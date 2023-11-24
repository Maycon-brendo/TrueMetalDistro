using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrueMetalAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarRelacionamentoPatchGenero : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GeneroId",
                table: "Patch",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patch_GeneroId",
                table: "Patch",
                column: "GeneroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patch_Genero_GeneroId",
                table: "Patch",
                column: "GeneroId",
                principalTable: "Genero",
                principalColumn: "GeneroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patch_Genero_GeneroId",
                table: "Patch");

            migrationBuilder.DropIndex(
                name: "IX_Patch_GeneroId",
                table: "Patch");

            migrationBuilder.DropColumn(
                name: "GeneroId",
                table: "Patch");
        }
    }
}
