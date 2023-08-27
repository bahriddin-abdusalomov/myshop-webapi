namespace MyShop.Domain.Exceptions.Shippers;

public class ShipperNotFoundException : NotFoundException
{
    public ShipperNotFoundException()
    {
        Exception = "Shipper not found !";
    }
}