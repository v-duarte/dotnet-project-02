using Trabajo_02.Aplicacion.Entidades;
namespace Trabajo_02.Aplicacion.Interfaces;
public interface IRepositorioCurso{
    void AltaCurso (Curso curso);
    void BajaCurso (string titulo);
    void ModificarCurso(Curso curso);
    List<Curso> GetCursos();
    Curso? GetCurso(string titulo);
}