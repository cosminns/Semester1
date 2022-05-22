using System;

public class BorrowBook
{
    public Member Member { get; set; } = default!;
    public Volume Volume { get; set; } = default!;
    public string LendDate { get; set; } = default!;
    public string ReturnDate { get; set; } = default!;
}
