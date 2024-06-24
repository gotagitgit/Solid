namespace MainApp.OCP.Accounts;

internal class CurrentAccount(int accountId, decimal balance, decimal overDraft) : Account(accountId, balance), ICurrentAccount
{
    public AccountType AccountType => AccountType.Current;

    public decimal OverDraft => overDraft;
}
