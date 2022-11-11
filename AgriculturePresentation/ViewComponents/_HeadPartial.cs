using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponets
{
    public class _HeadPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
