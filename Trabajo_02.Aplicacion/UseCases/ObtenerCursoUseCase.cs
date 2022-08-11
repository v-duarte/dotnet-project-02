using Trabajo_02.Aplicacion.Entidades;
using Trabajo_02.Aplicacion.Interfaces;
namespace Trabajo_02.Aplicacion.UseCases;
public class ObtenerCursoUseCase{
    private readonly IRepositorioCurso _rCurso;

    public ObtenerCursoUseCase(IRepositorioCurso rCurso){
        _rCurso = rCurso;
    }

    public Curso? Ejecutar(string titulo){
        Curso? c = _rCurso.GetCurso(titulo);
        return c;
    }
}