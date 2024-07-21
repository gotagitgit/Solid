using MainApp.OCP.VisitorPattern.Loans;

namespace MainApp.OCP.VisitorPattern.LoanVisitors;

internal class StandardLoanRate : ILoanRateVisitor
{
    public void VisitCarLoan(CarLoan carLoan)
    {
        carLoan.InterestRate = 0.05;
    }

    public void VisitHomeLoan(HomeLoan homeLoan)
    {
        homeLoan.InterestRate = 0.07;
    }

    public void VisitPersonalLoan(PersonalLoan personalLoan)
    {
        personalLoan.InterestRate = 0.02;
    }
}
