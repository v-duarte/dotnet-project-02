using Trabajo_02.Aplicacion.Entidades;
using Trabajo_02.Aplicacion.Interfaces;
namespace Trabajo_02.Aplicacion.UseCases;
public class ModificarInscripcionUseCase{
    private readonly IRepositorioInscripcion _rInscripcion;

    public ModificarInscripcionUseCase(IRepositorioInscripcion rInscripcion){
        _rInscripcion = rInscripcion;
    }

    public void Ejecutar(Inscripcion inscripcionAct, Inscripcion inscripcionNew){
        _rInscripcion.ModificarInscripcion(inscripcionAct, inscripcionNew);
    }
}