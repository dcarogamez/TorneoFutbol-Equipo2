using System;
namespace TorneoDeFutbol.App.Dominio
{
    public class Registro
    {
     public  int Partidos_Jugados { get;set; }
     public  int Partidos_Ganados{ get;set; }
     public  int  Partidos_Empatados { get;set; }
     public  int Puntos { get;set; }
     public  Equipo equipo { get;set; }
     public  Datos_Partido datos { get;set; }
          
     
    }