using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class VerificaRelacionamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "qntVitoria",
                table: "RegistroDePartidas",
                newName: "QntVitoria");

            migrationBuilder.RenameColumn(
                name: "qntPartida",
                table: "RegistroDePartidas",
                newName: "QntPartida");

            migrationBuilder.RenameColumn(
                name: "qntEmpate",
                table: "RegistroDePartidas",
                newName: "QntEmpate");

            migrationBuilder.RenameColumn(
                name: "qntDerrota",
                table: "RegistroDePartidas",
                newName: "QntDerrota");

            migrationBuilder.RenameColumn(
                name: "telCadastro",
                table: "Cadastros",
                newName: "TelCadastro");

            migrationBuilder.RenameColumn(
                name: "senhaCadastro",
                table: "Cadastros",
                newName: "SenhaCadastro");

            migrationBuilder.RenameColumn(
                name: "nomeCadastro",
                table: "Cadastros",
                newName: "NomeCadastro");

            migrationBuilder.RenameColumn(
                name: "nickname",
                table: "Cadastros",
                newName: "Nickname");

            migrationBuilder.RenameColumn(
                name: "emailCadastro",
                table: "Cadastros",
                newName: "EmailCadastro");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QntVitoria",
                table: "RegistroDePartidas",
                newName: "qntVitoria");

            migrationBuilder.RenameColumn(
                name: "QntPartida",
                table: "RegistroDePartidas",
                newName: "qntPartida");

            migrationBuilder.RenameColumn(
                name: "QntEmpate",
                table: "RegistroDePartidas",
                newName: "qntEmpate");

            migrationBuilder.RenameColumn(
                name: "QntDerrota",
                table: "RegistroDePartidas",
                newName: "qntDerrota");

            migrationBuilder.RenameColumn(
                name: "TelCadastro",
                table: "Cadastros",
                newName: "telCadastro");

            migrationBuilder.RenameColumn(
                name: "SenhaCadastro",
                table: "Cadastros",
                newName: "senhaCadastro");

            migrationBuilder.RenameColumn(
                name: "NomeCadastro",
                table: "Cadastros",
                newName: "nomeCadastro");

            migrationBuilder.RenameColumn(
                name: "Nickname",
                table: "Cadastros",
                newName: "nickname");

            migrationBuilder.RenameColumn(
                name: "EmailCadastro",
                table: "Cadastros",
                newName: "emailCadastro");
        }
    }
}
