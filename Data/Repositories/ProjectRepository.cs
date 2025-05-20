using Data.Contexts;
using Data.Entities;
using Data.Interfaces.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Data.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<ProjectEntity> _dbSet;

        public ProjectRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<ProjectEntity>();
        }

        public async Task<ProjectEntity> CreateAsync(ProjectEntity projectEntity)
        {
            if (projectEntity == null) { return null!; }
            try
            {
                await _dbSet.AddAsync(projectEntity);
                await _context.SaveChangesAsync();
                return projectEntity;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error creating project: {ex.Message}");
                return null!;
            }
        }
        public async Task<IEnumerable<ProjectEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
        public async Task<ProjectEntity> UpdateAsync(int id, ProjectEntity projectEntity)
        {
            if(projectEntity == null) { return null!; }
            try
            {
                var existingProject = await _dbSet.FindAsync(id);
                if (existingProject == null) { return null!; }
                _context.Entry(existingProject).CurrentValues.SetValues(projectEntity);
                await _context.SaveChangesAsync();
                return existingProject;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error updating project: {ex.Message}");
                return null!;
            }
        }
        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var existingProject = await _dbSet.FindAsync(id);
                if (existingProject == null) return false;

                _dbSet.Remove(existingProject);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception ex)
            {

                Debug.WriteLine($"error deleting project entity :: {ex.Message}");
                return false!;
            }

        }
    }
    
}
