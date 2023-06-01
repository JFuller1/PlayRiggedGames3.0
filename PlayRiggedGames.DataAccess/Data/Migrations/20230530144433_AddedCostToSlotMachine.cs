using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayRiggedGames.DataAccess.Data.Migrations
{
    public partial class AddedCostToSlotMachine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cost",
                table: "SlotMachines",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                table: "SlotMachines",
                keyColumn: "Id",
                keyValue: 1,
                column: "Cost",
                value: 5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "SlotMachines");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e820885b-8490-4367-8bd6-50440fed5b39",
                column: "ConcurrencyStamp",
                value: "d2efbd90-6fed-412c-8a82-6a4a25fbd42d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eda3e09d-0aaa-4e19-984a-7b511c387a86",
                column: "ConcurrencyStamp",
                value: "91aa36c9-7b02-47b9-833b-20f67630ecb1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dd9ce5d-2e8d-4831-9087-7f2deab0082f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d63b1a7a-8d80-422f-bd50-42706779884c", "AQAAAAEAACcQAAAAEJc3amqYbtHWJIGL/DDklMCwLDbfFGn6B8lvZEI8yLFmpVmNxJ3DwnLoSV8ulkvw7g==", "e99dec65-b9e9-4017-abf2-4cc9ad231961" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3e93844-b0c1-4e5b-a308-64353b0208d1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e44d43ef-608c-4d1c-8c5b-f8c903b8f929", "AQAAAAEAACcQAAAAEP1lZQOQrY7BhZOcJqNs9sswehcpzqoX6hHUrAefIggJ6UuIuAPLN2ctnxva0V7gVw==", "e7922ad3-6b43-4325-9e77-7914db42a264" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d207e04f-7a11-452e-8a48-23bae4fcd12f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d001c5d2-e129-4352-8fff-71e73a7acbd1", "AQAAAAEAACcQAAAAEHTKTxjwTYdBI1AB5soQcbBCKpQx3M98VWMAvcP6ilLoF2XTVUIPQsnk4axhAGBBQQ==", "599a9cf7-952b-4455-8a5b-32a260d0484f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d68aba42-86f9-45de-b529-c53869d23b1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9df827f-b69b-4c7c-83ff-076d1028ab98", "AQAAAAEAACcQAAAAEEQDZQ9QNMbGttU7PtttsGKZ9cBIh9jDnad2A7xiF0+IxJ2+/TbQNcUh3/mMdP49yw==", "7a4cb742-17d0-4478-ab56-5b9d635126c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0676817-e828-4c57-97d3-8169e2053575", "AQAAAAEAACcQAAAAEOAEApuBjkBseNY9nNpxTEpQSo/0qv1XYSB+FSBDvD3xVJ39IPRR94mBZxs0OW3nzw==", "9a40e74c-fe38-4026-9c5b-b1ae08123b0b" });

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2023, 5, 29, 9, 9, 27, 234, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2023, 5, 29, 9, 9, 27, 234, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2023, 5, 29, 9, 9, 27, 234, DateTimeKind.Local).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2023, 5, 29, 9, 9, 27, 234, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2023, 5, 29, 9, 9, 27, 234, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2023, 5, 29, 9, 9, 27, 234, DateTimeKind.Local).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2023, 5, 29, 9, 9, 27, 234, DateTimeKind.Local).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 8,
                column: "Time",
                value: new DateTime(2023, 5, 29, 9, 9, 27, 234, DateTimeKind.Local).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 9,
                column: "Time",
                value: new DateTime(2023, 5, 29, 9, 9, 27, 234, DateTimeKind.Local).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 10,
                column: "Time",
                value: new DateTime(2023, 5, 29, 9, 9, 27, 234, DateTimeKind.Local).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 11,
                column: "Time",
                value: new DateTime(2023, 5, 29, 9, 9, 27, 234, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 12,
                column: "Time",
                value: new DateTime(2023, 5, 29, 9, 9, 27, 234, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 13,
                column: "Time",
                value: new DateTime(2023, 5, 29, 9, 9, 27, 234, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 14,
                column: "Time",
                value: new DateTime(2023, 5, 29, 9, 9, 27, 234, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 15,
                column: "Time",
                value: new DateTime(2023, 5, 29, 9, 9, 27, 234, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 16,
                column: "Time",
                value: new DateTime(2023, 5, 29, 9, 9, 27, 234, DateTimeKind.Local).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 17,
                column: "Time",
                value: new DateTime(2023, 5, 29, 9, 9, 27, 234, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 18,
                column: "Time",
                value: new DateTime(2023, 5, 29, 9, 9, 27, 234, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 19,
                column: "Time",
                value: new DateTime(2023, 5, 29, 9, 9, 27, 234, DateTimeKind.Local).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 20,
                column: "Time",
                value: new DateTime(2023, 5, 29, 9, 9, 27, 234, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 21,
                column: "Time",
                value: new DateTime(2023, 5, 29, 9, 9, 27, 234, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 22,
                column: "Time",
                value: new DateTime(2023, 5, 29, 9, 9, 27, 234, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 23,
                column: "Time",
                value: new DateTime(2023, 5, 29, 9, 9, 27, 234, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 24,
                column: "Time",
                value: new DateTime(2023, 5, 29, 9, 9, 27, 234, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 25,
                column: "Time",
                value: new DateTime(2023, 5, 29, 9, 9, 27, 234, DateTimeKind.Local).AddTicks(6694));
        }
    }
}
