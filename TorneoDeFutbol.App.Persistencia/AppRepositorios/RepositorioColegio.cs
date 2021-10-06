using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia

{
    public class RepositorioColegio : IRepositorioColegio
    {
        private readonly AppContext _appContext = new AppContext(); 

        Colegio IRepositorioColegio.AddColegio (Colegio colegio) 
        {
            var colegioAdicionado = _appContext.Colegios.Add(colegio);
            _appContext.SaveChanges();
            return colegioAdicionado.Entity;
        } 


<<<<<<< HEAD
         IEnumerable<Colegio> IRepositorioColegio.GetAllColegios()
=======
         IEnumerable<Colegio> IRepositorioColegio.GetAllColegio()
>>>>>>> f458938893f44dcbf05a35525142bec7e48681e0
         {
             return _appContext.Colegios;
         }


        public void DeleteColegio(int Id_Colegio)
        {
            var colegioEncontrado = _appContext.Colegios.Find(Id_Colegio);
            if (colegioEncontrado == null)
                return;
            _appContext.Colegios.Remove(colegioEncontrado);
            _appContext.SaveChanges();
         }


        public Colegio GetColegio(int Id_Colegio)
        {
            return _appContext.Colegios.Find(Id_Colegio);
        }
        
        
        

    }
}
