using MainApp.OCP.VisitorPattern.LoanVisitors;

namespace MainApp.OCP.VisitorPattern.Loans;

internal class CarLoan(decimal amount, int duration) : Loan(amount, duration, "Car Loan") 
{
    public override void Accept(ILoanRateVisitor visitor)
    {
        visitor.VisitCarLoan(this);
    }
}
