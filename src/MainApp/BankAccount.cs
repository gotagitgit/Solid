namespace MainApp;

public class BankAccount
{  
    private decimal _balance;

    public BankAccount(int accountId, string accountHolderName, decimal balance)
    {
        AccountId = accountId;
        AccountHolderName = accountHolderName;
        _balance = balance;
    }

    public int AccountId { get; private set; }
    public string AccountHolderName { get; private set; }

    public decimal GetBalance()
    {
        return _balance;
    }

    public bool Withdraw(decimal amount)
    {
        if (amount <= 0 || amount > _balance)
        {
            return false;
        }

        _balance -= amount;
        LogTransaction(amount);
        return true;
    }

    private void LogTransaction(decimal amount)
    {
        Console.WriteLine($"Withdrawal of {amount:C} from Account ID {AccountId}");
    }
}

