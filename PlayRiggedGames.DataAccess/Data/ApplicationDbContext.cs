using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PlayRiggedGames.Domain.Models;
using PlayRiggedGames.Models;
using System.Security.Cryptography.X509Certificates;

namespace PlayRiggedGames.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IRiggedDataAccess
    {
        /*
         *  Note: if adding migrations for the first time enter:
         *      PM> Add-Migration InitialMigration -OutputDir Data\Migrations
         *  Apparently default location of migration is literally just on Project not in Data
         */

        /*
         *  Note: if running "PM> Update-Database" and ERR says "There is already an object named 'AspNetRoles' in the database":
         *      Ensure correct connection string 
         *      or
         *      Run: PM> Drop-Database
         *          when asked are you sure; 
         *              Enter PM> A
         *  It's just freaking out cuz table alrdy exists. Needs to be cleared to add another.            
         */

        /*
         *  Note: To ensure to disallow null values on Model variables:
         *      Add [Required] above variable declaration
         *      Use the below in action (in controller)
         *          if (ModelState.IsValid){} to ensure values are all valid
         *          
         *  This feature must be discussed with group members
         */

        /*
         *  Note: Update-Database 
         *      Should set all tables automatically with no issue.
         *      If issue; then its probably because Liam is using Docker not SSMS.
         *      Simply add connection string to your desired one & comment out the original.
         *  Liam is adding this because he believes that different connection strings are required depending on software.
         */

        // User related
        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }

        // Blackjack

        // Slot
        public virtual DbSet<SlotOutcome> SlotOutcomes { get; set; }
        public virtual DbSet<SlotSymbol> SlotSymbols { get; set; }
        public virtual DbSet<SlotMachine> SlotMachines { get; set; }
        public virtual DbSet<SlotGameLog> SlotGameLogs { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Ensures that PK of SlotOutcome is set as [GameId & Location]
            // since SlotOutcome has no specified PK
            builder.Entity<SlotOutcome>()
                .HasKey(s => new { s.GameId, s.Location });

            builder.Ignore<SlotRowWin>();

            #region Seed Data
            // User Roles
            builder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole()
                    {
                        Id = "eda3e09d-0aaa-4e19-984a-7b511c387a86",
                        Name = "Admin"
                    },
                    new IdentityRole()
                    {
                        Id = "e820885b-8490-4367-8bd6-50440fed5b39",
                        Name = "User"
                    }
                );

            // Slot Machines
            builder.Entity<SlotMachine>()
                .HasData(
                    new SlotMachine()
                    {
                        Id = 1,
                        Name = "LuckySlots",
                        Width = 5,
                        Height = 3,
                        Cost = 5
                    },
                    new SlotMachine()
                    {
                        Id = 2,
                        Name = "DailySpin",
                        Width = 7,
                        Height = 5,
                        Cost = 0
                    }
                );

            #region Lucky Slots Symbols
            builder.Entity<SlotSymbol>()
                .HasData(
                    new SlotSymbol()
                    {
                        Id = 1,
                        Name = "club",
                        Value = 75,
                        Weight = 30,
                        SlotMachineId = 1
                    },
                    new SlotSymbol()
                    {
                        Id = 2,
                        Name = "lemon",
                        Value = 25,
                        Weight = 50,
                        SlotMachineId = 1
                    },
                    new SlotSymbol()
                    {
                        Id = 3,
                        Name = "spade",
                        Value = 75,
                        Weight = 30,
                        SlotMachineId = 1
                    },
                    new SlotSymbol()
                    {
                        Id = 4,
                        Name = "banana",
                        Value = 30,
                        Weight = 50,
                        SlotMachineId = 1
                    },
                    new SlotSymbol()
                    {
                        Id = 5,
                        Name = "cherry",
                        Value = 50,
                        Weight = 50,
                        SlotMachineId = 1
                    },
                    new SlotSymbol()
                    {
                        Id = 6,
                        Name = "diamond",
                        Value = 75,
                        Weight = 30,
                        SlotMachineId = 1
                    },
                    new SlotSymbol()
                    {
                        Id = 7,
                        Name = "melon",
                        Value = 35,
                        Weight = 50,
                        SlotMachineId = 1
                    },
                    new SlotSymbol()
                    {
                        Id = 8,
                        Name = "grapes",
                        Value = 40,
                        Weight = 50,
                        SlotMachineId = 1
                    },
                    new SlotSymbol()
                    {
                        Id = 9,
                        Name = "heart",
                        Value = 75,
                        Weight = 30,
                        SlotMachineId = 1
                    },
                    new SlotSymbol()
                    {
                        Id = 10,
                        Name = "dice",
                        Value = 110,
                        Weight = 10,
                        SlotMachineId = 1
                    },
                    new SlotSymbol()
                    {
                        Id = 11,
                        Name = "chip",
                        Value = 100,
                        Weight = 10,
                        SlotMachineId = 1
                    },
                    new SlotSymbol()
                    {
                        Id = 12,
                        Name = "orange",
                        Value = 45,
                        Weight = 50,
                        SlotMachineId = 1
                    },
                    new SlotSymbol()
                    {
                        Id = 13,
                        Name = "strawberry",
                        Value = 55,
                        Weight = 50,
                        SlotMachineId = 1
                    },
                    new SlotSymbol()
                    {
                        Id = 14,
                        Name = "emerald",
                        Value = 200,
                        Weight = 5,
                        SlotMachineId = 1
                    },
                    new SlotSymbol()
                    {
                        Id = 15,
                        Name = "coin",
                        Value = 135,
                        Weight = 10,
                        SlotMachineId = 1
                    },
                    new SlotSymbol()
                    {
                        Id = 16,
                        Name = "bell",
                        Value = 125,
                        Weight = 10,
                        SlotMachineId = 1
                    },
                    new SlotSymbol()
                    {
                        Id = 17,
                        Name = "horseshoe",
                        Value = 150,
                        Weight = 10,
                        SlotMachineId = 1
                    },
                    new SlotSymbol()
                    {
                        Id = 18,
                        Name = "clover",
                        Value = 175,
                        Weight = 5,
                        SlotMachineId = 1
                    },
                    new SlotSymbol()
                    {
                        Id = 19,
                        Name = "crown",
                        Value = 500,
                        Weight = 5,
                        SlotMachineId = 1
                    },
                    new SlotSymbol()
                    {
                        Id = 20,
                        Name = "seven",
                        Value = 1000,
                        Weight = 3,
                        SlotMachineId = 1
                    }
                );
            #endregion

            #region Daily Spin Symbols
            builder.Entity<SlotSymbol>()
                .HasData(
                    new SlotSymbol()
                    {
                        Id = 21,
                        Name = "goldclub",
                        Value = 75,
                        Weight = 30,
                        SlotMachineId = 2
                    },
                    new SlotSymbol()
                    {
                        Id = 22,
                        Name = "goldlemon",
                        Value = 25,
                        Weight = 50,
                        SlotMachineId = 2
                    },
                    new SlotSymbol()
                    {
                        Id = 23,
                        Name = "goldspade",
                        Value = 75,
                        Weight = 30,
                        SlotMachineId = 2
                    },
                    new SlotSymbol()
                    {
                        Id = 24,
                        Name = "goldbanana",
                        Value = 30,
                        Weight = 50,
                        SlotMachineId = 2
                    },
                    new SlotSymbol()
                    {
                        Id = 25,
                        Name = "goldcherry",
                        Value = 50,
                        Weight = 50,
                        SlotMachineId = 2
                    },
                    new SlotSymbol()
                    {
                        Id = 26,
                        Name = "golddiamond",
                        Value = 75,
                        Weight = 30,
                        SlotMachineId = 2
                    },
                    new SlotSymbol()
                    {
                        Id = 27,
                        Name = "goldmelon",
                        Value = 35,
                        Weight = 50,
                        SlotMachineId = 2
                    },
                    new SlotSymbol()
                    {
                        Id = 28,
                        Name = "goldgrapes",
                        Value = 40,
                        Weight = 50,
                        SlotMachineId = 2
                    },
                    new SlotSymbol()
                    {
                        Id = 29,
                        Name = "goldheart",
                        Value = 75,
                        Weight = 30,
                        SlotMachineId = 2
                    },
                    new SlotSymbol()
                    {
                        Id = 30,
                        Name = "golddice",
                        Value = 110,
                        Weight = 10,
                        SlotMachineId = 2
                    },
                    new SlotSymbol()
                    {
                        Id = 31,
                        Name = "goldchip",
                        Value = 100,
                        Weight = 10,
                        SlotMachineId = 2
                    },
                    new SlotSymbol()
                    {
                        Id = 32,
                        Name = "goldorange",
                        Value = 45,
                        Weight = 50,
                        SlotMachineId = 2
                    },
                    new SlotSymbol()
                    {
                        Id = 33,
                        Name = "goldstrawberry",
                        Value = 55,
                        Weight = 50,
                        SlotMachineId = 2
                    },
                    new SlotSymbol()
                    {
                        Id = 34,
                        Name = "goldemerald",
                        Value = 200,
                        Weight = 5,
                        SlotMachineId = 2
                    },
                    new SlotSymbol()
                    {
                        Id = 35,
                        Name = "goldcoin",
                        Value = 135,
                        Weight = 10,
                        SlotMachineId = 2
                    },
                    new SlotSymbol()
                    {
                        Id = 36,
                        Name = "goldbell",
                        Value = 125,
                        Weight = 10,
                        SlotMachineId = 2
                    },
                    new SlotSymbol()
                    {
                        Id = 37,
                        Name = "goldhorseshoe",
                        Value = 150,
                        Weight = 10,
                        SlotMachineId = 2
                    },
                    new SlotSymbol()
                    {
                        Id = 38,
                        Name = "goldclover",
                        Value = 175,
                        Weight = 5,
                        SlotMachineId = 2
                    },
                    new SlotSymbol()
                    {
                        Id = 39,
                        Name = "goldcrown",
                        Value = 500,
                        Weight = 5,
                        SlotMachineId = 2
                    },
                    new SlotSymbol()
                    {
                        Id = 40,
                        Name = "goldseven",
                        Value = 1000,
                        Weight = 3,
                        SlotMachineId = 2
                    }
                );
            #endregion

            // Blackjack end result (Win, Loss, Stalemate)
            //builder.Entity<BlackjackEndResult>()
            //    .HasData(
            //        new BlackjackEndResult()
            //        {
            //            Id = 1,
            //            Name = "Win"
            //        },
            //        new BlackjackEndResult()
            //        {
            //            Id = 2,
            //            Name = "Loss"
            //        },
            //        new BlackjackEndResult()
            //        {
            //            Id = 3,
            //            Name = "Stalemate"
            //        }
            //    );

            #region Users

            var admin1 = new ApplicationUser()
            {
                Id = "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce",
                UserName = "ZaBloo",
                NormalizedUserName = "ZABLOO",
                Money = 1000000,
                Birthday = new DateTime(2000, 1, 20),
                Email = "fuller.jc@outlook.com",
                EmailConfirmed = true,
                FirstName = "Jaeden",
                LastName = "Fuller",
            };

            var user1 = new ApplicationUser()
            {
                Id = "d68aba42-86f9-45de-b529-c53869d23b1f",
                UserName = "number1ratedsalesman1997",
                NormalizedUserName = "NUMBER1RATEDSALESMAN1997",
                Money = 0,
                Birthday = new DateTime(1969, 3, 5),
                Email = "b.shot@gmail.com",
                EmailConfirmed = true,
                FirstName = "S.",
                LastName = "G."
            };

            var user2 = new ApplicationUser()
            {
                Id = "d207e04f-7a11-452e-8a48-23bae4fcd12f",
                UserName = "CoolCat12",
                NormalizedUserName = "COOLCAT12",
                Money = 120,
                Birthday = new DateTime(1995, 6, 2),
                Email = "example@gmail.com",
                EmailConfirmed = true,
                FirstName = "John",
                LastName = "Doe"
            };

            var user3 = new ApplicationUser()
            {
                Id = "b3e93844-b0c1-4e5b-a308-64353b0208d1",
                UserName = "LoneWolf",
                NormalizedUserName = "LONEWOLF",
                Money = 750,
                Birthday = new DateTime(1998, 9, 12),
                Email = "example@yahoo.com",
                EmailConfirmed = true,
                FirstName = "Samantha",
                LastName = "Smith"
            };

            var user4 = new ApplicationUser()
            {
                Id = "0dd9ce5d-2e8d-4831-9087-7f2deab0082f",
                UserName = "GamerGirl123",
                NormalizedUserName = "GAMERGIRL123",
                Money = 200,
                Birthday = new DateTime(2002, 12, 5),
                Email = "example@hotmail.com",
                EmailConfirmed = true,
                FirstName = "Veronica",
                LastName = "Brown"
            };

            var user5 = new ApplicationUser()
            {
                Id = "0dd9ce5d-123d-4831-9087-7f2deab0082f",
                UserName = "EvilZabloo",
                NormalizedUserName = "EVILZABLOO",
                Money = 200,
                Birthday = new DateTime(1905, 12, 5),
                Email = "exoimple@hotmail.com",
                EmailConfirmed = true,
                FirstName = "Evil",
                LastName = "Jaeden",
                BlackListed = true
            };

            PasswordHasher<ApplicationUser> ph = new PasswordHasher<ApplicationUser>();
            admin1.PasswordHash = ph.HashPassword(admin1, "1234*Pass");
            user1.PasswordHash = ph.HashPassword(user2, "1997Sale$");
            user2.PasswordHash = ph.HashPassword(user2, "$Moon99");
            user3.PasswordHash = ph.HashPassword(user3, "AwesomePossum!77");
            user4.PasswordHash = ph.HashPassword(user4, "Pass%55");
            user5.PasswordHash = ph.HashPassword(user5, "Mwahahaha!05");

            builder.Entity<ApplicationUser>()
                .HasData(admin1, user1, user2, user3, user4, user5);
            #endregion

            #region Roles
            //ADD Admin role seeding
            builder.Entity<IdentityUserRole<string>>()
                .HasData(
                    new IdentityUserRole<string>
                    {
                        RoleId = "eda3e09d-0aaa-4e19-984a-7b511c387a86", //ADMIN
                        UserId = "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce"
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = "e820885b-8490-4367-8bd6-50440fed5b39", //USER
                        UserId = "d68aba42-86f9-45de-b529-c53869d23b1f"
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = "e820885b-8490-4367-8bd6-50440fed5b39", //USER
                        UserId = "d207e04f-7a11-452e-8a48-23bae4fcd12f"
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = "e820885b-8490-4367-8bd6-50440fed5b39", //USER
                        UserId = "b3e93844-b0c1-4e5b-a308-64353b0208d1"
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = "e820885b-8490-4367-8bd6-50440fed5b39", //USER
                        UserId = "0dd9ce5d-2e8d-4831-9087-7f2deab0082f"
                    }

                );
            #endregion

            #endregion
        }

        #region Functions from Interface
        // fun fact: you do indeed need SaveChanges();

        // User
        public bool CreateUser(ApplicationUser newUser)
        {
            try
            {
                ApplicationUsers.Add(newUser);
                this.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public IEnumerable<ApplicationUser> GetAllUsers()
        {
            return ApplicationUsers.ToArray();
        }
        public bool UpdateUser(ApplicationUser updateData)
        {
            try
            {
                // intentionally break if null
                ApplicationUser selected = ApplicationUsers.First(x => x.Id == updateData.Id);

                selected = updateData;

                this.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        // SlotMachine
        public bool CreateSlotMachine(SlotMachine newSlotMachine)
        {
            try
            {
                SlotMachines.Add(newSlotMachine);
                this.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public IEnumerable<SlotMachine> GetAllSlotMachines()
        {
            return SlotMachines.ToArray();
        }
        public bool UpdateSlotMachine(SlotMachine updateData)
        {
            try
            {
                // intentionally break if null
                SlotMachine selected = SlotMachines.First(x => x.Id == updateData.Id);

                selected = updateData;

                this.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        // SlotSymbols CRU
        public bool CreateSlotSymbol(SlotSymbol newSlotSymbol)
        {
            try
            {
                SlotSymbols.Add(newSlotSymbol);
                this.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public IEnumerable<SlotSymbol> GetAllSlotSymbols()
        {
            return SlotSymbols.ToArray();
        }
        public bool UpdateSlotSymbol(SlotSymbol updateData)
        {
            try
            {
                SlotSymbol selected = SlotSymbols.First(x => x.Id == updateData.Id);

                selected = updateData;

                this.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }


        // SlotGameLogs CR
        public bool CreateSlotGameLog(SlotGameLog slotGameLog)
        {
            try
            {
                SlotGameLogs.Add(slotGameLog);
                this.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public IEnumerable<SlotGameLog> GetAllSlotGameLogs()
        {
            return SlotGameLogs.ToArray();
        }

        // SlotOutcomes CR
        public bool CreateSlotOutcome(SlotOutcome slotOutcome)
        {
            try
            {
                SlotOutcomes.Add(slotOutcome);
                this.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public IEnumerable<SlotOutcome> GetAllSlotOutcomes()
        {
            var returning = SlotOutcomes.ToArray();
            return returning;
        }

        // IdentityRoles CRU
        public bool CreateIdentityRole(IdentityRole role)
        {
            try
            {
                Roles.Add(role);
                this.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public IEnumerable<IdentityRole> GetAllIdentityRoles()
        {
            return Roles.ToArray();
        }
        public bool UpdateIdentityRole(IdentityRole role)
        {
            try
            {
                IdentityRole selected = GetAllIdentityRoles().First(x => x.Id == role.Id);

                selected = role;

                this.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        // IdentityUserRoles CRU
        public bool CreateIdentityUserRole(IdentityUserRole<string> userRole)
        {
            try
            {
                UserRoles.Add(userRole);
                this.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public IEnumerable<IdentityUserRole<string>> GetAllIdentityUserRoles()
        {
            return UserRoles.ToArray();
        }
        public bool UpdateIdentityUserRole(IdentityUserRole<string> updateData)
        {
            try
            {
                IdentityUserRole<string> selected = GetAllIdentityUserRoles().First(x => x.UserId == updateData.UserId);
                
                UserRoles.Remove(selected);
                UserRoles.Add(updateData);

                this.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        #endregion
    }
}
