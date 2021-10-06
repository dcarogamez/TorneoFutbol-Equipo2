using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;
using System.Linq; 
<<<<<<< HEAD
using System;
=======
>>>>>>> f458938893f44dcbf05a35525142bec7e48681e0

namespace TorneoDeFutbol.App.Persistencia

{
    public class RepositorioParticipante : IRepositorioParticipante
    {
        private readonly AppContext _appContext  = new AppContext();
        
<<<<<<< HEAD
        Participante IRepositorioParticipante.AddParticipante(Participante participante) 
=======
        Participante IRepositorioParticipante.AddParticipante (Participante participante) 

>>>>>>> f458938893f44dcbf05a35525142bec7e48681e0
        {
            var participanteAdicionado = _appContext.Participantes.Add(participante);
            _appContext.SaveChanges();
            return participanteAdicionado.Entity;
        } 
<<<<<<< HEAD

=======
>>>>>>> f458938893f44dcbf05a35525142bec7e48681e0
         IEnumerable<Participante> IRepositorioParticipante.GetAllParticipantes()
         {
             return _appContext.Participantes;
         }
<<<<<<< HEAD
        
        
        public void DeleteParticipante(int idParticipante)
        {
            
            var participanteEncontrado = _appContext.Participantes.Find(idParticipante);
            
=======
         public void DeleteParticipante(int Id_Participante)
        {
            var participanteEncontrado = _appContext.Participantes.Find(Id_Participante);
>>>>>>> f458938893f44dcbf05a35525142bec7e48681e0
            if (participanteEncontrado == null)
                return;
            _appContext.Participantes.Remove(participanteEncontrado);
            _appContext.SaveChanges();
<<<<<<< HEAD

         }

        public Participante GetParticipante(int idParticipante)
        {
            return _appContext.Participantes.Find(idParticipante);
        }


        public Participante UpdateParticipante(Participante participante)
        {
            var participanteEncontrado = _appContext.Participantes.Find(participante.idParticipante);
            
            if (participanteEncontrado != null)
            {

=======
         }
         public Participante GetParticipante(int idParticipante)
        {
            return _appContext.Participantes.Find(idParticipante);
        }
        public Participante UpdateParticipante(Participante participante)
        {
            var participanteEncontrado = _appContext.Participantes.Find(participante.idParticipante);
            if (participanteEncontrado != null)
            {
>>>>>>> f458938893f44dcbf05a35525142bec7e48681e0
                participanteEncontrado.nombre = participante.nombre;
                participanteEncontrado.apellido = participante.apellido;
                participanteEncontrado.numeroTelefono = participante.numeroTelefono;
                participanteEncontrado.direccion = participante.direccion;
                participanteEncontrado.ciudad = participante.ciudad;
                 _appContext.SaveChanges();
            }
            return participanteEncontrado;
        }

    }
}

