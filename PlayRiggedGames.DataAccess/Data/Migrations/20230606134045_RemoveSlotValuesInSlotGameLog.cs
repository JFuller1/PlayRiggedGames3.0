using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayRiggedGames.DataAccess.Data.Migrations
{
    public partial class RemoveSlotValuesInSlotGameLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e820885b-8490-4367-8bd6-50440fed5b39",
                column: "ConcurrencyStamp",
                value: "ed1a9081-80b0-41d6-adbf-e8aeca5eee9f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eda3e09d-0aaa-4e19-984a-7b511c387a86",
                column: "ConcurrencyStamp",
                value: "b024d320-08d7-42d3-ba09-7c8864a8d4d3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dd9ce5d-123d-4831-9087-7f2deab0082f",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 6, 6, 8, 40, 44, 717, DateTimeKind.Local).AddTicks(5152), "4b76faf1-58f8-4c56-8165-2751c598d2da", "AQAAAAEAACcQAAAAEOnh4bCJs2SHnxZnANDCbQHUDhrFn2x5sPnhm7ekJ71MoQyuDse26xNNXi28609O0A==", "23e2451f-e5a8-4a37-ab77-00fea4fb75e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dd9ce5d-2e8d-4831-9087-7f2deab0082f",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 6, 6, 8, 40, 44, 717, DateTimeKind.Local).AddTicks(5145), "6cad3148-3866-45e8-8c10-7b6f967863ec", "AQAAAAEAACcQAAAAECkFOpLuFG9E0DhjmLXUDokfA82JfQ+B0h8nA/eY+9i/qmSJReRV3/yg2yTuvBJ9eA==", "d086ce93-7073-418b-b12c-e25c00b9b897" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3e93844-b0c1-4e5b-a308-64353b0208d1",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 6, 6, 8, 40, 44, 717, DateTimeKind.Local).AddTicks(5135), "5c528433-8abf-4b78-892b-f1e858ba9069", "AQAAAAEAACcQAAAAECONvlyMcHZU4PvGyVttHi1i0sLwM7OSVHwbf4NRYujzSGnlHxnZsyIv1xUHL+z76Q==", "2b8efb3a-9307-4679-a6f0-cecb4e5f3095" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d207e04f-7a11-452e-8a48-23bae4fcd12f",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 6, 6, 8, 40, 44, 717, DateTimeKind.Local).AddTicks(5127), "e9d2e48b-0d12-4b41-bcfe-459f513931ea", "AQAAAAEAACcQAAAAEA8S13yqYKzKlRXsPlUd5/004VEHPxnmOsM9EePVs0srSD+irWzXb6vsnaFqoAJBnw==", "039e126c-9f6a-403d-8edb-b2324e5de2df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d68aba42-86f9-45de-b529-c53869d23b1f",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 6, 6, 8, 40, 44, 717, DateTimeKind.Local).AddTicks(5119), "9a181002-d6d2-4b5d-b1d4-219283b1bdb9", "AQAAAAEAACcQAAAAEP+VZPVlS24OReI8ZeduJS9rmYsrBL2F9Sn7h6NQaO2q23WnvXd4/EOhGaHt9bX/vQ==", "32bb47f3-9979-4134-8907-86a532cc6f89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 6, 6, 8, 40, 44, 717, DateTimeKind.Local).AddTicks(5095), "129ef02b-9772-4034-9842-335b6e73bfb8", "AQAAAAEAACcQAAAAENiLJh/jfoe8W8HLEBvEM6ZkZ+2bG2qAMKrzeoq1QmJLh0cYVM/3k9JxUIN2wYHiQA==", "4c8eefe5-6856-48d6-b24e-6cf597943c4c" });

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2023, 6, 6, 8, 40, 44, 724, DateTimeKind.Local).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2023, 6, 6, 8, 40, 44, 724, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2023, 6, 6, 8, 40, 44, 724, DateTimeKind.Local).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2023, 6, 6, 8, 40, 44, 724, DateTimeKind.Local).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2023, 6, 6, 8, 40, 44, 724, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2023, 6, 6, 8, 40, 44, 724, DateTimeKind.Local).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2023, 6, 6, 8, 40, 44, 724, DateTimeKind.Local).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 8,
                column: "Time",
                value: new DateTime(2023, 6, 6, 8, 40, 44, 724, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 9,
                column: "Time",
                value: new DateTime(2023, 6, 6, 8, 40, 44, 724, DateTimeKind.Local).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 10,
                column: "Time",
                value: new DateTime(2023, 6, 6, 8, 40, 44, 724, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 11,
                column: "Time",
                value: new DateTime(2023, 6, 6, 8, 40, 44, 724, DateTimeKind.Local).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 12,
                column: "Time",
                value: new DateTime(2023, 6, 6, 8, 40, 44, 724, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 13,
                column: "Time",
                value: new DateTime(2023, 6, 6, 8, 40, 44, 724, DateTimeKind.Local).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 14,
                column: "Time",
                value: new DateTime(2023, 6, 6, 8, 40, 44, 724, DateTimeKind.Local).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 15,
                column: "Time",
                value: new DateTime(2023, 6, 6, 8, 40, 44, 724, DateTimeKind.Local).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 16,
                column: "Time",
                value: new DateTime(2023, 6, 6, 8, 40, 44, 724, DateTimeKind.Local).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 17,
                column: "Time",
                value: new DateTime(2023, 6, 6, 8, 40, 44, 724, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 18,
                column: "Time",
                value: new DateTime(2023, 6, 6, 8, 40, 44, 724, DateTimeKind.Local).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 19,
                column: "Time",
                value: new DateTime(2023, 6, 6, 8, 40, 44, 724, DateTimeKind.Local).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 20,
                column: "Time",
                value: new DateTime(2023, 6, 6, 8, 40, 44, 724, DateTimeKind.Local).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 21,
                column: "Time",
                value: new DateTime(2023, 6, 6, 8, 40, 44, 724, DateTimeKind.Local).AddTicks(291));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 22,
                column: "Time",
                value: new DateTime(2023, 6, 6, 8, 40, 44, 724, DateTimeKind.Local).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 23,
                column: "Time",
                value: new DateTime(2023, 6, 6, 8, 40, 44, 724, DateTimeKind.Local).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 24,
                column: "Time",
                value: new DateTime(2023, 6, 6, 8, 40, 44, 724, DateTimeKind.Local).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 25,
                column: "Time",
                value: new DateTime(2023, 6, 6, 8, 40, 44, 724, DateTimeKind.Local).AddTicks(301));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e820885b-8490-4367-8bd6-50440fed5b39",
                column: "ConcurrencyStamp",
                value: "0562def0-879e-4e8b-9364-db0870f8478c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eda3e09d-0aaa-4e19-984a-7b511c387a86",
                column: "ConcurrencyStamp",
                value: "29f91a30-138b-45bb-988c-fe44a87fae7b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dd9ce5d-123d-4831-9087-7f2deab0082f",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 16, 40, 352, DateTimeKind.Local).AddTicks(7857), "01235806-1d63-43aa-bc0a-f4f50ccf8d77", "AQAAAAEAACcQAAAAEANFXnX940goM+yC1lV8UY0glwO9MK/B4+qatwzTEgDYEqgO8G4+bjiNOxPvxEegfQ==", "ee139152-1e33-4882-a7a3-f76736622f87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dd9ce5d-2e8d-4831-9087-7f2deab0082f",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 16, 40, 352, DateTimeKind.Local).AddTicks(7833), "1504c54d-26b4-48c6-8dea-02aeaab2af24", "AQAAAAEAACcQAAAAEO29OIvEfh4LPRlh2WkJbEAebF7HY87UIlSkrH2V0gz9/Igy6xgQzabyTHDGZug+Gg==", "7453c76b-4503-4607-8bbb-c58f94967624" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3e93844-b0c1-4e5b-a308-64353b0208d1",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 16, 40, 352, DateTimeKind.Local).AddTicks(7813), "4861404c-b80e-4bab-a6f4-971916f3d4b7", "AQAAAAEAACcQAAAAEBc5uQNNKF0MaT5yBi+XjaRZmE4A8j1GlVyY/Uwq47Xw6FcUj/5rp2WlqvXFTwPvUA==", "7819c979-9b55-413a-acf4-844b3d02e175" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d207e04f-7a11-452e-8a48-23bae4fcd12f",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 16, 40, 352, DateTimeKind.Local).AddTicks(7786), "afed4847-8d87-4ce8-8a48-3e19e2d266b9", "AQAAAAEAACcQAAAAEEAFBaijJcgY0OXaV92N273YhCPlBEBocfApO+7OEdf1zyv85xue5fW2usBUCdT9RQ==", "47d1d4f8-8969-401c-b12a-1d6b20969062" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d68aba42-86f9-45de-b529-c53869d23b1f",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 16, 40, 352, DateTimeKind.Local).AddTicks(7766), "848eeaea-cfa9-4b15-9865-2c90ac27b3c3", "AQAAAAEAACcQAAAAEK221F6yOT2BJBpcm3fJnRhkQ/hjj/nOYqHEGHTSa9KsOR/gEVZNp/EMn8VtPcik4A==", "8a57e9f9-c8a2-4af9-8fe4-260f4fb14429" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 16, 40, 352, DateTimeKind.Local).AddTicks(7732), "a217ab3f-dfca-43c1-90e1-e765f3539458", "AQAAAAEAACcQAAAAEInPe+UmnlXE+TmdLuba1ca3TmuR2qyfY2q/C22e22vbAsuXlzDNy9fodxeEbKpXxw==", "e21ee732-8560-465c-b71a-31b81b5ea6d8" });

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2023, 6, 1, 11, 16, 40, 368, DateTimeKind.Local).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2023, 6, 1, 11, 16, 40, 368, DateTimeKind.Local).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2023, 6, 1, 11, 16, 40, 368, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2023, 6, 1, 11, 16, 40, 368, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2023, 6, 1, 11, 16, 40, 368, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2023, 6, 1, 11, 16, 40, 368, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2023, 6, 1, 11, 16, 40, 368, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 8,
                column: "Time",
                value: new DateTime(2023, 6, 1, 11, 16, 40, 368, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 9,
                column: "Time",
                value: new DateTime(2023, 6, 1, 11, 16, 40, 368, DateTimeKind.Local).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 10,
                column: "Time",
                value: new DateTime(2023, 6, 1, 11, 16, 40, 368, DateTimeKind.Local).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 11,
                column: "Time",
                value: new DateTime(2023, 6, 1, 11, 16, 40, 368, DateTimeKind.Local).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 12,
                column: "Time",
                value: new DateTime(2023, 6, 1, 11, 16, 40, 368, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 13,
                column: "Time",
                value: new DateTime(2023, 6, 1, 11, 16, 40, 368, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 14,
                column: "Time",
                value: new DateTime(2023, 6, 1, 11, 16, 40, 368, DateTimeKind.Local).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 15,
                column: "Time",
                value: new DateTime(2023, 6, 1, 11, 16, 40, 368, DateTimeKind.Local).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 16,
                column: "Time",
                value: new DateTime(2023, 6, 1, 11, 16, 40, 368, DateTimeKind.Local).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 17,
                column: "Time",
                value: new DateTime(2023, 6, 1, 11, 16, 40, 368, DateTimeKind.Local).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 18,
                column: "Time",
                value: new DateTime(2023, 6, 1, 11, 16, 40, 368, DateTimeKind.Local).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 19,
                column: "Time",
                value: new DateTime(2023, 6, 1, 11, 16, 40, 368, DateTimeKind.Local).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 20,
                column: "Time",
                value: new DateTime(2023, 6, 1, 11, 16, 40, 368, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 21,
                column: "Time",
                value: new DateTime(2023, 6, 1, 11, 16, 40, 368, DateTimeKind.Local).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 22,
                column: "Time",
                value: new DateTime(2023, 6, 1, 11, 16, 40, 368, DateTimeKind.Local).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 23,
                column: "Time",
                value: new DateTime(2023, 6, 1, 11, 16, 40, 368, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 24,
                column: "Time",
                value: new DateTime(2023, 6, 1, 11, 16, 40, 368, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 25,
                column: "Time",
                value: new DateTime(2023, 6, 1, 11, 16, 40, 368, DateTimeKind.Local).AddTicks(3409));
        }
    }
}
