using Microsoft.AspNetCore.Mvc;

namespace BrandsShops.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BrandsController : ControllerBase
    {
        private static readonly List<Brand> brands = new()
        {
            new Brand { Id = 1, Name = "Nike", Description = "Leading sportswear brand" },
            new Brand { Id = 2, Name = "Adidas", Description = "Innovative sportswear and shoes" },
            new Brand { Id = 3, Name = "Apple", Description = "Innovative technology products" },
            new Brand { Id = 4, Name = "Samsung", Description = "Leading electronics and tech" },
            new Brand { Id = 5, Name = "Sony", Description = "Entertainment and electronics" },
            new Brand { Id = 6, Name = "Microsoft", Description = "Software and hardware solutions" }
        };

        [HttpGet]
        public ActionResult<List<Brand>> GetBrands()
        {
            return Ok(brands);
        }

        public class Brand
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string Description { get; set; } = string.Empty;
        }
    }
}
