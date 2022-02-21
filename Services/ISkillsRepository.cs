using Portfolio.Models;

namespace Portfolio.Services
{
    public interface ISkillsRepository
    {
        List<SkillsViewModel> GetSkills();
    }
}