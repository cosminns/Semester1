using System;

public class Member : Person
{
    public string CampusAddress { get; set; }
    public string JoinDate { get; set; }
    public bool IsProfessor { get; set; }
    public Card Card { get; set; }
}