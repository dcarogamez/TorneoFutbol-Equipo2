using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia

{
    public class RepositorioArbitro : IRepositorioArbitro
    {
        private readonly AppContext _appContext = new AppContext(); 
        
        Arbitro IRepositorioArbitro.AddArbitro (Arbitro arbitro) 

        {
            var arbitroAdicionado = _appContext.Equipos.Add(equipo);
            _appContext.SaveChanges();
            return arbitroAdicionado.Entity;
        } 


         IEnumerable<Arbitro> IRepositorioArbitro.GetAllArbitro()
         {
             return _appContext.Arbitro;
         }


         public void DeleteArbitro(int Id_Arbitro)
        {
            var arbitroEncontrado = _appContext.Arbitro.Find(Id_Arbitro);
            if (arbitroEncontrado == null)
                return;
            _appContext.Arbitro.Remove(equipoArbitro);
            _appContext.SaveChanges();
         }


         public Arbitro GetArbitro(int Id_Arbitro)
        {
            return _appContext.Arbitro.Find(Id_Arbitro);
        }
        
        Arbitro IRepositorioArbitro.AsignarColegio(int Id_Colegio, int Id_Arbitro)
        {
            var arbitroEncontrado = _appContext.Arbitro.Find(Id_Arbitro);
            if (arbitroEncontrado != null)
            {
                var colegioEncontrado = _appContext.Colegio.Find(Id_Colegio);
                if (colegioEncontrado != null)
                {
                    arbitroEncontrado.colegio = colegioEncontrado;
                    _appContext.SaveChanges();
                }
                return colegioEncontrado;
            }
            return null;
        }
        

    }
}
