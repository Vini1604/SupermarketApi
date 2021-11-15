using System;
using System.Collections.Generic;
using SupermarketApi.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace SupermarketApi.Repositories
{
    public class ISqlServerRepository : IProductRepository
    {

        private readonly ApplicationDbContext _db;
        public ISqlServerRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task CreateProduct(Product product)
        {
            
            _db.Add(product);
            await _db.SaveChangesAsync();

        }

        public void DeleteProduct(Guid idProduct)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetProductByDepartment(string department)
        {
            var products = from product in _db.Product select product;
            return await products.Where(x => x.Department.ToUpper() == department.ToUpper()).ToListAsync();
        }

        public async Task<Product> GetProductById(Guid idProduct)
        {
            var product = await _db.Product.FirstOrDefaultAsync(x => x.Id == idProduct);
            return product;
        }

        public void UpdatedProduct(Guid idProduct)
        {
            throw new NotImplementedException();
        }
    }
}