using System;


public class Card
{
	int cardNumber;
	string photo;
	string expiryDate;
	int memberSSN;

    public Card(int cardNumber, string photo, string expiryDate, int memberSSN)
    {
        this.cardNumber = cardNumber;
        this.photo = photo;
        this.expiryDate = expiryDate;
        this.memberSSN = memberSSN;
    }

}