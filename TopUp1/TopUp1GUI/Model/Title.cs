using System;
using System.Collections.Generic;

public class Title
{
    public string ISBN { get; set; } = default!;
    public string TitleDesc { get; set; } = default!;
    public string TitleTitle { get; set; } = default!;
    public string Publisher { get; set; } = default!;
    public string PublishingDate { get; set; } = default!;
    public string SubjectArea { get; set; } = default!;
    public string TitleType { get; set; } = default!;
    public string TitleStatus { get; set; } = default!;
    public List<string> Authors { get; set; } = new List<string>();
}