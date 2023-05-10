using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AvanceradDotNet_Labb4.Migrations
{
    /// <inheritdoc />
    public partial class Fix_PersonInterest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "PersonInterests",
                newName: "PersonID");

            migrationBuilder.RenameColumn(
                name: "LinkId",
                table: "PersonInterests",
                newName: "LinkID");

            migrationBuilder.RenameColumn(
                name: "InterestId",
                table: "PersonInterests",
                newName: "InterestID");

            migrationBuilder.RenameIndex(
                name: "IX_PersonInterests_PersonId",
                table: "PersonInterests",
                newName: "IX_PersonInterests_PersonID");

            migrationBuilder.RenameIndex(
                name: "IX_PersonInterests_LinkId",
                table: "PersonInterests",
                newName: "IX_PersonInterests_LinkID");

            migrationBuilder.RenameIndex(
                name: "IX_PersonInterests_InterestId",
                table: "PersonInterests",
                newName: "IX_PersonInterests_InterestID");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonInterests_Interests_InterestID",
                table: "PersonInterests",
                column: "InterestID",
                principalTable: "Interests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonInterests_Links_LinkID",
                table: "PersonInterests",
                column: "LinkID",
                principalTable: "Links",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonInterests_Persons_PersonID",
                table: "PersonInterests",
                column: "PersonID",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonInterests_Interests_InterestID",
                table: "PersonInterests");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonInterests_Links_LinkID",
                table: "PersonInterests");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonInterests_Persons_PersonID",
                table: "PersonInterests");

            migrationBuilder.RenameColumn(
                name: "PersonID",
                table: "PersonInterests",
                newName: "PersonId");

            migrationBuilder.RenameColumn(
                name: "LinkID",
                table: "PersonInterests",
                newName: "LinkId");

            migrationBuilder.RenameColumn(
                name: "InterestID",
                table: "PersonInterests",
                newName: "InterestId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonInterests_PersonID",
                table: "PersonInterests",
                newName: "IX_PersonInterests_PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonInterests_LinkID",
                table: "PersonInterests",
                newName: "IX_PersonInterests_LinkId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonInterests_InterestID",
                table: "PersonInterests",
                newName: "IX_PersonInterests_InterestId");

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
    }
}
