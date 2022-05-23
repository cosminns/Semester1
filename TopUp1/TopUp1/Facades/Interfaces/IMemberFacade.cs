
namespace TopUp1.Facades.Interfaces
{
    public interface IMemberFacade
    {
        public bool SaveMember(Member member);
        public bool UpdateMember(Member member);
        public bool DeleteMember(Member member);
        public Member GetMemberBySSN(int ssn);
    }
}