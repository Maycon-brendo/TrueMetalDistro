namespace TrueMetalAppWeb.Models;

public class Genero
{
    public int GeneroId { get; set; }
    public string Name { get; set; }

    public ICollection<Patch>? Patches { get; set; }
}
