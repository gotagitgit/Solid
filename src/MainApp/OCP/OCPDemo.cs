using MainApp.OCP.Accounts;
using MainApp.OCP.Validations;
using Microsoft.Extensions.DependencyInjection;

namespace MainApp.OCP;

internal class OCPDemo
{
    public static void RunDemo()
    {
        var serviceCollection = new ServiceCollection();

        serviceCollection.AddScoped<ILoggingService, LoggingService>();
        serviceCollection.AddScoped<IBankService, BankService>();
        serviceCollection.AddScoped<IAccountValidation, SavingsAccountValidation>();
        serviceCollection.AddScoped<IAccountValidation, CurrentAccountValidation>();
        serviceCollection.AddScoped<IAccountValidation, TimeDepositAccountValidation>();

        var serviceProvider = serviceCollection.BuildServiceProvider();
        
        var savingsAccount = new SavingsAccount(1001, 500m);
        var currentAccount = new CurrentAccount(1002, 500m, 100m);
        var timeDepositAccount = new TimeDepositAccount(1003, DateTime.Today.Subtract(TimeSpan.FromDays(29)), 30, 500m);

        var customer = new Customer(1, "Juan Dela Cruz", new List<IAccount>
        {
            savingsAccount,
            currentAccount,
            timeDepositAccount,
        });

        var bankService = serviceProvider.GetRequiredService<IBankService>();

        bankService.Withdraw(customer, 1001, 100.00m);
        bankService.Withdraw(customer, 1002, 600.00m);
        bankService.Withdraw(customer, 1003, 300m);

    }
}
