using Tax_Calculator.BusinessLayer;
using Tax_Calculator.Domain.Interfaces;

namespace Tax_Calculator.Factories
{
	public class TaxCalculationTypeFactory : ITaxCalculationTypeFactory
	{
		private readonly IEnumerable<ICalculateTax> _calculateTax;

		public TaxCalculationTypeFactory(IEnumerable<ICalculateTax> calculateTax)
		{
			_calculateTax = calculateTax;
		}	

		public ICalculateTax GetInstance(string token)
		{
			return token switch
			{
				"Progressive" => this.GetService(typeof(CalculateTaxProgressive)),
				"FlatValue" => this.GetService(typeof(CalculateTaxFlatValue)),
				"FlatRate" => this.GetService(typeof(CalculateTaxFlatRate)),
				_ => throw new InvalidOperationException()
			}; ;
		}

		public ICalculateTax GetService(Type type)
		{
			return this._calculateTax.FirstOrDefault(x => x.GetType() == type)!;
		}
	}
}
