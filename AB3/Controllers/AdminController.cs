using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AB3.Controllers
{
    public class AdminController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View("AdminLogin");
        }

        //If logged in
        // GET: /<controller>/
        public IActionResult Temp()
        {
            return View("AdminHome");
        }

        // GET: /<controller>/
        public IActionResult Add()
        {
            return View("Add");
        }
    }
}
