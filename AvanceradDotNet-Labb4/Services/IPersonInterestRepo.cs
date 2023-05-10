namespace AvanceradDotNet_Labb4.Services
{
    public interface IPersonInterestRepo<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T newEntity);
        Task Delete(int id);
        Task Update(T entity);
    }
}
