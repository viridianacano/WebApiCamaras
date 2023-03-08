using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiCamaras.Migrations
{
    /// <inheritdoc />
    public partial class Marcas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Camaras_Camaras_CamaraId",
                table: "Camaras");

            migrationBuilder.DropIndex(
                name: "IX_Camaras_CamaraId",
                table: "Camaras");

            migrationBuilder.DropColumn(
                name: "CamaraId",
                table: "Camaras");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CamaraId",
                table: "Camaras",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Camaras_CamaraId",
                table: "Camaras",
                column: "CamaraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Camaras_Camaras_CamaraId",
                table: "Camaras",
                column: "CamaraId",
                principalTable: "Camaras",
                principalColumn: "Id");
        }
    }
}
