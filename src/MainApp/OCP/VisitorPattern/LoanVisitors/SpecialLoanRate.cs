using MainApp.OCP.VisitorPattern.Loans;

namespace MainApp.OCP.VisitorPattern.LoanVisitors;

internal class SpecialLoanRate : ILoanRateVisitor
{
    public void VisitCarLoan(CarLoan carLoan)
    {
        carLoan.InterestRate = 0.04;
    }

    public void VisitHomeLoan(HomeLoan homeLoan)
    {
        homeLoan.InterestRate = 0.06;
    }

    public void VisitPersonalLoan(PersonalLoan personalLoan)
    {
        personalLoan.InterestRate = 0.01;
    }
}
