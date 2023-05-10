using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AvanceradDotNet_Labb4.Migrations
{
    /// <inheritdoc />
    public partial class fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "InterestId",
                table: "PersonInterests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LinkId",
                table: "PersonInterests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "PersonInterests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PersonInterests_InterestId",
                table: "PersonInterests",
                column: "InterestId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonInterests_LinkId",
                table: "PersonInterests",
                column: "LinkId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonInterests_PersonId",
                table: "PersonInterests",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonInterests_Interests_InterestId",
                table: "PersonInterests",
                column: "InterestId",
                principalTable: "Interests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonInterests_Links_LinkId",
                table: "PersonInterests",
                column: "LinkId",
                principalTable: "Links",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonInterests_Persons_PersonId",
                table: "PersonInterests",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonInterests_Interests_InterestId",
                table: "PersonInterests");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonInterests_Links_LinkId",
                table: "PersonInterests");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonInterests_Persons_PersonId",
                table: "PersonInterests");

            migrationBuilder.DropIndex(
                name: "IX_PersonInterests_InterestId",
                table: "PersonInterests");

            migrationBuilder.DropIndex(
                name: "IX_PersonInterests_LinkId",
                table: "PersonInterests");

            migrationBuilder.DropIndex(
                name: "IX_PersonInterests_PersonId",
                table: "PersonInterests");

            migrationBuilder.DropColumn(
                name: "InterestId",
                table: "PersonInterests");

            migrationBuilder.DropColumn(
                name: "LinkId",
                table: "PersonInterests");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "PersonInterests");

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
    }
}
