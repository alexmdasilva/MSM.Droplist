using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class MapDrop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MapDrops",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MapId = table.Column<int>(type: "int", nullable: false),
                    TotalRate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapDrops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemDrops",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MonsterId = table.Column<int>(type: "int", nullable: false),
                    ItemCat = table.Column<int>(type: "int", nullable: false),
                    ItemIndex = table.Column<int>(type: "int", nullable: false),
                    Skill = table.Column<int>(type: "int", nullable: false),
                    Luck = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MapDropId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemDrops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemDrops_MapDrops_MapDropId",
                        column: x => x.MapDropId,
                        principalTable: "MapDrops",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemDrops_MapDropId",
                table: "ItemDrops",
                column: "MapDropId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemDrops");

            migrationBuilder.DropTable(
                name: "MapDrops");
        }
    }
}
