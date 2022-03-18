using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FarmerMarket.Models;
using PagedList;

namespace FarmerMarket.Controllers
{
    public class HomeController : Controller
    {
        HaisanDB db = new HaisanDB();
        // GET: Home
        public ActionResult Index()
        {
            var products = db.SanPhams.OrderByDescending(p => p.MaSP);
            return View(products);
        }
       
    }
}