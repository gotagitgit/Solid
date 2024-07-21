using MainApp.OCP.Accounts;
using MainApp.OCP.VisitorPattern.Loans;

namespace MainApp.OCP;

internal class Customer(int customerId, string name, IReadOnlyList<IAccount> accounts, IReadOnlyList<Loan> loans)
{
    public int CustomerId { get; } = customerId;

    public string Name { get; } = name;

    public IReadOnlyList<IAccount> Accounts { get; } = accounts;

    public IAccount GetAccount(int accountId) => Accounts.First(a => a.AccountId == accountId);

    public IReadOnlyList<Loan> Loans { get; } = loans;
}
