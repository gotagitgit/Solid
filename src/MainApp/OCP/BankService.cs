﻿using MainApp.OCP.Accounts;
using MainApp.OCP.Validations;
using MainApp.OCP.VisitorPattern.LoanVisitors;

namespace MainApp.OCP;

internal class BankService : IBankService
{
    private readonly ILoggingService _loggingService;
    private readonly IDictionary<AccountType, IAccountValidation> _accountValidations;

    public BankService(ILoggingService loggingService, IEnumerable<IAccountValidation> accountValidations)
    {
        _loggingService = loggingService;
        _accountValidations = accountValidations.ToDictionary(x => x.AccountType, y => y);
    }

    public void ComputeTotalLoans(Customer customer, ILoanRateVisitor loanVisitor)
    {
        var loans = customer.Loans;

        var totalLoanPayment = 0m;

        _loggingService.LogMessage($"{customer.Name} Loans:");

        foreach (var loan in loans)
        {
            loan.Accept(loanVisitor);

            var loanPayment = loan.CalculateTotalPayment();

            totalLoanPayment += loanPayment;

            _loggingService.LogMessage($"Payment for {loan.Type} is {totalLoanPayment}");
        }

        _loggingService.LogMessage($"Total payment for all Loans is {totalLoanPayment}");
    }

    public void Withdraw(Customer customer, int accountId, decimal amount)
    {
        var account = customer.GetAccount(accountId);

        if (!_accountValidations.TryGetValue(account.AccountType, out var accountValidation))
            throw new ArgumentException("Account type {account} is not Valid");

        if (accountValidation.IsValid(account, amount))
        {
            account.Withdraw(amount);
            _loggingService.LogMessage($"Withdrawal of {amount} successful. New balance: {account.Balance}");
        }
        else
        {
            if (account is ITimeDepositAccount timeDeposit)
                LogTimeDepositError(timeDeposit);
            else
                _loggingService.LogMessage("Withdrawal failed. Check the amount and balance.");
        }
    }

    private void LogTimeDepositError(ITimeDepositAccount timeDeposit)
    {
        if (!timeDeposit.IsMatured())
            _loggingService.LogMessage("Time Deposit account did not reach maturity date");
    }
}
