using LearningByDoing.Models.IRepository;
using LearningByDoing.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace LearningByDoing.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository pieRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly string title = "Learning By Doing";

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            this.pieRepository = pieRepository;
            this.categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            ListViewModels viewModels = new ListViewModels(this.pieRepository.AllPies, title);
            return View(viewModels);
        }
    }
}
