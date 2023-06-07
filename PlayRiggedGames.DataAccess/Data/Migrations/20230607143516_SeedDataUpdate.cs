using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayRiggedGames.DataAccess.Data.Migrations
{
    public partial class SeedDataUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 8,
                column: "Time",
                value: new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 9,
                column: "Time",
                value: new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 10,
                column: "Time",
                value: new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 11,
                column: "Time",
                value: new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 12,
                column: "Time",
                value: new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 13,
                column: "Time",
                value: new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 14,
                column: "Time",
                value: new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 15,
                column: "Time",
                value: new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 16,
                column: "Time",
                value: new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 17,
                column: "Time",
                value: new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 18,
                column: "Time",
                value: new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 19,
                column: "Time",
                value: new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 20,
                column: "Time",
                value: new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 21,
                column: "Time",
                value: new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 22,
                column: "Time",
                value: new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 23,
                column: "Time",
                value: new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 24,
                column: "Time",
                value: new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 25,
                column: "Time",
                value: new DateTime(2023, 6, 7, 9, 35, 16, 35, DateTimeKind.Local).AddTicks(8399));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
