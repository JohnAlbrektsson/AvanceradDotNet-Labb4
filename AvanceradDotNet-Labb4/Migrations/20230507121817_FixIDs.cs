using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AvanceradDotNet_Labb4.Migrations
{
    /// <inheritdoc />
    public partial class FixIDs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Persons",
                newName: "PersonId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Links",
                newName: "LinkId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Interests",
                newName: "InterestId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "Persons",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "LinkId",
                table: "Links",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "InterestId",
                table: "Interests",
                newName: "Id");
        }
    }
}
