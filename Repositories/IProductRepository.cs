using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SupermarketApi.Entities;

namespace SupermarketApi.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetProductById(Guid idProduct);
        Task<List<Product>> GetProductByDepartment(string department);
        Task CreateProduct(Product product);
        Task UpdatedProduct(Product product);
        Task DeleteProduct(Product Product);

    }
}