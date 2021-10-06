using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Dominio;
using TorneoDeFutbol.App.Persistencia;

<<<<<<< HEAD
namespace TorneoDeFutbol.App.Frontend.pages.Jugadores
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioJugador _repoJugador;

        public Jugador jugador { get;set; }

        public DetailsModel(IRepositorioJugador repoJugador)
        {
            _repoJugador = repoJugador;
        }

        public IActionResult OnGet(int id)
        {
            jugador = _repoJugador.GetJugador(id);
            if(jugador == null)
=======
namespace TorneDeFutbol.App.Frontend.Pages.Jugadores
{
    public class DetailsModel : PageModel

    {
        private readonly IRepositorioJugador _repoJugador;
        public Jugador jugador {get; set;}        

         public DetailsModel (IRepositorioJugador repoJugador)
        {
        _repoJugador= repoJugador;

        }
        public IActionResult OnGet(int id)
        {
            jugador = _repoJugador.GetJugador(id);
            if (jugador == null)
>>>>>>> f458938893f44dcbf05a35525142bec7e48681e0
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
    }
<<<<<<< HEAD
}
=======

}    

>>>>>>> f458938893f44dcbf05a35525142bec7e48681e0
