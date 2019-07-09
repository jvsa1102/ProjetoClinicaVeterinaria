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
    public class IndexModel : PageModel
    {
        private readonly WebClinic.Models.DataContext _context;

        public IndexModel(WebClinic.Models.DataContext context)
        {
            _context = context;
        }

        public IList<Medico> Medico { get;set; }

        public async Task OnGetAsync()
        {
            IQueryable<Medico> medicos = from m in _context.Medico select m;

            medicos = medicos.OrderBy(m => m.Nome);

            Medico = await _context.Medico.ToListAsync();
            Medico = await medicos.AsNoTracking().ToListAsync();
        }
    }
}
