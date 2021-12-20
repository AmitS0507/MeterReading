﻿// <auto-generated />
using System;
using MeterReadings.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MeterReadings.API.Migrations
{
    [DbContext(typeof(MeterReadingContext))]
    [Migration("20211220222831_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MeterReadings.API.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Account");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountId = 2344,
                            FirstName = "Tommy",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 2,
                            AccountId = 2233,
                            FirstName = "Bany",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 3,
                            AccountId = 8766,
                            FirstName = "Sally",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 4,
                            AccountId = 2345,
                            FirstName = "Jerry",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 5,
                            AccountId = 2345,
                            FirstName = "Jerry",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 6,
                            AccountId = 2345,
                            FirstName = "Jerry",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 7,
                            AccountId = 2345,
                            FirstName = "Jerry",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 8,
                            AccountId = 2345,
                            FirstName = "Jerry",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 9,
                            AccountId = 2346,
                            FirstName = "Ollie",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 10,
                            AccountId = 2347,
                            FirstName = "Tera",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 11,
                            AccountId = 2348,
                            FirstName = "Tammy",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 12,
                            AccountId = 2349,
                            FirstName = "Simon",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 13,
                            AccountId = 2350,
                            FirstName = "Colin",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 14,
                            AccountId = 2351,
                            FirstName = "Gladys",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = 15,
                            AccountId = 2352,
                            FirstName = "Greg",
                            LastName = "Test"
                        });
                });

            modelBuilder.Entity("MeterReadings.API.Models.MeterReading", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("MeterReadValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MeterReadingDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("MeterReading");
                });
#pragma warning restore 612, 618
        }
    }
}