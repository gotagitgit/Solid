using MainApp.OCP.Accounts;

namespace MainApp.OCP.Validations;

internal interface IAccountValidation
{
    AccountType AccountType { get; }

    bool IsValid(IAccount account, decimal amount);
}