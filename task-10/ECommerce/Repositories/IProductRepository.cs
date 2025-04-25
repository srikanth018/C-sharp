using ECommerce.DTOs;
using ECommerce.Models.Entities;

namespace ECommerce.Repositories
{
    public interface IProductRepository<T> where T:class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task <T> AddAsync(T product);

        Task<T> GetByIdAsync(int Id);
        Task<T> UpdateAsync(int Id, T product);
        Task<T> DeleteAsync(int Id);
    }
}
