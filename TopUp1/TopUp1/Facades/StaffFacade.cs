using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopUp1.Facades.Interfaces;
using TopUp1.DAL.Interfaces;

namespace TopUp1.Facades
{
    public class StaffFacade : IStaffFacade
    {
        private IDAO<Staff> staffDAO;
        public StaffFacade(IDAO<Staff> staffDAO)
        {
            this.staffDAO = staffDAO;
        }

        public bool DeleteStaff(Staff staff)
        {
            return staffDAO.Delete(staff);
        }

        public Staff GetStaffInfo(int ssn)
        {
            return staffDAO.GetById(new Staff { SSN = ssn });
        }

        public bool SaveStaff(Staff staff)
        {
            return staffDAO.Create(staff);
        }

        public bool UpdateStaff(Staff staff)
        {
            return staffDAO.Update(staff);
        }
    }
}