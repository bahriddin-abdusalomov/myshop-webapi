namespace MyShop.Domain.Exceptions.Suppliers;

public class SupplierNotFoundException :NotFoundException
{
    public SupplierNotFoundException()
    {
        Exception = "Supplier not found !";
    }
}