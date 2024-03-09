using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class MessageEdited : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3cd8c9b0-7d53-4ade-8a3e-1afc65383997", "1a6ae5c1-adcc-4d79-887b-bc468b24422b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bda0b13d-de4a-4998-b263-6345071040e4", "252c24b3-0280-4437-ad6e-3fda8b789d29" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b2753688-62a8-427a-bf08-4c43b2166070", "2f290bd0-10fe-4210-b7e5-3c867869f7b5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b2753688-62a8-427a-bf08-4c43b2166070", "e9fe69a0-4da2-4d38-9440-449f9bdb7c10" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cd8c9b0-7d53-4ade-8a3e-1afc65383997");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2753688-62a8-427a-bf08-4c43b2166070");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bda0b13d-de4a-4998-b263-6345071040e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a6ae5c1-adcc-4d79-887b-bc468b24422b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "252c24b3-0280-4437-ad6e-3fda8b789d29");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f290bd0-10fe-4210-b7e5-3c867869f7b5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9fe69a0-4da2-4d38-9440-449f9bdb7c10");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "35b626ff-e04b-4b33-a9b6-744e1139afeb", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" },
                    { "6ed47366-5472-4469-a171-de5cf05a8e91", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" },
                    { "b8ea906e-5f3b-4c18-b776-bab8a257bc94", null, "Kullanıcı haklarını taşıyan rol", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "29364d2a-3f78-4e26-814a-62d20dacc487", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "890bb5e9-dbfa-4e25-a216-8779d4b0b348", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmetea@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAEANu7k+uIbxJ6qzfV4yVVv8EQ6F1JEZcULaq2wmj4Jor19Jz4AO7UClL2hwtaTQiLg==", "5387996655", false, "ec7dff32-8232-458a-9d10-f27e44f1b379", false, "selinMete" },
                    { "2dc79b36-c957-4b5f-85c2-33edc1655b87", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "cfa72fe2-ebdc-47f3-8b41-eb844460adf2", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Erkek", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "DENIZFOCA", "AQAAAAIAAYagAAAAEGnsZTWkZc8zRDQYQiC84SegV3n2tbtrnNRVp56QTRZI4pfQogeF3YGRj2OxrKkWHA==", "5558779966", false, "86fd7721-53e5-42e2-a6b7-94ac9fc60889", false, "denizFoca" },
                    { "4802b204-7be6-4efe-aeb1-4cad00137a11", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "31dfc132-0d36-48dc-ba5d-e86b49a3116d", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAEAsM/p2gRzizZMReCrfvpSXr7kHyi5i4HTy8a4V9B0jl/idT1l3O4NZhoYsGmy4y1A==", "5387996654", false, "452b9feb-7a8f-46bf-8a34-c5ed6aae351b", false, "kemalDurukan" },
                    { "eba03f7a-740b-4d40-883c-1cb825dba7bd", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "f7a58f00-9ac8-4a87-a233-ed823b504bbb", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAEEcXsWOYhtrFoyk28/JKHmYx8RC3u+R/KoXMCouj8pplJOnojy3E7Cmj5Egd/Cj/TQ==", "5387996653", false, "44e8d6e8-d9a9-4685-be4e-c06aad9a84b9", false, "aysenumay" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 22, 873, DateTimeKind.Local).AddTicks(343), new DateTime(2024, 3, 6, 19, 5, 22, 873, DateTimeKind.Local).AddTicks(352) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 22, 873, DateTimeKind.Local).AddTicks(359), new DateTime(2024, 3, 6, 19, 5, 22, 873, DateTimeKind.Local).AddTicks(359) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 22, 873, DateTimeKind.Local).AddTicks(360), new DateTime(2024, 3, 6, 19, 5, 22, 873, DateTimeKind.Local).AddTicks(361) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 22, 873, DateTimeKind.Local).AddTicks(362), new DateTime(2024, 3, 6, 19, 5, 22, 873, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 22, 873, DateTimeKind.Local).AddTicks(436), new DateTime(2024, 3, 6, 19, 5, 22, 873, DateTimeKind.Local).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 22, 874, DateTimeKind.Local).AddTicks(400), new DateTime(2024, 3, 6, 19, 5, 22, 874, DateTimeKind.Local).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 22, 874, DateTimeKind.Local).AddTicks(417), new DateTime(2024, 3, 6, 19, 5, 22, 874, DateTimeKind.Local).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 22, 874, DateTimeKind.Local).AddTicks(419), new DateTime(2024, 3, 6, 19, 5, 22, 874, DateTimeKind.Local).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 22, 874, DateTimeKind.Local).AddTicks(421), new DateTime(2024, 3, 6, 19, 5, 22, 874, DateTimeKind.Local).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 22, 874, DateTimeKind.Local).AddTicks(423), new DateTime(2024, 3, 6, 19, 5, 22, 874, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 22, 874, DateTimeKind.Local).AddTicks(427), new DateTime(2024, 3, 6, 19, 5, 22, 874, DateTimeKind.Local).AddTicks(427) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 22, 874, DateTimeKind.Local).AddTicks(429), new DateTime(2024, 3, 6, 19, 5, 22, 874, DateTimeKind.Local).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 22, 874, DateTimeKind.Local).AddTicks(431), new DateTime(2024, 3, 6, 19, 5, 22, 874, DateTimeKind.Local).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 22, 874, DateTimeKind.Local).AddTicks(464), new DateTime(2024, 3, 6, 19, 5, 22, 874, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 22, 874, DateTimeKind.Local).AddTicks(467), new DateTime(2024, 3, 6, 19, 5, 22, 874, DateTimeKind.Local).AddTicks(467) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 22, 874, DateTimeKind.Local).AddTicks(469), new DateTime(2024, 3, 6, 19, 5, 22, 874, DateTimeKind.Local).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 22, 872, DateTimeKind.Local).AddTicks(6508), "2dc79b36-c957-4b5f-85c2-33edc1655b87" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 22, 872, DateTimeKind.Local).AddTicks(6537), "29364d2a-3f78-4e26-814a-62d20dacc487" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 22, 872, DateTimeKind.Local).AddTicks(6539), "4802b204-7be6-4efe-aeb1-4cad00137a11" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 5, 22, 872, DateTimeKind.Local).AddTicks(6540), "eba03f7a-740b-4d40-883c-1cb825dba7bd" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "35b626ff-e04b-4b33-a9b6-744e1139afeb", "29364d2a-3f78-4e26-814a-62d20dacc487" },
                    { "6ed47366-5472-4469-a171-de5cf05a8e91", "2dc79b36-c957-4b5f-85c2-33edc1655b87" },
                    { "35b626ff-e04b-4b33-a9b6-744e1139afeb", "4802b204-7be6-4efe-aeb1-4cad00137a11" },
                    { "b8ea906e-5f3b-4c18-b776-bab8a257bc94", "eba03f7a-740b-4d40-883c-1cb825dba7bd" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "35b626ff-e04b-4b33-a9b6-744e1139afeb", "29364d2a-3f78-4e26-814a-62d20dacc487" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6ed47366-5472-4469-a171-de5cf05a8e91", "2dc79b36-c957-4b5f-85c2-33edc1655b87" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "35b626ff-e04b-4b33-a9b6-744e1139afeb", "4802b204-7be6-4efe-aeb1-4cad00137a11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b8ea906e-5f3b-4c18-b776-bab8a257bc94", "eba03f7a-740b-4d40-883c-1cb825dba7bd" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35b626ff-e04b-4b33-a9b6-744e1139afeb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ed47366-5472-4469-a171-de5cf05a8e91");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8ea906e-5f3b-4c18-b776-bab8a257bc94");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29364d2a-3f78-4e26-814a-62d20dacc487");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2dc79b36-c957-4b5f-85c2-33edc1655b87");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4802b204-7be6-4efe-aeb1-4cad00137a11");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eba03f7a-740b-4d40-883c-1cb825dba7bd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3cd8c9b0-7d53-4ade-8a3e-1afc65383997", null, "Kullanıcı haklarını taşıyan rol", "Customer", "CUSTOMER" },
                    { "b2753688-62a8-427a-bf08-4c43b2166070", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" },
                    { "bda0b13d-de4a-4998-b263-6345071040e4", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1a6ae5c1-adcc-4d79-887b-bc468b24422b", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "49dec177-0620-4a4e-aea0-a3598358ebf1", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAEH8WzSfotsyI2OsfAAX5FQGjE5BVa/LWEaM902+u1joJvfY1B+WReSSj10dHf+QFlA==", "5387996653", false, "7f124301-64b9-4f76-9a05-51c10c0c6e8a", false, "aysenumay" },
                    { "252c24b3-0280-4437-ad6e-3fda8b789d29", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "21137fa9-6fa0-4068-acea-5111389bc6fa", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Erkek", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "DENIZFOCA", "AQAAAAIAAYagAAAAEFuFh/tDzzR/bqvG/B9Y/NZD5MP91ZnDqPOSMwZO0MZd76xm3HHOPePMozh37ixQdw==", "5558779966", false, "6022e3e3-b730-487f-af00-250327d7bb96", false, "denizFoca" },
                    { "2f290bd0-10fe-4210-b7e5-3c867869f7b5", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "05805a3a-3b21-41d8-b596-dfe79d06f06e", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmetea@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAEAQOtNGcSlODtFeZqqp3e7VjtiI9UX7wqJMEVs27zBk/oHIYPpNedKPiB2cVmNswWA==", "5387996655", false, "52d7c358-8cda-4c6d-ab9d-6d319492d4e4", false, "selinMete" },
                    { "e9fe69a0-4da2-4d38-9440-449f9bdb7c10", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "e0f2f510-37ea-4813-851b-ba0867b6e8db", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAEKmp6xx2CWaA7ywu3Ke4Qorcmf8kDO2hzVzreOHvfQubweSspa5uxNwjl0G1YKAjCQ==", "5387996654", false, "adcd6e0f-6e46-4d70-aba4-71e4075e71e0", false, "kemalDurukan" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 37, 724, DateTimeKind.Local).AddTicks(4792), new DateTime(2024, 3, 5, 20, 2, 37, 724, DateTimeKind.Local).AddTicks(4798) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 37, 724, DateTimeKind.Local).AddTicks(4802), new DateTime(2024, 3, 5, 20, 2, 37, 724, DateTimeKind.Local).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 37, 724, DateTimeKind.Local).AddTicks(4804), new DateTime(2024, 3, 5, 20, 2, 37, 724, DateTimeKind.Local).AddTicks(4804) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 37, 724, DateTimeKind.Local).AddTicks(4805), new DateTime(2024, 3, 5, 20, 2, 37, 724, DateTimeKind.Local).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 37, 724, DateTimeKind.Local).AddTicks(4806), new DateTime(2024, 3, 5, 20, 2, 37, 724, DateTimeKind.Local).AddTicks(4807) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 37, 725, DateTimeKind.Local).AddTicks(2903), new DateTime(2024, 3, 5, 20, 2, 37, 725, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 37, 725, DateTimeKind.Local).AddTicks(2916), new DateTime(2024, 3, 5, 20, 2, 37, 725, DateTimeKind.Local).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 37, 725, DateTimeKind.Local).AddTicks(2918), new DateTime(2024, 3, 5, 20, 2, 37, 725, DateTimeKind.Local).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 37, 725, DateTimeKind.Local).AddTicks(2920), new DateTime(2024, 3, 5, 20, 2, 37, 725, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 37, 725, DateTimeKind.Local).AddTicks(2922), new DateTime(2024, 3, 5, 20, 2, 37, 725, DateTimeKind.Local).AddTicks(2922) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 37, 725, DateTimeKind.Local).AddTicks(2923), new DateTime(2024, 3, 5, 20, 2, 37, 725, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 37, 725, DateTimeKind.Local).AddTicks(2925), new DateTime(2024, 3, 5, 20, 2, 37, 725, DateTimeKind.Local).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 37, 725, DateTimeKind.Local).AddTicks(2927), new DateTime(2024, 3, 5, 20, 2, 37, 725, DateTimeKind.Local).AddTicks(2934) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 37, 725, DateTimeKind.Local).AddTicks(2952), new DateTime(2024, 3, 5, 20, 2, 37, 725, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 37, 725, DateTimeKind.Local).AddTicks(2954), new DateTime(2024, 3, 5, 20, 2, 37, 725, DateTimeKind.Local).AddTicks(2954) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 37, 725, DateTimeKind.Local).AddTicks(2958), new DateTime(2024, 3, 5, 20, 2, 37, 725, DateTimeKind.Local).AddTicks(2959) });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 37, 723, DateTimeKind.Local).AddTicks(8801), "252c24b3-0280-4437-ad6e-3fda8b789d29" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 37, 723, DateTimeKind.Local).AddTicks(8821), "2f290bd0-10fe-4210-b7e5-3c867869f7b5" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 37, 723, DateTimeKind.Local).AddTicks(8822), "e9fe69a0-4da2-4d38-9440-449f9bdb7c10" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 2, 37, 723, DateTimeKind.Local).AddTicks(8823), "1a6ae5c1-adcc-4d79-887b-bc468b24422b" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3cd8c9b0-7d53-4ade-8a3e-1afc65383997", "1a6ae5c1-adcc-4d79-887b-bc468b24422b" },
                    { "bda0b13d-de4a-4998-b263-6345071040e4", "252c24b3-0280-4437-ad6e-3fda8b789d29" },
                    { "b2753688-62a8-427a-bf08-4c43b2166070", "2f290bd0-10fe-4210-b7e5-3c867869f7b5" },
                    { "b2753688-62a8-427a-bf08-4c43b2166070", "e9fe69a0-4da2-4d38-9440-449f9bdb7c10" }
                });
        }
    }
}
