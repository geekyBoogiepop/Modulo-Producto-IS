﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Modulo_Producto.Data;

#nullable disable

namespace Modulo_Producto.Migrations
{
    [DbContext(typeof(SQLiteContext))]
    partial class SQLiteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.19");

            modelBuilder.Entity("Modulo_Producto.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CantidadActual")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CodigoBarra")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float?>("Impuestos")
                        .IsRequired()
                        .HasColumnType("REAL");

                    b.Property<int?>("Minimo")
                        .HasColumnType("INTEGER");

                    b.Property<float?>("PrecioCosto")
                        .IsRequired()
                        .HasColumnType("REAL");

                    b.Property<float?>("PrecioMayoreo")
                        .IsRequired()
                        .HasColumnType("REAL");

                    b.Property<float?>("PrecioVenta")
                        .IsRequired()
                        .HasColumnType("REAL");

                    b.Property<bool>("TieneInventario")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("Modulo_Producto.Models.Venta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Caja")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cliente")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("IdProducto")
                        .HasColumnType("INTEGER");

                    b.Property<float?>("Total")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Venta");
                });
#pragma warning restore 612, 618
        }
    }
}
