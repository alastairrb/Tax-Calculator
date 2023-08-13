using Tax_Calculator.Domain.Interfaces;
using Tax_Calculator.Models;

namespace Tax_Calculator.BusinessLayer
{
	public class CalculateTaxFlatValue : ICalculateTax
	{
		public decimal CalculateTax(IncomeTax incomeTax)
		{
			if (incomeTax.Income < 200000)
			{
				return incomeTax.Income * CalculationHelper.GetPercentage(5);
			}
			else
			{
				return 1000;
			}
		}
	}
}
