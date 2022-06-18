using Microsoft.EntityFrameworkCore.Migrations;

namespace leadingpointDataAccess.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_countries_countryId",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "Country_Id",
                table: "employees");

            migrationBuilder.RenameColumn(
                name: "countryId",
                table: "employees",
                newName: "CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_employees_countryId",
                table: "employees",
                newName: "IX_employees_CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_countries_CountryId",
                table: "employees",
                column: "CountryId",
                principalTable: "countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_countries_CountryId",
                table: "employees");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "employees",
                newName: "countryId");

            migrationBuilder.RenameIndex(
                name: "IX_employees_CountryId",
                table: "employees",
                newName: "IX_employees_countryId");

            migrationBuilder.AddColumn<int>(
                name: "Country_Id",
                table: "employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_countries_countryId",
                table: "employees",
                column: "countryId",
                principalTable: "countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
