using System;
using System.ComponentModel.DataAnnotations;



namespace TorneoDeFutbol.App.Dominio
{
    public class Director_Tecnico: Participante
    {
        [Key]
        String aniosExperiencia ;
          
    }
}