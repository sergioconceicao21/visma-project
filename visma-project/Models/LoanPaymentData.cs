using System.Text.Json.Serialization;

namespace visma_project.Models
{
    public class LoanPaymentData
    {
        [JsonPropertyName("Period")]
        public int Period { get; set; }

        [JsonPropertyName("TotalPayment")]
        public double TotalPayment { get; set; }

        [JsonPropertyName("Interest")]
        public double Interest { get; set; }

        [JsonPropertyName("Capital")]
        public double Capital { get; set; }

        [JsonPropertyName("Residual")]
        public double Residual { get; set; }

        public LoanPaymentData(int period, double totalPayment, double interest, double capital, double residual)
        {
            Period = period;
            TotalPayment = totalPayment;
            Interest = interest;
            Capital = capital;
            Residual = residual;
        }
    }
}
