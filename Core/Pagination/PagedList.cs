namespace sn_project_be.Core.Pagination;

public interface IPagedList<T> where T : class
{
    public static abstract Task<PaginationResponse<TResult>> ToPagedResponse<TResult>(IQueryable<TResult> asQueryable, int pageNumber, int pageSize);
}

public abstract class PagedList<T> : IPagedList<T> where T : class
{
    public static Task<PaginationResponse<TResult>> ToPagedResponse<TResult>(IQueryable<TResult> asQueryable, int pageNumber, int pageSize)
    {
        var count = asQueryable.Count();
        var items = asQueryable.Skip((pageNumber - 1) * pageSize).Take(pageSize).AsEnumerable();
        return Task.FromResult(new PaginationResponse<TResult>()
        {
            Items = items,
            TotalCount = count,
            PageSize = pageSize,
            CurrentPage = pageNumber,
            TotalPages = (int)Math.Ceiling(count / (double)pageSize),
        });
    }
}
