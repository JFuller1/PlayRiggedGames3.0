using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayRiggedGames.DataAccess.Data.Migrations
{
    public partial class AccountCreationDateAddedToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AccountCreated",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountCreated",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e820885b-8490-4367-8bd6-50440fed5b39",
                column: "ConcurrencyStamp",
                value: "2f69ab96-530a-4da5-b4b5-5241c89689ea");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eda3e09d-0aaa-4e19-984a-7b511c387a86",
                column: "ConcurrencyStamp",
                value: "30382fa0-e2f9-4b73-828c-c51624f8ea0f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dd9ce5d-2e8d-4831-9087-7f2deab0082f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e77e493-5111-4812-a065-d397a6ab218e", "AQAAAAEAACcQAAAAEFDNA39moRaeTq8Fzntk95OEdg34dYNh9VxGE/d8Pai6Yj5+fAqff3PZNSoHQ6qRtg==", "9e37b286-8ebc-402d-9b24-2b29efab5530" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3e93844-b0c1-4e5b-a308-64353b0208d1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64b39f04-6c85-4427-9857-af3fd85e4f41", "AQAAAAEAACcQAAAAEGey1vMdQq+PRMmwJZRU/I787zbBq4Q3OeKdaU12M2O1s9/niugG5y3hHXK/6Rv9qQ==", "57be026d-a7c0-407a-85c1-d7d82c107b5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d207e04f-7a11-452e-8a48-23bae4fcd12f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5842ae0f-8e3a-49e6-8b9e-9c53c61e6a5d", "AQAAAAEAACcQAAAAELHWtz6iZKDWgU8b5pXX46RdFwjox40lSUf22228NtzTpPa5vl0lT4ePp1edEiZr5Q==", "4b131d4b-4b6b-46fc-b9df-64abc9c4fd05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d68aba42-86f9-45de-b529-c53869d23b1f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82138fdf-495b-485e-a23e-52a458494132", "AQAAAAEAACcQAAAAEIxZ9WaVE8DJ8/1AT4+e2g2PSNXU8tfytfnUK29joAQcR5RWS/sTBQBumePCns6/Ig==", "8ece782c-3aac-473a-ad04-31414d9bad6a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d99ee798-1de5-435f-8878-ea530a375fcf", "AQAAAAEAACcQAAAAEGM/HPMWZhfJOUHF6ahfQhRgr0CwXT4PK5F0PTz1bH8ZCW49+jFjK5hNctOAFWZ7Xg==", "7ecfdc00-4f44-4ec5-9817-2f579f5c4eba" });

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2023, 5, 25, 9, 24, 40, 903, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2023, 5, 25, 9, 24, 40, 903, DateTimeKind.Local).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2023, 5, 25, 9, 24, 40, 903, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2023, 5, 25, 9, 24, 40, 903, DateTimeKind.Local).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2023, 5, 25, 9, 24, 40, 903, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2023, 5, 25, 9, 24, 40, 903, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2023, 5, 25, 9, 24, 40, 903, DateTimeKind.Local).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 8,
                column: "Time",
                value: new DateTime(2023, 5, 25, 9, 24, 40, 903, DateTimeKind.Local).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 9,
                column: "Time",
                value: new DateTime(2023, 5, 25, 9, 24, 40, 903, DateTimeKind.Local).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 10,
                column: "Time",
                value: new DateTime(2023, 5, 25, 9, 24, 40, 903, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 11,
                column: "Time",
                value: new DateTime(2023, 5, 25, 9, 24, 40, 903, DateTimeKind.Local).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 12,
                column: "Time",
                value: new DateTime(2023, 5, 25, 9, 24, 40, 903, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 13,
                column: "Time",
                value: new DateTime(2023, 5, 25, 9, 24, 40, 903, DateTimeKind.Local).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 14,
                column: "Time",
                value: new DateTime(2023, 5, 25, 9, 24, 40, 903, DateTimeKind.Local).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 15,
                column: "Time",
                value: new DateTime(2023, 5, 25, 9, 24, 40, 903, DateTimeKind.Local).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 16,
                column: "Time",
                value: new DateTime(2023, 5, 25, 9, 24, 40, 903, DateTimeKind.Local).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 17,
                column: "Time",
                value: new DateTime(2023, 5, 25, 9, 24, 40, 903, DateTimeKind.Local).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 18,
                column: "Time",
                value: new DateTime(2023, 5, 25, 9, 24, 40, 903, DateTimeKind.Local).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 19,
                column: "Time",
                value: new DateTime(2023, 5, 25, 9, 24, 40, 903, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 20,
                column: "Time",
                value: new DateTime(2023, 5, 25, 9, 24, 40, 903, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 21,
                column: "Time",
                value: new DateTime(2023, 5, 25, 9, 24, 40, 903, DateTimeKind.Local).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 22,
                column: "Time",
                value: new DateTime(2023, 5, 25, 9, 24, 40, 903, DateTimeKind.Local).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 23,
                column: "Time",
                value: new DateTime(2023, 5, 25, 9, 24, 40, 903, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 24,
                column: "Time",
                value: new DateTime(2023, 5, 25, 9, 24, 40, 903, DateTimeKind.Local).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 25,
                column: "Time",
                value: new DateTime(2023, 5, 25, 9, 24, 40, 903, DateTimeKind.Local).AddTicks(3437));
        }
    }
}
