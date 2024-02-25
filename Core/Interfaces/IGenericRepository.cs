using sn_project_be.Core.Pagination;

namespace sn_project_be.Core.Interfaces;

public interface IGenericRepository<T> where T : class
{
    Task<T> GetAsync(Guid id);
    Task<TResult> GetAsync<TResult>(Guid id);
    Task<List<T>> GetAllAsync();
    Task<List<TResult>> GetAllAsync<TResult>(QueryStringParameters paginationParameters);
    Task<T> AddAsync(T entity);
    Task<TResult> AddAsync<TSource, TResult>(TSource source);
    Task DeleteAsync(Guid id);
    Task UpdateAsync(T entity);
    Task<TResult> UpdateAsync<TSource, TResult>(Guid id, TSource source) where TSource : IBaseDto;
    Task<bool> Exists(Guid id);
}