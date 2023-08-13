using Tax_Calculator.Models;

namespace Tax_Calculator.Services
{
	public interface ITaxCalculatorAdapterService
	{
		Task<bool> saveTaxCalculation(IncomeTax IncomeTax);
	}
}
