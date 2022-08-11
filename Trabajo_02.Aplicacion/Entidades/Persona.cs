namespace Trabajo_02.Aplicacion.Entidades;
public abstract class Persona
{
    public string Nombre {get; set;}
    public string Apellido {get; set;}
    public int DNI {get; set;}
    protected Persona (int dni, string apellido, string nombre){
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.DNI = dni;
    }

    public override string ToString()
    {
         return $"DNI: {DNI} \nApellido: {Apellido} \nNombre: {Nombre} \n";
    }
}