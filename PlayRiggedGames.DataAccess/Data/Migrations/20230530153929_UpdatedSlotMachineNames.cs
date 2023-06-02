using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayRiggedGames.DataAccess.Data.Migrations
{
    public partial class UpdatedSlotMachineNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e820885b-8490-4367-8bd6-50440fed5b39",
                column: "ConcurrencyStamp",
                value: "a87a9a7b-58fb-4228-97f2-d91c15b611d1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eda3e09d-0aaa-4e19-984a-7b511c387a86",
                column: "ConcurrencyStamp",
                value: "c4a57f4f-ec60-407b-97c5-0d73a43659fc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dd9ce5d-2e8d-4831-9087-7f2deab0082f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7684e9ad-2a48-4df0-a2e7-c1df4fb163f6", "AQAAAAEAACcQAAAAEK4tQIhwLToR3OoBXYbHR+n6cvrjkqtb1aUZFwB+YVPEPmBwtGPXZ4RTaeqMz2nkAg==", "9fafd339-4256-4941-8b38-c55fb52e67ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3e93844-b0c1-4e5b-a308-64353b0208d1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1b18425-4e95-4d00-8ee5-583a11062724", "AQAAAAEAACcQAAAAEEcHbBvNwgJunmhu2Nr2dO+a2Qqq6eX0IveF22OVk3gkw0Zuzw3F86gsmMx8qku6uw==", "3e401ac2-9313-4e13-b68b-0e916135dd90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d207e04f-7a11-452e-8a48-23bae4fcd12f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8782eca0-9f78-4ff7-929a-3c93f5ff3266", "AQAAAAEAACcQAAAAEOu/kf8Efj/q/+udP1deuq2TJ5UJo0c/1o/thAGMQo5oFasH7a4KyyhA959z7xvkWw==", "4338f7d7-6f34-4a5d-8c95-8bc7a9c76a52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d68aba42-86f9-45de-b529-c53869d23b1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28a1f5c5-510e-4679-b08f-c031473c311d", "AQAAAAEAACcQAAAAEPp1sHCX7c4kGiWLvsgfem7156AcXonPLtQOOYLy9VFllp7C8c3yMAbLPshbUcdk0g==", "79bcb873-2f7c-49be-addc-4bf39a043a02" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4532a40-a091-48e7-a251-7f5d667adfa9", "AQAAAAEAACcQAAAAEOMaBnD9SmzaRqwvcdaMYQVXxzY5GQ5gaXoTgPIKs6bZ9NPKBLUBTF+/Uc+H0HAcqw==", "f3bf8691-a201-4846-80a0-bab3e898159b" });

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 39, 28, 590, DateTimeKind.Local).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 39, 28, 590, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 39, 28, 590, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 39, 28, 590, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 39, 28, 590, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 39, 28, 590, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 39, 28, 590, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 8,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 39, 28, 590, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 9,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 39, 28, 590, DateTimeKind.Local).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 10,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 39, 28, 590, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 11,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 39, 28, 590, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 12,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 39, 28, 590, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 13,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 39, 28, 590, DateTimeKind.Local).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 14,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 39, 28, 590, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 15,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 39, 28, 590, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 16,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 39, 28, 590, DateTimeKind.Local).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 17,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 39, 28, 590, DateTimeKind.Local).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 18,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 39, 28, 590, DateTimeKind.Local).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 19,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 39, 28, 590, DateTimeKind.Local).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 20,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 39, 28, 590, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 21,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 39, 28, 590, DateTimeKind.Local).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 22,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 39, 28, 590, DateTimeKind.Local).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 23,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 39, 28, 590, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 24,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 39, 28, 590, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 25,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 39, 28, 590, DateTimeKind.Local).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "SlotMachines",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "LuckySlots");

            migrationBuilder.UpdateData(
                table: "SlotMachines",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "DailySpin");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "SlotMachines",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Lucky Slots");

            migrationBuilder.UpdateData(
                table: "SlotMachines",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Daily Spin");
        }
    }
}
