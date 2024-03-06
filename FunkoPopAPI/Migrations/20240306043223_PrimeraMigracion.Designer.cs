﻿// <auto-generated />
using FunkoPopAPI.DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FunkoPopAPI.Migrations
{
    [DbContext(typeof(FunkoPopDbContext))]
    [Migration("20240306043223_PrimeraMigracion")]
    partial class PrimeraMigracion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FunkoPopAPI.MODELS.Franquicia", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Franquicias");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Nombre = "Marvel"
                        },
                        new
                        {
                            ID = 2,
                            Nombre = "Back to the Future"
                        });
                });

            modelBuilder.Entity("FunkoPopAPI.MODELS.FranquiciaGenero", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("FranquiciaID")
                        .HasColumnType("int");

                    b.Property<int>("GeneroID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("FranquiciaID");

                    b.HasIndex("GeneroID");

                    b.ToTable("FranquiciaGenero");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            FranquiciaID = 1,
                            GeneroID = 1
                        },
                        new
                        {
                            ID = 2,
                            FranquiciaID = 2,
                            GeneroID = 2
                        });
                });

            modelBuilder.Entity("FunkoPopAPI.MODELS.FunkoPop", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("FunkoPops");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Descripcion = "Proveniente de Infinity War",
                            Nombre = "Thanos"
                        },
                        new
                        {
                            ID = 2,
                            Descripcion = "Proveniente de Back to the future",
                            Nombre = "Marty McFly"
                        });
                });

            modelBuilder.Entity("FunkoPopAPI.MODELS.FunkoPopFranquicia", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("FranquiciaID")
                        .HasColumnType("int");

                    b.Property<int>("FunkoPopID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("FranquiciaID");

                    b.HasIndex("FunkoPopID");

                    b.ToTable("FunkoPopFranquicia");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            FranquiciaID = 1,
                            FunkoPopID = 1
                        },
                        new
                        {
                            ID = 2,
                            FranquiciaID = 2,
                            FunkoPopID = 2
                        });
                });

            modelBuilder.Entity("FunkoPopAPI.MODELS.Genero", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Genero");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Descripcion = "Acción"
                        },
                        new
                        {
                            ID = 2,
                            Descripcion = "Fantasía"
                        });
                });

            modelBuilder.Entity("FunkoPopAPI.MODELS.FranquiciaGenero", b =>
                {
                    b.HasOne("FunkoPopAPI.MODELS.Franquicia", "Franquicia")
                        .WithMany()
                        .HasForeignKey("FranquiciaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FunkoPopAPI.MODELS.Genero", "Genero")
                        .WithMany()
                        .HasForeignKey("GeneroID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Franquicia");

                    b.Navigation("Genero");
                });

            modelBuilder.Entity("FunkoPopAPI.MODELS.FunkoPopFranquicia", b =>
                {
                    b.HasOne("FunkoPopAPI.MODELS.Franquicia", "Franquicia")
                        .WithMany()
                        .HasForeignKey("FranquiciaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FunkoPopAPI.MODELS.FunkoPop", "FunkoPop")
                        .WithMany()
                        .HasForeignKey("FunkoPopID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Franquicia");

                    b.Navigation("FunkoPop");
                });
#pragma warning restore 612, 618
        }
    }
}
