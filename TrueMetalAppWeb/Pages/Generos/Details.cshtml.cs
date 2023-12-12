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
    public class DetailsModel : PageModel
    {
        private readonly TrueMetalAppWeb.Data.DistroDbContext _context;

        public DetailsModel(TrueMetalAppWeb.Data.DistroDbContext context)
        {
            _context = context;
        }

      public Genero Genero { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Genero == null)
            {
                return NotFound();
            }

            var genero = await _context.Genero.FirstOrDefaultAsync(m => m.GeneroId == id);
            if (genero == null)
            {
                return NotFound();
            }
            else 
            {
                Genero = genero;
            }
            return Page();
        }
    }
}
