using TopUp1.Facades.Interfaces;
using TopUp1.DAL.Interfaces;

namespace TopUp1.Facades
{
    public class MemberFacade : IMemberFacade
    {
        private IDAO<Member> memberDAO;
        public MemberFacade(IDAO<Member> memberDAO)
        {
            this.memberDAO = memberDAO;
        }

        public bool SaveMember(Member member)
        {
            return memberDAO.Create(member);
        }

        public bool UpdateMember(Member member)
        {
            return memberDAO.Update(member);
        }

        public bool DeleteMember(Member member)
        {
            return memberDAO.Delete(member);
        }

        public Member GetMemberInfo(int ssn)
        {
            return memberDAO.GetById(new Member { SSN = ssn });
        }
    }
}