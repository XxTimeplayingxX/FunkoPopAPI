using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FunkoPopAPI.Migrations
{
    /// <inheritdoc />
    public partial class PrimeraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Franquicias",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Franquicias", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FunkoPops",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FunkoPops", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FunkoPopFranquicia",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FunkoPopID = table.Column<int>(type: "int", nullable: false),
                    FranquiciaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FunkoPopFranquicia", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FunkoPopFranquicia_Franquicias_FranquiciaID",
                        column: x => x.FranquiciaID,
                        principalTable: "Franquicias",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FunkoPopFranquicia_FunkoPops_FunkoPopID",
                        column: x => x.FunkoPopID,
                        principalTable: "FunkoPops",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FranquiciaGenero",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FranquiciaID = table.Column<int>(type: "int", nullable: false),
                    GeneroID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FranquiciaGenero", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FranquiciaGenero_Franquicias_FranquiciaID",
                        column: x => x.FranquiciaID,
                        principalTable: "Franquicias",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FranquiciaGenero_Genero_GeneroID",
                        column: x => x.GeneroID,
                        principalTable: "Genero",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Franquicias",
                columns: new[] { "ID", "Nombre" },
                values: new object[,]
                {
                    { 1, "Marvel" },
                    { 2, "Back to the Future" }
                });

            migrationBuilder.InsertData(
                table: "FunkoPops",
                columns: new[] { "ID", "Descripcion", "Nombre" },
                values: new object[,]
                {
                    { 1, "Proveniente de Infinity War", "Thanos" },
                    { 2, "Proveniente de Back to the future", "Marty McFly" }
                });

            migrationBuilder.InsertData(
                table: "Genero",
                columns: new[] { "ID", "Descripcion" },
                values: new object[,]
                {
                    { 1, "Acción" },
                    { 2, "Fantasía" }
                });

            migrationBuilder.InsertData(
                table: "FranquiciaGenero",
                columns: new[] { "ID", "FranquiciaID", "GeneroID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "FunkoPopFranquicia",
                columns: new[] { "ID", "FranquiciaID", "FunkoPopID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FranquiciaGenero_FranquiciaID",
                table: "FranquiciaGenero",
                column: "FranquiciaID");

            migrationBuilder.CreateIndex(
                name: "IX_FranquiciaGenero_GeneroID",
                table: "FranquiciaGenero",
                column: "GeneroID");

            migrationBuilder.CreateIndex(
                name: "IX_FunkoPopFranquicia_FranquiciaID",
                table: "FunkoPopFranquicia",
                column: "FranquiciaID");

            migrationBuilder.CreateIndex(
                name: "IX_FunkoPopFranquicia_FunkoPopID",
                table: "FunkoPopFranquicia",
                column: "FunkoPopID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FranquiciaGenero");

            migrationBuilder.DropTable(
                name: "FunkoPopFranquicia");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "Franquicias");

            migrationBuilder.DropTable(
                name: "FunkoPops");
        }
    }
}
