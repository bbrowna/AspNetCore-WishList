using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Controllers;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WishList.Controller
{
    public class HomeController
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
