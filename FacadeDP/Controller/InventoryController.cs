using Microsoft.AspNetCore.Mvc;

namespace FacadeDP.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        //   public IActionResult Index() => View();

        private readonly IinventoryService _inventoryService;
        public InventoryController(IinventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        [HttpGet]
        public IActionResult GetItems()
        {
            var items = _inventoryService.get();
            return Ok(items);
        }
    }
}
