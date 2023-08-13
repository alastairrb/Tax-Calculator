namespace Tax_Calculator.BusinessLayer
{
	public class CalculationHelper
	{
		public static decimal GetPercentage(int percentage)
		{			
			return Convert.ToDecimal(percentage) / Convert.ToDecimal(100);
		}
	}
}
