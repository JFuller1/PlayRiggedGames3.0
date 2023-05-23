using PlayRiggedGames.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayRiggedGames.Service
{
    public interface IRiggedService
    {
        /*
         *  // Table name, function
         *  - Create
         *      Create object
         *  - Read
         *      Read all
         *          Read that belongs to something  (in service)
         *          Read one                        (in service)
         *  - Update
         *      Update object
         */

        /*
         *  Updating something:
         *      Let user select one object
         *      let the object have all values from original as default
         *      let them change a few things
         *      the changes will be applied to the object 
         */

        // Users CRU
        bool CreateUser(ApplicationUser newUser);
        IEnumerable<ApplicationUser> GetAllUsers();
        ApplicationUser GetUserById(string id);
        bool UpdateUser(ApplicationUser updateData);

        // SlotMachine CRU
        bool CreateSlotMachine(SlotMachine newSlotMachine);
        IEnumerable<SlotMachine> GetAllSlotMachines();
        SlotMachine GetSlotMachineById(int id);
        bool UpdateSlotMachine(SlotMachine updateData);

        // SlotSymbols CRU
        bool CreateSlotSymbol(SlotSymbol newSlotSymbol);
        IEnumerable<SlotSymbol> GetAllSlotSymbols();
        SlotSymbol GetSlotSymbolById(int id);
        bool UpdateSlotSymbol(SlotSymbol updateData);


        // SlotGameLogs CR
        bool CreateSlotGameLog(SlotGameLog slotGameLog);
        IEnumerable<SlotGameLog> GetAllSlotGameLogs();
        SlotGameLog GetSlotGameLogById(int id);

        // SlotOutcomes CR
        bool CreateSlotOutcome(SlotOutcome slotOutcome);
        IEnumerable<SlotOutcome> GetAllSlotOutcomes();
        IEnumerable<SlotOutcome> GetSlotOutcomesBySlotMachineId(int id);
    }
}
