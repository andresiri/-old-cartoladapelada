using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repositorio.Migrations
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
                    createdAt = table.Column<DateTime>(nullable: false),
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
                    createdAt = table.Column<DateTime>(nullable: false),
                    createdByUserId = table.Column<int>(nullable: false),
                    description = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pelada", x => x.id);
                    table.ForeignKey(
                        name: "ForeignKey_Pelada_UserId",
                        column: x => x.createdByUserId,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "peladaUser",
                columns: table => new
                {
                    peladaId = table.Column<int>(nullable: false),
                    userId = table.Column<int>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_peladaUser", x => new { x.peladaId, x.userId });
                    table.ForeignKey(
                        name: "ForeignKey_PeladaUser_PeladaId",
                        column: x => x.peladaId,
                        principalTable: "pelada",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "ForeignKey_PeladaUser_UserId",
                        column: x => x.userId,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_pelada_createdByUserId",
                table: "pelada",
                column: "createdByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_peladaUser_peladaId",
                table: "peladaUser",
                column: "peladaId");

            migrationBuilder.CreateIndex(
                name: "IX_peladaUser_userId",
                table: "peladaUser",
                column: "userId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "peladaUser");

            migrationBuilder.DropTable(
                name: "pelada");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
