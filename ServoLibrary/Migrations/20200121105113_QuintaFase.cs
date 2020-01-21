using Microsoft.EntityFrameworkCore.Migrations;

namespace ServoLibrary.Migrations
{
    public partial class QuintaFase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Product_ProductId",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_ProductId",
                table: "Address");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Address",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Address_ProductId",
                table: "Address",
                column: "ProductId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Product_ProductId",
                table: "Address",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Product_ProductId",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_ProductId",
                table: "Address");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Address",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Address_ProductId",
                table: "Address",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Product_ProductId",
                table: "Address",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
