using MyShop.Domain.Entities.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.DataAccess.Interfaces.Categories
{
    public interface CategoryRepository : IBaseRepository<Category>, IGetAllData<Category>
    {
    }
}
