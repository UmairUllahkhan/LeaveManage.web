using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManage.web.Data.Migrations
{
    public partial class changedatatype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "u8421m01-3dc0-0313-be9c-11c79d47mair",
                column: "ConcurrencyStamp",
                value: "6e746f87-0cfb-4efd-a7b8-d6705092b3e7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "z8421u01-3dc0-0306-be9c-11c79d47bair",
                column: "ConcurrencyStamp",
                value: "26503da3-30b6-4dda-a741-8ec04d3b02ab");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8421d01-3dc0-4374-be9c-11c79d47efea",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c8e74c0-353e-4877-875a-5f1a2442f019", "AQAAAAEAACcQAAAAEDBMjjhA1alQxGEamIw4AQRubxVsaWN3hg4BibzS60473pdD1yC+GwIS0h/rmfgpzQ==", "62ad8804-56c1-47ca-838b-b007382a0480" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa369996-9584-46c0-899b-a1992078c015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52120aca-b79b-4ed6-a920-32207bcb535d", "AQAAAAEAACcQAAAAEGb/bdGTr/OPBiB+SUy/jljPog3nL61uJ217vhItcQXRzCzuimdB/PKmZ+WBJl9E+w==", "31f7bf28-0878-4c4f-9730-fc41eb618e6d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "u8421m01-3dc0-0313-be9c-11c79d47mair",
                column: "ConcurrencyStamp",
                value: "3c584115-a78a-4035-a2bf-22c8adecbf00");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "z8421u01-3dc0-0306-be9c-11c79d47bair",
                column: "ConcurrencyStamp",
                value: "bfc04c44-d9af-4647-9902-47de4507d261");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8421d01-3dc0-4374-be9c-11c79d47efea",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7a9c922-a57d-4bcc-9227-5adfb92be871", "AQAAAAEAACcQAAAAEGMEOGRdkuqUvpVRgRTQzGe9Nl75x2xpXHSOPBiKYB/7v3mhyUCh8JfdzTQvJk9Yag==", "ace15179-a06e-4c95-96e5-6e5381910a7c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa369996-9584-46c0-899b-a1992078c015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e025b8f1-743d-4503-ac5a-1cb961acce3e", "AQAAAAEAACcQAAAAEGzxkl0EChhcv6/L0GLYX9TP02yTRWbRkTqHpL4jI59ShF8dOjUg6j4+/fy7qlf5ew==", "a4a3c009-4245-47b9-9822-8ece5c479d9d" });
        }
    }
}
