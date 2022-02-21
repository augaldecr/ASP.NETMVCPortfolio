namespace Portfolio.Models
{
    public class HomeIndexViewModel
    {
        public IEnumerable<ProjectViewModel>? Projects { get; set; }
        public IEnumerable<SkillsViewModel>? Skills { get; set; }
    }
}
