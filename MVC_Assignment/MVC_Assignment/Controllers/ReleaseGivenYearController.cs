using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Assignment.Models;

namespace MVC_Assignment.Controllers
{
    
    public class ReleaseGivenYearController : Controller
    {
        // GET: ReleaseGivenYear
        Movie db = new Movie();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getReleaseByYear()
        {
            List<Movie> movlist = (from m in db.Movies
                                   where m.DateofRelease = "09/03/2023"
                                       select m).ToList();
            return View(movlist);

        }
    }
}