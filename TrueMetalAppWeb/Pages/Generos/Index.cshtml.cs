using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TrueMetalAppWeb.Data;
using TrueMetalAppWeb.Models;

namespace TrueMetalAppWeb.Pages.Generos
{
    public class IndexModel : PageModel
    {
        private readonly TrueMetalAppWeb.Data.DistroDbContext _context;

        public IndexModel(TrueMetalAppWeb.Data.DistroDbContext context)
        {
            _context = context;
        }

        public IList<Genero> Genero { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Genero != null)
            {
                Genero = await _context.Genero.ToListAsync();
            }
        }
    }
}
