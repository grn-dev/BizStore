using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructures.Dal.Migrations
{
    public partial class order2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "lasteName",
                table: "Orders",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "lasteName",
                table: "Orders");
        }
    }
}
