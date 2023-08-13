namespace Tax_Calculator.Repository
{
	public interface IGenericRepository<T> where T : class 
	{
		Task<IEnumerable<T>> GetAll();

		Task<T> GetById(Guid id);

		Task<bool> Insert(T entity);

		Task<bool> Delete(Guid id);

		Task<bool> Upsert(T entity);

		void Save();
	}
}
