﻿// <auto-generated />
using System;
using ManteCompu.App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ManteCompu.App.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ManteCompu.App.Models.Administrador", b =>
                {
                    b.Property<int>("idAdmin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idAdmin"), 1L, 1);

                    b.Property<int>("usuarioidUsuario")
                        .HasColumnType("int");

                    b.HasKey("idAdmin");

                    b.HasIndex("usuarioidUsuario");

                    b.ToTable("Administrador");
                });

            modelBuilder.Entity("ManteCompu.App.Models.Citas", b =>
                {
                    b.Property<int>("idCitas")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idCitas"), 1L, 1);

                    b.Property<float>("Comision")
                        .HasColumnType("real");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("Horario")
                        .HasColumnType("time");

                    b.Property<int>("administradoridAdmin")
                        .HasColumnType("int");

                    b.Property<int>("clienteidCliente")
                        .HasColumnType("int");

                    b.Property<int>("tecnicoidTecnico")
                        .HasColumnType("int");

                    b.Property<float>("totalServicio")
                        .HasColumnType("real");

                    b.HasKey("idCitas");

                    b.HasIndex("administradoridAdmin");

                    b.HasIndex("clienteidCliente");

                    b.HasIndex("tecnicoidTecnico");

                    b.ToTable("Citas");
                });

            modelBuilder.Entity("ManteCompu.App.Models.CitasServicios", b =>
                {
                    b.Property<int>("idCitasServicios")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idCitasServicios"), 1L, 1);

                    b.Property<int>("idCitas")
                        .HasColumnType("int");

                    b.Property<int>("idServicio")
                        .HasColumnType("int");

                    b.HasKey("idCitasServicios");

                    b.ToTable("CitasServicios");
                });

            modelBuilder.Entity("ManteCompu.App.Models.Cliente", b =>
                {
                    b.Property<int>("idCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idCliente"), 1L, 1);

                    b.Property<string>("Rut")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("formaPago")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("usuarioidUsuario")
                        .HasColumnType("int");

                    b.HasKey("idCliente");

                    b.HasIndex("usuarioidUsuario");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("ManteCompu.App.Models.Servicio", b =>
                {
                    b.Property<int>("idServicio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idServicio"), 1L, 1);

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Preciode")
                        .HasColumnType("real");

                    b.HasKey("idServicio");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("ManteCompu.App.Models.Tecnico", b =>
                {
                    b.Property<int>("idTecnico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idTecnico"), 1L, 1);

                    b.Property<string>("nivelEstudio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numeroRegistro")
                        .HasColumnType("int");

                    b.Property<int>("usuarioidUsuario")
                        .HasColumnType("int");

                    b.HasKey("idTecnico");

                    b.HasIndex("usuarioidUsuario");

                    b.ToTable("Tecnico");
                });

            modelBuilder.Entity("ManteCompu.App.Models.Usuario", b =>
                {
                    b.Property<int>("idUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idUsuario"), 1L, 1);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("estadoUsuario")
                        .HasColumnType("bit");

                    b.Property<DateTime>("fechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("numeroIdentificacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipoIdentificacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipoUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idUsuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ManteCompu.App.Models.Administrador", b =>
                {
                    b.HasOne("ManteCompu.App.Models.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("usuarioidUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("ManteCompu.App.Models.Citas", b =>
                {
                    b.HasOne("ManteCompu.App.Models.Administrador", "administrador")
                        .WithMany()
                        .HasForeignKey("administradoridAdmin")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ManteCompu.App.Models.Cliente", "cliente")
                        .WithMany()
                        .HasForeignKey("clienteidCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ManteCompu.App.Models.Tecnico", "tecnico")
                        .WithMany()
                        .HasForeignKey("tecnicoidTecnico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("administrador");

                    b.Navigation("cliente");

                    b.Navigation("tecnico");
                });

            modelBuilder.Entity("ManteCompu.App.Models.Cliente", b =>
                {
                    b.HasOne("ManteCompu.App.Models.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("usuarioidUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("ManteCompu.App.Models.Tecnico", b =>
                {
                    b.HasOne("ManteCompu.App.Models.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("usuarioidUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("usuario");
                });
#pragma warning restore 612, 618
        }
    }
}