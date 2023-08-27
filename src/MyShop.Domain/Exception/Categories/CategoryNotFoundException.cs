
namespace MyShop.Domain.Exceptions.Categories;

public class CategoryNotFoundException : NotFoundException
{
    public CategoryNotFoundException()
    {
        Exception = "Category not found !";
    }
}