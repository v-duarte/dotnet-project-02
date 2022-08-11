using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Trabajo_02.UI.Data;
using Microsoft.EntityFrameworkCore;

//agregamos estas directivas using
using Trabajo_02.Repositorios;
using Trabajo_02.Aplicacion.UseCases;
using Trabajo_02.Aplicacion.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

//agregamos estos servicios al contenedor DI

//servicios de curso
builder.Services.AddTransient<AltaCursoUseCase>();
builder.Services.AddTransient<BajaCursoUseCase>();
builder.Services.AddTransient<ModificarCursoUseCase>();
builder.Services.AddTransient<ListarCursosUseCase>();
builder.Services.AddTransient<ObtenerCursoUseCase>();
builder.Services.AddScoped<IRepositorioCurso, RepositorioCurso>();

//servicios de estudiante
builder.Services.AddTransient<AltaEstudianteUseCase>();
builder.Services.AddTransient<BajaEstudianteUseCase>();
builder.Services.AddTransient<ModificarEstudianteUseCase>();
builder.Services.AddTransient<ListarEstudiantesUseCase>();
builder.Services.AddTransient<ObtenerEstudianteUseCase>();
builder.Services.AddScoped<IRepositorioEstudiante, RepositorioEstudiante>();

//servicios de inscripciones
builder.Services.AddTransient<AltaInscripcionUseCase>();
builder.Services.AddTransient<BajaInscripcionUseCase>();
builder.Services.AddTransient<ModificarInscripcionUseCase>();
builder.Services.AddTransient<ListarInscripcionesUseCase>();
builder.Services.AddTransient<ObtenerInscripcionUseCase>();
builder.Services.AddScoped<IRepositorioInscripcion, RepositorioInscripcion>();

//base de datos
using (var db = new Trabajo_02Context()){
    db.Database.EnsureCreated();
    //se establece la propiedad journal mode de la base de datos sqlite en DELETE
    var connection = db.Database.GetDbConnection();
    connection.Open();
    using (var command = connection.CreateCommand())
    {   
        command.CommandText = "PRAGMA journal_mode=DELETE;";
        command.ExecuteNonQuery();
    }
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
