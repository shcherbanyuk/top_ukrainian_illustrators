using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TopUkrainianIllustrators.Controllers
{
    public class IllustratorsController : Controller
    {
        public ActionResult Detail()
        {

            ViewBag.Name = "Volodymyr Holozubov";
            ViewBag.From = "Kyiv";
            ViewBag.AlmaMater = "Taras Shevchenko State Art School";
            ViewBag.MagnumOpus = "<p><strong>Maggie Magpie</strong> (1970, Kyiv, Veselka), <strong>Two chanticleers</strong> (1970, Kyiv, Veselka)</p>";

            return View();
        }
    }
}