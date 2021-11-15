using System;

namespace SupermarketApi.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Department { get; set; }
    }
}