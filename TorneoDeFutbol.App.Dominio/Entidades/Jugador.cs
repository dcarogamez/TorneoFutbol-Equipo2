using System;


namespace TorneoDeFutbol.App.Dominio
{
    public class Jugador: Participante
    {
        public int NumCamiseta { get;set; }
        public string Posicion { get;set; }
        public Participante participante  { get;set; }
        
   
         }
}