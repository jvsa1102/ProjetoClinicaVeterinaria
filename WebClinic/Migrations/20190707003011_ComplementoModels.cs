using Microsoft.EntityFrameworkCore.Migrations;

namespace WebClinic.Migrations
{
    public partial class ComplementoModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Proprietario",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Proprietario",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Proprietario",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Medico",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Medico",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Especialidade",
                table: "Medico",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Especializacoes",
                table: "Medico",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Medico",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cor",
                table: "Animal",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PesoAproximado",
                table: "Animal",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Porte",
                table: "Animal",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Proprietario");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Proprietario");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Proprietario");

            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Medico");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Medico");

            migrationBuilder.DropColumn(
                name: "Especialidade",
                table: "Medico");

            migrationBuilder.DropColumn(
                name: "Especializacoes",
                table: "Medico");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Medico");

            migrationBuilder.DropColumn(
                name: "Cor",
                table: "Animal");

            migrationBuilder.DropColumn(
                name: "PesoAproximado",
                table: "Animal");

            migrationBuilder.DropColumn(
                name: "Porte",
                table: "Animal");
        }
    }
}
