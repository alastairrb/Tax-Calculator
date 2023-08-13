namespace Tax_Calculator.Models
{
	public class IncomeTax
	{
		public int Id { get; set; }

		public decimal Income { get; set; }

		public string PostalCode { get; set; }

		public decimal CalculatedTaxAmount { get; set; }

		public DateTime? DateCreated { get; set; }
	}
}
