using Microsoft.EntityFrameworkCore.Migrations;

namespace Accievent.App.Persistencia.Migrations
{
    public partial class Inicial02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Personas",
                newName: "Id");

            migrationBuilder.CreateTable(
                name: "Accidentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoAccidente = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitud = table.Column<int>(type: "int", nullable: false),
                    Longitud = table.Column<int>(type: "int", nullable: false),
                    Barrio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoAgente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Colision = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Causa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaseDeAccidente = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accidentes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Agentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAgente = table.Column<int>(type: "int", nullable: false),
                    CodigoAgente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agentes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accidentes");

            migrationBuilder.DropTable(
                name: "Agentes");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Personas",
                newName: "id");
        }
    }
}
