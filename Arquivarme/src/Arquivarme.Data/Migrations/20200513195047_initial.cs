using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Arquivarme.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Categorias = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    EmpresaId = table.Column<Guid>(nullable: false),
                    Codigo = table.Column<decimal>(maxLength: 10, nullable: false),
                    NomeFantasia = table.Column<string>(nullable: false),
                    InscricaoFederal = table.Column<string>(nullable: false),
                    InscricaoEstadual = table.Column<string>(nullable: false),
                    Endereco = table.Column<string>(nullable: false),
                    Numero = table.Column<decimal>(maxLength: 10, nullable: false),
                    Bairro = table.Column<string>(nullable: false),
                    TelFixo = table.Column<decimal>(maxLength: 15, nullable: false),
                    TelCelular = table.Column<decimal>(maxLength: 15, nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.EmpresaId);
                });

            migrationBuilder.CreateTable(
                name: "Geolocalizacao",
                columns: table => new
                {
                    GeolocalizacaoId = table.Column<Guid>(nullable: false),
                    Pais = table.Column<string>(nullable: false),
                    Estado = table.Column<string>(nullable: false),
                    Sigla = table.Column<string>(nullable: false),
                    Cidade = table.Column<string>(nullable: false),
                    CodigoIBGE = table.Column<decimal>(maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geolocalizacao", x => x.GeolocalizacaoId);
                });

            migrationBuilder.CreateTable(
                name: "TipoMovimento",
                columns: table => new
                {
                    TipoMovimentoId = table.Column<Guid>(nullable: false),
                    Moviento = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoMovimento", x => x.TipoMovimentoId);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<Guid>(nullable: false),
                    CPF = table.Column<decimal>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    Senha = table.Column<string>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "CaixaArquivo",
                columns: table => new
                {
                    CaixaArquivoId = table.Column<Guid>(nullable: false),
                    Entrege = table.Column<bool>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    EmpresaId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaixaArquivo", x => x.CaixaArquivoId);
                    table.ForeignKey(
                        name: "FK_CaixaArquivo_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "EmpresaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CapaArquivo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    EmpresaId = table.Column<Guid>(nullable: false),
                    GeolocalizacaoId = table.Column<Guid>(nullable: false),
                    TipoMovimentoId = table.Column<Guid>(nullable: false),
                    CategoriaId = table.Column<Guid>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataFinal = table.Column<DateTime>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapaArquivo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CapaArquivo_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CapaArquivo_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "EmpresaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CapaArquivo_Geolocalizacao_GeolocalizacaoId",
                        column: x => x.GeolocalizacaoId,
                        principalTable: "Geolocalizacao",
                        principalColumn: "GeolocalizacaoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CapaArquivo_TipoMovimento_TipoMovimentoId",
                        column: x => x.TipoMovimentoId,
                        principalTable: "TipoMovimento",
                        principalColumn: "TipoMovimentoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CaixaArquivo_EmpresaId",
                table: "CaixaArquivo",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_CapaArquivo_CategoriaId",
                table: "CapaArquivo",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_CapaArquivo_EmpresaId",
                table: "CapaArquivo",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_CapaArquivo_GeolocalizacaoId",
                table: "CapaArquivo",
                column: "GeolocalizacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_CapaArquivo_TipoMovimentoId",
                table: "CapaArquivo",
                column: "TipoMovimentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaixaArquivo");

            migrationBuilder.DropTable(
                name: "CapaArquivo");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Geolocalizacao");

            migrationBuilder.DropTable(
                name: "TipoMovimento");
        }
    }
}
