using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebClinic.Models;

namespace WebClinic.Pages.Consultas
{
    public class DetailsModel : PageModel
    {
        private readonly WebClinic.Models.DataContext _context;

        public DetailsModel(WebClinic.Models.DataContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
