using Microsoft.EntityFrameworkCore.Migrations;

namespace PontosTuristicos.Migrations
{
    public partial class segundaMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PontoTuristico",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cidade = table.Column<string>(nullable: false),
                    Estado = table.Column<string>(maxLength: 2, nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    Referencia = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PontoTuristico", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PontoTuristico");
        }
    }
}
