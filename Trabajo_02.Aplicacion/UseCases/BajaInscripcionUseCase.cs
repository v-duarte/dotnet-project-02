using Trabajo_02.Aplicacion.Entidades;
using Trabajo_02.Aplicacion.Interfaces;
namespace Trabajo_02.Aplicacion.UseCases;
public class BajaInscripcionUseCase{
    private readonly IRepositorioInscripcion _rInscripcion;

    public BajaInscripcionUseCase(IRepositorioInscripcion rInscripcion){
        _rInscripcion = rInscripcion;
    }

    public void Ejecutar(int estudiante, string curso){
        _rInscripcion.BajaInscripcion(estudiante, curso);
    }
}