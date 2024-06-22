namespace MainApp.SRP;

internal class SRPDemo
{
    public static void NoSRP()
    {
        var bankAccount = new BankAccount(1, "Juan Dela Cruz", 100m);

        bankAccount.Withdraw(50m);
        var balance = bankAccount.GetBalance();

        Console.WriteLine($"Your remaining Balance is {balance}");

        bankAccount.Withdraw(100m);
    }

    public static void WithSRP()
    {
        var customer = new Customer(1, "Juan Dela Cruz");
        var account = new Account(1001, customer, 500.00m);     
        var bankService = new BankService();

        bankService.Withdraw(account, 100.00m); 
        bankService.Withdraw(account, 600.00m);
    }
}
