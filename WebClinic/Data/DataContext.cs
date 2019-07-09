using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebClinic.Models;

namespace WebClinic.Models
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<WebClinic.Models.Proprietario> Proprietario { get; set; }

        public DbSet<WebClinic.Models.Animal> Animal { get; set; }

        public DbSet<WebClinic.Models.Medico> Medico { get; set; }
        public DbSet<WebClinic.Models.TipoProcedimento> TipoProcedimento { get; set; }
        public DbSet<WebClinic.Models.Procedimento> Procedimento { get; set; }
        public DbSet<WebClinic.Models.Consulta> Consulta { get; set; }
        public DbSet<WebClinic.Models.Exame> Exame { get; set; }


    }
}
