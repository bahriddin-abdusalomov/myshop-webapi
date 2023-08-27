using MyShop.Domain.Entities.Orders;
using MyShop.Domain.Entities.Suppliers;

namespace MyShop.Domain.Entities.Products;

public class Product : Auditable
{
    public string Name { get; set; } = string.Empty;
    public string ImagePath { get; set; } = string.Empty;
    public double Price { get; set; }
    public string Description { get; set; } = string.Empty;

    #region Connection 

    public long SupplierId { get; set; }
    public ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();

    public long OrderId { get; set; }
    public ICollection<Order> Orders { get; set; } = new List<Order>();

    #endregion
}