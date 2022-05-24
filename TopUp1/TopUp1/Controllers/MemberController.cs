using Microsoft.AspNetCore.Mvc;
using TopUp1.Facades;
using TopUp1.DAL;
using TopUp1.Facades.Interfaces;

namespace TopUp1.Controllers
{
    public class MemberController : Controller
    {
        IMemberFacade memberFacade = new MemberFacade(new MemberDAO());

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
        [Route("api/member/{ssn}")]
        public Member GetMemberById(int ssn)
        {
            return memberFacade.GetMemberInfo(ssn);
        }

        [HttpPost]
        [Route("api/member")]
        public bool CreateMember(int SSN, string campusAddress, bool isProfessor)
        {
            Member member = new Member();
            member.SSN = SSN;
            member.CampusAddress = campusAddress;
            member.IsProfessor = isProfessor;
            return memberFacade.SaveMember(member);
        }

        [HttpPut]
        [Route("api/member/{ssn}")]
        public bool UpdateMember(int ssn, string campusAddress, DateTime joinDate, bool isProfessor, string homeAddress)
        {
            Member member = new Member();
            member.SSN = ssn;
            member.CampusAddress = campusAddress;
            member.JoinDate = joinDate.ToShortDateString();
            member.IsProfessor = isProfessor;
            member.HomeAddress = homeAddress;
            return memberFacade.UpdateMember(member);
        }

        [HttpDelete]
        [Route("api/member/{ssn}")]
        public bool DeleteMember(int ssn)
        {
            Member member = new Member();
            member.SSN = ssn;
            return memberFacade.DeleteMember(member);
        }
    }
}
