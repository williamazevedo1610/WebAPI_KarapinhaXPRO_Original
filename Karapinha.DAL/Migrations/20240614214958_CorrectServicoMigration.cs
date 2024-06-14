using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace K.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CorrectServicoMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Servicos",
                newName: "IdServico");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdServico",
                table: "Servicos",
                newName: "MyProperty");
        }
    }
}
