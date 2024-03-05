using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManage.web.Data.Migrations
{
    public partial class addeddefaultuserrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "u8421m01-3dc0-0313-be9c-11c79d47mair", "701002ea-b6c4-44d4-bd04-83f03cee08fe", "Administrator", "ADMINISTRATOR" },
                    { "z8421u01-3dc0-0306-be9c-11c79d47bair", "c0d20180-02a5-470c-a072-d522ebf53aeb", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FirstName", "JoiningDate", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d8421d01-3dc0-4374-be9c-11c79d47efea", 0, "1c6f3ed1-7e85-4f78-b5de-b49880552fd6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "khoula007@hotmail.com", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "KHOULA007@HOTMAIL.COM", null, "AQAAAAEAACcQAAAAEOZAQH6H57PDkuybkeikP3oIJhUTK5cZN+Is7yQdrhlGoa/MP1kABnRBybRPgLkbOA==", null, false, "901672ae-36b3-417a-847f-1860bccc3cc7", null, false, null },
                    { "fa369996-9584-46c0-899b-a1992078c015", 0, "bb473e7d-820b-4ebe-b1f1-a17b70cf5ac2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "khoula009@hotmail.com", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "KHOULA009@HOTMAIL.COM", null, "AQAAAAEAACcQAAAAEOAmbOcvPrwL7x/wgvqAMQYgJEEBLrW7/YXGAW2zPbbHonr94eMP/+6GQHaP52X3Sw==", null, false, "fc3cc2f9-90cf-4c2e-b291-5e36b257670b", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "u8421m01-3dc0-0313-be9c-11c79d47mair", "d8421d01-3dc0-4374-be9c-11c79d47efea" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "z8421u01-3dc0-0306-be9c-11c79d47bair", "fa369996-9584-46c0-899b-a1992078c015" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "u8421m01-3dc0-0313-be9c-11c79d47mair", "d8421d01-3dc0-4374-be9c-11c79d47efea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "z8421u01-3dc0-0306-be9c-11c79d47bair", "fa369996-9584-46c0-899b-a1992078c015" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "u8421m01-3dc0-0313-be9c-11c79d47mair");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "z8421u01-3dc0-0306-be9c-11c79d47bair");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8421d01-3dc0-4374-be9c-11c79d47efea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa369996-9584-46c0-899b-a1992078c015");
        }
    }
}
