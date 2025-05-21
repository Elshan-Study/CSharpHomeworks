namespace Library;

public class Member
{
    public string Name;
    public int TicketNumber;

    public Member(string name, int ticketNumber)
    {
        Name = name;
        TicketNumber = ticketNumber;
    }

    public override string ToString()
    {
        return $"Member: {Name}, Ticket #: {TicketNumber}";
    }
}