namespace MainApp.DIP;

internal interface IBankService
{
    void Withdraw(IAccount account, decimal amount);
}