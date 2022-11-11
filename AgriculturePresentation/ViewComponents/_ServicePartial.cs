using BusinnesLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
	public class _ServicePartial:ViewComponent
	{
		private readonly IService _service;

		public _ServicePartial(IService service)
		{
			_service = service;
		}
		public IViewComponentResult Invoke()
		{
			var values = _service.GetListAll();
			return View(values);
		}
	}
}
