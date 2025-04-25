using ECommerce.Data;
using ECommerce.DTOs;
using ECommerce.Models.Entities;
using ECommerce.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository<Product> repo;

        public ProductController(IProductRepository<Product> repo)
        {
            this.repo = repo;
        }

        
        [HttpGet]
        public async Task<IActionResult> GetAllProduct()
        {
           
            var products = await repo.GetAllAsync();
            return Ok(products);

        }
        [HttpPost]
        public async Task<IActionResult> AddProductAsync(AddProductDto product)
        {
         
            var newProduct = new Product
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Stock = product.Stock
            };

            await repo.AddAsync(newProduct);
            return Ok(newProduct);
                        
        }

        [HttpGet]
        [Route("{Id:int}")]
        public async Task<IActionResult> GetProductById(int Id)
        {
            var ProductById = await repo.GetByIdAsync(Id);
            if(ProductById is null)
            {
                return NotFound();
            }
            return Ok(ProductById);
        }

        [HttpPut]
        [Route("{Id:int}")]
        public async Task<IActionResult> UpdateProduct(int Id,[FromBody] UpdateProductDTO updateProduct)
        {
            var exsistingProduct = await repo.GetByIdAsync(Id);

            if (exsistingProduct is null)
            {
                return NotFound();
            }
            if (!string.IsNullOrEmpty(updateProduct.Name))
            {
                exsistingProduct.Name = updateProduct.Name;
            }
            if (!string.IsNullOrEmpty(updateProduct.Description))
            {
                exsistingProduct.Description = updateProduct.Description;
            }
            if (updateProduct.Price != null)
            {
                exsistingProduct.Price = (decimal)updateProduct.Price;
            }
            if (updateProduct.Stock != null)
            {
                exsistingProduct.Stock = (int)updateProduct.Stock;
            }

            var updatedProductDb = await repo.UpdateAsync(Id, exsistingProduct);
            return Ok(updatedProductDb);
        }

        [HttpDelete]
        [Route("{Id:int}")]

        public async Task<IActionResult> DeleteProductAsync(int Id)
        {
            var deletedProduct = await repo.DeleteAsync(Id);
            return Ok(deletedProduct);
        }
    }
}
