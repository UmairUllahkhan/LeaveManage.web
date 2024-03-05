using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManage.web.Data.Migrations
{
    public partial class addeddefaultusernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "u8421m01-3dc0-0313-be9c-11c79d47mair",
                column: "ConcurrencyStamp",
                value: "ac5cc70c-e7ed-43dc-90d7-85f155536c9c");

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
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "24298c02-b8c2-40d6-9c1f-686b90766e3d", "KHOULA007@HOTMAIL.COM", "AQAAAAEAACcQAAAAEALGWEQcE02WL6YBVdL2Q0CUQ9YLjgBHG6c3QA2Kpc8IKSKxpDr+ISBnviW4u92xOA==", "4bfd30bf-81f8-4710-bbd4-1aa6f9aef5da", "khoula007@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa369996-9584-46c0-899b-a1992078c015",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c0073442-5b7e-4395-b6f8-d7eba0282373", "KHOULA009@HOTMAIL.COM", "AQAAAAEAACcQAAAAEF1iZF6jqxulCV6LhHv/vtZwGR2aN8Qe8dSpfnq4emACfHLCkPz3noFPhmZKU4O0Jw==", "4af3a5ea-2aeb-43cc-92b8-a874636f55de", "khoula009@hotmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "u8421m01-3dc0-0313-be9c-11c79d47mair",
                column: "ConcurrencyStamp",
                value: "701002ea-b6c4-44d4-bd04-83f03cee08fe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "z8421u01-3dc0-0306-be9c-11c79d47bair",
                column: "ConcurrencyStamp",
                value: "c0d20180-02a5-470c-a072-d522ebf53aeb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8421d01-3dc0-4374-be9c-11c79d47efea",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1c6f3ed1-7e85-4f78-b5de-b49880552fd6", null, "AQAAAAEAACcQAAAAEOZAQH6H57PDkuybkeikP3oIJhUTK5cZN+Is7yQdrhlGoa/MP1kABnRBybRPgLkbOA==", "901672ae-36b3-417a-847f-1860bccc3cc7", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa369996-9584-46c0-899b-a1992078c015",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bb473e7d-820b-4ebe-b1f1-a17b70cf5ac2", null, "AQAAAAEAACcQAAAAEOAmbOcvPrwL7x/wgvqAMQYgJEEBLrW7/YXGAW2zPbbHonr94eMP/+6GQHaP52X3Sw==", "fc3cc2f9-90cf-4c2e-b291-5e36b257670b", null });
        }
    }
}
