using System;

public class Author
{
	int authorID;
	string fName;
	string mInit;
	string lName;

    public Author(int authorID, string fName, string mInit, string lName)
    {
        this.authorID = authorID;
        this.fName = fName;
        this.mInit = mInit;
        this.lName = lName;
    }
}
