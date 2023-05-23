using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayRiggedGames.DataAccess.Data.Migrations
{
    public partial class ModelFixesandNewSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SlotOutcomes_SlotValues_SymbolId",
                table: "SlotOutcomes");

            migrationBuilder.DropForeignKey(
                name: "FK_SlotValues_SlotMachines_SlotMachineId",
                table: "SlotValues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SlotValues",
                table: "SlotValues");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0209a29a-eb37-4996-88f3-f7b43d326e4b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14952d6e-15fd-4ee3-99f1-6c1f04e536a5");

            migrationBuilder.RenameTable(
                name: "SlotValues",
                newName: "SlotSymbols");

            migrationBuilder.RenameColumn(
                name: "JackPot",
                table: "SlotGameLogs",
                newName: "Jackpot");

            migrationBuilder.RenameColumn(
                name: "BirthDay",
                table: "AspNetUsers",
                newName: "Birthday");

            migrationBuilder.RenameIndex(
                name: "IX_SlotValues_SlotMachineId",
                table: "SlotSymbols",
                newName: "IX_SlotSymbols_SlotMachineId");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastLogin",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_SlotSymbols",
                table: "SlotSymbols",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e820885b-8490-4367-8bd6-50440fed5b39", "f8faf82d-c1a4-4ba0-ae48-1ddc66284061", "User", null },
                    { "eda3e09d-0aaa-4e19-984a-7b511c387a86", "88706e7a-ce0f-47b0-ae6d-8b8b75103018", "Admin", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BlackListed", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastLogin", "LastName", "LockoutEnabled", "LockoutEnd", "Money", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0dd9ce5d-2e8d-4831-9087-7f2deab0082f", 0, new DateTime(2002, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "3abee90c-1f7e-4776-b07e-3fd6b9dd3dc6", "example@hotmail.com", true, "Veronica", new DateTime(2023, 5, 23, 10, 29, 28, 399, DateTimeKind.Local).AddTicks(9039), "Brown", false, null, 200, null, "GAMERGIRL123", "AQAAAAEAACcQAAAAEE2/sGnZ3+bD/MABOAHFsWbQrYrUz3HY+uXhD0VD4rUoaaz4rnlwk1WU5rwbsetqrw==", null, false, "683a5054-b3cc-40eb-b122-03d9be8ee752", false, "GamerGirl123" },
                    { "b3e93844-b0c1-4e5b-a308-64353b0208d1", 0, new DateTime(1998, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "dc65aece-86e3-496b-8379-039b026ff5cf", "example@yahoo.com", true, "Samantha", new DateTime(2023, 5, 23, 10, 29, 28, 399, DateTimeKind.Local).AddTicks(9032), "Smith", false, null, 750, null, "LONEWOLF", "AQAAAAEAACcQAAAAENyngs6GihN2IedGGXK2RwOgRuPEyajGSo3+JGQjwRr2sMppzAskecQJoNsdJMIhJQ==", null, false, "faf60533-7bd3-4cde-a194-3181b7219114", false, "LoneWolf" },
                    { "d207e04f-7a11-452e-8a48-23bae4fcd12f", 0, new DateTime(1995, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "f5988ca7-69f0-40d4-8581-084b470a7f94", "example@gmail.com", true, "John", new DateTime(2023, 5, 23, 10, 29, 28, 399, DateTimeKind.Local).AddTicks(9024), "Doe", false, null, 120, null, "COOLCAT12", "AQAAAAEAACcQAAAAECHrdkYUyPqOy+9OwgobFX4Erm2dEhDxqgE5TXzCayV1OtibQ3+DheEJqiVQjL7K9g==", null, false, "49771250-d469-4fe5-b9b5-9b04fa0a2085", false, "CoolCat12" },
                    { "d68aba42-86f9-45de-b529-c53869d23b1f", 0, new DateTime(1969, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "a64ac197-0cd3-409a-bf64-fcd5960bd0e8", "b.shot@gmail.com", true, "S.", new DateTime(2023, 5, 23, 10, 29, 28, 399, DateTimeKind.Local).AddTicks(9014), "G.", false, null, 0, null, "NUMBER1RATEDSALESMAN1997", "AQAAAAEAACcQAAAAEDKAH7bqLy5NdWmv9DDda2Dc/If88AO1/tmdL17qTzNqkxrNPs2zWU+D0mNBu3hz8Q==", null, false, "83b6acf7-f9e9-4a8d-9311-6d27fedc22d6", false, "number1ratedsalesman1997" },
                    { "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce", 0, new DateTime(2000, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "f5e3ce66-6009-48db-a50f-126b377b42b3", "fuller.jc@outlook.com", true, "Jaeden", new DateTime(2023, 5, 23, 10, 29, 28, 399, DateTimeKind.Local).AddTicks(8996), "Fuller", false, null, 1000000, null, "ZABLOO", "AQAAAAEAACcQAAAAEJacxHgK8tnIdgsgeKMDRFzFwBhqR7npnWMjlCcXjOTODxV6KQnVOLUpibLLbJmWbA==", null, false, "aba290cd-8ece-49b0-aede-1646750292ea", false, "ZaBloo" }
                });

            migrationBuilder.InsertData(
                table: "SlotSymbols",
                columns: new[] { "Id", "Name", "SlotMachineId", "Value", "Weight" },
                values: new object[,]
                {
                    { 1, "club", 1, 5, 50 },
                    { 2, "lemon", 1, 5, 50 },
                    { 3, "spade", 1, 10, 50 },
                    { 4, "banana", 1, 10, 50 },
                    { 5, "cherry", 1, 10, 50 },
                    { 6, "diamond", 1, 15, 50 },
                    { 7, "melon", 1, 15, 50 },
                    { 8, "grapes", 1, 15, 50 },
                    { 9, "heart", 1, 25, 50 },
                    { 10, "dice", 1, 25, 50 },
                    { 11, "chip", 1, 25, 50 },
                    { 12, "orange", 1, 25, 50 },
                    { 13, "strawberry", 1, 25, 20 },
                    { 14, "emerald", 1, 50, 20 },
                    { 15, "coin", 1, 50, 20 },
                    { 16, "bell", 1, 150, 10 },
                    { 17, "horseshoe", 1, 150, 10 },
                    { 18, "clover", 1, 150, 10 },
                    { 19, "crown", 1, 500, 3 },
                    { 20, "seven", 1, 1000, 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e820885b-8490-4367-8bd6-50440fed5b39", "0dd9ce5d-2e8d-4831-9087-7f2deab0082f" },
                    { "e820885b-8490-4367-8bd6-50440fed5b39", "b3e93844-b0c1-4e5b-a308-64353b0208d1" },
                    { "e820885b-8490-4367-8bd6-50440fed5b39", "d207e04f-7a11-452e-8a48-23bae4fcd12f" },
                    { "e820885b-8490-4367-8bd6-50440fed5b39", "d68aba42-86f9-45de-b529-c53869d23b1f" },
                    { "eda3e09d-0aaa-4e19-984a-7b511c387a86", "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce" }
                });

            migrationBuilder.InsertData(
                table: "SlotGameLogs",
                columns: new[] { "Id", "Jackpot", "MoneyInput", "MoneyOutput", "PlayerId", "Time" },
                values: new object[,]
                {
                    { 1, false, 50, 2500, "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce", new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3061) },
                    { 2, false, 200, 8000, "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce", new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3065) },
                    { 3, false, 150, 5000, "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce", new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3068) },
                    { 4, true, 300, 15000, "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce", new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3071) },
                    { 5, false, 1000, 25000, "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce", new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3074) },
                    { 6, false, 100, 5000, "d68aba42-86f9-45de-b529-c53869d23b1f", new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3076) },
                    { 7, false, 200, 10000, "d68aba42-86f9-45de-b529-c53869d23b1f", new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3079) },
                    { 8, false, 150, 7500, "d68aba42-86f9-45de-b529-c53869d23b1f", new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3082) },
                    { 9, true, 300, 15000, "d68aba42-86f9-45de-b529-c53869d23b1f", new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3085) },
                    { 10, false, 250, 12500, "d68aba42-86f9-45de-b529-c53869d23b1f", new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3088) },
                    { 11, false, 100, 5000, "d207e04f-7a11-452e-8a48-23bae4fcd12f", new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3090) },
                    { 12, false, 200, 10000, "d207e04f-7a11-452e-8a48-23bae4fcd12f", new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3093) },
                    { 13, false, 150, 7500, "d207e04f-7a11-452e-8a48-23bae4fcd12f", new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3096) },
                    { 14, true, 300, 15000, "d207e04f-7a11-452e-8a48-23bae4fcd12f", new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3098) },
                    { 15, false, 250, 12500, "d207e04f-7a11-452e-8a48-23bae4fcd12f", new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3101) },
                    { 16, false, 100, 5000, "b3e93844-b0c1-4e5b-a308-64353b0208d1", new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3104) },
                    { 17, false, 200, 10000, "b3e93844-b0c1-4e5b-a308-64353b0208d1", new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3106) },
                    { 18, false, 150, 7500, "b3e93844-b0c1-4e5b-a308-64353b0208d1", new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3109) },
                    { 19, true, 300, 15000, "b3e93844-b0c1-4e5b-a308-64353b0208d1", new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3112) },
                    { 20, false, 250, 12500, "b3e93844-b0c1-4e5b-a308-64353b0208d1", new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3114) },
                    { 21, false, 100, 5000, "0dd9ce5d-2e8d-4831-9087-7f2deab0082f", new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3117) },
                    { 22, false, 200, 10000, "0dd9ce5d-2e8d-4831-9087-7f2deab0082f", new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3120) },
                    { 23, false, 150, 7500, "0dd9ce5d-2e8d-4831-9087-7f2deab0082f", new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3122) },
                    { 24, true, 300, 15000, "0dd9ce5d-2e8d-4831-9087-7f2deab0082f", new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3125) },
                    { 25, false, 250, 12500, "0dd9ce5d-2e8d-4831-9087-7f2deab0082f", new DateTime(2023, 5, 23, 10, 29, 28, 405, DateTimeKind.Local).AddTicks(3128) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_SlotOutcomes_SlotSymbols_SymbolId",
                table: "SlotOutcomes",
                column: "SymbolId",
                principalTable: "SlotSymbols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SlotSymbols_SlotMachines_SlotMachineId",
                table: "SlotSymbols",
                column: "SlotMachineId",
                principalTable: "SlotMachines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SlotOutcomes_SlotSymbols_SymbolId",
                table: "SlotOutcomes");

            migrationBuilder.DropForeignKey(
                name: "FK_SlotSymbols_SlotMachines_SlotMachineId",
                table: "SlotSymbols");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SlotSymbols",
                table: "SlotSymbols");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e820885b-8490-4367-8bd6-50440fed5b39", "0dd9ce5d-2e8d-4831-9087-7f2deab0082f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e820885b-8490-4367-8bd6-50440fed5b39", "b3e93844-b0c1-4e5b-a308-64353b0208d1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e820885b-8490-4367-8bd6-50440fed5b39", "d207e04f-7a11-452e-8a48-23bae4fcd12f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e820885b-8490-4367-8bd6-50440fed5b39", "d68aba42-86f9-45de-b529-c53869d23b1f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "eda3e09d-0aaa-4e19-984a-7b511c387a86", "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce" });

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SlotGameLogs",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SlotSymbols",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e820885b-8490-4367-8bd6-50440fed5b39");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eda3e09d-0aaa-4e19-984a-7b511c387a86");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dd9ce5d-2e8d-4831-9087-7f2deab0082f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3e93844-b0c1-4e5b-a308-64353b0208d1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d207e04f-7a11-452e-8a48-23bae4fcd12f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d68aba42-86f9-45de-b529-c53869d23b1f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce");

            migrationBuilder.DropColumn(
                name: "LastLogin",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "SlotSymbols",
                newName: "SlotValues");

            migrationBuilder.RenameColumn(
                name: "Jackpot",
                table: "SlotGameLogs",
                newName: "JackPot");

            migrationBuilder.RenameColumn(
                name: "Birthday",
                table: "AspNetUsers",
                newName: "BirthDay");

            migrationBuilder.RenameIndex(
                name: "IX_SlotSymbols_SlotMachineId",
                table: "SlotValues",
                newName: "IX_SlotValues_SlotMachineId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SlotValues",
                table: "SlotValues",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0209a29a-eb37-4996-88f3-f7b43d326e4b", "63d15722-5739-487c-9c4c-89a27d28f0d4", "Admin", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "14952d6e-15fd-4ee3-99f1-6c1f04e536a5", "f2d006a7-3430-4896-9c2f-119635a1aaab", "User", null });

            migrationBuilder.AddForeignKey(
                name: "FK_SlotOutcomes_SlotValues_SymbolId",
                table: "SlotOutcomes",
                column: "SymbolId",
                principalTable: "SlotValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SlotValues_SlotMachines_SlotMachineId",
                table: "SlotValues",
                column: "SlotMachineId",
                principalTable: "SlotMachines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
