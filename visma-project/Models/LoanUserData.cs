using System.Text.Json.Serialization;

namespace visma_project.Models
{
    public class LoanUserData
    {
        [JsonPropertyName("Years")]
        public int Years { get; set; }

        [JsonPropertyName("BorrowedPrincipal")]
        public double BorrowedPrincipal { get; set; }
    }
}
