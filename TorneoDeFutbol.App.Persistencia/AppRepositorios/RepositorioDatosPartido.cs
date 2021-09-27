using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia

{
    public class RepositorioDatosPartido : IRepositorioDatosPartido
    {
        private readonly AppContext _appContext = new AppContext();
        

        DatosPartido IRepositorioDatosPartido.AddDatosPartido (DatosPartido datosPartido) 
        {
            var datosPartidoAdicionado = _appContext.Equipos.Add(equipo);
            _appContext.SaveChanges();
            return datosPartidoAdicionado.Entity;
        } 


         IEnumerable<DatosPartido> IRepositorioDatosPartido.GetAllDatosPartido()
         {
             return _appContext.DatosPartido;
         }


         public void DeleteDatosPartido(int Id_DatosPartido)
        {
            var datosPartidoEncontrado = _appContext.DatosPartido.Find(Id_DatosPartido);
            if (datosPartidoEncontrado == null)
                return;
            _appContext.DatosPartido.Remove(datosPartidoEncontrado);
            _appContext.SaveChanges();
         }

         public DatosPartido GetDatosPartido(int Id_DatosPartido)
        {
            return _appContext.DatosPartido.Find(Id_DatosPartido);
        }
        
            Arbitro IRepositorioDatosPartido.AsignarArbitro(int Id_Arbitro, int Id_DatosPartido)
        {
            var datosPartidoEncontrado = _appContext.DatosPartido.Find(Id_DatosPartido);
            if (datosPartidoEncontrado != null)
            {
                var abritroEncontrado = _appContext.Arbitro.Find(Id_Arbitro);
                if (abitroEncontrado != null)
                {
                    DatosPartidoEncontrado.arbitro = ArbitroEncontrado;
                    _appContext.SaveChanges();
                }
                return arbitroEncontrado;
            }
            return null;
        }

        Estadio IRepositorioDatosPartido.AsignarEstadio(int Id_Estadio, int Id_DatosPartido)
        {
            var datosPartidoEncontrado = _appContext.DatosPartido.Find(Id_DatosPartido);
            if (datosPartidoEncontrado != null)
            {
                var estadioEncontrado = _appContext.Estadio.Find(Id_Estadio);
                if (estadioEncontrado != null)
                {
                    DatosPartidoEncontrado.estadio = estadioEncontrado;
                    _appContext.SaveChanges();
                }
                return estadioEncontrado;
            }
            return null;
        }

        Equipo IRepositorioDatosPartido.AsignarEquipoLocal(int Id_Equipo, int Id_DatosPartido)
        {
            var datosPartidoEncontrado = _appContext.DatosPartido.Find(Id_DatosPartido);
            if (datosPartidoEncontrado != null)
            {
                var equipoEncontrado = _appContext.Equipo.Find(Id_Equipo);
                if (equipoEncontrado != null)
                {
                    DatosPartidoEncontrado.equipo = equipoEncontrado;
                    _appContext.SaveChanges();
                }
                return equipoEncontrado;
            }
            return null;
        }

        Equipo IRepositorioDatosPartido.AsignarEquipoVisitante(int Id_Equipo, int Id_DatosPartido)
        {
            var datosPartidoEncontrado = _appContext.DatosPartido.Find(Id_DatosPartido);
            if (datosPartidoEncontrado != null)
            {
                var equipoEncontrado = _appContext.Equipo.Find(Id_Equipo);
                if (equipoEncontrado != null)
                {
                    DatosPartidoEncontrado.equipo = equipoEncontrado;
                    _appContext.SaveChanges();
                }
                return equipoEncontrado;
            }
            return null;
        }

    }
}
