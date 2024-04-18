using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalaxyExpress.API.Migrations
{
    public partial class ChangeTypePhoneNumberColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "PhoneNumbers",
                type: "NVARCHAR(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(15)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "PhoneNumbers",
                type: "NVARCHAR(15)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(20)");
        }
    }
}
