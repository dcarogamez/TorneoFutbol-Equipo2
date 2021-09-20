using System;
namespace TorneoDeFutbol.App.Dominio
{
    public class Partido
    {
     private int Id { get;set; }
     private date Fecha { get;set; }
     private  date Hora { get;set; }
     private  bolean Equipo_Visitante { get;set; }
     private  bolean Equipo_Local { get;set; }
     private  int Marcador { get;set; }
     private  Estadio estadio { get;set; }
     
     
    }
}