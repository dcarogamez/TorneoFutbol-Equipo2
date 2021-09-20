using System;
namespace TorneoDeFutbol.App.Dominio
{
    public class Equipo
    {
        private int ID { get;set; }
        private string Nombre { get;set; }
        private Municipio municipio  { get;set; }
        private Jugador jugador  { get;set; }
        private Director_Tecnico director  { get;set; }
        private Registro registro  { get;set; }
        
   
         }
}