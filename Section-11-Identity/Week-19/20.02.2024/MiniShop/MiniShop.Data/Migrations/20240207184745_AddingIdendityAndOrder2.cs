using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingIdendityAndOrder2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 45, 328, DateTimeKind.Local).AddTicks(5549), new DateTime(2024, 2, 7, 21, 47, 45, 328, DateTimeKind.Local).AddTicks(5561) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 45, 328, DateTimeKind.Local).AddTicks(5565), new DateTime(2024, 2, 7, 21, 47, 45, 328, DateTimeKind.Local).AddTicks(5566) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 45, 328, DateTimeKind.Local).AddTicks(5567), new DateTime(2024, 2, 7, 21, 47, 45, 328, DateTimeKind.Local).AddTicks(5567) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 45, 328, DateTimeKind.Local).AddTicks(5568), new DateTime(2024, 2, 7, 21, 47, 45, 328, DateTimeKind.Local).AddTicks(5568) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 45, 328, DateTimeKind.Local).AddTicks(5569), new DateTime(2024, 2, 7, 21, 47, 45, 328, DateTimeKind.Local).AddTicks(5569) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 45, 329, DateTimeKind.Local).AddTicks(1516), new DateTime(2024, 2, 7, 21, 47, 45, 329, DateTimeKind.Local).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 45, 329, DateTimeKind.Local).AddTicks(1524), new DateTime(2024, 2, 7, 21, 47, 45, 329, DateTimeKind.Local).AddTicks(1524) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 45, 329, DateTimeKind.Local).AddTicks(1526), new DateTime(2024, 2, 7, 21, 47, 45, 329, DateTimeKind.Local).AddTicks(1526) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 45, 329, DateTimeKind.Local).AddTicks(1527), new DateTime(2024, 2, 7, 21, 47, 45, 329, DateTimeKind.Local).AddTicks(1528) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 45, 329, DateTimeKind.Local).AddTicks(1529), new DateTime(2024, 2, 7, 21, 47, 45, 329, DateTimeKind.Local).AddTicks(1529) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 45, 329, DateTimeKind.Local).AddTicks(1530), new DateTime(2024, 2, 7, 21, 47, 45, 329, DateTimeKind.Local).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 45, 329, DateTimeKind.Local).AddTicks(1532), new DateTime(2024, 2, 7, 21, 47, 45, 329, DateTimeKind.Local).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 45, 329, DateTimeKind.Local).AddTicks(1533), new DateTime(2024, 2, 7, 21, 47, 45, 329, DateTimeKind.Local).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 45, 329, DateTimeKind.Local).AddTicks(1534), new DateTime(2024, 2, 7, 21, 47, 45, 329, DateTimeKind.Local).AddTicks(1535) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 45, 329, DateTimeKind.Local).AddTicks(1536), new DateTime(2024, 2, 7, 21, 47, 45, 329, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 45, 329, DateTimeKind.Local).AddTicks(1537), new DateTime(2024, 2, 7, 21, 47, 45, 329, DateTimeKind.Local).AddTicks(1537) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(793), new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(808), new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(809) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(810), new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(811), new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(811) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(812), new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(812) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(6606), new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(6617) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(6624), new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(6624) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(6645), new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(6646) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(6647), new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(6649), new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(6649) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(6651), new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(6651) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(6652), new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(6652) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(6654), new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(6657), new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(6657) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(6658), new DateTime(2024, 2, 7, 21, 44, 2, 427, DateTimeKind.Local).AddTicks(6659) });
        }
    }
}
