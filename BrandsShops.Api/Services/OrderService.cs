using BrandsShops.Api.Data;
using BrandsShops.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace BrandsShops.Api.Services
{
    public class OrderService
    {
        private readonly ApplicationDbContext _context;

        public OrderService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Order>> GetOrders(DateTime? startDate, DateTime? endDate, string? search = null)
        {
            var query = _context.Orders.AsQueryable();

            if (startDate.HasValue)
                query = query.Where(o => o.OrderDate >= startDate.Value.Date);

            if (endDate.HasValue)
                query = query.Where(o => o.OrderDate <= endDate.Value.Date);

            if (!string.IsNullOrWhiteSpace(search))
                query = query.Where(o => o.CustomerName.Contains(search));

            return await query.ToListAsync();
        }
    }
}
