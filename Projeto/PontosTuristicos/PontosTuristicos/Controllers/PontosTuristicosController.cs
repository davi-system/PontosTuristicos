using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PontosTuristicos.Controllers
{
    public class PontosTuristicosController : Controller
    {        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }       
    }
}
