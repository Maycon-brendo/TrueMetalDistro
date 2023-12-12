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
    public class DeleteModel : PageModel
    {
        private readonly TrueMetalAppWeb.Data.DistroDbContext _context;

        public DeleteModel(TrueMetalAppWeb.Data.DistroDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Genero == null)
            {
                return NotFound();
            }
            var genero = await _context.Genero.FindAsync(id);

            if (genero != null)
            {
                Genero = genero;
                _context.Genero.Remove(Genero);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
