using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.Services;
using System.Diagnostics;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProjectsRepository _projectsRepository;
        private readonly ISkillsRepository _skillsRepository;
        private readonly IEmailService _emailService;

        public HomeController(ILogger<HomeController> logger,
                              IProjectsRepository projectsRepository,
                              ISkillsRepository skillsRepository,
                              IEmailService emailService)
        {
            _logger = logger;
            _projectsRepository = projectsRepository;
            _skillsRepository = skillsRepository;
            _emailService = emailService;
        }

        public IActionResult Index()
        {
            //ViewBag.Name = "Alonso Ugalde Aguilar";
            //return View("Index", "Alonso Ugalde Aguilar");
            var projects = _projectsRepository.GetProjects().Take(3).ToList();
            var skills = _skillsRepository.GetSkills().ToArray();

            HomeIndexViewModel modelo = new()
            {
                Projects = projects,
                Skills = skills,
            };
            return View(modelo);
        }

        public IActionResult Projects()
        {
            var projects = _projectsRepository.GetProjects();
            return View(projects);
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contact(ContactViewModel contactViewModel)
        {
            await _emailService.Send(contactViewModel);
            return RedirectToAction("Thanks");
        }

        public IActionResult Thanks()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}