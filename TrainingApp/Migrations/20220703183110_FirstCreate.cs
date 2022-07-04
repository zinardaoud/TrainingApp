using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingApp.Migrations
{
    public partial class FirstCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    MatchId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Field = table.Column<string>(nullable: false),
                    SessionDate = table.Column<DateTime>(nullable: false),
                    SessionStart = table.Column<string>(nullable: false),
                    SessionEnd = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.MatchId);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Position = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trainings",
                columns: table => new
                {
                    TrainingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Field = table.Column<string>(nullable: false),
                    SessionDate = table.Column<DateTime>(nullable: false),
                    SessionStart = table.Column<string>(nullable: false),
                    SessionEnd = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainings", x => x.TrainingId);
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "MatchId", "Field", "SessionDate", "SessionEnd", "SessionStart" },
                values: new object[,]
                {
                    { 1, "A", new DateTime(2022, 8, 2, 20, 31, 9, 590, DateTimeKind.Local).AddTicks(2308), "21:30", "20:00" },
                    { 2, "A", new DateTime(2022, 8, 7, 20, 31, 9, 592, DateTimeKind.Local).AddTicks(2281), "21:30", "20:00" },
                    { 3, "A", new DateTime(2022, 8, 12, 20, 31, 9, 592, DateTimeKind.Local).AddTicks(2281), "21:30", "20:00" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "Position" },
                values: new object[,]
                {
                    { 35, 20, "Miguel", "Gutierrez", "LB" },
                    { 25, 19, "Eduardo", "Camavinga", "CM" },
                    { 24, 28, "Mariano", "Diaz", "CF" },
                    { 23, 27, "Ferland", "Mendy", "LB" },
                    { 22, 29, "Antonio", "Rudiger", "CB" },
                    { 21, 21, "Rodrygo", "Goes", "RW" },
                    { 20, 21, "Vinicius", "Junior", "LW" },
                    { 19, 25, "Dani", "Ceballos", "CM" },
                    { 18, 22, "Aurelien", "Tchoumeni", "CDM" },
                    { 17, 31, "Lucas", "Vazquez", "RB" },
                    { 16, 24, "Luka", "Jovic", "CF" },
                    { 15, 23, "Federico", "Valverde", "CM" },
                    { 14, 30, "Carlos", "Casemiro", "CDM" },
                    { 13, 23, "Andriy", "Lunin", "GK" },
                    { 11, 26, "Marco", "Asensio", "RW" },
                    { 10, 36, "Luka", "Modric", "CM" },
                    { 9, 34, "Karim", "Benzema", "CF" },
                    { 8, 32, "Toni", "Kroos", "CM" },
                    { 7, 31, "Eden", "Hazard", "LW" },
                    { 6, 32, "Nacho", "Fernandez", "CB" },
                    { 5, 25, "Jesus", "Vallejo", "CB" },
                    { 4, 30, "David", "Alaba", "CB" },
                    { 3, 24, "Eder", "Militao", "CB" },
                    { 2, 30, "Daniel", "Carvajal", "RB" },
                    { 1, 30, "Thibaut", "Courtois", "GK" }
                });

            migrationBuilder.InsertData(
                table: "Trainings",
                columns: new[] { "TrainingId", "Field", "SessionDate", "SessionEnd", "SessionStart" },
                values: new object[,]
                {
                    { 1, "B", new DateTime(2022, 7, 5, 20, 31, 9, 592, DateTimeKind.Local).AddTicks(2281), "21:30", "20:00" },
                    { 2, "B", new DateTime(2022, 7, 7, 20, 31, 9, 592, DateTimeKind.Local).AddTicks(2281), "21:30", "20:00" },
                    { 3, "B", new DateTime(2022, 7, 9, 20, 31, 9, 592, DateTimeKind.Local).AddTicks(2281), "21:30", "20:00" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Trainings");
        }
    }
}
