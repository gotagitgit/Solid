using MainApp.OCP.VisitorPattern.LoanVisitors;

namespace MainApp.OCP.VisitorPattern.Loans;

internal abstract class Loan(decimal amount, int duration, string type)
{
    protected decimal _amount = amount;    
    protected int _duration = duration;

    public string Type { get; } = type;

    public double InterestRate { get; set; }

    public virtual decimal CalculateTotalPayment()
    {
        return _amount * (decimal)Math.Pow(1 + InterestRate, _duration);
    }

    public abstract void Accept(ILoanRateVisitor visitor);
}
