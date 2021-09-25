using System;



namespace TorneoDeFutbol.App.Dominio
{
    public class DatosPartido
    {
     public  int Id_DatosPartido { get;set; }
     public  int Marcador { get;set; }
     public  int Tarjetas_Amarillas{ get;set; }
     public  int Tarjetas_Rojas { get;set; }
     public  int Goles_V { get;set; }
     public  int Goles_L { get;set; }
     public  int Tiempo { get;set; }
     public  Equipo equipo { get;set; }
     
          
     
    }
}