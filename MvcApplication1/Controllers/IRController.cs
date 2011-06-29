using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class IRController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Calculo(decimal salario)
        {
            ViewBag.Salario = salario;
            ViewBag.IR = new CalculoIR(salario).Calcular();
            return View("Index");
        }

    }
}
