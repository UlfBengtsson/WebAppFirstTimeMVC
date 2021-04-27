using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppFirstTimeMVC.Models.ViewModel;

namespace WebAppFirstTimeMVC.Controllers
{
    public class ExampelController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new ExampelViewModel());
        }

        [HttpPost]
        public IActionResult Index(ExampelViewModel exampelViewModel)
        {
            return View(exampelViewModel);
        }
    }
}
