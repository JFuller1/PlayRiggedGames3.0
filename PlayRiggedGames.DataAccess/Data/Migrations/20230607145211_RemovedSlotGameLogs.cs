using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayRiggedGames.DataAccess.Data.Migrations
{
    public partial class RemovedSlotGameLogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e820885b-8490-4367-8bd6-50440fed5b39",
                column: "ConcurrencyStamp",
                value: "61a64388-b0a0-43df-bdc8-1bea53863692");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eda3e09d-0aaa-4e19-984a-7b511c387a86",
                column: "ConcurrencyStamp",
                value: "7d57e679-cdbb-4f2c-9482-405d271eaffa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dd9ce5d-123d-4831-9087-7f2deab0082f",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 6, 7, 9, 52, 11, 449, DateTimeKind.Local).AddTicks(3614), "ca7c29f4-4341-4142-a074-cba47e966fd1", "AQAAAAEAACcQAAAAEHRvrxbDC5+hfe9pFR9M/6zqUEB5Z4iZ8NR1gVGJQZDapKONRAW56oyfvBahWjvXGg==", "7bf71c9f-8cd0-4d8d-ab21-021332e718ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dd9ce5d-2e8d-4831-9087-7f2deab0082f",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 6, 7, 9, 52, 11, 449, DateTimeKind.Local).AddTicks(3604), "20473e15-cab1-49fb-88d1-b0e132e9bb1f", "AQAAAAEAACcQAAAAEGN3roSoJqVC38whlijOpS49rgmKF0hhhnsRgLKFCsmECO/ShOb8m0pMSrUx8eZwww==", "278aa9bb-b100-46e6-9b5f-3f82dabf7ad0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3e93844-b0c1-4e5b-a308-64353b0208d1",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 6, 7, 9, 52, 11, 449, DateTimeKind.Local).AddTicks(3595), "de549bfb-903e-41d1-b32e-a624b4471f50", "AQAAAAEAACcQAAAAEHAQRWz97bFP7P9MXSKd5egU4pebcoXLR6QJpb0+AijXoKv+mO3hQvj9hqWe4lVk/Q==", "b845482c-dcfd-4e7d-be77-d679b9078d44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d207e04f-7a11-452e-8a48-23bae4fcd12f",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 6, 7, 9, 52, 11, 449, DateTimeKind.Local).AddTicks(3587), "d808391d-44c5-4f16-9d92-015bb65ea6cc", "AQAAAAEAACcQAAAAEGY2Tda9XprJB68YHQa2Dah1ZN3fk7kRPxUJIj1kpcZe0ulV1wjLp3s00lafe/BrxQ==", "bbfade0b-ad74-42dd-8264-d2ff53b3fba4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d68aba42-86f9-45de-b529-c53869d23b1f",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 6, 7, 9, 52, 11, 449, DateTimeKind.Local).AddTicks(3575), "234833ed-9ea2-415c-84db-b1117f651117", "AQAAAAEAACcQAAAAECxRzdvdkOZ76qH3F+V8qg/CpdcDq9lIgFDUTl7dTTY1WKocE80HRmhLI+ma+7JN1Q==", "fcbec56c-7bd2-4fe7-a13c-3f7643bc7ee7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 6, 7, 9, 52, 11, 449, DateTimeKind.Local).AddTicks(3560), "5866d6a0-7a59-4fb0-8899-408dc034bc45", "AQAAAAEAACcQAAAAEDS0qXkRzYeL79QfCDAr2OXu6nAxORKxidaYC9nCeRhJXfz1eGimZfs4BHWQocRcew==", "a1d503cd-cf7e-42e0-b559-1ce71aa2fb44" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e820885b-8490-4367-8bd6-50440fed5b39",
                column: "ConcurrencyStamp",
                value: "a4184efc-5bb2-4a33-8436-41a8140f9b94");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eda3e09d-0aaa-4e19-984a-7b511c387a86",
                column: "ConcurrencyStamp",
                value: "0a69e939-1fc2-4596-afc7-16002ac0e049");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dd9ce5d-123d-4831-9087-7f2deab0082f",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 6, 7, 9, 35, 16, 28, DateTimeKind.Local).AddTicks(6520), "4c220ad0-62d2-470f-badb-5f1699bbbdf2", "AQAAAAEAACcQAAAAEG634pQvYT8E0Y0BqxRhx4xjXxiTSL7YuQ1hDxudTIdEbMLswRpItMwl8i1IE3Rdug==", "c7a39f3d-30e5-445b-850d-6015732c57e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dd9ce5d-2e8d-4831-9087-7f2deab0082f",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 6, 7, 9, 35, 16, 28, DateTimeKind.Local).AddTicks(6512), "2a669fa9-8969-4100-9ad2-99b505a03caf", "AQAAAAEAACcQAAAAEIZY8WlSNn0fYQaZg/6VA3zdGLNl2dN3Xkj4xlyvtg8ov/fTDq3Zy0ZxZ+/jwmxHrA==", "8ac407a1-99be-447f-9cd3-44e355ef4644" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3e93844-b0c1-4e5b-a308-64353b0208d1",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 6, 7, 9, 35, 16, 28, DateTimeKind.Local).AddTicks(6501), "c86bf105-1c13-495a-a2f1-d1a47b8cb94c", "AQAAAAEAACcQAAAAEL7lAe6vstUOyT6lU+2SdXraqiyQL/Tp+MTcpIdSLb18Cs3nxdOvwHScj3WwJxR5Dw==", "1c9439c3-55c0-446c-b9f7-3ab576d9c594" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d207e04f-7a11-452e-8a48-23bae4fcd12f",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 6, 7, 9, 35, 16, 28, DateTimeKind.Local).AddTicks(6492), "8b6c4e59-c8ef-46a4-a68c-65a42e467aa3", "AQAAAAEAACcQAAAAEBR1om5ziUj0woekqXetNqXiXC/GHUs85wRPuGRKegg6imaxo4T+6/IKX7jeTmjyUA==", "2e1ddac3-87c0-4fa0-84f0-5be649e8bbd2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d68aba42-86f9-45de-b529-c53869d23b1f",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 6, 7, 9, 35, 16, 28, DateTimeKind.Local).AddTicks(6483), "d16084af-aaf6-4e25-b50f-4ee04588e923", "AQAAAAEAACcQAAAAEFwcQWCwXqMquwsU1O3oFfy1DshU9lZXp4rzkxIFLJEpyxYAlCDPk0VAGAX7goBK8A==", "b8d5390e-ad8a-4720-8486-133cb885c92a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 6, 7, 9, 35, 16, 28, DateTimeKind.Local).AddTicks(6450), "d37deef5-f09f-4268-a7e8-8ac36715bfcd", "AQAAAAEAACcQAAAAECtOoGHOewgcaE7CgkEV9cbBvpQFNjoBIYJTOP+sFLed0Ksjtia+thjq8WOOGaXlIQ==", "e28dd939-a523-4d5d-9a47-898c78269aea" });

            migrationBuilder.InsertData(
                table: "SlotGameLogs",
                columns: new[] { "Id", "Jackpot", "MoneyInput", "MoneyOutput", "PlayerId", "Time" },
                values: new object[,]
                {
                    { 1, false, 50, 2500, "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce", new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8318) },
                    { 2, false, 200, 8000, "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce", new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8322) },
                    { 3, false, 150, 5000, "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce", new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8326) },
                    { 4, true, 300, 15000, "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce", new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8329) },
                    { 5, false, 1000, 25000, "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce", new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8332) },
                    { 6, false, 100, 5000, "d68aba42-86f9-45de-b529-c53869d23b1f", new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8336) },
                    { 7, false, 200, 10000, "d68aba42-86f9-45de-b529-c53869d23b1f", new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8339) },
                    { 8, false, 150, 7500, "d68aba42-86f9-45de-b529-c53869d23b1f", new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8342) },
                    { 9, true, 300, 15000, "d68aba42-86f9-45de-b529-c53869d23b1f", new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8346) },
                    { 10, false, 250, 12500, "d68aba42-86f9-45de-b529-c53869d23b1f", new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8349) },
                    { 11, false, 100, 5000, "d207e04f-7a11-452e-8a48-23bae4fcd12f", new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8352) },
                    { 12, false, 200, 10000, "d207e04f-7a11-452e-8a48-23bae4fcd12f", new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8356) },
                    { 13, false, 150, 7500, "d207e04f-7a11-452e-8a48-23bae4fcd12f", new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8359) },
                    { 14, true, 300, 15000, "d207e04f-7a11-452e-8a48-23bae4fcd12f", new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8362) },
                    { 15, false, 250, 12500, "d207e04f-7a11-452e-8a48-23bae4fcd12f", new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8366) },
                    { 16, false, 100, 5000, "b3e93844-b0c1-4e5b-a308-64353b0208d1", new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8369) },
                    { 17, false, 200, 10000, "b3e93844-b0c1-4e5b-a308-64353b0208d1", new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8372) },
                    { 18, false, 150, 7500, "b3e93844-b0c1-4e5b-a308-64353b0208d1", new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8376) },
                    { 19, true, 300, 15000, "b3e93844-b0c1-4e5b-a308-64353b0208d1", new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8379) },
                    { 20, false, 250, 12500, "b3e93844-b0c1-4e5b-a308-64353b0208d1", new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8382) },
                    { 21, false, 100, 5000, "0dd9ce5d-2e8d-4831-9087-7f2deab0082f", new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8386) },
                    { 22, false, 200, 10000, "0dd9ce5d-2e8d-4831-9087-7f2deab0082f", new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8389) },
                    { 23, false, 150, 7500, "0dd9ce5d-2e8d-4831-9087-7f2deab0082f", new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8392) },
                    { 24, true, 300, 15000, "0dd9ce5d-2e8d-4831-9087-7f2deab0082f", new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8396) },
                    { 25, false, 250, 12500, "0dd9ce5d-2e8d-4831-9087-7f2deab0082f", new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8399) }
                });
        }
    }
}
