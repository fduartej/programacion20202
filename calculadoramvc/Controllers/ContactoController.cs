using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contacto objContacto){
            if (ModelState.IsValid)
            {
                _context.Add(objContacto);
                _context.SaveChanges();
                objContacto.Response = "Gracias estamos en contacto";
            }
            return View(objContacto);
        }

        // GET: Contacto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contacto = await _context.Contactos.FindAsync(id);
            if (contacto == null)
            {
                return NotFound();
            }
            return View(contacto);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,LastName")] Contacto contacto)
        {
            if (id != contacto.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contacto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                    
                }
                return RedirectToAction(nameof(Index));
            }
            return View(contacto);
        }
        


    }
}