using MyShop.DataAccess.Helpers;

namespace MyShop.DataAccess.Interfaces;

public interface ISearchForPage<TModel>
{
    public Task<IList<TModel>> ForPageAsync(TModel model, Pagenations pagenations);
}
    