using System;
using System.ComponentModel.DataAnnotations;


namespace TorneoDeFutbol.App.Dominio
{
    /// <summary>
    /// Lista de Colegio
    /// </summary>

    public class Colegio
    {
        [Key]
        public int idColegio { get;set; }
        public string nombre { get;set; }
        
    }
}