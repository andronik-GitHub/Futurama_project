using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalaxyExpress.DAL.Migrations
{
    public partial class InitialCreate : Migration
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
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "Email", "EmailConfirmed", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("00e8ecc6-7b14-4020-bcbd-1a849d69a8c6"), 0, null, 184.0824836823880000m, "75fd368c-c328-4369-9cfe-4fc195245d36", null, null, null, false, "Aaron", "Aaron", "Koepp", false, null, "Aaron_Koepp", null, null, "AQAAAAEAACcQAAAAEN9yXIg83ZypxErGJEHqBgx2DiYf/09XM+0ammzJpkAqCjlAqO2i9DgI9EsqqIddyw==", null, false, null, null, 1, false, null },
                    { new Guid("011fba87-398c-42ec-9aa7-ffb9c48fe9a9"), 0, new DateTime(1955, 7, 6, 0, 12, 0, 380, DateTimeKind.Local).AddTicks(6489), 689.8957534632670000m, "b9b863a2-3aa0-46bb-9403-9ba95bc0c9da", null, null, null, false, "Kristopher", "Kristopher", "Dickinson", false, null, "Kristopher53", null, null, "AQAAAAEAACcQAAAAELp7QuPTCu62EsZR7cBr02R4rGovrpr08zoZ9ruVjh3CnkH2raVAlhlhCsJWELh9GQ==", null, false, null, null, 0, false, null },
                    { new Guid("045fcec6-e944-4ba4-ab53-e930bdb298c6"), 0, new DateTime(1984, 3, 14, 14, 56, 31, 477, DateTimeKind.Local).AddTicks(1864), 262.3334065658870000m, "035df586-04c9-4880-b8f3-6149bfecfffe", null, null, null, false, "Neal", "Neal", "Schultz", false, null, "Neal_Schultz27", null, null, "AQAAAAEAACcQAAAAEAa+ziPA/uDVVrDnoOsC9CoFn7TgNAgG5THAJpswvPXlHCwI+IJqltUwYGeAAdqWpg==", null, false, null, null, 1, false, null },
                    { new Guid("0615c4c1-b356-478a-abeb-caaccb8742b0"), 0, new DateTime(1941, 5, 6, 16, 49, 0, 435, DateTimeKind.Local).AddTicks(7702), 432.7703825521340000m, "dfc07a87-28d9-4a6b-8744-a68ba62a6865", null, null, null, false, "Martha", "Martha", "Kirlin", false, null, "Martha_Kirlin42", null, null, "AQAAAAEAACcQAAAAEM+3EENzc7mSCaidXWFJZ8nGbbGkFQitC8Q4nenVMMGEzGsAbElzfaRm4cCDHb2VGQ==", null, false, null, null, 1, false, null },
                    { new Guid("0643292c-1282-43c9-ae18-5e2311a73db2"), 0, new DateTime(1994, 11, 17, 16, 23, 2, 181, DateTimeKind.Local).AddTicks(9134), 100.480239551150000m, "63daa04a-659f-4da1-91fe-14585ace9e17", null, null, null, false, "Vera", "Vera", "Von", false, null, "Vera_Von", null, null, "AQAAAAEAACcQAAAAEBJGeYZftYUb5GMoXTig0ppZCqX9K/ImEYo2B4fxRc6yGxLsBwb+mEexEPieq6fuUQ==", null, false, null, null, 1, false, null },
                    { new Guid("07169b5c-40fd-40ba-b01e-8b56de466065"), 0, null, 414.2859080673910000m, "a84d416a-f0c8-4d33-8e6a-893691e351ef", null, null, null, false, "Milton", "Milton", "Krajcik", false, null, "Milton.Krajcik47", null, null, "AQAAAAEAACcQAAAAELbE5WySDB2o9Z5mFxOJztM0Of+Io3DsMuj6+hdtzuNclI1tAv8BZzUMJCWsFs4Dvg==", null, false, null, null, 1, false, null },
                    { new Guid("0763ce92-5a2c-4138-ad42-41c5b45988dd"), 0, null, 127.7862098131080000m, "d61a0a3b-a7a7-4ae9-900f-6045aaa36100", null, null, null, false, null, "Ernest", "Bergstrom", false, null, "Ernest96", null, null, "AQAAAAEAACcQAAAAEFgSQ/VfHyibVlBO1MvKUBMM1RZZ77ffIFwevm/3OFEp7PcDyoGZaftiyDxGd93duA==", null, false, null, null, 0, false, null },
                    { new Guid("089446be-2352-4d8f-9726-ba2c324e1aee"), 0, new DateTime(1953, 8, 22, 4, 12, 45, 456, DateTimeKind.Local).AddTicks(6551), 840.6332907035920000m, "fe5b174b-99fa-4bcc-bd65-0983954e0622", null, null, null, false, "Ross", "Ross", "Gleichner", false, null, "Ross.Gleichner34", null, null, "AQAAAAEAACcQAAAAECBEZMo4/4eKGSGgNw/7EabMGe9+cwupgnGSQps5MQDoRSDkqVsFbPLA/1QR1vk06Q==", null, false, null, null, 0, false, null },
                    { new Guid("08e9beba-81d1-40e1-9f0f-4d282258b85b"), 0, new DateTime(2006, 7, 2, 10, 30, 24, 256, DateTimeKind.Local).AddTicks(85), 234.4933323528590000m, "2b52539c-0b19-4914-890e-493f2035c2c8", null, null, null, false, "Tim", "Tim", "Kemmer", false, null, "Tim.Kemmer53", null, null, "AQAAAAEAACcQAAAAEGilZAQxczgjZw5h0XPv3j1cp5P+LDJtWbnI7oYIq0HsLAHhgJaUgMXHcZgzlf7leQ==", null, false, null, null, 0, false, null },
                    { new Guid("08fd0c31-2e97-4cfb-bbf0-9eca4d7bbf0c"), 0, new DateTime(2007, 12, 15, 18, 2, 26, 608, DateTimeKind.Local).AddTicks(4053), 474.8675182883690000m, "053bd0b5-aaf2-40b3-9093-1472880158d9", null, null, null, false, null, "Matt", "Gerlach", false, null, "Matt_Gerlach13", null, null, "AQAAAAEAACcQAAAAEPdOhevXzuxAOjjWSyV7Qlg2RXPhvcZpSUZsCbMWtjQ4mJG60/QaQWkNvJlQpnKdVg==", null, false, null, null, 2, false, null },
                    { new Guid("09378928-71be-4297-b8fb-ea5311bf5963"), 0, null, 300.1815389831510000m, "705a14db-0766-42fe-be95-bddb5db3829a", null, null, null, false, null, "Janie", "Aufderhar", false, null, "Janie.Aufderhar98", null, null, "AQAAAAEAACcQAAAAEFg9KR1iblQb7BcWLjlkE7CyWeIHtRnz7vwTI1usoEr9gpjVJNWacuoCTf1QnJLvPw==", null, false, null, null, 0, false, null },
                    { new Guid("09e536d1-50fd-453a-80d5-e8283f64b0da"), 0, new DateTime(1959, 7, 1, 4, 5, 23, 226, DateTimeKind.Local).AddTicks(4677), 74.99070368809320000m, "012fde54-5fad-4c08-959f-56826193e58e", null, null, null, false, "Sidney", "Sidney", "Anderson", false, null, "Sidney46", null, null, "AQAAAAEAACcQAAAAEPBz8EXqR+2omo4JVyqI+CcrOByGnaYjLCu/bFAZayoFf7dJl2wn9laXz4YJJYo3qA==", null, false, null, null, 1, false, null },
                    { new Guid("09ee89cc-9f4d-4eae-a4f3-731ca2d52102"), 0, new DateTime(1975, 7, 26, 3, 39, 17, 778, DateTimeKind.Local).AddTicks(8862), 865.4205484366780000m, "7f3c9c9e-3297-400c-8134-07808eb221a8", null, null, null, false, "Erica", "Erica", "Sporer", false, null, "Erica20", null, null, "AQAAAAEAACcQAAAAENvY3jw12N5XaTiykFeZixgtVANCFEGDSUO3hGZTTotVBwnYLj9b+Z/EAjQP/EsQ4Q==", null, false, null, null, 0, false, null },
                    { new Guid("09fe5fb4-f36b-4a46-81a1-c617e335393a"), 0, new DateTime(1973, 2, 1, 15, 5, 43, 571, DateTimeKind.Local).AddTicks(1946), 505.3642716883680000m, "be339e04-2955-4cf7-807a-203527bf09a0", null, null, null, false, null, "Lauren", "Murray", false, null, "Lauren13", null, null, "AQAAAAEAACcQAAAAEPCyMs/B/iUQdxi3xPgS8hfGT5nsVR1THadB3vL+pqCHSsohZ0DG1RbH2lDQpQ2MDw==", null, false, null, null, 0, false, null },
                    { new Guid("09ff0b03-eca3-4596-9c5d-d809a2f99a1e"), 0, new DateTime(1932, 4, 4, 21, 45, 35, 343, DateTimeKind.Local).AddTicks(3347), 948.921662253730000m, "6376c627-7a45-4d1e-8136-136380e12533", null, null, null, false, null, "Mary", "Collier", false, null, "Mary_Collier", null, null, "AQAAAAEAACcQAAAAEF7iPUGoH4/I7G2lHI8mWdlHRcbLg81qXENvahGxtwOZ9vC9aZKZePJdCI17goJjXQ==", null, false, null, null, 0, false, null },
                    { new Guid("0c162bb7-00a6-40b1-b35d-bbd2862f363c"), 0, new DateTime(1981, 3, 12, 23, 46, 5, 978, DateTimeKind.Local).AddTicks(244), 884.3029043078120000m, "247f6676-2b44-4120-ac17-d4a96f5790fd", null, null, null, false, null, "Alonzo", "Rau", false, null, "Alonzo49", null, null, "AQAAAAEAACcQAAAAEDQjOgh2nRg6bOT49Kj6VthAEE+ffWI/KBvAr0nFElV9vd6W9WveikIRjPf+j9SeAA==", null, false, null, null, 0, false, null },
                    { new Guid("0c210681-d608-4ef0-acaa-f6ca1d403524"), 0, null, 844.5493612740820000m, "1847d7c7-1e8a-4a80-85dc-3b63735f6dfa", null, null, null, false, null, "Israel", "Wolf", false, null, "Israel.Wolf42", null, null, "AQAAAAEAACcQAAAAENFtQVPZXioM0mSLYxQENzKCFlV0CFsowsSdo12uBXX3Kte3Z/U8wkgAIKgiLBSuTg==", null, false, null, null, 1, false, null },
                    { new Guid("0d9e85a0-24c2-4c10-b1f2-180d3ceeaaaf"), 0, new DateTime(1948, 7, 26, 3, 23, 39, 858, DateTimeKind.Local).AddTicks(9985), 970.7468427296580000m, "4c161ab1-3690-4c31-a4aa-2fbb1c36b4dc", null, null, null, false, "Frances", "Frances", "Hauck", false, null, "Frances_Hauck57", null, null, "AQAAAAEAACcQAAAAEB2Z7Bv8SQw5RoJotZWY9f+PLoxUJRsh63y1Y26yAow9ll0spzAJBKvz3X/592kn3Q==", null, false, null, null, 1, false, null },
                    { new Guid("0dce50e5-ef29-456b-ab6f-c4454c5cfc38"), 0, new DateTime(1970, 7, 25, 20, 55, 11, 944, DateTimeKind.Local).AddTicks(824), 379.9004984778590000m, "32fe3993-7c6d-494b-9518-b1f35a2a6462", null, null, null, false, null, "Orville", "Lubowitz", false, null, "Orville.Lubowitz", null, null, "AQAAAAEAACcQAAAAEK3ttHT+b6JWEaMxeLpt4P2gA8uiG/Bw1Pmnb8COxRKZClBLzRKohsUjY6PZycgmXQ==", null, false, null, null, 2, false, null },
                    { new Guid("0edec355-b022-4255-80d6-c530f687d26e"), 0, null, 641.9414062115970000m, "66cdcaf2-2f41-4ad9-9f0f-4b2c969ab5b6", null, null, null, false, null, "Bradley", "Hintz", false, null, "Bradley.Hintz96", null, null, "AQAAAAEAACcQAAAAEIwRzLFsqb7wPBmiL8xZdnyoTvs0tTzfHSvW0FmpVrCG9qicZ5OrK94iOpzo9TYL0A==", null, false, null, null, 0, false, null },
                    { new Guid("0fedadae-5c91-4999-9924-42f5fcd0de5b"), 0, null, 289.0879095294790000m, "8aec5f47-92a2-4248-bce4-efd4c4f1798b", null, null, null, false, "Elsa", "Elsa", "Raynor", false, null, "Elsa87", null, null, "AQAAAAEAACcQAAAAEFZom0SQVrNmRA2edNIQLq/lzig2IPo9PUet3FwhS2MzJvZgiKIJuIGiJnDfsh6YnA==", null, false, null, null, 1, false, null },
                    { new Guid("1070c404-0d57-4ba4-828e-4ca0d5ec2262"), 0, new DateTime(1976, 5, 25, 14, 21, 40, 930, DateTimeKind.Local).AddTicks(894), 18.99112113037880000m, "2fb14f27-24be-41e7-b3bc-3490186d163c", null, null, null, false, "Darrell", "Darrell", "Johnson", false, null, "Darrell31", null, null, "AQAAAAEAACcQAAAAEMkIF+SunUbMZm41NT2lW2nVm9rL/qqppjtk/CLEhhGayy4KZiDAPhYVqxg5IR124Q==", null, false, null, null, 2, false, null },
                    { new Guid("11b76a5d-870e-46d3-b3e3-0af0f8f871ac"), 0, null, 783.9507171208990000m, "3c2149b9-979c-446f-9cd2-59c0d82cf2b3", null, null, null, false, "Lance", "Lance", "Pollich", false, null, "Lance.Pollich", null, null, "AQAAAAEAACcQAAAAEDx4c45hkND+ImgbJFLFVouOWBrxWRxEe2lgmVUaB+1/O5BMsZPLd87QEEUrqVNMMg==", null, false, null, null, 2, false, null },
                    { new Guid("11e566bf-b29d-4651-8e8c-7f65a8281c80"), 0, null, 983.9963778120120000m, "44bbb8e4-1469-42e1-ab3d-012873f3bd10", null, null, null, false, "Mathew", "Mathew", "Emmerich", false, null, "Mathew.Emmerich", null, null, "AQAAAAEAACcQAAAAEC24n6LM72Ft2sllVGzBiGO5ndYtkFEX8Rc9rRdo3LLERZr1g9aMullUK6LY+MOfOQ==", null, false, null, null, 1, false, null },
                    { new Guid("1281e6c3-dc02-4e83-a90d-37f640411dfc"), 0, null, 260.694480319470000m, "dd3888eb-3b71-4210-aca9-1ffff76efe48", null, null, null, false, null, "Stephen", "Lueilwitz", false, null, "Stephen_Lueilwitz", null, null, "AQAAAAEAACcQAAAAEFpaPxIx1LdKn8w60kUI9mHLa7z3XFtVTl0rsPU2wivXrruneZSAxEg+oIQIb+0Xug==", null, false, null, null, 1, false, null },
                    { new Guid("12f12b30-ab20-433f-91c1-e6f9be859390"), 0, null, 987.6368961566290000m, "971d6dca-45dc-4b98-a6a1-b28995a48a2a", null, null, null, false, null, "Ruby", "Cronin", false, null, "Ruby.Cronin", null, null, "AQAAAAEAACcQAAAAEHcNHt7d+aQ9ESaP/hBg5v3DOgqKbyX3Uk+AYhDmgDztaToG7k8ODDC36D7AhkWFGA==", null, false, null, null, 0, false, null },
                    { new Guid("13164560-3eb6-4f4f-9c11-1f819fc48e22"), 0, new DateTime(1961, 2, 24, 19, 56, 23, 324, DateTimeKind.Local).AddTicks(3478), 389.2462973346830000m, "ce1dce86-1b85-4212-8068-dcd91ed2d036", null, null, null, false, null, "Garry", "Spinka", false, null, "Garry98", null, null, "AQAAAAEAACcQAAAAEJgaIkAN3NwnrfxJlQirqJmGomEvzErGwYXDpkJI/Cr+x+jFYe3JOedp+oQdhjXOmw==", null, false, null, null, 1, false, null },
                    { new Guid("143cf7ff-f2e3-444c-a15b-3aa7b4c43475"), 0, new DateTime(1947, 7, 21, 17, 30, 58, 255, DateTimeKind.Local).AddTicks(4112), 918.2252565684330000m, "a97f6703-1d1b-49ab-b166-d64f303134f6", null, null, null, false, "Donna", "Donna", "Lind", false, null, "Donna15", null, null, "AQAAAAEAACcQAAAAEPmaEfX2KEwvEC4/OaU/kGX3Iwpk76VUbE2jb89m8DWBx+gDSgKCrPIHwgTi3gTVKw==", null, false, null, null, 0, false, null },
                    { new Guid("1530b862-24b5-484d-8939-50315a49bd13"), 0, null, 215.7404238055840000m, "8570fed0-5a08-42be-885f-85ce77ff6382", null, null, null, false, "Oscar", "Oscar", "Bosco", false, null, "Oscar_Bosco", null, null, "AQAAAAEAACcQAAAAEDIpCTGHiJ8GAs9sqYrVQ56SOXRRrkHrMfaq8CneQCVgL93POQkSFv6/NuifOt3bVQ==", null, false, null, null, 0, false, null },
                    { new Guid("1548ab99-88de-44e5-8fb2-0ecadca929aa"), 0, new DateTime(2009, 2, 23, 6, 43, 48, 811, DateTimeKind.Local).AddTicks(8516), 2.661627012802370000m, "081b67d9-a555-414b-a59c-fe321f9e7a1b", null, null, null, false, null, "Jessie", "Rutherford", false, null, "Jessie16", null, null, "AQAAAAEAACcQAAAAECphbIfq7Xhbjiw8U/IYjRnmV0aXsrxOxd0YKk9VICeQ2BQFagk4WZ1+NPu+gI8GFg==", null, false, null, null, 1, false, null },
                    { new Guid("15a8aac9-d692-4882-990e-3e575587579f"), 0, new DateTime(1994, 10, 6, 10, 36, 8, 151, DateTimeKind.Local).AddTicks(8661), 99.88405409616320000m, "1d747b89-ad5f-4714-9956-f992aa39d4f3", null, null, null, false, null, "Kerry", "Stoltenberg", false, null, "Kerry.Stoltenberg", null, null, "AQAAAAEAACcQAAAAEOXa4bOIeMAlMrHcPje1vT0ICylAXXs/EiGzTuOELPmoaCwGbG4lvv7ogS1iDbUZ0Q==", null, false, null, null, 1, false, null },
                    { new Guid("17f01111-498c-4286-9021-ec1a09f4b1ca"), 0, new DateTime(1936, 3, 12, 17, 17, 5, 713, DateTimeKind.Local).AddTicks(303), 797.9786566789810000m, "a2c3e79f-e34f-4547-b2b6-9866d51e48b6", null, null, null, false, null, "Wilbur", "O'Keefe", false, null, "Wilbur4", null, null, "AQAAAAEAACcQAAAAED2TV3jXCqa3/8s4n8UvoFO4qKrn4R9MkjkBMdE//geEePPfKzL7QAoMamj8BLYM5A==", null, false, null, null, 2, false, null },
                    { new Guid("19d85480-882e-40f7-a536-84a552b3e447"), 0, null, 201.857103188020000m, "e8bb9265-1d3b-4981-bcb2-324d0f804c4b", null, null, null, false, null, "Brian", "Brakus", false, null, "Brian_Brakus", null, null, "AQAAAAEAACcQAAAAEL2rWWmcxLwpselmkJyJ5dF+l+K0Hb9dLPg2pXaUy+kMWaKurJ56Kmvf7g1yFhs0ig==", null, false, null, null, 0, false, null },
                    { new Guid("1be28f90-0b14-4642-99f4-d8dd65c3d9f8"), 0, new DateTime(1964, 1, 24, 0, 52, 39, 797, DateTimeKind.Local).AddTicks(3463), 313.1120935781890000m, "2ba0a9b2-e918-44c2-aa78-20f1e83a8b94", null, null, null, false, null, "Sarah", "Brekke", false, null, "Sarah.Brekke89", null, null, "AQAAAAEAACcQAAAAEMm/+5DA4wvzqSROkAMl+DI5nYaDyYt4I1uJ/e378uzCoVAeV28OXhPMPk7sixv/ww==", null, false, null, null, 1, false, null },
                    { new Guid("1de915db-ea78-41e7-a3a2-76a8f6311629"), 0, null, 147.2044585399460000m, "36d10530-5504-46e1-b6fe-b3a633762c6c", null, null, null, false, "Angel", "Angel", "Jast", false, null, "Angel_Jast", null, null, "AQAAAAEAACcQAAAAEPBFeIwNo9ffAMfbizHww7FDjPwAiv21QWDRFIa4mhabw+wUo6nGhvtSG+HsgSMoHQ==", null, false, null, null, 0, false, null },
                    { new Guid("1e75d073-445f-4291-b366-fe0683c205a7"), 0, null, 122.2454666389830000m, "ebe7513a-6d55-495a-9482-3af8b5f7ebe2", null, null, null, false, "Janie", "Janie", "Frami", false, null, "Janie.Frami", null, null, "AQAAAAEAACcQAAAAEHCHJ4SrViKCaMDUj3HBW5mP2OGIVAezQSE4wTY5twVvdPIofxriy2yIsOLgTzRsKw==", null, false, null, null, 0, false, null },
                    { new Guid("1fa36b53-f427-4c95-96d2-7c8a11050267"), 0, new DateTime(1935, 8, 11, 18, 49, 1, 462, DateTimeKind.Local).AddTicks(7726), 207.1448027194430000m, "fe804a3d-550b-4485-88d3-716446e329cf", null, null, null, false, null, "Gertrude", "Weber", false, null, "Gertrude31", null, null, "AQAAAAEAACcQAAAAEDLOhBY+I7qt1QKjqeZE08BIyKAKFDhwg1kp6so+9MzMZlDhKOxU0Aamz9yoXpgqTw==", null, false, null, null, 1, false, null },
                    { new Guid("1fda2339-4864-46e3-bf7d-81a520206ae9"), 0, new DateTime(1954, 2, 28, 15, 47, 20, 394, DateTimeKind.Local).AddTicks(4222), 331.8216856066520000m, "0a99a924-83ef-4934-b6e6-7171b51ecfab", null, null, null, false, "Warren", "Warren", "Kunze", false, null, "Warren.Kunze36", null, null, "AQAAAAEAACcQAAAAEG98RhSUj2YDqCq6iTRJHoyIBVHi13p/Bv8IdZP2/QaH+ZXvmRtlIdeW0YaMJFU7JQ==", null, false, null, null, 0, false, null },
                    { new Guid("20245acd-f749-41bb-8cfd-f436a4e71e96"), 0, new DateTime(1988, 7, 1, 8, 28, 57, 997, DateTimeKind.Local).AddTicks(7485), 911.6527917809770000m, "589ba3b9-95ce-468e-a8d6-d8e9339c8152", null, null, null, false, null, "Randolph", "Hegmann", false, null, "Randolph68", null, null, "AQAAAAEAACcQAAAAEAOZPn8PwIapvaVv4IVDKx0snfLfourF4deAW4A8xSILvOYnjijCtjrN5GILZckY4g==", null, false, null, null, 0, false, null },
                    { new Guid("2078228d-bb74-4e81-8e84-3dd4a76ea271"), 0, null, 228.8265235791380000m, "75f7778b-d4e7-4f8f-a7d7-03bfcde50dd0", null, null, null, false, "Heidi", "Heidi", "McLaughlin", false, null, "Heidi_McLaughlin47", null, null, "AQAAAAEAACcQAAAAECC2ksuLa/XG9domZC1z1ns/On1w0dSPaU/6v8ax7hg+Ce19ry7UsIqwrXpnbiO3vw==", null, false, null, null, 1, false, null },
                    { new Guid("21aa2202-92c4-4bb8-a2f8-9785eb49fe49"), 0, null, 556.070978767390000m, "59e1488f-38ef-46bd-8e2e-1bedbdcb3a67", null, null, null, false, null, "Joey", "Rowe", false, null, "Joey.Rowe34", null, null, "AQAAAAEAACcQAAAAEFixrAoMD9oWxcEYhQfxybVsVrnyFgLnoExCBaitLbQbSKavSCz53TxbU1JuT3q+oA==", null, false, null, null, 1, false, null },
                    { new Guid("2275ad3d-6816-4c2b-ba9c-96a3dc4f45fb"), 0, new DateTime(1955, 6, 7, 5, 59, 4, 644, DateTimeKind.Local).AddTicks(5709), 257.7744005044010000m, "38f4f2d3-a2b9-44b3-98b7-0a31bb8604f4", null, null, null, false, null, "Rachel", "Considine", false, null, "Rachel.Considine0", null, null, "AQAAAAEAACcQAAAAEL1MoUHrdDPcvKYZYXLJpx8X4hgU+qhr3o8SPjXXWLRrI8MQhYPhaCSQxkEOPBwKQQ==", null, false, null, null, 1, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "Email", "EmailConfirmed", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("2293afe4-2408-427c-9960-7223d1291070"), 0, new DateTime(1966, 8, 18, 16, 48, 8, 45, DateTimeKind.Local).AddTicks(2221), 742.546137403340000m, "9f076c96-6f40-4b5f-88f9-e88071425244", null, null, null, false, null, "Alfredo", "Deckow", false, null, "Alfredo85", null, null, "AQAAAAEAACcQAAAAEPMnSz2otrktTyRnkTELU4zS7AJFPVOSXQ1Wfrw7nSh1t5oYe/vKDZbUBC0YyG3Dww==", null, false, null, null, 1, false, null },
                    { new Guid("22a1446b-6ffd-488e-8e70-011276aa0ae3"), 0, new DateTime(1965, 12, 14, 18, 6, 43, 859, DateTimeKind.Local).AddTicks(5716), 6.589023438840270000m, "e4689cf6-4b38-42b8-967c-dde49b08ad72", null, null, null, false, null, "Lena", "Corkery", false, null, "Lena_Corkery82", null, null, "AQAAAAEAACcQAAAAEODb3CiLAN3cR35bkWo6ivD1VJVjVZ8SnuXnlQrGgH+br5Hq+jqwj+Tl0YgMeoA3PA==", null, false, null, null, 1, false, null },
                    { new Guid("23dc6e61-4215-4b56-b081-13cd0b456e6f"), 0, null, 967.9827420813630000m, "43ed2208-ff66-4439-ae7c-47dc521bfa3b", null, null, null, false, "Rafael", "Rafael", "Goyette", false, null, "Rafael.Goyette", null, null, "AQAAAAEAACcQAAAAEL28WKGuljyyzWO4P1m03n/7u1BzVZO//DABKmAhGBNR13qaSV3KygfbMDfOsuK4TQ==", null, false, null, null, 0, false, null },
                    { new Guid("243b9c2d-ab41-4ea2-b445-092baa8385bc"), 0, null, 176.7738460295830000m, "0e372659-1470-4bba-a026-21892037156e", null, null, null, false, null, "Kristen", "Murazik", false, null, "Kristen_Murazik91", null, null, "AQAAAAEAACcQAAAAEMQP+kwXYi3btskmrGm3VIhz5cW0Mle7/PGcT/vosJwb2z42zoQLC/c4SwBuaJ27Kg==", null, false, null, null, 1, false, null },
                    { new Guid("25a38376-e74c-46cc-8d4f-292cebbcdffb"), 0, null, 107.7713915305860000m, "53d30769-6dc3-46fa-b16b-9eab17656752", null, null, null, false, "Cindy", "Cindy", "West", false, null, "Cindy_West", null, null, "AQAAAAEAACcQAAAAELHr9mdov2HKWoLEo8QKvEQiNLQTkcWbeF7o8SYfluj1bnCa6Wj5UL2QZlSE+lbSOg==", null, false, null, null, 1, false, null },
                    { new Guid("27f9e909-39f0-43df-afb3-3bc130e8da06"), 0, new DateTime(1929, 10, 27, 5, 23, 11, 390, DateTimeKind.Local).AddTicks(5628), 898.1327708943720000m, "fafc0dff-5daa-4e92-90e8-9ec3b07555e7", null, null, null, false, "Krystal", "Krystal", "Mueller", false, null, "Krystal.Mueller94", null, null, "AQAAAAEAACcQAAAAEB7+T2jcYrM5EpTvPc8jar//eNS5HbczuHqn90wmRD6QfbLruwpYKK4tRrDmULOoDw==", null, false, null, null, 1, false, null },
                    { new Guid("28ab8e57-b296-4656-9877-df7be64ecc51"), 0, new DateTime(1977, 9, 23, 0, 38, 53, 907, DateTimeKind.Local).AddTicks(3928), 431.6370198393170000m, "85d17bd3-7a45-47da-8c7c-c210d3126709", null, null, null, false, "Jessie", "Jessie", "Mayer", false, null, "Jessie58", null, null, "AQAAAAEAACcQAAAAEHghJpblw3jsLGeQI362UsGcKdyi5qNmmimN/oy/YidISmkS39vXmeOdX3Ug3BJqHg==", null, false, null, null, 0, false, null },
                    { new Guid("2956754d-e1ca-4623-bbe4-691ff14c9d29"), 0, new DateTime(1968, 8, 20, 14, 27, 27, 252, DateTimeKind.Local).AddTicks(6018), 835.5684714499650000m, "fc7cfd4d-97b8-4ec1-becb-73123e53addd", null, null, null, false, null, "Marian", "Reichel", false, null, "Marian.Reichel45", null, null, "AQAAAAEAACcQAAAAENtaQ6NeLajrJu2+cUaTo6AP3hcsD/4v2Zr0SMzQldvNE04+aM/4K6hK40LUo77ruA==", null, false, null, null, 1, false, null },
                    { new Guid("29c7fc41-2565-497d-8900-56c2e6208fa6"), 0, null, 2.309389858411780000m, "0518bba0-6b66-4226-87cb-034c9ef7758c", null, null, null, false, "Janis", "Janis", "Miller", false, null, "Janis.Miller", null, null, "AQAAAAEAACcQAAAAENVRPigMFO0VXzOwb+EoDyPlAZaTkvdR/yimuHiRLj95eDd+v49OTVui4Ycu5QrMJQ==", null, false, null, null, 0, false, null },
                    { new Guid("2a79982f-f343-4569-a725-228ecab03718"), 0, new DateTime(1944, 9, 28, 23, 1, 46, 684, DateTimeKind.Local).AddTicks(816), 833.2689186624240000m, "4f23071b-fb02-4f47-8f41-c2133d2a7558", null, null, null, false, null, "Terence", "Beahan", false, null, "Terence.Beahan", null, null, "AQAAAAEAACcQAAAAEC8rNOD0C5diRbtawQgCcETqc3SJEBHbwmVwVRPY9EfsBhsLSc36WqfQ5iW4/jqtww==", null, false, null, null, 1, false, null },
                    { new Guid("2b62c42e-4571-4d98-bd8d-7ba20ea3e48b"), 0, new DateTime(1943, 8, 18, 2, 20, 10, 542, DateTimeKind.Local).AddTicks(2837), 109.3468727795930000m, "5902e210-db36-4c29-af0f-5cfcbdbe19f4", null, null, null, false, null, "Lyle", "Mueller", false, null, "Lyle.Mueller", null, null, "AQAAAAEAACcQAAAAEO8Lu30UzF+91Gu7X6S51BYrfwWT5XO/joFgM25kg2Nu+tI6lyacTXXhgz+VN8KjoQ==", null, false, null, null, 1, false, null },
                    { new Guid("2c5320bb-6c0a-46cc-9731-a7b34514e4c1"), 0, new DateTime(1988, 8, 16, 8, 30, 50, 951, DateTimeKind.Local).AddTicks(5580), 116.9352190429220000m, "733ba473-eb91-4bba-9be7-63b8d465d119", null, null, null, false, null, "Ethel", "Gusikowski", false, null, "Ethel.Gusikowski73", null, null, "AQAAAAEAACcQAAAAEG/jfs2cVeC+I+i2kcb1q31tOz8yzN/CFBfY85dF8Ovc12ay2Q6QvTc7pJ+6ttQRXQ==", null, false, null, null, 0, false, null },
                    { new Guid("2d52a2a2-27d8-49a4-9ce6-969bb0f68fa2"), 0, null, 769.7271650074090000m, "77747a40-4fc3-4c25-9002-47b31e586e23", null, null, null, false, "Benjamin", "Benjamin", "Leffler", false, null, "Benjamin.Leffler", null, null, "AQAAAAEAACcQAAAAEE3Vp4RS4A/DXc7aI1EECH6Z72pJcLzLd+3cjpTyvI1/OhUzD1F9fA577ExZlyUHag==", null, false, null, null, 0, false, null },
                    { new Guid("2effe328-1bb8-4f90-8e5e-a133fd94d1df"), 0, null, 13.05309678453870000m, "24ddf8a9-215c-4829-8026-aabd10f987bf", null, null, null, false, "Eunice", "Eunice", "Durgan", false, null, "Eunice81", null, null, "AQAAAAEAACcQAAAAENuAjwaHQNAYNy6Pu3rbrFN0TeKEIwsjPFtZ1Kh3VYi0v6XMhG99fN0ynmySgME9WA==", null, false, null, null, 2, false, null },
                    { new Guid("2f3d1b8f-7590-4d18-9002-4caa22511a8b"), 0, null, 686.244218981610000m, "01836ece-aff7-4f65-a185-eeed8d99bccd", null, null, null, false, "Debra", "Debra", "Ankunding", false, null, "Debra17", null, null, "AQAAAAEAACcQAAAAEJn45b5GcpWYDb64pMFb3gNQ2qRWPymwTr7gsqUjfdtcN7eEoKA7QINFtQ1Hnq5dhg==", null, false, null, null, 1, false, null },
                    { new Guid("3327a162-c88c-4952-9e00-d3c7118fb9f5"), 0, null, 996.776389325670000m, "e38cf24b-97f0-4416-b3d6-c976b8ad8bb2", null, null, null, false, null, "Joanna", "Maggio", false, null, "Joanna.Maggio", null, null, "AQAAAAEAACcQAAAAEApPKarMqZfh0Cmgoqfomg23DM/PM4EJZ+/XptvkQt5Xq4UPFHWHaC4aqyu0408q7A==", null, false, null, null, 2, false, null },
                    { new Guid("3359f4d4-fbc1-4174-b3e0-8cc3754ac07b"), 0, new DateTime(1953, 9, 9, 21, 13, 48, 717, DateTimeKind.Local).AddTicks(8587), 87.89725793117720000m, "96b4daf5-ac97-477c-8271-0970a34749b9", null, null, null, false, "Eddie", "Eddie", "Veum", false, null, "Eddie5", null, null, "AQAAAAEAACcQAAAAEHqjWzDHCU5UKTIIFW16aJm9VnNyqXl7EOQQf3yVtsMrFzUMZc7MDCgF+ubsqf4rvA==", null, false, null, null, 1, false, null },
                    { new Guid("34abae3b-f28c-4c59-a716-fea9a1b0e1bb"), 0, new DateTime(2006, 10, 19, 6, 29, 52, 66, DateTimeKind.Local).AddTicks(9865), 164.7612098047480000m, "766f4f89-408a-4da0-a6a9-b81d472e877a", null, null, null, false, "Phil", "Phil", "Johnson", false, null, "Phil20", null, null, "AQAAAAEAACcQAAAAEG/37eMRJJf+L00fzIM9qmwSUzdwQY7haGmFGrwYu3KqvnYgYvUamj1hUAonUR0UcQ==", null, false, null, null, 1, false, null },
                    { new Guid("34c24f57-b16e-4b0f-abe2-5cb9c260e918"), 0, new DateTime(1973, 10, 14, 0, 56, 28, 519, DateTimeKind.Local).AddTicks(2353), 150.9666941149540000m, "51bc2d0c-50e5-4d91-9e2d-8f69f792bb27", null, null, null, false, "Caroline", "Caroline", "Renner", false, null, "Caroline69", null, null, "AQAAAAEAACcQAAAAEE+n8KAMsURLETnn+h+mQmMH201ah0C0nGOxe8+L38EHErvVUxbhejAdKiquon6MLQ==", null, false, null, null, 1, false, null },
                    { new Guid("351d8ea5-1894-4ffb-9d93-a257287acb66"), 0, new DateTime(1938, 10, 18, 19, 30, 38, 243, DateTimeKind.Local).AddTicks(8553), 691.8799696261140000m, "0d38ebed-5c8c-44ca-bf69-f69b3bfc60ab", null, null, null, false, "Frankie", "Frankie", "Christiansen", false, null, "Frankie53", null, null, "AQAAAAEAACcQAAAAEMhJrPBPLlPC9OaIQ1KOWODfkUVf6t7KdqW+4P/IXaaqMiAQM23IKhz8ho5b1hwu8g==", null, false, null, null, 2, false, null },
                    { new Guid("36afa758-a0b9-4345-9bce-db873a3c22fd"), 0, new DateTime(1979, 4, 27, 8, 1, 30, 11, DateTimeKind.Local).AddTicks(4999), 525.9726390573020000m, "a6497e26-50ad-44ed-af7b-780d73251312", null, null, null, false, null, "Belinda", "Morar", false, null, "Belinda2", null, null, "AQAAAAEAACcQAAAAEPrPMEQBSV+mRdDDCDbrVl0i6zeH1jPEyCfdn7oBEEg2HsT0dxmHGXSx1VPcYuA/9g==", null, false, null, null, 0, false, null },
                    { new Guid("371bed01-75b2-47b9-9535-3156b9a4c959"), 0, null, 302.3550360738020000m, "c2558817-1a3d-4040-b3d4-c372a9bd75ac", null, null, null, false, "Oscar", "Oscar", "Dietrich", false, null, "Oscar_Dietrich40", null, null, "AQAAAAEAACcQAAAAEEQOYz6TTonbbT/pJnvxgAvq02XwrDoNasqpaMMuz+mPxHcuB5LF9PA4kesircOzSQ==", null, false, null, null, 1, false, null },
                    { new Guid("37e41091-f10f-4b14-b68d-be058cea2e03"), 0, new DateTime(1944, 2, 24, 7, 53, 10, 401, DateTimeKind.Local).AddTicks(9797), 31.51355592894190000m, "745f8ca7-62bb-4b4a-ade0-8ed208026d0b", null, null, null, false, "Leigh", "Leigh", "Nitzsche", false, null, "Leigh34", null, null, "AQAAAAEAACcQAAAAEOZaVu3qXqMSoW/ePDak8ucqQ8Oo9Icy+lUzI/V4i+lRRAiq9lgJKfRN2/u2CT19Cg==", null, false, null, null, 1, false, null },
                    { new Guid("37f65b1e-268a-4a07-9f55-107b4df3c700"), 0, new DateTime(1949, 11, 11, 13, 7, 38, 142, DateTimeKind.Local).AddTicks(1543), 778.4235623434870000m, "95b90b7e-5639-49d3-a2f4-5505b1dc5fc2", null, null, null, false, null, "Cornelius", "Bashirian", false, null, "Cornelius.Bashirian87", null, null, "AQAAAAEAACcQAAAAENT/0KthMj2UtCIneeMdjpaxMbdelRPuBF8X67ElstXAOhMhpf6ZKSklBRA7n1M4jA==", null, false, null, null, 2, false, null },
                    { new Guid("39fc9708-01f3-4ab0-8c26-d5bc00da55db"), 0, null, 751.9621860313990000m, "e1cc87c3-b1eb-424d-804f-59c65ad76ef8", null, null, null, false, null, "Christie", "Braun", false, null, "Christie.Braun", null, null, "AQAAAAEAACcQAAAAELlhXQ2BkbRQ4WsTwTksg9kw7Sg6tNf0upv6v2by0USylGTNPZ3ql/8xpuIO30n4lQ==", null, false, null, null, 0, false, null },
                    { new Guid("3af6d087-276b-42a2-9c69-d7501840f5a1"), 0, null, 448.0778074859570000m, "8f89c9c8-80fd-49cd-9606-0c65106cec02", null, null, null, false, "Ismael", "Ismael", "Lind", false, null, "Ismael53", null, null, "AQAAAAEAACcQAAAAEBLLDQWjhXzKAHoKKpjgxL1ORAoe//FqhwXsG/hOZCjlPSuyKibFXDEHImrTMIqhww==", null, false, null, null, 0, false, null },
                    { new Guid("3b1108de-e27d-4674-b7ff-c1df3b68ae41"), 0, null, 52.44045312165080000m, "a911ad9d-9fc1-4809-b817-4e68606c4505", null, null, null, false, "Frank", "Frank", "Cremin", false, null, "Frank0", null, null, "AQAAAAEAACcQAAAAEGlzHryLIOeC0JMZDQayDHyAEBnW0jylGdbVuDHap5PhliXSbC8Bl2jWcU4EwshU/g==", null, false, null, null, 1, false, null },
                    { new Guid("3dc0198e-db0e-4b52-919e-c407fa4dc4a6"), 0, new DateTime(1992, 4, 13, 12, 32, 14, 161, DateTimeKind.Local).AddTicks(3060), 362.569909732930000m, "fdc33c60-a4c8-4c03-be19-457f160653ef", null, null, null, false, null, "Natalie", "Bernier", false, null, "Natalie_Bernier78", null, null, "AQAAAAEAACcQAAAAEKyG4UDDpZfHUM+/UY2FWZ7CoCJ/0PGGVZHWiyKwQBWseWEaGNFwKPje7iCpAD3cOQ==", null, false, null, null, 2, false, null },
                    { new Guid("40c86360-842c-49f4-a03e-2506f27e244d"), 0, null, 749.1817670924740000m, "7245977f-f85a-4b8e-973f-c5785a3830c3", null, null, null, false, "Pauline", "Pauline", "Weimann", false, null, "Pauline.Weimann", null, null, "AQAAAAEAACcQAAAAEFRZ9lUAqout8UYStufjhKe8W6S96AdWJenNCt1kWiKeWhFf48YAwgsRr2Tu8q+JUA==", null, false, null, null, 1, false, null },
                    { new Guid("40de2c6f-e29d-4027-93c3-945e76ec015c"), 0, new DateTime(1984, 7, 11, 4, 27, 4, 936, DateTimeKind.Local).AddTicks(2510), 362.5091789753340000m, "98b1248b-473d-4527-8205-a2874752508d", null, null, null, false, "Lloyd", "Lloyd", "Gottlieb", false, null, "Lloyd98", null, null, "AQAAAAEAACcQAAAAEJrrBjHymgrdMis7FEVAjH2EG32gCenEc8lLm75thp/HEefpu962sgk+IPqJ/hRmCg==", null, false, null, null, 2, false, null },
                    { new Guid("41e507fd-f435-49b8-a35c-9fba98848542"), 0, null, 899.1715235784780000m, "cedfb4f7-0116-4c40-b118-53aa8c91170f", null, null, null, false, "Tomas", "Tomas", "Brekke", false, null, "Tomas.Brekke", null, null, "AQAAAAEAACcQAAAAEK/Glc5rJHTdT3YK1Bs5rAPD5hYxNN+yVhUlFve4VmfxnMxLU4FUp5u4i9oZ0Am5Nw==", null, false, null, null, 2, false, null },
                    { new Guid("428063f6-fd3a-42bd-b0be-ba01a5e85a84"), 0, new DateTime(2009, 3, 8, 6, 36, 15, 734, DateTimeKind.Local).AddTicks(2771), 392.3590926735720000m, "d584212c-f89c-44e7-8397-94076ab049dd", null, null, null, false, "Lori", "Lori", "Kuphal", false, null, "Lori.Kuphal3", null, null, "AQAAAAEAACcQAAAAELBWgSqSdw1WpA4s//iS12jK+jNBZrrBONiA2LXuEqFXkKN31JfRAaq879D8xWSINQ==", null, false, null, null, 2, false, null },
                    { new Guid("4527938d-6c0c-424e-8f7a-6d20b4f7a9f0"), 0, null, 178.7722672091520000m, "1cf7aa4b-c5ac-46df-9e21-c835072f7391", null, null, null, false, "Kim", "Kim", "Ondricka", false, null, "Kim.Ondricka63", null, null, "AQAAAAEAACcQAAAAEIeFSap3ht1FaYrBlOmEU21I4B3RmzSn9fD9oXe/0KzIW13T+9RdSaMuoN5pkPQGhw==", null, false, null, null, 2, false, null },
                    { new Guid("4595bfbb-3a7d-407e-b6e6-b5d06b0ded5d"), 0, null, 660.8241557250930000m, "3778cf63-430a-46ae-9046-041169e47bc7", null, null, null, false, "Roberto", "Roberto", "Schmidt", false, null, "Roberto_Schmidt", null, null, "AQAAAAEAACcQAAAAEAOOHAraH6tKGMBaqFg8uDKTPkF000eM9oT0+ue6i1/Y3GXNupm/OfUIU/136Fx+oA==", null, false, null, null, 2, false, null },
                    { new Guid("479adb19-03b9-482c-b165-7766492bfdf2"), 0, new DateTime(1955, 7, 16, 7, 49, 25, 791, DateTimeKind.Local).AddTicks(9041), 973.499136268370000m, "392c9220-8597-40a0-ad82-0c540c0e6ffd", null, null, null, false, "Guadalupe", "Guadalupe", "Rippin", false, null, "Guadalupe_Rippin", null, null, "AQAAAAEAACcQAAAAEAQdvj5kWDfBIkJxG2zHS3exQb+MHununGMxUnW0TKWyj2aiqbs0zHjyfpz1Pr3Hpw==", null, false, null, null, 2, false, null },
                    { new Guid("49e9f216-cefc-4a4e-a243-81e78152afb7"), 0, new DateTime(1996, 9, 7, 1, 52, 1, 251, DateTimeKind.Local).AddTicks(1487), 98.59943117682690000m, "b6cab664-8778-4f6d-93be-1289512e5b60", null, null, null, false, null, "Jay", "Gislason", false, null, "Jay_Gislason", null, null, "AQAAAAEAACcQAAAAEHnkOCbd6rN75D2gtTK3RxDoufxw6ffkl0qQXB1cbyj+WTM3ESjd25TT63qiLKVcpQ==", null, false, null, null, 0, false, null },
                    { new Guid("4a1c10a8-7cf3-42b7-9d73-0683e4bc1868"), 0, null, 597.5768499901340000m, "16edcc9c-96bb-4589-b219-ba2cb4ba1f0a", null, null, null, false, null, "Lois", "Bernhard", false, null, "Lois_Bernhard48", null, null, "AQAAAAEAACcQAAAAECpE4ztdwYpbmO938Mu1k7s8PusRqwQkf6c2rOkxHh5gctfiJb3zH9JFZ1vgSYk+0Q==", null, false, null, null, 2, false, null },
                    { new Guid("4a3be526-6584-46c8-8a1d-041160609d8b"), 0, new DateTime(1985, 8, 23, 16, 15, 38, 703, DateTimeKind.Local).AddTicks(1534), 242.7941253220110000m, "ec3c438a-f35e-4363-a2f0-b65dfdc73886", null, null, null, false, "Mamie", "Mamie", "Doyle", false, null, "Mamie_Doyle88", null, null, "AQAAAAEAACcQAAAAEEK6+N5ny2px5K+0mD4a7QMRrTxf2ryrlu5WyUewLvA0Bw8nPV6vRvx6qMpNl5pDeg==", null, false, null, null, 1, false, null },
                    { new Guid("4a66fea0-71b8-4943-90c9-d349550e6fe9"), 0, null, 43.59003135862720000m, "d9f05778-3356-4fa4-a068-fbcd67bfaec0", null, null, null, false, "Kent", "Kent", "Gislason", false, null, "Kent_Gislason10", null, null, "AQAAAAEAACcQAAAAEKWKPOcUyIPZoxF8YX9jFP7lKXSPdpE7TwndcLJ3y+z39MkAet/5+2ybov1hDqQ0aA==", null, false, null, null, 1, false, null },
                    { new Guid("4af3e803-6a3d-43c8-9c77-811cb6207644"), 0, null, 75.04604093804110000m, "db410147-8194-40c4-aa1d-1bba71b1fb9b", null, null, null, false, null, "Ora", "Mueller", false, null, "Ora.Mueller", null, null, "AQAAAAEAACcQAAAAEDGT2uNYGIXnpL2gsNOToNQ0aX46hKZ3lHxYGZDgDbbcZv0ICmP7/WBdH/W9xarwXg==", null, false, null, null, 1, false, null },
                    { new Guid("4b70366e-a511-4254-8c8d-ad820ee7b210"), 0, null, 372.4367806649840000m, "c9abbe82-6adc-4239-8278-94c052a43bfe", null, null, null, false, "Dianne", "Dianne", "Flatley", false, null, "Dianne.Flatley", null, null, "AQAAAAEAACcQAAAAEGnWCW62BdNdDavebtGJ3wDCMKaZMCodiQGU+rJTSFuOmVDjuEqq0EL22ku2DzLSOQ==", null, false, null, null, 2, false, null },
                    { new Guid("4dd327b9-6a6d-48c5-bd5c-c99248206229"), 0, new DateTime(1994, 9, 11, 2, 59, 31, 165, DateTimeKind.Local).AddTicks(2581), 146.1973550672790000m, "eeeef949-7ecd-4cb3-a877-f8306cb4ba23", null, null, null, false, null, "Marianne", "Lindgren", false, null, "Marianne97", null, null, "AQAAAAEAACcQAAAAEBdLX0ejPkA5q9acuv4c3qrITGZ0I4sNxSwEJ1eH8GJkzOlW+hLnjlD4nxGWKlw0mg==", null, false, null, null, 2, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "Email", "EmailConfirmed", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("4e8f092d-b1e1-47d3-9de6-5d9db26187a5"), 0, null, 62.61840083599720000m, "723855b8-6f09-4321-a5c9-97335f70c099", null, null, null, false, "Calvin", "Calvin", "Feest", false, null, "Calvin18", null, null, "AQAAAAEAACcQAAAAEDM6MlX/tY5nwTDngqYTl/qlUZXnm9Y/6tGVO5KnnS+sIGlplSSv3UWP0u8yhv7qnw==", null, false, null, null, 1, false, null },
                    { new Guid("4f1ac364-cc01-4a40-a229-d66da5446413"), 0, new DateTime(1937, 3, 18, 10, 9, 19, 819, DateTimeKind.Local).AddTicks(6665), 634.0682636694490000m, "c19f68c2-725c-4950-8647-bed219be1c83", null, null, null, false, "Gwendolyn", "Gwendolyn", "Schmidt", false, null, "Gwendolyn_Schmidt", null, null, "AQAAAAEAACcQAAAAEJ78EnWxSnLAp1W9+TFq/YKChDlPlscrzhsTl2CG8oKtM3Ks72spo7vgVCsIQxJM0w==", null, false, null, null, 2, false, null },
                    { new Guid("4f750333-43c7-4b6d-871b-3959dea7a14e"), 0, new DateTime(1928, 11, 11, 0, 55, 48, 631, DateTimeKind.Local).AddTicks(2864), 417.6577662601220000m, "231352d4-0b9a-445c-8164-f6bd1ed94c9f", null, null, null, false, "Damon", "Damon", "Hagenes", false, null, "Damon_Hagenes", null, null, "AQAAAAEAACcQAAAAEPoxrevt66TiBImj/wkhnWX3gGHFD/PxnEOzgGJGmeeMJoJ+khIY5XsDiM5sXRjxbw==", null, false, null, null, 0, false, null },
                    { new Guid("4f7cd1ca-72e9-46bd-ab1e-ae8fa37d21a4"), 0, null, 369.3653111978150000m, "2232c247-48cc-4e05-bd6b-3055cc02083b", null, null, null, false, "Miguel", "Miguel", "Schaefer", false, null, "Miguel.Schaefer8", null, null, "AQAAAAEAACcQAAAAEMgwTOuUdzscUjsU99PM/d6Ud8qQIUjzf1vgjsc7TV7FJxMDB4P0BsStWMcpKL1BjA==", null, false, null, null, 0, false, null },
                    { new Guid("500d7059-5719-42c4-a15e-d4753ba03714"), 0, null, 565.5686317452270000m, "9b1d943c-5e0a-4015-b6ca-84db100dcac4", null, null, null, false, null, "Virgil", "Kiehn", false, null, "Virgil.Kiehn59", null, null, "AQAAAAEAACcQAAAAEA+2XhzZJtHDETs5oXMAhammflnumjgdtW4gMiKD0lkHx0jP3N1apJqqrOVlN/WChA==", null, false, null, null, 1, false, null },
                    { new Guid("5146be01-925a-447f-b871-b7de98b487df"), 0, null, 67.3149243957510000m, "e5e2abd2-f439-4730-a70e-278522cce974", null, null, null, false, null, "Troy", "Beer", false, null, "Troy28", null, null, "AQAAAAEAACcQAAAAEMyrmbRcHqSOvyBy7QVkrAiAvB66kDNGbte0vBB/1jI7qEXSzSIOGyyk06+83cP58Q==", null, false, null, null, 2, false, null },
                    { new Guid("5210b0bd-a591-4887-9abb-0f4415c0f467"), 0, new DateTime(1996, 6, 30, 19, 56, 42, 23, DateTimeKind.Local).AddTicks(6983), 408.888224110030000m, "c0a3f05e-80e4-48c7-ac29-56e0324f868d", null, null, null, false, "Brett", "Brett", "Hermann", false, null, "Brett66", null, null, "AQAAAAEAACcQAAAAEFbPRX7sP3AN8gXxrD5wJmGqPphSWSQo4cq56POcSfrNU/kS5ssIavrBKyaDO+Nv4g==", null, false, null, null, 2, false, null },
                    { new Guid("52fe76ad-4c09-4b99-9385-e407990c0307"), 0, null, 247.8959189182690000m, "613a1533-49d4-48bc-8604-d5fef73abc23", null, null, null, false, null, "Timmy", "Sauer", false, null, "Timmy_Sauer", null, null, "AQAAAAEAACcQAAAAENNZRfY6IeCbBJ6d8p3zBTdRNGa7iKvFvQtEM6slVWmMTHr9OsdoP8cAbEMYlWruGg==", null, false, null, null, 1, false, null },
                    { new Guid("5322c711-eaf5-4b14-8d69-cc6bf8809924"), 0, null, 973.4082497605740000m, "dd394112-106d-4c4b-a020-4ede0ebbbb29", null, null, null, false, null, "Dana", "Considine", false, null, "Dana40", null, null, "AQAAAAEAACcQAAAAEFTXFBQem7ZC54RKc+y/v1jqTPxAaZtUMKBrtrboRhkeh/Ii2XfUWErcIOphTkfeTw==", null, false, null, null, 1, false, null },
                    { new Guid("5398a079-6d82-4f82-8917-3f9eea9310eb"), 0, null, 133.9101692401640000m, "745d6f9e-b007-4700-8ed7-8c6814c7ce92", null, null, null, false, null, "Roman", "Gaylord", false, null, "Roman.Gaylord", null, null, "AQAAAAEAACcQAAAAEL4F9PMS7OqLR4/8eS22mgOdvmhpqkO7qHyhuL02ChoeaBtN1RpxjwGI4wsSvZnjjw==", null, false, null, null, 2, false, null },
                    { new Guid("53d8997e-27d6-4129-b5f1-0072e7f179bf"), 0, new DateTime(1958, 12, 8, 3, 40, 49, 71, DateTimeKind.Local).AddTicks(7526), 876.5030466915270000m, "54a68bb8-ca08-4ec1-90ed-5aa0133da4be", null, null, null, false, "Spencer", "Spencer", "Ullrich", false, null, "Spencer_Ullrich", null, null, "AQAAAAEAACcQAAAAEJFKOew75Qewo6uxzDdsJhGf0D1saXoRM1iaA0CirhVupxpduZeDh5cheh15ILVqPg==", null, false, null, null, 2, false, null },
                    { new Guid("54f16999-7e05-407e-aab8-1c56cdb79653"), 0, null, 618.1297959735780000m, "1e4d1869-13b9-4d24-afab-eb5d10e362bc", null, null, null, false, null, "Christie", "Zemlak", false, null, "Christie.Zemlak30", null, null, "AQAAAAEAACcQAAAAEBIgI38UXNOa/+C93gOHYrac5HhWq3/BeMT/Grw7DBcOige1BYii8E8mOV9ZwhwCqQ==", null, false, null, null, 2, false, null },
                    { new Guid("56460594-4f75-42d8-9106-e7e3ec02c12c"), 0, null, 181.0661392514520000m, "fe9174f4-4841-4a23-800f-8fdc345473a3", null, null, null, false, "Glen", "Glen", "Bins", false, null, "Glen.Bins97", null, null, "AQAAAAEAACcQAAAAEIbLDZ2ZT6zR53vNqrqGqSgnVtOJ5Qqqvidod9LrX67k2UDz9xQCsw3sXxn1Fkj7rg==", null, false, null, null, 0, false, null },
                    { new Guid("56780bb1-6c9e-4f24-a024-e244137c0516"), 0, null, 376.9408555266430000m, "4ab079e8-c753-4093-b2e1-95682bb7f3a2", null, null, null, false, "Christian", "Christian", "Barton", false, null, "Christian.Barton45", null, null, "AQAAAAEAACcQAAAAELwwnZcFbSAX2ttjHUzCYpxBJ2OrYRprkfG4vB5q8ARO1J+pI660Tnc2lvTnJ4rf+g==", null, false, null, null, 1, false, null },
                    { new Guid("57c213e6-163e-4134-8633-29615daff79d"), 0, null, 154.3878019035650000m, "6c482bd2-ceb5-4825-8c51-5edd88d5dadb", null, null, null, false, null, "Theodore", "Cummings", false, null, "Theodore.Cummings43", null, null, "AQAAAAEAACcQAAAAEOyCtoCiYKwIpJh63tAz5yLX+awPK2U5MNVAItmB3u6gqo93DcK4rH7v2h+3RpzpWA==", null, false, null, null, 2, false, null },
                    { new Guid("5881d0e1-89ce-4573-8217-2e4c8ee1688e"), 0, null, 660.317328208780000m, "a2fe0101-8884-4ee8-8f64-d6e13802133d", null, null, null, false, null, "Ada", "Beier", false, null, "Ada.Beier39", null, null, "AQAAAAEAACcQAAAAEPnhNWuqUPSlDGso1+kpwooQCpbRlUxpHSO7DbkNSZN5XwHdpTbesjSFeP9pSlpWyg==", null, false, null, null, 1, false, null },
                    { new Guid("58e47d27-16f3-4806-acf1-7b73ccbc0d5e"), 0, new DateTime(1953, 1, 17, 15, 56, 15, 675, DateTimeKind.Local).AddTicks(9701), 261.4368253085520000m, "41a3a1bc-37d6-4d5b-af37-b358e5caf195", null, null, null, false, null, "Dean", "Upton", false, null, "Dean_Upton", null, null, "AQAAAAEAACcQAAAAEOiHSYm2wyRfnaCPhvgCKmTjXD6ajFFosnpAjQi4GYsnon8AJxYK0xrngieZQVlVLA==", null, false, null, null, 1, false, null },
                    { new Guid("59e5a95d-f3ce-47fe-a7c9-70a6b47faac1"), 0, null, 190.6061085363650000m, "d2337113-6a61-4861-a019-733166f71d21", null, null, null, false, null, "Lila", "Willms", false, null, "Lila.Willms", null, null, "AQAAAAEAACcQAAAAEA89awQqNwz1ag3Ok2yfExX8OkY6BXyzv7GbdEWHt61k8V0QIAWzvZG3OA1Sw7NILw==", null, false, null, null, 0, false, null },
                    { new Guid("5af211a7-f736-4b52-b2bb-493388054061"), 0, null, 885.7928886086310000m, "6b4be96a-180d-4432-967e-e17fa9fe5407", null, null, null, false, null, "Bridget", "Schiller", false, null, "Bridget6", null, null, "AQAAAAEAACcQAAAAEO9oH34sNPY2uF0pLNVe2cxfW6KtKeB6zvd+OWTcJA29uetzAe9cQM6gN2irVJULUQ==", null, false, null, null, 0, false, null },
                    { new Guid("5c53533c-cf33-43f0-bdab-260275d90d88"), 0, null, 728.2789208736230000m, "dada1c9f-93e5-4687-993b-1a237c7a3c0d", null, null, null, false, "Debra", "Debra", "Lehner", false, null, "Debra.Lehner", null, null, "AQAAAAEAACcQAAAAEJaksMaljGI2YEMSUdzHbhfW3CNmEe8rBzLTVnZ1LJgt0Y2GhUQ5T4tkzM3z1Jg9+g==", null, false, null, null, 2, false, null },
                    { new Guid("5d61541c-3ac1-459c-b0d4-0bbe121306da"), 0, null, 855.4688333672150000m, "adffbfbd-3f5b-474b-af6f-58232559dfd5", null, null, null, false, null, "Leroy", "Larkin", false, null, "Leroy.Larkin61", null, null, "AQAAAAEAACcQAAAAEMSDKEVeLqwj/WMSjUq3SKgbAPjXGy2ucDE4Zjq3VPanP6j4FLZL9FZ2fJZ78IYqAA==", null, false, null, null, 2, false, null },
                    { new Guid("5dd3e047-c6f3-412d-b5cb-12b416f99706"), 0, null, 308.0825056733870000m, "8bbe43d9-88c6-46c4-a103-db526a05df8e", null, null, null, false, "Tracey", "Tracey", "Wunsch", false, null, "Tracey_Wunsch", null, null, "AQAAAAEAACcQAAAAEG1S3y7ElcgLTHqQ17xL+WooF5KhVeTNWIlk5Rh3O89h5fW2Aacdth1inqyLOgDWpw==", null, false, null, null, 0, false, null },
                    { new Guid("600649dd-c6d1-4ff3-9144-03f6ff7e6950"), 0, new DateTime(1945, 6, 3, 22, 52, 22, 21, DateTimeKind.Local).AddTicks(247), 193.4564456769530000m, "03997975-6c53-47ec-be33-1ecac5ba3dfb", null, null, null, false, "Katherine", "Katherine", "Kuhn", false, null, "Katherine.Kuhn", null, null, "AQAAAAEAACcQAAAAELZH5ulQnRY/sNzZNqHVG6BfqJ1OE/DZbK25UJu9TKyz62Jr35GBtfPj17lScmDfMA==", null, false, null, null, 1, false, null },
                    { new Guid("60c86293-9017-4722-ad96-c09fd6051a5b"), 0, new DateTime(1931, 10, 7, 6, 50, 58, 122, DateTimeKind.Local).AddTicks(9205), 741.1079116996980000m, "5f79cfe6-5e63-46af-927e-7b93ae791453", null, null, null, false, null, "Latoya", "Okuneva", false, null, "Latoya_Okuneva96", null, null, "AQAAAAEAACcQAAAAEDBM9oqmFlxpP0Jm0zeOOkjERQoKi9osIcihU7bl6BesJ6UEIeMqUFJolymsZbANbw==", null, false, null, null, 1, false, null },
                    { new Guid("611b8b1f-53d5-4660-9ad4-e0b57e915bf8"), 0, new DateTime(1952, 7, 27, 7, 5, 24, 845, DateTimeKind.Local).AddTicks(2048), 901.9516243722540000m, "91786c80-b387-47e5-86d0-7f524de84741", null, null, null, false, null, "Philip", "Satterfield", false, null, "Philip5", null, null, "AQAAAAEAACcQAAAAEA1j58GxOUd4+iqQt5Fe0BitMYstok2KSaHpisRAexNbXUczHL9gubNNPHZ5JQFUHw==", null, false, null, null, 2, false, null },
                    { new Guid("6127ea05-85cc-4ed4-9b13-5998aee91180"), 0, null, 282.2419740876150000m, "cfee343b-cb51-4be2-9ae1-f81af8fcad02", null, null, null, false, "Tomas", "Tomas", "Lang", false, null, "Tomas.Lang12", null, null, "AQAAAAEAACcQAAAAEF5Ki9k464yWYZX2oHD4PqET1hO3dCKLF8xkdNirGj007H+tPdXa04ed5zSqhmXxCw==", null, false, null, null, 0, false, null },
                    { new Guid("624d07fb-c364-4191-b439-aff73116c1d2"), 0, null, 161.8989304323260000m, "29666f3c-c2bf-4d28-8fa4-0bd3516d88d8", null, null, null, false, null, "Perry", "Greenfelder", false, null, "Perry17", null, null, "AQAAAAEAACcQAAAAEEo79dbahKx22DJLpcWmYouIhplcwFmYB4qlUZj3Qh7t6QIBTo4AddHZQSIMpHqa2A==", null, false, null, null, 2, false, null },
                    { new Guid("628d01f9-5feb-4e85-a1ac-d03470903a20"), 0, new DateTime(1986, 3, 26, 0, 6, 11, 743, DateTimeKind.Local).AddTicks(3426), 966.390953164230000m, "dbfc0632-7520-4012-b0f4-bcb1211a004f", null, null, null, false, null, "Sophie", "Turner", false, null, "Sophie.Turner30", null, null, "AQAAAAEAACcQAAAAENGyQ1aT+jQ/9o2Jtzvs46z+26IuAPNlTksTkDVeRZtL3O31Ieyi+gUFAmjOT4GbvQ==", null, false, null, null, 0, false, null },
                    { new Guid("6441d6d0-462e-4346-8bea-ddea048566dd"), 0, null, 431.2075692361860000m, "20c1b6cb-ed9e-45a7-8367-2fd8d18afd71", null, null, null, false, "Phyllis", "Phyllis", "Kihn", false, null, "Phyllis_Kihn36", null, null, "AQAAAAEAACcQAAAAEEFn2qlTWSZj0PCUGRPuEAYvaTYY1i/Bq6ZOwSbGGDw/dmesjk8WuZZZbqpG4zQG1A==", null, false, null, null, 2, false, null },
                    { new Guid("64677ac4-f6ca-4452-9192-ce10eab5a7a4"), 0, new DateTime(1925, 11, 20, 23, 21, 29, 220, DateTimeKind.Local).AddTicks(6223), 608.1305513712250000m, "c72d9a09-5789-4e09-97cf-4a10878b72d0", null, null, null, false, "Brian", "Brian", "Bergnaum", false, null, "Brian.Bergnaum", null, null, "AQAAAAEAACcQAAAAELGJy73lHsj87LjceyZcg1bOmzB+dCsBg3Djh1PWKVxre6Qwt/rZkKgFEaDjTP8ZUA==", null, false, null, null, 1, false, null },
                    { new Guid("651f4e42-b7be-4042-92c4-872c1b4a2b36"), 0, new DateTime(1925, 12, 11, 18, 30, 49, 948, DateTimeKind.Local).AddTicks(5072), 515.3758188662310000m, "5731ab80-0848-4f58-800f-424941c71112", null, null, null, false, null, "Bradley", "Crona", false, null, "Bradley.Crona79", null, null, "AQAAAAEAACcQAAAAEBz62Y8y7HDecpznXjReGm1N3JK93ACGNrdgo6+nCjP0hVKDiE73yeQqzPhYY2/cjg==", null, false, null, null, 1, false, null },
                    { new Guid("65cb2c49-f00f-450e-94e8-540312a9ce09"), 0, new DateTime(1999, 10, 19, 10, 14, 52, 904, DateTimeKind.Local).AddTicks(1124), 386.3719131289090000m, "06ae099b-ed60-4d9f-bdf9-bd28d9b7e79f", null, null, null, false, "Wesley", "Wesley", "Leffler", false, null, "Wesley_Leffler66", null, null, "AQAAAAEAACcQAAAAEPDCEql36+zGXmhTGb2gmBgy4MhFkENrM+F2I4cRuyeGRSJLgghh/xt+fnCZfcnPWw==", null, false, null, null, 1, false, null },
                    { new Guid("65dedea0-0687-4571-93d0-c6cdfefedb38"), 0, new DateTime(1937, 11, 1, 9, 35, 32, 12, DateTimeKind.Local).AddTicks(5731), 591.639365406980000m, "5238d6a8-f286-45e6-a286-f7a950d52199", null, null, null, false, null, "Joseph", "Reichel", false, null, "Joseph_Reichel", null, null, "AQAAAAEAACcQAAAAEOKjrWPCJwNUSBz4vEcMBmjHcF87edLQ7wV+V3sbxJvdUnHaRuCExkXudwWmt0XzWw==", null, false, null, null, 1, false, null },
                    { new Guid("68bf203c-5d15-452a-b81b-bb7831c4f579"), 0, new DateTime(1979, 7, 22, 13, 59, 58, 107, DateTimeKind.Local).AddTicks(1222), 237.9494865983850000m, "331c75aa-6b95-4231-9c8c-6c39a7686cc5", null, null, null, false, "Neil", "Neil", "Shanahan", false, null, "Neil_Shanahan", null, null, "AQAAAAEAACcQAAAAEHANhDuRRJujlcOvbfKe6Vdgqhl2Dqht3KqsX7HH7AvyLLjBj/offCODH+iRqcg6Aw==", null, false, null, null, 1, false, null },
                    { new Guid("6ceec469-cfb3-42b5-b289-a4c2da0a32dc"), 0, null, 203.7170964701970000m, "a554cbd8-416e-42ec-be85-7511777404cd", null, null, null, false, "Jane", "Jane", "Wiza", false, null, "Jane22", null, null, "AQAAAAEAACcQAAAAEK/1GRRH8UE6s0+5jY3C2z8cqGZ/b+vAL4sjh75DdgqCPTdxNs5nFsz6EakEWeeFZg==", null, false, null, null, 1, false, null },
                    { new Guid("6d64cb25-3e39-4da8-a0e1-a3ee13dd1071"), 0, null, 912.7519846613990000m, "81178195-714f-4e2e-8492-84606d8f8583", null, null, null, false, null, "Gerald", "Veum", false, null, "Gerald_Veum41", null, null, "AQAAAAEAACcQAAAAEDo4n+VY1pNav2xNZ+aSTC7sRF3NwdP704d6mSQKGNa5VHAoBpplY2ezroKZ9IxC/g==", null, false, null, null, 0, false, null },
                    { new Guid("6de94a05-0c03-4062-8ab9-57a5bd55b3a5"), 0, null, 638.6000941053920000m, "4ed906d7-cfb9-443e-95d8-48154edefb9b", null, null, null, false, "Justin", "Justin", "Heidenreich", false, null, "Justin26", null, null, "AQAAAAEAACcQAAAAEMeJLPkDWNqbGoXrD2y5n9gO6g3NvoU3GX6JZjK8TRoQRA7ADWdegkVakhXUVplGYQ==", null, false, null, null, 2, false, null },
                    { new Guid("70fe5fa7-69ef-4577-a750-34ca205c0dac"), 0, new DateTime(1990, 4, 1, 0, 8, 35, 883, DateTimeKind.Local).AddTicks(9243), 108.5589488750220000m, "2239dce5-37af-4b0d-9a7d-32b73c30fee6", null, null, null, false, "Yolanda", "Yolanda", "Thompson", false, null, "Yolanda_Thompson", null, null, "AQAAAAEAACcQAAAAEJ8qWoj6zyefRuUoyobmOT6HHGreEnNRkm84NgQg6pCDdxhnSL0yWJnmDSD7bqoMLg==", null, false, null, null, 1, false, null },
                    { new Guid("712b2e8f-feec-4b44-842e-63c59bbe48cb"), 0, new DateTime(1952, 6, 29, 23, 49, 17, 873, DateTimeKind.Local).AddTicks(3691), 613.9789677252080000m, "a5120ad2-d42e-4bab-bf4c-c6e058aa2b03", null, null, null, false, null, "Chris", "Goodwin", false, null, "Chris64", null, null, "AQAAAAEAACcQAAAAENmSWWd9GZvmdEbWUvYVVzxt0iSsmkpYZJhmzQ5ovIkWNu2fG61kTLou2FPImsXPVw==", null, false, null, null, 2, false, null },
                    { new Guid("7247fafb-5d1e-43fe-a447-5b99c26b77ba"), 0, null, 198.7924070959410000m, "846d8665-15a2-4270-b8a1-ec9ff1fbfde9", null, null, null, false, null, "Frederick", "Ankunding", false, null, "Frederick.Ankunding", null, null, "AQAAAAEAACcQAAAAEBimHztLKyEbF036auFBGG6ElTspWbvTdxHgMfY6RRJ69owQPheiK4CK6C/ConYOjQ==", null, false, null, null, 0, false, null },
                    { new Guid("7271d193-6a4b-40d9-ab91-a7d8a07e45bb"), 0, null, 583.5120115342750000m, "c50ab4ae-6ad1-41ce-a213-22e1e6963565", null, null, null, false, "Frankie", "Frankie", "Metz", false, null, "Frankie97", null, null, "AQAAAAEAACcQAAAAEOKHcoaGwaAkXwtHhqAsYrEB9txeFZorFUtwOO7lKjDdNL0Db5wbXfIy/hPeTFuVmw==", null, false, null, null, 1, false, null },
                    { new Guid("72c94cd8-c5e7-422d-b184-eeec7158816e"), 0, null, 451.0125172445610000m, "1b5f7330-8b0b-49f5-9e5c-febd0ab3e8fc", null, null, null, false, null, "David", "Schumm", false, null, "David.Schumm", null, null, "AQAAAAEAACcQAAAAENQO8unbLxJg3C4oqbAnRCdgWtPrqt9uOsNOvDNBFnnsfAAqtX/k881bdfDGsBa2Jg==", null, false, null, null, 2, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "Email", "EmailConfirmed", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("7319b27d-6146-4420-aa8d-717913c33345"), 0, new DateTime(1979, 2, 19, 11, 43, 48, 687, DateTimeKind.Local).AddTicks(4448), 732.9504670588150000m, "546cd55e-46d6-4a56-9f5e-3fb165bf034a", null, null, null, false, null, "Matt", "Ebert", false, null, "Matt62", null, null, "AQAAAAEAACcQAAAAEEoXIhu4KxdZhi/1ebbMolcvzP3R6zstOuWsOvLd61CjjcukSi3jqnzyHLHbNNxsWw==", null, false, null, null, 0, false, null },
                    { new Guid("7324afd3-dc67-4f31-ab23-e7b052d0c6e2"), 0, new DateTime(1938, 12, 6, 17, 42, 0, 945, DateTimeKind.Local).AddTicks(7414), 624.1772481384780000m, "5549a7b3-6ea7-419b-bceb-df340cac6d3f", null, null, null, false, null, "Isaac", "Hammes", false, null, "Isaac_Hammes10", null, null, "AQAAAAEAACcQAAAAEEwmK5sPQkSNJmGtycE1lQ/jOASjCgFUr8CZ4r7PeB7oNcmcd8n8MvGSfh6CEV7o3g==", null, false, null, null, 2, false, null },
                    { new Guid("732ba531-5faf-4b4a-bcac-24d9ca3fcbc2"), 0, null, 147.2918627126370000m, "297ca01f-3b72-4bdb-8bda-67402d7643d3", null, null, null, false, "Lynne", "Lynne", "Metz", false, null, "Lynne_Metz", null, null, "AQAAAAEAACcQAAAAELPIkzaZlxAlg22AJE9waw22TwACKBZc3RrNMfuF8rcNCPBYmr6vjR1aWC2AT+sXYA==", null, false, null, null, 2, false, null },
                    { new Guid("73953973-c12c-407d-b23d-97f5b010569d"), 0, null, 743.4270190219920000m, "8c4c7144-8104-4323-a741-aabfa3de9222", null, null, null, false, null, "Douglas", "Deckow", false, null, "Douglas.Deckow98", null, null, "AQAAAAEAACcQAAAAEK1rArDIOc08XDiAP7E4kYWDTpG+iaJC50EWgGUUHijuo+/uPxH27xeFlXSyn9Lxkw==", null, false, null, null, 0, false, null },
                    { new Guid("73cff5d2-f041-4e6e-8857-560606637e86"), 0, null, 602.3153179332310000m, "1fd90d67-128b-44af-acea-08520da28479", null, null, null, false, null, "Melissa", "Hyatt", false, null, "Melissa.Hyatt", null, null, "AQAAAAEAACcQAAAAEPd6z7f+cRMYHF4fe8Sw5K/85V6+Q6reH1vf4K8BkWtHZV1tPx/eoayo21BNdAAZxA==", null, false, null, null, 0, false, null },
                    { new Guid("74059a15-c214-4079-bc91-f8aa180574a7"), 0, new DateTime(1943, 2, 21, 1, 36, 57, 564, DateTimeKind.Local).AddTicks(9277), 532.3786035473950000m, "f71f7187-b990-41a4-ba6f-13e5fdc8d52f", null, null, null, false, "Cameron", "Cameron", "Jenkins", false, null, "Cameron.Jenkins", null, null, "AQAAAAEAACcQAAAAECP1bEgn9G3TihuU7KFtapjjVL8WV9J8xBeumbL9xQA9glwVD63v+6sK/IX51b/kMA==", null, false, null, null, 0, false, null },
                    { new Guid("750c9633-57cd-4cce-b195-c19394ee24b3"), 0, null, 165.4386501967170000m, "2399b658-e7d1-4c4f-9702-e7e122fde317", null, null, null, false, "Patty", "Patty", "Gleason", false, null, "Patty_Gleason", null, null, "AQAAAAEAACcQAAAAEBoUMXcn42Bt3H/bbThYfWdS5eagoWVPIYSXqSTur89biux2NW/KCOc6KeovSHqDsQ==", null, false, null, null, 1, false, null },
                    { new Guid("7646ca6a-9ad5-4b77-91b7-839412348bed"), 0, new DateTime(1966, 2, 15, 17, 30, 5, 611, DateTimeKind.Local).AddTicks(760), 619.3951402278920000m, "32bb1379-694a-4d47-9a65-d281b7236de5", null, null, null, false, null, "Lillian", "Halvorson", false, null, "Lillian_Halvorson4", null, null, "AQAAAAEAACcQAAAAEK5bXKy1K/6IQ3X/4gO4MYJnizDaZeqvlhmNgNTdbxPfio64lgcIcNnI9rEZuIDEdw==", null, false, null, null, 0, false, null },
                    { new Guid("77a05cfa-406d-4342-a924-73d56bf2829a"), 0, null, 837.8283386543910000m, "761d7b9a-cdc6-47e4-a550-455dcfde660c", null, null, null, false, "Kelly", "Kelly", "Fadel", false, null, "Kelly.Fadel25", null, null, "AQAAAAEAACcQAAAAEHxpzeCRAXJBjWBMoiH3R4zS8McIDwQMGEFeVDFQ1gX6fjHgLBZBCZOmETXy9p1+Pw==", null, false, null, null, 2, false, null },
                    { new Guid("77f28b3f-3ca9-4819-96c6-bd1e811a39f5"), 0, new DateTime(1939, 4, 5, 6, 7, 40, 548, DateTimeKind.Local).AddTicks(2687), 832.7086091740890000m, "d07bdd07-150e-4ec2-831f-6b3587016685", null, null, null, false, "Oliver", "Oliver", "Hodkiewicz", false, null, "Oliver_Hodkiewicz33", null, null, "AQAAAAEAACcQAAAAENHwUlAsHQZc5bqcgyhVemUubJcuCVsrObLzIVE6hE2Nh9exRgYfQO+r8CM0+SSUaQ==", null, false, null, null, 1, false, null },
                    { new Guid("7975589e-fce3-4ff6-8b4d-4f29aa2e3c37"), 0, null, 663.0014215819270000m, "f664f5b6-0f71-4aac-b6a5-45bf5fd058ce", null, null, null, false, "Johnnie", "Johnnie", "Crist", false, null, "Johnnie_Crist50", null, null, "AQAAAAEAACcQAAAAEGJaqI8lyfd5NnCVJIA4t/48Rq8cvwT/uEo/iIgZO+e0BWuOC64wQBGdsKxZTyZ01g==", null, false, null, null, 1, false, null },
                    { new Guid("7a4f4be1-0c5d-43fb-8b70-3e4913ca97a0"), 0, null, 239.7026183250830000m, "79c1a62a-db21-4a54-b239-c5c83b56eee0", null, null, null, false, "Raul", "Raul", "Leuschke", false, null, "Raul_Leuschke42", null, null, "AQAAAAEAACcQAAAAENW78kXQsAJKWSztrxYjyJwGx7lVaqyNli0UoyWQ+J8Au6RJwUHh1pSah2pF7zb4bA==", null, false, null, null, 2, false, null },
                    { new Guid("7adbc5f0-6d2f-4d16-ad51-1b76edd52481"), 0, new DateTime(1950, 6, 4, 4, 7, 11, 114, DateTimeKind.Local).AddTicks(182), 600.4531206854910000m, "5f1ece06-9df2-4e5e-9f57-8d9ed9672fc2", null, null, null, false, "Ronald", "Ronald", "Kovacek", false, null, "Ronald75", null, null, "AQAAAAEAACcQAAAAEATLBd19nDfpwqM2HW5lWAh+n5E/rwLcEKtHVtZHds8nN3+YSRsoOa17um5nvWUW7A==", null, false, null, null, 1, false, null },
                    { new Guid("7b9aa90c-3f91-430e-bbb3-c445e0de9d01"), 0, new DateTime(1925, 12, 24, 22, 49, 30, 611, DateTimeKind.Local).AddTicks(5888), 162.6042006381070000m, "533b94ac-1947-48bd-9270-ea926a300ea7", null, null, null, false, "Marcus", "Marcus", "Ernser", false, null, "Marcus_Ernser61", null, null, "AQAAAAEAACcQAAAAEBNos7nqsEKx2V9BIM36GoNt2MCDilZuZ1vY4klZqFJvMNiEtdwoTjtZ+IqjhQWP5g==", null, false, null, null, 0, false, null },
                    { new Guid("7c403944-d570-486e-9c1f-e40454a443f6"), 0, new DateTime(1958, 1, 10, 22, 42, 0, 908, DateTimeKind.Local).AddTicks(6530), 741.5551407640010000m, "fe1cb4e2-26fc-4bbb-898b-48f543afee8c", null, null, null, false, "Bryan", "Bryan", "Langosh", false, null, "Bryan.Langosh", null, null, "AQAAAAEAACcQAAAAEK2cU0Mmkm2VFHj7e7xi+xtrtcp20rxnR7+lomzBho91joXHod6AsMlRWmESgjuEnQ==", null, false, null, null, 2, false, null },
                    { new Guid("7d6ad8fc-e102-4ea8-a3e2-5bdfda8f1650"), 0, null, 547.6351836654440000m, "68032d16-cf24-4bb3-bda4-3f98d3ddc9d6", null, null, null, false, null, "Shannon", "Williamson", false, null, "Shannon_Williamson44", null, null, "AQAAAAEAACcQAAAAEDowJjghw3FZ3K8eS9XmQU28VtvMtc61TtiEDT7qwoR2asa2/qA/21N4FNaRcZuFGQ==", null, false, null, null, 2, false, null },
                    { new Guid("7e04a2e8-5af7-4c5e-8b81-d51fb8eb210b"), 0, new DateTime(1982, 10, 28, 0, 20, 0, 179, DateTimeKind.Local).AddTicks(9188), 499.2372740546260000m, "016e0ed0-e88f-45de-8c99-e55a1978be72", null, null, null, false, "Irving", "Irving", "Grimes", false, null, "Irving_Grimes", null, null, "AQAAAAEAACcQAAAAEH0apBCZibVxBOREw4g96zCBE5RDOpZ+QYs3RQ3F07WPEURvOPIE4h2iv7u8ArwHpw==", null, false, null, null, 0, false, null },
                    { new Guid("7f1920c1-828a-4d44-abe8-9db2c3bea2a0"), 0, new DateTime(1987, 9, 4, 18, 49, 35, 152, DateTimeKind.Local).AddTicks(9607), 85.11472848971310000m, "2bc95f22-579e-4d14-9dfa-c88f99fd285d", null, null, null, false, "Kimberly", "Kimberly", "Renner", false, null, "Kimberly45", null, null, "AQAAAAEAACcQAAAAELlGH54a9o3+MYwb/TKi0IhCZvkadiUPYlru2KPBS6S1HjKsFd3exlOLFHKra8Vz9A==", null, false, null, null, 0, false, null },
                    { new Guid("7f857795-bd2a-48ee-bcf8-ec48fdb428ab"), 0, new DateTime(1929, 2, 20, 9, 21, 40, 167, DateTimeKind.Local).AddTicks(3913), 707.508404612350000m, "20dc3203-9098-4cca-adba-52b2ee0ccda9", null, null, null, false, null, "Derrick", "Kirlin", false, null, "Derrick.Kirlin", null, null, "AQAAAAEAACcQAAAAENI/dVh6sfY8mCr4OLOg4oXQa32yxyIWG7PlqM8n60K1HOSpf7ryoCqmTMIll0Zblw==", null, false, null, null, 1, false, null },
                    { new Guid("8180db6e-0139-48fa-a7bc-8424ac74378c"), 0, null, 279.4358291442860000m, "2ea7cf57-f0b3-4d80-8804-f2a3c936ae7f", null, null, null, false, null, "Tyrone", "D'Amore", false, null, "Tyrone.DAmore", null, null, "AQAAAAEAACcQAAAAEGlgGlzoCI+4zEZDtHVWXuZ5tE5f7MsZc5lqTBhCHBzEzQatzj0gFcMCN8dWtH5Fdw==", null, false, null, null, 1, false, null },
                    { new Guid("8343d773-e986-49d8-99e9-bd908398b011"), 0, new DateTime(1976, 10, 8, 8, 36, 33, 86, DateTimeKind.Local).AddTicks(6864), 818.3478545345870000m, "db5c5ea1-2813-4fd8-8f88-f814889f8cf6", null, null, null, false, null, "David", "Kris", false, null, "David53", null, null, "AQAAAAEAACcQAAAAECSuEcWFi1Q8g4iTJH2TM7Xm2zRylrmdoLkpjvKNHGIKvLDG4aT8Ber3l+9A35mUMw==", null, false, null, null, 2, false, null },
                    { new Guid("85626191-e7df-461f-8d6e-58391f67d36a"), 0, null, 996.6050164119640000m, "6c01916a-8dd5-4336-9575-de0f8da08729", null, null, null, false, "Jean", "Jean", "Becker", false, null, "Jean_Becker57", null, null, "AQAAAAEAACcQAAAAEPedbPNCUI2A3p/ocTxfPnobudpiS3KLfx3zQ48vi9gipfOvcrJzDNjQ5QQL9IYPPA==", null, false, null, null, 2, false, null },
                    { new Guid("8887b8ab-eb5d-41ad-bac2-3126e85117d1"), 0, null, 186.2526733924330000m, "8dde25e2-9e5f-4eac-860f-9bdbd1ee1ff4", null, null, null, false, "Alberto", "Alberto", "Doyle", false, null, "Alberto.Doyle64", null, null, "AQAAAAEAACcQAAAAEJLl3+bpeFzMnWVs995ICB15vbEdx7w3Qvyb4mdyjNZ5CYxzodIAd+Z1KpvJQXLGNQ==", null, false, null, null, 2, false, null },
                    { new Guid("89739d78-901e-4353-8c13-fe879541f76f"), 0, null, 536.366991264690000m, "67ebcc9b-da59-4a33-a9aa-6138fc5f7ed3", null, null, null, false, "Sheldon", "Sheldon", "Luettgen", false, null, "Sheldon_Luettgen50", null, null, "AQAAAAEAACcQAAAAEF/XvU0IIhOwbHVPBhfd/w5a72htaX2r7YxdeVKTjzzwQ491mS0jJ3Bq5w50gytjzQ==", null, false, null, null, 2, false, null },
                    { new Guid("8988ace1-50ae-4626-95ff-eac9a9aeade6"), 0, new DateTime(1978, 5, 19, 10, 22, 23, 968, DateTimeKind.Local).AddTicks(1791), 577.2619506887390000m, "562a63bb-cf3c-439b-8918-2ecfdeec58a2", null, null, null, false, null, "Gwendolyn", "Hoppe", false, null, "Gwendolyn_Hoppe", null, null, "AQAAAAEAACcQAAAAEIObipsbWfo7DsbxLzX9wzfzc1ACHpw12iYewvFHc9YKFdrQlXQAqvhjsd7JhknwbQ==", null, false, null, null, 0, false, null },
                    { new Guid("89f14bfd-f2ad-40fc-8c24-b21398e3c7d3"), 0, null, 414.5081582435230000m, "302d7123-cc4d-423c-8175-897d7ad9e3e2", null, null, null, false, "Conrad", "Conrad", "Abernathy", false, null, "Conrad.Abernathy", null, null, "AQAAAAEAACcQAAAAEMX0royFniUnAdmsNgjSp/VwQayGR57LMJIJYGSYkA4ggr4gIfJSRatknwsiRPRGDw==", null, false, null, null, 0, false, null },
                    { new Guid("8b82d9a1-181d-4f54-aa69-032bffd3d9d4"), 0, new DateTime(1944, 12, 23, 19, 57, 51, 69, DateTimeKind.Local).AddTicks(7706), 4.370857554626850000m, "0869f2bd-d80a-4b93-9b21-8096811dabe1", null, null, null, false, "Darnell", "Darnell", "Kautzer", false, null, "Darnell_Kautzer", null, null, "AQAAAAEAACcQAAAAEC4azPnOMoZ+LBl4e8ebFbMVmLKVe1TTHOwmZDG/oYpeK0aLnugE0oF32tNT/IBg3w==", null, false, null, null, 2, false, null },
                    { new Guid("8c149454-da44-4038-9ece-768e572c5282"), 0, null, 451.7731539150830000m, "2f76a84c-5a90-4c04-8977-098f89b69bf8", null, null, null, false, "Johnny", "Johnny", "Konopelski", false, null, "Johnny98", null, null, "AQAAAAEAACcQAAAAECoOyr448NpCaYEveSLPTnOa//G34QM+ob50TYeEuTwP5Dn4sSIyLEgvZ7zLQ39FDg==", null, false, null, null, 1, false, null },
                    { new Guid("8c658576-57f3-41cc-9a3b-917efb1480d9"), 0, new DateTime(1990, 12, 7, 0, 54, 59, 931, DateTimeKind.Local).AddTicks(6241), 566.9777870503240000m, "d84dd270-aa60-4a13-9d5a-06c6fd4d2d8c", null, null, null, false, null, "Margie", "Bergnaum", false, null, "Margie87", null, null, "AQAAAAEAACcQAAAAEM1gXN2Idj7FX0+X51Oh+WyK/N+GPWYZa3dNKEHFIOA9+5dgXpf65zaayB9bjc1KlQ==", null, false, null, null, 0, false, null },
                    { new Guid("8c8ff9a2-2752-46a7-960e-0490c28de13f"), 0, null, 372.2311143035270000m, "07b47c07-20e0-48f0-aa88-5f715e6b86c7", null, null, null, false, "Grace", "Grace", "Welch", false, null, "Grace_Welch32", null, null, "AQAAAAEAACcQAAAAEP5qbevBpY1cMPkwGKnuk0JPlLbmn407Hr9EcM7lCetHwpuKTEGqNimIyzE9BB3OlQ==", null, false, null, null, 0, false, null },
                    { new Guid("8d7de522-82d8-4912-bf1a-5d80658097e7"), 0, null, 160.2539481378270000m, "95c0b220-1911-455c-b851-80043a4a895b", null, null, null, false, "Crystal", "Crystal", "Pfannerstill", false, null, "Crystal_Pfannerstill29", null, null, "AQAAAAEAACcQAAAAELScd/MmrS5Asl3ozgX5CRxOWRC4WAJ4+KlnBwtH+cgPV9NKEN48tlLWWvdAPQYYlw==", null, false, null, null, 1, false, null },
                    { new Guid("8de401f3-837a-4e09-884e-ddf9af867804"), 0, null, 754.6789112583320000m, "4279ecaf-c4cd-4bac-832f-df04ad9ebb53", null, null, null, false, null, "Jeremy", "Brakus", false, null, "Jeremy.Brakus40", null, null, "AQAAAAEAACcQAAAAEJlz/cUEPrJ88RMOtOEsdlMMtxYOIjVPO9SnYk8snsJ1MMeFLeEjG1FaVnN5AX6TvA==", null, false, null, null, 0, false, null },
                    { new Guid("8dea05e1-92c5-40d9-9159-8e1dcb818034"), 0, new DateTime(1969, 3, 17, 20, 37, 4, 503, DateTimeKind.Local).AddTicks(9368), 997.0913927277920000m, "cd7ccb9d-0141-4e9f-b9b8-8f3f63a00d77", null, null, null, false, "Viola", "Viola", "Schimmel", false, null, "Viola.Schimmel", null, null, "AQAAAAEAACcQAAAAEFzBP6FW3lQuvt2sEGtVuU1a/dJR+0KAxGveI0rw1WH986eRRuyw/ohR7JjlnLNNRw==", null, false, null, null, 0, false, null },
                    { new Guid("8fca9140-9c2e-4112-9850-cdf3b029b5ac"), 0, null, 269.4896268175460000m, "3cf21a2d-0bb3-45b6-8d6f-f4f915f596d0", null, null, null, false, "Hector", "Hector", "Schinner", false, null, "Hector98", null, null, "AQAAAAEAACcQAAAAEIRyKP8DzvS3spqtt1Guh3ud6TxT8aDFthyy1F5FZ8Z1fDki7rtRQIPhhW66Yk4Pkw==", null, false, null, null, 2, false, null },
                    { new Guid("9102f36c-0db2-4a0e-b22a-bcaffabfb757"), 0, new DateTime(1983, 9, 2, 22, 51, 43, 486, DateTimeKind.Local).AddTicks(6308), 961.9494425323160000m, "af5a22cd-2877-441d-b947-cb6e3b867cac", null, null, null, false, null, "Sophie", "Green", false, null, "Sophie.Green", null, null, "AQAAAAEAACcQAAAAEEslu/RkmxvYJ5VV/wrsiuU6XxN8xEdIxlCamloZ7sMlZmqxm3WWYEbAVB0POEduoA==", null, false, null, null, 0, false, null },
                    { new Guid("922f53da-9877-4d56-a64d-6d83331bdbb6"), 0, new DateTime(1969, 11, 28, 1, 23, 29, 805, DateTimeKind.Local).AddTicks(4309), 679.3823897197840000m, "f2190384-0a3d-4301-979e-90687f640a55", null, null, null, false, "Matt", "Matt", "Reinger", false, null, "Matt77", null, null, "AQAAAAEAACcQAAAAEKHjU52p6ERpAEC7iz3c/D9BaF4nCVIT1R8D2mxrbh5b2ilIQWBOeZY3GLxWcMeZMA==", null, false, null, null, 0, false, null },
                    { new Guid("9252c306-249a-4267-8ef5-891d8c0cbea1"), 0, new DateTime(1958, 5, 13, 5, 37, 59, 722, DateTimeKind.Local).AddTicks(6962), 924.3461423966450000m, "0b732990-6fcc-4cce-96a0-26aed90b36a8", null, null, null, false, "Patrick", "Patrick", "Witting", false, null, "Patrick_Witting45", null, null, "AQAAAAEAACcQAAAAECoTz7G945ZcVTKvRyaN19v1ZJ6sLV31PTSc+DIPDjyu2yeDeV+DhUlWVauoyyYtZw==", null, false, null, null, 2, false, null },
                    { new Guid("92fa424c-9623-4989-b9fe-494533664c26"), 0, null, 427.2446845769890000m, "b6e5738a-a62a-4ca5-92a2-aa2cd83f9e5a", null, null, null, false, "Jan", "Jan", "Stroman", false, null, "Jan.Stroman91", null, null, "AQAAAAEAACcQAAAAEMYKwwSE2qZqDP0ury5q/b1se5Oj9l1yZrqeEl2eYZQ+wmqt+vEBj1z0ByG45GquOg==", null, false, null, null, 2, false, null },
                    { new Guid("9336f657-bf13-4455-becf-1afff818911b"), 0, new DateTime(1960, 11, 9, 6, 6, 50, 730, DateTimeKind.Local).AddTicks(2905), 632.5098842271170000m, "960ea353-d195-4cd6-b341-2e44402aa157", null, null, null, false, "Christian", "Christian", "Schultz", false, null, "Christian.Schultz", null, null, "AQAAAAEAACcQAAAAEHI4PMOwavnygsJNhaDFWhZCAXPsrjDNFuwftQze0MhEfDzVCLhguaHxWUUycL/j4Q==", null, false, null, null, 1, false, null },
                    { new Guid("96830fa4-dc91-4a31-8fad-9b956fd29c58"), 0, new DateTime(1927, 6, 24, 10, 8, 12, 289, DateTimeKind.Local).AddTicks(303), 288.5216231603660000m, "93ccd209-6a50-45f7-a84a-5fe2c40361b1", null, null, null, false, "Ethel", "Ethel", "Pollich", false, null, "Ethel42", null, null, "AQAAAAEAACcQAAAAEICFJvgXeblXbgG+orcc5xEWVpYwTesbCnAvFBmqydZATaouGaccTwl2RkfJu2x0yQ==", null, false, null, null, 0, false, null },
                    { new Guid("980f1926-46d3-48d9-880c-73d0be9fa1e0"), 0, null, 236.4652887863780000m, "f6ded436-4933-4067-b76f-ea9cd86a1bea", null, null, null, false, null, "Jacquelyn", "Zemlak", false, null, "Jacquelyn5", null, null, "AQAAAAEAACcQAAAAEGV6LMrmJswA1NGvN3gsF9rATZtKQdwnaIRXGgQX8H84ewhLnRVhcZP5Z0YnSW5fSA==", null, false, null, null, 0, false, null },
                    { new Guid("993e8305-611d-4730-af5d-dbd1e15c6650"), 0, null, 171.3190522852350000m, "98799696-2e75-4ac1-8720-08641ce53624", null, null, null, false, null, "Kendra", "Kunde", false, null, "Kendra_Kunde", null, null, "AQAAAAEAACcQAAAAEPm4FPcMOhoP8ykfOyaXXqHSvM160UUIoEZIVJPJQUnBbahtk+ZTHu5UWZKilrFR6g==", null, false, null, null, 1, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "Email", "EmailConfirmed", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("9981eef1-0435-4903-9860-b16fb734ad1b"), 0, new DateTime(1949, 4, 30, 3, 15, 51, 924, DateTimeKind.Local).AddTicks(3301), 601.7522728326240000m, "ee51ceba-71e7-4a35-a7a1-ca21fec1ddd3", null, null, null, false, null, "Howard", "Luettgen", false, null, "Howard_Luettgen9", null, null, "AQAAAAEAACcQAAAAEEcE4XSg0teeVzZC7UikcmR5txcdw2ymQ+PaDnjDyFMpLzn598yb+HHHZZVbsbgsQw==", null, false, null, null, 2, false, null },
                    { new Guid("99d66586-6373-4afb-b333-7c5cb91075c4"), 0, null, 408.9518371515490000m, "65462b16-0eee-4c6c-ab1e-7bd006079492", null, null, null, false, null, "Christy", "Robel", false, null, "Christy_Robel", null, null, "AQAAAAEAACcQAAAAEH+/L0W+LknSxcgy8JAA8QxV9gPEW2NSBemNItOH+o3Lfo8lCIIF7BAZERkWxBYPGg==", null, false, null, null, 1, false, null },
                    { new Guid("9beccf2d-f01f-48c2-a830-6db7b7da19dd"), 0, null, 271.5328443737880000m, "b271eca2-3673-415e-913c-05129d7569e0", null, null, null, false, "Sophia", "Sophia", "Nienow", false, null, "Sophia.Nienow47", null, null, "AQAAAAEAACcQAAAAEBJDjvXdCJKsm/uUBUSxLdjEh8IBagOyHcDli+AWtHxMq+rKLY3Ri8NvFx1HqkBwyA==", null, false, null, null, 2, false, null },
                    { new Guid("9e9403fb-605a-441d-a83a-f936fec7582f"), 0, null, 719.0047486292260000m, "6a44ba3d-b5c9-4c50-ac82-8d017abf553e", null, null, null, false, null, "Ricky", "Batz", false, null, "Ricky39", null, null, "AQAAAAEAACcQAAAAEOjTcbJPFkqUmz75/Y53hOwU/QdEcEICbGoB5QVl2R2fm1QyiuDxq9mgKzWsaOo5fw==", null, false, null, null, 2, false, null },
                    { new Guid("9f2db745-dcf4-4a49-a27a-ae15a2f3087e"), 0, null, 710.1868294079550000m, "ffcb84a0-7a1e-400c-aa5f-7df05028a15f", null, null, null, false, null, "Antonio", "Spinka", false, null, "Antonio68", null, null, "AQAAAAEAACcQAAAAEHqnlaq05Z1nyLLZH9a0XDATvJn6W90P/o6c+T3HM4ymLLvnaZi9nLZxkZDDEi2IuQ==", null, false, null, null, 2, false, null },
                    { new Guid("a0042a3d-7eaa-4c67-b018-40977ff2a846"), 0, null, 493.1872765087310000m, "24c6a5ce-ca7a-48fe-8537-59254fe23b2b", null, null, null, false, "Myrtle", "Myrtle", "Hermann", false, null, "Myrtle_Hermann98", null, null, "AQAAAAEAACcQAAAAELGU4jANv8WQfJ9t45L/QUfGAf6yUJ3u3T1yqnPAKoOKmePSUPHg9ncDFRwvsWIfgA==", null, false, null, null, 2, false, null },
                    { new Guid("a0d3cad9-30ac-4da2-8952-dcde6122a64a"), 0, new DateTime(1986, 5, 26, 16, 20, 0, 172, DateTimeKind.Local).AddTicks(4056), 43.61377654394670000m, "70e2635c-3104-4f29-9f95-ce5846da16f7", null, null, null, false, null, "Marjorie", "Mraz", false, null, "Marjorie26", null, null, "AQAAAAEAACcQAAAAENjJBUHbujtwXSMESkeTvd6f59VF/RoY7DmQg7+0p6A9tEK968f6hc6wLGsWyEa6Bw==", null, false, null, null, 1, false, null },
                    { new Guid("a1e9eb46-748f-4b86-8554-7ae48675b2da"), 0, new DateTime(1979, 7, 2, 4, 27, 8, 665, DateTimeKind.Local).AddTicks(6709), 130.0387705244860000m, "0e5cc5bb-f36f-4df9-b57f-bfdc272d14b2", null, null, null, false, null, "Brent", "West", false, null, "Brent1", null, null, "AQAAAAEAACcQAAAAEG4TC8JzwA6b7c0dGC2EnmNpqb8rOLZ64ZLqPGRb7FoojUDWZZX0hoM1BqC8g5vkpQ==", null, false, null, null, 2, false, null },
                    { new Guid("a339ea33-3188-40c2-9d84-9ea46aa67e82"), 0, new DateTime(1987, 12, 15, 10, 55, 21, 119, DateTimeKind.Local).AddTicks(3964), 761.35020131930000m, "18d5ae4e-ceaa-4edf-895d-44be02b7142f", null, null, null, false, "Derek", "Derek", "Koch", false, null, "Derek18", null, null, "AQAAAAEAACcQAAAAEBi+K0NNPaqM4NsSZP9/BIlX273GENlSfWiEB7Y7Xe4mgUxU8VVksseZoCmRgedaqA==", null, false, null, null, 0, false, null },
                    { new Guid("a3bc456f-939a-42c3-99ed-719e0db5bf18"), 0, null, 494.7294265697940000m, "656fd7c0-9de8-4dfb-a07e-d536435f10f4", null, null, null, false, null, "Alfonso", "Mueller", false, null, "Alfonso.Mueller", null, null, "AQAAAAEAACcQAAAAENMbwrSR46FHKt2t/tmAOYoyk7PXz8pr4LgKTnb5CWVCfFDfdtch7OfvFFs8sSipLw==", null, false, null, null, 2, false, null },
                    { new Guid("a4972888-e048-48a4-a351-23bd705a917e"), 0, null, 736.0380671653520000m, "dede26c9-f70d-44bb-9165-457be8a6690e", null, null, null, false, "Olive", "Olive", "Heaney", false, null, "Olive.Heaney", null, null, "AQAAAAEAACcQAAAAEKZpsnBWq6GAWsKz3LF4AA1Sqzzry2IHOAJ/yZfEpdLdPZKru7wR/VYRfxczxq+kzg==", null, false, null, null, 2, false, null },
                    { new Guid("a4fd1dcd-4db0-4a8a-9303-ecaf58ed8a81"), 0, null, 193.9861732329870000m, "61af93fe-38cf-459f-aea4-23ad3ad5c8aa", null, null, null, false, "Homer", "Homer", "Flatley", false, null, "Homer51", null, null, "AQAAAAEAACcQAAAAEOsfRxdNBLh2V43Y93XtofcjeCbr3IdN86i7yWfR+SpznHq+Fxij8z2u5qP9kiGV2w==", null, false, null, null, 1, false, null },
                    { new Guid("a5e0abc8-bc40-47e6-bf22-077c758ba0a7"), 0, new DateTime(1957, 12, 13, 11, 35, 16, 374, DateTimeKind.Local).AddTicks(7767), 5.086835569251820000m, "4966a17c-6c30-43d9-b586-97b4a7682ff2", null, null, null, false, "Elisa", "Elisa", "Prosacco", false, null, "Elisa67", null, null, "AQAAAAEAACcQAAAAEDC9HYR4TZ0nPwxe7k3cFg4HYnAGMX+eYA5dl+eh2IVv8EMFIf6wxDxOcjVNZtDFWA==", null, false, null, null, 0, false, null },
                    { new Guid("a6098ed7-dc3b-4d11-bcda-a3ba0c8ac2f4"), 0, null, 231.4958565336240000m, "d809c6f8-1421-4107-b465-b6c41d566dd2", null, null, null, false, "Jamie", "Jamie", "Mayer", false, null, "Jamie30", null, null, "AQAAAAEAACcQAAAAELubQvojjEyf5H3Cys78iLVAOG51D7OOvUr4RIMwOTOjiVJOKf4jDFU4PdEgOosOcA==", null, false, null, null, 2, false, null },
                    { new Guid("a66e6d00-7000-4eb2-994b-a38594503957"), 0, null, 380.8728099902790000m, "5519f807-a561-4e92-8613-0c3c9db1f9be", null, null, null, false, null, "Kelly", "Kerluke", false, null, "Kelly96", null, null, "AQAAAAEAACcQAAAAECOi9ybzrrEskRDYeLHVk1wsP5GhCEJW7vQto7egd+dGHVe3dZlLPHVghxZERb9nWw==", null, false, null, null, 0, false, null },
                    { new Guid("a72d6b0a-25a6-4c67-ac93-cc46cae2d9dd"), 0, new DateTime(1960, 12, 28, 19, 8, 41, 831, DateTimeKind.Local).AddTicks(6408), 83.4864082192790000m, "0cb7a8fc-12b0-4c75-a7c2-c4556fc82898", null, null, null, false, "Ernesto", "Ernesto", "Moen", false, null, "Ernesto_Moen14", null, null, "AQAAAAEAACcQAAAAEABKPZpSfX+lc0SydjrkmKfQbgObggfL5y4HdgrDJgCot6Kv49tTQkpTDIYkmUZk7g==", null, false, null, null, 2, false, null },
                    { new Guid("a8fb7001-ca18-422b-b724-7bb884b357db"), 0, null, 285.3776092502930000m, "7b7928f2-d773-4730-8cb8-b380bbf6a4db", null, null, null, false, null, "Andrea", "Schmeler", false, null, "Andrea60", null, null, "AQAAAAEAACcQAAAAELOG8jpDnIZ1WAdgjqGui1E6kFPaEQ10pvSvhd63vHH2+s5RtqluoxWq922EHdZe5g==", null, false, null, null, 1, false, null },
                    { new Guid("a907043f-86ba-4126-baac-6e2c6eb5871c"), 0, new DateTime(1933, 3, 29, 22, 8, 44, 518, DateTimeKind.Local).AddTicks(7649), 799.1592918052340000m, "5bd0f53b-f07b-41f4-8ebc-d5625723c31a", null, null, null, false, "Frances", "Frances", "Haag", false, null, "Frances_Haag42", null, null, "AQAAAAEAACcQAAAAEDNDEJVF+L5Yl2Cr9xO0PL8lbgQKN0yKGUZHnOgW59OsC7XrffBvK61fmrBkU/iySQ==", null, false, null, null, 2, false, null },
                    { new Guid("aa406ff8-810a-45a6-8b41-5028563ae3b6"), 0, new DateTime(1929, 11, 6, 0, 39, 36, 387, DateTimeKind.Local).AddTicks(4009), 248.2050038652480000m, "b71842fe-7a06-4a3b-bfdc-c4de73ad8f17", null, null, null, false, null, "Raquel", "Auer", false, null, "Raquel67", null, null, "AQAAAAEAACcQAAAAEPDLQMf6dIjzo6s9zoJXE9NZp2EHe2mVSkLFHojVjrFzZQVn5/BWqGBnYefSF8t4eg==", null, false, null, null, 2, false, null },
                    { new Guid("ab38dbfc-78a4-4d84-9e77-53448911bc9f"), 0, null, 167.2853613578110000m, "57eed549-2afc-4b0e-91ae-5b68f4f99655", null, null, null, false, "Johnny", "Johnny", "Botsford", false, null, "Johnny.Botsford", null, null, "AQAAAAEAACcQAAAAEFHGFRLvk3uGgqq7IOToRJhszhNEgaznWQ3a98BeyxA78SeyJXJD6UmiRlwleDSblQ==", null, false, null, null, 2, false, null },
                    { new Guid("ab522845-c1bd-4f82-bee3-06f49429e4bf"), 0, new DateTime(1980, 8, 12, 9, 57, 24, 672, DateTimeKind.Local).AddTicks(4894), 415.5506317282030000m, "e335bbbe-9322-49c7-bcf4-292114acd2b4", null, null, null, false, null, "Debbie", "Schowalter", false, null, "Debbie.Schowalter", null, null, "AQAAAAEAACcQAAAAEBKMvnlC29CUcB2KPrEP7i5sobCqbAjKRMQ6cJF0CyEs6upHD12vgEKZaqPEbeXNcQ==", null, false, null, null, 2, false, null },
                    { new Guid("abfe1efb-0a8f-4af4-ab49-6de94e3ef374"), 0, new DateTime(1954, 1, 26, 12, 22, 45, 756, DateTimeKind.Local).AddTicks(2105), 832.250601660930000m, "cfa78cea-7ca6-4de5-a65d-402e745ed6d7", null, null, null, false, "Louise", "Louise", "Cormier", false, null, "Louise51", null, null, "AQAAAAEAACcQAAAAENmb0LiuycKr8zWwQtnlRmTqvfFF662V6yn2K63EAuFiMrV5jua4J8D2M+KIY1dyqg==", null, false, null, null, 2, false, null },
                    { new Guid("ac4b1e96-68b1-4502-856c-10b88acf07fa"), 0, new DateTime(1995, 6, 30, 21, 48, 10, 372, DateTimeKind.Local).AddTicks(4227), 990.1421812617920000m, "2b2e259b-5382-4a93-9f80-489f1a155219", null, null, null, false, "Alice", "Alice", "Schaden", false, null, "Alice.Schaden46", null, null, "AQAAAAEAACcQAAAAEE6lKgXs7XN12ccnDg/g3vL9AsL2zLqUaKBT9cbIPKS/3FeK23n+hZVhnf2IIGfQWg==", null, false, null, null, 0, false, null },
                    { new Guid("ae1ca1b0-7eff-4b3f-a0bd-d326d1ebe578"), 0, null, 429.486976264550000m, "fe011d52-2fe6-4077-ad8f-ed6beff1b16e", null, null, null, false, "Ollie", "Ollie", "Muller", false, null, "Ollie62", null, null, "AQAAAAEAACcQAAAAEN7Zc9DuWwVuN09N1BXGYS3Cte7erIer8fzw8BqaNutk00Qh5JlTBbKtMpyF1r7Frg==", null, false, null, null, 1, false, null },
                    { new Guid("ae3132fe-b0e9-44a8-a734-658de87cc9a5"), 0, new DateTime(1997, 12, 18, 2, 25, 24, 200, DateTimeKind.Local).AddTicks(4821), 114.7482811214630000m, "583f03c4-5a6d-4918-88fb-68449393b186", null, null, null, false, null, "Deborah", "Jaskolski", false, null, "Deborah_Jaskolski", null, null, "AQAAAAEAACcQAAAAEPHQagCDb8emfxg+RoYMAXcVsuhTAOOLJPRhB31MA3IJJR3BOxAXjEzaCZw7XR2Ucw==", null, false, null, null, 1, false, null },
                    { new Guid("ae39cf22-04cf-4eb4-8b28-b59be4789ea6"), 0, new DateTime(1954, 4, 19, 6, 45, 46, 397, DateTimeKind.Local).AddTicks(5567), 626.0490073451330000m, "fc6d6116-d92e-4414-bd77-8a0c7cf86312", null, null, null, false, null, "Jason", "Prosacco", false, null, "Jason16", null, null, "AQAAAAEAACcQAAAAEMBsfpbD5h4PkpPF2mJFkOoYjIRLglhO5qOXfdQmy6cxuAbXjiQTQ9Sm8VAhbZ+93g==", null, false, null, null, 0, false, null },
                    { new Guid("af267ef9-b2cf-4adf-a9d0-a58e3acadfa6"), 0, new DateTime(1948, 7, 14, 15, 46, 6, 493, DateTimeKind.Local).AddTicks(197), 755.6059272477770000m, "36370c97-f932-4331-9911-e0c32301e935", null, null, null, false, "Dustin", "Dustin", "Toy", false, null, "Dustin_Toy1", null, null, "AQAAAAEAACcQAAAAEN9r+l/jQojuf8svkBsAkalmR9JTg8g51TzGpHHs4fxzsF9ToP9gN4jYx+UNdDOQsA==", null, false, null, null, 2, false, null },
                    { new Guid("af67d494-10d3-4417-9f74-90816ee69f93"), 0, new DateTime(2007, 10, 20, 16, 5, 35, 630, DateTimeKind.Local).AddTicks(3175), 981.0921386380030000m, "6dc0337d-07a0-40e0-97da-f1a6c9dd7139", null, null, null, false, null, "Erik", "Upton", false, null, "Erik.Upton65", null, null, "AQAAAAEAACcQAAAAEKPqCNYsinangVOx5lw/ck7G8nt0nQdqzF7SpQLf5pIpm2ZaxGS2WVztwuBFz1HaFg==", null, false, null, null, 2, false, null },
                    { new Guid("af831e9b-a557-4f53-81e7-2278eb8802a1"), 0, null, 720.2928796284690000m, "e534011d-f4b8-4c95-a4ea-5c8a0b8edfa9", null, null, null, false, "Blanche", "Blanche", "Wintheiser", false, null, "Blanche81", null, null, "AQAAAAEAACcQAAAAEGn7KV9tZEv6mFYuEZhsOxTIeeiV5zVZJI8ZtZA4fkyK03UKTGb5mOug21Pn/9LkTA==", null, false, null, null, 1, false, null },
                    { new Guid("af867e87-ddef-4efe-ba16-9ce831f47443"), 0, new DateTime(1994, 12, 20, 23, 37, 45, 312, DateTimeKind.Local).AddTicks(6752), 604.2914123678060000m, "ff63db73-2918-4fa5-ab1c-33ac5ebf66a2", null, null, null, false, "Melissa", "Melissa", "Rolfson", false, null, "Melissa37", null, null, "AQAAAAEAACcQAAAAED5Zz2MfHScO0mcLS7AXrwyYpUWUEfItGGOsLq7XbrJ3VzE0NQzu03pB+59BHE4OYw==", null, false, null, null, 1, false, null },
                    { new Guid("b09cd69c-fd2f-4c43-9227-439aa81d485e"), 0, null, 13.1301399360280000m, "09f15ef6-eb97-48e5-b8e4-b2f05fa96ae9", null, null, null, false, null, "Delores", "Abernathy", false, null, "Delores_Abernathy6", null, null, "AQAAAAEAACcQAAAAEDidhYs+qO5Wd4sGJrAet4nHNATjJW/9lBocCf/UjOjk4++W/JAibZltZgDlevNh/g==", null, false, null, null, 0, false, null },
                    { new Guid("b2085c8a-b530-4404-a522-eaa5962529ec"), 0, null, 995.515329838940000m, "4e02c645-1c32-4448-a721-9be2300595f6", null, null, null, false, "Marlon", "Marlon", "Berge", false, null, "Marlon_Berge", null, null, "AQAAAAEAACcQAAAAENAlwVvUMBPzHPU2N4Q+HUfZ/rFzl1C+PF1FUcHLFvTkNn0Sp8OtVTL7MDImmiceiA==", null, false, null, null, 0, false, null },
                    { new Guid("b252505e-f926-4638-a778-09894c7e3345"), 0, new DateTime(1950, 6, 24, 16, 31, 18, 816, DateTimeKind.Local).AddTicks(2775), 178.4165165274480000m, "b05b5ab3-72d6-4074-8ed7-716b5416b110", null, null, null, false, null, "Jackie", "Beatty", false, null, "Jackie.Beatty89", null, null, "AQAAAAEAACcQAAAAEBqTY7jcfBLtX6VQX73JmxWsZStQYIg8sjWMMOoSuKywCTXBjoCYpaHccbrhWAcP+g==", null, false, null, null, 1, false, null },
                    { new Guid("b2abd3eb-7d4b-49b1-8a46-4ea8b8313ab8"), 0, null, 695.4419142134390000m, "66646a72-dd0d-48da-b376-37ae8ab99872", null, null, null, false, "Rachael", "Rachael", "Sporer", false, null, "Rachael29", null, null, "AQAAAAEAACcQAAAAEOdC3W++RhBlyvmVVkTKkZOJIxVvmHSCstTb7f0Rsfxcq91OeXG1fvbIGRS+TIjdiQ==", null, false, null, null, 0, false, null },
                    { new Guid("b40e13af-a00a-45af-a681-b960cb8d6a7b"), 0, null, 342.3693962117250000m, "96be82d7-ebe4-45b5-84d1-10550d873563", null, null, null, false, null, "Hector", "Bradtke", false, null, "Hector_Bradtke", null, null, "AQAAAAEAACcQAAAAEOj0fQrmPNx6YKQn0wwu/xK7tM2kOB0HsIQTZL76cW2d/8lnxF4CdbA48Cf1yOzk6w==", null, false, null, null, 1, false, null },
                    { new Guid("b7003b5f-1610-4487-9fd1-c03a6d0982d7"), 0, null, 736.3840121591890000m, "917c7416-a4a2-4161-8cb7-0471adc67564", null, null, null, false, "Henrietta", "Henrietta", "Pfeffer", false, null, "Henrietta.Pfeffer2", null, null, "AQAAAAEAACcQAAAAEApj3UyFbXTBKVY9/suOMezylPpOg06mY7lqCzqR+mRcBh7+h4Mi+65pSk7bflXKwA==", null, false, null, null, 1, false, null },
                    { new Guid("b7065d5a-6bbd-485c-bd51-6a4a0fc35e18"), 0, null, 519.5895789196710000m, "f09dfd88-8b88-48ab-8053-87dd3824e50b", null, null, null, false, null, "Louise", "Lind", false, null, "Louise.Lind92", null, null, "AQAAAAEAACcQAAAAEMxXxrPS0oiHklHye2bwbEVb6oMhAk3eHSAXgPSadFGe3xiKx0JLIECzqQoeYDY/Hg==", null, false, null, null, 2, false, null },
                    { new Guid("b72dbc44-743b-4e39-a250-af429c1f09a9"), 0, null, 173.2542937280850000m, "44587273-7f61-4fe2-9863-f3e5b3ebd292", null, null, null, false, null, "Everett", "Thiel", false, null, "Everett.Thiel75", null, null, "AQAAAAEAACcQAAAAEOeR7eflchj8CiAOizeDixuW4AHjx9Gx5bEq56M6lQack4Jj2utsK8Pvb7kjQv1ivg==", null, false, null, null, 1, false, null },
                    { new Guid("b7f7d261-2525-4477-8b55-bba019231e9f"), 0, new DateTime(1980, 5, 8, 19, 30, 22, 313, DateTimeKind.Local).AddTicks(8178), 873.7446150312570000m, "80c0b481-2e7f-4aff-b644-d02e11aaae60", null, null, null, false, "Jacqueline", "Jacqueline", "Hyatt", false, null, "Jacqueline_Hyatt18", null, null, "AQAAAAEAACcQAAAAEHeO1UvOBnxxSTWje3iM/0qS44DVpLH9hQDWQcbMj1ISL6y6zxX4ZhMqt0vPkbzC5w==", null, false, null, null, 2, false, null },
                    { new Guid("b89fe956-f020-4fc2-affd-e06c759e4081"), 0, null, 101.9271347056920000m, "ec3a079d-ffa6-4142-be6f-a5f2c7e8872c", null, null, null, false, null, "Edwin", "Hand", false, null, "Edwin23", null, null, "AQAAAAEAACcQAAAAEBwbjA9J1jy9MtJ8n7D3ANdrWZwveov8gqOgR026Uo9Smyzj0CFycecME0IHSHeZzw==", null, false, null, null, 0, false, null },
                    { new Guid("b9a99c94-3031-4da9-bdf3-33bb288dd6a9"), 0, null, 578.7401723420480000m, "1f224e62-ec09-463b-839f-4f065a52e6f8", null, null, null, false, null, "Drew", "Braun", false, null, "Drew_Braun", null, null, "AQAAAAEAACcQAAAAEFzn5Le4+Z+68zAMtRjtAtaeOWTycEVSUgnJ0ePjXtY9ze1Qi1XClE3HbTffeG48lg==", null, false, null, null, 1, false, null },
                    { new Guid("bb021ddc-2731-4d61-8069-ddee5e7759da"), 0, null, 435.3186710823530000m, "5d31d932-8e31-4ed9-9fa9-c8ece66ad4f3", null, null, null, false, "Guillermo", "Guillermo", "Borer", false, null, "Guillermo.Borer", null, null, "AQAAAAEAACcQAAAAEEtI35iGZwUIu0EkVe9jm/Mo5Kn0ZDcsvipar+kXRcGxfZ4qq+T8O4tSJNTrCrZOJg==", null, false, null, null, 2, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "Email", "EmailConfirmed", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("bb486a22-0b19-4077-b9ae-8415f7b0c807"), 0, null, 863.3222964318420000m, "d589b908-2ade-4c76-b45e-562d0729c75d", null, null, null, false, "Amos", "Amos", "Kub", false, null, "Amos.Kub", null, null, "AQAAAAEAACcQAAAAEEEK4mTZRfjQOp1q4o/9uaDvffLABeoZlFaqhQtcRlGC7slLccFrbiJCqv6QQTxlMA==", null, false, null, null, 1, false, null },
                    { new Guid("bdc35340-f998-4d2c-9ebc-c29624582c95"), 0, new DateTime(1927, 4, 15, 2, 1, 30, 906, DateTimeKind.Local).AddTicks(2852), 541.1904330274450000m, "192ee432-6f8d-4489-8590-8a5720e73757", null, null, null, false, "Lindsay", "Lindsay", "Bahringer", false, null, "Lindsay_Bahringer", null, null, "AQAAAAEAACcQAAAAEOp15kmKvMfKd3fCrp2ugNytBRzez2BYYWIgUjPKKsu06f5Q2VuIkvdj0bQcVpRQjg==", null, false, null, null, 1, false, null },
                    { new Guid("bdd49191-641c-4843-a442-069a71c65be5"), 0, null, 913.6963567584870000m, "8da88ea3-d9dd-4cc9-a9e7-cf805ceb5ff0", null, null, null, false, null, "Melvin", "Kuhlman", false, null, "Melvin60", null, null, "AQAAAAEAACcQAAAAELdbwxqVzoWZ5URNxzAxnSrzh7Ca1mFmTIDBZcbQZyci82ZhIfFJx6PLBDKyoTA08g==", null, false, null, null, 1, false, null },
                    { new Guid("bfb2c3f3-d581-43c3-ad34-2b9af77e293a"), 0, new DateTime(1965, 9, 21, 20, 4, 33, 501, DateTimeKind.Local).AddTicks(9597), 909.4564071710280000m, "8a57c635-8af2-42ca-ac58-789b77420837", null, null, null, false, null, "Cristina", "Douglas", false, null, "Cristina.Douglas", null, null, "AQAAAAEAACcQAAAAEMJLQSACa67kHTb4GBk/97osXr79jxUxJKm+sU4K0kBGbi8ngZ+ws+EKNB62MKCwWQ==", null, false, null, null, 0, false, null },
                    { new Guid("c0159440-683d-4c76-a904-aa1f4564822f"), 0, new DateTime(1926, 5, 10, 4, 40, 26, 767, DateTimeKind.Local).AddTicks(8907), 0.3592793771612920000m, "2f5f3c9b-67c1-4852-b203-184829467fb9", null, null, null, false, null, "Ginger", "Fadel", false, null, "Ginger65", null, null, "AQAAAAEAACcQAAAAEKWFkikhm8RzmBJJPPE6ba/FAB8ntnAlFjlJTd/AsuRikyjSQ+klwuVHt0BBzbNuJQ==", null, false, null, null, 0, false, null },
                    { new Guid("c075bfdf-a5cc-4efb-a6d1-f31b0c4bf344"), 0, null, 208.4895673250710000m, "787a1d4d-8e79-4c4b-b6ea-1726af27555c", null, null, null, false, "Randall", "Randall", "Stoltenberg", false, null, "Randall_Stoltenberg13", null, null, "AQAAAAEAACcQAAAAEEt8uIhLUu5T2PH9pFEwAw8Y9z1fv/qqGfCqKcCRuqVxpC5yGcbrQLrdTnhDDnacng==", null, false, null, null, 2, false, null },
                    { new Guid("c1169f01-6528-4f74-aa56-802f48a7ece8"), 0, new DateTime(1965, 4, 20, 22, 1, 24, 522, DateTimeKind.Local).AddTicks(6888), 584.0867818160710000m, "e3aaad2f-8b67-4eba-b53a-1049030cd2cc", null, null, null, false, "Sheila", "Sheila", "Ankunding", false, null, "Sheila.Ankunding", null, null, "AQAAAAEAACcQAAAAEEUagPAImvHZESbvY9kBQqCNgc3ruTkcajauTKyXjmCyWUYKbwdji/PSGBFOFZ0INg==", null, false, null, null, 2, false, null },
                    { new Guid("c2edd12d-5919-4c5c-b18f-3b1ef2ea8f55"), 0, null, 421.1443056678930000m, "579765d4-cfd7-4584-afa4-1846ddd3ca7b", null, null, null, false, "Lamar", "Lamar", "Bayer", false, null, "Lamar_Bayer30", null, null, "AQAAAAEAACcQAAAAEHubg/EzUrRLpd/HpL0wPASvc0zlPscJK+ZQNJcc2imVCWJnITdI5bOjyWOoSmWAqQ==", null, false, null, null, 1, false, null },
                    { new Guid("c4b80142-93ac-41b3-b29d-ff4cad905327"), 0, null, 807.0554444196140000m, "f922e64c-f3a5-486d-a1ec-b8002243e22f", null, null, null, false, null, "Clint", "Spencer", false, null, "Clint5", null, null, "AQAAAAEAACcQAAAAEGLH7Gm8EqRujM0xLE1qajr4iODQ6uf9TEjeAQGN6UNMppC/BJWbThsDWf1+EzsGYA==", null, false, null, null, 1, false, null },
                    { new Guid("c4ec53d7-69be-4d5d-9091-29c7f80bd641"), 0, null, 941.3781625100690000m, "d729261f-1d3c-4ab4-a3c9-88bf98cc3f69", null, null, null, false, null, "Jerry", "Pfeffer", false, null, "Jerry.Pfeffer89", null, null, "AQAAAAEAACcQAAAAEL5h0NKqQchHf1PCN6M7sD+2P+KnGfwmyVVlmTFJJT4xTue2lq/qVfCrie1peVTZEg==", null, false, null, null, 2, false, null },
                    { new Guid("c6c5dcc4-cc8e-4484-935f-918264ee4897"), 0, null, 957.5730941734780000m, "6e489f4a-eb9e-4202-ae58-a9d02f2897cd", null, null, null, false, null, "Tommie", "Adams", false, null, "Tommie_Adams1", null, null, "AQAAAAEAACcQAAAAEN0GXX7wjHaYZux1KxLjg9RrIQZOiixhZR0IgWe73Ac9ZWgK3cFozX40yQcjeAETdQ==", null, false, null, null, 1, false, null },
                    { new Guid("c6d62b30-8c4e-444d-a56a-cf5bea9f9c2a"), 0, null, 756.27952595920000m, "a0bf98a4-775e-4dda-b188-47324c97bcd8", null, null, null, false, null, "Dale", "Nicolas", false, null, "Dale_Nicolas91", null, null, "AQAAAAEAACcQAAAAEGFRoNucginQPxfJsh5QmuGtyR7TZOHmfPD5y021pIjIuhDcgEBF7/YY018mjhGMaw==", null, false, null, null, 2, false, null },
                    { new Guid("c78c659a-335a-4de3-940d-5ed29586f5d9"), 0, null, 785.7507545136920000m, "2d5d9e1c-7187-49df-94f9-abf82dc972eb", null, null, null, false, null, "Marianne", "Schaefer", false, null, "Marianne.Schaefer", null, null, "AQAAAAEAACcQAAAAEFD+CYTZ2ILb3hBvvaybLlnqkfagor/AD2Eu+x0GLaBoFosMypWdE6Dv98L+TgjqHA==", null, false, null, null, 1, false, null },
                    { new Guid("c7f2884a-d2aa-4aeb-80a7-44ed5d29e64a"), 0, new DateTime(1925, 12, 20, 8, 32, 51, 345, DateTimeKind.Local).AddTicks(8923), 179.7907662436180000m, "f0f86a4d-106e-4c04-9f0b-81e7a24730d7", null, null, null, false, null, "Gerardo", "Welch", false, null, "Gerardo_Welch", null, null, "AQAAAAEAACcQAAAAEAW2ogCZ5pItKSbEKLJ4W3fxf6NhnGimI/UGWBFb+RYTJLXT2L1mFeneWSUsHl7wYQ==", null, false, null, null, 0, false, null },
                    { new Guid("c864b34c-ddf5-4af6-9a5f-d8251c512e8f"), 0, null, 218.0505938660770000m, "8f43e28f-661d-4a78-b68d-3d7d1da8280d", null, null, null, false, "Marion", "Marion", "Ward", false, null, "Marion87", null, null, "AQAAAAEAACcQAAAAEKQgaV6oKfufFidcxYIJpIMDFKjXWz/gbsr1H56MfB2bAJRq4aCQhu7UU5MvII7WHA==", null, false, null, null, 2, false, null },
                    { new Guid("c9b88753-217a-4bb2-ac30-4bed75d66c61"), 0, null, 341.1628542481470000m, "3b05d410-a064-4b11-b20c-96a76b95163c", null, null, null, false, "Alfredo", "Alfredo", "Leannon", false, null, "Alfredo.Leannon90", null, null, "AQAAAAEAACcQAAAAEIQiOyVFn05cUWVpdxrMZFJ8wzURkdH7CuikHCyCtdipMSgfH9NC7/se9tVpMDfkaQ==", null, false, null, null, 2, false, null },
                    { new Guid("cc019092-2135-4dea-b991-c8b67614f148"), 0, new DateTime(1929, 3, 12, 20, 16, 51, 964, DateTimeKind.Local).AddTicks(4213), 717.7668353762550000m, "c3b5a1d8-33f8-455a-8c8c-ebbbaa2d695b", null, null, null, false, "Linda", "Linda", "Kuphal", false, null, "Linda.Kuphal", null, null, "AQAAAAEAACcQAAAAEGhkYcTtkp8mRsjhJEeK7amBsYwgL7+YNqm8Xf9/XuFD8SJCyeNPmC8WYtk26tB82g==", null, false, null, null, 1, false, null },
                    { new Guid("cca9c534-e77c-400e-a849-210326576f8f"), 0, null, 979.1780116530870000m, "026d5f99-1062-4bef-9616-9daa04196922", null, null, null, false, null, "Kelly", "Fisher", false, null, "Kelly.Fisher", null, null, "AQAAAAEAACcQAAAAEM8T4qz3nmmmOTHb4ebmsjzYx+JbcR5/aoMBny93Cv8UptYX8yon+Gc5UNHX3VdO4Q==", null, false, null, null, 0, false, null },
                    { new Guid("cd6370e2-d6d7-4cbd-aaac-c3cf98e8cec3"), 0, null, 826.792421427390000m, "cce80fae-26b4-4862-bad6-80e9d73ae679", null, null, null, false, null, "Tiffany", "Morar", false, null, "Tiffany_Morar", null, null, "AQAAAAEAACcQAAAAENBlnWD3DloojeeCA6VvRElOaRXQowaPuSmwWdkDJJiUW1oLPOxgUzOHbYdy4Tp0pg==", null, false, null, null, 2, false, null },
                    { new Guid("ce108172-f4b7-4653-a5c3-ff603fbc3a50"), 0, new DateTime(1962, 7, 2, 10, 10, 59, 830, DateTimeKind.Local).AddTicks(6945), 2.275582693132770000m, "2e49c97d-ee6c-4f86-a099-7fae1b36e372", null, null, null, false, null, "Hugo", "Bernhard", false, null, "Hugo.Bernhard", null, null, "AQAAAAEAACcQAAAAEG/Q9PjzcIPFJRdbd7r+kVi37YlS+F6otlaO2HWFmDMmTvl5G1ig4mK9AwUfNYdirA==", null, false, null, null, 0, false, null },
                    { new Guid("ce3412db-b24b-4f68-8e32-724c140b7d0a"), 0, null, 473.0049119406020000m, "d2fa6d2c-7f20-46df-b9ce-62a315a8ca2b", null, null, null, false, null, "Ismael", "Rogahn", false, null, "Ismael61", null, null, "AQAAAAEAACcQAAAAEM4VjwnnVFbtPJd0fYrs3wun2sR3aY1bSan+F77XGER/JlGYFRuGKG/Ep17yPZJuqA==", null, false, null, null, 1, false, null },
                    { new Guid("cffc8c5c-aee1-43fa-a247-e83b10ecb56e"), 0, null, 515.3566405887560000m, "f7ae4aee-e574-4a81-8eac-a05915e68515", null, null, null, false, "Teri", "Teri", "Jenkins", false, null, "Teri25", null, null, "AQAAAAEAACcQAAAAEHvpJObgzLNqQS+2rSMBLb472kPU4dnbqUAy0pN3+8nNDOb11aYKIRQMOm3vhIUiCQ==", null, false, null, null, 0, false, null },
                    { new Guid("d02ec5f5-af87-4bcb-954a-b24e23737d68"), 0, null, 776.7081477516930000m, "1d652a84-1996-4b05-a4ee-20b2f2835f71", null, null, null, false, "Erick", "Erick", "Rogahn", false, null, "Erick_Rogahn53", null, null, "AQAAAAEAACcQAAAAEK5ff4aTP7xyvA/reItLSMA9qnB7nkQR0/c+ceDVXA9aGhfxFLwqU7MGdt3EB6JiVQ==", null, false, null, null, 0, false, null },
                    { new Guid("d173c22f-aa53-4e3b-b137-bcd6d2faf814"), 0, new DateTime(1931, 10, 26, 2, 5, 44, 949, DateTimeKind.Local).AddTicks(5623), 354.4615891034520000m, "a9d5a93e-c780-4f18-a9e8-7a5f44c7d7b5", null, null, null, false, "Kirk", "Kirk", "Walker", false, null, "Kirk2", null, null, "AQAAAAEAACcQAAAAENt/jRwxvFHulSEPoeqBTMgPl+oy+L0OdcTaEJo6driJlJWMedWqK2/epikgqV+Dag==", null, false, null, null, 0, false, null },
                    { new Guid("d50ea512-4841-4fdb-b6f1-1805a1f266cc"), 0, new DateTime(1963, 8, 20, 11, 9, 30, 393, DateTimeKind.Local).AddTicks(5859), 236.0741784493470000m, "b77dff18-76cf-4ec8-96df-b61e9f03b13c", null, null, null, false, "Elizabeth", "Elizabeth", "D'Amore", false, null, "Elizabeth.DAmore97", null, null, "AQAAAAEAACcQAAAAEC0Q6uYe3+69iRvs/+lU+wjRsY3Hs6cNnyvyDHdBr80564/RKlDLdsQaZmXRykUcHw==", null, false, null, null, 0, false, null },
                    { new Guid("d52df32f-0260-40eb-8234-13ab7a744fcb"), 0, new DateTime(1983, 5, 28, 10, 3, 21, 206, DateTimeKind.Local).AddTicks(5501), 746.8130243610460000m, "26b7b39c-b1b4-47cd-8058-d998036df45c", null, null, null, false, null, "Erma", "Bogan", false, null, "Erma.Bogan88", null, null, "AQAAAAEAACcQAAAAEJ0QHRgAFzywHFIKbVIP8zp642QMpiboVQUpr31lA2GXi4395ygw2yXqGr23jVUbuQ==", null, false, null, null, 0, false, null },
                    { new Guid("d572b4d3-7e7c-44d5-b1d1-164c1895424b"), 0, new DateTime(1996, 9, 25, 1, 12, 31, 923, DateTimeKind.Local).AddTicks(2538), 340.8048666784060000m, "fbf057ca-5459-4087-bc42-8e0f719875f5", null, null, null, false, null, "Elvira", "Boehm", false, null, "Elvira.Boehm", null, null, "AQAAAAEAACcQAAAAEAtjycuNk7qfI4OajoBqBV+IMhvl0YLlUrW56oh2wc6XEXqUyq212eqJo1gAXxBBrQ==", null, false, null, null, 0, false, null },
                    { new Guid("d62fe5e3-4821-411a-b458-87e89f41f2f1"), 0, null, 10.95509862003420000m, "71689f92-a650-4017-bd27-0c4e9cad6696", null, null, null, false, null, "Rickey", "Shanahan", false, null, "Rickey.Shanahan54", null, null, "AQAAAAEAACcQAAAAEOVrWLs0TEX5kbxkG/9lIyRNsbo+9KiaDaBsun6UGrOdGsfQ7okaaFYRUCtDyy267Q==", null, false, null, null, 0, false, null },
                    { new Guid("d6f2753c-e864-40f4-a45e-4096737598aa"), 0, null, 334.3145208344160000m, "0468454d-6256-4bf2-82f4-dfa885580c47", null, null, null, false, "Madeline", "Madeline", "Lowe", false, null, "Madeline_Lowe", null, null, "AQAAAAEAACcQAAAAEIliLyi4hE9rLylx+E63CQu8P3ujaIxXaRh4dcxDNjtlUX4lCv+bRM8wd7cXp7HUQw==", null, false, null, null, 0, false, null },
                    { new Guid("d799d7ce-936a-414f-86fd-958f17b3f642"), 0, null, 301.2220395057450000m, "51bee014-0051-4ce0-b036-5fafdfcc2edb", null, null, null, false, "Van", "Van", "Bayer", false, null, "Van.Bayer7", null, null, "AQAAAAEAACcQAAAAEC/1JSYaDLS03PmldI0+ehkAEMbKRfo/EDcAgHK1ZOPKQfaq1psQzPoDezmuz1+7CQ==", null, false, null, null, 2, false, null },
                    { new Guid("d9b74426-c418-4b51-a42a-af5906c2fcff"), 0, new DateTime(1950, 7, 16, 2, 3, 23, 526, DateTimeKind.Local).AddTicks(2635), 367.7481908697570000m, "b861f3b2-af3a-4702-a32e-bf109dc64532", null, null, null, false, "Lela", "Lela", "Crist", false, null, "Lela_Crist62", null, null, "AQAAAAEAACcQAAAAEImgrd4Spi5xcFUjgVSdDogk7DRbcQvwThPu5/4EN0KG33CnNd/BFtBJqXxUHUYfEg==", null, false, null, null, 2, false, null },
                    { new Guid("db7dd226-4232-45fe-a502-06e0dfd99b42"), 0, new DateTime(1957, 6, 13, 8, 17, 1, 540, DateTimeKind.Local).AddTicks(5434), 831.4121509992480000m, "df26e812-7088-44a9-b6ef-ee531814a4c7", null, null, null, false, null, "Jamie", "Stehr", false, null, "Jamie_Stehr43", null, null, "AQAAAAEAACcQAAAAEHrNHi2wpNl6OfEVg/fXIq1W5kUbC9GXGH4KlJQym4AvJWaJE+NBS2FeWYlnt/R0Wg==", null, false, null, null, 2, false, null },
                    { new Guid("db9ac887-f173-4f7b-ad02-6d19fdd7b12e"), 0, null, 377.8886970331490000m, "074a76da-5db2-4a93-b913-dc9a63afbb30", null, null, null, false, "Jon", "Jon", "Bruen", false, null, "Jon_Bruen86", null, null, "AQAAAAEAACcQAAAAEPVeR/DL8aG+Hj5RI36TCvQFWvpBpZmyM6MZQnGmggaWB51hZQ5BVvRqgcNYXiJCJw==", null, false, null, null, 2, false, null },
                    { new Guid("dca6b19f-e9ff-4d07-b3df-fe7e57f8b960"), 0, null, 279.2832762130810000m, "d9ded58c-fda5-4dd1-8f6b-255398695c11", null, null, null, false, null, "Renee", "Stoltenberg", false, null, "Renee43", null, null, "AQAAAAEAACcQAAAAEC1CRxb6sZerRmFfzk4RMTekdItKOkd/aHiwYfyBZ45JPlX36l8tANA57mkQva6CCA==", null, false, null, null, 2, false, null },
                    { new Guid("dda60091-f993-4d23-997a-ac4774d856d5"), 0, null, 178.2916700222750000m, "251fe9a0-5314-4c8e-9482-7e8c387a6dd1", null, null, null, false, null, "Melba", "Hettinger", false, null, "Melba82", null, null, "AQAAAAEAACcQAAAAEK61OHblWEw2+DL+XRKRA0qkEj3MmyIQ/MdNraFPlr7Cet60MlOcjipZH+9kMuydiw==", null, false, null, null, 1, false, null },
                    { new Guid("ddf155f2-6984-4582-b06c-39700b8ecb92"), 0, new DateTime(1949, 11, 22, 21, 24, 39, 550, DateTimeKind.Local).AddTicks(9373), 672.3824013626870000m, "efaffa62-731d-428e-9996-97cfa77b67aa", null, null, null, false, "Gregg", "Gregg", "Lueilwitz", false, null, "Gregg47", null, null, "AQAAAAEAACcQAAAAEPqu/T9D2Shf7wFuc1LH3t4tXcGabONMV245dK9p7LiipTUt/b9UzBqNrr3Qm8GnYQ==", null, false, null, null, 1, false, null },
                    { new Guid("df2bde0b-bda8-499f-b5cc-cfa7429222d1"), 0, new DateTime(1979, 5, 17, 4, 12, 10, 511, DateTimeKind.Local).AddTicks(3959), 210.5401802905860000m, "3123f709-0af5-4f55-98cb-a24f98f5f1e5", null, null, null, false, "Justin", "Justin", "McKenzie", false, null, "Justin.McKenzie57", null, null, "AQAAAAEAACcQAAAAEF9KqampJKDyC5nnkkbZw6X6/8OUSZhgVaQN0D5PcOHW+iXkyqTaeAmLvAExpzQIpQ==", null, false, null, null, 0, false, null },
                    { new Guid("e0518a7c-2290-4dde-8de0-19fe26c3d8fa"), 0, null, 971.2529838919540000m, "149d92a2-0883-43a1-b687-36d0bfef23e3", null, null, null, false, "Luther", "Luther", "Balistreri", false, null, "Luther.Balistreri74", null, null, "AQAAAAEAACcQAAAAEFyuM/Obb6tGDzQ4+keTwZm7L6DH9iGTGsLkNRBlEPw+iOyBBMbqW6vYZWGdCw75ZA==", null, false, null, null, 0, false, null },
                    { new Guid("e135b016-8e68-479f-a8e6-0c1dd16d5c2f"), 0, null, 66.77070466747730000m, "5f31022d-5a68-4ae4-924f-af4ed70d8e0e", null, null, null, false, null, "Patty", "Altenwerth", false, null, "Patty_Altenwerth90", null, null, "AQAAAAEAACcQAAAAEDsUAJ1JVG7ccB9Mb2Y5VraP2NyKdwnjrBu+8R6wXwdhcGua/svl547pw7jwZuUTcg==", null, false, null, null, 0, false, null },
                    { new Guid("e2fd10a1-4989-4088-ae2b-0b5909314728"), 0, new DateTime(1976, 8, 21, 9, 26, 32, 752, DateTimeKind.Local).AddTicks(2847), 266.3634544790470000m, "76d61d4f-877c-46fa-8ab4-cffce1b3c458", null, null, null, false, null, "Matthew", "Schmidt", false, null, "Matthew.Schmidt", null, null, "AQAAAAEAACcQAAAAEF2gndpA+L2zHYwuqu3JGwpwSqyF+4igYO/uT+sMa0VkQvAfJ61PZhUYdnbQ/z7H0g==", null, false, null, null, 2, false, null },
                    { new Guid("e6fc9f3f-e447-488c-a497-0bec2a6f9fea"), 0, new DateTime(1977, 9, 9, 18, 45, 22, 201, DateTimeKind.Local).AddTicks(8453), 105.0952140615460000m, "a4022b02-8496-4bae-998a-fb7acd016443", null, null, null, false, "Michelle", "Michelle", "Schmidt", false, null, "Michelle_Schmidt25", null, null, "AQAAAAEAACcQAAAAEMjsOPjt+ZCtgYWkMtppAQfqnimWuWBUzsmiPOweafRuLkgAxKnAXPWdyMjr7Y3pNg==", null, false, null, null, 0, false, null },
                    { new Guid("ea67b8fa-bc9a-4e27-8ba5-f3c2359c883a"), 0, new DateTime(1988, 9, 10, 11, 28, 45, 722, DateTimeKind.Local).AddTicks(6766), 762.8327169195960000m, "52d1a731-beff-4a7f-9dcf-f46cd06ffc6f", null, null, null, false, null, "Sophia", "Hickle", false, null, "Sophia.Hickle", null, null, "AQAAAAEAACcQAAAAEJUSoAC77K5a7qO9gPKTq399e4pKptMbmbOhgwVFcmLImXpgolZ/yLUXnQQ6W+SsSA==", null, false, null, null, 1, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "Email", "EmailConfirmed", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("ea94f56c-ef76-423b-81af-2da80b37dfa6"), 0, new DateTime(1968, 5, 22, 15, 24, 24, 981, DateTimeKind.Local).AddTicks(7764), 684.5649972920280000m, "ed064671-873c-45b3-b93b-9a496b9a782b", null, null, null, false, "Garry", "Garry", "Stroman", false, null, "Garry.Stroman72", null, null, "AQAAAAEAACcQAAAAEPGBrLpbQtEEtIfGkwQvFt7kW+trOYBbRF2Z1A033tBZQ+Y+J8ryyt0Qoy8lIC32yw==", null, false, null, null, 0, false, null },
                    { new Guid("eac06870-6688-4254-bca8-fa7f08d81e32"), 0, null, 344.2572009867980000m, "35d9897b-eee5-4a50-b187-394a548565cd", null, null, null, false, null, "Ann", "Altenwerth", false, null, "Ann.Altenwerth8", null, null, "AQAAAAEAACcQAAAAEP8SuSon6UpIwGn0s18w8RKprJtVUNRr5KFXqk7FrtqS7/CQqFBwPVMbzxpQ34NQDg==", null, false, null, null, 0, false, null },
                    { new Guid("ebc46bc5-40b3-40f7-b23b-cc974fa9b051"), 0, null, 986.817770553380000m, "8f025152-69cb-47dc-a41b-55aba7a4c593", null, null, null, false, null, "Vicky", "Cummings", false, null, "Vicky98", null, null, "AQAAAAEAACcQAAAAEHiX4s6D4LAN3AiLWwuJ3bqnHWIYATjCJjFgvEZ/K8kzwaxFOCCEl5w0Q4oR8NHcLQ==", null, false, null, null, 0, false, null },
                    { new Guid("ebecc10d-21da-4369-81d7-600c2de48f88"), 0, null, 145.5416771145590000m, "b48f3c77-9be0-4123-bbb2-426d65060a2c", null, null, null, false, null, "Jamie", "Rolfson", false, null, "Jamie.Rolfson26", null, null, "AQAAAAEAACcQAAAAELEErGTnHEt4ECdzz9eK5P/SEoeuzHHbohuFt+ohZ4SV1LrOxtbydq065t3p7GzW/Q==", null, false, null, null, 2, false, null },
                    { new Guid("ef8bcbb3-fff2-4f2c-aa48-9ad3e0312130"), 0, null, 262.7333565922670000m, "a0bd321b-91a1-4075-8a84-20b5e4a036d9", null, null, null, false, "Rosie", "Rosie", "Marks", false, null, "Rosie.Marks", null, null, "AQAAAAEAACcQAAAAELsjtTomQaHS9xVJLgLD3d73NBZAjhNW0CWkyxxdfsKq9/02lklhrMEYsrwXofQAgg==", null, false, null, null, 1, false, null },
                    { new Guid("efacb463-5422-4958-902a-44c5cd16f26b"), 0, null, 423.7073143509440000m, "962e04a6-a653-4d22-83f6-95caed79a851", null, null, null, false, null, "Karla", "Beatty", false, null, "Karla43", null, null, "AQAAAAEAACcQAAAAEHOObTS8cxv+eFIMv8pATzaiPSbF5U9LXiSZq/zyTgs8AkT+oKjJQY/gqQpaguSuIg==", null, false, null, null, 0, false, null },
                    { new Guid("f070ec16-f59a-41c8-8ab6-b492f05b08e3"), 0, new DateTime(1984, 9, 15, 4, 33, 32, 983, DateTimeKind.Local).AddTicks(582), 589.61544115330000m, "2120fda0-0786-48e8-beb7-cfb0d0bdbc84", null, null, null, false, null, "Roman", "Witting", false, null, "Roman_Witting21", null, null, "AQAAAAEAACcQAAAAENSMQvAy+QQSUfA8oUYX3bYA0ciWS7u9Vb4w5WlEeYdw0lceQSzdAvCkcZOxs2hoXQ==", null, false, null, null, 2, false, null },
                    { new Guid("f088f668-331b-405e-b41a-5cc648df081c"), 0, new DateTime(1997, 11, 30, 14, 9, 2, 612, DateTimeKind.Local).AddTicks(8859), 634.7173340682520000m, "87ad0f6b-32b3-4dc9-9279-560703835592", null, null, null, false, null, "Bonnie", "Stamm", false, null, "Bonnie.Stamm83", null, null, "AQAAAAEAACcQAAAAECCkRvZxUjyXgGK8yI/BZdZvZKeMIl9lTJjiojPmcLj0jZvAp5++Xz7doRPsdbBwtw==", null, false, null, null, 0, false, null },
                    { new Guid("f2fc34d0-f967-4d49-ac54-2191c244d200"), 0, null, 574.5187811444010000m, "e0a9212f-9a0d-41bd-8e69-f3850b759ba2", null, null, null, false, null, "Warren", "Effertz", false, null, "Warren.Effertz", null, null, "AQAAAAEAACcQAAAAEASGH0dVFDLSB8NfdwFv9l0Fwm89zIDM8ma+i4EH0S5TybTh5GvInub6HkuQ9WspVw==", null, false, null, null, 0, false, null },
                    { new Guid("f3a37729-6cc8-4507-9aa5-d44c334bc0a7"), 0, null, 816.8761526513440000m, "55bbb1fb-32f6-4268-834a-c1ef9451ac9e", null, null, null, false, null, "Lorena", "Becker", false, null, "Lorena_Becker", null, null, "AQAAAAEAACcQAAAAEIBp7DVjD5nWI9Dcn4ZMooatMTFreRgJjVoqcmKogqlquZPPsjMVqvzLEtTO9r242g==", null, false, null, null, 0, false, null },
                    { new Guid("f3ea0004-e1e2-4557-a9d5-14a5369a2eb3"), 0, new DateTime(2004, 9, 10, 1, 16, 34, 683, DateTimeKind.Local).AddTicks(2439), 201.1979225146590000m, "e51c0c7f-2127-4316-b982-36f29ecb6dd6", null, null, null, false, null, "Freddie", "Blanda", false, null, "Freddie.Blanda98", null, null, "AQAAAAEAACcQAAAAED9axj9E7RZ8THDQzeFu4kbOG5lD4ZVjYgFzE78XbQToYLThLuzVLIk74t3HjEampA==", null, false, null, null, 2, false, null },
                    { new Guid("f4909d03-d7ac-4aaf-a6fe-77a88f9fe06b"), 0, null, 632.9643554208510000m, "736ad307-13e4-4eaf-b07b-898a427aa6eb", null, null, null, false, "Geneva", "Geneva", "Jones", false, null, "Geneva_Jones", null, null, "AQAAAAEAACcQAAAAEGwriXE4+gn+3TQy+A4VdE2MiUV/aw0FjWXxRBdOhlJE6KygwLBRKPcYwJqu9BZ9+A==", null, false, null, null, 0, false, null },
                    { new Guid("f498a63d-900c-464a-8fab-e4232968dc8b"), 0, null, 16.73835306403180000m, "127e179b-f085-41f2-a7f0-0b64da169e33", null, null, null, false, null, "Shirley", "Zieme", false, null, "Shirley.Zieme", null, null, "AQAAAAEAACcQAAAAEEl10RQOLKbbATXY573MBe7T+hw/0eB6wdgZWTsD9vvVyJLPsSe6O971WkjDkaNGJw==", null, false, null, null, 2, false, null },
                    { new Guid("f5193487-04f8-4c23-b0cd-90340ebc9154"), 0, null, 335.53681417290000m, "e2038315-769c-47ff-a567-785437b05e33", null, null, null, false, null, "Clarence", "Hickle", false, null, "Clarence_Hickle", null, null, "AQAAAAEAACcQAAAAEJGMGvDIVWiRxMmusnvkkTHU7lxjoqZf8gBcKykQpDZk6MvXnHA/nlXHS93Yxovgvw==", null, false, null, null, 0, false, null },
                    { new Guid("f52649ec-b9d7-4f35-8295-ec4e2b5c564c"), 0, new DateTime(1991, 2, 21, 6, 19, 12, 493, DateTimeKind.Local).AddTicks(2915), 471.7449197797370000m, "4c798fc0-d959-4c5c-b340-e49becfbac03", null, null, null, false, null, "George", "Waters", false, null, "George34", null, null, "AQAAAAEAACcQAAAAEHFyRMj8/tu1KPHJJngryDs3w+aBPI1sZrPlKFpxmG8U5SlM0EUkcFgtkHtxw2e5pQ==", null, false, null, null, 2, false, null },
                    { new Guid("f57190db-67c4-4d7b-9cd1-c8e27a6ac561"), 0, new DateTime(1983, 10, 23, 19, 38, 39, 492, DateTimeKind.Local).AddTicks(5000), 599.5861938397090000m, "f5dd8137-3297-4b6c-be1f-d848986d7337", null, null, null, false, null, "Hector", "Boyle", false, null, "Hector45", null, null, "AQAAAAEAACcQAAAAEDPir/wVbnNBG2yU6HUpkPTRq8PL1BqHr92kNnwuUHZ/lj2Zy8uyuyTTjKC+64LlIA==", null, false, null, null, 2, false, null },
                    { new Guid("f78b821b-0629-4e64-a36a-3d10ad04e07a"), 0, new DateTime(1993, 8, 2, 19, 5, 21, 885, DateTimeKind.Local).AddTicks(3836), 640.3402510196870000m, "44726a36-9f02-4846-940c-6f6db2933ad0", null, null, null, false, "Katie", "Katie", "Littel", false, null, "Katie15", null, null, "AQAAAAEAACcQAAAAEJQy20HS8lPMwdMyIjEJm2QOYkEWO1lYIMoDK92itGIRiQbdQW2FH/XAIyinosDl+g==", null, false, null, null, 2, false, null },
                    { new Guid("f7ba49ab-b88c-4490-8dc0-4a731ec11ec3"), 0, new DateTime(2003, 4, 17, 23, 45, 52, 170, DateTimeKind.Local).AddTicks(8251), 671.3108360185250000m, "c6b8c3aa-78af-43bb-8c86-a85b2e21170a", null, null, null, false, null, "Marianne", "Swaniawski", false, null, "Marianne_Swaniawski", null, null, "AQAAAAEAACcQAAAAEJMtjhVKASXaYZ/+/AYuQ6LIwSPW46ne7mDfglthC0IpkfV2ArBP4JEtQk70HFdK7A==", null, false, null, null, 0, false, null },
                    { new Guid("f7e08701-d57e-42d3-884d-beb04dee4c45"), 0, null, 706.7155347639770000m, "b80d17c7-8bca-4c5f-a731-7241b6035d3a", null, null, null, false, "Virginia", "Virginia", "Purdy", false, null, "Virginia.Purdy", null, null, "AQAAAAEAACcQAAAAEGo301eBJy6Z3JmUcoyDhbLD3tV/2uoBwQULjtKz9nrrARYKxiy7EZhSdvP7P6b1Hg==", null, false, null, null, 1, false, null },
                    { new Guid("f7effd3e-f620-479e-861c-7fb6220a3843"), 0, new DateTime(1980, 5, 5, 22, 10, 6, 70, DateTimeKind.Local).AddTicks(572), 9.32801345244150000m, "ee055e21-0262-43c8-bc0d-cde176c1c2f9", null, null, null, false, "Joe", "Joe", "Mraz", false, null, "Joe.Mraz75", null, null, "AQAAAAEAACcQAAAAEII+i1rovZq/tSlf4wZrwv8ybhVxrPAuVBgwQ3WC/wAMX+vvw9Zklhi/UXtRtmvJ4w==", null, false, null, null, 2, false, null },
                    { new Guid("f7f5e0b6-df15-4f10-b87e-6503c5e8fb8e"), 0, new DateTime(2001, 8, 30, 9, 23, 1, 901, DateTimeKind.Local).AddTicks(9199), 926.4397953102880000m, "92be05bb-e447-4c6f-a6e5-80d8496607f5", null, null, null, false, "Mark", "Mark", "Moore", false, null, "Mark_Moore", null, null, "AQAAAAEAACcQAAAAEDBzEQuWM9WN4w2keB7DUevSDblSGH59msRiVh6NAKXqtQZCsEXUQTJcExD6NS2VVw==", null, false, null, null, 2, false, null },
                    { new Guid("f8c234a1-e25c-478d-be01-cda21178c47a"), 0, null, 457.7294874635030000m, "10e06dc5-27d7-4af2-bf3c-8cecef73feb3", null, null, null, false, "Kristina", "Kristina", "Crooks", false, null, "Kristina78", null, null, "AQAAAAEAACcQAAAAEJfPovIIek24dj+A85VQomxcFngm9Lg8iTKUhnT+R4pvYTDhMKNfBcpp4F+nDCY7rg==", null, false, null, null, 2, false, null },
                    { new Guid("f8c6be38-3b48-44ea-9af5-7fd644c82034"), 0, null, 219.8485418873660000m, "e59823e0-5474-4d7d-a43b-95738202b79d", null, null, null, false, null, "Theresa", "Fahey", false, null, "Theresa.Fahey", null, null, "AQAAAAEAACcQAAAAEHTSsYAuTKpk/ylkJu0FqHrTxfD1G1vXXy5CGcPEJm72Bi+7qozDQR6x4y+TtHO04g==", null, false, null, null, 1, false, null },
                    { new Guid("fa671618-4f8c-472d-aad1-18adb7778e70"), 0, new DateTime(1950, 4, 30, 11, 12, 38, 947, DateTimeKind.Local).AddTicks(5371), 850.0167695793980000m, "7901276a-b597-41e6-ab1a-4dd554daf53d", null, null, null, false, null, "Wade", "Bergnaum", false, null, "Wade_Bergnaum", null, null, "AQAAAAEAACcQAAAAEIdG7G4FCjvgUVwDvY+1RynO8wR+1nPabLcQkFN1QzJwLYBNZCi9pk+LnzRciqTu1w==", null, false, null, null, 0, false, null },
                    { new Guid("fbcf0085-dd67-4f41-b656-a0c0900baca5"), 0, new DateTime(1940, 3, 24, 18, 23, 32, 935, DateTimeKind.Local).AddTicks(1157), 436.0574190493710000m, "6f705d5d-cc35-4398-86b8-3bcedcdb2aba", null, null, null, false, "Ismael", "Ismael", "Howell", false, null, "Ismael.Howell", null, null, "AQAAAAEAACcQAAAAEMv7Pzlp8LnenR7IrINroyKneFDD7CTDa3DjZW5hkakE5blc/Fs2+UQKLL3OeyAJ5w==", null, false, null, null, 2, false, null },
                    { new Guid("fc6059ea-998b-4053-8aa0-faef98da998c"), 0, new DateTime(1971, 2, 21, 11, 3, 24, 98, DateTimeKind.Local).AddTicks(5626), 700.5331937677650000m, "ccc4204a-9402-4833-93e3-93259c1d898a", null, null, null, false, null, "Max", "Schmeler", false, null, "Max86", null, null, "AQAAAAEAACcQAAAAEPPxzINBsEccMayjHJ8Gc3RsP2ptu7DgNRWQZub2RHD34NvUEFu2MfQPecphhGNOew==", null, false, null, null, 1, false, null },
                    { new Guid("fce6a3fa-2769-41fb-ad0b-94fcfc2caab0"), 0, new DateTime(1991, 11, 3, 18, 50, 23, 640, DateTimeKind.Local).AddTicks(7294), 399.1969435633790000m, "5f67a867-c97c-49ba-9e5d-cefb1e6a7447", null, null, null, false, null, "Julie", "Kohler", false, null, "Julie72", null, null, "AQAAAAEAACcQAAAAEIqStuXyGhgwqvxVBwpAduCCsr5qjLAvf8I+WOyGWFUesHFMIDssV5xWXFT2B/ikZA==", null, false, null, null, 2, false, null },
                    { new Guid("ff5c3ca9-e336-4c0b-bb16-8a689eb03900"), 0, new DateTime(1989, 3, 11, 12, 55, 0, 401, DateTimeKind.Local).AddTicks(7528), 190.1959983797280000m, "b176733d-f653-4515-b947-76e7f028c411", null, null, null, false, null, "Adrienne", "Veum", false, null, "Adrienne.Veum63", null, null, "AQAAAAEAACcQAAAAEGqYzg3NvzixDJrjEvXWBuvvrr/skUWHrOsE6OpqrtowUMUcU5YvRnbvby2Vvzgtvw==", null, false, null, null, 1, false, null }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("01380607-63a5-4cc4-8034-0bfdf63b03f9"), "0,52850807;0,3458543", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Allene, Guadeloupe", "Hand Forges, 8891", 490486830 },
                    { new Guid("026ff160-607c-4448-9a0e-22224756dce1"), "0,51333356;0,8612153", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Naderside, Sudan", "Theresia Port, 973", 1739091444 },
                    { new Guid("08d86312-7312-4d7f-a414-f3d43a1d22c2"), "0,48319483;0,68238693", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Heathcoteside, Bosnia and Herzegovina", "Myriam Vista, 6799", -440345764 },
                    { new Guid("0909e179-4d69-4476-a54d-d6c4e01470cc"), "0,4576658;0,14067358", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Federico, Italy", "Nico Groves, 23778", 464926029 },
                    { new Guid("121cad2e-5774-4f49-85d6-0b90c3644914"), "0,083705835;0,108080015", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Willismouth, Uganda", "Mireya Stravenue, 926", -561106565 },
                    { new Guid("1320f4ae-3aa0-4faa-8adc-f92f40718b02"), "0,4308324;0,12459468", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Keshaunbury, Madagascar", "Gabrielle Rest, 93008", 278165751 },
                    { new Guid("13acd826-a441-4cf0-b734-546fde65eaeb"), "0,011127202;0,49491975", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Janiceberg, Nepal", "Towne Park, 2749", -76413314 },
                    { new Guid("151847e5-b028-4f4a-97f3-ff312427cca3"), "0,1744279;0,7884833", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Graham, Maldives", "Dallas Plain, 96102", 482350103 },
                    { new Guid("18ab745b-5901-4cb0-878e-f134ae2e485d"), "0,3855924;0,9587916", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Freda, Faroe Islands", "Telly Freeway, 176", -166654932 },
                    { new Guid("18d413f5-9ab2-493e-8337-1fdfd3eebb0e"), "0,1821051;0,9962617", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Luna, Senegal", "Rowena Centers, 260", 557491859 },
                    { new Guid("1931b47c-721f-4612-ad7e-ad2bee2c7c3e"), "0,9170229;0,7599167", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Melvin, Netherlands Antilles", "Friesen Pines, 462", -1715433428 },
                    { new Guid("1f70dac0-146a-45ef-a458-aac237c5ebe5"), "0,8711997;0,06920785", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Myrnamouth, Eritrea", "Towne Avenue, 26043", -747631689 },
                    { new Guid("1f9ba209-7f1b-4c2c-b159-7258d813e515"), "0,20054188;0,8503816", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Billyhaven, Israel", "Rosenbaum Cliff, 0846", 1916701475 },
                    { new Guid("21dca019-293d-44e2-ac17-fde9f7b4794e"), "0,029138599;0,21191831", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Adalbertomouth, Seychelles", "Donnelly Oval, 6255", -1289638626 }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("22965f6c-bc06-49a0-93c4-53258424107a"), "0,2108171;0,75032043", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Langworthshire, Antigua and Barbuda", "Parker Motorway, 13495", 2075202755 },
                    { new Guid("24030200-1363-4a76-8795-b53c08b89b2d"), "0,9939354;0,96980345", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Angelaport, Kyrgyz Republic", "Genevieve Forge, 03202", 1473275277 },
                    { new Guid("27f0cb44-1a70-4123-914c-afa35265f85d"), "0,59360373;0,6243292", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Stephanyborough, Sao Tome and Principe", "Ima Manor, 9421", 865045793 },
                    { new Guid("2f80478b-b139-4be1-8dfa-4c07c181e995"), "0,6236421;0,6217762", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Angusbury, Gambia", "Cornelius Land, 918", -1345167941 },
                    { new Guid("2fbd2df7-a365-4034-a3ed-ca140b6f56e7"), "0,32585788;0,85062224", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Constantin, Madagascar", "Ervin Point, 3533", -709442230 },
                    { new Guid("3118d99c-620d-4abe-ab00-6d14e9151499"), "0,63292754;0,9892747", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Major, Morocco", "Reynolds Pike, 03463", 72271256 },
                    { new Guid("37bdec03-1d7d-49e5-8fb9-d43b13d6d6e4"), "0,16557544;0,7382729", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Jakobland, New Zealand", "Nella Hill, 6483", -1934648871 },
                    { new Guid("3a24485f-b209-42ad-afbc-9bfe2446657a"), "0,86804104;0,69482183", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Rosenbaumview, Lao People's Democratic Republic", "VonRueden Stravenue, 1807", 844702157 },
                    { new Guid("40ca667a-ef7b-47f8-ba95-69593445f5e7"), "0,033895448;0,5345264", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Franeckiville, South Africa", "Kling Village, 218", 1049194268 },
                    { new Guid("4123ef7c-99d1-4aa7-905e-b1372da57bf4"), "0,36439997;0,47339034", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Vanessaburgh, Andorra", "Watson Heights, 728", 156354494 },
                    { new Guid("423d50e8-cd3d-41bd-b5c9-4f498e0253ef"), "0,9064495;0,0475374", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Laurineville, Guinea", "Spinka Parkway, 5628", 2018133312 },
                    { new Guid("43260ef4-c04d-4f8e-bd11-e6f63671c70c"), "0,858892;0,0051350216", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Malcolmfurt, Slovenia", "Howell Well, 49822", -1624206025 },
                    { new Guid("43d54bed-408f-4fe3-b1b9-91565c1294cf"), "0,8688881;0,81128514", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Alvertafurt, Guatemala", "Kameron Bypass, 65815", 169648031 },
                    { new Guid("50f83f33-4eeb-4d2b-b4b9-5ee3e7955b73"), "0,6970618;0,5486312", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kundeborough, Canada", "Connelly Stravenue, 1007", 1985411734 },
                    { new Guid("51eaa5e7-cb23-41a3-903a-08e952071f0e"), "0,9386543;0,8556341", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Estrellatown, South Africa", "Walker Square, 74933", 2051739612 },
                    { new Guid("5875ec03-0b75-464d-bc9f-95382a00fdc3"), "0,4730133;0,1260881", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Landenborough, Cambodia", "Zoila Highway, 3141", -2055775319 },
                    { new Guid("5a5ae4cb-4ec7-44d3-bf5c-52d4c3752fa3"), "0,8669855;0,7723061", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Audreannemouth, Pitcairn Islands", "Ismael Flats, 15700", 1651616719 },
                    { new Guid("5befc4fa-0807-4422-aaaf-352a25d21a39"), "0,44308007;0,42282242", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Fishermouth, Cape Verde", "Schuppe Meadows, 457", 1708733916 },
                    { new Guid("5c1ed58b-5798-4aa9-a762-ad699a0add1f"), "0,8321185;0,6147071", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Alisaborough, Bouvet Island (Bouvetoya)", "Leanne Fort, 16785", 1204150620 },
                    { new Guid("5efeb0ec-3747-415b-b3ba-a705ff2d3932"), "0,20247018;0,7709402", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Roobhaven, Marshall Islands", "Deanna Mews, 84753", 650015443 },
                    { new Guid("5fbaf3d2-fe57-498c-9236-dc162f03ead2"), "0,30022547;0,27637705", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Noemyview, Latvia", "Blanda Meadow, 997", -1890211698 },
                    { new Guid("64c5af14-1b67-4c18-882a-2b3c10f834a1"), "0,65782607;0,5680831", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Sonyaville, Albania", "Crooks Lakes, 238", -1479652067 },
                    { new Guid("66e4797e-6a96-4179-9b38-12f6ad394cf7"), "0,5267172;0,63870764", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Marjorie, India", "Lind Estates, 4893", -1693831486 },
                    { new Guid("69795790-c10c-4913-a187-5f051e1c4b2f"), "0,5908052;0,63220716", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Parisianfort, Andorra", "Kendall Neck, 728", 514632407 },
                    { new Guid("768d236f-f0cb-4aac-bef0-14e2e028cee5"), "0,9450548;0,9174523", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Harmonchester, Bosnia and Herzegovina", "Stehr Trace, 892", 1681167627 },
                    { new Guid("79c20ee3-8b87-40e6-9e7f-fe8830979726"), "0,17870738;0,0894912", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Laylashire, Paraguay", "Aufderhar Orchard, 72695", 447334151 },
                    { new Guid("7b813e8c-c46e-418e-a851-a8238a3dac20"), "0,51160634;0,035743095", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Aglaeberg, Colombia", "Herbert Villages, 91477", 1369093335 },
                    { new Guid("7c0056b9-273a-4c38-bbba-345bae568a7a"), "0,6098925;0,40812966", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Wisokyland, Guyana", "Barton Vista, 6898", 651438290 },
                    { new Guid("85750c6f-0c1a-4482-a019-f2b37a2428db"), "0,6993176;0,43800747", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Hermantown, Germany", "Towne Pines, 27208", 2003772540 },
                    { new Guid("87d9f133-f2a8-44ab-8e4d-8a5b46b7f46f"), "0,17964877;0,88239723", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Donnellland, Bulgaria", "Bud Stravenue, 109", 657530457 },
                    { new Guid("88fb6618-03dd-43be-adc8-8805bc64b95d"), "0,50057644;0,60755634", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Freddy, Nicaragua", "Timmy Manor, 099", 87932614 },
                    { new Guid("8a47176e-7347-419f-a34e-c7cf1a2627c3"), "0,1859161;0,8915727", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Greysonfort, Uzbekistan", "Russell Lakes, 50086", 460689662 },
                    { new Guid("8a568205-931c-4c11-bf57-fdb922cfa765"), "0,2899819;0,42349604", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Peterchester, New Caledonia", "Precious Spring, 398", -443104525 },
                    { new Guid("8d0cdc99-c1b2-41c5-8df9-2c2f560ccdec"), "0,9789081;0,10913271", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Benjaminmouth, Aruba", "Sandra Unions, 6665", 1689940853 },
                    { new Guid("9365473c-42e2-44e7-991e-177343036e16"), "0,60413754;0,37067297", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Favianshire, Suriname", "Altenwerth Fords, 3866", -924681603 },
                    { new Guid("940e9b35-b2cc-4c61-b58f-bfce5b310960"), "0,535511;0,57120377", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Luettgenmouth, Nauru", "Kyla Haven, 2552", 126996012 },
                    { new Guid("962e676f-a4ca-4fff-a4f6-2ab0df2a8da5"), "0,55372095;0,045694355", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Nicholaston, Jordan", "Hansen Cliffs, 14220", -1072107784 },
                    { new Guid("9740a91e-cbd0-4bf2-af89-f88bd77976c4"), "0,3933074;0,27620286", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Reillyfort, Algeria", "Kub Fall, 8524", 1094907672 },
                    { new Guid("9819ae1a-ff32-4df5-a0fe-7f349826cf63"), "0,70878613;0,39537188", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Palma, Christmas Island", "Odie Overpass, 404", -1589313583 },
                    { new Guid("99cdce55-12c7-4cb9-a36f-f6df1334c1f6"), "0,33481318;0,96541667", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Osinskifurt, Cote d'Ivoire", "Beer Mills, 03101", 1404079766 },
                    { new Guid("9e89d612-7c56-4af4-8e41-9852333491f4"), "0,029713323;0,9686241", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Blairland, Serbia", "Kuvalis Greens, 9322", -1232861392 },
                    { new Guid("9f1e6bfc-cc75-4c73-92b7-f42f2a1f010d"), "0,5091112;0,5000977", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Angelicafort, Heard Island and McDonald Islands", "Claudine Walks, 8355", 1976986411 }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("9f32452f-9559-47c0-aa30-6b1ed2b4fe6c"), "0,90760976;0,28076187", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Coy, Iraq", "Layla Union, 0504", 951047636 },
                    { new Guid("9fbb29a9-ae36-4935-ad92-c23178967d9d"), "0,37530556;0,14557302", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Marina, Afghanistan", "Duncan Road, 1909", -439085840 },
                    { new Guid("9fef170f-1e7f-472d-8f7f-14880f28c30a"), "0,8654687;0,25361833", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Tillmanfort, Suriname", "Johnson Spurs, 06039", 1168344242 },
                    { new Guid("a12fc25e-7370-4de7-bb0f-ea6bb40b7db6"), "0,58850014;0,3833196", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Tristian, Luxembourg", "Trenton Greens, 493", 1201493032 },
                    { new Guid("a1b1d009-f9ad-4661-8a76-71c768b52e70"), "0,3209954;0,44039616", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Isadore, Niger", "Watsica Vista, 7973", 1567264370 },
                    { new Guid("a280936f-b2cf-4918-aa88-3301aaf2cc8d"), "0,1509925;0,01882012", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Devanburgh, United Kingdom", "Alfonso Meadow, 280", 272673532 },
                    { new Guid("a2fb7fb2-4e9b-4c01-ba53-2dac94cad663"), "0,60531265;0,24441868", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Madelynn, Bouvet Island (Bouvetoya)", "Howe Groves, 6516", 1481106131 },
                    { new Guid("a3524f45-9d4f-429b-8931-eca50ef2ac7a"), "0,20844683;0,73209476", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Myrnafort, Pitcairn Islands", "Stanton Mountain, 811", -348860878 },
                    { new Guid("a62347c2-691c-430c-bf3f-70ecaff8f9f5"), "0,34733173;0,2972268", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Rashad, Martinique", "Rogahn Falls, 886", 614660896 },
                    { new Guid("a81fce99-386f-4733-a804-69a21d041349"), "0,54726326;0,35706103", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Eveline, Northern Mariana Islands", "Douglas Lodge, 5404", -1526407589 },
                    { new Guid("a88290cd-ff00-4a6c-a033-19aaf1ce6541"), "0,94503903;0,70176035", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Elsaside, Croatia", "Erin Harbors, 14075", 392342921 },
                    { new Guid("a9f7a39a-29e2-4338-a51b-ede919a74d02"), "0,018743802;0,4819685", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Roycestad, Cayman Islands", "Abshire Forest, 958", -505777643 },
                    { new Guid("acd0d0e8-a31a-4886-aa6e-dadb1fde0c90"), "0,321399;0,35726562", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Carissa, Monaco", "Kovacek Fields, 53790", 2030325448 },
                    { new Guid("ae5d9bdd-48ca-4764-bbd6-cbc0082d0186"), "0,65413207;0,8363115", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Francescochester, Luxembourg", "Flatley Common, 9964", 1477703223 },
                    { new Guid("af9f3bcd-ec9a-47d0-955a-1954e55b12a5"), "0,3448573;0,5702879", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Moenfort, Togo", "Kacie Neck, 332", -1335147049 },
                    { new Guid("b2f05962-a786-4985-baff-7fe25f80da84"), "0,7749648;0,83727664", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Fredy, Chad", "VonRueden Route, 6661", 366143329 },
                    { new Guid("b62f890f-1095-4ea2-911d-7b4e1cd51bdb"), "0,013904986;0,5256923", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Katrinaland, Antarctica (the territory South of 60 deg S)", "Harvey Ports, 59654", -268790652 },
                    { new Guid("b6f65194-2333-46d0-a1f8-1fcb6d2b9edd"), "0,8690322;0,42062223", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Oberbrunnerstad, Niger", "Kreiger Estates, 98224", -1473575855 },
                    { new Guid("b7fe7e19-152a-4d62-b266-566380be782c"), "0,5988588;0,48380357", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Carter, Gabon", "Stewart Forest, 8717", 1346574296 },
                    { new Guid("bbcbc8bf-e72f-41bf-8398-ec5e83a86564"), "0,15805772;0,45540437", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Jermaineton, Reunion", "Hane Circles, 756", 1627955016 },
                    { new Guid("bd14eaf6-ef1e-4186-9b09-86c6b361e00a"), "0,3256534;0,9271611", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lindgrenville, Japan", "Pearlie Square, 23510", 1524633885 },
                    { new Guid("bfcdf10c-5326-4e16-8646-38d810c042f9"), "0,0712898;0,5578032", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Francisca, Indonesia", "Kessler Fords, 331", 1678881617 },
                    { new Guid("c162591c-6bf8-4294-ac4e-8d9b25d245ca"), "0,51990783;0,012893991", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "VonRuedenfurt, Zimbabwe", "Kelli Hill, 52190", 1056755869 },
                    { new Guid("c1f8f774-befa-4215-b2b4-a30d3cd27523"), "0,02368286;0,36939305", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Karli, Madagascar", "Carmen Fields, 50720", 1673071849 },
                    { new Guid("c62f140e-bf65-49a4-8e96-3976d270c759"), "0,36306563;0,31448337", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Samantha, Hong Kong", "Wolf Ferry, 62304", 207237841 },
                    { new Guid("c784bcfe-36d0-4b0c-8704-ce00df9aaf25"), "0,042977497;0,3988692", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Shaynaville, Northern Mariana Islands", "Lehner Village, 5959", -2010393582 },
                    { new Guid("ceed9b88-f9c9-496c-a91d-f69fbe640ece"), "0,024240289;0,13229536", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Aryanna, Mauritius", "Batz Place, 13220", 1028690234 },
                    { new Guid("d5e3b225-a419-4445-99c6-167feee17a79"), "0,87023085;0,21908475", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Jaylan, Panama", "Kulas Heights, 06462", -384977403 },
                    { new Guid("d93b50da-ef18-45e8-bf63-9c03446ebb90"), "0,8553083;0,17944783", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Shannonstad, Central African Republic", "Emmerich Rapid, 7910", 777407766 },
                    { new Guid("d9e906a5-a0e0-4a3e-811d-768945e02211"), "0,65785444;0,32526216", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Johnville, Saint Lucia", "Geoffrey Flats, 7740", 227692408 },
                    { new Guid("da321187-f3fc-4a84-bc08-861172764c47"), "0,31264898;0,8827339", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Zora, Guatemala", "Auer Grove, 256", -1462095936 },
                    { new Guid("da7adcc3-ca21-462a-b70d-d286f2c670a7"), "0,9711007;0,6553638", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Katelynfort, Kazakhstan", "Lauren Passage, 345", -467492158 },
                    { new Guid("dee97a1b-5f96-474a-a383-adc2efc5d250"), "0,64071107;0,6332082", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Dale, Botswana", "Greg Track, 28132", 1128189010 },
                    { new Guid("e4eacfff-a470-47d9-bf18-5568f986e21c"), "0,29409352;0,20334217", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Hillarymouth, Guam", "Isidro Crossroad, 8477", -1903332160 },
                    { new Guid("e73309d3-c441-4932-a09c-af03706b8eee"), "0,26670364;0,29022998", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Alisaside, Anguilla", "Edgardo Islands, 557", 1581517404 },
                    { new Guid("e8b80940-c4e0-4c3b-b2f8-7e13a2103780"), "0,9571011;0,86588633", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Deonteview, Bahamas", "Williamson Vista, 94656", -670114231 },
                    { new Guid("ed93df05-11c6-412c-82f0-8aa75ea66ea8"), "0,5695689;0,17186947", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lavadachester, Ireland", "Jermey Extensions, 83286", 786884963 },
                    { new Guid("ef93ecfe-06f6-495e-9dc5-acdd12667b97"), "0,32068798;0,3679111", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Funkton, Micronesia", "Shanelle Square, 487", 2123156009 },
                    { new Guid("f53320ac-20ac-4ace-aad8-aa73ca22fd10"), "0,16614291;0,673097", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Tianna, Qatar", "Alanna Valley, 64039", -2122918682 },
                    { new Guid("f8343b06-9129-4628-9f91-fc4e1c22eb15"), "0,8514637;0,9744588", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Ezra, Cambodia", "Destiny Burgs, 8438", 825476148 },
                    { new Guid("f8936055-9f70-44d9-8671-c5d65f08b415"), "0,48874798;0,3749211", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Vernicemouth, Tunisia", "Cathryn Oval, 5294", -413509519 },
                    { new Guid("fb42b495-be43-4f91-903d-094955269c28"), "0,5779565;0,9921418", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Keeleyland, United Arab Emirates", "Armstrong Vista, 20413", -495898492 }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("fc426ee6-7ce0-4b1c-b8e2-32a53e760de1"), "0,8864093;0,050600547", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Darlenebury, Samoa", "Feil Centers, 30870", 267634568 },
                    { new Guid("fdb5e21e-8527-4184-8e8f-86e9cbd48fe1"), "0,030559685;0,046754885", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Hardyburgh, Romania", "Durgan Radial, 92360", 212158023 }
                });

            migrationBuilder.InsertData(
                table: "PostBranches",
                columns: new[] { "BranchId", "BranchNumber", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress" },
                values: new object[,]
                {
                    { new Guid("0016b390-04e1-479d-9b2e-364716772606"), 1347288455, "0,5206496;0,8515129", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Rahsaan, Turkey", "Dee Glens, 258" },
                    { new Guid("0278919c-a954-4960-98c1-db890e6bac28"), -65544114, "0,41528687;0,45592302", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Heath, Swaziland", "Jamey Wells, 104" },
                    { new Guid("037126b5-c218-4858-b8f4-a7d42b02c07b"), 1643586921, "0,30254486;0,91922885", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Pollichchester, Anguilla", "Zulauf Mountain, 535" },
                    { new Guid("05e5656c-2994-48a0-a339-dde1e1a4f1a5"), -1470731657, "0,40128735;0,39107057", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Alisha, Mongolia", "Wyman Valleys, 186" },
                    { new Guid("0773c65a-1776-4019-a3cd-2a17b97c3dd8"), 240005258, "0,37677193;0,10375295", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Sydnimouth, Pitcairn Islands", "Schaden Terrace, 2428" },
                    { new Guid("0b25cba3-0417-471a-a0d2-89a5dfd76c01"), 968322518, "0,06500833;0,4667143", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ryanmouth, Georgia", "Shanon Port, 1967" },
                    { new Guid("0b5cc62a-0b28-46d8-a616-9b832171d377"), -1297501888, "0,8697812;0,14469372", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Catalinastad, Vietnam", "Anastasia Cliffs, 48200" },
                    { new Guid("0e17acaa-ea16-417f-965e-22991ab8b21d"), 1096684632, "0,43954188;0,5605697", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Randiland, Palestinian Territory", "Jeanne Hills, 46521" },
                    { new Guid("10b84ef0-078a-472a-99d4-a158ba7c9d6d"), 855965245, "0,04343681;0,6809823", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "VonRuedenland, Albania", "Westley Hills, 8190" },
                    { new Guid("129cdff2-3cee-47af-9ccb-835b0d632900"), 1961515049, "0,64475024;0,5793607", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Brookstad, Angola", "Durward Plains, 920" },
                    { new Guid("141f494f-6647-42ae-ae0b-75cd57f9d57b"), 242989127, "0,2420173;0,36089694", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Sadie, Israel", "Bernita Wells, 0287" },
                    { new Guid("15b53a9e-23e9-4fed-b40d-5d0b1b171b61"), -339392081, "0,3325654;0,5091223", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Donnellymouth, Greece", "Lehner Corner, 652" },
                    { new Guid("1706e418-892a-4912-9bd8-fa71fae418c1"), -1272340950, "0,8320415;0,94818324", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kozeyville, Malawi", "Kolby Islands, 4281" },
                    { new Guid("1a7e0b88-2fb6-433b-bcc7-bb9f258b11f3"), 67694327, "0,678577;0,3751937", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Amya, Panama", "Myrtie Springs, 40013" },
                    { new Guid("1c0c51f7-4e89-433a-8983-f3cbefd9a810"), -1080549110, "0,99621797;0,16133893", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Macieburgh, Gibraltar", "Princess Expressway, 042" },
                    { new Guid("1f7e7541-6b8a-45e0-8597-35b8c7c76625"), 1753542641, "0,29204977;0,29898626", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Anaisville, Gambia", "Jacky Shores, 686" },
                    { new Guid("21ea1356-b5ea-424b-b415-657f2803e339"), 1555562664, "0,33232972;0,07221903", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Ericka, Norfolk Island", "Huels Road, 171" },
                    { new Guid("2432655c-4ecc-48c6-98bb-7b9b3ad96668"), -2120416416, "0,8019069;0,13649791", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Maryamburgh, Greece", "Hazel Shore, 07815" },
                    { new Guid("26d0ff21-2077-487f-939f-475791621fd6"), 455562103, "0,21229312;0,73911905", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Israelshire, Uganda", "Upton Knolls, 72674" },
                    { new Guid("278156d2-93cd-47cc-bae2-912ad76be19f"), 1376344364, "0,8422071;0,8732346", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Audieshire, Somalia", "Adella River, 2943" },
                    { new Guid("2844b987-8e57-4391-9da4-b2762509364e"), -1694240443, "0,06366791;0,8445021", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Tierratown, Belarus", "Nadia Branch, 0475" },
                    { new Guid("2b6786ce-bd76-4731-a53a-f0abd337ca7a"), 97451911, "0,3820017;0,12854432", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Faheyport, Dominica", "Bryana Lake, 2356" },
                    { new Guid("3381afde-e949-492b-a85b-65023911c8c1"), -1733093438, "0,7652072;0,9186298", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Moenchester, Somalia", "Ardith Crescent, 018" },
                    { new Guid("34d83800-ef9a-4c25-a54d-ba1a285d4e91"), -802750576, "0,077582836;0,9158745", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Jeramyfurt, Haiti", "Deontae River, 17344" },
                    { new Guid("3df3c904-719f-4990-9f1d-25f255f93b63"), 1293549640, "0,53311527;0,9429761", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kamilleland, Mongolia", "Shaun Greens, 595" },
                    { new Guid("40b22a57-39b2-43d0-817c-7901e04c647c"), -1892260929, "0,66464996;0,24501176", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Alycia, Madagascar", "Ola Radial, 4410" },
                    { new Guid("44acb9bf-cac8-4b23-a4e2-2e44d51a9beb"), -958999745, "0,5089575;0,10620431", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Nicolechester, Nicaragua", "Jamir Pines, 2486" },
                    { new Guid("45f843a0-634e-4337-ac38-18289edb6386"), -1176683146, "0,010151474;0,05514263", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Leonieburgh, Zimbabwe", "Marks Drive, 3333" },
                    { new Guid("468fb00b-a4ad-4d1a-a7b9-234fffe176c9"), -1172359068, "0,5859966;0,7562098", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Gregorioshire, Saint Barthelemy", "Madonna Club, 5361" },
                    { new Guid("497471e5-5b00-4ae8-a678-039014c09380"), -1976738952, "0,54782325;0,14057879", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Deronchester, Saint Kitts and Nevis", "Hilll Inlet, 721" },
                    { new Guid("4dc42e13-1e48-4ea3-b86a-f3df4118c9d5"), 1671580967, "0,64982694;0,85620964", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Maudhaven, Afghanistan", "Hayes Grove, 7460" },
                    { new Guid("4e6e9edc-11d0-4a7c-adda-bf8743e854e1"), 1840218967, "0,68875533;0,099614404", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Lorimouth, Cambodia", "Lenna Hill, 99761" },
                    { new Guid("50a9814c-a8b8-4e15-998f-71d3025b6ea8"), -778677843, "0,635593;0,21876918", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Hackettton, Sao Tome and Principe", "Erick Cliff, 8229" },
                    { new Guid("50d93c29-6446-4370-ae77-2d0154406dbd"), 1275096118, "0,43964192;0,38882694", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Swiftstad, Argentina", "Kane Expressway, 343" },
                    { new Guid("50f09e36-8af3-4946-92a9-222d4e1be79b"), -462414642, "0,24696428;0,5345787", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Deon, Philippines", "Novella Motorway, 904" },
                    { new Guid("51defd5c-9282-48ca-bb6d-18dc45a54381"), -1164582721, "0,21660277;0,72037953", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mantebury, Cocos (Keeling) Islands", "Jamil Plain, 796" },
                    { new Guid("53b1372a-8c17-4b5c-a687-e4b3ff2467ff"), 642521627, "0,8132403;0,26893783", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Bertrandberg, Bosnia and Herzegovina", "Kuphal Plaza, 6664" },
                    { new Guid("54fe296c-d00e-4c7b-ac71-14688a8e4a66"), 1320343539, "0,34565896;0,16430159", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Shyannemouth, Spain", "Torp Forge, 6428" },
                    { new Guid("5a69917a-1b3c-4f0f-b8e3-50bca5ef8ea2"), 1584381801, "0,7765265;0,43504173", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Micahtown, Tunisia", "Bulah Lodge, 99521" },
                    { new Guid("5b8d4d3c-e185-4de6-9412-00785dd50ad5"), 1580112756, "0,30526456;0,69776064", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Augustinebury, French Southern Territories", "Veum Trail, 81590" }
                });

            migrationBuilder.InsertData(
                table: "PostBranches",
                columns: new[] { "BranchId", "BranchNumber", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress" },
                values: new object[,]
                {
                    { new Guid("5bfce6ed-f41f-4f2d-b70d-048f215eeaf7"), 927292920, "0,34049705;0,45895818", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Juwanburgh, Cambodia", "Yadira Hills, 20049" },
                    { new Guid("5e036dda-3306-40be-a305-21f79350895a"), 943132446, "0,9186602;0,445053", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Rhiannonbury, Morocco", "Adolphus Key, 626" },
                    { new Guid("5e097b88-cb59-47d7-9649-bcd2682ba7f2"), 1933426436, "0,7569914;0,807933", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Zoeyfurt, Lesotho", "Shannon Hollow, 327" },
                    { new Guid("5f7ede62-c8f0-48b2-ad86-a8bd560d192c"), 546873299, "0,46561366;0,27572593", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Jamirstad, Senegal", "Greenholt Mill, 56002" },
                    { new Guid("60c4266f-8210-4f6f-a18f-3bbe0fcc52ef"), 46257533, "0,8929697;0,74286574", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Gislasonberg, Jordan", "Darius Ranch, 6722" },
                    { new Guid("63450cab-27ee-4cf8-a92a-999c01d91312"), -1678522929, "0,57710785;0,5704657", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Vickieborough, Egypt", "Luettgen Path, 192" },
                    { new Guid("63a57fc9-56e5-4342-ba17-f80d1d48aae8"), 2129477293, "0,5894211;0,84232634", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Edmond, Liberia", "Huels Field, 22615" },
                    { new Guid("6611bb76-ccb4-4205-98ba-efeb039aeb78"), 86452602, "0,1078619;0,47834983", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Theodoreside, Tunisia", "Eldridge Keys, 9068" },
                    { new Guid("68423f32-5d32-4326-a578-21d72aad62a2"), -2044844293, "0,98420435;0,5202542", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Randalville, Philippines", "D'Amore Radial, 800" },
                    { new Guid("69299083-d4bf-4cc6-ad6d-df975862ed21"), 1236457277, "0,6844765;0,28154072", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Hintzfort, Virgin Islands, U.S.", "Flavio Trail, 01382" },
                    { new Guid("6e472106-e8c8-4651-b4e5-64efa108d44f"), -414153687, "0,97897136;0,40652007", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Goodwinport, Bhutan", "Agustina Manor, 90411" },
                    { new Guid("70e48017-1574-4db3-a793-8997b2871819"), 1515007095, "0,32380927;0,9589419", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Milesfort, Samoa", "Leanna Fall, 97597" },
                    { new Guid("73e4fc8b-9530-4a6f-8594-a86514779a10"), 1305201018, "0,031624027;0,8795799", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Harveyport, Angola", "Bruen Pike, 8594" },
                    { new Guid("7413402f-708e-41e6-ac7f-e45374fba55f"), 592312191, "0,35245782;0,9904926", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Otiliafurt, Honduras", "Beatty Throughway, 0584" },
                    { new Guid("74894854-04ea-4266-895b-340c8fa4e301"), 694452862, "0,34036705;0,26003405", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Alenehaven, Saint Kitts and Nevis", "Beier Gardens, 781" },
                    { new Guid("74937763-db31-488e-8149-dc0849b236f3"), -820238853, "0,66687876;0,25570357", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Shanel, Australia", "Bria Forge, 3157" },
                    { new Guid("761f33ce-627f-4304-ba34-25f10160c9cf"), 1082451359, "0,29152748;0,23758811", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Marshall, Tokelau", "Mylene Fall, 4824" },
                    { new Guid("76ab0f5c-ca9a-4704-8ad5-a67481aa4286"), -572857805, "0,2620524;0,7564248", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Friesenbury, Aruba", "Stark Spur, 3551" },
                    { new Guid("7c3d7417-9bf8-46d6-bb4f-11d4bb013163"), -1015077828, "0,6798361;0,77786106", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Olliemouth, United States of America", "Margarette Unions, 2721" },
                    { new Guid("83dbb901-8eb9-4ed6-99ff-e1b830acff04"), 712331155, "0,5233805;0,48192394", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Kaylin, Germany", "Langosh Pine, 2518" },
                    { new Guid("8827f823-bafe-42af-843a-262a12a3ce2e"), 295590076, "0,009903853;0,3850005", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Schroederchester, Oman", "Ralph Parkways, 9513" },
                    { new Guid("8ab3dd3e-9864-4345-a7e3-088203c8463e"), -2126273968, "0,54593;0,034432255", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Isaacchester, Taiwan", "Thiel Ramp, 192" },
                    { new Guid("8e8fcebd-ad2c-40b4-8d53-bbc90fd5390f"), 1631720034, "0,17042647;0,36860138", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Alford, Belgium", "Delia Springs, 45350" },
                    { new Guid("9192a899-97a0-4b3b-92cd-7e026be3934f"), 1062526824, "0,44172224;0,18860492", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Alisonton, Azerbaijan", "Gladyce Plaza, 8052" },
                    { new Guid("93eeebbd-063e-4375-8ac7-4844853bfeef"), -246576991, "0,42678013;0,10095942", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Adele, Israel", "Emmanuel Orchard, 07818" },
                    { new Guid("957d6734-1fa3-43cf-b86b-02340d8f8852"), 373373018, "0,5923345;0,9449527", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Vicky, Puerto Rico", "Maximus Port, 26547" },
                    { new Guid("96e4c5e3-6536-47dd-86f5-c40fcaac0f5b"), -246079713, "0,96237963;0,9393613", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mayertborough, Grenada", "Nathaniel Locks, 03290" },
                    { new Guid("97d04fc0-0a2c-497d-8599-98fe80443c1c"), -991126810, "0,7261802;0,6322086", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Haleyton, Nepal", "Hoppe Parks, 23734" },
                    { new Guid("9af89fb0-6ce6-4bca-b74d-8d16ff4b39cd"), -1208612517, "0,18809168;0,16739033", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Damianmouth, Guam", "Mercedes Motorway, 6320" },
                    { new Guid("9d4abba0-cd50-422b-900f-aecfe416dea1"), -544594336, "0,10888122;0,47942176", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Floport, Portugal", "Schuster Rapid, 02258" },
                    { new Guid("9d5fadda-9290-4d36-a02e-00bbc0dc2e77"), -204908499, "0,91558284;0,5850821", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Miles, Liberia", "Asa Highway, 670" },
                    { new Guid("9da1a904-7c5e-45d0-a9e8-1457c5d02848"), -896318541, "0,2660139;0,032918613", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Port Felipe, Dominican Republic", "Rosenbaum Summit, 03959" },
                    { new Guid("9e707a75-40ea-4781-8090-9a0ccfa618d8"), -548351113, "0,7114729;0,5242069", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Fletaland, Isle of Man", "Adell Route, 162" },
                    { new Guid("9fa97e46-87fd-472a-b5a8-9ac2c96289be"), 78763525, "0,74573046;0,23351961", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Braunberg, Isle of Man", "Remington Road, 7364" },
                    { new Guid("a26ba798-17a8-4735-8adf-f4e6979f0010"), 1278314840, "0,107607536;0,6335003", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Jacynthe, Virgin Islands, U.S.", "Aufderhar Ridges, 2566" },
                    { new Guid("a52c847a-7605-476c-bdb8-0eaf89dfa5ac"), 1128604277, "0,773588;0,83667046", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Haroldport, Northern Mariana Islands", "Derick Stream, 3129" },
                    { new Guid("a78b1951-1516-4424-b8b8-cb0a7a120130"), -1325304591, "0,17771506;0,8335623", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "West Vinnie, Qatar", "Jody Mountain, 823" },
                    { new Guid("acaaa101-5e5b-496d-8941-fa72bffb74f1"), 620347732, "0,17599556;0,45335558", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xzavierfurt, Iraq", "Rempel Stravenue, 7784" },
                    { new Guid("ad1845a8-cb0c-4e40-ac91-93c0871573a5"), -825510219, "0,6121224;0,2540902", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ivystad, Angola", "Clark Village, 183" },
                    { new Guid("ad7a27e3-a315-43e9-a660-354194ce2ab7"), 123171803, "0,5634088;0,8409246", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Della, Tuvalu", "Koepp Wells, 5289" },
                    { new Guid("ae04bd21-9bd5-4cbd-b299-c5b7ea16b2f4"), -1039016214, "0,7845116;0,45889962", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Jermainstad, French Guiana", "Mozell Extensions, 6162" },
                    { new Guid("b50f093e-1c07-45cb-99e2-2cf63be56ccb"), -801212021, "0,9689559;0,9507824", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Hansenstad, Antarctica (the territory South of 60 deg S)", "Berge Light, 827" }
                });

            migrationBuilder.InsertData(
                table: "PostBranches",
                columns: new[] { "BranchId", "BranchNumber", "Coordinates", "DateCreated", "DateDeleted", "DateUpdated", "GlobalAddress", "LocalAddress" },
                values: new object[,]
                {
                    { new Guid("ba459e88-5cbb-4b99-b421-cde8d9731efe"), 1451827058, "0,22247507;0,5609604", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lillyborough, Costa Rica", "Sonia Crest, 3654" },
                    { new Guid("bebe4138-e505-4340-8375-62a672f37d48"), 2079328066, "0,8209254;0,13054799", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Joshhaven, Iraq", "Abbott Flat, 60209" },
                    { new Guid("bedd4383-afaf-44b1-a8bf-16c30ea1e36b"), -251826903, "0,5541984;0,08329964", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Elliottton, Kazakhstan", "Cortez Streets, 964" },
                    { new Guid("c1671f3a-d00d-4b8e-8103-88ffb96e571b"), 1825398201, "0,36854753;0,99817795", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Elishaland, El Salvador", "Dibbert Ferry, 59122" },
                    { new Guid("c2389203-ae4b-422a-ad1b-09ab324874bc"), 802964185, "0,1691353;0,90947783", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lake Giovani, Guyana", "Becker Wells, 04998" },
                    { new Guid("c80f697d-73be-4e19-a3eb-1a4b46fb2902"), -918247473, "0,10716303;0,15374264", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Francescobury, New Caledonia", "Magali Rapids, 178" },
                    { new Guid("cffe432b-6a7e-4ff0-86fe-d39b0b5bd20c"), -417891743, "0,8400442;0,13414001", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "South Hallie, Aruba", "Merlin Forks, 50487" },
                    { new Guid("d0b651fb-f7ce-4b46-b4bc-ecccd16823c2"), 1717027979, "0,68623406;0,093361564", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Handborough, Norway", "Altenwerth Heights, 83170" },
                    { new Guid("d4603e5a-0c05-4549-907a-d6e1a7173a56"), 586574896, "0,48725235;0,22238176", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "East Colten, Central African Republic", "Joshuah Drive, 253" },
                    { new Guid("d903c63d-f3ec-46a8-a703-1a5007838b93"), 1491803766, "0,17057464;0,4607303", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Keshaunstad, Dominica", "Spencer Knolls, 8777" },
                    { new Guid("d923c410-f1da-4085-b9dc-bc36bcce90f2"), 473237329, "0,110237285;0,2076218", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Nikkotown, Norway", "Savanna Forks, 641" },
                    { new Guid("daad58da-1609-4db7-a1f0-0eb8fe22113f"), -1546018289, "0,9544086;0,36381418", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Jaceyshire, Timor-Leste", "Yoshiko Wall, 066" },
                    { new Guid("deedecaf-a242-466d-a663-f0ffc79f4c6f"), -987019679, "0,052226584;0,36913893", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Hintzhaven, Singapore", "Mosciski Track, 684" },
                    { new Guid("dfd8f4d8-6720-452e-9ca9-a3b944f8df46"), 2109665653, "0,38968995;0,4236577", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Bergstromside, Hungary", "Brakus Prairie, 59964" },
                    { new Guid("ec254f82-72bb-47ea-ab86-e676ea4c9201"), -396823979, "0,24297506;0,9955301", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "New Enochmouth, Togo", "Kaleigh Village, 71920" },
                    { new Guid("f198df95-1129-4318-bdff-c65c76a27d5e"), -768979542, "0,16050191;0,75937533", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Gleasonmouth, Israel", "Romaguera Island, 18157" },
                    { new Guid("f3089629-e607-4b04-a839-71486ae0b214"), 1271429531, "0,93965197;0,6670597", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "North Megane, Botswana", "Lockman Avenue, 0016" },
                    { new Guid("fb9006cf-fc30-4777-b7b5-7663dc814336"), -736484924, "0,8545258;0,72656286", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Corkerytown, Gabon", "Glover Lock, 9202" }
                });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "PromoCodeId", "ActivationCounter", "BonusSize", "Code", "DateCreated", "DateDeleted", "DateUpdated", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { new Guid("0064135a-586d-4d56-9d0f-27b51c5be85b"), 1534302016, 0.2003496485613530m, "3W7DPKb4aYktjAELs3SFXr1pGqRHuM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2338), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2337) },
                    { new Guid("012f6bb0-9c36-46ca-8d00-abb3bd9a5ca7"), 111952984, 0.05077148644090940m, "M6zq9WHeVZRrYDd7gE1FyNAUcbSJQw", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2089), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2087) },
                    { new Guid("08fa381c-12d6-4155-8266-6d119a48f8dd"), 1314975217, 0.6872317529984610m, "Mgp5PQWkuoEvVHBR1XYAnKMwyhciJ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(1119), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(1118) },
                    { new Guid("0c5623e5-70d5-4905-888c-c5ab05263d88"), -829085535, 0.1001454493828550m, "LEXrebGAWuzwcNUpZx6f8a7J3yH2FoDQjC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2293), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2291) },
                    { new Guid("10977405-82e6-4c24-96ff-1c6733cdceea"), 2066555933, 0.9046969028265250m, "342fanXr1L378cDVuYiHACqhTsvzeN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2069), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2067) },
                    { new Guid("155cd2d1-01dc-4655-a4db-48a983d58dc1"), 1672735536, 0.688327191533110m, "MiFXt2vCrGUA4eYmQaSgqp5ELRwD7y", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(1083), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(1082) },
                    { new Guid("16b3096d-b7c4-43f6-90a6-523e426cd586"), 1775648275, 0.5036568885124880m, "LjYWi5zdFu6mMRtU19nBKpoNEbQsfT4e3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1941), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1939) },
                    { new Guid("1a78b48a-46d7-4233-be7b-76c1ec708fd1"), 1317916765, 0.5881212690160320m, "3DTJyMK5UCzaojuG712BVtFinsdNhr4x", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2248), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2246) },
                    { new Guid("1df55c4f-c9d2-44f9-9eeb-0fe551ff5b8c"), -1692141799, 0.4284531511465230m, "3bFUPjNB2yHQEr7CYKSZGix3acpzt", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2466), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2464) },
                    { new Guid("2403f546-8ffa-40b3-abbb-0a1cc5cf5972"), -2073933670, 0.965591411829720m, "LVw156kce3f2hmAotuNxDYJrB8pSGgQM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1784), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1782) },
                    { new Guid("259dc67b-308a-4f93-bb2c-24b10da22922"), -1878509524, 0.1578518768778430m, "MSgmTNFXj7A9BvaeyCxMnuQqYdDr8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2029), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2028) },
                    { new Guid("2737d8a6-9c5e-4a50-8611-52706ff9c03e"), 2128607382, 0.911111991524280m, "M2mhXcHpqSoT3afsbQ1eCWnRyKjk4N8iGV", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2512), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2510) },
                    { new Guid("29d0c66a-9c32-4859-beb5-f31ed9661515"), -113207388, 0.05615735939925420m, "3Z2Uxp8jFbKXLDdhsGNifrzySvguaWtkEY", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2361), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2360) },
                    { new Guid("2bca3fb2-f6bd-485a-98c4-03b8b3fe2912"), -1366156721, 0.206835881134730m, "LWcfSmAXohQe7CzgrFt2wjqd6uKY9vJn", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(1213), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(1211) },
                    { new Guid("2e2ed187-a24b-4813-9538-2f090b0f6341"), 637737258, 0.04851939446994220m, "MHFxncRG67oPWVJX9yU513fNEQjZrLsCti", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2555), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2553) },
                    { new Guid("2f2e6a81-fad3-40b1-9635-bbc7141b189d"), 331080278, 0.08285675153839320m, "LyeiWXYorK4tcETSB2JU6AFMQ58PumNj", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(1006), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(1005) },
                    { new Guid("2fc5c246-adf8-4b2d-aecf-a85a61aeaad8"), 1465667228, 0.6756332815516530m, "LHLa394TtqSfhcAW8dzECvmsRYMGk", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(720), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(719) },
                    { new Guid("30ee284f-a7bb-4395-b19d-22e5df076772"), -618686316, 0.174632908985380m, "MwidjbunegKCBXthmrkHfq5pvxTV", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(96), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(44) },
                    { new Guid("381557ba-44a0-43d0-a190-cbcad25c60d9"), 236857366, 0.02264569372467750m, "MGoqX7cpizwYTJM8Unaefh9rg2RDC6s31", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(302), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(300) },
                    { new Guid("3f7c194d-4a68-4a4d-9342-dc6df48f0902"), -82217411, 0.5619178558705850m, "3vJK2CNb7HuApjaGUDxmRchwfPBZtqr3z", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2576), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2574) },
                    { new Guid("3fd7c99d-58ee-4d2f-aa3e-97cf2ef56377"), 1885793934, 0.1704819910995380m, "3GCwQKTLFoD63ymBzd1Zhc7rpaeb5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(907), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(905) },
                    { new Guid("439f983d-6dee-4b87-a893-7312569d99fb"), -569342457, 0.6715904439370910m, "M9AyCvrwHQcnK4TBRgaobGp7FExV3jiekW", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(640), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(639) },
                    { new Guid("442b65cc-6b45-41c7-b584-84cd0c5b4658"), 612225570, 0.6947575755452120m, "LVAprHx9MF6yq1DoSTsPQBWckmtwZe4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(839), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(838) },
                    { new Guid("4499f3a9-8828-4a81-b9c5-0aafb6ddf387"), 1979277371, 0.721536662383770m, "MqZiL1TuWpRnzHYyjBwJvkPt5Eb9G6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(379), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(378) }
                });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "PromoCodeId", "ActivationCounter", "BonusSize", "Code", "DateCreated", "DateDeleted", "DateUpdated", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { new Guid("4602f0ae-5f33-4b47-a00e-75eef1d1df7f"), 749512610, 0.2433464548860260m, "McboYJuZxDk1Xy3E4evHGBfq28i5ahs", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2487), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2485) },
                    { new Guid("4ef0c6c8-49fc-4d91-b8c9-7699db4c9b88"), 1206131770, 0.0952881914174620m, "3jYMXbPZkN39TCRFqEd86KBGa7vyemws", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(1155), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(1153) },
                    { new Guid("4fa55b29-7d8b-47ed-86d0-4d2bf9462957"), -679653538, 0.01044695679465770m, "3pc7TPJnf4uk9qxRGBMwjehN1bdDX", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1674), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1672) },
                    { new Guid("4fff3d54-dd2f-47d7-aee3-714873c83c4d"), 330214855, 0.03185829829092570m, "MGm8EXqj9vcpboJtTx4DFyerUHw6V3aQY", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(887), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(886) },
                    { new Guid("52441390-d4eb-421a-be09-87f994e9949e"), 1901345348, 0.6926163413785550m, "3PqyFD8edGou94cMLafknJ6ipwz1YbQ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(563), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(558) },
                    { new Guid("53ff920b-d82e-4f8f-a23d-b6979d9cc7d6"), 1262769422, 0.4407765810603680m, "MZB7PUdfRN4ueHQMYypK3J9mxLVTbratCF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1698), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1696) },
                    { new Guid("584ff235-fc3d-4de7-8ca3-65426f92687a"), 2005691012, 0.3988987868353210m, "Lfe9MdzHRmSZYVoP6nvTE3Dt5uXw87p", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1522), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1520) },
                    { new Guid("5f57392d-a0a0-49de-85e0-7b78e7e23441"), 1541878734, 0.6912441293713790m, "3XDQur7M2KijWyqBn3RaLvzxcS8owhUZP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1852), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1850) },
                    { new Guid("62440a0a-66fe-4bde-b395-69e240c8696b"), -1872678399, 0.1511053101749270m, "3qT2D8xsynoZg7PibY6k9FC3MaGHEfwJ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2226), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2225) },
                    { new Guid("6ffaf7df-b478-4312-a6d4-60dd20f60c57"), 1307524923, 0.2407695999822080m, "3sixaB5y6KrMnHdCezwjY3JvtUE4m", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(948), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(946) },
                    { new Guid("710ceaca-74f5-4bed-8f34-b703b16400e2"), 559173220, 0.4441472903919940m, "MJexB1s5FUgA2atNpTKiYkZMQyq9S", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(476), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(475) },
                    { new Guid("76c41c4f-2b1d-4512-8687-8edc25da740d"), -548650621, 0.4697059994319880m, "MjvNJ7MXxZet3EG12wcFAioPqrRmbsDCL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2533), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2531) },
                    { new Guid("778428f3-c5d3-42ee-bc3b-c50c1dd63a92"), -548647932, 0.7405858594407170m, "M1HkTUJoieLQFcd7yMSKWRtvNu6CfxE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(397), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(396) },
                    { new Guid("79a78a5e-72cb-4ff9-af7c-f7c9d8d324ff"), 871468107, 0.4375109045109360m, "Mbj2hEkHRrni6NT7cJL8GAYvade14", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 924, DateTimeKind.Local).AddTicks(8055), new DateTime(2024, 6, 2, 0, 22, 26, 924, DateTimeKind.Local).AddTicks(4873) },
                    { new Guid("7b9fdefd-b847-414a-a525-af7bae9c8669"), 916157605, 0.6545665420938780m, "LJqiQ1hLoZsHBtja7b8VkgGDR5czn3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2138), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2136) },
                    { new Guid("7d48e6ce-2b1e-4272-893e-e6228d3942eb"), -777093694, 0.5793397355208780m, "3zuoqnt5vM3E6SY4JpsBTgmNr2wVeyGiP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(1236), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(1234) },
                    { new Guid("80bbbd7c-1a98-4602-952c-869a9b4db50e"), -1027716222, 0.7968872232859380m, "LTNrKXqdtiG3nHbupS8B5UyWR12CkYM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1546), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1544) },
                    { new Guid("81536522-22b9-4eac-b2c3-fcb01bcd3925"), 748027498, 0.03978285469528410m, "MYWCwg9iNq1cReDymrAQxXkjpMTuV2So", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(759), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(757) },
                    { new Guid("818b79e8-1331-4a69-a381-a80a9413a3f1"), 698779115, 0.3349226869063640m, "L19yEh8RwQ7pXoBztMD2FNYaC3efA5WHU", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(541), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(539) },
                    { new Guid("8371c9cd-f3ee-43a9-828d-a845e8157a78"), -74307158, 0.4110747586456030m, "Lu4AUbePJ5CSvBTiKtkHFwY1shpW9Ny", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(697), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(696) },
                    { new Guid("84cefb49-1678-49e4-bce1-c4c19517a705"), -1206608442, 0.3832652327212830m, "MdSFQwaMh6RNc3H7VnLYr1pxKvyTJ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2205), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2204) },
                    { new Guid("8eb4bb70-2c12-46c5-8dd5-669921a139f1"), -1045224048, 0.8486286947843050m, "MUQP1f847CyBZMdGqJWe5AhXjscFHDxTu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2269), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2268) },
                    { new Guid("940c9929-0312-443c-bb24-8257516e1ec7"), -602132362, 0.9439042230115420m, "3TdqPxjwrWtByCzV2nHk64LKJ19FfDaZv", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1604), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1602) },
                    { new Guid("9414c57e-056e-453e-a483-3fab66643d8a"), -1885352751, 0.6491603319653150m, "L4Zra7S6u5kxLbpDPHdjqeR31zcThUo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(339), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(338) },
                    { new Guid("94ef44c9-ed0e-4add-9406-477ab9585e9c"), 1409858223, 0.01530722293697380m, "Ln8FLiShrsMjG7NEYQpduyCAPHm52Wv4o", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2444), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2442) },
                    { new Guid("9d3cdf97-e894-4944-b8d7-da581b05b684"), 2103124343, 0.8865510304999120m, "LShKxd2b8WMqpV4moPQa7zj9vHZuLCETNk", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(988), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(986) },
                    { new Guid("9ea4a0e1-001e-47d4-a289-5f9604021aa7"), 1359393501, 0.4279150495942040m, "L3AepXTRHudM1JkGCB8Lz5QjU6nD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(1101), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(1100) },
                    { new Guid("9f3bb7fe-a0c0-47d2-9284-d86168fcf68c"), -611614564, 0.05342139874074070m, "Msf3CtyuJkiQjmSvpGUVWeNnBhT2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1718), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1716) },
                    { new Guid("a141ffdb-3847-4ff0-8876-144b327192a4"), -1907640079, 0.2166122157424660m, "LGJmjnr4eH97zf5vFEopDCU23LNbXBAWda", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1917), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1915) },
                    { new Guid("a1c9cf2b-c774-4a3c-9909-0534c64fa448"), 1598061824, 0.6541568497377520m, "M23UcGSByPu19iHW6dAwhs7z4xb58ktYaR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(968), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(966) },
                    { new Guid("a27f512a-7864-4e69-a906-683ae3ea19df"), -1725730206, 0.5073462436507020m, "MF8AHUfp4NW1Gs2DvCkEc7hwguPZ6dL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2111), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2109) },
                    { new Guid("a4c5ead5-6c1b-4ffa-8b3e-6fa215c51720"), 252277014, 0.1897985061699780m, "MHCDyAS3MwshFEX1vjV5QLzRubN4me", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2009), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2008) },
                    { new Guid("a7f8281a-ad95-4ebc-9d00-c36d228f8319"), -1289995767, 0.4745546244661450m, "LHtpX9bfGzWeKi561AxnZy2UJEqh", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2049), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2047) },
                    { new Guid("a837d04c-0433-40a7-9767-d32482e35f48"), 1135098599, 0.2839744323843050m, "MsefxBwNjpPimA9q2ZRSrFnWvGQXHtu4Y", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1963), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1961) },
                    { new Guid("a9ab3fb9-80fc-4bac-9241-ecdf42f5fae4"), 361987613, 0.781286348650010m, "LzMgaHZYSuhQDPkVA2L8fF4Nb7e1tcJ9Bv", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1874), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1872) },
                    { new Guid("ab0aa35a-2e21-43b1-b03d-2715cb3ae426"), -1329059631, 0.02741530276355890m, "LvAcLwTWd1UiSyR2bZuFn7DrahoXYpHJ9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1831), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1829) },
                    { new Guid("b08737c0-3393-480b-a5de-a7259d544413"), -1324319230, 0.2588379724034060m, "3zTUVRH2KEoxWa18hJ9q3CcXdibMp", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1739), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1737) },
                    { new Guid("b2076e05-2040-497b-94b5-2c2088fe4d0c"), 1024058721, 0.7343901044901290m, "3sEGwiuyWB51VYhp4JaHmXvFb9qcCeAd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1625), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1623) },
                    { new Guid("b3e35057-a160-436c-87a5-b45f3cdb1cf1"), -681835878, 0.7325642638636910m, "MDYTMomWEpUS1hfGdv7K9wAFtqixkuPB4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1763), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1762) },
                    { new Guid("b4234751-5601-4123-a9f3-8beee52dc6bb"), -174977416, 0.3495554039657720m, "L9X7LuVdYb5AMPnTJNGsBEx6faC2pHQg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(582), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(581) },
                    { new Guid("b8433492-dde7-43c1-868b-55878768dbb6"), -2018235277, 0.2125283779593680m, "3Ku72qYU8pMJZHEzLfsWxDGvFPdjna3Ai", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(740), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(739) },
                    { new Guid("b8f7201c-1872-4802-b4bf-10b844c60ac1"), 154417322, 0.07774599519630210m, "LuGh91jHL4WYsMoV3KbQ7XngykN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(282), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(280) }
                });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "PromoCodeId", "ActivationCounter", "BonusSize", "Code", "DateCreated", "DateDeleted", "DateUpdated", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { new Guid("b9556136-f85b-41aa-acee-559c18dcdaea"), -1492746085, 0.4943168908836970m, "MqGCKMQe18AsnmhdTJf3BoYt7g6HF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(600), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(599) },
                    { new Guid("bb46f7e3-09d6-471a-8f87-4e27cce74bf9"), -20485531, 0.9024236876571760m, "3DFr1Z7wuLcj3MfaTsAhWqCktyipzm", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(619), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(618) },
                    { new Guid("bbb3e59e-5f0f-49be-9670-04c3f528953d"), -53995224, 0.5746698438672590m, "3WS5BzLiDGj7vgCXqofnH1s8ctabUd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2165), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2163) },
                    { new Guid("bffca68d-20ee-452e-b63d-92a57449353e"), -520918100, 0.4897236052480580m, "3TZ8qw4xAbBtJFRGp3XyzaiHoNcQEksdv", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(868), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(866) },
                    { new Guid("c1c8ad0e-ae44-40d1-9bbd-1d7656608e4e"), -1951291509, 0.203210547166650m, "35MRxiadYBeWcJTjAf2P6tm71hS9Qw", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2185), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2184) },
                    { new Guid("c6b3c01d-1a93-4c14-81b2-4792de9e964d"), 1119572495, 0.3337498724218750m, "3tDBoXeVdLR28E7PN53CkjZQMSW", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(1062), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(1060) },
                    { new Guid("c953a11f-ee33-427b-82f2-6887c43b7b25"), -310605464, 0.3693756111280080m, "LLPH6pNdrn13Gh8yAYVs75DRCboK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(320), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(319) },
                    { new Guid("c9eed078-25ec-4504-9b5e-08f955cc78d8"), 179587962, 0.5300949222704480m, "LZ6VYvFqNnUrQzp7uRfJgA1X8wGhHMd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(233), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(230) },
                    { new Guid("cc02102c-ade3-489a-854d-cbb2eb88540b"), -1558704188, 0.4764415575809850m, "LLuFQAdfSNZ3Gz5sTXpw1mWnbU8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2381), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2379) },
                    { new Guid("cf24fda1-e15a-4993-9705-77380c683ee1"), -830250793, 0.8101655725709650m, "3MYDLzCvZG7mjkHnqFoiAh5U2KPJQf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(423), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(421) },
                    { new Guid("cf769c61-73c8-497b-9709-f56319211e72"), -372432534, 0.3182045539785240m, "LPyTWkfM6QbodU5Cev7ZLi3VaYF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(263), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(261) },
                    { new Guid("d49bd2fd-8d9b-4622-81be-353561477185"), -1285806915, 0.8721970797398040m, "MbgoDQLtRGuycq4aX29jdUKsJiMm", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(677), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(675) },
                    { new Guid("d657efd6-3d27-42fe-a79c-abaae89f5c6a"), 1514098613, 0.8468144913198210m, "Me5bTZR2J8cMvFCpYWtNGij1sXP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(520), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(518) },
                    { new Guid("da55b5f9-bd78-4ac8-be8b-cc73240f1d99"), 1071870591, 0.5572077501748960m, "MTw7Jo34nRZQyqpeiUGaX1trK6ND5k", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1578), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1576) },
                    { new Guid("daed7757-a587-45ee-9203-edf9f0f9660e"), -184415408, 0.8458960005930190m, "MR1qYQutcSp5vbZ7VhDKWryd6sweEGiMJ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1475), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1464) },
                    { new Guid("dbc2eafc-3c43-45a5-af5c-0f9db5811fef"), 1214621615, 0.5598688161855370m, "3Ex6drSeziJMnVK9A7FHqyDtXgPRkZ3o18", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1895), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1894) },
                    { new Guid("dce2b27b-a779-43bf-9e28-7db8307f3070"), 1279731226, 0.03151841929706020m, "37pVuiY9wDnXkAmU5zPc1vBZa2LJ68", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2423), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2421) },
                    { new Guid("df36531d-dd11-460e-9fa2-7ab46cf5bc65"), 218589818, 0.7768832406912290m, "LE83szNm4StBkb5PwRGdZM2hqCDr9FTv", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(659), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(658) },
                    { new Guid("df3ba06c-ee1f-420d-8bdd-0f9fc172d32a"), 1558025705, 0.3683472874087880m, "LQBC3unEzKJbScfAtha7U8416gDo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(441), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(439) },
                    { new Guid("e2ab6b46-4451-4238-b751-e09a41311f60"), 1530242055, 0.2577181610163790m, "M9hA4uSR5dmFLi7cZsEJVG1YX6kgoD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(1172), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(1170) },
                    { new Guid("e2ca814a-7ef0-4042-bd27-8c1df70528d3"), 1709413858, 0.1110513849109550m, "MjvErG45zqBP7Z83wgsbYocVAixmFRt", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1653), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1651) },
                    { new Guid("e404e01d-9ef0-4261-b301-5d2cb2b1e428"), -1753398244, 0.9323028933400310m, "ML1YuoWBG5zA98rix3esEbjfSah", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(459), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(457) },
                    { new Guid("e46a1a44-ccf4-4e22-86d8-eca06908a288"), 1469777458, 0.4313199950376150m, "LNFoMbu5vCjryARhWgfPDdB3H8ckV7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1805), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1803) },
                    { new Guid("e789b3c4-283b-419a-a3e4-2fbbd2f60183"), 151330465, 0.4283293877170820m, "MXb4PdDLVgnxYj1GKsFMTBtrhkSW8cfCyQ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(1192), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(1190) },
                    { new Guid("e83e56d3-8f4a-41e8-a43f-952f9468d13c"), 585843982, 0.3262699742114890m, "ML2rdyR4SgFos8Yk7AHEuh1CzqBv", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(1136), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(1135) },
                    { new Guid("ea1e79eb-51af-46d1-bf86-b8b9dea489db"), -1731405285, 0.5504480683052730m, "L6V3uymWPrZSRT8Bsai1J9bh7xpf5w", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(1025), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(1023) },
                    { new Guid("eb1d9eb5-2005-4b58-a7a2-b61eea56e4e2"), -721122613, 0.8987277323398710m, "3TYixPRsCL7f1cj8aNZoMeV9HhFvXqz", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2314), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2312) },
                    { new Guid("ed777c7c-698f-4fab-9b78-25a03f1b8c6d"), 98795269, 0.5844793141158980m, "3HVd7sCjqB1GeoimW5AD8hnFRzXp", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(929), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(927) },
                    { new Guid("edcf5492-a4f1-4ff7-96cb-d399708338b2"), 1850218680, 0.4453766298711250m, "3K9R3jwhZB85paytVCAeksMXgPYfb2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(776), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(775) },
                    { new Guid("f13b4b93-8e7e-4077-9619-f3ea969f7468"), 1863937174, 0.1994435710537430m, "Lcy9buZiQTEqV7MrB6kgvXzfR4FS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(1042), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(1041) },
                    { new Guid("f433feca-778c-408e-b305-0be5bb30151c"), -1476374036, 0.7664704538751450m, "MbrqpUyigShaW4uBxMz1C9QARKvTfYPEc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(499), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(495) },
                    { new Guid("f60674b6-b682-4779-ad71-f9260aba732c"), -2061994532, 0.9934478847178890m, "MY5ixc4kPj1Dzefm2LSwEdCthATbFUaJpr", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2402), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(2401) },
                    { new Guid("fa9e8b12-7ae7-4520-a77f-d89b877fef03"), 808930745, 0.7597718277592840m, "LTMsGjJcnPE2wQYDLtxXmeH5fUZAyFh3Cp", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1984), new DateTime(2024, 6, 2, 0, 22, 26, 925, DateTimeKind.Local).AddTicks(1982) },
                    { new Guid("fe6fa3b3-b447-49f9-a5dc-c4b444e5fd91"), 1091939750, 0.700042694728340m, "M7SNVLUvenDMhBmkqP6QdZEYfFosiJu4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2024, 6, 7, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(358), new DateTime(2024, 6, 2, 0, 22, 28, 941, DateTimeKind.Local).AddTicks(356) }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("00538f00-fb21-4ee0-8067-549be34be4af"), null, null, "Clementina26@hotmail.com", new Guid("922f53da-9877-4d56-a64d-6d83331bdbb6") },
                    { new Guid("00a5288c-0988-4425-b93e-0c9a34075ab2"), null, null, "Telly_Hickle6@yahoo.com", new Guid("2078228d-bb74-4e81-8e84-3dd4a76ea271") },
                    { new Guid("00bd82ad-b6f8-4d68-b54c-fdee4b1e960c"), null, null, "Noelia.Frami62@hotmail.com", new Guid("abfe1efb-0a8f-4af4-ab49-6de94e3ef374") },
                    { new Guid("01666082-5bb8-4566-b106-61aa607c29ce"), null, null, "Murray.Keebler@gmail.com", new Guid("b72dbc44-743b-4e39-a250-af429c1f09a9") },
                    { new Guid("01dab739-2c28-4ba2-8848-687b70153280"), null, null, "Micah.Goldner@hotmail.com", new Guid("7c403944-d570-486e-9c1f-e40454a443f6") },
                    { new Guid("02177ff6-dcdd-4ff8-9948-89ac60260825"), null, null, "Christopher.Huels28@gmail.com", new Guid("1fda2339-4864-46e3-bf7d-81a520206ae9") },
                    { new Guid("0266eac4-a1a6-4aab-8f27-ddf0e6fdd9f7"), null, null, "Adrain.Watsica97@hotmail.com", new Guid("5af211a7-f736-4b52-b2bb-493388054061") },
                    { new Guid("02687681-9dab-4a23-a82e-7588ce10a9bf"), null, null, "Brionna32@hotmail.com", new Guid("af831e9b-a557-4f53-81e7-2278eb8802a1") },
                    { new Guid("02b32553-c35f-4f86-b4d4-d6f1818091ee"), null, null, "Annabelle.Conn60@yahoo.com", new Guid("732ba531-5faf-4b4a-bcac-24d9ca3fcbc2") },
                    { new Guid("02bbdb0a-1e7f-4c0e-a15a-eb3433ed5787"), null, null, "Soledad.Nienow@gmail.com", new Guid("4a66fea0-71b8-4943-90c9-d349550e6fe9") },
                    { new Guid("02c30f00-857b-41a4-8dc8-ebe25976c2be"), null, null, "Neoma.Crooks@hotmail.com", new Guid("65cb2c49-f00f-450e-94e8-540312a9ce09") },
                    { new Guid("02e3b030-70bd-44d5-b25d-34b7d5941f6c"), null, null, "Jensen_Schneider99@yahoo.com", new Guid("f088f668-331b-405e-b41a-5cc648df081c") },
                    { new Guid("0353278e-661f-4881-8942-f1c6c8572004"), null, null, "Davin_MacGyver17@hotmail.com", new Guid("9252c306-249a-4267-8ef5-891d8c0cbea1") },
                    { new Guid("043fb301-2021-4e53-b299-6fdb176d1a7b"), null, null, "Matteo_Heathcote@gmail.com", new Guid("b7003b5f-1610-4487-9fd1-c03a6d0982d7") },
                    { new Guid("04b83c74-c568-4738-9692-79cea68dd052"), null, null, "Foster_Kulas69@yahoo.com", new Guid("011fba87-398c-42ec-9aa7-ffb9c48fe9a9") },
                    { new Guid("05111106-b783-42c0-a8e7-98a36e5acd59"), null, null, "Dorothy24@yahoo.com", new Guid("9336f657-bf13-4455-becf-1afff818911b") },
                    { new Guid("051b4bc5-a650-4f08-b211-206dd15ca919"), null, null, "Bennett_Runolfsson@yahoo.com", new Guid("54f16999-7e05-407e-aab8-1c56cdb79653") },
                    { new Guid("05470cf6-4644-438e-ae0e-ac0e521be33b"), null, null, "Arlene_Carroll21@hotmail.com", new Guid("b2abd3eb-7d4b-49b1-8a46-4ea8b8313ab8") },
                    { new Guid("055e2136-4352-44ab-bd8c-66f31a91046c"), null, null, "Malika_Nikolaus41@hotmail.com", new Guid("ab38dbfc-78a4-4d84-9e77-53448911bc9f") },
                    { new Guid("05835fb3-9f4d-4032-995c-7ecf46c2b359"), null, null, "Marco.Weissnat@yahoo.com", new Guid("0edec355-b022-4255-80d6-c530f687d26e") },
                    { new Guid("0588bc9f-9518-4f79-8d7f-cebd4a097630"), null, null, "Christophe.Streich@gmail.com", new Guid("fa671618-4f8c-472d-aad1-18adb7778e70") },
                    { new Guid("06624092-6fc7-4c3b-bba0-db4422adc94e"), null, null, "Vergie80@gmail.com", new Guid("371bed01-75b2-47b9-9535-3156b9a4c959") },
                    { new Guid("06906056-551a-4329-b30c-784fad31b6df"), null, null, "David_Bartoletti@yahoo.com", new Guid("7247fafb-5d1e-43fe-a447-5b99c26b77ba") },
                    { new Guid("0691b052-3375-4023-b42a-1373458af028"), null, null, "Madison34@yahoo.com", new Guid("a0d3cad9-30ac-4da2-8952-dcde6122a64a") },
                    { new Guid("06a5d789-935a-49e8-9650-fcb593c56a89"), null, null, "Carissa.Herzog@yahoo.com", new Guid("73cff5d2-f041-4e6e-8857-560606637e86") },
                    { new Guid("06f48df9-75be-4ea9-b902-1616badadecd"), null, null, "Kiarra47@yahoo.com", new Guid("6de94a05-0c03-4062-8ab9-57a5bd55b3a5") },
                    { new Guid("07369cbb-defa-4e3c-a7c5-48301c7021c8"), null, null, "Mathew.Nicolas@gmail.com", new Guid("611b8b1f-53d5-4660-9ad4-e0b57e915bf8") },
                    { new Guid("07781efa-7461-4df1-b93e-3014446519c8"), null, null, "Gabriel.Skiles51@gmail.com", new Guid("a4fd1dcd-4db0-4a8a-9303-ecaf58ed8a81") },
                    { new Guid("085e1b04-8aec-4c7a-ba70-7c4ec0f693fc"), null, null, "Ramiro.Lang@gmail.com", new Guid("1530b862-24b5-484d-8939-50315a49bd13") },
                    { new Guid("087c2278-c1ef-46bb-9374-559f5c619b41"), null, null, "Clarissa.Cummerata72@gmail.com", new Guid("f78b821b-0629-4e64-a36a-3d10ad04e07a") },
                    { new Guid("08be34e5-3379-4333-85d2-6a9d7141b6ca"), null, null, "Kayden22@gmail.com", new Guid("1281e6c3-dc02-4e83-a90d-37f640411dfc") },
                    { new Guid("08d11fc1-9e63-4c55-bbce-8135d4c0a2db"), null, null, "Chet46@gmail.com", new Guid("df2bde0b-bda8-499f-b5cc-cfa7429222d1") },
                    { new Guid("0967f451-7bed-49aa-8b70-6d35ce4fcf6c"), null, null, "Celia88@yahoo.com", new Guid("11b76a5d-870e-46d3-b3e3-0af0f8f871ac") },
                    { new Guid("09914fb2-085c-4811-8e97-ef42a7c99408"), null, null, "Sam.Lind@gmail.com", new Guid("f498a63d-900c-464a-8fab-e4232968dc8b") },
                    { new Guid("09d25f97-47b6-4390-8c70-db4dae8b682a"), null, null, "Janice.Halvorson8@hotmail.com", new Guid("a4972888-e048-48a4-a351-23bd705a917e") },
                    { new Guid("09e289eb-d532-4881-a236-9771d3a44e69"), null, null, "George71@gmail.com", new Guid("12f12b30-ab20-433f-91c1-e6f9be859390") },
                    { new Guid("0a68fe41-2fee-4bf9-be4e-7343b658bab2"), null, null, "Mario84@gmail.com", new Guid("143cf7ff-f2e3-444c-a15b-3aa7b4c43475") },
                    { new Guid("0a9b55df-81eb-45b1-a1f4-98227ce0bcc1"), null, null, "Kaia_Anderson@gmail.com", new Guid("54f16999-7e05-407e-aab8-1c56cdb79653") },
                    { new Guid("0aaabd86-21d9-474c-999f-4539d78dbc8b"), null, null, "Lula55@yahoo.com", new Guid("ab522845-c1bd-4f82-bee3-06f49429e4bf") },
                    { new Guid("0ab4aacd-f8b1-4917-aa54-0d8387ca0723"), null, null, "Burnice_Powlowski@gmail.com", new Guid("00e8ecc6-7b14-4020-bcbd-1a849d69a8c6") },
                    { new Guid("0ae19e68-fa8d-44c1-a452-fba38888ec1b"), null, null, "Evert_Gibson@hotmail.com", new Guid("65cb2c49-f00f-450e-94e8-540312a9ce09") },
                    { new Guid("0b287231-1f90-46b8-8dd8-5be3f82d1bfa"), null, null, "Lee_Lesch@gmail.com", new Guid("f498a63d-900c-464a-8fab-e4232968dc8b") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("0b698229-c59c-4985-9375-5b9418660a65"), null, null, "Madonna.Metz@yahoo.com", new Guid("36afa758-a0b9-4345-9bce-db873a3c22fd") },
                    { new Guid("0bd93c7f-ad8e-46ec-b303-1d939432892e"), null, null, "Unique_Welch@yahoo.com", new Guid("6ceec469-cfb3-42b5-b289-a4c2da0a32dc") },
                    { new Guid("0bdb1e8a-fbee-4356-9154-e41b84066c98"), null, null, "Lucie_Grant@gmail.com", new Guid("cffc8c5c-aee1-43fa-a247-e83b10ecb56e") },
                    { new Guid("0be17b80-8cee-40bf-b73b-94ba16624f0a"), null, null, "Loy_Kohler@yahoo.com", new Guid("8d7de522-82d8-4912-bf1a-5d80658097e7") },
                    { new Guid("0c0eea09-3862-41b3-bc92-91b2ef4edf0f"), null, null, "Stephan.Bradtke40@gmail.com", new Guid("73cff5d2-f041-4e6e-8857-560606637e86") },
                    { new Guid("0c4b5519-7b5f-46bc-a8c9-417a1fc66d84"), null, null, "Corbin.Parker98@hotmail.com", new Guid("b09cd69c-fd2f-4c43-9227-439aa81d485e") },
                    { new Guid("0c8df2fa-ace3-45d7-a6c2-5038df825e22"), null, null, "Aglae10@hotmail.com", new Guid("0fedadae-5c91-4999-9924-42f5fcd0de5b") },
                    { new Guid("0cdb728b-7fff-4432-983a-1e5db7cc167d"), null, null, "Lilla_Harber50@hotmail.com", new Guid("1070c404-0d57-4ba4-828e-4ca0d5ec2262") },
                    { new Guid("0d31c103-6794-48f6-a44f-0d3bf57b1972"), null, null, "Bessie_Mann32@yahoo.com", new Guid("c075bfdf-a5cc-4efb-a6d1-f31b0c4bf344") },
                    { new Guid("0d63bded-a791-4931-af24-f92b3a7a7333"), null, null, "Jameson_Hilll@hotmail.com", new Guid("b7065d5a-6bbd-485c-bd51-6a4a0fc35e18") },
                    { new Guid("0d87bec0-b674-41f6-a197-c7873f449fc1"), null, null, "Alia_Bayer@hotmail.com", new Guid("fa671618-4f8c-472d-aad1-18adb7778e70") },
                    { new Guid("0d981a61-623a-4601-b2b1-66b3f7d3b18b"), null, null, "Garnett33@yahoo.com", new Guid("a1e9eb46-748f-4b86-8554-7ae48675b2da") },
                    { new Guid("0dd72e23-8863-4b9c-abf0-d18be30d4d88"), null, null, "Camryn_Hilll4@yahoo.com", new Guid("c6c5dcc4-cc8e-4484-935f-918264ee4897") },
                    { new Guid("0de56f78-86fd-4bd9-88ee-fb31aaec426e"), null, null, "Libby22@hotmail.com", new Guid("ab522845-c1bd-4f82-bee3-06f49429e4bf") },
                    { new Guid("0e22446d-5bb1-4260-bd86-fc2225e8f549"), null, null, "Nyah_Hoeger70@yahoo.com", new Guid("1de915db-ea78-41e7-a3a2-76a8f6311629") },
                    { new Guid("0ec42fa5-dda0-4d4a-811a-9652db01de4d"), null, null, "Jesse.Daniel@hotmail.com", new Guid("bb021ddc-2731-4d61-8069-ddee5e7759da") },
                    { new Guid("0fa130f4-9c14-47ea-8e72-f16aba3d19f0"), null, null, "Brennon_Leannon@gmail.com", new Guid("e0518a7c-2290-4dde-8de0-19fe26c3d8fa") },
                    { new Guid("0fa7ea15-39f2-4c4e-8a28-9e20d106b669"), null, null, "Kareem_Wolff6@hotmail.com", new Guid("4e8f092d-b1e1-47d3-9de6-5d9db26187a5") },
                    { new Guid("105eec0d-96b1-4911-b69b-8fc032b2ea82"), null, null, "Roderick14@gmail.com", new Guid("89739d78-901e-4353-8c13-fe879541f76f") },
                    { new Guid("10d31c80-e5dc-4948-abb5-6ed367c52d0f"), null, null, "Bartholome65@hotmail.com", new Guid("7d6ad8fc-e102-4ea8-a3e2-5bdfda8f1650") },
                    { new Guid("111dde42-76d2-4227-88df-004cb66a68cb"), null, null, "Maybell0@gmail.com", new Guid("1de915db-ea78-41e7-a3a2-76a8f6311629") },
                    { new Guid("11a7268a-2cba-43af-ae55-61f0eeed79e0"), null, null, "Eino19@gmail.com", new Guid("b7f7d261-2525-4477-8b55-bba019231e9f") },
                    { new Guid("11e0e0ec-1211-46c7-a569-0899c5d31ef2"), null, null, "Cathy.Koch@hotmail.com", new Guid("cca9c534-e77c-400e-a849-210326576f8f") },
                    { new Guid("11e46236-da13-4ac9-924b-3b210ddeaf89"), null, null, "Alda.Koelpin@yahoo.com", new Guid("b252505e-f926-4638-a778-09894c7e3345") },
                    { new Guid("12201dca-2831-4aa1-a5f8-d99671106915"), null, null, "Isabelle79@gmail.com", new Guid("1fda2339-4864-46e3-bf7d-81a520206ae9") },
                    { new Guid("12504e37-17db-4f01-88ab-a87148b371a7"), null, null, "Waylon.Hirthe@gmail.com", new Guid("732ba531-5faf-4b4a-bcac-24d9ca3fcbc2") },
                    { new Guid("125f478c-88d6-4ff5-b902-175215a8681c"), null, null, "Blair.Connelly0@hotmail.com", new Guid("8c8ff9a2-2752-46a7-960e-0490c28de13f") },
                    { new Guid("12709183-9f72-422d-938f-13d0598fa141"), null, null, "Agnes.Wisozk@gmail.com", new Guid("11e566bf-b29d-4651-8e8c-7f65a8281c80") },
                    { new Guid("129f3dba-627a-499a-b8a8-37d990b467a1"), null, null, "Sherwood_Fisher@gmail.com", new Guid("5398a079-6d82-4f82-8917-3f9eea9310eb") },
                    { new Guid("12a88b29-472b-4a24-9ad1-d52c260f7eaf"), null, null, "Ofelia_Padberg21@yahoo.com", new Guid("b7003b5f-1610-4487-9fd1-c03a6d0982d7") },
                    { new Guid("12aa2818-1412-438b-89b8-2d4538594fc5"), null, null, "Janet58@yahoo.com", new Guid("9e9403fb-605a-441d-a83a-f936fec7582f") },
                    { new Guid("12f27af1-36cb-4982-a08c-f43673a3ea51"), null, null, "Jewell52@yahoo.com", new Guid("f2fc34d0-f967-4d49-ac54-2191c244d200") },
                    { new Guid("13ae4036-cff7-47a9-b68f-1c56cc5ca001"), null, null, "Hope60@yahoo.com", new Guid("7319b27d-6146-4420-aa8d-717913c33345") },
                    { new Guid("1413c9c8-244d-4658-a675-6ebed3f66605"), null, null, "Moses40@yahoo.com", new Guid("8c658576-57f3-41cc-9a3b-917efb1480d9") },
                    { new Guid("14e17f2c-6005-4698-8d98-66faebcb67ca"), null, null, "Xander.Williamson@hotmail.com", new Guid("d9b74426-c418-4b51-a42a-af5906c2fcff") },
                    { new Guid("14e65dd6-4b1f-46bf-91ea-06aa5b0ece5f"), null, null, "Kiel.Kreiger@yahoo.com", new Guid("2f3d1b8f-7590-4d18-9002-4caa22511a8b") },
                    { new Guid("153ef744-2d72-4619-9bf1-0fec44c2b7c7"), null, null, "Lora.Gleason39@hotmail.com", new Guid("ebecc10d-21da-4369-81d7-600c2de48f88") },
                    { new Guid("158b4a25-6462-4707-b542-1f77ba1031b6"), null, null, "Arthur_Stiedemann@hotmail.com", new Guid("c075bfdf-a5cc-4efb-a6d1-f31b0c4bf344") },
                    { new Guid("15908d4d-a7fb-447e-afff-48e210e5d125"), null, null, "Yessenia_Sipes30@hotmail.com", new Guid("00e8ecc6-7b14-4020-bcbd-1a849d69a8c6") },
                    { new Guid("15d4aeb8-e1cc-4d6f-8430-d5514960c7aa"), null, null, "Maida79@hotmail.com", new Guid("500d7059-5719-42c4-a15e-d4753ba03714") },
                    { new Guid("15f27c64-33cd-46d4-b74d-1943b950aa61"), null, null, "Jerrod.Ullrich@yahoo.com", new Guid("b7f7d261-2525-4477-8b55-bba019231e9f") },
                    { new Guid("1611740a-35a2-413a-8765-672ba514c4bc"), null, null, "Demetris91@gmail.com", new Guid("f5193487-04f8-4c23-b0cd-90340ebc9154") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("164435c5-1dcd-470a-a65a-3d4eadc5e074"), null, null, "Grant.Gerhold@hotmail.com", new Guid("11b76a5d-870e-46d3-b3e3-0af0f8f871ac") },
                    { new Guid("16f2d046-3102-4e15-bc82-e6d584f762c8"), null, null, "Shane74@hotmail.com", new Guid("f2fc34d0-f967-4d49-ac54-2191c244d200") },
                    { new Guid("16f79809-2134-46b3-94fc-2acaeaa04e04"), null, null, "Carroll_Cole5@hotmail.com", new Guid("23dc6e61-4215-4b56-b081-13cd0b456e6f") },
                    { new Guid("1748a8c2-0819-4b96-acab-8e722d87a060"), null, null, "Thad.Pouros@gmail.com", new Guid("a66e6d00-7000-4eb2-994b-a38594503957") },
                    { new Guid("174ade34-7491-45fb-b134-63b57e751146"), null, null, "Isai28@hotmail.com", new Guid("4a66fea0-71b8-4943-90c9-d349550e6fe9") },
                    { new Guid("17537716-bc14-44c3-a7c1-8a510978a996"), null, null, "Ardith88@yahoo.com", new Guid("fa671618-4f8c-472d-aad1-18adb7778e70") },
                    { new Guid("1789f964-369d-4120-a480-161a0c5c8a7b"), null, null, "Jonathan_Mann@yahoo.com", new Guid("a3bc456f-939a-42c3-99ed-719e0db5bf18") },
                    { new Guid("18725403-813e-45c5-81ad-7c0ac79a0a8b"), null, null, "Clifford46@hotmail.com", new Guid("77f28b3f-3ca9-4819-96c6-bd1e811a39f5") },
                    { new Guid("188c107e-5a97-4bde-b18e-7bbbfbc80ef7"), null, null, "Twila_Weber@hotmail.com", new Guid("ea94f56c-ef76-423b-81af-2da80b37dfa6") },
                    { new Guid("18ecba46-4e3e-4f97-893d-4bdea330ec5f"), null, null, "Ernesto.Boyer@gmail.com", new Guid("aa406ff8-810a-45a6-8b41-5028563ae3b6") },
                    { new Guid("19476198-345d-4113-8c5e-668f5f0aeaf6"), null, null, "Marisa_DuBuque@gmail.com", new Guid("4e8f092d-b1e1-47d3-9de6-5d9db26187a5") },
                    { new Guid("19cf51d7-bba7-42ae-b0b6-cb1abcf49a1b"), null, null, "Jane_Schneider70@gmail.com", new Guid("f3ea0004-e1e2-4557-a9d5-14a5369a2eb3") },
                    { new Guid("1a1ba5a1-9bc4-4069-800f-4c88dc6537da"), null, null, "Leslie_Romaguera@gmail.com", new Guid("8de401f3-837a-4e09-884e-ddf9af867804") },
                    { new Guid("1a9e2591-c79b-4e63-b835-2900a82b92b4"), null, null, "Asa_Schiller@gmail.com", new Guid("a339ea33-3188-40c2-9d84-9ea46aa67e82") },
                    { new Guid("1b214360-99b6-4cfe-adb8-59b8c46eff2d"), null, null, "Emmet_Bergstrom@hotmail.com", new Guid("07169b5c-40fd-40ba-b01e-8b56de466065") },
                    { new Guid("1b47a45f-ed3f-4718-bb10-7f32ff0d3766"), null, null, "Norbert_Cartwright@yahoo.com", new Guid("ff5c3ca9-e336-4c0b-bb16-8a689eb03900") },
                    { new Guid("1b599c51-989a-4380-98ec-86ece34797c1"), null, null, "Emmett.Gutmann@hotmail.com", new Guid("479adb19-03b9-482c-b165-7766492bfdf2") },
                    { new Guid("1b68c63a-8657-4fc4-a1c0-497a1f85b240"), null, null, "Shirley83@hotmail.com", new Guid("77a05cfa-406d-4342-a924-73d56bf2829a") },
                    { new Guid("1bc31bb7-5f38-47a4-8c2d-f060c051c536"), null, null, "Jack_McKenzie@hotmail.com", new Guid("64677ac4-f6ca-4452-9192-ce10eab5a7a4") },
                    { new Guid("1bdac317-b833-470e-9dac-cd355d1d7533"), null, null, "Desiree48@gmail.com", new Guid("ae39cf22-04cf-4eb4-8b28-b59be4789ea6") },
                    { new Guid("1c3e9670-c0de-4176-a1a1-c8557e76d8fa"), null, null, "Olen.Hamill@yahoo.com", new Guid("980f1926-46d3-48d9-880c-73d0be9fa1e0") },
                    { new Guid("1c44f74d-2647-495e-93c3-03cd6225ef1a"), null, null, "Jean_Cummerata@hotmail.com", new Guid("2275ad3d-6816-4c2b-ba9c-96a3dc4f45fb") },
                    { new Guid("1c4ae182-9078-4e83-ab11-b42d225f8338"), null, null, "Major_Runte@hotmail.com", new Guid("6de94a05-0c03-4062-8ab9-57a5bd55b3a5") },
                    { new Guid("1ced85d9-0dfc-47ef-a335-189ab89d4fec"), null, null, "Mozelle_Maggio82@gmail.com", new Guid("11b76a5d-870e-46d3-b3e3-0af0f8f871ac") },
                    { new Guid("1d132812-4c44-4cce-9ac1-34aa748cb8af"), null, null, "Carter31@hotmail.com", new Guid("85626191-e7df-461f-8d6e-58391f67d36a") },
                    { new Guid("1d2f28ea-b27b-48c9-b5ad-845bd6a5c716"), null, null, "Alexandro_Monahan@gmail.com", new Guid("07169b5c-40fd-40ba-b01e-8b56de466065") },
                    { new Guid("1d36538e-19dc-4557-b534-ce0c669f31d5"), null, null, "Leda_Christiansen20@yahoo.com", new Guid("428063f6-fd3a-42bd-b0be-ba01a5e85a84") },
                    { new Guid("1d771e85-8638-4a20-93c1-75d75a593901"), null, null, "Keshaun.Yundt34@gmail.com", new Guid("af67d494-10d3-4417-9f74-90816ee69f93") },
                    { new Guid("1db42cd5-15c7-424d-ad0b-c66ef8442f36"), null, null, "Estevan46@hotmail.com", new Guid("ff5c3ca9-e336-4c0b-bb16-8a689eb03900") },
                    { new Guid("1eb409a9-a82f-425d-af43-c77e3c891ad2"), null, null, "Waino_Koch83@yahoo.com", new Guid("f52649ec-b9d7-4f35-8295-ec4e2b5c564c") },
                    { new Guid("1ebc22c4-bc47-4a37-9e5f-78379bda0cdb"), null, null, "Kathlyn90@hotmail.com", new Guid("40de2c6f-e29d-4027-93c3-945e76ec015c") },
                    { new Guid("1efcfbf3-e33c-40ca-bca0-266d068739d4"), null, null, "Vida_Little88@yahoo.com", new Guid("a0042a3d-7eaa-4c67-b018-40977ff2a846") },
                    { new Guid("1f22b4c6-eaac-43a7-b089-253158abc293"), null, null, "Gayle91@gmail.com", new Guid("08e9beba-81d1-40e1-9f0f-4d282258b85b") },
                    { new Guid("1fe69edd-1b25-4953-8806-e1768117f2ae"), null, null, "Dion_Vandervort@gmail.com", new Guid("fbcf0085-dd67-4f41-b656-a0c0900baca5") },
                    { new Guid("209f33e4-af96-43dd-8a82-7b426f411d61"), null, null, "Lelah84@yahoo.com", new Guid("8c149454-da44-4038-9ece-768e572c5282") },
                    { new Guid("21629aac-dde9-4995-a243-577675918dea"), null, null, "Joanie_Shields@gmail.com", new Guid("52fe76ad-4c09-4b99-9385-e407990c0307") },
                    { new Guid("21e02295-c356-4328-ac2f-c490a511f818"), null, null, "Johnathon67@hotmail.com", new Guid("65cb2c49-f00f-450e-94e8-540312a9ce09") },
                    { new Guid("22051e40-8183-4ad8-9b5a-7c3280a32089"), null, null, "Judd.Swift@gmail.com", new Guid("750c9633-57cd-4cce-b195-c19394ee24b3") },
                    { new Guid("22c6eb51-749a-499f-bdb6-7bd7eb05c6a5"), null, null, "Mae13@hotmail.com", new Guid("5dd3e047-c6f3-412d-b5cb-12b416f99706") },
                    { new Guid("22d24c09-ae77-4a3d-91b5-22e7f1f92918"), null, null, "Junius.Ledner@gmail.com", new Guid("11b76a5d-870e-46d3-b3e3-0af0f8f871ac") },
                    { new Guid("22e6b8e9-e8a3-4285-9e2f-908af2e42061"), null, null, "Retta_Cronin23@yahoo.com", new Guid("a0042a3d-7eaa-4c67-b018-40977ff2a846") },
                    { new Guid("22ea9a5f-cad2-4787-8476-003fb0e68e3c"), null, null, "Jayda_Grady@gmail.com", new Guid("ac4b1e96-68b1-4502-856c-10b88acf07fa") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("2351dbf5-64ab-4838-920b-9a65175a64e2"), null, null, "Jacynthe.Armstrong32@hotmail.com", new Guid("1070c404-0d57-4ba4-828e-4ca0d5ec2262") },
                    { new Guid("23698817-40c1-487a-a762-c9e4629966f0"), null, null, "Sam17@yahoo.com", new Guid("09ee89cc-9f4d-4eae-a4f3-731ca2d52102") },
                    { new Guid("23698b44-8d1e-4c1d-9aa2-0d7c68e9523e"), null, null, "Priscilla67@hotmail.com", new Guid("17f01111-498c-4286-9021-ec1a09f4b1ca") },
                    { new Guid("237f0ff2-efd0-40e1-9707-f8497ecf5f2e"), null, null, "Elian_Conroy@gmail.com", new Guid("39fc9708-01f3-4ab0-8c26-d5bc00da55db") },
                    { new Guid("240450cf-9b21-46b9-a836-ae1e9a6ca019"), null, null, "Daphne44@gmail.com", new Guid("8c658576-57f3-41cc-9a3b-917efb1480d9") },
                    { new Guid("249cad8d-ef41-4ac0-917a-5e08a00c5be0"), null, null, "Kylie30@hotmail.com", new Guid("09fe5fb4-f36b-4a46-81a1-c617e335393a") },
                    { new Guid("258e6f9d-2b81-4521-b37c-04651e06b7fb"), null, null, "Edwina_Walter8@hotmail.com", new Guid("8343d773-e986-49d8-99e9-bd908398b011") },
                    { new Guid("25ee8bbf-f307-4549-b658-dc52bde6f887"), null, null, "Heidi_Purdy@hotmail.com", new Guid("922f53da-9877-4d56-a64d-6d83331bdbb6") },
                    { new Guid("26181285-decf-4ca3-92b3-2844beb9a68e"), null, null, "Glennie.Frami71@yahoo.com", new Guid("d62fe5e3-4821-411a-b458-87e89f41f2f1") },
                    { new Guid("2620487d-30a9-4378-a385-edc540cde442"), null, null, "Audreanne55@gmail.com", new Guid("7a4f4be1-0c5d-43fb-8b70-3e4913ca97a0") },
                    { new Guid("26c9996c-15a3-4225-8a02-a97c6683eb10"), null, null, "Carmela57@hotmail.com", new Guid("9f2db745-dcf4-4a49-a27a-ae15a2f3087e") },
                    { new Guid("26e63cde-629a-43a4-9975-f4b666ba809a"), null, null, "Erik_Davis@hotmail.com", new Guid("c0159440-683d-4c76-a904-aa1f4564822f") },
                    { new Guid("27844896-cc6a-47da-a048-6f34454e8961"), null, null, "Gennaro41@hotmail.com", new Guid("b40e13af-a00a-45af-a681-b960cb8d6a7b") },
                    { new Guid("28ccdf78-191a-45ab-920a-88aabf94cfff"), null, null, "Elmira_Emard@yahoo.com", new Guid("b9a99c94-3031-4da9-bdf3-33bb288dd6a9") },
                    { new Guid("292009e2-ed04-4295-bc63-0b354507ca02"), null, null, "Casandra24@gmail.com", new Guid("d02ec5f5-af87-4bcb-954a-b24e23737d68") },
                    { new Guid("292de8a3-bb7e-4946-984f-e24148bf6ac8"), null, null, "Lily35@hotmail.com", new Guid("65dedea0-0687-4571-93d0-c6cdfefedb38") },
                    { new Guid("29949cfb-df29-41b3-9a1f-9698ef2528d7"), null, null, "Jazmyn.Langosh64@hotmail.com", new Guid("d173c22f-aa53-4e3b-b137-bcd6d2faf814") },
                    { new Guid("29cea1d6-21ca-4a47-9fc9-9761358a4bf7"), null, null, "Emile72@yahoo.com", new Guid("089446be-2352-4d8f-9726-ba2c324e1aee") },
                    { new Guid("2a4ef5d8-b2fc-4c46-a9f3-ff84efe6e86d"), null, null, "Rickie98@hotmail.com", new Guid("28ab8e57-b296-4656-9877-df7be64ecc51") },
                    { new Guid("2a7726b2-3e7b-44a9-b4d0-da0a2388f0d3"), null, null, "Nolan_Zboncak8@yahoo.com", new Guid("0c210681-d608-4ef0-acaa-f6ca1d403524") },
                    { new Guid("2b8e42a8-4ba8-4ca9-b35c-a32d1063b6b4"), null, null, "Glenda89@hotmail.com", new Guid("6127ea05-85cc-4ed4-9b13-5998aee91180") },
                    { new Guid("2b99f49a-2136-4dc4-a475-d843029149a5"), null, null, "Lula25@hotmail.com", new Guid("b72dbc44-743b-4e39-a250-af429c1f09a9") },
                    { new Guid("2be8b6ff-03d3-4b39-93f8-d5dda2a0c694"), null, null, "Loma_Okuneva@hotmail.com", new Guid("23dc6e61-4215-4b56-b081-13cd0b456e6f") },
                    { new Guid("2bec7b8a-c84e-49c1-9849-6960f55baa0f"), null, null, "Vern93@gmail.com", new Guid("045fcec6-e944-4ba4-ab53-e930bdb298c6") },
                    { new Guid("2c14c618-d5eb-41e3-b30a-9ed4c74345f6"), null, null, "Marta57@gmail.com", new Guid("5af211a7-f736-4b52-b2bb-493388054061") },
                    { new Guid("2c159109-e74c-4d67-8c07-55ec8a790317"), null, null, "Adalberto65@hotmail.com", new Guid("09ee89cc-9f4d-4eae-a4f3-731ca2d52102") },
                    { new Guid("2c16ab84-2906-4a79-a44d-1ef19b98dd95"), null, null, "Makenna_Schneider@hotmail.com", new Guid("9f2db745-dcf4-4a49-a27a-ae15a2f3087e") },
                    { new Guid("2c40654c-0af1-443e-974d-4de4456fbf03"), null, null, "Caleb.Terry27@gmail.com", new Guid("ab38dbfc-78a4-4d84-9e77-53448911bc9f") },
                    { new Guid("2c5a5762-04fa-4fd9-be4b-0edd8b4c264d"), null, null, "Kyla.Rau@gmail.com", new Guid("8343d773-e986-49d8-99e9-bd908398b011") },
                    { new Guid("2ccd8864-b5ec-4d9d-8a86-466eed72acaa"), null, null, "Abbie36@yahoo.com", new Guid("a907043f-86ba-4126-baac-6e2c6eb5871c") },
                    { new Guid("2d4cd5d0-1ab4-4f16-83df-c6fe3d05aa61"), null, null, "Florida_Frami@gmail.com", new Guid("89739d78-901e-4353-8c13-fe879541f76f") },
                    { new Guid("2d94b71f-45a1-4608-aa09-82fa6bb6c3cd"), null, null, "Aurelia_Farrell@gmail.com", new Guid("712b2e8f-feec-4b44-842e-63c59bbe48cb") },
                    { new Guid("2db1b53c-6072-41de-8a37-c27b9be63a92"), null, null, "Timmothy.Hagenes15@hotmail.com", new Guid("a0042a3d-7eaa-4c67-b018-40977ff2a846") },
                    { new Guid("2dcbc67f-48fd-4412-a9f8-4abfbaaab650"), null, null, "Amalia2@yahoo.com", new Guid("7975589e-fce3-4ff6-8b4d-4f29aa2e3c37") },
                    { new Guid("2e720bc5-a08c-4263-9034-7291c3143d93"), null, null, "Clair76@hotmail.com", new Guid("f78b821b-0629-4e64-a36a-3d10ad04e07a") },
                    { new Guid("2e82960b-5757-4986-95eb-fe92ab7a7ad5"), null, null, "Stone_Green99@hotmail.com", new Guid("72c94cd8-c5e7-422d-b184-eeec7158816e") },
                    { new Guid("2e8424d0-51df-4c61-acc3-8e1170160e35"), null, null, "Mark.Renner@yahoo.com", new Guid("f7ba49ab-b88c-4490-8dc0-4a731ec11ec3") },
                    { new Guid("2ea36c2f-f602-4261-a296-346706a23a6a"), null, null, "Carmelo71@hotmail.com", new Guid("5dd3e047-c6f3-412d-b5cb-12b416f99706") },
                    { new Guid("2eede396-21ae-4748-b1ec-93a74ee38049"), null, null, "Ewald.Becker@yahoo.com", new Guid("8180db6e-0139-48fa-a7bc-8424ac74378c") },
                    { new Guid("2f33710e-b43f-453e-901d-862a1cecc847"), null, null, "Zelda35@gmail.com", new Guid("c1169f01-6528-4f74-aa56-802f48a7ece8") },
                    { new Guid("2f5c55a3-d4c7-429c-a819-3d3cc6773c4a"), null, null, "Floyd4@yahoo.com", new Guid("af267ef9-b2cf-4adf-a9d0-a58e3acadfa6") },
                    { new Guid("2f924e11-1fca-48dc-bc54-445011efecaf"), null, null, "Imani.Kutch86@hotmail.com", new Guid("011fba87-398c-42ec-9aa7-ffb9c48fe9a9") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("302b552e-7408-41bf-ad31-50eed84e9b2b"), null, null, "Marguerite54@hotmail.com", new Guid("a66e6d00-7000-4eb2-994b-a38594503957") },
                    { new Guid("309e226e-e692-42a6-a2a8-c78adb66a47d"), null, null, "Geraldine_OReilly95@gmail.com", new Guid("7a4f4be1-0c5d-43fb-8b70-3e4913ca97a0") },
                    { new Guid("30d095ba-2a5b-4870-86d9-85da9c807219"), null, null, "Jared_Kozey29@yahoo.com", new Guid("1548ab99-88de-44e5-8fb2-0ecadca929aa") },
                    { new Guid("30de3e06-e685-4648-b492-35da3a6a166e"), null, null, "Rossie_McClure81@hotmail.com", new Guid("a339ea33-3188-40c2-9d84-9ea46aa67e82") },
                    { new Guid("315a8e00-a291-43d6-8598-d61450b78811"), null, null, "Ayden_Fisher83@gmail.com", new Guid("3dc0198e-db0e-4b52-919e-c407fa4dc4a6") },
                    { new Guid("318c7745-1ca9-44e3-a23f-5c0f485e36ae"), null, null, "Antonetta85@hotmail.com", new Guid("bb021ddc-2731-4d61-8069-ddee5e7759da") },
                    { new Guid("319364ab-380c-4cd2-ad0e-21d7e205aca6"), null, null, "Isadore_OKeefe15@gmail.com", new Guid("09ee89cc-9f4d-4eae-a4f3-731ca2d52102") },
                    { new Guid("31c5c306-6751-4287-bb74-bc4ba2bea719"), null, null, "Alexys_Boyle@gmail.com", new Guid("ab522845-c1bd-4f82-bee3-06f49429e4bf") },
                    { new Guid("31e1eec0-0ebc-4b3c-aa18-6054b1f17e05"), null, null, "Joshua_Kunde@gmail.com", new Guid("bdc35340-f998-4d2c-9ebc-c29624582c95") },
                    { new Guid("3264bb33-cb3f-4fc3-bde6-cf10ee3ddf49"), null, null, "Alexander.Senger36@yahoo.com", new Guid("7e04a2e8-5af7-4c5e-8b81-d51fb8eb210b") },
                    { new Guid("32dc4a95-c0a1-49e7-a604-6d4c937e29f9"), null, null, "Colt59@hotmail.com", new Guid("7247fafb-5d1e-43fe-a447-5b99c26b77ba") },
                    { new Guid("32e8ec50-f5c5-4c25-bc3b-245bd0878457"), null, null, "Hassie.Goodwin31@yahoo.com", new Guid("2f3d1b8f-7590-4d18-9002-4caa22511a8b") },
                    { new Guid("33785522-a994-49a2-a0dd-d6582ad399dc"), null, null, "Yasmine_Mayert@hotmail.com", new Guid("9981eef1-0435-4903-9860-b16fb734ad1b") },
                    { new Guid("33b1b013-97f9-4fb2-a1e4-8c683d159f93"), null, null, "Alisa_Emmerich50@hotmail.com", new Guid("89f14bfd-f2ad-40fc-8c24-b21398e3c7d3") },
                    { new Guid("33cbb188-546a-40cb-a538-0bf9ea901a4b"), null, null, "Arnold26@yahoo.com", new Guid("56460594-4f75-42d8-9106-e7e3ec02c12c") },
                    { new Guid("34b8a614-0f52-4a10-9a80-df22fc4fdabc"), null, null, "Eloise_OConnell46@yahoo.com", new Guid("ce3412db-b24b-4f68-8e32-724c140b7d0a") },
                    { new Guid("34f4b859-90f7-4a3f-bd96-48a3bc455d98"), null, null, "Onie.Gibson@hotmail.com", new Guid("f3a37729-6cc8-4507-9aa5-d44c334bc0a7") },
                    { new Guid("35261330-f53f-47ba-8e47-09bd3338eaa9"), null, null, "Josiah.Wisozk@gmail.com", new Guid("28ab8e57-b296-4656-9877-df7be64ecc51") },
                    { new Guid("35b9a47f-9ff3-4929-80cd-cb3cdd8b4664"), null, null, "Allene41@hotmail.com", new Guid("600649dd-c6d1-4ff3-9144-03f6ff7e6950") },
                    { new Guid("35d005f3-0b88-4003-ad4a-a4167dccce34"), null, null, "Jillian.Pagac@yahoo.com", new Guid("f7effd3e-f620-479e-861c-7fb6220a3843") },
                    { new Guid("35de71bd-39bb-4501-a659-07da1d9d5109"), null, null, "Emily_Fahey73@gmail.com", new Guid("c7f2884a-d2aa-4aeb-80a7-44ed5d29e64a") },
                    { new Guid("361e6b2a-c696-44eb-9550-9ea4c87022a4"), null, null, "Scottie_Bashirian67@gmail.com", new Guid("b89fe956-f020-4fc2-affd-e06c759e4081") },
                    { new Guid("36313bcc-92fb-4fe3-87ca-ff172e331b60"), null, null, "Madelynn.Goodwin74@yahoo.com", new Guid("0d9e85a0-24c2-4c10-b1f2-180d3ceeaaaf") },
                    { new Guid("3664a315-d461-432b-969c-e897f989a05a"), null, null, "Woodrow.Mueller67@yahoo.com", new Guid("20245acd-f749-41bb-8cfd-f436a4e71e96") },
                    { new Guid("36f3665a-6782-43d6-8956-62bbcc522928"), null, null, "Martine_Crist@gmail.com", new Guid("e135b016-8e68-479f-a8e6-0c1dd16d5c2f") },
                    { new Guid("374f3f06-8629-4848-bac7-5feca8e59dd6"), null, null, "Lizzie.Raynor54@gmail.com", new Guid("bb486a22-0b19-4077-b9ae-8415f7b0c807") },
                    { new Guid("37759176-a023-4525-a711-e96721cb00e7"), null, null, "Ryan_Metz@gmail.com", new Guid("d52df32f-0260-40eb-8234-13ab7a744fcb") },
                    { new Guid("37dadfce-74f7-4ccd-a9c6-37a5ada13a36"), null, null, "Ethel.Sporer@gmail.com", new Guid("7c403944-d570-486e-9c1f-e40454a443f6") },
                    { new Guid("38a573a5-a907-4c47-a20b-39f22377cb94"), null, null, "Wellington_Gerhold20@hotmail.com", new Guid("b89fe956-f020-4fc2-affd-e06c759e4081") },
                    { new Guid("38b4ffd2-319a-4ea6-9cd0-19d092ccd69f"), null, null, "Daryl.Carroll48@hotmail.com", new Guid("25a38376-e74c-46cc-8d4f-292cebbcdffb") },
                    { new Guid("39ae199a-069b-4704-9c13-2e4239fb55a7"), null, null, "Lyda_Weimann@yahoo.com", new Guid("4a66fea0-71b8-4943-90c9-d349550e6fe9") },
                    { new Guid("3ac1dc6b-6695-4ef1-a5fc-9fda00f4c4a2"), null, null, "Sydni.Casper9@gmail.com", new Guid("9beccf2d-f01f-48c2-a830-6db7b7da19dd") },
                    { new Guid("3acc8dca-c3de-48dd-9348-f92eb482609f"), null, null, "Makenna_Von53@hotmail.com", new Guid("3b1108de-e27d-4674-b7ff-c1df3b68ae41") },
                    { new Guid("3b0f57cb-37f7-4d4e-99ee-7bd9ac6005a4"), null, null, "Augusta37@yahoo.com", new Guid("732ba531-5faf-4b4a-bcac-24d9ca3fcbc2") },
                    { new Guid("3b271828-64d0-4881-b10b-9e47ab63838d"), null, null, "Daryl85@yahoo.com", new Guid("1070c404-0d57-4ba4-828e-4ca0d5ec2262") },
                    { new Guid("3b4e54ba-03ab-4fa0-b42b-7b9e42801426"), null, null, "Gene5@yahoo.com", new Guid("89f14bfd-f2ad-40fc-8c24-b21398e3c7d3") },
                    { new Guid("3b510874-085b-4364-9673-d5de2a56d18c"), null, null, "Nickolas38@yahoo.com", new Guid("ab522845-c1bd-4f82-bee3-06f49429e4bf") },
                    { new Guid("3bcad3cd-af08-44c1-a989-25f14af61a49"), null, null, "Berniece_Pouros@gmail.com", new Guid("af831e9b-a557-4f53-81e7-2278eb8802a1") },
                    { new Guid("3bff58d1-4ab2-4f2a-ba3c-d7d8d17c8b21"), null, null, "Tiffany_Koelpin33@gmail.com", new Guid("624d07fb-c364-4191-b439-aff73116c1d2") },
                    { new Guid("3c50f95b-9b14-4a80-85bb-326f4f182345"), null, null, "Shaina87@hotmail.com", new Guid("500d7059-5719-42c4-a15e-d4753ba03714") },
                    { new Guid("3c896629-0767-4ab5-ba9b-c8117b742768"), null, null, "Henderson18@gmail.com", new Guid("b40e13af-a00a-45af-a681-b960cb8d6a7b") },
                    { new Guid("3d72c4c1-d08f-4b08-967a-ea96981d7b83"), null, null, "Hilda_Ullrich@hotmail.com", new Guid("a8fb7001-ca18-422b-b724-7bb884b357db") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("3de69b75-0956-4a24-a13e-3496c5113188"), null, null, "Leonora5@yahoo.com", new Guid("4f1ac364-cc01-4a40-a229-d66da5446413") },
                    { new Guid("3e68e652-905f-4801-8d88-4e6df02dc513"), null, null, "Jordyn.Goodwin63@gmail.com", new Guid("2078228d-bb74-4e81-8e84-3dd4a76ea271") },
                    { new Guid("3f0a8641-4fff-4977-a892-db708363a3cc"), null, null, "Ebba68@hotmail.com", new Guid("bfb2c3f3-d581-43c3-ad34-2b9af77e293a") },
                    { new Guid("40ab8b54-a583-42a3-93bd-09c69a45a915"), null, null, "Gerard43@yahoo.com", new Guid("4f1ac364-cc01-4a40-a229-d66da5446413") },
                    { new Guid("40b443b2-aaff-4759-940a-218fbea374e5"), null, null, "Frederik2@hotmail.com", new Guid("e6fc9f3f-e447-488c-a497-0bec2a6f9fea") },
                    { new Guid("411abba0-3487-4cff-8766-56a34e84125e"), null, null, "Haven_Bartell37@hotmail.com", new Guid("7b9aa90c-3f91-430e-bbb3-c445e0de9d01") },
                    { new Guid("413c8cf7-0053-4ef0-8d9a-4e98919cbf10"), null, null, "Kiara.Boyer@gmail.com", new Guid("3359f4d4-fbc1-4174-b3e0-8cc3754ac07b") },
                    { new Guid("414a309b-370a-4dc3-b6a1-57335da3bc49"), null, null, "Delilah49@gmail.com", new Guid("af867e87-ddef-4efe-ba16-9ce831f47443") },
                    { new Guid("41670636-fc33-4e76-aa97-036e21f2b567"), null, null, "Veda.Toy63@hotmail.com", new Guid("7d6ad8fc-e102-4ea8-a3e2-5bdfda8f1650") },
                    { new Guid("419e09c8-3fd9-4eb4-9511-21b25bb4e4de"), null, null, "June.Spinka@hotmail.com", new Guid("ea94f56c-ef76-423b-81af-2da80b37dfa6") },
                    { new Guid("42236dec-2977-4b48-b936-24768af4913b"), null, null, "Mae_Heaney@hotmail.com", new Guid("09378928-71be-4297-b8fb-ea5311bf5963") },
                    { new Guid("423e67bd-5855-48b2-b03b-124cd829444b"), null, null, "Bertrand77@hotmail.com", new Guid("2f3d1b8f-7590-4d18-9002-4caa22511a8b") },
                    { new Guid("433cc76d-f212-4469-9d01-e44932d83858"), null, null, "Alexanne_Rolfson69@hotmail.com", new Guid("ea67b8fa-bc9a-4e27-8ba5-f3c2359c883a") },
                    { new Guid("44354a8d-277f-44f7-bdb5-54594b7eb7e0"), null, null, "Earnest.Morissette@yahoo.com", new Guid("a907043f-86ba-4126-baac-6e2c6eb5871c") },
                    { new Guid("446697a0-dc96-4f9b-9ffa-65878a411dc7"), null, null, "Devin91@gmail.com", new Guid("428063f6-fd3a-42bd-b0be-ba01a5e85a84") },
                    { new Guid("4468c764-de3c-40fe-8a4b-4da737fc76aa"), null, null, "Ashtyn81@yahoo.com", new Guid("f7e08701-d57e-42d3-884d-beb04dee4c45") },
                    { new Guid("4482b8f7-c8f0-4f95-b51b-101c97d19afe"), null, null, "Webster.Fritsch84@hotmail.com", new Guid("4527938d-6c0c-424e-8f7a-6d20b4f7a9f0") },
                    { new Guid("44aa5f89-2904-4956-9ec1-1b133760fa44"), null, null, "Frederick63@hotmail.com", new Guid("3359f4d4-fbc1-4174-b3e0-8cc3754ac07b") },
                    { new Guid("44f3602b-7693-4165-ad9b-64ac22bf719a"), null, null, "Arvel.Walsh@hotmail.com", new Guid("7e04a2e8-5af7-4c5e-8b81-d51fb8eb210b") },
                    { new Guid("461de340-a4cb-4e00-8fde-da2a8def2cfe"), null, null, "Ola79@gmail.com", new Guid("a8fb7001-ca18-422b-b724-7bb884b357db") },
                    { new Guid("46269cd6-b2e8-4f30-98b3-dc5e034b1aa5"), null, null, "Laverna12@yahoo.com", new Guid("cca9c534-e77c-400e-a849-210326576f8f") },
                    { new Guid("465a2213-7991-48a3-9213-05a2154b38f2"), null, null, "Daryl80@yahoo.com", new Guid("d572b4d3-7e7c-44d5-b1d1-164c1895424b") },
                    { new Guid("46cdda74-e4a3-4ac8-8571-c2a589920cb1"), null, null, "Lafayette_Watsica@hotmail.com", new Guid("fc6059ea-998b-4053-8aa0-faef98da998c") },
                    { new Guid("4702dca7-00aa-4b57-a42d-624ae647e21a"), null, null, "Jarod.Zulauf5@hotmail.com", new Guid("e2fd10a1-4989-4088-ae2b-0b5909314728") },
                    { new Guid("485651f3-7dd7-4a76-8e27-f9073637f2b3"), null, null, "Mittie_Jast@hotmail.com", new Guid("922f53da-9877-4d56-a64d-6d83331bdbb6") },
                    { new Guid("486aa9a3-c286-48dd-b6cd-3ec156caf468"), null, null, "Tyrese_Collier7@yahoo.com", new Guid("d02ec5f5-af87-4bcb-954a-b24e23737d68") },
                    { new Guid("486d274f-dfa7-4a90-af54-44c1a24e3d6f"), null, null, "Christopher.Ruecker@hotmail.com", new Guid("4af3e803-6a3d-43c8-9c77-811cb6207644") },
                    { new Guid("4897023a-9ceb-4faf-a5ab-9a0eee30e12c"), null, null, "Adaline_Vandervort87@yahoo.com", new Guid("ab38dbfc-78a4-4d84-9e77-53448911bc9f") },
                    { new Guid("489874ab-ebd3-4a65-ad99-6459b79ba012"), null, null, "Jovany_Witting15@yahoo.com", new Guid("57c213e6-163e-4134-8633-29615daff79d") },
                    { new Guid("48dd2976-dedc-465e-9a7b-967ae1e7a1a1"), null, null, "Fiona.Cremin@gmail.com", new Guid("a6098ed7-dc3b-4d11-bcda-a3ba0c8ac2f4") },
                    { new Guid("495779bc-f607-4ac4-9340-40f0545d4e83"), null, null, "Ludie43@gmail.com", new Guid("089446be-2352-4d8f-9726-ba2c324e1aee") },
                    { new Guid("498dbaf6-6753-47af-885e-24749a797222"), null, null, "Rosalia_Mitchell@gmail.com", new Guid("af867e87-ddef-4efe-ba16-9ce831f47443") },
                    { new Guid("49a7ec9b-80f1-4fac-8744-e84bddc06f71"), null, null, "Rachelle.McDermott27@yahoo.com", new Guid("f7ba49ab-b88c-4490-8dc0-4a731ec11ec3") },
                    { new Guid("49e0401f-484e-4cb2-9d9d-e767dcd48479"), null, null, "Jake65@yahoo.com", new Guid("a1e9eb46-748f-4b86-8554-7ae48675b2da") },
                    { new Guid("4a07b626-562a-427e-a897-91f4438ed194"), null, null, "Abdullah11@yahoo.com", new Guid("cc019092-2135-4dea-b991-c8b67614f148") },
                    { new Guid("4a216c0c-ea86-4c24-8648-3a55ec1d1abf"), null, null, "Gilda.Reichert13@yahoo.com", new Guid("1e75d073-445f-4291-b366-fe0683c205a7") },
                    { new Guid("4a3a13a4-2742-4c73-aada-012c7acfe4cd"), null, null, "Samson_Cummerata@hotmail.com", new Guid("99d66586-6373-4afb-b333-7c5cb91075c4") },
                    { new Guid("4a74f4b1-55b3-40ff-8634-89e5586eed7c"), null, null, "Kennith_Weimann87@gmail.com", new Guid("732ba531-5faf-4b4a-bcac-24d9ca3fcbc2") },
                    { new Guid("4a9559ea-37ae-4643-bcbe-8e2f925f6c4d"), null, null, "Urban95@yahoo.com", new Guid("b40e13af-a00a-45af-a681-b960cb8d6a7b") },
                    { new Guid("4aa53410-b86f-4c21-bc22-7bd45df9ff74"), null, null, "Mose88@hotmail.com", new Guid("428063f6-fd3a-42bd-b0be-ba01a5e85a84") },
                    { new Guid("4ab53d46-1eb4-4dce-9cf5-165791519c85"), null, null, "Raphaelle96@gmail.com", new Guid("a66e6d00-7000-4eb2-994b-a38594503957") },
                    { new Guid("4aba86bc-7063-40fc-82ef-7644735abb32"), null, null, "Vince89@hotmail.com", new Guid("4af3e803-6a3d-43c8-9c77-811cb6207644") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("4ad3c901-c75f-475f-a4ac-419b2615c47c"), null, null, "Beulah_Krajcik@hotmail.com", new Guid("7271d193-6a4b-40d9-ab91-a7d8a07e45bb") },
                    { new Guid("4caf3128-ec25-45d8-b007-2f62a489e206"), null, null, "Clair.Predovic@hotmail.com", new Guid("7324afd3-dc67-4f31-ab23-e7b052d0c6e2") },
                    { new Guid("4cb956d7-0e35-4c57-9216-10b313f4f73f"), null, null, "Stanton_Gibson90@gmail.com", new Guid("f4909d03-d7ac-4aaf-a6fe-77a88f9fe06b") },
                    { new Guid("4e6ece9c-caf3-40aa-8c67-5419b3944550"), null, null, "Garett_Crooks96@yahoo.com", new Guid("40c86360-842c-49f4-a03e-2506f27e244d") },
                    { new Guid("4e7011d5-b8b0-4e2e-9646-bf48987f2fe3"), null, null, "Annamarie.Conn26@hotmail.com", new Guid("73953973-c12c-407d-b23d-97f5b010569d") },
                    { new Guid("4e92bb63-83bd-4217-8784-2a63168cac33"), null, null, "Nikita_Becker98@gmail.com", new Guid("89f14bfd-f2ad-40fc-8c24-b21398e3c7d3") },
                    { new Guid("4ee8b7ad-8e9c-44b2-b1e5-1d761a8227b3"), null, null, "Fay_Dooley45@gmail.com", new Guid("ebc46bc5-40b3-40f7-b23b-cc974fa9b051") },
                    { new Guid("4f108c81-a30e-4a16-b1ff-4f1bfd5c2c45"), null, null, "Pierre_OKon@hotmail.com", new Guid("59e5a95d-f3ce-47fe-a7c9-70a6b47faac1") },
                    { new Guid("4f887ae6-de8e-4394-883f-e64fe86e6885"), null, null, "Johnpaul_Leuschke@yahoo.com", new Guid("7e04a2e8-5af7-4c5e-8b81-d51fb8eb210b") },
                    { new Guid("511ebb7e-ecd7-4d79-8228-bd6f162ebe9f"), null, null, "Jasmin15@yahoo.com", new Guid("22a1446b-6ffd-488e-8e70-011276aa0ae3") },
                    { new Guid("519e1501-0146-45c6-b963-91c91670f509"), null, null, "Gladys.Gutkowski@gmail.com", new Guid("a4fd1dcd-4db0-4a8a-9303-ecaf58ed8a81") },
                    { new Guid("51b16119-dc1a-4543-9163-843551f13cdb"), null, null, "Elinor_Fahey@yahoo.com", new Guid("fce6a3fa-2769-41fb-ad0b-94fcfc2caab0") },
                    { new Guid("51b3156b-bc9e-4b2e-86c1-6b10f1d1ac4f"), null, null, "Kristofer_Feest91@yahoo.com", new Guid("7adbc5f0-6d2f-4d16-ad51-1b76edd52481") },
                    { new Guid("526144bd-6907-47fe-8667-4a6c99a7b9c2"), null, null, "Annamarie_Schultz@yahoo.com", new Guid("f498a63d-900c-464a-8fab-e4232968dc8b") },
                    { new Guid("52f922a2-e6b8-474d-a504-7f7a5edb55d6"), null, null, "Cordia_Kertzmann63@gmail.com", new Guid("7d6ad8fc-e102-4ea8-a3e2-5bdfda8f1650") },
                    { new Guid("5347688c-e9f3-4e0e-b51c-eea0c8566ff5"), null, null, "Madelynn.Schimmel@gmail.com", new Guid("eac06870-6688-4254-bca8-fa7f08d81e32") },
                    { new Guid("535267e7-8606-4f5c-b65b-59806a37baa3"), null, null, "Jamison.Heller@yahoo.com", new Guid("59e5a95d-f3ce-47fe-a7c9-70a6b47faac1") },
                    { new Guid("5360c75d-51e0-4a1e-ab18-c51f339bd5b8"), null, null, "Andres36@gmail.com", new Guid("9252c306-249a-4267-8ef5-891d8c0cbea1") },
                    { new Guid("5384dcca-b493-425f-89bc-154b7d747f4f"), null, null, "Addison64@yahoo.com", new Guid("08fd0c31-2e97-4cfb-bbf0-9eca4d7bbf0c") },
                    { new Guid("53a762f9-d6e5-4152-8813-1a3d67441593"), null, null, "Lauriane48@yahoo.com", new Guid("89f14bfd-f2ad-40fc-8c24-b21398e3c7d3") },
                    { new Guid("53e0efb0-2cba-433a-b56d-37ba6d39b09e"), null, null, "Benton77@yahoo.com", new Guid("1548ab99-88de-44e5-8fb2-0ecadca929aa") },
                    { new Guid("53f395c0-9ddc-4182-9233-40dc05beabf3"), null, null, "Cheyanne_Boyle@yahoo.com", new Guid("60c86293-9017-4722-ad96-c09fd6051a5b") },
                    { new Guid("5462cc2d-fffe-45e2-9e52-dd3fab21e383"), null, null, "Cristopher43@yahoo.com", new Guid("0763ce92-5a2c-4138-ad42-41c5b45988dd") },
                    { new Guid("546c355c-5968-4953-b8bc-648ae0a5ce59"), null, null, "Felicia18@gmail.com", new Guid("8180db6e-0139-48fa-a7bc-8424ac74378c") },
                    { new Guid("54b07d42-ecd1-4fd4-a02d-d20011e6961e"), null, null, "Gaetano67@gmail.com", new Guid("a5e0abc8-bc40-47e6-bf22-077c758ba0a7") },
                    { new Guid("55223826-e202-40c1-9455-5898cfb8a65d"), null, null, "Narciso_Mitchell@gmail.com", new Guid("712b2e8f-feec-4b44-842e-63c59bbe48cb") },
                    { new Guid("56479e4e-7d59-46b1-8a6d-38a5846adedd"), null, null, "Eleazar.Gorczany75@gmail.com", new Guid("09378928-71be-4297-b8fb-ea5311bf5963") },
                    { new Guid("56502f56-8efb-46a6-9a1a-836a2be4749d"), null, null, "Alfredo_Mayer80@gmail.com", new Guid("4f7cd1ca-72e9-46bd-ab1e-ae8fa37d21a4") },
                    { new Guid("5661eb38-94d6-425e-bf3e-3e56a120809e"), null, null, "Leanna_Aufderhar@hotmail.com", new Guid("00e8ecc6-7b14-4020-bcbd-1a849d69a8c6") },
                    { new Guid("56786b45-9462-492d-9b28-594df5f55317"), null, null, "Deshawn_Grant50@yahoo.com", new Guid("2effe328-1bb8-4f90-8e5e-a133fd94d1df") },
                    { new Guid("56a1fa20-ce3a-4a3e-9723-3b12c1198639"), null, null, "Deron73@gmail.com", new Guid("1e75d073-445f-4291-b366-fe0683c205a7") },
                    { new Guid("56dc56f7-0ae6-4894-8d3d-4e75114abea8"), null, null, "Stanton_Leuschke@hotmail.com", new Guid("e135b016-8e68-479f-a8e6-0c1dd16d5c2f") },
                    { new Guid("57048ead-6247-44d4-b1c8-3737ae5f4ba9"), null, null, "Elmira_Bode8@gmail.com", new Guid("ab38dbfc-78a4-4d84-9e77-53448911bc9f") },
                    { new Guid("5716023e-0629-4645-a23d-c5b3e9d3b0f1"), null, null, "Reuben53@yahoo.com", new Guid("23dc6e61-4215-4b56-b081-13cd0b456e6f") },
                    { new Guid("571cff58-c32c-4ca9-b76b-960b0c86f650"), null, null, "Lori_Greenfelder43@gmail.com", new Guid("36afa758-a0b9-4345-9bce-db873a3c22fd") },
                    { new Guid("57690bc4-de1d-4056-80a3-f921637dc5f4"), null, null, "Marielle28@hotmail.com", new Guid("5dd3e047-c6f3-412d-b5cb-12b416f99706") },
                    { new Guid("5890eb06-59ef-4e2d-a66a-0be5546c1060"), null, null, "Laurel.Kuvalis@hotmail.com", new Guid("ddf155f2-6984-4582-b06c-39700b8ecb92") },
                    { new Guid("5992f92c-b9c8-4d3a-858f-a9e02025bdb3"), null, null, "Kaleigh_Cummerata20@hotmail.com", new Guid("b2abd3eb-7d4b-49b1-8a46-4ea8b8313ab8") },
                    { new Guid("59dbd6eb-0bd8-4342-a3bf-a1dba9169c3e"), null, null, "Maryam49@hotmail.com", new Guid("7646ca6a-9ad5-4b77-91b7-839412348bed") },
                    { new Guid("5a1f12d5-bb9d-40c3-a928-458a526b9efa"), null, null, "Raul_Buckridge@gmail.com", new Guid("c6c5dcc4-cc8e-4484-935f-918264ee4897") },
                    { new Guid("5a2bc13d-590a-4245-92ac-d4c7fa5a005e"), null, null, "Kory11@yahoo.com", new Guid("4595bfbb-3a7d-407e-b6e6-b5d06b0ded5d") },
                    { new Guid("5aaac2bc-d67a-49ed-b9cf-3d2f050f1ab8"), null, null, "Demond_Schneider@gmail.com", new Guid("efacb463-5422-4958-902a-44c5cd16f26b") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("5abc7e40-8c58-4a77-8f8b-f0d9b5570dbe"), null, null, "Maxie21@gmail.com", new Guid("ae39cf22-04cf-4eb4-8b28-b59be4789ea6") },
                    { new Guid("5b24c0be-5787-49b9-ab84-260cfd41e7a6"), null, null, "Darius.Stracke13@yahoo.com", new Guid("f3ea0004-e1e2-4557-a9d5-14a5369a2eb3") },
                    { new Guid("5c32e2bd-33f6-4726-b04b-5bbcb226cc54"), null, null, "Stanford29@yahoo.com", new Guid("a66e6d00-7000-4eb2-994b-a38594503957") },
                    { new Guid("5c462b3b-2965-431e-8ddd-79e731478f7b"), null, null, "Thaddeus30@hotmail.com", new Guid("f8c234a1-e25c-478d-be01-cda21178c47a") },
                    { new Guid("5c488e21-5df7-41db-beeb-fcf15a23ec5c"), null, null, "Osvaldo.Schuster@yahoo.com", new Guid("7adbc5f0-6d2f-4d16-ad51-1b76edd52481") },
                    { new Guid("5ce60f6e-7450-4c34-ab85-3aeb5432dd84"), null, null, "Demetris_Simonis42@yahoo.com", new Guid("5398a079-6d82-4f82-8917-3f9eea9310eb") },
                    { new Guid("5cfc8dbe-3eaf-4d2d-b624-9893384d8c06"), null, null, "Irwin.Little95@gmail.com", new Guid("40de2c6f-e29d-4027-93c3-945e76ec015c") },
                    { new Guid("5d543021-4a23-48a8-ac95-56dd3501e019"), null, null, "Boyd56@gmail.com", new Guid("2a79982f-f343-4569-a725-228ecab03718") },
                    { new Guid("5d976d1b-006e-4a76-adeb-353f1bf85d27"), null, null, "Deshawn.Ruecker@gmail.com", new Guid("f3a37729-6cc8-4507-9aa5-d44c334bc0a7") },
                    { new Guid("5e616677-4390-4e29-91f6-18ea0901bd3d"), null, null, "Cayla.Botsford28@hotmail.com", new Guid("af267ef9-b2cf-4adf-a9d0-a58e3acadfa6") },
                    { new Guid("5e7a8bd1-5bb2-4de3-b71a-a66dee020b0d"), null, null, "Quinten31@gmail.com", new Guid("58e47d27-16f3-4806-acf1-7b73ccbc0d5e") },
                    { new Guid("5ec93b0b-dea7-4239-a029-b7cfd17a0a35"), null, null, "Mckenna_Goldner83@hotmail.com", new Guid("c4ec53d7-69be-4d5d-9091-29c7f80bd641") },
                    { new Guid("5f62f694-92c7-4896-aae2-4f540b1a0c02"), null, null, "Reese.Conroy20@hotmail.com", new Guid("2b62c42e-4571-4d98-bd8d-7ba20ea3e48b") },
                    { new Guid("5f6afb0c-cf43-45a3-9137-ac29171770c3"), null, null, "Meggie7@hotmail.com", new Guid("5210b0bd-a591-4887-9abb-0f4415c0f467") },
                    { new Guid("5fb6056d-239b-4cd0-a9bb-65e6fed4cee3"), null, null, "Jayda.Wolf50@hotmail.com", new Guid("15a8aac9-d692-4882-990e-3e575587579f") },
                    { new Guid("6117e8d5-abad-4b56-9942-946169db595b"), null, null, "Coby_Sipes50@gmail.com", new Guid("65dedea0-0687-4571-93d0-c6cdfefedb38") },
                    { new Guid("6149355d-027a-46bd-a792-31d111fa304d"), null, null, "Jose.Davis@hotmail.com", new Guid("4f7cd1ca-72e9-46bd-ab1e-ae8fa37d21a4") },
                    { new Guid("6165be44-2c9c-4c0e-8a10-ab2b4ab098e8"), null, null, "Demetris.Bahringer9@yahoo.com", new Guid("cc019092-2135-4dea-b991-c8b67614f148") },
                    { new Guid("61847677-0123-414e-acbe-107848e8b7e2"), null, null, "Stephon.Gleason@hotmail.com", new Guid("7f1920c1-828a-4d44-abe8-9db2c3bea2a0") },
                    { new Guid("61c80950-4332-484c-849b-82aff62b6554"), null, null, "Dee44@gmail.com", new Guid("af267ef9-b2cf-4adf-a9d0-a58e3acadfa6") },
                    { new Guid("61e2c2d3-509a-4c1d-8eb6-7121f4ffbd4a"), null, null, "Shawn_Macejkovic@hotmail.com", new Guid("f4909d03-d7ac-4aaf-a6fe-77a88f9fe06b") },
                    { new Guid("61ff02fa-6f35-4ed8-baff-694cad94ffc5"), null, null, "Hanna.Goldner85@gmail.com", new Guid("ac4b1e96-68b1-4502-856c-10b88acf07fa") },
                    { new Guid("632b9911-78e1-402a-81a2-b1e7347528c7"), null, null, "Hulda85@hotmail.com", new Guid("c0159440-683d-4c76-a904-aa1f4564822f") },
                    { new Guid("63497e04-f859-4000-b629-3af2cf5b47e5"), null, null, "Keshawn.Zemlak@gmail.com", new Guid("92fa424c-9623-4989-b9fe-494533664c26") },
                    { new Guid("636ed665-d47e-4616-bcdf-de27b864cc6e"), null, null, "Kristofer84@hotmail.com", new Guid("bdc35340-f998-4d2c-9ebc-c29624582c95") },
                    { new Guid("639b283f-1180-4848-9c77-67cb0aecacfd"), null, null, "Jacquelyn32@hotmail.com", new Guid("27f9e909-39f0-43df-afb3-3bc130e8da06") },
                    { new Guid("63c1a5aa-f1f4-4a8e-b63b-9869e88333f3"), null, null, "Wilhelm_Borer@yahoo.com", new Guid("53d8997e-27d6-4129-b5f1-0072e7f179bf") },
                    { new Guid("644d1f7c-c8fd-4477-bd7b-77ebbaff99d7"), null, null, "Janick_McGlynn@gmail.com", new Guid("4f7cd1ca-72e9-46bd-ab1e-ae8fa37d21a4") },
                    { new Guid("64768eef-2f3d-427b-8e75-c7cde6683b8f"), null, null, "Nikko40@gmail.com", new Guid("57c213e6-163e-4134-8633-29615daff79d") },
                    { new Guid("64bb2a84-7960-4d2b-9ffa-e62a79d4c404"), null, null, "Jaleel.Hirthe@gmail.com", new Guid("045fcec6-e944-4ba4-ab53-e930bdb298c6") },
                    { new Guid("65465758-cb69-4b33-a9da-0544df2097f0"), null, null, "Larissa.Rohan@yahoo.com", new Guid("a5e0abc8-bc40-47e6-bf22-077c758ba0a7") },
                    { new Guid("6656ab02-3df2-4fdf-9272-4c287870cf8b"), null, null, "Shayne_Schumm@yahoo.com", new Guid("b2085c8a-b530-4404-a522-eaa5962529ec") },
                    { new Guid("668da219-fc1c-4e96-a129-275bdd4d68cc"), null, null, "Kade_Oberbrunner@hotmail.com", new Guid("73953973-c12c-407d-b23d-97f5b010569d") },
                    { new Guid("66ba5e78-983f-419f-b785-9d080d0bf765"), null, null, "Rey.Harris48@yahoo.com", new Guid("9981eef1-0435-4903-9860-b16fb734ad1b") },
                    { new Guid("66ce8a8d-8415-493b-a083-a96b804c85cd"), null, null, "Terrance_Ruecker88@gmail.com", new Guid("37e41091-f10f-4b14-b68d-be058cea2e03") },
                    { new Guid("6795b117-04d8-4a32-b6e0-9fe69a7af3bb"), null, null, "Emiliano_Strosin@gmail.com", new Guid("85626191-e7df-461f-8d6e-58391f67d36a") },
                    { new Guid("67b0b76c-5800-47c1-820a-10d860a2bfcf"), null, null, "Fabiola.Bruen@hotmail.com", new Guid("ea67b8fa-bc9a-4e27-8ba5-f3c2359c883a") },
                    { new Guid("685b1233-af69-4651-ae68-11f0d0c14e77"), null, null, "Fausto_Gleichner@hotmail.com", new Guid("f2fc34d0-f967-4d49-ac54-2191c244d200") },
                    { new Guid("68ac6661-8d56-45ae-9f61-0c282e58fb30"), null, null, "Yoshiko.Steuber@hotmail.com", new Guid("bfb2c3f3-d581-43c3-ad34-2b9af77e293a") },
                    { new Guid("68b86149-758f-4296-b15c-3a8bc6bb16a7"), null, null, "Joelle15@hotmail.com", new Guid("3327a162-c88c-4952-9e00-d3c7118fb9f5") },
                    { new Guid("68d69834-b742-46cc-8343-13e57b7e7f02"), null, null, "Helena_Grant@hotmail.com", new Guid("7a4f4be1-0c5d-43fb-8b70-3e4913ca97a0") },
                    { new Guid("69138f24-8638-4677-be8d-bcd7006bd732"), null, null, "Lane70@gmail.com", new Guid("7324afd3-dc67-4f31-ab23-e7b052d0c6e2") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("69a679c4-d5f3-4b1f-957a-195b46012641"), null, null, "Jaquan11@hotmail.com", new Guid("8d7de522-82d8-4912-bf1a-5d80658097e7") },
                    { new Guid("69cde4ed-1764-4db3-9e6a-e072a5d1fbec"), null, null, "Lenora7@hotmail.com", new Guid("7c403944-d570-486e-9c1f-e40454a443f6") },
                    { new Guid("6a256e9c-8860-4487-86f8-b7e330b736d8"), null, null, "Emil12@hotmail.com", new Guid("4f750333-43c7-4b6d-871b-3959dea7a14e") },
                    { new Guid("6a2f2f98-9eb0-4073-981f-f5159f860ecf"), null, null, "Loyal_Hayes@yahoo.com", new Guid("651f4e42-b7be-4042-92c4-872c1b4a2b36") },
                    { new Guid("6a40ae88-4949-4302-bbf4-d592842737a7"), null, null, "Stephan_Ernser@gmail.com", new Guid("d50ea512-4841-4fdb-b6f1-1805a1f266cc") },
                    { new Guid("6a84267f-e388-4927-b02f-98cc8418f446"), null, null, "Kayleigh_Fadel@yahoo.com", new Guid("19d85480-882e-40f7-a536-84a552b3e447") },
                    { new Guid("6aad8af8-b7a7-4758-9f0a-dd4b78e9cf60"), null, null, "Gaston.DuBuque7@yahoo.com", new Guid("bdc35340-f998-4d2c-9ebc-c29624582c95") },
                    { new Guid("6aaf08b4-0d58-45fa-904d-049f76473c85"), null, null, "Leo44@hotmail.com", new Guid("8988ace1-50ae-4626-95ff-eac9a9aeade6") },
                    { new Guid("6ac90f8f-6f1c-4ac4-8159-b50ee3c303a8"), null, null, "Cordie19@yahoo.com", new Guid("2956754d-e1ca-4623-bbe4-691ff14c9d29") },
                    { new Guid("6b059480-6f80-45c1-b089-35700dcc73af"), null, null, "Leopold.Swift13@yahoo.com", new Guid("624d07fb-c364-4191-b439-aff73116c1d2") },
                    { new Guid("6b060d40-23e2-400f-b477-f77f31dbd84b"), null, null, "Juston_Douglas@hotmail.com", new Guid("4e8f092d-b1e1-47d3-9de6-5d9db26187a5") },
                    { new Guid("6b07e45e-0a48-400b-ad53-30674b19cc96"), null, null, "Abner29@gmail.com", new Guid("611b8b1f-53d5-4660-9ad4-e0b57e915bf8") },
                    { new Guid("6b309459-3b49-48a1-a896-6079caa26187"), null, null, "Keanu.Rice87@yahoo.com", new Guid("0615c4c1-b356-478a-abeb-caaccb8742b0") },
                    { new Guid("6b974d1c-8757-4f2d-833c-c0779a791c9a"), null, null, "Westley_Blanda46@yahoo.com", new Guid("39fc9708-01f3-4ab0-8c26-d5bc00da55db") },
                    { new Guid("6c4c5527-1992-4827-9bf1-2d0855db87be"), null, null, "Forest_Schneider24@gmail.com", new Guid("bb021ddc-2731-4d61-8069-ddee5e7759da") },
                    { new Guid("6ca3a0c1-338e-44a3-9486-cafd0f3b4485"), null, null, "Meagan86@yahoo.com", new Guid("4a3be526-6584-46c8-8a1d-041160609d8b") },
                    { new Guid("6cac573b-c22a-44bd-993d-9178be245378"), null, null, "Darrel75@gmail.com", new Guid("3327a162-c88c-4952-9e00-d3c7118fb9f5") },
                    { new Guid("6cb500e2-7c6e-4b91-bf34-d081038c22b2"), null, null, "Zackery.Collins@hotmail.com", new Guid("9981eef1-0435-4903-9860-b16fb734ad1b") },
                    { new Guid("6d504dfc-db31-44b0-851d-56e816d038c3"), null, null, "Buck11@yahoo.com", new Guid("34abae3b-f28c-4c59-a716-fea9a1b0e1bb") },
                    { new Guid("6dc6d355-ba3b-4164-9bc0-b1cc1ed6d541"), null, null, "Floy21@hotmail.com", new Guid("f088f668-331b-405e-b41a-5cc648df081c") },
                    { new Guid("6e240f8b-516e-4a20-b9f0-780f6ce5caa3"), null, null, "Laurine8@hotmail.com", new Guid("bdd49191-641c-4843-a442-069a71c65be5") },
                    { new Guid("6e5ae19d-5ab5-459e-8036-40275a2f033a"), null, null, "Nickolas_Abernathy99@gmail.com", new Guid("1fa36b53-f427-4c95-96d2-7c8a11050267") },
                    { new Guid("6f2ed59f-3abc-48f0-8561-65672f2a0c1f"), null, null, "Donny.Jerde@hotmail.com", new Guid("d52df32f-0260-40eb-8234-13ab7a744fcb") },
                    { new Guid("6fad2fa2-fa5e-4d61-bcf7-157db6c2e735"), null, null, "Merl.Hermiston@yahoo.com", new Guid("1e75d073-445f-4291-b366-fe0683c205a7") },
                    { new Guid("6feb6022-50d2-4921-888f-3801aa0b8f63"), null, null, "Savanah48@gmail.com", new Guid("53d8997e-27d6-4129-b5f1-0072e7f179bf") },
                    { new Guid("70369161-b133-4598-a3c3-44f6dbe755d9"), null, null, "Gail38@hotmail.com", new Guid("ebecc10d-21da-4369-81d7-600c2de48f88") },
                    { new Guid("70a2005f-a438-4770-9fce-8919c4bfec3d"), null, null, "Tracy.Ward56@hotmail.com", new Guid("cd6370e2-d6d7-4cbd-aaac-c3cf98e8cec3") },
                    { new Guid("70ac1b9f-fd9c-40c2-b254-fb930e7f2766"), null, null, "Kadin.Tillman@gmail.com", new Guid("d9b74426-c418-4b51-a42a-af5906c2fcff") },
                    { new Guid("70d0123f-6ec4-4309-98d9-b4ffca5f0e2a"), null, null, "Allen.Hermann@gmail.com", new Guid("39fc9708-01f3-4ab0-8c26-d5bc00da55db") },
                    { new Guid("70dc20ba-0a31-4531-8730-4890df3bddbd"), null, null, "Alysa.Leffler@gmail.com", new Guid("243b9c2d-ab41-4ea2-b445-092baa8385bc") },
                    { new Guid("7121aed7-5af9-4057-a503-fdd2b3147ebf"), null, null, "Ezequiel_Frami28@yahoo.com", new Guid("a907043f-86ba-4126-baac-6e2c6eb5871c") },
                    { new Guid("71342d6a-dbec-4976-8b5f-221641a86740"), null, null, "Joanny.Brown60@hotmail.com", new Guid("ff5c3ca9-e336-4c0b-bb16-8a689eb03900") },
                    { new Guid("717511a8-b428-4f3c-94ff-edb361b00814"), null, null, "Alejandrin9@hotmail.com", new Guid("a339ea33-3188-40c2-9d84-9ea46aa67e82") },
                    { new Guid("71db1a9d-b542-4c03-a76a-8771aadfa6cc"), null, null, "Camden47@yahoo.com", new Guid("fce6a3fa-2769-41fb-ad0b-94fcfc2caab0") },
                    { new Guid("71fa34f8-aedc-4681-af79-ca4c5ebe4852"), null, null, "Yolanda60@hotmail.com", new Guid("e0518a7c-2290-4dde-8de0-19fe26c3d8fa") },
                    { new Guid("72190aaf-187d-4c8a-9a6f-0b0441f61202"), null, null, "Joey.Konopelski@yahoo.com", new Guid("1be28f90-0b14-4642-99f4-d8dd65c3d9f8") },
                    { new Guid("727ed0c7-9cec-45b4-ae5e-eef989b146b7"), null, null, "Lloyd85@yahoo.com", new Guid("980f1926-46d3-48d9-880c-73d0be9fa1e0") },
                    { new Guid("728c5efb-da95-4fc0-81e7-d40d399c9680"), null, null, "Savanna3@yahoo.com", new Guid("5210b0bd-a591-4887-9abb-0f4415c0f467") },
                    { new Guid("72920f32-ea31-4925-b857-10a34bcb464c"), null, null, "Osbaldo_Doyle@yahoo.com", new Guid("13164560-3eb6-4f4f-9c11-1f819fc48e22") },
                    { new Guid("72d8a051-51c7-45ab-9810-d1c7a28d9d10"), null, null, "Raleigh69@hotmail.com", new Guid("d50ea512-4841-4fdb-b6f1-1805a1f266cc") },
                    { new Guid("740baae9-85f3-465b-bf3f-2ac1e061787a"), null, null, "Cooper.Howe@yahoo.com", new Guid("7a4f4be1-0c5d-43fb-8b70-3e4913ca97a0") },
                    { new Guid("74924bc1-caa5-430a-9ea9-7258c08c193a"), null, null, "Tressa_Kuhlman61@hotmail.com", new Guid("9102f36c-0db2-4a0e-b22a-bcaffabfb757") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("74e1da12-558f-4d7c-b0e8-46d9a068bd23"), null, null, "Milford.Hegmann69@yahoo.com", new Guid("22a1446b-6ffd-488e-8e70-011276aa0ae3") },
                    { new Guid("75016704-4546-427d-8b54-b9fdbe0c74f7"), null, null, "Lou.Gerhold@yahoo.com", new Guid("6d64cb25-3e39-4da8-a0e1-a3ee13dd1071") },
                    { new Guid("76493f35-59c8-4736-b790-3909e0fff4a8"), null, null, "Demarco_Weimann83@yahoo.com", new Guid("9336f657-bf13-4455-becf-1afff818911b") },
                    { new Guid("768b7be2-09e6-4e91-8286-e2e8d88d80e1"), null, null, "Santa.Braun@hotmail.com", new Guid("21aa2202-92c4-4bb8-a2f8-9785eb49fe49") },
                    { new Guid("76e8d368-2171-4d96-957f-095b44fde9a2"), null, null, "Electa_Gleichner14@hotmail.com", new Guid("f7f5e0b6-df15-4f10-b87e-6503c5e8fb8e") },
                    { new Guid("77412a20-7cc9-405e-a8c5-f367d24dd3df"), null, null, "Judge_Mills@hotmail.com", new Guid("f5193487-04f8-4c23-b0cd-90340ebc9154") },
                    { new Guid("779f9b6e-c498-446e-97f0-421146c87f45"), null, null, "Conrad.Kunde58@yahoo.com", new Guid("c6c5dcc4-cc8e-4484-935f-918264ee4897") },
                    { new Guid("77a87c99-6186-4567-959d-bc886ffce788"), null, null, "Jaron_Wyman@yahoo.com", new Guid("11e566bf-b29d-4651-8e8c-7f65a8281c80") },
                    { new Guid("78572bcc-dc45-4b50-938b-8d5f8ca3dce6"), null, null, "Dora.Ullrich6@hotmail.com", new Guid("85626191-e7df-461f-8d6e-58391f67d36a") },
                    { new Guid("78d02abf-343b-46f2-b1b1-8b7d3f417cf2"), null, null, "Van.Jacobson@yahoo.com", new Guid("ce3412db-b24b-4f68-8e32-724c140b7d0a") },
                    { new Guid("7912e44c-4a77-4bae-9ec4-ebf5d99b50cc"), null, null, "Elda75@yahoo.com", new Guid("eac06870-6688-4254-bca8-fa7f08d81e32") },
                    { new Guid("7ae9c75e-90bd-4926-bde2-d2ff71c0fd04"), null, null, "Wiley76@hotmail.com", new Guid("ea94f56c-ef76-423b-81af-2da80b37dfa6") },
                    { new Guid("7af5c929-4d29-4554-a1a2-de80e7f97d37"), null, null, "Van23@gmail.com", new Guid("00e8ecc6-7b14-4020-bcbd-1a849d69a8c6") },
                    { new Guid("7b115c2c-8dc1-4611-80ac-c0b7b08e16f0"), null, null, "Randi_Mann55@gmail.com", new Guid("20245acd-f749-41bb-8cfd-f436a4e71e96") },
                    { new Guid("7b51b920-961a-46c7-8236-61d396565bb5"), null, null, "Bulah43@hotmail.com", new Guid("f57190db-67c4-4d7b-9cd1-c8e27a6ac561") },
                    { new Guid("7bbbe90d-5521-42c5-b8b6-e311dcdcb6c4"), null, null, "Shane_King@hotmail.com", new Guid("92fa424c-9623-4989-b9fe-494533664c26") },
                    { new Guid("7beff250-d938-4b9d-b1cf-0c33b3cb92e4"), null, null, "Amara36@hotmail.com", new Guid("bb021ddc-2731-4d61-8069-ddee5e7759da") },
                    { new Guid("7c072818-fad5-41e5-9a7f-2f5a2acd8fe1"), null, null, "Eldridge95@yahoo.com", new Guid("a72d6b0a-25a6-4c67-ac93-cc46cae2d9dd") },
                    { new Guid("7c493252-53ea-4b64-bc42-3e0577326e3e"), null, null, "Buck66@hotmail.com", new Guid("4dd327b9-6a6d-48c5-bd5c-c99248206229") },
                    { new Guid("7c78f360-2a8d-4ada-bd98-34da77ec6064"), null, null, "Rosa37@hotmail.com", new Guid("17f01111-498c-4286-9021-ec1a09f4b1ca") },
                    { new Guid("7cbb9155-963f-41ca-ab69-834546274943"), null, null, "Frida.McLaughlin@hotmail.com", new Guid("ebc46bc5-40b3-40f7-b23b-cc974fa9b051") },
                    { new Guid("7cc80fb4-b230-479e-8c78-b97a402380f5"), null, null, "Myah_Gleichner34@gmail.com", new Guid("08e9beba-81d1-40e1-9f0f-4d282258b85b") },
                    { new Guid("7d178e4f-37bf-47be-ad2b-b775236dddf8"), null, null, "Krystel18@yahoo.com", new Guid("a4972888-e048-48a4-a351-23bd705a917e") },
                    { new Guid("7d22792e-655a-4463-9734-1489d93dca60"), null, null, "Jeff.Olson80@yahoo.com", new Guid("d02ec5f5-af87-4bcb-954a-b24e23737d68") },
                    { new Guid("7e91a38b-ab8b-47b7-a7a2-7794f497bbce"), null, null, "Grayson_Marvin59@yahoo.com", new Guid("4dd327b9-6a6d-48c5-bd5c-c99248206229") },
                    { new Guid("7ee1b261-0826-41ee-a3f6-59ad040b0194"), null, null, "Christop.Kling52@hotmail.com", new Guid("b89fe956-f020-4fc2-affd-e06c759e4081") },
                    { new Guid("7f0863ef-c917-407c-9c45-de82635856a6"), null, null, "Johathan.Cartwright89@gmail.com", new Guid("af867e87-ddef-4efe-ba16-9ce831f47443") },
                    { new Guid("7f0e288c-e9f9-4b5b-be9f-5f847e2d12f7"), null, null, "Mathilde54@yahoo.com", new Guid("d799d7ce-936a-414f-86fd-958f17b3f642") },
                    { new Guid("7f3c87ef-79fb-4fed-8c95-7a03e25978d5"), null, null, "Rachael94@gmail.com", new Guid("750c9633-57cd-4cce-b195-c19394ee24b3") },
                    { new Guid("7f805801-346a-4190-94f5-275f1d15bcc7"), null, null, "Zoie36@gmail.com", new Guid("5210b0bd-a591-4887-9abb-0f4415c0f467") },
                    { new Guid("7fe9efea-317a-42f9-a7ef-192debc557b0"), null, null, "Dayana.Hyatt3@yahoo.com", new Guid("22a1446b-6ffd-488e-8e70-011276aa0ae3") },
                    { new Guid("7ff827d0-c686-4d2e-8b76-2fe41b9a8454"), null, null, "Macey.Reichel7@hotmail.com", new Guid("628d01f9-5feb-4e85-a1ac-d03470903a20") },
                    { new Guid("80129a95-e300-4d39-b683-ae1b904f38df"), null, null, "Wellington12@gmail.com", new Guid("4527938d-6c0c-424e-8f7a-6d20b4f7a9f0") },
                    { new Guid("80bd7dd9-6466-4764-934b-a3c3e8f58056"), null, null, "Maria_Rosenbaum99@hotmail.com", new Guid("b09cd69c-fd2f-4c43-9227-439aa81d485e") },
                    { new Guid("80ce2b06-c93b-482b-938b-e06772e303b0"), null, null, "Kane.Strosin@hotmail.com", new Guid("1530b862-24b5-484d-8939-50315a49bd13") },
                    { new Guid("813b3994-6072-4565-89e3-756afca8ec03"), null, null, "Nathanael25@gmail.com", new Guid("ddf155f2-6984-4582-b06c-39700b8ecb92") },
                    { new Guid("81d2187a-ceac-49a4-8fb7-8875c5dfdeac"), null, null, "Brad90@gmail.com", new Guid("f7f5e0b6-df15-4f10-b87e-6503c5e8fb8e") },
                    { new Guid("81d4d15f-b1d7-4282-b443-0a7a7f26f15c"), null, null, "Jackson.Kunze15@hotmail.com", new Guid("ddf155f2-6984-4582-b06c-39700b8ecb92") },
                    { new Guid("82731061-9402-4c9a-93f8-81d468719657"), null, null, "Kyra_Klein@yahoo.com", new Guid("c864b34c-ddf5-4af6-9a5f-d8251c512e8f") },
                    { new Guid("82804425-0bd3-409d-b59b-77254777c7b2"), null, null, "Jordy.Jacobs@yahoo.com", new Guid("c1169f01-6528-4f74-aa56-802f48a7ece8") },
                    { new Guid("828ef810-3856-4d11-967b-afb12330134f"), null, null, "Enrico.Wisozk@hotmail.com", new Guid("8887b8ab-eb5d-41ad-bac2-3126e85117d1") },
                    { new Guid("82bebe63-3564-4c8e-a056-968b19f9dad6"), null, null, "Harley_Hartmann57@hotmail.com", new Guid("8343d773-e986-49d8-99e9-bd908398b011") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("82dcd5fa-5a3b-4fd2-9b7d-58b5ae91c4f9"), null, null, "Joyce.Rice3@gmail.com", new Guid("1281e6c3-dc02-4e83-a90d-37f640411dfc") },
                    { new Guid("82f33231-d8c1-47a8-bb75-4574babe5e1a"), null, null, "Glenda.Batz@gmail.com", new Guid("f78b821b-0629-4e64-a36a-3d10ad04e07a") },
                    { new Guid("82f35b74-80f8-48bf-98ea-834b982fc64a"), null, null, "Reva.Goodwin@hotmail.com", new Guid("08fd0c31-2e97-4cfb-bbf0-9eca4d7bbf0c") },
                    { new Guid("83aae008-b54d-49ef-97f2-c85419f4559b"), null, null, "Dashawn59@hotmail.com", new Guid("9336f657-bf13-4455-becf-1afff818911b") },
                    { new Guid("8410e49c-c668-4c75-b59e-fe1a83ba08eb"), null, null, "Devon_Hermiston@gmail.com", new Guid("ae3132fe-b0e9-44a8-a734-658de87cc9a5") },
                    { new Guid("85244c99-2238-4997-bb2f-1396623171ea"), null, null, "Adolphus74@gmail.com", new Guid("a3bc456f-939a-42c3-99ed-719e0db5bf18") },
                    { new Guid("85b6a368-acb6-4715-8250-172dac660ebc"), null, null, "Asia.Conroy46@yahoo.com", new Guid("0edec355-b022-4255-80d6-c530f687d26e") },
                    { new Guid("86aef155-e9d5-45ac-82fd-3195384ae710"), null, null, "Marlin1@hotmail.com", new Guid("1e75d073-445f-4291-b366-fe0683c205a7") },
                    { new Guid("86c02a0c-8600-4722-85f0-500e7eadc11a"), null, null, "Maurice.Marks95@gmail.com", new Guid("56460594-4f75-42d8-9106-e7e3ec02c12c") },
                    { new Guid("86ec9493-b872-4318-817b-30852eeaf66d"), null, null, "Mossie_Jast@gmail.com", new Guid("8c658576-57f3-41cc-9a3b-917efb1480d9") },
                    { new Guid("872f63d4-a4b3-4e13-958b-b16486cecc75"), null, null, "Eva33@yahoo.com", new Guid("77a05cfa-406d-4342-a924-73d56bf2829a") },
                    { new Guid("875ec0b2-9089-4ba2-9417-6e48c39e6943"), null, null, "Krista19@yahoo.com", new Guid("7646ca6a-9ad5-4b77-91b7-839412348bed") },
                    { new Guid("87e263b9-1de3-41bc-8db9-5cbbcbb023f1"), null, null, "Kiarra_Padberg@gmail.com", new Guid("9e9403fb-605a-441d-a83a-f936fec7582f") },
                    { new Guid("881a4571-464e-41b9-9d07-fa2c9dae1827"), null, null, "Houston_Grimes@hotmail.com", new Guid("1be28f90-0b14-4642-99f4-d8dd65c3d9f8") },
                    { new Guid("885b3d30-faae-4d05-9d09-e8d37d36c453"), null, null, "Robbie_Hills30@yahoo.com", new Guid("c1169f01-6528-4f74-aa56-802f48a7ece8") },
                    { new Guid("8881406c-0cb0-4149-8a08-fb367ce45b20"), null, null, "Michelle_Pfeffer93@gmail.com", new Guid("7b9aa90c-3f91-430e-bbb3-c445e0de9d01") },
                    { new Guid("890e9893-dc8e-4c9f-b7b0-8665a7c4f623"), null, null, "Micheal_Cummerata5@yahoo.com", new Guid("5c53533c-cf33-43f0-bdab-260275d90d88") },
                    { new Guid("895e15a4-13a6-4713-a913-f025b821101a"), null, null, "Sarina.Lueilwitz@gmail.com", new Guid("9102f36c-0db2-4a0e-b22a-bcaffabfb757") },
                    { new Guid("8a069988-a26f-4e78-839e-dc6455096c76"), null, null, "Susanna50@hotmail.com", new Guid("2956754d-e1ca-4623-bbe4-691ff14c9d29") },
                    { new Guid("8a455037-1ed3-45ee-bf56-569edb8864cd"), null, null, "Shyann_Huels@yahoo.com", new Guid("0fedadae-5c91-4999-9924-42f5fcd0de5b") },
                    { new Guid("8a5a3d45-ac3b-4926-9789-cc1ff43a2ab9"), null, null, "Roxane_Schroeder@hotmail.com", new Guid("1de915db-ea78-41e7-a3a2-76a8f6311629") },
                    { new Guid("8b7895c7-314d-4ec7-96cf-9787790abf33"), null, null, "Josefina.Kuhic76@gmail.com", new Guid("ce108172-f4b7-4653-a5c3-ff603fbc3a50") },
                    { new Guid("8bdf7cba-9fc1-4975-8fca-b79344fa7b60"), null, null, "Ashleigh47@hotmail.com", new Guid("3af6d087-276b-42a2-9c69-d7501840f5a1") },
                    { new Guid("8be86ee5-22fe-44c4-b672-5f5fc931d81d"), null, null, "Amaya_Marvin5@gmail.com", new Guid("5d61541c-3ac1-459c-b0d4-0bbe121306da") },
                    { new Guid("8c4357b5-bb45-4c40-8d74-40716461ed2c"), null, null, "Raina_Turner21@gmail.com", new Guid("8887b8ab-eb5d-41ad-bac2-3126e85117d1") },
                    { new Guid("8c4e19fb-95e3-4919-afb0-145c9982b2f7"), null, null, "Jena.Prosacco@gmail.com", new Guid("c864b34c-ddf5-4af6-9a5f-d8251c512e8f") },
                    { new Guid("8c7aa28c-3a61-4128-aec7-1865075c2c17"), null, null, "Heath.Weissnat@yahoo.com", new Guid("1530b862-24b5-484d-8939-50315a49bd13") },
                    { new Guid("8ce8c2b3-4a88-4e39-9fdb-60efedea42b0"), null, null, "Tabitha.Jenkins@yahoo.com", new Guid("a339ea33-3188-40c2-9d84-9ea46aa67e82") },
                    { new Guid("8cef2dc8-8b12-4ecc-9b5b-a2ade84caff5"), null, null, "Alden69@gmail.com", new Guid("4a66fea0-71b8-4943-90c9-d349550e6fe9") },
                    { new Guid("8d40cb7b-2ecf-4b6d-994d-d8d85683dff3"), null, null, "Rickey_Batz90@gmail.com", new Guid("1fa36b53-f427-4c95-96d2-7c8a11050267") },
                    { new Guid("8d6d3d17-f319-4185-9f3b-792f02384daa"), null, null, "Piper49@yahoo.com", new Guid("41e507fd-f435-49b8-a35c-9fba98848542") },
                    { new Guid("8d7aa43c-4927-44d2-8fbe-b18436f3967c"), null, null, "Lauryn_Jakubowski34@hotmail.com", new Guid("73953973-c12c-407d-b23d-97f5b010569d") },
                    { new Guid("8dbb842e-56c8-404c-8684-f4f50f59729f"), null, null, "Neva.Leffler@gmail.com", new Guid("d52df32f-0260-40eb-8234-13ab7a744fcb") },
                    { new Guid("8e2266de-6c74-4b86-a4db-4a0c5ca53688"), null, null, "Elton_Muller@yahoo.com", new Guid("99d66586-6373-4afb-b333-7c5cb91075c4") },
                    { new Guid("8e76c139-84e1-4f3e-bee8-a341b1001b59"), null, null, "Arlie.Lebsack85@yahoo.com", new Guid("750c9633-57cd-4cce-b195-c19394ee24b3") },
                    { new Guid("8eb4c684-1444-454a-a92f-4cdf372a01da"), null, null, "Eriberto54@yahoo.com", new Guid("c075bfdf-a5cc-4efb-a6d1-f31b0c4bf344") },
                    { new Guid("8f38a3c0-72c4-49c6-bcc8-97a48dc2e0a4"), null, null, "Candido.Schmidt@gmail.com", new Guid("b2085c8a-b530-4404-a522-eaa5962529ec") },
                    { new Guid("8fbb4915-2b93-4087-87b8-957367555a25"), null, null, "Gerard_Johns22@yahoo.com", new Guid("54f16999-7e05-407e-aab8-1c56cdb79653") },
                    { new Guid("8fe337fa-ab7f-493c-a52e-26383dbb97a6"), null, null, "Antonetta_Upton65@yahoo.com", new Guid("d799d7ce-936a-414f-86fd-958f17b3f642") },
                    { new Guid("90030924-90d9-4a3c-9483-ae0a62705f6c"), null, null, "Grant.Botsford@hotmail.com", new Guid("993e8305-611d-4730-af5d-dbd1e15c6650") },
                    { new Guid("9019ab82-9546-43f6-b524-35f9181cfad8"), null, null, "Marilie86@yahoo.com", new Guid("34c24f57-b16e-4b0f-abe2-5cb9c260e918") },
                    { new Guid("907f12fc-6fac-4cf7-a57a-6ebc515e7f9b"), null, null, "Austyn47@hotmail.com", new Guid("5398a079-6d82-4f82-8917-3f9eea9310eb") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("90a6d865-d070-4c2d-bda2-88c4bbae8009"), null, null, "Kurtis_White47@gmail.com", new Guid("d62fe5e3-4821-411a-b458-87e89f41f2f1") },
                    { new Guid("90e364df-f99d-4e97-b063-5017f15e396a"), null, null, "Dudley93@hotmail.com", new Guid("19d85480-882e-40f7-a536-84a552b3e447") },
                    { new Guid("90ec03b4-823e-4bc1-8fd6-e1d5377c55cd"), null, null, "Percival29@yahoo.com", new Guid("f070ec16-f59a-41c8-8ab6-b492f05b08e3") },
                    { new Guid("90fd09b0-9e23-44fa-8e7a-8ee03fae5b47"), null, null, "Savanah_Labadie2@hotmail.com", new Guid("c4ec53d7-69be-4d5d-9091-29c7f80bd641") },
                    { new Guid("910d0a58-0a4a-4416-9889-dcf63fd53592"), null, null, "Bryana41@yahoo.com", new Guid("f2fc34d0-f967-4d49-ac54-2191c244d200") },
                    { new Guid("91299d8b-9bf5-45d8-a5ab-e4e3dc26146e"), null, null, "Luisa12@hotmail.com", new Guid("1530b862-24b5-484d-8939-50315a49bd13") },
                    { new Guid("91434e19-90ce-40fc-a8e1-6f98efded104"), null, null, "Brennon95@yahoo.com", new Guid("f7ba49ab-b88c-4490-8dc0-4a731ec11ec3") },
                    { new Guid("916aa1ac-34bb-4bd9-a15c-9a88458c6216"), null, null, "Reva_Kautzer89@hotmail.com", new Guid("5146be01-925a-447f-b871-b7de98b487df") },
                    { new Guid("91d4fbc5-89b9-414c-80cf-9ef3ee745d31"), null, null, "Drew.Abbott18@gmail.com", new Guid("f8c6be38-3b48-44ea-9af5-7fd644c82034") },
                    { new Guid("920e2948-ad01-4e35-aed5-1e427bcd5acf"), null, null, "Nathen28@hotmail.com", new Guid("49e9f216-cefc-4a4e-a243-81e78152afb7") },
                    { new Guid("92d4f240-c390-48df-aa47-c3b9d686549b"), null, null, "Rosalia41@hotmail.com", new Guid("2effe328-1bb8-4f90-8e5e-a133fd94d1df") },
                    { new Guid("933151f4-14fb-4dbb-9d51-beccd4f4a5d0"), null, null, "Genoveva_DuBuque97@gmail.com", new Guid("1548ab99-88de-44e5-8fb2-0ecadca929aa") },
                    { new Guid("93507050-1346-4602-95a3-24414c733eea"), null, null, "Brandyn_Stroman5@yahoo.com", new Guid("5210b0bd-a591-4887-9abb-0f4415c0f467") },
                    { new Guid("9353c545-c8eb-4f6b-b5ca-fa91c3d510d9"), null, null, "Alessandro_Shields@gmail.com", new Guid("af831e9b-a557-4f53-81e7-2278eb8802a1") },
                    { new Guid("935c3197-c161-4955-8f33-cd2dd969bec9"), null, null, "Ardith87@yahoo.com", new Guid("25a38376-e74c-46cc-8d4f-292cebbcdffb") },
                    { new Guid("93705849-3d27-43b9-b910-148f627ec95e"), null, null, "Aaron.Emmerich@hotmail.com", new Guid("19d85480-882e-40f7-a536-84a552b3e447") },
                    { new Guid("93a0a483-f8b0-4320-aa6d-09edb6d72081"), null, null, "Jazmyne.West@gmail.com", new Guid("8c149454-da44-4038-9ece-768e572c5282") },
                    { new Guid("9413e1fb-f289-491e-be51-b54fcb5e6058"), null, null, "Godfrey_Collier@gmail.com", new Guid("fc6059ea-998b-4053-8aa0-faef98da998c") },
                    { new Guid("9451e4f1-3e14-4d94-ad09-62b42454dc34"), null, null, "Leila.Rosenbaum23@hotmail.com", new Guid("8c8ff9a2-2752-46a7-960e-0490c28de13f") },
                    { new Guid("9516ff2a-7c0d-4dd2-a3ae-7deea630625b"), null, null, "Aric_Tillman12@hotmail.com", new Guid("60c86293-9017-4722-ad96-c09fd6051a5b") },
                    { new Guid("95da44fd-a07a-4bec-80f2-5deb991821cd"), null, null, "Quinn50@yahoo.com", new Guid("6ceec469-cfb3-42b5-b289-a4c2da0a32dc") },
                    { new Guid("9664abed-0996-4207-a836-50bccfc59a9e"), null, null, "Estefania.Collier74@gmail.com", new Guid("3359f4d4-fbc1-4174-b3e0-8cc3754ac07b") },
                    { new Guid("96f48d20-c5f0-42ee-8de8-b80b9f178954"), null, null, "Crystel.Rath@yahoo.com", new Guid("cffc8c5c-aee1-43fa-a247-e83b10ecb56e") },
                    { new Guid("970dd506-9203-4361-8a1c-e5d6026025af"), null, null, "Nona.Grady1@yahoo.com", new Guid("8dea05e1-92c5-40d9-9159-8e1dcb818034") },
                    { new Guid("9774a43e-1a85-4220-9b2a-4a88670a1e38"), null, null, "Jeramy_Grady@yahoo.com", new Guid("20245acd-f749-41bb-8cfd-f436a4e71e96") },
                    { new Guid("97e0f64d-474d-4424-beae-667573ea7afc"), null, null, "Rudolph.Prosacco4@yahoo.com", new Guid("37f65b1e-268a-4a07-9f55-107b4df3c700") },
                    { new Guid("98311a7d-3228-4cc1-be9a-82db508862b2"), null, null, "Nikko44@yahoo.com", new Guid("ce108172-f4b7-4653-a5c3-ff603fbc3a50") },
                    { new Guid("98590a04-faac-48e5-9129-0b80fc168787"), null, null, "Sigurd.Beahan@gmail.com", new Guid("6de94a05-0c03-4062-8ab9-57a5bd55b3a5") },
                    { new Guid("987dd092-01d6-4559-ae0d-377be7f7d866"), null, null, "Sydnie.Abshire@yahoo.com", new Guid("651f4e42-b7be-4042-92c4-872c1b4a2b36") },
                    { new Guid("98d0ee87-073a-46e8-8203-76936c338a67"), null, null, "Bulah_Carter45@hotmail.com", new Guid("5d61541c-3ac1-459c-b0d4-0bbe121306da") },
                    { new Guid("98ea6759-bedd-42c5-9716-fb5953681cef"), null, null, "Jesse.Anderson@yahoo.com", new Guid("8988ace1-50ae-4626-95ff-eac9a9aeade6") },
                    { new Guid("9924054a-f00b-4d7f-b13c-6d430ce7a8c1"), null, null, "Kody.Robel10@hotmail.com", new Guid("0615c4c1-b356-478a-abeb-caaccb8742b0") },
                    { new Guid("992ce5d6-d21d-4f83-a1a1-ae79a3ff92f9"), null, null, "Alva.Schroeder@yahoo.com", new Guid("cc019092-2135-4dea-b991-c8b67614f148") },
                    { new Guid("99774d64-4969-4bec-9a20-48a9634870c6"), null, null, "Curt63@yahoo.com", new Guid("b7f7d261-2525-4477-8b55-bba019231e9f") },
                    { new Guid("998dc468-94b6-4155-801f-a9626b47ffb1"), null, null, "Christopher_Walter@hotmail.com", new Guid("39fc9708-01f3-4ab0-8c26-d5bc00da55db") },
                    { new Guid("9996f972-1bc1-4e5e-83cd-5b4affd3a8b3"), null, null, "Jeramie51@yahoo.com", new Guid("9beccf2d-f01f-48c2-a830-6db7b7da19dd") },
                    { new Guid("999dcb8e-2843-4d13-9931-fb4f04c077ad"), null, null, "Makenna38@gmail.com", new Guid("628d01f9-5feb-4e85-a1ac-d03470903a20") },
                    { new Guid("99bb425e-61cf-4117-8ba5-aef4bfa723d2"), null, null, "Sigrid.Schimmel@hotmail.com", new Guid("f8c234a1-e25c-478d-be01-cda21178c47a") },
                    { new Guid("99bfd7ab-cad2-489c-9f00-30ab8900f7fb"), null, null, "Zachariah_Kuhlman@gmail.com", new Guid("f070ec16-f59a-41c8-8ab6-b492f05b08e3") },
                    { new Guid("99dba4fc-19cd-4ccc-98af-7cc5bb59c6ae"), null, null, "Skylar_Howell@gmail.com", new Guid("ea67b8fa-bc9a-4e27-8ba5-f3c2359c883a") },
                    { new Guid("9a8a9509-19ae-4d9d-8905-d51a7c9f8679"), null, null, "Lizeth74@gmail.com", new Guid("cc019092-2135-4dea-b991-c8b67614f148") },
                    { new Guid("9a8c7739-9e54-4691-ad3c-09f2ddb9ad16"), null, null, "Kristian.Dicki87@hotmail.com", new Guid("c1169f01-6528-4f74-aa56-802f48a7ece8") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("9b0b0d32-54a6-419e-acb6-1474891c06d8"), null, null, "Jillian80@yahoo.com", new Guid("37f65b1e-268a-4a07-9f55-107b4df3c700") },
                    { new Guid("9ba52318-d9f0-4697-ab5f-d0e588b308d8"), null, null, "May_Johnson@hotmail.com", new Guid("7e04a2e8-5af7-4c5e-8b81-d51fb8eb210b") },
                    { new Guid("9beef2f9-7930-412c-97ce-d8318b113add"), null, null, "Randi22@yahoo.com", new Guid("2c5320bb-6c0a-46cc-9731-a7b34514e4c1") },
                    { new Guid("9c238e42-4507-4924-99e1-fbc4c2ce801a"), null, null, "Ludwig_Wintheiser85@hotmail.com", new Guid("f7ba49ab-b88c-4490-8dc0-4a731ec11ec3") },
                    { new Guid("9c377cc4-731d-498f-855d-baa6776a41fa"), null, null, "Maximilian.Murphy57@yahoo.com", new Guid("712b2e8f-feec-4b44-842e-63c59bbe48cb") },
                    { new Guid("9c47cee7-ebaf-4339-b316-812b9b84a247"), null, null, "Leonie.Kertzmann76@gmail.com", new Guid("db9ac887-f173-4f7b-ad02-6d19fdd7b12e") },
                    { new Guid("9ce70fa6-d9d6-4c35-ab87-90b28c67b177"), null, null, "Benny_Ernser55@gmail.com", new Guid("a72d6b0a-25a6-4c67-ac93-cc46cae2d9dd") },
                    { new Guid("9d27b577-7175-4e00-8a73-2615fb097695"), null, null, "Lavina_Goldner@hotmail.com", new Guid("ae1ca1b0-7eff-4b3f-a0bd-d326d1ebe578") },
                    { new Guid("9d67f669-2ebb-48f7-9768-4008949836b2"), null, null, "Albin.Pacocha45@yahoo.com", new Guid("89739d78-901e-4353-8c13-fe879541f76f") },
                    { new Guid("9db17577-bdda-4808-81a7-6b637bd3fdfa"), null, null, "Marisa_Powlowski0@hotmail.com", new Guid("56780bb1-6c9e-4f24-a024-e244137c0516") },
                    { new Guid("9e41930b-3178-4489-94ca-f4d7322a74c0"), null, null, "Tara63@gmail.com", new Guid("8fca9140-9c2e-4112-9850-cdf3b029b5ac") },
                    { new Guid("9e532973-0ab7-4354-a30e-7dde36af22b9"), null, null, "Rachelle3@gmail.com", new Guid("2956754d-e1ca-4623-bbe4-691ff14c9d29") },
                    { new Guid("9e5ef15c-a63e-4013-8361-6a87412f1610"), null, null, "Helmer.Koch@yahoo.com", new Guid("f3ea0004-e1e2-4557-a9d5-14a5369a2eb3") },
                    { new Guid("9e80679a-0e76-472a-804e-220190d6b2a7"), null, null, "Kelvin_Prohaska53@gmail.com", new Guid("0d9e85a0-24c2-4c10-b1f2-180d3ceeaaaf") },
                    { new Guid("9eb8e1fe-fe5b-432c-971e-4348c5662a10"), null, null, "Eve96@hotmail.com", new Guid("6441d6d0-462e-4346-8bea-ddea048566dd") },
                    { new Guid("9eba0ccd-7c15-4e89-973a-cc2782e1daec"), null, null, "Brando13@gmail.com", new Guid("7adbc5f0-6d2f-4d16-ad51-1b76edd52481") },
                    { new Guid("9ede9445-ed1d-4371-8b1b-dd03886cef57"), null, null, "Rafael_Daniel87@yahoo.com", new Guid("2f3d1b8f-7590-4d18-9002-4caa22511a8b") },
                    { new Guid("9f17a5b2-2e4b-4efa-87be-11f3b140954f"), null, null, "Johnnie36@gmail.com", new Guid("b9a99c94-3031-4da9-bdf3-33bb288dd6a9") },
                    { new Guid("9f772265-ab82-46d5-bcff-4a4ad3dfdc61"), null, null, "Karolann68@hotmail.com", new Guid("1de915db-ea78-41e7-a3a2-76a8f6311629") },
                    { new Guid("9ff9e3e4-9cf4-42a7-b6dc-831a6fa4682e"), null, null, "Stewart.DuBuque97@yahoo.com", new Guid("aa406ff8-810a-45a6-8b41-5028563ae3b6") },
                    { new Guid("a0103988-0b86-4623-afa5-1e415356744c"), null, null, "Tracy29@hotmail.com", new Guid("993e8305-611d-4730-af5d-dbd1e15c6650") },
                    { new Guid("a0113fab-bc7a-440a-9490-bfcd53caa8fd"), null, null, "Nedra_Quitzon@hotmail.com", new Guid("4a1c10a8-7cf3-42b7-9d73-0683e4bc1868") },
                    { new Guid("a0798773-c329-4501-a684-ddec42d59788"), null, null, "Aisha.Stokes53@hotmail.com", new Guid("3359f4d4-fbc1-4174-b3e0-8cc3754ac07b") },
                    { new Guid("a0b0e8e0-b63b-47ee-b561-d1dbfe5e0ec0"), null, null, "Johnnie_Hintz71@yahoo.com", new Guid("bdd49191-641c-4843-a442-069a71c65be5") },
                    { new Guid("a0ffb34e-5cbc-4158-b24c-3c4e7aae637e"), null, null, "Davonte_Schulist@yahoo.com", new Guid("d173c22f-aa53-4e3b-b137-bcd6d2faf814") },
                    { new Guid("a191d493-e32e-4098-ae7e-bfd3279824c6"), null, null, "Michel.Krajcik@hotmail.com", new Guid("ae3132fe-b0e9-44a8-a734-658de87cc9a5") },
                    { new Guid("a1ddebb4-93f4-45fd-a329-778a543df0c1"), null, null, "Eusebio68@gmail.com", new Guid("c6d62b30-8c4e-444d-a56a-cf5bea9f9c2a") },
                    { new Guid("a1f352ea-41eb-442b-8438-1de25b5f7267"), null, null, "Baylee58@hotmail.com", new Guid("fbcf0085-dd67-4f41-b656-a0c0900baca5") },
                    { new Guid("a1fa5d54-3a95-4425-ac1d-76141572f50e"), null, null, "Frederique34@hotmail.com", new Guid("e135b016-8e68-479f-a8e6-0c1dd16d5c2f") },
                    { new Guid("a21be9ec-1eff-449e-905c-b74e03664a2e"), null, null, "Sandy.Wisoky@gmail.com", new Guid("b7003b5f-1610-4487-9fd1-c03a6d0982d7") },
                    { new Guid("a29b22e0-88a6-42e6-b20f-511520521e53"), null, null, "Freda.Collier8@hotmail.com", new Guid("0dce50e5-ef29-456b-ab6f-c4454c5cfc38") },
                    { new Guid("a2a080c1-5928-4d48-9b22-84fc4d53a88f"), null, null, "Corbin38@yahoo.com", new Guid("40c86360-842c-49f4-a03e-2506f27e244d") },
                    { new Guid("a3037b90-19ca-494d-bb95-c90f0564a622"), null, null, "Clint.Cartwright@hotmail.com", new Guid("09ff0b03-eca3-4596-9c5d-d809a2f99a1e") },
                    { new Guid("a3435bd8-6be2-4a63-af10-00de9249fbbe"), null, null, "Damaris64@gmail.com", new Guid("5881d0e1-89ce-4573-8217-2e4c8ee1688e") },
                    { new Guid("a374af3a-c5d4-4ca5-b94d-231f9ce20665"), null, null, "Godfrey25@gmail.com", new Guid("5146be01-925a-447f-b871-b7de98b487df") },
                    { new Guid("a43ad55a-93e6-4bdf-8f25-f62d305761ce"), null, null, "Hermina_Mann91@yahoo.com", new Guid("ac4b1e96-68b1-4502-856c-10b88acf07fa") },
                    { new Guid("a43d0c73-449a-4141-8d54-f1fbe2f04d22"), null, null, "Alysa.Hamill@hotmail.com", new Guid("5d61541c-3ac1-459c-b0d4-0bbe121306da") },
                    { new Guid("a4b47639-a67f-42d4-8357-3c755229fb22"), null, null, "Daphney.Hayes@hotmail.com", new Guid("7247fafb-5d1e-43fe-a447-5b99c26b77ba") },
                    { new Guid("a4cd3cbe-21f7-4ec2-be3a-2e5b6783ed3a"), null, null, "Jessy_Kihn@gmail.com", new Guid("d6f2753c-e864-40f4-a45e-4096737598aa") },
                    { new Guid("a55a4069-23f4-4366-9dcb-905b1f38eb83"), null, null, "Kayli85@hotmail.com", new Guid("e6fc9f3f-e447-488c-a497-0bec2a6f9fea") },
                    { new Guid("a6008084-3fb3-470f-9306-ffdc12069e57"), null, null, "Gail23@hotmail.com", new Guid("b2085c8a-b530-4404-a522-eaa5962529ec") },
                    { new Guid("a66d9700-2004-4c0e-8c21-c4a64b95bba5"), null, null, "Kurt.Conn39@yahoo.com", new Guid("3dc0198e-db0e-4b52-919e-c407fa4dc4a6") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("a6e377c0-3f8b-4049-8646-f4aaddbc07a2"), null, null, "Sylvia_Olson@hotmail.com", new Guid("600649dd-c6d1-4ff3-9144-03f6ff7e6950") },
                    { new Guid("a7606922-b6a3-42e4-86fc-0e53f6201ecb"), null, null, "Krystina43@gmail.com", new Guid("8988ace1-50ae-4626-95ff-eac9a9aeade6") },
                    { new Guid("a7d88a00-8d4c-473c-859c-cece8d468998"), null, null, "Sarina_Daugherty3@hotmail.com", new Guid("0fedadae-5c91-4999-9924-42f5fcd0de5b") },
                    { new Guid("a951aab5-194e-4188-9a2f-ca47200e6405"), null, null, "Opal.Lindgren@yahoo.com", new Guid("64677ac4-f6ca-4452-9192-ce10eab5a7a4") },
                    { new Guid("a9d61c00-5e6e-4e3f-afec-c83670b3b880"), null, null, "Nakia64@gmail.com", new Guid("34c24f57-b16e-4b0f-abe2-5cb9c260e918") },
                    { new Guid("aa051608-1ed5-4469-b216-1b46625b3621"), null, null, "Tabitha.Von@yahoo.com", new Guid("73cff5d2-f041-4e6e-8857-560606637e86") },
                    { new Guid("aa151ffc-493b-4788-9cec-bf9dd21d0cb3"), null, null, "Geovany.Hackett79@hotmail.com", new Guid("74059a15-c214-4079-bc91-f8aa180574a7") },
                    { new Guid("aab72ae9-254c-4c69-ae2b-4eaf0b4374f7"), null, null, "Destiny_Franecki30@gmail.com", new Guid("b2085c8a-b530-4404-a522-eaa5962529ec") },
                    { new Guid("aad317d1-6c5d-40ce-bbd2-301cde240383"), null, null, "Hershel73@yahoo.com", new Guid("4b70366e-a511-4254-8c8d-ad820ee7b210") },
                    { new Guid("ab0cd6e0-a449-4a47-a227-c62c8e0441ef"), null, null, "Marianne.Mraz89@hotmail.com", new Guid("7d6ad8fc-e102-4ea8-a3e2-5bdfda8f1650") },
                    { new Guid("ab1cee01-aa60-4075-a35f-6206c0129c60"), null, null, "Alena_Zulauf@yahoo.com", new Guid("abfe1efb-0a8f-4af4-ab49-6de94e3ef374") },
                    { new Guid("ab39b5f5-49f8-406b-b42e-ca3db34c340f"), null, null, "Orrin_Ritchie64@gmail.com", new Guid("2a79982f-f343-4569-a725-228ecab03718") },
                    { new Guid("aceea6bc-de64-4865-b3be-d082091c57ea"), null, null, "Jena86@yahoo.com", new Guid("56460594-4f75-42d8-9106-e7e3ec02c12c") },
                    { new Guid("ad3e90cb-3992-4c24-b73b-77a8be4ec42b"), null, null, "Dale_Hand51@hotmail.com", new Guid("2d52a2a2-27d8-49a4-9ce6-969bb0f68fa2") },
                    { new Guid("adf65ee0-a1f7-4494-9539-b6f13cb097b7"), null, null, "Samantha7@hotmail.com", new Guid("6de94a05-0c03-4062-8ab9-57a5bd55b3a5") },
                    { new Guid("ae5d4f7a-b047-4325-bebd-f7a4e55d2a80"), null, null, "David70@hotmail.com", new Guid("92fa424c-9623-4989-b9fe-494533664c26") },
                    { new Guid("ae8d59f6-2dcb-4b19-b897-750781aad567"), null, null, "Elinore.Harris@yahoo.com", new Guid("4b70366e-a511-4254-8c8d-ad820ee7b210") },
                    { new Guid("ae958de2-ee93-42bc-be5b-70dab97d4d23"), null, null, "Myrtice_Towne51@hotmail.com", new Guid("77a05cfa-406d-4342-a924-73d56bf2829a") },
                    { new Guid("af066a69-3d9b-4343-b903-68a88982ccde"), null, null, "Braulio_Abernathy@gmail.com", new Guid("13164560-3eb6-4f4f-9c11-1f819fc48e22") },
                    { new Guid("af1c38fd-d983-45be-a5de-e8619a21fc6f"), null, null, "Mathilde_Pfannerstill@yahoo.com", new Guid("f3a37729-6cc8-4507-9aa5-d44c334bc0a7") },
                    { new Guid("af564605-aaf4-4011-b9f7-3f3155549167"), null, null, "Warren.Rempel10@hotmail.com", new Guid("750c9633-57cd-4cce-b195-c19394ee24b3") },
                    { new Guid("af59df29-dd48-40cc-bc18-1f72f9a65d45"), null, null, "Margarett.Little@yahoo.com", new Guid("d02ec5f5-af87-4bcb-954a-b24e23737d68") },
                    { new Guid("afa67441-03cb-4226-b870-dce35ccd043f"), null, null, "Burley20@hotmail.com", new Guid("c6d62b30-8c4e-444d-a56a-cf5bea9f9c2a") },
                    { new Guid("afe8cda2-b87a-4ef2-8f97-a92319075899"), null, null, "Sven.Schulist@gmail.com", new Guid("5322c711-eaf5-4b14-8d69-cc6bf8809924") },
                    { new Guid("b02f848b-49bc-437d-bf26-69c35664bfac"), null, null, "Alva.Ward@gmail.com", new Guid("5146be01-925a-447f-b871-b7de98b487df") },
                    { new Guid("b0dc2296-8bd8-4736-8f14-ffdcd4142923"), null, null, "Liam97@hotmail.com", new Guid("5881d0e1-89ce-4573-8217-2e4c8ee1688e") },
                    { new Guid("b105a26b-05fc-4a53-9df2-7cf7a0976570"), null, null, "Mac.Feest38@hotmail.com", new Guid("8c658576-57f3-41cc-9a3b-917efb1480d9") },
                    { new Guid("b172224e-0bd0-4314-b65c-f1ee8fa5c2aa"), null, null, "Daija16@hotmail.com", new Guid("df2bde0b-bda8-499f-b5cc-cfa7429222d1") },
                    { new Guid("b197ccd8-591d-4466-8ded-75bacd835398"), null, null, "Ines_Fadel@gmail.com", new Guid("0c162bb7-00a6-40b1-b35d-bbd2862f363c") },
                    { new Guid("b1ac9f26-33ea-4bb2-9f10-cbb5a3a8dc4c"), null, null, "Gust_Hodkiewicz0@hotmail.com", new Guid("7319b27d-6146-4420-aa8d-717913c33345") },
                    { new Guid("b1d91562-cce2-485a-b371-35750d212c43"), null, null, "Garrick.Gutmann@hotmail.com", new Guid("2956754d-e1ca-4623-bbe4-691ff14c9d29") },
                    { new Guid("b21e03f9-0df5-4f3f-a419-968fac88280b"), null, null, "Kayleigh_Yundt@hotmail.com", new Guid("f3ea0004-e1e2-4557-a9d5-14a5369a2eb3") },
                    { new Guid("b252d0b2-5074-4817-937d-660c44c9048f"), null, null, "Tevin_Willms@gmail.com", new Guid("c9b88753-217a-4bb2-ac30-4bed75d66c61") },
                    { new Guid("b27776fc-f980-4305-b59e-fa20848356ff"), null, null, "Cristal99@gmail.com", new Guid("f8c6be38-3b48-44ea-9af5-7fd644c82034") },
                    { new Guid("b3346156-4ce8-4530-a515-2b02423841a7"), null, null, "Riley9@gmail.com", new Guid("58e47d27-16f3-4806-acf1-7b73ccbc0d5e") },
                    { new Guid("b346b006-8be2-467e-be72-e34a56a7ff4c"), null, null, "Everardo10@hotmail.com", new Guid("a5e0abc8-bc40-47e6-bf22-077c758ba0a7") },
                    { new Guid("b36b96a1-7564-4cdc-bd29-712cb75236c3"), null, null, "Jamir.Heaney76@hotmail.com", new Guid("f57190db-67c4-4d7b-9cd1-c8e27a6ac561") },
                    { new Guid("b39dc92b-c41e-4c3d-9964-dc8b3d44f7d6"), null, null, "Ernie.Zboncak87@yahoo.com", new Guid("a0042a3d-7eaa-4c67-b018-40977ff2a846") },
                    { new Guid("b4256bc6-6563-43c1-b20e-22c1693111e1"), null, null, "Mireya_Breitenberg3@yahoo.com", new Guid("3b1108de-e27d-4674-b7ff-c1df3b68ae41") },
                    { new Guid("b50e68e9-14fd-4555-a8ea-69ca58f278a9"), null, null, "Hilton.Waelchi@gmail.com", new Guid("f52649ec-b9d7-4f35-8295-ec4e2b5c564c") },
                    { new Guid("b5319933-e2a9-48c3-921f-45080a766847"), null, null, "August.Casper73@hotmail.com", new Guid("70fe5fa7-69ef-4577-a750-34ca205c0dac") },
                    { new Guid("b53583a7-c605-4592-827b-ddf1d53a1ca5"), null, null, "Wilson5@yahoo.com", new Guid("3af6d087-276b-42a2-9c69-d7501840f5a1") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("b53b3f8f-0e88-4ea6-988f-2081a0358fb4"), null, null, "Eula.Osinski40@yahoo.com", new Guid("85626191-e7df-461f-8d6e-58391f67d36a") },
                    { new Guid("b5999f49-1e7a-4e1d-a6e6-f31d4411d3c5"), null, null, "Joey.Predovic@yahoo.com", new Guid("49e9f216-cefc-4a4e-a243-81e78152afb7") },
                    { new Guid("b5d1be86-9e14-4482-aef6-f2054354285f"), null, null, "Marianne.Auer17@hotmail.com", new Guid("f7e08701-d57e-42d3-884d-beb04dee4c45") },
                    { new Guid("b6100ece-4c9a-4169-b182-efbc07ca76a3"), null, null, "Laverne95@gmail.com", new Guid("b40e13af-a00a-45af-a681-b960cb8d6a7b") },
                    { new Guid("b64143b8-42b6-431f-9272-af3caa2b38f2"), null, null, "Valerie.Collier@gmail.com", new Guid("8343d773-e986-49d8-99e9-bd908398b011") },
                    { new Guid("b6883769-28fb-4f7f-9872-5cb434e13efc"), null, null, "Ollie_Beier75@gmail.com", new Guid("7646ca6a-9ad5-4b77-91b7-839412348bed") },
                    { new Guid("b72dc75f-2b76-40a1-9e02-eda0dc47d775"), null, null, "Christophe.Rutherford@hotmail.com", new Guid("8fca9140-9c2e-4112-9850-cdf3b029b5ac") },
                    { new Guid("b733521a-e3ca-4be8-9934-76938557f2d0"), null, null, "Mitchell_Nicolas@yahoo.com", new Guid("af67d494-10d3-4417-9f74-90816ee69f93") },
                    { new Guid("b73e690f-a635-4d31-b8bf-ee12505d44d5"), null, null, "Jena_Durgan45@hotmail.com", new Guid("8fca9140-9c2e-4112-9850-cdf3b029b5ac") },
                    { new Guid("b83a6ae4-669e-4263-bfcb-129144985b53"), null, null, "Turner.Breitenberg@yahoo.com", new Guid("c6c5dcc4-cc8e-4484-935f-918264ee4897") },
                    { new Guid("b8658b0c-83b7-492e-a50a-80051ea9f52a"), null, null, "Dena.Reichert78@hotmail.com", new Guid("efacb463-5422-4958-902a-44c5cd16f26b") },
                    { new Guid("b8705ba2-b795-4437-a367-0b3afd1005f1"), null, null, "Enrique_Smith@gmail.com", new Guid("011fba87-398c-42ec-9aa7-ffb9c48fe9a9") },
                    { new Guid("b9075b56-d0c9-46d7-8ecf-e322bd52e166"), null, null, "Gia79@gmail.com", new Guid("49e9f216-cefc-4a4e-a243-81e78152afb7") },
                    { new Guid("b94b6519-ccd0-40f8-b1de-499892f9e358"), null, null, "Darwin.Witting58@gmail.com", new Guid("f3a37729-6cc8-4507-9aa5-d44c334bc0a7") },
                    { new Guid("b9948be4-81bf-4e01-a5b6-78925d39f618"), null, null, "Nina.Kertzmann@gmail.com", new Guid("5c53533c-cf33-43f0-bdab-260275d90d88") },
                    { new Guid("b9ce727b-4bf4-4f57-923d-5e1ddd48bdff"), null, null, "Dayne_Doyle@hotmail.com", new Guid("4f1ac364-cc01-4a40-a229-d66da5446413") },
                    { new Guid("b9e3ce00-9b9e-4172-a1c4-1b63e06eb9a9"), null, null, "Pearline.Kirlin93@yahoo.com", new Guid("dca6b19f-e9ff-4d07-b3df-fe7e57f8b960") },
                    { new Guid("ba0dd05b-1de7-4550-86cb-56721c96c254"), null, null, "Gustave_Bahringer@hotmail.com", new Guid("11e566bf-b29d-4651-8e8c-7f65a8281c80") },
                    { new Guid("bb006a1c-4e3f-456d-8861-ca2aae1c5b5e"), null, null, "Coty_Stroman@hotmail.com", new Guid("9f2db745-dcf4-4a49-a27a-ae15a2f3087e") },
                    { new Guid("bb53974f-50b5-4e04-b3c5-abbe619c3251"), null, null, "Isaac_Heathcote69@gmail.com", new Guid("6127ea05-85cc-4ed4-9b13-5998aee91180") },
                    { new Guid("bb922703-33b6-4218-9007-0b69ff36d086"), null, null, "Ross_Powlowski@yahoo.com", new Guid("db9ac887-f173-4f7b-ad02-6d19fdd7b12e") },
                    { new Guid("bbdac42e-7736-412b-a5da-5f40a23959e5"), null, null, "Ernest_White@hotmail.com", new Guid("4a1c10a8-7cf3-42b7-9d73-0683e4bc1868") },
                    { new Guid("bc1e23e6-9f75-4fa2-9834-3ed148cc9687"), null, null, "Cortney87@gmail.com", new Guid("aa406ff8-810a-45a6-8b41-5028563ae3b6") },
                    { new Guid("bc39e2e7-95d5-4dc8-a071-01235fca6993"), null, null, "Roosevelt_Streich14@hotmail.com", new Guid("65cb2c49-f00f-450e-94e8-540312a9ce09") },
                    { new Guid("bc6b8461-5b4c-4d66-a2dd-d51332b43203"), null, null, "London_Johnson1@gmail.com", new Guid("0c162bb7-00a6-40b1-b35d-bbd2862f363c") },
                    { new Guid("bc90c922-98f5-4f18-ac66-a9eb92f5ff29"), null, null, "Dolly.Blick@gmail.com", new Guid("aa406ff8-810a-45a6-8b41-5028563ae3b6") },
                    { new Guid("bc982bcf-53b0-4dd7-9d2e-5fa1b36308d8"), null, null, "Helga_MacGyver@gmail.com", new Guid("7f1920c1-828a-4d44-abe8-9db2c3bea2a0") },
                    { new Guid("bcde813c-bb53-4f5e-9a38-0fb94a785383"), null, null, "Erling_Auer83@gmail.com", new Guid("12f12b30-ab20-433f-91c1-e6f9be859390") },
                    { new Guid("bd4fbe62-3104-40ea-83fe-d6b05304ebe6"), null, null, "Lorenz.Jacobi80@gmail.com", new Guid("6ceec469-cfb3-42b5-b289-a4c2da0a32dc") },
                    { new Guid("be482f71-a907-4183-8780-0387db856583"), null, null, "Pearl80@yahoo.com", new Guid("bb486a22-0b19-4077-b9ae-8415f7b0c807") },
                    { new Guid("be4c3632-2cea-435c-a718-46420c09a58a"), null, null, "Chaz.Buckridge@yahoo.com", new Guid("96830fa4-dc91-4a31-8fad-9b956fd29c58") },
                    { new Guid("be60ddc7-220f-414c-8a3e-168a3727f009"), null, null, "Valerie.Goodwin@hotmail.com", new Guid("db7dd226-4232-45fe-a502-06e0dfd99b42") },
                    { new Guid("be6cc03b-8aa3-4c1b-a0ea-ab595bafc242"), null, null, "Burley_Hilll@yahoo.com", new Guid("20245acd-f749-41bb-8cfd-f436a4e71e96") },
                    { new Guid("bea4f8c1-4591-4a89-8a20-4e8a48f54016"), null, null, "Winifred35@gmail.com", new Guid("af67d494-10d3-4417-9f74-90816ee69f93") },
                    { new Guid("bebca4e4-aa04-4a51-9b3d-21ae8beae1cf"), null, null, "Lemuel_Lang@hotmail.com", new Guid("243b9c2d-ab41-4ea2-b445-092baa8385bc") },
                    { new Guid("bf3e226b-02d3-4208-976f-e676d1c06e96"), null, null, "Velva74@gmail.com", new Guid("1fda2339-4864-46e3-bf7d-81a520206ae9") },
                    { new Guid("bf4b89fb-af4c-48dc-8115-b907e4f49682"), null, null, "Candelario_Okuneva@gmail.com", new Guid("09ff0b03-eca3-4596-9c5d-d809a2f99a1e") },
                    { new Guid("bf9abe7e-84a0-475a-8472-414a554c11ad"), null, null, "Trenton.Beahan@yahoo.com", new Guid("712b2e8f-feec-4b44-842e-63c59bbe48cb") },
                    { new Guid("bfe70d60-971e-4df0-927c-7702e221f9c8"), null, null, "Eddie.Reinger@hotmail.com", new Guid("611b8b1f-53d5-4660-9ad4-e0b57e915bf8") },
                    { new Guid("c0416322-7fcd-43de-891b-81e970216c00"), null, null, "Miles.Jones87@gmail.com", new Guid("b252505e-f926-4638-a778-09894c7e3345") },
                    { new Guid("c045517c-f147-4016-a04a-f8f2164259a4"), null, null, "Alfredo44@hotmail.com", new Guid("72c94cd8-c5e7-422d-b184-eeec7158816e") },
                    { new Guid("c04b155c-34d8-4e8b-a3d3-35c19199d773"), null, null, "Libby50@yahoo.com", new Guid("56460594-4f75-42d8-9106-e7e3ec02c12c") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("c09354c3-15cb-43f7-8c34-dc96499dfc06"), null, null, "Maximillia18@gmail.com", new Guid("13164560-3eb6-4f4f-9c11-1f819fc48e22") },
                    { new Guid("c0956704-b7c2-4e2e-8834-f7dc9e00523d"), null, null, "Kevin84@yahoo.com", new Guid("25a38376-e74c-46cc-8d4f-292cebbcdffb") },
                    { new Guid("c0bef0e9-a615-432e-8e0e-17608da794e5"), null, null, "David_Rowe0@hotmail.com", new Guid("09e536d1-50fd-453a-80d5-e8283f64b0da") },
                    { new Guid("c0c3bdc1-a4b3-4d41-9c09-789d5c090509"), null, null, "Enos_Bechtelar@hotmail.com", new Guid("58e47d27-16f3-4806-acf1-7b73ccbc0d5e") },
                    { new Guid("c0ca08c9-c0dc-4134-99f9-93ec6d2e601d"), null, null, "Graciela79@gmail.com", new Guid("59e5a95d-f3ce-47fe-a7c9-70a6b47faac1") },
                    { new Guid("c1a02303-e88c-45ce-8e07-3cd437f8d6cb"), null, null, "Neil22@yahoo.com", new Guid("7646ca6a-9ad5-4b77-91b7-839412348bed") },
                    { new Guid("c1bac521-815a-46fb-8ee8-a3ba2fafee32"), null, null, "Reid.Osinski@gmail.com", new Guid("8dea05e1-92c5-40d9-9159-8e1dcb818034") },
                    { new Guid("c1d51156-e98e-4416-9a04-e4977ba9e0e7"), null, null, "Jazlyn_Nolan@hotmail.com", new Guid("3b1108de-e27d-4674-b7ff-c1df3b68ae41") },
                    { new Guid("c1f8fa80-a289-4e70-8892-fd3a5ed84ffd"), null, null, "Sven.Shanahan21@hotmail.com", new Guid("d572b4d3-7e7c-44d5-b1d1-164c1895424b") },
                    { new Guid("c204f17f-5097-4b7a-abde-440eea266d80"), null, null, "Dana_Blick@yahoo.com", new Guid("4a3be526-6584-46c8-8a1d-041160609d8b") },
                    { new Guid("c2103edc-943e-4d1f-bc53-5f3c81294787"), null, null, "Isobel0@gmail.com", new Guid("f7effd3e-f620-479e-861c-7fb6220a3843") },
                    { new Guid("c28bd5f5-05d6-4f57-a522-5455c937984d"), null, null, "Jailyn27@yahoo.com", new Guid("15a8aac9-d692-4882-990e-3e575587579f") },
                    { new Guid("c2c01e7e-ad2e-47a0-b25b-b0ea2d2d5d19"), null, null, "Tess6@hotmail.com", new Guid("bdd49191-641c-4843-a442-069a71c65be5") },
                    { new Guid("c2d9ae17-3785-4ac8-8115-767463813aef"), null, null, "Ellen_Bahringer@hotmail.com", new Guid("68bf203c-5d15-452a-b81b-bb7831c4f579") },
                    { new Guid("c3075a86-699f-4998-8f2d-87cc80d95b2d"), null, null, "Bernadette_Langworth41@yahoo.com", new Guid("3327a162-c88c-4952-9e00-d3c7118fb9f5") },
                    { new Guid("c31907ae-1ced-4a3f-9ccf-7f3ed4fa4659"), null, null, "Zack.Kohler63@gmail.com", new Guid("08e9beba-81d1-40e1-9f0f-4d282258b85b") },
                    { new Guid("c331effd-1936-4cc8-8c35-13fe29fdba78"), null, null, "Aurelio.Barrows@hotmail.com", new Guid("b7065d5a-6bbd-485c-bd51-6a4a0fc35e18") },
                    { new Guid("c34ec74f-64f8-4c43-8a91-b7fc7c413854"), null, null, "Keeley_Jacobi@gmail.com", new Guid("52fe76ad-4c09-4b99-9385-e407990c0307") },
                    { new Guid("c391248e-f211-41cb-bc98-4bb1fa1e18c5"), null, null, "Martine_Greenholt50@gmail.com", new Guid("dca6b19f-e9ff-4d07-b3df-fe7e57f8b960") },
                    { new Guid("c391288f-de67-40e6-a56c-8412c138ebb5"), null, null, "Eusebio61@yahoo.com", new Guid("c9b88753-217a-4bb2-ac30-4bed75d66c61") },
                    { new Guid("c45990b6-0af9-4fac-9b3f-d55ca352f666"), null, null, "Elbert_Erdman35@gmail.com", new Guid("0c210681-d608-4ef0-acaa-f6ca1d403524") },
                    { new Guid("c4653b59-277c-4585-9ed8-4fa59fb199b2"), null, null, "Giovanni.Hegmann@yahoo.com", new Guid("8988ace1-50ae-4626-95ff-eac9a9aeade6") },
                    { new Guid("c4ee3cd7-469e-496d-851b-76302ea55579"), null, null, "Austen57@yahoo.com", new Guid("abfe1efb-0a8f-4af4-ab49-6de94e3ef374") },
                    { new Guid("c51eb866-2ec9-4bee-8905-6a3b463ca58d"), null, null, "Carlo48@hotmail.com", new Guid("c4b80142-93ac-41b3-b29d-ff4cad905327") },
                    { new Guid("c5268234-00ca-4974-8f23-535dcea7d04a"), null, null, "Caleb86@yahoo.com", new Guid("3327a162-c88c-4952-9e00-d3c7118fb9f5") },
                    { new Guid("c583e972-d5bb-42f8-bcd0-dc136688d3c5"), null, null, "Anais_McLaughlin69@gmail.com", new Guid("5146be01-925a-447f-b871-b7de98b487df") },
                    { new Guid("c585bcc3-1bf0-4d8b-b4ee-ff274575ec71"), null, null, "Lavon.Brown@gmail.com", new Guid("dca6b19f-e9ff-4d07-b3df-fe7e57f8b960") },
                    { new Guid("c5f0e1a6-9ee5-43a6-b295-c7c8e446ddbe"), null, null, "Bailee.Tremblay@yahoo.com", new Guid("db7dd226-4232-45fe-a502-06e0dfd99b42") },
                    { new Guid("c66a1849-ba5d-45aa-b095-ac076a4d31ca"), null, null, "Louvenia28@gmail.com", new Guid("7319b27d-6146-4420-aa8d-717913c33345") },
                    { new Guid("c69f7a01-e4f6-4a63-aa85-b9322c09d986"), null, null, "Tod_Rolfson@yahoo.com", new Guid("8fca9140-9c2e-4112-9850-cdf3b029b5ac") },
                    { new Guid("c6e56ea6-7c48-4f01-93f8-2490fffac560"), null, null, "Margarett.Rodriguez@yahoo.com", new Guid("4f1ac364-cc01-4a40-a229-d66da5446413") },
                    { new Guid("c72bcf7d-75e5-4738-8b5a-30a3ecb1cae8"), null, null, "Rosamond.Nikolaus49@yahoo.com", new Guid("8d7de522-82d8-4912-bf1a-5d80658097e7") },
                    { new Guid("c7339e30-586a-4893-87f4-b441b85763a6"), null, null, "Sarah.Effertz49@hotmail.com", new Guid("c4ec53d7-69be-4d5d-9091-29c7f80bd641") },
                    { new Guid("c74a7612-20c1-4a8c-977f-d7757840a838"), null, null, "Kayleigh.Thompson@yahoo.com", new Guid("5322c711-eaf5-4b14-8d69-cc6bf8809924") },
                    { new Guid("c916e0f2-409b-470b-8f0f-1a82e8d3f0d4"), null, null, "Leopold.Witting@gmail.com", new Guid("74059a15-c214-4079-bc91-f8aa180574a7") },
                    { new Guid("c92b0c45-e4bf-4505-acf0-ddfa78cec0e7"), null, null, "Amari_Dietrich87@yahoo.com", new Guid("011fba87-398c-42ec-9aa7-ffb9c48fe9a9") },
                    { new Guid("c930ddbe-dd4e-4ab2-a78c-2ad46d0f88bf"), null, null, "Lonnie94@hotmail.com", new Guid("34abae3b-f28c-4c59-a716-fea9a1b0e1bb") },
                    { new Guid("ca2f087a-0e0d-4c16-9372-f580afab9cb3"), null, null, "Jessie_Streich64@hotmail.com", new Guid("7f857795-bd2a-48ee-bcf8-ec48fdb428ab") },
                    { new Guid("ca5cc27e-a2ce-47ca-add7-c0019c4b2a48"), null, null, "Granville61@yahoo.com", new Guid("9981eef1-0435-4903-9860-b16fb734ad1b") },
                    { new Guid("ca6e45cb-61e9-4118-ac63-bfdc286404e3"), null, null, "Marcia11@yahoo.com", new Guid("29c7fc41-2565-497d-8900-56c2e6208fa6") },
                    { new Guid("cb144501-1a92-4088-b06b-dcf9bbc50bef"), null, null, "Bonita_Wyman63@yahoo.com", new Guid("9e9403fb-605a-441d-a83a-f936fec7582f") },
                    { new Guid("cb441d3a-094d-4404-b316-b9da212cf0b9"), null, null, "Marcus_Senger19@gmail.com", new Guid("3af6d087-276b-42a2-9c69-d7501840f5a1") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("cb4a4619-827d-4355-a8a9-35e330e02cb3"), null, null, "Aglae_Green85@gmail.com", new Guid("cd6370e2-d6d7-4cbd-aaac-c3cf98e8cec3") },
                    { new Guid("cb75484b-91b5-4d4d-a314-8319d7f701aa"), null, null, "Gonzalo.Hessel@hotmail.com", new Guid("2293afe4-2408-427c-9960-7223d1291070") },
                    { new Guid("cb82fd92-222a-4de0-a46b-09054d26b0db"), null, null, "Emil_Price66@hotmail.com", new Guid("b2abd3eb-7d4b-49b1-8a46-4ea8b8313ab8") },
                    { new Guid("cb9389c0-6d75-4cff-9bf9-12644b164b9b"), null, null, "Ethel.Johnston@yahoo.com", new Guid("4e8f092d-b1e1-47d3-9de6-5d9db26187a5") },
                    { new Guid("cb9ededc-266a-477c-9049-547062256cf2"), null, null, "Teresa.Hackett52@yahoo.com", new Guid("045fcec6-e944-4ba4-ab53-e930bdb298c6") },
                    { new Guid("cbb6e150-ea05-4b91-b840-9c2e60e51d0f"), null, null, "Lavonne.Moen@hotmail.com", new Guid("0dce50e5-ef29-456b-ab6f-c4454c5cfc38") },
                    { new Guid("cbcea886-50e7-4536-a5ac-74f3763640b5"), null, null, "Julien1@gmail.com", new Guid("dda60091-f993-4d23-997a-ac4774d856d5") },
                    { new Guid("cbf6868e-3dd3-48dc-9004-1372bcba57a3"), null, null, "Dustin60@hotmail.com", new Guid("ac4b1e96-68b1-4502-856c-10b88acf07fa") },
                    { new Guid("cbfb2d25-31e2-40ae-9bed-c76bb4018a51"), null, null, "Benton.Rosenbaum90@hotmail.com", new Guid("09ee89cc-9f4d-4eae-a4f3-731ca2d52102") },
                    { new Guid("cc15bda6-d01e-4c26-a9cf-07be0f90dc3b"), null, null, "Margarette_Langworth1@gmail.com", new Guid("8de401f3-837a-4e09-884e-ddf9af867804") },
                    { new Guid("cc34817f-e54d-4e85-844a-0b7a9445a09c"), null, null, "Ilene69@hotmail.com", new Guid("6ceec469-cfb3-42b5-b289-a4c2da0a32dc") },
                    { new Guid("ccb0cd62-fb68-4600-86a9-50ad04a35bfa"), null, null, "Virgie83@yahoo.com", new Guid("5398a079-6d82-4f82-8917-3f9eea9310eb") },
                    { new Guid("ccb6387a-6cac-4db2-8cef-6be99e7b2173"), null, null, "Carlotta.Orn@gmail.com", new Guid("08e9beba-81d1-40e1-9f0f-4d282258b85b") },
                    { new Guid("cdb30ee5-eafb-471d-8379-fcbeab96ce39"), null, null, "Roderick_Jacobson@gmail.com", new Guid("37e41091-f10f-4b14-b68d-be058cea2e03") },
                    { new Guid("ce0652fe-b2c1-4456-a28c-c53a3f0f8028"), null, null, "Mia.Yost57@yahoo.com", new Guid("351d8ea5-1894-4ffb-9d93-a257287acb66") },
                    { new Guid("cec35398-c8e3-4a37-b0f4-d9430f6d7ef2"), null, null, "Bridie.Zieme22@hotmail.com", new Guid("34c24f57-b16e-4b0f-abe2-5cb9c260e918") },
                    { new Guid("ceec152e-0f05-412e-9571-8bc292c99960"), null, null, "Gloria20@hotmail.com", new Guid("ea94f56c-ef76-423b-81af-2da80b37dfa6") },
                    { new Guid("cf528709-8761-421f-8827-da6189ba5969"), null, null, "Junius.Mayert@yahoo.com", new Guid("29c7fc41-2565-497d-8900-56c2e6208fa6") },
                    { new Guid("cfa22150-587d-48be-8dc3-819a31723893"), null, null, "Elliott.Durgan46@hotmail.com", new Guid("af267ef9-b2cf-4adf-a9d0-a58e3acadfa6") },
                    { new Guid("d0437ecf-7285-41d5-a485-f68ad1a7a203"), null, null, "Verlie_Walker24@yahoo.com", new Guid("5d61541c-3ac1-459c-b0d4-0bbe121306da") },
                    { new Guid("d17088d6-9a92-42c9-bca6-1446afad0a47"), null, null, "Hildegard_Balistreri58@gmail.com", new Guid("a3bc456f-939a-42c3-99ed-719e0db5bf18") },
                    { new Guid("d1bd79c3-9f27-4f4c-adf3-507d9c16bbe8"), null, null, "Patience_Skiles18@hotmail.com", new Guid("23dc6e61-4215-4b56-b081-13cd0b456e6f") },
                    { new Guid("d2404d1d-70e0-4541-92c4-a24faa95958c"), null, null, "Nayeli_Fadel@gmail.com", new Guid("1548ab99-88de-44e5-8fb2-0ecadca929aa") },
                    { new Guid("d243095e-87bb-494a-b810-bc8fcfa8cd5d"), null, null, "Kaitlin_Kiehn44@yahoo.com", new Guid("77f28b3f-3ca9-4819-96c6-bd1e811a39f5") },
                    { new Guid("d24e8d34-3625-4868-9769-4188c89bca52"), null, null, "Osborne53@yahoo.com", new Guid("ae1ca1b0-7eff-4b3f-a0bd-d326d1ebe578") },
                    { new Guid("d2503bfa-3bc1-4c64-abf8-14b154665aa4"), null, null, "Leola_Blick91@yahoo.com", new Guid("0643292c-1282-43c9-ae18-5e2311a73db2") },
                    { new Guid("d2642333-346e-4f8f-aaeb-63cd02eb56ea"), null, null, "Godfrey.Wiegand@yahoo.com", new Guid("59e5a95d-f3ce-47fe-a7c9-70a6b47faac1") },
                    { new Guid("d274d3de-facb-4d77-9b40-f43be57bfbbe"), null, null, "Hudson24@hotmail.com", new Guid("7247fafb-5d1e-43fe-a447-5b99c26b77ba") },
                    { new Guid("d2bef146-293e-4f12-a00f-05eb58e9b279"), null, null, "Lamont_Rempel@hotmail.com", new Guid("bfb2c3f3-d581-43c3-ad34-2b9af77e293a") },
                    { new Guid("d2f084fa-dc72-457f-964e-880fbf665bb9"), null, null, "Kariane_Murazik27@yahoo.com", new Guid("68bf203c-5d15-452a-b81b-bb7831c4f579") },
                    { new Guid("d31fd233-2d4e-4634-8778-cffd46fa20a0"), null, null, "Rico_Kunze7@hotmail.com", new Guid("3b1108de-e27d-4674-b7ff-c1df3b68ae41") },
                    { new Guid("d3295be1-6904-4d76-a7ef-0d20d1af30f7"), null, null, "Jan54@hotmail.com", new Guid("f78b821b-0629-4e64-a36a-3d10ad04e07a") },
                    { new Guid("d3371b18-4fa2-408f-9478-8a7b5986c3ad"), null, null, "Alex_Considine@hotmail.com", new Guid("0dce50e5-ef29-456b-ab6f-c4454c5cfc38") },
                    { new Guid("d39c6bf6-7fca-4377-9065-7c1615f75a1d"), null, null, "Stuart89@gmail.com", new Guid("4595bfbb-3a7d-407e-b6e6-b5d06b0ded5d") },
                    { new Guid("d3aba521-eef1-414b-9c87-999ec3cef687"), null, null, "August.Berge70@yahoo.com", new Guid("0643292c-1282-43c9-ae18-5e2311a73db2") },
                    { new Guid("d3afaadb-e4e7-4b8e-81d7-39e14d03611f"), null, null, "Tommie_Towne@gmail.com", new Guid("b7f7d261-2525-4477-8b55-bba019231e9f") },
                    { new Guid("d419e992-02fd-4f73-a3e6-0b7f3c9b24f4"), null, null, "Casimer32@gmail.com", new Guid("2d52a2a2-27d8-49a4-9ce6-969bb0f68fa2") },
                    { new Guid("d44def07-2da8-4066-9616-01dc2ee7010c"), null, null, "Chaim_Kilback34@gmail.com", new Guid("a6098ed7-dc3b-4d11-bcda-a3ba0c8ac2f4") },
                    { new Guid("d462e59a-4210-4ff8-b6c8-64b071435385"), null, null, "Shanelle37@yahoo.com", new Guid("ff5c3ca9-e336-4c0b-bb16-8a689eb03900") },
                    { new Guid("d4d09217-ad72-4831-9c25-0da0daaf983c"), null, null, "Margarett98@yahoo.com", new Guid("ddf155f2-6984-4582-b06c-39700b8ecb92") },
                    { new Guid("d4deb898-02b4-4c5e-9667-0e9c41ab0762"), null, null, "Jeramie26@gmail.com", new Guid("9336f657-bf13-4455-becf-1afff818911b") },
                    { new Guid("d4e23a4c-0f4d-4967-8590-a21378d3cb8d"), null, null, "Emilie_Nader@hotmail.com", new Guid("7319b27d-6146-4420-aa8d-717913c33345") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("d5e5ede0-143e-4554-b641-b6f4e5a584b3"), null, null, "Gerardo46@gmail.com", new Guid("b09cd69c-fd2f-4c43-9227-439aa81d485e") },
                    { new Guid("d6260a76-b667-42f5-bfd8-e7508c1e1d45"), null, null, "Rudolph71@gmail.com", new Guid("c7f2884a-d2aa-4aeb-80a7-44ed5d29e64a") },
                    { new Guid("d66a1b39-aacc-42a5-a2da-6879d31ce26c"), null, null, "Macey_Gibson0@hotmail.com", new Guid("c6d62b30-8c4e-444d-a56a-cf5bea9f9c2a") },
                    { new Guid("d6cc5eba-ddbd-49b4-a22d-d83da99be5fc"), null, null, "Tyrell8@gmail.com", new Guid("d173c22f-aa53-4e3b-b137-bcd6d2faf814") },
                    { new Guid("d787c65f-0d6f-4924-b0c5-f9addcd26323"), null, null, "Pierre.Bechtelar9@yahoo.com", new Guid("f498a63d-900c-464a-8fab-e4232968dc8b") },
                    { new Guid("d8078c41-9209-4fb8-8f5e-8b49e500c7c7"), null, null, "Ivah71@yahoo.com", new Guid("7f857795-bd2a-48ee-bcf8-ec48fdb428ab") },
                    { new Guid("d81b377c-3cf1-4aa7-a4ae-a864dee7b0ef"), null, null, "Muhammad.Jones@hotmail.com", new Guid("dca6b19f-e9ff-4d07-b3df-fe7e57f8b960") },
                    { new Guid("d89be52c-71a9-4d21-a00d-1991857c9e36"), null, null, "Walter5@yahoo.com", new Guid("b09cd69c-fd2f-4c43-9227-439aa81d485e") },
                    { new Guid("d8b8f444-520a-450d-82a1-beae4bd723c5"), null, null, "Gayle2@hotmail.com", new Guid("1281e6c3-dc02-4e83-a90d-37f640411dfc") },
                    { new Guid("d9686805-5213-4c00-8eac-b2bb8c72846b"), null, null, "Josue.Russel66@hotmail.com", new Guid("c2edd12d-5919-4c5c-b18f-3b1ef2ea8f55") },
                    { new Guid("dae58294-5450-4967-93d3-70d7cf20f506"), null, null, "Zena59@hotmail.com", new Guid("c78c659a-335a-4de3-940d-5ed29586f5d9") },
                    { new Guid("daecdc4b-8418-4771-86fb-5137752624c6"), null, null, "Joana21@hotmail.com", new Guid("77a05cfa-406d-4342-a924-73d56bf2829a") },
                    { new Guid("db4e2129-da0b-403e-a9d1-458cf2892324"), null, null, "Willa.Kerluke@hotmail.com", new Guid("2b62c42e-4571-4d98-bd8d-7ba20ea3e48b") },
                    { new Guid("db7cd01c-7c21-46db-8dea-460741cecf7f"), null, null, "Melissa_Lehner@yahoo.com", new Guid("56780bb1-6c9e-4f24-a024-e244137c0516") },
                    { new Guid("dcb96fe8-b787-42d0-b444-d53638d0b9ca"), null, null, "Erich.Schaden@yahoo.com", new Guid("371bed01-75b2-47b9-9535-3156b9a4c959") },
                    { new Guid("dd211443-dd83-4290-a745-1c2ddee55c91"), null, null, "Eloise_Bradtke@hotmail.com", new Guid("ce3412db-b24b-4f68-8e32-724c140b7d0a") },
                    { new Guid("dd263f2b-b2cc-4c83-8b5e-e50a9c262b8c"), null, null, "Jameson.McDermott@yahoo.com", new Guid("d50ea512-4841-4fdb-b6f1-1805a1f266cc") },
                    { new Guid("ddab2ece-8200-4e20-a3f0-2455b9cd5924"), null, null, "Elsie78@hotmail.com", new Guid("96830fa4-dc91-4a31-8fad-9b956fd29c58") },
                    { new Guid("ddc30b89-aaf3-4b0b-aada-903fbc913bc6"), null, null, "Pietro4@yahoo.com", new Guid("fbcf0085-dd67-4f41-b656-a0c0900baca5") },
                    { new Guid("ddf91b16-486b-4889-a321-dfb40ff6f1cd"), null, null, "Noemy2@yahoo.com", new Guid("13164560-3eb6-4f4f-9c11-1f819fc48e22") },
                    { new Guid("de212354-a65e-43a8-ab66-200b1e7191d5"), null, null, "Lavonne69@hotmail.com", new Guid("b89fe956-f020-4fc2-affd-e06c759e4081") },
                    { new Guid("de349718-517b-49c4-a868-5955928a0f5b"), null, null, "Lyda73@yahoo.com", new Guid("abfe1efb-0a8f-4af4-ab49-6de94e3ef374") },
                    { new Guid("de43831c-e5ff-46b9-a27e-7863582bd29f"), null, null, "Dale.McLaughlin@hotmail.com", new Guid("c6d62b30-8c4e-444d-a56a-cf5bea9f9c2a") },
                    { new Guid("ded94b0b-32e4-4260-a453-cbab647bbc16"), null, null, "Josianne52@gmail.com", new Guid("0c210681-d608-4ef0-acaa-f6ca1d403524") },
                    { new Guid("e02253ba-2302-43de-b211-aca38c2a4a86"), null, null, "Bill.Koch@yahoo.com", new Guid("09e536d1-50fd-453a-80d5-e8283f64b0da") },
                    { new Guid("e02318bd-105c-4c6d-b241-6ca112765732"), null, null, "Jett.Mayert55@yahoo.com", new Guid("5dd3e047-c6f3-412d-b5cb-12b416f99706") },
                    { new Guid("e0b44387-506e-48ba-ad61-afd61e528a26"), null, null, "Friedrich.Hessel@gmail.com", new Guid("0c210681-d608-4ef0-acaa-f6ca1d403524") },
                    { new Guid("e0b5f564-f739-429d-a812-2102d9e61fc2"), null, null, "Layne_Konopelski@gmail.com", new Guid("ea67b8fa-bc9a-4e27-8ba5-f3c2359c883a") },
                    { new Guid("e1b2ad7d-7b22-42f3-af08-5694f930c9de"), null, null, "Sammie.Wisozk@yahoo.com", new Guid("58e47d27-16f3-4806-acf1-7b73ccbc0d5e") },
                    { new Guid("e2151736-224c-4da8-9cf3-76c025f570d8"), null, null, "Hipolito50@gmail.com", new Guid("74059a15-c214-4079-bc91-f8aa180574a7") },
                    { new Guid("e232496b-9a4b-4bd1-b178-2e0f8d6d2de0"), null, null, "Fern92@gmail.com", new Guid("d50ea512-4841-4fdb-b6f1-1805a1f266cc") },
                    { new Guid("e283024d-475b-458c-9747-32f39721c9eb"), null, null, "Josefina.Mayert11@gmail.com", new Guid("479adb19-03b9-482c-b165-7766492bfdf2") },
                    { new Guid("e2965903-a174-4d83-ba16-f6dda2984513"), null, null, "Felipe_Hahn@yahoo.com", new Guid("db7dd226-4232-45fe-a502-06e0dfd99b42") },
                    { new Guid("e2b49dcf-8bab-4a41-b962-c6b42dda51d3"), null, null, "Monty39@yahoo.com", new Guid("19d85480-882e-40f7-a536-84a552b3e447") },
                    { new Guid("e2efadd9-2886-4fe4-8900-5ea89c1a3c4b"), null, null, "Marilou32@gmail.com", new Guid("e2fd10a1-4989-4088-ae2b-0b5909314728") },
                    { new Guid("e3302f22-5f0b-4213-aaf6-6d6b4a01c060"), null, null, "Elise_Schowalter11@hotmail.com", new Guid("c4ec53d7-69be-4d5d-9091-29c7f80bd641") },
                    { new Guid("e361b738-08d2-4889-8926-b7857684e689"), null, null, "Hilario34@hotmail.com", new Guid("5881d0e1-89ce-4573-8217-2e4c8ee1688e") },
                    { new Guid("e36b8cee-ffac-45c4-929b-a54b96a45411"), null, null, "Yoshiko67@hotmail.com", new Guid("b2abd3eb-7d4b-49b1-8a46-4ea8b8313ab8") },
                    { new Guid("e37b6167-8c78-4648-b643-0869022d7d07"), null, null, "Bernard.Krajcik21@yahoo.com", new Guid("73cff5d2-f041-4e6e-8857-560606637e86") },
                    { new Guid("e3945a6a-42d9-4de4-9302-414c15acfa9a"), null, null, "Robbie34@yahoo.com", new Guid("25a38376-e74c-46cc-8d4f-292cebbcdffb") },
                    { new Guid("e4196555-372d-4290-ae01-dadeb6707b6d"), null, null, "Malinda50@hotmail.com", new Guid("ef8bcbb3-fff2-4f2c-aa48-9ad3e0312130") },
                    { new Guid("e4260d68-0886-418b-aa4c-02810d349c9f"), null, null, "Johnny.MacGyver@yahoo.com", new Guid("bdc35340-f998-4d2c-9ebc-c29624582c95") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("e43913be-e707-4bee-acb3-0d9964efae5b"), null, null, "Felicia_Brekke@hotmail.com", new Guid("7b9aa90c-3f91-430e-bbb3-c445e0de9d01") },
                    { new Guid("e45d49b9-2013-4cf4-a0a5-086c50a67ac1"), null, null, "Rex_Willms@yahoo.com", new Guid("fbcf0085-dd67-4f41-b656-a0c0900baca5") },
                    { new Guid("e46a2f6a-c22e-4f6d-a235-74e73d17ad41"), null, null, "Eugene34@gmail.com", new Guid("e0518a7c-2290-4dde-8de0-19fe26c3d8fa") },
                    { new Guid("e500bd5c-4ae9-4e48-896c-68be11701286"), null, null, "Bernadette.Olson86@yahoo.com", new Guid("0edec355-b022-4255-80d6-c530f687d26e") },
                    { new Guid("e5b460c2-9a66-4a53-91e8-60e3d9818838"), null, null, "Lesley_Jacobson77@yahoo.com", new Guid("4f7cd1ca-72e9-46bd-ab1e-ae8fa37d21a4") },
                    { new Guid("e64cf344-bb9a-4bed-9592-8df0bea3ad12"), null, null, "Cristian_Heller@yahoo.com", new Guid("6441d6d0-462e-4346-8bea-ddea048566dd") },
                    { new Guid("e68dbf38-bcd4-4c95-8c34-d8f6f276761b"), null, null, "Barbara_Morar71@hotmail.com", new Guid("0dce50e5-ef29-456b-ab6f-c4454c5cfc38") },
                    { new Guid("e739dd5e-a0cc-489b-b282-0eb26762133e"), null, null, "Amelie.Romaguera12@gmail.com", new Guid("c78c659a-335a-4de3-940d-5ed29586f5d9") },
                    { new Guid("e7840c3d-24fb-4f8f-93a5-73d18f5108ec"), null, null, "Javonte.Legros@hotmail.com", new Guid("0763ce92-5a2c-4138-ad42-41c5b45988dd") },
                    { new Guid("e84218fd-4bbd-4b68-9849-70f8eb53b6b9"), null, null, "Rhett.Sauer11@yahoo.com", new Guid("bdd49191-641c-4843-a442-069a71c65be5") },
                    { new Guid("e8eab867-6d64-4286-bdd6-7a9af38ef73a"), null, null, "Marty_Koelpin@gmail.com", new Guid("ce3412db-b24b-4f68-8e32-724c140b7d0a") },
                    { new Guid("e9207e85-b42d-48c5-8553-763b6eada76d"), null, null, "Devan.Johnson@hotmail.com", new Guid("21aa2202-92c4-4bb8-a2f8-9785eb49fe49") },
                    { new Guid("e92bd0d1-d373-47c6-9b36-c9dd397f586d"), null, null, "Wyman_Rodriguez@yahoo.com", new Guid("af831e9b-a557-4f53-81e7-2278eb8802a1") },
                    { new Guid("e9cb30ff-ac17-4858-babd-a0ef8737b4d8"), null, null, "Eusebio_Sporer71@hotmail.com", new Guid("e0518a7c-2290-4dde-8de0-19fe26c3d8fa") },
                    { new Guid("eae60f1f-de4c-42e1-9d11-d524ee4b17db"), null, null, "Dolores.Boehm@gmail.com", new Guid("0edec355-b022-4255-80d6-c530f687d26e") },
                    { new Guid("eb5e2c78-743f-4e51-a648-add72b96a466"), null, null, "Valerie_Batz40@hotmail.com", new Guid("8b82d9a1-181d-4f54-aa69-032bffd3d9d4") },
                    { new Guid("eb851d4b-9710-4f29-b7ab-2d4d25d829f0"), null, null, "Louvenia_Christiansen52@hotmail.com", new Guid("c4b80142-93ac-41b3-b29d-ff4cad905327") },
                    { new Guid("ec553cb1-040a-4f66-9c01-4338926b3365"), null, null, "Osborne.Balistreri40@yahoo.com", new Guid("7b9aa90c-3f91-430e-bbb3-c445e0de9d01") },
                    { new Guid("ec7ed60c-ce2a-4ac6-b3d7-bee82eedef6a"), null, null, "Dario.Prosacco@hotmail.com", new Guid("7271d193-6a4b-40d9-ab91-a7d8a07e45bb") },
                    { new Guid("ec9409b0-24b5-4e6e-bb3a-35be5538c68c"), null, null, "Logan4@gmail.com", new Guid("c2edd12d-5919-4c5c-b18f-3b1ef2ea8f55") },
                    { new Guid("ec964069-319f-4965-a123-08259ca00745"), null, null, "Dax_Lemke84@yahoo.com", new Guid("68bf203c-5d15-452a-b81b-bb7831c4f579") },
                    { new Guid("eca99c75-a674-493e-8e5f-14b12bcbada9"), null, null, "Berenice.Bartell@gmail.com", new Guid("a907043f-86ba-4126-baac-6e2c6eb5871c") },
                    { new Guid("ecc126a3-7fd3-435f-8169-6678b8ce9607"), null, null, "Luella42@yahoo.com", new Guid("af867e87-ddef-4efe-ba16-9ce831f47443") },
                    { new Guid("ed18b505-54f5-4d7a-ac7e-6dc69cd9f6b4"), null, null, "Agnes.Gleichner@hotmail.com", new Guid("a5e0abc8-bc40-47e6-bf22-077c758ba0a7") },
                    { new Guid("ed465d96-cf03-4d77-8786-4aedd9f36305"), null, null, "Laila.Ritchie7@hotmail.com", new Guid("0fedadae-5c91-4999-9924-42f5fcd0de5b") },
                    { new Guid("edc07e1f-bd58-4916-889c-70ff943f5423"), null, null, "Ada_Cormier29@yahoo.com", new Guid("7adbc5f0-6d2f-4d16-ad51-1b76edd52481") },
                    { new Guid("ee7d0f85-17e8-4b4c-b167-6cdd696bf950"), null, null, "Elva.Nikolaus6@hotmail.com", new Guid("74059a15-c214-4079-bc91-f8aa180574a7") },
                    { new Guid("eeb3632b-349a-4eb7-ae8d-7c67efeeb451"), null, null, "Lavern_Ondricka78@gmail.com", new Guid("11e566bf-b29d-4651-8e8c-7f65a8281c80") },
                    { new Guid("ef36dcf1-241a-45b9-ab40-b0131888a492"), null, null, "Donato_Wolff63@gmail.com", new Guid("34c24f57-b16e-4b0f-abe2-5cb9c260e918") },
                    { new Guid("ef864c7d-68da-487c-9bd8-51ac94f3f328"), null, null, "Mark20@gmail.com", new Guid("52fe76ad-4c09-4b99-9385-e407990c0307") },
                    { new Guid("f1080e1d-4d3f-4888-8d54-582e940bf945"), null, null, "Emmie_Grimes23@hotmail.com", new Guid("611b8b1f-53d5-4660-9ad4-e0b57e915bf8") },
                    { new Guid("f1100c36-93df-4b72-8b5c-bc83f9602085"), null, null, "Anne_Ruecker@yahoo.com", new Guid("b7003b5f-1610-4487-9fd1-c03a6d0982d7") },
                    { new Guid("f1fd96a4-3b7c-4929-b714-f169bc81c069"), null, null, "Vito37@yahoo.com", new Guid("4f750333-43c7-4b6d-871b-3959dea7a14e") },
                    { new Guid("f2256e13-ff90-4fde-b719-a2b04c93441a"), null, null, "Ursula.Ondricka@yahoo.com", new Guid("d6f2753c-e864-40f4-a45e-4096737598aa") },
                    { new Guid("f24d11d2-5d12-4ac4-8c04-19de197722a2"), null, null, "Candido20@yahoo.com", new Guid("70fe5fa7-69ef-4577-a750-34ca205c0dac") },
                    { new Guid("f24db8f2-5c79-43e7-ba9b-3db9c91d0260"), null, null, "Assunta.Barrows61@hotmail.com", new Guid("52fe76ad-4c09-4b99-9385-e407990c0307") },
                    { new Guid("f2737fe3-dc9f-4405-a702-cd1417a009c6"), null, null, "Isabel.Feil77@gmail.com", new Guid("2293afe4-2408-427c-9960-7223d1291070") },
                    { new Guid("f27fab68-59bc-4b18-bf43-fbab07965751"), null, null, "Jeremy_West7@hotmail.com", new Guid("41e507fd-f435-49b8-a35c-9fba98848542") },
                    { new Guid("f287d3b8-d64e-4230-9bd3-2497b70c4de3"), null, null, "Fritz59@yahoo.com", new Guid("9e9403fb-605a-441d-a83a-f936fec7582f") },
                    { new Guid("f2eae2e7-502b-42a4-98ce-ac94c76baf85"), null, null, "Vance16@gmail.com", new Guid("428063f6-fd3a-42bd-b0be-ba01a5e85a84") },
                    { new Guid("f31ddf17-a013-4ace-be24-fbe8d75a8573"), null, null, "Kameron33@hotmail.com", new Guid("22a1446b-6ffd-488e-8e70-011276aa0ae3") },
                    { new Guid("f3687f86-8742-4bc2-8bd0-6fa718d525e0"), null, null, "Reinhold63@yahoo.com", new Guid("4b70366e-a511-4254-8c8d-ad820ee7b210") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("f371ee57-c1ea-43cd-a4c9-37f4ebda1095"), null, null, "Dashawn96@gmail.com", new Guid("09fe5fb4-f36b-4a46-81a1-c617e335393a") },
                    { new Guid("f3da6879-e3ee-4f23-b457-df7416d353df"), null, null, "Bennie_Friesen19@gmail.com", new Guid("27f9e909-39f0-43df-afb3-3bc130e8da06") },
                    { new Guid("f44550c0-50ce-4829-86b1-fa8731e7ccf4"), null, null, "Lamont_Zemlak@gmail.com", new Guid("1281e6c3-dc02-4e83-a90d-37f640411dfc") },
                    { new Guid("f45b30ef-f959-4dde-a977-a9959310b67c"), null, null, "Clemmie78@hotmail.com", new Guid("7975589e-fce3-4ff6-8b4d-4f29aa2e3c37") },
                    { new Guid("f48b1a28-876e-449f-8e27-a98b7467c1d7"), null, null, "Luna_Jacobs@gmail.com", new Guid("49e9f216-cefc-4a4e-a243-81e78152afb7") },
                    { new Guid("f48c003c-5e13-4975-ba88-d22c6cad80a2"), null, null, "Myrna_Bartell@hotmail.com", new Guid("54f16999-7e05-407e-aab8-1c56cdb79653") },
                    { new Guid("f4eaf936-0cd4-49b4-869f-f8531dd2a64b"), null, null, "Sandrine.Schowalter@gmail.com", new Guid("045fcec6-e944-4ba4-ab53-e930bdb298c6") },
                    { new Guid("f53ab76d-69f3-4be1-bd62-ad856ae504af"), null, null, "Verdie.Tillman79@yahoo.com", new Guid("fa671618-4f8c-472d-aad1-18adb7778e70") },
                    { new Guid("f5484648-1980-49d6-87c2-9832b426a6f1"), null, null, "Chasity24@yahoo.com", new Guid("3af6d087-276b-42a2-9c69-d7501840f5a1") },
                    { new Guid("f573835a-a80c-4cc2-bf1d-53bb86a3f84c"), null, null, "Mauricio_Blanda@hotmail.com", new Guid("ef8bcbb3-fff2-4f2c-aa48-9ad3e0312130") },
                    { new Guid("f5d9cb9f-4c42-4500-96db-815e47ccc465"), null, null, "Sidney.Koelpin@hotmail.com", new Guid("73953973-c12c-407d-b23d-97f5b010569d") },
                    { new Guid("f60a6904-5260-4b89-8e7e-c5cc626417e1"), null, null, "Devin8@yahoo.com", new Guid("8b82d9a1-181d-4f54-aa69-032bffd3d9d4") },
                    { new Guid("f60f74fa-d22e-4e70-8382-b03823133910"), null, null, "Laisha.Roob4@yahoo.com", new Guid("e135b016-8e68-479f-a8e6-0c1dd16d5c2f") },
                    { new Guid("f6b88206-976b-4192-9a6c-4a1ef7e29157"), null, null, "Tom99@yahoo.com", new Guid("dda60091-f993-4d23-997a-ac4774d856d5") },
                    { new Guid("f6f84d61-8e4a-4f28-a960-c80753ffb2ab"), null, null, "Adelbert58@hotmail.com", new Guid("40de2c6f-e29d-4027-93c3-945e76ec015c") },
                    { new Guid("f6ff98ae-4a55-467e-8f02-b62c71611efe"), null, null, "Carmine.Weissnat66@gmail.com", new Guid("922f53da-9877-4d56-a64d-6d83331bdbb6") },
                    { new Guid("f75b3c57-0024-48cc-844c-a2dc8343aa15"), null, null, "Lonnie_Jenkins61@hotmail.com", new Guid("a3bc456f-939a-42c3-99ed-719e0db5bf18") },
                    { new Guid("f7930275-d071-416e-8e08-8b9ef514e7de"), null, null, "Karine_Witting@gmail.com", new Guid("89739d78-901e-4353-8c13-fe879541f76f") },
                    { new Guid("f7c3648e-d042-4f18-a5c6-3c7efa5e1e0e"), null, null, "Eleanore7@hotmail.com", new Guid("a0d3cad9-30ac-4da2-8952-dcde6122a64a") },
                    { new Guid("f87c2e0c-bb61-476b-a2d4-c4deb0fc70c5"), null, null, "Wilhelm.Predovic@gmail.com", new Guid("2275ad3d-6816-4c2b-ba9c-96a3dc4f45fb") },
                    { new Guid("f8e721be-0450-4e61-92e9-38f9ee7e55ce"), null, null, "Roselyn.Schuster@gmail.com", new Guid("8d7de522-82d8-4912-bf1a-5d80658097e7") },
                    { new Guid("f8f839b6-403c-4ee4-90e7-b429a5a58553"), null, null, "Maribel.VonRueden42@yahoo.com", new Guid("68bf203c-5d15-452a-b81b-bb7831c4f579") },
                    { new Guid("f912f79b-248d-4446-8594-01140e1a5121"), null, null, "Ludie.Rath@hotmail.com", new Guid("f57190db-67c4-4d7b-9cd1-c8e27a6ac561") },
                    { new Guid("f93d67d2-7193-4473-a528-549c5034c875"), null, null, "Zoe.Toy33@gmail.com", new Guid("6d64cb25-3e39-4da8-a0e1-a3ee13dd1071") },
                    { new Guid("f9625b44-8cac-40c8-970a-ec0f28ba44f4"), null, null, "Morton52@yahoo.com", new Guid("143cf7ff-f2e3-444c-a15b-3aa7b4c43475") },
                    { new Guid("f9e50cc0-c85b-41d9-808c-eff4e7d157c5"), null, null, "Billie.Purdy17@yahoo.com", new Guid("4b70366e-a511-4254-8c8d-ad820ee7b210") },
                    { new Guid("fa5afe08-b3b6-471a-aa8b-c0a789d5c57e"), null, null, "Curtis77@yahoo.com", new Guid("7c403944-d570-486e-9c1f-e40454a443f6") },
                    { new Guid("fab5af2c-8112-4d70-ab6c-e243d654ab4d"), null, null, "Malcolm_Schaden@hotmail.com", new Guid("c075bfdf-a5cc-4efb-a6d1-f31b0c4bf344") },
                    { new Guid("fad35c23-18ba-4f81-b2bd-985e0d9c1775"), null, null, "Loraine77@hotmail.com", new Guid("f57190db-67c4-4d7b-9cd1-c8e27a6ac561") },
                    { new Guid("fae01c51-0d2b-4e55-bc62-246802627028"), null, null, "Claude86@gmail.com", new Guid("d173c22f-aa53-4e3b-b137-bcd6d2faf814") },
                    { new Guid("fb77ba57-e647-4aac-a9a9-c3f21d2c663e"), null, null, "Keshaun53@yahoo.com", new Guid("af67d494-10d3-4417-9f74-90816ee69f93") },
                    { new Guid("fbb2d84f-8fa1-4bb3-929e-543205425d05"), null, null, "Carroll.Von4@hotmail.com", new Guid("40de2c6f-e29d-4027-93c3-945e76ec015c") },
                    { new Guid("fbe48f7a-dcd9-4c79-8f01-17dab54df034"), null, null, "Ramona.Greenfelder67@gmail.com", new Guid("1fda2339-4864-46e3-bf7d-81a520206ae9") },
                    { new Guid("fc767b15-7aaf-4ab0-8b66-4ebab918d07e"), null, null, "Waldo43@yahoo.com", new Guid("351d8ea5-1894-4ffb-9d93-a257287acb66") },
                    { new Guid("fc968180-2b71-4bdb-b4d4-796290a2c3a0"), null, null, "Yazmin.Hilpert@hotmail.com", new Guid("92fa424c-9623-4989-b9fe-494533664c26") },
                    { new Guid("fcc1b017-7fd3-424f-9ca0-fd2a6cff10e7"), null, null, "Ona66@yahoo.com", new Guid("db7dd226-4232-45fe-a502-06e0dfd99b42") },
                    { new Guid("fd806dfc-19fd-43c2-bc3b-f7d58052c74d"), null, null, "Malinda_Hirthe47@hotmail.com", new Guid("d52df32f-0260-40eb-8234-13ab7a744fcb") },
                    { new Guid("fdecc107-a5a4-494b-a70c-3ab9bf1d8bcc"), null, null, "Chad.Schuster@gmail.com", new Guid("bfb2c3f3-d581-43c3-ad34-2b9af77e293a") },
                    { new Guid("fe065c1c-ec6c-4538-b7be-f79c26879e6f"), null, null, "Estefania_Powlowski18@hotmail.com", new Guid("5881d0e1-89ce-4573-8217-2e4c8ee1688e") },
                    { new Guid("fe1feccc-a97d-4268-851c-1c8f9cff1894"), null, null, "Bertrand.Weber48@gmail.com", new Guid("9f2db745-dcf4-4a49-a27a-ae15a2f3087e") },
                    { new Guid("fe7b8ab0-b2e9-4e3f-b9ed-92769dc4ae10"), null, null, "Rachelle.Pfannerstill@hotmail.com", new Guid("1070c404-0d57-4ba4-828e-4ca0d5ec2262") },
                    { new Guid("fe7f6681-5a4d-42a0-8095-273fafda771c"), null, null, "Anastasia_Hammes4@hotmail.com", new Guid("2c5320bb-6c0a-46cc-9731-a7b34514e4c1") }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("006335f4-7ba9-4203-b477-64c175e1e924"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 30, 3, 29, 17, 204, DateTimeKind.Local).AddTicks(2305), new DateTime(2023, 7, 2, 3, 29, 17, 204, DateTimeKind.Local).AddTicks(2305), null, 18.21m, true, 1943141522853906m, true, "Special", 2, 34.461803f, "612 Dibbert Gardens, Margueritestad, Faroe Islands", new Guid("9f2db745-dcf4-4a49-a27a-ae15a2f3087e"), "2281 Kirlin Lakes, Hackettchester, Bangladesh", new Guid("922f53da-9877-4d56-a64d-6d83331bdbb6"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("008a4a5b-ee82-4bbe-a414-99811a0a7ad9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 29, 18, 41, 2, 515, DateTimeKind.Local).AddTicks(8341), new DateTime(2023, 10, 4, 18, 41, 2, 515, DateTimeKind.Local).AddTicks(8341), null, 99.78m, 3258959147642022m, true, "Super", 1, 19.336485f, "4400 Clark Common, East Hildegard, Myanmar", new Guid("2078228d-bb74-4e81-8e84-3dd4a76ea271"), "5521 Dickinson Wells, Waltonmouth, Denmark", new Guid("ae1ca1b0-7eff-4b3f-a0bd-d326d1ebe578"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("00d96453-9b65-4cb3-9475-db51f4326f3c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 17, 17, 53, 45, 174, DateTimeKind.Local).AddTicks(9672), new DateTime(2024, 1, 27, 17, 53, 45, 174, DateTimeKind.Local).AddTicks(9672), null, 60.94m, true, 9991720161804676m, "Courier", 2, 17.550058f, "44067 Guiseppe Fort, North Leoraview, Thailand", new Guid("f57190db-67c4-4d7b-9cd1-c8e27a6ac561"), "9522 Murazik Villages, Baumbachview, Georgia", new Guid("4e8f092d-b1e1-47d3-9de6-5d9db26187a5"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("01e710e1-430c-4e8b-8611-c601e6b8d37e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 19, 14, 54, 2, 301, DateTimeKind.Local).AddTicks(6152), new DateTime(2024, 4, 22, 14, 54, 2, 301, DateTimeKind.Local).AddTicks(6152), null, 46.82m, 1653327644552144m, "ParcelMachine", 5, 38.833885f, "20358 Schiller Corner, Lilianafurt, Panama", new Guid("2a79982f-f343-4569-a725-228ecab03718"), "18503 Alexandra Gateway, North Adeline, Belize", new Guid("7f857795-bd2a-48ee-bcf8-ec48fdb428ab"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("03853848-0b90-4ef1-8871-92188cc52894"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 27, 17, 40, 0, 198, DateTimeKind.Local).AddTicks(3310), new DateTime(2024, 4, 30, 17, 40, 0, 198, DateTimeKind.Local).AddTicks(3310), null, 11.42m, true, 1941723843096975m, "Courier", 3, 48.830402f, "9269 Imogene Glens, Pasqualeport, American Samoa", new Guid("b2085c8a-b530-4404-a522-eaa5962529ec"), "245 Javon Streets, Blandachester, Moldova", new Guid("53d8997e-27d6-4129-b5f1-0072e7f179bf"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("05b5f403-bd64-46ee-8e8a-e17edec0c4df"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 1, 13, 40, 57, 860, DateTimeKind.Local).AddTicks(7700), new DateTime(2023, 7, 7, 13, 40, 57, 860, DateTimeKind.Local).AddTicks(7700), null, 46.32m, true, 6984148554694302m, true, "Courier", 3, 7.2625f, "004 Reynolds Pines, East Dangelotown, Ireland", new Guid("b7f7d261-2525-4477-8b55-bba019231e9f"), "532 Nola Creek, South Beauburgh, Australia", new Guid("e135b016-8e68-479f-a8e6-0c1dd16d5c2f"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("086e7865-60fc-4be9-8260-8eb78797da22"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 12, 23, 55, 27, 448, DateTimeKind.Local).AddTicks(4460), new DateTime(2023, 7, 14, 23, 55, 27, 448, DateTimeKind.Local).AddTicks(4460), null, 72.65m, true, 6681228577077775m, "Super", 3, 32.71504f, "155 Ondricka Radial, Maximohaven, Cameroon", new Guid("e0518a7c-2290-4dde-8de0-19fe26c3d8fa"), "5572 Bernhard Junction, Beckerborough, Belize", new Guid("e6fc9f3f-e447-488c-a497-0bec2a6f9fea"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("09b6fc38-38de-477c-b283-2c2d16631ccd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 20, 0, 19, 53, 379, DateTimeKind.Local).AddTicks(1930), new DateTime(2024, 5, 23, 0, 19, 53, 379, DateTimeKind.Local).AddTicks(1930), null, 93.72m, 6652290735967352m, true, "ParcelMachine", 3, 3.5033252f, "5027 Ismael Village, East Emerymouth, American Samoa", new Guid("56460594-4f75-42d8-9106-e7e3ec02c12c"), "70874 Shaina Unions, Abigailmouth, Montserrat", new Guid("1530b862-24b5-484d-8939-50315a49bd13"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("0a64e71f-0a62-4e0a-b86e-597dbb8c454e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 30, 1, 33, 40, 485, DateTimeKind.Local).AddTicks(5758), new DateTime(2024, 5, 5, 1, 33, 40, 485, DateTimeKind.Local).AddTicks(5758), null, 48.89m, true, 7139045198850023m, true, "Standart", 1, 27.281652f, "7495 Corwin Forks, Lake Judge, Myanmar", new Guid("ea67b8fa-bc9a-4e27-8ba5-f3c2359c883a"), "971 Armand Shores, New Karelleport, Malawi", new Guid("750c9633-57cd-4cce-b195-c19394ee24b3"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("0e54c1e4-534d-41a1-93a1-2982a91aada0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 10, 10, 5, 23, 392, DateTimeKind.Local).AddTicks(5532), new DateTime(2024, 1, 12, 10, 5, 23, 392, DateTimeKind.Local).AddTicks(5532), null, 23.60m, true, 2798795967613583m, "Super", 4, 28.448826f, "4059 Bernhard Trail, Breitenbergville, Croatia", new Guid("ac4b1e96-68b1-4502-856c-10b88acf07fa"), "36812 Denesik Fort, West Marcel, Cambodia", new Guid("27f9e909-39f0-43df-afb3-3bc130e8da06"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("0eab3ea7-0ca0-416a-8a2f-3ca2dcd67d04"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 2, 13, 59, 26, 569, DateTimeKind.Local).AddTicks(6782), new DateTime(2024, 1, 7, 13, 59, 26, 569, DateTimeKind.Local).AddTicks(6782), null, 98.76m, 6470383500353867m, "Special", 5, 41.695587f, "146 Schultz Brooks, South Calebhaven, Myanmar", new Guid("c4ec53d7-69be-4d5d-9091-29c7f80bd641"), "12944 Lisa Throughway, Lake Adolphside, New Zealand", new Guid("89f14bfd-f2ad-40fc-8c24-b21398e3c7d3"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("0f10bfa0-2d27-4d3e-9a03-96da8a863d5c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 1, 12, 54, 30, 374, DateTimeKind.Local).AddTicks(3579), new DateTime(2023, 9, 8, 12, 54, 30, 374, DateTimeKind.Local).AddTicks(3579), null, 96.09m, true, 4740518687184260m, "Super", 5, 31.21829f, "244 McDermott Route, Carolynport, Portugal", new Guid("15a8aac9-d692-4882-990e-3e575587579f"), "12224 Jacobi Hills, Rudybury, Kiribati", new Guid("f498a63d-900c-464a-8fab-e4232968dc8b"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("110113ec-2f8c-4c49-9ab5-6d3a83747745"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 17, 21, 51, 8, 642, DateTimeKind.Local).AddTicks(3845), new DateTime(2023, 9, 18, 21, 51, 8, 642, DateTimeKind.Local).AddTicks(3845), null, 65.08m, 5614874137932492m, "Special", 4, 36.89807f, "772 Deanna Roads, Watsicahaven, Burkina Faso", new Guid("0c210681-d608-4ef0-acaa-f6ca1d403524"), "9417 Lauryn Alley, Wolfside, Uzbekistan", new Guid("5210b0bd-a591-4887-9abb-0f4415c0f467"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("1497d514-aa21-4cb2-b379-1ed569699724"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 1, 18, 24, 18, 163, DateTimeKind.Local).AddTicks(8653), new DateTime(2023, 10, 5, 18, 24, 18, 163, DateTimeKind.Local).AddTicks(8653), null, 78.82m, 8962500677696538m, true, "Special", 4, 22.940453f, "37174 Kulas Mews, West Darrick, Honduras", new Guid("8c8ff9a2-2752-46a7-960e-0490c28de13f"), "69031 Audie Passage, Beermouth, Uruguay", new Guid("0643292c-1282-43c9-ae18-5e2311a73db2"), "OnTheWay", "PlasticBag" },
                    { new Guid("1f4d20ad-b110-4421-96cf-bf0cccb1aa31"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 24, 17, 47, 19, 48, DateTimeKind.Local).AddTicks(6309), new DateTime(2024, 6, 1, 17, 47, 19, 48, DateTimeKind.Local).AddTicks(6309), null, 92.56m, 2563471545848643m, true, "Super", 2, 39.964993f, "504 Kozey Knolls, North Arely, Malaysia", new Guid("9336f657-bf13-4455-becf-1afff818911b"), "25812 Norma Loaf, Lennaville, Somalia", new Guid("58e47d27-16f3-4806-acf1-7b73ccbc0d5e"), "OnTheWay", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("28db454f-8db8-4cae-9f47-194e6777ee29"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 8, 3, 18, 28, 611, DateTimeKind.Local).AddTicks(2665), new DateTime(2023, 10, 12, 3, 18, 28, 611, DateTimeKind.Local).AddTicks(2665), null, 10.16m, true, 6390416778950977m, "Standart", 2, 29.557089f, "027 Cassin Station, East Arnulfo, Russian Federation", new Guid("00e8ecc6-7b14-4020-bcbd-1a849d69a8c6"), "12695 Kip Isle, South Derekborough, United States Minor Outlying Islands", new Guid("c864b34c-ddf5-4af6-9a5f-d8251c512e8f"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("30b6d504-8e28-489f-a711-8125c6203882"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 12, 7, 54, 58, 606, DateTimeKind.Local).AddTicks(3551), new DateTime(2024, 1, 21, 7, 54, 58, 606, DateTimeKind.Local).AddTicks(3551), null, 87.79m, 6610948028714716m, true, "Courier", 3, 5.4132514f, "833 Grayson Crescent, New Arnomouth, French Polynesia", new Guid("53d8997e-27d6-4129-b5f1-0072e7f179bf"), "7846 Anissa Mission, Muellerland, Australia", new Guid("3b1108de-e27d-4674-b7ff-c1df3b68ae41"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("31a42b24-fba3-4b2d-b73d-a7fe940b6178"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 18, 18, 20, 21, 330, DateTimeKind.Local).AddTicks(9264), new DateTime(2024, 5, 26, 18, 20, 21, 330, DateTimeKind.Local).AddTicks(9264), null, 53.75m, true, 5144566816428489m, true, "Super", 5, 26.257534f, "9135 Abernathy Spring, Rodborough, Benin", new Guid("8d7de522-82d8-4912-bf1a-5d80658097e7"), "86314 Bruen Views, Padbergchester, Uzbekistan", new Guid("ddf155f2-6984-4582-b06c-39700b8ecb92"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("34ed31c5-ae60-49de-961b-a4828730fe4d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 17, 23, 1, 50, 487, DateTimeKind.Local).AddTicks(4941), new DateTime(2023, 10, 26, 23, 1, 50, 487, DateTimeKind.Local).AddTicks(4941), null, 52.18m, 4580559560011206m, true, "Super", 5, 22.451546f, "585 Kub Shoals, Ortiztown, Togo", new Guid("9252c306-249a-4267-8ef5-891d8c0cbea1"), "53488 Hoeger Springs, East Keanu, Swaziland", new Guid("922f53da-9877-4d56-a64d-6d83331bdbb6"), "OnTheWay", "PlasticBag" },
                    { new Guid("3632fe15-0c65-4e7f-b6e6-4db9840f4290"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 2, 15, 37, 25, 512, DateTimeKind.Local).AddTicks(2194), new DateTime(2023, 10, 5, 15, 37, 25, 512, DateTimeKind.Local).AddTicks(2194), null, 89.13m, 5814805052944255m, true, "ParcelMachine", 5, 16.019117f, "61990 Chloe Drives, East Pascaleside, Cocos (Keeling) Islands", new Guid("34abae3b-f28c-4c59-a716-fea9a1b0e1bb"), "0745 Kovacek Fall, North Jarenhaven, Bulgaria", new Guid("65cb2c49-f00f-450e-94e8-540312a9ce09"), "Sent", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("3ee848cf-916d-45ea-86a8-83a09ef49f73"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 27, 14, 9, 41, 350, DateTimeKind.Local).AddTicks(5208), new DateTime(2023, 12, 3, 14, 9, 41, 350, DateTimeKind.Local).AddTicks(5208), null, 40.19m, true, 3249328153643367m, true, "Standart", 1, 35.90089f, "750 Harber Wall, North Crawford, Montserrat", new Guid("08e9beba-81d1-40e1-9f0f-4d282258b85b"), "0846 Katrina Alley, West Sigrid, Sao Tome and Principe", new Guid("1fda2339-4864-46e3-bf7d-81a520206ae9"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("458490d4-14f0-463c-8163-008cd5c44b61"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 9, 2, 33, 52, 855, DateTimeKind.Local).AddTicks(5241), new DateTime(2023, 7, 15, 2, 33, 52, 855, DateTimeKind.Local).AddTicks(5241), null, 36.45m, 2756362731520692m, true, "Super", 5, 11.556919f, "8931 Kunze Valleys, Timmyport, India", new Guid("07169b5c-40fd-40ba-b01e-8b56de466065"), "623 Dicki Extension, Braunton, Vietnam", new Guid("bb021ddc-2731-4d61-8069-ddee5e7759da"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("47179757-c199-4277-a090-9c1807af17b0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 25, 23, 17, 59, 510, DateTimeKind.Local).AddTicks(9562), new DateTime(2024, 4, 27, 23, 17, 59, 510, DateTimeKind.Local).AddTicks(9562), null, 97.06m, 6977138745420585m, "Courier", 2, 31.06686f, "5073 Robin Mission, Port Tillmanmouth, Kuwait", new Guid("f3ea0004-e1e2-4557-a9d5-14a5369a2eb3"), "9293 Isaac Knolls, West Gardner, Mauritius", new Guid("371bed01-75b2-47b9-9535-3156b9a4c959"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("4da39e51-a84e-4b2f-86b1-ffd850da2584"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 27, 13, 28, 19, 944, DateTimeKind.Local).AddTicks(2717), new DateTime(2023, 8, 2, 13, 28, 19, 944, DateTimeKind.Local).AddTicks(2717), null, 10.74m, true, 9956483650874140m, "ParcelMachine", 2, 25.428978f, "1895 McGlynn Radial, Lake Olafville, Paraguay", new Guid("fbcf0085-dd67-4f41-b656-a0c0900baca5"), "67280 Lubowitz Overpass, Lindgrenside, Bangladesh", new Guid("f7ba49ab-b88c-4490-8dc0-4a731ec11ec3"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("4e9ea799-6057-45f4-bfdc-80a95ed15316"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 5, 3, 50, 18, 689, DateTimeKind.Local).AddTicks(2561), new DateTime(2023, 11, 6, 3, 50, 18, 689, DateTimeKind.Local).AddTicks(2561), null, 66.81m, 3565779956039962m, true, "ParcelMachine", 2, 32.713528f, "76149 Robel Garden, Mitchellhaven, Luxembourg", new Guid("77a05cfa-406d-4342-a924-73d56bf2829a"), "6485 Jennyfer Dale, Wilfordtown, Togo", new Guid("f2fc34d0-f967-4d49-ac54-2191c244d200"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("4fae377e-8b79-4061-98c9-26a7ea15e25e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 22, 16, 17, 40, 296, DateTimeKind.Local).AddTicks(581), new DateTime(2023, 8, 24, 16, 17, 40, 296, DateTimeKind.Local).AddTicks(581), null, 53.44m, 9589878826755736m, "Super", 3, 25.738457f, "3965 Stamm Loop, Brekkeville, Solomon Islands", new Guid("2d52a2a2-27d8-49a4-9ce6-969bb0f68fa2"), "64621 Armstrong Villages, New Jacques, Peru", new Guid("f7effd3e-f620-479e-861c-7fb6220a3843"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("509e29cc-2b96-4c9b-8fde-afc7cdea9864"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 16, 14, 38, 44, 5, DateTimeKind.Local).AddTicks(6635), new DateTime(2023, 6, 18, 14, 38, 44, 5, DateTimeKind.Local).AddTicks(6635), null, 60.07m, true, 7394688741366597m, "ParcelMachine", 1, 42.154797f, "163 McCullough Spur, New Luisville, Ecuador", new Guid("3359f4d4-fbc1-4174-b3e0-8cc3754ac07b"), "3074 Macejkovic Terrace, North Chasityview, Senegal", new Guid("efacb463-5422-4958-902a-44c5cd16f26b"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("57165fc4-e8ed-4e66-9d1c-49751124a149"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 27, 2, 25, 58, 36, DateTimeKind.Local).AddTicks(3759), new DateTime(2023, 11, 6, 2, 25, 58, 36, DateTimeKind.Local).AddTicks(3759), null, 22.01m, true, 7394396440670299m, true, "Standart", 3, 21.098112f, "261 Roberts Streets, West Jettie, China", new Guid("f57190db-67c4-4d7b-9cd1-c8e27a6ac561"), "59212 Marvin Union, North Koryton, Switzerland", new Guid("8180db6e-0139-48fa-a7bc-8424ac74378c"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("5995cde6-30c8-4811-af6e-18eb6a481acd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 7, 2, 40, 29, 8, DateTimeKind.Local).AddTicks(7878), new DateTime(2024, 3, 15, 2, 40, 29, 8, DateTimeKind.Local).AddTicks(7878), null, 43.54m, 1054160011458325m, true, "Special", 1, 18.404736f, "783 Berge Mount, East Lunaberg, Falkland Islands (Malvinas)", new Guid("4af3e803-6a3d-43c8-9c77-811cb6207644"), "52233 Harber Mount, Julietown, Guyana", new Guid("5322c711-eaf5-4b14-8d69-cc6bf8809924"), "OnTheWay", "PlasticBag" },
                    { new Guid("59dcab38-bf41-45b2-a6d8-25e41947df90"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 4, 5, 53, 3, 924, DateTimeKind.Local).AddTicks(6526), new DateTime(2024, 5, 5, 5, 53, 3, 924, DateTimeKind.Local).AddTicks(6526), null, 98.78m, 8554141884570002m, true, "Super", 3, 21.127325f, "9230 Blanda Isle, Trentborough, Kyrgyz Republic", new Guid("52fe76ad-4c09-4b99-9385-e407990c0307"), "96198 Jordy Station, Lake Kathleenhaven, Guyana", new Guid("f498a63d-900c-464a-8fab-e4232968dc8b"), "Delivered", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("5a907ebf-6c20-48d8-8f79-a97779f1e7a6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 14, 13, 59, 16, 80, DateTimeKind.Local).AddTicks(9413), new DateTime(2023, 11, 15, 13, 59, 16, 80, DateTimeKind.Local).AddTicks(9413), null, 17.51m, true, 4862742621645747m, "Standart", 3, 20.564028f, "9697 Karine Parkway, Stuarttown, Madagascar", new Guid("4f750333-43c7-4b6d-871b-3959dea7a14e"), "811 Hand Cliff, Carrieton, Tuvalu", new Guid("09ff0b03-eca3-4596-9c5d-d809a2f99a1e"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("5b51f578-e56f-4f8a-a3d4-d574533ccd64"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 31, 5, 31, 56, 971, DateTimeKind.Local).AddTicks(3935), new DateTime(2024, 1, 2, 5, 31, 56, 971, DateTimeKind.Local).AddTicks(3935), null, 39.38m, true, 3587814117190152m, true, "Courier", 5, 2.7856822f, "27771 Grant Turnpike, East Elena, Panama", new Guid("c0159440-683d-4c76-a904-aa1f4564822f"), "260 Stehr Mount, Joneston, Finland", new Guid("428063f6-fd3a-42bd-b0be-ba01a5e85a84"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("5c5ed57e-4328-480e-aaff-9e654e153a90"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 17, 5, 39, 27, 177, DateTimeKind.Local).AddTicks(7666), new DateTime(2024, 2, 25, 5, 39, 27, 177, DateTimeKind.Local).AddTicks(7666), null, 67.88m, 5077155909491701m, "Super", 5, 20.340937f, "932 Werner Plain, Mylestown, Belarus", new Guid("bb021ddc-2731-4d61-8069-ddee5e7759da"), "509 Davis Wall, North Brentchester, Saint Kitts and Nevis", new Guid("37f65b1e-268a-4a07-9f55-107b4df3c700"), "Sent", "PlasticBag" },
                    { new Guid("5cee07b5-ecee-4100-b639-2984610434b8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 21, 12, 44, 32, 548, DateTimeKind.Local).AddTicks(1229), new DateTime(2023, 12, 24, 12, 44, 32, 548, DateTimeKind.Local).AddTicks(1229), null, 35.25m, 4330453206109048m, "Super", 2, 11.602122f, "12642 Titus Pike, Cristianberg, Bulgaria", new Guid("7247fafb-5d1e-43fe-a447-5b99c26b77ba"), "5336 Sigurd Walks, Cassinshire, Western Sahara", new Guid("0763ce92-5a2c-4138-ad42-41c5b45988dd"), "OnTheWay", "PlasticBag" },
                    { new Guid("5d4e4641-b0f9-4021-a085-dbc65bff4b9a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 21, 4, 49, 0, 213, DateTimeKind.Local).AddTicks(9853), new DateTime(2023, 8, 23, 4, 49, 0, 213, DateTimeKind.Local).AddTicks(9853), null, 28.86m, 8763050982371335m, "Standart", 5, 4.35409f, "5255 Jeff Green, Deshawnshire, Virgin Islands, British", new Guid("7adbc5f0-6d2f-4d16-ad51-1b76edd52481"), "1104 Jenkins Knolls, South Darleneton, Cuba", new Guid("08fd0c31-2e97-4cfb-bbf0-9eca4d7bbf0c"), "OnTheWay", "PlasticBag" },
                    { new Guid("5da47d47-9b86-44a8-8991-e32102df3d98"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 13, 14, 32, 25, 984, DateTimeKind.Local).AddTicks(9345), new DateTime(2023, 9, 14, 14, 32, 25, 984, DateTimeKind.Local).AddTicks(9345), null, 23.19m, 4866491691375578m, "Courier", 2, 13.312392f, "16159 Wilfredo Crossroad, North Theostad, United States Minor Outlying Islands", new Guid("92fa424c-9623-4989-b9fe-494533664c26"), "122 Bartell Springs, West Lafayettehaven, New Caledonia", new Guid("25a38376-e74c-46cc-8d4f-292cebbcdffb"), "OnTheWay", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("60dd8f34-d5f4-4036-8b66-07e364bad6c0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 13, 10, 0, 21, 813, DateTimeKind.Local).AddTicks(8555), new DateTime(2024, 5, 21, 10, 0, 21, 813, DateTimeKind.Local).AddTicks(8555), null, 38.03m, true, 4556245695354828m, true, "Standart", 1, 22.729635f, "011 Kassulke Ramp, Reichertchester, Cayman Islands", new Guid("b252505e-f926-4638-a778-09894c7e3345"), "72429 Isom Hill, Bashirianborough, Tunisia", new Guid("2a79982f-f343-4569-a725-228ecab03718"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("696f5f81-520c-4c85-9896-116c231b0c26"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 19, 10, 29, 5, 368, DateTimeKind.Local).AddTicks(8996), new DateTime(2024, 2, 27, 10, 29, 5, 368, DateTimeKind.Local).AddTicks(8996), null, 51.79m, true, 2780818491411054m, "Super", 3, 21.473085f, "6925 Rodrigo Station, Talonchester, Haiti", new Guid("b2abd3eb-7d4b-49b1-8a46-4ea8b8313ab8"), "8027 Franecki Mall, West Eleonoreburgh, China", new Guid("a1e9eb46-748f-4b86-8554-7ae48675b2da"), "Registered", "CardboardBox" },
                    { new Guid("721d1e79-0b65-4b29-b761-3719a7ca86ef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 9, 7, 34, 15, 843, DateTimeKind.Local).AddTicks(1), new DateTime(2023, 12, 19, 7, 34, 15, 843, DateTimeKind.Local).AddTicks(1), null, 74.80m, true, 4052098173398706m, "Standart", 1, 19.635815f, "0175 Moen Land, New Annabelleborough, Latvia", new Guid("2293afe4-2408-427c-9960-7223d1291070"), "42820 Koch Shoals, North Leonelstad, Svalbard & Jan Mayen Islands", new Guid("d50ea512-4841-4fdb-b6f1-1805a1f266cc"), "Sent", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("789961ca-c7de-42bb-8a21-230eaa9c5b03"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 4, 17, 29, 30, 163, DateTimeKind.Local).AddTicks(1217), new DateTime(2023, 9, 7, 17, 29, 30, 163, DateTimeKind.Local).AddTicks(1217), null, 15.33m, true, 5492301936979428m, true, "Courier", 5, 39.12641f, "24163 Greenholt Harbor, Zemlakburgh, Bulgaria", new Guid("08fd0c31-2e97-4cfb-bbf0-9eca4d7bbf0c"), "33930 Giovanny Fields, Harveyland, French Guiana", new Guid("4f7cd1ca-72e9-46bd-ab1e-ae8fa37d21a4"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7ea9fe15-e440-4c00-bb31-22b18d0b6d76"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 3, 19, 29, 30, 572, DateTimeKind.Local).AddTicks(6596), new DateTime(2024, 5, 6, 19, 29, 30, 572, DateTimeKind.Local).AddTicks(6596), null, 53.41m, 6372008292597932m, "Standart", 4, 38.816715f, "993 Kristina Land, East Bernieceland, Bhutan", new Guid("ae39cf22-04cf-4eb4-8b28-b59be4789ea6"), "341 Nettie Streets, Samsontown, Ukraine", new Guid("7e04a2e8-5af7-4c5e-8b81-d51fb8eb210b"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("8033c34d-6745-4ebb-a537-bd79682c7736"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 7, 9, 24, 32, 372, DateTimeKind.Local).AddTicks(9323), new DateTime(2023, 10, 14, 9, 24, 32, 372, DateTimeKind.Local).AddTicks(9323), null, 53.41m, 3598525498582541m, true, "ParcelMachine", 5, 23.637074f, "626 Buckridge Tunnel, Melissaview, Spain", new Guid("cc019092-2135-4dea-b991-c8b67614f148"), "110 Clint Coves, South Annabelle, Spain", new Guid("428063f6-fd3a-42bd-b0be-ba01a5e85a84"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("80dda3ab-f8e4-45a1-9a85-96c4c1049c18"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 7, 7, 37, 26, 624, DateTimeKind.Local).AddTicks(7983), new DateTime(2023, 7, 16, 7, 37, 26, 624, DateTimeKind.Local).AddTicks(7983), null, 31.80m, true, 8161851298970310m, true, "Standart", 2, 7.453153f, "1821 Billie Crossroad, Lake Enoch, Italy", new Guid("8887b8ab-eb5d-41ad-bac2-3126e85117d1"), "2341 Ericka Mountain, New Alanborough, French Southern Territories", new Guid("f2fc34d0-f967-4d49-ac54-2191c244d200"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("8190f318-ac15-4f76-b760-8289ea862e82"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 14, 15, 34, 18, 375, DateTimeKind.Local).AddTicks(9172), new DateTime(2023, 11, 15, 15, 34, 18, 375, DateTimeKind.Local).AddTicks(9172), null, 42.83m, 7024535085572753m, "Courier", 5, 33.522747f, "254 Lysanne Well, Kiehnhaven, Kenya", new Guid("2078228d-bb74-4e81-8e84-3dd4a76ea271"), "07451 Bella Prairie, Dareshire, Peru", new Guid("5210b0bd-a591-4887-9abb-0f4415c0f467"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("82e770ba-5afd-4408-8393-22c7ddfb3f58"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 7, 5, 6, 31, 559, DateTimeKind.Local).AddTicks(882), new DateTime(2023, 11, 9, 5, 6, 31, 559, DateTimeKind.Local).AddTicks(882), null, 94.55m, true, 8066883042521307m, true, "Standart", 4, 37.310745f, "655 Serenity Stream, Lake Lindsay, Ecuador", new Guid("89739d78-901e-4353-8c13-fe879541f76f"), "8954 Price Gardens, Lake Otiliaview, Lithuania", new Guid("c075bfdf-a5cc-4efb-a6d1-f31b0c4bf344"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("8338b9fc-3b4b-4ffe-a609-250cf5de2ebe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 3, 4, 1, 26, 798, DateTimeKind.Local).AddTicks(9383), new DateTime(2023, 12, 10, 4, 1, 26, 798, DateTimeKind.Local).AddTicks(9383), null, 79.25m, 2444088247167310m, true, "Super", 2, 0.7844232f, "74033 Trinity Islands, Gladyceport, Uganda", new Guid("d02ec5f5-af87-4bcb-954a-b24e23737d68"), "89686 Keagan Forest, East Ianbury, Gambia", new Guid("5146be01-925a-447f-b871-b7de98b487df"), "Return", "CardboardBox" },
                    { new Guid("855f9301-1779-4896-9226-b71632db85ac"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 17, 22, 56, 3, 94, DateTimeKind.Local).AddTicks(2921), new DateTime(2023, 6, 19, 22, 56, 3, 94, DateTimeKind.Local).AddTicks(2921), null, 36.23m, 8700726975570294m, true, "Courier", 3, 20.361464f, "993 Murray Path, New Jazmyne, Djibouti", new Guid("60c86293-9017-4722-ad96-c09fd6051a5b"), "2130 Dorcas Row, Lake Caterinabury, Austria", new Guid("bb021ddc-2731-4d61-8069-ddee5e7759da"), "OnTheWay", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("8679824b-3d89-4e75-a008-743b2899bb51"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 18, 8, 14, 59, 585, DateTimeKind.Local).AddTicks(1069), new DateTime(2023, 9, 26, 8, 14, 59, 585, DateTimeKind.Local).AddTicks(1069), null, 54.32m, 3423491747878605m, "Standart", 5, 34.243114f, "4487 Kenya Tunnel, Lake Aric, Montserrat", new Guid("f070ec16-f59a-41c8-8ab6-b492f05b08e3"), "708 Hope Greens, Billborough, Marshall Islands", new Guid("089446be-2352-4d8f-9726-ba2c324e1aee"), "Delivered", "PlasticBag" },
                    { new Guid("8bbf3528-02e5-4ee9-9bdc-598f6108f466"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 6, 14, 37, 2, 342, DateTimeKind.Local).AddTicks(473), new DateTime(2024, 2, 8, 14, 37, 2, 342, DateTimeKind.Local).AddTicks(473), null, 68.86m, 1862779525806642m, "Standart", 4, 18.272308f, "1837 Dickinson Village, West Allisonhaven, Sudan", new Guid("732ba531-5faf-4b4a-bcac-24d9ca3fcbc2"), "898 Mikayla Branch, North Mariannabury, Cocos (Keeling) Islands", new Guid("dda60091-f993-4d23-997a-ac4774d856d5"), "Registered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("8cba152a-dcc9-460c-b7c8-0395fb1004bf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 7, 17, 20, 4, 53, 3, DateTimeKind.Local).AddTicks(15), new DateTime(2023, 7, 21, 20, 4, 53, 3, DateTimeKind.Local).AddTicks(15), null, 11.72m, 6137345194158649m, true, "ParcelMachine", 3, 21.75321f, "03946 Mercedes Mission, South Paytonton, Georgia", new Guid("08fd0c31-2e97-4cfb-bbf0-9eca4d7bbf0c"), "462 Melba Crescent, Kozeymouth, Cocos (Keeling) Islands", new Guid("9f2db745-dcf4-4a49-a27a-ae15a2f3087e"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("8cd31d31-f72b-4bc5-844d-64f572cbf793"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 19, 0, 5, 23, 449, DateTimeKind.Local).AddTicks(8851), new DateTime(2023, 8, 26, 0, 5, 23, 449, DateTimeKind.Local).AddTicks(8851), null, 48.44m, 3332420393326224m, "Standart", 1, 42.858025f, "488 Mertz Points, Streichchester, Turkmenistan", new Guid("2c5320bb-6c0a-46cc-9731-a7b34514e4c1"), "49962 Rice Lane, Rudyton, Lebanon", new Guid("6127ea05-85cc-4ed4-9b13-5998aee91180"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("8da142b5-a5d7-4d53-9303-ae29d974bfd1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 12, 17, 47, 1, 918, DateTimeKind.Local).AddTicks(6194), new DateTime(2023, 8, 14, 17, 47, 1, 918, DateTimeKind.Local).AddTicks(6194), null, 18.62m, true, 4996896970310192m, true, "Standart", 5, 43.55991f, "580 Juliet Isle, Mrazstad, Jamaica", new Guid("7adbc5f0-6d2f-4d16-ad51-1b76edd52481"), "64457 Carter Shores, West Clairville, Togo", new Guid("07169b5c-40fd-40ba-b01e-8b56de466065"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("8e87b844-a1ed-49e9-a3de-d72790cae754"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 25, 8, 57, 27, 410, DateTimeKind.Local).AddTicks(6310), new DateTime(2024, 1, 1, 8, 57, 27, 410, DateTimeKind.Local).AddTicks(6310), null, 32.05m, 9968872230769924m, true, "Standart", 5, 45.721912f, "306 Kurtis Unions, West Johnathonmouth, Spain", new Guid("a339ea33-3188-40c2-9d84-9ea46aa67e82"), "37738 Zieme Shoal, Forestport, Antigua and Barbuda", new Guid("f4909d03-d7ac-4aaf-a6fe-77a88f9fe06b"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("8f332f1e-a5d6-4633-975d-ab5bdf7d21bb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 8, 8, 39, 36, 55, DateTimeKind.Local).AddTicks(4929), new DateTime(2024, 2, 15, 8, 39, 36, 55, DateTimeKind.Local).AddTicks(4929), null, 72.77m, 3212065863369311m, "ParcelMachine", 2, 2.727258f, "9621 Gail Junction, Lake Zoey, Ghana", new Guid("a6098ed7-dc3b-4d11-bcda-a3ba0c8ac2f4"), "3606 Cierra Port, South Gersonland, Iran", new Guid("a66e6d00-7000-4eb2-994b-a38594503957"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("929d38a5-2842-4dca-aa6f-6bd0af331d29"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 30, 2, 26, 20, 437, DateTimeKind.Local).AddTicks(4556), new DateTime(2023, 10, 8, 2, 26, 20, 437, DateTimeKind.Local).AddTicks(4556), null, 55.40m, 3032116439631186m, true, "Courier", 1, 12.148692f, "1549 Blaise Meadows, North Geovannyview, Slovakia (Slovak Republic)", new Guid("a6098ed7-dc3b-4d11-bcda-a3ba0c8ac2f4"), "590 Greenfelder Turnpike, New Nathanchester, Saint Barthelemy", new Guid("712b2e8f-feec-4b44-842e-63c59bbe48cb"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("97d234cb-f77f-4ce7-8232-d7feb5212c92"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 5, 6, 19, 32, 946, DateTimeKind.Local).AddTicks(1934), new DateTime(2024, 5, 11, 6, 19, 32, 946, DateTimeKind.Local).AddTicks(1934), null, 38.14m, true, 1127700665569465m, true, "Super", 1, 30.588402f, "2314 Katelin Wall, Drakeport, Japan", new Guid("ea94f56c-ef76-423b-81af-2da80b37dfa6"), "79650 Ratke Orchard, South Camila, Sri Lanka", new Guid("11b76a5d-870e-46d3-b3e3-0af0f8f871ac"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("98343fee-480e-4543-bfc6-60aabca8a47b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 24, 20, 56, 34, 820, DateTimeKind.Local).AddTicks(6204), new DateTime(2023, 12, 31, 20, 56, 34, 820, DateTimeKind.Local).AddTicks(6204), null, 14.63m, 4526006299855283m, true, "ParcelMachine", 1, 47.070934f, "5211 Abernathy Plaza, East Jaron, French Polynesia", new Guid("53d8997e-27d6-4129-b5f1-0072e7f179bf"), "0815 Audra Squares, South Kylie, Heard Island and McDonald Islands", new Guid("36afa758-a0b9-4345-9bce-db873a3c22fd"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("9d916d85-5969-4644-90c8-045a0bc1c44e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 24, 8, 15, 39, 999, DateTimeKind.Local).AddTicks(2988), new DateTime(2024, 4, 28, 8, 15, 39, 999, DateTimeKind.Local).AddTicks(2988), null, 64.03m, 6435436271952735m, "Super", 4, 38.3604f, "44309 Borer Garden, Bergeberg, Lao People's Democratic Republic", new Guid("5dd3e047-c6f3-412d-b5cb-12b416f99706"), "841 Noah Glens, Port Mateoland, Burkina Faso", new Guid("4f7cd1ca-72e9-46bd-ab1e-ae8fa37d21a4"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("9e6f09c3-f048-42af-b735-cf1304eb0a3c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 13, 0, 30, 33, 481, DateTimeKind.Local).AddTicks(1488), new DateTime(2023, 11, 23, 0, 30, 33, 481, DateTimeKind.Local).AddTicks(1488), null, 36.58m, 7760802415286349m, true, "ParcelMachine", 1, 3.8349206f, "70981 Denesik Courts, West Yoshikoview, Saudi Arabia", new Guid("b7f7d261-2525-4477-8b55-bba019231e9f"), "32235 Merlin Terrace, New Abdulmouth, Saint Pierre and Miquelon", new Guid("0fedadae-5c91-4999-9924-42f5fcd0de5b"), "Registered", "PlasticBag" },
                    { new Guid("9e6f641c-abeb-423b-8306-86401c92c947"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 22, 21, 39, 10, 212, DateTimeKind.Local).AddTicks(2847), new DateTime(2024, 2, 24, 21, 39, 10, 212, DateTimeKind.Local).AddTicks(2847), null, 77.97m, 9838803709924962m, true, "ParcelMachine", 3, 35.5064f, "289 Dax Viaduct, Cruickshankfort, Samoa", new Guid("c0159440-683d-4c76-a904-aa1f4564822f"), "521 Laury Course, North Sophia, Ethiopia", new Guid("6de94a05-0c03-4062-8ab9-57a5bd55b3a5"), "OnTheWay", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("a159d323-2be3-4319-81d5-3359d2724e20"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 11, 3, 44, 27, 739, DateTimeKind.Local).AddTicks(8805), new DateTime(2024, 5, 17, 3, 44, 27, 739, DateTimeKind.Local).AddTicks(8805), null, 91.00m, true, 7855810212994836m, "Standart", 1, 28.906998f, "9006 Harold Hollow, Predovicbury, Colombia", new Guid("27f9e909-39f0-43df-afb3-3bc130e8da06"), "78753 Jayson Locks, Baileyland, Hong Kong", new Guid("6d64cb25-3e39-4da8-a0e1-a3ee13dd1071"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("ac8936bf-81d6-4bd1-8fdd-6f4d17b28838"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 9, 2, 27, 11, 871, DateTimeKind.Local).AddTicks(4388), new DateTime(2023, 6, 19, 2, 27, 11, 871, DateTimeKind.Local).AddTicks(4388), null, 79.69m, 9035261978281100m, true, "Standart", 1, 44.960148f, "811 Cole Inlet, Jordanland, Slovenia", new Guid("89739d78-901e-4353-8c13-fe879541f76f"), "1240 Murray Harbor, Reinholdberg, Saint Lucia", new Guid("fc6059ea-998b-4053-8aa0-faef98da998c"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("af568754-a54a-4712-b255-3c9b26b5040d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 22, 7, 18, 0, 730, DateTimeKind.Local).AddTicks(1041), new DateTime(2023, 9, 23, 7, 18, 0, 730, DateTimeKind.Local).AddTicks(1041), null, 59.43m, true, 3137463792634505m, true, "Courier", 4, 29.451855f, "98895 Wolf Squares, Purdyland, Czech Republic", new Guid("5210b0bd-a591-4887-9abb-0f4415c0f467"), "9793 Kraig Lodge, South Ilene, Falkland Islands (Malvinas)", new Guid("89739d78-901e-4353-8c13-fe879541f76f"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("af79ded8-0762-4290-a339-10304a9e1d44"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 10, 22, 59, 53, 524, DateTimeKind.Local).AddTicks(901), new DateTime(2023, 6, 17, 22, 59, 53, 524, DateTimeKind.Local).AddTicks(901), null, 68.23m, true, 9723695220720190m, "Standart", 4, 21.902977f, "15889 Alexandrine Mission, South Lavada, Luxembourg", new Guid("7e04a2e8-5af7-4c5e-8b81-d51fb8eb210b"), "728 Donnelly Manors, Port Mya, Dominica", new Guid("37e41091-f10f-4b14-b68d-be058cea2e03"), "Delivered", "PlasticBag" },
                    { new Guid("b1dc6a90-1c4f-4610-858a-dca6ba613495"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 30, 6, 40, 22, 618, DateTimeKind.Local).AddTicks(7812), new DateTime(2023, 10, 10, 6, 40, 22, 618, DateTimeKind.Local).AddTicks(7812), null, 59.62m, true, 7782687753225950m, "Special", 1, 40.235664f, "6588 Anderson Green, Port Fatima, Aruba", new Guid("0c210681-d608-4ef0-acaa-f6ca1d403524"), "74224 Watson Throughway, Bartonburgh, Bosnia and Herzegovina", new Guid("af267ef9-b2cf-4adf-a9d0-a58e3acadfa6"), "Return", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("b2b2eb3f-2e46-447d-9def-3f2b4796e729"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 2, 5, 14, 4, 767, DateTimeKind.Local).AddTicks(8216), new DateTime(2023, 11, 8, 5, 14, 4, 767, DateTimeKind.Local).AddTicks(8216), null, 40.17m, 3985479922874732m, true, "Special", 3, 14.09513f, "3643 Kreiger Fields, Felipebury, Switzerland", new Guid("9102f36c-0db2-4a0e-b22a-bcaffabfb757"), "516 Boyer Fields, Bulahmouth, Samoa", new Guid("4f750333-43c7-4b6d-871b-3959dea7a14e"), "OnTheWay", "CardboardBox" },
                    { new Guid("b4376e9e-c268-4b90-8d75-7c3d967a36d3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 22, 2, 45, 33, 433, DateTimeKind.Local).AddTicks(643), new DateTime(2023, 12, 26, 2, 45, 33, 433, DateTimeKind.Local).AddTicks(643), null, 57.22m, 4106125295602891m, true, "Courier", 1, 24.264978f, "428 Kuhic Dale, Howellshire, Saudi Arabia", new Guid("8c149454-da44-4038-9ece-768e572c5282"), "024 Doug Ferry, North Chelsea, Turkmenistan", new Guid("2a79982f-f343-4569-a725-228ecab03718"), "Registered", "PlasticBag" },
                    { new Guid("b54a9007-74e6-46b9-99a2-5cef6045b72e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 27, 19, 48, 23, 640, DateTimeKind.Local).AddTicks(8827), new DateTime(2024, 2, 2, 19, 48, 23, 640, DateTimeKind.Local).AddTicks(8827), null, 34.65m, 8848000610987152m, true, "ParcelMachine", 3, 47.539803f, "575 Russel Trafficway, Lake Kasandra, Ukraine", new Guid("d9b74426-c418-4b51-a42a-af5906c2fcff"), "182 Davis Loaf, Lake Ashtonport, Liberia", new Guid("2c5320bb-6c0a-46cc-9731-a7b34514e4c1"), "Sent", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("b8ada974-c6e5-401a-bd66-3d03636a01d6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 26, 8, 55, 59, 354, DateTimeKind.Local).AddTicks(5598), new DateTime(2023, 12, 6, 8, 55, 59, 354, DateTimeKind.Local).AddTicks(5598), null, 27.09m, true, 3344740707271632m, true, "Standart", 4, 28.883167f, "5401 Lesley Passage, West Briana, Lao People's Democratic Republic", new Guid("dca6b19f-e9ff-4d07-b3df-fe7e57f8b960"), "1168 Effertz Ramp, Berniermouth, Portugal", new Guid("34abae3b-f28c-4c59-a716-fea9a1b0e1bb"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("ba7f9755-1d08-4b60-8f0c-d094dcd13523"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 16, 0, 15, 0, 561, DateTimeKind.Local).AddTicks(5416), new DateTime(2024, 1, 26, 0, 15, 0, 561, DateTimeKind.Local).AddTicks(5416), null, 33.71m, 7731165076865444m, "Super", 2, 19.243229f, "57594 Pollich Stream, West Zacharyfort, Senegal", new Guid("29c7fc41-2565-497d-8900-56c2e6208fa6"), "093 Hazel Parkway, South Anika, Nepal", new Guid("54f16999-7e05-407e-aab8-1c56cdb79653"), "Registered", "CardboardBox" },
                    { new Guid("bc2adffe-4f46-4c40-ba9d-c0458a1bd0a3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 3, 15, 18, 34, 139, DateTimeKind.Local).AddTicks(7137), new DateTime(2023, 11, 12, 15, 18, 34, 139, DateTimeKind.Local).AddTicks(7137), null, 44.78m, 7992044427412318m, "Courier", 3, 4.869969f, "590 Aron Street, East Kenny, Romania", new Guid("68bf203c-5d15-452a-b81b-bb7831c4f579"), "35557 Brakus Port, Weissnatbury, Belgium", new Guid("0c210681-d608-4ef0-acaa-f6ca1d403524"), "Return", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("bc55eb6e-ba49-4365-ae1e-40d59a54fe0a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 19, 7, 17, 47, 167, DateTimeKind.Local).AddTicks(7677), new DateTime(2023, 6, 26, 7, 17, 47, 167, DateTimeKind.Local).AddTicks(7677), null, 43.01m, 5684914551495870m, true, "Special", 3, 2.8643694f, "0234 Janet Centers, Conroyhaven, Lesotho", new Guid("7c403944-d570-486e-9c1f-e40454a443f6"), "851 Rohan Passage, New Madelynnville, Belarus", new Guid("a1e9eb46-748f-4b86-8554-7ae48675b2da"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("bd6ee1c3-cd3b-4127-a512-a984393aed8f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 23, 5, 14, 58, 87, DateTimeKind.Local).AddTicks(9039), new DateTime(2023, 9, 26, 5, 14, 58, 87, DateTimeKind.Local).AddTicks(9039), null, 31.11m, true, 1185679140954861m, true, "Standart", 3, 34.95197f, "0838 Bashirian Inlet, South Geoffreymouth, New Caledonia", new Guid("39fc9708-01f3-4ab0-8c26-d5bc00da55db"), "0258 Borer Valleys, New Derrick, Angola", new Guid("5322c711-eaf5-4b14-8d69-cc6bf8809924"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("bf715a18-0177-4cee-a434-3453db561506"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 7, 21, 59, 43, 396, DateTimeKind.Local).AddTicks(8628), new DateTime(2023, 8, 11, 21, 59, 43, 396, DateTimeKind.Local).AddTicks(8628), null, 19.18m, 2266939295819506m, "ParcelMachine", 2, 37.1762f, "97863 Sydnie Plains, North Meghan, Aruba", new Guid("6127ea05-85cc-4ed4-9b13-5998aee91180"), "726 Prosacco Brooks, Lake Angela, Mozambique", new Guid("d02ec5f5-af87-4bcb-954a-b24e23737d68"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("bfb0103a-c5cc-4bf4-8482-9a378dbf3eba"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 14, 0, 0, 34, 717, DateTimeKind.Local).AddTicks(173), new DateTime(2023, 11, 21, 0, 0, 34, 717, DateTimeKind.Local).AddTicks(173), null, 89.66m, 3365028184372430m, true, "Standart", 2, 36.78911f, "652 Sage Streets, East Leonardo, Guatemala", new Guid("8d7de522-82d8-4912-bf1a-5d80658097e7"), "8318 Axel Spur, New Gabe, Andorra", new Guid("a5e0abc8-bc40-47e6-bf22-077c758ba0a7"), "Sent", "CardboardBox" },
                    { new Guid("c177ef50-d54b-4bf7-888f-4e9e9e2d37b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 15, 12, 14, 48, 461, DateTimeKind.Local).AddTicks(51), new DateTime(2024, 4, 18, 12, 14, 48, 461, DateTimeKind.Local).AddTicks(51), null, 84.86m, 5489741090478312m, true, "ParcelMachine", 5, 4.3683796f, "32274 Zboncak Stream, Port Colin, Burkina Faso", new Guid("624d07fb-c364-4191-b439-aff73116c1d2"), "8268 Lilla Mill, New Alberto, Dominican Republic", new Guid("8dea05e1-92c5-40d9-9159-8e1dcb818034"), "OnTheWay", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("c8485b12-5727-4869-b904-78b799cc615d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 23, 12, 47, 44, 149, DateTimeKind.Local).AddTicks(1880), new DateTime(2023, 11, 2, 12, 47, 44, 149, DateTimeKind.Local).AddTicks(1880), null, 47.74m, true, 4667447058737510m, "Super", 1, 48.92895f, "2168 Jaeden Islands, Port Kian, Lesotho", new Guid("bb021ddc-2731-4d61-8069-ddee5e7759da"), "1816 Abernathy Lodge, Lake Keenanbury, Syrian Arab Republic", new Guid("ea94f56c-ef76-423b-81af-2da80b37dfa6"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("c973264c-abd4-4ffe-9362-fd02c4f843d6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 1, 0, 54, 34, 772, DateTimeKind.Local).AddTicks(4821), new DateTime(2023, 10, 9, 0, 54, 34, 772, DateTimeKind.Local).AddTicks(4821), null, 47.88m, 3533795788427804m, true, "Super", 2, 29.201315f, "332 Joshuah Spurs, Purdystad, France", new Guid("ab38dbfc-78a4-4d84-9e77-53448911bc9f"), "86557 Glover Flat, West Hermina, Morocco", new Guid("b09cd69c-fd2f-4c43-9227-439aa81d485e"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("cc442442-49a3-4549-a96f-c6cb031b87fd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 21, 17, 45, 16, 595, DateTimeKind.Local).AddTicks(5043), new DateTime(2024, 2, 26, 17, 45, 16, 595, DateTimeKind.Local).AddTicks(5043), null, 41.96m, true, 7046788750671598m, "ParcelMachine", 2, 7.4564247f, "46808 Nyasia Row, Kozeyton, Armenia", new Guid("624d07fb-c364-4191-b439-aff73116c1d2"), "0644 Corene Street, Port Arianetown, Monaco", new Guid("a66e6d00-7000-4eb2-994b-a38594503957"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("ce8947bb-64f7-4ebf-b276-4c3a41f8c5ff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 11, 13, 2, 54, 466, DateTimeKind.Local).AddTicks(1011), new DateTime(2023, 10, 19, 13, 2, 54, 466, DateTimeKind.Local).AddTicks(1011), null, 88.10m, 7744890292740693m, "Standart", 2, 49.224636f, "12665 Kathlyn Springs, North Audraborough, Iraq", new Guid("bb021ddc-2731-4d61-8069-ddee5e7759da"), "98899 Stiedemann Spring, Bobbiefurt, Barbados", new Guid("34abae3b-f28c-4c59-a716-fea9a1b0e1bb"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("da8b0b48-ae43-412a-8ba1-c2d780766fae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 14, 6, 20, 10, 150, DateTimeKind.Local).AddTicks(2762), new DateTime(2023, 6, 15, 6, 20, 10, 150, DateTimeKind.Local).AddTicks(2762), null, 80.29m, true, 7257983745200993m, "ParcelMachine", 2, 34.18967f, "5409 Steuber Track, Hartmannchester, Costa Rica", new Guid("7975589e-fce3-4ff6-8b4d-4f29aa2e3c37"), "1885 Domingo Hill, Port Jessikafort, Malawi", new Guid("4dd327b9-6a6d-48c5-bd5c-c99248206229"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("dbd6f3db-7a18-4825-ac7d-f1b27d66791e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 15, 8, 19, 6, 375, DateTimeKind.Local).AddTicks(9216), new DateTime(2024, 5, 25, 8, 19, 6, 375, DateTimeKind.Local).AddTicks(9216), null, 69.26m, true, 5917755588205936m, true, "Standart", 3, 20.020424f, "064 Donnell Flat, North Claudiafurt, Australia", new Guid("aa406ff8-810a-45a6-8b41-5028563ae3b6"), "13173 Anderson Overpass, Lake Brionnamouth, Armenia", new Guid("611b8b1f-53d5-4660-9ad4-e0b57e915bf8"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("dd85f108-744f-4fb6-8baf-d5abafa8a623"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 27, 1, 46, 49, 496, DateTimeKind.Local).AddTicks(4798), new DateTime(2023, 9, 28, 1, 46, 49, 496, DateTimeKind.Local).AddTicks(4798), null, 72.50m, true, 9333051570919432m, "Standart", 3, 10.404174f, "521 Spencer Spur, Haagstad, Comoros", new Guid("65cb2c49-f00f-450e-94e8-540312a9ce09"), "70602 Schmitt Ports, New Theodoraview, Gabon", new Guid("efacb463-5422-4958-902a-44c5cd16f26b"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("de1965f7-bf71-405e-af45-3449f4df6ec7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 5, 7, 24, 58, 198, DateTimeKind.Local).AddTicks(713), new DateTime(2024, 1, 12, 7, 24, 58, 198, DateTimeKind.Local).AddTicks(713), null, 68.23m, true, 8054803304646955m, true, "Special", 3, 15.692553f, "059 Heller Drive, East Alberta, Swaziland", new Guid("2f3d1b8f-7590-4d18-9002-4caa22511a8b"), "6440 Zboncak Streets, New Juana, Netherlands Antilles", new Guid("479adb19-03b9-482c-b165-7766492bfdf2"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("dea8b945-0cf1-46aa-9dff-65ffc5ae20c9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 5, 1, 40, 22, 110, DateTimeKind.Local).AddTicks(3789), new DateTime(2023, 9, 8, 1, 40, 22, 110, DateTimeKind.Local).AddTicks(3789), null, 77.33m, 8036194715829589m, "Standart", 4, 10.520421f, "907 Jakayla Port, Jaquanport, Reunion", new Guid("8fca9140-9c2e-4112-9850-cdf3b029b5ac"), "81808 Dorcas Landing, Nettieside, Lithuania", new Guid("428063f6-fd3a-42bd-b0be-ba01a5e85a84"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("dfc550d2-769b-492e-8458-1780fb7bf50c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 1, 18, 56, 35, 921, DateTimeKind.Local).AddTicks(5240), new DateTime(2023, 10, 7, 18, 56, 35, 921, DateTimeKind.Local).AddTicks(5240), null, 32.26m, true, 7839409889668262m, "ParcelMachine", 4, 44.85321f, "0189 Hoeger Streets, Domenickborough, Nauru", new Guid("37f65b1e-268a-4a07-9f55-107b4df3c700"), "236 Gilbert Turnpike, Meganefurt, Finland", new Guid("371bed01-75b2-47b9-9535-3156b9a4c959"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("e772ada4-af28-4356-87f5-8b458a858b79"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 25, 14, 35, 43, 757, DateTimeKind.Local).AddTicks(9279), new DateTime(2023, 7, 1, 14, 35, 43, 757, DateTimeKind.Local).AddTicks(9279), null, 94.26m, 8267014380863957m, true, "ParcelMachine", 5, 2.646284f, "59446 Pacocha Drive, Bodeview, Zambia", new Guid("bdc35340-f998-4d2c-9ebc-c29624582c95"), "07685 Stiedemann Fort, Eleazarbury, Italy", new Guid("09ff0b03-eca3-4596-9c5d-d809a2f99a1e"), "Return", "PlasticBag" },
                    { new Guid("e886c331-ec18-46c8-b4cb-632efc19f801"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 22, 16, 10, 5, 969, DateTimeKind.Local).AddTicks(970), new DateTime(2024, 1, 28, 16, 10, 5, 969, DateTimeKind.Local).AddTicks(970), null, 69.80m, 3257327502149991m, true, "ParcelMachine", 3, 27.539436f, "275 Champlin Meadows, Smithammouth, United Arab Emirates", new Guid("7975589e-fce3-4ff6-8b4d-4f29aa2e3c37"), "9628 Olaf Road, Willmsborough, Panama", new Guid("ac4b1e96-68b1-4502-856c-10b88acf07fa"), "Sent", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("eca3ef83-14e8-4105-bb2b-be758843f7ab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 6, 25, 14, 45, 44, 615, DateTimeKind.Local).AddTicks(4213), new DateTime(2023, 7, 4, 14, 45, 44, 615, DateTimeKind.Local).AddTicks(4213), null, 48.54m, true, 3376302713588986m, "Courier", 4, 8.905527f, "319 Kaden Falls, North Noemy, Pitcairn Islands", new Guid("9252c306-249a-4267-8ef5-891d8c0cbea1"), "139 Christine Cove, Port Carson, China", new Guid("5146be01-925a-447f-b871-b7de98b487df"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("ed28f71d-1144-4b20-b49c-666cee8ff932"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 11, 23, 51, 57, 623, DateTimeKind.Local).AddTicks(4479), new DateTime(2023, 9, 16, 23, 51, 57, 623, DateTimeKind.Local).AddTicks(4479), null, 13.10m, true, 8320090665535773m, true, "Courier", 4, 39.177868f, "13187 Zieme Stream, Genesisbury, Australia", new Guid("64677ac4-f6ca-4452-9192-ce10eab5a7a4"), "70276 Laurel Street, Irvington, Bulgaria", new Guid("9252c306-249a-4267-8ef5-891d8c0cbea1"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("ed456e01-1ba3-448d-b863-1edab79452ed"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 17, 8, 46, 36, 80, DateTimeKind.Local).AddTicks(6678), new DateTime(2023, 12, 19, 8, 46, 36, 80, DateTimeKind.Local).AddTicks(6678), null, 83.13m, 6489282889874714m, true, "Standart", 5, 11.276416f, "740 Kutch Orchard, East Miastad, Samoa", new Guid("2c5320bb-6c0a-46cc-9731-a7b34514e4c1"), "80733 Melvina Viaduct, Lake Savanna, Luxembourg", new Guid("4595bfbb-3a7d-407e-b6e6-b5d06b0ded5d"), "Delivered", "PlasticBag" },
                    { new Guid("ef73ae1d-f994-49b8-8753-0cebc9c12735"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 22, 16, 52, 29, 735, DateTimeKind.Local).AddTicks(6859), new DateTime(2024, 5, 26, 16, 52, 29, 735, DateTimeKind.Local).AddTicks(6859), null, 51.93m, 7682352215027666m, true, "Super", 3, 0.5288879f, "20963 Zulauf Courts, Port Amya, Russian Federation", new Guid("628d01f9-5feb-4e85-a1ac-d03470903a20"), "747 Fausto Gardens, Lake Viviennetown, Italy", new Guid("d62fe5e3-4821-411a-b458-87e89f41f2f1"), "Delivered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("f0d3defa-c5bc-4634-8c95-e333c3031dc2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 30, 13, 4, 15, 267, DateTimeKind.Local).AddTicks(7392), new DateTime(2023, 10, 31, 13, 4, 15, 267, DateTimeKind.Local).AddTicks(7392), null, 40.24m, 4446305616800165m, "Super", 2, 24.579876f, "923 Casper Rapid, South Rebekahfort, Uruguay", new Guid("b7065d5a-6bbd-485c-bd51-6a4a0fc35e18"), "3069 Percival Terrace, South Carleeburgh, Ukraine", new Guid("c2edd12d-5919-4c5c-b18f-3b1ef2ea8f55"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("f4b10a3b-7cca-4fb6-a340-5b552092398b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 24, 4, 11, 2, 141, DateTimeKind.Local).AddTicks(6482), new DateTime(2024, 3, 2, 4, 11, 2, 141, DateTimeKind.Local).AddTicks(6482), null, 63.38m, 4999240381422654m, true, "Super", 2, 42.86507f, "00071 Laverna Forks, Trevatown, Mauritania", new Guid("f8c6be38-3b48-44ea-9af5-7fd644c82034"), "96627 Coralie Keys, Darionmouth, Bahamas", new Guid("bb021ddc-2731-4d61-8069-ddee5e7759da"), "Delivered", "CardboardBox" },
                    { new Guid("f6da2cf2-6f55-4d5d-833a-3930ba5956a7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 8, 28, 17, 30, 11, 417, DateTimeKind.Local).AddTicks(6116), new DateTime(2023, 9, 6, 17, 30, 11, 417, DateTimeKind.Local).AddTicks(6116), null, 31.70m, 5852227694896625m, true, "Courier", 2, 22.697437f, "76601 Stroman Pike, South Khalidhaven, Tokelau", new Guid("1be28f90-0b14-4642-99f4-d8dd65c3d9f8"), "4756 Arlene Drives, Walkerstad, Dominican Republic", new Guid("d799d7ce-936a-414f-86fd-958f17b3f642"), "Delivered", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("f774fe36-925c-4fa6-a524-5e045fd921c7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 9, 29, 9, 3, 43, 548, DateTimeKind.Local).AddTicks(5377), new DateTime(2023, 10, 9, 9, 3, 43, 548, DateTimeKind.Local).AddTicks(5377), null, 79.65m, true, 1170000942772891m, true, "Super", 2, 0.57354695f, "08694 Maxwell Courts, Lake Erikfort, Romania", new Guid("b72dbc44-743b-4e39-a250-af429c1f09a9"), "7532 Elenora Vista, Adolfborough, Mexico", new Guid("1be28f90-0b14-4642-99f4-d8dd65c3d9f8"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("f82d6a56-36a1-4663-8506-5c1b06542deb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 13, 13, 21, 46, 42, DateTimeKind.Local).AddTicks(4717), new DateTime(2023, 12, 17, 13, 21, 46, 42, DateTimeKind.Local).AddTicks(4717), null, 22.76m, 2852022104558083m, "Courier", 5, 26.644075f, "45290 Norbert Turnpike, Lake Joshuah, Madagascar", new Guid("1be28f90-0b14-4642-99f4-d8dd65c3d9f8"), "7718 Schaden Knolls, Port Cordell, Slovenia", new Guid("243b9c2d-ab41-4ea2-b445-092baa8385bc"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("f8a08f93-b095-4cc0-9590-5c8001c17544"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 11, 8, 42, 23, 614, DateTimeKind.Local).AddTicks(5953), new DateTime(2024, 3, 18, 8, 42, 23, 614, DateTimeKind.Local).AddTicks(5953), null, 93.82m, 1690347672746773m, true, "Special", 5, 18.265846f, "03530 Hershel Green, Celestinoside, Grenada", new Guid("5dd3e047-c6f3-412d-b5cb-12b416f99706"), "1435 Lowe Hills, Boehmberg, Brazil", new Guid("ebecc10d-21da-4369-81d7-600c2de48f88"), "Sent", "PlasticBag" },
                    { new Guid("fcd1d48e-c547-4932-b70b-1ed6643d2f93"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 30, 23, 50, 59, 808, DateTimeKind.Local).AddTicks(2718), new DateTime(2024, 4, 1, 23, 50, 59, 808, DateTimeKind.Local).AddTicks(2718), null, 45.85m, 6462915768063254m, true, "ParcelMachine", 1, 21.289919f, "8701 Domenick Prairie, East Modestaside, Mozambique", new Guid("99d66586-6373-4afb-b333-7c5cb91075c4"), "79480 Mohammed Heights, East Rhett, Bahrain", new Guid("8343d773-e986-49d8-99e9-bd908398b011"), "Delivered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateCreated", "DateDeleted", "DateOfDispatch", "DateOfReceipt", "DateUpdated", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("fda940d0-dbd3-4157-b25c-f699eab0dab3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 4, 10, 32, 51, 686, DateTimeKind.Local).AddTicks(7045), new DateTime(2023, 10, 12, 10, 32, 51, 686, DateTimeKind.Local).AddTicks(7045), null, 52.56m, true, 7798062112092237m, "Courier", 3, 15.073172f, "26905 Walter Points, Dachfurt, Thailand", new Guid("9252c306-249a-4267-8ef5-891d8c0cbea1"), "88795 Everardo Field, Botsfordview, Holy See (Vatican City State)", new Guid("4a1c10a8-7cf3-42b7-9d73-0683e4bc1868"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("0035061a-89a7-497d-a879-f71571e83db0"), "252", "8921161395017447", null, null, new Guid("21aa2202-92c4-4bb8-a2f8-9785eb49fe49"), "12/05" },
                    { new Guid("003fd4f4-bb94-4b7f-a049-4f3f8363c6a4"), "146", "4676363726018797", null, null, new Guid("7319b27d-6146-4420-aa8d-717913c33345"), "11/05" },
                    { new Guid("0152a8a1-b5bb-4888-a0d1-7a2cd43ab12c"), "572", "7575232999309434", null, null, new Guid("1de915db-ea78-41e7-a3a2-76a8f6311629"), "09/27" },
                    { new Guid("0193485d-55fb-444c-8187-51829a8d26ca"), "423", "9457859385221315", null, null, new Guid("1fa36b53-f427-4c95-96d2-7c8a11050267"), "11/12" },
                    { new Guid("01dd53fa-a5a0-4322-a187-10e25dc008f6"), "911", "4737312113200621", null, null, new Guid("2d52a2a2-27d8-49a4-9ce6-969bb0f68fa2"), "10/11" },
                    { new Guid("02132e24-234f-42e4-a5b0-a13948c55b3a"), "159", "7307583032860003", null, null, new Guid("ea67b8fa-bc9a-4e27-8ba5-f3c2359c883a"), "07/11" },
                    { new Guid("02294f2e-fc7b-4f19-9f6d-081b6a1b5971"), "882", "7815833502148530", null, null, new Guid("b40e13af-a00a-45af-a681-b960cb8d6a7b"), "11/26" },
                    { new Guid("02341feb-d18f-4361-9c46-f271786fe8a7"), "895", "8540135955902504", null, null, new Guid("56780bb1-6c9e-4f24-a024-e244137c0516"), "01/21" },
                    { new Guid("02bc1940-1ac6-49d5-8e36-2383ebde9cc0"), "027", "1384816654840094", null, null, new Guid("8de401f3-837a-4e09-884e-ddf9af867804"), "09/06" },
                    { new Guid("02bfbf6e-8bdd-4b0a-83cd-6bff3cf81382"), "650", "9774148151201402", null, null, new Guid("a66e6d00-7000-4eb2-994b-a38594503957"), "08/08" },
                    { new Guid("02feeba8-c7af-411f-b799-108b365f894d"), "550", "5416884617955382", null, null, new Guid("65cb2c49-f00f-450e-94e8-540312a9ce09"), "05/04" },
                    { new Guid("0384484d-aa57-4559-b88e-85c33e907549"), "731", "4977025513096283", null, null, new Guid("2c5320bb-6c0a-46cc-9731-a7b34514e4c1"), "11/28" },
                    { new Guid("038a9aa6-2d60-42cd-82a3-48bee9330f5c"), "566", "7918662054858860", null, null, new Guid("ebecc10d-21da-4369-81d7-600c2de48f88"), "07/18" },
                    { new Guid("03c9a110-0eb3-431d-a386-c3238a30d3e5"), "442", "2211723683596283", null, null, new Guid("4f1ac364-cc01-4a40-a229-d66da5446413"), "09/20" },
                    { new Guid("046e77fe-1d37-40e7-a50b-8252441aba80"), "224", "8978600723846794", null, null, new Guid("c78c659a-335a-4de3-940d-5ed29586f5d9"), "10/07" },
                    { new Guid("0480d181-6889-4047-90f6-9f57c541fc5f"), "426", "8202122339255729", null, null, new Guid("a907043f-86ba-4126-baac-6e2c6eb5871c"), "05/17" },
                    { new Guid("04b6bb5c-2f36-4f69-bba8-222bd69255bb"), "322", "2697476133826892", null, null, new Guid("c0159440-683d-4c76-a904-aa1f4564822f"), "08/14" },
                    { new Guid("04c41d87-136b-4623-a40b-726f2d37a441"), "514", "7633027306297065", null, null, new Guid("611b8b1f-53d5-4660-9ad4-e0b57e915bf8"), "03/21" },
                    { new Guid("04cbae41-5fd6-4af0-8807-f5bb3cd4be4c"), "779", "1858644436530025", null, null, new Guid("600649dd-c6d1-4ff3-9144-03f6ff7e6950"), "11/25" },
                    { new Guid("04f0b458-7dcc-47f0-93a4-8a1eeceacae6"), "814", "9825485873860461", null, null, new Guid("e0518a7c-2290-4dde-8de0-19fe26c3d8fa"), "08/16" },
                    { new Guid("0521e932-0a37-4ace-bb5e-35dca8a09c37"), "883", "2304894919284465", null, null, new Guid("7e04a2e8-5af7-4c5e-8b81-d51fb8eb210b"), "03/10" },
                    { new Guid("060875f1-b63a-45c1-b854-a847b7b68b02"), "707", "4501495474992057", null, null, new Guid("5398a079-6d82-4f82-8917-3f9eea9310eb"), "05/21" },
                    { new Guid("06441537-0578-4966-bca6-be4d0ad8909d"), "772", "3371635339150353", null, null, new Guid("b7065d5a-6bbd-485c-bd51-6a4a0fc35e18"), "11/02" },
                    { new Guid("06502cfd-65cb-44c5-8f95-b28998516143"), "344", "3928098443308869", null, null, new Guid("59e5a95d-f3ce-47fe-a7c9-70a6b47faac1"), "11/27" },
                    { new Guid("06662085-33aa-4d49-88ad-bec73ebdc9b8"), "602", "3369807108844234", null, null, new Guid("eac06870-6688-4254-bca8-fa7f08d81e32"), "02/28" },
                    { new Guid("06d49828-c543-4426-8645-34cf87884a80"), "639", "4871861339929728", null, null, new Guid("0615c4c1-b356-478a-abeb-caaccb8742b0"), "04/11" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("06d50e03-8b0c-45fb-adf8-a27541edc002"), "260", "2766709357513717", null, null, new Guid("56460594-4f75-42d8-9106-e7e3ec02c12c"), "10/17" },
                    { new Guid("06e507dc-51f9-4231-8fe8-a021dd07af3d"), "492", "7730467185875755", null, null, new Guid("cffc8c5c-aee1-43fa-a247-e83b10ecb56e"), "07/11" },
                    { new Guid("08623770-863d-42de-8d7c-f15519dcc205"), "637", "9973050611341224", null, null, new Guid("f2fc34d0-f967-4d49-ac54-2191c244d200"), "01/25" },
                    { new Guid("091e0b95-703d-44ac-a335-b17e81951720"), "479", "7605929407050604", null, null, new Guid("1e75d073-445f-4291-b366-fe0683c205a7"), "07/18" },
                    { new Guid("097bf5dd-69b9-490c-85e8-2360ed0d1c38"), "657", "8050969611764168", null, null, new Guid("c6c5dcc4-cc8e-4484-935f-918264ee4897"), "03/10" },
                    { new Guid("099c2d01-a1ad-4ff8-aa58-120d3d95e3e9"), "744", "4923813314375166", null, null, new Guid("af831e9b-a557-4f53-81e7-2278eb8802a1"), "08/13" },
                    { new Guid("09ef3978-9850-44c9-8c57-5de03c4808a1"), "598", "6743374233290284", null, null, new Guid("73cff5d2-f041-4e6e-8857-560606637e86"), "12/18" },
                    { new Guid("09f59f1d-e4ca-49d6-9535-db45527d9393"), "693", "1886935126989626", null, null, new Guid("34abae3b-f28c-4c59-a716-fea9a1b0e1bb"), "11/25" },
                    { new Guid("0a226764-f51b-4104-9cf8-046fdd3e9017"), "706", "9050374422562982", null, null, new Guid("f7ba49ab-b88c-4490-8dc0-4a731ec11ec3"), "01/14" },
                    { new Guid("0a7299d0-bb6e-468b-a393-713069620b7a"), "164", "5279277331125677", null, null, new Guid("bdd49191-641c-4843-a442-069a71c65be5"), "06/02" },
                    { new Guid("0abe7b30-42fb-4ec7-b2fd-5afad4000413"), "920", "7161165216155394", null, null, new Guid("6de94a05-0c03-4062-8ab9-57a5bd55b3a5"), "10/11" },
                    { new Guid("0b155153-87c1-4d6b-a4e1-a3319ca07fab"), "707", "8831621124193198", null, null, new Guid("cca9c534-e77c-400e-a849-210326576f8f"), "03/22" },
                    { new Guid("0b9eae99-f6d3-4fc7-af07-cea6b4e333d7"), "819", "8779517928945401", null, null, new Guid("f7f5e0b6-df15-4f10-b87e-6503c5e8fb8e"), "11/07" },
                    { new Guid("0bc22799-5774-4ccd-9a7d-94b20b4ce766"), "715", "3400403015867037", null, null, new Guid("af867e87-ddef-4efe-ba16-9ce831f47443"), "04/02" },
                    { new Guid("0c03424e-e7b7-4efc-bdd8-7904154dedf3"), "796", "2493093602782649", null, null, new Guid("89f14bfd-f2ad-40fc-8c24-b21398e3c7d3"), "04/18" },
                    { new Guid("0ca19db8-9274-4a46-a5cd-16a056ee28fb"), "667", "9130394954329574", null, null, new Guid("8c658576-57f3-41cc-9a3b-917efb1480d9"), "04/25" },
                    { new Guid("0d174904-962a-4520-b8f8-41322673a00a"), "255", "4016134127557291", null, null, new Guid("34c24f57-b16e-4b0f-abe2-5cb9c260e918"), "08/14" },
                    { new Guid("0d1d088a-ed73-40b7-83fb-db19114e8468"), "075", "4459867813151230", null, null, new Guid("ac4b1e96-68b1-4502-856c-10b88acf07fa"), "03/08" },
                    { new Guid("0d2731a9-02f6-4031-9b9e-c5840960fc69"), "330", "6744323142249657", null, null, new Guid("65dedea0-0687-4571-93d0-c6cdfefedb38"), "11/09" },
                    { new Guid("0d390bf0-d913-4535-87fc-d004b55003d2"), "921", "6232245366728673", null, null, new Guid("5af211a7-f736-4b52-b2bb-493388054061"), "03/20" },
                    { new Guid("0df8f86f-68ff-4abf-a1a4-66799be3a65e"), "743", "4960283542603009", null, null, new Guid("39fc9708-01f3-4ab0-8c26-d5bc00da55db"), "11/11" },
                    { new Guid("0e506832-2121-4279-a0fb-11cd18592b7e"), "792", "9683927993034015", null, null, new Guid("f57190db-67c4-4d7b-9cd1-c8e27a6ac561"), "04/01" },
                    { new Guid("0e99e7fa-2f44-4e58-88b2-3b2a2696dac1"), "079", "7845504974778197", null, null, new Guid("f498a63d-900c-464a-8fab-e4232968dc8b"), "06/05" },
                    { new Guid("0f0a79d5-9f4f-49ff-b68f-c4746db5d1c8"), "701", "4188760287091796", null, null, new Guid("f5193487-04f8-4c23-b0cd-90340ebc9154"), "09/19" },
                    { new Guid("0f41a2a5-7c80-48cb-97be-08be0afec5fd"), "764", "8357638774175400", null, null, new Guid("13164560-3eb6-4f4f-9c11-1f819fc48e22"), "12/08" },
                    { new Guid("0f4708f3-6d6b-450f-b688-ba33b994a23a"), "586", "3731962888444084", null, null, new Guid("ae39cf22-04cf-4eb4-8b28-b59be4789ea6"), "07/24" },
                    { new Guid("0fbc1b22-99f9-4af4-84fe-7f5a259e5bcd"), "853", "5493029751996790", null, null, new Guid("4595bfbb-3a7d-407e-b6e6-b5d06b0ded5d"), "03/10" },
                    { new Guid("10b29c1c-43c3-4f3d-9eab-c3552c58541d"), "967", "4581523049686296", null, null, new Guid("ab38dbfc-78a4-4d84-9e77-53448911bc9f"), "10/19" },
                    { new Guid("10f02998-6b5e-44f9-ad4b-60aed674251c"), "136", "6543845045006573", null, null, new Guid("e135b016-8e68-479f-a8e6-0c1dd16d5c2f"), "06/22" },
                    { new Guid("10f821e1-3b6e-4113-8cbc-7b2f227c1cd0"), "507", "4448406478960439", null, null, new Guid("b2085c8a-b530-4404-a522-eaa5962529ec"), "02/28" },
                    { new Guid("1191f767-aee5-4a83-9af6-9353986fecdd"), "184", "5621956697469883", null, null, new Guid("9e9403fb-605a-441d-a83a-f936fec7582f"), "01/24" },
                    { new Guid("11b93ae4-35ae-4f8a-b3d6-9d96d319df6a"), "869", "1762091136785931", null, null, new Guid("a907043f-86ba-4126-baac-6e2c6eb5871c"), "07/10" },
                    { new Guid("129e43bd-3819-407c-88f6-ccf8951251db"), "269", "5194923268220851", null, null, new Guid("4527938d-6c0c-424e-8f7a-6d20b4f7a9f0"), "04/27" },
                    { new Guid("13153d0b-c334-44ac-aee3-b6ea69b759ae"), "805", "3837323267914782", null, null, new Guid("af867e87-ddef-4efe-ba16-9ce831f47443"), "05/08" },
                    { new Guid("13196456-1492-49b3-80dc-0b2b71fc0ee2"), "408", "4767918101607029", null, null, new Guid("428063f6-fd3a-42bd-b0be-ba01a5e85a84"), "09/21" },
                    { new Guid("137b1107-0190-4c59-8f10-3ab003f8254a"), "818", "1187262687316058", null, null, new Guid("c1169f01-6528-4f74-aa56-802f48a7ece8"), "07/09" },
                    { new Guid("139e62fd-349f-4de1-8bac-50d78dea3a52"), "484", "8020719712316240", null, null, new Guid("cca9c534-e77c-400e-a849-210326576f8f"), "01/27" },
                    { new Guid("14bd5803-1320-488e-8f62-b0a2c996985c"), "751", "5160295561217756", null, null, new Guid("b7f7d261-2525-4477-8b55-bba019231e9f"), "09/05" },
                    { new Guid("14f1c5c4-a248-46c8-9683-1fb444f6c3dd"), "802", "3849602153956407", null, null, new Guid("9336f657-bf13-4455-becf-1afff818911b"), "09/03" },
                    { new Guid("150b00dd-625a-4378-87dc-d472e96de64c"), "305", "2620989075393723", null, null, new Guid("af67d494-10d3-4417-9f74-90816ee69f93"), "03/25" },
                    { new Guid("153c501f-8e3b-4952-92db-d40656c47def"), "383", "3468427206706435", null, null, new Guid("600649dd-c6d1-4ff3-9144-03f6ff7e6950"), "03/05" },
                    { new Guid("1555a3c9-0a50-4e21-bf2a-90cffdec79d2"), "679", "8289942125329620", null, null, new Guid("5881d0e1-89ce-4573-8217-2e4c8ee1688e"), "03/08" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("1585edf0-be48-466c-87dc-dafda264709b"), "513", "3574328918158732", null, null, new Guid("a4fd1dcd-4db0-4a8a-9303-ecaf58ed8a81"), "02/11" },
                    { new Guid("160037d7-5743-4fb3-95c8-909c05e5062b"), "232", "6511003999091934", null, null, new Guid("a907043f-86ba-4126-baac-6e2c6eb5871c"), "08/07" },
                    { new Guid("16a9e13e-2ee9-436e-b2c3-cdcc71e616aa"), "109", "6001669942765584", null, null, new Guid("1548ab99-88de-44e5-8fb2-0ecadca929aa"), "07/03" },
                    { new Guid("173b56a2-278a-49a2-88eb-52c38d250967"), "732", "9343366300580949", null, null, new Guid("58e47d27-16f3-4806-acf1-7b73ccbc0d5e"), "04/19" },
                    { new Guid("173c7d70-134d-407f-aade-877fca2e9519"), "784", "3876395972453615", null, null, new Guid("351d8ea5-1894-4ffb-9d93-a257287acb66"), "05/11" },
                    { new Guid("17a0a1e8-7ae3-421d-ae86-5e130843355e"), "957", "7509104780995249", null, null, new Guid("8fca9140-9c2e-4112-9850-cdf3b029b5ac"), "07/08" },
                    { new Guid("17b3cdc3-be1f-41b0-bb38-02e4d9476430"), "394", "7246228423039816", null, null, new Guid("4e8f092d-b1e1-47d3-9de6-5d9db26187a5"), "01/15" },
                    { new Guid("1806bf9d-0f86-4461-b658-c49af9ba2292"), "744", "9002861629304948", null, null, new Guid("20245acd-f749-41bb-8cfd-f436a4e71e96"), "03/15" },
                    { new Guid("18a9eea2-630a-4bcd-b25e-b534e5a823c3"), "854", "6797676558672268", null, null, new Guid("fa671618-4f8c-472d-aad1-18adb7778e70"), "10/15" },
                    { new Guid("1915ad82-28d1-4659-8603-7b8a19bb4bfb"), "963", "3180948173929704", null, null, new Guid("4a66fea0-71b8-4943-90c9-d349550e6fe9"), "03/04" },
                    { new Guid("19fca316-e1a4-403f-8205-281f3b927d01"), "842", "5999110332269793", null, null, new Guid("fa671618-4f8c-472d-aad1-18adb7778e70"), "04/27" },
                    { new Guid("1ac14471-778e-4255-8c39-df43977bbef9"), "028", "2516108608092913", null, null, new Guid("f3ea0004-e1e2-4557-a9d5-14a5369a2eb3"), "05/10" },
                    { new Guid("1af5d142-c339-4578-84d0-16abfaf0dc88"), "290", "2525215451348393", null, null, new Guid("4a1c10a8-7cf3-42b7-9d73-0683e4bc1868"), "08/21" },
                    { new Guid("1bfde723-4d05-4b5d-aa5e-c8d3de8b4532"), "392", "6245992401243594", null, null, new Guid("bb021ddc-2731-4d61-8069-ddee5e7759da"), "12/13" },
                    { new Guid("1cb97543-4ab1-48ee-880a-55ff5615a6bb"), "307", "7705689893287081", null, null, new Guid("07169b5c-40fd-40ba-b01e-8b56de466065"), "03/01" },
                    { new Guid("1e04e98f-606b-4f69-8742-0e2fff5062f8"), "579", "3427178288113705", null, null, new Guid("19d85480-882e-40f7-a536-84a552b3e447"), "12/25" },
                    { new Guid("1e0ce97d-a453-4d89-977e-f79ec003f80e"), "973", "8953755899658231", null, null, new Guid("af267ef9-b2cf-4adf-a9d0-a58e3acadfa6"), "03/23" },
                    { new Guid("1e3c2ff9-dc98-4c15-a36b-0b119896e4a3"), "892", "9866312593856721", null, null, new Guid("3b1108de-e27d-4674-b7ff-c1df3b68ae41"), "12/12" },
                    { new Guid("1e791a7f-d076-4fce-9629-e135c8161559"), "369", "8032205588486251", null, null, new Guid("bb486a22-0b19-4077-b9ae-8415f7b0c807"), "12/14" },
                    { new Guid("1ea2ebc3-04b7-497a-927f-1dba14f2bb92"), "168", "9630765002899466", null, null, new Guid("20245acd-f749-41bb-8cfd-f436a4e71e96"), "11/12" },
                    { new Guid("1ee1d8cd-e774-44d9-96d4-47fdaafede90"), "500", "9689931061754922", null, null, new Guid("29c7fc41-2565-497d-8900-56c2e6208fa6"), "12/02" },
                    { new Guid("1f8db0c3-de0b-4b18-9690-95eae213a843"), "392", "2989806745314964", null, null, new Guid("5398a079-6d82-4f82-8917-3f9eea9310eb"), "08/01" },
                    { new Guid("1fb72dd1-983d-4d5f-8a83-c634fbe0d689"), "227", "2856597260731942", null, null, new Guid("b7003b5f-1610-4487-9fd1-c03a6d0982d7"), "09/12" },
                    { new Guid("20465fb9-2ebd-482d-b778-375768742cd4"), "137", "7208479643766800", null, null, new Guid("19d85480-882e-40f7-a536-84a552b3e447"), "02/18" },
                    { new Guid("208880dc-b186-4078-b36d-af983e8d8d37"), "517", "2583616600557041", null, null, new Guid("922f53da-9877-4d56-a64d-6d83331bdbb6"), "08/28" },
                    { new Guid("20d09bc8-0892-41e7-92eb-206f3b7dafb8"), "321", "5105712768860124", null, null, new Guid("5c53533c-cf33-43f0-bdab-260275d90d88"), "03/06" },
                    { new Guid("20fe3796-e930-4f92-ba50-2d4c5f7e187b"), "359", "9667940683808191", null, null, new Guid("d52df32f-0260-40eb-8234-13ab7a744fcb"), "09/18" },
                    { new Guid("21194a89-69bc-412a-947c-5a87c7e2d881"), "322", "6357363186825185", null, null, new Guid("b89fe956-f020-4fc2-affd-e06c759e4081"), "05/03" },
                    { new Guid("219083e3-4fe4-4816-a741-1463099c2a10"), "851", "1985002576231319", null, null, new Guid("1530b862-24b5-484d-8939-50315a49bd13"), "10/14" },
                    { new Guid("21fb13e3-a41a-481e-9f28-78d26bb09123"), "938", "8346970080162324", null, null, new Guid("68bf203c-5d15-452a-b81b-bb7831c4f579"), "04/11" },
                    { new Guid("22418ec8-916a-4275-9b78-877e7df18ac0"), "364", "2336332076334437", null, null, new Guid("54f16999-7e05-407e-aab8-1c56cdb79653"), "12/23" },
                    { new Guid("22d1e0a2-0f28-47fb-9a1c-0b3eb5ee2d97"), "738", "3650300668523736", null, null, new Guid("bfb2c3f3-d581-43c3-ad34-2b9af77e293a"), "01/24" },
                    { new Guid("22da3604-ccbc-4aeb-b331-8977dea6118f"), "433", "8305002474668613", null, null, new Guid("09ff0b03-eca3-4596-9c5d-d809a2f99a1e"), "04/06" },
                    { new Guid("232348de-16e6-41fc-b0e7-67a73506c1c5"), "656", "2977546334949323", null, null, new Guid("1de915db-ea78-41e7-a3a2-76a8f6311629"), "12/13" },
                    { new Guid("23a63f5c-0782-4365-ba1c-2422f736fb49"), "071", "7605918468125001", null, null, new Guid("8887b8ab-eb5d-41ad-bac2-3126e85117d1"), "01/08" },
                    { new Guid("23abc1b2-b151-43c5-9dff-b534488e74af"), "554", "3313366773606545", null, null, new Guid("8c8ff9a2-2752-46a7-960e-0490c28de13f"), "02/12" },
                    { new Guid("23db62e0-fe90-4273-92de-e239f24f5b0a"), "539", "7103600483130323", null, null, new Guid("ab38dbfc-78a4-4d84-9e77-53448911bc9f"), "04/02" },
                    { new Guid("23f6114c-1539-45a5-8d8c-723931167305"), "181", "6003689322068322", null, null, new Guid("f8c6be38-3b48-44ea-9af5-7fd644c82034"), "09/20" },
                    { new Guid("243c454c-d9dd-47cd-914e-9973a0146671"), "686", "3490832710347812", null, null, new Guid("65cb2c49-f00f-450e-94e8-540312a9ce09"), "09/17" },
                    { new Guid("2441ead3-3ed4-4da2-8324-e9124c63c9b5"), "539", "6356010102511105", null, null, new Guid("9981eef1-0435-4903-9860-b16fb734ad1b"), "11/03" },
                    { new Guid("245ad740-e6ad-4d9c-9329-a64d37b75338"), "633", "5721454480354785", null, null, new Guid("5881d0e1-89ce-4573-8217-2e4c8ee1688e"), "12/01" },
                    { new Guid("245ec7ea-d91c-46e6-a179-96a7bea3373f"), "136", "5383765610906226", null, null, new Guid("f8c6be38-3b48-44ea-9af5-7fd644c82034"), "09/01" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("249c01af-3e42-4425-8941-48f806293f43"), "825", "5940421768597515", null, null, new Guid("a0d3cad9-30ac-4da2-8952-dcde6122a64a"), "11/24" },
                    { new Guid("24ccd297-051b-4ab6-8e33-d21ee29bc04c"), "278", "4649682797063874", null, null, new Guid("40c86360-842c-49f4-a03e-2506f27e244d"), "03/10" },
                    { new Guid("25219db9-dbb4-4701-8a23-69ee91e835c0"), "112", "8693604561410946", null, null, new Guid("17f01111-498c-4286-9021-ec1a09f4b1ca"), "07/18" },
                    { new Guid("25e962cf-68a9-4054-8806-dc28e469bd4c"), "902", "6422850896346907", null, null, new Guid("d02ec5f5-af87-4bcb-954a-b24e23737d68"), "12/20" },
                    { new Guid("262740d2-186a-4fa4-bb9b-2ef72907753e"), "633", "1243356421040016", null, null, new Guid("0c210681-d608-4ef0-acaa-f6ca1d403524"), "04/15" },
                    { new Guid("2671e10b-ab0b-40aa-9487-bdb3bf83f1e1"), "446", "6225155981156807", null, null, new Guid("ac4b1e96-68b1-4502-856c-10b88acf07fa"), "04/14" },
                    { new Guid("267c0e2d-9893-404f-aa11-7c500d87f7f9"), "569", "8049655662512844", null, null, new Guid("08e9beba-81d1-40e1-9f0f-4d282258b85b"), "02/18" },
                    { new Guid("26cc24ae-1a4a-42e5-93dd-206d8c1eb0f4"), "354", "4899337784176840", null, null, new Guid("7adbc5f0-6d2f-4d16-ad51-1b76edd52481"), "03/11" },
                    { new Guid("26d6ffff-5676-48d3-a9e8-bef1cc12f685"), "167", "2777716156766625", null, null, new Guid("b2085c8a-b530-4404-a522-eaa5962529ec"), "03/21" },
                    { new Guid("26d85f07-dc30-4dc9-bc89-9dacd8b81255"), "565", "7839685665696953", null, null, new Guid("c2edd12d-5919-4c5c-b18f-3b1ef2ea8f55"), "04/15" },
                    { new Guid("2702194b-556d-460e-8e45-57f50e24d2b4"), "625", "2877993069247723", null, null, new Guid("09ee89cc-9f4d-4eae-a4f3-731ca2d52102"), "03/17" },
                    { new Guid("2759b787-75b6-4a0a-95ec-3c30733ece7b"), "391", "7172241601001797", null, null, new Guid("22a1446b-6ffd-488e-8e70-011276aa0ae3"), "09/09" },
                    { new Guid("288f1580-6835-4c2a-b1d5-7c5a1e9ea2cd"), "891", "6136258033292996", null, null, new Guid("0fedadae-5c91-4999-9924-42f5fcd0de5b"), "01/12" },
                    { new Guid("28b9f91d-7adf-4a46-b965-ab32a2ecfebf"), "012", "5416163013414186", null, null, new Guid("dda60091-f993-4d23-997a-ac4774d856d5"), "12/07" },
                    { new Guid("290493ef-963f-4f5d-8bd7-1ee6c771b764"), "609", "4804294146795351", null, null, new Guid("f57190db-67c4-4d7b-9cd1-c8e27a6ac561"), "10/09" },
                    { new Guid("291bf8c0-fe9a-4fbe-930c-fc532b8aaeed"), "932", "6565602470850297", null, null, new Guid("5881d0e1-89ce-4573-8217-2e4c8ee1688e"), "08/13" },
                    { new Guid("2934a955-13f1-455a-9ffa-008a10fe7bb6"), "200", "9289913058832290", null, null, new Guid("1070c404-0d57-4ba4-828e-4ca0d5ec2262"), "04/27" },
                    { new Guid("29358fab-2d0f-4001-a580-504d6bcd79bf"), "888", "8249443346195193", null, null, new Guid("b89fe956-f020-4fc2-affd-e06c759e4081"), "02/18" },
                    { new Guid("2939ddb0-8ede-4b5b-813c-c6e49afb1e0e"), "624", "6645974245482796", null, null, new Guid("a6098ed7-dc3b-4d11-bcda-a3ba0c8ac2f4"), "05/17" },
                    { new Guid("2956a3de-a34d-40fd-a116-0a7c07f7c34c"), "005", "2604110178033540", null, null, new Guid("f52649ec-b9d7-4f35-8295-ec4e2b5c564c"), "10/17" },
                    { new Guid("29a71937-b4ba-4509-97dc-1233c4185a0d"), "738", "3100526319544204", null, null, new Guid("b7f7d261-2525-4477-8b55-bba019231e9f"), "05/15" },
                    { new Guid("29abd077-3cbb-4b87-ab7e-41765164f0e2"), "533", "4080992141437187", null, null, new Guid("0c162bb7-00a6-40b1-b35d-bbd2862f363c"), "10/24" },
                    { new Guid("29ddf8d9-85ce-4df1-8230-bbbf9dfe7450"), "521", "6130330482330775", null, null, new Guid("7271d193-6a4b-40d9-ab91-a7d8a07e45bb"), "06/23" },
                    { new Guid("2a38261c-26b6-4ebb-83be-5de2f83a217c"), "826", "3257187593554516", null, null, new Guid("49e9f216-cefc-4a4e-a243-81e78152afb7"), "05/24" },
                    { new Guid("2a4255a6-10f3-47b4-8e7f-491d125dc17d"), "917", "5491905567425478", null, null, new Guid("7b9aa90c-3f91-430e-bbb3-c445e0de9d01"), "10/16" },
                    { new Guid("2a53ae7b-977f-4827-8d8b-f6c34c8c8379"), "798", "1204150376510201", null, null, new Guid("9336f657-bf13-4455-becf-1afff818911b"), "07/15" },
                    { new Guid("2b57a2fd-4b7b-404a-b5b2-79064f470b1b"), "505", "2422897526093705", null, null, new Guid("4a66fea0-71b8-4943-90c9-d349550e6fe9"), "09/15" },
                    { new Guid("2b61f393-00ed-4728-82d6-e6e0d9f54f54"), "008", "3376929400258223", null, null, new Guid("11b76a5d-870e-46d3-b3e3-0af0f8f871ac"), "07/14" },
                    { new Guid("2bb3d424-9c34-4485-90d8-83e7d2fd479d"), "090", "1013369615771577", null, null, new Guid("d62fe5e3-4821-411a-b458-87e89f41f2f1"), "02/06" },
                    { new Guid("2bba54b7-add7-4999-bb7f-86928ea11684"), "174", "2136745392962763", null, null, new Guid("9f2db745-dcf4-4a49-a27a-ae15a2f3087e"), "02/20" },
                    { new Guid("2be2a68f-455b-4ca2-82c0-300897e03c7f"), "948", "9706094524749794", null, null, new Guid("bdc35340-f998-4d2c-9ebc-c29624582c95"), "11/22" },
                    { new Guid("2c04071b-32f3-41f9-930c-c9dd373dbe58"), "664", "7103616565159265", null, null, new Guid("af867e87-ddef-4efe-ba16-9ce831f47443"), "07/18" },
                    { new Guid("2c077a13-4bae-4df7-8a0b-209e825bd029"), "135", "5263727436369443", null, null, new Guid("7247fafb-5d1e-43fe-a447-5b99c26b77ba"), "05/26" },
                    { new Guid("2cb105f3-548b-4db3-b97c-334801ebebe3"), "673", "5795683632190863", null, null, new Guid("c075bfdf-a5cc-4efb-a6d1-f31b0c4bf344"), "09/23" },
                    { new Guid("2cd8c6ba-03c2-40a7-b9f2-07bc7821b012"), "300", "1300908502861352", null, null, new Guid("68bf203c-5d15-452a-b81b-bb7831c4f579"), "11/06" },
                    { new Guid("2d012f28-d9ab-4400-b91d-5c48b80bb863"), "916", "3032932102102354", null, null, new Guid("1070c404-0d57-4ba4-828e-4ca0d5ec2262"), "01/22" },
                    { new Guid("2d1f03a1-46c6-413e-a4a4-8e0f3dcb52c2"), "348", "8564990834683262", null, null, new Guid("5881d0e1-89ce-4573-8217-2e4c8ee1688e"), "05/04" },
                    { new Guid("2d2d755e-e90e-4293-af6e-099ef28e5c18"), "013", "5712976626719166", null, null, new Guid("7975589e-fce3-4ff6-8b4d-4f29aa2e3c37"), "09/26" },
                    { new Guid("2d6cf944-6f0a-4e02-b201-37ef116ba882"), "102", "9702806149024595", null, null, new Guid("09fe5fb4-f36b-4a46-81a1-c617e335393a"), "07/22" },
                    { new Guid("2e804a02-a8fa-45f0-9f7c-e09c4a106c6b"), "017", "6354095965911436", null, null, new Guid("5322c711-eaf5-4b14-8d69-cc6bf8809924"), "10/11" },
                    { new Guid("2eaca18a-b6db-4ad9-aa0b-ef9b9195b2c3"), "966", "5719259382434343", null, null, new Guid("08fd0c31-2e97-4cfb-bbf0-9eca4d7bbf0c"), "12/21" },
                    { new Guid("2f3ff120-1135-4501-92b3-4adf50eb867a"), "333", "9879028749282745", null, null, new Guid("f2fc34d0-f967-4d49-ac54-2191c244d200"), "01/26" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("2f952555-e480-4373-9614-9ca3273ef603"), "578", "2135376339263038", null, null, new Guid("0fedadae-5c91-4999-9924-42f5fcd0de5b"), "11/14" },
                    { new Guid("2fe77d7e-c4da-4ce7-bc0a-9396a7b74a35"), "175", "5290279226158673", null, null, new Guid("5dd3e047-c6f3-412d-b5cb-12b416f99706"), "12/24" },
                    { new Guid("2ffff119-9ad6-4bf8-8604-0123eaf55553"), "978", "9634488422134124", null, null, new Guid("65cb2c49-f00f-450e-94e8-540312a9ce09"), "10/01" },
                    { new Guid("306da987-81dd-4859-8f47-996857b4728b"), "310", "4128985940763205", null, null, new Guid("3dc0198e-db0e-4b52-919e-c407fa4dc4a6"), "05/28" },
                    { new Guid("31913928-aed5-43ee-aa4f-6f32a8b1b4da"), "791", "5913069591641926", null, null, new Guid("9102f36c-0db2-4a0e-b22a-bcaffabfb757"), "02/23" },
                    { new Guid("32564378-ebcd-4402-aa9b-3b5c42a5a7e3"), "636", "7079674865760205", null, null, new Guid("25a38376-e74c-46cc-8d4f-292cebbcdffb"), "12/16" },
                    { new Guid("32de4689-5b7f-4790-8460-28b276b4dae7"), "769", "9795880682204360", null, null, new Guid("09ee89cc-9f4d-4eae-a4f3-731ca2d52102"), "04/12" },
                    { new Guid("334a2f91-1022-4cac-994b-d9aff19736fb"), "107", "7563980885925740", null, null, new Guid("732ba531-5faf-4b4a-bcac-24d9ca3fcbc2"), "02/22" },
                    { new Guid("33768ff6-e9b5-4429-bce1-16db13ca0bae"), "102", "4670670205079653", null, null, new Guid("39fc9708-01f3-4ab0-8c26-d5bc00da55db"), "07/14" },
                    { new Guid("33c108b3-7b34-445e-be74-fedcec0985a3"), "596", "7409877268681094", null, null, new Guid("a339ea33-3188-40c2-9d84-9ea46aa67e82"), "08/14" },
                    { new Guid("33dd0398-c3c9-4b54-8b55-be5bce165aa9"), "911", "9076823514362239", null, null, new Guid("ab522845-c1bd-4f82-bee3-06f49429e4bf"), "10/21" },
                    { new Guid("344fd675-eeca-46c1-899e-7b940dd594e8"), "003", "8230057727552151", null, null, new Guid("49e9f216-cefc-4a4e-a243-81e78152afb7"), "02/21" },
                    { new Guid("34583f01-2abe-48f7-9f0a-bf801596d7dd"), "597", "7978140378265182", null, null, new Guid("c4ec53d7-69be-4d5d-9091-29c7f80bd641"), "08/12" },
                    { new Guid("3540fb9e-6da4-405f-b518-4ada77df1161"), "142", "4251055695203289", null, null, new Guid("85626191-e7df-461f-8d6e-58391f67d36a"), "02/20" },
                    { new Guid("35632fae-ef8d-411a-9a03-e931bc4733ae"), "565", "5964964624620445", null, null, new Guid("7324afd3-dc67-4f31-ab23-e7b052d0c6e2"), "02/28" },
                    { new Guid("36971b2a-6ff2-43c6-af82-d027542901ac"), "942", "3285680567719197", null, null, new Guid("0763ce92-5a2c-4138-ad42-41c5b45988dd"), "03/16" },
                    { new Guid("371e0924-0747-46bd-956c-5e8f8f3f097f"), "594", "5717770366122684", null, null, new Guid("60c86293-9017-4722-ad96-c09fd6051a5b"), "12/18" },
                    { new Guid("3757c1c0-0e2a-4537-9c17-0af178410b43"), "543", "9335399938250914", null, null, new Guid("f4909d03-d7ac-4aaf-a6fe-77a88f9fe06b"), "12/02" },
                    { new Guid("3851b53e-aa2c-407a-b236-7c7924659aba"), "225", "8746057636295700", null, null, new Guid("3359f4d4-fbc1-4174-b3e0-8cc3754ac07b"), "11/11" },
                    { new Guid("38704d98-4604-457c-9f16-65d3a14af796"), "089", "4775345999401547", null, null, new Guid("500d7059-5719-42c4-a15e-d4753ba03714"), "12/08" },
                    { new Guid("38969be3-296f-4da0-9d7a-1f83e3b55865"), "927", "3622872658680022", null, null, new Guid("7247fafb-5d1e-43fe-a447-5b99c26b77ba"), "05/05" },
                    { new Guid("38dba613-8812-443f-84e3-ea65dd3fee4a"), "580", "4727270633564271", null, null, new Guid("2c5320bb-6c0a-46cc-9731-a7b34514e4c1"), "01/11" },
                    { new Guid("390bd88f-85a4-4110-b75d-6f0f8ac69920"), "397", "4459359030990358", null, null, new Guid("8d7de522-82d8-4912-bf1a-5d80658097e7"), "12/06" },
                    { new Guid("391df7eb-db14-4a3a-b74c-649bd02b268f"), "579", "6781275985863553", null, null, new Guid("980f1926-46d3-48d9-880c-73d0be9fa1e0"), "01/07" },
                    { new Guid("392bcc95-2aea-44a8-8c17-620682d47f34"), "373", "5990756887598576", null, null, new Guid("a66e6d00-7000-4eb2-994b-a38594503957"), "11/25" },
                    { new Guid("39729b30-9f32-41ea-a025-6afddede76a0"), "259", "7393597426983537", null, null, new Guid("40de2c6f-e29d-4027-93c3-945e76ec015c"), "03/01" },
                    { new Guid("399936eb-cf95-4896-9a4c-0e07a129621b"), "318", "9000406296350521", null, null, new Guid("20245acd-f749-41bb-8cfd-f436a4e71e96"), "08/05" },
                    { new Guid("39ec3397-06aa-46a0-9f8a-b0397dcacbdf"), "159", "4953685162348587", null, null, new Guid("f7e08701-d57e-42d3-884d-beb04dee4c45"), "10/20" },
                    { new Guid("3a223ca8-0522-41b5-a95c-271ccceea3a0"), "923", "4580090442901125", null, null, new Guid("351d8ea5-1894-4ffb-9d93-a257287acb66"), "02/06" },
                    { new Guid("3a5395ae-f758-47dc-b674-389d73b0a26a"), "492", "2118899547122263", null, null, new Guid("74059a15-c214-4079-bc91-f8aa180574a7"), "06/14" },
                    { new Guid("3a8d9656-5b1e-4e03-b6cc-d032488cf089"), "388", "3486699418668071", null, null, new Guid("08e9beba-81d1-40e1-9f0f-4d282258b85b"), "11/25" },
                    { new Guid("3ab0267e-78b5-4379-b899-d1a333decd44"), "669", "3854391190291434", null, null, new Guid("712b2e8f-feec-4b44-842e-63c59bbe48cb"), "05/10" },
                    { new Guid("3adf781e-e50a-4cac-967a-b25674009a4c"), "228", "6815124876744729", null, null, new Guid("56460594-4f75-42d8-9106-e7e3ec02c12c"), "11/01" },
                    { new Guid("3b3c271d-78f0-42bb-9741-0675230c5836"), "298", "9696736733979529", null, null, new Guid("5d61541c-3ac1-459c-b0d4-0bbe121306da"), "10/15" },
                    { new Guid("3b668879-a0d7-4c48-b4d1-d31e8f2834b8"), "865", "4863506024116537", null, null, new Guid("3359f4d4-fbc1-4174-b3e0-8cc3754ac07b"), "03/05" },
                    { new Guid("3bc4e3cf-d8bf-4c26-b117-8747cc88645e"), "493", "6879523691244886", null, null, new Guid("4b70366e-a511-4254-8c8d-ad820ee7b210"), "12/26" },
                    { new Guid("3cbcf211-6323-4cc9-b816-a09e05eae9fc"), "251", "2287156401460429", null, null, new Guid("5dd3e047-c6f3-412d-b5cb-12b416f99706"), "09/18" },
                    { new Guid("3cdfc50e-698d-4624-8249-a33f6174ee2a"), "583", "2701582660526251", null, null, new Guid("c4b80142-93ac-41b3-b29d-ff4cad905327"), "06/08" },
                    { new Guid("3d1be77c-44b9-405d-91f7-5ee78e2f95e2"), "622", "2914527895917079", null, null, new Guid("628d01f9-5feb-4e85-a1ac-d03470903a20"), "09/07" },
                    { new Guid("3d7b5b83-5ac7-4f5b-ac80-53eb648dd26e"), "444", "5471354899365747", null, null, new Guid("23dc6e61-4215-4b56-b081-13cd0b456e6f"), "11/24" },
                    { new Guid("3dbb1dab-5120-472f-a817-ddf50e69e70d"), "673", "3375848656674528", null, null, new Guid("651f4e42-b7be-4042-92c4-872c1b4a2b36"), "03/20" },
                    { new Guid("3dec48ea-d115-4854-be80-9d439f4044f7"), "638", "1787629028593216", null, null, new Guid("a3bc456f-939a-42c3-99ed-719e0db5bf18"), "02/14" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("3e567f10-a45a-46a3-af6a-b56760a54ff6"), "651", "8524186091095458", null, null, new Guid("c0159440-683d-4c76-a904-aa1f4564822f"), "12/08" },
                    { new Guid("3e8f6d93-68fb-4a07-bc3e-5ad83aebc679"), "681", "5175044564572778", null, null, new Guid("e135b016-8e68-479f-a8e6-0c1dd16d5c2f"), "11/18" },
                    { new Guid("3eb7e7ac-db93-49dd-b68f-c3056b397634"), "208", "1938074397402494", null, null, new Guid("3359f4d4-fbc1-4174-b3e0-8cc3754ac07b"), "04/12" },
                    { new Guid("3ebe9f32-fb47-4b9d-bfd6-17ed056d6b62"), "160", "7235352360883768", null, null, new Guid("5146be01-925a-447f-b871-b7de98b487df"), "07/20" },
                    { new Guid("3eeae899-ff65-47fc-84f3-03919626e395"), "171", "4748117188386776", null, null, new Guid("ac4b1e96-68b1-4502-856c-10b88acf07fa"), "05/11" },
                    { new Guid("3eee843f-dc14-4ddc-aaa8-a4810da26d20"), "606", "5945965033945751", null, null, new Guid("f088f668-331b-405e-b41a-5cc648df081c"), "02/12" },
                    { new Guid("3ef11464-8bb5-424c-8bea-9133cc39ed0a"), "809", "4210392072463751", null, null, new Guid("d02ec5f5-af87-4bcb-954a-b24e23737d68"), "01/22" },
                    { new Guid("3f1c649a-0485-4af4-a696-7d1164f5a537"), "490", "5073417801714758", null, null, new Guid("89739d78-901e-4353-8c13-fe879541f76f"), "03/03" },
                    { new Guid("3f69a645-82eb-4299-9196-86122b208437"), "728", "3411810425235894", null, null, new Guid("db9ac887-f173-4f7b-ad02-6d19fdd7b12e"), "04/03" },
                    { new Guid("3fb98b48-4812-473d-a2b5-3a4f75c9a7b0"), "462", "5672470966683495", null, null, new Guid("0763ce92-5a2c-4138-ad42-41c5b45988dd"), "08/06" },
                    { new Guid("3fbe5c20-fecf-4496-9374-ea3b3ff349b9"), "209", "3592703235206636", null, null, new Guid("e0518a7c-2290-4dde-8de0-19fe26c3d8fa"), "06/13" },
                    { new Guid("40dd61dc-3894-4e4a-9eeb-2abbe5dbc837"), "412", "2023825495222266", null, null, new Guid("bfb2c3f3-d581-43c3-ad34-2b9af77e293a"), "09/11" },
                    { new Guid("416b5b13-7a3a-42ec-928b-9e41c4c00dd6"), "456", "8156920946755512", null, null, new Guid("611b8b1f-53d5-4660-9ad4-e0b57e915bf8"), "01/13" },
                    { new Guid("42671e17-5e66-4c7f-aa6c-79b90b916057"), "587", "5129502548909476", null, null, new Guid("17f01111-498c-4286-9021-ec1a09f4b1ca"), "05/04" },
                    { new Guid("426eafc0-c286-4405-8c2e-c0ca80b0f7e6"), "481", "1676984903981636", null, null, new Guid("09fe5fb4-f36b-4a46-81a1-c617e335393a"), "12/08" },
                    { new Guid("429b71ec-c0db-4012-8cfe-0b4a683dd3cf"), "122", "4635856383837833", null, null, new Guid("011fba87-398c-42ec-9aa7-ffb9c48fe9a9"), "03/04" },
                    { new Guid("4309586e-8b5c-4284-b631-75a50705bb3a"), "829", "6166977451701463", null, null, new Guid("bb486a22-0b19-4077-b9ae-8415f7b0c807"), "01/21" },
                    { new Guid("436af93e-1b02-4afc-b1ec-233ada47d4f8"), "503", "8420769489845670", null, null, new Guid("7e04a2e8-5af7-4c5e-8b81-d51fb8eb210b"), "07/23" },
                    { new Guid("4378e9d8-99f5-497c-bf8e-92935c132ef3"), "678", "2449059891178871", null, null, new Guid("6ceec469-cfb3-42b5-b289-a4c2da0a32dc"), "07/25" },
                    { new Guid("43b2d609-beb0-4cc8-b5a5-b0b49ff53d6d"), "473", "4683132408145616", null, null, new Guid("9102f36c-0db2-4a0e-b22a-bcaffabfb757"), "02/28" },
                    { new Guid("43c5a9a9-843e-4409-805e-7d54fc9e237d"), "828", "7218365550881113", null, null, new Guid("b7003b5f-1610-4487-9fd1-c03a6d0982d7"), "07/03" },
                    { new Guid("44112368-de86-4f52-a961-999afb3a05ed"), "765", "5903883066118317", null, null, new Guid("cc019092-2135-4dea-b991-c8b67614f148"), "09/10" },
                    { new Guid("446bc2ff-f90f-4a1d-ba05-6a5d0d8233e4"), "047", "2163886304860070", null, null, new Guid("732ba531-5faf-4b4a-bcac-24d9ca3fcbc2"), "03/18" },
                    { new Guid("44b49374-c493-4ad8-8621-3a9145a8ab26"), "501", "4594992539567271", null, null, new Guid("ae39cf22-04cf-4eb4-8b28-b59be4789ea6"), "09/20" },
                    { new Guid("44cbbc7f-ee0e-48ca-acd9-f21eba810b61"), "544", "1209513600334172", null, null, new Guid("479adb19-03b9-482c-b165-7766492bfdf2"), "01/16" },
                    { new Guid("457d1906-b618-482a-b637-070725c06d47"), "565", "3141332503534893", null, null, new Guid("6de94a05-0c03-4062-8ab9-57a5bd55b3a5"), "07/16" },
                    { new Guid("45ae8cb7-bfad-43f0-91ca-2c3f6ef9b63a"), "239", "9397016109139030", null, null, new Guid("428063f6-fd3a-42bd-b0be-ba01a5e85a84"), "03/13" },
                    { new Guid("45b3e354-5df2-46e8-8b09-1c04212622e8"), "916", "7653196902924479", null, null, new Guid("29c7fc41-2565-497d-8900-56c2e6208fa6"), "11/02" },
                    { new Guid("45ef1705-6b21-4461-ab99-fad6d8083a2d"), "276", "9343500084113977", null, null, new Guid("70fe5fa7-69ef-4577-a750-34ca205c0dac"), "02/03" },
                    { new Guid("4644885d-77d0-45f0-86b0-7f91a1b51e22"), "870", "2545088013422669", null, null, new Guid("dca6b19f-e9ff-4d07-b3df-fe7e57f8b960"), "04/03" },
                    { new Guid("464dbe6e-0f66-47d6-bca1-8a4997b5f73c"), "742", "3547420524884681", null, null, new Guid("a1e9eb46-748f-4b86-8554-7ae48675b2da"), "11/28" },
                    { new Guid("46a07fdb-1e6e-4f22-831c-085f2c33fb49"), "070", "5455445927140016", null, null, new Guid("6ceec469-cfb3-42b5-b289-a4c2da0a32dc"), "08/08" },
                    { new Guid("46ba7cd4-5a76-497d-b605-746644903314"), "931", "5947726483669583", null, null, new Guid("c075bfdf-a5cc-4efb-a6d1-f31b0c4bf344"), "10/15" },
                    { new Guid("478dd4ab-06f7-49cc-8dde-32f01dc9356c"), "719", "7073488115461964", null, null, new Guid("3dc0198e-db0e-4b52-919e-c407fa4dc4a6"), "07/01" },
                    { new Guid("478e2e3b-a60c-4662-bee4-dbc1336e6368"), "272", "7952292676888293", null, null, new Guid("22a1446b-6ffd-488e-8e70-011276aa0ae3"), "04/13" },
                    { new Guid("479e553b-1a55-4527-9df7-fdbce212f75d"), "911", "9152787498241458", null, null, new Guid("59e5a95d-f3ce-47fe-a7c9-70a6b47faac1"), "07/04" },
                    { new Guid("47c86e94-bfd8-4716-b42f-4f421f05b3ae"), "707", "3172705860288448", null, null, new Guid("8180db6e-0139-48fa-a7bc-8424ac74378c"), "11/01" },
                    { new Guid("484804b1-39f8-40a9-855b-1807d15667df"), "919", "8284325127489477", null, null, new Guid("39fc9708-01f3-4ab0-8c26-d5bc00da55db"), "06/26" },
                    { new Guid("484b724f-4815-4631-b5f3-5ea434cb1c62"), "247", "8289731720503453", null, null, new Guid("624d07fb-c364-4191-b439-aff73116c1d2"), "08/12" },
                    { new Guid("48dc21e1-2297-407b-a0fe-610b8449427f"), "301", "1629834692520400", null, null, new Guid("89739d78-901e-4353-8c13-fe879541f76f"), "09/07" },
                    { new Guid("4962769a-36b9-4a28-a033-bae42de9c34f"), "918", "4953007728368813", null, null, new Guid("5146be01-925a-447f-b871-b7de98b487df"), "07/15" },
                    { new Guid("49b15816-d398-4745-9acf-8db16d5ea91c"), "095", "1202907196476959", null, null, new Guid("af831e9b-a557-4f53-81e7-2278eb8802a1"), "07/12" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("49da5222-910f-43fa-af5f-506ae59a5824"), "725", "4319611695517827", null, null, new Guid("922f53da-9877-4d56-a64d-6d83331bdbb6"), "01/20" },
                    { new Guid("4afacafd-5572-4b92-ad4b-9709523064c6"), "249", "8984536521987011", null, null, new Guid("92fa424c-9623-4989-b9fe-494533664c26"), "03/05" },
                    { new Guid("4b81598b-4b78-42c7-ab41-f9c375af7ab4"), "283", "9124367480328413", null, null, new Guid("af867e87-ddef-4efe-ba16-9ce831f47443"), "11/06" },
                    { new Guid("4baaf20a-346b-44f1-8ea5-916955573dd6"), "460", "9981049766540667", null, null, new Guid("5322c711-eaf5-4b14-8d69-cc6bf8809924"), "08/04" },
                    { new Guid("4c0b76ca-b703-4e97-b770-4d041fee7de5"), "668", "2364817473176775", null, null, new Guid("c6d62b30-8c4e-444d-a56a-cf5bea9f9c2a"), "09/07" },
                    { new Guid("4cbcc178-76c1-4d0e-b960-f55a8ba2ddb1"), "522", "5233180642901340", null, null, new Guid("f2fc34d0-f967-4d49-ac54-2191c244d200"), "07/01" },
                    { new Guid("4cc0cbc5-e5f1-4991-a7c3-cfd88aa07e53"), "466", "7032554757148245", null, null, new Guid("40de2c6f-e29d-4027-93c3-945e76ec015c"), "12/03" },
                    { new Guid("4cedc29d-9b56-481e-945f-9d3b9294e0f3"), "286", "6962784294445597", null, null, new Guid("57c213e6-163e-4134-8633-29615daff79d"), "02/24" },
                    { new Guid("4d2fca4c-be20-464e-b5a9-7acebf7cda65"), "505", "2139602978509626", null, null, new Guid("41e507fd-f435-49b8-a35c-9fba98848542"), "06/04" },
                    { new Guid("4d32ba25-d09f-45d4-ad2d-1fe6c0d1130d"), "218", "8385919370120562", null, null, new Guid("d50ea512-4841-4fdb-b6f1-1805a1f266cc"), "07/14" },
                    { new Guid("4d673d14-2f7c-405f-865b-1254bf49094e"), "226", "1609742920139469", null, null, new Guid("36afa758-a0b9-4345-9bce-db873a3c22fd"), "06/03" },
                    { new Guid("4e2ef3aa-b024-42fe-9c36-5c72f479d725"), "787", "9824854502175323", null, null, new Guid("bdd49191-641c-4843-a442-069a71c65be5"), "01/12" },
                    { new Guid("4eeac79d-6556-4066-b2ea-1e3a9d258bd7"), "598", "9479723119647970", null, null, new Guid("23dc6e61-4215-4b56-b081-13cd0b456e6f"), "12/25" },
                    { new Guid("4f1f21c3-eedb-4a21-bae8-97558c696bc9"), "530", "4264665297163361", null, null, new Guid("732ba531-5faf-4b4a-bcac-24d9ca3fcbc2"), "10/13" },
                    { new Guid("4f51768c-022c-4128-8cef-7e9e3899a04d"), "425", "4973336947896449", null, null, new Guid("2275ad3d-6816-4c2b-ba9c-96a3dc4f45fb"), "10/07" },
                    { new Guid("4fb14fc1-4c06-4925-87f2-e1352e44a3f0"), "865", "1316233106573927", null, null, new Guid("7324afd3-dc67-4f31-ab23-e7b052d0c6e2"), "06/13" },
                    { new Guid("50420ff7-e069-4dd3-9130-b36622182e24"), "435", "1247491266652653", null, null, new Guid("b7f7d261-2525-4477-8b55-bba019231e9f"), "07/09" },
                    { new Guid("50514e06-978e-4253-87b6-268e3a4ac033"), "782", "3632596671541119", null, null, new Guid("54f16999-7e05-407e-aab8-1c56cdb79653"), "09/02" },
                    { new Guid("50eff3ed-7030-40f8-a524-fdb4f22d126f"), "692", "2240356125992389", null, null, new Guid("ae3132fe-b0e9-44a8-a734-658de87cc9a5"), "06/20" },
                    { new Guid("513446d3-c9a9-4666-ba37-9b39197a377a"), "135", "5024050461249255", null, null, new Guid("8fca9140-9c2e-4112-9850-cdf3b029b5ac"), "06/03" },
                    { new Guid("526aca1f-aa6e-4a70-b9c4-2109d548240e"), "744", "5250952535981201", null, null, new Guid("c9b88753-217a-4bb2-ac30-4bed75d66c61"), "11/06" },
                    { new Guid("5275a397-35aa-4af8-920d-78649987295f"), "014", "7163736736890185", null, null, new Guid("1548ab99-88de-44e5-8fb2-0ecadca929aa"), "12/21" },
                    { new Guid("52790152-b4c7-42b3-bc12-2bb21f2d2273"), "898", "4243260597957678", null, null, new Guid("2956754d-e1ca-4623-bbe4-691ff14c9d29"), "03/24" },
                    { new Guid("531e0d8e-bf7a-4b65-a74b-f2d2d4b1d51f"), "144", "3518789175861604", null, null, new Guid("40de2c6f-e29d-4027-93c3-945e76ec015c"), "03/16" },
                    { new Guid("533d540c-7e1b-498c-ba67-62ecae7a662d"), "622", "9057320749134242", null, null, new Guid("ea94f56c-ef76-423b-81af-2da80b37dfa6"), "04/27" },
                    { new Guid("533ddef1-0c3e-414d-91b5-4e680952eee2"), "204", "2352789206602416", null, null, new Guid("eac06870-6688-4254-bca8-fa7f08d81e32"), "08/26" },
                    { new Guid("54017494-e482-400c-9381-78309b348f92"), "909", "1918453612117669", null, null, new Guid("a72d6b0a-25a6-4c67-ac93-cc46cae2d9dd"), "01/28" },
                    { new Guid("540b169b-f19d-4a3b-9df7-087348d6d42a"), "134", "3318749381117178", null, null, new Guid("1e75d073-445f-4291-b366-fe0683c205a7"), "11/08" },
                    { new Guid("543d3709-c962-49ec-bae8-54b62dd36b78"), "472", "1939879269266273", null, null, new Guid("a4fd1dcd-4db0-4a8a-9303-ecaf58ed8a81"), "08/02" },
                    { new Guid("546164ec-9aab-4c19-a0fb-53f101a4f657"), "467", "7890236558940027", null, null, new Guid("5dd3e047-c6f3-412d-b5cb-12b416f99706"), "02/27" },
                    { new Guid("54aee3bf-0b90-4f43-9c68-77ff5bf472dd"), "312", "4601779413131838", null, null, new Guid("5398a079-6d82-4f82-8917-3f9eea9310eb"), "05/26" },
                    { new Guid("54b466c5-c08f-49a9-8c5c-6a448238bd64"), "164", "1346632279510191", null, null, new Guid("d52df32f-0260-40eb-8234-13ab7a744fcb"), "06/16" },
                    { new Guid("54cf4a9a-925d-42fa-9e53-09e1847fe733"), "561", "9037924189255798", null, null, new Guid("d50ea512-4841-4fdb-b6f1-1805a1f266cc"), "09/04" },
                    { new Guid("54d1aaf7-857c-4d11-bb1a-31f499424f40"), "950", "6069220700273491", null, null, new Guid("b2085c8a-b530-4404-a522-eaa5962529ec"), "07/04" },
                    { new Guid("557135eb-7fc5-4e7e-b903-d11f8905acff"), "765", "8199578366990627", null, null, new Guid("6d64cb25-3e39-4da8-a0e1-a3ee13dd1071"), "08/24" },
                    { new Guid("557547e9-72e1-4c6e-94c8-741d240a68d4"), "917", "6780227617404435", null, null, new Guid("bdc35340-f998-4d2c-9ebc-c29624582c95"), "04/25" },
                    { new Guid("55988f41-1f53-4fac-b562-25de514659f3"), "303", "5446150620225936", null, null, new Guid("089446be-2352-4d8f-9726-ba2c324e1aee"), "07/25" },
                    { new Guid("55b4dc33-4245-446e-af53-05dd384f990e"), "592", "8848372721715031", null, null, new Guid("d173c22f-aa53-4e3b-b137-bcd6d2faf814"), "06/21" },
                    { new Guid("55f408b7-af1b-4d01-9b98-846e370c1d3c"), "293", "7482463787883026", null, null, new Guid("af67d494-10d3-4417-9f74-90816ee69f93"), "06/28" },
                    { new Guid("5617de36-978a-4709-b182-b438d7262cdf"), "735", "1157376268038961", null, null, new Guid("ea67b8fa-bc9a-4e27-8ba5-f3c2359c883a"), "02/01" },
                    { new Guid("571534c6-2166-473f-b245-f6d9d6a39958"), "250", "5439479512898066", null, null, new Guid("4595bfbb-3a7d-407e-b6e6-b5d06b0ded5d"), "12/04" },
                    { new Guid("57363898-46a3-4ad5-80b7-f2e569d871c3"), "313", "6937046164309084", null, null, new Guid("7b9aa90c-3f91-430e-bbb3-c445e0de9d01"), "03/26" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("5799a074-fa3d-44cb-9474-a524e7ec0f34"), "677", "7114037860616427", null, null, new Guid("1fda2339-4864-46e3-bf7d-81a520206ae9"), "08/19" },
                    { new Guid("57b2b7e9-c680-4212-9d4f-098c43e4611a"), "931", "5210349633940442", null, null, new Guid("1fda2339-4864-46e3-bf7d-81a520206ae9"), "08/08" },
                    { new Guid("580f713c-5922-4c04-8819-9c8602b894b2"), "330", "3634713731691733", null, null, new Guid("e135b016-8e68-479f-a8e6-0c1dd16d5c2f"), "05/04" },
                    { new Guid("58217bdb-abd1-42fd-a296-7144281828c8"), "467", "4936766498795555", null, null, new Guid("ab522845-c1bd-4f82-bee3-06f49429e4bf"), "08/08" },
                    { new Guid("58254547-3d7c-426c-b8d8-55b3548293f2"), "588", "1777423560567468", null, null, new Guid("1fda2339-4864-46e3-bf7d-81a520206ae9"), "10/27" },
                    { new Guid("5856fa77-940f-4495-9b16-8a9050a79017"), "653", "5926313256986388", null, null, new Guid("7319b27d-6146-4420-aa8d-717913c33345"), "02/13" },
                    { new Guid("59698b22-a3e2-454d-8a72-9738041085d5"), "866", "8314881243934391", null, null, new Guid("65dedea0-0687-4571-93d0-c6cdfefedb38"), "09/13" },
                    { new Guid("59fdee3b-a655-4db7-91e8-0efa584f7d38"), "073", "4784423350070887", null, null, new Guid("af267ef9-b2cf-4adf-a9d0-a58e3acadfa6"), "06/28" },
                    { new Guid("5a0c10d1-1f73-466f-9db7-5c17195e2068"), "618", "2764208901361932", null, null, new Guid("4527938d-6c0c-424e-8f7a-6d20b4f7a9f0"), "08/28" },
                    { new Guid("5a13b2c6-085e-4a30-834a-f60a47063a4c"), "418", "1625583226024730", null, null, new Guid("ae3132fe-b0e9-44a8-a734-658de87cc9a5"), "05/16" },
                    { new Guid("5a2d6f09-d688-44ec-8bfd-8e65565233b2"), "310", "8748615050903612", null, null, new Guid("243b9c2d-ab41-4ea2-b445-092baa8385bc"), "05/17" },
                    { new Guid("5aa373c1-a63f-4822-8ab4-1b0beae5807b"), "999", "9641953093121997", null, null, new Guid("089446be-2352-4d8f-9726-ba2c324e1aee"), "01/05" },
                    { new Guid("5ab0b332-3358-4605-a8c8-06a255aeeb5c"), "812", "9691417948835660", null, null, new Guid("428063f6-fd3a-42bd-b0be-ba01a5e85a84"), "09/03" },
                    { new Guid("5adebf18-cd12-4d44-8377-1e9802382860"), "626", "4656849781320698", null, null, new Guid("c6c5dcc4-cc8e-4484-935f-918264ee4897"), "05/16" },
                    { new Guid("5b00d6c5-4c5e-42a2-8214-bba537522ad3"), "785", "3266449723125958", null, null, new Guid("15a8aac9-d692-4882-990e-3e575587579f"), "09/28" },
                    { new Guid("5b067b98-79fe-491f-963b-e534bf2860ce"), "111", "7005916844809977", null, null, new Guid("56460594-4f75-42d8-9106-e7e3ec02c12c"), "12/23" },
                    { new Guid("5b2842a6-6ed5-490a-877c-4a493a4d301f"), "349", "9040253407023312", null, null, new Guid("d9b74426-c418-4b51-a42a-af5906c2fcff"), "10/13" },
                    { new Guid("5b311948-63bf-4579-910e-b975429742ab"), "034", "2829423827811214", null, null, new Guid("af267ef9-b2cf-4adf-a9d0-a58e3acadfa6"), "04/21" },
                    { new Guid("5b3497b4-2132-48ce-bdef-6d48fcb4d757"), "919", "5067219445972284", null, null, new Guid("3af6d087-276b-42a2-9c69-d7501840f5a1"), "02/04" },
                    { new Guid("5b6e059c-b0fe-46fd-8e8d-c578bdc88fb8"), "692", "8858149863042001", null, null, new Guid("7c403944-d570-486e-9c1f-e40454a443f6"), "12/26" },
                    { new Guid("5bb75a62-eb69-4907-baa6-14bb442c7d19"), "365", "5060681307516047", null, null, new Guid("34c24f57-b16e-4b0f-abe2-5cb9c260e918"), "06/07" },
                    { new Guid("5c03919c-fe4b-4cdd-9b4e-f434b1a31097"), "736", "9997252758907427", null, null, new Guid("8988ace1-50ae-4626-95ff-eac9a9aeade6"), "05/04" },
                    { new Guid("5c2e215e-7736-418b-ac17-495ad91c22a3"), "441", "4673052500256581", null, null, new Guid("3327a162-c88c-4952-9e00-d3c7118fb9f5"), "08/02" },
                    { new Guid("5c370772-171d-4b2e-9a20-4e572e8e0537"), "944", "4756142875603706", null, null, new Guid("00e8ecc6-7b14-4020-bcbd-1a849d69a8c6"), "04/01" },
                    { new Guid("5cff922a-90bb-44c1-a78c-5f0fb02576e1"), "522", "3925367572580853", null, null, new Guid("e0518a7c-2290-4dde-8de0-19fe26c3d8fa"), "02/15" },
                    { new Guid("5d951b4f-0b7e-4ecf-9468-552643700c34"), "694", "7554790042560954", null, null, new Guid("64677ac4-f6ca-4452-9192-ce10eab5a7a4"), "09/14" },
                    { new Guid("5dfaab90-9114-46ee-bb6a-faf6dfb6d18b"), "552", "3478374168630325", null, null, new Guid("6127ea05-85cc-4ed4-9b13-5998aee91180"), "06/01" },
                    { new Guid("5e9623d4-8ea1-44a7-a2eb-4404a0475b0d"), "635", "5102271297966096", null, null, new Guid("4f750333-43c7-4b6d-871b-3959dea7a14e"), "06/23" },
                    { new Guid("5eb03d5a-f853-4ebf-8a5d-566250a11a86"), "960", "3546345573867094", null, null, new Guid("7646ca6a-9ad5-4b77-91b7-839412348bed"), "06/22" },
                    { new Guid("5eeba9d6-3cf4-4fea-89f7-e8b6e8901cb9"), "177", "7142017493721107", null, null, new Guid("36afa758-a0b9-4345-9bce-db873a3c22fd"), "02/10" },
                    { new Guid("5f5616bd-4887-4ea4-8e18-f182e722420b"), "038", "7800021489282668", null, null, new Guid("2275ad3d-6816-4c2b-ba9c-96a3dc4f45fb"), "06/03" },
                    { new Guid("5f564761-f80b-4cc3-bcf4-bb8f4aa2f22b"), "130", "4868958273339284", null, null, new Guid("db7dd226-4232-45fe-a502-06e0dfd99b42"), "11/12" },
                    { new Guid("5f5f749d-c21d-4f74-8936-1d4905c22727"), "377", "5192832207073739", null, null, new Guid("5210b0bd-a591-4887-9abb-0f4415c0f467"), "06/26" },
                    { new Guid("5f7e9f15-fe7e-472e-87ce-5f0146dcef2f"), "962", "6943615773366802", null, null, new Guid("2f3d1b8f-7590-4d18-9002-4caa22511a8b"), "04/11" },
                    { new Guid("5fa0967b-3e0b-4c37-a61c-801c67744453"), "751", "8299385705124112", null, null, new Guid("a3bc456f-939a-42c3-99ed-719e0db5bf18"), "10/26" },
                    { new Guid("5fcc12a8-37ee-404c-85d3-1654ecea2a05"), "419", "5236904961908927", null, null, new Guid("cc019092-2135-4dea-b991-c8b67614f148"), "08/24" },
                    { new Guid("6079981b-3117-4c4a-b5f1-0605a0255b3f"), "139", "6612868251520353", null, null, new Guid("58e47d27-16f3-4806-acf1-7b73ccbc0d5e"), "06/16" },
                    { new Guid("60b2fcd1-d339-4eb3-b894-be78a4801d43"), "136", "5391980745862029", null, null, new Guid("73cff5d2-f041-4e6e-8857-560606637e86"), "07/08" },
                    { new Guid("60cfc34c-fe2d-4aa1-9c3c-090a1919b5ec"), "423", "2357821867348305", null, null, new Guid("f4909d03-d7ac-4aaf-a6fe-77a88f9fe06b"), "07/28" },
                    { new Guid("613dfcd2-4fc5-4e36-8611-66d8c20cfcbd"), "461", "4476927494246486", null, null, new Guid("96830fa4-dc91-4a31-8fad-9b956fd29c58"), "11/21" },
                    { new Guid("622dc984-9d07-4977-a81d-a3c0976543b5"), "840", "5924530447959850", null, null, new Guid("4f1ac364-cc01-4a40-a229-d66da5446413"), "02/26" },
                    { new Guid("62475f58-f332-48c4-aca5-7ebdfc7a7198"), "858", "6439321859224070", null, null, new Guid("f7effd3e-f620-479e-861c-7fb6220a3843"), "01/24" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("62aa7b3f-11fb-4e9f-a3d4-0a6cad0e2037"), "976", "5744283243070943", null, null, new Guid("c864b34c-ddf5-4af6-9a5f-d8251c512e8f"), "10/08" },
                    { new Guid("639edc8e-4bd3-4c22-9022-74e50b82a9a4"), "895", "4819394538835640", null, null, new Guid("4f1ac364-cc01-4a40-a229-d66da5446413"), "06/04" },
                    { new Guid("642961fe-5ec4-4b58-93db-4e68468a3b55"), "089", "6016118327337471", null, null, new Guid("0c210681-d608-4ef0-acaa-f6ca1d403524"), "12/11" },
                    { new Guid("643e6460-7ca4-4d2c-b693-9f574c4c9c56"), "049", "1161446991936368", null, null, new Guid("6de94a05-0c03-4062-8ab9-57a5bd55b3a5"), "09/20" },
                    { new Guid("647168d1-dd72-463b-83e5-2460485b4b05"), "455", "4927718598787593", null, null, new Guid("d572b4d3-7e7c-44d5-b1d1-164c1895424b"), "04/23" },
                    { new Guid("64aa56c2-e521-455a-b520-dd86074abd3f"), "226", "4392008162752099", null, null, new Guid("bdd49191-641c-4843-a442-069a71c65be5"), "01/03" },
                    { new Guid("64bf1cca-0538-4465-aaf1-2f42ef85c19b"), "544", "9855286939234235", null, null, new Guid("a0042a3d-7eaa-4c67-b018-40977ff2a846"), "07/10" },
                    { new Guid("653020ca-40bb-431e-b717-dec9a6024c49"), "013", "2024680690499032", null, null, new Guid("f8c234a1-e25c-478d-be01-cda21178c47a"), "03/21" },
                    { new Guid("65ab92cd-5a85-467f-a79d-5243f341fadb"), "392", "7251600946475870", null, null, new Guid("12f12b30-ab20-433f-91c1-e6f9be859390"), "06/09" },
                    { new Guid("66292a58-7c10-4f74-bfe8-7c56cec7be00"), "762", "1203086796497421", null, null, new Guid("8de401f3-837a-4e09-884e-ddf9af867804"), "09/15" },
                    { new Guid("6674ec2b-b3fe-48f4-8159-ba09b51d6c56"), "197", "3416419752561054", null, null, new Guid("df2bde0b-bda8-499f-b5cc-cfa7429222d1"), "07/25" },
                    { new Guid("6704b151-b0bc-4af6-88d2-814a9e3a34bc"), "598", "9865772003829626", null, null, new Guid("0c210681-d608-4ef0-acaa-f6ca1d403524"), "02/13" },
                    { new Guid("672f3b53-4e33-48e6-8eff-960e62f8da2a"), "774", "2921991731444736", null, null, new Guid("3b1108de-e27d-4674-b7ff-c1df3b68ae41"), "04/09" },
                    { new Guid("67b715e1-f665-43fb-af10-881776f83c8b"), "702", "3208527534828287", null, null, new Guid("8c658576-57f3-41cc-9a3b-917efb1480d9"), "01/10" },
                    { new Guid("67b8c4ab-a455-4520-9122-be1c7a2233a4"), "547", "2219617128506773", null, null, new Guid("a72d6b0a-25a6-4c67-ac93-cc46cae2d9dd"), "12/03" },
                    { new Guid("6818b4aa-0720-482e-81c6-ea3a83139119"), "233", "5846590903013898", null, null, new Guid("a0d3cad9-30ac-4da2-8952-dcde6122a64a"), "10/18" },
                    { new Guid("6832ac8b-bdb2-404d-9237-02b2ce51c73b"), "926", "5724530153669311", null, null, new Guid("fa671618-4f8c-472d-aad1-18adb7778e70"), "04/13" },
                    { new Guid("68cc8c43-8dac-4aba-8a8a-f067f3849390"), "955", "7729557349454891", null, null, new Guid("6127ea05-85cc-4ed4-9b13-5998aee91180"), "02/16" },
                    { new Guid("69094fcc-42f0-4eec-a61f-c31d816d37bc"), "734", "1126698942862177", null, null, new Guid("a8fb7001-ca18-422b-b724-7bb884b357db"), "08/15" },
                    { new Guid("69376033-1d8b-4a37-a62d-d482c1df2ed2"), "622", "3566684397677192", null, null, new Guid("8343d773-e986-49d8-99e9-bd908398b011"), "11/02" },
                    { new Guid("69b60bc3-f12f-4c16-8f0f-f3fe7068af2d"), "471", "6034370205405174", null, null, new Guid("fbcf0085-dd67-4f41-b656-a0c0900baca5"), "05/03" },
                    { new Guid("69d49394-4217-4cef-a2f8-f6562264c7d6"), "428", "9012494416537648", null, null, new Guid("c4ec53d7-69be-4d5d-9091-29c7f80bd641"), "07/14" },
                    { new Guid("69fa0bcd-febc-4516-894a-9a9c0f6cfdd0"), "921", "3984498388126329", null, null, new Guid("0fedadae-5c91-4999-9924-42f5fcd0de5b"), "08/03" },
                    { new Guid("6a8f3bf6-6b20-43e1-896f-955bfa3cb7b3"), "451", "1398935852062446", null, null, new Guid("f3ea0004-e1e2-4557-a9d5-14a5369a2eb3"), "10/03" },
                    { new Guid("6b42d5f6-3fe3-42e1-a8b5-3329cd2e7b7f"), "254", "6730916936430042", null, null, new Guid("9f2db745-dcf4-4a49-a27a-ae15a2f3087e"), "08/25" },
                    { new Guid("6c8dbce3-3f58-405b-8d7d-df92a3be61f6"), "003", "1252533192922030", null, null, new Guid("28ab8e57-b296-4656-9877-df7be64ecc51"), "01/03" },
                    { new Guid("6cccd7d5-810b-4341-9ded-5de840553385"), "545", "3168736644054844", null, null, new Guid("53d8997e-27d6-4129-b5f1-0072e7f179bf"), "04/09" },
                    { new Guid("6d1b56d2-f6e7-424a-9b32-97d513580f7c"), "081", "9603381927618347", null, null, new Guid("5210b0bd-a591-4887-9abb-0f4415c0f467"), "06/17" },
                    { new Guid("6d2e9f45-3bfc-4359-9a39-32ae8866c0f7"), "947", "4853679267674814", null, null, new Guid("712b2e8f-feec-4b44-842e-63c59bbe48cb"), "12/01" },
                    { new Guid("6d8ee3d4-e9af-41c8-a02c-b99dc3f0c218"), "464", "9620865356423940", null, null, new Guid("41e507fd-f435-49b8-a35c-9fba98848542"), "11/08" },
                    { new Guid("6dc44e93-e822-41d4-a5e8-47c80b53ebbe"), "648", "6249415894241025", null, null, new Guid("7e04a2e8-5af7-4c5e-8b81-d51fb8eb210b"), "06/24" },
                    { new Guid("6dd58699-df16-4ef6-903c-e869201ad5f6"), "172", "5831757538509958", null, null, new Guid("af267ef9-b2cf-4adf-a9d0-a58e3acadfa6"), "02/18" },
                    { new Guid("6e02df23-cfc3-4bfa-b9b4-eaf21ecbfec6"), "427", "7805773785853588", null, null, new Guid("c4ec53d7-69be-4d5d-9091-29c7f80bd641"), "01/25" },
                    { new Guid("6ea3fb5b-fe69-431b-b1cd-c29d001510dc"), "537", "4681648067550005", null, null, new Guid("c6c5dcc4-cc8e-4484-935f-918264ee4897"), "05/04" },
                    { new Guid("6eea7ee8-27de-411c-ba10-c20fdd54a64d"), "920", "3751741477187347", null, null, new Guid("b09cd69c-fd2f-4c43-9227-439aa81d485e"), "11/07" },
                    { new Guid("6f070685-7d3b-40da-97b3-46344b805036"), "764", "8257306348111726", null, null, new Guid("f78b821b-0629-4e64-a36a-3d10ad04e07a"), "07/12" },
                    { new Guid("6f7a6b12-b98a-4b2b-b38a-05705c538d77"), "427", "7071595735395317", null, null, new Guid("73cff5d2-f041-4e6e-8857-560606637e86"), "05/08" },
                    { new Guid("6f7f39dd-5185-4b64-9fa3-2db16b32a003"), "611", "1907127754382686", null, null, new Guid("8988ace1-50ae-4626-95ff-eac9a9aeade6"), "05/18" },
                    { new Guid("6fb82389-22f1-4603-b5a9-aea99634d75e"), "698", "7532375322324076", null, null, new Guid("f7ba49ab-b88c-4490-8dc0-4a731ec11ec3"), "09/01" },
                    { new Guid("6fe34247-c1b3-4501-81f8-4d4334aa1e2f"), "301", "9983464493320810", null, null, new Guid("8343d773-e986-49d8-99e9-bd908398b011"), "12/05" },
                    { new Guid("700e4c60-72fd-422e-bc06-c8554499d127"), "654", "7790039799959899", null, null, new Guid("8b82d9a1-181d-4f54-aa69-032bffd3d9d4"), "06/20" },
                    { new Guid("70318444-3a6d-4813-a2dc-d5d7fc197e2a"), "048", "2080331799056409", null, null, new Guid("49e9f216-cefc-4a4e-a243-81e78152afb7"), "07/22" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("70d53565-d18c-4494-9917-3d03a2ce9373"), "532", "8765364441365198", null, null, new Guid("3327a162-c88c-4952-9e00-d3c7118fb9f5"), "09/10" },
                    { new Guid("70ede6ea-d16a-44d9-9935-c8c31cb6b2ff"), "863", "3865721758212552", null, null, new Guid("7a4f4be1-0c5d-43fb-8b70-3e4913ca97a0"), "03/08" },
                    { new Guid("70feb44f-f8f9-4406-88f9-ba732c950942"), "953", "3948196966786725", null, null, new Guid("92fa424c-9623-4989-b9fe-494533664c26"), "10/22" },
                    { new Guid("7153bc78-cebe-4642-80f8-3c961f7323f4"), "594", "9478710012223731", null, null, new Guid("c1169f01-6528-4f74-aa56-802f48a7ece8"), "09/11" },
                    { new Guid("715f7854-a142-40b0-aa4e-5ff430d86db2"), "759", "2019421727826365", null, null, new Guid("f7ba49ab-b88c-4490-8dc0-4a731ec11ec3"), "02/09" },
                    { new Guid("716a38e8-6563-40f5-b5cb-5ea6022cfc09"), "262", "2736623308078911", null, null, new Guid("8d7de522-82d8-4912-bf1a-5d80658097e7"), "07/08" },
                    { new Guid("71719e37-13cd-4a08-b30d-4d5b07969d7e"), "887", "6236242509773593", null, null, new Guid("2078228d-bb74-4e81-8e84-3dd4a76ea271"), "12/08" },
                    { new Guid("71ceb0bf-3e7b-4cd1-a11d-a68c85a3f6f0"), "120", "9367739935611402", null, null, new Guid("37e41091-f10f-4b14-b68d-be058cea2e03"), "12/03" },
                    { new Guid("71dee0db-7289-4096-8507-9ee71199718a"), "739", "4690331106264155", null, null, new Guid("15a8aac9-d692-4882-990e-3e575587579f"), "01/22" },
                    { new Guid("723cb418-ec66-41b4-b8ab-5a27f6b29f81"), "804", "2910374643402187", null, null, new Guid("7adbc5f0-6d2f-4d16-ad51-1b76edd52481"), "01/21" },
                    { new Guid("725eec73-3275-4bb4-9ad9-a1abbbc4938e"), "944", "5786917464663326", null, null, new Guid("5210b0bd-a591-4887-9abb-0f4415c0f467"), "08/07" },
                    { new Guid("7296596f-8200-4342-9fcb-9b218eba5a6a"), "807", "2748150829239906", null, null, new Guid("bfb2c3f3-d581-43c3-ad34-2b9af77e293a"), "03/14" },
                    { new Guid("731de6d7-1e53-408f-a7d6-9001e76b81b3"), "365", "4245168184458716", null, null, new Guid("73953973-c12c-407d-b23d-97f5b010569d"), "04/22" },
                    { new Guid("7371bdd6-dc20-465a-8ccd-b58c0c4d7b1d"), "505", "4686294175362854", null, null, new Guid("b09cd69c-fd2f-4c43-9227-439aa81d485e"), "05/08" },
                    { new Guid("73bd3dd1-7ef5-4301-98e2-2bd9c28ef9a4"), "243", "1129479925834669", null, null, new Guid("99d66586-6373-4afb-b333-7c5cb91075c4"), "07/26" },
                    { new Guid("73d681e3-ba8d-4cfe-a1eb-5f4a8cec946f"), "240", "5372699521767095", null, null, new Guid("bb021ddc-2731-4d61-8069-ddee5e7759da"), "10/13" },
                    { new Guid("73e54ebc-a0a5-44d0-bc10-17298ae25708"), "628", "2267324402178822", null, null, new Guid("611b8b1f-53d5-4660-9ad4-e0b57e915bf8"), "12/09" },
                    { new Guid("74548d38-afef-44db-9a43-ca7a16fec616"), "068", "8950234368014149", null, null, new Guid("c6c5dcc4-cc8e-4484-935f-918264ee4897"), "04/25" },
                    { new Guid("7471b91c-8c2f-4086-ab79-d1b25e396c60"), "443", "8282325882878683", null, null, new Guid("09e536d1-50fd-453a-80d5-e8283f64b0da"), "12/21" },
                    { new Guid("74b44818-6d6a-4629-8005-bedd54327e4d"), "218", "8516711516023639", null, null, new Guid("54f16999-7e05-407e-aab8-1c56cdb79653"), "03/23" },
                    { new Guid("74b6f213-f6da-4336-b909-88ff8ddd62a5"), "127", "7299608850173766", null, null, new Guid("4f7cd1ca-72e9-46bd-ab1e-ae8fa37d21a4"), "06/12" },
                    { new Guid("74d162e7-7466-4ea5-8562-039bb36e3ae3"), "437", "4285197300190296", null, null, new Guid("3af6d087-276b-42a2-9c69-d7501840f5a1"), "01/17" },
                    { new Guid("75359add-eb32-4d35-9fdf-1a7cf34efbad"), "757", "7702321051382291", null, null, new Guid("08e9beba-81d1-40e1-9f0f-4d282258b85b"), "07/19" },
                    { new Guid("756b78a5-5c5c-4866-9312-256e32840d2d"), "437", "6789154195263180", null, null, new Guid("11e566bf-b29d-4651-8e8c-7f65a8281c80"), "04/23" },
                    { new Guid("75a55508-e4b3-4277-9c45-99d11e22d0ae"), "522", "4069635192181439", null, null, new Guid("2f3d1b8f-7590-4d18-9002-4caa22511a8b"), "12/08" },
                    { new Guid("75ea4760-b1bc-4d8c-8972-48f18f8995ff"), "842", "5388442040715209", null, null, new Guid("8fca9140-9c2e-4112-9850-cdf3b029b5ac"), "07/12" },
                    { new Guid("76576c04-212b-4e4e-8101-7cc7616c8688"), "712", "9514361955395379", null, null, new Guid("db7dd226-4232-45fe-a502-06e0dfd99b42"), "06/17" },
                    { new Guid("767c65b2-0d6a-4136-aab1-7610c640a4e4"), "250", "8080554357787489", null, null, new Guid("8c8ff9a2-2752-46a7-960e-0490c28de13f"), "02/24" },
                    { new Guid("767db85a-0be6-4a4a-b2fa-1c9d85c47e70"), "682", "6496870058272183", null, null, new Guid("b252505e-f926-4638-a778-09894c7e3345"), "07/27" },
                    { new Guid("769b8cd5-32d4-49a0-a6f0-176d17d6d463"), "576", "2915370925513771", null, null, new Guid("efacb463-5422-4958-902a-44c5cd16f26b"), "10/15" },
                    { new Guid("76c15298-db1e-4574-ab54-82eb07cd35e4"), "287", "1019744260893907", null, null, new Guid("045fcec6-e944-4ba4-ab53-e930bdb298c6"), "07/09" },
                    { new Guid("770971e0-b437-4957-a93b-32c3c1213e72"), "972", "9488244524364648", null, null, new Guid("49e9f216-cefc-4a4e-a243-81e78152afb7"), "11/17" },
                    { new Guid("774e6b7c-8fb9-448c-beb2-3ad76691642c"), "317", "1268544308691308", null, null, new Guid("85626191-e7df-461f-8d6e-58391f67d36a"), "10/16" },
                    { new Guid("77ad801c-d0f3-454f-bd81-55075bbf02dd"), "743", "6332763139665290", null, null, new Guid("ff5c3ca9-e336-4c0b-bb16-8a689eb03900"), "12/25" },
                    { new Guid("77af1dc9-32ae-4c67-95a1-dd3e84757216"), "614", "5277941319727264", null, null, new Guid("b2abd3eb-7d4b-49b1-8a46-4ea8b8313ab8"), "07/23" },
                    { new Guid("77b58184-7887-4ed1-bd85-ca0f547180e8"), "674", "7192343618870415", null, null, new Guid("89739d78-901e-4353-8c13-fe879541f76f"), "02/23" },
                    { new Guid("77c4243c-b344-4e84-ac8d-0c16704c9706"), "093", "6465906904856937", null, null, new Guid("4a66fea0-71b8-4943-90c9-d349550e6fe9"), "08/07" },
                    { new Guid("77d078b4-a1f8-4b6e-926d-7e0a7de13388"), "335", "1099510365896263", null, null, new Guid("4dd327b9-6a6d-48c5-bd5c-c99248206229"), "10/11" },
                    { new Guid("77da0bfd-a6b7-458b-b882-fd785de9c648"), "140", "5887544080975458", null, null, new Guid("7319b27d-6146-4420-aa8d-717913c33345"), "11/12" },
                    { new Guid("77ddcb17-794d-49c7-b027-2aa967f4fe62"), "105", "5949103172942214", null, null, new Guid("5af211a7-f736-4b52-b2bb-493388054061"), "04/22" },
                    { new Guid("77fd5255-5de5-4d8a-b499-7a64fc5bc18f"), "221", "2221984980603143", null, null, new Guid("5d61541c-3ac1-459c-b0d4-0bbe121306da"), "08/26" },
                    { new Guid("7825a471-3468-4021-99b3-6c8478921aa2"), "930", "4509285376437089", null, null, new Guid("922f53da-9877-4d56-a64d-6d83331bdbb6"), "09/11" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("782a2f52-f380-4fbc-84f6-7c0cc6d170bf"), "559", "8849094911895754", null, null, new Guid("92fa424c-9623-4989-b9fe-494533664c26"), "02/22" },
                    { new Guid("787ec556-ed1b-4719-a91f-c73dead28148"), "517", "8988254419430112", null, null, new Guid("74059a15-c214-4079-bc91-f8aa180574a7"), "09/28" },
                    { new Guid("793cef63-6fe8-4794-9542-30a096bcd08f"), "194", "8245408190787916", null, null, new Guid("21aa2202-92c4-4bb8-a2f8-9785eb49fe49"), "11/09" },
                    { new Guid("79c569a8-a0fb-4a87-830c-2b7ce56aeee8"), "311", "1468003587171309", null, null, new Guid("a5e0abc8-bc40-47e6-bf22-077c758ba0a7"), "11/12" },
                    { new Guid("7b5872a1-0a47-431b-82d2-4d69f2504e54"), "052", "3546572842391469", null, null, new Guid("f7effd3e-f620-479e-861c-7fb6220a3843"), "02/09" },
                    { new Guid("7b68018c-a019-4dec-bb85-f04cb367bfc3"), "032", "7418419993687081", null, null, new Guid("1e75d073-445f-4291-b366-fe0683c205a7"), "02/08" },
                    { new Guid("7bbfbe8f-f9fc-4be1-8628-a187d2b90ec0"), "213", "4270778590185428", null, null, new Guid("011fba87-398c-42ec-9aa7-ffb9c48fe9a9"), "05/22" },
                    { new Guid("7bc5d383-61d7-46fe-9ff7-64492913134b"), "665", "4404308449579608", null, null, new Guid("c2edd12d-5919-4c5c-b18f-3b1ef2ea8f55"), "04/04" },
                    { new Guid("7bc727dc-5053-48e5-bce0-f29f535ae9e6"), "788", "3130249412811343", null, null, new Guid("c6d62b30-8c4e-444d-a56a-cf5bea9f9c2a"), "08/20" },
                    { new Guid("7bdaf803-b2da-4920-976c-2b51cee319c6"), "193", "6312388171863449", null, null, new Guid("f57190db-67c4-4d7b-9cd1-c8e27a6ac561"), "04/27" },
                    { new Guid("7c56a2b1-30cb-4f4d-8620-7eba507349f3"), "933", "8474460199460962", null, null, new Guid("b72dbc44-743b-4e39-a250-af429c1f09a9"), "02/06" },
                    { new Guid("7ca38f58-fae8-420a-bcdf-cb20b956c2e3"), "657", "8621695973258529", null, null, new Guid("37e41091-f10f-4b14-b68d-be058cea2e03"), "06/04" },
                    { new Guid("7cb6f653-a49f-4b58-bd04-c580679f1621"), "638", "2767680854628235", null, null, new Guid("8988ace1-50ae-4626-95ff-eac9a9aeade6"), "08/03" },
                    { new Guid("7cce8ddc-f263-49c3-8cae-c7ffd40db763"), "674", "5315468612021623", null, null, new Guid("a339ea33-3188-40c2-9d84-9ea46aa67e82"), "05/13" },
                    { new Guid("7cd69c9d-8766-4dbc-b362-640253baa3aa"), "666", "8419944607363533", null, null, new Guid("b40e13af-a00a-45af-a681-b960cb8d6a7b"), "01/03" },
                    { new Guid("7cf8f174-85b3-4ea9-9c32-5e65697cb38c"), "358", "7575541020634133", null, null, new Guid("a66e6d00-7000-4eb2-994b-a38594503957"), "12/03" },
                    { new Guid("7e495174-03ca-4aad-b1d3-6259298801fa"), "305", "8008004534485411", null, null, new Guid("4dd327b9-6a6d-48c5-bd5c-c99248206229"), "08/20" },
                    { new Guid("7e61652b-d1f0-456b-bf95-464a0d2a4a78"), "792", "4579212953323008", null, null, new Guid("bb021ddc-2731-4d61-8069-ddee5e7759da"), "07/06" },
                    { new Guid("7f5651c7-b669-45a4-82aa-1b690e6170e5"), "864", "8134167096795579", null, null, new Guid("0edec355-b022-4255-80d6-c530f687d26e"), "05/19" },
                    { new Guid("7fb0e245-cd8f-4cb4-99e7-792cab63287f"), "929", "5012868244134488", null, null, new Guid("db7dd226-4232-45fe-a502-06e0dfd99b42"), "02/28" },
                    { new Guid("7fca606b-6d18-4e6a-9c6f-7286b6b8ca68"), "363", "3685584929633923", null, null, new Guid("0edec355-b022-4255-80d6-c530f687d26e"), "01/21" },
                    { new Guid("7fe3c49a-07d5-4c86-a83b-6f27912b6b4f"), "635", "5378968588648067", null, null, new Guid("fbcf0085-dd67-4f41-b656-a0c0900baca5"), "07/04" },
                    { new Guid("806ea9eb-b49a-400d-b71e-60f0bc04e41a"), "398", "4184181603091763", null, null, new Guid("bb021ddc-2731-4d61-8069-ddee5e7759da"), "12/17" },
                    { new Guid("808805a5-d0b6-4e0f-8022-131f041bec43"), "242", "9518023657065228", null, null, new Guid("d6f2753c-e864-40f4-a45e-4096737598aa"), "09/08" },
                    { new Guid("808c747b-13f0-4564-886b-78f873137b64"), "107", "6732341329644339", null, null, new Guid("c6d62b30-8c4e-444d-a56a-cf5bea9f9c2a"), "07/22" },
                    { new Guid("80deb144-cd97-4269-807d-06a193c735c9"), "778", "4721114892408125", null, null, new Guid("40de2c6f-e29d-4027-93c3-945e76ec015c"), "05/10" },
                    { new Guid("81f5d5fc-5de2-4e12-b6ea-28753351640d"), "404", "1981110277715877", null, null, new Guid("73953973-c12c-407d-b23d-97f5b010569d"), "06/04" },
                    { new Guid("821935f4-8666-4eb5-8bca-af3c905ecc77"), "543", "3608739393908378", null, null, new Guid("f7ba49ab-b88c-4490-8dc0-4a731ec11ec3"), "05/19" },
                    { new Guid("823d7536-0e22-41ea-848a-55cbecb9c7e5"), "444", "3184834904433276", null, null, new Guid("b2abd3eb-7d4b-49b1-8a46-4ea8b8313ab8"), "08/20" },
                    { new Guid("82478a1f-7064-4f20-91a0-ee056ce47a3f"), "688", "7689424054616028", null, null, new Guid("89f14bfd-f2ad-40fc-8c24-b21398e3c7d3"), "10/28" },
                    { new Guid("82addf82-231c-4f96-8c64-d8a108df55d2"), "028", "2995803389822066", null, null, new Guid("9e9403fb-605a-441d-a83a-f936fec7582f"), "07/20" },
                    { new Guid("82f4158e-b00c-4e35-b9bf-e90e8b919517"), "617", "4183787264753124", null, null, new Guid("f7f5e0b6-df15-4f10-b87e-6503c5e8fb8e"), "01/24" },
                    { new Guid("830bb146-9303-4c98-b676-f50d242283c7"), "366", "3030857309307829", null, null, new Guid("f2fc34d0-f967-4d49-ac54-2191c244d200"), "11/01" },
                    { new Guid("8323236e-f15d-4eea-ac96-a4cbb7fea124"), "130", "8364383015632931", null, null, new Guid("73953973-c12c-407d-b23d-97f5b010569d"), "02/25" },
                    { new Guid("83666bc7-e394-405b-8e49-ead123e57212"), "958", "5689017557233367", null, null, new Guid("11e566bf-b29d-4651-8e8c-7f65a8281c80"), "05/24" },
                    { new Guid("84c173f3-a23d-4dbd-b33b-ac96c72e48b8"), "185", "6554262163257956", null, null, new Guid("9e9403fb-605a-441d-a83a-f936fec7582f"), "05/10" },
                    { new Guid("84c4c4ae-c7ca-48e2-93c8-824c48caacb6"), "623", "7648405543561449", null, null, new Guid("f3a37729-6cc8-4507-9aa5-d44c334bc0a7"), "02/01" },
                    { new Guid("84e8bd05-d728-4594-a264-27453b1d10c9"), "540", "4812859596266819", null, null, new Guid("74059a15-c214-4079-bc91-f8aa180574a7"), "03/27" },
                    { new Guid("86031ec1-fc00-43db-9f45-3eafa61ac383"), "227", "7411903288952578", null, null, new Guid("a1e9eb46-748f-4b86-8554-7ae48675b2da"), "10/27" },
                    { new Guid("865d2560-c27c-4f08-ab6f-bc6ed44749ad"), "309", "8517025632630998", null, null, new Guid("624d07fb-c364-4191-b439-aff73116c1d2"), "05/02" },
                    { new Guid("86948a75-11cd-4875-87e2-00b97fef20d3"), "524", "6211268343318244", null, null, new Guid("f78b821b-0629-4e64-a36a-3d10ad04e07a"), "02/20" },
                    { new Guid("86de068d-7f3c-4f9b-bdbf-c949348e1020"), "464", "6688151639895705", null, null, new Guid("c1169f01-6528-4f74-aa56-802f48a7ece8"), "11/11" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("86e8ec65-66dc-4ea6-8254-7350f3d36b5d"), "353", "6076304737834281", null, null, new Guid("3327a162-c88c-4952-9e00-d3c7118fb9f5"), "12/19" },
                    { new Guid("87cb8737-bb35-4456-972f-cf33f7eb11ee"), "506", "3798701218714161", null, null, new Guid("922f53da-9877-4d56-a64d-6d83331bdbb6"), "04/10" },
                    { new Guid("87dafb0c-a96e-45e0-9a92-270f77b1ec71"), "014", "2730611199847324", null, null, new Guid("13164560-3eb6-4f4f-9c11-1f819fc48e22"), "04/14" },
                    { new Guid("87ff44df-1c0c-456a-9a1c-3713191940da"), "987", "6823027163074200", null, null, new Guid("2d52a2a2-27d8-49a4-9ce6-969bb0f68fa2"), "05/23" },
                    { new Guid("880017de-11c8-4caf-8e2c-469d1b71c37c"), "881", "8363098633838095", null, null, new Guid("0edec355-b022-4255-80d6-c530f687d26e"), "02/28" },
                    { new Guid("88a8fa30-401f-423b-b864-508c6899b7e0"), "463", "5803868148860262", null, null, new Guid("ce3412db-b24b-4f68-8e32-724c140b7d0a"), "10/22" },
                    { new Guid("88d98567-a7f8-4f50-9877-00a363fd54ff"), "526", "9007052882139354", null, null, new Guid("28ab8e57-b296-4656-9877-df7be64ecc51"), "06/17" },
                    { new Guid("89e8d85b-5640-4143-bf94-8f447e4a137a"), "110", "8985099410575994", null, null, new Guid("a4972888-e048-48a4-a351-23bd705a917e"), "03/19" },
                    { new Guid("8a12a358-73be-43b2-ba8d-b5c703d47507"), "240", "3244232654275881", null, null, new Guid("3af6d087-276b-42a2-9c69-d7501840f5a1"), "03/18" },
                    { new Guid("8abd8876-2f05-4e35-8a1d-07755aa46a51"), "972", "2497941211294897", null, null, new Guid("f3a37729-6cc8-4507-9aa5-d44c334bc0a7"), "05/08" },
                    { new Guid("8af91c5d-cd6d-4cb3-abaf-7208addf8bb6"), "433", "6922116536709002", null, null, new Guid("7adbc5f0-6d2f-4d16-ad51-1b76edd52481"), "07/12" },
                    { new Guid("8b722819-1c11-497a-aaba-40e049d2c423"), "239", "9293064359237164", null, null, new Guid("2a79982f-f343-4569-a725-228ecab03718"), "03/15" },
                    { new Guid("8b929784-3cd5-4dbe-8bc1-d00b03c0e84a"), "162", "8344524863716870", null, null, new Guid("0dce50e5-ef29-456b-ab6f-c4454c5cfc38"), "02/22" },
                    { new Guid("8bc5acc4-20de-40e9-a2c5-a92ec463f57b"), "696", "2914509640144545", null, null, new Guid("7a4f4be1-0c5d-43fb-8b70-3e4913ca97a0"), "09/07" },
                    { new Guid("8c67dcb8-3c76-494b-b576-a1c4b0e8e179"), "148", "7675518575864760", null, null, new Guid("8dea05e1-92c5-40d9-9159-8e1dcb818034"), "01/19" },
                    { new Guid("8c8a7a84-e3a0-408c-aa06-364e2f12ffc3"), "783", "8446138552814227", null, null, new Guid("8180db6e-0139-48fa-a7bc-8424ac74378c"), "07/10" },
                    { new Guid("8ca2a7c5-62b2-4179-9e94-792bd5ba882e"), "331", "7669424348104352", null, null, new Guid("a907043f-86ba-4126-baac-6e2c6eb5871c"), "01/28" },
                    { new Guid("8cb4c09c-4502-42f0-b192-2dc5a284b681"), "456", "9640797997529277", null, null, new Guid("1530b862-24b5-484d-8939-50315a49bd13"), "06/07" },
                    { new Guid("8ce90fbc-82ce-4b0f-a75e-48a9e84f8145"), "653", "5366987147059307", null, null, new Guid("ae1ca1b0-7eff-4b3f-a0bd-d326d1ebe578"), "02/15" },
                    { new Guid("8cf3bd77-ca9c-47e0-8017-e13569153cdb"), "030", "4921252526654779", null, null, new Guid("2956754d-e1ca-4623-bbe4-691ff14c9d29"), "03/06" },
                    { new Guid("8dc20a0f-11e2-4450-bd1c-f4eb6f52c516"), "685", "3777241716436986", null, null, new Guid("1281e6c3-dc02-4e83-a90d-37f640411dfc"), "04/22" },
                    { new Guid("8deb2565-1efc-4e58-b280-6993275cdfda"), "466", "5450437791068461", null, null, new Guid("7a4f4be1-0c5d-43fb-8b70-3e4913ca97a0"), "05/28" },
                    { new Guid("8ec490de-1b33-4d87-8621-e678c9bb4dcb"), "371", "5372290532814155", null, null, new Guid("34abae3b-f28c-4c59-a716-fea9a1b0e1bb"), "07/04" },
                    { new Guid("8f25f34c-92f7-41b3-8459-f17ac0aec3e9"), "120", "6322286644495172", null, null, new Guid("f57190db-67c4-4d7b-9cd1-c8e27a6ac561"), "11/10" },
                    { new Guid("8f30c966-faa3-488a-893c-271c9068972b"), "512", "8339146670433067", null, null, new Guid("7646ca6a-9ad5-4b77-91b7-839412348bed"), "02/23" },
                    { new Guid("8f6277b6-78aa-4bfd-a32c-a32a8d2230c6"), "287", "1050347503925499", null, null, new Guid("500d7059-5719-42c4-a15e-d4753ba03714"), "03/18" },
                    { new Guid("8f8f092b-90ea-4b18-a3fd-ff653cb25188"), "476", "4931453388810734", null, null, new Guid("9e9403fb-605a-441d-a83a-f936fec7582f"), "11/05" },
                    { new Guid("8fe65532-cfd8-467a-a523-c8a5de7946f3"), "762", "5636771090711958", null, null, new Guid("ebc46bc5-40b3-40f7-b23b-cc974fa9b051"), "09/20" },
                    { new Guid("9007e25c-8e97-4940-a8ea-51445f09b1a3"), "471", "9706383630560187", null, null, new Guid("2f3d1b8f-7590-4d18-9002-4caa22511a8b"), "08/04" },
                    { new Guid("90523bd5-4323-40b7-b93b-814281c7e3a9"), "589", "3765292319764196", null, null, new Guid("f070ec16-f59a-41c8-8ab6-b492f05b08e3"), "09/17" },
                    { new Guid("90d441cf-675e-44cb-b6d4-5f5a0472a917"), "536", "3502771850597766", null, null, new Guid("f52649ec-b9d7-4f35-8295-ec4e2b5c564c"), "09/27" },
                    { new Guid("90f7096d-d0d8-429b-ba8e-0ce1ee981373"), "389", "5797069771393051", null, null, new Guid("6441d6d0-462e-4346-8bea-ddea048566dd"), "02/17" },
                    { new Guid("9196daca-ca68-4422-9c3c-ad5e0ba5ce9b"), "678", "2013285517720150", null, null, new Guid("7d6ad8fc-e102-4ea8-a3e2-5bdfda8f1650"), "01/23" },
                    { new Guid("91a9b178-b2e8-45c6-b625-ec5d50f29ade"), "704", "4533422333810925", null, null, new Guid("1530b862-24b5-484d-8939-50315a49bd13"), "09/06" },
                    { new Guid("91eeaf5c-cd76-4ed2-bd66-c1cad7fa20e1"), "380", "9758164816237100", null, null, new Guid("68bf203c-5d15-452a-b81b-bb7831c4f579"), "06/17" },
                    { new Guid("92bbcc53-19bf-4cca-8802-c29b7a4d12a6"), "521", "6402646929223953", null, null, new Guid("a8fb7001-ca18-422b-b724-7bb884b357db"), "03/10" },
                    { new Guid("93221a54-48b9-4c31-932d-8c426e48d178"), "399", "3723744408752138", null, null, new Guid("89f14bfd-f2ad-40fc-8c24-b21398e3c7d3"), "07/03" },
                    { new Guid("935535a2-eace-46fa-950b-fda478fb818f"), "080", "3100477345628555", null, null, new Guid("abfe1efb-0a8f-4af4-ab49-6de94e3ef374"), "11/20" },
                    { new Guid("93e9c00a-b3a1-4cda-9252-ecea2559e2ec"), "462", "7491600183824696", null, null, new Guid("ddf155f2-6984-4582-b06c-39700b8ecb92"), "05/23" },
                    { new Guid("947a0a42-4d7d-4d84-9c50-554c4914a298"), "148", "8673220604969888", null, null, new Guid("fce6a3fa-2769-41fb-ad0b-94fcfc2caab0"), "03/17" },
                    { new Guid("94c35e0f-64e0-4703-bcf0-5f7338674a42"), "292", "2828520246516940", null, null, new Guid("07169b5c-40fd-40ba-b01e-8b56de466065"), "07/20" },
                    { new Guid("95523e57-31a1-4025-abf8-5fa7b3ddfe9e"), "447", "5417796955263815", null, null, new Guid("5d61541c-3ac1-459c-b0d4-0bbe121306da"), "10/27" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("95a51334-c096-4952-87fc-34604dc3e336"), "292", "9059771132364003", null, null, new Guid("8fca9140-9c2e-4112-9850-cdf3b029b5ac"), "05/06" },
                    { new Guid("95be49a7-2bd8-4a84-b51b-9a54a6694ac5"), "227", "3470549400956312", null, null, new Guid("73cff5d2-f041-4e6e-8857-560606637e86"), "03/16" },
                    { new Guid("9616b640-14dd-4098-8335-e5dcd8c0bbfe"), "622", "6261902113313971", null, null, new Guid("27f9e909-39f0-43df-afb3-3bc130e8da06"), "05/13" },
                    { new Guid("9617f093-6df8-4bb1-8302-eb510821df57"), "873", "6403223533863578", null, null, new Guid("df2bde0b-bda8-499f-b5cc-cfa7429222d1"), "11/17" },
                    { new Guid("961d634e-6d40-4ea8-aaad-1f6bb90e05bb"), "814", "8055193919691345", null, null, new Guid("52fe76ad-4c09-4b99-9385-e407990c0307"), "04/15" },
                    { new Guid("96b9910f-ef39-415b-8d11-86e4dcbe86cd"), "645", "1157298003684377", null, null, new Guid("f3ea0004-e1e2-4557-a9d5-14a5369a2eb3"), "11/01" },
                    { new Guid("96dc04d0-0ca0-4dac-bd17-cc373c925325"), "673", "8511312791249104", null, null, new Guid("34c24f57-b16e-4b0f-abe2-5cb9c260e918"), "02/28" },
                    { new Guid("970c93f8-c180-4411-abb4-b1c77b3ca6af"), "100", "6279092562203031", null, null, new Guid("8988ace1-50ae-4626-95ff-eac9a9aeade6"), "02/12" },
                    { new Guid("980139a2-65aa-4eab-9a84-2a73e3fc4fe4"), "949", "2684843946514578", null, null, new Guid("ff5c3ca9-e336-4c0b-bb16-8a689eb03900"), "08/12" },
                    { new Guid("980985c4-4f33-4031-9497-29fd27871e60"), "438", "2528505975142021", null, null, new Guid("2956754d-e1ca-4623-bbe4-691ff14c9d29"), "08/18" },
                    { new Guid("9878c47f-551a-4203-82d3-be8140b66c3f"), "305", "2012513800032202", null, null, new Guid("09ee89cc-9f4d-4eae-a4f3-731ca2d52102"), "11/10" },
                    { new Guid("99e326bb-2784-4d4c-9d58-af3297713c16"), "054", "7276175992610799", null, null, new Guid("ebecc10d-21da-4369-81d7-600c2de48f88"), "02/22" },
                    { new Guid("9a579b1d-9f8f-45bf-b842-0c8ad3a77e75"), "710", "5824569110915914", null, null, new Guid("d799d7ce-936a-414f-86fd-958f17b3f642"), "05/10" },
                    { new Guid("9a63736b-1b85-436a-a180-730de37bcc03"), "974", "1064697736544499", null, null, new Guid("89739d78-901e-4353-8c13-fe879541f76f"), "03/21" },
                    { new Guid("9a638947-e233-477d-9739-5d5f4f3e40ef"), "784", "8749525782539336", null, null, new Guid("993e8305-611d-4730-af5d-dbd1e15c6650"), "04/21" },
                    { new Guid("9a9d0cfb-6441-4017-b880-cad019439bea"), "724", "1066925520853775", null, null, new Guid("f3a37729-6cc8-4507-9aa5-d44c334bc0a7"), "02/15" },
                    { new Guid("9af6a4b3-d4e8-41b8-a8df-83d683221327"), "852", "8097585438518355", null, null, new Guid("cd6370e2-d6d7-4cbd-aaac-c3cf98e8cec3"), "08/19" },
                    { new Guid("9b2d0d02-d11c-408d-a677-a337a5cc7e75"), "898", "8576369680212829", null, null, new Guid("aa406ff8-810a-45a6-8b41-5028563ae3b6"), "01/09" },
                    { new Guid("9b376a03-7a08-430e-80a9-a596d8c89f5f"), "665", "9267214965014626", null, null, new Guid("ce108172-f4b7-4653-a5c3-ff603fbc3a50"), "09/04" },
                    { new Guid("9b3e6622-7bda-4ee0-913d-4bb20e9e8a28"), "317", "1890914296227691", null, null, new Guid("7a4f4be1-0c5d-43fb-8b70-3e4913ca97a0"), "10/18" },
                    { new Guid("9b4f8b35-d48a-441a-ad1a-5875aca28631"), "397", "6920030119329619", null, null, new Guid("1281e6c3-dc02-4e83-a90d-37f640411dfc"), "01/16" },
                    { new Guid("9b5012ae-7204-4b0e-b3b5-a02dc17bee14"), "923", "4156936101844558", null, null, new Guid("6ceec469-cfb3-42b5-b289-a4c2da0a32dc"), "08/10" },
                    { new Guid("9c0139c3-8125-413c-8640-ccfaa4b99721"), "755", "8429110751829189", null, null, new Guid("c075bfdf-a5cc-4efb-a6d1-f31b0c4bf344"), "10/09" },
                    { new Guid("9c42b67f-e3bb-412f-9898-18ba30a530ab"), "352", "3326239286069398", null, null, new Guid("0643292c-1282-43c9-ae18-5e2311a73db2"), "03/24" },
                    { new Guid("9c5bf92b-e1bb-4e5e-a7f1-03a723468b33"), "669", "1967171960733867", null, null, new Guid("0615c4c1-b356-478a-abeb-caaccb8742b0"), "08/10" },
                    { new Guid("9cfff71d-04f1-4d95-8cfd-3d76a8b0ed2d"), "802", "5495815715958242", null, null, new Guid("fa671618-4f8c-472d-aad1-18adb7778e70"), "12/05" },
                    { new Guid("9d025254-cbcc-4d7b-bc63-7d6d27e7832e"), "358", "8338190407388142", null, null, new Guid("d173c22f-aa53-4e3b-b137-bcd6d2faf814"), "06/14" },
                    { new Guid("9d1a9f46-2fe0-4c7d-9dac-ce40b735ddca"), "106", "3699475971269375", null, null, new Guid("993e8305-611d-4730-af5d-dbd1e15c6650"), "12/07" },
                    { new Guid("9d2fefca-d5d2-4694-a2d6-7cb75d8d5b82"), "628", "9585707831101589", null, null, new Guid("f7e08701-d57e-42d3-884d-beb04dee4c45"), "09/10" },
                    { new Guid("9d3736c9-dd8c-4839-93fa-6976713034c0"), "112", "5830896818034787", null, null, new Guid("cc019092-2135-4dea-b991-c8b67614f148"), "03/09" },
                    { new Guid("9dbb5e2d-6839-4c35-b032-9dc9e78af590"), "041", "4104140275567592", null, null, new Guid("ebc46bc5-40b3-40f7-b23b-cc974fa9b051"), "07/06" },
                    { new Guid("9defcd7f-c9e1-482c-8484-ffa6b6b03a65"), "772", "2837057892831008", null, null, new Guid("712b2e8f-feec-4b44-842e-63c59bbe48cb"), "06/16" },
                    { new Guid("9e230a04-a4e0-4a24-bfd1-d9d16f690171"), "796", "6417396357702103", null, null, new Guid("1fa36b53-f427-4c95-96d2-7c8a11050267"), "01/23" },
                    { new Guid("9e2c020b-def4-4c59-b373-1353f1774215"), "123", "2796624918204254", null, null, new Guid("143cf7ff-f2e3-444c-a15b-3aa7b4c43475"), "02/05" },
                    { new Guid("9e37f5b1-c8f1-40d1-bd6f-eab9ecd4915e"), "296", "7686465314403291", null, null, new Guid("1e75d073-445f-4291-b366-fe0683c205a7"), "03/06" },
                    { new Guid("9e9fc93b-6224-4f69-bf1d-a19f3a3e1348"), "866", "3210421593154778", null, null, new Guid("77f28b3f-3ca9-4819-96c6-bd1e811a39f5"), "03/08" },
                    { new Guid("9ee4be66-91e1-4cf0-86ee-6d9cadf15a02"), "917", "7259056220181634", null, null, new Guid("abfe1efb-0a8f-4af4-ab49-6de94e3ef374"), "05/26" },
                    { new Guid("a00fdd1f-573e-4722-a559-b9bacf6bc3c6"), "371", "1483275094482614", null, null, new Guid("1de915db-ea78-41e7-a3a2-76a8f6311629"), "11/08" },
                    { new Guid("a0ac6e2b-fc0d-4409-a102-ecb95d31c46e"), "427", "3361154013517074", null, null, new Guid("74059a15-c214-4079-bc91-f8aa180574a7"), "08/17" },
                    { new Guid("a0e9da37-3c75-4a56-bef8-4e850987bf7c"), "954", "9803902817589760", null, null, new Guid("732ba531-5faf-4b4a-bcac-24d9ca3fcbc2"), "04/11" },
                    { new Guid("a1db4160-b686-41ab-8570-fc3e38b9abaf"), "090", "4370548950078550", null, null, new Guid("11e566bf-b29d-4651-8e8c-7f65a8281c80"), "10/28" },
                    { new Guid("a229dbac-7d7a-453c-b6bc-7e6a9dfcab8c"), "750", "7942777307447471", null, null, new Guid("a3bc456f-939a-42c3-99ed-719e0db5bf18"), "01/17" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("a2d3b383-4e37-4d0e-907f-db2c05902a0b"), "459", "3683533781709269", null, null, new Guid("b9a99c94-3031-4da9-bdf3-33bb288dd6a9"), "12/04" },
                    { new Guid("a3416f56-bc9e-427d-b123-9437f2d35128"), "736", "3461964142354665", null, null, new Guid("243b9c2d-ab41-4ea2-b445-092baa8385bc"), "01/18" },
                    { new Guid("a35ceff6-a3f9-46b7-bcb0-98c47dc6aa1e"), "268", "4029127330472543", null, null, new Guid("4b70366e-a511-4254-8c8d-ad820ee7b210"), "04/17" },
                    { new Guid("a3e05201-fd44-48b3-b647-f1086c186f1f"), "925", "4094967956031803", null, null, new Guid("25a38376-e74c-46cc-8d4f-292cebbcdffb"), "04/16" },
                    { new Guid("a417eb1c-354f-4b60-8d16-7a63d1acc621"), "066", "2960938491994575", null, null, new Guid("0c210681-d608-4ef0-acaa-f6ca1d403524"), "05/25" },
                    { new Guid("a442535f-5734-4d96-a844-648f492113eb"), "474", "2826555951163633", null, null, new Guid("4e8f092d-b1e1-47d3-9de6-5d9db26187a5"), "03/18" },
                    { new Guid("a470320f-08fc-4131-958e-004f11909ea7"), "275", "2300720604012992", null, null, new Guid("9beccf2d-f01f-48c2-a830-6db7b7da19dd"), "08/27" },
                    { new Guid("a473c1c1-7f19-4c46-ab0b-a0d0287d04b6"), "080", "9518028218185528", null, null, new Guid("d62fe5e3-4821-411a-b458-87e89f41f2f1"), "02/21" },
                    { new Guid("a49430cf-c07e-40c9-929a-68651b7802c8"), "550", "8912068088061064", null, null, new Guid("b2085c8a-b530-4404-a522-eaa5962529ec"), "12/10" },
                    { new Guid("a6d9bb7a-cb16-49d3-8a14-8796eab26bff"), "100", "9169782569616504", null, null, new Guid("a6098ed7-dc3b-4d11-bcda-a3ba0c8ac2f4"), "05/27" },
                    { new Guid("a73b42d5-55d8-42ec-bf2d-fac6e25bedaf"), "624", "8740017383829965", null, null, new Guid("0edec355-b022-4255-80d6-c530f687d26e"), "12/14" },
                    { new Guid("a74685bc-e85c-47e4-8909-7e6e33b4f95a"), "299", "3823272731320713", null, null, new Guid("2a79982f-f343-4569-a725-228ecab03718"), "06/24" },
                    { new Guid("a74dfc74-3e6f-464d-8963-74f8b3ed8f52"), "503", "8476392815270345", null, null, new Guid("b252505e-f926-4638-a778-09894c7e3345"), "09/12" },
                    { new Guid("a7bcc182-b7fd-46f6-8d75-62e80cad22ff"), "579", "9011541955313841", null, null, new Guid("0d9e85a0-24c2-4c10-b1f2-180d3ceeaaaf"), "09/23" },
                    { new Guid("a7c5ca28-0660-4040-8135-a151aedda7b4"), "521", "4414881932697355", null, null, new Guid("70fe5fa7-69ef-4577-a750-34ca205c0dac"), "09/16" },
                    { new Guid("a7e256bf-4f4e-4f81-855f-1120fe484c7d"), "416", "5553468265549071", null, null, new Guid("22a1446b-6ffd-488e-8e70-011276aa0ae3"), "04/27" },
                    { new Guid("a8e71ba7-cf81-4688-bdc1-dd39652a18ef"), "161", "1931383860791761", null, null, new Guid("00e8ecc6-7b14-4020-bcbd-1a849d69a8c6"), "11/18" },
                    { new Guid("a928c508-021b-4b2c-8a9c-de3575e4a6b6"), "288", "3530171312998771", null, null, new Guid("db7dd226-4232-45fe-a502-06e0dfd99b42"), "11/04" },
                    { new Guid("a92fec53-4cfe-43b5-bf37-5130dd8113d8"), "620", "5803108073970178", null, null, new Guid("4af3e803-6a3d-43c8-9c77-811cb6207644"), "01/14" },
                    { new Guid("aa261e02-14d0-4561-aad1-07c57ba14358"), "828", "5009959488538583", null, null, new Guid("611b8b1f-53d5-4660-9ad4-e0b57e915bf8"), "04/28" },
                    { new Guid("aa49e91a-71e5-494f-8cc1-8f892afa4614"), "038", "6255943247208108", null, null, new Guid("19d85480-882e-40f7-a536-84a552b3e447"), "07/28" },
                    { new Guid("aa572ef7-d60d-4b16-86c1-6071f6550be1"), "533", "2347382125069045", null, null, new Guid("08e9beba-81d1-40e1-9f0f-4d282258b85b"), "06/14" },
                    { new Guid("aae318fe-b57c-435d-8f2a-300799c95804"), "344", "8438246640072105", null, null, new Guid("a3bc456f-939a-42c3-99ed-719e0db5bf18"), "04/14" },
                    { new Guid("ab5bef5d-2729-4720-9be7-1d1ad8a74221"), "407", "1963499887616201", null, null, new Guid("b09cd69c-fd2f-4c43-9227-439aa81d485e"), "09/26" },
                    { new Guid("ab6be9f4-d51e-4a0b-9a7f-fb39916a9518"), "391", "6792436551117743", null, null, new Guid("3327a162-c88c-4952-9e00-d3c7118fb9f5"), "09/05" },
                    { new Guid("ab6f88b6-de94-4c13-b636-ce1e48acc3e1"), "807", "8279642016516742", null, null, new Guid("85626191-e7df-461f-8d6e-58391f67d36a"), "02/05" },
                    { new Guid("abefa4ac-b19d-4406-9477-47ac8f2ca1b3"), "111", "2280796070649664", null, null, new Guid("c9b88753-217a-4bb2-ac30-4bed75d66c61"), "08/15" },
                    { new Guid("ac5a5258-3543-4281-92aa-603d67b92c15"), "421", "1893144655312672", null, null, new Guid("0643292c-1282-43c9-ae18-5e2311a73db2"), "02/01" },
                    { new Guid("aca5b962-0d99-475b-a742-2f59fcfab36f"), "644", "9704392431777326", null, null, new Guid("3359f4d4-fbc1-4174-b3e0-8cc3754ac07b"), "07/14" },
                    { new Guid("acd84280-ff86-41a1-9b6b-4df89e89bfbd"), "171", "5838102253678709", null, null, new Guid("a339ea33-3188-40c2-9d84-9ea46aa67e82"), "05/19" },
                    { new Guid("acdc4c0c-552f-461e-9a0a-48ae9cab8042"), "443", "5578314818333409", null, null, new Guid("f3a37729-6cc8-4507-9aa5-d44c334bc0a7"), "09/23" },
                    { new Guid("acf40e53-91c7-468a-901e-dc470ded136d"), "913", "9686153801806076", null, null, new Guid("8c658576-57f3-41cc-9a3b-917efb1480d9"), "04/25" },
                    { new Guid("ad1abcad-f475-41dc-b39d-4cb6f944c118"), "618", "9483464768927331", null, null, new Guid("0dce50e5-ef29-456b-ab6f-c4454c5cfc38"), "01/10" },
                    { new Guid("ad6ebc8c-773b-403d-9ad4-f4d4b7791cef"), "912", "9762888659659307", null, null, new Guid("9beccf2d-f01f-48c2-a830-6db7b7da19dd"), "12/11" },
                    { new Guid("ae3b8bbb-2c02-45f6-8e94-b0ea3669d7d3"), "681", "8165993553775152", null, null, new Guid("0c162bb7-00a6-40b1-b35d-bbd2862f363c"), "10/15" },
                    { new Guid("ae9d367e-6441-4061-b82f-85604c684e18"), "581", "6195653141679583", null, null, new Guid("57c213e6-163e-4134-8633-29615daff79d"), "09/16" },
                    { new Guid("aed879b4-1f7d-48b6-8420-e48eb70af6d3"), "962", "1881770860109353", null, null, new Guid("8343d773-e986-49d8-99e9-bd908398b011"), "01/28" },
                    { new Guid("af2de602-9a99-4553-9810-f784221f148a"), "734", "2072101495196634", null, null, new Guid("b7003b5f-1610-4487-9fd1-c03a6d0982d7"), "08/26" },
                    { new Guid("af3c41c0-0301-40c8-b4f0-d170177fddc7"), "541", "4477911583825881", null, null, new Guid("3af6d087-276b-42a2-9c69-d7501840f5a1"), "03/05" },
                    { new Guid("afcd346a-2efd-40f9-a723-35edffeb159a"), "319", "7371008112600307", null, null, new Guid("dca6b19f-e9ff-4d07-b3df-fe7e57f8b960"), "06/19" },
                    { new Guid("b04cf399-6407-486b-a7e0-996e471d8ef1"), "243", "7215983180380749", null, null, new Guid("0d9e85a0-24c2-4c10-b1f2-180d3ceeaaaf"), "01/11" },
                    { new Guid("b06a20cf-f052-4670-9351-65a610503946"), "409", "6386435502573313", null, null, new Guid("5dd3e047-c6f3-412d-b5cb-12b416f99706"), "04/16" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("b075e661-db96-4606-8d5b-79476fee6054"), "988", "4395334955073352", null, null, new Guid("7b9aa90c-3f91-430e-bbb3-c445e0de9d01"), "10/02" },
                    { new Guid("b103b550-b053-4d7a-b81b-f9670adaf087"), "261", "3856109922452084", null, null, new Guid("ae1ca1b0-7eff-4b3f-a0bd-d326d1ebe578"), "11/19" },
                    { new Guid("b1053dd9-b94b-44ff-b9e3-1dc7de378911"), "503", "5840060547762324", null, null, new Guid("dca6b19f-e9ff-4d07-b3df-fe7e57f8b960"), "02/22" },
                    { new Guid("b12d4e8b-cceb-4844-b8bd-542bb3a7c0aa"), "785", "8807312935900612", null, null, new Guid("371bed01-75b2-47b9-9535-3156b9a4c959"), "06/23" },
                    { new Guid("b146092a-d678-421e-aa69-7385ea3be066"), "193", "8104304661069884", null, null, new Guid("12f12b30-ab20-433f-91c1-e6f9be859390"), "02/04" },
                    { new Guid("b161677c-158a-43de-9f6c-3b1aebfd8629"), "325", "6239831644531296", null, null, new Guid("b89fe956-f020-4fc2-affd-e06c759e4081"), "05/24" },
                    { new Guid("b1859feb-ed69-459a-a4d7-ffacde091d17"), "846", "9728488307682544", null, null, new Guid("73953973-c12c-407d-b23d-97f5b010569d"), "12/04" },
                    { new Guid("b1d2f796-17e6-4783-950d-23df017811fb"), "259", "6319601179948480", null, null, new Guid("a4972888-e048-48a4-a351-23bd705a917e"), "06/12" },
                    { new Guid("b224f7b5-4ff0-41eb-b63d-fc8e8521c69a"), "098", "4678454646875209", null, null, new Guid("19d85480-882e-40f7-a536-84a552b3e447"), "11/11" },
                    { new Guid("b2b2a874-c924-440d-98fa-eda5f93a1524"), "517", "7716680930505949", null, null, new Guid("f070ec16-f59a-41c8-8ab6-b492f05b08e3"), "07/04" },
                    { new Guid("b3558e9a-5998-47eb-b9e7-7898ba428e75"), "575", "9607477964434357", null, null, new Guid("fbcf0085-dd67-4f41-b656-a0c0900baca5"), "09/23" },
                    { new Guid("b3f57886-610f-4cc4-9c5d-bd73ac6ec19e"), "983", "7806675063852173", null, null, new Guid("d50ea512-4841-4fdb-b6f1-1805a1f266cc"), "08/19" },
                    { new Guid("b42ff459-8ee8-4a84-82da-7d93f3373f03"), "371", "4177282649437519", null, null, new Guid("ab522845-c1bd-4f82-bee3-06f49429e4bf"), "01/07" },
                    { new Guid("b43f8919-5e91-4df3-a33b-80412138c2f9"), "826", "8303405740190003", null, null, new Guid("b89fe956-f020-4fc2-affd-e06c759e4081"), "08/13" },
                    { new Guid("b46c3784-4dfd-4fd3-be4d-c216dc1bd77e"), "467", "9707335974931489", null, null, new Guid("23dc6e61-4215-4b56-b081-13cd0b456e6f"), "05/01" },
                    { new Guid("b4754213-8a53-4733-9947-d4d5f2adf7fe"), "002", "2525329978156308", null, null, new Guid("1281e6c3-dc02-4e83-a90d-37f640411dfc"), "02/15" },
                    { new Guid("b48482b3-897e-4e23-ba5c-88a5935cbd91"), "767", "7201541781882935", null, null, new Guid("af67d494-10d3-4417-9f74-90816ee69f93"), "05/09" },
                    { new Guid("b4868557-36e0-47eb-b226-16b5d1a1f53e"), "826", "3096237820392105", null, null, new Guid("f088f668-331b-405e-b41a-5cc648df081c"), "02/18" },
                    { new Guid("b4c42e31-00ed-4937-aeb0-8ab188dfd772"), "981", "4039575433391322", null, null, new Guid("25a38376-e74c-46cc-8d4f-292cebbcdffb"), "09/25" },
                    { new Guid("b4ca4589-d2a8-4a7e-95c7-5a1091b1a301"), "470", "5033040988813739", null, null, new Guid("77a05cfa-406d-4342-a924-73d56bf2829a"), "05/23" },
                    { new Guid("b4fb7f55-6eb5-4e15-87cc-26e526b8ea72"), "726", "4721056528826345", null, null, new Guid("ab38dbfc-78a4-4d84-9e77-53448911bc9f"), "04/02" },
                    { new Guid("b5b09768-f1c5-4e55-8664-a88e0f6cd40f"), "783", "5700565741447264", null, null, new Guid("ab522845-c1bd-4f82-bee3-06f49429e4bf"), "06/25" },
                    { new Guid("b60eff03-423d-4135-a316-cf9280b1e903"), "364", "1417652665069063", null, null, new Guid("37f65b1e-268a-4a07-9f55-107b4df3c700"), "10/07" },
                    { new Guid("b6b7cf6a-dc83-4922-9446-b7321fd3efb5"), "172", "2086000459161494", null, null, new Guid("d6f2753c-e864-40f4-a45e-4096737598aa"), "01/25" },
                    { new Guid("b6db6f2c-9f40-4b04-9ecd-35a5eceb9e1f"), "655", "8692324928481512", null, null, new Guid("7d6ad8fc-e102-4ea8-a3e2-5bdfda8f1650"), "08/08" },
                    { new Guid("b71ae0c2-cb87-432f-a793-a85faaeb4a16"), "405", "4490152421068037", null, null, new Guid("9981eef1-0435-4903-9860-b16fb734ad1b"), "11/27" },
                    { new Guid("b735e094-4915-4683-8cd6-b7ec17b50442"), "473", "4749504492118071", null, null, new Guid("c6d62b30-8c4e-444d-a56a-cf5bea9f9c2a"), "05/12" },
                    { new Guid("b7360f9f-a2ac-4ca2-8a02-fcda9eb71470"), "197", "7318619425852000", null, null, new Guid("a0042a3d-7eaa-4c67-b018-40977ff2a846"), "08/18" },
                    { new Guid("b73c9b48-ad83-4722-8e59-36fe1e937c74"), "939", "4450994594001145", null, null, new Guid("af831e9b-a557-4f53-81e7-2278eb8802a1"), "05/22" },
                    { new Guid("b75e9da3-c6c3-4d76-857d-10da97cecb9b"), "792", "4589229605981616", null, null, new Guid("cffc8c5c-aee1-43fa-a247-e83b10ecb56e"), "06/17" },
                    { new Guid("b7771bd0-509c-402f-9a5a-6ec78d5b3f3d"), "785", "5066506026035951", null, null, new Guid("d50ea512-4841-4fdb-b6f1-1805a1f266cc"), "12/05" },
                    { new Guid("b7847cdf-7b58-4603-8303-32dac9fe66e3"), "644", "2799340162147432", null, null, new Guid("628d01f9-5feb-4e85-a1ac-d03470903a20"), "06/10" },
                    { new Guid("b7e3b38e-ea7b-4572-afe9-d2a00b3fe160"), "174", "9190725011513568", null, null, new Guid("6441d6d0-462e-4346-8bea-ddea048566dd"), "11/18" },
                    { new Guid("b7f73fcc-12f6-43b3-a0b6-11d08126d6bb"), "222", "9854938374837300", null, null, new Guid("00e8ecc6-7b14-4020-bcbd-1a849d69a8c6"), "04/25" },
                    { new Guid("b7f74cad-3903-4403-8632-d80df6fe761a"), "924", "4331950913963225", null, null, new Guid("7b9aa90c-3f91-430e-bbb3-c445e0de9d01"), "04/26" },
                    { new Guid("b92d416a-a59f-455c-a5e0-04b00ff8fd8e"), "007", "6496390682158043", null, null, new Guid("77a05cfa-406d-4342-a924-73d56bf2829a"), "04/08" },
                    { new Guid("b936fc7a-9ae4-4176-9b2a-39e03b115880"), "058", "2646693117151313", null, null, new Guid("58e47d27-16f3-4806-acf1-7b73ccbc0d5e"), "02/04" },
                    { new Guid("bab0e0cc-d9c1-4320-97c9-068e8b96b9bb"), "880", "6286408095651216", null, null, new Guid("ff5c3ca9-e336-4c0b-bb16-8a689eb03900"), "12/21" },
                    { new Guid("baecf99d-70d8-4521-a2ab-47077f233602"), "818", "5968822704283166", null, null, new Guid("2b62c42e-4571-4d98-bd8d-7ba20ea3e48b"), "06/22" },
                    { new Guid("bb1b1683-5701-40cc-9899-3c75adffcdd1"), "240", "2977458500869603", null, null, new Guid("8343d773-e986-49d8-99e9-bd908398b011"), "08/11" },
                    { new Guid("bb266f88-b378-46a5-984f-c051084c1bdc"), "008", "1637173006536673", null, null, new Guid("143cf7ff-f2e3-444c-a15b-3aa7b4c43475"), "06/02" },
                    { new Guid("bb298a17-07b3-47ef-8c19-a13806065ca6"), "232", "6233290883233549", null, null, new Guid("7d6ad8fc-e102-4ea8-a3e2-5bdfda8f1650"), "10/23" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("bb4eeb99-d8b5-4f4d-b270-2cb4d76bc0f3"), "035", "2451245350127061", null, null, new Guid("af831e9b-a557-4f53-81e7-2278eb8802a1"), "05/28" },
                    { new Guid("bc0da0a2-661e-494d-b4d5-daa956b73238"), "231", "7347575109796514", null, null, new Guid("ce3412db-b24b-4f68-8e32-724c140b7d0a"), "11/22" },
                    { new Guid("bc1adf25-7087-441d-8072-e9c19b670cd9"), "996", "8595019651930748", null, null, new Guid("4f7cd1ca-72e9-46bd-ab1e-ae8fa37d21a4"), "04/23" },
                    { new Guid("bc44ef1c-1a23-4925-9bd0-00fba9eaabd8"), "634", "1813028886495003", null, null, new Guid("4e8f092d-b1e1-47d3-9de6-5d9db26187a5"), "01/07" },
                    { new Guid("bc843f69-0687-4b1c-8ca9-473843ebcec3"), "542", "9001002223637303", null, null, new Guid("11b76a5d-870e-46d3-b3e3-0af0f8f871ac"), "09/20" },
                    { new Guid("bcca74e4-38cb-4f3d-b3d0-4554e0b98926"), "055", "7404255073953425", null, null, new Guid("1530b862-24b5-484d-8939-50315a49bd13"), "12/01" },
                    { new Guid("bdb07ae8-a5ea-4beb-a6e1-d4aebb758004"), "555", "3489125449190533", null, null, new Guid("b7003b5f-1610-4487-9fd1-c03a6d0982d7"), "09/21" },
                    { new Guid("be0e3f04-3574-46cc-9b23-49bf0eba4e8d"), "829", "1070385449576502", null, null, new Guid("a0042a3d-7eaa-4c67-b018-40977ff2a846"), "12/22" },
                    { new Guid("be7f9928-9245-4b43-b2ee-6c060ff014f7"), "205", "8604200791632644", null, null, new Guid("b40e13af-a00a-45af-a681-b960cb8d6a7b"), "01/19" },
                    { new Guid("be8b161c-5fde-43c3-b6ad-207e422385f0"), "486", "5956566533142787", null, null, new Guid("00e8ecc6-7b14-4020-bcbd-1a849d69a8c6"), "04/07" },
                    { new Guid("bfa10832-5ec1-498e-ad2d-c79f019b7d4e"), "741", "9494495462573599", null, null, new Guid("b7065d5a-6bbd-485c-bd51-6a4a0fc35e18"), "08/05" },
                    { new Guid("bfc609db-3e39-49a4-b7af-041accd8345e"), "450", "2933585460791192", null, null, new Guid("5398a079-6d82-4f82-8917-3f9eea9310eb"), "03/10" },
                    { new Guid("bfe96ff2-094b-4476-9967-a8c17c7fe3db"), "163", "4804023877096352", null, null, new Guid("af67d494-10d3-4417-9f74-90816ee69f93"), "04/20" },
                    { new Guid("c0529d8e-8a94-4d3f-bb79-231ba0c13b93"), "741", "8979995360796244", null, null, new Guid("3b1108de-e27d-4674-b7ff-c1df3b68ae41"), "08/26" },
                    { new Guid("c0907fe0-7a25-45d0-92e5-e77d8c0a8416"), "077", "9725395461730372", null, null, new Guid("7c403944-d570-486e-9c1f-e40454a443f6"), "10/23" },
                    { new Guid("c16056f5-07de-42d3-ba73-80c676cdad54"), "133", "2519029956002838", null, null, new Guid("40c86360-842c-49f4-a03e-2506f27e244d"), "05/07" },
                    { new Guid("c163294b-ba23-460c-b3bc-6ead13ce6619"), "403", "8238769136756744", null, null, new Guid("aa406ff8-810a-45a6-8b41-5028563ae3b6"), "09/04" },
                    { new Guid("c16b1b94-8fcb-40bb-8178-9860afe7d5ad"), "092", "7660579410773402", null, null, new Guid("a5e0abc8-bc40-47e6-bf22-077c758ba0a7"), "12/19" },
                    { new Guid("c2245942-e344-43b6-b609-6100ba9b1c59"), "795", "9670398299987300", null, null, new Guid("7c403944-d570-486e-9c1f-e40454a443f6"), "09/07" },
                    { new Guid("c224635e-fb94-4f6d-9bd4-344b4d1a9fa5"), "257", "4950607915647836", null, null, new Guid("dca6b19f-e9ff-4d07-b3df-fe7e57f8b960"), "12/15" },
                    { new Guid("c22b0d76-4849-44a8-b452-a5c6c28e53dd"), "920", "9657525817436889", null, null, new Guid("1548ab99-88de-44e5-8fb2-0ecadca929aa"), "10/21" },
                    { new Guid("c252bf9f-b833-4964-94c3-be07f25d72f5"), "821", "2270019825493071", null, null, new Guid("11e566bf-b29d-4651-8e8c-7f65a8281c80"), "07/10" },
                    { new Guid("c295e747-5758-41f5-ab6b-78b0942f9126"), "269", "7637626583779179", null, null, new Guid("65cb2c49-f00f-450e-94e8-540312a9ce09"), "08/13" },
                    { new Guid("c2d2248b-4ab8-43bc-93e1-aee374a1f12e"), "427", "3432189594369625", null, null, new Guid("b09cd69c-fd2f-4c43-9227-439aa81d485e"), "02/21" },
                    { new Guid("c2db8f84-c7df-48d7-9221-f949fa1f1fb5"), "179", "1702446649316990", null, null, new Guid("479adb19-03b9-482c-b165-7766492bfdf2"), "04/15" },
                    { new Guid("c2ecc999-2ca7-4b06-b38f-a5aa5374ba81"), "164", "4700734270270673", null, null, new Guid("750c9633-57cd-4cce-b195-c19394ee24b3"), "08/22" },
                    { new Guid("c3f04393-f83f-442b-b0c7-3d62631da40b"), "782", "5557089557120207", null, null, new Guid("4a3be526-6584-46c8-8a1d-041160609d8b"), "12/20" },
                    { new Guid("c491d215-83f3-4bea-9fa6-7ad058c4ac53"), "183", "4166458649709909", null, null, new Guid("89f14bfd-f2ad-40fc-8c24-b21398e3c7d3"), "10/23" },
                    { new Guid("c4968448-2669-4f49-a5cc-685408f42a69"), "110", "3410068381564736", null, null, new Guid("b2abd3eb-7d4b-49b1-8a46-4ea8b8313ab8"), "10/21" },
                    { new Guid("c4d93701-e74c-4f91-b852-44134c5fdb1f"), "557", "6893004952947789", null, null, new Guid("bdc35340-f998-4d2c-9ebc-c29624582c95"), "09/15" },
                    { new Guid("c5307903-b246-4ee6-9c5e-ca45e269f62a"), "365", "4754233401657054", null, null, new Guid("4a3be526-6584-46c8-8a1d-041160609d8b"), "09/24" },
                    { new Guid("c636c515-2609-4e5e-975f-c1d09a517238"), "655", "8942056894293408", null, null, new Guid("045fcec6-e944-4ba4-ab53-e930bdb298c6"), "03/14" },
                    { new Guid("c659fc50-4d23-45d8-8cbc-469d8eadb41e"), "377", "5918171298486672", null, null, new Guid("f498a63d-900c-464a-8fab-e4232968dc8b"), "09/25" },
                    { new Guid("c6d59abe-bb14-4f6f-8fd6-b21885ba8e74"), "674", "4475751973339526", null, null, new Guid("e0518a7c-2290-4dde-8de0-19fe26c3d8fa"), "09/14" },
                    { new Guid("c77c3865-f809-448c-9c90-138f966a7b98"), "504", "3118559272827261", null, null, new Guid("4f7cd1ca-72e9-46bd-ab1e-ae8fa37d21a4"), "02/28" },
                    { new Guid("c77fe7ab-a5ec-405b-aea2-ee3154cb489f"), "523", "1626434446683462", null, null, new Guid("9981eef1-0435-4903-9860-b16fb734ad1b"), "10/05" },
                    { new Guid("c78685cd-7d2b-4929-a4a2-c54751e59e9c"), "701", "3828862245213331", null, null, new Guid("e135b016-8e68-479f-a8e6-0c1dd16d5c2f"), "04/03" },
                    { new Guid("c792d778-eaf6-4031-a40a-50de1891c9e8"), "439", "3006761274992854", null, null, new Guid("09378928-71be-4297-b8fb-ea5311bf5963"), "08/25" },
                    { new Guid("c7f84904-ae52-4a82-8b56-4fc2b3acba12"), "434", "7507048876803966", null, null, new Guid("c4ec53d7-69be-4d5d-9091-29c7f80bd641"), "11/17" },
                    { new Guid("c841e6c4-41ac-4c7b-b896-a58b16cbb626"), "118", "9877437206803286", null, null, new Guid("64677ac4-f6ca-4452-9192-ce10eab5a7a4"), "09/16" },
                    { new Guid("c8e7dc0c-8133-4673-b7ae-c58a83a12019"), "880", "9347524681467634", null, null, new Guid("99d66586-6373-4afb-b333-7c5cb91075c4"), "05/18" },
                    { new Guid("c9111923-8058-4415-a51a-be813a474299"), "831", "2079320683112689", null, null, new Guid("23dc6e61-4215-4b56-b081-13cd0b456e6f"), "09/16" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("c9176f89-f7d1-4b46-a41e-0a1c7070cbfa"), "158", "4167273824246300", null, null, new Guid("ef8bcbb3-fff2-4f2c-aa48-9ad3e0312130"), "08/19" },
                    { new Guid("c9617929-5e36-4cbc-9519-5777192f2d18"), "381", "9424421484825669", null, null, new Guid("abfe1efb-0a8f-4af4-ab49-6de94e3ef374"), "07/19" },
                    { new Guid("c9714756-d394-4e47-9f69-de705f47c8a1"), "200", "2691320415820987", null, null, new Guid("fc6059ea-998b-4053-8aa0-faef98da998c"), "04/06" },
                    { new Guid("c9939c74-c05e-491e-9b30-06853290a148"), "541", "2274583737111706", null, null, new Guid("4e8f092d-b1e1-47d3-9de6-5d9db26187a5"), "07/08" },
                    { new Guid("ca2e345d-b00e-4377-9eaf-bb3c1160a96b"), "089", "2031354825269150", null, null, new Guid("1be28f90-0b14-4642-99f4-d8dd65c3d9f8"), "09/11" },
                    { new Guid("ca9eae13-8c7d-4d8e-8b9b-6acb5f5b6f0c"), "319", "1829302794515490", null, null, new Guid("96830fa4-dc91-4a31-8fad-9b956fd29c58"), "12/03" },
                    { new Guid("cae45f79-03e2-478f-a278-06df988a7957"), "493", "5297896359012041", null, null, new Guid("f3ea0004-e1e2-4557-a9d5-14a5369a2eb3"), "03/11" },
                    { new Guid("cb43ca08-97c0-472a-9d61-c2527814e99f"), "468", "1108158605367028", null, null, new Guid("7646ca6a-9ad5-4b77-91b7-839412348bed"), "09/06" },
                    { new Guid("cbb18070-f7d3-4401-8429-2264b59ed820"), "432", "9258237935660844", null, null, new Guid("85626191-e7df-461f-8d6e-58391f67d36a"), "10/09" },
                    { new Guid("cbd2a6c8-f2a8-4b48-a119-42f724c377d6"), "172", "5674038362300059", null, null, new Guid("8c149454-da44-4038-9ece-768e572c5282"), "01/28" },
                    { new Guid("cc548804-f372-44d4-8f8d-f211b76e21cf"), "503", "5190407567157284", null, null, new Guid("7d6ad8fc-e102-4ea8-a3e2-5bdfda8f1650"), "03/02" },
                    { new Guid("cc56160d-64d2-4ff1-aa80-ebd6da8b479d"), "930", "7705032029528769", null, null, new Guid("045fcec6-e944-4ba4-ab53-e930bdb298c6"), "09/21" },
                    { new Guid("cc6badcd-4062-42f5-bec2-b72458de6876"), "637", "3879101855241764", null, null, new Guid("fc6059ea-998b-4053-8aa0-faef98da998c"), "02/18" },
                    { new Guid("cc87cc68-e120-4c80-a460-0c3c724b42e8"), "557", "6290893040039082", null, null, new Guid("011fba87-398c-42ec-9aa7-ffb9c48fe9a9"), "03/05" },
                    { new Guid("cc892004-87d8-4e0c-9dc9-739e77be4826"), "330", "3468899925693199", null, null, new Guid("d799d7ce-936a-414f-86fd-958f17b3f642"), "01/09" },
                    { new Guid("cca7847b-da7f-4087-b1a5-0486dab7eb7e"), "765", "6582494424943683", null, null, new Guid("d173c22f-aa53-4e3b-b137-bcd6d2faf814"), "11/13" },
                    { new Guid("ccee6f94-2c28-46c2-ab9f-f95fe2ca94cb"), "683", "9080649083494131", null, null, new Guid("ff5c3ca9-e336-4c0b-bb16-8a689eb03900"), "03/07" },
                    { new Guid("cd094299-b0cb-45b9-bc2f-93b3c3f0753b"), "273", "4101577714944638", null, null, new Guid("8887b8ab-eb5d-41ad-bac2-3126e85117d1"), "01/02" },
                    { new Guid("cd3cea48-a969-4bad-9dac-66ea851d525e"), "692", "9360742338715063", null, null, new Guid("428063f6-fd3a-42bd-b0be-ba01a5e85a84"), "04/09" },
                    { new Guid("cd589afe-98be-46fd-8444-a84ae1d19ff4"), "212", "8428910134609344", null, null, new Guid("e6fc9f3f-e447-488c-a497-0bec2a6f9fea"), "01/25" },
                    { new Guid("cd818e92-34ea-40d6-934e-4b02f6b98c11"), "106", "3550749819178534", null, null, new Guid("ac4b1e96-68b1-4502-856c-10b88acf07fa"), "10/22" },
                    { new Guid("cd888bb8-61e0-44bd-9bdd-6e9749cae6f9"), "339", "1417131745870440", null, null, new Guid("8d7de522-82d8-4912-bf1a-5d80658097e7"), "06/09" },
                    { new Guid("cd8ced00-200b-4384-a0ab-bcc0ce06a083"), "280", "4819226037146107", null, null, new Guid("4b70366e-a511-4254-8c8d-ad820ee7b210"), "06/20" },
                    { new Guid("cdba624c-bd8d-45d8-b2de-a6348ff0f4c5"), "343", "8776101371709825", null, null, new Guid("8dea05e1-92c5-40d9-9159-8e1dcb818034"), "12/19" },
                    { new Guid("cdc8bfc8-76cc-4a10-adaa-b1fe5325fa67"), "496", "3811305354179673", null, null, new Guid("1070c404-0d57-4ba4-828e-4ca0d5ec2262"), "12/24" },
                    { new Guid("ce189713-1fbf-43a9-9c44-131f0d4906ce"), "561", "5282377011838244", null, null, new Guid("4a1c10a8-7cf3-42b7-9d73-0683e4bc1868"), "06/01" },
                    { new Guid("ce4d709a-cc04-4b1d-8603-5c4ef311fcd3"), "749", "2135891608411623", null, null, new Guid("11b76a5d-870e-46d3-b3e3-0af0f8f871ac"), "12/02" },
                    { new Guid("ceaf901c-f482-4ad3-9682-e76b556909dd"), "840", "4812377542616294", null, null, new Guid("c1169f01-6528-4f74-aa56-802f48a7ece8"), "04/13" },
                    { new Guid("d06d19ce-f583-419b-aa5e-5a589ec2edcb"), "162", "1848505628066766", null, null, new Guid("72c94cd8-c5e7-422d-b184-eeec7158816e"), "10/26" },
                    { new Guid("d06edfc2-48a4-405e-b73c-665f19412aa9"), "171", "2137452094094707", null, null, new Guid("68bf203c-5d15-452a-b81b-bb7831c4f579"), "07/18" },
                    { new Guid("d0fdb527-ee2a-4004-b745-4e285004afc6"), "756", "1960087305752337", null, null, new Guid("750c9633-57cd-4cce-b195-c19394ee24b3"), "10/23" },
                    { new Guid("d15fb150-dec0-4776-bbc2-b31a967b9388"), "629", "5926807160332688", null, null, new Guid("0dce50e5-ef29-456b-ab6f-c4454c5cfc38"), "03/19" },
                    { new Guid("d1736d96-2b2b-4694-95b6-9c72a3a87de5"), "457", "5583246378050850", null, null, new Guid("8d7de522-82d8-4912-bf1a-5d80658097e7"), "07/14" },
                    { new Guid("d185f840-8008-4ee9-a0a4-46702d02e616"), "544", "2956927556543617", null, null, new Guid("1548ab99-88de-44e5-8fb2-0ecadca929aa"), "07/26" },
                    { new Guid("d1e305b4-ca06-42f5-b425-aae8a8e55a3c"), "909", "5248547493902137", null, null, new Guid("34c24f57-b16e-4b0f-abe2-5cb9c260e918"), "01/26" },
                    { new Guid("d23c46d6-6917-4e75-a791-58acd0df6fe9"), "844", "8663528868687908", null, null, new Guid("c075bfdf-a5cc-4efb-a6d1-f31b0c4bf344"), "06/06" },
                    { new Guid("d24842cb-f580-4b98-b65e-727c9e09478d"), "903", "6327224474367620", null, null, new Guid("52fe76ad-4c09-4b99-9385-e407990c0307"), "08/06" },
                    { new Guid("d295074c-64ba-4d2b-a4d6-6f6ed99ea6b3"), "809", "8049856642373232", null, null, new Guid("d173c22f-aa53-4e3b-b137-bcd6d2faf814"), "02/23" },
                    { new Guid("d2c87d6d-60b8-4f92-b0e2-ae36a634b938"), "635", "4589383287904580", null, null, new Guid("53d8997e-27d6-4129-b5f1-0072e7f179bf"), "01/24" },
                    { new Guid("d2e677e1-c0ed-4cf3-92da-1b29ba898378"), "959", "8654297683338933", null, null, new Guid("651f4e42-b7be-4042-92c4-872c1b4a2b36"), "10/06" },
                    { new Guid("d2ec5cb6-01b6-48ed-9c88-68d01f01c642"), "251", "6249649684609562", null, null, new Guid("fce6a3fa-2769-41fb-ad0b-94fcfc2caab0"), "05/12" },
                    { new Guid("d42286f1-e2a5-42f5-b2b0-753eae542eba"), "343", "1049838046359945", null, null, new Guid("c7f2884a-d2aa-4aeb-80a7-44ed5d29e64a"), "01/04" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("d4821bd0-2667-4319-9f7d-206e00b0c28a"), "673", "4012683290015959", null, null, new Guid("ce108172-f4b7-4653-a5c3-ff603fbc3a50"), "07/26" },
                    { new Guid("d49547d1-d048-49b9-bfe8-08f30b2dcb78"), "566", "9285966859394238", null, null, new Guid("cc019092-2135-4dea-b991-c8b67614f148"), "11/02" },
                    { new Guid("d496ad1b-8394-4bd8-8883-e95ec3f085e2"), "085", "7462588581946122", null, null, new Guid("7646ca6a-9ad5-4b77-91b7-839412348bed"), "04/22" },
                    { new Guid("d5aeec77-279a-4eee-ac23-9bfbd7169813"), "976", "4080178116923841", null, null, new Guid("5146be01-925a-447f-b871-b7de98b487df"), "08/20" },
                    { new Guid("d5e646c8-cdce-4e59-9770-20b2a5395b88"), "255", "3823757290862393", null, null, new Guid("4f7cd1ca-72e9-46bd-ab1e-ae8fa37d21a4"), "03/15" },
                    { new Guid("d603b07c-b435-434e-9434-677a63f6cf40"), "212", "5900020894848043", null, null, new Guid("2b62c42e-4571-4d98-bd8d-7ba20ea3e48b"), "11/15" },
                    { new Guid("d67833cd-1020-457e-a93f-8231ef01bbd9"), "453", "6690631745456116", null, null, new Guid("4af3e803-6a3d-43c8-9c77-811cb6207644"), "10/06" },
                    { new Guid("d6d7f97d-6c98-4184-b027-d49ba0d83a12"), "828", "8147572475408917", null, null, new Guid("56460594-4f75-42d8-9106-e7e3ec02c12c"), "05/08" },
                    { new Guid("d8ce01a1-74e2-418f-8a71-f9cba20900c4"), "934", "8320996307040327", null, null, new Guid("0dce50e5-ef29-456b-ab6f-c4454c5cfc38"), "09/04" },
                    { new Guid("d8ee57b0-644f-4197-b291-6bbea1d1350c"), "382", "3275631508735712", null, null, new Guid("7c403944-d570-486e-9c1f-e40454a443f6"), "01/28" },
                    { new Guid("d90b3a17-40d7-48e6-893c-a393e30c991c"), "677", "4495072219515336", null, null, new Guid("20245acd-f749-41bb-8cfd-f436a4e71e96"), "07/24" },
                    { new Guid("d90cc713-a798-473f-acb9-5b06eab1f45f"), "906", "9547344346977415", null, null, new Guid("d02ec5f5-af87-4bcb-954a-b24e23737d68"), "10/06" },
                    { new Guid("d950789c-4564-4f0a-8c6d-0048aa96d606"), "424", "2018225873241186", null, null, new Guid("980f1926-46d3-48d9-880c-73d0be9fa1e0"), "01/16" },
                    { new Guid("d9a99af9-93dc-4a66-a71b-50565e5b76b8"), "422", "9317423882001893", null, null, new Guid("ea94f56c-ef76-423b-81af-2da80b37dfa6"), "08/01" },
                    { new Guid("d9e395d8-2f8e-42e4-8b99-df4c6f8f0482"), "717", "9246335915675215", null, null, new Guid("011fba87-398c-42ec-9aa7-ffb9c48fe9a9"), "12/13" },
                    { new Guid("da08e910-a748-4529-b31a-155d5c442c21"), "508", "5864411520661515", null, null, new Guid("54f16999-7e05-407e-aab8-1c56cdb79653"), "05/09" },
                    { new Guid("da4cd99d-431c-4e53-ae64-6a9e933b3f3a"), "396", "9550438859710975", null, null, new Guid("77f28b3f-3ca9-4819-96c6-bd1e811a39f5"), "07/08" },
                    { new Guid("da69f967-3174-4e9b-b38e-7cd883754fb9"), "172", "4306847090840666", null, null, new Guid("bdc35340-f998-4d2c-9ebc-c29624582c95"), "01/16" },
                    { new Guid("dac55635-399f-419d-8fb9-3f09a8340ee8"), "429", "4194298484525439", null, null, new Guid("cd6370e2-d6d7-4cbd-aaac-c3cf98e8cec3"), "10/25" },
                    { new Guid("dae8bac4-afbd-4cdb-9382-7859fe930560"), "048", "4784090970101022", null, null, new Guid("59e5a95d-f3ce-47fe-a7c9-70a6b47faac1"), "08/13" },
                    { new Guid("db22708e-7487-4a59-977d-4ecdf85d020c"), "005", "8520585343104788", null, null, new Guid("77a05cfa-406d-4342-a924-73d56bf2829a"), "10/11" },
                    { new Guid("dc5f8c91-91d5-4a54-9023-c45d9c263af1"), "617", "4020327749392086", null, null, new Guid("f5193487-04f8-4c23-b0cd-90340ebc9154"), "05/22" },
                    { new Guid("dcd96df7-2fb3-4210-9023-a8a0ce867128"), "529", "1538815925602514", null, null, new Guid("aa406ff8-810a-45a6-8b41-5028563ae3b6"), "05/28" },
                    { new Guid("ddbe8265-162a-43f7-9dae-84a478d8560a"), "299", "6905630060997632", null, null, new Guid("2f3d1b8f-7590-4d18-9002-4caa22511a8b"), "01/10" },
                    { new Guid("de13e496-c67d-41d6-8f8f-e270955597da"), "839", "2652315751715375", null, null, new Guid("6de94a05-0c03-4062-8ab9-57a5bd55b3a5"), "12/02" },
                    { new Guid("de3dcb04-dd89-482f-b529-aa74eafd5b9a"), "197", "1636475349977979", null, null, new Guid("e2fd10a1-4989-4088-ae2b-0b5909314728"), "07/23" },
                    { new Guid("de5e740c-edd5-4d43-877e-de490a688ba6"), "326", "7626194138114353", null, null, new Guid("045fcec6-e944-4ba4-ab53-e930bdb298c6"), "08/10" },
                    { new Guid("de72affa-5694-413f-bfc6-0428c1bf570b"), "212", "8997271843508602", null, null, new Guid("4a66fea0-71b8-4943-90c9-d349550e6fe9"), "08/07" },
                    { new Guid("debdf5e9-a48f-4c4e-9f2b-92b759248653"), "820", "7732423787926574", null, null, new Guid("a5e0abc8-bc40-47e6-bf22-077c758ba0a7"), "06/16" },
                    { new Guid("e02146df-28ae-4902-a1dc-5f0acde8e5b4"), "002", "1870608247944685", null, null, new Guid("b7f7d261-2525-4477-8b55-bba019231e9f"), "02/16" },
                    { new Guid("e02437e3-2c57-47f7-b348-e09d059c21e3"), "442", "6431663536172736", null, null, new Guid("9f2db745-dcf4-4a49-a27a-ae15a2f3087e"), "01/18" },
                    { new Guid("e061d447-83b5-42f9-9606-464916d3bfd1"), "833", "4075799046565044", null, null, new Guid("e6fc9f3f-e447-488c-a497-0bec2a6f9fea"), "07/14" },
                    { new Guid("e076a942-dab2-484c-a088-3f6d3ebc028d"), "183", "3155904853041029", null, null, new Guid("d02ec5f5-af87-4bcb-954a-b24e23737d68"), "02/09" },
                    { new Guid("e09741a6-af6a-4184-aaf1-553a5dc29aa4"), "616", "4261901210251812", null, null, new Guid("9336f657-bf13-4455-becf-1afff818911b"), "07/08" },
                    { new Guid("e0b33b7b-b29b-4ea8-87b4-f3dc37150c50"), "067", "7313572935464604", null, null, new Guid("7271d193-6a4b-40d9-ab91-a7d8a07e45bb"), "03/22" },
                    { new Guid("e0dbaae4-8675-427a-9dfb-d3a8cbee5318"), "851", "2849077382872430", null, null, new Guid("dda60091-f993-4d23-997a-ac4774d856d5"), "06/01" },
                    { new Guid("e1947124-fc34-4c6b-be7e-f4d1ffb42ebd"), "275", "3251723742079743", null, null, new Guid("52fe76ad-4c09-4b99-9385-e407990c0307"), "12/21" },
                    { new Guid("e21a8e88-ad7f-46e6-853b-345814de488e"), "944", "5553522212038680", null, null, new Guid("d52df32f-0260-40eb-8234-13ab7a744fcb"), "02/12" },
                    { new Guid("e22d1c68-1dde-4010-bea3-4617663b00e0"), "389", "9274528212951399", null, null, new Guid("a0042a3d-7eaa-4c67-b018-40977ff2a846"), "08/02" },
                    { new Guid("e25573e9-bacc-4861-8450-d6323637d289"), "776", "4941533234057821", null, null, new Guid("ea94f56c-ef76-423b-81af-2da80b37dfa6"), "11/02" },
                    { new Guid("e2c317dd-5042-4576-84a4-193eda74532b"), "258", "6126101027463023", null, null, new Guid("27f9e909-39f0-43df-afb3-3bc130e8da06"), "03/20" },
                    { new Guid("e2c38621-5cac-4743-b1d9-6c99f9f3fae8"), "869", "8874443235300032", null, null, new Guid("9f2db745-dcf4-4a49-a27a-ae15a2f3087e"), "06/15" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("e2f67477-16b1-41f8-ab9b-7d7603a623ca"), "781", "6752421442484919", null, null, new Guid("d572b4d3-7e7c-44d5-b1d1-164c1895424b"), "06/09" },
                    { new Guid("e31622db-7cbc-4ec5-b5ca-4f5763539d43"), "585", "9027904271486576", null, null, new Guid("58e47d27-16f3-4806-acf1-7b73ccbc0d5e"), "11/13" },
                    { new Guid("e592dc20-0a4b-46b5-b489-6f7c59325ab0"), "418", "8925722108247118", null, null, new Guid("9981eef1-0435-4903-9860-b16fb734ad1b"), "11/21" },
                    { new Guid("e5f8c471-ef6d-4c30-8d0d-dd0cdf65ec11"), "645", "3768188848567375", null, null, new Guid("a5e0abc8-bc40-47e6-bf22-077c758ba0a7"), "05/19" },
                    { new Guid("e638c968-edb6-42f8-8ecf-10999932e9c0"), "277", "5262327673279936", null, null, new Guid("b72dbc44-743b-4e39-a250-af429c1f09a9"), "02/11" },
                    { new Guid("e67ca6d2-339c-419f-9b1d-87ef630bd849"), "851", "4844707861667092", null, null, new Guid("db9ac887-f173-4f7b-ad02-6d19fdd7b12e"), "06/12" },
                    { new Guid("e6c962a0-6f21-4faa-8295-d5032bf9abec"), "999", "6488997528552990", null, null, new Guid("6ceec469-cfb3-42b5-b289-a4c2da0a32dc"), "11/01" },
                    { new Guid("e7934ad2-c05c-4680-9b76-fcb1dae67464"), "026", "6484818731910555", null, null, new Guid("a66e6d00-7000-4eb2-994b-a38594503957"), "09/23" },
                    { new Guid("e793be2e-274f-4550-9117-8f2a3add6faa"), "615", "2649680285221706", null, null, new Guid("750c9633-57cd-4cce-b195-c19394ee24b3"), "02/17" },
                    { new Guid("e7b0bb6e-4bed-419d-941a-a1dd6f24cc20"), "857", "9527883346070732", null, null, new Guid("7247fafb-5d1e-43fe-a447-5b99c26b77ba"), "04/02" },
                    { new Guid("e7f82aac-faf8-4e19-8016-bb4a5881fb12"), "103", "8856662067290432", null, null, new Guid("aa406ff8-810a-45a6-8b41-5028563ae3b6"), "09/05" },
                    { new Guid("e81c82fe-2e19-40a9-a3fe-bd1ef84c205c"), "204", "9246187335371476", null, null, new Guid("13164560-3eb6-4f4f-9c11-1f819fc48e22"), "12/10" },
                    { new Guid("e87d3042-1b16-421d-bad9-8d04a3ef5f60"), "490", "5522341877980638", null, null, new Guid("8c149454-da44-4038-9ece-768e572c5282"), "06/07" },
                    { new Guid("e8e0ad2c-198a-4c48-b648-4326e8688398"), "528", "8693416346840997", null, null, new Guid("7f857795-bd2a-48ee-bcf8-ec48fdb428ab"), "05/07" },
                    { new Guid("e948d4df-8a5d-4df3-9267-3c4a382e4749"), "425", "4078692647116402", null, null, new Guid("52fe76ad-4c09-4b99-9385-e407990c0307"), "12/16" },
                    { new Guid("e9838eae-f357-4ab1-a883-49847e529ad4"), "745", "7134384862509482", null, null, new Guid("7319b27d-6146-4420-aa8d-717913c33345"), "08/13" },
                    { new Guid("e98e9ea8-ceb5-48d6-9c8c-7963cf72964f"), "156", "8174195840505606", null, null, new Guid("1be28f90-0b14-4642-99f4-d8dd65c3d9f8"), "11/08" },
                    { new Guid("ea1404fa-381e-4948-be16-6670c4edca3f"), "639", "4112060355931807", null, null, new Guid("9336f657-bf13-4455-becf-1afff818911b"), "08/12" },
                    { new Guid("eab49cf2-dd5e-467d-bc11-e0e5737ad69d"), "870", "2577564564068918", null, null, new Guid("ddf155f2-6984-4582-b06c-39700b8ecb92"), "11/19" },
                    { new Guid("ead0376b-6b89-40aa-9d9c-c30278794e43"), "948", "7969583637122152", null, null, new Guid("bdd49191-641c-4843-a442-069a71c65be5"), "05/04" },
                    { new Guid("eafacff1-39ee-4e42-82d4-c25acaf0289a"), "258", "1916040037679667", null, null, new Guid("09378928-71be-4297-b8fb-ea5311bf5963"), "04/22" },
                    { new Guid("eb18693a-df2f-40bb-8860-838b867a2db6"), "461", "3631837720270604", null, null, new Guid("7247fafb-5d1e-43fe-a447-5b99c26b77ba"), "03/13" },
                    { new Guid("ec22a43d-a1fc-498f-8efa-0d6343517e84"), "306", "4883905221925685", null, null, new Guid("b2abd3eb-7d4b-49b1-8a46-4ea8b8313ab8"), "05/01" },
                    { new Guid("ed93b1c2-9ddc-49d8-a6b5-d0e2d1d19702"), "626", "5547616215838863", null, null, new Guid("abfe1efb-0a8f-4af4-ab49-6de94e3ef374"), "02/14" },
                    { new Guid("ed9d0b2a-481e-4c57-940a-8d8f02dddfc8"), "024", "1623262332600047", null, null, new Guid("4b70366e-a511-4254-8c8d-ad820ee7b210"), "03/18" },
                    { new Guid("ed9e6d9f-0a07-471b-a839-300789ce8296"), "222", "1700778665404992", null, null, new Guid("ea94f56c-ef76-423b-81af-2da80b37dfa6"), "12/13" },
                    { new Guid("edbf7fdb-72f9-45cf-8fea-8cabc95d110c"), "968", "5239072783277929", null, null, new Guid("4f750333-43c7-4b6d-871b-3959dea7a14e"), "01/18" },
                    { new Guid("edf0eb85-4baf-4a8b-a4f2-a61e9a652302"), "031", "9020732641666675", null, null, new Guid("f78b821b-0629-4e64-a36a-3d10ad04e07a"), "06/03" },
                    { new Guid("ee4fcdff-7e05-4136-846d-2d539d3d379b"), "813", "7037945357777674", null, null, new Guid("c4b80142-93ac-41b3-b29d-ff4cad905327"), "05/15" },
                    { new Guid("ee552c57-e1fa-4987-afad-b347f19a96f4"), "273", "1475317999620621", null, null, new Guid("7975589e-fce3-4ff6-8b4d-4f29aa2e3c37"), "04/19" },
                    { new Guid("ee925d3d-fa3c-4052-aca0-400abf4bf4af"), "869", "1861121000298336", null, null, new Guid("77a05cfa-406d-4342-a924-73d56bf2829a"), "01/23" },
                    { new Guid("eea92dfe-fa78-4936-9e1a-8bfa1a86bfa8"), "839", "2519483351624870", null, null, new Guid("c864b34c-ddf5-4af6-9a5f-d8251c512e8f"), "04/24" },
                    { new Guid("eedfc3b4-b25f-480b-96d6-6e4d8387c279"), "814", "1744337481803485", null, null, new Guid("ab38dbfc-78a4-4d84-9e77-53448911bc9f"), "05/28" },
                    { new Guid("ef6cf194-380d-487f-a8ff-646a7d1c9feb"), "762", "9353484342114721", null, null, new Guid("fbcf0085-dd67-4f41-b656-a0c0900baca5"), "10/04" },
                    { new Guid("ef87e47c-3d09-461c-bd17-717982e3fd51"), "317", "9041224878148912", null, null, new Guid("c7f2884a-d2aa-4aeb-80a7-44ed5d29e64a"), "05/06" },
                    { new Guid("efaa5f2a-35f1-4296-b7a9-1dcce87ac0b0"), "447", "6871941298774326", null, null, new Guid("ef8bcbb3-fff2-4f2c-aa48-9ad3e0312130"), "12/09" },
                    { new Guid("efb64d59-82fc-4870-b21f-c9ee90b0c5b7"), "232", "4057300370860215", null, null, new Guid("1fda2339-4864-46e3-bf7d-81a520206ae9"), "01/02" },
                    { new Guid("efe4f1e3-7a91-4bea-9333-48f699d8738d"), "803", "2978974229560203", null, null, new Guid("8c658576-57f3-41cc-9a3b-917efb1480d9"), "01/04" },
                    { new Guid("f003c307-374c-4b69-be6e-ab725ac357ab"), "380", "5196976648906063", null, null, new Guid("d52df32f-0260-40eb-8234-13ab7a744fcb"), "12/15" },
                    { new Guid("f05e9ee9-644a-4dba-bc26-081a567f5d28"), "119", "4102117638100909", null, null, new Guid("ea67b8fa-bc9a-4e27-8ba5-f3c2359c883a"), "09/09" },
                    { new Guid("f0dbb9d8-a051-4991-bf52-26bf60ab3373"), "333", "6926946089706736", null, null, new Guid("bfb2c3f3-d581-43c3-ad34-2b9af77e293a"), "09/25" },
                    { new Guid("f13053c8-aa32-4080-858e-fe00ab6d4693"), "714", "5481036556132632", null, null, new Guid("08fd0c31-2e97-4cfb-bbf0-9eca4d7bbf0c"), "06/27" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("f136dfe3-50c6-45ac-8832-14a9b59f8640"), "581", "9968587290009268", null, null, new Guid("8b82d9a1-181d-4f54-aa69-032bffd3d9d4"), "06/20" },
                    { new Guid("f1e60ce2-9638-4ff8-9c4d-0f4405c16224"), "726", "8046369455869962", null, null, new Guid("72c94cd8-c5e7-422d-b184-eeec7158816e"), "12/23" },
                    { new Guid("f1f2d03f-875c-4d19-b101-6c09bee98451"), "023", "1141024236541396", null, null, new Guid("13164560-3eb6-4f4f-9c11-1f819fc48e22"), "07/22" },
                    { new Guid("f21750b4-1c57-42df-8fa2-5e7f8fd7910d"), "663", "3892706273665193", null, null, new Guid("7f857795-bd2a-48ee-bcf8-ec48fdb428ab"), "12/27" },
                    { new Guid("f21e11fe-834e-41d9-b32d-6edb9dfe0224"), "947", "2801165846824261", null, null, new Guid("e2fd10a1-4989-4088-ae2b-0b5909314728"), "12/13" },
                    { new Guid("f27b5601-67a3-403a-a2e6-9ee4f615931f"), "072", "9205130970681349", null, null, new Guid("2effe328-1bb8-4f90-8e5e-a133fd94d1df"), "07/20" },
                    { new Guid("f2cf7bf4-2a42-4ed1-ac3e-b88c9253d3c3"), "566", "4507950518670764", null, null, new Guid("11b76a5d-870e-46d3-b3e3-0af0f8f871ac"), "09/17" },
                    { new Guid("f2d2c4ed-d343-48b8-a485-08e6c3619666"), "479", "7720674309846705", null, null, new Guid("2956754d-e1ca-4623-bbe4-691ff14c9d29"), "09/05" },
                    { new Guid("f2ec3e8d-39b7-4310-b583-3831e9a18024"), "028", "2502944795929078", null, null, new Guid("5d61541c-3ac1-459c-b0d4-0bbe121306da"), "10/23" },
                    { new Guid("f2f543ff-a1c9-426c-a902-67d41431d406"), "211", "6990404496801495", null, null, new Guid("1070c404-0d57-4ba4-828e-4ca0d5ec2262"), "05/13" },
                    { new Guid("f364efce-28d1-4f79-bf04-94ddd0506e58"), "442", "9660015919625695", null, null, new Guid("2078228d-bb74-4e81-8e84-3dd4a76ea271"), "11/04" },
                    { new Guid("f3c0a8b9-29a2-4981-bbde-ed6803e63185"), "413", "5406797019994284", null, null, new Guid("3b1108de-e27d-4674-b7ff-c1df3b68ae41"), "12/01" },
                    { new Guid("f3d825ee-3d9c-4936-82e3-f8486d4cc3f1"), "918", "9084179904812333", null, null, new Guid("9252c306-249a-4267-8ef5-891d8c0cbea1"), "04/04" },
                    { new Guid("f4763b57-963b-4f31-8c42-89ca0d1d26b4"), "159", "9818282778421114", null, null, new Guid("56780bb1-6c9e-4f24-a024-e244137c0516"), "06/22" },
                    { new Guid("f49694dc-a6e0-4ab3-b817-acc5f0727c6b"), "338", "5828879086269516", null, null, new Guid("7f1920c1-828a-4d44-abe8-9db2c3bea2a0"), "01/22" },
                    { new Guid("f4a66ed1-1117-4f71-9b00-05b03a25cd0a"), "573", "3644647284856517", null, null, new Guid("2effe328-1bb8-4f90-8e5e-a133fd94d1df"), "11/07" },
                    { new Guid("f4d1aa8e-5aff-4591-9305-ac394fd5f063"), "549", "6692524608571681", null, null, new Guid("09e536d1-50fd-453a-80d5-e8283f64b0da"), "05/05" },
                    { new Guid("f4e6c9fc-a689-4458-9caa-3aa8dcc2b140"), "550", "8224227172052934", null, null, new Guid("f8c234a1-e25c-478d-be01-cda21178c47a"), "12/14" },
                    { new Guid("f4f497df-e23a-424d-85f1-46781f6c4de8"), "231", "3950110634352441", null, null, new Guid("371bed01-75b2-47b9-9535-3156b9a4c959"), "07/25" },
                    { new Guid("f55386f7-d2e8-463c-a24c-9fc10b4c44a5"), "439", "8475025489970364", null, null, new Guid("b40e13af-a00a-45af-a681-b960cb8d6a7b"), "11/16" },
                    { new Guid("f63a66fe-de97-443b-995e-fb97195d9882"), "298", "1903988462563324", null, null, new Guid("59e5a95d-f3ce-47fe-a7c9-70a6b47faac1"), "07/18" },
                    { new Guid("f652f854-a97f-43fa-ab0d-cb2644008557"), "727", "6796582265527565", null, null, new Guid("b9a99c94-3031-4da9-bdf3-33bb288dd6a9"), "11/13" },
                    { new Guid("f6ae2ca6-6936-4798-9b49-476a071b9dd7"), "056", "6207993459175366", null, null, new Guid("ddf155f2-6984-4582-b06c-39700b8ecb92"), "09/04" },
                    { new Guid("f6c66944-5fe8-4a11-810e-4bc405d0e5d9"), "937", "3029226748454794", null, null, new Guid("f498a63d-900c-464a-8fab-e4232968dc8b"), "12/21" },
                    { new Guid("f6caa450-5479-44af-b902-e243044df0d5"), "204", "2008803279562711", null, null, new Guid("5146be01-925a-447f-b871-b7de98b487df"), "05/20" },
                    { new Guid("f6db8a20-ba1b-4eae-ac20-d1523cde654c"), "830", "3731036954988267", null, null, new Guid("7e04a2e8-5af7-4c5e-8b81-d51fb8eb210b"), "09/08" },
                    { new Guid("f6fa38f7-221c-48c5-938e-d118947361bd"), "442", "1551777271366188", null, null, new Guid("f78b821b-0629-4e64-a36a-3d10ad04e07a"), "08/03" },
                    { new Guid("f7aca5d8-5882-4e24-b89c-4a1e8be4db1a"), "724", "4023741187006965", null, null, new Guid("712b2e8f-feec-4b44-842e-63c59bbe48cb"), "09/12" },
                    { new Guid("f84384b5-c569-46ea-ad84-1c86fd87013a"), "543", "6819938025823458", null, null, new Guid("d9b74426-c418-4b51-a42a-af5906c2fcff"), "06/24" },
                    { new Guid("f8ea56be-075e-4c3a-884c-155924d9f487"), "132", "5016342024345601", null, null, new Guid("9252c306-249a-4267-8ef5-891d8c0cbea1"), "12/08" },
                    { new Guid("f8f4cb20-a39b-4255-864a-71a486ba6ec6"), "846", "1294170894079965", null, null, new Guid("ea67b8fa-bc9a-4e27-8ba5-f3c2359c883a"), "07/26" },
                    { new Guid("f900be4b-1f13-440a-9085-941660835f4d"), "979", "5531443498306722", null, null, new Guid("c78c659a-335a-4de3-940d-5ed29586f5d9"), "07/03" },
                    { new Guid("f90d4780-92b7-4173-b448-1bca8e148ec1"), "289", "3557218803581414", null, null, new Guid("ce3412db-b24b-4f68-8e32-724c140b7d0a"), "08/01" },
                    { new Guid("f96c495b-53cc-430b-b699-33b55a0a403f"), "079", "3082466440484546", null, null, new Guid("f498a63d-900c-464a-8fab-e4232968dc8b"), "11/15" },
                    { new Guid("f9b09b40-6127-4942-a27f-9883ca7ee561"), "686", "8853461284335028", null, null, new Guid("60c86293-9017-4722-ad96-c09fd6051a5b"), "08/27" },
                    { new Guid("f9cb4076-3a70-465c-a533-dcb76b2ddcd8"), "698", "5123162145352648", null, null, new Guid("7adbc5f0-6d2f-4d16-ad51-1b76edd52481"), "11/16" },
                    { new Guid("fa0c26e2-0a05-4fd0-bdad-2f40b8884123"), "561", "8109349603273425", null, null, new Guid("7f1920c1-828a-4d44-abe8-9db2c3bea2a0"), "08/23" },
                    { new Guid("fa6c5fba-e8ea-4eb8-a6ec-9fc1edf0925e"), "289", "4139075932558433", null, null, new Guid("ce3412db-b24b-4f68-8e32-724c140b7d0a"), "05/05" },
                    { new Guid("fa96421a-40e0-4f97-9015-f3057ac7ddd7"), "012", "2493123660803570", null, null, new Guid("1de915db-ea78-41e7-a3a2-76a8f6311629"), "08/16" },
                    { new Guid("fae26332-e32f-4f8e-960d-b318b1374e07"), "378", "4454556605183593", null, null, new Guid("25a38376-e74c-46cc-8d4f-292cebbcdffb"), "07/14" },
                    { new Guid("fb37c5b5-7fb3-4481-98fb-306d4d70abaa"), "409", "5100721100924945", null, null, new Guid("6d64cb25-3e39-4da8-a0e1-a3ee13dd1071"), "07/16" },
                    { new Guid("fb5a056b-b2f7-46d9-9cbe-a305ef975359"), "548", "6835027691563284", null, null, new Guid("37f65b1e-268a-4a07-9f55-107b4df3c700"), "06/01" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("fb6787be-527d-45b9-b4c0-44122178f3b5"), "811", "3735484088564014", null, null, new Guid("1281e6c3-dc02-4e83-a90d-37f640411dfc"), "07/01" },
                    { new Guid("fb95fb04-65a9-4142-a7c9-252198fb7b62"), "943", "8967079279553212", null, null, new Guid("09ff0b03-eca3-4596-9c5d-d809a2f99a1e"), "11/01" },
                    { new Guid("fce20851-9725-4963-9e1e-843d39590dc5"), "558", "5847867431604308", null, null, new Guid("ddf155f2-6984-4582-b06c-39700b8ecb92"), "06/02" },
                    { new Guid("fd174fdc-d0d9-445a-997d-e451a5dd0a52"), "911", "7621906831080349", null, null, new Guid("efacb463-5422-4958-902a-44c5cd16f26b"), "09/20" },
                    { new Guid("fd3ab549-c2fc-47b2-b420-860c64f29856"), "899", "8495962734019508", null, null, new Guid("2293afe4-2408-427c-9960-7223d1291070"), "09/03" },
                    { new Guid("fd762597-32f5-486d-b8d4-7fd82dfb5ed0"), "621", "2479065492989460", null, null, new Guid("2293afe4-2408-427c-9960-7223d1291070"), "10/04" },
                    { new Guid("fd7d00d8-4b2e-4cf3-8b1c-17c0f2ba6f85"), "639", "3580022979181112", null, null, new Guid("92fa424c-9623-4989-b9fe-494533664c26"), "07/27" },
                    { new Guid("fd941032-cd45-4f1e-ae15-44757e07476d"), "569", "2388324128858899", null, null, new Guid("0fedadae-5c91-4999-9924-42f5fcd0de5b"), "07/25" },
                    { new Guid("fe2d7889-78e7-4b70-98ba-28d4e6a62bb7"), "639", "3159354126458309", null, null, new Guid("5c53533c-cf33-43f0-bdab-260275d90d88"), "04/20" },
                    { new Guid("fe32eb9e-f86e-464d-85fd-d76ae7323f6e"), "935", "8337295168604605", null, null, new Guid("a339ea33-3188-40c2-9d84-9ea46aa67e82"), "01/05" },
                    { new Guid("fe733bb9-c714-47f2-a4e6-6b6fad7ebbc9"), "265", "5460265646480859", null, null, new Guid("39fc9708-01f3-4ab0-8c26-d5bc00da55db"), "08/23" },
                    { new Guid("feb2f627-5c0e-4919-a726-4823f16f311b"), "850", "5810190301234578", null, null, new Guid("4f1ac364-cc01-4a40-a229-d66da5446413"), "01/15" },
                    { new Guid("feefea34-0ebe-4ecb-b69c-743d65bb8584"), "127", "5290142375689909", null, null, new Guid("5210b0bd-a591-4887-9abb-0f4415c0f467"), "06/03" },
                    { new Guid("ff33d42b-c541-4656-8f51-fa89727f6fe6"), "749", "1944804688472163", null, null, new Guid("750c9633-57cd-4cce-b195-c19394ee24b3"), "01/24" },
                    { new Guid("ff6a23e6-2c08-46aa-98d3-0899ace32d98"), "561", "9336575777884725", null, null, new Guid("22a1446b-6ffd-488e-8e70-011276aa0ae3"), "12/01" },
                    { new Guid("ff8afb0c-c068-47d0-97cd-b37ea2a4e915"), "350", "7732964770471957", null, null, new Guid("09ee89cc-9f4d-4eae-a4f3-731ca2d52102"), "04/24" }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("001d2d1d-1e75-4122-892c-e7f2de05f56e"), null, null, "+273 37 (526) 89-85", new Guid("3359f4d4-fbc1-4174-b3e0-8cc3754ac07b") },
                    { new Guid("0034ef38-66de-4fd3-831d-567fd6c6c5a0"), null, null, "+373 72 (183) 04-51", new Guid("aa406ff8-810a-45a6-8b41-5028563ae3b6") },
                    { new Guid("009b612b-a969-4623-bda5-f3fe7f9536b9"), null, null, "+119 69 (878) 46-01", new Guid("0edec355-b022-4255-80d6-c530f687d26e") },
                    { new Guid("00bbba46-7d4f-4672-b327-2168058e49ab"), null, null, "+45 76 (846) 99-14", new Guid("85626191-e7df-461f-8d6e-58391f67d36a") },
                    { new Guid("01343120-5084-4d22-8865-6f648963005b"), null, null, "+344 29 (473) 33-99", new Guid("ab522845-c1bd-4f82-bee3-06f49429e4bf") },
                    { new Guid("01d66214-cff2-4e6b-ac6c-1b2388b733f0"), null, null, "+825 05 (723) 43-59", new Guid("7d6ad8fc-e102-4ea8-a3e2-5bdfda8f1650") },
                    { new Guid("01e18caa-3b4f-4ca7-82db-72de85883883"), null, null, "+82 58 (191) 57-27", new Guid("f8c6be38-3b48-44ea-9af5-7fd644c82034") },
                    { new Guid("02497f2f-16c9-4509-8235-0f1da0f9da18"), null, null, "+456 15 (818) 38-00", new Guid("a0d3cad9-30ac-4da2-8952-dcde6122a64a") },
                    { new Guid("0269ca80-b9a9-4209-857b-faf3b4119e74"), null, null, "+853 40 (261) 48-58", new Guid("df2bde0b-bda8-499f-b5cc-cfa7429222d1") },
                    { new Guid("028ab375-51a3-4dac-8aab-8a3d1c4d13e6"), null, null, "+779 05 (257) 08-37", new Guid("4595bfbb-3a7d-407e-b6e6-b5d06b0ded5d") },
                    { new Guid("02afae9f-d6f7-44b7-80e8-06e6aabb32d9"), null, null, "+961 82 (147) 81-38", new Guid("f78b821b-0629-4e64-a36a-3d10ad04e07a") },
                    { new Guid("02e803d1-e0e1-40a2-87ef-9ec918b49e80"), null, null, "+593 95 (120) 63-62", new Guid("428063f6-fd3a-42bd-b0be-ba01a5e85a84") },
                    { new Guid("0366a1ce-c9bb-41ba-a017-a455632e037f"), null, null, "+81 98 (058) 01-06", new Guid("5398a079-6d82-4f82-8917-3f9eea9310eb") },
                    { new Guid("0461bb5c-ecc2-4c08-9e92-a41d4905a179"), null, null, "+796 01 (784) 09-33", new Guid("922f53da-9877-4d56-a64d-6d83331bdbb6") },
                    { new Guid("04db3ada-051b-4459-8e17-b106a25edbda"), null, null, "+226 26 (101) 79-30", new Guid("d6f2753c-e864-40f4-a45e-4096737598aa") },
                    { new Guid("04f1755b-dfa2-408e-943f-1c1d10ce7158"), null, null, "+941 16 (249) 98-38", new Guid("2a79982f-f343-4569-a725-228ecab03718") },
                    { new Guid("051036fd-c397-4d56-9fcd-20e212c7847e"), null, null, "+269 48 (987) 47-27", new Guid("3af6d087-276b-42a2-9c69-d7501840f5a1") },
                    { new Guid("05c24a41-ca16-4167-bac1-8f8f5fdb9b63"), null, null, "+119 83 (072) 32-72", new Guid("af867e87-ddef-4efe-ba16-9ce831f47443") },
                    { new Guid("06185810-8704-4f91-bf5f-88073e6a885c"), null, null, "+249 30 (090) 39-30", new Guid("6127ea05-85cc-4ed4-9b13-5998aee91180") },
                    { new Guid("061af8e5-2917-418e-884b-5768d5ac85fc"), null, null, "+586 86 (781) 15-70", new Guid("712b2e8f-feec-4b44-842e-63c59bbe48cb") },
                    { new Guid("06283d1b-8e38-4f56-afe5-d6e7f08ba002"), null, null, "+31 55 (614) 64-40", new Guid("fa671618-4f8c-472d-aad1-18adb7778e70") },
                    { new Guid("0629323e-bdea-4c36-96c9-889e0c928d9e"), null, null, "+807 41 (638) 96-05", new Guid("4f7cd1ca-72e9-46bd-ab1e-ae8fa37d21a4") },
                    { new Guid("06527caa-8150-418d-9c4a-5f688e0b7028"), null, null, "+62 24 (553) 71-82", new Guid("17f01111-498c-4286-9021-ec1a09f4b1ca") },
                    { new Guid("069d6d4b-6e78-41da-99ab-1770befef40a"), null, null, "+39 12 (913) 22-99", new Guid("a0d3cad9-30ac-4da2-8952-dcde6122a64a") },
                    { new Guid("06ad37ac-7c37-4aeb-83bc-c0989c69d65e"), null, null, "+572 45 (198) 96-64", new Guid("7319b27d-6146-4420-aa8d-717913c33345") },
                    { new Guid("06b08d3d-42c4-49c2-9f3b-b4de0286e30e"), null, null, "+317 91 (500) 26-04", new Guid("23dc6e61-4215-4b56-b081-13cd0b456e6f") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("06d2b8a9-68be-4577-a8ef-a7188583dd31"), null, null, "+896 51 (154) 83-55", new Guid("4f1ac364-cc01-4a40-a229-d66da5446413") },
                    { new Guid("07569487-1611-4493-ac61-e7b361f1a50a"), null, null, "+914 88 (426) 34-51", new Guid("0fedadae-5c91-4999-9924-42f5fcd0de5b") },
                    { new Guid("07982b27-b97b-49fe-aa35-1937b6127b1b"), null, null, "+416 42 (143) 73-11", new Guid("49e9f216-cefc-4a4e-a243-81e78152afb7") },
                    { new Guid("08013473-9455-41fa-8b17-9756fe310915"), null, null, "+513 25 (583) 30-09", new Guid("0d9e85a0-24c2-4c10-b1f2-180d3ceeaaaf") },
                    { new Guid("08655145-6abd-4139-a2ec-bf143e41d8b0"), null, null, "+681 46 (932) 85-76", new Guid("ab38dbfc-78a4-4d84-9e77-53448911bc9f") },
                    { new Guid("0937d5be-0cdf-47af-ba52-154c87d72928"), null, null, "+622 86 (699) 68-73", new Guid("045fcec6-e944-4ba4-ab53-e930bdb298c6") },
                    { new Guid("093c25ba-0840-46cc-8aef-5e9fa585e818"), null, null, "+857 86 (542) 62-58", new Guid("8343d773-e986-49d8-99e9-bd908398b011") },
                    { new Guid("096785bf-6944-4295-890e-5a8885e9cb29"), null, null, "+45 95 (148) 58-70", new Guid("20245acd-f749-41bb-8cfd-f436a4e71e96") },
                    { new Guid("09ac0d9e-31a2-4ae9-a539-672c8b52ae7d"), null, null, "+316 53 (915) 56-04", new Guid("65cb2c49-f00f-450e-94e8-540312a9ce09") },
                    { new Guid("09b0d492-ec50-4d7a-8120-580b2c79ef51"), null, null, "+546 51 (543) 55-17", new Guid("ab38dbfc-78a4-4d84-9e77-53448911bc9f") },
                    { new Guid("0a2b89aa-8a59-4fd0-8be6-6e1aad523a8b"), null, null, "+416 56 (351) 53-39", new Guid("2f3d1b8f-7590-4d18-9002-4caa22511a8b") },
                    { new Guid("0a6e2218-c855-4e15-978c-35d017f22d3d"), null, null, "+231 29 (124) 58-91", new Guid("60c86293-9017-4722-ad96-c09fd6051a5b") },
                    { new Guid("0af44583-293d-42e5-be99-ebb6b80dd59c"), null, null, "+158 34 (246) 70-06", new Guid("b7003b5f-1610-4487-9fd1-c03a6d0982d7") },
                    { new Guid("0b0781d9-e5c3-48e0-a8ea-8fa3bcbbfa39"), null, null, "+684 19 (623) 07-62", new Guid("6ceec469-cfb3-42b5-b289-a4c2da0a32dc") },
                    { new Guid("0b1c10a2-8df6-4c69-bd0f-d5e75fa2e7dc"), null, null, "+739 39 (254) 28-98", new Guid("56460594-4f75-42d8-9106-e7e3ec02c12c") },
                    { new Guid("0b6e7770-24a5-4568-8f6d-3d0a565a9e7d"), null, null, "+81 04 (336) 45-57", new Guid("ea94f56c-ef76-423b-81af-2da80b37dfa6") },
                    { new Guid("0bbd4229-121e-4a12-ab02-85c888799cd4"), null, null, "+571 45 (601) 81-77", new Guid("73953973-c12c-407d-b23d-97f5b010569d") },
                    { new Guid("0c659d68-e26f-4ca5-ae08-9bec4646e8fe"), null, null, "+35 91 (859) 09-32", new Guid("a339ea33-3188-40c2-9d84-9ea46aa67e82") },
                    { new Guid("0c8737d2-e3cb-4a7a-8906-fc7f4ea2d78a"), null, null, "+730 71 (024) 36-11", new Guid("b09cd69c-fd2f-4c43-9227-439aa81d485e") },
                    { new Guid("0cc8251a-821e-4995-b6c5-1cc67c731e30"), null, null, "+735 91 (863) 93-73", new Guid("045fcec6-e944-4ba4-ab53-e930bdb298c6") },
                    { new Guid("0cf4a22f-4bea-4546-b504-f4ce1dbef583"), null, null, "+417 82 (506) 44-78", new Guid("4e8f092d-b1e1-47d3-9de6-5d9db26187a5") },
                    { new Guid("0d0e6db9-57d8-4525-a646-263a6fd471f9"), null, null, "+61 01 (943) 41-63", new Guid("0c210681-d608-4ef0-acaa-f6ca1d403524") },
                    { new Guid("0d93da83-062c-4215-a4f5-7bd0c4cb2b98"), null, null, "+641 55 (237) 33-18", new Guid("27f9e909-39f0-43df-afb3-3bc130e8da06") },
                    { new Guid("0df284d9-fd52-4237-b164-7ce354bf4d07"), null, null, "+596 09 (876) 28-92", new Guid("7adbc5f0-6d2f-4d16-ad51-1b76edd52481") },
                    { new Guid("0ee74c13-3d8d-48fb-8f5d-e4057e7aa00f"), null, null, "+427 34 (595) 08-44", new Guid("bdc35340-f998-4d2c-9ebc-c29624582c95") },
                    { new Guid("0ef60694-9161-465f-b08b-396efa705023"), null, null, "+382 06 (430) 69-21", new Guid("a907043f-86ba-4126-baac-6e2c6eb5871c") },
                    { new Guid("0ef88a71-8d42-4b76-860a-34e72ebe0194"), null, null, "+797 62 (156) 42-14", new Guid("c864b34c-ddf5-4af6-9a5f-d8251c512e8f") },
                    { new Guid("0f7bb0d3-81b1-4ff6-8333-2d320c267533"), null, null, "+808 78 (905) 05-96", new Guid("fa671618-4f8c-472d-aad1-18adb7778e70") },
                    { new Guid("0f87a32c-99f8-4b50-9147-9d631799a2bb"), null, null, "+911 62 (953) 83-81", new Guid("c7f2884a-d2aa-4aeb-80a7-44ed5d29e64a") },
                    { new Guid("0fcb7e2a-d1b1-4dd5-b678-ddbc1cf8f7a9"), null, null, "+279 43 (963) 00-90", new Guid("40de2c6f-e29d-4027-93c3-945e76ec015c") },
                    { new Guid("108e262c-7b68-4bf9-b024-b8c9d3ae02db"), null, null, "+636 83 (804) 38-54", new Guid("59e5a95d-f3ce-47fe-a7c9-70a6b47faac1") },
                    { new Guid("10d549c1-2d03-494b-8aa8-4152cc6bd2b6"), null, null, "+611 90 (426) 10-70", new Guid("6de94a05-0c03-4062-8ab9-57a5bd55b3a5") },
                    { new Guid("1156ede1-8cde-4049-8ba8-b6175eacc77e"), null, null, "+346 62 (086) 51-84", new Guid("ddf155f2-6984-4582-b06c-39700b8ecb92") },
                    { new Guid("116a165c-e301-4c0a-aefc-811fb2968d57"), null, null, "+197 98 (234) 77-02", new Guid("d9b74426-c418-4b51-a42a-af5906c2fcff") },
                    { new Guid("119f289a-f9e8-4a7b-90f1-ab15ef0a5195"), null, null, "+154 22 (838) 36-01", new Guid("600649dd-c6d1-4ff3-9144-03f6ff7e6950") },
                    { new Guid("1259fc1a-44e9-45e6-b866-a26e28d95299"), null, null, "+885 46 (837) 68-20", new Guid("60c86293-9017-4722-ad96-c09fd6051a5b") },
                    { new Guid("139df0cf-0a2e-425a-906c-5cc6fd8a48d4"), null, null, "+1 98 (926) 22-27", new Guid("c6d62b30-8c4e-444d-a56a-cf5bea9f9c2a") },
                    { new Guid("139e5546-7803-4932-aa14-440f5ab7bb94"), null, null, "+642 51 (124) 43-40", new Guid("c6d62b30-8c4e-444d-a56a-cf5bea9f9c2a") },
                    { new Guid("13a38175-bc14-4965-a0fa-918d6e2536d7"), null, null, "+400 64 (861) 16-89", new Guid("bdd49191-641c-4843-a442-069a71c65be5") },
                    { new Guid("14220c58-93dc-4d26-972a-47f3b33f531b"), null, null, "+65 05 (879) 09-49", new Guid("af831e9b-a557-4f53-81e7-2278eb8802a1") },
                    { new Guid("146234c3-e8a3-4845-b918-ab1c210423d6"), null, null, "+2 33 (898) 11-59", new Guid("7e04a2e8-5af7-4c5e-8b81-d51fb8eb210b") },
                    { new Guid("15737860-ce4c-483b-9405-8a96739d2b14"), null, null, "+498 72 (038) 43-69", new Guid("1281e6c3-dc02-4e83-a90d-37f640411dfc") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("15d2eedb-905d-449c-a88a-916c85566677"), null, null, "+834 83 (022) 80-23", new Guid("b09cd69c-fd2f-4c43-9227-439aa81d485e") },
                    { new Guid("15e0b5b0-d712-49d4-8565-99653c3edb37"), null, null, "+85 17 (007) 89-84", new Guid("7a4f4be1-0c5d-43fb-8b70-3e4913ca97a0") },
                    { new Guid("15fc0800-064a-481b-8841-a047028b6d27"), null, null, "+979 34 (834) 62-27", new Guid("1de915db-ea78-41e7-a3a2-76a8f6311629") },
                    { new Guid("16688200-0528-48d6-8ef2-d53eb941b3c5"), null, null, "+341 43 (830) 19-42", new Guid("1281e6c3-dc02-4e83-a90d-37f640411dfc") },
                    { new Guid("16954625-eb27-4a79-82de-a3a5ae343ebc"), null, null, "+593 19 (991) 28-34", new Guid("1fa36b53-f427-4c95-96d2-7c8a11050267") },
                    { new Guid("16e0e309-db0b-41b6-ac7b-c074391897f8"), null, null, "+920 89 (448) 52-75", new Guid("f4909d03-d7ac-4aaf-a6fe-77a88f9fe06b") },
                    { new Guid("17028596-6b43-4fa9-a56a-d53b76b5bb73"), null, null, "+821 50 (133) 00-67", new Guid("a907043f-86ba-4126-baac-6e2c6eb5871c") },
                    { new Guid("17083b09-fd38-4886-a3de-d2534253479a"), null, null, "+607 34 (427) 25-51", new Guid("d50ea512-4841-4fdb-b6f1-1805a1f266cc") },
                    { new Guid("173de440-f736-4b0e-8784-40b8e838a120"), null, null, "+993 77 (500) 55-22", new Guid("22a1446b-6ffd-488e-8e70-011276aa0ae3") },
                    { new Guid("17833721-ffc2-4d06-b6ac-be494cb5ede2"), null, null, "+167 19 (930) 20-14", new Guid("3af6d087-276b-42a2-9c69-d7501840f5a1") },
                    { new Guid("1796f579-0707-4b9e-90cf-94355ef58e5e"), null, null, "+845 83 (906) 44-39", new Guid("b7003b5f-1610-4487-9fd1-c03a6d0982d7") },
                    { new Guid("17b38b71-17f3-4b29-9a2a-352a15ce9fc3"), null, null, "+214 87 (521) 23-30", new Guid("72c94cd8-c5e7-422d-b184-eeec7158816e") },
                    { new Guid("17e3b88f-2f78-4a9c-8549-ae0f0f9ebc13"), null, null, "+228 53 (314) 32-70", new Guid("4b70366e-a511-4254-8c8d-ad820ee7b210") },
                    { new Guid("17eb3f12-c8b3-4d04-acb6-e19812c29b55"), null, null, "+881 11 (771) 11-37", new Guid("980f1926-46d3-48d9-880c-73d0be9fa1e0") },
                    { new Guid("18037e3b-19f9-49a2-bbc2-00bd11a4ca5a"), null, null, "+161 08 (675) 32-59", new Guid("f57190db-67c4-4d7b-9cd1-c8e27a6ac561") },
                    { new Guid("1821671e-da06-4516-a7e4-9cc0d5ef80fa"), null, null, "+624 76 (443) 01-22", new Guid("1e75d073-445f-4291-b366-fe0683c205a7") },
                    { new Guid("191084ef-447f-4887-84f7-136749cb102e"), null, null, "+645 65 (703) 50-53", new Guid("34c24f57-b16e-4b0f-abe2-5cb9c260e918") },
                    { new Guid("19d1fdc1-cc02-482d-84a0-76bc602fd313"), null, null, "+641 27 (000) 27-00", new Guid("4a66fea0-71b8-4943-90c9-d349550e6fe9") },
                    { new Guid("1a8293bc-cbe8-48a0-b6a7-25e1f2ce8ede"), null, null, "+409 14 (981) 74-16", new Guid("23dc6e61-4215-4b56-b081-13cd0b456e6f") },
                    { new Guid("1ae6eac6-321d-4e8d-8b24-cd05710dadfa"), null, null, "+31 11 (272) 53-11", new Guid("c6c5dcc4-cc8e-4484-935f-918264ee4897") },
                    { new Guid("1b1edeef-118e-4425-9ca4-e48bf54465cd"), null, null, "+648 19 (094) 04-32", new Guid("8fca9140-9c2e-4112-9850-cdf3b029b5ac") },
                    { new Guid("1bc83920-ae5e-43da-941f-cf09b9a68880"), null, null, "+366 41 (858) 92-49", new Guid("7a4f4be1-0c5d-43fb-8b70-3e4913ca97a0") },
                    { new Guid("1c2a6ac6-5ada-490e-8784-eecd333cad4e"), null, null, "+68 66 (006) 21-90", new Guid("3327a162-c88c-4952-9e00-d3c7118fb9f5") },
                    { new Guid("1c866b08-e663-48e8-aec3-b104737f7c32"), null, null, "+906 33 (389) 36-66", new Guid("b7f7d261-2525-4477-8b55-bba019231e9f") },
                    { new Guid("1ca44c94-ec26-4188-adc5-48fb468c70a0"), null, null, "+24 07 (168) 29-59", new Guid("f8c234a1-e25c-478d-be01-cda21178c47a") },
                    { new Guid("1cb16955-3807-4d84-b580-631ddd77caa3"), null, null, "+731 67 (403) 07-85", new Guid("dda60091-f993-4d23-997a-ac4774d856d5") },
                    { new Guid("1cd2e23e-08dd-40fc-bbaf-9078141ca18d"), null, null, "+812 52 (404) 38-14", new Guid("c6d62b30-8c4e-444d-a56a-cf5bea9f9c2a") },
                    { new Guid("1d467d0d-06eb-4b0e-9576-3a0bd050b022"), null, null, "+989 24 (204) 70-92", new Guid("2078228d-bb74-4e81-8e84-3dd4a76ea271") },
                    { new Guid("1dab2965-5ed8-4b5b-a38d-7b66c84eccc1"), null, null, "+584 94 (895) 56-85", new Guid("d173c22f-aa53-4e3b-b137-bcd6d2faf814") },
                    { new Guid("1dd16368-0fb7-4364-aa3e-a8643400a0b0"), null, null, "+691 81 (340) 16-09", new Guid("12f12b30-ab20-433f-91c1-e6f9be859390") },
                    { new Guid("1ddfa37a-90a5-4691-9cc2-dbef74554abb"), null, null, "+726 46 (735) 75-12", new Guid("cd6370e2-d6d7-4cbd-aaac-c3cf98e8cec3") },
                    { new Guid("1dfc7dee-c159-4162-a687-d9451a3c252c"), null, null, "+48 92 (059) 19-33", new Guid("a72d6b0a-25a6-4c67-ac93-cc46cae2d9dd") },
                    { new Guid("1e08f7fa-1950-4015-9088-20b5a063c676"), null, null, "+350 12 (575) 96-47", new Guid("00e8ecc6-7b14-4020-bcbd-1a849d69a8c6") },
                    { new Guid("1eb51f36-7663-425b-8386-8922c59a06d5"), null, null, "+895 57 (731) 63-61", new Guid("96830fa4-dc91-4a31-8fad-9b956fd29c58") },
                    { new Guid("1eee41b0-8e2a-4580-b0aa-4070ed837c2f"), null, null, "+58 88 (591) 66-66", new Guid("7d6ad8fc-e102-4ea8-a3e2-5bdfda8f1650") },
                    { new Guid("1fc05ff3-d3dd-4bb5-b1c4-65baacbf2c77"), null, null, "+437 17 (384) 40-90", new Guid("0dce50e5-ef29-456b-ab6f-c4454c5cfc38") },
                    { new Guid("1feccf52-d2a6-4810-8576-5e2615a9de40"), null, null, "+23 95 (781) 01-36", new Guid("8c8ff9a2-2752-46a7-960e-0490c28de13f") },
                    { new Guid("202c86ec-583b-4376-9bed-0d1c564dc2e9"), null, null, "+346 11 (347) 16-67", new Guid("27f9e909-39f0-43df-afb3-3bc130e8da06") },
                    { new Guid("2102785a-915a-4ef8-968f-2d45d17fcfe2"), null, null, "+255 25 (153) 71-49", new Guid("52fe76ad-4c09-4b99-9385-e407990c0307") },
                    { new Guid("2193c001-dcaa-4a2b-922f-52a78a6410b9"), null, null, "+595 53 (370) 54-54", new Guid("cc019092-2135-4dea-b991-c8b67614f148") },
                    { new Guid("21a9d3c6-a939-4360-b868-352d845f4ed5"), null, null, "+421 69 (348) 50-45", new Guid("12f12b30-ab20-433f-91c1-e6f9be859390") },
                    { new Guid("22086632-af53-4ea7-94a0-f90dc9ae5caa"), null, null, "+801 19 (767) 95-93", new Guid("3327a162-c88c-4952-9e00-d3c7118fb9f5") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("226fd907-47f2-452e-b7ec-41c024ceeded"), null, null, "+797 73 (440) 54-97", new Guid("2275ad3d-6816-4c2b-ba9c-96a3dc4f45fb") },
                    { new Guid("22a9269a-3e4f-4b26-abe2-9adbeb23a9fe"), null, null, "+57 05 (038) 74-16", new Guid("22a1446b-6ffd-488e-8e70-011276aa0ae3") },
                    { new Guid("230078d6-0cc9-4477-ab6c-2cc7adfb3b70"), null, null, "+372 89 (117) 08-99", new Guid("abfe1efb-0a8f-4af4-ab49-6de94e3ef374") },
                    { new Guid("2409f0ad-a53b-4cfa-8e1a-ae8101855bf6"), null, null, "+536 05 (070) 71-73", new Guid("7646ca6a-9ad5-4b77-91b7-839412348bed") },
                    { new Guid("24c55dae-9e02-4576-a64d-6ea4f6f90ce6"), null, null, "+751 72 (552) 44-48", new Guid("f070ec16-f59a-41c8-8ab6-b492f05b08e3") },
                    { new Guid("253e67ab-5093-4e86-bbec-ec60e0af6879"), null, null, "+819 43 (683) 45-94", new Guid("09ff0b03-eca3-4596-9c5d-d809a2f99a1e") },
                    { new Guid("25a46c39-6424-4d77-9149-1834f8202739"), null, null, "+678 76 (348) 99-45", new Guid("8180db6e-0139-48fa-a7bc-8424ac74378c") },
                    { new Guid("25d24891-5576-4a32-a4d7-48c29ebb5301"), null, null, "+816 89 (442) 41-40", new Guid("4f7cd1ca-72e9-46bd-ab1e-ae8fa37d21a4") },
                    { new Guid("2642be6f-8aa1-41d3-8a74-b9a67877ad2e"), null, null, "+606 69 (166) 06-01", new Guid("abfe1efb-0a8f-4af4-ab49-6de94e3ef374") },
                    { new Guid("27c47427-c7a5-4e8d-8bce-5c642912dd81"), null, null, "+617 28 (070) 91-74", new Guid("b89fe956-f020-4fc2-affd-e06c759e4081") },
                    { new Guid("27de2cac-b676-4f1f-9d28-437089178519"), null, null, "+298 98 (515) 61-17", new Guid("3327a162-c88c-4952-9e00-d3c7118fb9f5") },
                    { new Guid("27de56e1-a578-4e80-a332-30e4ed447617"), null, null, "+17 82 (534) 99-78", new Guid("65dedea0-0687-4571-93d0-c6cdfefedb38") },
                    { new Guid("28b86708-299e-4a07-b843-0825f011ad77"), null, null, "+386 96 (783) 84-26", new Guid("9336f657-bf13-4455-becf-1afff818911b") },
                    { new Guid("28c3980e-ae14-47d2-9e62-f1cfa56bd391"), null, null, "+96 87 (811) 68-52", new Guid("ac4b1e96-68b1-4502-856c-10b88acf07fa") },
                    { new Guid("29305e9f-bb34-4a8a-8afc-0f13ec118488"), null, null, "+902 78 (087) 98-12", new Guid("bfb2c3f3-d581-43c3-ad34-2b9af77e293a") },
                    { new Guid("2936d882-12bb-4a81-b6d2-586ed1ef351f"), null, null, "+826 40 (290) 11-22", new Guid("1530b862-24b5-484d-8939-50315a49bd13") },
                    { new Guid("2937fd6d-d080-4d4e-b880-ff0cd9b4e3d8"), null, null, "+205 44 (278) 54-28", new Guid("11e566bf-b29d-4651-8e8c-7f65a8281c80") },
                    { new Guid("298f5b95-150d-4fa9-a7f0-be26c962600d"), null, null, "+751 09 (042) 39-27", new Guid("77a05cfa-406d-4342-a924-73d56bf2829a") },
                    { new Guid("2b0e19ea-d874-4293-9b0a-021214994185"), null, null, "+945 67 (060) 31-79", new Guid("6ceec469-cfb3-42b5-b289-a4c2da0a32dc") },
                    { new Guid("2b1635b1-f9bc-406a-9eaa-0fa9c394f01f"), null, null, "+673 35 (663) 83-99", new Guid("628d01f9-5feb-4e85-a1ac-d03470903a20") },
                    { new Guid("2b62549b-17a3-4073-aa71-f57fd5290e8e"), null, null, "+927 66 (439) 10-63", new Guid("68bf203c-5d15-452a-b81b-bb7831c4f579") },
                    { new Guid("2b74980a-82e9-48c7-bcc5-ac0cfc6ca505"), null, null, "+76 65 (068) 45-58", new Guid("f498a63d-900c-464a-8fab-e4232968dc8b") },
                    { new Guid("2c4fb4ad-5620-40e3-9ad0-02e8de80bb7b"), null, null, "+876 01 (848) 56-69", new Guid("ae39cf22-04cf-4eb4-8b28-b59be4789ea6") },
                    { new Guid("2c8c3686-4edf-4ceb-bcb0-9cb2d4b3a069"), null, null, "+151 71 (136) 41-27", new Guid("11e566bf-b29d-4651-8e8c-7f65a8281c80") },
                    { new Guid("2cc36f69-4acd-414c-89ce-436b37771c71"), null, null, "+632 44 (530) 13-08", new Guid("aa406ff8-810a-45a6-8b41-5028563ae3b6") },
                    { new Guid("2cd1e620-b580-452f-bada-134eb2304e8a"), null, null, "+984 69 (053) 15-44", new Guid("db7dd226-4232-45fe-a502-06e0dfd99b42") },
                    { new Guid("2cec0cbc-7abf-48a4-a63a-18f17544ff75"), null, null, "+20 56 (256) 03-98", new Guid("77a05cfa-406d-4342-a924-73d56bf2829a") },
                    { new Guid("2d1c8e11-d972-459e-b951-0c12a4374b54"), null, null, "+790 01 (885) 35-54", new Guid("4f1ac364-cc01-4a40-a229-d66da5446413") },
                    { new Guid("2d2d3400-25d2-4b10-85dc-168c9e57c034"), null, null, "+410 04 (929) 12-96", new Guid("9981eef1-0435-4903-9860-b16fb734ad1b") },
                    { new Guid("2d50ccd9-5570-4918-a9a8-d71162863093"), null, null, "+734 93 (497) 00-53", new Guid("a8fb7001-ca18-422b-b724-7bb884b357db") },
                    { new Guid("2d7d4ff0-7a3a-4d41-a0ed-a60136a58690"), null, null, "+352 54 (620) 78-29", new Guid("0643292c-1282-43c9-ae18-5e2311a73db2") },
                    { new Guid("2da33cad-67ad-4146-b490-e1b5532f4640"), null, null, "+160 46 (703) 42-78", new Guid("ab522845-c1bd-4f82-bee3-06f49429e4bf") },
                    { new Guid("2dd0b1ea-9c1b-40ce-858b-c7aa90f0ac3e"), null, null, "+613 02 (679) 79-88", new Guid("8fca9140-9c2e-4112-9850-cdf3b029b5ac") },
                    { new Guid("2dd6a49d-2612-4d19-b031-04acaedc5200"), null, null, "+647 55 (523) 23-15", new Guid("c4ec53d7-69be-4d5d-9091-29c7f80bd641") },
                    { new Guid("2de93508-5bdf-4c34-a352-015960f05e56"), null, null, "+752 46 (499) 77-61", new Guid("99d66586-6373-4afb-b333-7c5cb91075c4") },
                    { new Guid("2e154825-1f56-4ff6-8573-2aa8614ee565"), null, null, "+615 70 (076) 35-83", new Guid("8d7de522-82d8-4912-bf1a-5d80658097e7") },
                    { new Guid("2e523a90-9230-4dba-a5cb-76d76e1fb83d"), null, null, "+766 02 (979) 32-35", new Guid("4a1c10a8-7cf3-42b7-9d73-0683e4bc1868") },
                    { new Guid("2eb74e2c-ad12-46b2-a597-16bbf51c0ff3"), null, null, "+198 85 (487) 23-74", new Guid("c78c659a-335a-4de3-940d-5ed29586f5d9") },
                    { new Guid("2f0697b6-c80b-4ff3-9a26-6d7597dc953c"), null, null, "+309 53 (916) 63-92", new Guid("a8fb7001-ca18-422b-b724-7bb884b357db") },
                    { new Guid("2f643871-eec1-4a65-a242-049b69a0d4a7"), null, null, "+808 51 (499) 96-07", new Guid("2effe328-1bb8-4f90-8e5e-a133fd94d1df") },
                    { new Guid("2f9f6e92-1f30-42d5-aff1-4f7325797842"), null, null, "+374 62 (233) 73-52", new Guid("a5e0abc8-bc40-47e6-bf22-077c758ba0a7") },
                    { new Guid("2fba703c-4ef0-47c7-9dbb-89e27efae9a7"), null, null, "+589 67 (413) 37-61", new Guid("0fedadae-5c91-4999-9924-42f5fcd0de5b") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("2fba71fa-d8f5-4ace-9896-2a9e4141b6fb"), null, null, "+52 19 (794) 30-83", new Guid("1530b862-24b5-484d-8939-50315a49bd13") },
                    { new Guid("2fc85ea1-6dc1-4e96-9f62-34f6055faf12"), null, null, "+607 68 (274) 85-06", new Guid("1070c404-0d57-4ba4-828e-4ca0d5ec2262") },
                    { new Guid("3032669e-9df6-4cef-b213-b0a4572faaa5"), null, null, "+234 91 (213) 25-03", new Guid("11b76a5d-870e-46d3-b3e3-0af0f8f871ac") },
                    { new Guid("30adf1c9-389e-4376-b202-605818398b79"), null, null, "+47 42 (864) 29-50", new Guid("b7003b5f-1610-4487-9fd1-c03a6d0982d7") },
                    { new Guid("30b03c42-ada4-4577-80d9-0c80fb72e9dd"), null, null, "+597 41 (920) 01-28", new Guid("4f750333-43c7-4b6d-871b-3959dea7a14e") },
                    { new Guid("30db8130-6b2a-4862-b5c6-34622527d0f7"), null, null, "+630 37 (597) 21-91", new Guid("73953973-c12c-407d-b23d-97f5b010569d") },
                    { new Guid("3105f94c-df2a-434a-8214-3ff62c18b767"), null, null, "+347 25 (503) 26-58", new Guid("3359f4d4-fbc1-4174-b3e0-8cc3754ac07b") },
                    { new Guid("313294a4-6af5-4109-add3-9926d3b7c2d3"), null, null, "+533 21 (691) 22-95", new Guid("7324afd3-dc67-4f31-ab23-e7b052d0c6e2") },
                    { new Guid("31479de3-1dc5-4bd8-834c-f5249a1ea16d"), null, null, "+68 98 (452) 50-16", new Guid("ef8bcbb3-fff2-4f2c-aa48-9ad3e0312130") },
                    { new Guid("318d207e-36c2-4139-8779-bc479b50adff"), null, null, "+363 58 (941) 97-45", new Guid("8de401f3-837a-4e09-884e-ddf9af867804") },
                    { new Guid("319a004b-e920-47c8-838d-cd1f28951702"), null, null, "+454 18 (172) 33-39", new Guid("7d6ad8fc-e102-4ea8-a3e2-5bdfda8f1650") },
                    { new Guid("3204ef43-9d2f-4ab5-8eb1-31c280a07b1e"), null, null, "+910 17 (700) 43-50", new Guid("54f16999-7e05-407e-aab8-1c56cdb79653") },
                    { new Guid("325b6e6f-55d1-4f57-9273-06383989c508"), null, null, "+806 84 (392) 99-33", new Guid("2b62c42e-4571-4d98-bd8d-7ba20ea3e48b") },
                    { new Guid("32e3b47f-9132-4982-afea-07977ac784c5"), null, null, "+434 74 (448) 92-80", new Guid("7271d193-6a4b-40d9-ab91-a7d8a07e45bb") },
                    { new Guid("33e7fcc8-a46f-44ce-9fa6-2d3ce6e653a0"), null, null, "+250 21 (654) 06-67", new Guid("6ceec469-cfb3-42b5-b289-a4c2da0a32dc") },
                    { new Guid("3412d180-cdd2-41f4-b138-f39037c07959"), null, null, "+929 20 (544) 25-80", new Guid("f57190db-67c4-4d7b-9cd1-c8e27a6ac561") },
                    { new Guid("344f1416-3761-4e00-b8c6-e8a192b0c4e0"), null, null, "+759 04 (895) 98-79", new Guid("1070c404-0d57-4ba4-828e-4ca0d5ec2262") },
                    { new Guid("34679d4c-6f96-4a0d-bf5b-9357a3d2f79b"), null, null, "+127 64 (090) 84-20", new Guid("1e75d073-445f-4291-b366-fe0683c205a7") },
                    { new Guid("34871797-8eab-4fa3-9538-c7363290fec8"), null, null, "+268 64 (764) 65-13", new Guid("c4ec53d7-69be-4d5d-9091-29c7f80bd641") },
                    { new Guid("35276255-4dae-4281-8465-009a6995a95a"), null, null, "+448 82 (304) 14-62", new Guid("a3bc456f-939a-42c3-99ed-719e0db5bf18") },
                    { new Guid("3567334c-63a0-49c0-8f69-c62a9ba19385"), null, null, "+327 42 (430) 36-74", new Guid("1e75d073-445f-4291-b366-fe0683c205a7") },
                    { new Guid("357e6faf-2c11-4964-8b6a-0cd2f78f7daf"), null, null, "+49 70 (097) 90-52", new Guid("4a66fea0-71b8-4943-90c9-d349550e6fe9") },
                    { new Guid("3647bfc0-a3b7-4cf1-ae6c-190736f4b31c"), null, null, "+330 23 (375) 71-76", new Guid("c4ec53d7-69be-4d5d-9091-29c7f80bd641") },
                    { new Guid("36a16ad7-f8c1-4204-b02b-e770d2b9ef1b"), null, null, "+409 94 (224) 50-94", new Guid("22a1446b-6ffd-488e-8e70-011276aa0ae3") },
                    { new Guid("36adf868-19d4-4c3f-8f88-aa0adcfad7bb"), null, null, "+542 86 (624) 51-08", new Guid("f088f668-331b-405e-b41a-5cc648df081c") },
                    { new Guid("36d6e794-28d8-4d98-b550-35d93f098e78"), null, null, "+973 67 (925) 12-88", new Guid("cffc8c5c-aee1-43fa-a247-e83b10ecb56e") },
                    { new Guid("378220c1-d48f-40bd-bb90-63f0117e2544"), null, null, "+600 95 (962) 29-34", new Guid("39fc9708-01f3-4ab0-8c26-d5bc00da55db") },
                    { new Guid("37a48507-9e0b-4ed6-b593-b433882f8e45"), null, null, "+762 94 (257) 09-59", new Guid("d799d7ce-936a-414f-86fd-958f17b3f642") },
                    { new Guid("37ac200d-d4fc-4c01-875f-2854608ae37e"), null, null, "+328 74 (011) 20-27", new Guid("2293afe4-2408-427c-9960-7223d1291070") },
                    { new Guid("37b37b54-30d9-401b-8a88-54b5161f1907"), null, null, "+465 86 (860) 79-75", new Guid("36afa758-a0b9-4345-9bce-db873a3c22fd") },
                    { new Guid("3813d59d-211f-4daf-84a0-f68367aed1ad"), null, null, "+270 58 (299) 58-17", new Guid("28ab8e57-b296-4656-9877-df7be64ecc51") },
                    { new Guid("3876a612-83d2-4e0f-a084-1b9d6e1e1683"), null, null, "+12 94 (984) 46-61", new Guid("25a38376-e74c-46cc-8d4f-292cebbcdffb") },
                    { new Guid("389bba8b-94c5-4992-ba0d-7b0aa663eec6"), null, null, "+338 45 (024) 50-12", new Guid("712b2e8f-feec-4b44-842e-63c59bbe48cb") },
                    { new Guid("38b6e3a5-5e2b-4c44-8893-a8a05010302a"), null, null, "+67 96 (962) 74-14", new Guid("4a66fea0-71b8-4943-90c9-d349550e6fe9") },
                    { new Guid("38c3df49-1e14-44a2-b17f-f0c9ebeea89f"), null, null, "+661 19 (819) 99-06", new Guid("0dce50e5-ef29-456b-ab6f-c4454c5cfc38") },
                    { new Guid("39531c49-17d5-4f98-aa71-7414448eef60"), null, null, "+66 30 (058) 40-42", new Guid("b40e13af-a00a-45af-a681-b960cb8d6a7b") },
                    { new Guid("3956c208-16ca-483e-886d-066927b6b29b"), null, null, "+747 05 (653) 87-17", new Guid("52fe76ad-4c09-4b99-9385-e407990c0307") },
                    { new Guid("398f43ba-3f21-475f-a805-a72e29266999"), null, null, "+757 15 (359) 94-05", new Guid("089446be-2352-4d8f-9726-ba2c324e1aee") },
                    { new Guid("39e993cd-eb19-4518-8237-9723ef7fad5e"), null, null, "+198 52 (832) 53-49", new Guid("5881d0e1-89ce-4573-8217-2e4c8ee1688e") },
                    { new Guid("3a98dfcf-a172-4fc3-8ff8-3945e80aeaf1"), null, null, "+109 80 (962) 37-32", new Guid("d572b4d3-7e7c-44d5-b1d1-164c1895424b") },
                    { new Guid("3aca0e9b-d50d-47c9-b9ab-5473dae15e29"), null, null, "+755 90 (648) 01-05", new Guid("4e8f092d-b1e1-47d3-9de6-5d9db26187a5") },
                    { new Guid("3ad78db9-387a-4581-9646-3bcd5f884d31"), null, null, "+167 23 (025) 18-34", new Guid("d173c22f-aa53-4e3b-b137-bcd6d2faf814") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("3b9f86e8-f972-48df-9c94-af7fef5f2052"), null, null, "+423 96 (735) 38-59", new Guid("b2abd3eb-7d4b-49b1-8a46-4ea8b8313ab8") },
                    { new Guid("3ba2940e-8058-4c08-92e8-b48a920f0d29"), null, null, "+222 50 (162) 85-67", new Guid("db7dd226-4232-45fe-a502-06e0dfd99b42") },
                    { new Guid("3c27a634-633b-43dd-9a54-de98e4d81983"), null, null, "+531 82 (604) 87-76", new Guid("f070ec16-f59a-41c8-8ab6-b492f05b08e3") },
                    { new Guid("3c5dbebc-d8cb-45cb-883d-85d5f95db0d2"), null, null, "+970 40 (272) 98-60", new Guid("0763ce92-5a2c-4138-ad42-41c5b45988dd") },
                    { new Guid("3ca8b11a-6173-4134-a1c6-e2b539aee9c0"), null, null, "+302 51 (533) 55-57", new Guid("bdc35340-f998-4d2c-9ebc-c29624582c95") },
                    { new Guid("3d34f17d-6134-4f0f-8b8f-01fb52b85792"), null, null, "+525 61 (051) 04-59", new Guid("d52df32f-0260-40eb-8234-13ab7a744fcb") },
                    { new Guid("3dab17ea-dc46-4246-b175-00eda9f71bb6"), null, null, "+794 62 (049) 42-00", new Guid("a66e6d00-7000-4eb2-994b-a38594503957") },
                    { new Guid("3dbbead1-5c84-46b6-b98a-0a3cda9ba7db"), null, null, "+545 86 (428) 41-53", new Guid("cca9c534-e77c-400e-a849-210326576f8f") },
                    { new Guid("3dbe89c7-f999-4433-b82e-bbe81e27f385"), null, null, "+694 30 (885) 95-87", new Guid("a907043f-86ba-4126-baac-6e2c6eb5871c") },
                    { new Guid("3dd7b287-8b97-4d9d-88f8-b9c22db558b0"), null, null, "+236 27 (855) 29-43", new Guid("bb021ddc-2731-4d61-8069-ddee5e7759da") },
                    { new Guid("3df47e29-0dec-4c83-951e-7dc809ca90a2"), null, null, "+44 68 (785) 72-23", new Guid("70fe5fa7-69ef-4577-a750-34ca205c0dac") },
                    { new Guid("3e94bfb0-cd1e-4308-bf04-7d3b7e448d90"), null, null, "+377 93 (357) 38-06", new Guid("f52649ec-b9d7-4f35-8295-ec4e2b5c564c") },
                    { new Guid("3ec9c3be-9613-46d8-995f-ed987af0e708"), null, null, "+248 01 (006) 57-69", new Guid("58e47d27-16f3-4806-acf1-7b73ccbc0d5e") },
                    { new Guid("3f08025c-75c6-487c-90a2-177865aa0100"), null, null, "+255 45 (914) 26-06", new Guid("58e47d27-16f3-4806-acf1-7b73ccbc0d5e") },
                    { new Guid("3f3eb3ee-5e61-421b-b48f-90178aaada58"), null, null, "+270 11 (326) 11-74", new Guid("bfb2c3f3-d581-43c3-ad34-2b9af77e293a") },
                    { new Guid("3f719a96-5798-4fad-aa95-06bb4d6dcc6e"), null, null, "+142 02 (816) 22-00", new Guid("fbcf0085-dd67-4f41-b656-a0c0900baca5") },
                    { new Guid("3f8f9e0f-1a83-4ba4-860f-b3d3091b1776"), null, null, "+559 27 (454) 03-97", new Guid("4f7cd1ca-72e9-46bd-ab1e-ae8fa37d21a4") },
                    { new Guid("3ff2ec9b-63e0-4137-8654-b948f27cf818"), null, null, "+238 99 (616) 71-55", new Guid("23dc6e61-4215-4b56-b081-13cd0b456e6f") },
                    { new Guid("408f82b1-992f-4e32-ba36-5de50f74af43"), null, null, "+1 20 (607) 26-56", new Guid("089446be-2352-4d8f-9726-ba2c324e1aee") },
                    { new Guid("40d56741-56a2-49df-a2a0-d96c4764e9d1"), null, null, "+669 19 (648) 34-09", new Guid("611b8b1f-53d5-4660-9ad4-e0b57e915bf8") },
                    { new Guid("41cb68b8-c9da-49c9-a823-e7cc859f7e47"), null, null, "+645 61 (061) 88-57", new Guid("af67d494-10d3-4417-9f74-90816ee69f93") },
                    { new Guid("4232482a-8fcf-42a4-8603-8eb884e92af5"), null, null, "+881 28 (639) 86-06", new Guid("4f750333-43c7-4b6d-871b-3959dea7a14e") },
                    { new Guid("426de72d-93f6-4d81-85d7-91b0c7902d84"), null, null, "+578 96 (378) 05-39", new Guid("ce108172-f4b7-4653-a5c3-ff603fbc3a50") },
                    { new Guid("4276da0e-1667-419d-b9b5-2448a39e8f89"), null, null, "+528 30 (460) 15-40", new Guid("5d61541c-3ac1-459c-b0d4-0bbe121306da") },
                    { new Guid("42fa52d0-1347-4b81-8114-018a6ef40ab1"), null, null, "+967 24 (913) 99-48", new Guid("08e9beba-81d1-40e1-9f0f-4d282258b85b") },
                    { new Guid("433b2d92-8e17-4a3e-908d-4dbd23ac7086"), null, null, "+852 72 (367) 90-24", new Guid("29c7fc41-2565-497d-8900-56c2e6208fa6") },
                    { new Guid("436e2bcf-7e25-4c5f-80ff-a202a9c9d94d"), null, null, "+134 64 (593) 07-73", new Guid("77f28b3f-3ca9-4819-96c6-bd1e811a39f5") },
                    { new Guid("43acdb9f-fd34-4820-aaad-0ac531e2fcc5"), null, null, "+967 94 (088) 38-75", new Guid("5146be01-925a-447f-b871-b7de98b487df") },
                    { new Guid("43bd3514-3aba-48e0-ad0e-ad3b4eddfef3"), null, null, "+45 56 (021) 12-05", new Guid("2f3d1b8f-7590-4d18-9002-4caa22511a8b") },
                    { new Guid("43f80c9d-3373-4047-83e7-f8be48491a69"), null, null, "+812 47 (987) 95-30", new Guid("c075bfdf-a5cc-4efb-a6d1-f31b0c4bf344") },
                    { new Guid("43fc7d58-8405-4c0b-9659-12724ccee21d"), null, null, "+894 18 (700) 78-00", new Guid("6de94a05-0c03-4062-8ab9-57a5bd55b3a5") },
                    { new Guid("440aa557-aa21-4ac6-8d1c-5930c778efb9"), null, null, "+755 09 (801) 08-60", new Guid("11b76a5d-870e-46d3-b3e3-0af0f8f871ac") },
                    { new Guid("44659fbd-2265-4dbc-9c84-a57501340cec"), null, null, "+140 38 (811) 13-34", new Guid("f7e08701-d57e-42d3-884d-beb04dee4c45") },
                    { new Guid("455c4832-0898-4a48-a7e1-489673f87ded"), null, null, "+643 15 (382) 51-29", new Guid("c075bfdf-a5cc-4efb-a6d1-f31b0c4bf344") },
                    { new Guid("4562d3f0-f1bd-40ec-9d21-aba1a8741e3a"), null, null, "+90 17 (152) 94-28", new Guid("6441d6d0-462e-4346-8bea-ddea048566dd") },
                    { new Guid("45a62e07-004f-4c2e-bcdc-cf0194218c96"), null, null, "+585 41 (314) 46-24", new Guid("9336f657-bf13-4455-becf-1afff818911b") },
                    { new Guid("4605a305-b621-4d1f-8b7c-f6ec214c35e8"), null, null, "+933 48 (220) 39-96", new Guid("5dd3e047-c6f3-412d-b5cb-12b416f99706") },
                    { new Guid("46dac884-42d8-486b-a111-7bf58730845f"), null, null, "+719 57 (642) 62-95", new Guid("09fe5fb4-f36b-4a46-81a1-c617e335393a") },
                    { new Guid("46f2ddfb-b772-4141-8022-851587724a73"), null, null, "+682 87 (757) 36-02", new Guid("0c210681-d608-4ef0-acaa-f6ca1d403524") },
                    { new Guid("4710dd6b-ceee-462f-a913-a9fdeb9e025b"), null, null, "+839 92 (866) 64-72", new Guid("b7003b5f-1610-4487-9fd1-c03a6d0982d7") },
                    { new Guid("47751f91-1e21-4af0-97e7-7a368cacf570"), null, null, "+539 82 (822) 65-95", new Guid("db9ac887-f173-4f7b-ad02-6d19fdd7b12e") },
                    { new Guid("47939360-fa0c-4181-849d-bde67bf0b4c1"), null, null, "+117 87 (879) 12-38", new Guid("8fca9140-9c2e-4112-9850-cdf3b029b5ac") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("47e0c293-2336-48b8-9963-e355a09a724f"), null, null, "+550 70 (608) 26-13", new Guid("b7f7d261-2525-4477-8b55-bba019231e9f") },
                    { new Guid("480ef9ca-29d5-47ef-b204-d61198b4690e"), null, null, "+172 74 (434) 66-20", new Guid("f2fc34d0-f967-4d49-ac54-2191c244d200") },
                    { new Guid("485c15c6-2b13-45da-bf49-c372674f3131"), null, null, "+487 18 (198) 66-07", new Guid("651f4e42-b7be-4042-92c4-872c1b4a2b36") },
                    { new Guid("48652751-e47e-4480-a89c-70d6fdef8640"), null, null, "+902 11 (110) 52-21", new Guid("9252c306-249a-4267-8ef5-891d8c0cbea1") },
                    { new Guid("4930291f-11a8-4090-9f5d-a2a88d52d004"), null, null, "+482 84 (320) 51-27", new Guid("eac06870-6688-4254-bca8-fa7f08d81e32") },
                    { new Guid("494f8c07-5379-4514-a18e-8c23c602faa5"), null, null, "+325 22 (221) 15-96", new Guid("7c403944-d570-486e-9c1f-e40454a443f6") },
                    { new Guid("4979ac5f-5762-4813-a8ab-4e2ba5520268"), null, null, "+796 11 (907) 38-74", new Guid("ea67b8fa-bc9a-4e27-8ba5-f3c2359c883a") },
                    { new Guid("49fe4204-6868-4fd4-a184-44fbb1d5c736"), null, null, "+361 09 (358) 16-46", new Guid("c7f2884a-d2aa-4aeb-80a7-44ed5d29e64a") },
                    { new Guid("4a5d36cf-baf9-49fd-93f9-40647ca43e9e"), null, null, "+483 69 (678) 99-98", new Guid("7c403944-d570-486e-9c1f-e40454a443f6") },
                    { new Guid("4a75c89e-467c-43a1-8b7d-ad4672c194e3"), null, null, "+731 85 (948) 97-44", new Guid("29c7fc41-2565-497d-8900-56c2e6208fa6") },
                    { new Guid("4b249305-d635-4685-ab12-5b94e17ea42e"), null, null, "+848 28 (112) 54-66", new Guid("07169b5c-40fd-40ba-b01e-8b56de466065") },
                    { new Guid("4b38f8c5-50a1-40f3-be12-4e2402ccdff6"), null, null, "+142 29 (497) 64-09", new Guid("bb021ddc-2731-4d61-8069-ddee5e7759da") },
                    { new Guid("4ba809a8-e6be-4e34-926d-b35f97c74f02"), null, null, "+802 09 (759) 15-11", new Guid("ae3132fe-b0e9-44a8-a734-658de87cc9a5") },
                    { new Guid("4c23ff9c-dda0-47dd-a43d-d4c6b3a6e62a"), null, null, "+252 78 (231) 98-83", new Guid("011fba87-398c-42ec-9aa7-ffb9c48fe9a9") },
                    { new Guid("4c2bbc14-9a04-4c5b-a8a4-a0557cba77c0"), null, null, "+124 65 (503) 62-57", new Guid("bb021ddc-2731-4d61-8069-ddee5e7759da") },
                    { new Guid("4ca270d1-0743-4552-b51f-c04f6477c3c4"), null, null, "+572 47 (446) 89-60", new Guid("abfe1efb-0a8f-4af4-ab49-6de94e3ef374") },
                    { new Guid("4ca40357-02da-41d8-adac-1b89a89c9a52"), null, null, "+522 86 (976) 98-42", new Guid("19d85480-882e-40f7-a536-84a552b3e447") },
                    { new Guid("4cd48dd9-777f-4367-abe9-12b753caa4f1"), null, null, "+475 02 (486) 71-16", new Guid("3327a162-c88c-4952-9e00-d3c7118fb9f5") },
                    { new Guid("4cf4aa43-9755-4365-a476-42a0dedc652c"), null, null, "+478 45 (137) 75-44", new Guid("ae1ca1b0-7eff-4b3f-a0bd-d326d1ebe578") },
                    { new Guid("4d4d2c1e-08a8-4862-816f-1285d51048c7"), null, null, "+201 39 (661) 32-71", new Guid("ae1ca1b0-7eff-4b3f-a0bd-d326d1ebe578") },
                    { new Guid("4d706366-097c-4e6d-ba19-701537ce2b01"), null, null, "+96 20 (872) 98-09", new Guid("993e8305-611d-4730-af5d-dbd1e15c6650") },
                    { new Guid("4daf8b99-3ccc-4a1a-b214-92bfb6221f88"), null, null, "+548 70 (477) 59-93", new Guid("fc6059ea-998b-4053-8aa0-faef98da998c") },
                    { new Guid("4dfabc57-554c-4255-ada1-dd950af1151a"), null, null, "+364 48 (724) 08-90", new Guid("96830fa4-dc91-4a31-8fad-9b956fd29c58") },
                    { new Guid("4e255697-c59d-4a97-9b16-ac2de20256d5"), null, null, "+144 60 (093) 53-45", new Guid("1fa36b53-f427-4c95-96d2-7c8a11050267") },
                    { new Guid("4e7b65f3-44c9-4376-a964-e9683008c586"), null, null, "+29 21 (823) 23-89", new Guid("ea67b8fa-bc9a-4e27-8ba5-f3c2359c883a") },
                    { new Guid("5021e9d8-630c-47d4-a894-bb5dbaccd44c"), null, null, "+800 81 (218) 56-95", new Guid("af267ef9-b2cf-4adf-a9d0-a58e3acadfa6") },
                    { new Guid("50b1d2c1-7a24-42e4-b833-f31995c81f9d"), null, null, "+876 85 (177) 74-57", new Guid("5c53533c-cf33-43f0-bdab-260275d90d88") },
                    { new Guid("50bf59c0-0cfa-48f1-88e1-9cea9e344595"), null, null, "+202 48 (683) 17-77", new Guid("ebecc10d-21da-4369-81d7-600c2de48f88") },
                    { new Guid("50cf4c72-678e-4614-8b93-2bec0073120d"), null, null, "+324 20 (352) 79-86", new Guid("922f53da-9877-4d56-a64d-6d83331bdbb6") },
                    { new Guid("50d7b821-b18a-47f5-a019-d21c82f422e7"), null, null, "+719 36 (519) 55-08", new Guid("c0159440-683d-4c76-a904-aa1f4564822f") },
                    { new Guid("513d2413-5cf4-494c-bb7d-f4ddf975e114"), null, null, "+767 57 (771) 01-20", new Guid("5881d0e1-89ce-4573-8217-2e4c8ee1688e") },
                    { new Guid("5157c518-3ba6-4554-b134-3daf26f5ab49"), null, null, "+990 00 (383) 04-39", new Guid("2d52a2a2-27d8-49a4-9ce6-969bb0f68fa2") },
                    { new Guid("515c5949-c3ca-49d7-be73-5e1c3e7c382a"), null, null, "+426 17 (968) 89-98", new Guid("9e9403fb-605a-441d-a83a-f936fec7582f") },
                    { new Guid("51ccbcaa-cf08-4f56-8024-d32f4fed1078"), null, null, "+191 25 (116) 17-58", new Guid("732ba531-5faf-4b4a-bcac-24d9ca3fcbc2") },
                    { new Guid("520a306e-6e5d-408f-b156-0b58a61e50a0"), null, null, "+871 80 (958) 12-21", new Guid("1281e6c3-dc02-4e83-a90d-37f640411dfc") },
                    { new Guid("520dc0fb-007a-4b40-861c-1a49436d1ea4"), null, null, "+743 15 (084) 98-24", new Guid("7a4f4be1-0c5d-43fb-8b70-3e4913ca97a0") },
                    { new Guid("52319843-347b-4fa8-a4d6-791420163d7f"), null, null, "+740 03 (541) 78-75", new Guid("89739d78-901e-4353-8c13-fe879541f76f") },
                    { new Guid("523a64b3-6b1f-4193-97d3-5e387b56fb59"), null, null, "+319 49 (964) 02-15", new Guid("0edec355-b022-4255-80d6-c530f687d26e") },
                    { new Guid("524905ee-3f79-4001-9df7-d222bfc54d66"), null, null, "+465 32 (788) 50-58", new Guid("aa406ff8-810a-45a6-8b41-5028563ae3b6") },
                    { new Guid("5343fe9f-476f-4f8c-b004-fa7cd153be2b"), null, null, "+180 70 (713) 16-23", new Guid("11e566bf-b29d-4651-8e8c-7f65a8281c80") },
                    { new Guid("53d0e120-a182-45bb-97ea-c0c47c8c3c48"), null, null, "+790 67 (316) 90-73", new Guid("1de915db-ea78-41e7-a3a2-76a8f6311629") },
                    { new Guid("53d40929-4309-4cf5-80d0-9579322ad9c6"), null, null, "+897 75 (762) 79-05", new Guid("54f16999-7e05-407e-aab8-1c56cdb79653") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("53eb1c8d-5516-4c2e-8fec-707fe5200601"), null, null, "+301 48 (447) 62-21", new Guid("7247fafb-5d1e-43fe-a447-5b99c26b77ba") },
                    { new Guid("5458b532-e06b-4253-a81b-f9f99b7b0571"), null, null, "+419 92 (570) 80-67", new Guid("ae39cf22-04cf-4eb4-8b28-b59be4789ea6") },
                    { new Guid("554f65f5-70ea-4b8a-86a1-00c4532d6387"), null, null, "+516 11 (359) 52-40", new Guid("28ab8e57-b296-4656-9877-df7be64ecc51") },
                    { new Guid("55590eed-5464-4d1e-acbe-a7364536b663"), null, null, "+331 56 (920) 13-35", new Guid("40de2c6f-e29d-4027-93c3-945e76ec015c") },
                    { new Guid("55596a8a-d35e-49a0-9b4b-315490956a8c"), null, null, "+505 64 (489) 52-23", new Guid("c1169f01-6528-4f74-aa56-802f48a7ece8") },
                    { new Guid("55abe715-66b3-44c3-8259-a3d0e40029f0"), null, null, "+476 40 (481) 69-15", new Guid("bdd49191-641c-4843-a442-069a71c65be5") },
                    { new Guid("55de9739-9bf5-4c27-a654-15f07cbdf69f"), null, null, "+559 38 (664) 33-23", new Guid("7d6ad8fc-e102-4ea8-a3e2-5bdfda8f1650") },
                    { new Guid("562a4c4b-4130-47e3-a1cc-489ac1a4de98"), null, null, "+991 95 (399) 12-97", new Guid("1548ab99-88de-44e5-8fb2-0ecadca929aa") },
                    { new Guid("568f432c-e147-463a-8719-48ce43ef9639"), null, null, "+79 73 (657) 42-62", new Guid("77a05cfa-406d-4342-a924-73d56bf2829a") },
                    { new Guid("57933c56-49da-4b55-aec7-b47000c34e53"), null, null, "+801 61 (038) 88-95", new Guid("f3ea0004-e1e2-4557-a9d5-14a5369a2eb3") },
                    { new Guid("57f714c5-ed9a-4566-a3a3-2ca09bd523ab"), null, null, "+271 79 (172) 96-93", new Guid("c9b88753-217a-4bb2-ac30-4bed75d66c61") },
                    { new Guid("58558b84-b26a-4998-ac7a-95f90eed09c2"), null, null, "+333 62 (078) 77-99", new Guid("143cf7ff-f2e3-444c-a15b-3aa7b4c43475") },
                    { new Guid("5869238c-56be-40c8-b960-eb9171a2a174"), null, null, "+315 02 (515) 49-20", new Guid("2c5320bb-6c0a-46cc-9731-a7b34514e4c1") },
                    { new Guid("591c02fb-c9a6-4f9e-8311-fea89cf5ee8f"), null, null, "+441 05 (329) 50-64", new Guid("5d61541c-3ac1-459c-b0d4-0bbe121306da") },
                    { new Guid("593c5e4a-03f2-4197-b9aa-b9b01d5965db"), null, null, "+206 56 (215) 38-68", new Guid("d799d7ce-936a-414f-86fd-958f17b3f642") },
                    { new Guid("59fdaec0-d701-4d83-8e9e-762198c3d218"), null, null, "+80 33 (577) 66-62", new Guid("1548ab99-88de-44e5-8fb2-0ecadca929aa") },
                    { new Guid("5a7f4b15-865d-45ec-ac5a-0ca8cc0475a5"), null, null, "+922 36 (103) 26-93", new Guid("0edec355-b022-4255-80d6-c530f687d26e") },
                    { new Guid("5a869646-9041-4de7-b6cc-d26cb17a84ab"), null, null, "+207 92 (777) 41-82", new Guid("4f1ac364-cc01-4a40-a229-d66da5446413") },
                    { new Guid("5a874fa1-ce59-4a91-b696-b4ba255c1089"), null, null, "+5 26 (730) 43-37", new Guid("23dc6e61-4215-4b56-b081-13cd0b456e6f") },
                    { new Guid("5aa8fa62-ca67-4762-a8f2-bae176f4ae0f"), null, null, "+262 45 (910) 51-09", new Guid("8c149454-da44-4038-9ece-768e572c5282") },
                    { new Guid("5ac02fc6-c1b4-40b4-9204-837c095f8c90"), null, null, "+741 06 (504) 47-73", new Guid("f57190db-67c4-4d7b-9cd1-c8e27a6ac561") },
                    { new Guid("5ae05c09-f124-4b56-b673-6c349a17f6bc"), null, null, "+114 76 (088) 53-13", new Guid("7975589e-fce3-4ff6-8b4d-4f29aa2e3c37") },
                    { new Guid("5ae7b8e1-1a32-48fb-8fdb-ee15358af2e7"), null, null, "+891 49 (717) 64-54", new Guid("e0518a7c-2290-4dde-8de0-19fe26c3d8fa") },
                    { new Guid("5b05290b-5135-4f8d-b992-2ddbbdd04984"), null, null, "+848 40 (508) 80-38", new Guid("09fe5fb4-f36b-4a46-81a1-c617e335393a") },
                    { new Guid("5b13ef07-a8b4-4409-98d9-74cb31dac3f7"), null, null, "+178 28 (781) 42-56", new Guid("371bed01-75b2-47b9-9535-3156b9a4c959") },
                    { new Guid("5b2bbaa9-5de8-4c9a-ae90-178b4f72fab7"), null, null, "+694 08 (827) 28-86", new Guid("7646ca6a-9ad5-4b77-91b7-839412348bed") },
                    { new Guid("5b2d0d12-2ab8-43cd-b0cf-baee939c4e9a"), null, null, "+996 25 (734) 09-91", new Guid("243b9c2d-ab41-4ea2-b445-092baa8385bc") },
                    { new Guid("5b7f48ad-dd54-456d-8b72-bcbb28d48bff"), null, null, "+717 74 (700) 26-13", new Guid("9336f657-bf13-4455-becf-1afff818911b") },
                    { new Guid("5bfdf06f-2e4b-457b-aa8f-630c512eccdc"), null, null, "+622 09 (526) 51-21", new Guid("5210b0bd-a591-4887-9abb-0f4415c0f467") },
                    { new Guid("5c1f6cd0-5625-4b99-8445-9d57f01488b2"), null, null, "+502 39 (856) 33-06", new Guid("3359f4d4-fbc1-4174-b3e0-8cc3754ac07b") },
                    { new Guid("5c42812d-eb1c-4839-8be5-8dfdb853989c"), null, null, "+526 29 (233) 40-23", new Guid("9e9403fb-605a-441d-a83a-f936fec7582f") },
                    { new Guid("5cc29c1e-00a8-4910-b14c-7acba56b3f51"), null, null, "+122 02 (166) 15-72", new Guid("f498a63d-900c-464a-8fab-e4232968dc8b") },
                    { new Guid("5cd0e059-2a5e-43de-8220-cba3085b0926"), null, null, "+988 44 (730) 74-45", new Guid("8d7de522-82d8-4912-bf1a-5d80658097e7") },
                    { new Guid("5ceea590-d997-4bcc-9b50-7b6383d88553"), null, null, "+960 88 (554) 10-27", new Guid("b72dbc44-743b-4e39-a250-af429c1f09a9") },
                    { new Guid("5d17442e-f42c-477e-b9ae-9db8f15f9637"), null, null, "+290 63 (322) 98-24", new Guid("5dd3e047-c6f3-412d-b5cb-12b416f99706") },
                    { new Guid("5d93c255-ce6e-48e7-acab-d23c123d5a30"), null, null, "+394 55 (522) 11-04", new Guid("65cb2c49-f00f-450e-94e8-540312a9ce09") },
                    { new Guid("5de01e49-dcf3-4e1e-9b47-d42651f37bbe"), null, null, "+749 52 (411) 72-24", new Guid("c864b34c-ddf5-4af6-9a5f-d8251c512e8f") },
                    { new Guid("5e2ee4be-9a4f-4269-911a-7952035f5701"), null, null, "+611 21 (263) 06-70", new Guid("2effe328-1bb8-4f90-8e5e-a133fd94d1df") },
                    { new Guid("5ebe2024-041d-41f9-8696-25703d1ad40d"), null, null, "+925 87 (440) 56-18", new Guid("2d52a2a2-27d8-49a4-9ce6-969bb0f68fa2") },
                    { new Guid("5ed677d1-63fc-4460-aa1a-17ce9131c015"), null, null, "+571 11 (128) 04-98", new Guid("8343d773-e986-49d8-99e9-bd908398b011") },
                    { new Guid("5f2fd589-8e88-4fc9-a707-dccf64f79bb6"), null, null, "+560 67 (882) 97-16", new Guid("25a38376-e74c-46cc-8d4f-292cebbcdffb") },
                    { new Guid("5f7f22b7-9271-4683-b68f-64938f02e23c"), null, null, "+318 71 (836) 06-23", new Guid("cc019092-2135-4dea-b991-c8b67614f148") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("5fb46107-cb24-42f8-ab10-93cce209dfac"), null, null, "+883 06 (834) 47-68", new Guid("dca6b19f-e9ff-4d07-b3df-fe7e57f8b960") },
                    { new Guid("6054bc07-f0e1-4876-9f79-84e459e8877e"), null, null, "+97 72 (110) 56-25", new Guid("9981eef1-0435-4903-9860-b16fb734ad1b") },
                    { new Guid("6059e617-e71c-4e68-ab7e-0afcd48ed9a1"), null, null, "+661 42 (342) 46-32", new Guid("5dd3e047-c6f3-412d-b5cb-12b416f99706") },
                    { new Guid("61780222-0db5-4bfd-9ba5-5244a61e54f7"), null, null, "+430 45 (469) 35-39", new Guid("8887b8ab-eb5d-41ad-bac2-3126e85117d1") },
                    { new Guid("61a3cb87-3d92-43ed-be3c-3496c59b5266"), null, null, "+702 03 (358) 93-00", new Guid("92fa424c-9623-4989-b9fe-494533664c26") },
                    { new Guid("61ff1d3f-1a09-4dd4-9e72-bfc17bc157b5"), null, null, "+289 56 (661) 37-37", new Guid("7e04a2e8-5af7-4c5e-8b81-d51fb8eb210b") },
                    { new Guid("6242b1ca-e3f4-47ac-a18d-3914e5562202"), null, null, "+409 80 (064) 33-99", new Guid("73cff5d2-f041-4e6e-8857-560606637e86") },
                    { new Guid("625abc17-f88d-41f7-9951-c9916cf069c8"), null, null, "+637 56 (143) 30-98", new Guid("af67d494-10d3-4417-9f74-90816ee69f93") },
                    { new Guid("62ad4d0e-3b22-48e4-9df2-3bf7436ce362"), null, null, "+777 20 (920) 24-96", new Guid("11b76a5d-870e-46d3-b3e3-0af0f8f871ac") },
                    { new Guid("642cde7f-d5ef-4da9-bddc-5415b5f738ce"), null, null, "+963 89 (536) 23-48", new Guid("bb021ddc-2731-4d61-8069-ddee5e7759da") },
                    { new Guid("655ef041-4cb8-44a1-b268-ae0c26046a15"), null, null, "+432 52 (348) 17-13", new Guid("d52df32f-0260-40eb-8234-13ab7a744fcb") },
                    { new Guid("65b4cf91-d640-4012-a426-e5165a423020"), null, null, "+424 89 (727) 35-20", new Guid("ce3412db-b24b-4f68-8e32-724c140b7d0a") },
                    { new Guid("65ec7a1b-fe54-4702-9736-5afc22e64839"), null, null, "+938 70 (226) 14-02", new Guid("7e04a2e8-5af7-4c5e-8b81-d51fb8eb210b") },
                    { new Guid("665aefa2-bcb5-4d51-8c6d-fb5b9c9d4fff"), null, null, "+600 60 (071) 09-82", new Guid("4f1ac364-cc01-4a40-a229-d66da5446413") },
                    { new Guid("66818da2-95da-4812-9148-717d775de44f"), null, null, "+834 82 (929) 69-27", new Guid("b2abd3eb-7d4b-49b1-8a46-4ea8b8313ab8") },
                    { new Guid("66bc078e-041c-4bce-b024-6c490bdde021"), null, null, "+685 04 (172) 28-54", new Guid("b72dbc44-743b-4e39-a250-af429c1f09a9") },
                    { new Guid("6761e17a-b8b6-4924-9039-36720bd256db"), null, null, "+630 32 (925) 11-68", new Guid("9e9403fb-605a-441d-a83a-f936fec7582f") },
                    { new Guid("67750aad-27ea-4cef-8680-496dfeb92d40"), null, null, "+573 00 (638) 78-61", new Guid("9102f36c-0db2-4a0e-b22a-bcaffabfb757") },
                    { new Guid("67804d25-aa22-4d8b-949e-57d3c9857530"), null, null, "+931 68 (555) 52-94", new Guid("5322c711-eaf5-4b14-8d69-cc6bf8809924") },
                    { new Guid("67b538f4-61ee-4bbb-92bb-5a2ee26536c4"), null, null, "+593 95 (685) 88-40", new Guid("479adb19-03b9-482c-b165-7766492bfdf2") },
                    { new Guid("68434274-47de-4d52-b675-e194a26ffbe7"), null, null, "+20 12 (283) 46-18", new Guid("8c149454-da44-4038-9ece-768e572c5282") },
                    { new Guid("68a9c8dc-8565-4e71-8c89-5d9476bda786"), null, null, "+654 92 (891) 67-54", new Guid("500d7059-5719-42c4-a15e-d4753ba03714") },
                    { new Guid("69b2383c-cb95-4b06-a222-207f6f80b61b"), null, null, "+223 13 (975) 24-32", new Guid("bfb2c3f3-d581-43c3-ad34-2b9af77e293a") },
                    { new Guid("69ce07c2-20bb-4bef-8728-04242cfae3f9"), null, null, "+179 22 (141) 18-96", new Guid("89739d78-901e-4353-8c13-fe879541f76f") },
                    { new Guid("6a0010b8-ac9b-4269-a305-9ba14268dfe8"), null, null, "+586 23 (162) 17-03", new Guid("9981eef1-0435-4903-9860-b16fb734ad1b") },
                    { new Guid("6a8236cb-18c9-46f6-ac6c-c8ff885cdfe4"), null, null, "+322 12 (505) 35-98", new Guid("56460594-4f75-42d8-9106-e7e3ec02c12c") },
                    { new Guid("6aa8135c-449c-4c4f-aa4f-5d5cc6984d17"), null, null, "+23 17 (174) 98-94", new Guid("732ba531-5faf-4b4a-bcac-24d9ca3fcbc2") },
                    { new Guid("6ae62460-ba65-4fb2-b9ef-97a4073ea0ee"), null, null, "+769 80 (527) 91-42", new Guid("f7effd3e-f620-479e-861c-7fb6220a3843") },
                    { new Guid("6afea414-6de4-427d-a9fd-4087ceaec2ab"), null, null, "+798 63 (140) 33-70", new Guid("1fda2339-4864-46e3-bf7d-81a520206ae9") },
                    { new Guid("6b1a6f15-fa03-408a-bec6-15d864656fcb"), null, null, "+625 20 (489) 75-48", new Guid("73cff5d2-f041-4e6e-8857-560606637e86") },
                    { new Guid("6b847ab6-8083-45e5-a6ab-a5526ee4d932"), null, null, "+355 38 (990) 19-13", new Guid("dca6b19f-e9ff-4d07-b3df-fe7e57f8b960") },
                    { new Guid("6bb4cea6-e0c8-439b-aff2-3f611ffb0d51"), null, null, "+43 38 (905) 32-92", new Guid("611b8b1f-53d5-4660-9ad4-e0b57e915bf8") },
                    { new Guid("6bedf90d-efc2-443d-ad91-72c7ff22aa8b"), null, null, "+497 74 (048) 68-86", new Guid("74059a15-c214-4079-bc91-f8aa180574a7") },
                    { new Guid("6c1f16aa-de9c-4978-a49e-451d34de0350"), null, null, "+261 14 (420) 07-94", new Guid("2b62c42e-4571-4d98-bd8d-7ba20ea3e48b") },
                    { new Guid("6ca49968-8415-4680-82ff-9cf513d801e9"), null, null, "+352 87 (428) 83-51", new Guid("49e9f216-cefc-4a4e-a243-81e78152afb7") },
                    { new Guid("6ca85b4e-f19b-4bde-af53-29984637eaf3"), null, null, "+327 39 (241) 88-94", new Guid("1070c404-0d57-4ba4-828e-4ca0d5ec2262") },
                    { new Guid("6caca8dd-362e-4f10-b14d-c4d676aef733"), null, null, "+592 40 (990) 83-19", new Guid("6127ea05-85cc-4ed4-9b13-5998aee91180") },
                    { new Guid("6d0bf08f-4083-4180-b55c-f98034d8b596"), null, null, "+863 51 (793) 32-76", new Guid("4595bfbb-3a7d-407e-b6e6-b5d06b0ded5d") },
                    { new Guid("6d0dc1fe-806f-4e38-9fd4-c707dc25d85c"), null, null, "+23 99 (675) 47-76", new Guid("36afa758-a0b9-4345-9bce-db873a3c22fd") },
                    { new Guid("6e052b8f-d7ab-42d6-bb41-93706cacf35d"), null, null, "+822 58 (032) 65-76", new Guid("7646ca6a-9ad5-4b77-91b7-839412348bed") },
                    { new Guid("6e1d32ba-b586-4b4b-8d95-428e3262a61c"), null, null, "+692 89 (959) 10-80", new Guid("e135b016-8e68-479f-a8e6-0c1dd16d5c2f") },
                    { new Guid("6e20fa35-7ac3-4bd5-b522-dc6292f772d9"), null, null, "+585 79 (773) 20-23", new Guid("ab38dbfc-78a4-4d84-9e77-53448911bc9f") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("6e38910b-736f-4b25-ab34-e42e8b1d7fb1"), null, null, "+561 35 (053) 83-81", new Guid("9beccf2d-f01f-48c2-a830-6db7b7da19dd") },
                    { new Guid("6e84b5dc-8949-4614-9581-cd38f1988b14"), null, null, "+165 59 (522) 83-81", new Guid("479adb19-03b9-482c-b165-7766492bfdf2") },
                    { new Guid("6edae32e-63ac-4056-8872-1086dba670e0"), null, null, "+486 46 (112) 10-62", new Guid("39fc9708-01f3-4ab0-8c26-d5bc00da55db") },
                    { new Guid("6ef442ba-b3db-4b1a-8f98-8f35573c7985"), null, null, "+977 11 (114) 66-88", new Guid("3dc0198e-db0e-4b52-919e-c407fa4dc4a6") },
                    { new Guid("6efa3fa4-08d0-4a52-9288-d3585a97f8df"), null, null, "+313 01 (389) 70-83", new Guid("a339ea33-3188-40c2-9d84-9ea46aa67e82") },
                    { new Guid("70062c76-5266-4c7f-b922-7d0b5d283814"), null, null, "+656 95 (270) 25-30", new Guid("8343d773-e986-49d8-99e9-bd908398b011") },
                    { new Guid("7073e070-3417-454a-9832-ad6d7e645693"), null, null, "+757 47 (136) 89-45", new Guid("1281e6c3-dc02-4e83-a90d-37f640411dfc") },
                    { new Guid("708942df-19e1-40e4-a186-acc805b90597"), null, null, "+730 65 (435) 00-28", new Guid("89f14bfd-f2ad-40fc-8c24-b21398e3c7d3") },
                    { new Guid("719ec300-1616-4488-bd2f-0a7dcf86add7"), null, null, "+392 56 (544) 22-89", new Guid("b40e13af-a00a-45af-a681-b960cb8d6a7b") },
                    { new Guid("71ac49de-0e2c-403a-aa35-7c35c8b4949b"), null, null, "+308 30 (074) 68-04", new Guid("fbcf0085-dd67-4f41-b656-a0c0900baca5") },
                    { new Guid("72fc0ab2-bc3f-4a0a-adf5-0d088e7815ee"), null, null, "+569 01 (403) 82-78", new Guid("af867e87-ddef-4efe-ba16-9ce831f47443") },
                    { new Guid("73db7dc0-8ca1-43fe-a826-73043fd381aa"), null, null, "+696 19 (347) 94-75", new Guid("73953973-c12c-407d-b23d-97f5b010569d") },
                    { new Guid("740a325f-1ee7-4fa0-a9ef-0272c9434769"), null, null, "+40 28 (825) 45-36", new Guid("0c162bb7-00a6-40b1-b35d-bbd2862f363c") },
                    { new Guid("740b9754-f26c-4ef2-9a7e-2f077708d932"), null, null, "+398 96 (858) 95-21", new Guid("a0042a3d-7eaa-4c67-b018-40977ff2a846") },
                    { new Guid("74204820-f3e7-4805-9f01-cd1b7feb0724"), null, null, "+599 03 (825) 65-34", new Guid("f7ba49ab-b88c-4490-8dc0-4a731ec11ec3") },
                    { new Guid("742adf41-0ff8-463c-ace6-6b12a42a2db4"), null, null, "+778 31 (548) 22-33", new Guid("f8c6be38-3b48-44ea-9af5-7fd644c82034") },
                    { new Guid("75f79b2a-6c17-42d6-954e-926de26e9623"), null, null, "+32 07 (176) 97-82", new Guid("045fcec6-e944-4ba4-ab53-e930bdb298c6") },
                    { new Guid("76312688-6b60-4a19-9453-6b4e9aaad708"), null, null, "+389 74 (400) 22-97", new Guid("2956754d-e1ca-4623-bbe4-691ff14c9d29") },
                    { new Guid("76b342ee-58d1-4a1f-b587-52778a081a9a"), null, null, "+813 85 (085) 93-56", new Guid("5881d0e1-89ce-4573-8217-2e4c8ee1688e") },
                    { new Guid("76cb193b-db13-4128-8b66-f607c0acf752"), null, null, "+418 04 (655) 23-89", new Guid("8343d773-e986-49d8-99e9-bd908398b011") },
                    { new Guid("76e1fa0a-df12-4dbe-b97a-c102e4f1ea48"), null, null, "+654 26 (382) 83-30", new Guid("b7f7d261-2525-4477-8b55-bba019231e9f") },
                    { new Guid("76eb50d5-40e0-42bd-9f9e-adde51b87fa6"), null, null, "+449 98 (260) 42-70", new Guid("a3bc456f-939a-42c3-99ed-719e0db5bf18") },
                    { new Guid("77a4e91a-8d82-4f7d-a030-75151f56258f"), null, null, "+393 44 (101) 79-72", new Guid("d62fe5e3-4821-411a-b458-87e89f41f2f1") },
                    { new Guid("77a668fa-5cea-4c51-9549-5278af926bdb"), null, null, "+491 21 (616) 78-39", new Guid("428063f6-fd3a-42bd-b0be-ba01a5e85a84") },
                    { new Guid("77bf94ee-0886-4cad-8205-a4939dce8b28"), null, null, "+392 91 (254) 54-78", new Guid("f8c234a1-e25c-478d-be01-cda21178c47a") },
                    { new Guid("77dfa8b8-3d89-46ca-9ce7-dfec6e9ae4d7"), null, null, "+898 11 (806) 69-91", new Guid("af67d494-10d3-4417-9f74-90816ee69f93") },
                    { new Guid("77f964df-1c83-4b55-b76e-f30d1a2540dc"), null, null, "+516 80 (729) 85-88", new Guid("40c86360-842c-49f4-a03e-2506f27e244d") },
                    { new Guid("781389e3-eea2-4d35-a91d-ca798a6768ca"), null, null, "+75 85 (266) 36-43", new Guid("922f53da-9877-4d56-a64d-6d83331bdbb6") },
                    { new Guid("78246b8f-d658-4a6f-b5c8-9d32b55ac4cd"), null, null, "+257 68 (503) 97-92", new Guid("ac4b1e96-68b1-4502-856c-10b88acf07fa") },
                    { new Guid("782b56bc-ca04-43b0-9d00-0884aa40e144"), null, null, "+116 02 (787) 33-23", new Guid("0edec355-b022-4255-80d6-c530f687d26e") },
                    { new Guid("783dbeba-e648-413d-84f6-c4b004b73a4b"), null, null, "+178 06 (440) 85-46", new Guid("00e8ecc6-7b14-4020-bcbd-1a849d69a8c6") },
                    { new Guid("78481c2d-79b0-4069-9359-7d3ef8be9132"), null, null, "+556 33 (690) 08-75", new Guid("39fc9708-01f3-4ab0-8c26-d5bc00da55db") },
                    { new Guid("7851d9da-989f-4ce6-beb6-2f47a0016664"), null, null, "+985 04 (335) 31-69", new Guid("e6fc9f3f-e447-488c-a497-0bec2a6f9fea") },
                    { new Guid("7862a5d9-9a5d-402a-a482-303a8e8bdc8f"), null, null, "+918 06 (860) 26-90", new Guid("d9b74426-c418-4b51-a42a-af5906c2fcff") },
                    { new Guid("78937b09-1821-47dc-ab8e-7461347a1732"), null, null, "+519 00 (901) 01-64", new Guid("22a1446b-6ffd-488e-8e70-011276aa0ae3") },
                    { new Guid("78f98605-d223-48f3-bf94-37705e528bbe"), null, null, "+138 40 (498) 59-86", new Guid("0fedadae-5c91-4999-9924-42f5fcd0de5b") },
                    { new Guid("793d5f6d-13a2-4de1-9afa-c3aeb3426b78"), null, null, "+182 56 (895) 11-56", new Guid("56780bb1-6c9e-4f24-a024-e244137c0516") },
                    { new Guid("79539a7c-ce78-4258-93c9-42c3295035bf"), null, null, "+533 80 (385) 57-46", new Guid("922f53da-9877-4d56-a64d-6d83331bdbb6") },
                    { new Guid("79618ba5-7105-4f7c-bfad-374c8a48e96c"), null, null, "+858 82 (125) 79-67", new Guid("8988ace1-50ae-4626-95ff-eac9a9aeade6") },
                    { new Guid("79883bd8-6078-487d-b420-f28ebde12f9b"), null, null, "+556 43 (465) 24-12", new Guid("b2085c8a-b530-4404-a522-eaa5962529ec") },
                    { new Guid("79915592-a26d-4b07-bc76-317f4ba5e35a"), null, null, "+121 57 (928) 08-61", new Guid("d6f2753c-e864-40f4-a45e-4096737598aa") },
                    { new Guid("79aaed6d-39ff-4c58-8014-cfc1ab3d529e"), null, null, "+715 60 (459) 53-74", new Guid("4e8f092d-b1e1-47d3-9de6-5d9db26187a5") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("7a5a024e-7bd0-4a93-a48c-3de2b3106933"), null, null, "+281 06 (709) 31-25", new Guid("5c53533c-cf33-43f0-bdab-260275d90d88") },
                    { new Guid("7b866876-feb1-4bef-90e7-5360158ef42e"), null, null, "+393 00 (350) 21-60", new Guid("56460594-4f75-42d8-9106-e7e3ec02c12c") },
                    { new Guid("7bd03813-c160-4a1c-85de-ce967098ff43"), null, null, "+822 02 (023) 69-25", new Guid("4af3e803-6a3d-43c8-9c77-811cb6207644") },
                    { new Guid("7be496b2-a6f4-4ca7-976c-db3e04f6bd29"), null, null, "+255 44 (729) 43-30", new Guid("64677ac4-f6ca-4452-9192-ce10eab5a7a4") },
                    { new Guid("7c59c211-c6b6-47e0-9afb-636535635d54"), null, null, "+962 71 (318) 42-40", new Guid("9e9403fb-605a-441d-a83a-f936fec7582f") },
                    { new Guid("7c8799bd-4341-48a6-be0d-157190060a60"), null, null, "+979 78 (227) 85-57", new Guid("20245acd-f749-41bb-8cfd-f436a4e71e96") },
                    { new Guid("7cb9c10f-a2ce-4509-bc5f-45f968c0b05a"), null, null, "+587 74 (934) 55-15", new Guid("c4b80142-93ac-41b3-b29d-ff4cad905327") },
                    { new Guid("7d29a4bd-d1c1-4b20-b3e6-f14c356659e2"), null, null, "+205 71 (895) 90-20", new Guid("8c658576-57f3-41cc-9a3b-917efb1480d9") },
                    { new Guid("7d64298e-81b7-477b-a49f-27bb3a878d40"), null, null, "+175 73 (279) 36-71", new Guid("e6fc9f3f-e447-488c-a497-0bec2a6f9fea") },
                    { new Guid("7dc814d0-1878-4749-b881-fd8a4397f5ef"), null, null, "+276 74 (281) 81-18", new Guid("8988ace1-50ae-4626-95ff-eac9a9aeade6") },
                    { new Guid("7dfd73b3-2b68-4b41-a62a-7c3426c808ba"), null, null, "+984 45 (440) 33-66", new Guid("7247fafb-5d1e-43fe-a447-5b99c26b77ba") },
                    { new Guid("7e21526f-7a1f-4253-b24c-0f75c720591c"), null, null, "+603 32 (420) 98-56", new Guid("fbcf0085-dd67-4f41-b656-a0c0900baca5") },
                    { new Guid("7e318d10-527a-4572-b05e-94a4b73aa8b5"), null, null, "+477 75 (988) 18-01", new Guid("3b1108de-e27d-4674-b7ff-c1df3b68ae41") },
                    { new Guid("7e65421b-0ddb-43cb-95c5-90f36239e801"), null, null, "+813 80 (607) 63-11", new Guid("25a38376-e74c-46cc-8d4f-292cebbcdffb") },
                    { new Guid("7e808ceb-3a19-4853-a47a-f6d6ad371980"), null, null, "+496 06 (023) 84-42", new Guid("351d8ea5-1894-4ffb-9d93-a257287acb66") },
                    { new Guid("7f02f11c-ac6f-4cd5-a8cb-45866f0ee9d7"), null, null, "+950 27 (217) 85-33", new Guid("8b82d9a1-181d-4f54-aa69-032bffd3d9d4") },
                    { new Guid("80580566-7f39-4b7a-a06f-050f0f6a3e15"), null, null, "+948 81 (904) 54-72", new Guid("a3bc456f-939a-42c3-99ed-719e0db5bf18") },
                    { new Guid("80982d10-e2bb-44ff-977d-96b80d98c394"), null, null, "+505 76 (372) 13-50", new Guid("21aa2202-92c4-4bb8-a2f8-9785eb49fe49") },
                    { new Guid("80c951d9-b2d9-4eb7-8a78-87c70bd33a75"), null, null, "+25 15 (855) 50-15", new Guid("d572b4d3-7e7c-44d5-b1d1-164c1895424b") },
                    { new Guid("80e47b21-f371-4c98-ad75-6d8b1d4f89ba"), null, null, "+33 96 (511) 97-33", new Guid("1fda2339-4864-46e3-bf7d-81a520206ae9") },
                    { new Guid("810b13a3-1a87-45e5-b457-a1eecb430fb5"), null, null, "+472 35 (004) 13-35", new Guid("0615c4c1-b356-478a-abeb-caaccb8742b0") },
                    { new Guid("812e9e09-1c2e-451c-a7c1-07ee5cd9e62c"), null, null, "+258 34 (485) 49-66", new Guid("4b70366e-a511-4254-8c8d-ad820ee7b210") },
                    { new Guid("81950ffd-93d9-487b-aeab-efe4c753afc3"), null, null, "+298 87 (780) 67-94", new Guid("fa671618-4f8c-472d-aad1-18adb7778e70") },
                    { new Guid("81abee59-c9e9-4bb8-ab4e-e0e8fa77af57"), null, null, "+142 22 (202) 75-47", new Guid("4a3be526-6584-46c8-8a1d-041160609d8b") },
                    { new Guid("81d79111-9bc1-4d32-b471-48a70bc7fda7"), null, null, "+954 54 (368) 74-43", new Guid("bfb2c3f3-d581-43c3-ad34-2b9af77e293a") },
                    { new Guid("827accd8-3fa9-48b2-835f-aea4fc60e784"), null, null, "+381 38 (215) 20-61", new Guid("6ceec469-cfb3-42b5-b289-a4c2da0a32dc") },
                    { new Guid("82c59851-1859-4d0e-a6b1-a0e39e492b9a"), null, null, "+299 82 (999) 77-12", new Guid("13164560-3eb6-4f4f-9c11-1f819fc48e22") },
                    { new Guid("82c8aba5-48ce-4360-8dff-096d5dc226e9"), null, null, "+581 14 (630) 65-39", new Guid("a0042a3d-7eaa-4c67-b018-40977ff2a846") },
                    { new Guid("82d99d5c-0010-4e5d-bf48-a2f7c2f27431"), null, null, "+295 90 (073) 01-76", new Guid("9f2db745-dcf4-4a49-a27a-ae15a2f3087e") },
                    { new Guid("82fbe36f-c42a-4929-9d65-e03ae80ae004"), null, null, "+24 01 (116) 79-75", new Guid("65dedea0-0687-4571-93d0-c6cdfefedb38") },
                    { new Guid("836e48b8-fa51-47ec-be49-582677a28f8f"), null, null, "+87 72 (954) 39-24", new Guid("17f01111-498c-4286-9021-ec1a09f4b1ca") },
                    { new Guid("8374e3c6-c319-49cc-a0c5-b06539672485"), null, null, "+60 92 (959) 34-09", new Guid("ff5c3ca9-e336-4c0b-bb16-8a689eb03900") },
                    { new Guid("83d6dea9-541a-4f29-aa7f-78570a1a050f"), null, null, "+638 65 (261) 98-78", new Guid("7b9aa90c-3f91-430e-bbb3-c445e0de9d01") },
                    { new Guid("83e28e15-d038-4dc4-86cc-86089fab4517"), null, null, "+413 23 (477) 21-29", new Guid("cc019092-2135-4dea-b991-c8b67614f148") },
                    { new Guid("83fa0752-0c3c-42eb-a9c7-a4934a121cc8"), null, null, "+325 40 (238) 52-97", new Guid("1e75d073-445f-4291-b366-fe0683c205a7") },
                    { new Guid("841ccb5c-0630-4803-962c-c0c225795966"), null, null, "+786 36 (855) 87-52", new Guid("4f7cd1ca-72e9-46bd-ab1e-ae8fa37d21a4") },
                    { new Guid("8437558c-d78e-4a02-9440-6c90fdcdc6f5"), null, null, "+705 17 (322) 66-63", new Guid("af867e87-ddef-4efe-ba16-9ce831f47443") },
                    { new Guid("84522397-90d4-42e3-a7e1-680740065ebb"), null, null, "+703 77 (391) 49-48", new Guid("f5193487-04f8-4c23-b0cd-90340ebc9154") },
                    { new Guid("846142e6-aa30-405d-ae91-100292bd5b66"), null, null, "+273 96 (980) 17-89", new Guid("09ee89cc-9f4d-4eae-a4f3-731ca2d52102") },
                    { new Guid("848a2093-852b-4abc-b59b-23341ac616f1"), null, null, "+357 57 (623) 75-12", new Guid("0c210681-d608-4ef0-acaa-f6ca1d403524") },
                    { new Guid("850f18a1-b1bc-4d02-9c1f-0e286b195295"), null, null, "+60 76 (627) 78-83", new Guid("371bed01-75b2-47b9-9535-3156b9a4c959") },
                    { new Guid("8526fbfc-1ba7-44ab-b6c1-0093a946bce9"), null, null, "+756 87 (841) 50-75", new Guid("a0042a3d-7eaa-4c67-b018-40977ff2a846") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("852a4f1f-52a9-4ed8-90d8-49815be99c99"), null, null, "+570 20 (866) 08-43", new Guid("624d07fb-c364-4191-b439-aff73116c1d2") },
                    { new Guid("85517dd9-05dd-4210-8088-35ece4656f6f"), null, null, "+943 39 (218) 43-06", new Guid("89f14bfd-f2ad-40fc-8c24-b21398e3c7d3") },
                    { new Guid("85609862-4ee8-4521-96c4-8c2bf57a7cf7"), null, null, "+555 96 (201) 39-88", new Guid("4a66fea0-71b8-4943-90c9-d349550e6fe9") },
                    { new Guid("8674a6d3-e038-4777-a5fa-6c2e56fcaba0"), null, null, "+777 73 (253) 41-60", new Guid("4dd327b9-6a6d-48c5-bd5c-c99248206229") },
                    { new Guid("86c351c7-ef0b-45be-a9ad-c3f4386cb78f"), null, null, "+12 87 (112) 22-12", new Guid("d50ea512-4841-4fdb-b6f1-1805a1f266cc") },
                    { new Guid("874989a0-d10a-41f7-a7c6-666e76b42965"), null, null, "+328 76 (416) 18-06", new Guid("d02ec5f5-af87-4bcb-954a-b24e23737d68") },
                    { new Guid("877a482b-0d1a-4a15-9a20-5a89c6771cf5"), null, null, "+898 25 (580) 84-42", new Guid("74059a15-c214-4079-bc91-f8aa180574a7") },
                    { new Guid("877c3ef9-c344-401d-be0e-6980dfd8d9e4"), null, null, "+16 91 (512) 88-98", new Guid("ddf155f2-6984-4582-b06c-39700b8ecb92") },
                    { new Guid("87c1c332-e41a-4b7c-84c1-51a79184591d"), null, null, "+605 19 (252) 24-21", new Guid("a6098ed7-dc3b-4d11-bcda-a3ba0c8ac2f4") },
                    { new Guid("884cd17c-ae62-4315-bd87-0bab31e1947e"), null, null, "+87 15 (790) 39-55", new Guid("52fe76ad-4c09-4b99-9385-e407990c0307") },
                    { new Guid("88541300-75ba-427c-b835-6855a01099a2"), null, null, "+583 63 (599) 04-71", new Guid("ce3412db-b24b-4f68-8e32-724c140b7d0a") },
                    { new Guid("893acae2-1c64-48e7-a1b1-7731bdeb6c3f"), null, null, "+195 24 (346) 13-61", new Guid("a5e0abc8-bc40-47e6-bf22-077c758ba0a7") },
                    { new Guid("8948208c-5d95-4b58-8605-4a270c7cd17b"), null, null, "+295 32 (346) 97-50", new Guid("9981eef1-0435-4903-9860-b16fb734ad1b") },
                    { new Guid("8970507b-8399-4803-82e5-b4d8e4640c79"), null, null, "+874 05 (216) 27-55", new Guid("8d7de522-82d8-4912-bf1a-5d80658097e7") },
                    { new Guid("8a67c1e1-212b-418c-8e4f-add0fc491949"), null, null, "+914 11 (309) 88-12", new Guid("af67d494-10d3-4417-9f74-90816ee69f93") },
                    { new Guid("8a6c0a5a-1d9f-4009-bd4a-d8089bc7c9af"), null, null, "+215 95 (519) 46-06", new Guid("f498a63d-900c-464a-8fab-e4232968dc8b") },
                    { new Guid("8ad7f992-18f3-40de-bb57-112150dd61a6"), null, null, "+695 91 (224) 37-52", new Guid("85626191-e7df-461f-8d6e-58391f67d36a") },
                    { new Guid("8b032505-38ea-4e01-88af-e9fe12cdfa67"), null, null, "+785 42 (351) 28-71", new Guid("f4909d03-d7ac-4aaf-a6fe-77a88f9fe06b") },
                    { new Guid("8b03afe5-5a53-462f-84c1-69667262c9b6"), null, null, "+681 28 (376) 74-01", new Guid("d50ea512-4841-4fdb-b6f1-1805a1f266cc") },
                    { new Guid("8b2566ba-bd29-4d6a-8c9a-eacc5083c883"), null, null, "+643 33 (879) 33-05", new Guid("b40e13af-a00a-45af-a681-b960cb8d6a7b") },
                    { new Guid("8b2fe07a-1cfe-4a8b-b603-cdf557f5768a"), null, null, "+175 01 (251) 77-39", new Guid("34abae3b-f28c-4c59-a716-fea9a1b0e1bb") },
                    { new Guid("8b342482-08f5-412b-9721-924ea0b247c1"), null, null, "+469 96 (495) 49-70", new Guid("d02ec5f5-af87-4bcb-954a-b24e23737d68") },
                    { new Guid("8b80ba1d-4b40-4c79-b878-d9cdd0771661"), null, null, "+53 72 (809) 88-29", new Guid("c6c5dcc4-cc8e-4484-935f-918264ee4897") },
                    { new Guid("8be757a7-1397-4ae3-a59b-e5b67e721df0"), null, null, "+937 67 (650) 10-72", new Guid("73cff5d2-f041-4e6e-8857-560606637e86") },
                    { new Guid("8c1d20a3-7035-4b07-9939-33c47bc6aa21"), null, null, "+413 68 (623) 28-18", new Guid("d173c22f-aa53-4e3b-b137-bcd6d2faf814") },
                    { new Guid("8c814671-2fcf-4d5c-bc1b-626a08cfaec0"), null, null, "+817 09 (922) 25-79", new Guid("c1169f01-6528-4f74-aa56-802f48a7ece8") },
                    { new Guid("8cd36e98-6d99-4d85-9bdf-222678bc03ba"), null, null, "+697 63 (327) 04-49", new Guid("9f2db745-dcf4-4a49-a27a-ae15a2f3087e") },
                    { new Guid("8ce95452-9a07-4f2c-8333-663e493e3968"), null, null, "+129 20 (419) 58-54", new Guid("5146be01-925a-447f-b871-b7de98b487df") },
                    { new Guid("8cf8bdb2-2c9a-4ebe-9795-4c07f90506c9"), null, null, "+253 93 (536) 63-05", new Guid("49e9f216-cefc-4a4e-a243-81e78152afb7") },
                    { new Guid("8d5b399a-d0f8-4210-b6aa-ecb3ad371a4d"), null, null, "+651 75 (575) 45-54", new Guid("efacb463-5422-4958-902a-44c5cd16f26b") },
                    { new Guid("8d963ab2-01bf-4f80-a3a6-ccc9f5a5dd0a"), null, null, "+947 88 (398) 25-37", new Guid("7b9aa90c-3f91-430e-bbb3-c445e0de9d01") },
                    { new Guid("8dad60b2-918e-4386-bff8-5bc70cb5b67d"), null, null, "+413 44 (339) 11-56", new Guid("89f14bfd-f2ad-40fc-8c24-b21398e3c7d3") },
                    { new Guid("8e8c78e6-90c0-43f7-bfd8-74910470740c"), null, null, "+880 02 (089) 08-16", new Guid("64677ac4-f6ca-4452-9192-ce10eab5a7a4") },
                    { new Guid("8f166cd3-2ccc-4753-a5a0-3f071f074d30"), null, null, "+689 19 (264) 96-16", new Guid("b2abd3eb-7d4b-49b1-8a46-4ea8b8313ab8") },
                    { new Guid("8f1f96c8-53d4-473e-a1fa-866b85f8febb"), null, null, "+206 64 (578) 12-56", new Guid("5af211a7-f736-4b52-b2bb-493388054061") },
                    { new Guid("8f3fe78c-5964-4bbe-b76f-d6714e41810f"), null, null, "+296 81 (723) 04-88", new Guid("8180db6e-0139-48fa-a7bc-8424ac74378c") },
                    { new Guid("8f9d37f5-12c3-4cdb-8304-3c358fd0f366"), null, null, "+739 47 (253) 08-09", new Guid("7e04a2e8-5af7-4c5e-8b81-d51fb8eb210b") },
                    { new Guid("8fd89fc5-ae1c-48b3-b53e-68c8b2bc350c"), null, null, "+377 27 (419) 06-05", new Guid("a1e9eb46-748f-4b86-8554-7ae48675b2da") },
                    { new Guid("902e9218-8b39-414c-a89b-3164a1c3bf22"), null, null, "+436 56 (144) 70-05", new Guid("dca6b19f-e9ff-4d07-b3df-fe7e57f8b960") },
                    { new Guid("905460d4-2062-4d7d-8827-7bf7ad1b117c"), null, null, "+674 56 (112) 26-50", new Guid("f3ea0004-e1e2-4557-a9d5-14a5369a2eb3") },
                    { new Guid("90ab8b6a-ea2e-4043-81b9-341767d03488"), null, null, "+126 89 (619) 22-87", new Guid("8c658576-57f3-41cc-9a3b-917efb1480d9") },
                    { new Guid("9118694c-9675-4a3f-9fb0-23351aa17402"), null, null, "+436 36 (573) 15-49", new Guid("750c9633-57cd-4cce-b195-c19394ee24b3") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("915ac125-c34a-4cda-88c5-3fae3982bac9"), null, null, "+977 91 (503) 13-64", new Guid("f78b821b-0629-4e64-a36a-3d10ad04e07a") },
                    { new Guid("91a5c36b-b65a-47c8-81c5-faf2991ff34b"), null, null, "+12 70 (245) 10-18", new Guid("c78c659a-335a-4de3-940d-5ed29586f5d9") },
                    { new Guid("91be4cb9-bd67-4026-a168-4069b21fa731"), null, null, "+190 43 (327) 11-33", new Guid("07169b5c-40fd-40ba-b01e-8b56de466065") },
                    { new Guid("91e75f50-17f6-44e4-af57-39c041e11649"), null, null, "+369 79 (562) 79-62", new Guid("6d64cb25-3e39-4da8-a0e1-a3ee13dd1071") },
                    { new Guid("93d4f725-c0ad-44b4-b80e-4a274e0f98d3"), null, null, "+246 17 (055) 29-06", new Guid("bdd49191-641c-4843-a442-069a71c65be5") },
                    { new Guid("9432a025-624a-4b34-99e0-7acd313d6810"), null, null, "+66 80 (918) 15-78", new Guid("52fe76ad-4c09-4b99-9385-e407990c0307") },
                    { new Guid("948028b5-374c-4288-b802-84a3ebd35c0c"), null, null, "+799 68 (010) 33-37", new Guid("37e41091-f10f-4b14-b68d-be058cea2e03") },
                    { new Guid("94a51c14-d21a-466d-9e6f-dc37841aaf9d"), null, null, "+235 71 (421) 66-62", new Guid("09ee89cc-9f4d-4eae-a4f3-731ca2d52102") },
                    { new Guid("9531f62b-fbf7-428a-83e7-3b3a7e3de61d"), null, null, "+375 21 (591) 28-06", new Guid("20245acd-f749-41bb-8cfd-f436a4e71e96") },
                    { new Guid("95c2cc77-8458-4143-8f5e-5d748e53f042"), null, null, "+150 18 (641) 29-80", new Guid("7f1920c1-828a-4d44-abe8-9db2c3bea2a0") },
                    { new Guid("95fa7613-a7b4-43a3-ad0d-ff6561fbd49f"), null, null, "+418 11 (384) 47-66", new Guid("011fba87-398c-42ec-9aa7-ffb9c48fe9a9") },
                    { new Guid("9607232d-bcba-4c29-8312-d076e36fe4e8"), null, null, "+299 12 (762) 73-92", new Guid("fa671618-4f8c-472d-aad1-18adb7778e70") },
                    { new Guid("968a9a5c-25ca-4d00-8dda-26115fb6d9ae"), null, null, "+271 03 (126) 22-20", new Guid("ebc46bc5-40b3-40f7-b23b-cc974fa9b051") },
                    { new Guid("96bb57ec-e83b-4209-914e-215613b6e238"), null, null, "+585 91 (179) 00-24", new Guid("19d85480-882e-40f7-a536-84a552b3e447") },
                    { new Guid("96e4c6a0-9b52-41ae-bc8f-2d817787b1a5"), null, null, "+119 36 (446) 13-70", new Guid("3af6d087-276b-42a2-9c69-d7501840f5a1") },
                    { new Guid("9709b9f9-c8c8-4466-8d53-281aa5f296d3"), null, null, "+191 95 (907) 94-90", new Guid("59e5a95d-f3ce-47fe-a7c9-70a6b47faac1") },
                    { new Guid("976b7e1f-4c96-4e3c-bfd7-3d6fe5918a08"), null, null, "+351 38 (173) 60-25", new Guid("37f65b1e-268a-4a07-9f55-107b4df3c700") },
                    { new Guid("97b2186f-dd07-442b-92df-de490d019382"), null, null, "+547 16 (896) 12-03", new Guid("b2085c8a-b530-4404-a522-eaa5962529ec") },
                    { new Guid("98171e91-133c-4395-8ee8-630206059a43"), null, null, "+594 48 (943) 11-06", new Guid("7adbc5f0-6d2f-4d16-ad51-1b76edd52481") },
                    { new Guid("9879f9bb-c365-405e-bbb7-ccfafd4fab7a"), null, null, "+38 19 (581) 32-29", new Guid("4b70366e-a511-4254-8c8d-ad820ee7b210") },
                    { new Guid("9b8fa7b2-9cdd-49ac-8dba-95c72d018dd1"), null, null, "+675 05 (116) 55-88", new Guid("f3a37729-6cc8-4507-9aa5-d44c334bc0a7") },
                    { new Guid("9bcb5ad5-9127-4d26-95e2-fcbe5fe91a0d"), null, null, "+272 29 (064) 15-68", new Guid("a5e0abc8-bc40-47e6-bf22-077c758ba0a7") },
                    { new Guid("9d1579f6-040f-4934-ac20-ec2736545d92"), null, null, "+325 08 (195) 69-73", new Guid("99d66586-6373-4afb-b333-7c5cb91075c4") },
                    { new Guid("9d2b0422-5e76-43b7-9b5f-d78cef888c94"), null, null, "+416 76 (802) 34-94", new Guid("712b2e8f-feec-4b44-842e-63c59bbe48cb") },
                    { new Guid("9e5a1c34-e1a5-41b9-a343-8b1c9546926a"), null, null, "+983 20 (842) 11-80", new Guid("58e47d27-16f3-4806-acf1-7b73ccbc0d5e") },
                    { new Guid("9ea3ed32-6bad-4d0e-84a6-9c882ce3e47d"), null, null, "+846 14 (946) 43-59", new Guid("143cf7ff-f2e3-444c-a15b-3aa7b4c43475") },
                    { new Guid("9f55415d-0b9b-466c-b57a-7254169e5184"), null, null, "+721 09 (402) 49-06", new Guid("5af211a7-f736-4b52-b2bb-493388054061") },
                    { new Guid("9f853a52-ed48-4ccc-a902-c08906b56e84"), null, null, "+591 87 (067) 82-63", new Guid("c9b88753-217a-4bb2-ac30-4bed75d66c61") },
                    { new Guid("9f9e6ac7-b95f-46ec-82f6-bcb5ba3be7a9"), null, null, "+666 42 (215) 20-89", new Guid("9252c306-249a-4267-8ef5-891d8c0cbea1") },
                    { new Guid("9f9f3bb8-830d-4508-8cc4-c6cde004df85"), null, null, "+95 91 (422) 55-45", new Guid("e0518a7c-2290-4dde-8de0-19fe26c3d8fa") },
                    { new Guid("9ff5f71c-d7e1-48e1-ab35-2b5208515868"), null, null, "+599 06 (587) 05-33", new Guid("f7ba49ab-b88c-4490-8dc0-4a731ec11ec3") },
                    { new Guid("a01b9b1b-9590-4e68-83ac-c599e4f4a983"), null, null, "+577 85 (688) 01-38", new Guid("4527938d-6c0c-424e-8f7a-6d20b4f7a9f0") },
                    { new Guid("a07d4291-b0d6-424b-9ccb-3924fa258884"), null, null, "+309 06 (178) 00-72", new Guid("09378928-71be-4297-b8fb-ea5311bf5963") },
                    { new Guid("a08be6df-1862-4d24-b9f1-1c6b5f68fcce"), null, null, "+288 48 (948) 42-29", new Guid("0763ce92-5a2c-4138-ad42-41c5b45988dd") },
                    { new Guid("a13d0831-4d80-43d7-90c1-50840064bc6f"), null, null, "+305 83 (480) 19-83", new Guid("d52df32f-0260-40eb-8234-13ab7a744fcb") },
                    { new Guid("a164e197-5e49-46b3-b4b8-ef18a9051af1"), null, null, "+391 03 (480) 41-94", new Guid("f3a37729-6cc8-4507-9aa5-d44c334bc0a7") },
                    { new Guid("a1937d05-969d-4aef-9867-d83633a6349a"), null, null, "+847 23 (553) 41-30", new Guid("243b9c2d-ab41-4ea2-b445-092baa8385bc") },
                    { new Guid("a1aa91c7-1851-4662-a4f4-f1d6627b936b"), null, null, "+685 78 (935) 13-25", new Guid("34c24f57-b16e-4b0f-abe2-5cb9c260e918") },
                    { new Guid("a253f608-ae13-43a5-880b-17d9c4daee01"), null, null, "+502 82 (102) 65-53", new Guid("af831e9b-a557-4f53-81e7-2278eb8802a1") },
                    { new Guid("a25b6925-8ef6-4795-b541-4c6b224518ac"), null, null, "+791 98 (461) 21-51", new Guid("2275ad3d-6816-4c2b-ba9c-96a3dc4f45fb") },
                    { new Guid("a27a936c-13f5-42f1-894a-8c9829619f02"), null, null, "+626 64 (795) 01-44", new Guid("a5e0abc8-bc40-47e6-bf22-077c758ba0a7") },
                    { new Guid("a29e87fd-3cde-4f5f-9af2-e19fd7d60d42"), null, null, "+970 89 (644) 10-07", new Guid("c6c5dcc4-cc8e-4484-935f-918264ee4897") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("a2c4a309-5d15-4ffd-8acd-64a690eb006f"), null, null, "+856 24 (359) 50-58", new Guid("40c86360-842c-49f4-a03e-2506f27e244d") },
                    { new Guid("a2e69eb2-0ae8-454f-bfff-dec5a4b96080"), null, null, "+824 66 (030) 83-51", new Guid("351d8ea5-1894-4ffb-9d93-a257287acb66") },
                    { new Guid("a30c4c48-9d3e-4f1c-a45b-3a5aefe0a7f8"), null, null, "+729 00 (198) 25-67", new Guid("db9ac887-f173-4f7b-ad02-6d19fdd7b12e") },
                    { new Guid("a35980c9-6e34-4e2a-9160-1a912ace58ef"), null, null, "+392 38 (284) 72-22", new Guid("712b2e8f-feec-4b44-842e-63c59bbe48cb") },
                    { new Guid("a3634f5d-45bb-4e60-93dd-a68a4e60be94"), null, null, "+273 34 (464) 10-99", new Guid("7319b27d-6146-4420-aa8d-717913c33345") },
                    { new Guid("a372b75d-0f94-40e4-8940-9f3f422c53a2"), null, null, "+521 16 (082) 73-14", new Guid("fce6a3fa-2769-41fb-ad0b-94fcfc2caab0") },
                    { new Guid("a3b2f64e-8ccd-4e4a-8b1e-358dab229683"), null, null, "+439 63 (871) 24-65", new Guid("5d61541c-3ac1-459c-b0d4-0bbe121306da") },
                    { new Guid("a3d5cfd3-994b-4403-b520-7fdaac9ed39b"), null, null, "+741 28 (554) 22-41", new Guid("00e8ecc6-7b14-4020-bcbd-1a849d69a8c6") },
                    { new Guid("a4a2fa94-1e40-4aaa-ad3b-570ca87b75ab"), null, null, "+620 14 (491) 81-73", new Guid("c6c5dcc4-cc8e-4484-935f-918264ee4897") },
                    { new Guid("a4c64ada-8b00-4f25-9bf3-db6c49488317"), null, null, "+730 53 (512) 58-77", new Guid("92fa424c-9623-4989-b9fe-494533664c26") },
                    { new Guid("a4da99fc-8fb8-446e-a602-910c9880819e"), null, null, "+762 39 (576) 98-85", new Guid("85626191-e7df-461f-8d6e-58391f67d36a") },
                    { new Guid("a4f88a27-6aa3-4d3d-b528-15a5eaca9b8a"), null, null, "+288 14 (458) 70-41", new Guid("8b82d9a1-181d-4f54-aa69-032bffd3d9d4") },
                    { new Guid("a5c96980-86ee-4780-9f57-31113e6ee79e"), null, null, "+118 66 (362) 27-92", new Guid("abfe1efb-0a8f-4af4-ab49-6de94e3ef374") },
                    { new Guid("a5e9f120-f107-44d8-bc22-17aa28c91018"), null, null, "+689 81 (406) 63-91", new Guid("a66e6d00-7000-4eb2-994b-a38594503957") },
                    { new Guid("a5f123ac-7a86-4f63-8142-893f74c1b298"), null, null, "+300 16 (783) 85-28", new Guid("ce3412db-b24b-4f68-8e32-724c140b7d0a") },
                    { new Guid("a61630ef-da36-42f2-a78b-e0af09d4047c"), null, null, "+93 64 (015) 84-52", new Guid("d02ec5f5-af87-4bcb-954a-b24e23737d68") },
                    { new Guid("a6202d3b-3e73-4bf3-a2ac-7b78c3d91849"), null, null, "+901 92 (841) 54-35", new Guid("a4fd1dcd-4db0-4a8a-9303-ecaf58ed8a81") },
                    { new Guid("a6efcfb1-2fc0-4f79-98fc-3cab1bfde356"), null, null, "+306 91 (174) 65-74", new Guid("7adbc5f0-6d2f-4d16-ad51-1b76edd52481") },
                    { new Guid("a755d2fa-c01a-4ea2-ab6e-011071c1269b"), null, null, "+92 17 (945) 71-71", new Guid("b7065d5a-6bbd-485c-bd51-6a4a0fc35e18") },
                    { new Guid("a79f0d8a-77a9-42a0-8d73-b2a94ce5e002"), null, null, "+367 58 (217) 21-32", new Guid("34c24f57-b16e-4b0f-abe2-5cb9c260e918") },
                    { new Guid("a79f48b1-0445-48a5-9faa-bf251603d2ad"), null, null, "+488 26 (795) 82-29", new Guid("ac4b1e96-68b1-4502-856c-10b88acf07fa") },
                    { new Guid("a7d3d67b-22f4-4bf2-9f87-8bce8d21b074"), null, null, "+559 93 (884) 23-99", new Guid("af831e9b-a557-4f53-81e7-2278eb8802a1") },
                    { new Guid("a839cd2c-af17-4766-abd9-6d96b23d1148"), null, null, "+98 17 (512) 89-52", new Guid("c1169f01-6528-4f74-aa56-802f48a7ece8") },
                    { new Guid("a85a01a6-972d-4d89-aaf3-962130f67093"), null, null, "+456 93 (032) 32-23", new Guid("58e47d27-16f3-4806-acf1-7b73ccbc0d5e") },
                    { new Guid("a8677a63-4d0e-4eca-a27a-49299daeb7ab"), null, null, "+701 72 (795) 85-81", new Guid("ea94f56c-ef76-423b-81af-2da80b37dfa6") },
                    { new Guid("a8cc3fa4-b720-41fa-a96c-2b2704dd68f9"), null, null, "+895 13 (117) 32-77", new Guid("c6d62b30-8c4e-444d-a56a-cf5bea9f9c2a") },
                    { new Guid("a94f0b89-e4d2-471d-b75d-75899a562569"), null, null, "+385 33 (427) 74-12", new Guid("2956754d-e1ca-4623-bbe4-691ff14c9d29") },
                    { new Guid("a99e9e6a-7e13-4639-a3b6-69e9a329755b"), null, null, "+893 75 (989) 70-03", new Guid("f498a63d-900c-464a-8fab-e4232968dc8b") },
                    { new Guid("aa1cfd0a-1e23-4272-9436-7e06c4681382"), null, null, "+300 29 (991) 61-69", new Guid("d50ea512-4841-4fdb-b6f1-1805a1f266cc") },
                    { new Guid("aa4e784e-a5a2-45aa-8f7c-cdcda59b9a0b"), null, null, "+237 63 (335) 38-88", new Guid("34abae3b-f28c-4c59-a716-fea9a1b0e1bb") },
                    { new Guid("aabfe256-7a04-4e4b-bf71-438f5948e4f5"), null, null, "+496 67 (317) 90-41", new Guid("11e566bf-b29d-4651-8e8c-7f65a8281c80") },
                    { new Guid("abb9b9a6-9a56-46c2-a517-ac329f8194b2"), null, null, "+91 31 (377) 91-78", new Guid("74059a15-c214-4079-bc91-f8aa180574a7") },
                    { new Guid("abbf7e15-98b0-448e-996f-06514c942d85"), null, null, "+492 50 (270) 11-03", new Guid("5398a079-6d82-4f82-8917-3f9eea9310eb") },
                    { new Guid("abc2e26c-973f-4942-8e36-7d7dd8f733c6"), null, null, "+429 05 (507) 71-38", new Guid("732ba531-5faf-4b4a-bcac-24d9ca3fcbc2") },
                    { new Guid("abf67eba-d4f9-411c-96a8-e76082f5a6d1"), null, null, "+133 68 (717) 91-43", new Guid("7247fafb-5d1e-43fe-a447-5b99c26b77ba") },
                    { new Guid("ac03fd4c-4079-419b-84b7-183dca371818"), null, null, "+123 61 (460) 64-54", new Guid("56460594-4f75-42d8-9106-e7e3ec02c12c") },
                    { new Guid("aca2381b-4829-4219-9db9-f8f0c81ec4fb"), null, null, "+971 03 (423) 92-71", new Guid("1548ab99-88de-44e5-8fb2-0ecadca929aa") },
                    { new Guid("aca6f2fd-dccf-48cf-8209-43a2f986d5e9"), null, null, "+324 25 (674) 33-51", new Guid("611b8b1f-53d5-4660-9ad4-e0b57e915bf8") },
                    { new Guid("acda3ff4-e296-4b19-8bbe-894da464728b"), null, null, "+57 26 (822) 62-70", new Guid("ef8bcbb3-fff2-4f2c-aa48-9ad3e0312130") },
                    { new Guid("ace1840a-fba7-4cb3-a067-5ce93c27cf8d"), null, null, "+433 96 (086) 89-21", new Guid("0c210681-d608-4ef0-acaa-f6ca1d403524") },
                    { new Guid("acf5cc37-4888-4c78-9b0f-0c54a3aee937"), null, null, "+788 04 (494) 77-84", new Guid("5146be01-925a-447f-b871-b7de98b487df") },
                    { new Guid("ad0c2e11-06dd-4587-a031-371e23c05aeb"), null, null, "+861 91 (500) 20-54", new Guid("1070c404-0d57-4ba4-828e-4ca0d5ec2262") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("ad2b8a7a-6173-4be6-b885-0491f262a31f"), null, null, "+578 48 (082) 95-22", new Guid("49e9f216-cefc-4a4e-a243-81e78152afb7") },
                    { new Guid("ad2e52cb-df68-40d4-97e2-d15b70403b94"), null, null, "+289 86 (098) 02-62", new Guid("4e8f092d-b1e1-47d3-9de6-5d9db26187a5") },
                    { new Guid("ad5a5fd6-f426-4141-b280-9420602c4d46"), null, null, "+449 12 (271) 84-56", new Guid("65cb2c49-f00f-450e-94e8-540312a9ce09") },
                    { new Guid("ad5de31e-b908-41d3-b1f5-5b60ded19d0d"), null, null, "+787 15 (169) 20-72", new Guid("19d85480-882e-40f7-a536-84a552b3e447") },
                    { new Guid("ada6ed36-7a36-4888-a312-8262d10b5018"), null, null, "+959 01 (020) 93-55", new Guid("68bf203c-5d15-452a-b81b-bb7831c4f579") },
                    { new Guid("ae367de5-499d-491a-830d-8f61237ca945"), null, null, "+210 92 (033) 29-82", new Guid("41e507fd-f435-49b8-a35c-9fba98848542") },
                    { new Guid("ae64206a-a42d-4dff-aec2-46d69e0d5a5e"), null, null, "+660 76 (333) 99-89", new Guid("4dd327b9-6a6d-48c5-bd5c-c99248206229") },
                    { new Guid("aea89976-3069-48d7-85ec-e9275e5abb95"), null, null, "+998 19 (432) 55-04", new Guid("7f1920c1-828a-4d44-abe8-9db2c3bea2a0") },
                    { new Guid("aebec921-0f7f-4e74-8eb8-a143abf563c8"), null, null, "+123 19 (873) 08-12", new Guid("750c9633-57cd-4cce-b195-c19394ee24b3") },
                    { new Guid("b1157f8b-bb5a-4722-9b7a-029b2f235cf0"), null, null, "+496 70 (373) 76-23", new Guid("f7ba49ab-b88c-4490-8dc0-4a731ec11ec3") },
                    { new Guid("b1c61b0b-a30d-42f8-89bb-0e0deb6afa52"), null, null, "+296 13 (832) 11-10", new Guid("11b76a5d-870e-46d3-b3e3-0af0f8f871ac") },
                    { new Guid("b1d28a1b-1dc0-493a-bce2-d9eea80dc60d"), null, null, "+818 65 (032) 67-88", new Guid("ebecc10d-21da-4369-81d7-600c2de48f88") },
                    { new Guid("b2808e0d-2de3-4c3f-b4f8-748a9164038d"), null, null, "+195 96 (466) 95-68", new Guid("09378928-71be-4297-b8fb-ea5311bf5963") },
                    { new Guid("b2b84fa1-6c07-459c-a57e-fea0b14f5691"), null, null, "+984 08 (604) 37-91", new Guid("b9a99c94-3031-4da9-bdf3-33bb288dd6a9") },
                    { new Guid("b2c0f5df-b265-479d-ad37-9b27ee8996ce"), null, null, "+659 37 (399) 46-38", new Guid("7adbc5f0-6d2f-4d16-ad51-1b76edd52481") },
                    { new Guid("b2c2e6b3-571d-4dc4-9e1f-73bb134a3c7e"), null, null, "+524 86 (888) 83-58", new Guid("b9a99c94-3031-4da9-bdf3-33bb288dd6a9") },
                    { new Guid("b2fb0c68-497f-4380-a369-47e7c4085640"), null, null, "+715 67 (758) 41-48", new Guid("09e536d1-50fd-453a-80d5-e8283f64b0da") },
                    { new Guid("b31b24c3-d4c4-47cb-9a8c-e8b8520542a3"), null, null, "+480 81 (905) 63-39", new Guid("5881d0e1-89ce-4573-8217-2e4c8ee1688e") },
                    { new Guid("b34a39c4-ea9e-413e-b410-3ae9778a9383"), null, null, "+444 45 (563) 58-08", new Guid("f52649ec-b9d7-4f35-8295-ec4e2b5c564c") },
                    { new Guid("b353b2e0-073f-4e32-9e35-e6b0a396dea5"), null, null, "+156 81 (136) 24-95", new Guid("f7f5e0b6-df15-4f10-b87e-6503c5e8fb8e") },
                    { new Guid("b3f64b54-89f5-4d8e-aee7-17d6b8dbcb4a"), null, null, "+435 21 (620) 75-54", new Guid("8fca9140-9c2e-4112-9850-cdf3b029b5ac") },
                    { new Guid("b41c6b52-a5d1-4535-8a1c-ccb87484a079"), null, null, "+400 36 (625) 79-54", new Guid("b09cd69c-fd2f-4c43-9227-439aa81d485e") },
                    { new Guid("b4798f7f-7fbe-4dd1-bb43-3ecaf1af2528"), null, null, "+54 60 (030) 04-08", new Guid("53d8997e-27d6-4129-b5f1-0072e7f179bf") },
                    { new Guid("b4d5c023-090a-4614-b8c2-23c39d22b57b"), null, null, "+252 52 (320) 98-30", new Guid("ff5c3ca9-e336-4c0b-bb16-8a689eb03900") },
                    { new Guid("b5285af2-45aa-41ff-8042-4c9c2eb978c7"), null, null, "+90 13 (962) 17-38", new Guid("af267ef9-b2cf-4adf-a9d0-a58e3acadfa6") },
                    { new Guid("b597c25b-51e2-4cb2-b04c-fd67da915a8d"), null, null, "+417 95 (717) 40-33", new Guid("4527938d-6c0c-424e-8f7a-6d20b4f7a9f0") },
                    { new Guid("b626f22d-a12c-48e6-adbf-4d5cea553aa0"), null, null, "+501 35 (662) 57-76", new Guid("2078228d-bb74-4e81-8e84-3dd4a76ea271") },
                    { new Guid("b630d2c1-6512-40ad-b3de-deddc6942a9b"), null, null, "+344 60 (545) 35-40", new Guid("15a8aac9-d692-4882-990e-3e575587579f") },
                    { new Guid("b69bb5a7-5abd-4c4a-8598-40e4940d9803"), null, null, "+987 68 (320) 46-40", new Guid("e0518a7c-2290-4dde-8de0-19fe26c3d8fa") },
                    { new Guid("b6cd18f9-410c-47cc-aff1-84895f353656"), null, null, "+472 13 (508) 51-80", new Guid("bdc35340-f998-4d2c-9ebc-c29624582c95") },
                    { new Guid("b7875103-ded0-4dad-904b-0262ae4cc7bc"), null, null, "+545 69 (810) 02-83", new Guid("a4fd1dcd-4db0-4a8a-9303-ecaf58ed8a81") },
                    { new Guid("b7922458-d542-4776-9dc5-1ce97a72ba37"), null, null, "+953 69 (359) 55-26", new Guid("c4b80142-93ac-41b3-b29d-ff4cad905327") },
                    { new Guid("b79c71a3-d5d0-48bc-af80-35054fb7f33a"), null, null, "+468 51 (542) 77-98", new Guid("a6098ed7-dc3b-4d11-bcda-a3ba0c8ac2f4") },
                    { new Guid("b7a50b83-dc1c-4d2e-b41a-6d981ac2b227"), null, null, "+702 65 (015) 89-68", new Guid("8c658576-57f3-41cc-9a3b-917efb1480d9") },
                    { new Guid("b8241d5a-a837-44fd-b1dc-1d7b609728ef"), null, null, "+225 58 (943) 90-75", new Guid("cd6370e2-d6d7-4cbd-aaac-c3cf98e8cec3") },
                    { new Guid("b8a44678-c8b3-4c0e-946a-759e88dab051"), null, null, "+552 29 (730) 20-21", new Guid("f2fc34d0-f967-4d49-ac54-2191c244d200") },
                    { new Guid("b8a826e0-afd2-4f66-86f3-eafa052d9963"), null, null, "+8 86 (390) 40-57", new Guid("9f2db745-dcf4-4a49-a27a-ae15a2f3087e") },
                    { new Guid("b8d3ef74-b639-44f3-8c64-ec55850df89d"), null, null, "+695 56 (592) 77-68", new Guid("1be28f90-0b14-4642-99f4-d8dd65c3d9f8") },
                    { new Guid("b8e58c40-e94a-49cd-9e75-969883c7bb8d"), null, null, "+616 15 (554) 90-45", new Guid("09e536d1-50fd-453a-80d5-e8283f64b0da") },
                    { new Guid("b8fb4af6-a50d-46b2-ad49-c2ae35173837"), null, null, "+80 74 (033) 39-95", new Guid("5146be01-925a-447f-b871-b7de98b487df") },
                    { new Guid("b90c4afe-78ab-461e-8baf-af776f22bc89"), null, null, "+836 19 (332) 07-27", new Guid("8de401f3-837a-4e09-884e-ddf9af867804") },
                    { new Guid("b9250a4f-d4f2-4e25-95b6-126eae87044a"), null, null, "+408 17 (899) 68-52", new Guid("b2085c8a-b530-4404-a522-eaa5962529ec") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("b926609c-505b-46c4-864b-a344bafb5db8"), null, null, "+194 14 (567) 06-06", new Guid("3af6d087-276b-42a2-9c69-d7501840f5a1") },
                    { new Guid("b92bc07c-89f5-4a00-aba3-a943bd35497d"), null, null, "+284 62 (840) 27-17", new Guid("ab38dbfc-78a4-4d84-9e77-53448911bc9f") },
                    { new Guid("b950a066-8965-4a4d-84d8-2af725c22648"), null, null, "+443 94 (755) 84-57", new Guid("70fe5fa7-69ef-4577-a750-34ca205c0dac") },
                    { new Guid("b98d5f08-71c6-4e6b-95f3-ede8f2221a84"), null, null, "+899 01 (673) 14-95", new Guid("8887b8ab-eb5d-41ad-bac2-3126e85117d1") },
                    { new Guid("ba459d25-b505-443f-a3c6-e5050ab8c914"), null, null, "+852 05 (401) 33-54", new Guid("2f3d1b8f-7590-4d18-9002-4caa22511a8b") },
                    { new Guid("ba9bcfec-7649-4c58-97fb-8f0f7823ea8b"), null, null, "+489 09 (321) 34-67", new Guid("a339ea33-3188-40c2-9d84-9ea46aa67e82") },
                    { new Guid("bb14eae0-dc86-423a-a1d9-e3b246023d2b"), null, null, "+639 46 (537) 27-57", new Guid("8988ace1-50ae-4626-95ff-eac9a9aeade6") },
                    { new Guid("bbfaffc4-7dc3-41df-9b13-6a912b80eb99"), null, null, "+826 16 (812) 66-03", new Guid("500d7059-5719-42c4-a15e-d4753ba03714") },
                    { new Guid("bc2b0508-1902-4c1b-a098-c782343c4ec8"), null, null, "+120 53 (792) 07-66", new Guid("40de2c6f-e29d-4027-93c3-945e76ec015c") },
                    { new Guid("bc9d2d0b-c6b4-487d-89fc-93858b6934fc"), null, null, "+675 20 (362) 06-47", new Guid("13164560-3eb6-4f4f-9c11-1f819fc48e22") },
                    { new Guid("bca53939-a000-42f5-a513-75134b58b3b7"), null, null, "+784 42 (953) 99-71", new Guid("2a79982f-f343-4569-a725-228ecab03718") },
                    { new Guid("bcd5a6a0-ff66-4726-87a7-9aefa5f34cad"), null, null, "+701 61 (143) 44-32", new Guid("ff5c3ca9-e336-4c0b-bb16-8a689eb03900") },
                    { new Guid("bd5a6bc8-f37f-488c-ba73-2cdce7a0ee3b"), null, null, "+230 60 (066) 79-02", new Guid("2956754d-e1ca-4623-bbe4-691ff14c9d29") },
                    { new Guid("be805833-64c8-4a8b-8e2b-c8c1b1db4cda"), null, null, "+279 26 (808) 76-12", new Guid("651f4e42-b7be-4042-92c4-872c1b4a2b36") },
                    { new Guid("bf23e731-1fcd-4803-b886-1b909a1f4823"), null, null, "+550 67 (507) 22-17", new Guid("d02ec5f5-af87-4bcb-954a-b24e23737d68") },
                    { new Guid("bf85491c-94b6-4f81-826d-21e2225d5e94"), null, null, "+761 01 (701) 84-46", new Guid("7319b27d-6146-4420-aa8d-717913c33345") },
                    { new Guid("bf85f7d5-9ca4-4f13-a177-3b9cdec0df7d"), null, null, "+462 90 (654) 44-99", new Guid("1fda2339-4864-46e3-bf7d-81a520206ae9") },
                    { new Guid("c0284b54-a0bc-4758-b73c-30942bc0e48a"), null, null, "+622 51 (951) 78-54", new Guid("5210b0bd-a591-4887-9abb-0f4415c0f467") },
                    { new Guid("c032ec90-7b86-4aa5-91da-a4024af7cb1e"), null, null, "+840 74 (580) 70-70", new Guid("34c24f57-b16e-4b0f-abe2-5cb9c260e918") },
                    { new Guid("c08a7efe-86ce-4845-b47f-f6788950049c"), null, null, "+416 69 (000) 89-12", new Guid("7319b27d-6146-4420-aa8d-717913c33345") },
                    { new Guid("c0aa8516-4a9d-45d5-b55b-d4b71c16f7ee"), null, null, "+726 35 (491) 50-64", new Guid("a4972888-e048-48a4-a351-23bd705a917e") },
                    { new Guid("c1de26d4-085c-45f1-bd18-669f21959581"), null, null, "+142 70 (188) 20-57", new Guid("b2085c8a-b530-4404-a522-eaa5962529ec") },
                    { new Guid("c1e39949-b674-459e-a174-445ead06869e"), null, null, "+681 63 (066) 73-71", new Guid("25a38376-e74c-46cc-8d4f-292cebbcdffb") },
                    { new Guid("c1e43831-3e75-4f06-82b1-47ebd64fc479"), null, null, "+375 26 (335) 88-08", new Guid("e0518a7c-2290-4dde-8de0-19fe26c3d8fa") },
                    { new Guid("c24fe2a1-6c1a-4f56-b6a6-60d32b2a21e0"), null, null, "+324 40 (483) 50-48", new Guid("d52df32f-0260-40eb-8234-13ab7a744fcb") },
                    { new Guid("c3ad4f53-1899-4888-82bc-a11245d25253"), null, null, "+203 16 (004) 67-63", new Guid("c2edd12d-5919-4c5c-b18f-3b1ef2ea8f55") },
                    { new Guid("c3ebcb15-2401-43a6-960d-3adfa2658d92"), null, null, "+331 39 (123) 39-65", new Guid("a4972888-e048-48a4-a351-23bd705a917e") },
                    { new Guid("c3f83b95-ef90-43bd-a76c-bf042f3f66ce"), null, null, "+772 84 (281) 73-40", new Guid("7646ca6a-9ad5-4b77-91b7-839412348bed") },
                    { new Guid("c411fde3-6f0d-497b-81eb-d6b0eeb04398"), null, null, "+437 45 (820) 86-21", new Guid("5210b0bd-a591-4887-9abb-0f4415c0f467") },
                    { new Guid("c42f1573-cfb1-4ff3-8c1a-2e90347e21ef"), null, null, "+238 29 (801) 16-68", new Guid("ddf155f2-6984-4582-b06c-39700b8ecb92") },
                    { new Guid("c44caf36-4dfd-477c-9dd2-d3eaed8c0d69"), null, null, "+194 69 (141) 22-39", new Guid("a0042a3d-7eaa-4c67-b018-40977ff2a846") },
                    { new Guid("c45584db-2f38-4552-8372-ec4f3b9183b5"), null, null, "+106 34 (598) 56-85", new Guid("1548ab99-88de-44e5-8fb2-0ecadca929aa") },
                    { new Guid("c4a98b36-4f6a-4711-aae9-3d78750fceeb"), null, null, "+549 70 (193) 91-06", new Guid("5398a079-6d82-4f82-8917-3f9eea9310eb") },
                    { new Guid("c4d82b45-f258-4dbb-908e-b0cf239f851a"), null, null, "+651 78 (603) 60-77", new Guid("f57190db-67c4-4d7b-9cd1-c8e27a6ac561") },
                    { new Guid("c4da24a5-9b4f-42be-ac4d-7d8b91888e57"), null, null, "+798 62 (855) 51-46", new Guid("428063f6-fd3a-42bd-b0be-ba01a5e85a84") },
                    { new Guid("c4e8ab9a-ba02-49d7-891b-8fcb04874f13"), null, null, "+890 64 (595) 28-22", new Guid("57c213e6-163e-4134-8633-29615daff79d") },
                    { new Guid("c4fcbb1d-cbdf-4c10-90ae-e33eb0df26a2"), null, null, "+644 14 (849) 73-47", new Guid("2f3d1b8f-7590-4d18-9002-4caa22511a8b") },
                    { new Guid("c54c58a0-adbc-44ee-8bd9-20e86fffbfcc"), null, null, "+916 13 (816) 20-51", new Guid("53d8997e-27d6-4129-b5f1-0072e7f179bf") },
                    { new Guid("c59e53b1-34de-4147-85c1-3eccd39a58a2"), null, null, "+969 03 (410) 42-27", new Guid("9f2db745-dcf4-4a49-a27a-ae15a2f3087e") },
                    { new Guid("c718a200-cec8-4dec-9917-8ffd6d692048"), null, null, "+42 11 (452) 29-12", new Guid("f3ea0004-e1e2-4557-a9d5-14a5369a2eb3") },
                    { new Guid("c73e901e-f430-4cab-ae52-7b0c6680aa3c"), null, null, "+984 98 (787) 44-45", new Guid("af267ef9-b2cf-4adf-a9d0-a58e3acadfa6") },
                    { new Guid("c78fc31e-c3d3-43a8-a66d-55a3998a7c78"), null, null, "+914 47 (343) 63-12", new Guid("df2bde0b-bda8-499f-b5cc-cfa7429222d1") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("c7df0596-533b-4faf-a8f0-c95800185bda"), null, null, "+882 59 (527) 54-13", new Guid("92fa424c-9623-4989-b9fe-494533664c26") },
                    { new Guid("c82ceb37-cc60-4901-a9a6-c8195283fc82"), null, null, "+159 74 (001) 70-15", new Guid("aa406ff8-810a-45a6-8b41-5028563ae3b6") },
                    { new Guid("c82f1bbf-28e8-4e07-b750-b976e3e43519"), null, null, "+370 59 (140) 18-01", new Guid("cca9c534-e77c-400e-a849-210326576f8f") },
                    { new Guid("c8fafd1e-03bb-45da-b5fa-5d4961ae28bd"), null, null, "+651 68 (629) 47-48", new Guid("7c403944-d570-486e-9c1f-e40454a443f6") },
                    { new Guid("c90a82cd-e029-45fb-84c1-b99552bd8ae7"), null, null, "+776 66 (490) 66-54", new Guid("1530b862-24b5-484d-8939-50315a49bd13") },
                    { new Guid("c90d25ca-d9ad-4b7c-93ce-f30e9c458061"), null, null, "+516 48 (302) 73-90", new Guid("8dea05e1-92c5-40d9-9159-8e1dcb818034") },
                    { new Guid("c9477487-6364-48a4-aec0-5d92b2898b3e"), null, null, "+777 26 (195) 46-34", new Guid("7975589e-fce3-4ff6-8b4d-4f29aa2e3c37") },
                    { new Guid("c99c04d1-777b-4fc3-8d1e-61f40a2a35a3"), null, null, "+572 94 (755) 17-80", new Guid("0fedadae-5c91-4999-9924-42f5fcd0de5b") },
                    { new Guid("c9c4abac-3a3d-454d-9e2d-0251131a69a5"), null, null, "+969 94 (951) 36-12", new Guid("4a3be526-6584-46c8-8a1d-041160609d8b") },
                    { new Guid("ca9edfb0-37a8-40ee-85bf-97cb79e3959c"), null, null, "+693 84 (074) 38-69", new Guid("5210b0bd-a591-4887-9abb-0f4415c0f467") },
                    { new Guid("cb38cbb6-5f76-46a2-a44a-8e79a59cc200"), null, null, "+125 46 (825) 17-37", new Guid("15a8aac9-d692-4882-990e-3e575587579f") },
                    { new Guid("cb4bd524-83fc-47d3-a5e7-d869ef73fd37"), null, null, "+518 76 (521) 34-51", new Guid("af831e9b-a557-4f53-81e7-2278eb8802a1") },
                    { new Guid("cb70b7b1-c27f-43cc-b446-abd004f5f2ae"), null, null, "+544 48 (029) 02-64", new Guid("ebc46bc5-40b3-40f7-b23b-cc974fa9b051") },
                    { new Guid("cba82150-08fb-42bc-94e8-2d4214a4425d"), null, null, "+229 06 (474) 60-29", new Guid("d173c22f-aa53-4e3b-b137-bcd6d2faf814") },
                    { new Guid("cc0ab300-9b4f-4268-8782-c9819c41680a"), null, null, "+672 71 (940) 51-00", new Guid("2c5320bb-6c0a-46cc-9731-a7b34514e4c1") },
                    { new Guid("cc13d2d2-bf9f-4f52-a9df-1feb337ba104"), null, null, "+609 05 (379) 40-34", new Guid("ea67b8fa-bc9a-4e27-8ba5-f3c2359c883a") },
                    { new Guid("cc1d448b-a6c0-4e55-9abe-1e1aca4f3531"), null, null, "+607 78 (793) 92-89", new Guid("b252505e-f926-4638-a778-09894c7e3345") },
                    { new Guid("cc577354-84d6-47c0-b1fb-1eca2ef1b93c"), null, null, "+124 66 (152) 58-83", new Guid("f2fc34d0-f967-4d49-ac54-2191c244d200") },
                    { new Guid("cc7d7ae3-8673-4df6-9192-02d09a214d20"), null, null, "+512 11 (803) 97-45", new Guid("fce6a3fa-2769-41fb-ad0b-94fcfc2caab0") },
                    { new Guid("cc9fd83a-033c-487b-b9ee-c92b387eedb9"), null, null, "+249 39 (863) 29-91", new Guid("f7ba49ab-b88c-4490-8dc0-4a731ec11ec3") },
                    { new Guid("ccdfcf13-dd41-4efb-abae-510666375cd0"), null, null, "+813 62 (890) 60-48", new Guid("1de915db-ea78-41e7-a3a2-76a8f6311629") },
                    { new Guid("cd0d4a08-a4d3-4b20-a163-083c99d6b2ce"), null, null, "+256 46 (464) 16-92", new Guid("a907043f-86ba-4126-baac-6e2c6eb5871c") },
                    { new Guid("cd279d76-dde0-4630-9cb1-b54b80fadfa7"), null, null, "+275 95 (512) 86-77", new Guid("d62fe5e3-4821-411a-b458-87e89f41f2f1") },
                    { new Guid("cd54e65e-ef91-42f7-b0c8-cbc7c21841ec"), null, null, "+601 12 (722) 18-96", new Guid("dca6b19f-e9ff-4d07-b3df-fe7e57f8b960") },
                    { new Guid("cd6b2c49-4f60-4cd8-88f8-b45916224ae6"), null, null, "+771 44 (777) 21-33", new Guid("40de2c6f-e29d-4027-93c3-945e76ec015c") },
                    { new Guid("cdbf588d-b993-4217-861d-ab530ef9260b"), null, null, "+928 07 (163) 21-06", new Guid("ff5c3ca9-e336-4c0b-bb16-8a689eb03900") },
                    { new Guid("cdc9c73e-0eb6-4eac-a368-f16b32399801"), null, null, "+61 71 (511) 01-22", new Guid("7f857795-bd2a-48ee-bcf8-ec48fdb428ab") },
                    { new Guid("cdcc03ea-04d2-49a9-9d72-e92066e40271"), null, null, "+363 50 (251) 43-47", new Guid("9336f657-bf13-4455-becf-1afff818911b") },
                    { new Guid("ce9c2671-2fe5-4618-851c-b0fb155905c7"), null, null, "+356 62 (483) 99-77", new Guid("0615c4c1-b356-478a-abeb-caaccb8742b0") },
                    { new Guid("ceda6a37-07c8-40bb-a6f7-2e1f24f1bf9c"), null, null, "+633 89 (198) 55-92", new Guid("7a4f4be1-0c5d-43fb-8b70-3e4913ca97a0") },
                    { new Guid("cf7f21df-e045-4844-a566-de7204b58253"), null, null, "+913 85 (531) 07-48", new Guid("e135b016-8e68-479f-a8e6-0c1dd16d5c2f") },
                    { new Guid("cf879181-79c6-4011-b19d-ddffec5437d0"), null, null, "+262 02 (697) 63-47", new Guid("980f1926-46d3-48d9-880c-73d0be9fa1e0") },
                    { new Guid("cfce3c1f-48a1-4b45-aa4d-c79cf2f1682e"), null, null, "+819 38 (704) 52-21", new Guid("b89fe956-f020-4fc2-affd-e06c759e4081") },
                    { new Guid("cfe12b34-0124-4bf6-a38d-b26b205d9e18"), null, null, "+865 71 (343) 46-83", new Guid("750c9633-57cd-4cce-b195-c19394ee24b3") },
                    { new Guid("d01f7d9e-751b-46d3-82e9-93c452d34495"), null, null, "+269 17 (677) 22-40", new Guid("7b9aa90c-3f91-430e-bbb3-c445e0de9d01") },
                    { new Guid("d062507b-a441-4a43-97c7-dc8bcf27ee5e"), null, null, "+847 54 (324) 29-46", new Guid("92fa424c-9623-4989-b9fe-494533664c26") },
                    { new Guid("d0a25f3c-0c30-4663-9d78-2744ebd9e4e9"), null, null, "+565 50 (425) 67-15", new Guid("2956754d-e1ca-4623-bbe4-691ff14c9d29") },
                    { new Guid("d0ef4e36-b54c-4f52-9add-e215b869bf32"), null, null, "+844 95 (384) 43-67", new Guid("85626191-e7df-461f-8d6e-58391f67d36a") },
                    { new Guid("d14cee59-dad9-4588-a7ac-96637dc747f9"), null, null, "+108 18 (113) 12-55", new Guid("eac06870-6688-4254-bca8-fa7f08d81e32") },
                    { new Guid("d17b8e89-efb0-4b75-8d8a-3b8152d461e3"), null, null, "+796 15 (624) 74-59", new Guid("b252505e-f926-4638-a778-09894c7e3345") },
                    { new Guid("d18375ad-e250-4529-91d1-b00e7662f6e3"), null, null, "+950 05 (382) 52-78", new Guid("8988ace1-50ae-4626-95ff-eac9a9aeade6") },
                    { new Guid("d24f3b04-8e44-48be-a5a2-f091685a6c70"), null, null, "+307 07 (202) 20-21", new Guid("c1169f01-6528-4f74-aa56-802f48a7ece8") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("d2884149-3bdb-4b50-9cf6-c70591d9d884"), null, null, "+363 21 (501) 00-80", new Guid("5322c711-eaf5-4b14-8d69-cc6bf8809924") },
                    { new Guid("d29557b3-106d-43a4-b213-18e84ca5a602"), null, null, "+215 35 (674) 86-68", new Guid("8c8ff9a2-2752-46a7-960e-0490c28de13f") },
                    { new Guid("d33c4817-effb-4324-8e34-7bf3e9ca5e8a"), null, null, "+997 21 (865) 52-52", new Guid("ea94f56c-ef76-423b-81af-2da80b37dfa6") },
                    { new Guid("d3d0105c-bb72-453a-9736-ee8d2cdb4c7c"), null, null, "+396 22 (803) 13-07", new Guid("e2fd10a1-4989-4088-ae2b-0b5909314728") },
                    { new Guid("d42ce418-0ba1-4356-8a18-aa2374b33173"), null, null, "+684 57 (870) 12-12", new Guid("89739d78-901e-4353-8c13-fe879541f76f") },
                    { new Guid("d6c92be4-137a-4b6b-ac9e-bccd6e4b8136"), null, null, "+239 43 (299) 63-56", new Guid("08fd0c31-2e97-4cfb-bbf0-9eca4d7bbf0c") },
                    { new Guid("d6e6fe0a-1425-4cec-9e21-05bcb83444f6"), null, null, "+286 15 (229) 49-10", new Guid("db7dd226-4232-45fe-a502-06e0dfd99b42") },
                    { new Guid("d805b1e7-6a00-4f24-8cf5-4b5a0194ea9e"), null, null, "+289 86 (816) 15-12", new Guid("c075bfdf-a5cc-4efb-a6d1-f31b0c4bf344") },
                    { new Guid("d86d33a8-1cd0-453b-88d1-b641dc4ca773"), null, null, "+205 90 (331) 41-10", new Guid("54f16999-7e05-407e-aab8-1c56cdb79653") },
                    { new Guid("d8a1106c-b7b6-424f-858d-9049e0fcd964"), null, null, "+513 71 (356) 21-94", new Guid("ea67b8fa-bc9a-4e27-8ba5-f3c2359c883a") },
                    { new Guid("d8d6a4e0-9600-4ee9-b08b-9686f32be2db"), null, null, "+99 19 (535) 36-78", new Guid("59e5a95d-f3ce-47fe-a7c9-70a6b47faac1") },
                    { new Guid("d944bb53-5990-4892-9eba-90146e1f7a5a"), null, null, "+810 03 (087) 07-98", new Guid("1de915db-ea78-41e7-a3a2-76a8f6311629") },
                    { new Guid("d978a3a8-2a20-41ce-9bf9-36c598c73134"), null, null, "+231 95 (547) 76-59", new Guid("6441d6d0-462e-4346-8bea-ddea048566dd") },
                    { new Guid("da8398bc-3c90-4ac4-84ea-358292650292"), null, null, "+150 48 (375) 11-89", new Guid("5dd3e047-c6f3-412d-b5cb-12b416f99706") },
                    { new Guid("da854219-c60b-4214-b033-cc77a7312ba7"), null, null, "+119 55 (578) 61-07", new Guid("6d64cb25-3e39-4da8-a0e1-a3ee13dd1071") },
                    { new Guid("da8ffdf1-14e8-47ef-8bf7-dd88a77b8fa8"), null, null, "+351 64 (289) 01-56", new Guid("f3a37729-6cc8-4507-9aa5-d44c334bc0a7") },
                    { new Guid("da9970b3-272d-4cc9-ae05-fa7117358265"), null, null, "+108 22 (951) 86-63", new Guid("f78b821b-0629-4e64-a36a-3d10ad04e07a") },
                    { new Guid("daa3dee2-4cd3-45e1-8c3f-dfe8a96df874"), null, null, "+457 10 (251) 36-06", new Guid("dda60091-f993-4d23-997a-ac4774d856d5") },
                    { new Guid("dace5ff0-5d0f-48ff-9f0a-f167e54f2c39"), null, null, "+533 68 (404) 04-97", new Guid("89739d78-901e-4353-8c13-fe879541f76f") },
                    { new Guid("db1679c5-f20c-4273-b001-10fa62ac0586"), null, null, "+850 02 (404) 62-12", new Guid("b09cd69c-fd2f-4c43-9227-439aa81d485e") },
                    { new Guid("db17d330-d279-424f-8512-207d25172ba3"), null, null, "+954 60 (540) 63-94", new Guid("b40e13af-a00a-45af-a681-b960cb8d6a7b") },
                    { new Guid("db3cc11e-15e5-421e-9ea5-9c526ac63055"), null, null, "+989 87 (325) 41-73", new Guid("3b1108de-e27d-4674-b7ff-c1df3b68ae41") },
                    { new Guid("db7b4adc-7be5-4d2b-baad-30cd569763d3"), null, null, "+93 85 (091) 75-31", new Guid("37e41091-f10f-4b14-b68d-be058cea2e03") },
                    { new Guid("db8053f7-3d61-44e0-85a8-aa88eb3ddd00"), null, null, "+919 69 (873) 53-15", new Guid("732ba531-5faf-4b4a-bcac-24d9ca3fcbc2") },
                    { new Guid("dba35e20-f306-4196-a74d-591bea431d22"), null, null, "+530 75 (530) 04-16", new Guid("b89fe956-f020-4fc2-affd-e06c759e4081") },
                    { new Guid("dc6cfba8-8f1e-456a-b686-24272469dcf7"), null, null, "+955 68 (690) 25-99", new Guid("a3bc456f-939a-42c3-99ed-719e0db5bf18") },
                    { new Guid("dd03b387-2c26-43d3-aeb4-94908967777a"), null, null, "+765 53 (704) 85-93", new Guid("7324afd3-dc67-4f31-ab23-e7b052d0c6e2") },
                    { new Guid("ddb6423f-43fc-46d1-a7ea-ff1f282778da"), null, null, "+225 78 (706) 34-49", new Guid("f7f5e0b6-df15-4f10-b87e-6503c5e8fb8e") },
                    { new Guid("ddb906ee-63e1-44b3-97d8-1595c5aba6ff"), null, null, "+841 80 (373) 31-75", new Guid("54f16999-7e05-407e-aab8-1c56cdb79653") },
                    { new Guid("de35034c-6677-46da-9e47-f50d163896f3"), null, null, "+392 04 (747) 71-80", new Guid("7b9aa90c-3f91-430e-bbb3-c445e0de9d01") },
                    { new Guid("de368644-1885-4083-ac5e-67238f219be1"), null, null, "+310 05 (313) 57-12", new Guid("011fba87-398c-42ec-9aa7-ffb9c48fe9a9") },
                    { new Guid("de511ac0-8e39-43df-ad6a-2b0fa7b94d70"), null, null, "+465 67 (991) 79-75", new Guid("750c9633-57cd-4cce-b195-c19394ee24b3") },
                    { new Guid("de908b7a-47f9-4e42-ad82-7acda0a5a930"), null, null, "+616 66 (797) 24-18", new Guid("cc019092-2135-4dea-b991-c8b67614f148") },
                    { new Guid("dea8056f-d4f2-4ffe-ade6-018d68608331"), null, null, "+180 13 (801) 46-81", new Guid("08e9beba-81d1-40e1-9f0f-4d282258b85b") },
                    { new Guid("dea84ede-8d11-4e96-a650-c18737dfe7d6"), null, null, "+228 32 (779) 60-17", new Guid("68bf203c-5d15-452a-b81b-bb7831c4f579") },
                    { new Guid("dea8fd9a-ddc9-4268-905f-c7388257690a"), null, null, "+216 66 (164) 35-16", new Guid("f088f668-331b-405e-b41a-5cc648df081c") },
                    { new Guid("df7d8261-6e01-400d-977d-2b08b9dabc47"), null, null, "+295 02 (978) 22-69", new Guid("e135b016-8e68-479f-a8e6-0c1dd16d5c2f") },
                    { new Guid("df80fe60-5169-42a0-b341-8d44a3f943d7"), null, null, "+388 55 (070) 18-15", new Guid("2293afe4-2408-427c-9960-7223d1291070") },
                    { new Guid("e011aae7-26c3-4ed9-9516-82e526f61ef8"), null, null, "+2 17 (688) 12-45", new Guid("ce3412db-b24b-4f68-8e32-724c140b7d0a") },
                    { new Guid("e020e397-f167-42dc-bd11-ba6e3c08391c"), null, null, "+649 49 (479) 35-34", new Guid("a339ea33-3188-40c2-9d84-9ea46aa67e82") },
                    { new Guid("e08f8a56-7efc-4745-9c65-a918c4af219c"), null, null, "+856 77 (585) 20-68", new Guid("bdc35340-f998-4d2c-9ebc-c29624582c95") },
                    { new Guid("e0a19049-3935-483c-9c8a-5118afcbd385"), null, null, "+543 26 (524) 08-55", new Guid("1be28f90-0b14-4642-99f4-d8dd65c3d9f8") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("e11cae52-90d3-458c-b5b6-fe7da537061a"), null, null, "+445 54 (352) 41-38", new Guid("ab522845-c1bd-4f82-bee3-06f49429e4bf") },
                    { new Guid("e11ddf5a-afb2-4b9f-a228-8dda3c8c4f60"), null, null, "+958 40 (133) 67-24", new Guid("ac4b1e96-68b1-4502-856c-10b88acf07fa") },
                    { new Guid("e1476751-34b2-4078-9084-225d872e9237"), null, null, "+775 47 (680) 38-95", new Guid("00e8ecc6-7b14-4020-bcbd-1a849d69a8c6") },
                    { new Guid("e16a4ba4-5b2e-4975-ac62-f788e2b2a3c5"), null, null, "+839 83 (438) 90-84", new Guid("ce108172-f4b7-4653-a5c3-ff603fbc3a50") },
                    { new Guid("e201d406-a438-4352-b564-a59b56667747"), null, null, "+919 02 (898) 98-72", new Guid("ab522845-c1bd-4f82-bee3-06f49429e4bf") },
                    { new Guid("e21f1144-465b-459d-a192-668840506fe7"), null, null, "+151 02 (230) 72-18", new Guid("8dea05e1-92c5-40d9-9159-8e1dcb818034") },
                    { new Guid("e239145c-8034-49dc-8987-d8fb5713cbe1"), null, null, "+354 48 (756) 22-45", new Guid("6de94a05-0c03-4062-8ab9-57a5bd55b3a5") },
                    { new Guid("e24ee063-de3e-4ff6-afd9-099dff97f63b"), null, null, "+361 26 (263) 53-85", new Guid("b7f7d261-2525-4477-8b55-bba019231e9f") },
                    { new Guid("e2a48b26-2f05-41f6-95be-55983693e98d"), null, null, "+82 20 (307) 17-84", new Guid("4b70366e-a511-4254-8c8d-ad820ee7b210") },
                    { new Guid("e2f22e6f-bb8c-4ba2-83b1-4f2edc974b3b"), null, null, "+124 35 (941) 68-59", new Guid("ea94f56c-ef76-423b-81af-2da80b37dfa6") },
                    { new Guid("e2fc4bf4-81ad-4a59-95c3-d484e7983933"), null, null, "+236 24 (874) 71-15", new Guid("89f14bfd-f2ad-40fc-8c24-b21398e3c7d3") },
                    { new Guid("e3b6e975-79bb-4601-8230-46c7b2a6e64f"), null, null, "+616 67 (752) 32-13", new Guid("f7effd3e-f620-479e-861c-7fb6220a3843") },
                    { new Guid("e3c87c71-a751-4fc9-8780-b4353fca68c0"), null, null, "+655 41 (757) 09-23", new Guid("7247fafb-5d1e-43fe-a447-5b99c26b77ba") },
                    { new Guid("e4ccd258-9ea3-4856-a697-2e2e730e493a"), null, null, "+100 22 (416) 63-78", new Guid("ae3132fe-b0e9-44a8-a734-658de87cc9a5") },
                    { new Guid("e60091d3-d148-47c8-95de-9f60d16b700c"), null, null, "+572 75 (503) 61-98", new Guid("74059a15-c214-4079-bc91-f8aa180574a7") },
                    { new Guid("e7acf575-f86d-4a4b-8f53-798c8c7813be"), null, null, "+926 45 (155) 80-88", new Guid("c0159440-683d-4c76-a904-aa1f4564822f") },
                    { new Guid("e7b5723d-3a78-4045-93c2-9db7c3fe19ad"), null, null, "+84 30 (985) 11-71", new Guid("0d9e85a0-24c2-4c10-b1f2-180d3ceeaaaf") },
                    { new Guid("e7f506b9-e472-4649-9683-e155da3c2296"), null, null, "+625 04 (031) 76-85", new Guid("56780bb1-6c9e-4f24-a024-e244137c0516") },
                    { new Guid("e878d73c-4444-4ae1-b4c4-5b24e28501b8"), null, null, "+380 42 (102) 09-84", new Guid("19d85480-882e-40f7-a536-84a552b3e447") },
                    { new Guid("e88a96d0-4242-4685-b752-3b8a52b23ced"), null, null, "+609 71 (072) 96-90", new Guid("09ee89cc-9f4d-4eae-a4f3-731ca2d52102") },
                    { new Guid("e8db17ed-8be2-4ea3-91c1-40740f5c06f2"), null, null, "+927 28 (601) 30-23", new Guid("600649dd-c6d1-4ff3-9144-03f6ff7e6950") },
                    { new Guid("e9147ca1-2e6f-41d8-b350-0594b451df29"), null, null, "+787 86 (135) 31-59", new Guid("f3ea0004-e1e2-4557-a9d5-14a5369a2eb3") },
                    { new Guid("e935bc75-c269-4525-ba81-415e65496767"), null, null, "+948 39 (758) 77-83", new Guid("a66e6d00-7000-4eb2-994b-a38594503957") },
                    { new Guid("e96531ba-7b7b-4e36-bf2d-3b603a1eff74"), null, null, "+705 43 (180) 71-79", new Guid("bb486a22-0b19-4077-b9ae-8415f7b0c807") },
                    { new Guid("e9690e9f-3007-4795-8787-ff944068e309"), null, null, "+854 80 (343) 32-61", new Guid("0c162bb7-00a6-40b1-b35d-bbd2862f363c") },
                    { new Guid("e98c7550-e677-413c-91a4-07586ec65f20"), null, null, "+972 32 (692) 72-21", new Guid("0643292c-1282-43c9-ae18-5e2311a73db2") },
                    { new Guid("e9a6c1cc-9fb5-4997-97c2-f705617a35ad"), null, null, "+714 71 (548) 63-31", new Guid("73cff5d2-f041-4e6e-8857-560606637e86") },
                    { new Guid("e9c188c1-a1c4-4260-b51b-8dcd039888df"), null, null, "+405 72 (277) 15-33", new Guid("db7dd226-4232-45fe-a502-06e0dfd99b42") },
                    { new Guid("e9ed5a9a-e160-4ec7-b13f-577b826a3ef6"), null, null, "+530 60 (586) 00-13", new Guid("7271d193-6a4b-40d9-ab91-a7d8a07e45bb") },
                    { new Guid("ea0096a2-68d6-4006-a936-56ce59d6d240"), null, null, "+219 80 (249) 07-89", new Guid("1530b862-24b5-484d-8939-50315a49bd13") },
                    { new Guid("eaffe4de-27ab-4219-9c58-a86e1be41ee5"), null, null, "+266 87 (513) 73-42", new Guid("59e5a95d-f3ce-47fe-a7c9-70a6b47faac1") },
                    { new Guid("ebb33821-f8b0-4321-b28a-49defac02f74"), null, null, "+396 02 (022) 44-34", new Guid("7c403944-d570-486e-9c1f-e40454a443f6") },
                    { new Guid("ebe0825d-9433-4961-8c61-5afce253c91d"), null, null, "+226 02 (725) 95-45", new Guid("0dce50e5-ef29-456b-ab6f-c4454c5cfc38") },
                    { new Guid("ec318d92-034b-44d2-9a4c-d10c638885d1"), null, null, "+926 11 (427) 49-12", new Guid("628d01f9-5feb-4e85-a1ac-d03470903a20") },
                    { new Guid("ec6a135b-30cc-491a-8326-9c1092c6e9bb"), null, null, "+545 68 (483) 24-66", new Guid("428063f6-fd3a-42bd-b0be-ba01a5e85a84") },
                    { new Guid("ec856997-7c21-4529-adeb-f49c7e30501d"), null, null, "+304 47 (274) 38-42", new Guid("fbcf0085-dd67-4f41-b656-a0c0900baca5") },
                    { new Guid("ec8abf6d-7352-4a04-b3cc-b72940b606e1"), null, null, "+975 93 (351) 01-99", new Guid("57c213e6-163e-4134-8633-29615daff79d") },
                    { new Guid("ec98e8c9-f6ac-4977-82a7-b7f97bb15968"), null, null, "+789 31 (133) 36-79", new Guid("fc6059ea-998b-4053-8aa0-faef98da998c") },
                    { new Guid("ec99d120-c12b-4a21-8b6b-574857220be6"), null, null, "+394 66 (353) 44-55", new Guid("72c94cd8-c5e7-422d-b184-eeec7158816e") },
                    { new Guid("ecbfa795-2d42-496d-967c-86cb9eaf0c5a"), null, null, "+435 30 (060) 58-61", new Guid("cffc8c5c-aee1-43fa-a247-e83b10ecb56e") },
                    { new Guid("ed0ec10f-c005-474e-8122-6cd00c4fa831"), null, null, "+627 99 (218) 09-77", new Guid("09ee89cc-9f4d-4eae-a4f3-731ca2d52102") },
                    { new Guid("ed2961fc-5607-48cf-b849-2ed29850441d"), null, null, "+628 86 (402) 73-33", new Guid("045fcec6-e944-4ba4-ab53-e930bdb298c6") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("edd6cf15-2e8d-4aa2-958d-f85a13b14d3f"), null, null, "+317 45 (505) 53-45", new Guid("7f857795-bd2a-48ee-bcf8-ec48fdb428ab") },
                    { new Guid("ee30170b-9285-44b4-b0fc-fa9dee80ce0e"), null, null, "+643 27 (618) 52-58", new Guid("5398a079-6d82-4f82-8917-3f9eea9310eb") },
                    { new Guid("ee589137-d28b-46c8-9251-8c34c167474b"), null, null, "+250 89 (303) 61-71", new Guid("e2fd10a1-4989-4088-ae2b-0b5909314728") },
                    { new Guid("ee85c8ea-aa6d-42d4-b398-c2668f3262c6"), null, null, "+668 60 (267) 13-10", new Guid("b89fe956-f020-4fc2-affd-e06c759e4081") },
                    { new Guid("eeb3443e-06d6-4c4f-8cc8-7f7fddbd5385"), null, null, "+270 73 (422) 74-23", new Guid("611b8b1f-53d5-4660-9ad4-e0b57e915bf8") },
                    { new Guid("eeeb3a76-dd60-4924-9d56-6f4a85c6a531"), null, null, "+617 98 (586) 31-90", new Guid("a1e9eb46-748f-4b86-8554-7ae48675b2da") },
                    { new Guid("eefbc3d5-56de-471c-b727-bb5fc85b8dcc"), null, null, "+91 76 (933) 27-34", new Guid("08e9beba-81d1-40e1-9f0f-4d282258b85b") },
                    { new Guid("eefdd3db-59bd-4be2-82ac-1e91bb8e4e5a"), null, null, "+761 25 (748) 01-42", new Guid("77a05cfa-406d-4342-a924-73d56bf2829a") },
                    { new Guid("ef1d1400-450e-4155-9d2c-866dac0b8185"), null, null, "+905 98 (624) 27-81", new Guid("a72d6b0a-25a6-4c67-ac93-cc46cae2d9dd") },
                    { new Guid("eff21ba1-b7c8-4138-be68-c25e9a681ab0"), null, null, "+149 52 (299) 30-49", new Guid("6de94a05-0c03-4062-8ab9-57a5bd55b3a5") },
                    { new Guid("f00e163f-5959-489c-b3b0-d76e1f261fc7"), null, null, "+281 92 (547) 18-44", new Guid("3dc0198e-db0e-4b52-919e-c407fa4dc4a6") },
                    { new Guid("f0a8254f-037d-4d1e-afae-97c58bd7d58f"), null, null, "+90 62 (093) 07-68", new Guid("011fba87-398c-42ec-9aa7-ffb9c48fe9a9") },
                    { new Guid("f0cf6957-5b9b-4388-a085-d9f20bbe67aa"), null, null, "+523 78 (250) 97-75", new Guid("13164560-3eb6-4f4f-9c11-1f819fc48e22") },
                    { new Guid("f0e8c9ee-5f50-43d1-9f4f-a15698b6556c"), null, null, "+360 91 (113) 28-40", new Guid("af267ef9-b2cf-4adf-a9d0-a58e3acadfa6") },
                    { new Guid("f168f0b3-04c0-48ad-a80b-63456834055a"), null, null, "+512 38 (977) 89-62", new Guid("af867e87-ddef-4efe-ba16-9ce831f47443") },
                    { new Guid("f18111b1-db7d-4416-98d1-fa30942ac83b"), null, null, "+987 55 (448) 45-76", new Guid("77f28b3f-3ca9-4819-96c6-bd1e811a39f5") },
                    { new Guid("f1bab7ca-3c7a-42af-9bf2-270b9ff3b31e"), null, null, "+709 50 (041) 81-39", new Guid("f7e08701-d57e-42d3-884d-beb04dee4c45") },
                    { new Guid("f2addb35-3905-456c-a86a-ec8840f3f414"), null, null, "+508 89 (403) 99-42", new Guid("08e9beba-81d1-40e1-9f0f-4d282258b85b") },
                    { new Guid("f2c2d8f9-9d72-491c-ad10-1ac85dcb0512"), null, null, "+916 76 (925) 70-00", new Guid("f78b821b-0629-4e64-a36a-3d10ad04e07a") },
                    { new Guid("f2d74020-1482-4fa2-8932-9e53855ebbf1"), null, null, "+417 91 (667) 80-95", new Guid("bb486a22-0b19-4077-b9ae-8415f7b0c807") },
                    { new Guid("f33af7f3-263c-4f94-98e7-e867fcd2b162"), null, null, "+686 10 (990) 16-75", new Guid("ddf155f2-6984-4582-b06c-39700b8ecb92") },
                    { new Guid("f38600b8-6ec2-43a9-9988-27ba6d5461b7"), null, null, "+745 22 (235) 93-11", new Guid("3359f4d4-fbc1-4174-b3e0-8cc3754ac07b") },
                    { new Guid("f397b19a-8602-42a1-8e9b-8a3498ba46bb"), null, null, "+236 98 (101) 84-41", new Guid("f2fc34d0-f967-4d49-ac54-2191c244d200") },
                    { new Guid("f3c0617d-1ef2-41f9-a717-1ddc8a714dd0"), null, null, "+498 68 (326) 76-49", new Guid("a66e6d00-7000-4eb2-994b-a38594503957") },
                    { new Guid("f40a9f24-4cd7-41d8-bfb4-c01b4bd29612"), null, null, "+754 16 (819) 82-24", new Guid("c2edd12d-5919-4c5c-b18f-3b1ef2ea8f55") },
                    { new Guid("f41938c1-a0b5-47e7-a2c1-37042e648634"), null, null, "+343 00 (966) 02-75", new Guid("3b1108de-e27d-4674-b7ff-c1df3b68ae41") },
                    { new Guid("f4b1e64a-621e-42ce-8756-f8ef310e5e66"), null, null, "+283 22 (347) 99-46", new Guid("65cb2c49-f00f-450e-94e8-540312a9ce09") },
                    { new Guid("f4b3098e-ba34-4584-9c13-40b15be7e656"), null, null, "+393 75 (290) 14-41", new Guid("993e8305-611d-4730-af5d-dbd1e15c6650") },
                    { new Guid("f4e61933-e965-48f2-96ef-0fb4b31a4298"), null, null, "+741 58 (582) 44-21", new Guid("e135b016-8e68-479f-a8e6-0c1dd16d5c2f") },
                    { new Guid("f4ecd62a-b744-43d5-bca0-bb5a8815944b"), null, null, "+4 69 (646) 17-21", new Guid("21aa2202-92c4-4bb8-a2f8-9785eb49fe49") },
                    { new Guid("f566c4e9-a3be-4ae5-a59f-3432260827e0"), null, null, "+33 46 (745) 51-97", new Guid("9beccf2d-f01f-48c2-a830-6db7b7da19dd") },
                    { new Guid("f590a342-fb4b-49c7-9791-edb54d6d02f8"), null, null, "+350 00 (052) 50-90", new Guid("1fda2339-4864-46e3-bf7d-81a520206ae9") },
                    { new Guid("f5c9d2f8-4302-4dee-9335-ea2ec9d11ea9"), null, null, "+387 78 (459) 14-30", new Guid("08fd0c31-2e97-4cfb-bbf0-9eca4d7bbf0c") },
                    { new Guid("f607f145-714b-47cd-aace-7a79b329dfca"), null, null, "+998 15 (008) 35-19", new Guid("5d61541c-3ac1-459c-b0d4-0bbe121306da") },
                    { new Guid("f6a3c486-c525-457f-915e-01b3b69798ce"), null, null, "+572 68 (972) 78-39", new Guid("b2abd3eb-7d4b-49b1-8a46-4ea8b8313ab8") },
                    { new Guid("f7274f69-622d-4f24-9d43-6059d1093492"), null, null, "+232 97 (343) 79-73", new Guid("3b1108de-e27d-4674-b7ff-c1df3b68ae41") },
                    { new Guid("f78da305-4a6e-43cd-9683-fce37cf564b0"), null, null, "+401 84 (315) 06-09", new Guid("9102f36c-0db2-4a0e-b22a-bcaffabfb757") },
                    { new Guid("f79a0690-3dba-4f9a-ad4e-df2d35b4d437"), null, null, "+328 19 (322) 71-13", new Guid("4a1c10a8-7cf3-42b7-9d73-0683e4bc1868") },
                    { new Guid("f7c510d6-8af7-4a76-9d0f-7c74defc59c0"), null, null, "+551 06 (603) 41-88", new Guid("8c658576-57f3-41cc-9a3b-917efb1480d9") },
                    { new Guid("f7db8bce-247a-40ef-9194-0662e28190ec"), null, null, "+334 35 (155) 05-15", new Guid("624d07fb-c364-4191-b439-aff73116c1d2") },
                    { new Guid("f8524770-c982-4215-9534-e57c955694b4"), null, null, "+57 99 (044) 14-25", new Guid("4af3e803-6a3d-43c8-9c77-811cb6207644") },
                    { new Guid("f97fd720-3002-4b12-8c75-5453344f1431"), null, null, "+960 86 (054) 88-38", new Guid("39fc9708-01f3-4ab0-8c26-d5bc00da55db") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("fadc9692-434a-4ce6-8c39-b119969d99fa"), null, null, "+520 59 (477) 60-17", new Guid("68bf203c-5d15-452a-b81b-bb7831c4f579") },
                    { new Guid("fb2c53e1-bc15-41cf-8c9c-931e116f1a79"), null, null, "+607 24 (226) 45-00", new Guid("20245acd-f749-41bb-8cfd-f436a4e71e96") },
                    { new Guid("fb8053b4-b6b9-4fc5-9c8d-636314c760a3"), null, null, "+604 54 (260) 51-52", new Guid("0dce50e5-ef29-456b-ab6f-c4454c5cfc38") },
                    { new Guid("fb92e618-6802-493f-bb73-2e57ac76a328"), null, null, "+158 34 (400) 29-12", new Guid("73953973-c12c-407d-b23d-97f5b010569d") },
                    { new Guid("fbf2f240-a900-4549-acb7-d527694570b0"), null, null, "+420 98 (127) 15-84", new Guid("c4ec53d7-69be-4d5d-9091-29c7f80bd641") },
                    { new Guid("fc298632-97b5-4394-b3a0-ffc2245b8070"), null, null, "+767 92 (621) 91-34", new Guid("09ff0b03-eca3-4596-9c5d-d809a2f99a1e") },
                    { new Guid("fd29b8b9-bd2c-419f-a623-5bb7b8b1d7d6"), null, null, "+932 22 (603) 73-10", new Guid("8d7de522-82d8-4912-bf1a-5d80658097e7") },
                    { new Guid("fd4adb81-691d-426d-8424-791cd420cae1"), null, null, "+504 03 (273) 10-58", new Guid("13164560-3eb6-4f4f-9c11-1f819fc48e22") },
                    { new Guid("fd99d819-087b-4f1d-9a5c-a1845f8dc859"), null, null, "+390 98 (703) 47-89", new Guid("efacb463-5422-4958-902a-44c5cd16f26b") },
                    { new Guid("fdba6845-9127-4590-a4de-f0ac51062e63"), null, null, "+890 00 (804) 63-50", new Guid("f5193487-04f8-4c23-b0cd-90340ebc9154") },
                    { new Guid("fdc5d843-06bb-4a8c-8a95-e211b87c6326"), null, null, "+679 59 (971) 30-76", new Guid("37f65b1e-268a-4a07-9f55-107b4df3c700") },
                    { new Guid("ff2297cc-ab18-4539-8ecd-e6af94d057fa"), null, null, "+927 14 (609) 25-52", new Guid("c075bfdf-a5cc-4efb-a6d1-f31b0c4bf344") },
                    { new Guid("ff3afdb8-7c01-4db9-9d2b-7fa33aa0ed88"), null, null, "+630 18 (125) 89-45", new Guid("f3a37729-6cc8-4507-9aa5-d44c334bc0a7") },
                    { new Guid("ff8779e9-1527-4951-a4ed-1b50fb2c8e87"), null, null, "+564 34 (742) 03-29", new Guid("bdd49191-641c-4843-a442-069a71c65be5") },
                    { new Guid("ffd6a719-20a5-417b-a4c1-07029f10cac7"), null, null, "+585 14 (221) 33-18", new Guid("b7065d5a-6bbd-485c-bd51-6a4a0fc35e18") },
                    { new Guid("ffe744d0-545b-40dd-8988-bd44f94d4e01"), null, null, "+844 16 (054) 42-77", new Guid("41e507fd-f435-49b8-a35c-9fba98848542") }
                });

            migrationBuilder.InsertData(
                table: "UserParcelMachines",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "ParcelMachineId", "UserId" },
                values: new object[,]
                {
                    { new Guid("001fdd9e-7cf1-49f4-93ef-7e3ffc30c0ed"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b2f05962-a786-4985-baff-7fe25f80da84"), new Guid("52fe76ad-4c09-4b99-9385-e407990c0307") },
                    { new Guid("0913f3bb-b7c5-495a-9e4a-926ea95187de"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c784bcfe-36d0-4b0c-8704-ce00df9aaf25"), new Guid("0763ce92-5a2c-4138-ad42-41c5b45988dd") },
                    { new Guid("0f60eea2-d0d7-4e45-bb7c-c1340e088ca8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9fbb29a9-ae36-4935-ad92-c23178967d9d"), new Guid("0edec355-b022-4255-80d6-c530f687d26e") },
                    { new Guid("0f684f2f-1b77-4366-9deb-5770687cbacb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2fbd2df7-a365-4034-a3ed-ca140b6f56e7"), new Guid("5c53533c-cf33-43f0-bdab-260275d90d88") },
                    { new Guid("0fdc7fe4-bb24-47ab-af59-951d4272927d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2f80478b-b139-4be1-8dfa-4c07c181e995"), new Guid("c1169f01-6528-4f74-aa56-802f48a7ece8") },
                    { new Guid("170624f3-4607-48f7-b283-eaf197ac99b9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("151847e5-b028-4f4a-97f3-ff312427cca3"), new Guid("732ba531-5faf-4b4a-bcac-24d9ca3fcbc2") },
                    { new Guid("18c4547f-f40d-49f7-af05-29e935b116d4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("64c5af14-1b67-4c18-882a-2b3c10f834a1"), new Guid("a339ea33-3188-40c2-9d84-9ea46aa67e82") },
                    { new Guid("1cdf334e-7797-4083-9a1a-f40b12c4bb46"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5c1ed58b-5798-4aa9-a762-ad699a0add1f"), new Guid("922f53da-9877-4d56-a64d-6d83331bdbb6") },
                    { new Guid("217111b7-dd7a-4d60-bd38-ed6ea7f106a0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9fef170f-1e7f-472d-8f7f-14880f28c30a"), new Guid("f498a63d-900c-464a-8fab-e4232968dc8b") },
                    { new Guid("220ad459-1dbc-432d-b580-42924afcfb78"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2fbd2df7-a365-4034-a3ed-ca140b6f56e7"), new Guid("4e8f092d-b1e1-47d3-9de6-5d9db26187a5") },
                    { new Guid("23b20b3d-5075-401c-9eda-fe87a2a40df9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("51eaa5e7-cb23-41a3-903a-08e952071f0e"), new Guid("a5e0abc8-bc40-47e6-bf22-077c758ba0a7") },
                    { new Guid("2434df86-dc29-412c-9726-093cb4486804"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("01380607-63a5-4cc4-8034-0bfdf63b03f9"), new Guid("af831e9b-a557-4f53-81e7-2278eb8802a1") },
                    { new Guid("24cb1cc7-b0fa-40f3-a289-764d3815b13a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9f32452f-9559-47c0-aa30-6b1ed2b4fe6c"), new Guid("d173c22f-aa53-4e3b-b137-bcd6d2faf814") },
                    { new Guid("341a6ab2-bcdb-4bf1-8d64-86b9f23d6ab1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2fbd2df7-a365-4034-a3ed-ca140b6f56e7"), new Guid("77a05cfa-406d-4342-a924-73d56bf2829a") },
                    { new Guid("35cd5cfa-216f-44e2-8914-da7f3ef778e1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("151847e5-b028-4f4a-97f3-ff312427cca3"), new Guid("99d66586-6373-4afb-b333-7c5cb91075c4") },
                    { new Guid("37ea9d07-dd3b-4e98-9866-3168c9ed168b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e8b80940-c4e0-4c3b-b2f8-7e13a2103780"), new Guid("f498a63d-900c-464a-8fab-e4232968dc8b") },
                    { new Guid("39dbdae9-6425-45ac-afca-7cbedd4437f6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d5e3b225-a419-4445-99c6-167feee17a79"), new Guid("5c53533c-cf33-43f0-bdab-260275d90d88") },
                    { new Guid("3b0284a7-0d73-48c8-93cd-cb9974a69432"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5a5ae4cb-4ec7-44d3-bf5c-52d4c3752fa3"), new Guid("c78c659a-335a-4de3-940d-5ed29586f5d9") },
                    { new Guid("4037586d-80c9-46bc-95f4-85d396f27251"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("24030200-1363-4a76-8795-b53c08b89b2d"), new Guid("56780bb1-6c9e-4f24-a024-e244137c0516") },
                    { new Guid("411ba9b5-554e-471d-a79a-76bdce67c539"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("40ca667a-ef7b-47f8-ba95-69593445f5e7"), new Guid("611b8b1f-53d5-4660-9ad4-e0b57e915bf8") },
                    { new Guid("4bc67ab8-05c8-4457-a06d-d4533f8901f8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8d0cdc99-c1b2-41c5-8df9-2c2f560ccdec"), new Guid("d50ea512-4841-4fdb-b6f1-1805a1f266cc") },
                    { new Guid("4ea0e946-6e99-498c-98a7-3757d484ecc0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1931b47c-721f-4612-ad7e-ad2bee2c7c3e"), new Guid("07169b5c-40fd-40ba-b01e-8b56de466065") },
                    { new Guid("4fb32e0d-9106-4a40-931f-01aec5937a3a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("940e9b35-b2cc-4c61-b58f-bfce5b310960"), new Guid("e6fc9f3f-e447-488c-a497-0bec2a6f9fea") },
                    { new Guid("51535d1e-c768-47ff-9aa0-cf75f6a2d511"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("87d9f133-f2a8-44ab-8e4d-8a5b46b7f46f"), new Guid("1e75d073-445f-4291-b366-fe0683c205a7") },
                    { new Guid("60cd5156-5642-4dbc-8453-4188fb1821f6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c784bcfe-36d0-4b0c-8704-ce00df9aaf25"), new Guid("b40e13af-a00a-45af-a681-b960cb8d6a7b") },
                    { new Guid("618ef61e-85e2-4edd-93cb-15611a7185cf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a88290cd-ff00-4a6c-a033-19aaf1ce6541"), new Guid("3359f4d4-fbc1-4174-b3e0-8cc3754ac07b") }
                });

            migrationBuilder.InsertData(
                table: "UserParcelMachines",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "ParcelMachineId", "UserId" },
                values: new object[,]
                {
                    { new Guid("63459d3a-5b18-4ce6-acf0-ec0b327d1ec5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2fbd2df7-a365-4034-a3ed-ca140b6f56e7"), new Guid("07169b5c-40fd-40ba-b01e-8b56de466065") },
                    { new Guid("69fee9c7-2b61-4878-b5ff-942958d1664a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c784bcfe-36d0-4b0c-8704-ce00df9aaf25"), new Guid("b40e13af-a00a-45af-a681-b960cb8d6a7b") },
                    { new Guid("6c775d9b-d302-49e9-9ace-e74ba14d9b20"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("18ab745b-5901-4cb0-878e-f134ae2e485d"), new Guid("ab522845-c1bd-4f82-bee3-06f49429e4bf") },
                    { new Guid("6e49e451-d2b4-40db-8dbb-aeca7a2aa083"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("40ca667a-ef7b-47f8-ba95-69593445f5e7"), new Guid("8343d773-e986-49d8-99e9-bd908398b011") },
                    { new Guid("774a13d3-95fa-4062-9b86-031e82b899c6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("940e9b35-b2cc-4c61-b58f-bfce5b310960"), new Guid("5146be01-925a-447f-b871-b7de98b487df") },
                    { new Guid("7e1813ca-4d82-4e47-ae2a-c16df5235d9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8d0cdc99-c1b2-41c5-8df9-2c2f560ccdec"), new Guid("fbcf0085-dd67-4f41-b656-a0c0900baca5") },
                    { new Guid("83009ac2-a91d-4030-ab5e-9bb0f0309d0a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("18ab745b-5901-4cb0-878e-f134ae2e485d"), new Guid("af67d494-10d3-4417-9f74-90816ee69f93") },
                    { new Guid("8a3bb140-e572-40f4-b3f7-cad6bf7f75a4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1931b47c-721f-4612-ad7e-ad2bee2c7c3e"), new Guid("5881d0e1-89ce-4573-8217-2e4c8ee1688e") },
                    { new Guid("927b3914-92f7-4ace-b34e-fb9f7080f212"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c784bcfe-36d0-4b0c-8704-ce00df9aaf25"), new Guid("c6c5dcc4-cc8e-4484-935f-918264ee4897") },
                    { new Guid("937a9260-2d57-45f0-8457-6e32989fe6e6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("962e676f-a4ca-4fff-a4f6-2ab0df2a8da5"), new Guid("f3ea0004-e1e2-4557-a9d5-14a5369a2eb3") },
                    { new Guid("987714ce-5b38-4289-95bc-e39a420bd5dd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a280936f-b2cf-4918-aa88-3301aaf2cc8d"), new Guid("25a38376-e74c-46cc-8d4f-292cebbcdffb") },
                    { new Guid("9db8fcbe-ee96-423c-b585-3a7074e79864"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("fdb5e21e-8527-4184-8e8f-86e9cbd48fe1"), new Guid("c075bfdf-a5cc-4efb-a6d1-f31b0c4bf344") },
                    { new Guid("a1cf7b66-94a9-4704-981d-179000d76568"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("87d9f133-f2a8-44ab-8e4d-8a5b46b7f46f"), new Guid("9f2db745-dcf4-4a49-a27a-ae15a2f3087e") },
                    { new Guid("aae3b875-d8c2-4195-816a-46e8d5d58f7e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ef93ecfe-06f6-495e-9dc5-acdd12667b97"), new Guid("49e9f216-cefc-4a4e-a243-81e78152afb7") },
                    { new Guid("b098c926-97a8-4306-897e-70d5424df4f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("87d9f133-f2a8-44ab-8e4d-8a5b46b7f46f"), new Guid("f2fc34d0-f967-4d49-ac54-2191c244d200") },
                    { new Guid("b4546821-c623-4cb7-b911-372436917215"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5efeb0ec-3747-415b-b3ba-a705ff2d3932"), new Guid("b2085c8a-b530-4404-a522-eaa5962529ec") },
                    { new Guid("b8b3978d-9dee-457e-bf6e-b82397ab0360"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("64c5af14-1b67-4c18-882a-2b3c10f834a1"), new Guid("a3bc456f-939a-42c3-99ed-719e0db5bf18") },
                    { new Guid("b97fc616-e55d-48a4-8d0f-8ed4e4057eeb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5befc4fa-0807-4422-aaaf-352a25d21a39"), new Guid("a339ea33-3188-40c2-9d84-9ea46aa67e82") },
                    { new Guid("bb569431-1d5f-4300-b514-5c3a774e8d65"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5befc4fa-0807-4422-aaaf-352a25d21a39"), new Guid("ab38dbfc-78a4-4d84-9e77-53448911bc9f") },
                    { new Guid("bf703519-7f6c-494c-9e05-141de464c1f9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("da321187-f3fc-4a84-bc08-861172764c47"), new Guid("52fe76ad-4c09-4b99-9385-e407990c0307") },
                    { new Guid("c4253e86-557b-4d4e-bcaa-40f4404a6046"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("43260ef4-c04d-4f8e-bd11-e6f63671c70c"), new Guid("a4972888-e048-48a4-a351-23bd705a917e") },
                    { new Guid("c599bf28-1493-40e3-94f5-0bf1a13369ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8a568205-931c-4c11-bf57-fdb922cfa765"), new Guid("77f28b3f-3ca9-4819-96c6-bd1e811a39f5") },
                    { new Guid("c5e7ca14-b44d-40c3-861f-d3c147858077"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("962e676f-a4ca-4fff-a4f6-2ab0df2a8da5"), new Guid("b7065d5a-6bbd-485c-bd51-6a4a0fc35e18") },
                    { new Guid("c8ced59a-803d-41c5-833a-a02b5a5d25db"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("79c20ee3-8b87-40e6-9e7f-fe8830979726"), new Guid("2f3d1b8f-7590-4d18-9002-4caa22511a8b") },
                    { new Guid("c98def09-75c3-4ec4-9b9a-85bc04182f15"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9819ae1a-ff32-4df5-a0fe-7f349826cf63"), new Guid("b7f7d261-2525-4477-8b55-bba019231e9f") },
                    { new Guid("ca44b599-b7a0-4b43-b03c-0d7950eadbc6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("22965f6c-bc06-49a0-93c4-53258424107a"), new Guid("ce3412db-b24b-4f68-8e32-724c140b7d0a") },
                    { new Guid("ce42d0df-248e-4da7-9bd0-3967865f4e48"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e4eacfff-a470-47d9-bf18-5568f986e21c"), new Guid("56460594-4f75-42d8-9106-e7e3ec02c12c") },
                    { new Guid("ce9925d8-c95b-4d4a-b8c0-7a74ddc09ac0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f53320ac-20ac-4ace-aad8-aa73ca22fd10"), new Guid("34c24f57-b16e-4b0f-abe2-5cb9c260e918") },
                    { new Guid("d84a50c8-802d-421f-8f7e-43e8e2735e93"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a2fb7fb2-4e9b-4c01-ba53-2dac94cad663"), new Guid("0fedadae-5c91-4999-9924-42f5fcd0de5b") },
                    { new Guid("dd7fbfea-2721-4d9b-8621-2f3c961c074a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a88290cd-ff00-4a6c-a033-19aaf1ce6541"), new Guid("fa671618-4f8c-472d-aad1-18adb7778e70") },
                    { new Guid("e0efe3ab-47c5-49ca-9ca5-ba37e322e7e9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3118d99c-620d-4abe-ab00-6d14e9151499"), new Guid("0763ce92-5a2c-4138-ad42-41c5b45988dd") },
                    { new Guid("ebfd3398-ddb7-4d0c-92d3-9fa00590f481"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("423d50e8-cd3d-41bd-b5c9-4f498e0253ef"), new Guid("c1169f01-6528-4f74-aa56-802f48a7ece8") },
                    { new Guid("f4451909-0ff5-4d81-b0b6-ae1c3a400679"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ed93df05-11c6-412c-82f0-8aa75ea66ea8"), new Guid("00e8ecc6-7b14-4020-bcbd-1a849d69a8c6") },
                    { new Guid("fc74f61b-1038-48fe-9e5f-8f729f351384"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("026ff160-607c-4448-9a0e-22224756dce1"), new Guid("ce3412db-b24b-4f68-8e32-724c140b7d0a") }
                });

            migrationBuilder.InsertData(
                table: "UserPostBranches",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PostBranchId", "UserId" },
                values: new object[,]
                {
                    { new Guid("05415b83-820a-46f3-bc56-79ab5830a86c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2b6786ce-bd76-4731-a53a-f0abd337ca7a"), new Guid("07169b5c-40fd-40ba-b01e-8b56de466065") },
                    { new Guid("09f19ccf-33d4-40e7-85b0-c9c5032e5aec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("54fe296c-d00e-4c7b-ac71-14688a8e4a66"), new Guid("e6fc9f3f-e447-488c-a497-0bec2a6f9fea") },
                    { new Guid("0b98620e-efd3-4237-acc8-dbf1a8387d33"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("deedecaf-a242-466d-a663-f0ffc79f4c6f"), new Guid("1e75d073-445f-4291-b366-fe0683c205a7") },
                    { new Guid("11bf96fc-d52a-4537-90ad-c39b100fc6ec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("73e4fc8b-9530-4a6f-8594-a86514779a10"), new Guid("56460594-4f75-42d8-9106-e7e3ec02c12c") },
                    { new Guid("166046a4-30a0-4c6c-971f-dabb5bb14f72"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("63450cab-27ee-4cf8-a92a-999c01d91312"), new Guid("0edec355-b022-4255-80d6-c530f687d26e") },
                    { new Guid("179ff1c7-9195-4366-a3ca-26fd32b512b1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4dc42e13-1e48-4ea3-b86a-f3df4118c9d5"), new Guid("922f53da-9877-4d56-a64d-6d83331bdbb6") },
                    { new Guid("199f166f-af20-495d-8d74-6ca3314749b9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("50f09e36-8af3-4946-92a9-222d4e1be79b"), new Guid("2f3d1b8f-7590-4d18-9002-4caa22511a8b") },
                    { new Guid("1cee3536-5a8e-4ded-a8bf-6be3476b7520"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("51defd5c-9282-48ca-bb6d-18dc45a54381"), new Guid("5881d0e1-89ce-4573-8217-2e4c8ee1688e") }
                });

            migrationBuilder.InsertData(
                table: "UserPostBranches",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PostBranchId", "UserId" },
                values: new object[,]
                {
                    { new Guid("1e301783-ccce-4dd9-b6d7-b189c649cf29"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("53b1372a-8c17-4b5c-a687-e4b3ff2467ff"), new Guid("611b8b1f-53d5-4660-9ad4-e0b57e915bf8") },
                    { new Guid("1ec4b120-1a6a-4e5c-9b47-894cf9324424"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("daad58da-1609-4db7-a1f0-0eb8fe22113f"), new Guid("a5e0abc8-bc40-47e6-bf22-077c758ba0a7") },
                    { new Guid("2b5939a7-0665-4dec-9e7c-2703fce52831"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("497471e5-5b00-4ae8-a678-039014c09380"), new Guid("0763ce92-5a2c-4138-ad42-41c5b45988dd") },
                    { new Guid("2e527f01-ad6f-4574-88ea-fce11837b899"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3df3c904-719f-4990-9f1d-25f255f93b63"), new Guid("0763ce92-5a2c-4138-ad42-41c5b45988dd") },
                    { new Guid("2e5f3b3a-5302-485d-9da7-b948847d570e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a26ba798-17a8-4735-8adf-f4e6979f0010"), new Guid("77a05cfa-406d-4342-a924-73d56bf2829a") },
                    { new Guid("30764ac4-9dc4-4872-b70f-4bfa9908973c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("50d93c29-6446-4370-ae77-2d0154406dbd"), new Guid("b7f7d261-2525-4477-8b55-bba019231e9f") },
                    { new Guid("322a602c-3f4f-42fa-802d-f8d4494192a0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("15b53a9e-23e9-4fed-b40d-5d0b1b171b61"), new Guid("c6c5dcc4-cc8e-4484-935f-918264ee4897") },
                    { new Guid("331576a9-fc4d-4213-9bee-7d42b7757036"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1f7e7541-6b8a-45e0-8597-35b8c7c76625"), new Guid("b40e13af-a00a-45af-a681-b960cb8d6a7b") },
                    { new Guid("36881541-532c-4f77-8c55-588afa7b6e39"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("05e5656c-2994-48a0-a339-dde1e1a4f1a5"), new Guid("49e9f216-cefc-4a4e-a243-81e78152afb7") },
                    { new Guid("36c0a16d-fa7a-46bc-a243-a29b4a5a3a24"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("53b1372a-8c17-4b5c-a687-e4b3ff2467ff"), new Guid("25a38376-e74c-46cc-8d4f-292cebbcdffb") },
                    { new Guid("38a9c3c8-5d3c-4a38-929c-6afaa832a251"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("50a9814c-a8b8-4e15-998f-71d3025b6ea8"), new Guid("a339ea33-3188-40c2-9d84-9ea46aa67e82") },
                    { new Guid("399e16c1-1208-411b-a9a8-65ffcef2eefa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("63450cab-27ee-4cf8-a92a-999c01d91312"), new Guid("f498a63d-900c-464a-8fab-e4232968dc8b") },
                    { new Guid("3a6435bc-1651-41b6-8f2e-e64089cf24b1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("26d0ff21-2077-487f-939f-475791621fd6"), new Guid("a4972888-e048-48a4-a351-23bd705a917e") },
                    { new Guid("3c83b952-d7d9-4bf3-996a-b812f7203465"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f198df95-1129-4318-bdff-c65c76a27d5e"), new Guid("732ba531-5faf-4b4a-bcac-24d9ca3fcbc2") },
                    { new Guid("3e0bdf6f-d734-4ad7-92e7-c3d34889dd36"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0b5cc62a-0b28-46d8-a616-9b832171d377"), new Guid("3359f4d4-fbc1-4174-b3e0-8cc3754ac07b") },
                    { new Guid("48affc76-7137-4d71-8f77-d1247ec014bb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("50f09e36-8af3-4946-92a9-222d4e1be79b"), new Guid("fbcf0085-dd67-4f41-b656-a0c0900baca5") },
                    { new Guid("4985724b-4045-4718-ac61-47f4f85352f6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0278919c-a954-4960-98c1-db890e6bac28"), new Guid("ce3412db-b24b-4f68-8e32-724c140b7d0a") },
                    { new Guid("4ddeb087-cb72-4bf4-a9b9-84904f1450cf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("7413402f-708e-41e6-ac7f-e45374fba55f"), new Guid("fa671618-4f8c-472d-aad1-18adb7778e70") },
                    { new Guid("4febe30d-e6b6-40af-90ed-cdb1a696afb8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("761f33ce-627f-4304-ba34-25f10160c9cf"), new Guid("c075bfdf-a5cc-4efb-a6d1-f31b0c4bf344") },
                    { new Guid("5d3be60d-223d-499d-abfa-f8899e94ab9d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("50d93c29-6446-4370-ae77-2d0154406dbd"), new Guid("f498a63d-900c-464a-8fab-e4232968dc8b") },
                    { new Guid("689b5292-1b67-4dbb-aeba-432d9716dc25"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("141f494f-6647-42ae-ae0b-75cd57f9d57b"), new Guid("af831e9b-a557-4f53-81e7-2278eb8802a1") },
                    { new Guid("690e5c47-6962-40a4-aeee-be10b268449e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("50d93c29-6446-4370-ae77-2d0154406dbd"), new Guid("b40e13af-a00a-45af-a681-b960cb8d6a7b") },
                    { new Guid("6a42ad92-bd49-42fb-ad1b-ca98f7d0abfa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8827f823-bafe-42af-843a-262a12a3ce2e"), new Guid("d173c22f-aa53-4e3b-b137-bcd6d2faf814") },
                    { new Guid("6ade703f-c20e-4365-8f02-97b6f2904ad3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("54fe296c-d00e-4c7b-ac71-14688a8e4a66"), new Guid("9f2db745-dcf4-4a49-a27a-ae15a2f3087e") },
                    { new Guid("7661ac25-8759-4cf8-b563-5ec83b6e8dd1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("26d0ff21-2077-487f-939f-475791621fd6"), new Guid("a339ea33-3188-40c2-9d84-9ea46aa67e82") },
                    { new Guid("7c8e575e-e7f1-42e8-8045-901d4249e28e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6e472106-e8c8-4651-b4e5-64efa108d44f"), new Guid("5c53533c-cf33-43f0-bdab-260275d90d88") },
                    { new Guid("808e1211-b39e-493f-bc74-f21a40daf1e2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4dc42e13-1e48-4ea3-b86a-f3df4118c9d5"), new Guid("c78c659a-335a-4de3-940d-5ed29586f5d9") },
                    { new Guid("82efdb89-a860-4f1e-93e5-cff5b63338ae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a78b1951-1516-4424-b8b8-cb0a7a120130"), new Guid("07169b5c-40fd-40ba-b01e-8b56de466065") },
                    { new Guid("86fe4277-b34d-498c-ae0e-42477879c193"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("63a57fc9-56e5-4342-ba17-f80d1d48aae8"), new Guid("c1169f01-6528-4f74-aa56-802f48a7ece8") },
                    { new Guid("8dbe5fa0-6a6f-46e0-88d2-166dd09f7de1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d903c63d-f3ec-46a8-a703-1a5007838b93"), new Guid("ce3412db-b24b-4f68-8e32-724c140b7d0a") },
                    { new Guid("9cab50a5-f07e-464a-8497-530ae9c1d3a5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("10b84ef0-078a-472a-99d4-a158ba7c9d6d"), new Guid("af67d494-10d3-4417-9f74-90816ee69f93") },
                    { new Guid("9f023841-630e-446f-89b0-1cf6a368be8b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f198df95-1129-4318-bdff-c65c76a27d5e"), new Guid("ab522845-c1bd-4f82-bee3-06f49429e4bf") },
                    { new Guid("a23d5f4c-09a4-4ab0-9d6a-9f3b818ac892"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("d923c410-f1da-4085-b9dc-bc36bcce90f2"), new Guid("0fedadae-5c91-4999-9924-42f5fcd0de5b") },
                    { new Guid("a6392aa7-5be3-4428-a8ab-550661946852"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("deedecaf-a242-466d-a663-f0ffc79f4c6f"), new Guid("99d66586-6373-4afb-b333-7c5cb91075c4") },
                    { new Guid("a6bb3c97-681c-4204-9a9f-07a91c0fae5d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5f7ede62-c8f0-48b2-ad86-a8bd560d192c"), new Guid("00e8ecc6-7b14-4020-bcbd-1a849d69a8c6") },
                    { new Guid("a6c84410-1fc2-4972-88aa-6b83a1195578"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("957d6734-1fa3-43cf-b86b-02340d8f8852"), new Guid("f3ea0004-e1e2-4557-a9d5-14a5369a2eb3") },
                    { new Guid("b4cd1935-09e5-419a-8dee-234cdf118b37"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bebe4138-e505-4340-8375-62a672f37d48"), new Guid("a3bc456f-939a-42c3-99ed-719e0db5bf18") },
                    { new Guid("ba2ffa31-c26a-43a1-92dd-b6f0de350ee2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("54fe296c-d00e-4c7b-ac71-14688a8e4a66"), new Guid("b2085c8a-b530-4404-a522-eaa5962529ec") },
                    { new Guid("bb8dc7f5-7095-4e17-bf88-0bfdd37f37b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("50a9814c-a8b8-4e15-998f-71d3025b6ea8"), new Guid("ab38dbfc-78a4-4d84-9e77-53448911bc9f") },
                    { new Guid("bd52ee6f-5bc7-4af7-9d54-c769edc35bfc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9192a899-97a0-4b3b-92cd-7e026be3934f"), new Guid("5c53533c-cf33-43f0-bdab-260275d90d88") },
                    { new Guid("c64470b3-ebaf-4b93-ab7c-6e284b82512c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("deedecaf-a242-466d-a663-f0ffc79f4c6f"), new Guid("52fe76ad-4c09-4b99-9385-e407990c0307") },
                    { new Guid("c6bd8796-c0f9-4ba0-8a57-a60442caa562"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5a69917a-1b3c-4f0f-b8e3-50bca5ef8ea2"), new Guid("8343d773-e986-49d8-99e9-bd908398b011") }
                });

            migrationBuilder.InsertData(
                table: "UserPostBranches",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PostBranchId", "UserId" },
                values: new object[,]
                {
                    { new Guid("c88f2942-adac-48c8-bf3e-10cb0998ad23"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3381afde-e949-492b-a85b-65023911c8c1"), new Guid("f2fc34d0-f967-4d49-ac54-2191c244d200") },
                    { new Guid("cb1a33d7-54dc-4b68-99f7-c48aecc685ed"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1706e418-892a-4912-9bd8-fa71fae418c1"), new Guid("34c24f57-b16e-4b0f-abe2-5cb9c260e918") },
                    { new Guid("d3838ed2-765a-4392-979e-effecb090e06"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c1671f3a-d00d-4b8e-8103-88ffb96e571b"), new Guid("4e8f092d-b1e1-47d3-9de6-5d9db26187a5") },
                    { new Guid("d474309d-3efc-4139-a73e-35ac1917acbf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9da1a904-7c5e-45d0-a9e8-1457c5d02848"), new Guid("d50ea512-4841-4fdb-b6f1-1805a1f266cc") },
                    { new Guid("d4bdb017-c1f1-47a5-9062-c954b4a01658"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c80f697d-73be-4e19-a3eb-1a4b46fb2902"), new Guid("c1169f01-6528-4f74-aa56-802f48a7ece8") },
                    { new Guid("dabe22b1-476f-4150-9428-2eb30d84511f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bedd4383-afaf-44b1-a8bf-16c30ea1e36b"), new Guid("52fe76ad-4c09-4b99-9385-e407990c0307") },
                    { new Guid("db475c92-bc2b-4a7f-9b31-35385c6cd3dc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("3381afde-e949-492b-a85b-65023911c8c1"), new Guid("5146be01-925a-447f-b871-b7de98b487df") },
                    { new Guid("e1c35f29-00bc-4808-b8b8-958c02b25ca6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("51defd5c-9282-48ca-bb6d-18dc45a54381"), new Guid("56780bb1-6c9e-4f24-a024-e244137c0516") },
                    { new Guid("e4495154-245f-4a29-bb82-5aa6a1dfbf36"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("53b1372a-8c17-4b5c-a687-e4b3ff2467ff"), new Guid("b7065d5a-6bbd-485c-bd51-6a4a0fc35e18") },
                    { new Guid("eaab807f-ba37-4ccb-bf68-69ea5fa5ea5a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6611bb76-ccb4-4205-98ba-efeb039aeb78"), new Guid("77f28b3f-3ca9-4819-96c6-bd1e811a39f5") }
                });

            migrationBuilder.InsertData(
                table: "UserPromoCodes",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PromoCodeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("060ae647-ba0e-49f1-a6ac-4429825b2840"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e83e56d3-8f4a-41e8-a43f-952f9468d13c"), new Guid("ce3412db-b24b-4f68-8e32-724c140b7d0a") },
                    { new Guid("08c6d52c-a5eb-41d0-b90e-df7644241759"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4ef0c6c8-49fc-4d91-b8c9-7699db4c9b88"), new Guid("611b8b1f-53d5-4660-9ad4-e0b57e915bf8") },
                    { new Guid("0f4b1ca5-ac14-4878-9938-fe463ba011c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("79a78a5e-72cb-4ff9-af7c-f7c9d8d324ff"), new Guid("b2085c8a-b530-4404-a522-eaa5962529ec") },
                    { new Guid("1d14e7d3-8be3-422f-a76e-b9062087442c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("79a78a5e-72cb-4ff9-af7c-f7c9d8d324ff"), new Guid("a339ea33-3188-40c2-9d84-9ea46aa67e82") },
                    { new Guid("1fd31c38-de11-48dc-9ca6-54e35ef8ea49"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("52441390-d4eb-421a-be09-87f994e9949e"), new Guid("0edec355-b022-4255-80d6-c530f687d26e") },
                    { new Guid("23c01cd8-34e4-496e-a434-b06afe4efd40"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("940c9929-0312-443c-bb24-8257516e1ec7"), new Guid("b40e13af-a00a-45af-a681-b960cb8d6a7b") },
                    { new Guid("2707582a-c736-4ea2-88ab-ef6a416a175b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9ea4a0e1-001e-47d4-a289-5f9604021aa7"), new Guid("5881d0e1-89ce-4573-8217-2e4c8ee1688e") },
                    { new Guid("2bff6122-461c-4764-a511-aaf6a3a08626"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1a78b48a-46d7-4233-be7b-76c1ec708fd1"), new Guid("ab522845-c1bd-4f82-bee3-06f49429e4bf") },
                    { new Guid("2e24ac84-ff84-4b81-9fea-239887b8f53b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("10977405-82e6-4c24-96ff-1c6733cdceea"), new Guid("f3ea0004-e1e2-4557-a9d5-14a5369a2eb3") },
                    { new Guid("2e733fbb-90cd-47da-a87c-9fa8e28ae4b1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("53ff920b-d82e-4f8f-a23d-b6979d9cc7d6"), new Guid("0fedadae-5c91-4999-9924-42f5fcd0de5b") },
                    { new Guid("2ffc6b13-0741-4c6a-b117-d5f806ede6b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2f2e6a81-fad3-40b1-9635-bbc7141b189d"), new Guid("4e8f092d-b1e1-47d3-9de6-5d9db26187a5") },
                    { new Guid("300069f2-c379-47cd-b951-abbe890e7e53"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("818b79e8-1331-4a69-a381-a80a9413a3f1"), new Guid("5c53533c-cf33-43f0-bdab-260275d90d88") },
                    { new Guid("368a3c26-eeec-4bba-8df5-b4f823ff4de4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("76c41c4f-2b1d-4512-8687-8edc25da740d"), new Guid("c075bfdf-a5cc-4efb-a6d1-f31b0c4bf344") },
                    { new Guid("3bf8a7ad-8bf1-46bc-9998-4606f48c50b8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("584ff235-fc3d-4de7-8ca3-65426f92687a"), new Guid("56460594-4f75-42d8-9106-e7e3ec02c12c") },
                    { new Guid("3d6405ff-9032-4a55-9e88-cce61c3d809f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5f57392d-a0a0-49de-85e0-7b78e7e23441"), new Guid("07169b5c-40fd-40ba-b01e-8b56de466065") },
                    { new Guid("432c8184-b484-47a7-a9f5-33a6742d8134"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2e2ed187-a24b-4813-9538-2f090b0f6341"), new Guid("9f2db745-dcf4-4a49-a27a-ae15a2f3087e") },
                    { new Guid("4c503809-5205-4c49-83b8-dc52daf8fb3c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e46a1a44-ccf4-4e22-86d8-eca06908a288"), new Guid("00e8ecc6-7b14-4020-bcbd-1a849d69a8c6") },
                    { new Guid("4fb966da-700e-4b36-9caf-e0d7530bcafc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e404e01d-9ef0-4261-b301-5d2cb2b1e428"), new Guid("c1169f01-6528-4f74-aa56-802f48a7ece8") },
                    { new Guid("54ef2701-1182-41eb-ae44-8b290e3f145d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1a78b48a-46d7-4233-be7b-76c1ec708fd1"), new Guid("c78c659a-335a-4de3-940d-5ed29586f5d9") },
                    { new Guid("57c8bac7-00e0-4e15-99b5-c20fdb0533a8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a4c5ead5-6c1b-4ffa-8b3e-6fa215c51720"), new Guid("b40e13af-a00a-45af-a681-b960cb8d6a7b") },
                    { new Guid("59fbcee4-48f1-4b0d-8676-deb6c1652197"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("9f3bb7fe-a0c0-47d2-9284-d86168fcf68c"), new Guid("0763ce92-5a2c-4138-ad42-41c5b45988dd") },
                    { new Guid("5e528a14-2ef6-457e-b82c-aef7b9bd2405"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("dce2b27b-a779-43bf-9e28-7db8307f3070"), new Guid("3359f4d4-fbc1-4174-b3e0-8cc3754ac07b") },
                    { new Guid("610917a8-de63-41a9-a85b-9abeae13b5a1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0c5623e5-70d5-4905-888c-c5ab05263d88"), new Guid("1e75d073-445f-4291-b366-fe0683c205a7") },
                    { new Guid("658260ef-180a-41e1-98e7-3854de23e4f2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8eb4bb70-2c12-46c5-8dd5-669921a139f1"), new Guid("2f3d1b8f-7590-4d18-9002-4caa22511a8b") },
                    { new Guid("6d798d36-4a37-4d4d-9dfd-d1be3e96af4b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("80bbbd7c-1a98-4602-952c-869a9b4db50e"), new Guid("d50ea512-4841-4fdb-b6f1-1805a1f266cc") },
                    { new Guid("71f78d30-2da3-4076-b1ac-eacc88f13fa6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b08737c0-3393-480b-a5de-a7259d544413"), new Guid("ab38dbfc-78a4-4d84-9e77-53448911bc9f") },
                    { new Guid("7295a46d-e314-4ead-8608-3a213001d8af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2403f546-8ffa-40b3-abbb-0a1cc5cf5972"), new Guid("b7f7d261-2525-4477-8b55-bba019231e9f") },
                    { new Guid("741e7251-1d3b-43f0-979b-d7b150c9eb08"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2737d8a6-9c5e-4a50-8611-52706ff9c03e"), new Guid("f498a63d-900c-464a-8fab-e4232968dc8b") },
                    { new Guid("772aeb6b-7384-4a75-861a-f3a9d81017df"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4fa55b29-7d8b-47ed-86d0-4d2bf9462957"), new Guid("fa671618-4f8c-472d-aad1-18adb7778e70") },
                    { new Guid("7b584cbe-8d23-41ea-a5ef-17a9bfec7171"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("29d0c66a-9c32-4859-beb5-f31ed9661515"), new Guid("a5e0abc8-bc40-47e6-bf22-077c758ba0a7") },
                    { new Guid("7ff60fec-6c80-4379-8b41-c2cbeda6bfd7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("daed7757-a587-45ee-9203-edf9f0f9660e"), new Guid("fbcf0085-dd67-4f41-b656-a0c0900baca5") },
                    { new Guid("807aedf6-00f2-47ff-b5c2-4ea719c51e7f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("df3ba06c-ee1f-420d-8bdd-0f9fc172d32a"), new Guid("0763ce92-5a2c-4138-ad42-41c5b45988dd") }
                });

            migrationBuilder.InsertData(
                table: "UserPromoCodes",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "PromoCodeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("83a4dce9-6118-4d6f-9044-73e64b5d2309"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a9ab3fb9-80fc-4bac-9241-ecdf42f5fae4"), new Guid("77a05cfa-406d-4342-a924-73d56bf2829a") },
                    { new Guid("8467a395-98e6-42f0-ac1e-28a763c2053c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("259dc67b-308a-4f93-bb2c-24b10da22922"), new Guid("a3bc456f-939a-42c3-99ed-719e0db5bf18") },
                    { new Guid("8aa2fc38-b823-46c1-9cd2-c1624495e4f2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("fa9e8b12-7ae7-4520-a77f-d89b877fef03"), new Guid("52fe76ad-4c09-4b99-9385-e407990c0307") },
                    { new Guid("8c8b3361-ae8d-4012-a246-6216f0a445a5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b8f7201c-1872-4802-b4bf-10b844c60ac1"), new Guid("c1169f01-6528-4f74-aa56-802f48a7ece8") },
                    { new Guid("9250e22f-d919-4350-b183-76060e3c0b25"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("8eb4bb70-2c12-46c5-8dd5-669921a139f1"), new Guid("af67d494-10d3-4417-9f74-90816ee69f93") },
                    { new Guid("96a588ef-fe41-4ced-9636-c14342abbabc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5f57392d-a0a0-49de-85e0-7b78e7e23441"), new Guid("25a38376-e74c-46cc-8d4f-292cebbcdffb") },
                    { new Guid("a4020dac-bd32-4332-99a9-53b3fe5dbea8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0064135a-586d-4d56-9d0f-27b51c5be85b"), new Guid("922f53da-9877-4d56-a64d-6d83331bdbb6") },
                    { new Guid("b6023daa-abe1-4a0b-8677-8af9dad425e1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("442b65cc-6b45-41c7-b584-84cd0c5b4658"), new Guid("ce3412db-b24b-4f68-8e32-724c140b7d0a") },
                    { new Guid("b66aa6f2-034c-4148-afb9-f74f92143f51"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("29d0c66a-9c32-4859-beb5-f31ed9661515"), new Guid("732ba531-5faf-4b4a-bcac-24d9ca3fcbc2") },
                    { new Guid("bbb991a7-5f21-4e98-bc55-df0b546cb3fc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6ffaf7df-b478-4312-a6d4-60dd20f60c57"), new Guid("56780bb1-6c9e-4f24-a024-e244137c0516") },
                    { new Guid("bc52254d-d7ce-4e52-bfbc-2630e04e88ad"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e46a1a44-ccf4-4e22-86d8-eca06908a288"), new Guid("a339ea33-3188-40c2-9d84-9ea46aa67e82") },
                    { new Guid("bd5080fe-d869-4653-89f5-c47d1237713b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("2737d8a6-9c5e-4a50-8611-52706ff9c03e"), new Guid("52fe76ad-4c09-4b99-9385-e407990c0307") },
                    { new Guid("c68b7755-6e62-4c66-b38b-415c60a8b1f5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b3e35057-a160-436c-87a5-b45f3cdb1cf1"), new Guid("f2fc34d0-f967-4d49-ac54-2191c244d200") },
                    { new Guid("c6a1b88e-7c16-4371-91ed-dfc87a54d769"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("30ee284f-a7bb-4395-b19d-22e5df076772"), new Guid("a4972888-e048-48a4-a351-23bd705a917e") },
                    { new Guid("c7349827-b074-4ed2-a92e-e545392a334e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a141ffdb-3847-4ff0-8876-144b327192a4"), new Guid("af831e9b-a557-4f53-81e7-2278eb8802a1") },
                    { new Guid("cc18336a-9aea-4181-824a-a8260df85bae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("94ef44c9-ed0e-4add-9406-477ab9585e9c"), new Guid("34c24f57-b16e-4b0f-abe2-5cb9c260e918") },
                    { new Guid("cdc2081d-66ba-482e-a488-fc8bfc9a2f6c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("f60674b6-b682-4779-ad71-f9260aba732c"), new Guid("07169b5c-40fd-40ba-b01e-8b56de466065") },
                    { new Guid("d6968c96-8d5a-42cc-8e18-42ba8f664aaa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5f57392d-a0a0-49de-85e0-7b78e7e23441"), new Guid("8343d773-e986-49d8-99e9-bd908398b011") },
                    { new Guid("db5d2e50-7cde-4914-97fd-d66fa7dea032"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("778428f3-c5d3-42ee-bc3b-c50c1dd63a92"), new Guid("b7065d5a-6bbd-485c-bd51-6a4a0fc35e18") },
                    { new Guid("e2ad12f8-b25a-4016-b33b-7054f080574a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4fa55b29-7d8b-47ed-86d0-4d2bf9462957"), new Guid("49e9f216-cefc-4a4e-a243-81e78152afb7") },
                    { new Guid("e8042cd6-c4d1-4311-b367-8e2546b1004b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a837d04c-0433-40a7-9767-d32482e35f48"), new Guid("5146be01-925a-447f-b871-b7de98b487df") },
                    { new Guid("ea877dad-0710-4b50-b5c2-fcda8c9846a4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("76c41c4f-2b1d-4512-8687-8edc25da740d"), new Guid("d173c22f-aa53-4e3b-b137-bcd6d2faf814") },
                    { new Guid("edc351a5-c538-43ac-ab37-5a928b02e9da"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("ea1e79eb-51af-46d1-bf86-b8b9dea489db"), new Guid("77f28b3f-3ca9-4819-96c6-bd1e811a39f5") },
                    { new Guid("ee433761-569b-4c42-88d4-54330e0c31d4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("da55b5f9-bd78-4ac8-be8b-cc73240f1d99"), new Guid("e6fc9f3f-e447-488c-a497-0bec2a6f9fea") },
                    { new Guid("f685b5ff-bc87-4d0f-b87c-4efafc8393ac"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e46a1a44-ccf4-4e22-86d8-eca06908a288"), new Guid("99d66586-6373-4afb-b333-7c5cb91075c4") },
                    { new Guid("fb015361-588d-4b1d-88c3-7a48330068ac"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4fa55b29-7d8b-47ed-86d0-4d2bf9462957"), new Guid("5c53533c-cf33-43f0-bdab-260275d90d88") },
                    { new Guid("fec1bf35-ca81-4f6e-a2a7-4e636875e996"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("b8f7201c-1872-4802-b4bf-10b844c60ac1"), new Guid("f498a63d-900c-464a-8fab-e4232968dc8b") },
                    { new Guid("ffffa8da-df83-46d1-9e04-df0f67ec7963"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("84cefb49-1678-49e4-bce1-c4c19517a705"), new Guid("c6c5dcc4-cc8e-4484-935f-918264ee4897") }
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
