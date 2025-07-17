using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IOrderService
{
    Task<List<Order>> GetOrders(DateTime? startDate, DateTime? endDate, string? search = null);
}
