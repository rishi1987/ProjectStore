using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BokkProject.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
            //return View("../../CommonViews/common");
        }

        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
