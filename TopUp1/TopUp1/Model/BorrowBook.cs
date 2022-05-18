using System;

public class BorrowBook
{
	int memberSSN;
	string titleISBN;
	int volumeNumber;
	string lendDate;
	string returnDate;

    public BorrowBook(int memberSSN, string titleISBN, int volumeNumber, string lendDate, string returnDate)
    {
        this.memberSSN = memberSSN;
        this.titleISBN = titleISBN;
        this.volumeNumber = volumeNumber;
        this.lendDate = lendDate;
        this.returnDate = returnDate;
    }
}
