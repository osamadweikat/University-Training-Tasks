using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class OrderService : IOrderService
{
    private readonly HttpClient _http;

    public OrderService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<Order>> GetOrders(DateTime? startDate, DateTime? endDate, string? search = null)
    {
        string url = $"api/Orders?";

        if (startDate.HasValue)
            url += $"startDate={startDate.Value:yyyy-MM-dd}&";
        if (endDate.HasValue)
            url += $"endDate={endDate.Value:yyyy-MM-dd}&";
        if (!string.IsNullOrWhiteSpace(search))
            url += $"search={search}&";

        url = url.TrimEnd('&');

        var orders = await _http.GetFromJsonAsync<List<Order>>(url);
        return orders ?? new List<Order>();
    }
}
