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
    public class IndexModel : PageModel
    {
        private readonly WebClinic.Models.DataContext _context;

        public IndexModel(WebClinic.Models.DataContext context)
        {
            _context = context;
        }

        public IList<Exame> Exame { get;set; }

        public async Task OnGetAsync()
        {
            Exame = await _context.Exame
                .Include(e => e.Animal)
                .Include(e => e.Medico).ToListAsync();
        }
    }
}
