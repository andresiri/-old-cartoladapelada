using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CartolaDaPelada.Migrations
{
    public partial class teste3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Posicao",
                table: "usuario",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Numero",
                table: "usuario",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Posicao",
                table: "usuario",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Numero",
                table: "usuario",
                nullable: false);
        }
    }
}
