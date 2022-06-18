using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace leadingpointDataAccess.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lookupcategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lookupcategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "projects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Country_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cities_countries_Country_Id",
                        column: x => x.Country_Id,
                        principalTable: "countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "lookups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    lookUpCategory_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lookups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_lookups_lookupcategories_lookUpCategory_ID",
                        column: x => x.lookUpCategory_ID,
                        principalTable: "lookupcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FName = table.Column<string>(nullable: false),
                    SName = table.Column<string>(nullable: false),
                    MName = table.Column<string>(nullable: false),
                    LName = table.Column<string>(nullable: false),
                    BDate = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Salary = table.Column<double>(nullable: false),
                    Project_Id = table.Column<int>(nullable: false),
                    City_Id = table.Column<int>(nullable: false),
                    Country_Id = table.Column<int>(nullable: false),
                    countryId = table.Column<int>(nullable: true),
                    Gender_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_employees_cities_City_Id",
                        column: x => x.City_Id,
                        principalTable: "cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employees_lookups_Gender_Id",
                        column: x => x.Gender_Id,
                        principalTable: "lookups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employees_projects_Project_Id",
                        column: x => x.Project_Id,
                        principalTable: "projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employees_countries_countryId",
                        column: x => x.countryId,
                        principalTable: "countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cities_Country_Id",
                table: "cities",
                column: "Country_Id");

            migrationBuilder.CreateIndex(
                name: "IX_employees_City_Id",
                table: "employees",
                column: "City_Id");

            migrationBuilder.CreateIndex(
                name: "IX_employees_Gender_Id",
                table: "employees",
                column: "Gender_Id");

            migrationBuilder.CreateIndex(
                name: "IX_employees_Project_Id",
                table: "employees",
                column: "Project_Id");

            migrationBuilder.CreateIndex(
                name: "IX_employees_countryId",
                table: "employees",
                column: "countryId");

            migrationBuilder.CreateIndex(
                name: "IX_lookups_lookUpCategory_ID",
                table: "lookups",
                column: "lookUpCategory_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "cities");

            migrationBuilder.DropTable(
                name: "lookups");

            migrationBuilder.DropTable(
                name: "projects");

            migrationBuilder.DropTable(
                name: "countries");

            migrationBuilder.DropTable(
                name: "lookupcategories");
        }
    }
}
