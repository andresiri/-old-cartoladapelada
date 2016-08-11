using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Repositorio.Contexto;

namespace CartolaDaPelada.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20160811021429_teste4")]
    partial class teste4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Apelido")
                        .HasColumnName("apelido")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("nome")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<byte>("Numero")
                        .HasColumnName("numero");

                    b.Property<string>("Posicao")
                        .HasColumnName("posicao")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnName("senha")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("SobreNome")
                        .HasColumnName("sobrenome")
                        .HasAnnotation("MaxLength", 100);

                    b.HasKey("Id");

                    b.ToTable("usuario");
                });
        }
    }
}
