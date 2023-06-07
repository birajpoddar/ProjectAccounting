using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAccounting.Interfaces;
using ProjectAccounting.Models;

namespace ProjectAccounting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentProcessorController : ControllerBase
    {
        IPaymentProcessor paymentProcessor;
        IEnumerable<PaymentDone> payments;

        public PaymentProcessorController(IPaymentProcessor processor)
        {
            paymentProcessor = processor;
        }

        [HttpGet]
        public async Task<ActionResult<string>> ProcessPayment()
        {
            // Retrieve all the payments from the file
            payments = await paymentProcessor.RetrievePayments();
            if (payments == null)
                return NotFound("No Payments has been made");

            // Get List of Paid Clients from Payment File
            var clients = payments.DistinctBy(p => p.ClientId).Select(p => p.ClientId).ToList();
            if (clients.Count == 0)
                return NotFound("No Clients found in the Payment File");

            // See if all the paid clientIds are available in the repo
            // Return notFound if all clients not found

            // Start the process of recording payment one by one for all clients in the list
            // If the total payment made by client is greater than TotalPaymentDue
            //      Return NotFound("Extra amount paid by the client")

            // If the total payment made by the client matches the TotalPaymentDue
            //      Do payment for all the Projects

            // If the total payment made by the client is less than the TotalPaymentDue
            //      Do payment for the fist project which matches the Invoice

            return Ok("All payments made");
        }
    }
}
