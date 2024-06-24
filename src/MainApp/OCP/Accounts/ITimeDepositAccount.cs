namespace MainApp.OCP.Accounts;

internal interface ITimeDepositAccount : IAccount
{
    bool IsMatured();
}