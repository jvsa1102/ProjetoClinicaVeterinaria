using Microsoft.EntityFrameworkCore.Migrations;

namespace WebClinic.Migrations
{
    public partial class CustoCorrecao001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Custo",
                table: "TipoProcedimento",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Custo",
                table: "TipoProcedimento",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");
        }
    }
}
