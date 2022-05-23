using TopUp1.Facades.Interfaces;
using TopUp1.DAL.Interfaces;

namespace TopUp1.Facades
{
    public class MemberFacade : IMemberFacade
    {
        private IMemberDAO memberDAO;
        public MemberFacade(IMemberDAO memberDAO)
        {
            this.memberDAO = memberDAO;
        }

        public bool SaveMember(Member member)
        {
            return memberDAO.CreateMember(member);
        }

        public bool UpdateMember(Member member)
        {
            return memberDAO.UpdateMember(member);
        }

        public bool DeleteMember(Member member)
        {
            return memberDAO.DeleteMember(member);
        }

        public Member GetMemberBySSN(int ssn)
        {
            return memberDAO.GetMemberBySSN(ssn);
        }
    }
}