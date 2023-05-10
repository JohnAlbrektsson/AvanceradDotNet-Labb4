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
    [Migration("20230507121817_FixIDs")]
    partial class FixIDs
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
                    b.Property<int>("InterestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InterestId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InterestId");

                    b.ToTable("Interests");

                    b.HasData(
                        new
                        {
                            InterestId = 1,
                            Description = "En sport där man sparkar på en boll för att göra mål",
                            Name = "Fotboll"
                        },
                        new
                        {
                            InterestId = 2,
                            Description = "En sport där man studsar en boll och ska kasta den i en korg",
                            Name = "Basket"
                        },
                        new
                        {
                            InterestId = 3,
                            Description = "Man rider runt på en häst",
                            Name = "Hästridning"
                        },
                        new
                        {
                            InterestId = 4,
                            Description = "Måla tavlor mm.",
                            Name = "Måla"
                        },
                        new
                        {
                            InterestId = 5,
                            Description = "Spela brädspel med andra",
                            Name = "Brädspel"
                        });
                });

            modelBuilder.Entity("AvanceradDotNet_Labb4.Models.Link", b =>
                {
                    b.Property<int>("LinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LinkId"));

                    b.Property<string>("LinkName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LinkId");

                    b.ToTable("Links");
                });

            modelBuilder.Entity("AvanceradDotNet_Labb4.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            PersonId = 1,
                            Email = "Sara73@gmail.com",
                            Name = "Sara Henriksson",
                            Phone = 735349253
                        },
                        new
                        {
                            PersonId = 2,
                            Email = "KalleB@gmail.com",
                            Name = "Karl Bengtsson",
                            Phone = 730569349
                        },
                        new
                        {
                            PersonId = 3,
                            Email = "JonasFaltgren@gmail.com",
                            Name = "Jonas Fältgren",
                            Phone = 745560443
                        });
                });

            modelBuilder.Entity("AvanceradDotNet_Labb4.Models.PersonInterest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("InterestID")
                        .HasColumnType("int");

                    b.Property<int>("LinkID")
                        .HasColumnType("int");

                    b.Property<int>("PersonID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InterestID");

                    b.HasIndex("LinkID");

                    b.HasIndex("PersonID");

                    b.ToTable("PersonInterests");
                });

            modelBuilder.Entity("AvanceradDotNet_Labb4.Models.PersonInterest", b =>
                {
                    b.HasOne("AvanceradDotNet_Labb4.Models.Interest", "Interest")
                        .WithMany()
                        .HasForeignKey("InterestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AvanceradDotNet_Labb4.Models.Link", "Link")
                        .WithMany()
                        .HasForeignKey("LinkID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AvanceradDotNet_Labb4.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Interest");

                    b.Navigation("Link");

                    b.Navigation("Person");
                });
#pragma warning restore 612, 618
        }
    }
}
