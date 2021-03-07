using Microsoft.EntityFrameworkCore.Migrations;

namespace CadastroEstabelecimento.Migrations
{
    public partial class CategoriaForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Estabelecimentos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Estabelecimentos");
        }
    }
}
