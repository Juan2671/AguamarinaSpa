using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class cascada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_detalleservicio_Servici_servicioResetaId",
                table: "detalleservicio");

            migrationBuilder.AddForeignKey(
                name: "FK_detalleservicio_Servici_servicioResetaId",
                table: "detalleservicio",
                column: "servicioResetaId",
                principalTable: "Servici",
                principalColumn: "ResetaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_detalleservicio_Servici_servicioResetaId",
                table: "detalleservicio");

            migrationBuilder.AddForeignKey(
                name: "FK_detalleservicio_Servici_servicioResetaId",
                table: "detalleservicio",
                column: "servicioResetaId",
                principalTable: "Servici",
                principalColumn: "ResetaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
