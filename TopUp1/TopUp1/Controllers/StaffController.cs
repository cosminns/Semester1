using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace TopUp1.Controllers
{
    public class StaffController : Controller
    {

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
            using (SqlConnection conn = new SqlConnection("Server=gtlgroup5.database.windows.net; Database=GTL; User Id = gtlgroup5admin; Password=5Pn4HVsMtZwmJYv;"))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prGetStaffInfo", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@SSN", ssn));
                SqlDataReader rdr;
                // execute the command
                rdr = cmd.ExecuteReader();
                Staff staff = new Staff();
                while (rdr.Read())
                {
                    staff.SSN = (int)rdr["SSN"];
                    staff.Name = (string)rdr["Name"];
                    staff.HomeAddress = (string)rdr["HomeAddress"];
                    staff.BirthDate = ((DateTime)rdr["DoB"]).ToShortDateString();
                    staff.Role = (string)rdr["RoleName"];
                }
                rdr.Close();

                //create a command to get the phone numbers and add them to the staff

                cmd = new SqlCommand("prGetPersonPhoneNumbers", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@SSN", ssn));
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    staff.PhoneNumbers.Add((string)rdr["PhoneNumber"]);
                }
                rdr.Close();

                return staff;
            }
        }
        [HttpPost]
        [Route("api/staff")]
        public bool CreateStaff(int SSN, int roleID)
        {
            using (SqlConnection conn = new SqlConnection("Server=gtlgroup5.database.windows.net; Database=GTL; User Id = gtlgroup5admin; Password=5Pn4HVsMtZwmJYv;"))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prInsertStaff", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@SSN", SSN));
                cmd.Parameters.Add(new SqlParameter("@Role_ID", roleID));
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    return true;
                }
                else return false;
            }
        }
        [HttpPut]
        [Route("api/staff/{ssn}")]
        public bool UpdateStaff(int ssn, int roleID, string homeAddress)
        {
            using (SqlConnection conn = new SqlConnection("Server=gtlgroup5.database.windows.net; Database=GTL; User Id = gtlgroup5admin; Password=5Pn4HVsMtZwmJYv;"))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prUpdateStaff", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@SSN", ssn));
                cmd.Parameters.Add(new SqlParameter("@Role_ID", roleID));
                cmd.Parameters.Add(new SqlParameter("@HomeAddress", homeAddress));
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    return true;
                }
                else return false;
            }
        }
        [HttpDelete]
        [Route("api/staff/{ssn}")]
        public bool DeleteStaff(int ssn)
        {
            using (SqlConnection conn = new SqlConnection("Server=gtlgroup5.database.windows.net; Database=GTL; User Id = gtlgroup5admin; Password=5Pn4HVsMtZwmJYv;"))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prDeleteStaff", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@SSN", ssn));
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    return true;
                }
                else return false;
            }
        }
    }
}
