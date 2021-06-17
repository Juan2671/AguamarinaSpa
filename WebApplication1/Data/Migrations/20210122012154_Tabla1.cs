using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class Tabla1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Documento",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Catego",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCategoria = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catego", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "CategoriaDeProductos",
                columns: table => new
                {
                    CategoriaProductosId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCategoria = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaDeProductos", x => x.CategoriaProductosId);
                });

            migrationBuilder.CreateTable(
                name: "ProductosGuardados",
                columns: table => new
                {
                    IngredienteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 40, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 150, nullable: false),
                    Imagen = table.Column<string>(nullable: true),
                    CategoriaProductosId = table.Column<int>(nullable: false),
                    Estado = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductosGuardados", x => x.IngredienteId);
                    table.ForeignKey(
                        name: "FK_ProductosGuardados_CategoriaDeProductos_CategoriaProductosId",
                        column: x => x.CategoriaProductosId,
                        principalTable: "CategoriaDeProductos",
                        principalColumn: "CategoriaProductosId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Servici",
                columns: table => new
                {
                    ResetaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 40, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 150, nullable: false),
                    Imagen = table.Column<string>(nullable: true),
                    Cantidad = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    CategoriaId = table.Column<int>(nullable: false),
                    CategoriaProductoId = table.Column<int>(nullable: false),
                    Estado = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servici", x => x.ResetaId);
                    table.ForeignKey(
                        name: "FK_Servici_Catego_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Catego",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Servici_CategoriaDeProductos_CategoriaProductoId",
                        column: x => x.CategoriaProductoId,
                        principalTable: "CategoriaDeProductos",
                        principalColumn: "CategoriaProductosId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductosGuardados_CategoriaProductosId",
                table: "ProductosGuardados",
                column: "CategoriaProductosId");

            migrationBuilder.CreateIndex(
                name: "IX_Servici_CategoriaId",
                table: "Servici",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Servici_CategoriaProductoId",
                table: "Servici",
                column: "CategoriaProductoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductosGuardados");

            migrationBuilder.DropTable(
                name: "Servici");

            migrationBuilder.DropTable(
                name: "Catego");

            migrationBuilder.DropTable(
                name: "CategoriaDeProductos");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Documento",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "AspNetUsers");
        }
    }
}
