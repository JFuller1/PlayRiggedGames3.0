using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayRiggedGames.DataAccess.Data.Migrations
{
    public partial class DailySpinSymbolsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e820885b-8490-4367-8bd6-50440fed5b39",
                column: "ConcurrencyStamp",
                value: "72c3700e-873a-4c5f-af18-edafaa5c3667");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eda3e09d-0aaa-4e19-984a-7b511c387a86",
                column: "ConcurrencyStamp",
                value: "bfd38dc1-666f-4a21-97a0-c356ce185811");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dd9ce5d-123d-4831-9087-7f2deab0082f",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 6, 5, 9, 47, 57, 848, DateTimeKind.Local).AddTicks(9520), "8c17be54-50c6-44db-8d36-538f38343635", "AQAAAAEAACcQAAAAEHbYhOz+1+pOGmOQCQCuK9vIIO6xFhvJ3FtPtQyLsxvUj5Lqpsm5VhRvq5krF5AifQ==", "23f6d743-4cd9-457f-b95b-3187e09c53e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dd9ce5d-2e8d-4831-9087-7f2deab0082f",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 6, 5, 9, 47, 57, 848, DateTimeKind.Local).AddTicks(9511), "2e8ae65f-04af-4b09-88f7-b606de72fc07", "AQAAAAEAACcQAAAAEIqSdSc6M7Iu8ysxAirrD7ZhxAI6sMBFgyRsLOW3i7yxkf9CwGJj64PNxJWTPZjE2Q==", "c2d99487-9076-46e8-b7eb-880ca16d05a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3e93844-b0c1-4e5b-a308-64353b0208d1",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 6, 5, 9, 47, 57, 848, DateTimeKind.Local).AddTicks(9503), "1f8232c4-1c9d-48e7-865a-efea4891fbeb", "AQAAAAEAACcQAAAAEEeNO5g6EbtLOoh83IFRdKqjdxCikGRde9+X+98Xd/gegcTyg9u2bEW2YdkiqqwmeA==", "3bc95e8b-996d-4494-880d-3d0c48953bba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d207e04f-7a11-452e-8a48-23bae4fcd12f",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 6, 5, 9, 47, 57, 848, DateTimeKind.Local).AddTicks(9491), "e20a59ac-10db-4a25-8faf-ca747145c421", "AQAAAAEAACcQAAAAEPWpX+ufghOfRm4z85I6qa0FRwtxuFKvSkcsjB/aeLn9vKZgNqXGMCCMmYOom/ebwA==", "77540f38-b090-4772-9265-50d3baeae9d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d68aba42-86f9-45de-b529-c53869d23b1f",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 6, 5, 9, 47, 57, 848, DateTimeKind.Local).AddTicks(9483), "d6bafc99-1f66-44f9-8495-a6009daf49d2", "AQAAAAEAACcQAAAAENqpQMO5Kj5duIHRzpFz78h3SZPedlYd5pbMDd9w8uVE+NgvZ+CEKiANw2j/DmfXbw==", "e0f7a45f-7cf2-4859-bed0-8a07f204417a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 6, 5, 9, 47, 57, 848, DateTimeKind.Local).AddTicks(9466), "1a64630d-2ccf-4330-bb2a-1c93a85dbb29", "AQAAAAEAACcQAAAAEIbZa+BBJxEiafVzbRmJCK/63NXX5UBCVYpNHX4vaWsqZOu+z/shVaE7ao/T1pZLMA==", "23a07497-129b-4c78-86cc-9521b6b3651b" });

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2023, 6, 5, 9, 47, 57, 855, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2023, 6, 5, 9, 47, 57, 855, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2023, 6, 5, 9, 47, 57, 855, DateTimeKind.Local).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2023, 6, 5, 9, 47, 57, 855, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2023, 6, 5, 9, 47, 57, 855, DateTimeKind.Local).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2023, 6, 5, 9, 47, 57, 855, DateTimeKind.Local).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2023, 6, 5, 9, 47, 57, 855, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 8,
                column: "Time",
                value: new DateTime(2023, 6, 5, 9, 47, 57, 855, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 9,
                column: "Time",
                value: new DateTime(2023, 6, 5, 9, 47, 57, 855, DateTimeKind.Local).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 10,
                column: "Time",
                value: new DateTime(2023, 6, 5, 9, 47, 57, 855, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 11,
                column: "Time",
                value: new DateTime(2023, 6, 5, 9, 47, 57, 855, DateTimeKind.Local).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 12,
                column: "Time",
                value: new DateTime(2023, 6, 5, 9, 47, 57, 855, DateTimeKind.Local).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 13,
                column: "Time",
                value: new DateTime(2023, 6, 5, 9, 47, 57, 855, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 14,
                column: "Time",
                value: new DateTime(2023, 6, 5, 9, 47, 57, 855, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 15,
                column: "Time",
                value: new DateTime(2023, 6, 5, 9, 47, 57, 855, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 16,
                column: "Time",
                value: new DateTime(2023, 6, 5, 9, 47, 57, 855, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 17,
                column: "Time",
                value: new DateTime(2023, 6, 5, 9, 47, 57, 855, DateTimeKind.Local).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 18,
                column: "Time",
                value: new DateTime(2023, 6, 5, 9, 47, 57, 855, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 19,
                column: "Time",
                value: new DateTime(2023, 6, 5, 9, 47, 57, 855, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 20,
                column: "Time",
                value: new DateTime(2023, 6, 5, 9, 47, 57, 855, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 21,
                column: "Time",
                value: new DateTime(2023, 6, 5, 9, 47, 57, 855, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 22,
                column: "Time",
                value: new DateTime(2023, 6, 5, 9, 47, 57, 855, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 23,
                column: "Time",
                value: new DateTime(2023, 6, 5, 9, 47, 57, 855, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 24,
                column: "Time",
                value: new DateTime(2023, 6, 5, 9, 47, 57, 855, DateTimeKind.Local).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 25,
                column: "Time",
                value: new DateTime(2023, 6, 5, 9, 47, 57, 855, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.InsertData(
                table: "SlotSymbols",
                columns: new[] { "Id", "Name", "SlotMachineId", "Value", "Weight" },
                values: new object[,]
                {
                    { 21, "goldclub", 2, 75, 30 },
                    { 22, "goldlemon", 2, 25, 50 },
                    { 23, "goldspade", 2, 75, 30 },
                    { 24, "goldbanana", 2, 30, 50 },
                    { 25, "goldcherry", 2, 50, 50 },
                    { 26, "golddiamond", 2, 75, 30 },
                    { 27, "goldmelon", 2, 35, 50 },
                    { 28, "goldgrapes", 2, 40, 50 },
                    { 29, "goldheart", 2, 75, 30 }
                });

            migrationBuilder.InsertData(
                table: "SlotSymbols",
                columns: new[] { "Id", "Name", "SlotMachineId", "Value", "Weight" },
                values: new object[,]
                {
                    { 30, "golddice", 2, 110, 10 },
                    { 31, "goldchip", 2, 100, 10 },
                    { 32, "goldorange", 2, 45, 50 },
                    { 33, "goldstrawberry", 2, 55, 50 },
                    { 34, "goldemerald", 2, 200, 5 },
                    { 35, "goldcoin", 2, 135, 10 },
                    { 36, "goldbell", 2, 125, 10 },
                    { 37, "goldhorseshoe", 2, 150, 10 },
                    { 38, "goldclover", 2, 175, 5 },
                    { 39, "goldcrown", 2, 500, 5 },
                    { 40, "goldseven", 2, 1000, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 40);

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
