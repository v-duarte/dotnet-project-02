using Trabajo_02.Aplicacion.Entidades;
namespace Trabajo_02.Aplicacion.Interfaces;
public interface IRepositorioInscripcion{
    void AltaInscripcion (int estudiante, string curso);
    void BajaInscripcion (int estudiante, string curso);
    void ModificarInscripcion(Inscripcion inscripcionAct, Inscripcion inscripcionNew);
    List<Inscripcion> GetInscripciones();
    Inscripcion? GetInscripcion(int estudiante, string curso);
}