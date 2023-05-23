using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayRiggedGames.DataAccess.Data.Migrations
{
    public partial class CreateIdentitySchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1574f7f1-6713-4280-b244-ae0fd61cca24");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d20c3651-07f4-46f5-a6a3-95dfccd24a7f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cbf9d030-abef-424e-b023-b4c825c8fada", "34d1a9f2-2ebd-45bf-9633-ac04605e74ce", "Admin", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ec793163-9eac-4d90-90b7-c20d4246567e", "5f280879-ba4a-4bf4-a4fd-836a2175f855", "User", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbf9d030-abef-424e-b023-b4c825c8fada");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec793163-9eac-4d90-90b7-c20d4246567e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1574f7f1-6713-4280-b244-ae0fd61cca24", "7564e717-9961-4f8e-8ba4-2da2a3f95c3a", "User", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d20c3651-07f4-46f5-a6a3-95dfccd24a7f", "db529f64-6219-463e-bd2e-585dc5683c11", "Admin", null });
        }
    }
}
