using Microsoft.AspNetCore.Mvc;

namespace TopUp1.Controllers
{
    public class MemberController : Controller
    {
        [Route("api/member")]
        [HttpGet]
        public List<Member> GetMembers()
        {
            var members = new List<Member>();
            return members;
        }
        [HttpGet]
        [Route("api/member/{id}")]
        public Member GetMemberById(int id)
        {
            var member = new Member(1, "string", "string", true);
            return member;
        }
        [HttpPost]
        [Route("api/member")]
        public bool CreateMember(int sSN, string campusAddress, string joinDate, bool isProfessor)
        {
            var result = true;
            return result;
        }
        [HttpPut]
        [Route("api/member/{id}")]
        public bool UpdateMember(int memberSSN, string titleISBN, int volumeNumber, string lendDate, string returnDate)
        {
            //Checks for null parameters
            var result = true;
            return result;
        }
        [HttpDelete]
        [Route("api/member/{id}")]
        public bool DeleteMember(int id)
        {
            bool result = true;
            return result;
        }
    }
}
