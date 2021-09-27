using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia

{
    public class RepositorioEquipo : IRepositorioEquipo
    {
        private readonly AppContext _appContext  = new AppContext();;
        
        Equipo IRepositorioEquipo.AddEquipo (Equipo equipo) 

        {
            var equipoAdicionado = _appContext.Equipos.Add(equipo);
            _appContext.SaveChanges();
            return equipoAdicionado.Entity;
        } 
         IEnumerable<Equipo> IRepositorioEquipo.GetAllEquipos()
         {
             return _appContext.Equipos;
         }
         public void DeleteEquipo(int Id_Equipo)
        {
            var equipoEncontrado = _appContext.Equipos.Find(Id_Equipo);
            if (equipoEncontrado == null)
                return;
            _appContext.Equipos.Remove(equipoEncontrado);
            _appContext.SaveChanges();
         }
         public Equipo GetEquipo(int Id_Equipo)
        {
            return _appContext.Equipos.Find(Id_Equipo);
        }
        
        Jugador IRepositorioEquipo.AsignarJugador(int Id_Participante, int Id_Equipo)
        {
            var equipoEncontrado = _appContext.Equipos.Find(Id_Equipo);
            if (equipoEncontrado != null)
            {
                var jugadorEncontrado = _appContext.Jugadores.Find(Id_Participante);
                if (jugadorEncontrado != null)
                {
                    equipoEncontrado.jugador = jugadorEncontrado;
                    _appContext.SaveChanges();
                }
                return jugadorEncontrado;
            }
            return null;
        }
        
        Director_Tecnico IRepositorioEquipo.AsignarDirectorTecnico(int Id_DirectorTecnico, int Id_Equipo)
        {
            var equipoEncontrado = _appContext.Equipos.Find(Id_Equipo);
            if (equipoEncontrado != null)
            {
                var directorTecnicoEncontrado = _appContext.Director_Tecnico.Find(Id_DirectorTecnico);
                if (directorTecnicoEncontrado != null)
                {
                    equipoEncontrado.directorTecnico = directorTecnicoEncontrado;
                    _appContext.SaveChanges();
                }
                return directorTecnicoEncontrado;
            }
            return null;
        }


        Municipio IRepositorioEquipo.AsignarMunicipio(int Id_Municipio, int Id_Equipo)
        {
            var equipoEncontrado = _appContext.Equipos.Find(Id_Equipo);
            if (equipoEncontrado != null)
            {
                var municipioEncontrado = _appContext.Municipio.Find(Id_Municipio);
                if (municipioEncontrado != null)
                {
                    equipoEncontrado.municipio = municipioEncontrado;
                    _appContext.SaveChanges();
                }
                return municipioEncontrado;
            }
            return null;
        }

    }
}
