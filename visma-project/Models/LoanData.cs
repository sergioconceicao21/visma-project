using System.Text.Json.Serialization;

namespace visma_project.Models
{
    public class LoanData
    {
        [JsonPropertyName("LoanUser")]
        public LoanUserData LoanUser { get; set; }

        [JsonPropertyName("LoanSimulation")]
        public List<LoanPaymentData> LoanPaymentData { get; set; }

        public LoanData()

        {
            LoanUser = new LoanUserData();
            LoanPaymentData = new List<LoanPaymentData>();
        }
    }
}
