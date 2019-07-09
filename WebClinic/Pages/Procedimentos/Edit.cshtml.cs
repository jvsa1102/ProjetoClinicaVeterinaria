using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebClinic.Models;

namespace WebClinic.Pages.Procedimentos
{
    public class EditModel : PageModel
    {
        private readonly WebClinic.Models.DataContext _context;

        public EditModel(WebClinic.Models.DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Procedimento Procedimento { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Procedimento = await _context.Procedimento
                .Include(p => p.Animal)
                .Include(p => p.Medico)
                .Include(p => p.TipoProcedimento).FirstOrDefaultAsync(m => m.ID == id);

            if (Procedimento == null)
            {
                return NotFound();
            }
           ViewData["AnimalID"] = new SelectList(_context.Animal, "ID", "Nome");
           ViewData["MedicoID"] = new SelectList(_context.Medico, "ID", "Nome");
           ViewData["TipoProcedimentoID"] = new SelectList(_context.TipoProcedimento, "ID", "Nome");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Procedimento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProcedimentoExists(Procedimento.ID))
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

        private bool ProcedimentoExists(int id)
        {
            return _context.Procedimento.Any(e => e.ID == id);
        }
    }
}
