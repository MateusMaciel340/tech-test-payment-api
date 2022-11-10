using tech_test_payment_api.Contexts;

using Microsoft.AspNetCore.Mvc;

namespace tech_test_payment_api.Controllers
{
    [ApiController]
    [Route("api-payment/[controller]")]
    public class SaleController : ControllerBase
    {
        private readonly ContextOrganizer _context;

        public SaleController(ContextOrganizer context)
        {
            _context = context;
        }
    }
}