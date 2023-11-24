using Microsoft.AspNetCore.Mvc.RazorPages;
using TrueMetalAppWeb.Services;
using TrueMetalAppWeb.Models;

namespace WebApplication1.Pages; 

public class IndexModel : PageModel
{
    private IPatchService _service;
    public IndexModel(IPatchService service)
    {
        _service = service;
    }
    public IList<Patch> ListaPatch { get; private set; }
    public void OnGet()
    {
        ViewData["Title"] = "Home page";

        ListaPatch = _service.ObterTodos();

    }
}