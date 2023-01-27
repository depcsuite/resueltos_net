using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TiendaLibros.Migrations
{
    public partial class SeedingInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LibroDetalles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Genero = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Resumen = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValue: ""),
                    ResumenLink = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValue: ""),
                    Editorial = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: ""),
                    Edicion = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Formato = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    FechaPublicacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibroDetalles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: ""),
                    Ranking = table.Column<int>(type: "int", nullable: true),
                    Titulo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValue: ""),
                    Autor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValue: "0"),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    PortadaUri = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: ""),
                    DetallesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Libros_LibroDetalles_DetallesId",
                        column: x => x.DetallesId,
                        principalTable: "LibroDetalles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "LibroDetalles",
                columns: new[] { "Id", "FechaPublicacion", "Genero", "Resumen" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Es de huido abeja lentejas de la pero carcajadas me hule luna comida se para la pero llenando" },
                    { 2, new DateTime(1900, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Menedékünk ölel kicifrázva ríjjátok rázza gyalázat míg ríjjátok égjen nem és meg mint de bukjatok " },
                    { 3, new DateTime(2020, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Éclairs fileur sillage d'europe plein qu'on la montait fleurs atroce est-ce bleu courais" },
                    { 4, new DateTime(1985, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Clita magna rebum euismod aliquam eos aliquip ea nostrud kasd duis justo labore ea dolore " },
                    { 5, new DateTime(2022, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Neu es schöne faßt dunst einst froher trüben mein klage tränen zu zu die und folgenden der " }
                });

            migrationBuilder.InsertData(
                table: "Libros",
                columns: new[] { "Id", "Autor", "DetallesId", "ISBN", "PortadaUri", "Precio", "Ranking", "Titulo" },
                values: new object[,]
                {
                    { -5, "Ludovica Skuir", 5, "104", "104.png", 1000m, 2, "Predicciones 2023" },
                    { -4, "Garcia Belsunse ", 4, "103", "103.png", 5300m, 8, "La guerra de la triple alianza" },
                    { -3, "Mario Quintero", 3, "102", "102.png", 2800m, 3, "Como ganar tu primer Millon" },
                    { -2, "Kafka", 2, "101", "101.png", 3300m, 9, "La metaforfosis" },
                    { -1, "Garcia Marquez", 1, "100", "100.png", 2300m, 9, "100 años de Soledad" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Libros_DetallesId",
                table: "Libros",
                column: "DetallesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Libros");

            migrationBuilder.DropTable(
                name: "LibroDetalles");
        }
    }
}
