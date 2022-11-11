using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponets
{
	public class _NavbarPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
