﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebClinic.Models;

namespace WebClinic.Pages.Animais
{
    public class IndexModel : PageModel
    {
        private readonly WebClinic.Models.DataContext _context;

        public IndexModel(WebClinic.Models.DataContext context)
        {
            _context = context;
        }

        public IList<Animal> Animal { get;set; }

        public async Task OnGetAsync()
        {
            Animal = await _context.Animal
                .Include(a => a.Proprietario).ToListAsync();
        }
    }
}
