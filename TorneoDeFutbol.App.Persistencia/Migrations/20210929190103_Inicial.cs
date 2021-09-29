using Microsoft.EntityFrameworkCore.Migrations;

namespace TorneoDeFutbol.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "FK_Equipos_Registros_registroPartidos_Jugados",
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
                name: "FK_Partidos_DatosPartidos_datospartidoId_DatosPartido",
                table: "Partidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_Equipos_equipoId_Equipo",
                table: "Partidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_Estadios_estadioId_Estadio",
                table: "Partidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_Participantes_arbitroId_Participante",
                table: "Partidos");

            migrationBuilder.DropIndex(
                name: "IX_Participantes_colegioId_Colegio",
                table: "Participantes");

            migrationBuilder.RenameColumn(
                name: "Puntos",
                table: "Registros",
                newName: "puntos");

            migrationBuilder.RenameColumn(
                name: "Partidos_Ganados",
                table: "Registros",
                newName: "partidosGanados");

            migrationBuilder.RenameColumn(
                name: "Partidos_Empatados",
                table: "Registros",
                newName: "partidosEmpatados");

            migrationBuilder.RenameColumn(
                name: "Goles_Favor",
                table: "Registros",
                newName: "golesFavor");

            migrationBuilder.RenameColumn(
                name: "Goles_Contra",
                table: "Registros",
                newName: "golesContra");

            migrationBuilder.RenameColumn(
                name: "Partidos_Jugados",
                table: "Registros",
                newName: "partidosJugados");

            migrationBuilder.RenameColumn(
                name: "Marcador",
                table: "Partidos",
                newName: "marcador");

            migrationBuilder.RenameColumn(
                name: "Hora",
                table: "Partidos",
                newName: "hora");

            migrationBuilder.RenameColumn(
                name: "GolesVisitante",
                table: "Partidos",
                newName: "golesVisitante");

            migrationBuilder.RenameColumn(
                name: "GolesLocal",
                table: "Partidos",
                newName: "golesLocal");

            migrationBuilder.RenameColumn(
                name: "Fecha",
                table: "Partidos",
                newName: "fecha");

            migrationBuilder.RenameColumn(
                name: "EquipoVisitante",
                table: "Partidos",
                newName: "equipoVisitante");

            migrationBuilder.RenameColumn(
                name: "EquipoLocal",
                table: "Partidos",
                newName: "equipoLocal");

            migrationBuilder.RenameColumn(
                name: "estadioId_Estadio",
                table: "Partidos",
                newName: "estadioidEstadio");

            migrationBuilder.RenameColumn(
                name: "equipoId_Equipo",
                table: "Partidos",
                newName: "equipoidEquipo");

            migrationBuilder.RenameColumn(
                name: "datospartidoId_DatosPartido",
                table: "Partidos",
                newName: "datosPartidoidDatosPartido");

            migrationBuilder.RenameColumn(
                name: "arbitroId_Participante",
                table: "Partidos",
                newName: "arbitroidParticipante");

            migrationBuilder.RenameColumn(
                name: "Id_Partido",
                table: "Partidos",
                newName: "idPartido");

            migrationBuilder.RenameIndex(
                name: "IX_Partidos_estadioId_Estadio",
                table: "Partidos",
                newName: "IX_Partidos_estadioidEstadio");

            migrationBuilder.RenameIndex(
                name: "IX_Partidos_equipoId_Equipo",
                table: "Partidos",
                newName: "IX_Partidos_equipoidEquipo");

            migrationBuilder.RenameIndex(
                name: "IX_Partidos_datospartidoId_DatosPartido",
                table: "Partidos",
                newName: "IX_Partidos_datosPartidoidDatosPartido");

            migrationBuilder.RenameIndex(
                name: "IX_Partidos_arbitroId_Participante",
                table: "Partidos",
                newName: "IX_Partidos_arbitroidParticipante");

            migrationBuilder.RenameColumn(
                name: "Posicion",
                table: "Participantes",
                newName: "posicion");

            migrationBuilder.RenameColumn(
                name: "NumeroDocumento",
                table: "Participantes",
                newName: "numeroDocumento");

            migrationBuilder.RenameColumn(
                name: "NumCamiseta",
                table: "Participantes",
                newName: "numCamiseta");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Participantes",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "Direccion",
                table: "Participantes",
                newName: "direccion");

            migrationBuilder.RenameColumn(
                name: "Ciudad",
                table: "Participantes",
                newName: "ciudad");

            migrationBuilder.RenameColumn(
                name: "Apellido",
                table: "Participantes",
                newName: "apellido");

            migrationBuilder.RenameColumn(
                name: "participanteId_Participante",
                table: "Participantes",
                newName: "participanteidParticipante");

            migrationBuilder.RenameColumn(
                name: "colegioId_Colegio",
                table: "Participantes",
                newName: "idArbitro");

            migrationBuilder.RenameColumn(
                name: "Numero_Telefono",
                table: "Participantes",
                newName: "numeroTelefono");

            migrationBuilder.RenameColumn(
                name: "Director_Tecnico_participanteId_Participante",
                table: "Participantes",
                newName: "colegioidColegio");

            migrationBuilder.RenameColumn(
                name: "Arbitro_participanteId_Participante",
                table: "Participantes",
                newName: "Director_Tecnico_participanteidParticipante");

            migrationBuilder.RenameColumn(
                name: "Id_Participante",
                table: "Participantes",
                newName: "idParticipante");

            migrationBuilder.RenameIndex(
                name: "IX_Participantes_participanteId_Participante",
                table: "Participantes",
                newName: "IX_Participantes_participanteidParticipante");

            migrationBuilder.RenameIndex(
                name: "IX_Participantes_Director_Tecnico_participanteId_Participante",
                table: "Participantes",
                newName: "IX_Participantes_colegioidColegio");

            migrationBuilder.RenameIndex(
                name: "IX_Participantes_Arbitro_participanteId_Participante",
                table: "Participantes",
                newName: "IX_Participantes_Director_Tecnico_participanteidParticipante");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Municipios",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "Id_Municipio",
                table: "Municipios",
                newName: "idMunicipio");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Estadios",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "Direccion",
                table: "Estadios",
                newName: "direccion");

            migrationBuilder.RenameColumn(
                name: "municipioId_Municipio",
                table: "Estadios",
                newName: "municipioidMunicipio");

            migrationBuilder.RenameColumn(
                name: "Id_Estadio",
                table: "Estadios",
                newName: "idEstadio");

            migrationBuilder.RenameIndex(
                name: "IX_Estadios_municipioId_Municipio",
                table: "Estadios",
                newName: "IX_Estadios_municipioidMunicipio");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Equipos",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "registroPartidos_Jugados",
                table: "Equipos",
                newName: "registropartidosJugados");

            migrationBuilder.RenameColumn(
                name: "municipioId_Municipio",
                table: "Equipos",
                newName: "municipioidMunicipio");

            migrationBuilder.RenameColumn(
                name: "jugadorId_Participante",
                table: "Equipos",
                newName: "jugadoridParticipante");

            migrationBuilder.RenameColumn(
                name: "directorTecnicoId_Participante",
                table: "Equipos",
                newName: "directorTecnicoidParticipante");

            migrationBuilder.RenameColumn(
                name: "Id_Equipo",
                table: "Equipos",
                newName: "idEquipo");

            migrationBuilder.RenameIndex(
                name: "IX_Equipos_registroPartidos_Jugados",
                table: "Equipos",
                newName: "IX_Equipos_registropartidosJugados");

            migrationBuilder.RenameIndex(
                name: "IX_Equipos_municipioId_Municipio",
                table: "Equipos",
                newName: "IX_Equipos_municipioidMunicipio");

            migrationBuilder.RenameIndex(
                name: "IX_Equipos_jugadorId_Participante",
                table: "Equipos",
                newName: "IX_Equipos_jugadoridParticipante");

            migrationBuilder.RenameIndex(
                name: "IX_Equipos_directorTecnicoId_Participante",
                table: "Equipos",
                newName: "IX_Equipos_directorTecnicoidParticipante");

            migrationBuilder.RenameColumn(
                name: "Tiempo",
                table: "DatosPartidos",
                newName: "tiempo");

            migrationBuilder.RenameColumn(
                name: "Marcador",
                table: "DatosPartidos",
                newName: "marcador");

            migrationBuilder.RenameColumn(
                name: "equipoId_Equipo",
                table: "DatosPartidos",
                newName: "estadioidEstadio");

            migrationBuilder.RenameColumn(
                name: "Tarjetas_Rojas",
                table: "DatosPartidos",
                newName: "tarjetasRojas");

            migrationBuilder.RenameColumn(
                name: "Tarjetas_Amarillas",
                table: "DatosPartidos",
                newName: "tarjetasAmarillas");

            migrationBuilder.RenameColumn(
                name: "Goles_V",
                table: "DatosPartidos",
                newName: "golesV");

            migrationBuilder.RenameColumn(
                name: "Goles_L",
                table: "DatosPartidos",
                newName: "golesL");

            migrationBuilder.RenameColumn(
                name: "Id_DatosPartido",
                table: "DatosPartidos",
                newName: "idDatosPartido");

            migrationBuilder.RenameIndex(
                name: "IX_DatosPartidos_equipoId_Equipo",
                table: "DatosPartidos",
                newName: "IX_DatosPartidos_estadioidEstadio");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Colegios",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "Id_Colegio",
                table: "Colegios",
                newName: "idColegio");

            migrationBuilder.AddColumn<int>(
                name: "Arbitro_participanteidParticipante",
                table: "Participantes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "local",
                table: "Equipos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "visitante",
                table: "Equipos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "arbitroidParticipante",
                table: "DatosPartidos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "equipoLocal",
                table: "DatosPartidos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "equipoVisitante",
                table: "DatosPartidos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "equipoidEquipo",
                table: "DatosPartidos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Participantes_Arbitro_participanteidParticipante",
                table: "Participantes",
                column: "Arbitro_participanteidParticipante");

            migrationBuilder.CreateIndex(
                name: "IX_DatosPartidos_arbitroidParticipante",
                table: "DatosPartidos",
                column: "arbitroidParticipante");

            migrationBuilder.CreateIndex(
                name: "IX_DatosPartidos_equipoidEquipo",
                table: "DatosPartidos",
                column: "equipoidEquipo");

            migrationBuilder.AddForeignKey(
                name: "FK_DatosPartidos_Equipos_equipoidEquipo",
                table: "DatosPartidos",
                column: "equipoidEquipo",
                principalTable: "Equipos",
                principalColumn: "idEquipo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DatosPartidos_Estadios_estadioidEstadio",
                table: "DatosPartidos",
                column: "estadioidEstadio",
                principalTable: "Estadios",
                principalColumn: "idEstadio",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DatosPartidos_Participantes_arbitroidParticipante",
                table: "DatosPartidos",
                column: "arbitroidParticipante",
                principalTable: "Participantes",
                principalColumn: "idParticipante",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Municipios_municipioidMunicipio",
                table: "Equipos",
                column: "municipioidMunicipio",
                principalTable: "Municipios",
                principalColumn: "idMunicipio",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Participantes_directorTecnicoidParticipante",
                table: "Equipos",
                column: "directorTecnicoidParticipante",
                principalTable: "Participantes",
                principalColumn: "idParticipante",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Participantes_jugadoridParticipante",
                table: "Equipos",
                column: "jugadoridParticipante",
                principalTable: "Participantes",
                principalColumn: "idParticipante",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Registros_registropartidosJugados",
                table: "Equipos",
                column: "registropartidosJugados",
                principalTable: "Registros",
                principalColumn: "partidosJugados",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estadios_Municipios_municipioidMunicipio",
                table: "Estadios",
                column: "municipioidMunicipio",
                principalTable: "Municipios",
                principalColumn: "idMunicipio",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Participantes_Colegios_colegioidColegio",
                table: "Participantes",
                column: "colegioidColegio",
                principalTable: "Colegios",
                principalColumn: "idColegio",
                onDelete: ReferentialAction.Restrict);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Partidos_DatosPartidos_datosPartidoidDatosPartido",
                table: "Partidos",
                column: "datosPartidoidDatosPartido",
                principalTable: "DatosPartidos",
                principalColumn: "idDatosPartido",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Partidos_Equipos_equipoidEquipo",
                table: "Partidos",
                column: "equipoidEquipo",
                principalTable: "Equipos",
                principalColumn: "idEquipo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Partidos_Estadios_estadioidEstadio",
                table: "Partidos",
                column: "estadioidEstadio",
                principalTable: "Estadios",
                principalColumn: "idEstadio",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Partidos_Participantes_arbitroidParticipante",
                table: "Partidos",
                column: "arbitroidParticipante",
                principalTable: "Participantes",
                principalColumn: "idParticipante",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DatosPartidos_Equipos_equipoidEquipo",
                table: "DatosPartidos");

            migrationBuilder.DropForeignKey(
                name: "FK_DatosPartidos_Estadios_estadioidEstadio",
                table: "DatosPartidos");

            migrationBuilder.DropForeignKey(
                name: "FK_DatosPartidos_Participantes_arbitroidParticipante",
                table: "DatosPartidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Municipios_municipioidMunicipio",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Participantes_directorTecnicoidParticipante",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Participantes_jugadoridParticipante",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Registros_registropartidosJugados",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Estadios_Municipios_municipioidMunicipio",
                table: "Estadios");

            migrationBuilder.DropForeignKey(
                name: "FK_Participantes_Colegios_colegioidColegio",
                table: "Participantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Participantes_Participantes_Arbitro_participanteidParticipante",
                table: "Participantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Participantes_Participantes_Director_Tecnico_participanteidParticipante",
                table: "Participantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Participantes_Participantes_participanteidParticipante",
                table: "Participantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_DatosPartidos_datosPartidoidDatosPartido",
                table: "Partidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_Equipos_equipoidEquipo",
                table: "Partidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_Estadios_estadioidEstadio",
                table: "Partidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_Participantes_arbitroidParticipante",
                table: "Partidos");

            migrationBuilder.DropIndex(
                name: "IX_Participantes_Arbitro_participanteidParticipante",
                table: "Participantes");

            migrationBuilder.DropIndex(
                name: "IX_DatosPartidos_arbitroidParticipante",
                table: "DatosPartidos");

            migrationBuilder.DropIndex(
                name: "IX_DatosPartidos_equipoidEquipo",
                table: "DatosPartidos");

            migrationBuilder.DropColumn(
                name: "Arbitro_participanteidParticipante",
                table: "Participantes");

            migrationBuilder.DropColumn(
                name: "local",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "visitante",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "arbitroidParticipante",
                table: "DatosPartidos");

            migrationBuilder.DropColumn(
                name: "equipoLocal",
                table: "DatosPartidos");

            migrationBuilder.DropColumn(
                name: "equipoVisitante",
                table: "DatosPartidos");

            migrationBuilder.DropColumn(
                name: "equipoidEquipo",
                table: "DatosPartidos");

            migrationBuilder.RenameColumn(
                name: "puntos",
                table: "Registros",
                newName: "Puntos");

            migrationBuilder.RenameColumn(
                name: "partidosGanados",
                table: "Registros",
                newName: "Partidos_Ganados");

            migrationBuilder.RenameColumn(
                name: "partidosEmpatados",
                table: "Registros",
                newName: "Partidos_Empatados");

            migrationBuilder.RenameColumn(
                name: "golesFavor",
                table: "Registros",
                newName: "Goles_Favor");

            migrationBuilder.RenameColumn(
                name: "golesContra",
                table: "Registros",
                newName: "Goles_Contra");

            migrationBuilder.RenameColumn(
                name: "partidosJugados",
                table: "Registros",
                newName: "Partidos_Jugados");

            migrationBuilder.RenameColumn(
                name: "marcador",
                table: "Partidos",
                newName: "Marcador");

            migrationBuilder.RenameColumn(
                name: "hora",
                table: "Partidos",
                newName: "Hora");

            migrationBuilder.RenameColumn(
                name: "golesVisitante",
                table: "Partidos",
                newName: "GolesVisitante");

            migrationBuilder.RenameColumn(
                name: "golesLocal",
                table: "Partidos",
                newName: "GolesLocal");

            migrationBuilder.RenameColumn(
                name: "fecha",
                table: "Partidos",
                newName: "Fecha");

            migrationBuilder.RenameColumn(
                name: "equipoVisitante",
                table: "Partidos",
                newName: "EquipoVisitante");

            migrationBuilder.RenameColumn(
                name: "equipoLocal",
                table: "Partidos",
                newName: "EquipoLocal");

            migrationBuilder.RenameColumn(
                name: "estadioidEstadio",
                table: "Partidos",
                newName: "estadioId_Estadio");

            migrationBuilder.RenameColumn(
                name: "equipoidEquipo",
                table: "Partidos",
                newName: "equipoId_Equipo");

            migrationBuilder.RenameColumn(
                name: "datosPartidoidDatosPartido",
                table: "Partidos",
                newName: "datospartidoId_DatosPartido");

            migrationBuilder.RenameColumn(
                name: "arbitroidParticipante",
                table: "Partidos",
                newName: "arbitroId_Participante");

            migrationBuilder.RenameColumn(
                name: "idPartido",
                table: "Partidos",
                newName: "Id_Partido");

            migrationBuilder.RenameIndex(
                name: "IX_Partidos_estadioidEstadio",
                table: "Partidos",
                newName: "IX_Partidos_estadioId_Estadio");

            migrationBuilder.RenameIndex(
                name: "IX_Partidos_equipoidEquipo",
                table: "Partidos",
                newName: "IX_Partidos_equipoId_Equipo");

            migrationBuilder.RenameIndex(
                name: "IX_Partidos_datosPartidoidDatosPartido",
                table: "Partidos",
                newName: "IX_Partidos_datospartidoId_DatosPartido");

            migrationBuilder.RenameIndex(
                name: "IX_Partidos_arbitroidParticipante",
                table: "Partidos",
                newName: "IX_Partidos_arbitroId_Participante");

            migrationBuilder.RenameColumn(
                name: "posicion",
                table: "Participantes",
                newName: "Posicion");

            migrationBuilder.RenameColumn(
                name: "numeroDocumento",
                table: "Participantes",
                newName: "NumeroDocumento");

            migrationBuilder.RenameColumn(
                name: "numCamiseta",
                table: "Participantes",
                newName: "NumCamiseta");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Participantes",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "direccion",
                table: "Participantes",
                newName: "Direccion");

            migrationBuilder.RenameColumn(
                name: "ciudad",
                table: "Participantes",
                newName: "Ciudad");

            migrationBuilder.RenameColumn(
                name: "apellido",
                table: "Participantes",
                newName: "Apellido");

            migrationBuilder.RenameColumn(
                name: "participanteidParticipante",
                table: "Participantes",
                newName: "participanteId_Participante");

            migrationBuilder.RenameColumn(
                name: "numeroTelefono",
                table: "Participantes",
                newName: "Numero_Telefono");

            migrationBuilder.RenameColumn(
                name: "idArbitro",
                table: "Participantes",
                newName: "colegioId_Colegio");

            migrationBuilder.RenameColumn(
                name: "colegioidColegio",
                table: "Participantes",
                newName: "Director_Tecnico_participanteId_Participante");

            migrationBuilder.RenameColumn(
                name: "Director_Tecnico_participanteidParticipante",
                table: "Participantes",
                newName: "Arbitro_participanteId_Participante");

            migrationBuilder.RenameColumn(
                name: "idParticipante",
                table: "Participantes",
                newName: "Id_Participante");

            migrationBuilder.RenameIndex(
                name: "IX_Participantes_participanteidParticipante",
                table: "Participantes",
                newName: "IX_Participantes_participanteId_Participante");

            migrationBuilder.RenameIndex(
                name: "IX_Participantes_Director_Tecnico_participanteidParticipante",
                table: "Participantes",
                newName: "IX_Participantes_Arbitro_participanteId_Participante");

            migrationBuilder.RenameIndex(
                name: "IX_Participantes_colegioidColegio",
                table: "Participantes",
                newName: "IX_Participantes_Director_Tecnico_participanteId_Participante");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Municipios",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "idMunicipio",
                table: "Municipios",
                newName: "Id_Municipio");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Estadios",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "direccion",
                table: "Estadios",
                newName: "Direccion");

            migrationBuilder.RenameColumn(
                name: "municipioidMunicipio",
                table: "Estadios",
                newName: "municipioId_Municipio");

            migrationBuilder.RenameColumn(
                name: "idEstadio",
                table: "Estadios",
                newName: "Id_Estadio");

            migrationBuilder.RenameIndex(
                name: "IX_Estadios_municipioidMunicipio",
                table: "Estadios",
                newName: "IX_Estadios_municipioId_Municipio");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Equipos",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "registropartidosJugados",
                table: "Equipos",
                newName: "registroPartidos_Jugados");

            migrationBuilder.RenameColumn(
                name: "municipioidMunicipio",
                table: "Equipos",
                newName: "municipioId_Municipio");

            migrationBuilder.RenameColumn(
                name: "jugadoridParticipante",
                table: "Equipos",
                newName: "jugadorId_Participante");

            migrationBuilder.RenameColumn(
                name: "directorTecnicoidParticipante",
                table: "Equipos",
                newName: "directorTecnicoId_Participante");

            migrationBuilder.RenameColumn(
                name: "idEquipo",
                table: "Equipos",
                newName: "Id_Equipo");

            migrationBuilder.RenameIndex(
                name: "IX_Equipos_registropartidosJugados",
                table: "Equipos",
                newName: "IX_Equipos_registroPartidos_Jugados");

            migrationBuilder.RenameIndex(
                name: "IX_Equipos_municipioidMunicipio",
                table: "Equipos",
                newName: "IX_Equipos_municipioId_Municipio");

            migrationBuilder.RenameIndex(
                name: "IX_Equipos_jugadoridParticipante",
                table: "Equipos",
                newName: "IX_Equipos_jugadorId_Participante");

            migrationBuilder.RenameIndex(
                name: "IX_Equipos_directorTecnicoidParticipante",
                table: "Equipos",
                newName: "IX_Equipos_directorTecnicoId_Participante");

            migrationBuilder.RenameColumn(
                name: "tiempo",
                table: "DatosPartidos",
                newName: "Tiempo");

            migrationBuilder.RenameColumn(
                name: "marcador",
                table: "DatosPartidos",
                newName: "Marcador");

            migrationBuilder.RenameColumn(
                name: "tarjetasRojas",
                table: "DatosPartidos",
                newName: "Tarjetas_Rojas");

            migrationBuilder.RenameColumn(
                name: "tarjetasAmarillas",
                table: "DatosPartidos",
                newName: "Tarjetas_Amarillas");

            migrationBuilder.RenameColumn(
                name: "golesV",
                table: "DatosPartidos",
                newName: "Goles_V");

            migrationBuilder.RenameColumn(
                name: "golesL",
                table: "DatosPartidos",
                newName: "Goles_L");

            migrationBuilder.RenameColumn(
                name: "estadioidEstadio",
                table: "DatosPartidos",
                newName: "equipoId_Equipo");

            migrationBuilder.RenameColumn(
                name: "idDatosPartido",
                table: "DatosPartidos",
                newName: "Id_DatosPartido");

            migrationBuilder.RenameIndex(
                name: "IX_DatosPartidos_estadioidEstadio",
                table: "DatosPartidos",
                newName: "IX_DatosPartidos_equipoId_Equipo");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Colegios",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "idColegio",
                table: "Colegios",
                newName: "Id_Colegio");

            migrationBuilder.CreateIndex(
                name: "IX_Participantes_colegioId_Colegio",
                table: "Participantes",
                column: "colegioId_Colegio");

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
                name: "FK_Equipos_Registros_registroPartidos_Jugados",
                table: "Equipos",
                column: "registroPartidos_Jugados",
                principalTable: "Registros",
                principalColumn: "Partidos_Jugados",
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
                name: "FK_Partidos_DatosPartidos_datospartidoId_DatosPartido",
                table: "Partidos",
                column: "datospartidoId_DatosPartido",
                principalTable: "DatosPartidos",
                principalColumn: "Id_DatosPartido",
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
    }
}
