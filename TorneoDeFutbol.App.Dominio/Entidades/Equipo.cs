using System;
namespace TorneoDeFutbol.App.Dominio
{
    public class Equipo
    {
        public  int ID { get;set; }
        public  string Nombre { get;set; }
        public  Municipio municipio  { get;set; }
        public  Jugador jugador  { get;set; }
        public  Director_Tecnico director  { get;set; }
        public  Registro registro  { get;set; }
        
   
         }
}