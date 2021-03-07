using Microsoft.EntityFrameworkCore.Migrations;

namespace CadastroEstabelecimento.Migrations
{
    public partial class CategoriaForeignKey2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estabelecimentos_Categorias_CategoriasId",
                table: "Estabelecimentos");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Estabelecimentos");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriasId",
                table: "Estabelecimentos",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Estabelecimentos_Categorias_CategoriasId",
                table: "Estabelecimentos",
                column: "CategoriasId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estabelecimentos_Categorias_CategoriasId",
                table: "Estabelecimentos");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriasId",
                table: "Estabelecimentos",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Estabelecimentos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Estabelecimentos_Categorias_CategoriasId",
                table: "Estabelecimentos",
                column: "CategoriasId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
