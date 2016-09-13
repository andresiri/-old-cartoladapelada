using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CartolaDaPelada.Migrations
{
    public partial class Database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGeneratedOnAdd", true),
                    email = table.Column<string>(maxLength: 100, nullable: false),
                    firstName = table.Column<string>(maxLength: 100, nullable: false),
                    lastName = table.Column<string>(maxLength: 100, nullable: true),
                    nickname = table.Column<string>(maxLength: 100, nullable: true),
                    number = table.Column<byte>(nullable: false),
                    password = table.Column<string>(maxLength: 100, nullable: false),
                    position = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pelada",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGeneratedOnAdd", true),
                    createdByUserId = table.Column<int>(nullable: false),
                    description = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pelada", x => x.id);
                    table.ForeignKey(
                        name: "ForeignKey_Pelada_User",
                        column: x => x.createdByUserId,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_pelada_createdByUserId",
                table: "pelada",
                column: "createdByUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pelada");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
