using MainApp.OCP.Accounts;

namespace MainApp.OCP.Validations;

internal class TimeDepositAccountValidation : IAccountValidation
{
    public AccountType AccountType => AccountType.TimeDeposit;

    public bool IsValid(IAccount account, decimal amount)
    {
        if (account is ITimeDepositAccount timeDepositAccount)
        {
            if (amount <= 0 || amount > timeDepositAccount.Balance || !timeDepositAccount.IsMatured())
                return false;

            return true;
        }

        throw new ArgumentException($"Account type {account} is not Time Deposit Account");
    }
}
