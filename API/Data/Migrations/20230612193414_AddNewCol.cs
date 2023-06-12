using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNewCol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "url",
                table: "Photos",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "isMain",
                table: "Photos",
                newName: "IsMain");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Interests",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Introduction",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LookingFor",
                table: "Users",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Interests",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Introduction",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LookingFor",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Photos",
                newName: "url");

            migrationBuilder.RenameColumn(
                name: "IsMain",
                table: "Photos",
                newName: "isMain");
        }
    }
}
