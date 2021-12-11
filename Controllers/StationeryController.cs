using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HMT_StationeryMnt.Controllers
{
    public class StationeryController : Controller
    {
        // GET: Stationeries
        public ActionResult Index()
        {
            return View();
        }
    }
}