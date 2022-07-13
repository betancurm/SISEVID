using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SISEVID.Migrations
{
    public partial class CorrecionTablaAsignaturas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asignaturas_Asignaturas_AsignaturaId",
                table: "Asignaturas");

            migrationBuilder.DropIndex(
                name: "IX_Asignaturas_AsignaturaId",
                table: "Asignaturas");

            migrationBuilder.DropColumn(
                name: "AsignaturaId",
                table: "Asignaturas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AsignaturaId",
                table: "Asignaturas",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Asignaturas_AsignaturaId",
                table: "Asignaturas",
                column: "AsignaturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asignaturas_Asignaturas_AsignaturaId",
                table: "Asignaturas",
                column: "AsignaturaId",
                principalTable: "Asignaturas",
                principalColumn: "Id");
        }
    }
}
