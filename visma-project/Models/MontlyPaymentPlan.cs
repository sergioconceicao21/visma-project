using visma_project.Interfaces;

namespace visma_project.Models
{
    public class MontlyPaymentPlan : IPaymentPlan
    {
        public MontlyPaymentPlan()
        {
        }

        public List<LoanPaymentData> GetPaymentPlan(int durationYears, double interestRate, double principal)
        {
            int periods = 12 * durationYears;
            double ratePerPeriod = interestRate / 12;

            List<LoanPaymentData> payments = new List<LoanPaymentData>();
            double monthlyPayment = principal * ratePerPeriod * Math.Pow(1 + ratePerPeriod, periods) / (Math.Pow(1 + ratePerPeriod, periods) - 1);

            double previousLoan = principal;

            for (int i = 0; i < periods; ++i)
            {
                double interestPayed = previousLoan * ratePerPeriod;
                double principalPayed = monthlyPayment - interestPayed;
                double debtNextPeriod = previousLoan - principalPayed;
                previousLoan = debtNextPeriod;

                payments.Add(new LoanPaymentData(i + 1, monthlyPayment, interestPayed, principalPayed, debtNextPeriod));
            }

            return payments;
        }
    }
}
