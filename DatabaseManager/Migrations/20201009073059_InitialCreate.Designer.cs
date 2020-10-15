﻿// <auto-generated />
using DatabaseManager;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DatabaseManager.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20201009073059_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("DatabaseManager.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Battery")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DisplaySize")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DisplayType")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TouchScreen")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
