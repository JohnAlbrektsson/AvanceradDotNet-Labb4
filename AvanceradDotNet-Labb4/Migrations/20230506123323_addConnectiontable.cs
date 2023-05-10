using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AvanceradDotNet_Labb4.Migrations
{
    /// <inheritdoc />
    public partial class addConnectiontable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonInterestId",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonInterestId",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonInterestId",
                table: "Interests",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PersonInterests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonInterests", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonInterestId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonInterestId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonInterestId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonInterestId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonInterestId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonInterestId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonInterestId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonInterestId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PersonInterestId",
                table: "Persons",
                column: "PersonInterestId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_PersonInterestId",
                table: "Links",
                column: "PersonInterestId");

            migrationBuilder.CreateIndex(
                name: "IX_Interests_PersonInterestId",
                table: "Interests",
                column: "PersonInterestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interests_PersonInterests_PersonInterestId",
                table: "Interests",
                column: "PersonInterestId",
                principalTable: "PersonInterests",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Links_PersonInterests_PersonInterestId",
                table: "Links",
                column: "PersonInterestId",
                principalTable: "PersonInterests",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_PersonInterests_PersonInterestId",
                table: "Persons",
                column: "PersonInterestId",
                principalTable: "PersonInterests",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interests_PersonInterests_PersonInterestId",
                table: "Interests");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_PersonInterests_PersonInterestId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_PersonInterests_PersonInterestId",
                table: "Persons");

            migrationBuilder.DropTable(
                name: "PersonInterests");

            migrationBuilder.DropIndex(
                name: "IX_Persons_PersonInterestId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Links_PersonInterestId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Interests_PersonInterestId",
                table: "Interests");

            migrationBuilder.DropColumn(
                name: "PersonInterestId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "PersonInterestId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "PersonInterestId",
                table: "Interests");
        }
    }
}
