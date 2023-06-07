using EllipticCurve;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlayRiggedGames.Domain.Models;
using PlayRiggedGames.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayRiggedGames.Service.Tests
{
    // https://learn.microsoft.com/en-us/previous-versions/visualstudio/visual-studio-2008/ms243399(v=vs.90)?redirectedfrom=MSDN

    [TestClass()]
    public class RiggedServiceTests
    {
        [TestMethod()]
        public void SlotSlotGameLogToSlotMachine_NoSlotOutcome()
        {
            // AAA
            private readonly IRiggedService _service;

            SlotMachine slotMachine = new SlotMachine()
            {
                Id = 1,
                Cost = 1,
                Width = 1,
                Height = 1,
                Name = "1",
                OutOfOrder = false
            };

            SlotSymbol symbol = new SlotSymbol()
            {
                Id = 1,
                Name = "symbol for 1",
                SlotMachineId = slotMachine.Id,
                Value = 1,
                Weight = 1
            };

            SlotGameLog slotGameLog = new SlotGameLog()
            {
                Id = 1,
                Jackpot = false,
                MoneyInput = 1,
                MoneyOutput = 1,
                PlayerId = "playerString",
                Time = DateTime.Now
            };

            Assert.ThrowsException<ArgumentNullException>(
                () =>
                );
        }

        [TestMethod()]
        public void SlotGameLogToSlotMachineTest()
        {
            Assert.Fail();
        }
    }
}