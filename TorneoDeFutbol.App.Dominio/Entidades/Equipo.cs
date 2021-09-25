using System;


namespace TorneoDeFutbol.App.Dominio
{
    public class Equipo
    {
        public  int Id { get;set; }
        public  string Nombre { get;set; }
        public Municipio municipio { get;set; }
        public Jugador jugador { get;set; }
        public Registro registro { get;set; }
        public Director_Tecnico directorTecnico { get;set; }

        

                
   
         }
}