﻿// <auto-generated />
using System;
using CarStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarStore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarStore.Models.Car", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("CapacitateaMotorului")
                        .HasColumnType("real");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumarLocuri")
                        .HasColumnType("int");

                    b.Property<int>("NumarUsi")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<Guid>("ProdID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProducerProdID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TipTractiune")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipulCombustibilului")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Transmisie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ProducerProdID");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CarStore.Models.Producer", b =>
                {
                    b.Property<Guid>("ProdID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Denumire")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProdID");

                    b.ToTable("Producers");
                });

            modelBuilder.Entity("CarStore.Models.Car", b =>
                {
                    b.HasOne("CarStore.Models.Producer", "Producer")
                        .WithMany("Cars")
                        .HasForeignKey("ProducerProdID");

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("CarStore.Models.Producer", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}