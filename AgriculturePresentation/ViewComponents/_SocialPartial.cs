using BusinnesLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponets
{
    public class _SocialPartial :ViewComponent
    {
        private readonly ISocialMediaService _socialMediaService;

        public _SocialPartial(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _socialMediaService.GetListAll();
            return View(values);
        }
    }
}
