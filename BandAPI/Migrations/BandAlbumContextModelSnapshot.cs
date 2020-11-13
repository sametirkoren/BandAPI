﻿// <auto-generated />
using System;
using BandAPI.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BandAPI.Migrations
{
    [DbContext(typeof(BandAlbumContext))]
    partial class BandAlbumContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BandAPI.Entities.Album", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("BandId");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b1256790-99f3-461c-8601-c9326e1b026f"),
                            BandId = new Guid("9433d064-bb01-46bf-a2af-b57fe93f5da1"),
                            Description = "One of the best heavy metal albums ever",
                            Title = "Master Of Puppets"
                        },
                        new
                        {
                            Id = new Guid("1b515fc1-2b9b-4256-959f-76ea6fa07e94"),
                            BandId = new Guid("56b8cbac-c3a4-4717-9dba-3724e8d0543b"),
                            Description = "Amazing Rock album with raw sound",
                            Title = "Appetite for Destruction"
                        },
                        new
                        {
                            Id = new Guid("68bba4bc-d02c-4cde-a513-993073495b04"),
                            BandId = new Guid("9e7bece4-765d-48b6-a56c-6fb237b07a1f"),
                            Description = "Amazing Rap album with raw sound",
                            Title = "Nows Da Time"
                        });
                });

            modelBuilder.Entity("BandAPI.Entities.Band", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Founded")
                        .HasColumnType("datetime2");

                    b.Property<string>("MainGenre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Bands");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9433d064-bb01-46bf-a2af-b57fe93f5da1"),
                            Founded = new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MainGenre = "Heavy Metal",
                            Name = "Metallica"
                        },
                        new
                        {
                            Id = new Guid("56b8cbac-c3a4-4717-9dba-3724e8d0543b"),
                            Founded = new DateTime(1985, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MainGenre = "Rock",
                            Name = "Guns N Roses"
                        },
                        new
                        {
                            Id = new Guid("9e7bece4-765d-48b6-a56c-6fb237b07a1f"),
                            Founded = new DateTime(1997, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MainGenre = "Rap",
                            Name = "TalKing Gunz"
                        });
                });

            modelBuilder.Entity("BandAPI.Entities.Album", b =>
                {
                    b.HasOne("BandAPI.Entities.Band", "Band")
                        .WithMany("Albums")
                        .HasForeignKey("BandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Band");
                });

            modelBuilder.Entity("BandAPI.Entities.Band", b =>
                {
                    b.Navigation("Albums");
                });
#pragma warning restore 612, 618
        }
    }
}
