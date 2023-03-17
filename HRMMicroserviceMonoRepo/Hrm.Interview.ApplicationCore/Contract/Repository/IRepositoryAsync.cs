using System;
namespace Hrm.Interview.ApplicationCore.Contract.Repository
{
	public interface IRepositoryAsync<T> where T : class
	{
		Task<int> InsertAsync(T entity);
		Task<int> DeleteAsync(int id);
		Task<int> UpdateAsync(T entity);
		Task<IEnumerable<T>> GetAllAsync();
		Task<T> GetByIdAsync(int id);
	}
}

