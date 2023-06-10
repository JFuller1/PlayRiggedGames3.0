using EllipticCurve;
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