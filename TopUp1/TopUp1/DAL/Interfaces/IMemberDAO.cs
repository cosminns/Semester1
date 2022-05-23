
namespace TopUp1.DAL.Interfaces
{
    public interface IMemberDAO
    {
        public Member GetMemberBySSN(int ssn);
        public bool CreateMember(Member member);
        public bool UpdateMember(Member member);
        public bool DeleteMember(Member member);
    }
}