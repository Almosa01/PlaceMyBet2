﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlaceMyBet.Models;

namespace PlaceMyBet.Migrations
{
    [DbContext(typeof(PlaceMyBetContext))]
    partial class PlaceMyBetContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PlaceMyBet.Models.Apuesta", b =>
                {
                    b.Property<int>("apuestaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("correo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("dinero")
                        .HasColumnType("double");

                    b.Property<double>("mercado")
                        .HasColumnType("double");

                    b.Property<int?>("mercados2mercadoId")
                        .HasColumnType("int");

                    b.Property<string>("tipo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("usuarioId")
                        .HasColumnType("int");

                    b.HasKey("apuestaId");

                    b.HasIndex("mercados2mercadoId");

                    b.HasIndex("usuarioId");

                    b.ToTable("apuestas");

                    b.HasData(
                        new
                        {
                            apuestaId = 1,
                            correo = "pabloescobar@gmail.com",
                            dinero = 4000.0,
                            mercado = 1.5,
                            tipo = "over"
                        });
                });

            modelBuilder.Entity("PlaceMyBet.Models.CasaApuestas", b =>
                {
                    b.Property<int>("casaApuestasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Correo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NombreBanco")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Numtarjeta")
                        .HasColumnType("int");

                    b.Property<double>("SaldoActual")
                        .HasColumnType("double");

                    b.HasKey("casaApuestasId");

                    b.ToTable("casaApuestas");

                    b.HasData(
                        new
                        {
                            casaApuestasId = 1,
                            Correo = "pabloescobar@gmail.com",
                            NombreBanco = "Caixa",
                            Numtarjeta = 12345678,
                            SaldoActual = 4000.0
                        });
                });

            modelBuilder.Entity("PlaceMyBet.Models.Evento", b =>
                {
                    b.Property<int>("eventoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("fecha")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("mercado")
                        .HasColumnType("double");

                    b.Property<int?>("mercadoId")
                        .HasColumnType("int");

                    b.Property<string>("nombreLocal")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("nombreVisitante")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("eventoId");

                    b.HasIndex("mercadoId");

                    b.ToTable("eventos");

                    b.HasData(
                        new
                        {
                            eventoId = 1,
                            fecha = "12-12-2040",
                            mercado = 1.5,
                            nombreLocal = "Valencia",
                            nombreVisitante = "Real Madrid"
                        });
                });

            modelBuilder.Entity("PlaceMyBet.Models.Mercado", b =>
                {
                    b.Property<int>("mercadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("cuotaOver")
                        .HasColumnType("double");

                    b.Property<double>("cuotaUnder")
                        .HasColumnType("double");

                    b.Property<double>("dineroOver")
                        .HasColumnType("double");

                    b.Property<double>("dineroUnder")
                        .HasColumnType("double");

                    b.Property<double>("mercado")
                        .HasColumnType("double");

                    b.HasKey("mercadoId");

                    b.ToTable("mercados");

                    b.HasData(
                        new
                        {
                            mercadoId = 1,
                            cuotaOver = 60.0,
                            cuotaUnder = 40.0,
                            dineroOver = 200.0,
                            dineroUnder = 500.0,
                            mercado = 1.5
                        });
                });

            modelBuilder.Entity("PlaceMyBet.Models.Usuario", b =>
                {
                    b.Property<int>("usuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("apellido")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("casaApuestas2casaApuestasId")
                        .HasColumnType("int");

                    b.Property<int>("edad")
                        .HasColumnType("int");

                    b.Property<double>("mercado")
                        .HasColumnType("double");

                    b.Property<int?>("mercadoId")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("usuarioId");

                    b.HasIndex("casaApuestas2casaApuestasId");

                    b.HasIndex("mercadoId");

                    b.ToTable("usuarios");

                    b.HasData(
                        new
                        {
                            usuarioId = 1,
                            apellido = "Escobar",
                            edad = 50,
                            mercado = 1.5,
                            nombre = "Pablo"
                        });
                });

            modelBuilder.Entity("PlaceMyBet.Models.Apuesta", b =>
                {
                    b.HasOne("PlaceMyBet.Models.Mercado", "mercados2")
                        .WithMany()
                        .HasForeignKey("mercados2mercadoId");

                    b.HasOne("PlaceMyBet.Models.Usuario", null)
                        .WithMany("apuestas2")
                        .HasForeignKey("usuarioId");
                });

            modelBuilder.Entity("PlaceMyBet.Models.Evento", b =>
                {
                    b.HasOne("PlaceMyBet.Models.Mercado", null)
                        .WithMany("eventos2")
                        .HasForeignKey("mercadoId");
                });

            modelBuilder.Entity("PlaceMyBet.Models.Usuario", b =>
                {
                    b.HasOne("PlaceMyBet.Models.CasaApuestas", "casaApuestas2")
                        .WithMany()
                        .HasForeignKey("casaApuestas2casaApuestasId");

                    b.HasOne("PlaceMyBet.Models.Mercado", null)
                        .WithMany("usuarios2")
                        .HasForeignKey("mercadoId");
                });
#pragma warning restore 612, 618
        }
    }
}
