namespace MainApp.ISP;

internal interface ISPDemo
{
    public static void RunDemo()
    {
        var customer = new Customer(1, "Juan Dela Cruz");
        var savingsAccount = new SavingsAccount(1001, customer, 500m);
        var currentAccount = new CurrentAccount(1002, customer, 500m, 100m);
        var timeDepositAccount = new TimeDepositAccount(1003, customer, DateTime.Now, 30, 500m);

        var bankService = new BankService();

        bankService.Withdraw(savingsAccount, 100.00m);
        bankService.Withdraw(currentAccount, 600.00m);
        bankService.Withdraw(timeDepositAccount, 300m);
    }
}
