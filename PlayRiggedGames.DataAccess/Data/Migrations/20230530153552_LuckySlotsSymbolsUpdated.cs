using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayRiggedGames.DataAccess.Data.Migrations
{
    public partial class LuckySlotsSymbolsUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e820885b-8490-4367-8bd6-50440fed5b39",
                column: "ConcurrencyStamp",
                value: "86a9b74c-9752-44dd-8b88-4a283d566b2f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eda3e09d-0aaa-4e19-984a-7b511c387a86",
                column: "ConcurrencyStamp",
                value: "d437520d-a0a1-48b3-8570-ebbb3216fcaa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dd9ce5d-2e8d-4831-9087-7f2deab0082f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09f54c25-a300-4cdb-bc8a-45f52c39af4b", "AQAAAAEAACcQAAAAELt4eH8h6+nzRz3hyBMO8SLVa9ikEUskz/xGF7vWg653vqko3zxNlNZAJv31Xe6x6w==", "a4c8bcf8-10eb-45a3-8a93-d87910f2639b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3e93844-b0c1-4e5b-a308-64353b0208d1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77c80b29-f214-4096-b49b-0e8621fd70ca", "AQAAAAEAACcQAAAAEMTqw/8HqZBNDMd75i/F1mCno5ljnG3pn7Rvp9n93uTYoQd5fOLaO6mNoCHVcDwy0w==", "7de7c609-0ecc-490e-963e-57486e5ffdb5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d207e04f-7a11-452e-8a48-23bae4fcd12f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c60a974-6fc6-48bb-b7d3-006b669e5f96", "AQAAAAEAACcQAAAAENvZzwFS9CNUwAFPul2FOSZHzBV953M+Z4zw1/f9bm43MBHrqqSWCYTJVXM2pcdLag==", "bf49c099-17d1-4240-adb3-9ce22e88c536" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d68aba42-86f9-45de-b529-c53869d23b1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90f2bed9-7b07-4769-be8c-cc8681893a95", "AQAAAAEAACcQAAAAEI/xHn/O3OIiIjT+XdVSY24HRtIbS6alHHd7I3Vhovmtr+d9l1MHCQzXWhBvUdUsmA==", "66398a1b-57a4-4e35-9b4f-b25acf8b8300" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "329956f1-ce3c-437d-963e-9ee8c54acdb9", "AQAAAAEAACcQAAAAEErfBpCk6s1KqUVJsehPWQTxrzRn03RJsNzluF3xJp1jSAtfxW8RAbBvBLewvnvChQ==", "80b94200-a6d0-46f3-ba4f-242277d19877" });

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 35, 51, 932, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 35, 51, 932, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 35, 51, 932, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 35, 51, 932, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 35, 51, 932, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 35, 51, 932, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 35, 51, 932, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 8,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 35, 51, 932, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 9,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 35, 51, 932, DateTimeKind.Local).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 10,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 35, 51, 932, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 11,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 35, 51, 932, DateTimeKind.Local).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 12,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 35, 51, 932, DateTimeKind.Local).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 13,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 35, 51, 932, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 14,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 35, 51, 932, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 15,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 35, 51, 932, DateTimeKind.Local).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 16,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 35, 51, 932, DateTimeKind.Local).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 17,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 35, 51, 932, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 18,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 35, 51, 932, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 19,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 35, 51, 932, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 20,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 35, 51, 932, DateTimeKind.Local).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 21,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 35, 51, 932, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 22,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 35, 51, 932, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 23,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 35, 51, 932, DateTimeKind.Local).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 24,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 35, 51, 932, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 25,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 35, 51, 932, DateTimeKind.Local).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Value", "Weight" },
                values: new object[] { 75, 30 });

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 2,
                column: "Value",
                value: 25);

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Value", "Weight" },
                values: new object[] { 75, 30 });

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 4,
                column: "Value",
                value: 30);

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 5,
                column: "Value",
                value: 50);

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Value", "Weight" },
                values: new object[] { 75, 30 });

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 7,
                column: "Value",
                value: 35);

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 8,
                column: "Value",
                value: 40);

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Value", "Weight" },
                values: new object[] { 75, 30 });

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Value", "Weight" },
                values: new object[] { 110, 10 });

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Value", "Weight" },
                values: new object[] { 100, 10 });

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 12,
                column: "Value",
                value: 45);

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Value", "Weight" },
                values: new object[] { 55, 50 });

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Value", "Weight" },
                values: new object[] { 200, 5 });

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Value", "Weight" },
                values: new object[] { 135, 10 });

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 16,
                column: "Value",
                value: 125);

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Value", "Weight" },
                values: new object[] { 175, 5 });

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 19,
                column: "Weight",
                value: 5);

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 20,
                column: "Weight",
                value: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e820885b-8490-4367-8bd6-50440fed5b39",
                column: "ConcurrencyStamp",
                value: "4e626b50-f4bd-4c5c-8911-b605929a894b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eda3e09d-0aaa-4e19-984a-7b511c387a86",
                column: "ConcurrencyStamp",
                value: "da6bfc39-fa76-4fe2-b752-7130d0309191");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dd9ce5d-2e8d-4831-9087-7f2deab0082f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fac147ed-9efd-495f-b7b8-2c561e0473fb", "AQAAAAEAACcQAAAAEI385gRd6egs1P4o7/d77NQBzSbmV4yva+d9k7kIHiPo0CS4vYFgXmJOjsxQN6AI7Q==", "acdf229e-9275-48da-a0db-456d9e96e8bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3e93844-b0c1-4e5b-a308-64353b0208d1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9670787e-420c-4904-8dd7-3285c7c4deda", "AQAAAAEAACcQAAAAEN+VPzXjZBgTridTnFE8WwJRrdTFhaC5pUH+vDyvGosvzUBScbNmdsH5N2Iy6trw3w==", "10958c91-8a49-4bd5-89eb-42305b3ceb3b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d207e04f-7a11-452e-8a48-23bae4fcd12f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1b6f6fb-5429-4a4d-8149-1a819cb61fe9", "AQAAAAEAACcQAAAAEHzg54iaF/BtJC9pMtcCY59RcrZbvUTs+Sbyo9CD1lsnGzeRa94a984Pl3tx8bQXcA==", "6a729885-3816-4e28-ba6f-fbee6f57e904" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d68aba42-86f9-45de-b529-c53869d23b1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3288b11-32f8-4e3c-8852-3a8bc51dc677", "AQAAAAEAACcQAAAAEOSEMDcF96KFTr1hWt7q6D0NtVQXPT2X6mp6UsQDULK2sAyMOeIKeCE43VvjmBByIg==", "f85cd617-6218-4c28-83a2-23d9a5e30c29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02b68bf1-6e46-4b34-b6d5-13baf00c64bf", "AQAAAAEAACcQAAAAEOgZ+HGO/lQRNPL0boBTwmsqi1Z+4oVN7ktzqJ8ZspFSgot6hmBnjjLmIs4LbHaIxQ==", "ce80378f-a8fb-4e38-92e0-1dddccaeea5b" });

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2023, 5, 30, 9, 44, 32, 900, DateTimeKind.Local).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2023, 5, 30, 9, 44, 32, 900, DateTimeKind.Local).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2023, 5, 30, 9, 44, 32, 900, DateTimeKind.Local).AddTicks(6366));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2023, 5, 30, 9, 44, 32, 900, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2023, 5, 30, 9, 44, 32, 900, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2023, 5, 30, 9, 44, 32, 900, DateTimeKind.Local).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2023, 5, 30, 9, 44, 32, 900, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 8,
                column: "Time",
                value: new DateTime(2023, 5, 30, 9, 44, 32, 900, DateTimeKind.Local).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 9,
                column: "Time",
                value: new DateTime(2023, 5, 30, 9, 44, 32, 900, DateTimeKind.Local).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 10,
                column: "Time",
                value: new DateTime(2023, 5, 30, 9, 44, 32, 900, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 11,
                column: "Time",
                value: new DateTime(2023, 5, 30, 9, 44, 32, 900, DateTimeKind.Local).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 12,
                column: "Time",
                value: new DateTime(2023, 5, 30, 9, 44, 32, 900, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 13,
                column: "Time",
                value: new DateTime(2023, 5, 30, 9, 44, 32, 900, DateTimeKind.Local).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 14,
                column: "Time",
                value: new DateTime(2023, 5, 30, 9, 44, 32, 900, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 15,
                column: "Time",
                value: new DateTime(2023, 5, 30, 9, 44, 32, 900, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 16,
                column: "Time",
                value: new DateTime(2023, 5, 30, 9, 44, 32, 900, DateTimeKind.Local).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 17,
                column: "Time",
                value: new DateTime(2023, 5, 30, 9, 44, 32, 900, DateTimeKind.Local).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 18,
                column: "Time",
                value: new DateTime(2023, 5, 30, 9, 44, 32, 900, DateTimeKind.Local).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 19,
                column: "Time",
                value: new DateTime(2023, 5, 30, 9, 44, 32, 900, DateTimeKind.Local).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 20,
                column: "Time",
                value: new DateTime(2023, 5, 30, 9, 44, 32, 900, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 21,
                column: "Time",
                value: new DateTime(2023, 5, 30, 9, 44, 32, 900, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 22,
                column: "Time",
                value: new DateTime(2023, 5, 30, 9, 44, 32, 900, DateTimeKind.Local).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 23,
                column: "Time",
                value: new DateTime(2023, 5, 30, 9, 44, 32, 900, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 24,
                column: "Time",
                value: new DateTime(2023, 5, 30, 9, 44, 32, 900, DateTimeKind.Local).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 25,
                column: "Time",
                value: new DateTime(2023, 5, 30, 9, 44, 32, 900, DateTimeKind.Local).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Value", "Weight" },
                values: new object[] { 5, 50 });

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 2,
                column: "Value",
                value: 5);

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Value", "Weight" },
                values: new object[] { 10, 50 });

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 4,
                column: "Value",
                value: 10);

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 5,
                column: "Value",
                value: 10);

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Value", "Weight" },
                values: new object[] { 15, 50 });

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 7,
                column: "Value",
                value: 15);

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 8,
                column: "Value",
                value: 15);

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Value", "Weight" },
                values: new object[] { 25, 50 });

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Value", "Weight" },
                values: new object[] { 25, 50 });

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Value", "Weight" },
                values: new object[] { 25, 50 });

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 12,
                column: "Value",
                value: 25);

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Value", "Weight" },
                values: new object[] { 25, 20 });

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Value", "Weight" },
                values: new object[] { 50, 20 });

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Value", "Weight" },
                values: new object[] { 50, 20 });

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 16,
                column: "Value",
                value: 150);

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Value", "Weight" },
                values: new object[] { 150, 10 });

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 19,
                column: "Weight",
                value: 3);

            migrationBuilder.UpdateData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 20,
                column: "Weight",
                value: 1);
        }
    }
}
