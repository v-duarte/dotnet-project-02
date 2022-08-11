using Microsoft.EntityFrameworkCore;
using Trabajo_02.Aplicacion.Entidades;

namespace Trabajo_02.Repositorios;
public class Trabajo_02Context : DbContext
{
    #nullable disable
    public DbSet<Estudiante> Alumnos { get; set; }
    public DbSet<Curso> Cursadas { get; set; }
    public DbSet<Inscripcion> Inscripciones { get; set; }
    #nullable enable
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("data source=Trabajo_02.sqlite");
    }
    // protected override void OnModelCreating(ModelBuilder modelBuilder){
    //     base.OnModelCreating(ModelBuilder modelBuilder);
    // }
}