using Trabajo_02.Aplicacion.Entidades;
using Trabajo_02.Aplicacion.Interfaces;
namespace Trabajo_02.Aplicacion.UseCases;
public class AltaEstudianteUseCase{
    private readonly IRepositorioEstudiante _rEstudiante;

    public AltaEstudianteUseCase(IRepositorioEstudiante rEstudiante){
        _rEstudiante = rEstudiante;
    }

    public void Ejecutar(Estudiante estudiante){
        _rEstudiante.AltaEstudiante(estudiante);
    }
}