using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TrueMetalAppWeb.Data;
using TrueMetalAppWeb.Models;

namespace TrueMetalAppWeb.Pages.Generos
{
    public class CreateModel : PageModel
    {
        private readonly TrueMetalAppWeb.Data.DistroDbContext _context;

        public CreateModel(TrueMetalAppWeb.Data.DistroDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Genero Genero { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Genero == null || Genero == null)
            {
                return Page();
            }

            _context.Genero.Add(Genero);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
