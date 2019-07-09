using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebClinic.Models;

namespace WebClinic.Pages.Animais
{
    public class DetailsModel : PageModel
    {
        private readonly WebClinic.Models.DataContext _context;

        public DetailsModel(WebClinic.Models.DataContext context)
        {
            _context = context;
        }

        public Animal Animal { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Animal = await _context.Animal
                .Include(a => a.Proprietario)
                .Include(s => s.Procedimentos).ThenInclude(e => e.Medico)
                .Include(s => s.Procedimentos).ThenInclude(f => f.TipoProcedimento)
                .Include(t => t.Consultas).ThenInclude(e => e.Medico)
                .Include(x => x.Exames).ThenInclude(e => e.Medico)
                .AsNoTracking().FirstOrDefaultAsync(m => m.ID == id);

            if (Animal == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
