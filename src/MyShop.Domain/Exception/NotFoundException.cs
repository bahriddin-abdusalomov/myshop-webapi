using System.Net;

namespace MyShop.Domain.Exceptions;

public class NotFoundException : Exception
{
    public string Exception { get; set; } = string.Empty;

}