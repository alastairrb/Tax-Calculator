using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tax_Calculator.BusinessLayer;
using Tax_Calculator.Models;

namespace TaxCalculatorTests
{	
	[TestClass]
	public class CalculationTests
	{
		private CalculateTaxProgressive _calculateTaxProgressive;
		private CalculateTaxFlatValue _calculateTaxFlatValue;
		private CalculateTaxFlatRate _calculateTaxFlatRate;

		[TestInitialize]
		public void CalculationTestsInitialize()
		{
			_calculateTaxProgressive = new CalculateTaxProgressive();
			_calculateTaxFlatValue = new CalculateTaxFlatValue();
			_calculateTaxFlatRate = new CalculateTaxFlatRate();
		}

		// Progression Calculations
		[TestMethod]		
		public void CalculateTax_Progressive_IncomeLessThan8350_IsTrue()
		{						
			var incomeTax = new IncomeTax
			{
				Income = 8350,
				PostalCode = "7441"
			};

			var calculatedTaxAmount = _calculateTaxProgressive.CalculateTax(incomeTax);

			Assert.IsTrue(calculatedTaxAmount == 835);			
		}

		[TestMethod]
		public void CalculateTax_Progressive_IncomeLessThan33950_IsTrue()
		{			
			var incomeTax = new IncomeTax
			{
				Income = 33950,
				PostalCode = "7441"
			};

			var calculatedTaxAmount = _calculateTaxProgressive.CalculateTax(incomeTax);

			Assert.IsTrue(calculatedTaxAmount == Convert.ToDecimal(5092.50));
		}

		[TestMethod]
		public void CalculateTax_Progressive_IncomeLessThan82250_IsTrue()
		{		
			var incomeTax = new IncomeTax
			{
				Income = 82250,
				PostalCode = "7441"
			};

			var calculatedTaxAmount = _calculateTaxProgressive.CalculateTax(incomeTax);

			Assert.IsTrue(calculatedTaxAmount == Convert.ToDecimal(20562.50));
		}

		[TestMethod]
		public void CalculateTax_Progressive_IncomeLessThan171550_IsTrue()
		{		
			var incomeTax = new IncomeTax
			{
				Income = 171550,
				PostalCode = "7441"
			};

			var calculatedTaxAmount = _calculateTaxProgressive.CalculateTax(incomeTax);

			Assert.IsTrue(calculatedTaxAmount == Convert.ToDecimal(48034.00));
		}

		[TestMethod]
		public void CalculateTax_Progressive_IncomeLessThan372950_IsTrue()
		{		
			var incomeTax = new IncomeTax
			{
				Income = 372950,
				PostalCode = "7441"
			};

			var calculatedTaxAmount = _calculateTaxProgressive.CalculateTax(incomeTax);

			Assert.IsTrue(calculatedTaxAmount == Convert.ToDecimal(123073.50));
		}

		[TestMethod]
		public void CalculateTax_Progressive_IncomeGreaterThan372950_IsTrue()
		{		
			var incomeTax = new IncomeTax
			{
				Income = 372951,
				PostalCode = "7441"
			};

			var calculatedTaxAmount = _calculateTaxProgressive.CalculateTax(incomeTax);

			Assert.IsTrue(calculatedTaxAmount == Convert.ToDecimal(130532.85));
		}

		// Flat Value
		[TestMethod]
		public void CalculateTax_FlatValue_IncomeLessThan200000_IsTrue()
		{			
			var incomeTax = new IncomeTax
			{
				Income = 100000,
				PostalCode = "A100"
			};

			var calculatedTaxAmount = _calculateTaxFlatValue.CalculateTax(incomeTax);

			Assert.IsTrue(calculatedTaxAmount == Convert.ToDecimal(5000));
		}

		[TestMethod]
		public void CalculateTax_FlatValue_IncomeGreaterThan200000_IsTrue()
		{
			var incomeTax = new IncomeTax
			{
				Income = 250000,
				PostalCode = "A100"
			};

			var calculatedTaxAmount = _calculateTaxFlatValue.CalculateTax(incomeTax);

			Assert.IsTrue(calculatedTaxAmount == Convert.ToDecimal(1000));
		}

		// Flat Rate
		[TestMethod]
		public void CalculateTax_Rate_IncomeGreaterThan372950_IsTrue()
		{			
			var incomeTax = new IncomeTax
			{
				Income = 2000,
				PostalCode = "7000"
			};

			var calculatedTaxAmount = _calculateTaxFlatRate.CalculateTax(incomeTax);

			Assert.IsTrue(calculatedTaxAmount == Convert.ToDecimal(360));
		}
	}
}
