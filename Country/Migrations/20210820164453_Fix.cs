using Microsoft.EntityFrameworkCore.Migrations;

namespace Country.Migrations
{
    public partial class Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Cities_CaptialId",
                table: "Countries");

            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Regions_RegionId",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "CaptialId",
                table: "Country",
                newName: "CapitalId");

            migrationBuilder.RenameIndex(
                name: "IX_Countries_RegionId",
                table: "Country",
                newName: "IX_Country_RegionId");

            migrationBuilder.RenameIndex(
                name: "IX_Countries_CaptialId",
                table: "Country",
                newName: "IX_Country_CapitalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Country",
                table: "Country",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Country_Cities_CapitalId",
                table: "Country",
                column: "CapitalId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Country_Regions_RegionId",
                table: "Country",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Country_Cities_CapitalId",
                table: "Country");

            migrationBuilder.DropForeignKey(
                name: "FK_Country_Regions_RegionId",
                table: "Country");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Country",
                table: "Country");

            migrationBuilder.RenameTable(
                name: "Country",
                newName: "Countries");

            migrationBuilder.RenameColumn(
                name: "CapitalId",
                table: "Countries",
                newName: "CaptialId");

            migrationBuilder.RenameIndex(
                name: "IX_Country_RegionId",
                table: "Countries",
                newName: "IX_Countries_RegionId");

            migrationBuilder.RenameIndex(
                name: "IX_Country_CapitalId",
                table: "Countries",
                newName: "IX_Countries_CaptialId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Cities_CaptialId",
                table: "Countries",
                column: "CaptialId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Regions_RegionId",
                table: "Countries",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
