namespace MainApp.OCP.Accounts;

internal class Account(int accountId, decimal balance)
{
    public decimal Balance { get; set; } = balance;

    public int AccountId { get; } = accountId;

    public void Deposit(decimal amount) => Balance += amount;

    public void Withdraw(decimal amount) => Balance -= amount;
}

