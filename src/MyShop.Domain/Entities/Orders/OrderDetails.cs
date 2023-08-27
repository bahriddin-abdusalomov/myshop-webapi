namespace MyShop.Domain.Entities.Orders;

public class OrderDetails : BaseModel
{
    public double UnitPrice { get; set; }
    public long Quantity { get; set; }

    #region Connection 

    public long OrderId { get; set; }
    public ICollection<Order> Orders { get; set; } = new List<Order>();

    #endregion
}