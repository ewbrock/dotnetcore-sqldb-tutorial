using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreSqlDb.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Climate",
                columns: table => new
                {
                    ClimateID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Rain_in_Winter = table.Column<string>(nullable: true),
                    Rain_during_Growing_Season = table.Column<string>(nullable: true),
                    Rain_during_Harvest = table.Column<string>(nullable: true),
                    Temp_in_Winter = table.Column<string>(nullable: true),
                    Temp_during_Growing_Season = table.Column<string>(nullable: true),
                    Temp_Continentality = table.Column<string>(nullable: true),
                    Temp_Diurnal = table.Column<string>(nullable: true),
                    Vintage_Variation = table.Column<string>(nullable: true),
                    Proximity_to_Large_Bodies_of_Water = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Climate", x => x.ClimateID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Climate");
        }
    }
}
