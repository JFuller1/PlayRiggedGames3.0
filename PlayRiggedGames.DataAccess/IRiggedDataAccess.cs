using PlayRiggedGames.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayRiggedGames.DataAccess
{
    public interface IRiggedDataAccess
    {
        /*
         *  Split up functions:
         *      Let DataAccess layer to just spit out all data into correct objects
         *      Do the narrowing in Services 
         *      
         *  Create and Update should return bool to clarify that the process success.
         *  For Get all if anything goes wrong its going to return null anyway.
         */
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
        bool UpdateUser(ApplicationUser updateData);

        // SlotMachine CRU
        bool CreateSlotMachine(SlotMachine newSlotMachine);         
        IEnumerable<SlotMachine> GetAllSlotMachines();
        bool UpdateSlotMachine(SlotMachine updateData);

        // SlotSymbols CRU
        bool CreateSlotSymbol(SlotSymbol newSlotSymbol);
        IEnumerable<SlotSymbol> GetAllSlotSymbols();
        bool UpdateSlotSymbol(SlotSymbol updateData);


        // SlotGameLogs CR
        bool CreateSlotGameLog(SlotGameLog slotGameLog);                
        IEnumerable<SlotGameLog> GetAllSlotGameLogs();

        // SlotOutcomes CR
        bool CreateSlotOutcome(SlotOutcome slotOutcome);            
        IEnumerable<SlotOutcome> GetAllSlotOutcomes();              

    }
}
