using AvanceradDotNet_Labb4.Models;

namespace AvanceradDotNet_Labb4.Services
{
    public interface IPersonRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<Interest>> GetInterests(int id);
        Task<IEnumerable<Link>> GetLinks(int id);
        Task<T> Add(T newObject);
        Task Delete(int id);
        Task<T> Update(T entity);

    }
}
