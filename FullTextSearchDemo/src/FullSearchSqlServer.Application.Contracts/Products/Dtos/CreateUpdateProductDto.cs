using System;

namespace FullSearchSqlServer.Products.Dtos
{
    [Serializable]
    public class CreateUpdateProductDto
    {
        public string Name { get; set; }

        public string Currency { get; set; }

        public decimal? OriginalPrice { get; set; }

        public decimal Price { get; set; }

        public int OrderMinQuantity { get; set; }

        public int OrderMaxQuantity { get; set; }

        public string UniqueName { get; set; }
    }
}