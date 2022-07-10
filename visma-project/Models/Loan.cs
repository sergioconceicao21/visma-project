using visma_project.Interfaces;

namespace visma_project.Models
{
    public class Loan
    {
        private readonly double InterestRate;
        private readonly int DurationYears;
        private readonly double Principal;
        private readonly IPaymentPlan PaymentPlan;

        public Loan(double interestRate, int durationYears, double principal, IPaymentPlan paymentPlan)
        {
            this.InterestRate = interestRate;
            this.DurationYears = durationYears;
            this.Principal = principal;
            this.PaymentPlan = paymentPlan;
        }

        public List<LoanPaymentData> CalculatePaymentPlan()
        {
            return this.PaymentPlan.GetPaymentPlan(DurationYears, InterestRate, Principal);
        }
    }
}
