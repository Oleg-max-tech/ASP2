using System.ComponentModel.DataAnnotations;

namespace ASP2.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ім'я є обов'язковим")]
        public string Name { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Зарплата має бути більшою за 0")]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = "Посада є обов'язковою")]
        public string Position { get; set; }
    }
}
