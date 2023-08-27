using MyShop.Domain.Entities.Orders;
using MyShop.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.DataAccess.Interfaces.Products
{
    public interface IProductRepository : IBaseRepository<Product>, IGetAllData<Product>, ISearchForPage<Product>
    {
    }
}
