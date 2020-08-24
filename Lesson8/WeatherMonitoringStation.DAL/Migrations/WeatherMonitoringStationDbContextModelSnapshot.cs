﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeatherMonitoringStation.DAL;

namespace WeatherMonitoringStation.DAL.Migrations
{
    [DbContext(typeof(WeatherMonitoringStationDbContext))]
    partial class WeatherMonitoringStationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WeatherMonitoringStation.DAL.Models.Weather", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Humadity")
                        .HasColumnType("int");

                    b.Property<int>("Pressure")
                        .HasColumnType("int");

                    b.Property<float>("Temprature")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("WeatherInformation");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "London",
                            Date = new DateTime(2020, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Humadity = 56,
                            Pressure = 1017,
                            Temprature = 294.45f
                        },
                        new
                        {
                            Id = 2,
                            City = "London",
                            Date = new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Humadity = 53,
                            Pressure = 1018,
                            Temprature = 294.44f
                        },
                        new
                        {
                            Id = 3,
                            City = "London",
                            Date = new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Humadity = 45,
                            Pressure = 1019,
                            Temprature = 290.44f
                        },
                        new
                        {
                            Id = 4,
                            City = "London",
                            Date = new DateTime(2020, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Humadity = 52,
                            Pressure = 1010,
                            Temprature = 291.43f
                        },
                        new
                        {
                            Id = 5,
                            City = "London",
                            Date = new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Humadity = 57,
                            Pressure = 1011,
                            Temprature = 294.3f
                        },
                        new
                        {
                            Id = 6,
                            City = "London",
                            Date = new DateTime(2020, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Humadity = 35,
                            Pressure = 1012,
                            Temprature = 293.44f
                        },
                        new
                        {
                            Id = 7,
                            City = "London",
                            Date = new DateTime(2020, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Humadity = 65,
                            Pressure = 1012,
                            Temprature = 292.44f
                        },
                        new
                        {
                            Id = 8,
                            City = "New York",
                            Date = new DateTime(2020, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Humadity = 56,
                            Pressure = 1017,
                            Temprature = 294.45f
                        },
                        new
                        {
                            Id = 9,
                            City = "New York",
                            Date = new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Humadity = 53,
                            Pressure = 1018,
                            Temprature = 294.44f
                        },
                        new
                        {
                            Id = 10,
                            City = "New York",
                            Date = new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Humadity = 45,
                            Pressure = 1019,
                            Temprature = 290.44f
                        },
                        new
                        {
                            Id = 11,
                            City = "New York",
                            Date = new DateTime(2020, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Humadity = 52,
                            Pressure = 1010,
                            Temprature = 291.43f
                        },
                        new
                        {
                            Id = 12,
                            City = "New York",
                            Date = new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Humadity = 57,
                            Pressure = 1011,
                            Temprature = 294.3f
                        },
                        new
                        {
                            Id = 13,
                            City = "New York",
                            Date = new DateTime(2020, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Humadity = 35,
                            Pressure = 1012,
                            Temprature = 293.44f
                        },
                        new
                        {
                            Id = 14,
                            City = "New York",
                            Date = new DateTime(2020, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Humadity = 65,
                            Pressure = 1012,
                            Temprature = 292.44f
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
