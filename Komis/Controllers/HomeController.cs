using Komis.Models;
using Komis.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Komis.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISamochodRepository _samochodRepository;

        public HomeController(ISamochodRepository samochodRepository)
        {
            _samochodRepository = samochodRepository;
        }

        public IActionResult Index()
        {
            var samochody = _samochodRepository.PobierzWszystkieSamochody().OrderBy(s => s.Marka);
            var homeVM = new HomeVM()
            {
                Samochody = samochody.ToList(),
                Tytul = "Przeglad Samochodów"
            };
            return View(homeVM);
        }

        public IActionResult Szczegoly(int id)
        {
            var samochod = _samochodRepository.PobierzSamochodById(id);

            if (samochod == null)
            {
                return NotFound();
            }

            return View(samochod);
        }
    }
}