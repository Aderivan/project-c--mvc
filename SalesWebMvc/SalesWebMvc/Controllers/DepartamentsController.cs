using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartamentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departament> departaments = new List<Departament>();

            departaments.Add(new Departament(1, "Eletronicos"));
            departaments.Add(new Departament(2, "Fashion"));
            return View(departaments);
        }
    }
}