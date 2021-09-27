using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioParticipante
    
    {
        Participante AddParticipante (Participante participante);
         IEnumerable<Participante> GetAllParticipantes();
        void DeleteParticipante(int Id_Participante);
        Participante GetParticipante(int Id_Participante);
        Participante UpdateParticipante(Participante participante);
        Jugador AsignarJugador (int Id_Participante, int Id_Participante);
        
       

    }
}
