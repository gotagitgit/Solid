using MainApp.OCP.VisitorPattern.LoanVisitors;

namespace MainApp.OCP;

internal interface IBankService
{
    void ComputeTotalLoans(Customer customer, ILoanRateVisitor loanVisitor);
    void Withdraw(Customer customer, int accountId, decimal amount);
}