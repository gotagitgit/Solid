namespace MainApp.OCP.Accounts;

internal interface ICurrentAccount : IAccount
{
    decimal OverDraft { get; }
}