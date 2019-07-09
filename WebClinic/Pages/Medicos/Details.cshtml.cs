using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebClinic.Models;

namespace WebClinic.Pages.Medicos
{
    public class DetailsModel : PageModel
    {
        private readonly WebClinic.Models.DataContext _context;

        public DetailsModel(WebClinic.Models.DataContext context)
        {
            _context = context;
        }

        public Medico Medico { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Medico = await _context.Medico.FirstOrDefaultAsync(m => m.ID == id);

            if (Medico == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
