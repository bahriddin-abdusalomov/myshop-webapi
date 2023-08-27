using MyShop.Domain.Entities.Products;
using System.ComponentModel.DataAnnotations;

namespace MyShop.Domain.Entities.Categories;

public class Category : Auditable
{

    [MaxLength(50)]
    public string Name { get; set; } = String.Empty;

    public string Description { get; set; } = String.Empty;

    public string ImagePath { get; set; } = String.Empty;


    #region Connection 

    public long ProductId { get; set; }
    public ICollection<Product> Products { get; set; } = new List<Product>();

    #endregion

}