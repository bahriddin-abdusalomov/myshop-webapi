using MyShop.Domain.Entities.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.DataAccess.Interfaces.Customers
{
    public interface ICustomerRepository : IBaseRepository<Customer> , IGetAllData<Customer>
    {
    }
}
