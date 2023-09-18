﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportYar.Repository.Implimentation;

#nullable disable

namespace SportYar.Repository.Implimentation.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230918101641_AddUserEntity")]
    partial class AddUserEntity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SportYar.Domain.Entites.Announcement", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(4947));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndingTimeInPersian")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsExpired")
                        .HasColumnType("bit");

                    b.Property<int>("Participant")
                        .HasColumnType("int");

                    b.Property<int>("PricePerparticipant")
                        .HasColumnType("int");

                    b.Property<string>("RegionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SportType")
                        .HasColumnType("int");

                    b.Property<string>("StartingTimeInPersian")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(5220));

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Announcements");
                });

            modelBuilder.Entity("SportYar.Domain.Entites.City", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(6442));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProvinceId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(6719));

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("SportYar.Domain.Entites.Province", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(7146));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(7414));

                    b.HasKey("Id");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("SportYar.Domain.Entites.Region", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CityId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(5716));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(5958));

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("SportYar.Domain.Entites.Request", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AnnouncementId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(4119));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsExpired")
                        .HasColumnType("bit");

                    b.Property<string>("IsPayedByWallet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(4440));

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AnnouncementId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("SportYar.Domain.Entites.Wallet.Wallet", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Balance")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(1604));

                    b.Property<DateTime?>("UpdateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(1995));

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Wallets");
                });

            modelBuilder.Entity("SportYar.Domain.Entites.Wallet.WalletsPaymentsTransaction", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Balance")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(2503));

                    b.Property<string>("PaymentId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(2790));

                    b.Property<string>("WalletId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("WalletId");

                    b.ToTable("WalletsPaymentsTransactions");
                });

            modelBuilder.Entity("SportYar.Domain.Entites.Wallet.WalletsReceivesTransaction", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Balance")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(3301));

                    b.Property<DateTime?>("UpdateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(3572));

                    b.Property<string>("WalletId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("WalletId");

                    b.ToTable("WalletsReceivesTransactions");
                });

            modelBuilder.Entity("SportYar.Domain.Entites.Announcement", b =>
                {
                    b.HasOne("SportYar.Domain.Entites.Region", "Region")
                        .WithMany("Announcements")
                        .HasForeignKey("RegionId");

                    b.Navigation("Region");
                });

            modelBuilder.Entity("SportYar.Domain.Entites.Request", b =>
                {
                    b.HasOne("SportYar.Domain.Entites.Announcement", "Announcement")
                        .WithMany("Requests")
                        .HasForeignKey("AnnouncementId");

                    b.Navigation("Announcement");
                });

            modelBuilder.Entity("SportYar.Domain.Entites.Wallet.WalletsPaymentsTransaction", b =>
                {
                    b.HasOne("SportYar.Domain.Entites.Wallet.Wallet", "Wallet")
                        .WithMany("WalletsPaymentsTransactions")
                        .HasForeignKey("WalletId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Wallet");
                });

            modelBuilder.Entity("SportYar.Domain.Entites.Wallet.WalletsReceivesTransaction", b =>
                {
                    b.HasOne("SportYar.Domain.Entites.Wallet.Wallet", "Wallet")
                        .WithMany("WalletsReceivesTransactions")
                        .HasForeignKey("WalletId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Wallet");
                });

            modelBuilder.Entity("SportYar.Domain.Entites.Announcement", b =>
                {
                    b.Navigation("Requests");
                });

            modelBuilder.Entity("SportYar.Domain.Entites.Region", b =>
                {
                    b.Navigation("Announcements");
                });

            modelBuilder.Entity("SportYar.Domain.Entites.Wallet.Wallet", b =>
                {
                    b.Navigation("WalletsPaymentsTransactions");

                    b.Navigation("WalletsReceivesTransactions");
                });
#pragma warning restore 612, 618
        }
    }
}
