using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TrueMetalAppWeb.Models;
using TrueMetalAppWeb.Services;

namespace TrueMetalAppWeb.Pages
{
    [Authorize]

    public class CreateModel : PageModel

    {
        public SelectList PatchOptionItems { get; set; }
        private IPatchService _service;
        public CreateModel(IPatchService service)
        {
            _service = service;
        }

        public void OnGet() 
        {
            PatchOptionItems = new SelectList(_service.ObterTodosGeneros(), nameof(Genero.GeneroId), nameof(Genero.Name));
        }

        [BindProperty]
        public Patch Patch { get; set; }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            _service.Incluir(Patch);

            return RedirectToPage("/Index");
        }
    }
}
