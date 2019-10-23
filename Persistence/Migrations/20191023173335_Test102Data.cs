using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class Test102Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Values",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 10, 23, 12, 33, 34, 984, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 10, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2019, 10, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Date", "LastName", "Name" },
                values: new object[] { 4, new DateTime(2019, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "Larsson", "Sam" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Date", "LastName", "Name" },
                values: new object[] { 5, new DateTime(2019, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "June", "Julian" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Values");
        }
    }
}
