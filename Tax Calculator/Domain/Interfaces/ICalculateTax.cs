using Tax_Calculator.Models;

namespace Tax_Calculator.Domain.Interfaces
{
	public interface ICalculateTax
	{
		public decimal CalculateTax(IncomeTax incomeTax);
	}
}
