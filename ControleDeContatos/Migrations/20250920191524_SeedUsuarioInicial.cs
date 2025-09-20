using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace ControleDeContatos.Migrations
{
    public partial class SeedUsuarioInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Nome", "Login", "Email", "Perfil", "Senha", "DataCadastro" },
                values: new object[] { "Jeiel", "jeiel", "jeiel@email.com", 1, "7c4a8d09ca3762af61e59520943dc26494f8941b", DateTime.Now }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Login",
                keyValue: "jeiel"
            );
        }
    }
}
