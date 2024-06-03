﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalaxyExpress.API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Login = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    FirstName = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    LastName = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    FatherName = table.Column<string>(type: "NVARCHAR(50)", nullable: true),
                    Birthday = table.Column<DateTime>(type: "DATETIME2", nullable: true),
                    Sex = table.Column<int>(type: "int", nullable: false),
                    ProfileImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    BonusAccount = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false, defaultValue: 0m),
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
                name: "ParcelMachines",
                columns: table => new
                {
                    ParcelMachineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParcelMachineNumber = table.Column<int>(type: "int", nullable: false),
                    LocalAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GlobalAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Coordinates = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParcelMachines", x => x.ParcelMachineId);
                });

            migrationBuilder.CreateTable(
                name: "PostBranches",
                columns: table => new
                {
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchNumber = table.Column<int>(type: "int", nullable: false),
                    LocalAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GlobalAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Coordinates = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostBranches", x => x.BranchId);
                });

            migrationBuilder.CreateTable(
                name: "PromoCodes",
                columns: table => new
                {
                    PromoCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BonusSize = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ActivationCounter = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromoCodes", x => x.PromoCodeId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    EmailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmailAddress = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.EmailId);
                    table.ForeignKey(
                        name: "FK_Emails_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Parcels",
                columns: table => new
                {
                    ParcelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecipientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InvoiceNumber = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MethodDelivery = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParcelWeight = table.Column<float>(type: "real", nullable: false),
                    SenderAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    RecipientAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TypePackaging = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfPackages = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    LossCoverage = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    HomeDelivery = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeliveryPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateOfDispatch = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfReceipt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parcels", x => x.ParcelId);
                    table.ForeignKey(
                        name: "FK_Parcels_AspNetUsers_RecipientId",
                        column: x => x.RecipientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Parcels_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PaymentCards",
                columns: table => new
                {
                    CardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CardNumber = table.Column<string>(type: "NVARCHAR(16)", nullable: false),
                    Validity = table.Column<string>(type: "NVARCHAR(5)", nullable: false),
                    CVV = table.Column<string>(type: "NVARCHAR(3)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentCards", x => x.CardId);
                    table.ForeignKey(
                        name: "FK_PaymentCards_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumbers",
                columns: table => new
                {
                    PhoneNumberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumbers", x => x.PhoneNumberId);
                    table.ForeignKey(
                        name: "FK_PhoneNumbers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserParcelMachines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParcelMachineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserParcelMachines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserParcelMachines_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserParcelMachines_ParcelMachines_ParcelMachineId",
                        column: x => x.ParcelMachineId,
                        principalTable: "ParcelMachines",
                        principalColumn: "ParcelMachineId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPostBranches",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PostBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPostBranches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPostBranches_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPostBranches_PostBranches_PostBranchId",
                        column: x => x.PostBranchId,
                        principalTable: "PostBranches",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPromoCodes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PromoCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPromoCodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPromoCodes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPromoCodes_PromoCodes_PromoCodeId",
                        column: x => x.PromoCodeId,
                        principalTable: "PromoCodes",
                        principalColumn: "PromoCodeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserParcels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParcelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsSender = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserParcels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserParcels_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserParcels_Parcels_ParcelId",
                        column: x => x.ParcelId,
                        principalTable: "Parcels",
                        principalColumn: "ParcelId");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), "e3113eb0-2a45-4e54-9905-51fe0858d8a9", "User", "USER" },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), "6d8fa76d-1a01-4289-9a52-ccabb236773e", "Manager", "MANAGER" },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), "78b6e0f0-69c0-45a8-aea4-a81b1f494dac", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "Email", "EmailConfirmed", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("013a7602-b915-4485-89ea-d3291ed9cab8"), 0, null, 725.0983107131890000m, "3aa561b9-9cad-410d-b2ce-bb189dae0e0d", null, null, null, false, null, "Tina", "Goyette", false, null, "Tina36", null, null, "AQAAAAEAACcQAAAAEFeCGbb7I89G2bAmJcFOzYoYnOxS/amdVuHkhYMGKWShaLpyg6ZUmnQ/i8OTPUY0lw==", null, false, null, null, 2, false, null },
                    { new Guid("01a8f276-3a4c-402e-98b4-c3b9dba05f91"), 0, new DateTime(1960, 5, 31, 4, 4, 29, 515, DateTimeKind.Local).AddTicks(333), 439.1084425770090000m, "71ef3acb-41d3-437d-b6a1-34c2e3669057", null, null, null, false, "Cristina", "Cristina", "Crist", false, null, "Cristina_Crist", null, null, "AQAAAAEAACcQAAAAEAvihCd4a5X611xVmjECDpEvQRxrj1a1BKcdTAZvASD/OvosNvDBcYXAtn+pRFXV8w==", null, false, null, null, 0, false, null },
                    { new Guid("02df2ae2-d7d0-47a4-aeae-e733e06bb1d0"), 0, null, 827.6075110017710000m, "d02bb461-a6fe-4f27-b196-3b7e71fbe99d", null, null, null, false, null, "Ignacio", "Nitzsche", false, null, "Ignacio_Nitzsche", null, null, "AQAAAAEAACcQAAAAEEcrUmmb+qUlVUQnwQBZErtTgZkwVOajV0QYMxZBL2xjVKff3g41K+SFAlGAr/6UQg==", null, false, null, null, 1, false, null },
                    { new Guid("0397b496-e66d-4ab5-942d-0a53948ef201"), 0, new DateTime(1980, 1, 11, 22, 33, 13, 976, DateTimeKind.Local).AddTicks(5305), 28.1335370857340000m, "12cd4f79-fc99-4e3f-b0b1-a72548fa5332", null, null, null, false, "Gina", "Gina", "Cremin", false, null, "Gina.Cremin67", null, null, "AQAAAAEAACcQAAAAEG9BFGXM/NLjWJFB1nlIWAImk/5cCAqtd/x1IrA+D6YRlpXa+9DZsg+nP7KqI42w1g==", null, false, null, null, 1, false, null },
                    { new Guid("03a04e64-e8f5-4db8-ae88-e45982174d32"), 0, new DateTime(1933, 7, 25, 14, 56, 23, 329, DateTimeKind.Local).AddTicks(8830), 400.7232275411720000m, "bd2dd4ba-efdd-49c1-8f46-dfd6a2e43040", null, null, null, false, null, "Nicholas", "D'Amore", false, null, "Nicholas76", null, null, "AQAAAAEAACcQAAAAEB4s5Doa7MfaD+RC/2sp+QLqHL5jU01zo3y2a56CsubPmSREiYlp0HM/g3STrTJD+A==", null, false, null, null, 2, false, null },
                    { new Guid("0639ab22-a867-435b-8c5b-7acf69750583"), 0, null, 174.1838195782870000m, "2d0d3f0e-47de-45fd-9330-c8b80e637a68", null, null, null, false, null, "Barry", "Grimes", false, null, "Barry.Grimes97", null, null, "AQAAAAEAACcQAAAAEJP3Dyrb7XqYIuTp7c2h8lo+F/u9fcoiA6dg61HcHWZWPAMFSREgZmD2aqy40nJUzw==", null, false, null, null, 2, false, null },
                    { new Guid("0768641f-3440-4d72-a350-3b2eca842a26"), 0, new DateTime(1931, 2, 4, 16, 46, 21, 394, DateTimeKind.Local).AddTicks(1543), 957.6670835002650000m, "5f06c668-48cd-4c0c-90be-f9a5739a9bdc", null, null, null, false, "Marcia", "Marcia", "Koelpin", false, null, "Marcia_Koelpin", null, null, "AQAAAAEAACcQAAAAEKiZhsSqPFRD6ZtTVfcwYhq0caNyCKx6HDFI5t6Iy6mYp/v8WkmyyGUsZp+5dDPIjw==", null, false, null, null, 0, false, null },
                    { new Guid("086d4f1c-510f-4c8f-a495-d7e8fc340ecc"), 0, new DateTime(1967, 8, 2, 7, 9, 41, 437, DateTimeKind.Local).AddTicks(6457), 926.6679870256120000m, "876afa4e-c442-4642-8869-34221b4248a5", null, null, null, false, null, "Lloyd", "Casper", false, null, "Lloyd_Casper10", null, null, "AQAAAAEAACcQAAAAEEDRt6cHzh0O1CawWJhXmNX5+VZeAqIluKIZ7zkAOVrEWtxOi702PNIvn7JVNL3c3w==", null, false, null, null, 2, false, null },
                    { new Guid("092e31f3-9b9a-4287-8cae-7fcd18feab47"), 0, null, 392.13273759180000m, "3c59b6d4-b947-4568-a98a-1c6788dded8b", null, null, null, false, "Christine", "Christine", "Schuppe", false, null, "Christine_Schuppe", null, null, "AQAAAAEAACcQAAAAEDbsrCAzOCCRFq8JGVwfaqr02jRothni8aDNHsZVB/CXftZUpBeQd1hy57e0Rj4RbQ==", null, false, null, null, 0, false, null },
                    { new Guid("09465da9-1c65-4a00-be4f-5b7144e699f3"), 0, new DateTime(1959, 6, 23, 19, 43, 32, 481, DateTimeKind.Local).AddTicks(3204), 538.0680747200940000m, "1e618422-c4bf-4e76-9917-10f1445e24e0", null, null, null, false, "Daryl", "Daryl", "Ritchie", false, null, "Daryl_Ritchie99", null, null, "AQAAAAEAACcQAAAAEPP9QMz59OihBGr6L+4Y67TcPaDmzrhg328mRnVera0aEdIeBul7s2YE3TiTRfAdzg==", null, false, null, null, 0, false, null },
                    { new Guid("0a69540b-ce9e-427c-8970-9f311fba0c21"), 0, null, 659.8907416115960000m, "1cd13847-7ace-4d46-9f30-2a8e484ef99a", null, null, null, false, "Zachary", "Zachary", "Dickens", false, null, "Zachary_Dickens27", null, null, "AQAAAAEAACcQAAAAEEwv4zI4vp25UCoA1OIOBOYXxnjlTcEtY7VpAVeLF4gprV8Sgdd0LWYbGY0ZrNZjzg==", null, false, null, null, 1, false, null },
                    { new Guid("0b440e9a-ee26-43ee-9d40-46328f22a228"), 0, new DateTime(1938, 11, 6, 0, 10, 7, 104, DateTimeKind.Local).AddTicks(8578), 73.95761260273460000m, "d1dd1db2-73f7-4c5f-90b7-548761d5a431", null, null, null, false, "Phil", "Phil", "Leuschke", false, null, "Phil.Leuschke7", null, null, "AQAAAAEAACcQAAAAEEy18L4alxOyhCu/Jxp7EonbSKfVpdlY3f1dxVcHdwaztTz5ynNpgFOfEVb8tNHOiA==", null, false, null, null, 1, false, null },
                    { new Guid("0ffea79c-1eaa-4ef4-b27f-e6c525534682"), 0, new DateTime(1980, 9, 1, 5, 32, 16, 743, DateTimeKind.Local).AddTicks(7559), 916.5447174976570000m, "16c216dd-c2e0-4036-be8c-99fbb26fce4d", null, null, null, false, "Pedro", "Pedro", "Strosin", false, null, "Pedro23", null, null, "AQAAAAEAACcQAAAAEPUMEKiq5/aFJMbd6zkJusbmmKHqmUIJ8R93oCdfa2PBCW45mU+TBggci8WJEHSa6g==", null, false, null, null, 1, false, null },
                    { new Guid("10a10ed0-e1f4-4de7-b631-e8c7d0d5eaa9"), 0, null, 89.2973267062360000m, "31c2851e-8dcc-4514-b0b0-bab55c7b56d0", null, null, null, false, "Eva", "Eva", "Anderson", false, null, "Eva_Anderson", null, null, "AQAAAAEAACcQAAAAEClWsYQ5UB3+WLtLpszTniYkakyqUiRshoxj2ZUP28s/eZ1zxkCuDvV/f++p+lAHgw==", null, false, null, null, 1, false, null },
                    { new Guid("11ddb06c-1f4a-4028-b37b-6ad05ae5f7d5"), 0, null, 859.8738918566940000m, "58462b93-4a6b-4432-8c76-baf01508d74e", null, null, null, false, null, "Shelly", "Gerhold", false, null, "Shelly.Gerhold51", null, null, "AQAAAAEAACcQAAAAEDPCFYguYTJ1tqqtn2cj/MVHMr+wdRZH8J+tPDLA45mWUPOSYsP26xbgpzT+W9V0GQ==", null, false, null, null, 1, false, null },
                    { new Guid("137b1e19-3c26-4708-9428-159387ebcd43"), 0, null, 607.2598475503960000m, "d9165c01-17b5-4235-8533-7496b5f92c7a", null, null, null, false, null, "Charles", "Hintz", false, null, "Charles.Hintz", null, null, "AQAAAAEAACcQAAAAECHmw3LFusKzSJhPTM0wCzXVo+OZokeJOZzsMToyA6Mz5oesOrL+1llaLuhMQduuHA==", null, false, null, null, 2, false, null },
                    { new Guid("146a249e-e614-41cc-98ab-d6287da977e5"), 0, null, 616.6892407911270000m, "a55092e2-02b4-4877-89a6-366bd3405cb3", null, null, null, false, null, "Tiffany", "Waelchi", false, null, "Tiffany_Waelchi", null, null, "AQAAAAEAACcQAAAAEDafS8hZRlcevtgxVy/DN53VnnrmqmB+VH4Rc5tQOZkLtFhSxiLraj9PbC5BCegjYw==", null, false, null, null, 2, false, null },
                    { new Guid("1546f9ad-e76e-4438-9513-2c0cdbcdc9dc"), 0, new DateTime(1956, 12, 23, 5, 19, 41, 236, DateTimeKind.Local).AddTicks(8610), 803.586947096470000m, "4d1f2b3c-f879-4e79-980b-780440878b5f", null, null, null, false, null, "Shane", "Kutch", false, null, "Shane.Kutch53", null, null, "AQAAAAEAACcQAAAAENQxZ/ZMJKz4omzPppMb9gzHjVhHPb9OYu9TU5gtpsRBZEJvpIT2Yw9PJ7Ok6LDcZg==", null, false, null, null, 1, false, null },
                    { new Guid("15cc8bf6-f5ac-435e-a654-84e10e29a1bd"), 0, null, 941.9660338335040000m, "a940b632-2b33-458b-9530-525d244f1d71", null, null, null, false, null, "Fernando", "Bartell", false, null, "Fernando91", null, null, "AQAAAAEAACcQAAAAEKviMCgXwi96KKsxyZzf9ZtvGVui+4wZPW6QDwQN1SDUl2T9ItwWH/X3hjp0iOw8Vg==", null, false, null, null, 2, false, null },
                    { new Guid("166bcf97-6b8a-4025-ad11-df15241b0a24"), 0, new DateTime(1944, 12, 24, 5, 28, 51, 376, DateTimeKind.Local).AddTicks(5843), 552.9733067576280000m, "87dede7d-6514-43c3-83b4-1b68293d1090", null, null, null, false, "Harry", "Harry", "Anderson", false, null, "Harry_Anderson", null, null, "AQAAAAEAACcQAAAAEK+jIDKm0NeU1/sFlhJoDWaEHh2m29brASfNcz83gELsm2dxRhYfXVb2y8mOvsDvyA==", null, false, null, null, 0, false, null },
                    { new Guid("16dfe9db-9389-4852-8b69-53610d60b359"), 0, null, 212.6656160337430000m, "8351d85d-6cb7-4323-bea7-132521bc4975", null, null, null, false, null, "Virgil", "Labadie", false, null, "Virgil_Labadie48", null, null, "AQAAAAEAACcQAAAAEGnXAZyfrdHU4fKKgDwcPVTP2juagPKaNK2rxMO9yzoVPCoY1T66cijgsY02bqHMlQ==", null, false, null, null, 2, false, null },
                    { new Guid("17441686-0fa5-4e5d-b680-2d5708a2ecd5"), 0, null, 548.5450410412880000m, "616e9322-dd65-4efc-837d-4d65338f354c", null, null, null, false, "Diane", "Diane", "Jacobi", false, null, "Diane55", null, null, "AQAAAAEAACcQAAAAEGEQn9vOT7pJkarWdbKjdbhDvp1g6QctilsladeCbSOMieICxVBeyyGqWnOZ5eUnKw==", null, false, null, null, 2, false, null },
                    { new Guid("1747bd38-8325-47e2-8876-f2ff552a55c8"), 0, null, 31.59463979825520000m, "f1838ec2-f078-47fd-a733-25e1e3cf6c2e", null, null, null, false, "Louise", "Louise", "Lind", false, null, "Louise_Lind41", null, null, "AQAAAAEAACcQAAAAEKr1xrEuE7UPPrnTpN3k6txcojzEYcGukseBB++aKPsqklObL02ujVJSKe35wR//Sg==", null, false, null, null, 2, false, null },
                    { new Guid("17b956d2-133d-4289-8a76-4633e194bce0"), 0, new DateTime(1994, 1, 9, 23, 21, 32, 539, DateTimeKind.Local).AddTicks(9917), 21.64337364830820000m, "2f46060a-7697-47a6-b23b-d61942b9fc3b", null, null, null, false, "Matt", "Matt", "Abernathy", false, null, "Matt.Abernathy", null, null, "AQAAAAEAACcQAAAAEAzkqDLh+1DtqW6Grbsb+Nwi9sf0i4wUClfBQgTzw5TTpQ2ZNDIrGZd3HyC+MauARQ==", null, false, null, null, 2, false, null },
                    { new Guid("18314b53-d5e3-48fa-8ad6-dc84c3baa1ff"), 0, null, 522.5733966826560000m, "ffe8eaff-21ac-4e08-bc0d-89f4e6e2340e", null, null, null, false, "Arthur", "Arthur", "Gerlach", false, null, "Arthur_Gerlach56", null, null, "AQAAAAEAACcQAAAAEN9MkYrAJ9WKYH1Hr1SBCwDq88D2L0ClOousdtMdgLa6Z6rxRnmv8KwKhlB/sPcoDw==", null, false, null, null, 1, false, null },
                    { new Guid("1c5135c6-32f4-4363-a0a3-5a8fb7357df1"), 0, new DateTime(1995, 6, 20, 5, 46, 13, 517, DateTimeKind.Local).AddTicks(4961), 333.400381901770000m, "34327589-505f-47cf-a64c-cdd887c54c80", null, null, null, false, null, "Salvatore", "Botsford", false, null, "Salvatore.Botsford", null, null, "AQAAAAEAACcQAAAAECFZozNkkzROIjveLyg+YszYgmgMz4KFd1aK4tOP+hqzniBsPzi/0pTWPpuWAt/Ksg==", null, false, null, null, 1, false, null },
                    { new Guid("1d118b7f-07b1-49dd-9f7d-5a1e7d8ea4bc"), 0, null, 695.5898620644660000m, "a436b32b-8fe6-4045-8bcd-44977115e4d4", null, null, null, false, null, "Dave", "Stanton", false, null, "Dave.Stanton91", null, null, "AQAAAAEAACcQAAAAEARCSNnRLAXsUIkd9O+KEUYWcXKH78Q/Qxxp4NwivpORKTlH+mQJYKv6Xh6kOL1inA==", null, false, null, null, 0, false, null },
                    { new Guid("1e47206c-cbc9-48ff-becb-ea5c84ec9719"), 0, null, 436.5899729484160000m, "24e05d77-f5cb-4063-a248-dd474fb91520", null, null, null, false, null, "Roosevelt", "Christiansen", false, null, "Roosevelt46", null, null, "AQAAAAEAACcQAAAAEKck5nD9N9TZ1MjQG9VZXhi87TFjd3+AqORVN8sl0ZN8FjYkrzo8wXaO0XkKl2qN5w==", null, false, null, null, 1, false, null },
                    { new Guid("2063153a-a610-4c40-9ddd-456ef0b560db"), 0, null, 961.5679662663610000m, "6a5820d8-571a-412b-9fb9-c65c8232f8ea", null, null, null, false, "Ramona", "Ramona", "Strosin", false, null, "Ramona.Strosin", null, null, "AQAAAAEAACcQAAAAEHgTGeIHk68kPdDr8uUjGqZlYapoAav/kQgunE9vjPbmPAFX00zGqLSYCNUt4dwyKQ==", null, false, null, null, 1, false, null },
                    { new Guid("222dda98-6fd2-4619-8709-1b78c7872ca8"), 0, null, 888.4670518281520000m, "8187c8cd-1478-4c1d-bd62-62531ec29a86", null, null, null, false, null, "Cindy", "Rowe", false, null, "Cindy.Rowe", null, null, "AQAAAAEAACcQAAAAEOqoolw4GsbEWXt/v4gOIFE7dB/HtzmNFlBFgsRGY7gkqEcUXujQ91OORTtmlbd2jA==", null, false, null, null, 1, false, null },
                    { new Guid("22c74cee-2548-4aef-ab56-019f64d2fb3e"), 0, null, 921.3039128470770000m, "d896f02b-0bff-4b7a-bcbf-ffbf5f97f8cc", null, null, null, false, "Marcus", "Marcus", "Ortiz", false, null, "Marcus_Ortiz92", null, null, "AQAAAAEAACcQAAAAENcVNatJs56ghXoSELpIuE5rqgAVW5HKcoo5WX6EQ367iV+bUfW+BVerWyIzkdpN6g==", null, false, null, null, 1, false, null },
                    { new Guid("24b96e86-5860-47b1-a6ec-9a832bafbb14"), 0, new DateTime(1972, 4, 14, 19, 38, 12, 382, DateTimeKind.Local).AddTicks(2413), 543.1254867847840000m, "26d8d160-ad27-4007-b604-5b0d84a1d9b7", null, null, null, false, null, "Jean", "Block", false, null, "Jean17", null, null, "AQAAAAEAACcQAAAAEJZhfpTVP+pbjmOcJG/raM/QPyP6zZJymg2p9MJAvVVj/k+rMoW6A0DwO4QfLQDndQ==", null, false, null, null, 2, false, null },
                    { new Guid("259e3939-18d5-4998-98ae-345c9d0fa279"), 0, new DateTime(1990, 5, 20, 4, 0, 8, 154, DateTimeKind.Local).AddTicks(4251), 281.480380909240000m, "8d1afc7e-4924-48fb-a123-3b629651e2c9", null, null, null, false, null, "Melody", "Bernhard", false, null, "Melody_Bernhard", null, null, "AQAAAAEAACcQAAAAEEcX3PMYWBjcEkKiQrW9JrEu73oqTCyyC878GsGeiJJklnNcVA85iknFQnwTnd4ieg==", null, false, null, null, 2, false, null },
                    { new Guid("25a47446-d397-4805-8427-d3185a6d35b7"), 0, null, 528.8597721694570000m, "c82c673c-5b99-4fde-83f5-8373d8115461", null, null, null, false, "Everett", "Everett", "Strosin", false, null, "Everett.Strosin45", null, null, "AQAAAAEAACcQAAAAEHCDzLiCX6gOHUVp8Ovfu5bCwvxd2D0t+Oj+snMgawOiiE2/ThllJVl1bV5yFGJWmQ==", null, false, null, null, 2, false, null },
                    { new Guid("25cda556-70c4-4bb2-ad33-871e7ca4939c"), 0, new DateTime(1999, 12, 28, 6, 2, 32, 760, DateTimeKind.Local).AddTicks(2624), 746.7149046848030000m, "87ace25b-f185-402f-a41c-cc17d02adaf3", null, null, null, false, null, "Deborah", "Mayert", false, null, "Deborah_Mayert", null, null, "AQAAAAEAACcQAAAAEPKYiimJK8CAROR9REGZOGgcF/5Lj6J3AiuyDHdKKu4RX0qrPkrh0VU1Bluq9UPbow==", null, false, null, null, 1, false, null },
                    { new Guid("26ad372f-ab3d-49d6-a283-d78f71a0b97b"), 0, null, 869.5040333185860000m, "51a78184-7573-4694-940b-06018a060a72", null, null, null, false, null, "Ramiro", "Dach", false, null, "Ramiro_Dach", null, null, "AQAAAAEAACcQAAAAELnprY1hYXz+VHLD53aHQenNMe4UZXnPLDrnfyYK88TH6+OfWe7caYej/seg+b3bdw==", null, false, null, null, 2, false, null },
                    { new Guid("284afcd2-63de-4550-906f-0a1ce11e8244"), 0, null, 407.9374255688750000m, "6f5ac330-fce3-438c-8f5f-debdd68321e3", null, null, null, false, null, "Molly", "Zemlak", false, null, "Molly93", null, null, "AQAAAAEAACcQAAAAEOyQ8R6L3DX1WyoV47AQW4E4kvUgjO3OL0LjQQP3zqumWQkn/T87xgrLIGK4WNSqiA==", null, false, null, null, 0, false, null },
                    { new Guid("2a328a80-898f-4b62-921d-731137bebe9f"), 0, new DateTime(1951, 1, 16, 10, 31, 22, 634, DateTimeKind.Local).AddTicks(4881), 407.8079407213340000m, "5311446b-974c-4710-a7f5-cdeda4fd02a7", null, null, null, false, null, "Van", "Parisian", false, null, "Van89", null, null, "AQAAAAEAACcQAAAAEPG3dMjaB0Rs7Q3Z8hiJcfgGmpC1ZG98r8X2T7XuUakpdvOEHrglNzZymJOVzy6bFg==", null, false, null, null, 0, false, null },
                    { new Guid("2a9b395f-43a6-4c12-8ee4-3f4db5f26f9d"), 0, null, 830.5782299827920000m, "d916583c-0a1e-4f3d-b4c9-7a16b4348005", null, null, null, false, "Duane", "Duane", "Hilll", false, null, "Duane_Hilll", null, null, "AQAAAAEAACcQAAAAEGyia7n0trTItZTFcxlzE1nj7G08ffyztWyONOYiZwt8kzWofkNI2mmOya1L7Zd2Iw==", null, false, null, null, 1, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "Email", "EmailConfirmed", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("2eb253e8-852b-4b59-bbd3-41b1d962644b"), 0, null, 985.3518715180740000m, "eb640f42-28b2-4ec3-a9eb-87465bf13a5b", null, null, null, false, null, "Hubert", "Nicolas", false, null, "Hubert_Nicolas", null, null, "AQAAAAEAACcQAAAAEBREYD8IAs3Ju8nQ7o4czQv3Ong6/IVbT4isztoKnwdX25zhy3oavxIcldTrYqMbrw==", null, false, null, null, 1, false, null },
                    { new Guid("2f7c84d9-6fe2-4a1c-ba84-c8d43feade58"), 0, new DateTime(1970, 9, 19, 2, 32, 5, 335, DateTimeKind.Local).AddTicks(4452), 324.9743985045580000m, "678d2d9a-1582-439b-a10f-6dda252634ad", null, null, null, false, "Irving", "Irving", "Ankunding", false, null, "Irving_Ankunding", null, null, "AQAAAAEAACcQAAAAEPrXUEupniGc9VBl5ZDn7IFj4lMHCxE0rT6K9MJeUoK1VPw3Nc12kdnnx4zJSrG02Q==", null, false, null, null, 1, false, null },
                    { new Guid("34d672c5-050e-4c3c-8018-0107a72f13f5"), 0, new DateTime(1969, 5, 20, 8, 55, 18, 67, DateTimeKind.Local).AddTicks(3946), 376.8484913788180000m, "ac7018da-9a65-4d3a-b3fa-3356cd5d43b7", null, null, null, false, null, "Alejandro", "Zboncak", false, null, "Alejandro_Zboncak", null, null, "AQAAAAEAACcQAAAAEJv2BZlLVOJ3osr4NKy0YIl3KLbPIohjB05u7LSlt7rDg8KfjktHh/X3BlX1TheLog==", null, false, null, null, 0, false, null },
                    { new Guid("359f112e-4dd6-47fb-995d-9dae092d143b"), 0, new DateTime(1926, 1, 23, 17, 32, 19, 992, DateTimeKind.Local).AddTicks(4946), 580.778878803470000m, "b7faf921-cb33-488d-8517-38673c10195e", null, null, null, false, null, "Isabel", "Farrell", false, null, "Isabel37", null, null, "AQAAAAEAACcQAAAAEKnxAyt6cnPPq1TUC26CUhM7lsTZi6PGvfw+wYbGvjtUNztSZlB2tPfGMh/J7bm7Dw==", null, false, null, null, 0, false, null },
                    { new Guid("3705daaf-a245-497f-b245-acd05a008711"), 0, null, 214.7931230210140000m, "699bd04b-ea48-479a-996b-ddf1410d0ebb", null, null, null, false, "Irvin", "Irvin", "Corkery", false, null, "Irvin60", null, null, "AQAAAAEAACcQAAAAEGyqLvWqB0N14cJ08TMo0GUItXYqyyAa5FzYDABIZhwfbIKHUFI2b52XXLl5Oomj2A==", null, false, null, null, 2, false, null },
                    { new Guid("37432efe-ddf1-4f3f-9753-a8b4a9e54500"), 0, null, 921.1182252038110000m, "0753c9bc-b84c-4ce7-b2f1-8a5897381c56", null, null, null, false, "Vernon", "Vernon", "Spinka", false, null, "Vernon.Spinka", null, null, "AQAAAAEAACcQAAAAEGEJAX2ywkj1bMkf2CQ3HupffKvCyXI4i9YuTzdgjGHcl+QkZEYMlTVe1/kcp30uUg==", null, false, null, null, 2, false, null },
                    { new Guid("3a8ff431-6524-4268-ae59-91f87b944fae"), 0, null, 293.4892567472780000m, "eb0b2ea2-dd07-43fe-9a04-811ce56a3f18", null, null, null, false, "Isabel", "Isabel", "Rowe", false, null, "Isabel_Rowe77", null, null, "AQAAAAEAACcQAAAAEJKLe4bJlp9rIQM+rp2yMQOmQOGZDU35xHjRlpyNmTjjZD4HfCFCq98B80G2g2KcNQ==", null, false, null, null, 2, false, null },
                    { new Guid("3aa0613b-0255-46fa-9fc9-f73e67ec6962"), 0, null, 487.5059101937030000m, "79a52ef6-a825-4fe8-824c-97c4f1f0a84b", null, null, null, false, null, "Fredrick", "Labadie", false, null, "Fredrick_Labadie48", null, null, "AQAAAAEAACcQAAAAEGE9GBJUuiAJrs7ucKPjS5EPuxGufFAd77Q1L/yCqhyAQySl/Ty05ExS+CSPZRQkfQ==", null, false, null, null, 0, false, null },
                    { new Guid("3ca63884-385c-4ae8-ac07-f3dc2df24aae"), 0, null, 393.7661708628020000m, "e4e00ca6-ce32-4fcb-8290-c1179894b5e1", null, null, null, false, "Daryl", "Daryl", "Gutkowski", false, null, "Daryl_Gutkowski89", null, null, "AQAAAAEAACcQAAAAEG7pMIllcsNh138UWslvMGI8ijFfwwf+0tzrEr+Da2UwufSyy0T7xIro4isuvNJclQ==", null, false, null, null, 2, false, null },
                    { new Guid("3dc1a6db-3bf2-4650-b501-abf7ef284b3c"), 0, new DateTime(2005, 5, 1, 17, 51, 44, 250, DateTimeKind.Local).AddTicks(7184), 465.6078699396480000m, "5307c738-e52b-419e-bbe9-9f572afa1ce0", null, null, null, false, null, "Anna", "Ritchie", false, null, "Anna.Ritchie", null, null, "AQAAAAEAACcQAAAAEOk6CDRC5TI5akiQTveXr40NGlAY0J9tuUPAbiFCNhCOPmoVpC3/DXJCsIT9c/IsMQ==", null, false, null, null, 0, false, null },
                    { new Guid("3dd4bd2a-4dd8-4988-867a-99041eb6851d"), 0, new DateTime(1999, 12, 5, 8, 14, 41, 476, DateTimeKind.Local).AddTicks(3906), 945.6626279370860000m, "9822fd9b-1c38-40a2-8420-40490c005451", null, null, null, false, null, "Darrell", "Moen", false, null, "Darrell_Moen", null, null, "AQAAAAEAACcQAAAAEOiGVWl8PZUZAQWI/jEPrNYt5daG/sIxUCfJG6NMnQKiSdty6jhvXPiWVXyn03tbsw==", null, false, null, null, 0, false, null },
                    { new Guid("427485d5-0faa-4f9a-9c6f-70317d50831a"), 0, new DateTime(2007, 1, 22, 16, 33, 20, 40, DateTimeKind.Local).AddTicks(5859), 820.7602604148120000m, "7551a0c3-3470-4cd0-9261-7ead0d1cf503", null, null, null, false, null, "Darla", "Will", false, null, "Darla.Will", null, null, "AQAAAAEAACcQAAAAEJAR7+RXavJDZKrnS9CEEy+I4qS4wkCo301STvDFihMXFfEygoOP57fa03zIZBhK3Q==", null, false, null, null, 0, false, null },
                    { new Guid("437bc41c-af0d-4443-809f-276b155b8846"), 0, new DateTime(1950, 2, 11, 21, 5, 45, 162, DateTimeKind.Local).AddTicks(6611), 620.9668729423190000m, "9b78f839-5020-4483-93f0-16b19fb07723", null, null, null, false, null, "Kristine", "MacGyver", false, null, "Kristine_MacGyver", null, null, "AQAAAAEAACcQAAAAEDtee56T5LsHyHbe4UMpFqwgSm63ndFyOJcQl27LG4UalN6TSGyrwQl+aYJNHN1Mkg==", null, false, null, null, 2, false, null },
                    { new Guid("43b84c41-ad8c-49ff-ae3a-561f6d21e04b"), 0, null, 694.7950044539440000m, "09c04237-bb92-49a8-a784-cf8217ca72e0", null, null, null, false, "Stephen", "Stephen", "Rath", false, null, "Stephen_Rath", null, null, "AQAAAAEAACcQAAAAEFG5eMmJYs+Ghd06bR/LLg5I242MU1Dqnd4Jz//Q4jv5G2E3qWFsjlwrU03WaDnz+A==", null, false, null, null, 0, false, null },
                    { new Guid("451f756f-99dc-4563-9d9a-db92f4a114f0"), 0, new DateTime(1956, 3, 25, 5, 47, 5, 172, DateTimeKind.Local).AddTicks(5944), 495.4185160609440000m, "c929eb84-061a-49f7-afbf-9ecaa3cc8e60", null, null, null, false, null, "Jonathan", "Bins", false, null, "Jonathan44", null, null, "AQAAAAEAACcQAAAAEOx4gr97SodGmTr06VDhshQcJUdQqp3ZF9xF7mA/Tj5COb4zxhy7LiybRKIOCi8q4A==", null, false, null, null, 1, false, null },
                    { new Guid("4883913c-7591-4093-a019-7e3dd870d152"), 0, null, 795.949457883860000m, "1688b5b1-1662-4186-bcc9-b412dc6cbba3", null, null, null, false, "Cecilia", "Cecilia", "West", false, null, "Cecilia93", null, null, "AQAAAAEAACcQAAAAEGRn+C2YSADjG3Wb5tjuE4BkCkljfRkrBUUGiy3ovPc+Al5dHJFxbvOg7vbcg2eQbQ==", null, false, null, null, 2, false, null },
                    { new Guid("4952ad1a-3fe2-4d0a-a38e-1e28e3808afd"), 0, null, 85.76887965488680000m, "753eabca-6be6-49c9-8e99-f590e77c0541", null, null, null, false, null, "Tina", "Buckridge", false, null, "Tina32", null, null, "AQAAAAEAACcQAAAAEAkoTXlhhOfHpA5pVVMcOGqeFlKI72XdD+pBQDpmnp1MamUzSjpVdggCVO6mX/2lxw==", null, false, null, null, 2, false, null },
                    { new Guid("49922094-de40-49f9-8fe5-21e734ddaadc"), 0, null, 742.4555712124190000m, "639ec85f-4509-41e4-8b45-84687f44467d", null, null, null, false, "Marshall", "Marshall", "Gleason", false, null, "Marshall_Gleason", null, null, "AQAAAAEAACcQAAAAEDEhiUFFnrcF9hz90HmHhO3nZPT0xivjuo/uiV7sayYw8vYLJHx2QTDqh3gbLjmDhw==", null, false, null, null, 0, false, null },
                    { new Guid("4a254852-2316-4300-99be-6d54e3eeac93"), 0, null, 514.5868968450220000m, "f22138db-98f2-4019-ba21-05de173db3f1", null, null, null, false, "Wesley", "Wesley", "Wolf", false, null, "Wesley.Wolf7", null, null, "AQAAAAEAACcQAAAAEN9g3Z4CMdDojca06c8ya+W5zIGyNz4/9N9JZ4hWXAGu5Y8Ou9Va7EeAzXnk8d2kXA==", null, false, null, null, 0, false, null },
                    { new Guid("4ae96a4e-92a4-486e-b7ce-61d3f2fe842b"), 0, new DateTime(1954, 5, 31, 17, 24, 46, 960, DateTimeKind.Local).AddTicks(7203), 356.2635488577490000m, "d9339cf6-9d01-47e5-9071-e73c92bad74f", null, null, null, false, "Phillip", "Phillip", "Raynor", false, null, "Phillip11", null, null, "AQAAAAEAACcQAAAAEEbFlCHAcFlKrF9fRqqqDUl4nVcfsF95TotDyJ/RgZHb6yOGagj2R1W6Zb1MzGs3Yw==", null, false, null, null, 2, false, null },
                    { new Guid("4af7ff34-3014-4da9-ba8e-e93cfaac4eaf"), 0, null, 33.84577739937860000m, "ae41ccce-acd0-4c76-b3f0-3af0f918034d", null, null, null, false, "Ronnie", "Ronnie", "Mosciski", false, null, "Ronnie0", null, null, "AQAAAAEAACcQAAAAEBNd26H5uND6jueF4Af5D/edElKm+aOGpZFuGVZTNG3Jdm/n23mkDyozzAwm5eGGrg==", null, false, null, null, 0, false, null },
                    { new Guid("4bb403d4-8670-466f-a9dc-17dd09c9d546"), 0, new DateTime(1940, 9, 13, 5, 7, 12, 241, DateTimeKind.Local).AddTicks(4408), 266.5855030831680000m, "c50d951c-adf2-4759-a94a-a41ed2071634", null, null, null, false, "Janis", "Janis", "Okuneva", false, null, "Janis.Okuneva", null, null, "AQAAAAEAACcQAAAAEE+LAGOvDVHesdRpAAmpADp80KrTQrAYDxnkaaIsgKoKr6r3gGhFRxkGJGmMbQjWWg==", null, false, null, null, 1, false, null },
                    { new Guid("4bfa50d6-7b76-402d-afe8-4b558ee6165b"), 0, new DateTime(1980, 12, 24, 5, 54, 36, 35, DateTimeKind.Local).AddTicks(2518), 409.911475491030000m, "99677063-64ed-415c-a271-a28f2061704c", null, null, null, false, "Connie", "Connie", "Weissnat", false, null, "Connie.Weissnat96", null, null, "AQAAAAEAACcQAAAAEEhWvhfJc/LNtfuP/v4JEYfw1ik5xZrAdy0CFtLyyIzpUAKOM4Pae4SdWbFXTI4QTQ==", null, false, null, null, 2, false, null },
                    { new Guid("4bffa9b9-a7ae-4dd6-b87b-dbcad3737bfd"), 0, null, 740.9461761387020000m, "0e6fc316-87f3-4584-87da-9855dac351a6", null, null, null, false, null, "Christine", "Tillman", false, null, "Christine_Tillman", null, null, "AQAAAAEAACcQAAAAEOF1d6HRLFP/wgJJaVjwvSnoNIqWYv+YQFjObAjs4rmwSmYC0Ko5hP3kGBEojlaY0Q==", null, false, null, null, 1, false, null },
                    { new Guid("4ccb797f-65b1-4b8c-809c-fe110c01052b"), 0, new DateTime(1963, 5, 28, 6, 21, 52, 144, DateTimeKind.Local).AddTicks(1632), 9.997200412500410000m, "797bbe54-ffcc-4459-a1b8-6624bed498c3", null, null, null, false, null, "Tim", "Windler", false, null, "Tim.Windler", null, null, "AQAAAAEAACcQAAAAEF9ZXMvIh1Fc4SZSTNh5sfRDbfg0TkAcs/T7letzBx2xkhp9y4SHJV1ofvhFBImsgw==", null, false, null, null, 2, false, null },
                    { new Guid("4d65579c-7caa-4a73-aec4-ebf5de2054ab"), 0, null, 376.3919994218220000m, "5cd5d0ab-67ec-443d-811c-384e238fc23a", null, null, null, false, null, "Damon", "Hilpert", false, null, "Damon.Hilpert", null, null, "AQAAAAEAACcQAAAAEFEpMTltkf0dbmjH451WB0X/oSVRFaC4Y1LnV+foB82B51oRjdMT2op0thYyYN0ehg==", null, false, null, null, 0, false, null },
                    { new Guid("4d792f39-989a-48bc-8528-2bda17a5967a"), 0, null, 420.8564867739030000m, "5f1b98b1-493b-41ed-9779-e76885c16ab7", null, null, null, false, null, "Johnnie", "Von", false, null, "Johnnie_Von39", null, null, "AQAAAAEAACcQAAAAEPPE8/e8RtdZpLDehf65e2/CDeuBWaZ6qCw+fUUNZ9KnJ/KrIhXE8ieHxjzwnB1EyQ==", null, false, null, null, 2, false, null },
                    { new Guid("4e8bea3b-5b3c-4c9c-b874-2c8b16d90db2"), 0, new DateTime(2006, 2, 12, 12, 5, 16, 558, DateTimeKind.Local).AddTicks(8555), 946.3815530307190000m, "08218570-2e91-48eb-ae88-15952ff7c60b", null, null, null, false, null, "Hugo", "Miller", false, null, "Hugo.Miller89", null, null, "AQAAAAEAACcQAAAAEPPSwi+qkE1to8pwfTkfij5OiEUGYeDJV/9GfQiaZ2i18uQ1A6/8/cUEmMUfQ6tZYg==", null, false, null, null, 0, false, null },
                    { new Guid("4ec972f7-f6d0-4660-943e-5ad3d2557cfe"), 0, new DateTime(1990, 11, 6, 20, 51, 5, 458, DateTimeKind.Local).AddTicks(991), 55.29216785672090000m, "a95db293-ad8e-431e-bbe2-dfd2a64f8604", null, null, null, false, "Lindsay", "Lindsay", "Kutch", false, null, "Lindsay93", null, null, "AQAAAAEAACcQAAAAEONMttjC10v41dFC6e8zs0MsUPpTAK5UhmstL7K8cIM9briVwnx3qOxCd3m5fnScAQ==", null, false, null, null, 1, false, null },
                    { new Guid("4fb2390c-a600-4f3b-adfe-f73867978239"), 0, null, 800.8410138768610000m, "80d836af-d092-4c0f-a6f4-1965fb53ef3c", null, null, null, false, "Cora", "Cora", "Botsford", false, null, "Cora_Botsford18", null, null, "AQAAAAEAACcQAAAAECdrYRrFCeV9VxV7u4spU0ijeY2Bhdc7hoVEbZnWN5upktAJtjhPSm2Mmkhg5kbplg==", null, false, null, null, 1, false, null },
                    { new Guid("4fd873ab-a800-46d0-959f-d9f6189c846e"), 0, null, 182.3981210718430000m, "d181a427-5a91-4100-b51a-88024bd649b3", null, null, null, false, "Jamie", "Jamie", "Trantow", false, null, "Jamie.Trantow", null, null, "AQAAAAEAACcQAAAAEJFCAWjtXzFAZ5A/7zhPjTRoACP004NdZxaKBThX0RsqY76+3N3d1GYAouzt5WZG+Q==", null, false, null, null, 1, false, null },
                    { new Guid("51655f73-efc8-4142-b1ea-1657e4fc0f2e"), 0, null, 464.5237203452110000m, "d145f5cb-73a5-4598-8a29-3579bc5fff59", null, null, null, false, "Kendra", "Kendra", "Bashirian", false, null, "Kendra.Bashirian45", null, null, "AQAAAAEAACcQAAAAEJmnQEC9IMimhtMUNlmyapfXXGQURvzgZBdTppSi8K51pTBES88SAU5e/hUzgobYKA==", null, false, null, null, 0, false, null },
                    { new Guid("52010289-102f-414b-8fb6-a09a575f22a0"), 0, null, 841.4274356858090000m, "be6b60ed-4dfa-4753-835c-a2afaa6aa482", null, null, null, false, "Jonathan", "Jonathan", "Leannon", false, null, "Jonathan.Leannon10", null, null, "AQAAAAEAACcQAAAAEE3+Kh/vW95pfQZCmkc1USq8s74XUkeAOZ2ZZKp2rfP/IEymxoxItKGJCLVC7MzqvQ==", null, false, null, null, 1, false, null },
                    { new Guid("52c54e9c-3d8e-429f-ae95-d180e2ec5a1d"), 0, null, 863.4533624762260000m, "9faf60fc-96be-438a-b4f2-ab7d8e2ba0f7", null, null, null, false, "Kelly", "Kelly", "Casper", false, null, "Kelly.Casper3", null, null, "AQAAAAEAACcQAAAAEEyF2RhgYJU0lNXZ325c5abQx2hQSYmXmc5ghSOeXAb50ToZOSZWnqBN/ZOiIo0d0g==", null, false, null, null, 0, false, null },
                    { new Guid("5441f683-8cec-4fb5-96c6-2fa82e7997d3"), 0, new DateTime(1999, 5, 13, 9, 8, 12, 92, DateTimeKind.Local).AddTicks(357), 205.0071135141040000m, "89a70ce9-9a44-4e46-9494-4e49d2af54da", null, null, null, false, null, "Daryl", "Braun", false, null, "Daryl.Braun", null, null, "AQAAAAEAACcQAAAAEJNqr9mvelZrSDnu8/TtgR+Jo03uzQqpJ91FkO4+8XJsz6O1yFXfhTDvXaDX4dOJ7Q==", null, false, null, null, 2, false, null },
                    { new Guid("551cb7a5-2acf-469f-be65-7a549dccf51f"), 0, new DateTime(1948, 4, 21, 1, 44, 42, 646, DateTimeKind.Local).AddTicks(2286), 846.8126738056780000m, "1f0e6b49-2bf2-45d2-a529-801262f9e818", null, null, null, false, "Darryl", "Darryl", "Lueilwitz", false, null, "Darryl_Lueilwitz18", null, null, "AQAAAAEAACcQAAAAEHy4klRd1/06HCmwVhsMXUQRGwZRMtcqIuMQvUKw1HWUz00iij+8NiTdz0YHWdulSQ==", null, false, null, null, 1, false, null },
                    { new Guid("552898bc-d86c-4567-80c9-bdb93739cab5"), 0, null, 638.8216352046180000m, "3dced8d9-2e86-4275-891c-878951a537e8", null, null, null, false, null, "Jeffrey", "Hoppe", false, null, "Jeffrey_Hoppe", null, null, "AQAAAAEAACcQAAAAEEI+1Pitq5uxqQ7XtAXDaKHoEJXRS0xUGf5NjF/SGQFWQH56UEbh7yyKIq5PQCLOfw==", null, false, null, null, 1, false, null },
                    { new Guid("5560fdd3-3041-418a-bdbd-b1b7cb595a87"), 0, new DateTime(1968, 8, 26, 9, 31, 1, 230, DateTimeKind.Local).AddTicks(2771), 923.3283944382230000m, "94653c0c-a354-474b-a67b-6adba6a707c3", null, null, null, false, null, "Deanna", "Tillman", false, null, "Deanna_Tillman", null, null, "AQAAAAEAACcQAAAAECOl2dI6nPiE1vNQwX+sNPIPbqjYOvwkUSiQCwp3e8B3CaX59iWYsL9mlyn8WFY9aw==", null, false, null, null, 2, false, null },
                    { new Guid("568a5cfd-171b-413d-addf-fe6ab58aa6d0"), 0, new DateTime(1996, 7, 2, 8, 16, 39, 269, DateTimeKind.Local).AddTicks(8002), 386.611793065890000m, "0861592e-ea0e-4b67-9a6c-60728001fe08", null, null, null, false, "Shawna", "Shawna", "Mraz", false, null, "Shawna_Mraz", null, null, "AQAAAAEAACcQAAAAELDhmZiMkfl1QNnnEoIvvoXU/x8TIE55n2tzQ5bYU4w1KjIA8J5SiFOhPShLpdMXEA==", null, false, null, null, 1, false, null },
                    { new Guid("57041776-9144-494f-9e92-9c9da3135eab"), 0, null, 691.4742962256360000m, "66910b17-c7f6-4bac-ac5c-146e78532d12", null, null, null, false, "Melvin", "Melvin", "Wunsch", false, null, "Melvin_Wunsch", null, null, "AQAAAAEAACcQAAAAEFWHboR7HwawBQwUP2nqSyJNFyBNUCmqBZKXqYiRBImrzXxaxjtcIDVoR0MMXBidUA==", null, false, null, null, 2, false, null },
                    { new Guid("57d5c043-44a4-43bb-80ee-1cbb791b2285"), 0, null, 827.615849933670000m, "8f0c7cb1-de9e-41fa-aebd-1595afce0a52", null, null, null, false, null, "Freddie", "Heaney", false, null, "Freddie_Heaney70", null, null, "AQAAAAEAACcQAAAAEKDZKzaOFsrNo7VcwLt3810eJ6PDeKLGANc+aXzNOaMdCVJd9WWw9z94aU8wotqdqA==", null, false, null, null, 2, false, null },
                    { new Guid("58fc780f-3b29-4947-a319-3ed8b421144e"), 0, null, 903.2622071523410000m, "6aa0ebc3-7abc-4acb-acfb-6ad1e3166b3c", null, null, null, false, null, "Stacey", "Adams", false, null, "Stacey.Adams63", null, null, "AQAAAAEAACcQAAAAEAOw7t4rzdt9XU0EjI5qEkdVAFGZhuj7n7sO+tbwqSTFxedZYsWGxdbZMe3Jaxg+FA==", null, false, null, null, 2, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "Email", "EmailConfirmed", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("5a13878d-22a4-47a3-8eb8-3f4be375baee"), 0, null, 669.8065341650060000m, "c560b449-538a-4752-93d7-474d657c18e8", null, null, null, false, null, "Bill", "DuBuque", false, null, "Bill.DuBuque", null, null, "AQAAAAEAACcQAAAAEOb8UD7LfPVSSHZ7BopOjbciAUmGLq1ugCRNU4+vwWPQl2kRjoqJafA+Cxc5CDbkMQ==", null, false, null, null, 0, false, null },
                    { new Guid("5a6031a7-d008-4d4c-9a87-857d42759454"), 0, new DateTime(1956, 1, 22, 18, 19, 21, 789, DateTimeKind.Local).AddTicks(9165), 616.9112554341820000m, "5f8d8356-d045-4476-ae18-4dbc6ce35570", null, null, null, false, "Grace", "Grace", "Okuneva", false, null, "Grace.Okuneva", null, null, "AQAAAAEAACcQAAAAEF3fbpEM+73+dUUsBOA5Z9Cn2pPQD8U6aqRhLuMF0Hz4I9gxaN+X8HpnxBUDWwLa/A==", null, false, null, null, 1, false, null },
                    { new Guid("5c31a07d-9e1a-46bb-9c88-2f881f607c52"), 0, null, 106.7400837015270000m, "f2d990eb-89c2-4059-a1f5-36afd5212f7a", null, null, null, false, "Kendra", "Kendra", "Conroy", false, null, "Kendra.Conroy10", null, null, "AQAAAAEAACcQAAAAEPhPzApFqagxY/dziFjBs+79jlXOVPvZRJTvGfuZyRoLOblEpQ14TXMnjTAZIxRJPw==", null, false, null, null, 1, false, null },
                    { new Guid("5d6854b6-463d-4c99-844f-2b03c65e196b"), 0, new DateTime(2006, 4, 26, 19, 45, 26, 979, DateTimeKind.Local).AddTicks(2950), 364.4591984478990000m, "60d5acab-5c40-41f9-aa22-45364280d55e", null, null, null, false, "Israel", "Israel", "Konopelski", false, null, "Israel.Konopelski75", null, null, "AQAAAAEAACcQAAAAEOQ27pOy6NIouSbnj2cxw2hCyeB6YqqpR2QgiAoU8KbOXS01DpflRmYS7DXHc9FV3g==", null, false, null, null, 2, false, null },
                    { new Guid("5e0e0eed-1c83-4b51-8938-5bab69316dab"), 0, null, 617.7045732986890000m, "f70248ed-cc7e-4720-a44e-ca14a7a211bf", null, null, null, false, "Ed", "Ed", "Lockman", false, null, "Ed87", null, null, "AQAAAAEAACcQAAAAEOK6UxC3uJ4zyT99Ny45wuZRCck55WQEq+P6zCZxNUYhYg83BAUi3gn1sebs0d62rg==", null, false, null, null, 0, false, null },
                    { new Guid("5e2d266d-c2a4-4711-b57e-3656b61d6ad2"), 0, null, 54.28812686334290000m, "c56488f0-6f46-4822-aa90-6f86765b70d2", null, null, null, false, null, "Isabel", "Cassin", false, null, "Isabel_Cassin", null, null, "AQAAAAEAACcQAAAAEGwTyNB6PfOS+H4bp8hQYspPeDcbcgIGcPWMxLK5GItXcmq8vtX2KLbDFPpVEzqIzg==", null, false, null, null, 1, false, null },
                    { new Guid("5effd297-ddf3-4f40-afed-c85e49e3d248"), 0, new DateTime(1943, 11, 25, 21, 7, 28, 385, DateTimeKind.Local).AddTicks(3617), 956.1476107354820000m, "31438122-ac83-48d8-801c-a8957fcf8ad7", null, null, null, false, "Allen", "Allen", "Wyman", false, null, "Allen.Wyman59", null, null, "AQAAAAEAACcQAAAAEB6BZDizZpmvj3rmxcr/NCdCbQvF77jZ5XWPV4mAQbhlhwmG2XIbsscxMgeYcouf4g==", null, false, null, null, 0, false, null },
                    { new Guid("5ffbbdb6-b588-4eef-811a-4b39d217f0a8"), 0, new DateTime(1997, 3, 18, 23, 33, 34, 314, DateTimeKind.Local).AddTicks(8160), 937.2199280680760000m, "d978bb08-3cfc-4662-8d44-0d9c290203c4", null, null, null, false, "Darnell", "Darnell", "Gutmann", false, null, "Darnell4", null, null, "AQAAAAEAACcQAAAAECrOnbP6OWYqLFwJUf68GIpmIMojOBwh8msLTaFNAQqfUZmIHovi065pK5a9cuVpzQ==", null, false, null, null, 1, false, null },
                    { new Guid("605efc2a-1846-428c-a520-3c8efbd1c5d8"), 0, null, 925.0250190197110000m, "2f2769b3-cc7e-46e1-9659-e491d9cb8c25", null, null, null, false, null, "Ryan", "Rodriguez", false, null, "Ryan.Rodriguez", null, null, "AQAAAAEAACcQAAAAEH8xychrJaOpkkMoKdbEppqHWCbnRsEng1kjsUNmqTlcc+TuQe36N5yOR28VIDKm8A==", null, false, null, null, 0, false, null },
                    { new Guid("6172d849-4ee5-486f-8f97-d2bbcfc40084"), 0, null, 467.9245326275540000m, "50286de9-e4f6-4ffa-a71e-51d076b77159", null, null, null, false, null, "Marshall", "Wuckert", false, null, "Marshall55", null, null, "AQAAAAEAACcQAAAAEN60HCZLjro3/oFZnescWS+3ieZqVAlJJTtIyIhOza7mmqRVJL0uwpfE6dmPdyyfeA==", null, false, null, null, 2, false, null },
                    { new Guid("620337a7-cc3b-43d5-aef4-5b29e97ab466"), 0, new DateTime(1954, 11, 24, 14, 10, 41, 753, DateTimeKind.Local).AddTicks(305), 768.7598137437070000m, "6567cd9f-65e4-42e7-a21a-98e92503ae74", null, null, null, false, null, "Penny", "Gerlach", false, null, "Penny55", null, null, "AQAAAAEAACcQAAAAEGgmF3vb+MY7FBqOxAxeQYDJtPxJgcI3SxwcpNH2FJv1OxW6Ei/BcedZKGdQJrsU2Q==", null, false, null, null, 1, false, null },
                    { new Guid("62f9c608-cb23-46fa-a1c4-304e5c65aec1"), 0, null, 559.1323740006340000m, "b9c69e8e-0344-43a9-9cec-e5e629a55f6c", null, null, null, false, "Cary", "Cary", "Okuneva", false, null, "Cary_Okuneva", null, null, "AQAAAAEAACcQAAAAEJgyuaSK3IIi+kFmtjneZSDP48vbucymBLh2IlsVV0taJDdht7IqThljBPK/MGjaPA==", null, false, null, null, 1, false, null },
                    { new Guid("6375150d-9633-494e-ba79-b55f87d56afa"), 0, new DateTime(1940, 2, 14, 7, 1, 56, 672, DateTimeKind.Local).AddTicks(5053), 367.3965151301570000m, "e3b7c9e5-e72f-4652-8a6b-6fde4ec6fca1", null, null, null, false, "Gilbert", "Gilbert", "Armstrong", false, null, "Gilbert_Armstrong", null, null, "AQAAAAEAACcQAAAAEEK3iTAWXbuxjv0hBH6rT73sJ0D3aYfbZVNxBEU5XWnraTr5l/biVoCUqp7zqZXwrg==", null, false, null, null, 1, false, null },
                    { new Guid("63bd6aad-fd4d-4a2d-b0ee-341253297e79"), 0, new DateTime(1925, 12, 12, 12, 36, 8, 251, DateTimeKind.Local).AddTicks(5906), 555.6413510844960000m, "8e0d664b-a0b4-4dab-8fb5-b73303b50652", null, null, null, false, null, "Felix", "Lockman", false, null, "Felix84", null, null, "AQAAAAEAACcQAAAAEE+Jpr7B5XkSEGZDe0oqLlDm+UUImcqCOdVxuNfPwEkxgsN5k2ZdNP/r707ETZfrWQ==", null, false, null, null, 2, false, null },
                    { new Guid("63ce22ac-8a36-4fb9-bf6d-61e02101f5d7"), 0, null, 209.1178792717840000m, "50b01a1c-4546-4fea-bcda-3b05fa5c197d", null, null, null, false, null, "Tammy", "Greenfelder", false, null, "Tammy_Greenfelder", null, null, "AQAAAAEAACcQAAAAEOGclJbVJRf7QiJle/6i+F5hU67G/MwekvfcZTRDUaq1KoVxj8lP12DsK1lhWwj1zQ==", null, false, null, null, 2, false, null },
                    { new Guid("641c3d4a-a6ff-4cb3-b40a-665b9156a255"), 0, null, 253.3987041886260000m, "1713328b-7ebc-4b33-a51c-2115832aad47", null, null, null, false, null, "Jimmie", "Kulas", false, null, "Jimmie15", null, null, "AQAAAAEAACcQAAAAEGmczRLLM2hYNMYqSMCKg7iZ7fHH9x/pXpuctYRw9WPdN0x3ICpED2FH+1T4mJ9nPA==", null, false, null, null, 2, false, null },
                    { new Guid("6507f7f4-4076-4fff-b89e-4205b52b6408"), 0, null, 416.7166250258380000m, "d7d67352-5703-49d8-aa2f-ba24c8a076c0", null, null, null, false, null, "Johnny", "Considine", false, null, "Johnny59", null, null, "AQAAAAEAACcQAAAAEDccCBYt8lJUgaCcg3BCA9whCghEAzftzaNGXHqZCzhM74LBl4QIKQYflPxfM8n1+w==", null, false, null, null, 1, false, null },
                    { new Guid("655cd6fe-206e-4683-a0e5-f0108ee7f59f"), 0, new DateTime(1984, 12, 18, 9, 6, 29, 407, DateTimeKind.Local).AddTicks(466), 120.4645816995350000m, "3abf22c2-5209-49b3-9bf1-a3a4180bfb43", null, null, null, false, null, "Kristie", "Johns", false, null, "Kristie91", null, null, "AQAAAAEAACcQAAAAEPs4d+ds29ySA0txhF3WLSJgy4XDTTotUv5apuj2EoUjcyZCcoygA2QOE90oxBc1AQ==", null, false, null, null, 1, false, null },
                    { new Guid("6709762d-580f-4c32-8f92-b1daa6e22c27"), 0, new DateTime(1958, 7, 17, 21, 49, 15, 863, DateTimeKind.Local).AddTicks(6045), 237.3669434470630000m, "905af54a-cbb2-4d23-9bef-9aa3a8693b49", null, null, null, false, null, "Felipe", "Kreiger", false, null, "Felipe11", null, null, "AQAAAAEAACcQAAAAEMzUWOhQ3ZaJn4mdGEB6X1Z6mAQrVqnMynWm2+68Ea+l9DqApPZq/lJrSD8OakW7yg==", null, false, null, null, 2, false, null },
                    { new Guid("68fd726f-e5e4-4755-a477-4727a0a9f4b8"), 0, null, 4.07043433933030000m, "1d099936-2f08-4090-b194-883e23d43953", null, null, null, false, "Kent", "Kent", "Heaney", false, null, "Kent_Heaney70", null, null, "AQAAAAEAACcQAAAAEP950MRkYqziErf3nWwPPPBOlX1LW14xlqivn/CdP8YqatuLEdqxpr9VPRzhtRXzWw==", null, false, null, null, 2, false, null },
                    { new Guid("69536a6d-5fc0-40dc-96ff-96cfa2e2ddde"), 0, new DateTime(1942, 4, 9, 19, 18, 28, 79, DateTimeKind.Local).AddTicks(4601), 672.7748273177510000m, "761976b4-e050-4762-a906-1c86f0425d19", null, null, null, false, "Christie", "Christie", "Emard", false, null, "Christie.Emard35", null, null, "AQAAAAEAACcQAAAAEJq9wLRS0S9Qgm6g0lj3I2REKbVnGYFkqgFEspsbl3CjoIxzJ41cx0bYIE5W95A9sQ==", null, false, null, null, 2, false, null },
                    { new Guid("69879006-dc0c-45ee-a1d8-571618a19f4d"), 0, null, 288.6775575253750000m, "92d615de-cff5-4f98-8ec7-f232add6347f", null, null, null, false, "Holly", "Holly", "Batz", false, null, "Holly65", null, null, "AQAAAAEAACcQAAAAELy7B0xr69WyElySrmAC5BA0Zb8nYkBsNg4Y8TG8KfmvRQP/9qPvFLx0fHn3uMqqDA==", null, false, null, null, 0, false, null },
                    { new Guid("6a6686d3-6711-42f4-b08b-ada2bf39be54"), 0, new DateTime(1961, 11, 15, 15, 49, 29, 947, DateTimeKind.Local).AddTicks(3589), 926.269453694960000m, "f69ac181-fd0e-43b4-beb3-6a6d2021d039", null, null, null, false, null, "Sheryl", "Hessel", false, null, "Sheryl.Hessel9", null, null, "AQAAAAEAACcQAAAAEOSIgPzat+Yn0EG6IOcNuwT+dRBUD+VQRSKC5QZ/s6fMO8uhofxc7WOI5Be4v3OnGw==", null, false, null, null, 1, false, null },
                    { new Guid("6b62d633-8ccd-4aa4-82e7-a8336a9e5760"), 0, null, 916.8291046749920000m, "8627bf73-d16b-49d1-a741-d9789725899c", null, null, null, false, "Johnny", "Johnny", "Williamson", false, null, "Johnny_Williamson", null, null, "AQAAAAEAACcQAAAAELUtWWyEV9woJvcsuef1/pxiSnRM05VKpz4Z5RGEEIdWIi0BagOIhtl67TLNAYIELw==", null, false, null, null, 0, false, null },
                    { new Guid("6cbb9172-2b78-4f00-a841-8a1e6d6be79b"), 0, null, 671.5702437294240000m, "ae66625b-dc55-48b2-926d-51f46a81a864", null, null, null, false, null, "Alfred", "Dietrich", false, null, "Alfred_Dietrich0", null, null, "AQAAAAEAACcQAAAAEMevrXosekZOmMbYeJDEetB3Lm0VqfzA8UnHtB/iQo8BMGmnAuzBo5TeC+eH8nL7Qg==", null, false, null, null, 1, false, null },
                    { new Guid("6db49be1-1b9b-4fd0-8b2d-52ae151f7432"), 0, new DateTime(2000, 6, 24, 20, 56, 46, 290, DateTimeKind.Local).AddTicks(2653), 683.6007467857130000m, "3ff1551d-6616-45cb-8ece-f00b6efd3cbb", null, null, null, false, "Bernadette", "Bernadette", "Bailey", false, null, "Bernadette45", null, null, "AQAAAAEAACcQAAAAEGY7O1ZwSb2corpKV/4E641rKl3/Jxc1aUoRVEdzsANNX55mMYlZCJWipoblLjj4WA==", null, false, null, null, 0, false, null },
                    { new Guid("6dcb62c8-dc29-4e18-aabc-b9f4d6f3d1ce"), 0, new DateTime(2002, 6, 21, 22, 26, 33, 487, DateTimeKind.Local).AddTicks(154), 190.5646067762090000m, "b5b64a56-19a9-46c7-8381-f113d8b6e507", null, null, null, false, "Jamie", "Jamie", "Hilpert", false, null, "Jamie_Hilpert9", null, null, "AQAAAAEAACcQAAAAEBR/CPjv64UQVt43hEvuHwdUpyyINoeV4rj610/yWexAT5vSqVHtKydbwVqVGOF8Bw==", null, false, null, null, 0, false, null },
                    { new Guid("6ee9a7d3-8695-4b4a-9a7f-e035a03a4cc3"), 0, new DateTime(1966, 1, 2, 9, 50, 58, 483, DateTimeKind.Local).AddTicks(2111), 823.5934892600640000m, "f5f8bb70-0037-410f-a071-8cba4154e4bd", null, null, null, false, "Tamara", "Tamara", "Smith", false, null, "Tamara_Smith91", null, null, "AQAAAAEAACcQAAAAEGJw+bUmkwzSJ0XJZyuD3GlNc1mw5qtAQjEo/o7HbRnpJauxkgbI2drp7D2vrsQWyQ==", null, false, null, null, 2, false, null },
                    { new Guid("708b56dd-a529-4229-82e2-2266f01c7942"), 0, new DateTime(1940, 3, 16, 12, 30, 33, 831, DateTimeKind.Local).AddTicks(9937), 441.3822256914560000m, "ea6ee7e8-8f8d-41ae-bed6-8b301b3b5d69", null, null, null, false, null, "Delbert", "Klein", false, null, "Delbert_Klein", null, null, "AQAAAAEAACcQAAAAEKXPJyLgpY5za4l1nzwcAtlpOYla4NcfYahRvuOIjj5JrtoUZTq/ZRXNij3UUwQsJA==", null, false, null, null, 0, false, null },
                    { new Guid("70c04dec-2a46-4304-b6d1-c42204afdab9"), 0, null, 841.4329876453410000m, "5766ae52-6500-4363-af99-ef48ac9bc798", null, null, null, false, null, "Jake", "Wyman", false, null, "Jake.Wyman8", null, null, "AQAAAAEAACcQAAAAEBjgBTp2TDX64htL1EA7E98m5B0qcZ7rBqbC5/jgvgj994W4AggCLDcMwvprjYEOwg==", null, false, null, null, 0, false, null },
                    { new Guid("716e3b4a-4381-424f-88d2-df0753a8cb13"), 0, null, 243.3211769924650000m, "d7410c3f-e57a-4eff-9d7b-80f9339d8322", null, null, null, false, null, "Blanca", "Marquardt", false, null, "Blanca55", null, null, "AQAAAAEAACcQAAAAEKF6J6XrMf4dj8bHiRuOps1+ukYMoKc4B0CYFr6TuKZU8lB0hASDbUmmquxMlfOm5Q==", null, false, null, null, 0, false, null },
                    { new Guid("71ef850e-2fd5-4538-9b05-9c38cbbdbe30"), 0, new DateTime(1935, 2, 11, 17, 46, 13, 948, DateTimeKind.Local).AddTicks(5065), 779.5140811912680000m, "822b5d45-6901-49ea-bdc7-5b9a9a3d8f39", null, null, null, false, "Myra", "Myra", "Feest", false, null, "Myra_Feest", null, null, "AQAAAAEAACcQAAAAEPg5BWbYn6zB+4+X6jBVagbcJ3LKOP7SJo/CJU4ndcMMObBEt62WtoRl9YsFISo1RQ==", null, false, null, null, 1, false, null },
                    { new Guid("72b9b70e-980c-47d3-a949-0b0acbdbe9f3"), 0, null, 538.7307083901210000m, "bca94538-7e0c-4982-b608-808e3dbb9df8", null, null, null, false, "Jaime", "Jaime", "Bernhard", false, null, "Jaime.Bernhard27", null, null, "AQAAAAEAACcQAAAAEB7CJx9557NbmAMjSBpiIHTet2Ib3SVw2iKWOde3D89hqHNPVkOQ93AfPLpFAJEfgg==", null, false, null, null, 2, false, null },
                    { new Guid("73850497-d7e2-4015-bf80-d8fc761772d3"), 0, new DateTime(1977, 10, 27, 15, 58, 14, 267, DateTimeKind.Local).AddTicks(5538), 556.5398219927230000m, "53585cc5-dedd-4ba7-8767-5a2ddb9f26dd", null, null, null, false, null, "Gilberto", "Langosh", false, null, "Gilberto_Langosh80", null, null, "AQAAAAEAACcQAAAAEKzLCNwnklNHu2LWKw0jMVduDcBqB0o8AW2owP1VuPjDMhkMyQGmtQ5ZCvMfGVgh4g==", null, false, null, null, 0, false, null },
                    { new Guid("73977b0d-a6cb-4576-bd4a-b7056acdccd3"), 0, null, 41.63959692034380000m, "68ef0a0d-4842-48bf-b3fd-cfc8117bd6e0", null, null, null, false, null, "Jake", "Fisher", false, null, "Jake.Fisher38", null, null, "AQAAAAEAACcQAAAAEBu4jb6behoKORveLD2wQDMsxTkQLvzigCDQ25io8NA7XczatsvGRKcF79/ZNlsT3w==", null, false, null, null, 1, false, null },
                    { new Guid("73aad8c3-cbed-4125-b80b-7db0735c3ac6"), 0, new DateTime(1995, 4, 19, 5, 10, 11, 824, DateTimeKind.Local).AddTicks(3942), 486.27452260280000m, "a4a1d00e-38b9-4d72-a7dd-41ec369f12ac", null, null, null, false, "Gilbert", "Gilbert", "Little", false, null, "Gilbert_Little", null, null, "AQAAAAEAACcQAAAAEDz1hnMrznmcECjTOMf7qW826Ki44xZcgkVm0gGbk2/o/m+h44jh/j2+2+HOMqjsNA==", null, false, null, null, 2, false, null },
                    { new Guid("749d009d-0557-4289-976a-50a7e345a281"), 0, new DateTime(1964, 5, 17, 12, 34, 5, 350, DateTimeKind.Local).AddTicks(1048), 302.4221525732940000m, "b83df82a-e185-46fd-8664-82840810095e", null, null, null, false, null, "Ernest", "Turcotte", false, null, "Ernest_Turcotte27", null, null, "AQAAAAEAACcQAAAAEAFY0S75ILgbI0bCFQU5SgCjIN8LYMLGY3SwdGweF4sDdaJylTr6hdzyb4pCmQfP2Q==", null, false, null, null, 2, false, null },
                    { new Guid("77332645-fb25-478f-998c-36dd38aaba91"), 0, null, 293.162393411890000m, "24d9b62e-1d8e-4dc5-a824-37f767cdcd62", null, null, null, false, "Kenneth", "Kenneth", "Legros", false, null, "Kenneth_Legros17", null, null, "AQAAAAEAACcQAAAAEAbW+Ezlqq5VopeilIoNooY/LZe64EeEcVrnLfR6gSmXtPxcvp9rlGqi90CkCpmzoQ==", null, false, null, null, 1, false, null },
                    { new Guid("7771e104-7d9f-4097-8375-a33ad264e1d8"), 0, null, 799.732774368820000m, "7a186d35-5832-4107-a6cb-4f428f55ae74", null, null, null, false, null, "Joey", "Ortiz", false, null, "Joey.Ortiz", null, null, "AQAAAAEAACcQAAAAENEO/wOqUrf7AHUSn1bhmTyYieKJtoSsJjAm2u1eF5TgCvsWSCPHcSzqvSClKzSWMg==", null, false, null, null, 0, false, null },
                    { new Guid("777e0877-9079-4ecc-a52b-f0bf5734b939"), 0, null, 83.81211889740510000m, "e470b565-dfb4-4324-9e02-9b35183b2fdc", null, null, null, false, "Lois", "Lois", "Witting", false, null, "Lois97", null, null, "AQAAAAEAACcQAAAAEBGf1Azl+2LUxffVF49p8071z0KP+0j+AhxHFG2q8fQfp9lwpkpcioi2KahJMvw3MQ==", null, false, null, null, 2, false, null },
                    { new Guid("7805e438-4982-4f20-9e68-baca0c631417"), 0, new DateTime(1998, 9, 29, 1, 50, 45, 467, DateTimeKind.Local).AddTicks(6539), 633.0164201324350000m, "82e366cb-fc82-4e95-bc8f-0da4a2d61fb4", null, null, null, false, null, "Johnnie", "Waters", false, null, "Johnnie90", null, null, "AQAAAAEAACcQAAAAEKzL3MAFtWr3HiBLEiHk3ePoS8crLJwHpMKCxuG7fVNpABC3t9WtSmyJOJSDHCpg9Q==", null, false, null, null, 2, false, null },
                    { new Guid("78615ad6-0a03-477e-a515-c98b1a96475d"), 0, null, 66.41261485719130000m, "07d759b9-b73d-43a6-bdf1-3e9692062b72", null, null, null, false, "June", "June", "Mraz", false, null, "June38", null, null, "AQAAAAEAACcQAAAAEDLIcGxpAOzWTohODOe+UbxzQDMmos5IGnV2tcocJughcBLCRC04XuuEzwzeQMNnag==", null, false, null, null, 1, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "Email", "EmailConfirmed", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("7889ec96-3dce-40c9-a3d9-1dabf9642602"), 0, new DateTime(1936, 8, 20, 4, 7, 32, 698, DateTimeKind.Local).AddTicks(9948), 981.1490456832070000m, "79bebfe0-4f86-41f4-9453-7f6456ffd610", null, null, null, false, null, "Chelsea", "Thiel", false, null, "Chelsea78", null, null, "AQAAAAEAACcQAAAAECkG752dO7Bxe3xsjiKzoDfve8fL+wGhpQvTPAbFWb5qLKTwJVARngMX3EabjNyWoQ==", null, false, null, null, 2, false, null },
                    { new Guid("7902b014-f441-4bad-a55f-7656352c84e7"), 0, new DateTime(1949, 10, 26, 20, 4, 57, 246, DateTimeKind.Local).AddTicks(1110), 923.5864292988920000m, "6525d407-00dc-479f-86e0-38892247ba21", null, null, null, false, "Nichole", "Nichole", "Crist", false, null, "Nichole34", null, null, "AQAAAAEAACcQAAAAEL5RVTQe2Os+dcycCWuY1iS4kvJqFGPkem/cPxS0SrO28UDMMjkjNEZkeXisEYr64Q==", null, false, null, null, 0, false, null },
                    { new Guid("7b354f95-20a6-4d69-abe1-b5a212feb069"), 0, new DateTime(1953, 8, 28, 5, 30, 55, 962, DateTimeKind.Local).AddTicks(3615), 242.649460404110000m, "de6cb580-786a-4a97-a4c3-61e32f56785c", null, null, null, false, "Lillie", "Lillie", "Bednar", false, null, "Lillie98", null, null, "AQAAAAEAACcQAAAAEDKvno1Wy5UqI2pwX7fKHFFIpuKnyiVBr5Js9wNNg2VMvSHbj8KBnYEv5hITVMPmBQ==", null, false, null, null, 2, false, null },
                    { new Guid("7b9acf5a-1eec-4436-8152-103e38ca0953"), 0, null, 294.7771496879090000m, "ccb10198-ab35-4c0e-a319-0aa65410a4d1", null, null, null, false, null, "Christy", "Tremblay", false, null, "Christy77", null, null, "AQAAAAEAACcQAAAAEMa73foHsGSGjSG8s0Agei8IXiDlcFZi/1z3h5805iWg1ctiCXD3M/cnd5svjps/CQ==", null, false, null, null, 1, false, null },
                    { new Guid("7e5e5ebc-3d4d-451a-884b-00a9d9f53676"), 0, null, 54.09264441246820000m, "d29e2b0e-59ae-4921-895f-c657e042d3ec", null, null, null, false, null, "Johnnie", "Armstrong", false, null, "Johnnie_Armstrong", null, null, "AQAAAAEAACcQAAAAED3ZfUh8sTP+ZDI2vaVBwHRahjZWmDl/qG8QuPjB6EwMS83RxsUS/czKpkof1/itsQ==", null, false, null, null, 0, false, null },
                    { new Guid("7f910a03-763a-4cdb-bbcb-8241bae6fc96"), 0, null, 118.6537381168070000m, "79fef44b-f190-4d04-81af-af5d2bba8637", null, null, null, false, "Heidi", "Heidi", "Heaney", false, null, "Heidi_Heaney35", null, null, "AQAAAAEAACcQAAAAEIAxiR/w/2noMtEUrygKQGaXXD6mejsr8QEFOT6oq0mGCHSJH96+XUZIAWUNwdG5hA==", null, false, null, null, 1, false, null },
                    { new Guid("83521c38-fd64-4bbe-89bf-e217d9771096"), 0, null, 604.3240685489360000m, "f0befd0b-7aaa-4eb6-8618-480cb1db7c90", null, null, null, false, null, "Gene", "Adams", false, null, "Gene16", null, null, "AQAAAAEAACcQAAAAEBb5uwG8jrF65UWbBcK6qLvp5HGHLWh2i5pQ9Dl8WApoFZWTqEAe/bzDCcTjFYgNYw==", null, false, null, null, 0, false, null },
                    { new Guid("8513debb-cacb-47df-a4d3-e59f2a261b69"), 0, new DateTime(1960, 12, 13, 6, 18, 10, 182, DateTimeKind.Local).AddTicks(7482), 306.5060614097150000m, "e4117ba3-44bf-4ffd-91ae-016e0196ef1f", null, null, null, false, null, "Emilio", "Erdman", false, null, "Emilio_Erdman", null, null, "AQAAAAEAACcQAAAAEO8zWVmLLvEMbwCfVKH7yOM1nqD1RzPRQfLwgygls/r2LY8GYze95AF46OAI5kpaTw==", null, false, null, null, 0, false, null },
                    { new Guid("857e5ff4-368c-45c8-909c-9cb05ea33802"), 0, null, 851.682856579250000m, "ebcd7e0b-3284-4a30-bad6-700c28c0402d", null, null, null, false, "Danny", "Danny", "Zboncak", false, null, "Danny.Zboncak", null, null, "AQAAAAEAACcQAAAAEAaDgzMir3OYpbYtE64qKSaPkZSo/fxVnQUFanBqIg7dkx3eONC9FH6Adg3p9QMeDw==", null, false, null, null, 0, false, null },
                    { new Guid("859757d1-9ad7-45f4-8664-764e0db29fec"), 0, null, 123.8035531976280000m, "c2ed1532-c27d-4666-8268-695fd65e2146", null, null, null, false, null, "Guadalupe", "Shanahan", false, null, "Guadalupe66", null, null, "AQAAAAEAACcQAAAAECLyZQSzgvrh3JBlg/Gpz9kgCuudUMiG9iP6KE/fn44FA5j1xMMlceQcnmlKk0HyaQ==", null, false, null, null, 2, false, null },
                    { new Guid("8606d3d5-5f3e-4f9a-b953-4be892f06c0d"), 0, new DateTime(1948, 3, 7, 18, 56, 24, 435, DateTimeKind.Local).AddTicks(1200), 664.0200768179370000m, "32af54bc-07a9-4969-8728-36877d8a6041", null, null, null, false, "Johnny", "Johnny", "Schiller", false, null, "Johnny.Schiller", null, null, "AQAAAAEAACcQAAAAEKaA5mm8RC8INEIDeqjXewQdZYrfCGnpGiESZyngTaoSOChdPHR+qwpO0KwHSrhkUg==", null, false, null, null, 2, false, null },
                    { new Guid("86139076-e779-453a-8f87-64e1bfeeeccc"), 0, new DateTime(1983, 10, 30, 15, 0, 46, 1, DateTimeKind.Local).AddTicks(584), 63.29648598300260000m, "fa261d48-1e15-4d14-adba-8d5b6b4f04ba", null, null, null, false, "Glen", "Glen", "Glover", false, null, "Glen39", null, null, "AQAAAAEAACcQAAAAEPdKDe7pTtmJE4dsBSC7iUPktT1HL0Yr1NnjdPZTYmQSSfJQtiHHPAwgPMQt9m8Deg==", null, false, null, null, 2, false, null },
                    { new Guid("861c20c6-b2fe-4d03-a2b4-ae2380f7edc5"), 0, new DateTime(1931, 7, 31, 7, 8, 52, 214, DateTimeKind.Local).AddTicks(9902), 893.3535121633760000m, "943a6610-5d27-4f85-9642-e5d2983a867e", null, null, null, false, null, "Roy", "Bogan", false, null, "Roy.Bogan", null, null, "AQAAAAEAACcQAAAAEODWgR7maMHbsYIY0G6NEUxj9p8T7DP3Ej3ojIwAldH8avyAgKozgwNIBnmGC1CTUA==", null, false, null, null, 2, false, null },
                    { new Guid("872eccf4-a3fa-43c5-ab2e-ac6f6c9e4f17"), 0, null, 92.81866815359010000m, "c2271c2b-fdac-45e2-b63b-0439ec288fb4", null, null, null, false, "Jana", "Jana", "Leannon", false, null, "Jana.Leannon", null, null, "AQAAAAEAACcQAAAAEFpeuAVlTG606l1MgVLPlhGR1VyB5WixvfHJjPblZeK92UuUmLIE+fnys6vbUhIxdQ==", null, false, null, null, 2, false, null },
                    { new Guid("88155035-c6f4-450c-bd25-3d3e9c9d8f5d"), 0, null, 581.1561815332230000m, "c7ff789e-565d-4e8d-8d12-6f89a3c1d4ca", null, null, null, false, null, "Anne", "Steuber", false, null, "Anne.Steuber13", null, null, "AQAAAAEAACcQAAAAEKPUOPtrrbvp6wbyJr0+CAc3ery2/Qc6FtyxmaEPeDji40pNyPW2ta5rWqFozQNxSw==", null, false, null, null, 2, false, null },
                    { new Guid("8892b0e2-0aef-404c-8681-2866126b786f"), 0, null, 716.6648343833150000m, "577ba05c-5b2a-4253-8299-5aabc672a065", null, null, null, false, null, "Sabrina", "Raynor", false, null, "Sabrina11", null, null, "AQAAAAEAACcQAAAAEFLlZ2t3gth0z8dk4tHggpjJ7NMSmhwTa4QJX0CQbWYvg86+oL/O2XzLBV3+ke6iWg==", null, false, null, null, 2, false, null },
                    { new Guid("89c19062-b085-4717-8960-680ec5f619e0"), 0, null, 833.023665378120000m, "8c77a734-cbb1-4702-8de7-93de6702c382", null, null, null, false, "Cynthia", "Cynthia", "Conn", false, null, "Cynthia.Conn3", null, null, "AQAAAAEAACcQAAAAEGTtzeFgdKG9m6vUbx8Yuvafrck9NkJqxOa+9DfRlP7J5aoeqIWdMreWxs6kFB4HyQ==", null, false, null, null, 1, false, null },
                    { new Guid("8a1cc6ac-cbbb-45b8-a858-79df665cbf01"), 0, new DateTime(1940, 10, 7, 10, 36, 10, 670, DateTimeKind.Local).AddTicks(5931), 268.3843139268830000m, "ccbd6540-e391-448b-8b10-cdf1b7e04d1b", null, null, null, false, null, "Anthony", "Frami", false, null, "Anthony.Frami33", null, null, "AQAAAAEAACcQAAAAEBoV0eHEoEzlDHINuyUAcCR5nDwJqAtVLsNbER2R/f9rqTrafZpcPeTJiZxmt0H8BA==", null, false, null, null, 2, false, null },
                    { new Guid("8adfe810-a4af-41ad-bda0-c1898bdb4d92"), 0, new DateTime(1988, 9, 25, 1, 49, 44, 896, DateTimeKind.Local).AddTicks(1890), 479.7840828473350000m, "651e4a46-11a7-484c-8d0a-062c7c9d9a3c", null, null, null, false, "Kelli", "Kelli", "Goyette", false, null, "Kelli76", null, null, "AQAAAAEAACcQAAAAEGDFGyyTyxDMHsvzgv0+TONGmCUrU2cda+Ss1hTbQ02J96qd3SYHhXNSVZoppcCU5A==", null, false, null, null, 1, false, null },
                    { new Guid("8bbc87aa-2bdb-4898-83a2-ca540a697ac0"), 0, null, 780.5009163066880000m, "ba241155-7991-4015-9ced-53e7053258bf", null, null, null, false, "Patti", "Patti", "Torp", false, null, "Patti.Torp18", null, null, "AQAAAAEAACcQAAAAENITpmFXH9pbWoBvfkNTr+romtAU58YZx5IWE8Xo6djnXb23Y1koJIALjGUHOsIccQ==", null, false, null, null, 0, false, null },
                    { new Guid("8bbc88c0-c35c-496f-b3fc-e18f3d8bad18"), 0, null, 59.56062235145550000m, "604cce35-720f-4503-90f9-8afacb6b48e9", null, null, null, false, "Johanna", "Johanna", "Marvin", false, null, "Johanna.Marvin23", null, null, "AQAAAAEAACcQAAAAEHvCgaae8PrIN/Y4UPE602qERfUpIPw1UGXe4LDq5y6HXU2DEDK4bl6wTRo46MvnYQ==", null, false, null, null, 0, false, null },
                    { new Guid("8c7f5100-7603-4d85-9e37-fba6a586f7c8"), 0, new DateTime(1990, 4, 23, 21, 39, 53, 438, DateTimeKind.Local).AddTicks(7945), 626.669227312270000m, "64a9d430-b262-4cc7-9f93-4ee5b9388925", null, null, null, false, null, "Cesar", "Bins", false, null, "Cesar34", null, null, "AQAAAAEAACcQAAAAEJptKQ9DYywxJXCqlgH7zX0yHkIoGh8jb9TfSms5WIarynzU3xrRFzK5qRn0y/mxlg==", null, false, null, null, 2, false, null },
                    { new Guid("8dd6a489-4514-4244-9fa7-a1490970f38b"), 0, new DateTime(1949, 8, 14, 11, 41, 22, 48, DateTimeKind.Local).AddTicks(7515), 509.7341315802360000m, "a2830580-376b-4ae7-8317-00860cfd698c", null, null, null, false, "Maggie", "Maggie", "Crooks", false, null, "Maggie78", null, null, "AQAAAAEAACcQAAAAEIfJkdY6ihDIlo3QuGzf7iZ+UdDD/UEDPGytAvOEuDsE/JEIkmxhVR/Z9WaKigS1gw==", null, false, null, null, 1, false, null },
                    { new Guid("8e832b0b-a138-409b-b85d-4b68d03a07b6"), 0, new DateTime(1981, 12, 30, 9, 16, 14, 374, DateTimeKind.Local).AddTicks(4038), 759.7758311032850000m, "77b62967-5a17-412c-9b08-91fd7f767d8d", null, null, null, false, null, "Keith", "Maggio", false, null, "Keith45", null, null, "AQAAAAEAACcQAAAAEKTfE4612eC/JQrQzyAlLLdkNIR+IdR9iGZA1xvHrg6lz3AYt/BbEmtIkWHP2KcjUQ==", null, false, null, null, 2, false, null },
                    { new Guid("8e8fd0f7-2809-49f2-9c1e-cbeb885b2de7"), 0, new DateTime(1935, 9, 20, 8, 45, 15, 451, DateTimeKind.Local).AddTicks(5376), 493.0372669181520000m, "c97de281-ed3e-4e51-a894-178a212026e6", null, null, null, false, "Bridget", "Bridget", "Hahn", false, null, "Bridget68", null, null, "AQAAAAEAACcQAAAAEML3sifotl9k8P2H7svn8c1eMEt792mX3OS196MSBGWIHLDT452sOznuOlt0zKmqPw==", null, false, null, null, 1, false, null },
                    { new Guid("91024531-3bc9-4397-868c-67a81b4abcfc"), 0, new DateTime(1951, 1, 19, 14, 25, 39, 452, DateTimeKind.Local).AddTicks(4393), 208.8776243641020000m, "c03e789d-6189-49ab-864a-6142b28411f0", null, null, null, false, null, "Betty", "Klocko", false, null, "Betty45", null, null, "AQAAAAEAACcQAAAAEFnL3OAvcQwALU+9D2DQrbEFESXuz7OdRO7jsQ5rRSorwo8aadLqJJ+0F8VBxLZ2ig==", null, false, null, null, 2, false, null },
                    { new Guid("93ac31b1-6465-45d3-b0b5-98811dbc77b4"), 0, null, 311.9503892006610000m, "a97ea272-31dc-41f9-9bdc-fb1dc0477f6d", null, null, null, false, null, "Becky", "Collins", false, null, "Becky25", null, null, "AQAAAAEAACcQAAAAEMGu5fA5RIiYtxDm90knnH7m8YoJuluPO+RzU8JsOf7Ln1Xd80Y9QmhkhFJ7v7Z8EQ==", null, false, null, null, 0, false, null },
                    { new Guid("93b22657-e430-4b16-b1f2-af9b44bd9175"), 0, null, 424.8368059773730000m, "886f5f2e-bdca-4bfb-963b-cc17b65e12ad", null, null, null, false, "Myra", "Myra", "Considine", false, null, "Myra.Considine35", null, null, "AQAAAAEAACcQAAAAEBI48UYyhiylWb1p9Jyb6/gzGt7x/JfUvLH1AK1DfviyLEACdiJjX/mbevG2I+kiPg==", null, false, null, null, 2, false, null },
                    { new Guid("94e92894-3b19-4c5f-9e95-0ec52116ec92"), 0, null, 767.4541308209540000m, "a3a0ca48-7542-449c-8c25-dbf1903bfa65", null, null, null, false, "Mona", "Mona", "Beier", false, null, "Mona.Beier", null, null, "AQAAAAEAACcQAAAAEMfHuis/amQbU2DpdkB/gR9x8oBMhc4+Of4as42zlwUpch627tjZIsuse9E+Xh5gJg==", null, false, null, null, 0, false, null },
                    { new Guid("960fe293-a56c-42c1-b68b-57d1e361fe6d"), 0, null, 851.3934935216750000m, "f262c9a4-0505-4ed5-90c6-0fd89063360f", null, null, null, false, null, "Bryant", "Skiles", false, null, "Bryant39", null, null, "AQAAAAEAACcQAAAAEJmgxC9bW5FGJ9zE3fLQ5Th4p1HEAUgcD8RpgKf5bc67XJTEG8NwHiM6wXAitWsNJA==", null, false, null, null, 0, false, null },
                    { new Guid("96357562-82d6-4394-b4bf-5b698e1ad612"), 0, new DateTime(1957, 5, 7, 14, 18, 39, 279, DateTimeKind.Local).AddTicks(5386), 528.3979444581870000m, "3605ece1-5e48-4367-b812-1020e60b2a32", null, null, null, false, "Sean", "Sean", "Goldner", false, null, "Sean.Goldner43", null, null, "AQAAAAEAACcQAAAAEEJYNOj6mKv6rA2sdiHOxgCOwqWWwr4YfI3HSdL4Q3iGxawOHpMlEt/BRtkfyatTLQ==", null, false, null, null, 2, false, null },
                    { new Guid("96389a1d-3bc8-465b-ba35-3027877a9981"), 0, null, 125.0628011515680000m, "6e4b5499-745e-432a-a87c-e16b529fff1c", null, null, null, false, "Ellen", "Ellen", "Hettinger", false, null, "Ellen_Hettinger4", null, null, "AQAAAAEAACcQAAAAEKO7dSR8bJE+AcuohPywxL2OepELmEuh1fVpaOso90y64gZ02HrgHoGH1li3hROjhQ==", null, false, null, null, 2, false, null },
                    { new Guid("966d5ef1-e601-407d-86be-887c8e79a449"), 0, null, 182.4748565459480000m, "a1e1589c-a0ae-485c-9e54-75a779ef4d1f", null, null, null, false, null, "Paula", "Rogahn", false, null, "Paula_Rogahn1", null, null, "AQAAAAEAACcQAAAAEB0Yidgdizyw0ShP9YGqOO+UcBv9T6gsS8Am9YgUMpj8u4CcBK5fFQ/ONe5rkA7AmQ==", null, false, null, null, 1, false, null },
                    { new Guid("967d4ff4-7cca-4fd1-a75a-2f73aca9ca0a"), 0, new DateTime(1978, 7, 26, 14, 53, 4, 288, DateTimeKind.Local).AddTicks(906), 474.0033744632030000m, "3b0afecb-21be-4db1-b0d9-520269e54e5a", null, null, null, false, "Abel", "Abel", "Johns", false, null, "Abel96", null, null, "AQAAAAEAACcQAAAAEN7y1yESl5++IHAfcLii13U8pRRQkWD0fzqp/4So7dTwrv2wKYvfMW7oRNfV7cKIkw==", null, false, null, null, 0, false, null },
                    { new Guid("97c89012-688a-4d00-9708-03d8cb08dc2e"), 0, new DateTime(1988, 8, 19, 19, 4, 35, 728, DateTimeKind.Local).AddTicks(2480), 722.8589322814730000m, "7fd181da-2aff-4f65-9d33-1c116ff00699", null, null, null, false, "Ruth", "Ruth", "Jast", false, null, "Ruth20", null, null, "AQAAAAEAACcQAAAAED7jIjwyWinzUGkwIi9038FCRC7FoTODlR8Hpj16mS9335mpnyUC/1usVht7VuaPyg==", null, false, null, null, 2, false, null },
                    { new Guid("97d70a43-949c-4c03-9da7-fc16fdc0c86d"), 0, null, 675.1906527721290000m, "3d0e4572-ba3b-49b9-b69e-7a7f97247444", null, null, null, false, "Timothy", "Timothy", "Dare", false, null, "Timothy.Dare44", null, null, "AQAAAAEAACcQAAAAEK48oDJk1Ry0hWEY2eATQfCpndmMc/yjH+x7yDlKM/6CXnTffrlke4Kz/Kz+UrOHJw==", null, false, null, null, 0, false, null },
                    { new Guid("98222b1e-1352-4ac9-8c47-69a7f0582ef6"), 0, null, 490.3290886337980000m, "9b364c0f-60ff-43ef-8e7d-59b77c37917e", null, null, null, false, "Tracey", "Tracey", "Hahn", false, null, "Tracey_Hahn", null, null, "AQAAAAEAACcQAAAAEDaAQCwKD7oUInckFHcan12JLolTsjy8WKkLJirv7Lda4BLGi9GsinWIEAE4Ahk/3g==", null, false, null, null, 1, false, null },
                    { new Guid("997402b2-514c-445f-9988-ae18a101181e"), 0, new DateTime(2002, 7, 19, 2, 14, 13, 993, DateTimeKind.Local).AddTicks(7635), 310.2876380862180000m, "28828366-70a0-471f-990e-e6d8ba64a68c", null, null, null, false, null, "Jo", "Conn", false, null, "Jo.Conn", null, null, "AQAAAAEAACcQAAAAEIDapi/rw1oSVqM7Rs2cFwtFyD6xom7FJRqnBVHlME+SNMWRaQH5Rw98ogSDeacucw==", null, false, null, null, 0, false, null },
                    { new Guid("9a38b671-5580-4658-abf4-c1fc9ce2be0b"), 0, null, 441.3048749012690000m, "03b83066-7286-4b39-a03a-6d26d353fdda", null, null, null, false, null, "Mandy", "Pacocha", false, null, "Mandy_Pacocha40", null, null, "AQAAAAEAACcQAAAAEM1UYPLC+TMJNqSTP790QfmCu+FrxNixN2hll+h4LcVKOUIj8H1u64/V22RqUenLJQ==", null, false, null, null, 2, false, null },
                    { new Guid("9a799371-7ad4-44c8-bcc3-759981e1573a"), 0, new DateTime(1925, 7, 6, 22, 25, 48, 805, DateTimeKind.Local).AddTicks(481), 128.2067314088970000m, "4aa3eeb0-a613-41bf-b918-35436c6b9fb3", null, null, null, false, "Annette", "Annette", "Farrell", false, null, "Annette27", null, null, "AQAAAAEAACcQAAAAEJOdX+JHsPmtVrWMC9tKYkPoMopX+OtWAGF4/neVJlmMg/kiPuAfjVpWtXSuU8mFqQ==", null, false, null, null, 2, false, null },
                    { new Guid("9b0c9ef1-c568-4fc6-8e02-cbbb959e0bbb"), 0, null, 793.1444040398120000m, "51031a6c-0b7d-41cd-a92d-679dc59ac1cb", null, null, null, false, "Catherine", "Catherine", "Roob", false, null, "Catherine78", null, null, "AQAAAAEAACcQAAAAEK9r48LGjxrhwyEqM2CzT/D2AWvSIQB8cH/hsuh+XX3cbP1pAgL/gRKFNCsXxdGR9w==", null, false, null, null, 2, false, null },
                    { new Guid("9b8fcbcf-ce9d-40cf-aa2a-0543ebe6f135"), 0, new DateTime(1965, 2, 27, 3, 22, 47, 539, DateTimeKind.Local).AddTicks(1014), 132.9309220426370000m, "ebc922d4-dbf2-4072-93a3-d2c46d47581e", null, null, null, false, "Jesse", "Jesse", "Ledner", false, null, "Jesse.Ledner33", null, null, "AQAAAAEAACcQAAAAEH4ELU1+US4ZBP8iCfPhTh+n5ShkkaPf097hWRuVvTfnik7k+zqPvU0EOipboUQ66A==", null, false, null, null, 0, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "Email", "EmailConfirmed", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("9dafc6e9-0e56-47f8-8b8b-4ca541841bd0"), 0, null, 823.4854814460880000m, "53b3d41a-e6f5-4f42-91cb-078300351793", null, null, null, false, "Vernon", "Vernon", "Hilll", false, null, "Vernon.Hilll", null, null, "AQAAAAEAACcQAAAAEG2NbFE12ELdm5W15qIj7SU6W04fS4+THf5yuVZ8h6CL0fAxAnxe8ET19rHJ4oJ7zg==", null, false, null, null, 1, false, null },
                    { new Guid("9e4f824d-b29a-4ec5-b3a1-111d46f41ecb"), 0, null, 127.8974675837980000m, "e100c651-d78a-498f-b771-e45c70842885", null, null, null, false, null, "Dawn", "Lueilwitz", false, null, "Dawn_Lueilwitz", null, null, "AQAAAAEAACcQAAAAEJsHEY52XxbpQwNIdE6M+liIDQZ8DJMBK91JUhUU9atKEZcLoCYV0gtoaD3TBpoiHg==", null, false, null, null, 0, false, null },
                    { new Guid("9e73d492-68df-4c26-bbd7-c238340416ec"), 0, null, 175.7184564832970000m, "ab4dd6cf-4d99-4668-83e0-41fc13873f4f", null, null, null, false, "Heather", "Heather", "Flatley", false, null, "Heather25", null, null, "AQAAAAEAACcQAAAAEKMFKEQDzWwWke84UOTa1rD6qJWQwF30H237Us65HM84+u3C7ujdBoDHR9b5Irv8Hw==", null, false, null, null, 1, false, null },
                    { new Guid("9eb02965-fa79-4bc7-940e-eff714a39f7e"), 0, null, 107.4570062164620000m, "74cffed1-9861-416a-9cbd-d80c27a7b1fd", null, null, null, false, null, "Heidi", "Veum", false, null, "Heidi92", null, null, "AQAAAAEAACcQAAAAEJMGURLS5ryNIvr2+9KOnms/5oIDvS0rzuCs19NoeUmyMVOtuMV2suX84QRHVsUOQg==", null, false, null, null, 2, false, null },
                    { new Guid("9f317a02-0a11-4f32-b538-7ec5c02e4b5e"), 0, null, 352.5961677220750000m, "09ae6e71-1b73-4483-bd43-a5cb5331bcf6", null, null, null, false, "Alberta", "Alberta", "Kshlerin", false, null, "Alberta_Kshlerin93", null, null, "AQAAAAEAACcQAAAAEFqZ5iMzhU7YakPKhv7SN4N2L1px3JpNvG9UwPMlFkm+fG+tlUuhXd+SzJe9xH6uUg==", null, false, null, null, 0, false, null },
                    { new Guid("9f331cb7-b70d-434b-bc28-147a5e624fd8"), 0, null, 590.2328533824950000m, "93454841-d7b2-4106-b1d0-551f7c4f8e9b", null, null, null, false, null, "Frederick", "Effertz", false, null, "Frederick.Effertz", null, null, "AQAAAAEAACcQAAAAEDATZ+JmFDw2rUBMdNhpWlGoLflsijCubTJAo15evvEkSUcaP20srkuzgU9bpZxzjg==", null, false, null, null, 0, false, null },
                    { new Guid("9fc4b18c-b710-43c3-be29-ffdea2c51975"), 0, new DateTime(1968, 11, 2, 4, 1, 20, 578, DateTimeKind.Local).AddTicks(6190), 892.5549663242620000m, "c8edbe8a-f5e1-4736-a430-b350b0220dba", null, null, null, false, null, "Patrick", "Wyman", false, null, "Patrick_Wyman", null, null, "AQAAAAEAACcQAAAAEP3dMnDZmmwSTQUKLDErdG/S+7MQTnAKnsDgzYcLkelPXhURjMGONHfeHCHAgoRMEA==", null, false, null, null, 1, false, null },
                    { new Guid("9ffccffc-cb42-46e5-86d7-6730697facf3"), 0, new DateTime(1925, 2, 18, 11, 25, 19, 900, DateTimeKind.Local).AddTicks(28), 699.6377974167180000m, "78eb68e3-b9a5-4953-b30f-87c35cd883fd", null, null, null, false, "Elisa", "Elisa", "Murphy", false, null, "Elisa92", null, null, "AQAAAAEAACcQAAAAEB0KRah++5yewNWP1g2NKJG7zwn4VZhTcUiog1ke8Cv0O4jFo9IpRWygO8WchXzl/g==", null, false, null, null, 1, false, null },
                    { new Guid("a01a13e5-a8d1-4048-b8b2-24cdfac5f11e"), 0, new DateTime(1928, 1, 13, 9, 41, 58, 158, DateTimeKind.Local).AddTicks(9624), 970.2315195477360000m, "1fc3045f-fecd-4a11-8b10-829444929e63", null, null, null, false, null, "Johnnie", "Hodkiewicz", false, null, "Johnnie_Hodkiewicz", null, null, "AQAAAAEAACcQAAAAEI7hGJJPe3Shq730cmgCXod/oOoDjTq+5d0fRP40q+KfFFzV2zZF2SfxCGOM+COE7w==", null, false, null, null, 0, false, null },
                    { new Guid("a13d28a1-8900-4b0d-8399-27cc466b719f"), 0, null, 856.6514312904860000m, "f4090070-5b5a-47b4-a6c5-a1e913e7f13f", null, null, null, false, null, "Frances", "Hermiston", false, null, "Frances_Hermiston", null, null, "AQAAAAEAACcQAAAAELxynuZq+/NKzI85cdrOCKFTeQAIWlnwcD08K/T9rUuQcVR+BuKcMQwsDZ2VZmgXbQ==", null, false, null, null, 2, false, null },
                    { new Guid("a161bc80-bb44-439e-bb80-442569d93b23"), 0, new DateTime(1929, 7, 14, 3, 21, 19, 489, DateTimeKind.Local).AddTicks(3631), 890.4192769773480000m, "2d2d5b87-bb43-4e82-ba39-f50acede6e0b", null, null, null, false, null, "Carl", "O'Hara", false, null, "Carl_OHara67", null, null, "AQAAAAEAACcQAAAAEJ94FTxFjuZyNWqtA8zrx4Kgp6rfzKM66S+h+owisArsZJ6ENG+EafCYb4lSV+/lWw==", null, false, null, null, 0, false, null },
                    { new Guid("a165efc8-0956-4593-9333-e1ab17939488"), 0, new DateTime(1926, 4, 7, 6, 16, 12, 312, DateTimeKind.Local).AddTicks(892), 82.07532917227160000m, "2f7cfb51-6667-4fb4-8a0c-0110f71e492b", null, null, null, false, "Veronica", "Veronica", "O'Connell", false, null, "Veronica.OConnell", null, null, "AQAAAAEAACcQAAAAENoBCmw4tREJNAIlPCBGmsZMdwzC94X6ganM7CAR32jKvskqmhrpoWqon1KLN1puXQ==", null, false, null, null, 2, false, null },
                    { new Guid("a3564d73-cc7f-45bf-bb8d-5bff9f9bd319"), 0, null, 288.6219320830660000m, "569610e5-d1c7-4260-b653-4db9932344bd", null, null, null, false, "Tonya", "Tonya", "Lang", false, null, "Tonya.Lang9", null, null, "AQAAAAEAACcQAAAAEHHA+AjWBNituDAyw4XR5WQos5fWEP3PtwNuS9v5O9Y1u6SCH5MLRHkot0nasKf45g==", null, false, null, null, 1, false, null },
                    { new Guid("a3a7c05f-2de2-47a6-9d73-3dc95cb0a4bf"), 0, null, 58.60144878530580000m, "44c93207-a6a6-48b0-8a0f-00de3023d420", null, null, null, false, "Marcella", "Marcella", "Rath", false, null, "Marcella87", null, null, "AQAAAAEAACcQAAAAECqb7dbd5IF6HMVtcXwO0TCjIc1qEGmFs8F60NuNrlwOLGxqNWBBFa2R1znMDG/tlA==", null, false, null, null, 0, false, null },
                    { new Guid("a4b4b14f-6b7f-4104-b0d2-b8f55417f1e7"), 0, new DateTime(1967, 7, 13, 21, 5, 55, 189, DateTimeKind.Local).AddTicks(4490), 583.5296116575370000m, "64207a4f-f426-4c26-a052-6e5713651f52", null, null, null, false, null, "Angela", "Cormier", false, null, "Angela_Cormier", null, null, "AQAAAAEAACcQAAAAEI/kBaoDMZs+a7/CmIWrQkcJ+NK/Qjb5n3OG+szWnVqd0SxbP7TRKwDdfSQCOnoX2g==", null, false, null, null, 1, false, null },
                    { new Guid("a64a13ca-2754-4769-a254-32716c64c908"), 0, null, 200.8272686687960000m, "55a5bd3f-e914-4247-b8c2-a31a143c1207", null, null, null, false, null, "Rosemary", "Braun", false, null, "Rosemary.Braun", null, null, "AQAAAAEAACcQAAAAEIgxG4z3V9QzRRQluPwygcBhhI7TAevK4V9zjVRZzoejkh/VT5wT68cdoAqqVqMBDQ==", null, false, null, null, 2, false, null },
                    { new Guid("a6b4e3da-0d2b-4dbd-9f10-ea183f9d6225"), 0, null, 463.3791642191530000m, "b9b029d0-01d0-4cfb-9f3d-d555cbc529f5", null, null, null, false, null, "Della", "Douglas", false, null, "Della_Douglas", null, null, "AQAAAAEAACcQAAAAEAJosi7IrjD0iMuNR81kG91wDzNZFvEOatYd8K7QEAJIUN8jLe4m+YThWJiDVXcFcA==", null, false, null, null, 2, false, null },
                    { new Guid("a6fc0423-6291-4866-8d02-6faea1986c4e"), 0, new DateTime(1988, 2, 23, 12, 17, 18, 750, DateTimeKind.Local).AddTicks(2033), 553.798118948930000m, "1c59eb82-e096-45f2-a287-64f6f450314c", null, null, null, false, "Jackie", "Jackie", "Tromp", false, null, "Jackie_Tromp", null, null, "AQAAAAEAACcQAAAAEJvqqoAWMQ8cbjxHATZIbSVlm1BL4ijxP/u8yyLX5E4YVjYcqK3AKuNgI3/1hYt73A==", null, false, null, null, 2, false, null },
                    { new Guid("a7a63c10-9b55-47c6-9d56-8793ee29aafd"), 0, new DateTime(1978, 1, 14, 4, 41, 3, 992, DateTimeKind.Local).AddTicks(5063), 160.9189697195820000m, "56328a6e-0476-4ab3-8d4c-b6489a9f13a4", null, null, null, false, null, "Frederick", "King", false, null, "Frederick_King16", null, null, "AQAAAAEAACcQAAAAEPTcLDkNTQCdsK6x8SZ6z+mheEJaCSEWGoJs3a8y31BOBL07xYuV+OOK25QBI4QNCQ==", null, false, null, null, 0, false, null },
                    { new Guid("a8a8fdd8-4ded-4cee-9b8c-87f2285d7eab"), 0, new DateTime(2004, 11, 11, 3, 40, 3, 723, DateTimeKind.Local).AddTicks(3166), 619.7775110819180000m, "2de3c238-65f6-422c-b58d-8105abfaeae2", null, null, null, false, null, "Tiffany", "Keeling", false, null, "Tiffany_Keeling81", null, null, "AQAAAAEAACcQAAAAEO24e0ausJIG2PA4MbzPamSE/qFbjFwzW8OpfG945Rv4rb1HErpI/jKDWPyMAxEGsg==", null, false, null, null, 2, false, null },
                    { new Guid("aa053e12-232a-4d5d-8b1f-0803fd8b7767"), 0, new DateTime(1988, 3, 24, 17, 8, 52, 189, DateTimeKind.Local).AddTicks(5808), 482.5654378722480000m, "c467d15e-5f3b-4aed-9f7e-8314b4f36197", null, null, null, false, "Fannie", "Fannie", "Wiza", false, null, "Fannie.Wiza35", null, null, "AQAAAAEAACcQAAAAEKS5+Eh0GYt9nCidJuRzIioO1AV9Eg4qBew6cdJcjlXzd1D1fs/qsJqVgwqsLvLW4w==", null, false, null, null, 0, false, null },
                    { new Guid("aa1380ad-62cc-4108-817a-4ac56a2c382d"), 0, null, 301.7644692293790000m, "ebe9727c-d16e-4200-a145-2f50ef2604ce", null, null, null, false, "Cory", "Cory", "O'Connell", false, null, "Cory.OConnell14", null, null, "AQAAAAEAACcQAAAAEB1Ft71hTW0xoFJKtC/3ATXElVEGKin9WfTQv9klGwWB0c7YeH9NLei5m3JTRxcnbA==", null, false, null, null, 1, false, null },
                    { new Guid("abf3ceb3-3421-4454-9686-7b4c13cd1fbf"), 0, null, 91.58304544981820000m, "83a82d71-f932-4ea4-9df0-9728a8efc0bd", null, null, null, false, "Angelica", "Angelica", "Gutkowski", false, null, "Angelica90", null, null, "AQAAAAEAACcQAAAAENCWGQ7OmT8pAUX05pG2yoCYE05kn1gLeIcY7J7Mr7bQuIEIXbv8mHaOO3LI2GCD8w==", null, false, null, null, 0, false, null },
                    { new Guid("abff8b44-2e47-47cd-8158-cb029242cf8c"), 0, new DateTime(1969, 8, 9, 18, 35, 45, 725, DateTimeKind.Local).AddTicks(5191), 246.3831074427820000m, "1035b2d2-6603-4cd0-b048-8c860486582d", null, null, null, false, "Elijah", "Elijah", "Kreiger", false, null, "Elijah.Kreiger68", null, null, "AQAAAAEAACcQAAAAEIL/6e32VCDHvrPKpW1JAJorzCSAB/AlzI71G9aSNq7PK2ZEfbh22/g9C+WnJVUwig==", null, false, null, null, 1, false, null },
                    { new Guid("ac2d4745-386c-4c13-a217-d9e2d9b842df"), 0, new DateTime(1967, 1, 29, 19, 48, 55, 506, DateTimeKind.Local).AddTicks(9735), 223.2628177713860000m, "3114da2d-229b-40f5-b20b-4768e521dd5f", null, null, null, false, "Josh", "Josh", "Schuster", false, null, "Josh17", null, null, "AQAAAAEAACcQAAAAEKtKNHkcChVhq0WviAM2gAsfBVvaQobhQkseTXniCJ61DbuCGCQo3i6bShwSjkxL7A==", null, false, null, null, 2, false, null },
                    { new Guid("ad53394d-1d27-416a-92bf-5074f6fa4fc4"), 0, null, 651.2458871191460000m, "ba06483b-8f0d-4690-8bc7-fa558480451c", null, null, null, false, null, "Ginger", "Ernser", false, null, "Ginger59", null, null, "AQAAAAEAACcQAAAAEP8Dx22oT4XFNHvUMFAaztH43Mfsnjd/GBsURkyJGnV2qZFvRebg4+LrBErsWbNUQg==", null, false, null, null, 0, false, null },
                    { new Guid("aee768a4-2b67-47da-a692-ab2b1cd95c27"), 0, new DateTime(1981, 1, 16, 21, 1, 18, 734, DateTimeKind.Local).AddTicks(9965), 226.8114507130270000m, "23e8923e-6b07-47a3-b020-aa3a4e760244", null, null, null, false, "Josh", "Josh", "Emmerich", false, null, "Josh.Emmerich55", null, null, "AQAAAAEAACcQAAAAECCUtyBRrhrlDGh12QYYh7AsY10NzNpvoyt8YbXhn0u06LpJDuT6XlxSY+rua2yhFQ==", null, false, null, null, 0, false, null },
                    { new Guid("b070b87c-5a28-4f27-8f54-9238dfbe5c79"), 0, new DateTime(1984, 5, 10, 21, 40, 48, 344, DateTimeKind.Local).AddTicks(3868), 733.7743732267540000m, "a80a0078-f550-4fed-8771-64fbc34675ce", null, null, null, false, null, "Calvin", "Lehner", false, null, "Calvin45", null, null, "AQAAAAEAACcQAAAAELIthLow5dBK1cYLIY6tg+ZuiBkuEy1OJ1+F28cZbPWWRzZeih+9lKthktqLnddDbw==", null, false, null, null, 0, false, null },
                    { new Guid("b2a11489-a556-462e-9631-1108d9049fcc"), 0, new DateTime(1994, 6, 27, 14, 31, 5, 981, DateTimeKind.Local).AddTicks(6731), 646.7338695220030000m, "77815118-aa0b-477a-be8a-cf3cd6b341fe", null, null, null, false, null, "Misty", "Bergnaum", false, null, "Misty.Bergnaum", null, null, "AQAAAAEAACcQAAAAELbjF4LdQKYn/WP80o7JfYfYaBlcn9KwaVA7/P2GvgyRMK5GgwxleyaswTqYwh5qDQ==", null, false, null, null, 2, false, null },
                    { new Guid("b3997a22-bce6-473b-9a56-6baca1b5ece7"), 0, new DateTime(1957, 8, 21, 2, 41, 17, 602, DateTimeKind.Local).AddTicks(5357), 18.61410153673220000m, "c4a80104-44dd-4f45-bc2f-8516c0b70331", null, null, null, false, null, "Josh", "Kirlin", false, null, "Josh83", null, null, "AQAAAAEAACcQAAAAEBpL4OqLn8ByW1lf7Po3SDZrqpVQjOwOgtXd3+/jcQA3KG5pDKVpl9NuuhNf4ctvpg==", null, false, null, null, 0, false, null },
                    { new Guid("b44b2dc0-6e21-4d7d-a788-6c4e66d96402"), 0, null, 104.0288160807360000m, "74e975a1-33f0-4079-b9d4-5f1e547f21d5", null, null, null, false, "Clark", "Clark", "Rogahn", false, null, "Clark5", null, null, "AQAAAAEAACcQAAAAEA3qcAxEtetvIWixVGW7oIMIulD4YHnY8yT3N20GPzN8r2st5EBpMTHzAd1BmzDW7Q==", null, false, null, null, 2, false, null },
                    { new Guid("b4e4db54-4f23-4365-96a9-cb8bd3cdaecf"), 0, null, 161.4324508109080000m, "83bef807-d82a-430e-9f88-9bf7dcf95aa7", null, null, null, false, null, "Terence", "Bartoletti", false, null, "Terence6", null, null, "AQAAAAEAACcQAAAAEGsytAagsracWDca4x9FKbwKrHnEUCOPzPgN4uG6V5SoEGo4FHTHX/mwQNfWz96H+w==", null, false, null, null, 2, false, null },
                    { new Guid("b50df756-e4ca-4115-a962-e283f6b8d317"), 0, new DateTime(1951, 6, 5, 5, 29, 55, 469, DateTimeKind.Local).AddTicks(5176), 343.6060866950060000m, "0795486b-caf9-485b-aadd-2bea53476e18", null, null, null, false, null, "Casey", "Kuhlman", false, null, "Casey_Kuhlman", null, null, "AQAAAAEAACcQAAAAEJgdRU3Spse93n62L8S3HmUxOJ+zbhioYQFEptzqwqcbtnTCFMOUPoZvjCM5/uD/Jg==", null, false, null, null, 1, false, null },
                    { new Guid("b5fe6c30-5f2d-462b-9dd2-bc5388f99ce5"), 0, new DateTime(1952, 9, 20, 13, 23, 39, 521, DateTimeKind.Local).AddTicks(1955), 680.7525343708010000m, "d6582a51-903a-493f-a39b-35fb1be1e8ab", null, null, null, false, null, "Ramon", "Moore", false, null, "Ramon.Moore", null, null, "AQAAAAEAACcQAAAAEF0TaHXtxbqTNUzHntKcyqwnienYrPoPOE/xBQVZID2PBQ4bvJduKZQUN63/4IMXUw==", null, false, null, null, 1, false, null },
                    { new Guid("b67eec58-0f42-4a35-a871-09c1ddaddd4b"), 0, new DateTime(2003, 6, 18, 14, 52, 28, 415, DateTimeKind.Local).AddTicks(7460), 353.7435377069830000m, "7bdbc28b-0c5c-42fa-b7ef-95d4b970022f", null, null, null, false, null, "Marc", "Kuvalis", false, null, "Marc68", null, null, "AQAAAAEAACcQAAAAECZgtbNxdKv6WjKcFmaLI6VMkvjpfuHINs6QxsW3TJ28RzuyfNFhYeFrnaMn0MiXAQ==", null, false, null, null, 2, false, null },
                    { new Guid("b71f69da-e20d-4b25-b2fb-00d5eb1c9002"), 0, new DateTime(1986, 10, 1, 2, 39, 21, 707, DateTimeKind.Local).AddTicks(3834), 764.4802956163250000m, "3f37bdec-81bc-490f-8d8b-d66d5ad59747", null, null, null, false, "Jeannette", "Jeannette", "Cremin", false, null, "Jeannette_Cremin28", null, null, "AQAAAAEAACcQAAAAEL/bIjcAY7L4YPmFM2WGbuL6zmMPlIi/MAsqTkRfPt5ycOrnOyuN0swOsanFp273Rw==", null, false, null, null, 2, false, null },
                    { new Guid("b944ae23-efab-4fcb-bda0-6be21e2add96"), 0, null, 431.897399384180000m, "7a05952d-e745-49d5-a8c9-ffdf6fc54bdb", null, null, null, false, "Alma", "Alma", "Little", false, null, "Alma.Little", null, null, "AQAAAAEAACcQAAAAEM+W0VusfbPqKhaVPM3AG8y+SAErXSbXzD2KRnlS5B8RiAes+lAwgFPhZk/Kaife2A==", null, false, null, null, 2, false, null },
                    { new Guid("b9974b20-5b3f-4445-a6d7-c4352b53a64c"), 0, new DateTime(1978, 4, 2, 14, 47, 59, 828, DateTimeKind.Local).AddTicks(309), 934.127675165530000m, "06d861c4-e93f-4814-97d2-75945f2f70aa", null, null, null, false, "Elbert", "Elbert", "Ondricka", false, null, "Elbert55", null, null, "AQAAAAEAACcQAAAAEH9nWtvNIoNEISSxPwPy1y6EPtVZkIClIOoepk0FCh7UvkrtEtV/gOXAuEESn9gwgg==", null, false, null, null, 1, false, null },
                    { new Guid("bcb5583b-3b55-4ea8-b016-f74baf89e99a"), 0, new DateTime(1966, 7, 4, 16, 14, 0, 847, DateTimeKind.Local).AddTicks(4423), 164.355185422170000m, "0fb7548c-24c7-420a-b54c-602e9f6d1bd1", null, null, null, false, null, "Sheryl", "Baumbach", false, null, "Sheryl_Baumbach", null, null, "AQAAAAEAACcQAAAAENpH2j/9eQ4oFEz4Gya/ZvBtWdJlcjCCS46swml1AYL7CVRd+LvpP9i+ik8apS8tuw==", null, false, null, null, 2, false, null },
                    { new Guid("bd5c667b-2bfc-46c6-814e-7b5c93be8f43"), 0, null, 506.8084809891770000m, "7a84b968-cb7d-46b7-a20d-d1e42ef394fa", null, null, null, false, null, "Lorraine", "Halvorson", false, null, "Lorraine_Halvorson", null, null, "AQAAAAEAACcQAAAAENtSbEkE+qQyl/E72qj/mhFv3S2VF9qQsAdyAq8SLv+nitYW0eGz0tO2R1XAW14eqw==", null, false, null, null, 0, false, null },
                    { new Guid("be18d868-cfef-46af-89ea-769a3c24c7da"), 0, null, 431.3076883592310000m, "6bc25f36-4613-422d-8afd-31ebd3bc29c3", null, null, null, false, null, "Olga", "Hackett", false, null, "Olga_Hackett", null, null, "AQAAAAEAACcQAAAAECw8sMu+pkOzbWizw0mUl9timEezMhxpyfwDm443C6kTK9qaH/mXCa2O8BQS0D590A==", null, false, null, null, 1, false, null },
                    { new Guid("c0ce8022-4a58-4c92-9e84-7f2ac0c9caa5"), 0, new DateTime(1953, 1, 26, 5, 16, 17, 273, DateTimeKind.Local).AddTicks(6853), 596.7003977991840000m, "af3f64d0-5db2-45b7-b579-9523c03dd74a", null, null, null, false, "Patsy", "Patsy", "Kutch", false, null, "Patsy_Kutch", null, null, "AQAAAAEAACcQAAAAEGTTw5mI31lxLNC2Q5G7sLDLKDE5lrLskmeVSnV6gjOV4v8SC+UGRfalB55zsyKAHA==", null, false, null, null, 2, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "Email", "EmailConfirmed", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("c1dedd78-34a2-4542-a585-a6ba740f5856"), 0, null, 139.7738660145630000m, "cb1c4744-71ea-413f-834e-c58111f982a4", null, null, null, false, null, "Stanley", "Kling", false, null, "Stanley.Kling", null, null, "AQAAAAEAACcQAAAAEIfpF67eja/XUgWxCeKVsoirpHo1N7hkuATAjXQYJzRGSkrextsBge30JNHwMg1cUg==", null, false, null, null, 0, false, null },
                    { new Guid("c311c4ad-bbcf-418b-8259-eec5ae72eb71"), 0, new DateTime(1970, 1, 19, 10, 36, 55, 741, DateTimeKind.Local).AddTicks(338), 445.7430852985820000m, "bbefdac6-3d41-4a08-96c5-004c7217cb05", null, null, null, false, "Pedro", "Pedro", "Smitham", false, null, "Pedro_Smitham", null, null, "AQAAAAEAACcQAAAAENirtb7XAJVBLdodi53YOBnx6wZG0YmP7LxW4KMenrV2I37YjesyB5d/TlAi3a14sg==", null, false, null, null, 2, false, null },
                    { new Guid("c3a4c71d-a9ab-475e-9d5b-425a5d31fb48"), 0, null, 609.4075848363460000m, "c36b8989-c41f-459d-8cb2-740efa3f92ee", null, null, null, false, null, "Sheila", "Keebler", false, null, "Sheila_Keebler7", null, null, "AQAAAAEAACcQAAAAEPy5h1Szb4PmjbExxp4gp18wIpTj8hd38SjZz5hyxZUXEQb7E4mlQ/wBWHGXQFtKeA==", null, false, null, null, 1, false, null },
                    { new Guid("c3f40de8-9c2b-4f97-b99a-a3d5f6431b27"), 0, new DateTime(1951, 3, 22, 3, 37, 30, 689, DateTimeKind.Local).AddTicks(1440), 327.882881322660000m, "b0372251-f335-456a-905d-827097c206da", null, null, null, false, "Lynette", "Lynette", "Williamson", false, null, "Lynette.Williamson28", null, null, "AQAAAAEAACcQAAAAEGoFX3y19oxhsomJkiR+xDICjSZornQjd+IiFlS19OX5WNCX8mmHWjvokGte8hzYaA==", null, false, null, null, 2, false, null },
                    { new Guid("c3f74963-e8a7-4598-bde6-0b7eb8dc16d8"), 0, new DateTime(1932, 4, 22, 14, 58, 40, 500, DateTimeKind.Local).AddTicks(6276), 337.5685858550950000m, "b0b0ab1c-43dc-49b1-90d2-d2b987946414", null, null, null, false, "Lonnie", "Lonnie", "Muller", false, null, "Lonnie30", null, null, "AQAAAAEAACcQAAAAEEyz/FQCH4tscgDZ1fxCWS6a4hRUWKBPsjQw8UAO/ZHEmvKTy8DmdhvSNnyGJ3w4QA==", null, false, null, null, 2, false, null },
                    { new Guid("c431ef46-de70-4dba-a2b4-061b2a219ebc"), 0, null, 561.8551045435210000m, "cf3a2ba5-f01c-47f8-8240-0f8b5a575963", null, null, null, false, null, "Clinton", "Koss", false, null, "Clinton26", null, null, "AQAAAAEAACcQAAAAEKkiBGy0PjTF7J5ByEUAOhoX/S1+Plo3PILaUW5FVg3A2CZdCexDGVEfjnVZaF7DEg==", null, false, null, null, 1, false, null },
                    { new Guid("c4c17769-48f5-471b-ac8e-87a2c17573b4"), 0, null, 20.87234174341990000m, "80802413-2409-450e-ad57-73ccec5d06e5", null, null, null, false, null, "Ian", "Von", false, null, "Ian_Von33", null, null, "AQAAAAEAACcQAAAAEF/VOsgvCxZx9wXwoIFxYzVFZ5pCKgbIdiSrPifbwtTKA8Vcc4pzd71EZiqmHwJVHw==", null, false, null, null, 0, false, null },
                    { new Guid("c50f147c-0804-4f38-a70a-7b8d4109234d"), 0, null, 404.1079282011590000m, "735e6afe-88e9-4dc6-9cd7-536d44406231", null, null, null, false, "Marcella", "Marcella", "Cummings", false, null, "Marcella_Cummings39", null, null, "AQAAAAEAACcQAAAAELUGqG23nU+NY0+wA7dZgw4r7vP0VGGMzGVPC7AhfOdC+sWAv+i03RDk5nbsqR8hjw==", null, false, null, null, 1, false, null },
                    { new Guid("c561cc5e-190d-4a91-8ea9-d03583fa3f86"), 0, new DateTime(1940, 3, 17, 9, 18, 18, 444, DateTimeKind.Local).AddTicks(2656), 551.4336267589720000m, "aaf94788-621a-4734-b58c-d6a33e7a1524", null, null, null, false, null, "Angelo", "Swaniawski", false, null, "Angelo_Swaniawski59", null, null, "AQAAAAEAACcQAAAAEN1J5SqZ9/xBBKhERD3hYHGidqJeuvS6XwcmeouqvcpAtn1JIaKJ10xJYZU9FQjFrw==", null, false, null, null, 0, false, null },
                    { new Guid("c60620ff-d62e-4585-9510-ed612aa89dcb"), 0, new DateTime(2008, 2, 16, 14, 50, 27, 674, DateTimeKind.Local).AddTicks(2791), 848.2547777987130000m, "48ada624-e486-4217-ae1c-a8c2335b0c23", null, null, null, false, "Derek", "Derek", "Farrell", false, null, "Derek_Farrell23", null, null, "AQAAAAEAACcQAAAAENCU0Ro+3vYVG+BoohlwnSa1mPxFCI7UFs+QrPq+YWrWkcmSF7bsIaX5ckHFD5y4KQ==", null, false, null, null, 1, false, null },
                    { new Guid("c798d3b3-ea5a-4b3b-a69b-7022aa64fe86"), 0, new DateTime(1950, 2, 21, 11, 57, 38, 581, DateTimeKind.Local).AddTicks(9656), 867.6693126089860000m, "8d65bf3a-5757-4df1-bed7-b30e31ea6aff", null, null, null, false, "Cory", "Cory", "Emmerich", false, null, "Cory_Emmerich", null, null, "AQAAAAEAACcQAAAAEF55omXYXMdftDcKrtiSsCdfm0bbl+7cR88A/qZG9zc6nTYUTyH4kopg5UDjYUBsaw==", null, false, null, null, 1, false, null },
                    { new Guid("c8db4c48-87fc-43bc-b9ef-e88e6764800d"), 0, null, 999.3570492005820000m, "b731b81a-db48-4797-ae4f-6a75981f9846", null, null, null, false, null, "Andre", "Treutel", false, null, "Andre98", null, null, "AQAAAAEAACcQAAAAEN2p8OFlqeCkaxDAOyj5MmL5C6DnGdpkiIryp1AGaIG119y9cbXwGTwJRPEic4fU2g==", null, false, null, null, 2, false, null },
                    { new Guid("c9de1952-448f-4a77-a4fa-b78a3751957a"), 0, new DateTime(1952, 7, 24, 3, 4, 7, 336, DateTimeKind.Local).AddTicks(3428), 921.5858224546760000m, "806e4a31-60dc-4e80-bf58-ca0c462e9375", null, null, null, false, null, "Casey", "Bogan", false, null, "Casey.Bogan", null, null, "AQAAAAEAACcQAAAAENwwB7WlSd4FPygOJDdV9C9MVmJXOFvmiJcjHvF4QzaMXGqQ2ewr/0HIJ5t6gWA8XA==", null, false, null, null, 0, false, null },
                    { new Guid("ca7879c0-456f-4a95-94ad-0a58b61bfc27"), 0, new DateTime(1951, 8, 3, 13, 17, 20, 98, DateTimeKind.Local).AddTicks(435), 942.0537169554620000m, "0c79fb31-922b-4c91-bcbc-82bec798aa25", null, null, null, false, null, "Harry", "Morar", false, null, "Harry.Morar", null, null, "AQAAAAEAACcQAAAAEJn4Gw7bPG6L1Bv9NVT4t3cYVmO0yGRT6APIxLyvy24W7YTEEC030dEuS5nXk7Pleg==", null, false, null, null, 0, false, null },
                    { new Guid("ca9a7100-5d5c-406e-8028-d065cd21c772"), 0, null, 1.798777546987540000m, "fb31e107-02a5-44f4-a066-a8b7e8fee36e", null, null, null, false, null, "Marcus", "Homenick", false, null, "Marcus_Homenick99", null, null, "AQAAAAEAACcQAAAAELaerCf/gJnRyExsMAYUzMcjK83wRUSvTL0NJJdHZR4LGQ1I9cW5+gtngLje1gZPGg==", null, false, null, null, 0, false, null },
                    { new Guid("cb8696d4-d2d5-40c3-b74f-38aafecd34f8"), 0, new DateTime(1992, 11, 8, 13, 55, 5, 488, DateTimeKind.Local).AddTicks(5539), 617.2389278877430000m, "df263285-b4cb-41c8-968c-b14ffcc2e97a", null, null, null, false, "Christina", "Christina", "Grady", false, null, "Christina_Grady24", null, null, "AQAAAAEAACcQAAAAEFbKPcFlP7UfTYRjLVguQ61BwifeM85SZRSYaKV5yQSHZMPSaDE3Z8h//vir9VQzxA==", null, false, null, null, 2, false, null },
                    { new Guid("cb9544f8-58da-451a-a24e-9ef9b8265d20"), 0, new DateTime(1992, 7, 25, 0, 11, 41, 380, DateTimeKind.Local).AddTicks(5519), 520.8245003486690000m, "f5ae7a66-177f-4f99-a639-049454388b16", null, null, null, false, null, "Glen", "Homenick", false, null, "Glen1", null, null, "AQAAAAEAACcQAAAAEHll1L7wUT0F0xesZjyqgbkR8VjnntsjOgugOmIPRy8+yl8Sobf3c4f69Hak36QPIA==", null, false, null, null, 2, false, null },
                    { new Guid("cc549d3d-c127-48fe-9320-69c0367cf0ef"), 0, new DateTime(1940, 10, 10, 6, 35, 3, 273, DateTimeKind.Local).AddTicks(7794), 436.7536148072840000m, "131262f1-bb5f-4825-b2bd-d8f31c0a8269", null, null, null, false, null, "Sidney", "Reichel", false, null, "Sidney_Reichel", null, null, "AQAAAAEAACcQAAAAEBqEozKcO1h0VuWq4yqz2HAIf5LnIjr8y/5cogtTA9SM4v7TSnNe4rM9ch/ZiIaB0A==", null, false, null, null, 2, false, null },
                    { new Guid("cd3bba51-ecbd-472a-a962-7f603574b446"), 0, null, 194.2598694192580000m, "bc57c0f0-4804-4a2d-867d-7a7839a28d27", null, null, null, false, "Lester", "Lester", "Jacobson", false, null, "Lester.Jacobson19", null, null, "AQAAAAEAACcQAAAAEKyEJwEtrK1bywNpdAk1byNN6yGoLAox+iT2TE2q1QXOMTa3KwOD4XKT5v2d1Wxm5Q==", null, false, null, null, 1, false, null },
                    { new Guid("ce4c448e-35a5-4243-aa12-b967d2b3da6f"), 0, new DateTime(2002, 9, 22, 12, 34, 17, 803, DateTimeKind.Local).AddTicks(8242), 884.6116920704860000m, "ade5530a-4627-4150-b22d-fabfe601cbf9", null, null, null, false, null, "Simon", "Dietrich", false, null, "Simon.Dietrich", null, null, "AQAAAAEAACcQAAAAEPcX8qjVKumtL27bAAfd6N+5N9laWGqgeKNbr6+itC58PxNGOjxBVX30NKDn/yISOw==", null, false, null, null, 0, false, null },
                    { new Guid("cefdf373-98f4-432b-bfc7-baaf121c554a"), 0, new DateTime(1946, 5, 7, 19, 5, 35, 643, DateTimeKind.Local).AddTicks(743), 487.3702756841380000m, "123b1f65-278d-4612-bb8b-bbf275a30998", null, null, null, false, "Alexander", "Alexander", "Kessler", false, null, "Alexander_Kessler", null, null, "AQAAAAEAACcQAAAAEE0DyUGOsbAWcMxzhZe3kIVO8XDLN4/6avLu3TnVnp/nfAiOAkBxPcZMlcFkLEmK5w==", null, false, null, null, 2, false, null },
                    { new Guid("cf6839a1-51b8-4ec5-bfec-3cbe48c20160"), 0, null, 469.7778086476090000m, "1d127d97-a58a-432a-a443-1a6320331316", null, null, null, false, "Adrian", "Adrian", "Davis", false, null, "Adrian_Davis35", null, null, "AQAAAAEAACcQAAAAENnnsIiL0IpMyhia8LTaJf++nFyPY9haD8YqfGW/N+7ygwLdF9AAETzmgr6wpJTdFg==", null, false, null, null, 0, false, null },
                    { new Guid("cfc77b46-5660-4e53-bd9c-0ef309097b43"), 0, new DateTime(1941, 7, 4, 19, 53, 19, 271, DateTimeKind.Local).AddTicks(3017), 157.3463672634340000m, "7f2dc509-0301-4007-b76a-46c9f8df2219", null, null, null, false, "James", "James", "Miller", false, null, "James.Miller", null, null, "AQAAAAEAACcQAAAAENOylvXqF8CeRYHJb1GIYx7JPRds5PgXxWBYoQEa/OeV9oTBgQCa3DAW0bqzO6n6fQ==", null, false, null, null, 2, false, null },
                    { new Guid("d0627291-bbf2-408e-bc02-9ba09faa06bd"), 0, new DateTime(1972, 11, 3, 6, 38, 17, 424, DateTimeKind.Local).AddTicks(218), 338.846192386280000m, "4602cfd2-0e5b-4a7f-bffe-6cc41f11ca92", null, null, null, false, "Ryan", "Ryan", "Keeling", false, null, "Ryan_Keeling33", null, null, "AQAAAAEAACcQAAAAEFOVCwdc4NTBBnVVfC580H0Mb4HosEW+nyOrXdSafay4Z6ZWkG/wcnT0tQN9z8+bxw==", null, false, null, null, 2, false, null },
                    { new Guid("d08dab84-c369-4193-b4fb-bbd252c59cc5"), 0, null, 515.294245284080000m, "a31d9543-a1e7-4b07-996b-b5cac15b2f59", null, null, null, false, null, "Ramiro", "Pagac", false, null, "Ramiro14", null, null, "AQAAAAEAACcQAAAAELHFBZIK2FnshehLA/MqWA3+uU6fOG6JCLV4iRZDqIX8oFfg39Uon1Q9LusJs5D5VQ==", null, false, null, null, 0, false, null },
                    { new Guid("d0fc0768-b3a0-4f82-affc-e355dc4101f4"), 0, new DateTime(1954, 7, 14, 6, 34, 20, 197, DateTimeKind.Local).AddTicks(3021), 634.3705045845570000m, "ed8fdc3d-9afc-4849-888f-e0930518f182", null, null, null, false, null, "Fredrick", "Gislason", false, null, "Fredrick61", null, null, "AQAAAAEAACcQAAAAEDjgh8ARC7Msk0YJNUjcoZRRSS6h+5uaIDaKkT78ZS9yaXoFzLcX+GV87AYm7mig5A==", null, false, null, null, 1, false, null },
                    { new Guid("d184b2bf-159f-4b4e-83e0-4f0bb6184d14"), 0, new DateTime(1960, 11, 19, 10, 29, 7, 271, DateTimeKind.Local).AddTicks(3990), 240.1672885970510000m, "be920464-ba0f-4e44-b89d-baad59ca6225", null, null, null, false, "Dale", "Dale", "Kohler", false, null, "Dale4", null, null, "AQAAAAEAACcQAAAAEGolTCbbiTw5Pk1eL/gR1ncYI6cAP6S2aJJCjYLVaBb2r7Jk4VIHMy5NDsNqPuow9A==", null, false, null, null, 0, false, null },
                    { new Guid("d1fdc728-523b-49bf-b2d8-eee9a8bb93d1"), 0, null, 375.8764199296290000m, "c8a57030-6f74-42f1-a0ef-3497512c2666", null, null, null, false, "Henrietta", "Henrietta", "Spinka", false, null, "Henrietta0", null, null, "AQAAAAEAACcQAAAAEChkGQyOssn/9cjZfPDDH2qfz1BHSuEYqiEhfTxDEVdyY3u2ihwE0IESASW684sZAg==", null, false, null, null, 0, false, null },
                    { new Guid("d368ec62-a4a6-47b3-a955-fb176a32fe20"), 0, null, 971.4348084160520000m, "2c3e796d-2c11-410e-9b90-7ed9195e30b2", null, null, null, false, null, "Jermaine", "Wehner", false, null, "Jermaine.Wehner", null, null, "AQAAAAEAACcQAAAAEIlSQgwkiLw89YERCE5rU9OmZj5W8PBl7gi0wd7w/5McVBqLKEHI1LDk7fcFyj9eNA==", null, false, null, null, 2, false, null },
                    { new Guid("d4409d83-a792-488f-bea4-9e1b42950fc9"), 0, new DateTime(1943, 11, 18, 17, 24, 48, 784, DateTimeKind.Local).AddTicks(9341), 613.3175478926540000m, "38d243ae-7b71-4cf8-893e-7e0064ce5cf4", null, null, null, false, null, "Noel", "Grimes", false, null, "Noel.Grimes", null, null, "AQAAAAEAACcQAAAAEIdM64+lcNpGr6oI9UdikgUwWJZa7jY0dLXeuzsb8UQLgAHEQdK+85FZCPXAGjR9+w==", null, false, null, null, 1, false, null },
                    { new Guid("d5f398ce-f08b-4d20-af17-603089eb45ee"), 0, null, 525.6942866809210000m, "1e86354b-9cb6-4a7c-a53a-d973cc0a488c", null, null, null, false, "Rose", "Rose", "Waelchi", false, null, "Rose_Waelchi", null, null, "AQAAAAEAACcQAAAAEGoQPJuU2fBkmx+XiuxZ8YeEjSS/0bewBPq8hDiMTOqK2dV/yvgjGsDBJA53ARNgzg==", null, false, null, null, 2, false, null },
                    { new Guid("d666c5aa-5c03-4391-8629-5cc681422ca2"), 0, null, 304.7871243116260000m, "1a4717b2-2e3b-4bc5-9659-11e7be06f2a5", null, null, null, false, "Harry", "Harry", "Windler", false, null, "Harry.Windler82", null, null, "AQAAAAEAACcQAAAAEKp66efYv7I1xhBc1QB64uAjGCuyv36q6Ln6Yfvg7mURIgKhaUn92EyQizqKoruCFg==", null, false, null, null, 1, false, null },
                    { new Guid("d8361619-ae4f-4db1-9eb9-291e4814a381"), 0, new DateTime(1934, 8, 15, 22, 2, 44, 659, DateTimeKind.Local).AddTicks(5522), 749.71067815860000m, "156f4ab8-94e1-45b3-bc2b-7975034dfb26", null, null, null, false, "Leslie", "Leslie", "Kreiger", false, null, "Leslie4", null, null, "AQAAAAEAACcQAAAAEL44vHyMj6G/u5hW6DEwZI9jvfAzrIFF/Py8nqsHvWsY0NbKJpoI5kxAOK667WMx6A==", null, false, null, null, 0, false, null },
                    { new Guid("d8dd96ce-4557-4993-959c-45a29c967d51"), 0, null, 722.8112925835420000m, "4fc9de9b-2ba6-4b23-8326-0bb621230e72", null, null, null, false, null, "Willis", "Schulist", false, null, "Willis78", null, null, "AQAAAAEAACcQAAAAEAwpFGbtiXEx82RXflhjTUqwgTEBT8bV9DxVE1RJ0wOR9WcKP70xlUtj00BvZJOznw==", null, false, null, null, 2, false, null },
                    { new Guid("d9295c19-5c11-40bb-ba7c-c1b368114ac0"), 0, new DateTime(1982, 2, 26, 19, 7, 41, 891, DateTimeKind.Local).AddTicks(543), 745.1149179710520000m, "68bf2506-3157-439d-94a5-981fbdc25c55", null, null, null, false, null, "Vera", "Mills", false, null, "Vera.Mills", null, null, "AQAAAAEAACcQAAAAECA020E5HI/8tbuycobv81Oh6RaLOZbNtjEfff16W1Wyjk81g0C4dk6I2lcjQD+6DA==", null, false, null, null, 2, false, null },
                    { new Guid("d9fc54cb-e30e-4a48-b749-08ff99fcff26"), 0, new DateTime(1969, 10, 5, 8, 4, 29, 54, DateTimeKind.Local).AddTicks(3346), 165.8247218915850000m, "54b5b66e-7335-42a9-aad8-341129be91dc", null, null, null, false, null, "Otis", "Wilderman", false, null, "Otis_Wilderman", null, null, "AQAAAAEAACcQAAAAEP7UbEZftieYpDh+0fv53cCGpjLjjJtDumc+ZhGna0vETbq4Pm1SeenxEoLh7SuPhA==", null, false, null, null, 2, false, null },
                    { new Guid("da687a7e-bca5-449f-ad43-32e0ac00fe15"), 0, new DateTime(1989, 7, 23, 2, 53, 45, 24, DateTimeKind.Local).AddTicks(3124), 787.7354582047650000m, "6b9b2f6c-113e-46c9-8f07-c8cf5a6d0a99", null, null, null, false, null, "Kathy", "Strosin", false, null, "Kathy31", null, null, "AQAAAAEAACcQAAAAEPRXA0eOj5VBp70aAiNNh3Ji9O8/vJ9DU+lW2Y4267uoVDWJ4fRrxqcFHaYKEMAd0w==", null, false, null, null, 0, false, null },
                    { new Guid("db79e848-cfae-4c0f-8859-e5d6af4a311c"), 0, null, 172.9701546896740000m, "8c597cc2-316b-4287-8f9d-523be7cfdbf1", null, null, null, false, null, "Linda", "Hirthe", false, null, "Linda.Hirthe76", null, null, "AQAAAAEAACcQAAAAEFe4BRRP6vLJR84oA5tmq0DNoh6oQN0Fjrnl5keK5AJyGVozjPjfaeoDuaWngtnHSA==", null, false, null, null, 1, false, null },
                    { new Guid("dc04df94-1448-4899-bec4-692b13ea2748"), 0, new DateTime(1946, 7, 7, 17, 45, 57, 529, DateTimeKind.Local).AddTicks(5172), 501.5775638609470000m, "e672f123-b443-43b8-9707-1e8408f174e1", null, null, null, false, null, "Silvia", "Fritsch", false, null, "Silvia.Fritsch", null, null, "AQAAAAEAACcQAAAAEKntcQT7Ns11QkeE8GGKYQgbyIBUwRd/aqusgYDGKGYvFVxjyD3i3db95YRVzdX5DA==", null, false, null, null, 2, false, null },
                    { new Guid("dd2a73f4-0d43-45df-8aa0-196122e00fc2"), 0, null, 853.790416412060000m, "ace35cd3-b3a5-41b9-b630-feafe8ccda04", null, null, null, false, "Jamie", "Jamie", "Von", false, null, "Jamie.Von48", null, null, "AQAAAAEAACcQAAAAEDAL1Ys9FQH2vAYSnYncPBQgB26U+vz03IwwREeF5dH4J/mkQHjOLBnuXyJT3zia1w==", null, false, null, null, 2, false, null },
                    { new Guid("dee746db-2712-4366-98c6-517b826fd421"), 0, null, 434.870998012140000m, "7e5e9946-a1fa-49cc-b61d-936c9589c1ac", null, null, null, false, null, "Tracey", "Kuhn", false, null, "Tracey17", null, null, "AQAAAAEAACcQAAAAEOh3JAVZlA7CNivJrTybWM5FCbn5VdVq097eFuF+du0Dci5c629tsJqqsaJax5iWpA==", null, false, null, null, 0, false, null },
                    { new Guid("df250436-821d-48ab-9508-ab3df0550e27"), 0, new DateTime(1993, 10, 20, 16, 38, 40, 677, DateTimeKind.Local).AddTicks(3842), 932.9182052864530000m, "914ffd0b-15ef-418b-9783-49437bdcb972", null, null, null, false, null, "Joan", "Metz", false, null, "Joan53", null, null, "AQAAAAEAACcQAAAAEPnM0zz8jA+5diAJ1qk6EURquH26gpQD5JglDJUgCy31noHjVNSrSmTjXikCwiNSfQ==", null, false, null, null, 2, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "Email", "EmailConfirmed", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("dfa0bf0e-13dc-416f-bb54-aaeb47a68545"), 0, new DateTime(1931, 3, 22, 8, 59, 47, 627, DateTimeKind.Local).AddTicks(8108), 229.8677742806110000m, "e41661a4-7457-4c72-92e6-c087691ac05c", null, null, null, false, "Roman", "Roman", "Koch", false, null, "Roman53", null, null, "AQAAAAEAACcQAAAAELC2TUp1dtVhvxe7AYbF2N+qK03jXXth4hDySGawNLjP4/RoEGFDN/sZeCfY629ggw==", null, false, null, null, 0, false, null },
                    { new Guid("dffee49d-d296-4315-aefd-9602dd01358c"), 0, new DateTime(1925, 11, 5, 23, 40, 53, 94, DateTimeKind.Local).AddTicks(2740), 984.3707936489980000m, "81645064-397a-4ce4-97dc-3c681667751f", null, null, null, false, null, "Austin", "Quigley", false, null, "Austin32", null, null, "AQAAAAEAACcQAAAAEEPk7rorM1M1eim08GRFLeqFbuQ1lgyPytNjYjK1fOcXHdz8Bi5KzKWIxGhY0MCLMg==", null, false, null, null, 0, false, null },
                    { new Guid("e1223f43-016e-41f5-b212-ab70a0ac01e2"), 0, null, 715.4931211265760000m, "3254c3a6-b45a-4600-8dc9-0a934c5b6f45", null, null, null, false, "Kristine", "Kristine", "Barton", false, null, "Kristine.Barton81", null, null, "AQAAAAEAACcQAAAAEGV2VYy2WXWBoxEBVzbtPR12QBeib4lwLQ96SAp8Zhxpsp8q5TdMQx9Avza96IKTXg==", null, false, null, null, 1, false, null },
                    { new Guid("e188b38e-8056-446d-96c9-b8979c4fd471"), 0, new DateTime(1997, 10, 12, 4, 2, 10, 745, DateTimeKind.Local).AddTicks(7875), 505.5156746992520000m, "df67b607-1eea-49ef-bbd2-3d6e9fb718e9", null, null, null, false, "Alfred", "Alfred", "Bruen", false, null, "Alfred.Bruen88", null, null, "AQAAAAEAACcQAAAAEAFAv1NcE8dcrK81xUorjxBSG5230d/q8ppVd1X9TnuwUB28zII5MRv+eQb0ny/rRA==", null, false, null, null, 2, false, null },
                    { new Guid("e27f9603-32f8-4066-bf07-4ab692c8350b"), 0, new DateTime(1952, 12, 31, 7, 21, 34, 247, DateTimeKind.Local).AddTicks(5770), 516.5729713282550000m, "b6925848-2015-4d46-9fe5-e9ec259c89fe", null, null, null, false, "Carrie", "Carrie", "Connelly", false, null, "Carrie.Connelly52", null, null, "AQAAAAEAACcQAAAAEFQx/fPYI95YQYnWTrgPr5vdS4d8M0YQylEh8SjKyK0Ceyf5/wLQZ6IK+C7LR1denQ==", null, false, null, null, 2, false, null },
                    { new Guid("e28ae980-81b6-4d5f-8748-b7cb3f0f995d"), 0, new DateTime(1971, 6, 26, 9, 24, 37, 392, DateTimeKind.Local).AddTicks(8986), 396.3507737289430000m, "03931ebb-f76e-4e1b-9014-7532cdc12a47", null, null, null, false, null, "Suzanne", "Lindgren", false, null, "Suzanne10", null, null, "AQAAAAEAACcQAAAAEHp45G/QdQSu/TsCUq6WpwyE6tJ9gRzv0pF02z8NwyJXWYq2jwdEAbrF1q4UBGPTeg==", null, false, null, null, 0, false, null },
                    { new Guid("e2dba597-b132-4b1a-a46f-540ebc581408"), 0, null, 535.6601741224350000m, "94646f9b-a9fa-42b1-b7e0-720089504551", null, null, null, false, "Alberta", "Alberta", "Lemke", false, null, "Alberta98", null, null, "AQAAAAEAACcQAAAAEMbneZ8XMa0KXcbmsFOJxm6QSQeeSs3wh/HaxsTbnBpLVnSONo2VAFsgMiqs3rFVbw==", null, false, null, null, 0, false, null },
                    { new Guid("e44b1f8c-951b-48de-a206-672ce80e3e29"), 0, null, 155.849923488410000m, "17156fba-4ed1-4b13-832e-bd3fd63fb457", null, null, null, false, "Austin", "Austin", "Walter", false, null, "Austin.Walter14", null, null, "AQAAAAEAACcQAAAAED5vdKJvP1vj6V+oeHlqgRpeCjef3E+G/PF5pt196keUO1m4S9laLFnehM+s1MnNLA==", null, false, null, null, 0, false, null },
                    { new Guid("e58d2261-638d-41ed-b5bf-55b3a94546e1"), 0, new DateTime(1985, 2, 27, 19, 47, 49, 427, DateTimeKind.Local).AddTicks(6156), 585.6608946662760000m, "a9324fe7-a415-483f-80ac-63e9730dd5ae", null, null, null, false, "Santos", "Santos", "Lindgren", false, null, "Santos_Lindgren63", null, null, "AQAAAAEAACcQAAAAEAst+OJ7/Fp4DqJ3y/EnZr2AcKmMkGElDwNZ/5xCPz+0a8muFzuKug6lDDo32FBCeQ==", null, false, null, null, 0, false, null },
                    { new Guid("e6b167e1-2f8a-4aa9-b766-dcb40c4c65b7"), 0, null, 364.8016599927240000m, "3bba79f9-53cc-4bc3-b712-5e8a15520751", null, null, null, false, null, "Kimberly", "Kuhn", false, null, "Kimberly.Kuhn", null, null, "AQAAAAEAACcQAAAAEFXcKnVvK3UCTtSPOZ5hq59YJd+pRia1cilhfW7W2pe5MYQQnr8siSi0wLBHoS3NBQ==", null, false, null, null, 0, false, null },
                    { new Guid("e7414a92-a2c0-4cbd-a0ca-3a6c538ac8c6"), 0, new DateTime(1975, 11, 27, 2, 14, 40, 675, DateTimeKind.Local).AddTicks(3653), 568.5137271948060000m, "954db577-0ac4-4e86-aadf-eac8ccaf8361", null, null, null, false, null, "Lori", "Gislason", false, null, "Lori83", null, null, "AQAAAAEAACcQAAAAEMvOtVJGqYR67zDLtSAXBMv6hNC5dJNIlO+f4gMmu/7pbMXcBaKcU8wuBoHsT33BAw==", null, false, null, null, 1, false, null },
                    { new Guid("e807eb16-5caf-4274-9ff7-5027ed83325c"), 0, new DateTime(2007, 9, 8, 5, 5, 55, 6, DateTimeKind.Local).AddTicks(8079), 586.8756048720360000m, "e13461d7-a467-45a7-b7bc-992ecdefbab5", null, null, null, false, "Gretchen", "Gretchen", "Hickle", false, null, "Gretchen84", null, null, "AQAAAAEAACcQAAAAEOrlHnMmmPR1CWttqgyLkSKyAfefKbBWjcdgpz/Kl6qZtW2KURUPAMtAMsw8qHk5Xg==", null, false, null, null, 0, false, null },
                    { new Guid("e9781110-3553-481f-bb3a-7ca26a63a83b"), 0, null, 137.0168344690570000m, "df5a903d-347f-414a-b957-e24485019e30", null, null, null, false, "Megan", "Megan", "Botsford", false, null, "Megan6", null, null, "AQAAAAEAACcQAAAAEKzzdZw2eJc94eas2q/WCmWW0qa1hrRx6PlcAB6Hc+lPnakc6gT0TxxKCSsR3Dh5Pw==", null, false, null, null, 0, false, null },
                    { new Guid("ed54e83f-5702-4289-98fb-949b73140a47"), 0, new DateTime(1987, 4, 11, 18, 33, 33, 357, DateTimeKind.Local).AddTicks(8522), 851.5220104570870000m, "36413adf-d139-4f44-b2dd-8884ec157b88", null, null, null, false, null, "Jacob", "O'Conner", false, null, "Jacob88", null, null, "AQAAAAEAACcQAAAAEN4UrHMbCgTKlQMZMjwlSVRiDQmRhYUz59LijbOawNqwq/mSP+Ze5vzr9p4kpT73BQ==", null, false, null, null, 1, false, null },
                    { new Guid("eddb3b35-4415-4828-97b3-fd737f127090"), 0, new DateTime(2001, 11, 10, 20, 29, 52, 903, DateTimeKind.Local).AddTicks(2068), 449.7243541960720000m, "86aab268-5913-4db5-aae5-475c7f8e941f", null, null, null, false, null, "Carlton", "Wyman", false, null, "Carlton.Wyman76", null, null, "AQAAAAEAACcQAAAAEMNAhJk6c03T+FY3rMdABdwNHrRJA57McSbEn/eLRPgs26RrRaKw7gR/M9IQZL0L7A==", null, false, null, null, 1, false, null },
                    { new Guid("eedd859d-8af5-43b7-8938-5bce7dd89153"), 0, null, 99.51636103600150000m, "5a85d952-b90e-4a7f-80c7-2e1afbe489bb", null, null, null, false, "Bennie", "Bennie", "Armstrong", false, null, "Bennie.Armstrong", null, null, "AQAAAAEAACcQAAAAEGjJo+cV5SpVeMTwfTh9HaDTHWCYW8XFtDPYyspVaqfEHelb7ZwoUJRotuOfDsM9gg==", null, false, null, null, 1, false, null },
                    { new Guid("ef100efa-deb4-4516-9a15-38df8ff7e396"), 0, new DateTime(1960, 3, 4, 16, 6, 28, 671, DateTimeKind.Local).AddTicks(982), 340.9433407363840000m, "32c20112-df49-4f85-a1b3-1793379a9f85", null, null, null, false, null, "May", "Conroy", false, null, "May_Conroy", null, null, "AQAAAAEAACcQAAAAEFmriMUuQcSKj36bmnTNNDEIcJJF+IvZan0ftQI4oX+jWheMiW1vym9Axme6pfTI9A==", null, false, null, null, 1, false, null },
                    { new Guid("ef14d144-d1c3-49fb-9e25-1889be79f4e3"), 0, new DateTime(1964, 3, 20, 22, 32, 52, 774, DateTimeKind.Local).AddTicks(9504), 683.48698004970000m, "78161c1a-bd8d-43bf-a0dc-c0bd29ac0b40", null, null, null, false, "Claudia", "Claudia", "Moen", false, null, "Claudia.Moen", null, null, "AQAAAAEAACcQAAAAELxwm2X2CRf5E5bsG6k0X1x7bw3HynM+R2ZBAVIYTcR2xNKucmOOY2KthAB3IGU4jw==", null, false, null, null, 1, false, null },
                    { new Guid("f044a50f-e46f-4992-b8ae-47aa00e79d4d"), 0, null, 941.2729628526620000m, "981fdc86-690d-40ce-9129-b4a6f7c9e9f3", null, null, null, false, "Patti", "Patti", "Parker", false, null, "Patti69", null, null, "AQAAAAEAACcQAAAAEEM9IJCE43aHboelg7m8oyfifVbLLuSPam5EBr1q1SJTZuUz3/+10rMt13BwqzNQRg==", null, false, null, null, 2, false, null },
                    { new Guid("f17c05bb-245d-432b-9116-f181ecbd16c6"), 0, null, 717.7495494394560000m, "045a3d54-7a71-4049-b379-a0dfe4e390d7", null, null, null, false, "Marguerite", "Marguerite", "Pfeffer", false, null, "Marguerite_Pfeffer83", null, null, "AQAAAAEAACcQAAAAEA/leSrzvURuU1bWrjU4iUTxtcZDKGYH5w6gQOmzdpICRAgOnKNcAmZMzaIdR//MtA==", null, false, null, null, 1, false, null },
                    { new Guid("f472d28b-1df9-4c84-8ceb-3254f55042e7"), 0, null, 913.5394092746290000m, "85dbfaca-d961-4628-8b3d-eecfa61d9fb9", null, null, null, false, "Blanche", "Blanche", "Streich", false, null, "Blanche_Streich", null, null, "AQAAAAEAACcQAAAAEGOaDeWvSRPWPAV3yGMGAaKvhwBVLz87OEk2mI2gm2CXJiWQxn2vn7is/DZR+tL94A==", null, false, null, null, 2, false, null },
                    { new Guid("f4d9bb48-d87b-420c-b2ef-f724726c7a08"), 0, new DateTime(2000, 3, 6, 9, 48, 25, 433, DateTimeKind.Local).AddTicks(1725), 915.0449568907650000m, "3052c73d-9870-480d-9f2b-5fcc2be01837", null, null, null, false, null, "Cristina", "Jones", false, null, "Cristina_Jones", null, null, "AQAAAAEAACcQAAAAEJhbWBjE+dEWWoIWRoJdvfB4sE3MZuyUnt37EQOu0Y5AgC6b726p9fXP0I+qKYkxNw==", null, false, null, null, 2, false, null },
                    { new Guid("f54b6d8e-36d4-482b-83f6-69bd802b2ec3"), 0, null, 395.2205487384210000m, "8bbf6e04-88be-43d7-a6a9-4358aaae10b7", null, null, null, false, "Harry", "Harry", "Wiza", false, null, "Harry_Wiza", null, null, "AQAAAAEAACcQAAAAEMQJAuIy/HBdjYkULXjh+df2eCjom9MZbCgyYf3rzjeNGTeXrY89q7Q5TjY34Dtn7A==", null, false, null, null, 0, false, null },
                    { new Guid("f7f7b1e1-146a-4f33-9556-99419aa87dbb"), 0, new DateTime(1933, 8, 16, 20, 31, 48, 25, DateTimeKind.Local).AddTicks(3162), 972.9386655518810000m, "46cd6e49-9c0e-4119-8a81-b2cb92ad5d7d", null, null, null, false, "Nora", "Nora", "Jacobson", false, null, "Nora2", null, null, "AQAAAAEAACcQAAAAENjV0ZFdhx8FX4Xh7d7D6A2DQ/JpouAHFg2zVt9ky+wtcJ1cECG3/T1nOE1nrtbQFw==", null, false, null, null, 1, false, null },
                    { new Guid("f9c15c1c-b6bd-46fd-921b-e1778f14dacf"), 0, null, 49.33162803237130000m, "233fdd94-6491-4051-964f-ff1d2d75ecde", null, null, null, false, null, "Toby", "Dibbert", false, null, "Toby_Dibbert", null, null, "AQAAAAEAACcQAAAAEFjIRfylsk90IK2FleKYwFSlEPXxBbmenJzg2RAzPxsdD4onp/r8XEdnX/MgVgR7Hg==", null, false, null, null, 2, false, null },
                    { new Guid("fc15fcf7-014b-4521-910c-8a4a05ae7df9"), 0, null, 802.554004449850000m, "1cb836dc-8ca6-4222-b9ae-445b99f4bf2f", null, null, null, false, "Kristin", "Kristin", "Nienow", false, null, "Kristin21", null, null, "AQAAAAEAACcQAAAAEFyB7UHCIc5EcXE2nnfbw0/OwCXigxgWgVZwctmeaoyjI6E6Da37EUNbMLPCRLBivw==", null, false, null, null, 0, false, null },
                    { new Guid("fc2635e7-fbe6-403c-bcdf-dc9a65be3352"), 0, null, 770.5136532585240000m, "259346e1-e028-47dc-a7c5-64c37d20cc8a", null, null, null, false, null, "Leslie", "Tromp", false, null, "Leslie_Tromp", null, null, "AQAAAAEAACcQAAAAECLutwuyrXeyXCC5HByznl0L67H9hUOOKL2WkmV8v0jKwE5wneNt0ef3tNL5BmGC7g==", null, false, null, null, 2, false, null },
                    { new Guid("fc7807f7-2e15-4c19-8500-ea40f337d9de"), 0, null, 176.9992465406320000m, "aaec9ab5-e1d8-41f5-a016-b1b258b599af", null, null, null, false, "Lorenzo", "Lorenzo", "Rosenbaum", false, null, "Lorenzo.Rosenbaum", null, null, "AQAAAAEAACcQAAAAECLl7zPoR4ncRq75jbCDo4ISfe55zneOEt8OahXPx9sZfdqPS/a/RvfRtrHU2GRWKw==", null, false, null, null, 1, false, null },
                    { new Guid("fd6ebc44-c70c-4ea5-ad8a-6029ee9c49d9"), 0, null, 199.3212186670560000m, "d0dae74b-5879-4fde-a5bb-35ae2b702aab", null, null, null, false, null, "Alexis", "Konopelski", false, null, "Alexis_Konopelski41", null, null, "AQAAAAEAACcQAAAAEFIPPTIDJDeYsu4XObgnZ9/t49PDcWfJS94Xd0qzANW3RfKszj7nZVJ6oUqorGurdg==", null, false, null, null, 2, false, null },
                    { new Guid("ff75563e-5545-46de-a4b3-3e0727d74698"), 0, new DateTime(2006, 7, 9, 19, 40, 23, 795, DateTimeKind.Local).AddTicks(6566), 60.0212269274980000m, "d28fea5c-96ec-4290-a1ff-13b9ccc20cd9", null, null, null, false, null, "Antonia", "Hamill", false, null, "Antonia_Hamill76", null, null, "AQAAAAEAACcQAAAAEAlyVpKEHLeUBIGYC7iFuFY9MYyF08YIlMqZD1XHYIUgkTD6gFT2laSJq4RW2M7K4w==", null, false, null, null, 1, false, null },
                    { new Guid("ffdf2e3d-14e1-47fc-a87f-43ee44597c72"), 0, null, 292.5818336943380000m, "7f6b35eb-c6ae-4005-b4f9-9840dc1d2295", null, null, null, false, "Veronica", "Veronica", "Hackett", false, null, "Veronica_Hackett22", null, null, "AQAAAAEAACcQAAAAEAZVvmkrdJrvq53TAeTFKdq1hCbfhllZwARFP+3zmVSTYXkNSkboaWZqMEIeoW4/zA==", null, false, null, null, 0, false, null }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("00e321a0-b3cd-4efa-ad5f-acd2a6277973"), "0,21119452;0,888482", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Sauerhaven, Botswana", "Waters Ramp, 13849", 2090242696 },
                    { new Guid("017dd6b5-4ed7-4f02-ad43-3b51a7ad4bb9"), "0,2622674;0,24064423", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Brittany, Liechtenstein", "Cara Lodge, 018", -553125716 },
                    { new Guid("0276dcb5-0fda-45af-ae1e-ad1ebb9eb360"), "0,20108965;0,3965427", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lindgrenfurt, Honduras", "Rath Hollow, 68192", -1304518772 },
                    { new Guid("05b94b15-3d70-4263-bc23-e7bc2ee0b68f"), "0,38515562;0,6097359", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Gibsonburgh, Peru", "Ferry Underpass, 92057", -429843782 },
                    { new Guid("06c4b020-4ee1-41a1-919c-35bbef42db08"), "0,7445438;0,51639014", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Kimview, French Southern Territories", "Champlin Corners, 05483", -302961860 },
                    { new Guid("074d3ed8-239e-447f-b465-76904d489640"), "0,36675134;0,88124293", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Considineport, France", "Nicholaus Radial, 69359", 1384533506 },
                    { new Guid("08b7e35e-b9df-4bcb-9d3c-45421f0346f5"), "0,48024303;0,5163894", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Modestoside, Somalia", "Lonny Ranch, 723", -742999203 },
                    { new Guid("08bfef53-8160-4393-a169-238134272885"), "0,023855615;0,9776245", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Kadeland, Swaziland", "Jerde Club, 26499", -746431348 },
                    { new Guid("097788d7-65a7-4005-8df8-99329c8ac247"), "0,09344343;0,4452098", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "McClurefurt, Ethiopia", "Boehm Stream, 0787", -1505440099 },
                    { new Guid("0e2be55a-06a0-4e73-a58a-bfc972ca90eb"), "0,89488775;0,86796707", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Hackettbury, Virgin Islands, British", "Simonis Port, 506", 1962119464 },
                    { new Guid("11c40e7e-4a84-4a7c-a9e9-dbe6ce92159b"), "0,09318269;0,6986376", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Nayeliborough, Austria", "Viola Way, 70638", -1672898855 }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("1202d374-094e-4967-809f-0c9d88a92d3a"), "0,39716163;0,59926665", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Berniceburgh, Timor-Leste", "Braeden Stravenue, 95618", -1767349425 },
                    { new Guid("16548a0a-53cd-450f-ae9b-a18f612b9b9e"), "0,41092867;0,5311361", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Vanessamouth, Hong Kong", "Preston Inlet, 336", 2077453222 },
                    { new Guid("1da1caca-249e-4dd5-b5c5-843f88248569"), "0,08598033;0,03606849", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Orlando, Solomon Islands", "Joaquin Forge, 2969", 775043635 },
                    { new Guid("1e3e36ee-88df-4b45-983d-3b59759a175b"), "0,7547889;0,1449845", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Brycebury, Sweden", "Brigitte Lakes, 46570", -855441949 },
                    { new Guid("1f1f7a4a-e508-4549-9d13-c652fabbae36"), "0,40865907;0,6771071", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kilbackland, Venezuela", "McDermott Dale, 254", -996810458 },
                    { new Guid("2484c9b3-5105-47ec-be5e-8d4c3a326a6c"), "0,12538996;0,08326856", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Jimmie, French Polynesia", "Fisher Street, 3408", 518029374 },
                    { new Guid("26c6822d-4c06-4e3d-935b-158be43a4e05"), "0,4403974;0,73558617", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Graciela, France", "Herman Prairie, 0087", 1217481657 },
                    { new Guid("26fa5931-8dc4-4cd7-b964-67e31b70ef54"), "0,49169585;0,9765918", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Austinville, Cayman Islands", "Cleve Neck, 112", -716889786 },
                    { new Guid("2c51fd58-18b8-4f79-b99e-83d90d242c61"), "0,25517228;0,2814485", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Harberfort, Albania", "Crona Drive, 8697", -183084682 },
                    { new Guid("2d93dd0e-f4e9-42b2-b57d-51bc36b4b51d"), "0,715284;0,29421481", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Kamryn, Costa Rica", "Cecile Way, 020", 1628284196 },
                    { new Guid("2df8ca0b-4f72-4a2d-b260-f8972c7fff9e"), "0,31420344;0,5927591", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Belle, Belize", "Keebler Pass, 571", 1101434282 },
                    { new Guid("33da8c7f-9503-4d5c-b842-9bec39923897"), "0,11904877;0,9024211", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Wilfrid, Uruguay", "Bauch Cape, 5559", 176918412 },
                    { new Guid("3542a37e-d418-4a88-bca3-9c235e8eeb8a"), "0,6041568;0,11084701", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Delphia, Rwanda", "Volkman Crest, 987", 262093976 },
                    { new Guid("37add9c7-3991-4d21-b9d3-b952f8abdce3"), "0,44571507;0,5475557", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Bailey, Sweden", "Shyann Mountains, 445", 63540266 },
                    { new Guid("3d62ee17-73e8-4e37-8ec6-39c3b95da370"), "0,055117264;0,17195836", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Carletonhaven, Algeria", "Annette Groves, 13710", 2116144972 },
                    { new Guid("433372c4-7775-47c4-a527-447eb90835e2"), "0,5175975;0,6587174", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Santosstad, United Kingdom", "Hane Lake, 83892", -91297344 },
                    { new Guid("455f3b1f-1405-498b-a7da-b26d99b7223c"), "0,27835426;0,14510085", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Lexus, Bhutan", "Walker Corners, 559", 1907210468 },
                    { new Guid("45fb15d5-1d03-4a20-aac7-a81780ee61c5"), "0,5868937;0,71775013", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Savanna, Kazakhstan", "Jaquelin Corners, 689", 904418950 },
                    { new Guid("4752f7b1-5165-4471-bd33-3e34ea3ec290"), "0,47504658;0,60350955", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Jeramymouth, Denmark", "Piper Orchard, 3237", -2049542899 },
                    { new Guid("47c17694-b67e-4966-b2a1-58c1902f5f55"), "0,4174391;0,57433206", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Pete, Qatar", "Kozey Field, 585", 1780492388 },
                    { new Guid("4ba4989a-a8b9-4cf5-9e86-a40e417ff062"), "0,070354685;0,71434444", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Torpton, Jersey", "Faye Lodge, 26410", -1065651772 },
                    { new Guid("504a43f9-96cd-4c2f-a40b-f406b78f16f2"), "0,6932536;0,50752264", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Diego, Thailand", "Toy Place, 2750", 1503911994 },
                    { new Guid("5290d396-dbd8-4934-b4a7-5c2f1f6af893"), "0,46637803;0,04234157", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Verlie, Montenegro", "Dickinson Cove, 027", -811589622 },
                    { new Guid("543a3672-3ec0-4226-b87e-ccd2c70cd4e4"), "0,35308853;0,97166145", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Haleyshire, France", "Lubowitz Manor, 0414", -291038984 },
                    { new Guid("547f1a6b-9d5f-4f34-9ab7-a70e48ee8959"), "0,36490238;0,18026638", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Liaborough, Armenia", "Roob Locks, 73568", 2040104949 },
                    { new Guid("55d08da5-4e04-4999-8b8e-45bcc14669c7"), "0,7538497;0,62401426", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Shainashire, Panama", "Jaclyn Pines, 1228", 673510476 },
                    { new Guid("58a76774-89af-474b-b5ea-9b18e6499c2d"), "0,43114743;0,9473817", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Hallemouth, Mexico", "Simonis Tunnel, 9726", -1445962970 },
                    { new Guid("5b14e8f7-bf92-458f-9591-1c6f68ba3eef"), "0,022863513;0,35719457", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Angelostad, Sao Tome and Principe", "Green Ville, 43829", 946575482 },
                    { new Guid("5f359b3f-8c20-4a2d-9d78-ba4e31c65633"), "0,9864919;0,03874137", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adrienburgh, Grenada", "Kellie Creek, 1197", 1810228802 },
                    { new Guid("60e1e7cf-e49b-45bf-912d-5216f1bb9f1c"), "0,18158486;0,096668966", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Mose, Antarctica (the territory South of 60 deg S)", "Haven Route, 0838", 1875025058 },
                    { new Guid("62636c8c-9d0d-4357-bb21-4d11946dd2a6"), "0,9382997;0,104191564", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Marvinshire, Slovakia (Slovak Republic)", "Lemke Ranch, 066", -1468524925 },
                    { new Guid("65f9bbd7-4da4-4c4f-aa52-6f7e5bf7dd99"), "0,45877692;0,17876187", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Esther, Cayman Islands", "Simonis Stravenue, 02019", -1873880452 },
                    { new Guid("6febe8fa-59cb-477a-b91d-994112d858da"), "0,08212267;0,9116055", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ulicesbury, Grenada", "Chris Circles, 09282", -1244302106 },
                    { new Guid("703532e7-6e28-4469-9434-0710af3995ff"), "0,017509056;0,37162766", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kuhntown, Marshall Islands", "Casper Garden, 88591", -2082012547 },
                    { new Guid("70bdf1a5-a486-4953-95b5-077b0986a392"), "0,2460188;0,9486813", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Oceane, Cambodia", "Weber Shores, 24653", 1765275717 },
                    { new Guid("70fcaf82-5547-45cf-909e-b70263c7eaa1"), "0,26077038;0,8839332", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Rossie, Solomon Islands", "Elfrieda Union, 7132", 1760286364 },
                    { new Guid("73992e26-143b-48c4-81b3-ef32d0141575"), "0,084108196;0,62012047", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Justenmouth, Andorra", "Corkery Bridge, 053", -302716961 },
                    { new Guid("77286314-faf9-4115-866f-da5446acce00"), "0,6186181;0,82182205", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Jimmie, Cuba", "Von Park, 04753", 22280285 },
                    { new Guid("7bd1a527-3c42-475c-818b-e39a99562fd9"), "0,89981335;0,7568381", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Lavernatown, Nicaragua", "Janice Courts, 822", 606913074 },
                    { new Guid("7c5fd36b-3b43-4ecf-97e4-f7a97ff67773"), "0,84547156;0,38687512", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Jules, Bolivia", "Kolby Radial, 835", 2056652618 },
                    { new Guid("80d71266-f0a6-43b8-8aa2-708c31a92407"), "0,5334386;0,1407044", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Rutherfordborough, Micronesia", "Mayert Wells, 506", -627299321 },
                    { new Guid("839a78cb-2a67-4249-a872-0e891187d566"), "0,9087541;0,03378734", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Nikolas, Zimbabwe", "Edison Vista, 3578", 111532754 }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("878f73b3-ecca-4152-b101-4fe4d5bc7f92"), "0,77921605;0,9329792", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Faheyland, Honduras", "Elvie Brook, 435", 729146068 },
                    { new Guid("88f4469b-15bf-408d-89d0-bd95968d61d6"), "0,5260184;0,3574922", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kuvaliston, Spain", "Sylvan Via, 216", -628875361 },
                    { new Guid("8ad721e3-df57-46b7-8270-389836d08360"), "0,29461762;0,7618553", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Catharine, Lebanon", "Mueller View, 9272", 2035665574 },
                    { new Guid("91e83f1d-b0fb-4d71-9a46-e843ef268d7d"), "0,15200298;0,25899628", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Schoenfort, Iraq", "Torphy Stravenue, 838", -116890240 },
                    { new Guid("9300e6fe-749c-45fc-b38e-3b8246fd2294"), "0,65024143;0,951002", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Claudia, Czech Republic", "O'Hara Valleys, 4806", -243120173 },
                    { new Guid("9310580e-8641-48b2-89e1-b478bc434217"), "0,8768274;0,97970414", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Dario, Guinea", "Haag Loop, 437", 780543165 },
                    { new Guid("96763803-131a-471d-9d8a-90e729bab5d0"), "0,9176363;0,958033", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Stromanbury, Costa Rica", "Keeling Track, 501", 1823398912 },
                    { new Guid("9935a97f-468c-41ff-a47e-6cb2275d892b"), "0,06594847;0,2289215", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Presley, Bermuda", "VonRueden Station, 2619", 1656578536 },
                    { new Guid("a1c5c68d-6458-41b9-8914-e84f754b5d1f"), "0,08299593;0,06722321", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Virginiatown, Latvia", "Pagac Loop, 93461", -1394266130 },
                    { new Guid("a3a70b4f-c475-44ef-92bc-5fd3442a7a50"), "0,18528852;0,18066211", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kertzmannfurt, Uruguay", "Sydnee Mall, 63284", 1304856253 },
                    { new Guid("a775edbb-61aa-4319-9f77-a9b03895a8f6"), "0,36244878;0,41458657", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Gennaro, Mauritania", "Wilton Fords, 848", 1402720191 },
                    { new Guid("ae936b46-e9ca-40ac-8457-fa5e82acff34"), "0,84291625;0,27169102", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Volkmanberg, Japan", "Douglas Streets, 8301", -1293150882 },
                    { new Guid("af7b05b2-61c9-48a8-9305-39c43038af15"), "0,47388265;0,3324935", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Clementina, Saint Lucia", "Senger Shores, 652", 1698302608 },
                    { new Guid("b0972c7f-be85-4a06-804f-1090e4128e71"), "0,86607057;0,4563463", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Schowalterbury, Falkland Islands (Malvinas)", "McClure Junctions, 89094", 989805592 },
                    { new Guid("b3af4bcd-f779-4cc8-95f7-ab948ef9bf0b"), "0,79300004;0,22338405", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Marielle, France", "Brandi Path, 794", 2050800830 },
                    { new Guid("bc7398d5-822c-4bef-80cf-ada5ad3fd5d7"), "0,069385506;0,21070848", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Sierra, Indonesia", "Alex Course, 0053", -140378088 },
                    { new Guid("be93c5d0-dbaf-4c6c-bd5f-07f732c78e9c"), "0,3409062;0,3658217", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Howeland, Guernsey", "Witting Canyon, 0480", -382961922 },
                    { new Guid("c3feb302-c6f4-4aec-bcce-6b77cdc749c6"), "0,05648634;0,6384292", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Lisa, Northern Mariana Islands", "Heaney Rue, 3983", 344845759 },
                    { new Guid("c5c40103-7eb1-4db8-8069-d2264d2c98f9"), "0,86700606;0,49836934", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Murazikland, Spain", "Fritsch River, 07012", -550866224 },
                    { new Guid("c7468da2-3433-4013-b736-762cfed2fbd5"), "0,28513327;0,7662998", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Darrion, Armenia", "Jerrell Village, 8793", 1024866922 },
                    { new Guid("c85a741c-2db3-4255-9cb3-e7ba319c3b3b"), "0,08278511;0,820452", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Sallyburgh, Palau", "Wunsch Loaf, 303", 571835487 },
                    { new Guid("c86fb63f-3440-4837-a32e-225a5d3e866a"), "0,19213928;0,50211954", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Ada, Mali", "Kacie Roads, 451", 2103140924 },
                    { new Guid("ca5a2f47-2a72-43bc-917a-f860f3fc9797"), "0,28501257;0,9180193", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Raul, Peru", "Rice Rest, 106", -589054676 },
                    { new Guid("ca9b4c98-140b-4455-8fe3-e367b8aa9247"), "0,17773381;0,11144044", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Nevaport, Sierra Leone", "Patience Hills, 9809", -1167527554 },
                    { new Guid("cb4c29cd-098a-4cc4-9a5b-1b6da0485df8"), "0,5002211;0,9853443", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Jabarichester, Central African Republic", "Grady Row, 69810", 416360008 },
                    { new Guid("cc06dc19-c877-486a-b9d1-c475991ab268"), "0,44664416;0,37631604", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Dantebury, Colombia", "Fermin Cliffs, 03963", -1449362796 },
                    { new Guid("cc7a99fe-90f0-4a78-a48f-84c6b16e72d7"), "0,51303095;0,3584709", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Chanelleborough, Iran", "Hansen Motorway, 230", 1469773949 },
                    { new Guid("cf7d01d7-485c-4a38-96eb-b97c85b129bd"), "0,339976;0,84156793", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Carolina, Mayotte", "Georgianna Summit, 1106", -2056299220 },
                    { new Guid("d05aa2dd-23af-4af7-a15c-ba40c92d03d5"), "0,74950194;0,70993936", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kenyattahaven, Myanmar", "Green Lane, 270", -1212966760 },
                    { new Guid("d2f56d97-f52d-4e0d-ba07-2c2ab3337e5e"), "0,03719012;0,35239127", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Aureliamouth, Morocco", "Hamill Drives, 06028", -343202709 },
                    { new Guid("d4206192-5ee9-4cab-a69d-74a89bf65d4d"), "0,1521805;0,36798143", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Horacio, Georgia", "Harley Isle, 50046", -1134529485 },
                    { new Guid("d5ff9ab7-1dc2-49be-9788-28ecbb28a90d"), "0,5854289;0,027819078", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Casperburgh, Madagascar", "Bernhard Roads, 32768", 925108116 },
                    { new Guid("da035ca1-996e-4ad3-8b6c-2cce646fa4da"), "0,39490503;0,18863624", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Greenfelderland, Senegal", "Veum Road, 681", -2115911609 },
                    { new Guid("df5bac42-c379-4d6e-9949-25a3c00e0f11"), "0,60209525;0,56398576", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mrazville, Christmas Island", "Von Parks, 2542", -325824514 },
                    { new Guid("e0db0206-372b-4b90-b1e1-017df05fc9ef"), "0,6538645;0,24040186", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Schowalterchester, Bahamas", "O'Kon Gardens, 30419", 667774902 },
                    { new Guid("e2834fe1-ac51-4e97-94bf-4a657aa6a947"), "0,749073;0,46843138", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Madelynnchester, French Polynesia", "Lue Groves, 51531", -762635198 },
                    { new Guid("e7f491cb-7c1e-4be9-be56-cb751bfd6c57"), "0,8678059;0,06823424", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Kamronside, Australia", "Ritchie Mountain, 41411", -1741548552 },
                    { new Guid("e9a51c17-9445-48d3-94ab-4ad09bb02de4"), "0,1185507;0,29539254", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Penelope, Cote d'Ivoire", "Korey Underpass, 484", -988018734 },
                    { new Guid("ea8511e8-2674-4046-a2de-4f1ca2976191"), "0,47724357;0,6844932", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Thorashire, American Samoa", "Lemke Glens, 0739", -1696819802 },
                    { new Guid("eb8a744d-7e24-42db-bb6c-e82a8138731d"), "0,7467211;0,40161777", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Reingerport, Dominican Republic", "Heath Stravenue, 048", 1784052018 },
                    { new Guid("ecb99e0f-f5cf-4c1e-8dc8-29e656e9eb9e"), "0,49399564;0,7095193", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Missouri, Tuvalu", "Joyce Bypass, 9674", 1633224252 },
                    { new Guid("f2728ea9-fee8-48f0-9079-7bc271322fdc"), "0,7148894;0,8925471", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Derrickstad, El Salvador", "Cleta Spring, 5699", -2142674641 }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("f4ee338a-2238-4a81-821d-b70987ca3c49"), "0,92625755;0,16812259", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Marciafurt, Argentina", "Moses Walks, 3023", -827585558 },
                    { new Guid("face8dbe-f57d-401d-bf10-3f27e9149d5a"), "0,15987796;0,38067272", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Wilfredo, Tajikistan", "Faustino Mountains, 31548", 551152194 },
                    { new Guid("fb721aab-77e6-4e3e-b874-5cee2eda835d"), "0,43217018;0,1514402", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Wisokyberg, Taiwan", "Crooks Summit, 030", 864087904 },
                    { new Guid("fd19b511-7f81-4e81-a49f-f4120f57f0a4"), "0,5988464;0,35724103", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Enola, El Salvador", "Kertzmann Brooks, 620", 262062650 },
                    { new Guid("ff9578ad-c8a4-47c7-a6b6-d99d0bd5ccd7"), "0,014275295;0,6178313", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Stellashire, Pitcairn Islands", "Ferry Groves, 5096", 2023456408 }
                });

            migrationBuilder.InsertData(
                table: "PostBranches",
                columns: new[] { "BranchId", "BranchNumber", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress" },
                values: new object[,]
                {
                    { new Guid("01196c3b-1c90-49ce-a212-a66937efc441"), 2019093283, "0,26348972;0,7733036", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Brianton, Martinique", "Taya Meadows, 356" },
                    { new Guid("02addd52-5fc0-49f5-80a9-7fdde8471356"), -962345817, "0,32060102;0,2219369", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Harberton, Niger", "Kayden Ports, 5224" },
                    { new Guid("0724176d-bd66-4517-b078-51504b6113fa"), -834147104, "0,31910557;0,643037", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Gradymouth, Antigua and Barbuda", "Bechtelar Roads, 8177" },
                    { new Guid("08080468-af45-49eb-a130-6d96a99fd932"), -478268912, "0,5810264;0,30027393", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Turnerville, Iraq", "Stokes Plain, 498" },
                    { new Guid("0ba9e586-4ee4-464c-938d-ae15298c6dd5"), -1396416338, "0,30378023;0,92391646", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mozellemouth, Nepal", "Lavada Underpass, 2320" },
                    { new Guid("0dc2deb1-5cbd-46a5-af8b-d0a8df0483b3"), -618282977, "0,650542;0,02043585", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Goldnermouth, Sudan", "Kassandra Lock, 95167" },
                    { new Guid("136c48c1-360f-4178-9140-3be6686b69a1"), 518857994, "0,7419371;0,53426075", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Pourosshire, Belgium", "Heaven Alley, 61383" },
                    { new Guid("1393ab8e-9081-47f2-87c2-02ed2f949603"), 68380132, "0,8246881;0,7330692", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Bauchbury, Saint Lucia", "Blanda Dale, 879" },
                    { new Guid("15d66f9e-fc40-4c15-ae0c-a031902012cb"), 1394825292, "0,59354794;0,9790766", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Framiberg, Malta", "Beer Prairie, 3383" },
                    { new Guid("17201d81-8ab5-490d-86a9-58bc2b51ae89"), -2087554362, "0,9061601;0,4860285", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Filibertoshire, Myanmar", "Turner Plains, 4475" },
                    { new Guid("1a7eeb16-be7b-4d37-b3d0-e5289074307c"), 916668219, "0,034151763;0,0997439", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Halhaven, Nigeria", "Dibbert Extension, 4706" },
                    { new Guid("1e79a388-d870-4b99-866c-41e9e6a263ba"), 888513465, "0,47679767;0,4259861", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Dulcetown, Holy See (Vatican City State)", "Sydnee Springs, 91823" },
                    { new Guid("1f2414cf-0390-4162-82d6-0c94f909f647"), 1474305773, "0,98820543;0,017856145", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Norwoodhaven, Venezuela", "Bergstrom Lakes, 425" },
                    { new Guid("2105e047-a562-42bd-9d74-1233fa4eaffa"), -478583927, "0,07595134;0,5987853", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Murphy, Uruguay", "Carroll Mews, 466" },
                    { new Guid("217055a4-39c9-4fcb-9b75-d4ac2dc840c7"), 837740951, "0,43857068;0,46427545", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Runolfssonburgh, Sierra Leone", "Barrows Road, 6615" },
                    { new Guid("21faa1a1-e583-43f4-8795-31b4e9e8198b"), 936607483, "0,88732564;0,45062894", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Niko, Faroe Islands", "Cronin Brook, 20841" },
                    { new Guid("236b0ad7-2c49-488e-bf89-7e01fcc50e03"), -44112039, "0,13341922;0,37838593", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Vincenzochester, Svalbard & Jan Mayen Islands", "Jeanie Row, 931" },
                    { new Guid("2370a8b4-289d-451e-8b11-227a57c9859f"), -407148943, "0,45897052;0,35559064", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Ignaciochester, Senegal", "Pouros Drive, 8174" },
                    { new Guid("2435f315-983c-4d0f-a6ac-529678a4397b"), -1132341958, "0,80686057;0,70615506", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Daytonborough, Lao People's Democratic Republic", "Davis Circle, 406" },
                    { new Guid("26e127cc-52df-43dd-8b1b-a28583c63e3c"), -2145287803, "0,58472574;0,9977381", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kattiefort, Bahrain", "Markus Dam, 610" },
                    { new Guid("26fe2cc6-77b6-46cd-9468-732650a83645"), -1096164376, "0,38144758;0,42326173", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Alisa, Chile", "Reese Neck, 8657" },
                    { new Guid("2b80224a-301f-4136-9147-716cebd41c61"), 1778493218, "0,60437095;0,8328592", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Aureliamouth, Macao", "Barrows Station, 126" },
                    { new Guid("2be3ab35-f1ec-446d-88b7-bd6614628f1a"), -1812587593, "0,40746313;0,0162342", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Feltonside, Taiwan", "Marks Square, 9681" },
                    { new Guid("2e1a4706-c69f-4640-b9ac-34783bc0599a"), 277405227, "0,9564942;0,35925496", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Elian, British Indian Ocean Territory (Chagos Archipelago)", "Connelly Mission, 8492" },
                    { new Guid("2f3bcb36-af36-4ef1-bf6b-59c3a34b0a61"), 1052092076, "0,65007854;0,17835592", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Alberta, Faroe Islands", "Schaefer Center, 37682" },
                    { new Guid("31f8a69d-54bd-4bf2-9e5c-3587470d2d17"), -570904792, "0,72646856;0,86310524", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Rauhaven, Algeria", "Rippin Ferry, 5946" },
                    { new Guid("32bb712d-6263-446d-9472-80edd39f824b"), -1875011450, "0,46236902;0,43530104", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Leilahaven, Barbados", "Lucious Locks, 304" },
                    { new Guid("34f56ff8-0396-4906-bf65-95dd1d01520f"), -1990904326, "0,5920513;0,72661525", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Danialville, Saint Lucia", "Barrows Pine, 321" },
                    { new Guid("3989d947-30eb-4096-b0c6-4f3d6fa82542"), -1669885479, "0,21761777;0,023817344", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Barney, Georgia", "Miracle Unions, 077" },
                    { new Guid("3df90f2b-9fa0-4bf6-aaa2-cdb3f0673fd4"), 771807295, "0,33977082;0,8514998", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Joseph, Canada", "Streich Prairie, 3221" },
                    { new Guid("401b5a57-79c1-402b-9447-d39a95a308a8"), 945266293, "0,06350211;0,9127573", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Clevelandland, Brazil", "Schulist Shores, 49129" },
                    { new Guid("40e38a01-e06d-4aca-a449-6dee510f14e1"), -1611860552, "0,5176269;0,6622918", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Elvis, Heard Island and McDonald Islands", "Kenya Port, 286" },
                    { new Guid("48418162-82ae-458c-a6a9-a5b81e0cf242"), 1672892573, "0,20792761;0,92151904", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Melbaview, Tuvalu", "Walsh Wells, 1242" },
                    { new Guid("49d7e151-6bc0-420d-98c3-90b847b7bd67"), 133836537, "0,10382503;0,36851016", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Colliertown, Virgin Islands, British", "Margot Circles, 0423" },
                    { new Guid("4a3f347e-2eed-48c0-b67e-14a25a6ea8af"), 419956774, "0,8986427;0,8621696", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Trishaton, Macao", "Rosenbaum Glens, 05040" },
                    { new Guid("4a683be6-a2a4-43b2-8fd0-0afece6b4ce4"), 641844668, "0,47499296;0,063848376", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mosciskifurt, Virgin Islands, U.S.", "Sylvia Ports, 90762" },
                    { new Guid("4abcaad7-23df-49d1-a77a-7af2874321c9"), -1694420699, "0,21452127;0,016878659", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Spencertown, Tanzania", "Hane Islands, 03807" }
                });

            migrationBuilder.InsertData(
                table: "PostBranches",
                columns: new[] { "BranchId", "BranchNumber", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress" },
                values: new object[,]
                {
                    { new Guid("4dc75159-3062-4e73-bab6-9f860de1577c"), 658963373, "0,37840968;0,59548557", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Zitafort, Burkina Faso", "Jerome Via, 7653" },
                    { new Guid("4fbf2329-3141-4cac-b13d-c099bba2efb0"), 568742036, "0,7559948;0,4727507", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Laney, Gambia", "Alexanne Brooks, 05104" },
                    { new Guid("528c608e-7cf2-4213-a8f6-0c81d6c84c4f"), 2121305191, "0,34830064;0,74558455", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Estelle, Montserrat", "Jaskolski Ramp, 4114" },
                    { new Guid("534b7b7a-77b0-45f6-bfcd-28b23bcbc428"), 1555849925, "0,2059401;0,38869664", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kadenview, Malawi", "Arvel Parkways, 12550" },
                    { new Guid("544c3315-51ce-4345-a516-93c12beab8f4"), 916777357, "0,5139545;0,89741313", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Wilton, Panama", "Schmitt Parkways, 77743" },
                    { new Guid("57e7905d-3951-43b8-9dad-1350da8ff2b3"), -809378435, "0,33938396;0,17377773", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Margretside, Kenya", "Brady Walk, 255" },
                    { new Guid("5c49af2b-317f-479d-b47d-2bcb53c5ec76"), 1670617630, "0,45923796;0,25754714", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Freeda, Hong Kong", "Tabitha Neck, 27643" },
                    { new Guid("5e82b022-507e-4752-9482-0bd759c86f71"), 548852275, "0,9686303;0,4568147", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Dorian, Gibraltar", "Abernathy Land, 62383" },
                    { new Guid("65084898-84d4-461e-aadc-40d280a72d6a"), -1859436779, "0,440324;0,80748826", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Easton, Equatorial Guinea", "Morar Mills, 256" },
                    { new Guid("66da549a-10be-4479-b0ff-7b11555427af"), 1388477476, "0,770418;0,31998992", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Bauchville, Ukraine", "Brakus Crossroad, 5716" },
                    { new Guid("6b0a28fd-7a63-4fd8-9c96-bba3f123e142"), -741160049, "0,26033825;0,91517097", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Dolores, Dominica", "Kellen Extensions, 4504" },
                    { new Guid("6b9ee8fb-26e6-4272-95b5-e89f67461b97"), -216161143, "0,58854467;0,21389128", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Clotilde, Myanmar", "Brionna Parkway, 38008" },
                    { new Guid("6da322af-921d-4c90-abb4-4e5fff93a2e3"), -428982811, "0,36803943;0,47226167", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Schinnershire, Hong Kong", "Deckow Court, 9123" },
                    { new Guid("71e5345a-4c0c-45da-96bb-46af936072a3"), -799193592, "0,2666689;0,42523107", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Savanahville, Colombia", "Reichert Lake, 89607" },
                    { new Guid("7cbeeedb-d2ad-45cb-a001-ec31b8bc24f7"), -1831917190, "0,7073737;0,3578793", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Marianneland, Spain", "Urban Inlet, 4984" },
                    { new Guid("7cf5a4a3-bf46-44fb-a20a-626a8a808372"), -771899452, "0,83278894;0,36082804", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Roxanne, Faroe Islands", "Ernser Ford, 875" },
                    { new Guid("7d67e0db-b90c-452a-8723-9836ba9147fb"), -1434309072, "0,33724284;0,51304805", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Schmelerfurt, Chad", "Aleen Prairie, 737" },
                    { new Guid("8151f542-7470-48f2-9c2f-30e7914de3e3"), 1378091338, "0,46304497;0,47222906", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Helenstad, Sierra Leone", "Elena Trail, 01755" },
                    { new Guid("82a468dd-ccae-4a13-a993-6fdd97326ca1"), 1923344923, "0,33552572;0,88761157", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Deventon, Estonia", "Daniel Union, 1174" },
                    { new Guid("83d63ff9-2e10-454d-b15c-b00eff647e41"), 549722263, "0,51423115;0,063222766", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Fayberg, Germany", "Juston Inlet, 993" },
                    { new Guid("87ca24d4-68b9-4b38-a4c4-62d8379ed40d"), -1610325327, "0,061588474;0,34388795", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Jeffery, Honduras", "Ebert Forges, 9439" },
                    { new Guid("8a8c2823-bcec-4972-afc2-717be78aa4ba"), 1276104178, "0,22258024;0,24299254", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Kristopher, Cuba", "Jadyn Cliff, 004" },
                    { new Guid("93c288f9-ec1b-4eba-abf7-1983043ec2ac"), -200889840, "0,43155676;0,7920731", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Wilhelmineburgh, Burundi", "Nadia Pines, 92220" },
                    { new Guid("94e03200-bc54-4902-9e70-3843f682c726"), 1957509158, "0,6213895;0,7189045", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Arjun, Paraguay", "Bailey Hollow, 50314" },
                    { new Guid("9a43596a-617d-4a5b-ab44-e412f170c6e2"), 1737745732, "0,103542045;0,80776703", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Lela, Mauritius", "Harris Station, 377" },
                    { new Guid("9bf61f1e-d9d2-4d4a-a686-4a7948656bc8"), 2076185785, "0,7721647;0,8191171", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Otiliastad, Nepal", "Brennon Hills, 214" },
                    { new Guid("9db6c639-0bbf-4526-a6d1-29741c501173"), -431149676, "0,4118241;0,34153304", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Allan, Romania", "Ratke Lock, 13796" },
                    { new Guid("9f13969f-5d19-424c-88ca-a41305b15ff4"), 1100975791, "0,5084143;0,056110326", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Lorenzo, Tajikistan", "Jaskolski Shores, 2647" },
                    { new Guid("a01d038b-3b37-4a6f-9f6b-b24ad8c48059"), -2030904938, "0,19970874;0,71676415", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Alva, Reunion", "Wilfredo Extension, 52767" },
                    { new Guid("a42c74da-877b-4913-bffd-551311ba5d8a"), 1799332850, "0,57635725;0,38726813", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kosston, Turks and Caicos Islands", "Davis Inlet, 5429" },
                    { new Guid("a4a4861f-a278-4bd9-83a3-49f6dade1589"), 566866500, "0,08803134;0,9508135", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Cecelia, Maldives", "Delphia Grove, 8812" },
                    { new Guid("ad395cb9-05b5-49d1-af21-f21f7eb4f83a"), 521993059, "0,66008836;0,66785717", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Hailie, Serbia", "Isabel Terrace, 0021" },
                    { new Guid("ad7f0065-dfce-42b6-ad4e-b677655a8368"), 1670857468, "0,093909465;0,149153", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Jaunitachester, Netherlands", "Calista Ports, 563" },
                    { new Guid("aed1f991-28ff-47bb-98d6-71a94e3d2cd2"), 1701900548, "0,9633953;0,5275824", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Bradley, Cook Islands", "Jo Fall, 245" },
                    { new Guid("b02ffc23-9d10-460f-88ae-0137ffe31669"), -1564457649, "0,0061821705;0,9569734", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Annabel, Virgin Islands, U.S.", "Rosenbaum Street, 726" },
                    { new Guid("b08e8e4d-9ad3-4e09-9cd2-4852282cf47c"), 1869380057, "0,038590297;0,4088433", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Feeneymouth, Lithuania", "Leila Ridges, 1374" },
                    { new Guid("b2bad618-e322-4db3-9583-2b7564e1273f"), 1151141594, "0,8729177;0,23962982", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Martine, Cocos (Keeling) Islands", "Rex Mountain, 9351" },
                    { new Guid("b774a910-ab96-422b-bbd9-0b0889c39b1d"), 890708009, "0,85619766;0,66106224", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ankundingville, Albania", "Audreanne Shores, 7039" },
                    { new Guid("be9b1f4c-6553-43b8-b332-b8978fd30629"), 1216459053, "0,13823059;0,16464195", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Sincere, Libyan Arab Jamahiriya", "Jerde Dam, 27765" },
                    { new Guid("c1a5877a-6c59-4f0e-93a9-74321ed27c18"), 1972716993, "0,38876176;0,03263744", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Franeckiside, Barbados", "Diana Circles, 312" },
                    { new Guid("c5c238c7-5301-45db-aa29-74bd768d2fa0"), -2085455045, "0,98772067;0,42304677", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Gilbertstad, Somalia", "Margaretta Ways, 692" },
                    { new Guid("c6b4cbbe-dd01-441c-b872-a3b17e6885e2"), -478704358, "0,13847053;0,8119492", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Moorefort, Iran", "Powlowski Parkway, 433" }
                });

            migrationBuilder.InsertData(
                table: "PostBranches",
                columns: new[] { "BranchId", "BranchNumber", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress" },
                values: new object[,]
                {
                    { new Guid("c7cd3096-1312-4b1c-802e-1f83090b61f7"), 1714776817, "0,08876282;0,33014116", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Webster, Central African Republic", "Lueilwitz Streets, 7930" },
                    { new Guid("c870cd44-790c-47f5-a09e-4acc61043248"), -182727808, "0,27220786;0,121968366", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Orenview, Bahrain", "Waters Forest, 3934" },
                    { new Guid("caa7b082-1933-48e1-95ff-b0cce8725ad3"), 1606407127, "0,7448903;0,11888759", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Kassandrabury, Saint Vincent and the Grenadines", "Geovany Curve, 973" },
                    { new Guid("cce0442f-3630-4057-9b31-5aa49d926b2e"), -311666823, "0,9572823;0,55924904", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Mozellmouth, Sri Lanka", "Isabella Via, 79324" },
                    { new Guid("cf970b75-99a7-4312-8f04-a3a2220c73c4"), -1047445961, "0,55690914;0,89213824", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Electa, Kyrgyz Republic", "Amara Hill, 9504" },
                    { new Guid("d973511c-c8cf-403b-a0f8-ef151445e357"), -1286876733, "0,90586793;0,29671213", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Willmsmouth, Cocos (Keeling) Islands", "Pollich Turnpike, 583" },
                    { new Guid("dc33068d-9a2e-4826-be19-a4422590951e"), -433291333, "0,44552448;0,7597934", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Gerhardport, Netherlands Antilles", "Hansen Square, 144" },
                    { new Guid("dc4d0f86-9a11-496b-b75c-14bb61a636e4"), 2074461206, "0,8505765;0,17587449", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ankundingburgh, Morocco", "Adam Mountain, 28486" },
                    { new Guid("dfb433d9-35f1-4525-9cef-c8f7e1c6d1aa"), -754126218, "0,14249578;0,9289791", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Goodwinstad, Kiribati", "Mathilde Well, 039" },
                    { new Guid("e09f9c22-f55a-47b3-9c73-1a34c059bd17"), 124216358, "0,26069722;0,5561332", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Gino, Montenegro", "Sipes Ways, 3904" },
                    { new Guid("f094da9f-b52b-4a65-aee3-92ac867777bc"), -1687594575, "0,6324872;0,80697864", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Deanstad, Burundi", "Percival Cape, 53015" },
                    { new Guid("f15f7a99-e0eb-43a9-bbdb-1bbac0fd96e4"), -777366671, "0,17354243;0,39451241", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Marques, Cook Islands", "Sporer Squares, 778" },
                    { new Guid("f673f75a-2f50-43b2-ac5f-348d781cc9f1"), -1789337742, "0,8083158;0,07749009", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Carolinahaven, Marshall Islands", "Malinda Parkways, 348" },
                    { new Guid("f86b3621-60f8-4751-9a10-f6cc8690b685"), 1019513696, "0,17140552;0,6750513", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Conroyfurt, Turks and Caicos Islands", "Raheem Falls, 50261" },
                    { new Guid("f90c14bd-5b41-46ea-9074-2f19771c86f7"), 1211477475, "0,8803873;0,29155445", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Michelmouth, Turks and Caicos Islands", "Felix Rapids, 4522" },
                    { new Guid("f99fc38d-430c-4268-9be1-31ff4908c3a8"), 942674432, "0,70617855;0,25354046", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Clevelandtown, Mali", "Bogan Villages, 807" },
                    { new Guid("fc50fe3a-eb3f-4320-a0b2-59e050db9d7d"), 301137698, "0,12471169;0,9111267", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Romainemouth, Georgia", "Luettgen Crossing, 40059" },
                    { new Guid("fc802853-4ef6-4413-b1c4-0a104b7d02a5"), 2044135266, "0,59494746;0,57369274", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Zachariahtown, Niue", "Zena Road, 793" },
                    { new Guid("fd56b266-4093-4ed8-984a-1a7c089b17b5"), 60669197, "0,42253;0,027245427", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Hoegerberg, Djibouti", "Taya Ramp, 056" },
                    { new Guid("fe702839-d55d-4c77-ac05-d9787f5ea5f7"), 1156273325, "0,9500524;0,18467212", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Marcellus, United States of America", "Roxane Curve, 274" },
                    { new Guid("fe841ed1-16f7-4c05-9816-698c833a1f4a"), -1569153452, "0,30389962;0,6316892", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Blickberg, Republic of Korea", "Grant Plains, 750" }
                });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "PromoCodeId", "ActivationCounter", "BonusSize", "Code", "DateCreated", "DateDeleted", "DateUpdated", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { new Guid("00986ca6-0060-430e-8379-ae7f4cc5bb24"), 877946766, 0.1197370272525070m, "LXMrVwZKsit1yBChzpaf7kRQ5EuTP8LvNb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9770), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9768) },
                    { new Guid("00b923ee-2611-42a9-ab4b-f45e7f42ecc5"), -1456494790, 0.7176732119869290m, "3gS1zmri4WXevx5RMJ7fDtYUp9ua8L", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(744), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(742) },
                    { new Guid("030f7df8-ff2b-4c7c-b02c-0138c5b13c55"), -556463474, 0.6432722027839590m, "3E813QL5CajnDHydMfRz6uWerhP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9880), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9878) },
                    { new Guid("041fd985-03db-4579-9d29-17812cecc6a3"), 1789535213, 0.465080767386570m, "MaDdJAtwoUTB1XPqQy9KGg2xvk3F5Cn6e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9835), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9834) },
                    { new Guid("0bf3d292-a734-4985-ae80-95b411968a83"), -224793006, 0.6498894751340270m, "L4BhuAfUYotdjWT1Lpb8N5aZ2RVPMFXxye", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9157), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9156) },
                    { new Guid("0e9e9f53-6106-45e7-a390-a9a5ebd58241"), -729978498, 0.5983226133839060m, "Mn6mho5sAdNSfirQHYkz27buXEJDwy1W", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 277, DateTimeKind.Local).AddTicks(9934), new DateTime(2024, 6, 2, 23, 23, 8, 277, DateTimeKind.Local).AddTicks(9932) },
                    { new Guid("0ee77169-4d99-4b09-81db-6c3a8e9a389d"), -1949972366, 0.2835222026885410m, "LhbkUGcfzZHqu4RPwme59Lj1A3v8QDtF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9850), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9849) },
                    { new Guid("130b5cbd-da33-4062-826a-92595ae17e4d"), 69384514, 0.1871339584237950m, "Lz5Wgf7v4Ucsrjhw2DqiT68RCa3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9104), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9102) },
                    { new Guid("1b4e6507-834a-49f8-bad8-1d3fe7b614cb"), 1004205018, 0.3922019679327490m, "L9EYf4tG8XzB1HuWQ6wZCR7mMTsxojvF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(450), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(447) },
                    { new Guid("20830bd9-0967-4ef8-a2e2-ec75b89e2c37"), 928177119, 0.1868842616958630m, "MkMFGE8KWqRwJHvfepN32nYZVsB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 277, DateTimeKind.Local).AddTicks(9915), new DateTime(2024, 6, 2, 23, 23, 8, 277, DateTimeKind.Local).AddTicks(9914) },
                    { new Guid("23af15d0-08c0-47d0-9000-f51636970523"), 1259080884, 0.3213624943376190m, "LBuvjZnmWxaSX162HyebYwGQ9zUMTJq", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(519), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(518) },
                    { new Guid("2575d51c-c3eb-4f88-a698-1c1b9b2ddf5a"), 1149083269, 0.1987623427039030m, "MMJ7F9sNrR53ZcPK4VChSEubkGAzj1vmy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9063), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9061) },
                    { new Guid("263d1d6c-644b-42a2-95b1-c13cf3a75639"), 1007149497, 0.8693776601245230m, "3FBasKP3ZfCiQre28RkNxmTEnb7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 277, DateTimeKind.Local).AddTicks(6266), new DateTime(2024, 6, 2, 23, 23, 8, 277, DateTimeKind.Local).AddTicks(3649) },
                    { new Guid("271a64e7-3a75-4634-aacc-ad698e9c43f8"), 1458522741, 0.1547784088311960m, "MEk7hZiFJ5vnpGVNA13eHu8d6gRtT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9909), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9908) },
                    { new Guid("27bd262c-5a96-48a3-8a5c-298cc9adb2de"), 777270282, 0.329076673460010m, "LvbFVxSPeYz4K6WnG2mgqwNtk51", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 277, DateTimeKind.Local).AddTicks(9800), new DateTime(2024, 6, 2, 23, 23, 8, 277, DateTimeKind.Local).AddTicks(9799) },
                    { new Guid("2aaf1855-ba53-49a3-9bc9-9bd7cab2a783"), -807530727, 0.9756496463298150m, "3hegZWyKtX6aRDzrVH12Qn9M3xf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9691), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9689) },
                    { new Guid("2d36f39e-1bf1-4293-88d7-184f1e9b8fc2"), -782233727, 0.9643707530653230m, "LAkZTCzHEMFUv9ND3Gfe4Q8ngs7xjoWytL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(615), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(614) },
                    { new Guid("314ae98b-0cee-413a-aa40-190fa1b01c9f"), -1265859769, 0.5918960449989760m, "3wVhs8azyK1qZrnSGxXeM7Nmv5ko", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9206), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9204) },
                    { new Guid("35cee295-046d-41ca-a9ff-0ef0191a49d4"), -1370952400, 0.3757343837787020m, "MbEHCo4BjYGAWqVd3L7auXcymfQN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9785), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9783) },
                    { new Guid("386e84bc-1123-4a62-a6dc-5bed830f42b3"), -1648508330, 0.3056098445132710m, "3grx6yGAoebjpEXw8YVuiPRmHkd2tqch", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(8931), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(8867) },
                    { new Guid("3d2b4a64-7daa-42f9-894a-db8a859bc330"), 1310510403, 0.2805979735382090m, "3B1kh6Jj4uiPdtTeXnrVQsWYagDwof3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9513), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9511) }
                });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "PromoCodeId", "ActivationCounter", "BonusSize", "Code", "DateCreated", "DateDeleted", "DateUpdated", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { new Guid("3edb767f-1a32-46ff-92ee-74df21b1452a"), 2045923426, 0.95863814694160m, "3qrcT3MhdvKP6BbD4o2EC8uQYgNn", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 277, DateTimeKind.Local).AddTicks(9972), new DateTime(2024, 6, 2, 23, 23, 8, 277, DateTimeKind.Local).AddTicks(9970) },
                    { new Guid("3eef3abf-4f7d-4f2e-bc3a-78f0dbb4a8d4"), 1087232174, 0.4624534163435990m, "3mPFYU7EN6LXBibSTChuR5xHKew", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9865), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9864) },
                    { new Guid("3fb2b6b3-1584-431f-9ff4-58e72a7a239a"), -429874266, 0.2370403170167380m, "LYKcjRrN234o7vqt8WFCpEDGidVfaSMQ9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9588), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9587) },
                    { new Guid("43c468cb-939e-4eea-8f91-89f88f0f5f70"), -962736095, 0.1502758479459930m, "3zEpQFs4DPbRrWZU6Ghu5HMk3gS1dnoX9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(580), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(578) },
                    { new Guid("45691c9a-22db-432b-91ec-21a8374d2a07"), -1626004677, 0.7423285612983470m, "Mx1LiFbSGJTkQdDfX8gC5YUz4vy9EmAoj", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(345), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(343) },
                    { new Guid("46996918-44a6-45c5-ac53-b8bc899b4482"), -1513377004, 0.2807814099478280m, "Lk41rSZKbeMFXAj9Qp5JE8uidvfyh", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9141), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9139) },
                    { new Guid("483fffca-41a2-4630-8923-fd7fb0c257a2"), -894317344, 0.4441964845873590m, "LaSRHuM1T9DxqGFdzvwjAtYLZiJeW2b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(96), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(94) },
                    { new Guid("48ba0274-6fac-4906-b903-f3df8b29cb67"), 1390486432, 0.6799151461415690m, "3L9G4xjzuK7kBJ3PcmUdTWf8qwyh2rtg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 277, DateTimeKind.Local).AddTicks(9955), new DateTime(2024, 6, 2, 23, 23, 8, 277, DateTimeKind.Local).AddTicks(9953) },
                    { new Guid("515b3853-8ffb-421a-bef7-3009fcf07d0b"), -120291594, 0.2463675742275710m, "LPbEVRLFjrY59ok8znXct2iUKyJ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(430), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(428) },
                    { new Guid("52bb6ea8-e5ce-454a-b17f-8bb89b12ad6a"), -101867987, 0.3211030273365890m, "L8tUouB5EanswWKP1Acx4yqi6dYv", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(652), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(651) },
                    { new Guid("530bedfb-dab5-4c9a-88bc-dce4d1284a1a"), 15365614, 0.0991163052395640m, "MJ2EKM6wgVXesYBuoW4tDR9PHA1F5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(391), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(389) },
                    { new Guid("58f95410-dd6e-4ce3-b3aa-f4488ec0f98c"), -1376740509, 0.6232361133877740m, "MG5tUeEpZ1ojy769kTdqKMabfmRFzLi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(408), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(406) },
                    { new Guid("5dfc92fe-0232-4751-ae36-8e240bf9e247"), 830826710, 0.03899442745892920m, "33uws9xT76Y4piNRmy8JaZGEMKg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9220), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9219) },
                    { new Guid("5fafb33e-14d3-40ef-acf0-17c54ee614ad"), 2080003389, 0.1737886634813450m, "39ghbe2wBs8tQNCnk7DGyqTfMEUW", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9241), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9239) },
                    { new Guid("61900db0-3f64-4059-93bd-3c96123f283d"), 1295288547, 0.7267255910276120m, "3VEs7XYA5UfxJ1Pg9QiShzkMZvrdDey", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(168), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(167) },
                    { new Guid("6238dd6d-8e72-4e12-b7dd-ac900a36c4a8"), -4476218, 0.01173152527858550m, "M1zMaDK8g4ABvZfmoCq2EJ5rsTXGFj", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(670), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(669) },
                    { new Guid("6298ec36-c8ef-426b-ae09-48bf38a2c68a"), 1275502363, 0.4470832850983460m, "LkH8htwPcVroub2ZYi7ETMU4nRd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(536), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(534) },
                    { new Guid("64e99ea4-9e33-4541-9b7f-2bc01d79d12d"), 286836273, 0.2359570989421820m, "3cu1wpqGFD9To4ySXHYzeQAKJaCjUPb7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9497), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9496) },
                    { new Guid("6705c050-744d-4029-9866-d8741c9b932b"), 1995237606, 0.5831407535774570m, "3gDCfBXMymJWGqu6t7U5Y49AaNEzv2x", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9475), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9473) },
                    { new Guid("67b13605-0510-4427-b340-12d353eb2794"), 801761652, 0.7700509955910190m, "3okJBLr23ZXFhdcYgVpGCU5RbPNuA9tvK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9257), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9256) },
                    { new Guid("67f3058f-7f71-4bf8-af75-5dad8f4ec261"), -1372221647, 0.9097946141706740m, "MGMor9SvsptU5cgRq68HkTJZPiLEQmAw", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9627), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9625) },
                    { new Guid("6a8f8eec-2799-4c76-8376-4c0dd4d8007b"), 1290003159, 0.005630895549692540m, "Mxfkw6LXV834a2YtvFsh5enEDPBpgicS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9043), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9040) },
                    { new Guid("6acad770-688d-4d76-a46b-13a339469528"), -273334280, 0.5830430455040780m, "MDPxERBqvFQy5LKS1zkWgZpUm2AhnHCfr", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(222), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(220) },
                    { new Guid("6b49359b-88f0-4d80-a16a-b5c30ba6b325"), -1714449789, 0.2718999222355640m, "LLVx2k4Xpn1QrdfCcS9P6betJuEaN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(466), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(464) },
                    { new Guid("6c0df1a4-cec2-4406-a5e5-d618aaf1835b"), 758463705, 0.4930227411973970m, "3WeHQgAGhsn74qzYECDxc3vNXbB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9657), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9656) },
                    { new Guid("6c4f7293-abea-44b8-8665-f9189d2685af"), -143082799, 0.4423089352693340m, "3zJKarRv5yjsGNLQP6WhUc9Bton1CdE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(710), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(706) },
                    { new Guid("73002ef1-6106-406d-a6ca-8b1e8386bac6"), 2121797745, 0.7898858080421480m, "3RqPxFuo7bvnYTg8L4HKScWsV9m3eaBJyQ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9190), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9189) },
                    { new Guid("74905bec-cb42-461c-a66a-660dc45aa10e"), 82546996, 0.1326129127275220m, "3na65F3NJ1kXtYbLK9BxTqhRWCme", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(727), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(726) },
                    { new Guid("75b2f0fe-ff2c-437d-a837-eff0d062b10e"), 224526010, 0.7184289154804760m, "LhX35AKEfmYuaoCp91crFWJSHGg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9414), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9412) },
                    { new Guid("777301d0-6a66-4fa2-a1ec-7315555b591a"), -409833667, 0.2834278058078260m, "3xmtfEXADRwp51Uc4FG27dHne8VQaz", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9296), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9294) },
                    { new Guid("77db4141-4efd-4a71-b869-2ceade9ec142"), -1540134698, 0.3792398212836260m, "MUrN153aeodLwDCpfJtME4qkZW2VAi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9642), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9640) },
                    { new Guid("78490cb5-c671-4b7f-aa28-9ef98031508f"), 780460885, 0.5792252905380460m, "Msjk1zmhFft5WQE9gS7cPZa8BAiqx", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9173), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9172) },
                    { new Guid("787c5f1e-486a-41cd-8183-c948d93061f9"), 1729704011, 0.7252468359249130m, "MysB59neUCXQjukmtMxqLE3NG7f1gawJ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9738), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9736) },
                    { new Guid("7a614bdb-8816-436c-8f4e-33a97564be60"), -2071811689, 0.8784781651981430m, "3D5hnfTMpVSzkKA4QxqNrv1jLBgF9oCEmu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(281), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(279) },
                    { new Guid("7cd298e3-fc76-4f9d-a78e-fecc8ff74cad"), -1013964234, 0.1155111574858290m, "3V7MQJ2uNqxb1joYigcDms9BehdywUSZFn", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9121), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9120) },
                    { new Guid("84985eca-8912-422b-b447-2de7205e8b2d"), 623344858, 0.7259802728478130m, "MbC4wpzBQL2mjkohW7rYnaxURTguMKtqH", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(484), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(482) },
                    { new Guid("8d96f8a3-9658-48b3-95e7-5856ce2f74df"), -1897076900, 0.2746306659592420m, "LeDBdLbZxUpYjcCzTFPtJh5Ngr7Gm4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 277, DateTimeKind.Local).AddTicks(9818), new DateTime(2024, 6, 2, 23, 23, 8, 277, DateTimeKind.Local).AddTicks(9816) },
                    { new Guid("8eb5c1b9-f32e-4493-8cad-93058508bd95"), 2108101730, 0.7108703355865470m, "MHe2VwcysfDPXqCQZ59vFEmhigSNz", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9277), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9273) },
                    { new Guid("8f570293-6bdc-4720-a835-328838d65fcc"), -764885314, 0.03167280278480610m, "Ld5zMVva7Q2DGJxnZqKWbeF98jNr", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 277, DateTimeKind.Local).AddTicks(9713), new DateTime(2024, 6, 2, 23, 23, 8, 277, DateTimeKind.Local).AddTicks(9704) },
                    { new Guid("94411963-e078-40d3-aa10-389c34018302"), -658103133, 0.9862331931820190m, "335UGkd8JfuRzQrvAP2xgcTFHtBw7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9894), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9893) },
                    { new Guid("9868c264-c573-4918-9c04-2b13a303009a"), 1409089450, 0.5318999383464110m, "LFcGaJQ3edfYZC5B4v2iAXMqgmuPhbUw", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(320), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(318) },
                    { new Guid("98c9938d-fbec-48ab-83d4-da676298dc56"), 68943810, 0.5538539335017990m, "33VFcJzPtvLHoKB9YgmWyf7865p", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9671), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9670) }
                });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "PromoCodeId", "ActivationCounter", "BonusSize", "Code", "DateCreated", "DateDeleted", "DateUpdated", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { new Guid("9c7052a3-3002-4c27-b741-7f8e47f990f8"), 1592257786, 0.1173529809241520m, "Mh4SBuZmwvKnFfMUtbzgyXGcTjqoDNsdx", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9397), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9396) },
                    { new Guid("9efe632d-8299-419d-a992-76309ff8fbce"), 1829756243, 0.458628320506970m, "MJtnYe6zLW3hKrsS2wxFy4VfgPBXUdGM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(597), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(596) },
                    { new Guid("9f296ef8-a913-4d56-bf6f-fd3661d87d36"), -940049883, 0.9489069787771010m, "3ar78sfV1pYJNeWcwjX4D3LQtZn", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9611), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9609) },
                    { new Guid("a1964fbd-5b30-4b68-b77b-17a7da990984"), -1031832350, 0.6424491238645030m, "L3haHSwcymkR4dTQBjgYtrUqp27x", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(185), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(184) },
                    { new Guid("a20fd51f-0c41-4bcf-9c1c-3f81f87b71bb"), -2118927798, 0.5303326067148620m, "MBNZJhKsLdgk3VjUp7Et2TWn18Hwyuf5m", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9459), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9458) },
                    { new Guid("a26b194a-ffb3-49e1-979f-77b47232af18"), -1435451814, 0.8707676194431610m, "3uveTXMy6CghWRDdfKoLJztkjp2AbsNxQ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9382), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9381) },
                    { new Guid("a6d68c29-78fa-4db3-b3c4-b99b1fe3ac36"), 1856472351, 0.805922273542290m, "L32QfgG1PLJTohcESHVA8MZj5i9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9366), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9365) },
                    { new Guid("a824f70c-5947-47d5-a183-ffff463f4b59"), -1481331840, 0.4027488123107260m, "3Gsfh4yRYmFrjXDKZuzp2NJwv7SAW", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 277, DateTimeKind.Local).AddTicks(9771), new DateTime(2024, 6, 2, 23, 23, 8, 277, DateTimeKind.Local).AddTicks(9770) },
                    { new Guid("a90c17a5-755e-419e-ae3f-8dced8eb9ec1"), -1021184390, 0.1443568556430650m, "MQWqVm4S5RPf2tbhU9yXzFwLkn1Tr", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(149), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(147) },
                    { new Guid("b0d40a46-b53d-42f0-ad17-f9a243034af5"), 181928218, 0.1744061286136170m, "3QmvrkEUy6MRKoNYA75PS4hqTj3sHg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9819), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9818) },
                    { new Guid("b12319ff-d5a6-4eca-ab37-f1f1fdd090e0"), -1712212282, 0.08212730291267440m, "LGQrbSHZLPvkhKtB7fN8Wjq1U64Rzg2dXy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9326) },
                    { new Guid("b7e78115-07e8-4be3-9fd7-1600fb5560f9"), 1765168757, 0.7041775946200570m, "36Dq9cEUTo8fNbzgZdY5JWLupiheVyP7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 277, DateTimeKind.Local).AddTicks(9870), new DateTime(2024, 6, 2, 23, 23, 8, 277, DateTimeKind.Local).AddTicks(9868) },
                    { new Guid("b8233739-7ec3-4f90-b045-08016be374af"), -801211076, 0.912926873685770m, "L1mzdHUxJb2aTrnqABVEMSKpRwZP6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9721), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9719) },
                    { new Guid("b9513041-bf13-4c51-a0e1-a2b2ca312e32"), 2145347073, 0.8529914104604180m, "37MGqPsoDQzXmnW68ydcphZBA1LH4NiwU", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9753), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9752) },
                    { new Guid("c293f160-1503-4d76-96b0-3cdcf89feb84"), 1414813075, 0.1615115048257110m, "L5kWD9bmf68it3Vn4jY1ARNLzhsSgax", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(687), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(685) },
                    { new Guid("c4b02be8-70cd-478f-8394-483fda63a7c4"), -688810948, 0.4850897206530710m, "3MQApYL6TkD5U41HqdV2Ww78RxciebnBJr", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9081), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9080) },
                    { new Guid("c75fd901-fd64-4c4e-9d18-de23cebecb44"), -1695678002, 0.01309706562063230m, "LESpbzWLgm1yT6MerjohuqXCt8RGn", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 277, DateTimeKind.Local).AddTicks(9739), new DateTime(2024, 6, 2, 23, 23, 8, 277, DateTimeKind.Local).AddTicks(9737) },
                    { new Guid("ca18a626-35d4-4bbd-b354-94835f4ae61b"), 488143558, 0.1864478775255180m, "3Yzby8BLesWZxKVnorvAg2DuMSJ135", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(204), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(202) },
                    { new Guid("ca19d085-a2d7-41e1-8746-7dcde135b223"), -722262094, 0.02613968731314010m, "LftBkL3mYhPsrSU71uQZWFzCjJADy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(261), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(260) },
                    { new Guid("cb121444-a460-43f8-bcec-b40fe4edecbe"), -980968256, 0.2193848079332220m, "MLsneAf7t8TGRKhxXu6MPmoNray1qi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(552), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(550) },
                    { new Guid("cded10f0-7a52-401e-9a7b-69e485c1e9a6"), -1693700630, 0.6178940309719170m, "LGvSVW2cs46ZxXMBdJamr7e3ofYHyiD5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(503), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(501) },
                    { new Guid("d382371b-33f7-4393-8af8-10e1e3ec89a6"), 893512349, 0.8953897667906310m, "3ZWjnJHuUCR529VTePgz6trBNQGa7EMi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9707), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9705) },
                    { new Guid("d3ff9109-17ce-4f64-aeaf-313050cf5999"), -2126793831, 0.9369872683798680m, "MRCJYhubmKE2dxMqp8ZzngyjsHv3aVrfc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(114), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(112) },
                    { new Guid("d579a952-06f7-4580-8c8b-09c5d5dece7e"), 1237407244, 0.4903486531626880m, "3ZiMT12PV8trNzhmwjqKv3a9HS7cyxo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9428), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9427) },
                    { new Guid("d9b12bfa-6fbc-4c8b-8ac6-27a2a2bbec18"), 837446028, 0.3026393028962990m, "MjRvx2L3mkqrN1F84JMCVZ7GPoneuTQhK5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(299), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(298) },
                    { new Guid("db545703-ca7a-40f4-a3f7-854bbf4c0498"), -1566589188, 0.822803238761760m, "MZMW1QYcrVbJETx5hijzLNsC6foq2Ha8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(633), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(631) },
                    { new Guid("df00a113-5b89-4450-8c21-799f77a8e366"), 2007225967, 0.1180588780129050m, "L6iAtT8rXb7cLdphzCjgvZqQNKYoV", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 277, DateTimeKind.Local).AddTicks(9894), new DateTime(2024, 6, 2, 23, 23, 8, 277, DateTimeKind.Local).AddTicks(9892) },
                    { new Guid("e0979182-16b7-4e7d-a6cc-3b6317c0d5b4"), 16025590, 0.9943918164019640m, "3DZPM8aQovy7NSRg56wGBV93the", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 277, DateTimeKind.Local).AddTicks(9851), new DateTime(2024, 6, 2, 23, 23, 8, 277, DateTimeKind.Local).AddTicks(9834) },
                    { new Guid("e16d4cd4-82d5-4b55-bd21-41badf4b7ddd"), -16492597, 0.6342679237617480m, "MXyMKwbt2TWokEvgn4FHhJ8rQds6VL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9444), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9442) },
                    { new Guid("e2ac638c-071c-4e3d-a6e0-32d1a1c4a840"), 909345816, 0.9825893050792780m, "MoSdjtcnTm75zN9fZvhEbGkwKq3AYeMCBH", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 277, DateTimeKind.Local).AddTicks(9643), new DateTime(2024, 6, 2, 23, 23, 8, 277, DateTimeKind.Local).AddTicks(9616) },
                    { new Guid("e59ad964-f4b5-408b-b749-81fa8e318c19"), -68080562, 0.266768600504950m, "3SAQ7nxHYh8qw4M5pyKPtmTbveu2EU3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(132), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(130) },
                    { new Guid("e8b57133-a00f-496f-aa8d-b6cf54054b4d"), -767994745, 0.1109843418112710m, "MTRiQgwVHetuB5PYhyWC8qS9obX", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 277, DateTimeKind.Local).AddTicks(9992), new DateTime(2024, 6, 2, 23, 23, 8, 277, DateTimeKind.Local).AddTicks(9987) },
                    { new Guid("e916c69c-d36e-4281-aedf-3c9dec80afb2"), -558821686, 0.1121271527739440m, "Mc2KXD6oikpt1N5xFZg8hybdWGvs4rR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(69), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(68) },
                    { new Guid("f11a586d-8dd0-4590-b1d3-25b70e8426c1"), -2008709925, 0.7100544646060m, "Lyv8nUs6hSFDWawb4Y2r7dJGRBToxK31me", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9344), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9343) },
                    { new Guid("f34de1f1-9d7b-4616-a3c2-ae2fefa33a84"), 1106228785, 0.03548678309786190m, "3r7kGK8YvT2QioA1wDd5CHNLJtuEpRV", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9312), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9311) },
                    { new Guid("f965e4ab-271c-4960-9255-fac5a35329f0"), -1659669350, 0.6043377832156190m, "MPMjAFwDtV1zZ2oCyLURc48sWhE75briNK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9800), new DateTime(2024, 6, 2, 23, 23, 9, 490, DateTimeKind.Local).AddTicks(9799) },
                    { new Guid("fcf09ec1-0ee1-47d1-bc83-8bc9f085b393"), -1428402209, 0.7292111131758020m, "LKrTgqcdjvZhHPpmUtsEGJWNY6RX", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(244), new DateTime(2024, 6, 2, 23, 23, 8, 278, DateTimeKind.Local).AddTicks(243) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("013a7602-b915-4485-89ea-d3291ed9cab8") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("01a8f276-3a4c-402e-98b4-c3b9dba05f91") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("02df2ae2-d7d0-47a4-aeae-e733e06bb1d0") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("0397b496-e66d-4ab5-942d-0a53948ef201") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("03a04e64-e8f5-4db8-ae88-e45982174d32") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("0639ab22-a867-435b-8c5b-7acf69750583") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("0768641f-3440-4d72-a350-3b2eca842a26") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("086d4f1c-510f-4c8f-a495-d7e8fc340ecc") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("092e31f3-9b9a-4287-8cae-7fcd18feab47") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("09465da9-1c65-4a00-be4f-5b7144e699f3") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("0a69540b-ce9e-427c-8970-9f311fba0c21") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("0b440e9a-ee26-43ee-9d40-46328f22a228") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("0ffea79c-1eaa-4ef4-b27f-e6c525534682") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("10a10ed0-e1f4-4de7-b631-e8c7d0d5eaa9") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("11ddb06c-1f4a-4028-b37b-6ad05ae5f7d5") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("137b1e19-3c26-4708-9428-159387ebcd43") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("146a249e-e614-41cc-98ab-d6287da977e5") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("1546f9ad-e76e-4438-9513-2c0cdbcdc9dc") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("1546f9ad-e76e-4438-9513-2c0cdbcdc9dc") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("15cc8bf6-f5ac-435e-a654-84e10e29a1bd") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("166bcf97-6b8a-4025-ad11-df15241b0a24") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("16dfe9db-9389-4852-8b69-53610d60b359") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("17441686-0fa5-4e5d-b680-2d5708a2ecd5") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("17441686-0fa5-4e5d-b680-2d5708a2ecd5") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("1747bd38-8325-47e2-8876-f2ff552a55c8") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("17b956d2-133d-4289-8a76-4633e194bce0") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("17b956d2-133d-4289-8a76-4633e194bce0") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("18314b53-d5e3-48fa-8ad6-dc84c3baa1ff") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("18314b53-d5e3-48fa-8ad6-dc84c3baa1ff") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("1c5135c6-32f4-4363-a0a3-5a8fb7357df1") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("1d118b7f-07b1-49dd-9f7d-5a1e7d8ea4bc") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("1d118b7f-07b1-49dd-9f7d-5a1e7d8ea4bc") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("1e47206c-cbc9-48ff-becb-ea5c84ec9719") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("2063153a-a610-4c40-9ddd-456ef0b560db") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("222dda98-6fd2-4619-8709-1b78c7872ca8") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("222dda98-6fd2-4619-8709-1b78c7872ca8") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("22c74cee-2548-4aef-ab56-019f64d2fb3e") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("24b96e86-5860-47b1-a6ec-9a832bafbb14") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("24b96e86-5860-47b1-a6ec-9a832bafbb14") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("259e3939-18d5-4998-98ae-345c9d0fa279") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("25a47446-d397-4805-8427-d3185a6d35b7") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("25cda556-70c4-4bb2-ad33-871e7ca4939c") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("26ad372f-ab3d-49d6-a283-d78f71a0b97b") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("284afcd2-63de-4550-906f-0a1ce11e8244") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("2a328a80-898f-4b62-921d-731137bebe9f") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("2a9b395f-43a6-4c12-8ee4-3f4db5f26f9d") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("2eb253e8-852b-4b59-bbd3-41b1d962644b") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("2eb253e8-852b-4b59-bbd3-41b1d962644b") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("2f7c84d9-6fe2-4a1c-ba84-c8d43feade58") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("34d672c5-050e-4c3c-8018-0107a72f13f5") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("34d672c5-050e-4c3c-8018-0107a72f13f5") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("359f112e-4dd6-47fb-995d-9dae092d143b") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("3705daaf-a245-497f-b245-acd05a008711") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("37432efe-ddf1-4f3f-9753-a8b4a9e54500") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("37432efe-ddf1-4f3f-9753-a8b4a9e54500") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("3a8ff431-6524-4268-ae59-91f87b944fae") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("3aa0613b-0255-46fa-9fc9-f73e67ec6962") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("3aa0613b-0255-46fa-9fc9-f73e67ec6962") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("3ca63884-385c-4ae8-ac07-f3dc2df24aae") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("3ca63884-385c-4ae8-ac07-f3dc2df24aae") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("3dc1a6db-3bf2-4650-b501-abf7ef284b3c") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("3dd4bd2a-4dd8-4988-867a-99041eb6851d") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("427485d5-0faa-4f9a-9c6f-70317d50831a") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("437bc41c-af0d-4443-809f-276b155b8846") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("437bc41c-af0d-4443-809f-276b155b8846") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("43b84c41-ad8c-49ff-ae3a-561f6d21e04b") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("43b84c41-ad8c-49ff-ae3a-561f6d21e04b") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("451f756f-99dc-4563-9d9a-db92f4a114f0") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("4883913c-7591-4093-a019-7e3dd870d152") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("4952ad1a-3fe2-4d0a-a38e-1e28e3808afd") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("49922094-de40-49f9-8fe5-21e734ddaadc") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("4a254852-2316-4300-99be-6d54e3eeac93") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("4ae96a4e-92a4-486e-b7ce-61d3f2fe842b") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("4af7ff34-3014-4da9-ba8e-e93cfaac4eaf") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("4bb403d4-8670-466f-a9dc-17dd09c9d546") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("4bb403d4-8670-466f-a9dc-17dd09c9d546") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("4bfa50d6-7b76-402d-afe8-4b558ee6165b") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("4bfa50d6-7b76-402d-afe8-4b558ee6165b") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("4bffa9b9-a7ae-4dd6-b87b-dbcad3737bfd") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("4ccb797f-65b1-4b8c-809c-fe110c01052b") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("4d65579c-7caa-4a73-aec4-ebf5de2054ab") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("4d792f39-989a-48bc-8528-2bda17a5967a") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("4d792f39-989a-48bc-8528-2bda17a5967a") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("4e8bea3b-5b3c-4c9c-b874-2c8b16d90db2") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("4ec972f7-f6d0-4660-943e-5ad3d2557cfe") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("4fb2390c-a600-4f3b-adfe-f73867978239") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("4fd873ab-a800-46d0-959f-d9f6189c846e") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("51655f73-efc8-4142-b1ea-1657e4fc0f2e") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("52010289-102f-414b-8fb6-a09a575f22a0") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("52c54e9c-3d8e-429f-ae95-d180e2ec5a1d") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("5441f683-8cec-4fb5-96c6-2fa82e7997d3") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("5441f683-8cec-4fb5-96c6-2fa82e7997d3") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("551cb7a5-2acf-469f-be65-7a549dccf51f") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("552898bc-d86c-4567-80c9-bdb93739cab5") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("5560fdd3-3041-418a-bdbd-b1b7cb595a87") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("568a5cfd-171b-413d-addf-fe6ab58aa6d0") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("568a5cfd-171b-413d-addf-fe6ab58aa6d0") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("57041776-9144-494f-9e92-9c9da3135eab") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("57d5c043-44a4-43bb-80ee-1cbb791b2285") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("57d5c043-44a4-43bb-80ee-1cbb791b2285") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("58fc780f-3b29-4947-a319-3ed8b421144e") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("58fc780f-3b29-4947-a319-3ed8b421144e") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("5a13878d-22a4-47a3-8eb8-3f4be375baee") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("5a6031a7-d008-4d4c-9a87-857d42759454") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("5c31a07d-9e1a-46bb-9c88-2f881f607c52") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("5d6854b6-463d-4c99-844f-2b03c65e196b") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("5d6854b6-463d-4c99-844f-2b03c65e196b") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("5e0e0eed-1c83-4b51-8938-5bab69316dab") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("5e2d266d-c2a4-4711-b57e-3656b61d6ad2") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("5effd297-ddf3-4f40-afed-c85e49e3d248") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("5ffbbdb6-b588-4eef-811a-4b39d217f0a8") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("5ffbbdb6-b588-4eef-811a-4b39d217f0a8") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("605efc2a-1846-428c-a520-3c8efbd1c5d8") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("6172d849-4ee5-486f-8f97-d2bbcfc40084") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("6172d849-4ee5-486f-8f97-d2bbcfc40084") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("620337a7-cc3b-43d5-aef4-5b29e97ab466") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("62f9c608-cb23-46fa-a1c4-304e5c65aec1") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("6375150d-9633-494e-ba79-b55f87d56afa") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("63bd6aad-fd4d-4a2d-b0ee-341253297e79") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("63ce22ac-8a36-4fb9-bf6d-61e02101f5d7") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("641c3d4a-a6ff-4cb3-b40a-665b9156a255") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("6507f7f4-4076-4fff-b89e-4205b52b6408") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("655cd6fe-206e-4683-a0e5-f0108ee7f59f") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("655cd6fe-206e-4683-a0e5-f0108ee7f59f") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("6709762d-580f-4c32-8f92-b1daa6e22c27") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("6709762d-580f-4c32-8f92-b1daa6e22c27") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("68fd726f-e5e4-4755-a477-4727a0a9f4b8") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("69536a6d-5fc0-40dc-96ff-96cfa2e2ddde") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("69536a6d-5fc0-40dc-96ff-96cfa2e2ddde") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("69879006-dc0c-45ee-a1d8-571618a19f4d") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("69879006-dc0c-45ee-a1d8-571618a19f4d") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("6a6686d3-6711-42f4-b08b-ada2bf39be54") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("6b62d633-8ccd-4aa4-82e7-a8336a9e5760") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("6b62d633-8ccd-4aa4-82e7-a8336a9e5760") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("6cbb9172-2b78-4f00-a841-8a1e6d6be79b") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("6cbb9172-2b78-4f00-a841-8a1e6d6be79b") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("6db49be1-1b9b-4fd0-8b2d-52ae151f7432") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("6dcb62c8-dc29-4e18-aabc-b9f4d6f3d1ce") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("6ee9a7d3-8695-4b4a-9a7f-e035a03a4cc3") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("6ee9a7d3-8695-4b4a-9a7f-e035a03a4cc3") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("708b56dd-a529-4229-82e2-2266f01c7942") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("708b56dd-a529-4229-82e2-2266f01c7942") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("70c04dec-2a46-4304-b6d1-c42204afdab9") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("716e3b4a-4381-424f-88d2-df0753a8cb13") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("71ef850e-2fd5-4538-9b05-9c38cbbdbe30") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("72b9b70e-980c-47d3-a949-0b0acbdbe9f3") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("73850497-d7e2-4015-bf80-d8fc761772d3") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("73850497-d7e2-4015-bf80-d8fc761772d3") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("73977b0d-a6cb-4576-bd4a-b7056acdccd3") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("73aad8c3-cbed-4125-b80b-7db0735c3ac6") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("73aad8c3-cbed-4125-b80b-7db0735c3ac6") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("749d009d-0557-4289-976a-50a7e345a281") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("77332645-fb25-478f-998c-36dd38aaba91") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("7771e104-7d9f-4097-8375-a33ad264e1d8") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("7771e104-7d9f-4097-8375-a33ad264e1d8") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("777e0877-9079-4ecc-a52b-f0bf5734b939") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("777e0877-9079-4ecc-a52b-f0bf5734b939") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("7805e438-4982-4f20-9e68-baca0c631417") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("78615ad6-0a03-477e-a515-c98b1a96475d") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("78615ad6-0a03-477e-a515-c98b1a96475d") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("7889ec96-3dce-40c9-a3d9-1dabf9642602") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("7902b014-f441-4bad-a55f-7656352c84e7") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("7b354f95-20a6-4d69-abe1-b5a212feb069") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("7b354f95-20a6-4d69-abe1-b5a212feb069") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("7b9acf5a-1eec-4436-8152-103e38ca0953") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("7e5e5ebc-3d4d-451a-884b-00a9d9f53676") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("7e5e5ebc-3d4d-451a-884b-00a9d9f53676") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("7f910a03-763a-4cdb-bbcb-8241bae6fc96") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("7f910a03-763a-4cdb-bbcb-8241bae6fc96") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("83521c38-fd64-4bbe-89bf-e217d9771096") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("8513debb-cacb-47df-a4d3-e59f2a261b69") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("857e5ff4-368c-45c8-909c-9cb05ea33802") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("859757d1-9ad7-45f4-8664-764e0db29fec") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("8606d3d5-5f3e-4f9a-b953-4be892f06c0d") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("8606d3d5-5f3e-4f9a-b953-4be892f06c0d") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("86139076-e779-453a-8f87-64e1bfeeeccc") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("861c20c6-b2fe-4d03-a2b4-ae2380f7edc5") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("872eccf4-a3fa-43c5-ab2e-ac6f6c9e4f17") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("88155035-c6f4-450c-bd25-3d3e9c9d8f5d") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("8892b0e2-0aef-404c-8681-2866126b786f") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("89c19062-b085-4717-8960-680ec5f619e0") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("8a1cc6ac-cbbb-45b8-a858-79df665cbf01") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("8a1cc6ac-cbbb-45b8-a858-79df665cbf01") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("8adfe810-a4af-41ad-bda0-c1898bdb4d92") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("8adfe810-a4af-41ad-bda0-c1898bdb4d92") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("8bbc87aa-2bdb-4898-83a2-ca540a697ac0") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("8bbc88c0-c35c-496f-b3fc-e18f3d8bad18") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("8bbc88c0-c35c-496f-b3fc-e18f3d8bad18") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("8c7f5100-7603-4d85-9e37-fba6a586f7c8") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("8c7f5100-7603-4d85-9e37-fba6a586f7c8") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("8dd6a489-4514-4244-9fa7-a1490970f38b") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("8e832b0b-a138-409b-b85d-4b68d03a07b6") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("8e8fd0f7-2809-49f2-9c1e-cbeb885b2de7") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("91024531-3bc9-4397-868c-67a81b4abcfc") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("91024531-3bc9-4397-868c-67a81b4abcfc") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("93ac31b1-6465-45d3-b0b5-98811dbc77b4") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("93ac31b1-6465-45d3-b0b5-98811dbc77b4") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("93b22657-e430-4b16-b1f2-af9b44bd9175") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("94e92894-3b19-4c5f-9e95-0ec52116ec92") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("94e92894-3b19-4c5f-9e95-0ec52116ec92") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("960fe293-a56c-42c1-b68b-57d1e361fe6d") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("96357562-82d6-4394-b4bf-5b698e1ad612") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("96357562-82d6-4394-b4bf-5b698e1ad612") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("96389a1d-3bc8-465b-ba35-3027877a9981") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("96389a1d-3bc8-465b-ba35-3027877a9981") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("966d5ef1-e601-407d-86be-887c8e79a449") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("966d5ef1-e601-407d-86be-887c8e79a449") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("967d4ff4-7cca-4fd1-a75a-2f73aca9ca0a") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("967d4ff4-7cca-4fd1-a75a-2f73aca9ca0a") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("97c89012-688a-4d00-9708-03d8cb08dc2e") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("97d70a43-949c-4c03-9da7-fc16fdc0c86d") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("98222b1e-1352-4ac9-8c47-69a7f0582ef6") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("997402b2-514c-445f-9988-ae18a101181e") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("9a38b671-5580-4658-abf4-c1fc9ce2be0b") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("9a38b671-5580-4658-abf4-c1fc9ce2be0b") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("9a799371-7ad4-44c8-bcc3-759981e1573a") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("9a799371-7ad4-44c8-bcc3-759981e1573a") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("9b0c9ef1-c568-4fc6-8e02-cbbb959e0bbb") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("9b0c9ef1-c568-4fc6-8e02-cbbb959e0bbb") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("9b8fcbcf-ce9d-40cf-aa2a-0543ebe6f135") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("9b8fcbcf-ce9d-40cf-aa2a-0543ebe6f135") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("9dafc6e9-0e56-47f8-8b8b-4ca541841bd0") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("9e4f824d-b29a-4ec5-b3a1-111d46f41ecb") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("9e4f824d-b29a-4ec5-b3a1-111d46f41ecb") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("9e73d492-68df-4c26-bbd7-c238340416ec") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("9eb02965-fa79-4bc7-940e-eff714a39f7e") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("9f317a02-0a11-4f32-b538-7ec5c02e4b5e") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("9f331cb7-b70d-434b-bc28-147a5e624fd8") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("9fc4b18c-b710-43c3-be29-ffdea2c51975") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("9ffccffc-cb42-46e5-86d7-6730697facf3") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("a01a13e5-a8d1-4048-b8b2-24cdfac5f11e") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("a01a13e5-a8d1-4048-b8b2-24cdfac5f11e") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("a13d28a1-8900-4b0d-8399-27cc466b719f") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("a161bc80-bb44-439e-bb80-442569d93b23") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("a165efc8-0956-4593-9333-e1ab17939488") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("a165efc8-0956-4593-9333-e1ab17939488") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("a3564d73-cc7f-45bf-bb8d-5bff9f9bd319") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("a3a7c05f-2de2-47a6-9d73-3dc95cb0a4bf") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("a4b4b14f-6b7f-4104-b0d2-b8f55417f1e7") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("a64a13ca-2754-4769-a254-32716c64c908") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("a6b4e3da-0d2b-4dbd-9f10-ea183f9d6225") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("a6fc0423-6291-4866-8d02-6faea1986c4e") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("a6fc0423-6291-4866-8d02-6faea1986c4e") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("a7a63c10-9b55-47c6-9d56-8793ee29aafd") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("a7a63c10-9b55-47c6-9d56-8793ee29aafd") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("a8a8fdd8-4ded-4cee-9b8c-87f2285d7eab") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("aa053e12-232a-4d5d-8b1f-0803fd8b7767") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("aa1380ad-62cc-4108-817a-4ac56a2c382d") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("aa1380ad-62cc-4108-817a-4ac56a2c382d") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("abf3ceb3-3421-4454-9686-7b4c13cd1fbf") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("abff8b44-2e47-47cd-8158-cb029242cf8c") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("ac2d4745-386c-4c13-a217-d9e2d9b842df") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("ad53394d-1d27-416a-92bf-5074f6fa4fc4") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("ad53394d-1d27-416a-92bf-5074f6fa4fc4") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("aee768a4-2b67-47da-a692-ab2b1cd95c27") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("aee768a4-2b67-47da-a692-ab2b1cd95c27") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("b070b87c-5a28-4f27-8f54-9238dfbe5c79") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("b2a11489-a556-462e-9631-1108d9049fcc") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("b3997a22-bce6-473b-9a56-6baca1b5ece7") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("b44b2dc0-6e21-4d7d-a788-6c4e66d96402") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("b4e4db54-4f23-4365-96a9-cb8bd3cdaecf") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("b4e4db54-4f23-4365-96a9-cb8bd3cdaecf") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("b50df756-e4ca-4115-a962-e283f6b8d317") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("b50df756-e4ca-4115-a962-e283f6b8d317") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("b5fe6c30-5f2d-462b-9dd2-bc5388f99ce5") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("b67eec58-0f42-4a35-a871-09c1ddaddd4b") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("b71f69da-e20d-4b25-b2fb-00d5eb1c9002") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("b944ae23-efab-4fcb-bda0-6be21e2add96") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("b944ae23-efab-4fcb-bda0-6be21e2add96") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("b9974b20-5b3f-4445-a6d7-c4352b53a64c") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("b9974b20-5b3f-4445-a6d7-c4352b53a64c") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("bcb5583b-3b55-4ea8-b016-f74baf89e99a") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("bcb5583b-3b55-4ea8-b016-f74baf89e99a") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("bd5c667b-2bfc-46c6-814e-7b5c93be8f43") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("be18d868-cfef-46af-89ea-769a3c24c7da") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("c0ce8022-4a58-4c92-9e84-7f2ac0c9caa5") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("c0ce8022-4a58-4c92-9e84-7f2ac0c9caa5") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("c1dedd78-34a2-4542-a585-a6ba740f5856") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("c1dedd78-34a2-4542-a585-a6ba740f5856") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("c311c4ad-bbcf-418b-8259-eec5ae72eb71") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("c311c4ad-bbcf-418b-8259-eec5ae72eb71") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("c3a4c71d-a9ab-475e-9d5b-425a5d31fb48") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("c3f40de8-9c2b-4f97-b99a-a3d5f6431b27") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("c3f74963-e8a7-4598-bde6-0b7eb8dc16d8") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("c431ef46-de70-4dba-a2b4-061b2a219ebc") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("c4c17769-48f5-471b-ac8e-87a2c17573b4") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("c50f147c-0804-4f38-a70a-7b8d4109234d") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("c561cc5e-190d-4a91-8ea9-d03583fa3f86") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("c60620ff-d62e-4585-9510-ed612aa89dcb") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("c798d3b3-ea5a-4b3b-a69b-7022aa64fe86") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("c8db4c48-87fc-43bc-b9ef-e88e6764800d") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("c9de1952-448f-4a77-a4fa-b78a3751957a") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("ca7879c0-456f-4a95-94ad-0a58b61bfc27") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("ca9a7100-5d5c-406e-8028-d065cd21c772") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("ca9a7100-5d5c-406e-8028-d065cd21c772") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("cb8696d4-d2d5-40c3-b74f-38aafecd34f8") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("cb9544f8-58da-451a-a24e-9ef9b8265d20") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("cc549d3d-c127-48fe-9320-69c0367cf0ef") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("cc549d3d-c127-48fe-9320-69c0367cf0ef") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("cd3bba51-ecbd-472a-a962-7f603574b446") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("ce4c448e-35a5-4243-aa12-b967d2b3da6f") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("ce4c448e-35a5-4243-aa12-b967d2b3da6f") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("cefdf373-98f4-432b-bfc7-baaf121c554a") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("cefdf373-98f4-432b-bfc7-baaf121c554a") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("cf6839a1-51b8-4ec5-bfec-3cbe48c20160") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("cf6839a1-51b8-4ec5-bfec-3cbe48c20160") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("cfc77b46-5660-4e53-bd9c-0ef309097b43") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("d0627291-bbf2-408e-bc02-9ba09faa06bd") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("d08dab84-c369-4193-b4fb-bbd252c59cc5") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("d0fc0768-b3a0-4f82-affc-e355dc4101f4") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("d184b2bf-159f-4b4e-83e0-4f0bb6184d14") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("d1fdc728-523b-49bf-b2d8-eee9a8bb93d1") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("d1fdc728-523b-49bf-b2d8-eee9a8bb93d1") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("d368ec62-a4a6-47b3-a955-fb176a32fe20") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("d4409d83-a792-488f-bea4-9e1b42950fc9") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("d5f398ce-f08b-4d20-af17-603089eb45ee") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("d666c5aa-5c03-4391-8629-5cc681422ca2") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("d8361619-ae4f-4db1-9eb9-291e4814a381") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("d8361619-ae4f-4db1-9eb9-291e4814a381") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("d8dd96ce-4557-4993-959c-45a29c967d51") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("d9295c19-5c11-40bb-ba7c-c1b368114ac0") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("d9295c19-5c11-40bb-ba7c-c1b368114ac0") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("d9fc54cb-e30e-4a48-b749-08ff99fcff26") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("d9fc54cb-e30e-4a48-b749-08ff99fcff26") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("da687a7e-bca5-449f-ad43-32e0ac00fe15") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("da687a7e-bca5-449f-ad43-32e0ac00fe15") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("db79e848-cfae-4c0f-8859-e5d6af4a311c") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("dc04df94-1448-4899-bec4-692b13ea2748") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("dd2a73f4-0d43-45df-8aa0-196122e00fc2") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("dd2a73f4-0d43-45df-8aa0-196122e00fc2") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("dee746db-2712-4366-98c6-517b826fd421") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("df250436-821d-48ab-9508-ab3df0550e27") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("dfa0bf0e-13dc-416f-bb54-aaeb47a68545") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("dffee49d-d296-4315-aefd-9602dd01358c") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("dffee49d-d296-4315-aefd-9602dd01358c") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("e1223f43-016e-41f5-b212-ab70a0ac01e2") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("e188b38e-8056-446d-96c9-b8979c4fd471") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("e27f9603-32f8-4066-bf07-4ab692c8350b") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("e28ae980-81b6-4d5f-8748-b7cb3f0f995d") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("e2dba597-b132-4b1a-a46f-540ebc581408") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("e2dba597-b132-4b1a-a46f-540ebc581408") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("e44b1f8c-951b-48de-a206-672ce80e3e29") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("e58d2261-638d-41ed-b5bf-55b3a94546e1") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("e6b167e1-2f8a-4aa9-b766-dcb40c4c65b7") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("e6b167e1-2f8a-4aa9-b766-dcb40c4c65b7") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("e7414a92-a2c0-4cbd-a0ca-3a6c538ac8c6") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("e807eb16-5caf-4274-9ff7-5027ed83325c") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("e9781110-3553-481f-bb3a-7ca26a63a83b") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("ed54e83f-5702-4289-98fb-949b73140a47") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("eddb3b35-4415-4828-97b3-fd737f127090") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("eedd859d-8af5-43b7-8938-5bce7dd89153") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("ef100efa-deb4-4516-9a15-38df8ff7e396") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("ef14d144-d1c3-49fb-9e25-1889be79f4e3") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("ef14d144-d1c3-49fb-9e25-1889be79f4e3") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("f044a50f-e46f-4992-b8ae-47aa00e79d4d") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("f044a50f-e46f-4992-b8ae-47aa00e79d4d") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("f17c05bb-245d-432b-9116-f181ecbd16c6") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("f472d28b-1df9-4c84-8ceb-3254f55042e7") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("f472d28b-1df9-4c84-8ceb-3254f55042e7") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("f4d9bb48-d87b-420c-b2ef-f724726c7a08") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("f54b6d8e-36d4-482b-83f6-69bd802b2ec3") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("f7f7b1e1-146a-4f33-9556-99419aa87dbb") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("f7f7b1e1-146a-4f33-9556-99419aa87dbb") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("f9c15c1c-b6bd-46fd-921b-e1778f14dacf") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("fc15fcf7-014b-4521-910c-8a4a05ae7df9") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("fc2635e7-fbe6-403c-bcdf-dc9a65be3352") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("fc7807f7-2e15-4c19-8500-ea40f337d9de") },
                    { new Guid("ce2d0037-321c-4056-80a4-025542724aa7"), new Guid("fc7807f7-2e15-4c19-8500-ea40f337d9de") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("fd6ebc44-c70c-4ea5-ad8a-6029ee9c49d9") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("ff75563e-5545-46de-a4b3-3e0727d74698") },
                    { new Guid("4c928d3e-1f34-454c-80bb-2af80fa5a230"), new Guid("ffdf2e3d-14e1-47fc-a87f-43ee44597c72") },
                    { new Guid("85b2dc1e-858d-462d-a0b4-51896efb5ea0"), new Guid("ffdf2e3d-14e1-47fc-a87f-43ee44597c72") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("0030eb0d-22cb-44f4-ad59-98685be3d8d4"), null, null, "Sven_Luettgen34@hotmail.com", new Guid("5c31a07d-9e1a-46bb-9c88-2f881f607c52") },
                    { new Guid("006fe896-8585-4338-bb35-3883958e24ca"), null, null, "Shayna_Kiehn@hotmail.com", new Guid("ad53394d-1d27-416a-92bf-5074f6fa4fc4") },
                    { new Guid("00813eaa-f710-4130-9877-4dd643c5d708"), null, null, "Lori.Marks@gmail.com", new Guid("2063153a-a610-4c40-9ddd-456ef0b560db") },
                    { new Guid("0083ed1c-8940-4743-8306-48235d675329"), null, null, "Karson_White@gmail.com", new Guid("2063153a-a610-4c40-9ddd-456ef0b560db") },
                    { new Guid("00cb60c2-02e5-46a3-879c-a56f9026b662"), null, null, "Rupert26@gmail.com", new Guid("fc2635e7-fbe6-403c-bcdf-dc9a65be3352") },
                    { new Guid("0143bbc9-d232-4124-b231-3c25f8ab4638"), null, null, "Hillary38@yahoo.com", new Guid("e1223f43-016e-41f5-b212-ab70a0ac01e2") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("014d421b-3c37-4e5b-9f56-e78703078f0a"), null, null, "Brycen58@gmail.com", new Guid("427485d5-0faa-4f9a-9c6f-70317d50831a") },
                    { new Guid("020ae97f-6c1e-4f77-a30a-6fb268506f11"), null, null, "Sibyl_Cormier46@hotmail.com", new Guid("d1fdc728-523b-49bf-b2d8-eee9a8bb93d1") },
                    { new Guid("02184ad5-afe3-430c-b4b0-4516ae66db38"), null, null, "Bertram_Howell@hotmail.com", new Guid("e44b1f8c-951b-48de-a206-672ce80e3e29") },
                    { new Guid("02f7bb8a-070e-40f6-9e7e-304db85d75c4"), null, null, "Margot_Schinner48@gmail.com", new Guid("9a799371-7ad4-44c8-bcc3-759981e1573a") },
                    { new Guid("02fd8cf6-eb9c-4125-92ea-b360470d71ce"), null, null, "Randall68@yahoo.com", new Guid("437bc41c-af0d-4443-809f-276b155b8846") },
                    { new Guid("0315666a-5ed3-4a5b-bb61-c576b5dc9864"), null, null, "Kacey_Hoeger94@yahoo.com", new Guid("91024531-3bc9-4397-868c-67a81b4abcfc") },
                    { new Guid("03ae9b4e-18df-4ee8-95d0-d5933304a121"), null, null, "Lafayette57@yahoo.com", new Guid("872eccf4-a3fa-43c5-ab2e-ac6f6c9e4f17") },
                    { new Guid("03f69c3f-f465-4d63-b095-8cdca71e3803"), null, null, "Price_Lesch@gmail.com", new Guid("4fb2390c-a600-4f3b-adfe-f73867978239") },
                    { new Guid("0427dfea-6195-4203-9b4f-4592975c7e80"), null, null, "Guillermo_Huel63@hotmail.com", new Guid("71ef850e-2fd5-4538-9b05-9c38cbbdbe30") },
                    { new Guid("043db856-a74f-4602-a62e-33845194232f"), null, null, "Reyes64@gmail.com", new Guid("9b8fcbcf-ce9d-40cf-aa2a-0543ebe6f135") },
                    { new Guid("04992ed6-2ca2-45c6-9d5c-5d8a4453f197"), null, null, "Newton_Parisian44@gmail.com", new Guid("997402b2-514c-445f-9988-ae18a101181e") },
                    { new Guid("04cbb397-ebef-4592-a245-903cb0933b15"), null, null, "Terry_Hackett@gmail.com", new Guid("72b9b70e-980c-47d3-a949-0b0acbdbe9f3") },
                    { new Guid("04d9e1dd-8574-4781-b011-f5c821ae1122"), null, null, "Loren48@hotmail.com", new Guid("4fd873ab-a800-46d0-959f-d9f6189c846e") },
                    { new Guid("05fd51ea-5cd4-4f45-abc9-3614af0eb1db"), null, null, "Werner_McKenzie45@yahoo.com", new Guid("960fe293-a56c-42c1-b68b-57d1e361fe6d") },
                    { new Guid("0698a615-55da-44b3-9ff8-7fa873a67ad3"), null, null, "Kelli.Green41@yahoo.com", new Guid("3a8ff431-6524-4268-ae59-91f87b944fae") },
                    { new Guid("06a0188c-2888-4dd0-aa1b-509c47725748"), null, null, "Jamison_Nitzsche16@gmail.com", new Guid("5441f683-8cec-4fb5-96c6-2fa82e7997d3") },
                    { new Guid("06e7f38d-5214-44e8-9fa9-c2a80aaa680a"), null, null, "Eriberto68@hotmail.com", new Guid("d666c5aa-5c03-4391-8629-5cc681422ca2") },
                    { new Guid("06edb773-7ddd-4d9f-b6d4-c1396847e73d"), null, null, "Brant.Padberg@hotmail.com", new Guid("b9974b20-5b3f-4445-a6d7-c4352b53a64c") },
                    { new Guid("07500dca-bad2-4cbd-a10e-4d33c160c5ba"), null, null, "Joshuah.Labadie89@hotmail.com", new Guid("966d5ef1-e601-407d-86be-887c8e79a449") },
                    { new Guid("07562085-91da-415d-89a3-77a9c5cfa53e"), null, null, "Jarred48@gmail.com", new Guid("9b8fcbcf-ce9d-40cf-aa2a-0543ebe6f135") },
                    { new Guid("075a0cf6-8b1e-4a2b-bb2f-f087f2ed262b"), null, null, "Monica15@gmail.com", new Guid("d8dd96ce-4557-4993-959c-45a29c967d51") },
                    { new Guid("07685a7b-81e4-4214-b503-c7d81dcff782"), null, null, "Lura61@yahoo.com", new Guid("f54b6d8e-36d4-482b-83f6-69bd802b2ec3") },
                    { new Guid("07930d10-40ec-4e09-a5a7-2d67992383e3"), null, null, "Jewell24@yahoo.com", new Guid("568a5cfd-171b-413d-addf-fe6ab58aa6d0") },
                    { new Guid("07b6a5d8-89a3-411e-9860-9674feceabdd"), null, null, "Renee.Olson33@yahoo.com", new Guid("259e3939-18d5-4998-98ae-345c9d0fa279") },
                    { new Guid("07fe1f90-0967-4012-8ff5-a9b36fea93e9"), null, null, "Charity_Zboncak1@yahoo.com", new Guid("dd2a73f4-0d43-45df-8aa0-196122e00fc2") },
                    { new Guid("0844eb43-62b4-4ce9-b91e-4de2fea9fc76"), null, null, "Ron.Howell83@gmail.com", new Guid("e7414a92-a2c0-4cbd-a0ca-3a6c538ac8c6") },
                    { new Guid("0884bf0b-4d73-4391-8cd0-56757d2d8e51"), null, null, "Hailee.Hickle90@gmail.com", new Guid("97c89012-688a-4d00-9708-03d8cb08dc2e") },
                    { new Guid("08cd354b-9b3b-49dd-b974-d97c5c00c179"), null, null, "Alberto57@hotmail.com", new Guid("9e73d492-68df-4c26-bbd7-c238340416ec") },
                    { new Guid("08d23309-6cd5-4640-a384-c45e35fcc811"), null, null, "Peggie.Berge23@gmail.com", new Guid("03a04e64-e8f5-4db8-ae88-e45982174d32") },
                    { new Guid("0905ddeb-6704-4595-8d2d-49b981f7a7c1"), null, null, "Rosetta.Mraz@yahoo.com", new Guid("6ee9a7d3-8695-4b4a-9a7f-e035a03a4cc3") },
                    { new Guid("09bacffa-a2e0-401c-ab20-15662b55d269"), null, null, "Justus_Koelpin69@yahoo.com", new Guid("f4d9bb48-d87b-420c-b2ef-f724726c7a08") },
                    { new Guid("09d3b57d-8853-4eb1-8702-5eb70a32d5bc"), null, null, "Cara_Hahn30@gmail.com", new Guid("777e0877-9079-4ecc-a52b-f0bf5734b939") },
                    { new Guid("09fa2368-bfc7-476f-bedc-3b6e771c53d1"), null, null, "Renee_Zboncak36@gmail.com", new Guid("cf6839a1-51b8-4ec5-bfec-3cbe48c20160") },
                    { new Guid("0a083bed-0313-45e0-9ce7-20a48ac6b014"), null, null, "Nola.Bartell@hotmail.com", new Guid("967d4ff4-7cca-4fd1-a75a-2f73aca9ca0a") },
                    { new Guid("0a402cb0-4d41-4b32-a5b4-a4ac7b7d1780"), null, null, "Lambert95@hotmail.com", new Guid("086d4f1c-510f-4c8f-a495-d7e8fc340ecc") },
                    { new Guid("0a5943b5-9f13-4054-a601-d2330a266b15"), null, null, "Jody.Adams@yahoo.com", new Guid("b5fe6c30-5f2d-462b-9dd2-bc5388f99ce5") },
                    { new Guid("0a685f6e-e373-4379-934e-8c4b77dd5dc6"), null, null, "Thalia.Schoen@yahoo.com", new Guid("c0ce8022-4a58-4c92-9e84-7f2ac0c9caa5") },
                    { new Guid("0a75bc2a-f188-4c2a-8a86-f67574f7b9d4"), null, null, "Ursula.Pacocha@hotmail.com", new Guid("dee746db-2712-4366-98c6-517b826fd421") },
                    { new Guid("0a76ed8e-6738-45ef-a729-6784a8db63bf"), null, null, "Samara45@yahoo.com", new Guid("4883913c-7591-4093-a019-7e3dd870d152") },
                    { new Guid("0a9d1219-a05b-40c7-8156-4822dbb3e936"), null, null, "Shanna_Leuschke@hotmail.com", new Guid("bcb5583b-3b55-4ea8-b016-f74baf89e99a") },
                    { new Guid("0aadae21-7baf-4855-bae8-ab4b7f9cd1dc"), null, null, "Giuseppe36@yahoo.com", new Guid("451f756f-99dc-4563-9d9a-db92f4a114f0") },
                    { new Guid("0ab407e1-d189-420c-9cb4-57de7a36eb77"), null, null, "Serena36@hotmail.com", new Guid("a6fc0423-6291-4866-8d02-6faea1986c4e") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("0c2058ca-95c5-4826-ae0e-ce1c81b37295"), null, null, "Pierce.Volkman@yahoo.com", new Guid("5560fdd3-3041-418a-bdbd-b1b7cb595a87") },
                    { new Guid("0c75eab5-2d1c-45e6-8aa7-53428f391d78"), null, null, "Arianna.Conn71@hotmail.com", new Guid("52010289-102f-414b-8fb6-a09a575f22a0") },
                    { new Guid("0c8e5b08-8f65-4278-989b-2a4a95d940ea"), null, null, "Keira.Strosin60@yahoo.com", new Guid("9dafc6e9-0e56-47f8-8b8b-4ca541841bd0") },
                    { new Guid("0c918e66-b556-4e6b-8d07-5f9dddacbf3b"), null, null, "Libbie.Weimann@hotmail.com", new Guid("cb8696d4-d2d5-40c3-b74f-38aafecd34f8") },
                    { new Guid("0ca73b5e-a0c5-41a9-b4ce-c98a1e6bf375"), null, null, "Jackie68@gmail.com", new Guid("b67eec58-0f42-4a35-a871-09c1ddaddd4b") },
                    { new Guid("0d796e1e-3570-4be9-8855-2af0cd931c82"), null, null, "Gunner_Funk40@hotmail.com", new Guid("7f910a03-763a-4cdb-bbcb-8241bae6fc96") },
                    { new Guid("0dae098f-0330-4f7c-847f-bb0cfbc6055a"), null, null, "Jayce27@hotmail.com", new Guid("ac2d4745-386c-4c13-a217-d9e2d9b842df") },
                    { new Guid("0dc60b74-ec2b-411d-b3fc-d7acbb3b277e"), null, null, "Edward_Kunze@yahoo.com", new Guid("5ffbbdb6-b588-4eef-811a-4b39d217f0a8") },
                    { new Guid("0de30939-451d-4972-ad60-eb3b5c1d225a"), null, null, "Helen35@yahoo.com", new Guid("7b354f95-20a6-4d69-abe1-b5a212feb069") },
                    { new Guid("0e375018-095c-426a-b366-4dd39335e1c1"), null, null, "Gideon.Morissette@hotmail.com", new Guid("96389a1d-3bc8-465b-ba35-3027877a9981") },
                    { new Guid("0e78dcf0-1e51-4b5e-89a1-c30eac5f046f"), null, null, "Jacky.Glover@yahoo.com", new Guid("69879006-dc0c-45ee-a1d8-571618a19f4d") },
                    { new Guid("0e938b79-1653-4d85-b50b-cd10f5603429"), null, null, "Lonnie.Schuster98@hotmail.com", new Guid("c0ce8022-4a58-4c92-9e84-7f2ac0c9caa5") },
                    { new Guid("0f6b4087-81a8-476b-9cbe-5cf2ef9be680"), null, null, "Ashly69@yahoo.com", new Guid("437bc41c-af0d-4443-809f-276b155b8846") },
                    { new Guid("0f6e9af0-57f7-4663-bec8-be5a73a7ad72"), null, null, "Alexandrine_Jacobi@yahoo.com", new Guid("73aad8c3-cbed-4125-b80b-7db0735c3ac6") },
                    { new Guid("0fd232e7-70d1-455b-b9b6-11560e7134a6"), null, null, "Carlie59@hotmail.com", new Guid("ce4c448e-35a5-4243-aa12-b967d2b3da6f") },
                    { new Guid("1028bff1-de24-4615-9b20-8a2298d42cb3"), null, null, "Norris51@yahoo.com", new Guid("7805e438-4982-4f20-9e68-baca0c631417") },
                    { new Guid("102ea199-ce72-4305-b887-60970186e008"), null, null, "Jamel87@hotmail.com", new Guid("c50f147c-0804-4f38-a70a-7b8d4109234d") },
                    { new Guid("104b0526-b3a4-4186-a5a6-23af577eb40c"), null, null, "Serena.Pacocha@hotmail.com", new Guid("98222b1e-1352-4ac9-8c47-69a7f0582ef6") },
                    { new Guid("10b2700e-fc9e-4c58-aa38-1086bf5a7106"), null, null, "Margarett65@hotmail.com", new Guid("ef100efa-deb4-4516-9a15-38df8ff7e396") },
                    { new Guid("10d62d90-bc81-4f91-b08a-ae50d12a098a"), null, null, "Peggie.Predovic@yahoo.com", new Guid("69879006-dc0c-45ee-a1d8-571618a19f4d") },
                    { new Guid("1139e975-2784-4413-b21b-abc2a681dce1"), null, null, "Claudine_Stroman@yahoo.com", new Guid("c8db4c48-87fc-43bc-b9ef-e88e6764800d") },
                    { new Guid("116b9f14-c1a1-4904-ab49-ec8ee1022132"), null, null, "Tressie58@yahoo.com", new Guid("63ce22ac-8a36-4fb9-bf6d-61e02101f5d7") },
                    { new Guid("1211169d-6f1d-4932-b01d-158221706413"), null, null, "Adolphus.Grimes50@yahoo.com", new Guid("9e4f824d-b29a-4ec5-b3a1-111d46f41ecb") },
                    { new Guid("122ff58d-35e9-4293-9713-488e35feab5b"), null, null, "Isac.OReilly28@gmail.com", new Guid("dc04df94-1448-4899-bec4-692b13ea2748") },
                    { new Guid("12607822-e794-476e-8daa-0e44b28e7327"), null, null, "Patricia.Kling88@yahoo.com", new Guid("4883913c-7591-4093-a019-7e3dd870d152") },
                    { new Guid("128d042e-b641-4a49-a02d-21cc3cd754b3"), null, null, "Kayley_Quitzon65@yahoo.com", new Guid("9dafc6e9-0e56-47f8-8b8b-4ca541841bd0") },
                    { new Guid("12f983a8-eb8f-4e9a-b1b3-c6b3c1f8074e"), null, null, "Lourdes43@yahoo.com", new Guid("5a6031a7-d008-4d4c-9a87-857d42759454") },
                    { new Guid("136e5015-978c-4f8f-854f-115c1779a3b6"), null, null, "Destiney.Kling@yahoo.com", new Guid("dffee49d-d296-4315-aefd-9602dd01358c") },
                    { new Guid("14187bfc-c4f1-4431-9186-54858564a2a7"), null, null, "Sigurd.Stanton@gmail.com", new Guid("73850497-d7e2-4015-bf80-d8fc761772d3") },
                    { new Guid("142148de-89dc-427f-813f-d4ded8f76c21"), null, null, "Alexanne_Towne23@gmail.com", new Guid("b4e4db54-4f23-4365-96a9-cb8bd3cdaecf") },
                    { new Guid("1439b162-0d6d-4384-ab96-11fdc04116f3"), null, null, "Ramona.Koss@yahoo.com", new Guid("73aad8c3-cbed-4125-b80b-7db0735c3ac6") },
                    { new Guid("14c6cc0c-f0b5-45a2-bbbe-229ca53f586a"), null, null, "Minnie.Renner55@yahoo.com", new Guid("da687a7e-bca5-449f-ad43-32e0ac00fe15") },
                    { new Guid("150b7db4-1067-4154-a0f8-356e46a9a1c5"), null, null, "Wendy.Balistreri@gmail.com", new Guid("dc04df94-1448-4899-bec4-692b13ea2748") },
                    { new Guid("1524850c-9f30-480f-9a11-b4cd3168a921"), null, null, "Rodger.Nolan79@gmail.com", new Guid("02df2ae2-d7d0-47a4-aeae-e733e06bb1d0") },
                    { new Guid("15ad4d97-29dd-4639-8c0b-87ca733e47c1"), null, null, "Don_Little23@hotmail.com", new Guid("ef14d144-d1c3-49fb-9e25-1889be79f4e3") },
                    { new Guid("160b2aa9-840d-4612-93a9-2c8f660f5121"), null, null, "Duane_Kunze34@yahoo.com", new Guid("6b62d633-8ccd-4aa4-82e7-a8336a9e5760") },
                    { new Guid("161f3359-51d8-404e-9160-74bb48c078db"), null, null, "Theodora.Johnston@gmail.com", new Guid("5ffbbdb6-b588-4eef-811a-4b39d217f0a8") },
                    { new Guid("1663a6cd-41bf-45f9-90d2-e2fcf6efadb8"), null, null, "Winnifred17@hotmail.com", new Guid("8adfe810-a4af-41ad-bda0-c1898bdb4d92") },
                    { new Guid("172d9ebe-2441-49fa-bdfb-462a6c711a3d"), null, null, "Idell24@gmail.com", new Guid("861c20c6-b2fe-4d03-a2b4-ae2380f7edc5") },
                    { new Guid("172dba58-485d-495d-b782-4899f47a6b41"), null, null, "Valentin.Stark@yahoo.com", new Guid("7b354f95-20a6-4d69-abe1-b5a212feb069") },
                    { new Guid("173f013d-ea70-41cc-aad2-027cd040dbd1"), null, null, "Glenda.Frami90@yahoo.com", new Guid("749d009d-0557-4289-976a-50a7e345a281") },
                    { new Guid("17dcc8e4-4cbf-4a3b-b996-ab418179e706"), null, null, "Alaina_Keeling@yahoo.com", new Guid("e807eb16-5caf-4274-9ff7-5027ed83325c") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("184f550c-f41d-4993-9e0f-5c472a434161"), null, null, "Jess.Feil@yahoo.com", new Guid("3dd4bd2a-4dd8-4988-867a-99041eb6851d") },
                    { new Guid("188d81b9-0bef-4f03-9db2-042adcd4ec24"), null, null, "Alford.Murazik26@hotmail.com", new Guid("b9974b20-5b3f-4445-a6d7-c4352b53a64c") },
                    { new Guid("18b2e3a3-fd2b-4827-904e-5b2d62444963"), null, null, "Ola87@gmail.com", new Guid("966d5ef1-e601-407d-86be-887c8e79a449") },
                    { new Guid("19676308-e0f6-4c6b-be1b-d92021d1f98b"), null, null, "Catharine.Turner@yahoo.com", new Guid("5a6031a7-d008-4d4c-9a87-857d42759454") },
                    { new Guid("1987ccaa-033c-4512-bf4d-9f5e82d5bb4b"), null, null, "Nikki98@gmail.com", new Guid("10a10ed0-e1f4-4de7-b631-e8c7d0d5eaa9") },
                    { new Guid("19ad5a4c-072d-4ac2-a162-7dc583e1b915"), null, null, "Lessie19@yahoo.com", new Guid("7b354f95-20a6-4d69-abe1-b5a212feb069") },
                    { new Guid("1a3ab0be-a8b5-4122-b639-2f119dd8dca7"), null, null, "Margaretta.Zboncak50@gmail.com", new Guid("9b0c9ef1-c568-4fc6-8e02-cbbb959e0bbb") },
                    { new Guid("1a783de9-3a49-4f43-bd80-5c92f9cc51e3"), null, null, "Kiel_Nienow76@hotmail.com", new Guid("91024531-3bc9-4397-868c-67a81b4abcfc") },
                    { new Guid("1ab99e07-f251-4383-aff4-2c5c1bd97304"), null, null, "Micah80@gmail.com", new Guid("b944ae23-efab-4fcb-bda0-6be21e2add96") },
                    { new Guid("1b94836d-3810-4935-b27c-10f3f34d2a8f"), null, null, "Christopher.Hauck@yahoo.com", new Guid("62f9c608-cb23-46fa-a1c4-304e5c65aec1") },
                    { new Guid("1c4a43c1-5d63-484c-9eab-2eda6846cd6c"), null, null, "Mateo98@yahoo.com", new Guid("cfc77b46-5660-4e53-bd9c-0ef309097b43") },
                    { new Guid("1c4ea9db-f50b-4f36-95a2-ecf955a417ba"), null, null, "Vena.Emmerich@hotmail.com", new Guid("cc549d3d-c127-48fe-9320-69c0367cf0ef") },
                    { new Guid("1c8c59c0-2a68-49cf-8079-0d3a82b4a7f3"), null, null, "Jackie11@gmail.com", new Guid("1c5135c6-32f4-4363-a0a3-5a8fb7357df1") },
                    { new Guid("1ca85e64-1550-43fc-b4ed-10a9df4a6a37"), null, null, "Leonor.Shields@gmail.com", new Guid("8adfe810-a4af-41ad-bda0-c1898bdb4d92") },
                    { new Guid("1ced67b0-5981-42a2-8484-a09a783a0d2a"), null, null, "Margarette_Emard72@hotmail.com", new Guid("7e5e5ebc-3d4d-451a-884b-00a9d9f53676") },
                    { new Guid("1dc7d754-301a-4bb3-a430-d6e93189583d"), null, null, "Willie_Lehner64@hotmail.com", new Guid("716e3b4a-4381-424f-88d2-df0753a8cb13") },
                    { new Guid("1de9cefa-2526-4825-a557-56f031335e31"), null, null, "Princess_Mueller@hotmail.com", new Guid("cb9544f8-58da-451a-a24e-9ef9b8265d20") },
                    { new Guid("1e0dc7d1-c0a9-4241-9f82-df37f56184ba"), null, null, "Michel18@gmail.com", new Guid("aee768a4-2b67-47da-a692-ab2b1cd95c27") },
                    { new Guid("1e3612a4-7dc1-4b9d-a326-a96afb288799"), null, null, "Stephan46@hotmail.com", new Guid("18314b53-d5e3-48fa-8ad6-dc84c3baa1ff") },
                    { new Guid("1e58e422-e2ab-467f-bfdd-054e0163313b"), null, null, "Alexane_Rohan60@hotmail.com", new Guid("6b62d633-8ccd-4aa4-82e7-a8336a9e5760") },
                    { new Guid("1e774c78-1f5b-4cfa-8d0a-2c002c45694a"), null, null, "Keagan1@yahoo.com", new Guid("91024531-3bc9-4397-868c-67a81b4abcfc") },
                    { new Guid("1ee246d3-ea45-4c6b-b096-933c2453e216"), null, null, "Zachariah.Mills54@gmail.com", new Guid("ed54e83f-5702-4289-98fb-949b73140a47") },
                    { new Guid("1eef6cb4-5139-45f8-b15b-40f1d1a39503"), null, null, "Darwin.Lindgren88@yahoo.com", new Guid("dd2a73f4-0d43-45df-8aa0-196122e00fc2") },
                    { new Guid("1fae26f8-a0f5-4f23-a44e-b6d4f1a43347"), null, null, "Kylie.Greenholt15@hotmail.com", new Guid("24b96e86-5860-47b1-a6ec-9a832bafbb14") },
                    { new Guid("206ce56b-3fdb-4d18-9cdd-c7997f101213"), null, null, "Alfonzo_Haag@gmail.com", new Guid("4bb403d4-8670-466f-a9dc-17dd09c9d546") },
                    { new Guid("20a8c900-efcf-4222-98c1-e9cbe0123b1b"), null, null, "Julie_Howell@yahoo.com", new Guid("db79e848-cfae-4c0f-8859-e5d6af4a311c") },
                    { new Guid("2200450b-53cb-4beb-87a9-c6e88809243c"), null, null, "Delmer77@yahoo.com", new Guid("df250436-821d-48ab-9508-ab3df0550e27") },
                    { new Guid("22567009-392d-4186-99ea-07c2d8b7fafd"), null, null, "Kenyon.Cole18@hotmail.com", new Guid("2eb253e8-852b-4b59-bbd3-41b1d962644b") },
                    { new Guid("22b115d8-8852-4c60-9934-b904b3e7ad5e"), null, null, "Dane91@gmail.com", new Guid("88155035-c6f4-450c-bd25-3d3e9c9d8f5d") },
                    { new Guid("23285222-423c-4ef6-a8e0-233e2b98a04c"), null, null, "Destin39@hotmail.com", new Guid("ca9a7100-5d5c-406e-8028-d065cd21c772") },
                    { new Guid("23496baa-9c9a-420b-85e8-34a98f34b739"), null, null, "Pattie.Turner34@hotmail.com", new Guid("d5f398ce-f08b-4d20-af17-603089eb45ee") },
                    { new Guid("234e3c75-b8a5-4c31-8e07-95578236e30d"), null, null, "Kristoffer.Ruecker@yahoo.com", new Guid("dd2a73f4-0d43-45df-8aa0-196122e00fc2") },
                    { new Guid("236d752a-2e14-4361-8e87-82f22e548714"), null, null, "Stanford.Leuschke77@yahoo.com", new Guid("9a799371-7ad4-44c8-bcc3-759981e1573a") },
                    { new Guid("238a263a-2089-46ca-9c8d-5f5aa072b097"), null, null, "Stuart78@gmail.com", new Guid("aa1380ad-62cc-4108-817a-4ac56a2c382d") },
                    { new Guid("2390dd8c-fc86-40e2-a256-4b2f27249d83"), null, null, "Adella_Beatty63@gmail.com", new Guid("58fc780f-3b29-4947-a319-3ed8b421144e") },
                    { new Guid("23c562f7-7260-409e-8d9d-df443b24e288"), null, null, "Jazlyn72@hotmail.com", new Guid("b50df756-e4ca-4115-a962-e283f6b8d317") },
                    { new Guid("2428956d-8bce-4eca-a3d0-bfc6b6a0a20d"), null, null, "Mireya84@hotmail.com", new Guid("c0ce8022-4a58-4c92-9e84-7f2ac0c9caa5") },
                    { new Guid("24379bab-c30d-48a5-bab4-4ec9a176b63d"), null, null, "Rudolph.Rohan77@yahoo.com", new Guid("18314b53-d5e3-48fa-8ad6-dc84c3baa1ff") },
                    { new Guid("24a8fe5d-2b85-419c-bfbf-f0dca7d3ba7d"), null, null, "Marcel.Witting79@yahoo.com", new Guid("1747bd38-8325-47e2-8876-f2ff552a55c8") },
                    { new Guid("25055712-bffc-4769-acbd-dfdcb161d74b"), null, null, "Hailey.Moen24@gmail.com", new Guid("da687a7e-bca5-449f-ad43-32e0ac00fe15") },
                    { new Guid("25883ab0-ac0d-478d-b21a-97e3473e99ed"), null, null, "London_Swaniawski@gmail.com", new Guid("9a38b671-5580-4658-abf4-c1fc9ce2be0b") },
                    { new Guid("25f8f790-e383-4c08-82e2-55d6440fcc41"), null, null, "Rod.Mann73@yahoo.com", new Guid("8bbc88c0-c35c-496f-b3fc-e18f3d8bad18") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("26445333-f525-4fa4-9887-e375300a10a5"), null, null, "Thelma57@yahoo.com", new Guid("c431ef46-de70-4dba-a2b4-061b2a219ebc") },
                    { new Guid("26c82776-2411-4d7d-ba1e-b540be9257bc"), null, null, "Gladys.Watsica@hotmail.com", new Guid("37432efe-ddf1-4f3f-9753-a8b4a9e54500") },
                    { new Guid("26e779a9-082c-481c-8083-b11fd9759067"), null, null, "Anastasia36@gmail.com", new Guid("abff8b44-2e47-47cd-8158-cb029242cf8c") },
                    { new Guid("26f4c3f6-7bba-4a36-8f02-808cb6022cc8"), null, null, "Alycia.Lind61@hotmail.com", new Guid("57d5c043-44a4-43bb-80ee-1cbb791b2285") },
                    { new Guid("2743f5a7-06fd-496f-96e0-9db7cd129166"), null, null, "Dorthy_Anderson93@gmail.com", new Guid("ffdf2e3d-14e1-47fc-a87f-43ee44597c72") },
                    { new Guid("280b0fc9-a070-4ff7-8dc1-f0c2ea58741b"), null, null, "Marta6@hotmail.com", new Guid("e58d2261-638d-41ed-b5bf-55b3a94546e1") },
                    { new Guid("28aea5ed-5fd7-40cf-9af7-e9dbc3590b7b"), null, null, "Otis_Runolfsson@yahoo.com", new Guid("51655f73-efc8-4142-b1ea-1657e4fc0f2e") },
                    { new Guid("2931df78-4a91-4ea5-a36d-1c51a5dd73b2"), null, null, "Garret86@hotmail.com", new Guid("e1223f43-016e-41f5-b212-ab70a0ac01e2") },
                    { new Guid("299bc4d0-21a7-44ad-bf8f-2c8d097b1696"), null, null, "Roosevelt_Hettinger35@gmail.com", new Guid("dffee49d-d296-4315-aefd-9602dd01358c") },
                    { new Guid("29c7a49f-9924-454c-b36c-5450eeac65b6"), null, null, "Helene.Torp62@gmail.com", new Guid("26ad372f-ab3d-49d6-a283-d78f71a0b97b") },
                    { new Guid("29d401b3-957e-4e79-837d-2b8cc565b809"), null, null, "Lucy_Kshlerin32@gmail.com", new Guid("83521c38-fd64-4bbe-89bf-e217d9771096") },
                    { new Guid("29ee81b7-040b-4c84-b6f1-e1c112aaae2c"), null, null, "Donald8@yahoo.com", new Guid("8c7f5100-7603-4d85-9e37-fba6a586f7c8") },
                    { new Guid("2a915c56-dc32-4eb6-a386-502ec5515ce1"), null, null, "Torrance.Prohaska67@hotmail.com", new Guid("655cd6fe-206e-4683-a0e5-f0108ee7f59f") },
                    { new Guid("2a99f786-9b91-47f8-b08b-34d713e9fae7"), null, null, "Alberta.Kautzer@hotmail.com", new Guid("ac2d4745-386c-4c13-a217-d9e2d9b842df") },
                    { new Guid("2acd9c7a-7c18-42b7-a8dc-02f1a38e0e51"), null, null, "Porter.Swift79@yahoo.com", new Guid("a3564d73-cc7f-45bf-bb8d-5bff9f9bd319") },
                    { new Guid("2c7101fe-ca1a-4d08-969e-5224d08b2414"), null, null, "Don92@hotmail.com", new Guid("f7f7b1e1-146a-4f33-9556-99419aa87dbb") },
                    { new Guid("2c8caed5-64a2-4341-bfe7-829134895ded"), null, null, "Frederick_Stanton89@yahoo.com", new Guid("451f756f-99dc-4563-9d9a-db92f4a114f0") },
                    { new Guid("2c8d6c2d-3c65-4e78-832b-c8c2b1028baf"), null, null, "Marge.Homenick89@yahoo.com", new Guid("11ddb06c-1f4a-4028-b37b-6ad05ae5f7d5") },
                    { new Guid("2c915d0d-d401-44ab-9d0d-4f02c46ff75e"), null, null, "Dominique25@hotmail.com", new Guid("5effd297-ddf3-4f40-afed-c85e49e3d248") },
                    { new Guid("2d7364fa-80e8-427c-92a9-3814a880fe31"), null, null, "Lacey.Jerde@gmail.com", new Guid("5effd297-ddf3-4f40-afed-c85e49e3d248") },
                    { new Guid("2d8cda2d-ef79-4198-851a-9613f1918f96"), null, null, "Vincent30@gmail.com", new Guid("c311c4ad-bbcf-418b-8259-eec5ae72eb71") },
                    { new Guid("2d9be7b3-0d8f-4bd8-8347-09962641b5ec"), null, null, "Irwin6@hotmail.com", new Guid("91024531-3bc9-4397-868c-67a81b4abcfc") },
                    { new Guid("2dd3141d-d9c9-4aa8-a192-52ca3b824206"), null, null, "Florence.Rau91@gmail.com", new Guid("6375150d-9633-494e-ba79-b55f87d56afa") },
                    { new Guid("2e08ea1f-f3d3-47f9-ade4-989cee6205db"), null, null, "Elvera12@gmail.com", new Guid("4bb403d4-8670-466f-a9dc-17dd09c9d546") },
                    { new Guid("2f2611fb-2688-4d9b-ba21-10174e01ad07"), null, null, "Jarrell.Blick@hotmail.com", new Guid("641c3d4a-a6ff-4cb3-b40a-665b9156a255") },
                    { new Guid("304fd0f5-817d-402c-87b9-36adf7f0078b"), null, null, "Izabella_Gutkowski@gmail.com", new Guid("8892b0e2-0aef-404c-8681-2866126b786f") },
                    { new Guid("30507f87-5652-41b1-a9fd-6bf8edfd5b9c"), null, null, "Tyra_Dicki@yahoo.com", new Guid("57041776-9144-494f-9e92-9c9da3135eab") },
                    { new Guid("30962bd5-56a7-44d6-89a8-bea558378675"), null, null, "Bailee94@yahoo.com", new Guid("6db49be1-1b9b-4fd0-8b2d-52ae151f7432") },
                    { new Guid("30a91968-7fe1-4976-b685-c4dbcc8730bf"), null, null, "Enoch_Rolfson@yahoo.com", new Guid("b71f69da-e20d-4b25-b2fb-00d5eb1c9002") },
                    { new Guid("31066b17-7bc9-4e62-9078-67ef018a6098"), null, null, "Hazel_Hansen43@yahoo.com", new Guid("c311c4ad-bbcf-418b-8259-eec5ae72eb71") },
                    { new Guid("316cd8fd-c678-4dda-bd15-bd47bc67a55e"), null, null, "Sofia.King0@gmail.com", new Guid("b070b87c-5a28-4f27-8f54-9238dfbe5c79") },
                    { new Guid("31758b4c-13aa-4a38-acb3-7e3dffc54e9b"), null, null, "Ross54@gmail.com", new Guid("3aa0613b-0255-46fa-9fc9-f73e67ec6962") },
                    { new Guid("32195dfe-aadf-4f46-be5e-1d8ecb4efc09"), null, null, "Adolphus_Labadie@gmail.com", new Guid("78615ad6-0a03-477e-a515-c98b1a96475d") },
                    { new Guid("323ad4d3-8fee-4786-9ca4-f79f5f1e7e93"), null, null, "Bessie.Schaefer@hotmail.com", new Guid("9a38b671-5580-4658-abf4-c1fc9ce2be0b") },
                    { new Guid("326b5dfc-e397-4aaa-a409-cac29f49bad4"), null, null, "Denis.Robel76@hotmail.com", new Guid("93b22657-e430-4b16-b1f2-af9b44bd9175") },
                    { new Guid("32af4bad-9720-462f-8795-d948b584f435"), null, null, "Margarett.OHara17@hotmail.com", new Guid("6cbb9172-2b78-4f00-a841-8a1e6d6be79b") },
                    { new Guid("32c0fb97-8fd7-4cca-b4a9-7e5449f65ab2"), null, null, "Leon.Kilback@yahoo.com", new Guid("fc15fcf7-014b-4521-910c-8a4a05ae7df9") },
                    { new Guid("332f0b10-a5d5-446f-a8ef-741d2b0da584"), null, null, "Jaden.Steuber@hotmail.com", new Guid("708b56dd-a529-4229-82e2-2266f01c7942") },
                    { new Guid("338b3428-7636-4166-b768-84b1d5a169d9"), null, null, "Summer74@hotmail.com", new Guid("51655f73-efc8-4142-b1ea-1657e4fc0f2e") },
                    { new Guid("339ad419-6df2-4bd0-9193-4e466c713604"), null, null, "Estefania76@yahoo.com", new Guid("c8db4c48-87fc-43bc-b9ef-e88e6764800d") },
                    { new Guid("339e511f-0da2-4c2f-8510-e3660c98a98e"), null, null, "Carlotta_Hilpert@gmail.com", new Guid("4fb2390c-a600-4f3b-adfe-f73867978239") },
                    { new Guid("33f1c2f3-ec9d-42aa-a5bb-36be229a6d49"), null, null, "Nasir_Blanda8@gmail.com", new Guid("1d118b7f-07b1-49dd-9f7d-5a1e7d8ea4bc") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("3486bfec-2d40-400d-9d41-b0eceeb38cba"), null, null, "Cynthia_Bayer@yahoo.com", new Guid("2a328a80-898f-4b62-921d-731137bebe9f") },
                    { new Guid("350681e6-a592-408a-bc1f-aaeac13cb969"), null, null, "Carroll97@hotmail.com", new Guid("d666c5aa-5c03-4391-8629-5cc681422ca2") },
                    { new Guid("35991fc9-9122-4d2e-8863-f20b8fce84da"), null, null, "Kameron_Auer18@gmail.com", new Guid("94e92894-3b19-4c5f-9e95-0ec52116ec92") },
                    { new Guid("359a5f22-b3ff-4eaf-9eb2-f9f40a0d81f1"), null, null, "Annabell42@hotmail.com", new Guid("f7f7b1e1-146a-4f33-9556-99419aa87dbb") },
                    { new Guid("35e3f3fa-7083-477b-9d80-c7fcc00f59f2"), null, null, "Sylvester_Pouros@yahoo.com", new Guid("16dfe9db-9389-4852-8b69-53610d60b359") },
                    { new Guid("35f7c9e3-a273-467f-a944-8ae252d319de"), null, null, "Brandi.Pouros40@hotmail.com", new Guid("03a04e64-e8f5-4db8-ae88-e45982174d32") },
                    { new Guid("35fe155f-7336-4772-be1d-03ad3f9b8981"), null, null, "Floy_Ondricka@yahoo.com", new Guid("092e31f3-9b9a-4287-8cae-7fcd18feab47") },
                    { new Guid("361c93bc-ac9e-47aa-a0e6-e2c74e66b1bb"), null, null, "Lauretta66@hotmail.com", new Guid("25a47446-d397-4805-8427-d3185a6d35b7") },
                    { new Guid("373cad77-ae91-40e2-bda0-c7c09674d710"), null, null, "Nash_Effertz66@yahoo.com", new Guid("6709762d-580f-4c32-8f92-b1daa6e22c27") },
                    { new Guid("3798eaa0-d772-4026-9901-062bb6a3bfa2"), null, null, "Noemy54@hotmail.com", new Guid("3dc1a6db-3bf2-4650-b501-abf7ef284b3c") },
                    { new Guid("37af7481-cf48-484f-b6bd-b7b4315e2ecf"), null, null, "Glenna60@gmail.com", new Guid("222dda98-6fd2-4619-8709-1b78c7872ca8") },
                    { new Guid("37bbd865-481c-4fb9-9213-eeeab179383f"), null, null, "Lydia_VonRueden@gmail.com", new Guid("655cd6fe-206e-4683-a0e5-f0108ee7f59f") },
                    { new Guid("383e6f20-5d24-4bd7-817e-e156fefe825f"), null, null, "Dorothea89@yahoo.com", new Guid("861c20c6-b2fe-4d03-a2b4-ae2380f7edc5") },
                    { new Guid("387dc54d-b62a-419c-8b5d-83dd686610a0"), null, null, "Precious12@hotmail.com", new Guid("6cbb9172-2b78-4f00-a841-8a1e6d6be79b") },
                    { new Guid("39c93fa4-c6a2-4eea-a337-72ee3a402e34"), null, null, "Adaline_Harris32@yahoo.com", new Guid("4d65579c-7caa-4a73-aec4-ebf5de2054ab") },
                    { new Guid("3a28dce0-3e8a-4c89-96b2-9270747e6e46"), null, null, "Ardella_MacGyver38@gmail.com", new Guid("96389a1d-3bc8-465b-ba35-3027877a9981") },
                    { new Guid("3a7c0abc-b17f-4752-a36c-358274c89752"), null, null, "Margret.Wilderman@yahoo.com", new Guid("ad53394d-1d27-416a-92bf-5074f6fa4fc4") },
                    { new Guid("3b8ab308-de3d-48b0-b9a9-317a98156a33"), null, null, "Jayden.Paucek66@hotmail.com", new Guid("d0fc0768-b3a0-4f82-affc-e355dc4101f4") },
                    { new Guid("3bb457e8-ef20-4c0b-ac6e-25cdd62273cb"), null, null, "Luis10@hotmail.com", new Guid("5e2d266d-c2a4-4711-b57e-3656b61d6ad2") },
                    { new Guid("3beef821-ebb7-4982-9d09-e69180ab5709"), null, null, "Camilla31@hotmail.com", new Guid("aa1380ad-62cc-4108-817a-4ac56a2c382d") },
                    { new Guid("3befc819-3ebd-4b7d-b294-3b5d7535f63d"), null, null, "Kaylee_Gerhold@gmail.com", new Guid("749d009d-0557-4289-976a-50a7e345a281") },
                    { new Guid("3bf71a95-8e39-4446-835e-efc7cd906790"), null, null, "Vilma.Gerlach44@gmail.com", new Guid("8dd6a489-4514-4244-9fa7-a1490970f38b") },
                    { new Guid("3c02a796-627a-46cd-84c4-4a8f8960575f"), null, null, "Serenity_Ratke63@yahoo.com", new Guid("be18d868-cfef-46af-89ea-769a3c24c7da") },
                    { new Guid("3c2d6514-9353-4b50-a5c4-b66a4b82bde9"), null, null, "Ignacio_Sanford@yahoo.com", new Guid("ad53394d-1d27-416a-92bf-5074f6fa4fc4") },
                    { new Guid("3c3481f6-51c7-4fad-bd7a-774c7735c7b3"), null, null, "Oscar_Conroy31@gmail.com", new Guid("a3564d73-cc7f-45bf-bb8d-5bff9f9bd319") },
                    { new Guid("3c420f87-3acb-47df-9a1c-47228bea779e"), null, null, "Earline8@hotmail.com", new Guid("861c20c6-b2fe-4d03-a2b4-ae2380f7edc5") },
                    { new Guid("3c5615cf-5b87-4a22-ba44-b9fa8eaf8ff8"), null, null, "Kaci1@yahoo.com", new Guid("63bd6aad-fd4d-4a2d-b0ee-341253297e79") },
                    { new Guid("3c958ef9-ec72-47d6-ae4c-6b35ebbeafef"), null, null, "Doris62@gmail.com", new Guid("d0fc0768-b3a0-4f82-affc-e355dc4101f4") },
                    { new Guid("3d90806d-931e-4aaa-ac9c-53eff91cc424"), null, null, "Calista_Schamberger@hotmail.com", new Guid("a6fc0423-6291-4866-8d02-6faea1986c4e") },
                    { new Guid("3da068e6-f82c-4924-a428-f13ad61e8578"), null, null, "Daryl_Hintz@yahoo.com", new Guid("2eb253e8-852b-4b59-bbd3-41b1d962644b") },
                    { new Guid("3da3b5c6-44a6-44fe-9060-18ceaa6c3b5c"), null, null, "Zella.Franecki@yahoo.com", new Guid("01a8f276-3a4c-402e-98b4-c3b9dba05f91") },
                    { new Guid("3dee8d24-da7e-4191-ae56-c41ba7886138"), null, null, "Josefina_Jast89@yahoo.com", new Guid("6375150d-9633-494e-ba79-b55f87d56afa") },
                    { new Guid("3e5f34f8-b77f-4187-a461-64226b4ce1a6"), null, null, "Edgar.Streich@yahoo.com", new Guid("fc15fcf7-014b-4521-910c-8a4a05ae7df9") },
                    { new Guid("3e8529c2-958e-4a62-b474-504cd6644219"), null, null, "Pietro.Pollich35@yahoo.com", new Guid("3aa0613b-0255-46fa-9fc9-f73e67ec6962") },
                    { new Guid("3ebbf063-8769-4286-86d8-0eee60491e87"), null, null, "Cruz.Auer@gmail.com", new Guid("b50df756-e4ca-4115-a962-e283f6b8d317") },
                    { new Guid("3ebf2514-7552-40cd-a55d-d5b060f2a20d"), null, null, "Rylee6@gmail.com", new Guid("e2dba597-b132-4b1a-a46f-540ebc581408") },
                    { new Guid("3ee72a07-df4e-45fc-9915-f383e63c2d97"), null, null, "Benny.OConner@hotmail.com", new Guid("e44b1f8c-951b-48de-a206-672ce80e3e29") },
                    { new Guid("3f303c86-fd2b-4edc-90dc-a32cae0f0029"), null, null, "Ben.Koelpin@yahoo.com", new Guid("1546f9ad-e76e-4438-9513-2c0cdbcdc9dc") },
                    { new Guid("3f324658-d171-43b5-a238-6f00db2e2e54"), null, null, "Claire_Weimann72@hotmail.com", new Guid("ac2d4745-386c-4c13-a217-d9e2d9b842df") },
                    { new Guid("3fdb517f-062c-4c76-a4d5-2061ac5b03db"), null, null, "Sibyl12@gmail.com", new Guid("9f317a02-0a11-4f32-b538-7ec5c02e4b5e") },
                    { new Guid("407bcc0b-9d00-41a6-a302-d8b4587f2a56"), null, null, "Margarita_Hane79@yahoo.com", new Guid("77332645-fb25-478f-998c-36dd38aaba91") },
                    { new Guid("40c5079e-b26e-4df5-be7b-51ce3fca21f3"), null, null, "Neal96@hotmail.com", new Guid("4d792f39-989a-48bc-8528-2bda17a5967a") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("411f7de4-d7c3-4356-8233-2adf513ab655"), null, null, "Tianna.Gibson87@hotmail.com", new Guid("9f331cb7-b70d-434b-bc28-147a5e624fd8") },
                    { new Guid("413f4912-5243-400b-9fb9-10e5d4ec41a6"), null, null, "Raegan35@gmail.com", new Guid("69536a6d-5fc0-40dc-96ff-96cfa2e2ddde") },
                    { new Guid("41c39929-935a-43af-9f48-60937f0309a1"), null, null, "Hadley.Hand@yahoo.com", new Guid("71ef850e-2fd5-4538-9b05-9c38cbbdbe30") },
                    { new Guid("41f15be3-f867-4f7f-8322-9cb2c34803f4"), null, null, "Retha.Lang26@yahoo.com", new Guid("1546f9ad-e76e-4438-9513-2c0cdbcdc9dc") },
                    { new Guid("424c011d-fb23-4860-bdaf-642fd61cf35f"), null, null, "Brendan_Crooks@hotmail.com", new Guid("259e3939-18d5-4998-98ae-345c9d0fa279") },
                    { new Guid("426f3f40-c229-4ecc-ad66-73f9197712d0"), null, null, "Olga20@hotmail.com", new Guid("d1fdc728-523b-49bf-b2d8-eee9a8bb93d1") },
                    { new Guid("429bba25-526c-4e23-ab9b-b176f44f59c0"), null, null, "Graciela_Kunde@gmail.com", new Guid("b5fe6c30-5f2d-462b-9dd2-bc5388f99ce5") },
                    { new Guid("430acdb9-7496-4d2c-a846-3f77fe782506"), null, null, "Demarco.Grady29@hotmail.com", new Guid("73aad8c3-cbed-4125-b80b-7db0735c3ac6") },
                    { new Guid("435cb7eb-d817-4fc6-b5e5-503c2508d0fb"), null, null, "Clement50@hotmail.com", new Guid("e2dba597-b132-4b1a-a46f-540ebc581408") },
                    { new Guid("43957638-e0a5-4ca8-990b-41eeae3b716d"), null, null, "Armand.Schimmel90@gmail.com", new Guid("0768641f-3440-4d72-a350-3b2eca842a26") },
                    { new Guid("4414348a-494c-48e1-b2f1-52438f3dfe40"), null, null, "Zelma_Kshlerin50@yahoo.com", new Guid("9b0c9ef1-c568-4fc6-8e02-cbbb959e0bbb") },
                    { new Guid("443cbee8-6e5b-429a-8170-b3e02c98e353"), null, null, "Anika50@hotmail.com", new Guid("eddb3b35-4415-4828-97b3-fd737f127090") },
                    { new Guid("45056b3a-e904-4a73-8c4c-ec1260233863"), null, null, "Lue_Cronin@gmail.com", new Guid("7771e104-7d9f-4097-8375-a33ad264e1d8") },
                    { new Guid("45ddef77-942f-44bc-aa61-298f55f3cfd6"), null, null, "Stephon.Nolan10@hotmail.com", new Guid("17441686-0fa5-4e5d-b680-2d5708a2ecd5") },
                    { new Guid("461b6cb3-270e-424f-a5bf-08a377c96bec"), null, null, "Jamie_Schmeler@gmail.com", new Guid("a7a63c10-9b55-47c6-9d56-8793ee29aafd") },
                    { new Guid("464a6095-8972-4e8e-8732-a2dbfb832cf8"), null, null, "Maya44@gmail.com", new Guid("c0ce8022-4a58-4c92-9e84-7f2ac0c9caa5") },
                    { new Guid("46714590-865e-43b9-bfd2-92e2a6768bb7"), null, null, "Gerardo.Metz@yahoo.com", new Guid("f17c05bb-245d-432b-9116-f181ecbd16c6") },
                    { new Guid("467db241-af8e-4118-b4e2-412e8d1fd3eb"), null, null, "Murray_Stoltenberg32@gmail.com", new Guid("25a47446-d397-4805-8427-d3185a6d35b7") },
                    { new Guid("46a825a7-29f6-4a37-8f2a-03cc5d46e8dd"), null, null, "Marquis_Schaefer7@hotmail.com", new Guid("f54b6d8e-36d4-482b-83f6-69bd802b2ec3") },
                    { new Guid("46aaa07c-6a77-428d-821f-dfcc02e0cedf"), null, null, "Garnett_Nienow@hotmail.com", new Guid("3705daaf-a245-497f-b245-acd05a008711") },
                    { new Guid("47578f39-c8af-4ca2-aab3-7ef96c9220ab"), null, null, "Madge_Raynor@yahoo.com", new Guid("777e0877-9079-4ecc-a52b-f0bf5734b939") },
                    { new Guid("479d8248-58e7-4924-9ffb-6dab8e4407f9"), null, null, "Damion.Bayer26@yahoo.com", new Guid("6dcb62c8-dc29-4e18-aabc-b9f4d6f3d1ce") },
                    { new Guid("47c80bba-3d5e-4de6-aa39-7c93985d4f2e"), null, null, "Myra.Watsica@gmail.com", new Guid("ca9a7100-5d5c-406e-8028-d065cd21c772") },
                    { new Guid("48179e2e-49c9-43ec-a8ea-118ab8067a82"), null, null, "Fay_Hudson@hotmail.com", new Guid("0b440e9a-ee26-43ee-9d40-46328f22a228") },
                    { new Guid("4821a4c1-c4c8-4c92-8636-a857c3f7bd56"), null, null, "Baylee_Nitzsche@yahoo.com", new Guid("8dd6a489-4514-4244-9fa7-a1490970f38b") },
                    { new Guid("483a841e-f7a4-4198-9626-2a8c4530ee6a"), null, null, "Leland.Zemlak@yahoo.com", new Guid("5441f683-8cec-4fb5-96c6-2fa82e7997d3") },
                    { new Guid("483c4ef3-b12d-4bb4-b99d-f0e17811367f"), null, null, "Ulices93@gmail.com", new Guid("4bffa9b9-a7ae-4dd6-b87b-dbcad3737bfd") },
                    { new Guid("4924c1bc-b7e0-439d-bf6f-450f8ea0eed9"), null, null, "Saige1@gmail.com", new Guid("eedd859d-8af5-43b7-8938-5bce7dd89153") },
                    { new Guid("49448984-5003-49e9-8472-fcc67426bd2e"), null, null, "Kathlyn9@gmail.com", new Guid("a3564d73-cc7f-45bf-bb8d-5bff9f9bd319") },
                    { new Guid("4969627b-e954-4917-98d8-11dabb51acd0"), null, null, "Gilbert_Walter@yahoo.com", new Guid("5560fdd3-3041-418a-bdbd-b1b7cb595a87") },
                    { new Guid("496d1bad-7319-4833-8650-ae69049b2614"), null, null, "Milo_Wehner84@yahoo.com", new Guid("58fc780f-3b29-4947-a319-3ed8b421144e") },
                    { new Guid("49804a3e-494a-49b3-90be-c30bf04828a2"), null, null, "Sammy_Quigley49@gmail.com", new Guid("52c54e9c-3d8e-429f-ae95-d180e2ec5a1d") },
                    { new Guid("4b36d140-d719-4ae0-82ce-656de7419aa2"), null, null, "Nelda.Boyer97@hotmail.com", new Guid("655cd6fe-206e-4683-a0e5-f0108ee7f59f") },
                    { new Guid("4bbb3ce0-33b3-4790-be2b-f0bc9a74f4c9"), null, null, "Ardella59@hotmail.com", new Guid("e9781110-3553-481f-bb3a-7ca26a63a83b") },
                    { new Guid("4c19e3fb-d571-482f-ad7e-1a460ce2c618"), null, null, "Valentin81@hotmail.com", new Guid("ef100efa-deb4-4516-9a15-38df8ff7e396") },
                    { new Guid("4c6e8bc2-452c-4d16-a368-1012a225a842"), null, null, "Randy_Altenwerth@gmail.com", new Guid("9f317a02-0a11-4f32-b538-7ec5c02e4b5e") },
                    { new Guid("4c7bcc18-f27a-40f3-83f4-8460fae5463b"), null, null, "Madeline.Altenwerth31@hotmail.com", new Guid("01a8f276-3a4c-402e-98b4-c3b9dba05f91") },
                    { new Guid("4c9282aa-8951-45a8-a698-7a40f0766175"), null, null, "Sadye.Daniel7@gmail.com", new Guid("ffdf2e3d-14e1-47fc-a87f-43ee44597c72") },
                    { new Guid("4ced9656-e619-421f-8166-0e03bf774de5"), null, null, "Allen_Bins@yahoo.com", new Guid("97d70a43-949c-4c03-9da7-fc16fdc0c86d") },
                    { new Guid("4d2c5fa0-05db-4ace-a31e-f5aad1bea45d"), null, null, "Michelle55@yahoo.com", new Guid("1546f9ad-e76e-4438-9513-2c0cdbcdc9dc") },
                    { new Guid("4d4da885-e3c8-44ec-8426-eb2def7eb8b9"), null, null, "Jabari.Mills9@yahoo.com", new Guid("d8361619-ae4f-4db1-9eb9-291e4814a381") },
                    { new Guid("4d9b47cd-de58-4510-ab2c-161fe54f5f0e"), null, null, "Helena.Wolf@gmail.com", new Guid("52c54e9c-3d8e-429f-ae95-d180e2ec5a1d") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("4db9bb83-4b82-4ada-a9e5-20ca210c7028"), null, null, "Zena_Ebert56@hotmail.com", new Guid("620337a7-cc3b-43d5-aef4-5b29e97ab466") },
                    { new Guid("4e41d398-5616-44e1-98c6-00e81b7c212b"), null, null, "Tyra84@gmail.com", new Guid("43b84c41-ad8c-49ff-ae3a-561f6d21e04b") },
                    { new Guid("4eb4b18f-012f-484c-8d43-17be097a1243"), null, null, "Alia_Lockman91@yahoo.com", new Guid("8e8fd0f7-2809-49f2-9c1e-cbeb885b2de7") },
                    { new Guid("4ef3b171-7244-4a58-953e-8702b1285e55"), null, null, "Eunice13@yahoo.com", new Guid("8adfe810-a4af-41ad-bda0-c1898bdb4d92") },
                    { new Guid("4f63ee13-93d4-47af-b1d3-9e4ad3f7cbbe"), null, null, "Nyah.Kub@yahoo.com", new Guid("d08dab84-c369-4193-b4fb-bbd252c59cc5") },
                    { new Guid("4f762e3f-a4ce-4a4c-a2de-1a012449c5a8"), null, null, "Sarah_Jones32@yahoo.com", new Guid("96357562-82d6-4394-b4bf-5b698e1ad612") },
                    { new Guid("4fcf1c16-ffcf-4341-9130-119619382035"), null, null, "Jaydon22@yahoo.com", new Guid("d8361619-ae4f-4db1-9eb9-291e4814a381") },
                    { new Guid("4fe24c82-16e2-4031-b5cc-1f155f2c5bdd"), null, null, "Kirk.Klocko28@hotmail.com", new Guid("d666c5aa-5c03-4391-8629-5cc681422ca2") },
                    { new Guid("4feed0a9-8589-4706-9b26-94575e28d45c"), null, null, "Ray.Jast@hotmail.com", new Guid("8c7f5100-7603-4d85-9e37-fba6a586f7c8") },
                    { new Guid("500beeb6-0eee-4e0b-a6cf-4ec0a2bbbabe"), null, null, "Gussie_Nitzsche@gmail.com", new Guid("4bb403d4-8670-466f-a9dc-17dd09c9d546") },
                    { new Guid("50915afe-66a3-423a-bccc-ca3e4fca4eea"), null, null, "Cierra81@yahoo.com", new Guid("857e5ff4-368c-45c8-909c-9cb05ea33802") },
                    { new Guid("512c817a-5a4a-4896-a82a-9f7cb3baaee2"), null, null, "Ashlee.Hahn@yahoo.com", new Guid("cefdf373-98f4-432b-bfc7-baaf121c554a") },
                    { new Guid("526c3807-7bfb-44da-9ea8-6bb10473a9f9"), null, null, "Janis6@hotmail.com", new Guid("8bbc88c0-c35c-496f-b3fc-e18f3d8bad18") },
                    { new Guid("52b2ac27-d231-416d-98ab-3667cbdad59f"), null, null, "Neil_Mraz@hotmail.com", new Guid("57d5c043-44a4-43bb-80ee-1cbb791b2285") },
                    { new Guid("53247bed-41a8-4e76-a6f3-4820f5cc21a8"), null, null, "Luther22@hotmail.com", new Guid("2a9b395f-43a6-4c12-8ee4-3f4db5f26f9d") },
                    { new Guid("5340f850-f3a0-4fcb-a7e4-2c0a1d627812"), null, null, "Jerrell78@gmail.com", new Guid("a161bc80-bb44-439e-bb80-442569d93b23") },
                    { new Guid("53650b25-b3dc-4575-b0f2-bafb051d8797"), null, null, "Madie65@gmail.com", new Guid("4d792f39-989a-48bc-8528-2bda17a5967a") },
                    { new Guid("540976ee-b383-4e80-b3a0-bc214eb6e309"), null, null, "Laisha.Runte42@hotmail.com", new Guid("83521c38-fd64-4bbe-89bf-e217d9771096") },
                    { new Guid("5420f99a-4959-4f96-88cd-3329aaa0d014"), null, null, "Cortney86@hotmail.com", new Guid("4a254852-2316-4300-99be-6d54e3eeac93") },
                    { new Guid("54cbd0dd-26d7-4bb2-849d-b9f238550b23"), null, null, "Carli.Strosin28@yahoo.com", new Guid("cf6839a1-51b8-4ec5-bfec-3cbe48c20160") },
                    { new Guid("5518964c-eb43-4cf9-b05b-d0f96811fe98"), null, null, "Cecile.Harber@hotmail.com", new Guid("2a9b395f-43a6-4c12-8ee4-3f4db5f26f9d") },
                    { new Guid("5519763a-23dc-472c-9369-fdae614c39df"), null, null, "Morton90@yahoo.com", new Guid("37432efe-ddf1-4f3f-9753-a8b4a9e54500") },
                    { new Guid("5536feed-c448-487c-91e2-c4b352fbbeb1"), null, null, "Margarette_Herman@hotmail.com", new Guid("4bfa50d6-7b76-402d-afe8-4b558ee6165b") },
                    { new Guid("5546e3aa-373d-4192-9add-799c887fe1c5"), null, null, "Mariah_Orn16@yahoo.com", new Guid("93ac31b1-6465-45d3-b0b5-98811dbc77b4") },
                    { new Guid("55504430-5c32-42d5-bca3-5036a8528a4a"), null, null, "Letha_Wiza18@gmail.com", new Guid("ce4c448e-35a5-4243-aa12-b967d2b3da6f") },
                    { new Guid("55b16282-5a86-4ee2-906e-91e7b1167b52"), null, null, "Jaylen31@hotmail.com", new Guid("857e5ff4-368c-45c8-909c-9cb05ea33802") },
                    { new Guid("55e0c619-db15-4908-b412-5e26e1cd120b"), null, null, "Dixie.Boyle@hotmail.com", new Guid("551cb7a5-2acf-469f-be65-7a549dccf51f") },
                    { new Guid("561c8d62-8dae-4ab3-b3b0-a2f7c5cb0ebd"), null, null, "Efren_Medhurst58@hotmail.com", new Guid("cc549d3d-c127-48fe-9320-69c0367cf0ef") },
                    { new Guid("56f39cc2-5cb2-4190-b6c9-6259dd1c5681"), null, null, "Rowland.Balistreri99@gmail.com", new Guid("c3a4c71d-a9ab-475e-9d5b-425a5d31fb48") },
                    { new Guid("57009564-3128-43f2-9f16-f9b078942397"), null, null, "Juwan_Robel93@yahoo.com", new Guid("43b84c41-ad8c-49ff-ae3a-561f6d21e04b") },
                    { new Guid("57393d60-c414-4a04-bb14-77b74683a67f"), null, null, "Nedra.Roob5@yahoo.com", new Guid("6cbb9172-2b78-4f00-a841-8a1e6d6be79b") },
                    { new Guid("574b00f4-0eb4-4056-a4f5-97685c6e5917"), null, null, "Luciano16@hotmail.com", new Guid("a01a13e5-a8d1-4048-b8b2-24cdfac5f11e") },
                    { new Guid("57b2202e-6bfd-436e-bdb6-928c845df07a"), null, null, "Arthur10@yahoo.com", new Guid("5ffbbdb6-b588-4eef-811a-4b39d217f0a8") },
                    { new Guid("57f3d7ef-f4a6-4151-9e54-861a7ed326ae"), null, null, "Elmira.Bergstrom@hotmail.com", new Guid("a13d28a1-8900-4b0d-8399-27cc466b719f") },
                    { new Guid("587effff-4d7a-4b1a-be0f-3ba07b9c3507"), null, null, "Rebeka.Schuster21@gmail.com", new Guid("8a1cc6ac-cbbb-45b8-a858-79df665cbf01") },
                    { new Guid("59192cd2-4cbb-49a0-bbc8-e8e701d81e5b"), null, null, "Sanford_Kuhn@hotmail.com", new Guid("dee746db-2712-4366-98c6-517b826fd421") },
                    { new Guid("59307227-9d54-4e2c-8fa8-91d9515c4d58"), null, null, "Adaline_Prohaska87@gmail.com", new Guid("359f112e-4dd6-47fb-995d-9dae092d143b") },
                    { new Guid("59590569-d9ce-4a21-87b2-d43ad7402275"), null, null, "Gussie_Senger@yahoo.com", new Guid("eddb3b35-4415-4828-97b3-fd737f127090") },
                    { new Guid("5995feee-b0b7-49e6-9a3c-ff3259848453"), null, null, "Edd36@yahoo.com", new Guid("86139076-e779-453a-8f87-64e1bfeeeccc") },
                    { new Guid("59d65b60-99d2-4142-ac5e-85827ba41a0c"), null, null, "Horace_Schuppe81@yahoo.com", new Guid("bcb5583b-3b55-4ea8-b016-f74baf89e99a") },
                    { new Guid("5a6e9d6c-311d-4728-8c8c-49e8dc76a220"), null, null, "Kyla99@gmail.com", new Guid("7889ec96-3dce-40c9-a3d9-1dabf9642602") },
                    { new Guid("5ac28273-6b23-4a03-a4d1-69b78044538c"), null, null, "Jarod_Klein37@yahoo.com", new Guid("bd5c667b-2bfc-46c6-814e-7b5c93be8f43") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("5ac678bc-b348-466f-a451-5433b0e76ddf"), null, null, "Zack6@gmail.com", new Guid("cf6839a1-51b8-4ec5-bfec-3cbe48c20160") },
                    { new Guid("5adad294-6a28-4190-afa0-a732de78f945"), null, null, "Lynn_Bechtelar@gmail.com", new Guid("ef100efa-deb4-4516-9a15-38df8ff7e396") },
                    { new Guid("5aefa10a-d937-421d-a4ee-6de88adbe66c"), null, null, "Edwin_Hackett99@yahoo.com", new Guid("777e0877-9079-4ecc-a52b-f0bf5734b939") },
                    { new Guid("5bb0608e-ca40-43d5-8c0e-0e231c7303a5"), null, null, "Kelvin.Rowe76@yahoo.com", new Guid("5d6854b6-463d-4c99-844f-2b03c65e196b") },
                    { new Guid("5bc13200-1b44-4cf9-8e1a-148ffe436c4a"), null, null, "Alanis.Huel89@gmail.com", new Guid("7889ec96-3dce-40c9-a3d9-1dabf9642602") },
                    { new Guid("5bc2af2b-d941-44e1-8167-cae0bdba37a3"), null, null, "Aryanna_Zboncak16@hotmail.com", new Guid("fd6ebc44-c70c-4ea5-ad8a-6029ee9c49d9") },
                    { new Guid("5c19e6b6-9787-4c25-be91-10e8bbfd3aca"), null, null, "Victoria71@yahoo.com", new Guid("0768641f-3440-4d72-a350-3b2eca842a26") },
                    { new Guid("5c6a4850-890c-4f18-9dc6-461b09ef9d84"), null, null, "Kolby.Fahey7@hotmail.com", new Guid("b4e4db54-4f23-4365-96a9-cb8bd3cdaecf") },
                    { new Guid("5cf63204-021f-4390-8040-c86890f68a0b"), null, null, "Quinton.Hickle98@hotmail.com", new Guid("6709762d-580f-4c32-8f92-b1daa6e22c27") },
                    { new Guid("5d93ab8e-f136-4357-bef7-36b372fcd754"), null, null, "Dylan90@yahoo.com", new Guid("872eccf4-a3fa-43c5-ab2e-ac6f6c9e4f17") },
                    { new Guid("5db5fbf4-babc-4598-9b50-b4f5a2ee6de4"), null, null, "Lori.Treutel@gmail.com", new Guid("4e8bea3b-5b3c-4c9c-b874-2c8b16d90db2") },
                    { new Guid("5e7ef3bc-e561-4945-94f0-4c3640659ec4"), null, null, "Edna71@hotmail.com", new Guid("e6b167e1-2f8a-4aa9-b766-dcb40c4c65b7") },
                    { new Guid("5eaeefc4-f052-4ddb-a99b-302f0344a8e7"), null, null, "Izabella_Runolfsdottir@gmail.com", new Guid("166bcf97-6b8a-4025-ad11-df15241b0a24") },
                    { new Guid("5f2e21c9-e309-4b66-b8e4-230b3aa56cb1"), null, null, "Maxine50@gmail.com", new Guid("c561cc5e-190d-4a91-8ea9-d03583fa3f86") },
                    { new Guid("5fe8914b-3ec6-4b7d-9df2-6b3611020ed8"), null, null, "Herman87@hotmail.com", new Guid("ef14d144-d1c3-49fb-9e25-1889be79f4e3") },
                    { new Guid("6023c235-d994-4a15-a5a3-6a8af56b0321"), null, null, "Sister_Bahringer@gmail.com", new Guid("6b62d633-8ccd-4aa4-82e7-a8336a9e5760") },
                    { new Guid("602c946b-53fb-4212-b8a9-edfd9a4148e1"), null, null, "Domenica_Jones@hotmail.com", new Guid("6375150d-9633-494e-ba79-b55f87d56afa") },
                    { new Guid("60ff6f7e-2c6a-4c4d-9d3e-d56c655b3ec0"), null, null, "Aubrey10@gmail.com", new Guid("7f910a03-763a-4cdb-bbcb-8241bae6fc96") },
                    { new Guid("61a93e4c-8a0c-46d2-b643-b3f696028def"), null, null, "Nora_Schmitt@gmail.com", new Guid("bcb5583b-3b55-4ea8-b016-f74baf89e99a") },
                    { new Guid("61acfba6-c0e9-45bd-b299-82c399215f9a"), null, null, "Theo4@hotmail.com", new Guid("5d6854b6-463d-4c99-844f-2b03c65e196b") },
                    { new Guid("61b92ad9-da3a-48a7-b8f7-fdf7c4119c19"), null, null, "Merritt.Feest72@gmail.com", new Guid("9a38b671-5580-4658-abf4-c1fc9ce2be0b") },
                    { new Guid("62105686-400c-4e05-9e39-7ae2f772e8f8"), null, null, "Aliya_Gorczany@yahoo.com", new Guid("4e8bea3b-5b3c-4c9c-b874-2c8b16d90db2") },
                    { new Guid("62914f70-fa90-46d1-ab13-14e9ee202ce4"), null, null, "Brice_Fisher@gmail.com", new Guid("6507f7f4-4076-4fff-b89e-4205b52b6408") },
                    { new Guid("62aebdb6-b668-4065-9d40-07dc692bc014"), null, null, "Chanel79@yahoo.com", new Guid("6172d849-4ee5-486f-8f97-d2bbcfc40084") },
                    { new Guid("62b66cca-7f65-4a95-a2fc-6f3e569204a7"), null, null, "Bria78@hotmail.com", new Guid("2eb253e8-852b-4b59-bbd3-41b1d962644b") },
                    { new Guid("62cedc88-cabb-402d-87a3-00c12665efc7"), null, null, "Buddy_Legros26@yahoo.com", new Guid("6cbb9172-2b78-4f00-a841-8a1e6d6be79b") },
                    { new Guid("63583f91-9512-4a77-bc3d-4ddc82adec00"), null, null, "Quinn19@gmail.com", new Guid("34d672c5-050e-4c3c-8018-0107a72f13f5") },
                    { new Guid("636d6f7d-5f25-428a-baa6-5e526bc1cc45"), null, null, "Brennon.Bashirian@yahoo.com", new Guid("7e5e5ebc-3d4d-451a-884b-00a9d9f53676") },
                    { new Guid("6385ce90-4ee6-4f0a-a779-e51046c3bf8f"), null, null, "Burnice69@yahoo.com", new Guid("8a1cc6ac-cbbb-45b8-a858-79df665cbf01") },
                    { new Guid("638933d5-f1f3-4e8c-8bdb-dbc3e83ca37d"), null, null, "Federico20@gmail.com", new Guid("859757d1-9ad7-45f4-8664-764e0db29fec") },
                    { new Guid("6396ee25-d85f-48d4-a8a8-04e719c882d3"), null, null, "Sydnee.Nolan12@hotmail.com", new Guid("e27f9603-32f8-4066-bf07-4ab692c8350b") },
                    { new Guid("63bb2b62-762e-495b-8acb-a75460549738"), null, null, "Reginald.Collins@gmail.com", new Guid("859757d1-9ad7-45f4-8664-764e0db29fec") },
                    { new Guid("63e6024d-326b-406f-acdc-a81095d789da"), null, null, "Raquel.Connelly@gmail.com", new Guid("e6b167e1-2f8a-4aa9-b766-dcb40c4c65b7") },
                    { new Guid("642d1caf-e49b-4d2a-9e17-fbce2aa0b8df"), null, null, "Tristin.Doyle@hotmail.com", new Guid("c311c4ad-bbcf-418b-8259-eec5ae72eb71") },
                    { new Guid("6432ce72-73ac-45d1-bb46-c068978f3d7d"), null, null, "Emil.Nicolas57@gmail.com", new Guid("58fc780f-3b29-4947-a319-3ed8b421144e") },
                    { new Guid("6442d6b9-d0c5-438f-8778-ca9a30418861"), null, null, "Verner_Rosenbaum@gmail.com", new Guid("aee768a4-2b67-47da-a692-ab2b1cd95c27") },
                    { new Guid("64640b17-3b42-45f2-9292-d16bebe23108"), null, null, "Ferne.Veum@gmail.com", new Guid("e1223f43-016e-41f5-b212-ab70a0ac01e2") },
                    { new Guid("647524f8-f543-4d58-ae2f-d526b85c2fa3"), null, null, "Tressa10@hotmail.com", new Guid("68fd726f-e5e4-4755-a477-4727a0a9f4b8") },
                    { new Guid("647e7a21-e0fd-4a20-a18d-f24a023fe654"), null, null, "Eleanora_Christiansen59@yahoo.com", new Guid("e7414a92-a2c0-4cbd-a0ca-3a6c538ac8c6") },
                    { new Guid("650ee3b0-b5b7-4ead-a7f9-4521a55a9482"), null, null, "Lauryn_Huel60@yahoo.com", new Guid("ff75563e-5545-46de-a4b3-3e0727d74698") },
                    { new Guid("6514906d-744c-473f-856c-58ceacf4aab7"), null, null, "Jace_McClure@gmail.com", new Guid("f044a50f-e46f-4992-b8ae-47aa00e79d4d") },
                    { new Guid("6532b169-7d56-4eac-8a0c-7f45fd975804"), null, null, "Martin50@yahoo.com", new Guid("9b0c9ef1-c568-4fc6-8e02-cbbb959e0bbb") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("662809f9-f2fd-404b-b95f-aa4a16941c1b"), null, null, "Jaylan86@yahoo.com", new Guid("8dd6a489-4514-4244-9fa7-a1490970f38b") },
                    { new Guid("664d1332-f2f6-4195-8956-19815cc09bcc"), null, null, "Manley.Lubowitz10@gmail.com", new Guid("2f7c84d9-6fe2-4a1c-ba84-c8d43feade58") },
                    { new Guid("669c8549-073b-4219-8670-9b29adf1a7b5"), null, null, "Celia.Lehner@gmail.com", new Guid("9eb02965-fa79-4bc7-940e-eff714a39f7e") },
                    { new Guid("66ccefbb-5f67-498b-b3f4-c633554ee4b7"), null, null, "Isaias.OKon@yahoo.com", new Guid("d9fc54cb-e30e-4a48-b749-08ff99fcff26") },
                    { new Guid("67149a52-2f27-42f4-92b6-df5111f33fe6"), null, null, "Max96@yahoo.com", new Guid("6ee9a7d3-8695-4b4a-9a7f-e035a03a4cc3") },
                    { new Guid("676b5076-d3a0-45f3-b314-abe49b34eb58"), null, null, "Verdie20@gmail.com", new Guid("a165efc8-0956-4593-9333-e1ab17939488") },
                    { new Guid("67b37784-ac4d-466d-8312-2b0d4d471595"), null, null, "Cynthia_Wintheiser@hotmail.com", new Guid("b5fe6c30-5f2d-462b-9dd2-bc5388f99ce5") },
                    { new Guid("686850f6-5929-4df1-8599-bac426e6aec7"), null, null, "Stephanie52@gmail.com", new Guid("9f331cb7-b70d-434b-bc28-147a5e624fd8") },
                    { new Guid("688509cd-afb9-4f42-99bc-926da71d7e74"), null, null, "Evalyn.Fahey@gmail.com", new Guid("dffee49d-d296-4315-aefd-9602dd01358c") },
                    { new Guid("690a7c89-7fd8-4574-bd1f-07673d959b6c"), null, null, "Jakayla_Kessler9@gmail.com", new Guid("c561cc5e-190d-4a91-8ea9-d03583fa3f86") },
                    { new Guid("69b31168-87e9-4380-8d5c-459e25dee20a"), null, null, "Aubree.Miller45@hotmail.com", new Guid("e6b167e1-2f8a-4aa9-b766-dcb40c4c65b7") },
                    { new Guid("6a7abd50-76a4-47c2-b58b-e06fbdb37aba"), null, null, "Madisyn.Stroman@hotmail.com", new Guid("b44b2dc0-6e21-4d7d-a788-6c4e66d96402") },
                    { new Guid("6a9768c1-e7b3-4484-85da-24ee066890fb"), null, null, "Chelsie.Wintheiser@yahoo.com", new Guid("69879006-dc0c-45ee-a1d8-571618a19f4d") },
                    { new Guid("6abd0126-3bdd-498e-a084-65cfd228eba9"), null, null, "Talon_Torphy@gmail.com", new Guid("c9de1952-448f-4a77-a4fa-b78a3751957a") },
                    { new Guid("6adb26b9-48fc-4120-a1f1-05dbb3057c2f"), null, null, "Darrell49@hotmail.com", new Guid("6709762d-580f-4c32-8f92-b1daa6e22c27") },
                    { new Guid("6adc97d8-91d2-42ec-b9ae-3787f97821ab"), null, null, "Kaylah.Sanford55@yahoo.com", new Guid("86139076-e779-453a-8f87-64e1bfeeeccc") },
                    { new Guid("6b1b0d79-df07-4a90-98be-1ed386480196"), null, null, "Mikayla63@yahoo.com", new Guid("222dda98-6fd2-4619-8709-1b78c7872ca8") },
                    { new Guid("6b1caacd-21b0-4bec-a667-a7dda77326db"), null, null, "Emerald98@hotmail.com", new Guid("0639ab22-a867-435b-8c5b-7acf69750583") },
                    { new Guid("6b938a51-fe48-4bdf-bd1c-084c6711fb79"), null, null, "Janiya87@yahoo.com", new Guid("a64a13ca-2754-4769-a254-32716c64c908") },
                    { new Guid("6bb30740-8e0f-42d8-9e47-06a34dba3860"), null, null, "Ari_Mertz@yahoo.com", new Guid("16dfe9db-9389-4852-8b69-53610d60b359") },
                    { new Guid("6c8a5f5a-bc70-4579-8d84-d00ebf86c753"), null, null, "Cullen_Heidenreich15@yahoo.com", new Guid("a01a13e5-a8d1-4048-b8b2-24cdfac5f11e") },
                    { new Guid("6c8f9df4-0f1d-408e-99bd-0d4733981a10"), null, null, "Hiram_Breitenberg10@yahoo.com", new Guid("d0627291-bbf2-408e-bc02-9ba09faa06bd") },
                    { new Guid("6d148f1a-7e41-4c0a-8785-897e0ade652a"), null, null, "Suzanne.Oberbrunner@yahoo.com", new Guid("1e47206c-cbc9-48ff-becb-ea5c84ec9719") },
                    { new Guid("6d6f99d3-bff5-424d-8d56-3aa2208e96f4"), null, null, "Favian_Green@hotmail.com", new Guid("437bc41c-af0d-4443-809f-276b155b8846") },
                    { new Guid("6ddf0aca-eebd-4015-80c1-5aa711670283"), null, null, "Omer0@yahoo.com", new Guid("e2dba597-b132-4b1a-a46f-540ebc581408") },
                    { new Guid("6e337df5-4724-4821-be01-5be5a1e6e1c7"), null, null, "Zula.Mante@yahoo.com", new Guid("78615ad6-0a03-477e-a515-c98b1a96475d") },
                    { new Guid("6e360b14-a823-4dc5-9800-b2e1cb77d43e"), null, null, "Tyson.Graham@yahoo.com", new Guid("a01a13e5-a8d1-4048-b8b2-24cdfac5f11e") },
                    { new Guid("6e487427-8651-4926-a255-51de702532e1"), null, null, "Dillon.Shanahan26@yahoo.com", new Guid("b3997a22-bce6-473b-9a56-6baca1b5ece7") },
                    { new Guid("6e63e8b5-95b4-4b20-997c-c98288e63c0e"), null, null, "Lynn96@yahoo.com", new Guid("57d5c043-44a4-43bb-80ee-1cbb791b2285") },
                    { new Guid("6eb50f14-7bef-4fdf-92ff-b4c4a576b269"), null, null, "Eino81@hotmail.com", new Guid("73850497-d7e2-4015-bf80-d8fc761772d3") },
                    { new Guid("6ef973ef-7721-49c6-ac87-6e28d7fc105f"), null, null, "Pinkie.Quitzon57@gmail.com", new Guid("e188b38e-8056-446d-96c9-b8979c4fd471") },
                    { new Guid("6f1a665f-f423-45fa-b112-c3d0d14a9c36"), null, null, "Rowan0@yahoo.com", new Guid("9e73d492-68df-4c26-bbd7-c238340416ec") },
                    { new Guid("6f2afe43-7229-48b5-bd70-6cd3b41458d2"), null, null, "Claire_Bahringer@gmail.com", new Guid("c50f147c-0804-4f38-a70a-7b8d4109234d") },
                    { new Guid("6f3f33df-95dc-44ac-8bfb-24074c93dcb3"), null, null, "Lucy34@yahoo.com", new Guid("9b8fcbcf-ce9d-40cf-aa2a-0543ebe6f135") },
                    { new Guid("6fd3fa51-84c4-441c-9e37-8f277988c2af"), null, null, "Eddie75@hotmail.com", new Guid("25cda556-70c4-4bb2-ad33-871e7ca4939c") },
                    { new Guid("70c826b3-b078-4b3a-b066-cb8ff7e35ace"), null, null, "Lilian_Renner@hotmail.com", new Guid("09465da9-1c65-4a00-be4f-5b7144e699f3") },
                    { new Guid("70de9e98-0db9-45f4-a950-11e1f069a594"), null, null, "Rocio_Willms38@gmail.com", new Guid("967d4ff4-7cca-4fd1-a75a-2f73aca9ca0a") },
                    { new Guid("7112f0fb-1805-421f-8c37-40e014453abb"), null, null, "Kiarra.Connelly@yahoo.com", new Guid("db79e848-cfae-4c0f-8859-e5d6af4a311c") },
                    { new Guid("7146db6b-dcea-484f-a2bc-d7a95c9c36a3"), null, null, "Lorenzo_Rolfson89@gmail.com", new Guid("e44b1f8c-951b-48de-a206-672ce80e3e29") },
                    { new Guid("71c3085b-6cf2-4d6a-aeb8-9496df665601"), null, null, "Trever4@yahoo.com", new Guid("b4e4db54-4f23-4365-96a9-cb8bd3cdaecf") },
                    { new Guid("71d06b6e-1943-4cc2-94ce-fda5013efcdc"), null, null, "Reinhold.Schimmel54@gmail.com", new Guid("9dafc6e9-0e56-47f8-8b8b-4ca541841bd0") },
                    { new Guid("71db51ae-8c5a-4303-840f-affb5155a179"), null, null, "Efrain_Mosciski@gmail.com", new Guid("1d118b7f-07b1-49dd-9f7d-5a1e7d8ea4bc") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("71dc8804-e45d-43f8-ac16-02b55f895ca9"), null, null, "Dino.Zemlak@hotmail.com", new Guid("eedd859d-8af5-43b7-8938-5bce7dd89153") },
                    { new Guid("7266b859-ea60-485e-9727-ada5100a0724"), null, null, "Dulce.Morar28@gmail.com", new Guid("abff8b44-2e47-47cd-8158-cb029242cf8c") },
                    { new Guid("72d4b613-6cc1-4a12-956c-eb0eb883fb3d"), null, null, "Price28@gmail.com", new Guid("94e92894-3b19-4c5f-9e95-0ec52116ec92") },
                    { new Guid("734e1b9d-8c3b-41b3-8391-85bcfeedda33"), null, null, "Nikolas43@hotmail.com", new Guid("568a5cfd-171b-413d-addf-fe6ab58aa6d0") },
                    { new Guid("735b82c6-1d5e-475f-8e86-204cd249792e"), null, null, "Maryam91@hotmail.com", new Guid("73977b0d-a6cb-4576-bd4a-b7056acdccd3") },
                    { new Guid("73810369-f64c-4b6c-bbc3-cd202882ba10"), null, null, "Lysanne_McGlynn43@hotmail.com", new Guid("b4e4db54-4f23-4365-96a9-cb8bd3cdaecf") },
                    { new Guid("738980b3-62a1-45cd-8da6-cd425c091633"), null, null, "Westley86@gmail.com", new Guid("ca7879c0-456f-4a95-94ad-0a58b61bfc27") },
                    { new Guid("738ab085-eac4-4127-a070-e1871f395863"), null, null, "Maeve.Reinger@hotmail.com", new Guid("70c04dec-2a46-4304-b6d1-c42204afdab9") },
                    { new Guid("73c7dccf-70b5-4c58-bf0e-4654d0bfa5de"), null, null, "Elise_Fay@yahoo.com", new Guid("ca9a7100-5d5c-406e-8028-d065cd21c772") },
                    { new Guid("73eb8d4d-3a18-48ba-868b-0a63c0eb7ba1"), null, null, "Marlon_Dietrich55@yahoo.com", new Guid("137b1e19-3c26-4708-9428-159387ebcd43") },
                    { new Guid("74532382-5729-4248-b638-36d852e7af38"), null, null, "Jamey6@gmail.com", new Guid("cc549d3d-c127-48fe-9320-69c0367cf0ef") },
                    { new Guid("74ddc7e4-b3f8-422d-ace5-5dd93826ef4b"), null, null, "Jessy_Hettinger@gmail.com", new Guid("f472d28b-1df9-4c84-8ceb-3254f55042e7") },
                    { new Guid("74e54f86-03e5-4034-8286-63eaf2e14ded"), null, null, "Cathrine.MacGyver@gmail.com", new Guid("6172d849-4ee5-486f-8f97-d2bbcfc40084") },
                    { new Guid("75b6bdf2-6f88-4b72-b91e-6cc04c72e6a1"), null, null, "Beverly_Crist3@yahoo.com", new Guid("17b956d2-133d-4289-8a76-4633e194bce0") },
                    { new Guid("75d1fe9e-6ffd-4d59-afbd-416d12ced493"), null, null, "Elda.Gerhold@gmail.com", new Guid("0397b496-e66d-4ab5-942d-0a53948ef201") },
                    { new Guid("75d48686-94fb-4533-8cfd-fc659c51a6b8"), null, null, "Marielle_Mills9@hotmail.com", new Guid("4af7ff34-3014-4da9-ba8e-e93cfaac4eaf") },
                    { new Guid("76543843-1c4c-46b5-90c4-939dcc466625"), null, null, "Flavio.Wehner@gmail.com", new Guid("708b56dd-a529-4229-82e2-2266f01c7942") },
                    { new Guid("767a40a4-3fad-423d-8102-7539ceb83eca"), null, null, "Heaven96@hotmail.com", new Guid("222dda98-6fd2-4619-8709-1b78c7872ca8") },
                    { new Guid("767ce530-90f2-4110-823d-cca214d4135f"), null, null, "Hilbert.Beer93@hotmail.com", new Guid("8e832b0b-a138-409b-b85d-4b68d03a07b6") },
                    { new Guid("77453795-841b-4076-b0b6-3fb349aeb9b9"), null, null, "Delia_Hills@yahoo.com", new Guid("1c5135c6-32f4-4363-a0a3-5a8fb7357df1") },
                    { new Guid("775ff64f-a7ff-4d1b-9cb6-5ed528b584eb"), null, null, "Bernhard76@gmail.com", new Guid("94e92894-3b19-4c5f-9e95-0ec52116ec92") },
                    { new Guid("7792338f-fdac-4c29-8c21-2b339f8921dd"), null, null, "Jayden24@gmail.com", new Guid("3705daaf-a245-497f-b245-acd05a008711") },
                    { new Guid("77b886da-50da-4f77-bc98-340f53cac23f"), null, null, "Reed.Greenfelder31@hotmail.com", new Guid("4bfa50d6-7b76-402d-afe8-4b558ee6165b") },
                    { new Guid("788ea262-4363-4ed3-8f00-43adfda1cb28"), null, null, "Jedediah.Welch@yahoo.com", new Guid("34d672c5-050e-4c3c-8018-0107a72f13f5") },
                    { new Guid("78b03ebf-60fa-4b7c-87b0-d3873e8a5787"), null, null, "Alejandrin_Lesch@gmail.com", new Guid("d9295c19-5c11-40bb-ba7c-c1b368114ac0") },
                    { new Guid("79090de7-5151-45bc-b0fa-fb296981c016"), null, null, "Joey85@yahoo.com", new Guid("8bbc88c0-c35c-496f-b3fc-e18f3d8bad18") },
                    { new Guid("792a5ba9-5e3b-45e0-93b0-9b8880a76fb3"), null, null, "Delia.Haag@hotmail.com", new Guid("b71f69da-e20d-4b25-b2fb-00d5eb1c9002") },
                    { new Guid("7979fe7a-dcbb-4fd0-9f54-aa4c100fb3c7"), null, null, "Nella_Jones73@gmail.com", new Guid("8c7f5100-7603-4d85-9e37-fba6a586f7c8") },
                    { new Guid("7b1fa3ad-ba84-4363-8970-caeeae6a1f2d"), null, null, "Arnulfo36@yahoo.com", new Guid("a7a63c10-9b55-47c6-9d56-8793ee29aafd") },
                    { new Guid("7b4d5dfc-5e4c-4bc9-876d-636c6567aca5"), null, null, "Alec39@yahoo.com", new Guid("d8361619-ae4f-4db1-9eb9-291e4814a381") },
                    { new Guid("7b973d63-4293-4801-befe-0a6414c05ef8"), null, null, "Rosa_Feest@gmail.com", new Guid("b944ae23-efab-4fcb-bda0-6be21e2add96") },
                    { new Guid("7ba31d9d-dd82-47e2-971a-d9c3caa47504"), null, null, "Hazle.Parisian49@yahoo.com", new Guid("7b9acf5a-1eec-4436-8152-103e38ca0953") },
                    { new Guid("7bb3ea7c-62d1-4f57-8d9c-f9c98482b3f2"), null, null, "Gerald77@yahoo.com", new Guid("98222b1e-1352-4ac9-8c47-69a7f0582ef6") },
                    { new Guid("7c4a34c5-5e15-459c-bf2f-01b10c157c90"), null, null, "Charlene.Keebler67@gmail.com", new Guid("222dda98-6fd2-4619-8709-1b78c7872ca8") },
                    { new Guid("7c4f183f-5deb-4380-99c2-40c3bd22824a"), null, null, "Sallie.Rodriguez@hotmail.com", new Guid("93ac31b1-6465-45d3-b0b5-98811dbc77b4") },
                    { new Guid("7c812bb2-632c-43eb-9831-d72d42f65394"), null, null, "Asia51@yahoo.com", new Guid("9f331cb7-b70d-434b-bc28-147a5e624fd8") },
                    { new Guid("7cd48710-adcf-4bda-92ec-caa7e90cb65b"), null, null, "Brady_Volkman@gmail.com", new Guid("4ccb797f-65b1-4b8c-809c-fe110c01052b") },
                    { new Guid("7d92d551-9e2c-4dd3-af18-1a0ae9c90706"), null, null, "Kaylah_Langosh@yahoo.com", new Guid("d9fc54cb-e30e-4a48-b749-08ff99fcff26") },
                    { new Guid("7e5db16f-8f96-4b03-8c5c-9960c5b13319"), null, null, "Johann50@gmail.com", new Guid("3dd4bd2a-4dd8-4988-867a-99041eb6851d") },
                    { new Guid("7f30af00-41ee-4078-9f17-be31a842c9d3"), null, null, "Zoila35@yahoo.com", new Guid("8513debb-cacb-47df-a4d3-e59f2a261b69") },
                    { new Guid("7f3cd58b-4bf9-4321-9d23-a74332ea0298"), null, null, "Xzavier_Aufderhar21@yahoo.com", new Guid("78615ad6-0a03-477e-a515-c98b1a96475d") },
                    { new Guid("7f7b1d69-e724-42c8-9fc6-9ecf0fd2467a"), null, null, "Khalid.Greenfelder66@yahoo.com", new Guid("43b84c41-ad8c-49ff-ae3a-561f6d21e04b") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("7fa79988-12fb-4ac4-bb07-d269b991579c"), null, null, "Anabelle15@gmail.com", new Guid("6dcb62c8-dc29-4e18-aabc-b9f4d6f3d1ce") },
                    { new Guid("80724546-06aa-42b0-8620-7afcaee6afcb"), null, null, "Rosa.Fay8@hotmail.com", new Guid("437bc41c-af0d-4443-809f-276b155b8846") },
                    { new Guid("80975050-f66c-4c73-a380-29d2301efc6c"), null, null, "Ciara.Cruickshank94@yahoo.com", new Guid("e1223f43-016e-41f5-b212-ab70a0ac01e2") },
                    { new Guid("80d0e219-957e-4078-83cc-9b92db9d2601"), null, null, "Aimee65@yahoo.com", new Guid("7805e438-4982-4f20-9e68-baca0c631417") },
                    { new Guid("81b41a6a-2443-4f8d-af4c-7551ea8bbb1b"), null, null, "Dereck.Reichel@yahoo.com", new Guid("24b96e86-5860-47b1-a6ec-9a832bafbb14") },
                    { new Guid("84100e79-d640-43be-ab52-5d939d6a27f9"), null, null, "Eloy36@gmail.com", new Guid("359f112e-4dd6-47fb-995d-9dae092d143b") },
                    { new Guid("84ca134b-116c-482f-aab1-69ce10245934"), null, null, "Nora.Tillman@yahoo.com", new Guid("641c3d4a-a6ff-4cb3-b40a-665b9156a255") },
                    { new Guid("84dafc05-b1d4-41d5-a53d-151d79faa847"), null, null, "Georgianna.Kreiger@yahoo.com", new Guid("a6fc0423-6291-4866-8d02-6faea1986c4e") },
                    { new Guid("85355d29-52b8-4d4b-84c3-2f603ceeab94"), null, null, "Arnoldo31@gmail.com", new Guid("427485d5-0faa-4f9a-9c6f-70317d50831a") },
                    { new Guid("8594fc96-b18c-4e4c-86f3-87a124e7a175"), null, null, "Lilly.Pfeffer13@yahoo.com", new Guid("a4b4b14f-6b7f-4104-b0d2-b8f55417f1e7") },
                    { new Guid("862458a1-c67f-4397-ad4f-386501f9072a"), null, null, "Layne.OKon68@gmail.com", new Guid("f9c15c1c-b6bd-46fd-921b-e1778f14dacf") },
                    { new Guid("864b3a64-ee7f-4c46-8a53-998610235978"), null, null, "Gideon.Dickinson11@yahoo.com", new Guid("abf3ceb3-3421-4454-9686-7b4c13cd1fbf") },
                    { new Guid("86cbd801-4802-4a1a-8868-458b8cc5f0f1"), null, null, "Sunny15@gmail.com", new Guid("861c20c6-b2fe-4d03-a2b4-ae2380f7edc5") },
                    { new Guid("8702bd70-7440-4f1c-981a-8764b30fe673"), null, null, "Rashawn48@hotmail.com", new Guid("cefdf373-98f4-432b-bfc7-baaf121c554a") },
                    { new Guid("87674a55-e008-4cf5-8a30-2e2ccf5ca34a"), null, null, "Pinkie.Kilback@gmail.com", new Guid("4bfa50d6-7b76-402d-afe8-4b558ee6165b") },
                    { new Guid("87bedcfe-0fd5-4ac0-a3e5-5409e3d3e301"), null, null, "Tristin78@gmail.com", new Guid("a6fc0423-6291-4866-8d02-6faea1986c4e") },
                    { new Guid("880bc98d-f0a8-4760-8eb4-8f13c85e747f"), null, null, "Moses.Ernser@hotmail.com", new Guid("c60620ff-d62e-4585-9510-ed612aa89dcb") },
                    { new Guid("883553a0-9282-4e20-9aae-b3da41751fc8"), null, null, "Lorna39@hotmail.com", new Guid("a7a63c10-9b55-47c6-9d56-8793ee29aafd") },
                    { new Guid("88787071-8161-48cd-aaab-40f8ede47fba"), null, null, "Leda43@gmail.com", new Guid("284afcd2-63de-4550-906f-0a1ce11e8244") },
                    { new Guid("88e03dbc-78ea-474a-9441-582643ac8830"), null, null, "Marcia_Walter@gmail.com", new Guid("8adfe810-a4af-41ad-bda0-c1898bdb4d92") },
                    { new Guid("88f2e485-4078-454d-a786-9c23c5de2a70"), null, null, "Lucio_Gutkowski@gmail.com", new Guid("5e2d266d-c2a4-4711-b57e-3656b61d6ad2") },
                    { new Guid("8929cbd0-73a4-4d3a-8bf9-74e262891374"), null, null, "Nora.Schimmel@hotmail.com", new Guid("10a10ed0-e1f4-4de7-b631-e8c7d0d5eaa9") },
                    { new Guid("89538d77-6058-480d-85cd-d30be4984bbc"), null, null, "Verda11@hotmail.com", new Guid("d4409d83-a792-488f-bea4-9e1b42950fc9") },
                    { new Guid("895a204f-e26b-413f-8138-e350336fbafe"), null, null, "Mason_Schultz90@hotmail.com", new Guid("7e5e5ebc-3d4d-451a-884b-00a9d9f53676") },
                    { new Guid("8a26a5d3-4abb-45f6-ac18-bb3d9620a688"), null, null, "Helen60@yahoo.com", new Guid("15cc8bf6-f5ac-435e-a654-84e10e29a1bd") },
                    { new Guid("8a5cfdd0-e31a-4eab-9697-87a60b7a991b"), null, null, "Kari.Thompson29@yahoo.com", new Guid("72b9b70e-980c-47d3-a949-0b0acbdbe9f3") },
                    { new Guid("8abedea0-3ede-4db3-b10c-827607063e25"), null, null, "Tillman.Rippin79@hotmail.com", new Guid("c798d3b3-ea5a-4b3b-a69b-7022aa64fe86") },
                    { new Guid("8b21c2a5-0437-422e-8dca-2abd49229ecb"), null, null, "Arne.Quitzon53@gmail.com", new Guid("cf6839a1-51b8-4ec5-bfec-3cbe48c20160") },
                    { new Guid("8bc00e1c-6110-40c4-be9b-ad5c747d5dd7"), null, null, "Toby.Larkin@yahoo.com", new Guid("fc2635e7-fbe6-403c-bcdf-dc9a65be3352") },
                    { new Guid("8c8bb409-b416-4893-895e-e7692eae4bcb"), null, null, "Forest89@gmail.com", new Guid("1747bd38-8325-47e2-8876-f2ff552a55c8") },
                    { new Guid("8d2ee159-7914-49e7-8e0b-48142aaa6ef1"), null, null, "Magdalen.Zieme79@yahoo.com", new Guid("551cb7a5-2acf-469f-be65-7a549dccf51f") },
                    { new Guid("8d32e0ae-feb3-4090-86af-c4ba81b9c517"), null, null, "Mandy39@gmail.com", new Guid("6172d849-4ee5-486f-8f97-d2bbcfc40084") },
                    { new Guid("8d75af34-9e46-41e4-8c42-0b9a2c9ff381"), null, null, "Adell.Blanda41@hotmail.com", new Guid("d0627291-bbf2-408e-bc02-9ba09faa06bd") },
                    { new Guid("8df37528-a75f-4df8-a576-0c0d9891090b"), null, null, "Janiya21@hotmail.com", new Guid("9ffccffc-cb42-46e5-86d7-6730697facf3") },
                    { new Guid("8e183261-024c-42c8-a60f-2106cf47c988"), null, null, "Alysa.Will@hotmail.com", new Guid("605efc2a-1846-428c-a520-3c8efbd1c5d8") },
                    { new Guid("8f04a3ca-e4ef-4aa6-af39-da63a81f8f64"), null, null, "Prudence46@yahoo.com", new Guid("c4c17769-48f5-471b-ac8e-87a2c17573b4") },
                    { new Guid("8f166a03-82c3-493c-b8a8-7adb29a392a1"), null, null, "Beaulah31@gmail.com", new Guid("013a7602-b915-4485-89ea-d3291ed9cab8") },
                    { new Guid("8fa73b22-a267-47ba-86d0-63dcd08765df"), null, null, "Wilton66@yahoo.com", new Guid("cc549d3d-c127-48fe-9320-69c0367cf0ef") },
                    { new Guid("8fb92e68-918e-4b1a-87cf-58d4ca1d567b"), null, null, "Hal.Upton78@hotmail.com", new Guid("b9974b20-5b3f-4445-a6d7-c4352b53a64c") },
                    { new Guid("9017c3c6-9384-439f-bf0a-6685b2e1d122"), null, null, "Antoinette.Walsh85@yahoo.com", new Guid("6507f7f4-4076-4fff-b89e-4205b52b6408") },
                    { new Guid("902abd5b-a243-47fa-ab2e-d2bacbd8d439"), null, null, "Reed8@hotmail.com", new Guid("73977b0d-a6cb-4576-bd4a-b7056acdccd3") },
                    { new Guid("9095df78-7a85-4bf1-a6f4-8308fd65aacc"), null, null, "Nicolette.Upton@yahoo.com", new Guid("552898bc-d86c-4567-80c9-bdb93739cab5") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("90a0daec-9f68-435e-a762-8bfd55ee9d87"), null, null, "Kathryn_Armstrong99@yahoo.com", new Guid("8606d3d5-5f3e-4f9a-b953-4be892f06c0d") },
                    { new Guid("91c0455e-ab22-4b52-9316-702454e58d71"), null, null, "Verdie.Dach43@hotmail.com", new Guid("d0627291-bbf2-408e-bc02-9ba09faa06bd") },
                    { new Guid("922869e9-da1c-476f-95c2-8eda97b42980"), null, null, "Lora56@yahoo.com", new Guid("ce4c448e-35a5-4243-aa12-b967d2b3da6f") },
                    { new Guid("92e7658d-9bc0-4ae0-aaec-2588483f34ce"), null, null, "Deontae12@gmail.com", new Guid("5a6031a7-d008-4d4c-9a87-857d42759454") },
                    { new Guid("939e619f-faed-49fc-a7c5-43d58105de67"), null, null, "Jakob.Konopelski@hotmail.com", new Guid("c8db4c48-87fc-43bc-b9ef-e88e6764800d") },
                    { new Guid("93ceef60-8757-44bb-accf-d3c243e87335"), null, null, "Darian_Schmeler20@hotmail.com", new Guid("a8a8fdd8-4ded-4cee-9b8c-87f2285d7eab") },
                    { new Guid("93d72bcf-72c4-42fa-b654-8eff9820715e"), null, null, "Neva_DAmore43@gmail.com", new Guid("3dd4bd2a-4dd8-4988-867a-99041eb6851d") },
                    { new Guid("9426d91e-32c3-49b9-bad4-1e6cf6154b19"), null, null, "Karlie.Harvey@hotmail.com", new Guid("7771e104-7d9f-4097-8375-a33ad264e1d8") },
                    { new Guid("946a637a-6adc-44b7-953f-caa1bd13d65c"), null, null, "Vincent_Tremblay10@hotmail.com", new Guid("6db49be1-1b9b-4fd0-8b2d-52ae151f7432") },
                    { new Guid("9497714b-e501-47a4-91dc-e42149e79548"), null, null, "Jules31@gmail.com", new Guid("4d65579c-7caa-4a73-aec4-ebf5de2054ab") },
                    { new Guid("964ef7dc-2b03-430f-b2ba-fdc7dd5af593"), null, null, "Giuseppe96@gmail.com", new Guid("7902b014-f441-4bad-a55f-7656352c84e7") },
                    { new Guid("9704fc45-d80c-4bbe-beba-4234909fc412"), null, null, "Kathlyn.Mann@yahoo.com", new Guid("70c04dec-2a46-4304-b6d1-c42204afdab9") },
                    { new Guid("9788d862-ebe5-4044-af5a-3cc499e790d5"), null, null, "Shaniya.Kirlin@gmail.com", new Guid("0397b496-e66d-4ab5-942d-0a53948ef201") },
                    { new Guid("983888e8-f894-4470-97fa-1fcdf298a0c5"), null, null, "Vivianne.Graham2@yahoo.com", new Guid("b67eec58-0f42-4a35-a871-09c1ddaddd4b") },
                    { new Guid("986613e1-c9d3-483f-a708-b8b960ac2501"), null, null, "Teresa.Emmerich60@yahoo.com", new Guid("aa053e12-232a-4d5d-8b1f-0803fd8b7767") },
                    { new Guid("98abe816-47f5-43b0-9de8-c54586a4f095"), null, null, "Enrico79@hotmail.com", new Guid("7f910a03-763a-4cdb-bbcb-8241bae6fc96") },
                    { new Guid("9902f340-20da-4c8d-8673-de4a52e81aaf"), null, null, "Velva.Price@yahoo.com", new Guid("997402b2-514c-445f-9988-ae18a101181e") },
                    { new Guid("9a6362ec-ba22-4252-8534-afd27c002968"), null, null, "Aleen16@gmail.com", new Guid("fc15fcf7-014b-4521-910c-8a4a05ae7df9") },
                    { new Guid("9a7b6a87-d490-4f7a-8087-86092f21a801"), null, null, "Orville.Prosacco@yahoo.com", new Guid("aa1380ad-62cc-4108-817a-4ac56a2c382d") },
                    { new Guid("9a9cc706-fbf9-4eaf-b04e-f0c072147080"), null, null, "Ottilie.Wilderman15@gmail.com", new Guid("d08dab84-c369-4193-b4fb-bbd252c59cc5") },
                    { new Guid("9b4cf2c6-1592-4f50-9696-5ededb15c69b"), null, null, "Danial.Heaney@yahoo.com", new Guid("d9fc54cb-e30e-4a48-b749-08ff99fcff26") },
                    { new Guid("9ba1d351-12fd-40d5-8e9f-a9e2dd59aec5"), null, null, "Markus_Senger45@hotmail.com", new Guid("8bbc87aa-2bdb-4898-83a2-ca540a697ac0") },
                    { new Guid("9c2b94c8-551b-4945-9e02-3bbd2e113f81"), null, null, "Amalia_Becker14@hotmail.com", new Guid("b71f69da-e20d-4b25-b2fb-00d5eb1c9002") },
                    { new Guid("9cabfdc0-4531-4840-929c-76e470112fa8"), null, null, "Mathilde.Smith@yahoo.com", new Guid("88155035-c6f4-450c-bd25-3d3e9c9d8f5d") },
                    { new Guid("9d20a170-b19e-4e8a-90f8-cf8e6919a6bc"), null, null, "Cordia36@yahoo.com", new Guid("5441f683-8cec-4fb5-96c6-2fa82e7997d3") },
                    { new Guid("9d2117c0-4027-40d3-96d5-15c0bcd39870"), null, null, "Eloy_Wuckert@yahoo.com", new Guid("dfa0bf0e-13dc-416f-bb54-aaeb47a68545") },
                    { new Guid("9d371040-2fdf-47dc-ad72-db05ffd8bf26"), null, null, "Hester.Hackett@gmail.com", new Guid("9a38b671-5580-4658-abf4-c1fc9ce2be0b") },
                    { new Guid("9d9861f1-4c4b-4e82-8664-11a9d4369b07"), null, null, "Danielle18@yahoo.com", new Guid("96357562-82d6-4394-b4bf-5b698e1ad612") },
                    { new Guid("9dfdbcbc-965c-49ab-a89e-8d6b07e25bea"), null, null, "Isaac53@hotmail.com", new Guid("97c89012-688a-4d00-9708-03d8cb08dc2e") },
                    { new Guid("9e3aa6f3-3b3f-437f-8eed-b0d9264b8068"), null, null, "Lavon_Lueilwitz40@hotmail.com", new Guid("77332645-fb25-478f-998c-36dd38aaba91") },
                    { new Guid("9e787aac-b59e-4d4f-ab15-0faa560dcb9c"), null, null, "Mabel_McCullough46@yahoo.com", new Guid("17b956d2-133d-4289-8a76-4633e194bce0") },
                    { new Guid("9e90cf6a-c7e0-4c72-9c6a-5f264d650c84"), null, null, "Grady22@gmail.com", new Guid("6dcb62c8-dc29-4e18-aabc-b9f4d6f3d1ce") },
                    { new Guid("9ecb7c31-4af3-4279-998f-fdeaed613e74"), null, null, "Roselyn_Zulauf@gmail.com", new Guid("c50f147c-0804-4f38-a70a-7b8d4109234d") },
                    { new Guid("9f06653b-0262-48db-b638-a0a20adbf093"), null, null, "Alexandrea_Kreiger@yahoo.com", new Guid("b944ae23-efab-4fcb-bda0-6be21e2add96") },
                    { new Guid("9f3bafd0-0315-4798-8911-ba0c1802af1f"), null, null, "Cecile_Witting18@hotmail.com", new Guid("f044a50f-e46f-4992-b8ae-47aa00e79d4d") },
                    { new Guid("9f625e88-676a-43a1-b65f-0c326fd4effe"), null, null, "Macey65@hotmail.com", new Guid("857e5ff4-368c-45c8-909c-9cb05ea33802") },
                    { new Guid("9f8acda1-c8ad-4e0d-aa2e-21835c69114e"), null, null, "Krista_Yost33@hotmail.com", new Guid("df250436-821d-48ab-9508-ab3df0550e27") },
                    { new Guid("9fcae15e-5b08-4eb8-bd43-c653da4559a3"), null, null, "Gabe7@yahoo.com", new Guid("d0fc0768-b3a0-4f82-affc-e355dc4101f4") },
                    { new Guid("a00829a9-c544-4e7f-a6bd-ce5ff220e5b5"), null, null, "Claudie82@hotmail.com", new Guid("4ccb797f-65b1-4b8c-809c-fe110c01052b") },
                    { new Guid("a021d426-f921-4a8f-8370-b1be32419cd6"), null, null, "Gregorio.Durgan@gmail.com", new Guid("6a6686d3-6711-42f4-b08b-ada2bf39be54") },
                    { new Guid("a035acd3-c2e1-4a7c-bdd7-c903737d86cb"), null, null, "Muriel_Klocko50@yahoo.com", new Guid("7e5e5ebc-3d4d-451a-884b-00a9d9f53676") },
                    { new Guid("a0771c56-4e7c-489e-9645-54d0b4bf7891"), null, null, "Maud80@gmail.com", new Guid("0a69540b-ce9e-427c-8970-9f311fba0c21") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("a0f1db1b-f721-4100-b704-30216efc53e2"), null, null, "Wendell9@gmail.com", new Guid("dc04df94-1448-4899-bec4-692b13ea2748") },
                    { new Guid("a128c0a0-906d-4b46-8313-2787f9a525a4"), null, null, "Anne94@hotmail.com", new Guid("e2dba597-b132-4b1a-a46f-540ebc581408") },
                    { new Guid("a22a07d9-3935-4734-9df4-83c214bb95c8"), null, null, "Alayna_Stark63@gmail.com", new Guid("5a13878d-22a4-47a3-8eb8-3f4be375baee") },
                    { new Guid("a2414612-3291-4733-bcbd-ed4e6fbd043e"), null, null, "Cecilia.Frami@yahoo.com", new Guid("ef100efa-deb4-4516-9a15-38df8ff7e396") },
                    { new Guid("a25a0cf7-80f9-44d1-9cb8-91e33e75d3d4"), null, null, "Abraham.Terry@yahoo.com", new Guid("aee768a4-2b67-47da-a692-ab2b1cd95c27") },
                    { new Guid("a2b3e82d-4060-4df0-9c75-1bc7f5e528fd"), null, null, "Leann_OKeefe29@yahoo.com", new Guid("86139076-e779-453a-8f87-64e1bfeeeccc") },
                    { new Guid("a3223f1a-d917-4cb1-bc8e-b58ff9dfadba"), null, null, "Jairo_Lebsack@hotmail.com", new Guid("568a5cfd-171b-413d-addf-fe6ab58aa6d0") },
                    { new Guid("a39b3756-913d-42fe-828b-5248b355d233"), null, null, "Madge.Cormier60@yahoo.com", new Guid("9f331cb7-b70d-434b-bc28-147a5e624fd8") },
                    { new Guid("a3bee04b-ccd7-4a45-885c-bf84ccbea766"), null, null, "Cathrine10@gmail.com", new Guid("8606d3d5-5f3e-4f9a-b953-4be892f06c0d") },
                    { new Guid("a47b3a75-a0cf-4676-8f05-20266440002b"), null, null, "Allene38@gmail.com", new Guid("4d792f39-989a-48bc-8528-2bda17a5967a") },
                    { new Guid("a4c44d8c-b8b3-4981-8a82-b31d71ccf06f"), null, null, "Dominic.Towne36@hotmail.com", new Guid("1e47206c-cbc9-48ff-becb-ea5c84ec9719") },
                    { new Guid("a52933a9-6ee4-41f7-8eb4-6e7ba3088f1a"), null, null, "Ibrahim_Larkin@hotmail.com", new Guid("d9fc54cb-e30e-4a48-b749-08ff99fcff26") },
                    { new Guid("a54e50bc-e3fe-4d50-bd50-f224aa471bf6"), null, null, "Deborah_Wyman@gmail.com", new Guid("4bfa50d6-7b76-402d-afe8-4b558ee6165b") },
                    { new Guid("a55ddd4c-23c6-46ca-b288-e6371416b9ef"), null, null, "Lucinda.Prosacco72@yahoo.com", new Guid("6dcb62c8-dc29-4e18-aabc-b9f4d6f3d1ce") },
                    { new Guid("a59d7472-f491-45a1-ba2c-b7feca5e5aaf"), null, null, "Adeline.Monahan@hotmail.com", new Guid("fc7807f7-2e15-4c19-8500-ea40f337d9de") },
                    { new Guid("a5a1c4e1-9093-4bca-be3c-ca23f0ce8167"), null, null, "Christophe_Schultz95@yahoo.com", new Guid("57d5c043-44a4-43bb-80ee-1cbb791b2285") },
                    { new Guid("a5b088cb-cb5e-4a15-956d-7daf47a3fe11"), null, null, "Eula_Renner@gmail.com", new Guid("24b96e86-5860-47b1-a6ec-9a832bafbb14") },
                    { new Guid("a754a414-8d2a-4267-8e84-6ea19371aebc"), null, null, "Princess32@gmail.com", new Guid("e28ae980-81b6-4d5f-8748-b7cb3f0f995d") },
                    { new Guid("a77685b5-a0d0-445f-aa5f-dcc17b4aa1e6"), null, null, "Darrel.White68@gmail.com", new Guid("605efc2a-1846-428c-a520-3c8efbd1c5d8") },
                    { new Guid("a894fca4-e2ad-4a68-96d9-053f386d8e1b"), null, null, "Kay_Reichel12@yahoo.com", new Guid("fc2635e7-fbe6-403c-bcdf-dc9a65be3352") },
                    { new Guid("a89e76d0-c9a9-4f0e-9e6a-27d1f05824da"), null, null, "Ernestina.Raynor41@hotmail.com", new Guid("9e4f824d-b29a-4ec5-b3a1-111d46f41ecb") },
                    { new Guid("a924dc9e-6f38-4308-91b2-8fb3f2cce453"), null, null, "Chanel_Spencer@gmail.com", new Guid("8892b0e2-0aef-404c-8681-2866126b786f") },
                    { new Guid("a928df0e-8337-4173-831d-5cf6dca99f44"), null, null, "Victor50@yahoo.com", new Guid("69536a6d-5fc0-40dc-96ff-96cfa2e2ddde") },
                    { new Guid("a964f1ca-83ad-4140-aa25-32f3bfe703d6"), null, null, "Jennings57@gmail.com", new Guid("25cda556-70c4-4bb2-ad33-871e7ca4939c") },
                    { new Guid("a990c135-0c7d-443c-95d7-e18a6e1063e8"), null, null, "Orland.Koch19@yahoo.com", new Guid("17b956d2-133d-4289-8a76-4633e194bce0") },
                    { new Guid("a9c20280-dd34-4d4e-9a21-e1780c11a3ac"), null, null, "Rosalinda_Mills@yahoo.com", new Guid("dfa0bf0e-13dc-416f-bb54-aaeb47a68545") },
                    { new Guid("aa2bb154-2698-4f17-8b9c-6f278736f949"), null, null, "Rebeka.OConnell@yahoo.com", new Guid("e27f9603-32f8-4066-bf07-4ab692c8350b") },
                    { new Guid("aa38e0ff-5e09-4702-a46d-a0af1a76d5fb"), null, null, "Arvilla.Medhurst46@hotmail.com", new Guid("284afcd2-63de-4550-906f-0a1ce11e8244") },
                    { new Guid("aa47e604-2b0f-4994-be6c-1624976e5ad1"), null, null, "Riley.Rohan94@yahoo.com", new Guid("dffee49d-d296-4315-aefd-9602dd01358c") },
                    { new Guid("aa5d4532-e5dd-49ac-b011-ec3325fef90a"), null, null, "Matt25@gmail.com", new Guid("ed54e83f-5702-4289-98fb-949b73140a47") },
                    { new Guid("aa8c497b-c44c-4c08-9588-81963bf396ef"), null, null, "Maeve32@hotmail.com", new Guid("7b354f95-20a6-4d69-abe1-b5a212feb069") },
                    { new Guid("aa97dc62-32cd-4939-ab27-2824f5a70bc3"), null, null, "Nathen5@gmail.com", new Guid("ca9a7100-5d5c-406e-8028-d065cd21c772") },
                    { new Guid("aab7fe85-4bd9-4900-b97d-e00fd4a72db8"), null, null, "Demetrius.Davis27@yahoo.com", new Guid("ffdf2e3d-14e1-47fc-a87f-43ee44597c72") },
                    { new Guid("aad94610-01dd-45fd-9d03-dd2f4d3f0122"), null, null, "Jayme_Hansen@hotmail.com", new Guid("137b1e19-3c26-4708-9428-159387ebcd43") },
                    { new Guid("aba873cb-be59-4293-b51d-28fc7e97f2bc"), null, null, "Joany.Hilpert@yahoo.com", new Guid("c561cc5e-190d-4a91-8ea9-d03583fa3f86") },
                    { new Guid("ac259826-56bb-4f02-b6c9-c582355bddec"), null, null, "Hermann.Stoltenberg@gmail.com", new Guid("4a254852-2316-4300-99be-6d54e3eeac93") },
                    { new Guid("ac482de5-cf92-4eef-856c-e46fcffd401c"), null, null, "Lucienne68@gmail.com", new Guid("c1dedd78-34a2-4542-a585-a6ba740f5856") },
                    { new Guid("ac6af5ad-d46f-42ff-870f-6a3800dc47de"), null, null, "Devante.Green26@hotmail.com", new Guid("6375150d-9633-494e-ba79-b55f87d56afa") },
                    { new Guid("ac6ebc3c-3256-4c8d-a7b9-558ee51e872a"), null, null, "Nicole47@yahoo.com", new Guid("96357562-82d6-4394-b4bf-5b698e1ad612") },
                    { new Guid("ac72f116-06d4-45b6-b7be-258a24356064"), null, null, "Letha_Buckridge89@hotmail.com", new Guid("4d792f39-989a-48bc-8528-2bda17a5967a") },
                    { new Guid("acae0aaf-74f6-46ac-86c5-0ed28fb593b0"), null, null, "Kailee.Boyle@hotmail.com", new Guid("a161bc80-bb44-439e-bb80-442569d93b23") },
                    { new Guid("ad16581c-8bab-42ee-90cd-708371a9b5a0"), null, null, "Domingo.Glover@hotmail.com", new Guid("4ec972f7-f6d0-4660-943e-5ad3d2557cfe") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("ad16a2e8-c2c1-4f65-a398-0a495ccf31ae"), null, null, "Meda11@gmail.com", new Guid("0b440e9a-ee26-43ee-9d40-46328f22a228") },
                    { new Guid("ad3664d7-b4e0-4af7-b8d3-16328ac2f193"), null, null, "Cathryn95@hotmail.com", new Guid("d1fdc728-523b-49bf-b2d8-eee9a8bb93d1") },
                    { new Guid("ad75239e-cde4-438c-9f8b-1d84a5993139"), null, null, "Finn.Hickle@yahoo.com", new Guid("a64a13ca-2754-4769-a254-32716c64c908") },
                    { new Guid("ad82e44f-e4a5-4cd2-bdf1-8d6e29cc21f1"), null, null, "Hugh99@yahoo.com", new Guid("e58d2261-638d-41ed-b5bf-55b3a94546e1") },
                    { new Guid("ada57151-6299-4447-b0f5-22ed50b007f2"), null, null, "Mylene_Gulgowski@gmail.com", new Guid("78615ad6-0a03-477e-a515-c98b1a96475d") },
                    { new Guid("adeb3053-2c89-4e45-8a31-9f64a89fc34c"), null, null, "Yadira_Nolan@yahoo.com", new Guid("fc7807f7-2e15-4c19-8500-ea40f337d9de") },
                    { new Guid("ae5fb524-5e8f-4cd2-aa2f-89d393dd4081"), null, null, "Aurelia.Bergnaum74@yahoo.com", new Guid("7889ec96-3dce-40c9-a3d9-1dabf9642602") },
                    { new Guid("af9c6416-49e6-402b-b813-f00573471bb1"), null, null, "Catharine82@hotmail.com", new Guid("641c3d4a-a6ff-4cb3-b40a-665b9156a255") },
                    { new Guid("afd91963-d77d-4635-9eb8-44f0539804f2"), null, null, "Cristina97@hotmail.com", new Guid("3dd4bd2a-4dd8-4988-867a-99041eb6851d") },
                    { new Guid("b06ddcb4-16a5-4845-b2bb-0daa1bcd439a"), null, null, "Elissa_Leffler26@yahoo.com", new Guid("997402b2-514c-445f-9988-ae18a101181e") },
                    { new Guid("b137700b-12c6-44d0-b005-db97eb0d088d"), null, null, "Kelton_Dietrich72@hotmail.com", new Guid("ac2d4745-386c-4c13-a217-d9e2d9b842df") },
                    { new Guid("b14d1bfc-634e-48dc-8881-9607a6872901"), null, null, "Sharon.Hills20@hotmail.com", new Guid("ffdf2e3d-14e1-47fc-a87f-43ee44597c72") },
                    { new Guid("b16fe388-a847-4d24-b746-0612ea3923d9"), null, null, "Lambert30@gmail.com", new Guid("c1dedd78-34a2-4542-a585-a6ba740f5856") },
                    { new Guid("b1f88ec8-0b9b-4865-bd8a-62a0679ff67d"), null, null, "Jermaine.Kertzmann@gmail.com", new Guid("d666c5aa-5c03-4391-8629-5cc681422ca2") },
                    { new Guid("b268fa76-3b47-44b2-8574-7f90ff155137"), null, null, "Anthony_Mohr@gmail.com", new Guid("c3f40de8-9c2b-4f97-b99a-a3d5f6431b27") },
                    { new Guid("b280032b-d2db-4b36-bb8d-dd8ec4bbf5c5"), null, null, "Keshaun.Auer@hotmail.com", new Guid("89c19062-b085-4717-8960-680ec5f619e0") },
                    { new Guid("b2b64085-6b1e-4b8e-ac6f-dec2856452e8"), null, null, "Mateo_Pouros@yahoo.com", new Guid("5ffbbdb6-b588-4eef-811a-4b39d217f0a8") },
                    { new Guid("b2d7acab-11fb-47f3-8a52-28eb854e3704"), null, null, "Maybelle75@hotmail.com", new Guid("3aa0613b-0255-46fa-9fc9-f73e67ec6962") },
                    { new Guid("b2dfc912-7cef-40a8-a5f8-cc8c447357e3"), null, null, "Dominic_Kuvalis@hotmail.com", new Guid("d8361619-ae4f-4db1-9eb9-291e4814a381") },
                    { new Guid("b3284058-8469-4ae2-b8db-d10981a1309c"), null, null, "Nicole72@gmail.com", new Guid("09465da9-1c65-4a00-be4f-5b7144e699f3") },
                    { new Guid("b3376cd9-a986-46cc-910a-d947a639a1fa"), null, null, "Grant_Mitchell30@yahoo.com", new Guid("3dc1a6db-3bf2-4650-b501-abf7ef284b3c") },
                    { new Guid("b339bf89-e86f-412f-a0f1-407e93b8e898"), null, null, "Destinee_Strosin94@gmail.com", new Guid("f472d28b-1df9-4c84-8ceb-3254f55042e7") },
                    { new Guid("b35f95ea-63e0-4418-ac27-6fd14b64a07d"), null, null, "Ellie.McDermott@gmail.com", new Guid("c431ef46-de70-4dba-a2b4-061b2a219ebc") },
                    { new Guid("b381ded3-9dc2-4f84-97d9-1c423d6efed5"), null, null, "Kirsten.Hauck@gmail.com", new Guid("8e8fd0f7-2809-49f2-9c1e-cbeb885b2de7") },
                    { new Guid("b3c4ddbf-443d-40fa-bd52-d1c502d8ff08"), null, null, "Beau11@hotmail.com", new Guid("22c74cee-2548-4aef-ab56-019f64d2fb3e") },
                    { new Guid("b43a12dc-0fae-42a6-8338-9b0f26d92dae"), null, null, "Bernadine24@hotmail.com", new Guid("3705daaf-a245-497f-b245-acd05a008711") },
                    { new Guid("b43c9e93-2b49-42a3-a07b-ee3bf70e8bfe"), null, null, "Allene_Sporer67@yahoo.com", new Guid("eedd859d-8af5-43b7-8938-5bce7dd89153") },
                    { new Guid("b43defcc-5589-47d6-94cc-17b7573f559f"), null, null, "Jane31@gmail.com", new Guid("7902b014-f441-4bad-a55f-7656352c84e7") },
                    { new Guid("b48f0ffa-3fe6-4fc8-9a3d-54837418ce4f"), null, null, "Alexanne93@hotmail.com", new Guid("22c74cee-2548-4aef-ab56-019f64d2fb3e") },
                    { new Guid("b4c31955-d650-413d-bfb0-875cce6139a5"), null, null, "Opal.OConner78@hotmail.com", new Guid("89c19062-b085-4717-8960-680ec5f619e0") },
                    { new Guid("b4c6cca4-794b-4372-ae46-14cc40e32893"), null, null, "Louisa.Conn@hotmail.com", new Guid("4d65579c-7caa-4a73-aec4-ebf5de2054ab") },
                    { new Guid("b5404ab9-aca9-4752-9419-d8912d0ee1e7"), null, null, "Alexzander_Bergnaum@hotmail.com", new Guid("8bbc88c0-c35c-496f-b3fc-e18f3d8bad18") },
                    { new Guid("b549f045-3e70-46f1-8662-1b7a7ec4ba96"), null, null, "Elbert_Waelchi@yahoo.com", new Guid("96389a1d-3bc8-465b-ba35-3027877a9981") },
                    { new Guid("b5a284ff-e0ab-4925-918b-67887b3d331a"), null, null, "Brenna64@yahoo.com", new Guid("d9295c19-5c11-40bb-ba7c-c1b368114ac0") },
                    { new Guid("b5a5f912-88c3-41f7-abeb-648282241086"), null, null, "Shad35@yahoo.com", new Guid("b44b2dc0-6e21-4d7d-a788-6c4e66d96402") },
                    { new Guid("b61e6657-c5f1-4ce2-9f9d-39616534642b"), null, null, "Kimberly.Spinka19@hotmail.com", new Guid("fc2635e7-fbe6-403c-bcdf-dc9a65be3352") },
                    { new Guid("b64659ce-75c9-4b09-a42d-0d29aee428f4"), null, null, "Serena_Hoeger@hotmail.com", new Guid("b71f69da-e20d-4b25-b2fb-00d5eb1c9002") },
                    { new Guid("b6c0623e-83ca-4223-91a7-0734bdb9f301"), null, null, "Joaquin.Morar58@hotmail.com", new Guid("ef14d144-d1c3-49fb-9e25-1889be79f4e3") },
                    { new Guid("b6c26f13-6004-4cef-8780-54ae829d064a"), null, null, "Abby.Ryan@hotmail.com", new Guid("5e0e0eed-1c83-4b51-8938-5bab69316dab") },
                    { new Guid("b6f9adc1-a7cd-427e-9ba4-f5f450e1405b"), null, null, "Lee81@yahoo.com", new Guid("4952ad1a-3fe2-4d0a-a38e-1e28e3808afd") },
                    { new Guid("b7f478fe-25c6-46af-88c7-2ecb03672dba"), null, null, "Ilene73@hotmail.com", new Guid("34d672c5-050e-4c3c-8018-0107a72f13f5") },
                    { new Guid("b801e05c-2359-4224-8a8e-91891fcb60a0"), null, null, "Hellen_Jerde23@hotmail.com", new Guid("0ffea79c-1eaa-4ef4-b27f-e6c525534682") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("b87d718c-22eb-4bcb-b653-a6b51c11ee13"), null, null, "April44@gmail.com", new Guid("5effd297-ddf3-4f40-afed-c85e49e3d248") },
                    { new Guid("b89c9f5a-f9a1-4956-95c7-a700c5c23f56"), null, null, "Halie60@hotmail.com", new Guid("eedd859d-8af5-43b7-8938-5bce7dd89153") },
                    { new Guid("b8b72291-e267-40b0-9592-891ba5c99be8"), null, null, "Melba.Monahan@yahoo.com", new Guid("02df2ae2-d7d0-47a4-aeae-e733e06bb1d0") },
                    { new Guid("b93f6f22-5f55-43a4-b766-377e68389244"), null, null, "Meggie8@yahoo.com", new Guid("6ee9a7d3-8695-4b4a-9a7f-e035a03a4cc3") },
                    { new Guid("b99e5f00-157c-40bb-a256-4a31bce05779"), null, null, "Nikko.Langworth21@hotmail.com", new Guid("5d6854b6-463d-4c99-844f-2b03c65e196b") },
                    { new Guid("b9f4e8b9-a6b8-4d05-9325-bddca7b812ff"), null, null, "Mazie_Jones@hotmail.com", new Guid("3ca63884-385c-4ae8-ac07-f3dc2df24aae") },
                    { new Guid("ba0aa021-98d0-468b-aa56-a0f1a98f448f"), null, null, "Elmo_Dietrich97@gmail.com", new Guid("96389a1d-3bc8-465b-ba35-3027877a9981") },
                    { new Guid("bac1d78e-6fdc-4523-b037-a35b4ee2cede"), null, null, "Giovanny.Doyle86@gmail.com", new Guid("abf3ceb3-3421-4454-9686-7b4c13cd1fbf") },
                    { new Guid("bac4b7ff-4a60-4ca0-abf1-0c1bddf7f814"), null, null, "Isabel63@hotmail.com", new Guid("97d70a43-949c-4c03-9da7-fc16fdc0c86d") },
                    { new Guid("baeb6651-ed8c-41f6-b43e-9f244cf4b852"), null, null, "Skye_Weissnat@gmail.com", new Guid("d08dab84-c369-4193-b4fb-bbd252c59cc5") },
                    { new Guid("bb44af42-1823-4ffd-b9dc-b56429816766"), null, null, "Zaria.Lynch42@gmail.com", new Guid("a01a13e5-a8d1-4048-b8b2-24cdfac5f11e") },
                    { new Guid("bb7f394c-73a0-45e7-99f8-5938e857d098"), null, null, "Virginia99@yahoo.com", new Guid("966d5ef1-e601-407d-86be-887c8e79a449") },
                    { new Guid("bbaa15d9-5eae-40d6-9940-7880f8c25a1d"), null, null, "Arlene_Wuckert12@yahoo.com", new Guid("69536a6d-5fc0-40dc-96ff-96cfa2e2ddde") },
                    { new Guid("bc0e57c6-16a5-40f3-a9f7-e2e27f62e921"), null, null, "Elenor_Ledner65@yahoo.com", new Guid("97d70a43-949c-4c03-9da7-fc16fdc0c86d") },
                    { new Guid("bc9dec63-cc59-4516-87f7-a3fb25f2ddf9"), null, null, "Edmond_Keebler@gmail.com", new Guid("0ffea79c-1eaa-4ef4-b27f-e6c525534682") },
                    { new Guid("bcf7ac4b-c5bb-4db3-a9ed-b91c7932d475"), null, null, "Francesca_Raynor77@gmail.com", new Guid("cd3bba51-ecbd-472a-a962-7f603574b446") },
                    { new Guid("bcf9dcf1-35ae-45be-a1bc-8721c8d19224"), null, null, "Mathias36@yahoo.com", new Guid("bcb5583b-3b55-4ea8-b016-f74baf89e99a") },
                    { new Guid("bd61cc80-7e8b-49ce-a716-8e26a58d5618"), null, null, "Alene85@hotmail.com", new Guid("857e5ff4-368c-45c8-909c-9cb05ea33802") },
                    { new Guid("bd8bea8b-f11b-429e-8555-034832017fdf"), null, null, "Lori.Hintz@gmail.com", new Guid("4bffa9b9-a7ae-4dd6-b87b-dbcad3737bfd") },
                    { new Guid("be426865-89b5-46da-adef-d6089b87763d"), null, null, "Cecelia.Miller99@yahoo.com", new Guid("4ec972f7-f6d0-4660-943e-5ad3d2557cfe") },
                    { new Guid("be97e634-1fa3-4089-a038-0819857fa6f8"), null, null, "Ian_Spinka@hotmail.com", new Guid("e807eb16-5caf-4274-9ff7-5027ed83325c") },
                    { new Guid("bed50122-d0ad-4b57-9644-2aa8192909c8"), null, null, "Marquise76@yahoo.com", new Guid("641c3d4a-a6ff-4cb3-b40a-665b9156a255") },
                    { new Guid("bf8fe123-a198-4c00-95df-8badae2b00c6"), null, null, "Walton_Gutmann@yahoo.com", new Guid("967d4ff4-7cca-4fd1-a75a-2f73aca9ca0a") },
                    { new Guid("bfc32a8e-824e-4d4f-af6d-bd8784616d8c"), null, null, "Georgianna.Sipes90@yahoo.com", new Guid("4952ad1a-3fe2-4d0a-a38e-1e28e3808afd") },
                    { new Guid("bfd4b3ee-9959-4fbc-b889-48e8547e2235"), null, null, "Charity21@yahoo.com", new Guid("8513debb-cacb-47df-a4d3-e59f2a261b69") },
                    { new Guid("bffc8069-7e7b-4585-ae23-7d5bad02e846"), null, null, "Agustin13@hotmail.com", new Guid("18314b53-d5e3-48fa-8ad6-dc84c3baa1ff") },
                    { new Guid("c001882c-366c-414b-9c90-77a332719c6d"), null, null, "Abelardo.Watsica9@gmail.com", new Guid("d184b2bf-159f-4b4e-83e0-4f0bb6184d14") },
                    { new Guid("c007476e-de66-4bbd-b5c7-d4452b578a70"), null, null, "Jamie_Toy@gmail.com", new Guid("b3997a22-bce6-473b-9a56-6baca1b5ece7") },
                    { new Guid("c101845d-6677-4752-bc57-11632372bf8e"), null, null, "Rey.Sanford69@gmail.com", new Guid("a3a7c05f-2de2-47a6-9d73-3dc95cb0a4bf") },
                    { new Guid("c10421a2-8837-4b51-86f5-1ca0a85854f2"), null, null, "Mazie96@gmail.com", new Guid("9a799371-7ad4-44c8-bcc3-759981e1573a") },
                    { new Guid("c10900c5-4607-4187-aeb1-dae3c5ba0867"), null, null, "Anais65@yahoo.com", new Guid("26ad372f-ab3d-49d6-a283-d78f71a0b97b") },
                    { new Guid("c109e266-3659-40a2-bf29-74c37eac2907"), null, null, "Laney_Kerluke71@yahoo.com", new Guid("9a799371-7ad4-44c8-bcc3-759981e1573a") },
                    { new Guid("c1115777-ef92-475f-aa6e-eaa3bf83163e"), null, null, "Rex.Macejkovic51@gmail.com", new Guid("4bb403d4-8670-466f-a9dc-17dd09c9d546") },
                    { new Guid("c140b57e-28b8-4fff-b290-df6a809ee472"), null, null, "Velva_Donnelly@yahoo.com", new Guid("63ce22ac-8a36-4fb9-bf6d-61e02101f5d7") },
                    { new Guid("c1b184c7-3647-4e1c-ae17-3c0bd70940be"), null, null, "Brigitte9@gmail.com", new Guid("e28ae980-81b6-4d5f-8748-b7cb3f0f995d") },
                    { new Guid("c1d9adcd-6cde-4e90-a6a6-857fb57b887b"), null, null, "Russ_Okuneva@gmail.com", new Guid("68fd726f-e5e4-4755-a477-4727a0a9f4b8") },
                    { new Guid("c25b4966-54b9-4ca3-8603-ebeaf8e0a2ea"), null, null, "Beau80@gmail.com", new Guid("c3f74963-e8a7-4598-bde6-0b7eb8dc16d8") },
                    { new Guid("c2667347-77d6-454d-8bed-f08eecd6b36e"), null, null, "Felicity_Heathcote@gmail.com", new Guid("26ad372f-ab3d-49d6-a283-d78f71a0b97b") },
                    { new Guid("c2fdbb93-20f4-4caf-9d4d-bc2f3f9dc322"), null, null, "Jacky.Bauch@gmail.com", new Guid("2eb253e8-852b-4b59-bbd3-41b1d962644b") },
                    { new Guid("c30a9d5f-a994-48fd-803f-3d8334e588d2"), null, null, "Quincy_Mayer38@gmail.com", new Guid("8bbc87aa-2bdb-4898-83a2-ca540a697ac0") },
                    { new Guid("c30e58b9-8bfc-451b-a365-f3ab4d11b513"), null, null, "Halie_McLaughlin41@gmail.com", new Guid("777e0877-9079-4ecc-a52b-f0bf5734b939") },
                    { new Guid("c34fbb81-06e7-4f7b-80b7-90b2eead76e3"), null, null, "Hazle.Mueller49@hotmail.com", new Guid("3705daaf-a245-497f-b245-acd05a008711") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("c3d0dd93-0f88-42e4-a27b-7eb6f3b78350"), null, null, "Lizeth61@hotmail.com", new Guid("d1fdc728-523b-49bf-b2d8-eee9a8bb93d1") },
                    { new Guid("c3e7c58a-309e-4ee7-9f1b-021d7efea039"), null, null, "Estevan94@gmail.com", new Guid("568a5cfd-171b-413d-addf-fe6ab58aa6d0") },
                    { new Guid("c41eab8e-d25f-48b5-a6af-af351feba0d1"), null, null, "Dell.Schuppe@yahoo.com", new Guid("57041776-9144-494f-9e92-9c9da3135eab") },
                    { new Guid("c45a1191-2369-4065-8282-b60b4aa91f90"), null, null, "Elliott_Muller@hotmail.com", new Guid("960fe293-a56c-42c1-b68b-57d1e361fe6d") },
                    { new Guid("c467a01d-7526-410f-8e1a-faf26c769fcc"), null, null, "Solon4@gmail.com", new Guid("c3a4c71d-a9ab-475e-9d5b-425a5d31fb48") },
                    { new Guid("c46a367b-b359-4559-a10b-2498e6a0d647"), null, null, "Chandler.Willms33@gmail.com", new Guid("8c7f5100-7603-4d85-9e37-fba6a586f7c8") },
                    { new Guid("c4915c60-f5a5-4aa2-b8b5-899affba8b62"), null, null, "Pattie_Streich@gmail.com", new Guid("d08dab84-c369-4193-b4fb-bbd252c59cc5") },
                    { new Guid("c4ee1f11-7071-46b0-99e9-b51ccc8b7296"), null, null, "Lloyd_Casper18@gmail.com", new Guid("a161bc80-bb44-439e-bb80-442569d93b23") },
                    { new Guid("c5edd2fa-1a61-46ec-9c4d-0676c78643d7"), null, null, "Trace.Gottlieb@gmail.com", new Guid("17441686-0fa5-4e5d-b680-2d5708a2ecd5") },
                    { new Guid("c6695e72-dc8e-419f-bfcb-0e3a13d924be"), null, null, "Faye87@hotmail.com", new Guid("4af7ff34-3014-4da9-ba8e-e93cfaac4eaf") },
                    { new Guid("c6891e0e-dc2e-4836-9f16-4f90d9ae9bff"), null, null, "Chandler81@gmail.com", new Guid("146a249e-e614-41cc-98ab-d6287da977e5") },
                    { new Guid("c6d04ca1-da02-4f13-ba7e-d7241b9afbca"), null, null, "Dwight_Volkman@gmail.com", new Guid("872eccf4-a3fa-43c5-ab2e-ac6f6c9e4f17") },
                    { new Guid("c789a063-02f0-403f-8d92-f301400b2452"), null, null, "Jess_Nikolaus@hotmail.com", new Guid("3ca63884-385c-4ae8-ac07-f3dc2df24aae") },
                    { new Guid("c7aed696-5be3-4338-bf89-cc61538dd10a"), null, null, "Ellie6@gmail.com", new Guid("69879006-dc0c-45ee-a1d8-571618a19f4d") },
                    { new Guid("c8e9128d-cb88-4c82-a6c8-026e53fbe099"), null, null, "Candido16@hotmail.com", new Guid("4d65579c-7caa-4a73-aec4-ebf5de2054ab") },
                    { new Guid("c9582cbc-4f57-4cf7-a976-a8f7f363865f"), null, null, "Elvis.Bernier70@gmail.com", new Guid("f9c15c1c-b6bd-46fd-921b-e1778f14dacf") },
                    { new Guid("c9f66904-0c5e-4468-aec5-fc81c4352753"), null, null, "Camden42@gmail.com", new Guid("d368ec62-a4a6-47b3-a955-fb176a32fe20") },
                    { new Guid("caf31b98-c1fa-4fb2-be09-a8de2296f31a"), null, null, "Mohammad.Bergnaum93@hotmail.com", new Guid("17441686-0fa5-4e5d-b680-2d5708a2ecd5") },
                    { new Guid("cbdc98ec-4850-4745-bf2e-fc26b14abec6"), null, null, "Henry.Wisoky61@gmail.com", new Guid("ce4c448e-35a5-4243-aa12-b967d2b3da6f") },
                    { new Guid("cc0aea31-1d52-4b24-be59-34dd989b8f22"), null, null, "Willie.Schumm@gmail.com", new Guid("c8db4c48-87fc-43bc-b9ef-e88e6764800d") },
                    { new Guid("cc13aad8-be6a-4fa1-979b-18a86de6bf9d"), null, null, "Russ.Fritsch88@gmail.com", new Guid("7771e104-7d9f-4097-8375-a33ad264e1d8") },
                    { new Guid("cc4a50dd-cf0e-411b-a402-089cd8ffc630"), null, null, "Gussie.Johns25@gmail.com", new Guid("a8a8fdd8-4ded-4cee-9b8c-87f2285d7eab") },
                    { new Guid("cc9de91b-0c3c-411f-a12e-bb4a4c257926"), null, null, "Laurie35@yahoo.com", new Guid("7771e104-7d9f-4097-8375-a33ad264e1d8") },
                    { new Guid("cced4050-8497-4d14-977d-2a173c59e433"), null, null, "Brain.Feil24@hotmail.com", new Guid("cb9544f8-58da-451a-a24e-9ef9b8265d20") },
                    { new Guid("cd17feb5-656c-4507-bcec-cacdface1adc"), null, null, "June.Huels@hotmail.com", new Guid("2f7c84d9-6fe2-4a1c-ba84-c8d43feade58") },
                    { new Guid("cd9770de-579b-490e-a272-fe6489ebf7da"), null, null, "Efrain.Prosacco59@gmail.com", new Guid("5d6854b6-463d-4c99-844f-2b03c65e196b") },
                    { new Guid("ce1ad7f9-dba4-4582-8aae-a2a9c3fbe707"), null, null, "Quincy_Rolfson@yahoo.com", new Guid("c311c4ad-bbcf-418b-8259-eec5ae72eb71") },
                    { new Guid("ce2393c3-af73-4379-9861-5a12db62be45"), null, null, "Verna_OConnell26@hotmail.com", new Guid("ff75563e-5545-46de-a4b3-3e0727d74698") },
                    { new Guid("ce9f89df-6ced-45d5-a8d2-a6b608e1f1d4"), null, null, "Hiram_Romaguera@yahoo.com", new Guid("8606d3d5-5f3e-4f9a-b953-4be892f06c0d") },
                    { new Guid("ceaf7260-b020-4db3-8c3e-2bcb58b4a7ec"), null, null, "Damien_Moen94@gmail.com", new Guid("b944ae23-efab-4fcb-bda0-6be21e2add96") },
                    { new Guid("cf598f4f-eb35-4e3d-bdc8-fca1c029f7ae"), null, null, "Guillermo.Pfannerstill18@gmail.com", new Guid("7b9acf5a-1eec-4436-8152-103e38ca0953") },
                    { new Guid("d05cf200-2245-40d1-913c-3fc55dc50874"), null, null, "Murphy.Lang92@gmail.com", new Guid("dc04df94-1448-4899-bec4-692b13ea2748") },
                    { new Guid("d0608848-d743-4b32-b7b5-3bacdfd695dc"), null, null, "Uriel.Bogisich@hotmail.com", new Guid("cfc77b46-5660-4e53-bd9c-0ef309097b43") },
                    { new Guid("d0879bf0-72ce-4456-98ee-aadbb79e8bd1"), null, null, "Amanda43@gmail.com", new Guid("9fc4b18c-b710-43c3-be29-ffdea2c51975") },
                    { new Guid("d0ba98d3-ca4e-45c7-8e21-f8a5bede75bf"), null, null, "Deven54@hotmail.com", new Guid("94e92894-3b19-4c5f-9e95-0ec52116ec92") },
                    { new Guid("d0c788e0-ac24-42a6-8560-379a99a64af0"), null, null, "Margret_Gaylord48@yahoo.com", new Guid("6172d849-4ee5-486f-8f97-d2bbcfc40084") },
                    { new Guid("d0f5a54a-ee64-4199-8fc4-e8a539603987"), null, null, "Tressie9@hotmail.com", new Guid("d8dd96ce-4557-4993-959c-45a29c967d51") },
                    { new Guid("d10c4745-c9f6-4f54-beec-a44e585957fb"), null, null, "William_Nienow@gmail.com", new Guid("b50df756-e4ca-4115-a962-e283f6b8d317") },
                    { new Guid("d1b0b1f5-5a44-4d71-880b-a8fcada9eb98"), null, null, "Llewellyn92@gmail.com", new Guid("0a69540b-ce9e-427c-8970-9f311fba0c21") },
                    { new Guid("d23b8b4a-d649-4209-a8cb-cec806536e67"), null, null, "Kianna.Leffler@hotmail.com", new Guid("15cc8bf6-f5ac-435e-a654-84e10e29a1bd") },
                    { new Guid("d2c71ba8-12f3-41b5-9a0d-b3305f0df4bb"), null, null, "Kristopher.Mosciski@hotmail.com", new Guid("620337a7-cc3b-43d5-aef4-5b29e97ab466") },
                    { new Guid("d2c9fbc6-f142-4006-a55c-107d1af8c88e"), null, null, "Rosalyn.Prosacco@hotmail.com", new Guid("c1dedd78-34a2-4542-a585-a6ba740f5856") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("d34cea20-168c-4994-99b4-926b13365ff1"), null, null, "Reymundo.Hessel66@yahoo.com", new Guid("aa1380ad-62cc-4108-817a-4ac56a2c382d") },
                    { new Guid("d3ae4ca1-e0ef-4ddd-8873-27e23752df7e"), null, null, "Trycia.Grady21@yahoo.com", new Guid("b50df756-e4ca-4115-a962-e283f6b8d317") },
                    { new Guid("d3c9e5ca-33da-434d-b29a-190c44fe10d7"), null, null, "Eriberto_Kirlin44@hotmail.com", new Guid("52010289-102f-414b-8fb6-a09a575f22a0") },
                    { new Guid("d415cfb6-6191-4166-a776-4346c030a4f8"), null, null, "Jeffry52@yahoo.com", new Guid("f044a50f-e46f-4992-b8ae-47aa00e79d4d") },
                    { new Guid("d45eec3e-ad3d-434b-b4f1-2cae676056bc"), null, null, "Akeem.Gusikowski62@yahoo.com", new Guid("a13d28a1-8900-4b0d-8399-27cc466b719f") },
                    { new Guid("d480bad8-2c72-430f-be8a-ed49325abc40"), null, null, "Nelda.Gibson@gmail.com", new Guid("5a13878d-22a4-47a3-8eb8-3f4be375baee") },
                    { new Guid("d4a82388-b2dd-44a1-bdee-92c697149b37"), null, null, "Donnell_Hermann91@hotmail.com", new Guid("b9974b20-5b3f-4445-a6d7-c4352b53a64c") },
                    { new Guid("d4c2e7e3-d10a-44fd-9429-ba56007fc936"), null, null, "Allen_Keebler63@hotmail.com", new Guid("7f910a03-763a-4cdb-bbcb-8241bae6fc96") },
                    { new Guid("d538efa0-686e-458d-96a3-082f507bf778"), null, null, "Rudolph10@hotmail.com", new Guid("dd2a73f4-0d43-45df-8aa0-196122e00fc2") },
                    { new Guid("d56df355-6ce0-4a37-87d7-17ab7c9d97d5"), null, null, "Susanna_Effertz@hotmail.com", new Guid("f7f7b1e1-146a-4f33-9556-99419aa87dbb") },
                    { new Guid("d57ddcb9-f7eb-4fe2-81c7-e53331fd1dd3"), null, null, "Pietro_Wisoky@gmail.com", new Guid("b2a11489-a556-462e-9631-1108d9049fcc") },
                    { new Guid("d5969339-883f-4366-be2c-9f99dd7ebd6a"), null, null, "Bertram_Hand30@yahoo.com", new Guid("fc15fcf7-014b-4521-910c-8a4a05ae7df9") },
                    { new Guid("d5fc343f-88b6-4709-acb2-933c42ab96cb"), null, null, "Briana.Conroy@yahoo.com", new Guid("259e3939-18d5-4998-98ae-345c9d0fa279") },
                    { new Guid("d61c718f-0ec4-4b05-88f7-f9ba1f4234a1"), null, null, "Alexandro_Howell0@hotmail.com", new Guid("e6b167e1-2f8a-4aa9-b766-dcb40c4c65b7") },
                    { new Guid("d6359d19-17b7-44d4-a6f9-3d4f8ab38d1e"), null, null, "Cleve91@gmail.com", new Guid("69536a6d-5fc0-40dc-96ff-96cfa2e2ddde") },
                    { new Guid("d641c5f3-afa8-4f38-9c11-f9b259e76930"), null, null, "Domenick98@gmail.com", new Guid("6ee9a7d3-8695-4b4a-9a7f-e035a03a4cc3") },
                    { new Guid("d66c0a3c-fd63-46d4-ad98-46898d5bc573"), null, null, "Ettie.Pollich19@yahoo.com", new Guid("6a6686d3-6711-42f4-b08b-ada2bf39be54") },
                    { new Guid("d72bef29-a259-4de7-8455-c99d3bf99be4"), null, null, "Zackary_Rowe@gmail.com", new Guid("17b956d2-133d-4289-8a76-4633e194bce0") },
                    { new Guid("d73573bb-9b12-4eec-b283-281470d3209e"), null, null, "Thora75@hotmail.com", new Guid("d368ec62-a4a6-47b3-a955-fb176a32fe20") },
                    { new Guid("d760f73d-2877-4bfb-ab69-f41b373868bd"), null, null, "Eli.Abshire57@yahoo.com", new Guid("b070b87c-5a28-4f27-8f54-9238dfbe5c79") },
                    { new Guid("d7645350-2f2d-4424-b429-3154816bcaab"), null, null, "Ellie46@gmail.com", new Guid("63bd6aad-fd4d-4a2d-b0ee-341253297e79") },
                    { new Guid("d79657af-c190-4ea9-9e29-d7d36bba0f85"), null, null, "Kelvin_Runolfsdottir66@yahoo.com", new Guid("37432efe-ddf1-4f3f-9753-a8b4a9e54500") },
                    { new Guid("d7a2ade0-79bb-4a06-9482-0af884b6f2c5"), null, null, "Ahmad.Schaden72@yahoo.com", new Guid("aa053e12-232a-4d5d-8b1f-0803fd8b7767") },
                    { new Guid("d811acb1-a629-49b9-92b2-52ddd644bdc8"), null, null, "Tyree63@gmail.com", new Guid("49922094-de40-49f9-8fe5-21e734ddaadc") },
                    { new Guid("d88e234f-4d72-4f1b-8d03-0c7948c5851d"), null, null, "Jacinthe_Kuvalis@hotmail.com", new Guid("52010289-102f-414b-8fb6-a09a575f22a0") },
                    { new Guid("d89de9fe-27df-4183-a39a-9e2d44ea1206"), null, null, "Claudine.Mueller@gmail.com", new Guid("58fc780f-3b29-4947-a319-3ed8b421144e") },
                    { new Guid("d8adcd6b-bebf-4278-bf06-9d69f695cdc9"), null, null, "Gerald_Baumbach@gmail.com", new Guid("6b62d633-8ccd-4aa4-82e7-a8336a9e5760") },
                    { new Guid("d984b4b6-e0fa-47d6-96b0-61aeee949438"), null, null, "Vincenza_Abbott@hotmail.com", new Guid("9e4f824d-b29a-4ec5-b3a1-111d46f41ecb") },
                    { new Guid("d9a11077-2d75-4373-b994-9d8173ef0893"), null, null, "Rico64@yahoo.com", new Guid("a6b4e3da-0d2b-4dbd-9f10-ea183f9d6225") },
                    { new Guid("d9f0bac2-afdd-4fc9-91cf-bff7f496e2f8"), null, null, "Parker73@hotmail.com", new Guid("b5fe6c30-5f2d-462b-9dd2-bc5388f99ce5") },
                    { new Guid("da32450b-f02d-493b-bcd6-a726886a618e"), null, null, "Aida.Corkery61@yahoo.com", new Guid("c50f147c-0804-4f38-a70a-7b8d4109234d") },
                    { new Guid("da3ef623-5619-42a7-ad2e-d4204f6cb6be"), null, null, "Etha_Torp42@gmail.com", new Guid("8e832b0b-a138-409b-b85d-4b68d03a07b6") },
                    { new Guid("da7a0ca6-c59b-4d91-aa15-1c7433aa506d"), null, null, "Abraham_Hamill@gmail.com", new Guid("93ac31b1-6465-45d3-b0b5-98811dbc77b4") },
                    { new Guid("da84e70f-fa69-45b4-ab7e-cbdfc4886514"), null, null, "Kathleen22@hotmail.com", new Guid("d9295c19-5c11-40bb-ba7c-c1b368114ac0") },
                    { new Guid("da89a8e8-a305-4231-be34-a118d6c681b6"), null, null, "Kendrick.Hickle82@yahoo.com", new Guid("a165efc8-0956-4593-9333-e1ab17939488") },
                    { new Guid("daa511e7-d354-4c56-8973-86a9a5e6a4f5"), null, null, "Alverta_Hintz@gmail.com", new Guid("9e4f824d-b29a-4ec5-b3a1-111d46f41ecb") },
                    { new Guid("dad5af31-ac98-4072-82ff-866cb29a00d2"), null, null, "Wilfrid.Swift79@yahoo.com", new Guid("da687a7e-bca5-449f-ad43-32e0ac00fe15") },
                    { new Guid("daf680ec-b7b8-4b48-a8c5-268f3f014aaa"), null, null, "Roscoe_Terry35@yahoo.com", new Guid("e188b38e-8056-446d-96c9-b8979c4fd471") },
                    { new Guid("db28cdf1-60f7-4929-9952-bab0afe706f9"), null, null, "Petra.Shanahan@hotmail.com", new Guid("2a328a80-898f-4b62-921d-731137bebe9f") },
                    { new Guid("db439966-a359-4032-8540-f3c250a15ec6"), null, null, "Foster.Ratke44@yahoo.com", new Guid("4ae96a4e-92a4-486e-b7ce-61d3f2fe842b") },
                    { new Guid("dbc2ab27-d500-4d3a-bdca-66b58d02354b"), null, null, "Gail59@yahoo.com", new Guid("8606d3d5-5f3e-4f9a-b953-4be892f06c0d") },
                    { new Guid("dbcff103-d22f-44f3-8408-9523b8fb8f6e"), null, null, "Martin_Torphy29@gmail.com", new Guid("d0627291-bbf2-408e-bc02-9ba09faa06bd") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("dc1bb59b-bdd8-46cf-b12f-e64ec603e239"), null, null, "Uriel50@yahoo.com", new Guid("ca7879c0-456f-4a95-94ad-0a58b61bfc27") },
                    { new Guid("dc3f5526-10a8-41b8-b2c0-6274c38ef884"), null, null, "Rahul70@gmail.com", new Guid("97d70a43-949c-4c03-9da7-fc16fdc0c86d") },
                    { new Guid("dc930999-6237-4678-bcc2-3fc2b7d8882a"), null, null, "Briana87@gmail.com", new Guid("1d118b7f-07b1-49dd-9f7d-5a1e7d8ea4bc") },
                    { new Guid("dcd57a75-3602-4a61-b66f-fefe325f8ff8"), null, null, "Kevon.Dibbert90@gmail.com", new Guid("a4b4b14f-6b7f-4104-b0d2-b8f55417f1e7") },
                    { new Guid("de010029-446b-48b1-ac25-545ad81abc49"), null, null, "Elda27@yahoo.com", new Guid("ad53394d-1d27-416a-92bf-5074f6fa4fc4") },
                    { new Guid("de5e8ebf-a76d-4bec-999e-ea27b4e93c97"), null, null, "Forrest.Volkman@hotmail.com", new Guid("967d4ff4-7cca-4fd1-a75a-2f73aca9ca0a") },
                    { new Guid("de64f6db-4fff-4305-91e0-cf4188d884ce"), null, null, "Wilbert.Considine31@gmail.com", new Guid("5c31a07d-9e1a-46bb-9c88-2f881f607c52") },
                    { new Guid("de6af17f-4fad-4c9f-9943-a788db701ad7"), null, null, "Mina.Rosenbaum@gmail.com", new Guid("a8a8fdd8-4ded-4cee-9b8c-87f2285d7eab") },
                    { new Guid("de6fc666-2f8d-47e6-be73-9a38e4940671"), null, null, "Mara_Brakus81@hotmail.com", new Guid("96357562-82d6-4394-b4bf-5b698e1ad612") },
                    { new Guid("de9fcf8d-5f15-49eb-8252-e9944ff3d207"), null, null, "Korey_Hettinger79@gmail.com", new Guid("5e0e0eed-1c83-4b51-8938-5bab69316dab") },
                    { new Guid("dec8af61-b0d2-44cc-9bd7-63282a5b459f"), null, null, "Robert.Hessel94@gmail.com", new Guid("092e31f3-9b9a-4287-8cae-7fcd18feab47") },
                    { new Guid("df29f6d2-4463-4bec-8520-ce421ad441d8"), null, null, "Dariana_Lebsack96@yahoo.com", new Guid("a7a63c10-9b55-47c6-9d56-8793ee29aafd") },
                    { new Guid("df4bfcdb-b263-46b7-bffb-e6b7ad6346c4"), null, null, "Aniyah.Kemmer@yahoo.com", new Guid("a165efc8-0956-4593-9333-e1ab17939488") },
                    { new Guid("dfb121bf-c022-438d-ba6a-6c5d7ad21cd9"), null, null, "Jefferey.Sauer@hotmail.com", new Guid("c60620ff-d62e-4585-9510-ed612aa89dcb") },
                    { new Guid("dfc7ad82-53ad-4ef1-8973-ef8ba394f937"), null, null, "Larry.Tromp19@hotmail.com", new Guid("2063153a-a610-4c40-9ddd-456ef0b560db") },
                    { new Guid("e0169db2-53ae-4246-9c5a-c0a91382a341"), null, null, "Ransom_Carroll@yahoo.com", new Guid("26ad372f-ab3d-49d6-a283-d78f71a0b97b") },
                    { new Guid("e01dcfc3-e922-492b-a4f4-7062d658af4b"), null, null, "Victor71@hotmail.com", new Guid("a8a8fdd8-4ded-4cee-9b8c-87f2285d7eab") },
                    { new Guid("e0dc4893-a344-4477-8c98-b83b26ce3ff1"), null, null, "Art_Powlowski36@yahoo.com", new Guid("9b8fcbcf-ce9d-40cf-aa2a-0543ebe6f135") },
                    { new Guid("e11b35c1-68cc-4ddd-986a-008ca3c97ba2"), null, null, "Dagmar.King57@gmail.com", new Guid("c3f40de8-9c2b-4f97-b99a-a3d5f6431b27") },
                    { new Guid("e1e385f4-21fb-4994-9e4c-c12ed2b94421"), null, null, "Eleazar_Trantow@yahoo.com", new Guid("f472d28b-1df9-4c84-8ceb-3254f55042e7") },
                    { new Guid("e1f8e0e3-5bad-4f47-915f-01819361da68"), null, null, "Vernon_Schinner55@gmail.com", new Guid("552898bc-d86c-4567-80c9-bdb93739cab5") },
                    { new Guid("e20cca89-789c-4105-b4c2-cf29eedc32ba"), null, null, "Sophia_Kiehn@gmail.com", new Guid("5a6031a7-d008-4d4c-9a87-857d42759454") },
                    { new Guid("e2784e2a-4606-4b0d-aa0e-b4a53b4f20ab"), null, null, "Griffin59@hotmail.com", new Guid("c1dedd78-34a2-4542-a585-a6ba740f5856") },
                    { new Guid("e2eaab5d-a89d-4bff-9039-99d7b2f857ae"), null, null, "London70@gmail.com", new Guid("9b0c9ef1-c568-4fc6-8e02-cbbb959e0bbb") },
                    { new Guid("e37d5558-1a37-4d5c-a4ea-7bd244ce6284"), null, null, "Alvina.Hayes@yahoo.com", new Guid("5effd297-ddf3-4f40-afed-c85e49e3d248") },
                    { new Guid("e3a4ae1e-120d-4cec-aa63-6f086d0f7f40"), null, null, "Winfield.Walker@yahoo.com", new Guid("fc7807f7-2e15-4c19-8500-ea40f337d9de") },
                    { new Guid("e3c230f2-5e3c-487d-b0ae-adb54a7970e8"), null, null, "Andrew83@yahoo.com", new Guid("8dd6a489-4514-4244-9fa7-a1490970f38b") },
                    { new Guid("e4079f73-5158-4b0d-af20-b14d95b3a0ba"), null, null, "Alfred.Hauck@yahoo.com", new Guid("f7f7b1e1-146a-4f33-9556-99419aa87dbb") },
                    { new Guid("e4b180f7-3a1a-4e89-96c9-7e6945319a60"), null, null, "Enoch72@yahoo.com", new Guid("a161bc80-bb44-439e-bb80-442569d93b23") },
                    { new Guid("e4cec0fd-ee5b-4f55-b322-a552b260f7ac"), null, null, "Fermin.Osinski@hotmail.com", new Guid("3ca63884-385c-4ae8-ac07-f3dc2df24aae") },
                    { new Guid("e511069d-d997-48f7-a907-5a26c2807d98"), null, null, "Gilda_Mohr82@hotmail.com", new Guid("1546f9ad-e76e-4438-9513-2c0cdbcdc9dc") },
                    { new Guid("e58de71b-a171-4624-aa10-7d1c086c6c57"), null, null, "Jewel.Zulauf96@yahoo.com", new Guid("9ffccffc-cb42-46e5-86d7-6730697facf3") },
                    { new Guid("e5a0a3d3-48e1-406f-b8c3-a49030778c32"), null, null, "Thaddeus.Hoeger@gmail.com", new Guid("a6b4e3da-0d2b-4dbd-9f10-ea183f9d6225") },
                    { new Guid("e5f5d85a-77d0-430e-a038-31487aeb927f"), null, null, "Faye35@hotmail.com", new Guid("18314b53-d5e3-48fa-8ad6-dc84c3baa1ff") },
                    { new Guid("e6237a92-4233-491f-b4ad-d6da1014452c"), null, null, "Madaline.Dietrich81@gmail.com", new Guid("cd3bba51-ecbd-472a-a962-7f603574b446") },
                    { new Guid("e635bc65-0c0f-453e-89a2-7da3ce51af5c"), null, null, "Stewart_Krajcik61@yahoo.com", new Guid("092e31f3-9b9a-4287-8cae-7fcd18feab47") },
                    { new Guid("e6d989e8-0dc8-4ff7-8194-f7352516b193"), null, null, "Alfonzo47@yahoo.com", new Guid("37432efe-ddf1-4f3f-9753-a8b4a9e54500") },
                    { new Guid("e6e1f069-b825-467d-86b5-0c143af4fc5f"), null, null, "Kamille_Sporer11@yahoo.com", new Guid("9dafc6e9-0e56-47f8-8b8b-4ca541841bd0") },
                    { new Guid("e73cb906-22c7-4a5d-ab2c-89f11044d1c0"), null, null, "Gregory_Howe@gmail.com", new Guid("cefdf373-98f4-432b-bfc7-baaf121c554a") },
                    { new Guid("e7785239-783e-418d-9eb9-a0ff9825aba4"), null, null, "Shad.Kris@gmail.com", new Guid("11ddb06c-1f4a-4028-b37b-6ad05ae5f7d5") },
                    { new Guid("e7789c6d-1b20-4ae6-8ad9-f8867e46e400"), null, null, "Iva23@hotmail.com", new Guid("be18d868-cfef-46af-89ea-769a3c24c7da") },
                    { new Guid("e7905136-c726-430a-bc3e-c1ec0a642531"), null, null, "Viva77@gmail.com", new Guid("43b84c41-ad8c-49ff-ae3a-561f6d21e04b") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("e7d7293b-4ced-49d4-907f-74f419ea3784"), null, null, "Kamille_Prosacco89@yahoo.com", new Guid("3ca63884-385c-4ae8-ac07-f3dc2df24aae") },
                    { new Guid("e83caea0-b67b-4645-837d-0218987de4bc"), null, null, "Don_Borer@hotmail.com", new Guid("aee768a4-2b67-47da-a692-ab2b1cd95c27") },
                    { new Guid("e859d50c-93b6-4ca7-a77d-46596c76d8e5"), null, null, "Alexanne.Koss49@hotmail.com", new Guid("a3a7c05f-2de2-47a6-9d73-3dc95cb0a4bf") },
                    { new Guid("e8b75570-83cb-42c9-8fc1-3c046919ea57"), null, null, "Rosalind.Price7@hotmail.com", new Guid("086d4f1c-510f-4c8f-a495-d7e8fc340ecc") },
                    { new Guid("e96d07e4-bd7d-4431-b3c2-f163fcc4754e"), null, null, "Geo_Schinner@yahoo.com", new Guid("34d672c5-050e-4c3c-8018-0107a72f13f5") },
                    { new Guid("e9b47716-8530-4e1d-80b2-4204651dfcaa"), null, null, "Jay_Mitchell@gmail.com", new Guid("966d5ef1-e601-407d-86be-887c8e79a449") },
                    { new Guid("e9cd3d6a-21be-4a5f-93fd-97e540d42e27"), null, null, "Chase_Heller@hotmail.com", new Guid("259e3939-18d5-4998-98ae-345c9d0fa279") },
                    { new Guid("e9dc95c1-8c7c-4174-ab8c-7c433dff56af"), null, null, "Green93@yahoo.com", new Guid("63bd6aad-fd4d-4a2d-b0ee-341253297e79") },
                    { new Guid("ea3b6f23-00be-4d54-85f2-fa1b15079a32"), null, null, "Georgianna_Collins34@yahoo.com", new Guid("c798d3b3-ea5a-4b3b-a69b-7022aa64fe86") },
                    { new Guid("ea4974f7-aaf6-4ce5-81bd-15d16f28fa51"), null, null, "Palma50@hotmail.com", new Guid("4ec972f7-f6d0-4660-943e-5ad3d2557cfe") },
                    { new Guid("eac9970b-01fe-47bf-b6d1-d65ce3864a38"), null, null, "Berenice_Homenick63@hotmail.com", new Guid("2a328a80-898f-4b62-921d-731137bebe9f") },
                    { new Guid("eb638029-577a-43e6-8bb3-dcfe828b6c37"), null, null, "Hadley_Ernser@gmail.com", new Guid("d0fc0768-b3a0-4f82-affc-e355dc4101f4") },
                    { new Guid("ebc2730f-8045-4369-a583-d7eb7129c741"), null, null, "Ignatius.Bayer71@hotmail.com", new Guid("ef14d144-d1c3-49fb-9e25-1889be79f4e3") },
                    { new Guid("ebcd6b3f-8dea-42d3-87e6-e189517c15ea"), null, null, "Macey.Waelchi@yahoo.com", new Guid("2a328a80-898f-4b62-921d-731137bebe9f") },
                    { new Guid("ec07b93c-d364-439b-ada8-abd4b2586ca8"), null, null, "Hope1@hotmail.com", new Guid("e44b1f8c-951b-48de-a206-672ce80e3e29") },
                    { new Guid("ed07d69a-7b97-426e-88d2-2c90d49afbb3"), null, null, "Cheyanne67@yahoo.com", new Guid("49922094-de40-49f9-8fe5-21e734ddaadc") },
                    { new Guid("ed53efc8-0d3f-43fb-aaef-1e52bd832804"), null, null, "Antonio20@hotmail.com", new Guid("73aad8c3-cbed-4125-b80b-7db0735c3ac6") },
                    { new Guid("ed8a93af-8ce9-41ac-9653-0fac4f0b7900"), null, null, "Jakayla_Stokes@gmail.com", new Guid("716e3b4a-4381-424f-88d2-df0753a8cb13") },
                    { new Guid("ee2302ff-e933-407f-9743-cea735ae8184"), null, null, "Moises_Stracke40@yahoo.com", new Guid("63bd6aad-fd4d-4a2d-b0ee-341253297e79") },
                    { new Guid("eeadd7fd-4a61-4453-a081-84d3052f9fd1"), null, null, "Fausto.Macejkovic@hotmail.com", new Guid("86139076-e779-453a-8f87-64e1bfeeeccc") },
                    { new Guid("eeb1b19a-a422-483f-afca-72ffd3d55f8b"), null, null, "Hugh_Huel@gmail.com", new Guid("24b96e86-5860-47b1-a6ec-9a832bafbb14") },
                    { new Guid("eefd9cde-4d92-4315-9744-d9f76123ee7d"), null, null, "Liza35@gmail.com", new Guid("93b22657-e430-4b16-b1f2-af9b44bd9175") },
                    { new Guid("ef2965d4-cd58-4432-8c8b-3a51f7409e1f"), null, null, "Roselyn.Mraz23@gmail.com", new Guid("655cd6fe-206e-4683-a0e5-f0108ee7f59f") },
                    { new Guid("f031904f-59ec-4162-abfb-81d4580d4743"), null, null, "Dessie.Boehm@yahoo.com", new Guid("092e31f3-9b9a-4287-8cae-7fcd18feab47") },
                    { new Guid("f038e687-b312-4b1f-b564-58072fed646c"), null, null, "Abbey.Krajcik@hotmail.com", new Guid("fc7807f7-2e15-4c19-8500-ea40f337d9de") },
                    { new Guid("f11ff5f8-9ed3-4ef8-b57a-562ff9599903"), null, null, "Lindsay.Reinger@gmail.com", new Guid("a165efc8-0956-4593-9333-e1ab17939488") },
                    { new Guid("f1b26fa9-df06-4268-b19b-25b03ef69da7"), null, null, "Gay0@yahoo.com", new Guid("fd6ebc44-c70c-4ea5-ad8a-6029ee9c49d9") },
                    { new Guid("f274bbbc-1d9c-494a-b693-753dd5d506e7"), null, null, "Modesto.Corkery24@yahoo.com", new Guid("997402b2-514c-445f-9988-ae18a101181e") },
                    { new Guid("f287d9f5-5648-465c-a0e5-30dbbb5a9520"), null, null, "Trey.DAmore@hotmail.com", new Guid("73850497-d7e2-4015-bf80-d8fc761772d3") },
                    { new Guid("f2cfdb32-93a6-42f3-84d8-4c53a3f3cfd7"), null, null, "Sabina_Larkin8@hotmail.com", new Guid("872eccf4-a3fa-43c5-ab2e-ac6f6c9e4f17") },
                    { new Guid("f303ee68-dbff-4d38-b67e-69d5c93ba1a6"), null, null, "Hubert58@gmail.com", new Guid("c4c17769-48f5-471b-ac8e-87a2c17573b4") },
                    { new Guid("f33f6d53-414e-464a-b340-0bd198a96a5d"), null, null, "America_Conn@yahoo.com", new Guid("f472d28b-1df9-4c84-8ceb-3254f55042e7") },
                    { new Guid("f34257b1-6ed0-4d33-8350-8d24b5dc83f0"), null, null, "Clotilde.Hessel@yahoo.com", new Guid("bd5c667b-2bfc-46c6-814e-7b5c93be8f43") },
                    { new Guid("f3882092-b25f-4bbb-a0f8-3bcd8b11aa50"), null, null, "Dwight_Pollich@yahoo.com", new Guid("c561cc5e-190d-4a91-8ea9-d03583fa3f86") },
                    { new Guid("f3a2f727-937e-45f2-b344-ba2f720e172f"), null, null, "Derek_Goyette@yahoo.com", new Guid("6709762d-580f-4c32-8f92-b1daa6e22c27") },
                    { new Guid("f3e4bdc8-cb1c-4ef8-8010-717785d768c7"), null, null, "Sebastian77@gmail.com", new Guid("b2a11489-a556-462e-9631-1108d9049fcc") },
                    { new Guid("f4256a62-acba-4e33-8de6-94c1e1888cd5"), null, null, "Cole.Denesik@hotmail.com", new Guid("5441f683-8cec-4fb5-96c6-2fa82e7997d3") },
                    { new Guid("f43a425f-f682-41af-96bb-31fd8bd47561"), null, null, "Benton93@gmail.com", new Guid("8a1cc6ac-cbbb-45b8-a858-79df665cbf01") },
                    { new Guid("f4629914-57ff-4ede-a940-efc14d8f1596"), null, null, "Chelsey.Jerde@yahoo.com", new Guid("c3f74963-e8a7-4598-bde6-0b7eb8dc16d8") },
                    { new Guid("f536ca0a-ab29-447a-9a94-d0f7be018018"), null, null, "Tomasa_Quigley48@yahoo.com", new Guid("9eb02965-fa79-4bc7-940e-eff714a39f7e") },
                    { new Guid("f551e736-7c3f-4a29-847d-b3eb2a2d11cc"), null, null, "Janice8@gmail.com", new Guid("73850497-d7e2-4015-bf80-d8fc761772d3") },
                    { new Guid("f568d7fd-aa7a-4273-b8d2-c76c4ca20571"), null, null, "Hazel50@yahoo.com", new Guid("708b56dd-a529-4229-82e2-2266f01c7942") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("f5736a99-4f0c-45c9-a4cc-187cdd62aefa"), null, null, "Rolando_Waelchi43@gmail.com", new Guid("cefdf373-98f4-432b-bfc7-baaf121c554a") },
                    { new Guid("f612933a-0ca2-464a-952f-417dee95a56a"), null, null, "Carey82@hotmail.com", new Guid("51655f73-efc8-4142-b1ea-1657e4fc0f2e") },
                    { new Guid("f628cb99-10a1-451c-8c39-df9bbcf3b142"), null, null, "Marie.Zieme56@yahoo.com", new Guid("a3564d73-cc7f-45bf-bb8d-5bff9f9bd319") },
                    { new Guid("f6a63881-fcc2-464a-81a1-35168086b6ff"), null, null, "Sylvester67@yahoo.com", new Guid("cb8696d4-d2d5-40c3-b74f-38aafecd34f8") },
                    { new Guid("f6bc8d97-c5b5-4608-9f99-2355b9836e4d"), null, null, "Quentin46@hotmail.com", new Guid("166bcf97-6b8a-4025-ad11-df15241b0a24") },
                    { new Guid("f70dc970-8beb-44b4-8be2-d0c81c97916c"), null, null, "Mona.Emmerich26@gmail.com", new Guid("708b56dd-a529-4229-82e2-2266f01c7942") },
                    { new Guid("f71a2c76-8d5c-4351-a0fc-4eb41402d85d"), null, null, "Wilber_Ledner58@gmail.com", new Guid("0639ab22-a867-435b-8c5b-7acf69750583") },
                    { new Guid("f77d6ab2-2ed1-4e36-9ad3-7bfc1f799297"), null, null, "Gaston_Moore14@gmail.com", new Guid("d5f398ce-f08b-4d20-af17-603089eb45ee") },
                    { new Guid("f7a19b77-8a7f-420e-ab11-f0859c5be2e9"), null, null, "Ahmad_Brown@hotmail.com", new Guid("f4d9bb48-d87b-420c-b2ef-f724726c7a08") },
                    { new Guid("f7fe2525-ccc7-44da-9355-229ceb72b139"), null, null, "Kaycee0@gmail.com", new Guid("013a7602-b915-4485-89ea-d3291ed9cab8") },
                    { new Guid("f858e7a8-2598-4903-9f12-38ec4323f4e4"), null, null, "Fleta_Walker@yahoo.com", new Guid("d9295c19-5c11-40bb-ba7c-c1b368114ac0") },
                    { new Guid("f87113b9-a85f-4af2-9806-edf6dbffbf2f"), null, null, "Berenice_Hyatt89@hotmail.com", new Guid("4ae96a4e-92a4-486e-b7ce-61d3f2fe842b") },
                    { new Guid("f8abf52f-5b72-4167-bfef-b7af4eb253ad"), null, null, "Guiseppe10@gmail.com", new Guid("17441686-0fa5-4e5d-b680-2d5708a2ecd5") },
                    { new Guid("f8d077f9-b40f-40f6-868b-de443bdf4748"), null, null, "Eda.Murray@hotmail.com", new Guid("1d118b7f-07b1-49dd-9f7d-5a1e7d8ea4bc") },
                    { new Guid("f8e9617a-022f-4c09-ab3f-3803f437341d"), null, null, "Monroe_Wisoky@hotmail.com", new Guid("9fc4b18c-b710-43c3-be29-ffdea2c51975") },
                    { new Guid("f94d037d-62d0-47e9-8def-cb145a01af0a"), null, null, "Demetrius35@hotmail.com", new Guid("146a249e-e614-41cc-98ab-d6287da977e5") },
                    { new Guid("f9efb1f3-398f-49a7-8578-a88839b30409"), null, null, "Blaze_Walter11@yahoo.com", new Guid("98222b1e-1352-4ac9-8c47-69a7f0582ef6") },
                    { new Guid("faa1eaaf-02c4-410b-8a5b-a1b2306522db"), null, null, "Brendon.OReilly@hotmail.com", new Guid("f044a50f-e46f-4992-b8ae-47aa00e79d4d") },
                    { new Guid("fb58f22d-6bf2-4cf4-af69-44f01bd9546b"), null, null, "Winfield.Wilderman@hotmail.com", new Guid("3a8ff431-6524-4268-ae59-91f87b944fae") },
                    { new Guid("fbaca641-5860-4725-aedc-8bff82ccf943"), null, null, "Justus_Mertz2@gmail.com", new Guid("d4409d83-a792-488f-bea4-9e1b42950fc9") },
                    { new Guid("fbb9c9b7-bb87-4886-a4ca-d885d58e222d"), null, null, "Rosendo.Rowe@yahoo.com", new Guid("51655f73-efc8-4142-b1ea-1657e4fc0f2e") },
                    { new Guid("fbe06657-048f-4ec5-8006-312e173e00fe"), null, null, "Johnpaul.Abernathy@hotmail.com", new Guid("e9781110-3553-481f-bb3a-7ca26a63a83b") },
                    { new Guid("fc010a01-0c3d-474e-a8de-01e06463c1ca"), null, null, "Jensen.Sawayn39@hotmail.com", new Guid("f17c05bb-245d-432b-9116-f181ecbd16c6") },
                    { new Guid("fcc8a46e-8869-43ca-a185-732a7ee3bddd"), null, null, "Buford18@hotmail.com", new Guid("52010289-102f-414b-8fb6-a09a575f22a0") },
                    { new Guid("fd0854c1-034e-4942-97e1-db0fa6b099fb"), null, null, "Alexa_Kuhic45@yahoo.com", new Guid("7889ec96-3dce-40c9-a3d9-1dabf9642602") },
                    { new Guid("fd0c9d54-63de-48a0-b0dc-1cbeaf0652ab"), null, null, "Lyric21@hotmail.com", new Guid("3aa0613b-0255-46fa-9fc9-f73e67ec6962") },
                    { new Guid("fdb1ef1d-869b-487b-8b76-3943e2b54a61"), null, null, "Holly_Abshire@yahoo.com", new Guid("d184b2bf-159f-4b4e-83e0-4f0bb6184d14") },
                    { new Guid("fded6826-1750-4bbb-9147-6bf9f8c53e13"), null, null, "Talon_Okuneva@hotmail.com", new Guid("8a1cc6ac-cbbb-45b8-a858-79df665cbf01") },
                    { new Guid("fe0805a6-3cf2-4afe-8ad0-75ce5c4f8785"), null, null, "Steve.Huels68@hotmail.com", new Guid("4ec972f7-f6d0-4660-943e-5ad3d2557cfe") },
                    { new Guid("fe0c12b9-9440-476b-9faf-22d820158d93"), null, null, "Maxine_OHara74@gmail.com", new Guid("da687a7e-bca5-449f-ad43-32e0ac00fe15") },
                    { new Guid("fecd8e97-96ef-4c68-9beb-652594b0daaf"), null, null, "Tyshawn_Crona@gmail.com", new Guid("98222b1e-1352-4ac9-8c47-69a7f0582ef6") },
                    { new Guid("fef482e8-a5db-4976-b1ad-219accce815f"), null, null, "Stephon10@gmail.com", new Guid("c9de1952-448f-4a77-a4fa-b78a3751957a") },
                    { new Guid("ff76dc9f-7368-4003-8647-5a2f3d7a6cdd"), null, null, "Eva41@yahoo.com", new Guid("4fd873ab-a800-46d0-959f-d9f6189c846e") },
                    { new Guid("ff921803-96a1-46b4-bdf4-76fa4791f943"), null, null, "Nicolas93@yahoo.com", new Guid("62f9c608-cb23-46fa-a1c4-304e5c65aec1") },
                    { new Guid("ff9f5cd0-d6a8-474a-b4b8-7bf15515fb2f"), null, null, "Juliet.Nitzsche8@hotmail.com", new Guid("93ac31b1-6465-45d3-b0b5-98811dbc77b4") },
                    { new Guid("ffe7643c-3c6b-4133-946c-c0cd09cdad93"), null, null, "Pearlie.Osinski13@hotmail.com", new Guid("2063153a-a610-4c40-9ddd-456ef0b560db") }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("0098d13a-4d7b-436b-ba98-d237244973dc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 15, 8, 57, 15, 69, DateTimeKind.Local).AddTicks(8238), new DateTime(2023, 9, 17, 8, 57, 15, 69, DateTimeKind.Local).AddTicks(8238), null, 28.44m, true, 4858464729816483m, true, "ParcelMachine", 2, 17.707134f, "885 Lynch Stravenue, West Myrtisfurt, Republic of Korea", new Guid("708b56dd-a529-4229-82e2-2266f01c7942"), "490 Watsica Dale, Bashirianport, Australia", new Guid("5a6031a7-d008-4d4c-9a87-857d42759454"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("030e91a4-b66b-43d5-a636-a61f75cf4dae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 5, 10, 6, 6, 509, DateTimeKind.Local).AddTicks(4777), new DateTime(2023, 11, 11, 10, 6, 6, 509, DateTimeKind.Local).AddTicks(4777), null, 41.26m, true, 1474033030172786m, "Special", 1, 0.31979194f, "7028 Ratke Roads, West Emory, Bosnia and Herzegovina", new Guid("013a7602-b915-4485-89ea-d3291ed9cab8"), "15393 Susana Walk, Schultzburgh, Northern Mariana Islands", new Guid("7b354f95-20a6-4d69-abe1-b5a212feb069"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("03a9cdd2-b84d-4d90-9b3d-7f751afacba7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 2, 1, 3, 51, 537, DateTimeKind.Local).AddTicks(7192), new DateTime(2023, 7, 4, 1, 3, 51, 537, DateTimeKind.Local).AddTicks(7192), null, 22.88m, 7531593830651885m, "Standart", 5, 0.13837333f, "4791 McCullough Fork, Lake Rocio, Australia", new Guid("e6b167e1-2f8a-4aa9-b766-dcb40c4c65b7"), "6893 Reichert Cliff, East Chester, Democratic People's Republic of Korea", new Guid("17b956d2-133d-4289-8a76-4633e194bce0"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("054bc8f1-f81a-4792-b26b-a75e2d039430"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 6, 1, 8, 58, 9, 136, DateTimeKind.Local).AddTicks(3605), new DateTime(2024, 6, 6, 8, 58, 9, 136, DateTimeKind.Local).AddTicks(3605), null, 94.06m, 2181238559154427m, true, "Standart", 2, 5.2080665f, "045 Hermann Divide, Creminstad, Ukraine", new Guid("c561cc5e-190d-4a91-8ea9-d03583fa3f86"), "6969 Berry Ville, Lake Braden, Saint Martin", new Guid("cc549d3d-c127-48fe-9320-69c0367cf0ef"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("05d17cdf-8c27-49a1-b97e-5f6be6766dc0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 13, 17, 14, 21, 468, DateTimeKind.Local).AddTicks(1048), new DateTime(2024, 4, 20, 17, 14, 21, 468, DateTimeKind.Local).AddTicks(1048), null, 52.09m, true, 6827519143519810m, true, "Super", 2, 14.33202f, "26994 Jakubowski Manor, West Abelardotown, Nicaragua", new Guid("4e8bea3b-5b3c-4c9c-b874-2c8b16d90db2"), "28757 Mohr Plains, Konopelskifort, Georgia", new Guid("6709762d-580f-4c32-8f92-b1daa6e22c27"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("0ada1442-0e2d-4139-872f-9d0f37a98bce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 26, 19, 28, 50, 514, DateTimeKind.Local).AddTicks(2052), new DateTime(2024, 2, 3, 19, 28, 50, 514, DateTimeKind.Local).AddTicks(2052), null, 96.21m, true, 9771449562736756m, "Standart", 2, 35.02859f, "10178 Norene Port, Pricemouth, Liechtenstein", new Guid("58fc780f-3b29-4947-a319-3ed8b421144e"), "5166 O'Conner Flat, Josiahland, Malaysia", new Guid("b2a11489-a556-462e-9631-1108d9049fcc"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("0f890b36-f98f-4aed-857f-2da110fbc15b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 11, 23, 18, 31, 49, DateTimeKind.Local).AddTicks(7179), new DateTime(2024, 5, 13, 23, 18, 31, 49, DateTimeKind.Local).AddTicks(7179), null, 79.21m, 9595565541474940m, true, "Special", 2, 21.167885f, "216 Eunice Plaza, South Gradyberg, Antarctica (the territory South of 60 deg S)", new Guid("641c3d4a-a6ff-4cb3-b40a-665b9156a255"), "56159 Murphy Circles, North Nat, Aruba", new Guid("a4b4b14f-6b7f-4104-b0d2-b8f55417f1e7"), "Sent", "PlasticBag" },
                    { new Guid("13017d18-83d8-4c97-9a2e-8de513f183c4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 14, 19, 26, 39, 39, DateTimeKind.Local).AddTicks(5888), new DateTime(2023, 6, 24, 19, 26, 39, 39, DateTimeKind.Local).AddTicks(5888), null, 41.03m, 7890279869618655m, true, "Super", 5, 21.233099f, "09133 Dibbert Radial, Lebsackhaven, Saint Martin", new Guid("e2dba597-b132-4b1a-a46f-540ebc581408"), "7556 Kohler Squares, Janiyaport, Greece", new Guid("146a249e-e614-41cc-98ab-d6287da977e5"), "Registered", "PlasticBag" },
                    { new Guid("134a7d2f-ce68-4e8c-8395-465c8cdae219"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 19, 5, 40, 42, 793, DateTimeKind.Local).AddTicks(867), new DateTime(2024, 2, 23, 5, 40, 42, 793, DateTimeKind.Local).AddTicks(867), null, 41.62m, 6412687743967973m, true, "Courier", 1, 8.323872f, "1095 Pedro Loop, South Layne, Paraguay", new Guid("93ac31b1-6465-45d3-b0b5-98811dbc77b4"), "7969 Kub Motorway, South Oscar, Singapore", new Guid("8e8fd0f7-2809-49f2-9c1e-cbeb885b2de7"), "Registered", "PlasticBag" },
                    { new Guid("14bd1bbf-56ec-4485-ac53-a6d8aa700365"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 18, 12, 55, 51, 23, DateTimeKind.Local).AddTicks(6576), new DateTime(2023, 11, 24, 12, 55, 51, 23, DateTimeKind.Local).AddTicks(6576), null, 14.78m, 3471828419296220m, true, "Standart", 1, 13.625155f, "6993 Connelly Flats, Schroederhaven, Latvia", new Guid("c50f147c-0804-4f38-a70a-7b8d4109234d"), "29347 Audreanne Hollow, Fadelburgh, China", new Guid("cefdf373-98f4-432b-bfc7-baaf121c554a"), "Delivered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("14e3a7e7-54e2-4d1f-879a-79d79ac3c72c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 26, 8, 47, 12, 115, DateTimeKind.Local).AddTicks(8175), new DateTime(2023, 9, 29, 8, 47, 12, 115, DateTimeKind.Local).AddTicks(8175), null, 11.17m, 5197876397449784m, "Standart", 5, 38.13945f, "8906 Schumm Pines, Lake Kaleyberg, Turks and Caicos Islands", new Guid("137b1e19-3c26-4708-9428-159387ebcd43"), "9526 Deven Shores, Weberhaven, Maldives", new Guid("96389a1d-3bc8-465b-ba35-3027877a9981"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("153157ee-c8ca-48b2-880d-e50518f3a2ab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 31, 7, 54, 16, 534, DateTimeKind.Local).AddTicks(9833), new DateTime(2023, 11, 4, 7, 54, 16, 534, DateTimeKind.Local).AddTicks(9833), null, 70.24m, true, 5422493738852299m, "Standart", 1, 31.80772f, "6351 Nels Valleys, Ferryshire, Comoros", new Guid("a6fc0423-6291-4866-8d02-6faea1986c4e"), "7181 Connie Corners, Feestchester, Democratic People's Republic of Korea", new Guid("5d6854b6-463d-4c99-844f-2b03c65e196b"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("16e1e6ee-3adf-4b37-928c-054d20090fbc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 29, 1, 1, 52, 961, DateTimeKind.Local).AddTicks(5273), new DateTime(2024, 1, 8, 1, 1, 52, 961, DateTimeKind.Local).AddTicks(5273), null, 19.56m, true, 4239463288321906m, true, "Super", 4, 22.068829f, "8312 Klocko Club, Lake Jennifer, Czech Republic", new Guid("166bcf97-6b8a-4025-ad11-df15241b0a24"), "08663 West Streets, Lake Ilafort, Uruguay", new Guid("63ce22ac-8a36-4fb9-bf6d-61e02101f5d7"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("1c340516-8541-442c-ac33-7343021a43ac"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 22, 16, 23, 59, 28, DateTimeKind.Local).AddTicks(6533), new DateTime(2024, 2, 26, 16, 23, 59, 28, DateTimeKind.Local).AddTicks(6533), null, 85.89m, 3414137833620573m, "Courier", 1, 27.122932f, "2738 Petra Terrace, Lubowitzfort, Republic of Korea", new Guid("a8a8fdd8-4ded-4cee-9b8c-87f2285d7eab"), "43125 Gideon Lake, West Loyburgh, Egypt", new Guid("451f756f-99dc-4563-9d9a-db92f4a114f0"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("1dd1e3da-467d-4538-ae65-f3e34d4975c0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 10, 8, 12, 40, 508, DateTimeKind.Local).AddTicks(5946), new DateTime(2024, 3, 14, 8, 12, 40, 508, DateTimeKind.Local).AddTicks(5946), null, 83.02m, true, 3054130759824730m, true, "Courier", 1, 24.16402f, "03278 Rosalinda Hollow, New Skylarbury, Anguilla", new Guid("51655f73-efc8-4142-b1ea-1657e4fc0f2e"), "525 Flavio Underpass, Lake Nigel, Saint Barthelemy", new Guid("03a04e64-e8f5-4db8-ae88-e45982174d32"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("1e5d7d3f-ecb6-46b7-9ca4-3fe9ecaf9b70"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 1, 8, 14, 45, 463, DateTimeKind.Local).AddTicks(4038), new DateTime(2023, 8, 8, 8, 14, 45, 463, DateTimeKind.Local).AddTicks(4038), null, 64.05m, true, 5557485793382991m, "Super", 5, 28.365442f, "227 Shanon Hill, Morarbury, Cape Verde", new Guid("d368ec62-a4a6-47b3-a955-fb176a32fe20"), "03444 Sigrid Forge, Boehmport, Lesotho", new Guid("fc15fcf7-014b-4521-910c-8a4a05ae7df9"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("1f7ee9a4-4790-4a65-b23e-70e250c048f3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 12, 19, 50, 39, 552, DateTimeKind.Local).AddTicks(3662), new DateTime(2024, 4, 17, 19, 50, 39, 552, DateTimeKind.Local).AddTicks(3662), null, 36.11m, 1865616535252086m, true, "Courier", 5, 14.290983f, "47892 Halvorson Roads, Runtefurt, Saint Martin", new Guid("cefdf373-98f4-432b-bfc7-baaf121c554a"), "54719 Garfield Island, Albertomouth, Slovenia", new Guid("8bbc87aa-2bdb-4898-83a2-ca540a697ac0"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("208ea960-a0e2-4d9d-990d-6cedc985a26a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 6, 4, 12, 32, 395, DateTimeKind.Local).AddTicks(626), new DateTime(2023, 8, 14, 4, 12, 32, 395, DateTimeKind.Local).AddTicks(626), null, 58.93m, true, 2636144094425000m, "Standart", 3, 41.535385f, "44781 Cathryn Extensions, Gerholdside, Panama", new Guid("0ffea79c-1eaa-4ef4-b27f-e6c525534682"), "79499 Martin Knolls, East Angie, Sudan", new Guid("3dc1a6db-3bf2-4650-b501-abf7ef284b3c"), "Sent", "PlasticBag" },
                    { new Guid("2170fec5-ac8c-4b35-b19d-c647d9e02cb9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 5, 15, 39, 10, 737, DateTimeKind.Local).AddTicks(8765), new DateTime(2024, 5, 9, 15, 39, 10, 737, DateTimeKind.Local).AddTicks(8765), null, 39.21m, true, 4801201307443815m, "ParcelMachine", 2, 2.228529f, "486 Heaney Crossroad, Agustinatown, Cook Islands", new Guid("2063153a-a610-4c40-9ddd-456ef0b560db"), "223 Bradtke Islands, Jessicafurt, Sudan", new Guid("777e0877-9079-4ecc-a52b-f0bf5734b939"), "Delivered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("22042cd8-61db-40dc-8e3e-57b04be18277"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 8, 8, 41, 47, 353, DateTimeKind.Local).AddTicks(4541), new DateTime(2023, 12, 12, 8, 41, 47, 353, DateTimeKind.Local).AddTicks(4541), null, 47.16m, 1905959263185757m, true, "ParcelMachine", 4, 41.05039f, "875 Conroy Trail, East Harveyhaven, Azerbaijan", new Guid("b71f69da-e20d-4b25-b2fb-00d5eb1c9002"), "3413 Trent Garden, Lake Lorenaport, Turks and Caicos Islands", new Guid("b070b87c-5a28-4f27-8f54-9238dfbe5c79"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("23479e5b-1cfe-4d25-b826-5f347a187438"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 11, 15, 53, 34, 188, DateTimeKind.Local).AddTicks(7267), new DateTime(2024, 1, 15, 15, 53, 34, 188, DateTimeKind.Local).AddTicks(7267), null, 91.96m, true, 9496363413529024m, true, "Special", 5, 29.622427f, "7076 Hettinger Row, Mayertshire, Bolivia", new Guid("e1223f43-016e-41f5-b212-ab70a0ac01e2"), "609 Cade Ridges, Layneside, Western Sahara", new Guid("166bcf97-6b8a-4025-ad11-df15241b0a24"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("237e3f7e-04c3-4783-b81a-f9182caaa1a8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 22, 21, 35, 5, 104, DateTimeKind.Local).AddTicks(7816), new DateTime(2023, 8, 1, 21, 35, 5, 104, DateTimeKind.Local).AddTicks(7816), null, 93.97m, 2641946157135970m, true, "ParcelMachine", 4, 48.191387f, "36274 Anastasia Pines, North Juston, Christmas Island", new Guid("3aa0613b-0255-46fa-9fc9-f73e67ec6962"), "8075 Kira Freeway, West Seamusmouth, Belize", new Guid("ef100efa-deb4-4516-9a15-38df8ff7e396"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("247b98fc-ad95-4cbe-95bc-c4b431f47408"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 19, 22, 11, 56, 700, DateTimeKind.Local).AddTicks(8232), new DateTime(2023, 10, 27, 22, 11, 56, 700, DateTimeKind.Local).AddTicks(8232), null, 68.85m, true, 7164543369698530m, true, "ParcelMachine", 5, 28.094864f, "5629 Turner Stream, West Isai, Botswana", new Guid("997402b2-514c-445f-9988-ae18a101181e"), "59344 Raynor Parkways, Jarrettland, San Marino", new Guid("1546f9ad-e76e-4438-9513-2c0cdbcdc9dc"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("2a6ab721-67c9-4ec6-82b0-a063f5aff118"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 13, 15, 20, 47, 835, DateTimeKind.Local).AddTicks(2852), new DateTime(2024, 1, 23, 15, 20, 47, 835, DateTimeKind.Local).AddTicks(2852), null, 10.85m, 3256799351642966m, true, "Standart", 3, 41.398148f, "997 Lori Expressway, Vandervortton, Macedonia", new Guid("6b62d633-8ccd-4aa4-82e7-a8336a9e5760"), "901 Modesta Wells, West Danbury, Chile", new Guid("ce4c448e-35a5-4243-aa12-b967d2b3da6f"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("2c3264f3-2d81-4d59-8905-9d574187b26a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 7, 20, 53, 10, 154, DateTimeKind.Local).AddTicks(4007), new DateTime(2024, 4, 11, 20, 53, 10, 154, DateTimeKind.Local).AddTicks(4007), null, 34.08m, 1095799503350109m, "ParcelMachine", 4, 35.272633f, "238 Sarina Circles, Chaunceychester, Comoros", new Guid("1d118b7f-07b1-49dd-9f7d-5a1e7d8ea4bc"), "79294 Beau Common, New Justonbury, Greece", new Guid("4ccb797f-65b1-4b8c-809c-fe110c01052b"), "Return", "PlasticBag" },
                    { new Guid("2c5098d9-e550-4f8b-b328-f0f8f39e7e18"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 30, 8, 22, 21, 38, DateTimeKind.Local).AddTicks(9894), new DateTime(2024, 5, 5, 8, 22, 21, 38, DateTimeKind.Local).AddTicks(9894), null, 28.36m, 2326106249266163m, "Super", 3, 41.28545f, "7185 Virginia Corners, East Jalyn, Mauritius", new Guid("49922094-de40-49f9-8fe5-21e734ddaadc"), "962 Electa Haven, Lefflermouth, Venezuela", new Guid("8bbc88c0-c35c-496f-b3fc-e18f3d8bad18"), "OnTheWay", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("2d675632-dafa-418d-a72c-e466390be8e6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 19, 7, 16, 35, 907, DateTimeKind.Local).AddTicks(6181), new DateTime(2024, 5, 24, 7, 16, 35, 907, DateTimeKind.Local).AddTicks(6181), null, 95.48m, true, 9326288811503280m, true, "Standart", 3, 12.290114f, "23368 Beau Wells, Eleanoramouth, Peru", new Guid("bcb5583b-3b55-4ea8-b016-f74baf89e99a"), "26825 Batz Green, North Cedrickfort, Cyprus", new Guid("f54b6d8e-36d4-482b-83f6-69bd802b2ec3"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("30fa238c-02f7-4663-af2a-64e32575c0a8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 24, 11, 33, 12, 328, DateTimeKind.Local).AddTicks(3926), new DateTime(2024, 3, 29, 11, 33, 12, 328, DateTimeKind.Local).AddTicks(3926), null, 74.76m, 3559514750396236m, "Courier", 1, 45.17724f, "78256 Beau Overpass, Lake Ericaville, Italy", new Guid("73850497-d7e2-4015-bf80-d8fc761772d3"), "3562 Giovanny Shoals, South Lue, Niue", new Guid("655cd6fe-206e-4683-a0e5-f0108ee7f59f"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("345874c7-b09f-4ce5-95f3-731b18aaf439"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 17, 4, 23, 44, 581, DateTimeKind.Local).AddTicks(2735), new DateTime(2023, 12, 22, 4, 23, 44, 581, DateTimeKind.Local).AddTicks(2735), null, 83.57m, true, 5946219155083892m, true, "ParcelMachine", 3, 20.862507f, "3364 Parisian Mall, Gregberg, San Marino", new Guid("6375150d-9633-494e-ba79-b55f87d56afa"), "8372 Katrina Burgs, Danykafurt, Fiji", new Guid("96357562-82d6-4394-b4bf-5b698e1ad612"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("3be7715c-10b0-47de-af4b-b9486835b68c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 17, 5, 12, 29, 283, DateTimeKind.Local).AddTicks(7604), new DateTime(2024, 3, 19, 5, 12, 29, 283, DateTimeKind.Local).AddTicks(7604), null, 75.48m, 3145800554253724m, true, "ParcelMachine", 5, 3.3073f, "1981 Jacobi Club, Port Keyshawn, Mauritania", new Guid("5ffbbdb6-b588-4eef-811a-4b39d217f0a8"), "639 D'Amore Rapid, O'Konshire, Belgium", new Guid("cd3bba51-ecbd-472a-a962-7f603574b446"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("4064e7e3-a415-4ff8-b4fe-5dd9ab773d25"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 5, 16, 2, 24, 285, DateTimeKind.Local).AddTicks(7064), new DateTime(2024, 1, 12, 16, 2, 24, 285, DateTimeKind.Local).AddTicks(7064), null, 38.48m, true, 8364264719746447m, true, "Courier", 2, 32.18255f, "9738 Heaven Wall, South Timmyfort, Romania", new Guid("d9fc54cb-e30e-4a48-b749-08ff99fcff26"), "50395 Christop Divide, New Clemensstad, Congo", new Guid("15cc8bf6-f5ac-435e-a654-84e10e29a1bd"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("464302d2-61fa-40f1-8dc1-44869d9674ec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 26, 12, 4, 43, 901, DateTimeKind.Local).AddTicks(4948), new DateTime(2024, 5, 1, 12, 4, 43, 901, DateTimeKind.Local).AddTicks(4948), null, 52.56m, true, 3835878940594740m, "Special", 1, 24.078651f, "985 Kuphal Prairie, Lakinfort, Oman", new Guid("ffdf2e3d-14e1-47fc-a87f-43ee44597c72"), "149 Rolfson Groves, South Mauriciobury, Comoros", new Guid("997402b2-514c-445f-9988-ae18a101181e"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("497e7cfc-a3e3-4dcf-a1fa-8fd94b06944f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 17, 21, 31, 3, 286, DateTimeKind.Local).AddTicks(1414), new DateTime(2023, 6, 23, 21, 31, 3, 286, DateTimeKind.Local).AddTicks(1414), null, 57.84m, 3816777053397566m, true, "Standart", 1, 9.14873f, "56074 Julio Plains, Robelhaven, Brunei Darussalam", new Guid("451f756f-99dc-4563-9d9a-db92f4a114f0"), "352 Fernando Village, New Melvinahaven, Guam", new Guid("d5f398ce-f08b-4d20-af17-603089eb45ee"), "Sent", "CardboardBox" },
                    { new Guid("4a635103-f89b-47f3-8f83-3123eddb21b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 7, 10, 10, 30, 560, DateTimeKind.Local).AddTicks(1633), new DateTime(2023, 7, 13, 10, 10, 30, 560, DateTimeKind.Local).AddTicks(1633), null, 99.13m, 9807134948175248m, true, "Special", 3, 13.960352f, "056 Kunde Stream, Williamsonshire, Uganda", new Guid("222dda98-6fd2-4619-8709-1b78c7872ca8"), "9966 Kris Bridge, Marquardtstad, Philippines", new Guid("62f9c608-cb23-46fa-a1c4-304e5c65aec1"), "Return", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("4de29f3b-8616-43b3-bc25-d3d177ba2ec0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 28, 15, 3, 29, 821, DateTimeKind.Local).AddTicks(3284), new DateTime(2024, 2, 2, 15, 3, 29, 821, DateTimeKind.Local).AddTicks(3284), null, 38.05m, 1869764447228086m, "Courier", 1, 40.914406f, "194 Lebsack Corner, East Gerardo, Czech Republic", new Guid("ef100efa-deb4-4516-9a15-38df8ff7e396"), "83146 Jermain Lake, Monserratestad, Virgin Islands, U.S.", new Guid("5560fdd3-3041-418a-bdbd-b1b7cb595a87"), "Sent", "CardboardBox" },
                    { new Guid("503c7ebf-81f0-4e02-bee1-3741c8cb2ddc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 17, 17, 38, 21, 920, DateTimeKind.Local).AddTicks(9244), new DateTime(2023, 7, 26, 17, 38, 21, 920, DateTimeKind.Local).AddTicks(9244), null, 49.82m, 6567556378604221m, "Special", 2, 13.217993f, "81396 Keeling Trail, New Edmundmouth, Mozambique", new Guid("73977b0d-a6cb-4576-bd4a-b7056acdccd3"), "76550 Klocko Plains, North Jaunita, Canada", new Guid("7b9acf5a-1eec-4436-8152-103e38ca0953"), "Delivered", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("52e9d9de-ba10-42d4-b4ae-180365b06512"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 21, 1, 39, 36, 601, DateTimeKind.Local).AddTicks(4001), new DateTime(2024, 2, 29, 1, 39, 36, 601, DateTimeKind.Local).AddTicks(4001), null, 95.43m, 6535772191427976m, true, "Courier", 2, 23.859766f, "0958 Addison Fort, Boyerfurt, Timor-Leste", new Guid("9b0c9ef1-c568-4fc6-8e02-cbbb959e0bbb"), "758 Will Radial, Keyshawnmouth, Syrian Arab Republic", new Guid("749d009d-0557-4289-976a-50a7e345a281"), "OnTheWay", "CardboardBox" },
                    { new Guid("5633f9c1-ebfe-457a-816e-d852e3ce4635"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 2, 9, 51, 29, 175, DateTimeKind.Local).AddTicks(7178), new DateTime(2024, 1, 8, 9, 51, 29, 175, DateTimeKind.Local).AddTicks(7178), null, 63.65m, 3197880111213117m, true, "ParcelMachine", 1, 11.906687f, "103 Bergstrom Village, West Leopold, Ukraine", new Guid("4d65579c-7caa-4a73-aec4-ebf5de2054ab"), "863 Chloe Drives, Koeppbury, French Southern Territories", new Guid("e188b38e-8056-446d-96c9-b8979c4fd471"), "Sent", "CardboardBox" },
                    { new Guid("57cb100b-cd81-4e73-ab60-66819b772b6a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 31, 19, 43, 34, 821, DateTimeKind.Local).AddTicks(6370), new DateTime(2024, 6, 5, 19, 43, 34, 821, DateTimeKind.Local).AddTicks(6370), null, 45.19m, 7456134934175442m, true, "Special", 1, 35.498707f, "914 Aaron Fort, Ebertmouth, Nauru", new Guid("03a04e64-e8f5-4db8-ae88-e45982174d32"), "30312 Tommie Extensions, Lake Kevon, Grenada", new Guid("69879006-dc0c-45ee-a1d8-571618a19f4d"), "Return", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("5ed46e1b-e82f-4d17-b7b3-43f59a508ede"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 3, 12, 25, 27, 840, DateTimeKind.Local).AddTicks(7599), new DateTime(2024, 4, 6, 12, 25, 27, 840, DateTimeKind.Local).AddTicks(7599), null, 82.13m, true, 8423527146000820m, true, "Super", 1, 31.344524f, "5060 Florencio Lake, North Lorenza, Reunion", new Guid("e58d2261-638d-41ed-b5bf-55b3a94546e1"), "05138 Brennan Turnpike, Hayesland, Mongolia", new Guid("966d5ef1-e601-407d-86be-887c8e79a449"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("623a5531-51f2-4e1d-8ec0-7e3ef8baebc0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 9, 14, 23, 58, 307, DateTimeKind.Local).AddTicks(809), new DateTime(2023, 7, 19, 14, 23, 58, 307, DateTimeKind.Local).AddTicks(809), null, 33.43m, 8736543573480415m, true, "Super", 3, 2.863922f, "07192 Feil Forge, South Albertoport, Paraguay", new Guid("b5fe6c30-5f2d-462b-9dd2-bc5388f99ce5"), "085 McLaughlin Lakes, Catharineport, Yemen", new Guid("f472d28b-1df9-4c84-8ceb-3254f55042e7"), "Registered", "CardboardBox" },
                    { new Guid("62bc572b-b9d5-44a9-a3e8-808eed11b7fc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 8, 2, 36, 3, 673, DateTimeKind.Local).AddTicks(5171), new DateTime(2023, 12, 15, 2, 36, 3, 673, DateTimeKind.Local).AddTicks(5171), null, 45.00m, 5319845242755856m, true, "Standart", 5, 8.059965f, "617 Herman Brooks, Robertatown, Finland", new Guid("fc2635e7-fbe6-403c-bcdf-dc9a65be3352"), "8724 Ritchie Manors, Pacochastad, Wallis and Futuna", new Guid("97c89012-688a-4d00-9708-03d8cb08dc2e"), "OnTheWay", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("69632b1e-83d4-471f-b7b8-60e039182f35"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 26, 10, 28, 26, 284, DateTimeKind.Local).AddTicks(1509), new DateTime(2023, 8, 30, 10, 28, 26, 284, DateTimeKind.Local).AddTicks(1509), null, 59.25m, 8053186577670854m, "Super", 2, 13.477711f, "58619 Meagan Island, New Verliemouth, Niger", new Guid("0768641f-3440-4d72-a350-3b2eca842a26"), "938 Maye Terrace, Vandervortberg, Solomon Islands", new Guid("9ffccffc-cb42-46e5-86d7-6730697facf3"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("6ce5a199-10ac-4ac9-a886-85a8b6e17db9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 6, 13, 40, 7, 406, DateTimeKind.Local).AddTicks(1606), new DateTime(2023, 6, 14, 13, 40, 7, 406, DateTimeKind.Local).AddTicks(1606), null, 57.26m, true, 7546865355786529m, "Special", 1, 18.599216f, "0557 Langworth Ports, Elenaborough, Pakistan", new Guid("10a10ed0-e1f4-4de7-b631-e8c7d0d5eaa9"), "4634 Nico Walk, Veumhaven, Malaysia", new Guid("086d4f1c-510f-4c8f-a495-d7e8fc340ecc"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("6f20cbe1-ce19-444e-8bfe-e8ec337736c0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 4, 11, 50, 50, 638, DateTimeKind.Local).AddTicks(7152), new DateTime(2023, 6, 12, 11, 50, 50, 638, DateTimeKind.Local).AddTicks(7152), null, 87.67m, 3190300859893181m, "Super", 3, 48.364338f, "17919 Claude Rue, Nienowview, Guernsey", new Guid("f7f7b1e1-146a-4f33-9556-99419aa87dbb"), "6870 Rosalind Highway, North Ariellebury, Fiji", new Guid("861c20c6-b2fe-4d03-a2b4-ae2380f7edc5"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7602e2ea-8d50-498b-ab0c-2dca671af84f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 14, 22, 42, 40, 811, DateTimeKind.Local).AddTicks(9033), new DateTime(2023, 7, 16, 22, 42, 40, 811, DateTimeKind.Local).AddTicks(9033), null, 98.15m, true, 2157148236089040m, "ParcelMachine", 5, 8.325658f, "663 Pfeffer Center, South Antoneport, Central African Republic", new Guid("4bffa9b9-a7ae-4dd6-b87b-dbcad3737bfd"), "89273 Ursula Ranch, New Tryciachester, Austria", new Guid("73977b0d-a6cb-4576-bd4a-b7056acdccd3"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7a288622-e752-49ab-b352-59d21afa499c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 29, 18, 40, 56, 83, DateTimeKind.Local).AddTicks(4142), new DateTime(2023, 8, 4, 18, 40, 56, 83, DateTimeKind.Local).AddTicks(4142), null, 16.13m, true, 1839902646723369m, true, "Super", 4, 43.528034f, "48792 Wilson Trail, North Uriel, Republic of Korea", new Guid("b944ae23-efab-4fcb-bda0-6be21e2add96"), "48980 Penelope Ville, Boscoshire, Romania", new Guid("9a38b671-5580-4658-abf4-c1fc9ce2be0b"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7ed4ca2e-1c5a-4773-ae80-d2f9301fbcef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 6, 23, 35, 50, 736, DateTimeKind.Local).AddTicks(6719), new DateTime(2024, 5, 10, 23, 35, 50, 736, DateTimeKind.Local).AddTicks(6719), null, 37.33m, 6769146818621464m, true, "Special", 4, 17.29112f, "9920 Johnston Terrace, North Leda, Bermuda", new Guid("dc04df94-1448-4899-bec4-692b13ea2748"), "39790 Lueilwitz Fork, Beershire, Morocco", new Guid("aa1380ad-62cc-4108-817a-4ac56a2c382d"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("7ff84dcd-c6f0-4bf4-a83f-4ecc00568b0c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 12, 18, 35, 32, 543, DateTimeKind.Local).AddTicks(2101), new DateTime(2023, 8, 19, 18, 35, 32, 543, DateTimeKind.Local).AddTicks(2101), null, 90.90m, true, 3265314940702336m, "ParcelMachine", 2, 29.076885f, "4057 Schultz Gardens, Sylvanborough, Lesotho", new Guid("8c7f5100-7603-4d85-9e37-fba6a586f7c8"), "711 Jakob Burgs, South Kasandra, Ethiopia", new Guid("71ef850e-2fd5-4538-9b05-9c38cbbdbe30"), "Sent", "CardboardBox" },
                    { new Guid("88b88792-4fea-4c07-8b38-6ebe8abc3231"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 16, 18, 39, 20, 136, DateTimeKind.Local).AddTicks(9535), new DateTime(2023, 8, 26, 18, 39, 20, 136, DateTimeKind.Local).AddTicks(9535), null, 11.67m, true, 9664070994625944m, "Courier", 5, 26.88808f, "1931 Lysanne Field, Schinnermouth, Madagascar", new Guid("cfc77b46-5660-4e53-bd9c-0ef309097b43"), "16925 Bradly Union, West Jefferyhaven, Barbados", new Guid("7771e104-7d9f-4097-8375-a33ad264e1d8"), "Return", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("8fc90dd2-6465-43aa-a899-186a888f9ce2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 12, 10, 51, 58, 197, DateTimeKind.Local).AddTicks(3840), new DateTime(2024, 4, 13, 10, 51, 58, 197, DateTimeKind.Local).AddTicks(3840), null, 12.81m, 3421425142539916m, "Courier", 1, 26.835293f, "01119 Chance Villages, Theahaven, Marshall Islands", new Guid("d368ec62-a4a6-47b3-a955-fb176a32fe20"), "747 Bartoletti Causeway, North Vladimir, Ukraine", new Guid("cb9544f8-58da-451a-a24e-9ef9b8265d20"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("91e498b1-7de3-46dd-89e1-62b79b6b380a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 11, 14, 47, 33, 248, DateTimeKind.Local).AddTicks(2065), new DateTime(2023, 6, 15, 14, 47, 33, 248, DateTimeKind.Local).AddTicks(2065), null, 80.31m, 3510737628843760m, true, "Special", 2, 48.343075f, "614 Jennyfer Islands, Lake Lavern, Bahrain", new Guid("4952ad1a-3fe2-4d0a-a38e-1e28e3808afd"), "20920 Eric Passage, West Alexandreafort, Uganda", new Guid("7889ec96-3dce-40c9-a3d9-1dabf9642602"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("9595b8ec-3c8c-4ab7-8bee-1f79fdaeef16"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 28, 21, 10, 7, 10, DateTimeKind.Local).AddTicks(9737), new DateTime(2023, 10, 29, 21, 10, 7, 10, DateTimeKind.Local).AddTicks(9737), null, 13.62m, true, 7147915555567698m, true, "ParcelMachine", 1, 17.773487f, "945 Carli Mount, North Tomasaville, Gambia", new Guid("259e3939-18d5-4998-98ae-345c9d0fa279"), "65110 Ziemann Throughway, East Terrell, Kenya", new Guid("cfc77b46-5660-4e53-bd9c-0ef309097b43"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("96358809-1985-4278-bba7-c5448a2aa44f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 17, 17, 32, 44, 162, DateTimeKind.Local).AddTicks(6362), new DateTime(2024, 2, 27, 17, 32, 44, 162, DateTimeKind.Local).AddTicks(6362), null, 46.77m, true, 6167675032369503m, "ParcelMachine", 1, 34.362617f, "469 O'Keefe Gateway, Otisberg, Mongolia", new Guid("d8dd96ce-4557-4993-959c-45a29c967d51"), "79773 Goyette Trace, North Joberg, Central African Republic", new Guid("8adfe810-a4af-41ad-bda0-c1898bdb4d92"), "Return", "PlasticBag" },
                    { new Guid("98162cb6-48a6-410c-9f78-a5c3592d452b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 18, 20, 29, 5, 356, DateTimeKind.Local).AddTicks(5271), new DateTime(2023, 9, 19, 20, 29, 5, 356, DateTimeKind.Local).AddTicks(5271), null, 77.43m, true, 2532607736771311m, "Special", 3, 37.65793f, "2671 Magdalena Mountain, Croninberg, Virgin Islands, U.S.", new Guid("e44b1f8c-951b-48de-a206-672ce80e3e29"), "45774 Abdiel Alley, Port Peyton, Marshall Islands", new Guid("f54b6d8e-36d4-482b-83f6-69bd802b2ec3"), "OnTheWay", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("a225d0ad-92b8-4f7f-8943-a8d5ee27791f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 5, 7, 17, 37, 524, DateTimeKind.Local).AddTicks(4862), new DateTime(2023, 9, 14, 7, 17, 37, 524, DateTimeKind.Local).AddTicks(4862), null, 72.32m, 7399787066818096m, true, "Courier", 5, 34.478542f, "43958 Bartell Green, West Dorotheashire, Mozambique", new Guid("a6b4e3da-0d2b-4dbd-9f10-ea183f9d6225"), "28897 MacGyver Inlet, Mekhifort, Malta", new Guid("bd5c667b-2bfc-46c6-814e-7b5c93be8f43"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("a4f50ad0-89db-47d8-b5aa-c6e841376dc6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 25, 12, 8, 9, 63, DateTimeKind.Local).AddTicks(7443), new DateTime(2023, 8, 28, 12, 8, 9, 63, DateTimeKind.Local).AddTicks(7443), null, 17.13m, true, 9557689453668684m, "Standart", 3, 7.546728f, "25556 Batz Plain, New Zenahaven, Virgin Islands, British", new Guid("11ddb06c-1f4a-4028-b37b-6ad05ae5f7d5"), "722 Moen Drive, Lake Amyafurt, Croatia", new Guid("f9c15c1c-b6bd-46fd-921b-e1778f14dacf"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("a6a40870-df00-48fa-9c83-c55c18da82b3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 31, 4, 53, 16, 55, DateTimeKind.Local).AddTicks(1111), new DateTime(2024, 6, 4, 4, 53, 16, 55, DateTimeKind.Local).AddTicks(1111), null, 92.80m, true, 4570934747643850m, true, "Courier", 1, 18.632463f, "4222 Collier Island, Paytonside, Guernsey", new Guid("17b956d2-133d-4289-8a76-4633e194bce0"), "80966 Pouros Mountain, North Samanta, El Salvador", new Guid("4ae96a4e-92a4-486e-b7ce-61d3f2fe842b"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("a6f48b67-20eb-45d7-a7d8-247f3c0f6151"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 23, 6, 7, 55, 326, DateTimeKind.Local).AddTicks(8165), new DateTime(2023, 11, 24, 6, 7, 55, 326, DateTimeKind.Local).AddTicks(8165), null, 93.03m, 5543712763262583m, "ParcelMachine", 3, 4.005968f, "3670 Leannon Fall, Coltonfurt, Bulgaria", new Guid("749d009d-0557-4289-976a-50a7e345a281"), "3180 Itzel Falls, Robertsport, Cook Islands", new Guid("0397b496-e66d-4ab5-942d-0a53948ef201"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("a7b2c877-5e3b-461f-bd01-2196b9f41f55"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 19, 0, 55, 29, 37, DateTimeKind.Local).AddTicks(1052), new DateTime(2024, 1, 26, 0, 55, 29, 37, DateTimeKind.Local).AddTicks(1052), null, 59.75m, true, 5871305069377661m, true, "Special", 3, 19.599926f, "881 Noe Stravenue, South Dwight, Bahamas", new Guid("68fd726f-e5e4-4755-a477-4727a0a9f4b8"), "963 Altenwerth Highway, Davidtown, Peru", new Guid("71ef850e-2fd5-4538-9b05-9c38cbbdbe30"), "OnTheWay", "PlasticBag" },
                    { new Guid("a95ecf41-a876-4409-afab-270e4d0714f2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 29, 16, 57, 30, 431, DateTimeKind.Local).AddTicks(3338), new DateTime(2024, 1, 31, 16, 57, 30, 431, DateTimeKind.Local).AddTicks(3338), null, 14.52m, true, 1672725868359980m, true, "ParcelMachine", 2, 1.7715076f, "352 Lon Ranch, West Ali, Yemen", new Guid("9e4f824d-b29a-4ec5-b3a1-111d46f41ecb"), "98860 Aylin Ridge, Zboncakmouth, Colombia", new Guid("3a8ff431-6524-4268-ae59-91f87b944fae"), "Delivered", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("aae1b163-6d8d-4b64-a024-0c7b748efbee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 19, 12, 33, 19, 876, DateTimeKind.Local).AddTicks(7059), new DateTime(2023, 6, 23, 12, 33, 19, 876, DateTimeKind.Local).AddTicks(7059), null, 26.91m, true, 9682670336121148m, "Special", 5, 1.1654384f, "6470 Marilou Gateway, Lake Maud, Bangladesh", new Guid("7b9acf5a-1eec-4436-8152-103e38ca0953"), "87396 Isobel Center, West Maurine, Vietnam", new Guid("0768641f-3440-4d72-a350-3b2eca842a26"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("ae8b7fcc-d014-4fd5-a5d8-06b15e923f36"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 24, 14, 47, 51, 576, DateTimeKind.Local).AddTicks(207), new DateTime(2024, 3, 5, 14, 47, 51, 576, DateTimeKind.Local).AddTicks(207), null, 54.40m, true, 9811686204483620m, true, "Super", 3, 11.204244f, "53035 Chaya Mission, Port Austynbury, Grenada", new Guid("8892b0e2-0aef-404c-8681-2866126b786f"), "1676 Weissnat Loop, New Alejandrin, Nicaragua", new Guid("25cda556-70c4-4bb2-ad33-871e7ca4939c"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("af58a8bc-b8aa-4863-a05c-7971abd37a1c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 2, 1, 32, 58, 291, DateTimeKind.Local).AddTicks(1779), new DateTime(2024, 2, 10, 1, 32, 58, 291, DateTimeKind.Local).AddTicks(1779), null, 57.14m, 8924084746053408m, true, "Super", 3, 21.382961f, "31243 Nienow Alley, Wolffborough, Vanuatu", new Guid("dee746db-2712-4366-98c6-517b826fd421"), "7473 Aditya Union, Lake Myles, Sudan", new Guid("bd5c667b-2bfc-46c6-814e-7b5c93be8f43"), "Return", "CardboardBox" },
                    { new Guid("b0f4308b-c228-459c-aeec-21dce1332490"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 11, 14, 18, 54, 162, DateTimeKind.Local).AddTicks(9667), new DateTime(2024, 2, 16, 14, 18, 54, 162, DateTimeKind.Local).AddTicks(9667), null, 26.07m, 1759556812641252m, true, "Special", 1, 19.294731f, "12056 Cassin Junctions, Taliaport, Bahamas", new Guid("c60620ff-d62e-4585-9510-ed612aa89dcb"), "6065 Cartwright Flats, Balistreriburgh, Papua New Guinea", new Guid("ac2d4745-386c-4c13-a217-d9e2d9b842df"), "OnTheWay", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("b2d42d7e-1794-4fed-9568-89176f22729e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 12, 4, 12, 27, 592, DateTimeKind.Local).AddTicks(365), new DateTime(2024, 2, 13, 4, 12, 27, 592, DateTimeKind.Local).AddTicks(365), null, 30.74m, true, 7775484529476535m, "Special", 5, 12.703663f, "619 Kelvin Heights, Schadenfort, French Polynesia", new Guid("7b9acf5a-1eec-4436-8152-103e38ca0953"), "936 Rau Green, North Vinceville, Turkey", new Guid("c3f74963-e8a7-4598-bde6-0b7eb8dc16d8"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("b55f4990-9bfb-44be-bdcf-091c258cbeb7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 18, 19, 37, 57, 769, DateTimeKind.Local).AddTicks(7016), new DateTime(2024, 2, 26, 19, 37, 57, 769, DateTimeKind.Local).AddTicks(7016), null, 16.70m, 6916746911345941m, "ParcelMachine", 3, 43.996185f, "66330 MacGyver Bypass, Savannamouth, Dominican Republic", new Guid("17b956d2-133d-4289-8a76-4633e194bce0"), "16917 Jimmy Lights, Rosalynmouth, Saint Helena", new Guid("8606d3d5-5f3e-4f9a-b953-4be892f06c0d"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("b5b85a75-7c08-454a-a3f5-de39069e04e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 30, 7, 32, 40, 887, DateTimeKind.Local).AddTicks(1359), new DateTime(2023, 9, 3, 7, 32, 40, 887, DateTimeKind.Local).AddTicks(1359), null, 22.26m, true, 7754192711856065m, "Standart", 2, 42.42621f, "7929 Ruecker Flat, Port Deltahaven, Faroe Islands", new Guid("bd5c667b-2bfc-46c6-814e-7b5c93be8f43"), "30638 Bartell Port, East Kennith, Thailand", new Guid("5441f683-8cec-4fb5-96c6-2fa82e7997d3"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("b7036f34-a1c3-4c74-ab74-d6d6e5d83701"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 10, 12, 35, 38, 445, DateTimeKind.Local).AddTicks(3579), new DateTime(2023, 11, 12, 12, 35, 38, 445, DateTimeKind.Local).AddTicks(3579), null, 17.99m, true, 1915669183971157m, true, "Courier", 1, 29.869299f, "2547 Fritsch Parkway, Casandraburgh, Israel", new Guid("c3a4c71d-a9ab-475e-9d5b-425a5d31fb48"), "92267 Douglas Place, Shanelport, Turkmenistan", new Guid("aee768a4-2b67-47da-a692-ab2b1cd95c27"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("c080df55-57b6-474c-a8d1-d75e254c0852"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 27, 2, 28, 48, 615, DateTimeKind.Local).AddTicks(3212), new DateTime(2023, 9, 5, 2, 28, 48, 615, DateTimeKind.Local).AddTicks(3212), null, 19.45m, 4443509423986852m, "Standart", 1, 34.341934f, "799 Hailee Wells, Funkbury, Egypt", new Guid("17b956d2-133d-4289-8a76-4633e194bce0"), "92737 Luettgen Mall, Rogahnfort, Niue", new Guid("749d009d-0557-4289-976a-50a7e345a281"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("c10197ef-ee9f-4b0d-b529-5613dd06b15c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 19, 10, 41, 14, 90, DateTimeKind.Local).AddTicks(928), new DateTime(2023, 7, 29, 10, 41, 14, 90, DateTimeKind.Local).AddTicks(928), null, 25.85m, 8318839892504118m, true, "Courier", 1, 18.916697f, "5796 Yadira Mission, Corwinside, Bouvet Island (Bouvetoya)", new Guid("dfa0bf0e-13dc-416f-bb54-aaeb47a68545"), "60689 Little Park, New Francesco, Honduras", new Guid("11ddb06c-1f4a-4028-b37b-6ad05ae5f7d5"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("c2a8b46d-1ad8-406b-b41b-0eb56603cd62"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 22, 3, 36, 20, 545, DateTimeKind.Local).AddTicks(255), new DateTime(2024, 5, 27, 3, 36, 20, 545, DateTimeKind.Local).AddTicks(255), null, 45.99m, true, 7468415495263867m, "Standart", 3, 39.372044f, "568 Langworth Roads, Wunschbury, Reunion", new Guid("568a5cfd-171b-413d-addf-fe6ab58aa6d0"), "24662 Nicolas Radial, Lake Minaport, Iran", new Guid("5d6854b6-463d-4c99-844f-2b03c65e196b"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("c30a2f96-73c9-4e6b-9551-f71873f4f28a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 13, 5, 38, 23, 384, DateTimeKind.Local).AddTicks(7648), new DateTime(2024, 2, 16, 5, 38, 23, 384, DateTimeKind.Local).AddTicks(7648), null, 24.08m, true, 4981423375556263m, true, "Special", 1, 26.239943f, "49372 Ledner Crossroad, Jaylenburgh, French Polynesia", new Guid("e188b38e-8056-446d-96c9-b8979c4fd471"), "89953 Effertz Prairie, Gretachester, Andorra", new Guid("37432efe-ddf1-4f3f-9753-a8b4a9e54500"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("c9834ce7-cde5-42dd-9d9a-5e9ddd6fdeaf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 11, 0, 37, 6, 666, DateTimeKind.Local).AddTicks(9757), new DateTime(2024, 5, 19, 0, 37, 6, 666, DateTimeKind.Local).AddTicks(9757), null, 37.76m, 9097907696436740m, "Standart", 2, 36.159786f, "1723 Lehner Crescent, Lake Dulcechester, Palau", new Guid("552898bc-d86c-4567-80c9-bdb93739cab5"), "53199 Mayert Cape, Dietrichfurt, Palau", new Guid("e58d2261-638d-41ed-b5bf-55b3a94546e1"), "Return", "PlasticBag" },
                    { new Guid("ca07046d-b13e-4c97-b2ae-559ac703bc68"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 30, 17, 34, 7, 605, DateTimeKind.Local).AddTicks(9379), new DateTime(2024, 2, 2, 17, 34, 7, 605, DateTimeKind.Local).AddTicks(9379), null, 63.46m, 3428167157432007m, "Standart", 1, 49.01378f, "8655 Prosacco Crossroad, Wintheiserport, Australia", new Guid("359f112e-4dd6-47fb-995d-9dae092d143b"), "483 Juliet Divide, West Colinbury, Namibia", new Guid("57041776-9144-494f-9e92-9c9da3135eab"), "Sent", "PlasticBag" },
                    { new Guid("ca0a4759-06c2-41eb-ae22-7719b8e93643"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 29, 10, 49, 15, 63, DateTimeKind.Local).AddTicks(6453), new DateTime(2023, 10, 7, 10, 49, 15, 63, DateTimeKind.Local).AddTicks(6453), null, 97.59m, 5389175069125755m, "Special", 5, 22.662775f, "1321 Cormier Brooks, North Haven, Niger", new Guid("62f9c608-cb23-46fa-a1c4-304e5c65aec1"), "1007 Wehner Cliffs, West Hassanland, United States of America", new Guid("4d792f39-989a-48bc-8528-2bda17a5967a"), "Sent", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("d0bf5567-b9e3-43b7-83ec-de25516255b0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 22, 3, 34, 6, 832, DateTimeKind.Local).AddTicks(7303), new DateTime(2024, 5, 29, 3, 34, 6, 832, DateTimeKind.Local).AddTicks(7303), null, 18.54m, true, 4744001634033620m, true, "Standart", 5, 39.99659f, "30013 Orn Underpass, Zitaville, Madagascar", new Guid("25cda556-70c4-4bb2-ad33-871e7ca4939c"), "34268 Douglas Street, Ivoryland, Mayotte", new Guid("e7414a92-a2c0-4cbd-a0ca-3a6c538ac8c6"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("d17c2820-85b4-4cd5-9565-3933b8228a72"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 1, 19, 29, 11, 106, DateTimeKind.Local).AddTicks(4283), new DateTime(2023, 12, 3, 19, 29, 11, 106, DateTimeKind.Local).AddTicks(4283), null, 90.32m, true, 7392598571418758m, "ParcelMachine", 5, 24.944212f, "46701 Randal Valleys, West Brodyfurt, Uganda", new Guid("7805e438-4982-4f20-9e68-baca0c631417"), "83186 Gislason Bridge, South Stefan, Canada", new Guid("0639ab22-a867-435b-8c5b-7acf69750583"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("d2ab5e62-3012-469d-91f7-7e9d441579a1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 29, 5, 3, 27, 462, DateTimeKind.Local).AddTicks(1791), new DateTime(2024, 4, 8, 5, 3, 27, 462, DateTimeKind.Local).AddTicks(1791), null, 14.14m, true, 6534631753949311m, true, "Standart", 5, 48.35481f, "0686 Elias Street, South Aureliobury, Holy See (Vatican City State)", new Guid("fc7807f7-2e15-4c19-8500-ea40f337d9de"), "6550 Ophelia Points, Lake Yvonnebury, Dominican Republic", new Guid("34d672c5-050e-4c3c-8018-0107a72f13f5"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("d695a49a-87e0-4f52-8cfe-6febb2d67566"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 28, 20, 31, 59, 87, DateTimeKind.Local).AddTicks(869), new DateTime(2023, 8, 1, 20, 31, 59, 87, DateTimeKind.Local).AddTicks(869), null, 39.67m, 7289528242428531m, "Super", 2, 29.928812f, "91735 Block Vista, New Leolaberg, Virgin Islands, British", new Guid("e2dba597-b132-4b1a-a46f-540ebc581408"), "100 Dario Shoals, Reichertbury, Turks and Caicos Islands", new Guid("d08dab84-c369-4193-b4fb-bbd252c59cc5"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("d74c9db1-7af4-4bcb-b86a-792b0b63342a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 15, 8, 56, 46, 36, DateTimeKind.Local).AddTicks(2204), new DateTime(2024, 5, 18, 8, 56, 46, 36, DateTimeKind.Local).AddTicks(2204), null, 84.49m, true, 7862256468744965m, "Courier", 1, 40.953857f, "4178 Marquardt Groves, Port Anibalchester, Libyan Arab Jamahiriya", new Guid("ac2d4745-386c-4c13-a217-d9e2d9b842df"), "3381 Leffler Roads, North Madalyn, Spain", new Guid("e9781110-3553-481f-bb3a-7ca26a63a83b"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("d8a67854-6748-4611-9e72-65aa41a78196"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 14, 16, 50, 35, 325, DateTimeKind.Local).AddTicks(3133), new DateTime(2023, 10, 15, 16, 50, 35, 325, DateTimeKind.Local).AddTicks(3133), null, 27.73m, 8590312585583770m, "Standart", 4, 39.21378f, "2230 Annabelle Island, Abernathyfort, Dominica", new Guid("7902b014-f441-4bad-a55f-7656352c84e7"), "016 Sauer Walks, East Minachester, Slovakia (Slovak Republic)", new Guid("ce4c448e-35a5-4243-aa12-b967d2b3da6f"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("db5c618f-e029-49dc-99f0-553242b09f02"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 10, 10, 7, 20, 110, DateTimeKind.Local).AddTicks(7221), new DateTime(2023, 9, 12, 10, 7, 20, 110, DateTimeKind.Local).AddTicks(7221), null, 29.44m, true, 4886026807047103m, true, "Super", 5, 25.088413f, "833 Haag Common, South Spencerside, Cameroon", new Guid("a64a13ca-2754-4769-a254-32716c64c908"), "968 Name Shoal, Gutkowskishire, Australia", new Guid("f4d9bb48-d87b-420c-b2ef-f724726c7a08"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("ddaee8a8-3fd9-46b2-84b6-a4d37023ea4f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 26, 8, 43, 52, 212, DateTimeKind.Local).AddTicks(9789), new DateTime(2023, 7, 31, 8, 43, 52, 212, DateTimeKind.Local).AddTicks(9789), null, 55.65m, 6783109131432159m, true, "Special", 5, 31.977856f, "6486 Pagac Point, North Timmymouth, Maldives", new Guid("e9781110-3553-481f-bb3a-7ca26a63a83b"), "8237 Jaquelin Spur, New Krystina, Jordan", new Guid("dee746db-2712-4366-98c6-517b826fd421"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("df4a5e03-70ac-4872-ad25-5e9b7d87fd85"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 27, 15, 39, 33, 987, DateTimeKind.Local).AddTicks(5135), new DateTime(2024, 2, 2, 15, 39, 33, 987, DateTimeKind.Local).AddTicks(5135), null, 29.32m, true, 8396185624188507m, true, "Standart", 4, 32.766006f, "588 Lacy Pass, Dejamouth, Zambia", new Guid("abff8b44-2e47-47cd-8158-cb029242cf8c"), "13876 Baumbach Skyway, New Warren, Syrian Arab Republic", new Guid("777e0877-9079-4ecc-a52b-f0bf5734b939"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("e0ad9c63-892b-44c7-9a44-3a71fa94ba8d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 11, 23, 29, 21, 314, DateTimeKind.Local).AddTicks(2090), new DateTime(2023, 8, 15, 23, 29, 21, 314, DateTimeKind.Local).AddTicks(2090), null, 70.26m, 4019331064486820m, true, "ParcelMachine", 4, 48.81328f, "31278 Waylon Lake, Abbeytown, United States Minor Outlying Islands", new Guid("b67eec58-0f42-4a35-a871-09c1ddaddd4b"), "91316 Lockman Islands, Brandimouth, Mauritania", new Guid("e27f9603-32f8-4066-bf07-4ab692c8350b"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("e365d39b-96d1-4660-b128-b1e5fd0eb23e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 29, 19, 7, 4, 278, DateTimeKind.Local).AddTicks(4093), new DateTime(2024, 4, 1, 19, 7, 4, 278, DateTimeKind.Local).AddTicks(4093), null, 56.84m, 7915550114305750m, "Special", 1, 23.663208f, "1079 Kertzmann Street, Lake Einoview, Andorra", new Guid("fd6ebc44-c70c-4ea5-ad8a-6029ee9c49d9"), "0008 Bahringer Center, Jaskolskimouth, Macedonia", new Guid("69879006-dc0c-45ee-a1d8-571618a19f4d"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("e3e07de7-f834-4adc-bf6d-88a6f147a415"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 8, 4, 12, 4, 12, DateTimeKind.Local).AddTicks(4384), new DateTime(2023, 12, 13, 4, 12, 4, 12, DateTimeKind.Local).AddTicks(4384), null, 89.30m, true, 7997549686379539m, true, "Courier", 3, 33.616085f, "967 Genoveva Passage, Ivoryland, Republic of Korea", new Guid("a3a7c05f-2de2-47a6-9d73-3dc95cb0a4bf"), "146 Denesik Rapid, Leannonton, Guinea-Bissau", new Guid("5a6031a7-d008-4d4c-9a87-857d42759454"), "OnTheWay", "PlasticBag" },
                    { new Guid("e9e05db2-2aab-4917-b73d-0c5a3c26c9d9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 12, 3, 41, 12, 429, DateTimeKind.Local).AddTicks(5467), new DateTime(2023, 6, 13, 3, 41, 12, 429, DateTimeKind.Local).AddTicks(5467), null, 61.96m, true, 1521487612393086m, true, "Super", 3, 47.75391f, "3392 Lemke Shoals, Jerdehaven, Vanuatu", new Guid("222dda98-6fd2-4619-8709-1b78c7872ca8"), "75688 Maritza Isle, Loweshire, Svalbard & Jan Mayen Islands", new Guid("9eb02965-fa79-4bc7-940e-eff714a39f7e"), "Return", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("ea4b3629-73fa-4d07-b1d6-b0dd90868f84"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 24, 13, 30, 45, 752, DateTimeKind.Local).AddTicks(5482), new DateTime(2023, 9, 1, 13, 30, 45, 752, DateTimeKind.Local).AddTicks(5482), null, 40.64m, true, 7735737620871680m, "Super", 2, 24.830713f, "0879 Tobin Hill, East Jaidaview, Eritrea", new Guid("5441f683-8cec-4fb5-96c6-2fa82e7997d3"), "8185 Jamal Crossroad, Lake Pierceview, Isle of Man", new Guid("451f756f-99dc-4563-9d9a-db92f4a114f0"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("eb482b32-750c-44ac-b838-68b87847dfb2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 5, 5, 31, 42, 129, DateTimeKind.Local).AddTicks(2268), new DateTime(2023, 6, 7, 5, 31, 42, 129, DateTimeKind.Local).AddTicks(2268), null, 73.56m, true, 4729212194483650m, true, "Special", 1, 14.404854f, "03235 Briana Fords, Brantshire, Madagascar", new Guid("cf6839a1-51b8-4ec5-bfec-3cbe48c20160"), "5281 Gutkowski Mountains, Port Dannystad, Venezuela", new Guid("4a254852-2316-4300-99be-6d54e3eeac93"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("ec092036-2ae9-4ffb-9913-783dadabc88b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 24, 11, 41, 20, 589, DateTimeKind.Local).AddTicks(9963), new DateTime(2024, 3, 26, 11, 41, 20, 589, DateTimeKind.Local).AddTicks(9963), null, 48.81m, true, 4327924707080710m, "Standart", 5, 45.837723f, "1517 Turcotte Crescent, Kaiaborough, Uzbekistan", new Guid("966d5ef1-e601-407d-86be-887c8e79a449"), "86063 Crawford Cliff, Greenholtport, Fiji", new Guid("57041776-9144-494f-9e92-9c9da3135eab"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("ed425edd-b8c9-43f2-a90e-354e1acf238f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 5, 14, 2, 43, 781, DateTimeKind.Local).AddTicks(1439), new DateTime(2024, 2, 8, 14, 2, 43, 781, DateTimeKind.Local).AddTicks(1439), null, 39.08m, true, 9807868336128128m, true, "Super", 1, 13.1027975f, "3376 Lelah Place, Yundthaven, Mozambique", new Guid("5d6854b6-463d-4c99-844f-2b03c65e196b"), "2990 Ruecker Pike, West Theodora, Mexico", new Guid("777e0877-9079-4ecc-a52b-f0bf5734b939"), "Sent", "PlasticBag" },
                    { new Guid("eda9664b-7daf-4b8d-95d0-bbbc19411072"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 11, 8, 5, 40, 631, DateTimeKind.Local).AddTicks(3424), new DateTime(2023, 7, 17, 8, 5, 40, 631, DateTimeKind.Local).AddTicks(3424), null, 93.98m, true, 5163236427343034m, true, "Standart", 3, 7.29515f, "69201 Madisen Overpass, North Joanniechester, Romania", new Guid("7771e104-7d9f-4097-8375-a33ad264e1d8"), "4689 Ortiz Mountains, Considineside, Brazil", new Guid("ff75563e-5545-46de-a4b3-3e0727d74698"), "Registered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("edc73672-b1ff-451b-b6a8-c9029d155b2e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 5, 7, 10, 35, 866, DateTimeKind.Local).AddTicks(4754), new DateTime(2023, 6, 9, 7, 10, 35, 866, DateTimeKind.Local).AddTicks(4754), null, 91.22m, true, 2449122910969981m, "Standart", 3, 1.1450135f, "29885 Garrett Underpass, Carrollstad, Montserrat", new Guid("a6b4e3da-0d2b-4dbd-9f10-ea183f9d6225"), "4093 Wilkinson Dam, Kimfort, Denmark", new Guid("d184b2bf-159f-4b4e-83e0-4f0bb6184d14"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("f139eab9-e8eb-45b8-90e7-156b0afc671d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 16, 21, 31, 8, 478, DateTimeKind.Local).AddTicks(5093), new DateTime(2024, 5, 20, 21, 31, 8, 478, DateTimeKind.Local).AddTicks(5093), null, 37.89m, 9159141353085042m, true, "Courier", 4, 45.684605f, "920 Schoen River, Mayertown, Jersey", new Guid("cefdf373-98f4-432b-bfc7-baaf121c554a"), "252 Kaitlin Landing, Halvorsonton, Samoa", new Guid("552898bc-d86c-4567-80c9-bdb93739cab5"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("f334b13f-c7e2-4bb5-888a-1b592b478aaf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 30, 15, 5, 20, 819, DateTimeKind.Local).AddTicks(8369), new DateTime(2023, 10, 6, 15, 5, 20, 819, DateTimeKind.Local).AddTicks(8369), null, 93.88m, 1246324583914763m, "Special", 5, 25.682287f, "3111 Jacobson Crest, Claudiaport, Kazakhstan", new Guid("02df2ae2-d7d0-47a4-aeae-e733e06bb1d0"), "920 Mandy Track, Millerberg, Gambia", new Guid("b67eec58-0f42-4a35-a871-09c1ddaddd4b"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("f33f4f3f-542d-43c9-bd9e-1c8ec593986f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 14, 21, 38, 11, 344, DateTimeKind.Local).AddTicks(6595), new DateTime(2024, 5, 22, 21, 38, 11, 344, DateTimeKind.Local).AddTicks(6595), null, 40.34m, true, 8206262467257057m, true, "Super", 3, 21.69209f, "106 Beier Cliffs, Rebekastad, Brazil", new Guid("17b956d2-133d-4289-8a76-4633e194bce0"), "98387 Reuben Heights, South Arnoburgh, Cote d'Ivoire", new Guid("63ce22ac-8a36-4fb9-bf6d-61e02101f5d7"), "Registered", "CardboardBox" },
                    { new Guid("f4d7fcc0-e21d-464c-a31c-1be903096974"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 29, 12, 54, 42, 455, DateTimeKind.Local).AddTicks(9333), new DateTime(2023, 9, 30, 12, 54, 42, 455, DateTimeKind.Local).AddTicks(9333), null, 62.02m, true, 9502507304213384m, true, "Standart", 4, 15.313646f, "4247 Bosco Pass, D'angeloland, Denmark", new Guid("f4d9bb48-d87b-420c-b2ef-f724726c7a08"), "9176 Kendra Parkways, Bauchstad, France", new Guid("aee768a4-2b67-47da-a692-ab2b1cd95c27"), "Registered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("fedddfda-60df-492a-a9b7-b9d4282df472"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 24, 1, 4, 36, 22, DateTimeKind.Local).AddTicks(6436), new DateTime(2023, 11, 1, 1, 4, 36, 22, DateTimeKind.Local).AddTicks(6436), null, 53.10m, true, 7702314061356178m, "ParcelMachine", 3, 23.035854f, "14291 Brennan Curve, Alishahaven, Timor-Leste", new Guid("a8a8fdd8-4ded-4cee-9b8c-87f2285d7eab"), "7230 Trystan Springs, Garfieldborough, Turkey", new Guid("c0ce8022-4a58-4c92-9e84-7f2ac0c9caa5"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("0083d18c-a609-4b28-8102-ba15b42f0380"), "477", "6372275069523649", null, null, new Guid("7b9acf5a-1eec-4436-8152-103e38ca0953"), "09/04" },
                    { new Guid("00b05118-2fef-4911-a7e7-cc7b1ad728d8"), "924", "1601267649521519", null, null, new Guid("284afcd2-63de-4550-906f-0a1ce11e8244"), "08/21" },
                    { new Guid("014209cc-9158-4864-b7ce-35ea24d56513"), "337", "4653601686515680", null, null, new Guid("94e92894-3b19-4c5f-9e95-0ec52116ec92"), "07/15" },
                    { new Guid("017bc774-0689-44f8-acbf-46feb7bf09d6"), "746", "2338417968600179", null, null, new Guid("4ec972f7-f6d0-4660-943e-5ad3d2557cfe"), "09/14" },
                    { new Guid("01b40340-29a6-48ba-ba75-458d28068326"), "814", "5648446904061173", null, null, new Guid("6b62d633-8ccd-4aa4-82e7-a8336a9e5760"), "05/02" },
                    { new Guid("01b7a9e0-3e7c-4565-9c22-41ddc554626b"), "563", "8600065996562732", null, null, new Guid("222dda98-6fd2-4619-8709-1b78c7872ca8"), "04/24" },
                    { new Guid("025ea917-f523-4d1d-90a8-0368e57018bc"), "692", "3105695415322577", null, null, new Guid("97c89012-688a-4d00-9708-03d8cb08dc2e"), "11/15" },
                    { new Guid("028005d1-3aa1-4c24-b093-a158169d658b"), "777", "4979711039943561", null, null, new Guid("086d4f1c-510f-4c8f-a495-d7e8fc340ecc"), "11/28" },
                    { new Guid("029b9dd5-2ab5-4746-93ef-9f17616b502a"), "393", "1252784171884179", null, null, new Guid("57d5c043-44a4-43bb-80ee-1cbb791b2285"), "06/26" },
                    { new Guid("0342a40a-3068-4f1c-be3e-d33bf7d966a1"), "835", "1168494654545090", null, null, new Guid("df250436-821d-48ab-9508-ab3df0550e27"), "07/24" },
                    { new Guid("044635a4-254c-414d-8ecd-1daf9454bd56"), "758", "4780133240829215", null, null, new Guid("967d4ff4-7cca-4fd1-a75a-2f73aca9ca0a"), "04/07" },
                    { new Guid("0457a437-4d1a-4199-b879-7bc96fdf9e14"), "706", "2305028434695663", null, null, new Guid("91024531-3bc9-4397-868c-67a81b4abcfc"), "03/24" },
                    { new Guid("045f277b-1597-4e54-9de0-1f4f874cf1e5"), "451", "8903242653079871", null, null, new Guid("552898bc-d86c-4567-80c9-bdb93739cab5"), "06/21" },
                    { new Guid("04741367-a086-46ce-a45f-d9348acbd52a"), "698", "8305238713439571", null, null, new Guid("8892b0e2-0aef-404c-8681-2866126b786f"), "12/07" },
                    { new Guid("04a82975-6355-43f7-8b09-2ff107ed7516"), "437", "6143664237892598", null, null, new Guid("b5fe6c30-5f2d-462b-9dd2-bc5388f99ce5"), "11/23" },
                    { new Guid("04aab805-e445-4d23-a019-2ab5b98eb920"), "623", "2551531362388090", null, null, new Guid("4bffa9b9-a7ae-4dd6-b87b-dbcad3737bfd"), "12/17" },
                    { new Guid("04df1036-f82f-4784-a3d1-e1628ea21a0b"), "559", "4378111136903666", null, null, new Guid("b50df756-e4ca-4115-a962-e283f6b8d317"), "06/25" },
                    { new Guid("058f0796-f466-4c1a-a3b6-2b64a444b1ba"), "276", "3598767937411089", null, null, new Guid("b71f69da-e20d-4b25-b2fb-00d5eb1c9002"), "01/22" },
                    { new Guid("05c30236-8032-437a-8112-0bcc22ac2352"), "740", "8816748843283907", null, null, new Guid("359f112e-4dd6-47fb-995d-9dae092d143b"), "10/28" },
                    { new Guid("05e2dd62-0335-47b5-acb4-fffeb51de106"), "660", "5118509868534996", null, null, new Guid("966d5ef1-e601-407d-86be-887c8e79a449"), "09/08" },
                    { new Guid("0607f69f-826a-45cb-b081-bd11fec4af75"), "969", "4218416583173507", null, null, new Guid("b3997a22-bce6-473b-9a56-6baca1b5ece7"), "09/25" },
                    { new Guid("062b4aa0-f771-42fb-9f59-5712e0e44a3f"), "630", "6564376145632438", null, null, new Guid("d0fc0768-b3a0-4f82-affc-e355dc4101f4"), "10/25" },
                    { new Guid("070ced7d-a36e-4c7b-a9fe-e422ed47d0d3"), "837", "3052160681540683", null, null, new Guid("cfc77b46-5660-4e53-bd9c-0ef309097b43"), "10/24" },
                    { new Guid("071da9fd-aba6-4228-b1c1-5fef0d707e65"), "013", "2854240326127370", null, null, new Guid("8bbc88c0-c35c-496f-b3fc-e18f3d8bad18"), "11/14" },
                    { new Guid("0820f6e6-2225-4c10-aaba-26c7f482383f"), "459", "2644239949592456", null, null, new Guid("166bcf97-6b8a-4025-ad11-df15241b0a24"), "11/01" },
                    { new Guid("08e6f1eb-f79c-4aca-bc6f-86e608f46b53"), "653", "7083851590150136", null, null, new Guid("6cbb9172-2b78-4f00-a841-8a1e6d6be79b"), "01/20" },
                    { new Guid("095d2755-da1f-46d1-b99d-52ab6e49dd79"), "717", "1526316734990614", null, null, new Guid("e44b1f8c-951b-48de-a206-672ce80e3e29"), "10/26" },
                    { new Guid("09c11916-3fc3-421e-b4a9-420766186d5b"), "165", "9928328037129583", null, null, new Guid("6709762d-580f-4c32-8f92-b1daa6e22c27"), "01/27" },
                    { new Guid("09d394da-62bd-49b8-91b7-0736270e58ca"), "339", "3839533496530929", null, null, new Guid("3705daaf-a245-497f-b245-acd05a008711"), "06/04" },
                    { new Guid("09f337bf-a69e-44bc-bfe2-91ff612ba042"), "505", "8190904044849011", null, null, new Guid("9e4f824d-b29a-4ec5-b3a1-111d46f41ecb"), "07/28" },
                    { new Guid("0a7ae2e3-9625-4c9b-9305-13d80bfc32a6"), "866", "5680506377982555", null, null, new Guid("9f317a02-0a11-4f32-b538-7ec5c02e4b5e"), "08/02" },
                    { new Guid("0a83664e-9c17-4bcf-92dc-f6b2ea31be8c"), "748", "9231450119334450", null, null, new Guid("9dafc6e9-0e56-47f8-8b8b-4ca541841bd0"), "10/01" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("0aca092f-6fa8-457d-b4c8-4eef164aed3d"), "004", "6286737052077523", null, null, new Guid("93ac31b1-6465-45d3-b0b5-98811dbc77b4"), "02/28" },
                    { new Guid("0b4de914-6e8c-4f95-9f09-b142d08d8578"), "100", "6794881414663596", null, null, new Guid("c3f74963-e8a7-4598-bde6-0b7eb8dc16d8"), "12/18" },
                    { new Guid("0b53d04e-9e68-482c-a692-45b48ceda0d1"), "685", "3567948410769519", null, null, new Guid("859757d1-9ad7-45f4-8664-764e0db29fec"), "06/07" },
                    { new Guid("0c055b8f-4c4c-4a78-b75f-e2bbf3bc2c9e"), "775", "8576323346485017", null, null, new Guid("620337a7-cc3b-43d5-aef4-5b29e97ab466"), "09/18" },
                    { new Guid("0c1d1cc3-f322-46c9-8c3f-bfe033a808c8"), "791", "9494721777117024", null, null, new Guid("ca9a7100-5d5c-406e-8028-d065cd21c772"), "01/18" },
                    { new Guid("0c8fcbd7-9359-42cd-872b-fe26790551c8"), "981", "2939587595165373", null, null, new Guid("d0627291-bbf2-408e-bc02-9ba09faa06bd"), "02/19" },
                    { new Guid("0d36cca5-b2a9-4f43-9cc1-13ef58686151"), "341", "1068498345451115", null, null, new Guid("a64a13ca-2754-4769-a254-32716c64c908"), "05/15" },
                    { new Guid("0dd3b046-2c38-45b5-a108-8f6de8222ff5"), "668", "8128597278887254", null, null, new Guid("a165efc8-0956-4593-9333-e1ab17939488"), "10/22" },
                    { new Guid("0e0feafb-5a39-4a1b-b84d-42a02a7a85ef"), "195", "2728432856304840", null, null, new Guid("98222b1e-1352-4ac9-8c47-69a7f0582ef6"), "09/16" },
                    { new Guid("0e15fad1-d056-4e1c-b5d3-c8ce08f0a70a"), "361", "2999741681812530", null, null, new Guid("c0ce8022-4a58-4c92-9e84-7f2ac0c9caa5"), "03/22" },
                    { new Guid("0e185ac4-8c50-48e3-9798-c768597c77b8"), "547", "4143866802907413", null, null, new Guid("1546f9ad-e76e-4438-9513-2c0cdbcdc9dc"), "05/09" },
                    { new Guid("0e35aafa-ff9e-4784-86e6-f63276e2acb9"), "618", "6748144261430726", null, null, new Guid("6ee9a7d3-8695-4b4a-9a7f-e035a03a4cc3"), "12/19" },
                    { new Guid("0ed821da-1b3a-49cd-9ebf-34c747fa39eb"), "330", "9047677256132257", null, null, new Guid("97d70a43-949c-4c03-9da7-fc16fdc0c86d"), "06/02" },
                    { new Guid("0ef56eaf-b7e5-405a-a0c4-dffb686c49f3"), "931", "8496684304880662", null, null, new Guid("09465da9-1c65-4a00-be4f-5b7144e699f3"), "03/06" },
                    { new Guid("0f720328-c9b0-45b0-9f0e-06d452035bdf"), "356", "8668015107468918", null, null, new Guid("83521c38-fd64-4bbe-89bf-e217d9771096"), "02/16" },
                    { new Guid("0f9a0dd4-8534-4ff5-ae23-d7d55cc518f5"), "255", "7752742719467222", null, null, new Guid("8e832b0b-a138-409b-b85d-4b68d03a07b6"), "04/13" },
                    { new Guid("0fd245b1-b972-4149-8c6e-01df6100aa8a"), "781", "1020783347949256", null, null, new Guid("eedd859d-8af5-43b7-8938-5bce7dd89153"), "07/04" },
                    { new Guid("104826db-dbd7-472f-9676-18ecd101c04a"), "428", "5250978766514106", null, null, new Guid("137b1e19-3c26-4708-9428-159387ebcd43"), "11/28" },
                    { new Guid("1087b5ee-9fac-4bfc-9c1f-a06fdc1d43bf"), "897", "4155761551651644", null, null, new Guid("9b0c9ef1-c568-4fc6-8e02-cbbb959e0bbb"), "07/15" },
                    { new Guid("10a5089c-6321-4655-8b85-c672a7ffbfa9"), "290", "7228531131652924", null, null, new Guid("d9fc54cb-e30e-4a48-b749-08ff99fcff26"), "05/22" },
                    { new Guid("10ed530d-0bd9-473b-8ab7-e7c98f19ef19"), "920", "4656329952650569", null, null, new Guid("4ec972f7-f6d0-4660-943e-5ad3d2557cfe"), "11/21" },
                    { new Guid("10efc4a8-61be-4382-8b61-1665be92f0a4"), "881", "9186906436786383", null, null, new Guid("b44b2dc0-6e21-4d7d-a788-6c4e66d96402"), "09/02" },
                    { new Guid("1171eef3-a7ce-42bf-8409-cea3bd988c7d"), "655", "5969844943182407", null, null, new Guid("10a10ed0-e1f4-4de7-b631-e8c7d0d5eaa9"), "11/10" },
                    { new Guid("11c2e7c8-8824-4a01-b849-6a7622b9297e"), "233", "6812829327708250", null, null, new Guid("a6fc0423-6291-4866-8d02-6faea1986c4e"), "06/25" },
                    { new Guid("11ca7e11-938e-4c3d-8ecf-fe6d8a98e6f8"), "711", "2547056766883370", null, null, new Guid("7e5e5ebc-3d4d-451a-884b-00a9d9f53676"), "12/13" },
                    { new Guid("1256986e-ce8e-4072-aa81-a17a4d2c5e36"), "580", "8830746421093268", null, null, new Guid("b50df756-e4ca-4115-a962-e283f6b8d317"), "12/03" },
                    { new Guid("1275fe31-e29b-4470-b9e1-0cd07015c49b"), "513", "7227543091011723", null, null, new Guid("6172d849-4ee5-486f-8f97-d2bbcfc40084"), "02/02" },
                    { new Guid("13050dc0-03e9-4c2f-aefd-a99c43e19917"), "624", "8593450150587840", null, null, new Guid("c50f147c-0804-4f38-a70a-7b8d4109234d"), "07/28" },
                    { new Guid("139dd60e-aff3-49b7-bfcd-9113e2b630a9"), "935", "8253260210595670", null, null, new Guid("98222b1e-1352-4ac9-8c47-69a7f0582ef6"), "01/07" },
                    { new Guid("14123f6b-e5a1-4c93-a7e5-5119ce99215a"), "333", "8819565617653064", null, null, new Guid("9f331cb7-b70d-434b-bc28-147a5e624fd8"), "01/09" },
                    { new Guid("15076b0d-f256-4d70-8152-506ef9d562e5"), "274", "2668924719619825", null, null, new Guid("cefdf373-98f4-432b-bfc7-baaf121c554a"), "08/02" },
                    { new Guid("15a68bf8-3752-4f53-aceb-97d785ab1780"), "018", "9850260712581423", null, null, new Guid("f044a50f-e46f-4992-b8ae-47aa00e79d4d"), "02/10" },
                    { new Guid("167e1fdc-efe7-40ed-a278-bad9bcf9e7ef"), "270", "3635475309388886", null, null, new Guid("5ffbbdb6-b588-4eef-811a-4b39d217f0a8"), "04/16" },
                    { new Guid("16cc0435-ed3c-4bfd-b333-465f85028003"), "434", "4909491561468369", null, null, new Guid("6a6686d3-6711-42f4-b08b-ada2bf39be54"), "02/18" },
                    { new Guid("16d4288d-3e33-4838-b38e-ea093634ee89"), "991", "9565122101360720", null, null, new Guid("8bbc88c0-c35c-496f-b3fc-e18f3d8bad18"), "05/22" },
                    { new Guid("172cb172-c666-4198-ab94-29f30bcb09d7"), "708", "6513090695162035", null, null, new Guid("ef100efa-deb4-4516-9a15-38df8ff7e396"), "05/28" },
                    { new Guid("17cd531b-84d8-4bf4-8bfc-08897271f3a4"), "842", "9843309677992559", null, null, new Guid("1d118b7f-07b1-49dd-9f7d-5a1e7d8ea4bc"), "06/16" },
                    { new Guid("17d06a81-62ff-4077-ba01-45346fb30a78"), "293", "5864121096928268", null, null, new Guid("0397b496-e66d-4ab5-942d-0a53948ef201"), "05/18" },
                    { new Guid("18347bf0-a031-4945-9885-97c49f11a6cd"), "219", "5189286792462788", null, null, new Guid("9a38b671-5580-4658-abf4-c1fc9ce2be0b"), "02/09" },
                    { new Guid("187ce638-f032-4f04-8083-23aa7e816f6b"), "403", "7876143755435866", null, null, new Guid("b5fe6c30-5f2d-462b-9dd2-bc5388f99ce5"), "08/17" },
                    { new Guid("18dc4699-a003-42e2-9c2a-a1d6af74f612"), "494", "5897723579914542", null, null, new Guid("967d4ff4-7cca-4fd1-a75a-2f73aca9ca0a"), "01/22" },
                    { new Guid("19091e1b-095c-494f-ab79-96a828746986"), "525", "2507276467165175", null, null, new Guid("777e0877-9079-4ecc-a52b-f0bf5734b939"), "02/04" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("19205ad7-404e-465e-a6f4-14d1c1a8dd34"), "540", "9497169842958781", null, null, new Guid("2a9b395f-43a6-4c12-8ee4-3f4db5f26f9d"), "10/22" },
                    { new Guid("194f7a66-84fb-42ba-b90c-2ed59de0223f"), "009", "4450397873951447", null, null, new Guid("93b22657-e430-4b16-b1f2-af9b44bd9175"), "11/14" },
                    { new Guid("1a8cecf1-5531-4937-ba7e-8c79ef4c7152"), "715", "3451946798818395", null, null, new Guid("086d4f1c-510f-4c8f-a495-d7e8fc340ecc"), "03/20" },
                    { new Guid("1ab3371b-57eb-4e35-aba7-021c1d8ef599"), "251", "5968104377701219", null, null, new Guid("d9fc54cb-e30e-4a48-b749-08ff99fcff26"), "04/10" },
                    { new Guid("1ab36bf7-5c6c-4f1a-a256-a38342bd1607"), "572", "7817627872425673", null, null, new Guid("cb9544f8-58da-451a-a24e-9ef9b8265d20"), "11/12" },
                    { new Guid("1ac5a4f3-8858-4301-a065-1a7ee36d0507"), "816", "4152854043251582", null, null, new Guid("859757d1-9ad7-45f4-8664-764e0db29fec"), "02/25" },
                    { new Guid("1af88aa4-96fc-45ea-abd9-9129344cb325"), "899", "3218832750273819", null, null, new Guid("b9974b20-5b3f-4445-a6d7-c4352b53a64c"), "12/01" },
                    { new Guid("1b106e9b-30ec-4ff9-a453-0274bca995f4"), "064", "3686824869062657", null, null, new Guid("4fd873ab-a800-46d0-959f-d9f6189c846e"), "06/09" },
                    { new Guid("1b34f488-8b35-420d-9973-3ebd44fde3ff"), "588", "8025179046189324", null, null, new Guid("1d118b7f-07b1-49dd-9f7d-5a1e7d8ea4bc"), "06/03" },
                    { new Guid("1b520e92-b9a6-4f71-9738-454af492ab11"), "004", "1096414657935106", null, null, new Guid("4e8bea3b-5b3c-4c9c-b874-2c8b16d90db2"), "04/02" },
                    { new Guid("1b5605dd-3e4a-48a1-9053-687352567572"), "329", "4631773738198414", null, null, new Guid("d8361619-ae4f-4db1-9eb9-291e4814a381"), "01/06" },
                    { new Guid("1b8d740c-bd33-4070-b8d1-bda9af4bab12"), "847", "4340041932021566", null, null, new Guid("0b440e9a-ee26-43ee-9d40-46328f22a228"), "03/02" },
                    { new Guid("1ba62458-e11b-4b8a-94ac-80958fa122cf"), "807", "5381362346826343", null, null, new Guid("cfc77b46-5660-4e53-bd9c-0ef309097b43"), "06/20" },
                    { new Guid("1bc6596d-9477-4f9b-8f06-390b0caec01a"), "841", "3199100399605935", null, null, new Guid("967d4ff4-7cca-4fd1-a75a-2f73aca9ca0a"), "04/09" },
                    { new Guid("1bf0324d-25f1-47c9-8d61-f8dd4b2cbbc9"), "185", "4840715960293878", null, null, new Guid("c1dedd78-34a2-4542-a585-a6ba740f5856"), "12/20" },
                    { new Guid("1c2276a1-aaf0-4e70-8659-9a43ce8aed1b"), "962", "9214933902934824", null, null, new Guid("10a10ed0-e1f4-4de7-b631-e8c7d0d5eaa9"), "12/24" },
                    { new Guid("1c460e12-aad0-4eaf-8034-19912a7b0be7"), "403", "8336387960831649", null, null, new Guid("89c19062-b085-4717-8960-680ec5f619e0"), "11/25" },
                    { new Guid("1c653bb3-0a26-40f2-9e11-5af2fb820ca3"), "127", "7891669805028815", null, null, new Guid("4bb403d4-8670-466f-a9dc-17dd09c9d546"), "01/14" },
                    { new Guid("1c799cea-ba08-4e60-a661-172c0cfa06ff"), "421", "2583757480383934", null, null, new Guid("4af7ff34-3014-4da9-ba8e-e93cfaac4eaf"), "04/03" },
                    { new Guid("1cbd82e0-6153-4380-ab52-f6757e2a4e10"), "473", "3601746195829762", null, null, new Guid("c3a4c71d-a9ab-475e-9d5b-425a5d31fb48"), "08/17" },
                    { new Guid("1d64a21f-22ba-4e58-8264-ab4027ef654c"), "815", "3882869073062095", null, null, new Guid("a161bc80-bb44-439e-bb80-442569d93b23"), "08/25" },
                    { new Guid("1d7beb12-c41f-4136-9fad-74ae0f18e301"), "094", "2871121574991800", null, null, new Guid("83521c38-fd64-4bbe-89bf-e217d9771096"), "01/08" },
                    { new Guid("1da5d964-02d5-4de4-9957-3843b3544a1b"), "272", "7061801689364855", null, null, new Guid("a01a13e5-a8d1-4048-b8b2-24cdfac5f11e"), "02/27" },
                    { new Guid("1dfa0745-1f47-4e8b-9562-52b0348ad9d4"), "806", "5965769982757317", null, null, new Guid("71ef850e-2fd5-4538-9b05-9c38cbbdbe30"), "04/20" },
                    { new Guid("1e09e062-5d5b-495b-b6cc-67f0e96ce8ce"), "304", "2098291248700393", null, null, new Guid("2eb253e8-852b-4b59-bbd3-41b1d962644b"), "12/13" },
                    { new Guid("1e252566-f3ea-4a64-b376-e1eb48bfefaf"), "487", "3610967636491653", null, null, new Guid("146a249e-e614-41cc-98ab-d6287da977e5"), "03/03" },
                    { new Guid("1e273146-9647-47f8-8aae-d7068a04fa11"), "392", "5040040501569412", null, null, new Guid("a8a8fdd8-4ded-4cee-9b8c-87f2285d7eab"), "05/04" },
                    { new Guid("1e2dbcf5-a4b7-475a-9ebe-770519a8b04f"), "609", "8660311767034863", null, null, new Guid("1d118b7f-07b1-49dd-9f7d-5a1e7d8ea4bc"), "03/19" },
                    { new Guid("1e48b7ba-4ba1-4546-9a39-6336539431e5"), "676", "4530339052996930", null, null, new Guid("43b84c41-ad8c-49ff-ae3a-561f6d21e04b"), "08/19" },
                    { new Guid("1edc9b54-ca7f-4e09-be0b-27f3c0aa5877"), "956", "4650835155156118", null, null, new Guid("17b956d2-133d-4289-8a76-4633e194bce0"), "11/14" },
                    { new Guid("1efd4127-a4b4-49ab-8b07-2b2a92a19001"), "124", "8338166103590074", null, null, new Guid("bcb5583b-3b55-4ea8-b016-f74baf89e99a"), "03/10" },
                    { new Guid("1f3de41a-92d2-453a-ac82-6cad6c8aaa16"), "127", "4399514450146628", null, null, new Guid("5effd297-ddf3-4f40-afed-c85e49e3d248"), "11/14" },
                    { new Guid("1f8bc194-1950-4b9e-9e4c-f9912a9170c0"), "111", "9609929438758282", null, null, new Guid("8c7f5100-7603-4d85-9e37-fba6a586f7c8"), "01/18" },
                    { new Guid("1faee729-7345-4aa9-a615-53677eb3d955"), "403", "2964991128893901", null, null, new Guid("8606d3d5-5f3e-4f9a-b953-4be892f06c0d"), "09/20" },
                    { new Guid("1ff3b584-bc09-40f2-81d7-5e3bb78c4bb9"), "010", "9268484859945400", null, null, new Guid("96357562-82d6-4394-b4bf-5b698e1ad612"), "04/16" },
                    { new Guid("204fb3b4-dce0-478c-86f2-18c6b0ff5801"), "711", "6575055577111314", null, null, new Guid("52010289-102f-414b-8fb6-a09a575f22a0"), "10/08" },
                    { new Guid("20b30c1a-ebb0-4462-a840-d5f843d6136c"), "329", "6115015440994271", null, null, new Guid("2063153a-a610-4c40-9ddd-456ef0b560db"), "08/20" },
                    { new Guid("212e2897-00d0-4448-b0b3-7c69cd468ec5"), "173", "5677843824074525", null, null, new Guid("b4e4db54-4f23-4365-96a9-cb8bd3cdaecf"), "07/07" },
                    { new Guid("21a34394-85d1-48bf-8bbd-e9dff4b23555"), "219", "1446927152583609", null, null, new Guid("a13d28a1-8900-4b0d-8399-27cc466b719f"), "03/19" },
                    { new Guid("21b40e8a-f499-4924-9658-0407d89358e6"), "676", "6678169929859900", null, null, new Guid("092e31f3-9b9a-4287-8cae-7fcd18feab47"), "06/03" },
                    { new Guid("21c1f069-3cbe-4337-977a-1065fd62c694"), "388", "8897956598957364", null, null, new Guid("013a7602-b915-4485-89ea-d3291ed9cab8"), "03/25" },
                    { new Guid("21dc923f-4159-4687-845d-0d5bb88707dd"), "293", "6530639715580013", null, null, new Guid("8c7f5100-7603-4d85-9e37-fba6a586f7c8"), "02/21" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("2216bc95-b022-48d0-9779-c5fd0fc0c0aa"), "124", "5849250491083748", null, null, new Guid("3ca63884-385c-4ae8-ac07-f3dc2df24aae"), "08/08" },
                    { new Guid("226fcc7b-de97-4a66-ba84-035d4c75de4d"), "079", "6003395552127923", null, null, new Guid("5c31a07d-9e1a-46bb-9c88-2f881f607c52"), "12/21" },
                    { new Guid("2295114b-24c8-4027-97c3-14722c0aaf65"), "768", "6099146831544726", null, null, new Guid("02df2ae2-d7d0-47a4-aeae-e733e06bb1d0"), "04/06" },
                    { new Guid("229a5991-6d55-4a90-a3e1-6f8320eadadd"), "095", "6270239767334092", null, null, new Guid("f7f7b1e1-146a-4f33-9556-99419aa87dbb"), "12/06" },
                    { new Guid("229cfaf5-5b51-42ac-a073-2466c72d308b"), "164", "6599834664758347", null, null, new Guid("e7414a92-a2c0-4cbd-a0ca-3a6c538ac8c6"), "04/20" },
                    { new Guid("236ffde2-9786-409f-9439-c1b239571a84"), "829", "2286401707303935", null, null, new Guid("5441f683-8cec-4fb5-96c6-2fa82e7997d3"), "12/20" },
                    { new Guid("237aca05-9609-411a-bd5c-e44318958ef8"), "031", "4711501084604557", null, null, new Guid("b944ae23-efab-4fcb-bda0-6be21e2add96"), "03/22" },
                    { new Guid("24b70e97-63fd-465c-aa1e-66c26ec5ec92"), "137", "2917278079374570", null, null, new Guid("708b56dd-a529-4229-82e2-2266f01c7942"), "01/18" },
                    { new Guid("24e55a54-346d-4409-ba2d-050b80600891"), "429", "8767080729479149", null, null, new Guid("6cbb9172-2b78-4f00-a841-8a1e6d6be79b"), "08/17" },
                    { new Guid("251cad4a-9ef9-4946-8be6-95c28980896f"), "018", "2280569349307312", null, null, new Guid("eedd859d-8af5-43b7-8938-5bce7dd89153"), "01/11" },
                    { new Guid("252153b6-da75-4ff6-9457-f1e77605104c"), "172", "4319944215925001", null, null, new Guid("e7414a92-a2c0-4cbd-a0ca-3a6c538ac8c6"), "10/13" },
                    { new Guid("25bc5c32-c1f8-47eb-a366-c9b4d9dce98e"), "537", "8333850973025503", null, null, new Guid("f9c15c1c-b6bd-46fd-921b-e1778f14dacf"), "01/14" },
                    { new Guid("25c06b39-5dac-4114-952b-59455571bd5e"), "041", "3138720791439172", null, null, new Guid("bd5c667b-2bfc-46c6-814e-7b5c93be8f43"), "06/14" },
                    { new Guid("261dc635-bd6d-4018-ab01-81c55f178404"), "425", "5367296617606664", null, null, new Guid("dffee49d-d296-4315-aefd-9602dd01358c"), "01/16" },
                    { new Guid("26486a58-b4af-45af-a8ed-afb05f290961"), "627", "5298132210602488", null, null, new Guid("ad53394d-1d27-416a-92bf-5074f6fa4fc4"), "10/22" },
                    { new Guid("265b70dc-798c-4ad7-8d27-b4d7ac12ac66"), "908", "4926645234193338", null, null, new Guid("5e0e0eed-1c83-4b51-8938-5bab69316dab"), "06/05" },
                    { new Guid("2665f181-b71c-439d-9fc6-9f16fd386c44"), "923", "1189249720479310", null, null, new Guid("e2dba597-b132-4b1a-a46f-540ebc581408"), "01/24" },
                    { new Guid("26708e76-f949-4d60-a269-2762c4de0c44"), "066", "4756729509589758", null, null, new Guid("708b56dd-a529-4229-82e2-2266f01c7942"), "07/25" },
                    { new Guid("26917c5c-772e-4810-978a-d2a58692bb44"), "394", "3572572073568094", null, null, new Guid("259e3939-18d5-4998-98ae-345c9d0fa279"), "11/11" },
                    { new Guid("26bff7f2-4309-4889-bf7e-46c4b5815f00"), "228", "8879468697778462", null, null, new Guid("51655f73-efc8-4142-b1ea-1657e4fc0f2e"), "09/25" },
                    { new Guid("26d200b5-b2e9-4d53-b625-ab3137eb6634"), "355", "9849695478779249", null, null, new Guid("e188b38e-8056-446d-96c9-b8979c4fd471"), "11/23" },
                    { new Guid("27031b63-9dd9-428c-8b8a-5fc355bb1151"), "990", "4766251867837895", null, null, new Guid("997402b2-514c-445f-9988-ae18a101181e"), "01/24" },
                    { new Guid("27049f71-ca9e-46e8-9837-7814b669df7e"), "742", "5516729821544751", null, null, new Guid("ed54e83f-5702-4289-98fb-949b73140a47"), "03/14" },
                    { new Guid("275a1371-8c5a-432c-bed9-dc10c34d4e9f"), "211", "4694771862580010", null, null, new Guid("37432efe-ddf1-4f3f-9753-a8b4a9e54500"), "08/26" },
                    { new Guid("277b8ef6-af23-4e60-b58e-8672d38dad29"), "411", "4194634848415199", null, null, new Guid("e1223f43-016e-41f5-b212-ab70a0ac01e2"), "04/02" },
                    { new Guid("27cfae0d-41a1-4bb2-8e09-5fc12a78f252"), "276", "2176180302806731", null, null, new Guid("51655f73-efc8-4142-b1ea-1657e4fc0f2e"), "10/10" },
                    { new Guid("2891ef67-2d0f-4749-becd-e4b1271b3fef"), "691", "7255219527441868", null, null, new Guid("63bd6aad-fd4d-4a2d-b0ee-341253297e79"), "02/10" },
                    { new Guid("28ad6923-4736-4dbd-bf1c-c8ca20aa860e"), "251", "9619989825514123", null, null, new Guid("e44b1f8c-951b-48de-a206-672ce80e3e29"), "03/02" },
                    { new Guid("2a2f126a-5ebd-4029-8bb5-ef151469af1f"), "907", "8957143646102166", null, null, new Guid("6375150d-9633-494e-ba79-b55f87d56afa"), "11/27" },
                    { new Guid("2aec7efb-8df3-4158-9292-9961da53c34e"), "048", "1880907206946122", null, null, new Guid("03a04e64-e8f5-4db8-ae88-e45982174d32"), "05/12" },
                    { new Guid("2b05b221-1cd5-405b-8a6f-b514633bf8cc"), "685", "8796061104411356", null, null, new Guid("5effd297-ddf3-4f40-afed-c85e49e3d248"), "02/09" },
                    { new Guid("2b0f6c63-c9a9-48f3-978e-3cf992d84fd3"), "606", "7671709871105556", null, null, new Guid("2eb253e8-852b-4b59-bbd3-41b1d962644b"), "02/06" },
                    { new Guid("2c4d3cba-f5bb-4df4-a380-8de5f92d9e50"), "665", "9004389097933573", null, null, new Guid("857e5ff4-368c-45c8-909c-9cb05ea33802"), "07/28" },
                    { new Guid("2c6ec3b3-ea82-410b-8b90-6551af51264c"), "701", "5250597584541560", null, null, new Guid("4883913c-7591-4093-a019-7e3dd870d152"), "07/21" },
                    { new Guid("2ca11b5c-1acc-40d5-a582-8ce06e619eae"), "344", "4002932785421350", null, null, new Guid("e807eb16-5caf-4274-9ff7-5027ed83325c"), "02/04" },
                    { new Guid("2cc1a674-6c26-445a-9bc2-f32dc112d5dd"), "255", "1135234787816788", null, null, new Guid("a01a13e5-a8d1-4048-b8b2-24cdfac5f11e"), "12/18" },
                    { new Guid("2d4238ef-d005-48a4-abf2-69cb15fbf265"), "398", "7922605833901651", null, null, new Guid("aa053e12-232a-4d5d-8b1f-0803fd8b7767"), "10/04" },
                    { new Guid("2d7b45bf-11f4-4225-9fc0-b4ba0b29177f"), "155", "7997112465437074", null, null, new Guid("a7a63c10-9b55-47c6-9d56-8793ee29aafd"), "07/06" },
                    { new Guid("2d8a3e64-951b-4249-b40b-7696a680e56b"), "488", "8525462445442923", null, null, new Guid("8a1cc6ac-cbbb-45b8-a858-79df665cbf01"), "02/24" },
                    { new Guid("2f003b6c-d31b-4638-95f3-320ee342fd2f"), "729", "2672585978389308", null, null, new Guid("e2dba597-b132-4b1a-a46f-540ebc581408"), "02/11" },
                    { new Guid("2f7a7492-1e6d-4c5d-a8c4-5e00ad7f1de0"), "419", "8184775500106983", null, null, new Guid("26ad372f-ab3d-49d6-a283-d78f71a0b97b"), "07/10" },
                    { new Guid("2f8b3e57-181c-46e6-b7a1-7c563fee1c03"), "822", "3568342692108427", null, null, new Guid("73977b0d-a6cb-4576-bd4a-b7056acdccd3"), "11/23" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("2fd6f40e-029b-4f52-92da-89aac4206453"), "599", "6316950924015903", null, null, new Guid("c561cc5e-190d-4a91-8ea9-d03583fa3f86"), "06/24" },
                    { new Guid("2ff5b4ac-1780-42c9-a8b8-15d1571761dd"), "867", "7228714086434895", null, null, new Guid("c1dedd78-34a2-4542-a585-a6ba740f5856"), "04/01" },
                    { new Guid("30434dd4-924d-450b-9ee2-1d79c1a31eff"), "861", "1621766409419626", null, null, new Guid("7e5e5ebc-3d4d-451a-884b-00a9d9f53676"), "01/01" },
                    { new Guid("3072e55e-6d47-41fe-8fea-2c9700f84c39"), "706", "3860602791406638", null, null, new Guid("b71f69da-e20d-4b25-b2fb-00d5eb1c9002"), "09/16" },
                    { new Guid("30a6f03e-73b2-4b95-9036-7b38df0a5ccf"), "000", "3836198716346141", null, null, new Guid("6dcb62c8-dc29-4e18-aabc-b9f4d6f3d1ce"), "07/09" },
                    { new Guid("31988be0-854c-4d65-a208-0d4280a18b04"), "857", "9882684985667132", null, null, new Guid("c50f147c-0804-4f38-a70a-7b8d4109234d"), "05/14" },
                    { new Guid("3275a924-890c-4b10-8f12-8bb75d8b6e28"), "620", "4894518276470030", null, null, new Guid("6dcb62c8-dc29-4e18-aabc-b9f4d6f3d1ce"), "11/14" },
                    { new Guid("32b62882-b108-4702-8da3-59b7ea2ceb6b"), "540", "6580543828940279", null, null, new Guid("d9295c19-5c11-40bb-ba7c-c1b368114ac0"), "01/01" },
                    { new Guid("32e8e307-848d-4424-aa38-d83263904252"), "730", "3656823244980948", null, null, new Guid("c50f147c-0804-4f38-a70a-7b8d4109234d"), "06/18" },
                    { new Guid("338614ce-a6d5-4cc7-9785-c5f6f32b7ee1"), "899", "5702580635655163", null, null, new Guid("568a5cfd-171b-413d-addf-fe6ab58aa6d0"), "12/15" },
                    { new Guid("33fb304a-6ac9-4fa1-b82f-e701889327fb"), "389", "3534493830447064", null, null, new Guid("3aa0613b-0255-46fa-9fc9-f73e67ec6962"), "09/08" },
                    { new Guid("340c7539-7dd1-4308-ba87-9585db8e7b6c"), "808", "6512284588852442", null, null, new Guid("6dcb62c8-dc29-4e18-aabc-b9f4d6f3d1ce"), "07/12" },
                    { new Guid("344e65d1-71e5-4d8e-b843-6103308fd674"), "006", "2443763056770841", null, null, new Guid("8a1cc6ac-cbbb-45b8-a858-79df665cbf01"), "11/01" },
                    { new Guid("3458ab14-abc6-4254-a12b-2df693c3185b"), "763", "5689195055108791", null, null, new Guid("77332645-fb25-478f-998c-36dd38aaba91"), "10/28" },
                    { new Guid("34e3505a-8ce7-4edb-8fac-be1caa13d0fb"), "990", "7213898744182768", null, null, new Guid("3a8ff431-6524-4268-ae59-91f87b944fae"), "09/19" },
                    { new Guid("34e992ad-19c7-42ef-b5f4-713b38272c0d"), "136", "5600510957933905", null, null, new Guid("ef14d144-d1c3-49fb-9e25-1889be79f4e3"), "01/04" },
                    { new Guid("34fa1c77-44af-48d4-8ea6-b15402d95923"), "171", "8531838080640044", null, null, new Guid("8606d3d5-5f3e-4f9a-b953-4be892f06c0d"), "11/01" },
                    { new Guid("357b6b00-0bd9-4e0c-861b-c1da4ee80bb5"), "336", "5866593308179864", null, null, new Guid("4d65579c-7caa-4a73-aec4-ebf5de2054ab"), "10/08" },
                    { new Guid("3585a9aa-bf74-48a0-925a-37dac6d4948b"), "175", "4929845137156747", null, null, new Guid("861c20c6-b2fe-4d03-a2b4-ae2380f7edc5"), "05/21" },
                    { new Guid("36f0e2c4-d51b-4e62-841f-b4a2a7bc60fa"), "588", "6472601944645012", null, null, new Guid("6709762d-580f-4c32-8f92-b1daa6e22c27"), "06/02" },
                    { new Guid("37055074-7f31-4fd1-ba99-ea8f699a69cc"), "968", "6206622061920011", null, null, new Guid("a165efc8-0956-4593-9333-e1ab17939488"), "05/25" },
                    { new Guid("374ff448-c9bd-4f77-bc06-a2aa1c9ddc94"), "189", "3123259221745557", null, null, new Guid("4ae96a4e-92a4-486e-b7ce-61d3f2fe842b"), "11/27" },
                    { new Guid("384103e5-fe23-446c-b590-b4325fd30516"), "802", "6373420624478407", null, null, new Guid("5a13878d-22a4-47a3-8eb8-3f4be375baee"), "03/10" },
                    { new Guid("384c96e4-2480-475b-b062-383e8c6d0a29"), "584", "3656891615796814", null, null, new Guid("4ae96a4e-92a4-486e-b7ce-61d3f2fe842b"), "05/23" },
                    { new Guid("3879f2f0-3964-4cba-92fb-3eef913f2297"), "343", "1868122906434373", null, null, new Guid("8606d3d5-5f3e-4f9a-b953-4be892f06c0d"), "12/05" },
                    { new Guid("38b63ca2-0940-4593-ac0f-f941247fd2f3"), "696", "2404934001262947", null, null, new Guid("73850497-d7e2-4015-bf80-d8fc761772d3"), "12/05" },
                    { new Guid("39337ec0-9c7c-4e23-9d4b-840a9bc6f229"), "061", "5487614684744723", null, null, new Guid("dd2a73f4-0d43-45df-8aa0-196122e00fc2"), "12/05" },
                    { new Guid("39ac7476-e6a5-4009-b1e9-f56828e5fa70"), "937", "7878533556115542", null, null, new Guid("b4e4db54-4f23-4365-96a9-cb8bd3cdaecf"), "12/28" },
                    { new Guid("3a2a01a6-d161-4c06-91c9-ad7d4e3ef847"), "846", "3089691731619048", null, null, new Guid("d666c5aa-5c03-4391-8629-5cc681422ca2"), "03/06" },
                    { new Guid("3ad55e67-c856-48c3-b3bb-46f32c5b76ef"), "446", "2529419584591444", null, null, new Guid("3a8ff431-6524-4268-ae59-91f87b944fae"), "02/22" },
                    { new Guid("3ad8a31f-d56a-44e6-bfce-0be6a034f562"), "165", "8300099206350269", null, null, new Guid("997402b2-514c-445f-9988-ae18a101181e"), "02/09" },
                    { new Guid("3b18f5f4-31ad-42c5-9f28-a5702d9fd223"), "983", "6949498172312581", null, null, new Guid("c50f147c-0804-4f38-a70a-7b8d4109234d"), "06/07" },
                    { new Guid("3b90fd28-0665-4ec0-9de0-6752b37ca273"), "394", "9422932801376902", null, null, new Guid("f472d28b-1df9-4c84-8ceb-3254f55042e7"), "06/24" },
                    { new Guid("3b95daf1-9777-4fbb-a105-315ceccb64c4"), "552", "5778727204255566", null, null, new Guid("52010289-102f-414b-8fb6-a09a575f22a0"), "11/04" },
                    { new Guid("3b989d70-5410-42d1-b5b8-c49e0601d50f"), "107", "8418750897402000", null, null, new Guid("c8db4c48-87fc-43bc-b9ef-e88e6764800d"), "10/23" },
                    { new Guid("3beed400-16fd-430f-9593-86939abcf82a"), "128", "8194388786268005", null, null, new Guid("552898bc-d86c-4567-80c9-bdb93739cab5"), "09/04" },
                    { new Guid("3c0fd4ab-71b3-41af-ad89-f3c1616dfc91"), "305", "2554099125989981", null, null, new Guid("ff75563e-5545-46de-a4b3-3e0727d74698"), "07/06" },
                    { new Guid("3c8f4070-71b0-4c70-9cf3-9b36947a43a0"), "125", "1713038724612686", null, null, new Guid("fc7807f7-2e15-4c19-8500-ea40f337d9de"), "12/25" },
                    { new Guid("3cf77d49-4908-4f5f-98ee-6642e0ae13e3"), "625", "3527238727740711", null, null, new Guid("88155035-c6f4-450c-bd25-3d3e9c9d8f5d"), "10/01" },
                    { new Guid("3d459ed7-481e-422b-80e8-454a4a0a5269"), "245", "7871465099486010", null, null, new Guid("37432efe-ddf1-4f3f-9753-a8b4a9e54500"), "12/28" },
                    { new Guid("3d597ff5-8042-438c-b7ca-fdb3f8e2b25a"), "821", "7736774077729179", null, null, new Guid("568a5cfd-171b-413d-addf-fe6ab58aa6d0"), "07/03" },
                    { new Guid("3dbc139a-b260-4a64-9615-0950dbf6af54"), "421", "4903076564456654", null, null, new Guid("cf6839a1-51b8-4ec5-bfec-3cbe48c20160"), "04/05" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("3dd8db2a-2606-46ad-8460-1ccd106c23f5"), "859", "8124748637391059", null, null, new Guid("ed54e83f-5702-4289-98fb-949b73140a47"), "09/09" },
                    { new Guid("3e651922-02ce-49db-89d3-5ee33fecf153"), "021", "4682079372873732", null, null, new Guid("7805e438-4982-4f20-9e68-baca0c631417"), "11/26" },
                    { new Guid("3e6d841c-d52e-4d96-994d-0e614135107c"), "008", "8212443212889307", null, null, new Guid("ce4c448e-35a5-4243-aa12-b967d2b3da6f"), "03/13" },
                    { new Guid("3ebaaae8-c83e-4612-9098-a9b9520abe8b"), "533", "4904720455468654", null, null, new Guid("e6b167e1-2f8a-4aa9-b766-dcb40c4c65b7"), "04/19" },
                    { new Guid("3ece45fe-890c-41f7-833d-99bdc5762672"), "869", "8050257918555373", null, null, new Guid("1546f9ad-e76e-4438-9513-2c0cdbcdc9dc"), "10/17" },
                    { new Guid("3fc377e7-44f0-450d-b83a-00e5f2ea07c6"), "711", "6353182724397136", null, null, new Guid("a3a7c05f-2de2-47a6-9d73-3dc95cb0a4bf"), "02/11" },
                    { new Guid("3feebc73-33e3-4a31-8d46-f93e4426b731"), "769", "9267646859048862", null, null, new Guid("9b8fcbcf-ce9d-40cf-aa2a-0543ebe6f135"), "05/03" },
                    { new Guid("3ff3dee6-9f83-4a38-bb58-1e8b04d9b193"), "693", "1885698762600570", null, null, new Guid("9ffccffc-cb42-46e5-86d7-6730697facf3"), "04/20" },
                    { new Guid("4014a569-f23c-462a-9d75-c040ac3ce2e3"), "718", "2576133040648126", null, null, new Guid("d5f398ce-f08b-4d20-af17-603089eb45ee"), "06/06" },
                    { new Guid("402e67d9-0a80-4679-bf1f-3f49c715d6ff"), "715", "9912344759317013", null, null, new Guid("49922094-de40-49f9-8fe5-21e734ddaadc"), "01/18" },
                    { new Guid("40d7d3be-fc9f-46ad-a8d0-ebd40c551417"), "224", "4480861484191802", null, null, new Guid("9e4f824d-b29a-4ec5-b3a1-111d46f41ecb"), "06/01" },
                    { new Guid("40e76b54-8a84-447c-887e-42522adae6ec"), "803", "6562067573121152", null, null, new Guid("a165efc8-0956-4593-9333-e1ab17939488"), "11/23" },
                    { new Guid("4103de80-e016-4e30-b1b4-7ee75151036b"), "422", "2521570154286951", null, null, new Guid("93ac31b1-6465-45d3-b0b5-98811dbc77b4"), "03/03" },
                    { new Guid("41ec0309-fbde-4765-8c50-fb5cc712c740"), "805", "5229844068663864", null, null, new Guid("e9781110-3553-481f-bb3a-7ca26a63a83b"), "03/10" },
                    { new Guid("41fa5c1b-a65e-48a6-8c4d-3eb2528ce59f"), "874", "4072246096073366", null, null, new Guid("b67eec58-0f42-4a35-a871-09c1ddaddd4b"), "11/25" },
                    { new Guid("42ae892a-7c29-480e-ace7-c08340da2716"), "416", "8003628757709321", null, null, new Guid("25cda556-70c4-4bb2-ad33-871e7ca4939c"), "03/06" },
                    { new Guid("42cc6349-4b74-4d53-b362-55f0aeb2e3ba"), "908", "4372220952434284", null, null, new Guid("97d70a43-949c-4c03-9da7-fc16fdc0c86d"), "12/19" },
                    { new Guid("42d2c9c9-6e00-4bb8-aeb0-3b5db62972b5"), "880", "4316475242747465", null, null, new Guid("4ccb797f-65b1-4b8c-809c-fe110c01052b"), "03/02" },
                    { new Guid("42e97cc4-efe9-4096-a710-e1f45c6ed0f1"), "895", "6274355100198357", null, null, new Guid("18314b53-d5e3-48fa-8ad6-dc84c3baa1ff"), "04/16" },
                    { new Guid("43d76d3e-3c81-4de0-a4d3-835c97d59fa3"), "154", "7699065982490126", null, null, new Guid("4d792f39-989a-48bc-8528-2bda17a5967a"), "09/06" },
                    { new Guid("43dec107-44d8-43f9-953d-f14a23bc72d2"), "172", "2521030462412382", null, null, new Guid("df250436-821d-48ab-9508-ab3df0550e27"), "06/16" },
                    { new Guid("4410fb0b-0f4e-4ed4-82cf-e8bc201d08fb"), "823", "9675105698552214", null, null, new Guid("fc2635e7-fbe6-403c-bcdf-dc9a65be3352"), "06/19" },
                    { new Guid("449e065e-eaef-4afa-9c97-e7361b46f1ad"), "145", "4453493762804474", null, null, new Guid("2063153a-a610-4c40-9ddd-456ef0b560db"), "11/06" },
                    { new Guid("454a8108-05a2-4a29-a89f-efafa2bc9256"), "708", "9121586324107470", null, null, new Guid("e188b38e-8056-446d-96c9-b8979c4fd471"), "05/22" },
                    { new Guid("4591c06a-dbc5-4525-9c6b-ac5c2e787ca4"), "297", "4645899511334562", null, null, new Guid("4952ad1a-3fe2-4d0a-a38e-1e28e3808afd"), "05/21" },
                    { new Guid("45b6854c-c6e0-4200-821b-2f51700c2b1e"), "946", "2318759267291831", null, null, new Guid("f7f7b1e1-146a-4f33-9556-99419aa87dbb"), "02/07" },
                    { new Guid("45b6acbf-dd9c-4ac8-b7eb-aa789fd81304"), "792", "6656146349745928", null, null, new Guid("25cda556-70c4-4bb2-ad33-871e7ca4939c"), "02/17" },
                    { new Guid("45d3e92f-5e3b-4218-8dde-975ebeb058b5"), "057", "6862222158294684", null, null, new Guid("52010289-102f-414b-8fb6-a09a575f22a0"), "11/08" },
                    { new Guid("45eaeb75-04f8-4bdb-b0bd-48e676399cc0"), "577", "6427547038191995", null, null, new Guid("8606d3d5-5f3e-4f9a-b953-4be892f06c0d"), "03/18" },
                    { new Guid("45edf1e3-1b8c-4cdf-8651-57c8c75c9c11"), "199", "2680207314244370", null, null, new Guid("d0fc0768-b3a0-4f82-affc-e355dc4101f4"), "02/15" },
                    { new Guid("47c95e20-bc18-4e91-9f01-31d90a2152ce"), "004", "6462224304166847", null, null, new Guid("d0fc0768-b3a0-4f82-affc-e355dc4101f4"), "06/23" },
                    { new Guid("47d6a770-f584-47e7-a017-7a4e3302faae"), "200", "6530621890333579", null, null, new Guid("d368ec62-a4a6-47b3-a955-fb176a32fe20"), "01/02" },
                    { new Guid("484100aa-6d1c-41fc-8a9f-e610b177d3db"), "027", "6615895856167262", null, null, new Guid("e27f9603-32f8-4066-bf07-4ab692c8350b"), "02/03" },
                    { new Guid("48576b2f-2c4f-42f9-be21-9c1a144997ff"), "448", "1804611296511964", null, null, new Guid("966d5ef1-e601-407d-86be-887c8e79a449"), "08/07" },
                    { new Guid("488efc5b-f431-4b76-a564-0af3680e3821"), "272", "1055965734453534", null, null, new Guid("cf6839a1-51b8-4ec5-bfec-3cbe48c20160"), "12/16" },
                    { new Guid("48c95557-2190-44be-9021-7138e2e493c6"), "494", "4291759011467827", null, null, new Guid("ffdf2e3d-14e1-47fc-a87f-43ee44597c72"), "05/04" },
                    { new Guid("48ec4078-47ec-4374-bc01-38ac87ec9a14"), "593", "7438399864414476", null, null, new Guid("5441f683-8cec-4fb5-96c6-2fa82e7997d3"), "06/17" },
                    { new Guid("49f1caa4-755f-4126-b09a-1a078431125b"), "543", "7263911025370810", null, null, new Guid("092e31f3-9b9a-4287-8cae-7fcd18feab47"), "01/08" },
                    { new Guid("4a4acff3-b178-4d83-82a9-a365ee062595"), "248", "2268673679259146", null, null, new Guid("cd3bba51-ecbd-472a-a962-7f603574b446"), "03/17" },
                    { new Guid("4a531f7d-3a8a-4019-8d22-d3ff19882606"), "220", "6898654689996561", null, null, new Guid("259e3939-18d5-4998-98ae-345c9d0fa279"), "08/08" },
                    { new Guid("4a9df41e-169a-4378-a6a6-cdf7349642a7"), "470", "6463480639197236", null, null, new Guid("8a1cc6ac-cbbb-45b8-a858-79df665cbf01"), "01/01" },
                    { new Guid("4ad84969-0674-42e5-8187-74662be41f7a"), "038", "9917436706614771", null, null, new Guid("3aa0613b-0255-46fa-9fc9-f73e67ec6962"), "02/12" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("4af4bd00-702c-4017-8490-a168817459bc"), "475", "6380745883080093", null, null, new Guid("aee768a4-2b67-47da-a692-ab2b1cd95c27"), "09/01" },
                    { new Guid("4b49a0ba-0d3b-483d-b2c5-59f1deb7702f"), "658", "4778728586628747", null, null, new Guid("f044a50f-e46f-4992-b8ae-47aa00e79d4d"), "03/18" },
                    { new Guid("4bc6b8f7-466c-4518-a077-9616012bbb67"), "242", "1759498495350478", null, null, new Guid("f9c15c1c-b6bd-46fd-921b-e1778f14dacf"), "04/27" },
                    { new Guid("4c18fb12-5193-4a19-9a26-f60c9b12a3d4"), "439", "9822881516551816", null, null, new Guid("ce4c448e-35a5-4243-aa12-b967d2b3da6f"), "12/13" },
                    { new Guid("4c612af0-259f-4e3f-bcd9-88a38407c80b"), "601", "3246112065759397", null, null, new Guid("d8361619-ae4f-4db1-9eb9-291e4814a381"), "08/04" },
                    { new Guid("4c6d3b3a-8d22-4c0e-89cf-6af9d8cdabb6"), "799", "2186464723135524", null, null, new Guid("4bffa9b9-a7ae-4dd6-b87b-dbcad3737bfd"), "01/18" },
                    { new Guid("4cf02823-763f-4ecd-9e9f-9b1d6242b16d"), "753", "9120085380482819", null, null, new Guid("ef100efa-deb4-4516-9a15-38df8ff7e396"), "04/16" },
                    { new Guid("4d69e7ea-6aca-4ebb-80e9-1228bc26ebed"), "719", "4221466691251503", null, null, new Guid("0768641f-3440-4d72-a350-3b2eca842a26"), "11/15" },
                    { new Guid("4d7bc916-82fc-4739-8da1-87612cbe1e16"), "656", "9105159661290954", null, null, new Guid("d8dd96ce-4557-4993-959c-45a29c967d51"), "01/15" },
                    { new Guid("4d8692b5-42fe-423f-b74a-2918a2b5fca8"), "778", "4838120970418070", null, null, new Guid("f472d28b-1df9-4c84-8ceb-3254f55042e7"), "05/01" },
                    { new Guid("4d9a3235-9cd3-44e3-acb1-bf0a968133ba"), "799", "2910030390424742", null, null, new Guid("a8a8fdd8-4ded-4cee-9b8c-87f2285d7eab"), "02/16" },
                    { new Guid("4dc12ea7-7257-4a6d-b412-618e0c4c1534"), "042", "1496475824104991", null, null, new Guid("86139076-e779-453a-8f87-64e1bfeeeccc"), "11/08" },
                    { new Guid("4e46c28e-26e6-4a50-b7cc-e95f3ddfa261"), "545", "9492564511653688", null, null, new Guid("c3f74963-e8a7-4598-bde6-0b7eb8dc16d8"), "02/21" },
                    { new Guid("4f115226-e41e-4d04-acb8-a96ae860ba75"), "361", "9842779019053696", null, null, new Guid("b71f69da-e20d-4b25-b2fb-00d5eb1c9002"), "05/02" },
                    { new Guid("4f12ce84-5584-460d-866e-884e116fb15e"), "252", "5791204065539539", null, null, new Guid("960fe293-a56c-42c1-b68b-57d1e361fe6d"), "12/08" },
                    { new Guid("4f65e99b-a952-4ae3-9160-effa9bcccc4c"), "791", "8348162629764683", null, null, new Guid("e6b167e1-2f8a-4aa9-b766-dcb40c4c65b7"), "06/11" },
                    { new Guid("4fb80a34-9763-468a-bda9-b73315a67643"), "044", "5419254722964975", null, null, new Guid("620337a7-cc3b-43d5-aef4-5b29e97ab466"), "09/26" },
                    { new Guid("4ff22183-bad9-45a0-8353-73ad5b5c54de"), "720", "3803627031891017", null, null, new Guid("f54b6d8e-36d4-482b-83f6-69bd802b2ec3"), "09/11" },
                    { new Guid("5026baaa-6371-46c7-8a78-842cb42d4b4d"), "774", "7600426994274673", null, null, new Guid("5e0e0eed-1c83-4b51-8938-5bab69316dab"), "12/03" },
                    { new Guid("50698411-fbf3-423a-858b-ef3e1d0cd56b"), "125", "5650374069021849", null, null, new Guid("43b84c41-ad8c-49ff-ae3a-561f6d21e04b"), "01/13" },
                    { new Guid("5163e7df-9921-4f40-a030-784190782461"), "784", "5064327518005397", null, null, new Guid("15cc8bf6-f5ac-435e-a654-84e10e29a1bd"), "07/19" },
                    { new Guid("51838f3e-d37c-4cfc-8baf-c77e3400c7e8"), "126", "5516735103734016", null, null, new Guid("e44b1f8c-951b-48de-a206-672ce80e3e29"), "06/08" },
                    { new Guid("51c8b210-cb56-41d9-beba-d075df0e578c"), "285", "1625977326432123", null, null, new Guid("d666c5aa-5c03-4391-8629-5cc681422ca2"), "04/20" },
                    { new Guid("51dcf0f0-8e1d-42ac-9b86-685b0de99b81"), "852", "4556745739015611", null, null, new Guid("17441686-0fa5-4e5d-b680-2d5708a2ecd5"), "07/09" },
                    { new Guid("52662ab2-c37e-499f-bbc7-c587977b76fe"), "335", "7334118758128512", null, null, new Guid("7f910a03-763a-4cdb-bbcb-8241bae6fc96"), "01/14" },
                    { new Guid("52a16464-eee1-46f0-b57c-fa7669d35234"), "860", "9602893578891008", null, null, new Guid("17441686-0fa5-4e5d-b680-2d5708a2ecd5"), "08/22" },
                    { new Guid("533bf1c7-b67b-4039-bafb-61716709d4fc"), "835", "1395101556665102", null, null, new Guid("94e92894-3b19-4c5f-9e95-0ec52116ec92"), "03/28" },
                    { new Guid("53a466ca-c3f8-4913-95b9-37aa4989ae65"), "716", "7499287055100506", null, null, new Guid("7771e104-7d9f-4097-8375-a33ad264e1d8"), "06/04" },
                    { new Guid("53cda60f-fa7a-40d6-902e-df34e3587b63"), "247", "2797125299516414", null, null, new Guid("69879006-dc0c-45ee-a1d8-571618a19f4d"), "05/09" },
                    { new Guid("53fce58e-6c9c-44e8-80f6-83d73405f073"), "067", "4838929389363134", null, null, new Guid("7902b014-f441-4bad-a55f-7656352c84e7"), "05/17" },
                    { new Guid("541ec6e2-b44c-47a0-a0c1-97122d53f43c"), "398", "2716327520132000", null, null, new Guid("6dcb62c8-dc29-4e18-aabc-b9f4d6f3d1ce"), "03/07" },
                    { new Guid("54a618e5-2595-40f7-ad21-7e1d81d510fb"), "910", "8756639862618971", null, null, new Guid("63bd6aad-fd4d-4a2d-b0ee-341253297e79"), "04/17" },
                    { new Guid("54fc382b-9415-48ec-b92c-1c646c91e403"), "408", "9606706946888907", null, null, new Guid("9dafc6e9-0e56-47f8-8b8b-4ca541841bd0"), "07/26" },
                    { new Guid("56232e47-a9f5-4219-ab98-6732212fa218"), "215", "5101399124828603", null, null, new Guid("5d6854b6-463d-4c99-844f-2b03c65e196b"), "03/27" },
                    { new Guid("56424312-d607-4ce6-a6d2-9b0e88d60d59"), "617", "3601222775329733", null, null, new Guid("c9de1952-448f-4a77-a4fa-b78a3751957a"), "05/02" },
                    { new Guid("5689e67b-287a-464a-bdc8-1504edcc1c3e"), "553", "2860357003786362", null, null, new Guid("9e4f824d-b29a-4ec5-b3a1-111d46f41ecb"), "09/27" },
                    { new Guid("56cc5aea-53df-4cb2-94d9-5f7498667119"), "911", "8784110163729815", null, null, new Guid("4bfa50d6-7b76-402d-afe8-4b558ee6165b"), "08/07" },
                    { new Guid("571641d3-c869-45ba-950a-886084c62c60"), "539", "6987313493110565", null, null, new Guid("3aa0613b-0255-46fa-9fc9-f73e67ec6962"), "12/27" },
                    { new Guid("571eacad-1ef2-4608-a271-5172544a6a02"), "140", "9537410867694228", null, null, new Guid("d08dab84-c369-4193-b4fb-bbd252c59cc5"), "11/02" },
                    { new Guid("5743ba36-1f27-40f0-8430-a3f252a3a505"), "394", "2742370184958988", null, null, new Guid("259e3939-18d5-4998-98ae-345c9d0fa279"), "04/08" },
                    { new Guid("574c1e60-bf03-4255-a33f-070108cac64a"), "202", "2422677472384698", null, null, new Guid("aa1380ad-62cc-4108-817a-4ac56a2c382d"), "05/09" },
                    { new Guid("574dedf5-79f7-46ee-a164-97862a63261b"), "749", "2131259224867619", null, null, new Guid("e2dba597-b132-4b1a-a46f-540ebc581408"), "07/27" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("5755dc4b-3467-4712-b287-9d6c65defc30"), "859", "2630066974536701", null, null, new Guid("c3f40de8-9c2b-4f97-b99a-a3d5f6431b27"), "12/16" },
                    { new Guid("57d220a5-2917-4127-ac52-979f30083441"), "331", "1760623947414184", null, null, new Guid("e58d2261-638d-41ed-b5bf-55b3a94546e1"), "08/12" },
                    { new Guid("582cf7ea-a5b1-48c4-bde7-5f1aa3d6683b"), "359", "4306431528576126", null, null, new Guid("58fc780f-3b29-4947-a319-3ed8b421144e"), "11/01" },
                    { new Guid("58376871-f7f0-42fe-bbcc-5efbd093e0f3"), "674", "3272522105747543", null, null, new Guid("22c74cee-2548-4aef-ab56-019f64d2fb3e"), "08/13" },
                    { new Guid("58a42ecd-7479-4ba5-9fa9-5089813e8272"), "181", "8676128745431248", null, null, new Guid("a3a7c05f-2de2-47a6-9d73-3dc95cb0a4bf"), "09/09" },
                    { new Guid("5a649d8c-5e70-4b0d-81b0-40b168aaa886"), "256", "2615416765391953", null, null, new Guid("1d118b7f-07b1-49dd-9f7d-5a1e7d8ea4bc"), "01/21" },
                    { new Guid("5ade74eb-eee9-4552-9872-9953dfac62a4"), "405", "7840717867194845", null, null, new Guid("e44b1f8c-951b-48de-a206-672ce80e3e29"), "06/15" },
                    { new Guid("5afd7ea5-9120-48a9-b06d-62ef4a32b7a5"), "356", "2053845132815706", null, null, new Guid("c431ef46-de70-4dba-a2b4-061b2a219ebc"), "08/18" },
                    { new Guid("5b46003d-fef6-4127-80e8-b891c3ca1d57"), "887", "8475453176236362", null, null, new Guid("8adfe810-a4af-41ad-bda0-c1898bdb4d92"), "03/27" },
                    { new Guid("5b5a4338-fd31-44b2-a28d-9b4c3aaac4be"), "589", "4695970006088126", null, null, new Guid("8dd6a489-4514-4244-9fa7-a1490970f38b"), "02/12" },
                    { new Guid("5b5c0cf2-f6d0-4717-b857-456288022d64"), "960", "9676375949130103", null, null, new Guid("0ffea79c-1eaa-4ef4-b27f-e6c525534682"), "05/07" },
                    { new Guid("5c0533b7-aa65-4193-97e1-cd1f95fb565a"), "307", "3887982863041220", null, null, new Guid("5a6031a7-d008-4d4c-9a87-857d42759454"), "06/27" },
                    { new Guid("5c0be1a5-8175-4921-b77d-4326575ea770"), "080", "4508316258239794", null, null, new Guid("cc549d3d-c127-48fe-9320-69c0367cf0ef"), "11/07" },
                    { new Guid("5c4c8574-cb5c-47ca-b524-50d62262481c"), "125", "7408243871829620", null, null, new Guid("71ef850e-2fd5-4538-9b05-9c38cbbdbe30"), "12/13" },
                    { new Guid("5c638633-1713-4fb3-8fb6-4f173ff45b20"), "259", "7649464384701473", null, null, new Guid("73aad8c3-cbed-4125-b80b-7db0735c3ac6"), "09/22" },
                    { new Guid("5d246c35-b196-4126-9f46-1d16d88be2e3"), "666", "6613739333367471", null, null, new Guid("a4b4b14f-6b7f-4104-b0d2-b8f55417f1e7"), "12/17" },
                    { new Guid("5d454615-d2bd-45be-b3f3-428b84d49637"), "585", "1835795949879807", null, null, new Guid("86139076-e779-453a-8f87-64e1bfeeeccc"), "10/14" },
                    { new Guid("5d9efd23-3115-4a76-9fbc-3ca2e57cee85"), "268", "9161464482611081", null, null, new Guid("51655f73-efc8-4142-b1ea-1657e4fc0f2e"), "09/09" },
                    { new Guid("5dacab94-678d-431a-9656-8d05060f9f92"), "947", "3860373515096018", null, null, new Guid("0768641f-3440-4d72-a350-3b2eca842a26"), "03/10" },
                    { new Guid("5db7fde3-fa8b-4bd6-9621-ddc577d7ae77"), "833", "2937495014863657", null, null, new Guid("013a7602-b915-4485-89ea-d3291ed9cab8"), "09/28" },
                    { new Guid("5dbfebd2-d506-4270-90c6-2137fde9813d"), "441", "1575164355101583", null, null, new Guid("9a799371-7ad4-44c8-bcc3-759981e1573a"), "12/18" },
                    { new Guid("5dd85761-0f34-4c19-b12c-6fc2327966c6"), "253", "1337387829997358", null, null, new Guid("6375150d-9633-494e-ba79-b55f87d56afa"), "04/20" },
                    { new Guid("5e2444f9-944b-42ac-97e2-778f1b35e18a"), "603", "9823130737490223", null, null, new Guid("c8db4c48-87fc-43bc-b9ef-e88e6764800d"), "11/13" },
                    { new Guid("5e6e54c0-384a-468d-b843-9bd60f584a0a"), "705", "6405706542394715", null, null, new Guid("6cbb9172-2b78-4f00-a841-8a1e6d6be79b"), "05/08" },
                    { new Guid("5ec81627-0fa3-4d5d-86ce-832156ded8f2"), "851", "8837556103953992", null, null, new Guid("dfa0bf0e-13dc-416f-bb54-aaeb47a68545"), "03/24" },
                    { new Guid("5f76e010-e805-4957-a437-857b3aa962fb"), "427", "1950315853140144", null, null, new Guid("5560fdd3-3041-418a-bdbd-b1b7cb595a87"), "07/04" },
                    { new Guid("600b8e2a-e0fc-417d-bba7-f83b121b6c4d"), "518", "2902490322080380", null, null, new Guid("ffdf2e3d-14e1-47fc-a87f-43ee44597c72"), "03/14" },
                    { new Guid("608a9e44-ef5c-41fa-88cc-c67f3a7b02e0"), "157", "2722271606173298", null, null, new Guid("146a249e-e614-41cc-98ab-d6287da977e5"), "01/05" },
                    { new Guid("608bd68d-693f-4004-9719-91ff1af2ccd4"), "219", "5328766686677309", null, null, new Guid("73aad8c3-cbed-4125-b80b-7db0735c3ac6"), "03/01" },
                    { new Guid("60d4eebf-6e5b-4a55-a5dc-29de65dc1308"), "355", "4228161047557553", null, null, new Guid("d368ec62-a4a6-47b3-a955-fb176a32fe20"), "07/18" },
                    { new Guid("6186d702-cc65-4917-a02b-b33d26803ad1"), "350", "4594906513494624", null, null, new Guid("fc15fcf7-014b-4521-910c-8a4a05ae7df9"), "11/19" },
                    { new Guid("61f7ee96-dd7b-488c-a70c-c5e84b99ef1a"), "229", "4596603208006661", null, null, new Guid("6709762d-580f-4c32-8f92-b1daa6e22c27"), "12/11" },
                    { new Guid("62197c23-c938-456f-8e0f-def5c5acdd07"), "644", "1551695527287830", null, null, new Guid("b070b87c-5a28-4f27-8f54-9238dfbe5c79"), "07/07" },
                    { new Guid("621996aa-d047-4fa7-adc6-f34b8c09a2c6"), "314", "9541677166980076", null, null, new Guid("ac2d4745-386c-4c13-a217-d9e2d9b842df"), "02/09" },
                    { new Guid("6275a3e3-be87-4550-a00d-77d6943eabad"), "722", "5099890271355161", null, null, new Guid("861c20c6-b2fe-4d03-a2b4-ae2380f7edc5"), "05/19" },
                    { new Guid("628dfa9f-3b87-425f-a951-f1cd27d367ea"), "366", "2833851305592417", null, null, new Guid("bcb5583b-3b55-4ea8-b016-f74baf89e99a"), "09/05" },
                    { new Guid("62c552eb-bde2-4d28-b66b-e156b1010f92"), "373", "9742733104605782", null, null, new Guid("a6fc0423-6291-4866-8d02-6faea1986c4e"), "04/07" },
                    { new Guid("62cac5ce-a366-4009-9025-13ffeed01e5e"), "270", "7688155994213312", null, null, new Guid("284afcd2-63de-4550-906f-0a1ce11e8244"), "04/28" },
                    { new Guid("6316094a-d973-426f-a28a-19cd7df546b9"), "883", "2783627735256104", null, null, new Guid("c3a4c71d-a9ab-475e-9d5b-425a5d31fb48"), "10/24" },
                    { new Guid("6317caf9-5811-417d-aeb8-aeef996b4e27"), "531", "3901933033773423", null, null, new Guid("437bc41c-af0d-4443-809f-276b155b8846"), "07/27" },
                    { new Guid("6388279c-d169-4240-996e-86e5cddb4ed9"), "602", "9052081224033931", null, null, new Guid("69536a6d-5fc0-40dc-96ff-96cfa2e2ddde"), "01/06" },
                    { new Guid("63a59976-d746-4bd1-ac4e-2c0489fbe2a2"), "687", "5642998031105767", null, null, new Guid("aee768a4-2b67-47da-a692-ab2b1cd95c27"), "08/17" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("63aa3694-d20b-4c34-b40a-eb8c064f14c5"), "045", "5393147375695538", null, null, new Guid("8dd6a489-4514-4244-9fa7-a1490970f38b"), "03/07" },
                    { new Guid("64879bb2-2b9d-40dd-9469-58a4e8b9244e"), "513", "1374461030186324", null, null, new Guid("c311c4ad-bbcf-418b-8259-eec5ae72eb71"), "06/06" },
                    { new Guid("650db3e6-6bd1-477f-b965-919069ed6053"), "764", "5958387822828465", null, null, new Guid("c3f40de8-9c2b-4f97-b99a-a3d5f6431b27"), "08/11" },
                    { new Guid("658dc09e-92b2-4ff6-98a4-8291febcfa36"), "289", "4461726910543254", null, null, new Guid("c561cc5e-190d-4a91-8ea9-d03583fa3f86"), "07/16" },
                    { new Guid("65eebe39-6bf0-4c52-bec8-55c9e874ba3c"), "788", "4736652837881155", null, null, new Guid("c311c4ad-bbcf-418b-8259-eec5ae72eb71"), "06/07" },
                    { new Guid("665cbe1a-c80e-4783-ada7-a94ff5d82591"), "799", "6759425263376121", null, null, new Guid("d666c5aa-5c03-4391-8629-5cc681422ca2"), "01/28" },
                    { new Guid("6663f1b6-5546-4fcc-9320-23268999f4ad"), "829", "4063871970166729", null, null, new Guid("0a69540b-ce9e-427c-8970-9f311fba0c21"), "11/07" },
                    { new Guid("66752878-f4bf-450a-8ab9-2baed0a48b21"), "559", "2464589848353037", null, null, new Guid("a6fc0423-6291-4866-8d02-6faea1986c4e"), "04/19" },
                    { new Guid("66e8cf5e-c7dd-4e0d-b473-72b37b994b98"), "609", "3440532579956485", null, null, new Guid("24b96e86-5860-47b1-a6ec-9a832bafbb14"), "09/16" },
                    { new Guid("6706daae-ff01-4bf7-b05d-cccf4a1f6132"), "526", "6824604877985302", null, null, new Guid("ad53394d-1d27-416a-92bf-5074f6fa4fc4"), "03/28" },
                    { new Guid("671d7969-03a2-43ef-a4dc-5ba8b133ceb0"), "554", "6831671265477659", null, null, new Guid("9a38b671-5580-4658-abf4-c1fc9ce2be0b"), "04/24" },
                    { new Guid("67bb8270-c395-4f7d-b711-fa8f33680eda"), "083", "4772871504074418", null, null, new Guid("d9295c19-5c11-40bb-ba7c-c1b368114ac0"), "05/03" },
                    { new Guid("68ab288e-0a5c-4e7f-a117-ce9efeb9839c"), "062", "2470524436729540", null, null, new Guid("f472d28b-1df9-4c84-8ceb-3254f55042e7"), "04/02" },
                    { new Guid("68fe0624-6637-457f-bede-80ac27d0a829"), "685", "8541020767751706", null, null, new Guid("7771e104-7d9f-4097-8375-a33ad264e1d8"), "09/08" },
                    { new Guid("691fa532-f739-4538-84a6-e54af3d46f22"), "224", "9726275764011510", null, null, new Guid("86139076-e779-453a-8f87-64e1bfeeeccc"), "06/10" },
                    { new Guid("695ff5c1-f2dd-44a9-be58-86d0adbc610f"), "345", "1360030759862411", null, null, new Guid("2063153a-a610-4c40-9ddd-456ef0b560db"), "09/04" },
                    { new Guid("697b4e30-5185-4eb5-b6b7-ebcec21bc229"), "916", "8376963860903737", null, null, new Guid("bcb5583b-3b55-4ea8-b016-f74baf89e99a"), "02/16" },
                    { new Guid("69a5f451-647c-450c-ad21-994f2eb24f03"), "540", "2440709223109850", null, null, new Guid("4a254852-2316-4300-99be-6d54e3eeac93"), "05/07" },
                    { new Guid("6a1ffd3d-3f56-4615-970a-258e34d65129"), "095", "3316040114502582", null, null, new Guid("fd6ebc44-c70c-4ea5-ad8a-6029ee9c49d9"), "05/07" },
                    { new Guid("6a4dabd2-19b7-407a-a721-e5bd299d5713"), "603", "4073323206681890", null, null, new Guid("8adfe810-a4af-41ad-bda0-c1898bdb4d92"), "10/12" },
                    { new Guid("6b29a873-903a-4f37-bfb1-c4f5fa2caff6"), "310", "5353723593502760", null, null, new Guid("cb8696d4-d2d5-40c3-b74f-38aafecd34f8"), "01/02" },
                    { new Guid("6b4a3efb-e0e3-4078-9176-32ae2d0ea849"), "722", "8807487618920525", null, null, new Guid("58fc780f-3b29-4947-a319-3ed8b421144e"), "01/19" },
                    { new Guid("6b52fb3a-6dd0-4da4-b771-1f5156f43f95"), "372", "8499555963815154", null, null, new Guid("b5fe6c30-5f2d-462b-9dd2-bc5388f99ce5"), "01/08" },
                    { new Guid("6ba54f22-3c7c-4f67-98bf-e43ce7172cb5"), "524", "8610067968055562", null, null, new Guid("d0627291-bbf2-408e-bc02-9ba09faa06bd"), "09/09" },
                    { new Guid("6bcc670e-9cd5-4924-9e0a-248a5434b0e1"), "241", "5355706761476514", null, null, new Guid("db79e848-cfae-4c0f-8859-e5d6af4a311c"), "04/11" },
                    { new Guid("6be8ea63-5bb5-4aed-b7b9-ae1dfc944ada"), "916", "4808616827817484", null, null, new Guid("96389a1d-3bc8-465b-ba35-3027877a9981"), "02/08" },
                    { new Guid("6c2544f8-d650-444d-bc56-14e458672de1"), "267", "3208984581391854", null, null, new Guid("ce4c448e-35a5-4243-aa12-b967d2b3da6f"), "06/23" },
                    { new Guid("6c26ee1c-d05b-47f6-9830-cc5d09bc8138"), "350", "6405861992431459", null, null, new Guid("d9fc54cb-e30e-4a48-b749-08ff99fcff26"), "07/09" },
                    { new Guid("6c522cab-fb98-4d34-8ca4-898c64a9df60"), "450", "7641342774557715", null, null, new Guid("2a328a80-898f-4b62-921d-731137bebe9f"), "10/11" },
                    { new Guid("6c6ede3f-d459-4538-bf1f-44aad544c313"), "561", "5308267560060521", null, null, new Guid("a13d28a1-8900-4b0d-8399-27cc466b719f"), "12/26" },
                    { new Guid("6c8aaf99-3379-4492-9ddd-3050f9341582"), "098", "4750927744641000", null, null, new Guid("8e8fd0f7-2809-49f2-9c1e-cbeb885b2de7"), "12/28" },
                    { new Guid("6c9f9f11-abe1-46d1-8f2a-42d76333f0f0"), "264", "9456013757378514", null, null, new Guid("ca9a7100-5d5c-406e-8028-d065cd21c772"), "01/22" },
                    { new Guid("6d1932ad-5418-4403-bfbf-e09d6655eaca"), "211", "2142484515692371", null, null, new Guid("b2a11489-a556-462e-9631-1108d9049fcc"), "12/19" },
                    { new Guid("6df94e44-0479-42ea-b096-ac4e4af887b6"), "604", "6634555994122483", null, null, new Guid("d08dab84-c369-4193-b4fb-bbd252c59cc5"), "09/09" },
                    { new Guid("6e0d0e52-f6e2-48ce-baa8-57377055a689"), "574", "7224378843032182", null, null, new Guid("b67eec58-0f42-4a35-a871-09c1ddaddd4b"), "04/16" },
                    { new Guid("6e413d67-163d-4131-be6a-4c79b420280e"), "505", "6762252731825605", null, null, new Guid("8c7f5100-7603-4d85-9e37-fba6a586f7c8"), "06/17" },
                    { new Guid("6e859686-c237-48a7-a3a3-29e14f8f1c0c"), "278", "7498202243521013", null, null, new Guid("aee768a4-2b67-47da-a692-ab2b1cd95c27"), "12/04" },
                    { new Guid("6ee86625-6d33-4d7c-80d1-eca6f44e85ac"), "896", "2649615610732760", null, null, new Guid("2f7c84d9-6fe2-4a1c-ba84-c8d43feade58"), "03/04" },
                    { new Guid("6f7669e9-f879-4f93-8b08-f5cd1f704cc1"), "993", "5450449456460682", null, null, new Guid("749d009d-0557-4289-976a-50a7e345a281"), "01/04" },
                    { new Guid("6fa56709-02f0-4df0-bc05-850fd426bab2"), "003", "6106908285585730", null, null, new Guid("ef14d144-d1c3-49fb-9e25-1889be79f4e3"), "05/20" },
                    { new Guid("7006d94c-fda7-4814-8df0-391577c4feea"), "490", "1130631428280505", null, null, new Guid("89c19062-b085-4717-8960-680ec5f619e0"), "02/13" },
                    { new Guid("70454381-ecaf-4ded-8348-f43d7e258388"), "399", "2833781481140681", null, null, new Guid("73aad8c3-cbed-4125-b80b-7db0735c3ac6"), "08/10" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("70d2bee1-fcba-497f-9980-9859d60015c4"), "255", "1822614423593568", null, null, new Guid("092e31f3-9b9a-4287-8cae-7fcd18feab47"), "09/26" },
                    { new Guid("71fbe048-721c-486b-92a8-21bdbd03f689"), "265", "8920464884506039", null, null, new Guid("18314b53-d5e3-48fa-8ad6-dc84c3baa1ff"), "09/18" },
                    { new Guid("72d024fc-b581-4c91-b3e8-39b2e4197b42"), "931", "7725957067001146", null, null, new Guid("69879006-dc0c-45ee-a1d8-571618a19f4d"), "08/22" },
                    { new Guid("72e0b71c-5ecf-49bd-bc59-66789e6e562a"), "195", "8472562527934310", null, null, new Guid("abf3ceb3-3421-4454-9686-7b4c13cd1fbf"), "11/28" },
                    { new Guid("73b84552-08d8-42f5-9b34-7848bc165bca"), "586", "9258331076396929", null, null, new Guid("d4409d83-a792-488f-bea4-9e1b42950fc9"), "01/22" },
                    { new Guid("73fbdb83-677f-4eb3-9910-5133a97cd042"), "536", "5910818167301025", null, null, new Guid("c60620ff-d62e-4585-9510-ed612aa89dcb"), "05/08" },
                    { new Guid("746cb33c-0b2e-4a05-bd8f-18ece30157e8"), "522", "5623400300640499", null, null, new Guid("5effd297-ddf3-4f40-afed-c85e49e3d248"), "10/23" },
                    { new Guid("749ca7a5-a116-40fd-85eb-5bbbe312e1ee"), "568", "7577889990492815", null, null, new Guid("a6b4e3da-0d2b-4dbd-9f10-ea183f9d6225"), "05/07" },
                    { new Guid("74e42f4d-6288-4edc-8d6e-15b3ae52a78f"), "924", "7089158934854164", null, null, new Guid("6ee9a7d3-8695-4b4a-9a7f-e035a03a4cc3"), "10/05" },
                    { new Guid("757b9e36-d460-413b-ab3b-44e18a04dc51"), "120", "8718451602464482", null, null, new Guid("092e31f3-9b9a-4287-8cae-7fcd18feab47"), "06/12" },
                    { new Guid("76170f98-b233-47b0-909c-bd2a2fc6b16e"), "882", "1228779644881595", null, null, new Guid("7b354f95-20a6-4d69-abe1-b5a212feb069"), "01/09" },
                    { new Guid("77417138-2d0d-49c6-a222-de3b710f7547"), "762", "3209554469167196", null, null, new Guid("f54b6d8e-36d4-482b-83f6-69bd802b2ec3"), "07/14" },
                    { new Guid("7777aa20-06c8-4033-b0d5-4ddd027e36ae"), "106", "5619501165547028", null, null, new Guid("da687a7e-bca5-449f-ad43-32e0ac00fe15"), "11/26" },
                    { new Guid("77e1af9d-f20a-43bc-b780-3eda8355f166"), "960", "7000042650274031", null, null, new Guid("2eb253e8-852b-4b59-bbd3-41b1d962644b"), "02/20" },
                    { new Guid("77e50d8b-8e6a-4fc1-abb5-d56c1fd929ca"), "030", "1998785404647793", null, null, new Guid("16dfe9db-9389-4852-8b69-53610d60b359"), "11/04" },
                    { new Guid("786992d8-4ccf-4db4-a992-e77c149ecc13"), "006", "6072177029241179", null, null, new Guid("ca9a7100-5d5c-406e-8028-d065cd21c772"), "07/16" },
                    { new Guid("789e314e-d46c-4075-a0df-04090bacbee6"), "453", "8425297236827449", null, null, new Guid("d0fc0768-b3a0-4f82-affc-e355dc4101f4"), "01/26" },
                    { new Guid("78bcacec-7ff3-4d7f-abc9-f3a2c5d4da2b"), "226", "2843768109652384", null, null, new Guid("ad53394d-1d27-416a-92bf-5074f6fa4fc4"), "10/01" },
                    { new Guid("78ed1671-75f7-4afd-948b-d7208d916cfd"), "608", "4412722967674893", null, null, new Guid("6507f7f4-4076-4fff-b89e-4205b52b6408"), "03/02" },
                    { new Guid("7985e493-60f4-487b-bd42-9d6df80e38b6"), "977", "3626422192584348", null, null, new Guid("4d65579c-7caa-4a73-aec4-ebf5de2054ab"), "11/14" },
                    { new Guid("79cf58f7-527f-4c74-b89e-c526c6839ecb"), "795", "2368345721875143", null, null, new Guid("16dfe9db-9389-4852-8b69-53610d60b359"), "02/23" },
                    { new Guid("79ea76a1-a886-4899-8be5-7b02570d3d14"), "110", "2895309018420809", null, null, new Guid("b4e4db54-4f23-4365-96a9-cb8bd3cdaecf"), "07/21" },
                    { new Guid("79f0d5b9-0c0d-4bea-a594-cb02de9efa94"), "467", "6066952933202837", null, null, new Guid("451f756f-99dc-4563-9d9a-db92f4a114f0"), "03/18" },
                    { new Guid("79fadbdc-31c5-4e0b-b208-edc6e03f4630"), "511", "2837082641053160", null, null, new Guid("97c89012-688a-4d00-9708-03d8cb08dc2e"), "08/13" },
                    { new Guid("7a03ffc3-2cc0-4d9a-ab87-bd2f8af404a8"), "169", "2194881782905258", null, null, new Guid("4e8bea3b-5b3c-4c9c-b874-2c8b16d90db2"), "08/15" },
                    { new Guid("7a0c8f94-7210-45b0-a2bc-2fabe0d5160a"), "069", "5915044397407261", null, null, new Guid("aa1380ad-62cc-4108-817a-4ac56a2c382d"), "09/24" },
                    { new Guid("7a1662f6-992d-4127-be4f-b0b9a8f77a0a"), "297", "6123215191163639", null, null, new Guid("70c04dec-2a46-4304-b6d1-c42204afdab9"), "08/20" },
                    { new Guid("7a30deb3-7e3f-48a9-a0bc-3553a30249c4"), "311", "1198858882476919", null, null, new Guid("9dafc6e9-0e56-47f8-8b8b-4ca541841bd0"), "09/05" },
                    { new Guid("7a492e9a-bc45-4a8c-8f7b-f9fb5cd1a803"), "958", "7232727454518539", null, null, new Guid("9b0c9ef1-c568-4fc6-8e02-cbbb959e0bbb"), "07/12" },
                    { new Guid("7a8ad481-27c0-4293-a8d3-463984ca6a4f"), "497", "5302304460453012", null, null, new Guid("6a6686d3-6711-42f4-b08b-ada2bf39be54"), "05/10" },
                    { new Guid("7a8fb7c2-9030-47ef-907d-ab71bd91ec5a"), "651", "6387694519040727", null, null, new Guid("15cc8bf6-f5ac-435e-a654-84e10e29a1bd"), "03/07" },
                    { new Guid("7b90f323-dbe9-484d-915e-e759375aff61"), "098", "1167921504539389", null, null, new Guid("96389a1d-3bc8-465b-ba35-3027877a9981"), "09/21" },
                    { new Guid("7bf3e128-4021-4ee8-b8d8-26d4ad595aef"), "791", "4441939041766988", null, null, new Guid("73850497-d7e2-4015-bf80-d8fc761772d3"), "05/27" },
                    { new Guid("7c5d7aef-977a-491d-b2e8-c177c975ccdb"), "617", "9063294744500450", null, null, new Guid("6507f7f4-4076-4fff-b89e-4205b52b6408"), "09/10" },
                    { new Guid("7c7bd16c-cdee-4a97-b142-51da46918743"), "757", "5625685080964232", null, null, new Guid("7889ec96-3dce-40c9-a3d9-1dabf9642602"), "07/26" },
                    { new Guid("7cde950f-cfd9-4368-991f-85f7799e2874"), "033", "8892365971498753", null, null, new Guid("3705daaf-a245-497f-b245-acd05a008711"), "05/09" },
                    { new Guid("7cf9838e-6c3d-4312-8562-a50042648382"), "682", "6975150979924931", null, null, new Guid("9ffccffc-cb42-46e5-86d7-6730697facf3"), "08/16" },
                    { new Guid("7e99826b-81e4-4277-aacc-8c1dbe67c605"), "597", "2067143832928534", null, null, new Guid("02df2ae2-d7d0-47a4-aeae-e733e06bb1d0"), "06/06" },
                    { new Guid("7ead89b2-15ed-4e67-a226-fa1fa1211154"), "464", "9938078052745871", null, null, new Guid("ad53394d-1d27-416a-92bf-5074f6fa4fc4"), "11/25" },
                    { new Guid("7ec0db70-18d2-491c-947f-c5ba2fae4ed3"), "294", "4272670712550866", null, null, new Guid("4bfa50d6-7b76-402d-afe8-4b558ee6165b"), "01/03" },
                    { new Guid("7ed92a46-0d14-4443-a366-3933faedca66"), "675", "2209506490864147", null, null, new Guid("7f910a03-763a-4cdb-bbcb-8241bae6fc96"), "02/02" },
                    { new Guid("7f034cbd-e6c2-44e5-9b98-0afaecaabbf2"), "679", "3146444157242339", null, null, new Guid("8bbc87aa-2bdb-4898-83a2-ca540a697ac0"), "09/05" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("7f09b15d-5af1-462d-b0a3-566029842365"), "406", "2287124923000780", null, null, new Guid("70c04dec-2a46-4304-b6d1-c42204afdab9"), "04/10" },
                    { new Guid("7f3a79a7-db55-4bf1-928f-cf9a0430e6bc"), "353", "3049408027948786", null, null, new Guid("96389a1d-3bc8-465b-ba35-3027877a9981"), "12/15" },
                    { new Guid("7f6307c0-ebea-42bb-815a-5f8c5c293762"), "895", "6144766836149131", null, null, new Guid("b944ae23-efab-4fcb-bda0-6be21e2add96"), "06/22" },
                    { new Guid("7f644570-e91c-4372-99e4-bd23eb3b0e65"), "134", "5974127476362184", null, null, new Guid("be18d868-cfef-46af-89ea-769a3c24c7da"), "02/28" },
                    { new Guid("7fe000fa-7337-478f-b008-bb7776d4b0d5"), "741", "2961811504341249", null, null, new Guid("93ac31b1-6465-45d3-b0b5-98811dbc77b4"), "06/26" },
                    { new Guid("804ace69-2ef6-4ae6-befd-235bbd9e2c19"), "486", "8473478291994664", null, null, new Guid("9a799371-7ad4-44c8-bcc3-759981e1573a"), "01/15" },
                    { new Guid("804ba70a-ff80-46cf-911f-45b0811618c1"), "244", "6048897682782417", null, null, new Guid("708b56dd-a529-4229-82e2-2266f01c7942"), "12/14" },
                    { new Guid("808c627d-36c6-4ce9-8ffc-8e80dccb75e6"), "566", "6639497620786078", null, null, new Guid("7e5e5ebc-3d4d-451a-884b-00a9d9f53676"), "09/13" },
                    { new Guid("80a55135-335f-40d5-ba29-4af71a91dfd8"), "549", "2193740423971593", null, null, new Guid("96389a1d-3bc8-465b-ba35-3027877a9981"), "07/01" },
                    { new Guid("812c500f-b7dd-4537-8632-ac9bc935ea5a"), "765", "2935503114490363", null, null, new Guid("5a6031a7-d008-4d4c-9a87-857d42759454"), "03/06" },
                    { new Guid("81724312-9fdd-490a-8838-55fb12580ec5"), "787", "7988677018897242", null, null, new Guid("ac2d4745-386c-4c13-a217-d9e2d9b842df"), "06/16" },
                    { new Guid("8179c842-08ad-4d03-bc6a-fab03ebb6ce4"), "713", "7860948454625659", null, null, new Guid("8adfe810-a4af-41ad-bda0-c1898bdb4d92"), "07/05" },
                    { new Guid("81a6379b-f1ad-4a30-a701-20d7384bc042"), "055", "7381016221910375", null, null, new Guid("857e5ff4-368c-45c8-909c-9cb05ea33802"), "06/15" },
                    { new Guid("81aea9f7-e256-44a8-adbc-dae90cc37f67"), "548", "6146917802685974", null, null, new Guid("e28ae980-81b6-4d5f-8748-b7cb3f0f995d"), "06/01" },
                    { new Guid("825f75d8-163a-4eb9-80c9-48187f973bfb"), "836", "3893948093270030", null, null, new Guid("641c3d4a-a6ff-4cb3-b40a-665b9156a255"), "02/04" },
                    { new Guid("826129bc-1e5e-4661-9ec2-3b4a7b3d3264"), "157", "7819803972388872", null, null, new Guid("8adfe810-a4af-41ad-bda0-c1898bdb4d92"), "12/15" },
                    { new Guid("828e7ad0-db38-42db-9a7f-90debbcba47b"), "824", "8239392126108538", null, null, new Guid("11ddb06c-1f4a-4028-b37b-6ad05ae5f7d5"), "11/03" },
                    { new Guid("836ac2e7-c971-40f7-97fe-b47f936b8c9e"), "945", "5391028768028386", null, null, new Guid("2063153a-a610-4c40-9ddd-456ef0b560db"), "06/14" },
                    { new Guid("83f93b2a-32da-4d18-bb84-7358205cc523"), "377", "3928964629666694", null, null, new Guid("fc2635e7-fbe6-403c-bcdf-dc9a65be3352"), "08/09" },
                    { new Guid("843248b8-674f-4b54-a68b-35af44e77d2a"), "290", "8495409225290398", null, null, new Guid("c0ce8022-4a58-4c92-9e84-7f2ac0c9caa5"), "02/20" },
                    { new Guid("844e0742-6e42-444a-9b21-5d4f2872dfed"), "753", "7049691838643321", null, null, new Guid("4ccb797f-65b1-4b8c-809c-fe110c01052b"), "02/07" },
                    { new Guid("847dc7ef-6d1e-4e01-a347-f9c54bb8ad40"), "975", "6493209535294819", null, null, new Guid("5441f683-8cec-4fb5-96c6-2fa82e7997d3"), "06/21" },
                    { new Guid("849dbd78-078c-41ee-ad33-db57d55fd920"), "182", "2628271000646826", null, null, new Guid("0ffea79c-1eaa-4ef4-b27f-e6c525534682"), "07/28" },
                    { new Guid("84fda751-316b-4ef4-a85b-841d9c3f88ed"), "837", "8782228183209135", null, null, new Guid("ff75563e-5545-46de-a4b3-3e0727d74698"), "10/08" },
                    { new Guid("8502a940-ad33-4bb7-8222-db65ce4e29f2"), "080", "1761358401593078", null, null, new Guid("655cd6fe-206e-4683-a0e5-f0108ee7f59f"), "10/21" },
                    { new Guid("8584809d-8aef-4b44-b925-b42ce4dc8998"), "624", "2376501115379850", null, null, new Guid("69879006-dc0c-45ee-a1d8-571618a19f4d"), "11/23" },
                    { new Guid("85a63872-eb6a-4063-94b8-a8f06be38be6"), "605", "2761189962424161", null, null, new Guid("9a38b671-5580-4658-abf4-c1fc9ce2be0b"), "05/16" },
                    { new Guid("85e4a8d8-771c-4293-a841-f1fbd22dfc9a"), "446", "1508519932462606", null, null, new Guid("fc15fcf7-014b-4521-910c-8a4a05ae7df9"), "09/23" },
                    { new Guid("85ee6b65-e437-4a21-b4b9-2ff3bd88b52c"), "553", "8894854864201783", null, null, new Guid("857e5ff4-368c-45c8-909c-9cb05ea33802"), "10/01" },
                    { new Guid("867d8aca-640f-436e-acc1-fa68f4c15260"), "574", "1898978529862767", null, null, new Guid("655cd6fe-206e-4683-a0e5-f0108ee7f59f"), "11/26" },
                    { new Guid("8695995d-58b9-4588-b714-6034f9b35af0"), "552", "4940013548829993", null, null, new Guid("69536a6d-5fc0-40dc-96ff-96cfa2e2ddde"), "03/26" },
                    { new Guid("874f7951-e596-4026-bbab-1666aa655b58"), "417", "4312769920580817", null, null, new Guid("d08dab84-c369-4193-b4fb-bbd252c59cc5"), "08/25" },
                    { new Guid("87efdb15-5ddb-4c3f-a18c-362e7034d76d"), "952", "2642485805698405", null, null, new Guid("34d672c5-050e-4c3c-8018-0107a72f13f5"), "09/26" },
                    { new Guid("880ffd3e-9d15-45c3-9a69-2bb2e628ea97"), "366", "2063199526143255", null, null, new Guid("18314b53-d5e3-48fa-8ad6-dc84c3baa1ff"), "02/26" },
                    { new Guid("88209ba3-4b87-40d2-953b-d14221bbae9d"), "350", "2244267072085686", null, null, new Guid("551cb7a5-2acf-469f-be65-7a549dccf51f"), "07/10" },
                    { new Guid("88b7292a-0fa5-442f-8a91-dd4fb768567f"), "434", "2765175965026342", null, null, new Guid("a161bc80-bb44-439e-bb80-442569d93b23"), "06/27" },
                    { new Guid("88e7fcfb-aa49-41ad-b6f6-107e5dd5d512"), "689", "7367155302362812", null, null, new Guid("ca7879c0-456f-4a95-94ad-0a58b61bfc27"), "12/24" },
                    { new Guid("89413776-caea-4880-87a3-5b702ac451d3"), "775", "5632691838952778", null, null, new Guid("8e832b0b-a138-409b-b85d-4b68d03a07b6"), "06/01" },
                    { new Guid("8983d7d8-9b9d-43e2-9271-124f5f83192b"), "771", "8975643647733946", null, null, new Guid("5e2d266d-c2a4-4711-b57e-3656b61d6ad2"), "08/26" },
                    { new Guid("89c774ec-215b-46ec-8369-78854f41cdcd"), "876", "7824684540777531", null, null, new Guid("fc7807f7-2e15-4c19-8500-ea40f337d9de"), "08/01" },
                    { new Guid("8a141adb-cf84-4953-8baa-c45903f89f9d"), "917", "1724531002040522", null, null, new Guid("872eccf4-a3fa-43c5-ab2e-ac6f6c9e4f17"), "01/14" },
                    { new Guid("8a3c0976-fca7-4b37-a08a-f02a75941eb8"), "531", "2950007051830349", null, null, new Guid("34d672c5-050e-4c3c-8018-0107a72f13f5"), "04/02" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("8afaaa1f-9827-4df8-9ad5-eb0f7ef5f0c1"), "477", "5370576635353990", null, null, new Guid("d184b2bf-159f-4b4e-83e0-4f0bb6184d14"), "09/22" },
                    { new Guid("8b6985f6-7176-4d09-bf99-a967efaac4b8"), "589", "1956781980945796", null, null, new Guid("9b0c9ef1-c568-4fc6-8e02-cbbb959e0bbb"), "02/15" },
                    { new Guid("8b98d847-13c7-4480-b4ce-f4602767b8dd"), "374", "8266333889934266", null, null, new Guid("708b56dd-a529-4229-82e2-2266f01c7942"), "06/22" },
                    { new Guid("8be96347-2d12-4243-8b83-4ecdd519f8e8"), "336", "3788158909380582", null, null, new Guid("655cd6fe-206e-4683-a0e5-f0108ee7f59f"), "09/19" },
                    { new Guid("8c0f0497-4dcd-4f87-9363-8667142b6ad1"), "733", "7415477955623460", null, null, new Guid("7e5e5ebc-3d4d-451a-884b-00a9d9f53676"), "12/24" },
                    { new Guid("8ced1ca5-6257-4371-b825-158b697c99cb"), "299", "1322237014178562", null, null, new Guid("857e5ff4-368c-45c8-909c-9cb05ea33802"), "09/08" },
                    { new Guid("8cfbce79-fd66-4081-bd0d-aa0011b78d96"), "866", "7525851225762286", null, null, new Guid("e2dba597-b132-4b1a-a46f-540ebc581408"), "03/19" },
                    { new Guid("8d05177e-3855-42a8-a832-2b68c5f56609"), "031", "5068362994114063", null, null, new Guid("f7f7b1e1-146a-4f33-9556-99419aa87dbb"), "05/21" },
                    { new Guid("8d66e3ab-2d7b-4f9a-b940-a460be8988ea"), "540", "6585586982860790", null, null, new Guid("1546f9ad-e76e-4438-9513-2c0cdbcdc9dc"), "03/25" },
                    { new Guid("8d99c517-0160-4514-85d2-1fce62a614b8"), "075", "5621642552371466", null, null, new Guid("3ca63884-385c-4ae8-ac07-f3dc2df24aae"), "11/07" },
                    { new Guid("8dc8ab39-204c-4287-9bd3-e340e9a03b45"), "735", "8632773974980930", null, null, new Guid("966d5ef1-e601-407d-86be-887c8e79a449"), "10/25" },
                    { new Guid("8dd4b933-8bcd-4b0f-b5cb-5b4c0a54a419"), "865", "1841442963093602", null, null, new Guid("e1223f43-016e-41f5-b212-ab70a0ac01e2"), "07/02" },
                    { new Guid("8df41f03-c4e9-4af4-a1a0-26754ce5073f"), "803", "2858239098207117", null, null, new Guid("63bd6aad-fd4d-4a2d-b0ee-341253297e79"), "03/11" },
                    { new Guid("8dfca443-4019-43f2-b2ef-e4634dc2a1c6"), "568", "4836662879752810", null, null, new Guid("eddb3b35-4415-4828-97b3-fd737f127090"), "03/13" },
                    { new Guid("8e194d81-c0e5-4e1d-b6d4-9e2a7a202571"), "407", "4724126748478989", null, null, new Guid("69536a6d-5fc0-40dc-96ff-96cfa2e2ddde"), "02/22" },
                    { new Guid("8f1b3d3d-969e-4402-823b-eff462b99d72"), "212", "5960120472259700", null, null, new Guid("551cb7a5-2acf-469f-be65-7a549dccf51f"), "08/02" },
                    { new Guid("8f5c36a9-ab08-4bf4-879c-526fe4da4c1e"), "096", "9051130818368807", null, null, new Guid("98222b1e-1352-4ac9-8c47-69a7f0582ef6"), "04/18" },
                    { new Guid("901f30dc-1d9b-4471-8985-c347d9581e9d"), "814", "2336999642848082", null, null, new Guid("4952ad1a-3fe2-4d0a-a38e-1e28e3808afd"), "09/18" },
                    { new Guid("903b7f0a-a87d-49be-810a-b6276686cc91"), "409", "3324912715326318", null, null, new Guid("b44b2dc0-6e21-4d7d-a788-6c4e66d96402"), "08/23" },
                    { new Guid("90680f9d-ca10-46b7-9443-958f14b3cfe5"), "508", "2548020688401469", null, null, new Guid("222dda98-6fd2-4619-8709-1b78c7872ca8"), "08/04" },
                    { new Guid("90778f21-3243-40a9-a976-45a465a31a95"), "711", "5015627522648336", null, null, new Guid("4883913c-7591-4093-a019-7e3dd870d152"), "09/02" },
                    { new Guid("91140064-08bc-41ba-954e-8e9c78f5967e"), "194", "6220633763740509", null, null, new Guid("a8a8fdd8-4ded-4cee-9b8c-87f2285d7eab"), "08/01" },
                    { new Guid("911ae1ae-6f89-438f-873a-225cba3029f8"), "386", "2449543615475267", null, null, new Guid("2a328a80-898f-4b62-921d-731137bebe9f"), "12/03" },
                    { new Guid("913e0bdb-f51c-45bc-a7ba-7001e6696f13"), "102", "6150046977824506", null, null, new Guid("d4409d83-a792-488f-bea4-9e1b42950fc9"), "05/18" },
                    { new Guid("916161eb-c934-4025-bfdc-6ed0e6bd5803"), "957", "6851960016615018", null, null, new Guid("6cbb9172-2b78-4f00-a841-8a1e6d6be79b"), "02/16" },
                    { new Guid("91ef66c9-38c8-47e9-bbfc-35ccffa6d18d"), "512", "8136195804929698", null, null, new Guid("c431ef46-de70-4dba-a2b4-061b2a219ebc"), "06/03" },
                    { new Guid("925f62b9-cd2b-4e2f-a46d-74c00d7982c3"), "817", "7388265638716374", null, null, new Guid("861c20c6-b2fe-4d03-a2b4-ae2380f7edc5"), "04/18" },
                    { new Guid("92633500-dcb3-4857-b836-15f610a41933"), "238", "1339955474905271", null, null, new Guid("e807eb16-5caf-4274-9ff7-5027ed83325c"), "06/07" },
                    { new Guid("9287b3c8-20bd-4ef4-bf2c-af5ed7a05d95"), "430", "6482435823157595", null, null, new Guid("63bd6aad-fd4d-4a2d-b0ee-341253297e79"), "06/20" },
                    { new Guid("9290579f-4ccc-445a-928c-d4b1de5d3d61"), "973", "8105059112925727", null, null, new Guid("a3564d73-cc7f-45bf-bb8d-5bff9f9bd319"), "03/25" },
                    { new Guid("932515c9-040c-4cc8-9a25-090ae27490ee"), "873", "5810775435466539", null, null, new Guid("7771e104-7d9f-4097-8375-a33ad264e1d8"), "12/11" },
                    { new Guid("934fd0a9-3ba2-4666-a7a0-3b3c2bf7ab10"), "255", "2787197450803707", null, null, new Guid("a7a63c10-9b55-47c6-9d56-8793ee29aafd"), "08/23" },
                    { new Guid("9486d7de-d420-4677-8aac-ed23e618d56f"), "539", "7042206251555598", null, null, new Guid("437bc41c-af0d-4443-809f-276b155b8846"), "06/05" },
                    { new Guid("9493309a-d810-4cb6-9047-7e496295335d"), "474", "3739359796198268", null, null, new Guid("91024531-3bc9-4397-868c-67a81b4abcfc"), "06/12" },
                    { new Guid("95faea50-3711-4828-83f1-efe54149397e"), "296", "4276933549038320", null, null, new Guid("c8db4c48-87fc-43bc-b9ef-e88e6764800d"), "01/28" },
                    { new Guid("9698f5f6-ac3c-4196-b8ea-7259d0e93962"), "530", "7939771046952394", null, null, new Guid("d8dd96ce-4557-4993-959c-45a29c967d51"), "12/10" },
                    { new Guid("974acae5-4e24-4e81-8c1c-08b996dcae5e"), "957", "8981597696512533", null, null, new Guid("93b22657-e430-4b16-b1f2-af9b44bd9175"), "01/09" },
                    { new Guid("975ab83e-9b64-4289-bdc7-f24ac175dc45"), "465", "1672237824139643", null, null, new Guid("aa053e12-232a-4d5d-8b1f-0803fd8b7767"), "01/24" },
                    { new Guid("97a9fe6c-58d2-4903-96d5-431f1ed521a0"), "059", "3939271407634914", null, null, new Guid("a4b4b14f-6b7f-4104-b0d2-b8f55417f1e7"), "02/08" },
                    { new Guid("97e770e4-daa3-4e3d-865b-bcfa22072b53"), "470", "3854753696604223", null, null, new Guid("7b354f95-20a6-4d69-abe1-b5a212feb069"), "05/02" },
                    { new Guid("98023cb4-3ed1-4bd0-8f0d-c93e02cdc438"), "940", "3987152258687368", null, null, new Guid("77332645-fb25-478f-998c-36dd38aaba91"), "12/13" },
                    { new Guid("990b7b16-9921-4076-871e-c889cbbe8a06"), "432", "3106121901761161", null, null, new Guid("9e73d492-68df-4c26-bbd7-c238340416ec"), "05/06" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("992bf2f1-6028-4945-a068-f88c2dc5ccd4"), "265", "2309736990685653", null, null, new Guid("57041776-9144-494f-9e92-9c9da3135eab"), "12/28" },
                    { new Guid("995a6c2f-6650-4dbc-9ee8-f2e55f8dd31f"), "852", "4461173161755835", null, null, new Guid("9a799371-7ad4-44c8-bcc3-759981e1573a"), "06/02" },
                    { new Guid("9a2884b2-094a-4698-980a-6b84ee7faf4a"), "704", "2975071713638603", null, null, new Guid("86139076-e779-453a-8f87-64e1bfeeeccc"), "01/03" },
                    { new Guid("9a28cca9-7558-440f-b48e-ccf83af3794f"), "316", "6233106251303381", null, null, new Guid("5a13878d-22a4-47a3-8eb8-3f4be375baee"), "06/10" },
                    { new Guid("9a2b83e2-974c-4f48-9140-b8e0b7c94a00"), "945", "6837696023553186", null, null, new Guid("8bbc87aa-2bdb-4898-83a2-ca540a697ac0"), "03/04" },
                    { new Guid("9a530c50-1f5f-40ea-9414-cf73662ca07b"), "591", "9936101456681801", null, null, new Guid("25a47446-d397-4805-8427-d3185a6d35b7"), "02/09" },
                    { new Guid("9a5569df-003a-437b-ba94-4fde9a326386"), "985", "1342318867990515", null, null, new Guid("6172d849-4ee5-486f-8f97-d2bbcfc40084"), "08/12" },
                    { new Guid("9aabe458-ad15-449a-af49-2966c1882513"), "278", "9049388459345441", null, null, new Guid("c1dedd78-34a2-4542-a585-a6ba740f5856"), "03/12" },
                    { new Guid("9af2d9fd-c329-49ab-a3c8-eae51f9f0f98"), "713", "3333240985366468", null, null, new Guid("568a5cfd-171b-413d-addf-fe6ab58aa6d0"), "01/06" },
                    { new Guid("9b69b37e-ab85-4e39-b303-372a784d61e4"), "431", "2696741458162546", null, null, new Guid("5d6854b6-463d-4c99-844f-2b03c65e196b"), "02/28" },
                    { new Guid("9b8e50a9-0613-4430-8da5-c01d558f12d7"), "535", "8775754669268924", null, null, new Guid("62f9c608-cb23-46fa-a1c4-304e5c65aec1"), "08/19" },
                    { new Guid("9b997ccc-80cb-41a0-8198-3e522df87f40"), "769", "9117559299391590", null, null, new Guid("960fe293-a56c-42c1-b68b-57d1e361fe6d"), "05/02" },
                    { new Guid("9c1faee2-e557-4f79-a1e4-96c92da8fab6"), "455", "5668806679776232", null, null, new Guid("5effd297-ddf3-4f40-afed-c85e49e3d248"), "12/06" },
                    { new Guid("9c7e5aca-ddeb-4b19-a81e-1d4663efe5d4"), "090", "1203811081979350", null, null, new Guid("da687a7e-bca5-449f-ad43-32e0ac00fe15"), "11/13" },
                    { new Guid("9d792c34-4eea-419d-a4ba-f72db474bcd2"), "184", "2680511974269483", null, null, new Guid("ef14d144-d1c3-49fb-9e25-1889be79f4e3"), "04/26" },
                    { new Guid("9d89ff61-7e85-48dd-a8ed-ffc8900aed59"), "703", "7282655635662116", null, null, new Guid("52010289-102f-414b-8fb6-a09a575f22a0"), "02/12" },
                    { new Guid("9df92da3-d48b-409c-9309-77c403ba519d"), "339", "6490290722143272", null, null, new Guid("9a799371-7ad4-44c8-bcc3-759981e1573a"), "08/06" },
                    { new Guid("9e076e39-9710-4b99-a91f-4bdeeb5e2f3f"), "740", "7186191852620165", null, null, new Guid("716e3b4a-4381-424f-88d2-df0753a8cb13"), "02/03" },
                    { new Guid("9e8378d0-1036-450c-a8c1-21830f122ec6"), "017", "5269804871041206", null, null, new Guid("01a8f276-3a4c-402e-98b4-c3b9dba05f91"), "07/28" },
                    { new Guid("9e9b6581-1267-4e6d-b260-9d5e06874022"), "606", "7744431037399454", null, null, new Guid("641c3d4a-a6ff-4cb3-b40a-665b9156a255"), "12/27" },
                    { new Guid("9ebcc173-0c4d-4438-a68e-30ca978a5953"), "036", "2471222613702267", null, null, new Guid("8513debb-cacb-47df-a4d3-e59f2a261b69"), "11/26" },
                    { new Guid("9f140406-efd7-4d4e-8f31-099c145acc39"), "352", "6681951243284008", null, null, new Guid("6172d849-4ee5-486f-8f97-d2bbcfc40084"), "10/08" },
                    { new Guid("9f1b30fd-e906-4751-9dbe-b7ad1d2f75c3"), "120", "4649474548684618", null, null, new Guid("e1223f43-016e-41f5-b212-ab70a0ac01e2"), "12/02" },
                    { new Guid("a02c565f-af01-4bcd-9137-aa119e9ad61d"), "355", "8466676487649366", null, null, new Guid("a3564d73-cc7f-45bf-bb8d-5bff9f9bd319"), "10/10" },
                    { new Guid("a03c90dc-563f-45ce-9585-1da664d21a61"), "745", "2024769100283534", null, null, new Guid("5ffbbdb6-b588-4eef-811a-4b39d217f0a8"), "12/17" },
                    { new Guid("a097dce9-aea9-4826-94a9-ff2d885c8a39"), "798", "1394930951835780", null, null, new Guid("68fd726f-e5e4-4755-a477-4727a0a9f4b8"), "07/10" },
                    { new Guid("a09b0c5d-660b-4c36-9d3b-c1788eeca457"), "334", "3994459542793273", null, null, new Guid("d9fc54cb-e30e-4a48-b749-08ff99fcff26"), "07/17" },
                    { new Guid("a0dbb6cb-e45d-45e5-b0f6-74c643d6ecd9"), "636", "7822891269866277", null, null, new Guid("58fc780f-3b29-4947-a319-3ed8b421144e"), "04/03" },
                    { new Guid("a0f12c13-0918-4ecd-b296-a32f135e14a3"), "927", "6335729737547715", null, null, new Guid("17441686-0fa5-4e5d-b680-2d5708a2ecd5"), "02/14" },
                    { new Guid("a10255b5-f17e-48a0-9120-ded57bad9dab"), "752", "3087863657663913", null, null, new Guid("fc7807f7-2e15-4c19-8500-ea40f337d9de"), "12/21" },
                    { new Guid("a1ae1bbb-24e3-4cc7-a968-aca155d2d218"), "683", "1884247969825241", null, null, new Guid("dffee49d-d296-4315-aefd-9602dd01358c"), "08/03" },
                    { new Guid("a1dbfd50-49f6-4eca-a3ee-25a4122bdeef"), "701", "2418744608779865", null, null, new Guid("d0627291-bbf2-408e-bc02-9ba09faa06bd"), "05/05" },
                    { new Guid("a218be60-7f4b-4abe-ab36-798a31d4bfcb"), "400", "6856104848046310", null, null, new Guid("eedd859d-8af5-43b7-8938-5bce7dd89153"), "06/04" },
                    { new Guid("a2780143-a38e-4b81-8d59-f73da1597ea1"), "615", "6138660669592792", null, null, new Guid("6ee9a7d3-8695-4b4a-9a7f-e035a03a4cc3"), "08/11" },
                    { new Guid("a278a7a7-0e60-4378-b482-6df123f5d225"), "783", "4546995516825077", null, null, new Guid("6375150d-9633-494e-ba79-b55f87d56afa"), "07/26" },
                    { new Guid("a2a2cec5-d594-4953-8235-63bbd8d48ef2"), "016", "5821433094469573", null, null, new Guid("2a328a80-898f-4b62-921d-731137bebe9f"), "06/01" },
                    { new Guid("a2ecc6ec-0a9e-4b59-9e0f-b0deb33e7a4a"), "319", "2906179510497599", null, null, new Guid("1747bd38-8325-47e2-8876-f2ff552a55c8"), "06/20" },
                    { new Guid("a310c87d-272a-4621-b5b7-b2d4570f1f46"), "140", "7487361616239884", null, null, new Guid("d1fdc728-523b-49bf-b2d8-eee9a8bb93d1"), "10/21" },
                    { new Guid("a326c11a-6ccf-4184-a4cb-bab5a9c78bf3"), "458", "9207260368670129", null, null, new Guid("26ad372f-ab3d-49d6-a283-d78f71a0b97b"), "03/25" },
                    { new Guid("a3634c57-da7e-43dd-bb50-c0a37c358b78"), "376", "9376467291828373", null, null, new Guid("2a9b395f-43a6-4c12-8ee4-3f4db5f26f9d"), "07/27" },
                    { new Guid("a3808df8-e1c4-4072-9855-dc132e3683d0"), "307", "5257251811991605", null, null, new Guid("dc04df94-1448-4899-bec4-692b13ea2748"), "10/16" },
                    { new Guid("a38b3ed0-e308-442e-859f-c6ae3e8b7cc2"), "360", "7355141212806504", null, null, new Guid("1c5135c6-32f4-4363-a0a3-5a8fb7357df1"), "06/20" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("a412deb9-7184-4fb1-bf12-fb2897346ccf"), "047", "8961558852997452", null, null, new Guid("c4c17769-48f5-471b-ac8e-87a2c17573b4"), "11/26" },
                    { new Guid("a44bb089-5903-4e9a-ba31-35ce0fc93a26"), "294", "1059189168336057", null, null, new Guid("fc15fcf7-014b-4521-910c-8a4a05ae7df9"), "03/02" },
                    { new Guid("a472587b-a388-41ee-9298-c65807c0b9d3"), "420", "8543869537580899", null, null, new Guid("6b62d633-8ccd-4aa4-82e7-a8336a9e5760"), "07/11" },
                    { new Guid("a495cbbc-5217-4415-b65c-f509348275ae"), "193", "6507688746293401", null, null, new Guid("69879006-dc0c-45ee-a1d8-571618a19f4d"), "12/05" },
                    { new Guid("a4a3c71a-febf-438c-a9f0-6ee53319e1b1"), "814", "3254425258841016", null, null, new Guid("4d65579c-7caa-4a73-aec4-ebf5de2054ab"), "07/01" },
                    { new Guid("a4db58dc-9833-4a40-bfb6-9221e16d5f27"), "394", "8222114283773425", null, null, new Guid("26ad372f-ab3d-49d6-a283-d78f71a0b97b"), "12/16" },
                    { new Guid("a55bf16e-3b7e-4dfd-87b4-ccb3a778250f"), "138", "5446773378070324", null, null, new Guid("52c54e9c-3d8e-429f-ae95-d180e2ec5a1d"), "02/16" },
                    { new Guid("a576cc45-33fd-45c3-bea8-b94cc2835180"), "402", "4189669392832643", null, null, new Guid("aa1380ad-62cc-4108-817a-4ac56a2c382d"), "10/03" },
                    { new Guid("a59c8151-cbd5-4839-bd41-573a39710a1b"), "968", "5333808566690383", null, null, new Guid("749d009d-0557-4289-976a-50a7e345a281"), "09/09" },
                    { new Guid("a60238e3-71ca-4099-8d47-ac2896587ed4"), "316", "3642233463116605", null, null, new Guid("68fd726f-e5e4-4755-a477-4727a0a9f4b8"), "02/05" },
                    { new Guid("a64ffe99-1934-44f7-8a56-a771f72841df"), "751", "5296425269682875", null, null, new Guid("d08dab84-c369-4193-b4fb-bbd252c59cc5"), "11/01" },
                    { new Guid("a65d878c-1639-4bcb-830e-df7113948d37"), "013", "3110450917078169", null, null, new Guid("605efc2a-1846-428c-a520-3c8efbd1c5d8"), "01/01" },
                    { new Guid("a79bc081-63e7-4815-8e03-8a91df654246"), "592", "4709963713767908", null, null, new Guid("f4d9bb48-d87b-420c-b2ef-f724726c7a08"), "09/07" },
                    { new Guid("a7b4e1f6-143c-4b55-a129-e128919b4ecd"), "863", "7935556930336587", null, null, new Guid("641c3d4a-a6ff-4cb3-b40a-665b9156a255"), "09/19" },
                    { new Guid("a829e507-8c50-4586-934d-111bccd6c7d8"), "360", "5784777515912861", null, null, new Guid("8892b0e2-0aef-404c-8681-2866126b786f"), "03/14" },
                    { new Guid("a832dfa0-7dd8-4f3a-99c5-2c7d0ba4fc88"), "166", "2867830199940226", null, null, new Guid("78615ad6-0a03-477e-a515-c98b1a96475d"), "04/20" },
                    { new Guid("a86237e1-444b-4bd3-b89e-ed06f5069e4f"), "592", "9641150834675034", null, null, new Guid("872eccf4-a3fa-43c5-ab2e-ac6f6c9e4f17"), "09/20" },
                    { new Guid("a88588ff-ecd2-4e96-89bb-c7f96d080632"), "173", "6727527836581337", null, null, new Guid("c561cc5e-190d-4a91-8ea9-d03583fa3f86"), "07/01" },
                    { new Guid("a8a57a32-8b62-404c-99b4-670d7afddb94"), "670", "4275991991429155", null, null, new Guid("52c54e9c-3d8e-429f-ae95-d180e2ec5a1d"), "04/06" },
                    { new Guid("a8f46e10-5a13-47e3-b61b-fa1cb6155cfd"), "597", "5484936405374285", null, null, new Guid("dfa0bf0e-13dc-416f-bb54-aaeb47a68545"), "11/02" },
                    { new Guid("a8f8268e-d281-41f9-9583-72b1946fa108"), "555", "8313961749641017", null, null, new Guid("9dafc6e9-0e56-47f8-8b8b-4ca541841bd0"), "02/22" },
                    { new Guid("a94cf2f5-f253-4e98-8ed1-d728bbdcd0dd"), "893", "2373466298226944", null, null, new Guid("3dd4bd2a-4dd8-4988-867a-99041eb6851d"), "09/12" },
                    { new Guid("a9c96722-69ed-4756-96fd-603cb7ce2296"), "478", "1154759875811125", null, null, new Guid("dffee49d-d296-4315-aefd-9602dd01358c"), "04/07" },
                    { new Guid("a9cff63c-8e38-4715-8d84-1da8df0cfe5c"), "397", "6373244166231388", null, null, new Guid("4bb403d4-8670-466f-a9dc-17dd09c9d546"), "06/02" },
                    { new Guid("aa5ae9c2-112e-4fac-b935-e41b713a4802"), "231", "1687701687181478", null, null, new Guid("fd6ebc44-c70c-4ea5-ad8a-6029ee9c49d9"), "05/24" },
                    { new Guid("aa90b125-81f8-4634-8ead-9bac787487ec"), "920", "2839197713208657", null, null, new Guid("37432efe-ddf1-4f3f-9753-a8b4a9e54500"), "12/01" },
                    { new Guid("aad8aae6-e5f9-4732-80b2-7d2ae9d5e085"), "935", "7886511309909184", null, null, new Guid("cd3bba51-ecbd-472a-a962-7f603574b446"), "01/04" },
                    { new Guid("aaea376f-3c34-42ac-a591-63035ddbf733"), "485", "2256144447591432", null, null, new Guid("ef100efa-deb4-4516-9a15-38df8ff7e396"), "09/14" },
                    { new Guid("ab16c6b9-20a7-4a21-809e-2cf8e3ac3bbc"), "589", "1872921935638831", null, null, new Guid("db79e848-cfae-4c0f-8859-e5d6af4a311c"), "01/15" },
                    { new Guid("ac185710-6107-4076-a9dc-42eaa9582dab"), "020", "5387940317286574", null, null, new Guid("73850497-d7e2-4015-bf80-d8fc761772d3"), "04/20" },
                    { new Guid("ac57f5a2-01e3-4a23-8759-811a8c69c845"), "862", "3649063846304728", null, null, new Guid("78615ad6-0a03-477e-a515-c98b1a96475d"), "08/03" },
                    { new Guid("ac9f36a8-5f48-4bc1-9bcc-f2dc0a708c34"), "939", "5951120473646167", null, null, new Guid("9eb02965-fa79-4bc7-940e-eff714a39f7e"), "12/28" },
                    { new Guid("acfa3893-35db-4795-8af1-113a48bafde0"), "037", "5733873425168330", null, null, new Guid("ef14d144-d1c3-49fb-9e25-1889be79f4e3"), "04/28" },
                    { new Guid("ad893352-fa79-40b6-9db4-071668c2ecb4"), "388", "2990379939322388", null, null, new Guid("9b8fcbcf-ce9d-40cf-aa2a-0543ebe6f135"), "06/09" },
                    { new Guid("adbd4c90-97c9-4d3a-a3df-d3681a932660"), "354", "3867054743741952", null, null, new Guid("ca7879c0-456f-4a95-94ad-0a58b61bfc27"), "09/18" },
                    { new Guid("adbe53db-d5fd-47f1-9c90-505956ef0e2d"), "411", "9532328245063567", null, null, new Guid("17441686-0fa5-4e5d-b680-2d5708a2ecd5"), "04/27" },
                    { new Guid("ae0b97fa-ec5f-4ce0-94be-98e212ab1f7e"), "430", "9227131342151695", null, null, new Guid("655cd6fe-206e-4683-a0e5-f0108ee7f59f"), "11/01" },
                    { new Guid("ae91a2f9-181a-42a3-8650-79e7a4b2f155"), "038", "6053332228585128", null, null, new Guid("dd2a73f4-0d43-45df-8aa0-196122e00fc2"), "02/28" },
                    { new Guid("aea15835-28b1-440e-9b79-04745f1a1faa"), "269", "5653382422147092", null, null, new Guid("dc04df94-1448-4899-bec4-692b13ea2748"), "03/22" },
                    { new Guid("aefedb62-e80c-47f9-8e22-84c9894f6df8"), "771", "5458126467461727", null, null, new Guid("137b1e19-3c26-4708-9428-159387ebcd43"), "11/28" },
                    { new Guid("afba2af8-6b08-45af-a296-9a652d47c347"), "961", "8332959548872460", null, null, new Guid("6db49be1-1b9b-4fd0-8b2d-52ae151f7432"), "09/02" },
                    { new Guid("b166cfe3-56fa-4c3b-83af-c421b705bb49"), "637", "6322334884950069", null, null, new Guid("f7f7b1e1-146a-4f33-9556-99419aa87dbb"), "05/09" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("b1a0041e-007a-4b68-bd68-b4c5c44f9339"), "053", "4367394708770382", null, null, new Guid("a161bc80-bb44-439e-bb80-442569d93b23"), "07/14" },
                    { new Guid("b2545e23-25b1-48fa-adc6-0bd0ffe602f8"), "869", "2892452672555975", null, null, new Guid("93ac31b1-6465-45d3-b0b5-98811dbc77b4"), "03/17" },
                    { new Guid("b2935c47-9dc1-4746-86f9-c069de57b985"), "737", "7855253775876180", null, null, new Guid("78615ad6-0a03-477e-a515-c98b1a96475d"), "04/23" },
                    { new Guid("b2eec20e-e78e-4bd8-b9ca-209903ac7abf"), "599", "5009518743852516", null, null, new Guid("17b956d2-133d-4289-8a76-4633e194bce0"), "10/27" },
                    { new Guid("b32b07ca-6cd9-4a70-a3e5-1fbcd57ba63b"), "577", "4513018337504972", null, null, new Guid("cefdf373-98f4-432b-bfc7-baaf121c554a"), "01/17" },
                    { new Guid("b380cd04-5596-4a19-8c5c-871dd59666ba"), "599", "8000664884919283", null, null, new Guid("dc04df94-1448-4899-bec4-692b13ea2748"), "06/17" },
                    { new Guid("b3985d1a-0038-4985-87f7-8bb86981a12d"), "225", "7353529431586937", null, null, new Guid("24b96e86-5860-47b1-a6ec-9a832bafbb14"), "05/10" },
                    { new Guid("b3e19e53-267b-4dc6-b4cb-fa7238fd0ef0"), "600", "4092426838365106", null, null, new Guid("222dda98-6fd2-4619-8709-1b78c7872ca8"), "04/18" },
                    { new Guid("b4da2a29-57c6-4729-8cb5-b895ac72043b"), "310", "5980986666932135", null, null, new Guid("a6b4e3da-0d2b-4dbd-9f10-ea183f9d6225"), "10/11" },
                    { new Guid("b4e25bda-5599-499c-ba29-52c938b42f89"), "283", "3771968369262019", null, null, new Guid("6db49be1-1b9b-4fd0-8b2d-52ae151f7432"), "07/21" },
                    { new Guid("b57ab8d3-23c2-4791-a752-f6970bcea8c0"), "349", "4845307687869739", null, null, new Guid("11ddb06c-1f4a-4028-b37b-6ad05ae5f7d5"), "03/15" },
                    { new Guid("b5891bc3-0f73-4122-a6d6-4f0f04fd5cae"), "185", "4983227073460135", null, null, new Guid("7805e438-4982-4f20-9e68-baca0c631417"), "04/28" },
                    { new Guid("b5e22523-a75e-4165-a2d0-feae97776752"), "307", "3356782918056705", null, null, new Guid("9f331cb7-b70d-434b-bc28-147a5e624fd8"), "03/07" },
                    { new Guid("b60db631-c4a3-4375-bfa5-86c3aece30f9"), "840", "4301088095115356", null, null, new Guid("b9974b20-5b3f-4445-a6d7-c4352b53a64c"), "03/24" },
                    { new Guid("b6569054-37c2-48c6-8e08-eeac0ade2589"), "030", "3884529603945199", null, null, new Guid("4d792f39-989a-48bc-8528-2bda17a5967a"), "11/27" },
                    { new Guid("b70b38de-03cf-41b3-9c2f-b1b32a1f6477"), "811", "7394128431706884", null, null, new Guid("3dd4bd2a-4dd8-4988-867a-99041eb6851d"), "02/08" },
                    { new Guid("b7336a36-db2b-4d63-81b5-d14f6d8cefb3"), "311", "6359109108487988", null, null, new Guid("96357562-82d6-4394-b4bf-5b698e1ad612"), "06/07" },
                    { new Guid("b79b7b1b-5680-4ff6-a2d9-dc94336d398b"), "902", "5590207471609628", null, null, new Guid("3dd4bd2a-4dd8-4988-867a-99041eb6851d"), "08/03" },
                    { new Guid("b7bc4be1-3d37-455d-9600-b04e18106f9a"), "451", "4231663918166647", null, null, new Guid("d9295c19-5c11-40bb-ba7c-c1b368114ac0"), "01/26" },
                    { new Guid("b7c442a2-9859-4992-8fe7-8925ab454356"), "506", "1595692183342928", null, null, new Guid("dee746db-2712-4366-98c6-517b826fd421"), "10/19" },
                    { new Guid("b7cd78c0-a1ed-48fd-9807-8336b3a6a473"), "427", "8911865631754614", null, null, new Guid("d8361619-ae4f-4db1-9eb9-291e4814a381"), "02/16" },
                    { new Guid("b7fd3ec7-b9bb-4beb-992f-35c796a34fb0"), "953", "1564528921790054", null, null, new Guid("d0627291-bbf2-408e-bc02-9ba09faa06bd"), "09/07" },
                    { new Guid("b8c87a95-48a3-4776-b4fc-69f423121b3c"), "585", "5760581399949098", null, null, new Guid("73977b0d-a6cb-4576-bd4a-b7056acdccd3"), "11/10" },
                    { new Guid("b927a666-4a2f-4ec4-bccf-41fbaa236a78"), "946", "6568090833902577", null, null, new Guid("abf3ceb3-3421-4454-9686-7b4c13cd1fbf"), "01/18" },
                    { new Guid("b9ab6475-5db4-493d-bc60-c5f35aed296a"), "111", "5170644732182062", null, null, new Guid("97d70a43-949c-4c03-9da7-fc16fdc0c86d"), "11/17" },
                    { new Guid("b9b77005-e8b8-4d4c-a8a2-4f2734a1ea96"), "342", "7904602926750254", null, null, new Guid("4bfa50d6-7b76-402d-afe8-4b558ee6165b"), "05/17" },
                    { new Guid("ba3aa55d-72c4-4c0f-b762-30c38c6fc7d8"), "171", "1181263833320404", null, null, new Guid("1747bd38-8325-47e2-8876-f2ff552a55c8"), "08/25" },
                    { new Guid("ba65f7c6-cf21-4a1f-98ee-f09b49d15b10"), "962", "4725197637104254", null, null, new Guid("57d5c043-44a4-43bb-80ee-1cbb791b2285"), "05/20" },
                    { new Guid("ba8f08f8-ee3b-4ec8-9852-af4cacf632c3"), "317", "1468762773134162", null, null, new Guid("222dda98-6fd2-4619-8709-1b78c7872ca8"), "12/01" },
                    { new Guid("bb3c3bee-d1fa-402b-aba5-18d44ab0907a"), "276", "3681071191289277", null, null, new Guid("cc549d3d-c127-48fe-9320-69c0367cf0ef"), "10/06" },
                    { new Guid("bb4a7cd9-8db4-499d-b151-8c94dbd21fab"), "595", "7182195492102968", null, null, new Guid("cb9544f8-58da-451a-a24e-9ef9b8265d20"), "05/25" },
                    { new Guid("bba2b4c2-3246-41f2-b22b-d47d7b94a39d"), "754", "6588615913442475", null, null, new Guid("7771e104-7d9f-4097-8375-a33ad264e1d8"), "09/04" },
                    { new Guid("bbc2847c-9b83-4ca9-b0fa-f2dab1a9baa5"), "929", "1628873715985332", null, null, new Guid("ffdf2e3d-14e1-47fc-a87f-43ee44597c72"), "04/24" },
                    { new Guid("bbdd6f75-d534-4b9a-8c39-ac6f0128d107"), "984", "1717320359774507", null, null, new Guid("6b62d633-8ccd-4aa4-82e7-a8336a9e5760"), "11/22" },
                    { new Guid("bc00d920-2c6d-41eb-82a4-63739d34190a"), "737", "4623529867355289", null, null, new Guid("a7a63c10-9b55-47c6-9d56-8793ee29aafd"), "07/02" },
                    { new Guid("bc786aeb-ce5a-4f87-a1bb-3bdf7895e756"), "265", "6102565604679663", null, null, new Guid("6b62d633-8ccd-4aa4-82e7-a8336a9e5760"), "05/15" },
                    { new Guid("bcd29d95-c891-4356-b135-36b0da4a7f84"), "025", "8597309657176488", null, null, new Guid("34d672c5-050e-4c3c-8018-0107a72f13f5"), "06/27" },
                    { new Guid("bcdb1df7-ca4a-43cf-953f-028d06d47ed8"), "977", "7994089985741215", null, null, new Guid("1546f9ad-e76e-4438-9513-2c0cdbcdc9dc"), "05/12" },
                    { new Guid("bcdc9dbf-40d2-445e-a5d5-4bf947eb043f"), "335", "9727329790599546", null, null, new Guid("568a5cfd-171b-413d-addf-fe6ab58aa6d0"), "02/07" },
                    { new Guid("bd1db938-8431-44a5-80dd-cbd9be587627"), "760", "4116815712589658", null, null, new Guid("9b0c9ef1-c568-4fc6-8e02-cbbb959e0bbb"), "12/12" },
                    { new Guid("bd219b9a-1595-45ef-b820-623dc4b5f206"), "606", "8383656355767572", null, null, new Guid("7f910a03-763a-4cdb-bbcb-8241bae6fc96"), "11/22" },
                    { new Guid("bd33617f-662f-4b84-9c48-1e53e8df110f"), "853", "4799613128790934", null, null, new Guid("4d792f39-989a-48bc-8528-2bda17a5967a"), "01/26" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("bd4004c5-a585-4336-a7cc-edf51f84a1e4"), "524", "2116514356073634", null, null, new Guid("b9974b20-5b3f-4445-a6d7-c4352b53a64c"), "07/25" },
                    { new Guid("bde65cc9-5fdb-49e6-9585-dc61012f0ddb"), "953", "3381803576260403", null, null, new Guid("cefdf373-98f4-432b-bfc7-baaf121c554a"), "02/03" },
                    { new Guid("bdf0a29c-3ae9-42ad-828b-9c7eea02d081"), "404", "7917740244058155", null, null, new Guid("872eccf4-a3fa-43c5-ab2e-ac6f6c9e4f17"), "09/07" },
                    { new Guid("be286fdd-a222-48b4-bc8a-94449c46adb6"), "682", "3906708517535846", null, null, new Guid("fc7807f7-2e15-4c19-8500-ea40f337d9de"), "06/02" },
                    { new Guid("be2cc7f1-0d5b-4203-adf8-faf231fdf443"), "421", "5310322801022460", null, null, new Guid("b3997a22-bce6-473b-9a56-6baca1b5ece7"), "06/17" },
                    { new Guid("be9c2e47-717e-4605-8518-17b0f3812a2d"), "967", "1788991375281607", null, null, new Guid("4ec972f7-f6d0-4660-943e-5ad3d2557cfe"), "01/24" },
                    { new Guid("bef1504d-16a8-4736-bf4e-73ef6a763a17"), "171", "6377949503250052", null, null, new Guid("22c74cee-2548-4aef-ab56-019f64d2fb3e"), "01/02" },
                    { new Guid("bf26697c-8ec8-45f1-a60c-5d06cd6a0aa8"), "090", "7321626574250134", null, null, new Guid("0639ab22-a867-435b-8c5b-7acf69750583"), "12/08" },
                    { new Guid("bf690ea3-dda4-48ce-91c5-f2173154a9d1"), "049", "2283978387157031", null, null, new Guid("b070b87c-5a28-4f27-8f54-9238dfbe5c79"), "06/05" },
                    { new Guid("bfa2e5f0-cb8b-4647-9d9d-3a84385dbeb2"), "639", "9442292052739897", null, null, new Guid("fc15fcf7-014b-4521-910c-8a4a05ae7df9"), "06/06" },
                    { new Guid("c053e274-dcb3-4383-b209-e5ce0627c064"), "534", "5940672132081394", null, null, new Guid("9f317a02-0a11-4f32-b538-7ec5c02e4b5e"), "02/16" },
                    { new Guid("c083e752-f8df-4264-9a4c-de66554a9bbf"), "154", "2500220246473344", null, null, new Guid("c0ce8022-4a58-4c92-9e84-7f2ac0c9caa5"), "01/20" },
                    { new Guid("c08d8007-a78f-4b4d-b126-984180576fe0"), "032", "1971966617142394", null, null, new Guid("3705daaf-a245-497f-b245-acd05a008711"), "03/19" },
                    { new Guid("c0b565e4-3d9a-492f-bdbb-2ec5ce614127"), "929", "7743771832036822", null, null, new Guid("3705daaf-a245-497f-b245-acd05a008711"), "05/08" },
                    { new Guid("c0d74294-3fb8-46b0-91fe-31515092f434"), "696", "1612456340284618", null, null, new Guid("6709762d-580f-4c32-8f92-b1daa6e22c27"), "03/25" },
                    { new Guid("c10a7f0a-bc86-4fcd-8dca-e535b31ce5fd"), "391", "3631314750191483", null, null, new Guid("c60620ff-d62e-4585-9510-ed612aa89dcb"), "10/16" },
                    { new Guid("c113329f-ed03-4d64-8e4c-8d872a6ae83d"), "862", "8926778032490268", null, null, new Guid("eddb3b35-4415-4828-97b3-fd737f127090"), "03/27" },
                    { new Guid("c1276bca-dde4-40ed-b5ea-8bf59e16b041"), "215", "4513160569255386", null, null, new Guid("437bc41c-af0d-4443-809f-276b155b8846"), "01/21" },
                    { new Guid("c136eb71-efcb-4721-bf12-d4222cf282e4"), "074", "7865219927899091", null, null, new Guid("0b440e9a-ee26-43ee-9d40-46328f22a228"), "01/08" },
                    { new Guid("c228de20-5eef-4c7c-9509-85bf9fbdcc9f"), "737", "5386842695308371", null, null, new Guid("a7a63c10-9b55-47c6-9d56-8793ee29aafd"), "04/21" },
                    { new Guid("c232e6d7-a758-4bf9-aad2-e50558873a8b"), "800", "7000662638084484", null, null, new Guid("8513debb-cacb-47df-a4d3-e59f2a261b69"), "07/27" },
                    { new Guid("c2657324-e423-4957-95f4-9bb4ab993164"), "572", "9009594435066789", null, null, new Guid("34d672c5-050e-4c3c-8018-0107a72f13f5"), "04/22" },
                    { new Guid("c26d8cea-acae-4f51-86f9-b1b9e79ea542"), "787", "6619644708901223", null, null, new Guid("5c31a07d-9e1a-46bb-9c88-2f881f607c52"), "09/13" },
                    { new Guid("c3742e46-80e8-453b-bd98-9a1b8c808fd2"), "977", "1889223457180449", null, null, new Guid("25a47446-d397-4805-8427-d3185a6d35b7"), "06/07" },
                    { new Guid("c3d2e7e3-2711-4155-ad3e-a438b63f1a21"), "505", "4657073700462522", null, null, new Guid("94e92894-3b19-4c5f-9e95-0ec52116ec92"), "05/22" },
                    { new Guid("c4a198a4-2059-4f39-82b2-8d6890fce947"), "216", "6868950813960816", null, null, new Guid("3dc1a6db-3bf2-4650-b501-abf7ef284b3c"), "10/10" },
                    { new Guid("c5001ac3-f395-46c6-884a-583fba6e634b"), "008", "6381205298293505", null, null, new Guid("aee768a4-2b67-47da-a692-ab2b1cd95c27"), "07/26" },
                    { new Guid("c537cab9-3a7e-44ca-b0cf-fdafd257c92a"), "344", "8453754712595990", null, null, new Guid("9fc4b18c-b710-43c3-be29-ffdea2c51975"), "09/04" },
                    { new Guid("c543a54b-139c-4124-be7e-1216cccab5f6"), "907", "2696548044253566", null, null, new Guid("1e47206c-cbc9-48ff-becb-ea5c84ec9719"), "11/20" },
                    { new Guid("c5787860-285e-41a5-9168-74fb0bea1735"), "028", "1814304491494192", null, null, new Guid("69536a6d-5fc0-40dc-96ff-96cfa2e2ddde"), "08/03" },
                    { new Guid("c57cc964-3183-4744-8697-5cfbe9385654"), "873", "8379787114837100", null, null, new Guid("a165efc8-0956-4593-9333-e1ab17939488"), "08/15" },
                    { new Guid("c5e5e77c-9a78-467c-9343-1fc96473efbe"), "559", "8316734594163131", null, null, new Guid("09465da9-1c65-4a00-be4f-5b7144e699f3"), "12/20" },
                    { new Guid("c63213cf-6959-4ced-a6c1-368aa86ae474"), "373", "8787659886562767", null, null, new Guid("24b96e86-5860-47b1-a6ec-9a832bafbb14"), "02/14" },
                    { new Guid("c641f983-b42d-451d-8b5d-fd2a148da07b"), "085", "3336096433060406", null, null, new Guid("6172d849-4ee5-486f-8f97-d2bbcfc40084"), "06/05" },
                    { new Guid("c6a68807-ad75-4db2-8b2d-6b370265f264"), "609", "7529241711897604", null, null, new Guid("cf6839a1-51b8-4ec5-bfec-3cbe48c20160"), "07/27" },
                    { new Guid("c81eae6c-2f69-4c43-a3de-c20f29006456"), "002", "5119750546380342", null, null, new Guid("b50df756-e4ca-4115-a962-e283f6b8d317"), "02/08" },
                    { new Guid("c83adcce-cf8c-498e-b996-ec037640258d"), "537", "9660434989358211", null, null, new Guid("4af7ff34-3014-4da9-ba8e-e93cfaac4eaf"), "02/22" },
                    { new Guid("c8b47ee4-a5cc-4aa8-8691-3f2959ea9125"), "357", "7165098830911354", null, null, new Guid("4bb403d4-8670-466f-a9dc-17dd09c9d546"), "03/03" },
                    { new Guid("c8bb4f11-2a6c-43dd-b5be-d2253410fd9f"), "184", "2140466755294016", null, null, new Guid("ac2d4745-386c-4c13-a217-d9e2d9b842df"), "08/12" },
                    { new Guid("c90a5d94-6b46-4791-8d39-32266d4f0660"), "019", "8247768088758307", null, null, new Guid("7b9acf5a-1eec-4436-8152-103e38ca0953"), "04/26" },
                    { new Guid("c926efca-8059-4606-afb1-9e41e4494ce2"), "596", "6168135558623103", null, null, new Guid("f17c05bb-245d-432b-9116-f181ecbd16c6"), "07/25" },
                    { new Guid("c959b754-d92e-495a-af1b-6a1e2a34a55f"), "377", "1984828143478188", null, null, new Guid("605efc2a-1846-428c-a520-3c8efbd1c5d8"), "09/21" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("c995248a-8798-4d03-a000-35a0075a7f15"), "971", "3098660669544682", null, null, new Guid("51655f73-efc8-4142-b1ea-1657e4fc0f2e"), "01/06" },
                    { new Guid("c9c3150d-2751-43ab-8437-0a845e4c3380"), "470", "4993096853865220", null, null, new Guid("a64a13ca-2754-4769-a254-32716c64c908"), "06/06" },
                    { new Guid("c9f8be09-1159-4b02-89af-bc06c4561069"), "869", "5556820248581946", null, null, new Guid("ca9a7100-5d5c-406e-8028-d065cd21c772"), "05/07" },
                    { new Guid("ca023b02-b4f3-4aea-84fd-45b013148d6e"), "047", "9635424820371724", null, null, new Guid("7889ec96-3dce-40c9-a3d9-1dabf9642602"), "10/12" },
                    { new Guid("ca6cb033-2bf7-4d3a-a055-8b83bd250c72"), "605", "1623210835157316", null, null, new Guid("7889ec96-3dce-40c9-a3d9-1dabf9642602"), "08/15" },
                    { new Guid("cab424ff-4135-4b8b-8d34-afcd79d9f206"), "299", "9447915511286398", null, null, new Guid("716e3b4a-4381-424f-88d2-df0753a8cb13"), "09/07" },
                    { new Guid("cadf15b1-1dbc-4fc2-a127-9c580aea261a"), "151", "1605816720984751", null, null, new Guid("2eb253e8-852b-4b59-bbd3-41b1d962644b"), "04/17" },
                    { new Guid("cb7a4134-852b-4ecb-bba1-3ad0a450eca7"), "261", "1632723549617546", null, null, new Guid("cefdf373-98f4-432b-bfc7-baaf121c554a"), "04/26" },
                    { new Guid("cbb004b8-c9fc-4eff-8051-bd4e232fa6ce"), "384", "1331841241002612", null, null, new Guid("6ee9a7d3-8695-4b4a-9a7f-e035a03a4cc3"), "12/27" },
                    { new Guid("cbe1d8f9-a198-4c06-aaa7-11e743d1cbcc"), "773", "9389827851496806", null, null, new Guid("4fb2390c-a600-4f3b-adfe-f73867978239"), "03/15" },
                    { new Guid("cbe88db0-9436-4406-86b5-a547a23906df"), "925", "4261361473606869", null, null, new Guid("96357562-82d6-4394-b4bf-5b698e1ad612"), "01/04" },
                    { new Guid("cc388cca-d073-48d7-82f3-9d5b9353b61d"), "821", "3466304582329915", null, null, new Guid("0a69540b-ce9e-427c-8970-9f311fba0c21"), "07/19" },
                    { new Guid("cc3da4a8-0368-4fc3-8352-e5ed6f48f8cc"), "513", "2389720743264697", null, null, new Guid("18314b53-d5e3-48fa-8ad6-dc84c3baa1ff"), "05/23" },
                    { new Guid("cd10d526-c556-461b-9bfd-acd17b7ebf23"), "371", "4579493205053355", null, null, new Guid("bd5c667b-2bfc-46c6-814e-7b5c93be8f43"), "05/07" },
                    { new Guid("cd25c869-8e73-4746-bde7-e9470b68f536"), "993", "3338574133262268", null, null, new Guid("9f331cb7-b70d-434b-bc28-147a5e624fd8"), "06/27" },
                    { new Guid("cd4a17c1-5420-488f-a263-3e3c85f37f39"), "166", "5740023360750066", null, null, new Guid("8e8fd0f7-2809-49f2-9c1e-cbeb885b2de7"), "04/14" },
                    { new Guid("cdeae877-9bb5-4d60-be83-16b220973d9f"), "446", "3026435164441321", null, null, new Guid("8dd6a489-4514-4244-9fa7-a1490970f38b"), "11/27" },
                    { new Guid("ce328663-307c-407a-bc1d-3ed360f231f9"), "874", "7208246157326758", null, null, new Guid("24b96e86-5860-47b1-a6ec-9a832bafbb14"), "08/25" },
                    { new Guid("ce555d41-a34d-42f4-9750-785ad261097b"), "286", "8422901887386442", null, null, new Guid("c311c4ad-bbcf-418b-8259-eec5ae72eb71"), "11/21" },
                    { new Guid("cea6a735-8d04-4b32-8f38-ed35154b87bb"), "431", "1059668475399236", null, null, new Guid("26ad372f-ab3d-49d6-a283-d78f71a0b97b"), "10/12" },
                    { new Guid("cef6167a-c579-4a15-b61b-d70085c5e1bc"), "809", "5943650531928297", null, null, new Guid("8dd6a489-4514-4244-9fa7-a1490970f38b"), "04/14" },
                    { new Guid("cf3f494c-b3aa-4430-84f0-29e9e4104a83"), "063", "3881144017974503", null, null, new Guid("d1fdc728-523b-49bf-b2d8-eee9a8bb93d1"), "08/23" },
                    { new Guid("d0f88838-6aac-4d7d-b7a8-d7a51cae8bfd"), "706", "8571731874993136", null, null, new Guid("58fc780f-3b29-4947-a319-3ed8b421144e"), "06/16" },
                    { new Guid("d12078bb-1da2-4367-ad88-e085c497071a"), "254", "2570907802689226", null, null, new Guid("b944ae23-efab-4fcb-bda0-6be21e2add96"), "03/09" },
                    { new Guid("d14fc79f-6a56-4573-ac4e-3530bb2ba845"), "388", "2385910378482164", null, null, new Guid("49922094-de40-49f9-8fe5-21e734ddaadc"), "07/05" },
                    { new Guid("d177e606-a824-427e-8495-d4b9b15c2862"), "158", "2773840579635024", null, null, new Guid("d5f398ce-f08b-4d20-af17-603089eb45ee"), "09/10" },
                    { new Guid("d1b7f7b8-318d-481d-ab88-b409c5e0d6ec"), "900", "4256936888105857", null, null, new Guid("e6b167e1-2f8a-4aa9-b766-dcb40c4c65b7"), "02/24" },
                    { new Guid("d2541004-3e55-4676-9ea8-7c9994bd573d"), "316", "2593937728908634", null, null, new Guid("427485d5-0faa-4f9a-9c6f-70317d50831a"), "07/02" },
                    { new Guid("d4331435-c36a-45a7-b5db-0d1ae089c3a3"), "455", "7426814662836791", null, null, new Guid("c9de1952-448f-4a77-a4fa-b78a3751957a"), "03/27" },
                    { new Guid("d4443673-64cc-4564-8849-da33c3f9bf79"), "495", "3194144473477962", null, null, new Guid("4d65579c-7caa-4a73-aec4-ebf5de2054ab"), "08/25" },
                    { new Guid("d4538e0f-e001-4b77-8e6c-7dca7c025288"), "819", "2863260476979465", null, null, new Guid("777e0877-9079-4ecc-a52b-f0bf5734b939"), "01/09" },
                    { new Guid("d47c722f-8ba9-4495-846b-0be33926094e"), "650", "3655067659562050", null, null, new Guid("8a1cc6ac-cbbb-45b8-a858-79df665cbf01"), "04/03" },
                    { new Guid("d49176f6-8ae0-406b-8a5a-14a75938a4ff"), "303", "1847487766378994", null, null, new Guid("7889ec96-3dce-40c9-a3d9-1dabf9642602"), "12/04" },
                    { new Guid("d4e56d91-1d79-4eca-93ed-54b2bab5759d"), "103", "7772333311444807", null, null, new Guid("9e4f824d-b29a-4ec5-b3a1-111d46f41ecb"), "02/28" },
                    { new Guid("d571bb9b-ec34-4b9b-abfd-b7885d4e4d20"), "422", "1458394082539891", null, null, new Guid("166bcf97-6b8a-4025-ad11-df15241b0a24"), "02/26" },
                    { new Guid("d5ad0c76-cee5-4d21-8c5a-6a8c2033560e"), "687", "2798415798527231", null, null, new Guid("5e2d266d-c2a4-4711-b57e-3656b61d6ad2"), "07/12" },
                    { new Guid("d60c5a6a-2f17-41c3-98ac-63f0d965cd48"), "735", "2436184595118921", null, null, new Guid("37432efe-ddf1-4f3f-9753-a8b4a9e54500"), "08/06" },
                    { new Guid("d69da9bd-b82e-4ff4-abad-253c1122d754"), "346", "7144842231444659", null, null, new Guid("d8361619-ae4f-4db1-9eb9-291e4814a381"), "09/19" },
                    { new Guid("d6a78b47-8c09-4eb2-b65a-f389a0cbe153"), "061", "3335669145984726", null, null, new Guid("5ffbbdb6-b588-4eef-811a-4b39d217f0a8"), "05/25" },
                    { new Guid("d6c495fc-88f7-416b-9963-adf6a6a243d3"), "099", "9647729597613926", null, null, new Guid("5d6854b6-463d-4c99-844f-2b03c65e196b"), "07/25" },
                    { new Guid("d73f1ffd-5985-4558-9386-32aed07abb3e"), "580", "2339003633819876", null, null, new Guid("d9295c19-5c11-40bb-ba7c-c1b368114ac0"), "06/21" },
                    { new Guid("d74ef194-cfcc-4a2b-937f-44b5d7beb97d"), "419", "3286483267720446", null, null, new Guid("861c20c6-b2fe-4d03-a2b4-ae2380f7edc5"), "03/03" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("d751757a-a52d-4de8-b757-e5fc0dffa36e"), "613", "5866993919974426", null, null, new Guid("3aa0613b-0255-46fa-9fc9-f73e67ec6962"), "10/08" },
                    { new Guid("d79727e0-6668-49f4-b4f8-06fcaf4394ec"), "772", "6766991392759089", null, null, new Guid("3dc1a6db-3bf2-4650-b501-abf7ef284b3c"), "01/17" },
                    { new Guid("d79e7866-e9c9-425f-8b2f-3353b495562d"), "688", "4851200104433492", null, null, new Guid("a3564d73-cc7f-45bf-bb8d-5bff9f9bd319"), "04/23" },
                    { new Guid("d7e37a35-724d-4939-b177-33594b471307"), "003", "2853868939451672", null, null, new Guid("7b354f95-20a6-4d69-abe1-b5a212feb069"), "07/04" },
                    { new Guid("d7fd4c61-8cbb-4411-abed-eeb6ea02f1eb"), "476", "6620317865156577", null, null, new Guid("777e0877-9079-4ecc-a52b-f0bf5734b939"), "02/18" },
                    { new Guid("d821af33-f546-4d03-8275-a8081f7c1cff"), "781", "7179472836286291", null, null, new Guid("5560fdd3-3041-418a-bdbd-b1b7cb595a87"), "08/05" },
                    { new Guid("d8404222-f848-40b2-9310-99eca39ceb43"), "780", "8977328735182035", null, null, new Guid("bcb5583b-3b55-4ea8-b016-f74baf89e99a"), "11/25" },
                    { new Guid("d93b08ac-38bb-4c4c-944a-13ac35ebf3c2"), "460", "2825366573377753", null, null, new Guid("9e73d492-68df-4c26-bbd7-c238340416ec"), "10/18" },
                    { new Guid("d9c6aa89-0b90-4712-8a32-ff9274314700"), "071", "6177231633247108", null, null, new Guid("1c5135c6-32f4-4363-a0a3-5a8fb7357df1"), "01/09" },
                    { new Guid("d9e16866-ad3f-4536-aa42-eb6f602f664d"), "410", "2116214896046698", null, null, new Guid("f4d9bb48-d87b-420c-b2ef-f724726c7a08"), "03/03" },
                    { new Guid("da1f8e96-b264-4b89-a989-efe6f3c946d9"), "903", "5619154125117777", null, null, new Guid("e1223f43-016e-41f5-b212-ab70a0ac01e2"), "09/17" },
                    { new Guid("da83a61f-6c37-41da-adec-6ca6d2996661"), "140", "7894148144082463", null, null, new Guid("9eb02965-fa79-4bc7-940e-eff714a39f7e"), "10/05" },
                    { new Guid("da9132d8-8f02-4fa3-b46c-32e9304d50a6"), "185", "9226296713363888", null, null, new Guid("cc549d3d-c127-48fe-9320-69c0367cf0ef"), "05/09" },
                    { new Guid("daa2097e-845c-45d0-8380-50c2352abb70"), "956", "3342077020229566", null, null, new Guid("641c3d4a-a6ff-4cb3-b40a-665b9156a255"), "07/06" },
                    { new Guid("db1e7a66-11d9-4d59-a75c-951f9ad59c7e"), "690", "1794717848786840", null, null, new Guid("73aad8c3-cbed-4125-b80b-7db0735c3ac6"), "02/10" },
                    { new Guid("db6fd00a-1d44-4d5b-8ca8-e6e19e0c319c"), "801", "3997378404326223", null, null, new Guid("dd2a73f4-0d43-45df-8aa0-196122e00fc2"), "07/16" },
                    { new Guid("db9deab9-fbcc-470d-ac50-313988b233e7"), "065", "1904419032565580", null, null, new Guid("7b354f95-20a6-4d69-abe1-b5a212feb069"), "01/03" },
                    { new Guid("dc283713-4251-477f-9a04-90a4d2791f19"), "591", "4185635466454907", null, null, new Guid("c4c17769-48f5-471b-ac8e-87a2c17573b4"), "07/14" },
                    { new Guid("dc3bc0d8-6e91-4e1e-a1d4-33cba6006368"), "394", "8657300512628888", null, null, new Guid("8bbc88c0-c35c-496f-b3fc-e18f3d8bad18"), "09/27" },
                    { new Guid("dc86a275-6ce2-4194-b96c-3d67fd55ca16"), "964", "1296471995066443", null, null, new Guid("b50df756-e4ca-4115-a962-e283f6b8d317"), "01/09" },
                    { new Guid("dca21910-1fc7-449c-b5ef-b6f18f38b6b9"), "617", "4877919823993691", null, null, new Guid("62f9c608-cb23-46fa-a1c4-304e5c65aec1"), "05/04" },
                    { new Guid("dcbcdb59-bf47-4dfc-90f7-ca898e035e4f"), "951", "3608757964896915", null, null, new Guid("98222b1e-1352-4ac9-8c47-69a7f0582ef6"), "09/09" },
                    { new Guid("dd6ce124-c3b3-4251-a7c9-aa2f760e1e0c"), "430", "9282154327001487", null, null, new Guid("ffdf2e3d-14e1-47fc-a87f-43ee44597c72"), "09/13" },
                    { new Guid("ddc76c54-b735-4e65-a58e-e19849234071"), "323", "5887604154917525", null, null, new Guid("1e47206c-cbc9-48ff-becb-ea5c84ec9719"), "05/09" },
                    { new Guid("de85cc51-2a76-4b02-b805-b07456566497"), "789", "4001171268121251", null, null, new Guid("b5fe6c30-5f2d-462b-9dd2-bc5388f99ce5"), "08/25" },
                    { new Guid("de89672b-48bb-477d-bfee-6bfe08c7db90"), "433", "3172782552527474", null, null, new Guid("63ce22ac-8a36-4fb9-bf6d-61e02101f5d7"), "02/22" },
                    { new Guid("dee3ebbd-5e47-44c5-826d-f07843002220"), "735", "1129537875503395", null, null, new Guid("73850497-d7e2-4015-bf80-d8fc761772d3"), "10/18" },
                    { new Guid("df307357-77e4-4980-a817-6a8b50684351"), "752", "2422349317144513", null, null, new Guid("c311c4ad-bbcf-418b-8259-eec5ae72eb71"), "06/20" },
                    { new Guid("df65d8da-b2ae-4239-a907-c334bec45f89"), "449", "8042254249513692", null, null, new Guid("c561cc5e-190d-4a91-8ea9-d03583fa3f86"), "04/21" },
                    { new Guid("df8a91c0-de54-44ea-aa6e-ac70ffb63e6b"), "191", "9205583422696517", null, null, new Guid("3ca63884-385c-4ae8-ac07-f3dc2df24aae"), "12/26" },
                    { new Guid("dfdc0791-28d6-4781-a6c3-9727b005940a"), "423", "1710699757076477", null, null, new Guid("b71f69da-e20d-4b25-b2fb-00d5eb1c9002"), "11/19" },
                    { new Guid("e02b9916-3f85-45cf-a62d-4c1b2c527958"), "350", "9952490391829539", null, null, new Guid("9b8fcbcf-ce9d-40cf-aa2a-0543ebe6f135"), "07/26" },
                    { new Guid("e045a19d-8294-452a-bd3f-7c7a49f011ad"), "110", "1992457424056836", null, null, new Guid("3dd4bd2a-4dd8-4988-867a-99041eb6851d"), "06/03" },
                    { new Guid("e112a882-42ec-46ae-b1cb-37673f72542c"), "728", "1691781517800402", null, null, new Guid("4bfa50d6-7b76-402d-afe8-4b558ee6165b"), "10/02" },
                    { new Guid("e117fec8-126c-4c61-9d6a-5aaa8b1b1671"), "172", "7125958372967008", null, null, new Guid("91024531-3bc9-4397-868c-67a81b4abcfc"), "07/26" },
                    { new Guid("e13997f4-8192-4fe3-907b-5088a37be2d4"), "910", "5674018563630394", null, null, new Guid("a161bc80-bb44-439e-bb80-442569d93b23"), "08/26" },
                    { new Guid("e1497b6d-9f64-4086-8d1b-e75a081c87c0"), "083", "9535252376646186", null, null, new Guid("6375150d-9633-494e-ba79-b55f87d56afa"), "12/11" },
                    { new Guid("e1b07583-a430-4466-92af-42b80c7888d0"), "624", "5150730183510075", null, null, new Guid("c798d3b3-ea5a-4b3b-a69b-7022aa64fe86"), "05/18" },
                    { new Guid("e1f395d6-4dea-4327-8364-c2f8dfd2c02c"), "230", "7136839138807940", null, null, new Guid("dd2a73f4-0d43-45df-8aa0-196122e00fc2"), "11/27" },
                    { new Guid("e2025903-0299-4851-b882-a6d3a1e4e65a"), "213", "6321309196581848", null, null, new Guid("dc04df94-1448-4899-bec4-692b13ea2748"), "09/22" },
                    { new Guid("e24c6242-2db9-4003-a69d-e64cf2f1f483"), "028", "4175340475982098", null, null, new Guid("f044a50f-e46f-4992-b8ae-47aa00e79d4d"), "05/18" },
                    { new Guid("e24eba37-ae1d-40cc-9fe5-84ad0141a920"), "845", "6290012924733896", null, null, new Guid("966d5ef1-e601-407d-86be-887c8e79a449"), "12/12" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("e26feba5-ea96-45e3-9e31-01de9379da23"), "517", "4584480225826481", null, null, new Guid("9f331cb7-b70d-434b-bc28-147a5e624fd8"), "12/24" },
                    { new Guid("e29600e1-92f8-4ebb-9323-9fe9dfabb6e6"), "610", "7500685271784085", null, null, new Guid("fc2635e7-fbe6-403c-bcdf-dc9a65be3352"), "05/03" },
                    { new Guid("e2c260b6-55ef-42fa-b249-5223948e03ea"), "110", "3000269724913168", null, null, new Guid("4bb403d4-8670-466f-a9dc-17dd09c9d546"), "07/24" },
                    { new Guid("e2e09a7a-c4db-45aa-8f80-78d7f952a49b"), "648", "2590462881940299", null, null, new Guid("e58d2261-638d-41ed-b5bf-55b3a94546e1"), "08/26" },
                    { new Guid("e303175d-e675-4f48-bc33-54febfb15f23"), "350", "7506289688677816", null, null, new Guid("d1fdc728-523b-49bf-b2d8-eee9a8bb93d1"), "08/25" },
                    { new Guid("e3b0257a-643a-4ef6-9000-d1f4087c5688"), "282", "3421280110344955", null, null, new Guid("57041776-9144-494f-9e92-9c9da3135eab"), "10/27" },
                    { new Guid("e3c4bb39-ebca-47a5-b686-f4039fdd7cc1"), "638", "8291128309256914", null, null, new Guid("f044a50f-e46f-4992-b8ae-47aa00e79d4d"), "04/13" },
                    { new Guid("e3d0a773-e7e8-43f3-9cf8-fd59cb9a0961"), "948", "8260933655849108", null, null, new Guid("359f112e-4dd6-47fb-995d-9dae092d143b"), "09/08" },
                    { new Guid("e416689f-5bcc-4a3b-9959-69c460d1827c"), "570", "6838769740744690", null, null, new Guid("7902b014-f441-4bad-a55f-7656352c84e7"), "01/18" },
                    { new Guid("e4379e58-e159-4dbf-8b16-3d627b3f78f9"), "691", "1103699057662817", null, null, new Guid("5d6854b6-463d-4c99-844f-2b03c65e196b"), "11/22" },
                    { new Guid("e4406467-6320-451f-97b6-90c8ee909528"), "247", "9223373958046690", null, null, new Guid("d184b2bf-159f-4b4e-83e0-4f0bb6184d14"), "10/28" },
                    { new Guid("e4abfd83-71db-4480-92ff-f42fb2d4b816"), "080", "8857327820473399", null, null, new Guid("ef100efa-deb4-4516-9a15-38df8ff7e396"), "09/23" },
                    { new Guid("e4bd9991-0c89-412d-b494-f6e99a5497d7"), "954", "6362211071350240", null, null, new Guid("57d5c043-44a4-43bb-80ee-1cbb791b2285"), "01/25" },
                    { new Guid("e5111729-29f9-4884-a708-297f9cb455d1"), "541", "5140164928284760", null, null, new Guid("4a254852-2316-4300-99be-6d54e3eeac93"), "03/01" },
                    { new Guid("e6446ea3-755e-4526-8051-fc52d307c5d1"), "666", "8268520536931390", null, null, new Guid("427485d5-0faa-4f9a-9c6f-70317d50831a"), "05/18" },
                    { new Guid("e6529f0b-6407-421b-bad7-9aa92a78220d"), "047", "6708775305384645", null, null, new Guid("0397b496-e66d-4ab5-942d-0a53948ef201"), "06/07" },
                    { new Guid("e6587028-c52c-403e-a674-7e0461c8104b"), "043", "3016208580593741", null, null, new Guid("5a6031a7-d008-4d4c-9a87-857d42759454"), "11/10" },
                    { new Guid("e664e11f-44f1-428a-b0bd-92f408eada13"), "667", "6478994109291970", null, null, new Guid("dffee49d-d296-4315-aefd-9602dd01358c"), "03/20" },
                    { new Guid("e685fac6-8325-4780-97ec-d995e53e64b7"), "668", "1125626313061584", null, null, new Guid("a01a13e5-a8d1-4048-b8b2-24cdfac5f11e"), "07/26" },
                    { new Guid("e701bd4e-bda1-414c-b07f-75a5c3eb657c"), "359", "6756672688790302", null, null, new Guid("7f910a03-763a-4cdb-bbcb-8241bae6fc96"), "03/11" },
                    { new Guid("e732e7ea-e377-4446-8869-7c671ddf80be"), "333", "3179089574191633", null, null, new Guid("aa1380ad-62cc-4108-817a-4ac56a2c382d"), "04/25" },
                    { new Guid("e7384cac-4f08-40bd-9b7c-3bd5b75586ec"), "619", "2476307475047810", null, null, new Guid("78615ad6-0a03-477e-a515-c98b1a96475d"), "08/05" },
                    { new Guid("e7c1d6b8-84e2-4bd5-9238-d45d6385ebbd"), "754", "8915804981824686", null, null, new Guid("dee746db-2712-4366-98c6-517b826fd421"), "09/15" },
                    { new Guid("e837ee7f-8cca-461b-936a-797cf6a00412"), "046", "7066016032988445", null, null, new Guid("4fd873ab-a800-46d0-959f-d9f6189c846e"), "12/06" },
                    { new Guid("e8534a32-bd09-43a1-b6c4-98851c4970c9"), "333", "5392239389410518", null, null, new Guid("9a38b671-5580-4658-abf4-c1fc9ce2be0b"), "02/18" },
                    { new Guid("e99aeb73-0373-4972-912c-22cb5134e810"), "475", "6244690576522577", null, null, new Guid("997402b2-514c-445f-9988-ae18a101181e"), "07/03" },
                    { new Guid("e9f5e7e6-beea-41d4-b699-fd9ac86d80b3"), "880", "8517846512737008", null, null, new Guid("b4e4db54-4f23-4365-96a9-cb8bd3cdaecf"), "01/23" },
                    { new Guid("ea329c9e-a57e-4474-a137-fe162f31df13"), "510", "1192760274510409", null, null, new Guid("fc2635e7-fbe6-403c-bcdf-dc9a65be3352"), "09/06" },
                    { new Guid("eacd8833-fe0b-4142-8688-c649dc0ad3ef"), "284", "2215378714700959", null, null, new Guid("8c7f5100-7603-4d85-9e37-fba6a586f7c8"), "07/23" },
                    { new Guid("eb210ed0-f34c-4c28-9508-bcea0fdfede0"), "158", "5730257449594791", null, null, new Guid("c1dedd78-34a2-4542-a585-a6ba740f5856"), "08/13" },
                    { new Guid("eb9a38e3-683c-491c-8d8b-962e7bb0fead"), "711", "6102805924637226", null, null, new Guid("872eccf4-a3fa-43c5-ab2e-ac6f6c9e4f17"), "04/25" },
                    { new Guid("ec637d0f-eaa7-451a-b02e-2e7cc4ace4c0"), "251", "4544444560258713", null, null, new Guid("da687a7e-bca5-449f-ad43-32e0ac00fe15"), "06/08" },
                    { new Guid("ec700d9e-d0b4-4263-9013-2b96d961d4f3"), "707", "7395072118935382", null, null, new Guid("b9974b20-5b3f-4445-a6d7-c4352b53a64c"), "12/12" },
                    { new Guid("ecac1d56-fcfc-43c0-847c-9cfcdc270205"), "861", "5721327094105913", null, null, new Guid("88155035-c6f4-450c-bd25-3d3e9c9d8f5d"), "01/08" },
                    { new Guid("ecb42bd6-1195-491c-bba6-6e91867dac11"), "983", "8115543531090470", null, null, new Guid("4d792f39-989a-48bc-8528-2bda17a5967a"), "08/28" },
                    { new Guid("ece8c4d2-f202-4d85-9a3c-12c8c51c568c"), "302", "4106391847026017", null, null, new Guid("17b956d2-133d-4289-8a76-4633e194bce0"), "09/10" },
                    { new Guid("edde3fe3-8641-4551-8f57-e2f29617adbd"), "093", "1967310712121575", null, null, new Guid("94e92894-3b19-4c5f-9e95-0ec52116ec92"), "01/11" },
                    { new Guid("ee20c170-9275-40e8-91ac-a4420644ec27"), "195", "6278330800667980", null, null, new Guid("01a8f276-3a4c-402e-98b4-c3b9dba05f91"), "06/24" },
                    { new Guid("ee244bbb-b721-47d7-9ac4-0e614774aa60"), "041", "8698844093426992", null, null, new Guid("be18d868-cfef-46af-89ea-769a3c24c7da"), "08/05" },
                    { new Guid("ee2dcd10-d47f-4836-a442-24e9365df86a"), "255", "3715735153786219", null, null, new Guid("57d5c043-44a4-43bb-80ee-1cbb791b2285"), "12/24" },
                    { new Guid("ee6e2e71-f7ec-47f0-8805-14f5c8808cb2"), "820", "8404779157859915", null, null, new Guid("5a6031a7-d008-4d4c-9a87-857d42759454"), "06/24" },
                    { new Guid("eebe7cce-1660-4a44-a699-d7fd53b2e3fb"), "247", "8715093857423150", null, null, new Guid("9fc4b18c-b710-43c3-be29-ffdea2c51975"), "02/12" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("eedf710f-db2a-4400-86a8-04128cf227eb"), "992", "5046202440197550", null, null, new Guid("eedd859d-8af5-43b7-8938-5bce7dd89153"), "07/09" },
                    { new Guid("efbf78be-0597-4021-b7db-295072738758"), "089", "7334643937977537", null, null, new Guid("d1fdc728-523b-49bf-b2d8-eee9a8bb93d1"), "04/24" },
                    { new Guid("eff34416-f135-4288-a7be-d7a452392eab"), "376", "2044064624707704", null, null, new Guid("997402b2-514c-445f-9988-ae18a101181e"), "01/17" },
                    { new Guid("f08bff5d-0af7-4508-b130-e28b89061223"), "201", "3745578445900702", null, null, new Guid("b944ae23-efab-4fcb-bda0-6be21e2add96"), "02/03" },
                    { new Guid("f0c95e7a-88b6-4ea5-b2cf-18d531d5259a"), "164", "7797948829016236", null, null, new Guid("43b84c41-ad8c-49ff-ae3a-561f6d21e04b"), "01/19" },
                    { new Guid("f0d38987-c01e-4a6b-a6bc-f2a307033064"), "184", "4967605938518233", null, null, new Guid("03a04e64-e8f5-4db8-ae88-e45982174d32"), "05/11" },
                    { new Guid("f1391e06-401a-4c73-b8e2-aa540bb86bc2"), "151", "5200278747303977", null, null, new Guid("43b84c41-ad8c-49ff-ae3a-561f6d21e04b"), "06/09" },
                    { new Guid("f2c4e0b9-8fd1-4b37-b8ad-0f491cc7cdfe"), "968", "2186999497698549", null, null, new Guid("f472d28b-1df9-4c84-8ceb-3254f55042e7"), "12/26" },
                    { new Guid("f341c23d-125c-44f0-9b5f-d56df14e1d08"), "342", "8295627948812992", null, null, new Guid("5441f683-8cec-4fb5-96c6-2fa82e7997d3"), "02/13" },
                    { new Guid("f3d3a9a9-0ed4-4cc2-8511-7167d772842a"), "432", "8886461194729345", null, null, new Guid("72b9b70e-980c-47d3-a949-0b0acbdbe9f3"), "05/12" },
                    { new Guid("f3e080fd-f147-47dd-9bff-69a5799096e5"), "560", "3579228753297969", null, null, new Guid("da687a7e-bca5-449f-ad43-32e0ac00fe15"), "09/21" },
                    { new Guid("f43b6b77-d229-4159-83a0-b893c0790d3d"), "759", "9090466449492634", null, null, new Guid("0639ab22-a867-435b-8c5b-7acf69750583"), "10/28" },
                    { new Guid("f4880091-cdd8-4de2-8998-fda898fe6d8b"), "060", "4881419753391929", null, null, new Guid("d666c5aa-5c03-4391-8629-5cc681422ca2"), "02/20" },
                    { new Guid("f4a57fc3-40ac-435c-8565-00e9902d2989"), "364", "8778679659253643", null, null, new Guid("63ce22ac-8a36-4fb9-bf6d-61e02101f5d7"), "05/04" },
                    { new Guid("f4fef2b1-0654-457a-a27f-d2df10fb1ecf"), "279", "2638247575398215", null, null, new Guid("91024531-3bc9-4397-868c-67a81b4abcfc"), "12/14" },
                    { new Guid("f51d653e-97e9-4407-9492-685172878ae8"), "671", "4208755601943656", null, null, new Guid("437bc41c-af0d-4443-809f-276b155b8846"), "07/02" },
                    { new Guid("f590b58e-9e87-48b0-8c0e-38738969891f"), "070", "7766209333139455", null, null, new Guid("cf6839a1-51b8-4ec5-bfec-3cbe48c20160"), "11/11" },
                    { new Guid("f5a16e8f-e510-4f9e-8845-6bce0c30595f"), "542", "5252221497863934", null, null, new Guid("abff8b44-2e47-47cd-8158-cb029242cf8c"), "07/02" },
                    { new Guid("f5d304ec-4ce1-4ed5-beef-578a93c6f4c5"), "947", "2953504175700773", null, null, new Guid("96357562-82d6-4394-b4bf-5b698e1ad612"), "02/24" },
                    { new Guid("f60c0c48-540d-4b31-a042-f93c281e18b6"), "252", "6773645691690391", null, null, new Guid("f17c05bb-245d-432b-9116-f181ecbd16c6"), "10/14" },
                    { new Guid("f640d181-1ef8-4ac9-88b3-6ffb7ec1240c"), "469", "9419361706710206", null, null, new Guid("e27f9603-32f8-4066-bf07-4ab692c8350b"), "05/21" },
                    { new Guid("f6b32f93-37e0-4f48-a977-82323e4bfd4d"), "262", "7744732387626586", null, null, new Guid("cc549d3d-c127-48fe-9320-69c0367cf0ef"), "03/10" },
                    { new Guid("f6d600c7-b954-4ca0-aac0-3d99510528d9"), "781", "8993210969510639", null, null, new Guid("4fb2390c-a600-4f3b-adfe-f73867978239"), "06/24" },
                    { new Guid("f6f79f35-f869-4204-bf1f-fc82b890bf18"), "191", "1566100036855690", null, null, new Guid("a6fc0423-6291-4866-8d02-6faea1986c4e"), "11/19" },
                    { new Guid("f72dc6e4-8b59-4430-aff1-d041f28ef655"), "128", "9676417363472368", null, null, new Guid("c0ce8022-4a58-4c92-9e84-7f2ac0c9caa5"), "01/11" },
                    { new Guid("f7530b8b-06ed-4fa5-8423-6502158c3bdc"), "867", "8187879970668049", null, null, new Guid("e9781110-3553-481f-bb3a-7ca26a63a83b"), "01/05" },
                    { new Guid("f846ac0e-45ab-4ebf-b5a6-342d23b01fd6"), "867", "8874607178398829", null, null, new Guid("72b9b70e-980c-47d3-a949-0b0acbdbe9f3"), "12/13" },
                    { new Guid("f84e4294-f7e7-4d6f-ba0c-861001121812"), "830", "7274717004158917", null, null, new Guid("5ffbbdb6-b588-4eef-811a-4b39d217f0a8"), "05/02" },
                    { new Guid("f872e698-42d8-4741-b8b4-cb5b38ef5979"), "051", "8203899938544777", null, null, new Guid("3ca63884-385c-4ae8-ac07-f3dc2df24aae"), "02/17" },
                    { new Guid("f87915ff-d2af-44aa-833e-fb2d03163b67"), "979", "2552000474363277", null, null, new Guid("c8db4c48-87fc-43bc-b9ef-e88e6764800d"), "05/18" },
                    { new Guid("f89fa8f9-0299-4ffc-9ee4-f23e93501092"), "266", "2235674662566741", null, null, new Guid("ce4c448e-35a5-4243-aa12-b967d2b3da6f"), "06/27" },
                    { new Guid("f8b87d4a-8d51-4fa7-bfcd-57633730abb1"), "943", "1180223447148116", null, null, new Guid("e28ae980-81b6-4d5f-8748-b7cb3f0f995d"), "01/06" },
                    { new Guid("f8da43b9-a260-4cb5-8638-1dc368c881d4"), "220", "9792075479190501", null, null, new Guid("8bbc88c0-c35c-496f-b3fc-e18f3d8bad18"), "08/16" },
                    { new Guid("f92f4cdc-e098-47cb-9dd3-b3d4dc2aef73"), "634", "5704945852719776", null, null, new Guid("e6b167e1-2f8a-4aa9-b766-dcb40c4c65b7"), "08/08" },
                    { new Guid("f95179da-cf63-476f-9fcf-696aab3c95c2"), "098", "4274637018600086", null, null, new Guid("259e3939-18d5-4998-98ae-345c9d0fa279"), "03/04" },
                    { new Guid("f9ba1d11-d201-42e4-a901-ac948c21e0e0"), "364", "5147457980991987", null, null, new Guid("451f756f-99dc-4563-9d9a-db92f4a114f0"), "11/08" },
                    { new Guid("f9ce49da-9aa6-4127-9193-bbb435e4d698"), "381", "3654479795068425", null, null, new Guid("a8a8fdd8-4ded-4cee-9b8c-87f2285d7eab"), "12/11" },
                    { new Guid("fa420d49-4a29-4faa-aa7a-36e9959b0e0f"), "782", "1355184514363789", null, null, new Guid("b2a11489-a556-462e-9631-1108d9049fcc"), "10/24" },
                    { new Guid("fadaf80f-cc20-4a57-aeda-2d061dad7728"), "535", "6791731269118439", null, null, new Guid("cb8696d4-d2d5-40c3-b74f-38aafecd34f8"), "02/03" },
                    { new Guid("fb3a4fc8-3387-44d2-ae77-0907c0da7c09"), "277", "7826072257134763", null, null, new Guid("2f7c84d9-6fe2-4a1c-ba84-c8d43feade58"), "05/18" },
                    { new Guid("fb6629c5-0882-4533-98c4-942f7bebee1b"), "070", "7993767132784843", null, null, new Guid("abff8b44-2e47-47cd-8158-cb029242cf8c"), "03/13" },
                    { new Guid("fbb65fcf-2103-4cf5-85fa-bc3ebf25e01f"), "897", "4992284369835354", null, null, new Guid("a01a13e5-a8d1-4048-b8b2-24cdfac5f11e"), "12/13" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("fbd1e5d7-9961-43a8-94b7-9848c4c55cae"), "728", "6066005364355009", null, null, new Guid("c798d3b3-ea5a-4b3b-a69b-7022aa64fe86"), "03/20" },
                    { new Guid("fbdae0f1-83d3-4304-8538-dabf875dae89"), "288", "1279683436537946", null, null, new Guid("2a328a80-898f-4b62-921d-731137bebe9f"), "05/04" },
                    { new Guid("fcc2963b-579a-4e5c-bf22-8c1324c4f6d8"), "630", "6431733310718579", null, null, new Guid("17b956d2-133d-4289-8a76-4633e194bce0"), "05/20" },
                    { new Guid("fe27da11-a7d3-4135-a21c-2d420d08811f"), "583", "5002212444542136", null, null, new Guid("97d70a43-949c-4c03-9da7-fc16fdc0c86d"), "12/11" },
                    { new Guid("fe5ffcb9-cbec-4ae9-99ea-9e7964b2483b"), "142", "2317896033769579", null, null, new Guid("a3564d73-cc7f-45bf-bb8d-5bff9f9bd319"), "06/04" },
                    { new Guid("fea5f471-b414-4442-a9a7-eadd60addc1d"), "740", "3759951435963472", null, null, new Guid("777e0877-9079-4ecc-a52b-f0bf5734b939"), "09/12" },
                    { new Guid("ff0323e1-41ed-4782-801c-80cd01fcafef"), "844", "3876253320381330", null, null, new Guid("967d4ff4-7cca-4fd1-a75a-2f73aca9ca0a"), "04/08" },
                    { new Guid("ff7724d3-51c4-4656-b7fc-9cd7102ec962"), "485", "5541797720048120", null, null, new Guid("4ec972f7-f6d0-4660-943e-5ad3d2557cfe"), "03/08" },
                    { new Guid("ff8d8608-d151-4d58-8499-f12caf1a8f40"), "273", "2080296760812711", null, null, new Guid("ac2d4745-386c-4c13-a217-d9e2d9b842df"), "12/18" },
                    { new Guid("ffdc967b-9104-436f-9f01-c76bb5da9b7f"), "735", "5053829270609716", null, null, new Guid("9b8fcbcf-ce9d-40cf-aa2a-0543ebe6f135"), "03/20" }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("00d95184-f019-4162-b410-29b1d7e2c779"), null, null, "+313 82 (885) 42-02", new Guid("9fc4b18c-b710-43c3-be29-ffdea2c51975") },
                    { new Guid("00e9c607-98d9-4c0f-869c-a63443fc16e9"), null, null, "+635 30 (658) 53-88", new Guid("2eb253e8-852b-4b59-bbd3-41b1d962644b") },
                    { new Guid("01425ef0-0106-46e4-8704-aeab6add80c5"), null, null, "+103 64 (564) 72-54", new Guid("63ce22ac-8a36-4fb9-bf6d-61e02101f5d7") },
                    { new Guid("01550926-ae1d-4d2d-afe2-9f767bf2fae6"), null, null, "+392 65 (990) 05-71", new Guid("c1dedd78-34a2-4542-a585-a6ba740f5856") },
                    { new Guid("015e2726-2dec-4607-8a8e-461ee07941c3"), null, null, "+881 48 (862) 93-85", new Guid("b44b2dc0-6e21-4d7d-a788-6c4e66d96402") },
                    { new Guid("02ecb5a3-5f66-4fa4-a110-5df6ce5bc076"), null, null, "+648 37 (617) 14-32", new Guid("fc15fcf7-014b-4521-910c-8a4a05ae7df9") },
                    { new Guid("03793b06-1cd9-497f-b5b4-0413eb7b3866"), null, null, "+906 73 (109) 36-17", new Guid("5effd297-ddf3-4f40-afed-c85e49e3d248") },
                    { new Guid("03c07ae6-44fa-430d-b473-fadc30a3b705"), null, null, "+175 67 (910) 56-25", new Guid("9b0c9ef1-c568-4fc6-8e02-cbbb959e0bbb") },
                    { new Guid("03c954da-da8c-4b22-9117-0084939b72fe"), null, null, "+918 78 (363) 20-40", new Guid("25cda556-70c4-4bb2-ad33-871e7ca4939c") },
                    { new Guid("043dfd42-31c3-46c6-aa76-5fed5ce7594a"), null, null, "+743 04 (132) 48-98", new Guid("222dda98-6fd2-4619-8709-1b78c7872ca8") },
                    { new Guid("0461aca6-a8f9-4bbc-a523-2ed43e44058b"), null, null, "+174 77 (267) 31-11", new Guid("fc15fcf7-014b-4521-910c-8a4a05ae7df9") },
                    { new Guid("04aa8760-5297-4eaf-a6f6-945881456cdc"), null, null, "+181 35 (690) 58-72", new Guid("1546f9ad-e76e-4438-9513-2c0cdbcdc9dc") },
                    { new Guid("04cde5bf-4998-4231-8a7f-bc2360f7ad0a"), null, null, "+169 99 (129) 59-58", new Guid("e44b1f8c-951b-48de-a206-672ce80e3e29") },
                    { new Guid("0512808e-091f-4bec-bf19-3f6c3f3b248b"), null, null, "+67 31 (066) 77-48", new Guid("4ec972f7-f6d0-4660-943e-5ad3d2557cfe") },
                    { new Guid("052b2227-21f3-4965-83a3-a2b77d91f2a2"), null, null, "+748 03 (000) 04-25", new Guid("fd6ebc44-c70c-4ea5-ad8a-6029ee9c49d9") },
                    { new Guid("057fd563-164a-4b82-be72-9db29f2d7ec5"), null, null, "+570 43 (663) 84-50", new Guid("ad53394d-1d27-416a-92bf-5074f6fa4fc4") },
                    { new Guid("059fc087-d518-4271-ae00-8c7fa114ef35"), null, null, "+707 62 (802) 08-04", new Guid("655cd6fe-206e-4683-a0e5-f0108ee7f59f") },
                    { new Guid("0690269e-9c6e-4ca5-a987-8c140a032f89"), null, null, "+334 34 (715) 00-89", new Guid("7b354f95-20a6-4d69-abe1-b5a212feb069") },
                    { new Guid("070040db-683a-4bf2-98c6-f5996f54207f"), null, null, "+401 52 (699) 64-32", new Guid("b67eec58-0f42-4a35-a871-09c1ddaddd4b") },
                    { new Guid("073f5e19-7ffd-47b6-9c0b-8c8ff9103149"), null, null, "+70 61 (111) 08-38", new Guid("605efc2a-1846-428c-a520-3c8efbd1c5d8") },
                    { new Guid("076a3244-a82e-4c23-b906-e56c7ad7630a"), null, null, "+782 54 (638) 53-74", new Guid("24b96e86-5860-47b1-a6ec-9a832bafbb14") },
                    { new Guid("07b1e44a-ef7b-4580-b68f-2f937c3cf52d"), null, null, "+47 37 (670) 69-96", new Guid("166bcf97-6b8a-4025-ad11-df15241b0a24") },
                    { new Guid("07fa2e17-11a1-4317-92b9-54be824bfdfb"), null, null, "+742 71 (878) 63-03", new Guid("e44b1f8c-951b-48de-a206-672ce80e3e29") },
                    { new Guid("0812c5c0-305f-456d-bcc5-34f731eced20"), null, null, "+224 69 (609) 86-09", new Guid("7771e104-7d9f-4097-8375-a33ad264e1d8") },
                    { new Guid("08d420b0-6b61-40da-a58f-8e3566c98680"), null, null, "+813 03 (363) 38-16", new Guid("c4c17769-48f5-471b-ac8e-87a2c17573b4") },
                    { new Guid("0910a9bf-7a19-41cc-8e8c-38ecc8891961"), null, null, "+585 60 (098) 12-77", new Guid("d08dab84-c369-4193-b4fb-bbd252c59cc5") },
                    { new Guid("09727d06-a215-447b-bf9f-ef1353345019"), null, null, "+379 64 (988) 38-15", new Guid("4952ad1a-3fe2-4d0a-a38e-1e28e3808afd") },
                    { new Guid("09936855-bc23-4dba-9941-a7bd39a9a443"), null, null, "+304 81 (851) 33-78", new Guid("5a6031a7-d008-4d4c-9a87-857d42759454") },
                    { new Guid("0aecd92b-a1c0-451b-8cf9-b61ce4b8cd29"), null, null, "+935 24 (383) 27-89", new Guid("551cb7a5-2acf-469f-be65-7a549dccf51f") },
                    { new Guid("0b26942f-2762-4b5f-898a-2c7dd59476a6"), null, null, "+163 68 (771) 79-62", new Guid("7889ec96-3dce-40c9-a3d9-1dabf9642602") },
                    { new Guid("0b4fe235-2608-40a0-a01c-53ec4f271bf3"), null, null, "+890 26 (631) 06-01", new Guid("63bd6aad-fd4d-4a2d-b0ee-341253297e79") },
                    { new Guid("0b59c062-277a-4eeb-b5be-b513697abb08"), null, null, "+42 31 (168) 08-75", new Guid("70c04dec-2a46-4304-b6d1-c42204afdab9") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("0b8adaeb-d354-4c37-b779-0182ae923913"), null, null, "+797 32 (875) 62-33", new Guid("8e832b0b-a138-409b-b85d-4b68d03a07b6") },
                    { new Guid("0bd3459d-6564-4416-b8ea-98dad4c82140"), null, null, "+768 14 (951) 99-26", new Guid("bd5c667b-2bfc-46c6-814e-7b5c93be8f43") },
                    { new Guid("0bfce6de-27d0-40fc-a03e-96d7eb80e7c2"), null, null, "+552 18 (987) 96-11", new Guid("a8a8fdd8-4ded-4cee-9b8c-87f2285d7eab") },
                    { new Guid("0ca75743-e926-4785-882e-4b7ab4a91318"), null, null, "+522 74 (742) 34-42", new Guid("859757d1-9ad7-45f4-8664-764e0db29fec") },
                    { new Guid("0cabee17-fc3a-46de-8775-1f52d90c20e8"), null, null, "+409 00 (847) 46-51", new Guid("3a8ff431-6524-4268-ae59-91f87b944fae") },
                    { new Guid("0ce99c95-737c-4387-9982-4d05bfd7365e"), null, null, "+729 94 (298) 29-52", new Guid("967d4ff4-7cca-4fd1-a75a-2f73aca9ca0a") },
                    { new Guid("0d228611-fffe-4ab9-8900-252bedc6fed8"), null, null, "+512 06 (404) 93-66", new Guid("18314b53-d5e3-48fa-8ad6-dc84c3baa1ff") },
                    { new Guid("0d36a578-651c-4b62-af7a-2fa00983764e"), null, null, "+971 00 (615) 91-29", new Guid("c3f40de8-9c2b-4f97-b99a-a3d5f6431b27") },
                    { new Guid("0d4c8c94-a701-4473-a5ca-0c8aedbc95f5"), null, null, "+869 82 (747) 51-32", new Guid("88155035-c6f4-450c-bd25-3d3e9c9d8f5d") },
                    { new Guid("0da769cc-d08f-441a-9a8e-151b3ea16ec8"), null, null, "+988 46 (043) 15-41", new Guid("259e3939-18d5-4998-98ae-345c9d0fa279") },
                    { new Guid("0e18dd16-0383-4097-a93f-d054c854c5cf"), null, null, "+525 77 (609) 07-91", new Guid("146a249e-e614-41cc-98ab-d6287da977e5") },
                    { new Guid("0e584de7-44ac-48ab-9006-ebba14b8079a"), null, null, "+878 17 (987) 57-78", new Guid("d368ec62-a4a6-47b3-a955-fb176a32fe20") },
                    { new Guid("0eae79e2-47ab-477d-9d84-0c49f9f8c1bc"), null, null, "+717 88 (131) 87-50", new Guid("872eccf4-a3fa-43c5-ab2e-ac6f6c9e4f17") },
                    { new Guid("0ebf58fa-5c24-481f-a6bb-9f2623b67c0b"), null, null, "+836 14 (633) 06-71", new Guid("3705daaf-a245-497f-b245-acd05a008711") },
                    { new Guid("0ecbebd2-6d19-4768-8296-95cfe7a43e04"), null, null, "+536 88 (667) 65-08", new Guid("96389a1d-3bc8-465b-ba35-3027877a9981") },
                    { new Guid("0f08a624-cee1-4b9b-bfbb-1a842a57d539"), null, null, "+837 61 (232) 88-81", new Guid("3dd4bd2a-4dd8-4988-867a-99041eb6851d") },
                    { new Guid("0f0ccfdb-66b3-40fb-9268-96081419567c"), null, null, "+526 34 (414) 42-22", new Guid("4d792f39-989a-48bc-8528-2bda17a5967a") },
                    { new Guid("0f3fc7c4-99a5-417b-8d83-d0ec5c33f7b2"), null, null, "+744 66 (251) 42-14", new Guid("b9974b20-5b3f-4445-a6d7-c4352b53a64c") },
                    { new Guid("0fa04954-214d-4eac-83db-0a093531bf34"), null, null, "+468 60 (725) 48-82", new Guid("91024531-3bc9-4397-868c-67a81b4abcfc") },
                    { new Guid("0fad119e-1951-457c-8d7b-b151ed9ecd54"), null, null, "+462 25 (623) 28-25", new Guid("db79e848-cfae-4c0f-8859-e5d6af4a311c") },
                    { new Guid("0fc494d1-ff80-494c-9704-3a470d8e9b94"), null, null, "+809 50 (462) 94-55", new Guid("cb8696d4-d2d5-40c3-b74f-38aafecd34f8") },
                    { new Guid("0ff7a017-c218-4e07-9fc9-981f703e8ae5"), null, null, "+453 27 (871) 41-19", new Guid("34d672c5-050e-4c3c-8018-0107a72f13f5") },
                    { new Guid("106e0168-55d8-471e-8bd7-2f9290ce9786"), null, null, "+43 27 (265) 28-87", new Guid("5ffbbdb6-b588-4eef-811a-4b39d217f0a8") },
                    { new Guid("108c2fd8-79c7-46d9-9b96-4f4f5694701f"), null, null, "+715 28 (431) 43-94", new Guid("3ca63884-385c-4ae8-ac07-f3dc2df24aae") },
                    { new Guid("109a0548-57a4-4b57-b192-b16aca2fc5de"), null, null, "+889 56 (643) 86-16", new Guid("ac2d4745-386c-4c13-a217-d9e2d9b842df") },
                    { new Guid("1252370b-698f-4775-8463-ee85e1f1b9c2"), null, null, "+717 03 (861) 08-59", new Guid("4bffa9b9-a7ae-4dd6-b87b-dbcad3737bfd") },
                    { new Guid("1264afe5-4a30-4457-a5b5-bb5c2ce123c1"), null, null, "+619 64 (806) 43-56", new Guid("8606d3d5-5f3e-4f9a-b953-4be892f06c0d") },
                    { new Guid("12709ea4-6b54-4649-872b-2aa7f78a34d1"), null, null, "+751 62 (235) 80-81", new Guid("b9974b20-5b3f-4445-a6d7-c4352b53a64c") },
                    { new Guid("127f0427-df1d-4b9a-bac0-5d03d746695d"), null, null, "+637 91 (200) 72-05", new Guid("aee768a4-2b67-47da-a692-ab2b1cd95c27") },
                    { new Guid("1293dff9-1d19-4fe5-ac2e-e98a44dabb6b"), null, null, "+77 79 (898) 25-93", new Guid("d0627291-bbf2-408e-bc02-9ba09faa06bd") },
                    { new Guid("1294f726-03df-4a52-b22f-04489afc16e0"), null, null, "+668 81 (171) 39-12", new Guid("d666c5aa-5c03-4391-8629-5cc681422ca2") },
                    { new Guid("12b30baa-d9d8-4b5e-b22d-95b3094cc5de"), null, null, "+132 56 (816) 09-73", new Guid("d08dab84-c369-4193-b4fb-bbd252c59cc5") },
                    { new Guid("12c2a871-25df-48bb-afc9-9b62d6a5e534"), null, null, "+982 88 (845) 42-38", new Guid("b71f69da-e20d-4b25-b2fb-00d5eb1c9002") },
                    { new Guid("133ccdac-66c4-4903-bbc4-d6626757c9a4"), null, null, "+51 01 (980) 89-57", new Guid("284afcd2-63de-4550-906f-0a1ce11e8244") },
                    { new Guid("135bef47-d6af-4e1c-b5db-90c873801897"), null, null, "+832 35 (888) 43-18", new Guid("9b8fcbcf-ce9d-40cf-aa2a-0543ebe6f135") },
                    { new Guid("139c029c-e9b6-4931-a19b-3292db5a1b77"), null, null, "+268 50 (106) 34-19", new Guid("9f331cb7-b70d-434b-bc28-147a5e624fd8") },
                    { new Guid("13dd4c73-fdd1-4c44-9143-d723bd93d1b7"), null, null, "+126 85 (833) 04-37", new Guid("dc04df94-1448-4899-bec4-692b13ea2748") },
                    { new Guid("13ecff21-c3c7-4257-b2f2-82775dbc2b1a"), null, null, "+115 43 (160) 30-57", new Guid("96389a1d-3bc8-465b-ba35-3027877a9981") },
                    { new Guid("1408963b-6456-43a9-8ebf-8d524a9b1ee2"), null, null, "+118 40 (242) 22-76", new Guid("d184b2bf-159f-4b4e-83e0-4f0bb6184d14") },
                    { new Guid("141b98c7-5ae4-4e33-9488-8f0ad2e17d6f"), null, null, "+528 66 (337) 08-92", new Guid("11ddb06c-1f4a-4028-b37b-6ad05ae5f7d5") },
                    { new Guid("146aa23b-4814-40f8-a41a-bae53247a8b0"), null, null, "+13 13 (257) 46-07", new Guid("5effd297-ddf3-4f40-afed-c85e49e3d248") },
                    { new Guid("149c5811-d7eb-4038-abb9-22855385996f"), null, null, "+763 81 (382) 25-46", new Guid("fc7807f7-2e15-4c19-8500-ea40f337d9de") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("14e3cf99-7950-4f0a-b4aa-51f46dbcbe9e"), null, null, "+573 45 (651) 56-08", new Guid("49922094-de40-49f9-8fe5-21e734ddaadc") },
                    { new Guid("1529d28f-e114-4e6f-b72f-9542b452e126"), null, null, "+112 08 (810) 49-74", new Guid("8606d3d5-5f3e-4f9a-b953-4be892f06c0d") },
                    { new Guid("15c28d65-f5ea-44f2-9e5b-7abc8658e89f"), null, null, "+542 48 (520) 92-80", new Guid("93ac31b1-6465-45d3-b0b5-98811dbc77b4") },
                    { new Guid("160a0164-5a38-4f72-8185-d19a5751a34c"), null, null, "+228 86 (771) 15-33", new Guid("2063153a-a610-4c40-9ddd-456ef0b560db") },
                    { new Guid("16281d0e-d2cb-4135-9048-da3df875d2ad"), null, null, "+355 79 (210) 15-07", new Guid("d0fc0768-b3a0-4f82-affc-e355dc4101f4") },
                    { new Guid("1642515d-f543-4106-b775-d4075ff7473a"), null, null, "+789 62 (550) 21-72", new Guid("b50df756-e4ca-4115-a962-e283f6b8d317") },
                    { new Guid("1643ce97-43d2-4316-b3b2-4c4b1cd865b7"), null, null, "+594 39 (284) 29-32", new Guid("57041776-9144-494f-9e92-9c9da3135eab") },
                    { new Guid("16622833-0363-4fdc-9223-e4bbc2f6f7d7"), null, null, "+279 42 (003) 01-30", new Guid("ce4c448e-35a5-4243-aa12-b967d2b3da6f") },
                    { new Guid("16a6f7c9-14fa-49e7-a616-bf4d98ad2801"), null, null, "+700 96 (497) 95-94", new Guid("641c3d4a-a6ff-4cb3-b40a-665b9156a255") },
                    { new Guid("16edd6d1-18ee-4a09-9fe0-9e30a1e8ac93"), null, null, "+573 35 (058) 20-73", new Guid("a161bc80-bb44-439e-bb80-442569d93b23") },
                    { new Guid("16fb3ae2-88af-49b3-a3dd-389321f6521a"), null, null, "+368 92 (788) 92-68", new Guid("db79e848-cfae-4c0f-8859-e5d6af4a311c") },
                    { new Guid("17639d6a-eda8-4c94-b6b9-8e6c036b95ae"), null, null, "+221 79 (898) 73-55", new Guid("69879006-dc0c-45ee-a1d8-571618a19f4d") },
                    { new Guid("176e1e1e-a554-45ea-9d52-13a9fb9db6a3"), null, null, "+995 37 (802) 44-92", new Guid("d8dd96ce-4557-4993-959c-45a29c967d51") },
                    { new Guid("178e1e5a-5984-4c24-ae21-7fdc45bd51f2"), null, null, "+924 85 (817) 82-79", new Guid("a161bc80-bb44-439e-bb80-442569d93b23") },
                    { new Guid("17a90708-b468-4eb5-8404-cd713052e697"), null, null, "+389 32 (132) 35-75", new Guid("5560fdd3-3041-418a-bdbd-b1b7cb595a87") },
                    { new Guid("17b69431-ca4f-45a5-a007-efe3c04d4004"), null, null, "+8 66 (470) 10-10", new Guid("63bd6aad-fd4d-4a2d-b0ee-341253297e79") },
                    { new Guid("17cdec71-bad8-48b8-a266-8b90afbbad6c"), null, null, "+208 95 (662) 32-36", new Guid("d9295c19-5c11-40bb-ba7c-c1b368114ac0") },
                    { new Guid("181718b0-e5a2-4d6b-a2c2-a6335b4c9b63"), null, null, "+601 42 (586) 32-79", new Guid("c431ef46-de70-4dba-a2b4-061b2a219ebc") },
                    { new Guid("181aa849-14ab-4d1e-99e1-d0e14e26c1fe"), null, null, "+840 24 (292) 90-55", new Guid("17b956d2-133d-4289-8a76-4633e194bce0") },
                    { new Guid("183b31d5-dee9-435c-9b53-4d02d8c73fe4"), null, null, "+584 92 (709) 28-12", new Guid("c60620ff-d62e-4585-9510-ed612aa89dcb") },
                    { new Guid("183e37e6-d11c-462a-b121-7424e8b6456e"), null, null, "+558 75 (270) 23-51", new Guid("c50f147c-0804-4f38-a70a-7b8d4109234d") },
                    { new Guid("18d35383-37e0-4c74-b65a-0bad25ee54a5"), null, null, "+349 49 (596) 06-49", new Guid("02df2ae2-d7d0-47a4-aeae-e733e06bb1d0") },
                    { new Guid("18e3cdb0-5e33-4a09-9845-23cff7862a69"), null, null, "+485 07 (975) 96-13", new Guid("9b0c9ef1-c568-4fc6-8e02-cbbb959e0bbb") },
                    { new Guid("19ad3e4f-1633-46de-883b-4f3e0ed94a2e"), null, null, "+487 51 (420) 52-64", new Guid("0a69540b-ce9e-427c-8970-9f311fba0c21") },
                    { new Guid("19ca4f11-8831-4028-8fed-3906b4bd9ffe"), null, null, "+614 52 (310) 30-09", new Guid("437bc41c-af0d-4443-809f-276b155b8846") },
                    { new Guid("19d660f2-5126-4bb0-9431-3a399b65154b"), null, null, "+106 96 (061) 14-02", new Guid("b5fe6c30-5f2d-462b-9dd2-bc5388f99ce5") },
                    { new Guid("1a74c196-1291-4ee4-90d9-eec9a8c4e950"), null, null, "+843 37 (170) 73-55", new Guid("427485d5-0faa-4f9a-9c6f-70317d50831a") },
                    { new Guid("1b00bf90-f3b5-4f0a-81de-b576a5e13a89"), null, null, "+859 33 (027) 82-08", new Guid("7889ec96-3dce-40c9-a3d9-1dabf9642602") },
                    { new Guid("1b0f5df2-5a86-4c56-9bb6-b95d95628c6d"), null, null, "+648 94 (548) 84-85", new Guid("cf6839a1-51b8-4ec5-bfec-3cbe48c20160") },
                    { new Guid("1b351a03-4822-46bb-a998-c06fa186e381"), null, null, "+476 91 (228) 50-90", new Guid("25cda556-70c4-4bb2-ad33-871e7ca4939c") },
                    { new Guid("1b897b87-d64f-47f0-80ea-667ca4157c48"), null, null, "+207 95 (096) 11-04", new Guid("7e5e5ebc-3d4d-451a-884b-00a9d9f53676") },
                    { new Guid("1bad424c-80d3-4004-a7ed-1794a62c3f45"), null, null, "+799 19 (589) 90-19", new Guid("e188b38e-8056-446d-96c9-b8979c4fd471") },
                    { new Guid("1bd7fb12-5f4b-451d-bca4-dc734faef68e"), null, null, "+405 29 (284) 37-51", new Guid("7b9acf5a-1eec-4436-8152-103e38ca0953") },
                    { new Guid("1cbbafbc-7814-4b37-9861-d22588b728f1"), null, null, "+500 80 (450) 18-57", new Guid("6375150d-9633-494e-ba79-b55f87d56afa") },
                    { new Guid("1d43e55b-b242-4d6f-85c8-107ed30581cc"), null, null, "+903 09 (939) 31-34", new Guid("6dcb62c8-dc29-4e18-aabc-b9f4d6f3d1ce") },
                    { new Guid("1d6ed1e3-8234-4efe-91c8-ace39640013c"), null, null, "+109 73 (797) 21-79", new Guid("94e92894-3b19-4c5f-9e95-0ec52116ec92") },
                    { new Guid("1de9b831-8d64-47db-a41e-62487ed8d340"), null, null, "+167 44 (372) 29-99", new Guid("93b22657-e430-4b16-b1f2-af9b44bd9175") },
                    { new Guid("1e894215-f4a9-44a3-86e0-54809d34f998"), null, null, "+792 09 (206) 56-31", new Guid("568a5cfd-171b-413d-addf-fe6ab58aa6d0") },
                    { new Guid("1e942178-75a9-4ee5-b1e7-433645512acf"), null, null, "+641 04 (044) 28-64", new Guid("749d009d-0557-4289-976a-50a7e345a281") },
                    { new Guid("1eab2748-e388-4f31-b45a-1333d189e87e"), null, null, "+895 68 (447) 68-78", new Guid("26ad372f-ab3d-49d6-a283-d78f71a0b97b") },
                    { new Guid("1ef686e4-0505-4f21-9276-cf265889e437"), null, null, "+689 48 (375) 72-22", new Guid("ca9a7100-5d5c-406e-8028-d065cd21c772") },
                    { new Guid("1f2ccf0f-5ef1-428c-a9fe-347447e45445"), null, null, "+942 02 (450) 52-22", new Guid("b070b87c-5a28-4f27-8f54-9238dfbe5c79") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("1fcf3459-a96e-4d39-9e54-794482f5ed9c"), null, null, "+786 26 (461) 27-12", new Guid("da687a7e-bca5-449f-ad43-32e0ac00fe15") },
                    { new Guid("1fe56b01-53b2-4d26-86e2-4b90873a2fe7"), null, null, "+133 22 (492) 64-58", new Guid("0ffea79c-1eaa-4ef4-b27f-e6c525534682") },
                    { new Guid("20320942-0a17-4820-9f06-f693380a6605"), null, null, "+161 04 (418) 15-67", new Guid("960fe293-a56c-42c1-b68b-57d1e361fe6d") },
                    { new Guid("20774e60-b0b8-4014-8a75-3ae2a8a35d49"), null, null, "+315 44 (206) 43-11", new Guid("4e8bea3b-5b3c-4c9c-b874-2c8b16d90db2") },
                    { new Guid("20aba5cf-9bab-469b-96a0-e32ee5f1b2b4"), null, null, "+188 18 (939) 46-98", new Guid("9eb02965-fa79-4bc7-940e-eff714a39f7e") },
                    { new Guid("20b5f896-bbd4-484c-9646-1b2ccf246f6d"), null, null, "+44 84 (477) 39-65", new Guid("9a38b671-5580-4658-abf4-c1fc9ce2be0b") },
                    { new Guid("21ec7e3a-fa3b-4b08-8b8a-63dc71b5c0ba"), null, null, "+839 47 (474) 63-56", new Guid("71ef850e-2fd5-4538-9b05-9c38cbbdbe30") },
                    { new Guid("223e7eb5-2712-4c74-b9b5-e01efaf48d8a"), null, null, "+447 55 (557) 59-84", new Guid("69879006-dc0c-45ee-a1d8-571618a19f4d") },
                    { new Guid("227c50e0-d89e-4a85-a483-757602b1f89b"), null, null, "+951 04 (590) 57-76", new Guid("1d118b7f-07b1-49dd-9f7d-5a1e7d8ea4bc") },
                    { new Guid("2373b4db-401d-4e0e-aeb4-f6e2bfb871a4"), null, null, "+281 76 (411) 55-08", new Guid("be18d868-cfef-46af-89ea-769a3c24c7da") },
                    { new Guid("238202bb-878a-4bf7-8f83-2e985155ed1c"), null, null, "+346 45 (263) 44-77", new Guid("15cc8bf6-f5ac-435e-a654-84e10e29a1bd") },
                    { new Guid("238cce06-9cbf-4887-a154-89e4e9270dd5"), null, null, "+458 14 (715) 14-93", new Guid("c8db4c48-87fc-43bc-b9ef-e88e6764800d") },
                    { new Guid("24202200-05d1-4f56-b450-a65cb3ebe895"), null, null, "+783 98 (101) 72-52", new Guid("8bbc88c0-c35c-496f-b3fc-e18f3d8bad18") },
                    { new Guid("24adc879-e4ae-4090-a9c8-b10c317c4325"), null, null, "+507 46 (964) 18-90", new Guid("3dc1a6db-3bf2-4650-b501-abf7ef284b3c") },
                    { new Guid("24b74cd8-5a40-49f5-afa4-62d2071ce02d"), null, null, "+792 31 (774) 37-21", new Guid("6172d849-4ee5-486f-8f97-d2bbcfc40084") },
                    { new Guid("254fec41-6827-4298-bec2-fb385950a26b"), null, null, "+189 71 (126) 20-78", new Guid("cc549d3d-c127-48fe-9320-69c0367cf0ef") },
                    { new Guid("259d27c5-25aa-4028-a5ce-05b6a06aac80"), null, null, "+283 13 (423) 49-00", new Guid("69879006-dc0c-45ee-a1d8-571618a19f4d") },
                    { new Guid("25ad955a-40a6-4d51-8691-44ae0c0d47e8"), null, null, "+356 51 (658) 67-37", new Guid("cfc77b46-5660-4e53-bd9c-0ef309097b43") },
                    { new Guid("25af597a-ecd1-4c85-8746-2b37571bc540"), null, null, "+680 47 (656) 05-07", new Guid("93b22657-e430-4b16-b1f2-af9b44bd9175") },
                    { new Guid("26538f6e-d063-404b-b6ce-77540b25c7bd"), null, null, "+303 03 (920) 76-38", new Guid("2a328a80-898f-4b62-921d-731137bebe9f") },
                    { new Guid("272cbc10-c378-4056-b99b-cf892f6d6f24"), null, null, "+749 17 (829) 12-23", new Guid("a6b4e3da-0d2b-4dbd-9f10-ea183f9d6225") },
                    { new Guid("2782a991-dba1-4e1b-a2a8-1172fcf61a71"), null, null, "+405 38 (341) 74-09", new Guid("91024531-3bc9-4397-868c-67a81b4abcfc") },
                    { new Guid("2790223a-5530-4845-ab41-58ffc316fb4a"), null, null, "+238 71 (586) 46-83", new Guid("f9c15c1c-b6bd-46fd-921b-e1778f14dacf") },
                    { new Guid("2799605a-262c-4fc1-bfa0-598b533dd442"), null, null, "+714 37 (824) 85-70", new Guid("e9781110-3553-481f-bb3a-7ca26a63a83b") },
                    { new Guid("27fa99b8-3724-428b-a3ed-471b4cf66368"), null, null, "+216 10 (380) 34-09", new Guid("c8db4c48-87fc-43bc-b9ef-e88e6764800d") },
                    { new Guid("27fbde31-21a6-4fcc-aabf-f377be6f5e6b"), null, null, "+437 31 (579) 53-87", new Guid("34d672c5-050e-4c3c-8018-0107a72f13f5") },
                    { new Guid("28174fc5-dffc-4999-bc40-c2e1a5525768"), null, null, "+615 98 (878) 34-60", new Guid("91024531-3bc9-4397-868c-67a81b4abcfc") },
                    { new Guid("2897559d-9f2c-4a67-9803-cc9644d20b6a"), null, null, "+911 12 (771) 67-40", new Guid("eddb3b35-4415-4828-97b3-fd737f127090") },
                    { new Guid("28deacc0-6ab3-4599-9529-5e0f04c345e7"), null, null, "+53 23 (673) 00-22", new Guid("5a6031a7-d008-4d4c-9a87-857d42759454") },
                    { new Guid("28ffe95b-ca17-4d05-b2b4-23f30d003977"), null, null, "+227 77 (266) 24-03", new Guid("b2a11489-a556-462e-9631-1108d9049fcc") },
                    { new Guid("2976975c-cd70-4ef6-a5a0-bd6e75c7ad1b"), null, null, "+749 45 (910) 27-89", new Guid("620337a7-cc3b-43d5-aef4-5b29e97ab466") },
                    { new Guid("297a8fdc-032d-477d-904c-796afd96ed78"), null, null, "+28 64 (834) 46-39", new Guid("ca7879c0-456f-4a95-94ad-0a58b61bfc27") },
                    { new Guid("2a939372-2647-4054-b32c-f1825780c425"), null, null, "+18 98 (253) 83-65", new Guid("be18d868-cfef-46af-89ea-769a3c24c7da") },
                    { new Guid("2aa80e15-a458-4854-87b0-c2dc3d9a9a7e"), null, null, "+457 50 (712) 55-46", new Guid("4a254852-2316-4300-99be-6d54e3eeac93") },
                    { new Guid("2aeb44bc-5ec7-4d8b-85c8-d648c97310be"), null, null, "+309 81 (781) 44-30", new Guid("22c74cee-2548-4aef-ab56-019f64d2fb3e") },
                    { new Guid("2afdba98-6b3e-41c9-8ccb-7afb64d9a368"), null, null, "+610 88 (100) 38-21", new Guid("3aa0613b-0255-46fa-9fc9-f73e67ec6962") },
                    { new Guid("2bc04500-9781-4d4f-9f3a-68ae51120098"), null, null, "+961 92 (123) 57-45", new Guid("ca9a7100-5d5c-406e-8028-d065cd21c772") },
                    { new Guid("2bd037da-c159-4c8c-b596-451770df4d0b"), null, null, "+898 65 (542) 53-35", new Guid("4952ad1a-3fe2-4d0a-a38e-1e28e3808afd") },
                    { new Guid("2c0d5526-513a-4864-8198-02af3e044f41"), null, null, "+460 10 (224) 50-09", new Guid("ad53394d-1d27-416a-92bf-5074f6fa4fc4") },
                    { new Guid("2d1dc8ed-c6fd-420f-a6fd-97f9493c7fa4"), null, null, "+155 29 (360) 85-32", new Guid("8dd6a489-4514-4244-9fa7-a1490970f38b") },
                    { new Guid("2d2fa416-5ba1-4e60-af1c-f72b89a8e789"), null, null, "+167 76 (400) 73-23", new Guid("5e0e0eed-1c83-4b51-8938-5bab69316dab") },
                    { new Guid("2d7728a0-0638-47d6-b3ee-3b8da365a0cd"), null, null, "+979 61 (231) 65-31", new Guid("3ca63884-385c-4ae8-ac07-f3dc2df24aae") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("2d991445-234e-4226-b2e0-256f9078f405"), null, null, "+946 84 (171) 06-64", new Guid("7805e438-4982-4f20-9e68-baca0c631417") },
                    { new Guid("2e69cb4c-8e66-4505-a4fb-d9cb8d5a8edd"), null, null, "+537 92 (300) 96-72", new Guid("9f331cb7-b70d-434b-bc28-147a5e624fd8") },
                    { new Guid("2f08d59f-7aed-40bb-8022-e5be40f5f31e"), null, null, "+425 64 (269) 53-56", new Guid("d184b2bf-159f-4b4e-83e0-4f0bb6184d14") },
                    { new Guid("2f8c23bb-94f6-4688-953e-d949d9194c74"), null, null, "+739 76 (947) 71-51", new Guid("2063153a-a610-4c40-9ddd-456ef0b560db") },
                    { new Guid("2fb36c20-9218-4d27-a9a8-90dfb3b2c2c8"), null, null, "+211 45 (912) 40-48", new Guid("69536a6d-5fc0-40dc-96ff-96cfa2e2ddde") },
                    { new Guid("30310e14-0473-4381-9834-e0cb793d0e5f"), null, null, "+526 42 (462) 51-17", new Guid("6172d849-4ee5-486f-8f97-d2bbcfc40084") },
                    { new Guid("30690d23-3598-4836-b36d-d2497e90086b"), null, null, "+330 20 (238) 61-79", new Guid("62f9c608-cb23-46fa-a1c4-304e5c65aec1") },
                    { new Guid("3076aac4-af2a-463f-86a5-5aad3653b92d"), null, null, "+837 50 (874) 34-22", new Guid("a01a13e5-a8d1-4048-b8b2-24cdfac5f11e") },
                    { new Guid("3195cd2e-7a21-45d1-ab19-ea2f1fadd6c6"), null, null, "+177 29 (403) 37-69", new Guid("97d70a43-949c-4c03-9da7-fc16fdc0c86d") },
                    { new Guid("32283e19-4f35-47fe-966a-c2371ea6b7d4"), null, null, "+578 80 (196) 16-45", new Guid("fc7807f7-2e15-4c19-8500-ea40f337d9de") },
                    { new Guid("322c6a4e-7954-497f-b1a4-e2190b36d8bd"), null, null, "+389 60 (204) 10-05", new Guid("51655f73-efc8-4142-b1ea-1657e4fc0f2e") },
                    { new Guid("32388f25-c6be-49e5-95ac-d2b44f877d03"), null, null, "+640 98 (536) 89-48", new Guid("9e73d492-68df-4c26-bbd7-c238340416ec") },
                    { new Guid("327b1a81-107e-4154-8eb1-f0b0b853e80f"), null, null, "+832 96 (714) 52-25", new Guid("f7f7b1e1-146a-4f33-9556-99419aa87dbb") },
                    { new Guid("331b3728-245e-4872-af49-cc6b103e594f"), null, null, "+195 12 (532) 04-77", new Guid("7771e104-7d9f-4097-8375-a33ad264e1d8") },
                    { new Guid("337b026a-35cb-4b3b-aa63-64f67b38e922"), null, null, "+486 05 (261) 51-71", new Guid("73850497-d7e2-4015-bf80-d8fc761772d3") },
                    { new Guid("344ecb0b-7b6c-4642-8e34-55ec818f2659"), null, null, "+214 68 (417) 41-93", new Guid("a6fc0423-6291-4866-8d02-6faea1986c4e") },
                    { new Guid("3458a358-074e-47f3-82ea-abc199fdd3e3"), null, null, "+393 25 (812) 22-65", new Guid("437bc41c-af0d-4443-809f-276b155b8846") },
                    { new Guid("348afd15-e6e9-4523-9dea-865a14631927"), null, null, "+906 76 (264) 12-26", new Guid("89c19062-b085-4717-8960-680ec5f619e0") },
                    { new Guid("348cc1c4-2c38-4536-be13-cc2619faafba"), null, null, "+850 10 (711) 35-08", new Guid("5e2d266d-c2a4-4711-b57e-3656b61d6ad2") },
                    { new Guid("34c7c206-6354-4ef5-9b9a-09e01db128b4"), null, null, "+788 71 (100) 54-01", new Guid("a01a13e5-a8d1-4048-b8b2-24cdfac5f11e") },
                    { new Guid("34ea9945-510b-4df5-aea1-ea9e6c87bd41"), null, null, "+376 50 (781) 79-81", new Guid("092e31f3-9b9a-4287-8cae-7fcd18feab47") },
                    { new Guid("34f91e90-8afc-454f-9052-6871f7930442"), null, null, "+475 01 (027) 63-09", new Guid("ffdf2e3d-14e1-47fc-a87f-43ee44597c72") },
                    { new Guid("34fd442b-ef32-41d7-926d-de7f05f37ffa"), null, null, "+873 43 (596) 16-63", new Guid("6507f7f4-4076-4fff-b89e-4205b52b6408") },
                    { new Guid("355d17a6-e0ec-479a-bb88-6356fa766f4c"), null, null, "+820 03 (397) 18-72", new Guid("d0fc0768-b3a0-4f82-affc-e355dc4101f4") },
                    { new Guid("35736666-8aee-4736-96aa-ed2dc61c5e4b"), null, null, "+609 70 (120) 91-15", new Guid("997402b2-514c-445f-9988-ae18a101181e") },
                    { new Guid("3592903e-4802-41eb-b52c-c2d4f210ad90"), null, null, "+191 75 (848) 93-50", new Guid("2eb253e8-852b-4b59-bbd3-41b1d962644b") },
                    { new Guid("35df808c-362d-4816-8a0c-a087a943a262"), null, null, "+488 03 (951) 31-94", new Guid("8bbc88c0-c35c-496f-b3fc-e18f3d8bad18") },
                    { new Guid("35e326e9-9e20-42f8-8133-9544320d9731"), null, null, "+754 64 (900) 68-56", new Guid("c561cc5e-190d-4a91-8ea9-d03583fa3f86") },
                    { new Guid("35f4a6e8-5f6d-4c54-9a95-173ca55919a2"), null, null, "+428 28 (266) 47-66", new Guid("a165efc8-0956-4593-9333-e1ab17939488") },
                    { new Guid("36b0c163-a805-461b-a61c-1b475b518ebc"), null, null, "+167 96 (037) 28-70", new Guid("2063153a-a610-4c40-9ddd-456ef0b560db") },
                    { new Guid("36eb7199-013d-41fd-8aa6-9f7e52b5d440"), null, null, "+441 16 (430) 62-53", new Guid("d368ec62-a4a6-47b3-a955-fb176a32fe20") },
                    { new Guid("376f536a-e075-4aba-b6ea-3baf12b6ccf4"), null, null, "+422 11 (248) 80-24", new Guid("9a799371-7ad4-44c8-bcc3-759981e1573a") },
                    { new Guid("37a06893-ef4a-4601-a899-bb110eca8e5f"), null, null, "+974 72 (856) 07-53", new Guid("4ec972f7-f6d0-4660-943e-5ad3d2557cfe") },
                    { new Guid("3821c8ab-eec4-4d03-8598-d15c9fa8f87a"), null, null, "+411 60 (004) 60-62", new Guid("abff8b44-2e47-47cd-8158-cb029242cf8c") },
                    { new Guid("382e7cbf-4265-4495-ac37-825d7e4e82ec"), null, null, "+405 12 (983) 57-96", new Guid("94e92894-3b19-4c5f-9e95-0ec52116ec92") },
                    { new Guid("38810794-4475-4998-986f-88cc7f5d5de6"), null, null, "+934 05 (313) 34-39", new Guid("2f7c84d9-6fe2-4a1c-ba84-c8d43feade58") },
                    { new Guid("38bf7f4b-1352-4a3b-88eb-fd9a0c5020cf"), null, null, "+27 40 (779) 49-81", new Guid("abf3ceb3-3421-4454-9686-7b4c13cd1fbf") },
                    { new Guid("391359e3-9c9b-4f75-9729-dbdc56a1439d"), null, null, "+530 95 (040) 49-50", new Guid("f7f7b1e1-146a-4f33-9556-99419aa87dbb") },
                    { new Guid("39ba73c7-64e9-46eb-af54-410c9e5518c4"), null, null, "+264 99 (035) 90-84", new Guid("ef14d144-d1c3-49fb-9e25-1889be79f4e3") },
                    { new Guid("39fbc3ae-895b-42d9-b193-0ce77549981e"), null, null, "+250 02 (966) 75-49", new Guid("68fd726f-e5e4-4755-a477-4727a0a9f4b8") },
                    { new Guid("3a28417b-2c6d-4b09-864c-d91ae68db00b"), null, null, "+392 82 (724) 80-87", new Guid("e2dba597-b132-4b1a-a46f-540ebc581408") },
                    { new Guid("3a30e736-42d9-4d95-b695-3e4ee970aed8"), null, null, "+172 94 (590) 00-93", new Guid("551cb7a5-2acf-469f-be65-7a549dccf51f") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("3a745c01-cb84-4227-8caa-4ca7942187de"), null, null, "+808 62 (157) 35-19", new Guid("0a69540b-ce9e-427c-8970-9f311fba0c21") },
                    { new Guid("3adb5fcd-d9b5-4ee3-801d-a9dc25f48f19"), null, null, "+475 55 (467) 22-63", new Guid("77332645-fb25-478f-998c-36dd38aaba91") },
                    { new Guid("3b9a93f3-d8c6-462d-8461-41d9c4d2a40b"), null, null, "+804 35 (051) 78-18", new Guid("e27f9603-32f8-4066-bf07-4ab692c8350b") },
                    { new Guid("3c1eaa7e-68b9-40cf-9ecd-4264109b6438"), null, null, "+134 98 (690) 34-17", new Guid("b070b87c-5a28-4f27-8f54-9238dfbe5c79") },
                    { new Guid("3c82f43b-78df-472e-88d0-d39d989b3eeb"), null, null, "+73 88 (470) 82-82", new Guid("96389a1d-3bc8-465b-ba35-3027877a9981") },
                    { new Guid("3cf75ba9-3a87-4f0a-a49e-701c8250a89f"), null, null, "+138 24 (129) 45-56", new Guid("2a328a80-898f-4b62-921d-731137bebe9f") },
                    { new Guid("3d3bc54c-5db6-4aa2-b4ca-ec290fe490df"), null, null, "+791 79 (542) 61-67", new Guid("2a328a80-898f-4b62-921d-731137bebe9f") },
                    { new Guid("3d48e001-ce00-48d2-9390-e4b8d07d576c"), null, null, "+430 35 (757) 80-22", new Guid("17441686-0fa5-4e5d-b680-2d5708a2ecd5") },
                    { new Guid("3e0f9e23-b14a-4d6a-bbff-5d08ef6b372a"), null, null, "+839 56 (248) 65-65", new Guid("d0fc0768-b3a0-4f82-affc-e355dc4101f4") },
                    { new Guid("3eb94653-0528-495b-a61d-254a6f5c2cfd"), null, null, "+92 12 (814) 24-95", new Guid("b2a11489-a556-462e-9631-1108d9049fcc") },
                    { new Guid("3f6699ee-eaca-44d0-8b17-fe697093eddb"), null, null, "+719 79 (432) 69-77", new Guid("6dcb62c8-dc29-4e18-aabc-b9f4d6f3d1ce") },
                    { new Guid("3fcedc26-fc1a-4aa1-bb7b-2b902230123d"), null, null, "+333 39 (808) 98-73", new Guid("72b9b70e-980c-47d3-a949-0b0acbdbe9f3") },
                    { new Guid("3fd9a75b-45f1-4033-bd13-3a1bc89fdd5d"), null, null, "+775 97 (831) 21-91", new Guid("dd2a73f4-0d43-45df-8aa0-196122e00fc2") },
                    { new Guid("3fdc8475-0b57-42bb-bebb-2de352601b8b"), null, null, "+390 91 (657) 24-48", new Guid("ef100efa-deb4-4516-9a15-38df8ff7e396") },
                    { new Guid("40149f3e-50d5-4267-9b74-9502ea057d79"), null, null, "+286 51 (557) 34-87", new Guid("ef100efa-deb4-4516-9a15-38df8ff7e396") },
                    { new Guid("401d0dfe-a44a-49a2-b247-549e16d10543"), null, null, "+680 71 (051) 57-39", new Guid("f472d28b-1df9-4c84-8ceb-3254f55042e7") },
                    { new Guid("40799e13-f935-4d96-b700-c00fc19cb332"), null, null, "+579 93 (077) 63-10", new Guid("17b956d2-133d-4289-8a76-4633e194bce0") },
                    { new Guid("4091af2c-d6ea-4331-92d9-76c2a0d611fc"), null, null, "+644 95 (621) 28-94", new Guid("7889ec96-3dce-40c9-a3d9-1dabf9642602") },
                    { new Guid("40b1eefc-5a60-4919-af48-b9629d4b418f"), null, null, "+650 10 (798) 77-75", new Guid("0768641f-3440-4d72-a350-3b2eca842a26") },
                    { new Guid("40bf9f6d-35a9-4b4b-be28-75d4af90dee8"), null, null, "+823 10 (410) 78-16", new Guid("6709762d-580f-4c32-8f92-b1daa6e22c27") },
                    { new Guid("411185e5-6797-4902-827d-8c24383aed41"), null, null, "+405 71 (955) 70-35", new Guid("25a47446-d397-4805-8427-d3185a6d35b7") },
                    { new Guid("413dac46-8345-42df-977b-2ecd4ed75e28"), null, null, "+779 13 (844) 00-53", new Guid("568a5cfd-171b-413d-addf-fe6ab58aa6d0") },
                    { new Guid("418230f7-17dd-49e4-96d5-4584a2280c6b"), null, null, "+902 50 (328) 53-97", new Guid("4bfa50d6-7b76-402d-afe8-4b558ee6165b") },
                    { new Guid("428ec0f1-4488-4465-858d-8502de2c8fbf"), null, null, "+689 27 (892) 48-81", new Guid("78615ad6-0a03-477e-a515-c98b1a96475d") },
                    { new Guid("428f12eb-1973-4fb5-a1bd-b932f418043e"), null, null, "+917 66 (621) 99-60", new Guid("8c7f5100-7603-4d85-9e37-fba6a586f7c8") },
                    { new Guid("429139c4-9625-466b-af24-a65b847b1ab9"), null, null, "+739 32 (945) 36-03", new Guid("7f910a03-763a-4cdb-bbcb-8241bae6fc96") },
                    { new Guid("42b07e76-94ea-435f-8c11-f401c47ff752"), null, null, "+856 02 (931) 05-43", new Guid("967d4ff4-7cca-4fd1-a75a-2f73aca9ca0a") },
                    { new Guid("42c15346-3b51-483b-bcf3-f05e311de600"), null, null, "+48 26 (846) 13-28", new Guid("57d5c043-44a4-43bb-80ee-1cbb791b2285") },
                    { new Guid("42e77911-c1c3-4d1a-b108-5bc671ea22b7"), null, null, "+527 78 (087) 36-88", new Guid("78615ad6-0a03-477e-a515-c98b1a96475d") },
                    { new Guid("431df451-75b1-4e75-99ad-3827340aa8b0"), null, null, "+458 32 (294) 38-72", new Guid("a01a13e5-a8d1-4048-b8b2-24cdfac5f11e") },
                    { new Guid("43451a77-c217-4f4a-934c-6e456e82f652"), null, null, "+355 52 (461) 22-27", new Guid("e58d2261-638d-41ed-b5bf-55b3a94546e1") },
                    { new Guid("434644b8-6ebd-473b-94e9-4448801ba2ac"), null, null, "+114 05 (073) 21-44", new Guid("c60620ff-d62e-4585-9510-ed612aa89dcb") },
                    { new Guid("4370cbc6-5f10-4364-94e0-1aaba0f35ee4"), null, null, "+499 90 (513) 09-37", new Guid("dd2a73f4-0d43-45df-8aa0-196122e00fc2") },
                    { new Guid("43ae542b-ffce-4457-91a7-b8505d106dba"), null, null, "+8 67 (636) 03-70", new Guid("e27f9603-32f8-4066-bf07-4ab692c8350b") },
                    { new Guid("4454fc25-b108-413c-bbed-6ddfa4a8eeaf"), null, null, "+972 41 (912) 55-22", new Guid("1d118b7f-07b1-49dd-9f7d-5a1e7d8ea4bc") },
                    { new Guid("448f3238-807b-4f5f-88c4-e780456793df"), null, null, "+957 01 (901) 58-78", new Guid("10a10ed0-e1f4-4de7-b631-e8c7d0d5eaa9") },
                    { new Guid("44917bca-86ef-465d-bfb5-ed6f2a76ca75"), null, null, "+798 38 (689) 76-12", new Guid("bcb5583b-3b55-4ea8-b016-f74baf89e99a") },
                    { new Guid("44a8d875-f190-4da7-87a1-f1f49fe543d1"), null, null, "+449 52 (968) 17-61", new Guid("5ffbbdb6-b588-4eef-811a-4b39d217f0a8") },
                    { new Guid("4595adb0-aa86-4168-8a5a-589e8c97345b"), null, null, "+882 11 (792) 94-91", new Guid("a01a13e5-a8d1-4048-b8b2-24cdfac5f11e") },
                    { new Guid("459641f4-8276-43db-8bbd-13fe1cc8e922"), null, null, "+427 09 (802) 95-83", new Guid("d0627291-bbf2-408e-bc02-9ba09faa06bd") },
                    { new Guid("45a7a355-998a-43f5-b122-2e1e1f3c9072"), null, null, "+816 41 (405) 91-80", new Guid("4a254852-2316-4300-99be-6d54e3eeac93") },
                    { new Guid("464b6c9c-b889-476f-bc2d-64aeea813ef5"), null, null, "+293 40 (063) 25-22", new Guid("f044a50f-e46f-4992-b8ae-47aa00e79d4d") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("46888bba-48d1-43c9-90fa-5071ad174122"), null, null, "+832 69 (604) 37-53", new Guid("e28ae980-81b6-4d5f-8748-b7cb3f0f995d") },
                    { new Guid("47085bf7-e77e-4e2c-a354-46e6c1d40f64"), null, null, "+300 18 (327) 82-48", new Guid("0b440e9a-ee26-43ee-9d40-46328f22a228") },
                    { new Guid("471320ac-fb38-48d5-8043-26ac5a527321"), null, null, "+253 89 (219) 22-59", new Guid("57d5c043-44a4-43bb-80ee-1cbb791b2285") },
                    { new Guid("473e425a-024e-4fce-b2ae-1a231f4bd714"), null, null, "+143 65 (263) 26-44", new Guid("ff75563e-5545-46de-a4b3-3e0727d74698") },
                    { new Guid("47816505-da4f-44e4-9401-526a2d4a8bf5"), null, null, "+386 78 (006) 51-22", new Guid("ce4c448e-35a5-4243-aa12-b967d2b3da6f") },
                    { new Guid("47c550e9-904a-47a7-b5a3-e62088bdf6a7"), null, null, "+13 96 (887) 70-41", new Guid("1e47206c-cbc9-48ff-becb-ea5c84ec9719") },
                    { new Guid("4841c5bd-5e53-444b-bdf8-07c743fc2527"), null, null, "+891 70 (008) 29-99", new Guid("9dafc6e9-0e56-47f8-8b8b-4ca541841bd0") },
                    { new Guid("48c5a246-5807-4fb8-96b8-c48678ae1bf6"), null, null, "+883 67 (808) 68-57", new Guid("ef100efa-deb4-4516-9a15-38df8ff7e396") },
                    { new Guid("490a46c2-6d3c-4a0c-b983-55c87011cfea"), null, null, "+952 70 (123) 26-77", new Guid("dd2a73f4-0d43-45df-8aa0-196122e00fc2") },
                    { new Guid("4a3fb063-0231-45e8-81be-d834f57187e5"), null, null, "+799 38 (161) 75-95", new Guid("3dd4bd2a-4dd8-4988-867a-99041eb6851d") },
                    { new Guid("4aadb6f9-d012-44fa-90e5-e156c8916116"), null, null, "+840 02 (474) 58-21", new Guid("b44b2dc0-6e21-4d7d-a788-6c4e66d96402") },
                    { new Guid("4be9d013-b3fb-460c-a8c1-982aca7758ef"), null, null, "+948 38 (796) 38-84", new Guid("a4b4b14f-6b7f-4104-b0d2-b8f55417f1e7") },
                    { new Guid("4c19d978-0569-4256-acf8-abee3f4426b7"), null, null, "+848 19 (122) 67-50", new Guid("18314b53-d5e3-48fa-8ad6-dc84c3baa1ff") },
                    { new Guid("4c2890a5-addc-44b0-9243-bec05ebf4533"), null, null, "+218 53 (966) 21-95", new Guid("1d118b7f-07b1-49dd-9f7d-5a1e7d8ea4bc") },
                    { new Guid("4c61cd6e-a5dc-4b2d-9941-24379cc2652c"), null, null, "+659 49 (850) 02-29", new Guid("777e0877-9079-4ecc-a52b-f0bf5734b939") },
                    { new Guid("4c6a03cf-e942-433c-881d-9b2b03d0913a"), null, null, "+735 56 (995) 99-07", new Guid("f472d28b-1df9-4c84-8ceb-3254f55042e7") },
                    { new Guid("4cc0a922-4e01-460d-b8fb-eabe519cf53f"), null, null, "+475 38 (438) 60-84", new Guid("b4e4db54-4f23-4365-96a9-cb8bd3cdaecf") },
                    { new Guid("4ce13d14-d75a-400e-a1a0-5c07a467284e"), null, null, "+372 75 (012) 67-20", new Guid("8adfe810-a4af-41ad-bda0-c1898bdb4d92") },
                    { new Guid("4d01a9cd-d85a-420a-8e8f-d81ee8b6b39a"), null, null, "+662 72 (649) 08-65", new Guid("b50df756-e4ca-4115-a962-e283f6b8d317") },
                    { new Guid("4d5c7d6d-92fe-4ac0-94fc-c23cf6ae7fd5"), null, null, "+835 45 (111) 75-33", new Guid("73aad8c3-cbed-4125-b80b-7db0735c3ac6") },
                    { new Guid("4d7917a8-cc25-4f17-9c24-b1cef12720d9"), null, null, "+809 75 (570) 77-10", new Guid("749d009d-0557-4289-976a-50a7e345a281") },
                    { new Guid("4df58468-acda-4979-9114-1a59aab2aa8a"), null, null, "+199 49 (313) 67-59", new Guid("b5fe6c30-5f2d-462b-9dd2-bc5388f99ce5") },
                    { new Guid("4e402aff-e954-45f7-b85e-7f1784d22b61"), null, null, "+642 64 (633) 96-32", new Guid("dc04df94-1448-4899-bec4-692b13ea2748") },
                    { new Guid("4e51a5de-7c8b-4180-adcd-ae9cedc6ec6f"), null, null, "+910 79 (503) 71-99", new Guid("4bb403d4-8670-466f-a9dc-17dd09c9d546") },
                    { new Guid("4e60edc1-67d8-4c1b-9ed2-caff4a7f9fcb"), null, null, "+88 63 (861) 98-42", new Guid("a8a8fdd8-4ded-4cee-9b8c-87f2285d7eab") },
                    { new Guid("4f228950-0bd5-492a-8d0b-cc015655033e"), null, null, "+623 16 (417) 53-96", new Guid("d4409d83-a792-488f-bea4-9e1b42950fc9") },
                    { new Guid("4f3940d7-fc94-470a-9b36-014513fea008"), null, null, "+429 62 (387) 37-44", new Guid("a8a8fdd8-4ded-4cee-9b8c-87f2285d7eab") },
                    { new Guid("4f5aa9e0-6da3-45ec-b642-cda2d4b7f6cc"), null, null, "+881 85 (233) 48-04", new Guid("cf6839a1-51b8-4ec5-bfec-3cbe48c20160") },
                    { new Guid("4f8726c0-d6b0-4d93-b531-b74bac0156fb"), null, null, "+215 33 (891) 67-96", new Guid("3ca63884-385c-4ae8-ac07-f3dc2df24aae") },
                    { new Guid("4fc7ade6-6591-4c1d-9097-255ef223b9d7"), null, null, "+550 06 (591) 50-35", new Guid("4e8bea3b-5b3c-4c9c-b874-2c8b16d90db2") },
                    { new Guid("4ff9afa5-add5-494c-85b2-ab361d0f5be1"), null, null, "+577 34 (376) 05-34", new Guid("52010289-102f-414b-8fb6-a09a575f22a0") },
                    { new Guid("507df8ea-1a84-4c43-b832-0296d2da10b3"), null, null, "+403 34 (054) 02-05", new Guid("83521c38-fd64-4bbe-89bf-e217d9771096") },
                    { new Guid("50839b64-d169-4ac1-b159-14d8736ee8b2"), null, null, "+330 39 (022) 41-24", new Guid("ad53394d-1d27-416a-92bf-5074f6fa4fc4") },
                    { new Guid("5141dff9-d231-48a8-8d5b-17c39bd84bd2"), null, null, "+897 91 (293) 14-58", new Guid("98222b1e-1352-4ac9-8c47-69a7f0582ef6") },
                    { new Guid("5162a6b4-ac45-4ed4-8896-58b2924a4605"), null, null, "+292 77 (332) 56-05", new Guid("4883913c-7591-4093-a019-7e3dd870d152") },
                    { new Guid("516e4b41-5b04-42ec-ac09-406fba96e11c"), null, null, "+279 75 (289) 29-05", new Guid("872eccf4-a3fa-43c5-ab2e-ac6f6c9e4f17") },
                    { new Guid("5179b1fb-c2c2-4e03-bfe9-a38e0236bb74"), null, null, "+388 38 (826) 61-46", new Guid("966d5ef1-e601-407d-86be-887c8e79a449") },
                    { new Guid("51b25ea7-e25c-4512-b9a4-3a652e3e6612"), null, null, "+118 74 (543) 94-62", new Guid("5c31a07d-9e1a-46bb-9c88-2f881f607c52") },
                    { new Guid("51c6ad5a-72ef-44ff-8de7-8ad3e0c9aa71"), null, null, "+253 75 (832) 31-61", new Guid("abff8b44-2e47-47cd-8158-cb029242cf8c") },
                    { new Guid("523b39a5-e3aa-47f3-a33d-e87f9db717d3"), null, null, "+806 09 (488) 88-01", new Guid("3dd4bd2a-4dd8-4988-867a-99041eb6851d") },
                    { new Guid("5332fda8-3e59-4f0c-8a01-1e87f9f22e01"), null, null, "+205 35 (296) 54-45", new Guid("93ac31b1-6465-45d3-b0b5-98811dbc77b4") },
                    { new Guid("54457880-293a-4001-959d-350927022083"), null, null, "+270 78 (438) 17-88", new Guid("e9781110-3553-481f-bb3a-7ca26a63a83b") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("54725a58-9e18-4666-897d-2070c4259059"), null, null, "+52 73 (098) 50-35", new Guid("37432efe-ddf1-4f3f-9753-a8b4a9e54500") },
                    { new Guid("553ea9a9-d5dd-498f-8d27-c2b6e49ea8ec"), null, null, "+48 07 (851) 23-93", new Guid("ef14d144-d1c3-49fb-9e25-1889be79f4e3") },
                    { new Guid("556a9044-f2dc-4a8a-a674-c538a1c16dc2"), null, null, "+516 03 (603) 81-85", new Guid("abf3ceb3-3421-4454-9686-7b4c13cd1fbf") },
                    { new Guid("557e9f25-1615-48e1-9317-b71dd6ee00c5"), null, null, "+537 89 (139) 67-28", new Guid("6cbb9172-2b78-4f00-a841-8a1e6d6be79b") },
                    { new Guid("55b867f0-fd1f-4567-ab60-b45bdf353a4f"), null, null, "+562 40 (140) 70-53", new Guid("9f331cb7-b70d-434b-bc28-147a5e624fd8") },
                    { new Guid("55c9e982-cc00-4580-8192-f97c8ac22fdb"), null, null, "+204 69 (534) 61-29", new Guid("a13d28a1-8900-4b0d-8399-27cc466b719f") },
                    { new Guid("563b6021-4837-4e8c-b35c-8da92877f8ab"), null, null, "+956 34 (523) 62-57", new Guid("57d5c043-44a4-43bb-80ee-1cbb791b2285") },
                    { new Guid("5657185a-01eb-4d51-b7b1-7a02a2c58622"), null, null, "+869 62 (738) 45-90", new Guid("c798d3b3-ea5a-4b3b-a69b-7022aa64fe86") },
                    { new Guid("568fffe8-fd62-4202-8016-88c2be325e3d"), null, null, "+160 75 (252) 29-35", new Guid("cefdf373-98f4-432b-bfc7-baaf121c554a") },
                    { new Guid("573265bc-6be3-4fbc-8291-2fd49bd901a8"), null, null, "+783 12 (626) 27-13", new Guid("9a38b671-5580-4658-abf4-c1fc9ce2be0b") },
                    { new Guid("57447cea-baab-4bdd-87a7-41d3359a08cb"), null, null, "+284 60 (869) 63-04", new Guid("7771e104-7d9f-4097-8375-a33ad264e1d8") },
                    { new Guid("57737c26-6d30-40e6-aae3-db6469857b7a"), null, null, "+706 47 (541) 79-86", new Guid("52010289-102f-414b-8fb6-a09a575f22a0") },
                    { new Guid("57a92abe-f6b3-407a-b60f-829d8087903a"), null, null, "+952 10 (304) 75-75", new Guid("7889ec96-3dce-40c9-a3d9-1dabf9642602") },
                    { new Guid("57c86fc8-dbdf-4155-976b-41cc01b3aa6e"), null, null, "+954 19 (125) 48-82", new Guid("17441686-0fa5-4e5d-b680-2d5708a2ecd5") },
                    { new Guid("5800a42c-079b-4181-887f-2e4d25ff69ec"), null, null, "+509 21 (960) 33-40", new Guid("3705daaf-a245-497f-b245-acd05a008711") },
                    { new Guid("58033d48-5054-4850-ac13-eb0678df0fa9"), null, null, "+523 82 (363) 71-57", new Guid("ac2d4745-386c-4c13-a217-d9e2d9b842df") },
                    { new Guid("58799a57-ce02-446b-b05f-836964384337"), null, null, "+259 82 (746) 88-40", new Guid("98222b1e-1352-4ac9-8c47-69a7f0582ef6") },
                    { new Guid("58ad2cf1-ff79-426b-8fbe-411dbde5dd54"), null, null, "+927 98 (438) 46-46", new Guid("ad53394d-1d27-416a-92bf-5074f6fa4fc4") },
                    { new Guid("58b5b181-77bb-4af1-b5fe-f556fb9f43a0"), null, null, "+591 26 (391) 18-28", new Guid("ca9a7100-5d5c-406e-8028-d065cd21c772") },
                    { new Guid("58fc4983-45e1-46ab-a3b7-7e709b6f0a0c"), null, null, "+568 76 (630) 46-36", new Guid("2f7c84d9-6fe2-4a1c-ba84-c8d43feade58") },
                    { new Guid("593906fe-5107-495a-a18a-3592a93ea521"), null, null, "+543 47 (742) 87-47", new Guid("b4e4db54-4f23-4365-96a9-cb8bd3cdaecf") },
                    { new Guid("59a2da6b-6fb9-49a8-ac4d-2a436de8d877"), null, null, "+962 29 (927) 09-14", new Guid("9f317a02-0a11-4f32-b538-7ec5c02e4b5e") },
                    { new Guid("59b5e63e-13f5-496f-9d48-258c1bb7a723"), null, null, "+530 67 (402) 77-71", new Guid("7e5e5ebc-3d4d-451a-884b-00a9d9f53676") },
                    { new Guid("59cfba17-d760-4fec-9d7a-ba30784f84b7"), null, null, "+339 76 (825) 61-79", new Guid("f044a50f-e46f-4992-b8ae-47aa00e79d4d") },
                    { new Guid("5a29ff77-a1ae-4df8-a689-f8a5940ddfaa"), null, null, "+821 50 (698) 72-08", new Guid("e188b38e-8056-446d-96c9-b8979c4fd471") },
                    { new Guid("5a5dbd65-3165-4d9f-b189-a40349019b38"), null, null, "+536 97 (717) 73-82", new Guid("861c20c6-b2fe-4d03-a2b4-ae2380f7edc5") },
                    { new Guid("5a61c755-89c0-42b4-ba94-2c3a913cd293"), null, null, "+711 27 (767) 06-55", new Guid("6dcb62c8-dc29-4e18-aabc-b9f4d6f3d1ce") },
                    { new Guid("5a964908-cb3a-4bd9-8bdc-10c356bf7694"), null, null, "+693 15 (682) 19-76", new Guid("6cbb9172-2b78-4f00-a841-8a1e6d6be79b") },
                    { new Guid("5b345200-cd70-45f8-a114-c3b5f7947aee"), null, null, "+562 97 (327) 42-87", new Guid("8e832b0b-a138-409b-b85d-4b68d03a07b6") },
                    { new Guid("5b34e604-1508-46cb-a3de-86a5bf623c27"), null, null, "+363 93 (327) 23-49", new Guid("96357562-82d6-4394-b4bf-5b698e1ad612") },
                    { new Guid("5bef9fa3-8a03-4cc7-9f72-b4242274adab"), null, null, "+669 34 (020) 09-55", new Guid("708b56dd-a529-4229-82e2-2266f01c7942") },
                    { new Guid("5c1d5212-3618-453a-9ea4-92797580591f"), null, null, "+756 45 (081) 50-72", new Guid("d4409d83-a792-488f-bea4-9e1b42950fc9") },
                    { new Guid("5c6da93f-edbe-45cb-a954-bd341837ca68"), null, null, "+998 02 (722) 40-30", new Guid("a64a13ca-2754-4769-a254-32716c64c908") },
                    { new Guid("5c72ee8e-a5df-4e33-bb47-0c7e992d7a02"), null, null, "+559 20 (407) 34-55", new Guid("aee768a4-2b67-47da-a692-ab2b1cd95c27") },
                    { new Guid("5c9bd70d-a626-4ddf-b91a-49d2a5572f89"), null, null, "+614 80 (571) 47-38", new Guid("c8db4c48-87fc-43bc-b9ef-e88e6764800d") },
                    { new Guid("5ccbcd71-e2d5-4bf4-9210-4a16278509a6"), null, null, "+631 66 (284) 29-41", new Guid("24b96e86-5860-47b1-a6ec-9a832bafbb14") },
                    { new Guid("5ce81b99-e18d-4d33-b794-433f4a8215cd"), null, null, "+16 20 (117) 94-40", new Guid("34d672c5-050e-4c3c-8018-0107a72f13f5") },
                    { new Guid("5d1f52c0-40c4-47f3-8871-609f995db6aa"), null, null, "+515 34 (174) 27-96", new Guid("73aad8c3-cbed-4125-b80b-7db0735c3ac6") },
                    { new Guid("5d405e89-ea83-482d-b59c-ec5789a2f35b"), null, null, "+221 42 (129) 58-64", new Guid("e28ae980-81b6-4d5f-8748-b7cb3f0f995d") },
                    { new Guid("5d49adc3-161f-4c91-9ed8-16ae9525b073"), null, null, "+303 62 (518) 69-28", new Guid("dd2a73f4-0d43-45df-8aa0-196122e00fc2") },
                    { new Guid("5dd30d13-d6ee-4554-80e8-73e0e5bfaa90"), null, null, "+619 53 (356) 87-54", new Guid("f044a50f-e46f-4992-b8ae-47aa00e79d4d") },
                    { new Guid("5e0efefa-e7ef-49ee-adec-344be4d966d3"), null, null, "+732 87 (872) 65-54", new Guid("5ffbbdb6-b588-4eef-811a-4b39d217f0a8") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("5e54ba84-85ce-49aa-ac9e-8abb4a0658be"), null, null, "+57 39 (131) 42-59", new Guid("8606d3d5-5f3e-4f9a-b953-4be892f06c0d") },
                    { new Guid("5e78683d-7985-42ea-8e34-2acc86383693"), null, null, "+101 76 (877) 92-15", new Guid("d666c5aa-5c03-4391-8629-5cc681422ca2") },
                    { new Guid("5e831fff-2f58-4b8a-bb5d-ffae4907a37c"), null, null, "+997 94 (543) 94-76", new Guid("655cd6fe-206e-4683-a0e5-f0108ee7f59f") },
                    { new Guid("5ec18073-6083-4658-bb1e-e8032f645b60"), null, null, "+832 23 (747) 76-74", new Guid("a165efc8-0956-4593-9333-e1ab17939488") },
                    { new Guid("5efc8270-1130-41bc-8bcb-5a17756275ae"), null, null, "+70 76 (863) 54-81", new Guid("da687a7e-bca5-449f-ad43-32e0ac00fe15") },
                    { new Guid("5f435520-9b14-47db-ad16-929bac421ea9"), null, null, "+755 00 (938) 50-86", new Guid("25a47446-d397-4805-8427-d3185a6d35b7") },
                    { new Guid("5f83fde1-79c4-4022-ac3d-cd1154ef92a6"), null, null, "+554 22 (158) 90-15", new Guid("ffdf2e3d-14e1-47fc-a87f-43ee44597c72") },
                    { new Guid("5fa7c107-c651-49ec-b325-addfaac0c3f8"), null, null, "+553 58 (155) 40-14", new Guid("ce4c448e-35a5-4243-aa12-b967d2b3da6f") },
                    { new Guid("5fe07d36-e6da-45f6-8c80-31eac2b3d78b"), null, null, "+695 52 (341) 41-49", new Guid("5441f683-8cec-4fb5-96c6-2fa82e7997d3") },
                    { new Guid("607f8353-0ba8-4789-b222-80ad59443b15"), null, null, "+416 52 (776) 39-65", new Guid("997402b2-514c-445f-9988-ae18a101181e") },
                    { new Guid("60a7f3c0-04fc-411e-aafd-455951277413"), null, null, "+660 69 (663) 03-70", new Guid("15cc8bf6-f5ac-435e-a654-84e10e29a1bd") },
                    { new Guid("60ece1df-2c70-42af-a932-8e525e436ab3"), null, null, "+720 15 (244) 33-21", new Guid("b50df756-e4ca-4115-a962-e283f6b8d317") },
                    { new Guid("611e1382-7408-4ebf-9571-e93988af7d68"), null, null, "+449 45 (507) 66-76", new Guid("8e8fd0f7-2809-49f2-9c1e-cbeb885b2de7") },
                    { new Guid("61518c9a-8ca7-48c0-b596-fc8d1b5aabb7"), null, null, "+263 73 (241) 34-61", new Guid("58fc780f-3b29-4947-a319-3ed8b421144e") },
                    { new Guid("61cac1e0-3f6e-4611-9f80-dda0cbe55e86"), null, null, "+934 04 (566) 51-16", new Guid("966d5ef1-e601-407d-86be-887c8e79a449") },
                    { new Guid("61ff0754-6f37-4590-9f19-1248888ba8e7"), null, null, "+679 24 (131) 73-08", new Guid("5e0e0eed-1c83-4b51-8938-5bab69316dab") },
                    { new Guid("6271b33f-b2f3-48c8-9452-c3abe1d50695"), null, null, "+129 18 (380) 91-61", new Guid("a64a13ca-2754-4769-a254-32716c64c908") },
                    { new Guid("62b17702-33a1-4d3d-bc67-055687229100"), null, null, "+532 33 (935) 10-75", new Guid("f044a50f-e46f-4992-b8ae-47aa00e79d4d") },
                    { new Guid("62c31612-75b3-4a36-ac21-3eef04ef34dc"), null, null, "+907 77 (465) 64-45", new Guid("73977b0d-a6cb-4576-bd4a-b7056acdccd3") },
                    { new Guid("62f8cc89-432d-430c-bd9a-8b294e26a07a"), null, null, "+723 74 (961) 07-74", new Guid("ac2d4745-386c-4c13-a217-d9e2d9b842df") },
                    { new Guid("64064666-3ee4-4a25-a262-dcdbaf47bb0c"), null, null, "+242 35 (132) 33-35", new Guid("3aa0613b-0255-46fa-9fc9-f73e67ec6962") },
                    { new Guid("64455934-efa2-4d6c-93b6-abe76212d430"), null, null, "+363 21 (781) 49-60", new Guid("4fb2390c-a600-4f3b-adfe-f73867978239") },
                    { new Guid("64af3f8e-c819-4b2b-890c-4d3208846c33"), null, null, "+113 24 (775) 68-59", new Guid("9f331cb7-b70d-434b-bc28-147a5e624fd8") },
                    { new Guid("65348696-113b-4aec-b341-dd81bb5eb045"), null, null, "+974 25 (297) 79-98", new Guid("5effd297-ddf3-4f40-afed-c85e49e3d248") },
                    { new Guid("658be751-d51a-4214-a6e1-81e10dd8b605"), null, null, "+483 17 (746) 77-31", new Guid("37432efe-ddf1-4f3f-9753-a8b4a9e54500") },
                    { new Guid("65d2bfe2-e704-419d-9874-3b2a6404d4f1"), null, null, "+393 61 (613) 47-38", new Guid("58fc780f-3b29-4947-a319-3ed8b421144e") },
                    { new Guid("65f7eb49-5697-4044-8793-7576406f5be4"), null, null, "+407 84 (299) 33-39", new Guid("359f112e-4dd6-47fb-995d-9dae092d143b") },
                    { new Guid("65f88b46-ba57-473f-9200-11b1a0542837"), null, null, "+318 70 (866) 82-72", new Guid("73aad8c3-cbed-4125-b80b-7db0735c3ac6") },
                    { new Guid("661d7429-1159-449c-b9b8-03a8d6e451fa"), null, null, "+580 65 (884) 55-93", new Guid("4ae96a4e-92a4-486e-b7ce-61d3f2fe842b") },
                    { new Guid("665f7e85-bcbf-488c-a254-e5d3ad5406ac"), null, null, "+274 44 (587) 83-61", new Guid("c1dedd78-34a2-4542-a585-a6ba740f5856") },
                    { new Guid("66febf85-d775-4e8b-8652-d2d3761b92aa"), null, null, "+790 59 (799) 51-17", new Guid("284afcd2-63de-4550-906f-0a1ce11e8244") },
                    { new Guid("6724a6bb-5b38-4235-a44e-10fb5e731ebb"), null, null, "+900 09 (472) 32-23", new Guid("5441f683-8cec-4fb5-96c6-2fa82e7997d3") },
                    { new Guid("672a313c-ea85-4438-8696-6d736bebdf95"), null, null, "+922 91 (586) 46-81", new Guid("63bd6aad-fd4d-4a2d-b0ee-341253297e79") },
                    { new Guid("673361e1-8be1-46d1-943a-8ae3520f7872"), null, null, "+837 45 (721) 40-51", new Guid("e6b167e1-2f8a-4aa9-b766-dcb40c4c65b7") },
                    { new Guid("675a44d8-2697-4312-8824-c921d181ab3b"), null, null, "+904 75 (639) 46-69", new Guid("9e73d492-68df-4c26-bbd7-c238340416ec") },
                    { new Guid("67880c30-a186-4547-bbb5-2c3c387a51ec"), null, null, "+73 11 (158) 13-22", new Guid("98222b1e-1352-4ac9-8c47-69a7f0582ef6") },
                    { new Guid("6795b0c6-ec45-46c5-9eb0-eb2cbfc3b3f0"), null, null, "+136 72 (240) 80-05", new Guid("4bffa9b9-a7ae-4dd6-b87b-dbcad3737bfd") },
                    { new Guid("67fa3486-8c50-4191-b256-8161614fb3e4"), null, null, "+408 30 (151) 77-28", new Guid("78615ad6-0a03-477e-a515-c98b1a96475d") },
                    { new Guid("682ceeed-5e46-469f-9c08-5714fae31a46"), null, null, "+777 14 (189) 57-08", new Guid("6172d849-4ee5-486f-8f97-d2bbcfc40084") },
                    { new Guid("68fff3fe-7b3d-4990-9600-6e5713d9b11f"), null, null, "+28 11 (611) 23-25", new Guid("52c54e9c-3d8e-429f-ae95-d180e2ec5a1d") },
                    { new Guid("692eceeb-963c-44f9-a954-ec138d6a3373"), null, null, "+661 90 (825) 48-77", new Guid("f17c05bb-245d-432b-9116-f181ecbd16c6") },
                    { new Guid("697cb922-f8da-42ef-bf6f-4981d09bc25d"), null, null, "+393 54 (026) 64-15", new Guid("5e2d266d-c2a4-4711-b57e-3656b61d6ad2") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("69a9858c-4570-4807-a09e-eed0cb9f731c"), null, null, "+190 94 (866) 52-86", new Guid("6db49be1-1b9b-4fd0-8b2d-52ae151f7432") },
                    { new Guid("69b0a638-6998-48f0-a931-e0660540b5f5"), null, null, "+675 57 (494) 64-22", new Guid("f4d9bb48-d87b-420c-b2ef-f724726c7a08") },
                    { new Guid("69ea7ac0-ae0e-4f4b-a3b6-e411476734a3"), null, null, "+495 80 (873) 11-44", new Guid("03a04e64-e8f5-4db8-ae88-e45982174d32") },
                    { new Guid("6a8a4c4a-df48-4e75-9660-352d548b361f"), null, null, "+58 69 (296) 98-10", new Guid("8dd6a489-4514-4244-9fa7-a1490970f38b") },
                    { new Guid("6ac70c5d-16d1-4f90-938f-cdea72040a6b"), null, null, "+882 45 (833) 55-75", new Guid("b3997a22-bce6-473b-9a56-6baca1b5ece7") },
                    { new Guid("6b020c2a-c4d0-4a8f-bb8c-cbf7a9c743c1"), null, null, "+488 74 (334) 31-21", new Guid("df250436-821d-48ab-9508-ab3df0550e27") },
                    { new Guid("6b44b2cb-64c3-438a-ae59-9763cd5cfe07"), null, null, "+839 30 (161) 02-05", new Guid("98222b1e-1352-4ac9-8c47-69a7f0582ef6") },
                    { new Guid("6bb4e791-74fe-44da-8fa9-991c3e75e8ff"), null, null, "+801 12 (391) 36-44", new Guid("cb9544f8-58da-451a-a24e-9ef9b8265d20") },
                    { new Guid("6bd0ef82-3188-4d69-a15f-5e5e40a36ce8"), null, null, "+436 47 (627) 15-89", new Guid("6db49be1-1b9b-4fd0-8b2d-52ae151f7432") },
                    { new Guid("6bd6e368-2643-4b89-b02f-c9e8f06be06a"), null, null, "+140 02 (503) 39-59", new Guid("8892b0e2-0aef-404c-8681-2866126b786f") },
                    { new Guid("6cbd9a50-b74f-4320-9a51-7892c4dce5f3"), null, null, "+335 53 (256) 94-71", new Guid("861c20c6-b2fe-4d03-a2b4-ae2380f7edc5") },
                    { new Guid("6ceb8822-8345-4e66-bb80-5a32613678b6"), null, null, "+450 32 (339) 56-13", new Guid("6a6686d3-6711-42f4-b08b-ada2bf39be54") },
                    { new Guid("6d9a099e-8972-4642-bb06-6202a52cacd2"), null, null, "+424 56 (103) 65-88", new Guid("716e3b4a-4381-424f-88d2-df0753a8cb13") },
                    { new Guid("6e79bd64-6a64-460d-a912-457510f37e57"), null, null, "+218 38 (721) 27-21", new Guid("ff75563e-5545-46de-a4b3-3e0727d74698") },
                    { new Guid("6efb8f64-c70e-4c33-b052-236093e3426e"), null, null, "+786 15 (738) 19-21", new Guid("86139076-e779-453a-8f87-64e1bfeeeccc") },
                    { new Guid("6f09190e-d27b-4f89-8aad-4bc30c69e63c"), null, null, "+432 43 (697) 02-53", new Guid("b67eec58-0f42-4a35-a871-09c1ddaddd4b") },
                    { new Guid("6f85c890-7f0f-456f-839f-4f42d39a6202"), null, null, "+297 05 (863) 97-51", new Guid("259e3939-18d5-4998-98ae-345c9d0fa279") },
                    { new Guid("6f972693-89af-4ff5-829d-e64913824548"), null, null, "+432 40 (853) 37-65", new Guid("d8361619-ae4f-4db1-9eb9-291e4814a381") },
                    { new Guid("6f9ceafd-9821-44e9-99ff-d42e401ef95a"), null, null, "+54 10 (890) 98-93", new Guid("9e4f824d-b29a-4ec5-b3a1-111d46f41ecb") },
                    { new Guid("7037a83b-17a5-4bdd-adf1-404ccd348376"), null, null, "+698 94 (050) 71-03", new Guid("78615ad6-0a03-477e-a515-c98b1a96475d") },
                    { new Guid("718ec8bd-f0c8-4263-aae1-16646c1a1b70"), null, null, "+214 43 (874) 91-61", new Guid("fd6ebc44-c70c-4ea5-ad8a-6029ee9c49d9") },
                    { new Guid("71940120-5aac-4869-aafd-967a22926d31"), null, null, "+380 47 (634) 17-73", new Guid("092e31f3-9b9a-4287-8cae-7fcd18feab47") },
                    { new Guid("724d17f9-7716-4f2f-979f-1605a9232507"), null, null, "+738 20 (967) 55-95", new Guid("df250436-821d-48ab-9508-ab3df0550e27") },
                    { new Guid("72634ff2-0276-4fc9-bd10-d360da7c3381"), null, null, "+454 18 (987) 98-51", new Guid("57041776-9144-494f-9e92-9c9da3135eab") },
                    { new Guid("72a137dc-018e-4f67-aeaa-a5eb9d44fcea"), null, null, "+558 19 (843) 27-21", new Guid("aa1380ad-62cc-4108-817a-4ac56a2c382d") },
                    { new Guid("73e7bebe-0f94-4176-9fbb-b40854ed1ae3"), null, null, "+409 65 (534) 55-79", new Guid("8513debb-cacb-47df-a4d3-e59f2a261b69") },
                    { new Guid("73f14327-3699-4415-99fc-ca9bac330dae"), null, null, "+123 65 (781) 34-34", new Guid("e2dba597-b132-4b1a-a46f-540ebc581408") },
                    { new Guid("74143811-bf57-4bcc-a6d8-5b89da177367"), null, null, "+225 22 (950) 74-04", new Guid("a3a7c05f-2de2-47a6-9d73-3dc95cb0a4bf") },
                    { new Guid("74a4acfe-39cd-48c5-bf9e-98f9a42fa4ab"), null, null, "+109 87 (216) 96-11", new Guid("73850497-d7e2-4015-bf80-d8fc761772d3") },
                    { new Guid("74fc741c-7a81-49a8-a0bd-74e1dd0dbdd3"), null, null, "+920 47 (494) 60-14", new Guid("872eccf4-a3fa-43c5-ab2e-ac6f6c9e4f17") },
                    { new Guid("75421fa1-708c-499e-ba1c-0a0482d980f5"), null, null, "+123 95 (255) 32-62", new Guid("5d6854b6-463d-4c99-844f-2b03c65e196b") },
                    { new Guid("75678776-e1e0-49f7-b958-1c18487778f2"), null, null, "+200 26 (900) 18-18", new Guid("d9fc54cb-e30e-4a48-b749-08ff99fcff26") },
                    { new Guid("756cd797-97a6-48e4-821a-c0cedd7cdc02"), null, null, "+716 64 (713) 83-72", new Guid("9a799371-7ad4-44c8-bcc3-759981e1573a") },
                    { new Guid("75886f88-216c-48ec-b46b-ee436defa05e"), null, null, "+959 52 (224) 46-49", new Guid("eddb3b35-4415-4828-97b3-fd737f127090") },
                    { new Guid("7592f090-185b-496d-b212-355746ba31b5"), null, null, "+577 18 (043) 16-91", new Guid("a161bc80-bb44-439e-bb80-442569d93b23") },
                    { new Guid("762ec0f1-0c4f-40af-97e3-20ce17805559"), null, null, "+84 83 (762) 28-49", new Guid("dffee49d-d296-4315-aefd-9602dd01358c") },
                    { new Guid("76f996eb-686c-4fc2-b9f9-b07dfb08238c"), null, null, "+989 91 (592) 97-64", new Guid("0397b496-e66d-4ab5-942d-0a53948ef201") },
                    { new Guid("77169fcb-a223-45be-b9e2-a31ca6718bb6"), null, null, "+268 30 (306) 91-42", new Guid("d9fc54cb-e30e-4a48-b749-08ff99fcff26") },
                    { new Guid("77406d92-a994-471f-94db-4d3ef47ee82f"), null, null, "+876 57 (577) 83-74", new Guid("a7a63c10-9b55-47c6-9d56-8793ee29aafd") },
                    { new Guid("7761e0d8-219d-47b1-bdc2-c19e6bfc7680"), null, null, "+885 43 (914) 43-09", new Guid("7902b014-f441-4bad-a55f-7656352c84e7") },
                    { new Guid("7783b11a-c215-47ec-906d-78142402f6b2"), null, null, "+892 04 (690) 91-49", new Guid("086d4f1c-510f-4c8f-a495-d7e8fc340ecc") },
                    { new Guid("77910d77-3fa6-4c7f-a6be-49822587b806"), null, null, "+976 41 (063) 18-17", new Guid("c798d3b3-ea5a-4b3b-a69b-7022aa64fe86") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("77f51723-294a-4ca9-97b9-1372986abffc"), null, null, "+85 48 (351) 27-84", new Guid("eedd859d-8af5-43b7-8938-5bce7dd89153") },
                    { new Guid("7807a869-e23a-4ecc-b1ba-c26fd5be9d7f"), null, null, "+774 32 (380) 09-89", new Guid("f472d28b-1df9-4c84-8ceb-3254f55042e7") },
                    { new Guid("783ccc53-ddc8-433f-9bee-028b92e82108"), null, null, "+125 91 (661) 74-57", new Guid("37432efe-ddf1-4f3f-9753-a8b4a9e54500") },
                    { new Guid("7990d1b8-ed13-422a-930d-d994000bf88e"), null, null, "+551 67 (462) 19-34", new Guid("d5f398ce-f08b-4d20-af17-603089eb45ee") },
                    { new Guid("799c2a54-b599-4fac-a874-3042b0fcdd80"), null, null, "+346 42 (604) 55-77", new Guid("641c3d4a-a6ff-4cb3-b40a-665b9156a255") },
                    { new Guid("79cab4fa-4247-4abd-8780-aad0a9f90820"), null, null, "+744 35 (800) 25-02", new Guid("c311c4ad-bbcf-418b-8259-eec5ae72eb71") },
                    { new Guid("79f553f3-ea24-4687-91d7-8b366c97feea"), null, null, "+850 58 (185) 65-12", new Guid("43b84c41-ad8c-49ff-ae3a-561f6d21e04b") },
                    { new Guid("7a2ee898-bfc8-460e-a44d-47e35c5ec75d"), null, null, "+369 30 (561) 45-53", new Guid("7e5e5ebc-3d4d-451a-884b-00a9d9f53676") },
                    { new Guid("7ab1eaf9-95cc-4684-9e45-461661642098"), null, null, "+108 51 (464) 20-61", new Guid("c3f74963-e8a7-4598-bde6-0b7eb8dc16d8") },
                    { new Guid("7b32e334-cf2a-4380-9bb8-ae8d76cf8e13"), null, null, "+982 93 (723) 78-83", new Guid("6375150d-9633-494e-ba79-b55f87d56afa") },
                    { new Guid("7b892289-63f3-4364-9b4b-06b6a23adb8a"), null, null, "+218 35 (825) 87-72", new Guid("013a7602-b915-4485-89ea-d3291ed9cab8") },
                    { new Guid("7bc9fb7e-3436-452f-8203-22b2ebb8fcda"), null, null, "+363 76 (869) 39-84", new Guid("222dda98-6fd2-4619-8709-1b78c7872ca8") },
                    { new Guid("7bcfe949-d191-496f-b6f9-303534558b5f"), null, null, "+941 61 (768) 26-07", new Guid("5a6031a7-d008-4d4c-9a87-857d42759454") },
                    { new Guid("7c85a134-f684-4216-be1e-a358ae04adf1"), null, null, "+846 54 (881) 94-58", new Guid("51655f73-efc8-4142-b1ea-1657e4fc0f2e") },
                    { new Guid("7c8fde9e-2881-4283-8b60-4a2d40f8dbcf"), null, null, "+493 10 (223) 85-89", new Guid("aee768a4-2b67-47da-a692-ab2b1cd95c27") },
                    { new Guid("7ce10c39-e345-4e7e-a583-714c9885cd0e"), null, null, "+291 97 (066) 10-34", new Guid("a8a8fdd8-4ded-4cee-9b8c-87f2285d7eab") },
                    { new Guid("7dc22f67-9417-49b2-92c0-cf8f64a3dbf9"), null, null, "+525 55 (554) 61-79", new Guid("02df2ae2-d7d0-47a4-aeae-e733e06bb1d0") },
                    { new Guid("7e20fd45-3e5a-4dbe-909b-af05c19c4e80"), null, null, "+824 84 (431) 33-24", new Guid("b71f69da-e20d-4b25-b2fb-00d5eb1c9002") },
                    { new Guid("7e32fa65-e399-4071-a995-aebdc3c002eb"), null, null, "+478 06 (840) 00-85", new Guid("70c04dec-2a46-4304-b6d1-c42204afdab9") },
                    { new Guid("7e409f02-f6e7-4c13-91c7-0ab38a46501d"), null, null, "+391 48 (475) 91-13", new Guid("b4e4db54-4f23-4365-96a9-cb8bd3cdaecf") },
                    { new Guid("7e4c2dbb-ef26-430f-a5d9-d1be88d57366"), null, null, "+937 12 (105) 09-28", new Guid("4883913c-7591-4093-a019-7e3dd870d152") },
                    { new Guid("7e626341-ea50-47db-a73a-8ca8be096a64"), null, null, "+266 81 (021) 13-19", new Guid("552898bc-d86c-4567-80c9-bdb93739cab5") },
                    { new Guid("7f594afc-eb14-47ac-b322-fc6dd8a9b5ca"), null, null, "+181 72 (417) 53-34", new Guid("451f756f-99dc-4563-9d9a-db92f4a114f0") },
                    { new Guid("7f889087-5739-4304-b024-75eaf04f5418"), null, null, "+553 98 (388) 53-44", new Guid("3705daaf-a245-497f-b245-acd05a008711") },
                    { new Guid("7ff4c48a-0a8b-4c27-836e-8e0b6f52eeff"), null, null, "+755 26 (666) 40-95", new Guid("71ef850e-2fd5-4538-9b05-9c38cbbdbe30") },
                    { new Guid("800219d0-7f9d-4893-9155-db5183a60134"), null, null, "+687 78 (543) 12-56", new Guid("26ad372f-ab3d-49d6-a283-d78f71a0b97b") },
                    { new Guid("800608cb-432c-478f-9c5f-39e86f59ad9a"), null, null, "+419 92 (431) 31-45", new Guid("137b1e19-3c26-4708-9428-159387ebcd43") },
                    { new Guid("80529021-77fc-47a1-a861-98887e130bab"), null, null, "+963 59 (018) 08-81", new Guid("e6b167e1-2f8a-4aa9-b766-dcb40c4c65b7") },
                    { new Guid("805c7ea1-b875-4f75-ab14-f0bce2ecb438"), null, null, "+925 38 (913) 01-11", new Guid("c561cc5e-190d-4a91-8ea9-d03583fa3f86") },
                    { new Guid("808b0159-c423-466a-8619-889a7dc5dee3"), null, null, "+437 69 (971) 95-67", new Guid("6ee9a7d3-8695-4b4a-9a7f-e035a03a4cc3") },
                    { new Guid("80a9fe87-76b6-4b4b-8d77-ffd77bce5624"), null, null, "+852 81 (896) 66-44", new Guid("c1dedd78-34a2-4542-a585-a6ba740f5856") },
                    { new Guid("812141d3-ee3b-47a0-bc70-84e7b3600eea"), null, null, "+497 14 (057) 60-42", new Guid("d9fc54cb-e30e-4a48-b749-08ff99fcff26") },
                    { new Guid("81316514-21b7-4c3f-a7ce-7c279926726c"), null, null, "+951 42 (179) 33-02", new Guid("c50f147c-0804-4f38-a70a-7b8d4109234d") },
                    { new Guid("819d8972-c30d-43d4-9aec-66ac7d969384"), null, null, "+353 22 (534) 61-81", new Guid("58fc780f-3b29-4947-a319-3ed8b421144e") },
                    { new Guid("81a1f9a0-483f-4ed1-ae8c-232ed5d7607a"), null, null, "+906 91 (005) 41-73", new Guid("4ec972f7-f6d0-4660-943e-5ad3d2557cfe") },
                    { new Guid("81b00552-a29c-4b30-862c-6d84dbfac9f7"), null, null, "+674 97 (266) 99-02", new Guid("fc2635e7-fbe6-403c-bcdf-dc9a65be3352") },
                    { new Guid("81b654b5-09e0-42cc-aa34-2a4707f26505"), null, null, "+34 37 (895) 66-15", new Guid("9ffccffc-cb42-46e5-86d7-6730697facf3") },
                    { new Guid("81f2be40-0561-4679-9d7b-6fb3420b5c13"), null, null, "+136 06 (769) 70-63", new Guid("4d65579c-7caa-4a73-aec4-ebf5de2054ab") },
                    { new Guid("82059321-16a7-43a9-9e47-4d4a1342d390"), null, null, "+948 42 (593) 73-88", new Guid("4bfa50d6-7b76-402d-afe8-4b558ee6165b") },
                    { new Guid("821aed53-5d84-43d8-a4b7-6be75465da8d"), null, null, "+297 45 (825) 39-02", new Guid("4ccb797f-65b1-4b8c-809c-fe110c01052b") },
                    { new Guid("83313bc9-0850-4266-9ae2-87aa7d2410d4"), null, null, "+279 32 (836) 66-47", new Guid("17441686-0fa5-4e5d-b680-2d5708a2ecd5") },
                    { new Guid("83599573-10e1-48f0-b573-6d1a50b1844c"), null, null, "+14 01 (271) 28-30", new Guid("ed54e83f-5702-4289-98fb-949b73140a47") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("8389b771-6855-444b-a619-a789d3b56775"), null, null, "+676 69 (249) 07-24", new Guid("ac2d4745-386c-4c13-a217-d9e2d9b842df") },
                    { new Guid("83d1f11d-388e-40e2-8c7c-282138d36d38"), null, null, "+275 71 (893) 61-51", new Guid("8c7f5100-7603-4d85-9e37-fba6a586f7c8") },
                    { new Guid("84f50b5d-3b0f-4f09-aaef-9835675a488b"), null, null, "+840 15 (965) 12-36", new Guid("b50df756-e4ca-4115-a962-e283f6b8d317") },
                    { new Guid("855400f5-c72b-46da-8285-e1194ee2adc8"), null, null, "+494 24 (259) 07-77", new Guid("eedd859d-8af5-43b7-8938-5bce7dd89153") },
                    { new Guid("8570501f-e94c-45fc-950f-b50bcc36b99f"), null, null, "+707 55 (560) 30-33", new Guid("6375150d-9633-494e-ba79-b55f87d56afa") },
                    { new Guid("8602017a-c88f-42ef-8b00-c2032ba4a91e"), null, null, "+245 83 (828) 94-17", new Guid("9a38b671-5580-4658-abf4-c1fc9ce2be0b") },
                    { new Guid("86925d26-2444-44b3-8d7f-70b70132a486"), null, null, "+47 73 (602) 10-99", new Guid("86139076-e779-453a-8f87-64e1bfeeeccc") },
                    { new Guid("86ce2c32-bcc6-4f5d-ae91-58c7347aeddf"), null, null, "+81 16 (946) 01-89", new Guid("8bbc88c0-c35c-496f-b3fc-e18f3d8bad18") },
                    { new Guid("871c52fe-7c73-40ca-8b65-f370f28a412a"), null, null, "+37 71 (930) 47-73", new Guid("cf6839a1-51b8-4ec5-bfec-3cbe48c20160") },
                    { new Guid("877e1ec4-62b4-41dd-a90b-cd1668d23d37"), null, null, "+414 66 (248) 97-80", new Guid("b944ae23-efab-4fcb-bda0-6be21e2add96") },
                    { new Guid("887553f8-b08b-4f59-bcc8-4cc9ec2f7f1c"), null, null, "+561 36 (605) 40-19", new Guid("03a04e64-e8f5-4db8-ae88-e45982174d32") },
                    { new Guid("888c9499-1a71-4f4b-8734-d405b7f3b4a4"), null, null, "+413 16 (614) 64-68", new Guid("b4e4db54-4f23-4365-96a9-cb8bd3cdaecf") },
                    { new Guid("8a943059-12e7-4c6b-914b-c36efb2dbd31"), null, null, "+839 44 (029) 91-13", new Guid("c50f147c-0804-4f38-a70a-7b8d4109234d") },
                    { new Guid("8a984914-4924-4914-b4fd-1029c0a4275b"), null, null, "+332 21 (717) 56-27", new Guid("c3a4c71d-a9ab-475e-9d5b-425a5d31fb48") },
                    { new Guid("8bac0b54-6451-4e0a-8c65-324d045ad763"), null, null, "+813 27 (728) 91-79", new Guid("9a38b671-5580-4658-abf4-c1fc9ce2be0b") },
                    { new Guid("8bbbe7f7-52d5-4bc9-a151-480ee1367f78"), null, null, "+728 05 (688) 16-78", new Guid("966d5ef1-e601-407d-86be-887c8e79a449") },
                    { new Guid("8bd32e2d-dc3b-4f0d-9f06-3a98489f5ee9"), null, null, "+462 07 (330) 06-75", new Guid("b71f69da-e20d-4b25-b2fb-00d5eb1c9002") },
                    { new Guid("8be18d87-ef29-4fcb-a637-0730789fd5d4"), null, null, "+376 86 (032) 12-33", new Guid("d8361619-ae4f-4db1-9eb9-291e4814a381") },
                    { new Guid("8bed2bcd-e391-4d73-8ad5-bdb35dac977e"), null, null, "+306 00 (273) 47-10", new Guid("4fb2390c-a600-4f3b-adfe-f73867978239") },
                    { new Guid("8c50c9bb-b2ce-4cb8-99a9-9f61ebf2723a"), null, null, "+466 02 (028) 07-75", new Guid("aa053e12-232a-4d5d-8b1f-0803fd8b7767") },
                    { new Guid("8c905344-e7dd-4c13-80c8-8bf1b70acf00"), null, null, "+46 84 (639) 94-81", new Guid("52c54e9c-3d8e-429f-ae95-d180e2ec5a1d") },
                    { new Guid("8c9344cd-3ec7-4687-8e6f-cf18c1c1ce94"), null, null, "+645 24 (685) 62-95", new Guid("a161bc80-bb44-439e-bb80-442569d93b23") },
                    { new Guid("8cc44b95-cead-4db3-8eb9-388297215456"), null, null, "+917 90 (673) 71-96", new Guid("0b440e9a-ee26-43ee-9d40-46328f22a228") },
                    { new Guid("8cc81b12-1e30-422d-bc15-1a58f5e48720"), null, null, "+416 28 (177) 50-22", new Guid("ef14d144-d1c3-49fb-9e25-1889be79f4e3") },
                    { new Guid("8ceaaa59-8780-429f-a110-37b5e714afe5"), null, null, "+12 39 (851) 56-61", new Guid("ca9a7100-5d5c-406e-8028-d065cd21c772") },
                    { new Guid("8cecec9d-8f83-4e56-9ce7-60528669d74a"), null, null, "+140 21 (626) 81-38", new Guid("cefdf373-98f4-432b-bfc7-baaf121c554a") },
                    { new Guid("8d1895a9-123c-4620-8a85-cd7442f58e6e"), null, null, "+530 85 (043) 93-83", new Guid("cb9544f8-58da-451a-a24e-9ef9b8265d20") },
                    { new Guid("8d3b5250-4b1d-4ae9-9b34-1b0d8ca09529"), null, null, "+609 82 (427) 53-14", new Guid("4d65579c-7caa-4a73-aec4-ebf5de2054ab") },
                    { new Guid("8dca7ad0-e1f1-4e3e-b517-c29d186f2b43"), null, null, "+406 49 (104) 27-38", new Guid("9dafc6e9-0e56-47f8-8b8b-4ca541841bd0") },
                    { new Guid("8ddc994b-5523-4512-8e41-0709caf9d40b"), null, null, "+135 13 (019) 68-96", new Guid("c311c4ad-bbcf-418b-8259-eec5ae72eb71") },
                    { new Guid("8dfba9ac-af94-4ea5-8e61-5f7819191ae1"), null, null, "+246 57 (953) 18-34", new Guid("259e3939-18d5-4998-98ae-345c9d0fa279") },
                    { new Guid("8e00ac98-536d-4b5f-9989-1ed386b41666"), null, null, "+27 11 (659) 62-13", new Guid("3aa0613b-0255-46fa-9fc9-f73e67ec6962") },
                    { new Guid("8ebd963a-8c95-4bc2-8cac-5baadca4e636"), null, null, "+915 42 (878) 00-97", new Guid("b9974b20-5b3f-4445-a6d7-c4352b53a64c") },
                    { new Guid("8f827678-77ef-4f4b-96be-e900def0bc0b"), null, null, "+467 05 (758) 83-39", new Guid("6ee9a7d3-8695-4b4a-9a7f-e035a03a4cc3") },
                    { new Guid("8fa1c70e-54da-4a13-83fe-96cd93e5c6b2"), null, null, "+185 38 (991) 03-39", new Guid("861c20c6-b2fe-4d03-a2b4-ae2380f7edc5") },
                    { new Guid("8fa4e5d5-12ee-44d3-a657-4402c5f2ec5d"), null, null, "+170 58 (119) 05-22", new Guid("dee746db-2712-4366-98c6-517b826fd421") },
                    { new Guid("8fdfcf64-a696-44a0-8b90-24eda854cea8"), null, null, "+975 19 (454) 77-28", new Guid("72b9b70e-980c-47d3-a949-0b0acbdbe9f3") },
                    { new Guid("9024d0ae-a6fb-45c1-b6c7-61ae4a7609b7"), null, null, "+928 00 (017) 00-70", new Guid("437bc41c-af0d-4443-809f-276b155b8846") },
                    { new Guid("90454e8d-40db-48ab-b865-8e63a0e46157"), null, null, "+457 11 (014) 97-95", new Guid("c431ef46-de70-4dba-a2b4-061b2a219ebc") },
                    { new Guid("904618c4-0389-4da1-ac13-a3bd583bfb70"), null, null, "+157 36 (647) 14-52", new Guid("8c7f5100-7603-4d85-9e37-fba6a586f7c8") },
                    { new Guid("905cb1bd-71f7-4dd4-946c-3a197445ef5a"), null, null, "+217 48 (898) 06-21", new Guid("0639ab22-a867-435b-8c5b-7acf69750583") },
                    { new Guid("90fc529a-c257-4cc1-b03f-b190d633e1f4"), null, null, "+680 19 (837) 24-89", new Guid("a3564d73-cc7f-45bf-bb8d-5bff9f9bd319") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("926fa793-2d9c-4e12-ae0b-6111c6bd8bc6"), null, null, "+983 24 (389) 62-39", new Guid("96357562-82d6-4394-b4bf-5b698e1ad612") },
                    { new Guid("9270889e-9602-4591-a9c5-09b372f5d2ac"), null, null, "+77 62 (242) 25-05", new Guid("2eb253e8-852b-4b59-bbd3-41b1d962644b") },
                    { new Guid("927d9ba8-03bb-456d-a549-907af94d455e"), null, null, "+546 22 (677) 98-94", new Guid("17b956d2-133d-4289-8a76-4633e194bce0") },
                    { new Guid("92819562-10de-4ab7-8fd0-c4dd0adccc11"), null, null, "+391 72 (612) 13-10", new Guid("d9295c19-5c11-40bb-ba7c-c1b368114ac0") },
                    { new Guid("928a3799-3a39-4419-ae25-570508f44089"), null, null, "+973 41 (055) 53-62", new Guid("9eb02965-fa79-4bc7-940e-eff714a39f7e") },
                    { new Guid("9290216d-0faf-43ad-ba52-29ca5a8582ca"), null, null, "+74 16 (255) 08-36", new Guid("bd5c667b-2bfc-46c6-814e-7b5c93be8f43") },
                    { new Guid("92e79612-afcd-4dfb-84b5-b7ec5e68ea20"), null, null, "+101 87 (468) 11-47", new Guid("c0ce8022-4a58-4c92-9e84-7f2ac0c9caa5") },
                    { new Guid("932e8d68-dc02-42ff-b126-8e804bdb0968"), null, null, "+706 51 (702) 26-72", new Guid("97c89012-688a-4d00-9708-03d8cb08dc2e") },
                    { new Guid("93d7ec90-3360-404e-8749-d8e207617b20"), null, null, "+11 13 (302) 15-88", new Guid("6ee9a7d3-8695-4b4a-9a7f-e035a03a4cc3") },
                    { new Guid("94624252-a917-4335-8075-fc59ebbc1cb9"), null, null, "+162 88 (374) 88-54", new Guid("c3f74963-e8a7-4598-bde6-0b7eb8dc16d8") },
                    { new Guid("94b31252-4ad6-4693-8e55-b06161730157"), null, null, "+372 12 (822) 82-34", new Guid("f7f7b1e1-146a-4f33-9556-99419aa87dbb") },
                    { new Guid("94d1761f-66e6-429b-9153-47d268d27830"), null, null, "+73 23 (539) 53-57", new Guid("d9295c19-5c11-40bb-ba7c-c1b368114ac0") },
                    { new Guid("957c1bee-d217-4cc8-80cc-0d4c8c1976d5"), null, null, "+841 54 (771) 30-93", new Guid("d8361619-ae4f-4db1-9eb9-291e4814a381") },
                    { new Guid("95d9f22d-920e-445a-97ae-eff0d6d9a3d1"), null, null, "+355 61 (922) 68-45", new Guid("960fe293-a56c-42c1-b68b-57d1e361fe6d") },
                    { new Guid("96423c36-c970-42e2-bc9b-07549a41f70c"), null, null, "+617 92 (801) 66-08", new Guid("37432efe-ddf1-4f3f-9753-a8b4a9e54500") },
                    { new Guid("96dee630-b687-47c6-a458-84e4df3a8ea4"), null, null, "+727 92 (965) 10-06", new Guid("8a1cc6ac-cbbb-45b8-a858-79df665cbf01") },
                    { new Guid("96e22fc2-214d-49b4-b642-0cfc95da4a28"), null, null, "+562 58 (478) 64-31", new Guid("3705daaf-a245-497f-b245-acd05a008711") },
                    { new Guid("96fea94b-7b09-4a3e-bc4a-a491e29a6b76"), null, null, "+845 15 (458) 45-08", new Guid("17441686-0fa5-4e5d-b680-2d5708a2ecd5") },
                    { new Guid("9817f41e-06bd-4507-b944-73426c0780af"), null, null, "+354 14 (294) 02-75", new Guid("26ad372f-ab3d-49d6-a283-d78f71a0b97b") },
                    { new Guid("9831e42e-f1f8-47e0-bec2-dd399954b255"), null, null, "+476 85 (318) 56-68", new Guid("94e92894-3b19-4c5f-9e95-0ec52116ec92") },
                    { new Guid("9890cb8b-9b4c-4d5f-84c8-dd5d1b1ebe6f"), null, null, "+52 97 (914) 35-15", new Guid("e6b167e1-2f8a-4aa9-b766-dcb40c4c65b7") },
                    { new Guid("98967400-543a-405c-ae1c-fee068a23d86"), null, null, "+616 90 (470) 46-60", new Guid("c1dedd78-34a2-4542-a585-a6ba740f5856") },
                    { new Guid("98e70f88-01b0-45a1-8d03-952f3a28a9c3"), null, null, "+471 28 (093) 73-62", new Guid("857e5ff4-368c-45c8-909c-9cb05ea33802") },
                    { new Guid("994f8c64-38a4-48c2-b885-67038793d9b9"), null, null, "+199 27 (001) 92-84", new Guid("259e3939-18d5-4998-98ae-345c9d0fa279") },
                    { new Guid("995e08b2-90d1-463b-b91a-ab79aeec97a6"), null, null, "+157 09 (238) 79-33", new Guid("997402b2-514c-445f-9988-ae18a101181e") },
                    { new Guid("99989eaf-5ef2-4ae3-8c11-2c812892f566"), null, null, "+914 49 (951) 93-14", new Guid("a6fc0423-6291-4866-8d02-6faea1986c4e") },
                    { new Guid("99fb39f9-7d20-4878-acd4-c951d6628e46"), null, null, "+869 45 (613) 92-44", new Guid("a6fc0423-6291-4866-8d02-6faea1986c4e") },
                    { new Guid("9a1ca3a7-74ed-46c2-960f-41c94b5dddcb"), null, null, "+517 16 (693) 89-02", new Guid("8e8fd0f7-2809-49f2-9c1e-cbeb885b2de7") },
                    { new Guid("9a718654-1530-493a-b110-7ca96467f304"), null, null, "+932 28 (519) 12-14", new Guid("086d4f1c-510f-4c8f-a495-d7e8fc340ecc") },
                    { new Guid("9ac9a62f-5a43-48f1-9ad8-127e78f87b12"), null, null, "+819 08 (634) 08-57", new Guid("58fc780f-3b29-4947-a319-3ed8b421144e") },
                    { new Guid("9ad8d07a-d74c-4562-82d5-49a31855e2a6"), null, null, "+832 52 (538) 00-12", new Guid("ef100efa-deb4-4516-9a15-38df8ff7e396") },
                    { new Guid("9aed6c39-9aae-49e2-9b79-9a65e1f50dbf"), null, null, "+887 86 (152) 31-69", new Guid("63bd6aad-fd4d-4a2d-b0ee-341253297e79") },
                    { new Guid("9b347b93-2402-40d8-a101-6681060ce5c9"), null, null, "+856 14 (492) 30-71", new Guid("777e0877-9079-4ecc-a52b-f0bf5734b939") },
                    { new Guid("9b99acca-976b-485c-bc9b-33c990c9e067"), null, null, "+739 75 (064) 52-59", new Guid("c311c4ad-bbcf-418b-8259-eec5ae72eb71") },
                    { new Guid("9bb6dd3c-2cc0-476d-afec-2370da3f9f96"), null, null, "+975 70 (706) 60-27", new Guid("d9295c19-5c11-40bb-ba7c-c1b368114ac0") },
                    { new Guid("9bf34341-7c3c-45df-b365-e4f24991846e"), null, null, "+505 05 (344) 94-93", new Guid("6cbb9172-2b78-4f00-a841-8a1e6d6be79b") },
                    { new Guid("9c289e77-7e97-4c9e-9c52-83b384d8aea2"), null, null, "+948 87 (741) 88-60", new Guid("2a9b395f-43a6-4c12-8ee4-3f4db5f26f9d") },
                    { new Guid("9c5241a0-af95-43cd-8d62-5d2821812580"), null, null, "+130 58 (061) 13-42", new Guid("1d118b7f-07b1-49dd-9f7d-5a1e7d8ea4bc") },
                    { new Guid("9cea924c-d857-4159-8a5c-ff799da3fd76"), null, null, "+518 79 (383) 93-30", new Guid("bcb5583b-3b55-4ea8-b016-f74baf89e99a") },
                    { new Guid("9d10b36f-4ea6-4a1b-821c-71a7f861bad1"), null, null, "+500 89 (818) 36-99", new Guid("88155035-c6f4-450c-bd25-3d3e9c9d8f5d") },
                    { new Guid("9d35e0c0-3a3f-4cdc-a42b-e16e9437a639"), null, null, "+511 12 (275) 29-88", new Guid("6dcb62c8-dc29-4e18-aabc-b9f4d6f3d1ce") },
                    { new Guid("9d3a388f-9f9a-4af8-97c5-e17ee9afc21a"), null, null, "+895 36 (950) 86-23", new Guid("e807eb16-5caf-4274-9ff7-5027ed83325c") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("9d49268e-2e79-4611-842d-420a0777ae43"), null, null, "+498 36 (442) 10-17", new Guid("3dc1a6db-3bf2-4650-b501-abf7ef284b3c") },
                    { new Guid("9e599de6-7ea2-4ea9-acf6-42bab1b762cf"), null, null, "+498 81 (758) 37-36", new Guid("69536a6d-5fc0-40dc-96ff-96cfa2e2ddde") },
                    { new Guid("a0124bd1-2f45-4272-ae26-87e6e74ce178"), null, null, "+906 66 (326) 57-07", new Guid("f7f7b1e1-146a-4f33-9556-99419aa87dbb") },
                    { new Guid("a0196e4f-821c-4e93-9559-34c4ea068950"), null, null, "+469 98 (814) 77-61", new Guid("ed54e83f-5702-4289-98fb-949b73140a47") },
                    { new Guid("a053015c-4578-4e74-af3c-89cd66f9248c"), null, null, "+210 79 (446) 16-31", new Guid("4d65579c-7caa-4a73-aec4-ebf5de2054ab") },
                    { new Guid("a0d506c1-0e9c-40fb-bbb6-595efd9b20e9"), null, null, "+66 59 (895) 34-07", new Guid("e7414a92-a2c0-4cbd-a0ca-3a6c538ac8c6") },
                    { new Guid("a1da93f4-6fb8-4595-97e8-df06be42ac0e"), null, null, "+693 58 (347) 85-39", new Guid("d1fdc728-523b-49bf-b2d8-eee9a8bb93d1") },
                    { new Guid("a2540c21-4d9e-4e66-b6a3-b1507615c45b"), null, null, "+928 61 (237) 28-03", new Guid("e7414a92-a2c0-4cbd-a0ca-3a6c538ac8c6") },
                    { new Guid("a2831c42-2a0a-4644-9859-8c6d29742eb6"), null, null, "+682 12 (907) 12-94", new Guid("a165efc8-0956-4593-9333-e1ab17939488") },
                    { new Guid("a2860cfa-def0-4740-b372-9eadc90892dd"), null, null, "+334 21 (859) 55-27", new Guid("861c20c6-b2fe-4d03-a2b4-ae2380f7edc5") },
                    { new Guid("a2c8b0a8-75e2-461c-8999-72ca565f3a7e"), null, null, "+285 74 (063) 20-65", new Guid("e2dba597-b132-4b1a-a46f-540ebc581408") },
                    { new Guid("a31c2001-a456-496d-b540-d7507ae310b8"), null, null, "+737 83 (430) 62-66", new Guid("fc2635e7-fbe6-403c-bcdf-dc9a65be3352") },
                    { new Guid("a3547d83-52e4-4a2f-a547-0ea254440141"), null, null, "+913 34 (031) 48-71", new Guid("2a9b395f-43a6-4c12-8ee4-3f4db5f26f9d") },
                    { new Guid("a3aa6c0d-92cc-4ef9-aba5-22b8cdc59932"), null, null, "+770 22 (981) 97-08", new Guid("c9de1952-448f-4a77-a4fa-b78a3751957a") },
                    { new Guid("a3c41c3b-dfe7-49b2-b84f-5b33a6bbfecd"), null, null, "+420 11 (535) 35-84", new Guid("9b0c9ef1-c568-4fc6-8e02-cbbb959e0bbb") },
                    { new Guid("a3c5248b-fa96-477e-a964-cfe38708e751"), null, null, "+26 07 (035) 53-99", new Guid("2063153a-a610-4c40-9ddd-456ef0b560db") },
                    { new Guid("a4b233d7-e301-41b2-bbce-ce3e77b2c0cd"), null, null, "+177 15 (942) 48-66", new Guid("a3564d73-cc7f-45bf-bb8d-5bff9f9bd319") },
                    { new Guid("a4e67519-c532-4892-aa54-cc1e2a47a99f"), null, null, "+490 62 (265) 95-67", new Guid("4ae96a4e-92a4-486e-b7ce-61d3f2fe842b") },
                    { new Guid("a513f733-a1c9-4f84-ae8a-4ecbd2217b31"), null, null, "+495 56 (915) 33-77", new Guid("708b56dd-a529-4229-82e2-2266f01c7942") },
                    { new Guid("a5500f26-841c-42ed-8205-55bfa74a32a5"), null, null, "+709 00 (568) 59-54", new Guid("6b62d633-8ccd-4aa4-82e7-a8336a9e5760") },
                    { new Guid("a5681ebd-82a5-4128-8b23-a7f08fba3a24"), null, null, "+441 38 (563) 00-52", new Guid("e2dba597-b132-4b1a-a46f-540ebc581408") },
                    { new Guid("a599b71e-08f3-446f-875d-f4c55e2f5146"), null, null, "+316 80 (904) 93-60", new Guid("8606d3d5-5f3e-4f9a-b953-4be892f06c0d") },
                    { new Guid("a5f79f4a-bbac-4862-b09a-233b08e2a9d5"), null, null, "+13 54 (092) 40-91", new Guid("d0fc0768-b3a0-4f82-affc-e355dc4101f4") },
                    { new Guid("a60b7b61-cf7f-4c8d-b9ea-367f7ce42072"), null, null, "+173 20 (605) 35-90", new Guid("26ad372f-ab3d-49d6-a283-d78f71a0b97b") },
                    { new Guid("a63aa7f9-b650-46c7-808c-7b86e03da2e2"), null, null, "+936 19 (107) 35-93", new Guid("0768641f-3440-4d72-a350-3b2eca842a26") },
                    { new Guid("a6a51e08-18ed-404a-bbbe-cb8328d9f227"), null, null, "+859 72 (348) 83-11", new Guid("4af7ff34-3014-4da9-ba8e-e93cfaac4eaf") },
                    { new Guid("a6a5ae20-d594-40ff-b5bc-024644f5e83c"), null, null, "+743 27 (572) 04-00", new Guid("c3a4c71d-a9ab-475e-9d5b-425a5d31fb48") },
                    { new Guid("a6c1c7ee-1545-4701-9f9b-810461d12806"), null, null, "+459 64 (963) 53-76", new Guid("96389a1d-3bc8-465b-ba35-3027877a9981") },
                    { new Guid("a6cf29ef-446c-4f74-99f9-0270eef100c1"), null, null, "+704 50 (933) 45-41", new Guid("0ffea79c-1eaa-4ef4-b27f-e6c525534682") },
                    { new Guid("a70639d7-b0ef-4e51-bb99-53fcc4576e7d"), null, null, "+211 35 (593) 94-74", new Guid("c0ce8022-4a58-4c92-9e84-7f2ac0c9caa5") },
                    { new Guid("a712a606-bac0-4e55-8abc-186841dffd0b"), null, null, "+413 80 (197) 06-95", new Guid("4d792f39-989a-48bc-8528-2bda17a5967a") },
                    { new Guid("a722e92a-e817-416a-87a5-8dc46a706cf1"), null, null, "+570 58 (618) 30-40", new Guid("d9fc54cb-e30e-4a48-b749-08ff99fcff26") },
                    { new Guid("a730dfd6-e454-4e85-9ffc-40863a4b8a9c"), null, null, "+850 06 (208) 38-33", new Guid("16dfe9db-9389-4852-8b69-53610d60b359") },
                    { new Guid("a8ded51c-653f-44c6-b145-81563d0eeba7"), null, null, "+877 40 (609) 85-16", new Guid("b9974b20-5b3f-4445-a6d7-c4352b53a64c") },
                    { new Guid("a8f08709-16de-4f06-acd0-5c68b97ce492"), null, null, "+804 70 (540) 51-02", new Guid("97d70a43-949c-4c03-9da7-fc16fdc0c86d") },
                    { new Guid("a929ddfc-9a6d-43a0-9b0f-325f01c66c3f"), null, null, "+872 08 (975) 65-01", new Guid("69536a6d-5fc0-40dc-96ff-96cfa2e2ddde") },
                    { new Guid("a96010bb-96e4-410a-9e62-6d327200f426"), null, null, "+967 04 (280) 02-39", new Guid("8adfe810-a4af-41ad-bda0-c1898bdb4d92") },
                    { new Guid("a9b7e0af-5199-4f97-8939-da901ebdbac3"), null, null, "+13 05 (978) 97-87", new Guid("34d672c5-050e-4c3c-8018-0107a72f13f5") },
                    { new Guid("a9f79b8e-33d3-4146-84a0-fdc8b698c2ba"), null, null, "+487 26 (265) 48-96", new Guid("1546f9ad-e76e-4438-9513-2c0cdbcdc9dc") },
                    { new Guid("aa07d3c6-edd4-42b1-bbf1-f3223fba97f4"), null, null, "+484 41 (912) 12-41", new Guid("68fd726f-e5e4-4755-a477-4727a0a9f4b8") },
                    { new Guid("aa42494c-4b39-4fce-9ef9-4c321c3c8d0d"), null, null, "+127 83 (611) 63-27", new Guid("5a13878d-22a4-47a3-8eb8-3f4be375baee") },
                    { new Guid("ab522593-9381-4030-89ba-8df14b25eaf3"), null, null, "+724 28 (808) 60-29", new Guid("ffdf2e3d-14e1-47fc-a87f-43ee44597c72") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("ab97d5cf-08d6-4897-90d7-dcbee28a90a7"), null, null, "+411 81 (944) 26-60", new Guid("3aa0613b-0255-46fa-9fc9-f73e67ec6962") },
                    { new Guid("abbec7dd-77fd-46a2-9a98-11433e3aab24"), null, null, "+66 64 (203) 47-98", new Guid("7b354f95-20a6-4d69-abe1-b5a212feb069") },
                    { new Guid("abd23cbe-d4f7-4500-a526-6b6a96e3f5ad"), null, null, "+252 18 (598) 04-57", new Guid("d8361619-ae4f-4db1-9eb9-291e4814a381") },
                    { new Guid("ac268e73-f26d-496c-b470-4a156ba24f7b"), null, null, "+147 46 (118) 60-08", new Guid("b5fe6c30-5f2d-462b-9dd2-bc5388f99ce5") },
                    { new Guid("ac3d7ae9-1afa-4ef6-8959-d7c01c4fc806"), null, null, "+166 89 (142) 82-13", new Guid("eedd859d-8af5-43b7-8938-5bce7dd89153") },
                    { new Guid("aca97493-17ea-4d04-878a-b24f0ebf1eb1"), null, null, "+235 65 (597) 49-89", new Guid("7b9acf5a-1eec-4436-8152-103e38ca0953") },
                    { new Guid("acefec16-7771-48b5-8c8c-f1feffd8edff"), null, null, "+310 01 (035) 73-57", new Guid("62f9c608-cb23-46fa-a1c4-304e5c65aec1") },
                    { new Guid("ad0da61e-852d-443e-9542-a4438a7786dd"), null, null, "+684 21 (721) 98-61", new Guid("857e5ff4-368c-45c8-909c-9cb05ea33802") },
                    { new Guid("ad6665ca-da8e-479a-99ee-8440796dffd8"), null, null, "+132 19 (478) 54-78", new Guid("9b8fcbcf-ce9d-40cf-aa2a-0543ebe6f135") },
                    { new Guid("ae0b0e08-7147-4d2b-8efb-24c0076d3f07"), null, null, "+661 41 (544) 54-28", new Guid("2a328a80-898f-4b62-921d-731137bebe9f") },
                    { new Guid("ae160630-3a37-42ba-97ac-aebfdfd43be6"), null, null, "+817 18 (148) 70-72", new Guid("d08dab84-c369-4193-b4fb-bbd252c59cc5") },
                    { new Guid("ae390b61-6913-4162-a04d-f3fcfc7ae1c7"), null, null, "+346 30 (903) 42-18", new Guid("5d6854b6-463d-4c99-844f-2b03c65e196b") },
                    { new Guid("aef0033c-7943-415f-9731-23ce832c56dc"), null, null, "+666 30 (531) 14-66", new Guid("6a6686d3-6711-42f4-b08b-ada2bf39be54") },
                    { new Guid("af126d15-fa0a-408b-b84d-9199fa4c14e1"), null, null, "+941 66 (254) 50-35", new Guid("3dd4bd2a-4dd8-4988-867a-99041eb6851d") },
                    { new Guid("af31000e-de36-460e-8b11-de8f02b05790"), null, null, "+307 41 (112) 80-89", new Guid("86139076-e779-453a-8f87-64e1bfeeeccc") },
                    { new Guid("afac9d7c-4c41-435f-b76d-320bc4d65035"), null, null, "+981 96 (789) 39-05", new Guid("4bb403d4-8670-466f-a9dc-17dd09c9d546") },
                    { new Guid("afad298f-278d-4794-86ee-45c130529793"), null, null, "+255 33 (255) 12-08", new Guid("43b84c41-ad8c-49ff-ae3a-561f6d21e04b") },
                    { new Guid("b02cd5f4-854a-4bae-b143-f14d6b900b42"), null, null, "+47 49 (036) 80-79", new Guid("6cbb9172-2b78-4f00-a841-8a1e6d6be79b") },
                    { new Guid("b0602170-391f-4221-8e05-399403416446"), null, null, "+396 06 (053) 70-03", new Guid("8dd6a489-4514-4244-9fa7-a1490970f38b") },
                    { new Guid("b06657e0-6e5c-4c1f-9235-09a0e27a13a2"), null, null, "+966 73 (890) 63-45", new Guid("b944ae23-efab-4fcb-bda0-6be21e2add96") },
                    { new Guid("b07ac236-8a60-46f3-ab7b-748e4f97199c"), null, null, "+189 59 (067) 83-67", new Guid("a3564d73-cc7f-45bf-bb8d-5bff9f9bd319") },
                    { new Guid("b07c2c25-20ca-4f5a-98af-106585335edc"), null, null, "+350 75 (636) 57-40", new Guid("bcb5583b-3b55-4ea8-b016-f74baf89e99a") },
                    { new Guid("b09c4db3-2e6d-47d2-b142-e8e5011a258f"), null, null, "+223 09 (787) 44-11", new Guid("dee746db-2712-4366-98c6-517b826fd421") },
                    { new Guid("b0c0c4af-575f-40db-9204-76f0a217aa3e"), null, null, "+593 44 (545) 31-10", new Guid("73850497-d7e2-4015-bf80-d8fc761772d3") },
                    { new Guid("b1a076ea-129c-4356-9535-d7ca9f42ad86"), null, null, "+748 61 (629) 26-37", new Guid("57d5c043-44a4-43bb-80ee-1cbb791b2285") },
                    { new Guid("b1cb34ec-f731-4fb1-94d0-28abc224e34b"), null, null, "+324 37 (923) 04-40", new Guid("451f756f-99dc-4563-9d9a-db92f4a114f0") },
                    { new Guid("b246ae77-f71b-4ba4-bdcc-4c4bb66e0eba"), null, null, "+843 79 (546) 40-97", new Guid("eedd859d-8af5-43b7-8938-5bce7dd89153") },
                    { new Guid("b34850b1-0792-4021-96f1-dc46c679595a"), null, null, "+323 20 (075) 03-27", new Guid("c8db4c48-87fc-43bc-b9ef-e88e6764800d") },
                    { new Guid("b3e5c238-1853-4d5f-a24b-b83076016dcc"), null, null, "+256 32 (139) 33-25", new Guid("b3997a22-bce6-473b-9a56-6baca1b5ece7") },
                    { new Guid("b3f6e151-dee7-45e3-8daa-9c52dfeb4246"), null, null, "+510 46 (242) 55-75", new Guid("43b84c41-ad8c-49ff-ae3a-561f6d21e04b") },
                    { new Guid("b3fce5fd-3dcb-46e2-8927-34d7e9da3882"), null, null, "+144 89 (493) 27-06", new Guid("437bc41c-af0d-4443-809f-276b155b8846") },
                    { new Guid("b42fcefe-0c83-417e-888b-c940c44b5b98"), null, null, "+375 71 (397) 09-88", new Guid("96357562-82d6-4394-b4bf-5b698e1ad612") },
                    { new Guid("b44ede98-7fdc-4e01-a37d-6b0b3db220ce"), null, null, "+100 88 (699) 67-96", new Guid("1c5135c6-32f4-4363-a0a3-5a8fb7357df1") },
                    { new Guid("b4589e32-ba6c-4549-8603-53071911533c"), null, null, "+771 07 (083) 92-02", new Guid("9fc4b18c-b710-43c3-be29-ffdea2c51975") },
                    { new Guid("b52fa6eb-ac32-4b86-a2fc-7e23f41f75c7"), null, null, "+713 59 (091) 52-93", new Guid("5ffbbdb6-b588-4eef-811a-4b39d217f0a8") },
                    { new Guid("b5d4e593-9b91-4687-994f-608287ba5006"), null, null, "+258 61 (832) 35-19", new Guid("9a799371-7ad4-44c8-bcc3-759981e1573a") },
                    { new Guid("b5fd240a-55a8-4fd3-a10d-4e106e8ef018"), null, null, "+96 28 (547) 28-42", new Guid("d666c5aa-5c03-4391-8629-5cc681422ca2") },
                    { new Guid("b6296f7c-7a7e-46aa-b1e9-24c8ba95a7b8"), null, null, "+626 48 (552) 04-55", new Guid("18314b53-d5e3-48fa-8ad6-dc84c3baa1ff") },
                    { new Guid("b63d2b73-3100-4255-bd67-6966c045c60b"), null, null, "+794 48 (149) 32-96", new Guid("aa053e12-232a-4d5d-8b1f-0803fd8b7767") },
                    { new Guid("b694c9f4-220d-4529-9869-abd362c74e0a"), null, null, "+145 90 (694) 54-22", new Guid("9b8fcbcf-ce9d-40cf-aa2a-0543ebe6f135") },
                    { new Guid("b6a68f2e-9c99-4734-b004-5064bc210688"), null, null, "+171 23 (689) 35-76", new Guid("872eccf4-a3fa-43c5-ab2e-ac6f6c9e4f17") },
                    { new Guid("b7089aac-ef04-4ffe-8df6-199c9be6460c"), null, null, "+870 34 (737) 07-66", new Guid("967d4ff4-7cca-4fd1-a75a-2f73aca9ca0a") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("b737c424-9404-436f-953a-2bd57b047c78"), null, null, "+34 22 (408) 51-64", new Guid("a165efc8-0956-4593-9333-e1ab17939488") },
                    { new Guid("b754a287-c45e-4d7d-b8d4-8630a9006e17"), null, null, "+507 69 (459) 33-88", new Guid("d1fdc728-523b-49bf-b2d8-eee9a8bb93d1") },
                    { new Guid("b7683605-4796-44a6-9932-b8ace6f939ac"), null, null, "+752 90 (413) 49-40", new Guid("a7a63c10-9b55-47c6-9d56-8793ee29aafd") },
                    { new Guid("b77c9975-ee19-47ed-bfd3-6b86be9047d0"), null, null, "+851 26 (341) 25-99", new Guid("18314b53-d5e3-48fa-8ad6-dc84c3baa1ff") },
                    { new Guid("b7ac44cd-c69c-4ba3-bfc0-f72e49ede1ff"), null, null, "+578 36 (394) 76-92", new Guid("7f910a03-763a-4cdb-bbcb-8241bae6fc96") },
                    { new Guid("b7ca2ec2-5990-4ef7-ab7b-e913b508c3dd"), null, null, "+859 09 (096) 62-29", new Guid("620337a7-cc3b-43d5-aef4-5b29e97ab466") },
                    { new Guid("b7f70cf6-1fa0-4e20-9a23-1c4afa9e5f37"), null, null, "+497 38 (021) 14-62", new Guid("4fd873ab-a800-46d0-959f-d9f6189c846e") },
                    { new Guid("b828f15a-edd8-48c3-83e6-c51d820d7139"), null, null, "+224 90 (379) 73-98", new Guid("966d5ef1-e601-407d-86be-887c8e79a449") },
                    { new Guid("b877187f-31c9-4996-a320-8ae6de013a2b"), null, null, "+34 67 (339) 87-96", new Guid("6709762d-580f-4c32-8f92-b1daa6e22c27") },
                    { new Guid("b8cdd7eb-57dd-411d-8412-1635f39eb662"), null, null, "+235 90 (238) 19-50", new Guid("7f910a03-763a-4cdb-bbcb-8241bae6fc96") },
                    { new Guid("b8d9a2cf-3e8a-44ad-8e39-f5f4dd13de81"), null, null, "+41 33 (065) 45-83", new Guid("cc549d3d-c127-48fe-9320-69c0367cf0ef") },
                    { new Guid("b90bfca7-c27b-4f84-a62b-cc605c7fe817"), null, null, "+452 08 (763) 16-79", new Guid("fc2635e7-fbe6-403c-bcdf-dc9a65be3352") },
                    { new Guid("b90cef9a-5034-4bd2-89ce-045ed2988d49"), null, null, "+761 76 (895) 59-34", new Guid("51655f73-efc8-4142-b1ea-1657e4fc0f2e") },
                    { new Guid("ba11c6ae-a99f-45c8-9bd4-58540be2a32c"), null, null, "+37 40 (718) 64-13", new Guid("fc7807f7-2e15-4c19-8500-ea40f337d9de") },
                    { new Guid("ba9e99ed-30ad-4b2a-a829-fc67319bb18a"), null, null, "+855 49 (091) 79-44", new Guid("5a13878d-22a4-47a3-8eb8-3f4be375baee") },
                    { new Guid("bab4e5e9-5c36-4286-9a2c-d6dd6dfc670b"), null, null, "+379 31 (482) 35-75", new Guid("cd3bba51-ecbd-472a-a962-7f603574b446") },
                    { new Guid("bb23a0e6-4186-46c8-83af-c16e1d1b89ab"), null, null, "+7 99 (662) 44-67", new Guid("a4b4b14f-6b7f-4104-b0d2-b8f55417f1e7") },
                    { new Guid("bbce03a2-8d63-4d0e-b6fd-6928f1d1b98d"), null, null, "+359 98 (039) 75-55", new Guid("708b56dd-a529-4229-82e2-2266f01c7942") },
                    { new Guid("bc08ba6d-552a-4d44-a5a7-411e52a6d3f6"), null, null, "+45 19 (938) 53-13", new Guid("4d65579c-7caa-4a73-aec4-ebf5de2054ab") },
                    { new Guid("bc090511-7837-433c-b228-6e5d09805425"), null, null, "+201 90 (243) 34-25", new Guid("013a7602-b915-4485-89ea-d3291ed9cab8") },
                    { new Guid("bc5e40ea-5fb0-420b-b875-2ebe99aef9c2"), null, null, "+326 50 (716) 87-23", new Guid("9e4f824d-b29a-4ec5-b3a1-111d46f41ecb") },
                    { new Guid("bc8901ba-629d-42a6-98dd-d1fb0d43730e"), null, null, "+326 20 (509) 83-21", new Guid("2eb253e8-852b-4b59-bbd3-41b1d962644b") },
                    { new Guid("bcaaeea6-bb8c-43a5-996b-eed909af4d53"), null, null, "+90 12 (515) 32-18", new Guid("859757d1-9ad7-45f4-8664-764e0db29fec") },
                    { new Guid("bdaf63bb-308a-4a0b-91c7-c18dc6a6357b"), null, null, "+749 41 (835) 09-80", new Guid("e1223f43-016e-41f5-b212-ab70a0ac01e2") },
                    { new Guid("bdf510a2-ceae-43c9-b9d6-1a68fdc34c87"), null, null, "+7 58 (069) 07-27", new Guid("ffdf2e3d-14e1-47fc-a87f-43ee44597c72") },
                    { new Guid("be11282c-3b17-4e31-a128-6d0e10bbe7dd"), null, null, "+818 49 (295) 70-97", new Guid("dffee49d-d296-4315-aefd-9602dd01358c") },
                    { new Guid("be398234-3ebc-456f-87cd-9b20bd819942"), null, null, "+22 60 (626) 05-30", new Guid("fc2635e7-fbe6-403c-bcdf-dc9a65be3352") },
                    { new Guid("be4d6b95-2dcf-41fa-997b-54f4af43f01f"), null, null, "+152 86 (638) 50-47", new Guid("4bfa50d6-7b76-402d-afe8-4b558ee6165b") },
                    { new Guid("beca1383-05f7-4914-ba9b-4ce51bb7d533"), null, null, "+904 87 (839) 31-78", new Guid("359f112e-4dd6-47fb-995d-9dae092d143b") },
                    { new Guid("bef0def5-b93c-491e-bc59-e5f79a6bab30"), null, null, "+670 58 (480) 43-11", new Guid("7b354f95-20a6-4d69-abe1-b5a212feb069") },
                    { new Guid("bfb22535-869d-4607-8659-f7f2946b243a"), null, null, "+879 93 (938) 25-35", new Guid("7771e104-7d9f-4097-8375-a33ad264e1d8") },
                    { new Guid("bffd029e-25c8-4a1a-9f3f-9c9e9fc8e473"), null, null, "+600 75 (073) 89-75", new Guid("fc15fcf7-014b-4521-910c-8a4a05ae7df9") },
                    { new Guid("c01a9012-ef54-41e3-bddd-bbe7eca33d81"), null, null, "+705 34 (207) 46-25", new Guid("63ce22ac-8a36-4fb9-bf6d-61e02101f5d7") },
                    { new Guid("c09740e8-06d8-4629-8d08-11c2bbdd08e6"), null, null, "+371 26 (445) 67-08", new Guid("c3f40de8-9c2b-4f97-b99a-a3d5f6431b27") },
                    { new Guid("c123c991-8e3d-4a53-9e55-afb41e132353"), null, null, "+213 53 (709) 15-85", new Guid("9e4f824d-b29a-4ec5-b3a1-111d46f41ecb") },
                    { new Guid("c12c6bf4-61a4-4276-954f-179ef58f5854"), null, null, "+414 00 (019) 76-45", new Guid("97d70a43-949c-4c03-9da7-fc16fdc0c86d") },
                    { new Guid("c1dc5995-8cff-4e39-b0da-bd246aa2386d"), null, null, "+146 29 (122) 87-73", new Guid("166bcf97-6b8a-4025-ad11-df15241b0a24") },
                    { new Guid("c1e141f1-c4ac-4402-8d6f-674f0b848610"), null, null, "+898 42 (611) 49-58", new Guid("cb8696d4-d2d5-40c3-b74f-38aafecd34f8") },
                    { new Guid("c227b59e-03a5-4fe1-b1bf-104e1aaaec4f"), null, null, "+375 52 (142) 32-62", new Guid("f472d28b-1df9-4c84-8ceb-3254f55042e7") },
                    { new Guid("c2ab9dc0-73a9-4e00-81f0-64b694bed16d"), null, null, "+533 92 (883) 06-61", new Guid("9e4f824d-b29a-4ec5-b3a1-111d46f41ecb") },
                    { new Guid("c2b4f2b1-29fe-498a-a2a2-fe2dc3d0d5f5"), null, null, "+988 87 (049) 86-21", new Guid("91024531-3bc9-4397-868c-67a81b4abcfc") },
                    { new Guid("c39afa87-9994-411f-b14f-0d17692d1cb0"), null, null, "+252 48 (208) 15-95", new Guid("7902b014-f441-4bad-a55f-7656352c84e7") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("c3d712a5-ea82-401e-ab27-427e587e0117"), null, null, "+402 76 (677) 78-85", new Guid("1e47206c-cbc9-48ff-becb-ea5c84ec9719") },
                    { new Guid("c3daeef8-e6db-4b33-b179-b7c7dcde2bc1"), null, null, "+450 78 (018) 10-18", new Guid("c0ce8022-4a58-4c92-9e84-7f2ac0c9caa5") },
                    { new Guid("c3f2b66a-9f19-4c27-97a8-a3a262310c0c"), null, null, "+601 34 (988) 01-85", new Guid("3a8ff431-6524-4268-ae59-91f87b944fae") },
                    { new Guid("c3f96cd6-e404-4c8f-b1c0-00587a7175c6"), null, null, "+593 32 (045) 65-07", new Guid("f54b6d8e-36d4-482b-83f6-69bd802b2ec3") },
                    { new Guid("c52dc038-cee2-450e-91d6-9c9d99b99230"), null, null, "+496 29 (700) 59-65", new Guid("5560fdd3-3041-418a-bdbd-b1b7cb595a87") },
                    { new Guid("c5ac7c13-c6fc-4078-8fb9-4ec943c6b706"), null, null, "+15 54 (314) 47-16", new Guid("552898bc-d86c-4567-80c9-bdb93739cab5") },
                    { new Guid("c5c0993a-e9f8-47ba-b646-e229b269c2f0"), null, null, "+378 26 (043) 44-83", new Guid("9b0c9ef1-c568-4fc6-8e02-cbbb959e0bbb") },
                    { new Guid("c76e6eb5-2fed-4c93-a1cd-b69d19f6b822"), null, null, "+579 98 (250) 62-30", new Guid("9f317a02-0a11-4f32-b538-7ec5c02e4b5e") },
                    { new Guid("c796daaa-38b4-4a99-b075-568a06c15fc3"), null, null, "+45 07 (226) 52-30", new Guid("f9c15c1c-b6bd-46fd-921b-e1778f14dacf") },
                    { new Guid("c7e28174-600d-4fee-92d9-bf683df57b2d"), null, null, "+982 66 (885) 21-66", new Guid("777e0877-9079-4ecc-a52b-f0bf5734b939") },
                    { new Guid("c8dc6249-7567-4a17-9153-5d05991a2ec4"), null, null, "+99 82 (353) 23-61", new Guid("092e31f3-9b9a-4287-8cae-7fcd18feab47") },
                    { new Guid("c8fc9773-2975-4e28-b951-edeb99a182f0"), null, null, "+768 25 (344) 73-05", new Guid("b71f69da-e20d-4b25-b2fb-00d5eb1c9002") },
                    { new Guid("c916118f-eaef-4b75-a2fb-c74e7696d1ee"), null, null, "+55 21 (657) 15-07", new Guid("c0ce8022-4a58-4c92-9e84-7f2ac0c9caa5") },
                    { new Guid("c932eb21-644a-4010-8711-dd90bee44a1e"), null, null, "+535 88 (755) 80-70", new Guid("e58d2261-638d-41ed-b5bf-55b3a94546e1") },
                    { new Guid("c9480ba9-5514-4c9c-8aca-0fecac110944"), null, null, "+316 39 (791) 75-09", new Guid("4bfa50d6-7b76-402d-afe8-4b558ee6165b") },
                    { new Guid("c948b425-e2d4-4000-b4bf-101b739bb69e"), null, null, "+371 63 (572) 25-08", new Guid("e6b167e1-2f8a-4aa9-b766-dcb40c4c65b7") },
                    { new Guid("ca74d754-f11e-4fbe-b979-287ce22fb216"), null, null, "+401 90 (711) 05-41", new Guid("ce4c448e-35a5-4243-aa12-b967d2b3da6f") },
                    { new Guid("cb749963-d3e9-490a-b634-42294e5a467a"), null, null, "+29 41 (211) 46-69", new Guid("d0627291-bbf2-408e-bc02-9ba09faa06bd") },
                    { new Guid("cbc601e8-c78a-4384-ae19-d7b92f7f6b34"), null, null, "+987 42 (916) 43-93", new Guid("c311c4ad-bbcf-418b-8259-eec5ae72eb71") },
                    { new Guid("cbceb17a-126b-4c59-badc-b96f376c6563"), null, null, "+877 29 (998) 30-73", new Guid("d0627291-bbf2-408e-bc02-9ba09faa06bd") },
                    { new Guid("cc9e04d4-d98a-4ef4-a0f7-1cbd395c8cdd"), null, null, "+987 59 (972) 83-01", new Guid("93ac31b1-6465-45d3-b0b5-98811dbc77b4") },
                    { new Guid("ccac75e9-16b1-4342-9a6f-b0dde046c1da"), null, null, "+192 67 (830) 62-56", new Guid("6b62d633-8ccd-4aa4-82e7-a8336a9e5760") },
                    { new Guid("cccd062d-ad3e-4da5-9d28-f8223b4cb71f"), null, null, "+262 32 (382) 33-13", new Guid("89c19062-b085-4717-8960-680ec5f619e0") },
                    { new Guid("cd324dfa-b4bb-4799-b949-730327704ac3"), null, null, "+398 79 (459) 75-20", new Guid("16dfe9db-9389-4852-8b69-53610d60b359") },
                    { new Guid("cd659890-5d80-4854-bd7d-11e52e0610a7"), null, null, "+164 44 (470) 96-35", new Guid("6709762d-580f-4c32-8f92-b1daa6e22c27") },
                    { new Guid("cdb218cf-b12e-49f0-8713-c5abeeec5d64"), null, null, "+290 46 (881) 00-37", new Guid("9b8fcbcf-ce9d-40cf-aa2a-0543ebe6f135") },
                    { new Guid("ce0ba1ac-6e27-4bde-b8c5-5f7f277fedb0"), null, null, "+425 45 (832) 39-59", new Guid("6b62d633-8ccd-4aa4-82e7-a8336a9e5760") },
                    { new Guid("ce3e30ad-0695-4233-ab35-c4cf245d444b"), null, null, "+249 36 (997) 50-93", new Guid("a3564d73-cc7f-45bf-bb8d-5bff9f9bd319") },
                    { new Guid("ce8478c3-00c2-4631-84bf-dd60bbbc034d"), null, null, "+548 42 (836) 99-03", new Guid("11ddb06c-1f4a-4028-b37b-6ad05ae5f7d5") },
                    { new Guid("cf101334-80c3-4a01-9901-5b20c1c7c661"), null, null, "+512 52 (998) 28-76", new Guid("7b354f95-20a6-4d69-abe1-b5a212feb069") },
                    { new Guid("cf3a9b67-c07d-4bbe-ae2f-0a70452f97bb"), null, null, "+766 87 (208) 83-26", new Guid("5d6854b6-463d-4c99-844f-2b03c65e196b") },
                    { new Guid("cfd70a4d-d0b0-4cdf-9c22-c7f3ce20fb5f"), null, null, "+397 18 (969) 30-92", new Guid("97c89012-688a-4d00-9708-03d8cb08dc2e") },
                    { new Guid("d02e976a-7cac-4ccd-a05b-60e0c5295f08"), null, null, "+578 91 (374) 63-19", new Guid("7f910a03-763a-4cdb-bbcb-8241bae6fc96") },
                    { new Guid("d0cef729-d24b-4c1d-a03d-38b5d236d17d"), null, null, "+353 18 (458) 46-17", new Guid("8dd6a489-4514-4244-9fa7-a1490970f38b") },
                    { new Guid("d114500c-444f-49da-9e0d-e45bb33de9fa"), null, null, "+915 44 (117) 06-55", new Guid("09465da9-1c65-4a00-be4f-5b7144e699f3") },
                    { new Guid("d15c5d7c-10b9-4a9b-969c-5a43fd1b61fb"), null, null, "+673 90 (469) 52-52", new Guid("83521c38-fd64-4bbe-89bf-e217d9771096") },
                    { new Guid("d1905672-af8c-44df-9d51-8086d7a8206c"), null, null, "+947 28 (662) 02-18", new Guid("137b1e19-3c26-4708-9428-159387ebcd43") },
                    { new Guid("d310d4ab-1b1a-4f62-9f92-27485b48028d"), null, null, "+986 23 (908) 43-96", new Guid("cf6839a1-51b8-4ec5-bfec-3cbe48c20160") },
                    { new Guid("d39e75c5-38d8-40cc-8685-a321bb49c185"), null, null, "+537 98 (828) 94-83", new Guid("8adfe810-a4af-41ad-bda0-c1898bdb4d92") },
                    { new Guid("d3ef31e7-06a5-43cd-9cfc-d2296398684a"), null, null, "+900 08 (465) 59-45", new Guid("f54b6d8e-36d4-482b-83f6-69bd802b2ec3") },
                    { new Guid("d43c177c-781d-4ac2-8892-28f6df37c8da"), null, null, "+830 38 (483) 45-67", new Guid("5d6854b6-463d-4c99-844f-2b03c65e196b") },
                    { new Guid("d455491c-67d1-4f00-b36b-d6ab39a52418"), null, null, "+302 08 (032) 64-51", new Guid("aa1380ad-62cc-4108-817a-4ac56a2c382d") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("d48ce4df-0d9a-4c5e-98c9-e0523271c832"), null, null, "+999 11 (524) 24-06", new Guid("e807eb16-5caf-4274-9ff7-5027ed83325c") },
                    { new Guid("d4b80247-bc25-4659-93bb-52eac3681da1"), null, null, "+532 46 (325) 04-08", new Guid("8a1cc6ac-cbbb-45b8-a858-79df665cbf01") },
                    { new Guid("d4dec1bc-a54c-4cbe-997c-cd5b9a8bf7f0"), null, null, "+728 62 (102) 50-81", new Guid("dc04df94-1448-4899-bec4-692b13ea2748") },
                    { new Guid("d5170344-8cd3-4432-88a0-6b5db6c32b42"), null, null, "+883 38 (715) 34-92", new Guid("a13d28a1-8900-4b0d-8399-27cc466b719f") },
                    { new Guid("d53f5be7-1dcd-4022-bcbc-3d677bf93d59"), null, null, "+747 50 (978) 74-25", new Guid("01a8f276-3a4c-402e-98b4-c3b9dba05f91") },
                    { new Guid("d5aa2b05-f3ec-4a2c-8a9d-6ac34e5f17fa"), null, null, "+389 47 (965) 59-74", new Guid("6b62d633-8ccd-4aa4-82e7-a8336a9e5760") },
                    { new Guid("d5d1e4bc-c9a8-49c3-a4bc-cf34e25c98bb"), null, null, "+43 77 (741) 65-51", new Guid("c4c17769-48f5-471b-ac8e-87a2c17573b4") },
                    { new Guid("d6fe12f1-3e49-4640-ab42-09ebe3bf378d"), null, null, "+915 06 (505) 29-17", new Guid("a3a7c05f-2de2-47a6-9d73-3dc95cb0a4bf") },
                    { new Guid("d726e73e-a74f-492d-9216-b984d85fcbe0"), null, null, "+819 46 (009) 09-26", new Guid("967d4ff4-7cca-4fd1-a75a-2f73aca9ca0a") },
                    { new Guid("d7384506-cba1-4c71-8bc1-4bd0ea051295"), null, null, "+372 89 (102) 48-16", new Guid("52010289-102f-414b-8fb6-a09a575f22a0") },
                    { new Guid("d7b48371-ace5-4b49-b200-2b67313d8492"), null, null, "+891 25 (927) 62-28", new Guid("a6fc0423-6291-4866-8d02-6faea1986c4e") },
                    { new Guid("d831c4fa-9a6d-48f0-ba91-631dc0b32727"), null, null, "+958 60 (751) 86-15", new Guid("da687a7e-bca5-449f-ad43-32e0ac00fe15") },
                    { new Guid("d8bebe56-b760-4905-ba03-ef3311832214"), null, null, "+748 33 (649) 91-33", new Guid("fc15fcf7-014b-4521-910c-8a4a05ae7df9") },
                    { new Guid("d9299905-9abe-49d3-8110-eeeff7c38290"), null, null, "+528 84 (907) 23-44", new Guid("73aad8c3-cbed-4125-b80b-7db0735c3ac6") },
                    { new Guid("d9c691d5-06d3-4f44-810d-638d9a237361"), null, null, "+521 79 (052) 33-01", new Guid("777e0877-9079-4ecc-a52b-f0bf5734b939") },
                    { new Guid("da255a1f-134a-49e0-a213-3fe682dd726b"), null, null, "+904 04 (748) 21-51", new Guid("5441f683-8cec-4fb5-96c6-2fa82e7997d3") },
                    { new Guid("da5d14a7-deea-4b36-8e3d-aef0d8169ab9"), null, null, "+111 66 (481) 95-24", new Guid("09465da9-1c65-4a00-be4f-5b7144e699f3") },
                    { new Guid("da5fb10f-c5e8-461a-996f-14307cc0855b"), null, null, "+753 45 (170) 61-30", new Guid("f17c05bb-245d-432b-9116-f181ecbd16c6") },
                    { new Guid("da7f9f3c-60b6-4f2c-b5c9-d1c21be35c56"), null, null, "+310 87 (401) 65-05", new Guid("01a8f276-3a4c-402e-98b4-c3b9dba05f91") },
                    { new Guid("da88d012-2e87-4d69-86fb-6d621ad777bf"), null, null, "+164 36 (573) 12-54", new Guid("dffee49d-d296-4315-aefd-9602dd01358c") },
                    { new Guid("daed51ca-1d4b-4a59-8240-757fe005fbfa"), null, null, "+556 25 (427) 40-55", new Guid("9dafc6e9-0e56-47f8-8b8b-4ca541841bd0") },
                    { new Guid("dafd3964-78a1-4e30-9c4d-9a8abafd44da"), null, null, "+14 70 (903) 26-75", new Guid("d5f398ce-f08b-4d20-af17-603089eb45ee") },
                    { new Guid("db0bb048-6225-43a1-ad9b-bf0e09ee38b0"), null, null, "+889 08 (506) 36-25", new Guid("222dda98-6fd2-4619-8709-1b78c7872ca8") },
                    { new Guid("dc6b60b0-5316-4f6c-ba6b-ca3aad4cf7d3"), null, null, "+153 00 (558) 96-65", new Guid("aa1380ad-62cc-4108-817a-4ac56a2c382d") },
                    { new Guid("dc6db22e-f147-4b32-a4c9-27c211396ec6"), null, null, "+524 62 (231) 06-50", new Guid("b944ae23-efab-4fcb-bda0-6be21e2add96") },
                    { new Guid("dc70b8a7-3816-4d85-8cc2-be5b29f6ae26"), null, null, "+446 68 (203) 79-59", new Guid("5c31a07d-9e1a-46bb-9c88-2f881f607c52") },
                    { new Guid("dcb7caad-beb0-4816-90eb-9350d1556dac"), null, null, "+876 52 (481) 64-35", new Guid("6172d849-4ee5-486f-8f97-d2bbcfc40084") },
                    { new Guid("ddb5461e-4d54-4bb6-b409-e172160e434e"), null, null, "+149 34 (681) 98-60", new Guid("9ffccffc-cb42-46e5-86d7-6730697facf3") },
                    { new Guid("ddf6eff1-4b38-4a06-b473-bcd91619edf6"), null, null, "+273 08 (751) 95-93", new Guid("8adfe810-a4af-41ad-bda0-c1898bdb4d92") },
                    { new Guid("debb2e82-8413-4c28-9e2f-9b43d33a1f3c"), null, null, "+838 36 (845) 67-52", new Guid("22c74cee-2548-4aef-ab56-019f64d2fb3e") },
                    { new Guid("debfc9a8-bff5-4e05-8254-981fbcc8cfaf"), null, null, "+915 92 (270) 51-69", new Guid("43b84c41-ad8c-49ff-ae3a-561f6d21e04b") },
                    { new Guid("df799d51-155a-41f3-8945-9f684b098d4a"), null, null, "+586 06 (714) 94-64", new Guid("4d792f39-989a-48bc-8528-2bda17a5967a") },
                    { new Guid("e06e71de-f9b5-4330-86d4-f8a5b703a7c1"), null, null, "+733 24 (939) 86-83", new Guid("cc549d3d-c127-48fe-9320-69c0367cf0ef") },
                    { new Guid("e091e8fa-781a-4d60-8f9b-5fea81dbee93"), null, null, "+555 52 (532) 27-55", new Guid("69536a6d-5fc0-40dc-96ff-96cfa2e2ddde") },
                    { new Guid("e0c73171-b3bc-453b-a91a-8c9bc5de9847"), null, null, "+148 35 (688) 56-57", new Guid("d1fdc728-523b-49bf-b2d8-eee9a8bb93d1") },
                    { new Guid("e140c537-7ef8-4603-85db-61f7222d8cfa"), null, null, "+516 24 (878) 79-14", new Guid("0397b496-e66d-4ab5-942d-0a53948ef201") },
                    { new Guid("e1d04a8b-49e3-49f9-b696-acb85ebdde22"), null, null, "+859 53 (654) 54-00", new Guid("fc7807f7-2e15-4c19-8500-ea40f337d9de") },
                    { new Guid("e1d8b119-7ca4-4df7-b557-d3d687d4370d"), null, null, "+158 22 (929) 87-70", new Guid("857e5ff4-368c-45c8-909c-9cb05ea33802") },
                    { new Guid("e219b200-0d3b-4e4c-a846-14722e14cb2d"), null, null, "+890 89 (917) 62-53", new Guid("a7a63c10-9b55-47c6-9d56-8793ee29aafd") },
                    { new Guid("e22ab30a-a1de-4578-a11e-d1868ed342bf"), null, null, "+623 93 (214) 43-79", new Guid("24b96e86-5860-47b1-a6ec-9a832bafbb14") },
                    { new Guid("e25f36a8-ea3e-486f-84f3-1ea44fbecc98"), null, null, "+712 68 (274) 81-76", new Guid("d08dab84-c369-4193-b4fb-bbd252c59cc5") },
                    { new Guid("e29638aa-f1b2-4073-99e3-83b0f8ddcd9e"), null, null, "+889 97 (572) 61-64", new Guid("c561cc5e-190d-4a91-8ea9-d03583fa3f86") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("e2eef972-747a-4247-9900-22043e5e0022"), null, null, "+981 12 (173) 87-81", new Guid("427485d5-0faa-4f9a-9c6f-70317d50831a") },
                    { new Guid("e3a51f24-ff05-4304-9881-fdea0ae71fc2"), null, null, "+384 99 (398) 53-43", new Guid("51655f73-efc8-4142-b1ea-1657e4fc0f2e") },
                    { new Guid("e424d46a-4236-453e-9027-9c30956c72af"), null, null, "+806 24 (018) 45-05", new Guid("93ac31b1-6465-45d3-b0b5-98811dbc77b4") },
                    { new Guid("e4351226-4a3c-4656-905a-cdbdb7341a82"), null, null, "+720 61 (618) 70-01", new Guid("708b56dd-a529-4229-82e2-2266f01c7942") },
                    { new Guid("e488847e-6842-461f-9ce4-3f83cc6d58bd"), null, null, "+639 01 (609) 75-28", new Guid("5441f683-8cec-4fb5-96c6-2fa82e7997d3") },
                    { new Guid("e4bd035a-aed8-4653-b11d-5f591abc77d0"), null, null, "+636 79 (307) 65-54", new Guid("52010289-102f-414b-8fb6-a09a575f22a0") },
                    { new Guid("e4ef7eb1-2ed8-4757-85bf-a13e55bd25b0"), null, null, "+547 99 (416) 24-69", new Guid("e44b1f8c-951b-48de-a206-672ce80e3e29") },
                    { new Guid("e5417ff2-b125-4d56-a442-fc76999eba9e"), null, null, "+896 49 (376) 05-27", new Guid("ef14d144-d1c3-49fb-9e25-1889be79f4e3") },
                    { new Guid("e57c8469-da89-4438-a06f-0bf6958d15ac"), null, null, "+646 61 (555) 44-58", new Guid("6709762d-580f-4c32-8f92-b1daa6e22c27") },
                    { new Guid("e599c4de-e6d1-4ca8-aed3-bd9fa15a6bbf"), null, null, "+371 54 (368) 75-04", new Guid("641c3d4a-a6ff-4cb3-b40a-665b9156a255") },
                    { new Guid("e5fb336f-348e-4540-abdb-1727d186729e"), null, null, "+601 30 (948) 64-24", new Guid("8c7f5100-7603-4d85-9e37-fba6a586f7c8") },
                    { new Guid("e64caad0-36aa-46e4-bbb6-a7122c16aaea"), null, null, "+764 99 (435) 44-24", new Guid("4bb403d4-8670-466f-a9dc-17dd09c9d546") },
                    { new Guid("e64f561b-978b-4822-9ddf-1e2b6e918490"), null, null, "+809 33 (579) 64-41", new Guid("d8dd96ce-4557-4993-959c-45a29c967d51") },
                    { new Guid("e650a900-c614-4ad1-9c48-92d92b3d1c00"), null, null, "+481 30 (995) 81-11", new Guid("7805e438-4982-4f20-9e68-baca0c631417") },
                    { new Guid("e6cbd2da-46d2-4753-a856-ee6e99952098"), null, null, "+562 86 (853) 69-87", new Guid("568a5cfd-171b-413d-addf-fe6ab58aa6d0") },
                    { new Guid("e77f7124-1467-4fb0-9143-b4e715d7f8f1"), null, null, "+124 47 (260) 97-60", new Guid("e1223f43-016e-41f5-b212-ab70a0ac01e2") },
                    { new Guid("e794bfdc-a721-4c91-8511-7bd8597a7f8c"), null, null, "+225 51 (526) 65-24", new Guid("f4d9bb48-d87b-420c-b2ef-f724726c7a08") },
                    { new Guid("e7a5fe91-2ebe-462f-ab83-a2d65734ac1f"), null, null, "+965 27 (168) 99-09", new Guid("4d792f39-989a-48bc-8528-2bda17a5967a") },
                    { new Guid("e805ddcc-0699-4631-bec1-d508224e9853"), null, null, "+207 78 (345) 11-85", new Guid("97d70a43-949c-4c03-9da7-fc16fdc0c86d") },
                    { new Guid("e831f62e-c7fc-4422-b8d8-da918e21a41f"), null, null, "+552 30 (753) 45-14", new Guid("dc04df94-1448-4899-bec4-692b13ea2748") },
                    { new Guid("e948bfa3-a283-43b4-997e-79a044c8cf73"), null, null, "+197 18 (582) 67-55", new Guid("aee768a4-2b67-47da-a692-ab2b1cd95c27") },
                    { new Guid("e9b872f8-04e1-44db-ab38-d3cfbcd5601d"), null, null, "+698 36 (060) 86-83", new Guid("bcb5583b-3b55-4ea8-b016-f74baf89e99a") },
                    { new Guid("e9d75e64-7087-4f00-8ef0-4a7871562f80"), null, null, "+368 69 (754) 70-37", new Guid("6ee9a7d3-8695-4b4a-9a7f-e035a03a4cc3") },
                    { new Guid("ea35b1de-1cfa-4b52-b05b-519396ae08ff"), null, null, "+89 37 (485) 88-09", new Guid("da687a7e-bca5-449f-ad43-32e0ac00fe15") },
                    { new Guid("eafadf6c-9233-41a9-bc45-871d358426a3"), null, null, "+261 11 (579) 78-58", new Guid("17b956d2-133d-4289-8a76-4633e194bce0") },
                    { new Guid("eb43eda2-b45d-467d-9716-7c1260a7027f"), null, null, "+863 03 (212) 49-46", new Guid("8a1cc6ac-cbbb-45b8-a858-79df665cbf01") },
                    { new Guid("eb9e4cb8-4fa9-4e79-a846-d0a1047683de"), null, null, "+704 24 (920) 92-67", new Guid("73850497-d7e2-4015-bf80-d8fc761772d3") },
                    { new Guid("ec0baa6b-83d0-41f5-b9fc-c4788088add6"), null, null, "+21 38 (973) 49-36", new Guid("b944ae23-efab-4fcb-bda0-6be21e2add96") },
                    { new Guid("ec131585-474b-4a15-a2a8-b2fd3c95334e"), null, null, "+330 21 (440) 36-90", new Guid("10a10ed0-e1f4-4de7-b631-e8c7d0d5eaa9") },
                    { new Guid("ec4c8b8c-8476-4c6c-b841-a7904127782a"), null, null, "+985 94 (577) 53-91", new Guid("8bbc87aa-2bdb-4898-83a2-ca540a697ac0") },
                    { new Guid("ed3c9dfb-25c5-48a1-a1d7-361762007e0a"), null, null, "+629 06 (035) 83-19", new Guid("dffee49d-d296-4315-aefd-9602dd01358c") },
                    { new Guid("ed763e43-57cd-4a05-a2d0-6f84d59c8d80"), null, null, "+333 54 (560) 13-78", new Guid("6375150d-9633-494e-ba79-b55f87d56afa") },
                    { new Guid("edb1876a-18de-4ab0-8e3f-dd77bdc19cbd"), null, null, "+499 56 (398) 16-01", new Guid("4af7ff34-3014-4da9-ba8e-e93cfaac4eaf") },
                    { new Guid("edf5f2d0-7919-4594-88e4-be843b0c5550"), null, null, "+181 41 (313) 39-28", new Guid("1546f9ad-e76e-4438-9513-2c0cdbcdc9dc") },
                    { new Guid("edfc1b99-6196-42cf-ae1a-153f20c2cdb8"), null, null, "+168 87 (680) 12-79", new Guid("716e3b4a-4381-424f-88d2-df0753a8cb13") },
                    { new Guid("ee236252-fdb3-4794-b0a7-8321154f4d59"), null, null, "+305 84 (664) 15-12", new Guid("655cd6fe-206e-4683-a0e5-f0108ee7f59f") },
                    { new Guid("ee564dd7-07ba-4947-860d-b31d0f538cb7"), null, null, "+694 22 (103) 64-45", new Guid("7e5e5ebc-3d4d-451a-884b-00a9d9f53676") },
                    { new Guid("ee613418-b39f-4073-b8df-dfc70b066743"), null, null, "+422 49 (022) 24-00", new Guid("94e92894-3b19-4c5f-9e95-0ec52116ec92") },
                    { new Guid("ee95a56f-72d7-42f6-a3eb-d12f0c2374b3"), null, null, "+460 27 (508) 50-66", new Guid("9a799371-7ad4-44c8-bcc3-759981e1573a") },
                    { new Guid("ee9f38ef-9f0f-4c93-ab1a-37727fe0554c"), null, null, "+195 69 (755) 95-36", new Guid("641c3d4a-a6ff-4cb3-b40a-665b9156a255") },
                    { new Guid("eea1a21c-3984-49b3-9493-d6c5df6806f8"), null, null, "+71 98 (389) 60-65", new Guid("77332645-fb25-478f-998c-36dd38aaba91") },
                    { new Guid("eecf8d4a-b5f8-41dd-924c-d954095822d1"), null, null, "+874 60 (388) 90-90", new Guid("222dda98-6fd2-4619-8709-1b78c7872ca8") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("eee6277a-ab8b-4c2c-ae42-317b22aa13ff"), null, null, "+89 83 (243) 74-63", new Guid("cd3bba51-ecbd-472a-a962-7f603574b446") },
                    { new Guid("efff5670-ccdb-42fb-a64d-6fe5c73a8c5e"), null, null, "+227 00 (492) 47-28", new Guid("8bbc88c0-c35c-496f-b3fc-e18f3d8bad18") },
                    { new Guid("f0078b52-8a6f-4a78-b7d4-7e7dbebcc12a"), null, null, "+623 05 (634) 87-62", new Guid("1747bd38-8325-47e2-8876-f2ff552a55c8") },
                    { new Guid("f074f000-0cc0-4b4e-b73b-b4e1c72b3305"), null, null, "+240 56 (296) 73-12", new Guid("4bb403d4-8670-466f-a9dc-17dd09c9d546") },
                    { new Guid("f122a2b0-eb65-4ec9-b635-8c5838503bfe"), null, null, "+821 50 (859) 86-66", new Guid("b5fe6c30-5f2d-462b-9dd2-bc5388f99ce5") },
                    { new Guid("f14728bf-efb5-4cd4-b201-d07c9d9f78f5"), null, null, "+401 39 (288) 52-50", new Guid("092e31f3-9b9a-4287-8cae-7fcd18feab47") },
                    { new Guid("f1d27c47-ab28-4747-b09c-7fdd733dc1e1"), null, null, "+343 74 (548) 45-92", new Guid("997402b2-514c-445f-9988-ae18a101181e") },
                    { new Guid("f2a59905-5ba9-474c-bca6-24fe2ef097f3"), null, null, "+959 66 (435) 57-81", new Guid("1546f9ad-e76e-4438-9513-2c0cdbcdc9dc") },
                    { new Guid("f3ad23a5-c6d9-4e12-923b-5f6249793dad"), null, null, "+814 59 (224) 08-24", new Guid("4fd873ab-a800-46d0-959f-d9f6189c846e") },
                    { new Guid("f3dacaa1-07e1-469b-8aef-ebdb2dab3e55"), null, null, "+229 17 (576) 69-33", new Guid("8892b0e2-0aef-404c-8681-2866126b786f") },
                    { new Guid("f45e6789-232c-4ca0-b701-fe0bd4e6eec4"), null, null, "+731 70 (431) 27-40", new Guid("73977b0d-a6cb-4576-bd4a-b7056acdccd3") },
                    { new Guid("f490eb50-d433-4867-942e-7859dca64d85"), null, null, "+713 82 (407) 36-70", new Guid("cc549d3d-c127-48fe-9320-69c0367cf0ef") },
                    { new Guid("f4b3b828-3236-4db3-a48b-fd77abcd47ff"), null, null, "+835 33 (565) 70-49", new Guid("3ca63884-385c-4ae8-ac07-f3dc2df24aae") },
                    { new Guid("f4b519c8-8614-42ea-98c5-de2e992e8ecc"), null, null, "+689 90 (440) 44-37", new Guid("655cd6fe-206e-4683-a0e5-f0108ee7f59f") },
                    { new Guid("f500fa05-76da-4cd3-9829-89f5044c53f2"), null, null, "+885 12 (916) 06-89", new Guid("8a1cc6ac-cbbb-45b8-a858-79df665cbf01") },
                    { new Guid("f5a32a4b-d359-4f44-924a-c50b9638bd26"), null, null, "+850 41 (148) 37-05", new Guid("c9de1952-448f-4a77-a4fa-b78a3751957a") },
                    { new Guid("f611bebb-e514-45b2-bda5-6142299716d2"), null, null, "+200 16 (827) 38-62", new Guid("e1223f43-016e-41f5-b212-ab70a0ac01e2") },
                    { new Guid("f66af8b9-cfe8-40d6-88ee-c213c35a63b7"), null, null, "+272 87 (087) 03-91", new Guid("69879006-dc0c-45ee-a1d8-571618a19f4d") },
                    { new Guid("f6e5d59e-cd5a-419a-bffe-9a3407145347"), null, null, "+366 27 (136) 59-06", new Guid("cefdf373-98f4-432b-bfc7-baaf121c554a") },
                    { new Guid("f703dcc5-fd34-44e0-978e-f2c6900eeb1c"), null, null, "+220 76 (672) 82-43", new Guid("c561cc5e-190d-4a91-8ea9-d03583fa3f86") },
                    { new Guid("f7225823-4db7-44db-b398-53cb594629db"), null, null, "+407 41 (522) 32-78", new Guid("e1223f43-016e-41f5-b212-ab70a0ac01e2") },
                    { new Guid("f7372ac7-f042-46c7-9dab-133195b664e0"), null, null, "+792 40 (185) 10-88", new Guid("146a249e-e614-41cc-98ab-d6287da977e5") },
                    { new Guid("f74363f2-f4c4-4bab-861b-5db2da011ac3"), null, null, "+335 11 (783) 86-86", new Guid("dfa0bf0e-13dc-416f-bb54-aaeb47a68545") },
                    { new Guid("f7a622a6-3300-4f3e-997f-6e89f4f5a626"), null, null, "+695 07 (555) 33-40", new Guid("96357562-82d6-4394-b4bf-5b698e1ad612") },
                    { new Guid("f7a7f5e3-6364-483c-9cf4-4883724fdc2d"), null, null, "+762 83 (265) 96-57", new Guid("857e5ff4-368c-45c8-909c-9cb05ea33802") },
                    { new Guid("f7a94a58-aeac-495f-be99-6cdd19d07141"), null, null, "+509 06 (508) 45-03", new Guid("5effd297-ddf3-4f40-afed-c85e49e3d248") },
                    { new Guid("f7ad5536-6833-44c4-a82f-5de0a339eb6c"), null, null, "+926 77 (783) 49-74", new Guid("dfa0bf0e-13dc-416f-bb54-aaeb47a68545") },
                    { new Guid("f7c84684-6b8d-456a-b7ed-fe8dbcd579e4"), null, null, "+782 44 (401) 15-09", new Guid("0639ab22-a867-435b-8c5b-7acf69750583") },
                    { new Guid("f7e1ec84-448f-4c19-b3c8-5f1be95a359f"), null, null, "+865 75 (450) 48-83", new Guid("1747bd38-8325-47e2-8876-f2ff552a55c8") },
                    { new Guid("f8e940be-ac0b-4153-ade9-c1928ef9b29c"), null, null, "+684 49 (997) 86-05", new Guid("d666c5aa-5c03-4391-8629-5cc681422ca2") },
                    { new Guid("f959a98c-98b5-4e05-9918-8bd6a76f5991"), null, null, "+752 21 (530) 52-48", new Guid("a6b4e3da-0d2b-4dbd-9f10-ea183f9d6225") },
                    { new Guid("f95f68a2-39b4-48bd-bb5c-62ec263bbac3"), null, null, "+856 50 (464) 54-85", new Guid("9dafc6e9-0e56-47f8-8b8b-4ca541841bd0") },
                    { new Guid("f99a7dc3-cab3-42a3-94b7-a1a67884eac4"), null, null, "+327 16 (882) 48-34", new Guid("ca7879c0-456f-4a95-94ad-0a58b61bfc27") },
                    { new Guid("f9b2744d-9e81-4f25-9458-897f5cf22ea9"), null, null, "+158 77 (238) 84-58", new Guid("e44b1f8c-951b-48de-a206-672ce80e3e29") },
                    { new Guid("fa0ecdcf-f734-4231-ad4c-15c62e020c50"), null, null, "+125 40 (492) 28-40", new Guid("5a6031a7-d008-4d4c-9a87-857d42759454") },
                    { new Guid("fa507ca0-e7ae-45e7-b898-82fe9aa81b84"), null, null, "+687 67 (321) 38-43", new Guid("cfc77b46-5660-4e53-bd9c-0ef309097b43") },
                    { new Guid("faf436f4-5f40-4abd-b290-b5b5f65555f6"), null, null, "+493 92 (893) 39-62", new Guid("86139076-e779-453a-8f87-64e1bfeeeccc") },
                    { new Guid("fb2c7f5e-af08-4ad5-812c-36cfbc6c2c47"), null, null, "+100 53 (678) 24-60", new Guid("c50f147c-0804-4f38-a70a-7b8d4109234d") },
                    { new Guid("fb5319db-3787-4467-aa87-4facfbd43ea5"), null, null, "+83 78 (491) 17-63", new Guid("24b96e86-5860-47b1-a6ec-9a832bafbb14") },
                    { new Guid("fbccb144-5641-4b17-ab8b-06ba523146fa"), null, null, "+582 90 (985) 47-63", new Guid("8513debb-cacb-47df-a4d3-e59f2a261b69") },
                    { new Guid("fbe8c73a-8e6f-48bb-ada8-0a880982a24c"), null, null, "+705 33 (816) 59-56", new Guid("605efc2a-1846-428c-a520-3c8efbd1c5d8") },
                    { new Guid("fc088438-4744-46db-a430-65154a1efb53"), null, null, "+901 26 (038) 01-82", new Guid("aa1380ad-62cc-4108-817a-4ac56a2c382d") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("fc7e9204-7e8c-43ac-9aaa-b25b78dae089"), null, null, "+656 29 (286) 19-03", new Guid("4ccb797f-65b1-4b8c-809c-fe110c01052b") },
                    { new Guid("fc884f55-cab5-4e40-846d-04031f93c5c8"), null, null, "+185 34 (390) 33-86", new Guid("4ec972f7-f6d0-4660-943e-5ad3d2557cfe") },
                    { new Guid("fc943cc4-9dce-4680-aa41-de17b4835baa"), null, null, "+741 13 (507) 39-28", new Guid("a7a63c10-9b55-47c6-9d56-8793ee29aafd") },
                    { new Guid("fd6cb3b8-b79e-4cc3-9ff4-d919c2d14608"), null, null, "+726 06 (104) 75-03", new Guid("d1fdc728-523b-49bf-b2d8-eee9a8bb93d1") },
                    { new Guid("fd75585c-214e-4f4f-ae0a-75f357b53a53"), null, null, "+103 94 (557) 24-86", new Guid("1c5135c6-32f4-4363-a0a3-5a8fb7357df1") },
                    { new Guid("feab4b0e-f20f-48bf-894c-4eabd91a43b7"), null, null, "+313 05 (606) 31-50", new Guid("8bbc87aa-2bdb-4898-83a2-ca540a697ac0") },
                    { new Guid("fefe3eb4-8475-4020-80c2-1084765143e9"), null, null, "+204 71 (060) 13-94", new Guid("568a5cfd-171b-413d-addf-fe6ab58aa6d0") },
                    { new Guid("ff531d5c-051a-4840-8bc1-7f1af61d469f"), null, null, "+175 32 (585) 67-14", new Guid("49922094-de40-49f9-8fe5-21e734ddaadc") },
                    { new Guid("ffae4e69-a55a-49d8-8bf0-9c6878b0755e"), null, null, "+712 50 (376) 99-16", new Guid("6507f7f4-4076-4fff-b89e-4205b52b6408") },
                    { new Guid("ffd04b05-c929-436f-98cb-e1d9479ece0d"), null, null, "+895 52 (470) 19-02", new Guid("cefdf373-98f4-432b-bfc7-baaf121c554a") }
                });

            migrationBuilder.InsertData(
                table: "UserParcelMachines",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "ParcelMachineId", "UserId" },
                values: new object[,]
                {
                    { new Guid("019d5d3f-eb30-43ae-a864-693bfdc4f8d4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ca9b4c98-140b-4455-8fe3-e367b8aa9247"), new Guid("57d5c043-44a4-43bb-80ee-1cbb791b2285") },
                    { new Guid("029b2b73-2c1f-4b20-9be1-976ac2fd483c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c85a741c-2db3-4255-9cb3-e7ba319c3b3b"), new Guid("3705daaf-a245-497f-b245-acd05a008711") },
                    { new Guid("0404ef80-a7e9-4ff0-acb3-3f9b5a666cbf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("26fa5931-8dc4-4cd7-b964-67e31b70ef54"), new Guid("a165efc8-0956-4593-9333-e1ab17939488") },
                    { new Guid("047e3441-de5f-4f7f-93da-26ffb04d21d8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("08bfef53-8160-4393-a169-238134272885"), new Guid("73aad8c3-cbed-4125-b80b-7db0735c3ac6") },
                    { new Guid("0c3e42cd-e49c-489e-9f0a-1b9ab87dd452"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("08b7e35e-b9df-4bcb-9d3c-45421f0346f5"), new Guid("5ffbbdb6-b588-4eef-811a-4b39d217f0a8") },
                    { new Guid("0d84efdb-b44d-4a2d-ac4f-ca0a77fefc37"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7c5fd36b-3b43-4ecf-97e4-f7a97ff67773"), new Guid("dc04df94-1448-4899-bec4-692b13ea2748") },
                    { new Guid("167dcfb3-17cd-4b40-be2d-af75180e5f19"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00e321a0-b3cd-4efa-ad5f-acd2a6277973"), new Guid("ef14d144-d1c3-49fb-9e25-1889be79f4e3") },
                    { new Guid("1c0ad816-ac7d-4008-922c-716f291be995"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8ad721e3-df57-46b7-8270-389836d08360"), new Guid("dfa0bf0e-13dc-416f-bb54-aaeb47a68545") },
                    { new Guid("1cce53a0-a13b-4038-a5f0-e08f5915a2d4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d4206192-5ee9-4cab-a69d-74a89bf65d4d"), new Guid("2063153a-a610-4c40-9ddd-456ef0b560db") },
                    { new Guid("2851ff66-3c4c-4ac6-85ac-1b48432c03f0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("58a76774-89af-474b-b5ea-9b18e6499c2d"), new Guid("34d672c5-050e-4c3c-8018-0107a72f13f5") },
                    { new Guid("2a7da00a-09d3-4e54-b70c-4dbcd5c198e8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("eb8a744d-7e24-42db-bb6c-e82a8138731d"), new Guid("872eccf4-a3fa-43c5-ab2e-ac6f6c9e4f17") },
                    { new Guid("2b7bd927-8cf6-4ca3-ab73-8dff5a0fb179"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5290d396-dbd8-4934-b4a7-5c2f1f6af893"), new Guid("e1223f43-016e-41f5-b212-ab70a0ac01e2") },
                    { new Guid("31f8468b-ff88-4564-87ab-51cbbfefb3c9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("455f3b1f-1405-498b-a7da-b26d99b7223c"), new Guid("ff75563e-5545-46de-a4b3-3e0727d74698") },
                    { new Guid("321672c0-400a-438e-aaf2-d2fb597f090c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d4206192-5ee9-4cab-a69d-74a89bf65d4d"), new Guid("7f910a03-763a-4cdb-bbcb-8241bae6fc96") },
                    { new Guid("369350e4-935a-417a-b010-0dab6434ad1b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("62636c8c-9d0d-4357-bb21-4d11946dd2a6"), new Guid("e6b167e1-2f8a-4aa9-b766-dcb40c4c65b7") },
                    { new Guid("38d12093-4f5f-46c0-b913-5d4d91fa58c2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b3af4bcd-f779-4cc8-95f7-ab948ef9bf0b"), new Guid("a01a13e5-a8d1-4048-b8b2-24cdfac5f11e") },
                    { new Guid("481922ee-d886-4aaf-badc-26e8de9debac"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("91e83f1d-b0fb-4d71-9a46-e843ef268d7d"), new Guid("7805e438-4982-4f20-9e68-baca0c631417") },
                    { new Guid("4999918f-94ae-402c-942e-b33ffae14015"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("017dd6b5-4ed7-4f02-ad43-3b51a7ad4bb9"), new Guid("7f910a03-763a-4cdb-bbcb-8241bae6fc96") },
                    { new Guid("4ce897cd-2805-4719-b227-35fb1317b5d7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("839a78cb-2a67-4249-a872-0e891187d566"), new Guid("d666c5aa-5c03-4391-8629-5cc681422ca2") },
                    { new Guid("4f9693b8-dc89-4c21-8490-cc26141baf7f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7c5fd36b-3b43-4ecf-97e4-f7a97ff67773"), new Guid("a01a13e5-a8d1-4048-b8b2-24cdfac5f11e") },
                    { new Guid("54190882-cd2e-42c3-903a-2f383ac19570"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5f359b3f-8c20-4a2d-9d78-ba4e31c65633"), new Guid("a165efc8-0956-4593-9333-e1ab17939488") },
                    { new Guid("5614e2f6-b4dd-4344-85bb-89289674aca2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d4206192-5ee9-4cab-a69d-74a89bf65d4d"), new Guid("a8a8fdd8-4ded-4cee-9b8c-87f2285d7eab") },
                    { new Guid("58024571-13e3-42dc-bf1e-c01fa3db4d7f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1f1f7a4a-e508-4549-9d13-c652fabbae36"), new Guid("7e5e5ebc-3d4d-451a-884b-00a9d9f53676") },
                    { new Guid("59ab169b-c6dc-4610-89a1-3df3617c1997"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d2f56d97-f52d-4e0d-ba07-2c2ab3337e5e"), new Guid("437bc41c-af0d-4443-809f-276b155b8846") },
                    { new Guid("66f835ae-990c-4f0d-8438-d4ad50fafd6b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("26fa5931-8dc4-4cd7-b964-67e31b70ef54"), new Guid("6172d849-4ee5-486f-8f97-d2bbcfc40084") },
                    { new Guid("6b24a4fe-eb82-4619-b050-02e3515063bd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b3af4bcd-f779-4cc8-95f7-ab948ef9bf0b"), new Guid("eedd859d-8af5-43b7-8938-5bce7dd89153") },
                    { new Guid("6bafd325-123d-4f5c-a944-966880a16fd8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1f1f7a4a-e508-4549-9d13-c652fabbae36"), new Guid("749d009d-0557-4289-976a-50a7e345a281") },
                    { new Guid("6f26e68d-fffa-4077-b496-c6947cdda24f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("91e83f1d-b0fb-4d71-9a46-e843ef268d7d"), new Guid("b71f69da-e20d-4b25-b2fb-00d5eb1c9002") },
                    { new Guid("714e73ac-e2cd-4f33-b5db-ac0307a3a012"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5290d396-dbd8-4934-b4a7-5c2f1f6af893"), new Guid("9e4f824d-b29a-4ec5-b3a1-111d46f41ecb") },
                    { new Guid("796e81a4-500d-46fe-8abd-dcfd6dfd5391"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f4ee338a-2238-4a81-821d-b70987ca3c49"), new Guid("2a328a80-898f-4b62-921d-731137bebe9f") },
                    { new Guid("81408587-e1ab-49b5-8dd4-9ec61db19078"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9935a97f-468c-41ff-a47e-6cb2275d892b"), new Guid("e2dba597-b132-4b1a-a46f-540ebc581408") },
                    { new Guid("8ca081ef-ef5c-4c20-8d8f-5604623bd5cd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1202d374-094e-4967-809f-0c9d88a92d3a"), new Guid("c431ef46-de70-4dba-a2b4-061b2a219ebc") }
                });

            migrationBuilder.InsertData(
                table: "UserParcelMachines",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "ParcelMachineId", "UserId" },
                values: new object[,]
                {
                    { new Guid("9197adfe-32ca-4641-a793-c552ee33abdd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b3af4bcd-f779-4cc8-95f7-ab948ef9bf0b"), new Guid("4bfa50d6-7b76-402d-afe8-4b558ee6165b") },
                    { new Guid("9374586b-05c1-4917-a542-be9e48cb1353"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("60e1e7cf-e49b-45bf-912d-5216f1bb9f1c"), new Guid("e9781110-3553-481f-bb3a-7ca26a63a83b") },
                    { new Guid("9833712e-de67-4bea-add8-eedc52c36598"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ff9578ad-c8a4-47c7-a6b6-d99d0bd5ccd7"), new Guid("96389a1d-3bc8-465b-ba35-3027877a9981") },
                    { new Guid("984d4fed-bb17-483e-a320-889a3969342b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5290d396-dbd8-4934-b4a7-5c2f1f6af893"), new Guid("d8361619-ae4f-4db1-9eb9-291e4814a381") },
                    { new Guid("992b0424-ea31-457d-bd28-2b6da1be53dc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f2728ea9-fee8-48f0-9079-7bc271322fdc"), new Guid("a161bc80-bb44-439e-bb80-442569d93b23") },
                    { new Guid("a45ac1e8-3717-467f-9901-999f69f81059"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1f1f7a4a-e508-4549-9d13-c652fabbae36"), new Guid("7f910a03-763a-4cdb-bbcb-8241bae6fc96") },
                    { new Guid("a4988012-b1ba-4b56-90e7-8e53d1fb2819"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("543a3672-3ec0-4226-b87e-ccd2c70cd4e4"), new Guid("eedd859d-8af5-43b7-8938-5bce7dd89153") },
                    { new Guid("a7196f84-64dd-48a3-8f7a-69f80e57ea4a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a3a70b4f-c475-44ef-92bc-5fd3442a7a50"), new Guid("d9295c19-5c11-40bb-ba7c-c1b368114ac0") },
                    { new Guid("a73007a9-7ade-42a8-8bb7-560b7856df50"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7bd1a527-3c42-475c-818b-e39a99562fd9"), new Guid("013a7602-b915-4485-89ea-d3291ed9cab8") },
                    { new Guid("b197b597-67d6-4a64-8703-bd9c4d10b6de"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d4206192-5ee9-4cab-a69d-74a89bf65d4d"), new Guid("9dafc6e9-0e56-47f8-8b8b-4ca541841bd0") },
                    { new Guid("b1e46111-bd23-4a1f-be34-71adfe81ea74"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("455f3b1f-1405-498b-a7da-b26d99b7223c"), new Guid("0b440e9a-ee26-43ee-9d40-46328f22a228") },
                    { new Guid("b641f8b6-4443-4c39-a900-93ac3d5c02a5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ff9578ad-c8a4-47c7-a6b6-d99d0bd5ccd7"), new Guid("6709762d-580f-4c32-8f92-b1daa6e22c27") },
                    { new Guid("b91ca401-4f64-4127-b8ae-31588db05acb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b3af4bcd-f779-4cc8-95f7-ab948ef9bf0b"), new Guid("7902b014-f441-4bad-a55f-7656352c84e7") },
                    { new Guid("b9a1f201-bd32-49c8-897b-d2fd20ad0f56"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4ba4989a-a8b9-4cf5-9e86-a40e417ff062"), new Guid("dc04df94-1448-4899-bec4-692b13ea2748") },
                    { new Guid("bd8666a5-6704-4f2d-90c4-b9248b9f928d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("da035ca1-996e-4ad3-8b6c-2cce646fa4da"), new Guid("63bd6aad-fd4d-4a2d-b0ee-341253297e79") },
                    { new Guid("c3f04d2a-63d2-4242-af82-21e6fa90dd54"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("65f9bbd7-4da4-4c4f-aa52-6f7e5bf7dd99"), new Guid("551cb7a5-2acf-469f-be65-7a549dccf51f") },
                    { new Guid("ca0e4d61-7cac-485b-998a-68ae1ccee3bb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("878f73b3-ecca-4152-b101-4fe4d5bc7f92"), new Guid("7b354f95-20a6-4d69-abe1-b5a212feb069") },
                    { new Guid("caa6b19e-a52d-4c59-b23f-3891357a1d4c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("433372c4-7775-47c4-a527-447eb90835e2"), new Guid("c311c4ad-bbcf-418b-8259-eec5ae72eb71") },
                    { new Guid("cb9eb93a-f052-4f2f-bf72-00fc60c7664f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e9a51c17-9445-48d3-94ab-4ad09bb02de4"), new Guid("1546f9ad-e76e-4438-9513-2c0cdbcdc9dc") },
                    { new Guid("d46a5517-4d12-41c6-ac87-178e065fdf95"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ecb99e0f-f5cf-4c1e-8dc8-29e656e9eb9e"), new Guid("2eb253e8-852b-4b59-bbd3-41b1d962644b") },
                    { new Guid("e5e6606b-8439-4058-8d1c-4782f224b8ec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("da035ca1-996e-4ad3-8b6c-2cce646fa4da"), new Guid("cefdf373-98f4-432b-bfc7-baaf121c554a") },
                    { new Guid("e6d104bf-b2b2-4242-bdc9-bfd8c536601e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5290d396-dbd8-4934-b4a7-5c2f1f6af893"), new Guid("861c20c6-b2fe-4d03-a2b4-ae2380f7edc5") },
                    { new Guid("ef958f62-dc51-4e91-99a1-d87fb3c2cbcc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1f1f7a4a-e508-4549-9d13-c652fabbae36"), new Guid("78615ad6-0a03-477e-a515-c98b1a96475d") },
                    { new Guid("f17da271-2a66-4d8a-89aa-6f584409f16b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("11c40e7e-4a84-4a7c-a9e9-dbe6ce92159b"), new Guid("dd2a73f4-0d43-45df-8aa0-196122e00fc2") },
                    { new Guid("f4bd4f57-3307-4dad-bacd-1949fee0b0db"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("88f4469b-15bf-408d-89d0-bd95968d61d6"), new Guid("427485d5-0faa-4f9a-9c6f-70317d50831a") },
                    { new Guid("f8c728f9-34f8-401f-9fe9-9de2e3732991"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5b14e8f7-bf92-458f-9591-1c6f68ba3eef"), new Guid("34d672c5-050e-4c3c-8018-0107a72f13f5") },
                    { new Guid("f9fd81e3-c7d2-433b-9b49-e3d9452d43ec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0e2be55a-06a0-4e73-a58a-bfc972ca90eb"), new Guid("3dc1a6db-3bf2-4650-b501-abf7ef284b3c") },
                    { new Guid("fb17a849-ec54-4504-a27d-6dfa35f58364"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5b14e8f7-bf92-458f-9591-1c6f68ba3eef"), new Guid("f472d28b-1df9-4c84-8ceb-3254f55042e7") }
                });

            migrationBuilder.InsertData(
                table: "UserPostBranches",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PostBranchId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0d949c75-5c1c-4436-b21f-bfba5fb30194"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9f13969f-5d19-424c-88ca-a41305b15ff4"), new Guid("a01a13e5-a8d1-4048-b8b2-24cdfac5f11e") },
                    { new Guid("155539ef-f99b-4d6d-a514-8459607bdbe5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d973511c-c8cf-403b-a0f8-ef151445e357"), new Guid("7f910a03-763a-4cdb-bbcb-8241bae6fc96") },
                    { new Guid("19493c48-ea35-4141-a68b-30e4bb4aad51"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("136c48c1-360f-4178-9140-3be6686b69a1"), new Guid("7f910a03-763a-4cdb-bbcb-8241bae6fc96") },
                    { new Guid("1d6d00c8-790a-483a-bf07-956ca6518cb3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7cf5a4a3-bf46-44fb-a20a-626a8a808372"), new Guid("e9781110-3553-481f-bb3a-7ca26a63a83b") },
                    { new Guid("1ebc1c81-fbe2-45b2-9212-f1dacf1a5dac"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c6b4cbbe-dd01-441c-b872-a3b17e6885e2"), new Guid("872eccf4-a3fa-43c5-ab2e-ac6f6c9e4f17") },
                    { new Guid("1edad5d0-562a-4b04-822c-b1bb91136ba1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c5c238c7-5301-45db-aa29-74bd768d2fa0"), new Guid("013a7602-b915-4485-89ea-d3291ed9cab8") },
                    { new Guid("1f7db354-6f5c-4794-a94b-aa5b0cda5b67"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8a8c2823-bcec-4972-afc2-717be78aa4ba"), new Guid("551cb7a5-2acf-469f-be65-7a549dccf51f") },
                    { new Guid("217b8aa8-44cb-4e0d-8686-3011c729e15e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("534b7b7a-77b0-45f6-bfcd-28b23bcbc428"), new Guid("3705daaf-a245-497f-b245-acd05a008711") },
                    { new Guid("23efa949-35ff-44b7-af9f-81e429ccc0a4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("66da549a-10be-4479-b0ff-7b11555427af"), new Guid("0b440e9a-ee26-43ee-9d40-46328f22a228") },
                    { new Guid("241a4190-361e-404f-b618-801e692c470f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a01d038b-3b37-4a6f-9f6b-b24ad8c48059"), new Guid("57d5c043-44a4-43bb-80ee-1cbb791b2285") },
                    { new Guid("2754266b-993e-4941-9048-1b5fed5643c2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1f2414cf-0390-4162-82d6-0c94f909f647"), new Guid("e2dba597-b132-4b1a-a46f-540ebc581408") },
                    { new Guid("314ce8a7-c602-4985-90d4-7beaf87132ff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("93c288f9-ec1b-4eba-abf7-1983043ec2ac"), new Guid("e1223f43-016e-41f5-b212-ab70a0ac01e2") },
                    { new Guid("349d1688-2ffe-4850-a09d-be19413c9200"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("57e7905d-3951-43b8-9dad-1350da8ff2b3"), new Guid("c431ef46-de70-4dba-a2b4-061b2a219ebc") },
                    { new Guid("385b994f-464a-40c8-ace9-70928793712f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("15d66f9e-fc40-4c15-ae0c-a031902012cb"), new Guid("34d672c5-050e-4c3c-8018-0107a72f13f5") }
                });

            migrationBuilder.InsertData(
                table: "UserPostBranches",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PostBranchId", "UserId" },
                values: new object[,]
                {
                    { new Guid("49f836ec-2796-4437-8b49-e73d5087cfc4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("08080468-af45-49eb-a130-6d96a99fd932"), new Guid("2a328a80-898f-4b62-921d-731137bebe9f") },
                    { new Guid("5eaf12a5-d35d-4984-b538-5a336eac97db"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("cf970b75-99a7-4312-8f04-a3a2220c73c4"), new Guid("9e4f824d-b29a-4ec5-b3a1-111d46f41ecb") },
                    { new Guid("645d6dad-4263-42a4-947a-b11f75f6f234"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("cf970b75-99a7-4312-8f04-a3a2220c73c4"), new Guid("861c20c6-b2fe-4d03-a2b4-ae2380f7edc5") },
                    { new Guid("6936c639-be27-4d7a-957a-e5720840935b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b2bad618-e322-4db3-9583-2b7564e1273f"), new Guid("a165efc8-0956-4593-9333-e1ab17939488") },
                    { new Guid("6f70abee-6e4c-4dda-bdde-c45c32c17c62"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8151f542-7470-48f2-9c2f-30e7914de3e3"), new Guid("7f910a03-763a-4cdb-bbcb-8241bae6fc96") },
                    { new Guid("7350c776-b3a9-4258-9e97-4b3ab8011d9f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f90c14bd-5b41-46ea-9074-2f19771c86f7"), new Guid("7902b014-f441-4bad-a55f-7656352c84e7") },
                    { new Guid("75497018-5fec-448f-9457-c35223c5b872"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0ba9e586-4ee4-464c-938d-ae15298c6dd5"), new Guid("c311c4ad-bbcf-418b-8259-eec5ae72eb71") },
                    { new Guid("7fe4dfcc-c888-4018-b790-230b92cb17ad"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("08080468-af45-49eb-a130-6d96a99fd932"), new Guid("d666c5aa-5c03-4391-8629-5cc681422ca2") },
                    { new Guid("834bc247-3149-4de6-8c47-2c67da639c9a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("32bb712d-6263-446d-9472-80edd39f824b"), new Guid("d9295c19-5c11-40bb-ba7c-c1b368114ac0") },
                    { new Guid("882d9583-16fe-48bf-92dd-797db0c63262"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("08080468-af45-49eb-a130-6d96a99fd932"), new Guid("6172d849-4ee5-486f-8f97-d2bbcfc40084") },
                    { new Guid("89617a21-c9f5-401e-b087-c5777b13dc93"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("401b5a57-79c1-402b-9447-d39a95a308a8"), new Guid("eedd859d-8af5-43b7-8938-5bce7dd89153") },
                    { new Guid("8bb32796-3c81-4e31-8e44-8b89b5525896"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2e1a4706-c69f-4640-b9ac-34783bc0599a"), new Guid("437bc41c-af0d-4443-809f-276b155b8846") },
                    { new Guid("8dcf21bd-0200-4f1e-bf4e-e4ceaeaae1ef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c870cd44-790c-47f5-a09e-4acc61043248"), new Guid("cefdf373-98f4-432b-bfc7-baaf121c554a") },
                    { new Guid("968084c3-d444-4877-a607-fd97e3586e01"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1e79a388-d870-4b99-866c-41e9e6a263ba"), new Guid("dd2a73f4-0d43-45df-8aa0-196122e00fc2") },
                    { new Guid("96e139ef-ea2b-49fe-8b0e-48a3e175ec98"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c5c238c7-5301-45db-aa29-74bd768d2fa0"), new Guid("7805e438-4982-4f20-9e68-baca0c631417") },
                    { new Guid("9a8e3229-0e27-40a5-b5a1-906e3df23f24"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1e79a388-d870-4b99-866c-41e9e6a263ba"), new Guid("dfa0bf0e-13dc-416f-bb54-aaeb47a68545") },
                    { new Guid("9cd09255-9f7b-443f-ace1-1eb6b09d12ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b02ffc23-9d10-460f-88ae-0137ffe31669"), new Guid("a8a8fdd8-4ded-4cee-9b8c-87f2285d7eab") },
                    { new Guid("9d6767c9-6700-4738-8d69-a1080aee2cb9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5c49af2b-317f-479d-b47d-2bcb53c5ec76"), new Guid("78615ad6-0a03-477e-a515-c98b1a96475d") },
                    { new Guid("9ea1d83a-4482-4fa0-a3bc-71233678dc9c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1e79a388-d870-4b99-866c-41e9e6a263ba"), new Guid("7b354f95-20a6-4d69-abe1-b5a212feb069") },
                    { new Guid("9f18574b-489f-4569-ace8-9dc4a3033f91"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("caa7b082-1933-48e1-95ff-b0cce8725ad3"), new Guid("73aad8c3-cbed-4125-b80b-7db0735c3ac6") },
                    { new Guid("a8aac67c-b172-4103-b92d-50cf976a825c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("caa7b082-1933-48e1-95ff-b0cce8725ad3"), new Guid("2063153a-a610-4c40-9ddd-456ef0b560db") },
                    { new Guid("b2b73909-2b8d-44b9-8521-782af924bd1f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("94e03200-bc54-4902-9e70-3843f682c726"), new Guid("d8361619-ae4f-4db1-9eb9-291e4814a381") },
                    { new Guid("bef213a9-423d-4cf3-8bb0-55e359d5aff5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("17201d81-8ab5-490d-86a9-58bc2b51ae89"), new Guid("2eb253e8-852b-4b59-bbd3-41b1d962644b") },
                    { new Guid("bfc7b25a-27c4-406d-8fb6-37a9bfa10861"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4abcaad7-23df-49d1-a77a-7af2874321c9"), new Guid("eedd859d-8af5-43b7-8938-5bce7dd89153") },
                    { new Guid("c112be16-cefb-41ab-ba54-52fff6ecd194"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("236b0ad7-2c49-488e-bf89-7e01fcc50e03"), new Guid("a165efc8-0956-4593-9333-e1ab17939488") },
                    { new Guid("c142aceb-5938-431e-ab10-44398b7827b0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("15d66f9e-fc40-4c15-ae0c-a031902012cb"), new Guid("9dafc6e9-0e56-47f8-8b8b-4ca541841bd0") },
                    { new Guid("c322e4f3-7ac1-45cc-91fa-cb660ffab75b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("cf970b75-99a7-4312-8f04-a3a2220c73c4"), new Guid("e6b167e1-2f8a-4aa9-b766-dcb40c4c65b7") },
                    { new Guid("c4b674ad-1969-4e8c-93aa-be7e6cfc4148"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1f2414cf-0390-4162-82d6-0c94f909f647"), new Guid("a01a13e5-a8d1-4048-b8b2-24cdfac5f11e") },
                    { new Guid("ca860d7e-479b-4189-b835-5bbb823ab645"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("aed1f991-28ff-47bb-98d6-71a94e3d2cd2"), new Guid("4bfa50d6-7b76-402d-afe8-4b558ee6165b") },
                    { new Guid("ce10b468-af02-486c-8c83-2f4d3e84dc3a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("fc50fe3a-eb3f-4320-a0b2-59e050db9d7d"), new Guid("34d672c5-050e-4c3c-8018-0107a72f13f5") },
                    { new Guid("cfae9d88-6dbe-4d13-a98f-bec17fd904dd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b08e8e4d-9ad3-4e09-9cd2-4852282cf47c"), new Guid("3dc1a6db-3bf2-4650-b501-abf7ef284b3c") },
                    { new Guid("d02ba25b-78a2-4dd1-95d6-8fba6cd37332"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7cf5a4a3-bf46-44fb-a20a-626a8a808372"), new Guid("ef14d144-d1c3-49fb-9e25-1889be79f4e3") },
                    { new Guid("d3415380-aa69-4eed-8ad4-f9affc6829e5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("87ca24d4-68b9-4b38-a4c4-62d8379ed40d"), new Guid("427485d5-0faa-4f9a-9c6f-70317d50831a") },
                    { new Guid("d8648bb1-479a-49ba-bc72-1c72112c44f3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e09f9c22-f55a-47b3-9c73-1a34c059bd17"), new Guid("f472d28b-1df9-4c84-8ceb-3254f55042e7") },
                    { new Guid("db6eff7f-f6c3-462f-b887-485c86aa1d1e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1e79a388-d870-4b99-866c-41e9e6a263ba"), new Guid("a161bc80-bb44-439e-bb80-442569d93b23") },
                    { new Guid("e527edda-7bec-445f-add4-96e90e4a38b7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4a3f347e-2eed-48c0-b67e-14a25a6ea8af"), new Guid("5ffbbdb6-b588-4eef-811a-4b39d217f0a8") },
                    { new Guid("e7c05620-6adc-4de4-8d07-e430aa74a000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("dc4d0f86-9a11-496b-b75c-14bb61a636e4"), new Guid("6709762d-580f-4c32-8f92-b1daa6e22c27") },
                    { new Guid("e9d13766-f82e-408e-afb2-d28357692e48"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("21faa1a1-e583-43f4-8795-31b4e9e8198b"), new Guid("ff75563e-5545-46de-a4b3-3e0727d74698") },
                    { new Guid("eceb35e4-c6c2-4e8d-a406-a5142b4f9301"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("534b7b7a-77b0-45f6-bfcd-28b23bcbc428"), new Guid("63bd6aad-fd4d-4a2d-b0ee-341253297e79") },
                    { new Guid("f105e56d-95b7-44a4-9ec4-8fcd2d30de49"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6b0a28fd-7a63-4fd8-9c96-bba3f123e142"), new Guid("b71f69da-e20d-4b25-b2fb-00d5eb1c9002") },
                    { new Guid("f42d809c-ed5e-4f1a-9972-d617aace5730"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("136c48c1-360f-4178-9140-3be6686b69a1"), new Guid("dc04df94-1448-4899-bec4-692b13ea2748") },
                    { new Guid("f98e3149-f2f6-4e02-ba39-0459c109f7db"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f673f75a-2f50-43b2-ac5f-348d781cc9f1"), new Guid("96389a1d-3bc8-465b-ba35-3027877a9981") }
                });

            migrationBuilder.InsertData(
                table: "UserPostBranches",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PostBranchId", "UserId" },
                values: new object[,]
                {
                    { new Guid("f9b23b6a-d7e4-48b4-8231-0fe79ef9b374"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b02ffc23-9d10-460f-88ae-0137ffe31669"), new Guid("749d009d-0557-4289-976a-50a7e345a281") },
                    { new Guid("fa013875-ca82-4329-8cb1-40fecc2f0eab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4dc75159-3062-4e73-bab6-9f860de1577c"), new Guid("1546f9ad-e76e-4438-9513-2c0cdbcdc9dc") },
                    { new Guid("fb7cb92c-c6e9-4620-91fc-9713d03b4e7c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ad395cb9-05b5-49d1-af21-f21f7eb4f83a"), new Guid("dc04df94-1448-4899-bec4-692b13ea2748") },
                    { new Guid("fed609aa-34ae-47ab-9119-5ee57d605d07"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("534b7b7a-77b0-45f6-bfcd-28b23bcbc428"), new Guid("7e5e5ebc-3d4d-451a-884b-00a9d9f53676") }
                });

            migrationBuilder.InsertData(
                table: "UserPromoCodes",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PromoCodeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("02b0cf65-84ec-4aeb-9d67-3fae6c14bc35"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a1964fbd-5b30-4b68-b77b-17a7da990984"), new Guid("872eccf4-a3fa-43c5-ab2e-ac6f6c9e4f17") },
                    { new Guid("08675497-4908-4d78-aad3-3fa68ff020c1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ca18a626-35d4-4bbd-b354-94835f4ae61b"), new Guid("5ffbbdb6-b588-4eef-811a-4b39d217f0a8") },
                    { new Guid("1297defd-267f-4c96-b917-cdbcf404e5ca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c75fd901-fd64-4c4e-9d18-de23cebecb44"), new Guid("63bd6aad-fd4d-4a2d-b0ee-341253297e79") },
                    { new Guid("1a66276f-f892-4e0d-931c-a9fc35a79bee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("74905bec-cb42-461c-a66a-660dc45aa10e"), new Guid("a165efc8-0956-4593-9333-e1ab17939488") },
                    { new Guid("24ebd266-c1fd-499c-8af5-561b7b724217"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("23af15d0-08c0-47d0-9000-f51636970523"), new Guid("dd2a73f4-0d43-45df-8aa0-196122e00fc2") },
                    { new Guid("26a4f3ef-9c4f-4f42-8f70-4072c5d52a94"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e59ad964-f4b5-408b-b749-81fa8e318c19"), new Guid("013a7602-b915-4485-89ea-d3291ed9cab8") },
                    { new Guid("317897ee-2dea-4036-a15d-96c2aeaf08bb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("cb121444-a460-43f8-bcec-b40fe4edecbe"), new Guid("f472d28b-1df9-4c84-8ceb-3254f55042e7") },
                    { new Guid("433b7ba9-e2c7-4be1-9e7f-0ea80d89cad8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("130b5cbd-da33-4062-826a-92595ae17e4d"), new Guid("7f910a03-763a-4cdb-bbcb-8241bae6fc96") },
                    { new Guid("43fb4e76-196c-4b4f-8827-a4b7805ce28b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7a614bdb-8816-436c-8f4e-33a97564be60"), new Guid("a165efc8-0956-4593-9333-e1ab17939488") },
                    { new Guid("4776afde-4c68-408d-a9cc-6727607b0865"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("67b13605-0510-4427-b340-12d353eb2794"), new Guid("7902b014-f441-4bad-a55f-7656352c84e7") },
                    { new Guid("49d27c2b-c449-4055-b474-df85ca09f950"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a90c17a5-755e-419e-ae3f-8dced8eb9ec1"), new Guid("427485d5-0faa-4f9a-9c6f-70317d50831a") },
                    { new Guid("4e8f33c8-e726-4bb6-8f73-8e9ab8485175"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8d96f8a3-9658-48b3-95e7-5856ce2f74df"), new Guid("78615ad6-0a03-477e-a515-c98b1a96475d") },
                    { new Guid("543a11dd-50a3-4203-9290-abcfc83c010c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6acad770-688d-4d76-a46b-13a339469528"), new Guid("ff75563e-5545-46de-a4b3-3e0727d74698") },
                    { new Guid("5702219f-37a6-43d2-9790-a73fabd3ffb2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("cded10f0-7a52-401e-9a7b-69e485c1e9a6"), new Guid("2063153a-a610-4c40-9ddd-456ef0b560db") },
                    { new Guid("58e78b40-d1b7-4caa-a9b5-ba9f236a9066"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d382371b-33f7-4393-8af8-10e1e3ec89a6"), new Guid("9dafc6e9-0e56-47f8-8b8b-4ca541841bd0") },
                    { new Guid("5c38e0ac-e034-4929-8258-74065e585fa9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6238dd6d-8e72-4e12-b7dd-ac900a36c4a8"), new Guid("e1223f43-016e-41f5-b212-ab70a0ac01e2") },
                    { new Guid("66a706ea-026f-4d50-ae16-3885205c6187"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9efe632d-8299-419d-a992-76309ff8fbce"), new Guid("dc04df94-1448-4899-bec4-692b13ea2748") },
                    { new Guid("66b04fd7-ca20-4130-99d4-d257715df6bd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2d36f39e-1bf1-4293-88d7-184f1e9b8fc2"), new Guid("eedd859d-8af5-43b7-8938-5bce7dd89153") },
                    { new Guid("678457af-6108-41e8-81c1-7adfb3f0670a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a6d68c29-78fa-4db3-b3c4-b99b1fe3ac36"), new Guid("e9781110-3553-481f-bb3a-7ca26a63a83b") },
                    { new Guid("682cc3bb-3c13-457c-92c3-ef92065a938b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6a8f8eec-2799-4c76-8376-4c0dd4d8007b"), new Guid("7e5e5ebc-3d4d-451a-884b-00a9d9f53676") },
                    { new Guid("7048c63c-46ed-468f-9b17-ad79e382c0af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7a614bdb-8816-436c-8f4e-33a97564be60"), new Guid("437bc41c-af0d-4443-809f-276b155b8846") },
                    { new Guid("73c14e73-cd07-46f4-bbd5-566e85944295"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ca19d085-a2d7-41e1-8746-7dcde135b223"), new Guid("2a328a80-898f-4b62-921d-731137bebe9f") },
                    { new Guid("82fbeb23-dea7-437a-92ac-f72ca392cdcc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b7e78115-07e8-4be3-9fd7-1600fb5560f9"), new Guid("7f910a03-763a-4cdb-bbcb-8241bae6fc96") },
                    { new Guid("834159a2-5875-404a-ba4a-86a95082aaf3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8d96f8a3-9658-48b3-95e7-5856ce2f74df"), new Guid("a8a8fdd8-4ded-4cee-9b8c-87f2285d7eab") },
                    { new Guid("859b045f-0cfb-4a25-b94e-b3a573b03f0b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d9b12bfa-6fbc-4c8b-8ac6-27a2a2bbec18"), new Guid("a161bc80-bb44-439e-bb80-442569d93b23") },
                    { new Guid("88f95532-edf0-40a2-9ab4-670af23a5091"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("cded10f0-7a52-401e-9a7b-69e485c1e9a6"), new Guid("861c20c6-b2fe-4d03-a2b4-ae2380f7edc5") },
                    { new Guid("90b05aea-bbd3-48ac-80fd-3a19002fad24"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e0979182-16b7-4e7d-a6cc-3b6317c0d5b4"), new Guid("eedd859d-8af5-43b7-8938-5bce7dd89153") },
                    { new Guid("93f2cd63-ade4-454d-83df-2acf0cded231"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c293f160-1503-4d76-96b0-3cdcf89feb84"), new Guid("2eb253e8-852b-4b59-bbd3-41b1d962644b") },
                    { new Guid("95afcd17-01a6-46fa-98c1-35cb369bc769"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3eef3abf-4f7d-4f2e-bc3a-78f0dbb4a8d4"), new Guid("551cb7a5-2acf-469f-be65-7a549dccf51f") },
                    { new Guid("9c364499-0042-4670-87d1-766387bf3863"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f965e4ab-271c-4960-9255-fac5a35329f0"), new Guid("0b440e9a-ee26-43ee-9d40-46328f22a228") },
                    { new Guid("9d22a9eb-297d-4981-8c24-5cadee11390f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("263d1d6c-644b-42a2-95b1-c13cf3a75639"), new Guid("c431ef46-de70-4dba-a2b4-061b2a219ebc") },
                    { new Guid("9f0f2d64-a232-4e2a-a022-21cc1cb8af87"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("78490cb5-c671-4b7f-aa28-9ef98031508f"), new Guid("3dc1a6db-3bf2-4650-b501-abf7ef284b3c") },
                    { new Guid("a2027ac9-0e8c-4e4f-8b69-a210622b7020"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("43c468cb-939e-4eea-8f91-89f88f0f5f70"), new Guid("96389a1d-3bc8-465b-ba35-3027877a9981") },
                    { new Guid("a6c80519-e67f-43ee-a1b1-953abce7047b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("cb121444-a460-43f8-bcec-b40fe4edecbe"), new Guid("d8361619-ae4f-4db1-9eb9-291e4814a381") },
                    { new Guid("a86a03a4-4597-4480-a7dd-91305fd44b23"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e8b57133-a00f-496f-aa8d-b6cf54054b4d"), new Guid("9e4f824d-b29a-4ec5-b3a1-111d46f41ecb") },
                    { new Guid("a9604a55-2221-40aa-ab93-85d38ad7d38a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6705c050-744d-4029-9866-d8741c9b932b"), new Guid("d9295c19-5c11-40bb-ba7c-c1b368114ac0") },
                    { new Guid("b34f9ffe-401b-4ffc-9680-b32871c1f10e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("263d1d6c-644b-42a2-95b1-c13cf3a75639"), new Guid("6172d849-4ee5-486f-8f97-d2bbcfc40084") },
                    { new Guid("b53bb346-30a1-490e-b34c-d9e4a6f19706"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a20fd51f-0c41-4bcf-9c1c-3f81f87b71bb"), new Guid("7b354f95-20a6-4d69-abe1-b5a212feb069") }
                });

            migrationBuilder.InsertData(
                table: "UserPromoCodes",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PromoCodeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("b9d89dc5-087a-4cec-a63c-b99297d583f4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("27bd262c-5a96-48a3-8a5c-298cc9adb2de"), new Guid("34d672c5-050e-4c3c-8018-0107a72f13f5") },
                    { new Guid("bb930e2a-6c45-4a23-9128-0286688cc110"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6c4f7293-abea-44b8-8665-f9189d2685af"), new Guid("d666c5aa-5c03-4391-8629-5cc681422ca2") },
                    { new Guid("c57152a1-8f1c-492f-9d06-c49ea48d6588"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5dfc92fe-0232-4751-ae36-8e240bf9e247"), new Guid("dfa0bf0e-13dc-416f-bb54-aaeb47a68545") },
                    { new Guid("c93fe822-178b-4bbb-af62-1cb1e7a442c2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ca18a626-35d4-4bbd-b354-94835f4ae61b"), new Guid("e6b167e1-2f8a-4aa9-b766-dcb40c4c65b7") },
                    { new Guid("cfeeb4e1-7c0b-4d51-be4d-1bef3ca4eb51"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e2ac638c-071c-4e3d-a6e0-32d1a1c4a840"), new Guid("cefdf373-98f4-432b-bfc7-baaf121c554a") },
                    { new Guid("d37fbe83-7bde-4c24-9d7a-7bd48a9dfdc0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e916c69c-d36e-4281-aedf-3c9dec80afb2"), new Guid("7f910a03-763a-4cdb-bbcb-8241bae6fc96") },
                    { new Guid("d87bb9b5-2a93-4891-99e3-beeaf23e1345"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("df00a113-5b89-4450-8c21-799f77a8e366"), new Guid("dc04df94-1448-4899-bec4-692b13ea2748") },
                    { new Guid("d8972927-ceac-4ab6-b0fb-3a91986e9b9f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9efe632d-8299-419d-a992-76309ff8fbce"), new Guid("34d672c5-050e-4c3c-8018-0107a72f13f5") },
                    { new Guid("d89a10c8-17e7-4d8d-ab7a-e500bccea35b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9c7052a3-3002-4c27-b741-7f8e47f990f8"), new Guid("1546f9ad-e76e-4438-9513-2c0cdbcdc9dc") },
                    { new Guid("da9e4ac6-2ae4-4beb-a30b-c58fdb6d93a7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("20830bd9-0967-4ef8-a2e2-ec75b89e2c37"), new Guid("c311c4ad-bbcf-418b-8259-eec5ae72eb71") },
                    { new Guid("de151c61-6cc3-4274-b031-6302a6cd4099"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a1964fbd-5b30-4b68-b77b-17a7da990984"), new Guid("57d5c043-44a4-43bb-80ee-1cbb791b2285") },
                    { new Guid("de4a09ea-9802-4a51-95f6-e62deeb54531"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3edb767f-1a32-46ff-92ee-74df21b1452a"), new Guid("6709762d-580f-4c32-8f92-b1daa6e22c27") },
                    { new Guid("e1357c9c-3871-46ca-b4ce-8bd5bae057f2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f34de1f1-9d7b-4616-a3c2-ae2fefa33a84"), new Guid("ef14d144-d1c3-49fb-9e25-1889be79f4e3") },
                    { new Guid("e58437d2-2c25-4a26-9639-45b12ccc18d4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("45691c9a-22db-432b-91ec-21a8374d2a07"), new Guid("b71f69da-e20d-4b25-b2fb-00d5eb1c9002") },
                    { new Guid("ed6fa836-f06d-4902-9bbb-7232187b8f2d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3eef3abf-4f7d-4f2e-bc3a-78f0dbb4a8d4"), new Guid("7805e438-4982-4f20-9e68-baca0c631417") },
                    { new Guid("f0812021-687a-4cfa-befd-a47720ccae2b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("483fffca-41a2-4630-8923-fd7fb0c257a2"), new Guid("a01a13e5-a8d1-4048-b8b2-24cdfac5f11e") },
                    { new Guid("f23ce03f-55c2-478a-8f71-523ae3a1147d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6298ec36-c8ef-426b-ae09-48bf38a2c68a"), new Guid("3705daaf-a245-497f-b245-acd05a008711") },
                    { new Guid("f42e3e5e-cd94-4b41-a003-df395add0db2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2575d51c-c3eb-4f88-a698-1c1b9b2ddf5a"), new Guid("749d009d-0557-4289-976a-50a7e345a281") },
                    { new Guid("f549b54d-286b-4a3b-92ae-4d820b94ee5e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e59ad964-f4b5-408b-b749-81fa8e318c19"), new Guid("a01a13e5-a8d1-4048-b8b2-24cdfac5f11e") },
                    { new Guid("f57320c3-f5af-4e9e-babe-e509fd746cdd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("cb121444-a460-43f8-bcec-b40fe4edecbe"), new Guid("e2dba597-b132-4b1a-a46f-540ebc581408") },
                    { new Guid("f6dd97dd-7107-4048-a643-c707f7d34600"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9f296ef8-a913-4d56-bf6f-fd3661d87d36"), new Guid("4bfa50d6-7b76-402d-afe8-4b558ee6165b") },
                    { new Guid("fcb7f7b8-548e-4826-9e5f-7cf4da700b7a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("67f3058f-7f71-4bf8-af75-5dad8f4ec261"), new Guid("73aad8c3-cbed-4125-b80b-7db0735c3ac6") }
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
                name: "IX_AspNetUsers_Login",
                table: "AspNetUsers",
                column: "Login",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_EmailAddress",
                table: "Emails",
                column: "EmailAddress",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Emails_UserId",
                table: "Emails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Parcels_RecipientId",
                table: "Parcels",
                column: "RecipientId");

            migrationBuilder.CreateIndex(
                name: "IX_Parcels_SenderId",
                table: "Parcels",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentCards_UserId",
                table: "PaymentCards",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbers_Number",
                table: "PhoneNumbers",
                column: "Number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbers_UserId",
                table: "PhoneNumbers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PromoCodes_Code",
                table: "PromoCodes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserParcelMachines_ParcelMachineId",
                table: "UserParcelMachines",
                column: "ParcelMachineId");

            migrationBuilder.CreateIndex(
                name: "IX_UserParcelMachines_UserId",
                table: "UserParcelMachines",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserParcels_ParcelId",
                table: "UserParcels",
                column: "ParcelId");

            migrationBuilder.CreateIndex(
                name: "IX_UserParcels_UserId",
                table: "UserParcels",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPostBranches_PostBranchId",
                table: "UserPostBranches",
                column: "PostBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPostBranches_UserId",
                table: "UserPostBranches",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPromoCodes_PromoCodeId",
                table: "UserPromoCodes",
                column: "PromoCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPromoCodes_UserId",
                table: "UserPromoCodes",
                column: "UserId");
        }

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
                name: "Emails");

            migrationBuilder.DropTable(
                name: "PaymentCards");

            migrationBuilder.DropTable(
                name: "PhoneNumbers");

            migrationBuilder.DropTable(
                name: "UserParcelMachines");

            migrationBuilder.DropTable(
                name: "UserParcels");

            migrationBuilder.DropTable(
                name: "UserPostBranches");

            migrationBuilder.DropTable(
                name: "UserPromoCodes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "ParcelMachines");

            migrationBuilder.DropTable(
                name: "Parcels");

            migrationBuilder.DropTable(
                name: "PostBranches");

            migrationBuilder.DropTable(
                name: "PromoCodes");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
