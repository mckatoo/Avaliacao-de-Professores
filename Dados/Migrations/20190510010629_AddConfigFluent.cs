using Microsoft.EntityFrameworkCore.Migrations;

namespace Dados.Migrations
{
    public partial class AddConfigFluent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Anos_AnoId",
                table: "Cursos");

            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Disciplinas_DisciplinaId",
                table: "Cursos");

            migrationBuilder.DropIndex(
                name: "IX_Cursos_AnoId",
                table: "Cursos");

            migrationBuilder.DropIndex(
                name: "IX_Cursos_DisciplinaId",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "AnoId",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "DisciplinaId",
                table: "Cursos");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Professores",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Disciplinas",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CursoId",
                table: "Disciplinas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CursoId",
                table: "Anos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_CursoId",
                table: "Disciplinas",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Anos_CursoId",
                table: "Anos",
                column: "CursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Anos_Cursos_CursoId",
                table: "Anos",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplinas_Cursos_CursoId",
                table: "Disciplinas",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Anos_Cursos_CursoId",
                table: "Anos");

            migrationBuilder.DropForeignKey(
                name: "FK_Disciplinas_Cursos_CursoId",
                table: "Disciplinas");

            migrationBuilder.DropIndex(
                name: "IX_Disciplinas_CursoId",
                table: "Disciplinas");

            migrationBuilder.DropIndex(
                name: "IX_Anos_CursoId",
                table: "Anos");

            migrationBuilder.DropColumn(
                name: "CursoId",
                table: "Disciplinas");

            migrationBuilder.DropColumn(
                name: "CursoId",
                table: "Anos");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Professores",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Disciplinas",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AddColumn<int>(
                name: "AnoId",
                table: "Cursos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DisciplinaId",
                table: "Cursos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_AnoId",
                table: "Cursos",
                column: "AnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_DisciplinaId",
                table: "Cursos",
                column: "DisciplinaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Anos_AnoId",
                table: "Cursos",
                column: "AnoId",
                principalTable: "Anos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Disciplinas_DisciplinaId",
                table: "Cursos",
                column: "DisciplinaId",
                principalTable: "Disciplinas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
