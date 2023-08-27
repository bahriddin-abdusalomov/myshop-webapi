using MyShop.Domain.Entities.Orders;
using System.ComponentModel.DataAnnotations;

namespace MyShop.Domain.Entities.Customers;

public class Customer : Auditable
{
    [MaxLength(50)]
    public string FirstName { get; set; } = String.Empty;

    [MaxLength(50)]
    public string LastName { get; set; } = String.Empty;

    public DateOnly BirthDate { get; set; }

    public string Country { get; set; } = String.Empty;

    public string Region { get; set; } = String.Empty;

    [MaxLength(13)]
    public string PhoneNumber { get; set; } = String.Empty;


    #region Connection 

    public long OrderId { get; set; }
    public ICollection<Order> Orders { get; set; } = new List<Order>();

    #endregion
}