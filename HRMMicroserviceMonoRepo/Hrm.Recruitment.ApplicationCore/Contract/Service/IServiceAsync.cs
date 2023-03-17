using System;
namespace Hrm.Recruitment.ApplicationCore.Contract.Service
{
	public interface IServiceAsync<TRequestModel, TResponseMode>
		where TRequestModel : class
		where TResponseMode: class
	{
		Task<int> InsertAsync(TRequestModel model);
		Task<int> DeleteAsync(int id);
		Task<int> UpdateAsync(TRequestModel model);
		Task<TResponseMode> GetByIdAsync(int id);
		Task<IEnumerable<TResponseMode>> GetAllAsync();
	}
}

