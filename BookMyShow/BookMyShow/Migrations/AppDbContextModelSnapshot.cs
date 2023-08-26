﻿// <auto-generated />
using System;
using BookMyShow.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookMyShow.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookMyShow.Model.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("BookMyShow.Model.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ShowId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ShowId")
                        .IsUnique();

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("BookMyShow.Model.Screen", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TheatreId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TheatreId");

                    b.ToTable("Screens");
                });

            modelBuilder.Entity("BookMyShow.Model.Seat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsOccupied")
                        .HasColumnType("bit");

                    b.Property<int>("SeatNo")
                        .HasColumnType("int");

                    b.Property<Guid>("ShowId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ShowId");

                    b.HasIndex("UserId");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("BookMyShow.Model.Show", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FromTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ScreenId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ToTime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ScreenId");

                    b.ToTable("Shows");
                });

            modelBuilder.Entity("BookMyShow.Model.Theatre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CityId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CityId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId1");

                    b.ToTable("Theatres");
                });

            modelBuilder.Entity("BookMyShow.Model.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("BookMyShow.Model.Movie", b =>
                {
                    b.HasOne("BookMyShow.Model.Show", "Show")
                        .WithOne("movie")
                        .HasForeignKey("BookMyShow.Model.Movie", "ShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Show");
                });

            modelBuilder.Entity("BookMyShow.Model.Screen", b =>
                {
                    b.HasOne("BookMyShow.Model.Theatre", "Theatre")
                        .WithMany("Screens")
                        .HasForeignKey("TheatreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Theatre");
                });

            modelBuilder.Entity("BookMyShow.Model.Seat", b =>
                {
                    b.HasOne("BookMyShow.Model.Show", "Show")
                        .WithMany("seats")
                        .HasForeignKey("ShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookMyShow.Model.User", "User")
                        .WithMany("seats")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Show");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookMyShow.Model.Show", b =>
                {
                    b.HasOne("BookMyShow.Model.Screen", "Screen")
                        .WithMany("shows")
                        .HasForeignKey("ScreenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Screen");
                });

            modelBuilder.Entity("BookMyShow.Model.Theatre", b =>
                {
                    b.HasOne("BookMyShow.Model.City", "City")
                        .WithMany("theatres")
                        .HasForeignKey("CityId1");

                    b.Navigation("City");
                });

            modelBuilder.Entity("BookMyShow.Model.City", b =>
                {
                    b.Navigation("theatres");
                });

            modelBuilder.Entity("BookMyShow.Model.Screen", b =>
                {
                    b.Navigation("shows");
                });

            modelBuilder.Entity("BookMyShow.Model.Show", b =>
                {
                    b.Navigation("movie");

                    b.Navigation("seats");
                });

            modelBuilder.Entity("BookMyShow.Model.Theatre", b =>
                {
                    b.Navigation("Screens");
                });

            modelBuilder.Entity("BookMyShow.Model.User", b =>
                {
                    b.Navigation("seats");
                });
#pragma warning restore 612, 618
        }
    }
}
