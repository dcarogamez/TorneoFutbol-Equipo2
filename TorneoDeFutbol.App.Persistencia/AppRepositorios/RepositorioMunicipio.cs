using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia

{
    public class RepositorioMunicipio : IRepositorioMunicipio
    {
        private readonly AppContext _appContext = new AppContext();

        Municipio IRepositorioMunicipio.AddMunicipio (Municipio municipio) 

        {
            var municipioAdicionado = _appContext.Municipio.Add(municipio);
            _appContext.SaveChanges();
            return municipioAdicionado.Entity;
        } 


         IEnumerable<Municipio> IRepositorioMunicipio.GetAllMunicipio()
         {
             return _appContext.Municipio;
         }



         public void DeleteMunicipio(int Id_Municipio)
        {
            var municipioEncontrado = _appContext.Municipio.Find(Id_Municipio);
            if (municipioEncontrado == null)
                return;
            _appContext.Municipio.Remove(municipioEncontrado);
            _appContext.SaveChanges();
         }



         public Equipo GetMunicipio(int Id_Municipio)
        {
            return _appContext.Municipio.Find(Id_Municipio);
        }

    }
}
