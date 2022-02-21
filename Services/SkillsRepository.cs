using Portfolio.Models;

namespace Portfolio.Services
{
    public class SkillsRepository : ISkillsRepository
    {
        public List<SkillsViewModel> GetSkills()
        {
            return new List<SkillsViewModel>() {
                new SkillsViewModel
                {
                    Icon = "bi bi-pc",
                    CSSClasses = "border-radius: 15px 0 0 15px; box-shadow: 0 5px 5px 0 gray",
                    Title = "Back-end",
                    Description = "Trabajo desde el desarrollo, pruebas automáticas y puesta en producción con entrega continua.",
                    Stack = "ASP.NET Core, SQL Server",
                    Experience = new string[] { "Web APIs", "ASP.NET Core MVC", "EF Core", "Blazor" },
                },
                new SkillsViewModel
                {
                    Icon = "bi bi-display",
                    CSSClasses= "box-shadow: 0 5px 5px 0 gray",
                    Title = "Front-end",
                    Description = "Desarrollo front-ends robustos los cuales cumplen con los requerimientos del negocio.",
                    Stack = "React, Blazor WASM",
                    Experience = new string[] { "React Hooks", "Blazor WASM", "HTML 5", "Vanilla JS" },
                },
                new SkillsViewModel
                {
                    Icon = "bi bi-phone",
                    CSSClasses= "border-radius: 0 15px 15px 0; box-shadow: 0 5px 5px 0 gray",
                    Title = "Mobile",
                    Description = "Creo clientes móviles multiplataforma con React Native que cumplen con las necesidades del negocio.",
                    Stack = "React Native",
                    Experience = new string[] { "React Native", },
                },
            };
        }
    }
}
