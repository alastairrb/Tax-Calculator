using Tax_Calculator.Domain.Interfaces;

namespace Tax_Calculator.Factories
{
	public interface ITaxCalculationTypeFactory
	{
		ICalculateTax GetInstance(string Token);
	}
}
