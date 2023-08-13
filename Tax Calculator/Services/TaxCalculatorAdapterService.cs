using Tax_Calculator.Models;
using Tax_Calculator.Repository;

namespace Tax_Calculator.Services
{
	public class TaxCalculatorAdapterService : ITaxCalculatorAdapterService
	{
		private readonly IGenericRepository<IncomeTax> _repository;
		public TaxCalculatorAdapterService(IGenericRepository<IncomeTax> repository)
		{
			_repository = repository;
		}

		public async Task<bool> saveTaxCalculation(IncomeTax IncomeTax)
		{
			return await _repository.Insert(IncomeTax);
		}
	}
}
