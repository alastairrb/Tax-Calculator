using Tax_Calculator.Domain.Interfaces;
using Tax_Calculator.Factories;
using Tax_Calculator.Models;

namespace Tax_Calculator.BusinessLayer
{
	public class CalculateTaxService : ICalculateService
	{		
		private readonly ITaxCalculationTypeFactory _calculateTaxFactory;				

		public CalculateTaxService(ITaxCalculationTypeFactory calculateTaxFactory)
		{
			_calculateTaxFactory = calculateTaxFactory;			
		}				

		public IncomeTax CalculateTax(IncomeTax IncomeTax)
		{			
			IncomeTax.CalculatedTaxAmount = GetCalculationType(IncomeTax.PostalCode).CalculateTax(IncomeTax);

			return IncomeTax;
		}

		public ICalculateTax GetCalculationType(string postalCode)
		{
			switch (postalCode)
			{
				case "7441":
				case "1000":
					return _calculateTaxFactory.GetInstance("Progressive");
				case "A100":
					return _calculateTaxFactory.GetInstance("FlatValue");
				case "7100":
					return _calculateTaxFactory.GetInstance("FlatRate");
				default:
					throw new InvalidOperationException();
			}						
		}
	}
}
