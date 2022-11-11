using BusinnesLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class AdressesControllercs : Controller
    {
        private readonly IAdressService _adressService;

        public AdressesControllercs(IAdressService adressService)
        {
            _adressService = adressService;
        }

        public IActionResult Index()
        {
            var values = _adressService.GetListAll();
            return View(values);
        }
        
        [HttpGet]
        public IActionResult UpdateAdress(int id)
        {
            var values = _adressService.GetById(id);
            _adressService.Update(values);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateAdress(Adress adress)
        {
            _adressService.Update(adress);
            return RedirectToAction("Index");
        }
    }
}
