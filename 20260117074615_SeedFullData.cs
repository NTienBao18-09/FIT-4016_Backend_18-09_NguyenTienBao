using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OrderManagementApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedFullData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "OrderDate", "OrderNumber" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ORD-20260101-0001" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "OrderDate", "OrderNumber" },
                values: new object[] { new DateTime(2026, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "ORD-20260102-0002" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedAt", "CustomerEmail", "CustomerName", "DeliveryDate", "OrderDate", "OrderNumber", "ProductId", "Quantity", "UpdatedAt" },
                values: new object[,]
                {
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "peter3@gmail.com", "Peter Brown", null, new DateTime(2026, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "ORD-20260103-0003", 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lucy4@gmail.com", "Lucy Green", null, new DateTime(2026, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "ORD-20260104-0004", 4, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tom5@gmail.com", "Tom White", null, new DateTime(2026, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ORD-20260105-0005", 5, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "emma6@gmail.com", "Emma Black", null, new DateTime(2026, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "ORD-20260106-0006", 6, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "david7@gmail.com", "David Wilson", null, new DateTime(2026, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "ORD-20260107-0007", 7, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sophia8@gmail.com", "Sophia Lee", null, new DateTime(2026, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "ORD-20260108-0008", 8, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "james9@gmail.com", "James King", null, new DateTime(2026, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ORD-20260109-0009", 9, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "linda10@gmail.com", "Linda Scott", null, new DateTime(2026, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ORD-20260110-0010", 10, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "chris11@gmail.com", "Chris Evans", null, new DateTime(2026, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "ORD-20260111-0011", 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "natalie12@gmail.com", "Natalie Portman", null, new DateTime(2026, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "ORD-20260112-0012", 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "robert13@gmail.com", "Robert Downey", null, new DateTime(2026, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "ORD-20260113-0013", 3, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "scarlett14@gmail.com", "Scarlett Johansson", null, new DateTime(2026, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "ORD-20260114-0014", 4, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mark15@gmail.com", "Mark Ruffalo", null, new DateTime(2026, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ORD-20260115-0015", 5, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jeremy16@gmail.com", "Jeremy Renner", null, new DateTime(2026, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "ORD-20260116-0016", 6, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "paul17@gmail.com", "Paul Rudd", null, new DateTime(2026, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "ORD-20260117-0017", 7, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "brie18@gmail.com", "Brie Larson", null, new DateTime(2026, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "ORD-20260118-0018", 8, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ben19@gmail.com", "Benedict Cumberbatch", null, new DateTime(2026, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "ORD-20260119-0019", 9, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tom20@gmail.com", "Tom Holland", null, new DateTime(2026, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ORD-20260120-0020", 10, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "OrderDate", "OrderNumber" },
                values: new object[] { new DateTime(2026, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ORD-20260117-0001" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "OrderDate", "OrderNumber" },
                values: new object[] { new DateTime(2026, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "ORD-20260117-0002" });
        }
    }
}
