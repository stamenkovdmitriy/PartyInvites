using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    // класс подверждающий ответ наприглашение
    public class GuestResponse
    {
        [Required(ErrorMessage ="Please enter your name")]
        // Пожалуйста введите свое имя
        public string Name { get; set; }

        [Required(ErrorMessage ="Please enter your eemail address")]
        [EmailAddress]
        // Пожалуйста введите адре электронной почты
        public string Email { get; set; }

        [Required(ErrorMessage ="Pleaseenter your phone number")]
        // Пожалуйста введите номер телефона
        public string Phone { get; set; }

        [Required(ErrorMessage ="Please specify whether you'll attend")]
        // Пожалуйста укажите примите ли вы участие
        public bool? WillAttend { get; set; } 
    }
}
