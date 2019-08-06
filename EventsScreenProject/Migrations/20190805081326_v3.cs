using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsScreenProject.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TopPosition",
                table: "TemplateFields",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "LeftPosition",
                table: "TemplateFields",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "EventFields",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "EventFields");

            migrationBuilder.AlterColumn<int>(
                name: "TopPosition",
                table: "TemplateFields",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LeftPosition",
                table: "TemplateFields",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
