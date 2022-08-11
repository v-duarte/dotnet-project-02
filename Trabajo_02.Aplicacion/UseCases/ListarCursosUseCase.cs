using Trabajo_02.Aplicacion.Entidades;
using Trabajo_02.Aplicacion.Interfaces;
namespace Trabajo_02.Aplicacion.UseCases;

public class ListarCursosUseCase{
    private readonly IRepositorioCurso _rCurso;

    public ListarCursosUseCase(IRepositorioCurso rCurso){
        _rCurso = rCurso;
    }

    public List<Curso> Ejecutar(){
       return _rCurso.GetCursos();
    }
}