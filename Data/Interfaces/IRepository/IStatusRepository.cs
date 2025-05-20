using Data.Entities;

namespace Data.Interfaces.IRepository
{
    public interface IStatusRepository
    {
        Task<IEnumerable<StatusEntity>> GetAllStatusesAsync();
    }
}