namespace MainApp.LSP;

internal class BankService
{
    public void Withdraw(Account account, decimal amount)
    {
        if (account.Withdraw(amount))
        {
            Console.WriteLine($"Withdrawal of {amount} successful. New balance: {account.Balance}");
        }
        else
        {
            Console.WriteLine("Withdrawal failed. Check the amount and balance.");
        }
    }
}
