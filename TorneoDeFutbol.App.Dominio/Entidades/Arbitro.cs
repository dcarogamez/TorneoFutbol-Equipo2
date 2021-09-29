using System;
//using System.ComponentModel.DataAnnotations;


namespace TorneoDeFutbol.App.Dominio
{
    public class Arbitro: Participante
    {

        //[Key]
        public  int idArbitro { get;set; }
        public Colegio colegio { get;set; }
        public Participante participante{ get;set;}
           
        }
}