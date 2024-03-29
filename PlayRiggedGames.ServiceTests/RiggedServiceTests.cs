﻿using EllipticCurve;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlayRiggedGames.DataAccess;
using PlayRiggedGames.Domain.Models;
using PlayRiggedGames.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Identity;
using System.Security.Principal;

namespace PlayRiggedGames.Service.Tests
{
    // https://learn.microsoft.com/en-us/previous-versions/visualstudio/visual-studio-2008/ms243399(v=vs.90)?redirectedfrom=MSDN

    [TestClass()]
    public class RiggedServiceTests
    {
        private IRiggedService _service;
        private Mock<IRiggedDataAccess> _mockDataAccess;

        [TestMethod()]
        public void Sample()
        {
            // ADAA

            // ARRANGE STUFF HERE

            // DB SETUP
            // Create the mock object
               _mockDataAccess = new Mock<IRiggedDataAccess>();

            // template for mocking _dataAccess functions (required if trying to grab something from DB)
            // _mockDataAccess.Setup<return type of function>(x => x.function name()).Returns(what to actually return);
            _mockDataAccess.Setup<IEnumerable<SlotOutcome>>(l => l.GetAllSlotOutcomes()).Returns(
                new List<SlotOutcome>()
                {
                        new SlotOutcome()
                        {

                        }
                }
                );

            // Inject the mock object into the service constructor
            // now _service is usable
            _service = new RiggedService(_mockDataAccess.Object);

            // ACT STUFF HERE
            // ASSERT STUFF HERE
        }

        // Aayush's Unit Test
        [TestMethod()]
        public void GetIdentityRoleOfUser_ValidOutput()
        {
            // Arrange
            var userId = "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2cd";
            var user = new ApplicationUser()
            {
                Id = userId,
                UserName = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAA",
                NormalizedUserName = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAA",
                Money = -1000,
                Birthday = new DateTime(2000, 1, 20),
                Email = "IAmInCripplingDept@SendHelp.com",
                EmailConfirmed = true,
                FirstName = "Liam",
                LastName = "Lee"
            };

            var roleId = "80960ea5-6c16-4c1d-8eb7-66940d0ad43de820885b-8490-4367-8bd6-50440fed5b39";
            var role = new IdentityRole()
            {
                Id = roleId,
                Name = "Developer"
            };

            var userRole = new IdentityUserRole<string>()
            {
                RoleId = roleId,
                UserId = userId
            };

            // DB Setup
            _mockDataAccess = new Mock<IRiggedDataAccess>();

            _mockDataAccess.Setup<IEnumerable<IdentityUserRole<string>>>(l => l.GetAllIdentityUserRoles()).Returns(
                new List<IdentityUserRole<string>>()
                {
                    userRole,
                    new IdentityUserRole<string>()
                    {
                        RoleId = "80960ea5-6c26-4c1d-8eb7-66940d0ad43de820885b-8490-4367-8bd6-50440fed5b39",
                        UserId = "f2672e1f-cf38-45a5-94d0-8ecb0c2ce2cd"
                    }
                }
            );

            _mockDataAccess.Setup<IEnumerable<IdentityRole>>(p => p.GetAllIdentityRoles()).Returns(
                new List<IdentityRole>()
                {
                    role,
                    new IdentityRole()
                    {
                        Id = "80970ea5-6c16-4c1d-8eb7-66940d0ad43de820885b-8490-4367-8bd6-50440fed5b39",
                        Name = "Develoooooper"
                    }
                }
            );

            _service = new RiggedService(_mockDataAccess.Object);

            // Act
            var iRole = _service.GetIdentityRoleOfUser(user);

            // Assert
            Assert.AreEqual(role, iRole);
        }

