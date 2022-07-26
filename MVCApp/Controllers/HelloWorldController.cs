using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;


namespace MVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();
        public IActionResult Index()
        {
            //DogViewModel doggy = new DogViewModel()
            //{
            //    Age = 9, 
            //    Name = "Chris"
            //};
            return View(dogs);
        }
        public IActionResult Create()
        {
            var dogVM = new DogViewModel();
            return View(dogVM);
        }
        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            //return View("Index");
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }
    }
}
