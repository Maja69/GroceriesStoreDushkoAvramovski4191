using Microsoft.EntityFrameworkCore.Migrations;

namespace GroceriesStore.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, null, "Apples" },
                    { 2, null, "Bananas" },
                    { 3, null, "Oranges" },
                    { 4, null, "Grapes" },
                    { 5, null, "Tomato" },
                    { 6, null, "Strawberry" }
                });

            migrationBuilder.InsertData(
                table: "Groceries",
                columns: new[] { "GroceriesId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsOnSale", "IsOnStock", "Name", "Price" },
                values: new object[,]
                {
                    { 3, 1, "Nice Red Apple", null, "~\\Images\\redapple.jpg", true, true, "Red Apple", 30m },
                    { 4, 1, "Nice Yellow Apple", null, "~\\Images\\yellowapple.jpg", true, true, "Yellow Apple", 35m },
                    { 5, 1, "Nice Green Apple", null, "~\\Images\\greenapple.jpg", false, true, "Green Apple", 50m },
                    { 1, 2, "Nice Yellow Banana", null, "~\\Images\\banana.jpg", false, true, "Yellow Banana", 50m },
                    { 2, 2, "Nice Green Banana", null, "~\\Images\\greenbanana.jpg", false, true, "Green Banana", 40m },
                    { 6, 3, "Nice Orange", null, "~\\Images\\orange.jpg", false, true, "Orange", 54m },
                    { 7, 3, "Nice Red Orange", null, "~\\Images\\redorange.jpg", false, true, "Red Orange", 75m },
                    { 8, 3, "Nice Mandarina", null, "~\\Images\\mandarina.jpg", false, true, "Mandarina", 100m },
                    { 9, 4, "Nice Grape", null, "~\\Images\\grape.jpg", false, true, "Grape", 100m },
                    { 10, 4, "Nice Red Grape", null, "~\\Images\\redgrape.jpg", true, true, "Red Grape", 100m },
                    { 11, 4, "Nice Yellow Grape", null, "~\\Images\\yellowgrape.jpg", true, true, "Yellow Grape", 110m },
                    { 12, 5, "Nice Tomato", null, "~\\Images\\tomato.jpg", false, true, "Tomato", 150m },
                    { 13, 6, "Nice Red Strawberry", null, "~\\Images\\strawberry.jpg", false, true, "Strawberry", 250m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Groceries",
                keyColumn: "GroceriesId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);
        }
    }
}
