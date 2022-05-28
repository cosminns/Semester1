using System;

public class BorrowBook
{
    public Member Member { get; set; } = new Member();
    public Volume Volume { get; set; } = new Volume();
    public string LendDate { get; set; } = default!;
    public string DeadLine { get; set; } = default!;
    public string ReturnDate { get; set; } = default!;
}
