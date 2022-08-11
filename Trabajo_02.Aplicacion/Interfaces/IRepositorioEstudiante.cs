using Trabajo_02.Aplicacion.Entidades;
namespace Trabajo_02.Aplicacion.Interfaces;
public interface IRepositorioEstudiante{
    void AltaEstudiante (Estudiante estudiante);
    void BajaEstudiante (int dni);
    void ModificarEstudiante(Estudiante estudiante);
    List<Estudiante> GetEstudiantes();
    Estudiante? GetEstudiante(int dni);
}