﻿// <auto-generated />
using AvanceradDotNet_Labb4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AvanceradDotNet_Labb4.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230506120638_initial-creation")]
    partial class initialcreation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AvanceradDotNet_Labb4.Models.Interest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Interests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "En sport där man sparkar på en boll för att göra mål",
                            Name = "Fotboll"
                        },
                        new
                        {
                            Id = 2,
                            Description = "En sport där man studsar en boll och ska kasta den i en korg",
                            Name = "Basket"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Man rider runt på en häst",
                            Name = "Hästridning"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Måla tavlor mm.",
                            Name = "Måla"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Spela brädspel med andra",
                            Name = "Brädspel"
                        });
                });

            modelBuilder.Entity("AvanceradDotNet_Labb4.Models.Link", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("LinkName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Links");
                });

            modelBuilder.Entity("AvanceradDotNet_Labb4.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Sara73@gmail.com",
                            Name = "Sara Henriksson",
                            Phone = 735349253
                        },
                        new
                        {
                            Id = 2,
                            Email = "KalleB@gmail.com",
                            Name = "Karl Bengtsson",
                            Phone = 730569349
                        },
                        new
                        {
                            Id = 3,
                            Email = "JonasFaltgren@gmail.com",
                            Name = "Jonas Fältgren",
                            Phone = 745560443
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
