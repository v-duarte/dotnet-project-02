using Trabajo_02.Aplicacion.Entidades;
using Trabajo_02.Aplicacion.Interfaces;
namespace Trabajo_02.Aplicacion.UseCases;
public class ObtenerEstudianteUseCase{
    private readonly IRepositorioEstudiante _rEstudiante;

    public ObtenerEstudianteUseCase(IRepositorioEstudiante rEstudiante){
        _rEstudiante = rEstudiante;
    }

    public Estudiante? Ejecutar(int dni){
        Estudiante? e = _rEstudiante.GetEstudiante(dni);
        return e;
    }
}