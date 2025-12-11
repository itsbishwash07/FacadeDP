using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FacadeDP.Controller 
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService; 
        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost]
        public IActionResult Pay(double amount, string item)
        {
            _paymentService.pay(amount, item); 
            return Ok("Payment processed successfully.");
        }
        // GET: PaymentController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        // GET: PaymentController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: PaymentController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: PaymentController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: PaymentController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
    }

        // POST: PaymentController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: PaymentController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: PaymentController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    
}
