using System;
using System.Collections.Generic;

public class Person
{
    public int SSN { get; set; }
    public string Name { get; set; }
    public string HomeAddress { get; set; }
    public string BirthDate { get; set; }
    public List<string> PhoneNumbers { get; set; } = new List<string>();
}