using Microsoft.EntityFrameworkCore.Migrations;
using TrueMetalAppWeb.Models;

#nullable disable

namespace TrueMetalAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarDadosIniciaisGenero : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new DistroDbContext();
            context.Genero.AddRange(ObterCargaInicialGenero());
            context.SaveChanges();
        }

        private IList<Genero> ObterCargaInicialGenero()
        {
            return new List<Genero>()
            {
                new Genero() {Name = "Black metal"},
                new Genero() {Name = "Epic Black metal"},
                new Genero() {Name = "Pagan Black metal"},
                new Genero() {Name = "Folk Black metal"},
                new Genero() {Name = "Atmospheric Black metal"},
                new Genero() {Name = "Depressive suicidal Black metal"},
                new Genero() {Name = "Symphonic Black metal"},
            };
        }

    }
}
