using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace USLabs.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cursos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Titulo = table.Column<string>(type: "TEXT", nullable: true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    FechaPublicacion = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "instructores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Apellidos = table.Column<string>(type: "TEXT", nullable: true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Grado = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instructores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "precios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "varchar", maxLength: 100, nullable: true),
                    PrecioActual = table.Column<decimal>(type: "TEXT", precision: 10, scale: 2, nullable: false),
                    PrecioPromocion = table.Column<decimal>(type: "TEXT", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_precios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "calificaciones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Alumno = table.Column<string>(type: "TEXT", nullable: true),
                    Puntaje = table.Column<int>(type: "INTEGER", nullable: false),
                    Comentario = table.Column<string>(type: "TEXT", nullable: true),
                    CursoId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_calificaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_calificaciones_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "imagenes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    CursoId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imagenes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_imagenes_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "curso_instructores",
                columns: table => new
                {
                    CursoId = table.Column<Guid>(type: "TEXT", nullable: false),
                    InstructorId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_curso_instructores", x => new { x.InstructorId, x.CursoId });
                    table.ForeignKey(
                        name: "FK_curso_instructores_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_curso_instructores_instructores_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "instructores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "curso_precios",
                columns: table => new
                {
                    CursoId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PrecioId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_curso_precios", x => new { x.PrecioId, x.CursoId });
                    table.ForeignKey(
                        name: "FK_curso_precios_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_curso_precios_precios_PrecioId",
                        column: x => x.PrecioId,
                        principalTable: "precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_calificaciones_CursoId",
                table: "calificaciones",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_curso_instructores_CursoId",
                table: "curso_instructores",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_curso_precios_CursoId",
                table: "curso_precios",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_imagenes_CursoId",
                table: "imagenes",
                column: "CursoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "calificaciones");

            migrationBuilder.DropTable(
                name: "curso_instructores");

            migrationBuilder.DropTable(
                name: "curso_precios");

            migrationBuilder.DropTable(
                name: "imagenes");

            migrationBuilder.DropTable(
                name: "instructores");

            migrationBuilder.DropTable(
                name: "precios");

            migrationBuilder.DropTable(
                name: "cursos");
        }
    }
}
