using Microsoft.EntityFrameworkCore;
using SchoolBusDataAccess.Contexts;
using SchoolBusDataAccess.Repositories.Abstracts;
using SchoolBusModels.Abstracts;

namespace SchoolBusDataAccess.Repositories.Concretes;

public class Repository<T> : IRepository<T> where T : BaseEntity, new()
{
    private readonly SchoolBusDataContext _context;

    private readonly DbSet<T> _dbSet;

    public Repository()
    {
        _context = new SchoolBusDataContext();
        _dbSet = _context?.Set<T>();
    }

    public string Add(T entity)
    {
        //if (entity == null) throw new ArgumentNullException($"{nameof(T)} is Null");
        try
        {
            _dbSet.Add(entity);
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
        return "Succesfully added!";
    }

    public string AddRange(ICollection<T> entities)
    {
        //if (entities == null || entities.Count == 0) throw new ArgumentNullException("Collection is Null");
        try
        {
            _dbSet.AddRange(entities);
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
        return "Succesfully added!";
    }

    public ICollection<T>? GetAll()
    {
        return _dbSet.ToList<T>();
    }

    public T? GetById(int id)
    {
        return _dbSet.FirstOrDefault(p => p.Id == id);
    }

    public string Remove(T entity)
    {  
        try
        {
            _dbSet.Remove(entity);
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
        return "Succesfully deleted!";
    }

    public string Update(T entity)
    {
        try
        {
            _dbSet.Update(entity);
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
        return "Succesfully updated!";
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}
