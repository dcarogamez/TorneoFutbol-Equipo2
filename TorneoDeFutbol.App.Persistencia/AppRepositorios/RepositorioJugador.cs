using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia

{
    public class RepositorioJugador : IRepositorioJugador
    {
        private readonly AppContext _appContext  = new AppContext();;
        

        Jugador IRepositorioJugador.AddJugador (Jugador jugador) 

        {
            var jugadorAdicionado = _appContext.Jugadores.Add(jugador);
            _appContext.SaveChanges();
            return jugadorAdicionado.Entity;
        } 
         IEnumerable<Jugador> IRepositorioJugador.GetAllJugadores()
         {
             return _appContext.Jugadores;
         }
         public void DeleteJugador(int Id_Participante)
        {
            var jugadorEncontrado = _appContext.Jugadores.Find(Id_Participante);
            if (jugadorEncontrado == null)
                return;
            _appContext.Jugadores.Remove(jugadorEncontrado);
            _appContext.SaveChanges();
         }
         public Jugador GetJugador(int Id_Participante)
        {
            return _appContext.Jugadores.Find(Id_Participante);
        }
        

    }
}

