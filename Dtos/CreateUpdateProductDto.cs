using System.ComponentModel.DataAnnotations;

namespace SupermarketApi.Dtos
{
    public class CreateUpdateProductDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1, 5000, ErrorMessage = "Price should be a value between 1 and 5000")]
        public double Price { get; set; }
        public string Department { get; set; }
    }
}