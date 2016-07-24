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
            if (DateTime.Today.DayOfWeek == DayOfWeek.Sunday)
            {
                return Redirect("/");
            }
            return Content("Hello from IllustratorsController");
        }
    }
}