using System;
namespace TorneoDeFutbol.App.Dominio
{
    public class Partido
    {
     public  int Id { get;set; }
     public  date Fecha { get;set; }
     public   date Hora { get;set; }
     public   bolean Equipo_Visitante { get;set; }
     public   bolean Equipo_Local { get;set; }
     public   int Marcador { get;set; }
     public   Estadio estadio { get;set; }
     
     
    }
}