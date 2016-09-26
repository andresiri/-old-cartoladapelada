using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Repositorio.Contexto;

namespace Repositorio.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20160926233943_AddingNewTableArena")]
    partial class AddingNewTableArena
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("Domain.Entities.Arena", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("Latitude")
                        .HasColumnName("latitude")
                        .HasAnnotation("MaxLength", 30);

                    b.Property<string>("Longitude")
                        .HasColumnName("longitude")
                        .HasAnnotation("MaxLength", 30);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("arena");
                });

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

            modelBuilder.Entity("Domain.Entities.PeladaUser", b =>
                {
                    b.Property<int>("PeladaId")
                        .HasColumnName("peladaId");

                    b.Property<int>("UserId")
                        .HasColumnName("userId");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("createdAt");

                    b.Property<int>("Id")
                        .HasColumnName("id");

                    b.HasKey("PeladaId", "UserId");

                    b.HasAlternateKey("Id");

                    b.HasIndex("PeladaId");

                    b.HasIndex("UserId");

                    b.ToTable("peladaUser");
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
                    b.HasOne("Domain.Entities.User", "CreatedByUser")
                        .WithMany("Peladas")
                        .HasForeignKey("CreatedByUserId")
                        .HasConstraintName("ForeignKey_Pelada_UserId");
                });

            modelBuilder.Entity("Domain.Entities.PeladaUser", b =>
                {
                    b.HasOne("Domain.Entities.Pelada", "Pelada")
                        .WithMany("PeladaUsers")
                        .HasForeignKey("PeladaId")
                        .HasConstraintName("ForeignKey_PeladaUser_PeladaId");

                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany("PeladaUsers")
                        .HasForeignKey("UserId")
                        .HasConstraintName("ForeignKey_PeladaUser_UserId");
                });
        }
    }
}
