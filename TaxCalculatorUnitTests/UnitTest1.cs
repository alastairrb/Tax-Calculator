using NUnit.Framework;

namespace TaxCalculatorUnitTests
{
	public class Tests
	{
		string test;
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void CalculateTax_Progressive_IncomeLessThan8350()
		{
			var calculateTaxService = new CalculateTaxService(null);

			var incomeTax = new IncomeTax
			{
				Income = 8350,
				PostalCode = "7441"
			};

			calculateTaxService.CalculateTax(incomeTax);

			Assert.IsTrue(incomeTax.CalculatedTaxAmount == 100);
		}
	}
}