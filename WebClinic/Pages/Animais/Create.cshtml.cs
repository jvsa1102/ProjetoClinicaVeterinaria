using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebClinic.Models;

namespace WebClinic.Pages.Animais
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
        ViewData["ProprietarioID"] = new SelectList(_context.Proprietario, "ID", "Nome");
            ViewData["ProprietarioNome"] = new SelectList(_context.Proprietario, "Nome", "Nome");
            return Page();
        }

        [BindProperty]
        public Animal Animal { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Animal.Add(Animal);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}