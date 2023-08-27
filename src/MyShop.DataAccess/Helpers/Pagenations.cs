namespace MyShop.DataAccess.Helpers;

public class Pagenations
{
    public int PageNumber { get; set; }

    public int MaxPageSize = 30;

    public Pagenations(int pageNumber)
    {
        PageNumber = pageNumber;
    }

    public int GetPageNumber
    {
        get { return (PageNumber - 1) * MaxPageSize; }
    }
}
