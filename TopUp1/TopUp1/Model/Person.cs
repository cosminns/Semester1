using System;

public class Person
{
	int SSN;
	string fName;
	string mInit;
	string lName;
	string homeAddress;
	string birthDate;

    public Person(int sSN, string fName, string mInit, string lName, string homeAddress, string birthDate)
    {
        SSN = sSN;
        this.fName = fName;
        this.mInit = mInit;
        this.lName = lName;
        this.homeAddress = homeAddress;
        this.birthDate = birthDate;
    }
}