using System;
namespace TorneoDeFutbol.App.Dominio
{
    public class Datos_Partido
    {
     public int Marcador { get;set; }
     public  int Tarjetas_Amarillas{ get;set; }
     public   int Tarjetas_Rojas { get;set; }
     public   int Goles_V { get;set; }
     public   int Goles_L { get;set; }
     public   date Tiempo { get;set; }
     public   Jugador jugador { get;set; }
     public  Partido partido { get;set; }
          
     
    }