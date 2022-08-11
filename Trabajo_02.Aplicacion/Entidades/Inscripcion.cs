namespace Trabajo_02.Aplicacion.Entidades;
public class Inscripcion{
    public int Id { get; set; }
    public int DNI {get; set;}
    public string Titulo {get; set;}
    public string FechaDeInscripcion {get; set;}
    public Inscripcion (){
        this.DNI = 0;
        this.Titulo = "";
        this.FechaDeInscripcion = "";
    }
    public Inscripcion (int estudiante, string titulo, string fechaInscripcion){
        this.DNI = estudiante;
        this.Titulo = titulo;
        this.FechaDeInscripcion = fechaInscripcion;
    }
}