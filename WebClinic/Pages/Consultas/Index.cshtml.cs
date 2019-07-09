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
    public class IndexModel : PageModel
    {
        private readonly WebClinic.Models.DataContext _context;

        public IndexModel(WebClinic.Models.DataContext context)
        {
            _context = context;
        }

        public IList<Consulta> Consulta { get;set; }

        public async Task OnGetAsync()
        {
            Consulta = await _context.Consulta
                .Include(c => c.Animal)
                .Include(c => c.Medico).ToListAsync();
        }
    }
}
