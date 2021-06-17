using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class elimnartabla : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servici_CategoriaDeProductos_CategoriaProductoId",
                table: "Servici");

            migrationBuilder.DropIndex(
                name: "IX_Servici_CategoriaProductoId",
                table: "Servici");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Servici_CategoriaProductoId",
                table: "Servici",
                column: "CategoriaProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Servici_CategoriaDeProductos_CategoriaProductoId",
                table: "Servici",
                column: "CategoriaProductoId",
                principalTable: "CategoriaDeProductos",
                principalColumn: "CategoriaProductosId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
