using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebClinic.Models;

namespace WebClinic.Pages.Medicos
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
            return Page();
        }

        [BindProperty]
        public Medico Medico { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Medico.Add(Medico);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}