using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebClinic.Models;

namespace WebClinic.Pages.Exames
{
    public class DetailsModel : PageModel
    {
        private readonly WebClinic.Models.DataContext _context;

        public DetailsModel(WebClinic.Models.DataContext context)
        {
            _context = context;
        }

        public Exame Exame { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Exame = await _context.Exame
                .Include(e => e.Animal)
                .Include(e => e.Medico).FirstOrDefaultAsync(m => m.ID == id);

            if (Exame == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
