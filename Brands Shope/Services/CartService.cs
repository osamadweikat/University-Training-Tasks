public class CartService
{
    private List<Product> cartItems = new();

    public IReadOnlyList<Product> CartItems => cartItems;

    public void AddToCart(Product product)
    {
        cartItems.Add(product);
    }

    public void RemoveFromCart(Product product)
    {
        cartItems.Remove(product);
    }

    public decimal GetTotalPrice()
    {
        return cartItems.Sum(p => p.Price);
    }
}
