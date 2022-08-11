using Trabajo_02.Aplicacion.Entidades;
using Trabajo_02.Aplicacion.Interfaces;
namespace Trabajo_02.Aplicacion.UseCases;

public class ListarEstudiantesUseCase{
    private readonly IRepositorioEstudiante _rEstudiante;

    public ListarEstudiantesUseCase(IRepositorioEstudiante rEstudiante){
        _rEstudiante = rEstudiante;
    }
    public List<Estudiante> Ejecutar(){
        return _rEstudiante.GetEstudiantes();
    }
}