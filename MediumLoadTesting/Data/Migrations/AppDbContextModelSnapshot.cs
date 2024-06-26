﻿// <auto-generated />
using System;
using MediumLoadTesting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MediumLoadTesting.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MediumLoadTesting.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("BookId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            AuthorName = "AuthorName 1",
                            Name = "Name 1",
                            PublishedAt = new DateTime(2024, 5, 20, 14, 13, 39, 631, DateTimeKind.Utc).AddTicks(2500)
                        },
                        new
                        {
                            BookId = 2,
                            AuthorName = "AuthorName 2",
                            Name = "Name 2",
                            PublishedAt = new DateTime(2024, 5, 20, 14, 13, 39, 631, DateTimeKind.Utc).AddTicks(2500)
                        },
                        new
                        {
                            BookId = 3,
                            AuthorName = "AuthorName 3",
                            Name = "Name 3",
                            PublishedAt = new DateTime(2024, 5, 20, 14, 13, 39, 631, DateTimeKind.Utc).AddTicks(2510)
                        },
                        new
                        {
                            BookId = 4,
                            AuthorName = "AuthorName 4",
                            Name = "Name 4",
                            PublishedAt = new DateTime(2024, 5, 20, 14, 13, 39, 631, DateTimeKind.Utc).AddTicks(2510)
                        },
                        new
                        {
                            BookId = 5,
                            AuthorName = "AuthorName 5",
                            Name = "Name 5",
                            PublishedAt = new DateTime(2024, 5, 20, 14, 13, 39, 631, DateTimeKind.Utc).AddTicks(2510)
                        },
                        new
                        {
                            BookId = 6,
                            AuthorName = "AuthorName 6",
                            Name = "Name 6",
                            PublishedAt = new DateTime(2024, 5, 20, 14, 13, 39, 631, DateTimeKind.Utc).AddTicks(2510)
                        },
                        new
                        {
                            BookId = 7,
                            AuthorName = "AuthorName 7",
                            Name = "Name 7",
                            PublishedAt = new DateTime(2024, 5, 20, 14, 13, 39, 631, DateTimeKind.Utc).AddTicks(2520)
                        },
                        new
                        {
                            BookId = 8,
                            AuthorName = "AuthorName 8",
                            Name = "Name 8",
                            PublishedAt = new DateTime(2024, 5, 20, 14, 13, 39, 631, DateTimeKind.Utc).AddTicks(2520)
                        },
                        new
                        {
                            BookId = 9,
                            AuthorName = "AuthorName 9",
                            Name = "Name 9",
                            PublishedAt = new DateTime(2024, 5, 20, 14, 13, 39, 631, DateTimeKind.Utc).AddTicks(2520)
                        },
                        new
                        {
                            BookId = 10,
                            AuthorName = "AuthorName 10",
                            Name = "Name 10",
                            PublishedAt = new DateTime(2024, 5, 20, 14, 13, 39, 631, DateTimeKind.Utc).AddTicks(2520)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
