using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseTester.Controllers
{
    public class HelloThereController : Controller
    {

        public string HelloThere()
        {
            return "General Kenobi";
        }

        public string Index()
        {
            return "This is the default action";
        }


        /*
        public IActionResult Index()
        {
            return View();
        }
        */
    }
}
