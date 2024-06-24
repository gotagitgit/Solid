namespace MainApp.OCP.Accounts;

internal class TimeDepositAccount(int accountId, DateTime dateCreated, int period, decimal balance) :
    Account(accountId, balance), ITimeDepositAccount
{
    private readonly DateTime _dateCreated = dateCreated;

    private readonly TimeSpan _time = TimeSpan.FromDays(period);

    public AccountType AccountType => AccountType.TimeDeposit;

    public bool IsMatured() => DateTime.Now.Subtract(_dateCreated).TotalDays > _time.TotalDays;
}
