using System.Collections.Generic;

namespace DyagilevRandom.Pages.Models
{
    public class RandomizerModel
    {
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public string ListInput { get; set; } // Ввод списка значений
        public string SelectedMode { get; set; } // Режим выбора (диапазон или список)
    }
}