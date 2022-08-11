using Trabajo_02.Aplicacion.Entidades;
using Trabajo_02.Aplicacion.Interfaces;
namespace Trabajo_02.Repositorios;
public class RepositorioInscripcion : IRepositorioInscripcion
{
    RepositorioCurso rCurso = new RepositorioCurso();
    RepositorioEstudiante rEstudiante = new RepositorioEstudiante();
    public void AltaInscripcion(int estudiante, string curso)
    {
        using (var db = new Trabajo_02Context()){
            var consultaAlumno = rEstudiante.GetEstudiante(estudiante);
            var consultaCurso = rCurso.GetCurso(curso);
            if ((rCurso != null) && (rEstudiante != null)){
                var consultaInscripcion = GetInscripcion(estudiante, curso);
                if (consultaInscripcion == null){
                    Inscripcion i = new Inscripcion(estudiante, curso, DateTime.Today.ToShortDateString());
                    db.Inscripciones.Add(i);
                    db.SaveChanges();
                }
            }
        }
    }

    public void BajaInscripcion(int estudiante, string curso)
    {
        using (var db = new Trabajo_02Context()){
            var consulta = GetInscripcion(estudiante, curso);
            if (consulta != null){
                db.Inscripciones.Remove(consulta);
                db.SaveChanges();
            }
        }
    }

    public Inscripcion? GetInscripcion(int estudiante, string curso)
    {
        using (var db = new Trabajo_02Context()){
            var inscripcion = db.Inscripciones.Where(i => i.DNI == estudiante && i.Titulo == curso).FirstOrDefault<Inscripcion>();
            return inscripcion;
        }
    }

    public List<Inscripcion> GetInscripciones()
    {
        using (var db = new Trabajo_02Context()){
            List <Inscripcion> inscripciones = db.Inscripciones.ToList();
            return inscripciones;
        }
    }

    public void ModificarInscripcion(Inscripcion inscripcionAct, Inscripcion inscripcionNew)
    {
        BajaInscripcion(inscripcionAct.DNI, inscripcionAct.Titulo);
        AltaInscripcion(inscripcionNew.DNI, inscripcionNew.Titulo);
    }
}