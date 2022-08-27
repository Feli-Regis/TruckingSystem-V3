﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TruckingSystem_V3.DBContexts;

#nullable disable

namespace TruckingSystem_V3.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220827033539_SecondMigration")]
    partial class SecondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("TruckingSystem_V3.Entities.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("SourceAndDestiny")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("TruckerId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TruckerId");

                    b.ToTable("Trips");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "400 Km de distancia.",
                            SourceAndDestiny = "Rosario a Buenos Aires",
                            TruckerId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "50 Km de distancia.",
                            SourceAndDestiny = "Galvez a Funes",
                            TruckerId = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "350 Km de distacnia.",
                            SourceAndDestiny = "Fisherton a Buenos Aires",
                            TruckerId = 2
                        },
                        new
                        {
                            Id = 4,
                            Description = "70 Km de distancia.",
                            SourceAndDestiny = "Funes a Rosario",
                            TruckerId = 2
                        },
                        new
                        {
                            Id = 5,
                            Description = "30 Km de distancia.",
                            SourceAndDestiny = "Capitan Bermudez a Rosario",
                            TruckerId = 3
                        },
                        new
                        {
                            Id = 6,
                            Description = "300 Km de distancia.",
                            SourceAndDestiny = "Funes a Buenos Aires",
                            TruckerId = 3
                        });
                });

            modelBuilder.Entity("TruckingSystem_V3.Entities.Trucker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NameAndLastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("TruckerType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Truckers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NameAndLastName = "Rodrigo Fernandez",
                            TruckerType = "Cisterna."
                        },
                        new
                        {
                            Id = 2,
                            NameAndLastName = "Antionio Gimenez",
                            TruckerType = "Carga Seca."
                        },
                        new
                        {
                            Id = 3,
                            NameAndLastName = "Lucas Lopez",
                            TruckerType = "Carga Refrigerada."
                        });
                });

            modelBuilder.Entity("TruckingSystem_V3.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasMaxLength(32)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(32)
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LastName = "Regis",
                            Name = "Felipe",
                            Password = "feli99",
                            Role = 0,
                            UserName = "feliregis"
                        },
                        new
                        {
                            Id = 2,
                            LastName = "Garcia",
                            Name = "Mateo",
                            Password = "mateo99",
                            Role = 0,
                            UserName = "mategarcia"
                        },
                        new
                        {
                            Id = 3,
                            LastName = "Urushima",
                            Name = "Gabriel",
                            Password = "gabi99",
                            Role = 0,
                            UserName = "gabiurushima"
                        });
                });

            modelBuilder.Entity("TruckingSystem_V3.Entities.Trip", b =>
                {
                    b.HasOne("TruckingSystem_V3.Entities.Trucker", "Trucker")
                        .WithMany("Trips")
                        .HasForeignKey("TruckerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trucker");
                });

            modelBuilder.Entity("TruckingSystem_V3.Entities.Trucker", b =>
                {
                    b.Navigation("Trips");
                });
#pragma warning restore 612, 618
        }
    }
}