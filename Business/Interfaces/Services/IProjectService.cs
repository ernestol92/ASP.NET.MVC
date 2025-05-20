using Data.Entities;

namespace Business.Services;

public interface IProjectService
{
    Task<IEnumerable<ProjectEntity>> GetAllProjectsAsync();
    Task<ProjectEntity?> CreateProjectAsync(ProjectEntity entity);
    Task<ProjectEntity?> UpdateProjectAsync(int id, ProjectEntity entity);
    Task<bool> DeleteProjectAsync(int id);
}
