namespace Tax_Calculator.Repository
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		private ApplicationDbContext _context;		

		public GenericRepository(ApplicationDbContext context)
		{
			_context = context;			
		}

		public async Task<bool> Insert(T entity)
		{
			// Add try/catch and logging
			try
			{
				_context.Set<T>().Add(entity);				

				Save();
			}
			catch (Exception ex)
			{
				var test = ex.Message;
			}

			return true;			
		}

		public Task<IEnumerable<T>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<bool> Delete(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<T> GetById(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<bool> Upsert(T entity)
		{
			throw new NotImplementedException();
		}

		public void Save()
		{
			_context.SaveChanges();
		}
	}
}
