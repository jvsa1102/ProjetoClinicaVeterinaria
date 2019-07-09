using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebClinic.Models;

namespace WebClinic.Pages.Procedimentos
{
    public class IndexModel : PageModel
    {
        private readonly WebClinic.Models.DataContext _context;

        public IndexModel(WebClinic.Models.DataContext context)
        {
            _context = context;
        }

        public IList<Procedimento> Procedimento { get;set; }

        public async Task OnGetAsync()
        {
            Procedimento = await _context.Procedimento
                .Include(p => p.Animal)
                .Include(p => p.Medico)
                .Include(p => p.TipoProcedimento).ToListAsync();
        }
    }
}
