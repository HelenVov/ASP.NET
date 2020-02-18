using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Task1_MVC.Models
{
    public class RecallDataViewModel
    {
        [Required]
        [DisplayName("Введите имя:")]
        [RegularExpression("[А-Я]{1}[а-я]{2,10}",
            ErrorMessage = "Имя должно начинаться с заглавной буквы, длина-мин. 3 символа, длина-макс. 10 символов.")]
        public string Name { get; set; }

        public DateTime Time { get; set; } = DateTime.UtcNow;

        [Required]
        [DisplayName("Введите отзыв:")]
        [StringLength(maximumLength: 50, MinimumLength = 10)]
        public string Text { get; set; }
    }
}