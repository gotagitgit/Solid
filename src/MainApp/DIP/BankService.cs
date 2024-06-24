namespace MainApp.DIP;

internal class BankService : IBankService
{
    private readonly ILoggingService _loggingService;

    public BankService(ILoggingService loggingService)
    {
        _loggingService = loggingService;
    }

    public void Withdraw(IAccount account, decimal amount)
    {
        if (account.Withdraw(amount))
        {
            _loggingService.LogMessage($"Withdrawal of {amount} successful. New balance: {account.Balance}");            
        }
        else
        {
            if (account is ITimeDepositAccount timeDeposit)
                LogTimeDepositError(timeDeposit);
            else
                _loggingService.LogMessage("Withdrawal failed. Check the amount and balance.");
        }
    }

    private void LogTimeDepositError(ITimeDepositAccount timeDeposit)
    {
        if (!timeDeposit.IsMatured())
            _loggingService.LogMessage("Time Deposit account did not reach maturity date");
    }
}
