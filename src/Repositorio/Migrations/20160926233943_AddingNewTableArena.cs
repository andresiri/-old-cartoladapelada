using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repositorio.Migrations
{
    public partial class AddingNewTableArena : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "arena",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGeneratedOnAdd", true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    description = table.Column<string>(maxLength: 100, nullable: false),
                    latitude = table.Column<string>(maxLength: 30, nullable: true),
                    longitude = table.Column<string>(maxLength: 30, nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_arena", x => x.id);
                });

            migrationBuilder.AddUniqueConstraint(
                name: "AK_peladaUser_id",
                table: "peladaUser",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_peladaUser_id",
                table: "peladaUser");

            migrationBuilder.DropTable(
                name: "arena");
        }
    }
}
