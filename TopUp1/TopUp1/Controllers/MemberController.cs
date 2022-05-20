using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace TopUp1.Controllers
{
    public class MemberController : Controller
    {
        /*[Route("api/member")]
        [HttpGet]
        public List<Member> GetMembers()
        {
             List<Member>list=new List<Member>();
            using (SqlConnection conn = new SqlConnection("Server=gtlgroup5.database.windows.net; Database=GTL; User Id = gtlgroup5admin; Password=5Pn4HVsMtZwmJYv;"))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prGetMemberInfo", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@MemberSSN", 10002354));
                SqlDataReader rdr = null;
                // execute the command
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Member member = new Member();
                    member.SSN = (int)rdr["SSN"];
                    member.CampusAddress = (string)rdr["CampusAddress"];
                    member.JoinDate = ((DateTime)rdr["JoinDate"]).ToShortDateString();
                    member.IsProfessor = (bool)rdr["IsProfessor"];
                    list.Add(member);
                }
            }
            return list;
        }*/
        [HttpGet]
        [Route("api/member/{id}")]
        public Member GetMemberById(int id)
        {
            using (SqlConnection conn = new SqlConnection("Server=gtlgroup5.database.windows.net; Database=GTL; User Id = gtlgroup5admin; Password=5Pn4HVsMtZwmJYv;"))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prGetMemberInfo", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@MemberSSN", id));
                SqlDataReader rdr = null;
                // execute the command
                rdr = cmd.ExecuteReader();
                Member member = new Member();
                while (rdr.Read())
                {
                    member.SSN = (int)rdr["SSN"];
                    member.Name = (string)rdr["Name"];
                    member.HomeAddress = (string)rdr["HomeAddress"];
                    member.BirthDate = ((DateTime)rdr["DoB"]).ToShortDateString();
                    member.CampusAddress = (string)rdr["CampusAddress"];
                    member.JoinDate = ((DateTime)rdr["JoinDate"]).ToShortDateString();
                    member.IsProfessor = (bool)rdr["IsProfessor"];

                }
                return member;
            }
        }
        [HttpPost]
        [Route("api/member")]
        public bool CreateMember(int SSN, string campusAddress, bool isProfessor)
        {
            using (SqlConnection conn = new SqlConnection("Server=gtlgroup5.database.windows.net; Database=GTL; User Id = gtlgroup5admin; Password=5Pn4HVsMtZwmJYv;"))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prInsertMember", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@MemberSSN", SSN));
                cmd.Parameters.Add(new SqlParameter("@CampusAddress", campusAddress));
                cmd.Parameters.Add(new SqlParameter("@JoinDate", DateTime.Today));
                cmd.Parameters.Add(new SqlParameter("@IsProfessor", isProfessor));
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    return true;
                }
                else return false;
            }
        }
        [HttpPut]
        [Route("api/member/{id}")]
        public bool UpdateMember(int id, string campusAddress, DateTime joinDate, bool isProfessor, string homeAddress)
        {
            using (SqlConnection conn = new SqlConnection("Server=gtlgroup5.database.windows.net; Database=GTL; User Id = gtlgroup5admin; Password=5Pn4HVsMtZwmJYv;"))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prUpdateMember", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@MemberSSN", id));
                cmd.Parameters.Add(new SqlParameter("@CampusAddress", campusAddress));
                cmd.Parameters.Add(new SqlParameter("@JoinDate", joinDate));
                cmd.Parameters.Add(new SqlParameter("@IsProfessor", isProfessor));
                cmd.Parameters.Add(new SqlParameter("@HomeAddress", homeAddress));
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    return true;
                }
                else return false;
            }
        }
        [HttpDelete]
        [Route("api/member/{id}")]
        public bool DeleteMember(int id)
        {
            using (SqlConnection conn = new SqlConnection("Server=gtlgroup5.database.windows.net; Database=GTL; User Id = gtlgroup5admin; Password=5Pn4HVsMtZwmJYv;"))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prDeleteMember", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@MemberSSN", id));
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    return true;
                }
                else return false;
            }
        }
    }
}
