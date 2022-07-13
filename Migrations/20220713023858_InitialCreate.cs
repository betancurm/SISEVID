using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SISEVID.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Universidad",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universidad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sede",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Departamento = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Municipio = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    UniversidadId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sede", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sede_Universidad_UniversidadId",
                        column: x => x.UniversidadId,
                        principalTable: "Universidad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Facultad",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    SedeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facultad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Facultad_Sede_SedeId",
                        column: x => x.SedeId,
                        principalTable: "Sede",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Programa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Modalidad = table.Column<int>(type: "int", maxLength: 150, nullable: false),
                    Duracion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    TituloOtorgado = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Pensum = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacultadId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Programa_Facultad_FacultadId",
                        column: x => x.FacultadId,
                        principalTable: "Facultad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Condicion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProgramaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condicion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Condicion_Programa_ProgramaId",
                        column: x => x.ProgramaId,
                        principalTable: "Programa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articulo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CondicionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articulo_Condicion_CondicionId",
                        column: x => x.CondicionId,
                        principalTable: "Condicion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Literal",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Letra = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArticuloId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Literal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Literal_Articulo_ArticuloId",
                        column: x => x.ArticuloId,
                        principalTable: "Articulo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Numeral",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LiteralId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Numeral", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Numeral_Literal_LiteralId",
                        column: x => x.LiteralId,
                        principalTable: "Literal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articulo_CondicionId",
                table: "Articulo",
                column: "CondicionId");

            migrationBuilder.CreateIndex(
                name: "IX_Condicion_ProgramaId",
                table: "Condicion",
                column: "ProgramaId");

            migrationBuilder.CreateIndex(
                name: "IX_Facultad_Email",
                table: "Facultad",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Facultad_Nombre",
                table: "Facultad",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Facultad_SedeId",
                table: "Facultad",
                column: "SedeId");

            migrationBuilder.CreateIndex(
                name: "IX_Facultad_Telefono",
                table: "Facultad",
                column: "Telefono",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Literal_ArticuloId",
                table: "Literal",
                column: "ArticuloId");

            migrationBuilder.CreateIndex(
                name: "IX_Numeral_LiteralId",
                table: "Numeral",
                column: "LiteralId");

            migrationBuilder.CreateIndex(
                name: "IX_Programa_Email",
                table: "Programa",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Programa_FacultadId",
                table: "Programa",
                column: "FacultadId");

            migrationBuilder.CreateIndex(
                name: "IX_Programa_Nombre",
                table: "Programa",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Programa_Telefono",
                table: "Programa",
                column: "Telefono",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sede_Direccion",
                table: "Sede",
                column: "Direccion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sede_Nombre",
                table: "Sede",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sede_Telefono",
                table: "Sede",
                column: "Telefono",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sede_UniversidadId",
                table: "Sede",
                column: "UniversidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Universidad_Nombre",
                table: "Universidad",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Universidad_Telefono",
                table: "Universidad",
                column: "Telefono",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Numeral");

            migrationBuilder.DropTable(
                name: "Literal");

            migrationBuilder.DropTable(
                name: "Articulo");

            migrationBuilder.DropTable(
                name: "Condicion");

            migrationBuilder.DropTable(
                name: "Programa");

            migrationBuilder.DropTable(
                name: "Facultad");

            migrationBuilder.DropTable(
                name: "Sede");

            migrationBuilder.DropTable(
                name: "Universidad");
        }
    }
}
