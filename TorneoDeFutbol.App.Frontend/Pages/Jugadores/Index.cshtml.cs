using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Dominio;
using TorneoDeFutbol.App.Persistencia;

<<<<<<< HEAD
namespace TorneoDeFutbol.App.Frontend.Pages.Jugadores
=======
namespace TorneDeFutbol.App.Frontend.Pages.Jugadores
>>>>>>> f458938893f44dcbf05a35525142bec7e48681e0
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioJugador _repoJugador;
<<<<<<< HEAD
        
        public IEnumerable<Jugador> jugadores {get; set;}
        
        public IndexModel(IRepositorioJugador repoJugador)
        {
            _repoJugador = repoJugador;
=======

        public IEnumerable<Jugador> jugadores {get; set;}

        public IndexModel(IRepositorioJugador repoJugador)
        {
        _repoJugador= repoJugador;

>>>>>>> f458938893f44dcbf05a35525142bec7e48681e0
        }

        public void OnGet()
        {
            jugadores = _repoJugador.GetAllJugadores();
        }
    }
}
