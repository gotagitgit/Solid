using MainApp;
using MainApp.ISP;

namespace SolidTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var bankService = new BankService();

        var customer = new Customer(1, "Tests");

        var savingsAccount = new SavingsAccount(1, customer, 100m);

        bankService.Withdraw(savingsAccount, 50m);
    }
}