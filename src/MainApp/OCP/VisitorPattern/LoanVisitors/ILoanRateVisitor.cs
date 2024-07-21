using MainApp.OCP.VisitorPattern.Loans;

namespace MainApp.OCP.VisitorPattern.LoanVisitors;
internal interface ILoanRateVisitor
{
    void VisitHomeLoan(HomeLoan homeLoan);
    void VisitPersonalLoan(PersonalLoan personalLoan);
    void VisitCarLoan(CarLoan carLoan);
}
