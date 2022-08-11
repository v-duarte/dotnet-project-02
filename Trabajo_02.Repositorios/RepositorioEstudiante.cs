using Trabajo_02.Aplicacion.Entidades;
using Trabajo_02.Aplicacion.Interfaces;
namespace Trabajo_02.Repositorios;
public class RepositorioEstudiante : IRepositorioEstudiante
{
    public void AltaEstudiante(Estudiante estudiante)
    {
        using (var db = new Trabajo_02Context()){
            var consulta = GetEstudiante(estudiante.DNI);
            if (consulta == null){ //Si no se encontro ninguno, se agrega a la base de datos
                    db.Alumnos.Add(estudiante);
                    db.SaveChanges();
            }
            else{
                throw new Exception ($"El Estudiante con DNI {estudiante.DNI} ya existe en la base de datos.");
            }
        }
    }

    public void BajaEstudiante(int dni)
    {
        using (var db = new Trabajo_02Context()){
            var consulta = GetEstudiante(dni);
            if (consulta != null){ //Si no se encontro ninguno, se agrega a la base de datos
                    db.Alumnos.Remove(consulta);
                    db.SaveChanges();
            }
        }
    }

    public Estudiante? GetEstudiante(int dni)
    {
        using (var db = new Trabajo_02Context()){
            var estudiante = db.Alumnos.Where(e => e.DNI == dni).FirstOrDefault<Estudiante>();
            return estudiante;
        }
    }

    public List<Estudiante> GetEstudiantes()
    {
        using (var db = new Trabajo_02Context()){
            List <Estudiante> estudiantes = db.Alumnos.ToList();
            return estudiantes;
        }
    }

    public void ModificarEstudiante(Estudiante estudiante)
    {
        BajaEstudiante(estudiante.DNI);
        AltaEstudiante(estudiante);
    }
}