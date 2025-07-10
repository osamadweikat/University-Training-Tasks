public interface IProductService
{
    Task<List<Brand>> GetBrands();
    Task<List<Product>> GetProductsByBrand(int brandId);
    Task<Product?> GetProductById(int productId); 
}
