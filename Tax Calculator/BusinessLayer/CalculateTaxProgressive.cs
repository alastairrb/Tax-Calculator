using Tax_Calculator.Domain.Interfaces;
using Tax_Calculator.Models;

namespace Tax_Calculator.BusinessLayer
{
	public class CalculateTaxProgressive : ICalculateTax
	{
		public decimal CalculateTax(IncomeTax incomeTax)
		{
			if(incomeTax.Income > 0 && incomeTax.Income <= 8350)
			{				
				return incomeTax.Income * CalculationHelper.GetPercentage(10);
			}
			else if (incomeTax.Income > 8350 && incomeTax.Income <= 33950)
			{
				return incomeTax.Income * CalculationHelper.GetPercentage(15);
			}
			else if(incomeTax.Income > 33950 && incomeTax.Income <= 82250)
			{
				return incomeTax.Income * CalculationHelper.GetPercentage(25);
			}
			else if (incomeTax.Income > 82250 && incomeTax.Income <= 171550)
			{
				return incomeTax.Income * CalculationHelper.GetPercentage(28);
			}
			else if (incomeTax.Income > 171550 && incomeTax.Income <= 372950)
			{
				return incomeTax.Income * CalculationHelper.GetPercentage(33);
			}			
			else
			{
				return incomeTax.Income * CalculationHelper.GetPercentage(35);
			}			
		}		
	}
}
