namespace Trabajo_02.Aplicacion.Entidades;
public class Curso{
    public int Id { get; set; }

    public string Titulo {get; set;} = "" ;
    public string Descripcion {get; set;} = "" ;
    //para trabajar en sqlite, los datetime tienen que pasar a un string
    public string FechaDeInicio {get; set;} = "" ;
    public string FechaDeFinalizacion {get; set;} = "" ;

    public Curso (){}
    public Curso (string titulo, string descripcion, string fechaInicio, string fechaFinalizacion){
        this.Titulo = titulo;
        this.Descripcion = descripcion;
        this.FechaDeInicio = fechaInicio;
        this.FechaDeFinalizacion = fechaFinalizacion;
    }
}