        // Aayush's Unit Test
        [TestMethod()]
        public void GetIdentityRoleOfUser_NullInput()
        {
            // Arrange
            var userId = "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2cd";
            ApplicationUser? user = null;

            var roleId = "80960ea5-6c16-4c1d-8eb7-66940d0ad43de820885b-8490-4367-8bd6-50440fed5b39";
            var role = new IdentityRole()
            {
                Id = roleId,
                Name = "Developer"
            };

            var userRole = new IdentityUserRole<string>()
            {
                RoleId = roleId,
                UserId = userId
            };

            // DB Setup
            _mockDataAccess = new Mock<IRiggedDataAccess>();

            _mockDataAccess.Setup<IEnumerable<IdentityUserRole<string>>>(l => l.GetAllIdentityUserRoles()).Returns(
                new List<IdentityUserRole<string>>()
                {
                    userRole,
                    new IdentityUserRole<string>()
                    {
                        RoleId = "80960ea5-6c26-4c1d-8eb7-66940d0ad43de820885b-8490-4367-8bd6-50440fed5b39",
                        UserId = "f2672e1f-cf38-45a5-94d0-8ecb0c2ce2cd"
                    }
                }
            );

            _mockDataAccess.Setup<IEnumerable<IdentityRole>>(p => p.GetAllIdentityRoles()).Returns(
                new List<IdentityRole>()
                {
                    role,
                    new IdentityRole()
                    {
                        Id = "80970ea5-6c16-4c1d-8eb7-66940d0ad43de820885b-8490-4367-8bd6-50440fed5b39",
                        Name = "Develoooooper"
                    }
                }
            );

            _service = new RiggedService(_mockDataAccess.Object);

            // Act + Assert

            Assert.ThrowsException<NullReferenceException>(
                () => _service.GetIdentityRoleOfUser(user)
            );
        }

