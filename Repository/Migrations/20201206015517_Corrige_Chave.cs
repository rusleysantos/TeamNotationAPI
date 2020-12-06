using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Corrige_Chave : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_User_IDADDRESS",
                table: "User",
                column: "IDADDRESS");

            migrationBuilder.CreateIndex(
                name: "IX_User_IDPROFILE",
                table: "User",
                column: "IDPROFILE");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Address_IDADDRESS",
                table: "User",
                column: "IDADDRESS",
                principalTable: "Address",
                principalColumn: "IDADDRESS",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Profile_IDPROFILE",
                table: "User",
                column: "IDPROFILE",
                principalTable: "Profile",
                principalColumn: "IDPROFILE",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Address_IDADDRESS",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Profile_IDPROFILE",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_IDADDRESS",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_IDPROFILE",
                table: "User");
        }
    }
}
