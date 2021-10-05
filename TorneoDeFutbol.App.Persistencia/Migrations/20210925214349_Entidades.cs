using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TorneoDeFutbol.App.Persistencia.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colegios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colegios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Municipios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Registros",
                columns: table => new
                {
                    Partidos_Jugados = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Partidos_Ganados = table.Column<int>(type: "int", nullable: false),
                    Partidos_Empatados = table.Column<int>(type: "int", nullable: false),
                    Goles_Favor = table.Column<int>(type: "int", nullable: false),
                    Goles_Contra = table.Column<int>(type: "int", nullable: false),
                    Puntos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registros", x => x.Partidos_Jugados);
                });

            migrationBuilder.CreateTable(
                name: "Participantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroDocumento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero_Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    colegioId = table.Column<int>(type: "int", nullable: true),
                    Arbitro_participanteId = table.Column<int>(type: "int", nullable: true),
                    Director_Tecnico_participanteId = table.Column<int>(type: "int", nullable: true),
                    NumCamiseta = table.Column<int>(type: "int", nullable: true),
                    Posicion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    participanteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Participantes_Colegios_colegioId",
                        column: x => x.colegioId,
                        principalTable: "Colegios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Participantes_Participantes_Arbitro_participanteId",
                        column: x => x.Arbitro_participanteId,
                        principalTable: "Participantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Participantes_Participantes_Director_Tecnico_participanteId",
                        column: x => x.Director_Tecnico_participanteId,
                        principalTable: "Participantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Participantes_Participantes_participanteId",
                        column: x => x.participanteId,
                        principalTable: "Participantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estadios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    municipioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estadios_Municipios_municipioId",
                        column: x => x.municipioId,
                        principalTable: "Municipios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    municipioId = table.Column<int>(type: "int", nullable: true),
                    jugadorId = table.Column<int>(type: "int", nullable: true),
                    registroPartidos_Jugados = table.Column<int>(type: "int", nullable: true),
                    directorTecnicoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipos_Municipios_municipioId",
                        column: x => x.municipioId,
                        principalTable: "Municipios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipos_Participantes_directorTecnicoId",
                        column: x => x.directorTecnicoId,
                        principalTable: "Participantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipos_Participantes_jugadorId",
                        column: x => x.jugadorId,
                        principalTable: "Participantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipos_Registros_registroPartidos_Jugados",
                        column: x => x.registroPartidos_Jugados,
                        principalTable: "Registros",
                        principalColumn: "Partidos_Jugados",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DatosPartidos",
                columns: table => new
                {
                    Id_DatosPartido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marcador = table.Column<int>(type: "int", nullable: false),
                    Tarjetas_Amarillas = table.Column<int>(type: "int", nullable: false),
                    Tarjetas_Rojas = table.Column<int>(type: "int", nullable: false),
                    Goles_V = table.Column<int>(type: "int", nullable: false),
                    Goles_L = table.Column<int>(type: "int", nullable: false),
                    Tiempo = table.Column<int>(type: "int", nullable: false),
                    equipoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosPartidos", x => x.Id_DatosPartido);
                    table.ForeignKey(
                        name: "FK_DatosPartidos_Equipos_equipoId",
                        column: x => x.equipoId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Partidos",
                columns: table => new
                {
                    Id_Partido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EquipoVisitante = table.Column<bool>(type: "bit", nullable: false),
                    EquipoLocal = table.Column<bool>(type: "bit", nullable: false),
                    GolesLocal = table.Column<int>(type: "int", nullable: false),
                    GolesVisitante = table.Column<int>(type: "int", nullable: false),
                    Marcador = table.Column<int>(type: "int", nullable: false),
                    estadioId = table.Column<int>(type: "int", nullable: true),
                    equipoId = table.Column<int>(type: "int", nullable: true),
                    datospartidoId_DatosPartido = table.Column<int>(type: "int", nullable: true),
                    arbitroId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partidos", x => x.Id_Partido);
                    table.ForeignKey(
                        name: "FK_Partidos_DatosPartidos_datospartidoId_DatosPartido",
                        column: x => x.datospartidoId_DatosPartido,
                        principalTable: "DatosPartidos",
                        principalColumn: "Id_DatosPartido",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partidos_Equipos_equipoId",
                        column: x => x.equipoId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partidos_Estadios_estadioId",
                        column: x => x.estadioId,
                        principalTable: "Estadios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partidos_Participantes_arbitroId",
                        column: x => x.arbitroId,
                        principalTable: "Participantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DatosPartidos_equipoId",
                table: "DatosPartidos",
                column: "equipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_directorTecnicoId",
                table: "Equipos",
                column: "directorTecnicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_jugadorId",
                table: "Equipos",
                column: "jugadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_municipioId",
                table: "Equipos",
                column: "municipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_registroPartidos_Jugados",
                table: "Equipos",
                column: "registroPartidos_Jugados");

            migrationBuilder.CreateIndex(
                name: "IX_Estadios_municipioId",
                table: "Estadios",
                column: "municipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Participantes_Arbitro_participanteId",
                table: "Participantes",
                column: "Arbitro_participanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Participantes_colegioId",
                table: "Participantes",
                column: "colegioId");

            migrationBuilder.CreateIndex(
                name: "IX_Participantes_Director_Tecnico_participanteId",
                table: "Participantes",
                column: "Director_Tecnico_participanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Participantes_participanteId",
                table: "Participantes",
                column: "participanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_arbitroId",
                table: "Partidos",
                column: "arbitroId");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_datospartidoId_DatosPartido",
                table: "Partidos",
                column: "datospartidoId_DatosPartido");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_equipoId",
                table: "Partidos",
                column: "equipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_estadioId",
                table: "Partidos",
                column: "estadioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Partidos");

            migrationBuilder.DropTable(
                name: "DatosPartidos");

            migrationBuilder.DropTable(
                name: "Estadios");

            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropTable(
                name: "Municipios");

            migrationBuilder.DropTable(
                name: "Participantes");

            migrationBuilder.DropTable(
                name: "Registros");

            migrationBuilder.DropTable(
                name: "Colegios");
        }
    }
}
