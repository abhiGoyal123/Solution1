
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Search.Logic;

namespace CS_Inheritence.Logic
{
    public class Accounts
    {
        /// <summary>
        /// Dynamic Polymorphism
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        public decimal GetStaffIncome(StaffLogicAbstract staff)
        {
            decimal NetIncome = staff.CalculateIncome() - staff.ShareToHospital();
            return NetIncome;
        }
    }
}

