namespace MainApp.ISP;

internal class BankService
{
    public void Withdraw(IAccount account, decimal amount)
    {
        if (account.Withdraw(amount))
        {
            Console.WriteLine($"Withdrawal of {amount} successful. New balance: {account.Balance}");
        }
        else
        {
            if (account is ITimeDepositAccount timeDeposit)
                LogTimeDepositError(timeDeposit);
            else
                Console.WriteLine("Withdrawal failed. Check the amount and balance.");
        }        
    }

    private void LogTimeDepositError(ITimeDepositAccount timeDeposit)
    {
        if (!timeDeposit.IsMatured())
            Console.WriteLine("Time Deposit account did not reach maturity date");
    }
}
