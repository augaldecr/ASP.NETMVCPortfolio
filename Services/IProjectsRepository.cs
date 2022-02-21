using Portfolio.Models;

namespace Portfolio.Services
{
    public interface IProjectsRepository
    {
        List<ProjectViewModel> GetProjects();
    }
}