namespace MainApp.LSP;

internal class CurrentAccount(int accountId, Customer customer, decimal balance, decimal overDraft) : Account(accountId, customer, balance)
{
    private readonly decimal _overDraft = overDraft;

    public override bool Withdraw(decimal amount)
    {
        var allowedAmountToWithdraw = Balance + _overDraft;

        if (amount <= 0 || amount > allowedAmountToWithdraw)
        {
            return false;
        }           

        Balance -= amount;

        return true;
    }
}
