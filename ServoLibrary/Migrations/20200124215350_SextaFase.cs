using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServoLibrary.Migrations
{
    public partial class SextaFase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Users_Userid",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_Userid",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "Userid",
                table: "Product",
                newName: "UserId");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Product",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Telephones",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(nullable: true),
                    number = table.Column<string>(nullable: true),
                    productsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telephones", x => x.id);
                    table.ForeignKey(
                        name: "FK_Telephones_Product_productsId",
                        column: x => x.productsId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_UserId",
                table: "Product",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Telephones_productsId",
                table: "Telephones",
                column: "productsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Users_UserId",
                table: "Product",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Users_UserId",
                table: "Product");

            migrationBuilder.DropTable(
                name: "Telephones");

            migrationBuilder.DropIndex(
                name: "IX_Product_UserId",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Product",
                newName: "Userid");

            migrationBuilder.AlterColumn<int>(
                name: "Userid",
                table: "Product",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Product_Userid",
                table: "Product",
                column: "Userid");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Users_Userid",
                table: "Product",
                column: "Userid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
