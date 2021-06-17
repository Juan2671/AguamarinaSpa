using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class migracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "usuarioId",
                table: "Servici",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Servici_usuarioId",
                table: "Servici",
                column: "usuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Servici_AspNetUsers_usuarioId",
                table: "Servici",
                column: "usuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servici_AspNetUsers_usuarioId",
                table: "Servici");

            migrationBuilder.DropIndex(
                name: "IX_Servici_usuarioId",
                table: "Servici");

            migrationBuilder.DropColumn(
                name: "usuarioId",
                table: "Servici");
        }
    }
}
