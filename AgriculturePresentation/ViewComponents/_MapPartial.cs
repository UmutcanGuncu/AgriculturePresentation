using DataAccesLayer.Contexts;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AgriculturePresentation.ViewComponents
{
    public class _MapPartial:ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            AgricultureContext agricultureContext = new AgricultureContext();
            var values = agricultureContext.Adresses.Select(x => x.MapInfo).FirstOrDefault();
            ViewBag.bag = values;
            return View();
        }
    }
}
