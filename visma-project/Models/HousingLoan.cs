using visma_project.Interfaces;

namespace visma_project.Models
{
    public class HousingLoan : Loan
    {
        public HousingLoan(double interestRate, int durationYears, double principal) : base(interestRate, durationYears, principal, new MontlyPaymentPlan())
        {
        }
    }
}
