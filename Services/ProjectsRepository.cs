using Portfolio.Models;

namespace Portfolio.Services
{
    public class ProjectsRepository : IProjectsRepository
    {
        public List<ProjectViewModel> GetProjects()
        {
            return new List<ProjectViewModel>() {
                new ProjectViewModel
                {
                    Title = "SIRIMEP 2022",
                    Description = "SIstema para la Recopilación de Información de la evaluación de los aprendizajes del Ministerio de Educación Pública adaptado al REA 2019",
                    Link = "https://sirimep.mep.go.cr/",
                    ImageURL = "/images/SIRIMEP2021.png"
                },
                    new ProjectViewModel
                {
                    Title = "SIRIMEP 2021",
                    Description = "SIstema para la Recopilación de Información de la evaluación de los aprendizajes del Ministerio de Educación Pública",
                    Link = "https://sirimep.mep.go.cr/",
                    ImageURL = "/images/SIRIMEP2021.png"
                },
                 new ProjectViewModel
                {
                    Title = "AprendizApp (Cliente móvil multiplataforma con React Native)",
                    Description = "Cliente móvil multiplataforma para el acceso a recursos educativos multimedia mediante códigos QR para el Ministerio de Educación Pública de Costa Rica",
                    Link = "http://aprendizapp.mep.go.cr/",
                    ImageURL = "/images/AprendizApp.png"
                },
                    new ProjectViewModel
                {
                    Title = "AprendizApp (Backend y sistema de gestión)",
                    Description = "Sistema para la gestión de recursos educativos multimedia y acceso mediante códigos QR para el Ministerio de Educación Pública de Costa Rica",
                    Link = "http://aprendizapp.mep.go.cr/",
                    ImageURL = "/images/AprendizApp.png"
                },
                    new ProjectViewModel
                {
                    Title = "MEP Teams",
                    Description = "Aplicación PWA para la gestión de grupos de Teams, adaptada al contexto de los docentes del Ministerio de Educación Pública de Costa Rica",
                    Link = "Offline",
                    ImageURL = "/images/MEPTeamsPIAD.png"
                },
                    new ProjectViewModel
                {
                    Title = "Sistema para la generación del Informa Descriptivo de Logros 2020",
                    Description = "Sistema para la evaluación de los aprendizajes y generación del Informe Descriptivo de Logros",
                    Link = "Offline",
                    ImageURL = "/images/IDL2020.png"
                },
                 new ProjectViewModel
                {
                    Title = "Aula Virtual 2020 (prueba de concepto)",
                    Description = "Sistema LMS con integración a Office 365",
                    Link = "Offline",
                    ImageURL = "/images/AulaVirtual.png"
                },
                 new ProjectViewModel
                {
                    Title = "Aula Virtual 2020 (prueba de concepto) (App para Microsoft Teams)",
                    Description = "Sistema LMS con integración a Office 365 en formato de app para Microsoft Teams",
                    Link = "Offline",
                    ImageURL = "/images/AulaVirtualTeams.png"
                },
            };
        }
    }
}
