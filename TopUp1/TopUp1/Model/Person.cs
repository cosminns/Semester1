using System;
using System.Collections.Generic;

public class Person
{
    public int SSN { get; set; }
    public string Name { get; set; } = default!;
    public string HomeAddress { get; set; } = default!;
    public string BirthDate { get; set; } = default!;
    public List<string> PhoneNumbers { get; set; } = new List<string>();
}