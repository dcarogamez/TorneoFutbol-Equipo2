using System;
namespace TorneoDeFutbol.App.Dominio
{
    public class Registro
    {
     private int Partidos_Jugados { get;set; }
     private int Partidos_Ganados{ get;set; }
     private int Partidos_Empatados { get;set; }
     private int Puntos { get;set; }
     private Equipo equipo { get;set; }
     private Datos_Partido datos { get;set; }
          
     
    }