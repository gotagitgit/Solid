using MainApp.OCP.Accounts;
using MainApp.OCP.Validations;
using MainApp.OCP.VisitorPattern.Loans;
using MainApp.OCP.VisitorPattern.LoanVisitors;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks.Dataflow;

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

        var loans = new List<Loan>
        {
            new CarLoan(100000, 3),
            new PersonalLoan(10000, 1)

        };

        var accounts = new List<IAccount>
        {
            savingsAccount,
            currentAccount,
            timeDepositAccount,
        };

        var customer1 = new Customer(1, "Juan Dela Cruz", accounts, loans);

        var bankService = serviceProvider.GetRequiredService<IBankService>();

        bankService.Withdraw(customer1, 1001, 100.00m);
        bankService.Withdraw(customer1, 1002, 600.00m);
        bankService.Withdraw(customer1, 1003, 300m);

        bankService.ComputeTotalLoans(customer1, new StandardLoanRate());

        var customer2 = new Customer(2, "Juanita Dimagiba", accounts, loans);

        bankService.ComputeTotalLoans(customer2, new SpecialLoanRate());
    }
}
