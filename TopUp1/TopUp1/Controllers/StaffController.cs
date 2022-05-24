using Microsoft.AspNetCore.Mvc;
using TopUp1.Facades;
using TopUp1.DAL;
using TopUp1.Facades.Interfaces;

namespace TopUp1.Controllers
{
    public class StaffController : Controller
    {
        IStaffFacade staffFacade = new StaffFacade(new StaffDAO());
        //[Route("api/staff")]
        //[HttpGet]
        //public List<Staff> GetStaff()
        //{
        //    var staff = new List<Staff>();
        //    return staff;
        //}
        [HttpGet]
        [Route("api/staff/{ssn}")]
        public Staff GetStaffById(int ssn)
        {
            return staffFacade.GetStaffInfo(ssn);
        }
        [HttpPost]
        [Route("api/staff")]
        public bool CreateStaff(int ssn, int roleID)
        {
            Staff staff = new Staff();
            staff.SSN = ssn;
            staff.Role.RoleID = roleID;
            return staffFacade.SaveStaff(staff);
        }
        [HttpPut]
        [Route("api/staff/{ssn}")]
        public bool UpdateStaff(int ssn, int roleID, string homeAddress)
        {
            Staff staff = new Staff();
            staff.SSN = ssn;
            staff.Role.RoleID = roleID;
            staff.HomeAddress = homeAddress;
            return staffFacade.UpdateStaff(staff);
        }
        [HttpDelete]
        [Route("api/staff/{ssn}")]
        public bool DeleteStaff(int ssn)
        {
            Staff staff = new Staff();
            staff.SSN = ssn;
            return staffFacade.DeleteStaff(staff);
        }
    }
}
