using TorneoDeFutbol.App.Dominio;
using System.Collections.Generic;

namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioMunicipio
    
    {
        Municipio AddMunicipio (Municipio municipio);
<<<<<<< HEAD
         IEnumerable<Municipio> GetAllMunicipios();
=======
         IEnumerable<Municipio> GetAllMunicipio();
>>>>>>> f458938893f44dcbf05a35525142bec7e48681e0
        void DeleteMunicipio(int idMunicipio);
        Municipio GetMunicipio(int idMunicipio);
        
        
       

    }
}
