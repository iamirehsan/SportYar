using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportYar.Repository.Implimentation.Migrations
{
    /// <inheritdoc />
    public partial class AddUserEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "WalletsReceivesTransactions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(3572),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 25, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WalletsReceivesTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(3301),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 25, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "WalletsPaymentsTransactions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(2790),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 25, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WalletsPaymentsTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(2503),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 25, DateTimeKind.Local).AddTicks(7401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Wallets",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(1995),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 25, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Wallets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(1604),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 25, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Requests",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(4440),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 25, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Requests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(4119),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 25, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Regions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(5958),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 26, DateTimeKind.Local).AddTicks(787));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Regions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(5716),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 26, DateTimeKind.Local).AddTicks(569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Provinces",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(7414),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 26, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provinces",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(7146),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 26, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Cities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(6719),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 26, DateTimeKind.Local).AddTicks(1499));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(6442),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 26, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Announcements",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(5220),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 25, DateTimeKind.Local).AddTicks(9986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(4947),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 25, DateTimeKind.Local).AddTicks(9754));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "WalletsReceivesTransactions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 25, DateTimeKind.Local).AddTicks(8440),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(3572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WalletsReceivesTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 25, DateTimeKind.Local).AddTicks(8199),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "WalletsPaymentsTransactions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 25, DateTimeKind.Local).AddTicks(7672),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WalletsPaymentsTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 25, DateTimeKind.Local).AddTicks(7401),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Wallets",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 25, DateTimeKind.Local).AddTicks(6732),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(1995));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Wallets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 25, DateTimeKind.Local).AddTicks(6378),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Requests",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 25, DateTimeKind.Local).AddTicks(9218),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Requests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 25, DateTimeKind.Local).AddTicks(8999),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Regions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 26, DateTimeKind.Local).AddTicks(787),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(5958));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Regions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 26, DateTimeKind.Local).AddTicks(569),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(5716));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Provinces",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 26, DateTimeKind.Local).AddTicks(2176),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provinces",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 26, DateTimeKind.Local).AddTicks(2000),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Cities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 26, DateTimeKind.Local).AddTicks(1499),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 26, DateTimeKind.Local).AddTicks(1286),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Announcements",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 25, DateTimeKind.Local).AddTicks(9986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 6, 16, 0, 54, 25, DateTimeKind.Local).AddTicks(9754),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(4947));
        }
    }
}
