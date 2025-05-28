using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace USLabs.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SecurityMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("04136d71-7fc0-4dea-912b-57ecb156816f"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("6072610f-7cd2-4b3b-bae1-4b46d006da34"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("6d7947b5-9571-42ba-baa9-822ac7230823"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("8791ac0d-8c65-4f3a-8712-dde0e24a8096"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("9f198e87-266c-4fa2-9401-d10781533e80"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("b38eba8e-d006-4892-8606-4f6f2edf3dce"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("c6613ba9-9eb5-494d-9727-995ece9afef1"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("c8a22eab-0117-4dcb-ab21-6f965178a1c5"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("f8a7a0b0-6390-4d4d-a99c-0fcaa30cbe5b"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("144b234d-4704-4b79-ac5b-2180107b6b89"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("3880ba5c-80d0-4cb0-98a7-012ad2442475"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("38cca2bb-bb55-48b0-8e88-74b9a2572131"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("43badb03-7c6b-4fe7-8cee-a051d6a943f6"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("5f64f1e3-e6eb-4f22-b8d4-2de4a0744081"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("8120f029-5074-434c-b094-97f86c7300c8"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("970223b0-afd4-4b56-9053-1ef77b4ed1eb"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("e365656b-6ef5-4894-ba60-b9ad380d20a9"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("e717cee1-322d-4995-aa06-ac66d5eac4b8"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("edae10f9-0c55-459f-b4b5-3dcf39697dc7"));

            migrationBuilder.DeleteData(
                table: "precios",
                keyColumn: "Id",
                keyValue: new Guid("af67c31c-d7c2-462d-b712-c1faae1dea64"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
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
                    NombreCompleto = table.Column<string>(type: "TEXT", nullable: true),
                    Carrera = table.Column<string>(type: "TEXT", nullable: true),
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "251c7549-b0c9-48b5-9291-7e4f6aff7931", null, "CLIENT", "CLIENT" },
                    { "9bce5a2e-1b18-45e7-adf4-91dede28fa3d", null, "ADMIN", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "cursos",
                columns: new[] { "Id", "Descripcion", "FechaPublicacion", "Titulo" },
                values: new object[,]
                {
                    { new Guid("091fd643-8a73-4d3f-8e60-df8701f35da5"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2025, 5, 28, 4, 14, 45, 662, DateTimeKind.Utc).AddTicks(1200), "Gorgeous Wooden Chair" },
                    { new Guid("13ce05a8-e386-4c24-8987-58dcef664bf9"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2025, 5, 28, 4, 14, 45, 662, DateTimeKind.Utc).AddTicks(1170), "Rustic Steel Fish" },
                    { new Guid("1e095bee-2bc0-4e99-bae6-9e1b35a5decb"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2025, 5, 28, 4, 14, 45, 662, DateTimeKind.Utc).AddTicks(1320), "Intelligent Fresh Keyboard" },
                    { new Guid("a46ba943-ed9f-44ca-be72-1f2814a3c6d3"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2025, 5, 28, 4, 14, 45, 662, DateTimeKind.Utc).AddTicks(1220), "Handmade Rubber Table" },
                    { new Guid("a8c3b709-0843-41f7-9cd4-370a4dd88118"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2025, 5, 28, 4, 14, 45, 662, DateTimeKind.Utc).AddTicks(1350), "Sleek Cotton Shirt" },
                    { new Guid("ad4dcc53-f50e-4f1b-b69a-c8db469bc79c"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(2025, 5, 28, 4, 14, 45, 662, DateTimeKind.Utc).AddTicks(1260), "Sleek Concrete Towels" },
                    { new Guid("ddbb3dc6-cd32-4b0c-9779-1bf49c6996c0"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2025, 5, 28, 4, 14, 45, 662, DateTimeKind.Utc).AddTicks(1330), "Gorgeous Plastic Bike" },
                    { new Guid("e09820cf-2784-49e7-9120-9e9a5f555b04"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2025, 5, 28, 4, 14, 45, 662, DateTimeKind.Utc).AddTicks(1240), "Unbranded Rubber Soap" },
                    { new Guid("eccfc8bb-ca65-48c7-81fb-045c746b9ad1"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2025, 5, 28, 4, 14, 45, 662, DateTimeKind.Utc).AddTicks(1290), "Practical Frozen Computer" }
                });

            migrationBuilder.InsertData(
                table: "instructores",
                columns: new[] { "Id", "Apellidos", "Grado", "Nombre" },
                values: new object[,]
                {
                    { new Guid("5882c8ee-4837-4d35-8c1a-03d6d79e5901"), "Ledner", "Future Solutions Producer", "Colby" },
                    { new Guid("7a4f6be7-8185-452a-baec-7ffc20915bc1"), "Morar", "Human Research Representative", "Jeramy" },
                    { new Guid("ae60729f-f366-4d0c-a014-bc47abd6d0f8"), "Ritchie", "Chief Security Associate", "Wendell" },
                    { new Guid("affa4c25-36c5-4e68-b267-7585dac41adc"), "Lubowitz", "Global Mobility Administrator", "Cristopher" },
                    { new Guid("b29e8654-818e-4ee7-a5e5-e01cbd9516e3"), "Paucek", "Corporate Metrics Analyst", "Elsie" },
                    { new Guid("c5a9b150-6180-4dba-8242-915cadd0d6f6"), "Thompson", "Regional Creative Director", "Reese" },
                    { new Guid("d70e65da-d0bc-4b44-a313-07afd1c4d617"), "Muller", "Internal Brand Analyst", "Dariana" },
                    { new Guid("dcb0db52-7eb0-413b-a0e2-e6e28bed1a03"), "Mayert", "Forward Usability Analyst", "Jordan" },
                    { new Guid("dd26ca77-0fb5-4b4b-9c40-ee88230b0587"), "Ankunding", "Senior Functionality Producer", "Barbara" },
                    { new Guid("e45c48f5-5650-4c43-ab90-d3363154bf94"), "O'Connell", "Central Metrics Administrator", "Zackary" }
                });

            migrationBuilder.InsertData(
                table: "precios",
                columns: new[] { "Id", "Nombre", "PrecioActual", "PrecioPromocion" },
                values: new object[] { new Guid("f653873e-9318-48a0-ab04-b8d25facc68f"), "Precio regular", 10.0m, 5.0m });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 1, "POLICIES", "CURSO_READ", "9bce5a2e-1b18-45e7-adf4-91dede28fa3d" },
                    { 2, "POLICIES", "CURSO_WRITE", "9bce5a2e-1b18-45e7-adf4-91dede28fa3d" },
                    { 3, "POLICIES", "CURSO_UPDATE", "9bce5a2e-1b18-45e7-adf4-91dede28fa3d" },
                    { 4, "POLICIES", "CURSO_DELETE", "9bce5a2e-1b18-45e7-adf4-91dede28fa3d" },
                    { 5, "POLICIES", "INSTRUCTOR_CREATE", "9bce5a2e-1b18-45e7-adf4-91dede28fa3d" },
                    { 6, "POLICIES", "INSTRUCTOR_READ", "9bce5a2e-1b18-45e7-adf4-91dede28fa3d" },
                    { 7, "POLICIES", "INSTRUCTOR_UPDATE", "9bce5a2e-1b18-45e7-adf4-91dede28fa3d" },
                    { 8, "POLICIES", "COMENTARIO_READ", "9bce5a2e-1b18-45e7-adf4-91dede28fa3d" },
                    { 9, "POLICIES", "COMENTARIO_DELETE", "9bce5a2e-1b18-45e7-adf4-91dede28fa3d" },
                    { 10, "POLICIES", "COMENTARIO_CREATE", "9bce5a2e-1b18-45e7-adf4-91dede28fa3d" },
                    { 11, "POLICIES", "CURSO_READ", "251c7549-b0c9-48b5-9291-7e4f6aff7931" },
                    { 12, "POLICIES", "INSTRUCTOR_READ", "251c7549-b0c9-48b5-9291-7e4f6aff7931" },
                    { 13, "POLICIES", "COMENTARIO_READ", "251c7549-b0c9-48b5-9291-7e4f6aff7931" },
                    { 14, "POLICIES", "COMENTARIO_CREATE", "251c7549-b0c9-48b5-9291-7e4f6aff7931" }
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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("091fd643-8a73-4d3f-8e60-df8701f35da5"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("13ce05a8-e386-4c24-8987-58dcef664bf9"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("1e095bee-2bc0-4e99-bae6-9e1b35a5decb"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("a46ba943-ed9f-44ca-be72-1f2814a3c6d3"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("a8c3b709-0843-41f7-9cd4-370a4dd88118"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("ad4dcc53-f50e-4f1b-b69a-c8db469bc79c"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("ddbb3dc6-cd32-4b0c-9779-1bf49c6996c0"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("e09820cf-2784-49e7-9120-9e9a5f555b04"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("eccfc8bb-ca65-48c7-81fb-045c746b9ad1"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("5882c8ee-4837-4d35-8c1a-03d6d79e5901"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("7a4f6be7-8185-452a-baec-7ffc20915bc1"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("ae60729f-f366-4d0c-a014-bc47abd6d0f8"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("affa4c25-36c5-4e68-b267-7585dac41adc"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("b29e8654-818e-4ee7-a5e5-e01cbd9516e3"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("c5a9b150-6180-4dba-8242-915cadd0d6f6"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("d70e65da-d0bc-4b44-a313-07afd1c4d617"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("dcb0db52-7eb0-413b-a0e2-e6e28bed1a03"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("dd26ca77-0fb5-4b4b-9c40-ee88230b0587"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("e45c48f5-5650-4c43-ab90-d3363154bf94"));

            migrationBuilder.DeleteData(
                table: "precios",
                keyColumn: "Id",
                keyValue: new Guid("f653873e-9318-48a0-ab04-b8d25facc68f"));

            migrationBuilder.InsertData(
                table: "cursos",
                columns: new[] { "Id", "Descripcion", "FechaPublicacion", "Titulo" },
                values: new object[,]
                {
                    { new Guid("04136d71-7fc0-4dea-912b-57ecb156816f"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2025, 5, 27, 19, 36, 5, 944, DateTimeKind.Utc).AddTicks(8980), "Handcrafted Rubber Computer" },
                    { new Guid("6072610f-7cd2-4b3b-bae1-4b46d006da34"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new DateTime(2025, 5, 27, 19, 36, 5, 944, DateTimeKind.Utc).AddTicks(8960), "Handmade Rubber Computer" },
                    { new Guid("6d7947b5-9571-42ba-baa9-822ac7230823"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2025, 5, 27, 19, 36, 5, 944, DateTimeKind.Utc).AddTicks(9090), "Incredible Wooden Gloves" },
                    { new Guid("8791ac0d-8c65-4f3a-8712-dde0e24a8096"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2025, 5, 27, 19, 36, 5, 944, DateTimeKind.Utc).AddTicks(9070), "Intelligent Plastic Sausages" },
                    { new Guid("9f198e87-266c-4fa2-9401-d10781533e80"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2025, 5, 27, 19, 36, 5, 944, DateTimeKind.Utc).AddTicks(8900), "Incredible Frozen Table" },
                    { new Guid("b38eba8e-d006-4892-8606-4f6f2edf3dce"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2025, 5, 27, 19, 36, 5, 944, DateTimeKind.Utc).AddTicks(9100), "Incredible Wooden Ball" },
                    { new Guid("c6613ba9-9eb5-494d-9727-995ece9afef1"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2025, 5, 27, 19, 36, 5, 944, DateTimeKind.Utc).AddTicks(9030), "Handcrafted Steel Table" },
                    { new Guid("c8a22eab-0117-4dcb-ab21-6f965178a1c5"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2025, 5, 27, 19, 36, 5, 944, DateTimeKind.Utc).AddTicks(9050), "Handcrafted Soft Pants" },
                    { new Guid("f8a7a0b0-6390-4d4d-a99c-0fcaa30cbe5b"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2025, 5, 27, 19, 36, 5, 944, DateTimeKind.Utc).AddTicks(8940), "Unbranded Cotton Mouse" }
                });

            migrationBuilder.InsertData(
                table: "instructores",
                columns: new[] { "Id", "Apellidos", "Grado", "Nombre" },
                values: new object[,]
                {
                    { new Guid("144b234d-4704-4b79-ac5b-2180107b6b89"), "Weber", "Lead Solutions Administrator", "Nova" },
                    { new Guid("3880ba5c-80d0-4cb0-98a7-012ad2442475"), "Little", "Dynamic Mobility Orchestrator", "Jaron" },
                    { new Guid("38cca2bb-bb55-48b0-8e88-74b9a2572131"), "Daugherty", "International Configuration Coordinator", "Ronny" },
                    { new Guid("43badb03-7c6b-4fe7-8cee-a051d6a943f6"), "Cassin", "Senior Accountability Manager", "Savannah" },
                    { new Guid("5f64f1e3-e6eb-4f22-b8d4-2de4a0744081"), "Haag", "Internal Marketing Architect", "Vernice" },
                    { new Guid("8120f029-5074-434c-b094-97f86c7300c8"), "Rath", "Legacy Assurance Specialist", "Zachary" },
                    { new Guid("970223b0-afd4-4b56-9053-1ef77b4ed1eb"), "Flatley", "International Response Analyst", "Germaine" },
                    { new Guid("e365656b-6ef5-4894-ba60-b9ad380d20a9"), "Welch", "District Tactics Planner", "Keira" },
                    { new Guid("e717cee1-322d-4995-aa06-ac66d5eac4b8"), "Marks", "Human Division Representative", "Lauren" },
                    { new Guid("edae10f9-0c55-459f-b4b5-3dcf39697dc7"), "Halvorson", "Dynamic Functionality Liaison", "Elza" }
                });

            migrationBuilder.InsertData(
                table: "precios",
                columns: new[] { "Id", "Nombre", "PrecioActual", "PrecioPromocion" },
                values: new object[] { new Guid("af67c31c-d7c2-462d-b712-c1faae1dea64"), "Precio regular", 10.0m, 5.0m });
        }
    }
}
