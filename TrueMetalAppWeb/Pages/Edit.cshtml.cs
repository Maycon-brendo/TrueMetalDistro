using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TrueMetalAppWeb.Models;
using TrueMetalAppWeb.Services;

namespace TrueMetalAppWeb.Pages
{
    [Authorize]

    public class EditModel : PageModel
    {
        public SelectList PatchOptionItems { get; set; }
        private IPatchService _service;
        public EditModel(IPatchService service)
        {
            _service = service;
        }
        [BindProperty]
        public Patch Patch { get; set; }

        public IActionResult OnGet(int id)
        {
            Patch = _service.Obter(id);

            PatchOptionItems = new SelectList(_service.ObterTodosGeneros(), nameof(Genero.GeneroId), nameof(Genero.Name));

            if (Patch == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _service.Alterar(Patch);

            return RedirectToPage("/Index");
        }
        public IActionResult OnPostExclusao()
        {
            _service.Excluir(Patch.PatchId);

            return RedirectToPage("/Index");
        }
    }
}
