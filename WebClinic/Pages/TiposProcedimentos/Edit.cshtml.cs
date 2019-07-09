using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebClinic.Models;

namespace WebClinic.Pages.TiposProcedimentos
{
    public class EditModel : PageModel
    {
        private readonly WebClinic.Models.DataContext _context;

        public EditModel(WebClinic.Models.DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TipoProcedimento TipoProcedimento { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TipoProcedimento = await _context.TipoProcedimento.FirstOrDefaultAsync(m => m.ID == id);

            if (TipoProcedimento == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TipoProcedimento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoProcedimentoExists(TipoProcedimento.ID))
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

        private bool TipoProcedimentoExists(int id)
        {
            return _context.TipoProcedimento.Any(e => e.ID == id);
        }
    }
}
