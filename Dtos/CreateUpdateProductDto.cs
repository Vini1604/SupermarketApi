using System.ComponentModel.DataAnnotations;
using System;
namespace SupermarketApi.Dtos
{
    public class CreateUpdateProductDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1, Double.MaxValue, ErrorMessage = "Price should be a value between 1 and 5000")]
        public double Price { get; set; }
        public string Department { get; set; }
    }
}