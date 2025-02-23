using Microsoft.EntityFrameworkCore;
using ProjectManager.Data;
using ProjectManager.Models;

namespace ProjectManager.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ApplicationDbContext _context;

        public ProjectRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Project>> GetAllProjects()
        {
            return await _context.Projects.ToListAsync();
        }

        public async Task<Project> GetProjectById(int id)
        {
            return await _context.Projects.FindAsync(id);
        }

        public async Task AddProject(Project project)
        {
            _context.Projects.Add(project);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProject(Project project)
        {
            _context.Projects.Update(project);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProject(int id)
        {
            var project = await _context.Projects.FindAsync(id);
            if (project != null)
            {
                _context.Projects.Remove(project);
                await _context.SaveChangesAsync();
            }
        }
    }
}
