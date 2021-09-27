using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia

{
    public class RepositorioEstadio : IRepositorioEstadio
    {
        private readonly AppContext _appContext = new AppContext();
        

        Estadio IRepositorioEstadio.AddEstadio (Estadio estadio) 
        {
            var estadioAdicionado = _appContext.Estadio.Add(estadio);
            _appContext.SaveChanges();
            return estadioAdicionado.Entity;
        } 


         IEnumerable<Estadio> IRepositorioEstadio.GetAllEstadio()
         {
             return _appContext.Estadio;
         }


         public void DeleteEstadio(int Id_Estadio)
        {
            var estadioEncontrado = _appContext.Estadio.Find(Id_Estadio);
            if (estadioEncontrado == null)
                return;
            _appContext.Estadio.Remove(estadioEncontrado);
            _appContext.SaveChanges();
         }


         public Estadio GetEstadio(int Id_Estadio)
        {
            return _appContext.Estadio.Find(Id_Estadio);
        }


        Municipio IRepositorioEstadio.AsignarMunicipio(int Id_Municipio, int Id_Estadio)
        {
            var estadioEncontrado = _appContext.Estadio.Find(Id_Estadio);
            if (estadioEncontrado != null)
            {
                var municipioEncontrado = _appContext.Municipio.Find(Id_Municipio);
                if (municipioEncontrado != null)
                {
                    estadioEncontrado.municipio = municipioEncontrado;
                    _appContext.SaveChanges();
                }
                return municipioEncontrado;
            }
            return null;
        }

    }
}
