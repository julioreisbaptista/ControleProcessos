﻿// <auto-generated />
using System;
using ControleProcessos.DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ControleProcessos.Migrations
{
    [DbContext(typeof(ControleProcessosContext))]
    [Migration("20240416105855_ajuste3")]
    partial class ajuste3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ControleProcessos.DAL.Models.Area", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Area");
                });

            modelBuilder.Entity("ControleProcessos.DAL.Models.Processo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AreaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProcessoId")
                        .HasColumnType("int");

                    b.Property<int>("ProcessoTipoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProcessoId");

                    b.ToTable("Processo");
                });

            modelBuilder.Entity("ControleProcessos.DAL.Models.ProcessoTipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProcessoTipo");
                });

            modelBuilder.Entity("ControleProcessos.DAL.Models.Processo", b =>
                {
                    b.HasOne("ControleProcessos.DAL.Models.Processo", null)
                        .WithMany("Subprocessos")
                        .HasForeignKey("ProcessoId");
                });

            modelBuilder.Entity("ControleProcessos.DAL.Models.Processo", b =>
                {
                    b.Navigation("Subprocessos");
                });
#pragma warning restore 612, 618
        }
    }
}
