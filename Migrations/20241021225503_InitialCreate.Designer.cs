﻿// <auto-generated />
using System;
using GestionFacturasApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestionFacturasApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241021225503_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GestionFacturasApp.Models.FacturaCabecera", b =>
                {
                    b.Property<int>("IdFactura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFactura"));

                    b.Property<bool>("ExentaIVA")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaFactura")
                        .HasColumnType("datetime2");

                    b.Property<string>("GlosaFactura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdEstadoFactura")
                        .HasColumnType("int");

                    b.Property<int>("IdProveedor")
                        .HasColumnType("int");

                    b.Property<int>("ProveedorIdProveedor")
                        .HasColumnType("int");

                    b.HasKey("IdFactura");

                    b.HasIndex("ProveedorIdProveedor");

                    b.ToTable("FacturasCabecera");
                });

            modelBuilder.Entity("GestionFacturasApp.Models.FacturaDetalle", b =>
                {
                    b.Property<int>("IdFacturaDetalle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFacturaDetalle"));

                    b.Property<decimal>("CantidadItem")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CodigoItem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FacturaCabeceraIdFactura")
                        .HasColumnType("int");

                    b.Property<int>("IdFactura")
                        .HasColumnType("int");

                    b.Property<string>("NombreItem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NroItem")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioUnitarioItem")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SubTotalItem")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UnidadItem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdFacturaDetalle");

                    b.HasIndex("FacturaCabeceraIdFactura");

                    b.ToTable("FacturasDetalle");
                });

            modelBuilder.Entity("GestionFacturasApp.Models.Proveedor", b =>
                {
                    b.Property<int>("IdProveedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProveedor"));

                    b.Property<string>("CiudadProveedor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComunaProveedor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FonoProveedor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GiroProveedor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreProveedor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RutProveedor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdProveedor");

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("GestionFacturasApp.Models.FacturaCabecera", b =>
                {
                    b.HasOne("GestionFacturasApp.Models.Proveedor", "Proveedor")
                        .WithMany("FacturasCabecera")
                        .HasForeignKey("ProveedorIdProveedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("GestionFacturasApp.Models.FacturaDetalle", b =>
                {
                    b.HasOne("GestionFacturasApp.Models.FacturaCabecera", "FacturaCabecera")
                        .WithMany("FacturaDetalles")
                        .HasForeignKey("FacturaCabeceraIdFactura")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FacturaCabecera");
                });

            modelBuilder.Entity("GestionFacturasApp.Models.FacturaCabecera", b =>
                {
                    b.Navigation("FacturaDetalles");
                });

            modelBuilder.Entity("GestionFacturasApp.Models.Proveedor", b =>
                {
                    b.Navigation("FacturasCabecera");
                });
#pragma warning restore 612, 618
        }
    }
}