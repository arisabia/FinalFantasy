using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalFantasy.RepositoryEF.Migrations
{
    public partial class IntialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arma",
                columns: table => new
                {
                    Nome = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PuntiDanno = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arma", x => x.Nome);
                });

            migrationBuilder.CreateTable(
                name: "Gamer",
                columns: table => new
                {
                    NickName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gamer", x => x.NickName);
                });

            migrationBuilder.CreateTable(
                name: "Personaggio",
                columns: table => new
                {
                    Nome = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false),
                    PuntiVita = table.Column<int>(type: "int", nullable: false),
                    Livello = table.Column<int>(type: "int", nullable: false),
                    ArmaNome = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    personnagio_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoEroe = table.Column<int>(type: "int", nullable: true),
                    PuntiLivello = table.Column<int>(type: "int", nullable: true),
                    NickNameGamer = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TipoMostro = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personaggio", x => x.Nome);
                    table.ForeignKey(
                        name: "FK_Personaggio_Arma_ArmaNome",
                        column: x => x.ArmaNome,
                        principalTable: "Arma",
                        principalColumn: "Nome",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personaggio_Gamer_NickNameGamer",
                        column: x => x.NickNameGamer,
                        principalTable: "Gamer",
                        principalColumn: "NickName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personaggio_ArmaNome",
                table: "Personaggio",
                column: "ArmaNome");

            migrationBuilder.CreateIndex(
                name: "IX_Personaggio_NickNameGamer",
                table: "Personaggio",
                column: "NickNameGamer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personaggio");

            migrationBuilder.DropTable(
                name: "Arma");

            migrationBuilder.DropTable(
                name: "Gamer");
        }
    }
}
