using tech_test_payment_api.Contexts;
using tech_test_payment_api.Models;
using tech_test_payment_api.Enums;

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

        // Adding Order Sale
        [HttpPost("AddingOrderSale")]
        public IActionResult AddingSale(OrderSale orderSale)
        {
            int countItems = 0;

            foreach (var item in orderSale.Products)
            {
                countItems += 1;
            }

            if (countItems < 1)
            {
                return BadRequest("Solicitação do pedido realizada com sucesso!");
            }

            orderSale.Status = StatusTransitions.Awaiting_Payment;
            orderSale.CurrentDate = DateTime.Now;

            _context.Sellers.Add(orderSale.Seller);

            decimal Amount = 0;

            foreach (var item in orderSale.Products)
            {
                if (item.Price <= 0 || item.Inventory <= 0)
                {
                    return BadRequest("Preço e estoque não podem ser iguais a zero ou menores que zero!");
                }

                Amount += item.Price * item.Inventory;
                _context.Products.Add(item);
            }

            orderSale.Amount = Amount;
            _context.OrderSales.Add(orderSale);
            _context.SaveChanges();

            return Ok(orderSale);
        }
    }
}