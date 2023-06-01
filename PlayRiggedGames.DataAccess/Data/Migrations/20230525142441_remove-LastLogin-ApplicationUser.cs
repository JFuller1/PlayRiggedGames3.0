using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayRiggedGames.DataAccess.Data.Migrations
{
    public partial class removeLastLoginApplicationUser : Migration
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
