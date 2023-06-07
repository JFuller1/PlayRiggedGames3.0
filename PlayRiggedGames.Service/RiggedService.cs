using Microsoft.AspNetCore.Identity;
using PlayRiggedGames.DataAccess;
using PlayRiggedGames.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            return GetAllSlotMachines().First(x => x.Id == id);
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
        public IEnumerable<SlotSymbol> GetSlotSymbolsBySlotMachineId(int id)
        {
            return GetAllSlotSymbols().Where(x => x.SlotMachineId == id);
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

        public int GetSlotSymbolIdByName(string name)
        {
            return _dataAccess.GetAllSlotSymbols().Where(symbol => symbol.Name == name).FirstOrDefault().Id;
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
        public IEnumerable<SlotOutcome> GetSlotOutcomesBySlotGameLogId(int id)
        {
            var all = _dataAccess.GetAllSlotOutcomes();
            // var returning = all.Where(x => (int)x.GameId == id).ToArray();       // this returning null

            List<SlotOutcome> returning = new List<SlotOutcome>();

            foreach(var outcome in all)
            {
                if (outcome.GameId == id)
                {
                    returning.Add(outcome);
                }
            }

            return returning.ToArray();
        }

        // IdentityRole CRU 
        public bool CreateIdentityRole(string roleName)
        {
            try
            {
                _dataAccess.CreateIdentityRole(new IdentityRole(roleName));
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public IEnumerable<IdentityRole> GetAllIdentityRoles()
        {
            return _dataAccess.GetAllIdentityRoles();
        }
        public IdentityRole GetIdentityRoleById(string id)
        {
            return _dataAccess.GetAllIdentityRoles().FirstOrDefault(x => x.Id == id);
        }
        public IdentityRole GetIdentityRoleByName(string name)
        {
            return GetAllIdentityRoles().FirstOrDefault(x => x.Name == name);
        }
        public bool UpdateIdentityRole(IdentityRole role)
        {
            if (_dataAccess.UpdateIdentityRole(role))
            {
                return true;
            }
            return false;
        }

        // IdentityUserRole CRU
        public bool CreateIdentityUserRole(string userId, string roleId)
        {
            try
            {
                List<string> userIdWithRoles = GetAllIdentityUserRoles().Select(x => x.UserId).ToList();
                List<string> roleIds = GetAllIdentityRoles().Select(x => x.Id).ToList();

                if (userIdWithRoles.Contains(userId))
                {
                    throw new Exception("User already has role. Modify instead of adding.");
                }
                else if (!roleIds.Contains(roleId))
                {
                    throw new Exception("Specified role does not exist.");
                }
                else
                {
                    // All clear
                    _dataAccess.CreateIdentityUserRole(new IdentityUserRole<string>()
                    {
                        UserId = userId,
                        RoleId = roleId
                    });
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public IEnumerable<IdentityUserRole<string>> GetAllIdentityUserRoles()
        {
            return _dataAccess.GetAllIdentityUserRoles();
        }
        public IdentityRole GetIdentityRoleOfUser(ApplicationUser user)
        {
            return GetIdentityRoleById(GetAllIdentityUserRoles().Where(x => x.UserId == user.Id).Select(x => x.RoleId).FirstOrDefault());
        }
        public bool UpdateIdentityUserRole(ApplicationUser user, IdentityRole role)
        {
            IdentityUserRole<string> updateData = new()
            {
                UserId = user.Id,
                RoleId = role.Id
            };

            if (_dataAccess.UpdateIdentityUserRole(updateData))
            {
                return true;
            }
            return false;
        }

        // Converter
        public SlotMachine SlotGameLogToSlotMachine(SlotGameLog input)
        {
            // SlotGameLog --> SlotOutcomes --> SlotOutcome --> SlotSymbol --> SlotGameLog
            List<SlotOutcome> slotOutcomes = GetSlotOutcomesBySlotGameLogId(input.Id).ToList();     // still returning null
            
            SlotOutcome firstSlotOutcome = slotOutcomes.First();

            SlotSymbol theSymbol = GetSlotSymbolById(firstSlotOutcome.SymbolId);

            return GetSlotMachineById(theSymbol.SlotMachineId);
        }

        #endregion
    }
}
