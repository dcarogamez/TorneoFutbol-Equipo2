using Microsoft.EntityFrameworkCore.Migrations;

namespace TorneoDeFutbol.App.Persistencia.Migrations
{
    public partial class ModifEntidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DatosPartidos_Equipos_equipoId",
                table: "DatosPartidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Municipios_municipioId",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Participantes_directorTecnicoId",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Participantes_jugadorId",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Estadios_Municipios_municipioId",
                table: "Estadios");

            migrationBuilder.DropForeignKey(
                name: "FK_Participantes_Colegios_colegioId",
                table: "Participantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Participantes_Participantes_Arbitro_participanteId",
                table: "Participantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Participantes_Participantes_Director_Tecnico_participanteId",
                table: "Participantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Participantes_Participantes_participanteId",
                table: "Participantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_Equipos_equipoId",
                table: "Partidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_Estadios_estadioId",
                table: "Partidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_Participantes_arbitroId",
                table: "Partidos");

            migrationBuilder.RenameColumn(
                name: "estadioId",
                table: "Partidos",
                newName: "estadioId_Estadio");

            migrationBuilder.RenameColumn(
                name: "equipoId",
                table: "Partidos",
                newName: "equipoId_Equipo");

            migrationBuilder.RenameColumn(
                name: "arbitroId",
                table: "Partidos",
                newName: "arbitroId_Participante");

            migrationBuilder.RenameIndex(
                name: "IX_Partidos_estadioId",
                table: "Partidos",
                newName: "IX_Partidos_estadioId_Estadio");

            migrationBuilder.RenameIndex(
                name: "IX_Partidos_equipoId",
                table: "Partidos",
                newName: "IX_Partidos_equipoId_Equipo");

            migrationBuilder.RenameIndex(
                name: "IX_Partidos_arbitroId",
                table: "Partidos",
                newName: "IX_Partidos_arbitroId_Participante");

            migrationBuilder.RenameColumn(
                name: "participanteId",
                table: "Participantes",
                newName: "participanteId_Participante");

            migrationBuilder.RenameColumn(
                name: "colegioId",
                table: "Participantes",
                newName: "colegioId_Colegio");

            migrationBuilder.RenameColumn(
                name: "Director_Tecnico_participanteId",
                table: "Participantes",
                newName: "Director_Tecnico_participanteId_Participante");

            migrationBuilder.RenameColumn(
                name: "Arbitro_participanteId",
                table: "Participantes",
                newName: "Arbitro_participanteId_Participante");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Participantes",
                newName: "Id_Participante");

            migrationBuilder.RenameIndex(
                name: "IX_Participantes_participanteId",
                table: "Participantes",
                newName: "IX_Participantes_participanteId_Participante");

            migrationBuilder.RenameIndex(
                name: "IX_Participantes_Director_Tecnico_participanteId",
                table: "Participantes",
                newName: "IX_Participantes_Director_Tecnico_participanteId_Participante");

            migrationBuilder.RenameIndex(
                name: "IX_Participantes_colegioId",
                table: "Participantes",
                newName: "IX_Participantes_colegioId_Colegio");

            migrationBuilder.RenameIndex(
                name: "IX_Participantes_Arbitro_participanteId",
                table: "Participantes",
                newName: "IX_Participantes_Arbitro_participanteId_Participante");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Municipios",
                newName: "Id_Municipio");

            migrationBuilder.RenameColumn(
                name: "municipioId",
                table: "Estadios",
                newName: "municipioId_Municipio");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Estadios",
                newName: "Id_Estadio");

            migrationBuilder.RenameIndex(
                name: "IX_Estadios_municipioId",
                table: "Estadios",
                newName: "IX_Estadios_municipioId_Municipio");

            migrationBuilder.RenameColumn(
                name: "municipioId",
                table: "Equipos",
                newName: "municipioId_Municipio");

            migrationBuilder.RenameColumn(
                name: "jugadorId",
                table: "Equipos",
                newName: "jugadorId_Participante");

            migrationBuilder.RenameColumn(
                name: "directorTecnicoId",
                table: "Equipos",
                newName: "directorTecnicoId_Participante");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Equipos",
                newName: "Id_Equipo");

            migrationBuilder.RenameIndex(
                name: "IX_Equipos_municipioId",
                table: "Equipos",
                newName: "IX_Equipos_municipioId_Municipio");

            migrationBuilder.RenameIndex(
                name: "IX_Equipos_jugadorId",
                table: "Equipos",
                newName: "IX_Equipos_jugadorId_Participante");

            migrationBuilder.RenameIndex(
                name: "IX_Equipos_directorTecnicoId",
                table: "Equipos",
                newName: "IX_Equipos_directorTecnicoId_Participante");

            migrationBuilder.RenameColumn(
                name: "equipoId",
                table: "DatosPartidos",
                newName: "equipoId_Equipo");

            migrationBuilder.RenameIndex(
                name: "IX_DatosPartidos_equipoId",
                table: "DatosPartidos",
                newName: "IX_DatosPartidos_equipoId_Equipo");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Colegios",
                newName: "Id_Colegio");

            migrationBuilder.AddForeignKey(
                name: "FK_DatosPartidos_Equipos_equipoId_Equipo",
                table: "DatosPartidos",
                column: "equipoId_Equipo",
                principalTable: "Equipos",
                principalColumn: "Id_Equipo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Municipios_municipioId_Municipio",
                table: "Equipos",
                column: "municipioId_Municipio",
                principalTable: "Municipios",
                principalColumn: "Id_Municipio",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Participantes_directorTecnicoId_Participante",
                table: "Equipos",
                column: "directorTecnicoId_Participante",
                principalTable: "Participantes",
                principalColumn: "Id_Participante",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Participantes_jugadorId_Participante",
                table: "Equipos",
                column: "jugadorId_Participante",
                principalTable: "Participantes",
                principalColumn: "Id_Participante",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estadios_Municipios_municipioId_Municipio",
                table: "Estadios",
                column: "municipioId_Municipio",
                principalTable: "Municipios",
                principalColumn: "Id_Municipio",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Participantes_Colegios_colegioId_Colegio",
                table: "Participantes",
                column: "colegioId_Colegio",
                principalTable: "Colegios",
                principalColumn: "Id_Colegio",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Participantes_Participantes_Arbitro_participanteId_Participante",
                table: "Participantes",
                column: "Arbitro_participanteId_Participante",
                principalTable: "Participantes",
                principalColumn: "Id_Participante",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Participantes_Participantes_Director_Tecnico_participanteId_Participante",
                table: "Participantes",
                column: "Director_Tecnico_participanteId_Participante",
                principalTable: "Participantes",
                principalColumn: "Id_Participante",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Participantes_Participantes_participanteId_Participante",
                table: "Participantes",
                column: "participanteId_Participante",
                principalTable: "Participantes",
                principalColumn: "Id_Participante",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Partidos_Equipos_equipoId_Equipo",
                table: "Partidos",
                column: "equipoId_Equipo",
                principalTable: "Equipos",
                principalColumn: "Id_Equipo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Partidos_Estadios_estadioId_Estadio",
                table: "Partidos",
                column: "estadioId_Estadio",
                principalTable: "Estadios",
                principalColumn: "Id_Estadio",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Partidos_Participantes_arbitroId_Participante",
                table: "Partidos",
                column: "arbitroId_Participante",
                principalTable: "Participantes",
                principalColumn: "Id_Participante",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DatosPartidos_Equipos_equipoId_Equipo",
                table: "DatosPartidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Municipios_municipioId_Municipio",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Participantes_directorTecnicoId_Participante",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Participantes_jugadorId_Participante",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Estadios_Municipios_municipioId_Municipio",
                table: "Estadios");

            migrationBuilder.DropForeignKey(
                name: "FK_Participantes_Colegios_colegioId_Colegio",
                table: "Participantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Participantes_Participantes_Arbitro_participanteId_Participante",
                table: "Participantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Participantes_Participantes_Director_Tecnico_participanteId_Participante",
                table: "Participantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Participantes_Participantes_participanteId_Participante",
                table: "Participantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_Equipos_equipoId_Equipo",
                table: "Partidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_Estadios_estadioId_Estadio",
                table: "Partidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_Participantes_arbitroId_Participante",
                table: "Partidos");

            migrationBuilder.RenameColumn(
                name: "estadioId_Estadio",
                table: "Partidos",
                newName: "estadioId");

            migrationBuilder.RenameColumn(
                name: "equipoId_Equipo",
                table: "Partidos",
                newName: "equipoId");

            migrationBuilder.RenameColumn(
                name: "arbitroId_Participante",
                table: "Partidos",
                newName: "arbitroId");

            migrationBuilder.RenameIndex(
                name: "IX_Partidos_estadioId_Estadio",
                table: "Partidos",
                newName: "IX_Partidos_estadioId");

            migrationBuilder.RenameIndex(
                name: "IX_Partidos_equipoId_Equipo",
                table: "Partidos",
                newName: "IX_Partidos_equipoId");

            migrationBuilder.RenameIndex(
                name: "IX_Partidos_arbitroId_Participante",
                table: "Partidos",
                newName: "IX_Partidos_arbitroId");

            migrationBuilder.RenameColumn(
                name: "participanteId_Participante",
                table: "Participantes",
                newName: "participanteId");

            migrationBuilder.RenameColumn(
                name: "colegioId_Colegio",
                table: "Participantes",
                newName: "colegioId");

            migrationBuilder.RenameColumn(
                name: "Director_Tecnico_participanteId_Participante",
                table: "Participantes",
                newName: "Director_Tecnico_participanteId");

            migrationBuilder.RenameColumn(
                name: "Arbitro_participanteId_Participante",
                table: "Participantes",
                newName: "Arbitro_participanteId");

            migrationBuilder.RenameColumn(
                name: "Id_Participante",
                table: "Participantes",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Participantes_participanteId_Participante",
                table: "Participantes",
                newName: "IX_Participantes_participanteId");

            migrationBuilder.RenameIndex(
                name: "IX_Participantes_Director_Tecnico_participanteId_Participante",
                table: "Participantes",
                newName: "IX_Participantes_Director_Tecnico_participanteId");

            migrationBuilder.RenameIndex(
                name: "IX_Participantes_colegioId_Colegio",
                table: "Participantes",
                newName: "IX_Participantes_colegioId");

            migrationBuilder.RenameIndex(
                name: "IX_Participantes_Arbitro_participanteId_Participante",
                table: "Participantes",
                newName: "IX_Participantes_Arbitro_participanteId");

            migrationBuilder.RenameColumn(
                name: "Id_Municipio",
                table: "Municipios",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "municipioId_Municipio",
                table: "Estadios",
                newName: "municipioId");

            migrationBuilder.RenameColumn(
                name: "Id_Estadio",
                table: "Estadios",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Estadios_municipioId_Municipio",
                table: "Estadios",
                newName: "IX_Estadios_municipioId");

            migrationBuilder.RenameColumn(
                name: "municipioId_Municipio",
                table: "Equipos",
                newName: "municipioId");

            migrationBuilder.RenameColumn(
                name: "jugadorId_Participante",
                table: "Equipos",
                newName: "jugadorId");

            migrationBuilder.RenameColumn(
                name: "directorTecnicoId_Participante",
                table: "Equipos",
                newName: "directorTecnicoId");

            migrationBuilder.RenameColumn(
                name: "Id_Equipo",
                table: "Equipos",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Equipos_municipioId_Municipio",
                table: "Equipos",
                newName: "IX_Equipos_municipioId");

            migrationBuilder.RenameIndex(
                name: "IX_Equipos_jugadorId_Participante",
                table: "Equipos",
                newName: "IX_Equipos_jugadorId");

            migrationBuilder.RenameIndex(
                name: "IX_Equipos_directorTecnicoId_Participante",
                table: "Equipos",
                newName: "IX_Equipos_directorTecnicoId");

            migrationBuilder.RenameColumn(
                name: "equipoId_Equipo",
                table: "DatosPartidos",
                newName: "equipoId");

            migrationBuilder.RenameIndex(
                name: "IX_DatosPartidos_equipoId_Equipo",
                table: "DatosPartidos",
                newName: "IX_DatosPartidos_equipoId");

            migrationBuilder.RenameColumn(
                name: "Id_Colegio",
                table: "Colegios",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DatosPartidos_Equipos_equipoId",
                table: "DatosPartidos",
                column: "equipoId",
                principalTable: "Equipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Municipios_municipioId",
                table: "Equipos",
                column: "municipioId",
                principalTable: "Municipios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Participantes_directorTecnicoId",
                table: "Equipos",
                column: "directorTecnicoId",
                principalTable: "Participantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Participantes_jugadorId",
                table: "Equipos",
                column: "jugadorId",
                principalTable: "Participantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estadios_Municipios_municipioId",
                table: "Estadios",
                column: "municipioId",
                principalTable: "Municipios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Participantes_Colegios_colegioId",
                table: "Participantes",
                column: "colegioId",
                principalTable: "Colegios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Participantes_Participantes_Arbitro_participanteId",
                table: "Participantes",
                column: "Arbitro_participanteId",
                principalTable: "Participantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Participantes_Participantes_Director_Tecnico_participanteId",
                table: "Participantes",
                column: "Director_Tecnico_participanteId",
                principalTable: "Participantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Participantes_Participantes_participanteId",
                table: "Participantes",
                column: "participanteId",
                principalTable: "Participantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Partidos_Equipos_equipoId",
                table: "Partidos",
                column: "equipoId",
                principalTable: "Equipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Partidos_Estadios_estadioId",
                table: "Partidos",
                column: "estadioId",
                principalTable: "Estadios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Partidos_Participantes_arbitroId",
                table: "Partidos",
                column: "arbitroId",
                principalTable: "Participantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
