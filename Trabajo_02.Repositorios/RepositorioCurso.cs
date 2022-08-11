using Trabajo_02.Aplicacion.Entidades;
using Trabajo_02.Aplicacion.Interfaces;
namespace Trabajo_02.Repositorios;
public class RepositorioCurso : IRepositorioCurso
{
        public void AltaCurso(Curso curso)
        {
            using (var db = new Trabajo_02Context()){
                var consulta = GetCurso(curso.Titulo); //Reviso si no hay un curso con el mismo nombre
                if (consulta == null){ //Si no se encontro ninguno, se agrega a la base de datos
                    db.Cursadas.Add(curso);
                    db.SaveChanges();
                }
            }
        }

        public void BajaCurso(string titulo)
        {
            using (var db = new Trabajo_02Context()){
                var consulta = GetCurso(titulo); //Reviso si no hay un curso con el mismo nombre
                if (consulta != null){
                    db.Cursadas.Remove(consulta);
                    db.SaveChanges();
                }
            }
        }

        public Curso? GetCurso(string titulo)
        {
            using (var db = new Trabajo_02Context()){
                var curso = db.Cursadas.Where(c => c.Titulo == titulo).FirstOrDefault<Curso>();
                return curso;
            }
        }

        public List<Curso> GetCursos()
        {
            using (var db = new Trabajo_02Context()){
                List<Curso> cursos = db.Cursadas.ToList();
                return cursos;
            }
        }

        public void ModificarCurso(Curso curso)
        {
            BajaCurso(curso.Titulo);
            AltaCurso(curso);
        }
}