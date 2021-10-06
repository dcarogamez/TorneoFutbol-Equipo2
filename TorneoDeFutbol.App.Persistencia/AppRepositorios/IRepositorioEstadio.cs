using TorneoDeFutbol.App.Dominio;
using System.Collections.Generic;

namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioEstadio
    
    {

        Estadio AddEstadio (Estadio estadio);
<<<<<<< HEAD
        IEnumerable<Estadio> GetAllEstadios();
=======
        IEnumerable<Estadio> GetAllEstadio();
>>>>>>> f458938893f44dcbf05a35525142bec7e48681e0
        void DeleteEstadio(int Id_Estadio);
        Estadio GetEstadio (int Id_Estadio);
        Municipio AsignarMunicipio (int Id_Estadio, int Id_Municipio);

    }
}
