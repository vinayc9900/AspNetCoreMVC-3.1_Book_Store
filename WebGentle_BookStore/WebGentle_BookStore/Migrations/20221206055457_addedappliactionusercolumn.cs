using Microsoft.EntityFrameworkCore.Migrations;

namespace WebGentle_BookStore.Migrations
{
    public partial class addedappliactionusercolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastNAme",
                table: "AspNetUsers",
                newName: "LastName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AspNetUsers",
                newName: "LastNAme");
        }
    }
}
