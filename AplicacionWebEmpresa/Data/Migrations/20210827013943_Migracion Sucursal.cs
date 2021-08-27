using Microsoft.EntityFrameworkCore.Migrations;

namespace AplicacionWebEmpresa.Data.Migrations
{
    public partial class MigracionSucursal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sucursal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false).Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    Telefono = table.Column<string>(nullable: true),
                    Ciudad = table.Column<string>(nullable: false),
                    Empleados = table.Column<int>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursal", x => x.Id);
                }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
