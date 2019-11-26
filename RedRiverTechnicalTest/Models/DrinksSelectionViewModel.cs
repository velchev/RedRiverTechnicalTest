using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using RedRiverTechnicalTest.Domain;

namespace RedRiverTechnicalTest.Models
{
    public class DrinksSelectionViewModel
    {
        public class Drink
        {
            public string Name { get; set; }
        }

        [Required]
        [Display(Name = "Hot Drink")]
        public string SelectedDrink { get; set; }
        private readonly List<Drink> _drinks = new List<Drink>
        {
            new Drink{Name = DrinksNames.LemonTea},
            new Drink{Name = DrinksNames.Coffee},
            new Drink{Name = DrinksNames.Chocolate}
        };

        public IEnumerable<SelectListItem> AvailableDrinks => new SelectList(_drinks, "Name", "Name");
    }
}