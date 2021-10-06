using System;
using System.ComponentModel.DataAnnotations;



namespace TorneoDeFutbol.App.Dominio
{
    public class Jugador: Participante
    {
<<<<<<< HEAD
        public int numCamiseta { get;set; }
        public Posicion posicion { get;set; }
=======
        
        public int numCamiseta { get;set; }
        public string posicion { get;set; }
>>>>>>> f458938893f44dcbf05a35525142bec7e48681e0
        public Participante participante  { get;set; }
    }
}