using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayRiggedGames.DataAccess.Data.Migrations
{
    public partial class AddedSampleBlackListedUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e820885b-8490-4367-8bd6-50440fed5b39",
                column: "ConcurrencyStamp",
                value: "445dc940-0954-43c7-ba95-cd55241a65ac");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eda3e09d-0aaa-4e19-984a-7b511c387a86",
                column: "ConcurrencyStamp",
                value: "e6f60242-c4e5-4959-95e1-7b8517203777");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dd9ce5d-2e8d-4831-9087-7f2deab0082f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9fe2aad7-f71d-48e2-a1e4-4b78cbb21edb", "AQAAAAEAACcQAAAAEAacvUQJrriDUmskxV35aTxT1XWDIE3otgYIOe2601aq3hQllHBmoJ6UQ6QDHDQ3Ug==", "4a505021-ab5c-46d9-87f5-c87e142fbb1a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3e93844-b0c1-4e5b-a308-64353b0208d1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7707c2b-31f0-4b2d-9ef3-1f25cf1dd0ac", "AQAAAAEAACcQAAAAEMO6LpH7rHUhyAkaGJICxVKbewGaPLEPAPH1tTUFxtBmzvbCGhgF9Vr+wlEFEVtvnw==", "d272f31a-0d91-474c-8c9a-027cfedfd3df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d207e04f-7a11-452e-8a48-23bae4fcd12f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45743549-5ee6-444c-861e-886b317bff29", "AQAAAAEAACcQAAAAEMPcP45IXACf16twcp8aC5mKj2Q9z+Eg1xjB2r1ulwpBhpSLcuKdlR8wkmP1jHPqLg==", "78e7e2c9-f613-4dae-919a-20a34d8031b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d68aba42-86f9-45de-b529-c53869d23b1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48e64c17-5b05-4ed2-97b8-ec167226a329", "AQAAAAEAACcQAAAAEHD3MVMDyhABlxY0ndyPAQr9DECMyvJTb5tGh30UEXG019SSk+9ZrwG4lSDFSo7PZg==", "2d10061a-a21f-4c48-8c74-cbb4d4ba60f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60d1be7c-9002-40b7-b1c0-ed81bedce127", "AQAAAAEAACcQAAAAEGc5yvPXnuzlHjwhAUDdU90vl87GHwRF204ouzG50x6OqR9wDjHLqtgQ3g2SHaJ42Q==", "8ec42af0-cb25-4fc8-98ca-211c49495fa8" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BlackListed", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Money", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0dd9ce5d-123d-4831-9087-7f2deab0082f", 0, new DateTime(1905, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "ece2c73b-0f9f-4b38-8cc9-478ac0776d44", "exoimple@hotmail.com", true, "Evil", "Jaeden", false, null, 200, null, "EVILZABLOO", "AQAAAAEAACcQAAAAEIhdBgDdMySDmjPjvdnj91fHEbtFTy81wkrlSdHoUnof0uxbpaxNsYaWxf8xKkhDAA==", null, false, "46ac99d8-321b-4037-82c5-4f1048b216ae", false, "EvilZabloo" });

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 46, 41, 476, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 46, 41, 476, DateTimeKind.Local).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 46, 41, 476, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 46, 41, 476, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 46, 41, 476, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 46, 41, 476, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 46, 41, 476, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 8,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 46, 41, 476, DateTimeKind.Local).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 9,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 46, 41, 476, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 10,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 46, 41, 476, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 11,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 46, 41, 476, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 12,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 46, 41, 476, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 13,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 46, 41, 476, DateTimeKind.Local).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 14,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 46, 41, 476, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 15,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 46, 41, 476, DateTimeKind.Local).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 16,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 46, 41, 476, DateTimeKind.Local).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 17,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 46, 41, 476, DateTimeKind.Local).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 18,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 46, 41, 476, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 19,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 46, 41, 476, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 20,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 46, 41, 476, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 21,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 46, 41, 476, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 22,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 46, 41, 476, DateTimeKind.Local).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 23,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 46, 41, 476, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 24,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 46, 41, 476, DateTimeKind.Local).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 25,
                column: "Time",
                value: new DateTime(2023, 5, 30, 10, 46, 41, 476, DateTimeKind.Local).AddTicks(7026));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dd9ce5d-123d-4831-9087-7f2deab0082f");

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
        }
    }
}
