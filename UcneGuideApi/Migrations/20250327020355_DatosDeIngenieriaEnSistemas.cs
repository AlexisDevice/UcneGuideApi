using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UcneGuideApi.Migrations
{
    /// <inheritdoc />
    public partial class DatosDeIngenieriaEnSistemas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Materias",
                columns: new[] { "MateriaId", "CarreraId", "Codigo", "Descripcion", "Nombre", "ProfesorId" },
                values: new object[,]
                {
                    { 1, 1, "HUM-111", "Muy buen", "Lengua Española y Técnica de Expresión I", 1 },
                    { 2, 1, "MAT-125", "Muy buen", "Precalculo", 2 },
                    { 3, 1, "HUM-123", "Muy buen", "Filosofía", 3 },
                    { 4, 1, "QMA-117", "Muy buen", "Química I", 4 },
                    { 5, 1, "QMA-118", "Muy buen", "Laboratorio de Química I", 5 },
                    { 6, 1, "FIS-136", "Muy buen", "Física I", 6 },
                    { 7, 1, "FIS-137", "Muy buen", "Laboratorio Física I", 7 },
                    { 8, 1, "ORI-116", "Muy buen", "Orientación Académica", 8 },
                    { 9, 1, "HUM-121", "Muy buen", "Lengua Española y Técnica de Expresión II", 9 },
                    { 10, 1, "FIS-230", "Muy buen", "Física II", 10 },
                    { 11, 1, "FIS-231", "Muy buen", "Laboratorio Física II", 11 },
                    { 12, 1, "MAT-140", "Muy buen", "Cálculo Diferencial", 12 },
                    { 13, 1, "ISC-201", "Muy buen", "Introducción a la Ingeniería en Sistemas", 13 },
                    { 14, 1, "ISC-202", "Muy buen", "Laboratorio Introducción a la Ingeniería en Sistemas", 14 },
                    { 15, 1, "ISC-203", "Muy buen", "Estructuras Discretas", 15 },
                    { 16, 1, "ISC-204", "Muy buen", "Doctrina Social de la Iglesia", 16 },
                    { 17, 1, "ISC-205", "Muy buen", "Calculo Integral", 17 },
                    { 18, 1, "MAT-141", "Muy buen", "Fisica III", 18 },
                    { 19, 1, "ISC-206", "Muy buen", "Laboratorio de Fisica III", 19 },
                    { 20, 1, "ISC-207", "Muy buen", "Tecnica de Programacion", 20 },
                    { 21, 1, "ISC-208", "Muy buen", "Laboratorio de Tecnica de Programacion", 21 },
                    { 22, 1, "ISC-209", "Muy buen", "Actividad Cocurricular", 22 },
                    { 23, 1, "ISC-210", "Muy buen", "Educacion En Valores", 23 },
                    { 24, 1, "ISC-211", "Muy buen", "Metodologia de la Investigacion", 24 },
                    { 25, 1, "ISC-212", "Muy buen", "Contabilidad General", 25 },
                    { 26, 1, "ISC-213", "Muy buen", "Calculo Vectorial", 26 },
                    { 27, 1, "ISC-214", "Muy buen", "Programacion I", 27 },
                    { 28, 1, "ISC-215", "Muy buen", "Laboratorio de Programacion I", 28 },
                    { 29, 1, "ISC-216", "Muy buen", "Estructura de Datos", 29 },
                    { 30, 1, "ISC-217", "Muy buen", "Ecologia y preservacion del medio ambiente", 30 },
                    { 31, 1, "ISC-218", "Muy buen", "Algebra Lineal", 31 },
                    { 32, 1, "ISC-219", "Muy buen", "Electronica Aplicada", 32 },
                    { 33, 1, "ISC-220", "Muy buen", "Analisis de sistemas", 33 },
                    { 34, 1, "ISC-221", "Muy buen", "Programacion II", 34 },
                    { 35, 1, "ISC-222", "Muy buen", "Laboratorio de Programacion II", 35 },
                    { 36, 1, "ISC-223", "Muy buen", "Sistemas Operativos", 36 },
                    { 37, 1, "ISC-224", "Muy buen", "Laboratorios Sistemas Operativos", 37 },
                    { 38, 1, "ISC-225", "Muy buen", "Principios de seguridad informatica", 38 },
                    { 39, 1, "ISC-226", "Muy buen", "Probabilidad y estadistica", 39 },
                    { 40, 1, "ISC-227", "Muy buen", "Base de Datos I", 40 },
                    { 41, 1, "ISC-228", "Muy buen", "Laboratorio Base de Datos I", 41 },
                    { 42, 1, "ISC-229", "Muy buen", "Arquitectura del Computador", 42 },
                    { 43, 1, "ISC-230", "Muy buen", "Programacion III", 43 },
                    { 44, 1, "ISC-231", "Muy buen", "Laboratorio Programacion III", 44 },
                    { 45, 1, "ISC-232", "Muy buen", "Ecuaciones Diferenciales", 45 },
                    { 46, 1, "ISC-233", "Muy buen", "Diseño de Sistemas", 46 },
                    { 47, 1, "ISC-234", "Muy buen", "Proyecto Aplicado", 47 },
                    { 48, 1, "ISC-235", "Muy buen", "Mantenimiento del Hadware", 48 },
                    { 49, 1, "ISC-236", "Muy buen", "Teleproceso y Redes", 49 },
                    { 50, 1, "ISC-237", "Muy buen", "Laboratorio de teleproceso y redes", 50 },
                    { 51, 1, "ISC-238", "Muy buen", "Programacion Aplicada I", 51 },
                    { 52, 1, "ISC-239", "Muy buen", "Laboratorio Programacion Aplicada I", 52 },
                    { 53, 1, "ISC-241", "Muy buen", "Pasantia I", 53 },
                    { 54, 1, "ISC-242", "Muy buen", "Ingenieria Econimica", 53 },
                    { 55, 1, "ISC-243", "Muy buen", "Organizacion y Administracion de sistemas", 53 },
                    { 56, 1, "ISC-244", "Muy buen", "Base de Datos II", 53 },
                    { 57, 1, "ISC-245", "Muy buen", "laboratorio de Base de Datos II", 53 },
                    { 58, 1, "ISC-246", "Muy buen", "Programacion Aplicada I", 53 },
                    { 59, 1, "ISC-247", "Muy buen", "Computacion Centrada en Redes", 53 },
                    { 60, 1, "ISC-248", "Muy buen", "Simulacion Digital", 53 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 60);
        }
    }
}
