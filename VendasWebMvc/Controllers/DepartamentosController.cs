using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VendasWebMvc.Models;

namespace VendasWebMvc.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> list = new List<Departamento>();
            list.Add(new Departamento { Id = 1, Nome = "Eletronicos" });
            list.Add(new Departamento { Id = 2, Nome = "Móveis" });
            list.Add(new Departamento { Id = 3, Nome = "Confecção" });
            list.Add(new Departamento { Id = 4, Nome = "Calçados" });
            return View(list);
        }

        public IActionResult Create()
        {

        }
    }
}
