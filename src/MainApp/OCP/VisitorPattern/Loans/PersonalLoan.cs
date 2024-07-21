using MainApp.OCP.VisitorPattern.LoanVisitors;

namespace MainApp.OCP.VisitorPattern.Loans;

internal class PersonalLoan(decimal amount, int duration) : Loan(amount, duration, "Personal Loan")
{
    public override void Accept(ILoanRateVisitor visitor)
    {
        visitor.VisitPersonalLoan(this);
    }
}
