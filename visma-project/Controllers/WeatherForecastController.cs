using Microsoft.AspNetCore.Mvc;
using visma_project.Models;

namespace visma_project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private const double INTEREST_RATE = 0.035; // ideally the 0.035 (interest rate) should be retrieved from an interest rate calculation service

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public double Get()
        {
            return INTEREST_RATE;
        }

        [HttpPost]
        public LoanData Post([FromBody] LoanData data)
        {
            HousingLoan loan = new HousingLoan(INTEREST_RATE, data.LoanUser.Years, data.LoanUser.BorrowedPrincipal);
            data.LoanPaymentData = loan.CalculatePaymentPlan();
            return data;
        }
    }
}