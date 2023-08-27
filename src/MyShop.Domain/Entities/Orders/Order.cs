namespace MyShop.Domain.Entities.Orders;

public class Order : Auditable
{
    public DateTime OrderDate { get; set; }
    public DateTime RequireDate { get; set; }
    public DateTime ShippedDate { get; set; }
    public string Country { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty;

}