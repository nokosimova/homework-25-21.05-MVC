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
        public IActionResult Index()
        {
            ExportData data = new ExportData();
            return View(data.ReadFromPerson());
        }

          }
}
