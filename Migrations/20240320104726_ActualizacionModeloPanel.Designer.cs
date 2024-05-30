﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SolarSoft_1._0.Context;

#nullable disable

namespace SolarSoft_1._0.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240320104726_ActualizacionModeloPanel")]
    partial class ActualizacionModeloPanel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SolarSoft_1._0.Models.Panel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("AnchoPanel")
                        .HasColumnType("float");

                    b.Property<double>("AnchoTerreno")
                        .HasColumnType("float");

                    b.Property<int>("AnguloEstructura")
                        .HasColumnType("int");

                    b.Property<double>("LargoTerreno")
                        .HasColumnType("float");

                    b.Property<double>("Latitud")
                        .HasColumnType("float");

                    b.Property<double>("Longitud")
                        .HasColumnType("float");

                    b.Property<double>("LongitudPanel")
                        .HasColumnType("float");

                    b.Property<string>("ModeloPanel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Potencia")
                        .HasColumnType("int");

                    b.Property<int?>("PotenciaTotal")
                        .HasColumnType("int");

                    b.Property<double?>("Separacion")
                        .HasColumnType("float");

                    b.Property<int?>("TotalPaneles")
                        .HasColumnType("int");

                    b.Property<double>("Voltaje")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Paneles");
                });
#pragma warning restore 612, 618
        }
    }
}
