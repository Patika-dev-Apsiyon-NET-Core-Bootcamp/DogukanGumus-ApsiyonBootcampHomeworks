using System;

namespace ServiceToConsume.Core.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Decimal Price { get; set; }
        public string UserId { get; set; }
    }
}