using System.ComponentModel.DataAnnotations;

namespace MyShop.Domain.Entities.Suppliers;

public class Supplier : BaseModel
{
    [MaxLength(50)]
    public string CompanyName { get; set; } = string.Empty;

    [MaxLength(13)]
    public string PhoneNumber { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty;

}