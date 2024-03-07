using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class MessageRelationEdit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "24b30403-5e01-45fe-a697-5a6c5edcbf63", "03ada15f-f69d-4ec5-83d2-56374e0f3f5e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "174e1756-2bdb-49d6-b100-49f9d5c427d6", "5b576230-15bb-4472-9be2-8d11bf32ab7b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "71444f37-0d24-47fe-955f-bbeac65eb572", "afb9cd62-825d-474a-acb9-b933e4cedcf8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "71444f37-0d24-47fe-955f-bbeac65eb572", "bf27aeab-c0b4-4bc4-804b-05833646b2c6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "174e1756-2bdb-49d6-b100-49f9d5c427d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24b30403-5e01-45fe-a697-5a6c5edcbf63");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71444f37-0d24-47fe-955f-bbeac65eb572");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "03ada15f-f69d-4ec5-83d2-56374e0f3f5e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b576230-15bb-4472-9be2-8d11bf32ab7b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afb9cd62-825d-474a-acb9-b933e4cedcf8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf27aeab-c0b4-4bc4-804b-05833646b2c6");

            migrationBuilder.AddColumn<int>(
                name: "RelatedId",
                table: "Message",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3949328d-75d5-4a6c-a802-084cac11c573", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" },
                    { "a37212ca-8013-4cd1-9e2e-3de272ff992b", null, "Kullanıcı haklarını taşıyan rol", "Customer", "CUSTOMER" },
                    { "a5dd8578-3cf8-496b-8ff2-7ee41b0c8578", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "59efde3f-1550-40dd-9fd2-58819b0a3486", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "6fb8c01b-4ed2-4def-b6e2-033578a66803", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAECPBT8Ocf9Yoi2aHTbpb8267fnjsggLKgBERiLEGW1wiemReyUsL0DxdRZGj5XHWTA==", "5387996653", false, "40a146fc-300f-4b5c-91ad-193d8e7e0185", false, "aysenumay" },
                    { "a67078ba-86e7-495b-9a68-5eb59dd47acb", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "75e0f521-3432-49fb-befb-2f06fd6024d6", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAEP5tH+lAbbnmQN1EUDB32UaG88t7FNajouI8yDoKKr0+cToFzJYPawAVqk79YwdDIg==", "5387996654", false, "4a3c24c8-1aa3-4535-92ef-06f1fa8b4057", false, "kemalDurukan" },
                    { "b0a44363-a3fd-442e-8e60-bc9b9fed8722", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "81ef5bb3-7a3d-4e8e-bf99-4d4ca782b7eb", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmetea@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAEAK5b0mB6D7pD8LRTe+IYhd0iU4TuzKfEoY/5Eb2p4tAvRPw6RgJi+HtqbRgq62ilQ==", "5387996655", false, "342b99f4-e8b7-47b4-9fbb-ddc433e44c4d", false, "selinMete" },
                    { "fb9641f5-3e4b-4864-8542-2ef76fed8149", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "8fb965bc-24c3-4a0f-bd6f-6b0115ac15a1", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Erkek", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "DENIZFOCA", "AQAAAAIAAYagAAAAEKvOUfk/ccc6A8W9gG17dN3tk7mjaVH9xzyt6nUD8f2vfCGQIKGXbvjoh2F/0FMH0A==", "5558779966", false, "8de2db03-ff2a-4b40-8b32-afa12a2f3282", false, "denizFoca" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 24, 477, DateTimeKind.Local).AddTicks(6409), new DateTime(2024, 3, 7, 20, 19, 24, 477, DateTimeKind.Local).AddTicks(6415) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 24, 477, DateTimeKind.Local).AddTicks(6419), new DateTime(2024, 3, 7, 20, 19, 24, 477, DateTimeKind.Local).AddTicks(6419) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 24, 477, DateTimeKind.Local).AddTicks(6421), new DateTime(2024, 3, 7, 20, 19, 24, 477, DateTimeKind.Local).AddTicks(6421) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 24, 477, DateTimeKind.Local).AddTicks(6422), new DateTime(2024, 3, 7, 20, 19, 24, 477, DateTimeKind.Local).AddTicks(6422) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 24, 477, DateTimeKind.Local).AddTicks(6423), new DateTime(2024, 3, 7, 20, 19, 24, 477, DateTimeKind.Local).AddTicks(6424) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 24, 478, DateTimeKind.Local).AddTicks(2836), new DateTime(2024, 3, 7, 20, 19, 24, 478, DateTimeKind.Local).AddTicks(2841) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 24, 478, DateTimeKind.Local).AddTicks(2882), new DateTime(2024, 3, 7, 20, 19, 24, 478, DateTimeKind.Local).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 24, 478, DateTimeKind.Local).AddTicks(2885), new DateTime(2024, 3, 7, 20, 19, 24, 478, DateTimeKind.Local).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 24, 478, DateTimeKind.Local).AddTicks(2886), new DateTime(2024, 3, 7, 20, 19, 24, 478, DateTimeKind.Local).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 24, 478, DateTimeKind.Local).AddTicks(2888), new DateTime(2024, 3, 7, 20, 19, 24, 478, DateTimeKind.Local).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 24, 478, DateTimeKind.Local).AddTicks(2890), new DateTime(2024, 3, 7, 20, 19, 24, 478, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 24, 478, DateTimeKind.Local).AddTicks(2891), new DateTime(2024, 3, 7, 20, 19, 24, 478, DateTimeKind.Local).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 24, 478, DateTimeKind.Local).AddTicks(2893), new DateTime(2024, 3, 7, 20, 19, 24, 478, DateTimeKind.Local).AddTicks(2897) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 24, 478, DateTimeKind.Local).AddTicks(2914), new DateTime(2024, 3, 7, 20, 19, 24, 478, DateTimeKind.Local).AddTicks(2915) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 24, 478, DateTimeKind.Local).AddTicks(2916), new DateTime(2024, 3, 7, 20, 19, 24, 478, DateTimeKind.Local).AddTicks(2916) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 24, 478, DateTimeKind.Local).AddTicks(2917), new DateTime(2024, 3, 7, 20, 19, 24, 478, DateTimeKind.Local).AddTicks(2918) });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 24, 477, DateTimeKind.Local).AddTicks(1170), "fb9641f5-3e4b-4864-8542-2ef76fed8149" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 24, 477, DateTimeKind.Local).AddTicks(1193), "b0a44363-a3fd-442e-8e60-bc9b9fed8722" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 24, 477, DateTimeKind.Local).AddTicks(1194), "a67078ba-86e7-495b-9a68-5eb59dd47acb" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 19, 24, 477, DateTimeKind.Local).AddTicks(1196), "59efde3f-1550-40dd-9fd2-58819b0a3486" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "a37212ca-8013-4cd1-9e2e-3de272ff992b", "59efde3f-1550-40dd-9fd2-58819b0a3486" },
                    { "a5dd8578-3cf8-496b-8ff2-7ee41b0c8578", "a67078ba-86e7-495b-9a68-5eb59dd47acb" },
                    { "a5dd8578-3cf8-496b-8ff2-7ee41b0c8578", "b0a44363-a3fd-442e-8e60-bc9b9fed8722" },
                    { "3949328d-75d5-4a6c-a802-084cac11c573", "fb9641f5-3e4b-4864-8542-2ef76fed8149" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a37212ca-8013-4cd1-9e2e-3de272ff992b", "59efde3f-1550-40dd-9fd2-58819b0a3486" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a5dd8578-3cf8-496b-8ff2-7ee41b0c8578", "a67078ba-86e7-495b-9a68-5eb59dd47acb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a5dd8578-3cf8-496b-8ff2-7ee41b0c8578", "b0a44363-a3fd-442e-8e60-bc9b9fed8722" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3949328d-75d5-4a6c-a802-084cac11c573", "fb9641f5-3e4b-4864-8542-2ef76fed8149" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3949328d-75d5-4a6c-a802-084cac11c573");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a37212ca-8013-4cd1-9e2e-3de272ff992b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5dd8578-3cf8-496b-8ff2-7ee41b0c8578");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59efde3f-1550-40dd-9fd2-58819b0a3486");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a67078ba-86e7-495b-9a68-5eb59dd47acb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0a44363-a3fd-442e-8e60-bc9b9fed8722");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fb9641f5-3e4b-4864-8542-2ef76fed8149");

            migrationBuilder.DropColumn(
                name: "RelatedId",
                table: "Message");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "174e1756-2bdb-49d6-b100-49f9d5c427d6", null, "Kullanıcı haklarını taşıyan rol", "Customer", "CUSTOMER" },
                    { "24b30403-5e01-45fe-a697-5a6c5edcbf63", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" },
                    { "71444f37-0d24-47fe-955f-bbeac65eb572", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "03ada15f-f69d-4ec5-83d2-56374e0f3f5e", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "92521521-7c02-480e-8dc8-d4a06d2ea385", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Erkek", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "DENIZFOCA", "AQAAAAIAAYagAAAAEDyDK8bt+G5ej0uHkpq8uQn6raJprSQlPLnZs/D9SjhIYHrrzdpUsgcXxjkZji98oQ==", "5558779966", false, "d6b601b1-7e62-4df8-8aaa-d1b377c127e4", false, "denizFoca" },
                    { "5b576230-15bb-4472-9be2-8d11bf32ab7b", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "42e9efbe-f780-4deb-9817-dfd762ac944a", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAENkfAHvXBG2sEZipCwFh7ATUJUy+WmbfGBDwIcfz/DOJPP79Qvzbn7+D9SVQRKXM5A==", "5387996653", false, "8b46f8e8-1580-439f-b91f-f84c29e48f65", false, "aysenumay" },
                    { "afb9cd62-825d-474a-acb9-b933e4cedcf8", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "d069c3e2-07c1-404c-8467-8ce691ae994a", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAEHrpfpnR2Yc+tVxNJiVYJihrRPF+su3NgvEpxC03RLosfYgqL8nqcMb/Zjc0BQHamA==", "5387996654", false, "ff4c2eaf-9620-4365-8127-5f1cbf0e8aef", false, "kemalDurukan" },
                    { "bf27aeab-c0b4-4bc4-804b-05833646b2c6", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "d977768d-7eed-4b81-9fbc-65d31bbb4244", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmetea@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAEH6Dds7Ezhr9Ca7wn35bbCfERHEYrTHNjFbU3yXj89vDwiS3HCtKDd/NVEWgbMkeew==", "5387996655", false, "6ebe6396-97fc-4f0a-a121-4b62d0a82b37", false, "selinMete" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 35, 704, DateTimeKind.Local).AddTicks(3515), new DateTime(2024, 3, 6, 19, 7, 35, 704, DateTimeKind.Local).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 35, 704, DateTimeKind.Local).AddTicks(3531), new DateTime(2024, 3, 6, 19, 7, 35, 704, DateTimeKind.Local).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 35, 704, DateTimeKind.Local).AddTicks(3533), new DateTime(2024, 3, 6, 19, 7, 35, 704, DateTimeKind.Local).AddTicks(3533) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 35, 704, DateTimeKind.Local).AddTicks(3535), new DateTime(2024, 3, 6, 19, 7, 35, 704, DateTimeKind.Local).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 35, 704, DateTimeKind.Local).AddTicks(3536), new DateTime(2024, 3, 6, 19, 7, 35, 704, DateTimeKind.Local).AddTicks(3537) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 35, 705, DateTimeKind.Local).AddTicks(802), new DateTime(2024, 3, 6, 19, 7, 35, 705, DateTimeKind.Local).AddTicks(809) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 35, 705, DateTimeKind.Local).AddTicks(816), new DateTime(2024, 3, 6, 19, 7, 35, 705, DateTimeKind.Local).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 35, 705, DateTimeKind.Local).AddTicks(819), new DateTime(2024, 3, 6, 19, 7, 35, 705, DateTimeKind.Local).AddTicks(819) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 35, 705, DateTimeKind.Local).AddTicks(821), new DateTime(2024, 3, 6, 19, 7, 35, 705, DateTimeKind.Local).AddTicks(821) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 35, 705, DateTimeKind.Local).AddTicks(823), new DateTime(2024, 3, 6, 19, 7, 35, 705, DateTimeKind.Local).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 35, 705, DateTimeKind.Local).AddTicks(825), new DateTime(2024, 3, 6, 19, 7, 35, 705, DateTimeKind.Local).AddTicks(825) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 35, 705, DateTimeKind.Local).AddTicks(827), new DateTime(2024, 3, 6, 19, 7, 35, 705, DateTimeKind.Local).AddTicks(827) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 35, 705, DateTimeKind.Local).AddTicks(829), new DateTime(2024, 3, 6, 19, 7, 35, 705, DateTimeKind.Local).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 35, 705, DateTimeKind.Local).AddTicks(850), new DateTime(2024, 3, 6, 19, 7, 35, 705, DateTimeKind.Local).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 35, 705, DateTimeKind.Local).AddTicks(852), new DateTime(2024, 3, 6, 19, 7, 35, 705, DateTimeKind.Local).AddTicks(853) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 35, 705, DateTimeKind.Local).AddTicks(856), new DateTime(2024, 3, 6, 19, 7, 35, 705, DateTimeKind.Local).AddTicks(856) });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 35, 703, DateTimeKind.Local).AddTicks(7148), "03ada15f-f69d-4ec5-83d2-56374e0f3f5e" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 35, 703, DateTimeKind.Local).AddTicks(7186), "bf27aeab-c0b4-4bc4-804b-05833646b2c6" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 35, 703, DateTimeKind.Local).AddTicks(7189), "afb9cd62-825d-474a-acb9-b933e4cedcf8" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 7, 35, 703, DateTimeKind.Local).AddTicks(7191), "5b576230-15bb-4472-9be2-8d11bf32ab7b" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "24b30403-5e01-45fe-a697-5a6c5edcbf63", "03ada15f-f69d-4ec5-83d2-56374e0f3f5e" },
                    { "174e1756-2bdb-49d6-b100-49f9d5c427d6", "5b576230-15bb-4472-9be2-8d11bf32ab7b" },
                    { "71444f37-0d24-47fe-955f-bbeac65eb572", "afb9cd62-825d-474a-acb9-b933e4cedcf8" },
                    { "71444f37-0d24-47fe-955f-bbeac65eb572", "bf27aeab-c0b4-4bc4-804b-05833646b2c6" }
                });
        }
    }
}
