using System;

public class Volume
{
	string titleISBN;
	int volumeNumber;
	bool borrowed;
	public Volume(string titleISBN, int volumeNumber, bool borrowed)
	{
		this.titleISBN = titleISBN;
		this.volumeNumber = volumeNumber;
		this.borrowed = borrowed;
	}
}