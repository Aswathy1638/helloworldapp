using ECommerceApplication;

public class ProductService
{
    private readonly ECommerceDbContext _dbContext;

    public ProductService(ECommerceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    // Create a new product
    public void CreateProduct(Product product)
    {
        _dbContext.Products.Add(product);
        _dbContext.SaveChanges();
    }

    // Read a product's details
    public Product GetProduct(int productId)
    {
        return _dbContext.Products.Find(productId);
    }

    // Update a product's details
    public void UpdateProduct(Product product)
    {
        _dbContext.Products.Update(product);
        _dbContext.SaveChanges();
    }

    // Delete a product
    public void DeleteProduct(int productId)
    {
        var product = _dbContext.Products.Find(productId);
        if (product != null)
        {
            _dbContext.Products.Remove(product);
            _dbContext.SaveChanges();
        }
    }
}
