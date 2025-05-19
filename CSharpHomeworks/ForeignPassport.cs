namespace CSharpHomeworks;

public class ForeignPassport
{
    private readonly string _passportNumber;
    private readonly string _fullName;
    private readonly DateTime _issueDate;
    private readonly string _citizenship;
    
    public ForeignPassport(string passportNumber, string fullName, DateTime issueDate, string citizenship)
    {
        if (string.IsNullOrWhiteSpace(passportNumber))
            throw new ArgumentException("Passport number cannot be empty.");

        if (string.IsNullOrWhiteSpace(fullName))
            throw new ArgumentException("Full name cannot be empty.");

        if (issueDate > DateTime.Now)
            throw new ArgumentException("The issue date cannot be in the future..");

        if (string.IsNullOrWhiteSpace(citizenship))
            throw new ArgumentException("Citizenship cannot be empty.");

        _passportNumber = passportNumber;
        _fullName = fullName;
        _issueDate = issueDate;
        _citizenship = citizenship;
    }
    
    public override string ToString()
    {
        return $"Foreign Passport:\n" +
               $"Passport Number: {_passportNumber}\n" +
               $"Full Name: {_fullName}\n" +
               $"Issue Date: {_issueDate.ToShortDateString()}\n" +
               $"Citizenship: {_citizenship}";
    }
}