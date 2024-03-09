using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class MessageEdited2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SendingDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Text = table.Column<string>(type: "TEXT", nullable: true),
                    ToId = table.Column<string>(type: "TEXT", nullable: true),
                    ToName = table.Column<string>(type: "TEXT", nullable: true),
                    FromId = table.Column<string>(type: "TEXT", nullable: true),
                    FromName = table.Column<string>(type: "TEXT", nullable: true),
                    IsRead = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Message");

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
    }
}
