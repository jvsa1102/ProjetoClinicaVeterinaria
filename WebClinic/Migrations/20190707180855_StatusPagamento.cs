using Microsoft.EntityFrameworkCore.Migrations;

namespace WebClinic.Migrations
{
    public partial class StatusPagamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Pagamento",
                table: "Procedimento",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Procedimento",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Pagamento",
                table: "Exame",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Exame",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Pagamento",
                table: "Consulta",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Consulta",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pagamento",
                table: "Procedimento");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Procedimento");

            migrationBuilder.DropColumn(
                name: "Pagamento",
                table: "Exame");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Exame");

            migrationBuilder.DropColumn(
                name: "Pagamento",
                table: "Consulta");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Consulta");
        }
    }
}
