using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Repositorio.Contexto;

namespace CartolaDaPelada.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20160915221209_addedCreatedAtColumn")]
    partial class addedCreatedAtColumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("Domain.Entities.Pelada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("createdAt");

                    b.Property<int>("CreatedByUserId")
                        .HasColumnName("createdByUserId");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasAnnotation("MaxLength", 50);

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.ToTable("pelada");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("createdAt");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("firstName")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("LastName")
                        .HasColumnName("lastName")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("Nickname")
                        .HasColumnName("nickname")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<byte>("Number")
                        .HasColumnName("number");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("password")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("Position")
                        .HasColumnName("position")
                        .HasAnnotation("MaxLength", 100);

                    b.HasKey("Id");

                    b.ToTable("user");
                });

            modelBuilder.Entity("Domain.Entities.Pelada", b =>
                {
                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany("Peladas")
                        .HasForeignKey("CreatedByUserId")
                        .HasConstraintName("ForeignKey_Pelada_User")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
