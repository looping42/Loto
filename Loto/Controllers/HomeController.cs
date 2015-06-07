using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Loto.Models;
using Loto.Models.DataAccess;
using HtmlAgilityPack;

namespace Loto.Controllers
{
    public partial class HomeController : Controller
    {
        public virtual ActionResult Index()
        {
            ResultatModel model = new ResultatModel();
            model.ListResultatLoto();
            model.ListResultatProbablite();
            model.ResearchResultLoto();
            return View(model);
        }


    }
}
