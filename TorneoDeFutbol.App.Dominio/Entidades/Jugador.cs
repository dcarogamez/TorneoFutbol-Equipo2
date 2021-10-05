using System;
using System.ComponentModel.DataAnnotations;



namespace TorneoDeFutbol.App.Dominio
{
    public class Jugador: Participante
    {
        public int numCamiseta { get;set; }
        public Posicion posicion { get;set; }
        public Participante participante  { get;set; }
    }
}