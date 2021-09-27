using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;
using System.Linq; 

namespace TorneoDeFutbol.App.Persistencia

{
    public class RepositorioParticipante : IRepositorioParticipante
    {
        private readonly AppContext _appContext  = new AppContext();;
        
        Participante IRepositorioParticipante.AddParticipante (Participante participante) 

        {
            var participanteAdicionado = _appContext.Participantes.Add(participante);
            _appContext.SaveChanges();
            return participanteAdicionado.Entity;
        } 
         IEnumerable<Participante> IRepositorioParticipante.GetAllParticipantes()
         {
             return _appContext.Participantes;
         }
         public void DeleteParticipante(int Id_Participante)
        {
            var participanteEncontrado = _appContext.Participantes.Find(Id_Participante);
            if (participanteEncontrado == null)
                return;
            _appContext.Participantes.Remove(participanteEncontrado);
            _appContext.SaveChanges();
         }
         public Participante GetParticipante(int Id_Participante)
        {
            return _appContext.Participantes.Find(Id_Participante);
        }
        public Participante UpdateParticipante(Participante participante)
        {
            var participanteEncontrado = _appContext.Participantes.Find(participante.Id_Participante);
            if (participanteEncontrado != null)
            {
                participanteEncontrado.Nombre = participante.Nombre;
                participanteEncontrado.Apellido = participante.Apellido;
                participanteEncontrado.Numero_Telefono = participante.Numero_Telefono;
                participanteEncontrado.Direccion = participante.Direccion;
                participanteEncontrado.Ciudad = participante.Ciudad;
                 _appContext.SaveChanges();
            }
            return participanteEncontrado;
        }

    }
}

