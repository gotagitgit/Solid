namespace MainApp.DIP;

internal class TimeDepositAccount(int accountId, Customer customer, DateTime dateCreated, int period, decimal balance) :
    Account(accountId, customer, balance), IAccount, ITimeDepositAccount
{
    private readonly DateTime _dateCreated = dateCreated;

    private readonly TimeSpan _time = TimeSpan.FromDays(period);

    public bool IsMatured() => DateTime.Now.Subtract(_dateCreated).TotalDays > _time.TotalDays;

    public override bool Withdraw(decimal amount)
    {
        if (amount <= 0 || amount > Balance || !IsMatured())
            return false;

        Balance -= amount;

        return true;
    }
}
