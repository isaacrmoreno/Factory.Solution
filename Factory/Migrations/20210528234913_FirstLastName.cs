using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class FirstLastName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Engineers",
                newName: "LastName");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Machines",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Engineers",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Engineers");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Engineers",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Machines",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");
        }
    }
}
