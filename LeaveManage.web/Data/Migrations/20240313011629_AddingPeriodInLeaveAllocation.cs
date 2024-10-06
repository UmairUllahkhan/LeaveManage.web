using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManage.web.Data.Migrations
{
    public partial class AddingPeriodInLeaveAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "u8421m01-3dc0-0313-be9c-11c79d47mair",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3c584115-a78a-4035-a2bf-22c8adecbf00", "Adminsitrator", "ADMINSITRATOR" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "u8421m01-3dc0-0313-be9c-11c79d47mair",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ac5cc70c-e7ed-43dc-90d7-85f155536c9c", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "z8421u01-3dc0-0306-be9c-11c79d47bair",
                column: "ConcurrencyStamp",
                value: "211fdec8-201b-490a-b8a0-116483739d8a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8421d01-3dc0-4374-be9c-11c79d47efea",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24298c02-b8c2-40d6-9c1f-686b90766e3d", "AQAAAAEAACcQAAAAEALGWEQcE02WL6YBVdL2Q0CUQ9YLjgBHG6c3QA2Kpc8IKSKxpDr+ISBnviW4u92xOA==", "4bfd30bf-81f8-4710-bbd4-1aa6f9aef5da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa369996-9584-46c0-899b-a1992078c015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0073442-5b7e-4395-b6f8-d7eba0282373", "AQAAAAEAACcQAAAAEF1iZF6jqxulCV6LhHv/vtZwGR2aN8Qe8dSpfnq4emACfHLCkPz3noFPhmZKU4O0Jw==", "4af3a5ea-2aeb-43cc-92b8-a874636f55de" });
        }
    }
}
