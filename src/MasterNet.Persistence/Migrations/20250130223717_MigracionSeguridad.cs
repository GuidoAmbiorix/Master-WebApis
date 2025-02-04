using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MasterNet.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class MigracionSeguridad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("06150002-4d47-491c-99f8-6f8188daec74"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("0fa9fd44-5e41-4d89-b6b8-58543a0d796a"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("13f16e7c-af4d-45c2-8ca3-ab015fd378ce"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("2bbe5b2e-317d-4c4b-9163-454c23cda813"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("6f4ecc64-6833-42cf-bf90-9e60d847fcee"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("95aa8ce9-db70-4597-b488-95d1dc2f0db4"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("b185c9ed-3abf-4b89-9b69-9a0350656d20"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("c1951966-e6e7-440b-8529-8a3d0254b80f"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("e4aeeec6-afd0-475f-a955-8509d5db19bf"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("03bf5324-109d-41b3-8203-baf03c1547be"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("2ca477f1-4f72-444c-b8ef-5946ed7e72e2"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("30f882c3-730c-4acf-a7ba-523eb78c6443"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("3d102e5d-f9a8-48ee-9180-2e20cc16d0fd"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("3fd0fa6f-1031-412f-851a-02131817d139"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("65d32bdf-5067-4623-8b13-7bf3c0464dff"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("6b58542c-5378-4118-8531-47e5fd143423"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("b2a01f98-e4a4-4dc7-aae3-6cf4d172d4ac"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("b2b84d22-750a-4a2f-a1a2-36c114cca408"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("c4f4ae11-0037-4307-8939-f26410f3a49c"));

            migrationBuilder.DeleteData(
                table: "precios",
                keyColumn: "Id",
                keyValue: new Guid("986c0863-f264-42e7-b59d-e2e229d5582d"));

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
                    { "6de68f48-cda9-4e64-95f0-d8748b11f2c4", null, "ADMIN", "ADMIN" },
                    { "d5e912be-c4d6-4db9-924f-4fa395ec7bf8", null, "CLIENT", "CLIENT" }
                });

            migrationBuilder.InsertData(
                table: "cursos",
                columns: new[] { "Id", "Descripcion", "FechaPublicacion", "Titulo" },
                values: new object[,]
                {
                    { new Guid("25d38a2f-b098-4ad9-a9fe-b419d687e87a"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2025, 1, 30, 22, 37, 16, 889, DateTimeKind.Utc).AddTicks(7253), "Incredible Steel Shirt" },
                    { new Guid("2b5a94c0-62a8-4ac1-a30c-7a4b3d52c8a8"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2025, 1, 30, 22, 37, 16, 889, DateTimeKind.Utc).AddTicks(7290), "Rustic Soft Soap" },
                    { new Guid("2c3fbfe2-30bb-4898-afd4-adcb846a7880"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2025, 1, 30, 22, 37, 16, 889, DateTimeKind.Utc).AddTicks(7317), "Handcrafted Rubber Bacon" },
                    { new Guid("318e3eb2-db6d-4c28-a3f0-de9c88818aa0"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2025, 1, 30, 22, 37, 16, 889, DateTimeKind.Utc).AddTicks(7334), "Handcrafted Steel Shoes" },
                    { new Guid("43777e34-04f7-4e7f-97e6-e18f5309d01b"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2025, 1, 30, 22, 37, 16, 889, DateTimeKind.Utc).AddTicks(7281), "Intelligent Rubber Shoes" },
                    { new Guid("4d60003f-9765-4e2e-bfb4-21a0c0b72a5c"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2025, 1, 30, 22, 37, 16, 889, DateTimeKind.Utc).AddTicks(7268), "Rustic Frozen Gloves" },
                    { new Guid("7eb6ec6b-9f1f-4956-8e96-f97058f47850"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(2025, 1, 30, 22, 37, 16, 889, DateTimeKind.Utc).AddTicks(7326), "Intelligent Metal Computer" },
                    { new Guid("94611726-2d02-49e0-9a22-5b4d92c35b1d"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2025, 1, 30, 22, 37, 16, 889, DateTimeKind.Utc).AddTicks(7308), "Awesome Soft Chicken" },
                    { new Guid("a24c1eb0-217a-4feb-a4c6-7010e7ed05d4"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2025, 1, 30, 22, 37, 16, 889, DateTimeKind.Utc).AddTicks(7341), "Rustic Frozen Sausages" }
                });

            migrationBuilder.InsertData(
                table: "instructores",
                columns: new[] { "Id", "Apellidos", "Grado", "Nombre" },
                values: new object[,]
                {
                    { new Guid("3aec4189-12be-41f1-a775-5849c34eecd5"), "Johnston", "Global Factors Orchestrator", "Manuel" },
                    { new Guid("69dec9e6-10b7-480d-96f0-e320bc21c5ad"), "Reichel", "Central Factors Associate", "Percival" },
                    { new Guid("6f826310-ff45-47d8-bee1-e2b5e82cee3c"), "Schneider", "Regional Implementation Associate", "Casandra" },
                    { new Guid("7623e4b0-cb07-4504-8979-204d6a9f40c6"), "Stoltenberg", "Dynamic Directives Producer", "Maximilian" },
                    { new Guid("8635551b-6ebc-40a1-9cb7-b4e7f59f2a7e"), "Smitham", "Direct Division Liaison", "Patrick" },
                    { new Guid("8be6d24c-036c-4b86-98f1-7675371f780a"), "Stark", "International Response Analyst", "Trevor" },
                    { new Guid("b08e58f7-9e7b-47c9-819c-c5f1715e69a9"), "Stanton", "Product Configuration Director", "Bernice" },
                    { new Guid("b289ab76-fe39-4f2a-9f43-316be148c271"), "Wiza", "Dynamic Group Architect", "Nikolas" },
                    { new Guid("c6af47d5-5b3a-4051-9f6b-179f6ae81017"), "Dach", "Internal Creative Consultant", "Adrien" },
                    { new Guid("d637e01a-f47b-4598-a8da-1dd5c7623f65"), "Bartoletti", "Legacy Interactions Analyst", "Blaise" }
                });

            migrationBuilder.InsertData(
                table: "precios",
                columns: new[] { "Id", "Nombre", "PrecioActual", "PrecioPromocion" },
                values: new object[] { new Guid("0ed4c92e-c522-4cd0-b037-64c1d64ce2b7"), "Precio Regular", 10.0m, 8.0m });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 1, "POLICIES", "CURSO_READ", "6de68f48-cda9-4e64-95f0-d8748b11f2c4" },
                    { 2, "POLICIES", "CURSO_UPDATE", "6de68f48-cda9-4e64-95f0-d8748b11f2c4" },
                    { 3, "POLICIES", "CURSO_WRITE", "6de68f48-cda9-4e64-95f0-d8748b11f2c4" },
                    { 4, "POLICIES", "CURSO_DELETE", "6de68f48-cda9-4e64-95f0-d8748b11f2c4" },
                    { 5, "POLICIES", "INSTRUCTOR_CREATE", "6de68f48-cda9-4e64-95f0-d8748b11f2c4" },
                    { 6, "POLICIES", "INSTRUCTOR_READ", "6de68f48-cda9-4e64-95f0-d8748b11f2c4" },
                    { 7, "POLICIES", "INSTRUCTOR_UPDATE", "6de68f48-cda9-4e64-95f0-d8748b11f2c4" },
                    { 8, "POLICIES", "COMENTARIO_READ", "6de68f48-cda9-4e64-95f0-d8748b11f2c4" },
                    { 9, "POLICIES", "COMENTARIO_DELETE", "6de68f48-cda9-4e64-95f0-d8748b11f2c4" },
                    { 10, "POLICIES", "COMENTARIO_CREATE", "6de68f48-cda9-4e64-95f0-d8748b11f2c4" },
                    { 11, "POLICIES", "CURSO_READ", "d5e912be-c4d6-4db9-924f-4fa395ec7bf8" },
                    { 12, "POLICIES", "INSTRUCTOR_READ", "d5e912be-c4d6-4db9-924f-4fa395ec7bf8" },
                    { 13, "POLICIES", "COMENTARIO_READ", "d5e912be-c4d6-4db9-924f-4fa395ec7bf8" },
                    { 14, "POLICIES", "COMENTARIO_CREATE", "d5e912be-c4d6-4db9-924f-4fa395ec7bf8" }
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
                keyValue: new Guid("25d38a2f-b098-4ad9-a9fe-b419d687e87a"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("2b5a94c0-62a8-4ac1-a30c-7a4b3d52c8a8"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("2c3fbfe2-30bb-4898-afd4-adcb846a7880"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("318e3eb2-db6d-4c28-a3f0-de9c88818aa0"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("43777e34-04f7-4e7f-97e6-e18f5309d01b"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("4d60003f-9765-4e2e-bfb4-21a0c0b72a5c"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("7eb6ec6b-9f1f-4956-8e96-f97058f47850"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("94611726-2d02-49e0-9a22-5b4d92c35b1d"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("a24c1eb0-217a-4feb-a4c6-7010e7ed05d4"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("3aec4189-12be-41f1-a775-5849c34eecd5"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("69dec9e6-10b7-480d-96f0-e320bc21c5ad"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("6f826310-ff45-47d8-bee1-e2b5e82cee3c"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("7623e4b0-cb07-4504-8979-204d6a9f40c6"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("8635551b-6ebc-40a1-9cb7-b4e7f59f2a7e"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("8be6d24c-036c-4b86-98f1-7675371f780a"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("b08e58f7-9e7b-47c9-819c-c5f1715e69a9"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("b289ab76-fe39-4f2a-9f43-316be148c271"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("c6af47d5-5b3a-4051-9f6b-179f6ae81017"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("d637e01a-f47b-4598-a8da-1dd5c7623f65"));

            migrationBuilder.DeleteData(
                table: "precios",
                keyColumn: "Id",
                keyValue: new Guid("0ed4c92e-c522-4cd0-b037-64c1d64ce2b7"));

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
        }
    }
}
