using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppFirstTimeMVC.Models.Data;
using WebAppFirstTimeMVC.Models.Service;
using WebAppFirstTimeMVC.Models.ViewModel;

namespace WebAppFirstTimeMVC.Controllers
{
    public class CakesController : Controller
    {
        readonly ICakeService _cakeService = new CakeService();

        public IActionResult Index()
        {
            return View(_cakeService.FindAll());
        }

        [HttpGet]
        public IActionResult AmountFilterCakes(int minAmount)
        {
            return PartialView("_CakeTableParctialView", _cakeService.FindByAmount(minAmount));
        }

        [HttpPost]
        public IActionResult PartcialDetails(int id)
        {
            Cake cake = _cakeService.FindbyId(id);

            if (cake == null)
            {
                return NotFound();
            }

            return PartialView("_CakeDetailsRowParctialView", cake);
        }

        [HttpPost]
        public IActionResult PartcialCakeTableRow(int id)
        {
            return PartialView("_CakeTableRowParctialView", _cakeService.FindbyId(id));
        }

        public IActionResult Detailes(int id)
        {
            Cake cake = _cakeService.FindbyId(id);

            if (cake == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(cake);
        }

        //Edit
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Cake cake = _cakeService.FindbyId(id);

            if (cake == null)
            {
                return RedirectToAction(nameof(Index));
            }

            EditCake editCake = new EditCake(id, cake);

            return View(editCake);
        }

        [HttpPost]
        public IActionResult Edit(int id, CreateCake CreateCake)
        {
            Cake cake = _cakeService.FindbyId(id);

            if (cake == null)
            {
                return RedirectToAction(nameof(Index));
            }

            if (ModelState.IsValid)
            {
                _cakeService.Edit(id, CreateCake);

                return RedirectToAction(nameof(Detailes), new { id = id });
            }

            EditCake editCake = new EditCake(id, CreateCake);

            return View(editCake);
        }

        public IActionResult Delete(int id)
        {
            Cake cake = _cakeService.FindbyId(id);

            if (cake == null)
            {
                return NotFound();//404
            }

            if (_cakeService.Remove(id))
            {
                return Ok("cake" + id);//200
            }

            return BadRequest();
        }
    }
}
