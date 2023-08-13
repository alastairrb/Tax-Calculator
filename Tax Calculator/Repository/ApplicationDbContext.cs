using Microsoft.EntityFrameworkCore;
using Tax_Calculator.Models;

namespace Tax_Calculator.Repository
{
	public class ApplicationDbContext : DbContext
	{		
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			 : base(options)
		{
		}

		public virtual DbSet<IncomeTax> IncomeTax { get; set; }
	}
}

