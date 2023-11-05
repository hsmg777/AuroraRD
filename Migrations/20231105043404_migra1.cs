using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuroraRD.Migrations
{
    public partial class migra1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Liquido");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Liquido",
                newName: "imagen");

            migrationBuilder.AddColumn<int>(
                name: "Precio",
                table: "Liquido",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "cantidad",
                table: "Liquido",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Liquido");

            migrationBuilder.DropColumn(
                name: "cantidad",
                table: "Liquido");

            migrationBuilder.RenameColumn(
                name: "imagen",
                table: "Liquido",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Liquido",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

           
        }
    }
}
