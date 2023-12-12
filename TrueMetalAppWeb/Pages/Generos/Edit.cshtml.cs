﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrueMetalAppWeb.Data;
using TrueMetalAppWeb.Models;

namespace TrueMetalAppWeb.Pages.Generos
{
    public class EditModel : PageModel
    {
        private readonly TrueMetalAppWeb.Data.DistroDbContext _context;

        public EditModel(TrueMetalAppWeb.Data.DistroDbContext context)
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

            var genero =  await _context.Genero.FirstOrDefaultAsync(m => m.GeneroId == id);
            if (genero == null)
            {
                return NotFound();
            }
            Genero = genero;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Genero).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GeneroExists(Genero.GeneroId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool GeneroExists(int id)
        {
          return (_context.Genero?.Any(e => e.GeneroId == id)).GetValueOrDefault();
        }
    }
}
