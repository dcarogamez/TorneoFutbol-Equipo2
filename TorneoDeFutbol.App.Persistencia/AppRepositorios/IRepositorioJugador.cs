using TorneoDeFutbol.App.Dominio;
using System.Collections.Generic;

namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioJugador
    
    {
        Jugador AddJugador (Jugador jugador);
        IEnumerable<Jugador> GetAllJugadores();
        void DeleteJugador(int idJugador);
        Jugador GetJugador(int idJugador);
        
       

    }
}
