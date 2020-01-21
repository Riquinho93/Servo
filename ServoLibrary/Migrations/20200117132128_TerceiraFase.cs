using Microsoft.EntityFrameworkCore.Migrations;

namespace ServoLibrary.Migrations
{
    public partial class TerceiraFase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Products_ProductId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Users_Userid",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_ProductId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "CoverImage",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Pais",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "Setor",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Address");

            migrationBuilder.RenameIndex(
                name: "IX_Products_Userid",
                table: "Product",
                newName: "IX_Product_Userid");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "Product",
                newName: "IX_Product_CategoryId");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Address",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Users_Userid",
                table: "Product",
                column: "Userid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Product_ProductId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Users_Userid",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_ProductId",
                table: "Address");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addresses");

            migrationBuilder.RenameIndex(
                name: "IX_Product_Userid",
                table: "Products",
                newName: "IX_Products_Userid");

            migrationBuilder.RenameIndex(
                name: "IX_Product_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.AddColumn<string>(
                name: "CoverImage",
                table: "Products",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Pais",
                table: "Addresses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Setor",
                table: "Addresses",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ProductId",
                table: "Addresses",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Products_ProductId",
                table: "Addresses",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Users_Userid",
                table: "Products",
                column: "Userid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
