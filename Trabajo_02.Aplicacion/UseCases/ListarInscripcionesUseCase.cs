using Trabajo_02.Aplicacion.Entidades;
using Trabajo_02.Aplicacion.Interfaces;
namespace Trabajo_02.Aplicacion.UseCases;
public class ListarInscripcionesUseCase{
    private readonly IRepositorioInscripcion _rInscripcion;
    public ListarInscripcionesUseCase(IRepositorioInscripcion rInscripcion){
        _rInscripcion = rInscripcion;
    }
    public List<Inscripcion> Ejecutar(){
        return _rInscripcion.GetInscripciones();
    }
}