using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.DataAccess.Interfaces
{
    public interface IGetAllData<TModel>
    {
        public Task<IEnumerable<TModel>> GetAllDataAsync(TModel model);
    }
}
