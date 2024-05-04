using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mvcSistemaVentas.Data.Migrations
{
    /// <inheritdoc />
    public partial class Agregarcampostablausuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NombreUsuario",
                table: "AspNetUsers",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "Carrera",
                table: "AspNetUsers",
                newName: "Direccion");

            migrationBuilder.AddColumn<string>(
                name: "Ciudad",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ciudad",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "AspNetUsers",
                newName: "NombreUsuario");

            migrationBuilder.RenameColumn(
                name: "Direccion",
                table: "AspNetUsers",
                newName: "Carrera");
        }
    }
}
