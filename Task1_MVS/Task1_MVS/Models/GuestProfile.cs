using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Task1_MVS.Models
{
    public class GuestProfile
    {

        [DisplayName("Введите имя:")]
        [RegularExpression("[А-Я]{1}[а-я]{2,10}",
           ErrorMessage = "Имя должно начинаться с заглавной буквы, длина-мин. 3 символа, длина-макс. 10 символов.")]
        public string Name { get; set; }
        
        public List<Question> Questions { get; set; }

        public int[] Answers { get; set; }

        public bool Check { get; set; }
    }
}