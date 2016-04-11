using AttestationService.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttestationService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<FacultyViewModel> facults = new List<FacultyViewModel>();
            for (int i = 0; i < 14; i++)
            {
                facults.Add(new FacultyViewModel("Faculty" + i.ToString(), "Blah-blah-blah"));
            }
            return View(facults);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}