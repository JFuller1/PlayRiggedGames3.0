using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayRiggedGames.DataAccess.Data.Migrations
{
    public partial class SlotMachineIntegration : Migration
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountCreated", "Birthday", "BlackListed", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Money", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0dd9ce5d-123d-4831-9087-7f2deab0082f", 0, new DateTime(2023, 6, 1, 11, 16, 40, 352, DateTimeKind.Local).AddTicks(7857), new DateTime(1905, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "01235806-1d63-43aa-bc0a-f4f50ccf8d77", "exoimple@hotmail.com", true, "Evil", "Jaeden", false, null, 200, null, "EVILZABLOO", "AQAAAAEAACcQAAAAEANFXnX940goM+yC1lV8UY0glwO9MK/B4+qatwzTEgDYEqgO8G4+bjiNOxPvxEegfQ==", null, false, "ee139152-1e33-4882-a7a3-f76736622f87", false, "EvilZabloo" });

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

            migrationBuilder.UpdateData(
                table: "SlotMachines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Cost", "Name", "Width" },
                values: new object[] { 5, "LuckySlots", 5 });

            migrationBuilder.InsertData(
                table: "SlotMachines",
                columns: new[] { "Id", "Cost", "Height", "Name", "OutOfOrder", "Width" },
                values: new object[] { 2, 0, 5, "DailySpin", false, 7 });

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
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dd9ce5d-123d-4831-9087-7f2deab0082f");

            migrationBuilder.DeleteData(
                table: "SlotMachines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "SlotMachines");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e820885b-8490-4367-8bd6-50440fed5b39",
                column: "ConcurrencyStamp",
                value: "26fa9360-441d-4eaf-b1f5-6090e6cf8391");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eda3e09d-0aaa-4e19-984a-7b511c387a86",
                column: "ConcurrencyStamp",
                value: "d15ece4f-8314-400a-8204-cc2a44f484a2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dd9ce5d-2e8d-4831-9087-7f2deab0082f",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 5, 26, 9, 51, 44, 844, DateTimeKind.Local).AddTicks(4477), "5d579ac2-3648-4a28-bbe8-4fe8fbb87fb4", "AQAAAAEAACcQAAAAEDsSY7vKfLFuvI1WjLl8NhA2oaU6I35/PMVBwkJ7jibZhXJHJNgYMKQGWZ+dqAs/4g==", "281bc565-ddfa-4463-9594-9ffeb19bb005" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3e93844-b0c1-4e5b-a308-64353b0208d1",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 5, 26, 9, 51, 44, 844, DateTimeKind.Local).AddTicks(4469), "568e78ca-6958-448f-ada2-6f337e01d5e8", "AQAAAAEAACcQAAAAEJBmO8zCeGx90mI8AAotvo3/TQQYE7tcXL7rs+K9rBdtXnUVlmD44le2zLHXNDh1/Q==", "7af63a5f-dcbf-4523-8645-9dd32387d135" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d207e04f-7a11-452e-8a48-23bae4fcd12f",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 5, 26, 9, 51, 44, 844, DateTimeKind.Local).AddTicks(4460), "6ea78b2d-244f-41d0-94f2-9e53d9237725", "AQAAAAEAACcQAAAAEMFx7HxuceI3XV7yvHPcg3l6c4QFGf0T8XxDi9gw9Y8QYW4IO8I0kjog7/FUaajeDQ==", "8dfc699d-057f-41c2-b3fe-bdc8191b1196" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d68aba42-86f9-45de-b529-c53869d23b1f",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 5, 26, 9, 51, 44, 844, DateTimeKind.Local).AddTicks(4450), "8b138400-af54-45f9-b92b-c654579ba39c", "AQAAAAEAACcQAAAAEI5WX5AlFbyjhnmlDbnBV7jo8/idfWPalycw8OZdzoomitPTjVXaJWb64umc1h+2sg==", "a75dc0c2-1935-42b8-b380-5f2798107852" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce",
                columns: new[] { "AccountCreated", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 5, 26, 9, 51, 44, 844, DateTimeKind.Local).AddTicks(4434), "07fd69b9-2ec8-4f2b-aaf9-f0ebd2ae5212", "AQAAAAEAACcQAAAAELu0WRzeP8HmaUpg/cskoO+1cphi+TYTf9T0w6rCPvaEfL6BW/jDCh83W3vmdev99Q==", "8a6a9e48-4b3b-4926-9e47-fc2cbbe0b219" });

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2023, 5, 26, 9, 51, 44, 849, DateTimeKind.Local).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2023, 5, 26, 9, 51, 44, 849, DateTimeKind.Local).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2023, 5, 26, 9, 51, 44, 849, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2023, 5, 26, 9, 51, 44, 849, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2023, 5, 26, 9, 51, 44, 849, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2023, 5, 26, 9, 51, 44, 849, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2023, 5, 26, 9, 51, 44, 849, DateTimeKind.Local).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 8,
                column: "Time",
                value: new DateTime(2023, 5, 26, 9, 51, 44, 849, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 9,
                column: "Time",
                value: new DateTime(2023, 5, 26, 9, 51, 44, 849, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 10,
                column: "Time",
                value: new DateTime(2023, 5, 26, 9, 51, 44, 849, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 11,
                column: "Time",
                value: new DateTime(2023, 5, 26, 9, 51, 44, 849, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 12,
                column: "Time",
                value: new DateTime(2023, 5, 26, 9, 51, 44, 849, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 13,
                column: "Time",
                value: new DateTime(2023, 5, 26, 9, 51, 44, 849, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 14,
                column: "Time",
                value: new DateTime(2023, 5, 26, 9, 51, 44, 849, DateTimeKind.Local).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 15,
                column: "Time",
                value: new DateTime(2023, 5, 26, 9, 51, 44, 849, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 16,
                column: "Time",
                value: new DateTime(2023, 5, 26, 9, 51, 44, 849, DateTimeKind.Local).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 17,
                column: "Time",
                value: new DateTime(2023, 5, 26, 9, 51, 44, 849, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 18,
                column: "Time",
                value: new DateTime(2023, 5, 26, 9, 51, 44, 849, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 19,
                column: "Time",
                value: new DateTime(2023, 5, 26, 9, 51, 44, 849, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 20,
                column: "Time",
                value: new DateTime(2023, 5, 26, 9, 51, 44, 849, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 21,
                column: "Time",
                value: new DateTime(2023, 5, 26, 9, 51, 44, 849, DateTimeKind.Local).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 22,
                column: "Time",
                value: new DateTime(2023, 5, 26, 9, 51, 44, 849, DateTimeKind.Local).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 23,
                column: "Time",
                value: new DateTime(2023, 5, 26, 9, 51, 44, 849, DateTimeKind.Local).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 24,
                column: "Time",
                value: new DateTime(2023, 5, 26, 9, 51, 44, 849, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 25,
                column: "Time",
                value: new DateTime(2023, 5, 26, 9, 51, 44, 849, DateTimeKind.Local).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "SlotMachines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Width" },
                values: new object[] { "Lucky Slots", 3 });

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
