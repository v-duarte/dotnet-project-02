using Trabajo_02.Aplicacion.Entidades;
using Trabajo_02.Aplicacion.Interfaces;
namespace Trabajo_02.Aplicacion.UseCases;
public class ObtenerInscripcionUseCase{
    private readonly IRepositorioInscripcion _rInscripcion;

    public ObtenerInscripcionUseCase(IRepositorioInscripcion rInscripcion){
        _rInscripcion = rInscripcion;
    }

    public Inscripcion? Ejecutar(int estudiante, string curso){
        Inscripcion? i= _rInscripcion.GetInscripcion(estudiante, curso);
        return i;
    }
}