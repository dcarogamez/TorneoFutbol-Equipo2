using System;
namespace TorneoDeFutbol.App.Dominio
{
    public class Registro
    {
     public  int Partidos_Jugados { get;set; }
     public  int Partidos_Ganados{ get;set; }
     public  int  Partidos_Empatados { get;set; }
     public  int Puntos { get;set; }
     public  DatosPartido datos { get;set; }
          
     
    }
}