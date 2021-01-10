using Microsoft.EntityFrameworkCore.Migrations;

namespace GroceriesStore.Migrations
{
    public partial class AddingShoppingCartItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroceriesId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Groceries_GroceriesId",
                        column: x => x.GroceriesId,
                        principalTable: "Groceries",
                        principalColumn: "GroceriesId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 1,
                column: "ImageUrl",
                value: "\\Images\\banana.jpg");

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 2,
                column: "ImageUrl",
                value: "\\Images\\greenbanana.jpg");

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 3,
                column: "ImageUrl",
                value: "\\Images\\redapple.jpg");

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 4,
                column: "ImageUrl",
                value: "\\Images\\yellowapple.jpg");

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 5,
                column: "ImageUrl",
                value: "\\Images\\greenapple.jpg");

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 6,
                column: "ImageUrl",
                value: "\\Images\\orange.jpg");

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 7,
                column: "ImageUrl",
                value: "\\Images\\redorange.jpg");

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 8,
                column: "ImageUrl",
                value: "\\Images\\mandarina.jpg");

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 9,
                column: "ImageUrl",
                value: "\\Images\\grape.jpg");

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnail\\redgrapesmall.jpg", "\\Images\\redgrape.jpg" });

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 11,
                column: "ImageUrl",
                value: "\\Images\\yellowgrape.jpg");

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 12,
                column: "ImageUrl",
                value: "\\Images\\tomato.jpg");

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 13,
                column: "ImageUrl",
                value: "\\Images\\strawberry.jpg");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_GroceriesId",
                table: "ShoppingCartItems",
                column: "GroceriesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 1,
                column: "ImageUrl",
                value: "~\\Images\\banana.jpg");

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 2,
                column: "ImageUrl",
                value: "~\\Images\\greenbanana.jpg");

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 3,
                column: "ImageUrl",
                value: "~\\Images\\redapple.jpg");

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 4,
                column: "ImageUrl",
                value: "~\\Images\\yellowapple.jpg");

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 5,
                column: "ImageUrl",
                value: "~\\Images\\greenapple.jpg");

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 6,
                column: "ImageUrl",
                value: "~\\Images\\orange.jpg");

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 7,
                column: "ImageUrl",
                value: "~\\Images\\redorange.jpg");

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 8,
                column: "ImageUrl",
                value: "~\\Images\\mandarina.jpg");

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 9,
                column: "ImageUrl",
                value: "~\\Images\\grape.jpg");

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { null, "~\\Images\\redgrape.jpg" });

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 11,
                column: "ImageUrl",
                value: "~\\Images\\yellowgrape.jpg");

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 12,
                column: "ImageUrl",
                value: "~\\Images\\tomato.jpg");

            migrationBuilder.UpdateData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 13,
                column: "ImageUrl",
                value: "~\\Images\\strawberry.jpg");
        }
    }
}
