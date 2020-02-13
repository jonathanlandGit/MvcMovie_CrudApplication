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
        // 
        // GET: /HelloWorld/
        /*
        public string Index()
        {
            return "This is my default action...";
        }
        */

        //GET get's the index 
        public IActionResult Index()
        {
            //returns the the hello world view
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        /*// GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

        */

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        ///HelloWorld/Welcome?name=Rick&numtimes=4 - this will print out what is needed
        //public string Welcome(string name, int numTimes = 1)
        // {
        //     return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        // }

        //GET: https://localhost:{PORT}/HelloWorld/Welcome/3?name=Rick
        /*
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
        */




    }
}