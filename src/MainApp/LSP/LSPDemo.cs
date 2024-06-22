namespace MainApp.LSP;

internal class LSPDemo
{
    public static void Run()
    {
        var customer = new Customer(1, "Juan Dela Cruz");
        var savingsAccount = new SavingsAccount(1001, customer, 500m);
        var currentAccount = new CurrentAccount(1002, customer, 500m, 100m);
        
        var bankService = new BankService();

        bankService.Withdraw(savingsAccount, 100.00m);
        bankService.Withdraw(currentAccount, 600.00m);
    }
}
