using Microsoft.AspNetCore.Mvc;

namespace FacadeDP.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseFacadeController : ControllerBase
    {
        private readonly IinventoryService _inventoryService;
        private readonly INotificationService _notificationService; 
        private readonly IPaymentService _paymentService;
        public PurchaseFacadeController(IinventoryService inventoryservice , INotificationService notificationService, IPaymentService paymentService)
        {
            _inventoryService = inventoryservice;
            _notificationService = notificationService;
            _paymentService = paymentService;
        }

        [HttpPost]
        public IActionResult PurchaseItem(string item, double amount)
        {
            var items = _inventoryService.get();
            if (items.Contains(item))
            {
                _paymentService.pay(amount, item);
                _notificationService.send($"Purchase of {item} for {amount} completed successfully.");
                return Ok("Purchase completed successfully.");
            }
            else
            {
                return BadRequest("Item not available in inventory.");
            }
        }
    }
}
