namespace MainApp.LSP;

internal class SavingsAccount(int accountId, Customer customer, decimal balance) : Account(accountId, customer, balance)
{
    public override bool Withdraw(decimal amount)
    {
        if (amount <= 0 || amount > Balance)
            return false;             

        Balance -= amount;

        return true;
    }
}
