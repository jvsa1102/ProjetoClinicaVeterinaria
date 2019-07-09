using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebClinic.Models;

namespace WebClinic.Pages.Consultas
{
    public class EditModel : PageModel
    {
        private readonly WebClinic.Models.DataContext _context;

        public EditModel(WebClinic.Models.DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Consulta Consulta { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Consulta = await _context.Consulta
                .Include(c => c.Animal)
                .Include(c => c.Medico).FirstOrDefaultAsync(m => m.ID == id);

            if (Consulta == null)
            {
                return NotFound();
            }
           ViewData["AnimalID"] = new SelectList(_context.Animal, "ID", "Nome");
           ViewData["MedicoID"] = new SelectList(_context.Medico, "ID", "Nome");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Consulta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConsultaExists(Consulta.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ConsultaExists(int id)
        {
            return _context.Consulta.Any(e => e.ID == id);
        }
    }
}
