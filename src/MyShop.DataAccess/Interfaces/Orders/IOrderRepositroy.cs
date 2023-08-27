using MyShop.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.DataAccess.Interfaces.Orders
{
    public interface IOrderRepositroy : IBaseRepository<Order>, IGetAllData<Order>, ISearchForPage<Order>
    {
    }
}
