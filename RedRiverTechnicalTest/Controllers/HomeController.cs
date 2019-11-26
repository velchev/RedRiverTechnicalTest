using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RedRiverTechnicalTest.Domain;
using RedRiverTechnicalTest.Models;

namespace RedRiverTechnicalTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new DrinksSelectionViewModel());
        }

        [HttpPost]
        public IActionResult Index(DrinksSelectionViewModel drinksSelectionViewModel)
        {
            var selectedDrink = drinksSelectionViewModel.SelectedDrink;
            var builder = GetBuilderForSelectedHotDrink(selectedDrink);
            if (builder == null)
            {
                //TODO: UI error handling
                ViewBag.Errors = new List<string>(new List<string> {"can not handle the creation of selected hot drink"});
                return View(new DrinksSelectionViewModel());
            }

            var hotDrinksMachine = new HotDrinksMachine(builder);
            hotDrinksMachine.MakeDrink();
            var drink = hotDrinksMachine.GetDrink();
            ViewBag.ActionsPerformedDuringOperation = drink.GetActionsPerformedDuringOperation();

            return View(new DrinksSelectionViewModel
            {
                SelectedDrink = drinksSelectionViewModel.SelectedDrink,
            });
        }

        private static HotDrinkBuilder GetBuilderForSelectedHotDrink(string selectedDrink)
        {
            HotDrinkBuilder builder = null;
            if (selectedDrink == DrinksNames.LemonTea)
            {
                builder = new LemonTeaBuilder();
            }
            else if (selectedDrink == DrinksNames.Coffee)
            {
                builder = new CoffeeBuilder();
            }
            else if (selectedDrink == DrinksNames.Chocolate)
            {
                builder = new ChocolateBuilder();
            }

            return builder;
        }

        public IActionResult Privacy()
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
