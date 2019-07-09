using Microsoft.EntityFrameworkCore.Migrations;

namespace WebClinic.Migrations
{
    public partial class RelatorioConsulta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Relatorio",
                table: "Consulta",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Relatorio",
                table: "Consulta");
        }
    }
}
