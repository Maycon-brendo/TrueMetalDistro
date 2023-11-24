using Microsoft.EntityFrameworkCore.Migrations;
using TrueMetalAppWeb.Models;

#nullable disable

namespace TrueMetalAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarDadosIniciaisPatch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new DistroDbContext();
            context.Patch.AddRange(ObterCargaInicialPatch());
            context.SaveChanges();
        }

        private IList<Patch> ObterCargaInicialPatch()
        {
             return new List<Patch>()
            {
                new Patch
                {

                    Nome = "Mayhem patch coat of arms",
                    Descricao = "Patch bordado - mayhem",
                    ImagemUri = "/imagens/mayhem-coat-of-arms1-510x680.jpg",
                    Preco = 25.00,
                    EntregaExpressa = true,
                    DataCadastro = DateTime.Now

                },

                new Patch
                {

                    Nome = "Caladan brood - Patch",
                    Descricao = "Patch bordado logo - caladan brood",
                    ImagemUri = "/imagens/caladan-brood-logo-big-aufnaeher-patch.jpg",
                    Preco = 25.00,
                    EntregaExpressa = true,
                    DataCadastro = DateTime.Now

                },

                new Patch
                {

                    Nome = "Darkthrone - Patch",
                    Descricao = "Patch bordado - darkthrone logo",
                    ImagemUri = "/imagens/shopping.webp",
                    Preco = 25.00,
                    EntregaExpressa = false,
                    DataCadastro = DateTime.Now

                },

                new Patch
                {

                    Nome = "Dark Funeral - Patch",
                    Descricao = "Patch bordado - dark funeral",
                    ImagemUri = "/imagens/D_NQ_NP_867080-MLB29212295649_012019-O.webp",
                    Preco = 25.00,
                    EntregaExpressa = true,
                    DataCadastro = DateTime.Now

                },

                new Patch
                {

                    Nome = "The true Werwolf",
                    Descricao = "Patch bordado - the true werwolf logo",
                    ImagemUri = "/imagens/ttw2_680x1000.jpeg",
                    Preco = 25.00,
                    EntregaExpressa = true,
                    DataCadastro = DateTime.Now

                },

                new Patch
                {

                    Nome = "Cinto de Balas",
                    Descricao = "True Black metal bullet belt",
                    ImagemUri = "/imagens/bullet_belt.jpg",
                    Preco = 600.00,
                    EntregaExpressa = true,
                    DataCadastro = DateTime.Now

                },
            };
        }
    }
}
