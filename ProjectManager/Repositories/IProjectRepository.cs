using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectManager.Models;

namespace ProjectManager.Repositories
{
    public interface IProjectRepository
    {
        Task<IEnumerable<Project>> GetAllProjects();
        Task<Project> GetProjectById(int id);
        Task AddProject(Project project);
        Task UpdateProject(Project project);
        Task DeleteProject(int id);
    }
}
