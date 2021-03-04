using Assignment5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBookRepository repository;

        public NavigationMenuViewComponent (IBookRepository r)
        {
            repository = r;
        }
        public IViewComponentResult Invoke()
        {
            //This is where we create the categories to filter on
            ViewBag.SelectType = RouteData?.Values["category"];

            return View(repository.Projects
                .Select(x => x.Classification)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
