using Microsoft.EntityFrameworkCore.Migrations;

namespace TestTask.DAL.Migrations
{
    public partial class AddNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Coefficient",
                table: "Taxes",
                type: "real",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "real");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Coefficient",
                table: "Taxes",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "real",
                oldNullable: true);
        }
    }
}
