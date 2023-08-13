using Tax_Calculator.Domain.Interfaces;
using Tax_Calculator.Models;

namespace Tax_Calculator.BusinessLayer
{
	public class CalculateTaxFlatRate : ICalculateTax
	{
		public decimal CalculateTax(IncomeTax incomeTax)
		{			
			return incomeTax.Income * CalculationHelper.GetPercentage(Convert.ToInt32(17.5));
		}
	}
}
