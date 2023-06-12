using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KnowsAs",
                table: "Users",
                newName: "KnownAs");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Photos",
                newName: "url");

            migrationBuilder.RenameColumn(
                name: "IsMain",
                table: "Photos",
                newName: "isMain");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KnownAs",
                table: "Users",
                newName: "KnowsAs");

            migrationBuilder.RenameColumn(
                name: "url",
                table: "Photos",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "isMain",
                table: "Photos",
                newName: "IsMain");
        }
    }
}
