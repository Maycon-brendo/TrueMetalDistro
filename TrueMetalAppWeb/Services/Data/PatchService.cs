using TrueMetalAppWeb.Data;
using TrueMetalAppWeb.Models;

namespace TrueMetalAppWeb.Services.Data;
public class PatchService : IPatchService
{

    private DistroDbContext _context;

    public PatchService(DistroDbContext context)
    {  _context = context; 
    }
    public void Alterar(Patch patch)
    {
        var PatchEncontrado = Obter(patch.PatchId);
        PatchEncontrado.Nome = patch.Nome;
        PatchEncontrado.Descricao = patch.Descricao;
        PatchEncontrado.Preco = patch.Preco;
        PatchEncontrado.ImagemUri = patch.ImagemUri;
        PatchEncontrado.EntregaExpressa = patch.EntregaExpressa;
        PatchEncontrado.DataCadastro = patch.DataCadastro;
        PatchEncontrado.GeneroId = patch.GeneroId;
        _context.SaveChanges();
    }

    public void Excluir(int id)
    {
        var PatchEncontrado = Obter(id);
        _context.Patch.Remove(PatchEncontrado);
        _context.SaveChanges();
    }

    public void Incluir(Patch patch)
    {
        _context.Patch.Add(patch);
        _context.SaveChanges();
    }

    public Patch Obter(int id)
    {
        return _context.Patch.SingleOrDefault(item => item.PatchId == id);
    }

    public Genero ObterGenero(int id) => _context.Genero.SingleOrDefault(item => item.GeneroId == id);

    public IList<Patch> ObterTodos()
    {
        return _context.Patch.ToList();
    }

    public IList<Genero> ObterTodosGeneros()=> _context.Genero.ToList();
}
