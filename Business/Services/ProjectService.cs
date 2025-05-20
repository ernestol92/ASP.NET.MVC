using Data.Entities;
using Data.Interfaces.IRepository;

namespace Business.Services;

public class ProjectService : IProjectService
{
    private readonly IProjectRepository _projectRepository;

    public ProjectService(IProjectRepository projectRepository)
    {
        _projectRepository = projectRepository;
    }

    public async Task<ProjectEntity?> CreateProjectAsync(ProjectEntity projectEntity)
    {
        return await _projectRepository.CreateAsync(projectEntity);
    }

    public async Task<IEnumerable<ProjectEntity>> GetAllProjectsAsync()
    {
        return await _projectRepository.GetAllAsync();
    }

 

    public async Task<ProjectEntity?> UpdateProjectAsync(int id, ProjectEntity projectEntity)
    {
        return await _projectRepository.UpdateAsync(id, projectEntity);
    }


    public async Task<bool> DeleteProjectAsync(int id)
    {
        return await _projectRepository.DeleteAsync(id);
    }


}
