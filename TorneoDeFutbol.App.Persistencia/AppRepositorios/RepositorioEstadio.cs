using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia

{
    public class RepositorioEstadio : IRepositorioEstadio
    {
        private readonly AppContext _appContext = new AppContext();
        

        Estadio IRepositorioEstadio.AddEstadio (Estadio estadio) 
        {
            var estadioAdicionado = _appContext.Estadios.Add(estadio);
            _appContext.SaveChanges();
            return estadioAdicionado.Entity;
        } 


<<<<<<< HEAD
         IEnumerable<Estadio> IRepositorioEstadio.GetAllEstadios()
=======
         IEnumerable<Estadio> IRepositorioEstadio.GetAllEstadio()
>>>>>>> f458938893f44dcbf05a35525142bec7e48681e0
         {
             return _appContext.Estadios;
         }


         public void DeleteEstadio(int idEstadio)
        {
            var estadioEncontrado = _appContext.Estadios.Find(idEstadio);
            if (estadioEncontrado == null)
                return;
            _appContext.Estadios.Remove(estadioEncontrado);
            _appContext.SaveChanges();
         }


         public Estadio GetEstadio(int idEstadio)
        {
            return _appContext.Estadios.Find(idEstadio);
        }


        Municipio IRepositorioEstadio.AsignarMunicipio(int idMunicipio, int idEstadio)
        {
            var estadioEncontrado = _appContext.Estadios.Find(idEstadio);
            if (estadioEncontrado != null)
            {
                var municipioEncontrado = _appContext.Municipios.Find(idMunicipio);
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
