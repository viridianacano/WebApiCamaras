﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiCamaras;

#nullable disable

namespace WebApiCamaras.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230308045023_Marcas2")]
    partial class Marcas2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.1.23111.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApiCamaras.Entidades.Camara", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Camaras");
                });

            modelBuilder.Entity("WebApiCamaras.Entidades.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CamaraId")
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CamaraId");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("WebApiCamaras.Entidades.Marca", b =>
                {
                    b.HasOne("WebApiCamaras.Entidades.Camara", "Camara")
                        .WithMany("marcas")
                        .HasForeignKey("CamaraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Camara");
                });

            modelBuilder.Entity("WebApiCamaras.Entidades.Camara", b =>
                {
                    b.Navigation("marcas");
                });
#pragma warning restore 612, 618
        }
    }
}
