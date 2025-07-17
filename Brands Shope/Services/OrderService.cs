public class OrderService
{
    private List<Order> orders = new()
    {
        new Order { Id = 1, CustomerName = "Ahmad", OrderDate = new DateTime(2025, 7, 10), TotalAmount = 150.75m },
        new Order { Id = 2, CustomerName = "Lina", OrderDate = new DateTime(2025, 7, 9), TotalAmount = 220.00m },
        new Order { Id = 3, CustomerName = "Yousef", OrderDate = new DateTime(2025, 7, 8), TotalAmount = 99.99m },
        new Order { Id = 4, CustomerName = "Salma", OrderDate = new DateTime(2025, 7, 7), TotalAmount = 310.20m },
        new Order { Id = 5, CustomerName = "Omar", OrderDate = new DateTime(2025, 7, 6), TotalAmount = 185.40m },
        new Order { Id = 6, CustomerName = "Sara", OrderDate = new DateTime(2025, 7, 5), TotalAmount = 250.00m },
        new Order { Id = 7, CustomerName = "Maya", OrderDate = new DateTime(2025, 7, 4), TotalAmount = 70.25m },
        new Order { Id = 8, CustomerName = "Khaled", OrderDate = new DateTime(2025, 7, 3), TotalAmount = 440.00m },
        new Order { Id = 9, CustomerName = "Nour", OrderDate = new DateTime(2025, 7, 2), TotalAmount = 199.95m },
        new Order { Id = 10, CustomerName = "Tariq", OrderDate = new DateTime(2025, 7, 1), TotalAmount = 135.60m }
    };

    public Task<List<Order>> GetOrders(DateTime? startDate, DateTime? endDate, string? search = null)
    {
        var filtered = orders.Where(o =>
            (!startDate.HasValue || o.OrderDate >= startDate.Value.Date) &&
            (!endDate.HasValue || o.OrderDate <= endDate.Value.Date) &&
            (string.IsNullOrWhiteSpace(search) || o.CustomerName.Contains(search, StringComparison.OrdinalIgnoreCase))
        ).ToList();

        return Task.FromResult(filtered);
    }
}
