using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using calculadoramvc.Models;
using calculadoramvc.Data;

namespace calculadoramvc.Controllers
{
    public class ContactoController : Controller
    {

       private readonly ILogger<ContactoController> _logger;
       private readonly DatabaseContext _context;


        public ContactoController(ILogger<ContactoController> logger,
            DatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var listContactos=_context.Contactos.ToList();
            return View(listContactos);
        }

        [HttpPost]
        public IActionResult Registrar(Contacto objContacto){
            if (ModelState.IsValid)
            {
                _context.Add(objContacto);
                _context.SaveChanges();
                objContacto.Response = "Gracias estamos en contacto";
            }
            return View("index", objContacto);
        }

    }
}