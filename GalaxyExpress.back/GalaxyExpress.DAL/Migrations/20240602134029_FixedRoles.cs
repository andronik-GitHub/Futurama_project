using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalaxyExpress.DAL.Migrations
{
    public partial class FixedRoles : Migration
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
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), "c194897c-42d6-4e1a-8bb1-b80095860635", "Manager", "MANAGER" },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), "2bdf18bc-1aae-4eee-a4c1-2139c2fb0bee", "User", "USER" },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), "16e9f0f5-a9b4-4681-8c57-909ac42bac83", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "Email", "EmailConfirmed", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("01424fda-76cf-4203-995c-a75e43c1d1d0"), 0, new DateTime(2004, 10, 6, 11, 34, 24, 732, DateTimeKind.Local).AddTicks(7205), 61.4412928606560000m, "dfdbd764-7eec-4073-842f-7da380055a4a", null, null, null, false, null, "Joann", "Thiel", false, null, "Joann_Thiel12", null, null, "AQAAAAEAACcQAAAAEHBo6Wc0SlmQNrjhG5n6uERP8WCXNN477+Qoj9g78MEMF/om6YbGgquxjyK0zp2rpg==", null, false, null, null, 1, false, null },
                    { new Guid("02a17a84-0a35-4164-b872-e030d586b6fe"), 0, new DateTime(1969, 4, 14, 21, 37, 41, 459, DateTimeKind.Local).AddTicks(2550), 646.8429188184220000m, "7830b034-3bb4-41ab-a10c-4fca4c1bc5bf", null, null, null, false, "Frances", "Frances", "Armstrong", false, null, "Frances22", null, null, "AQAAAAEAACcQAAAAEO1oSIVPPf882MTTfyS9OltIpSokP1olhbBuqM9NrDZMYHzKM0v5m73YjEkTM/fimw==", null, false, null, null, 1, false, null },
                    { new Guid("0447d1d8-3e48-4d64-8d2e-7d9a733628ec"), 0, null, 348.6631487092290000m, "19f01ca2-a4aa-4f94-beda-15c9398c5892", null, null, null, false, "Laura", "Laura", "Parker", false, null, "Laura_Parker", null, null, "AQAAAAEAACcQAAAAEMhsrowPaK2yfbwUOYuj2FMk/TSODbzOBuETTDtqgiH15qa+IKSOpJXd4YoYktj7OQ==", null, false, null, null, 2, false, null },
                    { new Guid("0635daf3-649c-437b-92ef-713d43246a0a"), 0, null, 840.5318366586260000m, "33570a35-4103-4d18-8c03-05b3349f8464", null, null, null, false, null, "Ernest", "Pagac", false, null, "Ernest74", null, null, "AQAAAAEAACcQAAAAEKV7PHSdESbtL/g9e/o3syYV+ilMDrLWEvouLhPci0xzSWP66i5uZnlEK55kVVJIBw==", null, false, null, null, 1, false, null },
                    { new Guid("06f4c32b-9a3d-4b38-99a4-56ea0ba685a8"), 0, new DateTime(1949, 9, 4, 14, 54, 50, 714, DateTimeKind.Local).AddTicks(6554), 887.0041790996350000m, "6c69f3b7-deda-484f-848c-61ad286b18d0", null, null, null, false, null, "Johnnie", "Upton", false, null, "Johnnie.Upton", null, null, "AQAAAAEAACcQAAAAEP8kxVCiaEVRF/qNyIOFIVmN924249BppnetqKMlyS5q84IU/KE+398J4c88446NOQ==", null, false, null, null, 0, false, null },
                    { new Guid("0773e360-956e-4d39-94c5-d0906a9e4557"), 0, new DateTime(1982, 8, 23, 15, 15, 17, 301, DateTimeKind.Local).AddTicks(199), 621.8128750076880000m, "c70e492e-ba74-4344-a179-6252cb73bb41", null, null, null, false, "Gina", "Gina", "Reilly", false, null, "Gina_Reilly17", null, null, "AQAAAAEAACcQAAAAEFdR3wU1ZLhY74IUGEEZdMNIwB9m91+u/qu8qJZ6gjp1+uh6Avob2RdWGh3NEod0EQ==", null, false, null, null, 2, false, null },
                    { new Guid("0776f148-3954-48ff-8bb8-772d353c1a3c"), 0, null, 665.3568235738310000m, "09835c6e-63e2-414b-9e8f-e3f072bc3a40", null, null, null, false, null, "Vera", "Rath", false, null, "Vera51", null, null, "AQAAAAEAACcQAAAAEGynGrwzp+f7kjbnvgB3hFj+9KheehX2D2RS4rOG7ORUx/I2oRZRwR6rs6iT+ceQRA==", null, false, null, null, 2, false, null },
                    { new Guid("07e77ffa-7983-4cb3-bfa5-a4b8ed39f91f"), 0, new DateTime(1975, 8, 6, 12, 56, 34, 805, DateTimeKind.Local).AddTicks(4139), 649.519442349560000m, "849360bd-9a4e-449a-986c-8621910b3a43", null, null, null, false, null, "Esther", "Walsh", false, null, "Esther_Walsh", null, null, "AQAAAAEAACcQAAAAEPwdF0AOfrQCbtDgXgb06hV0cc0pqYn8e5yLksylDiGdAFCLZ2L5SGF2XdOgcdVXYA==", null, false, null, null, 2, false, null },
                    { new Guid("080ced29-2e70-40de-82e4-0a2d478fe53e"), 0, new DateTime(1955, 11, 14, 5, 58, 57, 744, DateTimeKind.Local).AddTicks(9978), 115.0431841973410000m, "520b79f5-bbef-4ac2-aa39-bb80c79bf1da", null, null, null, false, "Fannie", "Fannie", "Schmidt", false, null, "Fannie_Schmidt90", null, null, "AQAAAAEAACcQAAAAEBdOlgY9f4UweOO4w9UlV1uoqs4uGeGigcFK1tbYw1L7mfSv057RL46Pzxt701Iu9Q==", null, false, null, null, 1, false, null },
                    { new Guid("08589d86-24cf-48ee-b140-eab54649e215"), 0, null, 534.4050444227790000m, "b7282bf0-62f1-4d12-af1e-b39e0fdf25f2", null, null, null, false, null, "Lora", "Murazik", false, null, "Lora.Murazik78", null, null, "AQAAAAEAACcQAAAAEG27jUxTO45k621M1A8ckeH+usLmhp6GbayzL9f8HnTxsFevWsXNAB20QNAXfmgGNA==", null, false, null, null, 0, false, null },
                    { new Guid("0877dbd6-c025-49ef-b189-53b217500382"), 0, null, 460.5289638230230000m, "979362e8-d868-4a0d-91e4-4ee18d3db396", null, null, null, false, null, "Max", "Wolf", false, null, "Max7", null, null, "AQAAAAEAACcQAAAAEH87qTg186zQ+LnEMnrAH1QSLEiP7RpraXc2iqP5YzrqL7vu4kzGO5TMOPJ/ydDryQ==", null, false, null, null, 0, false, null },
                    { new Guid("087fb413-124f-47b1-b54e-4bdedf2edf63"), 0, new DateTime(1962, 3, 29, 12, 25, 58, 797, DateTimeKind.Local).AddTicks(1014), 484.7100901812850000m, "e036f5c9-59d6-478d-b3aa-b6047aa7b9f9", null, null, null, false, "Paulette", "Paulette", "Schumm", false, null, "Paulette.Schumm63", null, null, "AQAAAAEAACcQAAAAEMc6BpAwYSvmkkrgdLPC2TzW7QNDqrg30SZDtzPGBo4vfXsDMUk7QZ8pe93JjeJqQA==", null, false, null, null, 1, false, null },
                    { new Guid("097cb7d3-d333-48aa-b8ee-cacd11ee91fa"), 0, new DateTime(1947, 10, 30, 18, 41, 26, 282, DateTimeKind.Local).AddTicks(7308), 979.5838763101770000m, "a3532fea-772e-468c-845e-e61f6346bc2f", null, null, null, false, "Bernard", "Bernard", "Dietrich", false, null, "Bernard.Dietrich99", null, null, "AQAAAAEAACcQAAAAEKnAnwqveNTBLgDEpdhc0Ic/xjNU9/waN64pLxWa2n+MYzLgB0eVpT0QkEKc8+y+Kw==", null, false, null, null, 1, false, null },
                    { new Guid("0a1370d0-5d3b-4609-9efc-9507f4acc2f8"), 0, null, 388.7112529304660000m, "cc9d85b8-9da0-4ff8-b9c4-55439fca108c", null, null, null, false, null, "Janie", "Cummerata", false, null, "Janie23", null, null, "AQAAAAEAACcQAAAAECFn09/az60HmFANapx6FVX7rrT4aPfC0R8u3FyVnQ+XX0sdqn8S++vDXw32isN8LQ==", null, false, null, null, 1, false, null },
                    { new Guid("0a8fb680-a380-4d35-85da-ff3cf9faa245"), 0, new DateTime(1962, 10, 19, 22, 57, 13, 844, DateTimeKind.Local).AddTicks(329), 894.7255354937680000m, "c54a1616-2e4b-40ad-99d7-94d266703a7d", null, null, null, false, "Luz", "Luz", "Mayert", false, null, "Luz.Mayert94", null, null, "AQAAAAEAACcQAAAAEKiUcsJjWyKT/HZKLhS7JpiUJphqOK5TCfV+J3NryYJTo//r4nG3fgraO2RvFDb7/Q==", null, false, null, null, 2, false, null },
                    { new Guid("0b65bf95-8c8c-4e28-8317-122f0f66a78e"), 0, null, 581.9748986924360000m, "31a6967c-18f7-483e-9b0c-f9c38d78c5b9", null, null, null, false, "Lillian", "Lillian", "Roberts", false, null, "Lillian.Roberts90", null, null, "AQAAAAEAACcQAAAAEL/3Rtw/s6UVtbwBmEtXohw6jszuydB5aw4PuXLwu00sq2736dCtwmP8ZUhIBwOqEQ==", null, false, null, null, 1, false, null },
                    { new Guid("0bf479c3-ab54-4392-b19e-a71b3942b7fe"), 0, new DateTime(1986, 12, 31, 23, 5, 24, 864, DateTimeKind.Local).AddTicks(5), 770.7548315310520000m, "2cabb745-845a-453f-b4a2-dfebbedd1c10", null, null, null, false, "Lucas", "Lucas", "Brakus", false, null, "Lucas.Brakus75", null, null, "AQAAAAEAACcQAAAAEFAmTP+Rxzv121U9D7Yz7tgMINX8ZeHJasAWFFavIPeI68sKwvWktiwpTUWc8BN1Ng==", null, false, null, null, 0, false, null },
                    { new Guid("0c66002d-25be-4864-84e7-acd6fd765b27"), 0, null, 269.3295238762490000m, "2406451d-deb3-4cf2-9d09-e233d37f9168", null, null, null, false, "Genevieve", "Genevieve", "Toy", false, null, "Genevieve4", null, null, "AQAAAAEAACcQAAAAEH2pYuHycyPCDCg7L/ouzHVolBfPtTbbhGXN8iyrkxXbsfhVCQHIbEzSb1M4MeY6Sw==", null, false, null, null, 0, false, null },
                    { new Guid("0d230077-5e9b-42d8-a83a-650a22378849"), 0, null, 291.8781652190810000m, "8f09e089-44e4-445d-a986-51743429fc90", null, null, null, false, null, "Joshua", "Gutmann", false, null, "Joshua.Gutmann", null, null, "AQAAAAEAACcQAAAAENoJSn9Rh9kBdEn1/txzvW+INaPbBH/zzfXyRIMyCCJoW2Zw5f3EaKUUoJPaasecig==", null, false, null, null, 2, false, null },
                    { new Guid("0d6ec0b6-076d-4fc4-8519-424b1c8bf28e"), 0, null, 664.0550232178570000m, "3f9eda86-c3df-4c96-9d65-6add13dc23a1", null, null, null, false, "Mamie", "Mamie", "Fisher", false, null, "Mamie63", null, null, "AQAAAAEAACcQAAAAEOvWd0szq0xLXmW47aH3jLZvSw6/gdW+vozMUSpzHI1j8H26MN3Xv32NZtGqU/5oeg==", null, false, null, null, 1, false, null },
                    { new Guid("0d88a4e0-8366-4547-8ebe-087d4c74b34f"), 0, null, 215.8578185846160000m, "cea031f6-ee6e-465b-9a6e-e9626d309750", null, null, null, false, "Darrin", "Darrin", "Wiegand", false, null, "Darrin_Wiegand31", null, null, "AQAAAAEAACcQAAAAEETwAjqfBwdpV2hG4olm8FTpT1PIE43bvqZ91dMLLXTKWnaqUOzTBNWsT7QxoNi0sA==", null, false, null, null, 2, false, null },
                    { new Guid("0e6930e6-cf0a-4195-8d74-a9cc0dfb30b6"), 0, null, 16.67516156421810000m, "cce30ac6-6172-4a38-8d4c-5e88d6935cee", null, null, null, false, null, "Maggie", "Windler", false, null, "Maggie.Windler34", null, null, "AQAAAAEAACcQAAAAEDlrAw98Oq99hr8D8iYtJTdU5zOEJZ4GZijgFUHwQ4XQZ2Q48a5QAszLp2Re9QRC8g==", null, false, null, null, 0, false, null },
                    { new Guid("0e7742f2-e964-4e8c-b692-4ffb75ece318"), 0, null, 16.04931776417640000m, "021006bc-723e-4dcc-9bbf-a81925614414", null, null, null, false, "Stewart", "Stewart", "O'Connell", false, null, "Stewart_OConnell", null, null, "AQAAAAEAACcQAAAAEO3ggCQ0SHLiHU8d0ySww38g02qC69GLcYXTPfvc3dK++8g/8aMOAYTQNP3Lt7q6pA==", null, false, null, null, 1, false, null },
                    { new Guid("0ec010bc-7e48-4cb9-bb93-8dd9d5b37f6d"), 0, new DateTime(1937, 2, 2, 15, 28, 11, 894, DateTimeKind.Local).AddTicks(7943), 556.8874530273370000m, "b4a8d853-4763-41ae-8d70-0f26abe64ab8", null, null, null, false, null, "Grace", "Kutch", false, null, "Grace0", null, null, "AQAAAAEAACcQAAAAEPr97VYh48AUZ7GrFsA218B6eYy0cBn+EXmKiUTJJXSJF3mxkk+rxjVWKqbpB1fWrg==", null, false, null, null, 0, false, null },
                    { new Guid("10766e70-305e-4e2a-8560-ffeb596a93eb"), 0, null, 650.6199722109350000m, "1c565743-a2e9-4d73-818e-d45f908c06e7", null, null, null, false, "Edith", "Edith", "Bernhard", false, null, "Edith_Bernhard", null, null, "AQAAAAEAACcQAAAAEBMGpPGbuEelu8AdMQ1m2i6pE5pnzJTAns/yZWzbdQaHKOUxEs1oZ3DAGg7A+NTp1A==", null, false, null, null, 1, false, null },
                    { new Guid("108fbff3-4041-4eed-b2a0-4a4b1fb47787"), 0, new DateTime(1939, 11, 7, 1, 27, 54, 959, DateTimeKind.Local).AddTicks(4800), 180.2927505344020000m, "d782ad29-1582-4480-8b79-94b42b6a1864", null, null, null, false, "Eddie", "Eddie", "Predovic", false, null, "Eddie.Predovic", null, null, "AQAAAAEAACcQAAAAEOXxZtnWFMFImeu3vTzAmzGBDvhNSONSkdes5ia+dlvA9D3wTb7EPgq5lTQ+/0StUg==", null, false, null, null, 1, false, null },
                    { new Guid("1154bb55-7f7f-4d91-8347-5797ffeacb13"), 0, new DateTime(1982, 9, 29, 9, 6, 17, 864, DateTimeKind.Local).AddTicks(6673), 460.6955269873320000m, "d595a718-7842-4e97-a9f1-a55ddddcb414", null, null, null, false, "Mamie", "Mamie", "Zboncak", false, null, "Mamie49", null, null, "AQAAAAEAACcQAAAAEGnuhBtDljQ6/vy/Z6mSuxuhTQo1+IEuKxmwumTJj88wmvx6iXc44OipkU93PyJvyA==", null, false, null, null, 2, false, null },
                    { new Guid("1381d1cd-5c11-46c1-bc37-987b3f5ae33e"), 0, null, 988.3226856812840000m, "12abaae3-a0f8-4b9d-a186-d33f9c2ea6d6", null, null, null, false, "Leonard", "Leonard", "Abernathy", false, null, "Leonard.Abernathy", null, null, "AQAAAAEAACcQAAAAEGugY4pcOriPCIDhs3lEtKv2Fn/xtm0iEy96vjpfvbzKNus8kPZqS6avtjHxNjZ6ZQ==", null, false, null, null, 2, false, null },
                    { new Guid("141e6ca1-3b19-4ffc-a21f-8420c3f6db52"), 0, null, 565.2091210349380000m, "a35d6723-6c1a-4aad-836a-e905184d11ad", null, null, null, false, null, "Dana", "Moen", false, null, "Dana86", null, null, "AQAAAAEAACcQAAAAEKUa99YLJofnUvG58SNiqLcRuaV9OxoQHOOhMyKDLxrSSxxBQbd6+uj3FJFuxRnepA==", null, false, null, null, 1, false, null },
                    { new Guid("182bd5c0-616f-4e9b-8837-7c2b67e01496"), 0, null, 851.2178760403040000m, "1828cc5f-c8b2-4202-adc0-5a31cda65cd6", null, null, null, false, "Lorena", "Lorena", "Kautzer", false, null, "Lorena.Kautzer80", null, null, "AQAAAAEAACcQAAAAEJAb28X37YOKkhhQTIxCV0+vkzF1Rh4lRZFUg2y5Vm6yKn3Q8Rros4+HoWtX5HfXPQ==", null, false, null, null, 0, false, null },
                    { new Guid("1937fdf7-97b0-4102-95c9-2163eb910112"), 0, new DateTime(1952, 9, 9, 23, 57, 0, 270, DateTimeKind.Local).AddTicks(675), 827.7821671990860000m, "751828c8-3a4c-48e1-949c-5359e7cc758b", null, null, null, false, null, "Gerald", "Olson", false, null, "Gerald42", null, null, "AQAAAAEAACcQAAAAEKXEa+nxNSvabcUd3w9OHFuOimxbv2/AHRzWrBpFYCgEQzzUktNJgTe286hs2mYV2g==", null, false, null, null, 1, false, null },
                    { new Guid("1a21f215-231c-4e09-b7c2-4e3163978286"), 0, null, 493.0453593218440000m, "4e9157e5-1053-43c1-8b64-d46067089448", null, null, null, false, null, "Jon", "Grimes", false, null, "Jon17", null, null, "AQAAAAEAACcQAAAAEPwjggGIzRQbFidfLKg1oL4vxARj7KJQsFcOGw5cQhGyRJUIMtTkwJ/2SJYHUAXp7A==", null, false, null, null, 0, false, null },
                    { new Guid("1b1ebe07-5765-4728-8b40-ee14061347ae"), 0, new DateTime(1945, 8, 1, 5, 9, 18, 744, DateTimeKind.Local).AddTicks(6808), 428.8632420422670000m, "14c1a8ac-d3d0-42d3-8873-4efb9368280e", null, null, null, false, null, "Karla", "Rogahn", false, null, "Karla1", null, null, "AQAAAAEAACcQAAAAEKmwsxMyqJJMd+3gwfgt3uIvZdk+Ewvk+mL0KUyrFsuKzMxvz9CYbi5G4UDzQh0udQ==", null, false, null, null, 2, false, null },
                    { new Guid("1bab23ea-659b-4531-ad24-fdfd8984675d"), 0, null, 129.4859297039090000m, "f94faf2a-2022-4ad9-a20b-70d01c05538a", null, null, null, false, null, "Deanna", "Wiegand", false, null, "Deanna72", null, null, "AQAAAAEAACcQAAAAEHqtkCwxLcUr15Kq3DXfIThcHeQEDE5eBxKKI/mw4x8npXBh9zWMdr+tDmWkqap4QA==", null, false, null, null, 2, false, null },
                    { new Guid("1cdde210-cf9c-4b69-a64c-3995a2267739"), 0, null, 719.2916222511370000m, "c0409e33-c5fe-43ff-a57b-283ef38ee02b", null, null, null, false, "Jo", "Jo", "Jerde", false, null, "Jo18", null, null, "AQAAAAEAACcQAAAAEGTldveR5b2KgYT4od1PcVxwPWHZvU/cl/OLz6sglalpWYGpdYJJFxAZjXrwjuE7Ug==", null, false, null, null, 0, false, null },
                    { new Guid("1e17494c-b19d-4879-af0e-c6575db6bd37"), 0, new DateTime(1935, 9, 17, 13, 38, 43, 560, DateTimeKind.Local).AddTicks(1258), 872.4844729771990000m, "be5cca66-d006-41ac-bf29-d128764913c5", null, null, null, false, null, "Keith", "Littel", false, null, "Keith_Littel", null, null, "AQAAAAEAACcQAAAAELOxMRZvGcD5C6U8PCc2uZTt71qlFYN6QfeHTIOoUTHX5el7KuZ8hfXxZNNiDIfqSg==", null, false, null, null, 0, false, null },
                    { new Guid("21d9b3f2-945c-40a1-a0ca-7b6fcbe38a4e"), 0, new DateTime(1949, 4, 8, 7, 23, 51, 62, DateTimeKind.Local).AddTicks(5300), 949.0260892689670000m, "9595569c-543b-492c-bf6f-d1da7dab54ed", null, null, null, false, "Jon", "Jon", "Torphy", false, null, "Jon15", null, null, "AQAAAAEAACcQAAAAEMr+uy6eTevvrG5Vcnrb6VVtZW5Qx/VWJioboxdA1qvlXHIT9m9kMojR/kJSLJ722g==", null, false, null, null, 1, false, null },
                    { new Guid("22edc826-6747-4099-aca5-578199353ac6"), 0, null, 331.4927202366450000m, "8f3f2830-7cb3-4b00-a959-5ad96f828147", null, null, null, false, "Cory", "Cory", "Hettinger", false, null, "Cory.Hettinger", null, null, "AQAAAAEAACcQAAAAEOBmQiVV8S+Kf7PcxrlohFvGn0DKJORVyWVCmiUEAv7Z2/yirPUcCACDvnFsJSJzIA==", null, false, null, null, 2, false, null },
                    { new Guid("230e73b5-4a4b-4b1c-ad48-f7a0074303c7"), 0, null, 716.7262606983220000m, "a1761be4-49f6-4925-8563-4aaebe49cda1", null, null, null, false, null, "Kathryn", "Maggio", false, null, "Kathryn71", null, null, "AQAAAAEAACcQAAAAEIPRIOpJcH0uX93VV6tNu2zuHim8LwMScSBgkqk8fRG8JeaJdg68ga9T+Uctsu0Ryw==", null, false, null, null, 2, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "Email", "EmailConfirmed", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("23e8131d-ba45-4488-991d-941eca3fbe0a"), 0, null, 809.7909940169980000m, "6cce74c4-4b2b-4730-b08c-e8b3d2d1d7cb", null, null, null, false, null, "May", "Trantow", false, null, "May25", null, null, "AQAAAAEAACcQAAAAEHyC5GtmGqN+2RWo9jB5RQRqrDmGSaVSIk33cIQsWyoOfFacL4BTVW9GgayzERz+Gw==", null, false, null, null, 1, false, null },
                    { new Guid("2411a1da-d71e-4e02-a40e-984ec689c7bd"), 0, new DateTime(1998, 8, 4, 11, 47, 52, 249, DateTimeKind.Local).AddTicks(6304), 565.7475553601790000m, "0538979a-59dc-4bc6-8dc5-62fe7dad9305", null, null, null, false, "Orlando", "Orlando", "Denesik", false, null, "Orlando_Denesik", null, null, "AQAAAAEAACcQAAAAEE9r+ZKLVpSCSB+o0deQv44FakLeJ3a5xazd4yWna7fXXmGu/Ody7rMQ8x9J/c0RDQ==", null, false, null, null, 0, false, null },
                    { new Guid("2476b4fb-aceb-40f6-b636-80dd269d535c"), 0, null, 515.4723102467910000m, "7a3f81d5-fbda-44ad-9659-1656a138e466", null, null, null, false, null, "Charlie", "Legros", false, null, "Charlie_Legros55", null, null, "AQAAAAEAACcQAAAAENF2XOdiLfReWjSYW17sIC/uFYIkHKrvNGwZ0x7ep3JVocCxUXOJ+2lMjlLSsJgAWg==", null, false, null, null, 1, false, null },
                    { new Guid("25c234e8-8d95-42b3-9dc3-c418fbcaa7da"), 0, null, 917.5994906598280000m, "d9d2245b-02dd-4371-9182-a4ab600861c3", null, null, null, false, null, "Leonard", "Willms", false, null, "Leonard.Willms", null, null, "AQAAAAEAACcQAAAAEJX5baTFb8A6FFXJwuP1ycyXPNzFBfugi9On/rymCFp7mHBlUjtAq993AJMEDjEZLw==", null, false, null, null, 2, false, null },
                    { new Guid("2700d101-47ef-4c75-a3e1-b613514a94f0"), 0, null, 53.1083909637960000m, "905f3c1a-9653-457d-90e5-adaa76ad0e14", null, null, null, false, "Melanie", "Melanie", "Kemmer", false, null, "Melanie.Kemmer20", null, null, "AQAAAAEAACcQAAAAELgMoDLroADKtnVwhWczuDb+1owFjek2K5kmn+L9iBjguFzfUAPJn180RUw+Lph+zA==", null, false, null, null, 0, false, null },
                    { new Guid("2b5f8a6c-d3e8-41ff-8867-cadb6cd16ea4"), 0, null, 194.4971079793490000m, "b59a587a-5e79-484a-a89c-787e43e2da0b", null, null, null, false, "Ann", "Ann", "Dickinson", false, null, "Ann2", null, null, "AQAAAAEAACcQAAAAEEiKUz04roDD4SqS0NyELhgNgX0C/KCeSMLsMSk6wJUDGAXsS7VpzIR8VYs5OWfHfA==", null, false, null, null, 0, false, null },
                    { new Guid("2bdbd536-e4dc-4869-9dac-f62a098ecb05"), 0, new DateTime(1962, 9, 3, 3, 30, 15, 564, DateTimeKind.Local).AddTicks(6427), 583.971412373360000m, "e9eaee91-9243-4934-a041-d2508d7c4e69", null, null, null, false, null, "Geoffrey", "Gibson", false, null, "Geoffrey.Gibson32", null, null, "AQAAAAEAACcQAAAAEB2My2HeZZWeR22DymiYyVEb47YxAUWv3TP+ei1XmBk64FJqq5bn407DfFqAcTtl9g==", null, false, null, null, 0, false, null },
                    { new Guid("2c87eaa4-8e07-41f4-bad0-935d07541e78"), 0, new DateTime(1956, 9, 9, 12, 48, 2, 112, DateTimeKind.Local).AddTicks(5991), 404.53772715940000m, "d52fc5ed-a908-410c-81da-e51b31382f71", null, null, null, false, "Ricardo", "Ricardo", "Bradtke", false, null, "Ricardo.Bradtke11", null, null, "AQAAAAEAACcQAAAAEGtCxZzaEd0uvYXziMip6ZzedMJn/VR0nAul+gO4JyIfOoWGP55eMUucwrLsjf0m2Q==", null, false, null, null, 1, false, null },
                    { new Guid("2e3a99a4-4308-410d-b67e-4763bbd6b9c8"), 0, null, 125.6737467502050000m, "2eb92be0-3597-4fb9-8aef-65cb3ec00b9e", null, null, null, false, null, "Brett", "Gutkowski", false, null, "Brett98", null, null, "AQAAAAEAACcQAAAAEEt1aWqj+sOPJQzPrKH2Dll4wRya/ZqeQKDksnCGvjaV93sFpSLAHIUoN1Pfj/LUhg==", null, false, null, null, 0, false, null },
                    { new Guid("2f8c0b43-80b3-437b-8a84-a763ed30230e"), 0, null, 953.5479637398480000m, "7acc6601-9b30-4047-b927-271632c882b2", null, null, null, false, null, "Ernest", "Hodkiewicz", false, null, "Ernest_Hodkiewicz", null, null, "AQAAAAEAACcQAAAAEHV6iJ4fHZ2hvXysRc/eJTM6H6Zi+Kw5DQ4nGbi8SujrRzS5atw7qTiqs4rj5y6oIg==", null, false, null, null, 2, false, null },
                    { new Guid("323967f9-cf4e-4818-a5bf-94dff7ea728b"), 0, null, 881.7138852993510000m, "e5474dfb-513d-445c-9a4f-d5857c402e07", null, null, null, false, null, "Estelle", "Bosco", false, null, "Estelle94", null, null, "AQAAAAEAACcQAAAAEHeRRvshKfh5JVkSWmulV6t3yFftJm4InfPq/n3OviyH909jddr/Dkgin4Jq/kgCRQ==", null, false, null, null, 2, false, null },
                    { new Guid("32feb777-af06-4813-9108-9d7acfd0bd04"), 0, null, 348.0488127877980000m, "2d31cd23-0b63-4f98-896d-0e56ecf84ec5", null, null, null, false, "Irving", "Irving", "Stoltenberg", false, null, "Irving_Stoltenberg42", null, null, "AQAAAAEAACcQAAAAEPFeNCzaNsUZw33D2YM050DQ9YaD20AdV/lZVa2wConL+p6+pnPqpIkdCWUPRT7H3g==", null, false, null, null, 2, false, null },
                    { new Guid("3314d8f7-2262-4e19-afd4-3e85972480b8"), 0, new DateTime(1973, 5, 10, 0, 36, 7, 574, DateTimeKind.Local).AddTicks(4041), 706.0346568555670000m, "1f9a574c-75dd-4c19-bab0-c165fe93fb01", null, null, null, false, null, "Gerard", "Stanton", false, null, "Gerard90", null, null, "AQAAAAEAACcQAAAAEMg/UaozVLXtTa2sOEofEcHaEmiJEKRXRRj/VN+MMCtUrWjre2WUFtNGA59EJrpqFg==", null, false, null, null, 0, false, null },
                    { new Guid("335c9d28-42e2-4d49-9686-f0cd1b972fae"), 0, new DateTime(1977, 11, 9, 12, 16, 20, 428, DateTimeKind.Local).AddTicks(6221), 779.5334861766430000m, "84925038-fdf1-408d-8eb7-04bbaf22e15b", null, null, null, false, null, "Florence", "Kertzmann", false, null, "Florence.Kertzmann", null, null, "AQAAAAEAACcQAAAAEA6m6aiMrTk7cphVue5CnIQOAUp5IVie5YvkTcyG7/SaT0zrE/5z+oKfWTBgJbIf4A==", null, false, null, null, 1, false, null },
                    { new Guid("34e9aed1-9d94-41dd-a50e-2e11424b25e1"), 0, null, 411.4695645158990000m, "2e1b1367-b38f-4aaf-af7e-f9928d307b38", null, null, null, false, null, "Elaine", "Gleason", false, null, "Elaine_Gleason32", null, null, "AQAAAAEAACcQAAAAENEJZnCfJBIFBhkT5DjEDNygHc5nhpIn1b0C+j4voUWFBEu86SJ4SRAblAbR95IcGg==", null, false, null, null, 0, false, null },
                    { new Guid("35275876-97ec-44a4-8503-f21c815c9a45"), 0, null, 995.3075334825030000m, "27229398-8ff8-4b07-89e9-e2d346126a5e", null, null, null, false, null, "Bobbie", "Harris", false, null, "Bobbie.Harris76", null, null, "AQAAAAEAACcQAAAAEPOZO1d3K95gdG80NRq4GqeidFh0moVHyJuNAQxterIsUPhSpV75OHJwUMHB+8+gnQ==", null, false, null, null, 0, false, null },
                    { new Guid("353c126e-57f5-471a-b13f-0e4fd4cef2fe"), 0, new DateTime(1928, 6, 30, 22, 58, 6, 743, DateTimeKind.Local).AddTicks(9671), 32.79602042026760000m, "eea1ffcb-32ae-453e-8612-5b11fb012093", null, null, null, false, "Jimmy", "Jimmy", "Paucek", false, null, "Jimmy71", null, null, "AQAAAAEAACcQAAAAEEX7MSyqRI/Fd2+HD4Do9OB9lYjdVwGLuxWMRtcxCuH0pncPN6fGHNktKBAHklgkAQ==", null, false, null, null, 2, false, null },
                    { new Guid("3585370e-fea3-4a31-9a6c-93267371cc1d"), 0, null, 926.1362964391940000m, "8d4704b5-137b-4665-b627-f26503df96a3", null, null, null, false, null, "Josefina", "Grady", false, null, "Josefina_Grady10", null, null, "AQAAAAEAACcQAAAAEBvDoK+gXfZV5DgSBQ5Bcd19Ru0SvmB7OB3J2sFSswcS9A2AvXaW3MX5JVsyIUup8g==", null, false, null, null, 2, false, null },
                    { new Guid("36ffb969-580b-40d2-8fa0-94749ea99214"), 0, new DateTime(1976, 1, 29, 7, 27, 37, 439, DateTimeKind.Local).AddTicks(238), 974.8285217492020000m, "1dca4fc6-9f7b-4ce4-b13a-8ba2b4556165", null, null, null, false, null, "Craig", "Kozey", false, null, "Craig.Kozey", null, null, "AQAAAAEAACcQAAAAEAmO3yxV6DSScyrxAv1sptUN5qsWrmrHDgKnfT/V01em4hy6ep0N2k8Up5iAb3zbnA==", null, false, null, null, 2, false, null },
                    { new Guid("3712e35b-2da9-4c76-ad88-28828e776a5c"), 0, new DateTime(1947, 11, 4, 21, 24, 18, 781, DateTimeKind.Local).AddTicks(4060), 188.9976859800260000m, "46996370-9a6d-4e28-8a85-001fa3db916c", null, null, null, false, null, "Nettie", "Lehner", false, null, "Nettie.Lehner40", null, null, "AQAAAAEAACcQAAAAENbe5EbpLCoTERhsVZs/ICBrZeaCDRFUD5UlHgdXkpkTlDbH98mObDIuSlnC1c8dNA==", null, false, null, null, 1, false, null },
                    { new Guid("394e6c37-a398-4cf7-983d-8fb216e6c46f"), 0, new DateTime(1996, 11, 12, 12, 57, 16, 68, DateTimeKind.Local).AddTicks(7499), 709.3317276566810000m, "77975063-0343-4ae6-82f0-6cc3b1ec7a15", null, null, null, false, null, "Maria", "Schumm", false, null, "Maria.Schumm", null, null, "AQAAAAEAACcQAAAAEODSRT0yLLfGYE7ozZi+7jX0mXFX1OJVFIHvwS5Dp523pgCeIjn6L3QPuq0Nk8SrEg==", null, false, null, null, 0, false, null },
                    { new Guid("39d27a82-05d2-4135-b53b-53748eefd4f2"), 0, null, 159.1288555751680000m, "908c511a-f976-4df9-a2c8-a6f0803e7595", null, null, null, false, "Brandi", "Brandi", "Beer", false, null, "Brandi15", null, null, "AQAAAAEAACcQAAAAEFmQjSYWC5WY9Lq7fqC7l5umC/jmZPyAQaJQl3iqY2PribhVju64/SBt3xnTQuytlw==", null, false, null, null, 2, false, null },
                    { new Guid("3a19b458-72b3-4b5b-97e6-334a56d7d557"), 0, new DateTime(1974, 5, 2, 6, 3, 31, 414, DateTimeKind.Local).AddTicks(2045), 973.818708593910000m, "26c26c0e-6f5b-406b-9ab0-e992fc862b0f", null, null, null, false, "Justin", "Justin", "Kunze", false, null, "Justin_Kunze", null, null, "AQAAAAEAACcQAAAAEJJl/gXlMxGbK9bVaKMZY7x5VlWdumhLhXhfwzUr35ZjPSNUZiurqHNoHvgtQl6nLw==", null, false, null, null, 0, false, null },
                    { new Guid("3a262ff7-1654-4c72-9285-3ba10eac6509"), 0, new DateTime(1967, 8, 7, 5, 38, 1, 351, DateTimeKind.Local).AddTicks(5151), 206.313032094330000m, "ac95fa9c-6b54-44d8-b987-57247fdeda5f", null, null, null, false, null, "Marion", "Jacobi", false, null, "Marion46", null, null, "AQAAAAEAACcQAAAAEA3OtJKF6H4pnwc9dfyYpA9OdBbCJOozFeHztTNqAL5fG/swL9vx9lXCWZZj9JG3qw==", null, false, null, null, 0, false, null },
                    { new Guid("3a6fda52-d9f1-418c-8ffa-69974f7f39be"), 0, new DateTime(1945, 9, 7, 13, 48, 54, 662, DateTimeKind.Local).AddTicks(8281), 735.6267224877880000m, "f1d4b49a-7a5e-448d-bb42-173657d6eaa3", null, null, null, false, null, "Marion", "Bartell", false, null, "Marion_Bartell", null, null, "AQAAAAEAACcQAAAAEFdg5NXBbt/WNUker4rFmb9PsMpAmDfEwTv6xVe7f25y5F1oMY1rfP/UjtPpKaFgag==", null, false, null, null, 0, false, null },
                    { new Guid("3b3e9016-3025-48e3-93b2-fa474015c0f7"), 0, null, 0.7692766957135830000m, "a8b71be5-7ddc-4589-812d-c3dd4698df28", null, null, null, false, null, "Doris", "Brakus", false, null, "Doris11", null, null, "AQAAAAEAACcQAAAAEGZ2ndSTj2ijNzHtaVTyeWB1tRwtKAT6cuPTkE2jwNp+YVdEbUB7lXEq0E6ojIjYuQ==", null, false, null, null, 1, false, null },
                    { new Guid("3c3a765d-c1b9-47c7-b39a-7b5dc35e1cbc"), 0, null, 108.1448497301620000m, "bfdda410-3fe3-4c34-94c8-1946de8779cf", null, null, null, false, "Jacqueline", "Jacqueline", "Grimes", false, null, "Jacqueline.Grimes", null, null, "AQAAAAEAACcQAAAAELhrvvgr0MOBMAvictsk0I8IHkmby8GJnAljPB5+ymF3arcoc88etkCF1qdS8mUuVw==", null, false, null, null, 1, false, null },
                    { new Guid("3ee0e809-4d8b-4164-a824-c5ab67903af7"), 0, null, 756.4549775993480000m, "c1f07198-3d13-4697-b53a-2e1a42c9ff14", null, null, null, false, null, "Kathy", "Rutherford", false, null, "Kathy.Rutherford6", null, null, "AQAAAAEAACcQAAAAEMiIQW8o8smwpBcPGnc4ymS+jBtYcTFHGWaLyB/z1kEmop2FirLL5O9y1xGkBgGUDA==", null, false, null, null, 2, false, null },
                    { new Guid("3f1a1c74-7f9a-433e-808b-f0d69f6d97e7"), 0, null, 634.2880297394680000m, "c9215fc8-88fa-4d5b-807a-105921342d04", null, null, null, false, "Stella", "Stella", "Klein", false, null, "Stella19", null, null, "AQAAAAEAACcQAAAAEHj3KM5dNYWT5+RJRNF3j8xxGEV6CDfjUelVBVXM1X5StMEvqXJspFpPJwIej8+2ag==", null, false, null, null, 1, false, null },
                    { new Guid("3ff3d88e-b078-4f3a-8312-8447eeb772e2"), 0, new DateTime(1925, 9, 29, 13, 40, 11, 799, DateTimeKind.Local).AddTicks(9593), 540.4715853397160000m, "c61d8fad-9270-4066-9321-c32d262e19c4", null, null, null, false, "Kay", "Kay", "Ebert", false, null, "Kay_Ebert", null, null, "AQAAAAEAACcQAAAAEJZRXa1NxErUlpZ9ECxQ54BTvmfuVCrx7G/mLrEhgg+VtR9w1qdZR6VteYYauzRw+w==", null, false, null, null, 1, false, null },
                    { new Guid("405a5eb1-aee0-4578-8748-2d8b5a6b0d57"), 0, new DateTime(1975, 2, 17, 5, 42, 13, 863, DateTimeKind.Local).AddTicks(6454), 459.1415263389080000m, "4188c4c2-e3a5-41d7-a60a-0dd14c48f76d", null, null, null, false, "Rodolfo", "Rodolfo", "Buckridge", false, null, "Rodolfo_Buckridge12", null, null, "AQAAAAEAACcQAAAAEAd1QrhOFmW/5uYcFvre7s+b4E6L/1ashRG2OqiNdMXsg2LSWhNTYgv/bMsSRXMp5Q==", null, false, null, null, 0, false, null },
                    { new Guid("4083c32d-a4cd-4c70-b794-fa7b97aafe4e"), 0, new DateTime(1974, 5, 5, 2, 23, 47, 109, DateTimeKind.Local).AddTicks(1512), 471.6944585863620000m, "16daf8cf-fd0e-4f13-8322-6565aeafc1f4", null, null, null, false, "Martha", "Martha", "Kub", false, null, "Martha_Kub", null, null, "AQAAAAEAACcQAAAAEAvV8HAFkM5Rt214ZVeapf2kBPfWhm/J+mgBU4RWrxWXImnSG+mA2PdPMXM5LQ8d1Q==", null, false, null, null, 0, false, null },
                    { new Guid("40a279f6-73dd-4fa2-8b1e-05f9cd8bdcf9"), 0, new DateTime(1968, 8, 28, 18, 53, 13, 347, DateTimeKind.Local).AddTicks(9183), 553.4065747516210000m, "125fa638-f723-4432-bd2f-2fbba00821df", null, null, null, false, "Jo", "Jo", "Feest", false, null, "Jo.Feest", null, null, "AQAAAAEAACcQAAAAEM1tVfxFBrljSnXpNOGelDOyhUCR3orkE+5WhbXb0LcEYt7dtpNPzPkMhYIi/8RqBQ==", null, false, null, null, 0, false, null },
                    { new Guid("4188ab2e-f46b-4cf6-b460-560a914e5d35"), 0, new DateTime(1987, 2, 23, 11, 27, 55, 305, DateTimeKind.Local).AddTicks(9248), 931.1816983611750000m, "2ea4b22d-69ee-4762-ba48-8ab114ade298", null, null, null, false, "Christine", "Christine", "Hilll", false, null, "Christine_Hilll82", null, null, "AQAAAAEAACcQAAAAEPbXy9nmCoOoXmHibVO08iwMJ9czD6F06xsllDm3VEz36Ww9YDv4XD60SKCvKAl2kw==", null, false, null, null, 2, false, null },
                    { new Guid("42babbec-5dbe-4cc3-9f68-bb4bc7ad9491"), 0, null, 59.47465699006470000m, "4cd60fd4-8c02-4697-9118-52f3b31f7bca", null, null, null, false, "Clara", "Clara", "Hegmann", false, null, "Clara_Hegmann", null, null, "AQAAAAEAACcQAAAAEPI7YupcCzFA/GFBlFo2AUWAB/S0H3om0Xxp2APYZyVwkuoM8SEo1vrk81QRW1HCrw==", null, false, null, null, 1, false, null },
                    { new Guid("42c4353e-7775-4c68-a647-2b921bb87c89"), 0, new DateTime(1954, 9, 27, 10, 58, 25, 945, DateTimeKind.Local).AddTicks(8477), 540.5067182294920000m, "9cdfb5d7-3d61-4887-b707-8356d9a0fdc8", null, null, null, false, "Ashley", "Ashley", "Witting", false, null, "Ashley.Witting", null, null, "AQAAAAEAACcQAAAAEMou+TQW0+2LSqctXKwkUcqVKSKCF3g/stC+hdGb3A8d/zhi/BJl8zyC05q9Dl/I4A==", null, false, null, null, 1, false, null },
                    { new Guid("46542d6d-04cc-418a-88b4-cda40f4aff48"), 0, null, 686.8775651345680000m, "5c708d19-cc04-4fd7-a69e-833596d9cf52", null, null, null, false, "Hector", "Hector", "Wyman", false, null, "Hector42", null, null, "AQAAAAEAACcQAAAAEOLO4Eu/BYxG5Z0c+Sq/D3/BNcXtTmYzrCUqqn6jzQrSqV7M2jmV43i9LXdC79pIeA==", null, false, null, null, 0, false, null },
                    { new Guid("46843658-5438-46a9-b26a-f6c2fcfd1883"), 0, new DateTime(1948, 12, 9, 16, 13, 47, 749, DateTimeKind.Local).AddTicks(4971), 334.7186605062380000m, "b9a251d4-7290-4818-a346-44ccb90d577c", null, null, null, false, null, "Kenneth", "Wehner", false, null, "Kenneth.Wehner68", null, null, "AQAAAAEAACcQAAAAEKxYPrZlIbxNxvk28a3+7t58PLeLm2fQLKByMARtv/KI9N4tNwYtRxMAnVdKkllz4g==", null, false, null, null, 1, false, null },
                    { new Guid("4732299f-418c-4c2e-ac09-aacb3b2c8976"), 0, new DateTime(1955, 4, 10, 7, 13, 38, 722, DateTimeKind.Local).AddTicks(5629), 622.543284493690000m, "52fd5e2c-d657-45ee-9491-efb9ce168b0b", null, null, null, false, "Dwight", "Dwight", "Krajcik", false, null, "Dwight.Krajcik48", null, null, "AQAAAAEAACcQAAAAEMfj0xJmwFpD5gYx41dQczkZIWpSNyMDx0ElhFUyKGFpsxDPJGRqYpt1LSZ2M7de8Q==", null, false, null, null, 1, false, null },
                    { new Guid("482632b6-5f62-4fe4-82e0-1b6f0d3ee842"), 0, new DateTime(1957, 10, 14, 18, 34, 50, 572, DateTimeKind.Local).AddTicks(2446), 672.4554967690140000m, "3ab694e7-635e-4fff-99aa-95d51731f554", null, null, null, false, "Kendra", "Kendra", "Emard", false, null, "Kendra.Emard", null, null, "AQAAAAEAACcQAAAAECV2Uqe8Ays1Y+ojT+DTVAHusuy8qDusKFtKqt9bjkKUr+m1Kt4upTEfX32BEqv0sA==", null, false, null, null, 1, false, null },
                    { new Guid("487efc58-2d93-4b91-a4fb-1ce1d3ef038a"), 0, new DateTime(1934, 1, 15, 1, 19, 51, 923, DateTimeKind.Local).AddTicks(3812), 831.2237897184640000m, "603d3f3f-67c5-4edc-846b-f2207478d14b", null, null, null, false, "Hector", "Hector", "Keeling", false, null, "Hector14", null, null, "AQAAAAEAACcQAAAAEKOKFz9NUGNoP3Pim8iuRLYX4OwvDzr5ZZKERR92Yv+AQwXkNyqYssygEPbCxlZ/yA==", null, false, null, null, 1, false, null },
                    { new Guid("487f0344-4cde-4b10-971a-1f8311cce3f5"), 0, new DateTime(1940, 8, 31, 19, 13, 58, 910, DateTimeKind.Local).AddTicks(4546), 719.8721490998940000m, "edc3e8a2-4b2f-4828-9f73-283da04491b4", null, null, null, false, null, "Eduardo", "Goldner", false, null, "Eduardo.Goldner", null, null, "AQAAAAEAACcQAAAAEO95E99O99GIN2Ej0bcVoxKtky9Mil2Dsnv2mwtnP5zQBx8O6gkVcadkABAxYfKvrw==", null, false, null, null, 0, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "Email", "EmailConfirmed", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("48b3cd65-be2f-4be1-a3c5-d88da44b3d73"), 0, null, 440.1076853644640000m, "7c6347bf-cf24-4329-a0ff-882501a3c7d6", null, null, null, false, "Jacob", "Jacob", "Mohr", false, null, "Jacob.Mohr52", null, null, "AQAAAAEAACcQAAAAEOTfbNoVNkukJ1a0Q5ATaGXJ5VgjDRBwdAKX0kwaqwPwEylZYotp5j4Tv4x5FXUDiQ==", null, false, null, null, 1, false, null },
                    { new Guid("48f4af12-c8b0-4444-98ca-81df5d349e01"), 0, null, 530.6662730450380000m, "eae3e2ef-d478-428f-97c9-5405a55e78a4", null, null, null, false, "Christy", "Christy", "Smitham", false, null, "Christy_Smitham80", null, null, "AQAAAAEAACcQAAAAEC3Ey8mCIOSoKLu4s33qOCQm+I1E54JHsD/b4eeXzMZd31/qqMGaQqQPNmuTWnmfzw==", null, false, null, null, 1, false, null },
                    { new Guid("496d8ed2-fc6d-49e6-b902-8a1d0b266928"), 0, null, 812.9483701368240000m, "004b542b-8661-486a-9d21-afacbd946b8a", null, null, null, false, "Megan", "Megan", "Moen", false, null, "Megan60", null, null, "AQAAAAEAACcQAAAAEEO9d6xHwm18I9VHV4ofeDQJPqZyZBwYteAzLdf+2p3slG7GM/Bn2l254bkOSsUg8Q==", null, false, null, null, 2, false, null },
                    { new Guid("49ef4ccb-eb29-4ffa-bcfe-88759ac3f1c5"), 0, null, 738.9752027196570000m, "73975293-2364-4fc7-be61-c74865a09f64", null, null, null, false, "Diane", "Diane", "Considine", false, null, "Diane.Considine", null, null, "AQAAAAEAACcQAAAAEGek8vK1Qhrm7q+iuhn9S3sOIBaa2q8wAWp9wtQWEmTEn6cq6OWP+vf3uBcYxWkXwA==", null, false, null, null, 1, false, null },
                    { new Guid("4a9e17b4-cb0f-4c82-80d2-e1d56fe06f0a"), 0, new DateTime(1946, 8, 6, 22, 1, 20, 898, DateTimeKind.Local).AddTicks(3062), 350.7729335652080000m, "27e7a6db-1378-4a6d-b9da-56eaea92ab70", null, null, null, false, "Keith", "Keith", "Kub", false, null, "Keith.Kub", null, null, "AQAAAAEAACcQAAAAEHn7NweUNAlwY3H4h20LZVxasTiS6zcYaYGjTZxVJEOc9Q2i2EgcYyjVrO5IGw5rtQ==", null, false, null, null, 0, false, null },
                    { new Guid("4b2a14c5-b9ad-4e45-ae16-0762e7d1e215"), 0, new DateTime(1998, 8, 23, 14, 16, 33, 441, DateTimeKind.Local).AddTicks(2130), 311.4714644603230000m, "984c9c22-8fa6-4ed5-94ba-f9363a4ced78", null, null, null, false, null, "Amos", "Greenfelder", false, null, "Amos.Greenfelder57", null, null, "AQAAAAEAACcQAAAAECBa5a3i6UGJnlQ4gnPK2AxQbZUIr+SzuzQ3RPqHddTkkNqP7v9A0EDtFOIcwhBBbA==", null, false, null, null, 1, false, null },
                    { new Guid("4b45c810-f446-449d-8b0e-4a2ebbbf7104"), 0, new DateTime(1983, 1, 4, 9, 25, 50, 729, DateTimeKind.Local).AddTicks(6476), 175.1959574396060000m, "fe5cc98b-5e29-4c8a-89cf-3dd63243f371", null, null, null, false, null, "Erika", "Crona", false, null, "Erika97", null, null, "AQAAAAEAACcQAAAAEDWpCKrEfk1UrNxCOXgH/2V4eEWs190w3kmMrlATePKJm6OJpW+kYSl0gVaMMULVqw==", null, false, null, null, 1, false, null },
                    { new Guid("4c5d0085-4956-4748-b989-09b4d927d669"), 0, new DateTime(1982, 3, 14, 18, 19, 18, 932, DateTimeKind.Local).AddTicks(6793), 856.277630401040000m, "6033307f-fec5-4989-8c0e-9d9bdd2c8f51", null, null, null, false, "Roderick", "Roderick", "Borer", false, null, "Roderick91", null, null, "AQAAAAEAACcQAAAAEPf0PkN3ioDUc/EvJUrYI1eES5VlZYVe1opol+3C+Z269qdWNrXBKcUTpT19Ixymgw==", null, false, null, null, 0, false, null },
                    { new Guid("4d006d0d-8a50-4d81-886b-176313d018fb"), 0, new DateTime(1958, 2, 20, 12, 41, 59, 502, DateTimeKind.Local).AddTicks(3233), 89.45645704032470000m, "c1aad5ec-173d-4a98-b25b-b497dc36012c", null, null, null, false, "Josefina", "Josefina", "Langworth", false, null, "Josefina95", null, null, "AQAAAAEAACcQAAAAEP4BFfO8dNltqJqYhyEw3B+OM+XjcZ4RIrep4AJNHiE0w2T6T9a0Pro9RFN44UaLzQ==", null, false, null, null, 2, false, null },
                    { new Guid("4e8c89c0-a2fb-42d3-8d7a-11fe5d3b6d75"), 0, new DateTime(2009, 4, 22, 7, 27, 42, 711, DateTimeKind.Local).AddTicks(1651), 305.0273723894260000m, "348392de-9ba8-41a7-ac5e-1d40beade840", null, null, null, false, "Hugo", "Hugo", "Stark", false, null, "Hugo_Stark8", null, null, "AQAAAAEAACcQAAAAEEw3eVuIVcIwCDtIcqGcMbrAoYac+rbjbX8BQC1WQ43PgmDhLvn3+a0cYaVhOeGZGg==", null, false, null, null, 1, false, null },
                    { new Guid("4ecad1f7-2b37-4dd8-be42-dedd60205e81"), 0, new DateTime(1964, 10, 7, 15, 56, 36, 209, DateTimeKind.Local).AddTicks(8815), 70.12527495168780000m, "621f8296-8bc1-493b-96e2-975ae8b25307", null, null, null, false, "Pam", "Pam", "Volkman", false, null, "Pam.Volkman", null, null, "AQAAAAEAACcQAAAAEMEyUMQmlbvZITi+gd6GKjvCXqc2Z9TM0EUMeBUffm27cjcx7LBBRBFqejTBrvX7mw==", null, false, null, null, 1, false, null },
                    { new Guid("4efd0f6e-db18-4603-b7c2-f032eb9132a9"), 0, new DateTime(1949, 10, 30, 10, 51, 42, 330, DateTimeKind.Local).AddTicks(1298), 695.8935866328610000m, "0782fc60-4000-425e-a0f8-8bc9da91a84e", null, null, null, false, "Candace", "Candace", "Smitham", false, null, "Candace17", null, null, "AQAAAAEAACcQAAAAEM2MhncSZXPPUkMbS44xOIFt/xgi4LZ23bhRfmYEI2XUXoSpxECyzDLMTd098M7Mrw==", null, false, null, null, 0, false, null },
                    { new Guid("4f42e5ab-642c-4775-b2b2-a116ecfcd663"), 0, null, 299.2335038244740000m, "404942e1-c4c1-41a6-8484-a2c8df08d652", null, null, null, false, null, "Joanna", "Rice", false, null, "Joanna.Rice13", null, null, "AQAAAAEAACcQAAAAEL+J+9uUtRnSdbrv0KUhmJC7bOZ0roVFWdigKVGC38qE3wHn4xIh+VDylf1ATwDPug==", null, false, null, null, 2, false, null },
                    { new Guid("4fdddaf5-83dc-4f45-ad82-fcab10f87405"), 0, new DateTime(1930, 5, 28, 9, 10, 37, 321, DateTimeKind.Local).AddTicks(9893), 20.55774852552860000m, "1b2a00f2-3c71-40bd-9199-3e04e6a9d910", null, null, null, false, null, "Robin", "Schuppe", false, null, "Robin_Schuppe3", null, null, "AQAAAAEAACcQAAAAEGrrM6fL4G1OlwlAbVAMgz4jHsZ9u6sGb9NKqwJACbcUlk6Wn+dXpPrAZRRKguZGCw==", null, false, null, null, 1, false, null },
                    { new Guid("50ac14d1-c13d-42f2-8026-301c38b1964b"), 0, null, 526.3261585884090000m, "051dff0d-79af-4c68-8f72-11378604733f", null, null, null, false, null, "Louis", "Kutch", false, null, "Louis89", null, null, "AQAAAAEAACcQAAAAEOU6q270X0StkJemumWM20CtqgxRaXvffnrstttsI/wqKWT4Npx4AACR3zgWvDovog==", null, false, null, null, 0, false, null },
                    { new Guid("50b1b40f-32d2-45da-a690-b9d24fff476e"), 0, null, 307.5912433705660000m, "88e89178-5e53-4b24-a47c-ea498533796d", null, null, null, false, null, "Cameron", "Kassulke", false, null, "Cameron89", null, null, "AQAAAAEAACcQAAAAEI69m9kdwk0CSoRu7kaPRyUYQAfrih2UY3CjwcqMBHG9XBYUgeDS9rmrMjXTOY6zzQ==", null, false, null, null, 0, false, null },
                    { new Guid("50fa1a40-d4af-4edd-8c00-61ec693395b2"), 0, null, 418.0653661498980000m, "2850ddf8-eb8b-4c7d-b746-2477257d0893", null, null, null, false, "Hubert", "Hubert", "Hartmann", false, null, "Hubert.Hartmann", null, null, "AQAAAAEAACcQAAAAELPg3I7OlaAEINt2qei2jZuUe4F5BHOksRA9I098e6i9prrolO1yUZ5ssn+eng1sTg==", null, false, null, null, 0, false, null },
                    { new Guid("530579fa-33a7-4827-a21f-b9cacab42c7d"), 0, new DateTime(1960, 5, 8, 12, 7, 54, 442, DateTimeKind.Local).AddTicks(5005), 862.8164895424270000m, "08b41ad3-2294-4485-b094-c0296d43221c", null, null, null, false, "Emily", "Emily", "Murray", false, null, "Emily_Murray1", null, null, "AQAAAAEAACcQAAAAEAB5RT+nyf++1nUYQNyyalDXnpukuI0iinTpFrM1UCpWBT8wI0Obnd5fvCvTr6WQYw==", null, false, null, null, 2, false, null },
                    { new Guid("539c62ee-15fc-4d37-ab5d-0e4126109954"), 0, null, 506.6291963067970000m, "e926523d-cec4-4d3f-b3b5-352034ff0624", null, null, null, false, null, "Toni", "Mann", false, null, "Toni_Mann44", null, null, "AQAAAAEAACcQAAAAEOUMH9t3W5zA6a/hoPtC+yQ9AeVI8fQfBEZ4L6oWA07GrnFU78uLExDiOgKJI/vQCg==", null, false, null, null, 2, false, null },
                    { new Guid("548e47d4-b851-4432-8514-fc092768db5b"), 0, null, 145.5047395801760000m, "ecd40a95-85ca-48ef-8617-54b9ae2214bc", null, null, null, false, "Antoinette", "Antoinette", "Russel", false, null, "Antoinette_Russel", null, null, "AQAAAAEAACcQAAAAECuSN5jeGrnh2Lfjd7Tujy9huUl0BJUcUDVnIVOmPKxGL0R9YGcJa9ay0E12w6Oy+w==", null, false, null, null, 1, false, null },
                    { new Guid("54c975d2-dbfe-4626-97fa-ceaa28e85030"), 0, null, 453.4510829053880000m, "cd734b97-00b4-4b1b-a5b5-9d04e9243a0c", null, null, null, false, "Christie", "Christie", "Kohler", false, null, "Christie_Kohler", null, null, "AQAAAAEAACcQAAAAEIWYA0I2JaWYNEgpGY1xdztMSUz1yj9OC9q1A/hNMwM74T5JczxUgoarpwUArdR60w==", null, false, null, null, 1, false, null },
                    { new Guid("56234ad9-accf-413f-8d2b-5d6fb1cd04a1"), 0, null, 692.5825469355920000m, "068f06f8-c750-4f22-9788-ab96a015b6f2", null, null, null, false, null, "Darrel", "O'Connell", false, null, "Darrel.OConnell94", null, null, "AQAAAAEAACcQAAAAEMcSAgesK8U3nrKHvJabTlKdyrAGI79jWADkltyBy8jFZSDitrkB2gD8WWrylnaC5g==", null, false, null, null, 0, false, null },
                    { new Guid("56b8dced-e510-417c-8b93-8a2cb06b845a"), 0, null, 851.835863268590000m, "d3f96fc7-72c9-48ea-a693-e0ad94b88e3a", null, null, null, false, null, "Yvonne", "Brakus", false, null, "Yvonne_Brakus", null, null, "AQAAAAEAACcQAAAAEMnyDIQmu0c5ONMmicQ+kO32Be7g72ycVzRbk5OZaQOOlBWDX7PPwSyeZ79HUtVlcQ==", null, false, null, null, 1, false, null },
                    { new Guid("56c8b4b0-c1db-425e-a349-2f7b3feabb5e"), 0, new DateTime(1939, 1, 22, 3, 11, 58, 916, DateTimeKind.Local).AddTicks(665), 668.8827787454430000m, "01f81ce0-799a-4827-85cc-a21ab8a97e1d", null, null, null, false, "Ryan", "Ryan", "Borer", false, null, "Ryan_Borer37", null, null, "AQAAAAEAACcQAAAAEMi+MjcOJSc880fIOEXY2mZa3Ms/50G9IPxgQ9JdNSpFCngdQzjF8MofyMk8FaNUpw==", null, false, null, null, 0, false, null },
                    { new Guid("57b666b4-3a1b-4303-851f-a88f5f534543"), 0, null, 940.4153027818440000m, "53378e36-2075-4644-89c6-9976b7af76a3", null, null, null, false, null, "Sandy", "Casper", false, null, "Sandy.Casper", null, null, "AQAAAAEAACcQAAAAELCAuTp/ldQmWmQ4z4dEsMPnSaDbiOwTfV+jpmJpq+GFuC6JvNhL/kpi9hDXCk0K9A==", null, false, null, null, 0, false, null },
                    { new Guid("59a9232d-40d9-422d-8a1a-fe022e85093a"), 0, new DateTime(1968, 3, 19, 16, 22, 41, 632, DateTimeKind.Local).AddTicks(6798), 624.2269837740540000m, "0368916b-4aeb-49e3-b8e6-8207bcba2371", null, null, null, false, null, "Wilma", "Parker", false, null, "Wilma30", null, null, "AQAAAAEAACcQAAAAEFHSTjhrhQawQy8O/G4JhXZegcASnR2Ym0u2aZ8OfQbhwcQdSCvk2VgMp+cQ5LZBgg==", null, false, null, null, 1, false, null },
                    { new Guid("5aff4312-b9a9-4958-b14a-305be3aa9f4b"), 0, new DateTime(1997, 2, 2, 13, 59, 16, 110, DateTimeKind.Local).AddTicks(3057), 516.6828123552470000m, "e8e8e943-8616-444d-bdf2-74eccc510b42", null, null, null, false, "Jana", "Jana", "Beier", false, null, "Jana_Beier4", null, null, "AQAAAAEAACcQAAAAEJOd+Panq3wGqJx8vu3irHy/kLZotUmJ7R8qiOLallYN4L3crPhLTyuenBKSWo2DHA==", null, false, null, null, 0, false, null },
                    { new Guid("5c5b9127-2aa5-4ed6-b779-6402154d5c0f"), 0, null, 97.85547101099290000m, "edbfe763-07a3-467a-b3ce-5cd9705d6486", null, null, null, false, null, "Jordan", "Swift", false, null, "Jordan.Swift", null, null, "AQAAAAEAACcQAAAAELbIZdLGyDLvW3EcrePvQN1fbDtbnlAsOkRPoqicH5adFg2sQJnWX3mbFgLhBJqiaw==", null, false, null, null, 0, false, null },
                    { new Guid("5c6a10ae-343d-47fa-9381-6cbe7b1a68be"), 0, null, 226.1803468548040000m, "0fefa313-e1de-4a5e-8e4c-eba406ae6263", null, null, null, false, "Sheldon", "Sheldon", "Ziemann", false, null, "Sheldon_Ziemann29", null, null, "AQAAAAEAACcQAAAAED1uWxiwUnV6xyykNrJ4b0YRXHDgQt5BJAYdHq4rksSNsXvI5EUn6ldOiJd0VubelQ==", null, false, null, null, 2, false, null },
                    { new Guid("5d1e2a88-0f0a-4b6e-a524-e279224a1944"), 0, null, 274.9652876070030000m, "b33213fb-7a51-43fb-b2e3-73a8a7ed00f0", null, null, null, false, null, "Daisy", "Beer", false, null, "Daisy_Beer13", null, null, "AQAAAAEAACcQAAAAEEVHdMmEaW8eo+uJSySzJ9LROktDGPOx2v1MRvFUBeoggVdLAW7MPyE7dXUki4fLTQ==", null, false, null, null, 2, false, null },
                    { new Guid("5d203345-c58f-4236-9e46-c9ba7a8529a5"), 0, new DateTime(1958, 5, 1, 1, 1, 55, 538, DateTimeKind.Local).AddTicks(6288), 226.7269961811850000m, "3d8d3349-81fc-4545-9411-6f6d854f2d1c", null, null, null, false, "Charlene", "Charlene", "Bruen", false, null, "Charlene_Bruen", null, null, "AQAAAAEAACcQAAAAEAqagq/BOQS+clxsoBpwKIBRWrJi19L12Ie0bohjrag/wEy859ppSUmvhhBXq3wY6Q==", null, false, null, null, 0, false, null },
                    { new Guid("5e1f9cf6-8e77-46be-92e7-b3f10da0ed86"), 0, new DateTime(1984, 5, 24, 3, 9, 15, 990, DateTimeKind.Local).AddTicks(4673), 429.2154331000340000m, "bb684604-0eee-4299-9eae-37275102e1e6", null, null, null, false, "Marion", "Marion", "Schmeler", false, null, "Marion20", null, null, "AQAAAAEAACcQAAAAEGkcxc+TPruSIIUb8gbu1sdHEeH+Sgk+bJYbP6kWfwdOvySQFPsTDK3W9qcuD4qc1g==", null, false, null, null, 2, false, null },
                    { new Guid("5f366c1b-9e38-4bc9-b773-fca63347cbcc"), 0, new DateTime(1981, 8, 27, 20, 0, 51, 108, DateTimeKind.Local).AddTicks(5376), 454.5020635843770000m, "bee49dd7-43ae-4f60-a081-d9400a285885", null, null, null, false, null, "Johnny", "Mills", false, null, "Johnny84", null, null, "AQAAAAEAACcQAAAAEKFCj8YKVOS2IiuNVL4cD5mGH+Eeej+gT1jFrhMEbjNOGoMxKaLTqYhx8NHj9pz6IQ==", null, false, null, null, 0, false, null },
                    { new Guid("6101631f-7cf2-4393-a938-099c07dbe44b"), 0, new DateTime(1996, 10, 5, 13, 10, 29, 205, DateTimeKind.Local).AddTicks(3553), 307.0418686270580000m, "eb0f3f0d-5027-452d-a1cf-79b65a36cdc8", null, null, null, false, "Vicki", "Vicki", "Hauck", false, null, "Vicki_Hauck41", null, null, "AQAAAAEAACcQAAAAEPmyA5LdAtSDtDMwSiVF5GEFVMocaDyljBdQlpbQOXcC1wEVo7IR1Zfe5u8cPM55ww==", null, false, null, null, 0, false, null },
                    { new Guid("61dcb7dd-eb57-4421-b814-6cd202b0f4a1"), 0, new DateTime(1951, 9, 11, 15, 40, 45, 382, DateTimeKind.Local).AddTicks(9926), 705.1672545502660000m, "036c8482-2373-49e4-bf55-f97a49d4167c", null, null, null, false, null, "Diana", "Collier", false, null, "Diana.Collier31", null, null, "AQAAAAEAACcQAAAAEIgLZAv1w/IwSkm+oQzlPTFqWcnxr7JdVOxGI44fW/xlK99m5hokmaRjduahu6jxKg==", null, false, null, null, 1, false, null },
                    { new Guid("6218849a-9af3-4ab0-93d1-f5fd29135491"), 0, new DateTime(1953, 12, 25, 10, 32, 4, 75, DateTimeKind.Local).AddTicks(1375), 730.5460332882760000m, "09a68ac4-e910-4f88-9191-114afb868e34", null, null, null, false, null, "Salvador", "Shanahan", false, null, "Salvador.Shanahan0", null, null, "AQAAAAEAACcQAAAAEED5sGRoIrYkxl44oVn9FU/eiMl9tMo01j3vVT/d8O2VVs/x+HbbqXRzRYj4DiFQsA==", null, false, null, null, 1, false, null },
                    { new Guid("63107baa-d978-4764-b959-7e90a1de3ee0"), 0, null, 469.1176218973720000m, "490430bf-d088-4d63-8780-98b680072c09", null, null, null, false, "Derrick", "Derrick", "Ondricka", false, null, "Derrick87", null, null, "AQAAAAEAACcQAAAAEI44jrJEtaGN7RQqfwIqOj1zQBYo5KuhGHSZJt/xJJNd1ypJrZGIeXZemUzode+54Q==", null, false, null, null, 2, false, null },
                    { new Guid("64174d68-43d3-488f-89bf-23d32b134019"), 0, null, 253.6106830198610000m, "3d229662-3a6c-4ebe-a335-6dd109b7b5f5", null, null, null, false, null, "Darnell", "Witting", false, null, "Darnell34", null, null, "AQAAAAEAACcQAAAAEKZNobfnKYINRYSeA95o+xnFrnOlU6TkmZtvqdnG4JAc+dBVqugse5eqtDcOpCJ8Qg==", null, false, null, null, 0, false, null },
                    { new Guid("64e0a0ed-41a2-429f-800b-6407610d5984"), 0, new DateTime(1980, 6, 23, 23, 49, 38, 204, DateTimeKind.Local).AddTicks(7966), 995.1923977866450000m, "f86b83fb-17fd-4995-bf12-b504141ec03e", null, null, null, false, "Hope", "Hope", "Langosh", false, null, "Hope.Langosh71", null, null, "AQAAAAEAACcQAAAAEEUKivBYch4N1FGAD1j6KO+YvxiU8JaDnBqSs8vUF+mZdFUIr7DQINLkVngMB3GiXw==", null, false, null, null, 1, false, null },
                    { new Guid("652ba8ca-0eee-4fb2-a548-4621f2c8de0b"), 0, null, 25.61612681233150000m, "b607d7bf-b2a8-499a-8e0f-a4a0114d5861", null, null, null, false, "Alberta", "Alberta", "Mayert", false, null, "Alberta.Mayert", null, null, "AQAAAAEAACcQAAAAEPf7lLaKZeIWiMthek302aufT7SX434bpPFJYM/kBZNJCY2a/ETkDAzGJ0USJC9CbQ==", null, false, null, null, 2, false, null },
                    { new Guid("653800c1-b55d-4636-99c0-ea31223d7e3b"), 0, null, 418.4562542185990000m, "f8cce58d-24e7-4201-b922-a2f2beb2ed68", null, null, null, false, null, "Jean", "Legros", false, null, "Jean.Legros", null, null, "AQAAAAEAACcQAAAAEC/DFe8yn60A2vfpWD3Q1w5L4vgPmxMjWnwFDz6y2rBQox/yQPuvsBqhxv1vO/NQ7Q==", null, false, null, null, 0, false, null },
                    { new Guid("658f3ddd-678c-4dca-b9fa-45901c0f1c05"), 0, null, 585.6883037405280000m, "9ed92be6-6b43-4e7e-8418-cc960c0d5a70", null, null, null, false, null, "Elena", "Kohler", false, null, "Elena_Kohler80", null, null, "AQAAAAEAACcQAAAAEHU/n0THlmOLVtEL1xbzOxVZWXHfBYD5D7rVZJvwJNo4xvuCJnkwB5SqqRM4pHqlrQ==", null, false, null, null, 2, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "Email", "EmailConfirmed", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("66da7f26-36d5-4406-a2e4-35363c8e43cb"), 0, null, 725.4639816011760000m, "e63742b0-7852-4757-84ee-ebb16ab6ae6c", null, null, null, false, null, "Vivian", "Moen", false, null, "Vivian.Moen91", null, null, "AQAAAAEAACcQAAAAEFMiiMIORaDZI8FdkbImx3W/kpdmRsNl92hl4i8y8iRkS2IJ4BRYvW7lb5x9xVqKmw==", null, false, null, null, 2, false, null },
                    { new Guid("672ce079-171b-4f7e-b744-6b9376e96b61"), 0, new DateTime(1981, 11, 27, 6, 46, 59, 802, DateTimeKind.Local).AddTicks(5219), 80.75021241241930000m, "26d67bb7-3b40-4a29-8863-7aabce95eebd", null, null, null, false, null, "Cora", "Kuvalis", false, null, "Cora_Kuvalis", null, null, "AQAAAAEAACcQAAAAEA2CXYY1m+Rvu43mG2/p4td1hrrK0Z18ifbhHxR/3T4QKG5jswEh+TjIYAkbSQR3Mg==", null, false, null, null, 2, false, null },
                    { new Guid("67a258f9-5c48-4651-8f32-1ee7f5b4246d"), 0, new DateTime(2001, 3, 15, 23, 50, 50, 629, DateTimeKind.Local).AddTicks(6594), 734.4337072183570000m, "3fb308db-8776-40f9-9048-2a53fdb1a861", null, null, null, false, null, "Darlene", "Hilll", false, null, "Darlene_Hilll86", null, null, "AQAAAAEAACcQAAAAEL4nN0j0rbooGBo+ZJ7OsLjly1+Vwc43HQH/yGJJjxWW75NJFSlgseZShiclbEPBWw==", null, false, null, null, 2, false, null },
                    { new Guid("6ab8f9db-6513-4d8f-9cde-7b925ff51057"), 0, null, 52.93438160266110000m, "da9ac947-defc-4dd0-9592-2b1542e44e75", null, null, null, false, null, "Susan", "Klocko", false, null, "Susan22", null, null, "AQAAAAEAACcQAAAAECqVb26pI5FdrD/d0oy614+puVIOFvItTa5uYcnCpTT4kAV7f5QEa9/O+zBkHFCq0A==", null, false, null, null, 2, false, null },
                    { new Guid("6b5cd903-9056-4302-b3e6-b910c3a67f76"), 0, new DateTime(1955, 12, 24, 3, 3, 8, 714, DateTimeKind.Local).AddTicks(2040), 912.5954384891020000m, "322bd3fc-b76b-41f1-9e04-08dff9c8f385", null, null, null, false, null, "Dwight", "D'Amore", false, null, "Dwight.DAmore55", null, null, "AQAAAAEAACcQAAAAEJu3eh0GqXvdZQ/lR52oYePlIe1rY4jcVAQka4eKgH9zeXrdDHQkWXsY1Cd90853Kg==", null, false, null, null, 2, false, null },
                    { new Guid("6c16f159-98d6-4d70-a7ac-43b19b827d49"), 0, null, 108.7125696101860000m, "7d6c8ee3-0261-4224-be88-880649f43bc4", null, null, null, false, null, "Rafael", "Keeling", false, null, "Rafael33", null, null, "AQAAAAEAACcQAAAAEIaJpYp2OU04NRZy1o13YORmBSI5OLGOg1Y+RvThsv+jrrC3EFowZVgaySYCv2O+IQ==", null, false, null, null, 0, false, null },
                    { new Guid("6c3e0836-290a-4c10-8832-91720a2e9054"), 0, new DateTime(2002, 6, 17, 16, 13, 36, 920, DateTimeKind.Local).AddTicks(4001), 332.3888241483280000m, "21f6353d-efff-453d-9c41-7414acc2d14b", null, null, null, false, "Estelle", "Estelle", "Rath", false, null, "Estelle_Rath", null, null, "AQAAAAEAACcQAAAAEJkQ3VSPvFrezAefw1dIvBAQsA9NEOM9GyWfYRsp/Yi47gIEs+Zn4Mjtogjpb1b8FA==", null, false, null, null, 2, false, null },
                    { new Guid("6c3f8b98-7095-4d12-8f55-02b23a300d5f"), 0, null, 118.0345169475160000m, "2355ae3f-d7a2-4e45-8cd3-8d78835e3cc9", null, null, null, false, null, "Ana", "Hettinger", false, null, "Ana_Hettinger", null, null, "AQAAAAEAACcQAAAAEDFa4yeTj/hdzCGMT56+Npo8Vxw+p/hoc3WIo+zao5nrtdPs58b0lAr19H5RoM/Vbw==", null, false, null, null, 1, false, null },
                    { new Guid("6ef84803-7ff7-46d1-b1b3-ebda82e158b3"), 0, new DateTime(2006, 8, 23, 0, 30, 40, 560, DateTimeKind.Local).AddTicks(6082), 478.3513376869780000m, "1362119f-0d98-4215-bd91-3b68af65f69b", null, null, null, false, null, "Tomas", "Larkin", false, null, "Tomas.Larkin96", null, null, "AQAAAAEAACcQAAAAEGTSDiM69/e+Fox5DksEopBOCYYdZYlAFELLaFCrsAKXhkgSFFTv7qvC7usAuPRc0A==", null, false, null, null, 2, false, null },
                    { new Guid("6f109fcf-941c-474c-810c-243f75df54d6"), 0, new DateTime(1958, 4, 24, 19, 36, 54, 589, DateTimeKind.Local).AddTicks(6946), 371.4920398887540000m, "ba8e4120-6878-4dba-98d3-5475edd626e7", null, null, null, false, null, "Rudy", "Rolfson", false, null, "Rudy42", null, null, "AQAAAAEAACcQAAAAEKh6GMLonx1A2NZi0GJN2fDxFADvr+bCGFwQ6RrJX7Zbmfd9qIg7WrhcIi8Z+m50MQ==", null, false, null, null, 0, false, null },
                    { new Guid("6f196aeb-f350-478e-a23f-992b0ea6da29"), 0, new DateTime(2007, 4, 14, 19, 12, 18, 36, DateTimeKind.Local).AddTicks(2287), 946.7132912846960000m, "0837876b-554c-4261-8ab2-e830f998d961", null, null, null, false, null, "Josh", "Trantow", false, null, "Josh.Trantow65", null, null, "AQAAAAEAACcQAAAAEIkDXpsR3u924hetSn8AvU9JXbWXvzWCjlN2uhiORnsWI4TgcglC+jmk9zGTNfiGrg==", null, false, null, null, 2, false, null },
                    { new Guid("70d04e87-92ed-4410-96a6-934a82c8bbcb"), 0, null, 810.7482186758870000m, "ee9874c2-2982-4bcb-802a-8f30278e33d0", null, null, null, false, null, "Ross", "Doyle", false, null, "Ross_Doyle42", null, null, "AQAAAAEAACcQAAAAEPo3Nvaoqwpkn3UbDuYlAH1TiypNGWE8Qf4SLLDKyqolkSxP8TIHxjaQwPGoKWKMjQ==", null, false, null, null, 0, false, null },
                    { new Guid("718a03a0-2841-450f-a417-5345b18c81ab"), 0, null, 142.2672365636710000m, "0b358103-b004-40a2-bae0-bb8ce2269b99", null, null, null, false, null, "Dallas", "Kirlin", false, null, "Dallas.Kirlin", null, null, "AQAAAAEAACcQAAAAEDcLJCQo7WlMfwTAlSR03YTXguuevXLqapm4+ukRZ8ealfckFo6gj7U3MFvC6hbBnA==", null, false, null, null, 1, false, null },
                    { new Guid("719d1670-ba7d-4e9b-b4de-d7074f81aa66"), 0, new DateTime(1969, 6, 5, 0, 21, 5, 258, DateTimeKind.Local).AddTicks(649), 906.8501968650820000m, "98db3473-af7f-4d17-aad2-dcd77a5b98fb", null, null, null, false, "Kimberly", "Kimberly", "Marquardt", false, null, "Kimberly25", null, null, "AQAAAAEAACcQAAAAEK8yhkJDxzhu3vSaboq3bqNsXt91k4+I0SzuV3e4IoP7XBfBlNnNUPVCYnqG/jzlvg==", null, false, null, null, 0, false, null },
                    { new Guid("71f7fb3b-e7f1-4325-bdd2-98f71dd515b1"), 0, new DateTime(1974, 10, 20, 21, 36, 52, 525, DateTimeKind.Local).AddTicks(4399), 709.2045151094540000m, "e5e4af18-08b6-44bd-9293-67d7999e0df9", null, null, null, false, "Dana", "Dana", "Howe", false, null, "Dana_Howe39", null, null, "AQAAAAEAACcQAAAAEFW9x0p0ky6deaQFWKaEzCEFKN++xjicv03RSGRyMva8ymwyMsLMiu12Y+MKaNe3Lw==", null, false, null, null, 2, false, null },
                    { new Guid("72a42c8b-ed7c-4e7a-81c6-313cac897b20"), 0, new DateTime(1993, 3, 11, 7, 30, 48, 715, DateTimeKind.Local).AddTicks(6417), 583.2628668093440000m, "8633aece-ad69-4f9a-8dfd-4d91d6fcfad6", null, null, null, false, null, "Julius", "Bruen", false, null, "Julius_Bruen59", null, null, "AQAAAAEAACcQAAAAEDO50tybGqy1QGfqolmNrs8GBBPCX7R18xEhhs95PgvUpeIJ7F9KcduhXd9Gbxmxew==", null, false, null, null, 1, false, null },
                    { new Guid("74ef9233-8d34-4883-8938-b78b6c147246"), 0, new DateTime(1927, 8, 1, 10, 15, 59, 838, DateTimeKind.Local).AddTicks(58), 882.3771690605780000m, "015a28dd-a15a-4489-b0a9-f4e1e0226179", null, null, null, false, null, "Tony", "Bradtke", false, null, "Tony15", null, null, "AQAAAAEAACcQAAAAEL3hPsDXYBLitFR4f4o4vi+FrsSyXWVDW0IRMtkuW/ODU/N1/966DTzF7ZeCJidoqg==", null, false, null, null, 2, false, null },
                    { new Guid("753e85fe-b18a-442a-b91e-1d9dc9216d93"), 0, null, 131.1015822400830000m, "e5d84e65-7c50-4965-a2d7-df6d685f9797", null, null, null, false, null, "Ervin", "Volkman", false, null, "Ervin.Volkman53", null, null, "AQAAAAEAACcQAAAAEBL9GkO2GJEX4oL4b8S4znJ/PQyhcsCInTK13xpw3q/jAocgR7LCPziUipiwfhSfhg==", null, false, null, null, 2, false, null },
                    { new Guid("757f3f70-fdce-4727-8fcf-9ac8aa0287b3"), 0, null, 649.5049473340670000m, "8ffedf61-d1cd-4f25-ad79-9289fbcfc91f", null, null, null, false, "Kyle", "Kyle", "Jones", false, null, "Kyle_Jones", null, null, "AQAAAAEAACcQAAAAEH56LpjJ6LkuMVgdkxyLwsbZwUG2vF+xwOx7Y+Md0pw1+8JtroEENsRt4YkrlaDBYw==", null, false, null, null, 0, false, null },
                    { new Guid("75ba16eb-aa9c-4c6f-90ae-1515360055a9"), 0, null, 695.5340165960080000m, "fecbe2da-886e-49e8-80aa-8fcb5cc8697a", null, null, null, false, "Marguerite", "Marguerite", "Koss", false, null, "Marguerite.Koss", null, null, "AQAAAAEAACcQAAAAEEP0sKIAh9ubL9zFtBc5uY7YLOWUomMY4dSH7Wmt+1muRwP3PHZJbquR1nDG/S4adw==", null, false, null, null, 2, false, null },
                    { new Guid("76c44275-2d3e-43e9-b34e-c05f912213b8"), 0, new DateTime(2000, 9, 21, 15, 1, 50, 315, DateTimeKind.Local).AddTicks(4344), 171.2865293691450000m, "10a74f57-8eb5-43e2-9569-c095cb9d7006", null, null, null, false, null, "Gerardo", "Stokes", false, null, "Gerardo_Stokes", null, null, "AQAAAAEAACcQAAAAELqWGXl9IUVmjSATX6Yn0QwqwON9A3HvvFdVFIZp7tszPFZQDgQ5klknYj3yDtZUXw==", null, false, null, null, 0, false, null },
                    { new Guid("7778b4eb-db56-4ddd-a0bc-5f46aff077f7"), 0, null, 273.7364179590710000m, "b58ddaad-b408-4a0f-948f-bcb297455595", null, null, null, false, "Gladys", "Gladys", "Kiehn", false, null, "Gladys69", null, null, "AQAAAAEAACcQAAAAECXBHJqb5rq84PV/ecZfHWxMNPmNZRIHQ+la3xKjQmMCYmSR6SdhWMgKI9jaCO1eQQ==", null, false, null, null, 1, false, null },
                    { new Guid("77bc83c5-7598-48f0-b4c1-23f76fd277ca"), 0, null, 665.0204694439920000m, "f552a34b-521e-4aeb-8070-3d9bbb531375", null, null, null, false, null, "Brian", "Kiehn", false, null, "Brian17", null, null, "AQAAAAEAACcQAAAAEJYa8Wx+LMjHdZkjfQXttj+H1zOSkn2DrqbgNWid6QVHt5LIU0b1Qb+8p4nOcRqFCg==", null, false, null, null, 0, false, null },
                    { new Guid("78be92c8-3390-4d5e-aa3a-54c7301eaf2f"), 0, null, 5.719871537560820000m, "da10e6c2-0d5c-4a0f-9663-8454a5d68201", null, null, null, false, "Archie", "Archie", "Morar", false, null, "Archie.Morar", null, null, "AQAAAAEAACcQAAAAEDU/QfwwEMwrk74GOPVyL08zhA5lMTMlu3j5+xtJFw4jCJOmCGbAVPLFHWWnJvc2PA==", null, false, null, null, 2, false, null },
                    { new Guid("7a52231d-ba53-47d6-8382-e5bf5f9e7e24"), 0, null, 358.6798567227770000m, "2b63e31b-94b4-4876-b1bc-73f51f36dc15", null, null, null, false, "Marilyn", "Marilyn", "Greenfelder", false, null, "Marilyn.Greenfelder", null, null, "AQAAAAEAACcQAAAAEEsWF7JnueF9FrNeURbPGb3183g8/PFsRremSKBRAw9V/+jIY1ZHcIo33yRQyr4fVA==", null, false, null, null, 0, false, null },
                    { new Guid("7abaa815-d503-4740-a0a9-20d8752fc2cf"), 0, null, 604.1278068914750000m, "e63e387e-e828-4199-82b7-558720468e8e", null, null, null, false, "Don", "Don", "Shields", false, null, "Don92", null, null, "AQAAAAEAACcQAAAAEDnfQ9XK9PYv2mNBBgPO3ADnGE4jQRKTU1RjeC2iXMg/Iq0bL+s79++AsUkhhHjEDQ==", null, false, null, null, 1, false, null },
                    { new Guid("7c2f2e0c-1d40-453b-84ea-f5f09cb10d28"), 0, null, 985.6220192747940000m, "9ed83481-d6ad-4a4a-bcee-6e7ed18f3050", null, null, null, false, "Carolyn", "Carolyn", "Bosco", false, null, "Carolyn_Bosco50", null, null, "AQAAAAEAACcQAAAAEJ5A85YM+VPnpPDvOdAJe7NErXS3b/0jV/2Da4NYvtwupUGDr5cJwbO1uMJs4bx/FQ==", null, false, null, null, 0, false, null },
                    { new Guid("7cf58058-5eec-4c6e-a4ae-cf50ccf0b2ac"), 0, null, 843.0266261381990000m, "daad0153-c7e3-4d66-b397-44888539ba61", null, null, null, false, null, "Barbara", "Dach", false, null, "Barbara34", null, null, "AQAAAAEAACcQAAAAECfcfLwnwTjYmfQvw4+jtvCUB3tbYOARRuLdb0eITp8xt5RHYUogDgZWpQ7UNO4iJg==", null, false, null, null, 1, false, null },
                    { new Guid("7da75a84-c857-4768-9ff2-252052ea5333"), 0, null, 143.061983192870000m, "ef0bc481-779d-43e8-85b0-b941a1a30df4", null, null, null, false, "Spencer", "Spencer", "Ziemann", false, null, "Spencer48", null, null, "AQAAAAEAACcQAAAAENjuuqsnF7NZK0Y49jv0m3Jc6lr3J7EZ9Q+Hefdg2QsPpqkBsaljzfEATi8X8Ym73Q==", null, false, null, null, 1, false, null },
                    { new Guid("7de3e658-53a0-464d-a4aa-b7bf40828f5d"), 0, new DateTime(1939, 10, 27, 14, 41, 17, 64, DateTimeKind.Local).AddTicks(5888), 927.1207295599420000m, "61142002-eaa9-4e38-b4df-9bef76fb3f0f", null, null, null, false, null, "Lynne", "Terry", false, null, "Lynne_Terry", null, null, "AQAAAAEAACcQAAAAEBd06CdXmuFdP31fwruTzY5MrjTS+nOpY+iSm3YjfrXxZa/OBAhprlcGVCMBE4f8DA==", null, false, null, null, 1, false, null },
                    { new Guid("7e4a74cd-b47b-47e6-ab98-22ed32bd8e27"), 0, new DateTime(1971, 11, 1, 13, 13, 8, 698, DateTimeKind.Local).AddTicks(1258), 852.6523865228220000m, "5b069d6b-d51d-400c-bd09-d3552733b978", null, null, null, false, "Jackie", "Jackie", "Balistreri", false, null, "Jackie.Balistreri", null, null, "AQAAAAEAACcQAAAAEFFTqw6nrvXbYc4RrCr7mH8im3hvRa0Gw6oL1lGzxbhM9AOczm7XArJ6TsKxNdoZJg==", null, false, null, null, 0, false, null },
                    { new Guid("80c8c606-5918-4559-bdbb-606d564f96d5"), 0, new DateTime(1998, 9, 8, 13, 51, 15, 624, DateTimeKind.Local).AddTicks(8545), 513.5494168112330000m, "4088a178-b273-4a5b-b076-f111b011bde9", null, null, null, false, null, "Woodrow", "Hickle", false, null, "Woodrow.Hickle93", null, null, "AQAAAAEAACcQAAAAEPGFjuYJXzfRfwoJz0B47RVwHn28UMjxjBuH3JeGVwq9DJPjF2cw9RKquvWfugX3ug==", null, false, null, null, 0, false, null },
                    { new Guid("815c5bf5-7253-492e-81c8-82e2d6860602"), 0, new DateTime(1983, 4, 28, 2, 49, 44, 596, DateTimeKind.Local).AddTicks(5133), 272.3604182552950000m, "86ff438f-4c12-4ccb-bbd4-6914968df558", null, null, null, false, "Bryant", "Bryant", "Kuhlman", false, null, "Bryant.Kuhlman85", null, null, "AQAAAAEAACcQAAAAEAYBqcB1AvoHsI/omXxDXS7IKzeIbTUp7ie68S9OZOGffK6Y85+HUswY6cp2YQcvDA==", null, false, null, null, 2, false, null },
                    { new Guid("819538c4-628a-4b17-a719-8274b53093f3"), 0, null, 201.7264223886190000m, "a4c28d64-63ed-4d50-9b00-52b9072b63ed", null, null, null, false, null, "Ronnie", "Yost", false, null, "Ronnie.Yost", null, null, "AQAAAAEAACcQAAAAENsWldnJIHR84SkvIU6WDRL03b4y8X37YCKusrGolQXD+LEGAVHfXl4ZmV88/ViU7A==", null, false, null, null, 2, false, null },
                    { new Guid("82b99640-3f2e-425b-a088-51b3c226a192"), 0, new DateTime(1948, 9, 20, 15, 17, 19, 339, DateTimeKind.Local).AddTicks(8493), 494.1913525128180000m, "5aa299ae-4c2d-4d0d-8a4a-9f94366daf6f", null, null, null, false, "Helen", "Helen", "Kuvalis", false, null, "Helen77", null, null, "AQAAAAEAACcQAAAAEPIAuv0/0ja74lQWOtGeK1yooS1L1bs6Xh54YWZP5qGMdNyr2fecwZAP95GGbBnsYA==", null, false, null, null, 1, false, null },
                    { new Guid("82f7ffb4-bdb1-40a8-8d2d-67f1c2f5bf91"), 0, new DateTime(1942, 5, 15, 11, 26, 22, 254, DateTimeKind.Local).AddTicks(2803), 834.9379635401390000m, "a13e2dc9-2622-41aa-a5e1-02fb5df93e47", null, null, null, false, null, "Madeline", "Bauch", false, null, "Madeline58", null, null, "AQAAAAEAACcQAAAAEC8SHrfdoaByp1ChYtJEO2MGEReViS7iRJohlimHBQAk5FIPES7gyhv+idjONlf9Sg==", null, false, null, null, 1, false, null },
                    { new Guid("831f8f9d-e78d-4f72-8b48-1c32c42fda1b"), 0, new DateTime(1940, 8, 9, 7, 48, 43, 984, DateTimeKind.Local).AddTicks(2457), 840.0108633571680000m, "0a72c027-a168-4e3f-bc88-f9bbeba3b0f0", null, null, null, false, null, "Cecil", "Murazik", false, null, "Cecil.Murazik52", null, null, "AQAAAAEAACcQAAAAEG4suzJBqEMQ2sJWSRTF2mvqc9KC4GyvR7yJ/+Xkgovc1vd2+Y7o0cOC0Og5+OBolA==", null, false, null, null, 2, false, null },
                    { new Guid("871feb78-0a5f-4d88-8754-a386270f590d"), 0, new DateTime(1950, 6, 27, 13, 3, 30, 388, DateTimeKind.Local).AddTicks(3586), 552.9145279495290000m, "d58259f6-deeb-4f11-a36e-57c0a83b65a9", null, null, null, false, "Ana", "Ana", "Boehm", false, null, "Ana.Boehm39", null, null, "AQAAAAEAACcQAAAAECt+RUUpbfDA36FOsPaW5fW7G8xApH/79leeo6r3dopAyacq8CrSMrtgRAGsRBgVPQ==", null, false, null, null, 1, false, null },
                    { new Guid("8867eb2c-20d1-43a8-8081-18744798ef5a"), 0, new DateTime(1934, 7, 25, 12, 31, 29, 648, DateTimeKind.Local).AddTicks(717), 506.35286139910000m, "38599697-b698-44f5-ae43-3c0dce0e021c", null, null, null, false, null, "Pete", "Oberbrunner", false, null, "Pete.Oberbrunner30", null, null, "AQAAAAEAACcQAAAAEBA/1LVgQLolIHIQ8l7Kx3//oUD5uPC+PGGxSjN3Ud2fojAf8dVSHwRQSyElzH6DNA==", null, false, null, null, 1, false, null },
                    { new Guid("8a696f30-76c2-40db-a250-030829547d67"), 0, null, 691.4303028553430000m, "7f2f7123-4771-4cc2-aa21-9739e17441ce", null, null, null, false, "Kenny", "Kenny", "Reinger", false, null, "Kenny.Reinger75", null, null, "AQAAAAEAACcQAAAAEA0Wouekbu1GDBgmSWRupzp66I0p5KxOm8twfkd/kE2LmF+P9lKoGTSTRkdeXP3RiQ==", null, false, null, null, 0, false, null },
                    { new Guid("8b3afef3-3bbb-4237-b8b8-1eba1df7757e"), 0, null, 737.4109564485760000m, "272d4bdc-dced-4809-84f0-c81a580cad26", null, null, null, false, "Bryant", "Bryant", "Larson", false, null, "Bryant_Larson54", null, null, "AQAAAAEAACcQAAAAEEz8oQAQ6FXz7w4ZwcypT3mPbl7GNLu5Q3WcJSUjlTyE7Bn89lqPJq6OVIhOwxIoyA==", null, false, null, null, 1, false, null },
                    { new Guid("8be01b71-4060-43ad-98a5-2c0730fd003b"), 0, new DateTime(1997, 1, 11, 18, 23, 46, 38, DateTimeKind.Local).AddTicks(7157), 260.7701476360860000m, "8f93bee3-5cd4-4cfe-a831-4bcdf1aa1bb8", null, null, null, false, null, "Belinda", "Stanton", false, null, "Belinda.Stanton", null, null, "AQAAAAEAACcQAAAAEIxqp51PO103E+k00mEPdEyhYRTL0VulD7cF9SMwYdoYkO2KHhTDHYU+P4deJVEV2w==", null, false, null, null, 1, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "Email", "EmailConfirmed", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("8bfa284c-faeb-4fb6-909c-2a2ea4c8745b"), 0, new DateTime(1955, 3, 29, 17, 0, 41, 272, DateTimeKind.Local).AddTicks(4019), 528.8163183676130000m, "b30a3fdd-1932-452a-abb0-c3fd2a5dced1", null, null, null, false, null, "Ismael", "Littel", false, null, "Ismael.Littel", null, null, "AQAAAAEAACcQAAAAEE+dbiOSHbgMmD/MLLYljssA4hOzjNqmhrxICAmBjq2ZfskRISUjKbcaMOrslNXxMQ==", null, false, null, null, 1, false, null },
                    { new Guid("8c060e9b-2ea2-4602-8535-ce147e60fcbd"), 0, null, 86.83460233341930000m, "86ab9667-8228-472b-981f-31e70c1e5331", null, null, null, false, null, "Albert", "Bartell", false, null, "Albert_Bartell", null, null, "AQAAAAEAACcQAAAAEPzczv4tIDgFyd7yHvu/++oFUzFPXkrPr3dke935T/1fj/nwkZ8MK2vXtrO1CeyzHw==", null, false, null, null, 2, false, null },
                    { new Guid("8c18ec85-46f2-44b0-bd0b-56adb1bf7743"), 0, new DateTime(1958, 3, 27, 6, 12, 27, 700, DateTimeKind.Local).AddTicks(6419), 478.6130729691340000m, "b9991583-cde5-4331-b93d-5fea91f53ac3", null, null, null, false, null, "Chad", "Herman", false, null, "Chad98", null, null, "AQAAAAEAACcQAAAAEGpnd81S4tqVpEQFK/R3qOBuEX6zUArd6vnHThB9cuHjkWtxqf+SxBIOqkXZfqA8Sg==", null, false, null, null, 1, false, null },
                    { new Guid("8c30b7e6-1da3-4a5c-87ba-544b9377a290"), 0, new DateTime(1942, 9, 28, 21, 46, 37, 652, DateTimeKind.Local).AddTicks(7169), 328.7154215896560000m, "ea01dcc2-3a4c-4185-b939-ffc9a76a944e", null, null, null, false, "Shelley", "Shelley", "Murphy", false, null, "Shelley.Murphy53", null, null, "AQAAAAEAACcQAAAAEH88kIi8Sdptizl7hRocQ/TV3NF6JxnQZQsZu79tz7wU0AuWbXOYl8nhjGyIE3mMvg==", null, false, null, null, 2, false, null },
                    { new Guid("8ce72c63-9c31-4159-9ba2-012a4fc3df72"), 0, new DateTime(1973, 6, 13, 23, 31, 6, 579, DateTimeKind.Local).AddTicks(2886), 298.1623780152140000m, "02d3075d-b6db-4735-9d4d-791ede1f149b", null, null, null, false, "Wilbert", "Wilbert", "O'Keefe", false, null, "Wilbert_OKeefe68", null, null, "AQAAAAEAACcQAAAAEIvx7AaPLPdkK8n+UJd0FcWQE5Ha5HWaoaNbSngODSR/kDY9KJDsN59TyK2IBhtTng==", null, false, null, null, 1, false, null },
                    { new Guid("8dca8632-b27c-44ad-bd6c-0d7679a4f075"), 0, null, 102.0972222138260000m, "422f0695-5d57-4422-9eff-76c84989baa8", null, null, null, false, "Angie", "Angie", "Padberg", false, null, "Angie44", null, null, "AQAAAAEAACcQAAAAEEf7TKucX6cMS3P5k9adQxD2NNCBD90o+kq7oITxTYeC+WxAyDOpKNJRrabxAgibUQ==", null, false, null, null, 2, false, null },
                    { new Guid("8e3d5153-23be-45f9-83b4-5aecbb1a4322"), 0, null, 778.6726486656940000m, "d2bfa33b-924c-46b3-9ce8-7013b5cae4c1", null, null, null, false, null, "Van", "Rohan", false, null, "Van.Rohan", null, null, "AQAAAAEAACcQAAAAENvxPPQf+l9xa2pjq/wPblBKBNEqzAulICVth6VpPODTUw/kVN3bbuYTSCcWaMHZ1w==", null, false, null, null, 0, false, null },
                    { new Guid("8ea935b6-2c30-4bef-803c-9f382789979b"), 0, new DateTime(1943, 3, 13, 11, 35, 58, 428, DateTimeKind.Local).AddTicks(879), 160.8238014239010000m, "be918545-7c90-4bf2-bebe-c1a3475b7769", null, null, null, false, "Edwin", "Edwin", "Aufderhar", false, null, "Edwin62", null, null, "AQAAAAEAACcQAAAAENnT9VtfncV0cAgEmCBnOXZrVSoxcQdk1u4hQ654DGyBFO1FIZ4dagbR8AgwPIzyYQ==", null, false, null, null, 2, false, null },
                    { new Guid("8f35c799-d964-48e4-9cf8-befb4f9b7bf0"), 0, null, 352.8177966587420000m, "811b3917-618f-44fb-85bc-028e26461fe7", null, null, null, false, null, "Edmund", "Ratke", false, null, "Edmund.Ratke59", null, null, "AQAAAAEAACcQAAAAECdnFPQKxx2RlaaB4h6bMkjGnd1ComxDWwVrZ1hWaS0uKXd76+rk4hHMRq7gzS6azA==", null, false, null, null, 1, false, null },
                    { new Guid("8f876cca-154f-4381-adab-41c9e894d046"), 0, null, 953.6317466323590000m, "a2d3e9b1-fde6-437a-856f-4ea28f1365ad", null, null, null, false, null, "Jacqueline", "Wunsch", false, null, "Jacqueline91", null, null, "AQAAAAEAACcQAAAAEPi2zjOoFI2+Z0OSV9hoi/yxkeqOZbQFWnk7BTYSXNA0rlHGs7F32+ipoB4Slw7tmg==", null, false, null, null, 1, false, null },
                    { new Guid("8fc5f8c0-3711-4486-8ea0-48697b9ea01f"), 0, new DateTime(1954, 9, 18, 9, 54, 3, 198, DateTimeKind.Local).AddTicks(3416), 710.9028252185940000m, "34b98133-61a0-4b3d-b6eb-f36dc6e55f79", null, null, null, false, null, "Audrey", "Ruecker", false, null, "Audrey.Ruecker50", null, null, "AQAAAAEAACcQAAAAEEOyz8rCmI/dOKfflHe9+lpHQornXp3khYLs74AFEffpVuNmCKgBPqBhKQO8QMpSIw==", null, false, null, null, 2, false, null },
                    { new Guid("914e0b17-40ab-478d-ba2c-61856d240679"), 0, null, 933.03267691810000m, "847fa46f-5214-40bc-b63e-858557a5b219", null, null, null, false, "Herbert", "Herbert", "Robel", false, null, "Herbert.Robel", null, null, "AQAAAAEAACcQAAAAEEeTyj9bTVin+9QEpj0WwkhIiBoONk1RKZKIvD3yY/2vepY8EjGNDgr/lPHZR0Sg7A==", null, false, null, null, 1, false, null },
                    { new Guid("92a5d027-0cfb-43ec-84b3-d812837c5654"), 0, null, 450.6134516429760000m, "745acfa8-b7c6-442f-8522-a29ac6fb45f9", null, null, null, false, null, "Ginger", "Rau", false, null, "Ginger.Rau", null, null, "AQAAAAEAACcQAAAAEE/kca2kDz9bnU33VbE+/rzNbu2ExjQQJSV72bcYBzthkeJ3qy0W2HEXMMEYSS/uiQ==", null, false, null, null, 2, false, null },
                    { new Guid("92d6cbc1-d409-403c-b274-517d31726ae9"), 0, null, 724.2484831380390000m, "13ff1056-a6aa-444e-b1e6-fb18b7851a74", null, null, null, false, null, "Lester", "Hickle", false, null, "Lester.Hickle", null, null, "AQAAAAEAACcQAAAAEO0ufd0Eq5Vxov1qTHlQbXRmmcJU2q/5IwxxEtMS5snfBIcE7wUBeWRmYD3MbeykUA==", null, false, null, null, 2, false, null },
                    { new Guid("93e9e8fa-8b76-4968-a1ef-a4d59b6958ea"), 0, new DateTime(1977, 7, 13, 20, 33, 42, 648, DateTimeKind.Local).AddTicks(7619), 834.7994308031430000m, "a5adae31-0a12-4aad-96d6-3753153ef373", null, null, null, false, "Terence", "Terence", "Rice", false, null, "Terence_Rice", null, null, "AQAAAAEAACcQAAAAEE/5tOvMAVOQWsCENOnLJMd74lheqc1ksFrzy4hDfW+MiaRmg2T8NCwAwEK6qhpgLg==", null, false, null, null, 2, false, null },
                    { new Guid("94c09a0c-18a4-40c8-9285-032386267d16"), 0, null, 173.4496456784520000m, "8888b6f3-cc9d-4c84-9859-85503f6fe40b", null, null, null, false, "Eduardo", "Eduardo", "Jast", false, null, "Eduardo39", null, null, "AQAAAAEAACcQAAAAEDf3xxVLS9W/AcFopwWndzeNejyKSk0DNODMDKyz/+xx+jFr2mjR63csanEblxiN/Q==", null, false, null, null, 2, false, null },
                    { new Guid("97e11482-d5e6-41d7-82e3-80806df9c3bc"), 0, new DateTime(1989, 9, 23, 15, 16, 19, 323, DateTimeKind.Local).AddTicks(7139), 75.9995621546920000m, "d46d3302-a1fb-4a37-a328-bd09e84b6599", null, null, null, false, "Vickie", "Vickie", "Larson", false, null, "Vickie_Larson", null, null, "AQAAAAEAACcQAAAAENNMl6G4EuRInGH7bpu47FqFo2n+n7HLYoT8SGgzJSWV4ZG4Tf/f1I88yUrYOBa7YQ==", null, false, null, null, 1, false, null },
                    { new Guid("980189d0-dcc8-4676-93bf-39ec81288e2f"), 0, null, 413.8136381355410000m, "87ec32ac-545e-4a33-8e62-753dbaefa273", null, null, null, false, "Ellen", "Ellen", "Monahan", false, null, "Ellen.Monahan9", null, null, "AQAAAAEAACcQAAAAEB6HAykCMYuebtflyN4bHv3E7DHcW0N7B7MLrQN58fXVNLIFwqAgQR4MI75JxbfhXQ==", null, false, null, null, 2, false, null },
                    { new Guid("99d3bf2d-5ff0-41e8-b115-9bf94eab6881"), 0, null, 186.5008554662360000m, "9bf815c2-f6eb-4f03-bcb4-d09b6ff84139", null, null, null, false, null, "Teri", "Senger", false, null, "Teri86", null, null, "AQAAAAEAACcQAAAAEPViLvfnVPpr5+1LVWybnLkIt0psXKrTcava+YMU8PJJkLWcrEzd87U4IOBxgO/Nlg==", null, false, null, null, 2, false, null },
                    { new Guid("99d4724f-46db-42d2-a62b-3d8fa528e130"), 0, null, 414.2044338167830000m, "f58780a6-a157-4c12-a740-a94fe1e7b884", null, null, null, false, null, "Gabriel", "Connelly", false, null, "Gabriel.Connelly19", null, null, "AQAAAAEAACcQAAAAEE33orruItBIhszh17IjPz9hxEy4mdt7Zh/g+lbk63VF60dZBvPxcHbOcSWvMsoWWg==", null, false, null, null, 0, false, null },
                    { new Guid("9b254af5-9da3-4b42-a5f3-b573df408d84"), 0, null, 250.3869564865930000m, "89a2322d-6845-49eb-92f0-6dfce9ef9f70", null, null, null, false, null, "Stephanie", "Carroll", false, null, "Stephanie1", null, null, "AQAAAAEAACcQAAAAEAsDTns1oNLMPrPcttOCYhoGj77rXR/yyxupDxtrzmw9t/c4hIRA/5e3iVX9lgvAlQ==", null, false, null, null, 0, false, null },
                    { new Guid("9cf1e944-d004-426c-83ee-acb2b8793bc6"), 0, new DateTime(1957, 6, 25, 1, 11, 40, 914, DateTimeKind.Local).AddTicks(952), 255.5721352992180000m, "3c5bebe7-fb6c-4df2-972e-abdc3dea8530", null, null, null, false, null, "Hope", "Schumm", false, null, "Hope_Schumm72", null, null, "AQAAAAEAACcQAAAAENdD7lVuTLgisMmOMDkA7ttNrWWxG9KMz7oJrnU62yUP38fx9Dtx3WctARR7vwYubg==", null, false, null, null, 1, false, null },
                    { new Guid("9e39f449-ecbf-4238-8ca8-47309c134789"), 0, new DateTime(1965, 10, 10, 5, 53, 59, 711, DateTimeKind.Local).AddTicks(9142), 313.9510082258150000m, "bd569283-2ff0-40b0-970e-ea4c6f6d7702", null, null, null, false, "Lester", "Lester", "Gleason", false, null, "Lester.Gleason88", null, null, "AQAAAAEAACcQAAAAELn1/RdepECJkz5cmoaEOVzq4cYa5PjqCv9b+Z98UksnGqy2LPnPojcTO3l2vzi8Bg==", null, false, null, null, 2, false, null },
                    { new Guid("9e96d314-cd64-47aa-a5bc-7e0525cc9914"), 0, null, 208.2582754755240000m, "1d6603c4-bd5b-40e7-8e05-c9c73a9efdc3", null, null, null, false, null, "Cornelius", "Predovic", false, null, "Cornelius58", null, null, "AQAAAAEAACcQAAAAEIjWXuMQTqJcf94MYVLOHG6jS1MzDUbPZNRRiK9p4TDnPmPE4mVST001jamQvJnNUw==", null, false, null, null, 0, false, null },
                    { new Guid("9ec54876-333f-4825-9959-c839395cb66e"), 0, new DateTime(1928, 9, 1, 13, 6, 2, 544, DateTimeKind.Local).AddTicks(1782), 37.2714890213950000m, "b1005c91-770d-415c-a1c3-fa1c87af1fef", null, null, null, false, "Rickey", "Rickey", "Glover", false, null, "Rickey35", null, null, "AQAAAAEAACcQAAAAEPsCS/zIK7w9fiZfe6VtVefKk/OWN4Zb6vSH4wTQayYAIRr0jCBbYamLHPAcgYeSyw==", null, false, null, null, 2, false, null },
                    { new Guid("9ee8d8bd-022b-4718-b8f4-cc38174e988c"), 0, new DateTime(1966, 1, 15, 19, 56, 50, 268, DateTimeKind.Local).AddTicks(8275), 392.4035994443480000m, "954ee14b-3d30-47a5-bc8c-22ec81cc1acb", null, null, null, false, "Bryant", "Bryant", "Will", false, null, "Bryant_Will52", null, null, "AQAAAAEAACcQAAAAEA6iql4yeMKuHlfB5toY8QeeUZ0WS4NzV5MQZ/hVai7RUc20kCKd8sbw7euVW35LcQ==", null, false, null, null, 0, false, null },
                    { new Guid("9ff0a0ca-02d0-4209-bb8f-a0d7efaf75bb"), 0, null, 387.0212870123430000m, "be50c5e1-bd0b-4dcc-897e-4a267f1dec4c", null, null, null, false, null, "Gregg", "Sporer", false, null, "Gregg80", null, null, "AQAAAAEAACcQAAAAEAVkgzU8xr7jv8Ix5jhbeID/wkoflFvWa/ja+5ehJRaVPo2S9VZyNFQG7ZuKgXNv4Q==", null, false, null, null, 2, false, null },
                    { new Guid("a03e50af-2ee0-4392-86e9-a0420b2f24bb"), 0, new DateTime(1945, 3, 10, 3, 1, 30, 363, DateTimeKind.Local).AddTicks(913), 482.387919991140000m, "b58ced9b-0a1f-4161-b696-00bfef1dd9d7", null, null, null, false, "Chad", "Chad", "McCullough", false, null, "Chad.McCullough55", null, null, "AQAAAAEAACcQAAAAEL4m9+4Npym+ah1en8NHMLJLUDMSvqynJR397z5TQJR42RSS1wqyjDE8XQNiSJc+mg==", null, false, null, null, 1, false, null },
                    { new Guid("a2c81266-ca25-4e08-bddc-c6ccfe9435e2"), 0, null, 463.7854062102910000m, "7e8034e3-9b00-4da8-a072-a4695fcd5d17", null, null, null, false, null, "Jonathon", "Bins", false, null, "Jonathon_Bins", null, null, "AQAAAAEAACcQAAAAEIUEpn9q4mxVOicn1GeCyDxzFoF25fh0b90W2t1RjN5zYsS+w2iWeexw1ENG6tlKSA==", null, false, null, null, 2, false, null },
                    { new Guid("a419df27-9358-4a02-9ab7-2f2e2344fae0"), 0, null, 254.2678176629210000m, "567e8252-8d24-420a-980e-cdf531f0e3d0", null, null, null, false, null, "Debbie", "Hoppe", false, null, "Debbie_Hoppe", null, null, "AQAAAAEAACcQAAAAEAGFKv/PzRpB3jQ4ssK/lB8fPZd0i0R4MDx8h5vq0Crylaz1Xyrxp5hw0aof7GV8ow==", null, false, null, null, 1, false, null },
                    { new Guid("a5276d46-3296-4c05-ba31-d2ebddfd8a57"), 0, new DateTime(1971, 8, 11, 7, 27, 17, 624, DateTimeKind.Local).AddTicks(6071), 880.6560532013990000m, "6612bac0-3c2e-4ce1-a848-a621f521fdd9", null, null, null, false, null, "Drew", "Johnston", false, null, "Drew38", null, null, "AQAAAAEAACcQAAAAEOJcg8A0gNBqPMXICOO7Pj89Xdy6X1oB91bvVZXqC3pKKr6aLtAcpbbbf55i0ZFDqA==", null, false, null, null, 0, false, null },
                    { new Guid("a59d873d-ae08-427c-b25e-29c55895239f"), 0, null, 425.9361146522650000m, "69804b48-276d-4c4e-9c4b-3f2481af9cdd", null, null, null, false, null, "Michele", "Hermiston", false, null, "Michele.Hermiston", null, null, "AQAAAAEAACcQAAAAEEOfNFeg2v2i9aCspCN0cbnWhCg8aF9F7WLKU23eROS2PHw1srK233999tzx52wU7A==", null, false, null, null, 1, false, null },
                    { new Guid("a6a8eca4-cb2e-43f7-9ea2-cbc644c8f9d8"), 0, null, 954.0510188017680000m, "918fb1ba-5df2-48c9-9d88-9792582fce26", null, null, null, false, "Toni", "Toni", "Miller", false, null, "Toni87", null, null, "AQAAAAEAACcQAAAAEDv9CJlerHj0fj/HPrLwsygxlemw2FH+XbyTqLlA4OZjFmeG5hL54k0Jo3XK7MqxoQ==", null, false, null, null, 2, false, null },
                    { new Guid("a780acfd-e10d-4dc5-a383-1ba56a91e666"), 0, null, 682.3120655731460000m, "8707d130-c461-45d2-a690-0a0bc34edf81", null, null, null, false, "Clay", "Clay", "Lockman", false, null, "Clay82", null, null, "AQAAAAEAACcQAAAAEGX28L954ZFumUGZW8biyEtmuvJ1VJa60pNwLzH3ARu9bbnuqmL6VM04mnbZAnN+qA==", null, false, null, null, 1, false, null },
                    { new Guid("a9090dd7-3795-48e2-837b-9a72a0274d7b"), 0, null, 458.4214970529810000m, "b0592fa4-475e-479d-b292-7ba4136a31d1", null, null, null, false, "Brett", "Brett", "Muller", false, null, "Brett.Muller44", null, null, "AQAAAAEAACcQAAAAEE6bgK+oLFXLVsrVGdVLhgHNKCEsdDZCuiuufGtRDQ7FauJI0pt1aWhWAiXd7TK9oA==", null, false, null, null, 0, false, null },
                    { new Guid("a943e809-55d9-482f-a592-8709b5f7d47f"), 0, null, 730.4664496988140000m, "34b9c26c-109a-4e53-9f41-3d2788e6c1db", null, null, null, false, "Kari", "Kari", "Kuphal", false, null, "Kari18", null, null, "AQAAAAEAACcQAAAAEI6ReK2i/PvxNr9iOkzuym8ZG2MsBQDw34joS+nI7JxKmLsJ8NQLAPuixcv45GIOxQ==", null, false, null, null, 1, false, null },
                    { new Guid("ab451099-7866-44e4-9ebd-f1162ea6206a"), 0, null, 512.5761976247080000m, "36a30871-86ab-4007-b0f7-a389d4ee3966", null, null, null, false, "Cory", "Cory", "Jacobi", false, null, "Cory8", null, null, "AQAAAAEAACcQAAAAEH71WqjdSpJDgQt4KW2OTSRfpga/czNGYOXPBm/5PkuWmcBcft9pSYhp4QNkSZ2XWQ==", null, false, null, null, 0, false, null },
                    { new Guid("ac4ee7ff-56c7-4c45-ba3e-32ed6d9370f3"), 0, null, 541.5119727920240000m, "a26882d9-82fd-47af-813a-00c275701e8d", null, null, null, false, null, "Laurence", "Schinner", false, null, "Laurence88", null, null, "AQAAAAEAACcQAAAAEOZBE8cguYJoEM4JhrAuJhGpsyZVVc/68pU6eSSOA4ULhCJP339BlRxTrUyGlMshag==", null, false, null, null, 0, false, null },
                    { new Guid("ac5a7dc0-9da2-4c23-9acc-ec9828404cd5"), 0, new DateTime(1936, 9, 7, 10, 22, 56, 119, DateTimeKind.Local).AddTicks(9074), 252.0423234530050000m, "d8e6aa9b-f055-4fc2-a581-77720095000b", null, null, null, false, "Doyle", "Doyle", "Bode", false, null, "Doyle_Bode93", null, null, "AQAAAAEAACcQAAAAEL+cUjkfzJr+uxBdtAzZQT8Ns3+rziGK14wWRrEJq5QwirHPD0yI1Y6TOIp4He6PKA==", null, false, null, null, 2, false, null },
                    { new Guid("ac984856-387b-48de-9d39-5cfa956d354e"), 0, new DateTime(1936, 5, 15, 23, 29, 24, 893, DateTimeKind.Local).AddTicks(3474), 375.8597069574260000m, "2d447467-b92f-4c75-ae23-4c7f71250dfc", null, null, null, false, null, "Rosie", "Ledner", false, null, "Rosie.Ledner", null, null, "AQAAAAEAACcQAAAAEBDTZI+j5Q9VC/brx6yjVJDMUFNP4vdX4iTiXM7uRYT98fLIYZSgo1xM1TEhHu1mzQ==", null, false, null, null, 0, false, null },
                    { new Guid("adbbd240-641f-475b-b705-5e35298ef012"), 0, null, 263.00159033990000m, "a8ea0b6e-a908-4347-8934-f99aefb7da97", null, null, null, false, "Rogelio", "Rogelio", "Lang", false, null, "Rogelio9", null, null, "AQAAAAEAACcQAAAAEC2or6Ddm+PxX0b0DskGY17SRtEhCdHRWzXn0FWPKrdNG18sHL1PrxQoP7QwfHqXZA==", null, false, null, null, 2, false, null },
                    { new Guid("aeae0f68-579f-46b8-bee2-c797ee09ee5e"), 0, new DateTime(1931, 5, 29, 2, 28, 7, 130, DateTimeKind.Local).AddTicks(591), 120.0442221129670000m, "ad6502eb-087d-4cfa-aaf9-2bf513a6628e", null, null, null, false, "Leroy", "Leroy", "Kovacek", false, null, "Leroy11", null, null, "AQAAAAEAACcQAAAAENxC4s6fno1dGjHVrW7dftVCdTAzUHaPQA+q2wTBcDoAnMiZ8qPuHEO9eVhqI/brQg==", null, false, null, null, 0, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "Email", "EmailConfirmed", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("aec475ab-9ab8-4f55-8794-ee1ffc6f6da6"), 0, null, 328.9743728399770000m, "7944713a-3d24-4891-aa78-df144c510e5e", null, null, null, false, "Jesse", "Jesse", "Haley", false, null, "Jesse.Haley", null, null, "AQAAAAEAACcQAAAAEE7BfspWE/cqbYBrxPbR9bnbExVxCKreiFfb1113PjMWtmmkG1lOGDGHCd1tV09mFA==", null, false, null, null, 2, false, null },
                    { new Guid("affd1717-742a-4014-8e72-3420c7496c1e"), 0, new DateTime(1986, 8, 2, 18, 59, 2, 289, DateTimeKind.Local).AddTicks(3316), 950.7848228587880000m, "7e57ec8a-2d03-4d33-b553-479bc1bb0d19", null, null, null, false, null, "Shane", "Rath", false, null, "Shane.Rath", null, null, "AQAAAAEAACcQAAAAEC8uJYpLdh41Xs0qJLHdV6w9MsfQepUoakC9ilHPqNFKGVrWP/l2/gR4FpvZyOfnxQ==", null, false, null, null, 1, false, null },
                    { new Guid("b1817475-7a6c-44d8-8e81-4b59b1f4923e"), 0, null, 827.7725494613760000m, "b14d55c6-7f03-4b2f-997b-474b09bfe737", null, null, null, false, null, "Michelle", "Gusikowski", false, null, "Michelle97", null, null, "AQAAAAEAACcQAAAAELX27mt4r11k/Ui7j/sFm4cfWL2MzcZrqgHhq/QAQh53rHWlLt6fzVM0s1NoQYIX7w==", null, false, null, null, 1, false, null },
                    { new Guid("b21ce16f-bf5c-4cfa-9fd4-9b67014eadbb"), 0, null, 223.9434046543040000m, "3dc8f569-f28e-4e99-9b42-a1fd60bbabc0", null, null, null, false, null, "Sheldon", "Ziemann", false, null, "Sheldon_Ziemann10", null, null, "AQAAAAEAACcQAAAAEI6RU9EaPT61AM5yfNvbavcLNmp3NdAP62vdRhzgF/4EuixHwyGhODT9WhmyX3uZ4A==", null, false, null, null, 0, false, null },
                    { new Guid("b40d8226-58de-4e86-811d-0e6b38686d57"), 0, new DateTime(1941, 3, 24, 0, 48, 50, 371, DateTimeKind.Local).AddTicks(9368), 106.8083254473650000m, "36391281-5874-4966-857b-cb41fe0713a2", null, null, null, false, null, "Lela", "Koelpin", false, null, "Lela_Koelpin", null, null, "AQAAAAEAACcQAAAAECWssvetFq06YAKUXJRv7h4CxiCoNAHoqZoLS5Z4684r29tXvIeLQB5XryfFxZyVUw==", null, false, null, null, 2, false, null },
                    { new Guid("b53497b3-fabe-4282-a5c6-ef6e82864309"), 0, null, 754.1805422962390000m, "395c92af-b46e-410d-9d04-0578d21a62b3", null, null, null, false, null, "Rosemarie", "Rogahn", false, null, "Rosemarie.Rogahn", null, null, "AQAAAAEAACcQAAAAEAoEatz+Ow4G33ZNtO800UP/M4mZwz7g3+U1ubp6RWomihxjPMrh7kxVW9oT54LbdA==", null, false, null, null, 1, false, null },
                    { new Guid("b5cca55a-d81f-47be-b0b4-50d07e79ce69"), 0, null, 513.9133430700710000m, "e5bd0a5a-cb55-495a-bb4e-4d6668362360", null, null, null, false, "Cory", "Cory", "Waters", false, null, "Cory30", null, null, "AQAAAAEAACcQAAAAEE6H3Ekl0lhvDcfp2v14tSFBQkz+V5Ao8FvryMIl3t58w6pcgcAl2P9XLQLqj7Fehw==", null, false, null, null, 1, false, null },
                    { new Guid("b8e5286e-6ec4-4001-89c4-e17065f9bf09"), 0, new DateTime(2007, 5, 15, 10, 10, 46, 862, DateTimeKind.Local).AddTicks(2323), 86.82854114006730000m, "eddfbd84-a77e-4d5d-b820-34e94ea80a35", null, null, null, false, null, "Felicia", "Prohaska", false, null, "Felicia.Prohaska61", null, null, "AQAAAAEAACcQAAAAEF6w7xElpUKhU46RtakrP+skkHwVKTkJGSi7+5VqPVMZ2HxY31hMpOBj9WjCUcGnRA==", null, false, null, null, 2, false, null },
                    { new Guid("bbaf9fe2-9863-4589-964a-23c62e6bf830"), 0, null, 511.2295627902130000m, "77d5559f-ced9-4413-b4ac-fabc6da640ea", null, null, null, false, "Lucas", "Lucas", "Kemmer", false, null, "Lucas_Kemmer", null, null, "AQAAAAEAACcQAAAAEM5rmBkllDQbpcHsx48WUDAGIbS3MKDYqC10asllGpCly6kUjyPeT5pZM4ud8mgmMQ==", null, false, null, null, 0, false, null },
                    { new Guid("bbe91897-98e6-4c1e-aef5-09cd3dbb35cd"), 0, null, 507.5872388644780000m, "28e7842c-5a31-413a-a996-3c8c601a5dec", null, null, null, false, null, "Kenneth", "Lindgren", false, null, "Kenneth.Lindgren73", null, null, "AQAAAAEAACcQAAAAEBGWfu8ayZRM8IKzndbrva9M99Ug20dxRXd0nmjVV0Hpaoz2FJy6QZmGRvDIhQsLLg==", null, false, null, null, 0, false, null },
                    { new Guid("bc7c70fa-9300-4c06-afd7-8aa97fcf9993"), 0, null, 669.9650614711850000m, "07f8c482-485a-42e8-b660-2068d408f5b4", null, null, null, false, "Julia", "Julia", "Lockman", false, null, "Julia56", null, null, "AQAAAAEAACcQAAAAEAqpHiP9Web/NyG/t/TH9G31ky1buUW2G0j+KfmnRbkE/AEyfzcSpH3lFQSF9rx/jg==", null, false, null, null, 2, false, null },
                    { new Guid("bd07490e-79db-4063-b992-0fa27e7f7677"), 0, new DateTime(1973, 1, 31, 6, 2, 38, 476, DateTimeKind.Local).AddTicks(4090), 105.0712370015450000m, "bd04a097-39ea-42bb-aae6-49c3ecd5331d", null, null, null, false, null, "Wm", "Friesen", false, null, "Wm_Friesen28", null, null, "AQAAAAEAACcQAAAAEHIprqRWB87F+f30G+iyiGGIk4/pHbeGmPJ3jNyNR6v8QBeKoAMPiFwygD3YIUTT3A==", null, false, null, null, 2, false, null },
                    { new Guid("bd349cb3-f696-4e78-9355-45b8b4f7385f"), 0, new DateTime(1978, 10, 1, 14, 55, 7, 454, DateTimeKind.Local).AddTicks(6918), 229.0305822306290000m, "bcae2697-91b9-443b-be3e-99f44ef836fb", null, null, null, false, "Vanessa", "Vanessa", "Jerde", false, null, "Vanessa.Jerde27", null, null, "AQAAAAEAACcQAAAAEPJ+OKZE2DhT9pndRlid3LGrmamw6GNSbAKceM42vxwZOIuxhQo54eYUvKPGVfyRhg==", null, false, null, null, 0, false, null },
                    { new Guid("be0a8a82-f1fd-45d5-8523-5b32db6fc767"), 0, null, 924.6875906547360000m, "f8a75dd7-1cc1-4122-afeb-a54824f01625", null, null, null, false, "Bernadette", "Bernadette", "Spinka", false, null, "Bernadette.Spinka72", null, null, "AQAAAAEAACcQAAAAEBaP/wNNinNlDvQ9L/KrpSrmm1enkAsQQhXf27h3qKvVZeo4YFdGi9w8x12v1T7nOA==", null, false, null, null, 0, false, null },
                    { new Guid("c0ff772c-b38f-4860-9c1e-4c49d424f9a5"), 0, new DateTime(1954, 4, 16, 13, 58, 14, 385, DateTimeKind.Local).AddTicks(5826), 971.6185179449160000m, "05a3ac55-84a0-4042-9c97-0f55854fe0a4", null, null, null, false, null, "Rudy", "Herzog", false, null, "Rudy.Herzog", null, null, "AQAAAAEAACcQAAAAEFyKalzfcAZei64jaYJ1ugJaLjWf8hQiPgBHLeto0DvIjzGjb7Nkvj+3ouP/gERh1Q==", null, false, null, null, 0, false, null },
                    { new Guid("c221f46b-a606-417e-aead-c8b255d84d11"), 0, new DateTime(1973, 12, 27, 4, 1, 45, 303, DateTimeKind.Local).AddTicks(3018), 441.7566241416610000m, "e77706c9-a34a-4279-9ddf-c1c6abc29ed6", null, null, null, false, "Camille", "Camille", "Schiller", false, null, "Camille.Schiller", null, null, "AQAAAAEAACcQAAAAEDMQUCtTxdtc532O0blhl+HSqi0ttIjOunu0vUPg8T2A2z4BsTJ1nLiQiCAK/1YvQw==", null, false, null, null, 0, false, null },
                    { new Guid("c2701daa-7747-422a-bb74-d9ffc8e0f5fc"), 0, new DateTime(1950, 7, 29, 5, 31, 43, 768, DateTimeKind.Local).AddTicks(9537), 475.7602826190170000m, "6851d81b-db87-440b-8746-bb2155a4032b", null, null, null, false, "Josephine", "Josephine", "Von", false, null, "Josephine_Von41", null, null, "AQAAAAEAACcQAAAAEBW3cv6HOaLG5MGKZreFBXF6j4W2UXTCufviotgH7zTLJc5T7JJX0DHTIDCxiOau8Q==", null, false, null, null, 1, false, null },
                    { new Guid("c36bd526-4a45-4a4b-9d0e-50c279e9b939"), 0, null, 564.6382291267050000m, "0de5815d-793c-4cab-bbec-dd313ccd9c48", null, null, null, false, "Elbert", "Elbert", "Lang", false, null, "Elbert_Lang", null, null, "AQAAAAEAACcQAAAAEMi1SwtpH/wpGtrfCjUUcP0R8wAw1RuX7PxjZUOHY+5h3RuyXaRCm+Jiv9zUVxJP/g==", null, false, null, null, 1, false, null },
                    { new Guid("c3cc5785-6364-48fa-bb83-e7ac33fc672b"), 0, new DateTime(1951, 1, 21, 2, 12, 39, 992, DateTimeKind.Local).AddTicks(2288), 406.0324919896080000m, "3bb7cd47-b790-45d9-aaa5-fe53fdb1917b", null, null, null, false, "Jana", "Jana", "Nicolas", false, null, "Jana.Nicolas17", null, null, "AQAAAAEAACcQAAAAENRmQxkJtnE2Gm0dxjgQo++C6xj3eue34z/442JUzfKsZ2q9n9sUlp6PLyYBcvW2xg==", null, false, null, null, 0, false, null },
                    { new Guid("c40f9fee-6298-4137-bc78-c74409dec92f"), 0, new DateTime(2007, 10, 27, 9, 37, 48, 449, DateTimeKind.Local).AddTicks(7399), 945.2520864927480000m, "67a09ca8-8fef-4ddb-b458-14a0a82fdb73", null, null, null, false, null, "Lester", "Kemmer", false, null, "Lester98", null, null, "AQAAAAEAACcQAAAAEGXX12VKbOa9PuXVgFreLA+ekcni8RX0dB3hmmpsXTE2JruGg2n4hDsPJb5eTcZw9Q==", null, false, null, null, 2, false, null },
                    { new Guid("c5513371-ea13-4b3b-ab65-8bbb471b2afc"), 0, new DateTime(2004, 6, 2, 20, 19, 16, 881, DateTimeKind.Local).AddTicks(6080), 821.8640101821650000m, "f9b3017d-758d-4d1a-adf4-c838d8806cf4", null, null, null, false, null, "Jared", "Baumbach", false, null, "Jared32", null, null, "AQAAAAEAACcQAAAAEICK/Pj0yhz82Qdk+dUCRNDAJYqtcglINgnrGNPWvqzzZMtdlDbnKam7eIxUphh0Fg==", null, false, null, null, 2, false, null },
                    { new Guid("c58f524e-a96e-4e8b-9186-6c21d38d64b3"), 0, new DateTime(1955, 8, 16, 18, 9, 1, 362, DateTimeKind.Local).AddTicks(118), 588.0509517973930000m, "80092f6e-8ec3-41d9-9491-570ff9f8cf07", null, null, null, false, "Betsy", "Betsy", "Torp", false, null, "Betsy_Torp10", null, null, "AQAAAAEAACcQAAAAEGESJt3lsdkeHWE2vQaxUrMP9QR2b8HPISauKcOA0lsZ2rLIrP/ZrPWMh+4QgTSnPQ==", null, false, null, null, 0, false, null },
                    { new Guid("c590f92c-3ca1-4a33-a976-926995a0f7cc"), 0, new DateTime(1959, 7, 3, 16, 29, 28, 182, DateTimeKind.Local).AddTicks(340), 431.4846078223210000m, "ef1b8d36-813b-4a8c-a53f-ee7bf28d2b55", null, null, null, false, "Shelley", "Shelley", "Nader", false, null, "Shelley91", null, null, "AQAAAAEAACcQAAAAEAMHV2BZUAJD6cXSvWI3sYKU9RrPeAXvCNEoAPmYciT6BaTLXsKXHRdbiMVCE2DAEQ==", null, false, null, null, 2, false, null },
                    { new Guid("c5efb9ab-d786-43d2-9595-c90aedaedb9b"), 0, new DateTime(2001, 12, 13, 21, 18, 17, 133, DateTimeKind.Local).AddTicks(7787), 703.7724870171020000m, "d9fe3570-3fce-4125-912e-e3aa6c5183ff", null, null, null, false, "Stanley", "Stanley", "Grant", false, null, "Stanley.Grant81", null, null, "AQAAAAEAACcQAAAAEOjKsw7UM3luEn4ioNZol8PG+GHtMhL13z73L5Z+YyQJXsVBgE5FttrAFwn57QGWBw==", null, false, null, null, 1, false, null },
                    { new Guid("c66d96b2-e569-4470-a3b9-82ba83e46c97"), 0, null, 266.9771131480890000m, "84d406ff-cb67-45ee-8dea-7731ecb631b1", null, null, null, false, "Brent", "Brent", "Bernier", false, null, "Brent_Bernier90", null, null, "AQAAAAEAACcQAAAAEFCiRnZEacIa9W7NCSyyof2sS74ZKDEUiwHxbO3EiBW2ihfmTyhVilzFRAKDrj7bhQ==", null, false, null, null, 0, false, null },
                    { new Guid("c6e8a5d8-6660-4e85-9ff9-1e6ec6d0c580"), 0, null, 740.4377603349490000m, "89b993ca-a7d4-497c-8fa4-b5549ddb63bc", null, null, null, false, "Alan", "Alan", "Marquardt", false, null, "Alan_Marquardt38", null, null, "AQAAAAEAACcQAAAAEMo2X4VThWh4j5AjZoMAsok8H6iOBfaoschGioEP17yl86+39hXgUgLeKXoqpEFDCA==", null, false, null, null, 2, false, null },
                    { new Guid("c7c0cd55-07d8-41cc-9d2b-4bd04cb7edb3"), 0, null, 54.46284320785780000m, "647d650c-e2a8-4975-a8ac-1e1d7cb6a491", null, null, null, false, null, "Alfred", "Casper", false, null, "Alfred_Casper", null, null, "AQAAAAEAACcQAAAAEIjR6kea2hU3dZ4F8JIqiqNMkTOQhTkNvriFOnM+2ofpJ/sgpWrpLDtcGUGqnfD7uw==", null, false, null, null, 2, false, null },
                    { new Guid("c7f42761-e210-47b4-9e39-2df36dce4c96"), 0, new DateTime(1984, 1, 21, 3, 7, 16, 883, DateTimeKind.Local).AddTicks(5120), 4.880485126059540000m, "93612906-8067-432c-b09d-bc1924b1f80f", null, null, null, false, null, "Tony", "Abernathy", false, null, "Tony57", null, null, "AQAAAAEAACcQAAAAELoRs4SqfaadmAQW+NeLsDnARaKa5+3gQ2LnMdNAPK8FVHEjqaByewrIcrwp3KBKMQ==", null, false, null, null, 1, false, null },
                    { new Guid("c88c725e-8cbf-416d-a4bf-153a024ea6c9"), 0, new DateTime(1926, 1, 7, 5, 52, 48, 384, DateTimeKind.Local).AddTicks(1449), 136.5404230561890000m, "8c104f4d-5dd1-4c94-ad15-32cc6a77b1c2", null, null, null, false, null, "Marcus", "Schultz", false, null, "Marcus44", null, null, "AQAAAAEAACcQAAAAEIi7CKtGWwUCUyz8ecquI2Rt0lfUuHJc+nvKhCO2GhCqdLWCC1WIDZwFmcSM+0tK4w==", null, false, null, null, 0, false, null },
                    { new Guid("ca127dc1-765b-47e8-87ee-ebc90ec70a73"), 0, null, 913.971818854150000m, "4e53cfab-64d1-459e-a226-df552d7d156f", null, null, null, false, null, "Sheri", "Price", false, null, "Sheri_Price", null, null, "AQAAAAEAACcQAAAAEH/HToI24v9WZT+nxm5hDWCzruUVn4SBeFXEGRiNy8M2lRwFxHFQKGRohi41nNGciQ==", null, false, null, null, 0, false, null },
                    { new Guid("ce7719fc-1874-4df0-88ba-9b5637945029"), 0, new DateTime(1982, 10, 18, 23, 52, 38, 786, DateTimeKind.Local).AddTicks(445), 207.8545938379180000m, "ff2845ff-ef15-402e-a43d-be2f5204f3b8", null, null, null, false, null, "Pedro", "Kuvalis", false, null, "Pedro.Kuvalis55", null, null, "AQAAAAEAACcQAAAAEFf0VL9cW9M9hDbuMZhGr4LWWMlst9ZIL+QK7n7w766KUTYj04po08LMtL4+7kNrgw==", null, false, null, null, 2, false, null },
                    { new Guid("cf3285c8-97d7-426d-87f3-e0854194e226"), 0, null, 111.9732342614560000m, "dd65f111-440e-42f3-ac29-b473d5a9976a", null, null, null, false, null, "Jenna", "Abshire", false, null, "Jenna_Abshire", null, null, "AQAAAAEAACcQAAAAEEgBZw4QaJw040ZCReXOlGWPDC+7hDaOkjUyCQdT6KWE/lRH4JsX0A9tt30Tr7h/vQ==", null, false, null, null, 0, false, null },
                    { new Guid("cf348fa5-7d32-48ec-957c-eb481beb0358"), 0, null, 695.9229823744270000m, "6aebbe4f-8dfa-4a58-ade5-8d7895c90ecc", null, null, null, false, null, "Sherman", "Klein", false, null, "Sherman33", null, null, "AQAAAAEAACcQAAAAEFmPh15aAQa1fJcER26MZgawGkKry+MRmRI11PMddL4QvMRRmDmDea8zldl36J9ltQ==", null, false, null, null, 2, false, null },
                    { new Guid("cf611bf3-21fb-4ed7-a138-00c7afdda9ba"), 0, new DateTime(2001, 8, 13, 7, 0, 33, 712, DateTimeKind.Local).AddTicks(7804), 670.492393195980000m, "7c009836-5a03-4ecc-9e93-f55ccff8bd63", null, null, null, false, null, "Barry", "Trantow", false, null, "Barry_Trantow16", null, null, "AQAAAAEAACcQAAAAECcD3+QHIJYldwz4bdoUutGuxyMGSegUvqRXIPhDG9k05zERsoV8OofTkahrNt81Nw==", null, false, null, null, 2, false, null },
                    { new Guid("d0aae9a2-8c5b-48e9-b856-e309c80cadae"), 0, new DateTime(2007, 6, 22, 3, 21, 0, 543, DateTimeKind.Local).AddTicks(7511), 353.3728591340120000m, "f53e9223-8268-4d12-bbce-06b14ad0d72a", null, null, null, false, "Abel", "Abel", "Wolff", false, null, "Abel_Wolff", null, null, "AQAAAAEAACcQAAAAEHN7HjBUh/8WqTVQwC/1EPHVq0v81WXX+XJIWXvqM0+Y2Uz9jBUoE2O+Z+/gsNHyqg==", null, false, null, null, 0, false, null },
                    { new Guid("d1d503de-e688-46df-9a53-6ca07b1d716f"), 0, null, 113.6708528365310000m, "a7a6c8f8-6e34-48b2-9507-fc8304eb2d8b", null, null, null, false, "Cynthia", "Cynthia", "Feeney", false, null, "Cynthia61", null, null, "AQAAAAEAACcQAAAAEGM0Zehv5njwxxwax3qmo8FMg70XqKg2ddvGYY6VrcxvlD2piI3ChmZcqvFSC7xOuQ==", null, false, null, null, 2, false, null },
                    { new Guid("d29932a8-80f8-42b1-85e0-6bf810161455"), 0, null, 888.011020086090000m, "0ac0b427-7d78-4662-b4f8-e0af6aa67420", null, null, null, false, null, "Kyle", "Langosh", false, null, "Kyle_Langosh", null, null, "AQAAAAEAACcQAAAAENfQEJWzp3mSo636bB829oVFaLQNYIjIiFO7jYmni1LDj4ge0aTyhId0QY1OGUqm8Q==", null, false, null, null, 1, false, null },
                    { new Guid("d3cba19c-d75f-49cd-8bce-3e5563428a3a"), 0, null, 808.1708831008930000m, "8079ed71-5c1b-4ad8-b86e-57b1e2023dc5", null, null, null, false, null, "Malcolm", "Jacobs", false, null, "Malcolm_Jacobs", null, null, "AQAAAAEAACcQAAAAEBxwG1LCOlisRFcbfufGJ4cIcNYZvE4fdbVbWYWy0g0TL42xXYypMJA/uTzspjszAQ==", null, false, null, null, 0, false, null },
                    { new Guid("d40492c4-d582-4ce6-943c-a487675b7960"), 0, new DateTime(1993, 6, 19, 12, 21, 28, 16, DateTimeKind.Local).AddTicks(2265), 38.12775182676810000m, "4c3975ca-03ca-4d22-81ab-9bc6f1671329", null, null, null, false, null, "Jared", "Okuneva", false, null, "Jared_Okuneva", null, null, "AQAAAAEAACcQAAAAEOMBUpTBjgcO+eSnBaav5uBqkd4EjOzdlzb/rpkLux19nTgL6cypn4o8ZdBf1jFiNQ==", null, false, null, null, 1, false, null },
                    { new Guid("d43ee797-d0bc-4a3e-8833-c45e9d340f44"), 0, null, 552.8398041680210000m, "3ba5649a-53ad-4b9e-a021-b88deecfebf8", null, null, null, false, "Randolph", "Randolph", "Wyman", false, null, "Randolph56", null, null, "AQAAAAEAACcQAAAAEMRQ5sLyygpoT708paE7pcwxbc50bvasvFYN74Yc2mYxvmNTEdmxRhmlQC40m+kdTA==", null, false, null, null, 0, false, null },
                    { new Guid("d57e07f1-63a6-4514-ae7a-51f83c901e2c"), 0, null, 188.340562773750000m, "25e9385b-d6ce-4f46-af62-74d28f2bd818", null, null, null, false, "Kevin", "Kevin", "Pacocha", false, null, "Kevin69", null, null, "AQAAAAEAACcQAAAAEI82XPLvWbFHV9nccDQaEpudhCO5HP/k2Ntdd5udhBbODTcpfSR6//lAt0eXcyzryA==", null, false, null, null, 2, false, null },
                    { new Guid("db32027d-cf9c-4544-af7d-d20c917925c7"), 0, new DateTime(1999, 11, 11, 16, 47, 38, 419, DateTimeKind.Local).AddTicks(1330), 421.5725454930210000m, "2e9f8824-ac98-4627-95da-fdee844966c2", null, null, null, false, "Lindsey", "Lindsey", "Lesch", false, null, "Lindsey.Lesch35", null, null, "AQAAAAEAACcQAAAAEJ6SpwC90aizw4031jAH/g9Kk17zm+KaD343h4cQrMw+zn1wliNZK2XQVOAAlZfh1A==", null, false, null, null, 1, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "Email", "EmailConfirmed", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("db91ddfb-75b6-4d51-82ea-52631a102b16"), 0, new DateTime(2001, 7, 8, 17, 45, 27, 784, DateTimeKind.Local).AddTicks(5954), 757.2297734256110000m, "18182a63-816f-4ca5-ab49-a590af833aca", null, null, null, false, "Penny", "Penny", "Koss", false, null, "Penny16", null, null, "AQAAAAEAACcQAAAAEKLHN8nNxARKJHtqE8uUtaN0gNI0hMwHv1NbS2jdGBOMKmeWe0n6k6r+ZckMuIpWTg==", null, false, null, null, 0, false, null },
                    { new Guid("dbc51236-052c-4c31-820d-b0a01a143d1a"), 0, new DateTime(1952, 8, 24, 17, 4, 53, 969, DateTimeKind.Local).AddTicks(3816), 685.7189929386460000m, "fbf526a6-7c72-4c9e-b4cc-974e36474939", null, null, null, false, null, "Mitchell", "Turcotte", false, null, "Mitchell_Turcotte", null, null, "AQAAAAEAACcQAAAAEAZDqyfEUmPwzHST6tYN8r3hWEntW5wzqrYWYH+4UD1D09Y85d1hBlCeGmUSzTK7Vw==", null, false, null, null, 2, false, null },
                    { new Guid("dc2b5eaa-01f8-425c-874d-15e523189cc1"), 0, new DateTime(1991, 9, 13, 17, 40, 3, 325, DateTimeKind.Local).AddTicks(7794), 878.3689653849910000m, "f6ca21a5-6461-47d9-8278-10b9825b6b7e", null, null, null, false, null, "Opal", "McGlynn", false, null, "Opal_McGlynn91", null, null, "AQAAAAEAACcQAAAAECidnoCjhm6rQblzIqzDdffKdctHCTRHwzq/Y2WMFblTpvolQ3tR6Mnjh5RUTl0/5w==", null, false, null, null, 1, false, null },
                    { new Guid("dc52bf7b-d952-45c3-8bf0-44dadbfbb09e"), 0, null, 486.620555045190000m, "187542d8-b528-4b85-b7d4-ada1db8c525c", null, null, null, false, "Nathaniel", "Nathaniel", "Kuhic", false, null, "Nathaniel39", null, null, "AQAAAAEAACcQAAAAEA2BAYsDsXtb1oICMglfmAJ5cciIx3KV0WvmCRamtYWjWLZgu5y6YXDf0nXiOxX1Bg==", null, false, null, null, 2, false, null },
                    { new Guid("dc5f8e5e-be11-43f9-acd2-648e38e09946"), 0, new DateTime(2001, 10, 9, 22, 5, 49, 790, DateTimeKind.Local).AddTicks(9595), 102.0331714130370000m, "8b7f9479-cc02-4dc9-9bd6-7f90c90cbd49", null, null, null, false, "April", "April", "Grant", false, null, "April73", null, null, "AQAAAAEAACcQAAAAEB+kpK0LaoHP1kYUAdGv+EHzumqaY5m4IsUTw7QQxsSZhFzgjnfMI/ZosP7cprdUyQ==", null, false, null, null, 2, false, null },
                    { new Guid("dd550cd7-4eae-4d75-8be5-5f3e496fdd24"), 0, new DateTime(1932, 12, 30, 7, 40, 8, 607, DateTimeKind.Local).AddTicks(4853), 820.8439424503090000m, "7aa6c47a-ee29-4f04-97b4-30e5db78f935", null, null, null, false, null, "Clara", "Morar", false, null, "Clara32", null, null, "AQAAAAEAACcQAAAAEDI6SsyZQfqYc2nResk2B6gXKJesVCo8GvaJ7H6IxAGrVhPAnAMbC0oDOPbGcx6MIw==", null, false, null, null, 1, false, null },
                    { new Guid("ddf2bc3e-21a3-4bd8-8ebc-4afb8cb49df0"), 0, new DateTime(1981, 4, 17, 6, 17, 16, 437, DateTimeKind.Local).AddTicks(6486), 17.30741018465190000m, "be4c8c6d-5d55-412a-9f1d-1f61f7d70dad", null, null, null, false, null, "Katie", "Herzog", false, null, "Katie.Herzog67", null, null, "AQAAAAEAACcQAAAAEOXGtfuWOPQ83gAqqv4HbLRNz8t7cCQQ/Zst7Hg16tKMdv02qAEA9Q+YbbNw5W50Gg==", null, false, null, null, 1, false, null },
                    { new Guid("de7e4623-27a6-4a10-8c19-1f8ae8f689d2"), 0, null, 616.1552204223690000m, "d2201198-25c3-49ae-ad9d-1caf98f2d109", null, null, null, false, null, "Dave", "Heller", false, null, "Dave_Heller", null, null, "AQAAAAEAACcQAAAAEMzlJ4YWFuIAlyHBUXpjsSUVsHmnPYCEDjTx5V9IxuZBl+83B+4Z03poyVTfZkGrdg==", null, false, null, null, 0, false, null },
                    { new Guid("df1ba0e6-99b8-419d-a3b8-cece7c4928bd"), 0, new DateTime(1987, 5, 15, 2, 26, 14, 627, DateTimeKind.Local).AddTicks(1586), 201.20598690160000m, "ee926b77-222e-4cfc-9233-d40605f71475", null, null, null, false, null, "Cathy", "Carroll", false, null, "Cathy93", null, null, "AQAAAAEAACcQAAAAELp1eYUxEQ4MTMMkOVRf1uVFbkvSY0DQ5l6iApjphX+t9brna3gp/ywrZu0g8FhF+w==", null, false, null, null, 0, false, null },
                    { new Guid("df3cc97e-5297-4426-8d73-6ec8a1d6ff19"), 0, new DateTime(1965, 11, 15, 7, 44, 27, 184, DateTimeKind.Local).AddTicks(4886), 787.4348123724010000m, "a6ed9a01-1756-4438-ad4b-f9cd15f12ddf", null, null, null, false, "Vivian", "Vivian", "Murphy", false, null, "Vivian.Murphy", null, null, "AQAAAAEAACcQAAAAEKvmdHZ+5m7nkj8zdo3r2wt6L5REuChwmcaoMgtBpoFeJXAQ8mNBW7/68HjCZuWgCQ==", null, false, null, null, 2, false, null },
                    { new Guid("e2db5e4a-dcb2-42fc-b56b-17a4692bd0de"), 0, new DateTime(1985, 3, 7, 9, 0, 20, 962, DateTimeKind.Local).AddTicks(8544), 91.96016343828030000m, "37dd3458-61e6-4513-8a68-9d07031603c6", null, null, null, false, "Joy", "Joy", "Jacobi", false, null, "Joy_Jacobi27", null, null, "AQAAAAEAACcQAAAAECw5DcJ6714vpsu4tbdGmOlt9TALxFibxOrhz8X5JoDtyhZCjhHOeC1Iwp3YALthBg==", null, false, null, null, 2, false, null },
                    { new Guid("e36aac18-179d-420c-8aaa-edf7ff736e50"), 0, new DateTime(1958, 1, 4, 15, 29, 7, 456, DateTimeKind.Local).AddTicks(7566), 258.6928148968430000m, "c4e0f6aa-dd6b-47d8-b66f-5f2a068d8b9e", null, null, null, false, "Pedro", "Pedro", "Feil", false, null, "Pedro37", null, null, "AQAAAAEAACcQAAAAENrNz/rnzmkYkWWU989kcimUkWp+ZdEJaROJzhj4Q5QMHM9RkjNdvnCB1N9xaMj1Mw==", null, false, null, null, 2, false, null },
                    { new Guid("e41a0e5f-468e-496b-8fe7-b8f4b2a0f962"), 0, new DateTime(1970, 7, 19, 3, 6, 19, 489, DateTimeKind.Local).AddTicks(1848), 109.5072131073610000m, "2e384a93-5af1-49dc-8471-0c4395bde469", null, null, null, false, null, "Iris", "Friesen", false, null, "Iris.Friesen12", null, null, "AQAAAAEAACcQAAAAEPV6R9pK6a3XwoiRN2E0GBizp+xwbsXLocuLBgEWsCE5dvfc0CUBLTDU8m2NGeYZUQ==", null, false, null, null, 0, false, null },
                    { new Guid("e5406e78-ce40-43ee-8dee-e58fe7687eb3"), 0, null, 273.3906777667120000m, "1f6a2847-a311-4b0c-8de5-4c3b2abf9d23", null, null, null, false, null, "Pearl", "Boyer", false, null, "Pearl.Boyer12", null, null, "AQAAAAEAACcQAAAAEFXMIbKqGQN4ZuPiVjI734xrp8Ffhu14WTLTpU85JylC2+TubC6S3aBJFlrdqe9ceQ==", null, false, null, null, 2, false, null },
                    { new Guid("e5fa7b3b-6d8a-43dc-88a3-403aed558476"), 0, null, 466.3560912993780000m, "849263bb-bd7b-468a-ba0f-85024f93c71f", null, null, null, false, null, "Eric", "Rice", false, null, "Eric.Rice", null, null, "AQAAAAEAACcQAAAAEByctEXKnYCwEdM4rhRu8JdGPAlxLKjMKBucwJklBduzswMiUPygeLsMFlWWW8dLIQ==", null, false, null, null, 0, false, null },
                    { new Guid("e764f5ca-90fe-4d60-aab1-e56e02a1f110"), 0, new DateTime(1997, 10, 1, 1, 55, 53, 138, DateTimeKind.Local).AddTicks(7517), 530.2590316365690000m, "a17fec24-710e-48bb-932b-73b28daff483", null, null, null, false, null, "Lynda", "Dickinson", false, null, "Lynda.Dickinson85", null, null, "AQAAAAEAACcQAAAAEBsgdqpchWkvZV6bgBcLFIyuRJjLPw2IjNTJ9mqn1UK0W9aEw08gLjwsHEXKDfMSyg==", null, false, null, null, 2, false, null },
                    { new Guid("ea848f07-5360-4e76-ac1d-cf046366d4ef"), 0, null, 11.40464837383270000m, "01ef3b0b-95fe-49e0-83f2-bad8ef4038c7", null, null, null, false, null, "Josefina", "Kozey", false, null, "Josefina0", null, null, "AQAAAAEAACcQAAAAEL7uaW0D4W8Dl8d2MPrGFFgpl+9NGmtFgbCGYNteylTqnj9xAwl9eNugpOEXOjkG2g==", null, false, null, null, 0, false, null },
                    { new Guid("ed1f5061-44e1-4df4-b0de-bc0c17fd0185"), 0, null, 594.8984436294250000m, "fdda00b5-e6e0-4a99-829d-4baa27c684e5", null, null, null, false, null, "Susan", "Walter", false, null, "Susan_Walter93", null, null, "AQAAAAEAACcQAAAAEFyudP7PBaNBwbackO5Pw0Lm/GNVra5YEeWXoS/uD3FxNlCBli8uIX2kjeOm3b0Zbw==", null, false, null, null, 0, false, null },
                    { new Guid("ed5c634a-32ee-48fd-80f4-26cfb1c72602"), 0, null, 730.6571047686260000m, "89a4300c-f971-48ea-944a-1b5bc05a7251", null, null, null, false, "Sheryl", "Sheryl", "Schumm", false, null, "Sheryl_Schumm71", null, null, "AQAAAAEAACcQAAAAEKP79HaKFS2bHw2JeQa6O7Fpot6Lv/0U6dZp5IEiDfLMIGlAOWaUzm+dBpF5CEFu8w==", null, false, null, null, 1, false, null },
                    { new Guid("eeb82343-3a6f-48ee-b791-709692ceea7d"), 0, new DateTime(1964, 3, 8, 19, 36, 16, 921, DateTimeKind.Local).AddTicks(2730), 848.9546025707750000m, "ebbde120-dde3-4b92-bc2f-b27eeb1250ed", null, null, null, false, null, "Alejandro", "Blanda", false, null, "Alejandro_Blanda57", null, null, "AQAAAAEAACcQAAAAEKjgzjP/MkIJJIN0sFURn0AFYwsSIqO3+L2jEZaUm/4swfxXJsOrZDvw4LtXBQZI6g==", null, false, null, null, 2, false, null },
                    { new Guid("f28f3fdf-fa90-4b58-895f-89b7f89e53e9"), 0, new DateTime(1971, 12, 20, 16, 6, 34, 380, DateTimeKind.Local).AddTicks(8002), 122.3923673810660000m, "b9acc03a-ea78-473c-a8a3-aafc2ebf7bc4", null, null, null, false, null, "Maurice", "Hudson", false, null, "Maurice.Hudson86", null, null, "AQAAAAEAACcQAAAAEEj/1U/QvsVyfr/5TKAhd+34qvrzUmZqO+UCYqzW5FBPahCaa7kW1+tDm7QoppaGHw==", null, false, null, null, 2, false, null },
                    { new Guid("f2c5c231-fa4f-4403-a17b-f986cd15543a"), 0, new DateTime(1996, 5, 27, 3, 54, 19, 846, DateTimeKind.Local).AddTicks(518), 578.2524982238110000m, "82e8e1eb-48c1-4485-bf09-f90b3d4bfd60", null, null, null, false, null, "Trevor", "Gleichner", false, null, "Trevor52", null, null, "AQAAAAEAACcQAAAAEK9UakO4x179am+dNTD5DpvP/zttcNmV8VXDirgpFP0UlHfwSzoHeWZPeXiWyxvm5A==", null, false, null, null, 2, false, null },
                    { new Guid("f3cb510a-8243-4204-8c1f-ace56610d45f"), 0, null, 114.2561469361440000m, "04c39598-e7eb-4653-8cc8-c77ea1db9959", null, null, null, false, "Steve", "Steve", "Auer", false, null, "Steve_Auer", null, null, "AQAAAAEAACcQAAAAEAA7UfzcW1/sny+W20x+0S0QQFHS3qZOBo3mgZka6i8lQxFK0UDl4yFtJDuupULw3w==", null, false, null, null, 0, false, null },
                    { new Guid("f4c8c27a-6b37-469c-9492-061adc476725"), 0, new DateTime(1963, 10, 21, 11, 12, 12, 743, DateTimeKind.Local).AddTicks(9450), 715.8177284372180000m, "1d17a00c-6b06-4277-afa4-4f51c11b2d9c", null, null, null, false, "Spencer", "Spencer", "Schiller", false, null, "Spencer.Schiller77", null, null, "AQAAAAEAACcQAAAAEMfxQ7CEdtvTOntxNacXC8CaYsCRkjGHTWtDeZ2b/hSRGQrLN1im4Nc668E4hbJO/Q==", null, false, null, null, 0, false, null },
                    { new Guid("f51931e0-68b3-4aed-8f03-7ef9a8526650"), 0, new DateTime(1949, 8, 31, 1, 46, 22, 651, DateTimeKind.Local).AddTicks(4960), 285.7919032237460000m, "3221f972-841b-4cce-9c14-37487378f7a7", null, null, null, false, null, "Eloise", "Gutkowski", false, null, "Eloise_Gutkowski70", null, null, "AQAAAAEAACcQAAAAEAElLW0pW5t1ZPNrlphXW6ggwpZi2xrrmnrVe/HZCMxnXY/mqLORLgCaK+RoLTW1iw==", null, false, null, null, 0, false, null },
                    { new Guid("f5fa9239-e966-4c8e-9eb5-32ecf277976e"), 0, new DateTime(2006, 9, 4, 6, 13, 46, 978, DateTimeKind.Local).AddTicks(8214), 903.6929065450360000m, "47267acd-f40c-468e-9722-54a753b422e7", null, null, null, false, "Gordon", "Gordon", "Jenkins", false, null, "Gordon.Jenkins41", null, null, "AQAAAAEAACcQAAAAEOamLngmJk3G0BBfzU/GHTQ3oDPAWxYiOgT9ya4xzGq46MTNgx2GhvhtVfr+PG1LtQ==", null, false, null, null, 0, false, null },
                    { new Guid("f630d90d-3329-4958-99e4-34aa2f69436c"), 0, null, 330.2724180392820000m, "923a7490-6fd2-4d04-80b2-0c167884b12f", null, null, null, false, "Lynette", "Lynette", "Strosin", false, null, "Lynette_Strosin27", null, null, "AQAAAAEAACcQAAAAEEo6HvT/+eqFMiEdP93sg+LmFjjULcL1UNyfuQ2QvUgJV4SgM4TUdv0O0CLVumMJDg==", null, false, null, null, 2, false, null },
                    { new Guid("f7082ecf-eb66-429e-8a3f-72fac7d7b453"), 0, null, 224.1828724527050000m, "e5163417-30d1-4d05-9827-af69ce77e1ed", null, null, null, false, null, "Anita", "Swift", false, null, "Anita_Swift28", null, null, "AQAAAAEAACcQAAAAEG4Ch+fE1jqn28PVvCToHkHOr07cWUSzg41D79d7NLw515Ito1/1zrXBoHv2xc1EOA==", null, false, null, null, 1, false, null },
                    { new Guid("f7dacdb6-cd5e-4c55-a2df-710f582d75f2"), 0, null, 515.0294019211920000m, "d08c8a9b-0400-4c03-ba56-51f96cb8f7d6", null, null, null, false, "Don", "Don", "Corkery", false, null, "Don1", null, null, "AQAAAAEAACcQAAAAEPkHLvKQkAwXQwcBNlMi8wFvl4222RIvx+H15we7Io9EK9wztMKXZtUozJd9JCI0rQ==", null, false, null, null, 2, false, null },
                    { new Guid("fcf05f51-7f3a-4331-a0f5-6204db62e7ba"), 0, new DateTime(1966, 11, 4, 18, 17, 28, 931, DateTimeKind.Local).AddTicks(5711), 78.86276918226850000m, "83272aec-1bed-4976-b263-e803abebd354", null, null, null, false, null, "Louise", "Tillman", false, null, "Louise.Tillman", null, null, "AQAAAAEAACcQAAAAENxz2QQeFAX7f4UcUqP+evrFYbZgajKa0koeAGKAdZCImzAKdsttOycsXqfGe0AN7g==", null, false, null, null, 0, false, null },
                    { new Guid("fe7a3052-1ad9-4450-b9d5-057c6abe9c2e"), 0, null, 293.0754410782970000m, "e38ad1ef-ee59-43b4-9b2e-630385e19944", null, null, null, false, null, "Owen", "Yost", false, null, "Owen47", null, null, "AQAAAAEAACcQAAAAEF+D8osZLtb05Fc39idzGyRDnnGbMbLR46EeTnn6i5pn07FAQNyy7nKeeOsFdXrxUw==", null, false, null, null, 2, false, null }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("00091fb6-aa02-4588-9b84-d11458b9c6a4"), "0,9805234;0,25510257", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Angus, Finland", "Douglas Mountain, 9396", 1790215414 },
                    { new Guid("0468ea01-aceb-416d-b978-7cf43120877f"), "0,5270095;0,18993732", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Queen, Netherlands Antilles", "Bechtelar Forges, 785", -1316829310 },
                    { new Guid("068c0c27-b98a-49d5-aaa1-a1765dda50f9"), "0,673872;0,9823251", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Andrewmouth, Uganda", "Glenna Mews, 4611", -1279443706 },
                    { new Guid("09e5e21c-c776-467c-905e-21ba4e3beed9"), "0,7110243;0,6929496", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Zemlakfort, Moldova", "Brekke Underpass, 65178", 699461311 },
                    { new Guid("0ef3ff47-880f-45dd-8df0-2e9c70bdbcdb"), "0,7017697;0,62811714", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Aliza, Saint Martin", "Feest Meadow, 249", 1250640853 },
                    { new Guid("0fb36c2d-7153-4220-9932-c33c963f8c7b"), "0,87431216;0,74923384", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Citlallifort, Cote d'Ivoire", "Harley Camp, 53218", -641158279 },
                    { new Guid("17a015cb-7dfd-4c22-a4c5-5a73a327da20"), "0,79004025;0,2497331", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Keegan, Sao Tome and Principe", "Sim Way, 318", 380616919 },
                    { new Guid("1992c5e6-dcf1-4936-8f7a-e2ccf95fa593"), "0,79386437;0,8149139", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Haleighmouth, Turks and Caicos Islands", "Ankunding Mount, 050", 988662400 },
                    { new Guid("19c5337c-9e54-40b4-84a0-95c2f337e410"), "0,6768272;0,90174145", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Janickton, Italy", "Fahey Well, 66996", 1554639407 },
                    { new Guid("2112c8a4-038e-4173-bcd3-498ad1f0a769"), "0,46641386;0,24112655", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Maciton, Germany", "Dach Plaza, 757", -1602935444 },
                    { new Guid("222500b6-d2ed-42b0-8935-d7a57033ec6a"), "0,48978993;0,73793536", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mayertside, Cambodia", "Graciela Viaduct, 13517", -1979497979 }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("233044a0-8250-4752-bedd-65c224c0a75e"), "0,8229435;0,8091199", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "O'Konburgh, South Georgia and the South Sandwich Islands", "Guillermo Place, 30186", 101545316 },
                    { new Guid("27476dc8-63bd-42ab-a795-e1dcbcc4b831"), "0,78165406;0,91300327", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Abdullahmouth, Latvia", "Greenfelder Walks, 92117", -1541722433 },
                    { new Guid("2a197e6f-00c1-4048-a7dd-2e00ef52fb76"), "0,21027268;0,85522515", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Therese, Turks and Caicos Islands", "Lemke Summit, 07491", 540190566 },
                    { new Guid("31bab75a-923e-401d-aa20-f89bf5902e7b"), "0,87877595;0,08670677", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Jeffrychester, Tunisia", "Aufderhar Isle, 32800", -1213709568 },
                    { new Guid("32bf02b8-2e2e-4750-8fe2-772bf1dbfae7"), "0,1367173;0,8087032", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Elsemouth, Northern Mariana Islands", "Clemens Club, 577", 1686030429 },
                    { new Guid("3405c9c8-4177-44e5-bdad-e6c6b4aeab8a"), "0,7550404;0,080388464", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adellview, Philippines", "Kimberly Well, 7551", 1465554563 },
                    { new Guid("37ab01f1-1bdc-4cdb-ad56-d3d3689a8780"), "0,5661709;0,40391177", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Santinafort, Belgium", "Mertz Branch, 570", -15421817 },
                    { new Guid("37f751b9-b53a-4898-b4a9-a37e0314864b"), "0,66595817;0,18729162", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Beulah, Holy See (Vatican City State)", "Candace Walk, 37626", -644267471 },
                    { new Guid("3a38050a-84c7-4261-8367-5bbaeb449cbc"), "0,2670511;0,80850405", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Ashlynnmouth, Portugal", "Ima Pines, 621", 1940876682 },
                    { new Guid("3c318328-a67c-4c6c-9ed7-2a8bae9f85ea"), "0,5201997;0,65829307", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Caesar, Sudan", "Ansel Estate, 83315", 316218106 },
                    { new Guid("3d17f8d2-ee40-4481-9c6d-91cefd7e33c1"), "0,9716812;0,46009558", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West D'angeloberg, Panama", "Shana Loaf, 9442", -343768487 },
                    { new Guid("46965ce1-5364-4913-bd7a-2ceb74c585e7"), "0,14015049;0,017213948", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Zula, Reunion", "Upton Passage, 384", -195854720 },
                    { new Guid("4e7b9177-3edc-4a7b-aadc-a181cc69f17e"), "0,13258897;0,82703465", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Madisonchester, Guyana", "Anibal Estate, 505", 190304003 },
                    { new Guid("4ebe9335-2657-4b4f-a16d-1d349a1df1df"), "0,45813;0,7335855", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Rubyton, Burundi", "Kemmer Station, 7239", -1829112383 },
                    { new Guid("50c32f6e-f6ea-46a3-9e45-715b8c6299cb"), "0,92027825;0,6641707", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Delphineberg, Haiti", "Salvatore Drives, 635", -2024885176 },
                    { new Guid("50da9465-bcf5-4087-8543-c453d70d3920"), "0,99380195;0,13985237", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Zander, Israel", "Denesik Ferry, 778", -339424602 },
                    { new Guid("55852a60-9ae1-4d32-8768-ba1817455e63"), "0,42694044;0,40032828", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lindshire, Western Sahara", "Kunde Mission, 365", 175149956 },
                    { new Guid("560cd733-1510-411e-bd76-418c0279a1a4"), "0,7514266;0,7047245", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kozeyview, Azerbaijan", "Hayley Locks, 531", -2089740715 },
                    { new Guid("566b54f1-4b53-47e1-9081-144113bb9c9b"), "0,58249867;0,7814138", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Graciela, Saint Pierre and Miquelon", "Balistreri Key, 07404", -2109276918 },
                    { new Guid("58235a1a-afdb-41a2-b991-528250511518"), "0,9101672;0,94743055", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Alexis, Greenland", "Schaden Fort, 511", -1767247121 },
                    { new Guid("58d75ce1-187f-42ea-9907-6116aace8f5c"), "0,5357598;0,50278217", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Grahamfort, Saint Martin", "Mikel Summit, 8774", -1486228932 },
                    { new Guid("592f9c89-50e9-4d25-9c28-664ba4900563"), "0,9241499;0,028203081", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kennediton, Senegal", "Legros Mountains, 1647", -1753385757 },
                    { new Guid("5ae0ed88-cca1-44fd-99d8-21aeed748e73"), "0,08165577;0,2889158", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Barrowsberg, Bahrain", "Stehr Port, 29001", -921430070 },
                    { new Guid("5b85b1c9-36dc-4dc1-8950-645a221afb9b"), "0,0077266623;0,8202745", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Estellland, Anguilla", "Hintz Overpass, 3323", 1553285770 },
                    { new Guid("62ade7ef-4e34-479d-8622-6a46590825d9"), "0,17330776;0,62538487", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Blickburgh, South Georgia and the South Sandwich Islands", "Jarred Ramp, 7593", -1474147324 },
                    { new Guid("63603a85-2548-44e3-bc36-7b32498a2919"), "0,07949193;0,108212814", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Alexandrinehaven, Mayotte", "Eloisa Village, 3967", 1205179790 },
                    { new Guid("639766bd-6d77-419f-9691-f0686f37251e"), "0,6313595;0,815486", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Bayerberg, Angola", "Gorczany Fords, 22432", -1629512064 },
                    { new Guid("6487fc30-6deb-409c-8257-c4e45f593af4"), "0,9177455;0,98257405", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Petratown, Madagascar", "Lang Viaduct, 3234", -1811032734 },
                    { new Guid("661d7ffb-22a1-4e54-8f7b-baddab4e818b"), "0,5725667;0,47404534", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Marcelle, Turks and Caicos Islands", "Lily Fords, 7438", 162183523 },
                    { new Guid("6791dcab-3628-4f15-9495-fd77b7928256"), "0,78089845;0,8054679", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "VonRuedenburgh, Cocos (Keeling) Islands", "Turner Meadow, 8759", -514039067 },
                    { new Guid("6844e222-6205-47f1-b36d-3d91079d0826"), "0,16680306;0,6804538", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Bauchmouth, Turkey", "Ward Village, 01873", -1229926860 },
                    { new Guid("710bba6d-4210-470d-9f0b-ebfdab7469be"), "0,051410682;0,606495", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Mablestad, Ethiopia", "Vito Ranch, 979", -1020839771 },
                    { new Guid("71c8cdb0-aa26-44ca-852c-9de9e50e093d"), "0,81559473;0,062501445", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Christophechester, Liechtenstein", "Queenie Fields, 141", 1122798766 },
                    { new Guid("76c53964-2524-4d25-a9b9-cf207b81dfe0"), "0,9063449;0,87343436", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Murazikbury, Cayman Islands", "Deon Highway, 3596", 1350191003 },
                    { new Guid("78c4d716-54c8-45fa-85b7-7b0d00eca860"), "0,21007921;0,663026", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Beckerview, Saint Pierre and Miquelon", "Tiana Mall, 574", -1789086109 },
                    { new Guid("79dd8ee8-b8a1-47fd-b20b-4bb36d827c5e"), "0,4530319;0,09811161", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Ruth, Monaco", "Kertzmann Village, 25822", -932101922 },
                    { new Guid("7e451632-f8bd-4029-ab71-12f636420ebd"), "0,085819535;0,2332436", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Smithview, Fiji", "Gleason Curve, 8542", -2020565523 },
                    { new Guid("7ef869ee-bd68-41c3-a42d-2b7217857422"), "0,1034019;0,41246992", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Jamison, Nepal", "Reese Union, 9596", -448148755 },
                    { new Guid("8089ccd2-8029-47ca-ad35-b3b01d71501c"), "0,39727437;0,26405385", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Framitown, Republic of Korea", "Douglas Row, 4121", 609534024 },
                    { new Guid("862ae6dd-1c01-4827-8a1c-2622dbe1d94b"), "0,9833644;0,3159596", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Carmella, Turkmenistan", "Bradtke Flat, 847", 1571550071 },
                    { new Guid("8c88fd24-7820-4033-9677-c83854c16403"), "0,16915108;0,06831091", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Denamouth, Madagascar", "Haven Flat, 374", -1229464506 },
                    { new Guid("8d602d97-6946-41d0-ab1e-042b702681fd"), "0,5160947;0,9328302", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Granville, Mayotte", "Moen Mill, 08969", -802802269 }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("931f39ea-b671-483a-97f1-26087b7e97cf"), "0,08553281;0,42746168", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Savannaside, Pitcairn Islands", "Gislason Circles, 8794", -1592377112 },
                    { new Guid("9b3600ec-6abb-4527-8353-b86e0ba9dfe9"), "0,12526669;0,1681597", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kilbackborough, Indonesia", "Collins Isle, 117", 1352441867 },
                    { new Guid("9c676e7c-cee2-4fb0-b15c-ad680a4e0508"), "0,9387213;0,9145884", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Schambergerbury, Bahamas", "Tanner Freeway, 219", -513699957 },
                    { new Guid("9d4d2699-bfbb-4748-9982-b5b9c25bd958"), "0,5125641;0,43511382", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "VonRuedenbury, Malta", "Antonette Bridge, 405", -1274174673 },
                    { new Guid("9e590295-ad36-40e8-80f1-a90b1f6d2b8c"), "0,78617376;0,740888", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Francescoburgh, Eritrea", "Oran Tunnel, 348", -521756556 },
                    { new Guid("a19c209a-6a01-438d-8bd8-2f86abcbf435"), "0,9428999;0,8288067", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Wolffurt, Brunei Darussalam", "Mayert Points, 8236", 136834567 },
                    { new Guid("a1c06906-8732-416c-a4fc-29ad95c5f002"), "0,8014129;0,59419096", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Kamronberg, Cook Islands", "Schoen Estate, 1984", 139181400 },
                    { new Guid("a257c649-cc45-4c4f-94bb-15ae61eb9813"), "0,89479613;0,25407448", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Camden, Turkmenistan", "Wintheiser River, 640", -1384780970 },
                    { new Guid("a8a1cdc6-a6b8-4dec-814c-b73cd716f7a6"), "0,19967727;0,8837278", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Francesburgh, French Polynesia", "Icie Groves, 7624", 1316291947 },
                    { new Guid("a999a2b6-4c48-49ab-8061-ec6d28e0a171"), "0,9830156;0,7968004", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Adellaberg, Anguilla", "Berge Path, 024", -890555880 },
                    { new Guid("aa608ceb-68af-4b6f-aaf8-28bb37576957"), "0,57644296;0,8388213", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Schinnerborough, Sweden", "Bashirian Grove, 11359", 1203617732 },
                    { new Guid("ad520e3a-54cc-4c25-8f67-c2e52d676ea3"), "0,45615292;0,8074428", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adolphusburgh, Bahamas", "Windler Shores, 29596", -1562116545 },
                    { new Guid("ae678ec1-c7de-4c93-9ced-ae4246b06427"), "0,7789414;0,051720995", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Domingobury, Cape Verde", "Marcelina Pines, 27775", -1160186292 },
                    { new Guid("b1655492-a811-4f4d-bf9f-d9e635c7c28d"), "0,54011816;0,84923095", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Buddyport, Japan", "Kreiger Gardens, 485", 2035520093 },
                    { new Guid("b862f4a0-9862-42be-afb9-5a596c222eed"), "0,68664604;0,7214819", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lizzieville, Chile", "Abbott Fords, 142", 845667708 },
                    { new Guid("bbae83c4-1e04-4b2d-bce8-c60064eefac7"), "0,3162485;0,44968024", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Sonny, Ukraine", "Smith Inlet, 44754", -2074363173 },
                    { new Guid("beab36bd-d0bd-4fa4-831a-9db24226833c"), "0,05662432;0,33518016", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Leraport, Mauritius", "Lehner Square, 8119", -1189236459 },
                    { new Guid("c73190bb-ed98-41ec-ab25-a2b158d3818e"), "0,30173907;0,6377869", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Dareburgh, Suriname", "Dickens Mill, 00500", 1855171541 },
                    { new Guid("ce744015-c5d5-462c-9e98-877a407cf522"), "0,8271852;0,37806627", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Paul, New Zealand", "Renner Creek, 8642", -1496502348 },
                    { new Guid("cfbd9367-93df-4ef4-9a1f-054f6ef543d7"), "0,93092036;0,5397466", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Kaylee, Sri Lanka", "Cary Mount, 086", -1035174203 },
                    { new Guid("d041e12d-4780-47a8-883c-db7b287e0a05"), "0,017024944;0,6330396", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Gabeville, Wallis and Futuna", "Zander Cove, 78672", -1110158532 },
                    { new Guid("d0a4e549-7e37-4c36-b107-a73a11f361f8"), "0,75517553;0,32852188", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Blake, Aruba", "Conor Walks, 513", -645156938 },
                    { new Guid("d22edb2d-5381-4ce7-b715-5d38edce9f8b"), "0,80446887;0,14792164", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Kathleenside, Lesotho", "Klocko Cliff, 50607", 352203566 },
                    { new Guid("d935d64c-4b36-4555-acbc-b624c4af40dc"), "0,37382197;0,70466113", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Pollyville, Pitcairn Islands", "Feest Crescent, 4318", 1672130049 },
                    { new Guid("daf617bd-1066-46bf-8087-a149647b6d8f"), "0,22505972;0,5482188", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Estelle, Hong Kong", "Bogisich Union, 11293", 1175320536 },
                    { new Guid("db9e2ba7-df30-4f6a-b460-8bc54e094955"), "0,39548287;0,13500038", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Gaylordmouth, Peru", "Claire Groves, 6068", 1361526231 },
                    { new Guid("dbb0b168-450e-4d80-9c33-6e4bd11c5316"), "0,7035181;0,38570234", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Terrenceview, Gabon", "Reynolds Mills, 56029", -642278845 },
                    { new Guid("dc7833fb-d139-4f65-8a6f-bc2fea32c559"), "0,64594305;0,43796605", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Haleyburgh, Romania", "Mraz Club, 92465", 912221106 },
                    { new Guid("e509c407-759a-45f4-a4cf-8f4234d0cb66"), "0,8192384;0,07813538", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lefflerchester, Guadeloupe", "Rasheed Station, 46181", -1919835681 },
                    { new Guid("e6ee6cbb-2a6c-4254-8f3d-6ccff987db33"), "0,70852655;0,37551552", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Marciatown, Heard Island and McDonald Islands", "Pouros Plains, 9968", 1020773938 },
                    { new Guid("e7de180f-ddb6-432b-ab23-fc06fd578375"), "0,52234125;0,6932871", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Judd, Moldova", "Ford Grove, 05260", -1503119145 },
                    { new Guid("e81896ad-49d6-4b9f-9d21-36ce2e2569cf"), "0,8026099;0,86635023", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Winonaberg, Romania", "Schmidt Islands, 523", 1808480710 },
                    { new Guid("eb4b4a81-f7f6-4929-87aa-15e714f7fd94"), "0,440321;0,07231036", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Elody, Holy See (Vatican City State)", "Halvorson Isle, 2054", -1946002288 },
                    { new Guid("ee303bce-2716-4227-b7d9-2a52abcb28e6"), "0,4582704;0,918702", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kayliehaven, Comoros", "Norval Vista, 430", 1161269366 },
                    { new Guid("eed80be9-efd0-4c1b-b1e4-f7e931fff5d1"), "0,23977596;0,0058439085", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Pietroshire, Saint Helena", "Huels Circle, 5960", -1876847611 },
                    { new Guid("f17c1701-0e46-4252-b359-35ca70436e43"), "0,74769324;0,85031825", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Haskellville, Papua New Guinea", "Kub Junctions, 7483", 843221641 },
                    { new Guid("f21855d7-cfb6-4b8e-af2c-65382b12c736"), "0,29024175;0,73654354", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Rosamondport, American Samoa", "Marks Via, 858", -268602028 },
                    { new Guid("f3c042f8-a89b-4505-b220-4ee7fef397b0"), "0,11247898;0,7770601", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Josianne, Sao Tome and Principe", "Chasity Causeway, 87370", 1528043256 },
                    { new Guid("f4b3d8a0-c197-4ceb-b49e-eb4bc305b17f"), "0,35063154;0,60484266", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Amparo, Marshall Islands", "Amya Knoll, 07041", 1778044681 },
                    { new Guid("f4e3b21c-7066-4618-9446-9e31497bdda8"), "0,67503697;0,24593636", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Ervin, Kazakhstan", "Rosenbaum Avenue, 921", 173733023 },
                    { new Guid("f59bd662-31da-40fc-801e-b049a8a47d2b"), "0,5108395;0,693306", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adrianahaven, Afghanistan", "Waelchi Shoal, 5872", -2128630528 },
                    { new Guid("f74c47eb-ec5f-4ba4-b8fd-c10e20f0bff8"), "0,29549876;0,28248784", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Abrahammouth, Tuvalu", "Noel Rapids, 59476", -353774549 }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("f828bcdf-be5a-483e-af6c-a5e45c5b1b9b"), "0,79849005;0,7221016", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Michelleview, China", "Orn Flat, 35317", -830926516 },
                    { new Guid("f84f2bed-9c4c-4443-8aaa-31f330ddc3f7"), "0,9809041;0,6077858", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Millerville, Morocco", "Keeling Shoal, 7477", -1859891947 },
                    { new Guid("f867436f-deaf-42da-a3f0-4006db366d84"), "0,116065435;0,09958847", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Mylene, Eritrea", "Nona Ports, 0861", -1876847132 },
                    { new Guid("f8b9f8e1-247c-4fd1-9951-4f879ff74b6e"), "0,27590984;0,695709", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Sagebury, Nigeria", "Lysanne Ridges, 21659", 278975322 },
                    { new Guid("feac7668-218c-47ce-ac67-191dae73b884"), "0,42126146;0,6756972", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Chloehaven, Brunei Darussalam", "Bell Vista, 4438", 688054370 }
                });

            migrationBuilder.InsertData(
                table: "PostBranches",
                columns: new[] { "BranchId", "BranchNumber", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress" },
                values: new object[,]
                {
                    { new Guid("0285616b-45bf-4209-af00-3ad0c57a44aa"), 157933827, "0,13422881;0,087073915", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Troy, Jordan", "Freeman Fork, 7687" },
                    { new Guid("02890f5c-c811-49db-8843-43c7b5c64c71"), 1930241702, "0,35172394;0,9474527", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Izaiah, Netherlands", "Maxwell Stream, 17167" },
                    { new Guid("05424d6a-3732-4b9c-86d8-9b856f2c829b"), 197799048, "0,7234254;0,8625561", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Dinofort, Guadeloupe", "Hayes Green, 86899" },
                    { new Guid("05ecceec-a3b0-4ff7-ac6b-e0df55d81967"), -1251666207, "0,09460584;0,6514172", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Hirtheberg, Gibraltar", "Volkman Highway, 080" },
                    { new Guid("09a992d4-c231-4daa-937c-d6fa2b53c23b"), 1419899364, "0,043652263;0,2543384", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Oceanetown, Burundi", "Icie Squares, 5849" },
                    { new Guid("0a001c05-62f0-454d-a6c2-4e1716a8c0c6"), 1697515471, "0,22687581;0,6833974", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Uniqueshire, Senegal", "Justine Gateway, 8578" },
                    { new Guid("0b0b671a-3aab-4e4f-be3e-90feac893433"), 995239059, "0,42222667;0,101444766", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Aminastad, Sweden", "Eugenia Rest, 3332" },
                    { new Guid("11dd29ef-8cd7-46a4-8c0f-ba233e4b67f4"), 1065677997, "0,7703102;0,943879", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Kassandra, Belarus", "Gregoria Trace, 309" },
                    { new Guid("13254452-436d-479a-bff9-48eca7e36250"), 1898218456, "0,818234;0,6138145", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "D'Amorestad, Liechtenstein", "Raynor Branch, 69774" },
                    { new Guid("15db064c-3e4c-4d0b-b187-7fa6da2d0d86"), -241993623, "0,58736974;0,90703154", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Dextershire, Uruguay", "Elmore Stravenue, 813" },
                    { new Guid("160984a0-aa30-4b0b-8351-18010bda3136"), -347943976, "0,08776772;0,20574574", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Willmsfurt, United States Minor Outlying Islands", "Reichel Cliffs, 08992" },
                    { new Guid("193f0061-1dc7-475d-ab69-3d2eef9cf188"), -634017909, "0,70312166;0,23984402", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Curtchester, Pitcairn Islands", "Jacobson Fort, 247" },
                    { new Guid("194d17fe-21a0-48fd-81dc-9bf8ae8eb845"), 1770479198, "0,93783754;0,15822515", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Domingomouth, Namibia", "Emelia Place, 85647" },
                    { new Guid("1b870e5d-f7ae-46f2-a1eb-c18cc6da48c4"), -851270910, "0,15305309;0,7019526", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Henry, Monaco", "Rasheed Motorway, 36990" },
                    { new Guid("202ba67f-c995-4c01-a6e6-9c971c50b807"), 224556923, "0,6937891;0,63797516", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Rodolfo, Venezuela", "Jazmin Canyon, 697" },
                    { new Guid("215e0978-30a0-4f4a-bbc1-be590cb3b428"), -53497196, "0,94711536;0,45991245", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Aprilfurt, Iceland", "O'Connell Dam, 843" },
                    { new Guid("24ec95d8-1bc9-4960-9d58-207eb8726de8"), 426689900, "0,9519823;0,72194463", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Mohamedshire, Guam", "Okuneva Highway, 106" },
                    { new Guid("26055f4c-5625-4617-b4fd-d7188a39fec3"), 2134562836, "0,68180734;0,44459724", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Jonesville, Myanmar", "Marlin Views, 3560" },
                    { new Guid("26cf9720-123a-47ca-adb8-a8f1a48fc7d0"), 1011639477, "0,88615745;0,833021", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Rodrigoborough, Luxembourg", "Tromp Garden, 032" },
                    { new Guid("2ac39f2f-79dd-4f61-bbbe-f987d800aa59"), 920703852, "0,11800988;0,5021286", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Pablofort, Svalbard & Jan Mayen Islands", "Lind Path, 132" },
                    { new Guid("2bc8f746-1b7a-4770-b470-8baadafc77ce"), 9661242, "0,6381888;0,9692732", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adrianview, Guam", "Claudia Fords, 2955" },
                    { new Guid("2dbaf2de-fc58-4d06-8058-ffaf93e699f4"), 1207857902, "0,34369346;0,007184785", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Gusikowskiborough, Holy See (Vatican City State)", "Guy Bypass, 8016" },
                    { new Guid("3153544b-4450-4685-a7b2-5919e2314a2d"), -612517886, "0,042269785;0,2959768", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Catherinefurt, Monaco", "Feeney Loaf, 345" },
                    { new Guid("36ca1bb1-1e46-47e8-84cc-9c91d6d42e9d"), -554462357, "0,30002156;0,26078326", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Mayefurt, Saint Lucia", "Rosa Fall, 00025" },
                    { new Guid("3728082f-89a6-42f5-ab38-4e82f8f9215a"), 1358440942, "0,5446228;0,41071275", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Weissnatshire, Swaziland", "Weber Courts, 467" },
                    { new Guid("3dfa9e91-2c5e-4d61-a723-d15f9907f3bb"), 817815998, "0,76211315;0,03942771", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Coltontown, Saint Lucia", "Bailey Station, 87798" },
                    { new Guid("4275ee08-49f6-4a36-9b99-63f17d298d45"), 1252393520, "0,59503365;0,13052565", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Montanatown, Turks and Caicos Islands", "Florian Via, 715" },
                    { new Guid("4fec1495-0912-42cf-8863-5df0380372e7"), 884967454, "0,13618346;0,32988313", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Uptonfurt, Anguilla", "Larson Roads, 315" },
                    { new Guid("50219400-356b-4dce-993c-fd9553516295"), 218311872, "0,09677861;0,5103958", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Nicoleville, Saint Martin", "Jaskolski Green, 09879" },
                    { new Guid("513a1ff7-e965-4b9c-85c1-0e0915b5b391"), 1523861579, "0,9500312;0,7619406", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Anniestad, Slovakia (Slovak Republic)", "Barrows Key, 282" },
                    { new Guid("556715a8-4725-4d18-bfec-f9d8c4bc8bed"), 8303566, "0,34743154;0,87345016", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Howardton, Albania", "White Trafficway, 032" },
                    { new Guid("562d503a-0c99-4bdb-bcea-1a39a7f9b447"), -89471892, "0,6868752;0,7090601", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Schambergerburgh, Netherlands", "Raymond Pine, 56774" },
                    { new Guid("578fcf07-ea13-4d36-9b6b-ed7ce1270226"), 554452474, "0,038537197;0,0008024132", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Drakefort, Mayotte", "Sporer Ferry, 847" },
                    { new Guid("580a160a-9665-42d9-9e88-6d6f185b14d4"), 1526336631, "0,7433608;0,019683156", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Luciefort, Costa Rica", "Skiles Plains, 50676" },
                    { new Guid("593f07d5-7f10-40a2-bdcf-ce2ab3ee58da"), -1470615478, "0,15203667;0,56516343", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Bentonstad, Reunion", "Vesta Turnpike, 593" },
                    { new Guid("5d0e707e-d596-4d8a-9a9a-c3ad111c12ca"), -1005772794, "0,2835377;0,29634956", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Garettshire, Namibia", "Dasia Court, 5980" },
                    { new Guid("5e02c8f4-718a-44a5-9481-f7cf15d6a723"), 168287494, "0,91194016;0,74024796", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Keiraview, Uzbekistan", "Heather Gateway, 0466" }
                });

            migrationBuilder.InsertData(
                table: "PostBranches",
                columns: new[] { "BranchId", "BranchNumber", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress" },
                values: new object[,]
                {
                    { new Guid("63ffc79c-40c0-4f75-aa55-e4ced4464423"), 1017933228, "0,5657576;0,032139324", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Herzogbury, Western Sahara", "Clotilde Pike, 17717" },
                    { new Guid("645412ac-560a-4b75-998f-68887c3eafee"), 145211877, "0,5160878;0,72682214", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Noemie, Cocos (Keeling) Islands", "Herman Garden, 4734" },
                    { new Guid("6456d4ba-fdbe-468e-a062-98c06a43b5b8"), 1595283992, "0,39806375;0,6288618", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Norenebury, Armenia", "Joe Lights, 93736" },
                    { new Guid("64afc640-b6a6-41db-b176-bf1295345a46"), -1000849726, "0,5647107;0,2391793", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Terrill, Turks and Caicos Islands", "Brody Meadows, 532" },
                    { new Guid("6b7bc4ca-63e8-4353-bd9b-d34d8aa8a4f8"), 1746837814, "0,511181;0,42875576", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Rueckermouth, Uganda", "Johnny Shoals, 0322" },
                    { new Guid("6bde901a-2336-4bef-93df-4d872280ef0e"), -956778552, "0,59866;0,9635238", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Rhea, Bouvet Island (Bouvetoya)", "Juanita Lodge, 37960" },
                    { new Guid("6c0d124f-6b52-4071-a94f-b2de6dfeacd1"), -123634427, "0,48333758;0,4068642", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Luciochester, Bangladesh", "Myrtie Roads, 6607" },
                    { new Guid("6eac7b12-91bd-4c5a-9200-25862d27e34c"), -1866396787, "0,1890324;0,99167", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Adolphstad, Democratic People's Republic of Korea", "Maude Meadows, 0177" },
                    { new Guid("6f860395-56f3-49a3-8041-8365921a9d26"), 1119375281, "0,5615353;0,2314621", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Kraig, Western Sahara", "Ottilie Road, 85672" },
                    { new Guid("757b93b2-4d93-49f5-8a9f-ed2b994b170d"), -850098407, "0,26855558;0,9798256", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Kellenborough, Saint Pierre and Miquelon", "Blanche Mill, 5610" },
                    { new Guid("762e6a22-5edc-404b-92c6-2b74996b1367"), -743901382, "0,050290816;0,3656804", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Easter, French Polynesia", "Kamren Run, 1809" },
                    { new Guid("76b8be56-3335-46c9-8359-2c6bbdc82349"), 997553081, "0,6781688;0,42790458", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Ervin, Slovenia", "MacGyver Parkway, 9015" },
                    { new Guid("784634d6-74c1-490b-be22-85be9a2cd9fc"), -1460411633, "0,45846537;0,15481454", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Jordanmouth, Belgium", "Dare Parkway, 36663" },
                    { new Guid("7982c108-fb8e-44b4-86d4-bc820a068744"), 1212748118, "0,010140975;0,82892805", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Enochshire, Sierra Leone", "Rhett Ways, 3051" },
                    { new Guid("7bd0ffed-8d7c-4a54-a482-1f3752bb8fc3"), 1796970239, "0,37708268;0,034873538", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Walkerland, Pitcairn Islands", "Norris Greens, 00695" },
                    { new Guid("7ec1b685-2c50-49c8-9e0a-a00175dcc987"), -2073853940, "0,70268625;0,47962013", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Violette, Isle of Man", "Deckow Roads, 15192" },
                    { new Guid("83371ae5-003a-45c9-860b-907702f0122c"), 1104485462, "0,1194917;0,6015188", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Izaiah, Norway", "Eugenia Isle, 260" },
                    { new Guid("872aa9d2-c253-4cb7-9c1e-6b615b36d591"), -152697328, "0,47245044;0,753725", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Maryseborough, Lebanon", "Johnathon Street, 61271" },
                    { new Guid("879299da-d4a5-4323-922d-c3f63dea109c"), 1575696488, "0,5145529;0,7934794", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Valeriebury, Georgia", "Connelly Unions, 52173" },
                    { new Guid("88b65034-cd44-44ce-bb39-e665565e055f"), 1949774082, "0,32911757;0,04293671", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Kathlyn, Palau", "Smitham Road, 3195" },
                    { new Guid("8943915c-5468-42b1-a887-8d4a6efd68fd"), -1726740347, "0,5495948;0,06925942", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Gusikowskiburgh, Mauritania", "Fahey Squares, 222" },
                    { new Guid("8e8a7302-6f41-4a1a-a048-ef2b721091f1"), -599671136, "0,39678007;0,34518117", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Avaville, Antigua and Barbuda", "Allison Pass, 700" },
                    { new Guid("96ceb4f2-9a2e-44f3-abe6-4eb636c7ede0"), 375951381, "0,46626747;0,37715968", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Cordellmouth, Heard Island and McDonald Islands", "Goyette Crescent, 983" },
                    { new Guid("9a776394-ebbe-4217-b437-cba63582ba3c"), -962704653, "0,045031864;0,79462165", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Casperport, Sierra Leone", "Osinski Drive, 2876" },
                    { new Guid("a0207149-d4f7-49c5-a084-54af1def5b80"), 259472198, "0,097560056;0,47722644", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Hayliemouth, Jersey", "Kling Squares, 9561" },
                    { new Guid("a6c7ac5c-08c9-42c4-8e40-76d9ac447e3d"), -2026278650, "0,11149528;0,49027058", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kareemburgh, Palau", "Bins Keys, 42659" },
                    { new Guid("b41be0ad-916a-4699-b272-cbee7a4dde70"), -1022436016, "0,6364635;0,8969864", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Retha, Grenada", "Tyrique Locks, 620" },
                    { new Guid("b494a74c-b0a8-45be-af15-7560fb955e29"), 343699546, "0,1519478;0,33120397", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Giovannyland, Uganda", "Hartmann Stravenue, 33788" },
                    { new Guid("b713e0f2-510e-40f5-a395-8adf805c1ee3"), -1505510978, "0,988939;0,43384743", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Bechtelarton, Greenland", "Jacques Island, 33590" },
                    { new Guid("b822b2a7-d482-4bb9-a569-f7c1f5027d07"), 926312635, "0,25734574;0,7978108", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Croninshire, Falkland Islands (Malvinas)", "Maybell Well, 24661" },
                    { new Guid("b95ac420-edf0-4bf7-8163-25650a83f81d"), 382848398, "0,38141197;0,7768864", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lockmanchester, Mozambique", "Oran Garden, 2772" },
                    { new Guid("bb5c4c98-6147-4427-94dd-b9c4721f830a"), -1106744479, "0,2796704;0,36935583", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Jordan, Kuwait", "Brycen Avenue, 221" },
                    { new Guid("be8ebd43-3b99-4609-b334-47e36a9e2043"), 2004797465, "0,002880296;0,43062937", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Sporerville, Indonesia", "Schmeler Lakes, 86318" },
                    { new Guid("bea3147a-fbb4-451b-9fd3-45a5651cd296"), 1086305512, "0,5472121;0,612419", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Simonisville, Bosnia and Herzegovina", "Stiedemann Skyway, 030" },
                    { new Guid("c15e4086-648a-47ed-838b-d150623eb624"), -716468520, "0,10335978;0,50465983", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Sabryna, Cook Islands", "Stracke Walks, 1673" },
                    { new Guid("c1d650b4-fbfa-4b66-9373-d99f67846b82"), 425176261, "0,52841985;0,5664173", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Brittanybury, Tonga", "Klein Neck, 8022" },
                    { new Guid("c485ffea-0794-4907-97e5-dc00d128bc09"), 1254765723, "0,60082114;0,9704387", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Athena, Falkland Islands (Malvinas)", "Waino Mission, 135" },
                    { new Guid("c5903145-89ab-47f0-a2f5-f1f8b4f692b7"), 897474124, "0,8990554;0,9713721", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Danial, Swaziland", "Nathan Keys, 9582" },
                    { new Guid("c831b4db-f622-4481-b747-8b9e5a805112"), 627075130, "0,4029635;0,98165494", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Eusebiofurt, Afghanistan", "Abshire Brook, 23520" },
                    { new Guid("ca76d44f-dcbd-41ad-9691-27eeab4fc833"), 1005335887, "0,3149622;0,91115594", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Estevanhaven, Pakistan", "Elijah Ville, 8799" },
                    { new Guid("cca6547d-d7fc-492d-ab02-1865136a6ac6"), 149977523, "0,46480328;0,958878", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Susannaport, Israel", "Shanahan Street, 0371" },
                    { new Guid("cd76ced5-cd78-4f61-b27f-208b3da12333"), -24371629, "0,26480985;0,8416339", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Stiedemannhaven, Luxembourg", "Feest Prairie, 9404" }
                });

            migrationBuilder.InsertData(
                table: "PostBranches",
                columns: new[] { "BranchId", "BranchNumber", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress" },
                values: new object[,]
                {
                    { new Guid("cdecec89-ebe0-4165-8605-37bd2add10bf"), 1385864778, "0,2097874;0,51345176", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Labadieville, Syrian Arab Republic", "Price Plains, 3281" },
                    { new Guid("ceca5024-bf2a-41d5-b33f-d5a39908bba3"), 693000701, "0,35128927;0,7575386", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Braulioshire, Luxembourg", "Corene Circles, 13736" },
                    { new Guid("d6018212-0e8f-4d07-9882-afb42f07bc6f"), -1611765708, "0,053999163;0,008860245", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Norbertmouth, Netherlands", "O'Keefe Circles, 6374" },
                    { new Guid("dd03813a-f5a8-4387-8db8-006fa63e85f6"), 607850011, "0,15977092;0,8239165", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Cassandreton, Slovenia", "Cristobal Corner, 76422" },
                    { new Guid("dda45740-e79d-4a64-aa2b-b6a63a2ff896"), 350528975, "0,053151585;0,6646339", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Emmetville, Gibraltar", "Florine Port, 8432" },
                    { new Guid("dde0b36b-db79-4298-b44b-45ad1c262837"), 1165796678, "0,34382433;0,43447483", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Alishafurt, Malawi", "Kemmer Square, 3524" },
                    { new Guid("e42dca98-3a11-4def-8a8a-a4daf84b0676"), -396746799, "0,4193084;0,28128704", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Rodriguezview, Estonia", "Schamberger Drives, 801" },
                    { new Guid("e4758d41-cab5-4519-92ef-82bf55ee46c2"), -900796845, "0,8075194;0,7882038", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Sabinaberg, Canada", "Dallin Viaduct, 8485" },
                    { new Guid("e924eb5a-2e5d-4dbd-bd2f-8ff2e48243d5"), 1620769734, "0,44925565;0,7137665", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Weissnatborough, Russian Federation", "Spencer Coves, 3203" },
                    { new Guid("e9d15aab-ce78-4f8e-9610-02b3fb59c194"), 439280740, "0,73309004;0,66555995", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Ceceliaburgh, Switzerland", "Gaylord Neck, 73257" },
                    { new Guid("e9deac14-ad3d-47af-961a-a9f88d91ebbc"), -2044646363, "0,5765495;0,27711517", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Trystan, Tuvalu", "Domenico Circles, 294" },
                    { new Guid("ed2fc7da-d6f8-47d8-8d40-a8534cf0f3a7"), 1601561371, "0,9841698;0,35207137", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kleinton, Italy", "Bins Circles, 816" },
                    { new Guid("ee52d52f-a751-4949-a65d-3c83c0790753"), -1419262842, "0,8294042;0,7877579", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "O'Connerstad, Macedonia", "Gus Field, 276" },
                    { new Guid("ef0c3884-a9b4-4b30-9774-1583c5b4223b"), 1898891635, "0,34889615;0,7080082", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Schambergerside, Paraguay", "Wintheiser Roads, 3999" },
                    { new Guid("f1489a7b-0ad2-440c-92e3-1470f05422b8"), -2140086958, "0,1426376;0,58348113", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Toy, Lithuania", "Boris Camp, 017" },
                    { new Guid("f1cd0938-f151-49b6-8b82-8a95ef1546cb"), 1857123071, "0,6736821;0,19090927", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Bauchfort, Liberia", "Yoshiko Way, 0854" },
                    { new Guid("f4ec1e69-10b9-410d-85f6-01761d35adab"), 150677394, "0,53148085;0,98264027", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Laurietown, Cameroon", "Berge Port, 545" },
                    { new Guid("f50c3da5-3f8a-4018-b2f2-97030d2788b1"), -1180887013, "0,60745996;0,7841771", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Abbottchester, Panama", "Lind Cape, 7452" },
                    { new Guid("fa180ce9-bf3b-43ee-9ada-56a1c596ff5f"), -853749617, "0,47280225;0,81525856", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Codybury, Maldives", "Gutmann Drive, 5967" },
                    { new Guid("fd799de0-afa7-454f-8694-e01bef1c4aad"), -1227115505, "0,32917547;0,2119848", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Vergieberg, Latvia", "Turcotte Spring, 4015" },
                    { new Guid("fe5c7f8e-b9b8-454e-98b1-86c30abca4a9"), -138436860, "0,07845911;0,8638332", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Berthamouth, Antigua and Barbuda", "Amira Branch, 129" }
                });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "PromoCodeId", "ActivationCounter", "BonusSize", "Code", "DateCreated", "DateDeleted", "DateUpdated", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { new Guid("08b2ca0e-6e8e-44fa-863b-cda69fdca4b2"), 480522583, 0.146261074740750m, "3kNoBr7GKvzt3p8gECmhXiVDMH1WF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9408), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9407) },
                    { new Guid("08b31ef2-1620-477f-bb21-ba853dab21da"), 1565278945, 0.005559699532283190m, "LQNqcYCSudet3pPUDLojXWghs94K", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(8996), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(8991) },
                    { new Guid("0c50c751-2e79-43dd-a466-2e3c59164991"), 1148393255, 0.8995571786816680m, "MRbUf3uAStz64rQexhT9MJBw1agPZmVqyd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5816), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5815) },
                    { new Guid("0d8b9abc-f7cc-47e8-8ae0-e2ea08a32078"), -346937241, 0.3723308338231840m, "3vxZa1fq7NW3BkinMyE9GVozDSQwesb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(6005), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(6003) },
                    { new Guid("0d8c0faa-b3ad-4cb0-bc7d-940de74bf3b9"), -1428981703, 0.04265940886094850m, "LhZAdwv4McBUigjG32tQk8CWxomr6qR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5950), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5948) },
                    { new Guid("0d8ed4b0-0ef4-46f3-9bb2-4f18f0835094"), -1090280896, 0.269833619535130m, "3ZgGeNRWXVnyoUxivhcmfY3LCp1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9199), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9197) },
                    { new Guid("0d9856ca-9d46-43fe-9ea4-677ddd4817a4"), -110112976, 0.6020538771207360m, "3FCR5gJ61MTt42EKYvukjPq38XQsUVL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5913), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5911) },
                    { new Guid("14063827-a4e8-45d6-bc5f-094ed7f22830"), -182787249, 0.9285692086132360m, "LSdEW5bx2fthuC1DmN9iKUvc6wLrRGeT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9390), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9389) },
                    { new Guid("1690c4c0-4eda-4a82-9815-cecb6b7e99d0"), 722270306, 0.8119892449318990m, "3HfgJr6bQRi8jyBzauoT1kpCUeN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9640), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9638) },
                    { new Guid("1882f060-d419-4768-a126-ec035fd48db8"), -1673765087, 0.1314260983657750m, "LQRrKAcBTxPJuG1sD5vXEkNfpqhgin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5366), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5364) },
                    { new Guid("1c037b3e-cde5-458b-a54c-f9094fa7a083"), 1848204301, 0.2747372798452930m, "MwQne7gMcm5X8ok3sUfpHRSyCTGr", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(8740), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(8738) },
                    { new Guid("1c775f54-10bc-4141-a154-cb51c2ff1819"), 698319650, 0.1695560397418530m, "MwZ3mzUT2vXcgSnhtJfik794xGA6C", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5869), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5867) },
                    { new Guid("1e2c3b8e-7f5a-4c66-a8b8-f4034b80f3b4"), -1005481610, 0.6997822889113870m, "MTN3c1LhCD5UHsGjXBxnSpJ8ZmieRdQE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5203), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5201) },
                    { new Guid("1f100365-4832-4f01-b908-6dd4017db04d"), -370648023, 0.2843094967294440m, "LNo6ivCBnH8XA4FDrEhsQLxzGpd2c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(6087), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(6085) },
                    { new Guid("1fc78409-012f-461c-b64e-a271a4dd7f97"), -2073110379, 0.2539507769920780m, "3k2unTP8GdsBXhQLWK3vzNM6atyjrC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5288), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5287) },
                    { new Guid("22bd2021-cedd-408d-a684-02403a460238"), -830016870, 0.1522379019969430m, "MRriVh5NYzc3te28dK41B7HxkEC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9465), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9464) },
                    { new Guid("24ea48ae-0c1e-40cf-ae73-10965362255d"), 1597239892, 0.6321694060862880m, "LRNxTrGYmp9cKzsZyBAQShu3d5e7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(8832), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(8830) },
                    { new Guid("26c41653-1498-4950-b0b5-9b9c6a674f7e"), -948377062, 0.4752961385087070m, "La6WjBJ5fgMt9uQZoKGFx23VHrSpTy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(8762), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(8760) },
                    { new Guid("30873f96-94b2-4fad-9a86-935bba4c9258"), 2035109671, 0.633000950223510m, "LzHmFCdRoSaTuDjPvwxVythANfeYck31W", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9181), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9179) },
                    { new Guid("31dddba9-7239-4395-a898-88863d0bbb6b"), -728584721, 0.172877580662570m, "LpH9FW17cwGvJ3ozZ5NVf8dgthMs4L", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9620), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9619) },
                    { new Guid("3a913350-dc74-49f3-9924-b44d17c15f46"), 578814163, 0.09916435662192510m, "3zsp2EXkeBT7WMRvCoFKntAudah", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5135), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5134) }
                });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "PromoCodeId", "ActivationCounter", "BonusSize", "Code", "DateCreated", "DateDeleted", "DateUpdated", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { new Guid("3c435359-fac4-4efb-ac19-8b89092be3b0"), 768732134, 0.2237197955423270m, "MKygBVuFXoG1fEdi9NsY7ZkP6hzb2QxJr", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(8807), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(8805) },
                    { new Guid("455eadb8-3793-48a6-a507-69f94303225f"), -1456845657, 0.1125115381041160m, "MvfiYdZNn5jmyFqW3649euaw1pgxh", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5092), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5090) },
                    { new Guid("4599c57a-7df6-45b1-8273-84c2128d37f3"), -1736944561, 0.2384880930825740m, "LYQTR35AdqV2oUCvjJWyrc7n8ELigz", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5050), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5041) },
                    { new Guid("4858ab5b-5def-4ce0-86da-47223f1d69ed"), -208698652, 0.7846146201605460m, "MvB7FUSgpCRsc2qWdPwkhKG4zn31VbZi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5269), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5268) },
                    { new Guid("4a2d1797-9ad8-41b6-945b-1a8b5611d51b"), -1547730608, 0.8817285982378880m, "35ndaZyt2NASoPcEKxBMrb6F9pH", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5155), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5153) },
                    { new Guid("4a463d92-aa64-4c91-bc1c-1abc98a4d289"), -2145763162, 0.7573235621075580m, "LBTY9A61CVqExjkg3mMrKefLWRoc2iw", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5778), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5777) },
                    { new Guid("4a6c60c9-2653-47e3-a029-aac8e74a828c"), 1541922489, 0.7643747822816340m, "LxrzSM3spUH7EeQw42yVjPnfuB9t", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9042), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9040) },
                    { new Guid("5288414a-5ef1-470c-91c9-f4331a432a6d"), -1862110089, 0.9470829591629880m, "LBJ4PDqGsFukRrf27hX9NwUT5LjCvp", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5796), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5795) },
                    { new Guid("5d68a3b6-5979-47e2-8fb5-71ac27817a30"), 1226278575, 0.2165678065357890m, "36sL3ybXmzfnvptajMSYPc5BWNgukT8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5986), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5985) },
                    { new Guid("5e9f92ce-9cc9-432c-94f5-950e91d62e51"), -1543779748, 0.6335738940398560m, "3GUsFNqcCmbxZQ5Va831v2pRhfBJST7Me", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(8856), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(8854) },
                    { new Guid("64f3333e-672a-414b-b134-9383d3f91503"), 1482893973, 0.3532854871450910m, "3VqrhNZp76g3wE52Cs8X9j1BMtRUKA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5347), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5346) },
                    { new Guid("6a048e5a-5ff7-4426-a1f4-abc8a36e233c"), 1176894050, 0.7168987919130150m, "3rzUhPvsyBeGaVcxw62ofLFubXWCpN5mZ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9218), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9217) },
                    { new Guid("6a75c7ee-c2ce-402d-b253-9c81f00dcc44"), -671272133, 0.1332211278949010m, "LN7mcjg8hdn6tBPyW4vLfDbRxQ3A1Cw", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5893), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5892) },
                    { new Guid("6f505e65-75dd-4ca0-b8a7-91940d9cf35c"), -1508537958, 0.3193775975982030m, "MqNzCMgDshyXjerBobV5iv84FZY9QPkx2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9427), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9426) },
                    { new Guid("6ff76dc7-b17c-4f88-9387-3df586c94efd"), 987346605, 0.359077059754380m, "LwdWH79Nh1xevKmRbizs8SZTo6CQBM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9602), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9600) },
                    { new Guid("702995fd-7543-46a6-9ab0-ad8edb8327db"), 2055494125, 0.9888608704439180m, "MMiRqBZPAvQecoFauH6x7szj8gY", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9527), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9526) },
                    { new Guid("70509b9c-92a7-4f77-88f1-310ffc2bd688"), 76315588, 0.4450104873220050m, "32rePnS5fiGzDNyquwEYMUX4FpTg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9699), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9697) },
                    { new Guid("76b49993-3a26-4e47-8531-a347470eab0b"), 1818714579, 0.1823440614033220m, "MGiZAScWC9KYozRymdHvJ7ErQpMfBP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5481), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5480) },
                    { new Guid("7a7ac9a8-b81b-4bb8-8c8b-d5f21fb15fcd"), -1080860311, 0.09012766417622810m, "3CcGzS7JqxZ2XF4Rmw3EreibgMaWPQB9y", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5835), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5834) },
                    { new Guid("7a9d556b-6f52-4f21-b626-28d2edc40024"), -54093299, 0.3694434571159730m, "ML8QmBPs9GtC57oDSaJxVwRXAebd3HkcK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5183), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5182) },
                    { new Guid("7b0cbab6-a4e2-4f69-8b85-fb727a143720"), 1440332815, 0.2533208759855710m, "M9hjyrsvWnqGR1zCp8giUAMTVbH75", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(8691), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(8687) },
                    { new Guid("7c146fe3-3523-41cc-992d-e8ea012769e4"), 1710249824, 0.3349343023114770m, "3Uci39SRboLhFvZsateVQmq8uBxW1yzf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5325), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5324) },
                    { new Guid("7c673346-1f6a-47a9-b0df-84bd12e8623f"), -930189581, 0.7452731079037470m, "MYoFavgBAXP2RmQqK1C6irHNJ7zVyt95", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9118), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9117) },
                    { new Guid("7c85061c-c0aa-4d09-8b68-4f8ead5e2a8d"), -1079193823, 0.1227742946047470m, "34SU5NCfAg1oYvXutEjki8KPqb726", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5388), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5387) },
                    { new Guid("7ddcd699-357c-4bd7-b5f4-861eb52840aa"), 697668047, 0.3714911666756060m, "LYZBGQL1uoJPjcpwidE3gabKzxk5Ve2t", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(8786), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(8785) },
                    { new Guid("7fcdfa8d-e674-435b-9346-bd58f62882c3"), 948942491, 0.5175453266552660m, "LqLJQwrAn7zVEFiYvaPkbU5CoB6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9141), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9140) },
                    { new Guid("812cd1c3-c210-44b4-b3b7-b996d9332355"), -882446633, 0.3742191982071910m, "LJSrqZVA4Ey3c5uajHoUDwbh9tXk21gKm", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5563), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5561) },
                    { new Guid("83eac619-4cd8-411e-8a4d-d5efa0a4e9c3"), 1068370055, 0.563213529715570m, "3QB9Dx6Zem7hkf5aPAHFr4KYtyX", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9275), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9273) },
                    { new Guid("8b330301-880d-4b0d-9696-fc65139528dc"), 1005440134, 0.6082982735120380m, "MHjtLMNQ6cYdaCSgXzvyJs4KnRkhpGm9i2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9510), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9508) },
                    { new Guid("8e0692a6-22d8-4324-8d6c-788bf9f51a15"), -526768131, 0.9193765247268710m, "MgcTuexJAaPsfkQ1rijh4ByH7RUMt2qvSW", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9448), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9446) },
                    { new Guid("8fedc85f-a8c9-4781-9c27-2bcc40e94cc5"), 1607312291, 0.1485815987649620m, "MJYmreux5DCoPg9Lyb4v3SjwEXAfUpWti6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5116), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5114) },
                    { new Guid("90af310f-96b9-4ccf-ab4b-86fcafb1708d"), 1088099868, 0.0677118531116650m, "LafLYsRVC7cnJZG8iAoSv1X53jT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5543), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5542) },
                    { new Guid("90b74684-2c55-4309-8ad2-0adbb598d26a"), 1758283159, 0.4887821229501820m, "3rBM1RJdY86ZPctH5Lf7Ghgospbyw", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9662), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9661) },
                    { new Guid("9194b69e-e4a2-4716-801e-cf61d0a88979"), 1128496139, 0.4694592480220080m, "36i4jpvQ9qoVZBHUyrDG1AMwsdFaPhS2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(6026), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(6024) },
                    { new Guid("949ca63e-2ef7-4dcd-93e4-e822b2811af1"), 1861773074, 0.1194366775532010m, "3n8iD3c4MA7u6B2SUaKeTdrxqhPFNHV", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5932), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5930) },
                    { new Guid("98d436b3-6428-4b86-9fef-350bccb71602"), -184613632, 0.5480498955086710m, "3meuKVB6qRSpsTnUbha3Cz4ZP52kJYj", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9097), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9096) },
                    { new Guid("99e9d349-840e-40d3-b64f-2d24e112189a"), 1485356878, 0.3350026246387040m, "LRA6aWkNph2US7XoFvJziLnmbwQ8jyYf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5683), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5682) },
                    { new Guid("9ac71479-c162-4968-bf85-adf313dce142"), 1590436794, 0.2254936871032220m, "M9pm23avbqKCk6hRWYDfBsN4MAw", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5408), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5406) },
                    { new Guid("9b22962b-7768-4ca0-81ac-fa4eedef641b"), -1582081774, 0.4371540442917190m, "MNtE1QUXw86V9sipRFcvJ3L2ZMHBgnx4Td", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5709), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5707) },
                    { new Guid("9b62fec8-defa-4e1c-9b8d-94372047a540"), -1118116645, 0.3179365240618250m, "L9x8pWiMqhvDe3wbyuCBUcXSKzYGjTEm", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5426), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5425) },
                    { new Guid("9fe44c2d-f6e1-4080-95bf-1e2c952a06a9"), 911824647, 0.3135576247773250m, "MoD51hiWVCRbKSPNdG6QfqULEYgyjavwm", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(6069), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(6067) },
                    { new Guid("a15cafda-749c-444e-aadb-549fcf55059f"), 434660151, 0.9545663756201280m, "3eZqbpEk7ofd3VrDABgcxj6UsRJhFQP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5463), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5461) }
                });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "PromoCodeId", "ActivationCounter", "BonusSize", "Code", "DateCreated", "DateDeleted", "DateUpdated", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { new Guid("a308a1eb-0eed-4c57-b9b7-328f55222ea2"), 1957642471, 0.02729103092114020m, "MAjwhSVpgHfMa8FNWKeEXr6vJ3kG", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9545), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9544) },
                    { new Guid("a392d48d-270a-4e99-a05d-8ea4e873c4e9"), 1185415661, 0.4684686575782520m, "3X7bV2c61sWz3CdxRTGL8Zg5yPAaqh", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5663), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5662) },
                    { new Guid("a3ff379e-8eef-4462-a849-0e3071956300"), 287432250, 0.2243271711990190m, "3MxnLrhsiZVGwSCfaEWzPdFU2k7DKHJ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5643), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5641) },
                    { new Guid("a41b5b96-a261-463b-887d-584b8217aa30"), 993914390, 0.8182881906937260m, "MpuCVFB2H3Zyr6osveUTQK9xmiSfdEb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9078), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9077) },
                    { new Guid("a622d817-b271-4d4a-a4b0-9e863ee65b3e"), -304056413, 0.2874511146663170m, "L6rDSokT1B29iNHgLzfyqWtCe4JsbPxV", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9255), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9253) },
                    { new Guid("a9e8d10d-694b-416a-ab14-8ade88403596"), 1623284788, 0.3265447220967820m, "LKDP2LgUE1hZ3Wqxy7GCHFu5MmakwS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(6049), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(6047) },
                    { new Guid("ab39520a-2baf-4219-b2fc-dd1120bbd661"), -42883394, 0.1679302896126950m, "3cEdZA6tps4eTyqJBRNLMUW9uiHV", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(8875), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(8873) },
                    { new Guid("ae924223-a3bb-4c17-a933-2a8a62531cc4"), 1715729720, 0.4976896719520270m, "MvAKxaZFQtqMpVXjTJ1WhD48wEN6mSB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9736), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9734) },
                    { new Guid("af154077-a12d-45cc-bc90-9cd00b9314f2"), 549252192, 0.4297577629567060m, "Lk3e5rJyL92XBxZuihwtWTYRn1jdNp4A", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9564), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9562) },
                    { new Guid("b49564fe-ee40-4e50-a560-417b89aa0a1d"), -744709657, 0.1940137861804650m, "Lpm82nFkwTAX3bQurVHxcE17zs45DydtNY", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9584), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9582) },
                    { new Guid("b8026a94-81fd-48b2-ad1a-1b7a2c2c70fe"), 1872820195, 0.4858576614929690m, "MPevJDC4gaXAiMVwfkysWK3Zh96", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9485), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9483) },
                    { new Guid("b841c6e7-ded8-45b0-900a-4ae90f49fc1b"), -1437784902, 0.7149790492212860m, "LW4CQZoveKSVmqFP3DJMgjER9baiucz", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9348), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9346) },
                    { new Guid("c6d9f639-a66d-4ed1-a88e-d30f30c8e140"), 777827958, 0.5715034965181050m, "M6XGyoQRiZ15xtnfuWAEjNcL8Pz29d3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(8912), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(8910) },
                    { new Guid("c73af1ab-df3f-4b31-8eff-6efa69bad81b"), -1197292988, 0.837069219791660m, "MsfqP2rmkQcZ9gH5xiBKpVU7oyDeNCwSdJ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(2219), new DateTime(2024, 6, 2, 16, 40, 26, 762, DateTimeKind.Local).AddTicks(9210) },
                    { new Guid("ce568648-c15f-4a32-850c-2a0b6e4f01ed"), -122214434, 0.4835334609925730m, "3Qeq8CRT7rcM1zBNhPJLGs5YiSym", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(8951), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(8949) },
                    { new Guid("cee31fcc-0d6b-4cc0-b361-21ef998f97cb"), 1451399820, 0.2612286491413990m, "3MBeKPqx4k3wVgJoH8S6nYWtiEsC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9024), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9022) },
                    { new Guid("d10ddb0e-c9a3-4478-abfb-78d3125ca197"), -1462740335, 0.5136922595253910m, "MC8aR7JmjB6b5DX2Eidr4NUPFhQkyzAH", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9236), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9235) },
                    { new Guid("d1e822ac-98c8-4a6a-b598-efa18d6592c5"), -2058470426, 0.4483309678787930m, "LMoJuVdL7EvZCaBFfsqYmTinKebP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5249), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5248) },
                    { new Guid("d351d329-b5f1-4c97-a8f3-37f91a5f87fe"), 641082969, 0.912059579752230m, "3eQij4u2HVP5WEmRK3fkqLX8cUy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9059), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9058) },
                    { new Guid("d4e748b8-03ab-4231-b143-ef574621e7e2"), -862485252, 0.3398088040283850m, "3kzJcj49BhCNGwQdSY8vHXseAiu12Rmtb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(8970), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(8969) },
                    { new Guid("d6d866d9-2aae-427a-beba-749fed4f175f"), -59156798, 0.3278117991166320m, "LC6SDL1mK9JMwEk3tHs8rBvGiZQ4upe5d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9161), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9160) },
                    { new Guid("d85d925b-972e-442f-960d-cfa350253177"), -1186546801, 0.9663668940936310m, "MakFfrRdZjhGHyASw4se6Ugz93pN2EVLt", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5619), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5618) },
                    { new Guid("dbe763ca-5cdc-4cc0-b26d-a6edc0e3789d"), 399596481, 0.8162109038092690m, "MnyJdLKrSzWTM4UgemB6hfNsow592", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5759), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5757) },
                    { new Guid("dc4f740c-8bb6-4519-aaa1-c36613fb9250"), -455423317, 0.970040106855790m, "3djV451CUN8JWo2mGZkQuiqfDALP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5444), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5443) },
                    { new Guid("dd3503f2-29b5-42d0-9fb4-6543eb1f4b1b"), -892006728, 0.108625325157220m, "LfeJE1iagN2W9jA58sL6cVRTuKySbXYkU", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5582), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5580) },
                    { new Guid("de126c9e-a18d-429b-839d-e9ab9549d6b7"), 873006766, 0.9639500352055890m, "3MbGzCdJtLX2v4mxT6fwa8YWyZE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9716), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9715) },
                    { new Guid("ded79847-9fac-4d19-93c2-a360b472769e"), 1316878729, 0.9005185276421910m, "L8s7GqMJRnVQpPvoeycT3hK5CwSLxf4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9681), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9679) },
                    { new Guid("e274d291-f77f-4e42-9fe1-952545377169"), -441767132, 0.5241073643811870m, "3toc4nKEwWyY1JTUvPgbV53m7dHBLeiFC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5521), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5520) },
                    { new Guid("e8934bbc-f09e-4bc9-9d48-8fbb9ea99395"), 1560345909, 0.1813037775455620m, "LPy2BkNE873q5mnXeAZQRuYiW4pGVgx", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(8565), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(8509) },
                    { new Guid("ea2337cc-2949-441a-b624-830942dc6e36"), 641018912, 0.709660391136910m, "M4HWLvGpjuZkBgD2Kxyn6JMVTEqYt", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5502), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5500) },
                    { new Guid("ee55d0c5-5bca-4ebe-a32c-5e0e57116dde"), 1844749748, 0.9454914570464990m, "Mt8YjFKWLR2bZP9m1ATw3ouB6GnM5Q", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5968), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5967) },
                    { new Guid("f033bbdb-e676-4be2-bf14-a9799258a801"), -718933446, 0.266285448082970m, "L3JB6rWvounQwVzFh4cdRtsqTPe", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5306), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5305) },
                    { new Guid("f0d33a87-e7a5-4a75-aed8-3102cc98d02e"), 1994963818, 0.0865422767898450m, "LdeEWDYwfvNQk8gjGcTK9A26szF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9371), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(9369) },
                    { new Guid("f502618f-b378-473d-bd06-c6ad857cf16e"), -226362359, 0.5703586749258470m, "LUZG6TksVCFieL8AfDz2mu3gdMKc45R", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5600), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5599) },
                    { new Guid("f80a099f-4669-4b98-ac36-0a3c02cee3f5"), -1908332651, 0.505700581290730m, "LokKtFM4pxbzCHysEfrnVDLjG7W", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(8930), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(8928) },
                    { new Guid("fc70539e-8d04-4328-a070-f624967410d9"), -43826674, 0.8161109996672760m, "LVu4eWUf2EX5AoJxnpHvtqKjwsbLriDz", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5229), new DateTime(2024, 6, 2, 16, 40, 26, 763, DateTimeKind.Local).AddTicks(5228) },
                    { new Guid("ff08cf81-ddad-42d5-bc74-0227f4d4a194"), -1601498473, 0.006538450092799850m, "MA8HS9cmKeC5gYUD1FV6XPJudkr", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(8893), new DateTime(2024, 6, 2, 16, 40, 28, 771, DateTimeKind.Local).AddTicks(8892) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("01424fda-76cf-4203-995c-a75e43c1d1d0") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("02a17a84-0a35-4164-b872-e030d586b6fe") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("0447d1d8-3e48-4d64-8d2e-7d9a733628ec") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("0447d1d8-3e48-4d64-8d2e-7d9a733628ec") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("0635daf3-649c-437b-92ef-713d43246a0a") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("06f4c32b-9a3d-4b38-99a4-56ea0ba685a8") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("0773e360-956e-4d39-94c5-d0906a9e4557") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("0773e360-956e-4d39-94c5-d0906a9e4557") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("0776f148-3954-48ff-8bb8-772d353c1a3c") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("0776f148-3954-48ff-8bb8-772d353c1a3c") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("07e77ffa-7983-4cb3-bfa5-a4b8ed39f91f") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("080ced29-2e70-40de-82e4-0a2d478fe53e") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("08589d86-24cf-48ee-b140-eab54649e215") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("0877dbd6-c025-49ef-b189-53b217500382") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("087fb413-124f-47b1-b54e-4bdedf2edf63") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("097cb7d3-d333-48aa-b8ee-cacd11ee91fa") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("097cb7d3-d333-48aa-b8ee-cacd11ee91fa") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("0a1370d0-5d3b-4609-9efc-9507f4acc2f8") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("0a1370d0-5d3b-4609-9efc-9507f4acc2f8") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("0a8fb680-a380-4d35-85da-ff3cf9faa245") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("0b65bf95-8c8c-4e28-8317-122f0f66a78e") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("0bf479c3-ab54-4392-b19e-a71b3942b7fe") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("0c66002d-25be-4864-84e7-acd6fd765b27") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("0d230077-5e9b-42d8-a83a-650a22378849") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("0d230077-5e9b-42d8-a83a-650a22378849") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("0d6ec0b6-076d-4fc4-8519-424b1c8bf28e") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("0d88a4e0-8366-4547-8ebe-087d4c74b34f") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("0e6930e6-cf0a-4195-8d74-a9cc0dfb30b6") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("0e7742f2-e964-4e8c-b692-4ffb75ece318") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("0ec010bc-7e48-4cb9-bb93-8dd9d5b37f6d") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("10766e70-305e-4e2a-8560-ffeb596a93eb") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("108fbff3-4041-4eed-b2a0-4a4b1fb47787") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("1154bb55-7f7f-4d91-8347-5797ffeacb13") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("1154bb55-7f7f-4d91-8347-5797ffeacb13") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("1381d1cd-5c11-46c1-bc37-987b3f5ae33e") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("141e6ca1-3b19-4ffc-a21f-8420c3f6db52") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("141e6ca1-3b19-4ffc-a21f-8420c3f6db52") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("182bd5c0-616f-4e9b-8837-7c2b67e01496") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("1937fdf7-97b0-4102-95c9-2163eb910112") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("1937fdf7-97b0-4102-95c9-2163eb910112") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("1a21f215-231c-4e09-b7c2-4e3163978286") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("1b1ebe07-5765-4728-8b40-ee14061347ae") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("1bab23ea-659b-4531-ad24-fdfd8984675d") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("1cdde210-cf9c-4b69-a64c-3995a2267739") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("1e17494c-b19d-4879-af0e-c6575db6bd37") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("1e17494c-b19d-4879-af0e-c6575db6bd37") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("21d9b3f2-945c-40a1-a0ca-7b6fcbe38a4e") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("22edc826-6747-4099-aca5-578199353ac6") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("22edc826-6747-4099-aca5-578199353ac6") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("230e73b5-4a4b-4b1c-ad48-f7a0074303c7") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("23e8131d-ba45-4488-991d-941eca3fbe0a") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("2411a1da-d71e-4e02-a40e-984ec689c7bd") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("2411a1da-d71e-4e02-a40e-984ec689c7bd") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("2476b4fb-aceb-40f6-b636-80dd269d535c") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("25c234e8-8d95-42b3-9dc3-c418fbcaa7da") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("25c234e8-8d95-42b3-9dc3-c418fbcaa7da") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("2700d101-47ef-4c75-a3e1-b613514a94f0") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("2700d101-47ef-4c75-a3e1-b613514a94f0") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("2b5f8a6c-d3e8-41ff-8867-cadb6cd16ea4") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("2bdbd536-e4dc-4869-9dac-f62a098ecb05") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("2bdbd536-e4dc-4869-9dac-f62a098ecb05") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("2c87eaa4-8e07-41f4-bad0-935d07541e78") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("2c87eaa4-8e07-41f4-bad0-935d07541e78") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("2e3a99a4-4308-410d-b67e-4763bbd6b9c8") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("2f8c0b43-80b3-437b-8a84-a763ed30230e") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("323967f9-cf4e-4818-a5bf-94dff7ea728b") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("32feb777-af06-4813-9108-9d7acfd0bd04") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("3314d8f7-2262-4e19-afd4-3e85972480b8") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("335c9d28-42e2-4d49-9686-f0cd1b972fae") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("335c9d28-42e2-4d49-9686-f0cd1b972fae") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("34e9aed1-9d94-41dd-a50e-2e11424b25e1") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("35275876-97ec-44a4-8503-f21c815c9a45") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("353c126e-57f5-471a-b13f-0e4fd4cef2fe") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("353c126e-57f5-471a-b13f-0e4fd4cef2fe") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("3585370e-fea3-4a31-9a6c-93267371cc1d") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("36ffb969-580b-40d2-8fa0-94749ea99214") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("3712e35b-2da9-4c76-ad88-28828e776a5c") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("3712e35b-2da9-4c76-ad88-28828e776a5c") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("394e6c37-a398-4cf7-983d-8fb216e6c46f") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("394e6c37-a398-4cf7-983d-8fb216e6c46f") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("39d27a82-05d2-4135-b53b-53748eefd4f2") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("3a19b458-72b3-4b5b-97e6-334a56d7d557") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("3a19b458-72b3-4b5b-97e6-334a56d7d557") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("3a262ff7-1654-4c72-9285-3ba10eac6509") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("3a6fda52-d9f1-418c-8ffa-69974f7f39be") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("3b3e9016-3025-48e3-93b2-fa474015c0f7") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("3b3e9016-3025-48e3-93b2-fa474015c0f7") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("3c3a765d-c1b9-47c7-b39a-7b5dc35e1cbc") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("3c3a765d-c1b9-47c7-b39a-7b5dc35e1cbc") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("3ee0e809-4d8b-4164-a824-c5ab67903af7") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("3f1a1c74-7f9a-433e-808b-f0d69f6d97e7") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("3ff3d88e-b078-4f3a-8312-8447eeb772e2") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("3ff3d88e-b078-4f3a-8312-8447eeb772e2") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("405a5eb1-aee0-4578-8748-2d8b5a6b0d57") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("4083c32d-a4cd-4c70-b794-fa7b97aafe4e") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("40a279f6-73dd-4fa2-8b1e-05f9cd8bdcf9") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("40a279f6-73dd-4fa2-8b1e-05f9cd8bdcf9") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("4188ab2e-f46b-4cf6-b460-560a914e5d35") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("4188ab2e-f46b-4cf6-b460-560a914e5d35") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("42babbec-5dbe-4cc3-9f68-bb4bc7ad9491") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("42c4353e-7775-4c68-a647-2b921bb87c89") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("46542d6d-04cc-418a-88b4-cda40f4aff48") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("46843658-5438-46a9-b26a-f6c2fcfd1883") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("4732299f-418c-4c2e-ac09-aacb3b2c8976") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("482632b6-5f62-4fe4-82e0-1b6f0d3ee842") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("487efc58-2d93-4b91-a4fb-1ce1d3ef038a") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("487f0344-4cde-4b10-971a-1f8311cce3f5") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("48b3cd65-be2f-4be1-a3c5-d88da44b3d73") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("48b3cd65-be2f-4be1-a3c5-d88da44b3d73") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("48f4af12-c8b0-4444-98ca-81df5d349e01") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("48f4af12-c8b0-4444-98ca-81df5d349e01") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("496d8ed2-fc6d-49e6-b902-8a1d0b266928") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("49ef4ccb-eb29-4ffa-bcfe-88759ac3f1c5") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("4a9e17b4-cb0f-4c82-80d2-e1d56fe06f0a") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("4a9e17b4-cb0f-4c82-80d2-e1d56fe06f0a") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("4b2a14c5-b9ad-4e45-ae16-0762e7d1e215") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("4b45c810-f446-449d-8b0e-4a2ebbbf7104") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("4c5d0085-4956-4748-b989-09b4d927d669") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("4c5d0085-4956-4748-b989-09b4d927d669") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("4d006d0d-8a50-4d81-886b-176313d018fb") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("4e8c89c0-a2fb-42d3-8d7a-11fe5d3b6d75") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("4ecad1f7-2b37-4dd8-be42-dedd60205e81") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("4efd0f6e-db18-4603-b7c2-f032eb9132a9") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("4f42e5ab-642c-4775-b2b2-a116ecfcd663") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("4f42e5ab-642c-4775-b2b2-a116ecfcd663") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("4fdddaf5-83dc-4f45-ad82-fcab10f87405") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("50ac14d1-c13d-42f2-8026-301c38b1964b") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("50ac14d1-c13d-42f2-8026-301c38b1964b") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("50b1b40f-32d2-45da-a690-b9d24fff476e") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("50b1b40f-32d2-45da-a690-b9d24fff476e") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("50fa1a40-d4af-4edd-8c00-61ec693395b2") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("530579fa-33a7-4827-a21f-b9cacab42c7d") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("530579fa-33a7-4827-a21f-b9cacab42c7d") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("539c62ee-15fc-4d37-ab5d-0e4126109954") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("539c62ee-15fc-4d37-ab5d-0e4126109954") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("548e47d4-b851-4432-8514-fc092768db5b") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("54c975d2-dbfe-4626-97fa-ceaa28e85030") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("54c975d2-dbfe-4626-97fa-ceaa28e85030") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("56234ad9-accf-413f-8d2b-5d6fb1cd04a1") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("56b8dced-e510-417c-8b93-8a2cb06b845a") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("56c8b4b0-c1db-425e-a349-2f7b3feabb5e") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("56c8b4b0-c1db-425e-a349-2f7b3feabb5e") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("57b666b4-3a1b-4303-851f-a88f5f534543") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("57b666b4-3a1b-4303-851f-a88f5f534543") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("59a9232d-40d9-422d-8a1a-fe022e85093a") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("59a9232d-40d9-422d-8a1a-fe022e85093a") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("5aff4312-b9a9-4958-b14a-305be3aa9f4b") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("5aff4312-b9a9-4958-b14a-305be3aa9f4b") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("5c5b9127-2aa5-4ed6-b779-6402154d5c0f") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("5c5b9127-2aa5-4ed6-b779-6402154d5c0f") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("5c6a10ae-343d-47fa-9381-6cbe7b1a68be") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("5c6a10ae-343d-47fa-9381-6cbe7b1a68be") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("5d1e2a88-0f0a-4b6e-a524-e279224a1944") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("5d1e2a88-0f0a-4b6e-a524-e279224a1944") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("5d203345-c58f-4236-9e46-c9ba7a8529a5") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("5e1f9cf6-8e77-46be-92e7-b3f10da0ed86") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("5f366c1b-9e38-4bc9-b773-fca63347cbcc") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("6101631f-7cf2-4393-a938-099c07dbe44b") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("61dcb7dd-eb57-4421-b814-6cd202b0f4a1") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("6218849a-9af3-4ab0-93d1-f5fd29135491") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("63107baa-d978-4764-b959-7e90a1de3ee0") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("64174d68-43d3-488f-89bf-23d32b134019") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("64e0a0ed-41a2-429f-800b-6407610d5984") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("652ba8ca-0eee-4fb2-a548-4621f2c8de0b") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("653800c1-b55d-4636-99c0-ea31223d7e3b") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("658f3ddd-678c-4dca-b9fa-45901c0f1c05") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("66da7f26-36d5-4406-a2e4-35363c8e43cb") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("672ce079-171b-4f7e-b744-6b9376e96b61") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("672ce079-171b-4f7e-b744-6b9376e96b61") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("67a258f9-5c48-4651-8f32-1ee7f5b4246d") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("6ab8f9db-6513-4d8f-9cde-7b925ff51057") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("6b5cd903-9056-4302-b3e6-b910c3a67f76") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("6c16f159-98d6-4d70-a7ac-43b19b827d49") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("6c3e0836-290a-4c10-8832-91720a2e9054") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("6c3e0836-290a-4c10-8832-91720a2e9054") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("6c3f8b98-7095-4d12-8f55-02b23a300d5f") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("6ef84803-7ff7-46d1-b1b3-ebda82e158b3") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("6ef84803-7ff7-46d1-b1b3-ebda82e158b3") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("6f109fcf-941c-474c-810c-243f75df54d6") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("6f196aeb-f350-478e-a23f-992b0ea6da29") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("70d04e87-92ed-4410-96a6-934a82c8bbcb") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("718a03a0-2841-450f-a417-5345b18c81ab") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("718a03a0-2841-450f-a417-5345b18c81ab") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("719d1670-ba7d-4e9b-b4de-d7074f81aa66") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("719d1670-ba7d-4e9b-b4de-d7074f81aa66") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("71f7fb3b-e7f1-4325-bdd2-98f71dd515b1") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("71f7fb3b-e7f1-4325-bdd2-98f71dd515b1") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("72a42c8b-ed7c-4e7a-81c6-313cac897b20") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("74ef9233-8d34-4883-8938-b78b6c147246") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("74ef9233-8d34-4883-8938-b78b6c147246") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("753e85fe-b18a-442a-b91e-1d9dc9216d93") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("757f3f70-fdce-4727-8fcf-9ac8aa0287b3") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("757f3f70-fdce-4727-8fcf-9ac8aa0287b3") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("75ba16eb-aa9c-4c6f-90ae-1515360055a9") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("75ba16eb-aa9c-4c6f-90ae-1515360055a9") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("76c44275-2d3e-43e9-b34e-c05f912213b8") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("7778b4eb-db56-4ddd-a0bc-5f46aff077f7") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("77bc83c5-7598-48f0-b4c1-23f76fd277ca") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("77bc83c5-7598-48f0-b4c1-23f76fd277ca") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("78be92c8-3390-4d5e-aa3a-54c7301eaf2f") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("7a52231d-ba53-47d6-8382-e5bf5f9e7e24") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("7abaa815-d503-4740-a0a9-20d8752fc2cf") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("7c2f2e0c-1d40-453b-84ea-f5f09cb10d28") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("7cf58058-5eec-4c6e-a4ae-cf50ccf0b2ac") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("7da75a84-c857-4768-9ff2-252052ea5333") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("7da75a84-c857-4768-9ff2-252052ea5333") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("7de3e658-53a0-464d-a4aa-b7bf40828f5d") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("7de3e658-53a0-464d-a4aa-b7bf40828f5d") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("7e4a74cd-b47b-47e6-ab98-22ed32bd8e27") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("7e4a74cd-b47b-47e6-ab98-22ed32bd8e27") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("80c8c606-5918-4559-bdbb-606d564f96d5") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("815c5bf5-7253-492e-81c8-82e2d6860602") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("815c5bf5-7253-492e-81c8-82e2d6860602") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("819538c4-628a-4b17-a719-8274b53093f3") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("82b99640-3f2e-425b-a088-51b3c226a192") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("82f7ffb4-bdb1-40a8-8d2d-67f1c2f5bf91") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("831f8f9d-e78d-4f72-8b48-1c32c42fda1b") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("871feb78-0a5f-4d88-8754-a386270f590d") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("8867eb2c-20d1-43a8-8081-18744798ef5a") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("8a696f30-76c2-40db-a250-030829547d67") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("8b3afef3-3bbb-4237-b8b8-1eba1df7757e") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("8b3afef3-3bbb-4237-b8b8-1eba1df7757e") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("8be01b71-4060-43ad-98a5-2c0730fd003b") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("8bfa284c-faeb-4fb6-909c-2a2ea4c8745b") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("8c060e9b-2ea2-4602-8535-ce147e60fcbd") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("8c18ec85-46f2-44b0-bd0b-56adb1bf7743") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("8c30b7e6-1da3-4a5c-87ba-544b9377a290") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("8ce72c63-9c31-4159-9ba2-012a4fc3df72") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("8ce72c63-9c31-4159-9ba2-012a4fc3df72") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("8dca8632-b27c-44ad-bd6c-0d7679a4f075") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("8dca8632-b27c-44ad-bd6c-0d7679a4f075") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("8e3d5153-23be-45f9-83b4-5aecbb1a4322") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("8ea935b6-2c30-4bef-803c-9f382789979b") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("8ea935b6-2c30-4bef-803c-9f382789979b") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("8f35c799-d964-48e4-9cf8-befb4f9b7bf0") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("8f876cca-154f-4381-adab-41c9e894d046") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("8fc5f8c0-3711-4486-8ea0-48697b9ea01f") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("8fc5f8c0-3711-4486-8ea0-48697b9ea01f") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("914e0b17-40ab-478d-ba2c-61856d240679") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("92a5d027-0cfb-43ec-84b3-d812837c5654") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("92d6cbc1-d409-403c-b274-517d31726ae9") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("93e9e8fa-8b76-4968-a1ef-a4d59b6958ea") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("94c09a0c-18a4-40c8-9285-032386267d16") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("97e11482-d5e6-41d7-82e3-80806df9c3bc") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("97e11482-d5e6-41d7-82e3-80806df9c3bc") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("980189d0-dcc8-4676-93bf-39ec81288e2f") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("99d3bf2d-5ff0-41e8-b115-9bf94eab6881") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("99d4724f-46db-42d2-a62b-3d8fa528e130") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("99d4724f-46db-42d2-a62b-3d8fa528e130") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("9b254af5-9da3-4b42-a5f3-b573df408d84") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("9cf1e944-d004-426c-83ee-acb2b8793bc6") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("9e39f449-ecbf-4238-8ca8-47309c134789") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("9e96d314-cd64-47aa-a5bc-7e0525cc9914") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("9e96d314-cd64-47aa-a5bc-7e0525cc9914") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("9ec54876-333f-4825-9959-c839395cb66e") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("9ee8d8bd-022b-4718-b8f4-cc38174e988c") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("9ee8d8bd-022b-4718-b8f4-cc38174e988c") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("9ff0a0ca-02d0-4209-bb8f-a0d7efaf75bb") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("a03e50af-2ee0-4392-86e9-a0420b2f24bb") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("a2c81266-ca25-4e08-bddc-c6ccfe9435e2") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("a419df27-9358-4a02-9ab7-2f2e2344fae0") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("a5276d46-3296-4c05-ba31-d2ebddfd8a57") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("a59d873d-ae08-427c-b25e-29c55895239f") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("a59d873d-ae08-427c-b25e-29c55895239f") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("a6a8eca4-cb2e-43f7-9ea2-cbc644c8f9d8") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("a780acfd-e10d-4dc5-a383-1ba56a91e666") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("a780acfd-e10d-4dc5-a383-1ba56a91e666") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("a9090dd7-3795-48e2-837b-9a72a0274d7b") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("a943e809-55d9-482f-a592-8709b5f7d47f") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("ab451099-7866-44e4-9ebd-f1162ea6206a") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("ac4ee7ff-56c7-4c45-ba3e-32ed6d9370f3") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("ac4ee7ff-56c7-4c45-ba3e-32ed6d9370f3") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("ac5a7dc0-9da2-4c23-9acc-ec9828404cd5") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("ac984856-387b-48de-9d39-5cfa956d354e") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("adbbd240-641f-475b-b705-5e35298ef012") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("adbbd240-641f-475b-b705-5e35298ef012") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("aeae0f68-579f-46b8-bee2-c797ee09ee5e") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("aeae0f68-579f-46b8-bee2-c797ee09ee5e") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("aec475ab-9ab8-4f55-8794-ee1ffc6f6da6") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("affd1717-742a-4014-8e72-3420c7496c1e") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("affd1717-742a-4014-8e72-3420c7496c1e") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("b1817475-7a6c-44d8-8e81-4b59b1f4923e") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("b1817475-7a6c-44d8-8e81-4b59b1f4923e") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("b21ce16f-bf5c-4cfa-9fd4-9b67014eadbb") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("b40d8226-58de-4e86-811d-0e6b38686d57") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("b53497b3-fabe-4282-a5c6-ef6e82864309") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("b5cca55a-d81f-47be-b0b4-50d07e79ce69") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("b8e5286e-6ec4-4001-89c4-e17065f9bf09") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("bbaf9fe2-9863-4589-964a-23c62e6bf830") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("bbaf9fe2-9863-4589-964a-23c62e6bf830") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("bbe91897-98e6-4c1e-aef5-09cd3dbb35cd") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("bbe91897-98e6-4c1e-aef5-09cd3dbb35cd") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("bc7c70fa-9300-4c06-afd7-8aa97fcf9993") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("bd07490e-79db-4063-b992-0fa27e7f7677") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("bd349cb3-f696-4e78-9355-45b8b4f7385f") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("be0a8a82-f1fd-45d5-8523-5b32db6fc767") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("c0ff772c-b38f-4860-9c1e-4c49d424f9a5") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("c221f46b-a606-417e-aead-c8b255d84d11") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("c221f46b-a606-417e-aead-c8b255d84d11") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("c2701daa-7747-422a-bb74-d9ffc8e0f5fc") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("c36bd526-4a45-4a4b-9d0e-50c279e9b939") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("c3cc5785-6364-48fa-bb83-e7ac33fc672b") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("c3cc5785-6364-48fa-bb83-e7ac33fc672b") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("c40f9fee-6298-4137-bc78-c74409dec92f") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("c5513371-ea13-4b3b-ab65-8bbb471b2afc") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("c5513371-ea13-4b3b-ab65-8bbb471b2afc") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("c58f524e-a96e-4e8b-9186-6c21d38d64b3") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("c58f524e-a96e-4e8b-9186-6c21d38d64b3") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("c590f92c-3ca1-4a33-a976-926995a0f7cc") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("c5efb9ab-d786-43d2-9595-c90aedaedb9b") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("c66d96b2-e569-4470-a3b9-82ba83e46c97") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("c66d96b2-e569-4470-a3b9-82ba83e46c97") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("c6e8a5d8-6660-4e85-9ff9-1e6ec6d0c580") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("c6e8a5d8-6660-4e85-9ff9-1e6ec6d0c580") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("c7c0cd55-07d8-41cc-9d2b-4bd04cb7edb3") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("c7c0cd55-07d8-41cc-9d2b-4bd04cb7edb3") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("c7f42761-e210-47b4-9e39-2df36dce4c96") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("c7f42761-e210-47b4-9e39-2df36dce4c96") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("c88c725e-8cbf-416d-a4bf-153a024ea6c9") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("ca127dc1-765b-47e8-87ee-ebc90ec70a73") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("ce7719fc-1874-4df0-88ba-9b5637945029") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("ce7719fc-1874-4df0-88ba-9b5637945029") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("cf3285c8-97d7-426d-87f3-e0854194e226") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("cf3285c8-97d7-426d-87f3-e0854194e226") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("cf348fa5-7d32-48ec-957c-eb481beb0358") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("cf611bf3-21fb-4ed7-a138-00c7afdda9ba") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("cf611bf3-21fb-4ed7-a138-00c7afdda9ba") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("d0aae9a2-8c5b-48e9-b856-e309c80cadae") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("d0aae9a2-8c5b-48e9-b856-e309c80cadae") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("d1d503de-e688-46df-9a53-6ca07b1d716f") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("d29932a8-80f8-42b1-85e0-6bf810161455") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("d3cba19c-d75f-49cd-8bce-3e5563428a3a") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("d40492c4-d582-4ce6-943c-a487675b7960") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("d43ee797-d0bc-4a3e-8833-c45e9d340f44") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("d43ee797-d0bc-4a3e-8833-c45e9d340f44") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("d57e07f1-63a6-4514-ae7a-51f83c901e2c") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("db32027d-cf9c-4544-af7d-d20c917925c7") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("db32027d-cf9c-4544-af7d-d20c917925c7") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("db91ddfb-75b6-4d51-82ea-52631a102b16") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("dbc51236-052c-4c31-820d-b0a01a143d1a") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("dbc51236-052c-4c31-820d-b0a01a143d1a") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("dc2b5eaa-01f8-425c-874d-15e523189cc1") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("dc52bf7b-d952-45c3-8bf0-44dadbfbb09e") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("dc5f8e5e-be11-43f9-acd2-648e38e09946") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("dc5f8e5e-be11-43f9-acd2-648e38e09946") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("dd550cd7-4eae-4d75-8be5-5f3e496fdd24") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("dd550cd7-4eae-4d75-8be5-5f3e496fdd24") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("ddf2bc3e-21a3-4bd8-8ebc-4afb8cb49df0") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("ddf2bc3e-21a3-4bd8-8ebc-4afb8cb49df0") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("de7e4623-27a6-4a10-8c19-1f8ae8f689d2") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("df1ba0e6-99b8-419d-a3b8-cece7c4928bd") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("df1ba0e6-99b8-419d-a3b8-cece7c4928bd") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("df3cc97e-5297-4426-8d73-6ec8a1d6ff19") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("df3cc97e-5297-4426-8d73-6ec8a1d6ff19") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("e2db5e4a-dcb2-42fc-b56b-17a4692bd0de") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("e36aac18-179d-420c-8aaa-edf7ff736e50") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("e41a0e5f-468e-496b-8fe7-b8f4b2a0f962") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("e5406e78-ce40-43ee-8dee-e58fe7687eb3") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("e5406e78-ce40-43ee-8dee-e58fe7687eb3") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("e5fa7b3b-6d8a-43dc-88a3-403aed558476") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("e764f5ca-90fe-4d60-aab1-e56e02a1f110") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("ea848f07-5360-4e76-ac1d-cf046366d4ef") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("ed1f5061-44e1-4df4-b0de-bc0c17fd0185") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("ed5c634a-32ee-48fd-80f4-26cfb1c72602") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("eeb82343-3a6f-48ee-b791-709692ceea7d") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("f28f3fdf-fa90-4b58-895f-89b7f89e53e9") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("f2c5c231-fa4f-4403-a17b-f986cd15543a") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("f3cb510a-8243-4204-8c1f-ace56610d45f") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("f4c8c27a-6b37-469c-9492-061adc476725") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("f4c8c27a-6b37-469c-9492-061adc476725") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("f51931e0-68b3-4aed-8f03-7ef9a8526650") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("f5fa9239-e966-4c8e-9eb5-32ecf277976e") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("f630d90d-3329-4958-99e4-34aa2f69436c") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("f7082ecf-eb66-429e-8a3f-72fac7d7b453") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("f7dacdb6-cd5e-4c55-a2df-710f582d75f2") },
                    { new Guid("6630aea3-a165-4f1e-9752-15729334407d"), new Guid("fcf05f51-7f3a-4331-a0f5-6204db62e7ba") },
                    { new Guid("e2552191-72c8-4ad1-907a-a80a6b5f1125"), new Guid("fcf05f51-7f3a-4331-a0f5-6204db62e7ba") },
                    { new Guid("d59180bb-6713-4395-8483-45abe04eaddb"), new Guid("fe7a3052-1ad9-4450-b9d5-057c6abe9c2e") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("0033c1dd-358d-4f05-a13c-3b2e3c95a966"), null, null, "Colleen43@gmail.com", new Guid("affd1717-742a-4014-8e72-3420c7496c1e") },
                    { new Guid("005c10b3-dd13-41ce-b8de-cc71fd334503"), null, null, "Beaulah28@yahoo.com", new Guid("a59d873d-ae08-427c-b25e-29c55895239f") },
                    { new Guid("00f6b456-e5dd-4e9a-820c-9a4e3d7e2208"), null, null, "Marietta_Terry69@gmail.com", new Guid("f7dacdb6-cd5e-4c55-a2df-710f582d75f2") },
                    { new Guid("0105bf83-9c67-49d2-b86c-84c7dbb3c549"), null, null, "Ramon86@hotmail.com", new Guid("dc2b5eaa-01f8-425c-874d-15e523189cc1") },
                    { new Guid("018ba3f7-f961-4ca8-8d75-b1c6f63d0ac6"), null, null, "Moises34@hotmail.com", new Guid("ca127dc1-765b-47e8-87ee-ebc90ec70a73") },
                    { new Guid("01a08449-2890-40fd-9b3f-8fac1181fcc2"), null, null, "Samanta53@hotmail.com", new Guid("0776f148-3954-48ff-8bb8-772d353c1a3c") },
                    { new Guid("01d48dd0-eb0d-429d-b5e9-a408a78b364c"), null, null, "Reanna.Runolfsson39@yahoo.com", new Guid("70d04e87-92ed-4410-96a6-934a82c8bbcb") },
                    { new Guid("02194224-0cfd-464d-8750-ac7a116a1e41"), null, null, "Elouise_Cruickshank45@hotmail.com", new Guid("3a19b458-72b3-4b5b-97e6-334a56d7d557") },
                    { new Guid("02756ad6-24ba-4fbf-b13a-658fc52802e6"), null, null, "Juston.Morar@hotmail.com", new Guid("61dcb7dd-eb57-4421-b814-6cd202b0f4a1") },
                    { new Guid("02c87606-7246-490f-8336-8b25d532795e"), null, null, "Mikayla.Barrows17@hotmail.com", new Guid("9ff0a0ca-02d0-4209-bb8f-a0d7efaf75bb") },
                    { new Guid("030c140b-9582-4949-aa52-f313f4938b3a"), null, null, "Maximo.Koss26@yahoo.com", new Guid("df1ba0e6-99b8-419d-a3b8-cece7c4928bd") },
                    { new Guid("034d7340-6f24-4380-9cc0-5d8079b44090"), null, null, "Jermey63@yahoo.com", new Guid("71f7fb3b-e7f1-4325-bdd2-98f71dd515b1") },
                    { new Guid("03c7b601-ecda-4fa6-b484-40b09f4fa32f"), null, null, "Frederick_Parker85@gmail.com", new Guid("e36aac18-179d-420c-8aaa-edf7ff736e50") },
                    { new Guid("048dac4b-b03e-4a41-a14c-f5cb6e07fd46"), null, null, "Tania65@gmail.com", new Guid("a780acfd-e10d-4dc5-a383-1ba56a91e666") },
                    { new Guid("0495539c-31f3-406f-9dc3-a3f7c65ec57a"), null, null, "Viviane45@hotmail.com", new Guid("bd349cb3-f696-4e78-9355-45b8b4f7385f") },
                    { new Guid("0529ec80-1786-42e7-bf10-98f50ac90b95"), null, null, "Lemuel.Flatley64@hotmail.com", new Guid("bbe91897-98e6-4c1e-aef5-09cd3dbb35cd") },
                    { new Guid("0557be5e-05b0-43ab-acac-55d8e32375a1"), null, null, "Noelia92@gmail.com", new Guid("f51931e0-68b3-4aed-8f03-7ef9a8526650") },
                    { new Guid("061680f4-13d5-441b-ae9e-e3ebd568b96c"), null, null, "Juvenal_Abbott45@gmail.com", new Guid("c7c0cd55-07d8-41cc-9d2b-4bd04cb7edb3") },
                    { new Guid("06a33bb1-8385-4041-832b-7157a56c2031"), null, null, "Evan_Braun@yahoo.com", new Guid("496d8ed2-fc6d-49e6-b902-8a1d0b266928") },
                    { new Guid("06f5e173-a0c7-4534-8dee-d9f30d89989f"), null, null, "Craig_Hammes@hotmail.com", new Guid("ac984856-387b-48de-9d39-5cfa956d354e") },
                    { new Guid("078cd727-d55d-4af3-9243-244edf74c409"), null, null, "Remington.Ziemann@gmail.com", new Guid("1154bb55-7f7f-4d91-8347-5797ffeacb13") },
                    { new Guid("083c7a2e-a43a-4e6a-9508-d1210c266ebb"), null, null, "Deron72@gmail.com", new Guid("652ba8ca-0eee-4fb2-a548-4621f2c8de0b") },
                    { new Guid("08a38b86-52af-4145-b1f5-57d1fcb8f9d9"), null, null, "Ricky58@gmail.com", new Guid("78be92c8-3390-4d5e-aa3a-54c7301eaf2f") },
                    { new Guid("08b5ecbe-9f6a-49d6-9b07-99a3b23f9444"), null, null, "Libby_Rice@yahoo.com", new Guid("54c975d2-dbfe-4626-97fa-ceaa28e85030") },
                    { new Guid("09b585bc-3b46-47d2-a355-79320508cb28"), null, null, "Oswaldo.Gutkowski8@yahoo.com", new Guid("8dca8632-b27c-44ad-bd6c-0d7679a4f075") },
                    { new Guid("0a20b00d-90c6-49e3-a518-a38cc0fac791"), null, null, "Jay78@yahoo.com", new Guid("4d006d0d-8a50-4d81-886b-176313d018fb") },
                    { new Guid("0a3dd974-536b-4183-912a-e86d57e8bfc0"), null, null, "Randal92@gmail.com", new Guid("adbbd240-641f-475b-b705-5e35298ef012") },
                    { new Guid("0b93f5c1-ebad-4cf8-8665-ad2073d89fd8"), null, null, "Nellie.Roberts12@hotmail.com", new Guid("0773e360-956e-4d39-94c5-d0906a9e4557") },
                    { new Guid("0bba3656-746b-4c42-9de1-e6e75aeed3fe"), null, null, "Rory19@yahoo.com", new Guid("108fbff3-4041-4eed-b2a0-4a4b1fb47787") },
                    { new Guid("0c03acb7-a26f-4ece-a0ce-c72e36ac0a1b"), null, null, "Sheldon.Hermiston@hotmail.com", new Guid("3f1a1c74-7f9a-433e-808b-f0d69f6d97e7") },
                    { new Guid("0ce81cee-e530-4dfb-9432-152847b41b05"), null, null, "Buck.Beer71@yahoo.com", new Guid("c6e8a5d8-6660-4e85-9ff9-1e6ec6d0c580") },
                    { new Guid("0d598fa4-e8f1-4363-8466-1f04ab31fff6"), null, null, "Felicita10@yahoo.com", new Guid("4188ab2e-f46b-4cf6-b460-560a914e5d35") },
                    { new Guid("0d808fa1-0f12-4426-bc73-ec8909809165"), null, null, "Bessie95@gmail.com", new Guid("48f4af12-c8b0-4444-98ca-81df5d349e01") },
                    { new Guid("0d895bee-00da-455c-aa52-66b1cc386a08"), null, null, "Verda.Stroman4@gmail.com", new Guid("f2c5c231-fa4f-4403-a17b-f986cd15543a") },
                    { new Guid("0e4b0714-c2a4-4cb0-ae0b-b3593aa5f217"), null, null, "Emmet9@hotmail.com", new Guid("496d8ed2-fc6d-49e6-b902-8a1d0b266928") },
                    { new Guid("0e574a3f-6b1c-478b-bd86-beaad2c91c0d"), null, null, "Soledad_Wilkinson69@hotmail.com", new Guid("4732299f-418c-4c2e-ac09-aacb3b2c8976") },
                    { new Guid("0e802e4e-bba7-4dcb-8931-ced72a6b9537"), null, null, "Annetta.Thiel@hotmail.com", new Guid("c66d96b2-e569-4470-a3b9-82ba83e46c97") },
                    { new Guid("0f39aeff-ed6d-46c7-851d-73731540413c"), null, null, "Alejandrin.Renner@yahoo.com", new Guid("9cf1e944-d004-426c-83ee-acb2b8793bc6") },
                    { new Guid("0f56272c-f860-414d-9228-32583b2cabda"), null, null, "Davion.Steuber@gmail.com", new Guid("dc52bf7b-d952-45c3-8bf0-44dadbfbb09e") },
                    { new Guid("0f72e247-4c2d-4a4a-915b-6f0617fac8bf"), null, null, "Otha14@hotmail.com", new Guid("c7f42761-e210-47b4-9e39-2df36dce4c96") },
                    { new Guid("0fad2119-97b6-4d49-b366-e9e466c7f2b6"), null, null, "Kirsten53@yahoo.com", new Guid("2411a1da-d71e-4e02-a40e-984ec689c7bd") },
                    { new Guid("0fe0e2d6-fc33-4a07-941e-28718539bf5a"), null, null, "Darius17@hotmail.com", new Guid("bbaf9fe2-9863-4589-964a-23c62e6bf830") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("0fff0071-e9d6-4480-aa31-c5663944552a"), null, null, "Danial_Wehner0@hotmail.com", new Guid("6c3f8b98-7095-4d12-8f55-02b23a300d5f") },
                    { new Guid("10116800-1e2a-401e-b720-b12dc00bf79f"), null, null, "Asa90@yahoo.com", new Guid("a9090dd7-3795-48e2-837b-9a72a0274d7b") },
                    { new Guid("107af2d1-2781-43b0-9536-e7b63e953441"), null, null, "Jane_Lesch56@gmail.com", new Guid("42babbec-5dbe-4cc3-9f68-bb4bc7ad9491") },
                    { new Guid("11820835-c3bb-4b0f-b39c-3665e03e66b6"), null, null, "Lyla.Blick@yahoo.com", new Guid("fcf05f51-7f3a-4331-a0f5-6204db62e7ba") },
                    { new Guid("119932a2-fcec-4c37-9a8d-1dbaa7f3dc59"), null, null, "Casandra_OHara79@hotmail.com", new Guid("46542d6d-04cc-418a-88b4-cda40f4aff48") },
                    { new Guid("12597165-ae76-46e2-8ff0-66032dc6ac31"), null, null, "Laurel30@yahoo.com", new Guid("c5513371-ea13-4b3b-ab65-8bbb471b2afc") },
                    { new Guid("1278b73c-ee8f-4a48-b8d4-088805147e51"), null, null, "Tina65@yahoo.com", new Guid("d29932a8-80f8-42b1-85e0-6bf810161455") },
                    { new Guid("1305bb13-cdd6-4797-9b07-6f7a36129c25"), null, null, "Cristian.Durgan19@yahoo.com", new Guid("dc5f8e5e-be11-43f9-acd2-648e38e09946") },
                    { new Guid("135aabff-a2d3-460f-93ba-f9bf85d4518c"), null, null, "Pearlie20@gmail.com", new Guid("b40d8226-58de-4e86-811d-0e6b38686d57") },
                    { new Guid("137359ea-235c-45f0-b9c9-f5cd8aebd1f6"), null, null, "Ardella.Leffler@yahoo.com", new Guid("323967f9-cf4e-4818-a5bf-94dff7ea728b") },
                    { new Guid("13b7bfbc-05ab-47db-a3fa-2011678f1e15"), null, null, "Alysson.Davis@gmail.com", new Guid("f28f3fdf-fa90-4b58-895f-89b7f89e53e9") },
                    { new Guid("1456665b-7659-451d-81ae-8b7c41250870"), null, null, "Elvis.Feeney@gmail.com", new Guid("8be01b71-4060-43ad-98a5-2c0730fd003b") },
                    { new Guid("14d26bd3-9a24-4bf5-8176-f30524d1fce1"), null, null, "Kaycee.Mosciski@gmail.com", new Guid("cf3285c8-97d7-426d-87f3-e0854194e226") },
                    { new Guid("1599229d-fddc-47e1-8b81-2c8852e47f09"), null, null, "Lyric_Crist@hotmail.com", new Guid("56c8b4b0-c1db-425e-a349-2f7b3feabb5e") },
                    { new Guid("15b8c5f2-1b20-4902-810d-7543003fd7ae"), null, null, "Arnaldo.Emmerich@yahoo.com", new Guid("f630d90d-3329-4958-99e4-34aa2f69436c") },
                    { new Guid("160db8ea-1777-40d6-8192-30629b477faa"), null, null, "Korbin_Sawayn@hotmail.com", new Guid("2700d101-47ef-4c75-a3e1-b613514a94f0") },
                    { new Guid("16a15916-3f13-4222-a2fc-e377065212c2"), null, null, "Reilly76@hotmail.com", new Guid("fcf05f51-7f3a-4331-a0f5-6204db62e7ba") },
                    { new Guid("16c3d707-220a-4939-af02-f99f5528f695"), null, null, "Caterina20@yahoo.com", new Guid("8e3d5153-23be-45f9-83b4-5aecbb1a4322") },
                    { new Guid("16f38bd5-a18d-4b3b-b606-d9b79071e52f"), null, null, "Melany.Miller@hotmail.com", new Guid("ea848f07-5360-4e76-ac1d-cf046366d4ef") },
                    { new Guid("170d3740-3cd1-46ed-bfd2-bfd8b41bf5ca"), null, null, "Claudine30@gmail.com", new Guid("aeae0f68-579f-46b8-bee2-c797ee09ee5e") },
                    { new Guid("17fce661-c4f8-47bb-b536-0366288d3145"), null, null, "Leila.Stiedemann@hotmail.com", new Guid("108fbff3-4041-4eed-b2a0-4a4b1fb47787") },
                    { new Guid("184b8e17-bcfa-429b-9b1d-6c3700572040"), null, null, "Graham_Howell19@hotmail.com", new Guid("753e85fe-b18a-442a-b91e-1d9dc9216d93") },
                    { new Guid("187c0a39-8083-4acd-8165-7dc40d42f705"), null, null, "Lonie_Jenkins@yahoo.com", new Guid("cf3285c8-97d7-426d-87f3-e0854194e226") },
                    { new Guid("18a935fb-6999-4a2f-8385-a83ed5ae21b2"), null, null, "Garnett_Emard27@gmail.com", new Guid("815c5bf5-7253-492e-81c8-82e2d6860602") },
                    { new Guid("190f699f-5760-4a9a-af19-71191736af3e"), null, null, "Brock_Douglas33@yahoo.com", new Guid("fe7a3052-1ad9-4450-b9d5-057c6abe9c2e") },
                    { new Guid("19adc8ea-f686-4ae8-9bc6-395fff35565b"), null, null, "Annalise36@hotmail.com", new Guid("3585370e-fea3-4a31-9a6c-93267371cc1d") },
                    { new Guid("19b8ee9d-0680-4de6-a024-bb372ca941bc"), null, null, "Genesis98@gmail.com", new Guid("9ec54876-333f-4825-9959-c839395cb66e") },
                    { new Guid("19fe7c7d-899f-47f2-bab4-3380e3c7e995"), null, null, "Zander_Rolfson56@gmail.com", new Guid("22edc826-6747-4099-aca5-578199353ac6") },
                    { new Guid("1a478421-177d-4ed5-99cb-e1a630e4eaf7"), null, null, "Antonetta_Pacocha75@hotmail.com", new Guid("77bc83c5-7598-48f0-b4c1-23f76fd277ca") },
                    { new Guid("1a955ba5-6ad5-4a4e-a47d-955bd265b3b1"), null, null, "Leilani5@hotmail.com", new Guid("ca127dc1-765b-47e8-87ee-ebc90ec70a73") },
                    { new Guid("1aa19d61-7bdb-4b53-ae0e-3ef15315f6de"), null, null, "Olaf43@gmail.com", new Guid("bbaf9fe2-9863-4589-964a-23c62e6bf830") },
                    { new Guid("1af4c5af-328d-45eb-9098-a8963f77129c"), null, null, "Breanne_Abernathy30@hotmail.com", new Guid("32feb777-af06-4813-9108-9d7acfd0bd04") },
                    { new Guid("1b27702d-71b6-407d-b71e-9cf6169207f4"), null, null, "Tillman_Jakubowski@hotmail.com", new Guid("f4c8c27a-6b37-469c-9492-061adc476725") },
                    { new Guid("1b4e2682-d9f3-4a0d-b1fc-4b9aabfe508a"), null, null, "Waino79@gmail.com", new Guid("46542d6d-04cc-418a-88b4-cda40f4aff48") },
                    { new Guid("1bb3a37f-9b41-4d1f-9233-96c92d5a0729"), null, null, "Lyla.Abbott53@gmail.com", new Guid("64e0a0ed-41a2-429f-800b-6407610d5984") },
                    { new Guid("1bcf02a4-350d-45cd-890d-3280e2f5d997"), null, null, "Lia.Douglas15@gmail.com", new Guid("4ecad1f7-2b37-4dd8-be42-dedd60205e81") },
                    { new Guid("1c0c7a5d-7492-40c1-86b5-ffede28a907e"), null, null, "Lyric.Dooley71@yahoo.com", new Guid("2bdbd536-e4dc-4869-9dac-f62a098ecb05") },
                    { new Guid("1c2f4c6a-0329-4795-a46f-f91f16592928"), null, null, "Cayla90@yahoo.com", new Guid("f4c8c27a-6b37-469c-9492-061adc476725") },
                    { new Guid("1c40509b-79fe-485a-804a-3f2c8b8483c1"), null, null, "Alfreda_Hessel33@hotmail.com", new Guid("32feb777-af06-4813-9108-9d7acfd0bd04") },
                    { new Guid("1c455b18-1134-4d22-afee-0c432ceffd52"), null, null, "Ulises5@gmail.com", new Guid("c40f9fee-6298-4137-bc78-c74409dec92f") },
                    { new Guid("1cc70335-97d7-4c91-94eb-2010e19e81cc"), null, null, "Lina_Koch50@yahoo.com", new Guid("4b45c810-f446-449d-8b0e-4a2ebbbf7104") },
                    { new Guid("1cfa242c-0fff-4976-b78d-b85e3d9f9559"), null, null, "Immanuel81@hotmail.com", new Guid("6c3e0836-290a-4c10-8832-91720a2e9054") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("1d7cee37-de1e-4412-a151-aa75fcc10ec9"), null, null, "Fritz_Lowe89@gmail.com", new Guid("6b5cd903-9056-4302-b3e6-b910c3a67f76") },
                    { new Guid("1d8ca0ab-99f6-4c37-b1da-3a84a6e1c38e"), null, null, "Dashawn51@yahoo.com", new Guid("0a1370d0-5d3b-4609-9efc-9507f4acc2f8") },
                    { new Guid("1d9d295d-743e-45ab-aaf3-906883e6512f"), null, null, "Daniella.Jakubowski@yahoo.com", new Guid("1b1ebe07-5765-4728-8b40-ee14061347ae") },
                    { new Guid("1dccfdcd-3af9-4f3c-b3b3-1520a7814634"), null, null, "Elenor.Wuckert97@hotmail.com", new Guid("487efc58-2d93-4b91-a4fb-1ce1d3ef038a") },
                    { new Guid("1deff86c-66c3-42d5-9a73-7fc01beedf4c"), null, null, "Tyshawn_Wiegand@yahoo.com", new Guid("07e77ffa-7983-4cb3-bfa5-a4b8ed39f91f") },
                    { new Guid("1e2d9f2c-1425-474c-8670-0fe6c1e5f892"), null, null, "Gabriel.Terry@yahoo.com", new Guid("0a8fb680-a380-4d35-85da-ff3cf9faa245") },
                    { new Guid("1e569cd6-715b-49ca-a5cb-b261f8b91577"), null, null, "Marjorie.Reinger@gmail.com", new Guid("323967f9-cf4e-4818-a5bf-94dff7ea728b") },
                    { new Guid("1e61999b-d1e1-432c-9e8a-58e730b4d9bd"), null, null, "Blaise.Kiehn@yahoo.com", new Guid("394e6c37-a398-4cf7-983d-8fb216e6c46f") },
                    { new Guid("1ee7721b-bc75-4e03-98b3-fa27a2a70c9a"), null, null, "Kenny71@hotmail.com", new Guid("c88c725e-8cbf-416d-a4bf-153a024ea6c9") },
                    { new Guid("1eff0265-e8a7-4475-9650-6bc7e6926a7b"), null, null, "Marcelle_Trantow15@gmail.com", new Guid("487f0344-4cde-4b10-971a-1f8311cce3f5") },
                    { new Guid("1f074f8b-0112-495c-99ad-82bad16ef444"), null, null, "Matt_Dach11@yahoo.com", new Guid("5c6a10ae-343d-47fa-9381-6cbe7b1a68be") },
                    { new Guid("1f32a137-6af4-4fbd-8abe-32929f9ab21e"), null, null, "Rhoda24@gmail.com", new Guid("e5406e78-ce40-43ee-8dee-e58fe7687eb3") },
                    { new Guid("1f4dd8bf-754f-4cb2-943f-8ee7dfd90b6d"), null, null, "Adah64@yahoo.com", new Guid("49ef4ccb-eb29-4ffa-bcfe-88759ac3f1c5") },
                    { new Guid("1f4fd9a8-50ac-42d3-8948-627a04cced0d"), null, null, "Katheryn5@gmail.com", new Guid("672ce079-171b-4f7e-b744-6b9376e96b61") },
                    { new Guid("1f97ebea-8d2e-4ddb-9608-f73377ec8f2a"), null, null, "Ruby_Sanford61@yahoo.com", new Guid("3b3e9016-3025-48e3-93b2-fa474015c0f7") },
                    { new Guid("1faab1e0-3eb5-47a0-b439-9fc72bd25939"), null, null, "Mariah49@hotmail.com", new Guid("f5fa9239-e966-4c8e-9eb5-32ecf277976e") },
                    { new Guid("1fac4236-f8be-4e77-a64e-51e7a5b260a7"), null, null, "Elmo76@hotmail.com", new Guid("815c5bf5-7253-492e-81c8-82e2d6860602") },
                    { new Guid("211a5641-3d62-442d-94bb-889a2ea28dbc"), null, null, "Ian.Haley@hotmail.com", new Guid("141e6ca1-3b19-4ffc-a21f-8420c3f6db52") },
                    { new Guid("21aa1247-dd39-4105-b1e3-ac74f0d017bc"), null, null, "Gwendolyn_Daniel@yahoo.com", new Guid("496d8ed2-fc6d-49e6-b902-8a1d0b266928") },
                    { new Guid("21d3174b-a17a-4a25-8fbe-8e7e8089e4a4"), null, null, "Chester.Sauer@gmail.com", new Guid("93e9e8fa-8b76-4968-a1ef-a4d59b6958ea") },
                    { new Guid("220c87b8-69b7-4104-9a3f-394fad30e8a8"), null, null, "Vallie_Gutmann36@gmail.com", new Guid("9ee8d8bd-022b-4718-b8f4-cc38174e988c") },
                    { new Guid("223ccaca-eb94-43e6-9cee-dbda3bbde8b0"), null, null, "Rey35@gmail.com", new Guid("d0aae9a2-8c5b-48e9-b856-e309c80cadae") },
                    { new Guid("2283bb25-285e-4a25-ab9e-3ee3eaf1c11b"), null, null, "Adriel67@yahoo.com", new Guid("ce7719fc-1874-4df0-88ba-9b5637945029") },
                    { new Guid("236d6bab-fbd2-479d-b45f-8dea0084e5de"), null, null, "Neil_Morissette36@gmail.com", new Guid("548e47d4-b851-4432-8514-fc092768db5b") },
                    { new Guid("24638299-6064-4629-8135-c5b97f133aa2"), null, null, "Emil_Hegmann58@hotmail.com", new Guid("35275876-97ec-44a4-8503-f21c815c9a45") },
                    { new Guid("24cde88b-6183-4709-be0b-2084c6b07d81"), null, null, "Zula40@yahoo.com", new Guid("d40492c4-d582-4ce6-943c-a487675b7960") },
                    { new Guid("24fd00f5-727f-416a-a35d-f3c2f49e5793"), null, null, "Tommie_Kerluke@yahoo.com", new Guid("61dcb7dd-eb57-4421-b814-6cd202b0f4a1") },
                    { new Guid("25060724-55ee-4dfd-9d05-b7b6fe8756d7"), null, null, "Jett_Dooley@yahoo.com", new Guid("2e3a99a4-4308-410d-b67e-4763bbd6b9c8") },
                    { new Guid("250a8f6e-eaa6-4193-99d6-de59227f4bd3"), null, null, "Lonnie76@hotmail.com", new Guid("23e8131d-ba45-4488-991d-941eca3fbe0a") },
                    { new Guid("2526879d-cff8-40b6-bde4-8d57bce6670c"), null, null, "Jeanie.Raynor36@gmail.com", new Guid("dbc51236-052c-4c31-820d-b0a01a143d1a") },
                    { new Guid("259a2fd2-b786-44e7-ba19-3059503195f1"), null, null, "Jacey_Lueilwitz43@yahoo.com", new Guid("a943e809-55d9-482f-a592-8709b5f7d47f") },
                    { new Guid("26a12c5a-dea4-4191-96da-b4f3b00310b4"), null, null, "Maryjane47@gmail.com", new Guid("230e73b5-4a4b-4b1c-ad48-f7a0074303c7") },
                    { new Guid("26f2c6f8-5914-448c-847c-43bb312dffc7"), null, null, "Finn31@hotmail.com", new Guid("8bfa284c-faeb-4fb6-909c-2a2ea4c8745b") },
                    { new Guid("27265751-4d97-465d-81ca-cf8bb25b3e31"), null, null, "Eldred22@hotmail.com", new Guid("e764f5ca-90fe-4d60-aab1-e56e02a1f110") },
                    { new Guid("2753dddd-a2db-409a-b08d-029fbd39f18d"), null, null, "Keshaun22@gmail.com", new Guid("8bfa284c-faeb-4fb6-909c-2a2ea4c8745b") },
                    { new Guid("27872f68-344e-42c7-90fb-36cd8c6b023e"), null, null, "Dakota.Graham21@yahoo.com", new Guid("c5efb9ab-d786-43d2-9595-c90aedaedb9b") },
                    { new Guid("27c24fa4-3c47-45ac-bc23-e8195aca9f4a"), null, null, "Shania13@gmail.com", new Guid("dc52bf7b-d952-45c3-8bf0-44dadbfbb09e") },
                    { new Guid("28671663-1964-4b3e-aa02-189c9fd04337"), null, null, "Albertha.Hammes@gmail.com", new Guid("7de3e658-53a0-464d-a4aa-b7bf40828f5d") },
                    { new Guid("28e3c45a-c98c-47e0-921d-b3d1f46d855a"), null, null, "Jay_Schaefer48@yahoo.com", new Guid("bd349cb3-f696-4e78-9355-45b8b4f7385f") },
                    { new Guid("28ef7c1c-0ad3-42e0-8acc-5c31505aa3a9"), null, null, "Jalyn84@gmail.com", new Guid("5c6a10ae-343d-47fa-9381-6cbe7b1a68be") },
                    { new Guid("29459634-c637-4d6d-b725-d8f0bc7fa24e"), null, null, "Mary.Konopelski20@gmail.com", new Guid("e36aac18-179d-420c-8aaa-edf7ff736e50") },
                    { new Guid("296ee8d2-ef37-4620-aeb5-d2c1028a143b"), null, null, "Matt_Anderson36@gmail.com", new Guid("b21ce16f-bf5c-4cfa-9fd4-9b67014eadbb") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("29fa0ada-11c1-4f82-820a-21ff54e4d111"), null, null, "Lolita.Larson61@gmail.com", new Guid("108fbff3-4041-4eed-b2a0-4a4b1fb47787") },
                    { new Guid("2a855c21-9e87-4211-ad2f-666465444ef5"), null, null, "Camren73@hotmail.com", new Guid("77bc83c5-7598-48f0-b4c1-23f76fd277ca") },
                    { new Guid("2aac299c-6f1d-483b-8262-d9fbe4ec1a90"), null, null, "Waldo39@hotmail.com", new Guid("56c8b4b0-c1db-425e-a349-2f7b3feabb5e") },
                    { new Guid("2aeeb577-c9c7-4c5d-affe-34603d0a8681"), null, null, "Murray.Hand@yahoo.com", new Guid("4f42e5ab-642c-4775-b2b2-a116ecfcd663") },
                    { new Guid("2b331709-9733-4ad9-ac7d-5d3e4f771a88"), null, null, "Fannie26@gmail.com", new Guid("46843658-5438-46a9-b26a-f6c2fcfd1883") },
                    { new Guid("2be76007-6cf4-4f05-87c8-72329ae10fe0"), null, null, "Isidro6@yahoo.com", new Guid("ac5a7dc0-9da2-4c23-9acc-ec9828404cd5") },
                    { new Guid("2c33e16f-2318-4bca-b152-a2621bf9e76d"), null, null, "Maiya_Shanahan54@yahoo.com", new Guid("a5276d46-3296-4c05-ba31-d2ebddfd8a57") },
                    { new Guid("2c5241d8-902b-4b1c-9962-11b5dd08c2b0"), null, null, "Cooper_Braun@gmail.com", new Guid("a419df27-9358-4a02-9ab7-2f2e2344fae0") },
                    { new Guid("2c567ede-54d1-49a0-a862-8208984739c1"), null, null, "Cristopher30@yahoo.com", new Guid("3ff3d88e-b078-4f3a-8312-8447eeb772e2") },
                    { new Guid("2c669657-c8af-4bc0-8765-d77910573a3e"), null, null, "Lauretta.Koepp@yahoo.com", new Guid("02a17a84-0a35-4164-b872-e030d586b6fe") },
                    { new Guid("2c9a42d2-4048-459b-a1f1-3cb2cadbc6de"), null, null, "Lizeth42@yahoo.com", new Guid("97e11482-d5e6-41d7-82e3-80806df9c3bc") },
                    { new Guid("2cda1238-7f19-43db-b7c2-f353059c47a5"), null, null, "Oda28@yahoo.com", new Guid("dd550cd7-4eae-4d75-8be5-5f3e496fdd24") },
                    { new Guid("2ce66d6f-a4f1-495b-9024-02b4c006e5ef"), null, null, "Bert6@yahoo.com", new Guid("1a21f215-231c-4e09-b7c2-4e3163978286") },
                    { new Guid("2d02ed2f-989f-4fbd-8bd4-87b052183d6e"), null, null, "Camille74@gmail.com", new Guid("78be92c8-3390-4d5e-aa3a-54c7301eaf2f") },
                    { new Guid("2d513121-b3a0-4f6c-9982-637c89d09e10"), null, null, "Benedict.Connelly54@gmail.com", new Guid("4a9e17b4-cb0f-4c82-80d2-e1d56fe06f0a") },
                    { new Guid("2d662f71-66b0-4a0d-8236-6c2c538a7fb7"), null, null, "Amina.Zieme78@hotmail.com", new Guid("ea848f07-5360-4e76-ac1d-cf046366d4ef") },
                    { new Guid("2d9237c9-9db0-461f-bbb5-0b113f36586f"), null, null, "Hortense.Runolfsson34@yahoo.com", new Guid("b5cca55a-d81f-47be-b0b4-50d07e79ce69") },
                    { new Guid("2e761018-9722-402c-8519-b839ca17cf91"), null, null, "Jairo90@hotmail.com", new Guid("7c2f2e0c-1d40-453b-84ea-f5f09cb10d28") },
                    { new Guid("2e8f9800-8827-49fc-9d07-dfcfe1e843ac"), null, null, "Earnestine42@yahoo.com", new Guid("4083c32d-a4cd-4c70-b794-fa7b97aafe4e") },
                    { new Guid("2e9d9e09-24b7-4512-b6dd-7a6de565d24d"), null, null, "Jakob.Hane@gmail.com", new Guid("0d230077-5e9b-42d8-a83a-650a22378849") },
                    { new Guid("2ea3e415-4f94-431e-b892-fa539d67c7dd"), null, null, "Kenny92@yahoo.com", new Guid("7cf58058-5eec-4c6e-a4ae-cf50ccf0b2ac") },
                    { new Guid("2f3c07e4-7c6d-4eb5-8c73-8b3dc2b09584"), null, null, "Gilbert_Gerlach@yahoo.com", new Guid("0a1370d0-5d3b-4609-9efc-9507f4acc2f8") },
                    { new Guid("2feaccaf-e774-48cb-b6ae-f7ee62b36c3b"), null, null, "Dorothea_Brown@gmail.com", new Guid("72a42c8b-ed7c-4e7a-81c6-313cac897b20") },
                    { new Guid("303442ce-c5ff-48fd-bc45-fe0ec3a867af"), null, null, "Rossie.Skiles@gmail.com", new Guid("1154bb55-7f7f-4d91-8347-5797ffeacb13") },
                    { new Guid("30485412-72cd-4132-8f78-2d16734385b9"), null, null, "Aric_Mayer@hotmail.com", new Guid("5d1e2a88-0f0a-4b6e-a524-e279224a1944") },
                    { new Guid("3049956f-91a8-46c8-a115-00205470bc27"), null, null, "Deontae_Tillman57@yahoo.com", new Guid("94c09a0c-18a4-40c8-9285-032386267d16") },
                    { new Guid("304e0468-4ac0-4af8-9139-a153fd27fbff"), null, null, "Alize80@hotmail.com", new Guid("548e47d4-b851-4432-8514-fc092768db5b") },
                    { new Guid("30ac8c83-027b-4016-aa8c-1697b10f893a"), null, null, "Jay_Olson@yahoo.com", new Guid("353c126e-57f5-471a-b13f-0e4fd4cef2fe") },
                    { new Guid("30b0a672-41f0-4c28-9b46-99ee07d3d065"), null, null, "Rebecca94@gmail.com", new Guid("56c8b4b0-c1db-425e-a349-2f7b3feabb5e") },
                    { new Guid("30da5d13-28b5-490e-a755-2548ec3a6f79"), null, null, "Reba.Smitham@gmail.com", new Guid("ce7719fc-1874-4df0-88ba-9b5637945029") },
                    { new Guid("3106461e-1303-465f-ac56-05069ec682f2"), null, null, "Jewel62@yahoo.com", new Guid("9b254af5-9da3-4b42-a5f3-b573df408d84") },
                    { new Guid("313cf97b-1488-4b16-bfe5-fbbaf2e3c9ca"), null, null, "Lester29@hotmail.com", new Guid("50fa1a40-d4af-4edd-8c00-61ec693395b2") },
                    { new Guid("3143bc65-5480-4970-a7e1-e6feaae8ebac"), null, null, "Eugenia32@hotmail.com", new Guid("e5406e78-ce40-43ee-8dee-e58fe7687eb3") },
                    { new Guid("314bfaa5-93cf-4c29-99fe-b0635a9ab782"), null, null, "Ford58@yahoo.com", new Guid("c66d96b2-e569-4470-a3b9-82ba83e46c97") },
                    { new Guid("32b08a8d-7adc-44ba-b36c-8cbb5a04ef88"), null, null, "Miller.Abshire@hotmail.com", new Guid("e764f5ca-90fe-4d60-aab1-e56e02a1f110") },
                    { new Guid("32b73c9c-c507-401e-a999-20c508602281"), null, null, "Jacynthe36@hotmail.com", new Guid("335c9d28-42e2-4d49-9686-f0cd1b972fae") },
                    { new Guid("32f1c984-164e-423a-a14c-cab9cd39dadf"), null, null, "Dee94@yahoo.com", new Guid("c590f92c-3ca1-4a33-a976-926995a0f7cc") },
                    { new Guid("33109d04-c337-4a87-880e-89d6bc839d24"), null, null, "Abigale_Fisher0@yahoo.com", new Guid("c221f46b-a606-417e-aead-c8b255d84d11") },
                    { new Guid("33ddaaf8-e3b0-44e7-9cc0-ea26616541c4"), null, null, "Claudie8@yahoo.com", new Guid("fcf05f51-7f3a-4331-a0f5-6204db62e7ba") },
                    { new Guid("33e9543a-409c-461a-8c69-472200f0aa2e"), null, null, "Jasmin.Hermiston@yahoo.com", new Guid("3a6fda52-d9f1-418c-8ffa-69974f7f39be") },
                    { new Guid("347e61a6-a81e-48f0-8363-02860cd652db"), null, null, "Danny.Dare@yahoo.com", new Guid("2c87eaa4-8e07-41f4-bad0-935d07541e78") },
                    { new Guid("34806467-071f-486c-82aa-d9245734adb6"), null, null, "Bernie.Schaefer41@gmail.com", new Guid("487efc58-2d93-4b91-a4fb-1ce1d3ef038a") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("34de8380-f335-41e2-a7ca-b1c55c011a96"), null, null, "Eleonore68@yahoo.com", new Guid("0776f148-3954-48ff-8bb8-772d353c1a3c") },
                    { new Guid("3546a584-5b82-44be-af20-a72307655ff2"), null, null, "Pascale63@gmail.com", new Guid("7e4a74cd-b47b-47e6-ab98-22ed32bd8e27") },
                    { new Guid("3552a8b5-3c96-48f0-9546-809fd2c765cb"), null, null, "Nikita.Kuhic@hotmail.com", new Guid("2700d101-47ef-4c75-a3e1-b613514a94f0") },
                    { new Guid("358055e9-b4b2-4271-8b75-fcdb04e953ba"), null, null, "Ahmad42@yahoo.com", new Guid("02a17a84-0a35-4164-b872-e030d586b6fe") },
                    { new Guid("35dc8b1b-ae48-43c5-8858-3228e57c5acd"), null, null, "Paolo.Fay@yahoo.com", new Guid("32feb777-af06-4813-9108-9d7acfd0bd04") },
                    { new Guid("35ff42f8-4b9b-4b8f-9969-adb68812014c"), null, null, "Christa.Hyatt60@yahoo.com", new Guid("6c3f8b98-7095-4d12-8f55-02b23a300d5f") },
                    { new Guid("36359001-4770-47ca-8aee-599929f9cfb3"), null, null, "Patricia_Paucek@yahoo.com", new Guid("1e17494c-b19d-4879-af0e-c6575db6bd37") },
                    { new Guid("3638707a-8ccc-4694-8612-64b8a337f4ab"), null, null, "Alberto52@hotmail.com", new Guid("f4c8c27a-6b37-469c-9492-061adc476725") },
                    { new Guid("36435efc-c8bc-4422-9920-3e8101facb7b"), null, null, "Freddie_Welch@gmail.com", new Guid("dd550cd7-4eae-4d75-8be5-5f3e496fdd24") },
                    { new Guid("364f2645-3259-469b-8d92-7ab8692d5d2b"), null, null, "Davonte52@gmail.com", new Guid("dbc51236-052c-4c31-820d-b0a01a143d1a") },
                    { new Guid("36d4407d-16f0-403a-858b-991713142d5e"), null, null, "Afton.Jones@gmail.com", new Guid("3585370e-fea3-4a31-9a6c-93267371cc1d") },
                    { new Guid("375bc7a4-77d8-4550-8bff-95b336fa5278"), null, null, "Katelynn59@gmail.com", new Guid("5e1f9cf6-8e77-46be-92e7-b3f10da0ed86") },
                    { new Guid("387fa9bf-93e4-4087-84f1-46f4635ee949"), null, null, "Aurore27@gmail.com", new Guid("40a279f6-73dd-4fa2-8b1e-05f9cd8bdcf9") },
                    { new Guid("389a8d3b-0370-4881-9ec2-553c94d5c37f"), null, null, "Rasheed_Reinger@gmail.com", new Guid("3ff3d88e-b078-4f3a-8312-8447eeb772e2") },
                    { new Guid("389e9764-0d33-4e3d-8af8-ca93c5a35eef"), null, null, "Diana.Russel@gmail.com", new Guid("f7082ecf-eb66-429e-8a3f-72fac7d7b453") },
                    { new Guid("38a276d0-dd20-4386-afb9-c8517e7a8759"), null, null, "German.Labadie@hotmail.com", new Guid("2476b4fb-aceb-40f6-b636-80dd269d535c") },
                    { new Guid("38c66ce8-8a2a-45fb-9e1f-9c0755d57687"), null, null, "Bertrand8@gmail.com", new Guid("652ba8ca-0eee-4fb2-a548-4621f2c8de0b") },
                    { new Guid("38e9088a-b300-4959-821a-338f483f6997"), null, null, "Jayden_Robel44@yahoo.com", new Guid("8ea935b6-2c30-4bef-803c-9f382789979b") },
                    { new Guid("3930b842-bb6f-437e-a95b-95a3d1c8ddba"), null, null, "Christian_Nolan86@yahoo.com", new Guid("d3cba19c-d75f-49cd-8bce-3e5563428a3a") },
                    { new Guid("395c3d2f-df87-4be2-aaa9-f93ff96155e5"), null, null, "Lenore_Ankunding45@yahoo.com", new Guid("6b5cd903-9056-4302-b3e6-b910c3a67f76") },
                    { new Guid("3960269f-a938-4c79-a68c-d8f3b1de3759"), null, null, "Emmanuelle.Marquardt45@yahoo.com", new Guid("097cb7d3-d333-48aa-b8ee-cacd11ee91fa") },
                    { new Guid("39a31cf3-6e81-4503-8a3f-ad81a451d8b0"), null, null, "Chris41@gmail.com", new Guid("50b1b40f-32d2-45da-a690-b9d24fff476e") },
                    { new Guid("3a75e2a3-8f15-4af5-9d32-8b217c7af4da"), null, null, "Adam.Sauer@gmail.com", new Guid("e5fa7b3b-6d8a-43dc-88a3-403aed558476") },
                    { new Guid("3ab0927e-a5c1-47df-835c-d27ca4dc1817"), null, null, "Ramiro_Padberg@hotmail.com", new Guid("815c5bf5-7253-492e-81c8-82e2d6860602") },
                    { new Guid("3aec9cd9-7bbe-477f-b68d-5f8a9a68455b"), null, null, "Jennings20@gmail.com", new Guid("0a1370d0-5d3b-4609-9efc-9507f4acc2f8") },
                    { new Guid("3b521bfc-b9d2-4231-acc0-a0ce1d417b3d"), null, null, "Rasheed_Schaefer85@yahoo.com", new Guid("97e11482-d5e6-41d7-82e3-80806df9c3bc") },
                    { new Guid("3b5b714c-7a2e-4918-8e9d-1cff41904ea4"), null, null, "Aubrey_Kozey10@gmail.com", new Guid("6ef84803-7ff7-46d1-b1b3-ebda82e158b3") },
                    { new Guid("3bf7b932-0c8e-4e56-94f6-e9ddd0671504"), null, null, "Ellen96@gmail.com", new Guid("a9090dd7-3795-48e2-837b-9a72a0274d7b") },
                    { new Guid("3c0f3c9c-1ff9-4103-83f6-7b39758bdfb5"), null, null, "Owen82@hotmail.com", new Guid("c7c0cd55-07d8-41cc-9d2b-4bd04cb7edb3") },
                    { new Guid("3d56d939-383d-4eb3-9b6f-9d46fe4c7301"), null, null, "Amely80@hotmail.com", new Guid("93e9e8fa-8b76-4968-a1ef-a4d59b6958ea") },
                    { new Guid("3d782f2f-9bd5-4724-af4b-17fb1eb8e045"), null, null, "Emmy.Dietrich86@gmail.com", new Guid("db32027d-cf9c-4544-af7d-d20c917925c7") },
                    { new Guid("3d8ea5c6-4db9-4417-bae8-42f245c04fe0"), null, null, "Aditya63@yahoo.com", new Guid("d57e07f1-63a6-4514-ae7a-51f83c901e2c") },
                    { new Guid("3edf16e8-8a18-4af3-bbf4-fc19c1a6decd"), null, null, "Araceli95@hotmail.com", new Guid("e41a0e5f-468e-496b-8fe7-b8f4b2a0f962") },
                    { new Guid("4022b0f9-1084-44e8-bb5b-c8dad32249c1"), null, null, "Annamae77@gmail.com", new Guid("1bab23ea-659b-4531-ad24-fdfd8984675d") },
                    { new Guid("40882940-c2ef-4e34-97db-a1486f8b2787"), null, null, "Erich_Walsh90@hotmail.com", new Guid("353c126e-57f5-471a-b13f-0e4fd4cef2fe") },
                    { new Guid("408c8f94-be9e-4229-8cd3-17aa08c194cc"), null, null, "Penelope_Schumm@yahoo.com", new Guid("42c4353e-7775-4c68-a647-2b921bb87c89") },
                    { new Guid("40e1ff8d-9e75-4501-8881-fdb24785226c"), null, null, "Elisha.Kassulke91@yahoo.com", new Guid("672ce079-171b-4f7e-b744-6b9376e96b61") },
                    { new Guid("40f69ba2-5f69-4eb9-955d-081b9e68bc87"), null, null, "Kennith_Becker58@yahoo.com", new Guid("4ecad1f7-2b37-4dd8-be42-dedd60205e81") },
                    { new Guid("4166198f-0777-4590-b4cd-1e9f1ff6d7cd"), null, null, "Robbie.Shields@hotmail.com", new Guid("ac4ee7ff-56c7-4c45-ba3e-32ed6d9370f3") },
                    { new Guid("4173dafd-f4e7-4c6c-adfb-14044753c49f"), null, null, "Gilberto_Gleichner@gmail.com", new Guid("df3cc97e-5297-4426-8d73-6ec8a1d6ff19") },
                    { new Guid("41acddc9-c3c4-4687-8049-519f7f41e75b"), null, null, "Jayden.Corwin22@yahoo.com", new Guid("aec475ab-9ab8-4f55-8794-ee1ffc6f6da6") },
                    { new Guid("41f7e8b2-d882-435f-aca1-e19938825584"), null, null, "Howard_Funk81@yahoo.com", new Guid("8c18ec85-46f2-44b0-bd0b-56adb1bf7743") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("426fa0b4-7756-4657-b4be-7047b2230b4a"), null, null, "Hester26@hotmail.com", new Guid("c36bd526-4a45-4a4b-9d0e-50c279e9b939") },
                    { new Guid("42e86639-19e7-4486-ae19-ae5342b1534a"), null, null, "Esperanza69@yahoo.com", new Guid("8f876cca-154f-4381-adab-41c9e894d046") },
                    { new Guid("438cf61d-23d4-440d-91e4-595e78c45892"), null, null, "Ron.Gulgowski34@hotmail.com", new Guid("a9090dd7-3795-48e2-837b-9a72a0274d7b") },
                    { new Guid("43e2ae9c-5aba-4cca-9a92-eb42607c3858"), null, null, "Aliya_Cummings@gmail.com", new Guid("4083c32d-a4cd-4c70-b794-fa7b97aafe4e") },
                    { new Guid("44108533-9d40-483c-adce-28bed49b7e0e"), null, null, "Herta36@gmail.com", new Guid("4efd0f6e-db18-4603-b7c2-f032eb9132a9") },
                    { new Guid("4449e459-c1ab-4dc7-87d5-475cd9055e02"), null, null, "Lazaro_Kessler71@hotmail.com", new Guid("ed1f5061-44e1-4df4-b0de-bc0c17fd0185") },
                    { new Guid("4453c8f7-b8e2-4b78-bffe-c3cb8529732b"), null, null, "Minerva23@yahoo.com", new Guid("831f8f9d-e78d-4f72-8b48-1c32c42fda1b") },
                    { new Guid("446ba2f7-da0b-4c46-8993-556f063a1571"), null, null, "Liana.Wintheiser76@hotmail.com", new Guid("d43ee797-d0bc-4a3e-8833-c45e9d340f44") },
                    { new Guid("44741823-ea60-42e2-8520-b1d972c8aae4"), null, null, "Rahsaan.Considine@hotmail.com", new Guid("6ef84803-7ff7-46d1-b1b3-ebda82e158b3") },
                    { new Guid("447c428e-efdc-4751-aae8-16022038d847"), null, null, "Sarah_Rau@gmail.com", new Guid("5c5b9127-2aa5-4ed6-b779-6402154d5c0f") },
                    { new Guid("44f2418f-e498-490b-ba99-c53445231c74"), null, null, "Dedrick_Wisozk22@gmail.com", new Guid("10766e70-305e-4e2a-8560-ffeb596a93eb") },
                    { new Guid("45a30467-6a2b-44b7-b6c8-387634d4fd58"), null, null, "Loma.Miller35@hotmail.com", new Guid("6ab8f9db-6513-4d8f-9cde-7b925ff51057") },
                    { new Guid("45f6d3c8-17d1-40ac-9867-710fc539820f"), null, null, "Hilton_Douglas7@hotmail.com", new Guid("4fdddaf5-83dc-4f45-ad82-fcab10f87405") },
                    { new Guid("4618cc9f-0ea3-424a-9203-44f7169cfd4b"), null, null, "Lucy50@gmail.com", new Guid("9ff0a0ca-02d0-4209-bb8f-a0d7efaf75bb") },
                    { new Guid("46203ad2-7c12-45de-8234-6e07d4aead06"), null, null, "Nikki73@yahoo.com", new Guid("ddf2bc3e-21a3-4bd8-8ebc-4afb8cb49df0") },
                    { new Guid("467f17cd-3252-400a-987c-fbb2d6ed27cf"), null, null, "Thurman62@gmail.com", new Guid("6ef84803-7ff7-46d1-b1b3-ebda82e158b3") },
                    { new Guid("46905743-1e06-49e9-bc3b-9983cd96a75f"), null, null, "Rosalyn_Willms56@yahoo.com", new Guid("6c16f159-98d6-4d70-a7ac-43b19b827d49") },
                    { new Guid("46ec329a-0305-4fc5-a57f-61503ab8cc79"), null, null, "Torey.Thompson27@gmail.com", new Guid("71f7fb3b-e7f1-4325-bdd2-98f71dd515b1") },
                    { new Guid("472a3f69-379e-4c30-9198-66ff890f5c6f"), null, null, "Wilhelmine32@yahoo.com", new Guid("aec475ab-9ab8-4f55-8794-ee1ffc6f6da6") },
                    { new Guid("4754e2b9-4a1c-46b0-8ef6-48c623e45e41"), null, null, "Brock.Reichert14@hotmail.com", new Guid("bd07490e-79db-4063-b992-0fa27e7f7677") },
                    { new Guid("4775e9ec-f098-47b7-bbeb-fabe7f4087c0"), null, null, "Filomena.Brown@hotmail.com", new Guid("10766e70-305e-4e2a-8560-ffeb596a93eb") },
                    { new Guid("47a78744-7ee4-48d6-ad92-fee3cfd4a977"), null, null, "Johan1@gmail.com", new Guid("df1ba0e6-99b8-419d-a3b8-cece7c4928bd") },
                    { new Guid("4896fe8a-c663-4879-b680-fe707bf01584"), null, null, "Barbara_Boyle13@gmail.com", new Guid("8c18ec85-46f2-44b0-bd0b-56adb1bf7743") },
                    { new Guid("489c1f4f-52b2-49bf-a97c-18ed96cb649a"), null, null, "Cloyd76@yahoo.com", new Guid("eeb82343-3a6f-48ee-b791-709692ceea7d") },
                    { new Guid("48a704a3-2203-410d-b77a-5eff64e7e54e"), null, null, "Jordon_Russel69@gmail.com", new Guid("25c234e8-8d95-42b3-9dc3-c418fbcaa7da") },
                    { new Guid("48c60686-457d-48d8-afff-154c9476de5a"), null, null, "Christ.Ullrich5@hotmail.com", new Guid("c66d96b2-e569-4470-a3b9-82ba83e46c97") },
                    { new Guid("4933cace-a489-4c8c-a816-288f57660441"), null, null, "Mafalda0@gmail.com", new Guid("ce7719fc-1874-4df0-88ba-9b5637945029") },
                    { new Guid("497c17d9-a548-4036-83c7-85b2992a7054"), null, null, "Wyatt78@gmail.com", new Guid("4a9e17b4-cb0f-4c82-80d2-e1d56fe06f0a") },
                    { new Guid("49da8b26-2d3d-44b2-ba3f-2809e2d3c285"), null, null, "Angelina_Tremblay96@gmail.com", new Guid("8dca8632-b27c-44ad-bd6c-0d7679a4f075") },
                    { new Guid("4b3b5632-d290-4b8f-bed5-42313d3d8bfb"), null, null, "Sarai.Blick64@yahoo.com", new Guid("48b3cd65-be2f-4be1-a3c5-d88da44b3d73") },
                    { new Guid("4b48d956-8b32-4c1b-b8e8-ea0b9133c95b"), null, null, "Rebeca.Harber@gmail.com", new Guid("21d9b3f2-945c-40a1-a0ca-7b6fcbe38a4e") },
                    { new Guid("4b5f01ad-5d64-4f55-8294-7fffea14b38e"), null, null, "Deanna.Mosciski@yahoo.com", new Guid("539c62ee-15fc-4d37-ab5d-0e4126109954") },
                    { new Guid("4bb58319-e664-4199-a468-5a1a03da814e"), null, null, "Lukas_Rowe@yahoo.com", new Guid("d57e07f1-63a6-4514-ae7a-51f83c901e2c") },
                    { new Guid("4cb49eb4-dbcc-4156-b4da-e4fb76e94852"), null, null, "Ramon.Dickinson@yahoo.com", new Guid("d0aae9a2-8c5b-48e9-b856-e309c80cadae") },
                    { new Guid("4d12a4bc-8d94-4649-b8ac-610a8c22b6bc"), null, null, "Name.Wehner@yahoo.com", new Guid("353c126e-57f5-471a-b13f-0e4fd4cef2fe") },
                    { new Guid("4d4739a1-8ee9-45d6-9ac3-df1f99e9de52"), null, null, "Dusty9@yahoo.com", new Guid("46843658-5438-46a9-b26a-f6c2fcfd1883") },
                    { new Guid("4d72e643-7dc3-4594-a338-680ef25c1162"), null, null, "Raul50@gmail.com", new Guid("56b8dced-e510-417c-8b93-8a2cb06b845a") },
                    { new Guid("4d75338c-d354-4fca-9abf-8ee9f54b4c32"), null, null, "Kenyon.Bruen12@gmail.com", new Guid("871feb78-0a5f-4d88-8754-a386270f590d") },
                    { new Guid("4dce5792-7451-4108-b945-ae691312465c"), null, null, "Damian55@hotmail.com", new Guid("dc5f8e5e-be11-43f9-acd2-648e38e09946") },
                    { new Guid("4e010967-b47c-4796-a05d-1eec33e98eb0"), null, null, "Alfredo_Kunde41@yahoo.com", new Guid("aeae0f68-579f-46b8-bee2-c797ee09ee5e") },
                    { new Guid("4e0f0b84-9227-469f-8b19-dda210feee19"), null, null, "Tamia.Ledner68@gmail.com", new Guid("bbaf9fe2-9863-4589-964a-23c62e6bf830") },
                    { new Guid("4f4f351b-10ab-477c-8365-8d315de02055"), null, null, "Patience6@yahoo.com", new Guid("2e3a99a4-4308-410d-b67e-4763bbd6b9c8") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("4fc920ff-7abd-49aa-a211-a34eb8e222dc"), null, null, "Erling.Cremin24@gmail.com", new Guid("5d203345-c58f-4236-9e46-c9ba7a8529a5") },
                    { new Guid("5139c6bc-bd58-4d9a-9a1c-3f280799499d"), null, null, "Landen.Willms96@yahoo.com", new Guid("c7f42761-e210-47b4-9e39-2df36dce4c96") },
                    { new Guid("51e85110-dcf1-4b34-986d-60a58b3b2660"), null, null, "Mohammad_Lesch@gmail.com", new Guid("0877dbd6-c025-49ef-b189-53b217500382") },
                    { new Guid("520cc863-1ca2-4b44-9af7-546442d5a4e8"), null, null, "Keira_Goldner@gmail.com", new Guid("3ee0e809-4d8b-4164-a824-c5ab67903af7") },
                    { new Guid("5212e3cb-42a6-4a91-8f6c-7d767b6f9e20"), null, null, "Willow.Waters12@yahoo.com", new Guid("0773e360-956e-4d39-94c5-d0906a9e4557") },
                    { new Guid("5235cc41-0f3d-4eb8-b3a9-0549da8d171e"), null, null, "Daryl33@gmail.com", new Guid("1937fdf7-97b0-4102-95c9-2163eb910112") },
                    { new Guid("525dc54c-5338-4873-a893-3ffb0fe93b34"), null, null, "Ella_Bernhard@hotmail.com", new Guid("d29932a8-80f8-42b1-85e0-6bf810161455") },
                    { new Guid("529c63bc-4c4b-4807-a02e-f127b6af402e"), null, null, "Cielo55@gmail.com", new Guid("5c5b9127-2aa5-4ed6-b779-6402154d5c0f") },
                    { new Guid("52aa404e-0191-4fb1-b43a-cba4b1c47924"), null, null, "Rosanna_Swift@yahoo.com", new Guid("719d1670-ba7d-4e9b-b4de-d7074f81aa66") },
                    { new Guid("533d9251-7641-453e-b3c7-bd66290f053d"), null, null, "Madge.Gutkowski@gmail.com", new Guid("6b5cd903-9056-4302-b3e6-b910c3a67f76") },
                    { new Guid("53c1b932-9a1c-4149-9fbc-ae38a462a010"), null, null, "Ida.Abernathy@gmail.com", new Guid("72a42c8b-ed7c-4e7a-81c6-313cac897b20") },
                    { new Guid("54560370-26c3-4a23-9e5b-cd60858f60cd"), null, null, "Dasia_Jacobi84@yahoo.com", new Guid("6c16f159-98d6-4d70-a7ac-43b19b827d49") },
                    { new Guid("54c3f75d-5c05-483b-bee6-f47526a82e41"), null, null, "Edyth70@gmail.com", new Guid("f2c5c231-fa4f-4403-a17b-f986cd15543a") },
                    { new Guid("54d4a954-4396-47be-b31a-b621aefef2b7"), null, null, "Joanne.Donnelly@hotmail.com", new Guid("c6e8a5d8-6660-4e85-9ff9-1e6ec6d0c580") },
                    { new Guid("550e2366-f080-4230-8fe1-f41bbf112762"), null, null, "Jazmyn38@gmail.com", new Guid("ac4ee7ff-56c7-4c45-ba3e-32ed6d9370f3") },
                    { new Guid("56035e7a-64de-41bd-acf7-075e86208f8f"), null, null, "Alice15@yahoo.com", new Guid("adbbd240-641f-475b-b705-5e35298ef012") },
                    { new Guid("56668013-a3c1-4690-a58f-37fa9ea8be29"), null, null, "Kylee_Jaskolski62@yahoo.com", new Guid("c5513371-ea13-4b3b-ab65-8bbb471b2afc") },
                    { new Guid("566e44df-0c7d-4949-a197-8af73849305f"), null, null, "Eryn51@yahoo.com", new Guid("c2701daa-7747-422a-bb74-d9ffc8e0f5fc") },
                    { new Guid("5693c20c-f249-4b66-a1e7-40f8dea88c16"), null, null, "Lance22@hotmail.com", new Guid("e41a0e5f-468e-496b-8fe7-b8f4b2a0f962") },
                    { new Guid("56b63c6e-b717-466f-9eda-4b48eb967a26"), null, null, "Jermain_Lockman22@hotmail.com", new Guid("487f0344-4cde-4b10-971a-1f8311cce3f5") },
                    { new Guid("5733fdea-a82b-4b09-9c06-d71fcb1650f6"), null, null, "Vern58@hotmail.com", new Guid("9ee8d8bd-022b-4718-b8f4-cc38174e988c") },
                    { new Guid("574640b4-aba6-476b-94bb-0b9b20d36640"), null, null, "Tod.Goldner@gmail.com", new Guid("c66d96b2-e569-4470-a3b9-82ba83e46c97") },
                    { new Guid("5767fe58-a594-4842-9bc1-6320f61942cb"), null, null, "Madalyn_Maggio14@gmail.com", new Guid("c7f42761-e210-47b4-9e39-2df36dce4c96") },
                    { new Guid("578cec45-f0ee-498f-a1c9-dece32e77291"), null, null, "Juliet.Sanford@hotmail.com", new Guid("92d6cbc1-d409-403c-b274-517d31726ae9") },
                    { new Guid("57b36a57-4b7c-4983-9f0c-31d86715013d"), null, null, "Jerrell_Ward19@gmail.com", new Guid("718a03a0-2841-450f-a417-5345b18c81ab") },
                    { new Guid("57c98ec3-4851-4be7-b149-078d4cc54eae"), null, null, "Viviane51@yahoo.com", new Guid("815c5bf5-7253-492e-81c8-82e2d6860602") },
                    { new Guid("57d895a4-9934-4736-9fe1-6cec4690780b"), null, null, "Dayne2@yahoo.com", new Guid("753e85fe-b18a-442a-b91e-1d9dc9216d93") },
                    { new Guid("57e3b6d3-5ac7-4d7c-b5ed-38fbea9476fe"), null, null, "Emily_Olson@hotmail.com", new Guid("9e96d314-cd64-47aa-a5bc-7e0525cc9914") },
                    { new Guid("57e89206-7ffc-4ddd-8057-09e759fd2348"), null, null, "Jazlyn98@gmail.com", new Guid("cf348fa5-7d32-48ec-957c-eb481beb0358") },
                    { new Guid("5835edea-1ef3-46ac-8ea2-449076067c21"), null, null, "Nya.Hand56@hotmail.com", new Guid("50fa1a40-d4af-4edd-8c00-61ec693395b2") },
                    { new Guid("5885ca09-52a8-4dd1-a217-d9a73c47c1c1"), null, null, "Valerie_Kris@gmail.com", new Guid("c58f524e-a96e-4e8b-9186-6c21d38d64b3") },
                    { new Guid("58987f33-bb4e-432a-abbf-a5c087a658c5"), null, null, "Mckayla.Stehr@hotmail.com", new Guid("67a258f9-5c48-4651-8f32-1ee7f5b4246d") },
                    { new Guid("58ebcfbc-4442-4190-8567-53b9715a636a"), null, null, "Piper_Wintheiser@gmail.com", new Guid("3712e35b-2da9-4c76-ad88-28828e776a5c") },
                    { new Guid("5991ca11-519f-4a10-b14d-0a9ea833f704"), null, null, "Nettie.Ferry86@gmail.com", new Guid("8b3afef3-3bbb-4237-b8b8-1eba1df7757e") },
                    { new Guid("59c4d274-dac7-465a-bb98-d9898bb4af71"), null, null, "Jovany_Okuneva@hotmail.com", new Guid("07e77ffa-7983-4cb3-bfa5-a4b8ed39f91f") },
                    { new Guid("5a5b6483-3426-4a65-92dd-755ca8172957"), null, null, "Angelo52@gmail.com", new Guid("57b666b4-3a1b-4303-851f-a88f5f534543") },
                    { new Guid("5ab9976c-ff53-414a-898c-759e8368eb03"), null, null, "Keanu_Hauck79@gmail.com", new Guid("5f366c1b-9e38-4bc9-b773-fca63347cbcc") },
                    { new Guid("5acb2fd3-26f7-458b-8ce0-be2e11644a87"), null, null, "Tiana_Legros@yahoo.com", new Guid("5aff4312-b9a9-4958-b14a-305be3aa9f4b") },
                    { new Guid("5aeb7781-81cf-4863-8765-a36a32f59557"), null, null, "Phyllis.Nikolaus@yahoo.com", new Guid("64e0a0ed-41a2-429f-800b-6407610d5984") },
                    { new Guid("5b47f47f-30b7-4793-9b6e-54b91a1fc535"), null, null, "Ettie.Pfeffer27@gmail.com", new Guid("99d4724f-46db-42d2-a62b-3d8fa528e130") },
                    { new Guid("5bc8fcdb-3825-448b-98e8-6f1099a46db6"), null, null, "Clinton.Thompson@hotmail.com", new Guid("63107baa-d978-4764-b959-7e90a1de3ee0") },
                    { new Guid("5c255b52-83ae-4f42-ba9f-3f420c556d27"), null, null, "Breanne.Vandervort@yahoo.com", new Guid("658f3ddd-678c-4dca-b9fa-45901c0f1c05") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("5c31695f-9161-4c54-ba2f-87364ed3e8a6"), null, null, "Francesca_Dickinson@gmail.com", new Guid("0ec010bc-7e48-4cb9-bb93-8dd9d5b37f6d") },
                    { new Guid("5c3dbd39-93d5-4c51-bd57-487edcde8666"), null, null, "Heloise65@gmail.com", new Guid("42c4353e-7775-4c68-a647-2b921bb87c89") },
                    { new Guid("5c4aeafa-8e24-4e77-afc5-86c84e4d5de8"), null, null, "Cecile.Corkery@gmail.com", new Guid("0e6930e6-cf0a-4195-8d74-a9cc0dfb30b6") },
                    { new Guid("5c4fa491-06fe-4b5f-9998-9718b4819eb7"), null, null, "Schuyler86@gmail.com", new Guid("cf3285c8-97d7-426d-87f3-e0854194e226") },
                    { new Guid("5c63556a-7c75-43e6-8d3d-84f38b58c95b"), null, null, "Oswaldo_Little69@hotmail.com", new Guid("6f196aeb-f350-478e-a23f-992b0ea6da29") },
                    { new Guid("5c68fe2d-db21-4db9-a2ef-f2eb78485098"), null, null, "Hassie43@yahoo.com", new Guid("c5513371-ea13-4b3b-ab65-8bbb471b2afc") },
                    { new Guid("5ce3013e-4965-4f75-be8e-94f00cd74aa5"), null, null, "Sherman.McCullough14@hotmail.com", new Guid("82f7ffb4-bdb1-40a8-8d2d-67f1c2f5bf91") },
                    { new Guid("5dec31fa-91e8-4006-90ef-26362af1e634"), null, null, "Alivia51@yahoo.com", new Guid("db32027d-cf9c-4544-af7d-d20c917925c7") },
                    { new Guid("5e0eb643-88fc-4b51-bfa6-0a535d847b09"), null, null, "Johnathan80@gmail.com", new Guid("4ecad1f7-2b37-4dd8-be42-dedd60205e81") },
                    { new Guid("5ea446d8-b1e7-49c6-90f9-66855c27a6a0"), null, null, "Florida.Schaden@gmail.com", new Guid("5c5b9127-2aa5-4ed6-b779-6402154d5c0f") },
                    { new Guid("5ef99f59-8118-43c2-b6e9-ae3e5aad1407"), null, null, "Maximilian.Hodkiewicz14@hotmail.com", new Guid("07e77ffa-7983-4cb3-bfa5-a4b8ed39f91f") },
                    { new Guid("5f8284e1-0621-4425-8c97-b469cb16bffe"), null, null, "Emery_Botsford@yahoo.com", new Guid("36ffb969-580b-40d2-8fa0-94749ea99214") },
                    { new Guid("5faf7f1b-b41c-4435-a812-724f36e5d409"), null, null, "Elisa_Douglas@yahoo.com", new Guid("d3cba19c-d75f-49cd-8bce-3e5563428a3a") },
                    { new Guid("5fcb1c65-4d05-4bd0-bb7e-1c4d9eda9296"), null, null, "Jany86@gmail.com", new Guid("54c975d2-dbfe-4626-97fa-ceaa28e85030") },
                    { new Guid("5fee8bfd-dd4c-4256-b96a-753ad72af238"), null, null, "Savannah64@gmail.com", new Guid("1bab23ea-659b-4531-ad24-fdfd8984675d") },
                    { new Guid("602017a6-f3b7-4d00-81bf-b002dd3694df"), null, null, "Darian_Roberts@gmail.com", new Guid("76c44275-2d3e-43e9-b34e-c05f912213b8") },
                    { new Guid("603bec89-7f7a-49c5-a7f9-2e2dc7a6e40d"), null, null, "Libbie.Streich@gmail.com", new Guid("0773e360-956e-4d39-94c5-d0906a9e4557") },
                    { new Guid("604ba572-1b16-4f10-b037-5604bd78905a"), null, null, "Zoie.Stanton12@hotmail.com", new Guid("6ab8f9db-6513-4d8f-9cde-7b925ff51057") },
                    { new Guid("60a9211a-edf7-414b-b071-e86210badc56"), null, null, "Isaac91@yahoo.com", new Guid("99d3bf2d-5ff0-41e8-b115-9bf94eab6881") },
                    { new Guid("6109153b-c8b4-4522-b23a-e23e8ab4e7fc"), null, null, "Salvatore59@gmail.com", new Guid("22edc826-6747-4099-aca5-578199353ac6") },
                    { new Guid("613173d5-0fd2-45c8-97e6-d26d0dada9d2"), null, null, "Hayden23@hotmail.com", new Guid("affd1717-742a-4014-8e72-3420c7496c1e") },
                    { new Guid("616ae8ae-5b4b-41b7-b6d1-fb8a302548db"), null, null, "Hilario.Kuhic@gmail.com", new Guid("a2c81266-ca25-4e08-bddc-c6ccfe9435e2") },
                    { new Guid("617adeff-35aa-41f9-99b6-011ae766db34"), null, null, "Cameron_Mitchell@hotmail.com", new Guid("0877dbd6-c025-49ef-b189-53b217500382") },
                    { new Guid("61d42bbd-01d5-4e4a-a3d2-2d241bbe7332"), null, null, "Jodie.Feeney43@yahoo.com", new Guid("530579fa-33a7-4827-a21f-b9cacab42c7d") },
                    { new Guid("61e1c0a3-28c4-4a0f-8aab-3232d7273d38"), null, null, "Caesar.Pouros@gmail.com", new Guid("c3cc5785-6364-48fa-bb83-e7ac33fc672b") },
                    { new Guid("6217c121-b6c7-46f0-9fa8-7ac9ed0a5d5a"), null, null, "Savannah_Dooley7@yahoo.com", new Guid("1e17494c-b19d-4879-af0e-c6575db6bd37") },
                    { new Guid("629c5201-fa4f-4638-9de4-ec9c700fc8a3"), null, null, "Enrique_King21@hotmail.com", new Guid("1a21f215-231c-4e09-b7c2-4e3163978286") },
                    { new Guid("631318b8-8da7-4761-b445-b9da2f7729e9"), null, null, "Clyde.Langosh68@yahoo.com", new Guid("c7c0cd55-07d8-41cc-9d2b-4bd04cb7edb3") },
                    { new Guid("63af45ec-0b58-40a8-a41a-74bfb4967a01"), null, null, "Josephine.Hickle@yahoo.com", new Guid("b1817475-7a6c-44d8-8e81-4b59b1f4923e") },
                    { new Guid("63e61937-d935-4f8d-9f86-dd940a3803ab"), null, null, "Hillard_Mayert69@yahoo.com", new Guid("9cf1e944-d004-426c-83ee-acb2b8793bc6") },
                    { new Guid("63e69090-f43d-4c67-bf82-9a1e3acbb099"), null, null, "Theodore_Bayer@gmail.com", new Guid("cf348fa5-7d32-48ec-957c-eb481beb0358") },
                    { new Guid("64188bd1-c795-4da7-bda7-8090897ec9ff"), null, null, "Rhea90@hotmail.com", new Guid("672ce079-171b-4f7e-b744-6b9376e96b61") },
                    { new Guid("6444c5ee-26a5-4c0d-b7c6-23ee05312d62"), null, null, "Nicklaus_Gorczany28@hotmail.com", new Guid("394e6c37-a398-4cf7-983d-8fb216e6c46f") },
                    { new Guid("64f58135-aed1-49df-b07c-9277f5197f96"), null, null, "Lillie_Wintheiser36@yahoo.com", new Guid("9e39f449-ecbf-4238-8ca8-47309c134789") },
                    { new Guid("656c10ec-3169-4296-8524-0c807bc2be86"), null, null, "Janessa.Hand@yahoo.com", new Guid("97e11482-d5e6-41d7-82e3-80806df9c3bc") },
                    { new Guid("665abb80-0725-4e44-9c3b-ff961205e744"), null, null, "Kailey41@yahoo.com", new Guid("8c060e9b-2ea2-4602-8535-ce147e60fcbd") },
                    { new Guid("671288e7-3139-4e40-b998-ef95d153d36e"), null, null, "Cameron.Marvin@hotmail.com", new Guid("482632b6-5f62-4fe4-82e0-1b6f0d3ee842") },
                    { new Guid("673a936f-057a-41d1-80c0-b9f9aa33d914"), null, null, "Kamille.Kuhn@gmail.com", new Guid("08589d86-24cf-48ee-b140-eab54649e215") },
                    { new Guid("673f5126-9e7f-4e95-9862-856f105a69ff"), null, null, "Baron.Kilback17@gmail.com", new Guid("01424fda-76cf-4203-995c-a75e43c1d1d0") },
                    { new Guid("681cbd64-dc55-4538-bfdf-4ed92d7846bf"), null, null, "Tristian_Balistreri@hotmail.com", new Guid("5f366c1b-9e38-4bc9-b773-fca63347cbcc") },
                    { new Guid("6824c451-eb91-40cb-8e68-5501cd837bb7"), null, null, "Stan_Hermann63@yahoo.com", new Guid("2b5f8a6c-d3e8-41ff-8867-cadb6cd16ea4") },
                    { new Guid("6883b2be-c503-492d-b9e1-5d9f5dfaf67e"), null, null, "Coleman_Quitzon@hotmail.com", new Guid("7de3e658-53a0-464d-a4aa-b7bf40828f5d") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("68a0e4a4-a2a0-42fe-a341-50864cd8bbeb"), null, null, "Malvina76@hotmail.com", new Guid("c6e8a5d8-6660-4e85-9ff9-1e6ec6d0c580") },
                    { new Guid("68da0453-9b4e-49f5-b78f-8232c437c32f"), null, null, "Tony49@gmail.com", new Guid("980189d0-dcc8-4676-93bf-39ec81288e2f") },
                    { new Guid("68e80378-9c51-42b4-bc2d-8fc7eed33929"), null, null, "Adell52@hotmail.com", new Guid("76c44275-2d3e-43e9-b34e-c05f912213b8") },
                    { new Guid("692bab07-34ed-4025-8aaa-c35de89507ba"), null, null, "Eulah71@hotmail.com", new Guid("5c6a10ae-343d-47fa-9381-6cbe7b1a68be") },
                    { new Guid("69326f77-8fe7-4d30-8626-888642cee95a"), null, null, "Samanta_Conn@hotmail.com", new Guid("78be92c8-3390-4d5e-aa3a-54c7301eaf2f") },
                    { new Guid("69cb7bed-8758-4312-8ba3-4a269856f552"), null, null, "Amari.Cremin81@hotmail.com", new Guid("3b3e9016-3025-48e3-93b2-fa474015c0f7") },
                    { new Guid("69e0e613-bb0c-4c50-81cd-a9952f831eab"), null, null, "Lavada9@gmail.com", new Guid("3712e35b-2da9-4c76-ad88-28828e776a5c") },
                    { new Guid("69e7c434-d717-4a18-9917-24c26cdae88f"), null, null, "Brandy.Rolfson@yahoo.com", new Guid("a419df27-9358-4a02-9ab7-2f2e2344fae0") },
                    { new Guid("69f6431a-79d3-442f-b84b-917096b700b9"), null, null, "Ambrose_Jast@gmail.com", new Guid("757f3f70-fdce-4727-8fcf-9ac8aa0287b3") },
                    { new Guid("6a316cee-f3a9-4c40-be45-ca6114a42bb7"), null, null, "Terrill.Schinner@yahoo.com", new Guid("3c3a765d-c1b9-47c7-b39a-7b5dc35e1cbc") },
                    { new Guid("6a6af3de-d380-443c-bdd2-296cc73db73c"), null, null, "Coy98@hotmail.com", new Guid("3a19b458-72b3-4b5b-97e6-334a56d7d557") },
                    { new Guid("6a7fa4df-59d9-41f4-8880-b6041abaec45"), null, null, "Erich4@gmail.com", new Guid("8dca8632-b27c-44ad-bd6c-0d7679a4f075") },
                    { new Guid("6b1f98d3-5f21-44b9-81c5-73a824eaf323"), null, null, "Aracely.Predovic@yahoo.com", new Guid("548e47d4-b851-4432-8514-fc092768db5b") },
                    { new Guid("6b818e3f-c77c-45f9-bab5-664aac15aaee"), null, null, "Andrew.Miller@hotmail.com", new Guid("6f109fcf-941c-474c-810c-243f75df54d6") },
                    { new Guid("6bf74313-4148-4938-ba60-0dba03223317"), null, null, "Zoie_Klocko58@gmail.com", new Guid("ddf2bc3e-21a3-4bd8-8ebc-4afb8cb49df0") },
                    { new Guid("6dc5b263-bd96-48fc-bed8-e98622f491ab"), null, null, "Grant.Hand@gmail.com", new Guid("819538c4-628a-4b17-a719-8274b53093f3") },
                    { new Guid("6deb2164-7b5a-4f60-9719-c3475ba3d501"), null, null, "Enos.Homenick@hotmail.com", new Guid("1cdde210-cf9c-4b69-a64c-3995a2267739") },
                    { new Guid("6e4c3323-1d85-4489-ad0b-e500cc0b0719"), null, null, "Jarrell_Cummerata@gmail.com", new Guid("3314d8f7-2262-4e19-afd4-3e85972480b8") },
                    { new Guid("6e5257c2-da5e-4c82-aae9-05835fe84bab"), null, null, "Myriam.Stiedemann@gmail.com", new Guid("c58f524e-a96e-4e8b-9186-6c21d38d64b3") },
                    { new Guid("6e675c09-eb88-491e-a32f-f57551943776"), null, null, "Carey_Veum@gmail.com", new Guid("c36bd526-4a45-4a4b-9d0e-50c279e9b939") },
                    { new Guid("6e68520b-8bc7-4510-9188-5510388683b8"), null, null, "Rowland_Hayes83@gmail.com", new Guid("54c975d2-dbfe-4626-97fa-ceaa28e85030") },
                    { new Guid("6ebc3b6c-98e4-433e-a53c-b6df48d10019"), null, null, "Marcelino.Reichel54@hotmail.com", new Guid("db91ddfb-75b6-4d51-82ea-52631a102b16") },
                    { new Guid("6fcdb588-4adf-47b8-a3f7-b130bac195c1"), null, null, "Elyse28@hotmail.com", new Guid("df1ba0e6-99b8-419d-a3b8-cece7c4928bd") },
                    { new Guid("703e932a-50c3-448d-8e39-706eb341e10d"), null, null, "Jerrell.Harber47@hotmail.com", new Guid("3a19b458-72b3-4b5b-97e6-334a56d7d557") },
                    { new Guid("70b643b8-5c29-4e5a-bb67-4172c97195ab"), null, null, "Rafael.Weber76@hotmail.com", new Guid("8a696f30-76c2-40db-a250-030829547d67") },
                    { new Guid("7101e56c-3b17-4cf0-9c6c-667f6faea522"), null, null, "Corrine_Glover@gmail.com", new Guid("56b8dced-e510-417c-8b93-8a2cb06b845a") },
                    { new Guid("7180c00a-8d12-4607-9a90-8bd82d7ea724"), null, null, "Maida71@gmail.com", new Guid("4d006d0d-8a50-4d81-886b-176313d018fb") },
                    { new Guid("71986da1-4c30-47e7-ba69-09eace671fcc"), null, null, "Gianni.Kling43@hotmail.com", new Guid("59a9232d-40d9-422d-8a1a-fe022e85093a") },
                    { new Guid("7215c2dc-3c58-48bc-abb3-28e8108dad72"), null, null, "Peggie88@hotmail.com", new Guid("5e1f9cf6-8e77-46be-92e7-b3f10da0ed86") },
                    { new Guid("722ec755-7495-47b2-afc9-5be28ca6fae1"), null, null, "Kennedi.Cormier@yahoo.com", new Guid("d1d503de-e688-46df-9a53-6ca07b1d716f") },
                    { new Guid("72407ad7-d197-4551-bad1-f1fdb60eb787"), null, null, "Sylvan.Abbott5@gmail.com", new Guid("7abaa815-d503-4740-a0a9-20d8752fc2cf") },
                    { new Guid("726cb953-e833-4b74-a421-dd0571d36d79"), null, null, "Jacques_Macejkovic@hotmail.com", new Guid("3ee0e809-4d8b-4164-a824-c5ab67903af7") },
                    { new Guid("726f4a28-15c2-4c48-9288-34b77ea98d45"), null, null, "Mireya.Marquardt@hotmail.com", new Guid("b8e5286e-6ec4-4001-89c4-e17065f9bf09") },
                    { new Guid("72795780-39ee-4f92-bdea-947658ca474c"), null, null, "Dean66@gmail.com", new Guid("5d1e2a88-0f0a-4b6e-a524-e279224a1944") },
                    { new Guid("727e0078-6395-40cb-828d-75d0cd391168"), null, null, "Sam.Lebsack45@yahoo.com", new Guid("1b1ebe07-5765-4728-8b40-ee14061347ae") },
                    { new Guid("7287d556-7878-401a-946c-d9afe539b7d7"), null, null, "Tad93@hotmail.com", new Guid("93e9e8fa-8b76-4968-a1ef-a4d59b6958ea") },
                    { new Guid("728a40c3-3560-45d5-9be3-eb798aee98af"), null, null, "Gilberto.Treutel13@gmail.com", new Guid("0447d1d8-3e48-4d64-8d2e-7d9a733628ec") },
                    { new Guid("728ca3bb-a286-4ca8-8de7-6924d59f2c94"), null, null, "Candida_Goodwin@hotmail.com", new Guid("097cb7d3-d333-48aa-b8ee-cacd11ee91fa") },
                    { new Guid("7296babe-8970-4af1-a63e-6fca40605a7b"), null, null, "Shaylee.Corwin@yahoo.com", new Guid("080ced29-2e70-40de-82e4-0a2d478fe53e") },
                    { new Guid("733fa878-cc23-4d60-91a1-b6f6bf99838e"), null, null, "Freeda.Abernathy@gmail.com", new Guid("5aff4312-b9a9-4958-b14a-305be3aa9f4b") },
                    { new Guid("738b2e55-74b5-4876-9069-aebb26bdc469"), null, null, "Alvena.Wilderman35@gmail.com", new Guid("2700d101-47ef-4c75-a3e1-b613514a94f0") },
                    { new Guid("73ecf732-955f-46e2-8710-04346ea66989"), null, null, "Lizeth.Ziemann56@gmail.com", new Guid("ed5c634a-32ee-48fd-80f4-26cfb1c72602") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("7441b949-ceb8-47ee-8c9c-c9f711b14685"), null, null, "Granville.Dibbert@yahoo.com", new Guid("a6a8eca4-cb2e-43f7-9ea2-cbc644c8f9d8") },
                    { new Guid("74b67ff7-d7cc-46ef-b475-4e3d8a5475b6"), null, null, "Scot_Kub@gmail.com", new Guid("2f8c0b43-80b3-437b-8a84-a763ed30230e") },
                    { new Guid("752e01fc-04c4-4edb-b993-7b5938fe03c5"), null, null, "Harrison_Kub@gmail.com", new Guid("9e96d314-cd64-47aa-a5bc-7e0525cc9914") },
                    { new Guid("7547b28f-257b-4e74-8188-fa55fc081b42"), null, null, "Herta_Pacocha5@hotmail.com", new Guid("9ec54876-333f-4825-9959-c839395cb66e") },
                    { new Guid("75e6ca3f-9c2a-4591-85cd-1be8d614c030"), null, null, "Vernice.Hirthe31@yahoo.com", new Guid("77bc83c5-7598-48f0-b4c1-23f76fd277ca") },
                    { new Guid("76117655-5692-45a8-9f9f-eb058bdb64d0"), null, null, "Donato_McLaughlin@hotmail.com", new Guid("54c975d2-dbfe-4626-97fa-ceaa28e85030") },
                    { new Guid("7649dc21-52cb-4869-9565-bb9e2d09868f"), null, null, "Chelsea84@gmail.com", new Guid("ed5c634a-32ee-48fd-80f4-26cfb1c72602") },
                    { new Guid("764fbbf3-eeb6-414a-b0ea-7e34a72aae7a"), null, null, "Wilford_Hamill@hotmail.com", new Guid("d57e07f1-63a6-4514-ae7a-51f83c901e2c") },
                    { new Guid("7728b509-6e53-417e-b4ff-8b8c49364de1"), null, null, "Agustin.Schumm@hotmail.com", new Guid("cf611bf3-21fb-4ed7-a138-00c7afdda9ba") },
                    { new Guid("7747b031-e75e-4452-8ce2-486b23a031e6"), null, null, "Tyshawn.Frami@gmail.com", new Guid("3f1a1c74-7f9a-433e-808b-f0d69f6d97e7") },
                    { new Guid("77a83baa-0390-4be8-bc36-db04376c88cb"), null, null, "Yvette.Hermann99@yahoo.com", new Guid("8ce72c63-9c31-4159-9ba2-012a4fc3df72") },
                    { new Guid("78367f70-c780-474e-b2e9-a2e15c3d4890"), null, null, "Erin.Quigley97@gmail.com", new Guid("0635daf3-649c-437b-92ef-713d43246a0a") },
                    { new Guid("783f6992-6402-4a59-a36e-92fab1ff6a2c"), null, null, "Brown_Pagac70@hotmail.com", new Guid("dd550cd7-4eae-4d75-8be5-5f3e496fdd24") },
                    { new Guid("7897bf8b-7fda-4f07-89a5-562d2c0510e8"), null, null, "Edwardo.Abernathy36@yahoo.com", new Guid("76c44275-2d3e-43e9-b34e-c05f912213b8") },
                    { new Guid("78b39514-6cde-4643-98b2-c500ea2a560c"), null, null, "Jalen_Berge87@gmail.com", new Guid("78be92c8-3390-4d5e-aa3a-54c7301eaf2f") },
                    { new Guid("78e2634a-73e0-4c03-b991-f7aaf7dac4f8"), null, null, "Rubie.Botsford@yahoo.com", new Guid("ddf2bc3e-21a3-4bd8-8ebc-4afb8cb49df0") },
                    { new Guid("79097831-3e59-4d79-af46-6b702b561b26"), null, null, "Brett_Muller82@gmail.com", new Guid("1381d1cd-5c11-46c1-bc37-987b3f5ae33e") },
                    { new Guid("79ea2870-5801-4870-974d-b50827ed846c"), null, null, "Adelbert_Denesik12@yahoo.com", new Guid("06f4c32b-9a3d-4b38-99a4-56ea0ba685a8") },
                    { new Guid("7a0a62b7-4a86-41f5-afd8-c7d936e2f5e1"), null, null, "Iliana_Wolff63@gmail.com", new Guid("ac5a7dc0-9da2-4c23-9acc-ec9828404cd5") },
                    { new Guid("7b85c126-1ce1-4314-979c-a2ae8c20c44a"), null, null, "Luella_Jones@yahoo.com", new Guid("b53497b3-fabe-4282-a5c6-ef6e82864309") },
                    { new Guid("7ba8aa6c-4a05-465d-9f32-09c71b0968aa"), null, null, "Keshaun27@hotmail.com", new Guid("74ef9233-8d34-4883-8938-b78b6c147246") },
                    { new Guid("7bde0819-ed32-4dfc-bc91-5ef184d8aeb7"), null, null, "Hildegard55@hotmail.com", new Guid("c590f92c-3ca1-4a33-a976-926995a0f7cc") },
                    { new Guid("7bf6433e-b371-49ac-98e0-c928c3be446e"), null, null, "Melissa_Roob@hotmail.com", new Guid("b1817475-7a6c-44d8-8e81-4b59b1f4923e") },
                    { new Guid("7c8162d7-9bcc-4a15-b70e-04ff62fe181c"), null, null, "Ottis21@gmail.com", new Guid("50ac14d1-c13d-42f2-8026-301c38b1964b") },
                    { new Guid("7cbfd1e5-872c-4537-8d05-a2832032d6f0"), null, null, "Abigail_Lakin@hotmail.com", new Guid("2700d101-47ef-4c75-a3e1-b613514a94f0") },
                    { new Guid("7ce82383-e99f-4e1d-85de-f2f62192c5e7"), null, null, "Carole_Krajcik21@hotmail.com", new Guid("f51931e0-68b3-4aed-8f03-7ef9a8526650") },
                    { new Guid("7d98fc73-7579-4139-9ed4-33ca49a423ff"), null, null, "Courtney.Kozey90@gmail.com", new Guid("ab451099-7866-44e4-9ebd-f1162ea6206a") },
                    { new Guid("7ea6b36e-9255-4d12-82d4-4beadf8400da"), null, null, "Magnolia_Wisoky@hotmail.com", new Guid("0a8fb680-a380-4d35-85da-ff3cf9faa245") },
                    { new Guid("7f6016eb-c81f-4ea6-9242-36b22c067ce1"), null, null, "Deondre29@yahoo.com", new Guid("aeae0f68-579f-46b8-bee2-c797ee09ee5e") },
                    { new Guid("7f8656b1-4ad6-4569-b0cb-e06051fa3bee"), null, null, "Darren12@gmail.com", new Guid("c3cc5785-6364-48fa-bb83-e7ac33fc672b") },
                    { new Guid("8020c9b7-58e1-4822-ae30-15a7d4438256"), null, null, "Russ.Gerlach86@yahoo.com", new Guid("7abaa815-d503-4740-a0a9-20d8752fc2cf") },
                    { new Guid("8035db4e-e3be-4840-b04e-837a6b18d218"), null, null, "Deborah52@gmail.com", new Guid("42babbec-5dbe-4cc3-9f68-bb4bc7ad9491") },
                    { new Guid("806ee259-95a7-4991-9caa-332d67f4150e"), null, null, "Al.Haag@yahoo.com", new Guid("8c060e9b-2ea2-4602-8535-ce147e60fcbd") },
                    { new Guid("80b29042-9644-423e-8405-f2edf11aa9bc"), null, null, "Emiliano.Becker97@gmail.com", new Guid("2c87eaa4-8e07-41f4-bad0-935d07541e78") },
                    { new Guid("8180626b-69c4-4a26-87a7-695c3d7cb29a"), null, null, "Halie34@hotmail.com", new Guid("2f8c0b43-80b3-437b-8a84-a763ed30230e") },
                    { new Guid("81c68403-ccfb-4d5c-877d-373452e220a0"), null, null, "Koby61@gmail.com", new Guid("c3cc5785-6364-48fa-bb83-e7ac33fc672b") },
                    { new Guid("82825d5e-d9b8-4bf4-b744-062390128864"), null, null, "Candida_Becker3@gmail.com", new Guid("50b1b40f-32d2-45da-a690-b9d24fff476e") },
                    { new Guid("82a116bb-5cf6-48aa-a910-2920d12b1236"), null, null, "Julian56@gmail.com", new Guid("de7e4623-27a6-4a10-8c19-1f8ae8f689d2") },
                    { new Guid("82ef717f-cb1b-403d-ab17-d5372afa5d20"), null, null, "Halle.Powlowski@yahoo.com", new Guid("7da75a84-c857-4768-9ff2-252052ea5333") },
                    { new Guid("834f0e4a-b296-4968-b732-206327dd5ae6"), null, null, "Alvera.Satterfield@gmail.com", new Guid("ac984856-387b-48de-9d39-5cfa956d354e") },
                    { new Guid("83dd5e1d-51ce-41d5-ad50-996de28d078c"), null, null, "Adan_Bernhard@hotmail.com", new Guid("82b99640-3f2e-425b-a088-51b3c226a192") },
                    { new Guid("83ea4f70-3411-4022-b0f5-722994fc4125"), null, null, "Torey57@gmail.com", new Guid("097cb7d3-d333-48aa-b8ee-cacd11ee91fa") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("83f7e6d4-7dc5-4356-b351-e911bc7a540a"), null, null, "Jerald.OReilly@gmail.com", new Guid("64174d68-43d3-488f-89bf-23d32b134019") },
                    { new Guid("843cded2-e763-4e34-a881-fba41598d83f"), null, null, "Shea.DAmore@yahoo.com", new Guid("f7dacdb6-cd5e-4c55-a2df-710f582d75f2") },
                    { new Guid("844b7267-5ab3-4777-b6cd-7ab55c8acf78"), null, null, "Pierce_Gutkowski62@gmail.com", new Guid("c221f46b-a606-417e-aead-c8b255d84d11") },
                    { new Guid("850e2b67-1df7-4bd5-9db6-85bf4e603ad4"), null, null, "Wellington.Brekke@hotmail.com", new Guid("0b65bf95-8c8c-4e28-8317-122f0f66a78e") },
                    { new Guid("851ce193-b341-458e-8097-a821caa88863"), null, null, "Isobel90@yahoo.com", new Guid("672ce079-171b-4f7e-b744-6b9376e96b61") },
                    { new Guid("8586cb19-7373-4f4a-820c-689ae73031b9"), null, null, "Martin27@gmail.com", new Guid("6ab8f9db-6513-4d8f-9cde-7b925ff51057") },
                    { new Guid("85b85379-a953-4b2e-a10d-6e7675154e9f"), null, null, "Emil5@yahoo.com", new Guid("82f7ffb4-bdb1-40a8-8d2d-67f1c2f5bf91") },
                    { new Guid("85f3a1ae-87ec-4c15-a6b7-b94135e0e822"), null, null, "Rosie.Bins99@hotmail.com", new Guid("72a42c8b-ed7c-4e7a-81c6-313cac897b20") },
                    { new Guid("8694aefc-2fa5-48b7-a166-b275b8f4fec3"), null, null, "Leonardo.Block@gmail.com", new Guid("ddf2bc3e-21a3-4bd8-8ebc-4afb8cb49df0") },
                    { new Guid("86d4dc5b-937a-4bce-89cb-125c6f1b65af"), null, null, "Sven_Robel@yahoo.com", new Guid("914e0b17-40ab-478d-ba2c-61856d240679") },
                    { new Guid("86d5acfd-7ee6-4069-948d-b4aa9ec3ab23"), null, null, "Fritz.Kohler1@gmail.com", new Guid("56234ad9-accf-413f-8d2b-5d6fb1cd04a1") },
                    { new Guid("8751ef97-4eb7-429a-bd60-3f60cb545325"), null, null, "Emmitt.Predovic74@yahoo.com", new Guid("e5406e78-ce40-43ee-8dee-e58fe7687eb3") },
                    { new Guid("878e64f7-7432-4693-bb3a-8ae9b9c7c8c9"), null, null, "Eliza75@gmail.com", new Guid("871feb78-0a5f-4d88-8754-a386270f590d") },
                    { new Guid("87f4cd32-0922-4222-8b9d-bb4f8b3ba9b6"), null, null, "Kade62@yahoo.com", new Guid("dd550cd7-4eae-4d75-8be5-5f3e496fdd24") },
                    { new Guid("882ef2f3-a4ae-443f-989d-174c22f727ba"), null, null, "Mollie.Runte@yahoo.com", new Guid("39d27a82-05d2-4135-b53b-53748eefd4f2") },
                    { new Guid("885313c8-ccc3-4bb4-9cfa-c6d5e0f95829"), null, null, "Vergie.Bins46@hotmail.com", new Guid("affd1717-742a-4014-8e72-3420c7496c1e") },
                    { new Guid("88f32915-2a7d-45e2-88b3-bb1805ea7132"), null, null, "Esteban.Grant@gmail.com", new Guid("8ea935b6-2c30-4bef-803c-9f382789979b") },
                    { new Guid("8915eece-c01e-44c9-8848-36a3233fc57c"), null, null, "Alisha8@gmail.com", new Guid("0e6930e6-cf0a-4195-8d74-a9cc0dfb30b6") },
                    { new Guid("89257fe7-f546-45ae-806c-f1ca00166880"), null, null, "Hailie_Leffler@gmail.com", new Guid("3712e35b-2da9-4c76-ad88-28828e776a5c") },
                    { new Guid("89c560c6-0410-40a4-9b50-c2d7130e3a70"), null, null, "Lisette10@yahoo.com", new Guid("3ee0e809-4d8b-4164-a824-c5ab67903af7") },
                    { new Guid("89c9a3b7-22d0-4261-8b52-5d981d8aa06d"), null, null, "Odessa_Carroll@hotmail.com", new Guid("323967f9-cf4e-4818-a5bf-94dff7ea728b") },
                    { new Guid("89e39a9b-8f97-4328-98f1-0e57cb4cfa63"), null, null, "Camryn97@hotmail.com", new Guid("0d88a4e0-8366-4547-8ebe-087d4c74b34f") },
                    { new Guid("89e9a754-d762-40a1-9b69-42f8cc22c69f"), null, null, "Myrna_Hagenes57@hotmail.com", new Guid("4f42e5ab-642c-4775-b2b2-a116ecfcd663") },
                    { new Guid("89f560d0-8cb7-4d77-b8a9-d7a097340904"), null, null, "Janis_Bogisich0@yahoo.com", new Guid("b1817475-7a6c-44d8-8e81-4b59b1f4923e") },
                    { new Guid("8a2d4a2c-5a78-42dc-a41a-aaad08708211"), null, null, "Josiah82@gmail.com", new Guid("57b666b4-3a1b-4303-851f-a88f5f534543") },
                    { new Guid("8a6edd27-0237-4b13-9869-d829b51eaf54"), null, null, "Francisco.Schroeder67@gmail.com", new Guid("72a42c8b-ed7c-4e7a-81c6-313cac897b20") },
                    { new Guid("8a6fab9d-440d-42a8-8c18-826d067f70ee"), null, null, "Rosemarie90@gmail.com", new Guid("5e1f9cf6-8e77-46be-92e7-b3f10da0ed86") },
                    { new Guid("8afdff7d-6ffc-40a7-80c3-c6a5df3ccd21"), null, null, "Baron.Olson@yahoo.com", new Guid("c0ff772c-b38f-4860-9c1e-4c49d424f9a5") },
                    { new Guid("8b1de898-299f-47a9-996f-be59e115de18"), null, null, "Sage.Stracke@yahoo.com", new Guid("50b1b40f-32d2-45da-a690-b9d24fff476e") },
                    { new Guid("8b9168df-e5c2-42d8-9490-fb53006fb7aa"), null, null, "Denis16@hotmail.com", new Guid("539c62ee-15fc-4d37-ab5d-0e4126109954") },
                    { new Guid("8bac5b51-0d7b-4637-8980-43baa29bf70d"), null, null, "Millie16@hotmail.com", new Guid("6c3e0836-290a-4c10-8832-91720a2e9054") },
                    { new Guid("8bbef008-b6a0-48e4-80d4-e277dc06fb2d"), null, null, "Destiney52@yahoo.com", new Guid("56c8b4b0-c1db-425e-a349-2f7b3feabb5e") },
                    { new Guid("8bf7e330-e0c4-4235-8f8a-0904c9d655a6"), null, null, "Bryana_Keebler@yahoo.com", new Guid("c58f524e-a96e-4e8b-9186-6c21d38d64b3") },
                    { new Guid("8c1b8e23-a5f1-4efe-baed-4bd750980132"), null, null, "Ronaldo66@hotmail.com", new Guid("32feb777-af06-4813-9108-9d7acfd0bd04") },
                    { new Guid("8cb3e138-dc97-4a87-b290-02bf24ad6b6a"), null, null, "Esmeralda.Prosacco56@yahoo.com", new Guid("335c9d28-42e2-4d49-9686-f0cd1b972fae") },
                    { new Guid("8cc2644b-02a6-4d47-a208-a2bce8159ca3"), null, null, "Grayce_Smith82@gmail.com", new Guid("4b2a14c5-b9ad-4e45-ae16-0762e7d1e215") },
                    { new Guid("8cf204ca-fd8f-48bf-9554-1c8be6f44dd2"), null, null, "Jarvis1@gmail.com", new Guid("0776f148-3954-48ff-8bb8-772d353c1a3c") },
                    { new Guid("8da45490-3122-4d74-b157-3fc53aefc9e9"), null, null, "Kelly.Friesen37@gmail.com", new Guid("757f3f70-fdce-4727-8fcf-9ac8aa0287b3") },
                    { new Guid("8db95bcb-5ffa-4742-96d3-5904ec2b31f9"), null, null, "Aidan.Daniel2@hotmail.com", new Guid("92a5d027-0cfb-43ec-84b3-d812837c5654") },
                    { new Guid("8e89b908-d472-48b3-8303-0f216c03999d"), null, null, "Gisselle_Conroy30@gmail.com", new Guid("7e4a74cd-b47b-47e6-ab98-22ed32bd8e27") },
                    { new Guid("8eea87e2-feb2-4344-8df3-08b581407dc3"), null, null, "Cali94@yahoo.com", new Guid("57b666b4-3a1b-4303-851f-a88f5f534543") },
                    { new Guid("8f2381e2-40c3-4d44-96ea-b4b6fbb87eb5"), null, null, "Alvena19@hotmail.com", new Guid("94c09a0c-18a4-40c8-9285-032386267d16") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("8f7d72b7-2769-4d9a-997f-9f4aebf7dd26"), null, null, "Holly22@gmail.com", new Guid("141e6ca1-3b19-4ffc-a21f-8420c3f6db52") },
                    { new Guid("8fa57888-1aa1-45ee-a2f7-f8fb42a96af8"), null, null, "Ava78@gmail.com", new Guid("64174d68-43d3-488f-89bf-23d32b134019") },
                    { new Guid("8fc40370-f4dd-45b2-a9eb-1cf04a4d2ab9"), null, null, "Patrick.Hauck@yahoo.com", new Guid("80c8c606-5918-4559-bdbb-606d564f96d5") },
                    { new Guid("8fdf4c3c-5b95-4c78-860b-57f6a5e8486b"), null, null, "Elinore_Walter40@gmail.com", new Guid("7de3e658-53a0-464d-a4aa-b7bf40828f5d") },
                    { new Guid("90a46843-d914-4d8a-93c8-4ee53da3b603"), null, null, "Trystan_Bailey@gmail.com", new Guid("323967f9-cf4e-4818-a5bf-94dff7ea728b") },
                    { new Guid("90e48796-63c9-41db-915f-9033a7b8e975"), null, null, "Teagan_Denesik@hotmail.com", new Guid("6f196aeb-f350-478e-a23f-992b0ea6da29") },
                    { new Guid("90eb9b18-a93b-45d9-a192-35d96ec16625"), null, null, "Raphaelle33@yahoo.com", new Guid("50ac14d1-c13d-42f2-8026-301c38b1964b") },
                    { new Guid("91d16b0b-09fa-4799-af7f-2acdb72585ac"), null, null, "Vivien.Metz18@hotmail.com", new Guid("2bdbd536-e4dc-4869-9dac-f62a098ecb05") },
                    { new Guid("91ed1952-1096-492c-8f4e-c93e1578b3ff"), null, null, "Adele.Ortiz56@hotmail.com", new Guid("718a03a0-2841-450f-a417-5345b18c81ab") },
                    { new Guid("926f1a58-76c8-4d24-a7f8-03908b13617f"), null, null, "Name_Kirlin@yahoo.com", new Guid("77bc83c5-7598-48f0-b4c1-23f76fd277ca") },
                    { new Guid("9315fce4-69c9-452c-b6e6-059f659ef597"), null, null, "Darrin_Rosenbaum@yahoo.com", new Guid("0d230077-5e9b-42d8-a83a-650a22378849") },
                    { new Guid("932b3be2-4733-4879-8efe-40113c1f39ad"), null, null, "Tod.Bashirian68@yahoo.com", new Guid("e41a0e5f-468e-496b-8fe7-b8f4b2a0f962") },
                    { new Guid("935b28cc-7293-43eb-b974-f1fa7e82e4f9"), null, null, "Zelda.Conn86@yahoo.com", new Guid("4188ab2e-f46b-4cf6-b460-560a914e5d35") },
                    { new Guid("9494c4e5-eb5e-4994-a579-74bd30d7e401"), null, null, "Aubree40@yahoo.com", new Guid("3a262ff7-1654-4c72-9285-3ba10eac6509") },
                    { new Guid("94a697b8-d4e0-40ca-a2b0-23e9f06003c8"), null, null, "Mackenzie_Schumm80@yahoo.com", new Guid("0b65bf95-8c8c-4e28-8317-122f0f66a78e") },
                    { new Guid("94d9781c-a44f-495b-99c5-45eecf6c2987"), null, null, "Carmelo.Skiles8@yahoo.com", new Guid("a6a8eca4-cb2e-43f7-9ea2-cbc644c8f9d8") },
                    { new Guid("94e18ca2-e706-4095-8cb6-e585faaeba65"), null, null, "Pierce.Nicolas@gmail.com", new Guid("c7c0cd55-07d8-41cc-9d2b-4bd04cb7edb3") },
                    { new Guid("95275811-cd55-41b1-8c03-152b25c710f3"), null, null, "Jennings.Morar@gmail.com", new Guid("1937fdf7-97b0-4102-95c9-2163eb910112") },
                    { new Guid("95907f66-4a92-4c1f-a243-0f40bcff8b0e"), null, null, "Franz.West75@yahoo.com", new Guid("8ce72c63-9c31-4159-9ba2-012a4fc3df72") },
                    { new Guid("9594fc6a-eaf6-4091-9ffe-d8024dc7a4fd"), null, null, "Keyon53@yahoo.com", new Guid("182bd5c0-616f-4e9b-8837-7c2b67e01496") },
                    { new Guid("95e2613d-01de-4974-b338-1eef5f1812a1"), null, null, "Anibal.Hartmann@gmail.com", new Guid("8867eb2c-20d1-43a8-8081-18744798ef5a") },
                    { new Guid("962445ab-4618-4caa-909c-8e43762d2b76"), null, null, "Kimberly44@hotmail.com", new Guid("2411a1da-d71e-4e02-a40e-984ec689c7bd") },
                    { new Guid("963fe5dd-6daa-473c-8081-3c2a2f98df24"), null, null, "Eduardo64@hotmail.com", new Guid("ea848f07-5360-4e76-ac1d-cf046366d4ef") },
                    { new Guid("9649714b-583d-4ebc-8858-7adfa84aff6a"), null, null, "Clementina_Mohr@gmail.com", new Guid("a9090dd7-3795-48e2-837b-9a72a0274d7b") },
                    { new Guid("96aee77f-382e-4c47-b196-c41844612a85"), null, null, "Cleora.Rutherford21@gmail.com", new Guid("394e6c37-a398-4cf7-983d-8fb216e6c46f") },
                    { new Guid("9745d0ce-cd8a-4771-a993-8d50206427bb"), null, null, "Syble.Huel33@gmail.com", new Guid("cf3285c8-97d7-426d-87f3-e0854194e226") },
                    { new Guid("97627236-32d6-4aa8-ac5b-6574e3b67706"), null, null, "Nya81@hotmail.com", new Guid("e41a0e5f-468e-496b-8fe7-b8f4b2a0f962") },
                    { new Guid("976b1ba2-7f1a-4b16-a9f0-17a9f6d87b52"), null, null, "Sheldon_Leannon@hotmail.com", new Guid("4fdddaf5-83dc-4f45-ad82-fcab10f87405") },
                    { new Guid("9797b195-e771-49f6-b245-6609148d675c"), null, null, "Elsa16@hotmail.com", new Guid("0e7742f2-e964-4e8c-b692-4ffb75ece318") },
                    { new Guid("97d6d9a8-20c8-4a57-bf45-889a45629fc4"), null, null, "Lucy.Herman@gmail.com", new Guid("0bf479c3-ab54-4392-b19e-a71b3942b7fe") },
                    { new Guid("97e3fb63-d857-41b3-99db-a27e4e91d860"), null, null, "Enrique.Shanahan@yahoo.com", new Guid("3b3e9016-3025-48e3-93b2-fa474015c0f7") },
                    { new Guid("9818f0a4-a9f8-415c-9a8a-893a5ea7b15c"), null, null, "Griffin.Koch35@hotmail.com", new Guid("82b99640-3f2e-425b-a088-51b3c226a192") },
                    { new Guid("98200a18-c249-4f0e-b3ac-c8f6f6f4e66a"), null, null, "Tommie.Kilback30@yahoo.com", new Guid("b5cca55a-d81f-47be-b0b4-50d07e79ce69") },
                    { new Guid("98327c9b-d871-483c-9f0f-c9945c8ec03d"), null, null, "Drew_Hane67@yahoo.com", new Guid("405a5eb1-aee0-4578-8748-2d8b5a6b0d57") },
                    { new Guid("9854c4c3-e29a-414e-8496-39ac7c9f6869"), null, null, "Elna2@gmail.com", new Guid("48f4af12-c8b0-4444-98ca-81df5d349e01") },
                    { new Guid("9861d085-8857-4560-9bd5-f4dbe35b9026"), null, null, "Lonie_Abshire@yahoo.com", new Guid("36ffb969-580b-40d2-8fa0-94749ea99214") },
                    { new Guid("98996e6d-3111-423c-8fff-1893790371a4"), null, null, "Camron.Jaskolski10@hotmail.com", new Guid("0d6ec0b6-076d-4fc4-8519-424b1c8bf28e") },
                    { new Guid("98aea9bd-d47c-42ac-896f-1441743f79b3"), null, null, "Jaden2@yahoo.com", new Guid("8fc5f8c0-3711-4486-8ea0-48697b9ea01f") },
                    { new Guid("98bd2106-5c8e-4a70-9114-1682156318bc"), null, null, "Gwen.Bartoletti74@gmail.com", new Guid("5d203345-c58f-4236-9e46-c9ba7a8529a5") },
                    { new Guid("999fe0a1-1df1-4e06-b4e2-de1a9f86b1dd"), null, null, "Douglas_Borer@yahoo.com", new Guid("0877dbd6-c025-49ef-b189-53b217500382") },
                    { new Guid("99b9301c-bd4e-401e-a254-eff0ab630da4"), null, null, "Judge_Nikolaus54@gmail.com", new Guid("8f35c799-d964-48e4-9cf8-befb4f9b7bf0") },
                    { new Guid("99c64028-9969-44a9-a5b8-704cef9e0e0f"), null, null, "Lauriane29@gmail.com", new Guid("c590f92c-3ca1-4a33-a976-926995a0f7cc") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("9a6013d7-1b4e-4b5a-aefa-9e85fcca7f8b"), null, null, "Claudia62@gmail.com", new Guid("7abaa815-d503-4740-a0a9-20d8752fc2cf") },
                    { new Guid("9ad81742-9610-4d57-a329-84676370c7a2"), null, null, "Jalon57@gmail.com", new Guid("4f42e5ab-642c-4775-b2b2-a116ecfcd663") },
                    { new Guid("9b42a0c8-06f7-4b7d-8cb1-fe0829bc5906"), null, null, "Etha_Cormier1@yahoo.com", new Guid("bbaf9fe2-9863-4589-964a-23c62e6bf830") },
                    { new Guid("9b4a6d67-ca53-40df-bff2-4bc7d0c83c5b"), null, null, "Catharine.Nienow@yahoo.com", new Guid("d43ee797-d0bc-4a3e-8833-c45e9d340f44") },
                    { new Guid("9b930ec1-5a4c-411c-aa20-94851f0ff18d"), null, null, "Sebastian_Mosciski89@gmail.com", new Guid("5aff4312-b9a9-4958-b14a-305be3aa9f4b") },
                    { new Guid("9bc2c3ea-2934-4a1b-9c63-52f6c7ebd3e1"), null, null, "Aryanna.Homenick11@hotmail.com", new Guid("6218849a-9af3-4ab0-93d1-f5fd29135491") },
                    { new Guid("9be73ae6-e863-4aa2-9fc7-809d0c655172"), null, null, "Mallie.Abernathy@gmail.com", new Guid("405a5eb1-aee0-4578-8748-2d8b5a6b0d57") },
                    { new Guid("9bfa0543-9a74-4626-9da6-afeb4eb9d99d"), null, null, "Cathrine_Lueilwitz12@gmail.com", new Guid("0447d1d8-3e48-4d64-8d2e-7d9a733628ec") },
                    { new Guid("9d8fcecf-db54-4b23-9c41-e71564b5576b"), null, null, "Madilyn84@hotmail.com", new Guid("d57e07f1-63a6-4514-ae7a-51f83c901e2c") },
                    { new Guid("9e00f154-0a6b-420d-9f8f-0607a4040390"), null, null, "Brandyn.Reichel92@hotmail.com", new Guid("0e7742f2-e964-4e8c-b692-4ffb75ece318") },
                    { new Guid("9e1ed1c9-e40e-478a-99c7-debc12bb1f0c"), null, null, "Wendy_Labadie@yahoo.com", new Guid("2c87eaa4-8e07-41f4-bad0-935d07541e78") },
                    { new Guid("9e71688e-7e01-4987-9049-51cd4827e28b"), null, null, "Jarrett45@gmail.com", new Guid("7da75a84-c857-4768-9ff2-252052ea5333") },
                    { new Guid("9e918985-b920-453a-a322-cc887aef9a07"), null, null, "Darron.Johnson59@gmail.com", new Guid("3a19b458-72b3-4b5b-97e6-334a56d7d557") },
                    { new Guid("9f1e5201-9463-40f5-8f66-ff9199082b0d"), null, null, "Tristian_Brekke@yahoo.com", new Guid("108fbff3-4041-4eed-b2a0-4a4b1fb47787") },
                    { new Guid("9f87156e-948b-4da3-9d25-e0b9a8a72545"), null, null, "Freddy.White80@yahoo.com", new Guid("0d88a4e0-8366-4547-8ebe-087d4c74b34f") },
                    { new Guid("9fc90676-3a82-467a-a6b0-ee0412c5c73e"), null, null, "Vella_Lowe47@gmail.com", new Guid("8dca8632-b27c-44ad-bd6c-0d7679a4f075") },
                    { new Guid("a00f0904-8b0c-458a-8c62-3c1fcb7d2150"), null, null, "Aurelie79@gmail.com", new Guid("4b2a14c5-b9ad-4e45-ae16-0762e7d1e215") },
                    { new Guid("a047ad28-ce26-461d-bd37-f58c2663d933"), null, null, "Joel25@hotmail.com", new Guid("5e1f9cf6-8e77-46be-92e7-b3f10da0ed86") },
                    { new Guid("a0c0918e-4c54-415e-97e3-5d2d231725e4"), null, null, "Amie49@hotmail.com", new Guid("4ecad1f7-2b37-4dd8-be42-dedd60205e81") },
                    { new Guid("a124346e-9e18-42fe-9091-cf693dc31729"), null, null, "Leanne_Connelly@gmail.com", new Guid("4c5d0085-4956-4748-b989-09b4d927d669") },
                    { new Guid("a1355942-c646-4bd8-bde3-d7a29016ee2a"), null, null, "Rocky76@gmail.com", new Guid("0d6ec0b6-076d-4fc4-8519-424b1c8bf28e") },
                    { new Guid("a1778a73-c3df-4b40-b62f-2d3fbd60e9a5"), null, null, "Kiarra_Murray75@yahoo.com", new Guid("1e17494c-b19d-4879-af0e-c6575db6bd37") },
                    { new Guid("a1a5026a-8bcf-4cc6-a0aa-375818f36026"), null, null, "Mellie_Paucek@hotmail.com", new Guid("57b666b4-3a1b-4303-851f-a88f5f534543") },
                    { new Guid("a1c6fa86-4105-4e7d-9a27-adebd508f6b3"), null, null, "Edison_Haley82@yahoo.com", new Guid("7cf58058-5eec-4c6e-a4ae-cf50ccf0b2ac") },
                    { new Guid("a266d69d-5ea1-4291-b0fd-c41677c05443"), null, null, "Devonte.Block@yahoo.com", new Guid("4a9e17b4-cb0f-4c82-80d2-e1d56fe06f0a") },
                    { new Guid("a32e6362-17b8-492d-8504-10a3c9d17381"), null, null, "Kelsi91@gmail.com", new Guid("8ea935b6-2c30-4bef-803c-9f382789979b") },
                    { new Guid("a366f58c-da02-4521-acbb-aa39bc31c281"), null, null, "Aletha_Kling91@gmail.com", new Guid("48b3cd65-be2f-4be1-a3c5-d88da44b3d73") },
                    { new Guid("a3cc3676-f332-446a-8107-32fb1535b42c"), null, null, "Raleigh.Rolfson46@yahoo.com", new Guid("8867eb2c-20d1-43a8-8081-18744798ef5a") },
                    { new Guid("a49ff34f-810b-421e-9c6f-156ae2cdbb21"), null, null, "Kobe22@hotmail.com", new Guid("fe7a3052-1ad9-4450-b9d5-057c6abe9c2e") },
                    { new Guid("a4b3954e-8802-494f-8269-308f779b1d5c"), null, null, "Wade46@hotmail.com", new Guid("67a258f9-5c48-4651-8f32-1ee7f5b4246d") },
                    { new Guid("a4c31c52-4b44-4617-ad2d-e311ae8a1b6a"), null, null, "Holly_Rodriguez@gmail.com", new Guid("4c5d0085-4956-4748-b989-09b4d927d669") },
                    { new Guid("a511b4cb-3399-4cc4-bb3c-dea8bb1822a7"), null, null, "Jovan_Lemke@hotmail.com", new Guid("0a1370d0-5d3b-4609-9efc-9507f4acc2f8") },
                    { new Guid("a52a8856-f200-4691-a8ed-63d80cb73b11"), null, null, "Dayton19@gmail.com", new Guid("1154bb55-7f7f-4d91-8347-5797ffeacb13") },
                    { new Guid("a5a20f71-1ea7-4897-9eaf-bef7d516312b"), null, null, "Chase.Fay@gmail.com", new Guid("99d3bf2d-5ff0-41e8-b115-9bf94eab6881") },
                    { new Guid("a5b5946f-a8c7-4626-bb3b-202759bae931"), null, null, "Bryana.Jakubowski55@yahoo.com", new Guid("9e96d314-cd64-47aa-a5bc-7e0525cc9914") },
                    { new Guid("a5b9cd58-921e-45cc-b1e0-c1938020ffc1"), null, null, "Dereck_Lynch53@yahoo.com", new Guid("2bdbd536-e4dc-4869-9dac-f62a098ecb05") },
                    { new Guid("a73f1696-dd8a-4949-b287-dbebfeb9f266"), null, null, "Marlin_Osinski@gmail.com", new Guid("64174d68-43d3-488f-89bf-23d32b134019") },
                    { new Guid("a760468c-3ead-478d-a342-11f968b3a16f"), null, null, "Gregg42@yahoo.com", new Guid("2411a1da-d71e-4e02-a40e-984ec689c7bd") },
                    { new Guid("a7747141-3abc-4212-bf9d-e5bcaafb279a"), null, null, "Aliya82@hotmail.com", new Guid("718a03a0-2841-450f-a417-5345b18c81ab") },
                    { new Guid("a782a2d9-7cf1-4ab7-b7a9-a1990be31dca"), null, null, "Ned_Stoltenberg9@gmail.com", new Guid("653800c1-b55d-4636-99c0-ea31223d7e3b") },
                    { new Guid("a86ee97e-fd04-49f1-b871-b84f62a0538a"), null, null, "Kobe.Bartell@gmail.com", new Guid("cf611bf3-21fb-4ed7-a138-00c7afdda9ba") },
                    { new Guid("a8a9c6f3-1f45-4695-ba2d-b90b14bb03de"), null, null, "Cary8@gmail.com", new Guid("8ce72c63-9c31-4159-9ba2-012a4fc3df72") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("a8b95f6f-d82b-46c0-a9d1-491cd61c5b48"), null, null, "Jonas.Beier@gmail.com", new Guid("4d006d0d-8a50-4d81-886b-176313d018fb") },
                    { new Guid("a9319703-a6fa-4fe8-b0e6-43833bc6cfc5"), null, null, "Sam.Weimann@gmail.com", new Guid("914e0b17-40ab-478d-ba2c-61856d240679") },
                    { new Guid("a942a68f-1c38-42fe-9907-16217a57dc5e"), null, null, "Wilmer.Kreiger62@hotmail.com", new Guid("db32027d-cf9c-4544-af7d-d20c917925c7") },
                    { new Guid("a97399ae-fab2-445a-a00a-a4e28a1ea9dd"), null, null, "Triston_Waters@gmail.com", new Guid("5aff4312-b9a9-4958-b14a-305be3aa9f4b") },
                    { new Guid("abf4d5a9-39f5-46ca-8132-344099ada9b8"), null, null, "Adele58@yahoo.com", new Guid("d0aae9a2-8c5b-48e9-b856-e309c80cadae") },
                    { new Guid("ac496291-f3b6-4535-b57d-5c6d37c02360"), null, null, "Maddison.Smitham45@hotmail.com", new Guid("92d6cbc1-d409-403c-b274-517d31726ae9") },
                    { new Guid("ac70d408-1abc-4bc7-8971-cff59f23abbc"), null, null, "Antonette.Russel@yahoo.com", new Guid("d40492c4-d582-4ce6-943c-a487675b7960") },
                    { new Guid("acb3e501-bfac-4918-912e-ea9c4d8c0025"), null, null, "Lydia.Hansen@yahoo.com", new Guid("40a279f6-73dd-4fa2-8b1e-05f9cd8bdcf9") },
                    { new Guid("adbf8350-3dc8-498d-8f02-c2cbadb058c8"), null, null, "Sheldon99@hotmail.com", new Guid("66da7f26-36d5-4406-a2e4-35363c8e43cb") },
                    { new Guid("adda1f28-d489-49c9-b13d-35476e87f5d0"), null, null, "Leanne_Koelpin@gmail.com", new Guid("df3cc97e-5297-4426-8d73-6ec8a1d6ff19") },
                    { new Guid("adf1f5dc-1be0-4a5f-9943-ca977cd6f05b"), null, null, "Megane.Romaguera9@hotmail.com", new Guid("be0a8a82-f1fd-45d5-8523-5b32db6fc767") },
                    { new Guid("ae1b5c48-884d-4ce7-aa12-cd46e3b4cc9f"), null, null, "Ezra_Volkman@hotmail.com", new Guid("a780acfd-e10d-4dc5-a383-1ba56a91e666") },
                    { new Guid("ae9eb572-9c7f-44c3-bdfe-a456463c9769"), null, null, "Zula_Bechtelar@gmail.com", new Guid("aec475ab-9ab8-4f55-8794-ee1ffc6f6da6") },
                    { new Guid("aee133da-c853-40b8-895c-874c4c969715"), null, null, "Gavin72@hotmail.com", new Guid("c3cc5785-6364-48fa-bb83-e7ac33fc672b") },
                    { new Guid("af37704a-989c-4d5a-ad38-b21c98e109c6"), null, null, "Dameon_Bashirian@hotmail.com", new Guid("7e4a74cd-b47b-47e6-ab98-22ed32bd8e27") },
                    { new Guid("afacf1e8-cb56-4d41-a090-a2cd2ad2b3c8"), null, null, "Annabelle79@gmail.com", new Guid("482632b6-5f62-4fe4-82e0-1b6f0d3ee842") },
                    { new Guid("afb57ef6-f30a-4de7-b724-b8024cfa540b"), null, null, "Luciano93@yahoo.com", new Guid("8fc5f8c0-3711-4486-8ea0-48697b9ea01f") },
                    { new Guid("b0067eef-ea72-4e9c-8f21-14379755bfc4"), null, null, "Emory.Stracke36@yahoo.com", new Guid("0e6930e6-cf0a-4195-8d74-a9cc0dfb30b6") },
                    { new Guid("b0238b4f-1126-4129-811b-e247d76cfc4f"), null, null, "Elmira.Gaylord@hotmail.com", new Guid("cf348fa5-7d32-48ec-957c-eb481beb0358") },
                    { new Guid("b055f6b2-7366-4a7f-90e4-08dd3c5d6f35"), null, null, "Stella73@gmail.com", new Guid("42babbec-5dbe-4cc3-9f68-bb4bc7ad9491") },
                    { new Guid("b06ad90c-d4ef-4903-b99a-2d9ac12027dc"), null, null, "Anais71@yahoo.com", new Guid("48f4af12-c8b0-4444-98ca-81df5d349e01") },
                    { new Guid("b07d6749-4a53-401e-b7dc-c1c2c0ef3801"), null, null, "Mohammed9@hotmail.com", new Guid("4d006d0d-8a50-4d81-886b-176313d018fb") },
                    { new Guid("b0a11246-b1f4-4e84-9a36-4712389db170"), null, null, "Triston_Altenwerth67@hotmail.com", new Guid("5f366c1b-9e38-4bc9-b773-fca63347cbcc") },
                    { new Guid("b0a9e203-bae7-4f38-891e-8d94966d82d5"), null, null, "Blaise.Lesch55@hotmail.com", new Guid("48b3cd65-be2f-4be1-a3c5-d88da44b3d73") },
                    { new Guid("b110e776-edac-4aa0-b308-fa4ac6c9e6e1"), null, null, "Deontae31@gmail.com", new Guid("7da75a84-c857-4768-9ff2-252052ea5333") },
                    { new Guid("b14d7a36-a533-4fc3-8d0c-fed250b29b28"), null, null, "Granville_Hand@yahoo.com", new Guid("a780acfd-e10d-4dc5-a383-1ba56a91e666") },
                    { new Guid("b16bb27e-d6bd-4423-aeec-e95d2c39d79a"), null, null, "Tessie.Murphy@hotmail.com", new Guid("3712e35b-2da9-4c76-ad88-28828e776a5c") },
                    { new Guid("b19354eb-0977-4259-a6d3-20f517fd729e"), null, null, "Jazlyn25@yahoo.com", new Guid("0635daf3-649c-437b-92ef-713d43246a0a") },
                    { new Guid("b19dd727-8eae-4a15-9cad-083e73cec650"), null, null, "Lucile_Green@yahoo.com", new Guid("fcf05f51-7f3a-4331-a0f5-6204db62e7ba") },
                    { new Guid("b2abf6d7-b8e3-4b89-9c20-d1b6b1912c54"), null, null, "Lauretta.Sanford49@yahoo.com", new Guid("496d8ed2-fc6d-49e6-b902-8a1d0b266928") },
                    { new Guid("b2c41ba8-cdab-4a5e-9c10-89bd711a83d3"), null, null, "Leila_Runolfsdottir@yahoo.com", new Guid("08589d86-24cf-48ee-b140-eab54649e215") },
                    { new Guid("b2dbddc3-b5df-4743-8da8-0cccddd8d30e"), null, null, "Reymundo.Morissette91@hotmail.com", new Guid("35275876-97ec-44a4-8503-f21c815c9a45") },
                    { new Guid("b348f5eb-af46-441f-9183-7fe335ed1669"), null, null, "Jeffry.Herman@yahoo.com", new Guid("06f4c32b-9a3d-4b38-99a4-56ea0ba685a8") },
                    { new Guid("b4647683-231f-4bd1-a9bc-174ffd071fab"), null, null, "Deondre.Tromp@hotmail.com", new Guid("4f42e5ab-642c-4775-b2b2-a116ecfcd663") },
                    { new Guid("b50baaaf-331b-4afd-82cb-3ffcd29f973c"), null, null, "Kaylin.Macejkovic44@hotmail.com", new Guid("a419df27-9358-4a02-9ab7-2f2e2344fae0") },
                    { new Guid("b56412b8-b725-4411-a3a5-4cca2fe77997"), null, null, "Kendrick.Hoppe90@gmail.com", new Guid("658f3ddd-678c-4dca-b9fa-45901c0f1c05") },
                    { new Guid("b5d66606-6a3e-4dba-a1af-661460356b77"), null, null, "Gregorio.Hills@yahoo.com", new Guid("6218849a-9af3-4ab0-93d1-f5fd29135491") },
                    { new Guid("b5f26eeb-abc1-4366-93be-b3cff4645f0f"), null, null, "Mya17@gmail.com", new Guid("8a696f30-76c2-40db-a250-030829547d67") },
                    { new Guid("b66939c3-d106-44b0-91a9-516290e8742f"), null, null, "Domenic.Koss@gmail.com", new Guid("23e8131d-ba45-4488-991d-941eca3fbe0a") },
                    { new Guid("b6739ef4-f03e-440c-92b3-ea0ce49d8e6e"), null, null, "Leon.Bergstrom88@gmail.com", new Guid("9ff0a0ca-02d0-4209-bb8f-a0d7efaf75bb") },
                    { new Guid("b6790c51-a109-429a-8e93-b2bff3c0567f"), null, null, "Mercedes17@yahoo.com", new Guid("1154bb55-7f7f-4d91-8347-5797ffeacb13") },
                    { new Guid("b67fa921-eda5-4a96-a3e6-42fb88307343"), null, null, "Destini75@hotmail.com", new Guid("be0a8a82-f1fd-45d5-8523-5b32db6fc767") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("b6aa2f76-38cc-4b55-aa6f-0a2c602f72b1"), null, null, "Arch_Breitenberg@yahoo.com", new Guid("0773e360-956e-4d39-94c5-d0906a9e4557") },
                    { new Guid("b6b9c71d-956c-4f8b-a425-6fa68120c042"), null, null, "Melisa.Strosin@yahoo.com", new Guid("980189d0-dcc8-4676-93bf-39ec81288e2f") },
                    { new Guid("b72ff0cc-5cfc-4447-bc17-1bf0c0871068"), null, null, "Marge51@hotmail.com", new Guid("0e6930e6-cf0a-4195-8d74-a9cc0dfb30b6") },
                    { new Guid("b7622cc0-cdfc-4bc2-b306-d229033a31c0"), null, null, "Vladimir91@yahoo.com", new Guid("719d1670-ba7d-4e9b-b4de-d7074f81aa66") },
                    { new Guid("b7881e61-d127-4326-9677-4eea47115358"), null, null, "Maximilian_Collier88@yahoo.com", new Guid("07e77ffa-7983-4cb3-bfa5-a4b8ed39f91f") },
                    { new Guid("b78f807d-13d9-4f61-bae4-f14e0ccb7271"), null, null, "Maria.Block@gmail.com", new Guid("2b5f8a6c-d3e8-41ff-8867-cadb6cd16ea4") },
                    { new Guid("b797e84e-d172-4e2e-8f01-1cd96e0e4f29"), null, null, "Justen_Wuckert38@hotmail.com", new Guid("7da75a84-c857-4768-9ff2-252052ea5333") },
                    { new Guid("b7a5b8f6-f71f-4187-9f15-762d88a03d8e"), null, null, "Madisyn.Harris@hotmail.com", new Guid("530579fa-33a7-4827-a21f-b9cacab42c7d") },
                    { new Guid("b7a9fa6e-75a5-4134-8e89-1d67556bd37d"), null, null, "Fay_Will26@gmail.com", new Guid("c58f524e-a96e-4e8b-9186-6c21d38d64b3") },
                    { new Guid("b7b83d26-697e-426d-a85d-139b71e35a2d"), null, null, "Elna_Torphy@gmail.com", new Guid("6101631f-7cf2-4393-a938-099c07dbe44b") },
                    { new Guid("b8247ae4-5a98-4b2c-81df-c7293f51a706"), null, null, "Kariane93@hotmail.com", new Guid("b40d8226-58de-4e86-811d-0e6b38686d57") },
                    { new Guid("b8468f78-2623-4dcb-b5c9-838391c18fd7"), null, null, "Keely92@gmail.com", new Guid("405a5eb1-aee0-4578-8748-2d8b5a6b0d57") },
                    { new Guid("b84a3745-b9a0-4742-ba99-d5b93dde8343"), null, null, "Caleb.Crona@yahoo.com", new Guid("353c126e-57f5-471a-b13f-0e4fd4cef2fe") },
                    { new Guid("b84feae3-6fba-4043-9643-792bc2b1afaa"), null, null, "Alysha68@gmail.com", new Guid("99d4724f-46db-42d2-a62b-3d8fa528e130") },
                    { new Guid("b888ca3d-3a97-4abc-90db-c0b6c058b33f"), null, null, "Jorge_Johnson@yahoo.com", new Guid("8fc5f8c0-3711-4486-8ea0-48697b9ea01f") },
                    { new Guid("b919c772-0533-47d5-afcc-8c9afc05a286"), null, null, "Triston_Wuckert96@yahoo.com", new Guid("8be01b71-4060-43ad-98a5-2c0730fd003b") },
                    { new Guid("b93e4486-7536-4eb4-aa93-77ec9cea36ee"), null, null, "Tianna.Ondricka@yahoo.com", new Guid("25c234e8-8d95-42b3-9dc3-c418fbcaa7da") },
                    { new Guid("b96d86d2-98e2-421d-9482-d1f9a2f553a6"), null, null, "Abel.Doyle@hotmail.com", new Guid("080ced29-2e70-40de-82e4-0a2d478fe53e") },
                    { new Guid("b99123f2-bebd-4fc6-a7a1-faa838ed87cf"), null, null, "Felipe_Fay@hotmail.com", new Guid("cf611bf3-21fb-4ed7-a138-00c7afdda9ba") },
                    { new Guid("b9b9d7e9-187c-40c8-9cac-c2353c1a7610"), null, null, "Aaron.Barton3@gmail.com", new Guid("8e3d5153-23be-45f9-83b4-5aecbb1a4322") },
                    { new Guid("baf181e6-284a-4ea7-82eb-6a8cc23c1df4"), null, null, "Catherine_Breitenberg@yahoo.com", new Guid("087fb413-124f-47b1-b54e-4bdedf2edf63") },
                    { new Guid("bbcba1ed-3285-4ff6-8e88-31e8db88acb0"), null, null, "Manley_Nitzsche83@gmail.com", new Guid("c88c725e-8cbf-416d-a4bf-153a024ea6c9") },
                    { new Guid("bbe23866-9707-494d-8004-864b0a207ea3"), null, null, "Faye.Carter85@hotmail.com", new Guid("71f7fb3b-e7f1-4325-bdd2-98f71dd515b1") },
                    { new Guid("bc340233-53b3-4c7c-9215-dcc3c056b535"), null, null, "Kelton.Hodkiewicz51@yahoo.com", new Guid("0447d1d8-3e48-4d64-8d2e-7d9a733628ec") },
                    { new Guid("bc5ed53f-eb20-4347-8c09-9b24c2485239"), null, null, "Chadd14@gmail.com", new Guid("22edc826-6747-4099-aca5-578199353ac6") },
                    { new Guid("bd725a28-e382-4533-a992-58a57900ae19"), null, null, "Verner29@yahoo.com", new Guid("de7e4623-27a6-4a10-8c19-1f8ae8f689d2") },
                    { new Guid("bddfb7b8-9134-45e3-9913-d9df506223b7"), null, null, "Estefania40@hotmail.com", new Guid("a943e809-55d9-482f-a592-8709b5f7d47f") },
                    { new Guid("be31ade1-7d99-4782-aa31-4b0a84ca1aa1"), null, null, "Adele59@yahoo.com", new Guid("3c3a765d-c1b9-47c7-b39a-7b5dc35e1cbc") },
                    { new Guid("be423e79-e79b-4d5a-b2d8-fd66ecb09a7b"), null, null, "Carissa.Bayer@yahoo.com", new Guid("49ef4ccb-eb29-4ffa-bcfe-88759ac3f1c5") },
                    { new Guid("be8e885b-02f4-42c0-8b13-ce9460f0e3d9"), null, null, "Jalen.Yundt@hotmail.com", new Guid("74ef9233-8d34-4883-8938-b78b6c147246") },
                    { new Guid("beb35393-bcec-4a93-b071-0b175bc1557d"), null, null, "Carolyne97@gmail.com", new Guid("ab451099-7866-44e4-9ebd-f1162ea6206a") },
                    { new Guid("bf7274e8-db87-469b-924d-91a29db8487e"), null, null, "Elmer.Mosciski68@yahoo.com", new Guid("9ee8d8bd-022b-4718-b8f4-cc38174e988c") },
                    { new Guid("bf937c82-3f5b-47b9-b0ff-2205282fd077"), null, null, "Laverna.Ondricka76@gmail.com", new Guid("718a03a0-2841-450f-a417-5345b18c81ab") },
                    { new Guid("bf99c75c-3b1b-4782-8457-d26ade77c62c"), null, null, "Sterling.Pacocha48@hotmail.com", new Guid("b53497b3-fabe-4282-a5c6-ef6e82864309") },
                    { new Guid("c017be46-3d88-44a1-aa35-150d80df0cf1"), null, null, "Jaqueline62@gmail.com", new Guid("3ff3d88e-b078-4f3a-8312-8447eeb772e2") },
                    { new Guid("c0286f24-61ba-4101-8610-db0743fe4bcf"), null, null, "Eduardo65@gmail.com", new Guid("e2db5e4a-dcb2-42fc-b56b-17a4692bd0de") },
                    { new Guid("c060626a-2c64-4b71-8e37-3c8e31a6a735"), null, null, "Caroline77@yahoo.com", new Guid("0877dbd6-c025-49ef-b189-53b217500382") },
                    { new Guid("c105a223-8e56-45b2-b79e-538fea2b1529"), null, null, "Vita.Ferry@hotmail.com", new Guid("2bdbd536-e4dc-4869-9dac-f62a098ecb05") },
                    { new Guid("c1092b7e-f630-4893-94cd-6b268c3c51a8"), null, null, "Leonie_Doyle29@gmail.com", new Guid("c0ff772c-b38f-4860-9c1e-4c49d424f9a5") },
                    { new Guid("c136f597-6336-4cfa-9c81-8c32b27f9730"), null, null, "Verner99@hotmail.com", new Guid("087fb413-124f-47b1-b54e-4bdedf2edf63") },
                    { new Guid("c1c7fe28-4266-4c45-9368-e9242616ec16"), null, null, "Gwen.Kassulke@yahoo.com", new Guid("1937fdf7-97b0-4102-95c9-2163eb910112") },
                    { new Guid("c1df7d5d-d4a5-47e3-a4c2-96bbebd67d24"), null, null, "Ardith.Breitenberg@yahoo.com", new Guid("c88c725e-8cbf-416d-a4bf-153a024ea6c9") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("c250bbe7-2ec5-4b83-a5b7-0eddebbc2844"), null, null, "Nadia55@yahoo.com", new Guid("230e73b5-4a4b-4b1c-ad48-f7a0074303c7") },
                    { new Guid("c2cfbee9-cd6a-4fee-84b1-5f05988e0575"), null, null, "Norval67@hotmail.com", new Guid("0e7742f2-e964-4e8c-b692-4ffb75ece318") },
                    { new Guid("c2d83112-f888-4746-8f12-94256af98982"), null, null, "Jarod91@gmail.com", new Guid("39d27a82-05d2-4135-b53b-53748eefd4f2") },
                    { new Guid("c2f11153-febf-4222-9988-b7d10673df98"), null, null, "Hilda_Rolfson42@gmail.com", new Guid("9b254af5-9da3-4b42-a5f3-b573df408d84") },
                    { new Guid("c3121ca9-ab57-4a67-bfae-72ccca1df5d0"), null, null, "Olga.West@hotmail.com", new Guid("0776f148-3954-48ff-8bb8-772d353c1a3c") },
                    { new Guid("c32168df-fa31-4bc4-bd57-06cb98f96367"), null, null, "Mortimer.Bednar@yahoo.com", new Guid("e5fa7b3b-6d8a-43dc-88a3-403aed558476") },
                    { new Guid("c331f867-5ba7-4150-bfa3-eeb54a93966d"), null, null, "Shanny_Jacobson@gmail.com", new Guid("bbe91897-98e6-4c1e-aef5-09cd3dbb35cd") },
                    { new Guid("c38560a8-4414-4e54-bb08-c5d8a1b3ed52"), null, null, "Amari.Block@hotmail.com", new Guid("48f4af12-c8b0-4444-98ca-81df5d349e01") },
                    { new Guid("c3968c7c-b945-4a8e-b855-f147bcb43088"), null, null, "Marietta_Hermann@yahoo.com", new Guid("8f35c799-d964-48e4-9cf8-befb4f9b7bf0") },
                    { new Guid("c3b48f3e-bce9-426b-970c-8967c8ce8d96"), null, null, "Dorian90@yahoo.com", new Guid("9ec54876-333f-4825-9959-c839395cb66e") },
                    { new Guid("c40ea1c4-cf21-4088-8389-3d3909735da0"), null, null, "Annamae.Conn20@gmail.com", new Guid("df3cc97e-5297-4426-8d73-6ec8a1d6ff19") },
                    { new Guid("c5354df5-d0b7-4435-86ef-b0ac2a003bef"), null, null, "Mireille_Wolf@gmail.com", new Guid("70d04e87-92ed-4410-96a6-934a82c8bbcb") },
                    { new Guid("c5acfa2f-f345-4540-b001-7213dca7dba1"), null, null, "Devan24@hotmail.com", new Guid("8fc5f8c0-3711-4486-8ea0-48697b9ea01f") },
                    { new Guid("c5ba0423-7b75-4e7a-afc0-cb6d2f0974f8"), null, null, "Neoma.Keebler30@gmail.com", new Guid("4188ab2e-f46b-4cf6-b460-560a914e5d35") },
                    { new Guid("c655e76d-9336-4593-bc1a-f14407bc138e"), null, null, "Marquis_Rice55@yahoo.com", new Guid("fe7a3052-1ad9-4450-b9d5-057c6abe9c2e") },
                    { new Guid("c6f8942d-a236-48ca-86b6-a979ece1e0fb"), null, null, "Camilla.Bins@gmail.com", new Guid("aec475ab-9ab8-4f55-8794-ee1ffc6f6da6") },
                    { new Guid("c704a5bc-8c80-4a7a-bcc6-a52037186d9e"), null, null, "Tanner.Casper19@gmail.com", new Guid("5d203345-c58f-4236-9e46-c9ba7a8529a5") },
                    { new Guid("c73dbc57-4a4d-4610-9608-36a55e07f616"), null, null, "Kavon_OConnell91@hotmail.com", new Guid("6ab8f9db-6513-4d8f-9cde-7b925ff51057") },
                    { new Guid("c7c0ee9f-af6f-4f60-9119-aacae91b2b8b"), null, null, "Ethelyn9@hotmail.com", new Guid("06f4c32b-9a3d-4b38-99a4-56ea0ba685a8") },
                    { new Guid("c7f9e379-cc12-4285-b14a-ff9e4fe3e1e7"), null, null, "Erick.Kassulke99@yahoo.com", new Guid("a59d873d-ae08-427c-b25e-29c55895239f") },
                    { new Guid("c846ada6-0774-4ab8-a880-e3108cb823c7"), null, null, "Elnora58@hotmail.com", new Guid("9ee8d8bd-022b-4718-b8f4-cc38174e988c") },
                    { new Guid("c9870256-5900-4948-8459-14ab2b4fa6d7"), null, null, "Callie90@yahoo.com", new Guid("819538c4-628a-4b17-a719-8274b53093f3") },
                    { new Guid("c9a56e6d-c772-4f3f-be21-0a637c87bb1f"), null, null, "Alysa29@yahoo.com", new Guid("a2c81266-ca25-4e08-bddc-c6ccfe9435e2") },
                    { new Guid("c9da7569-8e8c-447a-ba52-9bfcbe9b6707"), null, null, "Maryse.Leffler@hotmail.com", new Guid("2411a1da-d71e-4e02-a40e-984ec689c7bd") },
                    { new Guid("ca11d051-e4ac-450f-98fd-15a49108653e"), null, null, "Liam_Erdman@gmail.com", new Guid("4c5d0085-4956-4748-b989-09b4d927d669") },
                    { new Guid("ca30ace5-6a4a-4412-8c53-b840130dcc95"), null, null, "Valentine30@yahoo.com", new Guid("4fdddaf5-83dc-4f45-ad82-fcab10f87405") },
                    { new Guid("ca943cf2-dd64-4311-a87b-1b8ffdd53aff"), null, null, "Etha_Berge@gmail.com", new Guid("59a9232d-40d9-422d-8a1a-fe022e85093a") },
                    { new Guid("cad58841-4954-4906-98bb-f84e4123fe3b"), null, null, "Fernando.Johnston@gmail.com", new Guid("8f876cca-154f-4381-adab-41c9e894d046") },
                    { new Guid("caebd0ea-c7b8-489c-8dd1-4462820999e2"), null, null, "Russel5@hotmail.com", new Guid("8b3afef3-3bbb-4237-b8b8-1eba1df7757e") },
                    { new Guid("cb59c5f2-fd06-4d70-b709-f192054694cd"), null, null, "Rowan.Schinner43@hotmail.com", new Guid("7a52231d-ba53-47d6-8382-e5bf5f9e7e24") },
                    { new Guid("cbb469bd-3498-4b41-b37c-059b5ec90970"), null, null, "Antonietta_Feest@gmail.com", new Guid("7e4a74cd-b47b-47e6-ab98-22ed32bd8e27") },
                    { new Guid("cbcb6978-e1a9-431d-8cc4-edcb5966e319"), null, null, "Lucienne13@yahoo.com", new Guid("c2701daa-7747-422a-bb74-d9ffc8e0f5fc") },
                    { new Guid("cbd388ab-ea04-4d19-8d35-26cd7a1760a9"), null, null, "Hattie42@yahoo.com", new Guid("f3cb510a-8243-4204-8c1f-ace56610d45f") },
                    { new Guid("cc25165f-a976-49b1-a727-b84d8ec9a57e"), null, null, "Cornelius_Harvey46@gmail.com", new Guid("539c62ee-15fc-4d37-ab5d-0e4126109954") },
                    { new Guid("cc2bc326-fcd6-46e8-9bc3-d0c547c09379"), null, null, "Maryjane40@hotmail.com", new Guid("7778b4eb-db56-4ddd-a0bc-5f46aff077f7") },
                    { new Guid("cc5751e5-27ad-437b-bbb6-764322d53018"), null, null, "Lydia30@yahoo.com", new Guid("adbbd240-641f-475b-b705-5e35298ef012") },
                    { new Guid("ccb782fd-e626-44e0-b481-55893549a9d3"), null, null, "Angelica.Daugherty24@hotmail.com", new Guid("4fdddaf5-83dc-4f45-ad82-fcab10f87405") },
                    { new Guid("ccb9f3b7-1943-4efd-952c-14a334f51c1f"), null, null, "Lilliana_Rutherford81@yahoo.com", new Guid("e2db5e4a-dcb2-42fc-b56b-17a4692bd0de") },
                    { new Guid("cd2a3a78-0608-4615-ae7a-54c388e9a5cc"), null, null, "Kurt1@hotmail.com", new Guid("c6e8a5d8-6660-4e85-9ff9-1e6ec6d0c580") },
                    { new Guid("cd4b70da-0844-4932-9d17-4c9b52366b4f"), null, null, "Maria_Reynolds40@gmail.com", new Guid("75ba16eb-aa9c-4c6f-90ae-1515360055a9") },
                    { new Guid("cd660414-885c-4480-83ba-52cc2a7eda59"), null, null, "Kenya25@hotmail.com", new Guid("0ec010bc-7e48-4cb9-bb93-8dd9d5b37f6d") },
                    { new Guid("ce415c8d-c6f2-46e9-81ec-60d8c457a03c"), null, null, "Reynold.Trantow@hotmail.com", new Guid("6ef84803-7ff7-46d1-b1b3-ebda82e158b3") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("cec448dc-0a8c-47ce-a089-a1217616d309"), null, null, "Newell19@hotmail.com", new Guid("7c2f2e0c-1d40-453b-84ea-f5f09cb10d28") },
                    { new Guid("cef4003e-46f4-43e4-b87b-934462b03107"), null, null, "Era_Gerlach97@gmail.com", new Guid("66da7f26-36d5-4406-a2e4-35363c8e43cb") },
                    { new Guid("cfa6cfc1-4ce0-4f78-8efc-4231bd38c056"), null, null, "Justus38@gmail.com", new Guid("7de3e658-53a0-464d-a4aa-b7bf40828f5d") },
                    { new Guid("cfdb9524-5660-46e4-9c85-2127cb3867e4"), null, null, "Thora_Goodwin@yahoo.com", new Guid("0447d1d8-3e48-4d64-8d2e-7d9a733628ec") },
                    { new Guid("d09594a6-23e3-4e8f-b6f7-d9cc3be4c38d"), null, null, "Elisha.Little79@yahoo.com", new Guid("405a5eb1-aee0-4578-8748-2d8b5a6b0d57") },
                    { new Guid("d0d247e2-a56d-4196-8d2e-e6b8812fa483"), null, null, "Ervin_Berge85@hotmail.com", new Guid("25c234e8-8d95-42b3-9dc3-c418fbcaa7da") },
                    { new Guid("d0ed3f98-ad8f-4c36-b728-78caa304e772"), null, null, "Doris92@gmail.com", new Guid("3a262ff7-1654-4c72-9285-3ba10eac6509") },
                    { new Guid("d0f0358d-dfb1-4fd1-abee-63f6acd8d01e"), null, null, "Quincy.Carter31@yahoo.com", new Guid("50ac14d1-c13d-42f2-8026-301c38b1964b") },
                    { new Guid("d1364853-c33d-42e2-b089-867809550fd1"), null, null, "Mina.Walker@hotmail.com", new Guid("b1817475-7a6c-44d8-8e81-4b59b1f4923e") },
                    { new Guid("d2027b1e-1562-4dfc-8a81-475ff155c512"), null, null, "Ari50@gmail.com", new Guid("21d9b3f2-945c-40a1-a0ca-7b6fcbe38a4e") },
                    { new Guid("d2b9173c-faa8-434e-afba-64c20b4c31a2"), null, null, "Clifford6@gmail.com", new Guid("39d27a82-05d2-4135-b53b-53748eefd4f2") },
                    { new Guid("d2c883c3-27f4-4648-a444-0cdd5ba090cb"), null, null, "Idella43@hotmail.com", new Guid("5f366c1b-9e38-4bc9-b773-fca63347cbcc") },
                    { new Guid("d30ad238-ac2c-4010-8245-fc20d1c2f522"), null, null, "Abbie_Harris87@hotmail.com", new Guid("6c3e0836-290a-4c10-8832-91720a2e9054") },
                    { new Guid("d34aee8d-15b6-4b7a-be9e-1b948be4f1a9"), null, null, "Ena.Stoltenberg82@hotmail.com", new Guid("d1d503de-e688-46df-9a53-6ca07b1d716f") },
                    { new Guid("d36b82db-7b90-476c-9182-a5d656424680"), null, null, "Paula.Rau@yahoo.com", new Guid("a780acfd-e10d-4dc5-a383-1ba56a91e666") },
                    { new Guid("d370e5e3-d3dd-4984-884d-4fb20c96d1f3"), null, null, "Eryn.Schinner@gmail.com", new Guid("141e6ca1-3b19-4ffc-a21f-8420c3f6db52") },
                    { new Guid("d37f0e0b-edc5-4185-ba1c-d114ce95d261"), null, null, "Haylee.Ward@hotmail.com", new Guid("5c5b9127-2aa5-4ed6-b779-6402154d5c0f") },
                    { new Guid("d3949e3b-3d37-4b36-b01c-74298d262a95"), null, null, "Tierra25@yahoo.com", new Guid("42babbec-5dbe-4cc3-9f68-bb4bc7ad9491") },
                    { new Guid("d39c665f-5aab-42d3-884d-ac3c75489bc6"), null, null, "Lew.Gerhold@gmail.com", new Guid("3ee0e809-4d8b-4164-a824-c5ab67903af7") },
                    { new Guid("d3ea35fa-6c11-4967-9d76-f009997ed7c4"), null, null, "Dustin_Schiller22@hotmail.com", new Guid("c7f42761-e210-47b4-9e39-2df36dce4c96") },
                    { new Guid("d489dc83-6b21-425f-93ac-895b0a612e6a"), null, null, "Kendall.Reinger65@gmail.com", new Guid("75ba16eb-aa9c-4c6f-90ae-1515360055a9") },
                    { new Guid("d4cd01bf-7f53-4ed8-824e-a0ff8b066211"), null, null, "Jo.Rowe@yahoo.com", new Guid("a03e50af-2ee0-4392-86e9-a0420b2f24bb") },
                    { new Guid("d525ac0f-e86d-4ae1-9848-5de87d4f5cf7"), null, null, "Hosea57@hotmail.com", new Guid("9ff0a0ca-02d0-4209-bb8f-a0d7efaf75bb") },
                    { new Guid("d5cd4e64-5126-4069-b6d9-d4b3e16eaff1"), null, null, "Elise_Schmidt77@gmail.com", new Guid("dbc51236-052c-4c31-820d-b0a01a143d1a") },
                    { new Guid("d5de8c29-79d2-41a4-8b58-0e75b91a5017"), null, null, "Kaley_Littel@hotmail.com", new Guid("4efd0f6e-db18-4603-b7c2-f032eb9132a9") },
                    { new Guid("d613b8ca-ca7a-4c7a-ae12-f27dc17781dd"), null, null, "Mohamed8@gmail.com", new Guid("34e9aed1-9d94-41dd-a50e-2e11424b25e1") },
                    { new Guid("d6d920ea-0401-4c7f-933e-8c4631ef3e2a"), null, null, "Jayson15@yahoo.com", new Guid("dc5f8e5e-be11-43f9-acd2-648e38e09946") },
                    { new Guid("d74db261-896c-489d-a9f6-b4747a3cd880"), null, null, "Sandrine98@gmail.com", new Guid("06f4c32b-9a3d-4b38-99a4-56ea0ba685a8") },
                    { new Guid("d7774303-e19f-40b0-87da-9930555a8140"), null, null, "Willard_OKon@yahoo.com", new Guid("4e8c89c0-a2fb-42d3-8d7a-11fe5d3b6d75") },
                    { new Guid("d8286a31-3c9c-4320-94bb-b41ee91ad642"), null, null, "Lamar_Ward56@gmail.com", new Guid("bd07490e-79db-4063-b992-0fa27e7f7677") },
                    { new Guid("d838a473-12ec-44f2-90a8-17d181f5b095"), null, null, "Reginald_Weissnat@gmail.com", new Guid("9ec54876-333f-4825-9959-c839395cb66e") },
                    { new Guid("d84322af-cc58-4886-a03b-36499bb9453d"), null, null, "Morris.Koss1@yahoo.com", new Guid("3c3a765d-c1b9-47c7-b39a-7b5dc35e1cbc") },
                    { new Guid("d847158c-dad1-4cd6-befe-8faed21e8a03"), null, null, "Esther15@hotmail.com", new Guid("530579fa-33a7-4827-a21f-b9cacab42c7d") },
                    { new Guid("d8889e2d-34ee-4124-a876-9d73fc3986d5"), null, null, "Julio_Volkman56@hotmail.com", new Guid("335c9d28-42e2-4d49-9686-f0cd1b972fae") },
                    { new Guid("d8ae96a0-9c07-4853-a8c3-53b96269681c"), null, null, "Pedro_Roob@gmail.com", new Guid("1cdde210-cf9c-4b69-a64c-3995a2267739") },
                    { new Guid("d90255ed-578c-4fed-9e0e-9de58c943600"), null, null, "Ebba.Sauer@gmail.com", new Guid("eeb82343-3a6f-48ee-b791-709692ceea7d") },
                    { new Guid("d926c7a9-5e90-4b9c-851d-a6ac99d2ba86"), null, null, "Clementina5@hotmail.com", new Guid("dbc51236-052c-4c31-820d-b0a01a143d1a") },
                    { new Guid("daf782d6-b774-48f0-87f0-6713a840ce4c"), null, null, "Eliza39@yahoo.com", new Guid("76c44275-2d3e-43e9-b34e-c05f912213b8") },
                    { new Guid("db36be32-7aea-4866-a3d7-90fdeaf3e057"), null, null, "Jaylon_Bashirian@hotmail.com", new Guid("757f3f70-fdce-4727-8fcf-9ac8aa0287b3") },
                    { new Guid("db36fed1-959e-4d3a-8771-67ebe881368a"), null, null, "Lina_Koss4@hotmail.com", new Guid("63107baa-d978-4764-b959-7e90a1de3ee0") },
                    { new Guid("db4d302f-3077-4666-a77f-312d4579d951"), null, null, "Isabel.Crist4@hotmail.com", new Guid("4c5d0085-4956-4748-b989-09b4d927d669") },
                    { new Guid("dbda6b7e-ebe4-4032-89bf-7be71a6d7a61"), null, null, "Dahlia_Paucek@gmail.com", new Guid("f28f3fdf-fa90-4b58-895f-89b7f89e53e9") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("dbdbcf80-b62f-40cf-9e65-41b9c0ed1a1a"), null, null, "Edythe.Deckow6@gmail.com", new Guid("a59d873d-ae08-427c-b25e-29c55895239f") },
                    { new Guid("dc4036be-6ebc-4b9f-b631-7a270d4d0111"), null, null, "Kailyn21@gmail.com", new Guid("bd07490e-79db-4063-b992-0fa27e7f7677") },
                    { new Guid("dc91f5b4-7d59-4f18-a0fc-295a8f369bbd"), null, null, "Alana.Davis@yahoo.com", new Guid("99d4724f-46db-42d2-a62b-3d8fa528e130") },
                    { new Guid("dcd963a8-912a-4004-b15c-3f7c402e8e5f"), null, null, "Lucio_Konopelski18@yahoo.com", new Guid("fe7a3052-1ad9-4450-b9d5-057c6abe9c2e") },
                    { new Guid("dd0e7f81-d052-41de-af2b-16c6e3098091"), null, null, "Dessie_Gutkowski0@gmail.com", new Guid("8ce72c63-9c31-4159-9ba2-012a4fc3df72") },
                    { new Guid("dd55f09a-a196-4618-9731-1a6d870f690d"), null, null, "Rosalia_Schoen@hotmail.com", new Guid("0d230077-5e9b-42d8-a83a-650a22378849") },
                    { new Guid("ddcfc4b5-1c48-4626-a0b6-0423d8e7e71d"), null, null, "Lorena34@yahoo.com", new Guid("6101631f-7cf2-4393-a938-099c07dbe44b") },
                    { new Guid("ddfabfec-6483-4a84-a786-1c15f2a09921"), null, null, "Kattie.Farrell@yahoo.com", new Guid("6f109fcf-941c-474c-810c-243f75df54d6") },
                    { new Guid("de2bee72-f861-4937-be3c-5975dd289ee7"), null, null, "Candida.Beahan@gmail.com", new Guid("f4c8c27a-6b37-469c-9492-061adc476725") },
                    { new Guid("de3cb72f-d20b-4732-9d9b-db915c684186"), null, null, "Jenifer.Leannon@yahoo.com", new Guid("affd1717-742a-4014-8e72-3420c7496c1e") },
                    { new Guid("de79473c-5cdd-411a-9748-d389c21181ce"), null, null, "Brigitte.Wehner43@gmail.com", new Guid("d0aae9a2-8c5b-48e9-b856-e309c80cadae") },
                    { new Guid("dee3595a-ef71-4ec5-86ee-c9888eb23941"), null, null, "Ayden96@yahoo.com", new Guid("01424fda-76cf-4203-995c-a75e43c1d1d0") },
                    { new Guid("df279f40-aad4-4fe3-8f70-5dee760c2456"), null, null, "Juliana.Kirlin@gmail.com", new Guid("f5fa9239-e966-4c8e-9eb5-32ecf277976e") },
                    { new Guid("dfbc15e2-f73c-4495-b45d-ebbb327212bd"), null, null, "Jason_Klein@yahoo.com", new Guid("25c234e8-8d95-42b3-9dc3-c418fbcaa7da") },
                    { new Guid("e039a482-28bc-4ef2-8c40-78da86f38ac4"), null, null, "Torrance28@gmail.com", new Guid("e5406e78-ce40-43ee-8dee-e58fe7687eb3") },
                    { new Guid("e0b2a6a2-a0bb-41c3-95a9-9861859d674e"), null, null, "Korey.Hoppe86@hotmail.com", new Guid("cf348fa5-7d32-48ec-957c-eb481beb0358") },
                    { new Guid("e2729e05-8639-4a48-8126-b2bf65978a10"), null, null, "Bonnie_Ziemann40@yahoo.com", new Guid("80c8c606-5918-4559-bdbb-606d564f96d5") },
                    { new Guid("e27f5257-4040-4a6c-8e0e-87c6cd5ad95a"), null, null, "Shaun.Hilpert@gmail.com", new Guid("3c3a765d-c1b9-47c7-b39a-7b5dc35e1cbc") },
                    { new Guid("e2d8d5d0-7b1e-4be2-9f0f-ac4d491ba5bc"), null, null, "Ryann_Lehner47@yahoo.com", new Guid("8b3afef3-3bbb-4237-b8b8-1eba1df7757e") },
                    { new Guid("e373dd87-0b75-429f-9885-89d72bc521f1"), null, null, "Tyrel.Heller1@gmail.com", new Guid("653800c1-b55d-4636-99c0-ea31223d7e3b") },
                    { new Guid("e393d85f-9dac-4217-b8b7-1ece674e4552"), null, null, "Darren.White@hotmail.com", new Guid("56234ad9-accf-413f-8d2b-5d6fb1cd04a1") },
                    { new Guid("e3c2926e-12c8-450b-9db2-49f37fdf198c"), null, null, "Beth_Gorczany24@yahoo.com", new Guid("db32027d-cf9c-4544-af7d-d20c917925c7") },
                    { new Guid("e438e683-529a-4d83-9dfc-26d733c2be2d"), null, null, "Zola_Herzog35@yahoo.com", new Guid("ea848f07-5360-4e76-ac1d-cf046366d4ef") },
                    { new Guid("e45d4edf-8f50-457a-bb6f-768c464f5518"), null, null, "Tanner.Bartell41@yahoo.com", new Guid("d43ee797-d0bc-4a3e-8833-c45e9d340f44") },
                    { new Guid("e49d7ccd-f111-435a-8661-31c1dfc48760"), null, null, "June.Stanton80@gmail.com", new Guid("141e6ca1-3b19-4ffc-a21f-8420c3f6db52") },
                    { new Guid("e52a172c-9137-4eb4-a3ff-bdc787a3d276"), null, null, "Jessy61@gmail.com", new Guid("0bf479c3-ab54-4392-b19e-a71b3942b7fe") },
                    { new Guid("e5b8869f-23aa-493d-b7a4-ff6b748ac68b"), null, null, "Alphonso_Bartell@hotmail.com", new Guid("5d1e2a88-0f0a-4b6e-a524-e279224a1944") },
                    { new Guid("e5ba5240-9ae3-443e-84cd-36964c7f63a0"), null, null, "Vernice.Gulgowski@hotmail.com", new Guid("71f7fb3b-e7f1-4325-bdd2-98f71dd515b1") },
                    { new Guid("e5f64822-2f5b-4d9f-8f94-0066d7041dc5"), null, null, "Lucio31@gmail.com", new Guid("5d203345-c58f-4236-9e46-c9ba7a8529a5") },
                    { new Guid("e5fcb898-7fb7-4746-a6ff-db021649bb9d"), null, null, "Isaiah81@yahoo.com", new Guid("4e8c89c0-a2fb-42d3-8d7a-11fe5d3b6d75") },
                    { new Guid("e6647384-92a3-4932-bdd3-c99cf7a6b543"), null, null, "Santa_Conroy@gmail.com", new Guid("8b3afef3-3bbb-4237-b8b8-1eba1df7757e") },
                    { new Guid("e6bef307-9a20-4bcd-9007-ea2e8ac67f32"), null, null, "Piper_Morissette44@gmail.com", new Guid("7a52231d-ba53-47d6-8382-e5bf5f9e7e24") },
                    { new Guid("e71459eb-ee7b-4979-b756-42c66cf1b563"), null, null, "Floyd.Rodriguez77@gmail.com", new Guid("ac4ee7ff-56c7-4c45-ba3e-32ed6d9370f3") },
                    { new Guid("e741bd44-8149-4eb5-bb32-97caa420f96b"), null, null, "Kian_Hartmann@gmail.com", new Guid("df1ba0e6-99b8-419d-a3b8-cece7c4928bd") },
                    { new Guid("e7750112-70f5-4206-bd01-66fd5b01419d"), null, null, "Billie32@yahoo.com", new Guid("a5276d46-3296-4c05-ba31-d2ebddfd8a57") },
                    { new Guid("e777928c-e3df-48be-bd8b-9b673fd892e5"), null, null, "Fredrick30@yahoo.com", new Guid("9e39f449-ecbf-4238-8ca8-47309c134789") },
                    { new Guid("e8092b5e-8c07-45a2-9a16-1283d8fc234f"), null, null, "Fidel9@yahoo.com", new Guid("92a5d027-0cfb-43ec-84b3-d812837c5654") },
                    { new Guid("e8c55f62-628a-4a26-b16c-4b22aa9ddcf5"), null, null, "Gregorio.Cronin92@gmail.com", new Guid("4188ab2e-f46b-4cf6-b460-560a914e5d35") },
                    { new Guid("e90cabe2-245e-42ab-99e5-099db9f1ed98"), null, null, "Scarlett58@hotmail.com", new Guid("3314d8f7-2262-4e19-afd4-3e85972480b8") },
                    { new Guid("e92a0f98-2536-4a0b-9441-f5ca0773739e"), null, null, "Esther10@gmail.com", new Guid("b8e5286e-6ec4-4001-89c4-e17065f9bf09") },
                    { new Guid("e93f1cfc-da7a-4c40-8e75-42e180c3fe65"), null, null, "Russel98@gmail.com", new Guid("cf611bf3-21fb-4ed7-a138-00c7afdda9ba") },
                    { new Guid("e9466b2c-a76e-4f26-bc64-6dabd67af9d5"), null, null, "Lillie69@hotmail.com", new Guid("ed1f5061-44e1-4df4-b0de-bc0c17fd0185") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("e9e082fe-f161-4628-a167-72bed373d474"), null, null, "Angelina23@yahoo.com", new Guid("c40f9fee-6298-4137-bc78-c74409dec92f") },
                    { new Guid("ea3630cf-f8f9-42cb-9a87-beca4e1b8720"), null, null, "Frankie46@gmail.com", new Guid("40a279f6-73dd-4fa2-8b1e-05f9cd8bdcf9") },
                    { new Guid("ea47e1ca-ff4c-406c-af2e-cdbb85a19fdb"), null, null, "Gunnar_Hane2@hotmail.com", new Guid("c221f46b-a606-417e-aead-c8b255d84d11") },
                    { new Guid("ea6b466c-d35d-4124-b6ee-8f6beaabc124"), null, null, "Faustino1@yahoo.com", new Guid("bbe91897-98e6-4c1e-aef5-09cd3dbb35cd") },
                    { new Guid("eab732a8-d173-4010-9c39-0d90f9bd65cc"), null, null, "Kira.Huel10@gmail.com", new Guid("dc5f8e5e-be11-43f9-acd2-648e38e09946") },
                    { new Guid("ebf7f3c4-531c-4802-99a0-db93e8a2903f"), null, null, "Arch.Kihn@hotmail.com", new Guid("539c62ee-15fc-4d37-ab5d-0e4126109954") },
                    { new Guid("ec700a92-56aa-44bf-8c63-42385cce8388"), null, null, "Raegan_Reichert@hotmail.com", new Guid("22edc826-6747-4099-aca5-578199353ac6") },
                    { new Guid("ed36ef07-a9f8-42c3-adfa-e3adf4f45b1e"), null, null, "Nelle58@hotmail.com", new Guid("64174d68-43d3-488f-89bf-23d32b134019") },
                    { new Guid("ed66ac6f-06dd-4529-838d-1dfe1a9b26e4"), null, null, "Mabel63@hotmail.com", new Guid("34e9aed1-9d94-41dd-a50e-2e11424b25e1") },
                    { new Guid("ed7a3de2-fa17-45e4-92c1-e154ab9c4377"), null, null, "Riley19@yahoo.com", new Guid("bc7c70fa-9300-4c06-afd7-8aa97fcf9993") },
                    { new Guid("ede03cf2-cf24-4d27-b86f-641c04bc2f34"), null, null, "Janet_Beahan48@yahoo.com", new Guid("4a9e17b4-cb0f-4c82-80d2-e1d56fe06f0a") },
                    { new Guid("ee3e1609-9cef-4417-974d-e0056adeec7d"), null, null, "Chance_McLaughlin@gmail.com", new Guid("b21ce16f-bf5c-4cfa-9fd4-9b67014eadbb") },
                    { new Guid("ee846ab6-276d-40d9-adce-a980578e7dc6"), null, null, "Noah_Muller36@yahoo.com", new Guid("dc2b5eaa-01f8-425c-874d-15e523189cc1") },
                    { new Guid("ee9d5f8b-5004-4cd3-a7c4-3abe319fb468"), null, null, "Bo.Ruecker22@hotmail.com", new Guid("719d1670-ba7d-4e9b-b4de-d7074f81aa66") },
                    { new Guid("eebe1008-5708-44bd-aaef-fbffbc2d6a3a"), null, null, "Ari94@hotmail.com", new Guid("2c87eaa4-8e07-41f4-bad0-935d07541e78") },
                    { new Guid("eece6f26-0797-49c0-818d-78aaf4770f68"), null, null, "Maximo46@yahoo.com", new Guid("394e6c37-a398-4cf7-983d-8fb216e6c46f") },
                    { new Guid("ef311ba0-7e58-47da-8ca2-d74861f7c1db"), null, null, "Reva_Mayer19@hotmail.com", new Guid("530579fa-33a7-4827-a21f-b9cacab42c7d") },
                    { new Guid("ef607ad8-6875-442c-ad82-6d102ad2932b"), null, null, "Kamron80@yahoo.com", new Guid("bd07490e-79db-4063-b992-0fa27e7f7677") },
                    { new Guid("ef9f65bc-c993-4222-afef-0e00a740eaab"), null, null, "Raoul74@yahoo.com", new Guid("db91ddfb-75b6-4d51-82ea-52631a102b16") },
                    { new Guid("f00531be-6bb1-429f-a1c2-cb0ea67a2fce"), null, null, "Enrique_Schultz67@gmail.com", new Guid("831f8f9d-e78d-4f72-8b48-1c32c42fda1b") },
                    { new Guid("f03cc893-d20e-46f7-9b71-c07f6d46f1a1"), null, null, "Willie14@yahoo.com", new Guid("bbe91897-98e6-4c1e-aef5-09cd3dbb35cd") },
                    { new Guid("f0a04f35-5f43-4313-82ee-b33a2d95fe38"), null, null, "Clair.Grant@hotmail.com", new Guid("5d1e2a88-0f0a-4b6e-a524-e279224a1944") },
                    { new Guid("f0c65b14-b662-4212-9a2b-e0c4857ea2bd"), null, null, "Madonna.Hyatt46@hotmail.com", new Guid("c88c725e-8cbf-416d-a4bf-153a024ea6c9") },
                    { new Guid("f0dadc15-3811-4cb4-b0f5-7ead2839c833"), null, null, "Katrina30@yahoo.com", new Guid("0e7742f2-e964-4e8c-b692-4ffb75ece318") },
                    { new Guid("f11a16b3-4d75-4786-8876-6abfbb154727"), null, null, "Sandrine.Thompson@gmail.com", new Guid("0c66002d-25be-4864-84e7-acd6fd765b27") },
                    { new Guid("f177c172-1478-4f03-9b96-1b92355dab36"), null, null, "Noel94@gmail.com", new Guid("6b5cd903-9056-4302-b3e6-b910c3a67f76") },
                    { new Guid("f18df401-3d94-41cd-a581-fb71ec3ef319"), null, null, "Gay28@yahoo.com", new Guid("c5efb9ab-d786-43d2-9595-c90aedaedb9b") },
                    { new Guid("f1936b82-bc2f-4520-b705-a722a685798c"), null, null, "Renee.Kohler@gmail.com", new Guid("50b1b40f-32d2-45da-a690-b9d24fff476e") },
                    { new Guid("f2042a76-fdc6-4b81-9bb8-de9081a67a91"), null, null, "Damon_Waters92@yahoo.com", new Guid("3a6fda52-d9f1-418c-8ffa-69974f7f39be") },
                    { new Guid("f24eab2c-f330-4528-b596-d9492edf5776"), null, null, "Vince.McGlynn@hotmail.com", new Guid("4b45c810-f446-449d-8b0e-4a2ebbbf7104") },
                    { new Guid("f2ba0a59-366d-4b1e-b210-9bbb43cfae76"), null, null, "Meredith35@yahoo.com", new Guid("74ef9233-8d34-4883-8938-b78b6c147246") },
                    { new Guid("f2f37b20-09bd-49d7-915a-e843800f08be"), null, null, "Lilla.Bednar86@hotmail.com", new Guid("2476b4fb-aceb-40f6-b636-80dd269d535c") },
                    { new Guid("f3ca2da3-7ac9-4567-abea-463a66b4f747"), null, null, "Tyler2@gmail.com", new Guid("182bd5c0-616f-4e9b-8837-7c2b67e01496") },
                    { new Guid("f3e32369-8b51-466c-a2c3-8298983762a7"), null, null, "Isom_Nienow@gmail.com", new Guid("8ea935b6-2c30-4bef-803c-9f382789979b") },
                    { new Guid("f464e5f3-cb7a-48a1-a991-62e26f0a3c00"), null, null, "Lizeth.Wyman54@yahoo.com", new Guid("1381d1cd-5c11-46c1-bc37-987b3f5ae33e") },
                    { new Guid("f4dc919a-a0b7-44e3-94e9-d0dbdd0e3b9b"), null, null, "Tyra88@hotmail.com", new Guid("5c6a10ae-343d-47fa-9381-6cbe7b1a68be") },
                    { new Guid("f53fb091-7f4b-4e83-92ad-927e3bcb0ba6"), null, null, "Braulio.Jones62@yahoo.com", new Guid("ce7719fc-1874-4df0-88ba-9b5637945029") },
                    { new Guid("f5ba4558-2a28-49fd-8170-37a421126ad7"), null, null, "Lisandro.Rice97@hotmail.com", new Guid("59a9232d-40d9-422d-8a1a-fe022e85093a") },
                    { new Guid("f5cf8816-7315-43b4-b769-67432b8717d6"), null, null, "Walker.Hauck@yahoo.com", new Guid("548e47d4-b851-4432-8514-fc092768db5b") },
                    { new Guid("f5f25522-d91a-4c4e-ba2c-ee4984720f85"), null, null, "Kali_Medhurst36@hotmail.com", new Guid("bc7c70fa-9300-4c06-afd7-8aa97fcf9993") },
                    { new Guid("f5f8492b-7a66-4705-a9d8-1c39cac3d672"), null, null, "Zachariah_Stracke50@yahoo.com", new Guid("d43ee797-d0bc-4a3e-8833-c45e9d340f44") },
                    { new Guid("f612fd1e-d305-48af-aef9-5ae7617dac28"), null, null, "Adella.Armstrong@hotmail.com", new Guid("8c30b7e6-1da3-4a5c-87ba-544b9377a290") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("f6144023-bce2-424f-b238-9e85ed9027bc"), null, null, "Demond_Bergnaum@yahoo.com", new Guid("99d4724f-46db-42d2-a62b-3d8fa528e130") },
                    { new Guid("f7196cd6-caff-4279-9b73-77ae1c790498"), null, null, "Dahlia96@yahoo.com", new Guid("f3cb510a-8243-4204-8c1f-ace56610d45f") },
                    { new Guid("f71e829d-e7d1-4243-8400-8246395b2d13"), null, null, "Alison29@gmail.com", new Guid("50ac14d1-c13d-42f2-8026-301c38b1964b") },
                    { new Guid("f74251ae-3a84-4712-bf8e-b806ff39b3aa"), null, null, "Robert_Crist29@yahoo.com", new Guid("335c9d28-42e2-4d49-9686-f0cd1b972fae") },
                    { new Guid("f7deae7b-8237-4409-ab60-29218cabb0f1"), null, null, "Thalia.Feil@hotmail.com", new Guid("719d1670-ba7d-4e9b-b4de-d7074f81aa66") },
                    { new Guid("f7e19baf-d59c-4267-bbd9-4445411d917f"), null, null, "Emmy_Marks@gmail.com", new Guid("0c66002d-25be-4864-84e7-acd6fd765b27") },
                    { new Guid("f7e4e447-0a10-4e20-895a-4a4d9f5cdc27"), null, null, "Merle_Hintz66@hotmail.com", new Guid("40a279f6-73dd-4fa2-8b1e-05f9cd8bdcf9") },
                    { new Guid("f810a826-9ae6-46bf-90d6-637572d704a5"), null, null, "Abigale.Mueller43@yahoo.com", new Guid("f630d90d-3329-4958-99e4-34aa2f69436c") },
                    { new Guid("f81123e8-aee5-45d1-bf30-d32c22f2a919"), null, null, "Kara.Donnelly@gmail.com", new Guid("757f3f70-fdce-4727-8fcf-9ac8aa0287b3") },
                    { new Guid("f885e51e-3992-4fec-a544-11865cf20c8e"), null, null, "Kaelyn3@hotmail.com", new Guid("a419df27-9358-4a02-9ab7-2f2e2344fae0") },
                    { new Guid("f8baa53e-fa10-4c1f-b991-6721abf5f78a"), null, null, "Eduardo.Borer@gmail.com", new Guid("df3cc97e-5297-4426-8d73-6ec8a1d6ff19") },
                    { new Guid("f8fe680a-06ab-4847-969b-f027e6ebbbb1"), null, null, "Ryan2@hotmail.com", new Guid("75ba16eb-aa9c-4c6f-90ae-1515360055a9") },
                    { new Guid("f91713d8-1bee-4fca-a776-26c09f24a0c9"), null, null, "Della.Gerlach86@yahoo.com", new Guid("6c3e0836-290a-4c10-8832-91720a2e9054") },
                    { new Guid("f91cacf1-a904-456b-adb0-de4a051451c2"), null, null, "Darrion31@yahoo.com", new Guid("4732299f-418c-4c2e-ac09-aacb3b2c8976") },
                    { new Guid("f95f72b5-5824-4b87-b2a1-65cd3f1dc92b"), null, null, "Gino.Bergstrom72@gmail.com", new Guid("7abaa815-d503-4740-a0a9-20d8752fc2cf") },
                    { new Guid("f9db2cf8-cd49-42ef-a752-b1fabde520e7"), null, null, "Furman27@gmail.com", new Guid("39d27a82-05d2-4135-b53b-53748eefd4f2") },
                    { new Guid("f9f6c016-96d6-435c-80af-e58ed51b9599"), null, null, "Bessie.Lowe@yahoo.com", new Guid("74ef9233-8d34-4883-8938-b78b6c147246") },
                    { new Guid("fa16f28e-029e-496b-b5bd-c0efbaf0d29a"), null, null, "Oceane42@hotmail.com", new Guid("adbbd240-641f-475b-b705-5e35298ef012") },
                    { new Guid("fa32a8c8-6850-4cea-b0bb-690660e5e057"), null, null, "Andre89@hotmail.com", new Guid("3ff3d88e-b078-4f3a-8312-8447eeb772e2") },
                    { new Guid("fa7d653e-57c9-4100-9292-a1b4cc13dfe4"), null, null, "Guillermo.Fisher81@hotmail.com", new Guid("8c30b7e6-1da3-4a5c-87ba-544b9377a290") },
                    { new Guid("fa8b1863-4315-46d8-abca-62c15c0f3cdb"), null, null, "Tia_Kessler@gmail.com", new Guid("93e9e8fa-8b76-4968-a1ef-a4d59b6958ea") },
                    { new Guid("fa90352d-77fe-4b4a-87eb-f7d99544a268"), null, null, "Taylor.Nader64@gmail.com", new Guid("7778b4eb-db56-4ddd-a0bc-5f46aff077f7") },
                    { new Guid("fab4212c-0b38-4749-b23d-b6df13176fec"), null, null, "Amelia.Cummings@yahoo.com", new Guid("097cb7d3-d333-48aa-b8ee-cacd11ee91fa") },
                    { new Guid("fab5ccbd-2010-4478-adbe-934ad2eb1d5b"), null, null, "Modesto.Green@hotmail.com", new Guid("48b3cd65-be2f-4be1-a3c5-d88da44b3d73") },
                    { new Guid("fae5701f-622b-402c-b0c0-2829a7d5b9c1"), null, null, "Charity.Lynch@gmail.com", new Guid("c5513371-ea13-4b3b-ab65-8bbb471b2afc") },
                    { new Guid("faee49e2-5e28-45b5-b66a-54b5ce7ad4ce"), null, null, "Chasity_Farrell@yahoo.com", new Guid("8e3d5153-23be-45f9-83b4-5aecbb1a4322") },
                    { new Guid("fbee70fe-11c0-46f3-a75c-e445ff740775"), null, null, "Juana.Dicki@yahoo.com", new Guid("1e17494c-b19d-4879-af0e-c6575db6bd37") },
                    { new Guid("fc4d4162-db3f-49e5-b0a5-229ca5188343"), null, null, "Antonina.Cronin86@gmail.com", new Guid("1937fdf7-97b0-4102-95c9-2163eb910112") },
                    { new Guid("fc5c5118-d5a0-48ff-b238-ebbaebafca50"), null, null, "Consuelo9@gmail.com", new Guid("c590f92c-3ca1-4a33-a976-926995a0f7cc") },
                    { new Guid("fc62b550-e1a4-4646-b898-89ee6de79794"), null, null, "Fermin.Maggio@gmail.com", new Guid("aeae0f68-579f-46b8-bee2-c797ee09ee5e") },
                    { new Guid("fc7032f1-777c-4d4f-bb3d-bdb236fd4cc2"), null, null, "Arturo.Schultz87@yahoo.com", new Guid("ac4ee7ff-56c7-4c45-ba3e-32ed6d9370f3") },
                    { new Guid("fcb74022-d821-4ef2-baef-977b142b8e5c"), null, null, "Lyda5@gmail.com", new Guid("75ba16eb-aa9c-4c6f-90ae-1515360055a9") },
                    { new Guid("fcd3b4ef-a989-4094-bc08-73fe63cd5686"), null, null, "Ralph39@yahoo.com", new Guid("a03e50af-2ee0-4392-86e9-a0420b2f24bb") },
                    { new Guid("fce8e909-f2b6-4f9e-8227-74fff68a2808"), null, null, "Janiya1@yahoo.com", new Guid("0d230077-5e9b-42d8-a83a-650a22378849") },
                    { new Guid("fd8df00d-4541-43e0-950a-f937f107a474"), null, null, "Pedro24@gmail.com", new Guid("f7082ecf-eb66-429e-8a3f-72fac7d7b453") },
                    { new Guid("fdd77b60-5bb5-4ce5-913a-405512949697"), null, null, "Brandi.Braun22@gmail.com", new Guid("a59d873d-ae08-427c-b25e-29c55895239f") },
                    { new Guid("fe1e28be-74bc-4719-bfa2-f90e6faa29db"), null, null, "Malinda.Torphy6@gmail.com", new Guid("97e11482-d5e6-41d7-82e3-80806df9c3bc") },
                    { new Guid("fe24dc45-ccf6-490a-a88d-d05d6ffd01d8"), null, null, "Enrique_Hackett@hotmail.com", new Guid("c221f46b-a606-417e-aead-c8b255d84d11") },
                    { new Guid("fee1274c-2a51-4dd4-bd18-4b5ae3ec7d96"), null, null, "Caroline_Rau@yahoo.com", new Guid("9e96d314-cd64-47aa-a5bc-7e0525cc9914") },
                    { new Guid("fefd4add-e07c-4188-8d60-571b21969a1e"), null, null, "Adrienne.Dicki23@yahoo.com", new Guid("3b3e9016-3025-48e3-93b2-fa474015c0f7") },
                    { new Guid("ff01422a-3ed2-4eac-a861-d0c5c3321cb4"), null, null, "Nova_Schneider46@hotmail.com", new Guid("59a9232d-40d9-422d-8a1a-fe022e85093a") },
                    { new Guid("ff9b55ef-27dd-4826-a581-d95d98b42c3e"), null, null, "Ashlynn21@yahoo.com", new Guid("8e3d5153-23be-45f9-83b4-5aecbb1a4322") }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("011a6f93-78e6-4b97-82bd-aaf16480447e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 1, 2, 33, 38, 926, DateTimeKind.Local).AddTicks(3525), new DateTime(2023, 9, 2, 2, 33, 38, 926, DateTimeKind.Local).AddTicks(3525), null, 68.86m, 4689362184164010m, true, "ParcelMachine", 3, 36.387463f, "129 Beatty Summit, Jacobsonshire, Tunisia", new Guid("8c30b7e6-1da3-4a5c-87ba-544b9377a290"), "94151 Earlene Path, Noeliashire, Montenegro", new Guid("8be01b71-4060-43ad-98a5-2c0730fd003b"), "Delivered", "PlasticBag" },
                    { new Guid("06516df1-7cde-435f-bc33-da7d1daaf754"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 10, 16, 45, 57, 524, DateTimeKind.Local).AddTicks(5086), new DateTime(2023, 11, 11, 16, 45, 57, 524, DateTimeKind.Local).AddTicks(5086), null, 94.31m, 3560711735078384m, true, "Special", 2, 8.542186f, "1321 Hayes Lakes, New Hilton, Germany", new Guid("1a21f215-231c-4e09-b7c2-4e3163978286"), "90690 Runte Burgs, Leraburgh, Japan", new Guid("815c5bf5-7253-492e-81c8-82e2d6860602"), "Registered", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("0d589a0f-0599-45c8-812b-ae10276e32ab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 4, 9, 41, 15, 357, DateTimeKind.Local).AddTicks(2588), new DateTime(2023, 6, 7, 9, 41, 15, 357, DateTimeKind.Local).AddTicks(2588), null, 74.52m, 2801026173965043m, "Special", 2, 17.358072f, "26537 Parisian Village, Hanebury, Yemen", new Guid("141e6ca1-3b19-4ffc-a21f-8420c3f6db52"), "904 Buster Parkway, Frankiestad, France", new Guid("3a6fda52-d9f1-418c-8ffa-69974f7f39be"), "Return", "CardboardBox" },
                    { new Guid("12848e34-d48d-42c5-87a2-36e86d34cd30"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 25, 19, 24, 44, 171, DateTimeKind.Local).AddTicks(6423), new DateTime(2024, 1, 26, 19, 24, 44, 171, DateTimeKind.Local).AddTicks(6423), null, 38.47m, 6776002223151843m, "Courier", 5, 27.6661f, "53437 Willard Inlet, Port Mossiebury, Macedonia", new Guid("8dca8632-b27c-44ad-bd6c-0d7679a4f075"), "15878 Jones Parkway, New Corrine, South Georgia and the South Sandwich Islands", new Guid("e41a0e5f-468e-496b-8fe7-b8f4b2a0f962"), "Delivered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("13da6a2b-e5c8-45a8-8c52-32e8a3a714f8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 23, 17, 4, 28, 866, DateTimeKind.Local).AddTicks(7850), new DateTime(2024, 2, 1, 17, 4, 28, 866, DateTimeKind.Local).AddTicks(7850), null, 72.38m, true, 1627441620793106m, "ParcelMachine", 5, 2.8364296f, "64497 Roob View, Aldafurt, Maldives", new Guid("c2701daa-7747-422a-bb74-d9ffc8e0f5fc"), "522 Pink Falls, Yoshikoton, Bosnia and Herzegovina", new Guid("3b3e9016-3025-48e3-93b2-fa474015c0f7"), "Sent", "PlasticBag" },
                    { new Guid("150a165a-7d0a-4fa2-9e8a-07e565dde95e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 11, 20, 46, 56, 222, DateTimeKind.Local).AddTicks(6384), new DateTime(2023, 7, 17, 20, 46, 56, 222, DateTimeKind.Local).AddTicks(6384), null, 84.95m, true, 5474863815064217m, "ParcelMachine", 1, 41.21428f, "424 Frank Road, O'Konchester, Vietnam", new Guid("49ef4ccb-eb29-4ffa-bcfe-88759ac3f1c5"), "02014 Bettye Rue, Bradborough, Holy See (Vatican City State)", new Guid("db91ddfb-75b6-4d51-82ea-52631a102b16"), "Return", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("1579e24e-98c5-4db9-8024-7da9afa3fc16"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 8, 18, 40, 44, 969, DateTimeKind.Local).AddTicks(1760), new DateTime(2023, 12, 15, 18, 40, 44, 969, DateTimeKind.Local).AddTicks(1760), null, 66.38m, true, 2207655830734826m, true, "Courier", 4, 2.4096863f, "43203 McLaughlin Path, Luettgenchester, Mauritania", new Guid("fcf05f51-7f3a-4331-a0f5-6204db62e7ba"), "1264 Sheridan Rue, North Amie, Isle of Man", new Guid("d40492c4-d582-4ce6-943c-a487675b7960"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("166f36b2-a5b5-4b83-84fd-93a7a1af6e7c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 11, 8, 21, 39, 365, DateTimeKind.Local).AddTicks(9604), new DateTime(2024, 2, 21, 8, 21, 39, 365, DateTimeKind.Local).AddTicks(9604), null, 85.64m, 4061125259266219m, "Courier", 2, 5.1666307f, "29436 Chet Drive, Lake Adellestad, Afghanistan", new Guid("6101631f-7cf2-4393-a938-099c07dbe44b"), "355 Green Green, Leilanihaven, Kenya", new Guid("21d9b3f2-945c-40a1-a0ca-7b6fcbe38a4e"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("184a27ed-8016-46d2-9958-aae3134ef95b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 9, 0, 6, 48, 3, DateTimeKind.Local).AddTicks(5209), new DateTime(2024, 5, 10, 0, 6, 48, 3, DateTimeKind.Local).AddTicks(5209), null, 16.88m, true, 7597974130335115m, "Super", 5, 16.498781f, "9424 Bayer Common, Port Odiehaven, Taiwan", new Guid("22edc826-6747-4099-aca5-578199353ac6"), "266 Presley Extension, Port Nellie, Wallis and Futuna", new Guid("8be01b71-4060-43ad-98a5-2c0730fd003b"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("186464b3-1d0c-4cdb-bf74-f0a29694c00c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 4, 14, 38, 14, 36, DateTimeKind.Local).AddTicks(4349), new DateTime(2024, 2, 11, 14, 38, 14, 36, DateTimeKind.Local).AddTicks(4349), null, 27.92m, 6552104265325226m, true, "Super", 1, 29.781992f, "8802 Charlie Squares, Cliffordside, Turkmenistan", new Guid("b5cca55a-d81f-47be-b0b4-50d07e79ce69"), "6215 Tate Valley, Torphyburgh, Netherlands Antilles", new Guid("fe7a3052-1ad9-4450-b9d5-057c6abe9c2e"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("19153de9-2bf6-4b01-8e0b-dbcbb9d9f499"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 25, 12, 0, 21, 133, DateTimeKind.Local).AddTicks(9236), new DateTime(2023, 12, 31, 12, 0, 21, 133, DateTimeKind.Local).AddTicks(9236), null, 96.39m, true, 2065072824905787m, "Special", 1, 24.934122f, "12914 Ulices Plaza, Valentineland, Tajikistan", new Guid("db91ddfb-75b6-4d51-82ea-52631a102b16"), "991 Elian Ville, Tremblayville, Tunisia", new Guid("1381d1cd-5c11-46c1-bc37-987b3f5ae33e"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("1ab78e0c-9df0-498e-baf0-1699c9e7c18d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 21, 17, 49, 43, 651, DateTimeKind.Local).AddTicks(3023), new DateTime(2023, 9, 25, 17, 49, 43, 651, DateTimeKind.Local).AddTicks(3023), null, 96.60m, 9577222391131648m, "Courier", 3, 40.638767f, "14718 Madelynn Corner, Marleneview, Madagascar", new Guid("dc2b5eaa-01f8-425c-874d-15e523189cc1"), "70119 Travis Ranch, Brownstad, South Africa", new Guid("dc5f8e5e-be11-43f9-acd2-648e38e09946"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("1fdbc3d7-e1fe-42b1-93d8-adfaf721dc7a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 14, 17, 52, 36, 822, DateTimeKind.Local).AddTicks(9884), new DateTime(2023, 9, 18, 17, 52, 36, 822, DateTimeKind.Local).AddTicks(9884), null, 77.25m, 3550414563590131m, true, "Super", 2, 34.50483f, "6125 Kip Brook, West Suzanneport, Burundi", new Guid("97e11482-d5e6-41d7-82e3-80806df9c3bc"), "436 O'Reilly Rest, Princessshire, China", new Guid("9ec54876-333f-4825-9959-c839395cb66e"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("214d493a-643d-479f-84e7-42923ad4b58e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 18, 10, 16, 27, 284, DateTimeKind.Local).AddTicks(2725), new DateTime(2023, 9, 20, 10, 16, 27, 284, DateTimeKind.Local).AddTicks(2725), null, 98.16m, true, 7988061214800877m, "Courier", 1, 35.318996f, "093 Nader Union, Mellieland, Samoa", new Guid("42c4353e-7775-4c68-a647-2b921bb87c89"), "1965 Eleanore Throughway, New Melvinville, Saint Pierre and Miquelon", new Guid("76c44275-2d3e-43e9-b34e-c05f912213b8"), "Delivered", "CardboardBox" },
                    { new Guid("21f6bf13-7d5c-40d9-875c-b740a6d103ca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 12, 16, 21, 14, 128, DateTimeKind.Local).AddTicks(6291), new DateTime(2024, 3, 22, 16, 21, 14, 128, DateTimeKind.Local).AddTicks(6291), null, 85.29m, true, 6544294923691531m, "Courier", 2, 48.983578f, "703 Wintheiser Circle, Sydneyburgh, Marshall Islands", new Guid("db32027d-cf9c-4544-af7d-d20c917925c7"), "0466 Rice Hills, Annieview, Egypt", new Guid("1bab23ea-659b-4531-ad24-fdfd8984675d"), "Return", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("24e76763-6bf6-4d8a-9f8b-91a9d964fefb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 4, 3, 14, 16, 654, DateTimeKind.Local).AddTicks(3832), new DateTime(2023, 9, 9, 3, 14, 16, 654, DateTimeKind.Local).AddTicks(3832), null, 10.92m, 5641947542564499m, true, "Special", 3, 6.8412514f, "71245 Zboncak Field, South Franzburgh, Australia", new Guid("94c09a0c-18a4-40c8-9285-032386267d16"), "543 Arlo Shores, West Louburgh, United Kingdom", new Guid("719d1670-ba7d-4e9b-b4de-d7074f81aa66"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("29b116ec-9e7b-481d-a1b4-b374bcedc913"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 5, 12, 51, 49, 994, DateTimeKind.Local).AddTicks(6512), new DateTime(2024, 2, 11, 12, 51, 49, 994, DateTimeKind.Local).AddTicks(6512), null, 68.90m, true, 2992220555222482m, true, "Standart", 4, 28.390383f, "233 Sigmund Ridge, Lake Trenton, France", new Guid("4732299f-418c-4c2e-ac09-aacb3b2c8976"), "5685 Elvis Mill, Gorczanymouth, Congo", new Guid("719d1670-ba7d-4e9b-b4de-d7074f81aa66"), "Sent", "PlasticBag" },
                    { new Guid("2a496df4-c231-42e0-bbc6-ec7fe2919d4b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 26, 10, 9, 11, 12, DateTimeKind.Local).AddTicks(9257), new DateTime(2024, 4, 1, 10, 9, 11, 12, DateTimeKind.Local).AddTicks(9257), null, 32.97m, true, 2552949780046001m, true, "Special", 3, 22.027233f, "2684 Kozey Point, New Bernadinebury, Nigeria", new Guid("9e96d314-cd64-47aa-a5bc-7e0525cc9914"), "06219 Gabriel Club, North Edison, Oman", new Guid("dd550cd7-4eae-4d75-8be5-5f3e496fdd24"), "OnTheWay", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("2ac84d8e-92a3-499c-a202-1664db620e50"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 19, 19, 52, 31, 259, DateTimeKind.Local).AddTicks(9913), new DateTime(2024, 1, 21, 19, 52, 31, 259, DateTimeKind.Local).AddTicks(9913), null, 54.00m, 2764982372963199m, true, "Super", 3, 8.756031f, "90344 Bogan Camp, West Franz, Venezuela", new Guid("82b99640-3f2e-425b-a088-51b3c226a192"), "8440 Ara Locks, West Madysontown, Sierra Leone", new Guid("c5513371-ea13-4b3b-ab65-8bbb471b2afc"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("2b0b24b6-a0c0-43ca-a77b-5edf4c053933"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 17, 4, 8, 16, 666, DateTimeKind.Local).AddTicks(3850), new DateTime(2024, 3, 18, 4, 8, 16, 666, DateTimeKind.Local).AddTicks(3850), null, 49.16m, true, 3644391359917384m, true, "Special", 4, 4.5274506f, "763 Pfeffer Ford, New Merrittborough, Norway", new Guid("1154bb55-7f7f-4d91-8347-5797ffeacb13"), "0326 Wilkinson Skyway, South Dan, Nauru", new Guid("df1ba0e6-99b8-419d-a3b8-cece7c4928bd"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("2c321b2b-e41c-403e-ac46-c9494501bed1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 15, 0, 42, 25, 755, DateTimeKind.Local).AddTicks(1689), new DateTime(2023, 11, 19, 0, 42, 25, 755, DateTimeKind.Local).AddTicks(1689), null, 35.48m, 7782593268516769m, "Standart", 1, 26.601894f, "50409 Johns Meadows, Brendenchester, Lesotho", new Guid("3a19b458-72b3-4b5b-97e6-334a56d7d557"), "0414 Bernier Trafficway, Bradtkechester, Austria", new Guid("a419df27-9358-4a02-9ab7-2f2e2344fae0"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("3038c17d-7495-4ae9-8fc8-21988902e41b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 26, 9, 37, 32, 696, DateTimeKind.Local).AddTicks(1279), new DateTime(2024, 1, 30, 9, 37, 32, 696, DateTimeKind.Local).AddTicks(1279), null, 36.46m, true, 1521230422669439m, "Standart", 3, 38.87406f, "00591 Kaden Tunnel, Kuhlmanside, United Arab Emirates", new Guid("1b1ebe07-5765-4728-8b40-ee14061347ae"), "1495 Celia Overpass, Josianneport, Sierra Leone", new Guid("c7f42761-e210-47b4-9e39-2df36dce4c96"), "Return", "CardboardBox" },
                    { new Guid("370b622c-fea9-40c2-bc1a-501c0ddda681"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 14, 22, 40, 3, 813, DateTimeKind.Local).AddTicks(4173), new DateTime(2023, 6, 17, 22, 40, 3, 813, DateTimeKind.Local).AddTicks(4173), null, 82.46m, true, 4081131839682236m, "Courier", 3, 3.634749f, "4984 Mitchell Forks, West Abbeyview, Aruba", new Guid("b1817475-7a6c-44d8-8e81-4b59b1f4923e"), "2363 Dickens Fords, West Tressietown, Estonia", new Guid("353c126e-57f5-471a-b13f-0e4fd4cef2fe"), "Registered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("387ad3e6-fc2e-47c9-a335-f5302f07e187"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 3, 21, 33, 34, 255, DateTimeKind.Local).AddTicks(4838), new DateTime(2024, 1, 10, 21, 33, 34, 255, DateTimeKind.Local).AddTicks(4838), null, 41.68m, true, 1349858970737009m, true, "Special", 1, 20.153664f, "8934 Homenick Land, West Mckenzie, Brunei Darussalam", new Guid("482632b6-5f62-4fe4-82e0-1b6f0d3ee842"), "142 Heaney Knoll, Kristofferborough, Bangladesh", new Guid("b8e5286e-6ec4-4001-89c4-e17065f9bf09"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("3a6e9494-098f-47c1-84be-f6b322e933d3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 5, 3, 24, 7, 548, DateTimeKind.Local).AddTicks(3010), new DateTime(2023, 8, 8, 3, 24, 7, 548, DateTimeKind.Local).AddTicks(3010), null, 68.88m, true, 6154990490449970m, "ParcelMachine", 1, 47.910595f, "9932 Will Track, Lake Albertoshire, Lao People's Democratic Republic", new Guid("0c66002d-25be-4864-84e7-acd6fd765b27"), "882 Elisabeth Field, Clintonside, Belize", new Guid("d40492c4-d582-4ce6-943c-a487675b7960"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("3de52e7e-3b5b-43cc-9031-fb262220dbc8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 26, 8, 29, 36, 891, DateTimeKind.Local).AddTicks(1298), new DateTime(2023, 10, 28, 8, 29, 36, 891, DateTimeKind.Local).AddTicks(1298), null, 60.10m, 5689852150687053m, true, "Courier", 5, 46.147068f, "32989 Maggio Crossing, North Nico, Jordan", new Guid("67a258f9-5c48-4651-8f32-1ee7f5b4246d"), "1744 Hauck Points, Port Kane, El Salvador", new Guid("f51931e0-68b3-4aed-8f03-7ef9a8526650"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("4021ecd4-46fb-486f-94ca-0a601984682d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 17, 8, 20, 42, 310, DateTimeKind.Local).AddTicks(3261), new DateTime(2024, 4, 26, 8, 20, 42, 310, DateTimeKind.Local).AddTicks(3261), null, 29.29m, true, 2853513037005061m, true, "ParcelMachine", 1, 37.040665f, "0823 Mosciski Stravenue, South Gianni, Netherlands", new Guid("0773e360-956e-4d39-94c5-d0906a9e4557"), "36468 Guiseppe Walks, Andersonbury, Virgin Islands, British", new Guid("ac984856-387b-48de-9d39-5cfa956d354e"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("422d5304-d13f-4ebc-923e-6c15900572d4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 17, 5, 33, 44, 954, DateTimeKind.Local).AddTicks(6875), new DateTime(2023, 8, 27, 5, 33, 44, 954, DateTimeKind.Local).AddTicks(6875), null, 54.21m, 6103413059011702m, "ParcelMachine", 2, 28.329004f, "5036 Schimmel Villages, North Fabiolaborough, Marshall Islands", new Guid("141e6ca1-3b19-4ffc-a21f-8420c3f6db52"), "06331 Quigley Square, North Annabell, Trinidad and Tobago", new Guid("67a258f9-5c48-4651-8f32-1ee7f5b4246d"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("428d1873-38b5-47b8-aae1-08d043e081f7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 21, 20, 31, 38, 823, DateTimeKind.Local).AddTicks(8092), new DateTime(2023, 7, 22, 20, 31, 38, 823, DateTimeKind.Local).AddTicks(8092), null, 28.96m, 4294319700247438m, true, "ParcelMachine", 5, 40.573524f, "813 Zemlak Field, Edwardfort, Afghanistan", new Guid("4b2a14c5-b9ad-4e45-ae16-0762e7d1e215"), "2948 Boehm Path, North Lorenfort, Republic of Korea", new Guid("bd07490e-79db-4063-b992-0fa27e7f7677"), "Sent", "PlasticBag" },
                    { new Guid("4291b080-da14-46cd-86cd-411f509d288b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 1, 0, 5, 13, 471, DateTimeKind.Local).AddTicks(2509), new DateTime(2024, 3, 4, 0, 5, 13, 471, DateTimeKind.Local).AddTicks(2509), null, 56.95m, 3779786946935056m, true, "Courier", 4, 29.900978f, "497 Swaniawski Fork, Felipemouth, Falkland Islands (Malvinas)", new Guid("3a262ff7-1654-4c72-9285-3ba10eac6509"), "252 Anderson Stream, East Gerard, Wallis and Futuna", new Guid("c6e8a5d8-6660-4e85-9ff9-1e6ec6d0c580"), "Return", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("42a60a83-08a2-4ebf-b001-bde59b8ec58e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 27, 10, 58, 13, 186, DateTimeKind.Local).AddTicks(5068), new DateTime(2023, 10, 28, 10, 58, 13, 186, DateTimeKind.Local).AddTicks(5068), null, 43.31m, true, 2446702741814795m, true, "ParcelMachine", 4, 24.512554f, "52563 Orie Gardens, Emmyville, Benin", new Guid("9ee8d8bd-022b-4718-b8f4-cc38174e988c"), "4404 Rowe Throughway, Bartolettiton, Venezuela", new Guid("8c060e9b-2ea2-4602-8535-ce147e60fcbd"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("4c0155ff-898e-4930-97d2-e84927d843cc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 10, 6, 33, 10, 214, DateTimeKind.Local).AddTicks(4828), new DateTime(2023, 9, 19, 6, 33, 10, 214, DateTimeKind.Local).AddTicks(4828), null, 75.63m, 1170995467623958m, true, "Super", 3, 10.831038f, "22302 Archibald Cove, Bernhardburgh, Germany", new Guid("42babbec-5dbe-4cc3-9f68-bb4bc7ad9491"), "9486 Quitzon Underpass, West Vicentamouth, Cameroon", new Guid("3ee0e809-4d8b-4164-a824-c5ab67903af7"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("4cd4ae29-75e7-4adf-8705-87cd439ed0c0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 16, 14, 26, 48, 772, DateTimeKind.Local).AddTicks(482), new DateTime(2024, 1, 25, 14, 26, 48, 772, DateTimeKind.Local).AddTicks(482), null, 14.63m, true, 1194702746164602m, "Super", 2, 21.307144f, "748 O'Hara Drives, Gaylordfurt, Singapore", new Guid("a419df27-9358-4a02-9ab7-2f2e2344fae0"), "03173 Douglas Cove, Eleazarland, Trinidad and Tobago", new Guid("8be01b71-4060-43ad-98a5-2c0730fd003b"), "Return", "CardboardBox" },
                    { new Guid("4ea669af-cc20-41fc-914c-19001379d394"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 12, 4, 44, 2, 304, DateTimeKind.Local).AddTicks(3969), new DateTime(2023, 12, 20, 4, 44, 2, 304, DateTimeKind.Local).AddTicks(3969), null, 32.49m, true, 4516034399431630m, "Special", 5, 16.867207f, "429 Towne Stravenue, North Elisabethbury, United Kingdom", new Guid("819538c4-628a-4b17-a719-8274b53093f3"), "16994 Rhiannon Corners, Willmsburgh, Angola", new Guid("0a8fb680-a380-4d35-85da-ff3cf9faa245"), "Return", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("55037efc-ec6f-4b3e-b0b3-79917a914247"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 22, 8, 33, 49, 885, DateTimeKind.Local).AddTicks(5580), new DateTime(2024, 1, 1, 8, 33, 49, 885, DateTimeKind.Local).AddTicks(5580), null, 92.87m, 1343587246155507m, "Standart", 3, 43.994507f, "04204 Wintheiser Pine, Shieldsfurt, Austria", new Guid("c40f9fee-6298-4137-bc78-c74409dec92f"), "54678 Julia Bypass, Reicherttown, Cambodia", new Guid("b1817475-7a6c-44d8-8e81-4b59b1f4923e"), "Sent", "CardboardBox" },
                    { new Guid("5b5f1743-da13-4098-9de8-f60c8402ef88"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 21, 5, 12, 2, 785, DateTimeKind.Local).AddTicks(7934), new DateTime(2023, 7, 31, 5, 12, 2, 785, DateTimeKind.Local).AddTicks(7934), null, 31.62m, 1635238911157528m, "ParcelMachine", 5, 9.972475f, "48512 Bogisich Lights, North Cory, Palau", new Guid("2411a1da-d71e-4e02-a40e-984ec689c7bd"), "7407 Johnson Dam, Port Nelleview, Czech Republic", new Guid("2bdbd536-e4dc-4869-9dac-f62a098ecb05"), "Return", "CardboardBox" },
                    { new Guid("65830e1d-08ea-48e1-b117-16c1078aec6d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 18, 8, 35, 3, 544, DateTimeKind.Local).AddTicks(5337), new DateTime(2023, 11, 21, 8, 35, 3, 544, DateTimeKind.Local).AddTicks(5337), null, 78.92m, 8743010450816748m, "Standart", 2, 6.6154f, "7696 Price Streets, Madilynshire, Paraguay", new Guid("70d04e87-92ed-4410-96a6-934a82c8bbcb"), "62160 Easton Ports, New Liliana, Denmark", new Guid("aec475ab-9ab8-4f55-8794-ee1ffc6f6da6"), "OnTheWay", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("6695ce78-cc8d-410b-ac2a-984fc27a8210"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 19, 1, 25, 47, 253, DateTimeKind.Local).AddTicks(9966), new DateTime(2024, 1, 27, 1, 25, 47, 253, DateTimeKind.Local).AddTicks(9966), null, 43.57m, true, 2293495509582286m, true, "Standart", 1, 4.22168f, "494 Bernadette Lock, Konopelskitown, Democratic People's Republic of Korea", new Guid("92a5d027-0cfb-43ec-84b3-d812837c5654"), "10631 Lavina Gateway, Elsaborough, Solomon Islands", new Guid("63107baa-d978-4764-b959-7e90a1de3ee0"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("680ee6c7-ed4e-4441-b0ca-49e06a2eb453"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 7, 13, 32, 28, 231, DateTimeKind.Local).AddTicks(1608), new DateTime(2023, 7, 14, 13, 32, 28, 231, DateTimeKind.Local).AddTicks(1608), null, 97.21m, 8013312468035979m, "Special", 4, 7.712268f, "93529 Stehr Drives, East Mylene, Brunei Darussalam", new Guid("5e1f9cf6-8e77-46be-92e7-b3f10da0ed86"), "9363 Ritchie Drive, West Juvenal, El Salvador", new Guid("8bfa284c-faeb-4fb6-909c-2a2ea4c8745b"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("68f8c39e-7fd6-404f-bed0-9ed392650f55"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 26, 10, 49, 13, 270, DateTimeKind.Local).AddTicks(8560), new DateTime(2024, 1, 2, 10, 49, 13, 270, DateTimeKind.Local).AddTicks(8560), null, 85.92m, true, 3980324316617312m, true, "ParcelMachine", 5, 24.595068f, "597 Jed Parks, Hoegerhaven, Western Sahara", new Guid("6f109fcf-941c-474c-810c-243f75df54d6"), "88776 Nitzsche Mountain, North Cleveborough, Zimbabwe", new Guid("1381d1cd-5c11-46c1-bc37-987b3f5ae33e"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("6ac26c49-7ff9-4485-9bc1-4262d6070cd6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 6, 19, 33, 1, 484, DateTimeKind.Local).AddTicks(4017), new DateTime(2024, 5, 13, 19, 33, 1, 484, DateTimeKind.Local).AddTicks(4017), null, 40.13m, true, 5956473707794580m, "Courier", 3, 10.299944f, "650 Rippin Trace, Smithborough, Cape Verde", new Guid("bbaf9fe2-9863-4589-964a-23c62e6bf830"), "303 Gottlieb Place, Willmouth, Antigua and Barbuda", new Guid("e36aac18-179d-420c-8aaa-edf7ff736e50"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("6db05619-61f5-4688-986a-eb99316153b6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 13, 21, 31, 32, 187, DateTimeKind.Local).AddTicks(6942), new DateTime(2023, 7, 21, 21, 31, 32, 187, DateTimeKind.Local).AddTicks(6942), null, 37.16m, true, 5432157780604921m, true, "Super", 4, 2.5272892f, "7126 Reilly Corner, Dooleyshire, Bouvet Island (Bouvetoya)", new Guid("01424fda-76cf-4203-995c-a75e43c1d1d0"), "55794 Hettinger Summit, West Marlinville, Cocos (Keeling) Islands", new Guid("141e6ca1-3b19-4ffc-a21f-8420c3f6db52"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("6e9ac9a0-4d22-46f4-a291-ff5878147a6c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 29, 23, 20, 17, 938, DateTimeKind.Local).AddTicks(3056), new DateTime(2024, 3, 6, 23, 20, 17, 938, DateTimeKind.Local).AddTicks(3056), null, 66.15m, 5510005523881782m, "Courier", 3, 41.443817f, "440 Greenholt Ramp, Sawaynberg, Latvia", new Guid("de7e4623-27a6-4a10-8c19-1f8ae8f689d2"), "0061 Marks Mills, Oranton, Finland", new Guid("6218849a-9af3-4ab0-93d1-f5fd29135491"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("6e9cd708-88b9-46f0-84bc-9bf3f7334970"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 22, 16, 4, 30, 162, DateTimeKind.Local).AddTicks(2322), new DateTime(2023, 6, 28, 16, 4, 30, 162, DateTimeKind.Local).AddTicks(2322), null, 25.08m, true, 1186443443023409m, "Standart", 5, 36.60739f, "3327 O'Keefe Knolls, Kreigerfort, Syrian Arab Republic", new Guid("487f0344-4cde-4b10-971a-1f8311cce3f5"), "1320 Evan Ville, East Kathrynton, French Guiana", new Guid("b1817475-7a6c-44d8-8e81-4b59b1f4923e"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("6fb6ad1e-21aa-44c9-9597-7a02c3602655"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 7, 21, 43, 26, 414, DateTimeKind.Local).AddTicks(3742), new DateTime(2023, 11, 16, 21, 43, 26, 414, DateTimeKind.Local).AddTicks(3742), null, 36.97m, 2355982572234268m, true, "Courier", 2, 35.99759f, "1527 Block Gateway, Lake Audrey, Andorra", new Guid("6101631f-7cf2-4393-a938-099c07dbe44b"), "90804 Cassin Divide, Port Myrl, Central African Republic", new Guid("487efc58-2d93-4b91-a4fb-1ce1d3ef038a"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("73d73975-219f-45c6-b450-e1ad3c41c00f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 16, 21, 47, 28, 111, DateTimeKind.Local).AddTicks(7311), new DateTime(2024, 1, 26, 21, 47, 28, 111, DateTimeKind.Local).AddTicks(7311), null, 88.10m, 7147744091100836m, "Super", 4, 14.805909f, "1962 McGlynn Crescent, West Hassie, Isle of Man", new Guid("3a262ff7-1654-4c72-9285-3ba10eac6509"), "721 Joel Falls, Hailieland, Singapore", new Guid("49ef4ccb-eb29-4ffa-bcfe-88759ac3f1c5"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("76cf4263-4884-4556-b23e-209578e8491a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 15, 15, 54, 38, 663, DateTimeKind.Local).AddTicks(8992), new DateTime(2023, 6, 21, 15, 54, 38, 663, DateTimeKind.Local).AddTicks(8992), null, 53.97m, 1039171507088808m, true, "Courier", 4, 41.913837f, "41047 Rory Court, Lake Traceychester, Switzerland", new Guid("8fc5f8c0-3711-4486-8ea0-48697b9ea01f"), "335 Lysanne Trail, Waylonport, Gibraltar", new Guid("4b2a14c5-b9ad-4e45-ae16-0762e7d1e215"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7ecccc7d-90ba-4613-af55-bb6c2ae34282"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 1, 12, 37, 26, 523, DateTimeKind.Local).AddTicks(3701), new DateTime(2023, 8, 5, 12, 37, 26, 523, DateTimeKind.Local).AddTicks(3701), null, 79.50m, true, 9548912544619730m, "Courier", 5, 13.744403f, "711 Stiedemann Union, Parismouth, Solomon Islands", new Guid("8e3d5153-23be-45f9-83b4-5aecbb1a4322"), "135 Christiansen Radial, South Asha, New Caledonia", new Guid("335c9d28-42e2-4d49-9686-f0cd1b972fae"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7f1661d2-b9c0-445e-9046-c8f3adde1952"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 12, 17, 13, 11, 356, DateTimeKind.Local).AddTicks(5275), new DateTime(2024, 5, 19, 17, 13, 11, 356, DateTimeKind.Local).AddTicks(5275), null, 81.25m, true, 5510070855278030m, true, "Special", 2, 44.845505f, "05812 Grant Summit, South Ana, Serbia", new Guid("23e8131d-ba45-4488-991d-941eca3fbe0a"), "056 Huel Tunnel, Littlefurt, Angola", new Guid("97e11482-d5e6-41d7-82e3-80806df9c3bc"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("826abe7b-04d1-4787-a534-737025a132fd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 11, 14, 52, 55, 925, DateTimeKind.Local).AddTicks(8779), new DateTime(2023, 8, 21, 14, 52, 55, 925, DateTimeKind.Local).AddTicks(8779), null, 74.85m, 6740789556998498m, "Courier", 3, 42.1637f, "3649 O'Hara Run, New Lavada, Mexico", new Guid("c7f42761-e210-47b4-9e39-2df36dce4c96"), "628 Kaelyn Lodge, Robynburgh, Iceland", new Guid("0773e360-956e-4d39-94c5-d0906a9e4557"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("8580db7e-3887-4241-ba09-fb2700a15b2f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 27, 15, 9, 51, 913, DateTimeKind.Local).AddTicks(1627), new DateTime(2024, 3, 30, 15, 9, 51, 913, DateTimeKind.Local).AddTicks(1627), null, 48.17m, true, 8903669527629147m, "Standart", 3, 1.964957f, "874 Verda Square, Bartolettiport, Hungary", new Guid("0b65bf95-8c8c-4e28-8317-122f0f66a78e"), "4391 Perry Turnpike, Nitzschetown, Slovakia (Slovak Republic)", new Guid("02a17a84-0a35-4164-b872-e030d586b6fe"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("8844b3ce-0a7f-450a-9f44-7a9ec95f5c70"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 16, 21, 45, 53, 744, DateTimeKind.Local).AddTicks(6936), new DateTime(2023, 7, 24, 21, 45, 53, 744, DateTimeKind.Local).AddTicks(6936), null, 68.34m, 9404724963201584m, true, "Courier", 3, 27.05694f, "41427 Rippin Rest, Nienowmouth, Oman", new Guid("75ba16eb-aa9c-4c6f-90ae-1515360055a9"), "8040 Gladys Shoals, East Margarettemouth, Northern Mariana Islands", new Guid("d57e07f1-63a6-4514-ae7a-51f83c901e2c"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("88707a15-dd23-434d-a1ca-3ea39924dd01"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 23, 6, 43, 30, 169, DateTimeKind.Local).AddTicks(7129), new DateTime(2024, 5, 30, 6, 43, 30, 169, DateTimeKind.Local).AddTicks(7129), null, 63.59m, 5298915437532510m, "Standart", 1, 42.259296f, "72285 Aliyah Cove, South Sydnie, Japan", new Guid("0d88a4e0-8366-4547-8ebe-087d4c74b34f"), "157 Christopher Loaf, West Abigaleton, Belgium", new Guid("6b5cd903-9056-4302-b3e6-b910c3a67f76"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("89244313-1e28-4cf7-84b9-76074296e073"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 30, 5, 0, 10, 583, DateTimeKind.Local).AddTicks(135), new DateTime(2023, 10, 31, 5, 0, 10, 583, DateTimeKind.Local).AddTicks(135), null, 52.79m, 2814295153895590m, true, "Super", 1, 1.3286875f, "594 Wyman Mountain, Bergstromburgh, Turkmenistan", new Guid("d40492c4-d582-4ce6-943c-a487675b7960"), "17621 Jakubowski Light, Conroybury, San Marino", new Guid("db32027d-cf9c-4544-af7d-d20c917925c7"), "Delivered", "CardboardBox" },
                    { new Guid("8a55df9d-8406-43ec-bb3c-17a330378c54"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 6, 1, 9, 48, 6, 913, DateTimeKind.Local).AddTicks(7647), new DateTime(2024, 6, 8, 9, 48, 6, 913, DateTimeKind.Local).AddTicks(7647), null, 17.08m, 8133294945640743m, true, "Special", 3, 48.575783f, "0748 Bogan Brooks, Shaniafort, Jordan", new Guid("39d27a82-05d2-4135-b53b-53748eefd4f2"), "5827 Alanna Forest, Johnsonbury, Japan", new Guid("4efd0f6e-db18-4603-b7c2-f032eb9132a9"), "OnTheWay", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("8b770522-15f6-414a-b4d9-fc0dce369671"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 21, 19, 48, 17, 857, DateTimeKind.Local).AddTicks(3199), new DateTime(2023, 6, 27, 19, 48, 17, 857, DateTimeKind.Local).AddTicks(3199), null, 46.58m, true, 1694010657864982m, "Standart", 1, 9.399871f, "3546 Walker Lakes, Rueckerfurt, Bangladesh", new Guid("1e17494c-b19d-4879-af0e-c6575db6bd37"), "15283 Maymie Forge, Finnborough, Vanuatu", new Guid("3c3a765d-c1b9-47c7-b39a-7b5dc35e1cbc"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("8c223bb9-3211-4c4f-b8a3-6ff2a861b716"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 29, 19, 47, 8, 767, DateTimeKind.Local).AddTicks(4890), new DateTime(2023, 12, 8, 19, 47, 8, 767, DateTimeKind.Local).AddTicks(4890), null, 19.40m, 5681251776261888m, "Super", 1, 0.99530995f, "8107 McClure Mission, Wardfort, Honduras", new Guid("b21ce16f-bf5c-4cfa-9fd4-9b67014eadbb"), "6197 Nienow Circles, South Frank, Wallis and Futuna", new Guid("bbe91897-98e6-4c1e-aef5-09cd3dbb35cd"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("8f5aed4b-734f-47ad-8a47-f8a18c822732"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 15, 16, 7, 51, 842, DateTimeKind.Local).AddTicks(2966), new DateTime(2023, 9, 16, 16, 7, 51, 842, DateTimeKind.Local).AddTicks(2966), null, 96.10m, true, 2665530033309992m, "Courier", 5, 30.681986f, "06282 Derrick Springs, North Carolyn, Guernsey", new Guid("719d1670-ba7d-4e9b-b4de-d7074f81aa66"), "5886 Olson Spurs, Schuppefurt, Tunisia", new Guid("8b3afef3-3bbb-4237-b8b8-1eba1df7757e"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("91413d80-b61b-408a-b098-32643a12a908"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 28, 1, 6, 40, 327, DateTimeKind.Local).AddTicks(2654), new DateTime(2023, 9, 3, 1, 6, 40, 327, DateTimeKind.Local).AddTicks(2654), null, 14.10m, 5331316753893321m, "Standart", 5, 33.152016f, "539 Kuphal Extension, West Saigeville, Niue", new Guid("8bfa284c-faeb-4fb6-909c-2a2ea4c8745b"), "1902 Chesley Shoal, Goodwinmouth, Saudi Arabia", new Guid("ac4ee7ff-56c7-4c45-ba3e-32ed6d9370f3"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("95d18579-899e-4e9a-89ec-4efc2e2c147c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 9, 7, 23, 54, 388, DateTimeKind.Local).AddTicks(7639), new DateTime(2023, 9, 10, 7, 23, 54, 388, DateTimeKind.Local).AddTicks(7639), null, 30.68m, 8315321389738124m, true, "Special", 5, 35.994083f, "57080 Jayden Turnpike, West Stephaniemouth, Sri Lanka", new Guid("a419df27-9358-4a02-9ab7-2f2e2344fae0"), "107 Abbott Manor, Port Brenna, Saudi Arabia", new Guid("f2c5c231-fa4f-4403-a17b-f986cd15543a"), "OnTheWay", "PlasticBag" },
                    { new Guid("9639e547-69c1-47c2-a53b-e8d7d1901230"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 12, 12, 37, 42, 832, DateTimeKind.Local).AddTicks(3436), new DateTime(2023, 9, 19, 12, 37, 42, 832, DateTimeKind.Local).AddTicks(3436), null, 30.44m, 4314257020367754m, true, "Special", 4, 31.505783f, "588 Lynch Courts, Port Damian, Israel", new Guid("fe7a3052-1ad9-4450-b9d5-057c6abe9c2e"), "4537 Pfeffer Knolls, Okunevaborough, Cambodia", new Guid("405a5eb1-aee0-4578-8748-2d8b5a6b0d57"), "Delivered", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("97417fda-a280-4f86-8e58-9b4713a3f1cc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 4, 20, 10, 35, 519, DateTimeKind.Local).AddTicks(9423), new DateTime(2024, 3, 14, 20, 10, 35, 519, DateTimeKind.Local).AddTicks(9423), null, 45.64m, true, 2320677300031036m, true, "Super", 4, 2.9227698f, "449 Abby Flat, East Adolfo, Switzerland", new Guid("82b99640-3f2e-425b-a088-51b3c226a192"), "247 Ricardo Unions, East Favianstad, Czech Republic", new Guid("7abaa815-d503-4740-a0a9-20d8752fc2cf"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("996cd0a5-bf85-4fe1-a928-e5c7901d3889"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 31, 6, 55, 6, 343, DateTimeKind.Local).AddTicks(451), new DateTime(2024, 4, 6, 6, 55, 6, 343, DateTimeKind.Local).AddTicks(451), null, 44.69m, 5592136030815590m, true, "Super", 5, 31.054636f, "863 Bednar Canyon, Willmsview, Romania", new Guid("40a279f6-73dd-4fa2-8b1e-05f9cd8bdcf9"), "576 McKenzie Spurs, Sunnytown, Honduras", new Guid("50b1b40f-32d2-45da-a690-b9d24fff476e"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("9a068994-6cf7-465b-8e27-78a552870067"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 10, 23, 32, 40, 903, DateTimeKind.Local).AddTicks(5496), new DateTime(2023, 7, 12, 23, 32, 40, 903, DateTimeKind.Local).AddTicks(5496), null, 31.22m, true, 8717312230869334m, "Super", 1, 25.799091f, "82717 Ofelia Centers, Margaritaview, Maldives", new Guid("08589d86-24cf-48ee-b140-eab54649e215"), "37072 Carter Fields, West Joany, Costa Rica", new Guid("2700d101-47ef-4c75-a3e1-b613514a94f0"), "OnTheWay", "CardboardBox" },
                    { new Guid("9afda8af-0ba9-4e8d-aa73-4e988edc2ee2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 13, 4, 48, 55, 801, DateTimeKind.Local).AddTicks(6746), new DateTime(2024, 2, 20, 4, 48, 55, 801, DateTimeKind.Local).AddTicks(6746), null, 77.54m, true, 7687806320512944m, "Special", 4, 9.052405f, "4987 Kuhn Hill, Port Terencefurt, Anguilla", new Guid("aec475ab-9ab8-4f55-8794-ee1ffc6f6da6"), "634 Josh Expressway, South Imelda, Cuba", new Guid("e764f5ca-90fe-4d60-aab1-e56e02a1f110"), "Registered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("9d5a604c-e5d7-4978-9dd6-1fc5624ddfff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 25, 1, 41, 53, 52, DateTimeKind.Local).AddTicks(8447), new DateTime(2024, 4, 3, 1, 41, 53, 52, DateTimeKind.Local).AddTicks(8447), null, 96.21m, 3883893619100832m, true, "Standart", 4, 32.669147f, "135 Orn Village, Joeymouth, Slovakia (Slovak Republic)", new Guid("7abaa815-d503-4740-a0a9-20d8752fc2cf"), "98544 Bartell Harbors, Port Nelson, Paraguay", new Guid("66da7f26-36d5-4406-a2e4-35363c8e43cb"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("a339fe0d-e546-4616-ac43-bbe03324ab9d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 12, 13, 50, 39, 379, DateTimeKind.Local).AddTicks(5374), new DateTime(2024, 3, 19, 13, 50, 39, 379, DateTimeKind.Local).AddTicks(5374), null, 91.87m, true, 3940819232994922m, true, "ParcelMachine", 4, 35.062435f, "9502 Richmond Isle, South Clair, Jordan", new Guid("4d006d0d-8a50-4d81-886b-176313d018fb"), "437 Neoma Forest, East Albinbury, Mayotte", new Guid("48b3cd65-be2f-4be1-a3c5-d88da44b3d73"), "Registered", "CardboardBox" },
                    { new Guid("a5919ac4-7341-43ef-93ad-0c4553586d5e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 1, 20, 32, 9, 775, DateTimeKind.Local).AddTicks(6648), new DateTime(2023, 8, 7, 20, 32, 9, 775, DateTimeKind.Local).AddTicks(6648), null, 73.40m, true, 8660153785912182m, true, "Courier", 4, 46.158195f, "666 Nikolaus Mills, Shanelport, Tunisia", new Guid("548e47d4-b851-4432-8514-fc092768db5b"), "397 Dare Summit, North Marie, Kenya", new Guid("7a52231d-ba53-47d6-8382-e5bf5f9e7e24"), "Registered", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("a716cc0e-48c7-4be9-8824-2f534a679268"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 18, 9, 20, 55, 494, DateTimeKind.Local).AddTicks(2207), new DateTime(2024, 3, 27, 9, 20, 55, 494, DateTimeKind.Local).AddTicks(2207), null, 96.73m, 6404799369148206m, true, "ParcelMachine", 3, 29.06129f, "891 Queen Turnpike, Lake Melyssa, Estonia", new Guid("21d9b3f2-945c-40a1-a0ca-7b6fcbe38a4e"), "838 Kyra Throughway, Port Alison, Tanzania", new Guid("8c30b7e6-1da3-4a5c-87ba-544b9377a290"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("a97bee95-fd1c-451e-bc33-8f0e4ff7ec31"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 29, 21, 20, 5, 201, DateTimeKind.Local).AddTicks(8036), new DateTime(2023, 10, 5, 21, 20, 5, 201, DateTimeKind.Local).AddTicks(8036), null, 23.98m, true, 2368013956838802m, true, "ParcelMachine", 1, 46.636433f, "74317 Mazie Forest, West Kendall, Nauru", new Guid("1154bb55-7f7f-4d91-8347-5797ffeacb13"), "72914 Harvey Bypass, New Jackstad, Nigeria", new Guid("f3cb510a-8243-4204-8c1f-ace56610d45f"), "OnTheWay", "PlasticBag" },
                    { new Guid("aabf7198-9f37-4d16-bc63-fa1cd701e44a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 19, 18, 39, 20, 555, DateTimeKind.Local).AddTicks(8920), new DateTime(2023, 6, 23, 18, 39, 20, 555, DateTimeKind.Local).AddTicks(8920), null, 11.75m, true, 9534834039793206m, true, "Standart", 2, 8.420138f, "140 Alexandrine Spring, Purdymouth, India", new Guid("78be92c8-3390-4d5e-aa3a-54c7301eaf2f"), "80704 Piper Valley, Herminaburgh, Algeria", new Guid("080ced29-2e70-40de-82e4-0a2d478fe53e"), "OnTheWay", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("b5345a85-a425-4a9d-87ac-308024aaa1d5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 18, 8, 27, 24, 274, DateTimeKind.Local).AddTicks(3380), new DateTime(2024, 5, 25, 8, 27, 24, 274, DateTimeKind.Local).AddTicks(3380), null, 42.33m, 4118113485218448m, "ParcelMachine", 1, 5.667388f, "725 Koch Rapids, North Alanna, Burundi", new Guid("0ec010bc-7e48-4cb9-bb93-8dd9d5b37f6d"), "16727 Walsh Summit, New Jaida, Germany", new Guid("64e0a0ed-41a2-429f-800b-6407610d5984"), "Sent", "PlasticBag" },
                    { new Guid("b7bdb9ac-52d5-46fa-ba5e-82361fc4620a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 28, 4, 32, 40, 305, DateTimeKind.Local).AddTicks(1391), new DateTime(2023, 6, 29, 4, 32, 40, 305, DateTimeKind.Local).AddTicks(1391), null, 68.60m, 6544200900621387m, "Courier", 3, 8.048762f, "38231 Predovic Route, Port Avistown, Macedonia", new Guid("548e47d4-b851-4432-8514-fc092768db5b"), "016 Kirlin Shores, Parisianborough, Qatar", new Guid("aec475ab-9ab8-4f55-8794-ee1ffc6f6da6"), "OnTheWay", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("bb554b81-56ef-4342-ac5a-e3f2b787ac54"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 4, 4, 28, 53, 590, DateTimeKind.Local).AddTicks(4862), new DateTime(2023, 12, 12, 4, 28, 53, 590, DateTimeKind.Local).AddTicks(4862), null, 57.10m, true, 3683985871171824m, "Special", 1, 8.99241f, "8291 Haleigh Lane, Kilbackstad, Central African Republic", new Guid("a2c81266-ca25-4e08-bddc-c6ccfe9435e2"), "217 Jonathon Key, Nienowchester, French Southern Territories", new Guid("4c5d0085-4956-4748-b989-09b4d927d669"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("bd3debc0-b54b-48ff-804c-71b4c3af5d74"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 3, 7, 16, 13, 937, DateTimeKind.Local).AddTicks(4196), new DateTime(2023, 6, 13, 7, 16, 13, 937, DateTimeKind.Local).AddTicks(4196), null, 56.55m, 9965252812222370m, true, "Courier", 2, 39.822357f, "335 Giles Manor, Collinsberg, Bouvet Island (Bouvetoya)", new Guid("c5513371-ea13-4b3b-ab65-8bbb471b2afc"), "505 Dillan Mills, Kathleenton, New Zealand", new Guid("f5fa9239-e966-4c8e-9eb5-32ecf277976e"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("c16ae37c-0fd1-4f88-8541-a7868552973a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 20, 22, 15, 35, 757, DateTimeKind.Local).AddTicks(8522), new DateTime(2024, 5, 27, 22, 15, 35, 757, DateTimeKind.Local).AddTicks(8522), null, 21.68m, true, 5590470991307453m, "Special", 1, 47.145954f, "515 Elza Forest, O'Konberg, Svalbard & Jan Mayen Islands", new Guid("a780acfd-e10d-4dc5-a383-1ba56a91e666"), "696 Elenora Square, Daishastad, Sao Tome and Principe", new Guid("50ac14d1-c13d-42f2-8026-301c38b1964b"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("c1ea24e5-ca7e-4a5e-bc47-cf08f203afa6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 23, 14, 35, 39, 813, DateTimeKind.Local).AddTicks(8082), new DateTime(2024, 4, 25, 14, 35, 39, 813, DateTimeKind.Local).AddTicks(8082), null, 15.91m, 8932351190209983m, "Special", 4, 43.987648f, "81513 Heathcote Summit, Leannonhaven, Madagascar", new Guid("7c2f2e0c-1d40-453b-84ea-f5f09cb10d28"), "67539 Harvey Harbors, Port Christopher, Lao People's Democratic Republic", new Guid("8fc5f8c0-3711-4486-8ea0-48697b9ea01f"), "Sent", "PlasticBag" },
                    { new Guid("c30c061f-54d8-43fd-9df4-a154c66d3434"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 19, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(760), new DateTime(2023, 11, 25, 11, 29, 9, 475, DateTimeKind.Local).AddTicks(760), null, 50.88m, 9434882356735284m, "Standart", 3, 24.871428f, "4514 Judge Plains, Lake Kayleighton, Mauritania", new Guid("34e9aed1-9d94-41dd-a50e-2e11424b25e1"), "901 Breitenberg Oval, Hoegertown, Guinea-Bissau", new Guid("d0aae9a2-8c5b-48e9-b856-e309c80cadae"), "Registered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("c4257458-cba8-42e5-aac6-dab12d7dbdfc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 20, 4, 41, 34, 683, DateTimeKind.Local).AddTicks(401), new DateTime(2023, 11, 29, 4, 41, 34, 683, DateTimeKind.Local).AddTicks(401), null, 73.55m, true, 5120215152991570m, "Special", 3, 22.883636f, "4271 Franecki Landing, Harveyville, Cape Verde", new Guid("3c3a765d-c1b9-47c7-b39a-7b5dc35e1cbc"), "150 Jast Villages, South Bonnie, Mauritania", new Guid("7c2f2e0c-1d40-453b-84ea-f5f09cb10d28"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("c4763317-ed46-4bdb-a68b-2fa54abaf67e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 4, 10, 51, 37, 323, DateTimeKind.Local).AddTicks(2963), new DateTime(2024, 3, 9, 10, 51, 37, 323, DateTimeKind.Local).AddTicks(2963), null, 89.16m, true, 8484594078617576m, true, "Special", 3, 31.924007f, "35792 Kutch Dale, Port Justineland, Congo", new Guid("3c3a765d-c1b9-47c7-b39a-7b5dc35e1cbc"), "1482 Mosciski Square, Port Heloiseview, Macao", new Guid("2b5f8a6c-d3e8-41ff-8867-cadb6cd16ea4"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("c514ffdc-e575-4ba0-98ba-4dacdbfa9502"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 7, 12, 26, 53, 599, DateTimeKind.Local).AddTicks(947), new DateTime(2024, 5, 13, 12, 26, 53, 599, DateTimeKind.Local).AddTicks(947), null, 46.20m, 9039839849942556m, "ParcelMachine", 1, 46.136066f, "18740 Wehner Wall, South Laurettaport, Slovakia (Slovak Republic)", new Guid("718a03a0-2841-450f-a417-5345b18c81ab"), "250 Daugherty Hills, West Morris, Guinea-Bissau", new Guid("99d3bf2d-5ff0-41e8-b115-9bf94eab6881"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("c55f71d4-7ec3-45d3-979c-4003611e895a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 17, 23, 0, 19, 276, DateTimeKind.Local).AddTicks(5628), new DateTime(2024, 3, 23, 23, 0, 19, 276, DateTimeKind.Local).AddTicks(5628), null, 56.61m, true, 3778208564903088m, "ParcelMachine", 3, 36.14271f, "86565 Lakin Knoll, North Kassandra, Guam", new Guid("831f8f9d-e78d-4f72-8b48-1c32c42fda1b"), "62561 Witting Square, Torrancechester, United States Minor Outlying Islands", new Guid("4e8c89c0-a2fb-42d3-8d7a-11fe5d3b6d75"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("ccf0f4cd-2051-41bc-8364-d4c6160dfadb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 25, 0, 59, 5, 476, DateTimeKind.Local).AddTicks(9853), new DateTime(2024, 5, 1, 0, 59, 5, 476, DateTimeKind.Local).AddTicks(9853), null, 77.88m, 7240064014476649m, true, "Standart", 1, 12.120036f, "6323 Stewart Parkway, Jovanview, Canada", new Guid("64e0a0ed-41a2-429f-800b-6407610d5984"), "998 Antoinette Walks, Brendonburgh, Northern Mariana Islands", new Guid("1cdde210-cf9c-4b69-a64c-3995a2267739"), "OnTheWay", "CardboardBox" },
                    { new Guid("cfb70f27-db06-4296-9b3f-8692718b13f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 24, 1, 39, 45, 196, DateTimeKind.Local).AddTicks(258), new DateTime(2024, 6, 2, 1, 39, 45, 196, DateTimeKind.Local).AddTicks(258), null, 19.76m, 6565352515660728m, true, "Special", 4, 5.260624f, "217 Douglas Port, Christophaven, Tonga", new Guid("74ef9233-8d34-4883-8938-b78b6c147246"), "5033 Littel Springs, Port Rosamond, Togo", new Guid("72a42c8b-ed7c-4e7a-81c6-313cac897b20"), "Delivered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("d00e71de-dddf-48c6-8695-6af45c2696a5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 31, 2, 7, 54, 916, DateTimeKind.Local).AddTicks(4467), new DateTime(2024, 4, 8, 2, 7, 54, 916, DateTimeKind.Local).AddTicks(4467), null, 71.94m, 5936403992673356m, "ParcelMachine", 1, 8.31029f, "7171 Velda Hollow, Port Sammie, Chad", new Guid("1154bb55-7f7f-4d91-8347-5797ffeacb13"), "5393 Jefferey Vista, Stammfurt, Saint Vincent and the Grenadines", new Guid("8f876cca-154f-4381-adab-41c9e894d046"), "Sent", "PlasticBag" },
                    { new Guid("d114a127-55b5-412a-ad9d-abef1ce43cc9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 26, 5, 6, 29, 865, DateTimeKind.Local).AddTicks(5041), new DateTime(2023, 7, 28, 5, 6, 29, 865, DateTimeKind.Local).AddTicks(5041), null, 33.27m, 6627839035219982m, "Standart", 2, 23.375834f, "137 Vivian Court, East Paige, Thailand", new Guid("c3cc5785-6364-48fa-bb83-e7ac33fc672b"), "29152 Kilback Drive, Sporerside, Montserrat", new Guid("3a262ff7-1654-4c72-9285-3ba10eac6509"), "Return", "PlasticBag" },
                    { new Guid("d8aef4a5-911b-482b-9ab7-94dc7706a114"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 22, 12, 12, 38, 287, DateTimeKind.Local).AddTicks(3642), new DateTime(2024, 3, 1, 12, 12, 38, 287, DateTimeKind.Local).AddTicks(3642), null, 10.34m, 9714439924430698m, "Standart", 3, 42.479244f, "0295 Sauer Drives, Javontefurt, Suriname", new Guid("66da7f26-36d5-4406-a2e4-35363c8e43cb"), "65911 Jorge Place, Rauchester, Libyan Arab Jamahiriya", new Guid("4efd0f6e-db18-4603-b7c2-f032eb9132a9"), "Delivered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("d9294516-6af8-459e-84b5-edbb8047c32c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 26, 12, 45, 28, 943, DateTimeKind.Local).AddTicks(3325), new DateTime(2023, 12, 27, 12, 45, 28, 943, DateTimeKind.Local).AddTicks(3325), null, 42.95m, true, 5774129118216847m, "Super", 3, 7.402432f, "86667 Schmidt Squares, Avisfort, Mayotte", new Guid("9e39f449-ecbf-4238-8ca8-47309c134789"), "65365 Dicki Divide, Altenwerthbury, Timor-Leste", new Guid("1bab23ea-659b-4531-ad24-fdfd8984675d"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("dbbb490a-833f-4f7d-b4e1-169b921210ae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 11, 1, 17, 27, 815, DateTimeKind.Local).AddTicks(8485), new DateTime(2023, 9, 19, 1, 17, 27, 815, DateTimeKind.Local).AddTicks(8485), null, 56.96m, 4937664422541652m, true, "Special", 3, 8.694029f, "74955 Kacey Cove, Waldoborough, Guyana", new Guid("cf611bf3-21fb-4ed7-a138-00c7afdda9ba"), "31035 Batz Knoll, Shieldsfort, Thailand", new Guid("3b3e9016-3025-48e3-93b2-fa474015c0f7"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("dbe4824a-e519-4d21-ba0d-8fa69caadccd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 24, 14, 42, 24, 126, DateTimeKind.Local).AddTicks(3272), new DateTime(2024, 2, 3, 14, 42, 24, 126, DateTimeKind.Local).AddTicks(3272), null, 83.35m, true, 5143891472212530m, "Special", 3, 11.68708f, "634 Oleta Dam, West Estamouth, Heard Island and McDonald Islands", new Guid("59a9232d-40d9-422d-8a1a-fe022e85093a"), "26213 Stamm Radial, Ebertland, Bahamas", new Guid("f7dacdb6-cd5e-4c55-a2df-710f582d75f2"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("e1f9439d-c45d-4958-aa83-d4965b9c5899"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 18, 13, 35, 46, 206, DateTimeKind.Local).AddTicks(4321), new DateTime(2023, 11, 27, 13, 35, 46, 206, DateTimeKind.Local).AddTicks(4321), null, 95.43m, true, 6749260922139543m, true, "Standart", 2, 7.254546f, "736 Marcella Ranch, Jotown, France", new Guid("92d6cbc1-d409-403c-b274-517d31726ae9"), "90056 Micheal Mill, South Stephan, Holy See (Vatican City State)", new Guid("db32027d-cf9c-4544-af7d-d20c917925c7"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("e369afaf-35b6-460d-ac43-e7ec5fad43dc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 6, 19, 5, 4, 512, DateTimeKind.Local).AddTicks(2091), new DateTime(2024, 2, 14, 19, 5, 4, 512, DateTimeKind.Local).AddTicks(2091), null, 95.82m, 6890687414235646m, "Super", 2, 16.829613f, "397 Kirlin Rest, Bartellborough, Cuba", new Guid("a419df27-9358-4a02-9ab7-2f2e2344fae0"), "1676 Hahn Roads, Kreigerside, Burkina Faso", new Guid("c0ff772c-b38f-4860-9c1e-4c49d424f9a5"), "Delivered", "CardboardBox" },
                    { new Guid("e5ba3aa4-1387-4d65-9382-d34048f9300d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 2, 8, 50, 55, 450, DateTimeKind.Local).AddTicks(7036), new DateTime(2023, 9, 9, 8, 50, 55, 450, DateTimeKind.Local).AddTicks(7036), null, 83.56m, 5167999294825193m, "Courier", 4, 20.477869f, "19446 Madonna Meadow, Lake Mohammadborough, Chile", new Guid("7e4a74cd-b47b-47e6-ab98-22ed32bd8e27"), "6638 Ressie Avenue, West Sofiaton, United Arab Emirates", new Guid("dc2b5eaa-01f8-425c-874d-15e523189cc1"), "Return", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("e5c2e122-400d-492a-8b40-e7f1b3f835b3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 29, 13, 31, 37, 308, DateTimeKind.Local).AddTicks(2431), new DateTime(2024, 3, 31, 13, 31, 37, 308, DateTimeKind.Local).AddTicks(2431), null, 63.43m, 8669022840945111m, true, "Special", 3, 14.752342f, "919 Collier Inlet, Port Myles, Chad", new Guid("353c126e-57f5-471a-b13f-0e4fd4cef2fe"), "3690 Kira Fort, West Jeffrey, Guinea-Bissau", new Guid("1a21f215-231c-4e09-b7c2-4e3163978286"), "Sent", "CardboardBox" },
                    { new Guid("eac8349d-adcb-44c9-89c8-ff1f1faa8585"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 1, 9, 23, 33, 697, DateTimeKind.Local).AddTicks(3915), new DateTime(2023, 12, 9, 9, 23, 33, 697, DateTimeKind.Local).AddTicks(3915), null, 71.96m, 3089209173671962m, true, "Special", 3, 28.142107f, "1129 Blanda Skyway, West Mariela, Barbados", new Guid("ac984856-387b-48de-9d39-5cfa956d354e"), "51260 Kunde Overpass, East Cecilia, Iraq", new Guid("f4c8c27a-6b37-469c-9492-061adc476725"), "OnTheWay", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("f24e951f-9dfb-4ba8-89db-8625c26761d7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 6, 2, 4, 30, 24, 629, DateTimeKind.Local).AddTicks(4353), new DateTime(2024, 6, 8, 4, 30, 24, 629, DateTimeKind.Local).AddTicks(4353), null, 81.76m, true, 1771933875823760m, true, "Courier", 1, 1.7981211f, "557 Zetta Radial, Lake Cadeville, Japan", new Guid("5d1e2a88-0f0a-4b6e-a524-e279224a1944"), "6761 Reanna Mountain, Reidfurt, Cocos (Keeling) Islands", new Guid("82f7ffb4-bdb1-40a8-8d2d-67f1c2f5bf91"), "Return", "PlasticBag" },
                    { new Guid("f6b0625f-4e7d-472e-8921-9bf5e1cc411d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 6, 23, 51, 25, 970, DateTimeKind.Local).AddTicks(8633), new DateTime(2023, 7, 11, 23, 51, 25, 970, DateTimeKind.Local).AddTicks(8633), null, 93.35m, true, 6918091209122069m, true, "Super", 4, 5.0868826f, "86190 Rogahn Cove, Krajcikfurt, Kazakhstan", new Guid("4b2a14c5-b9ad-4e45-ae16-0762e7d1e215"), "9890 Brisa Way, Lake Wilfredo, Ghana", new Guid("f2c5c231-fa4f-4403-a17b-f986cd15543a"), "Registered", "CardboardBox" },
                    { new Guid("fb89fd9a-c46d-4dac-9099-22057c0b4860"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 26, 22, 55, 22, 171, DateTimeKind.Local).AddTicks(9860), new DateTime(2023, 9, 2, 22, 55, 22, 171, DateTimeKind.Local).AddTicks(9860), null, 17.61m, true, 1098073209889795m, true, "Special", 5, 49.6328f, "592 Reggie Lakes, Grimesberg, Venezuela", new Guid("f2c5c231-fa4f-4403-a17b-f986cd15543a"), "793 Oswald Underpass, Euniceton, Turks and Caicos Islands", new Guid("f3cb510a-8243-4204-8c1f-ace56610d45f"), "Delivered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("fbcfe5c7-1ff3-4f08-b936-06f2d2b55f5e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 27, 6, 18, 46, 155, DateTimeKind.Local).AddTicks(7308), new DateTime(2023, 8, 31, 6, 18, 46, 155, DateTimeKind.Local).AddTicks(7308), null, 58.86m, 7443046706552464m, true, "Courier", 2, 1.1523346f, "344 Joesph Prairie, Wilmermouth, Netherlands Antilles", new Guid("b1817475-7a6c-44d8-8e81-4b59b1f4923e"), "55820 Rath Corners, Abernathyton, Central African Republic", new Guid("b40d8226-58de-4e86-811d-0e6b38686d57"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("fbd3cf86-3147-4f9c-8c34-7b3c41255f4c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 8, 15, 55, 20, 579, DateTimeKind.Local).AddTicks(9085), new DateTime(2023, 10, 17, 15, 55, 20, 579, DateTimeKind.Local).AddTicks(9085), null, 49.36m, 2061476890086894m, "Standart", 1, 38.91925f, "5956 Taryn Roads, Juanaburgh, Turkey", new Guid("0877dbd6-c025-49ef-b189-53b217500382"), "19206 Lou Estate, Claudshire, Tuvalu", new Guid("ddf2bc3e-21a3-4bd8-8ebc-4afb8cb49df0"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("0032b51e-bdb2-4f88-bfe5-27af20abb40b"), "771", "6214698105596593", null, null, new Guid("6101631f-7cf2-4393-a938-099c07dbe44b"), "01/18" },
                    { new Guid("00362486-0e36-4f53-a74b-5849ee59c2c9"), "499", "1297309640084637", null, null, new Guid("a2c81266-ca25-4e08-bddc-c6ccfe9435e2"), "04/05" },
                    { new Guid("0114ce56-d15c-4c3d-b988-90a12aad87a3"), "429", "9743753926426032", null, null, new Guid("1937fdf7-97b0-4102-95c9-2163eb910112"), "04/26" },
                    { new Guid("015934af-c349-4580-a853-c418010c4c41"), "723", "2852934752616913", null, null, new Guid("b5cca55a-d81f-47be-b0b4-50d07e79ce69"), "01/07" },
                    { new Guid("015ecf6b-86d8-4897-8080-340aec552a7f"), "289", "7616764268383912", null, null, new Guid("c7f42761-e210-47b4-9e39-2df36dce4c96"), "05/05" },
                    { new Guid("01c60aa9-9958-43b7-8aca-0b0bfe05f357"), "531", "8875784048876023", null, null, new Guid("c88c725e-8cbf-416d-a4bf-153a024ea6c9"), "12/23" },
                    { new Guid("02208bd4-0621-419c-b4a2-e1bad1de4455"), "418", "7249454019356801", null, null, new Guid("6ef84803-7ff7-46d1-b1b3-ebda82e158b3"), "09/09" },
                    { new Guid("026fe96a-70d6-4cce-b80b-8b4e2207d933"), "679", "9755162419088885", null, null, new Guid("9ec54876-333f-4825-9959-c839395cb66e"), "07/06" },
                    { new Guid("033121dd-416c-4866-97a3-500a101afe0d"), "651", "3681245457908899", null, null, new Guid("2700d101-47ef-4c75-a3e1-b613514a94f0"), "08/16" },
                    { new Guid("0340e128-9eef-474f-9d17-400f1ae57248"), "928", "7846121545853720", null, null, new Guid("8fc5f8c0-3711-4486-8ea0-48697b9ea01f"), "06/01" },
                    { new Guid("03670ecd-e37d-4ea7-b003-cfd0e20ac1cd"), "016", "2473981063555188", null, null, new Guid("548e47d4-b851-4432-8514-fc092768db5b"), "01/11" },
                    { new Guid("0378d9c2-f329-455a-af30-9a206c9aa04b"), "021", "3319918065589465", null, null, new Guid("496d8ed2-fc6d-49e6-b902-8a1d0b266928"), "03/20" },
                    { new Guid("03a19c19-f4c6-4d6b-ba55-4db857a72070"), "157", "5326333477362153", null, null, new Guid("530579fa-33a7-4827-a21f-b9cacab42c7d"), "05/15" },
                    { new Guid("0400bcab-427e-4a6b-8912-6138584a6371"), "591", "7922042238183756", null, null, new Guid("353c126e-57f5-471a-b13f-0e4fd4cef2fe"), "07/19" },
                    { new Guid("040908a1-53c9-4dce-8597-f6573a9bbe15"), "019", "5422143571537042", null, null, new Guid("8867eb2c-20d1-43a8-8081-18744798ef5a"), "01/28" },
                    { new Guid("04638a22-f0a3-4d57-a9de-73f49cc2c4ee"), "875", "7252588241916162", null, null, new Guid("72a42c8b-ed7c-4e7a-81c6-313cac897b20"), "12/13" },
                    { new Guid("047cc46e-8235-4ab8-b908-71a0038d00ef"), "877", "6119484951949432", null, null, new Guid("f51931e0-68b3-4aed-8f03-7ef9a8526650"), "02/02" },
                    { new Guid("048dc8de-71eb-42a2-8c6f-457ecdc6f3ab"), "596", "9162968414356989", null, null, new Guid("32feb777-af06-4813-9108-9d7acfd0bd04"), "02/19" },
                    { new Guid("0507ccef-13d3-49ed-b9fa-66511757e31a"), "511", "6763597675654357", null, null, new Guid("819538c4-628a-4b17-a719-8274b53093f3"), "04/07" },
                    { new Guid("0599da84-6ffa-4a25-9009-f3eeb4665ae6"), "437", "7460863225625929", null, null, new Guid("35275876-97ec-44a4-8503-f21c815c9a45"), "04/23" },
                    { new Guid("059d48d4-075b-4412-8bea-4996561c7ddb"), "033", "1701705580197323", null, null, new Guid("2c87eaa4-8e07-41f4-bad0-935d07541e78"), "01/03" },
                    { new Guid("06026f44-c6bc-4340-a6c5-a78455122053"), "344", "1188924114412129", null, null, new Guid("8e3d5153-23be-45f9-83b4-5aecbb1a4322"), "05/10" },
                    { new Guid("061c8feb-d8b5-4b4a-b91d-6e5cd4d749d4"), "321", "6266553075421986", null, null, new Guid("97e11482-d5e6-41d7-82e3-80806df9c3bc"), "04/19" },
                    { new Guid("06beaadc-3f12-4433-8b5f-cf0f383874ed"), "092", "4631624647845053", null, null, new Guid("7c2f2e0c-1d40-453b-84ea-f5f09cb10d28"), "02/19" },
                    { new Guid("06fcebe9-578f-4747-a91f-b2575a1fed44"), "198", "8827574837047154", null, null, new Guid("3ee0e809-4d8b-4164-a824-c5ab67903af7"), "11/04" },
                    { new Guid("07439185-3115-4490-a2a8-beccf4ee8f11"), "437", "5052287540276404", null, null, new Guid("35275876-97ec-44a4-8503-f21c815c9a45"), "03/28" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("07b61058-f48a-4e65-a5f0-4be5c39cce61"), "126", "5579308691928109", null, null, new Guid("f4c8c27a-6b37-469c-9492-061adc476725"), "10/26" },
                    { new Guid("07dd85f8-ac83-461d-ba58-5ea856d5dc7f"), "055", "7079975434588042", null, null, new Guid("dc52bf7b-d952-45c3-8bf0-44dadbfbb09e"), "04/21" },
                    { new Guid("08bb300f-b334-4c76-9247-81aebfb3383e"), "934", "1133262102666723", null, null, new Guid("de7e4623-27a6-4a10-8c19-1f8ae8f689d2"), "01/02" },
                    { new Guid("08e3c816-12c8-4315-b2dd-2e3834c6dc82"), "293", "3772539908940002", null, null, new Guid("8be01b71-4060-43ad-98a5-2c0730fd003b"), "04/17" },
                    { new Guid("08f6fa29-9e9c-489d-80d8-5772d2df93aa"), "581", "9683168688758701", null, null, new Guid("50b1b40f-32d2-45da-a690-b9d24fff476e"), "12/19" },
                    { new Guid("091507ee-a749-4c6c-a0ee-f38d529e7324"), "110", "4480627876036732", null, null, new Guid("42babbec-5dbe-4cc3-9f68-bb4bc7ad9491"), "11/26" },
                    { new Guid("09479050-3c8c-4b3d-bd24-47d8df0eca89"), "129", "5246189132769106", null, null, new Guid("48f4af12-c8b0-4444-98ca-81df5d349e01"), "01/11" },
                    { new Guid("095b9a45-f1fe-401a-b327-d691ecadca7b"), "142", "3887651500572456", null, null, new Guid("affd1717-742a-4014-8e72-3420c7496c1e"), "03/09" },
                    { new Guid("0968d5f1-f2aa-465b-87b5-1a67087722bf"), "592", "7942629734676853", null, null, new Guid("097cb7d3-d333-48aa-b8ee-cacd11ee91fa"), "09/06" },
                    { new Guid("098d5383-9b6c-4ad4-9e16-84d0f820cee5"), "159", "3671293848921834", null, null, new Guid("6218849a-9af3-4ab0-93d1-f5fd29135491"), "04/26" },
                    { new Guid("09e890a5-86a0-4abd-bf5e-1f66163d4807"), "084", "6208633900940742", null, null, new Guid("0877dbd6-c025-49ef-b189-53b217500382"), "10/07" },
                    { new Guid("09fa8bcc-6dab-49eb-b2e4-3eec809b6f48"), "913", "9536774802979442", null, null, new Guid("8b3afef3-3bbb-4237-b8b8-1eba1df7757e"), "10/16" },
                    { new Guid("0a268614-239d-4c85-99b6-adf0ea651b68"), "020", "8512012415703515", null, null, new Guid("72a42c8b-ed7c-4e7a-81c6-313cac897b20"), "07/10" },
                    { new Guid("0a7afd53-0005-4338-934a-34f901d41eb6"), "139", "7749223980511193", null, null, new Guid("353c126e-57f5-471a-b13f-0e4fd4cef2fe"), "12/09" },
                    { new Guid("0a8277ba-bf8d-4fc0-8778-4360a78e7d10"), "724", "2703004875951073", null, null, new Guid("99d3bf2d-5ff0-41e8-b115-9bf94eab6881"), "06/07" },
                    { new Guid("0a8f3cd4-0538-4079-922e-7d3921555ef5"), "939", "6767308046677427", null, null, new Guid("9e39f449-ecbf-4238-8ca8-47309c134789"), "11/23" },
                    { new Guid("0aaf7a1e-df1c-498a-a84e-7b1250430e70"), "890", "9239079539537646", null, null, new Guid("22edc826-6747-4099-aca5-578199353ac6"), "12/05" },
                    { new Guid("0ad74696-9372-4586-bab0-d603e2a09a5a"), "241", "4525896659584010", null, null, new Guid("3ff3d88e-b078-4f3a-8312-8447eeb772e2"), "11/15" },
                    { new Guid("0ae310a9-b2ca-4624-8ac9-b8430ab774ce"), "169", "1600923728465155", null, null, new Guid("4efd0f6e-db18-4603-b7c2-f032eb9132a9"), "12/18" },
                    { new Guid("0af5cb28-190b-4cdc-bfd2-d1e9afd0077e"), "592", "2733461015865015", null, null, new Guid("42babbec-5dbe-4cc3-9f68-bb4bc7ad9491"), "07/14" },
                    { new Guid("0b1c3ab1-3fdb-402d-bdc0-f513d16031de"), "611", "1873329767813502", null, null, new Guid("67a258f9-5c48-4651-8f32-1ee7f5b4246d"), "10/18" },
                    { new Guid("0b2d180c-d798-4067-b746-f40bf6912faf"), "580", "1238978115614578", null, null, new Guid("a419df27-9358-4a02-9ab7-2f2e2344fae0"), "07/03" },
                    { new Guid("0be757f6-8c87-44cc-97cb-01a34e97b0b6"), "461", "5242680723309248", null, null, new Guid("92a5d027-0cfb-43ec-84b3-d812837c5654"), "12/12" },
                    { new Guid("0c5646d4-480f-41fb-8670-c46e61ee18fa"), "168", "8193486179697437", null, null, new Guid("fcf05f51-7f3a-4331-a0f5-6204db62e7ba"), "08/25" },
                    { new Guid("0c65a33a-7ab3-4fb0-8772-3c96af56aba8"), "227", "6896955214070229", null, null, new Guid("ddf2bc3e-21a3-4bd8-8ebc-4afb8cb49df0"), "01/21" },
                    { new Guid("0ca41430-a0a6-4348-801f-cb1fd1209ab0"), "234", "3715509706036529", null, null, new Guid("46843658-5438-46a9-b26a-f6c2fcfd1883"), "12/28" },
                    { new Guid("0cfc6106-5a6a-40c9-a010-b9caf1991529"), "584", "2020300804819938", null, null, new Guid("cf3285c8-97d7-426d-87f3-e0854194e226"), "05/02" },
                    { new Guid("0d02eeb8-fc80-4156-a7a9-3481cce77f11"), "952", "7119867366067296", null, null, new Guid("aeae0f68-579f-46b8-bee2-c797ee09ee5e"), "10/23" },
                    { new Guid("0de6dbf5-cdf3-462d-858e-a8d78d2c673c"), "854", "7060124089993321", null, null, new Guid("c7c0cd55-07d8-41cc-9d2b-4bd04cb7edb3"), "07/12" },
                    { new Guid("0dfa4329-9d29-4c91-9ebe-bb481b5d6661"), "725", "3507000736248638", null, null, new Guid("c6e8a5d8-6660-4e85-9ff9-1e6ec6d0c580"), "01/23" },
                    { new Guid("1017cd5a-1712-404c-9dcd-e2762239155e"), "643", "3106306522790200", null, null, new Guid("5d203345-c58f-4236-9e46-c9ba7a8529a5"), "05/19" },
                    { new Guid("1112bf36-ee70-4dca-86a8-84eb64974426"), "117", "2880275348446541", null, null, new Guid("59a9232d-40d9-422d-8a1a-fe022e85093a"), "05/10" },
                    { new Guid("1157c3d8-fd80-466a-98cd-2a5afe9db859"), "406", "5789997970058349", null, null, new Guid("8f876cca-154f-4381-adab-41c9e894d046"), "11/26" },
                    { new Guid("118fa5ec-00dd-42f5-97e8-97ef4df9f07f"), "147", "7604717039847144", null, null, new Guid("0e6930e6-cf0a-4195-8d74-a9cc0dfb30b6"), "01/06" },
                    { new Guid("1193f04a-1f36-4d9a-8978-f6b5f6e9e652"), "335", "9986247074610241", null, null, new Guid("815c5bf5-7253-492e-81c8-82e2d6860602"), "08/28" },
                    { new Guid("119f18e0-a813-496e-aee3-86fb7eac386a"), "221", "1708129829066669", null, null, new Guid("087fb413-124f-47b1-b54e-4bdedf2edf63"), "12/12" },
                    { new Guid("11a53e75-90dc-48b2-8a6d-6a789b0a9247"), "181", "4242735551464539", null, null, new Guid("7e4a74cd-b47b-47e6-ab98-22ed32bd8e27"), "01/09" },
                    { new Guid("12189e9b-4c69-478d-9f40-db1edf72bd65"), "282", "2246514630500321", null, null, new Guid("e41a0e5f-468e-496b-8fe7-b8f4b2a0f962"), "10/23" },
                    { new Guid("122045a1-853f-470e-93f6-45cce722f761"), "557", "1199088608402224", null, null, new Guid("8c18ec85-46f2-44b0-bd0b-56adb1bf7743"), "03/13" },
                    { new Guid("125e0b6a-86f1-494f-a0c3-66d6b845b85a"), "000", "4414717869356492", null, null, new Guid("ac5a7dc0-9da2-4c23-9acc-ec9828404cd5"), "06/11" },
                    { new Guid("12e20622-4180-4a1d-81d2-c4c1af92fa21"), "403", "9735349637313824", null, null, new Guid("9ee8d8bd-022b-4718-b8f4-cc38174e988c"), "02/21" },
                    { new Guid("12f69573-fb5a-472a-820e-4ce9ef3599ed"), "989", "9730248029735451", null, null, new Guid("1154bb55-7f7f-4d91-8347-5797ffeacb13"), "09/22" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("1306a950-df8a-4533-9982-74fd7f30a100"), "502", "1582964477813731", null, null, new Guid("ac984856-387b-48de-9d39-5cfa956d354e"), "12/24" },
                    { new Guid("13187ee2-d0a0-4ecb-871f-b4cc887b00c7"), "680", "8951517679777218", null, null, new Guid("0d230077-5e9b-42d8-a83a-650a22378849"), "06/03" },
                    { new Guid("13871b87-cf1e-465e-8853-af65c37a2c47"), "435", "3561196018035881", null, null, new Guid("32feb777-af06-4813-9108-9d7acfd0bd04"), "12/07" },
                    { new Guid("13a9ed57-7a0e-40f2-90d5-6c6448660f54"), "556", "2184908811339858", null, null, new Guid("394e6c37-a398-4cf7-983d-8fb216e6c46f"), "04/03" },
                    { new Guid("1440425a-5ff5-4dc7-985b-c215bd15da90"), "911", "8408564635460670", null, null, new Guid("adbbd240-641f-475b-b705-5e35298ef012"), "03/04" },
                    { new Guid("144f27a7-5f2e-477d-b5fd-9b94f0550665"), "877", "1397367085302126", null, null, new Guid("7de3e658-53a0-464d-a4aa-b7bf40828f5d"), "07/24" },
                    { new Guid("153ec666-c364-4e63-8f5d-ab22437e230d"), "862", "9874647232028763", null, null, new Guid("8ea935b6-2c30-4bef-803c-9f382789979b"), "06/21" },
                    { new Guid("15dba1cc-ba1f-4447-9e49-c5f3251f91a4"), "466", "5878869552467297", null, null, new Guid("76c44275-2d3e-43e9-b34e-c05f912213b8"), "12/18" },
                    { new Guid("161a896e-a560-4911-b3de-1b83134b4f3f"), "823", "1712560103500528", null, null, new Guid("3c3a765d-c1b9-47c7-b39a-7b5dc35e1cbc"), "07/23" },
                    { new Guid("165f3ed2-1503-47a7-834b-27cb24e14e3c"), "308", "7519857231363473", null, null, new Guid("70d04e87-92ed-4410-96a6-934a82c8bbcb"), "09/09" },
                    { new Guid("168a069c-7d80-44ba-9519-54a08e3caa11"), "402", "1800221762304473", null, null, new Guid("d0aae9a2-8c5b-48e9-b856-e309c80cadae"), "11/23" },
                    { new Guid("1690ac13-323e-4d76-b05d-08b723802956"), "137", "3295982539962130", null, null, new Guid("a780acfd-e10d-4dc5-a383-1ba56a91e666"), "11/13" },
                    { new Guid("1796cdee-e65a-4eb8-8145-0f9cf9423061"), "369", "4053951182131482", null, null, new Guid("718a03a0-2841-450f-a417-5345b18c81ab"), "06/26" },
                    { new Guid("17b1f853-0450-4585-82e8-dbbd9e109e1f"), "474", "4126006896270470", null, null, new Guid("5aff4312-b9a9-4958-b14a-305be3aa9f4b"), "04/16" },
                    { new Guid("18064622-207a-4808-a890-b401b53fdf9d"), "984", "5485029668105327", null, null, new Guid("4a9e17b4-cb0f-4c82-80d2-e1d56fe06f0a"), "07/14" },
                    { new Guid("18d13c5c-67dc-4384-9d94-ecc531d56033"), "934", "3143756445809838", null, null, new Guid("07e77ffa-7983-4cb3-bfa5-a4b8ed39f91f"), "08/11" },
                    { new Guid("199e7149-9233-42de-a0b3-4064ae09b176"), "416", "2831595203208705", null, null, new Guid("39d27a82-05d2-4135-b53b-53748eefd4f2"), "11/01" },
                    { new Guid("1a8f3a87-85ab-4879-bd04-40890d378f1e"), "052", "9289477013676889", null, null, new Guid("3712e35b-2da9-4c76-ad88-28828e776a5c"), "10/22" },
                    { new Guid("1a9bc3b7-3729-4c80-a468-c56253597a63"), "813", "1078125784036078", null, null, new Guid("b21ce16f-bf5c-4cfa-9fd4-9b67014eadbb"), "11/25" },
                    { new Guid("1a9f0e13-7bf1-47fc-b859-e01e6e1c98b5"), "075", "6011004891883106", null, null, new Guid("5e1f9cf6-8e77-46be-92e7-b3f10da0ed86"), "10/18" },
                    { new Guid("1b0e7c3a-c5ce-47f5-8c32-71f0113f4031"), "070", "4200125953224745", null, null, new Guid("c7f42761-e210-47b4-9e39-2df36dce4c96"), "06/27" },
                    { new Guid("1bb5604e-dc1a-41ed-87f9-cb0883065461"), "596", "4952448758527250", null, null, new Guid("0e6930e6-cf0a-4195-8d74-a9cc0dfb30b6"), "04/14" },
                    { new Guid("1be2bda6-03a5-4291-86b2-310a6dd4ac17"), "193", "4345004820505764", null, null, new Guid("394e6c37-a398-4cf7-983d-8fb216e6c46f"), "05/03" },
                    { new Guid("1c7561c3-6261-4758-9c64-2752ee3d3da4"), "410", "6393104760728679", null, null, new Guid("8dca8632-b27c-44ad-bd6c-0d7679a4f075"), "02/21" },
                    { new Guid("1c8c1b26-3bf1-4fc4-96f5-a7c771d435a5"), "213", "7558153634152757", null, null, new Guid("2e3a99a4-4308-410d-b67e-4763bbd6b9c8"), "12/17" },
                    { new Guid("1d1a9d8b-a392-4c58-81e7-06c066d3669e"), "834", "9862772207045010", null, null, new Guid("4b45c810-f446-449d-8b0e-4a2ebbbf7104"), "01/18" },
                    { new Guid("1e0639f4-5cd8-49ad-990c-a907fd45f724"), "758", "9319111916860948", null, null, new Guid("99d4724f-46db-42d2-a62b-3d8fa528e130"), "03/16" },
                    { new Guid("1e6168f3-ba7a-4a0c-896e-2491af9935d0"), "594", "4861064172734877", null, null, new Guid("bbe91897-98e6-4c1e-aef5-09cd3dbb35cd"), "10/21" },
                    { new Guid("1ec9cc3b-dead-46f0-ba5f-e975bea3c89c"), "041", "9426424977497571", null, null, new Guid("8fc5f8c0-3711-4486-8ea0-48697b9ea01f"), "01/15" },
                    { new Guid("1eca8a30-e447-4c7f-8c11-fab6ea016261"), "825", "2699750600256465", null, null, new Guid("a59d873d-ae08-427c-b25e-29c55895239f"), "05/13" },
                    { new Guid("1eee5ef9-2077-4886-a22f-282443b59a20"), "677", "2756040217688773", null, null, new Guid("34e9aed1-9d94-41dd-a50e-2e11424b25e1"), "03/02" },
                    { new Guid("1f0caeee-9036-4179-9bae-d5b10ceace09"), "192", "4615901584853326", null, null, new Guid("db91ddfb-75b6-4d51-82ea-52631a102b16"), "05/19" },
                    { new Guid("1f286802-8642-4690-a542-c96b6667dc62"), "777", "6977571575547238", null, null, new Guid("353c126e-57f5-471a-b13f-0e4fd4cef2fe"), "11/08" },
                    { new Guid("1f322df4-b393-478d-8fb1-6d71fd874c69"), "998", "8634421329628126", null, null, new Guid("d57e07f1-63a6-4514-ae7a-51f83c901e2c"), "12/02" },
                    { new Guid("1f5c3eae-70d1-4e4e-8f16-a9757ea20fe6"), "972", "9511436146679421", null, null, new Guid("a419df27-9358-4a02-9ab7-2f2e2344fae0"), "08/16" },
                    { new Guid("1fb3642a-c744-4a10-8df2-c22a964f854a"), "078", "9815911145812445", null, null, new Guid("02a17a84-0a35-4164-b872-e030d586b6fe"), "11/07" },
                    { new Guid("1fbe9a37-28fe-4cbb-883b-a6de2eeb20ae"), "010", "5865801186442845", null, null, new Guid("2476b4fb-aceb-40f6-b636-80dd269d535c"), "10/04" },
                    { new Guid("20447729-c2ec-4a9d-b45a-b6129c5c720f"), "958", "2035620154665783", null, null, new Guid("c7c0cd55-07d8-41cc-9d2b-4bd04cb7edb3"), "09/25" },
                    { new Guid("20f8ff7c-a7e1-44e5-90a0-a44730ae854c"), "028", "7511542535177890", null, null, new Guid("8ce72c63-9c31-4159-9ba2-012a4fc3df72"), "04/22" },
                    { new Guid("215273fa-7934-4708-b173-1cc44df57a4c"), "516", "2699105563464028", null, null, new Guid("6ab8f9db-6513-4d8f-9cde-7b925ff51057"), "06/24" },
                    { new Guid("220e37ff-75c3-41e4-96aa-74f11b0dcced"), "643", "5779542495156731", null, null, new Guid("a419df27-9358-4a02-9ab7-2f2e2344fae0"), "06/17" },
                    { new Guid("2279efac-d686-48cc-9083-d3461f0401ac"), "273", "5196510655650741", null, null, new Guid("8ce72c63-9c31-4159-9ba2-012a4fc3df72"), "11/11" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("2393ee43-575e-4039-9a71-e26b4e3f70f9"), "071", "8353325213740213", null, null, new Guid("5c6a10ae-343d-47fa-9381-6cbe7b1a68be"), "06/07" },
                    { new Guid("24234e2c-6a19-41fe-82d5-deeeebf133b8"), "938", "1966661139437525", null, null, new Guid("9cf1e944-d004-426c-83ee-acb2b8793bc6"), "02/10" },
                    { new Guid("2443d3d3-2800-4d65-99e6-4d5a3173510a"), "587", "4067557655015980", null, null, new Guid("80c8c606-5918-4559-bdbb-606d564f96d5"), "05/06" },
                    { new Guid("2456f047-0948-4dc0-8b0b-7ed083fd47e1"), "143", "3499286274410748", null, null, new Guid("7abaa815-d503-4740-a0a9-20d8752fc2cf"), "02/13" },
                    { new Guid("245e37f6-f623-4447-bf3d-a386d3e73fb9"), "151", "4284814397244684", null, null, new Guid("719d1670-ba7d-4e9b-b4de-d7074f81aa66"), "03/18" },
                    { new Guid("2495e019-b5e3-4851-aebd-4e267d65547e"), "331", "2997850459260079", null, null, new Guid("4188ab2e-f46b-4cf6-b460-560a914e5d35"), "11/03" },
                    { new Guid("24b7ae98-fa8f-4a7c-81f3-4ba20aa0554e"), "245", "9397562845226228", null, null, new Guid("6f196aeb-f350-478e-a23f-992b0ea6da29"), "12/24" },
                    { new Guid("2559f1e6-6f08-4cab-8b0e-1e80c3d858cf"), "194", "1442348369672713", null, null, new Guid("70d04e87-92ed-4410-96a6-934a82c8bbcb"), "09/15" },
                    { new Guid("255b6a7a-eba2-4c7b-bc66-0fd0692f6073"), "495", "5098005899540889", null, null, new Guid("7cf58058-5eec-4c6e-a4ae-cf50ccf0b2ac"), "03/21" },
                    { new Guid("255ee0be-dbc7-4b16-a5bc-384fe618f4d3"), "684", "6126395135712010", null, null, new Guid("6f109fcf-941c-474c-810c-243f75df54d6"), "12/06" },
                    { new Guid("2591c05d-3935-47af-b048-92657b49544b"), "090", "2673212113721811", null, null, new Guid("405a5eb1-aee0-4578-8748-2d8b5a6b0d57"), "02/04" },
                    { new Guid("259969ac-9198-49bd-91fc-d5f3e982d60e"), "134", "7352626469224534", null, null, new Guid("c58f524e-a96e-4e8b-9186-6c21d38d64b3"), "05/10" },
                    { new Guid("25b3ad54-6021-498c-9d16-61a4e730f0b2"), "880", "4192066718528911", null, null, new Guid("f51931e0-68b3-4aed-8f03-7ef9a8526650"), "06/18" },
                    { new Guid("26d592f1-886f-4264-aaad-5aa72f4b0a8c"), "060", "2672887310416805", null, null, new Guid("5f366c1b-9e38-4bc9-b773-fca63347cbcc"), "10/09" },
                    { new Guid("276793e3-c585-4c4a-a020-4fce18c6d126"), "034", "4176374448073139", null, null, new Guid("cf348fa5-7d32-48ec-957c-eb481beb0358"), "06/14" },
                    { new Guid("279065b9-525f-42cf-8c0a-d2a3d8067569"), "406", "5321295577097111", null, null, new Guid("bd07490e-79db-4063-b992-0fa27e7f7677"), "01/06" },
                    { new Guid("27b7f92e-ec12-4794-9077-bfa28f6a2db2"), "621", "4684886104289526", null, null, new Guid("718a03a0-2841-450f-a417-5345b18c81ab"), "11/26" },
                    { new Guid("27db6772-47eb-4d52-bd12-1105a5617304"), "013", "6201083848237686", null, null, new Guid("56b8dced-e510-417c-8b93-8a2cb06b845a"), "06/26" },
                    { new Guid("2805f28c-60e3-49da-ab9f-b73df94f0ba1"), "409", "2485143740571789", null, null, new Guid("3f1a1c74-7f9a-433e-808b-f0d69f6d97e7"), "06/14" },
                    { new Guid("280c6681-e36d-483a-b7c2-1cfc94eb49ce"), "388", "1137665273171494", null, null, new Guid("230e73b5-4a4b-4b1c-ad48-f7a0074303c7"), "12/13" },
                    { new Guid("29420648-8c99-4635-b7ef-c90ac8ae2040"), "772", "2922894521285663", null, null, new Guid("2b5f8a6c-d3e8-41ff-8867-cadb6cd16ea4"), "08/01" },
                    { new Guid("29e6ff9b-09e3-4eaa-99fa-cca48fbd1d2c"), "379", "9153655423746555", null, null, new Guid("335c9d28-42e2-4d49-9686-f0cd1b972fae"), "11/27" },
                    { new Guid("29eb2d2e-04a4-4510-b517-dc00fd7a073f"), "099", "9729843282827605", null, null, new Guid("7de3e658-53a0-464d-a4aa-b7bf40828f5d"), "05/21" },
                    { new Guid("2abd1134-e019-4835-a552-0ad6bd8d1e30"), "066", "8414881086961346", null, null, new Guid("46542d6d-04cc-418a-88b4-cda40f4aff48"), "01/18" },
                    { new Guid("2ac81eb6-5cde-4a05-9663-4470765e14ba"), "095", "4958930759303492", null, null, new Guid("eeb82343-3a6f-48ee-b791-709692ceea7d"), "06/23" },
                    { new Guid("2aeab43d-44cb-4b65-a7ff-f162cac1a2c3"), "735", "7418758852060680", null, null, new Guid("bbe91897-98e6-4c1e-aef5-09cd3dbb35cd"), "02/20" },
                    { new Guid("2b05e7af-6be1-42e8-9521-e795573edb2d"), "081", "8894031654222613", null, null, new Guid("cf348fa5-7d32-48ec-957c-eb481beb0358"), "09/04" },
                    { new Guid("2b356c6d-0bbf-4e09-b058-1d798ab4cc15"), "447", "6710635810777739", null, null, new Guid("57b666b4-3a1b-4303-851f-a88f5f534543"), "03/23" },
                    { new Guid("2b6363ea-9fe6-4935-8ae8-44aaa2307065"), "903", "2844411995377286", null, null, new Guid("dc5f8e5e-be11-43f9-acd2-648e38e09946"), "08/24" },
                    { new Guid("2bf47634-08fe-4e07-a64b-5e1ea37f61cd"), "643", "1167848176641403", null, null, new Guid("d57e07f1-63a6-4514-ae7a-51f83c901e2c"), "02/03" },
                    { new Guid("2c79564a-c32e-4798-bee5-3301ecdd52ed"), "202", "8622127376630154", null, null, new Guid("cf611bf3-21fb-4ed7-a138-00c7afdda9ba"), "04/17" },
                    { new Guid("2cda2b1d-15b6-4dcc-abe4-c583e9555b45"), "436", "5758493672497992", null, null, new Guid("4ecad1f7-2b37-4dd8-be42-dedd60205e81"), "01/28" },
                    { new Guid("2db0ffcb-f3ea-4322-8d86-ce907bd8702e"), "956", "4725706470847643", null, null, new Guid("3ee0e809-4d8b-4164-a824-c5ab67903af7"), "04/09" },
                    { new Guid("2eb2bd68-a63a-46e5-a2fd-31ed8caf95a0"), "115", "1374444738757779", null, null, new Guid("06f4c32b-9a3d-4b38-99a4-56ea0ba685a8"), "10/28" },
                    { new Guid("2eeeb813-8d54-4e9e-bb6f-f3fd70c6aebc"), "296", "1449451393596815", null, null, new Guid("e5406e78-ce40-43ee-8dee-e58fe7687eb3"), "02/04" },
                    { new Guid("2f2db7c9-06ab-4731-86b0-007bdeb5fe8a"), "652", "8918879406942358", null, null, new Guid("aec475ab-9ab8-4f55-8794-ee1ffc6f6da6"), "04/11" },
                    { new Guid("2f73c9db-7a55-4219-a4ea-c8712ff4ddfa"), "610", "3111939778576448", null, null, new Guid("a9090dd7-3795-48e2-837b-9a72a0274d7b"), "05/03" },
                    { new Guid("2f8be117-9e8d-48b5-8fdd-7305f07e8517"), "743", "5559544193600745", null, null, new Guid("59a9232d-40d9-422d-8a1a-fe022e85093a"), "11/10" },
                    { new Guid("2f97d278-6529-42d7-be6a-b40216fd0b3a"), "582", "4368212954741000", null, null, new Guid("c3cc5785-6364-48fa-bb83-e7ac33fc672b"), "03/10" },
                    { new Guid("2f9e46ae-4475-4a78-aae0-84e7c87c3b74"), "922", "8205834985602693", null, null, new Guid("8a696f30-76c2-40db-a250-030829547d67"), "09/01" },
                    { new Guid("2fa68a04-ac9b-42b9-aef3-c195fd71b3bc"), "834", "7389300457379753", null, null, new Guid("df3cc97e-5297-4426-8d73-6ec8a1d6ff19"), "05/28" },
                    { new Guid("3029679a-b724-40d1-ada7-9d34be1cae03"), "749", "2642519350680161", null, null, new Guid("59a9232d-40d9-422d-8a1a-fe022e85093a"), "12/16" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("3057a2c5-1b18-4895-b670-c18d808e7109"), "938", "1133630779259859", null, null, new Guid("c7f42761-e210-47b4-9e39-2df36dce4c96"), "12/04" },
                    { new Guid("3066b31e-9628-4bc8-b427-5d42cd2e0d1e"), "773", "4850623368934176", null, null, new Guid("22edc826-6747-4099-aca5-578199353ac6"), "06/14" },
                    { new Guid("308dcdb5-6a41-45a8-8245-217e67a031f0"), "484", "6722195625693172", null, null, new Guid("539c62ee-15fc-4d37-ab5d-0e4126109954"), "03/23" },
                    { new Guid("30a65e34-da4d-45c9-9612-92f3e0e4da77"), "641", "4409940957484200", null, null, new Guid("108fbff3-4041-4eed-b2a0-4a4b1fb47787"), "02/11" },
                    { new Guid("30a8ab56-19de-45a0-b997-ef98c522848c"), "551", "1692091310657607", null, null, new Guid("cf3285c8-97d7-426d-87f3-e0854194e226"), "05/06" },
                    { new Guid("30acabdd-1a2d-431d-9a1d-f58bc31e7311"), "769", "1293583150861656", null, null, new Guid("3b3e9016-3025-48e3-93b2-fa474015c0f7"), "06/17" },
                    { new Guid("30dac252-6817-4859-9591-62fd2219a35b"), "645", "1638459856650169", null, null, new Guid("672ce079-171b-4f7e-b744-6b9376e96b61"), "02/23" },
                    { new Guid("31056e2c-d68d-4f3b-86b8-b1e15b9346ca"), "139", "6600859171436735", null, null, new Guid("108fbff3-4041-4eed-b2a0-4a4b1fb47787"), "02/14" },
                    { new Guid("310783db-2799-4edb-b1f8-cda8ed2c2bdc"), "810", "8557955115014632", null, null, new Guid("9e96d314-cd64-47aa-a5bc-7e0525cc9914"), "11/06" },
                    { new Guid("31140d9b-b801-48ee-b0d3-c5c099bd87b7"), "030", "4309413410159107", null, null, new Guid("0773e360-956e-4d39-94c5-d0906a9e4557"), "02/14" },
                    { new Guid("315da80a-59c6-4367-8116-dd9f6317f986"), "428", "3558741427118530", null, null, new Guid("63107baa-d978-4764-b959-7e90a1de3ee0"), "05/26" },
                    { new Guid("317a1815-f9b9-43dd-b459-f98ba6797413"), "496", "7329850468636822", null, null, new Guid("23e8131d-ba45-4488-991d-941eca3fbe0a"), "08/13" },
                    { new Guid("3196b622-102c-4a35-a3c8-f7761dc6ac48"), "805", "6482766592884322", null, null, new Guid("d40492c4-d582-4ce6-943c-a487675b7960"), "07/25" },
                    { new Guid("32905377-405b-4aca-944a-8e5aa5d0e2ee"), "207", "1722491726340947", null, null, new Guid("dbc51236-052c-4c31-820d-b0a01a143d1a"), "11/24" },
                    { new Guid("32baa2f4-4d29-49c2-8d90-f1655694767f"), "053", "8120806189217457", null, null, new Guid("42babbec-5dbe-4cc3-9f68-bb4bc7ad9491"), "07/04" },
                    { new Guid("333365ac-3924-4bd6-a34d-8f0b07bc49b5"), "298", "7466441499215427", null, null, new Guid("c590f92c-3ca1-4a33-a976-926995a0f7cc"), "12/17" },
                    { new Guid("3397f65e-2932-462d-9186-aa2ae4872284"), "981", "9325860020773545", null, null, new Guid("9ec54876-333f-4825-9959-c839395cb66e"), "02/14" },
                    { new Guid("33be5c14-e887-4514-9408-5bb710e0366f"), "588", "1800425589612222", null, null, new Guid("5c5b9127-2aa5-4ed6-b779-6402154d5c0f"), "07/14" },
                    { new Guid("3463d252-67f9-47c5-93b2-54c940021861"), "861", "8838588774807265", null, null, new Guid("64e0a0ed-41a2-429f-800b-6407610d5984"), "09/02" },
                    { new Guid("34aacba4-7d41-4975-89c2-e0da79c1c069"), "139", "9128935517159800", null, null, new Guid("3712e35b-2da9-4c76-ad88-28828e776a5c"), "01/09" },
                    { new Guid("34ac27c6-34bc-4f21-82a3-72d95bd229e2"), "599", "7189243464189541", null, null, new Guid("b53497b3-fabe-4282-a5c6-ef6e82864309"), "11/08" },
                    { new Guid("352b2a99-d73a-4b31-a9f9-36fa9166a003"), "808", "6072966156749982", null, null, new Guid("7c2f2e0c-1d40-453b-84ea-f5f09cb10d28"), "09/25" },
                    { new Guid("353b5ffb-0444-4bb2-843a-ac01255dc4b5"), "584", "7915719762586981", null, null, new Guid("8fc5f8c0-3711-4486-8ea0-48697b9ea01f"), "03/24" },
                    { new Guid("3557f231-a461-4e3a-9b0a-041707f836ad"), "419", "7547434019384842", null, null, new Guid("4b2a14c5-b9ad-4e45-ae16-0762e7d1e215"), "10/19" },
                    { new Guid("35947da0-a9d2-4fe5-82a9-3761762f7989"), "683", "2664423857372039", null, null, new Guid("5d1e2a88-0f0a-4b6e-a524-e279224a1944"), "08/04" },
                    { new Guid("35d9f4a5-8234-485d-aaca-df6a6ab82c15"), "303", "7968123009485542", null, null, new Guid("4fdddaf5-83dc-4f45-ad82-fcab10f87405"), "09/21" },
                    { new Guid("364cbf89-86f6-4340-927a-683c0356c1c3"), "624", "5354667042696830", null, null, new Guid("1e17494c-b19d-4879-af0e-c6575db6bd37"), "09/10" },
                    { new Guid("3660c017-2c1a-43b0-a5fe-21d1107113eb"), "227", "8348671525175907", null, null, new Guid("e36aac18-179d-420c-8aaa-edf7ff736e50"), "07/18" },
                    { new Guid("3675ede2-7fe7-4df8-824c-2052bcb63c19"), "679", "2404496687681186", null, null, new Guid("f630d90d-3329-4958-99e4-34aa2f69436c"), "06/19" },
                    { new Guid("36cd4a0a-73f2-47d6-b3d5-94b5fa104362"), "764", "8458170245521452", null, null, new Guid("8be01b71-4060-43ad-98a5-2c0730fd003b"), "01/27" },
                    { new Guid("36eca680-70c3-4ef7-b920-08d951bfbd3a"), "337", "7605514619892678", null, null, new Guid("78be92c8-3390-4d5e-aa3a-54c7301eaf2f"), "06/05" },
                    { new Guid("36f338f2-1254-4823-9578-21926606d34d"), "918", "8627566108350270", null, null, new Guid("323967f9-cf4e-4818-a5bf-94dff7ea728b"), "01/19" },
                    { new Guid("36ffc051-c611-4080-95ff-50a88af75ba9"), "752", "7924304038095019", null, null, new Guid("64174d68-43d3-488f-89bf-23d32b134019"), "01/21" },
                    { new Guid("37337eb9-c7fc-4a74-a284-b3c3b1b95063"), "412", "3710943586026422", null, null, new Guid("aec475ab-9ab8-4f55-8794-ee1ffc6f6da6"), "12/21" },
                    { new Guid("3752f714-b938-43d7-8e88-2ef429a871ac"), "706", "4651304242731994", null, null, new Guid("718a03a0-2841-450f-a417-5345b18c81ab"), "11/27" },
                    { new Guid("37682ca6-e675-4ca3-a656-9214a3b8ca61"), "030", "9799974554176929", null, null, new Guid("0877dbd6-c025-49ef-b189-53b217500382"), "10/21" },
                    { new Guid("383fb7f8-02f3-40a3-ab5b-908fd1885ec4"), "820", "7006439324218382", null, null, new Guid("48b3cd65-be2f-4be1-a3c5-d88da44b3d73"), "02/05" },
                    { new Guid("38ce4eda-3dbb-4827-a8b0-22edde604ff8"), "446", "2136328292726656", null, null, new Guid("5d1e2a88-0f0a-4b6e-a524-e279224a1944"), "12/15" },
                    { new Guid("3922f7ae-0437-4306-8bae-81551f45c9a9"), "245", "7895387577641391", null, null, new Guid("dd550cd7-4eae-4d75-8be5-5f3e496fdd24"), "05/10" },
                    { new Guid("39706170-8564-41d5-b242-c26238d24d66"), "830", "7468977398871974", null, null, new Guid("ed5c634a-32ee-48fd-80f4-26cfb1c72602"), "11/15" },
                    { new Guid("39bc1ede-3318-4cc9-87f9-75f09c88939c"), "732", "8599786678170944", null, null, new Guid("df3cc97e-5297-4426-8d73-6ec8a1d6ff19"), "07/07" },
                    { new Guid("3a9b5883-e988-4d6e-a95e-8ffa60ed4dab"), "727", "7654947688351268", null, null, new Guid("25c234e8-8d95-42b3-9dc3-c418fbcaa7da"), "10/10" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("3abe39ec-3642-4ae1-b5f2-2a48e1ac719d"), "902", "6498166817108154", null, null, new Guid("2bdbd536-e4dc-4869-9dac-f62a098ecb05"), "03/13" },
                    { new Guid("3b6074d6-df1d-41e0-b688-17805a145600"), "328", "6958708410148473", null, null, new Guid("3a19b458-72b3-4b5b-97e6-334a56d7d557"), "01/25" },
                    { new Guid("3bcfe014-07d3-48b6-b74f-24fde721864e"), "284", "1542607212338149", null, null, new Guid("8e3d5153-23be-45f9-83b4-5aecbb1a4322"), "05/23" },
                    { new Guid("3caba4e7-1b54-40ee-a19e-4f50ef80562b"), "915", "3916075097231864", null, null, new Guid("405a5eb1-aee0-4578-8748-2d8b5a6b0d57"), "03/05" },
                    { new Guid("3ccff2d8-05ca-44ae-8881-720d9e23e521"), "687", "6379793211253449", null, null, new Guid("4a9e17b4-cb0f-4c82-80d2-e1d56fe06f0a"), "11/23" },
                    { new Guid("3d071792-2332-49e6-8b64-053d199573a5"), "411", "7154417112618148", null, null, new Guid("6c16f159-98d6-4d70-a7ac-43b19b827d49"), "06/08" },
                    { new Guid("3d113668-14a1-42bf-bd2f-16d02e51321e"), "915", "2000704853661939", null, null, new Guid("c3cc5785-6364-48fa-bb83-e7ac33fc672b"), "05/10" },
                    { new Guid("3d416eb0-1a1c-4daa-b238-3f4007c6abd4"), "610", "9282221799588306", null, null, new Guid("4fdddaf5-83dc-4f45-ad82-fcab10f87405"), "08/06" },
                    { new Guid("3d76c7ce-1948-473b-b023-c2bb7d00bf50"), "967", "6120426485264622", null, null, new Guid("39d27a82-05d2-4135-b53b-53748eefd4f2"), "11/23" },
                    { new Guid("3d94f3bc-8aa2-48d0-a435-517e5e973616"), "938", "8390187222378806", null, null, new Guid("50fa1a40-d4af-4edd-8c00-61ec693395b2"), "02/18" },
                    { new Guid("3e39a855-2d04-43cd-9987-ddd43ec5d531"), "758", "3723540520528138", null, null, new Guid("97e11482-d5e6-41d7-82e3-80806df9c3bc"), "10/24" },
                    { new Guid("3ebad0b7-714e-422d-aba5-f95398b18188"), "120", "3258318285689141", null, null, new Guid("0776f148-3954-48ff-8bb8-772d353c1a3c"), "07/26" },
                    { new Guid("3eef1ee8-7626-4fd9-bafc-b59fadad61da"), "526", "7235027618784675", null, null, new Guid("f7082ecf-eb66-429e-8a3f-72fac7d7b453"), "04/10" },
                    { new Guid("3f60c850-03ca-4c98-b4ad-db4dfdc379b3"), "485", "3860771606859339", null, null, new Guid("3b3e9016-3025-48e3-93b2-fa474015c0f7"), "03/22" },
                    { new Guid("3fab6973-9e44-4809-a374-de16115f53e7"), "783", "8072534320515770", null, null, new Guid("672ce079-171b-4f7e-b744-6b9376e96b61"), "02/05" },
                    { new Guid("40091f21-4a38-4859-bbb9-ee8edf87c29d"), "123", "5277586654099548", null, null, new Guid("8bfa284c-faeb-4fb6-909c-2a2ea4c8745b"), "03/24" },
                    { new Guid("40655562-f051-4b61-b29f-c429d361924d"), "371", "7319719690096724", null, null, new Guid("831f8f9d-e78d-4f72-8b48-1c32c42fda1b"), "11/04" },
                    { new Guid("40e60342-c7fd-4901-8c5e-d3110cc963e7"), "944", "3806264112343519", null, null, new Guid("405a5eb1-aee0-4578-8748-2d8b5a6b0d57"), "05/10" },
                    { new Guid("4108b5e0-0910-4bcf-8612-62107aea850f"), "184", "7565709535004086", null, null, new Guid("819538c4-628a-4b17-a719-8274b53093f3"), "04/19" },
                    { new Guid("41293b9d-d754-4754-9d52-fe19daee50b3"), "282", "2345670199136237", null, null, new Guid("8ea935b6-2c30-4bef-803c-9f382789979b"), "12/07" },
                    { new Guid("41859f87-13d4-4f9d-98cc-0e4837dcc4df"), "489", "7559663755600525", null, null, new Guid("80c8c606-5918-4559-bdbb-606d564f96d5"), "07/21" },
                    { new Guid("41a1e631-7f03-4027-8dc8-927f2104acd6"), "670", "5922636102592496", null, null, new Guid("bc7c70fa-9300-4c06-afd7-8aa97fcf9993"), "04/18" },
                    { new Guid("41b8abad-ab81-429e-94c6-8013dd9f6026"), "128", "6815578360445723", null, null, new Guid("dc2b5eaa-01f8-425c-874d-15e523189cc1"), "09/14" },
                    { new Guid("41c77c4c-da2e-4e57-aec4-a00dcbc4cc66"), "253", "4033068279659767", null, null, new Guid("c40f9fee-6298-4137-bc78-c74409dec92f"), "10/16" },
                    { new Guid("4346b330-faa1-4729-96c4-b81e4dd1c758"), "678", "6672992615932331", null, null, new Guid("141e6ca1-3b19-4ffc-a21f-8420c3f6db52"), "11/15" },
                    { new Guid("437bd148-3ad3-4e8b-b6d6-b4075dadf556"), "733", "4029147121818672", null, null, new Guid("0c66002d-25be-4864-84e7-acd6fd765b27"), "12/16" },
                    { new Guid("43e05066-44a2-4ddb-9957-15612c7259d0"), "299", "5056151485199789", null, null, new Guid("72a42c8b-ed7c-4e7a-81c6-313cac897b20"), "02/25" },
                    { new Guid("44486375-a46a-464c-92e3-6e5550b112af"), "163", "2596898757614621", null, null, new Guid("d29932a8-80f8-42b1-85e0-6bf810161455"), "06/27" },
                    { new Guid("448df62e-c633-4e8c-b415-88d99ac3b71d"), "136", "1787047143730904", null, null, new Guid("93e9e8fa-8b76-4968-a1ef-a4d59b6958ea"), "10/06" },
                    { new Guid("44e8c548-093e-4c54-a0bb-9c87f03eb816"), "539", "9924738491347997", null, null, new Guid("323967f9-cf4e-4818-a5bf-94dff7ea728b"), "01/09" },
                    { new Guid("4558dd58-c5e1-479b-b00f-33d4670b1f62"), "974", "4298912705241486", null, null, new Guid("e5406e78-ce40-43ee-8dee-e58fe7687eb3"), "01/06" },
                    { new Guid("463711fd-407d-4916-8ca2-bc8705afc313"), "827", "5180533419594261", null, null, new Guid("5aff4312-b9a9-4958-b14a-305be3aa9f4b"), "04/23" },
                    { new Guid("4637a745-22cd-4803-b020-6d40b18843a8"), "297", "7881479335307837", null, null, new Guid("4732299f-418c-4c2e-ac09-aacb3b2c8976"), "09/02" },
                    { new Guid("4672129b-e01f-4172-9e63-7e54fd6afb0e"), "279", "1928573274918250", null, null, new Guid("94c09a0c-18a4-40c8-9285-032386267d16"), "11/07" },
                    { new Guid("46f8527f-121d-4285-8d93-caaf8826339a"), "986", "6209560709720478", null, null, new Guid("8ce72c63-9c31-4159-9ba2-012a4fc3df72"), "06/16" },
                    { new Guid("475fcd5d-cf83-42fc-a6f2-6f371ae51913"), "706", "5174990429840685", null, null, new Guid("db32027d-cf9c-4544-af7d-d20c917925c7"), "03/12" },
                    { new Guid("4775343b-abda-4d60-85ed-1a333c16e422"), "281", "3506005640199202", null, null, new Guid("dbc51236-052c-4c31-820d-b0a01a143d1a"), "07/09" },
                    { new Guid("484a5f9d-de59-48c9-98de-f511177b8c68"), "229", "1726226684894260", null, null, new Guid("d57e07f1-63a6-4514-ae7a-51f83c901e2c"), "02/16" },
                    { new Guid("4858db65-78a7-438b-9602-8394de521289"), "780", "4038208138749128", null, null, new Guid("5d203345-c58f-4236-9e46-c9ba7a8529a5"), "05/15" },
                    { new Guid("489e9fca-8ae8-4afd-820a-8ca732ea28da"), "404", "4345269692392963", null, null, new Guid("7da75a84-c857-4768-9ff2-252052ea5333"), "09/20" },
                    { new Guid("48b8564d-f4ce-4bbc-91b1-1206f68568a4"), "106", "8093605738521974", null, null, new Guid("5d203345-c58f-4236-9e46-c9ba7a8529a5"), "03/06" },
                    { new Guid("48e59979-40d9-4d6a-9f04-f65ea0c47e44"), "035", "4567663218318776", null, null, new Guid("5c6a10ae-343d-47fa-9381-6cbe7b1a68be"), "02/05" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("491e4131-a1e6-4f40-b88a-0bf7fdf8b8e8"), "341", "1485633815991130", null, null, new Guid("74ef9233-8d34-4883-8938-b78b6c147246"), "07/17" },
                    { new Guid("49c0cff1-d553-4cd9-b4f3-0e1ecc3013a6"), "086", "6641026827077440", null, null, new Guid("0a1370d0-5d3b-4609-9efc-9507f4acc2f8"), "03/02" },
                    { new Guid("49f75e99-00da-49d8-97b1-84ea5896dffd"), "787", "5969134738239760", null, null, new Guid("db91ddfb-75b6-4d51-82ea-52631a102b16"), "04/03" },
                    { new Guid("4afb3d6c-1ac6-4270-bec0-a92d181227b0"), "880", "7201451900454743", null, null, new Guid("719d1670-ba7d-4e9b-b4de-d7074f81aa66"), "09/10" },
                    { new Guid("4b7c43de-cf9b-4629-b6c2-eebb0870c8fa"), "084", "4652355375310845", null, null, new Guid("4732299f-418c-4c2e-ac09-aacb3b2c8976"), "06/16" },
                    { new Guid("4c0bf29d-35f7-49ba-887a-cc2defb48b58"), "449", "6397106820525448", null, null, new Guid("4b45c810-f446-449d-8b0e-4a2ebbbf7104"), "05/14" },
                    { new Guid("4c67ede4-c517-443a-aad9-026ed786c91c"), "972", "1263495170817672", null, null, new Guid("c5513371-ea13-4b3b-ab65-8bbb471b2afc"), "05/10" },
                    { new Guid("4c9645a9-d642-493c-ace0-36ebad3e1af5"), "185", "2768309871835087", null, null, new Guid("c88c725e-8cbf-416d-a4bf-153a024ea6c9"), "09/11" },
                    { new Guid("4cab3a83-3e83-4eea-a0e2-779bcf53a4cb"), "230", "7002147884380432", null, null, new Guid("e41a0e5f-468e-496b-8fe7-b8f4b2a0f962"), "10/05" },
                    { new Guid("4cd7129b-665e-49db-a620-4df8db9644ce"), "091", "8383493659192192", null, null, new Guid("7da75a84-c857-4768-9ff2-252052ea5333"), "07/15" },
                    { new Guid("4d0716af-a155-4a07-8e1d-fb5ab95e934d"), "807", "2738317884200694", null, null, new Guid("487efc58-2d93-4b91-a4fb-1ce1d3ef038a"), "02/24" },
                    { new Guid("4d28378a-4296-4c67-966f-5e919e91775c"), "665", "5101904232796852", null, null, new Guid("4ecad1f7-2b37-4dd8-be42-dedd60205e81"), "04/20" },
                    { new Guid("4d2c8399-02c3-49f8-8e8f-25122d65894f"), "034", "3263277024260286", null, null, new Guid("40a279f6-73dd-4fa2-8b1e-05f9cd8bdcf9"), "01/24" },
                    { new Guid("4e127860-ccf3-4afe-bde2-5785beee013f"), "764", "2269154786386569", null, null, new Guid("ab451099-7866-44e4-9ebd-f1162ea6206a"), "10/13" },
                    { new Guid("4e16a105-6033-4dd4-98e1-c7287e3cf560"), "603", "3681987032087809", null, null, new Guid("e36aac18-179d-420c-8aaa-edf7ff736e50"), "05/14" },
                    { new Guid("4e5f8f91-4424-4796-96c3-e68db203c1b1"), "465", "8245113967889731", null, null, new Guid("0d88a4e0-8366-4547-8ebe-087d4c74b34f"), "03/05" },
                    { new Guid("4e69aa94-8bce-4657-9e23-f2a421957754"), "590", "5030005386213066", null, null, new Guid("bd349cb3-f696-4e78-9355-45b8b4f7385f"), "12/06" },
                    { new Guid("4e6fda05-6d4e-42cb-ba06-1f1be9102a96"), "934", "3800908226257774", null, null, new Guid("82b99640-3f2e-425b-a088-51b3c226a192"), "08/11" },
                    { new Guid("4e92c4be-e7af-423b-8d1c-d859c69aa5b5"), "948", "1697055203660147", null, null, new Guid("5f366c1b-9e38-4bc9-b773-fca63347cbcc"), "02/26" },
                    { new Guid("4e9811dd-de6a-435b-b9f6-3113d39e7d88"), "698", "7275720928887008", null, null, new Guid("99d4724f-46db-42d2-a62b-3d8fa528e130"), "02/25" },
                    { new Guid("4eaa4de7-8900-4914-a0c8-644f4afba55c"), "821", "3656607137756256", null, null, new Guid("48f4af12-c8b0-4444-98ca-81df5d349e01"), "02/28" },
                    { new Guid("4f2c2db4-a3f8-4e6c-856e-99cf2b38d195"), "045", "9216198992543339", null, null, new Guid("df3cc97e-5297-4426-8d73-6ec8a1d6ff19"), "06/19" },
                    { new Guid("4f4b5ea2-da2e-4a0e-ae3b-c95c0ecb7d1e"), "956", "3659433519442689", null, null, new Guid("719d1670-ba7d-4e9b-b4de-d7074f81aa66"), "02/18" },
                    { new Guid("4ffeb4b5-bb0c-451b-8ebc-f66b3b6cf152"), "711", "7960718903222443", null, null, new Guid("bd07490e-79db-4063-b992-0fa27e7f7677"), "02/19" },
                    { new Guid("505d33f4-439f-44d3-aaea-9d707dfcf571"), "514", "2525207296185623", null, null, new Guid("3314d8f7-2262-4e19-afd4-3e85972480b8"), "02/11" },
                    { new Guid("50b208be-a6a6-4d3a-8bd5-03939c5b92cb"), "834", "2126948193282569", null, null, new Guid("6c3e0836-290a-4c10-8832-91720a2e9054"), "01/01" },
                    { new Guid("50e9cf53-84bb-4363-a007-99c2ce3fa6ea"), "750", "4521645516541874", null, null, new Guid("0c66002d-25be-4864-84e7-acd6fd765b27"), "06/17" },
                    { new Guid("510f42ff-110e-40d4-9e4f-eb3bbe95bbfa"), "815", "7680811392249433", null, null, new Guid("658f3ddd-678c-4dca-b9fa-45901c0f1c05"), "10/17" },
                    { new Guid("51230d19-4b30-47fe-88c3-610eb0576df7"), "941", "4802295681015226", null, null, new Guid("76c44275-2d3e-43e9-b34e-c05f912213b8"), "10/11" },
                    { new Guid("51a7985e-5de5-428a-85e4-f756bbfcc0e3"), "573", "1223210915558955", null, null, new Guid("7778b4eb-db56-4ddd-a0bc-5f46aff077f7"), "01/28" },
                    { new Guid("522116cb-a701-4509-adbe-59d048dcb56f"), "974", "4605765410198695", null, null, new Guid("fe7a3052-1ad9-4450-b9d5-057c6abe9c2e"), "09/20" },
                    { new Guid("522d6fe8-ed70-47ba-9be5-d765bab17953"), "720", "5703011219470354", null, null, new Guid("48b3cd65-be2f-4be1-a3c5-d88da44b3d73"), "11/01" },
                    { new Guid("523fdae4-107e-48f0-892a-bc69da686221"), "506", "4828120544929985", null, null, new Guid("3c3a765d-c1b9-47c7-b39a-7b5dc35e1cbc"), "08/27" },
                    { new Guid("52473430-7237-4a42-9619-ff3777450d91"), "918", "5674704334333865", null, null, new Guid("0e7742f2-e964-4e8c-b692-4ffb75ece318"), "12/22" },
                    { new Guid("524f7361-254d-4d98-9d59-49d18b9a992b"), "340", "9919059436986485", null, null, new Guid("f28f3fdf-fa90-4b58-895f-89b7f89e53e9"), "06/05" },
                    { new Guid("536989f1-fdcc-4ca5-b663-f2957c804e9c"), "767", "1036782452295579", null, null, new Guid("c590f92c-3ca1-4a33-a976-926995a0f7cc"), "06/20" },
                    { new Guid("5406dbae-deef-4156-8669-8ac7e91f2d80"), "726", "2692640598835864", null, null, new Guid("e41a0e5f-468e-496b-8fe7-b8f4b2a0f962"), "07/21" },
                    { new Guid("5420236f-c0b6-430e-a221-99db95f61153"), "794", "8309099115328307", null, null, new Guid("ce7719fc-1874-4df0-88ba-9b5637945029"), "04/11" },
                    { new Guid("54cfed4f-9c3b-4ad4-b8c9-4ce0cd68dca0"), "664", "8041354458519050", null, null, new Guid("0d88a4e0-8366-4547-8ebe-087d4c74b34f"), "01/03" },
                    { new Guid("54fae110-6ef9-4f33-9dee-f417a59b4695"), "242", "6844803507268290", null, null, new Guid("3314d8f7-2262-4e19-afd4-3e85972480b8"), "11/28" },
                    { new Guid("553a4c19-9568-4a51-9e26-2a5654843668"), "008", "1967642874655068", null, null, new Guid("5f366c1b-9e38-4bc9-b773-fca63347cbcc"), "10/08" },
                    { new Guid("556a5fc9-fe64-4666-9e0a-477d3a064ec0"), "847", "9546193019788137", null, null, new Guid("fe7a3052-1ad9-4450-b9d5-057c6abe9c2e"), "05/01" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("557055c6-36ce-4408-89ce-9f9a29841a25"), "840", "8929736048767279", null, null, new Guid("3c3a765d-c1b9-47c7-b39a-7b5dc35e1cbc"), "10/23" },
                    { new Guid("5582af1f-d75d-48bc-8cfd-677bb27ccce4"), "107", "4730592210962995", null, null, new Guid("6ab8f9db-6513-4d8f-9cde-7b925ff51057"), "05/04" },
                    { new Guid("558f67a1-f88e-402b-be48-4711b558254f"), "371", "9083241416398423", null, null, new Guid("dc2b5eaa-01f8-425c-874d-15e523189cc1"), "03/10" },
                    { new Guid("559b4c9c-e5ee-4821-8466-fae617ffe217"), "094", "2568533197488889", null, null, new Guid("108fbff3-4041-4eed-b2a0-4a4b1fb47787"), "10/24" },
                    { new Guid("5601d48a-98da-4ff0-9eaa-154c2b715f8c"), "561", "2499058966687536", null, null, new Guid("a943e809-55d9-482f-a592-8709b5f7d47f"), "05/03" },
                    { new Guid("5641c920-f24c-4ff4-89c2-89d8bdebf235"), "774", "8262798357105864", null, null, new Guid("4083c32d-a4cd-4c70-b794-fa7b97aafe4e"), "03/07" },
                    { new Guid("56602f95-0fb1-4606-849d-a1138c43b684"), "054", "7384282490410386", null, null, new Guid("3ff3d88e-b078-4f3a-8312-8447eeb772e2"), "02/09" },
                    { new Guid("569a2706-83ba-4114-9fce-ad04cfd29e72"), "686", "2515517786393209", null, null, new Guid("64e0a0ed-41a2-429f-800b-6407610d5984"), "12/08" },
                    { new Guid("56c263d6-7157-4ed4-8c5f-e5cbfaea2686"), "623", "1829862172159921", null, null, new Guid("a419df27-9358-4a02-9ab7-2f2e2344fae0"), "07/04" },
                    { new Guid("573a1c62-901e-4396-9c4b-332e361c7731"), "350", "9309665322152426", null, null, new Guid("757f3f70-fdce-4727-8fcf-9ac8aa0287b3"), "06/09" },
                    { new Guid("5775af1c-139c-433b-b9e7-973efcef3078"), "003", "2506841439251281", null, null, new Guid("080ced29-2e70-40de-82e4-0a2d478fe53e"), "05/04" },
                    { new Guid("581055cf-5649-42d3-a1f3-1344e888003b"), "948", "7022565231225492", null, null, new Guid("92d6cbc1-d409-403c-b274-517d31726ae9"), "10/12" },
                    { new Guid("583c8ead-d3e7-4b1a-8581-e6ec791a3397"), "387", "3564443994490783", null, null, new Guid("087fb413-124f-47b1-b54e-4bdedf2edf63"), "08/05" },
                    { new Guid("58733c44-be1c-4c27-ad24-f7847d2d21f9"), "261", "9322706320311049", null, null, new Guid("97e11482-d5e6-41d7-82e3-80806df9c3bc"), "07/06" },
                    { new Guid("58d7d30f-f1da-40d5-b033-1505ade648e0"), "733", "7011833676825686", null, null, new Guid("4d006d0d-8a50-4d81-886b-176313d018fb"), "01/15" },
                    { new Guid("58e62a27-55ab-4299-b9de-4185ede2e08c"), "040", "4436831854805130", null, null, new Guid("40a279f6-73dd-4fa2-8b1e-05f9cd8bdcf9"), "03/24" },
                    { new Guid("5919b53d-8507-45f1-8d4e-89e3846ea316"), "952", "4852730678609871", null, null, new Guid("8c30b7e6-1da3-4a5c-87ba-544b9377a290"), "04/16" },
                    { new Guid("598d0394-349c-4761-9901-8fa35d9eaee1"), "070", "6900703254744940", null, null, new Guid("0e7742f2-e964-4e8c-b692-4ffb75ece318"), "08/25" },
                    { new Guid("59b2fc6a-6056-40e4-8f6d-3338cd50d7f0"), "857", "7859261098768084", null, null, new Guid("d0aae9a2-8c5b-48e9-b856-e309c80cadae"), "11/15" },
                    { new Guid("5a95b9d9-0709-427c-828a-d7e13afbe6a6"), "735", "1942652129730177", null, null, new Guid("141e6ca1-3b19-4ffc-a21f-8420c3f6db52"), "01/07" },
                    { new Guid("5b4bb219-6527-4cf7-96d9-1926508f94cb"), "664", "7730399723740426", null, null, new Guid("f7dacdb6-cd5e-4c55-a2df-710f582d75f2"), "11/15" },
                    { new Guid("5bc72ada-b24b-4653-9d68-b20be889fae2"), "989", "6621774227066543", null, null, new Guid("50b1b40f-32d2-45da-a690-b9d24fff476e"), "11/09" },
                    { new Guid("5bcd9571-1bba-4bfc-b8a8-7ad006e193af"), "548", "7548008446237098", null, null, new Guid("76c44275-2d3e-43e9-b34e-c05f912213b8"), "08/16" },
                    { new Guid("5c0d5302-aee0-41b9-bb4c-577678922424"), "531", "4068775605228834", null, null, new Guid("719d1670-ba7d-4e9b-b4de-d7074f81aa66"), "09/12" },
                    { new Guid("5c2905c4-b535-436d-89d5-44886d09eafa"), "287", "7904035028125252", null, null, new Guid("8f35c799-d964-48e4-9cf8-befb4f9b7bf0"), "03/28" },
                    { new Guid("5ca6805d-86b8-4d38-be53-3121862c7038"), "659", "3683993385576797", null, null, new Guid("2bdbd536-e4dc-4869-9dac-f62a098ecb05"), "08/24" },
                    { new Guid("5cb1198a-5c87-47e0-9a51-a5311145fe81"), "929", "2623665259865929", null, null, new Guid("6f109fcf-941c-474c-810c-243f75df54d6"), "04/19" },
                    { new Guid("5cbc5527-49c8-4752-b7dd-8061068b9fda"), "896", "5115550910327040", null, null, new Guid("4efd0f6e-db18-4603-b7c2-f032eb9132a9"), "09/18" },
                    { new Guid("5d378df7-2a45-41c2-8fb6-885e6201a485"), "776", "1810807345519347", null, null, new Guid("7de3e658-53a0-464d-a4aa-b7bf40828f5d"), "02/23" },
                    { new Guid("5da64cb9-3cb3-417a-84d3-62a419f9862c"), "284", "5380562212672855", null, null, new Guid("dd550cd7-4eae-4d75-8be5-5f3e496fdd24"), "03/27" },
                    { new Guid("5e098023-090b-42f1-9e95-eb55b5b9ecff"), "003", "6867629066994554", null, null, new Guid("a9090dd7-3795-48e2-837b-9a72a0274d7b"), "11/06" },
                    { new Guid("5e9e254b-0bb9-469e-868f-b2262c76bdb3"), "565", "9647238274357168", null, null, new Guid("40a279f6-73dd-4fa2-8b1e-05f9cd8bdcf9"), "12/13" },
                    { new Guid("5ea3c2ca-13e6-4b44-9375-f9749ae353af"), "837", "7569557916344880", null, null, new Guid("1bab23ea-659b-4531-ad24-fdfd8984675d"), "03/10" },
                    { new Guid("5ed57f55-b937-4395-8bbb-58b966dc2755"), "215", "4450473828333482", null, null, new Guid("67a258f9-5c48-4651-8f32-1ee7f5b4246d"), "12/06" },
                    { new Guid("5f55e583-b835-4fe4-8d28-1a9aed11a32e"), "571", "7176119028143610", null, null, new Guid("482632b6-5f62-4fe4-82e0-1b6f0d3ee842"), "07/19" },
                    { new Guid("5fb1606d-d865-43cd-9d7e-084f0fbaba45"), "639", "6912459892309754", null, null, new Guid("b1817475-7a6c-44d8-8e81-4b59b1f4923e"), "06/05" },
                    { new Guid("60462ac6-5acb-4956-9c06-d5515bf362c8"), "094", "8938836722105021", null, null, new Guid("b1817475-7a6c-44d8-8e81-4b59b1f4923e"), "11/16" },
                    { new Guid("605923fe-1ce6-4ef8-ab22-d07747bce866"), "956", "3067082588198582", null, null, new Guid("7e4a74cd-b47b-47e6-ab98-22ed32bd8e27"), "10/27" },
                    { new Guid("60646224-d668-4e6a-8949-c04496be6777"), "563", "4495280773601942", null, null, new Guid("230e73b5-4a4b-4b1c-ad48-f7a0074303c7"), "12/28" },
                    { new Guid("6076c33d-acc1-403e-a009-1def1e131792"), "911", "9571879564949239", null, null, new Guid("78be92c8-3390-4d5e-aa3a-54c7301eaf2f"), "12/12" },
                    { new Guid("60776905-656d-4b46-a7d9-a25116aa744a"), "036", "4465732642706999", null, null, new Guid("f5fa9239-e966-4c8e-9eb5-32ecf277976e"), "05/12" },
                    { new Guid("609d248b-9026-43c2-89b7-54aa0a572c9d"), "953", "6247358225886938", null, null, new Guid("ed5c634a-32ee-48fd-80f4-26cfb1c72602"), "03/20" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("60aae012-f8c5-460d-8f07-3536fad8e658"), "667", "2398154890411717", null, null, new Guid("3ff3d88e-b078-4f3a-8312-8447eeb772e2"), "05/26" },
                    { new Guid("60bb5543-12e9-4606-aaa5-0f5d0a2671af"), "030", "7423287463795206", null, null, new Guid("22edc826-6747-4099-aca5-578199353ac6"), "04/21" },
                    { new Guid("60d94d42-a9be-488f-af0e-4ee39d048df4"), "585", "9908385855893879", null, null, new Guid("ddf2bc3e-21a3-4bd8-8ebc-4afb8cb49df0"), "01/12" },
                    { new Guid("61761a9d-4e02-41a0-9b83-64dbc9720ba6"), "205", "1675171637643557", null, null, new Guid("66da7f26-36d5-4406-a2e4-35363c8e43cb"), "04/13" },
                    { new Guid("61915fdc-3d18-4c2a-8ccf-642c79038bdb"), "370", "6780263115446583", null, null, new Guid("df1ba0e6-99b8-419d-a3b8-cece7c4928bd"), "09/19" },
                    { new Guid("6219e836-5085-4070-b606-fab2b5b671fd"), "450", "9147361473702566", null, null, new Guid("64174d68-43d3-488f-89bf-23d32b134019"), "10/18" },
                    { new Guid("622beb8e-ea66-42ce-ad47-1543a76f0669"), "585", "8240575861637956", null, null, new Guid("affd1717-742a-4014-8e72-3420c7496c1e"), "01/18" },
                    { new Guid("62456a21-1e87-4072-9511-3b554affe8b1"), "561", "1237622124511582", null, null, new Guid("06f4c32b-9a3d-4b38-99a4-56ea0ba685a8"), "03/04" },
                    { new Guid("62949f3e-0bde-40b8-8489-38cd51f3cd1e"), "189", "4295232991085318", null, null, new Guid("f7dacdb6-cd5e-4c55-a2df-710f582d75f2"), "01/18" },
                    { new Guid("6422035b-ad6a-4f51-be05-a4ac0a121f69"), "340", "5157008661323693", null, null, new Guid("25c234e8-8d95-42b3-9dc3-c418fbcaa7da"), "04/04" },
                    { new Guid("6494e371-fa0b-462d-acc4-7363f895df60"), "245", "9214264498582084", null, null, new Guid("bbaf9fe2-9863-4589-964a-23c62e6bf830"), "07/16" },
                    { new Guid("64c4f7e9-f7cb-41da-80b2-e1bd2c0d9e6f"), "115", "4981473530175093", null, null, new Guid("335c9d28-42e2-4d49-9686-f0cd1b972fae"), "03/16" },
                    { new Guid("64c599e3-9a20-4547-a2ed-f1726cd70921"), "390", "2897991000433541", null, null, new Guid("5d1e2a88-0f0a-4b6e-a524-e279224a1944"), "09/06" },
                    { new Guid("64c93823-eb13-418d-bbbf-baf407af42dd"), "496", "4599673867781545", null, null, new Guid("c36bd526-4a45-4a4b-9d0e-50c279e9b939"), "03/21" },
                    { new Guid("64cce33a-41da-463d-8b8d-4fc14aab7524"), "670", "2025358316325014", null, null, new Guid("99d3bf2d-5ff0-41e8-b115-9bf94eab6881"), "10/18" },
                    { new Guid("64d1bbf4-66bb-454c-9b23-7902f3d82e43"), "066", "9802721148975747", null, null, new Guid("32feb777-af06-4813-9108-9d7acfd0bd04"), "10/01" },
                    { new Guid("652d3b8f-7e39-4eaa-8018-6cab80e67bb3"), "168", "5633425197900649", null, null, new Guid("0635daf3-649c-437b-92ef-713d43246a0a"), "12/03" },
                    { new Guid("655b9462-9aa8-4ef2-bc09-adbcf7e06258"), "180", "8066482098193032", null, null, new Guid("1cdde210-cf9c-4b69-a64c-3995a2267739"), "06/13" },
                    { new Guid("6599be21-ec1e-4745-abe9-ac48d05c91bb"), "802", "8737203650118787", null, null, new Guid("323967f9-cf4e-4818-a5bf-94dff7ea728b"), "02/12" },
                    { new Guid("661cd2bd-65ac-457d-b060-6546c29a2517"), "495", "5541925769881026", null, null, new Guid("108fbff3-4041-4eed-b2a0-4a4b1fb47787"), "02/25" },
                    { new Guid("66714d11-bb7a-4bd7-8a2a-aa578510aa64"), "955", "3334017725778142", null, null, new Guid("3a19b458-72b3-4b5b-97e6-334a56d7d557"), "08/28" },
                    { new Guid("668ab186-a87d-457d-9893-0908cc4014d8"), "314", "3457738307826838", null, null, new Guid("cf348fa5-7d32-48ec-957c-eb481beb0358"), "06/20" },
                    { new Guid("66cfea50-dcfa-4f4c-87e9-23bbfbb91dcf"), "767", "6421071510656181", null, null, new Guid("d1d503de-e688-46df-9a53-6ca07b1d716f"), "02/02" },
                    { new Guid("6702de58-4cd6-49cd-8ba1-9d024b0827dd"), "692", "2943456545690661", null, null, new Guid("f2c5c231-fa4f-4403-a17b-f986cd15543a"), "09/09" },
                    { new Guid("673f08de-09a3-4905-af84-37723cc764cd"), "622", "3046227170861694", null, null, new Guid("9e96d314-cd64-47aa-a5bc-7e0525cc9914"), "10/13" },
                    { new Guid("68d98ac4-5fc6-478b-b178-005704032321"), "027", "8363244178263532", null, null, new Guid("a03e50af-2ee0-4392-86e9-a0420b2f24bb"), "07/22" },
                    { new Guid("68e1e484-0432-494d-b1d7-aef630d752c8"), "461", "5911614709130287", null, null, new Guid("672ce079-171b-4f7e-b744-6b9376e96b61"), "06/19" },
                    { new Guid("6a0e8622-7fbb-473d-8037-5d7513bbb16d"), "781", "4403608939043725", null, null, new Guid("0bf479c3-ab54-4392-b19e-a71b3942b7fe"), "02/02" },
                    { new Guid("6a39b7e8-3f95-46ee-8d8f-8d1c959762d7"), "304", "3529153878895529", null, null, new Guid("0d230077-5e9b-42d8-a83a-650a22378849"), "10/25" },
                    { new Guid("6a3e086c-db0b-4582-9323-703577e311a0"), "535", "1790077141932519", null, null, new Guid("c5513371-ea13-4b3b-ab65-8bbb471b2afc"), "04/27" },
                    { new Guid("6a44e3f1-9cc2-48d9-afcc-c14710ed59b2"), "859", "8405631661563323", null, null, new Guid("32feb777-af06-4813-9108-9d7acfd0bd04"), "12/16" },
                    { new Guid("6a84d0c4-e149-4b05-93e6-ce6e01dff234"), "973", "8360627648546471", null, null, new Guid("ac984856-387b-48de-9d39-5cfa956d354e"), "04/14" },
                    { new Guid("6ad106e3-7b50-4dcd-91c7-b2596b96a793"), "514", "2339304918145433", null, null, new Guid("aeae0f68-579f-46b8-bee2-c797ee09ee5e"), "06/13" },
                    { new Guid("6b7f4c15-60a7-4a87-9bb4-e5f2e8ae46b2"), "510", "9969993953546041", null, null, new Guid("54c975d2-dbfe-4626-97fa-ceaa28e85030"), "05/20" },
                    { new Guid("6b962b0f-fbb5-4c92-a9d7-3bb7d67493de"), "069", "5152276121580135", null, null, new Guid("980189d0-dcc8-4676-93bf-39ec81288e2f"), "02/07" },
                    { new Guid("6bf79001-b4d7-4f30-803c-a95eb79a3de8"), "598", "7517685531781962", null, null, new Guid("182bd5c0-616f-4e9b-8837-7c2b67e01496"), "08/10" },
                    { new Guid("6c4b0344-4478-4fb8-9a7f-fa45c5fc9cf1"), "778", "5665557454251933", null, null, new Guid("753e85fe-b18a-442a-b91e-1d9dc9216d93"), "03/27" },
                    { new Guid("6c4cf5bc-13d4-41a5-bca5-9f26482d0dda"), "187", "9349016554401877", null, null, new Guid("c0ff772c-b38f-4860-9c1e-4c49d424f9a5"), "12/18" },
                    { new Guid("6c628ec0-0480-4822-b079-90d1de63e496"), "773", "6523678990502675", null, null, new Guid("56c8b4b0-c1db-425e-a349-2f7b3feabb5e"), "01/22" },
                    { new Guid("6ca43b5f-af3f-4733-afbe-425743d8a296"), "702", "5072224466782522", null, null, new Guid("ac4ee7ff-56c7-4c45-ba3e-32ed6d9370f3"), "04/03" },
                    { new Guid("6d123667-b079-4551-a4d0-e5ecce42091a"), "509", "2793786871437325", null, null, new Guid("6101631f-7cf2-4393-a938-099c07dbe44b"), "09/17" },
                    { new Guid("6d155900-ce40-486e-9722-34a61833a561"), "260", "9638785767217023", null, null, new Guid("aeae0f68-579f-46b8-bee2-c797ee09ee5e"), "01/26" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("6d2637e9-4600-4ee3-8218-7d8b151e4e05"), "466", "6701865345689550", null, null, new Guid("0776f148-3954-48ff-8bb8-772d353c1a3c"), "07/04" },
                    { new Guid("6d298199-c6ea-4342-a7e2-c0cc7e66109c"), "730", "2547929284228202", null, null, new Guid("c88c725e-8cbf-416d-a4bf-153a024ea6c9"), "05/09" },
                    { new Guid("6d38fb25-1263-43e4-94f9-7ffb63524224"), "450", "8128218318727097", null, null, new Guid("496d8ed2-fc6d-49e6-b902-8a1d0b266928"), "12/03" },
                    { new Guid("6d41ee28-6a48-4b12-a7f5-1ec59255f1f2"), "028", "6456273167568927", null, null, new Guid("42c4353e-7775-4c68-a647-2b921bb87c89"), "09/12" },
                    { new Guid("6e38d7bc-9cd5-4f79-b153-5c37e7c93fdf"), "987", "5300260521592979", null, null, new Guid("2411a1da-d71e-4e02-a40e-984ec689c7bd"), "09/19" },
                    { new Guid("6ec29f99-178a-4d66-9da8-55ad1c92a161"), "287", "5046159696240382", null, null, new Guid("c88c725e-8cbf-416d-a4bf-153a024ea6c9"), "11/10" },
                    { new Guid("6ef3989c-2dae-41b9-9031-31c97c688d31"), "345", "2927702590273231", null, null, new Guid("75ba16eb-aa9c-4c6f-90ae-1515360055a9"), "12/19" },
                    { new Guid("6f473ac3-3d52-413a-93a2-fde9992ef51d"), "612", "9472322371066790", null, null, new Guid("3a6fda52-d9f1-418c-8ffa-69974f7f39be"), "09/17" },
                    { new Guid("6f4dde62-8544-43ee-ad3c-65d90d567140"), "250", "6937973261346975", null, null, new Guid("9ff0a0ca-02d0-4209-bb8f-a0d7efaf75bb"), "09/04" },
                    { new Guid("6f75db64-3ad4-4bf4-aea7-cb7a8e7b3f0f"), "584", "2628327728846257", null, null, new Guid("1937fdf7-97b0-4102-95c9-2163eb910112"), "04/09" },
                    { new Guid("6f778e2e-572c-47e0-b5cd-1d1f1143eea2"), "795", "1737169131343586", null, null, new Guid("871feb78-0a5f-4d88-8754-a386270f590d"), "03/22" },
                    { new Guid("6fcc0fd6-c5a2-4a06-9709-84bb92f9ffc6"), "330", "4057937682546019", null, null, new Guid("3a262ff7-1654-4c72-9285-3ba10eac6509"), "12/14" },
                    { new Guid("705afee1-357d-4571-b5fd-fe77cbee44b6"), "537", "7732855441089958", null, null, new Guid("93e9e8fa-8b76-4968-a1ef-a4d59b6958ea"), "10/08" },
                    { new Guid("70618934-8b4d-48ef-9eb7-2dff2028c4b2"), "247", "1438731212548000", null, null, new Guid("4a9e17b4-cb0f-4c82-80d2-e1d56fe06f0a"), "07/02" },
                    { new Guid("7095cbde-08e3-4312-a6c1-87fbab2af9ed"), "167", "4454101153776460", null, null, new Guid("0a1370d0-5d3b-4609-9efc-9507f4acc2f8"), "04/16" },
                    { new Guid("7161f8a1-9f17-4bed-8dca-ec93f69f9b58"), "017", "6202592183166206", null, null, new Guid("40a279f6-73dd-4fa2-8b1e-05f9cd8bdcf9"), "11/24" },
                    { new Guid("717eaf57-ef78-40b9-8ca0-9398daf284ad"), "588", "1170317006869864", null, null, new Guid("ddf2bc3e-21a3-4bd8-8ebc-4afb8cb49df0"), "01/15" },
                    { new Guid("719288b7-ab1f-4234-932b-a61b0d4fae12"), "322", "7916275138247738", null, null, new Guid("08589d86-24cf-48ee-b140-eab54649e215"), "01/16" },
                    { new Guid("71db9e90-8f45-4fff-a7d7-df51d6857abb"), "159", "5988996094336299", null, null, new Guid("94c09a0c-18a4-40c8-9285-032386267d16"), "09/14" },
                    { new Guid("720fbbf1-36f3-4200-ad97-aa1a642cb217"), "676", "5181241983807441", null, null, new Guid("77bc83c5-7598-48f0-b4c1-23f76fd277ca"), "11/08" },
                    { new Guid("72d9ebdc-96f5-4d17-8426-97b89c0a5b92"), "373", "5298666987270038", null, null, new Guid("0447d1d8-3e48-4d64-8d2e-7d9a733628ec"), "11/19" },
                    { new Guid("72f37673-1ad8-4e3a-a75e-0b85f6ab6176"), "540", "7788128016843095", null, null, new Guid("c2701daa-7747-422a-bb74-d9ffc8e0f5fc"), "09/10" },
                    { new Guid("7305ff4f-f195-4248-bc2b-1029891de558"), "813", "4403408575518261", null, null, new Guid("bd07490e-79db-4063-b992-0fa27e7f7677"), "12/28" },
                    { new Guid("7321f2d1-df0d-49af-b0d4-dee52dcb5e73"), "520", "2921795085629513", null, null, new Guid("8c060e9b-2ea2-4602-8535-ce147e60fcbd"), "08/01" },
                    { new Guid("732e36f7-ed09-41f9-8256-4e72a3a39f73"), "059", "7231042367199640", null, null, new Guid("1937fdf7-97b0-4102-95c9-2163eb910112"), "12/02" },
                    { new Guid("744420b5-8296-4869-9dbf-fc9196591b0d"), "382", "1066719741168750", null, null, new Guid("7778b4eb-db56-4ddd-a0bc-5f46aff077f7"), "08/03" },
                    { new Guid("7481da51-8ac4-4cfb-8e0b-2e43f7fe36c5"), "316", "8051738212794228", null, null, new Guid("fcf05f51-7f3a-4331-a0f5-6204db62e7ba"), "10/25" },
                    { new Guid("755db2a6-f6c6-4cbb-86c6-275c596dd3bc"), "791", "5121013696557170", null, null, new Guid("e764f5ca-90fe-4d60-aab1-e56e02a1f110"), "10/06" },
                    { new Guid("75bb83f0-3076-4fcd-b0a7-bdd31b1f9632"), "060", "3873206223738200", null, null, new Guid("d0aae9a2-8c5b-48e9-b856-e309c80cadae"), "04/15" },
                    { new Guid("75e92d3c-457f-438b-8c4b-36cfe86c98bc"), "700", "1127968778555293", null, null, new Guid("8f35c799-d964-48e4-9cf8-befb4f9b7bf0"), "07/15" },
                    { new Guid("765386f9-f713-4729-990c-b6cb1e71166c"), "856", "1386719224897121", null, null, new Guid("75ba16eb-aa9c-4c6f-90ae-1515360055a9"), "02/09" },
                    { new Guid("76706898-d278-4fda-affc-82c49c18da94"), "554", "6682943554065861", null, null, new Guid("ce7719fc-1874-4df0-88ba-9b5637945029"), "02/18" },
                    { new Guid("76bcba4a-88ac-4279-be71-3c5351233b21"), "906", "7285220899134696", null, null, new Guid("c2701daa-7747-422a-bb74-d9ffc8e0f5fc"), "02/12" },
                    { new Guid("76f0f502-d017-494f-822b-d3cac64962d6"), "448", "8442454918720993", null, null, new Guid("c221f46b-a606-417e-aead-c8b255d84d11"), "09/15" },
                    { new Guid("774641c9-7ad4-427e-ba35-ae297c1c600f"), "035", "6579617087554169", null, null, new Guid("815c5bf5-7253-492e-81c8-82e2d6860602"), "06/17" },
                    { new Guid("7746cb1d-42f2-4a81-99aa-094c978fdf63"), "468", "1367389539079515", null, null, new Guid("182bd5c0-616f-4e9b-8837-7c2b67e01496"), "12/02" },
                    { new Guid("7800ea76-211c-442f-a510-85dc1cdbd699"), "997", "3873310841534225", null, null, new Guid("25c234e8-8d95-42b3-9dc3-c418fbcaa7da"), "01/14" },
                    { new Guid("7803fb93-24ac-4862-8c9f-d5b9c968dd6a"), "987", "6141667106016931", null, null, new Guid("4b2a14c5-b9ad-4e45-ae16-0762e7d1e215"), "05/12" },
                    { new Guid("78271406-c008-4c29-bb30-67eac6969012"), "628", "8476182739220338", null, null, new Guid("07e77ffa-7983-4cb3-bfa5-a4b8ed39f91f"), "10/10" },
                    { new Guid("784fcbb1-6174-4b47-bb98-cab1372b1ac7"), "227", "6511457214152916", null, null, new Guid("50ac14d1-c13d-42f2-8026-301c38b1964b"), "11/15" },
                    { new Guid("78682d60-62ef-4232-97f0-b66ba779bbf6"), "980", "1950744290143842", null, null, new Guid("4ecad1f7-2b37-4dd8-be42-dedd60205e81"), "03/06" },
                    { new Guid("78bb5c5c-78a5-485e-ad9b-7a9dc5f10df9"), "018", "9777267761703242", null, null, new Guid("097cb7d3-d333-48aa-b8ee-cacd11ee91fa"), "10/03" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("78e1c64f-bda0-4526-9745-93e1d0ed55fe"), "711", "8184586823371233", null, null, new Guid("482632b6-5f62-4fe4-82e0-1b6f0d3ee842"), "11/10" },
                    { new Guid("79194696-6b4f-4d49-84f3-9d699078336b"), "560", "3081024180023928", null, null, new Guid("57b666b4-3a1b-4303-851f-a88f5f534543"), "02/17" },
                    { new Guid("79e1225d-b573-4f1c-b7a0-40e9e1c0c8bc"), "661", "1893577854858208", null, null, new Guid("9b254af5-9da3-4b42-a5f3-b573df408d84"), "07/01" },
                    { new Guid("7a24ee46-d42e-42a1-b023-cd1c88e1802f"), "113", "6295529934321499", null, null, new Guid("487f0344-4cde-4b10-971a-1f8311cce3f5"), "05/20" },
                    { new Guid("7a5446a0-a17b-4c38-975c-152b102f796c"), "579", "9610352496099345", null, null, new Guid("530579fa-33a7-4827-a21f-b9cacab42c7d"), "02/24" },
                    { new Guid("7ac22d0f-2298-4c85-a89d-46bdfeb8ff08"), "411", "5174231988201738", null, null, new Guid("831f8f9d-e78d-4f72-8b48-1c32c42fda1b"), "12/03" },
                    { new Guid("7b6267a4-e9d3-4ad9-b72f-5aa467df4178"), "693", "2405313204350205", null, null, new Guid("07e77ffa-7983-4cb3-bfa5-a4b8ed39f91f"), "01/11" },
                    { new Guid("7b70b629-b28f-4629-88f7-866e139b8c11"), "126", "7890666384758775", null, null, new Guid("01424fda-76cf-4203-995c-a75e43c1d1d0"), "01/23" },
                    { new Guid("7bac33da-6ecd-4f01-b8be-1d4ff7b3da8e"), "551", "9856863882287390", null, null, new Guid("71f7fb3b-e7f1-4325-bdd2-98f71dd515b1"), "04/17" },
                    { new Guid("7bcc228e-9d4b-4188-98b2-9aa5f813e0ac"), "347", "4531250108465373", null, null, new Guid("9ff0a0ca-02d0-4209-bb8f-a0d7efaf75bb"), "10/11" },
                    { new Guid("7be3decd-1409-4f48-8bb6-8435178c1b8b"), "982", "4547830833579454", null, null, new Guid("3a6fda52-d9f1-418c-8ffa-69974f7f39be"), "11/07" },
                    { new Guid("7cd74c2a-bc8b-46c7-8b78-56e2ca0a5e72"), "663", "7300298956109362", null, null, new Guid("b5cca55a-d81f-47be-b0b4-50d07e79ce69"), "12/20" },
                    { new Guid("7cdfbcdd-64dc-4ac5-890c-bf32a073e0e8"), "877", "1323432099515371", null, null, new Guid("6f196aeb-f350-478e-a23f-992b0ea6da29"), "03/02" },
                    { new Guid("7d12851a-9a54-490a-a66c-fc21c242e8e7"), "933", "8384257398927417", null, null, new Guid("42c4353e-7775-4c68-a647-2b921bb87c89"), "09/19" },
                    { new Guid("7dc64863-9b9c-4e14-a03e-ccf64bd89606"), "584", "3319260012800268", null, null, new Guid("dc52bf7b-d952-45c3-8bf0-44dadbfbb09e"), "07/24" },
                    { new Guid("7ddaff16-615f-458a-a940-12ed286e43dc"), "242", "2294726002312513", null, null, new Guid("48f4af12-c8b0-4444-98ca-81df5d349e01"), "06/15" },
                    { new Guid("7de0f7af-628c-4ded-baf8-88a4bd4cdb07"), "015", "5102146060179130", null, null, new Guid("6ef84803-7ff7-46d1-b1b3-ebda82e158b3"), "11/04" },
                    { new Guid("7de61cb7-9a93-4f7b-9a51-2bb38e190dc1"), "183", "2573959396431089", null, null, new Guid("6c3e0836-290a-4c10-8832-91720a2e9054"), "08/27" },
                    { new Guid("7e02742c-0de0-4778-8226-8d619f2f5743"), "330", "4368652600094804", null, null, new Guid("9ff0a0ca-02d0-4209-bb8f-a0d7efaf75bb"), "11/21" },
                    { new Guid("7e247b7a-0d57-46f1-9aee-63756c121f29"), "660", "1190776372600597", null, null, new Guid("757f3f70-fdce-4727-8fcf-9ac8aa0287b3"), "03/27" },
                    { new Guid("7e30c545-82b1-4c7c-b229-acdef1dc1ab4"), "042", "8438778272891752", null, null, new Guid("c6e8a5d8-6660-4e85-9ff9-1e6ec6d0c580"), "02/14" },
                    { new Guid("7e9bd0aa-c90f-4be4-af0d-034c8894b01d"), "225", "6800885405980648", null, null, new Guid("50fa1a40-d4af-4edd-8c00-61ec693395b2"), "02/20" },
                    { new Guid("7eccfb4f-cc67-4b24-8c5b-317508476532"), "449", "2032641354615111", null, null, new Guid("539c62ee-15fc-4d37-ab5d-0e4126109954"), "11/26" },
                    { new Guid("7f2e6994-3634-4c93-a68d-127bb194709a"), "115", "6352837454028282", null, null, new Guid("c66d96b2-e569-4470-a3b9-82ba83e46c97"), "12/23" },
                    { new Guid("7f6025bc-751e-4420-8d29-87833e5bc1e3"), "673", "6074341850326043", null, null, new Guid("2bdbd536-e4dc-4869-9dac-f62a098ecb05"), "03/01" },
                    { new Guid("7f70ce81-257e-4f13-9236-7bc523c7ebc5"), "389", "4181961997334165", null, null, new Guid("57b666b4-3a1b-4303-851f-a88f5f534543"), "06/05" },
                    { new Guid("7faab371-945c-4c0c-bd44-2c6a640d408e"), "284", "8004548413382792", null, null, new Guid("92d6cbc1-d409-403c-b274-517d31726ae9"), "10/19" },
                    { new Guid("7fd64d53-8a4a-433b-9d5a-b20114a5e331"), "209", "5828263283214933", null, null, new Guid("4083c32d-a4cd-4c70-b794-fa7b97aafe4e"), "12/09" },
                    { new Guid("80d4de1a-81f6-48df-8dbf-f0f2ef3faac3"), "037", "9363244517830520", null, null, new Guid("141e6ca1-3b19-4ffc-a21f-8420c3f6db52"), "12/23" },
                    { new Guid("812f072f-ba67-4a60-b2d0-e472e881555a"), "246", "7218789678427531", null, null, new Guid("75ba16eb-aa9c-4c6f-90ae-1515360055a9"), "11/15" },
                    { new Guid("813acfac-556b-497f-afbf-57fec95a7e2c"), "427", "7950778971666148", null, null, new Guid("b40d8226-58de-4e86-811d-0e6b38686d57"), "06/04" },
                    { new Guid("8162284e-d3ac-4b59-b952-b13335353522"), "119", "5107409621128674", null, null, new Guid("c66d96b2-e569-4470-a3b9-82ba83e46c97"), "02/13" },
                    { new Guid("81817f45-dada-444a-86f3-1cfbb0b6596a"), "516", "7324345482906557", null, null, new Guid("b1817475-7a6c-44d8-8e81-4b59b1f4923e"), "05/09" },
                    { new Guid("8181b3e5-ca87-4ca8-ade5-51ba3b49bca1"), "268", "5738430598389508", null, null, new Guid("e5fa7b3b-6d8a-43dc-88a3-403aed558476"), "09/14" },
                    { new Guid("8234ddcd-b6fb-4791-a19c-ddc2b0e7520d"), "688", "7263902854515587", null, null, new Guid("56c8b4b0-c1db-425e-a349-2f7b3feabb5e"), "02/11" },
                    { new Guid("823e34a2-378b-414e-b2dd-550b17ea3c3a"), "661", "4623441509349532", null, null, new Guid("1cdde210-cf9c-4b69-a64c-3995a2267739"), "12/04" },
                    { new Guid("8244f7cd-0849-48cd-9f18-fd7d50e0c579"), "111", "8553028269453018", null, null, new Guid("93e9e8fa-8b76-4968-a1ef-a4d59b6958ea"), "12/28" },
                    { new Guid("825e5892-d795-4735-bb8c-2e6beb451b95"), "770", "3579242169081888", null, null, new Guid("e5fa7b3b-6d8a-43dc-88a3-403aed558476"), "02/22" },
                    { new Guid("827ba9c3-30e1-4863-bc73-00e85798a739"), "210", "8324969699431550", null, null, new Guid("6b5cd903-9056-4302-b3e6-b910c3a67f76"), "09/11" },
                    { new Guid("82c14d6a-9ff3-43dd-9cdf-8a8136c7a8e6"), "623", "4209617402144099", null, null, new Guid("df1ba0e6-99b8-419d-a3b8-cece7c4928bd"), "01/19" },
                    { new Guid("82c1eb47-138d-4cb4-922d-a6625d648e23"), "310", "6105140560026426", null, null, new Guid("0ec010bc-7e48-4cb9-bb93-8dd9d5b37f6d"), "06/16" },
                    { new Guid("83d32bb6-902d-48d9-b63b-38ad4e634a37"), "198", "2766028452060036", null, null, new Guid("8c30b7e6-1da3-4a5c-87ba-544b9377a290"), "06/28" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("83dac12d-4170-4f52-b1c4-1f4c6b4f7d6e"), "343", "9168219258953160", null, null, new Guid("0b65bf95-8c8c-4e28-8317-122f0f66a78e"), "01/02" },
                    { new Guid("84313aed-2afb-42ec-aee9-79409e362180"), "779", "2160622241454130", null, null, new Guid("8dca8632-b27c-44ad-bd6c-0d7679a4f075"), "12/24" },
                    { new Guid("861ce60d-1eac-4c20-bd78-b1503741ef95"), "309", "4776625836266604", null, null, new Guid("3712e35b-2da9-4c76-ad88-28828e776a5c"), "10/13" },
                    { new Guid("86aec64a-c563-478e-89b6-f88f2f9259e2"), "840", "4142086784041693", null, null, new Guid("d40492c4-d582-4ce6-943c-a487675b7960"), "07/21" },
                    { new Guid("86c2ba70-08a2-4957-921a-63ab9a63436b"), "270", "4693209875612557", null, null, new Guid("bbaf9fe2-9863-4589-964a-23c62e6bf830"), "11/22" },
                    { new Guid("871b5081-6b36-4129-81ef-5543578777fe"), "990", "5144596406931403", null, null, new Guid("c58f524e-a96e-4e8b-9186-6c21d38d64b3"), "05/19" },
                    { new Guid("877777ef-e9d4-46ec-874c-d08cdc05cac2"), "363", "4697704347123273", null, null, new Guid("2bdbd536-e4dc-4869-9dac-f62a098ecb05"), "08/07" },
                    { new Guid("880fee17-76fb-47b3-a520-d9d7cc9dcc86"), "116", "3089571670273065", null, null, new Guid("c6e8a5d8-6660-4e85-9ff9-1e6ec6d0c580"), "05/19" },
                    { new Guid("8859cb5a-f9a6-473c-8d57-3554923d1bc4"), "224", "5031433324605678", null, null, new Guid("adbbd240-641f-475b-b705-5e35298ef012"), "08/26" },
                    { new Guid("88e621d6-da9b-461f-a053-f67fd76764d3"), "732", "3922154283197012", null, null, new Guid("ce7719fc-1874-4df0-88ba-9b5637945029"), "07/26" },
                    { new Guid("89aa9232-e2eb-4a81-88b0-556cf886c3d9"), "477", "2763115655793499", null, null, new Guid("335c9d28-42e2-4d49-9686-f0cd1b972fae"), "02/07" },
                    { new Guid("89e1074e-36c9-46c9-98b0-353219adabad"), "437", "6220450272547691", null, null, new Guid("10766e70-305e-4e2a-8560-ffeb596a93eb"), "05/03" },
                    { new Guid("89fae071-b17b-4f75-bd14-9bf0ab0f945b"), "561", "9152530207176151", null, null, new Guid("34e9aed1-9d94-41dd-a50e-2e11424b25e1"), "05/06" },
                    { new Guid("8a2da054-1eac-4f13-a874-acb7b9bd40a2"), "986", "2993212964454610", null, null, new Guid("e41a0e5f-468e-496b-8fe7-b8f4b2a0f962"), "02/21" },
                    { new Guid("8a648a5a-5db4-48d8-9547-98519228efc4"), "852", "6445436810277662", null, null, new Guid("0d6ec0b6-076d-4fc4-8519-424b1c8bf28e"), "04/24" },
                    { new Guid("8a9cfad1-5784-4ba5-8525-8dad402f4fec"), "895", "3611028964215798", null, null, new Guid("06f4c32b-9a3d-4b38-99a4-56ea0ba685a8"), "03/21" },
                    { new Guid("8abfcd90-63d4-4073-a70f-e8006b75e386"), "456", "7550343395930765", null, null, new Guid("2c87eaa4-8e07-41f4-bad0-935d07541e78"), "10/03" },
                    { new Guid("8accd743-2c59-48de-9f7e-3b8e2c258063"), "000", "9233275216186981", null, null, new Guid("42babbec-5dbe-4cc3-9f68-bb4bc7ad9491"), "01/26" },
                    { new Guid("8ae7e641-13c0-4d57-904d-acb626cc8f03"), "702", "8659224687225199", null, null, new Guid("be0a8a82-f1fd-45d5-8523-5b32db6fc767"), "06/16" },
                    { new Guid("8aebe4f2-a47a-4bd8-b330-e68ccd31b645"), "091", "7549393501846787", null, null, new Guid("6b5cd903-9056-4302-b3e6-b910c3a67f76"), "09/11" },
                    { new Guid("8ba7e787-c81d-463d-bd4c-ac0719ec2ecb"), "761", "2291497607027063", null, null, new Guid("7abaa815-d503-4740-a0a9-20d8752fc2cf"), "05/06" },
                    { new Guid("8c0ae923-7685-4ac5-9ec0-71ac411711b9"), "611", "6530349780237067", null, null, new Guid("b8e5286e-6ec4-4001-89c4-e17065f9bf09"), "09/26" },
                    { new Guid("8c927e29-5c3a-43a0-a988-4d4b73d18df8"), "597", "4258456444448631", null, null, new Guid("5c5b9127-2aa5-4ed6-b779-6402154d5c0f"), "04/05" },
                    { new Guid("8ccc8bf8-d615-4a27-9acb-6b3eaa0f7490"), "948", "3427553397785847", null, null, new Guid("f4c8c27a-6b37-469c-9492-061adc476725"), "06/18" },
                    { new Guid("8d1dd9ef-f378-4846-b81a-4a911700a07e"), "801", "8197823547307252", null, null, new Guid("1154bb55-7f7f-4d91-8347-5797ffeacb13"), "05/19" },
                    { new Guid("8d30078a-039c-4ec5-8106-28325371681f"), "052", "6544180544670086", null, null, new Guid("0d230077-5e9b-42d8-a83a-650a22378849"), "12/22" },
                    { new Guid("8d413522-1888-4a88-865d-cb11d04de9f0"), "238", "1522618767579688", null, null, new Guid("c66d96b2-e569-4470-a3b9-82ba83e46c97"), "06/07" },
                    { new Guid("8dee1a57-a576-4a14-83ee-1f925c78458e"), "687", "1770319998505938", null, null, new Guid("1e17494c-b19d-4879-af0e-c6575db6bd37"), "05/18" },
                    { new Guid("8e553f05-f3af-4739-9677-c585d1c0c032"), "179", "1925392678762497", null, null, new Guid("ed1f5061-44e1-4df4-b0de-bc0c17fd0185"), "03/22" },
                    { new Guid("8f0fa1a8-91f1-4f95-99fa-c17ca615a060"), "785", "5081321838108212", null, null, new Guid("2411a1da-d71e-4e02-a40e-984ec689c7bd"), "01/27" },
                    { new Guid("8f2e5da5-a1e7-46f6-a63f-1212127c8efa"), "002", "4167492247184469", null, null, new Guid("2700d101-47ef-4c75-a3e1-b613514a94f0"), "01/17" },
                    { new Guid("8f2f4089-71e6-44d6-a1f8-bf405e62eedf"), "941", "1194735133830421", null, null, new Guid("548e47d4-b851-4432-8514-fc092768db5b"), "09/03" },
                    { new Guid("8fa2440c-fc47-47d1-ab25-487e33fb331b"), "639", "9475723763131525", null, null, new Guid("3c3a765d-c1b9-47c7-b39a-7b5dc35e1cbc"), "05/14" },
                    { new Guid("905d6b00-23f8-49dc-afc2-1fb576e1fdc3"), "980", "1359844241254380", null, null, new Guid("75ba16eb-aa9c-4c6f-90ae-1515360055a9"), "02/15" },
                    { new Guid("90d8a958-b1ab-452a-a1e9-95a4b13cf8d6"), "409", "4183010559258078", null, null, new Guid("c7f42761-e210-47b4-9e39-2df36dce4c96"), "09/11" },
                    { new Guid("90dc3aaf-4119-485d-b64e-419478d8493b"), "147", "1077344929774575", null, null, new Guid("d29932a8-80f8-42b1-85e0-6bf810161455"), "04/11" },
                    { new Guid("913f1597-47e7-4813-8390-5b6f3605c3f8"), "828", "6687928425719613", null, null, new Guid("7abaa815-d503-4740-a0a9-20d8752fc2cf"), "01/17" },
                    { new Guid("918c8ebf-9221-4ac2-a06d-d4ec52374c0e"), "559", "8561466473488221", null, null, new Guid("7e4a74cd-b47b-47e6-ab98-22ed32bd8e27"), "07/06" },
                    { new Guid("91d7a8e1-8f35-4d4c-b70f-2b219fb36b34"), "736", "6241372706355955", null, null, new Guid("9e96d314-cd64-47aa-a5bc-7e0525cc9914"), "04/12" },
                    { new Guid("91ef394a-2426-453e-b045-d66ab31a14df"), "027", "3166360340145362", null, null, new Guid("5aff4312-b9a9-4958-b14a-305be3aa9f4b"), "05/04" },
                    { new Guid("927d64a0-19d8-41e0-b3b6-83030b8e13d4"), "601", "3526529237836977", null, null, new Guid("e5406e78-ce40-43ee-8dee-e58fe7687eb3"), "03/20" },
                    { new Guid("92957a9f-58b1-4ce7-853b-579c614fb7ea"), "411", "9158263947072271", null, null, new Guid("4188ab2e-f46b-4cf6-b460-560a914e5d35"), "02/24" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("934e8009-f6c6-486c-abc3-5fcf4c615b10"), "663", "4152509563653526", null, null, new Guid("1154bb55-7f7f-4d91-8347-5797ffeacb13"), "05/05" },
                    { new Guid("93644442-a304-47a9-aaa2-1b38cbc214dc"), "381", "7465119063501036", null, null, new Guid("672ce079-171b-4f7e-b744-6b9376e96b61"), "05/28" },
                    { new Guid("938f7764-226a-497b-998a-ceb5e430961f"), "101", "5282770523282930", null, null, new Guid("a6a8eca4-cb2e-43f7-9ea2-cbc644c8f9d8"), "09/09" },
                    { new Guid("94393a23-2666-4f11-98b3-2fe8967498d5"), "246", "4579723541971434", null, null, new Guid("21d9b3f2-945c-40a1-a0ca-7b6fcbe38a4e"), "11/03" },
                    { new Guid("94400fae-c70d-4b32-ae6a-ad1c867208cf"), "542", "2044714592868274", null, null, new Guid("0ec010bc-7e48-4cb9-bb93-8dd9d5b37f6d"), "11/01" },
                    { new Guid("946a68ec-cebc-4486-bb30-8d76a9f58622"), "602", "4862693741627312", null, null, new Guid("01424fda-76cf-4203-995c-a75e43c1d1d0"), "09/03" },
                    { new Guid("952ee970-75f6-449d-b436-ee6029dc996f"), "269", "8799262326427308", null, null, new Guid("74ef9233-8d34-4883-8938-b78b6c147246"), "01/10" },
                    { new Guid("954405b4-660a-4435-91b8-ed5cc54f03a4"), "898", "7778770439200854", null, null, new Guid("bbe91897-98e6-4c1e-aef5-09cd3dbb35cd"), "05/03" },
                    { new Guid("95d01f1e-e0ef-4766-8062-ce17f1cc7348"), "301", "2979467352601465", null, null, new Guid("0776f148-3954-48ff-8bb8-772d353c1a3c"), "03/19" },
                    { new Guid("95d18b50-ba2d-4d61-9d86-51faa764d077"), "495", "1989418447795497", null, null, new Guid("a2c81266-ca25-4e08-bddc-c6ccfe9435e2"), "08/18" },
                    { new Guid("9694cf75-02f0-4293-b264-3748adcf8f02"), "451", "3785707583532094", null, null, new Guid("a5276d46-3296-4c05-ba31-d2ebddfd8a57"), "09/02" },
                    { new Guid("970d8c7c-b65c-4099-96f2-721a1d413ddb"), "603", "4923037733968111", null, null, new Guid("d3cba19c-d75f-49cd-8bce-3e5563428a3a"), "05/27" },
                    { new Guid("975f0791-b157-42fb-adb5-89a7d37a8eb8"), "524", "6337123642769658", null, null, new Guid("fcf05f51-7f3a-4331-a0f5-6204db62e7ba"), "06/27" },
                    { new Guid("976182eb-e546-4afd-ab92-1b422c0e436a"), "464", "7443428749614773", null, null, new Guid("ac5a7dc0-9da2-4c23-9acc-ec9828404cd5"), "05/22" },
                    { new Guid("97830673-5967-4a3b-a4e1-26786e5a2b48"), "773", "1649117246005682", null, null, new Guid("f4c8c27a-6b37-469c-9492-061adc476725"), "09/01" },
                    { new Guid("97e590d2-3bcf-40e2-9405-ca759dd79abd"), "599", "7435437582241867", null, null, new Guid("0877dbd6-c025-49ef-b189-53b217500382"), "01/21" },
                    { new Guid("985986b6-15ef-4fe9-8e86-4c0568b9785d"), "072", "5220363167363245", null, null, new Guid("2700d101-47ef-4c75-a3e1-b613514a94f0"), "10/12" },
                    { new Guid("98b85e8d-d458-49d7-8c6d-4ae773c85cc4"), "349", "3886474500397783", null, null, new Guid("a59d873d-ae08-427c-b25e-29c55895239f"), "12/26" },
                    { new Guid("9911bf9c-32ee-427c-acb1-a07af8bbd415"), "418", "5178583787152898", null, null, new Guid("c590f92c-3ca1-4a33-a976-926995a0f7cc"), "11/26" },
                    { new Guid("9966a138-deba-414d-97c1-58fcf75d5187"), "555", "5393788770980546", null, null, new Guid("46843658-5438-46a9-b26a-f6c2fcfd1883"), "09/04" },
                    { new Guid("99be5bc1-e7e6-4b3f-bcd3-281501a8ce6c"), "206", "8405112800293725", null, null, new Guid("530579fa-33a7-4827-a21f-b9cacab42c7d"), "10/08" },
                    { new Guid("99fda428-7a2f-4031-a0d5-d2cf8a663ed5"), "389", "9797931835057784", null, null, new Guid("0773e360-956e-4d39-94c5-d0906a9e4557"), "07/09" },
                    { new Guid("9aada07d-cc04-4948-9bac-52ac59fcb8e6"), "125", "5310026682654915", null, null, new Guid("b53497b3-fabe-4282-a5c6-ef6e82864309"), "07/23" },
                    { new Guid("9b16f854-5830-47f8-9aae-f41d18542ec6"), "998", "6641718576019260", null, null, new Guid("71f7fb3b-e7f1-4325-bdd2-98f71dd515b1"), "04/27" },
                    { new Guid("9b7d10be-ce99-4ff0-90b9-60a33add5672"), "994", "7246796780336507", null, null, new Guid("74ef9233-8d34-4883-8938-b78b6c147246"), "09/14" },
                    { new Guid("9bbbcd44-33b8-41f3-b400-ba6bcb270f5d"), "499", "4870657691747601", null, null, new Guid("5d1e2a88-0f0a-4b6e-a524-e279224a1944"), "12/05" },
                    { new Guid("9ca62caa-f81e-4c54-80db-60e1191f071d"), "775", "9487213621374466", null, null, new Guid("db32027d-cf9c-4544-af7d-d20c917925c7"), "12/23" },
                    { new Guid("9ca8d1c2-0a99-448e-b030-11b76dfa42cd"), "897", "7960405765729738", null, null, new Guid("ea848f07-5360-4e76-ac1d-cf046366d4ef"), "12/03" },
                    { new Guid("9ce712db-d56c-45b5-9ad3-372bfd5daffa"), "544", "2305326866539484", null, null, new Guid("1a21f215-231c-4e09-b7c2-4e3163978286"), "08/09" },
                    { new Guid("9d2f98a3-7f8f-45e3-986c-655919b0f208"), "858", "2992763799167705", null, null, new Guid("c221f46b-a606-417e-aead-c8b255d84d11"), "02/05" },
                    { new Guid("9ef7ae9b-afe7-42a7-8e6a-680fda3eed19"), "779", "8023948339786289", null, null, new Guid("0d230077-5e9b-42d8-a83a-650a22378849"), "03/27" },
                    { new Guid("9efb601a-a481-4f43-934e-2f2e7d01d189"), "520", "9186460659274495", null, null, new Guid("c590f92c-3ca1-4a33-a976-926995a0f7cc"), "10/02" },
                    { new Guid("9f1caa78-1386-4349-abbc-64dff77847c6"), "403", "5599881496653692", null, null, new Guid("c40f9fee-6298-4137-bc78-c74409dec92f"), "03/08" },
                    { new Guid("9fe28182-ec26-46e9-9022-c6bf61147ebf"), "742", "3432178645989928", null, null, new Guid("5c6a10ae-343d-47fa-9381-6cbe7b1a68be"), "11/04" },
                    { new Guid("9fea6ab3-7249-4292-acd2-7d1ae721d340"), "654", "9266067656659834", null, null, new Guid("0776f148-3954-48ff-8bb8-772d353c1a3c"), "08/27" },
                    { new Guid("9ffb49f9-5b7a-486b-a29f-b552479c99e2"), "432", "4178870453425342", null, null, new Guid("753e85fe-b18a-442a-b91e-1d9dc9216d93"), "10/23" },
                    { new Guid("a07719b2-09ef-47c6-8add-5cb51a5236b1"), "725", "9237691760962705", null, null, new Guid("cf611bf3-21fb-4ed7-a138-00c7afdda9ba"), "06/19" },
                    { new Guid("a0882fa1-8b13-4893-b12b-130ca81c2a5a"), "521", "1407968431548769", null, null, new Guid("4d006d0d-8a50-4d81-886b-176313d018fb"), "12/15" },
                    { new Guid("a08fd2ac-b24e-41b1-99e6-dbf82c38f21e"), "687", "4458401013011050", null, null, new Guid("ea848f07-5360-4e76-ac1d-cf046366d4ef"), "04/05" },
                    { new Guid("a0d15af0-f7d9-4d31-a711-8b6796bd0d9e"), "290", "3816929735529828", null, null, new Guid("4f42e5ab-642c-4775-b2b2-a116ecfcd663"), "08/19" },
                    { new Guid("a15538fa-8d0d-43e0-a3dc-9ec7a154f494"), "465", "8261384322541676", null, null, new Guid("df3cc97e-5297-4426-8d73-6ec8a1d6ff19"), "02/08" },
                    { new Guid("a181f419-62f0-4818-9523-6b3c8e4023cb"), "150", "4256054016408454", null, null, new Guid("141e6ca1-3b19-4ffc-a21f-8420c3f6db52"), "02/14" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("a21add04-b4a3-4f17-80a2-9ac36369fcca"), "369", "3413716028374313", null, null, new Guid("49ef4ccb-eb29-4ffa-bcfe-88759ac3f1c5"), "08/21" },
                    { new Guid("a2574263-116a-4962-a881-7488eb2d421d"), "916", "2907057626528810", null, null, new Guid("56234ad9-accf-413f-8d2b-5d6fb1cd04a1"), "11/18" },
                    { new Guid("a26dda92-b2c9-4232-b458-9ec2359ec4d8"), "710", "3902967577718704", null, null, new Guid("aec475ab-9ab8-4f55-8794-ee1ffc6f6da6"), "06/12" },
                    { new Guid("a2b469da-7d98-4ab1-ba0f-b141ad5153a7"), "951", "1035866149382834", null, null, new Guid("1b1ebe07-5765-4728-8b40-ee14061347ae"), "11/15" },
                    { new Guid("a332219f-ef6e-4ac5-a916-b9be51a898a3"), "337", "4261316461892399", null, null, new Guid("4c5d0085-4956-4748-b989-09b4d927d669"), "08/04" },
                    { new Guid("a3b04d47-b733-4202-93a0-7ca153e77b8e"), "820", "4683924036798499", null, null, new Guid("d57e07f1-63a6-4514-ae7a-51f83c901e2c"), "03/13" },
                    { new Guid("a3cdeb12-d179-4aca-bb1c-e28c3d97af26"), "565", "6688505488912080", null, null, new Guid("5aff4312-b9a9-4958-b14a-305be3aa9f4b"), "10/22" },
                    { new Guid("a3e969c5-c86a-4a87-afb3-fd4116daffff"), "442", "1172532160983598", null, null, new Guid("ca127dc1-765b-47e8-87ee-ebc90ec70a73"), "10/07" },
                    { new Guid("a410ceee-6de1-442a-96a8-a3355c081afe"), "855", "8285946658167007", null, null, new Guid("4e8c89c0-a2fb-42d3-8d7a-11fe5d3b6d75"), "07/19" },
                    { new Guid("a42b00b4-f927-42a2-8a1f-53a68517f73e"), "037", "1944455812756404", null, null, new Guid("48f4af12-c8b0-4444-98ca-81df5d349e01"), "12/02" },
                    { new Guid("a4b0b231-bedc-47ed-8d0d-bcfea0468cea"), "448", "9313713724515195", null, null, new Guid("1b1ebe07-5765-4728-8b40-ee14061347ae"), "11/14" },
                    { new Guid("a4e758b1-ed2f-4bbc-ac8b-b4283740bd7a"), "267", "1504174030914847", null, null, new Guid("3a19b458-72b3-4b5b-97e6-334a56d7d557"), "05/18" },
                    { new Guid("a5178769-abc0-4287-88e8-0e1b470f2490"), "888", "4535806321403972", null, null, new Guid("6c3f8b98-7095-4d12-8f55-02b23a300d5f"), "11/08" },
                    { new Guid("a570622d-3d16-4180-9f4f-b8042016f284"), "624", "9595913817785920", null, null, new Guid("bbaf9fe2-9863-4589-964a-23c62e6bf830"), "11/12" },
                    { new Guid("a5d97d42-b0bc-41fa-a604-04334f183179"), "348", "9845259204203408", null, null, new Guid("4d006d0d-8a50-4d81-886b-176313d018fb"), "02/15" },
                    { new Guid("a611dfa1-923f-4e54-ab66-2d5aa9525270"), "979", "3559893562454752", null, null, new Guid("4ecad1f7-2b37-4dd8-be42-dedd60205e81"), "10/13" },
                    { new Guid("a65cd174-e060-45f4-a1b7-b8e4c995f638"), "033", "2726815576619822", null, null, new Guid("48b3cd65-be2f-4be1-a3c5-d88da44b3d73"), "08/03" },
                    { new Guid("a663c43c-2490-4440-86da-f4ff83902a61"), "512", "2847491329499741", null, null, new Guid("1381d1cd-5c11-46c1-bc37-987b3f5ae33e"), "11/21" },
                    { new Guid("a69a9b84-b91f-4e14-a852-409a3f5ed7da"), "685", "6246210336670135", null, null, new Guid("7a52231d-ba53-47d6-8382-e5bf5f9e7e24"), "09/15" },
                    { new Guid("a69f8f66-8079-4578-b92b-490d098f14be"), "687", "1207136956579569", null, null, new Guid("ac4ee7ff-56c7-4c45-ba3e-32ed6d9370f3"), "01/01" },
                    { new Guid("a76bb773-d38e-42d9-b3c1-3011e73e8baf"), "154", "7384022255224616", null, null, new Guid("ed1f5061-44e1-4df4-b0de-bc0c17fd0185"), "12/08" },
                    { new Guid("a963ff78-a0a3-4678-b1a2-b54eac7766e8"), "915", "5727520103737399", null, null, new Guid("871feb78-0a5f-4d88-8754-a386270f590d"), "09/25" },
                    { new Guid("a9879a2c-339a-4ffa-918a-4aeec9a96e35"), "172", "9370376743549978", null, null, new Guid("2c87eaa4-8e07-41f4-bad0-935d07541e78"), "10/06" },
                    { new Guid("a9bec97a-2cb0-4ba0-969e-4c75193c9265"), "972", "9588581977983869", null, null, new Guid("815c5bf5-7253-492e-81c8-82e2d6860602"), "08/22" },
                    { new Guid("aad14e77-6573-4d6a-9c52-8afb207f6e0c"), "009", "2650688512258308", null, null, new Guid("39d27a82-05d2-4135-b53b-53748eefd4f2"), "06/28" },
                    { new Guid("aae3d250-d31d-436c-88f4-47b1d6fd614f"), "712", "1703264173894140", null, null, new Guid("5e1f9cf6-8e77-46be-92e7-b3f10da0ed86"), "07/24" },
                    { new Guid("ab37676c-ae6b-4bb1-b316-6e04c57487da"), "072", "8799758528846722", null, null, new Guid("fe7a3052-1ad9-4450-b9d5-057c6abe9c2e"), "07/02" },
                    { new Guid("ab65eb4b-ff9a-44ad-bce2-f4e8465e634b"), "732", "7778351115636461", null, null, new Guid("c3cc5785-6364-48fa-bb83-e7ac33fc672b"), "02/09" },
                    { new Guid("ab9454e3-68f3-4b5b-a066-4b313c822c06"), "063", "3577822706546656", null, null, new Guid("4a9e17b4-cb0f-4c82-80d2-e1d56fe06f0a"), "06/07" },
                    { new Guid("aba5fac5-9a5c-4001-8b1f-bb1c0ef0bf5c"), "928", "7740870867542154", null, null, new Guid("99d4724f-46db-42d2-a62b-3d8fa528e130"), "02/10" },
                    { new Guid("ac0d78d0-f8c9-480f-a535-2ffc11ba55e1"), "228", "4296523010070947", null, null, new Guid("5c5b9127-2aa5-4ed6-b779-6402154d5c0f"), "08/14" },
                    { new Guid("ac969c90-105a-464b-893d-e48528cd2710"), "523", "7144323124725458", null, null, new Guid("9ec54876-333f-4825-9959-c839395cb66e"), "03/13" },
                    { new Guid("acb8e05f-80b9-45b0-bd3a-6009f26bf81a"), "728", "8559818249375751", null, null, new Guid("50ac14d1-c13d-42f2-8026-301c38b1964b"), "10/22" },
                    { new Guid("acc99591-2346-4f9d-adb2-aea1a2057aa2"), "312", "1997191898415241", null, null, new Guid("c36bd526-4a45-4a4b-9d0e-50c279e9b939"), "06/19" },
                    { new Guid("acee8e22-135e-4242-8b87-a3e452a07687"), "575", "4406945323518800", null, null, new Guid("50b1b40f-32d2-45da-a690-b9d24fff476e"), "01/12" },
                    { new Guid("ad110ac3-d2ed-44ab-b4f3-882b925ce15f"), "670", "1420560098256289", null, null, new Guid("6ef84803-7ff7-46d1-b1b3-ebda82e158b3"), "02/26" },
                    { new Guid("ad835741-b4d7-4804-afed-c07e3f2418ad"), "915", "6770799096544768", null, null, new Guid("8a696f30-76c2-40db-a250-030829547d67"), "09/11" },
                    { new Guid("ad9b7404-f9d6-4b22-82e5-17d428e6291e"), "148", "2754907623289172", null, null, new Guid("9ee8d8bd-022b-4718-b8f4-cc38174e988c"), "10/28" },
                    { new Guid("add1c579-4f35-4383-a790-a0a345706ff7"), "116", "3316985836455026", null, null, new Guid("3712e35b-2da9-4c76-ad88-28828e776a5c"), "09/20" },
                    { new Guid("aefca03f-c009-4915-b2a4-01d38161e12c"), "142", "7390354631869594", null, null, new Guid("2700d101-47ef-4c75-a3e1-b613514a94f0"), "11/22" },
                    { new Guid("aefe2fc1-7fec-45fb-bfe7-1ef7d45918a2"), "618", "9611956591175596", null, null, new Guid("ab451099-7866-44e4-9ebd-f1162ea6206a"), "06/08" },
                    { new Guid("af8bdda3-00af-4844-980c-fb8785c84b0b"), "992", "7897986578690002", null, null, new Guid("a943e809-55d9-482f-a592-8709b5f7d47f"), "01/11" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("afa355a1-798f-4959-b730-6be12dc8b565"), "436", "3450152349740635", null, null, new Guid("3a19b458-72b3-4b5b-97e6-334a56d7d557"), "05/03" },
                    { new Guid("afec5f5b-1a8c-4c33-8e28-4a968f05649c"), "365", "4932351604096798", null, null, new Guid("78be92c8-3390-4d5e-aa3a-54c7301eaf2f"), "07/02" },
                    { new Guid("b05ac833-3e96-48f9-9e5b-64b28c621d5f"), "067", "4240431579500455", null, null, new Guid("df1ba0e6-99b8-419d-a3b8-cece7c4928bd"), "03/05" },
                    { new Guid("b0713af1-7749-4efe-981a-cd05d2d45418"), "761", "6722096066404713", null, null, new Guid("dc5f8e5e-be11-43f9-acd2-648e38e09946"), "10/22" },
                    { new Guid("b074493d-923b-4d17-b610-3d48b1e5a066"), "605", "1333642488525698", null, null, new Guid("50ac14d1-c13d-42f2-8026-301c38b1964b"), "03/17" },
                    { new Guid("b1752b1a-7236-4db2-967c-c5e7900b9139"), "199", "8809403910291115", null, null, new Guid("a59d873d-ae08-427c-b25e-29c55895239f"), "02/04" },
                    { new Guid("b281a24e-894c-4b9d-9d2a-2c20590acdda"), "647", "6543084442371018", null, null, new Guid("496d8ed2-fc6d-49e6-b902-8a1d0b266928"), "11/13" },
                    { new Guid("b2d80d06-2b47-44bc-8542-3db65fbe10f8"), "566", "8547227720950061", null, null, new Guid("4fdddaf5-83dc-4f45-ad82-fcab10f87405"), "09/16" },
                    { new Guid("b2e3793f-b578-4d50-ac8f-5403706c7d9a"), "088", "8896593577218005", null, null, new Guid("66da7f26-36d5-4406-a2e4-35363c8e43cb"), "01/05" },
                    { new Guid("b30d7486-ff69-4ca0-87a2-0da10cb72828"), "721", "2790122783054672", null, null, new Guid("eeb82343-3a6f-48ee-b791-709692ceea7d"), "10/25" },
                    { new Guid("b414f412-b40e-4bff-aa58-7001ce904e8a"), "178", "7588056461997284", null, null, new Guid("f630d90d-3329-4958-99e4-34aa2f69436c"), "09/24" },
                    { new Guid("b478fd57-7b85-4424-bf9a-66958f65103f"), "910", "3171913199710885", null, null, new Guid("b40d8226-58de-4e86-811d-0e6b38686d57"), "08/20" },
                    { new Guid("b48e99a0-9683-46c4-87dc-705ac375dc14"), "876", "9091191540659331", null, null, new Guid("22edc826-6747-4099-aca5-578199353ac6"), "03/11" },
                    { new Guid("b4902e8d-f42a-4f55-a3ca-800763060baa"), "669", "1602408735170078", null, null, new Guid("0e7742f2-e964-4e8c-b692-4ffb75ece318"), "12/13" },
                    { new Guid("b58223be-3b36-494e-adca-b123b3434e82"), "241", "8059743911846140", null, null, new Guid("72a42c8b-ed7c-4e7a-81c6-313cac897b20"), "03/22" },
                    { new Guid("b5b8c442-a69c-46c7-b0b2-20ef5fc8607c"), "194", "3514437876164059", null, null, new Guid("d0aae9a2-8c5b-48e9-b856-e309c80cadae"), "03/26" },
                    { new Guid("b5f0e5a5-e0ca-4713-acd6-fd594fdd4767"), "510", "9299183371664409", null, null, new Guid("405a5eb1-aee0-4578-8748-2d8b5a6b0d57"), "05/07" },
                    { new Guid("b78f3209-29bc-4418-8474-69ba8c16b341"), "433", "9737489612801554", null, null, new Guid("9cf1e944-d004-426c-83ee-acb2b8793bc6"), "04/28" },
                    { new Guid("b791b98b-7e41-4d91-8d00-5482a59caeed"), "480", "5931874079895348", null, null, new Guid("0e6930e6-cf0a-4195-8d74-a9cc0dfb30b6"), "07/12" },
                    { new Guid("b7d5571f-da9d-4b99-ba8c-18b7700a1aed"), "583", "3673229467358709", null, null, new Guid("e5406e78-ce40-43ee-8dee-e58fe7687eb3"), "07/23" },
                    { new Guid("b833d2ae-6047-4d4d-8a4b-29043fbb8d38"), "062", "5986740765712361", null, null, new Guid("36ffb969-580b-40d2-8fa0-94749ea99214"), "09/25" },
                    { new Guid("b84a6e28-81a0-4535-a6f8-4a8d9136314d"), "162", "6153654552027680", null, null, new Guid("b1817475-7a6c-44d8-8e81-4b59b1f4923e"), "05/08" },
                    { new Guid("b86c837d-1ace-4ebb-9167-89dd30b72c0a"), "585", "4595106614569996", null, null, new Guid("7cf58058-5eec-4c6e-a4ae-cf50ccf0b2ac"), "03/26" },
                    { new Guid("b92a7670-b9a2-422b-841f-3417dfd18f44"), "411", "8009356934711458", null, null, new Guid("dc5f8e5e-be11-43f9-acd2-648e38e09946"), "09/04" },
                    { new Guid("ba6e49a8-3086-4007-a5b0-8ef15643ad0f"), "863", "4623142823022458", null, null, new Guid("d1d503de-e688-46df-9a53-6ca07b1d716f"), "10/23" },
                    { new Guid("ba9dc95a-93f0-4c29-be8e-98465563f165"), "671", "5992406467981576", null, null, new Guid("6b5cd903-9056-4302-b3e6-b910c3a67f76"), "01/23" },
                    { new Guid("bac562ca-f4fd-4ac4-a978-5acd88bfbbc2"), "488", "1530503974634008", null, null, new Guid("bbaf9fe2-9863-4589-964a-23c62e6bf830"), "09/18" },
                    { new Guid("baed2716-0a87-4137-ba75-23d4a371f667"), "925", "8557888111490368", null, null, new Guid("ea848f07-5360-4e76-ac1d-cf046366d4ef"), "08/16" },
                    { new Guid("baf675f1-5dbc-43aa-92b7-96a91b9c7f12"), "524", "6388471428778323", null, null, new Guid("76c44275-2d3e-43e9-b34e-c05f912213b8"), "01/27" },
                    { new Guid("bb511649-e80a-4123-b69b-4ccc3d37c1bc"), "665", "8463933427515653", null, null, new Guid("6ab8f9db-6513-4d8f-9cde-7b925ff51057"), "11/18" },
                    { new Guid("bb976001-4b69-4f3f-90b5-2d3877e5a82b"), "289", "5216145193968947", null, null, new Guid("fe7a3052-1ad9-4450-b9d5-057c6abe9c2e"), "06/15" },
                    { new Guid("bb9e92d8-f58a-40ff-aa2c-5d31f265a66d"), "161", "2068786089563421", null, null, new Guid("99d4724f-46db-42d2-a62b-3d8fa528e130"), "11/21" },
                    { new Guid("bbc0d88b-7905-498d-85fe-b883b4b16a9a"), "761", "6225442662915249", null, null, new Guid("dbc51236-052c-4c31-820d-b0a01a143d1a"), "10/17" },
                    { new Guid("bc3b3065-3584-4e17-bda7-d3d07e97ba15"), "062", "4141742283879037", null, null, new Guid("dd550cd7-4eae-4d75-8be5-5f3e496fdd24"), "04/02" },
                    { new Guid("bc5fc614-36aa-4644-b43d-606dccc2b45b"), "994", "8514234688295195", null, null, new Guid("5c6a10ae-343d-47fa-9381-6cbe7b1a68be"), "12/02" },
                    { new Guid("bcbd71f8-b9df-4e7c-ad7b-18f13d29d9b8"), "424", "8658061539312536", null, null, new Guid("8ea935b6-2c30-4bef-803c-9f382789979b"), "07/26" },
                    { new Guid("bcc07758-d34f-4205-ac27-058ece31c20e"), "758", "4866604915578355", null, null, new Guid("4fdddaf5-83dc-4f45-ad82-fcab10f87405"), "10/28" },
                    { new Guid("bd359f15-e5a2-4f18-b1e2-8ad4bf5cf17c"), "176", "5841782565881460", null, null, new Guid("5e1f9cf6-8e77-46be-92e7-b3f10da0ed86"), "05/11" },
                    { new Guid("bd939753-dc55-448e-9229-a1df38b52f1d"), "244", "2428837053254739", null, null, new Guid("e2db5e4a-dcb2-42fc-b56b-17a4692bd0de"), "06/10" },
                    { new Guid("bddb3e37-60d1-4cd8-b0a5-44634a1e511b"), "887", "5066814578218538", null, null, new Guid("affd1717-742a-4014-8e72-3420c7496c1e"), "02/25" },
                    { new Guid("be45b575-5fa3-4429-8b19-e60589865ecc"), "732", "8140816632777429", null, null, new Guid("93e9e8fa-8b76-4968-a1ef-a4d59b6958ea"), "01/18" },
                    { new Guid("be7fbcf8-4527-416b-a194-0e067cf8170f"), "980", "6674067641759223", null, null, new Guid("1e17494c-b19d-4879-af0e-c6575db6bd37"), "08/04" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("be97a04e-b113-4a7b-9833-2664991d42d1"), "897", "6144611119744693", null, null, new Guid("56b8dced-e510-417c-8b93-8a2cb06b845a"), "09/15" },
                    { new Guid("bef300fc-64a8-4d66-9d63-77dcd4717598"), "965", "4090414247879391", null, null, new Guid("c3cc5785-6364-48fa-bb83-e7ac33fc672b"), "10/23" },
                    { new Guid("bf49d54d-2164-4a61-8834-2ade6499a531"), "029", "1993362582640825", null, null, new Guid("0e6930e6-cf0a-4195-8d74-a9cc0dfb30b6"), "03/08" },
                    { new Guid("bf8aa583-ff47-4cb8-a5fb-cc01e92b2b7e"), "497", "5961415755496147", null, null, new Guid("2411a1da-d71e-4e02-a40e-984ec689c7bd"), "01/09" },
                    { new Guid("bf97d37c-5930-476b-aaa7-54f47afed855"), "699", "6196209914332159", null, null, new Guid("097cb7d3-d333-48aa-b8ee-cacd11ee91fa"), "05/11" },
                    { new Guid("bf983d5a-266a-4eeb-b4e2-48a43f170ec5"), "179", "7042870619664433", null, null, new Guid("2f8c0b43-80b3-437b-8a84-a763ed30230e"), "01/21" },
                    { new Guid("bfae231a-75b9-446d-99bd-aa8e95140a44"), "324", "2663697051996090", null, null, new Guid("db32027d-cf9c-4544-af7d-d20c917925c7"), "10/27" },
                    { new Guid("bfc5a105-7134-46e7-a07d-e905e0abd70d"), "516", "7202896466625132", null, null, new Guid("7e4a74cd-b47b-47e6-ab98-22ed32bd8e27"), "08/10" },
                    { new Guid("c039422a-a9b2-476b-b3ac-e72572c8f87f"), "726", "1026130528384282", null, null, new Guid("0635daf3-649c-437b-92ef-713d43246a0a"), "01/26" },
                    { new Guid("c043a27f-2a37-4acc-acc9-c66a9f549671"), "063", "7190375162216169", null, null, new Guid("4c5d0085-4956-4748-b989-09b4d927d669"), "12/02" },
                    { new Guid("c05d0af7-7c4d-4499-986c-e36abad3f899"), "246", "2294529350164000", null, null, new Guid("a9090dd7-3795-48e2-837b-9a72a0274d7b"), "10/07" },
                    { new Guid("c09ea87a-e5db-42d5-9faf-a3664a6c9569"), "136", "4440832046912345", null, null, new Guid("6c16f159-98d6-4d70-a7ac-43b19b827d49"), "12/21" },
                    { new Guid("c0af12cf-8ecb-465f-b0fe-85e59abfe88d"), "865", "5662608039807167", null, null, new Guid("c7c0cd55-07d8-41cc-9d2b-4bd04cb7edb3"), "11/20" },
                    { new Guid("c0de2be4-a041-43af-9cdc-b0d460e25d60"), "175", "7627530943865521", null, null, new Guid("4f42e5ab-642c-4775-b2b2-a116ecfcd663"), "07/09" },
                    { new Guid("c0f45261-35e6-4240-97f7-bb77dab229f1"), "904", "1336739816812602", null, null, new Guid("335c9d28-42e2-4d49-9686-f0cd1b972fae"), "05/08" },
                    { new Guid("c10b0576-536b-4eef-90c6-1617b1e9dc2d"), "410", "3273230923516763", null, null, new Guid("02a17a84-0a35-4164-b872-e030d586b6fe"), "04/22" },
                    { new Guid("c1264f4f-013d-41b6-8eff-96510cfd13ff"), "497", "1266242495716651", null, null, new Guid("1a21f215-231c-4e09-b7c2-4e3163978286"), "04/17" },
                    { new Guid("c15a6f88-2ef6-43f7-a5b2-4726b1dec820"), "882", "3332751961228903", null, null, new Guid("aec475ab-9ab8-4f55-8794-ee1ffc6f6da6"), "04/01" },
                    { new Guid("c16385d0-4445-44d5-b53f-272b80957fb0"), "465", "7812918166096905", null, null, new Guid("1381d1cd-5c11-46c1-bc37-987b3f5ae33e"), "11/03" },
                    { new Guid("c16dca22-fca7-44d9-b7c7-a2e44e447cf7"), "972", "5377750516642124", null, null, new Guid("8b3afef3-3bbb-4237-b8b8-1eba1df7757e"), "08/06" },
                    { new Guid("c1d22113-7952-4c74-a7a8-600241fb4efd"), "088", "3101893328157996", null, null, new Guid("4c5d0085-4956-4748-b989-09b4d927d669"), "10/18" },
                    { new Guid("c203dc6a-46b5-45b2-b733-5dfa09944f0b"), "371", "4150144105122693", null, null, new Guid("a780acfd-e10d-4dc5-a383-1ba56a91e666"), "12/08" },
                    { new Guid("c22a32fd-1074-4e08-99a7-ae8ed79b61b5"), "316", "8360819859754930", null, null, new Guid("54c975d2-dbfe-4626-97fa-ceaa28e85030"), "01/24" },
                    { new Guid("c24989b8-8177-421d-adf6-f12bbd9734b9"), "478", "2416143485694593", null, null, new Guid("f2c5c231-fa4f-4403-a17b-f986cd15543a"), "03/02" },
                    { new Guid("c3caa6bb-32e2-41d0-84aa-39742d0f2414"), "208", "1044109210422990", null, null, new Guid("cf348fa5-7d32-48ec-957c-eb481beb0358"), "06/19" },
                    { new Guid("c3d851d7-fc92-4763-883e-db25bde28a0f"), "816", "9966208651967123", null, null, new Guid("ca127dc1-765b-47e8-87ee-ebc90ec70a73"), "04/18" },
                    { new Guid("c3dbe512-8e99-4f13-81c7-4b18228a66df"), "124", "4725549707303099", null, null, new Guid("080ced29-2e70-40de-82e4-0a2d478fe53e"), "08/08" },
                    { new Guid("c3ffef35-13d9-47f5-972c-8356eb3d2f18"), "770", "7112707657630610", null, null, new Guid("8e3d5153-23be-45f9-83b4-5aecbb1a4322"), "11/16" },
                    { new Guid("c43793b4-5a2d-42c2-9be5-37993bc5f7bd"), "336", "2325688983291825", null, null, new Guid("a5276d46-3296-4c05-ba31-d2ebddfd8a57"), "05/01" },
                    { new Guid("c45ef2ee-6b8a-49aa-9703-654e482ea2bc"), "413", "5500759795247036", null, null, new Guid("b21ce16f-bf5c-4cfa-9fd4-9b67014eadbb"), "04/16" },
                    { new Guid("c47313e2-e303-41d3-b9f7-ffc49aa7b4f4"), "771", "7009462032310809", null, null, new Guid("92a5d027-0cfb-43ec-84b3-d812837c5654"), "04/14" },
                    { new Guid("c5406427-c0a3-4957-b069-ead444b8136d"), "130", "2204657210536160", null, null, new Guid("10766e70-305e-4e2a-8560-ffeb596a93eb"), "11/13" },
                    { new Guid("c5554ab4-09b9-4cb1-a24b-fd76fab12c13"), "433", "8438078907790708", null, null, new Guid("97e11482-d5e6-41d7-82e3-80806df9c3bc"), "07/27" },
                    { new Guid("c59bd2c5-5d4e-40e5-982b-d0596c35336d"), "810", "3412599885503688", null, null, new Guid("653800c1-b55d-4636-99c0-ea31223d7e3b"), "03/19" },
                    { new Guid("c5e5050f-dc80-4173-8baa-01fe7bf22292"), "768", "1277431325210316", null, null, new Guid("1e17494c-b19d-4879-af0e-c6575db6bd37"), "12/01" },
                    { new Guid("c6035734-47c8-4fbf-801e-7f0038b3e632"), "279", "8198369930164037", null, null, new Guid("82f7ffb4-bdb1-40a8-8d2d-67f1c2f5bf91"), "04/25" },
                    { new Guid("c6d5230f-7504-4454-b9b8-ba86b00d781b"), "436", "8752182305549230", null, null, new Guid("0447d1d8-3e48-4d64-8d2e-7d9a733628ec"), "08/21" },
                    { new Guid("c7569348-34d5-4dba-900a-27b0851d8746"), "132", "7903037278305463", null, null, new Guid("8ce72c63-9c31-4159-9ba2-012a4fc3df72"), "05/12" },
                    { new Guid("c75c19e3-063d-42fc-a9ad-2b24b830eed1"), "586", "4641695108673524", null, null, new Guid("8c060e9b-2ea2-4602-8535-ce147e60fcbd"), "08/27" },
                    { new Guid("c7e11903-ff54-4eb7-87aa-69f2e9117b30"), "961", "9164234827204836", null, null, new Guid("46542d6d-04cc-418a-88b4-cda40f4aff48"), "04/14" },
                    { new Guid("c7e17e2a-e691-42b0-bf70-e522b2b92913"), "724", "3774400433864812", null, null, new Guid("c58f524e-a96e-4e8b-9186-6c21d38d64b3"), "07/17" },
                    { new Guid("c88766a3-da9f-4336-b403-edb72f63ff31"), "165", "8369523749519208", null, null, new Guid("bd349cb3-f696-4e78-9355-45b8b4f7385f"), "08/20" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("c8cbddec-2739-4a79-a659-ce64c2a83d73"), "289", "1116090086534321", null, null, new Guid("4188ab2e-f46b-4cf6-b460-560a914e5d35"), "08/25" },
                    { new Guid("c8d8a88c-3c7a-4a2e-9da4-bed654d23d48"), "339", "1098124139616824", null, null, new Guid("0447d1d8-3e48-4d64-8d2e-7d9a733628ec"), "11/15" },
                    { new Guid("c8ebfc8f-49e5-4161-a42a-97a67777de0c"), "213", "8196352472702966", null, null, new Guid("6c3f8b98-7095-4d12-8f55-02b23a300d5f"), "05/22" },
                    { new Guid("c90b0d39-af3e-4e9c-b320-6f8373b25984"), "768", "4256421996391609", null, null, new Guid("539c62ee-15fc-4d37-ab5d-0e4126109954"), "04/28" },
                    { new Guid("c9274f73-87ba-4a26-92f9-c7e732f46a40"), "486", "8140927761523337", null, null, new Guid("8bfa284c-faeb-4fb6-909c-2a2ea4c8745b"), "03/08" },
                    { new Guid("c9706911-dc32-43e9-9766-3173014de91d"), "725", "8344561429918600", null, null, new Guid("9ff0a0ca-02d0-4209-bb8f-a0d7efaf75bb"), "12/13" },
                    { new Guid("c97e6a62-ccdc-49ad-a4fb-41ce5dbbfa31"), "820", "8045950095353335", null, null, new Guid("4e8c89c0-a2fb-42d3-8d7a-11fe5d3b6d75"), "02/12" },
                    { new Guid("c9b2b1ee-1db5-4c08-9ad7-ffaa55fe00c7"), "481", "4764063890745878", null, null, new Guid("77bc83c5-7598-48f0-b4c1-23f76fd277ca"), "01/27" },
                    { new Guid("ca17d902-0860-406d-b800-27ec8b682995"), "995", "1334840016520865", null, null, new Guid("59a9232d-40d9-422d-8a1a-fe022e85093a"), "03/19" },
                    { new Guid("ca33e225-cd1e-4a93-86ba-47073c0ddf15"), "356", "9499250809492940", null, null, new Guid("9e96d314-cd64-47aa-a5bc-7e0525cc9914"), "04/07" },
                    { new Guid("ca342f86-9c3c-4c7a-b260-14486e3f613e"), "174", "3854386311399708", null, null, new Guid("64174d68-43d3-488f-89bf-23d32b134019"), "12/04" },
                    { new Guid("ca34c703-e119-4878-95b9-1b5c76e5eeeb"), "888", "9363399624731467", null, null, new Guid("dd550cd7-4eae-4d75-8be5-5f3e496fdd24"), "08/11" },
                    { new Guid("cabb0fad-612a-4cfe-83d9-00d3c70e2a20"), "550", "3938633198923379", null, null, new Guid("f28f3fdf-fa90-4b58-895f-89b7f89e53e9"), "02/06" },
                    { new Guid("cac1e0cf-e120-4083-a15c-c84943fc42c3"), "316", "8521626570362897", null, null, new Guid("353c126e-57f5-471a-b13f-0e4fd4cef2fe"), "03/20" },
                    { new Guid("cb0599c3-8382-4eae-b2a6-9e83af726529"), "340", "9531841006394651", null, null, new Guid("0e7742f2-e964-4e8c-b692-4ffb75ece318"), "04/10" },
                    { new Guid("cb8696e2-8e3c-4026-a244-7d549214aa82"), "709", "9057518710534835", null, null, new Guid("7da75a84-c857-4768-9ff2-252052ea5333"), "07/09" },
                    { new Guid("cbb18c0b-824e-44ce-9ba7-e070cf990469"), "487", "4357512319881189", null, null, new Guid("0a8fb680-a380-4d35-85da-ff3cf9faa245"), "11/06" },
                    { new Guid("cc45446d-48d9-4d91-81a1-11271d7f0aed"), "513", "1740987038847260", null, null, new Guid("2b5f8a6c-d3e8-41ff-8867-cadb6cd16ea4"), "07/09" },
                    { new Guid("cc97d8a0-8031-499f-84bb-c258c28cf54e"), "074", "6926089108435558", null, null, new Guid("a780acfd-e10d-4dc5-a383-1ba56a91e666"), "05/26" },
                    { new Guid("cce137ae-0358-4966-8b4c-2e8e2c8350b2"), "517", "2128018443868618", null, null, new Guid("6218849a-9af3-4ab0-93d1-f5fd29135491"), "10/16" },
                    { new Guid("cd02255d-3c3e-4633-a577-685dad27d9e9"), "569", "8596073518111969", null, null, new Guid("8e3d5153-23be-45f9-83b4-5aecbb1a4322"), "10/07" },
                    { new Guid("cd79e710-2cf9-438b-b4a4-312181007998"), "088", "5753903278551166", null, null, new Guid("757f3f70-fdce-4727-8fcf-9ac8aa0287b3"), "03/23" },
                    { new Guid("cd803d46-85cd-4f61-8ab0-0aa81acc5a2c"), "814", "3205546931962724", null, null, new Guid("7a52231d-ba53-47d6-8382-e5bf5f9e7e24"), "06/05" },
                    { new Guid("cdb47721-f246-4248-af01-778a9378cfe2"), "769", "3150897631655029", null, null, new Guid("8ea935b6-2c30-4bef-803c-9f382789979b"), "10/21" },
                    { new Guid("ce2aafdb-30e7-40f5-8708-59611eba3214"), "375", "1544436416750243", null, null, new Guid("77bc83c5-7598-48f0-b4c1-23f76fd277ca"), "05/02" },
                    { new Guid("cea53dcf-88f9-4ccb-b384-7213d7372c8e"), "622", "4237236359201985", null, null, new Guid("3b3e9016-3025-48e3-93b2-fa474015c0f7"), "07/03" },
                    { new Guid("ced6d4c4-fc9c-4b0d-be6a-c654057b85f6"), "744", "2585803251488604", null, null, new Guid("cf3285c8-97d7-426d-87f3-e0854194e226"), "03/18" },
                    { new Guid("cf2e8b79-cdbc-49c2-a379-9ac36b62b857"), "004", "7045670223495500", null, null, new Guid("ac4ee7ff-56c7-4c45-ba3e-32ed6d9370f3"), "04/08" },
                    { new Guid("cf489874-f6c7-43ec-8f67-1f917e33c5b0"), "532", "1766035617101580", null, null, new Guid("23e8131d-ba45-4488-991d-941eca3fbe0a"), "12/18" },
                    { new Guid("cf64f69b-738b-4a15-885a-fcc7970e7615"), "144", "4622328821317280", null, null, new Guid("394e6c37-a398-4cf7-983d-8fb216e6c46f"), "09/14" },
                    { new Guid("cfa16ae2-4849-41a4-9ae6-57ce2bf136e8"), "508", "5676043291417620", null, null, new Guid("f4c8c27a-6b37-469c-9492-061adc476725"), "07/05" },
                    { new Guid("cfc52b6c-0957-4f73-a57a-6ac6a7e3d05d"), "868", "5199771387326729", null, null, new Guid("82b99640-3f2e-425b-a088-51b3c226a192"), "04/06" },
                    { new Guid("d05a9ecc-a821-48ed-ba1f-3220faca3d53"), "073", "2989156463768779", null, null, new Guid("be0a8a82-f1fd-45d5-8523-5b32db6fc767"), "09/11" },
                    { new Guid("d09f2a7f-69cb-4d08-8ffa-4e6819f9375e"), "318", "8402638067406463", null, null, new Guid("8dca8632-b27c-44ad-bd6c-0d7679a4f075"), "08/01" },
                    { new Guid("d0df209a-1d42-4c9f-8a87-e5d1f2216342"), "239", "5513303624909847", null, null, new Guid("bbe91897-98e6-4c1e-aef5-09cd3dbb35cd"), "04/16" },
                    { new Guid("d0f03981-ba7b-4f96-806a-c7a8704d47d9"), "037", "6103302326173313", null, null, new Guid("25c234e8-8d95-42b3-9dc3-c418fbcaa7da"), "09/26" },
                    { new Guid("d0f1e791-6c80-4447-a3fb-eaa8fcf5954b"), "546", "1547886411300256", null, null, new Guid("c6e8a5d8-6660-4e85-9ff9-1e6ec6d0c580"), "12/01" },
                    { new Guid("d1c47ea1-8a4f-4b49-80c6-3a919279358a"), "485", "7685417973211598", null, null, new Guid("74ef9233-8d34-4883-8938-b78b6c147246"), "12/05" },
                    { new Guid("d1e845da-ba67-4708-b561-460eedc83552"), "092", "7572396634388973", null, null, new Guid("658f3ddd-678c-4dca-b9fa-45901c0f1c05"), "11/22" },
                    { new Guid("d1f3b2b8-7391-42ae-9e22-424eb69e8570"), "005", "1276786690275322", null, null, new Guid("c5513371-ea13-4b3b-ab65-8bbb471b2afc"), "04/07" },
                    { new Guid("d2164af8-ef45-45c4-baba-a7bb33754813"), "912", "4888217456515157", null, null, new Guid("71f7fb3b-e7f1-4325-bdd2-98f71dd515b1"), "08/20" },
                    { new Guid("d2ac71e9-fb60-4e53-980e-5642e547b362"), "403", "1249217538497456", null, null, new Guid("c7c0cd55-07d8-41cc-9d2b-4bd04cb7edb3"), "09/07" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("d2c071b8-5bf1-4e12-9686-37e4c31aa98e"), "996", "5085819231404042", null, null, new Guid("0773e360-956e-4d39-94c5-d0906a9e4557"), "08/07" },
                    { new Guid("d4fc2bf7-84d5-4058-9d82-7cf3737d99ed"), "594", "6029433619105936", null, null, new Guid("61dcb7dd-eb57-4421-b814-6cd202b0f4a1"), "06/06" },
                    { new Guid("d5051aaf-7fa3-469f-af49-24af21d68655"), "651", "4929038730041696", null, null, new Guid("d43ee797-d0bc-4a3e-8833-c45e9d340f44"), "05/02" },
                    { new Guid("d53a4778-19ed-4028-bb51-6086f23ae2ae"), "227", "6011068621272539", null, null, new Guid("4f42e5ab-642c-4775-b2b2-a116ecfcd663"), "05/13" },
                    { new Guid("d5ead1b5-598e-44bf-864a-9009a74729b6"), "388", "7487874258073858", null, null, new Guid("2f8c0b43-80b3-437b-8a84-a763ed30230e"), "07/01" },
                    { new Guid("d60f7a48-da2a-47d0-926c-9a1a3bbc15d3"), "600", "4848973774532551", null, null, new Guid("2c87eaa4-8e07-41f4-bad0-935d07541e78"), "11/03" },
                    { new Guid("d62511c1-75fd-4cab-945b-6b8d17bcf037"), "543", "6849687096706524", null, null, new Guid("08589d86-24cf-48ee-b140-eab54649e215"), "07/24" },
                    { new Guid("d66419d8-d2a0-4bac-8b10-862de92b2fdc"), "081", "1358415644211892", null, null, new Guid("affd1717-742a-4014-8e72-3420c7496c1e"), "09/10" },
                    { new Guid("d6c9a99e-479c-4b12-9bc2-f6a984e3e88a"), "427", "4594622703619156", null, null, new Guid("5e1f9cf6-8e77-46be-92e7-b3f10da0ed86"), "01/18" },
                    { new Guid("d6e4bdde-a32b-4c3f-a8d6-60b8acddc5b2"), "078", "8824079182604729", null, null, new Guid("0a1370d0-5d3b-4609-9efc-9507f4acc2f8"), "05/02" },
                    { new Guid("d79b6a44-94ec-49fd-8f94-6a91326d879c"), "268", "6611899673809784", null, null, new Guid("4d006d0d-8a50-4d81-886b-176313d018fb"), "02/09" },
                    { new Guid("d81458cf-f865-42d5-a1e2-e04529fcfec4"), "880", "3680561913266831", null, null, new Guid("0877dbd6-c025-49ef-b189-53b217500382"), "10/03" },
                    { new Guid("d86f7d14-7fdf-48e1-b312-5a76bae1766f"), "061", "3628597959191680", null, null, new Guid("1937fdf7-97b0-4102-95c9-2163eb910112"), "02/10" },
                    { new Guid("d87f4e0f-9355-4e49-8ef7-be25c04c503d"), "668", "9293999721227158", null, null, new Guid("3ee0e809-4d8b-4164-a824-c5ab67903af7"), "03/03" },
                    { new Guid("d9c75a14-945d-4f67-aae9-42bfef8ad231"), "193", "7567214970918194", null, null, new Guid("7abaa815-d503-4740-a0a9-20d8752fc2cf"), "03/17" },
                    { new Guid("da1e425d-900d-4445-a2b8-efd9bb766073"), "661", "9327328856103768", null, null, new Guid("39d27a82-05d2-4135-b53b-53748eefd4f2"), "07/01" },
                    { new Guid("da60534c-efe0-476e-ad11-5ba934193d33"), "599", "2961337091303352", null, null, new Guid("fcf05f51-7f3a-4331-a0f5-6204db62e7ba"), "01/16" },
                    { new Guid("db1c3b9a-fdea-467a-8fc5-acc39840b9bc"), "195", "2014811862386718", null, null, new Guid("487efc58-2d93-4b91-a4fb-1ce1d3ef038a"), "07/13" },
                    { new Guid("db39e932-f5cf-47ab-953d-8f0dac9774e1"), "941", "5014060341572094", null, null, new Guid("3ee0e809-4d8b-4164-a824-c5ab67903af7"), "05/01" },
                    { new Guid("db823b31-8a9e-4bdc-8d56-69a06d10af26"), "479", "2976028144453783", null, null, new Guid("1bab23ea-659b-4531-ad24-fdfd8984675d"), "03/28" },
                    { new Guid("dbb64733-5ec7-446f-b22a-f7df12d94d71"), "855", "1544119992018651", null, null, new Guid("5c5b9127-2aa5-4ed6-b779-6402154d5c0f"), "05/17" },
                    { new Guid("dbbce033-7adb-4d00-a69f-b80d565b04d0"), "204", "8554034284827059", null, null, new Guid("a59d873d-ae08-427c-b25e-29c55895239f"), "03/16" },
                    { new Guid("dbda4a68-8656-4f5c-b7d7-42a498ee8f78"), "481", "9201408197254009", null, null, new Guid("c5efb9ab-d786-43d2-9595-c90aedaedb9b"), "02/28" },
                    { new Guid("dc955695-24c3-4aed-8cf7-b9aa0a0a4450"), "772", "5524575331398490", null, null, new Guid("6b5cd903-9056-4302-b3e6-b910c3a67f76"), "09/01" },
                    { new Guid("dcf07092-b749-4490-9351-1026d370f397"), "038", "1783120073358688", null, null, new Guid("56234ad9-accf-413f-8d2b-5d6fb1cd04a1"), "07/07" },
                    { new Guid("dd31e87f-30a5-4514-8992-f82ee41d3f97"), "677", "1987226739719213", null, null, new Guid("de7e4623-27a6-4a10-8c19-1f8ae8f689d2"), "10/17" },
                    { new Guid("dd7fde57-43b1-4a5f-903c-494ff88c146e"), "063", "4338106181911358", null, null, new Guid("1154bb55-7f7f-4d91-8347-5797ffeacb13"), "10/20" },
                    { new Guid("dd9a5f75-eece-4239-a652-967121d91134"), "713", "7430192785318649", null, null, new Guid("ea848f07-5360-4e76-ac1d-cf046366d4ef"), "06/05" },
                    { new Guid("ddcc5c68-e46b-4c92-9c5d-40501c416b26"), "930", "9707961832894122", null, null, new Guid("ac4ee7ff-56c7-4c45-ba3e-32ed6d9370f3"), "06/11" },
                    { new Guid("ddd08b20-380c-4a4d-9453-aab51cdb68ab"), "281", "9645409079549092", null, null, new Guid("4c5d0085-4956-4748-b989-09b4d927d669"), "03/16" },
                    { new Guid("ddea4659-69bb-4ee7-9c8a-1b3410577319"), "666", "8765905992112283", null, null, new Guid("9b254af5-9da3-4b42-a5f3-b573df408d84"), "12/27" },
                    { new Guid("ddfe749a-3019-41a9-9f10-3bb81a0a1f5e"), "383", "9128167493698454", null, null, new Guid("cf611bf3-21fb-4ed7-a138-00c7afdda9ba"), "01/11" },
                    { new Guid("de23e128-736b-4e52-9f14-01fe78f99604"), "567", "9537987327166546", null, null, new Guid("394e6c37-a398-4cf7-983d-8fb216e6c46f"), "01/26" },
                    { new Guid("dea9f7ba-7972-4b05-a2ba-48b05dab7b76"), "088", "4033796934549158", null, null, new Guid("61dcb7dd-eb57-4421-b814-6cd202b0f4a1"), "05/15" },
                    { new Guid("df7bf100-6963-4ec2-8088-7a036fdaf5d4"), "417", "2450162823973503", null, null, new Guid("07e77ffa-7983-4cb3-bfa5-a4b8ed39f91f"), "02/20" },
                    { new Guid("dfa10109-495d-4f2a-9079-5e48a9d7f90e"), "707", "4310326237469800", null, null, new Guid("8dca8632-b27c-44ad-bd6c-0d7679a4f075"), "10/26" },
                    { new Guid("e056f887-0f89-4c82-be20-e0b923d9a754"), "827", "3074524269018830", null, null, new Guid("d43ee797-d0bc-4a3e-8833-c45e9d340f44"), "09/18" },
                    { new Guid("e10de597-8bfc-4b14-b07d-11ecf76e9858"), "152", "3214606029336254", null, null, new Guid("815c5bf5-7253-492e-81c8-82e2d6860602"), "07/18" },
                    { new Guid("e1522dde-dd97-4e17-b876-55f66fbb1509"), "285", "1515769854540203", null, null, new Guid("aeae0f68-579f-46b8-bee2-c797ee09ee5e"), "08/26" },
                    { new Guid("e15b025d-9168-4372-8a17-3b9837ebde04"), "599", "1652699332672925", null, null, new Guid("df1ba0e6-99b8-419d-a3b8-cece7c4928bd"), "01/23" },
                    { new Guid("e15e3059-4aec-4045-b9dc-219bc0a16b52"), "978", "3745449622585537", null, null, new Guid("496d8ed2-fc6d-49e6-b902-8a1d0b266928"), "12/14" },
                    { new Guid("e1708519-d88e-462d-bf90-4304644e3e76"), "082", "6553324667587406", null, null, new Guid("0bf479c3-ab54-4392-b19e-a71b3942b7fe"), "02/24" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("e171f2db-ac30-4c3b-8d2b-94c087fdd40e"), "432", "7305289969925891", null, null, new Guid("0a1370d0-5d3b-4609-9efc-9507f4acc2f8"), "04/03" },
                    { new Guid("e180481c-2361-4afc-800b-61b5b56414e7"), "647", "7033102953028694", null, null, new Guid("dbc51236-052c-4c31-820d-b0a01a143d1a"), "09/28" },
                    { new Guid("e1825d13-a902-43c5-bfd5-77c3cc678813"), "083", "7586683385014242", null, null, new Guid("54c975d2-dbfe-4626-97fa-ceaa28e85030"), "10/25" },
                    { new Guid("e19dec9e-1a81-46eb-a876-40cfad0a236f"), "903", "2657201847472630", null, null, new Guid("914e0b17-40ab-478d-ba2c-61856d240679"), "03/24" },
                    { new Guid("e1fc5558-683d-4582-82fd-fe3c32529231"), "480", "1311590567586910", null, null, new Guid("6c3e0836-290a-4c10-8832-91720a2e9054"), "07/09" },
                    { new Guid("e2009416-876a-4eee-bff1-e48a119863c0"), "918", "7393849285579984", null, null, new Guid("3585370e-fea3-4a31-9a6c-93267371cc1d"), "07/21" },
                    { new Guid("e24f7b70-c603-4628-947a-22893b474f95"), "068", "3295830098125555", null, null, new Guid("a780acfd-e10d-4dc5-a383-1ba56a91e666"), "08/05" },
                    { new Guid("e3961688-7c8d-4243-b2f3-a5436877a14c"), "431", "6064923008833018", null, null, new Guid("dc5f8e5e-be11-43f9-acd2-648e38e09946"), "05/23" },
                    { new Guid("e3afff44-7bba-4dae-882a-1e51cc15719d"), "951", "8459309833430320", null, null, new Guid("5f366c1b-9e38-4bc9-b773-fca63347cbcc"), "03/18" },
                    { new Guid("e4580adf-8f7e-4388-a8f3-c026b65eeabf"), "641", "1100108951935347", null, null, new Guid("652ba8ca-0eee-4fb2-a548-4621f2c8de0b"), "05/16" },
                    { new Guid("e45e1623-74a5-4351-96fd-d9ae23331306"), "956", "1997553489303162", null, null, new Guid("0447d1d8-3e48-4d64-8d2e-7d9a733628ec"), "02/16" },
                    { new Guid("e49a8523-6681-4671-afa8-c6b6e6d75e27"), "716", "9132849975518281", null, null, new Guid("bd07490e-79db-4063-b992-0fa27e7f7677"), "11/22" },
                    { new Guid("e4a2dd38-74fa-41d0-a14e-8b3c07499e58"), "896", "6205787033461213", null, null, new Guid("a03e50af-2ee0-4392-86e9-a0420b2f24bb"), "09/11" },
                    { new Guid("e4b84c93-bf39-4a17-91ad-f6cd1f26bba7"), "476", "5221772610107380", null, null, new Guid("cf611bf3-21fb-4ed7-a138-00c7afdda9ba"), "10/16" },
                    { new Guid("e4d04afe-2403-4f2a-a86b-50adfeb2f746"), "826", "3056486979613493", null, null, new Guid("e2db5e4a-dcb2-42fc-b56b-17a4692bd0de"), "09/02" },
                    { new Guid("e5000899-6c01-44e7-8738-9bba1e0b166f"), "413", "4230075387304899", null, null, new Guid("e764f5ca-90fe-4d60-aab1-e56e02a1f110"), "03/01" },
                    { new Guid("e500b574-81c6-4d15-908d-2acba8057b2a"), "296", "4666170279722801", null, null, new Guid("adbbd240-641f-475b-b705-5e35298ef012"), "09/11" },
                    { new Guid("e55c0b2b-a11e-4313-9ae4-28a9d35f5405"), "363", "1513548326860195", null, null, new Guid("64174d68-43d3-488f-89bf-23d32b134019"), "12/13" },
                    { new Guid("e5b08a02-968d-441e-a2c8-5ec8c453d4ef"), "136", "9623414121431543", null, null, new Guid("7da75a84-c857-4768-9ff2-252052ea5333"), "02/06" },
                    { new Guid("e5e73115-5780-4768-abfd-49527da590ad"), "083", "1259337802520414", null, null, new Guid("06f4c32b-9a3d-4b38-99a4-56ea0ba685a8"), "01/06" },
                    { new Guid("e67d6d73-2d9e-402f-b55a-712c2e72d861"), "071", "3545320467524390", null, null, new Guid("ddf2bc3e-21a3-4bd8-8ebc-4afb8cb49df0"), "08/22" },
                    { new Guid("e686320e-ec16-4b04-a986-dc1dc8a7b734"), "032", "8494413299708271", null, null, new Guid("4188ab2e-f46b-4cf6-b460-560a914e5d35"), "06/16" },
                    { new Guid("e7767c77-94bc-4868-bc8b-b38c9a4579da"), "051", "5242204231367726", null, null, new Guid("71f7fb3b-e7f1-4325-bdd2-98f71dd515b1"), "05/05" },
                    { new Guid("e79eb235-24c0-4737-bd9f-8a11743566a7"), "134", "4908609063765295", null, null, new Guid("323967f9-cf4e-4818-a5bf-94dff7ea728b"), "09/26" },
                    { new Guid("e7f82a2c-d662-4b85-a322-2bf7eb1ed851"), "247", "7780928721564991", null, null, new Guid("718a03a0-2841-450f-a417-5345b18c81ab"), "03/18" },
                    { new Guid("e805c568-a1bf-4d12-8c65-e5e03bf3ae1e"), "973", "4113327873121934", null, null, new Guid("63107baa-d978-4764-b959-7e90a1de3ee0"), "04/15" },
                    { new Guid("e80ab0e4-42ca-4dc4-ac9c-1c05a6ab7657"), "188", "7322956315037950", null, null, new Guid("c221f46b-a606-417e-aead-c8b255d84d11"), "07/25" },
                    { new Guid("e8883b25-1a3f-4df8-94de-db58a51b889b"), "900", "9193806204420640", null, null, new Guid("50b1b40f-32d2-45da-a690-b9d24fff476e"), "01/27" },
                    { new Guid("e9539d25-7502-4c25-98be-17a022c9d60a"), "423", "3375737101012788", null, null, new Guid("49ef4ccb-eb29-4ffa-bcfe-88759ac3f1c5"), "10/13" },
                    { new Guid("e97172ec-6854-46df-b3bd-b6974b8b0174"), "721", "4188014704223805", null, null, new Guid("539c62ee-15fc-4d37-ab5d-0e4126109954"), "08/25" },
                    { new Guid("e9d58802-5fa4-432d-96b9-68d20e66633a"), "560", "5110839602264725", null, null, new Guid("7de3e658-53a0-464d-a4aa-b7bf40828f5d"), "12/05" },
                    { new Guid("e9d65924-c737-44cc-833b-a817f86860e8"), "064", "3337623971151662", null, null, new Guid("56c8b4b0-c1db-425e-a349-2f7b3feabb5e"), "09/08" },
                    { new Guid("ea18eb8b-0019-473d-b4e9-3d85e0625a5e"), "989", "2320339690853261", null, null, new Guid("77bc83c5-7598-48f0-b4c1-23f76fd277ca"), "02/23" },
                    { new Guid("ea66f72e-60c8-43c4-86e8-bcfb7c788451"), "258", "9081328930179634", null, null, new Guid("b8e5286e-6ec4-4001-89c4-e17065f9bf09"), "02/28" },
                    { new Guid("ea872e61-ab11-4dfe-8b1c-b3a3ce531eb4"), "534", "9436469198068559", null, null, new Guid("6ef84803-7ff7-46d1-b1b3-ebda82e158b3"), "11/02" },
                    { new Guid("eab03f32-5cd0-449f-ba7f-b9fe7cc81972"), "655", "8153350554957218", null, null, new Guid("2411a1da-d71e-4e02-a40e-984ec689c7bd"), "09/19" },
                    { new Guid("eb2d75db-994b-4920-a46f-b2a6047b073a"), "383", "1853305829024105", null, null, new Guid("8fc5f8c0-3711-4486-8ea0-48697b9ea01f"), "03/17" },
                    { new Guid("eb2fd448-f7ac-4d4f-9484-e75fd2d79931"), "359", "6492724904836923", null, null, new Guid("3a262ff7-1654-4c72-9285-3ba10eac6509"), "03/24" },
                    { new Guid("eb976a24-86bd-4bbb-85ae-611737b03940"), "455", "4645055813313501", null, null, new Guid("0773e360-956e-4d39-94c5-d0906a9e4557"), "05/07" },
                    { new Guid("ebf781d3-460f-41a1-b023-2edcea1093fb"), "514", "8402048185655451", null, null, new Guid("8867eb2c-20d1-43a8-8081-18744798ef5a"), "06/14" },
                    { new Guid("ec08f6c0-95e1-42a9-aee9-830c38b4eb62"), "395", "4165948355573758", null, null, new Guid("0b65bf95-8c8c-4e28-8317-122f0f66a78e"), "11/06" },
                    { new Guid("ec1aa61b-6ce2-41a9-a8aa-48f70349639c"), "035", "1331777486955431", null, null, new Guid("097cb7d3-d333-48aa-b8ee-cacd11ee91fa"), "10/01" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("eceb214f-005e-43cb-86f5-eef6dda7aebc"), "266", "9072348998046612", null, null, new Guid("3ff3d88e-b078-4f3a-8312-8447eeb772e2"), "11/08" },
                    { new Guid("ed9a74d0-c071-4285-ac0c-3abc37272520"), "824", "4669363865111195", null, null, new Guid("57b666b4-3a1b-4303-851f-a88f5f534543"), "07/05" },
                    { new Guid("eda050e1-9e19-46ac-b0e1-7dd7aa124161"), "314", "1037940740204716", null, null, new Guid("8f876cca-154f-4381-adab-41c9e894d046"), "08/12" },
                    { new Guid("ee02ee37-3555-4340-ae92-c9bdf95327ee"), "255", "5067721755254483", null, null, new Guid("0d6ec0b6-076d-4fc4-8519-424b1c8bf28e"), "01/22" },
                    { new Guid("ee087f4c-bc7a-477a-9f01-c5f3aa4b3c25"), "071", "7864839943339701", null, null, new Guid("9ec54876-333f-4825-9959-c839395cb66e"), "11/16" },
                    { new Guid("ee0e325c-16d7-4d9a-a476-210a1d9f0825"), "901", "1914008579779091", null, null, new Guid("cf3285c8-97d7-426d-87f3-e0854194e226"), "10/07" },
                    { new Guid("ee1ff2da-0dd6-4fa8-8179-e44f08de8551"), "556", "4004724592717682", null, null, new Guid("9e39f449-ecbf-4238-8ca8-47309c134789"), "05/09" },
                    { new Guid("ef5795ee-00bd-4930-92c6-f2aaff42ab24"), "250", "6731419076712020", null, null, new Guid("3b3e9016-3025-48e3-93b2-fa474015c0f7"), "06/11" },
                    { new Guid("ef981f8b-ce54-4357-9739-69c7d8295ff7"), "094", "4902444751455153", null, null, new Guid("c66d96b2-e569-4470-a3b9-82ba83e46c97"), "02/04" },
                    { new Guid("ef9a9f96-343c-4309-a227-22324cc089e0"), "769", "2977055330586150", null, null, new Guid("548e47d4-b851-4432-8514-fc092768db5b"), "04/03" },
                    { new Guid("efcf681a-f31a-4db7-bc85-7097b5295406"), "114", "7813126287606251", null, null, new Guid("8c18ec85-46f2-44b0-bd0b-56adb1bf7743"), "06/13" },
                    { new Guid("efd5e3c4-5545-4b4f-a4e9-152a871d5fb0"), "078", "4247306138076170", null, null, new Guid("2e3a99a4-4308-410d-b67e-4763bbd6b9c8"), "08/20" },
                    { new Guid("efde3885-d12e-4a50-b09d-137bbe62db5f"), "497", "8654240496030645", null, null, new Guid("d43ee797-d0bc-4a3e-8833-c45e9d340f44"), "08/14" },
                    { new Guid("f00c167e-7af3-40a1-9201-9cb061298e95"), "238", "5708183997742681", null, null, new Guid("548e47d4-b851-4432-8514-fc092768db5b"), "03/12" },
                    { new Guid("f014f2d1-f511-439c-9603-455722552064"), "265", "6600308166885444", null, null, new Guid("db32027d-cf9c-4544-af7d-d20c917925c7"), "08/10" },
                    { new Guid("f0e4a100-830e-4ef9-bfac-807dea1bd104"), "966", "2846863479722031", null, null, new Guid("652ba8ca-0eee-4fb2-a548-4621f2c8de0b"), "08/12" },
                    { new Guid("f116ce1b-69c5-4331-99c1-ede2cfaac83e"), "010", "5528618475679627", null, null, new Guid("6c3e0836-290a-4c10-8832-91720a2e9054"), "08/02" },
                    { new Guid("f14c3151-b3aa-47ee-bf4c-428114d93d5d"), "551", "2568823118190268", null, null, new Guid("c5efb9ab-d786-43d2-9595-c90aedaedb9b"), "08/28" },
                    { new Guid("f1702a14-523b-4b8e-bc82-74eb5e18fa94"), "368", "5112413943422953", null, null, new Guid("50ac14d1-c13d-42f2-8026-301c38b1964b"), "09/16" },
                    { new Guid("f1c830f3-7dfc-46cd-889c-6d41cda9d746"), "239", "3898130480990451", null, null, new Guid("914e0b17-40ab-478d-ba2c-61856d240679"), "10/21" },
                    { new Guid("f1fd41a6-f20b-4e41-bee4-6bc068ef103b"), "230", "5916015172546020", null, null, new Guid("653800c1-b55d-4636-99c0-ea31223d7e3b"), "11/24" },
                    { new Guid("f2ec4b21-beaa-40de-b9bb-359e0f676522"), "409", "4007853848728043", null, null, new Guid("adbbd240-641f-475b-b705-5e35298ef012"), "09/11" },
                    { new Guid("f302d7a1-e640-4c63-b748-45f62c16f94a"), "130", "2390344750908628", null, null, new Guid("c0ff772c-b38f-4860-9c1e-4c49d424f9a5"), "06/05" },
                    { new Guid("f3e0169e-59b0-413a-a4aa-6a5f49ea63f8"), "775", "1692390835717097", null, null, new Guid("a9090dd7-3795-48e2-837b-9a72a0274d7b"), "11/21" },
                    { new Guid("f4243a43-0433-4b66-9676-0900f07401e3"), "362", "2750203124285996", null, null, new Guid("757f3f70-fdce-4727-8fcf-9ac8aa0287b3"), "09/01" },
                    { new Guid("f4a42464-3d3c-4d40-ae35-f5f88b60a0be"), "604", "9232668896206700", null, null, new Guid("4f42e5ab-642c-4775-b2b2-a116ecfcd663"), "05/04" },
                    { new Guid("f4c67ee0-76ab-4245-bda3-66e95cdae1d7"), "767", "7168138190239573", null, null, new Guid("9ee8d8bd-022b-4718-b8f4-cc38174e988c"), "09/18" },
                    { new Guid("f4f2b4fb-1b81-4af6-9327-6b662d050e9a"), "335", "7726295727532498", null, null, new Guid("3f1a1c74-7f9a-433e-808b-f0d69f6d97e7"), "12/19" },
                    { new Guid("f520c708-8739-4d13-a985-767d196277d2"), "545", "5011320154327376", null, null, new Guid("8b3afef3-3bbb-4237-b8b8-1eba1df7757e"), "06/16" },
                    { new Guid("f553ab44-0c1d-4b9e-8c7a-248e5f7bea5d"), "574", "4872125418237504", null, null, new Guid("54c975d2-dbfe-4626-97fa-ceaa28e85030"), "12/19" },
                    { new Guid("f57a97a9-0d4d-488e-b83e-03f81e7921f1"), "989", "5997387141252389", null, null, new Guid("9ee8d8bd-022b-4718-b8f4-cc38174e988c"), "10/28" },
                    { new Guid("f5e8de64-d27a-43d1-8e2f-05a50a630195"), "441", "1156339073109267", null, null, new Guid("56c8b4b0-c1db-425e-a349-2f7b3feabb5e"), "07/27" },
                    { new Guid("f685ca77-7f87-45ae-9469-d66709543bec"), "532", "6812622284338059", null, null, new Guid("bc7c70fa-9300-4c06-afd7-8aa97fcf9993"), "10/07" },
                    { new Guid("f6ddad9d-f048-410e-b572-90f205058544"), "304", "1335197509484968", null, null, new Guid("2476b4fb-aceb-40f6-b636-80dd269d535c"), "03/24" },
                    { new Guid("f7006c38-da86-4787-90b0-a76ef6baea5b"), "128", "3147016905951468", null, null, new Guid("487f0344-4cde-4b10-971a-1f8311cce3f5"), "04/07" },
                    { new Guid("f7222971-b65b-4414-aee4-631db226501c"), "387", "2797083375701709", null, null, new Guid("48b3cd65-be2f-4be1-a3c5-d88da44b3d73"), "03/23" },
                    { new Guid("f7c98b79-f006-4607-95e6-24c6073b09bb"), "311", "6483554024037511", null, null, new Guid("21d9b3f2-945c-40a1-a0ca-7b6fcbe38a4e"), "04/28" },
                    { new Guid("f7e0fa71-0db2-4a93-b928-97714b762072"), "179", "9589443912351800", null, null, new Guid("d3cba19c-d75f-49cd-8bce-3e5563428a3a"), "07/19" },
                    { new Guid("f82cdf71-cbbd-416e-b2cd-2af979f6513f"), "464", "1252616053773446", null, null, new Guid("6ab8f9db-6513-4d8f-9cde-7b925ff51057"), "06/22" },
                    { new Guid("f8445ea2-df14-402c-b652-c5414cf7c1bc"), "673", "5007076914782961", null, null, new Guid("a6a8eca4-cb2e-43f7-9ea2-cbc644c8f9d8"), "03/15" },
                    { new Guid("f90e8271-0517-4251-b7e7-7fba203e4728"), "012", "6937272861067252", null, null, new Guid("530579fa-33a7-4827-a21f-b9cacab42c7d"), "09/12" },
                    { new Guid("f93c32ce-e938-49af-9e45-cb0b80585981"), "992", "7217763325162823", null, null, new Guid("c58f524e-a96e-4e8b-9186-6c21d38d64b3"), "10/20" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("f9c10e50-5653-4dd7-b2ac-3a7a7417960e"), "713", "4187954321327455", null, null, new Guid("d43ee797-d0bc-4a3e-8833-c45e9d340f44"), "09/25" },
                    { new Guid("f9f0ddb0-77c4-4164-a504-115980e2ef80"), "454", "7447986193296062", null, null, new Guid("f3cb510a-8243-4204-8c1f-ace56610d45f"), "03/08" },
                    { new Guid("fa3aabcd-e199-468c-b125-f2aa3a49fcbb"), "493", "6349663760839566", null, null, new Guid("f7082ecf-eb66-429e-8a3f-72fac7d7b453"), "07/11" },
                    { new Guid("faa86574-395a-481d-b9c7-c1c0a1d5821b"), "088", "5070002415268279", null, null, new Guid("36ffb969-580b-40d2-8fa0-94749ea99214"), "07/17" },
                    { new Guid("fb3f417f-5709-4745-82a2-e0569880cccb"), "892", "1803614158936820", null, null, new Guid("8b3afef3-3bbb-4237-b8b8-1eba1df7757e"), "07/18" },
                    { new Guid("fc71c661-ae31-4df3-8803-806ce0f4eac0"), "369", "3795103698964743", null, null, new Guid("5d203345-c58f-4236-9e46-c9ba7a8529a5"), "08/14" },
                    { new Guid("fcaaf18d-6ac9-40fa-9eea-ea13e1825dbb"), "644", "6190034458755063", null, null, new Guid("0a8fb680-a380-4d35-85da-ff3cf9faa245"), "02/01" },
                    { new Guid("fcd43e51-0a46-4bc7-9470-ee67476f4905"), "842", "9853530278606547", null, null, new Guid("ce7719fc-1874-4df0-88ba-9b5637945029"), "12/11" },
                    { new Guid("fd99ddfd-c781-4a7f-bfb1-1937946e9179"), "733", "4121659756743101", null, null, new Guid("c221f46b-a606-417e-aead-c8b255d84d11"), "08/13" },
                    { new Guid("fe917b05-25fe-41b2-afbf-2c9e56e35ca0"), "199", "1275001406026895", null, null, new Guid("c5513371-ea13-4b3b-ab65-8bbb471b2afc"), "08/16" },
                    { new Guid("fed42577-18ad-4b86-9a12-fa269d4e14cb"), "324", "8036661468069236", null, null, new Guid("f5fa9239-e966-4c8e-9eb5-32ecf277976e"), "10/13" },
                    { new Guid("fede5aa0-a9dc-43d7-9284-cae169b91405"), "136", "5062192807435622", null, null, new Guid("3585370e-fea3-4a31-9a6c-93267371cc1d"), "03/13" },
                    { new Guid("ff27f632-20a3-49b9-8967-a17f0e5ed18f"), "878", "9212017014199569", null, null, new Guid("f3cb510a-8243-4204-8c1f-ace56610d45f"), "05/15" },
                    { new Guid("ff780569-9a47-419c-b23b-afca583350f8"), "244", "8288625495138233", null, null, new Guid("78be92c8-3390-4d5e-aa3a-54c7301eaf2f"), "06/17" },
                    { new Guid("ffac2d77-4ff4-4492-aaad-82dd5c453c42"), "988", "6452869737000375", null, null, new Guid("980189d0-dcc8-4676-93bf-39ec81288e2f"), "11/15" },
                    { new Guid("fff5620f-fab8-44d7-84c5-04d1a4becb13"), "618", "7353036265627433", null, null, new Guid("82f7ffb4-bdb1-40a8-8d2d-67f1c2f5bf91"), "05/03" }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("004e0d02-0815-4f57-9218-fa290c0219f3"), null, null, "+477 95 (308) 01-55", new Guid("4188ab2e-f46b-4cf6-b460-560a914e5d35") },
                    { new Guid("0067402c-a96d-4b7c-ad4d-947cec69f8cd"), null, null, "+385 40 (022) 92-25", new Guid("ac4ee7ff-56c7-4c45-ba3e-32ed6d9370f3") },
                    { new Guid("00ca4c82-847b-4a89-bcfd-bb33477d22e1"), null, null, "+124 49 (265) 47-70", new Guid("719d1670-ba7d-4e9b-b4de-d7074f81aa66") },
                    { new Guid("00cfc2e4-12a5-4d6f-860b-90eb21cdc27e"), null, null, "+771 82 (505) 87-79", new Guid("0bf479c3-ab54-4392-b19e-a71b3942b7fe") },
                    { new Guid("018802ff-523d-4657-91ee-bdde86bba070"), null, null, "+780 97 (488) 53-70", new Guid("b1817475-7a6c-44d8-8e81-4b59b1f4923e") },
                    { new Guid("01f9f3aa-d3b3-4d12-9a7a-2320a85fe660"), null, null, "+13 31 (920) 24-78", new Guid("f28f3fdf-fa90-4b58-895f-89b7f89e53e9") },
                    { new Guid("02ee0b50-e37e-4a64-ac95-ecca2e832436"), null, null, "+51 60 (252) 39-06", new Guid("2c87eaa4-8e07-41f4-bad0-935d07541e78") },
                    { new Guid("02f4f038-9f6a-4a4c-8342-64101bf0ffa6"), null, null, "+766 89 (087) 02-30", new Guid("c6e8a5d8-6660-4e85-9ff9-1e6ec6d0c580") },
                    { new Guid("032a1bc1-8d17-479a-ab91-4f4d83fe45eb"), null, null, "+559 18 (314) 81-17", new Guid("c7f42761-e210-47b4-9e39-2df36dce4c96") },
                    { new Guid("03545ec5-36f1-42a0-9ffa-9b68f4cd1bf5"), null, null, "+437 15 (099) 11-75", new Guid("08589d86-24cf-48ee-b140-eab54649e215") },
                    { new Guid("036452cd-1fef-492a-82ab-97f3e84641ca"), null, null, "+685 11 (329) 96-03", new Guid("a943e809-55d9-482f-a592-8709b5f7d47f") },
                    { new Guid("03b128e5-5994-4f30-9f05-f187c5c4b9b2"), null, null, "+804 70 (724) 15-76", new Guid("cf348fa5-7d32-48ec-957c-eb481beb0358") },
                    { new Guid("04035ce5-79f9-4664-bfa3-faf4a5b4c481"), null, null, "+105 08 (199) 51-85", new Guid("548e47d4-b851-4432-8514-fc092768db5b") },
                    { new Guid("04740735-b27a-4253-990f-c70a37475703"), null, null, "+289 56 (659) 73-79", new Guid("4e8c89c0-a2fb-42d3-8d7a-11fe5d3b6d75") },
                    { new Guid("047a3c78-2fa5-478a-8070-9c02c207899d"), null, null, "+165 75 (036) 34-19", new Guid("f4c8c27a-6b37-469c-9492-061adc476725") },
                    { new Guid("04f09398-c841-4881-a2a3-88c396cef6e0"), null, null, "+979 36 (453) 80-98", new Guid("980189d0-dcc8-4676-93bf-39ec81288e2f") },
                    { new Guid("0546779a-9c99-4302-b8ea-db1ce69a2dcb"), null, null, "+759 75 (107) 25-44", new Guid("c590f92c-3ca1-4a33-a976-926995a0f7cc") },
                    { new Guid("054b41d2-c0b3-461b-9824-19bb984fac54"), null, null, "+123 75 (540) 35-13", new Guid("32feb777-af06-4813-9108-9d7acfd0bd04") },
                    { new Guid("0663f294-697a-4189-8db7-c59010e61005"), null, null, "+148 06 (756) 95-32", new Guid("72a42c8b-ed7c-4e7a-81c6-313cac897b20") },
                    { new Guid("06cb229a-2c4c-4310-a8fe-474571ef6e93"), null, null, "+301 07 (411) 21-37", new Guid("dbc51236-052c-4c31-820d-b0a01a143d1a") },
                    { new Guid("06ff198b-7661-417b-b878-564abacbfb62"), null, null, "+900 29 (827) 08-99", new Guid("bbaf9fe2-9863-4589-964a-23c62e6bf830") },
                    { new Guid("07b7e292-6c30-41fe-be8a-2ad48f8e3186"), null, null, "+101 15 (933) 01-21", new Guid("0c66002d-25be-4864-84e7-acd6fd765b27") },
                    { new Guid("0824dddb-5193-43d1-aff0-3ff34a85f0dd"), null, null, "+837 65 (296) 49-00", new Guid("4fdddaf5-83dc-4f45-ad82-fcab10f87405") },
                    { new Guid("08b01da8-c52d-410c-8e41-41ba0ea7ded5"), null, null, "+863 78 (173) 96-78", new Guid("40a279f6-73dd-4fa2-8b1e-05f9cd8bdcf9") },
                    { new Guid("08c00d8c-ae99-48cf-81ba-35e726298007"), null, null, "+516 46 (877) 29-69", new Guid("1a21f215-231c-4e09-b7c2-4e3163978286") },
                    { new Guid("08d602ef-a77f-4c3f-af1c-09825851e18e"), null, null, "+294 87 (802) 11-02", new Guid("bd07490e-79db-4063-b992-0fa27e7f7677") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("096cb6c5-d617-47c2-8247-4a26ceb58a9c"), null, null, "+310 12 (939) 77-49", new Guid("539c62ee-15fc-4d37-ab5d-0e4126109954") },
                    { new Guid("09917d4c-fd31-4ba8-8a55-66c7e1fc9567"), null, null, "+938 50 (282) 77-13", new Guid("8e3d5153-23be-45f9-83b4-5aecbb1a4322") },
                    { new Guid("0a0b09dc-a8d9-485c-ab21-d44e4611f63f"), null, null, "+116 74 (807) 54-65", new Guid("3712e35b-2da9-4c76-ad88-28828e776a5c") },
                    { new Guid("0b0199ae-fbc4-45cf-821a-0166f02bec21"), null, null, "+79 46 (186) 75-83", new Guid("80c8c606-5918-4559-bdbb-606d564f96d5") },
                    { new Guid("0b28639c-9425-4760-b34d-1f90b6d1dce7"), null, null, "+462 48 (967) 64-06", new Guid("7de3e658-53a0-464d-a4aa-b7bf40828f5d") },
                    { new Guid("0b96605b-7b17-4655-9baa-c084131a37d3"), null, null, "+153 32 (393) 77-29", new Guid("871feb78-0a5f-4d88-8754-a386270f590d") },
                    { new Guid("0bd599de-2a7c-481b-abe3-34c2bdb3ad1f"), null, null, "+550 10 (530) 62-49", new Guid("93e9e8fa-8b76-4968-a1ef-a4d59b6958ea") },
                    { new Guid("0bedfb17-2370-47f8-bd3b-864fffda605f"), null, null, "+746 72 (145) 73-77", new Guid("a419df27-9358-4a02-9ab7-2f2e2344fae0") },
                    { new Guid("0c2712cf-328b-4dec-b3de-f9a00414e283"), null, null, "+869 11 (903) 56-84", new Guid("6b5cd903-9056-4302-b3e6-b910c3a67f76") },
                    { new Guid("0cbb8989-a8af-4724-9b31-25603033be75"), null, null, "+85 69 (837) 85-54", new Guid("df1ba0e6-99b8-419d-a3b8-cece7c4928bd") },
                    { new Guid("0d1b91d6-a695-4863-83aa-da58e356edbd"), null, null, "+317 73 (703) 78-93", new Guid("fe7a3052-1ad9-4450-b9d5-057c6abe9c2e") },
                    { new Guid("0d4e2e29-b635-4cb2-b339-6aff4b03f848"), null, null, "+908 11 (756) 86-48", new Guid("323967f9-cf4e-4818-a5bf-94dff7ea728b") },
                    { new Guid("0d5d543b-3cb7-415a-b2b6-30d8cf837ce8"), null, null, "+488 84 (055) 85-70", new Guid("10766e70-305e-4e2a-8560-ffeb596a93eb") },
                    { new Guid("0dbf48f9-0993-439a-a7d7-de163d14bf2b"), null, null, "+318 43 (071) 84-44", new Guid("2c87eaa4-8e07-41f4-bad0-935d07541e78") },
                    { new Guid("0dcb19d5-14d6-4156-af60-bf13598dced7"), null, null, "+106 28 (098) 54-15", new Guid("815c5bf5-7253-492e-81c8-82e2d6860602") },
                    { new Guid("0e59a564-57f9-41f6-93cc-9bb42d3fc581"), null, null, "+579 11 (070) 90-81", new Guid("61dcb7dd-eb57-4421-b814-6cd202b0f4a1") },
                    { new Guid("0f570af7-6282-40cc-a2fd-60fa6196c93a"), null, null, "+659 98 (169) 20-00", new Guid("c7c0cd55-07d8-41cc-9d2b-4bd04cb7edb3") },
                    { new Guid("0f8642ae-4b59-4063-aa12-cda5f45777e1"), null, null, "+750 72 (495) 46-74", new Guid("c221f46b-a606-417e-aead-c8b255d84d11") },
                    { new Guid("0fa325e2-bd9a-47ab-9a71-09ea47456c9e"), null, null, "+169 44 (564) 19-10", new Guid("8c30b7e6-1da3-4a5c-87ba-544b9377a290") },
                    { new Guid("0fb38246-ee1f-44b5-be03-4c25fcc3361c"), null, null, "+642 72 (936) 65-22", new Guid("2e3a99a4-4308-410d-b67e-4763bbd6b9c8") },
                    { new Guid("0fd0ce11-137b-4733-abde-89d08b8e7050"), null, null, "+235 29 (657) 06-20", new Guid("7de3e658-53a0-464d-a4aa-b7bf40828f5d") },
                    { new Guid("10058885-c0f4-40f4-a61b-29e7597ea454"), null, null, "+848 09 (670) 89-19", new Guid("a9090dd7-3795-48e2-837b-9a72a0274d7b") },
                    { new Guid("102429db-7279-41bb-9589-1ceee7b6b83f"), null, null, "+855 96 (260) 19-58", new Guid("f7dacdb6-cd5e-4c55-a2df-710f582d75f2") },
                    { new Guid("1058b91e-1b1b-4112-ac42-15bcf8472da1"), null, null, "+966 16 (289) 15-82", new Guid("c590f92c-3ca1-4a33-a976-926995a0f7cc") },
                    { new Guid("107fb112-cba9-4537-b9ad-1aab94124a0a"), null, null, "+761 37 (700) 32-65", new Guid("4b45c810-f446-449d-8b0e-4a2ebbbf7104") },
                    { new Guid("10861040-516c-430f-af8b-c0ab11b7ef20"), null, null, "+433 76 (006) 01-80", new Guid("c3cc5785-6364-48fa-bb83-e7ac33fc672b") },
                    { new Guid("10d0bf21-acff-461a-ab0d-f9b078f8d5ef"), null, null, "+30 59 (301) 62-40", new Guid("07e77ffa-7983-4cb3-bfa5-a4b8ed39f91f") },
                    { new Guid("1106258a-9ec6-4327-8e6c-d9bc47496ae0"), null, null, "+736 22 (153) 24-90", new Guid("4f42e5ab-642c-4775-b2b2-a116ecfcd663") },
                    { new Guid("113aa1d7-8e7b-4ef5-85d7-993968265671"), null, null, "+198 45 (252) 49-95", new Guid("3a19b458-72b3-4b5b-97e6-334a56d7d557") },
                    { new Guid("11bf22da-dfc7-4881-a7c1-2bacb4c15850"), null, null, "+570 00 (237) 48-19", new Guid("108fbff3-4041-4eed-b2a0-4a4b1fb47787") },
                    { new Guid("11f3b697-cff8-4495-9cc5-8c11959093d4"), null, null, "+23 22 (058) 87-90", new Guid("df1ba0e6-99b8-419d-a3b8-cece7c4928bd") },
                    { new Guid("13194f58-a403-47e3-936a-d49602f1c1c7"), null, null, "+828 14 (063) 76-65", new Guid("6c3f8b98-7095-4d12-8f55-02b23a300d5f") },
                    { new Guid("131e1587-f98a-40b8-88a9-4ddd560f71e7"), null, null, "+469 49 (869) 93-56", new Guid("e36aac18-179d-420c-8aaa-edf7ff736e50") },
                    { new Guid("13752e4f-f58d-4314-b899-6ea6445ebc7e"), null, null, "+199 55 (673) 78-36", new Guid("fcf05f51-7f3a-4331-a0f5-6204db62e7ba") },
                    { new Guid("137c160b-aa6d-452c-b7fa-4f37edaa6766"), null, null, "+720 01 (562) 02-35", new Guid("4fdddaf5-83dc-4f45-ad82-fcab10f87405") },
                    { new Guid("1390968f-dcea-4fb8-a7dd-aea35238af25"), null, null, "+12 65 (136) 31-82", new Guid("a2c81266-ca25-4e08-bddc-c6ccfe9435e2") },
                    { new Guid("13ad7b0a-d353-4960-a212-7b0cd6289569"), null, null, "+111 54 (928) 36-29", new Guid("48b3cd65-be2f-4be1-a3c5-d88da44b3d73") },
                    { new Guid("13f2fc6f-2bad-46af-bd2b-6909c709ed29"), null, null, "+430 42 (737) 88-39", new Guid("76c44275-2d3e-43e9-b34e-c05f912213b8") },
                    { new Guid("166d2bbe-ad80-46fb-8f1e-5f730cd6eb95"), null, null, "+618 84 (079) 18-06", new Guid("bc7c70fa-9300-4c06-afd7-8aa97fcf9993") },
                    { new Guid("16c458af-160f-4d54-801c-9fe73314185a"), null, null, "+910 73 (997) 15-35", new Guid("71f7fb3b-e7f1-4325-bdd2-98f71dd515b1") },
                    { new Guid("16d957df-b389-496e-82b0-829841468063"), null, null, "+576 53 (651) 73-49", new Guid("75ba16eb-aa9c-4c6f-90ae-1515360055a9") },
                    { new Guid("17e4cd53-d24a-415a-8bd2-b9965fd2aeaf"), null, null, "+528 00 (893) 30-23", new Guid("a03e50af-2ee0-4392-86e9-a0420b2f24bb") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("1800c614-a23d-4ac7-bf7b-a03a01166dd1"), null, null, "+537 80 (529) 40-20", new Guid("8a696f30-76c2-40db-a250-030829547d67") },
                    { new Guid("186cc66d-88b2-4362-ad2f-67c86d8f969f"), null, null, "+933 68 (122) 21-40", new Guid("0e6930e6-cf0a-4195-8d74-a9cc0dfb30b6") },
                    { new Guid("18925596-3af3-48cd-88cd-f47654738f97"), null, null, "+656 22 (031) 67-66", new Guid("e5406e78-ce40-43ee-8dee-e58fe7687eb3") },
                    { new Guid("18b334ed-9dcb-4359-9fb5-09b404dbb61c"), null, null, "+259 45 (800) 96-85", new Guid("be0a8a82-f1fd-45d5-8523-5b32db6fc767") },
                    { new Guid("191199d4-0a6c-455a-bd92-5395b0dc9414"), null, null, "+10 44 (759) 18-32", new Guid("5c5b9127-2aa5-4ed6-b779-6402154d5c0f") },
                    { new Guid("1915d247-ee81-4967-b707-f4f5c0148dc0"), null, null, "+296 13 (453) 45-21", new Guid("4732299f-418c-4c2e-ac09-aacb3b2c8976") },
                    { new Guid("1a05fa22-00ef-4c26-bc6e-5f7b7805a76d"), null, null, "+928 05 (148) 05-99", new Guid("32feb777-af06-4813-9108-9d7acfd0bd04") },
                    { new Guid("1a0b6e3a-1e36-44e2-99a7-ad64f566130a"), null, null, "+68 16 (373) 46-85", new Guid("5e1f9cf6-8e77-46be-92e7-b3f10da0ed86") },
                    { new Guid("1a593641-082c-43f6-9ca9-d5f969cf2056"), null, null, "+427 88 (638) 82-84", new Guid("2411a1da-d71e-4e02-a40e-984ec689c7bd") },
                    { new Guid("1a6b5215-33a2-4ed9-8eb5-48345a7e7582"), null, null, "+428 97 (405) 28-67", new Guid("0bf479c3-ab54-4392-b19e-a71b3942b7fe") },
                    { new Guid("1ad9d0fb-607a-4cad-9cf6-367fb7fdb7f5"), null, null, "+447 29 (162) 07-93", new Guid("f2c5c231-fa4f-4403-a17b-f986cd15543a") },
                    { new Guid("1ae37414-7ff1-4c84-b6f4-8f7221dae459"), null, null, "+597 52 (278) 70-61", new Guid("ac984856-387b-48de-9d39-5cfa956d354e") },
                    { new Guid("1afceb72-cd90-486a-bc81-dbb37c67329a"), null, null, "+256 13 (424) 14-63", new Guid("1e17494c-b19d-4879-af0e-c6575db6bd37") },
                    { new Guid("1b380e90-e06c-487f-85e0-f60e2cd83890"), null, null, "+942 29 (866) 77-58", new Guid("718a03a0-2841-450f-a417-5345b18c81ab") },
                    { new Guid("1b4ab8e0-9fbc-4070-8ad8-5af453478f03"), null, null, "+181 80 (524) 63-13", new Guid("ce7719fc-1874-4df0-88ba-9b5637945029") },
                    { new Guid("1b62730b-d90e-4bec-afea-ed9e212761d5"), null, null, "+289 10 (554) 27-64", new Guid("78be92c8-3390-4d5e-aa3a-54c7301eaf2f") },
                    { new Guid("1b808a2e-1a6c-4cc5-88b7-91c7fc58e14b"), null, null, "+411 51 (790) 32-97", new Guid("54c975d2-dbfe-4626-97fa-ceaa28e85030") },
                    { new Guid("1bb9f6a7-81ef-4bc6-8a29-ea35e7040945"), null, null, "+992 77 (684) 73-63", new Guid("8ea935b6-2c30-4bef-803c-9f382789979b") },
                    { new Guid("1bf63acc-364f-4990-a991-f1e4aefb2a73"), null, null, "+227 91 (330) 26-86", new Guid("7cf58058-5eec-4c6e-a4ae-cf50ccf0b2ac") },
                    { new Guid("1c4487d9-1f70-4b88-9fd2-a5bdcc8dad42"), null, null, "+973 56 (292) 83-27", new Guid("fe7a3052-1ad9-4450-b9d5-057c6abe9c2e") },
                    { new Guid("1c857fe6-79bb-4f9a-97c2-26e56471c964"), null, null, "+142 15 (393) 65-46", new Guid("71f7fb3b-e7f1-4325-bdd2-98f71dd515b1") },
                    { new Guid("1cb49f9c-ad84-46f3-be7f-729aaa5124e2"), null, null, "+582 27 (055) 40-25", new Guid("48f4af12-c8b0-4444-98ca-81df5d349e01") },
                    { new Guid("1cd89672-a911-43f2-bd39-01f1e05b16d3"), null, null, "+147 72 (183) 82-62", new Guid("56c8b4b0-c1db-425e-a349-2f7b3feabb5e") },
                    { new Guid("1d39cefa-862f-48af-8ceb-416264d9f433"), null, null, "+486 29 (817) 98-71", new Guid("7e4a74cd-b47b-47e6-ab98-22ed32bd8e27") },
                    { new Guid("1d64624b-7772-47cd-8c49-0499bad57f35"), null, null, "+507 91 (672) 59-05", new Guid("9ee8d8bd-022b-4718-b8f4-cc38174e988c") },
                    { new Guid("1d7bdaaf-d77a-4b57-8061-829028d02be6"), null, null, "+657 52 (351) 20-71", new Guid("f7082ecf-eb66-429e-8a3f-72fac7d7b453") },
                    { new Guid("1d953b43-b5f1-47d0-9b61-2dff1a63cec8"), null, null, "+130 61 (671) 59-81", new Guid("ac5a7dc0-9da2-4c23-9acc-ec9828404cd5") },
                    { new Guid("1d9c4f32-4ce6-405b-a408-6b443d0edc5a"), null, null, "+214 48 (621) 34-77", new Guid("06f4c32b-9a3d-4b38-99a4-56ea0ba685a8") },
                    { new Guid("1ddeaad1-fc77-4145-86cb-8fba6d60905f"), null, null, "+155 91 (875) 60-96", new Guid("757f3f70-fdce-4727-8fcf-9ac8aa0287b3") },
                    { new Guid("1dfc6bc3-7ff1-4852-8554-32f08ba8a1e2"), null, null, "+264 94 (485) 90-12", new Guid("ea848f07-5360-4e76-ac1d-cf046366d4ef") },
                    { new Guid("1e215f74-e91d-4f59-a147-e2dc94cf11d4"), null, null, "+999 42 (514) 01-38", new Guid("141e6ca1-3b19-4ffc-a21f-8420c3f6db52") },
                    { new Guid("1e2a07db-c355-4004-9ba6-1b933041afb7"), null, null, "+121 78 (789) 05-89", new Guid("54c975d2-dbfe-4626-97fa-ceaa28e85030") },
                    { new Guid("1e6ff08a-ac49-4629-a188-e1ff5bdec75f"), null, null, "+795 30 (655) 91-08", new Guid("0a8fb680-a380-4d35-85da-ff3cf9faa245") },
                    { new Guid("1e778711-f77e-4450-8649-c58ecf8b98ba"), null, null, "+549 08 (217) 59-13", new Guid("5d203345-c58f-4236-9e46-c9ba7a8529a5") },
                    { new Guid("1eb3733b-4eb0-4c7f-9c23-de210e931544"), null, null, "+322 57 (311) 40-03", new Guid("ed1f5061-44e1-4df4-b0de-bc0c17fd0185") },
                    { new Guid("1ec2ce97-2cf6-4b64-9c22-5323ffde7b7c"), null, null, "+9 33 (019) 40-49", new Guid("7a52231d-ba53-47d6-8382-e5bf5f9e7e24") },
                    { new Guid("1eca683c-2246-439d-981b-50851dcb43b6"), null, null, "+651 30 (752) 29-80", new Guid("815c5bf5-7253-492e-81c8-82e2d6860602") },
                    { new Guid("1f9d9cb9-3c67-4905-b66e-87c0aff25692"), null, null, "+622 23 (039) 59-47", new Guid("adbbd240-641f-475b-b705-5e35298ef012") },
                    { new Guid("1fb37145-f8ca-4203-8121-a4631e4e720b"), null, null, "+849 45 (160) 45-27", new Guid("1cdde210-cf9c-4b69-a64c-3995a2267739") },
                    { new Guid("1ff641d3-e5db-4c97-bc35-b1945f656196"), null, null, "+454 98 (148) 86-30", new Guid("dd550cd7-4eae-4d75-8be5-5f3e496fdd24") },
                    { new Guid("201c90d7-e290-4024-a4ff-5f95029fc02d"), null, null, "+24 18 (586) 45-87", new Guid("c7f42761-e210-47b4-9e39-2df36dce4c96") },
                    { new Guid("20f1ae32-22a8-444f-95ca-027ac9c1ad74"), null, null, "+242 47 (695) 55-12", new Guid("c7f42761-e210-47b4-9e39-2df36dce4c96") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("21495659-2d20-4b51-a2b9-8658aa0bad26"), null, null, "+638 79 (692) 95-83", new Guid("bbe91897-98e6-4c1e-aef5-09cd3dbb35cd") },
                    { new Guid("2153c3da-62f1-4f52-9394-19704fcd550c"), null, null, "+306 51 (699) 29-36", new Guid("d1d503de-e688-46df-9a53-6ca07b1d716f") },
                    { new Guid("219f8644-cf73-4570-addf-32032c75d249"), null, null, "+207 99 (735) 73-00", new Guid("34e9aed1-9d94-41dd-a50e-2e11424b25e1") },
                    { new Guid("21ecdaac-4f5d-4d6d-8724-9e7eebc99f87"), null, null, "+73 76 (572) 01-88", new Guid("6218849a-9af3-4ab0-93d1-f5fd29135491") },
                    { new Guid("22a14552-c753-4fe8-bc8e-5cb230e94ec7"), null, null, "+21 54 (498) 86-61", new Guid("1cdde210-cf9c-4b69-a64c-3995a2267739") },
                    { new Guid("22ef89d0-552b-439f-8fec-f205c8883b12"), null, null, "+780 58 (356) 46-63", new Guid("b1817475-7a6c-44d8-8e81-4b59b1f4923e") },
                    { new Guid("231a5d62-6887-45f4-b9ef-53f7657b2fa6"), null, null, "+527 96 (371) 39-67", new Guid("087fb413-124f-47b1-b54e-4bdedf2edf63") },
                    { new Guid("23572a56-99fc-4921-a86d-d4f5f275859f"), null, null, "+935 52 (907) 25-19", new Guid("50b1b40f-32d2-45da-a690-b9d24fff476e") },
                    { new Guid("2369754e-2481-4b0d-9ff9-78637b323661"), null, null, "+430 29 (112) 13-26", new Guid("182bd5c0-616f-4e9b-8837-7c2b67e01496") },
                    { new Guid("242a062d-a994-46d4-8b82-8f79620c37b8"), null, null, "+319 10 (863) 60-39", new Guid("70d04e87-92ed-4410-96a6-934a82c8bbcb") },
                    { new Guid("24d8a428-cde5-43cb-ae57-3d4ef01c73be"), null, null, "+856 01 (054) 30-71", new Guid("46542d6d-04cc-418a-88b4-cda40f4aff48") },
                    { new Guid("24e4a839-74f6-4114-8bb9-548129d041c8"), null, null, "+60 83 (293) 78-55", new Guid("de7e4623-27a6-4a10-8c19-1f8ae8f689d2") },
                    { new Guid("25610fa3-5e55-4999-9826-a01ee9d58cfd"), null, null, "+169 43 (131) 30-28", new Guid("f5fa9239-e966-4c8e-9eb5-32ecf277976e") },
                    { new Guid("25622997-af25-4ff3-8cba-0ddeaddd740a"), null, null, "+934 83 (237) 16-18", new Guid("9ec54876-333f-4825-9959-c839395cb66e") },
                    { new Guid("25671eaa-9047-44f7-87d5-0016411482ca"), null, null, "+400 79 (204) 69-58", new Guid("0e6930e6-cf0a-4195-8d74-a9cc0dfb30b6") },
                    { new Guid("25c2a3dc-791a-408f-995c-264f5adcd959"), null, null, "+461 23 (470) 50-85", new Guid("6b5cd903-9056-4302-b3e6-b910c3a67f76") },
                    { new Guid("25ceb71c-2ce3-453a-a3e3-c6132911fb50"), null, null, "+630 50 (136) 54-83", new Guid("9e39f449-ecbf-4238-8ca8-47309c134789") },
                    { new Guid("261711c3-1310-4e30-97aa-7665f8c75d5f"), null, null, "+927 11 (077) 87-45", new Guid("2411a1da-d71e-4e02-a40e-984ec689c7bd") },
                    { new Guid("26472115-364a-4a4e-b318-ab3ad5b8f013"), null, null, "+911 37 (755) 46-93", new Guid("8fc5f8c0-3711-4486-8ea0-48697b9ea01f") },
                    { new Guid("264b7161-8165-441d-aee7-0fabd839154a"), null, null, "+571 90 (206) 23-58", new Guid("75ba16eb-aa9c-4c6f-90ae-1515360055a9") },
                    { new Guid("268517b5-8f45-427b-b32a-48cd6e664907"), null, null, "+737 41 (856) 54-34", new Guid("6c3e0836-290a-4c10-8832-91720a2e9054") },
                    { new Guid("2747f4cf-4389-4670-bafa-1a536dcfbb9a"), null, null, "+531 39 (728) 35-48", new Guid("230e73b5-4a4b-4b1c-ad48-f7a0074303c7") },
                    { new Guid("27a6b644-a23d-4cec-a91a-bd63ae8ccb79"), null, null, "+130 92 (354) 81-28", new Guid("3c3a765d-c1b9-47c7-b39a-7b5dc35e1cbc") },
                    { new Guid("27ad4648-b658-41d7-8f62-d449c06e62c6"), null, null, "+727 01 (174) 52-18", new Guid("9ee8d8bd-022b-4718-b8f4-cc38174e988c") },
                    { new Guid("27f9db36-6481-428e-a586-ad9a44ba015b"), null, null, "+687 29 (287) 36-80", new Guid("fcf05f51-7f3a-4331-a0f5-6204db62e7ba") },
                    { new Guid("28c0025b-1fad-4959-a1a3-40d1028bf768"), null, null, "+974 49 (673) 39-59", new Guid("e36aac18-179d-420c-8aaa-edf7ff736e50") },
                    { new Guid("295d887f-eb76-400e-adce-261ab138b2cf"), null, null, "+988 84 (065) 17-32", new Guid("482632b6-5f62-4fe4-82e0-1b6f0d3ee842") },
                    { new Guid("29c61c1e-daa5-448c-9ad3-efc689e48b46"), null, null, "+743 33 (145) 72-76", new Guid("7da75a84-c857-4768-9ff2-252052ea5333") },
                    { new Guid("2abeb1fd-a29b-4781-9452-d92cbd24710e"), null, null, "+883 41 (949) 16-25", new Guid("aeae0f68-579f-46b8-bee2-c797ee09ee5e") },
                    { new Guid("2adcb61c-2d2c-471b-97aa-7f0ebf42c0b9"), null, null, "+589 63 (351) 98-28", new Guid("c88c725e-8cbf-416d-a4bf-153a024ea6c9") },
                    { new Guid("2b27f9bd-b879-4213-801e-a3c85e93bf7c"), null, null, "+375 14 (833) 97-06", new Guid("1937fdf7-97b0-4102-95c9-2163eb910112") },
                    { new Guid("2bc27b62-71e6-47d2-a768-fe71eec950ca"), null, null, "+115 10 (049) 66-13", new Guid("0635daf3-649c-437b-92ef-713d43246a0a") },
                    { new Guid("2c241c5f-bb7a-43dc-b040-3b0d1b1c9aa3"), null, null, "+192 71 (065) 95-82", new Guid("718a03a0-2841-450f-a417-5345b18c81ab") },
                    { new Guid("2c52468f-43ce-4242-9eab-a861da628c38"), null, null, "+511 18 (729) 20-13", new Guid("9ff0a0ca-02d0-4209-bb8f-a0d7efaf75bb") },
                    { new Guid("2c64bc88-7ef7-4522-8ae2-58806023b6b3"), null, null, "+902 83 (434) 38-43", new Guid("d43ee797-d0bc-4a3e-8833-c45e9d340f44") },
                    { new Guid("2c68281e-bac3-4815-a2de-a50567eb4d03"), null, null, "+196 58 (930) 42-01", new Guid("7abaa815-d503-4740-a0a9-20d8752fc2cf") },
                    { new Guid("2c8bb59d-d695-4a42-8a62-6bacbeecc6b9"), null, null, "+195 98 (318) 26-66", new Guid("d43ee797-d0bc-4a3e-8833-c45e9d340f44") },
                    { new Guid("2c9b9054-a38b-40c5-a3c2-f3a44e084e44"), null, null, "+323 66 (018) 87-82", new Guid("8dca8632-b27c-44ad-bd6c-0d7679a4f075") },
                    { new Guid("2d00186e-5a43-4edb-985e-a1677c4eed7d"), null, null, "+658 34 (080) 08-91", new Guid("a419df27-9358-4a02-9ab7-2f2e2344fae0") },
                    { new Guid("2d4f3cf1-7931-45dd-bf59-27a4ab992db1"), null, null, "+640 12 (583) 15-58", new Guid("f51931e0-68b3-4aed-8f03-7ef9a8526650") },
                    { new Guid("2d5506f0-147a-40c8-aa00-dc799bb14ed9"), null, null, "+386 69 (658) 26-76", new Guid("5f366c1b-9e38-4bc9-b773-fca63347cbcc") },
                    { new Guid("2db7f422-ca16-40a2-ba4b-27863a148dc5"), null, null, "+395 05 (620) 23-48", new Guid("cf3285c8-97d7-426d-87f3-e0854194e226") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("2efe1969-ef86-48c1-b68a-763011eb4e21"), null, null, "+217 27 (021) 38-47", new Guid("74ef9233-8d34-4883-8938-b78b6c147246") },
                    { new Guid("2f08cbbb-0dc8-457b-b5e1-cff7c2a20631"), null, null, "+927 81 (377) 08-26", new Guid("a780acfd-e10d-4dc5-a383-1ba56a91e666") },
                    { new Guid("2f2bc909-3c80-41bb-8a2a-16109e8d8bde"), null, null, "+17 52 (903) 04-42", new Guid("3ff3d88e-b078-4f3a-8312-8447eeb772e2") },
                    { new Guid("2f4b4aea-9fc9-45cc-9eaf-1ea15eee41b7"), null, null, "+371 84 (800) 00-90", new Guid("7c2f2e0c-1d40-453b-84ea-f5f09cb10d28") },
                    { new Guid("2f51d11f-a403-4619-a855-44ff7148676a"), null, null, "+916 06 (005) 71-28", new Guid("8b3afef3-3bbb-4237-b8b8-1eba1df7757e") },
                    { new Guid("2f607190-1346-4a89-8b8a-d82b45919178"), null, null, "+634 03 (442) 86-04", new Guid("0635daf3-649c-437b-92ef-713d43246a0a") },
                    { new Guid("2f891aa4-0a50-4388-b060-cb239539de72"), null, null, "+705 36 (311) 89-93", new Guid("719d1670-ba7d-4e9b-b4de-d7074f81aa66") },
                    { new Guid("2fb9f65a-d79b-46f2-a1ac-91322045a5ed"), null, null, "+290 25 (116) 73-76", new Guid("0e6930e6-cf0a-4195-8d74-a9cc0dfb30b6") },
                    { new Guid("30041c20-434e-4b48-81df-f4a571c4881d"), null, null, "+519 11 (385) 69-19", new Guid("7778b4eb-db56-4ddd-a0bc-5f46aff077f7") },
                    { new Guid("300fd75d-86db-40c0-9d0a-3ea93b00ba68"), null, null, "+690 08 (084) 01-35", new Guid("4efd0f6e-db18-4603-b7c2-f032eb9132a9") },
                    { new Guid("307a9cfe-f51f-42e4-82c5-c4be882f0e88"), null, null, "+162 18 (473) 63-06", new Guid("4fdddaf5-83dc-4f45-ad82-fcab10f87405") },
                    { new Guid("309b39af-cd8a-4c78-a52c-d7b1757fce0e"), null, null, "+580 92 (390) 53-10", new Guid("353c126e-57f5-471a-b13f-0e4fd4cef2fe") },
                    { new Guid("30b0b5ce-704e-478b-b78c-ae3b8e986ec7"), null, null, "+224 53 (409) 69-97", new Guid("753e85fe-b18a-442a-b91e-1d9dc9216d93") },
                    { new Guid("30e16031-2546-4a49-9835-ab4126e9e06c"), null, null, "+138 82 (486) 05-27", new Guid("a2c81266-ca25-4e08-bddc-c6ccfe9435e2") },
                    { new Guid("30eaa69c-5507-4a2a-a22b-b1f78429cb38"), null, null, "+309 20 (752) 60-08", new Guid("b53497b3-fabe-4282-a5c6-ef6e82864309") },
                    { new Guid("31162d09-3efd-41af-a5eb-230031943e58"), null, null, "+551 35 (929) 38-05", new Guid("3c3a765d-c1b9-47c7-b39a-7b5dc35e1cbc") },
                    { new Guid("311cc3e6-374b-44fb-80d0-b2f57d314b3e"), null, null, "+323 83 (794) 86-89", new Guid("3ee0e809-4d8b-4164-a824-c5ab67903af7") },
                    { new Guid("314a11c0-5a25-4ac1-9ede-22caf84185d1"), null, null, "+638 10 (967) 13-78", new Guid("c5513371-ea13-4b3b-ab65-8bbb471b2afc") },
                    { new Guid("31a68ed6-aea2-4a35-be7f-fd84a3982890"), null, null, "+617 08 (818) 28-58", new Guid("56c8b4b0-c1db-425e-a349-2f7b3feabb5e") },
                    { new Guid("31daba7d-0dc7-46c1-b89d-5f51b27d943b"), null, null, "+576 14 (954) 72-38", new Guid("7da75a84-c857-4768-9ff2-252052ea5333") },
                    { new Guid("31f5df19-b853-4545-8b97-15c43c6c97f9"), null, null, "+365 89 (361) 64-89", new Guid("fcf05f51-7f3a-4331-a0f5-6204db62e7ba") },
                    { new Guid("31f82ff3-b715-4c69-9ddc-397ebb00a56e"), null, null, "+969 41 (090) 34-48", new Guid("5d1e2a88-0f0a-4b6e-a524-e279224a1944") },
                    { new Guid("31faeb5e-ec67-4aac-92b3-debf9ca0198c"), null, null, "+235 52 (809) 12-43", new Guid("77bc83c5-7598-48f0-b4c1-23f76fd277ca") },
                    { new Guid("3219f611-bcc0-4aa7-bc14-a74386d97311"), null, null, "+477 88 (290) 88-07", new Guid("01424fda-76cf-4203-995c-a75e43c1d1d0") },
                    { new Guid("3236606c-efc9-41dc-ba9d-5f976ca5a746"), null, null, "+851 71 (525) 77-10", new Guid("c5513371-ea13-4b3b-ab65-8bbb471b2afc") },
                    { new Guid("32845ec6-eb3f-4d7c-b8e4-266ef2e8a72a"), null, null, "+665 02 (724) 73-14", new Guid("2c87eaa4-8e07-41f4-bad0-935d07541e78") },
                    { new Guid("329cbf6b-fdde-40de-a1b6-f6bc46f62570"), null, null, "+629 15 (338) 23-74", new Guid("67a258f9-5c48-4651-8f32-1ee7f5b4246d") },
                    { new Guid("32b42f18-784a-42b7-87b2-7e8cfa583baf"), null, null, "+707 74 (743) 83-17", new Guid("aec475ab-9ab8-4f55-8794-ee1ffc6f6da6") },
                    { new Guid("33444bd4-a476-4a5c-b9ee-7ff232ad57dd"), null, null, "+438 54 (571) 46-16", new Guid("54c975d2-dbfe-4626-97fa-ceaa28e85030") },
                    { new Guid("33c02d14-6e4d-4ab4-b0e5-75a20787c6e1"), null, null, "+562 80 (182) 97-69", new Guid("4083c32d-a4cd-4c70-b794-fa7b97aafe4e") },
                    { new Guid("340d2443-aacf-4e02-82e9-b888e432a8ff"), null, null, "+734 30 (856) 18-16", new Guid("35275876-97ec-44a4-8503-f21c815c9a45") },
                    { new Guid("346092a0-e130-4343-9015-0ea859910b37"), null, null, "+700 30 (479) 96-40", new Guid("5d203345-c58f-4236-9e46-c9ba7a8529a5") },
                    { new Guid("34880667-0df6-45e7-9e23-5a3a3e8d2b4f"), null, null, "+506 92 (436) 12-80", new Guid("c6e8a5d8-6660-4e85-9ff9-1e6ec6d0c580") },
                    { new Guid("34d4b677-f62c-4017-8561-e76860e3cde5"), null, null, "+407 87 (380) 10-13", new Guid("66da7f26-36d5-4406-a2e4-35363c8e43cb") },
                    { new Guid("35132aa0-7482-41e2-a52f-7985961e68b9"), null, null, "+980 28 (748) 29-37", new Guid("c88c725e-8cbf-416d-a4bf-153a024ea6c9") },
                    { new Guid("352194d2-7370-4ef4-a651-67c1d35d0347"), null, null, "+971 61 (056) 20-09", new Guid("0773e360-956e-4d39-94c5-d0906a9e4557") },
                    { new Guid("358b2335-212b-428d-b626-87c0d8e3e6a0"), null, null, "+242 45 (089) 91-00", new Guid("bd07490e-79db-4063-b992-0fa27e7f7677") },
                    { new Guid("360d1f90-a1df-45e2-914b-af0d62a43bc7"), null, null, "+530 65 (554) 28-06", new Guid("c3cc5785-6364-48fa-bb83-e7ac33fc672b") },
                    { new Guid("36645675-3d3b-49eb-95e2-cf796e1f3c33"), null, null, "+229 49 (116) 64-09", new Guid("6c3e0836-290a-4c10-8832-91720a2e9054") },
                    { new Guid("3681fec4-b180-4ad3-8d02-c65235e5092d"), null, null, "+452 80 (312) 19-69", new Guid("c2701daa-7747-422a-bb74-d9ffc8e0f5fc") },
                    { new Guid("36d1e872-aeac-4e8f-afb6-6eef3b165069"), null, null, "+160 97 (344) 34-66", new Guid("d0aae9a2-8c5b-48e9-b856-e309c80cadae") },
                    { new Guid("36e22b9d-117c-443d-8e1f-43cf0677751f"), null, null, "+891 99 (105) 51-47", new Guid("aec475ab-9ab8-4f55-8794-ee1ffc6f6da6") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("36ed4dcc-c918-4ab8-8f59-a6c027c342f7"), null, null, "+728 02 (798) 11-86", new Guid("496d8ed2-fc6d-49e6-b902-8a1d0b266928") },
                    { new Guid("3720f3ba-8c75-48bf-9ef8-73f567839474"), null, null, "+182 88 (256) 24-44", new Guid("cf611bf3-21fb-4ed7-a138-00c7afdda9ba") },
                    { new Guid("3740818f-c55e-4735-bf42-8bb49c985008"), null, null, "+45 73 (707) 95-17", new Guid("59a9232d-40d9-422d-8a1a-fe022e85093a") },
                    { new Guid("37504046-ef1f-4fa1-b71d-c21307046883"), null, null, "+57 58 (020) 78-43", new Guid("42babbec-5dbe-4cc3-9f68-bb4bc7ad9491") },
                    { new Guid("37dd8f93-1fec-4a97-a169-61f5d218add2"), null, null, "+479 56 (742) 91-35", new Guid("b40d8226-58de-4e86-811d-0e6b38686d57") },
                    { new Guid("380b510d-b3ec-498b-93e9-839b0cc04f7c"), null, null, "+541 72 (050) 09-71", new Guid("4c5d0085-4956-4748-b989-09b4d927d669") },
                    { new Guid("380f495f-f425-422f-886f-d259a7ed0dc8"), null, null, "+349 08 (990) 07-33", new Guid("0776f148-3954-48ff-8bb8-772d353c1a3c") },
                    { new Guid("381b2242-3997-422d-82a0-cf054804968b"), null, null, "+432 09 (911) 67-06", new Guid("b5cca55a-d81f-47be-b0b4-50d07e79ce69") },
                    { new Guid("3847c79a-9be4-4b31-bc0c-b29304a5b2a0"), null, null, "+660 52 (098) 50-93", new Guid("75ba16eb-aa9c-4c6f-90ae-1515360055a9") },
                    { new Guid("394095ff-f6eb-4c7c-8dfd-62e47db91c63"), null, null, "+335 67 (198) 87-51", new Guid("94c09a0c-18a4-40c8-9285-032386267d16") },
                    { new Guid("398e2a8f-ba13-47a4-a70b-df9e3c1a1829"), null, null, "+908 99 (118) 83-86", new Guid("e5406e78-ce40-43ee-8dee-e58fe7687eb3") },
                    { new Guid("399f72a4-1a95-4bad-8dc6-c70b90cfbaa2"), null, null, "+797 80 (032) 56-05", new Guid("394e6c37-a398-4cf7-983d-8fb216e6c46f") },
                    { new Guid("39fe5fc1-9733-4428-afcc-110b7a026a82"), null, null, "+118 36 (110) 23-03", new Guid("0d88a4e0-8366-4547-8ebe-087d4c74b34f") },
                    { new Guid("3ad44991-6345-4b03-abd4-b0098913d1ac"), null, null, "+557 63 (315) 03-93", new Guid("dbc51236-052c-4c31-820d-b0a01a143d1a") },
                    { new Guid("3ae58188-89da-4a5e-b78c-47e96f12d77b"), null, null, "+763 15 (870) 92-06", new Guid("a59d873d-ae08-427c-b25e-29c55895239f") },
                    { new Guid("3af23fbc-639f-4ce2-ab84-d0abac65979e"), null, null, "+768 35 (328) 12-31", new Guid("e2db5e4a-dcb2-42fc-b56b-17a4692bd0de") },
                    { new Guid("3b5594f5-ccdf-489d-aa02-218be9ef897e"), null, null, "+922 32 (858) 24-76", new Guid("4188ab2e-f46b-4cf6-b460-560a914e5d35") },
                    { new Guid("3be6cf0f-e8bf-4139-9865-3ad8ffc8913b"), null, null, "+663 75 (518) 21-53", new Guid("530579fa-33a7-4827-a21f-b9cacab42c7d") },
                    { new Guid("3c00e0ad-1899-4ba8-95c6-361292d67ec4"), null, null, "+281 63 (964) 13-04", new Guid("07e77ffa-7983-4cb3-bfa5-a4b8ed39f91f") },
                    { new Guid("3c11e26c-c697-4a84-9048-abccd818715a"), null, null, "+693 46 (229) 55-88", new Guid("46843658-5438-46a9-b26a-f6c2fcfd1883") },
                    { new Guid("3cac4dc9-6331-441f-89ce-6d643b1c34a2"), null, null, "+376 80 (378) 17-58", new Guid("405a5eb1-aee0-4578-8748-2d8b5a6b0d57") },
                    { new Guid("3da713cb-194f-4d52-93ea-d73eaa6f1da4"), null, null, "+822 76 (419) 66-24", new Guid("914e0b17-40ab-478d-ba2c-61856d240679") },
                    { new Guid("3e161235-a365-4a0c-9411-321bcf14906d"), null, null, "+236 68 (941) 19-43", new Guid("1e17494c-b19d-4879-af0e-c6575db6bd37") },
                    { new Guid("3ec8c600-dee5-44a9-bbaf-b6fe1a98ff5d"), null, null, "+14 82 (752) 76-01", new Guid("c5efb9ab-d786-43d2-9595-c90aedaedb9b") },
                    { new Guid("3f0c645d-d48e-4c67-8a5b-7b2cc3298913"), null, null, "+384 54 (246) 03-30", new Guid("bbaf9fe2-9863-4589-964a-23c62e6bf830") },
                    { new Guid("3f6ecd5f-393f-4006-bd83-0af8f935c3d2"), null, null, "+132 71 (029) 10-30", new Guid("a9090dd7-3795-48e2-837b-9a72a0274d7b") },
                    { new Guid("3fea9cf0-3f47-42ca-8ac5-2289af7acd73"), null, null, "+288 42 (259) 00-06", new Guid("a6a8eca4-cb2e-43f7-9ea2-cbc644c8f9d8") },
                    { new Guid("401f3a67-6082-4876-a9ef-18ad6b1a9336"), null, null, "+348 35 (147) 88-42", new Guid("2f8c0b43-80b3-437b-8a84-a763ed30230e") },
                    { new Guid("411b6fcf-bb2f-4d2a-9089-55639e35f6f7"), null, null, "+513 20 (594) 91-03", new Guid("6c16f159-98d6-4d70-a7ac-43b19b827d49") },
                    { new Guid("4142d598-0013-41e6-9f37-1ae96663e724"), null, null, "+917 08 (979) 12-93", new Guid("5f366c1b-9e38-4bc9-b773-fca63347cbcc") },
                    { new Guid("418c5fea-39d3-4e2f-8e10-101fb6fa9a41"), null, null, "+384 17 (868) 97-32", new Guid("c66d96b2-e569-4470-a3b9-82ba83e46c97") },
                    { new Guid("42809c7e-b735-4752-b625-209aa1f12460"), null, null, "+802 11 (461) 25-09", new Guid("4d006d0d-8a50-4d81-886b-176313d018fb") },
                    { new Guid("434e4b03-2c81-4026-aff1-3da961a366e8"), null, null, "+947 97 (569) 47-63", new Guid("df3cc97e-5297-4426-8d73-6ec8a1d6ff19") },
                    { new Guid("43726d7a-44d3-4904-9a57-a2ad8e46b88a"), null, null, "+334 83 (820) 53-91", new Guid("0ec010bc-7e48-4cb9-bb93-8dd9d5b37f6d") },
                    { new Guid("438b35c0-963c-40d8-a71d-998be5f016c6"), null, null, "+802 39 (089) 15-90", new Guid("7da75a84-c857-4768-9ff2-252052ea5333") },
                    { new Guid("43f2dbd2-d68b-41e3-bfec-27f20470b608"), null, null, "+262 46 (758) 45-26", new Guid("405a5eb1-aee0-4578-8748-2d8b5a6b0d57") },
                    { new Guid("43f7aadc-7bec-4cc6-9af0-c85ef8ae43e6"), null, null, "+601 50 (511) 89-56", new Guid("3ee0e809-4d8b-4164-a824-c5ab67903af7") },
                    { new Guid("44678163-bb8a-48c1-9dfa-d86720113099"), null, null, "+327 93 (474) 73-52", new Guid("405a5eb1-aee0-4578-8748-2d8b5a6b0d57") },
                    { new Guid("4476e694-1ec9-4838-847f-d664d73eb072"), null, null, "+73 04 (463) 78-64", new Guid("92a5d027-0cfb-43ec-84b3-d812837c5654") },
                    { new Guid("44c4b1d4-97d5-4944-8483-3113df1598cb"), null, null, "+515 44 (286) 78-08", new Guid("5aff4312-b9a9-4958-b14a-305be3aa9f4b") },
                    { new Guid("45407297-b475-4c8c-8d6e-0aeec1632ded"), null, null, "+978 42 (985) 18-86", new Guid("8e3d5153-23be-45f9-83b4-5aecbb1a4322") },
                    { new Guid("4593243d-52ba-4e4c-8e22-b80c427964ab"), null, null, "+552 10 (320) 37-19", new Guid("2bdbd536-e4dc-4869-9dac-f62a098ecb05") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("4641fe99-48e3-4e2e-b38d-bd476d4b7010"), null, null, "+900 32 (432) 91-56", new Guid("539c62ee-15fc-4d37-ab5d-0e4126109954") },
                    { new Guid("478ed495-80b4-4879-bbbf-3547a8a98822"), null, null, "+837 80 (250) 30-57", new Guid("dc52bf7b-d952-45c3-8bf0-44dadbfbb09e") },
                    { new Guid("47df528f-00e4-4ccf-bc3c-42db19e23482"), null, null, "+423 10 (088) 36-93", new Guid("c66d96b2-e569-4470-a3b9-82ba83e46c97") },
                    { new Guid("482c0647-098a-4838-8888-ce92b9d870bb"), null, null, "+654 61 (020) 84-70", new Guid("fcf05f51-7f3a-4331-a0f5-6204db62e7ba") },
                    { new Guid("48327e85-33d9-42f2-beba-fa9a79d1778d"), null, null, "+230 80 (167) 43-05", new Guid("50ac14d1-c13d-42f2-8026-301c38b1964b") },
                    { new Guid("48eddd68-04bd-4e72-82ea-8bad6bb8f08c"), null, null, "+366 94 (582) 20-74", new Guid("3b3e9016-3025-48e3-93b2-fa474015c0f7") },
                    { new Guid("492d5dc5-1c87-451c-82bc-fe8875cd9baf"), null, null, "+733 27 (636) 49-24", new Guid("0447d1d8-3e48-4d64-8d2e-7d9a733628ec") },
                    { new Guid("4a3d7a8b-bfae-4dca-9cc2-c1b84d22585f"), null, null, "+559 15 (391) 95-02", new Guid("48b3cd65-be2f-4be1-a3c5-d88da44b3d73") },
                    { new Guid("4b829526-b2c8-4577-8dd7-1d6c305d927c"), null, null, "+608 53 (201) 60-84", new Guid("c66d96b2-e569-4470-a3b9-82ba83e46c97") },
                    { new Guid("4b908418-4c09-43a0-9cfd-e9e7ea99124c"), null, null, "+89 71 (919) 71-66", new Guid("42c4353e-7775-4c68-a647-2b921bb87c89") },
                    { new Guid("4bcfa111-bd1b-4093-b944-5f5e5fa1e55f"), null, null, "+787 39 (040) 59-60", new Guid("db91ddfb-75b6-4d51-82ea-52631a102b16") },
                    { new Guid("4bda48a6-717b-4e13-9ab7-d8d325151600"), null, null, "+535 89 (373) 34-40", new Guid("658f3ddd-678c-4dca-b9fa-45901c0f1c05") },
                    { new Guid("4bf577a8-9753-4571-97aa-5c2e8cf9a900"), null, null, "+173 44 (825) 81-83", new Guid("dd550cd7-4eae-4d75-8be5-5f3e496fdd24") },
                    { new Guid("4c971247-cb99-463e-8ee1-cb744119b8ea"), null, null, "+45 81 (448) 95-81", new Guid("97e11482-d5e6-41d7-82e3-80806df9c3bc") },
                    { new Guid("4cc4fd6d-9a3a-4082-adb4-3503f895ff77"), null, null, "+767 20 (926) 63-51", new Guid("c6e8a5d8-6660-4e85-9ff9-1e6ec6d0c580") },
                    { new Guid("4cca8365-04be-4613-8cd4-92b7ff55d698"), null, null, "+138 75 (886) 02-55", new Guid("22edc826-6747-4099-aca5-578199353ac6") },
                    { new Guid("4ce780d5-d22f-4040-a3f0-e2a0b6df84fb"), null, null, "+313 05 (725) 98-02", new Guid("77bc83c5-7598-48f0-b4c1-23f76fd277ca") },
                    { new Guid("4d32c591-eec1-4abd-bfc4-c4f37c3f95bc"), null, null, "+986 95 (444) 11-42", new Guid("718a03a0-2841-450f-a417-5345b18c81ab") },
                    { new Guid("4d8ff5f1-8dcd-437f-9b13-81fa4cd2b52b"), null, null, "+957 78 (375) 95-87", new Guid("980189d0-dcc8-4676-93bf-39ec81288e2f") },
                    { new Guid("4da0bba3-9861-4024-9de7-6ed695844da6"), null, null, "+30 50 (775) 80-26", new Guid("64174d68-43d3-488f-89bf-23d32b134019") },
                    { new Guid("4e25eb87-0d7f-4178-8fd5-eb8194865174"), null, null, "+77 93 (358) 22-50", new Guid("a59d873d-ae08-427c-b25e-29c55895239f") },
                    { new Guid("4e2942b4-b37c-439d-ba45-2a552371ba74"), null, null, "+344 97 (087) 59-79", new Guid("db32027d-cf9c-4544-af7d-d20c917925c7") },
                    { new Guid("4ecea127-b469-4395-9e45-eac8bd1cf1c3"), null, null, "+280 50 (126) 28-29", new Guid("3585370e-fea3-4a31-9a6c-93267371cc1d") },
                    { new Guid("4ef8c9d4-b245-4a76-a3ef-926c69cf806e"), null, null, "+663 50 (757) 36-76", new Guid("a780acfd-e10d-4dc5-a383-1ba56a91e666") },
                    { new Guid("4f0c88dc-e601-4cb9-8563-95730d70b8dc"), null, null, "+146 54 (906) 10-41", new Guid("b1817475-7a6c-44d8-8e81-4b59b1f4923e") },
                    { new Guid("4f5c8537-deef-4ef1-8653-ae4fa3a7f5c6"), null, null, "+846 12 (891) 92-07", new Guid("a9090dd7-3795-48e2-837b-9a72a0274d7b") },
                    { new Guid("4f7e5151-8bea-4b91-820d-cef9d0d5a1d2"), null, null, "+863 87 (108) 02-65", new Guid("eeb82343-3a6f-48ee-b791-709692ceea7d") },
                    { new Guid("4fa429d3-4914-44d2-8395-15744e13d895"), null, null, "+753 12 (051) 32-74", new Guid("56234ad9-accf-413f-8d2b-5d6fb1cd04a1") },
                    { new Guid("4fd801eb-4a43-4add-8877-fe3fbe008055"), null, null, "+542 04 (821) 22-32", new Guid("8be01b71-4060-43ad-98a5-2c0730fd003b") },
                    { new Guid("5092b8ed-5858-4887-be1a-0a6b03328996"), null, null, "+779 99 (056) 00-26", new Guid("548e47d4-b851-4432-8514-fc092768db5b") },
                    { new Guid("50a38ce0-b37c-46b4-aec6-b6702b6c84f9"), null, null, "+185 63 (749) 34-52", new Guid("67a258f9-5c48-4651-8f32-1ee7f5b4246d") },
                    { new Guid("50d1687b-78ea-4167-b3e7-709202a346d5"), null, null, "+187 12 (405) 34-90", new Guid("df3cc97e-5297-4426-8d73-6ec8a1d6ff19") },
                    { new Guid("51694b98-330c-450d-bafa-4d6c5c6876d6"), null, null, "+204 08 (687) 53-69", new Guid("819538c4-628a-4b17-a719-8274b53093f3") },
                    { new Guid("516c9963-87ab-446c-aa6c-5b84cccc5d65"), null, null, "+708 87 (656) 56-83", new Guid("99d4724f-46db-42d2-a62b-3d8fa528e130") },
                    { new Guid("51702b20-eda5-48cf-9e26-9b193d6496b8"), null, null, "+111 10 (610) 76-11", new Guid("1381d1cd-5c11-46c1-bc37-987b3f5ae33e") },
                    { new Guid("51892100-1a6f-4f08-80e7-32c264ba1a6d"), null, null, "+423 50 (254) 95-04", new Guid("5aff4312-b9a9-4958-b14a-305be3aa9f4b") },
                    { new Guid("51a057cf-40f7-4d2c-8bd0-d82b705cc162"), null, null, "+982 08 (197) 84-79", new Guid("ea848f07-5360-4e76-ac1d-cf046366d4ef") },
                    { new Guid("51be0240-85a5-408f-9d04-9776a036dfce"), null, null, "+598 31 (684) 31-85", new Guid("c590f92c-3ca1-4a33-a976-926995a0f7cc") },
                    { new Guid("520d3fd5-31e2-4afd-b6d3-cd8350f5ed44"), null, null, "+273 00 (815) 32-89", new Guid("e764f5ca-90fe-4d60-aab1-e56e02a1f110") },
                    { new Guid("522b4b33-2d08-44c1-8d37-98a444b25f0a"), null, null, "+603 59 (531) 01-41", new Guid("dc5f8e5e-be11-43f9-acd2-648e38e09946") },
                    { new Guid("52ba3440-1d33-4ac7-8848-a1b11cbcac71"), null, null, "+781 81 (841) 92-91", new Guid("82f7ffb4-bdb1-40a8-8d2d-67f1c2f5bf91") },
                    { new Guid("52e3c03a-df5a-4d05-a26c-0f8d1d058fe3"), null, null, "+397 23 (760) 17-06", new Guid("3a6fda52-d9f1-418c-8ffa-69974f7f39be") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("53fac23b-7e0f-4b42-8bd6-70d958208a82"), null, null, "+83 73 (337) 35-01", new Guid("4f42e5ab-642c-4775-b2b2-a116ecfcd663") },
                    { new Guid("541a5af0-48eb-429f-a78a-5e1fbb838c0d"), null, null, "+124 18 (399) 98-69", new Guid("a5276d46-3296-4c05-ba31-d2ebddfd8a57") },
                    { new Guid("544f77bc-13c2-48de-abc5-81f2b945ddfe"), null, null, "+920 24 (482) 24-37", new Guid("a59d873d-ae08-427c-b25e-29c55895239f") },
                    { new Guid("54ac850b-158f-4283-8292-1d62972a47a3"), null, null, "+545 67 (110) 74-11", new Guid("cf348fa5-7d32-48ec-957c-eb481beb0358") },
                    { new Guid("54d77225-3828-4a2f-a420-21ad69a8ece4"), null, null, "+511 79 (239) 90-42", new Guid("8fc5f8c0-3711-4486-8ea0-48697b9ea01f") },
                    { new Guid("55a82c61-1ead-44e5-9d16-147e26a6c78c"), null, null, "+105 07 (287) 30-40", new Guid("e5fa7b3b-6d8a-43dc-88a3-403aed558476") },
                    { new Guid("56771c3e-105b-45b0-af71-3c52a3520d2c"), null, null, "+426 25 (029) 44-84", new Guid("50b1b40f-32d2-45da-a690-b9d24fff476e") },
                    { new Guid("56cff863-ace6-4993-b7fc-3afa3f18308e"), null, null, "+468 90 (758) 74-85", new Guid("dc52bf7b-d952-45c3-8bf0-44dadbfbb09e") },
                    { new Guid("572d4cc3-d2b2-441e-af74-bfce66947832"), null, null, "+488 50 (967) 77-64", new Guid("6c3e0836-290a-4c10-8832-91720a2e9054") },
                    { new Guid("5742af01-1d2a-4539-b774-61e3667462da"), null, null, "+627 11 (123) 27-71", new Guid("ac4ee7ff-56c7-4c45-ba3e-32ed6d9370f3") },
                    { new Guid("57b2e688-7cd3-404b-87c8-15373b799ddf"), null, null, "+368 33 (261) 52-49", new Guid("757f3f70-fdce-4727-8fcf-9ac8aa0287b3") },
                    { new Guid("58af4853-03a9-4ab8-ad6a-0bcffcbcc16f"), null, null, "+3 74 (652) 61-75", new Guid("f4c8c27a-6b37-469c-9492-061adc476725") },
                    { new Guid("58ed5798-470d-4622-b42e-a164989e1ee1"), null, null, "+624 04 (420) 78-96", new Guid("8b3afef3-3bbb-4237-b8b8-1eba1df7757e") },
                    { new Guid("594dd8f6-6458-4ac2-b28b-7835e5963f52"), null, null, "+840 49 (933) 89-52", new Guid("fe7a3052-1ad9-4450-b9d5-057c6abe9c2e") },
                    { new Guid("597278bf-eec3-499b-bd57-38e431ef1654"), null, null, "+223 12 (542) 66-96", new Guid("f3cb510a-8243-4204-8c1f-ace56610d45f") },
                    { new Guid("597a6905-962c-49a5-ad7a-509c454d894d"), null, null, "+645 65 (735) 33-01", new Guid("affd1717-742a-4014-8e72-3420c7496c1e") },
                    { new Guid("5a0f22d7-d161-411d-b041-f1574a128aff"), null, null, "+478 69 (515) 72-55", new Guid("831f8f9d-e78d-4f72-8b48-1c32c42fda1b") },
                    { new Guid("5a19ad1c-5474-4a4e-b7a0-0a675e02ea50"), null, null, "+736 70 (196) 22-28", new Guid("9ff0a0ca-02d0-4209-bb8f-a0d7efaf75bb") },
                    { new Guid("5a70f20b-9f82-42a2-aed3-b5f168ad36ff"), null, null, "+505 11 (866) 56-52", new Guid("6ef84803-7ff7-46d1-b1b3-ebda82e158b3") },
                    { new Guid("5ae74326-6bb9-4999-b96a-07bb23a48ed6"), null, null, "+733 21 (169) 26-30", new Guid("3c3a765d-c1b9-47c7-b39a-7b5dc35e1cbc") },
                    { new Guid("5af0a35f-a8fa-4f78-b60d-142b262caff9"), null, null, "+477 88 (814) 32-68", new Guid("0e7742f2-e964-4e8c-b692-4ffb75ece318") },
                    { new Guid("5c00606a-5385-496a-b701-52a0eb3c0611"), null, null, "+584 28 (168) 83-74", new Guid("9ec54876-333f-4825-9959-c839395cb66e") },
                    { new Guid("5cae4a95-7794-412a-8fc2-c6958851fce9"), null, null, "+595 57 (390) 97-78", new Guid("c2701daa-7747-422a-bb74-d9ffc8e0f5fc") },
                    { new Guid("5cbec711-6237-4177-8cf1-a602b59ecf3a"), null, null, "+695 60 (388) 28-59", new Guid("3c3a765d-c1b9-47c7-b39a-7b5dc35e1cbc") },
                    { new Guid("5cc6abc9-d818-4ed7-b4e4-9c1152c0c401"), null, null, "+273 88 (929) 70-39", new Guid("cf611bf3-21fb-4ed7-a138-00c7afdda9ba") },
                    { new Guid("5cca6308-4a1a-4454-877b-6e9c90b59ede"), null, null, "+28 23 (654) 32-29", new Guid("ca127dc1-765b-47e8-87ee-ebc90ec70a73") },
                    { new Guid("5d41a98e-074a-4f26-ad7b-b742f845eabc"), null, null, "+405 50 (046) 04-74", new Guid("3a262ff7-1654-4c72-9285-3ba10eac6509") },
                    { new Guid("5d56b692-84bb-4182-9273-777a47a05a59"), null, null, "+847 45 (114) 77-90", new Guid("56c8b4b0-c1db-425e-a349-2f7b3feabb5e") },
                    { new Guid("5d636c07-6def-46ed-913d-20734f273b47"), null, null, "+911 32 (245) 73-02", new Guid("9e39f449-ecbf-4238-8ca8-47309c134789") },
                    { new Guid("5d9f20cc-ecf6-4598-9b9b-020c1978060f"), null, null, "+36 41 (752) 94-84", new Guid("3b3e9016-3025-48e3-93b2-fa474015c0f7") },
                    { new Guid("5da7bbf4-a6e7-42d8-84c7-a976ec8e3af9"), null, null, "+337 25 (766) 59-82", new Guid("5f366c1b-9e38-4bc9-b773-fca63347cbcc") },
                    { new Guid("5dd86167-ac86-4783-8acf-1878b7e69132"), null, null, "+644 99 (393) 57-61", new Guid("7abaa815-d503-4740-a0a9-20d8752fc2cf") },
                    { new Guid("5e3ac754-a934-4c53-863d-fb4516226c5a"), null, null, "+67 89 (580) 78-02", new Guid("757f3f70-fdce-4727-8fcf-9ac8aa0287b3") },
                    { new Guid("5e644917-6252-4c53-afee-6c0ffebfc309"), null, null, "+662 11 (402) 25-99", new Guid("de7e4623-27a6-4a10-8c19-1f8ae8f689d2") },
                    { new Guid("5ea13d2d-6975-4eb1-b959-66eaa3d9c46d"), null, null, "+581 06 (052) 96-48", new Guid("59a9232d-40d9-422d-8a1a-fe022e85093a") },
                    { new Guid("5ea6a384-0b31-4f51-b93a-2559653f225d"), null, null, "+767 17 (316) 33-71", new Guid("6f196aeb-f350-478e-a23f-992b0ea6da29") },
                    { new Guid("5eb599c6-9917-43fd-b84f-d02eda47c6b2"), null, null, "+10 51 (891) 38-20", new Guid("23e8131d-ba45-4488-991d-941eca3fbe0a") },
                    { new Guid("5efaa847-bcb5-4a0f-9b64-4d49dcd93e72"), null, null, "+486 28 (134) 64-00", new Guid("39d27a82-05d2-4135-b53b-53748eefd4f2") },
                    { new Guid("5f46d41c-ddb3-4fa0-a196-2b220920443c"), null, null, "+603 96 (570) 17-13", new Guid("097cb7d3-d333-48aa-b8ee-cacd11ee91fa") },
                    { new Guid("5f981367-8e09-4e5e-b458-23e69ccb3b1b"), null, null, "+241 89 (934) 16-64", new Guid("0447d1d8-3e48-4d64-8d2e-7d9a733628ec") },
                    { new Guid("5ff3a368-d609-4f08-a216-d78b5c8766d2"), null, null, "+544 62 (397) 09-95", new Guid("ce7719fc-1874-4df0-88ba-9b5637945029") },
                    { new Guid("6014fa13-4b6e-41a9-81f0-04895458d3c5"), null, null, "+627 74 (305) 10-99", new Guid("2b5f8a6c-d3e8-41ff-8867-cadb6cd16ea4") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("6016f916-c92c-4d34-abe6-fc8a2b1a3491"), null, null, "+840 90 (134) 43-31", new Guid("f7082ecf-eb66-429e-8a3f-72fac7d7b453") },
                    { new Guid("604f60a4-c0f8-4504-9a19-9d6fec89f4c8"), null, null, "+168 89 (789) 58-22", new Guid("9b254af5-9da3-4b42-a5f3-b573df408d84") },
                    { new Guid("60c588a7-22af-4cc3-b6ff-e0ce272bae3c"), null, null, "+2 74 (874) 64-56", new Guid("487efc58-2d93-4b91-a4fb-1ce1d3ef038a") },
                    { new Guid("60caa528-c396-45ca-87b5-cb418d340743"), null, null, "+134 16 (828) 20-13", new Guid("e5406e78-ce40-43ee-8dee-e58fe7687eb3") },
                    { new Guid("60cae517-ac90-43c7-8583-75e3b6752a6a"), null, null, "+162 46 (063) 73-48", new Guid("bd07490e-79db-4063-b992-0fa27e7f7677") },
                    { new Guid("6153d421-dcc4-419f-aab0-80705fc9e226"), null, null, "+562 74 (080) 73-51", new Guid("ac5a7dc0-9da2-4c23-9acc-ec9828404cd5") },
                    { new Guid("61aedd59-543c-4706-9713-a1e3bc35d816"), null, null, "+112 37 (860) 20-98", new Guid("39d27a82-05d2-4135-b53b-53748eefd4f2") },
                    { new Guid("629c4d01-d3bc-407a-9ba2-5c0b61c069b2"), null, null, "+94 39 (013) 77-42", new Guid("9ec54876-333f-4825-9959-c839395cb66e") },
                    { new Guid("62d326c7-a8a4-45cb-b44e-701e0253d3f2"), null, null, "+221 24 (239) 96-02", new Guid("f4c8c27a-6b37-469c-9492-061adc476725") },
                    { new Guid("62dce421-6010-4b4e-ad11-5c25d9a187e9"), null, null, "+785 18 (627) 17-40", new Guid("64174d68-43d3-488f-89bf-23d32b134019") },
                    { new Guid("634a37bb-b63c-48ec-a5b1-566db5e3b3e2"), null, null, "+402 67 (785) 32-91", new Guid("530579fa-33a7-4827-a21f-b9cacab42c7d") },
                    { new Guid("6384f9a5-a908-4876-8ce3-a3ec49eb2a11"), null, null, "+765 64 (721) 33-43", new Guid("819538c4-628a-4b17-a719-8274b53093f3") },
                    { new Guid("63856b22-121f-472d-b5f6-0836d8622a4d"), null, null, "+323 25 (961) 21-07", new Guid("d29932a8-80f8-42b1-85e0-6bf810161455") },
                    { new Guid("64bbe64d-9d59-4666-a9b8-0e0e8c0ab400"), null, null, "+664 76 (665) 27-73", new Guid("a419df27-9358-4a02-9ab7-2f2e2344fae0") },
                    { new Guid("64f0b656-7208-49e0-9006-7ed77bae3449"), null, null, "+371 61 (268) 41-51", new Guid("bd07490e-79db-4063-b992-0fa27e7f7677") },
                    { new Guid("6504abab-3575-4f3b-8e33-b7f2bfdf035e"), null, null, "+666 60 (005) 17-16", new Guid("8c060e9b-2ea2-4602-8535-ce147e60fcbd") },
                    { new Guid("65b6e997-9076-4e9f-afb5-c483d5186c58"), null, null, "+875 14 (765) 37-86", new Guid("3a262ff7-1654-4c72-9285-3ba10eac6509") },
                    { new Guid("65bb5445-2bef-48bf-9788-3e95ec49665f"), null, null, "+676 62 (888) 04-94", new Guid("658f3ddd-678c-4dca-b9fa-45901c0f1c05") },
                    { new Guid("66437869-4d67-420f-8252-0765e019e121"), null, null, "+892 93 (643) 91-05", new Guid("e2db5e4a-dcb2-42fc-b56b-17a4692bd0de") },
                    { new Guid("66f4be54-497a-4914-9f4c-7e5e0b946032"), null, null, "+960 16 (274) 38-87", new Guid("3a19b458-72b3-4b5b-97e6-334a56d7d557") },
                    { new Guid("679cbc8b-97cd-42c1-80c7-3bf9748295f3"), null, null, "+368 06 (326) 53-34", new Guid("7e4a74cd-b47b-47e6-ab98-22ed32bd8e27") },
                    { new Guid("67fb03fa-cb4f-4908-8be3-4c209556e0d9"), null, null, "+559 39 (480) 69-10", new Guid("c58f524e-a96e-4e8b-9186-6c21d38d64b3") },
                    { new Guid("6891af03-3f7e-406d-9416-7ee5a5247d91"), null, null, "+983 12 (390) 40-05", new Guid("182bd5c0-616f-4e9b-8837-7c2b67e01496") },
                    { new Guid("68f877f0-8074-4e3f-aa38-e9b01b1e2e23"), null, null, "+534 72 (940) 00-05", new Guid("6101631f-7cf2-4393-a938-099c07dbe44b") },
                    { new Guid("691513ec-17c9-4ec3-8234-00b30b57d717"), null, null, "+306 95 (622) 40-49", new Guid("d3cba19c-d75f-49cd-8bce-3e5563428a3a") },
                    { new Guid("6942bb8a-ab00-4622-8387-c8d13ec8a740"), null, null, "+909 45 (363) 65-74", new Guid("5d203345-c58f-4236-9e46-c9ba7a8529a5") },
                    { new Guid("698acb62-cd0d-41c7-a590-82f2a36ac37a"), null, null, "+636 45 (048) 49-50", new Guid("ac984856-387b-48de-9d39-5cfa956d354e") },
                    { new Guid("69da16b9-34dc-4dc0-bdfe-a5353f425f41"), null, null, "+465 25 (891) 06-14", new Guid("5c6a10ae-343d-47fa-9381-6cbe7b1a68be") },
                    { new Guid("69fd7781-2a7a-4650-b693-43c271c13e65"), null, null, "+305 55 (803) 52-75", new Guid("0a1370d0-5d3b-4609-9efc-9507f4acc2f8") },
                    { new Guid("6a019cd3-ea2d-4550-91a3-9bf54a7e4ccd"), null, null, "+389 49 (748) 57-82", new Guid("530579fa-33a7-4827-a21f-b9cacab42c7d") },
                    { new Guid("6a20cb37-eaa2-4b1a-989f-4421c339dd00"), null, null, "+688 44 (121) 21-87", new Guid("6c3e0836-290a-4c10-8832-91720a2e9054") },
                    { new Guid("6a247b98-613e-452a-b2aa-cb669e802d83"), null, null, "+207 06 (497) 42-53", new Guid("c3cc5785-6364-48fa-bb83-e7ac33fc672b") },
                    { new Guid("6a3f4a88-3964-470b-bc9f-9affe8ad94e6"), null, null, "+312 90 (918) 45-46", new Guid("fe7a3052-1ad9-4450-b9d5-057c6abe9c2e") },
                    { new Guid("6a7f3d72-13fe-4a84-9f5b-0d7a72edc9fe"), null, null, "+435 18 (507) 33-65", new Guid("72a42c8b-ed7c-4e7a-81c6-313cac897b20") },
                    { new Guid("6a838b70-8458-4b03-ac20-3b2d8100d0c6"), null, null, "+778 29 (258) 45-39", new Guid("93e9e8fa-8b76-4968-a1ef-a4d59b6958ea") },
                    { new Guid("6aa01556-0736-44bf-a5fc-ade1e57d2d3f"), null, null, "+797 59 (500) 93-18", new Guid("36ffb969-580b-40d2-8fa0-94749ea99214") },
                    { new Guid("6b0bc691-7e4b-40cd-ac5b-50b56b4a880b"), null, null, "+574 42 (385) 23-90", new Guid("ea848f07-5360-4e76-ac1d-cf046366d4ef") },
                    { new Guid("6b3c4dc6-b03d-494f-9d4a-272d46b1f7b2"), null, null, "+619 66 (408) 04-56", new Guid("4d006d0d-8a50-4d81-886b-176313d018fb") },
                    { new Guid("6bc5013b-2cb4-460f-92be-3a72c75cc5c9"), null, null, "+295 91 (371) 29-08", new Guid("8ce72c63-9c31-4159-9ba2-012a4fc3df72") },
                    { new Guid("6c48bbcb-dddf-4860-b79d-1f6c744db460"), null, null, "+933 23 (910) 97-78", new Guid("8867eb2c-20d1-43a8-8081-18744798ef5a") },
                    { new Guid("6c78fb6a-f407-47e0-a26b-a29a3a68e443"), null, null, "+790 38 (700) 39-35", new Guid("f4c8c27a-6b37-469c-9492-061adc476725") },
                    { new Guid("6c883c87-2334-491f-bb44-9b98a0b043ca"), null, null, "+75 31 (343) 54-92", new Guid("0447d1d8-3e48-4d64-8d2e-7d9a733628ec") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("6ca5b639-cdf3-4601-9212-5cbe1b32c9b0"), null, null, "+414 19 (596) 57-32", new Guid("6f109fcf-941c-474c-810c-243f75df54d6") },
                    { new Guid("6ce0106d-18d2-4665-b943-46a9ce2a0e0d"), null, null, "+750 10 (874) 54-93", new Guid("335c9d28-42e2-4d49-9686-f0cd1b972fae") },
                    { new Guid("6ced1563-dd19-4efe-a3f9-31a3c083f7d1"), null, null, "+681 46 (114) 33-60", new Guid("0776f148-3954-48ff-8bb8-772d353c1a3c") },
                    { new Guid("6dc4ec5f-adf7-428c-8597-558f6d17ecc0"), null, null, "+388 01 (382) 25-59", new Guid("cf3285c8-97d7-426d-87f3-e0854194e226") },
                    { new Guid("6de95c00-4753-4657-84a8-040d8e928587"), null, null, "+611 66 (994) 52-54", new Guid("4188ab2e-f46b-4cf6-b460-560a914e5d35") },
                    { new Guid("6e26665a-4f2e-4f9e-a52b-7454bc668755"), null, null, "+684 53 (334) 87-60", new Guid("718a03a0-2841-450f-a417-5345b18c81ab") },
                    { new Guid("6eec2015-5204-49ab-b60e-c5dbe6d0f386"), null, null, "+788 29 (772) 50-32", new Guid("8c060e9b-2ea2-4602-8535-ce147e60fcbd") },
                    { new Guid("6fc97b43-1e3e-4e7a-8ceb-56b72d46fe58"), null, null, "+431 96 (404) 56-81", new Guid("3712e35b-2da9-4c76-ad88-28828e776a5c") },
                    { new Guid("700dedde-9287-4aef-8683-7836853a345a"), null, null, "+432 75 (835) 29-26", new Guid("97e11482-d5e6-41d7-82e3-80806df9c3bc") },
                    { new Guid("7023c780-83d1-4901-91ee-e3219ebaa7c3"), null, null, "+113 90 (931) 04-44", new Guid("4c5d0085-4956-4748-b989-09b4d927d669") },
                    { new Guid("7044dc64-4c2f-42d1-99b0-4083185fe516"), null, null, "+284 31 (274) 85-14", new Guid("4f42e5ab-642c-4775-b2b2-a116ecfcd663") },
                    { new Guid("706e3ed7-4b54-4d3a-ad68-6c95fce66201"), null, null, "+848 09 (494) 96-49", new Guid("8f35c799-d964-48e4-9cf8-befb4f9b7bf0") },
                    { new Guid("708efb43-78ba-4c2a-a0af-1b2952803355"), null, null, "+879 62 (162) 97-75", new Guid("3f1a1c74-7f9a-433e-808b-f0d69f6d97e7") },
                    { new Guid("7103223e-e3c9-4c2b-941a-c7333671d171"), null, null, "+463 29 (322) 93-92", new Guid("adbbd240-641f-475b-b705-5e35298ef012") },
                    { new Guid("71455977-1cc1-4063-bca6-5e7dbed9a78f"), null, null, "+564 22 (807) 78-53", new Guid("c5513371-ea13-4b3b-ab65-8bbb471b2afc") },
                    { new Guid("717f012a-5296-4e2e-89e4-75d0b00d547a"), null, null, "+149 99 (025) 64-27", new Guid("93e9e8fa-8b76-4968-a1ef-a4d59b6958ea") },
                    { new Guid("7186ca5c-0593-4636-88f5-7360a969f036"), null, null, "+647 71 (607) 46-36", new Guid("cf3285c8-97d7-426d-87f3-e0854194e226") },
                    { new Guid("7260898c-695d-4e72-b702-ae0f1898091c"), null, null, "+786 43 (564) 99-57", new Guid("dc2b5eaa-01f8-425c-874d-15e523189cc1") },
                    { new Guid("72ccad85-3173-4761-9d7f-070c51360836"), null, null, "+901 77 (933) 22-27", new Guid("7c2f2e0c-1d40-453b-84ea-f5f09cb10d28") },
                    { new Guid("72ff71df-c74a-48b1-8007-a8d3a3263cfc"), null, null, "+8 46 (260) 53-46", new Guid("4ecad1f7-2b37-4dd8-be42-dedd60205e81") },
                    { new Guid("7323a1b5-6dfd-4010-a9f1-2cc21b623496"), null, null, "+29 52 (206) 33-02", new Guid("06f4c32b-9a3d-4b38-99a4-56ea0ba685a8") },
                    { new Guid("733a95bc-09a6-4120-8cc7-5e271ff782db"), null, null, "+296 80 (232) 20-23", new Guid("335c9d28-42e2-4d49-9686-f0cd1b972fae") },
                    { new Guid("7430dbf1-ff43-4372-81b9-7a3356457214"), null, null, "+360 25 (043) 65-51", new Guid("b40d8226-58de-4e86-811d-0e6b38686d57") },
                    { new Guid("7449eab6-6a8e-4b7f-add5-aaf25a15740c"), null, null, "+404 96 (880) 93-25", new Guid("1bab23ea-659b-4531-ad24-fdfd8984675d") },
                    { new Guid("744fb37d-f242-4073-864a-5926716696a9"), null, null, "+919 78 (640) 19-37", new Guid("0d6ec0b6-076d-4fc4-8519-424b1c8bf28e") },
                    { new Guid("74579acb-27cd-4b37-813e-c486346f660f"), null, null, "+897 00 (594) 01-45", new Guid("1154bb55-7f7f-4d91-8347-5797ffeacb13") },
                    { new Guid("7469bd55-b405-42f7-b2d5-fd5ca2b0141d"), null, null, "+207 79 (092) 12-49", new Guid("652ba8ca-0eee-4fb2-a548-4621f2c8de0b") },
                    { new Guid("74b3ada2-d147-4709-8e36-7213caf92227"), null, null, "+189 84 (628) 49-07", new Guid("2700d101-47ef-4c75-a3e1-b613514a94f0") },
                    { new Guid("74f1a8f9-571c-4284-afba-f66b4636299e"), null, null, "+471 03 (446) 62-68", new Guid("6c16f159-98d6-4d70-a7ac-43b19b827d49") },
                    { new Guid("75084260-4237-4049-a0b0-7ef6c22ad111"), null, null, "+425 12 (228) 79-96", new Guid("394e6c37-a398-4cf7-983d-8fb216e6c46f") },
                    { new Guid("75d7a8e6-5a78-4c60-855a-f9173d2c0f0c"), null, null, "+493 64 (795) 71-94", new Guid("dbc51236-052c-4c31-820d-b0a01a143d1a") },
                    { new Guid("766c089e-93f3-42c7-9532-afdf0e19b498"), null, null, "+933 25 (419) 55-45", new Guid("487efc58-2d93-4b91-a4fb-1ce1d3ef038a") },
                    { new Guid("7716ac2c-5bad-4b44-9b7b-213b0ecd52db"), null, null, "+642 38 (801) 21-09", new Guid("74ef9233-8d34-4883-8938-b78b6c147246") },
                    { new Guid("77d31280-30ef-4e80-aeca-bf236daa5dc5"), null, null, "+423 23 (558) 29-14", new Guid("76c44275-2d3e-43e9-b34e-c05f912213b8") },
                    { new Guid("7892c382-a4e9-4bb5-b3c6-3ce899e301c8"), null, null, "+774 07 (100) 63-28", new Guid("2476b4fb-aceb-40f6-b636-80dd269d535c") },
                    { new Guid("7989e2a0-fbf9-4db1-8447-a392e14f80d0"), null, null, "+202 24 (864) 08-31", new Guid("71f7fb3b-e7f1-4325-bdd2-98f71dd515b1") },
                    { new Guid("799ba7b2-6a6b-4578-a7f5-10c6eafc4ab7"), null, null, "+561 17 (381) 15-29", new Guid("6ef84803-7ff7-46d1-b1b3-ebda82e158b3") },
                    { new Guid("79f90d9a-dff4-49f7-8f17-44c23da88a2b"), null, null, "+836 96 (826) 38-24", new Guid("46542d6d-04cc-418a-88b4-cda40f4aff48") },
                    { new Guid("7a3f308e-4487-42e9-b170-2e98f164dbef"), null, null, "+30 94 (659) 82-68", new Guid("230e73b5-4a4b-4b1c-ad48-f7a0074303c7") },
                    { new Guid("7a8c5e89-c4ce-4ffd-a27c-bb9a06a0fe6a"), null, null, "+434 53 (708) 04-99", new Guid("aeae0f68-579f-46b8-bee2-c797ee09ee5e") },
                    { new Guid("7aa57860-527a-4da0-ba7a-68f8622b1ca9"), null, null, "+238 71 (073) 09-09", new Guid("2bdbd536-e4dc-4869-9dac-f62a098ecb05") },
                    { new Guid("7b96264e-9343-48b3-be76-a1c3b2c4de5c"), null, null, "+511 01 (035) 01-31", new Guid("72a42c8b-ed7c-4e7a-81c6-313cac897b20") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("7bbd354e-c9cb-4cde-94ef-7f82ec9eb515"), null, null, "+396 50 (521) 18-87", new Guid("d57e07f1-63a6-4514-ae7a-51f83c901e2c") },
                    { new Guid("7bd1d080-b4b6-44a6-a60f-6fe0837c6b38"), null, null, "+110 99 (718) 84-04", new Guid("56c8b4b0-c1db-425e-a349-2f7b3feabb5e") },
                    { new Guid("7c3b9e7d-1695-481f-9af1-5458529c8015"), null, null, "+534 28 (463) 03-32", new Guid("5c6a10ae-343d-47fa-9381-6cbe7b1a68be") },
                    { new Guid("7e4d2f47-38c0-4174-9618-690681dc1921"), null, null, "+91 68 (887) 77-73", new Guid("0877dbd6-c025-49ef-b189-53b217500382") },
                    { new Guid("7e98b7a8-eb57-44c2-b7ef-dc01edeabaac"), null, null, "+879 07 (700) 90-09", new Guid("108fbff3-4041-4eed-b2a0-4a4b1fb47787") },
                    { new Guid("7eb8d236-06aa-4993-be85-1a2ef1a5bb2e"), null, null, "+167 39 (703) 16-07", new Guid("3585370e-fea3-4a31-9a6c-93267371cc1d") },
                    { new Guid("7f04eb74-652f-4920-bd9c-65750b4725e1"), null, null, "+628 36 (053) 42-81", new Guid("bd349cb3-f696-4e78-9355-45b8b4f7385f") },
                    { new Guid("7f290908-861a-4495-9ecf-19b373c95c33"), null, null, "+98 72 (529) 86-44", new Guid("d29932a8-80f8-42b1-85e0-6bf810161455") },
                    { new Guid("7f8669a4-959f-46bb-855b-e7493e55d037"), null, null, "+110 85 (087) 80-36", new Guid("50ac14d1-c13d-42f2-8026-301c38b1964b") },
                    { new Guid("80a59af6-565d-4f43-a887-dcd4ac898263"), null, null, "+971 71 (869) 17-70", new Guid("9ee8d8bd-022b-4718-b8f4-cc38174e988c") },
                    { new Guid("81391405-2d7b-4154-acdc-64c0f5968365"), null, null, "+794 33 (354) 76-13", new Guid("adbbd240-641f-475b-b705-5e35298ef012") },
                    { new Guid("81bfc4bf-a91d-4ece-b020-140770f98abd"), null, null, "+138 20 (250) 45-30", new Guid("1937fdf7-97b0-4102-95c9-2163eb910112") },
                    { new Guid("81db3bb3-e53c-484a-95e1-c0b8311e5238"), null, null, "+87 09 (561) 23-73", new Guid("affd1717-742a-4014-8e72-3420c7496c1e") },
                    { new Guid("82c92c9e-1068-4742-b9a1-4a72b909aed1"), null, null, "+458 60 (906) 33-86", new Guid("5d1e2a88-0f0a-4b6e-a524-e279224a1944") },
                    { new Guid("8391d86b-df4c-4d55-a475-0886655abcd7"), null, null, "+256 90 (724) 48-43", new Guid("1937fdf7-97b0-4102-95c9-2163eb910112") },
                    { new Guid("83c3bbaf-2036-4334-8989-739e5d2789ce"), null, null, "+313 09 (252) 05-83", new Guid("aeae0f68-579f-46b8-bee2-c797ee09ee5e") },
                    { new Guid("83eda95c-8918-4959-a40d-52e31a2431d6"), null, null, "+960 25 (635) 14-58", new Guid("d43ee797-d0bc-4a3e-8833-c45e9d340f44") },
                    { new Guid("83f11d0a-d467-4053-af00-a2ca3e1a864e"), null, null, "+380 59 (479) 17-26", new Guid("a6a8eca4-cb2e-43f7-9ea2-cbc644c8f9d8") },
                    { new Guid("8465ed3b-c56c-467c-ae5d-241905fbedbd"), null, null, "+234 29 (891) 33-24", new Guid("34e9aed1-9d94-41dd-a50e-2e11424b25e1") },
                    { new Guid("84ad2bcb-3472-42e5-9058-a3949471b0a8"), null, null, "+674 72 (016) 20-69", new Guid("f630d90d-3329-4958-99e4-34aa2f69436c") },
                    { new Guid("84dd6a1f-b0c1-48b2-9884-316182611cfa"), null, null, "+150 96 (380) 74-89", new Guid("0776f148-3954-48ff-8bb8-772d353c1a3c") },
                    { new Guid("8512c5c0-714e-41c5-8d99-bf54a1f9a354"), null, null, "+648 21 (020) 04-98", new Guid("a780acfd-e10d-4dc5-a383-1ba56a91e666") },
                    { new Guid("85b04872-fa47-4ca0-a0b6-f4bd5d12fb1b"), null, null, "+86 74 (492) 15-77", new Guid("548e47d4-b851-4432-8514-fc092768db5b") },
                    { new Guid("85fbadcd-32bb-482c-915e-53424cd50868"), null, null, "+815 11 (302) 84-86", new Guid("7cf58058-5eec-4c6e-a4ae-cf50ccf0b2ac") },
                    { new Guid("865f6a17-b7a1-45f6-936d-07fcaaf0014a"), null, null, "+550 41 (904) 96-23", new Guid("672ce079-171b-4f7e-b744-6b9376e96b61") },
                    { new Guid("867f6eb5-fb6e-4a8b-b0b6-851acefa15b1"), null, null, "+465 70 (752) 26-73", new Guid("50b1b40f-32d2-45da-a690-b9d24fff476e") },
                    { new Guid("86a34cb7-094f-4196-8ea7-2038419500b5"), null, null, "+659 91 (972) 97-37", new Guid("2700d101-47ef-4c75-a3e1-b613514a94f0") },
                    { new Guid("871892b8-b157-456e-a401-f92a5be0529c"), null, null, "+962 65 (369) 09-16", new Guid("4ecad1f7-2b37-4dd8-be42-dedd60205e81") },
                    { new Guid("875a107a-8b6d-4dbf-8733-bcce41c0e79d"), null, null, "+979 62 (728) 88-53", new Guid("530579fa-33a7-4827-a21f-b9cacab42c7d") },
                    { new Guid("8773a46f-a891-41e0-a49e-3b83031b744e"), null, null, "+859 49 (268) 59-74", new Guid("323967f9-cf4e-4818-a5bf-94dff7ea728b") },
                    { new Guid("877bd96e-0dc7-4405-a290-39fb1ccea6cd"), null, null, "+366 37 (096) 18-72", new Guid("8fc5f8c0-3711-4486-8ea0-48697b9ea01f") },
                    { new Guid("877c06e9-e509-4dd6-849f-6fe50765c3fe"), null, null, "+554 58 (112) 80-72", new Guid("6ab8f9db-6513-4d8f-9cde-7b925ff51057") },
                    { new Guid("87af0aa9-0255-4881-912c-7d1a9b577392"), null, null, "+989 05 (496) 41-49", new Guid("64e0a0ed-41a2-429f-800b-6407610d5984") },
                    { new Guid("8869bf07-a533-4122-a960-d3f987518183"), null, null, "+531 30 (529) 02-14", new Guid("49ef4ccb-eb29-4ffa-bcfe-88759ac3f1c5") },
                    { new Guid("8876ffdf-06b3-4e92-a5dc-9c0e7236a4d4"), null, null, "+433 23 (295) 31-29", new Guid("141e6ca1-3b19-4ffc-a21f-8420c3f6db52") },
                    { new Guid("8888fb7a-1eb9-42d7-b46b-6d9ee44b8b35"), null, null, "+813 03 (490) 95-66", new Guid("1154bb55-7f7f-4d91-8347-5797ffeacb13") },
                    { new Guid("88d12af1-5eb2-4011-af0c-d73da4ffa14e"), null, null, "+67 20 (769) 26-82", new Guid("6b5cd903-9056-4302-b3e6-b910c3a67f76") },
                    { new Guid("88f3e116-3687-4c84-91ab-1d4eefbc90a8"), null, null, "+160 43 (326) 82-22", new Guid("78be92c8-3390-4d5e-aa3a-54c7301eaf2f") },
                    { new Guid("89322bcb-a230-4f1a-a5b5-4b8748250b87"), null, null, "+920 17 (447) 59-41", new Guid("cf611bf3-21fb-4ed7-a138-00c7afdda9ba") },
                    { new Guid("898773c2-df14-462a-a131-00f6b24b6db1"), null, null, "+697 31 (295) 61-89", new Guid("07e77ffa-7983-4cb3-bfa5-a4b8ed39f91f") },
                    { new Guid("89a85453-bbd3-4355-b174-3add83d1a4cd"), null, null, "+136 22 (095) 66-43", new Guid("5f366c1b-9e38-4bc9-b773-fca63347cbcc") },
                    { new Guid("89bb35a2-f4ba-4e5f-ba8b-76583de15e99"), null, null, "+696 28 (457) 22-47", new Guid("42babbec-5dbe-4cc3-9f68-bb4bc7ad9491") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("89d0353a-265c-4fb9-b556-ffce773a9963"), null, null, "+549 37 (198) 77-93", new Guid("99d3bf2d-5ff0-41e8-b115-9bf94eab6881") },
                    { new Guid("8a590b03-eb5b-48b1-8cba-3d3a58f13a5a"), null, null, "+14 62 (905) 70-74", new Guid("b8e5286e-6ec4-4001-89c4-e17065f9bf09") },
                    { new Guid("8b548627-e569-4105-973e-dc62fcab366d"), null, null, "+378 38 (232) 93-56", new Guid("2700d101-47ef-4c75-a3e1-b613514a94f0") },
                    { new Guid("8b7c7183-a93e-452b-b8a8-e78f254aa7e5"), null, null, "+961 07 (767) 33-83", new Guid("cf348fa5-7d32-48ec-957c-eb481beb0358") },
                    { new Guid("8ba354f0-1fa2-468c-90fe-398f5bb726d7"), null, null, "+786 50 (186) 42-25", new Guid("70d04e87-92ed-4410-96a6-934a82c8bbcb") },
                    { new Guid("8c6abea7-3598-49e3-bd7b-31557bae322c"), null, null, "+348 00 (499) 52-43", new Guid("22edc826-6747-4099-aca5-578199353ac6") },
                    { new Guid("8d05c8fb-b631-4803-ba65-5ca2a271ac00"), null, null, "+163 41 (175) 68-10", new Guid("bbaf9fe2-9863-4589-964a-23c62e6bf830") },
                    { new Guid("8d675d30-2256-4edc-90d8-1f90f484bb68"), null, null, "+660 41 (531) 23-25", new Guid("141e6ca1-3b19-4ffc-a21f-8420c3f6db52") },
                    { new Guid("8dff45fd-6141-4337-aa85-9eb5a60f9069"), null, null, "+371 84 (663) 82-42", new Guid("8dca8632-b27c-44ad-bd6c-0d7679a4f075") },
                    { new Guid("8e2e447d-0d61-49aa-a54c-ddddd2b7085f"), null, null, "+200 65 (779) 75-73", new Guid("08589d86-24cf-48ee-b140-eab54649e215") },
                    { new Guid("8e4cc519-f302-4fb0-b6ca-f0b3df63be4e"), null, null, "+805 15 (312) 75-76", new Guid("dc5f8e5e-be11-43f9-acd2-648e38e09946") },
                    { new Guid("8efb94ac-4dc6-49b6-b649-acdd98182121"), null, null, "+744 68 (300) 37-37", new Guid("78be92c8-3390-4d5e-aa3a-54c7301eaf2f") },
                    { new Guid("8f7516cb-cd43-4cac-8cbd-d1dd8ea051c5"), null, null, "+32 49 (425) 87-17", new Guid("ac4ee7ff-56c7-4c45-ba3e-32ed6d9370f3") },
                    { new Guid("8f962da6-92cb-477a-8232-d89eeed1ffd6"), null, null, "+766 20 (256) 28-75", new Guid("7e4a74cd-b47b-47e6-ab98-22ed32bd8e27") },
                    { new Guid("8f98edff-e637-4a26-b028-578c91cf5f7b"), null, null, "+337 07 (578) 92-78", new Guid("7abaa815-d503-4740-a0a9-20d8752fc2cf") },
                    { new Guid("8faa25ff-452a-4981-9501-200ada2f7548"), null, null, "+314 51 (373) 67-14", new Guid("cf348fa5-7d32-48ec-957c-eb481beb0358") },
                    { new Guid("8fb8e3bb-09e0-45b7-aeab-95e6f94b169b"), null, null, "+269 46 (142) 20-75", new Guid("9cf1e944-d004-426c-83ee-acb2b8793bc6") },
                    { new Guid("9008d399-bdf6-48a9-9550-42661a3a5c88"), null, null, "+292 25 (904) 97-34", new Guid("22edc826-6747-4099-aca5-578199353ac6") },
                    { new Guid("903a2078-2441-4b61-a59d-28bb3172db6e"), null, null, "+369 02 (539) 51-17", new Guid("1b1ebe07-5765-4728-8b40-ee14061347ae") },
                    { new Guid("9048aa79-773f-4e5b-9730-a1aa503e887a"), null, null, "+250 79 (227) 28-93", new Guid("6ef84803-7ff7-46d1-b1b3-ebda82e158b3") },
                    { new Guid("91265a42-7ab1-4285-9a2f-3035260d55ac"), null, null, "+815 19 (289) 26-19", new Guid("653800c1-b55d-4636-99c0-ea31223d7e3b") },
                    { new Guid("91ebe88e-e20f-4989-969f-e49ae320e5ab"), null, null, "+155 63 (515) 87-90", new Guid("2411a1da-d71e-4e02-a40e-984ec689c7bd") },
                    { new Guid("921dadc4-0cbc-41c6-b86b-7d875ab47769"), null, null, "+124 60 (787) 48-55", new Guid("487f0344-4cde-4b10-971a-1f8311cce3f5") },
                    { new Guid("92276e82-5ffd-4348-9de6-fd48d7cf2596"), null, null, "+860 64 (915) 92-64", new Guid("1937fdf7-97b0-4102-95c9-2163eb910112") },
                    { new Guid("92499548-fd71-412a-aabb-d701b665ae5d"), null, null, "+570 70 (900) 17-88", new Guid("48f4af12-c8b0-4444-98ca-81df5d349e01") },
                    { new Guid("9278cd9b-4fa5-4987-aedc-30e4e783e34b"), null, null, "+275 68 (746) 18-24", new Guid("db32027d-cf9c-4544-af7d-d20c917925c7") },
                    { new Guid("92ce08e2-1070-4f00-a68a-8ed7803e4367"), null, null, "+365 56 (418) 53-82", new Guid("99d3bf2d-5ff0-41e8-b115-9bf94eab6881") },
                    { new Guid("930d3cf6-1ddd-4168-9712-659016dacb97"), null, null, "+620 96 (530) 54-00", new Guid("7abaa815-d503-4740-a0a9-20d8752fc2cf") },
                    { new Guid("93307dab-e7bc-4727-a488-941f670d9512"), null, null, "+91 96 (619) 68-01", new Guid("dbc51236-052c-4c31-820d-b0a01a143d1a") },
                    { new Guid("93385b10-db32-493f-9980-0fbc71b18532"), null, null, "+164 33 (292) 46-80", new Guid("80c8c606-5918-4559-bdbb-606d564f96d5") },
                    { new Guid("9354be6f-def5-47ac-8879-ef9039141c38"), null, null, "+210 78 (114) 71-16", new Guid("7e4a74cd-b47b-47e6-ab98-22ed32bd8e27") },
                    { new Guid("9361d17b-d24a-43f7-813e-0a4371e03c4c"), null, null, "+905 35 (155) 67-30", new Guid("141e6ca1-3b19-4ffc-a21f-8420c3f6db52") },
                    { new Guid("9390788c-4a95-4af3-b5da-59df594f034a"), null, null, "+793 30 (752) 37-69", new Guid("e41a0e5f-468e-496b-8fe7-b8f4b2a0f962") },
                    { new Guid("94c3f259-8904-4b8a-b141-d9bb4254dd4f"), null, null, "+398 36 (181) 84-78", new Guid("82b99640-3f2e-425b-a088-51b3c226a192") },
                    { new Guid("94da1d82-ec24-45a1-b156-53dd19f7b499"), null, null, "+802 95 (442) 41-53", new Guid("c7c0cd55-07d8-41cc-9d2b-4bd04cb7edb3") },
                    { new Guid("94f00612-b5a0-489d-a51f-4355d4cec6ce"), null, null, "+491 76 (771) 72-63", new Guid("3f1a1c74-7f9a-433e-808b-f0d69f6d97e7") },
                    { new Guid("951aa57c-2de9-4c76-b77a-ef7dbfa51a9d"), null, null, "+555 28 (090) 15-65", new Guid("815c5bf5-7253-492e-81c8-82e2d6860602") },
                    { new Guid("9562379b-2806-4ecd-9c44-bff448c33fbd"), null, null, "+396 24 (101) 41-96", new Guid("323967f9-cf4e-4818-a5bf-94dff7ea728b") },
                    { new Guid("95b78a17-485d-449d-a0ea-1582ea123930"), null, null, "+851 18 (930) 47-13", new Guid("9ff0a0ca-02d0-4209-bb8f-a0d7efaf75bb") },
                    { new Guid("96533f86-04b0-47aa-9edb-887341398bc1"), null, null, "+300 23 (747) 16-47", new Guid("5c5b9127-2aa5-4ed6-b779-6402154d5c0f") },
                    { new Guid("96605f3a-fccb-4f1c-992c-bcc578c51e31"), null, null, "+413 00 (694) 36-54", new Guid("42c4353e-7775-4c68-a647-2b921bb87c89") },
                    { new Guid("968a98e2-51f5-48e2-b1dd-67373f0f291b"), null, null, "+774 91 (047) 24-16", new Guid("5c5b9127-2aa5-4ed6-b779-6402154d5c0f") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("96bfa2c0-b011-4d84-87be-8613924997ec"), null, null, "+978 76 (977) 90-55", new Guid("49ef4ccb-eb29-4ffa-bcfe-88759ac3f1c5") },
                    { new Guid("96feb589-0fce-48d1-b504-9d6d4d3b41be"), null, null, "+888 95 (538) 82-85", new Guid("bbe91897-98e6-4c1e-aef5-09cd3dbb35cd") },
                    { new Guid("971859fc-26e1-4b4c-8279-ffc56abf3c32"), null, null, "+252 84 (873) 47-49", new Guid("0b65bf95-8c8c-4e28-8317-122f0f66a78e") },
                    { new Guid("97a57ed2-bfdf-4760-8225-b86d7ecdb288"), null, null, "+480 40 (409) 19-08", new Guid("4188ab2e-f46b-4cf6-b460-560a914e5d35") },
                    { new Guid("985cb3eb-5f75-46b5-ae1c-da96a97f7d7e"), null, null, "+12 31 (125) 47-38", new Guid("aec475ab-9ab8-4f55-8794-ee1ffc6f6da6") },
                    { new Guid("985ff725-f613-4b78-854f-7c6950227595"), null, null, "+348 32 (392) 65-46", new Guid("3ff3d88e-b078-4f3a-8312-8447eeb772e2") },
                    { new Guid("98aaeaf1-653f-4bd1-9085-97ab1b2bed7c"), null, null, "+277 47 (178) 09-44", new Guid("40a279f6-73dd-4fa2-8b1e-05f9cd8bdcf9") },
                    { new Guid("9908c2fe-ccc3-433d-b023-1aeaf2d5823c"), null, null, "+354 18 (718) 92-66", new Guid("48f4af12-c8b0-4444-98ca-81df5d349e01") },
                    { new Guid("99342e3c-cb81-4c77-94f5-9f7873b68958"), null, null, "+39 57 (476) 52-01", new Guid("5aff4312-b9a9-4958-b14a-305be3aa9f4b") },
                    { new Guid("99825f91-464f-4da3-af5d-057539c41082"), null, null, "+713 46 (323) 20-14", new Guid("353c126e-57f5-471a-b13f-0e4fd4cef2fe") },
                    { new Guid("999a62c1-b419-42e3-81f8-de31814639a9"), null, null, "+84 13 (523) 45-82", new Guid("0ec010bc-7e48-4cb9-bb93-8dd9d5b37f6d") },
                    { new Guid("99dc2b15-7ce3-4c4e-b869-1356471f87d7"), null, null, "+266 18 (994) 62-41", new Guid("6ab8f9db-6513-4d8f-9cde-7b925ff51057") },
                    { new Guid("99fb52d0-7357-4e4c-98a0-fbb6e66c6a15"), null, null, "+417 09 (679) 21-41", new Guid("ed5c634a-32ee-48fd-80f4-26cfb1c72602") },
                    { new Guid("9a1ccdad-d944-4f00-a0f6-c06072ece8aa"), null, null, "+279 39 (666) 89-20", new Guid("0e6930e6-cf0a-4195-8d74-a9cc0dfb30b6") },
                    { new Guid("9a250ae1-4886-4bba-9551-169e670fee1c"), null, null, "+9 77 (477) 14-19", new Guid("3712e35b-2da9-4c76-ad88-28828e776a5c") },
                    { new Guid("9a9ca05a-e815-4a9e-98d1-fa55fdc44a9c"), null, null, "+750 60 (005) 94-97", new Guid("496d8ed2-fc6d-49e6-b902-8a1d0b266928") },
                    { new Guid("9afae550-d8d7-41f0-a140-7ff62d3fb5fd"), null, null, "+481 47 (178) 88-74", new Guid("c58f524e-a96e-4e8b-9186-6c21d38d64b3") },
                    { new Guid("9b481fc5-8803-4dcf-9a8e-003c1a6a1440"), null, null, "+581 96 (553) 98-74", new Guid("71f7fb3b-e7f1-4325-bdd2-98f71dd515b1") },
                    { new Guid("9b4bb5ea-5981-4b7c-a3ea-9f5ff9532080"), null, null, "+684 62 (472) 32-49", new Guid("48f4af12-c8b0-4444-98ca-81df5d349e01") },
                    { new Guid("9b5a1cf5-2995-49d3-b179-227ef396747c"), null, null, "+224 43 (518) 84-88", new Guid("3b3e9016-3025-48e3-93b2-fa474015c0f7") },
                    { new Guid("9b99d996-2d1b-4a20-a9a1-ccfaa30cd1f9"), null, null, "+733 18 (187) 11-86", new Guid("b53497b3-fabe-4282-a5c6-ef6e82864309") },
                    { new Guid("9c20215a-c92c-467d-b78d-81b3b02efae0"), null, null, "+437 71 (309) 96-49", new Guid("82b99640-3f2e-425b-a088-51b3c226a192") },
                    { new Guid("9cf59629-e8f5-4c38-88c1-e786600bce3a"), null, null, "+421 13 (338) 50-37", new Guid("54c975d2-dbfe-4626-97fa-ceaa28e85030") },
                    { new Guid("9d0d7168-2561-4447-a54f-9bdaf078eaae"), null, null, "+542 49 (566) 67-18", new Guid("496d8ed2-fc6d-49e6-b902-8a1d0b266928") },
                    { new Guid("9d5a37f3-0e5f-4e66-bbc9-136918f1598a"), null, null, "+3 86 (128) 83-96", new Guid("9ee8d8bd-022b-4718-b8f4-cc38174e988c") },
                    { new Guid("9d716d66-5b12-4fb5-838e-513456890bc4"), null, null, "+992 22 (026) 95-96", new Guid("df1ba0e6-99b8-419d-a3b8-cece7c4928bd") },
                    { new Guid("9d965105-ee2d-40e9-9a42-7dc1c4941797"), null, null, "+301 42 (946) 20-22", new Guid("ddf2bc3e-21a3-4bd8-8ebc-4afb8cb49df0") },
                    { new Guid("9dd223d6-dca8-4a9e-b237-ac4e0ba1beb0"), null, null, "+657 44 (827) 62-80", new Guid("4efd0f6e-db18-4603-b7c2-f032eb9132a9") },
                    { new Guid("9dfc42dc-8007-440a-98c9-f724b2f3b39d"), null, null, "+22 49 (731) 68-05", new Guid("82f7ffb4-bdb1-40a8-8d2d-67f1c2f5bf91") },
                    { new Guid("9ecf4b38-9b40-416b-9ac7-0dba78842ad3"), null, null, "+384 96 (297) 52-66", new Guid("74ef9233-8d34-4883-8938-b78b6c147246") },
                    { new Guid("9f143dc1-04c1-4e30-aa3e-ee5f03812dcf"), null, null, "+941 18 (675) 76-19", new Guid("25c234e8-8d95-42b3-9dc3-c418fbcaa7da") },
                    { new Guid("9f273d07-c613-4ce5-842b-6a7d147300e2"), null, null, "+649 86 (361) 84-83", new Guid("108fbff3-4041-4eed-b2a0-4a4b1fb47787") },
                    { new Guid("9fab43d3-f5ad-463d-94f5-1dcfc593564d"), null, null, "+121 91 (006) 30-89", new Guid("56b8dced-e510-417c-8b93-8a2cb06b845a") },
                    { new Guid("a04db30d-737b-489f-8c00-2b4b30bc9527"), null, null, "+559 67 (193) 84-00", new Guid("8e3d5153-23be-45f9-83b4-5aecbb1a4322") },
                    { new Guid("a0a3e1bc-7356-4120-911a-b831701142b8"), null, null, "+874 61 (349) 86-76", new Guid("93e9e8fa-8b76-4968-a1ef-a4d59b6958ea") },
                    { new Guid("a1134550-1a0b-4e89-9e97-3ef3603a0060"), null, null, "+574 88 (810) 95-04", new Guid("672ce079-171b-4f7e-b744-6b9376e96b61") },
                    { new Guid("a19ce967-1da5-43b8-9394-6cde77ecf861"), null, null, "+852 29 (655) 69-89", new Guid("b21ce16f-bf5c-4cfa-9fd4-9b67014eadbb") },
                    { new Guid("a1b36ec9-1e24-4843-b50d-b1c2e108bb4a"), null, null, "+387 34 (972) 74-96", new Guid("0b65bf95-8c8c-4e28-8317-122f0f66a78e") },
                    { new Guid("a25441e5-8a82-4243-ac20-ab3a6bd3e1ce"), null, null, "+704 38 (901) 02-63", new Guid("6ef84803-7ff7-46d1-b1b3-ebda82e158b3") },
                    { new Guid("a268ed47-717b-47b1-a568-14440822d42c"), null, null, "+369 70 (484) 05-40", new Guid("652ba8ca-0eee-4fb2-a548-4621f2c8de0b") },
                    { new Guid("a280b66c-7462-43b8-a0f9-5e6c4c28d05b"), null, null, "+536 93 (188) 78-04", new Guid("64174d68-43d3-488f-89bf-23d32b134019") },
                    { new Guid("a2848c70-7dc2-41e2-b2d1-902d9ae3c29b"), null, null, "+525 32 (460) 64-33", new Guid("2f8c0b43-80b3-437b-8a84-a763ed30230e") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("a28f4512-03c6-48dd-8d6a-12fd7d70d5ab"), null, null, "+485 43 (129) 46-39", new Guid("affd1717-742a-4014-8e72-3420c7496c1e") },
                    { new Guid("a2b58bf1-bf83-43b2-93f4-9eddfc89e8e1"), null, null, "+699 11 (555) 43-67", new Guid("a59d873d-ae08-427c-b25e-29c55895239f") },
                    { new Guid("a2fceaa2-2ff3-467e-bb91-bee3f8911a9b"), null, null, "+239 77 (972) 11-71", new Guid("ddf2bc3e-21a3-4bd8-8ebc-4afb8cb49df0") },
                    { new Guid("a395c710-0fa4-44ca-84cb-558f371ed341"), null, null, "+566 02 (620) 31-22", new Guid("496d8ed2-fc6d-49e6-b902-8a1d0b266928") },
                    { new Guid("a39b5f85-5502-45f1-984f-8464ce97a129"), null, null, "+101 25 (513) 71-90", new Guid("8c30b7e6-1da3-4a5c-87ba-544b9377a290") },
                    { new Guid("a3bf77fa-ff47-4ef1-ad81-0cf64bf8ec54"), null, null, "+705 73 (493) 28-88", new Guid("ddf2bc3e-21a3-4bd8-8ebc-4afb8cb49df0") },
                    { new Guid("a4278d0d-d2ce-4595-b5df-c41424debb00"), null, null, "+451 87 (873) 24-27", new Guid("6101631f-7cf2-4393-a938-099c07dbe44b") },
                    { new Guid("a4381bec-28c6-46a0-a7ca-8c1561aaffd0"), null, null, "+173 89 (934) 55-50", new Guid("c7c0cd55-07d8-41cc-9d2b-4bd04cb7edb3") },
                    { new Guid("a4654cfd-0399-422f-988c-bc5c992f2e01"), null, null, "+949 47 (529) 23-56", new Guid("0877dbd6-c025-49ef-b189-53b217500382") },
                    { new Guid("a47468de-8854-484e-89de-96de20e3a0e7"), null, null, "+605 49 (103) 85-64", new Guid("0773e360-956e-4d39-94c5-d0906a9e4557") },
                    { new Guid("a4c7a9f7-3ae1-40ab-a4d2-8c16d819655b"), null, null, "+888 86 (939) 08-14", new Guid("0773e360-956e-4d39-94c5-d0906a9e4557") },
                    { new Guid("a563c9e3-226b-42fe-a6bc-0169c0f2d95e"), null, null, "+702 20 (449) 93-68", new Guid("40a279f6-73dd-4fa2-8b1e-05f9cd8bdcf9") },
                    { new Guid("a5a90d59-f5a0-4eeb-9527-c1abec8bc86d"), null, null, "+34 00 (395) 31-59", new Guid("753e85fe-b18a-442a-b91e-1d9dc9216d93") },
                    { new Guid("a646a2c0-b698-478b-a926-ca38b7882781"), null, null, "+523 46 (263) 01-70", new Guid("bbaf9fe2-9863-4589-964a-23c62e6bf830") },
                    { new Guid("a667baa2-0fe7-4d49-b8c6-8380423fdb67"), null, null, "+739 42 (235) 02-32", new Guid("0e7742f2-e964-4e8c-b692-4ffb75ece318") },
                    { new Guid("a6d201fc-dbcf-40ec-ac3d-7fd7d840a61d"), null, null, "+911 01 (907) 02-83", new Guid("8ea935b6-2c30-4bef-803c-9f382789979b") },
                    { new Guid("a7ca59db-8d32-44c0-87aa-53b22827c22f"), null, null, "+633 32 (166) 24-09", new Guid("92d6cbc1-d409-403c-b274-517d31726ae9") },
                    { new Guid("a8166d6b-ddfb-43d5-a4e4-f1270087f670"), null, null, "+11 14 (932) 30-61", new Guid("32feb777-af06-4813-9108-9d7acfd0bd04") },
                    { new Guid("a8170e31-21b4-4bd0-b0e9-c7acded956fe"), null, null, "+919 18 (541) 72-93", new Guid("097cb7d3-d333-48aa-b8ee-cacd11ee91fa") },
                    { new Guid("a82e980c-ee06-4404-9e5e-6da41839666d"), null, null, "+605 23 (382) 20-06", new Guid("c6e8a5d8-6660-4e85-9ff9-1e6ec6d0c580") },
                    { new Guid("a84d6149-f2ea-4786-8bdf-f154e943f2ed"), null, null, "+398 63 (526) 13-53", new Guid("dd550cd7-4eae-4d75-8be5-5f3e496fdd24") },
                    { new Guid("a85253e3-4309-4b5c-861a-3cd94f3a212f"), null, null, "+146 14 (465) 42-92", new Guid("c58f524e-a96e-4e8b-9186-6c21d38d64b3") },
                    { new Guid("a85a15f4-76ca-467c-9a79-723eb0ba89b4"), null, null, "+912 31 (820) 50-62", new Guid("3314d8f7-2262-4e19-afd4-3e85972480b8") },
                    { new Guid("a8e64cd0-3108-4eaf-9f10-2d0162f3c3e9"), null, null, "+52 06 (401) 37-29", new Guid("d57e07f1-63a6-4514-ae7a-51f83c901e2c") },
                    { new Guid("a8fdaa9b-976f-45c8-94df-09a469cde922"), null, null, "+761 98 (906) 59-17", new Guid("78be92c8-3390-4d5e-aa3a-54c7301eaf2f") },
                    { new Guid("a92b5916-e718-4c3a-afcc-e4ff201b8fa9"), null, null, "+160 26 (015) 60-23", new Guid("e5406e78-ce40-43ee-8dee-e58fe7687eb3") },
                    { new Guid("a931ee9f-e918-43e1-bd79-8528c49756a3"), null, null, "+565 93 (949) 91-61", new Guid("25c234e8-8d95-42b3-9dc3-c418fbcaa7da") },
                    { new Guid("a93880c4-5f86-4281-8da0-58f729ec331b"), null, null, "+239 92 (788) 39-27", new Guid("0d230077-5e9b-42d8-a83a-650a22378849") },
                    { new Guid("a978d914-14c9-45ea-a75e-1300711d1e19"), null, null, "+168 88 (369) 93-15", new Guid("01424fda-76cf-4203-995c-a75e43c1d1d0") },
                    { new Guid("a99051a4-5280-4882-9151-d11c8a36bb73"), null, null, "+495 51 (758) 17-56", new Guid("914e0b17-40ab-478d-ba2c-61856d240679") },
                    { new Guid("aa11f47a-cac8-42a1-b0d6-2cfde6011eb8"), null, null, "+555 39 (273) 21-11", new Guid("02a17a84-0a35-4164-b872-e030d586b6fe") },
                    { new Guid("aa1bc48b-45ef-4643-8cc4-0fa3bddb6d69"), null, null, "+578 82 (373) 60-80", new Guid("c40f9fee-6298-4137-bc78-c74409dec92f") },
                    { new Guid("aa45f6e4-281a-44b7-8779-4fbc9f329a5e"), null, null, "+179 54 (759) 84-56", new Guid("8ea935b6-2c30-4bef-803c-9f382789979b") },
                    { new Guid("aafb5d61-b3b5-4f8d-8c37-15656347ef90"), null, null, "+617 84 (226) 15-57", new Guid("aec475ab-9ab8-4f55-8794-ee1ffc6f6da6") },
                    { new Guid("ab7e4c25-c4e0-4aa7-b7bd-52e97e0b1ad4"), null, null, "+857 84 (329) 95-70", new Guid("48b3cd65-be2f-4be1-a3c5-d88da44b3d73") },
                    { new Guid("aba9304b-d0f3-4a70-a656-77bc1dee9519"), null, null, "+320 66 (424) 29-81", new Guid("32feb777-af06-4813-9108-9d7acfd0bd04") },
                    { new Guid("ac3c89e1-660d-48ae-881c-c78cec865b0c"), null, null, "+464 89 (684) 41-89", new Guid("0877dbd6-c025-49ef-b189-53b217500382") },
                    { new Guid("acb2ef5e-f279-4663-be4a-6ae4dbe25d42"), null, null, "+161 24 (906) 69-81", new Guid("35275876-97ec-44a4-8503-f21c815c9a45") },
                    { new Guid("ad019031-3fd1-4d07-8ad1-a3c60875d7f6"), null, null, "+742 94 (037) 02-46", new Guid("8f876cca-154f-4381-adab-41c9e894d046") },
                    { new Guid("ad2dfd2b-2376-4307-8c38-6673ed10dbee"), null, null, "+950 03 (982) 89-03", new Guid("0877dbd6-c025-49ef-b189-53b217500382") },
                    { new Guid("ae051c66-d7af-4a54-89f0-a3567b4f404a"), null, null, "+647 45 (080) 73-75", new Guid("080ced29-2e70-40de-82e4-0a2d478fe53e") },
                    { new Guid("ae9c0638-8752-4259-b6be-814e14a40954"), null, null, "+553 19 (333) 93-11", new Guid("61dcb7dd-eb57-4421-b814-6cd202b0f4a1") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("aeb51f20-c234-4760-bfca-78f3159c2dc5"), null, null, "+204 47 (289) 94-24", new Guid("b21ce16f-bf5c-4cfa-9fd4-9b67014eadbb") },
                    { new Guid("afb3f749-e1b9-4b8b-914f-d6d4653a6c39"), null, null, "+231 67 (165) 65-53", new Guid("07e77ffa-7983-4cb3-bfa5-a4b8ed39f91f") },
                    { new Guid("b049d023-c4b5-46b7-9daf-8d160c97337f"), null, null, "+729 92 (676) 85-81", new Guid("8867eb2c-20d1-43a8-8081-18744798ef5a") },
                    { new Guid("b09b4081-fea3-4a1d-9ce7-3e9d8afa158b"), null, null, "+517 99 (732) 54-75", new Guid("482632b6-5f62-4fe4-82e0-1b6f0d3ee842") },
                    { new Guid("b0e4a8c6-d964-4c66-ad8d-ce30aa1804be"), null, null, "+420 10 (143) 66-97", new Guid("d1d503de-e688-46df-9a53-6ca07b1d716f") },
                    { new Guid("b1304d95-05e2-4953-894f-034359b06d73"), null, null, "+350 63 (556) 35-89", new Guid("f7dacdb6-cd5e-4c55-a2df-710f582d75f2") },
                    { new Guid("b16df931-9b9f-4b61-9eac-5b5e4758cc4f"), null, null, "+122 87 (671) 47-74", new Guid("48b3cd65-be2f-4be1-a3c5-d88da44b3d73") },
                    { new Guid("b1e27c4f-48a3-4e39-980d-ada59110f696"), null, null, "+86 54 (817) 86-09", new Guid("dc5f8e5e-be11-43f9-acd2-648e38e09946") },
                    { new Guid("b20cc8f2-6840-4873-81a4-4100274af87e"), null, null, "+297 45 (864) 12-23", new Guid("2bdbd536-e4dc-4869-9dac-f62a098ecb05") },
                    { new Guid("b24bc38d-25ca-4e0d-b777-755dff72c987"), null, null, "+113 42 (054) 13-07", new Guid("8f876cca-154f-4381-adab-41c9e894d046") },
                    { new Guid("b32d62ff-bc7d-486e-b134-2f8316dd8153"), null, null, "+753 31 (175) 01-13", new Guid("3ee0e809-4d8b-4164-a824-c5ab67903af7") },
                    { new Guid("b345d140-ea55-40e8-bc81-d905c4aff77e"), null, null, "+49 55 (487) 67-12", new Guid("2411a1da-d71e-4e02-a40e-984ec689c7bd") },
                    { new Guid("b36b0735-3d19-43c8-a2e5-da8993b13143"), null, null, "+694 09 (362) 34-48", new Guid("ed1f5061-44e1-4df4-b0de-bc0c17fd0185") },
                    { new Guid("b370d1dc-ede4-4d12-a0d9-c1f167527280"), null, null, "+944 24 (872) 78-05", new Guid("0a8fb680-a380-4d35-85da-ff3cf9faa245") },
                    { new Guid("b382aaf5-ed5e-4fe6-b6cc-855bcdc0c392"), null, null, "+462 05 (668) 01-26", new Guid("0a1370d0-5d3b-4609-9efc-9507f4acc2f8") },
                    { new Guid("b38b306b-d946-43db-a4fd-9931462090c1"), null, null, "+857 02 (861) 94-64", new Guid("c221f46b-a606-417e-aead-c8b255d84d11") },
                    { new Guid("b3a8b2d1-80c6-4344-8fc1-30105084faee"), null, null, "+994 24 (706) 26-24", new Guid("6b5cd903-9056-4302-b3e6-b910c3a67f76") },
                    { new Guid("b3bc19e6-8b39-409a-8b7d-d97d19a7ba9d"), null, null, "+693 32 (476) 73-83", new Guid("405a5eb1-aee0-4578-8748-2d8b5a6b0d57") },
                    { new Guid("b411214a-f70a-404e-ae86-0c8891c59682"), null, null, "+16 35 (651) 26-08", new Guid("0447d1d8-3e48-4d64-8d2e-7d9a733628ec") },
                    { new Guid("b48d5c12-849e-4056-be6e-c2b1d55f5196"), null, null, "+739 63 (781) 06-36", new Guid("92a5d027-0cfb-43ec-84b3-d812837c5654") },
                    { new Guid("b4de6a03-8857-4bc9-961a-b4611f9f829f"), null, null, "+20 97 (922) 73-16", new Guid("94c09a0c-18a4-40c8-9285-032386267d16") },
                    { new Guid("b4e3c3fc-cc4d-4003-a17e-7987cc7e3d64"), null, null, "+483 19 (228) 32-71", new Guid("5e1f9cf6-8e77-46be-92e7-b3f10da0ed86") },
                    { new Guid("b4e5f3d9-f1a6-41d9-aa2d-8ec343513311"), null, null, "+7 53 (856) 36-67", new Guid("23e8131d-ba45-4488-991d-941eca3fbe0a") },
                    { new Guid("b52c6c2f-79f3-4c3e-a81a-71dfb31596ba"), null, null, "+716 00 (568) 26-84", new Guid("0773e360-956e-4d39-94c5-d0906a9e4557") },
                    { new Guid("b53bf9b8-7b60-450c-a590-e88d0a14956f"), null, null, "+867 90 (144) 68-89", new Guid("0a1370d0-5d3b-4609-9efc-9507f4acc2f8") },
                    { new Guid("b6167a1e-381b-4a3c-a1cd-9a19d1c2d4ac"), null, null, "+109 36 (752) 42-58", new Guid("c221f46b-a606-417e-aead-c8b255d84d11") },
                    { new Guid("b635d3ec-3e2a-4fe6-9cf4-8278210b39be"), null, null, "+187 35 (885) 13-97", new Guid("4732299f-418c-4c2e-ac09-aacb3b2c8976") },
                    { new Guid("b639aaf8-af0b-4fd2-8e77-6317da95eea9"), null, null, "+69 49 (993) 58-24", new Guid("5c6a10ae-343d-47fa-9381-6cbe7b1a68be") },
                    { new Guid("b6a4e482-ca4b-4fe3-b6dc-62b2348948ae"), null, null, "+557 79 (337) 80-41", new Guid("a9090dd7-3795-48e2-837b-9a72a0274d7b") },
                    { new Guid("b6a5a391-a333-4033-99ca-08df0641d270"), null, null, "+453 24 (902) 46-99", new Guid("9e96d314-cd64-47aa-a5bc-7e0525cc9914") },
                    { new Guid("b7f29f44-d20b-4751-94ba-44914b814d63"), null, null, "+925 84 (323) 20-37", new Guid("02a17a84-0a35-4164-b872-e030d586b6fe") },
                    { new Guid("b80c1667-c702-4c4d-b5a2-201add40a769"), null, null, "+143 46 (245) 75-74", new Guid("e41a0e5f-468e-496b-8fe7-b8f4b2a0f962") },
                    { new Guid("b86a6380-eb9f-4c3b-bcf2-5f77dabaeea2"), null, null, "+843 26 (653) 38-66", new Guid("50fa1a40-d4af-4edd-8c00-61ec693395b2") },
                    { new Guid("b898b32a-7cdc-4386-9a42-aaeb80de8628"), null, null, "+66 24 (086) 83-72", new Guid("c40f9fee-6298-4137-bc78-c74409dec92f") },
                    { new Guid("b96d0335-c5ff-4baa-b71e-40c57b122365"), null, null, "+192 14 (870) 84-18", new Guid("f3cb510a-8243-4204-8c1f-ace56610d45f") },
                    { new Guid("b978f85f-6a14-4f34-8fe6-889ef1eabb7b"), null, null, "+88 95 (649) 30-46", new Guid("c36bd526-4a45-4a4b-9d0e-50c279e9b939") },
                    { new Guid("b9e98694-d0d9-4337-8998-4617159d819c"), null, null, "+540 31 (966) 39-48", new Guid("0e7742f2-e964-4e8c-b692-4ffb75ece318") },
                    { new Guid("ba4de82a-9a2e-46c8-af55-5ed14738c0bf"), null, null, "+177 05 (776) 76-21", new Guid("4a9e17b4-cb0f-4c82-80d2-e1d56fe06f0a") },
                    { new Guid("ba9d11cf-67d7-44c6-a93d-9c53002d28e9"), null, null, "+207 01 (288) 37-05", new Guid("871feb78-0a5f-4d88-8754-a386270f590d") },
                    { new Guid("bab0bc43-62e3-46c3-b31a-14aebf7252c8"), null, null, "+446 99 (120) 75-76", new Guid("9ff0a0ca-02d0-4209-bb8f-a0d7efaf75bb") },
                    { new Guid("bad41296-12fb-4bef-b61d-d819d6dd71d2"), null, null, "+476 72 (617) 59-52", new Guid("335c9d28-42e2-4d49-9686-f0cd1b972fae") },
                    { new Guid("bb0612cf-a994-4737-9b07-70fae1bb74b0"), null, null, "+651 75 (792) 09-57", new Guid("4c5d0085-4956-4748-b989-09b4d927d669") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("bb0f9b21-5d51-499f-ba84-4c0c78587dbe"), null, null, "+236 05 (485) 27-60", new Guid("97e11482-d5e6-41d7-82e3-80806df9c3bc") },
                    { new Guid("bb11461c-7d43-4425-88dc-0baf764daf39"), null, null, "+742 21 (889) 69-12", new Guid("df1ba0e6-99b8-419d-a3b8-cece7c4928bd") },
                    { new Guid("bb1662fc-d8cd-4c56-866a-26ef8b7337fa"), null, null, "+892 92 (603) 25-22", new Guid("06f4c32b-9a3d-4b38-99a4-56ea0ba685a8") },
                    { new Guid("bb81de14-4526-43d1-beee-8c994c967576"), null, null, "+784 55 (280) 02-87", new Guid("548e47d4-b851-4432-8514-fc092768db5b") },
                    { new Guid("bbef6565-3143-4871-b1f7-2e36c3594af0"), null, null, "+477 26 (450) 19-79", new Guid("394e6c37-a398-4cf7-983d-8fb216e6c46f") },
                    { new Guid("bbfede9a-b69b-4e4a-b1f7-d830b495a0b2"), null, null, "+173 53 (797) 77-34", new Guid("3ff3d88e-b078-4f3a-8312-8447eeb772e2") },
                    { new Guid("bc382989-9c06-48ef-9311-a6d1e5b9d678"), null, null, "+690 82 (627) 18-19", new Guid("e5fa7b3b-6d8a-43dc-88a3-403aed558476") },
                    { new Guid("bc7dd53e-0ce9-4bbf-869b-f45bb52902fc"), null, null, "+846 24 (786) 60-57", new Guid("1bab23ea-659b-4531-ad24-fdfd8984675d") },
                    { new Guid("bccd0d1e-81b0-4b52-bf2c-0138ad3c9415"), null, null, "+231 40 (501) 93-56", new Guid("d0aae9a2-8c5b-48e9-b856-e309c80cadae") },
                    { new Guid("bd98f47c-c0bf-42b2-b609-3c14647a2403"), null, null, "+679 54 (504) 18-82", new Guid("42babbec-5dbe-4cc3-9f68-bb4bc7ad9491") },
                    { new Guid("bea108d1-5e34-483a-95b8-58524e75720e"), null, null, "+141 11 (228) 28-84", new Guid("672ce079-171b-4f7e-b744-6b9376e96b61") },
                    { new Guid("bee3d3a2-ac09-447d-b5fc-2064a7266f36"), null, null, "+308 64 (851) 81-96", new Guid("dc5f8e5e-be11-43f9-acd2-648e38e09946") },
                    { new Guid("bf021b98-e2dd-4a33-b37b-820a716c681c"), null, null, "+838 85 (077) 60-32", new Guid("b8e5286e-6ec4-4001-89c4-e17065f9bf09") },
                    { new Guid("bf186adc-56c4-4b57-8ebe-ce5f27aa2d59"), null, null, "+944 87 (729) 72-72", new Guid("0d88a4e0-8366-4547-8ebe-087d4c74b34f") },
                    { new Guid("bf5cc850-5859-42fa-9f90-ffc841c59413"), null, null, "+988 06 (459) 44-84", new Guid("7a52231d-ba53-47d6-8382-e5bf5f9e7e24") },
                    { new Guid("bf98b03c-72c9-4ddd-8c19-55dc5121772d"), null, null, "+55 54 (672) 49-14", new Guid("5c6a10ae-343d-47fa-9381-6cbe7b1a68be") },
                    { new Guid("bfa5b7a4-b012-4d74-8db8-267b0e47eec6"), null, null, "+831 35 (591) 75-56", new Guid("5d203345-c58f-4236-9e46-c9ba7a8529a5") },
                    { new Guid("c02e5ba3-4a64-4f56-a224-5bc528c26c7a"), null, null, "+934 83 (124) 21-32", new Guid("42babbec-5dbe-4cc3-9f68-bb4bc7ad9491") },
                    { new Guid("c04a0f59-7d95-4bd3-89b7-d00f5db2d30f"), null, null, "+129 51 (701) 30-96", new Guid("2bdbd536-e4dc-4869-9dac-f62a098ecb05") },
                    { new Guid("c04c0e18-a960-45b2-8707-1cbb9d6cfefe"), null, null, "+550 95 (024) 98-12", new Guid("080ced29-2e70-40de-82e4-0a2d478fe53e") },
                    { new Guid("c058db21-d9c3-4505-9f8f-878e2e935fd8"), null, null, "+292 56 (750) 19-63", new Guid("8f35c799-d964-48e4-9cf8-befb4f9b7bf0") },
                    { new Guid("c1b3d84b-b6ba-4f8e-945f-eb58fb1d68ca"), null, null, "+372 04 (653) 19-27", new Guid("6f109fcf-941c-474c-810c-243f75df54d6") },
                    { new Guid("c20044c5-be44-4a9a-bb77-8ba504177f61"), null, null, "+789 49 (752) 68-29", new Guid("63107baa-d978-4764-b959-7e90a1de3ee0") },
                    { new Guid("c215043e-f362-40e7-bafd-ccfbce947ebc"), null, null, "+694 73 (492) 43-46", new Guid("d40492c4-d582-4ce6-943c-a487675b7960") },
                    { new Guid("c2574d0d-099f-4016-853b-b15834723624"), null, null, "+521 58 (246) 74-06", new Guid("b1817475-7a6c-44d8-8e81-4b59b1f4923e") },
                    { new Guid("c32574d5-1a38-4d40-a6aa-9ebdf40e7d86"), null, null, "+935 57 (363) 31-06", new Guid("a943e809-55d9-482f-a592-8709b5f7d47f") },
                    { new Guid("c34d3e0f-eea6-4235-b0a0-af342c17de56"), null, null, "+569 07 (000) 35-42", new Guid("d3cba19c-d75f-49cd-8bce-3e5563428a3a") },
                    { new Guid("c37c7a3f-cb8a-4720-8906-5e04be4ccfe5"), null, null, "+240 87 (991) 16-93", new Guid("539c62ee-15fc-4d37-ab5d-0e4126109954") },
                    { new Guid("c3fb57b6-839e-4b83-9f38-e4dcf06863d2"), null, null, "+929 65 (568) 69-30", new Guid("831f8f9d-e78d-4f72-8b48-1c32c42fda1b") },
                    { new Guid("c40261fc-f66b-4405-8d6b-1b02018d12dd"), null, null, "+281 61 (204) 74-76", new Guid("64e0a0ed-41a2-429f-800b-6407610d5984") },
                    { new Guid("c40416d9-5564-4135-8534-3b7eb9e322fa"), null, null, "+887 34 (436) 80-09", new Guid("353c126e-57f5-471a-b13f-0e4fd4cef2fe") },
                    { new Guid("c482a77e-d6ba-4ce2-8d22-0c7eb0d66e1f"), null, null, "+547 97 (254) 84-47", new Guid("db91ddfb-75b6-4d51-82ea-52631a102b16") },
                    { new Guid("c52b59da-8387-49aa-81b8-5d8d7f9d7982"), null, null, "+610 47 (463) 50-61", new Guid("5d1e2a88-0f0a-4b6e-a524-e279224a1944") },
                    { new Guid("c60808cc-63d4-4cf5-8ab0-7e2f715731f7"), null, null, "+42 43 (989) 72-74", new Guid("cf611bf3-21fb-4ed7-a138-00c7afdda9ba") },
                    { new Guid("c6361134-2cba-4fd9-99ef-1bf0fc5407c6"), null, null, "+944 31 (734) 54-37", new Guid("df3cc97e-5297-4426-8d73-6ec8a1d6ff19") },
                    { new Guid("c67eb10c-b7e4-48a7-9dd1-3a4e4a24a34f"), null, null, "+322 02 (119) 23-68", new Guid("5e1f9cf6-8e77-46be-92e7-b3f10da0ed86") },
                    { new Guid("c6c20d36-af79-408c-830b-1a7073ce2fa3"), null, null, "+229 18 (697) 83-28", new Guid("8a696f30-76c2-40db-a250-030829547d67") },
                    { new Guid("c799d3c5-f437-43da-9802-fe380c44ab4e"), null, null, "+915 95 (785) 11-57", new Guid("8c18ec85-46f2-44b0-bd0b-56adb1bf7743") },
                    { new Guid("c7e07161-81be-4c58-837a-9aa02553e3a0"), null, null, "+659 64 (790) 51-45", new Guid("4b2a14c5-b9ad-4e45-ae16-0762e7d1e215") },
                    { new Guid("c8520b15-bb16-42b2-aa4c-3e8f35e861bb"), null, null, "+187 81 (482) 91-38", new Guid("757f3f70-fdce-4727-8fcf-9ac8aa0287b3") },
                    { new Guid("c860460e-edfc-4195-9e9b-28be33458001"), null, null, "+664 58 (180) 53-94", new Guid("df3cc97e-5297-4426-8d73-6ec8a1d6ff19") },
                    { new Guid("c8e10c98-8144-406a-bed9-2ed150488f22"), null, null, "+842 11 (228) 20-96", new Guid("a5276d46-3296-4c05-ba31-d2ebddfd8a57") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("c8f0c640-fc58-4244-bdfb-2ed47872a0bc"), null, null, "+313 11 (983) 42-29", new Guid("8e3d5153-23be-45f9-83b4-5aecbb1a4322") },
                    { new Guid("c904de88-0492-47d5-b501-0f130599fea3"), null, null, "+209 69 (954) 12-23", new Guid("99d4724f-46db-42d2-a62b-3d8fa528e130") },
                    { new Guid("cab4a81b-23a0-46fe-a0ed-c1bea9ce0000"), null, null, "+524 32 (445) 07-45", new Guid("2c87eaa4-8e07-41f4-bad0-935d07541e78") },
                    { new Guid("cae97355-745a-4cdc-b1d4-c82af776fb3e"), null, null, "+846 91 (994) 52-39", new Guid("8b3afef3-3bbb-4237-b8b8-1eba1df7757e") },
                    { new Guid("cb07a929-194f-45ff-8f53-6a1cb4089dc2"), null, null, "+623 06 (834) 25-96", new Guid("653800c1-b55d-4636-99c0-ea31223d7e3b") },
                    { new Guid("cb0e7325-d677-4212-af84-4b9f0212c599"), null, null, "+481 95 (514) 65-38", new Guid("ca127dc1-765b-47e8-87ee-ebc90ec70a73") },
                    { new Guid("cb66eb77-a0a2-40f2-9fcc-eaea4f0d86b2"), null, null, "+267 76 (900) 89-59", new Guid("50ac14d1-c13d-42f2-8026-301c38b1964b") },
                    { new Guid("cc69a8c5-7cf9-40bb-a96d-edd3aa0958cf"), null, null, "+565 27 (061) 73-26", new Guid("66da7f26-36d5-4406-a2e4-35363c8e43cb") },
                    { new Guid("ccbafcf3-b748-4bbb-9120-558321aa182c"), null, null, "+375 97 (314) 44-92", new Guid("6c3f8b98-7095-4d12-8f55-02b23a300d5f") },
                    { new Guid("ccca313e-4020-444e-abe6-dc7bc9ae501b"), null, null, "+653 32 (821) 52-31", new Guid("22edc826-6747-4099-aca5-578199353ac6") },
                    { new Guid("cce341ea-c701-4148-a543-ead984072702"), null, null, "+666 48 (655) 37-69", new Guid("db32027d-cf9c-4544-af7d-d20c917925c7") },
                    { new Guid("cce3d6ac-acb1-4bbb-8fe4-6bab771379ca"), null, null, "+327 78 (651) 82-64", new Guid("6ab8f9db-6513-4d8f-9cde-7b925ff51057") },
                    { new Guid("cd0a9e29-f7a7-4f89-b486-eb81980aacfb"), null, null, "+798 80 (535) 86-20", new Guid("f630d90d-3329-4958-99e4-34aa2f69436c") },
                    { new Guid("cda68f77-a7f6-4d25-8a3e-1c921ba8beed"), null, null, "+986 99 (867) 21-71", new Guid("bbe91897-98e6-4c1e-aef5-09cd3dbb35cd") },
                    { new Guid("cdcdd81d-1066-434f-a0ef-b0f42a40f25e"), null, null, "+567 52 (485) 61-34", new Guid("77bc83c5-7598-48f0-b4c1-23f76fd277ca") },
                    { new Guid("cdfff5fd-7f95-4ba7-878c-9418cb7676f2"), null, null, "+636 17 (161) 73-21", new Guid("ab451099-7866-44e4-9ebd-f1162ea6206a") },
                    { new Guid("ce6514cc-f83f-4bff-8e4e-d1d4727aad9d"), null, null, "+644 72 (706) 62-84", new Guid("0a1370d0-5d3b-4609-9efc-9507f4acc2f8") },
                    { new Guid("cecd2f3a-9dff-43db-b60e-23598d64510a"), null, null, "+292 42 (584) 38-90", new Guid("c0ff772c-b38f-4860-9c1e-4c49d424f9a5") },
                    { new Guid("cef3c80b-2a9e-4d45-9577-a23f745edc5d"), null, null, "+28 47 (843) 05-41", new Guid("3ee0e809-4d8b-4164-a824-c5ab67903af7") },
                    { new Guid("cf3fee3b-a81e-4f81-ac9e-c3aca5686110"), null, null, "+344 04 (146) 76-45", new Guid("539c62ee-15fc-4d37-ab5d-0e4126109954") },
                    { new Guid("cf989121-3180-44a6-8c73-fecbdb59cdd9"), null, null, "+14 27 (109) 07-01", new Guid("8dca8632-b27c-44ad-bd6c-0d7679a4f075") },
                    { new Guid("d08d82f0-96d7-4eeb-aa31-ce4523d9f32f"), null, null, "+153 92 (004) 98-37", new Guid("c7c0cd55-07d8-41cc-9d2b-4bd04cb7edb3") },
                    { new Guid("d0c6550f-5a98-498a-922d-6c7372032247"), null, null, "+986 89 (249) 89-08", new Guid("719d1670-ba7d-4e9b-b4de-d7074f81aa66") },
                    { new Guid("d0f56bb4-05c3-43ac-a944-02bc0b2134f6"), null, null, "+658 33 (956) 34-95", new Guid("aeae0f68-579f-46b8-bee2-c797ee09ee5e") },
                    { new Guid("d0fee5d3-a11e-4a1f-b358-935c7b52fdf7"), null, null, "+685 06 (121) 00-76", new Guid("63107baa-d978-4764-b959-7e90a1de3ee0") },
                    { new Guid("d1254583-72cf-4446-99cb-dd3a5ebfdb50"), null, null, "+203 94 (791) 75-19", new Guid("be0a8a82-f1fd-45d5-8523-5b32db6fc767") },
                    { new Guid("d197e408-104f-4f99-b3c1-f3bbd175a7e0"), null, null, "+642 12 (914) 05-17", new Guid("57b666b4-3a1b-4303-851f-a88f5f534543") },
                    { new Guid("d1a80003-5574-415b-b6f2-74b2658fc2a3"), null, null, "+527 84 (644) 83-97", new Guid("5c5b9127-2aa5-4ed6-b779-6402154d5c0f") },
                    { new Guid("d1af4f31-e210-462e-8db5-525bf4f009de"), null, null, "+120 71 (611) 53-12", new Guid("4b2a14c5-b9ad-4e45-ae16-0762e7d1e215") },
                    { new Guid("d221fb68-a2a9-488e-9634-0460c51b3f05"), null, null, "+936 79 (903) 24-93", new Guid("46843658-5438-46a9-b26a-f6c2fcfd1883") },
                    { new Guid("d25b68da-f93c-4741-8086-84b1f2304175"), null, null, "+130 31 (330) 79-26", new Guid("9e96d314-cd64-47aa-a5bc-7e0525cc9914") },
                    { new Guid("d2784d8c-c336-464f-86b1-694d32bb8e83"), null, null, "+603 18 (882) 72-72", new Guid("8b3afef3-3bbb-4237-b8b8-1eba1df7757e") },
                    { new Guid("d29dc70b-3ed0-419c-97f1-6aa3333f30c8"), null, null, "+643 43 (320) 98-19", new Guid("76c44275-2d3e-43e9-b34e-c05f912213b8") },
                    { new Guid("d2d4cccb-cb50-4bb3-b137-cf73c23d7f13"), null, null, "+778 45 (799) 61-91", new Guid("4a9e17b4-cb0f-4c82-80d2-e1d56fe06f0a") },
                    { new Guid("d31d73a9-5215-4d8b-839d-045fef2bd5f6"), null, null, "+667 41 (554) 29-08", new Guid("e764f5ca-90fe-4d60-aab1-e56e02a1f110") },
                    { new Guid("d4819762-4285-4951-8a13-56b6a1956e61"), null, null, "+238 70 (452) 71-52", new Guid("4a9e17b4-cb0f-4c82-80d2-e1d56fe06f0a") },
                    { new Guid("d5733aee-019f-4523-ad07-c71a55ebde70"), null, null, "+832 98 (975) 08-33", new Guid("4b45c810-f446-449d-8b0e-4a2ebbbf7104") },
                    { new Guid("d5863bf8-1e08-45b4-85e4-fd59e96bc195"), null, null, "+807 18 (799) 22-63", new Guid("a419df27-9358-4a02-9ab7-2f2e2344fae0") },
                    { new Guid("d5a78cd4-81d9-46ef-aa81-b5ddadc73373"), null, null, "+732 19 (305) 86-47", new Guid("4ecad1f7-2b37-4dd8-be42-dedd60205e81") },
                    { new Guid("d629b0ed-147a-433d-adc8-7d3d6eacf804"), null, null, "+335 99 (934) 56-60", new Guid("097cb7d3-d333-48aa-b8ee-cacd11ee91fa") },
                    { new Guid("d62b477f-0b02-4117-a2d5-208ac705c950"), null, null, "+989 22 (600) 79-35", new Guid("39d27a82-05d2-4135-b53b-53748eefd4f2") },
                    { new Guid("d649fbd2-ea3c-4b65-b338-6bd1c560562b"), null, null, "+684 10 (775) 06-39", new Guid("0d6ec0b6-076d-4fc4-8519-424b1c8bf28e") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("d6d84f05-f426-45c8-a8d5-548f346d41c7"), null, null, "+563 47 (262) 67-64", new Guid("6ab8f9db-6513-4d8f-9cde-7b925ff51057") },
                    { new Guid("d7bf5244-c871-4aec-923d-49fc40147723"), null, null, "+633 39 (460) 55-49", new Guid("dd550cd7-4eae-4d75-8be5-5f3e496fdd24") },
                    { new Guid("d828b1b4-ad47-42a2-8110-5e5f36472215"), null, null, "+929 50 (663) 94-87", new Guid("db32027d-cf9c-4544-af7d-d20c917925c7") },
                    { new Guid("d82c7877-0f47-4561-a767-64f0808cbf66"), null, null, "+971 10 (464) 05-71", new Guid("9e96d314-cd64-47aa-a5bc-7e0525cc9914") },
                    { new Guid("d8457f0d-3d6c-4155-94d4-ed7bbd258e4a"), null, null, "+188 96 (489) 33-05", new Guid("1e17494c-b19d-4879-af0e-c6575db6bd37") },
                    { new Guid("d875aa4b-9fab-48dc-99d5-0192d06535c3"), null, null, "+917 21 (577) 46-62", new Guid("719d1670-ba7d-4e9b-b4de-d7074f81aa66") },
                    { new Guid("d96bab73-44b4-4b9c-aa1e-aaf6c094debc"), null, null, "+425 74 (381) 43-76", new Guid("3a19b458-72b3-4b5b-97e6-334a56d7d557") },
                    { new Guid("d9902b4a-f2d3-4b94-9a64-b89713be5e9d"), null, null, "+795 00 (997) 91-97", new Guid("40a279f6-73dd-4fa2-8b1e-05f9cd8bdcf9") },
                    { new Guid("d9d78ce4-1f5b-47a5-9264-3d7035b8b3a6"), null, null, "+191 29 (771) 50-85", new Guid("ce7719fc-1874-4df0-88ba-9b5637945029") },
                    { new Guid("da3f5515-ecd8-41b7-b875-10dfde66c662"), null, null, "+280 24 (600) 55-13", new Guid("d0aae9a2-8c5b-48e9-b856-e309c80cadae") },
                    { new Guid("da472982-4933-4c70-ba0e-63552b7974fe"), null, null, "+996 65 (649) 93-13", new Guid("f51931e0-68b3-4aed-8f03-7ef9a8526650") },
                    { new Guid("daac9607-9ada-431d-870e-4f4a78c63795"), null, null, "+206 76 (905) 30-60", new Guid("7778b4eb-db56-4ddd-a0bc-5f46aff077f7") },
                    { new Guid("dae807a7-da24-4386-a7e0-b0f03d6ae0ab"), null, null, "+311 53 (535) 39-37", new Guid("c66d96b2-e569-4470-a3b9-82ba83e46c97") },
                    { new Guid("dafe7775-230c-4479-aace-d27ff196c20c"), null, null, "+966 37 (591) 40-41", new Guid("0e7742f2-e964-4e8c-b692-4ffb75ece318") },
                    { new Guid("db4ec330-826b-49f5-9475-bdf1f6e6ce57"), null, null, "+877 92 (561) 42-31", new Guid("57b666b4-3a1b-4303-851f-a88f5f534543") },
                    { new Guid("db8cea09-1165-4942-b861-b09dcc762a38"), null, null, "+400 51 (511) 10-87", new Guid("3b3e9016-3025-48e3-93b2-fa474015c0f7") },
                    { new Guid("dbe64fa7-ea91-4d81-873e-9823607b43e0"), null, null, "+994 99 (662) 90-29", new Guid("3a19b458-72b3-4b5b-97e6-334a56d7d557") },
                    { new Guid("dc0cad5e-61e0-4815-8177-e722d21884a8"), null, null, "+619 66 (760) 27-81", new Guid("10766e70-305e-4e2a-8560-ffeb596a93eb") },
                    { new Guid("dc259247-cfe3-47b8-98cc-3c8f1025c6db"), null, null, "+605 81 (873) 65-10", new Guid("57b666b4-3a1b-4303-851f-a88f5f534543") },
                    { new Guid("dccbc3fe-011a-4881-9f7f-03a7fac18089"), null, null, "+382 59 (211) 07-58", new Guid("ddf2bc3e-21a3-4bd8-8ebc-4afb8cb49df0") },
                    { new Guid("dd08ab8d-5a17-4066-8e67-054ca3e458db"), null, null, "+842 19 (325) 89-58", new Guid("2b5f8a6c-d3e8-41ff-8867-cadb6cd16ea4") },
                    { new Guid("dda6fdfc-7719-46ee-adab-e7dc5cd8a6ff"), null, null, "+996 19 (308) 75-49", new Guid("ac4ee7ff-56c7-4c45-ba3e-32ed6d9370f3") },
                    { new Guid("ddda37d4-29ea-47b8-9cac-3ba7e969c024"), null, null, "+545 96 (596) 75-34", new Guid("50ac14d1-c13d-42f2-8026-301c38b1964b") },
                    { new Guid("ddea2d92-488d-4d7d-9b82-b62cf8c688b2"), null, null, "+543 08 (271) 02-86", new Guid("0d230077-5e9b-42d8-a83a-650a22378849") },
                    { new Guid("de565743-9ca9-4f16-9e12-2b50573990a5"), null, null, "+936 21 (887) 24-18", new Guid("335c9d28-42e2-4d49-9686-f0cd1b972fae") },
                    { new Guid("de5fc1e6-066c-48fd-9ed3-db2d02898e15"), null, null, "+425 72 (793) 90-22", new Guid("74ef9233-8d34-4883-8938-b78b6c147246") },
                    { new Guid("ded3feee-4734-49e4-b487-9a06bd8856b3"), null, null, "+605 96 (179) 64-77", new Guid("a03e50af-2ee0-4392-86e9-a0420b2f24bb") },
                    { new Guid("dedaaf85-a19f-4bec-8f8f-157f635db84a"), null, null, "+734 93 (389) 31-78", new Guid("c590f92c-3ca1-4a33-a976-926995a0f7cc") },
                    { new Guid("e036620e-7c57-4ef5-8411-082c522f7ab6"), null, null, "+789 01 (189) 81-31", new Guid("2700d101-47ef-4c75-a3e1-b613514a94f0") },
                    { new Guid("e097a816-074c-48de-a0b1-0098f5adec9e"), null, null, "+619 34 (222) 73-82", new Guid("b5cca55a-d81f-47be-b0b4-50d07e79ce69") },
                    { new Guid("e0a18a69-11f3-44f0-bec9-a2ac996c1b42"), null, null, "+399 73 (970) 24-91", new Guid("59a9232d-40d9-422d-8a1a-fe022e85093a") },
                    { new Guid("e0d02157-311f-45fc-9236-701d2e40b244"), null, null, "+865 47 (302) 65-68", new Guid("815c5bf5-7253-492e-81c8-82e2d6860602") },
                    { new Guid("e0da94af-f6ef-47b3-8800-7346314c105b"), null, null, "+708 82 (692) 32-28", new Guid("9e96d314-cd64-47aa-a5bc-7e0525cc9914") },
                    { new Guid("e1520b62-c56a-42c6-bf0d-e8682ebf3510"), null, null, "+124 92 (749) 05-50", new Guid("6218849a-9af3-4ab0-93d1-f5fd29135491") },
                    { new Guid("e164afe6-dedd-4273-ac3c-56f53fcbb37c"), null, null, "+917 31 (202) 08-53", new Guid("d40492c4-d582-4ce6-943c-a487675b7960") },
                    { new Guid("e16e9a1a-e197-4d48-bc6a-6acc80ae34e2"), null, null, "+169 02 (516) 77-38", new Guid("39d27a82-05d2-4135-b53b-53748eefd4f2") },
                    { new Guid("e19a9c0b-e26e-4878-946c-1261134519fd"), null, null, "+135 28 (482) 64-70", new Guid("99d4724f-46db-42d2-a62b-3d8fa528e130") },
                    { new Guid("e1e24873-a956-43bb-84df-9096188f1a47"), null, null, "+388 05 (763) 50-88", new Guid("f28f3fdf-fa90-4b58-895f-89b7f89e53e9") },
                    { new Guid("e1f80c26-3bf8-45ff-a82d-b686f85c22cd"), null, null, "+891 20 (833) 37-84", new Guid("c88c725e-8cbf-416d-a4bf-153a024ea6c9") },
                    { new Guid("e2055ebe-c8d9-41db-8cdd-d65a9598b582"), null, null, "+272 79 (650) 98-67", new Guid("323967f9-cf4e-4818-a5bf-94dff7ea728b") },
                    { new Guid("e24fa885-cfa8-45d7-8202-906594bdd2c5"), null, null, "+280 86 (333) 69-40", new Guid("6f196aeb-f350-478e-a23f-992b0ea6da29") },
                    { new Guid("e266895e-7fc8-4de4-8295-5e4b6dc053c1"), null, null, "+596 27 (157) 83-97", new Guid("77bc83c5-7598-48f0-b4c1-23f76fd277ca") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("e2770036-c004-4654-93ba-5f39f8ba966a"), null, null, "+112 53 (216) 37-92", new Guid("8ce72c63-9c31-4159-9ba2-012a4fc3df72") },
                    { new Guid("e2886c73-c22c-4c0a-8003-49044bdd7d26"), null, null, "+639 98 (958) 70-92", new Guid("92d6cbc1-d409-403c-b274-517d31726ae9") },
                    { new Guid("e2918163-8257-40d0-b950-68947af262fb"), null, null, "+782 05 (591) 61-28", new Guid("21d9b3f2-945c-40a1-a0ca-7b6fcbe38a4e") },
                    { new Guid("e2e4ffa9-ed31-4123-8a06-7e222f974d98"), null, null, "+194 66 (861) 70-96", new Guid("06f4c32b-9a3d-4b38-99a4-56ea0ba685a8") },
                    { new Guid("e2f7e3f8-019a-4350-ba98-30435de80972"), null, null, "+159 52 (074) 43-06", new Guid("f2c5c231-fa4f-4403-a17b-f986cd15543a") },
                    { new Guid("e327ac7e-05f9-4c7a-a40c-20ef689caa1e"), null, null, "+358 77 (713) 57-26", new Guid("3314d8f7-2262-4e19-afd4-3e85972480b8") },
                    { new Guid("e362b05a-317f-4bfb-9939-01aab7f10a32"), null, null, "+113 49 (296) 11-35", new Guid("8fc5f8c0-3711-4486-8ea0-48697b9ea01f") },
                    { new Guid("e3a9fec6-f89f-4079-943b-65c93829cd65"), null, null, "+834 24 (531) 11-01", new Guid("7da75a84-c857-4768-9ff2-252052ea5333") },
                    { new Guid("e48a83ff-333e-4f07-82ca-04760cbff8f3"), null, null, "+25 51 (603) 60-63", new Guid("ab451099-7866-44e4-9ebd-f1162ea6206a") },
                    { new Guid("e51310e2-2c81-4620-ba59-da554f4ea7dc"), null, null, "+855 13 (852) 45-13", new Guid("99d4724f-46db-42d2-a62b-3d8fa528e130") },
                    { new Guid("e5d3c59e-8ec7-4772-8d19-41aef950b846"), null, null, "+823 17 (567) 25-76", new Guid("7de3e658-53a0-464d-a4aa-b7bf40828f5d") },
                    { new Guid("e6144eed-8037-422c-96f8-6318870bfce6"), null, null, "+534 99 (479) 32-25", new Guid("8bfa284c-faeb-4fb6-909c-2a2ea4c8745b") },
                    { new Guid("e6273f1e-3514-4090-84bf-7c5ac9644798"), null, null, "+44 49 (502) 83-96", new Guid("c5513371-ea13-4b3b-ab65-8bbb471b2afc") },
                    { new Guid("e6441fcf-60c3-4caf-9d0a-f26463098955"), null, null, "+503 97 (730) 39-90", new Guid("087fb413-124f-47b1-b54e-4bdedf2edf63") },
                    { new Guid("e66eb44e-3201-4ee1-8552-92b30d3a2cf7"), null, null, "+691 86 (047) 80-82", new Guid("9b254af5-9da3-4b42-a5f3-b573df408d84") },
                    { new Guid("e72a5313-0da3-45fe-9a5b-91ca92906f6e"), null, null, "+414 69 (832) 74-39", new Guid("ce7719fc-1874-4df0-88ba-9b5637945029") },
                    { new Guid("e73ddbad-d6a9-42a3-b59a-90990b8c32f4"), null, null, "+200 84 (215) 93-77", new Guid("57b666b4-3a1b-4303-851f-a88f5f534543") },
                    { new Guid("e77b94fd-3cc1-4c7e-be0e-1b31681454d8"), null, null, "+846 11 (888) 22-71", new Guid("72a42c8b-ed7c-4e7a-81c6-313cac897b20") },
                    { new Guid("e78dc20a-f8d3-4cd3-b1d5-fc3bd23e5ed3"), null, null, "+449 61 (732) 47-51", new Guid("c88c725e-8cbf-416d-a4bf-153a024ea6c9") },
                    { new Guid("e81c47e1-6fb7-4a8c-a3c7-c098c0fba846"), null, null, "+871 62 (999) 46-03", new Guid("affd1717-742a-4014-8e72-3420c7496c1e") },
                    { new Guid("e81cffc0-6c8d-4875-9585-3f12f0cfd6d3"), null, null, "+249 95 (746) 86-13", new Guid("75ba16eb-aa9c-4c6f-90ae-1515360055a9") },
                    { new Guid("e8292c23-6f51-43dd-a7c3-fd247b247162"), null, null, "+759 70 (797) 47-62", new Guid("8c18ec85-46f2-44b0-bd0b-56adb1bf7743") },
                    { new Guid("e857d047-b7b1-48f6-9833-b50274f17f8d"), null, null, "+688 21 (488) 20-99", new Guid("f5fa9239-e966-4c8e-9eb5-32ecf277976e") },
                    { new Guid("e8e9385d-6e5c-4b51-8b4c-add0df368613"), null, null, "+960 88 (407) 47-23", new Guid("0d230077-5e9b-42d8-a83a-650a22378849") },
                    { new Guid("e99bba99-e60a-4a46-ba11-dfba1ca30a62"), null, null, "+619 38 (349) 78-30", new Guid("50b1b40f-32d2-45da-a690-b9d24fff476e") },
                    { new Guid("e9dbe909-05e0-4e9f-b7a1-9195671929cd"), null, null, "+93 27 (371) 89-35", new Guid("353c126e-57f5-471a-b13f-0e4fd4cef2fe") },
                    { new Guid("ea03a68c-f132-4ec3-b312-430d9ced76c1"), null, null, "+310 65 (320) 13-46", new Guid("cf3285c8-97d7-426d-87f3-e0854194e226") },
                    { new Guid("ea17b017-6435-473e-963f-6fc665920ec6"), null, null, "+65 18 (826) 57-38", new Guid("36ffb969-580b-40d2-8fa0-94749ea99214") },
                    { new Guid("eadfeef2-4888-4603-98e1-90768dea855c"), null, null, "+536 81 (402) 06-10", new Guid("3ff3d88e-b078-4f3a-8312-8447eeb772e2") },
                    { new Guid("eb1e549e-2c4e-48b3-be86-9de51b32a077"), null, null, "+973 24 (675) 62-59", new Guid("e41a0e5f-468e-496b-8fe7-b8f4b2a0f962") },
                    { new Guid("ebd99179-6253-4d15-98b6-8dd3123c000a"), null, null, "+554 16 (488) 42-45", new Guid("2476b4fb-aceb-40f6-b636-80dd269d535c") },
                    { new Guid("ec8707b8-bd6d-47c7-9423-91f82273919c"), null, null, "+721 16 (112) 82-04", new Guid("1b1ebe07-5765-4728-8b40-ee14061347ae") },
                    { new Guid("ed1b0797-a581-4f5a-b506-47ca6dc5fa93"), null, null, "+841 00 (216) 60-17", new Guid("bbe91897-98e6-4c1e-aef5-09cd3dbb35cd") },
                    { new Guid("ed979cbf-9875-4397-b836-5af8cf2f5984"), null, null, "+400 26 (604) 65-62", new Guid("e41a0e5f-468e-496b-8fe7-b8f4b2a0f962") },
                    { new Guid("eddbddf8-6a05-4f8c-8eae-962292db1fa7"), null, null, "+175 76 (789) 48-33", new Guid("d57e07f1-63a6-4514-ae7a-51f83c901e2c") },
                    { new Guid("ee2ce34b-bb11-4885-933c-4b11587cb2c0"), null, null, "+268 70 (073) 49-02", new Guid("21d9b3f2-945c-40a1-a0ca-7b6fcbe38a4e") },
                    { new Guid("eeabf3af-3a81-46e6-85f9-2fbe7a2fd35d"), null, null, "+848 77 (796) 77-16", new Guid("1a21f215-231c-4e09-b7c2-4e3163978286") },
                    { new Guid("eee81be5-5608-4cbd-a57b-c2f947ca7c76"), null, null, "+206 34 (466) 67-48", new Guid("4f42e5ab-642c-4775-b2b2-a116ecfcd663") },
                    { new Guid("ef45cd72-c901-494f-a6a4-1349829745ba"), null, null, "+575 56 (684) 95-62", new Guid("4a9e17b4-cb0f-4c82-80d2-e1d56fe06f0a") },
                    { new Guid("ef5ebbb9-dc3f-4175-b17d-f7acf31558fe"), null, null, "+957 34 (566) 11-71", new Guid("64174d68-43d3-488f-89bf-23d32b134019") },
                    { new Guid("ef721d42-b966-40be-8b1f-9c4c2a9aa147"), null, null, "+535 20 (239) 92-37", new Guid("108fbff3-4041-4eed-b2a0-4a4b1fb47787") },
                    { new Guid("ef754370-66b1-4d57-8485-76c136754ce9"), null, null, "+623 83 (389) 84-47", new Guid("c3cc5785-6364-48fa-bb83-e7ac33fc672b") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("efe37be9-0af8-4210-89e8-64f2ad5c4679"), null, null, "+198 84 (401) 56-44", new Guid("0776f148-3954-48ff-8bb8-772d353c1a3c") },
                    { new Guid("f0845a09-933a-4c9c-afbe-9723796bb3b3"), null, null, "+619 01 (842) 67-94", new Guid("097cb7d3-d333-48aa-b8ee-cacd11ee91fa") },
                    { new Guid("f0a6771d-5646-4402-b08f-35c0d1db16db"), null, null, "+988 08 (516) 20-61", new Guid("c7f42761-e210-47b4-9e39-2df36dce4c96") },
                    { new Guid("f115be90-9456-4404-a73b-af4bf8f33887"), null, null, "+155 77 (355) 95-01", new Guid("9ec54876-333f-4825-9959-c839395cb66e") },
                    { new Guid("f12a0d56-e80c-4f59-a37d-34a169e68a8d"), null, null, "+533 52 (290) 15-22", new Guid("4d006d0d-8a50-4d81-886b-176313d018fb") },
                    { new Guid("f17ec4f9-1d7a-4a19-9a9f-33b5fd95053e"), null, null, "+471 97 (506) 20-88", new Guid("7de3e658-53a0-464d-a4aa-b7bf40828f5d") },
                    { new Guid("f19b6e17-367f-481c-855b-fa98702d4f1f"), null, null, "+987 18 (546) 73-53", new Guid("97e11482-d5e6-41d7-82e3-80806df9c3bc") },
                    { new Guid("f1a59959-4b55-4593-8dfa-93e59778b66e"), null, null, "+287 56 (327) 50-36", new Guid("487f0344-4cde-4b10-971a-1f8311cce3f5") },
                    { new Guid("f1ca29e4-0a85-43c2-92be-4c67ed781288"), null, null, "+532 56 (557) 82-71", new Guid("d0aae9a2-8c5b-48e9-b856-e309c80cadae") },
                    { new Guid("f1e012a8-d525-454c-b582-3ea1de220495"), null, null, "+1 19 (395) 75-32", new Guid("672ce079-171b-4f7e-b744-6b9376e96b61") },
                    { new Guid("f2a87c95-ca73-49d5-b54c-d454c2e496c8"), null, null, "+664 30 (769) 44-89", new Guid("8ea935b6-2c30-4bef-803c-9f382789979b") },
                    { new Guid("f2cc3911-1c90-4a20-b28a-f8d6b0152b85"), null, null, "+396 56 (052) 79-50", new Guid("8ce72c63-9c31-4159-9ba2-012a4fc3df72") },
                    { new Guid("f2f59343-35c8-492f-a6bc-807fbacf2f72"), null, null, "+577 72 (818) 76-52", new Guid("a780acfd-e10d-4dc5-a383-1ba56a91e666") },
                    { new Guid("f35e6526-d228-4f82-a0b5-0449501844dd"), null, null, "+604 96 (662) 69-99", new Guid("50fa1a40-d4af-4edd-8c00-61ec693395b2") },
                    { new Guid("f360453f-f906-498f-b493-ef717b142365"), null, null, "+726 95 (162) 42-93", new Guid("4083c32d-a4cd-4c70-b794-fa7b97aafe4e") },
                    { new Guid("f3962f9a-bea7-4368-8ae6-9f7ad44aaec5"), null, null, "+507 01 (776) 39-34", new Guid("c36bd526-4a45-4a4b-9d0e-50c279e9b939") },
                    { new Guid("f399c803-6441-4cb2-aae9-b8bb8e6bc813"), null, null, "+494 16 (812) 15-26", new Guid("1381d1cd-5c11-46c1-bc37-987b3f5ae33e") },
                    { new Guid("f3ba5404-5433-488f-b1ee-9b400126610b"), null, null, "+235 65 (946) 12-35", new Guid("9cf1e944-d004-426c-83ee-acb2b8793bc6") },
                    { new Guid("f3fcc40e-2022-4452-b6fb-6141ab6e79aa"), null, null, "+423 97 (013) 76-63", new Guid("25c234e8-8d95-42b3-9dc3-c418fbcaa7da") },
                    { new Guid("f4265aaa-e5a2-4507-abc6-948d51f7ab59"), null, null, "+324 92 (801) 15-09", new Guid("5e1f9cf6-8e77-46be-92e7-b3f10da0ed86") },
                    { new Guid("f427fc8f-3efd-402d-8f25-b4c6e440e2ae"), null, null, "+77 71 (311) 70-95", new Guid("bd349cb3-f696-4e78-9355-45b8b4f7385f") },
                    { new Guid("f477bb08-6f6d-4d45-a320-8896e45873c3"), null, null, "+866 47 (002) 79-93", new Guid("bc7c70fa-9300-4c06-afd7-8aa97fcf9993") },
                    { new Guid("f4ed0478-5314-4b31-a145-43aeef117d10"), null, null, "+579 70 (082) 45-27", new Guid("8ce72c63-9c31-4159-9ba2-012a4fc3df72") },
                    { new Guid("f4fc3dff-d3bf-45c7-85b8-43d500c10ccf"), null, null, "+801 97 (608) 86-55", new Guid("4c5d0085-4956-4748-b989-09b4d927d669") },
                    { new Guid("f5d755c0-97b1-4a8c-b986-09ceedf2aa73"), null, null, "+557 18 (777) 78-84", new Guid("8dca8632-b27c-44ad-bd6c-0d7679a4f075") },
                    { new Guid("f628f56f-a063-4621-b68c-e51de23b30c1"), null, null, "+850 29 (327) 51-19", new Guid("4e8c89c0-a2fb-42d3-8d7a-11fe5d3b6d75") },
                    { new Guid("f6493714-df21-4b26-81f7-6ceeaf408789"), null, null, "+544 81 (985) 43-25", new Guid("4fdddaf5-83dc-4f45-ad82-fcab10f87405") },
                    { new Guid("f6f58554-62ea-4809-9366-b4c971ad014d"), null, null, "+587 02 (594) 42-64", new Guid("dc2b5eaa-01f8-425c-874d-15e523189cc1") },
                    { new Guid("f6fb9e34-9567-48b9-8f4a-b2b90b08b772"), null, null, "+714 91 (774) 70-67", new Guid("5d1e2a88-0f0a-4b6e-a524-e279224a1944") },
                    { new Guid("f754f15c-cf6d-4c06-81da-78003f4369bd"), null, null, "+221 51 (494) 91-03", new Guid("c58f524e-a96e-4e8b-9186-6c21d38d64b3") },
                    { new Guid("f776e1cf-f2e5-49e5-bcf1-c0f432e4a151"), null, null, "+604 10 (012) 73-18", new Guid("0d230077-5e9b-42d8-a83a-650a22378849") },
                    { new Guid("f8201074-b435-4d74-9019-7f27e09ed71e"), null, null, "+606 86 (501) 78-80", new Guid("3a6fda52-d9f1-418c-8ffa-69974f7f39be") },
                    { new Guid("f82ac218-a310-44ed-8712-7e89a7a81526"), null, null, "+721 59 (945) 49-45", new Guid("76c44275-2d3e-43e9-b34e-c05f912213b8") },
                    { new Guid("f8422553-3363-4bc7-bc92-7adad03e9a3c"), null, null, "+973 62 (720) 78-32", new Guid("c5efb9ab-d786-43d2-9595-c90aedaedb9b") },
                    { new Guid("f92c5135-8e6e-4fdc-9f37-d95ef3c84b29"), null, null, "+364 58 (061) 65-60", new Guid("0c66002d-25be-4864-84e7-acd6fd765b27") },
                    { new Guid("f9d3f2df-a6fe-4dcf-bda8-506875a267c6"), null, null, "+807 36 (390) 17-67", new Guid("56234ad9-accf-413f-8d2b-5d6fb1cd04a1") },
                    { new Guid("fa112c47-7db2-40e6-a041-811040b39fa8"), null, null, "+597 12 (687) 26-19", new Guid("adbbd240-641f-475b-b705-5e35298ef012") },
                    { new Guid("fa6bc760-8d1d-431b-8c73-9ee0aceabb2d"), null, null, "+953 69 (900) 84-81", new Guid("d57e07f1-63a6-4514-ae7a-51f83c901e2c") },
                    { new Guid("fba9c7a2-9a37-4491-8019-6ff9c94ca51b"), null, null, "+42 25 (864) 98-15", new Guid("4d006d0d-8a50-4d81-886b-176313d018fb") },
                    { new Guid("fbbf9583-f85a-4828-9480-59a68dfca222"), null, null, "+123 41 (396) 26-76", new Guid("8be01b71-4060-43ad-98a5-2c0730fd003b") },
                    { new Guid("fc25e90e-c999-471f-afd4-509e5cc771bf"), null, null, "+390 26 (830) 72-54", new Guid("5aff4312-b9a9-4958-b14a-305be3aa9f4b") },
                    { new Guid("fc66ce9e-0e4a-4500-b1f2-1364e028bdae"), null, null, "+907 75 (050) 61-54", new Guid("c221f46b-a606-417e-aead-c8b255d84d11") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("fc68a55b-11e4-46c0-9f7d-826e27e42e95"), null, null, "+134 60 (070) 70-15", new Guid("ed5c634a-32ee-48fd-80f4-26cfb1c72602") },
                    { new Guid("fc77573c-a9ff-4fef-a2d7-015eed003f1e"), null, null, "+420 45 (894) 74-04", new Guid("c0ff772c-b38f-4860-9c1e-4c49d424f9a5") },
                    { new Guid("fca0caac-0d62-45db-a941-4712edfe4de1"), null, null, "+179 57 (347) 45-96", new Guid("1154bb55-7f7f-4d91-8347-5797ffeacb13") },
                    { new Guid("fcb48ccd-c4d0-4433-8de2-bbc4567a81f7"), null, null, "+328 91 (157) 36-31", new Guid("d43ee797-d0bc-4a3e-8833-c45e9d340f44") },
                    { new Guid("fd13b2c1-9a9c-44f0-82d6-915170fffac2"), null, null, "+240 44 (635) 04-50", new Guid("1e17494c-b19d-4879-af0e-c6575db6bd37") },
                    { new Guid("fd3ab3b0-fd5d-48be-a07e-8a6cc87b9c48"), null, null, "+867 17 (161) 26-48", new Guid("1154bb55-7f7f-4d91-8347-5797ffeacb13") },
                    { new Guid("fd565f82-4402-4057-b342-28a8fc2ea553"), null, null, "+983 01 (509) 35-32", new Guid("4ecad1f7-2b37-4dd8-be42-dedd60205e81") },
                    { new Guid("fda55b43-a1b9-49d6-8a39-6245eb5578dc"), null, null, "+212 15 (355) 29-54", new Guid("3712e35b-2da9-4c76-ad88-28828e776a5c") },
                    { new Guid("fda87e77-e5c5-4234-a697-405d4bc04b1d"), null, null, "+465 68 (177) 34-81", new Guid("394e6c37-a398-4cf7-983d-8fb216e6c46f") },
                    { new Guid("fe7714c9-dc50-49ca-b3ec-77714e67c4a9"), null, null, "+376 87 (200) 18-52", new Guid("2e3a99a4-4308-410d-b67e-4763bbd6b9c8") },
                    { new Guid("fe950339-781a-4458-af74-027f4142d133"), null, null, "+260 51 (316) 64-63", new Guid("59a9232d-40d9-422d-8a1a-fe022e85093a") },
                    { new Guid("fefdd592-e978-491b-9fd5-4ecdb696ec8c"), null, null, "+910 54 (080) 43-10", new Guid("8bfa284c-faeb-4fb6-909c-2a2ea4c8745b") },
                    { new Guid("ff0c13cc-860e-48ca-80cc-f6da854f3f76"), null, null, "+79 73 (528) 31-03", new Guid("ea848f07-5360-4e76-ac1d-cf046366d4ef") },
                    { new Guid("ff2b02cb-7c8c-4cd7-87dd-03b0bddf42d8"), null, null, "+365 13 (621) 24-37", new Guid("eeb82343-3a6f-48ee-b791-709692ceea7d") },
                    { new Guid("ff2c58ce-d66e-4b2d-9ada-e4bbaef96880"), null, null, "+995 62 (015) 96-59", new Guid("56b8dced-e510-417c-8b93-8a2cb06b845a") },
                    { new Guid("ff4f9612-b066-476a-9d92-decb56f51cef"), null, null, "+608 93 (940) 35-13", new Guid("25c234e8-8d95-42b3-9dc3-c418fbcaa7da") }
                });

            migrationBuilder.InsertData(
                table: "UserParcelMachines",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "ParcelMachineId", "UserId" },
                values: new object[,]
                {
                    { new Guid("06750d7c-655e-402c-bea5-92f8c58f7f4d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f74c47eb-ec5f-4ba4-b8fd-c10e20f0bff8"), new Guid("db32027d-cf9c-4544-af7d-d20c917925c7") },
                    { new Guid("0ccfbcc2-a9bb-4a90-a26d-8bf49cc0cda5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0468ea01-aceb-416d-b978-7cf43120877f"), new Guid("48f4af12-c8b0-4444-98ca-81df5d349e01") },
                    { new Guid("13e89372-9d97-4323-a99c-965569637700"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a1c06906-8732-416c-a4fc-29ad95c5f002"), new Guid("f28f3fdf-fa90-4b58-895f-89b7f89e53e9") },
                    { new Guid("1f1947a7-8707-473d-a55d-a26bcf8c72c1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("58235a1a-afdb-41a2-b991-528250511518"), new Guid("48f4af12-c8b0-4444-98ca-81df5d349e01") },
                    { new Guid("2e246468-a406-473c-83ab-7f85955462d3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a1c06906-8732-416c-a4fc-29ad95c5f002"), new Guid("c7c0cd55-07d8-41cc-9d2b-4bd04cb7edb3") },
                    { new Guid("2f973317-6419-4308-b10b-01c84b0b229e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("aa608ceb-68af-4b6f-aaf8-28bb37576957"), new Guid("5aff4312-b9a9-4958-b14a-305be3aa9f4b") },
                    { new Guid("3233d1df-7f42-43dc-b7b3-b8202e407f3a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a999a2b6-4c48-49ab-8061-ec6d28e0a171"), new Guid("d43ee797-d0bc-4a3e-8833-c45e9d340f44") },
                    { new Guid("327c8014-9669-4677-960a-9f6f8644ac02"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3d17f8d2-ee40-4481-9c6d-91cefd7e33c1"), new Guid("99d4724f-46db-42d2-a62b-3d8fa528e130") },
                    { new Guid("33526238-e61e-4f00-9a42-bdfce8848729"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("710bba6d-4210-470d-9f0b-ebfdab7469be"), new Guid("8b3afef3-3bbb-4237-b8b8-1eba1df7757e") },
                    { new Guid("33b16593-bd7f-4b40-b4b7-3e414ba05bbe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("46965ce1-5364-4913-bd7a-2ceb74c585e7"), new Guid("405a5eb1-aee0-4578-8748-2d8b5a6b0d57") },
                    { new Guid("36bdd380-f4d1-49f5-bcc9-ca210b9e5ef8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7e451632-f8bd-4029-ab71-12f636420ebd"), new Guid("6b5cd903-9056-4302-b3e6-b910c3a67f76") },
                    { new Guid("37941451-47fe-41bd-a726-811f582b57d2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e509c407-759a-45f4-a4cf-8f4234d0cb66"), new Guid("0ec010bc-7e48-4cb9-bb93-8dd9d5b37f6d") },
                    { new Guid("3e3f839a-bab8-46da-9fd5-68c939d66fd7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8c88fd24-7820-4033-9677-c83854c16403"), new Guid("4efd0f6e-db18-4603-b7c2-f032eb9132a9") },
                    { new Guid("4109554e-edbf-4f17-80c7-c8f1d8fd8344"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e6ee6cbb-2a6c-4254-8f3d-6ccff987db33"), new Guid("aeae0f68-579f-46b8-bee2-c797ee09ee5e") },
                    { new Guid("46a40b38-f9a3-4743-bb42-0c7629b15b3a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d22edb2d-5381-4ce7-b715-5d38edce9f8b"), new Guid("8fc5f8c0-3711-4486-8ea0-48697b9ea01f") },
                    { new Guid("546ca39c-aa30-4667-ab32-8f4df0636677"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8c88fd24-7820-4033-9677-c83854c16403"), new Guid("9e96d314-cd64-47aa-a5bc-7e0525cc9914") },
                    { new Guid("581250fb-a932-4ab2-beca-765502b8a4c7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f21855d7-cfb6-4b8e-af2c-65382b12c736"), new Guid("e5406e78-ce40-43ee-8dee-e58fe7687eb3") },
                    { new Guid("587486b7-c214-4970-a4e5-693b14588ed6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9c676e7c-cee2-4fb0-b15c-ad680a4e0508"), new Guid("9e39f449-ecbf-4238-8ca8-47309c134789") },
                    { new Guid("5e29e95f-d4e7-498f-8f67-b6760bed4a75"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f17c1701-0e46-4252-b359-35ca70436e43"), new Guid("3ff3d88e-b078-4f3a-8312-8447eeb772e2") },
                    { new Guid("5e566461-5a3c-4bea-9aec-1f01f33b8e13"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("222500b6-d2ed-42b0-8935-d7a57033ec6a"), new Guid("cf348fa5-7d32-48ec-957c-eb481beb0358") },
                    { new Guid("5e5969f8-2879-4316-bd44-3ac6e45edfae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e509c407-759a-45f4-a4cf-8f4234d0cb66"), new Guid("cf3285c8-97d7-426d-87f3-e0854194e226") },
                    { new Guid("6a89c40f-4918-4db1-8a87-c05d16812c72"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("661d7ffb-22a1-4e54-8f7b-baddab4e818b"), new Guid("b8e5286e-6ec4-4001-89c4-e17065f9bf09") },
                    { new Guid("70a55893-a864-40c7-8abb-02175796376f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("dc7833fb-d139-4f65-8a6f-bc2fea32c559"), new Guid("080ced29-2e70-40de-82e4-0a2d478fe53e") },
                    { new Guid("7234c056-e298-4310-8fa7-e60f7bf2882a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("566b54f1-4b53-47e1-9081-144113bb9c9b"), new Guid("54c975d2-dbfe-4626-97fa-ceaa28e85030") },
                    { new Guid("79df5ef0-0e71-44f3-ab36-cb50234bae03"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("58235a1a-afdb-41a2-b991-528250511518"), new Guid("64174d68-43d3-488f-89bf-23d32b134019") },
                    { new Guid("818f3ad4-25fb-404c-9be7-b6ee2ba6df78"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9b3600ec-6abb-4527-8353-b86e0ba9dfe9"), new Guid("a419df27-9358-4a02-9ab7-2f2e2344fae0") }
                });

            migrationBuilder.InsertData(
                table: "UserParcelMachines",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "ParcelMachineId", "UserId" },
                values: new object[,]
                {
                    { new Guid("8399d52f-3668-4946-a05a-fa0624a0e82e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f17c1701-0e46-4252-b359-35ca70436e43"), new Guid("d57e07f1-63a6-4514-ae7a-51f83c901e2c") },
                    { new Guid("85ac338c-dbf4-4603-bc39-3bf35486cd43"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f17c1701-0e46-4252-b359-35ca70436e43"), new Guid("64174d68-43d3-488f-89bf-23d32b134019") },
                    { new Guid("86fc56c4-24c0-40b0-a4ac-f059ac11b7f3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d935d64c-4b36-4555-acbc-b624c4af40dc"), new Guid("4b45c810-f446-449d-8b0e-4a2ebbbf7104") },
                    { new Guid("87a26995-e42c-40f7-a95f-0a7a1238947f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("76c53964-2524-4d25-a9b9-cf207b81dfe0"), new Guid("d0aae9a2-8c5b-48e9-b856-e309c80cadae") },
                    { new Guid("8ad1ccae-6e0b-421d-8ab5-53035e31a8d9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8089ccd2-8029-47ca-ad35-b3b01d71501c"), new Guid("e36aac18-179d-420c-8aaa-edf7ff736e50") },
                    { new Guid("91ad1fbf-4918-491d-9f81-7d7b135389e2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("55852a60-9ae1-4d32-8768-ba1817455e63"), new Guid("c5513371-ea13-4b3b-ab65-8bbb471b2afc") },
                    { new Guid("992165f8-1161-4a90-bcf5-6f93b166d9b4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3405c9c8-4177-44e5-bdad-e6c6b4aeab8a"), new Guid("dd550cd7-4eae-4d75-8be5-5f3e496fdd24") },
                    { new Guid("9c5036b8-bc32-44c5-bf4e-d31136c81b27"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f828bcdf-be5a-483e-af6c-a5e45c5b1b9b"), new Guid("7abaa815-d503-4740-a0a9-20d8752fc2cf") },
                    { new Guid("9f2312f8-73a8-4127-a1b7-bd60b7b93dbc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c73190bb-ed98-41ec-ab25-a2b158d3818e"), new Guid("8dca8632-b27c-44ad-bd6c-0d7679a4f075") },
                    { new Guid("a093d9fa-e43d-40ae-8627-89d4380a2476"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8c88fd24-7820-4033-9677-c83854c16403"), new Guid("f4c8c27a-6b37-469c-9492-061adc476725") },
                    { new Guid("a6d63afb-a582-4efa-b592-6d0b5fd3f684"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a1c06906-8732-416c-a4fc-29ad95c5f002"), new Guid("adbbd240-641f-475b-b705-5e35298ef012") },
                    { new Guid("a716e9e4-ab27-4f0d-b78e-b2178b5a354b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("62ade7ef-4e34-479d-8622-6a46590825d9"), new Guid("61dcb7dd-eb57-4421-b814-6cd202b0f4a1") },
                    { new Guid("a8c07693-f307-436d-85e1-bbb409f28e83"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7e451632-f8bd-4029-ab71-12f636420ebd"), new Guid("21d9b3f2-945c-40a1-a0ca-7b6fcbe38a4e") },
                    { new Guid("aace5f48-e895-4c9a-8d70-07c94f3d3939"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f828bcdf-be5a-483e-af6c-a5e45c5b1b9b"), new Guid("4732299f-418c-4c2e-ac09-aacb3b2c8976") },
                    { new Guid("b2a2c294-dcd3-4918-8205-6860d8743398"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("31bab75a-923e-401d-aa20-f89bf5902e7b"), new Guid("323967f9-cf4e-4818-a5bf-94dff7ea728b") },
                    { new Guid("b5f1c384-12fc-4657-bafb-80bfdeb0a22f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("aa608ceb-68af-4b6f-aaf8-28bb37576957"), new Guid("d43ee797-d0bc-4a3e-8833-c45e9d340f44") },
                    { new Guid("bf45d7ad-f942-4109-9a65-a22b0aecb4d5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9b3600ec-6abb-4527-8353-b86e0ba9dfe9"), new Guid("0e7742f2-e964-4e8c-b692-4ffb75ece318") },
                    { new Guid("c1e431f1-890f-4e39-9005-0e2a87735aa3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e81896ad-49d6-4b9f-9d21-36ce2e2569cf"), new Guid("487efc58-2d93-4b91-a4fb-1ce1d3ef038a") },
                    { new Guid("c3779d54-1c66-4332-ad0e-9e90ae49aa08"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("592f9c89-50e9-4d25-9c28-664ba4900563"), new Guid("c221f46b-a606-417e-aead-c8b255d84d11") },
                    { new Guid("cd0e0431-1920-408b-9dce-3a0adc1dae78"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a1c06906-8732-416c-a4fc-29ad95c5f002"), new Guid("4188ab2e-f46b-4cf6-b460-560a914e5d35") },
                    { new Guid("cfc2af5d-8c70-4944-b15c-e04b7e349c5d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e6ee6cbb-2a6c-4254-8f3d-6ccff987db33"), new Guid("4b45c810-f446-449d-8b0e-4a2ebbbf7104") },
                    { new Guid("d048a5a0-ba44-4c79-afd0-adf5fc7280c0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("58d75ce1-187f-42ea-9907-6116aace8f5c"), new Guid("f4c8c27a-6b37-469c-9492-061adc476725") },
                    { new Guid("d08076f9-99c6-410d-965b-27723f127ae1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f17c1701-0e46-4252-b359-35ca70436e43"), new Guid("a59d873d-ae08-427c-b25e-29c55895239f") },
                    { new Guid("d191639b-93d9-48bc-a5e4-667693aba61a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4e7b9177-3edc-4a7b-aadc-a181cc69f17e"), new Guid("59a9232d-40d9-422d-8a1a-fe022e85093a") },
                    { new Guid("d1e495d9-eba1-450f-a516-ba2324450cc1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("560cd733-1510-411e-bd76-418c0279a1a4"), new Guid("4083c32d-a4cd-4c70-b794-fa7b97aafe4e") },
                    { new Guid("d870f865-64b3-4fdb-8b3e-03dca52400a9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a257c649-cc45-4c4f-94bb-15ae61eb9813"), new Guid("61dcb7dd-eb57-4421-b814-6cd202b0f4a1") },
                    { new Guid("d8e7d688-7cdf-496c-9853-8545922594fb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6844e222-6205-47f1-b36d-3d91079d0826"), new Guid("0e6930e6-cf0a-4195-8d74-a9cc0dfb30b6") },
                    { new Guid("dc42515b-99e2-492d-8f98-d577d85fe461"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c73190bb-ed98-41ec-ab25-a2b158d3818e"), new Guid("4a9e17b4-cb0f-4c82-80d2-e1d56fe06f0a") },
                    { new Guid("dd365b46-dbf8-4a36-bd23-f3da23814923"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("17a015cb-7dfd-4c22-a4c5-5a73a327da20"), new Guid("4d006d0d-8a50-4d81-886b-176313d018fb") },
                    { new Guid("e6dccfc4-2db6-40c2-a740-728401c6ae94"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("46965ce1-5364-4913-bd7a-2ceb74c585e7"), new Guid("4b2a14c5-b9ad-4e45-ae16-0762e7d1e215") },
                    { new Guid("e7147662-b6c1-42aa-96ee-932e4721544d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f4b3d8a0-c197-4ceb-b49e-eb4bc305b17f"), new Guid("2700d101-47ef-4c75-a3e1-b613514a94f0") },
                    { new Guid("e9d960bd-f132-46ba-8e79-c6a22906b2ef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("862ae6dd-1c01-4827-8a1c-2622dbe1d94b"), new Guid("59a9232d-40d9-422d-8a1a-fe022e85093a") },
                    { new Guid("faa6366c-fcec-4dda-999f-113b5df5bf85"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("55852a60-9ae1-4d32-8768-ba1817455e63"), new Guid("0a1370d0-5d3b-4609-9efc-9507f4acc2f8") },
                    { new Guid("fdb974e0-f391-4285-975f-11bb2fceee12"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9c676e7c-cee2-4fb0-b15c-ad680a4e0508"), new Guid("9e39f449-ecbf-4238-8ca8-47309c134789") }
                });

            migrationBuilder.InsertData(
                table: "UserPostBranches",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PostBranchId", "UserId" },
                values: new object[,]
                {
                    { new Guid("00ded126-39cc-4650-8823-64adc4fcf7a9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("11dd29ef-8cd7-46a4-8c0f-ba233e4b67f4"), new Guid("5aff4312-b9a9-4958-b14a-305be3aa9f4b") },
                    { new Guid("01999dd5-eb13-46d5-a7bc-020115038e29"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b713e0f2-510e-40f5-a395-8adf805c1ee3"), new Guid("64174d68-43d3-488f-89bf-23d32b134019") },
                    { new Guid("0351645f-a089-4504-9140-c29ea9e9d717"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("dd03813a-f5a8-4387-8db8-006fa63e85f6"), new Guid("9e39f449-ecbf-4238-8ca8-47309c134789") },
                    { new Guid("0621480c-0f3f-4db1-b3c8-de7b0c18c838"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("160984a0-aa30-4b0b-8351-18010bda3136"), new Guid("a59d873d-ae08-427c-b25e-29c55895239f") },
                    { new Guid("0c19da6f-de61-49a3-8c5b-9f718c774d44"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("dd03813a-f5a8-4387-8db8-006fa63e85f6"), new Guid("6b5cd903-9056-4302-b3e6-b910c3a67f76") },
                    { new Guid("0c1c3531-765d-46f7-a85d-06a00a0e67ea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c15e4086-648a-47ed-838b-d150623eb624"), new Guid("61dcb7dd-eb57-4421-b814-6cd202b0f4a1") },
                    { new Guid("0c3ce4b8-07aa-427a-8d8c-8c1ee2c80729"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2ac39f2f-79dd-4f61-bbbe-f987d800aa59"), new Guid("64174d68-43d3-488f-89bf-23d32b134019") },
                    { new Guid("185648d0-7f7b-420a-951a-fe294f104825"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("05424d6a-3732-4b9c-86d8-9b856f2c829b"), new Guid("c221f46b-a606-417e-aead-c8b255d84d11") }
                });

            migrationBuilder.InsertData(
                table: "UserPostBranches",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PostBranchId", "UserId" },
                values: new object[,]
                {
                    { new Guid("19892e0f-9e09-4c88-8595-783a283c5b64"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("762e6a22-5edc-404b-92c6-2b74996b1367"), new Guid("3ff3d88e-b078-4f3a-8312-8447eeb772e2") },
                    { new Guid("29883976-5a9d-4f7e-b215-52a898fc3970"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("fe5c7f8e-b9b8-454e-98b1-86c30abca4a9"), new Guid("e36aac18-179d-420c-8aaa-edf7ff736e50") },
                    { new Guid("3879ecda-8888-46f2-8d83-cdc073b5d8eb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6eac7b12-91bd-4c5a-9200-25862d27e34c"), new Guid("dd550cd7-4eae-4d75-8be5-5f3e496fdd24") },
                    { new Guid("39749626-2052-40c9-9871-fdc3ff2aba82"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3728082f-89a6-42f5-ab38-4e82f8f9215a"), new Guid("21d9b3f2-945c-40a1-a0ca-7b6fcbe38a4e") },
                    { new Guid("3b5bc3cd-f87e-4233-8ff0-a659fff9f573"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("63ffc79c-40c0-4f75-aa55-e4ced4464423"), new Guid("8dca8632-b27c-44ad-bd6c-0d7679a4f075") },
                    { new Guid("3ff7c5a7-d2e6-45d1-b57a-584f0ed375b9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("02890f5c-c811-49db-8843-43c7b5c64c71"), new Guid("cf3285c8-97d7-426d-87f3-e0854194e226") },
                    { new Guid("431d72a7-de8a-4fa3-91b2-7f62ced34b37"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("562d503a-0c99-4bdb-bcea-1a39a7f9b447"), new Guid("0a1370d0-5d3b-4609-9efc-9507f4acc2f8") },
                    { new Guid("44e9d8cb-0e43-437e-97bc-05961e1fff8b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d6018212-0e8f-4d07-9882-afb42f07bc6f"), new Guid("0e7742f2-e964-4e8c-b692-4ffb75ece318") },
                    { new Guid("46d3d5db-7f9e-4770-a72e-77d5b2c68df3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("578fcf07-ea13-4d36-9b6b-ed7ce1270226"), new Guid("d57e07f1-63a6-4514-ae7a-51f83c901e2c") },
                    { new Guid("4707338e-fa5e-4bc2-a418-2442995b9197"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ceca5024-bf2a-41d5-b33f-d5a39908bba3"), new Guid("4b45c810-f446-449d-8b0e-4a2ebbbf7104") },
                    { new Guid("49101dcf-4194-459c-90b3-2f5670a34976"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3dfa9e91-2c5e-4d61-a723-d15f9907f3bb"), new Guid("4efd0f6e-db18-4603-b7c2-f032eb9132a9") },
                    { new Guid("53e6b111-087c-48fe-bbfb-936b3de6a539"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3dfa9e91-2c5e-4d61-a723-d15f9907f3bb"), new Guid("323967f9-cf4e-4818-a5bf-94dff7ea728b") },
                    { new Guid("5422fe66-361d-4f76-b9ac-1a47e78946e1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("36ca1bb1-1e46-47e8-84cc-9c91d6d42e9d"), new Guid("d43ee797-d0bc-4a3e-8833-c45e9d340f44") },
                    { new Guid("56418ace-afa5-40f3-8c98-8a8197983da1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("be8ebd43-3b99-4609-b334-47e36a9e2043"), new Guid("487efc58-2d93-4b91-a4fb-1ce1d3ef038a") },
                    { new Guid("58c600a1-5444-4192-ad7e-39911505ee71"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b713e0f2-510e-40f5-a395-8adf805c1ee3"), new Guid("2700d101-47ef-4c75-a3e1-b613514a94f0") },
                    { new Guid("5a64917b-0c55-41b7-9295-dc3cd52fd65d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ed2fc7da-d6f8-47d8-8d40-a8534cf0f3a7"), new Guid("aeae0f68-579f-46b8-bee2-c797ee09ee5e") },
                    { new Guid("5b462542-24e0-45eb-9e1d-fc4daaf6b2c6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2ac39f2f-79dd-4f61-bbbe-f987d800aa59"), new Guid("48f4af12-c8b0-4444-98ca-81df5d349e01") },
                    { new Guid("5f9efc27-a202-4900-ae93-569c0f01a3b6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e9deac14-ad3d-47af-961a-a9f88d91ebbc"), new Guid("0e6930e6-cf0a-4195-8d74-a9cc0dfb30b6") },
                    { new Guid("62a74794-d45e-4d5b-979d-5025f02b5433"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("578fcf07-ea13-4d36-9b6b-ed7ce1270226"), new Guid("4a9e17b4-cb0f-4c82-80d2-e1d56fe06f0a") },
                    { new Guid("62cb794e-a017-44c2-99e7-9ca82f51ba37"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("96ceb4f2-9a2e-44f3-abe6-4eb636c7ede0"), new Guid("9e96d314-cd64-47aa-a5bc-7e0525cc9914") },
                    { new Guid("6609867d-d531-4155-8d4e-2b1b471d3fa4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("215e0978-30a0-4f4a-bbc1-be590cb3b428"), new Guid("61dcb7dd-eb57-4421-b814-6cd202b0f4a1") },
                    { new Guid("693e9a82-cda2-4616-b76d-7e496034840f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c485ffea-0794-4907-97e5-dc00d128bc09"), new Guid("0ec010bc-7e48-4cb9-bb93-8dd9d5b37f6d") },
                    { new Guid("75c17944-5949-4c89-8512-f2ed76d37454"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e42dca98-3a11-4def-8a8a-a4daf84b0676"), new Guid("cf348fa5-7d32-48ec-957c-eb481beb0358") },
                    { new Guid("79a7eceb-9839-4595-83b5-5f797621be23"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6b7bc4ca-63e8-4353-bd9b-d34d8aa8a4f8"), new Guid("db32027d-cf9c-4544-af7d-d20c917925c7") },
                    { new Guid("82b04bfb-e9a0-479f-85b7-428d09347aa1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("556715a8-4725-4d18-bfec-f9d8c4bc8bed"), new Guid("b8e5286e-6ec4-4001-89c4-e17065f9bf09") },
                    { new Guid("832964b5-d1a8-4ad4-9fff-ab8f6a48a6dd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("63ffc79c-40c0-4f75-aa55-e4ced4464423"), new Guid("e5406e78-ce40-43ee-8dee-e58fe7687eb3") },
                    { new Guid("881b0bc6-b8e6-4bb1-9937-5328486fb32d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e42dca98-3a11-4def-8a8a-a4daf84b0676"), new Guid("4188ab2e-f46b-4cf6-b460-560a914e5d35") },
                    { new Guid("960ca496-d3f9-435b-9654-d40a11decfa8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e924eb5a-2e5d-4dbd-bd2f-8ff2e48243d5"), new Guid("adbbd240-641f-475b-b705-5e35298ef012") },
                    { new Guid("9a954060-0c6b-495f-869e-d609848c62d3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("05ecceec-a3b0-4ff7-ac6b-e0df55d81967"), new Guid("7abaa815-d503-4740-a0a9-20d8752fc2cf") },
                    { new Guid("9cb48801-fdec-4078-a42b-b5169986b197"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6456d4ba-fdbe-468e-a062-98c06a43b5b8"), new Guid("8b3afef3-3bbb-4237-b8b8-1eba1df7757e") },
                    { new Guid("9cbe7e04-7d4b-4216-9bbd-6da16e92a5af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2ac39f2f-79dd-4f61-bbbe-f987d800aa59"), new Guid("d0aae9a2-8c5b-48e9-b856-e309c80cadae") },
                    { new Guid("a2be7003-04ba-4bb1-aa77-da8b6424929c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("26055f4c-5625-4617-b4fd-d7188a39fec3"), new Guid("4d006d0d-8a50-4d81-886b-176313d018fb") },
                    { new Guid("a51ab3b5-9b23-41bc-9a56-06485cf4350f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("757b93b2-4d93-49f5-8a9f-ed2b994b170d"), new Guid("a419df27-9358-4a02-9ab7-2f2e2344fae0") },
                    { new Guid("a85cd962-5381-416e-80f6-3ba6197bd9f7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6b7bc4ca-63e8-4353-bd9b-d34d8aa8a4f8"), new Guid("4083c32d-a4cd-4c70-b794-fa7b97aafe4e") },
                    { new Guid("a9d2b37c-331b-4f64-9eaa-8a2a98a905e9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("784634d6-74c1-490b-be22-85be9a2cd9fc"), new Guid("d43ee797-d0bc-4a3e-8833-c45e9d340f44") },
                    { new Guid("b004b16e-2be3-4897-b9fb-8e5299f13db9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ef0c3884-a9b4-4b30-9774-1583c5b4223b"), new Guid("8fc5f8c0-3711-4486-8ea0-48697b9ea01f") },
                    { new Guid("b1d3996d-559b-444e-b029-416f7ba0159c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ceca5024-bf2a-41d5-b33f-d5a39908bba3"), new Guid("4b2a14c5-b9ad-4e45-ae16-0762e7d1e215") },
                    { new Guid("b33d7e5a-1de9-4151-a925-154449980e8d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f1489a7b-0ad2-440c-92e3-1470f05422b8"), new Guid("080ced29-2e70-40de-82e4-0a2d478fe53e") },
                    { new Guid("b6c00891-2875-43b8-9543-d1810edabd7a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b822b2a7-d482-4bb9-a569-f7c1f5027d07"), new Guid("c7c0cd55-07d8-41cc-9d2b-4bd04cb7edb3") },
                    { new Guid("b821de65-7820-496e-9eaf-6484839a02c6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ca76d44f-dcbd-41ad-9691-27eeab4fc833"), new Guid("405a5eb1-aee0-4578-8748-2d8b5a6b0d57") },
                    { new Guid("b9aa2cdb-9b3e-4dd9-b597-147a724607ad"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("dde0b36b-db79-4298-b44b-45ad1c262837"), new Guid("59a9232d-40d9-422d-8a1a-fe022e85093a") },
                    { new Guid("bb14500c-dbcb-4c0e-a407-474ec4508c57"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("36ca1bb1-1e46-47e8-84cc-9c91d6d42e9d"), new Guid("c5513371-ea13-4b3b-ab65-8bbb471b2afc") }
                });

            migrationBuilder.InsertData(
                table: "UserPostBranches",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PostBranchId", "UserId" },
                values: new object[,]
                {
                    { new Guid("c3a65d67-5000-4aaf-b8ef-f513870a07c4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("160984a0-aa30-4b0b-8351-18010bda3136"), new Guid("99d4724f-46db-42d2-a62b-3d8fa528e130") },
                    { new Guid("c460f27b-cb8d-4600-9bcf-37d566f6ee2c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("879299da-d4a5-4323-922d-c3f63dea109c"), new Guid("f4c8c27a-6b37-469c-9492-061adc476725") },
                    { new Guid("c53d7672-f0cd-42e0-ad4a-4305b91be6cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2ac39f2f-79dd-4f61-bbbe-f987d800aa59"), new Guid("59a9232d-40d9-422d-8a1a-fe022e85093a") },
                    { new Guid("d3e5673e-092c-48fd-a1e0-236a57e11cc9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2bc8f746-1b7a-4770-b470-8baadafc77ce"), new Guid("54c975d2-dbfe-4626-97fa-ceaa28e85030") },
                    { new Guid("d823a28d-5568-4d61-8a85-16a5063a0033"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("fd799de0-afa7-454f-8694-e01bef1c4aad"), new Guid("4732299f-418c-4c2e-ac09-aacb3b2c8976") },
                    { new Guid("d9aa2fc6-fa8d-48d2-8b9c-8698559979a2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0b0b671a-3aab-4e4f-be3e-90feac893433"), new Guid("f4c8c27a-6b37-469c-9492-061adc476725") },
                    { new Guid("da40a445-17cc-4fcc-ab96-31f68838196e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0b0b671a-3aab-4e4f-be3e-90feac893433"), new Guid("9e39f449-ecbf-4238-8ca8-47309c134789") },
                    { new Guid("e2fd51c5-d319-4acc-8666-9f6af8fc4f42"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("88b65034-cd44-44ce-bb39-e665565e055f"), new Guid("4b45c810-f446-449d-8b0e-4a2ebbbf7104") },
                    { new Guid("ef046a26-6e0e-4c2c-9d93-d724f88b8d89"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2ac39f2f-79dd-4f61-bbbe-f987d800aa59"), new Guid("f28f3fdf-fa90-4b58-895f-89b7f89e53e9") },
                    { new Guid("ffd807c2-7699-4d15-a555-fca2014f6146"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("193f0061-1dc7-475d-ab69-3d2eef9cf188"), new Guid("48f4af12-c8b0-4444-98ca-81df5d349e01") }
                });

            migrationBuilder.InsertData(
                table: "UserPromoCodes",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PromoCodeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0014b75c-7481-41d6-96e0-6d1e53d8d3f5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("83eac619-4cd8-411e-8a4d-d5efa0a4e9c3"), new Guid("0ec010bc-7e48-4cb9-bb93-8dd9d5b37f6d") },
                    { new Guid("01c74402-e852-427e-910f-25b5709e5c8a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0d9856ca-9d46-43fe-9ea4-677ddd4817a4"), new Guid("64174d68-43d3-488f-89bf-23d32b134019") },
                    { new Guid("07eed0cd-4278-4a63-9431-703c059eea5e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4a2d1797-9ad8-41b6-945b-1a8b5611d51b"), new Guid("e5406e78-ce40-43ee-8dee-e58fe7687eb3") },
                    { new Guid("082d106f-91ad-4965-ad0b-060117148774"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a3ff379e-8eef-4462-a849-0e3071956300"), new Guid("59a9232d-40d9-422d-8a1a-fe022e85093a") },
                    { new Guid("08eeef2b-cba4-47d3-ac76-657218ef9f71"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5288414a-5ef1-470c-91c9-f4331a432a6d"), new Guid("cf3285c8-97d7-426d-87f3-e0854194e226") },
                    { new Guid("11ab4d07-b4d0-420f-9236-b028053f4e8b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a3ff379e-8eef-4462-a849-0e3071956300"), new Guid("d43ee797-d0bc-4a3e-8833-c45e9d340f44") },
                    { new Guid("17350d2c-e54b-4b74-b943-87c77cd9cb1d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("22bd2021-cedd-408d-a684-02403a460238"), new Guid("e36aac18-179d-420c-8aaa-edf7ff736e50") },
                    { new Guid("17c28daf-8237-4b7c-a5a6-cff215a02baa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f0d33a87-e7a5-4a75-aed8-3102cc98d02e"), new Guid("4083c32d-a4cd-4c70-b794-fa7b97aafe4e") },
                    { new Guid("23b39969-eefd-40a6-a6f9-54327ebd65b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a392d48d-270a-4e99-a05d-8ea4e873c4e9"), new Guid("cf348fa5-7d32-48ec-957c-eb481beb0358") },
                    { new Guid("373b83a3-bf22-4b57-aa96-b78be0b78188"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ea2337cc-2949-441a-b624-830942dc6e36"), new Guid("c221f46b-a606-417e-aead-c8b255d84d11") },
                    { new Guid("42e3550a-3e19-4257-bc91-691073439c24"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("64f3333e-672a-414b-b134-9383d3f91503"), new Guid("d0aae9a2-8c5b-48e9-b856-e309c80cadae") },
                    { new Guid("4ab25cd8-06ef-4e2b-8c42-5ff0e9f0fee8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("83eac619-4cd8-411e-8a4d-d5efa0a4e9c3"), new Guid("4b2a14c5-b9ad-4e45-ae16-0762e7d1e215") },
                    { new Guid("4af64e58-a266-40e9-9dfe-beca1429cfd8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("98d436b3-6428-4b86-9fef-350bccb71602"), new Guid("61dcb7dd-eb57-4421-b814-6cd202b0f4a1") },
                    { new Guid("4dbb5368-a70c-460e-badd-ccd4637eb46c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7c85061c-c0aa-4d09-8b68-4f8ead5e2a8d"), new Guid("59a9232d-40d9-422d-8a1a-fe022e85093a") },
                    { new Guid("4e8839a1-cdcc-44ab-a0a6-1502b11b33d7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9ac71479-c162-4968-bf85-adf313dce142"), new Guid("f4c8c27a-6b37-469c-9492-061adc476725") },
                    { new Guid("4eb2e0e5-34b6-419a-aa63-970d0216e9de"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9b22962b-7768-4ca0-81ac-fa4eedef641b"), new Guid("0a1370d0-5d3b-4609-9efc-9507f4acc2f8") },
                    { new Guid("5116ae1d-41e2-4739-b856-9ebf9c37a387"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7a7ac9a8-b81b-4bb8-8c8b-d5f21fb15fcd"), new Guid("a419df27-9358-4a02-9ab7-2f2e2344fae0") },
                    { new Guid("52d42004-a330-4d60-b748-c33b8ef8e778"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ea2337cc-2949-441a-b624-830942dc6e36"), new Guid("aeae0f68-579f-46b8-bee2-c797ee09ee5e") },
                    { new Guid("55452732-ec3e-48de-be1d-14425a518534"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("949ca63e-2ef7-4dcd-93e4-e822b2811af1"), new Guid("5aff4312-b9a9-4958-b14a-305be3aa9f4b") },
                    { new Guid("574dcfe8-87b0-44fe-8d3e-7bd3a909eab6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8fedc85f-a8c9-4781-9c27-2bcc40e94cc5"), new Guid("8fc5f8c0-3711-4486-8ea0-48697b9ea01f") },
                    { new Guid("5a335982-6875-4957-8dff-3a34c17b9c25"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9194b69e-e4a2-4716-801e-cf61d0a88979"), new Guid("64174d68-43d3-488f-89bf-23d32b134019") },
                    { new Guid("65daad8c-cd43-4a78-b655-16ebefbedc7c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f502618f-b378-473d-bd06-c6ad857cf16e"), new Guid("4732299f-418c-4c2e-ac09-aacb3b2c8976") },
                    { new Guid("673c6845-d4f9-4ce4-9e51-0de3b86bbf76"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d10ddb0e-c9a3-4478-abfb-78d3125ca197"), new Guid("48f4af12-c8b0-4444-98ca-81df5d349e01") },
                    { new Guid("6ee4356b-27d2-44f9-a0de-c5afdb034948"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1e2c3b8e-7f5a-4c66-a8b8-f4034b80f3b4"), new Guid("3ff3d88e-b078-4f3a-8312-8447eeb772e2") },
                    { new Guid("75b0debf-fb71-4eed-925c-d93191f8b2c4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("455eadb8-3793-48a6-a507-69f94303225f"), new Guid("6b5cd903-9056-4302-b3e6-b910c3a67f76") },
                    { new Guid("7a4544e6-1c8f-47da-b2ee-47e1e12aac1b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9194b69e-e4a2-4716-801e-cf61d0a88979"), new Guid("487efc58-2d93-4b91-a4fb-1ce1d3ef038a") },
                    { new Guid("7c68fc74-c32b-422f-8c67-7abfe75de41b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f033bbdb-e676-4be2-bf14-a9799258a801"), new Guid("48f4af12-c8b0-4444-98ca-81df5d349e01") },
                    { new Guid("7dfbaf7a-1183-4714-8304-4cde1e9a5fc0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("455eadb8-3793-48a6-a507-69f94303225f"), new Guid("4a9e17b4-cb0f-4c82-80d2-e1d56fe06f0a") },
                    { new Guid("7e45cb58-9cfd-4bd2-a295-ffd533ed8dbc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9b22962b-7768-4ca0-81ac-fa4eedef641b"), new Guid("d57e07f1-63a6-4514-ae7a-51f83c901e2c") },
                    { new Guid("7eea9c1f-d403-4245-ba14-c37b839016e3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1c775f54-10bc-4141-a154-cb51c2ff1819"), new Guid("db32027d-cf9c-4544-af7d-d20c917925c7") },
                    { new Guid("81bad804-7ad5-47d1-b424-ad337a668d1d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4a463d92-aa64-4c91-bc1c-1abc98a4d289"), new Guid("c7c0cd55-07d8-41cc-9d2b-4bd04cb7edb3") },
                    { new Guid("82c49226-5188-4ab7-8170-176534a5cbb2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1f100365-4832-4f01-b908-6dd4017db04d"), new Guid("4efd0f6e-db18-4603-b7c2-f032eb9132a9") }
                });

            migrationBuilder.InsertData(
                table: "UserPromoCodes",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PromoCodeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("83eee73f-41b3-4e87-ba52-7c1afe30ffb2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ee55d0c5-5bca-4ebe-a32c-5e0e57116dde"), new Guid("f28f3fdf-fa90-4b58-895f-89b7f89e53e9") },
                    { new Guid("86c4b6be-88b7-4242-89b6-b4bdf7805439"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a622d817-b271-4d4a-a4b0-9e863ee65b3e"), new Guid("99d4724f-46db-42d2-a62b-3d8fa528e130") },
                    { new Guid("87990044-dd0b-4b90-a989-2d220b997413"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ea2337cc-2949-441a-b624-830942dc6e36"), new Guid("4b45c810-f446-449d-8b0e-4a2ebbbf7104") },
                    { new Guid("89e72f33-f8da-4165-addb-d506236d698b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a9e8d10d-694b-416a-ab14-8ade88403596"), new Guid("9e39f449-ecbf-4238-8ca8-47309c134789") },
                    { new Guid("926c1434-40fa-4cca-a465-33493eee52f5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3c435359-fac4-4efb-ac19-8b89092be3b0"), new Guid("21d9b3f2-945c-40a1-a0ca-7b6fcbe38a4e") },
                    { new Guid("94588e4d-1535-40e3-a27d-3d94a829242d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("de126c9e-a18d-429b-839d-e9ab9549d6b7"), new Guid("7abaa815-d503-4740-a0a9-20d8752fc2cf") },
                    { new Guid("957a33ac-7c6f-43ea-9ec7-320d531fbf60"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0c50c751-2e79-43dd-a466-2e3c59164991"), new Guid("adbbd240-641f-475b-b705-5e35298ef012") },
                    { new Guid("99bbc0eb-7564-4bc2-a868-85a58ae8e43f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7a9d556b-6f52-4f21-b626-28d2edc40024"), new Guid("323967f9-cf4e-4818-a5bf-94dff7ea728b") },
                    { new Guid("a057bbcd-cedb-4872-acb3-deff9ad43788"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d85d925b-972e-442f-960d-cfa350253177"), new Guid("b8e5286e-6ec4-4001-89c4-e17065f9bf09") },
                    { new Guid("a592e4c9-7761-434f-8709-c252187cc02b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("812cd1c3-c210-44b4-b3b7-b996d9332355"), new Guid("0e6930e6-cf0a-4195-8d74-a9cc0dfb30b6") },
                    { new Guid("a5dacb03-dcac-47c1-819e-596e6e9c6c55"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5288414a-5ef1-470c-91c9-f4331a432a6d"), new Guid("9e96d314-cd64-47aa-a5bc-7e0525cc9914") },
                    { new Guid("a65ea7d1-d949-42e6-b0f8-655961d363ef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1fc78409-012f-461c-b64e-a271a4dd7f97"), new Guid("a59d873d-ae08-427c-b25e-29c55895239f") },
                    { new Guid("aab8c122-1c66-49c5-90ec-0c96b54ee410"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("dd3503f2-29b5-42d0-9fb4-6543eb1f4b1b"), new Guid("4b45c810-f446-449d-8b0e-4a2ebbbf7104") },
                    { new Guid("b37e8446-a1d7-46c4-95fe-d29bf80a2362"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7ddcd699-357c-4bd7-b5f4-861eb52840aa"), new Guid("080ced29-2e70-40de-82e4-0a2d478fe53e") },
                    { new Guid("bcc2709b-4bdf-46f0-9aa4-5f0914cf2884"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4599c57a-7df6-45b1-8273-84c2128d37f3"), new Guid("405a5eb1-aee0-4578-8748-2d8b5a6b0d57") },
                    { new Guid("bd463dfd-1e64-4da1-ad2e-96012f972ee5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1882f060-d419-4768-a126-ec035fd48db8"), new Guid("9e39f449-ecbf-4238-8ca8-47309c134789") },
                    { new Guid("bf990f60-782e-4b7e-a389-28ca82839257"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9fe44c2d-f6e1-4080-95bf-1e2c952a06a9"), new Guid("f4c8c27a-6b37-469c-9492-061adc476725") },
                    { new Guid("c14bbea6-aee9-4551-992c-cebdadf8d5f0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0d8c0faa-b3ad-4cb0-bc7d-940de74bf3b9"), new Guid("4d006d0d-8a50-4d81-886b-176313d018fb") },
                    { new Guid("ca0e1b21-51f8-4373-9afd-88185cc62919"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d351d329-b5f1-4c97-a8f3-37f91a5f87fe"), new Guid("dd550cd7-4eae-4d75-8be5-5f3e496fdd24") },
                    { new Guid("d0d93269-6f09-4dca-8f5a-fce5581f9bbe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c73af1ab-df3f-4b31-8eff-6efa69bad81b"), new Guid("0e7742f2-e964-4e8c-b692-4ffb75ece318") },
                    { new Guid("d946d647-8b12-40ee-9256-6728e675b6a2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8b330301-880d-4b0d-9696-fc65139528dc"), new Guid("61dcb7dd-eb57-4421-b814-6cd202b0f4a1") },
                    { new Guid("dc0c6026-bd3c-46a0-9945-53b11e8ffeef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0d8c0faa-b3ad-4cb0-bc7d-940de74bf3b9"), new Guid("8b3afef3-3bbb-4237-b8b8-1eba1df7757e") },
                    { new Guid("e3a0e303-7300-488e-b9b2-e6d05ac5e4db"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d4e748b8-03ab-4231-b143-ef574621e7e2"), new Guid("54c975d2-dbfe-4626-97fa-ceaa28e85030") },
                    { new Guid("e5a1db36-d127-47f2-ad69-2ebe1e63e819"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a15cafda-749c-444e-aadb-549fcf55059f"), new Guid("d43ee797-d0bc-4a3e-8833-c45e9d340f44") },
                    { new Guid("e72ad7f1-c7c6-4201-8b2a-204745072568"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4a463d92-aa64-4c91-bc1c-1abc98a4d289"), new Guid("4188ab2e-f46b-4cf6-b460-560a914e5d35") },
                    { new Guid("f4cc6500-5fb2-4213-a268-67f5d8f5e893"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("dc4f740c-8bb6-4519-aaa1-c36613fb9250"), new Guid("2700d101-47ef-4c75-a3e1-b613514a94f0") },
                    { new Guid("fcc78d8b-b673-4f2b-b383-40bd1314d4bd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c73af1ab-df3f-4b31-8eff-6efa69bad81b"), new Guid("8dca8632-b27c-44ad-bd6c-0d7679a4f075") },
                    { new Guid("fdb7177e-fb25-4085-a30c-4e718b212930"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d85d925b-972e-442f-960d-cfa350253177"), new Guid("c5513371-ea13-4b3b-ab65-8bbb471b2afc") }
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
