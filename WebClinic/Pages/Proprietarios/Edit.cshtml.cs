using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebClinic.Models;

namespace WebClinic.Pages.Proprietarios
{
    public class EditModel : PageModel
    {
        private readonly WebClinic.Models.DataContext _context;

        public EditModel(WebClinic.Models.DataContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Proprietario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProprietarioExists(Proprietario.ID))
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

        private bool ProprietarioExists(int id)
        {
            return _context.Proprietario.Any(e => e.ID == id);
        }
    }
}
