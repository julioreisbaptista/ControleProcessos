using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleProcessos.Migrations
{
    /// <inheritdoc />
    public partial class ajuste4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Processo_Processo_ProcessoId",
                table: "Processo");

            migrationBuilder.DropIndex(
                name: "IX_Processo_ProcessoId",
                table: "Processo");

            migrationBuilder.DropColumn(
                name: "ProcessoId",
                table: "Processo");

            migrationBuilder.AddColumn<string>(
                name: "Subprocessos",
                table: "Processo",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subprocessos",
                table: "Processo");

            migrationBuilder.AddColumn<int>(
                name: "ProcessoId",
                table: "Processo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Processo_ProcessoId",
                table: "Processo",
                column: "ProcessoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Processo_Processo_ProcessoId",
                table: "Processo",
                column: "ProcessoId",
                principalTable: "Processo",
                principalColumn: "Id");
        }
    }
}
