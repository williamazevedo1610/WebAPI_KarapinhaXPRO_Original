using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace K.DAL.Migrations
{
    /// <inheritdoc />
    public partial class TableOfProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Horarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Perfis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servicos",
                columns: table => new
                {
                    MyProperty = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preco = table.Column<double>(type: "float", nullable: false),
                    CategoriaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicos", x => x.MyProperty);
                    table.ForeignKey(
                        name: "FK_Servicos_Categorias_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Utilizadors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefone = table.Column<int>(type: "int", nullable: true),
                    Fotografia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BilheteIden = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PerfilID = table.Column<int>(type: "int", nullable: true),
                    Activar = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilizadors", x => x.id);
                    table.ForeignKey(
                        name: "FK_Utilizadors_Perfis_PerfilID",
                        column: x => x.PerfilID,
                        principalTable: "Perfis",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Profissionals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefone = table.Column<int>(type: "int", nullable: false),
                    Fotografia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BilheteIden = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServicoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profissionals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profissionals_Servicos_ServicoID",
                        column: x => x.ServicoID,
                        principalTable: "Servicos",
                        principalColumn: "MyProperty",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Marcacaos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataRegisto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPagar = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Perfil = table.Column<int>(type: "int", nullable: true),
                    UtilizadorID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcacaos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Marcacaos_Utilizadors_UtilizadorID",
                        column: x => x.UtilizadorID,
                        principalTable: "Utilizadors",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "ProfissionalsHorarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfissionalID = table.Column<int>(type: "int", nullable: false),
                    HorarioID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfissionalsHorarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfissionalsHorarios_Horarios_HorarioID",
                        column: x => x.HorarioID,
                        principalTable: "Horarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfissionalsHorarios_Profissionals_ProfissionalID",
                        column: x => x.ProfissionalID,
                        principalTable: "Profissionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServicoMarcacaos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServicoId = table.Column<int>(type: "int", nullable: false),
                    MarcacaoId = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hora = table.Column<TimeOnly>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicoMarcacaos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServicoMarcacaos_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ServicoMarcacaos_Marcacaos_MarcacaoId",
                        column: x => x.MarcacaoId,
                        principalTable: "Marcacaos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServicoMarcacaos_Servicos_ServicoId",
                        column: x => x.ServicoId,
                        principalTable: "Servicos",
                        principalColumn: "MyProperty",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Marcacaos_UtilizadorID",
                table: "Marcacaos",
                column: "UtilizadorID");

            migrationBuilder.CreateIndex(
                name: "IX_Profissionals_ServicoID",
                table: "Profissionals",
                column: "ServicoID");

            migrationBuilder.CreateIndex(
                name: "IX_ProfissionalsHorarios_HorarioID",
                table: "ProfissionalsHorarios",
                column: "HorarioID");

            migrationBuilder.CreateIndex(
                name: "IX_ProfissionalsHorarios_ProfissionalID",
                table: "ProfissionalsHorarios",
                column: "ProfissionalID");

            migrationBuilder.CreateIndex(
                name: "IX_ServicoMarcacaos_CategoriaId",
                table: "ServicoMarcacaos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicoMarcacaos_MarcacaoId",
                table: "ServicoMarcacaos",
                column: "MarcacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicoMarcacaos_ServicoId",
                table: "ServicoMarcacaos",
                column: "ServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_CategoriaID",
                table: "Servicos",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_Utilizadors_PerfilID",
                table: "Utilizadors",
                column: "PerfilID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfissionalsHorarios");

            migrationBuilder.DropTable(
                name: "ServicoMarcacaos");

            migrationBuilder.DropTable(
                name: "Horarios");

            migrationBuilder.DropTable(
                name: "Profissionals");

            migrationBuilder.DropTable(
                name: "Marcacaos");

            migrationBuilder.DropTable(
                name: "Servicos");

            migrationBuilder.DropTable(
                name: "Utilizadors");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Perfis");
        }
    }
}
