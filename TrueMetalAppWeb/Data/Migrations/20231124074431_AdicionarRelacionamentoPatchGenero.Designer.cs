﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrueMetalAppWeb.Data;

#nullable disable

namespace TrueMetalAppWeb.Data.Migrations
{
    [DbContext(typeof(DistroDbContext))]
    [Migration("20231124074431_AdicionarRelacionamentoPatchGenero")]
    partial class AdicionarRelacionamentoPatchGenero
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TrueMetalAppWeb.Models.Genero", b =>
                {
                    b.Property<int>("GeneroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GeneroId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GeneroId");

                    b.ToTable("Genero");
                });

            modelBuilder.Entity("TrueMetalAppWeb.Models.Patch", b =>
                {
                    b.Property<int>("PatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatchId"));

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("EntregaExpressa")
                        .HasColumnType("bit");

                    b.Property<int?>("GeneroId")
                        .HasColumnType("int");

                    b.Property<string>("ImagemUri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.HasKey("PatchId");

                    b.HasIndex("GeneroId");

                    b.ToTable("Patch");
                });

            modelBuilder.Entity("TrueMetalAppWeb.Models.Patch", b =>
                {
                    b.HasOne("TrueMetalAppWeb.Models.Genero", null)
                        .WithMany("Patches")
                        .HasForeignKey("GeneroId");
                });

            modelBuilder.Entity("TrueMetalAppWeb.Models.Genero", b =>
                {
                    b.Navigation("Patches");
                });
#pragma warning restore 612, 618
        }
    }
}
