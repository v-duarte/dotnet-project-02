namespace Trabajo_02.Aplicacion.Entidades;
public class Estudiante : Persona{
    public int Id { get; set; }
    public string Mail {get; set;} = "";

    public Estudiante(): base(0, "", ""){}
    public Estudiante (int dni, string apellido, string nombre, string mail) : base(dni, apellido, nombre){
        
        this.Mail = mail;  
    }

    public override string ToString()    
    {
        return base.ToString() + $"\nMail: {Mail}";    
    }  
}