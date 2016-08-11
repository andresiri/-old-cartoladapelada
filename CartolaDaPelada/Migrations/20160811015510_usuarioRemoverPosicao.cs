using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CartolaDaPelada.Migrations
{
    public partial class usuarioRemoverPosicao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Posicao",
                table: "usuario",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Posicao",
                table: "usuario",
                maxLength: 50,
                nullable: true);
        }
    }
}
