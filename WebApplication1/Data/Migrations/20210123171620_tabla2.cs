using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class tabla2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductoIngredienteId",
                table: "Servici",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Servici_ProductoIngredienteId",
                table: "Servici",
                column: "ProductoIngredienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Servici_ProductosGuardados_ProductoIngredienteId",
                table: "Servici",
                column: "ProductoIngredienteId",
                principalTable: "ProductosGuardados",
                principalColumn: "IngredienteId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servici_ProductosGuardados_ProductoIngredienteId",
                table: "Servici");

            migrationBuilder.DropIndex(
                name: "IX_Servici_ProductoIngredienteId",
                table: "Servici");

            migrationBuilder.DropColumn(
                name: "ProductoIngredienteId",
                table: "Servici");
        }
    }
}
