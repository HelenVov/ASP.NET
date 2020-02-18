using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Task1_MVC.Models
{
    public class GuestProfileViewModel
    {

        [DisplayName("Введите имя:")]
        [RegularExpression("[А-Я]{1}[а-я]{2,10}",
           ErrorMessage = "Имя должно начинаться с заглавной буквы, длина-мин. 3 символа, длина-макс. 10 символов.")]
        public string Name { get; set; }

        public List<QuestionViewModel> Questions { get; set; }

        public int[] Answers { get; set; }

        public bool Check { get; set; }
    }
}