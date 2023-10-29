namespace SchoolBusDataAccess.Repositories.Abstracts;

public interface IRepository<T>
{
    T? GetById(int id);
    string Add(T entity);
    string AddRange(ICollection<T> entities);
    ICollection<T>? GetAll();
    string Remove(T entity);
    string Update(T entity);
    void SaveChanges();
}
