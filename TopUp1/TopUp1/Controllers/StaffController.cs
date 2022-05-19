using Microsoft.AspNetCore.Mvc;

namespace TopUp1.Controllers
{
    public class StaffController : Controller
    {

        [Route("api/staff")]
        [HttpGet]
        public List<Staff> GetStaff()
        {
            var staff = new List<Staff>();
            return staff;
        }
        [HttpGet]
        [Route("api/staff/{id}")]
        public Staff GetStaffById(int id)
        {
            var staff = new Staff(1, 1);
            return staff;
        }
        [HttpPost]
        [Route("api/staff")]
        public bool CreateStaff(int sSN, int roleID)
        {
            var result = true;
            return result;
        }
        [HttpPut]
        [Route("api/staff/{id}")]
        public bool UpdateStaff(int SSN, int roleID)
        {
            //Checks for null parameters
            var result = true;
            return result;
        }
        [HttpDelete]
        [Route("api/staff/{id}")]
        public bool DeleteStaff(int id)
        {
            bool result = true;
            return result;
        }
    }
}
