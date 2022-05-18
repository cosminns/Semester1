using System;

public class Member
{
	int SSN;
	string campusAddress;
	string joinDate;
	bool isProfessor;

    public Member(int sSN, string campusAddress, string joinDate, bool isProfessor)
    {
        SSN = sSN;
        this.campusAddress = campusAddress;
        this.joinDate = joinDate;
        this.isProfessor = isProfessor;
    }
}