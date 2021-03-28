﻿// <auto-generated />
using System;
using ADUM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ADUM.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ADUM.Models.Token", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ADGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpiredTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("SamAccountName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tokens");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ADGroup = "G_INF_ADM",
                            ExpiredTime = new DateTime(2021, 3, 15, 8, 9, 14, 0, DateTimeKind.Unspecified),
                            SamAccountName = "dan",
                            StartTime = new DateTime(2021, 3, 15, 8, 4, 14, 0, DateTimeKind.Unspecified),
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            ADGroup = "G_INF_ADM",
                            ExpiredTime = new DateTime(2021, 3, 20, 18, 34, 14, 0, DateTimeKind.Unspecified),
                            SamAccountName = "toan",
                            StartTime = new DateTime(2021, 3, 20, 18, 24, 14, 0, DateTimeKind.Unspecified),
                            Status = 0
                        },
                        new
                        {
                            Id = 3,
                            ADGroup = "G_INF_ADM",
                            ExpiredTime = new DateTime(2021, 3, 21, 20, 4, 14, 0, DateTimeKind.Unspecified),
                            SamAccountName = "alex",
                            StartTime = new DateTime(2021, 3, 21, 12, 4, 14, 0, DateTimeKind.Unspecified),
                            Status = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
