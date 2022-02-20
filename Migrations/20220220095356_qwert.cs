using Microsoft.EntityFrameworkCore.Migrations;

namespace Crud1.Migrations
{
    public partial class qwert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Addresses_Addressid",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_Addressid",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Addressid",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "Addressidid",
                table: "Customers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Addressidid",
                table: "Customers",
                column: "Addressidid");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Addresses_Addressidid",
                table: "Customers",
                column: "Addressidid",
                principalTable: "Addresses",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Addresses_Addressidid",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_Addressidid",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Addressidid",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "Addressid",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Addressid",
                table: "Customers",
                column: "Addressid");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Addresses_Addressid",
                table: "Customers",
                column: "Addressid",
                principalTable: "Addresses",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
