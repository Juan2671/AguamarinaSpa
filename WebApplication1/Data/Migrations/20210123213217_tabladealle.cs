using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class tabladealle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "detalleservicio",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    servicioResetaId = table.Column<int>(nullable: true),
                    productoIngredienteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalleservicio", x => x.id);
                    table.ForeignKey(
                        name: "FK_detalleservicio_ProductosGuardados_productoIngredienteId",
                        column: x => x.productoIngredienteId,
                        principalTable: "ProductosGuardados",
                        principalColumn: "IngredienteId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_detalleservicio_Servici_servicioResetaId",
                        column: x => x.servicioResetaId,
                        principalTable: "Servici",
                        principalColumn: "ResetaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_detalleservicio_productoIngredienteId",
                table: "detalleservicio",
                column: "productoIngredienteId");

            migrationBuilder.CreateIndex(
                name: "IX_detalleservicio_servicioResetaId",
                table: "detalleservicio",
                column: "servicioResetaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "detalleservicio");
        }
    }
}
