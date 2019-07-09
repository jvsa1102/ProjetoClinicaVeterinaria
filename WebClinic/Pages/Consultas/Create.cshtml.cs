using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebClinic.Models;

namespace WebClinic.Pages.Consultas
{
    public class CreateModel : PageModel
    {
        private readonly WebClinic.Models.DataContext _context;

        public CreateModel(WebClinic.Models.DataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AnimalID"] = new SelectList(_context.Animal, "ID", "Nome");
        ViewData["MedicoID"] = new SelectList(_context.Medico, "ID", "Nome");
            return Page();
        }

        [BindProperty]
        public Consulta Consulta { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Consulta.Add(Consulta);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}