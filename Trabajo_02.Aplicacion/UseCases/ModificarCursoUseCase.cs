using Trabajo_02.Aplicacion.Entidades;
using Trabajo_02.Aplicacion.Interfaces;
namespace Trabajo_02.Aplicacion.UseCases;
public class ModificarCursoUseCase{
    private readonly IRepositorioCurso _rCurso;

    public ModificarCursoUseCase(IRepositorioCurso rCurso){
        _rCurso = rCurso;
    }

    public void Ejecutar(Curso curso){
        _rCurso.ModificarCurso(curso);
    }
}