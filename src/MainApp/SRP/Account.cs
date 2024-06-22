namespace MainApp.SRP;

internal class Account(int accountId, Customer customer, decimal balance)
{
    public int AccountId { get; } = accountId;

    public Customer Customer { get; } = customer;

    public decimal Balance { get; set; } = balance;

    public bool Withdraw(decimal amount)
    {
        if (amount <= 0 || amount > Balance)
            return false;

        Balance -= amount;

        return true;
    }
}

    