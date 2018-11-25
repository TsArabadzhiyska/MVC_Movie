using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // GET: /<controller>/
        public IActionResult Welcome(string name, int ID = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = ID;
            return View();
        }

        public string HelloToYou(string name ,int age=4)
        {
            return HtmlEncoder.Default.Encode($"Hey {name} hello to you . You are {age} years old");
        }
    }
}
