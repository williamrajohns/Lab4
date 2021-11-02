using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //string testindex = "Welcome from iactionresult index"; 
            return View();
        }

        public IActionResult Error()
        {
            //string testerror = "in iactionresult error";
            return Error(); // Do you need to modify this line? Use your judgement based on the app you developed so far //was View();
            //return Error(); //??? cause theres one 
        }

    }
}
