using TrueMetalAppWeb.Models;

namespace TrueMetalAppWeb.Services.Memory;

public class PatchService : IPatchService
{

    public PatchService()
        => CarregarListaInicial();

    private IList<Patch> _patches;

    private void CarregarListaInicial()
    {
        _patches = new List<Patch>()
        {
            new Patch
            {
                PatchId = 1,
                Nome = "Mayhem patch coat of arms",
                Descricao = "Patch bordado - mayhem",
                ImagemUri = "/imagens/mayhem-coat-of-arms1-510x680.jpg",
                Preco = 25.00,
                EntregaExpressa = true,
                DataCadastro = DateTime.Now

            },

            new Patch
            {
                PatchId = 2,
                Nome = "Caladan brood - Patch",
                Descricao = "Patch bordado logo - caladan brood",
                ImagemUri = "/imagens/caladan-brood-logo-big-aufnaeher-patch.jpg",
                Preco = 25.00,
                EntregaExpressa = true,
                DataCadastro = DateTime.Now

            },

            new Patch
            {
                PatchId = 3,
                Nome = "Darkthrone - Patch",
                Descricao = "Patch bordado - darkthrone logo",
                ImagemUri = "/imagens/shopping.webp",
                Preco = 25.00,
                EntregaExpressa = false,
                DataCadastro = DateTime.Now

            },

            new Patch
            {
                PatchId = 4,
                Nome = "Dark Funeral - Patch",
                Descricao = "Patch bordado - dark funeral",
                ImagemUri = "/imagens/D_NQ_NP_867080-MLB29212295649_012019-O.webp",
                Preco = 25.00,
                EntregaExpressa = true,
                DataCadastro = DateTime.Now

            },

            new Patch
            {
                PatchId = 5,
                Nome = "The true Werwolf",
                Descricao = "Patch bordado - the true werwolf logo",
                ImagemUri = "/imagens/ttw2_680x1000.jpeg",
                Preco = 25.00,
                EntregaExpressa = true,
                DataCadastro = DateTime.Now

            },

            new Patch
            {
                PatchId = 6,
                Nome = "Cinto de Balas",
                Descricao = "True Black metal bullet belt",
                ImagemUri = "/imagens/bullet_belt.jpg",
                Preco = 500.00,
                EntregaExpressa = true,
                DataCadastro = DateTime.Now

            },
        };
    }

    public IList<Patch> ObterTodos()
        => _patches;

    public Patch Obter(int id)
        => ObterTodos().SingleOrDefault(item => item.PatchId == id);

    public void Incluir(Patch patch)
    {
        var proximoId = _patches.Max(item => item.PatchId) + 1;
        patch.PatchId = proximoId;
        _patches.Add(patch);
    }

    public void Alterar(Patch patch)
    {
        var patchEncontrado = _patches.SingleOrDefault(item => item.PatchId == patch.PatchId);
        patchEncontrado.Nome = patch.Nome;
        patchEncontrado.Descricao = patch.Descricao;
        patchEncontrado.Preco = patch.Preco;
        patchEncontrado.EntregaExpressa = patch.EntregaExpressa;
        patchEncontrado.DataCadastro = patch.DataCadastro;
        patchEncontrado.ImagemUri = patch.ImagemUri;
    }

    public void Excluir(int id)
    {
        var patchEncontrado = Obter(id);
        _patches.Remove(patchEncontrado);
    }

    public IList<Genero> ObterTodosGeneros()
    {
        throw new NotImplementedException();
    }

    public Genero ObterGenero()
    {
        throw new NotImplementedException();
    }

    public Genero ObterGenero(int id)
    {
        throw new NotImplementedException();
    }
}
