using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class FixedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0525a50-ba2c-416d-a243-89af13ebbcfb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb8bbc26-fe3b-478d-856f-03344be0d61c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "59821eec-67bb-4827-991c-9561ff6c30a3", "ee59f087-bbcb-4c90-b714-c4628ad1d34d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "76fe6687-9b77-4db7-af67-817079e1f08d", "8c3a2cee-f210-4467-a721-8eea60e116db", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59821eec-67bb-4827-991c-9561ff6c30a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76fe6687-9b77-4db7-af67-817079e1f08d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cb8bbc26-fe3b-478d-856f-03344be0d61c", "9501d223-e992-4d4f-b2c8-df203017a7f6", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a0525a50-ba2c-416d-a243-89af13ebbcfb", "a2a13691-891d-4e56-98ae-1a1389a04566", "Admin", "ADMIN" });
        }
    }
}
