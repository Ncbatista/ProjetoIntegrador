using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoIntegrador.Migrations
{
    /// <inheritdoc />
    public partial class novo2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PontosColeta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Responsavel = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PontosColeta", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PontosColeta");
        }
    }
}
