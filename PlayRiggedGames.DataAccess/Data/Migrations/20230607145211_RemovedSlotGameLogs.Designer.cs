﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlayRiggedGames.DataAccess.Data;

#nullable disable

namespace PlayRiggedGames.DataAccess.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230607145211_RemovedSlotGameLogs")]
    partial class RemovedSlotGameLogs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "eda3e09d-0aaa-4e19-984a-7b511c387a86",
                            ConcurrencyStamp = "7d57e679-cdbb-4f2c-9482-405d271eaffa",
                            Name = "Admin"
                        },
                        new
                        {
                            Id = "e820885b-8490-4367-8bd6-50440fed5b39",
                            ConcurrencyStamp = "61a64388-b0a0-43df-bdc8-1bea53863692",
                            Name = "User"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce",
                            RoleId = "eda3e09d-0aaa-4e19-984a-7b511c387a86"
                        },
                        new
                        {
                            UserId = "d68aba42-86f9-45de-b529-c53869d23b1f",
                            RoleId = "e820885b-8490-4367-8bd6-50440fed5b39"
                        },
                        new
                        {
                            UserId = "d207e04f-7a11-452e-8a48-23bae4fcd12f",
                            RoleId = "e820885b-8490-4367-8bd6-50440fed5b39"
                        },
                        new
                        {
                            UserId = "b3e93844-b0c1-4e5b-a308-64353b0208d1",
                            RoleId = "e820885b-8490-4367-8bd6-50440fed5b39"
                        },
                        new
                        {
                            UserId = "0dd9ce5d-2e8d-4831-9087-7f2deab0082f",
                            RoleId = "e820885b-8490-4367-8bd6-50440fed5b39"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("PlayRiggedGames.Domain.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("AccountCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<bool>("BlackListed")
                        .HasColumnType("bit");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Money")
                        .HasColumnType("int");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce",
                            AccessFailedCount = 0,
                            AccountCreated = new DateTime(2023, 6, 7, 9, 52, 11, 449, DateTimeKind.Local).AddTicks(3560),
                            Birthday = new DateTime(2000, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BlackListed = false,
                            ConcurrencyStamp = "5866d6a0-7a59-4fb0-8899-408dc034bc45",
                            Email = "fuller.jc@outlook.com",
                            EmailConfirmed = true,
                            FirstName = "Jaeden",
                            LastName = "Fuller",
                            LockoutEnabled = false,
                            Money = 1000000,
                            NormalizedUserName = "ZABLOO",
                            PasswordHash = "AQAAAAEAACcQAAAAEDS0qXkRzYeL79QfCDAr2OXu6nAxORKxidaYC9nCeRhJXfz1eGimZfs4BHWQocRcew==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a1d503cd-cf7e-42e0-b559-1ce71aa2fb44",
                            TwoFactorEnabled = false,
                            UserName = "ZaBloo"
                        },
                        new
                        {
                            Id = "d68aba42-86f9-45de-b529-c53869d23b1f",
                            AccessFailedCount = 0,
                            AccountCreated = new DateTime(2023, 6, 7, 9, 52, 11, 449, DateTimeKind.Local).AddTicks(3575),
                            Birthday = new DateTime(1969, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BlackListed = false,
                            ConcurrencyStamp = "234833ed-9ea2-415c-84db-b1117f651117",
                            Email = "b.shot@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "S.",
                            LastName = "G.",
                            LockoutEnabled = false,
                            Money = 0,
                            NormalizedUserName = "NUMBER1RATEDSALESMAN1997",
                            PasswordHash = "AQAAAAEAACcQAAAAECxRzdvdkOZ76qH3F+V8qg/CpdcDq9lIgFDUTl7dTTY1WKocE80HRmhLI+ma+7JN1Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fcbec56c-7bd2-4fe7-a13c-3f7643bc7ee7",
                            TwoFactorEnabled = false,
                            UserName = "number1ratedsalesman1997"
                        },
                        new
                        {
                            Id = "d207e04f-7a11-452e-8a48-23bae4fcd12f",
                            AccessFailedCount = 0,
                            AccountCreated = new DateTime(2023, 6, 7, 9, 52, 11, 449, DateTimeKind.Local).AddTicks(3587),
                            Birthday = new DateTime(1995, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BlackListed = false,
                            ConcurrencyStamp = "d808391d-44c5-4f16-9d92-015bb65ea6cc",
                            Email = "example@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "John",
                            LastName = "Doe",
                            LockoutEnabled = false,
                            Money = 120,
                            NormalizedUserName = "COOLCAT12",
                            PasswordHash = "AQAAAAEAACcQAAAAEGY2Tda9XprJB68YHQa2Dah1ZN3fk7kRPxUJIj1kpcZe0ulV1wjLp3s00lafe/BrxQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bbfade0b-ad74-42dd-8264-d2ff53b3fba4",
                            TwoFactorEnabled = false,
                            UserName = "CoolCat12"
                        },
                        new
                        {
                            Id = "b3e93844-b0c1-4e5b-a308-64353b0208d1",
                            AccessFailedCount = 0,
                            AccountCreated = new DateTime(2023, 6, 7, 9, 52, 11, 449, DateTimeKind.Local).AddTicks(3595),
                            Birthday = new DateTime(1998, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BlackListed = false,
                            ConcurrencyStamp = "de549bfb-903e-41d1-b32e-a624b4471f50",
                            Email = "example@yahoo.com",
                            EmailConfirmed = true,
                            FirstName = "Samantha",
                            LastName = "Smith",
                            LockoutEnabled = false,
                            Money = 750,
                            NormalizedUserName = "LONEWOLF",
                            PasswordHash = "AQAAAAEAACcQAAAAEHAQRWz97bFP7P9MXSKd5egU4pebcoXLR6QJpb0+AijXoKv+mO3hQvj9hqWe4lVk/Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b845482c-dcfd-4e7d-be77-d679b9078d44",
                            TwoFactorEnabled = false,
                            UserName = "LoneWolf"
                        },
                        new
                        {
                            Id = "0dd9ce5d-2e8d-4831-9087-7f2deab0082f",
                            AccessFailedCount = 0,
                            AccountCreated = new DateTime(2023, 6, 7, 9, 52, 11, 449, DateTimeKind.Local).AddTicks(3604),
                            Birthday = new DateTime(2002, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BlackListed = false,
                            ConcurrencyStamp = "20473e15-cab1-49fb-88d1-b0e132e9bb1f",
                            Email = "example@hotmail.com",
                            EmailConfirmed = true,
                            FirstName = "Veronica",
                            LastName = "Brown",
                            LockoutEnabled = false,
                            Money = 200,
                            NormalizedUserName = "GAMERGIRL123",
                            PasswordHash = "AQAAAAEAACcQAAAAEGN3roSoJqVC38whlijOpS49rgmKF0hhhnsRgLKFCsmECO/ShOb8m0pMSrUx8eZwww==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "278aa9bb-b100-46e6-9b5f-3f82dabf7ad0",
                            TwoFactorEnabled = false,
                            UserName = "GamerGirl123"
                        },
                        new
                        {
                            Id = "0dd9ce5d-123d-4831-9087-7f2deab0082f",
                            AccessFailedCount = 0,
                            AccountCreated = new DateTime(2023, 6, 7, 9, 52, 11, 449, DateTimeKind.Local).AddTicks(3614),
                            Birthday = new DateTime(1905, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BlackListed = true,
                            ConcurrencyStamp = "ca7c29f4-4341-4142-a074-cba47e966fd1",
                            Email = "exoimple@hotmail.com",
                            EmailConfirmed = true,
                            FirstName = "Evil",
                            LastName = "Jaeden",
                            LockoutEnabled = false,
                            Money = 200,
                            NormalizedUserName = "EVILZABLOO",
                            PasswordHash = "AQAAAAEAACcQAAAAEHRvrxbDC5+hfe9pFR9M/6zqUEB5Z4iZ8NR1gVGJQZDapKONRAW56oyfvBahWjvXGg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7bf71c9f-8cd0-4d8d-ab21-021332e718ff",
                            TwoFactorEnabled = false,
                            UserName = "EvilZabloo"
                        });
                });

            modelBuilder.Entity("PlayRiggedGames.Domain.Models.SlotGameLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Jackpot")
                        .HasColumnType("bit");

                    b.Property<int>("MoneyInput")
                        .HasColumnType("int");

                    b.Property<int>("MoneyOutput")
                        .HasColumnType("int");

                    b.Property<string>("PlayerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("SlotGameLogs");
                });

            modelBuilder.Entity("PlayRiggedGames.Domain.Models.SlotMachine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OutOfOrder")
                        .HasColumnType("bit");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SlotMachines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cost = 5,
                            Height = 3,
                            Name = "LuckySlots",
                            OutOfOrder = false,
                            Width = 5
                        },
                        new
                        {
                            Id = 2,
                            Cost = 0,
                            Height = 5,
                            Name = "DailySpin",
                            OutOfOrder = false,
                            Width = 7
                        });
                });

            modelBuilder.Entity("PlayRiggedGames.Domain.Models.SlotOutcome", b =>
                {
                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("Location")
                        .HasColumnType("int");

                    b.Property<int>("SlotMachineId")
                        .HasColumnType("int");

                    b.Property<int>("SymbolId")
                        .HasColumnType("int");

                    b.HasKey("GameId", "Location");

                    b.HasIndex("SymbolId");

                    b.ToTable("SlotOutcomes");
                });

            modelBuilder.Entity("PlayRiggedGames.Domain.Models.SlotSymbol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SlotMachineId")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SlotMachineId");

                    b.ToTable("SlotSymbols");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "club",
                            SlotMachineId = 1,
                            Value = 75,
                            Weight = 30
                        },
                        new
                        {
                            Id = 2,
                            Name = "lemon",
                            SlotMachineId = 1,
                            Value = 25,
                            Weight = 50
                        },
                        new
                        {
                            Id = 3,
                            Name = "spade",
                            SlotMachineId = 1,
                            Value = 75,
                            Weight = 30
                        },
                        new
                        {
                            Id = 4,
                            Name = "banana",
                            SlotMachineId = 1,
                            Value = 30,
                            Weight = 50
                        },
                        new
                        {
                            Id = 5,
                            Name = "cherry",
                            SlotMachineId = 1,
                            Value = 50,
                            Weight = 50
                        },
                        new
                        {
                            Id = 6,
                            Name = "diamond",
                            SlotMachineId = 1,
                            Value = 75,
                            Weight = 30
                        },
                        new
                        {
                            Id = 7,
                            Name = "melon",
                            SlotMachineId = 1,
                            Value = 35,
                            Weight = 50
                        },
                        new
                        {
                            Id = 8,
                            Name = "grapes",
                            SlotMachineId = 1,
                            Value = 40,
                            Weight = 50
                        },
                        new
                        {
                            Id = 9,
                            Name = "heart",
                            SlotMachineId = 1,
                            Value = 75,
                            Weight = 30
                        },
                        new
                        {
                            Id = 10,
                            Name = "dice",
                            SlotMachineId = 1,
                            Value = 110,
                            Weight = 10
                        },
                        new
                        {
                            Id = 11,
                            Name = "chip",
                            SlotMachineId = 1,
                            Value = 100,
                            Weight = 10
                        },
                        new
                        {
                            Id = 12,
                            Name = "orange",
                            SlotMachineId = 1,
                            Value = 45,
                            Weight = 50
                        },
                        new
                        {
                            Id = 13,
                            Name = "strawberry",
                            SlotMachineId = 1,
                            Value = 55,
                            Weight = 50
                        },
                        new
                        {
                            Id = 14,
                            Name = "emerald",
                            SlotMachineId = 1,
                            Value = 200,
                            Weight = 5
                        },
                        new
                        {
                            Id = 15,
                            Name = "coin",
                            SlotMachineId = 1,
                            Value = 135,
                            Weight = 10
                        },
                        new
                        {
                            Id = 16,
                            Name = "bell",
                            SlotMachineId = 1,
                            Value = 125,
                            Weight = 10
                        },
                        new
                        {
                            Id = 17,
                            Name = "horseshoe",
                            SlotMachineId = 1,
                            Value = 150,
                            Weight = 10
                        },
                        new
                        {
                            Id = 18,
                            Name = "clover",
                            SlotMachineId = 1,
                            Value = 175,
                            Weight = 5
                        },
                        new
                        {
                            Id = 19,
                            Name = "crown",
                            SlotMachineId = 1,
                            Value = 500,
                            Weight = 5
                        },
                        new
                        {
                            Id = 20,
                            Name = "seven",
                            SlotMachineId = 1,
                            Value = 1000,
                            Weight = 3
                        },
                        new
                        {
                            Id = 21,
                            Name = "goldclub",
                            SlotMachineId = 2,
                            Value = 75,
                            Weight = 30
                        },
                        new
                        {
                            Id = 22,
                            Name = "goldlemon",
                            SlotMachineId = 2,
                            Value = 25,
                            Weight = 50
                        },
                        new
                        {
                            Id = 23,
                            Name = "goldspade",
                            SlotMachineId = 2,
                            Value = 75,
                            Weight = 30
                        },
                        new
                        {
                            Id = 24,
                            Name = "goldbanana",
                            SlotMachineId = 2,
                            Value = 30,
                            Weight = 50
                        },
                        new
                        {
                            Id = 25,
                            Name = "goldcherry",
                            SlotMachineId = 2,
                            Value = 50,
                            Weight = 50
                        },
                        new
                        {
                            Id = 26,
                            Name = "golddiamond",
                            SlotMachineId = 2,
                            Value = 75,
                            Weight = 30
                        },
                        new
                        {
                            Id = 27,
                            Name = "goldmelon",
                            SlotMachineId = 2,
                            Value = 35,
                            Weight = 50
                        },
                        new
                        {
                            Id = 28,
                            Name = "goldgrapes",
                            SlotMachineId = 2,
                            Value = 40,
                            Weight = 50
                        },
                        new
                        {
                            Id = 29,
                            Name = "goldheart",
                            SlotMachineId = 2,
                            Value = 75,
                            Weight = 30
                        },
                        new
                        {
                            Id = 30,
                            Name = "golddice",
                            SlotMachineId = 2,
                            Value = 110,
                            Weight = 10
                        },
                        new
                        {
                            Id = 31,
                            Name = "goldchip",
                            SlotMachineId = 2,
                            Value = 100,
                            Weight = 10
                        },
                        new
                        {
                            Id = 32,
                            Name = "goldorange",
                            SlotMachineId = 2,
                            Value = 45,
                            Weight = 50
                        },
                        new
                        {
                            Id = 33,
                            Name = "goldstrawberry",
                            SlotMachineId = 2,
                            Value = 55,
                            Weight = 50
                        },
                        new
                        {
                            Id = 34,
                            Name = "goldemerald",
                            SlotMachineId = 2,
                            Value = 200,
                            Weight = 5
                        },
                        new
                        {
                            Id = 35,
                            Name = "goldcoin",
                            SlotMachineId = 2,
                            Value = 135,
                            Weight = 10
                        },
                        new
                        {
                            Id = 36,
                            Name = "goldbell",
                            SlotMachineId = 2,
                            Value = 125,
                            Weight = 10
                        },
                        new
                        {
                            Id = 37,
                            Name = "goldhorseshoe",
                            SlotMachineId = 2,
                            Value = 150,
                            Weight = 10
                        },
                        new
                        {
                            Id = 38,
                            Name = "goldclover",
                            SlotMachineId = 2,
                            Value = 175,
                            Weight = 5
                        },
                        new
                        {
                            Id = 39,
                            Name = "goldcrown",
                            SlotMachineId = 2,
                            Value = 500,
                            Weight = 5
                        },
                        new
                        {
                            Id = 40,
                            Name = "goldseven",
                            SlotMachineId = 2,
                            Value = 1000,
                            Weight = 3
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("PlayRiggedGames.Domain.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("PlayRiggedGames.Domain.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PlayRiggedGames.Domain.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("PlayRiggedGames.Domain.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PlayRiggedGames.Domain.Models.SlotGameLog", b =>
                {
                    b.HasOne("PlayRiggedGames.Domain.Models.ApplicationUser", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("PlayRiggedGames.Domain.Models.SlotOutcome", b =>
                {
                    b.HasOne("PlayRiggedGames.Domain.Models.SlotGameLog", "Game")
                        .WithMany("SlotOutcomes")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PlayRiggedGames.Domain.Models.SlotSymbol", "Symbol")
                        .WithMany()
                        .HasForeignKey("SymbolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Symbol");
                });

            modelBuilder.Entity("PlayRiggedGames.Domain.Models.SlotSymbol", b =>
                {
                    b.HasOne("PlayRiggedGames.Domain.Models.SlotMachine", "SlotMachine")
                        .WithMany("Values")
                        .HasForeignKey("SlotMachineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SlotMachine");
                });

            modelBuilder.Entity("PlayRiggedGames.Domain.Models.SlotGameLog", b =>
                {
                    b.Navigation("SlotOutcomes");
                });

            modelBuilder.Entity("PlayRiggedGames.Domain.Models.SlotMachine", b =>
                {
                    b.Navigation("Values");
                });
#pragma warning restore 612, 618
        }
    }
}