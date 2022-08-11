using Trabajo_02.Aplicacion.Entidades;
using Trabajo_02.Aplicacion.Interfaces;
namespace Trabajo_02.Aplicacion.UseCases;
public class BajaEstudianteUseCase{
    private readonly IRepositorioEstudiante _rEstudiante;

    public BajaEstudianteUseCase(IRepositorioEstudiante rEstudiante){
        _rEstudiante = rEstudiante;
    }

    public void Ejecutar(int dni){
        _rEstudiante.BajaEstudiante(dni);
    }
}