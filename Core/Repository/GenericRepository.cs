using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using sn_project_be.Core.Exceptions;
using sn_project_be.Core.Interfaces;
using sn_project_be.Data;

namespace sn_project_be.Core.Repository;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly SsDbContext _context;
    private readonly IMapper _mapper;

    public GenericRepository(SsDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<T> GetAsync(Guid id)
    {
        var result = await _context.Set<T>().FindAsync(id);
        if (result is null)
        {
            throw new NotFoundException(typeof(T).Name, id);
        }

        return result;
    }

    public async Task<TResult> GetAsync<TResult>(Guid id)
    {
        var result = await _context.Set<T>().FindAsync(id);
        if (result is null)
        {
            throw new NotFoundException(typeof(T).Name, id);
        }
        
        return _mapper.Map<TResult>(result);
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<List<TResult>> GetAllAsync<TResult>()
    {
        return await _context.Set<T>()
            .ProjectTo<TResult>(_mapper.ConfigurationProvider)
            .ToListAsync();
    }

    public async Task<T> AddAsync(T entity)
    {
        await _context.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<TResult> AddAsync<TSource, TResult>(TSource source)
    {
        var entity = _mapper.Map<T>(source);
            
        await _context.AddAsync(entity);
        await _context.SaveChangesAsync();

        return _mapper.Map<TResult>(entity); 
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetAsync(id);

        if (entity is null)
        {
            throw new NotFoundException(typeof(T).Name, id);
        }

        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        _context.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<TResult> UpdateAsync<TSource, TResult>(Guid id, TSource source) where TSource : IBaseDto
    {
        if (id != source.Id)
        {
            throw new BadRequestException("Invalid Id used in request");
        }

        var entity = await GetAsync(id);

        if(entity == null)
        {
            throw new NotFoundException(typeof(T).Name, id);
        }

        _mapper.Map(source, entity);
        var a = _context.Update(entity);
        await _context.SaveChangesAsync();
        return _mapper.Map<TResult>(entity);
    }

    public async Task<bool> Exists(Guid id)
    {
        var entity = await GetAsync(id);
        return entity != null;
    }
}