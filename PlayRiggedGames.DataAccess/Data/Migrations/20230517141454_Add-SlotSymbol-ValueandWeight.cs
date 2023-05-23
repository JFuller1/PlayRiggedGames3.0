using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayRiggedGames.DataAccess.Data.Migrations
{
    public partial class AddSlotSymbolValueandWeight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8bbec330-3938-449b-a15e-b693af1ebd60");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4bc0032-8b36-4ffa-b33c-c1680ef0a40a");

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "SlotValues",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "SlotValues",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0209a29a-eb37-4996-88f3-f7b43d326e4b", "63d15722-5739-487c-9c4c-89a27d28f0d4", "Admin", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "14952d6e-15fd-4ee3-99f1-6c1f04e536a5", "f2d006a7-3430-4896-9c2f-119635a1aaab", "User", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0209a29a-eb37-4996-88f3-f7b43d326e4b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14952d6e-15fd-4ee3-99f1-6c1f04e536a5");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "SlotValues");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "SlotValues");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8bbec330-3938-449b-a15e-b693af1ebd60", "55b564ad-2e29-4aa1-9b7e-b4f4e6f5007d", "User", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a4bc0032-8b36-4ffa-b33c-c1680ef0a40a", "81420f41-15a9-485c-be7d-c9127ab55a6a", "Admin", null });
        }
    }
}
