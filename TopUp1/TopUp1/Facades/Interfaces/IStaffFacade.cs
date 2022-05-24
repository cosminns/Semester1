using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopUp1.Facades.Interfaces
{
    public interface IStaffFacade
    {
        public bool SaveStaff(Staff staff);
        public bool UpdateStaff(Staff staff);
        public bool DeleteStaff(Staff staff);
        public Staff GetStaffInfo(int ssn);
    }
}