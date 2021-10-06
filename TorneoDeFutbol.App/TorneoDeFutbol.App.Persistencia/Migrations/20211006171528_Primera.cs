using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TorneoDeFutbol.App.Persistencia.Migrations
{
    public partial class Primera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participantes_Participantes_Arbitro_participanteidParticipante",
                table: "Participantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Participantes_Participantes_Director_Tecnico_participanteidParticipante",
                table: "Participantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Participantes_Participantes_participanteidParticipante",
                table: "Participantes");

            migrationBuilder.DropIndex(
                name: "IX_Participantes_Arbitro_participanteidParticipante",
                table: "Participantes");

            migrationBuilder.DropIndex(
                name: "IX_Participantes_Director_Tecnico_participanteidParticipante",
                table: "Participantes");

            migrationBuilder.DropIndex(
                name: "IX_Participantes_participanteidParticipante",
                table: "Participantes");

            migrationBuilder.DropColumn(
                name: "Arbitro_participanteidParticipante",
                table: "Participantes");

            migrationBuilder.DropColumn(
                name: "Director_Tecnico_participanteidParticipante",
                table: "Participantes");

            migrationBuilder.DropColumn(
                name: "idArbitro",
                table: "Participantes");

            migrationBuilder.DropColumn(
                name: "participanteidParticipante",
                table: "Participantes");

            migrationBuilder.AlterColumn<int>(
                name: "posicion",
                table: "Participantes",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaNacimiento",
                table: "Participantes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "genero",
                table: "Participantes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fechaNacimiento",
                table: "Participantes");

            migrationBuilder.DropColumn(
                name: "genero",
                table: "Participantes");

            migrationBuilder.AlterColumn<string>(
                name: "posicion",
                table: "Participantes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Arbitro_participanteidParticipante",
                table: "Participantes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Director_Tecnico_participanteidParticipante",
                table: "Participantes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idArbitro",
                table: "Participantes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "participanteidParticipante",
                table: "Participantes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Participantes_Arbitro_participanteidParticipante",
                table: "Participantes",
                column: "Arbitro_participanteidParticipante");

            migrationBuilder.CreateIndex(
                name: "IX_Participantes_Director_Tecnico_participanteidParticipante",
                table: "Participantes",
                column: "Director_Tecnico_participanteidParticipante");

            migrationBuilder.CreateIndex(
                name: "IX_Participantes_participanteidParticipante",
                table: "Participantes",
                column: "participanteidParticipante");

            migrationBuilder.AddForeignKey(
                name: "FK_Participantes_Participantes_Arbitro_participanteidParticipante",
                table: "Participantes",
                column: "Arbitro_participanteidParticipante",
                principalTable: "Participantes",
                principalColumn: "idParticipante",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Participantes_Participantes_Director_Tecnico_participanteidParticipante",
                table: "Participantes",
                column: "Director_Tecnico_participanteidParticipante",
                principalTable: "Participantes",
                principalColumn: "idParticipante",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Participantes_Participantes_participanteidParticipante",
                table: "Participantes",
                column: "participanteidParticipante",
                principalTable: "Participantes",
                principalColumn: "idParticipante",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
