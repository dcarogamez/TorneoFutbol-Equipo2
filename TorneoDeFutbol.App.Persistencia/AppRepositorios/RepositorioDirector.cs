using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia

{
    public class RepositorioDirector : IRepositorioDirector
    {
        private readonly AppContext _appContext = new AppContext();

        Director_Tecnico IRepositorioDirector.AddDirectorTecnico (Director_Tecnico director) 
        {
            var directorAdicionado = _appContext.DirectoresTecnicos.Add(director);
            _appContext.SaveChanges();
            return directorAdicionado.Entity;
        } 

         IEnumerable<Director_Tecnico> IRepositorioDirector.GetAllDirectorTecnico()
         {
             return _appContext.DirectoresTecnicos;
         }
        public void DeleteDirectorTecnico(int Id_DirectorTecnico)
        {
            var directorTecnicoEncontrado = _appContext.DirectoresTecnicos.Find(Id_DirectorTecnico);
            if (directorTecnicoEncontrado == null)
                return;
            _appContext.DirectoresTecnicos.Remove(directorTecnicoEncontrado);
            _appContext.SaveChanges();
         }


        public Director_Tecnico GetDirectorTecnico(int Id_DirectorTecnico)
        {
            return _appContext.DirectoresTecnicos.Find(Id_DirectorTecnico);
        }
                

    }
}
