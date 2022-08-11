using Trabajo_02.Aplicacion.Entidades;
using Trabajo_02.Aplicacion.Interfaces;
namespace Trabajo_02.Aplicacion.UseCases;
public class BajaCursoUseCase{
    private readonly IRepositorioCurso _rCurso;

    public BajaCursoUseCase(IRepositorioCurso rCurso){
        _rCurso = rCurso;
    }

    public void Ejecutar(string titulo){
        _rCurso.BajaCurso(titulo);
    }
}