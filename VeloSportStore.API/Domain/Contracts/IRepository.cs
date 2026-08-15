namespace VeloSportStore.API.Domain.Contracts
{
    public interface IRepository<ID, TValue>
    {
        Task<IEnumerable<TValue>> GetAllAsync();
        Task<TValue> GetByIdAsync(ID uuid);
        Task CreateAsync(TValue entity);
        Task UpdateAsync(ID uuid, TValue entity);
        Task DeleteAsync(ID uuid);
    }
}
