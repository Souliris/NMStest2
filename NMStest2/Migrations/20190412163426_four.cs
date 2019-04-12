using Microsoft.EntityFrameworkCore.Migrations;

namespace NMStest2.Migrations
{
    public partial class four : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "foreignKey",
                table: "Resource");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "foreignKey",
                table: "Resource",
                nullable: false,
                defaultValue: 0);
        }
    }
}
