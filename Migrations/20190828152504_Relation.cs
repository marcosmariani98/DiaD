using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoApi.Migrations
{
    public partial class Relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "descripcion",
                table: "Productos",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "descripcion",
                table: "Categorias",
                newName: "Descripcion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Productos",
                newName: "descripcion");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Categorias",
                newName: "descripcion");
        }
    }
}
