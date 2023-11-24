using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TrueMetalAppWeb.Models;
using TrueMetalAppWeb.Services;

namespace TrueMetalAppWeb.Pages
{
    public class DetailsModel : PageModel
    {
        private IPatchService _service;
        public string GeneroNome { get; set;  }
        public DetailsModel(IPatchService service) 
        {
            _service = service;
        }
        public Patch Patch { get; private set; }
        public IActionResult OnGet(int id)
        {
            Patch = _service.Obter(id);

            if (Patch.GeneroId is not null)
            {
                GeneroNome = _service.ObterGenero(Patch.GeneroId.Value).Name;
            }
            

            if (Patch == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
