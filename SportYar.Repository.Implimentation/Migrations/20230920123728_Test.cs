using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportYar.Repository.Implimentation.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "WalletsReceivesTransactions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(4514),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(3572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WalletsReceivesTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(4218),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "WalletsPaymentsTransactions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(3761),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WalletsPaymentsTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(3467),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Wallets",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(2991),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(1995));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Wallets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(2721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Requests",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(5247),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Requests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(4994),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Regions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(6728),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(5958));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Regions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(6430),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(5716));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Provinces",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(8299),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provinces",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(8077),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Cities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(7484),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(7183),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Announcements",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(6003),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(5722),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    BanksCardsNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "WalletsReceivesTransactions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(3572),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WalletsReceivesTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(3301),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "WalletsPaymentsTransactions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(2790),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(3761));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WalletsPaymentsTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(2503),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(3467));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Wallets",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(1995),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Wallets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(1604),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(2721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Requests",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(4440),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(5247));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Requests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(4119),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Regions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(5958),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Regions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(5716),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Provinces",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(7414),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provinces",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(7146),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Cities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(6719),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(6442),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Announcements",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(5220),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(6003));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Announcements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 46, 41, 652, DateTimeKind.Local).AddTicks(4947),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 16, 7, 28, 165, DateTimeKind.Local).AddTicks(5722));
        }
    }
}
