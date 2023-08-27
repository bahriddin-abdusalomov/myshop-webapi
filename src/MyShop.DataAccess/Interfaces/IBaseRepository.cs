namespace MyShop.DataAccess.Interfaces;

public interface IBaseRepository<TEntityModel>
{
    public Task<int> CreateAsync(TEntityModel entity);
    public Task<int> UpdateAsync(long id);
    public Task<int> DeleteAsync(long id);
    public Task<int> GetByIdAsync(long id);
    
}
