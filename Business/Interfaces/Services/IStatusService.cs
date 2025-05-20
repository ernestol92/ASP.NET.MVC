using Data.Entities;

namespace Business.Interfaces.Services
{
    public interface IStatusService
    {
        Task<IEnumerable<StatusEntity>> GetStatusList();
    }
}