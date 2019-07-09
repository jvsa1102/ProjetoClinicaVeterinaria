using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebClinic.Models;

namespace WebClinic.Pages.Procedimentos
{
    public class DetailsModel : PageModel
    {
        private readonly WebClinic.Models.DataContext _context;

        public DetailsModel(WebClinic.Models.DataContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
