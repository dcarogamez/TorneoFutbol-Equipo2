using TorneoDeFutbol.App.Dominio;
using System.Collections.Generic;

namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioColegio
    
    {
        Colegio AddColegio (Colegio colegio);
<<<<<<< HEAD
        IEnumerable<Colegio> GetAllColegios();
=======
        IEnumerable<Colegio> GetAllColegio();
>>>>>>> f458938893f44dcbf05a35525142bec7e48681e0
        void DeleteColegio(int Id_Colegio);
        Colegio GetColegio(int Id_Colegio);
    }
}
