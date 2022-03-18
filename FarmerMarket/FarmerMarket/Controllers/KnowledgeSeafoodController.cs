using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FarmerMarket.Controllers
{
    public class KnowledgeSeafoodController : Controller
    {
        // GET: KnowledgeSeafood
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NewDetail()
        {
            return View();
        }
    }
}