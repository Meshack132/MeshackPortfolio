using Microsoft.AspNetCore.Mvc;
using MeshackPortfolio.Models;

namespace MeshackPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Skills()
        {
            var skills = new List<Skill>
            {
                new Skill { Category = "Programming Languages", Skills = new List<string> { "C#", "Python", "SQL" } },
                new Skill { Category = "DevOps Tools", Skills = new List<string> { "Azure DevOps", "Terraform", "Docker" } }
            };
            return View(skills);
        }

        public IActionResult Projects()
        {
            var projects = new List<Project>
            {
                new Project { Title = "MyVoting App", Description = "Secure voting app with authentication.", Technologies = "Java, Spring", GitHubLink = "https://github.com/Meshack132/Myvoting" }
            };
            return View(projects);
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
