using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using calculadoramvc.Models;

namespace calculadoramvc.Controllers
{
    public class CalculadoraController : Controller
    {
        private readonly ILogger<CalculadoraController> _logger;

        public CalculadoraController(ILogger<CalculadoraController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(Calculadora objCalculadora){
            if("+".Equals(objCalculadora.Acccion)){
                objCalculadora.Respuesta = objCalculadora.Operador1 + objCalculadora.Operador2;
            }
            if("-".Equals(objCalculadora.Acccion)){
                objCalculadora.Respuesta = objCalculadora.Operador1 - objCalculadora.Operador2;
            }            
            return View("index", objCalculadora);
        }

    }
}
