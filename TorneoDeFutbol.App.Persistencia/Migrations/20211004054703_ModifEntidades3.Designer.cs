﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TorneoDeFutbol.App.Persistencia;

namespace TorneoDeFutbol.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211004054703_ModifEntidades3")]
    partial class ModifEntidades3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Colegio", b =>
                {
                    b.Property<int>("idColegio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idColegio");

                    b.ToTable("Colegios");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Datos_Partido", b =>
                {
                    b.Property<int>("idDatosPartido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("arbitroidParticipante")
                        .HasColumnType("int");

                    b.Property<bool>("equipoLocal")
                        .HasColumnType("bit");

                    b.Property<bool>("equipoVisitante")
                        .HasColumnType("bit");

                    b.Property<int?>("equipoidEquipo")
                        .HasColumnType("int");

                    b.Property<int?>("estadioidEstadio")
                        .HasColumnType("int");

                    b.Property<int>("golesL")
                        .HasColumnType("int");

                    b.Property<int>("golesV")
                        .HasColumnType("int");

                    b.Property<int>("marcador")
                        .HasColumnType("int");

                    b.Property<int>("tarjetasAmarillas")
                        .HasColumnType("int");

                    b.Property<int>("tarjetasRojas")
                        .HasColumnType("int");

                    b.Property<int>("tiempo")
                        .HasColumnType("int");

                    b.HasKey("idDatosPartido");

                    b.HasIndex("arbitroidParticipante");

                    b.HasIndex("equipoidEquipo");

                    b.HasIndex("estadioidEstadio");

                    b.ToTable("DatosPartidos");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Equipo", b =>
                {
                    b.Property<int>("idEquipo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("directorTecnicoidParticipante")
                        .HasColumnType("int");

                    b.Property<int?>("jugadoridParticipante")
                        .HasColumnType("int");

                    b.Property<bool>("local")
                        .HasColumnType("bit");

                    b.Property<int?>("municipioidMunicipio")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("registropartidosJugados")
                        .HasColumnType("int");

                    b.Property<bool>("visitante")
                        .HasColumnType("bit");

                    b.HasKey("idEquipo");

                    b.HasIndex("directorTecnicoidParticipante");

                    b.HasIndex("jugadoridParticipante");

                    b.HasIndex("municipioidMunicipio");

                    b.HasIndex("registropartidosJugados");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Estadio", b =>
                {
                    b.Property<int>("idEstadio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("municipioidMunicipio")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idEstadio");

                    b.HasIndex("municipioidMunicipio");

                    b.ToTable("Estadios");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Municipio", b =>
                {
                    b.Property<int>("idMunicipio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idMunicipio");

                    b.ToTable("Municipios");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Participante", b =>
                {
                    b.Property<int>("idParticipante")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("genero")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numeroDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numeroTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idParticipante");

                    b.ToTable("Participantes");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Participante");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Partido", b =>
                {
                    b.Property<int>("idPartido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("arbitroidParticipante")
                        .HasColumnType("int");

                    b.Property<int?>("datosPartidoidDatosPartido")
                        .HasColumnType("int");

                    b.Property<bool>("equipoLocal")
                        .HasColumnType("bit");

                    b.Property<bool>("equipoVisitante")
                        .HasColumnType("bit");

                    b.Property<int?>("equipoidEquipo")
                        .HasColumnType("int");

                    b.Property<int?>("estadioidEstadio")
                        .HasColumnType("int");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("golesLocal")
                        .HasColumnType("int");

                    b.Property<int>("golesVisitante")
                        .HasColumnType("int");

                    b.Property<DateTime>("hora")
                        .HasColumnType("datetime2");

                    b.Property<int>("marcador")
                        .HasColumnType("int");

                    b.HasKey("idPartido");

                    b.HasIndex("arbitroidParticipante");

                    b.HasIndex("datosPartidoidDatosPartido");

                    b.HasIndex("equipoidEquipo");

                    b.HasIndex("estadioidEstadio");

                    b.ToTable("Partidos");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Registro", b =>
                {
                    b.Property<int>("partidosJugados")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("golesContra")
                        .HasColumnType("int");

                    b.Property<int>("golesFavor")
                        .HasColumnType("int");

                    b.Property<int>("partidosEmpatados")
                        .HasColumnType("int");

                    b.Property<int>("partidosGanados")
                        .HasColumnType("int");

                    b.Property<int>("puntos")
                        .HasColumnType("int");

                    b.HasKey("partidosJugados");

                    b.ToTable("Registros");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Arbitro", b =>
                {
                    b.HasBaseType("TorneoDeFutbol.App.Dominio.Participante");

                    b.Property<int?>("colegioidColegio")
                        .HasColumnType("int");

                    b.Property<int>("idArbitro")
                        .HasColumnType("int");

                    b.Property<int?>("participanteidParticipante")
                        .HasColumnType("int")
                        .HasColumnName("Arbitro_participanteidParticipante");

                    b.HasIndex("colegioidColegio");

                    b.HasIndex("participanteidParticipante");

                    b.HasDiscriminator().HasValue("Arbitro");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Director_Tecnico", b =>
                {
                    b.HasBaseType("TorneoDeFutbol.App.Dominio.Participante");

                    b.Property<int?>("participanteidParticipante")
                        .HasColumnType("int")
                        .HasColumnName("Director_Tecnico_participanteidParticipante");

                    b.HasIndex("participanteidParticipante");

                    b.HasDiscriminator().HasValue("Director_Tecnico");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Jugador", b =>
                {
                    b.HasBaseType("TorneoDeFutbol.App.Dominio.Participante");

                    b.Property<int>("numCamiseta")
                        .HasColumnType("int");

                    b.Property<int?>("participanteidParticipante")
                        .HasColumnType("int");

                    b.Property<string>("posicion")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("participanteidParticipante");

                    b.HasDiscriminator().HasValue("Jugador");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Datos_Partido", b =>
                {
                    b.HasOne("TorneoDeFutbol.App.Dominio.Arbitro", "arbitro")
                        .WithMany()
                        .HasForeignKey("arbitroidParticipante");

                    b.HasOne("TorneoDeFutbol.App.Dominio.Equipo", "equipo")
                        .WithMany()
                        .HasForeignKey("equipoidEquipo");

                    b.HasOne("TorneoDeFutbol.App.Dominio.Estadio", "estadio")
                        .WithMany()
                        .HasForeignKey("estadioidEstadio");

                    b.Navigation("arbitro");

                    b.Navigation("equipo");

                    b.Navigation("estadio");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Equipo", b =>
                {
                    b.HasOne("TorneoDeFutbol.App.Dominio.Director_Tecnico", "directorTecnico")
                        .WithMany()
                        .HasForeignKey("directorTecnicoidParticipante");

                    b.HasOne("TorneoDeFutbol.App.Dominio.Jugador", "jugador")
                        .WithMany()
                        .HasForeignKey("jugadoridParticipante");

                    b.HasOne("TorneoDeFutbol.App.Dominio.Municipio", "municipio")
                        .WithMany()
                        .HasForeignKey("municipioidMunicipio");

                    b.HasOne("TorneoDeFutbol.App.Dominio.Registro", "registro")
                        .WithMany()
                        .HasForeignKey("registropartidosJugados");

                    b.Navigation("directorTecnico");

                    b.Navigation("jugador");

                    b.Navigation("municipio");

                    b.Navigation("registro");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Estadio", b =>
                {
                    b.HasOne("TorneoDeFutbol.App.Dominio.Municipio", "municipio")
                        .WithMany()
                        .HasForeignKey("municipioidMunicipio");

                    b.Navigation("municipio");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Partido", b =>
                {
                    b.HasOne("TorneoDeFutbol.App.Dominio.Arbitro", "arbitro")
                        .WithMany()
                        .HasForeignKey("arbitroidParticipante");

                    b.HasOne("TorneoDeFutbol.App.Dominio.Datos_Partido", "datosPartido")
                        .WithMany()
                        .HasForeignKey("datosPartidoidDatosPartido");

                    b.HasOne("TorneoDeFutbol.App.Dominio.Equipo", "equipo")
                        .WithMany()
                        .HasForeignKey("equipoidEquipo");

                    b.HasOne("TorneoDeFutbol.App.Dominio.Estadio", "estadio")
                        .WithMany()
                        .HasForeignKey("estadioidEstadio");

                    b.Navigation("arbitro");

                    b.Navigation("datosPartido");

                    b.Navigation("equipo");

                    b.Navigation("estadio");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Arbitro", b =>
                {
                    b.HasOne("TorneoDeFutbol.App.Dominio.Colegio", "colegio")
                        .WithMany()
                        .HasForeignKey("colegioidColegio");

                    b.HasOne("TorneoDeFutbol.App.Dominio.Participante", "participante")
                        .WithMany()
                        .HasForeignKey("participanteidParticipante");

                    b.Navigation("colegio");

                    b.Navigation("participante");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Director_Tecnico", b =>
                {
                    b.HasOne("TorneoDeFutbol.App.Dominio.Participante", "participante")
                        .WithMany()
                        .HasForeignKey("participanteidParticipante");

                    b.Navigation("participante");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Jugador", b =>
                {
                    b.HasOne("TorneoDeFutbol.App.Dominio.Participante", "participante")
                        .WithMany()
                        .HasForeignKey("participanteidParticipante");

                    b.Navigation("participante");
                });
#pragma warning restore 612, 618
        }
    }
}
