﻿using BusinnesLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
    public class _DashboardTablePartial : ViewComponent
    {
        private readonly IContactService _contactService;

        public _DashboardTablePartial(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _contactService.GetListAll();
            return View(values);
        }
    }
}
