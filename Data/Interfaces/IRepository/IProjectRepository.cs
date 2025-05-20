using Data.Entities;

namespace Data.Interfaces.IRepository;

public interface IProjectRepository
{
    Task<ProjectEntity> CreateAsync(ProjectEntity projectEntity);

    Task<ProjectEntity> UpdateAsync(int id, ProjectEntity projectEntity);

    Task <IEnumerable<ProjectEntity>> GetAllAsync();

    Task<bool> DeleteAsync(int id);


}
