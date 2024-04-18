using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalaxyExpress.API.Migrations
{
    public partial class AddSomeEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Sex",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(15)",
                oldNullable: true,
                oldDefaultValue: "Not selected");

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
                name: "PaymentCards",
                columns: table => new
                {
                    CardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CardNumber = table.Column<decimal>(type: "decimal(16,0)", nullable: false),
                    Validity = table.Column<string>(type: "NVARCHAR(5)", nullable: false),
                    CVV = table.Column<decimal>(type: "DECIMAL(3,0)", nullable: false),
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
                    Number = table.Column<string>(type: "NVARCHAR(15)", nullable: false),
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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Login",
                table: "AspNetUsers",
                column: "Login",
                unique: true);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "PaymentCards");

            migrationBuilder.DropTable(
                name: "PhoneNumbers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Login",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Sex",
                table: "AspNetUsers",
                type: "NVARCHAR(15)",
                nullable: true,
                defaultValue: "Not selected",
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