        // Elliot's Test Method
        [TestMethod()]
        public void CreateSlotSymbol_ReturnsFalseWithNull()
        {

            //Arrange
            bool expectedResult = false;
            SlotSymbol? nullSymbol = null;

            // DB setup
            _mockDataAccess = new Mock<IRiggedDataAccess>();
            _service = new RiggedService(_mockDataAccess.Object);

            //Act
            bool result = _service.CreateSlotSymbol(nullSymbol);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        // Elliot's Test Method
        [TestMethod()]
        public void CreateSlotSymbol_ReturnsFalseWithInvalidSlotMachineId()
        {

            //Arrange
            bool expectedResult = false;
            SlotSymbol slotSymbol = new SlotSymbol()
            {
                Id = 0,
                Name = "TestSymbol",
                Value = 0,
                Weight = 0,
                SlotMachineId = -1,
                SlotMachine = null
            };

            SlotMachine slotMachine = new SlotMachine()
            {
                Id = 0,
                Cost = 0,
                Height = 0,
                Width = 0,
                Name = "TestMachine",
                OutOfOrder = false,
                Values = new List<SlotSymbol>()
            };

            // DB setup
            _mockDataAccess = new Mock<IRiggedDataAccess>();

            _mockDataAccess.Setup<IEnumerable<SlotMachine>>(l => l.GetAllSlotMachines()).Returns(new List<SlotMachine>()
                {
                    slotMachine
                }
                );

            _mockDataAccess.Setup<IEnumerable<SlotSymbol>>(l => l.GetAllSlotSymbols()).Returns(new List<SlotSymbol>()
                {
                    slotSymbol
                }
                );

            _service = new RiggedService(_mockDataAccess.Object);

            //Act
            bool result = _service.CreateSlotSymbol(slotSymbol);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        // Jaeden's Test Method
        [TestMethod()]
        public void GetUserByIdTest()
        {

            //Arrange
            string userId = "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce";
            ApplicationUser expectedUser = new ApplicationUser()
            {
                Id = "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2ce",
                UserName = "ZaBloo",
                NormalizedUserName = "ZABLOO",
                Money = 1000000,
                Birthday = new DateTime(2000, 1, 20),
                Email = "fuller.jc@outlook.com",
                EmailConfirmed = true,
                FirstName = "Jaeden",
                LastName = "Fuller"
            };

            // DB setup
            _mockDataAccess = new Mock<IRiggedDataAccess>();
            _mockDataAccess.Setup<IEnumerable<ApplicationUser>>(x => x.GetAllUsers()).Returns(new List<ApplicationUser>()
            {
                expectedUser,
                new ApplicationUser()
                {
                    Id = "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2cd",
                    UserName = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAA",
                    NormalizedUserName = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAA",
                    Money = -1000,
                    Birthday = new DateTime(2000, 1, 20),
                    Email = "IAmInCripplingDept@SendHelp.com",
                    EmailConfirmed = true,
                    FirstName = "Liam",
                    LastName = "Lee"
                }
            });
            _service = new RiggedService(_mockDataAccess.Object);

            //Act
            ApplicationUser applicationUser = _service.GetUserById(userId);

            //Assert
            Assert.AreEqual(expectedUser, applicationUser);
        }

        [TestMethod()]
        public void GetUserByIdThatDoesntExistInDatabaseTest()
        {
            //Arrange
            string userId = "hj67e1f-cf38-45a5-94d0-8ebb0c2ce2cd";

            //DB Setup
            _mockDataAccess = new Mock<IRiggedDataAccess>();
            _mockDataAccess.Setup<IEnumerable<ApplicationUser>>(x => x.GetAllUsers()).Returns(new List<ApplicationUser>()
            {
                new ApplicationUser()
                {
                    Id = "f2672e1f-cf38-45a5-94d0-8ebb0c2ce2cd",
                    UserName = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAA",
                    NormalizedUserName = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAA",
                    Money = -1000,
                    Birthday = new DateTime(2000, 1, 20),
                    Email = "IAmInCripplingDept@SendHelp.com",
                    EmailConfirmed = true,
                    FirstName = "Liam",
                    LastName = "Lee"
                }
            });
            _service = new RiggedService(_mockDataAccess.Object);

            //Act & Assert
            Assert.ThrowsException<InvalidOperationException>(
                () => _service.GetUserById(userId)
                );
        }

        // Liam's Test Method
        [TestMethod()]
        public void SlotGameLogToSlotMachine_NoSlotOutcomes()
        {
            // Arrange
            SlotGameLog slotGameLog = new SlotGameLog()
            {
                Id = 1,
                Jackpot = false,
                MoneyInput = 10,
                MoneyOutput = 10,
                PlayerId = "Player Id Here",
                Time = DateTime.MinValue
            };

            SlotMachine slotMachine = new SlotMachine()
            {
                Id = 12,
                Cost = 10,
                Height = 10,
                OutOfOrder = false,
                Name = "Test",
                Width = 10
            };

            SlotSymbol slotSymbol = new SlotSymbol()
            {
                Id = 23,
                Name = "Da symbol",
                SlotMachineId = slotMachine.Id,
                Value = 1,
                Weight = 10
            };

            // Db setup
            _mockDataAccess = new Mock<IRiggedDataAccess>();
            _mockDataAccess.Setup<IEnumerable<SlotOutcome>>(x => x.GetAllSlotOutcomes()).Returns(new List<SlotOutcome>());
            _service = new RiggedService(_mockDataAccess.Object);

            // Assert & Action
            Assert.ThrowsException<ArgumentNullException>(
                () => _service.SlotGameLogToSlotMachine(slotGameLog)
                );
        }

        // Liam's Test Method
        [TestMethod()] 
        public void SlotGameLogToSlotMachine_NoMatchingSlotSymbol()
        {
            // Arrange 
            SlotGameLog slotGameLog = new SlotGameLog()
            {
                Id = 1,
                Jackpot = false,
                MoneyInput = 10,
                MoneyOutput = 10,
                PlayerId = "Player Id Here",
                Time = DateTime.MinValue
            };

            SlotMachine slotMachine = new SlotMachine()
            {
                Id = 12,
                Cost = 10,
                Height = 10,
                OutOfOrder = false,
                Name = "Test",
                Width = 10
            };

            SlotSymbol slotSymbol = new SlotSymbol()
            {
                Id = 23,
                Name = "Da symbol",
                SlotMachineId = slotMachine.Id,
                Value = 1,
                Weight = 10
            };

            SlotOutcome slotOutcome = new SlotOutcome()
            {
                GameId = slotGameLog.Id,
                SymbolId = slotSymbol.Id,
                Location = 1,
                SlotMachineId = slotMachine.Id,
            };

            _mockDataAccess = new Mock<IRiggedDataAccess>();
            _mockDataAccess.Setup<IEnumerable<SlotOutcome>>(x => x.GetAllSlotOutcomes()).Returns(
                new List<SlotOutcome>()
                {
                    slotOutcome
                });
            _mockDataAccess.Setup<IEnumerable<SlotSymbol>>(x => x.GetAllSlotSymbols()).Returns(new List<SlotSymbol>());
            _service = new RiggedService(_mockDataAccess.Object);

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(
                () => _service.SlotGameLogToSlotMachine(slotGameLog)
                );
        }
    }
}