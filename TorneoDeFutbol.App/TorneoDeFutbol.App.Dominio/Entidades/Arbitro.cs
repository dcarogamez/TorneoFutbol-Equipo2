using System;
using System.ComponentModel.DataAnnotations;


namespace TorneoDeFutbol.App.Dominio
{
    public class Arbitro: Participante
    {
        [Key]
        public Colegio colegio { get;set; }
           
    }
}