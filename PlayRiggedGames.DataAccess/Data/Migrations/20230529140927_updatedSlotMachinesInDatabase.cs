using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayRiggedGames.DataAccess.Data.Migrations
{
    public partial class updatedSlotMachinesInDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastLogin",
                table: "AspNetUsers");

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

            migrationBuilder.UpdateData(
                table: "SlotMachines",
                keyColumn: "Id",
                keyValue: 1,
                column: "Width",
                value: 5);

            migrationBuilder.InsertData(
                table: "SlotMachines",
                columns: new[] { "Id", "Height", "Name", "OutOfOrder", "Width" },
                values: new object[] { 2, 5, "Daily Spin", false, 7 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SlotMachines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastLogin",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e820885b-8490-4367-8bd6-50440fed5b39",
                column: "ConcurrencyStamp",
                value: "f8faf82d-c1a4-4ba0-ae48-1ddc66284061");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eda3e09d-0aaa-4e19-984a-7b511c387a86",
                column: "ConcurrencyStamp",
                value: "88706e7a-ce0f-47b0-ae6d-8b8b75103018");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dd9ce5d-2e8d-4831-9087-7f2deab0082f",
                columns: new[] { "ConcurrencyStamp", "LastLogin", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3abee90c-1f7e-4776-b07e-3fd6b9dd3dc6", new DateTime(2023, 5, 23, 10, 29, 28, 399, DateTimeKind.Local).AddTicks(9039), "AQAAAAEAACcQAAAAEE2/sGnZ3+bD/MABOAHFsWbQrYrUz3HY+uXhD0VD4rUoaaz4rnlwk1WU5rwbsetqrw==", "683a5054-b3cc-40eb-b122-03d9be8ee752" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3e93844-b0c1-4e5b-a308-64353b0208d1",
                columns: new[] { "ConcurrencyStamp", "LastLogin", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc65aece-86e3-496b-8379-039b026ff5cf", new DateTime(2023, 5, 23, 10, 29, 28, 399, DateTimeKind.Local).AddTicks(9032), "AQAAAAEAACcQAAAAENyngs6GihN2IedGGXK2RwOgRuPEyajGSo3+JGQjwRr2sMppzAskecQJoNsdJMIhJQ==", "faf60533-7bd3-4cde-a194-3181b7219114" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d207e04f-7a11-452e-8a48-23bae4fcd12f",
                columns: new[] { "ConcurrencyStamp", "LastLogin", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5988ca7-69f0-40d4-8581-084b470a7f94", new DateTime(2023, 5, 23, 10, 29, 28, 399, DateTimeKind.Local).AddTicks(9024), "AQAAAAEAACcQAAAAECHrdkYUyPqOy+9OwgobFX4Erm2dEhDxqgE5TXzCayV1OtibQ3+DheEJqiVQjL7K9g==", "49771250-d469-4fe5-b9b5-9b04fa0a2085" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d68aba42-86f9-45de-b529-c53869d23b1f",
                columns: new[] { "ConcurrencyStamp", "LastLogin", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a64ac197-0cd3-409a-bf64-fcd5960bd0e8", new DateTime(2023, 5, 23, 10, 29, 28, 399, DateTimeKind.Local).AddTicks(9014), "AQAAAAEAACcQAAAAEDKAH7bqLy5NdWmv9DDda2Dc/If88AO1/tmdL17qTzNqkxrNPs2zWU+D0mNBu3hz8Q==", "83b6acf7-f9e9-4a8d-9311-6d27fedc22d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce",
                columns: new[] { "ConcurrencyStamp", "LastLogin", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5e3ce66-6009-48db-a50f-126b377b42b3", new DateTime(2023, 5, 23, 10, 29, 28, 399, DateTimeKind.Local).AddTicks(8996), "AQAAAAEAACcQAAAAEJacxHgK8tnIdgsgeKMDRFzFwBhqR7npnWMjlCcXjOTODxV6KQnVOLUpibLLbJmWbA==", "aba290cd-8ece-49b0-aede-1646750292ea" });

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 8,
                column: "Time",
                value: new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 9,
                column: "Time",
                value: new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 10,
                column: "Time",
                value: new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 11,
                column: "Time",
                value: new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 12,
                column: "Time",
                value: new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 13,
                column: "Time",
                value: new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 14,
                column: "Time",
                value: new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 15,
                column: "Time",
                value: new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 16,
                column: "Time",
                value: new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 17,
                column: "Time",
                value: new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3106));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 18,
                column: "Time",
                value: new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 19,
                column: "Time",
                value: new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 20,
                column: "Time",
                value: new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 21,
                column: "Time",
                value: new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3117));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 22,
                column: "Time",
                value: new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 23,
                column: "Time",
                value: new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 24,
                column: "Time",
                value: new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 25,
                column: "Time",
                value: new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "SlotMachines",
                keyColumn: "Id",
                keyValue: 1,
                column: "Width",
                value: 3);
        }
    }
}
