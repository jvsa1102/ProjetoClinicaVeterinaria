using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebClinic.Models;

namespace WebClinic.Pages.Medicos
{
    public class AgendaModel : PageModel
    {
        private readonly WebClinic.Models.DataContext _context;

        public string DateSort { get; set; }

        public AgendaModel(WebClinic.Models.DataContext context)
        {
            _context = context;
        }

        public Medico Medico { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataInicial { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataFinal { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id, string sortOrder)
        {
            if (id == null)
            {
                return NotFound();
            }

            Medico = await _context.Medico
                .Include(p => p.Procedimentos)
                .ThenInclude(a => a.Animal)
                .Include(p => p.Procedimentos)
                .ThenInclude(t => t.TipoProcedimento)
                .Include(c => c.Consultas)
                .ThenInclude(a => a.Animal)
                .Include(e => e.Exames)
                .ThenInclude(a => a.Animal)
                .FirstOrDefaultAsync(m => m.ID == id);

            /*IQueryable<Consulta> consulta = from c in _context.Consulta select c;
            IQueryable<Exame> exame = from e in _context.Exame select e;
            IQueryable<Procedimento> procedimento = from p in _context.Procedimento select p;

            consulta = consulta.OrderBy(c => c.DataRealizacao);
            exame = exame.OrderBy(e => e.DataRealizacao);
            procedimento = procedimento.OrderBy(p => p.DataRealizacao);

            Medico.Consultas = await consulta.Include(a => a.Animal).AsNoTracking().ToListAsync();
            Medico.Exames = await exame.Include(a => a.Animal).AsNoTracking().ToListAsync();
            Medico.Procedimentos = await procedimento.Include(t => t.TipoProcedimento).Include(a => a.Animal).AsNoTracking().ToListAsync();*/

            if (Medico == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}