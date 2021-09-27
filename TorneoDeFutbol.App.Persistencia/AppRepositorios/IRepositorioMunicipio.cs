using TorneoDeFutbol.App.Dominio;
using System.Collections.Generic;

namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioMunicipio
    
    {
        Municipio AddMunicipio (Municipio municipio);
         IEnumerable<Municipio> GetAllMunicipio();
        void DeleteMunicipio(int Id_Municipio);
        Equipo GetMunicipio(int Id_Municipio);
        
        
       

    }
}
