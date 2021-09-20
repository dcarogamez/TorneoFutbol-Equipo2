using System;
namespace TorneoDeFutbol.App.Dominio
{
    public class Datos_Partido
    {
     private int Marcador { get;set; }
     private int Tarjetas_Amarillas{ get;set; }
     private  int Tarjetas_Rojas { get;set; }
     private  int Goles_V { get;set; }
     private  int Goles_L { get;set; }
     private  date Tiempo { get;set; }
     private  Jugador jugador { get;set; }
     private Partido partido { get;set; }
          
     
    }