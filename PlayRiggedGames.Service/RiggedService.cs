using PlayRiggedGames.DataAccess;
using PlayRiggedGames.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayRiggedGames.Service
{
    public class RiggedService : IRiggedService
    {
        /* 
         *  there shouldnt be any input errors (ex: null, spaces, etc) at this point
         *  although if returning null then should do something abt to prevent entire solution to stop working      
         *  or controller should atleast do somethign abt that
        */

        private readonly IRiggedDataAccess _dataAccess;

        public RiggedService(IRiggedDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        #region Funcitons from Interface
        // Users CRU
        public bool CreateUser(ApplicationUser newUser)
        {
            if (_dataAccess.CreateUser(newUser))
            {
                return true;
            }
            return false;
        }
        public IEnumerable<ApplicationUser> GetAllUsers()
        {
            return _dataAccess.GetAllUsers();
        }
        public ApplicationUser GetUserById(string id)
        {
            return GetAllUsers().FirstOrDefault(x => x.Id == id);
        }
        public bool UpdateUser(ApplicationUser updateData)
        {
            if (_dataAccess.UpdateUser(updateData))
            {
                return true;
            }
            return false;
        }

        // SlotMachine CRU
        public bool CreateSlotMachine(SlotMachine newSlotMachine)
        {
            if (_dataAccess.CreateSlotMachine(newSlotMachine))
            {
                return true;
            }
            return false;
        }
        public IEnumerable<SlotMachine> GetAllSlotMachines()
        {
            return _dataAccess.GetAllSlotMachines();
        }
        public SlotMachine GetSlotMachineById(int id)
        {
            return GetAllSlotMachines().FirstOrDefault(x => x.Id == id);
        }
        public bool UpdateSlotMachine(SlotMachine updateData)
        {
            if (_dataAccess.UpdateSlotMachine(updateData))
            {
                return true;
            }
            return false;
        }

        // SlotSymbols CRU
        public bool CreateSlotSymbol(SlotSymbol newSlotSymbol)
        {
            if (_dataAccess.CreateSlotSymbol(newSlotSymbol))
            {
                return true;
            }
            return false;
        }
        public IEnumerable<SlotSymbol> GetAllSlotSymbols()
        {
            return _dataAccess.GetAllSlotSymbols();
        }
        public SlotSymbol GetSlotSymbolById(int id)
        {
            return GetAllSlotSymbols().FirstOrDefault(x => x.Id == id);
        }
        public bool UpdateSlotSymbol(SlotSymbol updateData)
        {
            if (_dataAccess.UpdateSlotSymbol(updateData))
            {
                return true;
            }
            return false;
        }


        // SlotGameLogs CR
        public bool CreateSlotGameLog(SlotGameLog slotGameLog)
        {
            if (_dataAccess.CreateSlotGameLog(slotGameLog))
            {
                return true;
            }
            return false;
        }
        public IEnumerable<SlotGameLog> GetAllSlotGameLogs()
        {
            return _dataAccess.GetAllSlotGameLogs();
        }
        public SlotGameLog GetSlotGameLogById(int id)
        {
            return GetAllSlotGameLogs().FirstOrDefault(x => x.Id == id);
        }

        // SlotOutcomes CR
        public bool CreateSlotOutcome(SlotOutcome slotOutcome)
        {
            if (_dataAccess.CreateSlotOutcome(slotOutcome))
            {
                return true;
            }
            return false;
        }
        public IEnumerable<SlotOutcome> GetAllSlotOutcomes()
        {
            return _dataAccess.GetAllSlotOutcomes();
        }
        public IEnumerable<SlotOutcome> GetSlotOutcomesBySlotMachineId(int id)
        {
            return GetAllSlotOutcomes().Where(x => x.SlotMachineId == id);
        }
        #endregion
    }
}
