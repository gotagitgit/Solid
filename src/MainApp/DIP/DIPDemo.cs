using Microsoft.Extensions.DependencyInjection;

namespace MainApp.DIP;
internal class DIPDemo
{
    public static void RunDemo()
    {
        var serviceCollection = new ServiceCollection();

        //serviceCollection.AddScoped<ILoggingService, LoggingService>();
        serviceCollection.AddScoped<ILoggingService, DiagnosticsLogging>();
        serviceCollection.AddScoped<IBankService, BankService>();

        var serviceProvider = serviceCollection.BuildServiceProvider();

        var customer = new Customer(1, "Juan Dela Cruz");
        var savingsAccount = new SavingsAccount(1001, customer, 500m);
        var currentAccount = new CurrentAccount(1002, customer, 500m, 100m);
        var timeDepositAccount = new TimeDepositAccount(1003, customer, DateTime.Today.Subtract(TimeSpan.FromDays(29)), 30, 500m);

        var bankService = serviceProvider.GetRequiredService<IBankService>();

        bankService.Withdraw(savingsAccount, 100.00m);
        bankService.Withdraw(currentAccount, 600.00m);
        bankService.Withdraw(timeDepositAccount, 300m);

    }
}
