﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorCountry.Data;

#nullable disable

namespace RazorCountry.Migrations
{
    [DbContext(typeof(CountryContext))]
    [Migration("20230217093943_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("RazorCountry.Models.Continent", b =>
                {
                    b.Property<string>("ID")
                        .HasMaxLength(2)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Continents");
                });

            modelBuilder.Entity("RazorCountry.Models.Country", b =>
                {
                    b.Property<string>("ID")
                        .HasMaxLength(3)
                        .HasColumnType("TEXT");

                    b.Property<int?>("Area")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ContinentID")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("Population")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("UnitedNationsDate")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Countries");
                });
#pragma warning restore 612, 618
        }
    }
}
