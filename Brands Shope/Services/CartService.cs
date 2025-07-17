using System.Net.Http.Json;
using Brands_Shope.Models;

namespace Brands_Shope.Services
{
    public class CartService
    {
        private readonly HttpClient _http;

        public CartService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<CartItem>> GetCartItems()
        {
            return await _http.GetFromJsonAsync<List<CartItem>>("api/cart") ?? new List<CartItem>();
        }

        public async Task AddToCart(int productId)
        {
            var response = await _http.PostAsJsonAsync("api/cart", new { ProductId = productId });
            response.EnsureSuccessStatusCode();
        }

        public async Task UpdateQuantity(int cartItemId, int newQuantity)
        {
            var response = await _http.PutAsJsonAsync($"api/cart/{cartItemId}", newQuantity);
            response.EnsureSuccessStatusCode();
        }

        public async Task RemoveFromCart(int cartItemId)
        {
            var response = await _http.DeleteAsync($"api/cart/{cartItemId}");
            response.EnsureSuccessStatusCode();
        }

        public async Task<decimal> GetTotalPrice()
        {
            var items = await GetCartItems();
            return items.Sum(i => i.Product?.Price * i.Quantity ?? 0);
        }
    }
}
