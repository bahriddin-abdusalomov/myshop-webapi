using MyShop.Domain.Entities.Orders;
using System.ComponentModel.DataAnnotations;

namespace MyShop.Domain.Entities.Shippers;

public class Shipper
{
    [MaxLength(50)]
    public string CompanyName { get; set; } = string.Empty;

    [MaxLength(13)]
    public string Contact { get; set; } = string.Empty;

    #region Connection 

    public long OrderId { get; set; }
    public ICollection<Order> Orders { get; set; } = new List<Order>();

    #endregion
}