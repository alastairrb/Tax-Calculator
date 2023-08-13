using Tax_Calculator.Models;

namespace Tax_Calculator.Domain.Interfaces
{
	public interface ICalculateService
	{		
		IncomeTax CalculateTax(IncomeTax IncomeTax);

		ICalculateTax GetCalculationType(string postalCode);
	}
}
