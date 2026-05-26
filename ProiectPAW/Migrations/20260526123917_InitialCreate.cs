using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComertApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Magazine",
                columns: table => new
                {
                    IdMagazin = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nume = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Adresa = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Magazine", x => x.IdMagazin);
                });

            migrationBuilder.CreateTable(
                name: "Raioane",
                columns: table => new
                {
                    IdRaion = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nume = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    NumarAngajati = table.Column<int>(type: "INTEGER", nullable: false),
                    IdMagazin = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Raioane", x => x.IdRaion);
                    table.ForeignKey(
                        name: "FK_Raioane_Magazine_IdMagazin",
                        column: x => x.IdMagazin,
                        principalTable: "Magazine",
                        principalColumn: "IdMagazin",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Desfaceri",
                columns: table => new
                {
                    IdDesfacere = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProdusVandut = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Cantitate = table.Column<int>(type: "INTEGER", nullable: false),
                    Valoare = table.Column<decimal>(type: "TEXT", nullable: false),
                    DataVanzarii = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    IdRaion = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desfaceri", x => x.IdDesfacere);
                    table.ForeignKey(
                        name: "FK_Desfaceri_Raioane_IdRaion",
                        column: x => x.IdRaion,
                        principalTable: "Raioane",
                        principalColumn: "IdRaion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Desfaceri_IdRaion",
                table: "Desfaceri",
                column: "IdRaion");

            migrationBuilder.CreateIndex(
                name: "IX_Raioane_IdMagazin",
                table: "Raioane",
                column: "IdMagazin");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Desfaceri");

            migrationBuilder.DropTable(
                name: "Raioane");

            migrationBuilder.DropTable(
                name: "Magazine");
        }
    }
}
