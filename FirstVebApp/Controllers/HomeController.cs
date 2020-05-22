using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstVebApp.Models;

namespace FirstVebApp.Controllers
{
    public class HomeController : Controller
    {
        List<Person> list;
        public HomeController(ExportData data)
        {
            list = data.Read();
        }

        public IActionResult Index()
        {
            return View(list);
        }

          }
}
