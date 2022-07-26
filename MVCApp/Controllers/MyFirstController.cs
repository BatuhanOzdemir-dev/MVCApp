using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;


namespace MVCApp.Controllers
{
    public class MyFirstController : Controller
    {
        private static List<FirstViewModel> _firstModels = new List<FirstViewModel>();
        public IActionResult Index()
        {
            return View(_firstModels);
        }
        public IActionResult WorkExperience()
        {
            var fVM = new FirstViewModel();
            return View(fVM);

        }
        public IActionResult WorkExperienceInput(FirstViewModel firstViewModel)
        {
            _firstModels.Add(firstViewModel);

            return RedirectToAction(nameof(Index));

        }
    }
}
