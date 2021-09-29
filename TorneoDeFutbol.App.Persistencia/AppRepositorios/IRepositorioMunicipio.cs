using TorneoDeFutbol.App.Dominio;
using System.Collections.Generic;

namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioMunicipio
    
    {
        Municipio AddMunicipio (Municipio municipio);
         IEnumerable<Municipio> GetAllMunicipio();
        void DeleteMunicipio(int idMunicipio);
        Municipio GetMunicipio(int idMunicipio);
        
        
       

    }
}
