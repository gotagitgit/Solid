namespace MainApp.ISP;

internal class CurrentAccount(int accountId, Customer customer, decimal balance, decimal overDraft) : Account(accountId, customer, balance), IAccount
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
