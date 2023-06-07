using System;
namespace ProjectAccounting.Models
{
	public class PaymentDone
	{
		public int InvoiceId { get; set; }
		public int ClientId{ get; set; }
		public double PaymentMade { get; set; }

	}
}

