using TorneoDeFutbol.App.Dominio;
using System.Collections.Generic;

namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioDatosPartido
    
    {
        
        Datos_Partido AddDatosPartido (Datos_Partido datosPartido);
<<<<<<< HEAD
        IEnumerable<Datos_Partido> GetAllDatosPartidos();
=======
        IEnumerable<Datos_Partido> GetAllDatosPartido();
>>>>>>> f458938893f44dcbf05a35525142bec7e48681e0
        void DeleteDatosPartido(int Id_DatosPartido);
        //????Datos_Partido GetDatosPartido(int Id_DatosPartido);
        Equipo GetEquipoVisitante (int Id_Equipo);
        Equipo GetEquipoLocal (int Id_Equipo);
        Arbitro AsignarArbitro (int Id_DatosPartido, int Id_Arbitro);
        Estadio AsignarEstadio (int Id_DatosPartido, int Id_Estadio);
        Equipo AsignarEquipoVisitante (int Id_DatosPartido, int Id_Equipo);
        Equipo AsignarEquipoLocal (int Id_DatosPartido , int Id_Equipo);

    }
}
