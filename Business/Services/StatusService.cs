using Business.Interfaces.Services;
using Data.Entities;
using Data.Interfaces.IRepository;
using Data.Repositories;

namespace Business.Services;

public class StatusService : IStatusService
{
    private readonly IStatusRepository _statusRepository;

    public StatusService(IStatusRepository statusRepository)
    {
        _statusRepository = statusRepository;
    }

    public async Task<IEnumerable<StatusEntity>> GetStatusList()
    {
        return await _statusRepository.GetAllStatusesAsync();
    }
}
