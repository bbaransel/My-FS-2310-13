using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class SampleDataIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "57fc1d04-8de8-4426-8d72-0ba43e982bfd", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" },
                    { "8ce24a28-a08c-48c2-a1cf-275e378b76d1", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" },
                    { "ba5d2ac3-0be4-43f1-9604-ce328e924be4", null, "Kullanıcı haklarını taşıyan rol", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "42e80013-f9ed-46db-afe0-b5d6f688b6a9", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "023ffe6d-8bc2-46c0-808b-2b0d2c7b0fda", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAEMzJP5nOXzzbMKXkq95HKF8VrRmUiK6lPGyGuJX1uQ5YADdxW5f7YPh7IkgNAZG3UQ==", "5387996654", false, "aa58d50d-67e2-4aaf-860e-85f1782301f2", false, "kemalDurukan" },
                    { "5398541f-cdb6-4155-b544-47e0140abfd3", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "19b2ed71-7721-41eb-ab22-b424f92161f9", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Erkek", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "DENIZFOCA", "AQAAAAIAAYagAAAAEBQYk1Cb1P1jc4N1QJUjiyJvZu8F1GGfi8DHHVafMQqPioITneet2HBhRM1yd+LWAg==", "5558779966", false, "995eb049-3b99-4781-bdc9-e0f918abb142", false, "denizFoca" },
                    { "7e73632a-965b-4c17-ab53-ba3fb44cae02", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "e5e6f2d7-0dd0-4abd-8997-72dcd6285d2d", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmetea@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAEBWI4ijqbeHJR6w6YDqHwYqwOeiWC0fpX6b3zMbliO0zgCOAqxu0oCPIpaHLgfXZkA==", "5387996655", false, "97e29265-f996-4c9d-af7c-f24841452885", false, "selinMete" },
                    { "94d22821-38c5-444d-9475-1100677c28aa", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "ac0fbf67-ea56-42cd-93b3-0b5594160295", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAEAY/P1rC84dBoge/vbr9LAFa6OIMuPNXaJ2PPjcuaXbCzs342keq4DZ/UYxDotqIWQ==", "5387996653", false, "852000ab-b528-4c6b-9a19-195a9fc0f411", false, "aysenumay" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(444), new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(462), new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(462) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(463), new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(464), new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(466), new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(466) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(7683), new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(7696), new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(7696) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(7698), new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(7698) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(7700), new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(7701), new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(7702) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(7703), new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(7703) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(7705), new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(7706), new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(7725), new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(7725) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(7726), new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(7728), new DateTime(2024, 2, 8, 20, 3, 41, 690, DateTimeKind.Local).AddTicks(7728) });

            migrationBuilder.InsertData(
                table: "ShoppingCarts",
                columns: new[] { "Id", "CreatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 8, 20, 3, 41, 689, DateTimeKind.Local).AddTicks(6407), "5398541f-cdb6-4155-b544-47e0140abfd3" },
                    { 2, new DateTime(2024, 2, 8, 20, 3, 41, 689, DateTimeKind.Local).AddTicks(6433), "7e73632a-965b-4c17-ab53-ba3fb44cae02" },
                    { 3, new DateTime(2024, 2, 8, 20, 3, 41, 689, DateTimeKind.Local).AddTicks(6435), "42e80013-f9ed-46db-afe0-b5d6f688b6a9" },
                    { 4, new DateTime(2024, 2, 8, 20, 3, 41, 689, DateTimeKind.Local).AddTicks(6436), "94d22821-38c5-444d-9475-1100677c28aa" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8ce24a28-a08c-48c2-a1cf-275e378b76d1", "42e80013-f9ed-46db-afe0-b5d6f688b6a9" },
                    { "57fc1d04-8de8-4426-8d72-0ba43e982bfd", "5398541f-cdb6-4155-b544-47e0140abfd3" },
                    { "8ce24a28-a08c-48c2-a1cf-275e378b76d1", "7e73632a-965b-4c17-ab53-ba3fb44cae02" },
                    { "ba5d2ac3-0be4-43f1-9604-ce328e924be4", "94d22821-38c5-444d-9475-1100677c28aa" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8ce24a28-a08c-48c2-a1cf-275e378b76d1", "42e80013-f9ed-46db-afe0-b5d6f688b6a9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "57fc1d04-8de8-4426-8d72-0ba43e982bfd", "5398541f-cdb6-4155-b544-47e0140abfd3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8ce24a28-a08c-48c2-a1cf-275e378b76d1", "7e73632a-965b-4c17-ab53-ba3fb44cae02" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba5d2ac3-0be4-43f1-9604-ce328e924be4", "94d22821-38c5-444d-9475-1100677c28aa" });

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57fc1d04-8de8-4426-8d72-0ba43e982bfd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ce24a28-a08c-48c2-a1cf-275e378b76d1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba5d2ac3-0be4-43f1-9604-ce328e924be4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42e80013-f9ed-46db-afe0-b5d6f688b6a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5398541f-cdb6-4155-b544-47e0140abfd3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7e73632a-965b-4c17-ab53-ba3fb44cae02");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94d22821-38c5-444d-9475-1100677c28aa");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 48, 46, 308, DateTimeKind.Local).AddTicks(7461), new DateTime(2024, 2, 7, 21, 48, 46, 308, DateTimeKind.Local).AddTicks(7475) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 48, 46, 308, DateTimeKind.Local).AddTicks(7478), new DateTime(2024, 2, 7, 21, 48, 46, 308, DateTimeKind.Local).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 48, 46, 308, DateTimeKind.Local).AddTicks(7479), new DateTime(2024, 2, 7, 21, 48, 46, 308, DateTimeKind.Local).AddTicks(7479) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 48, 46, 308, DateTimeKind.Local).AddTicks(7480), new DateTime(2024, 2, 7, 21, 48, 46, 308, DateTimeKind.Local).AddTicks(7481) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 48, 46, 308, DateTimeKind.Local).AddTicks(7481), new DateTime(2024, 2, 7, 21, 48, 46, 308, DateTimeKind.Local).AddTicks(7482) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 48, 46, 309, DateTimeKind.Local).AddTicks(2217), new DateTime(2024, 2, 7, 21, 48, 46, 309, DateTimeKind.Local).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 48, 46, 309, DateTimeKind.Local).AddTicks(2230), new DateTime(2024, 2, 7, 21, 48, 46, 309, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 48, 46, 309, DateTimeKind.Local).AddTicks(2232), new DateTime(2024, 2, 7, 21, 48, 46, 309, DateTimeKind.Local).AddTicks(2232) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 48, 46, 309, DateTimeKind.Local).AddTicks(2233), new DateTime(2024, 2, 7, 21, 48, 46, 309, DateTimeKind.Local).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 48, 46, 309, DateTimeKind.Local).AddTicks(2235), new DateTime(2024, 2, 7, 21, 48, 46, 309, DateTimeKind.Local).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 48, 46, 309, DateTimeKind.Local).AddTicks(2236), new DateTime(2024, 2, 7, 21, 48, 46, 309, DateTimeKind.Local).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 48, 46, 309, DateTimeKind.Local).AddTicks(2239), new DateTime(2024, 2, 7, 21, 48, 46, 309, DateTimeKind.Local).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 48, 46, 309, DateTimeKind.Local).AddTicks(2240), new DateTime(2024, 2, 7, 21, 48, 46, 309, DateTimeKind.Local).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 48, 46, 309, DateTimeKind.Local).AddTicks(2242), new DateTime(2024, 2, 7, 21, 48, 46, 309, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 48, 46, 309, DateTimeKind.Local).AddTicks(2243), new DateTime(2024, 2, 7, 21, 48, 46, 309, DateTimeKind.Local).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 48, 46, 309, DateTimeKind.Local).AddTicks(2244), new DateTime(2024, 2, 7, 21, 48, 46, 309, DateTimeKind.Local).AddTicks(2245) });
        }
    }
}
