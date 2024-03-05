using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "date('now')"),
                    Price = table.Column<decimal>(type: "real", nullable: false),
                    Properties = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    IsHome = table.Column<bool>(type: "INTEGER", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "date('now')"),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderNumber = table.Column<string>(type: "TEXT", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Note = table.Column<string>(type: "TEXT", nullable: true),
                    PaymentType = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderState = table.Column<int>(type: "INTEGER", nullable: false),
                    ConversationId = table.Column<string>(type: "TEXT", nullable: true),
                    PaymentId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    ShoppingCartId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7d5197f3-265d-4a56-bd60-92bf568e7ef7", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" },
                    { "94ff40e8-1681-4f6b-9aef-1b7ce40dd07c", null, "Kullanıcı haklarını taşıyan rol", "Customer", "CUSTOMER" },
                    { "c6a01b9d-339f-40af-92ad-157aeee64957", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "39eeb2de-9bc1-4fd8-ab9e-7f62f0382f5f", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "d3a20130-b9a6-43ad-b395-64482dfebde2", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmetea@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAEKBiZ8VB9S8jtn+FXDwnzfLCpUpEZhverLKbadpSyxzcd7HznVw0fqthME/jXjjH1Q==", "5387996655", false, "cf728171-c73e-4ae7-8f19-d757c8fc1d4b", false, "selinMete" },
                    { "6ae23710-4b88-462e-b662-94cd75908e07", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "a3ed3620-0238-4051-9112-9505f873027e", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAEBD2w+CVDNWuXVPNCDT0YOE4dbuq1AjI3YSpjyXHeoSoL+FDscztLtPBYEVNcHeS0g==", "5387996653", false, "315ed3a3-1acb-4976-a9fb-33ada6d0752f", false, "aysenumay" },
                    { "801f37ee-5f61-4913-9cfe-7bdf85249105", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "f9a6373e-282c-42d2-a0f1-af69637b2b00", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Erkek", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "DENIZFOCA", "AQAAAAIAAYagAAAAEJpJI+meb2Bj0uk8sGgTTjmJDD3+RUvhKOlEcaug4paNrHvZJtl7ROFqi00IThTBPA==", "5558779966", false, "9d928d0d-c720-48b0-a8a2-3563ef9d5763", false, "denizFoca" },
                    { "89df1de4-680b-4e7f-a619-c8963f95fc6a", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "6cc5bf03-3709-47b2-973a-5d2148752544", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAEND77eNSTdEZ0NWLbB5B+fZGrMToWgNTKcLGjg5PRRN60sDJbcx/QzyFLZasidDOIQ==", "5387996654", false, "61a55582-6b0a-4f8f-93c7-1a41fe88b929", false, "kemalDurukan" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedDate", "Name", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 3, 11, 43, 29, 679, DateTimeKind.Local).AddTicks(6824), "TV kategorisi", true, false, new DateTime(2024, 3, 3, 11, 43, 29, 679, DateTimeKind.Local).AddTicks(6836), "Televizyon", "televizyon" },
                    { 2, new DateTime(2024, 3, 3, 11, 43, 29, 679, DateTimeKind.Local).AddTicks(6841), "Bilgisayar kategorisi", true, false, new DateTime(2024, 3, 3, 11, 43, 29, 679, DateTimeKind.Local).AddTicks(6841), "Bilgisayar", "bilgisayar" },
                    { 3, new DateTime(2024, 3, 3, 11, 43, 29, 679, DateTimeKind.Local).AddTicks(6843), "Elektronik Eşya kategorisi", true, false, new DateTime(2024, 3, 3, 11, 43, 29, 679, DateTimeKind.Local).AddTicks(6843), "Elektronik Eşya", "elektronik-esya" },
                    { 4, new DateTime(2024, 3, 3, 11, 43, 29, 679, DateTimeKind.Local).AddTicks(6844), "Beyaz Eşya kategorisi", true, false, new DateTime(2024, 3, 3, 11, 43, 29, 679, DateTimeKind.Local).AddTicks(6845), "Beyaz Eşya", "beyaz-esya" },
                    { 5, new DateTime(2024, 3, 3, 11, 43, 29, 679, DateTimeKind.Local).AddTicks(6846), "Telefon kategorisi", true, false, new DateTime(2024, 3, 3, 11, 43, 29, 679, DateTimeKind.Local).AddTicks(6846), "Telefon", "telefon" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "ImageUrl", "IsActive", "IsDeleted", "IsHome", "ModifiedDate", "Name", "Price", "Properties", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 3, 11, 43, 29, 680, DateTimeKind.Local).AddTicks(3139), "1.png", true, false, true, new DateTime(2024, 3, 3, 11, 43, 29, 680, DateTimeKind.Local).AddTicks(3145), "IPhone 14", 59000m, "Harika bir telefon", "iphone-14" },
                    { 2, new DateTime(2024, 3, 3, 11, 43, 29, 680, DateTimeKind.Local).AddTicks(3151), "2.png", true, false, false, new DateTime(2024, 3, 3, 11, 43, 29, 680, DateTimeKind.Local).AddTicks(3151), "IPhone 14 Pro", 69000m, "Bu da harika bir telefon", "iphone-14-pro" },
                    { 3, new DateTime(2024, 3, 3, 11, 43, 29, 680, DateTimeKind.Local).AddTicks(3153), "3.png", true, false, true, new DateTime(2024, 3, 3, 11, 43, 29, 680, DateTimeKind.Local).AddTicks(3153), "Samsung S23", 49000m, "İdare eder", "samsung-s23" },
                    { 4, new DateTime(2024, 3, 3, 11, 43, 29, 680, DateTimeKind.Local).AddTicks(3155), "4.png", true, false, true, new DateTime(2024, 3, 3, 11, 43, 29, 680, DateTimeKind.Local).AddTicks(3155), "Xaomi Note 4", 39000m, "Harika bir telefon", "xaomi-note-4" },
                    { 5, new DateTime(2024, 3, 3, 11, 43, 29, 680, DateTimeKind.Local).AddTicks(3156), "5.png", true, false, true, new DateTime(2024, 3, 3, 11, 43, 29, 680, DateTimeKind.Local).AddTicks(3157), "MacBook Air M2", 52000m, "M2nin gücü", "macbook-air-m2" },
                    { 6, new DateTime(2024, 3, 3, 11, 43, 29, 680, DateTimeKind.Local).AddTicks(3158), "6.png", true, false, false, new DateTime(2024, 3, 3, 11, 43, 29, 680, DateTimeKind.Local).AddTicks(3158), "MacBook Pro M3", 79000m, "16 Gb ram", "macbook-pro-m3" },
                    { 7, new DateTime(2024, 3, 3, 11, 43, 29, 680, DateTimeKind.Local).AddTicks(3159), "7.png", true, false, true, new DateTime(2024, 3, 3, 11, 43, 29, 680, DateTimeKind.Local).AddTicks(3160), "Vestel Çamaşır Makinesi X65", 19000m, "Akıllı makine", "vestel-camasir-makinesi-x65" },
                    { 8, new DateTime(2024, 3, 3, 11, 43, 29, 680, DateTimeKind.Local).AddTicks(3161), "8.png", true, false, false, new DateTime(2024, 3, 3, 11, 43, 29, 680, DateTimeKind.Local).AddTicks(3168), "Arçelik Çamaşır Makinesi A-4", 21000m, "Süper hızlı makine", "arcelik-camasir-makinesi-a-4" },
                    { 9, new DateTime(2024, 3, 3, 11, 43, 29, 680, DateTimeKind.Local).AddTicks(3181), "9.png", true, false, true, new DateTime(2024, 3, 3, 11, 43, 29, 680, DateTimeKind.Local).AddTicks(3182), "Hoop Dijital Radyo X96", 1250m, "Klasik radyo keyfi", "hoop-dijital-radyo-x96" },
                    { 10, new DateTime(2024, 3, 3, 11, 43, 29, 680, DateTimeKind.Local).AddTicks(3183), "10.png", true, false, true, new DateTime(2024, 3, 3, 11, 43, 29, 680, DateTimeKind.Local).AddTicks(3183), "Xaomi Dijital Baskül", 2100m, "Kilonuzu kontrol edin", "xaomi-dijital-baskul" },
                    { 11, new DateTime(2024, 3, 3, 11, 43, 29, 680, DateTimeKind.Local).AddTicks(3185), "11.png", true, false, true, new DateTime(2024, 3, 3, 11, 43, 29, 680, DateTimeKind.Local).AddTicks(3185), "Blaupunkt AC69 Led TV", 9800m, "Android tv", "blaupunkt-ac69-led-tv" }
                });

            migrationBuilder.InsertData(
                table: "ShoppingCarts",
                columns: new[] { "Id", "CreatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 3, 11, 43, 29, 679, DateTimeKind.Local).AddTicks(2126), "801f37ee-5f61-4913-9cfe-7bdf85249105" },
                    { 2, new DateTime(2024, 3, 3, 11, 43, 29, 679, DateTimeKind.Local).AddTicks(2146), "39eeb2de-9bc1-4fd8-ab9e-7f62f0382f5f" },
                    { 3, new DateTime(2024, 3, 3, 11, 43, 29, 679, DateTimeKind.Local).AddTicks(2147), "89df1de4-680b-4e7f-a619-c8963f95fc6a" },
                    { 4, new DateTime(2024, 3, 3, 11, 43, 29, 679, DateTimeKind.Local).AddTicks(2149), "6ae23710-4b88-462e-b662-94cd75908e07" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c6a01b9d-339f-40af-92ad-157aeee64957", "39eeb2de-9bc1-4fd8-ab9e-7f62f0382f5f" },
                    { "94ff40e8-1681-4f6b-9aef-1b7ce40dd07c", "6ae23710-4b88-462e-b662-94cd75908e07" },
                    { "7d5197f3-265d-4a56-bd60-92bf568e7ef7", "801f37ee-5f61-4913-9cfe-7bdf85249105" },
                    { "c6a01b9d-339f-40af-92ad-157aeee64957", "89df1de4-680b-4e7f-a619-c8963f95fc6a" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 3, 1 },
                    { 5, 1 },
                    { 3, 2 },
                    { 5, 2 },
                    { 3, 3 },
                    { 5, 3 },
                    { 3, 4 },
                    { 5, 4 },
                    { 2, 5 },
                    { 3, 5 },
                    { 2, 6 },
                    { 3, 6 },
                    { 3, 7 },
                    { 4, 7 },
                    { 3, 8 },
                    { 4, 8 },
                    { 3, 9 },
                    { 3, 10 },
                    { 4, 10 },
                    { 1, 11 },
                    { 3, 11 },
                    { 4, 11 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ProductId",
                table: "ShoppingCartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ShoppingCartId",
                table: "ShoppingCartItems",
                column: "ShoppingCartId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
