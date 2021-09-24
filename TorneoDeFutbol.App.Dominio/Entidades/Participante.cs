using System;
namespace TorneoDeFutbol.App.Dominio
{
    public class Participante
    {
     public int Id { get;set; }
     public string Nombre { get;set; }
     public string NumeroDocumento { get;set; }
     public string TipoDocumento_Id { get;set; }
     public string Equipo_Id { get;set; }
   
    }
}