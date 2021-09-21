using System;
namespace TorneoDeFutbol.App.Dominio
{
    public class Partido
    {
     public   int Id { get;set; }
     public   int Fecha { get;set; }
     public   int Hora { get;set; }
     public   bool Equipo_Visitante { get;set; }
     public   bool Equipo_Local { get;set; }
     public   int Marcador { get;set; }
     public   Estadio estadio { get;set; }
     
     
    }
}