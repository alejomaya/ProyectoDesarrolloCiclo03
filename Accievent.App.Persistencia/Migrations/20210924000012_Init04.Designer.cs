﻿// <auto-generated />
using Accievent.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Accievent.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20210924000012_Init04")]
    partial class Init04
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Accievent.App.Dominio.Accidente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Barrio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Causa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaseDeAccidente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CodigoAccidente")
                        .HasColumnType("int");

                    b.Property<string>("CodigoAgente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Colision")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fecha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Latitud")
                        .HasColumnType("int");

                    b.Property<int>("Longitud")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Accidentes");
                });

            modelBuilder.Entity("Accievent.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<int>("IdPersona")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("Accievent.App.Dominio.AgenteDeTransito", b =>
                {
                    b.HasBaseType("Accievent.App.Dominio.Persona");

                    b.Property<string>("Cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodigoAgente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdAgente")
                        .HasColumnType("int");

                    b.Property<string>("Prueba")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("AgenteDeTransito");
                });
#pragma warning restore 612, 618
        }
    }
}
