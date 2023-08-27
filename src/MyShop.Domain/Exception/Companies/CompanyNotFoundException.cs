namespace MyShop.Domain.Exceptions.Companies;

public class CompanyNotFoundException : NotFoundException
{
    public CompanyNotFoundException()
    {
        Exception = "Company not found !";
    }
}