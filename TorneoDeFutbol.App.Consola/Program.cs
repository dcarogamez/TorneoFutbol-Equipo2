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
        {Console.WriteLine("Hello World Entity Framework");
            
            //AddParticipante();
            //BuscarParticipante();
            //IndexParticipantes();
            //DeleteParticipante();
            AddJugador();
            //DeleteJugador();
            //AddEquipo();
            //DeleteEquipo();
            //AsignarJugador();
        }

            //Método para AÑADIR PARTICIPANTE ***************************************************
            private static void AddParticipante()
            {
            var Participante = new Participante
            {
                numeroDocumento="11111",
                nombre = "Pedro",
                apellido = "Flores",
                direccion = "Calle 58 No 5-15",
                numeroTelefono = "854576",
                ciudad = "Pereira"
                
            };
             _repoParticipante.AddParticipante(Participante);
            }
            //Metodo para AÑADIR JUGADOR**********************************************************
            private static void AddJugador()
            {
                var Jugador = new Jugador
                {
                    
                    numeroDocumento="54321",
                    nombre = "Genaro",
                    apellido = "Gatusso",
                    direccion = "Cicilia",
                    numeroTelefono = "+18 0180003060",
                    ciudad = "Turín",
                    //genero = (Genero)Enum.Parse(typeof(Genero), "Pansexual"),
                    numCamiseta = 2,
                    fechaNacimiento = Convert.ToDateTime("31/01/1984"),
                    //posicion = (Posicion)Enum.Parse(typeof(Posicion), "DefensaLibero")
                };
                _repoJugador.AddJugador(Jugador);
            }

            //Método ELIMINAR Participante**********************************************************
            private static void DeleteParticipante()
            {
                _repoParticipante.DeleteParticipante(1016);
            }

            //Método ELIMINAR Jugador***************************************************************
            private static void DeleteJugador()
            {
                _repoJugador.DeleteJugador(1011);
            }



            private static void BuscarParticipante()
            {
                int idParticipante = 10;
                var participante =_repoParticipante.GetParticipante(idParticipante);
                if(participante == null)
                {
                    Console.WriteLine("No existe");
                }
                else
                {
                    Console.WriteLine("Si existe");
                }
                /*{
                   Console.WriteLine(participante.nombre + " "+ participante.apellido); 
                }*/
            }

            private static void IndexParticipantes()
            {
                foreach (var participante in _repoParticipante.GetAllParticipantes())
                {
                   Console.WriteLine(participante.nombre + " "+ participante.apellido); 
                }
            }
            

            private static void AddEquipo()
            {
                var Equipo = new Equipo
                    {
                     nombre = "Millonarios",
                    };
                _repoEquipo.AddEquipo(Equipo);

            }

            private static void DeleteEquipo()
            {
                _repoEquipo.DeleteEquipo(5);
            }

            
            private static void AsignarJugador()
            {
                var jugador = _repoEquipo.AsignarJugador(4,1);
                Console.WriteLine(jugador.nombre + " "+ jugador.apellido);
            }
    
    }
}
