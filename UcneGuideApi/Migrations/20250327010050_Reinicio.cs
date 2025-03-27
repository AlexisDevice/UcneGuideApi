using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UcneGuideApi.Migrations
{
    /// <inheritdoc />
    public partial class Reinicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comentarios_AspNetUsers_UsuarioId",
                table: "Comentarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Comentarios_Materias_MateriaId",
                table: "Comentarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Sugerencias_AspNetUsers_UsuarioId",
                table: "Sugerencias");

            migrationBuilder.DropIndex(
                name: "IX_Sugerencias_UsuarioId",
                table: "Sugerencias");

            migrationBuilder.DropIndex(
                name: "IX_Comentarios_MateriaId",
                table: "Comentarios");

            migrationBuilder.DropIndex(
                name: "IX_Comentarios_UsuarioId",
                table: "Comentarios");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Sugerencias",
                newName: "SugerenciaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Profesores",
                newName: "ProfesorId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Materias",
                newName: "MateriaId");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.RenameColumn(
                name: "SugerenciaId",
                table: "Sugerencias",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProfesorId",
                table: "Profesores",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MateriaId",
                table: "Materias",
                newName: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Sugerencias_UsuarioId",
                table: "Sugerencias",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_MateriaId",
                table: "Comentarios",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_UsuarioId",
                table: "Comentarios",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comentarios_AspNetUsers_UsuarioId",
                table: "Comentarios",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comentarios_Materias_MateriaId",
                table: "Comentarios",
                column: "MateriaId",
                principalTable: "Materias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sugerencias_AspNetUsers_UsuarioId",
                table: "Sugerencias",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
