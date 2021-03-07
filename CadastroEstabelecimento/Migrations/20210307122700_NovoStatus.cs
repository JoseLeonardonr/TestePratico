using Microsoft.EntityFrameworkCore.Migrations;

namespace CadastroEstabelecimento.Migrations
{
    public partial class NovoStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusID",
                table: "Estabelecimentos");

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Estabelecimentos",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Estabelecimentos",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<int>(
                name: "StatusID",
                table: "Estabelecimentos",
                nullable: false,
                defaultValue: 0);
        }
    }
}
