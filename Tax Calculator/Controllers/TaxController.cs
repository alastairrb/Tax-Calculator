using Microsoft.AspNetCore.Mvc;
using Tax_Calculator.Domain.Interfaces;
using Tax_Calculator.Models;
using Tax_Calculator.Services;

namespace Tax_Calculator.Controllers
{
	public class TaxController : Controller
	{
		private readonly ICalculateService _determineTaxType;
		private readonly ITaxCalculatorAdapterService _taxCalculatorService;

		public TaxController(ICalculateService determineTaxType, ITaxCalculatorAdapterService taxCalculatorService)
		{
			_determineTaxType = determineTaxType;
			_taxCalculatorService = taxCalculatorService;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CalculateTax(IncomeTax tax)
		{
			try
			{				
				_determineTaxType.CalculateTax(tax);

				tax.DateCreated = DateTime.Now;				
				_taxCalculatorService.saveTaxCalculation(tax);

				return Ok();				
			}
			catch
			{
				return BadRequest();
			}			
		}
	}
}
