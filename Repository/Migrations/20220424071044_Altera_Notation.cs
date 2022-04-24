using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Altera_Notation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ATTACH_T_NOTATION_AnnotationidAnnotation",
                table: "ATTACH_T");

            migrationBuilder.DropForeignKey(
                name: "FK_NOTATION_PROJECT_ID_PROJECT",
                table: "NOTATION");

            migrationBuilder.DropForeignKey(
                name: "FK_NOTATION_USER_ID_USER",
                table: "NOTATION");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NOTATION",
                table: "NOTATION");

            migrationBuilder.RenameTable(
                name: "NOTATION",
                newName: "ANNOTATION");

            migrationBuilder.RenameColumn(
                name: "ID_NOTATION",
                table: "ANNOTATION",
                newName: "ID_ANNOTATION");

            migrationBuilder.RenameIndex(
                name: "IX_NOTATION_ID_USER",
                table: "ANNOTATION",
                newName: "IX_ANNOTATION_ID_USER");

            migrationBuilder.RenameIndex(
                name: "IX_NOTATION_ID_PROJECT",
                table: "ANNOTATION",
                newName: "IX_ANNOTATION_ID_PROJECT");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ANNOTATION",
                table: "ANNOTATION",
                column: "ID_ANNOTATION");

            migrationBuilder.AddForeignKey(
                name: "FK_ANNOTATION_PROJECT_ID_PROJECT",
                table: "ANNOTATION",
                column: "ID_PROJECT",
                principalTable: "PROJECT",
                principalColumn: "ID_PROJECT",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ANNOTATION_USER_ID_USER",
                table: "ANNOTATION",
                column: "ID_USER",
                principalTable: "USER",
                principalColumn: "ID_USER",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ATTACH_T_ANNOTATION_AnnotationidAnnotation",
                table: "ATTACH_T",
                column: "AnnotationidAnnotation",
                principalTable: "ANNOTATION",
                principalColumn: "ID_ANNOTATION",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ANNOTATION_PROJECT_ID_PROJECT",
                table: "ANNOTATION");

            migrationBuilder.DropForeignKey(
                name: "FK_ANNOTATION_USER_ID_USER",
                table: "ANNOTATION");

            migrationBuilder.DropForeignKey(
                name: "FK_ATTACH_T_ANNOTATION_AnnotationidAnnotation",
                table: "ATTACH_T");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ANNOTATION",
                table: "ANNOTATION");

            migrationBuilder.RenameTable(
                name: "ANNOTATION",
                newName: "NOTATION");

            migrationBuilder.RenameColumn(
                name: "ID_ANNOTATION",
                table: "NOTATION",
                newName: "ID_NOTATION");

            migrationBuilder.RenameIndex(
                name: "IX_ANNOTATION_ID_USER",
                table: "NOTATION",
                newName: "IX_NOTATION_ID_USER");

            migrationBuilder.RenameIndex(
                name: "IX_ANNOTATION_ID_PROJECT",
                table: "NOTATION",
                newName: "IX_NOTATION_ID_PROJECT");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NOTATION",
                table: "NOTATION",
                column: "ID_NOTATION");

            migrationBuilder.AddForeignKey(
                name: "FK_ATTACH_T_NOTATION_AnnotationidAnnotation",
                table: "ATTACH_T",
                column: "AnnotationidAnnotation",
                principalTable: "NOTATION",
                principalColumn: "ID_NOTATION",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NOTATION_PROJECT_ID_PROJECT",
                table: "NOTATION",
                column: "ID_PROJECT",
                principalTable: "PROJECT",
                principalColumn: "ID_PROJECT",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NOTATION_USER_ID_USER",
                table: "NOTATION",
                column: "ID_USER",
                principalTable: "USER",
                principalColumn: "ID_USER",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
