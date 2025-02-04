using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MasterNet.Persistence.Migrations
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
                    Nombre = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
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
                    CursoId = table.Column<Guid>(type: "TEXT", nullable: true)
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
                name: "cursos_instructores",
                columns: table => new
                {
                    CursoId = table.Column<Guid>(type: "TEXT", nullable: false),
                    InstructorId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cursos_instructores", x => new { x.InstructorId, x.CursoId });
                    table.ForeignKey(
                        name: "FK_cursos_instructores_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cursos_instructores_instructores_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "instructores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cursos_precios",
                columns: table => new
                {
                    CursoId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PrecioId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cursos_precios", x => new { x.PrecioId, x.CursoId });
                    table.ForeignKey(
                        name: "FK_cursos_precios_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cursos_precios_precios_PrecioId",
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
                    { new Guid("06150002-4d47-491c-99f8-6f8188daec74"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2025, 1, 25, 19, 11, 7, 157, DateTimeKind.Utc).AddTicks(4793), "Gorgeous Plastic Mouse" },
                    { new Guid("0fa9fd44-5e41-4d89-b6b8-58543a0d796a"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2025, 1, 25, 19, 11, 7, 157, DateTimeKind.Utc).AddTicks(4753), "Refined Frozen Ball" },
                    { new Guid("13f16e7c-af4d-45c2-8ca3-ab015fd378ce"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2025, 1, 25, 19, 11, 7, 157, DateTimeKind.Utc).AddTicks(4817), "Handmade Frozen Tuna" },
                    { new Guid("2bbe5b2e-317d-4c4b-9163-454c23cda813"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new DateTime(2025, 1, 25, 19, 11, 7, 157, DateTimeKind.Utc).AddTicks(4801), "Rustic Metal Cheese" },
                    { new Guid("6f4ecc64-6833-42cf-bf90-9e60d847fcee"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2025, 1, 25, 19, 11, 7, 157, DateTimeKind.Utc).AddTicks(4809), "Sleek Metal Chicken" },
                    { new Guid("95aa8ce9-db70-4597-b488-95d1dc2f0db4"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2025, 1, 25, 19, 11, 7, 157, DateTimeKind.Utc).AddTicks(4783), "Incredible Granite Bacon" },
                    { new Guid("b185c9ed-3abf-4b89-9b69-9a0350656d20"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2025, 1, 25, 19, 11, 7, 157, DateTimeKind.Utc).AddTicks(4842), "Practical Rubber Chair" },
                    { new Guid("c1951966-e6e7-440b-8529-8a3d0254b80f"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2025, 1, 25, 19, 11, 7, 157, DateTimeKind.Utc).AddTicks(4834), "Generic Granite Pizza" },
                    { new Guid("e4aeeec6-afd0-475f-a955-8509d5db19bf"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2025, 1, 25, 19, 11, 7, 157, DateTimeKind.Utc).AddTicks(4767), "Fantastic Frozen Salad" }
                });

            migrationBuilder.InsertData(
                table: "instructores",
                columns: new[] { "Id", "Apellidos", "Grado", "Nombre" },
                values: new object[,]
                {
                    { new Guid("03bf5324-109d-41b3-8203-baf03c1547be"), "Weber", "Legacy Assurance Coordinator", "Gilberto" },
                    { new Guid("2ca477f1-4f72-444c-b8ef-5946ed7e72e2"), "Bradtke", "Regional Program Associate", "Milton" },
                    { new Guid("30f882c3-730c-4acf-a7ba-523eb78c6443"), "Christiansen", "Investor Factors Supervisor", "William" },
                    { new Guid("3d102e5d-f9a8-48ee-9180-2e20cc16d0fd"), "Kuhlman", "Principal Interactions Specialist", "Augusta" },
                    { new Guid("3fd0fa6f-1031-412f-851a-02131817d139"), "Okuneva", "National Response Consultant", "Mertie" },
                    { new Guid("65d32bdf-5067-4623-8b13-7bf3c0464dff"), "Wiza", "Dynamic Program Analyst", "Giles" },
                    { new Guid("6b58542c-5378-4118-8531-47e5fd143423"), "Dietrich", "Principal Paradigm Supervisor", "Stuart" },
                    { new Guid("b2a01f98-e4a4-4dc7-aae3-6cf4d172d4ac"), "Sanford", "Global Metrics Manager", "Ron" },
                    { new Guid("b2b84d22-750a-4a2f-a1a2-36c114cca408"), "Hamill", "Legacy Configuration Assistant", "Chelsea" },
                    { new Guid("c4f4ae11-0037-4307-8939-f26410f3a49c"), "Heidenreich", "Product Optimization Manager", "Dayne" }
                });

            migrationBuilder.InsertData(
                table: "precios",
                columns: new[] { "Id", "Nombre", "PrecioActual", "PrecioPromocion" },
                values: new object[] { new Guid("986c0863-f264-42e7-b59d-e2e229d5582d"), "Precio Regular", 10.0m, 8.0m });

            migrationBuilder.CreateIndex(
                name: "IX_calificaciones_CursoId",
                table: "calificaciones",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_cursos_instructores_CursoId",
                table: "cursos_instructores",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_cursos_precios_CursoId",
                table: "cursos_precios",
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
                name: "cursos_instructores");

            migrationBuilder.DropTable(
                name: "cursos_precios");

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
