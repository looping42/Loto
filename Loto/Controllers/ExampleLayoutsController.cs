using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapMvcSample.Controllers
{
    public partial class ExampleLayoutsController : Controller
    {
        public virtual ActionResult Starter()
        {
            return View();
        }

        public virtual ActionResult Marketing()
        {
            return View();
        }

        public virtual ActionResult Fluid()
        {
            return View();
        }

        public virtual ActionResult Narrow()
        {
            return View();
        }

        public virtual ActionResult SignIn()
        {
            return View();
        }

        public virtual ActionResult StickyFooter()
        {
            return View("TBD");
        }

        public virtual ActionResult Carousel()
        {
            return View("TBD");
        }
    }
}
