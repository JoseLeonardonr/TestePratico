using Microsoft.EntityFrameworkCore.Migrations;

namespace CadastroEstabelecimento.Migrations
{
    public partial class status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Razao",
                table: "Estabelecimentos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cnpj",
                table: "Estabelecimentos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusID",
                table: "Estabelecimentos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusID",
                table: "Estabelecimentos");

            migrationBuilder.AlterColumn<string>(
                name: "Razao",
                table: "Estabelecimentos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Cnpj",
                table: "Estabelecimentos",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
