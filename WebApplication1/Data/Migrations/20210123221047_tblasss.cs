using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class tblasss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servici_ProductosGuardados_ProductoIngredienteId",
                table: "Servici");

            migrationBuilder.DropIndex(
                name: "IX_Servici_ProductoIngredienteId",
                table: "Servici");

            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "Servici");

            migrationBuilder.DropColumn(
                name: "ProductoIngredienteId",
                table: "Servici");

            migrationBuilder.AddColumn<int>(
                name: "cantidad",
                table: "detalleservicio",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cantidad",
                table: "detalleservicio");

            migrationBuilder.AddColumn<int>(
                name: "Cantidad",
                table: "Servici",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductoIngredienteId",
                table: "Servici",
                type: "int",
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
    }
}
