using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebClinic.Models;

namespace WebClinic.Pages.TiposProcedimentos
{
    public class DeleteModel : PageModel
    {
        private readonly WebClinic.Models.DataContext _context;

        public DeleteModel(WebClinic.Models.DataContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TipoProcedimento = await _context.TipoProcedimento.FindAsync(id);

            if (TipoProcedimento != null)
            {
                _context.TipoProcedimento.Remove(TipoProcedimento);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
