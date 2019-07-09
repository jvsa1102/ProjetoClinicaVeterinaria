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
    public class DetailsModel : PageModel
    {
        private readonly WebClinic.Models.DataContext _context;

        public DetailsModel(WebClinic.Models.DataContext context)
        {
            _context = context;
        }

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
    }
}
