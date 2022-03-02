using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class Monsters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemDrops_MapDrops_MapDropId",
                table: "ItemDrops");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Maps",
                table: "Maps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MapDrops",
                table: "MapDrops");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemDrops",
                table: "ItemDrops");

            migrationBuilder.RenameTable(
                name: "Maps",
                newName: "Map");

            migrationBuilder.RenameTable(
                name: "MapDrops",
                newName: "MapDrop");

            migrationBuilder.RenameTable(
                name: "ItemDrops",
                newName: "ItemDrop");

            migrationBuilder.RenameIndex(
                name: "IX_ItemDrops_MapDropId",
                table: "ItemDrop",
                newName: "IX_ItemDrop_MapDropId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Map",
                table: "Map",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MapDrop",
                table: "MapDrop",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemDrop",
                table: "ItemDrop",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Monster",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Index = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monster", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ItemDrop_MapDrop_MapDropId",
                table: "ItemDrop",
                column: "MapDropId",
                principalTable: "MapDrop",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemDrop_MapDrop_MapDropId",
                table: "ItemDrop");

            migrationBuilder.DropTable(
                name: "Monster");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MapDrop",
                table: "MapDrop");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Map",
                table: "Map");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemDrop",
                table: "ItemDrop");

            migrationBuilder.RenameTable(
                name: "MapDrop",
                newName: "MapDrops");

            migrationBuilder.RenameTable(
                name: "Map",
                newName: "Maps");

            migrationBuilder.RenameTable(
                name: "ItemDrop",
                newName: "ItemDrops");

            migrationBuilder.RenameIndex(
                name: "IX_ItemDrop_MapDropId",
                table: "ItemDrops",
                newName: "IX_ItemDrops_MapDropId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MapDrops",
                table: "MapDrops",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Maps",
                table: "Maps",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemDrops",
                table: "ItemDrops",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemDrops_MapDrops_MapDropId",
                table: "ItemDrops",
                column: "MapDropId",
                principalTable: "MapDrops",
                principalColumn: "Id");
        }
    }
}
