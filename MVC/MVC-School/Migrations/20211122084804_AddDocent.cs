﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_School.Migrations
{
    public partial class AddDocent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Docent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Achternaam = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    LocatieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Docent_Locatie_LocatieId",
                        column: x => x.LocatieId,
                        principalTable: "Locatie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Docent_LocatieId",
                table: "Docent",
                column: "LocatieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Docent");

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
        }
    }
}
