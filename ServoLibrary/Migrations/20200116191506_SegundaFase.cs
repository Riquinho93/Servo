using Microsoft.EntityFrameworkCore.Migrations;

namespace ServoLibrary.Migrations
{
    public partial class SegundaFase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Users_userid",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "userid",
                table: "Products",
                newName: "Userid");

            migrationBuilder.RenameIndex(
                name: "IX_Products_userid",
                table: "Products",
                newName: "IX_Products_Userid");

            migrationBuilder.AddColumn<string>(
                name: "Complemento",
                table: "Addresses",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Users_Userid",
                table: "Products",
                column: "Userid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Users_Userid",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Complemento",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "Userid",
                table: "Products",
                newName: "userid");

            migrationBuilder.RenameIndex(
                name: "IX_Products_Userid",
                table: "Products",
                newName: "IX_Products_userid");

            migrationBuilder.AddColumn<int>(
                name: "Numero",
                table: "Addresses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Users_userid",
                table: "Products",
                column: "userid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
