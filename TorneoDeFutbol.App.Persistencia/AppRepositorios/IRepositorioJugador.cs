using TorneoDeFutbol.App.Dominio;
using System.Collections.Generic;

namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioJugador
    
    {
        Jugador AddJugador (Jugador jugador);
<<<<<<< HEAD
        IEnumerable<Jugador> GetAllJugadores();
        void DeleteJugador(int idJugador);
        Jugador GetJugador(int idJugador);
=======
         IEnumerable<Jugador> GetAllJugadores();
        void DeleteJugador(int Id);
        Jugador GetJugador(int Id);
>>>>>>> f458938893f44dcbf05a35525142bec7e48681e0
        
       

    }
}
