using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia

{
    public class RepositorioDirector : IRepositorioDirector
    {
        private readonly AppContext _appContext = new AppContext();

        Director IRepositorioDirector.AddDirectorTecnico (Director director) 

        {
            var directorAdicionado = _appContext.Director.Add(director);
            _appContext.SaveChanges();
            return directorAdicionado.Entity;
        } 
         IEnumerable<DirectorTecnico> IRepositorioDirector.GetAllDirectorTecnico()
         {
             return _appContext.Director;
         }
         public void DeleteDirectorTecnico(int Id_DirectorTecnico)
        {
            var directorTecnicoEncontrado = _appContext.Director.Find(Id_DirectorTecnico);
            if (directorTecnicoEncontrado == null)
                return;
            _appContext.Director.Remove(directorTecnicoEncontrado);
            _appContext.SaveChanges();
         }


         public Director_Tecnico GetDirectorTecnico(int Id_DirectorTecnico)
        {
            return _appContext.Director.Find(Id_DirectorTecnico);
        }
                

    }
}
