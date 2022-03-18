using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FarmerMarket.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        public PartialViewResult _Header()
        {
            return PartialView();
        }
    }
}