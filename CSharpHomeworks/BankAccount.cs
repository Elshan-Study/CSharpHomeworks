namespace CSharpHomeworks;

public class BankAccount
{
    private readonly string _ownerName;
    private decimal _balance;

    public BankAccount(string ownerName, decimal initialBalance)
    {
        if (string.IsNullOrWhiteSpace(ownerName))
            throw new ArgumentException("Owner name cannot be empty.");
        if (initialBalance < 0)
            throw new ArgumentException("Initial balance cannot be negative.");

        _ownerName = ownerName;
        _balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive.");

        _balance += amount;
        Console.WriteLine($"Deposited: {amount}. New balance: {_balance}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be positive.");

        if (amount > _balance)
            throw new InvalidOperationException("Insufficient funds.");

        _balance -= amount;
        Console.WriteLine($"Withdrawn: {amount}. Remaining balance: {_balance}");
    }

    public override string ToString() =>
        $"Account owner: {_ownerName}\nBalance: {_balance}";
}