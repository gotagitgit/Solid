using MainApp.OCP.Accounts;

namespace MainApp.OCP.Validations;

internal class SavingsAccountValidation : IAccountValidation
{
    public AccountType AccountType => AccountType.Savings;

    public bool IsValid(IAccount account, decimal amount) => amount <= 0 || amount > account.Balance ? false : true;
}
