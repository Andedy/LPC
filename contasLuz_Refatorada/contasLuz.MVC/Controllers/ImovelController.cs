using Microsoft.AspNetCore.Mvc;
using contasLuz.Entities;
using contasLuz.interfaces;


namespace contasLuz.MVC.Controllers
{
    public class ImovelController : Controller
    {
        private IImovelRepositories _Repositories;

        public ImovelController(IImovelRepositories Repositories){
        this._Repositories = Repositories;
        }

        public IActionResult Index()
        {
            var listImoveis = _Repositories.GetAll();
            return View(listImoveis);
        }
  
        public IActionResult Create()
        {            
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(Imoveis Imoveis)
        {            
            _Repositories.Create(Imoveis);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {   
            var Imoveis = _Repositories.GetById(id);
            return View(Imoveis);
        }

        [HttpPost]
        public RedirectToActionResult Update(Imoveis Imoveis)
        {            
            _Repositories.Update(Imoveis);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {   
            _Repositories.Delete(id);
         return RedirectToAction("Index");
        }
    }
}