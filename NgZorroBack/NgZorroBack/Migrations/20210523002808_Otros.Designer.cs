﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NgZorroBack.Models;

namespace NgZorroBack.Migrations
{
    [DbContext(typeof(MerakiZorroContext))]
    [Migration("20210523002808_Otros")]
    partial class Otros
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NgZorroBack.Models.Colore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Colores");
                });

            modelBuilder.Entity("NgZorroBack.Models.EstadoServicio", b =>
                {
                    b.Property<int>("IdEstadoServicio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEstadoServicio");

                    b.ToTable("EstadoServicios");
                });

            modelBuilder.Entity("NgZorroBack.Models.EstadoUsuario", b =>
                {
                    b.Property<int>("IdEstadoUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEstadoUsuario");

                    b.ToTable("EstadoUsuarios");
                });

            modelBuilder.Entity("NgZorroBack.Models.EstadoVehiculo", b =>
                {
                    b.Property<int>("IdEstadoVehiculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEstadoVehiculo");

                    b.ToTable("EstadoVehiculos");
                });

            modelBuilder.Entity("NgZorroBack.Models.Genero", b =>
                {
                    b.Property<int>("IdGenero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdGenero");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("NgZorroBack.Models.InfoConductore", b =>
                {
                    b.Property<int>("IdInfo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CodigoV")
                        .HasColumnType("int");

                    b.Property<int?>("CodigoVNavigationCodigoV")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("FotoConductor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdConductor")
                        .HasColumnType("int");

                    b.HasKey("IdInfo");

                    b.HasIndex("CodigoVNavigationCodigoV");

                    b.ToTable("InfoConductores");
                });

            modelBuilder.Entity("NgZorroBack.Models.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("NgZorroBack.Models.Role", b =>
                {
                    b.Property<int>("IdRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdRol");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("NgZorroBack.Models.Servicio", b =>
                {
                    b.Property<int>("IdServicio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CelularRecibe")
                        .HasColumnType("int");

                    b.Property<string>("DireccionCarga")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DireccionEntrega")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdConductor")
                        .HasColumnType("int");

                    b.Property<int?>("IdConductorNavigationIdInfo")
                        .HasColumnType("int");

                    b.Property<int>("IdEstadoServicio")
                        .HasColumnType("int");

                    b.Property<int?>("IdEstadoServicioNavigationIdEstadoServicio")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoCarga")
                        .HasColumnType("int");

                    b.Property<int?>("IdTipoCargaNavigationIdTipoCarga")
                        .HasColumnType("int");

                    b.Property<string>("PersonaRecibe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("PrecioServicio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdServicio");

                    b.HasIndex("IdConductorNavigationIdInfo");

                    b.HasIndex("IdEstadoServicioNavigationIdEstadoServicio");

                    b.HasIndex("IdTipoCargaNavigationIdTipoCarga");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("NgZorroBack.Models.TipoCarga", b =>
                {
                    b.Property<int>("IdTipoCarga")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTipoCarga");

                    b.ToTable("TipoCargas");
                });

            modelBuilder.Entity("NgZorroBack.Models.TipoDocumento", b =>
                {
                    b.Property<int>("IdTipoDocumento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTipoDocumento");

                    b.ToTable("TipoDocumentos");
                });

            modelBuilder.Entity("NgZorroBack.Models.TipoVehiculo", b =>
                {
                    b.Property<int>("IdTipoVehiculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTipoVehiculo");

                    b.ToTable("TipoVehiculos");
                });

            modelBuilder.Entity("NgZorroBack.Models.Vehiculo", b =>
                {
                    b.Property<int>("CodigoV")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cilindraje")
                        .HasColumnType("int");

                    b.Property<string>("FotoV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdColor")
                        .HasColumnType("int");

                    b.Property<int?>("IdColorNavigationId")
                        .HasColumnType("int");

                    b.Property<int?>("IdEstadoVehiculo")
                        .HasColumnType("int");

                    b.Property<int?>("IdEstadoVehiculoNavigationIdEstadoVehiculo")
                        .HasColumnType("int");

                    b.Property<int>("IdMarca")
                        .HasColumnType("int");

                    b.Property<int?>("IdMarcaNavigationId")
                        .HasColumnType("int");

                    b.Property<int?>("IdPropietario")
                        .HasColumnType("int");

                    b.Property<int?>("IdTipoVehiculo")
                        .HasColumnType("int");

                    b.Property<int?>("IdTipoVehiculoNavigationIdTipoVehiculo")
                        .HasColumnType("int");

                    b.Property<int>("Modelo")
                        .HasColumnType("int");

                    b.Property<string>("Placa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeguroCarga")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TecnoMecanica")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CodigoV");

                    b.HasIndex("IdColorNavigationId");

                    b.HasIndex("IdEstadoVehiculoNavigationIdEstadoVehiculo");

                    b.HasIndex("IdMarcaNavigationId");

                    b.HasIndex("IdTipoVehiculoNavigationIdTipoVehiculo");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("NgZorroBack.Usuarios.UsuarioIdentity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Celular")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("IdEstado")
                        .HasColumnType("int");

                    b.Property<int?>("IdEstadoNavigationIdEstadoUsuario")
                        .HasColumnType("int");

                    b.Property<int>("IdGenero")
                        .HasColumnType("int");

                    b.Property<int?>("IdGeneroNavigationIdGenero")
                        .HasColumnType("int");

                    b.Property<int>("IdRol")
                        .HasColumnType("int");

                    b.Property<int?>("IdRolNavigationIdRol")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoDocumento")
                        .HasColumnType("int");

                    b.Property<int?>("IdTipoDocumentoNavigationIdTipoDocumento")
                        .HasColumnType("int");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroDocumento")
                        .HasColumnType("int");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdEstadoNavigationIdEstadoUsuario");

                    b.HasIndex("IdGeneroNavigationIdGenero");

                    b.HasIndex("IdRolNavigationIdRol");

                    b.HasIndex("IdTipoDocumentoNavigationIdTipoDocumento");

                    b.ToTable("UsuariosIdentity");
                });

            modelBuilder.Entity("NgZorroBack.Models.InfoConductore", b =>
                {
                    b.HasOne("NgZorroBack.Models.Vehiculo", "CodigoVNavigation")
                        .WithMany("InfoConductores")
                        .HasForeignKey("CodigoVNavigationCodigoV");

                    b.Navigation("CodigoVNavigation");
                });

            modelBuilder.Entity("NgZorroBack.Models.Servicio", b =>
                {
                    b.HasOne("NgZorroBack.Models.InfoConductore", "IdConductorNavigation")
                        .WithMany("Servicios")
                        .HasForeignKey("IdConductorNavigationIdInfo");

                    b.HasOne("NgZorroBack.Models.EstadoServicio", "IdEstadoServicioNavigation")
                        .WithMany("Servicios")
                        .HasForeignKey("IdEstadoServicioNavigationIdEstadoServicio");

                    b.HasOne("NgZorroBack.Models.TipoCarga", "IdTipoCargaNavigation")
                        .WithMany("Servicios")
                        .HasForeignKey("IdTipoCargaNavigationIdTipoCarga");

                    b.Navigation("IdConductorNavigation");

                    b.Navigation("IdEstadoServicioNavigation");

                    b.Navigation("IdTipoCargaNavigation");
                });

            modelBuilder.Entity("NgZorroBack.Models.Vehiculo", b =>
                {
                    b.HasOne("NgZorroBack.Models.Colore", "IdColorNavigation")
                        .WithMany("Vehiculos")
                        .HasForeignKey("IdColorNavigationId");

                    b.HasOne("NgZorroBack.Models.EstadoVehiculo", "IdEstadoVehiculoNavigation")
                        .WithMany("Vehiculos")
                        .HasForeignKey("IdEstadoVehiculoNavigationIdEstadoVehiculo");

                    b.HasOne("NgZorroBack.Models.Marca", "IdMarcaNavigation")
                        .WithMany("Vehiculos")
                        .HasForeignKey("IdMarcaNavigationId");

                    b.HasOne("NgZorroBack.Models.TipoVehiculo", "IdTipoVehiculoNavigation")
                        .WithMany("Vehiculos")
                        .HasForeignKey("IdTipoVehiculoNavigationIdTipoVehiculo");

                    b.Navigation("IdColorNavigation");

                    b.Navigation("IdEstadoVehiculoNavigation");

                    b.Navigation("IdMarcaNavigation");

                    b.Navigation("IdTipoVehiculoNavigation");
                });

            modelBuilder.Entity("NgZorroBack.Usuarios.UsuarioIdentity", b =>
                {
                    b.HasOne("NgZorroBack.Models.EstadoUsuario", "IdEstadoNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdEstadoNavigationIdEstadoUsuario");

                    b.HasOne("NgZorroBack.Models.Genero", "IdGeneroNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdGeneroNavigationIdGenero");

                    b.HasOne("NgZorroBack.Models.Role", "IdRolNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdRolNavigationIdRol");

                    b.HasOne("NgZorroBack.Models.TipoDocumento", "IdTipoDocumentoNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdTipoDocumentoNavigationIdTipoDocumento");

                    b.Navigation("IdEstadoNavigation");

                    b.Navigation("IdGeneroNavigation");

                    b.Navigation("IdRolNavigation");

                    b.Navigation("IdTipoDocumentoNavigation");
                });

            modelBuilder.Entity("NgZorroBack.Models.Colore", b =>
                {
                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("NgZorroBack.Models.EstadoServicio", b =>
                {
                    b.Navigation("Servicios");
                });

            modelBuilder.Entity("NgZorroBack.Models.EstadoUsuario", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("NgZorroBack.Models.EstadoVehiculo", b =>
                {
                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("NgZorroBack.Models.Genero", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("NgZorroBack.Models.InfoConductore", b =>
                {
                    b.Navigation("Servicios");
                });

            modelBuilder.Entity("NgZorroBack.Models.Marca", b =>
                {
                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("NgZorroBack.Models.Role", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("NgZorroBack.Models.TipoCarga", b =>
                {
                    b.Navigation("Servicios");
                });

            modelBuilder.Entity("NgZorroBack.Models.TipoDocumento", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("NgZorroBack.Models.TipoVehiculo", b =>
                {
                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("NgZorroBack.Models.Vehiculo", b =>
                {
                    b.Navigation("InfoConductores");
                });
#pragma warning restore 612, 618
        }
    }
}
