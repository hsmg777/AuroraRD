using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuroraRD.Migrations
{
    public partial class CambiosBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NombreReserva",
                table: "Reservas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NombreReserva",
                table: "Reservas");
        }
    }
}
