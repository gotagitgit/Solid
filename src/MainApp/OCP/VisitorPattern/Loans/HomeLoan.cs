using MainApp.OCP.VisitorPattern.LoanVisitors;

namespace MainApp.OCP.VisitorPattern.Loans;

internal class HomeLoan(decimal amount, int duration) : Loan(amount, duration, "Home Loan")
{
    public override void Accept(ILoanRateVisitor visitor)
    {
        visitor.VisitHomeLoan(this);
    }
}
