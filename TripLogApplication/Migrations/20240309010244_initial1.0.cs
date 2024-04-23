using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TripLogApplication.Migrations
{
    public partial class initial10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Accommodation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccommodationPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccommodationEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThingsToDo1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThingsToDo2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThingsToDo3 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Accommodation", "AccommodationEmail", "AccommodationPhone", "Destination", "EndDate", "StartDate", "ThingsToDo1", "ThingsToDo2", "ThingsToDo3" },
                values: new object[] { 1, "Porkodi", "porkodi@gmail.com", "32423423434", "US", new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), "swim", "swim", "swim" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trips");
        }
    }
}
