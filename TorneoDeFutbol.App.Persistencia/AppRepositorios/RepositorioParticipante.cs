using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;
using System.Linq; 
using System;

namespace TorneoDeFutbol.App.Persistencia

{
    public class RepositorioParticipante : IRepositorioParticipante
    {
        private readonly AppContext _appContext  = new AppContext();
        
        Participante IRepositorioParticipante.AddParticipante(Participante participante) 
        {
            var participanteAdicionado = _appContext.Participantes.Add(participante);
            _appContext.SaveChanges();
            return participanteAdicionado.Entity;
        } 

         IEnumerable<Participante> IRepositorioParticipante.GetAllParticipantes()
         {
             return _appContext.Participantes;
         }
        
        
        public void DeleteParticipante(int idParticipante)
        {
            
            var participanteEncontrado = _appContext.Participantes.Find(idParticipante);
            
            if (participanteEncontrado == null)
                return;
            _appContext.Participantes.Remove(participanteEncontrado);
            _appContext.SaveChanges();

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

