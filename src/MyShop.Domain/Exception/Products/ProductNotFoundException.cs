namespace MyShop.Domain.Exceptions.Products;

public class ProductNotFoundException : NotFoundException
{
    public ProductNotFoundException()
    {
        Exception = "Product not found !";
    }
}