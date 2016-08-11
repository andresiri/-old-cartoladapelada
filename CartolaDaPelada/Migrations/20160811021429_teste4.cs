using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CartolaDaPelada.Migrations
{
    public partial class teste4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SobreNome",
                table: "usuario",
                newName: "sobrenome");

            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "usuario",
                newName: "senha");

            migrationBuilder.RenameColumn(
                name: "Posicao",
                table: "usuario",
                newName: "posicao");

            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "usuario",
                newName: "numero");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "usuario",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "usuario",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Apelido",
                table: "usuario",
                newName: "apelido");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "usuario",
                newName: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "sobrenome",
                table: "usuario",
                newName: "SobreNome");

            migrationBuilder.RenameColumn(
                name: "senha",
                table: "usuario",
                newName: "Senha");

            migrationBuilder.RenameColumn(
                name: "posicao",
                table: "usuario",
                newName: "Posicao");

            migrationBuilder.RenameColumn(
                name: "numero",
                table: "usuario",
                newName: "Numero");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "usuario",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "usuario",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "apelido",
                table: "usuario",
                newName: "Apelido");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "usuario",
                newName: "Id");
        }
    }
}
