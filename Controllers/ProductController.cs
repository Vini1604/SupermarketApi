using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SupermarketApi.Dtos;
using SupermarketApi.Entities;
using SupermarketApi.Repositories;

namespace SupermarketApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }
    
        [HttpGet("{idProduct:guid}")]
        public async Task<ActionResult<ProductDto>> GetProductById([FromRoute] Guid idProduct){
            var product = await _repository.GetProductById(idProduct);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product.asDto());
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetProductByDepartment(string department){
            var products = await _repository.GetProductByDepartment(department);
            if (products == null)
            {
                return NoContent();
            }

            foreach(Product product in products){
                product.asDto();
            }
            return Ok(products);
        }

        [HttpPost]
        public async Task<ActionResult<ProductDto>> CreateProduct(CreateUpdateProductDto newProduct){
            var productDtoToData = new Product{
                Id = Guid.NewGuid(),
                Name = newProduct.Name,
                Price = newProduct.Price,
                Department = newProduct.Department
            };
            await _repository.CreateProduct(productDtoToData);
            return productDtoToData.asDto();
        }

        [HttpPut("{idProduct}")]
        public ActionResult UpdateProduct(Guid idProduct, CreateUpdateProductDto UpdatedProduct){
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(Guid idProduct){
            return Ok();
        }
    }
}