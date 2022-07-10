using visma_project.Models;

namespace visma_project.Interfaces
{
    public interface IPaymentPlan
    {
        List<LoanPaymentData> GetPaymentPlan(int durationYears, double interestRate, double principal);
    }
}
