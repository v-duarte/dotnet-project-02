using Trabajo_02.Aplicacion.Entidades;
using Trabajo_02.Aplicacion.Interfaces;
namespace Trabajo_02.Aplicacion.UseCases;
public class AltaCursoUseCase{
    private readonly IRepositorioCurso _rCurso;

    public AltaCursoUseCase(IRepositorioCurso rCurso){
        _rCurso = rCurso;
    }

    public void Ejecutar(Curso curso){
        _rCurso.AltaCurso(curso);
    }
}
