using System;
using TorneoDeFutbol.App.Dominio;
using TorneoDeFutbol.App.Persistencia;

namespace TorneoDeFutbol.App.Consola
{    class Program
    {
        private static IRepositorioParticipante _repoParticipante = new RepositorioParticipante();
        private static IRepositorioJugador _repoJugador = new RepositorioJugador();
        private static IRepositorioEquipo _repoEquipo = new RepositorioEquipo();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Entity Framework");
            AddParticipante();
            //BuscarParticipante(1);
            // IndexParticipantes();
            //DeleteParticipante ();
            // AddJugador();
            // AddEquipo();
            //AsignarJugador();
                           
        }
            private static void AddParticipante()
            {
            var Participante = new Participante
            {
                numeroDocumento="588888",
                nombre = "Luis",
                apellido = "Rosero",
                direccion = "Calle 56 No 78-3",
                numeroTelefono = "8854455",
                ciudad = "Bogota"
                
            };

            _repoParticipante.AddParticipante(Participante);

            }
            
            private static void BuscarParticipante(int Id_Participante)
            {
                var participante =_repoParticipante.GetParticipante(Id_Participante);

                {
                   Console.WriteLine(participante.nombre + " "+ participante.apellido); 
                }
            }
            private static void IndexParticipantes()
            {
                foreach (var participante in _repoParticipante.GetAllParticipantes())
                {
                   Console.WriteLine(participante.nombre + " "+ participante.apellido); 
                }
            }
            private static void DeleteParticipante()
            {
                _repoParticipante.DeleteParticipante(5);
            }
             private static void AddJugador()
            {
            var Jugador = new Jugador
            {
                numeroDocumento="333333",
                nombre = "Juan ",
                apellido = "Lopez",
                direccion = "Calle 45 No 8-5",
                numeroTelefono = "845215",
                ciudad = "Bogota",
                numCamiseta = 6,
                posicion ="Defensa"
                
            };

            _repoJugador.AddJugador(Jugador);
            }

            private static void AddEquipo()
            {
            var Equipo = new Equipo
            {
                
                nombre = "Colombia",
                
                
            };
            

            _repoEquipo.AddEquipo(Equipo);

            }
            private static void AsignarJugador()
            {
                var jugador = _repoEquipo.AsignarJugador(4,1);
                Console.WriteLine(jugador.nombre + " "+ jugador.apellido);
            }
    
    }
}
