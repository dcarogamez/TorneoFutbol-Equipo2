using System;


namespace TorneoDeFutbol.App.Dominio
{
    public class Estadio
    {
        public  int Id { get;set; }
        public  string Nombre { get;set; }
        public  string Direccion { get;set; }
        public  Municipio municipio  { get;set; }
        
   
         }
}