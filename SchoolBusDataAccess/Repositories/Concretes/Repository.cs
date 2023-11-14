using Microsoft.EntityFrameworkCore;
using SchoolBusDataAccess.Contexts;
using SchoolBusDataAccess.Repositories.Abstracts;
using SchoolBusModels.Abstracts;
using SchoolBusModels.Concretes;

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
        try
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
        return "Succesfully added!";

        //try
        //{
        //    var existingEntity = _dbSet.Local.FirstOrDefault(e => e.Id == entity.Id);

        //    if (existingEntity != null)
        //    {
        //        _context.Entry(existingEntity).CurrentValues.SetValues(entity);
        //    }
        //    else
        //    {
        //        // Check if the entity is already tracked by key
        //        var entry = _context.ChangeTracker.Entries<T>().FirstOrDefault(e => e.Entity.Id == entity.Id);

        //        if (entry != null)
        //        {
        //            entry.CurrentValues.SetValues(entity);
        //        }
        //        else
        //        {


        //            if (entity is Student student)
        //            {
        //                // Assuming there's a navigation property named 'Parents' on the Student entity
        //               // _context.Entry(student).Collection(s => s.Parents).Load();

        //                // Attach existing parents without adding them to the Parents DbSet
        //                foreach (var parent in _context.Parents)
        //                {
        //                    _context.Entry(parent).State = EntityState.Unchanged;
        //                }
        //            }
        //            _dbSet.Add(entity);
        //        }
        //    }

        //    _context.SaveChanges();
        //}
        //catch (Exception ex)
        //{
        //    return ex.Message;
        //}
        //return "Successfully added!";




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



