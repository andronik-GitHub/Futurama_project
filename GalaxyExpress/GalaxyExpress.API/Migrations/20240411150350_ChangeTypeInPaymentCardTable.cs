using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalaxyExpress.API.Migrations
{
    public partial class ChangeTypeInPaymentCardTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CardNumber",
                table: "PaymentCards",
                type: "NVARCHAR(16)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(16,0)");

            migrationBuilder.AlterColumn<string>(
                name: "CVV",
                table: "PaymentCards",
                type: "NVARCHAR(3)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(3,0)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "CardNumber",
                table: "PaymentCards",
                type: "decimal(16,0)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(16)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CVV",
                table: "PaymentCards",
                type: "DECIMAL(3,0)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(3)");
        }
    }
}
