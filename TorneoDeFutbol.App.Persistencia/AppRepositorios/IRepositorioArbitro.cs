using TorneoDeFutbol.App.Dominio;
using System.Collections.Generic;

namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioArbitro
    
    {
        
        Arbitro AddArbitro (Arbitro arbitro);
<<<<<<< HEAD
        IEnumerable<Arbitro> GetAllArbitros();
=======
        IEnumerable<Arbitro> GetAllArbitro();
>>>>>>> f458938893f44dcbf05a35525142bec7e48681e0
        void DeleteArbitro (int Id_Arbitro);
        Arbitro GetArbitro(int Id_Arbitro);
        Colegio AsignarColegio (int Id_Arbitro, int Id_Colegio);

    }
}
