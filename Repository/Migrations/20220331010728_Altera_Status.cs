using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Altera_Status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "TIPO",
                table: "STATUS");

            migrationBuilder.AddColumn<string>(
                name: "TYPE",
                table: "STATUS",
                nullable: true);

            migrationBuilder.Sql(@"INSERT INTO STATUS
                                    (DESCRIPTION, TYPE) 
                                   VALUES
						            ('Nova','TA'),
                                    ('Em Andamento','TA'),
                                    ('Impedida','TA'),
                                    ('Concluída','TA'),
                                    ('Bloqueada','TA'),
                                    ('Excluir','TA')");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TYPE",
                table: "STATUS");

            migrationBuilder.AddColumn<string>(
                name: "TIPO",
                table: "STATUS",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
