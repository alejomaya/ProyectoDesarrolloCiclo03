using Microsoft.EntityFrameworkCore.Migrations;

namespace Accievent.App.Persistencia.Migrations
{
    public partial class Init08 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Personas_PersonaId",
                table: "Vehiculos");

            migrationBuilder.RenameColumn(
                name: "PersonaId",
                table: "Vehiculos",
                newName: "ConductorId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehiculos_PersonaId",
                table: "Vehiculos",
                newName: "IX_Vehiculos_ConductorId");

            migrationBuilder.AddColumn<string>(
                name: "CiudadResidencia",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Diagnostico",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdConductor",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdVictima",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumeroPase",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AgenteDeTransitoId",
                table: "Accidentes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehiculoId",
                table: "Accidentes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VictimaId",
                table: "Accidentes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Accidentes_AgenteDeTransitoId",
                table: "Accidentes",
                column: "AgenteDeTransitoId");

            migrationBuilder.CreateIndex(
                name: "IX_Accidentes_VehiculoId",
                table: "Accidentes",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Accidentes_VictimaId",
                table: "Accidentes",
                column: "VictimaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accidentes_Personas_AgenteDeTransitoId",
                table: "Accidentes",
                column: "AgenteDeTransitoId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Accidentes_Personas_VictimaId",
                table: "Accidentes",
                column: "VictimaId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Accidentes_Vehiculos_VehiculoId",
                table: "Accidentes",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Personas_ConductorId",
                table: "Vehiculos",
                column: "ConductorId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accidentes_Personas_AgenteDeTransitoId",
                table: "Accidentes");

            migrationBuilder.DropForeignKey(
                name: "FK_Accidentes_Personas_VictimaId",
                table: "Accidentes");

            migrationBuilder.DropForeignKey(
                name: "FK_Accidentes_Vehiculos_VehiculoId",
                table: "Accidentes");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Personas_ConductorId",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Accidentes_AgenteDeTransitoId",
                table: "Accidentes");

            migrationBuilder.DropIndex(
                name: "IX_Accidentes_VehiculoId",
                table: "Accidentes");

            migrationBuilder.DropIndex(
                name: "IX_Accidentes_VictimaId",
                table: "Accidentes");

            migrationBuilder.DropColumn(
                name: "CiudadResidencia",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Diagnostico",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "IdConductor",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "IdVictima",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "NumeroPase",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "AgenteDeTransitoId",
                table: "Accidentes");

            migrationBuilder.DropColumn(
                name: "VehiculoId",
                table: "Accidentes");

            migrationBuilder.DropColumn(
                name: "VictimaId",
                table: "Accidentes");

            migrationBuilder.RenameColumn(
                name: "ConductorId",
                table: "Vehiculos",
                newName: "PersonaId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehiculos_ConductorId",
                table: "Vehiculos",
                newName: "IX_Vehiculos_PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Personas_PersonaId",
                table: "Vehiculos",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
