using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TopUkrainianIllustrators.Models;

namespace TopUkrainianIllustrators.Controllers
{
    public class IllustratorsController : Controller
    {
        public ActionResult Detail()
        {
            var illustrators = new Illustrators()
            {
                Name = "Volodymyr Holozubov",
                From = "Kyiv",
                AlmaMater = "Taras Shevchenko State Art School",
                MagnumOpusHtml = "<p><strong>Maggie Magpie</strong> (1970, Kyiv, Veselka), <strong>Two chanticleers</strong> (1970, Kyiv, Veselka)</p>",
            };
        
            return View(illustrators);
        }
    }
}