namespace MainApp.SRP;

public class BankAccount(int accountId, string accountHolderName, decimal balance)
{
    private decimal _balance = balance;

    public int AccountId { get; } = accountId;
    public string AccountHolderName { get; } = accountHolderName;

    public decimal GetBalance()
    {
        return _balance;
    }

    public bool Withdraw(decimal amount)
    {
        if (amount <= 0 || amount > _balance)
        {
            Console.WriteLine("You have insufficient amount");

            return false;
        }

        _balance -= amount;
        Console.WriteLine($"Withdrawal of {amount:C} from Account ID {AccountId}");
        return true;
    }
}

