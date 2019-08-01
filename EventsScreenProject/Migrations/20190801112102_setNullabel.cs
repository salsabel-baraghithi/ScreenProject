using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsScreenProject.Migrations
{
    public partial class setNullabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "TemplateId",
                table: "TemplateFields",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<long>(
                name: "EventId",
                table: "EventFields",
                nullable: true,
                oldClrType: typeof(long));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "TemplateId",
                table: "TemplateFields",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "EventId",
                table: "EventFields",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);
        }
    }
}
