using System;

public class Title
{
	string ISBN;
	string titleDesc;
	string title;
	string publisher;
	string publishingDate;
	string subjectArea;
	string titleType;
	string titleStatus;

    public Title(string iSBN, string titleDesc, string title, string publisher, string publishingDate, string subjectArea, string titleType, string titleStatus)
    {
        ISBN = iSBN;
        this.titleDesc = titleDesc;
        this.title = title;
        this.publisher = publisher;
        this.publishingDate = publishingDate;
        this.subjectArea = subjectArea;
        this.titleType = titleType;
        this.titleStatus = titleStatus;
    }
}