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
    public class DeleteModel : PageModel
    {
        private readonly WebClinic.Models.DataContext _context;

        public DeleteModel(WebClinic.Models.DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Proprietario Proprietario { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Proprietario = await _context.Proprietario.FirstOrDefaultAsync(m => m.ID == id);

            if (Proprietario == null)
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

            Proprietario = await _context.Proprietario.FindAsync(id);

            if (Proprietario != null)
            {
                _context.Proprietario.Remove(Proprietario);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
