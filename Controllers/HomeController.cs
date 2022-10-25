using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebSecurityXSS.Data;
using WebSecurityXSS.Models;
using WebSecurityXSS.ViewModel;

namespace WebSecurityXSS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
      
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ParameterTempring(PersonViewModel personViewModel)
        {
            Person person = new Person
            {
                Id = personViewModel.Person.Id,
                Search = personViewModel.Search
            };
            PersonDBContext personDB = new PersonDBContext();
            personDB.Add(person);
            
            return View();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}