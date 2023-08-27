namespace MyShop.Domain.Entities;

public class Auditable : BaseModel
{
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}