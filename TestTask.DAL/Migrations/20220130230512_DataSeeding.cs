using Microsoft.EntityFrameworkCore.Migrations;

namespace TestTask.DAL.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Coefficient",
                table: "Taxes",
                type: "float",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { 1, "CA" },
                    { 2, "NY" },
                    { 3, "FL" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Passenger" },
                    { 2, "Truck" },
                    { 3, "Trailer" }
                });

            migrationBuilder.InsertData(
                table: "Fees",
                columns: new[] { "Id", "FeeValue", "StateId", "Zipcode" },
                values: new object[,]
                {
                    { 1, 100, 1, "90011" },
                    { 15, 115, 3, "32009" },
                    { 14, 98, 3, "32008" },
                    { 13, 64, 3, "32007" },
                    { 11, 36, 3, "32004" },
                    { 10, 96, 2, "10005" },
                    { 9, 84, 2, "10004" },
                    { 12, 58, 3, "32006" },
                    { 7, 140, 2, "10002" },
                    { 6, 80, 2, "10001" },
                    { 5, 90, 1, "91331" },
                    { 4, 110, 1, "90650" },
                    { 3, 130, 1, "90201" },
                    { 2, 120, 1, "90044" },
                    { 8, 70, 2, "10003" }
                });

            migrationBuilder.InsertData(
                table: "Taxes",
                columns: new[] { "Id", "Coefficient", "StateId", "VehicleId" },
                values: new object[,]
                {
                    { 6, 1.5, 2, 3 },
                    { 1, 1.05, 1, 1 },
                    { 4, 0.90000000000000002, 2, 1 },
                    { 7, 1.1000000000000001, 3, 1 },
                    { 2, 1.2, 1, 2 },
                    { 5, 1.5, 2, 2 },
                    { 8, 1.5, 3, 2 },
                    { 3, 1.25, 1, 3 },
                    { 9, null, 3, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Fees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Fees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Fees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Fees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Fees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Fees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Fees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Fees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Fees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Fees",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Fees",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Fees",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Fees",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Taxes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Taxes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Taxes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Taxes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Taxes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Taxes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Taxes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Taxes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Taxes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<float>(
                name: "Coefficient",
                table: "Taxes",
                type: "real",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);
        }
    }
}
