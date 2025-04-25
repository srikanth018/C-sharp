using ECommerce.Data;
using ECommerce.DTOs;
using ECommerce.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Repositories
{
    public class ProductRepository : IProductRepository<Product>
    {
        private readonly ApplicationDbContext dbContext;

        public ProductRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await dbContext.Products.ToListAsync();
        }

        public async Task<Product> AddAsync(Product P_Product)
        {
            await dbContext.Products.AddAsync(P_Product);
            dbContext.SaveChanges();
            return P_Product;
        }

        public async Task<Product> GetByIdAsync(int Id)
        {
            var ProductById = await dbContext.Products.FindAsync(Id);
            return ProductById;
        }

        public async Task<Product> UpdateAsync(int Id, Product product)
        {
            dbContext.Products.Update(product);
            await dbContext.SaveChangesAsync();
            return product;
        }

        public async Task<Product> DeleteAsync(int Id)
        {
            var isProductExists = await dbContext.Products.FindAsync(Id);
            if(isProductExists is null)
            {
                throw new Exception("Product Not Found For Deletion");
            }
            dbContext.Products.Remove(isProductExists);
            await dbContext.SaveChangesAsync();
            return isProductExists;
        }
    }
}
