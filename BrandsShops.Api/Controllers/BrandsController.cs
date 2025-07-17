using Microsoft.AspNetCore.Mvc;
using BrandsShops.Api.Data;
using BrandsShops.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace BrandsShops.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BrandsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BrandsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Brand>>> GetBrands()
        {
            var brands = await _context.Brands.ToListAsync();
            return Ok(brands);
        }
    }
}
