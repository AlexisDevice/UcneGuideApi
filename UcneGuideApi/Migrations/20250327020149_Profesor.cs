using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UcneGuideApi.Migrations
{
    /// <inheritdoc />
    public partial class Profesor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfesorId",
                table: "Materias",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfesorId",
                table: "Materias");
        }
    }
}
