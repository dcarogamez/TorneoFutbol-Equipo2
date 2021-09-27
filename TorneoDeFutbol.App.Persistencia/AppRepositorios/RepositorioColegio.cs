using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia

{
    public class RepositorioColegio : IRepositorioColegio
    {
        private readonly AppContext _appContext = new AppContext(); 

        Equipo IRepositorioColegio.AddColegio (Colegio colegio) 
        {
            var colegioAdicionado = _appContext.Colegio.Add(colegio);
            _appContext.SaveChanges();
            return colegioAdicionado.Entity;
        } 


         IEnumerable<Colegio> IRepositorioColegio.GetAllColegio()
         {
             return _appContext.Colegio;
         }


         public void DeleteColegio(int Id_Colegio)
        {
            var colegioEncontrado = _appContext.Colegio.Find(Id_Colegio);
            if (colegioEncontrado == null)
                return;
            _appContext.Colegio.Remove(colegioEncontrado);
            _appContext.SaveChanges();
         }


         public Equipo GetColegio(int Id_Colegio)
        {
            return _appContext.Colegio.Find(Id_Colegio);
        }
        
        
        

    }
}
