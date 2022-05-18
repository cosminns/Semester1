using System;

public class Card
{
	int cardNumber;
	Image photo;
	string expiryDate;
	int memberSSN;

    public Card(int cardNumber, Image photo, string expiryDate, string memberSSN)
    {
        this.cardNumber = cardNumber;
        this.photo = photo;
        this.expiryDate = expiryDate;
        this.memberSSN = memberSSN;
    }

}