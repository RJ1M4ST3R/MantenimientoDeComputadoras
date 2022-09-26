using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManteCompu.App.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CitasServicios",
                columns: table => new
                {
                    idCitasServicios = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idServicio = table.Column<int>(type: "int", nullable: false),
                    idCitas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitasServicios", x => x.idCitasServicios);
                });

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    idServicio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preciode = table.Column<float>(type: "real", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicios", x => x.idServicio);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    idUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipoIdentificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numeroIdentificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    eMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipoUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estadoUsuario = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.idUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Administrador",
                columns: table => new
                {
                    idAdmin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuarioidUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrador", x => x.idAdmin);
                    table.ForeignKey(
                        name: "FK_Administrador_Usuario_usuarioidUsuario",
                        column: x => x.usuarioidUsuario,
                        principalTable: "Usuario",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    idCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuarioidUsuario = table.Column<int>(type: "int", nullable: false),
                    Rut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    formaPago = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.idCliente);
                    table.ForeignKey(
                        name: "FK_Cliente_Usuario_usuarioidUsuario",
                        column: x => x.usuarioidUsuario,
                        principalTable: "Usuario",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tecnico",
                columns: table => new
                {
                    idTecnico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nivelEstudio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numeroRegistro = table.Column<int>(type: "int", nullable: false),
                    usuarioidUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnico", x => x.idTecnico);
                    table.ForeignKey(
                        name: "FK_Tecnico_Usuario_usuarioidUsuario",
                        column: x => x.usuarioidUsuario,
                        principalTable: "Usuario",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Citas",
                columns: table => new
                {
                    idCitas = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Horario = table.Column<TimeSpan>(type: "time", nullable: false),
                    clienteidCliente = table.Column<int>(type: "int", nullable: false),
                    tecnicoidTecnico = table.Column<int>(type: "int", nullable: false),
                    administradoridAdmin = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    totalServicio = table.Column<float>(type: "real", nullable: false),
                    Comision = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citas", x => x.idCitas);
                    table.ForeignKey(
                        name: "FK_Citas_Administrador_administradoridAdmin",
                        column: x => x.administradoridAdmin,
                        principalTable: "Administrador",
                        principalColumn: "idAdmin",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citas_Cliente_clienteidCliente",
                        column: x => x.clienteidCliente,
                        principalTable: "Cliente",
                        principalColumn: "idCliente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citas_Tecnico_tecnicoidTecnico",
                        column: x => x.tecnicoidTecnico,
                        principalTable: "Tecnico",
                        principalColumn: "idTecnico",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Administrador_usuarioidUsuario",
                table: "Administrador",
                column: "usuarioidUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_administradoridAdmin",
                table: "Citas",
                column: "administradoridAdmin");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_clienteidCliente",
                table: "Citas",
                column: "clienteidCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_tecnicoidTecnico",
                table: "Citas",
                column: "tecnicoidTecnico");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_usuarioidUsuario",
                table: "Cliente",
                column: "usuarioidUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Tecnico_usuarioidUsuario",
                table: "Tecnico",
                column: "usuarioidUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Citas");

            migrationBuilder.DropTable(
                name: "CitasServicios");

            migrationBuilder.DropTable(
                name: "Servicios");

            migrationBuilder.DropTable(
                name: "Administrador");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Tecnico");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
