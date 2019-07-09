using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebClinic.Models;

namespace WebClinic.Pages.Proprietarios
{
    public class DetailsModel : PageModel
    {
        private readonly WebClinic.Models.DataContext _context;

        public DetailsModel(WebClinic.Models.DataContext context)
        {
            _context = context;
        }

        public Proprietario Proprietario { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Proprietario = await _context.Proprietario
                .Include(m => m.Animais)
                .ThenInclude(p => p.Procedimentos).ThenInclude(t => t.TipoProcedimento)
                .Include(m => m.Animais)
                .ThenInclude(c => c.Consultas)
                .Include(m => m.Animais)
                .ThenInclude(e => e.Exames)
                .AsNoTracking().FirstOrDefaultAsync(m => m.ID == id);

            if (Proprietario == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
