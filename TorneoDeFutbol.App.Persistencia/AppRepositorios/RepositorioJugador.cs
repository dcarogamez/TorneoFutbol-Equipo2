using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia

{
    public class RepositorioJugador : IRepositorioJugador
    {
        private readonly AppContext _appContext  = new AppContext();
        
<<<<<<< HEAD
        Jugador IRepositorioJugador.AddJugador (Jugador jugador)
=======

        Jugador IRepositorioJugador.AddJugador (Jugador jugador) 

>>>>>>> f458938893f44dcbf05a35525142bec7e48681e0
        {
            var jugadorAdicionado = _appContext.Jugadores.Add(jugador);
            _appContext.SaveChanges();
            return jugadorAdicionado.Entity;
        } 
<<<<<<< HEAD

        IEnumerable<Jugador> IRepositorioJugador.GetAllJugadores()
         {
             return _appContext.Jugadores;
         }

        //Método Eliminar Jugador
        public void DeleteJugador(int idJugador)
        {

            var jugadorEncontrado = _appContext.Jugadores.Find(idJugador);
            if (jugadorEncontrado == null)
            {return;}
            else
            {
            _appContext.Jugadores.Remove(jugadorEncontrado);
            _appContext.SaveChanges();
            }
        }

        public Jugador GetJugador(int Id_Participante)
=======
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
>>>>>>> f458938893f44dcbf05a35525142bec7e48681e0
        {
            return _appContext.Jugadores.Find(Id_Participante);
        }
        

    }
}

