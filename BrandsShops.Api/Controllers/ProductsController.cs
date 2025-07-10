using Microsoft.AspNetCore.Mvc;

namespace BrandsShops.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private static readonly List<Product> products = new()
{
       new Product { Id = 1, BrandId = 1, Name = "Nike Shoes", BrandName = "Nike", Price = 120, Description = "Comfortable running shoes", ImageUrl = "images/products/1.png" },
       new Product { Id = 2, BrandId = 1, Name = "Nike T-Shirt", BrandName = "Nike", Price = 40, Description = "Cool cotton T-shirt", ImageUrl = "images/products/2.png" },
       new Product { Id = 3, BrandId = 2, Name = "Adidas Jacket", BrandName = "Adidas", Price = 100, Description = "Stylish sports jacket", ImageUrl = "images/products/3.png" },
       new Product { Id = 4, BrandId = 3, Name = "iPhone", BrandName = "Apple", Price = 1000, Description = "Latest Apple phone", ImageUrl = "images/products/4.png" },
       new Product { Id = 5, BrandId = 4, Name = "Galaxy S21", BrandName = "Samsung", Price = 850, Description = "Samsung smartphone", ImageUrl = "images/products/5.png" },
       new Product { Id = 6, BrandId = 5, Name = "Sony Headphones", BrandName = "Sony", Price = 200, Description = "Noise-cancelling headphones", ImageUrl = "images/products/6.png" },
       new Product { Id = 7, BrandId = 6, Name = "Microsoft Surface", BrandName = "Microsoft", Price = 1200, Description = "2-in-1 laptop", ImageUrl = "images/products/7.png" }
};


        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpGet("brand/{brandId}")]
        public IActionResult GetProductsByBrand(int brandId)
        {
            var result = products.Where(p => p.BrandId == brandId).ToList();
            return Ok(result);
        }



        public class Product
        {
            public int Id { get; set; }
            public int BrandId { get; set; }
            public string? Name { get; set; }
            public string? BrandName { get; set; }
            public decimal Price { get; set; }
            public string? Description { get; set; }
            public string? ImageUrl { get; set; }
        }
    }
}
