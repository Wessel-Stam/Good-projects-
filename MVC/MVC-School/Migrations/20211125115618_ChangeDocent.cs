using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_School.Migrations
{
    public partial class ChangeDocent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Docent_Locatie_LocatieId",
                table: "Docent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locatie",
                table: "Locatie");

            migrationBuilder.RenameTable(
                name: "Locatie",
                newName: "Locaties");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locaties",
                table: "Locaties",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Docent_Locaties_LocatieId",
                table: "Docent",
                column: "LocatieId",
                principalTable: "Locaties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Docent_Locaties_LocatieId",
                table: "Docent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locaties",
                table: "Locaties");

            migrationBuilder.RenameTable(
                name: "Locaties",
                newName: "Locatie");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locatie",
                table: "Locatie",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Docent_Locatie_LocatieId",
                table: "Docent",
                column: "LocatieId",
                principalTable: "Locatie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
