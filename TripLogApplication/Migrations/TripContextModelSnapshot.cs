﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TripLogApplication.Data;

#nullable disable

namespace TripLogApplication.Migrations
{
    [DbContext(typeof(TripContext))]
    partial class TripContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TripLogApplication.Models.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Accommodation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccommodationEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccommodationPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ThingsToDo1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThingsToDo2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThingsToDo3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Trips");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Accommodation = "Porkodi",
                            AccommodationEmail = "porkodi@gmail.com",
                            AccommodationPhone = "32423423434",
                            Destination = "US",
                            EndDate = new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Local),
                            StartDate = new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Local),
                            ThingsToDo1 = "swim",
                            ThingsToDo2 = "swim",
                            ThingsToDo3 = "swim"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
