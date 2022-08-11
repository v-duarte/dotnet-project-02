using Trabajo_02.Aplicacion.Entidades;
using Trabajo_02.Aplicacion.Interfaces;
namespace Trabajo_02.Aplicacion.UseCases;
public class AltaInscripcionUseCase{
    private readonly IRepositorioInscripcion _rInscripcion;

    public AltaInscripcionUseCase(IRepositorioInscripcion rInscripcion){
        _rInscripcion = rInscripcion;
    }

    public void Ejecutar(int estudiante, string curso){
        _rInscripcion.AltaInscripcion(estudiante, curso);
    }
}