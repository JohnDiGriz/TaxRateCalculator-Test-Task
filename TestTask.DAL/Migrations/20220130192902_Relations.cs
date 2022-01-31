using Microsoft.EntityFrameworkCore.Migrations;

namespace TestTask.DAL.Migrations
{
    public partial class Relations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Taxes_StateId",
                table: "Taxes",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Taxes_VehicleId",
                table: "Taxes",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Fees_StateId",
                table: "Fees",
                column: "StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fees_States_StateId",
                table: "Fees",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Taxes_States_StateId",
                table: "Taxes",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Taxes_Vehicles_VehicleId",
                table: "Taxes",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fees_States_StateId",
                table: "Fees");

            migrationBuilder.DropForeignKey(
                name: "FK_Taxes_States_StateId",
                table: "Taxes");

            migrationBuilder.DropForeignKey(
                name: "FK_Taxes_Vehicles_VehicleId",
                table: "Taxes");

            migrationBuilder.DropIndex(
                name: "IX_Taxes_StateId",
                table: "Taxes");

            migrationBuilder.DropIndex(
                name: "IX_Taxes_VehicleId",
                table: "Taxes");

            migrationBuilder.DropIndex(
                name: "IX_Fees_StateId",
                table: "Fees");
        }
    }
}
