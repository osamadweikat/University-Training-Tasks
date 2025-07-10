using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

public class ProductService : IProductService
{
    private readonly HttpClient http;

    public ProductService(HttpClient http)
    {
        this.http = http;
    }

    public async Task<List<Brand>> GetBrands()
    {
        var brands = await http.GetFromJsonAsync<List<Brand>>("api/Brands");
        return brands ?? new List<Brand>();
    }

    public async Task<List<Product>> GetProductsByBrand(int brandId)
    {
        var products = await http.GetFromJsonAsync<List<Product>>($"api/Products/brand/{brandId}");
        return products ?? new List<Product>();
    }

    public async Task<Product?> GetProductById(int productId)
    {
        return await http.GetFromJsonAsync<Product>($"api/Products/{productId}");
    }
}
