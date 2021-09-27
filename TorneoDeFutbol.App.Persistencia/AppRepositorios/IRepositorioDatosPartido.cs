using TorneoDeFutbol.App.Dominio;
using System.Collections.Generic;

namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioDatosPartido
    
    {
        
        DatosPartido AddDatosPartido (DatosPartido datospartido);
        IEnumerable<DatosPArtido> GetAllDatosPartido();
        void DeleteDatosPartido(int Id_DatosPartido);
        DatosPartido GetDatosPartido(int Id_DatosPartido);
        Equipo GetEquipoVisitante (int Id_Equipo);
        Equipo GetEquipoLocal (int Id_Equipo);
        Arbitro AsignarArbitro (int Id_DatosPartido, int Id_Arbitro);
        Estadio AsignarEstadio (int Id_DatosPartido, int Id_Estadio);
        Equipo AsignarEquipoVisitante (int Id_DatosPartido, int Id_Equipo);
        Equipo AsignarEquipoLocal (int Id_DatosPartido , int Id_Equipo);

    }
}
