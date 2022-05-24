using System;

public class Member : Person
{
    public string CampusAddress { get; set; } = default!;
    public string JoinDate { get; set; } = default!;
    public bool IsProfessor { get; set; }
    public Card Card { get; set; } = new Card();
}