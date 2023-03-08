
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiCamaras.Migrations
{
    /// <inheritdoc />
    public partial class Marcas2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Marcas",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "modelo",
                table: "Marcas",
                newName: "Modelo");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Marcas",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Marcas",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "Modelo",
                table: "Marcas",
                newName: "modelo");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Marcas",
                newName: "id");
        }
    }
}
