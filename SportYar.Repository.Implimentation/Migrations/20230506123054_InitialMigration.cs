﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportYar.Repository.Implimentation.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProvinceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 26, DateTimeKind.Local).AddTicks(1286)),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 26, DateTimeKind.Local).AddTicks(1499))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 26, DateTimeKind.Local).AddTicks(2000)),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 26, DateTimeKind.Local).AddTicks(2176))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 26, DateTimeKind.Local).AddTicks(569)),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 26, DateTimeKind.Local).AddTicks(787))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wallets",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Balance = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 25, DateTimeKind.Local).AddTicks(6378)),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 25, DateTimeKind.Local).AddTicks(6732))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SportType = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartingTimeInPersian = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndingTimeInPersian = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Participant = table.Column<int>(type: "int", nullable: false),
                    PricePerparticipant = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsExpired = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 25, DateTimeKind.Local).AddTicks(9754)),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 25, DateTimeKind.Local).AddTicks(9986))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Announcements_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WalletsPaymentsTransactions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WalletId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PaymentId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Balance = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 25, DateTimeKind.Local).AddTicks(7401)),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 25, DateTimeKind.Local).AddTicks(7672))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WalletsPaymentsTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WalletsPaymentsTransactions_Wallets_WalletId",
                        column: x => x.WalletId,
                        principalTable: "Wallets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WalletsReceivesTransactions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Balance = table.Column<int>(type: "int", nullable: false),
                    WalletId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 25, DateTimeKind.Local).AddTicks(8199)),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 25, DateTimeKind.Local).AddTicks(8440))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WalletsReceivesTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WalletsReceivesTransactions_Wallets_WalletId",
                        column: x => x.WalletId,
                        principalTable: "Wallets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnnouncementId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsExpired = table.Column<bool>(type: "bit", nullable: false),
                    PaymentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPayedByWallet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 25, DateTimeKind.Local).AddTicks(8999)),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 25, DateTimeKind.Local).AddTicks(9218))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requests_Announcements_AnnouncementId",
                        column: x => x.AnnouncementId,
                        principalTable: "Announcements",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_RegionId",
                table: "Announcements",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_AnnouncementId",
                table: "Requests",
                column: "AnnouncementId");

            migrationBuilder.CreateIndex(
                name: "IX_WalletsPaymentsTransactions_WalletId",
                table: "WalletsPaymentsTransactions",
                column: "WalletId");

            migrationBuilder.CreateIndex(
                name: "IX_WalletsReceivesTransactions_WalletId",
                table: "WalletsReceivesTransactions",
                column: "WalletId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "WalletsPaymentsTransactions");

            migrationBuilder.DropTable(
                name: "WalletsReceivesTransactions");

            migrationBuilder.DropTable(
                name: "Announcements");

            migrationBuilder.DropTable(
                name: "Wallets");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
