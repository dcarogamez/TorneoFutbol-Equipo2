using System;



namespace TorneoDeFutbol.App.Dominio

{
    public class Partido
    {
     public   int Id_Partido { get;set; }
     public   DateTime Fecha { get;set; }
     public   DateTime Hora { get;set; }
     public   bool EquipoVisitante { get;set; }
     public   bool EquipoLocal { get;set; }
     public   int GolesLocal { get;set; }
     public   int GolesVisitante { get;set; }
     public   int Marcador { get;set; }
     public   Estadio estadio { get;set; }
     public   Equipo equipo  { get;set; }
     public   DatosPartido datospartido  { get;set; }
     public   Arbitro arbitro  { get;set; }
     
     


  
  

    }
}