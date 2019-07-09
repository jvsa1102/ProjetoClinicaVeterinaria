using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebClinic.Migrations
{
    public partial class ExamesConsultasNav002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consulta",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataRealizacao = table.Column<DateTime>(nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    Custo = table.Column<decimal>(nullable: false),
                    AnimalID = table.Column<int>(nullable: false),
                    MedicoID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consulta", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Consulta_Animal_AnimalID",
                        column: x => x.AnimalID,
                        principalTable: "Animal",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consulta_Medico_MedicoID",
                        column: x => x.MedicoID,
                        principalTable: "Medico",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exame",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataRealizacao = table.Column<DateTime>(nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    Custo = table.Column<decimal>(nullable: false),
                    AnimalID = table.Column<int>(nullable: false),
                    MedicoID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exame", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Exame_Animal_AnimalID",
                        column: x => x.AnimalID,
                        principalTable: "Animal",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exame_Medico_MedicoID",
                        column: x => x.MedicoID,
                        principalTable: "Medico",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_AnimalID",
                table: "Consulta",
                column: "AnimalID");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_MedicoID",
                table: "Consulta",
                column: "MedicoID");

            migrationBuilder.CreateIndex(
                name: "IX_Exame_AnimalID",
                table: "Exame",
                column: "AnimalID");

            migrationBuilder.CreateIndex(
                name: "IX_Exame_MedicoID",
                table: "Exame",
                column: "MedicoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consulta");

            migrationBuilder.DropTable(
                name: "Exame");
        }
    }
}
