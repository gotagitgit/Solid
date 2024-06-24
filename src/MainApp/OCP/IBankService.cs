namespace MainApp.OCP;

internal interface IBankService
{
    void Withdraw(Customer customer, int accountId, decimal amount);
}