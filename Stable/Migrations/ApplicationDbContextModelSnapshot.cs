﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Stable.Data;

#nullable disable

namespace Stable.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Stable.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("End_date_time")
                        .HasColumnType("datetime2");

                    b.Property<string>("HorseId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LandId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Start_date_time")
                        .HasColumnType("datetime2");

                    b.Property<string>("TrainerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("HorseId");

                    b.HasIndex("LandId");

                    b.HasIndex("TrainerId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Stable.Models.CarePachage", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HorseId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HorseId");

                    b.ToTable("CarePachages");
                });

            modelBuilder.Entity("Stable.Models.Horse", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Health_Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<string>("Hoof_Condition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Is_For_Sale")
                        .HasColumnType("bit");

                    b.Property<string>("LandId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Last_Checkup_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Physical_Condition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rental_Price_Per_Hour")
                        .HasColumnType("float");

                    b.Property<double>("Selling_Price")
                        .HasColumnType("float");

                    b.Property<string>("TrainerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Training_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("LandId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("TrainerId");

                    b.ToTable("Horses");
                });

            modelBuilder.Entity("Stable.Models.Land", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Area")
                        .HasColumnType("float");

                    b.Property<double>("Hourly_Price")
                        .HasColumnType("float");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lands");
                });

            modelBuilder.Entity("Stable.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("TrainerId");

                    b.ToTable("Language");
                });

            modelBuilder.Entity("Stable.Models.Owner", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("Stable.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CarePachageId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("HorseId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LandId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(225)
                        .HasColumnType("nvarchar(225)");

                    b.Property<string>("OwnerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TrainerId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CarePachageId");

                    b.HasIndex("HorseId");

                    b.HasIndex("LandId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("TrainerId");

                    b.ToTable("Photo");
                });

            modelBuilder.Entity("Stable.Models.Trainer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Experience_Years")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Trainers");
                });

            modelBuilder.Entity("Stable.Models.Booking", b =>
                {
                    b.HasOne("Stable.Models.Horse", "Horse")
                        .WithMany("Bookings")
                        .HasForeignKey("HorseId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Stable.Models.Land", "Land")
                        .WithMany("Bookings")
                        .HasForeignKey("LandId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Stable.Models.Trainer", "Trainer")
                        .WithMany("Bookings")
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Horse");

                    b.Navigation("Land");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("Stable.Models.CarePachage", b =>
                {
                    b.HasOne("Stable.Models.Horse", "Horse")
                        .WithMany("Pachages")
                        .HasForeignKey("HorseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Horse");
                });

            modelBuilder.Entity("Stable.Models.Horse", b =>
                {
                    b.HasOne("Stable.Models.Land", "Land")
                        .WithMany("Horses")
                        .HasForeignKey("LandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Stable.Models.Owner", "Owner")
                        .WithMany("Horses")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Stable.Models.Trainer", "Trainer")
                        .WithMany("Horses")
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Land");

                    b.Navigation("Owner");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("Stable.Models.Language", b =>
                {
                    b.HasOne("Stable.Models.Trainer", "Trainer")
                        .WithMany("Languages")
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("Stable.Models.Photo", b =>
                {
                    b.HasOne("Stable.Models.CarePachage", "CarePachage")
                        .WithMany("Photos")
                        .HasForeignKey("CarePachageId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Stable.Models.Horse", "Horse")
                        .WithMany("Photos")
                        .HasForeignKey("HorseId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Stable.Models.Land", "Land")
                        .WithMany("Photos")
                        .HasForeignKey("LandId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Stable.Models.Owner", "Owner")
                        .WithMany("Photos")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Stable.Models.Trainer", "Trainer")
                        .WithMany("Photos")
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("CarePachage");

                    b.Navigation("Horse");

                    b.Navigation("Land");

                    b.Navigation("Owner");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("Stable.Models.CarePachage", b =>
                {
                    b.Navigation("Photos");
                });

            modelBuilder.Entity("Stable.Models.Horse", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Pachages");

                    b.Navigation("Photos");
                });

            modelBuilder.Entity("Stable.Models.Land", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Horses");

                    b.Navigation("Photos");
                });

            modelBuilder.Entity("Stable.Models.Owner", b =>
                {
                    b.Navigation("Horses");

                    b.Navigation("Photos");
                });

            modelBuilder.Entity("Stable.Models.Trainer", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Horses");

                    b.Navigation("Languages");

                    b.Navigation("Photos");
                });
#pragma warning restore 612, 618
        }
    }
}
