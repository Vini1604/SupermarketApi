using SupermarketApi.Dtos;
using SupermarketApi.Entities;

namespace SupermarketApi
{
    public static class Extensions
    {
        public static ProductDto asDto (this Product product){
            if (product == null)
            {
                return null;
            }
            return new ProductDto {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Department = product.Department
            };
        }
    }
}