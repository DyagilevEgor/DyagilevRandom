using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using DyagilevRandom.Pages.Models;

namespace DyagilevRandom.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public RandomizerModel Randomizer { get; set; } = new RandomizerModel();
        public object RandomizedValue { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            // Проверка режима
            if (Randomizer.SelectedMode == "range")
            {
                var random = new Random();
                RandomizedValue = random.Next(Randomizer.MinValue, Randomizer.MaxValue + 1);
            }
            else if (Randomizer.SelectedMode == "list")
            {
                // Генерация случайного значения из списка
                var inputValues = Randomizer.ListInput
                    .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .Distinct()
                    .ToList();

                if (inputValues.Count > 0)
                {
                    var random = new Random();
                    RandomizedValue = inputValues[random.Next(inputValues.Count)];
                }
            }
        }
    }
}