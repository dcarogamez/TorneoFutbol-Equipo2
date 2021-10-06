using TorneoDeFutbol.App.Dominio;
using System.Collections.Generic;

namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioDirector
    
    {

        Director_Tecnico AddDirectorTecnico (Director_Tecnico directorTecnico);
<<<<<<< HEAD
        IEnumerable<Director_Tecnico> GetAllDirectoresTecnicos();
=======
        IEnumerable<Director_Tecnico> GetAllDirectorTecnico();
>>>>>>> f458938893f44dcbf05a35525142bec7e48681e0
        void DeleteDirectorTecnico(int Id_DirectorTecnico);
        Director_Tecnico GetDirectorTecnico(int Id_DirectorTecnico);
        
       

    }
}
